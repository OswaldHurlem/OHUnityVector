# coding: interpy
import itertools

'''
MAJOR TODOS
- Inspectors
- Certain Bounds/Ray/Rect functionality, especially:
    - Rectangle overlap
    - Enumerate corners of rectangle
    - De/Normalize point within rectangle
    - Ray.GetPoint()
    - Point in integer rect to index
    - Point in integer rect to set of indices to sample from
- Certain Vector3 functions:
    - (0,0,0) and (1,1,1) vectors
    - Infinity vectors
    - Angle in degrees
    - Lerp/Delerp
    - Project (onto plane)
    - Reflect across plane
    - Spherical interpolation
'''

# TODO stb-style _IMPLEMENTATION macro
cFileBegin = '#ifndef UNITY_VECTORS'
cFileEnd = '''#define UNITY_VECTORS
#endif'''

csFileBegin = '''// Generated with oh_unity_vector_generator.py
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;

namespace OH
{
'''

csFileEnd = '}'

# For C# you can split the output into multiple files by defining outputFile_*
# which seems to help with Unity's compile times :(
# TODO allow splitting C++ file
settingsByLanguage = {
    'C' : {
        'outputFile' : r'oh_vectors_unity.h',
        'funcPrefix' : 'inline ',
        'swizzlePrefix' : 'Swizz',
        'booleanName' : 'Boolean',
        'fileBegin' : cFileBegin,
        'fileEnd' : cFileEnd
    },
    'C#' : {
        'outputFile' : r'UnityVector.cs',
        'outputFile_ops' : r'UnityVectorOperations.cs',
        'outputFile_ext' : r'UnityVectorExtensions.cs',
        'outputFile_swizzle' : r'UnityVectorSwizzles.cs',
        'outputFile_swizzle_ext' : r'UnityVectorSwizzleExtensions.cs',
        'funcPrefix' : 'public static ',
        'firstParamModifier' : 'this ',
        'booleanName' : 'Boolean',
        'extMethodClassName' : 'VecExt', # Set to None to disable
        'stdCallClassName' : 'VecOps', # Set to None to disable
        'mathClassName' : 'Arith',
        'fileBegin' : csFileBegin,
        'fileEnd' : csFileEnd
    },
}

class expando(object):
    pass

# Creating primitive definitions
def makePrimitive(
    nameByLang,
    usedInVecs = False,
    isFloatType = False,
    declareVecsInLangs = [],
    castUpTo = None,
    functionSuffixByLanguage = None,
    useForCtors = False):
        prim = expando()
        prim.nameByLang = nameByLang
        prim.usedInVecs = usedInVecs
        prim.isFloatType = isFloatType
        prim.declareVecsInLangs = declareVecsInLangs
        prim.castUpTo = castUpTo
        prim.functionSuffixByLanguage = functionSuffixByLanguage
        prim.useForCtors = useForCtors
        return prim

i64 = makePrimitive({'C' : 'Int64', 'C#' : 'Int64'})
i32 = makePrimitive({'C' : 'Int32', 'C#' : 'Int32'},   usedInVecs = True, isFloatType = False, 
    declareVecsInLangs = {'C':True, 'C#':True},  castUpTo = i64,  functionSuffixByLanguage = {'C':'I', 'C#':'I'}, useForCtors = True)
u8 = makePrimitive({'C' : 'byte', 'C#' : 'byte'},      usedInVecs = True, isFloatType = False, 
    declareVecsInLangs = {'C':True, 'C#':True},  castUpTo = i32,  functionSuffixByLanguage = {'C':'B', 'C#':'B'}, useForCtors = True)
#f64 = makePrimitive({'C' : 'double', 'C#' : 'double'}, usedInVecs = True, isFloatType = True,  
#    declareVecsInLangs = {'C':True, 'C#':True},  castUpTo = None, functionSuffixByLanguage = {'C':'D', 'C#':'D'}, useForCtors = True)
f64 = makePrimitive({'C' : 'double', 'C#' : 'double'}, isFloatType = True)
f32 = makePrimitive({'C' : 'float', 'C#' : 'float'},   usedInVecs = True, isFloatType = True,  
    declareVecsInLangs = {'C':True, 'C#':False}, castUpTo = f64,  functionSuffixByLanguage = {'C':'F', 'C#':'F'}, useForCtors = True)

# Creating vector definitions
def getSubscriptSchemes(n):
    if n == 2:
        return [['x','y']]
    if n == 3:
        return [['x','y','z']]
    if n == 4:
        return [['x','y','z','w']]

primList = [i64, i32, u8, f64, f32]

def nameVectorByLanguage(primitive, n):
    primCSharpName = primitive.nameByLang['C#']
    primAbbrev = {
        'Int64' : 'L',
        'Int32' : 'I',
        'byte' : 'B',
        'float' : '',
        'double' : 'D'
    }[primCSharpName]
    vectorName = "Vector#{primAbbrev}#{n}"
    return {'C' : vectorName, 'C#' : vectorName}

