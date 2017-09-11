#pragma once

#include <stdint.h> 
#include <stddef.h>
#include <string.h>
#include <stdio.h>
#include <intrin.h>
#include <math.h>

typedef uint8_t   byte;
typedef uint32_t  UInt32;
typedef int32_t   Int32;
typedef int64_t   Int64;
typedef uint32_t  Boolean;

#define Min(X, Y) (((X) < (Y)) ? (X) : (Y))
#define Max(X, Y) (((X) > (Y)) ? (X) : (Y))

inline Int32 Pow2Rem(Int32 A, Int32 Pow2)
{
    return A & ((1 << Pow2) - 1);
}

inline Int32 Pow2Div(Int32 A, Int32 Pow2)
{
    return A >> Pow2;
}

inline Int32 Pow2CeilDiv(Int32 A, Int32 Pow2)
{
    return (A >> Pow2) + ((A & ((1 << Pow2) - 1)) != 0);
}

inline Int32 Pow2Mult(Int32 A, Int32 Pow2)
{
    return A << Pow2;
}

inline Int32 Pow2Mult(Int64 A, Int64 Pow2)
{
    return A << Pow2;
}

inline byte Pow2Rem(byte A, byte Pow2)
{
    return A & ((1 << Pow2) - 1);
}

inline byte Pow2Div(byte A, byte Pow2)
{
    return A >> Pow2;
}

inline byte Pow2CeilDiv(byte A, byte Pow2)
{
    return (A >> Pow2) + ((A & ((1 << Pow2) - 1)) != 0);
}

inline byte Pow2Mult(byte A, byte Pow2)
{
    return A << Pow2;
}

inline float Sqrt(float A)
{
    return sqrtf(A);
}

inline Int32 Div(Int32 A, Int32 B)
{
    Int32 q = A/B, r = A%B;
    if ((r > 0 && B < 0) || (r < 0 && B > 0))
       return q-1;
    else
       return q;
}

inline Int32 CeilDiv(Int32 A, Int32 B)
{
    return (A/B) + ((A%B!=0)
        ? !((A>0)^(B>0))
        : 0);
}

inline Int32 Rem(Int32 A, Int32 B)
{
    Int32 r = A%B;
    if ((r > 0 && B < 0) || (r < 0 && B > 0))
       return r+B;
    else
       return r;
}

inline float Div(float A, float B)
{
    return A/B;
}

inline byte Div(byte A, byte B)
{
    return A/B;
}

inline byte CeilDiv(byte A, byte B)
{
    return (A/B) + ((A%B!=0)
        ? !((A>0)^(B>0))
        : 0);
}

inline byte Rem(byte A, byte B)
{
    return A%B;
}

inline Int32 FloorIF(float x)
{
    return (Int32)floorf(x);
}

inline Int32 CeilIF(float x)
{
    return (Int32)ceilf(x);
}

inline byte FloorBF(float x)
{
    return (byte)floorf(x);
}

inline byte CeilBF(float x)
{
    return (byte)ceilf(x);
}

#include "oh_vectors_unity.h"

Int32 main()
{

}