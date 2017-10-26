# Oswald Hurlem's Unity Vector Library and Generator

## Vector as in... ?
As in a set of 2-4 numbers represention a point in 2-4-dimensional space. Not an arbitarily-sized list of arbitrarily typed values. Not what you provide to SIMD functions.

## Development/Epistemic status
I am a C++ and C# developer with five years of experience. This is the first ever library I've put out for public consumption. I am using this code in my own project, [Swedish Cubes for Unity](https://yave.handmade.network/). Some of the vector types and functions within will not just be used within Swedish Cubes but also its API, so I am interested in hashing out the details of this library with a party who intends to use it or Swedish Cubes.
Breaking changes to names and calling conventions are not out of the question. In particular, I may replace VectorI2 and VectorI3 with the Vector2Int and Vector3Int types introduced in Unity 2017.2, and then updating the naming convention of other non-float vectors to match these. I personally do not like that naming convention, so this is totally contingent upon whether Vector#Int becomes prevalent in Unity's and others' codebases.

## Description
This is a library that includes several types of non-float vector types, many operations for vector types,
and a python script to generate either more or less of them.
The vector types, and most functions, are implemented in both C++ and C#, with identical memory layouts. Unity's Vector# types are also implemented in C++. This makes writing and utilizing native code easier and more fun, as I can personally attest. Crucially, neither language's implementation is a wrapper around the other, which would prevent inlining and create slow code.

## Sample code
### C#
```C#
using OH;
using OH.Ext;

public static class Dumb
{
    public static double Example(VectorB2 byteVector)
    {
        var six = OHV.MkVectorB2(6); // (6, 6)

        return byteVector.ElRem(six) // Element-wise remainder
            .XXYY() // Swizzled to a VectorB4
            .MkVectorD4B() // Convert to a double vector
            .Volume(); // Get product of all four components;
        // All of these are available as non-extension methods as well via OHV.*
    }
}
```
### C++
```C++
#include "oh_vectors_unity.h"

double DumbExample(VectorB2 byteVector)
{
    auto six = MkVectorB2(6); // (6, 6)

    return Volume(
        MkVectorD4B(
            SwizzXXYY(
                ElRem(byteVector, six)
                )
            )
        );
}
```

## Features
* Vectors that use Byte, Int32, and Double as components.
* It's generated code, but very easy to read for the most part.
* Implements most built-in Unity functions with an (IMO) better naming scheme, plus many more.
* The added vector types do not implicitly cast
* Identical method names across each type, but no functions where they don't make sense (e.g. no normalizing integer vectors).
* Swizzles! Swizzle between any two vectors with the same component type. Allows you to use underscores to blank members out.
* Conversion from float to integer vectors rounds to -Infinity like God intended.
* All functions are pure! All functions look like functions! Say goodbye to Unity's impure .Normalize() function and sqrt-concealing .normalized property.
* Implemented as both extension methods and non-extension methods.
    * With the upgraded Mono Runtime, `using static OH.OHV;` lets you call vector operations without giving the class name.
    * `using OH.Ext;` gives you all functions as extension methods.
    * Mix and match to choose how much work Intellisense has to do. Or use both so that it's just like [UFCS](https://en.wikipedia.org/wiki/Uniform_Function_Call_Syntax)!
* Compact inspector for all vector types.

## Usage
Copy UnityVector\*.cs into your Assets folder. You will need to provide implementations for a few simple math functions. Mine can be found in ExtraMath.cs.
For C++ code, you'll need to provide the math functions as well as a few typedefs. I do this in testBuild.cpp
To use the python script, you must have Interpy installed.

## TODO
* Reimplement remaining Unity Vector functions.
* Convert integer vectors to array indices.
* Interactions with rectangles, rays, and angles.
* Improve flexibility of code generator.
* Unit tests using some established Vector library??
* Add SIMD/SOA types
* Add ISPC codegen/compatibility
* Some of the required math functions (such as Div() for float types) shouldn't be required.
* MAYBE: Generate C instead of C++
* MAYBE: Use Unity's Vector#Int types for compatibility and change naming scheme to be consistent.

## Please!!
Let me know if you are using this library, how you're using it, and what you'd like changed or added.