vecList = []

for prim in primList:
    if prim.usedInVecs:
        for n in xrange(2,5):
            vector = expando()
            vector.prim = prim
            vector.n = n
            vector.subSchemes = getSubscriptSchemes(n)
            vector.subs = vector.subSchemes[0]
            vecList.append(vector)
            vector.nameByLang = nameVectorByLanguage(prim, n)
            vector.declareVecsInLangs = prim.declareVecsInLangs
            vector.isFloatType = prim.isFloatType
            vector.castUpTo = None

for vector in vecList:
    for castUpCandidate in vecList:
        if (castUpCandidate.prim == vector.prim.castUpTo and castUpCandidate.n == vector.n):
            vector.castUpTo = castUpCandidate

currentLanguage = None
funcPrefix = None
swizzPrefix = None
booleanName = None
vectorFunctionClassPrefix = None
mathFunctionCallPrefix = None
# This one is a little situational
firstParamModifier = ''

# Mode 0 = n primitive parameters
# Mode 1 = 1 primitive paramter applied to all members
# Mode 2 = n-primitive vector parameter
def nameCtor(vector, prim, mode, declaration = False):
    if declaration:
        return "Mk#{vector.name}" + ('' if (vector.prim == prim) else prim.fSuffix)
    return vectorFunctionClassPrefix + "Mk#{vector.name}" + ('' if (vector.prim == prim) else prim.fSuffix)

indentStack = []
indentSum = 0

currentFile = None

def pushIndent(indent):
    global indentSum
    indentStack.append(indent)
    indentSum += indent
    return True

def popIndent():
    global indentSum
    indentSum -= indentStack.pop()

def indStr(indent):
    return '    ' * indent

def OUT(string):
    lines = string.splitlines() if not string == "" else ['\n']
    for l in lines:
        currentFile.write(indStr(indentSum) + string + '\n')

def MSG(string):
    print("/** MSG: " + string + " **/")

# Vector definitions fixed until next switchToLanguage()
def outputCtors(vector):
    for prim in primList:
        if prim.useForCtors:
            samePrimType = (vector.prim == prim)
            conversion = "(#{vector.prim.name})"
            if (prim.isFloatType) and not vector.isFloatType:
                conversion = mathFunctionCallPrefix + "Floor#{vector.prim.fSuffix}#{prim.fSuffix}"
            if 'Construct from N primitives':
                paramString = ', '.join(["#{prim.name} #{ss}" for ss in vector.subs])
                OUT("#{funcPrefix}#{vector.name} #{nameCtor(vector, prim, 0, True)}(#{paramString})")
                OUT('{')
                if pushIndent(1):
                    OUT("#{vector.name} V;")
                    for idx, ss in enumerate(vector.subs):
                        OUT("V.#{ss} = #{conversion}(#{ss});")
                    OUT("return V;")
                popIndent()
                OUT('}\n')
            if 'Construct from single value':
                OUT("#{funcPrefix}#{vector.name} #{nameCtor(vector, prim, 1, True)}(#{prim.name} A)")
                OUT('{')
                if pushIndent(1):
                    OUT("#{vector.name} V;")
                    for idx, ss in enumerate(vector.subs):
                        OUT("V.#{ss} = #{conversion}(A);")
                    OUT("return V;")
                popIndent()
                OUT('}\n')

# TODO create by copying from pointer?

def listVecMembers(vector, vecVarName):
    return ["#{vecVarName}.#{ss}" for ss in vector.subs]

# Construct from other vector type
def constructFromOtherVector(ctdVec):
    for paramVec in vecList:
        if (ctdVec.n == paramVec.n) and (ctdVec.prim != paramVec.prim):
            OUT("#{funcPrefix}#{ctdVec.name} #{nameCtor(ctdVec, paramVec.prim, 2, True)}(#{firstParamModifier}#{paramVec.name} V)")
            OUT('{')
            if pushIndent(1):
                ctorParams = ', '.join(listVecMembers(paramVec, 'V'))
                OUT("return #{nameCtor(ctdVec, paramVec.prim, 0)}(#{ctorParams});")
            popIndent()
            OUT('}\n')

def constructFromCeiling(ctdVec):
    for paramVec in vecList:
        if ((ctdVec.n == paramVec.n) and not (ctdVec.prim.isFloatType) and (paramVec.prim.isFloatType)):
            fName = "Ceil#{ctdVec.name}#{paramVec.prim.fSuffix}"
            OUT("#{funcPrefix}#{ctdVec.name} #{fName}(#{firstParamModifier}#{paramVec.name} V)")
            OUT('{')
            terms = ', '.join(["#{mathFunctionCallPrefix}Ceil#{ctdVec.prim.fSuffix}#{paramVec.prim.fSuffix}(V.#{ss})" for ss in paramVec.subs])
            if pushIndent(1):
                OUT("return #{nameCtor(ctdVec, paramVec.prim, 0)}(#{terms});")
            popIndent()
            OUT('}\n')

