#pragma once

#include <stdint.h> 
#include <stddef.h>
#include <string.h>
#include <stdio.h>
#include <intrin.h>
#include <math.h>

typedef uint8_t   Byte;
typedef uint32_t  UInt32;
typedef int32_t   Int32;
typedef int64_t   Int64;
typedef uint32_t  Boolean;
typedef float     Single;
typedef double    Double;

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

inline Byte Pow2Rem(Byte A, Byte Pow2)
{
    return A & ((1 << Pow2) - 1);
}

inline Byte Pow2Div(Byte A, Byte Pow2)
{
    return A >> Pow2;
}

inline Byte Pow2CeilDiv(Byte A, Byte Pow2)
{
    return (A >> Pow2) + ((A & ((1 << Pow2) - 1)) != 0);
}

inline Byte Pow2Mult(Byte A, Byte Pow2)
{
    return A << Pow2;
}

inline Single Sqrt(Single A)
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

inline Single Div(Single A, Single B)
{
    return A/B;
}

inline Byte Div(Byte A, Byte B)
{
    return A/B;
}

inline Double Div(Double A, Double B)
{
    return A/B;
}

inline Byte CeilDiv(Byte A, Byte B)
{
    return (A/B) + ((A%B!=0)
        ? !((A>0)^(B>0))
        : 0);
}

inline Byte Rem(Byte A, Byte B)
{
    return A%B;
}

inline Int32 FloorIF(Single x)
{
    return (Int32)floorf(x);
}

inline Int32 CeilIF(Single x)
{
    return (Int32)ceilf(x);
}

inline Byte FloorBF(Single x)
{
    return (Byte)floorf(x);
}

inline Byte CeilBF(Single x)
{
    return (Byte)ceilf(x);
}

inline Int32 FloorID(Double x)
{
    return (Int32)floor(x);
}

inline Int32 CeilID(Double x)
{
    return (Int32)ceil(x);
}

inline Byte FloorBD(Double x)
{
    return (Byte)floor(x);
}

inline Byte CeilBD(Double x)
{
    return (Byte)ceil(x);
}

#include "oh_vectors_unity.h"

Int32 main()
{

}