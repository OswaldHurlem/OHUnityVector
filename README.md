# Oswald Hurlem's Unity Vector Library and Generator

## Development/Epistemic status
I am a C++ and C# developer with five years of experience. This is the first ever library I've put out for public consumption. I am not certain it is bug-free, especially when it comes to the python code generator. I am using this code in my own project, [Swedish Cubes for Unity](https://yave.handmade.network/). I am interested in hashing out the details of this library with a party who intends to use it. Breaking changes to names and calling conventions are not out of the question.

## Description
This is a library that includes several types of non-float vector types, many operations for vector types,
and a python script to generate more.
The vector types, and most functions, are implemented in both C++ and C#, with identical memory layouts. Unity's VectorN types are also implemented in C++. This makes writing and utilizing native code easier and more fun, as I can personally attest. Crucially, neither language's implementation is a wrapper around the other, which would prevent inlining and create slow code.

## Features
* It's generated code, but very easy to read for the most part.
* Implements most built-in Unity functions with an (IMO) better naming scheme, plus many more.
* No implicit casts (except for with Unity's VectorN types, which can't be helped).
* Identical method names across each type, but no functions where they don't make sense (e.g. no normalizing integer vectors).
* Swizzles! Swizzle between any two vectors with the same component type. Allows you to use underscores to blank members out.
* Conversion from float to integer vectors rounds to -Infinity like God intended.
* All functions are pure! All functions look like functions! Say goodbye to Unity's impure .Normalize() function and sqrt-concealing .normalized property.
* Implemented as both extension methods and non-extension methods.
    * With the upgraded Mono Runtime, `using static OH.VecOps` lets you call vector operations without giving the class name!
    * `using OH` gives you all functions as extention methods.
    * Mix and match to choose how much work Intellisense has to do. Or use both so that it's just like UFCS!

## Usage
Copy UnityVector*.cs into your Assets folder. You will need to provide implementations for a few simple math functions. Mine can be found in ExtraMath.cs.
For C++ code, you'll need to provide the math functions as well as a few typedefs. I do this in testBuild.cpp
To use the python script, you must have Interpy installed.

## TODO
* Reimplement remaining Unity Vector functions.
* Add custom inspectors.
* Convert integer vectors to array indices.
* Improve flexibility of code generator.
* Unit tests using some established Vector library??
* Add SIMD/SOA types
* Some of the required math functions (such as Div() for float types) shouldn't be required.
* MAYBE: Generate C instead of C++

## Please!!
Let me know if you are using this library, how you're using it, and what features you'd like me to add.