def getABExpressionPairs(vector):
    return zip(listVecMembers(vector, 'A'), listVecMembers(vector, 'B'))

def outputLogicalInnerProduct(funcName, innerOperator, outerOperator, vector):
    OUT("#{funcPrefix}#{booleanName} #{funcName}(#{firstParamModifier}#{vector.name} A, #{vector.name} B)")
    OUT('{')
    terms = ["(#{pair[0]} #{innerOperator} #{pair[1]})" for pair in getABExpressionPairs(vector)]
    if pushIndent(1):
        OUT("return #{terms[0]}")
        pushIndent(1)
        for term in terms[1:-1]:
            OUT("#{outerOperator} #{term}")
        OUT("#{outerOperator} #{terms[-1]};")
        popIndent()
    popIndent()
    OUT('}\n')

def outputCtorWithTerms(ctorFunc, terms, cast):
    if pushIndent(1):
        OUT("return #{ctorFunc}(")
        pushIndent(1)
        for t in terms[:-1]:
            OUT("(#{cast})(#{t}),")
        OUT("(#{cast})(#{terms[-1]}));")
        popIndent()
    popIndent()

def outputElementwiseOperation(funcName, operator, vector):
    OUT("#{funcPrefix}#{vector.name} #{funcName}(#{firstParamModifier}#{vector.name} A, #{vector.name} B)")
    OUT('{')
    terms = ["#{pair[0]} #{operator} #{pair[1]}" for pair in getABExpressionPairs(vector)]
    outputCtorWithTerms(nameCtor(vector, vector.prim, 0), terms, vector.prim.name)
    OUT('}\n')

def outputElementwiseParenth(funcName, innerFunction, vector, eligibilePrims=None):
    if (not eligibilePrims) or (vector.prim in eligibilePrims):
        OUT("#{funcPrefix}#{vector.name} #{funcName}(#{firstParamModifier}#{vector.name} A, #{vector.name} B)")
        OUT('{')
        terms = ["#{innerFunction}(#{pair[0]}, #{pair[1]})" for pair in getABExpressionPairs(vector)]
        outputCtorWithTerms(nameCtor(vector, vector.prim, 0), terms, vector.prim.name)
        OUT('}\n')

#operator-
def outputNegativeOperator(vector):
    if vector.prim != u8:
        OUT("#{funcPrefix}#{vector.name} operator-(#{vector.name} V)")
        OUT('{')
        terms = ', '.join(["-#{member}" for member in listVecMembers(vector, 'V')])
        if pushIndent(1):
            OUT("return #{nameCtor(vector, vector.prim, 0)}(#{terms});")
        popIndent()
        OUT('}\n')

#Scalar operations
def scalarOperatorFwd(operator, vector, substitute=None):
    OUT("#{funcPrefix}#{vector.name} operator#{operator}(#{vector.prim.name} A, #{vector.name} V)")
    OUT('{')
    if substitute:
        terms = ["(#{substitute}(A, V.#{ss}))" for ss in vector.subs]
    else:
        terms = ["(A #{operator} #{member})" for member in listVecMembers(vector, 'V')]
    outputCtorWithTerms(nameCtor(vector, vector.prim, 0), terms, vector.prim.name)
    OUT('}\n')

def scalarOperatorBkwd(operator, vector, substitute=None):
    OUT("#{funcPrefix}#{vector.name} operator#{operator}(#{vector.name} V, #{vector.prim.name} A)")
    OUT('{')
    if substitute:
        terms = ["(#{substitute}(V.#{ss}, A))" for ss in vector.subs]
    else:
        terms = ["(#{member} #{operator} A)" for member in listVecMembers(vector, 'V')]
    outputCtorWithTerms(nameCtor(vector, vector.prim, 0), terms, vector.prim.name)
    OUT('}\n')

def compoundPlusMinus(operator, vector):
    OUT("#{funcPrefix}#{vector.name}& operator#{operator}=(#{vector.name}& A, #{vector.name} B)")
    OUT('{')
    if pushIndent(1):
        OUT("A = A #{operator} B;")
        OUT('return A;')
    popIndent()
    OUT('}\n')

def compoundScalarMultDiv(operator, vector):
    OUT("#{funcPrefix}#{vector.name}& operator#{operator}=(#{vector.name}& V, #{vector.prim.name} A)")
    OUT('{')
    if pushIndent(1):
        OUT("V = V #{operator} A;")
        OUT('return V;')
    popIndent()
    OUT('}\n')

def dotProduct(vector, safetyCast = None):
    castExpr = '' if not safetyCast else "(#{safetyCast.name})"
    returnType = vector.prim.name if not safetyCast else safetyCast.name
    suffix = '' if not safetyCast else safetyCast.fSuffix
    OUT("#{funcPrefix}#{returnType} DotP#{suffix}(#{firstParamModifier}#{vector.name} A, #{vector.name} B)")
    OUT('{')
    terms = ["#{castExpr}(#{pair[0]} * #{pair[1]})" for pair in getABExpressionPairs(vector)]
    pushIndent(1)
    OUT("return (#{returnType})(#{terms[0]}")
    pushIndent(1)
    for t in terms[1::-1]:
        OUT("+ #{t}")
    OUT("+ #{terms[-1]});")
    popIndent()
    popIndent()
    OUT('}\n')
    if vector.castUpTo and not safetyCast:
        dotProduct(vector, vector.castUpTo.prim)

def sqLen(vector, safetyCast = None):
    castExpr = '' if not safetyCast else "#{safetyCast.name}"
    functionSuffix = '' if not safetyCast else safetyCast.fSuffix
    returnType = vector.prim.name if not safetyCast else safetyCast.name;
    OUT("#{funcPrefix}#{returnType} SqLen#{functionSuffix}(#{firstParamModifier}#{vector.name} V)")
    OUT('{')
    if pushIndent(1):
        OUT("return DotP#{functionSuffix}(V,V);")
    popIndent()
    OUT('}\n')
    if vector.castUpTo and not safetyCast:
        sqLen(vector, vector.castUpTo.prim)

# TODO add SafetyCast?
def outputManhatLength(vector):
    OUT("#{funcPrefix}#{vector.prim.name} ManhatLength(#{firstParamModifier}#{vector.name} V)")
    OUT('{')
    sumExpr = ' + '.join(listVecMembers(vector, 'V'))
    if pushIndent(1):
        OUT("return (#{vector.prim.name})(#{sumExpr});")
    popIndent()
    OUT('}\n')

def vecLength(vector, safetyCast = None):
    if vector.prim.isFloatType:
        castExpr = '' if not safetyCast else "(#{safetyCast.name})"
        functionSuffix = '' if not safetyCast else safetyCast.fSuffix
        returnType = vector.prim.name if not safetyCast else safetyCast.name
        OUT("#{funcPrefix}#{returnType} Len#{functionSuffix}(#{firstParamModifier}#{vector.name} V)")
        OUT('{')
        if pushIndent(1):
            OUT("return #{mathFunctionCallPrefix}Sqrt(SqLen#{functionSuffix}(V));")
        popIndent()
        OUT('}\n')

#norm
def outputNorm(vector):
    if vector.prim.isFloatType:
        OUT("#{funcPrefix}#{vector.name} Norm(#{firstParamModifier}#{vector.name} V)")
        OUT('{')
        if pushIndent(1):
            OUT('return V/Len(V);')
        popIndent()
        OUT('}\n')

def volume(vector, safetyCast = None):
    castExpr = "(#{vector.prim.name})" if not safetyCast else "(#{safetyCast.name})"
    functionSuffix = '' if not safetyCast else safetyCast.fSuffix
    returnType = vector.prim.name if not safetyCast else safetyCast.name
    OUT("#{funcPrefix}#{returnType} Volume#{functionSuffix}(#{firstParamModifier}#{vector.name} V)")
    OUT('{')
    prodExpr = ' * '.join(listVecMembers(vector, 'V'))
    if pushIndent(1):
        OUT("return #{castExpr}(#{prodExpr});")
    popIndent()
    OUT('}\n')
    if vector.castUpTo and not safetyCast:
        volume(vector, vector.castUpTo.prim)

def outputPow2Volume(vector, safetyCast = None):
    if not vector.prim.isFloatType:
        castExpr = "(#{vector.prim.name})" if not safetyCast else "(#{safetyCast.name})"
        functionSuffix = '' if not safetyCast else safetyCast.fSuffix
        returnType = vector.prim.name if not safetyCast else safetyCast.name
        OUT("#{funcPrefix}#{returnType} Pow2Volume#{functionSuffix}(#{firstParamModifier}#{vector.name} V)")
        OUT('{')
        prodExpr = ' + '.join(listVecMembers(vector, 'V'))
        if pushIndent(1):
            OUT("return #{mathFunctionCallPrefix}Pow2Mult(#{castExpr}1, #{castExpr}(#{prodExpr}));")
        popIndent()
        OUT('}\n')
        if vector.castUpTo and not safetyCast:
            outputPow2Volume(vector, vector.castUpTo.prim)

#cross product
def outputCrossProduct(vector):
    if vector.n == 3 and vector.prim != u8:
        OUT("#{funcPrefix}#{vector.name} CrossP(#{firstParamModifier}#{vector.name} A, #{vector.name} B)")
        OUT('{')
        if pushIndent(1):
            OUT("return #{nameCtor(vector, vector.prim, 0)}(")
            if pushIndent(1):
                OUT('(A.y * B.z) - (A.z * B.y),')
                OUT('-(A.x * B.z) + (A.z * B.x),')
                OUT('(A.x * B.y) - (A.y * B.x));')
            popIndent()
        popIndent()
        OUT('}\n')

def appendVDot(ss):
    return '0' if (ss == '_') else ('V.' + ss)

def outputSwizzles(vFrom):
    for vTo in vecList:
        if (vFrom.prim == vTo.prim):
            for ssCombo in itertools.product(vFrom.subs + ['_'], repeat=vTo.n):
                if (ssCombo.count('_') != len(ssCombo)):
                    params = map(appendVDot, ssCombo)
                    OUT("#{funcPrefix}#{vTo.name} #{swizzPrefix}#{''.join(ssCombo).upper()}" +
                        "(#{firstParamModifier}#{vFrom.name} V){ return #{nameCtor(vTo, vTo.prim, 0)}(#{', '.join(params)}); }")

def closeCurrentFile():
    if currentFile:
        currentFile.write(settingsByLanguage[currentLanguage]['fileEnd'])
        currentFile.close()

def switchToFileIfSpecified(fileKey):
    global currentFile
    global currentLanguage
    newFileName = settingsByLanguage[currentLanguage].get('outputFile' + fileKey)
    if newFileName:
        closeCurrentFile()
        currentFile = open(settingsByLanguage[currentLanguage]['outputFile' + fileKey], 'w')
        currentFile.write(settingsByLanguage[currentLanguage]['fileBegin'])


def switchToLanguage(language):
    global currentLanguage
    global currentFile
    global funcPrefix
    global firstParamModifier
    global swizzPrefix
    global booleanName
    global vectorFunctionClassPrefix
    global mathFunctionCallPrefix
    currentLanguage = language
    switchToFileIfSpecified('')
    for vector in vecList:
        vector.name = vector.nameByLang[language]
        vector.declare = vector.declareVecsInLangs[language]
    for prim in primList:
        prim.name = prim.nameByLang[language]
        prim.fSuffix = prim.functionSuffixByLanguage[language] if prim.functionSuffixByLanguage else None
    funcPrefix = settingsByLanguage[language].get('funcPrefix') or ''
    swizzPrefix = settingsByLanguage[language].get('swizzlePrefix') or ''
    booleanName = settingsByLanguage[language]['booleanName']
    vectorFunctionClassPrefix = ''
    stdCallClassName = settingsByLanguage[language].get('stdCallClassName')
    if stdCallClassName:
        vectorFunctionClassPrefix = stdCallClassName + '.'
    mathFunctionCallPrefix = ''
    mathClassName = settingsByLanguage[language].get('mathClassName')
    if mathClassName:
        mathFunctionCallPrefix = mathClassName + '.'


# Outputting C code
switchToLanguage('C')

for vector in vecList:
    if vector.declare:
        OUT("union #{vector.name}")
        OUT("{")
        pushIndent(1)
        for subScheme in vector.subSchemes:
            fieldsJoined = ', '.join(subScheme)
            OUT("struct { #{vector.prim.name} #{fieldsJoined}; };")
        OUT("#{vector.prim.name} E[#{vector.n}];")
        popIndent()
        OUT("};")
        OUT("")

for vector in vecList:
    if vector.n == 2:
        if vector.prim != u8:
            OUT("#define #{vector.name}_left    (#{vector.name}{ -1,  0 })")
            OUT("#define #{vector.name}_down    (#{vector.name}{  0, -1 })")
        OUT("#define #{vector.name}_right   (#{vector.name}{  1,  0 })")
        OUT("#define #{vector.name}_up      (#{vector.name}{  0,  1 })")
    if vector.n == 3:
        if vector.prim != u8:
            OUT("#define #{vector.name}_left    (#{vector.name}{ -1,  0,  0 })")
            OUT("#define #{vector.name}_down    (#{vector.name}{  0, -1,  0 })")
            OUT("#define #{vector.name}_back    (#{vector.name}{  0,  0, -1 })")
        OUT("#define #{vector.name}_right   (#{vector.name}{  1,  0,  0 })")
        OUT("#define #{vector.name}_up      (#{vector.name}{  0,  1,  0 })")
        OUT("#define #{vector.name}_forward (#{vector.name}{  0,  0,  1 })")
OUT("")

OUT("// Constructors from primitives. Float converts to int using floor")
for vector in vecList:
    outputCtors(vector)

OUT("// Constructors from other vectors. Float converts to int using floor")
for vector in vecList:
    constructFromOtherVector(vector)

OUT("// Constructors from ceiling rather than floor")
for vector in vecList:
    constructFromCeiling(vector)

OUT("// Equality operator")
for vector in vecList:
    outputLogicalInnerProduct('operator==', '==', '&&', vector)

OUT("// Inequality operator")
for vector in vecList:
    outputLogicalInnerProduct('operator!=', '!=', '||', vector)

OUT("// Evaluate whether all terms are greater than, less than, greater than or equal, less than or equal")
for vector in vecList:
    outputLogicalInnerProduct('StrictGt', '>', '&&', vector)

for vector in vecList:
    outputLogicalInnerProduct('StrictLt', '<', '&&', vector)

for vector in vecList:
    outputLogicalInnerProduct('StrictGte', '>=', '&&', vector)

for vector in vecList:
    outputLogicalInnerProduct('StrictLte', '<=', '&&', vector)

OUT("// Addition operator")
for vector in vecList:
    outputElementwiseOperation('operator+', '+', vector)

OUT("// Subtraction operator")
for vector in vecList:
    outputElementwiseOperation('operator-', '-', vector)

OUT("// Elementwise multiplication (equivalent to Scale() in Unity)")
for vector in vecList:
    outputElementwiseOperation('ElMult', '*', vector)

OUT("// Elementwise division. Uses floor.")
for vector in vecList:
    outputElementwiseParenth('ElDiv', mathFunctionCallPrefix + 'Div', vector)

OUT("// Elementwise division that uses ceiling instead of floor")
for vector in vecList:
    outputElementwiseParenth('ElCeilDiv', mathFunctionCallPrefix + 'CeilDiv', vector, [u8, i32, i64])

OUT("// Elementwise min/max")
for vector in vecList:
    outputElementwiseParenth('ElMin', mathFunctionCallPrefix + 'Min', vector)

for vector in vecList:
    outputElementwiseParenth('ElMax', mathFunctionCallPrefix + 'Max', vector)

OUT("// Elementwise remainder. Uses floor.")
for vector in vecList:
    outputElementwiseParenth('ElRem', mathFunctionCallPrefix + 'Rem', vector, [u8, i32, i64])

OUT("// Elementwise multiplication/division/remainder by 2^B_i")
for vector in vecList:
    outputElementwiseParenth('ElPow2Div', mathFunctionCallPrefix + 'Pow2Div', vector, [u8, i32, i64])

for vector in vecList:
    outputElementwiseParenth('ElPow2Mult', mathFunctionCallPrefix + 'Pow2Mult', vector, [u8, i32, i64])

for vector in vecList:
    outputElementwiseParenth('ElPow2Rem', mathFunctionCallPrefix + 'Pow2Rem', vector, [u8, i32, i64])

for vector in vecList:
    outputElementwiseParenth('ElPow2CeilDiv', mathFunctionCallPrefix + 'Pow2CeilDiv', vector, [u8, i32, i64])

OUT("// Negation (as in Additive Inverse) operator")
for vector in vecList:
    outputNegativeOperator(vector)

OUT("// Scalar multiplication/division operators")
for vector in vecList:
    scalarOperatorFwd('*', vector)

for vector in vecList:
    scalarOperatorFwd('/', vector, mathFunctionCallPrefix + "Div")

for vector in vecList:
    scalarOperatorBkwd('*', vector)

for vector in vecList:
    scalarOperatorBkwd('/', vector, mathFunctionCallPrefix + "Div")

OUT("// Compound assignment operators")
for vector in vecList:
    compoundPlusMinus('+', vector)

for vector in vecList:
    compoundPlusMinus('-', vector)

for vector in vecList:
    compoundScalarMultDiv('*', vector)

for vector in vecList:
    compoundScalarMultDiv('/', vector)

OUT("// Dot product")
for vector in vecList:
    dotProduct(vector)

OUT("// Square length")
for vector in vecList:
    sqLen(vector)

OUT("// Manhattan length operators (ie sum of components)")
for vector in vecList:
    outputManhatLength(vector)

OUT("// Vector length (as in, euclidean)")
for vector in vecList:
    vecLength(vector)

OUT("// Normalized vector")
for vector in vecList:
    outputNorm(vector)

OUT("// Product of components of vector")
for vector in vecList:
    volume(vector)

for vector in vecList:
    outputPow2Volume(vector)

OUT("// Cross product")
for vector in vecList:
    outputCrossProduct(vector)

OUT("// Swizzles")
for vector in vecList:
    outputSwizzles(vector)

# Outputting C# code
switchToLanguage('C#')

pushIndent(1)

# TODO include option to allow discriminated unions or other set of subscripts
# Either using explicit layout or with properties
for vector in vecList:
    if not vector.declare:
        continue
    OUT("[StructLayout(LayoutKind.Sequential, Pack=0)]")
    OUT("public struct #{vector.name} : IEquatable<#{vector.name}>")
    OUT("{")
    pushIndent(1)
    subscripts = ', '.join([ss for ss in vector.subs])
    OUT("// All state")
    OUT("public #{vector.prim.name} #{subscripts};")
    OUT("")
    OUT("// Member functions")
    if "Indexer":
        OUT("public #{vector.prim.name} this[int i]")
        OUT("{")
        if pushIndent(1):
            OUT("get")
            OUT("{")
            if pushIndent(1):
                OUT("switch (i)")
                OUT("{")
                pushIndent(1)
                for idx, ss in enumerate(vector.subs):
                    OUT("case #{idx}: { return #{ss}; }")
                OUT("default: { return #{vector.prim.name}.MaxValue; }")
                popIndent()
                OUT("}")
            popIndent()
            OUT("}")
        popIndent()
        if pushIndent(1):
            OUT("set")
            OUT("{")
            if pushIndent(1):
                OUT("switch (i)")
                OUT("{")
                pushIndent(1)
                for idx, ss in enumerate(vector.subs):
                    OUT("case #{idx}: { #{ss} = value; break; }")
                popIndent()
                OUT("}")
            popIndent()
            OUT("}")
        popIndent()
        OUT("}\n")
    if "Utility Values":
        if vector.n == 2:
            if vector.prim != u8:
                OUT("public static #{vector.name} left = #{nameCtor(vector, vector.prim, 0)}(-1,  0 );")
                OUT("public static #{vector.name} down = #{nameCtor(vector, vector.prim, 0)}( 0, -1 );")
            OUT("public static #{vector.name} right = #{nameCtor(vector, vector.prim, 0)}( 1,  0 );")
            OUT("public static #{vector.name} up    = #{nameCtor(vector, vector.prim, 0)}( 0,  1 );")
        if vector.n == 3:
            if vector.prim != u8:
                OUT("public static #{vector.name} left  = #{nameCtor(vector, vector.prim, 0)}(-1,  0,  0 );")
                OUT("public static #{vector.name} down  = #{nameCtor(vector, vector.prim, 0)}( 0, -1,  0 );")
                OUT("public static #{vector.name} back  = #{nameCtor(vector, vector.prim, 0)}( 0,  0, -1 );")
            OUT("public static #{vector.name} right   = #{nameCtor(vector, vector.prim, 0)}( 1,  0,  0 );")
            OUT("public static #{vector.name} up      = #{nameCtor(vector, vector.prim, 0)}( 0,  1,  0 );")
            OUT("public static #{vector.name} forward = #{nameCtor(vector, vector.prim, 0)}( 0,  0,  1 );")
    OUT("")
    outputLogicalInnerProduct('operator==', '==', '&&', vector)
    outputLogicalInnerProduct('operator!=', '!=', '||', vector)
    outputElementwiseOperation('operator-', '-', vector)
    outputElementwiseOperation('operator+', '+', vector)
    outputNegativeOperator(vector)
    scalarOperatorFwd('*', vector)
    scalarOperatorFwd('/', vector, mathFunctionCallPrefix + "Div")
    scalarOperatorBkwd('*', vector)
    scalarOperatorBkwd('/', vector, mathFunctionCallPrefix + "Div")
    OUT("public override string ToString()")
    OUT("{")
    if pushIndent(1):
        formatString = '"{{' + ', '.join([('{' + str(i) + '}') for i in range(0, vector.n)]) + '}}"'
        terms = ', '.join([ss for ss in vector.subs])
        OUT("return string.Format(#{formatString}, #{terms});")
    popIndent()
    OUT("}\n")
    OUT("public #{booleanName} Equals(#{vector.name} other)")
    OUT("{")
    if pushIndent(1):
        OUT("return this == other;")
    popIndent()
    OUT("}\n")
    OUT("public override #{booleanName} Equals(object obj)")
    OUT("{")
    if pushIndent(1):
        OUT("if (ReferenceEquals(null, obj)) return false;")
        OUT("return obj is #{vector.name} && Equals((#{vector.name})obj);")
    popIndent()
    OUT("}\n")
    OUT("public override int GetHashCode()")
    OUT("{")
    if pushIndent(1):
        OUT("unchecked")
        OUT("{")
        if pushIndent(1):
            OUT("int hashCode = x;")
            for ss in vector.subs:
                OUT("hashCode = (hashCode * 397) ^ #{ss};")
            OUT("return hashCode;")
        popIndent()
        OUT("}")
    popIndent()
    OUT("}")
    popIndent()
    OUT('}\n')

def outputStaticClassFunctionsCSharp():
    if (firstParamModifier == '') or (settingsByLanguage['C#'].get('stdCallClassName') == None):
        OUT("// Constructors from primitives. Float converts to int using floor")
        for vector in vecList:
            outputCtors(vector)
    OUT("// Constructors from other vectors. Float converts to int using floor")
    for vector in vecList:
        constructFromOtherVector(vector)
    OUT("// Constructors from ceiling rather than floor")
    for vector in vecList:
        constructFromCeiling(vector)
    OUT("// Evaluate whether all terms are greater than, less than, greater than or equal, less than or equal")
    for vector in vecList:
        outputLogicalInnerProduct('StrictGt', '>', '&&', vector)
    for vector in vecList:
        outputLogicalInnerProduct('StrictLt', '<', '&&', vector)
    for vector in vecList:
        outputLogicalInnerProduct('StrictGte', '>=', '&&', vector)
    for vector in vecList:
        outputLogicalInnerProduct('StrictLte', '<=', '&&', vector)
    OUT("// Elementwise multiplication (equivalent to Scale() in Unity)")
    for vector in vecList:
        outputElementwiseOperation('ElMult', '*', vector)
    OUT("// Elementwise division. Uses floor.")
    for vector in vecList:
        outputElementwiseParenth('ElDiv', mathFunctionCallPrefix + 'Div', vector)
    OUT("// Elementwise division that uses ceiling instead of floor")
    for vector in vecList:
        outputElementwiseParenth('ElCeilDiv', mathFunctionCallPrefix + 'CeilDiv', vector, [u8, i32, i64])
    OUT("// Elementwise min/max")
    for vector in vecList:
        outputElementwiseParenth('ElMin', mathFunctionCallPrefix + 'Min', vector)
    for vector in vecList:
        outputElementwiseParenth('ElMax', mathFunctionCallPrefix + 'Max', vector)
    OUT("// Elementwise remainder. Uses floor.")
    for vector in vecList:
        outputElementwiseParenth('ElRem', mathFunctionCallPrefix + 'Rem', vector, [u8, i32, i64])
    OUT("// Elementwise multiplication/division/remainder by 2^B_i")
    for vector in vecList:
        outputElementwiseParenth('ElPow2CeilDiv', mathFunctionCallPrefix + 'Pow2CeilDiv', vector, [u8, i32, i64])
    for vector in vecList:
        outputElementwiseParenth('ElPow2Div', mathFunctionCallPrefix + 'Pow2Div', vector, [u8, i32, i64])
    for vector in vecList:
        outputElementwiseParenth('ElPow2Mult', mathFunctionCallPrefix + 'Pow2Mult', vector, [u8, i32, i64])
    for vector in vecList:
        outputElementwiseParenth('ElPow2Rem', mathFunctionCallPrefix + 'Pow2Rem', vector, [u8, i32, i64])
    OUT("// Dot product")
    for vector in vecList:
        dotProduct(vector)
    OUT("// Square length")
    for vector in vecList:
        sqLen(vector)
    OUT("// Manhattan length operators (ie sum of components)")
    for vector in vecList:
        outputManhatLength(vector)
    OUT("// Vector length (as in, euclidean)")
    for vector in vecList:
        vecLength(vector)
    OUT("// Normalized vector")
    for vector in vecList:
        outputNorm(vector)
    OUT("// Product of components of vector")
    for vector in vecList:
        volume(vector)
    for vector in vecList:
        outputPow2Volume(vector)
    OUT("// Cross product")
    for vector in vecList:
        outputCrossProduct(vector)
    OUT('// Some C#-specific functions')
    for vector in vecList:
        OUT("public static #{vector.name} Select(#{firstParamModifier}#{vector.name} V, Func<#{vector.prim.name}, #{vector.prim.name}> func)")
        OUT("{")
        terms = ["func(V.#{ss})" for ss in vector.subs]
        outputCtorWithTerms(nameCtor(vector, vector.prim, 0), terms, vector.prim.name)
        OUT("}\n")
    for vector in vecList:
        OUT("public static #{vector.prim.name}[] Members(#{firstParamModifier}#{vector.name} V)")
        OUT("{")
        terms = ', '.join(["V.#{ss}" for ss in vector.subs])
        pushIndent(1)
        OUT("return new[] { #{terms} };")
        popIndent()
        OUT("}\n")
    for vector in vecList:
        OUT("public static #{vector.name} To#{vector.name}(#{firstParamModifier}System.Collections.Generic.IEnumerable<#{vector.prim.name}> list)")
        OUT("{")
        pushIndent(1)
        OUT("var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, #{vector.n}));")
        termStr = ', '.join(["array[#{idx}]" for idx in range(0, vector.n)])
        OUT("return #{nameCtor(vector, vector.prim, 0)}(#{termStr});")
        popIndent()
        OUT("}\n")

if settingsByLanguage['C#'].get('stdCallClassName'):
    className = settingsByLanguage['C#']['stdCallClassName']
    switchToFileIfSpecified('_ops')
    OUT("public static partial class #{className}")
    OUT('{')
    if pushIndent(1):
        outputStaticClassFunctionsCSharp()
    popIndent()
    OUT('}')
    switchToFileIfSpecified('_swizzle')
    OUT("public static partial class #{className}")
    OUT('{')
    if pushIndent(1):
        for vector in vecList:
            outputSwizzles(vector)
    popIndent()
    OUT('}')

if settingsByLanguage['C#'].get('extMethodClassName'):
    className = settingsByLanguage['C#']['extMethodClassName']
    firstParamModifier = settingsByLanguage['C#']['firstParamModifier']
    switchToFileIfSpecified('_ext')
    OUT("public static partial class #{className}")
    OUT('{')
    if pushIndent(1):
        outputStaticClassFunctionsCSharp()
    popIndent()
    OUT('}')
    switchToFileIfSpecified('_swizzle_ext')
    OUT("public static partial class #{className}")
    OUT('{')
    if pushIndent(1):
        for vector in vecList:
            outputSwizzles(vector)
    popIndent()
    OUT('}')

popIndent()
OUT("}")