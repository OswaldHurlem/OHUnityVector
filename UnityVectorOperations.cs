// Generated with oh_unity_vector_generator.py
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;

namespace OH
{
    public static partial class OHV
    {
        // Constructors from primitives. Float converts to int using floor
        public static VectorI2 MkVectorI2(Int32 x, Int32 y)
        {
            VectorI2 V;
            V.x = (Int32)(x);
            V.y = (Int32)(y);
            return V;
        }

        public static VectorI2 MkVectorI2(Int32 A)
        {
            VectorI2 V;
            V.x = (Int32)(A);
            V.y = (Int32)(A);
            return V;
        }

        public static VectorI2 MkVectorI2B(Byte x, Byte y)
        {
            VectorI2 V;
            V.x = (Int32)(x);
            V.y = (Int32)(y);
            return V;
        }

        public static VectorI2 MkVectorI2B(Byte A)
        {
            VectorI2 V;
            V.x = (Int32)(A);
            V.y = (Int32)(A);
            return V;
        }

        public static VectorI2 MkVectorI2D(Double x, Double y)
        {
            VectorI2 V;
            V.x = Arith.FloorID(x);
            V.y = Arith.FloorID(y);
            return V;
        }

        public static VectorI2 MkVectorI2D(Double A)
        {
            VectorI2 V;
            V.x = Arith.FloorID(A);
            V.y = Arith.FloorID(A);
            return V;
        }

        public static VectorI2 MkVectorI2F(Single x, Single y)
        {
            VectorI2 V;
            V.x = Arith.FloorIF(x);
            V.y = Arith.FloorIF(y);
            return V;
        }

        public static VectorI2 MkVectorI2F(Single A)
        {
            VectorI2 V;
            V.x = Arith.FloorIF(A);
            V.y = Arith.FloorIF(A);
            return V;
        }

        public static VectorI3 MkVectorI3(Int32 x, Int32 y, Int32 z)
        {
            VectorI3 V;
            V.x = (Int32)(x);
            V.y = (Int32)(y);
            V.z = (Int32)(z);
            return V;
        }

        public static VectorI3 MkVectorI3(Int32 A)
        {
            VectorI3 V;
            V.x = (Int32)(A);
            V.y = (Int32)(A);
            V.z = (Int32)(A);
            return V;
        }

        public static VectorI3 MkVectorI3B(Byte x, Byte y, Byte z)
        {
            VectorI3 V;
            V.x = (Int32)(x);
            V.y = (Int32)(y);
            V.z = (Int32)(z);
            return V;
        }

        public static VectorI3 MkVectorI3B(Byte A)
        {
            VectorI3 V;
            V.x = (Int32)(A);
            V.y = (Int32)(A);
            V.z = (Int32)(A);
            return V;
        }

        public static VectorI3 MkVectorI3D(Double x, Double y, Double z)
        {
            VectorI3 V;
            V.x = Arith.FloorID(x);
            V.y = Arith.FloorID(y);
            V.z = Arith.FloorID(z);
            return V;
        }

        public static VectorI3 MkVectorI3D(Double A)
        {
            VectorI3 V;
            V.x = Arith.FloorID(A);
            V.y = Arith.FloorID(A);
            V.z = Arith.FloorID(A);
            return V;
        }

        public static VectorI3 MkVectorI3F(Single x, Single y, Single z)
        {
            VectorI3 V;
            V.x = Arith.FloorIF(x);
            V.y = Arith.FloorIF(y);
            V.z = Arith.FloorIF(z);
            return V;
        }

        public static VectorI3 MkVectorI3F(Single A)
        {
            VectorI3 V;
            V.x = Arith.FloorIF(A);
            V.y = Arith.FloorIF(A);
            V.z = Arith.FloorIF(A);
            return V;
        }

        public static VectorI4 MkVectorI4(Int32 x, Int32 y, Int32 z, Int32 w)
        {
            VectorI4 V;
            V.x = (Int32)(x);
            V.y = (Int32)(y);
            V.z = (Int32)(z);
            V.w = (Int32)(w);
            return V;
        }

        public static VectorI4 MkVectorI4(Int32 A)
        {
            VectorI4 V;
            V.x = (Int32)(A);
            V.y = (Int32)(A);
            V.z = (Int32)(A);
            V.w = (Int32)(A);
            return V;
        }

        public static VectorI4 MkVectorI4B(Byte x, Byte y, Byte z, Byte w)
        {
            VectorI4 V;
            V.x = (Int32)(x);
            V.y = (Int32)(y);
            V.z = (Int32)(z);
            V.w = (Int32)(w);
            return V;
        }

        public static VectorI4 MkVectorI4B(Byte A)
        {
            VectorI4 V;
            V.x = (Int32)(A);
            V.y = (Int32)(A);
            V.z = (Int32)(A);
            V.w = (Int32)(A);
            return V;
        }

        public static VectorI4 MkVectorI4D(Double x, Double y, Double z, Double w)
        {
            VectorI4 V;
            V.x = Arith.FloorID(x);
            V.y = Arith.FloorID(y);
            V.z = Arith.FloorID(z);
            V.w = Arith.FloorID(w);
            return V;
        }

        public static VectorI4 MkVectorI4D(Double A)
        {
            VectorI4 V;
            V.x = Arith.FloorID(A);
            V.y = Arith.FloorID(A);
            V.z = Arith.FloorID(A);
            V.w = Arith.FloorID(A);
            return V;
        }

        public static VectorI4 MkVectorI4F(Single x, Single y, Single z, Single w)
        {
            VectorI4 V;
            V.x = Arith.FloorIF(x);
            V.y = Arith.FloorIF(y);
            V.z = Arith.FloorIF(z);
            V.w = Arith.FloorIF(w);
            return V;
        }

        public static VectorI4 MkVectorI4F(Single A)
        {
            VectorI4 V;
            V.x = Arith.FloorIF(A);
            V.y = Arith.FloorIF(A);
            V.z = Arith.FloorIF(A);
            V.w = Arith.FloorIF(A);
            return V;
        }

        public static VectorB2 MkVectorB2I(Int32 x, Int32 y)
        {
            VectorB2 V;
            V.x = (Byte)(x);
            V.y = (Byte)(y);
            return V;
        }

        public static VectorB2 MkVectorB2I(Int32 A)
        {
            VectorB2 V;
            V.x = (Byte)(A);
            V.y = (Byte)(A);
            return V;
        }

        public static VectorB2 MkVectorB2(Byte x, Byte y)
        {
            VectorB2 V;
            V.x = (Byte)(x);
            V.y = (Byte)(y);
            return V;
        }

        public static VectorB2 MkVectorB2(Byte A)
        {
            VectorB2 V;
            V.x = (Byte)(A);
            V.y = (Byte)(A);
            return V;
        }

        public static VectorB2 MkVectorB2D(Double x, Double y)
        {
            VectorB2 V;
            V.x = Arith.FloorBD(x);
            V.y = Arith.FloorBD(y);
            return V;
        }

        public static VectorB2 MkVectorB2D(Double A)
        {
            VectorB2 V;
            V.x = Arith.FloorBD(A);
            V.y = Arith.FloorBD(A);
            return V;
        }

        public static VectorB2 MkVectorB2F(Single x, Single y)
        {
            VectorB2 V;
            V.x = Arith.FloorBF(x);
            V.y = Arith.FloorBF(y);
            return V;
        }

        public static VectorB2 MkVectorB2F(Single A)
        {
            VectorB2 V;
            V.x = Arith.FloorBF(A);
            V.y = Arith.FloorBF(A);
            return V;
        }

        public static VectorB3 MkVectorB3I(Int32 x, Int32 y, Int32 z)
        {
            VectorB3 V;
            V.x = (Byte)(x);
            V.y = (Byte)(y);
            V.z = (Byte)(z);
            return V;
        }

        public static VectorB3 MkVectorB3I(Int32 A)
        {
            VectorB3 V;
            V.x = (Byte)(A);
            V.y = (Byte)(A);
            V.z = (Byte)(A);
            return V;
        }

        public static VectorB3 MkVectorB3(Byte x, Byte y, Byte z)
        {
            VectorB3 V;
            V.x = (Byte)(x);
            V.y = (Byte)(y);
            V.z = (Byte)(z);
            return V;
        }

        public static VectorB3 MkVectorB3(Byte A)
        {
            VectorB3 V;
            V.x = (Byte)(A);
            V.y = (Byte)(A);
            V.z = (Byte)(A);
            return V;
        }

        public static VectorB3 MkVectorB3D(Double x, Double y, Double z)
        {
            VectorB3 V;
            V.x = Arith.FloorBD(x);
            V.y = Arith.FloorBD(y);
            V.z = Arith.FloorBD(z);
            return V;
        }

        public static VectorB3 MkVectorB3D(Double A)
        {
            VectorB3 V;
            V.x = Arith.FloorBD(A);
            V.y = Arith.FloorBD(A);
            V.z = Arith.FloorBD(A);
            return V;
        }

        public static VectorB3 MkVectorB3F(Single x, Single y, Single z)
        {
            VectorB3 V;
            V.x = Arith.FloorBF(x);
            V.y = Arith.FloorBF(y);
            V.z = Arith.FloorBF(z);
            return V;
        }

        public static VectorB3 MkVectorB3F(Single A)
        {
            VectorB3 V;
            V.x = Arith.FloorBF(A);
            V.y = Arith.FloorBF(A);
            V.z = Arith.FloorBF(A);
            return V;
        }

        public static VectorB4 MkVectorB4I(Int32 x, Int32 y, Int32 z, Int32 w)
        {
            VectorB4 V;
            V.x = (Byte)(x);
            V.y = (Byte)(y);
            V.z = (Byte)(z);
            V.w = (Byte)(w);
            return V;
        }

        public static VectorB4 MkVectorB4I(Int32 A)
        {
            VectorB4 V;
            V.x = (Byte)(A);
            V.y = (Byte)(A);
            V.z = (Byte)(A);
            V.w = (Byte)(A);
            return V;
        }

        public static VectorB4 MkVectorB4(Byte x, Byte y, Byte z, Byte w)
        {
            VectorB4 V;
            V.x = (Byte)(x);
            V.y = (Byte)(y);
            V.z = (Byte)(z);
            V.w = (Byte)(w);
            return V;
        }

        public static VectorB4 MkVectorB4(Byte A)
        {
            VectorB4 V;
            V.x = (Byte)(A);
            V.y = (Byte)(A);
            V.z = (Byte)(A);
            V.w = (Byte)(A);
            return V;
        }

        public static VectorB4 MkVectorB4D(Double x, Double y, Double z, Double w)
        {
            VectorB4 V;
            V.x = Arith.FloorBD(x);
            V.y = Arith.FloorBD(y);
            V.z = Arith.FloorBD(z);
            V.w = Arith.FloorBD(w);
            return V;
        }

        public static VectorB4 MkVectorB4D(Double A)
        {
            VectorB4 V;
            V.x = Arith.FloorBD(A);
            V.y = Arith.FloorBD(A);
            V.z = Arith.FloorBD(A);
            V.w = Arith.FloorBD(A);
            return V;
        }

        public static VectorB4 MkVectorB4F(Single x, Single y, Single z, Single w)
        {
            VectorB4 V;
            V.x = Arith.FloorBF(x);
            V.y = Arith.FloorBF(y);
            V.z = Arith.FloorBF(z);
            V.w = Arith.FloorBF(w);
            return V;
        }

        public static VectorB4 MkVectorB4F(Single A)
        {
            VectorB4 V;
            V.x = Arith.FloorBF(A);
            V.y = Arith.FloorBF(A);
            V.z = Arith.FloorBF(A);
            V.w = Arith.FloorBF(A);
            return V;
        }

        public static VectorD2 MkVectorD2I(Int32 x, Int32 y)
        {
            VectorD2 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            return V;
        }

        public static VectorD2 MkVectorD2I(Int32 A)
        {
            VectorD2 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            return V;
        }

        public static VectorD2 MkVectorD2B(Byte x, Byte y)
        {
            VectorD2 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            return V;
        }

        public static VectorD2 MkVectorD2B(Byte A)
        {
            VectorD2 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            return V;
        }

        public static VectorD2 MkVectorD2(Double x, Double y)
        {
            VectorD2 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            return V;
        }

        public static VectorD2 MkVectorD2(Double A)
        {
            VectorD2 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            return V;
        }

        public static VectorD2 MkVectorD2F(Single x, Single y)
        {
            VectorD2 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            return V;
        }

        public static VectorD2 MkVectorD2F(Single A)
        {
            VectorD2 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            return V;
        }

        public static VectorD3 MkVectorD3I(Int32 x, Int32 y, Int32 z)
        {
            VectorD3 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            V.z = (Double)(z);
            return V;
        }

        public static VectorD3 MkVectorD3I(Int32 A)
        {
            VectorD3 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            V.z = (Double)(A);
            return V;
        }

        public static VectorD3 MkVectorD3B(Byte x, Byte y, Byte z)
        {
            VectorD3 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            V.z = (Double)(z);
            return V;
        }

        public static VectorD3 MkVectorD3B(Byte A)
        {
            VectorD3 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            V.z = (Double)(A);
            return V;
        }

        public static VectorD3 MkVectorD3(Double x, Double y, Double z)
        {
            VectorD3 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            V.z = (Double)(z);
            return V;
        }

        public static VectorD3 MkVectorD3(Double A)
        {
            VectorD3 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            V.z = (Double)(A);
            return V;
        }

        public static VectorD3 MkVectorD3F(Single x, Single y, Single z)
        {
            VectorD3 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            V.z = (Double)(z);
            return V;
        }

        public static VectorD3 MkVectorD3F(Single A)
        {
            VectorD3 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            V.z = (Double)(A);
            return V;
        }

        public static VectorD4 MkVectorD4I(Int32 x, Int32 y, Int32 z, Int32 w)
        {
            VectorD4 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            V.z = (Double)(z);
            V.w = (Double)(w);
            return V;
        }

        public static VectorD4 MkVectorD4I(Int32 A)
        {
            VectorD4 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            V.z = (Double)(A);
            V.w = (Double)(A);
            return V;
        }

        public static VectorD4 MkVectorD4B(Byte x, Byte y, Byte z, Byte w)
        {
            VectorD4 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            V.z = (Double)(z);
            V.w = (Double)(w);
            return V;
        }

        public static VectorD4 MkVectorD4B(Byte A)
        {
            VectorD4 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            V.z = (Double)(A);
            V.w = (Double)(A);
            return V;
        }

        public static VectorD4 MkVectorD4(Double x, Double y, Double z, Double w)
        {
            VectorD4 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            V.z = (Double)(z);
            V.w = (Double)(w);
            return V;
        }

        public static VectorD4 MkVectorD4(Double A)
        {
            VectorD4 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            V.z = (Double)(A);
            V.w = (Double)(A);
            return V;
        }

        public static VectorD4 MkVectorD4F(Single x, Single y, Single z, Single w)
        {
            VectorD4 V;
            V.x = (Double)(x);
            V.y = (Double)(y);
            V.z = (Double)(z);
            V.w = (Double)(w);
            return V;
        }

        public static VectorD4 MkVectorD4F(Single A)
        {
            VectorD4 V;
            V.x = (Double)(A);
            V.y = (Double)(A);
            V.z = (Double)(A);
            V.w = (Double)(A);
            return V;
        }

        public static Vector2 MkVector2I(Int32 x, Int32 y)
        {
            Vector2 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            return V;
        }

        public static Vector2 MkVector2I(Int32 A)
        {
            Vector2 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            return V;
        }

        public static Vector2 MkVector2B(Byte x, Byte y)
        {
            Vector2 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            return V;
        }

        public static Vector2 MkVector2B(Byte A)
        {
            Vector2 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            return V;
        }

        public static Vector2 MkVector2D(Double x, Double y)
        {
            Vector2 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            return V;
        }

        public static Vector2 MkVector2D(Double A)
        {
            Vector2 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            return V;
        }

        public static Vector2 MkVector2(Single x, Single y)
        {
            Vector2 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            return V;
        }

        public static Vector2 MkVector2(Single A)
        {
            Vector2 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            return V;
        }

        public static Vector3 MkVector3I(Int32 x, Int32 y, Int32 z)
        {
            Vector3 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            V.z = (Single)(z);
            return V;
        }

        public static Vector3 MkVector3I(Int32 A)
        {
            Vector3 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            V.z = (Single)(A);
            return V;
        }

        public static Vector3 MkVector3B(Byte x, Byte y, Byte z)
        {
            Vector3 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            V.z = (Single)(z);
            return V;
        }

        public static Vector3 MkVector3B(Byte A)
        {
            Vector3 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            V.z = (Single)(A);
            return V;
        }

        public static Vector3 MkVector3D(Double x, Double y, Double z)
        {
            Vector3 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            V.z = (Single)(z);
            return V;
        }

        public static Vector3 MkVector3D(Double A)
        {
            Vector3 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            V.z = (Single)(A);
            return V;
        }

        public static Vector3 MkVector3(Single x, Single y, Single z)
        {
            Vector3 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            V.z = (Single)(z);
            return V;
        }

        public static Vector3 MkVector3(Single A)
        {
            Vector3 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            V.z = (Single)(A);
            return V;
        }

        public static Vector4 MkVector4I(Int32 x, Int32 y, Int32 z, Int32 w)
        {
            Vector4 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            V.z = (Single)(z);
            V.w = (Single)(w);
            return V;
        }

        public static Vector4 MkVector4I(Int32 A)
        {
            Vector4 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            V.z = (Single)(A);
            V.w = (Single)(A);
            return V;
        }

        public static Vector4 MkVector4B(Byte x, Byte y, Byte z, Byte w)
        {
            Vector4 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            V.z = (Single)(z);
            V.w = (Single)(w);
            return V;
        }

        public static Vector4 MkVector4B(Byte A)
        {
            Vector4 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            V.z = (Single)(A);
            V.w = (Single)(A);
            return V;
        }

        public static Vector4 MkVector4D(Double x, Double y, Double z, Double w)
        {
            Vector4 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            V.z = (Single)(z);
            V.w = (Single)(w);
            return V;
        }

        public static Vector4 MkVector4D(Double A)
        {
            Vector4 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            V.z = (Single)(A);
            V.w = (Single)(A);
            return V;
        }

        public static Vector4 MkVector4(Single x, Single y, Single z, Single w)
        {
            Vector4 V;
            V.x = (Single)(x);
            V.y = (Single)(y);
            V.z = (Single)(z);
            V.w = (Single)(w);
            return V;
        }

        public static Vector4 MkVector4(Single A)
        {
            Vector4 V;
            V.x = (Single)(A);
            V.y = (Single)(A);
            V.z = (Single)(A);
            V.w = (Single)(A);
            return V;
        }

        // Constructors from other vectors. Float converts to int using floor
        public static VectorI2 MkVectorI2B(VectorB2 V)
        {
            return OHV.MkVectorI2B(V.x, V.y);
        }

        public static VectorI2 MkVectorI2D(VectorD2 V)
        {
            return OHV.MkVectorI2D(V.x, V.y);
        }

        public static VectorI2 MkVectorI2F(Vector2 V)
        {
            return OHV.MkVectorI2F(V.x, V.y);
        }

        public static VectorI3 MkVectorI3B(VectorB3 V)
        {
            return OHV.MkVectorI3B(V.x, V.y, V.z);
        }

        public static VectorI3 MkVectorI3D(VectorD3 V)
        {
            return OHV.MkVectorI3D(V.x, V.y, V.z);
        }

        public static VectorI3 MkVectorI3F(Vector3 V)
        {
            return OHV.MkVectorI3F(V.x, V.y, V.z);
        }

        public static VectorI4 MkVectorI4B(VectorB4 V)
        {
            return OHV.MkVectorI4B(V.x, V.y, V.z, V.w);
        }

        public static VectorI4 MkVectorI4D(VectorD4 V)
        {
            return OHV.MkVectorI4D(V.x, V.y, V.z, V.w);
        }

        public static VectorI4 MkVectorI4F(Vector4 V)
        {
            return OHV.MkVectorI4F(V.x, V.y, V.z, V.w);
        }

        public static VectorB2 MkVectorB2I(VectorI2 V)
        {
            return OHV.MkVectorB2I(V.x, V.y);
        }

        public static VectorB2 MkVectorB2D(VectorD2 V)
        {
            return OHV.MkVectorB2D(V.x, V.y);
        }

        public static VectorB2 MkVectorB2F(Vector2 V)
        {
            return OHV.MkVectorB2F(V.x, V.y);
        }

        public static VectorB3 MkVectorB3I(VectorI3 V)
        {
            return OHV.MkVectorB3I(V.x, V.y, V.z);
        }

        public static VectorB3 MkVectorB3D(VectorD3 V)
        {
            return OHV.MkVectorB3D(V.x, V.y, V.z);
        }

        public static VectorB3 MkVectorB3F(Vector3 V)
        {
            return OHV.MkVectorB3F(V.x, V.y, V.z);
        }

        public static VectorB4 MkVectorB4I(VectorI4 V)
        {
            return OHV.MkVectorB4I(V.x, V.y, V.z, V.w);
        }

        public static VectorB4 MkVectorB4D(VectorD4 V)
        {
            return OHV.MkVectorB4D(V.x, V.y, V.z, V.w);
        }

        public static VectorB4 MkVectorB4F(Vector4 V)
        {
            return OHV.MkVectorB4F(V.x, V.y, V.z, V.w);
        }

        public static VectorD2 MkVectorD2I(VectorI2 V)
        {
            return OHV.MkVectorD2I(V.x, V.y);
        }

        public static VectorD2 MkVectorD2B(VectorB2 V)
        {
            return OHV.MkVectorD2B(V.x, V.y);
        }

        public static VectorD2 MkVectorD2F(Vector2 V)
        {
            return OHV.MkVectorD2F(V.x, V.y);
        }

        public static VectorD3 MkVectorD3I(VectorI3 V)
        {
            return OHV.MkVectorD3I(V.x, V.y, V.z);
        }

        public static VectorD3 MkVectorD3B(VectorB3 V)
        {
            return OHV.MkVectorD3B(V.x, V.y, V.z);
        }

        public static VectorD3 MkVectorD3F(Vector3 V)
        {
            return OHV.MkVectorD3F(V.x, V.y, V.z);
        }

        public static VectorD4 MkVectorD4I(VectorI4 V)
        {
            return OHV.MkVectorD4I(V.x, V.y, V.z, V.w);
        }

        public static VectorD4 MkVectorD4B(VectorB4 V)
        {
            return OHV.MkVectorD4B(V.x, V.y, V.z, V.w);
        }

        public static VectorD4 MkVectorD4F(Vector4 V)
        {
            return OHV.MkVectorD4F(V.x, V.y, V.z, V.w);
        }

        public static Vector2 MkVector2I(VectorI2 V)
        {
            return OHV.MkVector2I(V.x, V.y);
        }

        public static Vector2 MkVector2B(VectorB2 V)
        {
            return OHV.MkVector2B(V.x, V.y);
        }

        public static Vector2 MkVector2D(VectorD2 V)
        {
            return OHV.MkVector2D(V.x, V.y);
        }

        public static Vector3 MkVector3I(VectorI3 V)
        {
            return OHV.MkVector3I(V.x, V.y, V.z);
        }

        public static Vector3 MkVector3B(VectorB3 V)
        {
            return OHV.MkVector3B(V.x, V.y, V.z);
        }

        public static Vector3 MkVector3D(VectorD3 V)
        {
            return OHV.MkVector3D(V.x, V.y, V.z);
        }

        public static Vector4 MkVector4I(VectorI4 V)
        {
            return OHV.MkVector4I(V.x, V.y, V.z, V.w);
        }

        public static Vector4 MkVector4B(VectorB4 V)
        {
            return OHV.MkVector4B(V.x, V.y, V.z, V.w);
        }

        public static Vector4 MkVector4D(VectorD4 V)
        {
            return OHV.MkVector4D(V.x, V.y, V.z, V.w);
        }

        // Constructors from ceiling rather than floor
        public static VectorI2 CeilVectorI2D(VectorD2 V)
        {
            return OHV.MkVectorI2D(Arith.CeilID(V.x), Arith.CeilID(V.y));
        }

        public static VectorI2 CeilVectorI2F(Vector2 V)
        {
            return OHV.MkVectorI2F(Arith.CeilIF(V.x), Arith.CeilIF(V.y));
        }

        public static VectorI3 CeilVectorI3D(VectorD3 V)
        {
            return OHV.MkVectorI3D(Arith.CeilID(V.x), Arith.CeilID(V.y), Arith.CeilID(V.z));
        }

        public static VectorI3 CeilVectorI3F(Vector3 V)
        {
            return OHV.MkVectorI3F(Arith.CeilIF(V.x), Arith.CeilIF(V.y), Arith.CeilIF(V.z));
        }

        public static VectorI4 CeilVectorI4D(VectorD4 V)
        {
            return OHV.MkVectorI4D(Arith.CeilID(V.x), Arith.CeilID(V.y), Arith.CeilID(V.z), Arith.CeilID(V.w));
        }

        public static VectorI4 CeilVectorI4F(Vector4 V)
        {
            return OHV.MkVectorI4F(Arith.CeilIF(V.x), Arith.CeilIF(V.y), Arith.CeilIF(V.z), Arith.CeilIF(V.w));
        }

        public static VectorB2 CeilVectorB2D(VectorD2 V)
        {
            return OHV.MkVectorB2D(Arith.CeilBD(V.x), Arith.CeilBD(V.y));
        }

        public static VectorB2 CeilVectorB2F(Vector2 V)
        {
            return OHV.MkVectorB2F(Arith.CeilBF(V.x), Arith.CeilBF(V.y));
        }

        public static VectorB3 CeilVectorB3D(VectorD3 V)
        {
            return OHV.MkVectorB3D(Arith.CeilBD(V.x), Arith.CeilBD(V.y), Arith.CeilBD(V.z));
        }

        public static VectorB3 CeilVectorB3F(Vector3 V)
        {
            return OHV.MkVectorB3F(Arith.CeilBF(V.x), Arith.CeilBF(V.y), Arith.CeilBF(V.z));
        }

        public static VectorB4 CeilVectorB4D(VectorD4 V)
        {
            return OHV.MkVectorB4D(Arith.CeilBD(V.x), Arith.CeilBD(V.y), Arith.CeilBD(V.z), Arith.CeilBD(V.w));
        }

        public static VectorB4 CeilVectorB4F(Vector4 V)
        {
            return OHV.MkVectorB4F(Arith.CeilBF(V.x), Arith.CeilBF(V.y), Arith.CeilBF(V.z), Arith.CeilBF(V.w));
        }

        // Evaluate whether all terms are greater than, less than, greater than or equal, less than or equal
        public static Boolean StrictGt(VectorI2 A, VectorI2 B)
        {
            return (A.x > B.x)
                && (A.y > B.y);
        }

        public static Boolean StrictGt(VectorI3 A, VectorI3 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z);
        }

        public static Boolean StrictGt(VectorI4 A, VectorI4 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z)
                && (A.w > B.w);
        }

        public static Boolean StrictGt(VectorB2 A, VectorB2 B)
        {
            return (A.x > B.x)
                && (A.y > B.y);
        }

        public static Boolean StrictGt(VectorB3 A, VectorB3 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z);
        }

        public static Boolean StrictGt(VectorB4 A, VectorB4 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z)
                && (A.w > B.w);
        }

        public static Boolean StrictGt(VectorD2 A, VectorD2 B)
        {
            return (A.x > B.x)
                && (A.y > B.y);
        }

        public static Boolean StrictGt(VectorD3 A, VectorD3 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z);
        }

        public static Boolean StrictGt(VectorD4 A, VectorD4 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z)
                && (A.w > B.w);
        }

        public static Boolean StrictGt(Vector2 A, Vector2 B)
        {
            return (A.x > B.x)
                && (A.y > B.y);
        }

        public static Boolean StrictGt(Vector3 A, Vector3 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z);
        }

        public static Boolean StrictGt(Vector4 A, Vector4 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z)
                && (A.w > B.w);
        }

        public static Boolean StrictLt(VectorI2 A, VectorI2 B)
        {
            return (A.x < B.x)
                && (A.y < B.y);
        }

        public static Boolean StrictLt(VectorI3 A, VectorI3 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z);
        }

        public static Boolean StrictLt(VectorI4 A, VectorI4 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z)
                && (A.w < B.w);
        }

        public static Boolean StrictLt(VectorB2 A, VectorB2 B)
        {
            return (A.x < B.x)
                && (A.y < B.y);
        }

        public static Boolean StrictLt(VectorB3 A, VectorB3 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z);
        }

        public static Boolean StrictLt(VectorB4 A, VectorB4 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z)
                && (A.w < B.w);
        }

        public static Boolean StrictLt(VectorD2 A, VectorD2 B)
        {
            return (A.x < B.x)
                && (A.y < B.y);
        }

        public static Boolean StrictLt(VectorD3 A, VectorD3 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z);
        }

        public static Boolean StrictLt(VectorD4 A, VectorD4 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z)
                && (A.w < B.w);
        }

        public static Boolean StrictLt(Vector2 A, Vector2 B)
        {
            return (A.x < B.x)
                && (A.y < B.y);
        }

        public static Boolean StrictLt(Vector3 A, Vector3 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z);
        }

        public static Boolean StrictLt(Vector4 A, Vector4 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z)
                && (A.w < B.w);
        }

        public static Boolean StrictGte(VectorI2 A, VectorI2 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y);
        }

        public static Boolean StrictGte(VectorI3 A, VectorI3 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z);
        }

        public static Boolean StrictGte(VectorI4 A, VectorI4 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z)
                && (A.w >= B.w);
        }

        public static Boolean StrictGte(VectorB2 A, VectorB2 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y);
        }

        public static Boolean StrictGte(VectorB3 A, VectorB3 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z);
        }

        public static Boolean StrictGte(VectorB4 A, VectorB4 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z)
                && (A.w >= B.w);
        }

        public static Boolean StrictGte(VectorD2 A, VectorD2 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y);
        }

        public static Boolean StrictGte(VectorD3 A, VectorD3 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z);
        }

        public static Boolean StrictGte(VectorD4 A, VectorD4 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z)
                && (A.w >= B.w);
        }

        public static Boolean StrictGte(Vector2 A, Vector2 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y);
        }

        public static Boolean StrictGte(Vector3 A, Vector3 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z);
        }

        public static Boolean StrictGte(Vector4 A, Vector4 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z)
                && (A.w >= B.w);
        }

        public static Boolean StrictLte(VectorI2 A, VectorI2 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y);
        }

        public static Boolean StrictLte(VectorI3 A, VectorI3 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z);
        }

        public static Boolean StrictLte(VectorI4 A, VectorI4 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z)
                && (A.w <= B.w);
        }

        public static Boolean StrictLte(VectorB2 A, VectorB2 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y);
        }

        public static Boolean StrictLte(VectorB3 A, VectorB3 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z);
        }

        public static Boolean StrictLte(VectorB4 A, VectorB4 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z)
                && (A.w <= B.w);
        }

        public static Boolean StrictLte(VectorD2 A, VectorD2 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y);
        }

        public static Boolean StrictLte(VectorD3 A, VectorD3 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z);
        }

        public static Boolean StrictLte(VectorD4 A, VectorD4 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z)
                && (A.w <= B.w);
        }

        public static Boolean StrictLte(Vector2 A, Vector2 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y);
        }

        public static Boolean StrictLte(Vector3 A, Vector3 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z);
        }

        public static Boolean StrictLte(Vector4 A, Vector4 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z)
                && (A.w <= B.w);
        }

        // Elementwise multiplication (equivalent to Scale() in Unity)
        public static VectorI2 ElMult(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(A.x * B.x),
                (Int32)(A.y * B.y));
        }

        public static VectorI3 ElMult(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(A.x * B.x),
                (Int32)(A.y * B.y),
                (Int32)(A.z * B.z));
        }

        public static VectorI4 ElMult(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(A.x * B.x),
                (Int32)(A.y * B.y),
                (Int32)(A.z * B.z),
                (Int32)(A.w * B.w));
        }

        public static VectorB2 ElMult(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(A.x * B.x),
                (Byte)(A.y * B.y));
        }

        public static VectorB3 ElMult(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(A.x * B.x),
                (Byte)(A.y * B.y),
                (Byte)(A.z * B.z));
        }

        public static VectorB4 ElMult(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(A.x * B.x),
                (Byte)(A.y * B.y),
                (Byte)(A.z * B.z),
                (Byte)(A.w * B.w));
        }

        public static VectorD2 ElMult(VectorD2 A, VectorD2 B)
        {
            return OHV.MkVectorD2(
                (Double)(A.x * B.x),
                (Double)(A.y * B.y));
        }

        public static VectorD3 ElMult(VectorD3 A, VectorD3 B)
        {
            return OHV.MkVectorD3(
                (Double)(A.x * B.x),
                (Double)(A.y * B.y),
                (Double)(A.z * B.z));
        }

        public static VectorD4 ElMult(VectorD4 A, VectorD4 B)
        {
            return OHV.MkVectorD4(
                (Double)(A.x * B.x),
                (Double)(A.y * B.y),
                (Double)(A.z * B.z),
                (Double)(A.w * B.w));
        }

        public static Vector2 ElMult(Vector2 A, Vector2 B)
        {
            return OHV.MkVector2(
                (Single)(A.x * B.x),
                (Single)(A.y * B.y));
        }

        public static Vector3 ElMult(Vector3 A, Vector3 B)
        {
            return OHV.MkVector3(
                (Single)(A.x * B.x),
                (Single)(A.y * B.y),
                (Single)(A.z * B.z));
        }

        public static Vector4 ElMult(Vector4 A, Vector4 B)
        {
            return OHV.MkVector4(
                (Single)(A.x * B.x),
                (Single)(A.y * B.y),
                (Single)(A.z * B.z),
                (Single)(A.w * B.w));
        }

        // Elementwise division. Uses floor.
        public static VectorI2 ElDiv(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(Arith.Div(A.x, B.x)),
                (Int32)(Arith.Div(A.y, B.y)));
        }

        public static VectorI3 ElDiv(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(Arith.Div(A.x, B.x)),
                (Int32)(Arith.Div(A.y, B.y)),
                (Int32)(Arith.Div(A.z, B.z)));
        }

        public static VectorI4 ElDiv(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(Arith.Div(A.x, B.x)),
                (Int32)(Arith.Div(A.y, B.y)),
                (Int32)(Arith.Div(A.z, B.z)),
                (Int32)(Arith.Div(A.w, B.w)));
        }

        public static VectorB2 ElDiv(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(Arith.Div(A.x, B.x)),
                (Byte)(Arith.Div(A.y, B.y)));
        }

        public static VectorB3 ElDiv(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(Arith.Div(A.x, B.x)),
                (Byte)(Arith.Div(A.y, B.y)),
                (Byte)(Arith.Div(A.z, B.z)));
        }

        public static VectorB4 ElDiv(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(Arith.Div(A.x, B.x)),
                (Byte)(Arith.Div(A.y, B.y)),
                (Byte)(Arith.Div(A.z, B.z)),
                (Byte)(Arith.Div(A.w, B.w)));
        }

        public static VectorD2 ElDiv(VectorD2 A, VectorD2 B)
        {
            return OHV.MkVectorD2(
                (Double)(Arith.Div(A.x, B.x)),
                (Double)(Arith.Div(A.y, B.y)));
        }

        public static VectorD3 ElDiv(VectorD3 A, VectorD3 B)
        {
            return OHV.MkVectorD3(
                (Double)(Arith.Div(A.x, B.x)),
                (Double)(Arith.Div(A.y, B.y)),
                (Double)(Arith.Div(A.z, B.z)));
        }

        public static VectorD4 ElDiv(VectorD4 A, VectorD4 B)
        {
            return OHV.MkVectorD4(
                (Double)(Arith.Div(A.x, B.x)),
                (Double)(Arith.Div(A.y, B.y)),
                (Double)(Arith.Div(A.z, B.z)),
                (Double)(Arith.Div(A.w, B.w)));
        }

        public static Vector2 ElDiv(Vector2 A, Vector2 B)
        {
            return OHV.MkVector2(
                (Single)(Arith.Div(A.x, B.x)),
                (Single)(Arith.Div(A.y, B.y)));
        }

        public static Vector3 ElDiv(Vector3 A, Vector3 B)
        {
            return OHV.MkVector3(
                (Single)(Arith.Div(A.x, B.x)),
                (Single)(Arith.Div(A.y, B.y)),
                (Single)(Arith.Div(A.z, B.z)));
        }

        public static Vector4 ElDiv(Vector4 A, Vector4 B)
        {
            return OHV.MkVector4(
                (Single)(Arith.Div(A.x, B.x)),
                (Single)(Arith.Div(A.y, B.y)),
                (Single)(Arith.Div(A.z, B.z)),
                (Single)(Arith.Div(A.w, B.w)));
        }

        // Elementwise division that uses ceiling instead of floor
        public static VectorI2 ElCeilDiv(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(Arith.CeilDiv(A.x, B.x)),
                (Int32)(Arith.CeilDiv(A.y, B.y)));
        }

        public static VectorI3 ElCeilDiv(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(Arith.CeilDiv(A.x, B.x)),
                (Int32)(Arith.CeilDiv(A.y, B.y)),
                (Int32)(Arith.CeilDiv(A.z, B.z)));
        }

        public static VectorI4 ElCeilDiv(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(Arith.CeilDiv(A.x, B.x)),
                (Int32)(Arith.CeilDiv(A.y, B.y)),
                (Int32)(Arith.CeilDiv(A.z, B.z)),
                (Int32)(Arith.CeilDiv(A.w, B.w)));
        }

        public static VectorB2 ElCeilDiv(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(Arith.CeilDiv(A.x, B.x)),
                (Byte)(Arith.CeilDiv(A.y, B.y)));
        }

        public static VectorB3 ElCeilDiv(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(Arith.CeilDiv(A.x, B.x)),
                (Byte)(Arith.CeilDiv(A.y, B.y)),
                (Byte)(Arith.CeilDiv(A.z, B.z)));
        }

        public static VectorB4 ElCeilDiv(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(Arith.CeilDiv(A.x, B.x)),
                (Byte)(Arith.CeilDiv(A.y, B.y)),
                (Byte)(Arith.CeilDiv(A.z, B.z)),
                (Byte)(Arith.CeilDiv(A.w, B.w)));
        }

        // Elementwise min/max
        public static VectorI2 ElMin(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(Arith.Min(A.x, B.x)),
                (Int32)(Arith.Min(A.y, B.y)));
        }

        public static VectorI3 ElMin(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(Arith.Min(A.x, B.x)),
                (Int32)(Arith.Min(A.y, B.y)),
                (Int32)(Arith.Min(A.z, B.z)));
        }

        public static VectorI4 ElMin(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(Arith.Min(A.x, B.x)),
                (Int32)(Arith.Min(A.y, B.y)),
                (Int32)(Arith.Min(A.z, B.z)),
                (Int32)(Arith.Min(A.w, B.w)));
        }

        public static VectorB2 ElMin(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(Arith.Min(A.x, B.x)),
                (Byte)(Arith.Min(A.y, B.y)));
        }

        public static VectorB3 ElMin(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(Arith.Min(A.x, B.x)),
                (Byte)(Arith.Min(A.y, B.y)),
                (Byte)(Arith.Min(A.z, B.z)));
        }

        public static VectorB4 ElMin(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(Arith.Min(A.x, B.x)),
                (Byte)(Arith.Min(A.y, B.y)),
                (Byte)(Arith.Min(A.z, B.z)),
                (Byte)(Arith.Min(A.w, B.w)));
        }

        public static VectorD2 ElMin(VectorD2 A, VectorD2 B)
        {
            return OHV.MkVectorD2(
                (Double)(Arith.Min(A.x, B.x)),
                (Double)(Arith.Min(A.y, B.y)));
        }

        public static VectorD3 ElMin(VectorD3 A, VectorD3 B)
        {
            return OHV.MkVectorD3(
                (Double)(Arith.Min(A.x, B.x)),
                (Double)(Arith.Min(A.y, B.y)),
                (Double)(Arith.Min(A.z, B.z)));
        }

        public static VectorD4 ElMin(VectorD4 A, VectorD4 B)
        {
            return OHV.MkVectorD4(
                (Double)(Arith.Min(A.x, B.x)),
                (Double)(Arith.Min(A.y, B.y)),
                (Double)(Arith.Min(A.z, B.z)),
                (Double)(Arith.Min(A.w, B.w)));
        }

        public static Vector2 ElMin(Vector2 A, Vector2 B)
        {
            return OHV.MkVector2(
                (Single)(Arith.Min(A.x, B.x)),
                (Single)(Arith.Min(A.y, B.y)));
        }

        public static Vector3 ElMin(Vector3 A, Vector3 B)
        {
            return OHV.MkVector3(
                (Single)(Arith.Min(A.x, B.x)),
                (Single)(Arith.Min(A.y, B.y)),
                (Single)(Arith.Min(A.z, B.z)));
        }

        public static Vector4 ElMin(Vector4 A, Vector4 B)
        {
            return OHV.MkVector4(
                (Single)(Arith.Min(A.x, B.x)),
                (Single)(Arith.Min(A.y, B.y)),
                (Single)(Arith.Min(A.z, B.z)),
                (Single)(Arith.Min(A.w, B.w)));
        }

        public static VectorI2 ElMax(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(Arith.Max(A.x, B.x)),
                (Int32)(Arith.Max(A.y, B.y)));
        }

        public static VectorI3 ElMax(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(Arith.Max(A.x, B.x)),
                (Int32)(Arith.Max(A.y, B.y)),
                (Int32)(Arith.Max(A.z, B.z)));
        }

        public static VectorI4 ElMax(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(Arith.Max(A.x, B.x)),
                (Int32)(Arith.Max(A.y, B.y)),
                (Int32)(Arith.Max(A.z, B.z)),
                (Int32)(Arith.Max(A.w, B.w)));
        }

        public static VectorB2 ElMax(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(Arith.Max(A.x, B.x)),
                (Byte)(Arith.Max(A.y, B.y)));
        }

        public static VectorB3 ElMax(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(Arith.Max(A.x, B.x)),
                (Byte)(Arith.Max(A.y, B.y)),
                (Byte)(Arith.Max(A.z, B.z)));
        }

        public static VectorB4 ElMax(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(Arith.Max(A.x, B.x)),
                (Byte)(Arith.Max(A.y, B.y)),
                (Byte)(Arith.Max(A.z, B.z)),
                (Byte)(Arith.Max(A.w, B.w)));
        }

        public static VectorD2 ElMax(VectorD2 A, VectorD2 B)
        {
            return OHV.MkVectorD2(
                (Double)(Arith.Max(A.x, B.x)),
                (Double)(Arith.Max(A.y, B.y)));
        }

        public static VectorD3 ElMax(VectorD3 A, VectorD3 B)
        {
            return OHV.MkVectorD3(
                (Double)(Arith.Max(A.x, B.x)),
                (Double)(Arith.Max(A.y, B.y)),
                (Double)(Arith.Max(A.z, B.z)));
        }

        public static VectorD4 ElMax(VectorD4 A, VectorD4 B)
        {
            return OHV.MkVectorD4(
                (Double)(Arith.Max(A.x, B.x)),
                (Double)(Arith.Max(A.y, B.y)),
                (Double)(Arith.Max(A.z, B.z)),
                (Double)(Arith.Max(A.w, B.w)));
        }

        public static Vector2 ElMax(Vector2 A, Vector2 B)
        {
            return OHV.MkVector2(
                (Single)(Arith.Max(A.x, B.x)),
                (Single)(Arith.Max(A.y, B.y)));
        }

        public static Vector3 ElMax(Vector3 A, Vector3 B)
        {
            return OHV.MkVector3(
                (Single)(Arith.Max(A.x, B.x)),
                (Single)(Arith.Max(A.y, B.y)),
                (Single)(Arith.Max(A.z, B.z)));
        }

        public static Vector4 ElMax(Vector4 A, Vector4 B)
        {
            return OHV.MkVector4(
                (Single)(Arith.Max(A.x, B.x)),
                (Single)(Arith.Max(A.y, B.y)),
                (Single)(Arith.Max(A.z, B.z)),
                (Single)(Arith.Max(A.w, B.w)));
        }

        // Elementwise remainder. Uses floor.
        public static VectorI2 ElRem(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(Arith.Rem(A.x, B.x)),
                (Int32)(Arith.Rem(A.y, B.y)));
        }

        public static VectorI3 ElRem(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(Arith.Rem(A.x, B.x)),
                (Int32)(Arith.Rem(A.y, B.y)),
                (Int32)(Arith.Rem(A.z, B.z)));
        }

        public static VectorI4 ElRem(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(Arith.Rem(A.x, B.x)),
                (Int32)(Arith.Rem(A.y, B.y)),
                (Int32)(Arith.Rem(A.z, B.z)),
                (Int32)(Arith.Rem(A.w, B.w)));
        }

        public static VectorB2 ElRem(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(Arith.Rem(A.x, B.x)),
                (Byte)(Arith.Rem(A.y, B.y)));
        }

        public static VectorB3 ElRem(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(Arith.Rem(A.x, B.x)),
                (Byte)(Arith.Rem(A.y, B.y)),
                (Byte)(Arith.Rem(A.z, B.z)));
        }

        public static VectorB4 ElRem(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(Arith.Rem(A.x, B.x)),
                (Byte)(Arith.Rem(A.y, B.y)),
                (Byte)(Arith.Rem(A.z, B.z)),
                (Byte)(Arith.Rem(A.w, B.w)));
        }

        // Elementwise multiplication/division/remainder by 2^B_i
        public static VectorI2 ElPow2CeilDiv(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Int32)(Arith.Pow2CeilDiv(A.y, B.y)));
        }

        public static VectorI3 ElPow2CeilDiv(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Int32)(Arith.Pow2CeilDiv(A.y, B.y)),
                (Int32)(Arith.Pow2CeilDiv(A.z, B.z)));
        }

        public static VectorI4 ElPow2CeilDiv(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Int32)(Arith.Pow2CeilDiv(A.y, B.y)),
                (Int32)(Arith.Pow2CeilDiv(A.z, B.z)),
                (Int32)(Arith.Pow2CeilDiv(A.w, B.w)));
        }

        public static VectorB2 ElPow2CeilDiv(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Byte)(Arith.Pow2CeilDiv(A.y, B.y)));
        }

        public static VectorB3 ElPow2CeilDiv(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Byte)(Arith.Pow2CeilDiv(A.y, B.y)),
                (Byte)(Arith.Pow2CeilDiv(A.z, B.z)));
        }

        public static VectorB4 ElPow2CeilDiv(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Byte)(Arith.Pow2CeilDiv(A.y, B.y)),
                (Byte)(Arith.Pow2CeilDiv(A.z, B.z)),
                (Byte)(Arith.Pow2CeilDiv(A.w, B.w)));
        }

        public static VectorI2 ElPow2Div(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(Arith.Pow2Div(A.x, B.x)),
                (Int32)(Arith.Pow2Div(A.y, B.y)));
        }

        public static VectorI3 ElPow2Div(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(Arith.Pow2Div(A.x, B.x)),
                (Int32)(Arith.Pow2Div(A.y, B.y)),
                (Int32)(Arith.Pow2Div(A.z, B.z)));
        }

        public static VectorI4 ElPow2Div(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(Arith.Pow2Div(A.x, B.x)),
                (Int32)(Arith.Pow2Div(A.y, B.y)),
                (Int32)(Arith.Pow2Div(A.z, B.z)),
                (Int32)(Arith.Pow2Div(A.w, B.w)));
        }

        public static VectorB2 ElPow2Div(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(Arith.Pow2Div(A.x, B.x)),
                (Byte)(Arith.Pow2Div(A.y, B.y)));
        }

        public static VectorB3 ElPow2Div(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(Arith.Pow2Div(A.x, B.x)),
                (Byte)(Arith.Pow2Div(A.y, B.y)),
                (Byte)(Arith.Pow2Div(A.z, B.z)));
        }

        public static VectorB4 ElPow2Div(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(Arith.Pow2Div(A.x, B.x)),
                (Byte)(Arith.Pow2Div(A.y, B.y)),
                (Byte)(Arith.Pow2Div(A.z, B.z)),
                (Byte)(Arith.Pow2Div(A.w, B.w)));
        }

        public static VectorI2 ElPow2Mult(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(Arith.Pow2Mult(A.x, B.x)),
                (Int32)(Arith.Pow2Mult(A.y, B.y)));
        }

        public static VectorI3 ElPow2Mult(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(Arith.Pow2Mult(A.x, B.x)),
                (Int32)(Arith.Pow2Mult(A.y, B.y)),
                (Int32)(Arith.Pow2Mult(A.z, B.z)));
        }

        public static VectorI4 ElPow2Mult(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(Arith.Pow2Mult(A.x, B.x)),
                (Int32)(Arith.Pow2Mult(A.y, B.y)),
                (Int32)(Arith.Pow2Mult(A.z, B.z)),
                (Int32)(Arith.Pow2Mult(A.w, B.w)));
        }

        public static VectorB2 ElPow2Mult(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(Arith.Pow2Mult(A.x, B.x)),
                (Byte)(Arith.Pow2Mult(A.y, B.y)));
        }

        public static VectorB3 ElPow2Mult(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(Arith.Pow2Mult(A.x, B.x)),
                (Byte)(Arith.Pow2Mult(A.y, B.y)),
                (Byte)(Arith.Pow2Mult(A.z, B.z)));
        }

        public static VectorB4 ElPow2Mult(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(Arith.Pow2Mult(A.x, B.x)),
                (Byte)(Arith.Pow2Mult(A.y, B.y)),
                (Byte)(Arith.Pow2Mult(A.z, B.z)),
                (Byte)(Arith.Pow2Mult(A.w, B.w)));
        }

        public static VectorI2 ElPow2Rem(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(Arith.Pow2Rem(A.x, B.x)),
                (Int32)(Arith.Pow2Rem(A.y, B.y)));
        }

        public static VectorI3 ElPow2Rem(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(Arith.Pow2Rem(A.x, B.x)),
                (Int32)(Arith.Pow2Rem(A.y, B.y)),
                (Int32)(Arith.Pow2Rem(A.z, B.z)));
        }

        public static VectorI4 ElPow2Rem(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(Arith.Pow2Rem(A.x, B.x)),
                (Int32)(Arith.Pow2Rem(A.y, B.y)),
                (Int32)(Arith.Pow2Rem(A.z, B.z)),
                (Int32)(Arith.Pow2Rem(A.w, B.w)));
        }

        public static VectorB2 ElPow2Rem(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(Arith.Pow2Rem(A.x, B.x)),
                (Byte)(Arith.Pow2Rem(A.y, B.y)));
        }

        public static VectorB3 ElPow2Rem(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(Arith.Pow2Rem(A.x, B.x)),
                (Byte)(Arith.Pow2Rem(A.y, B.y)),
                (Byte)(Arith.Pow2Rem(A.z, B.z)));
        }

        public static VectorB4 ElPow2Rem(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(Arith.Pow2Rem(A.x, B.x)),
                (Byte)(Arith.Pow2Rem(A.y, B.y)),
                (Byte)(Arith.Pow2Rem(A.z, B.z)),
                (Byte)(Arith.Pow2Rem(A.w, B.w)));
        }

        // Dot product
        public static Int32 DotP(VectorI2 A, VectorI2 B)
        {
            return (Int32)((A.x * B.x)
                + (A.y * B.y));
        }

        public static Int32 DotP(VectorI3 A, VectorI3 B)
        {
            return (Int32)((A.x * B.x)
                + (A.y * B.y)
                + (A.z * B.z));
        }

        public static Int32 DotP(VectorI4 A, VectorI4 B)
        {
            return (Int32)((A.x * B.x)
                + (A.y * B.y)
                + (A.z * B.z)
                + (A.w * B.w));
        }

        public static Byte DotP(VectorB2 A, VectorB2 B)
        {
            return (Byte)((A.x * B.x)
                + (A.y * B.y));
        }

        public static Int32 DotPI(VectorB2 A, VectorB2 B)
        {
            return (Int32)((Int32)(A.x * B.x)
                + (Int32)(A.y * B.y));
        }

        public static Byte DotP(VectorB3 A, VectorB3 B)
        {
            return (Byte)((A.x * B.x)
                + (A.y * B.y)
                + (A.z * B.z));
        }

        public static Int32 DotPI(VectorB3 A, VectorB3 B)
        {
            return (Int32)((Int32)(A.x * B.x)
                + (Int32)(A.y * B.y)
                + (Int32)(A.z * B.z));
        }

        public static Byte DotP(VectorB4 A, VectorB4 B)
        {
            return (Byte)((A.x * B.x)
                + (A.y * B.y)
                + (A.z * B.z)
                + (A.w * B.w));
        }

        public static Int32 DotPI(VectorB4 A, VectorB4 B)
        {
            return (Int32)((Int32)(A.x * B.x)
                + (Int32)(A.y * B.y)
                + (Int32)(A.z * B.z)
                + (Int32)(A.w * B.w));
        }

        public static Double DotP(VectorD2 A, VectorD2 B)
        {
            return (Double)((A.x * B.x)
                + (A.y * B.y));
        }

        public static Double DotP(VectorD3 A, VectorD3 B)
        {
            return (Double)((A.x * B.x)
                + (A.y * B.y)
                + (A.z * B.z));
        }

        public static Double DotP(VectorD4 A, VectorD4 B)
        {
            return (Double)((A.x * B.x)
                + (A.y * B.y)
                + (A.z * B.z)
                + (A.w * B.w));
        }

        public static Single DotP(Vector2 A, Vector2 B)
        {
            return (Single)((A.x * B.x)
                + (A.y * B.y));
        }

        public static Double DotPD(Vector2 A, Vector2 B)
        {
            return (Double)((Double)(A.x * B.x)
                + (Double)(A.y * B.y));
        }

        public static Single DotP(Vector3 A, Vector3 B)
        {
            return (Single)((A.x * B.x)
                + (A.y * B.y)
                + (A.z * B.z));
        }

        public static Double DotPD(Vector3 A, Vector3 B)
        {
            return (Double)((Double)(A.x * B.x)
                + (Double)(A.y * B.y)
                + (Double)(A.z * B.z));
        }

        public static Single DotP(Vector4 A, Vector4 B)
        {
            return (Single)((A.x * B.x)
                + (A.y * B.y)
                + (A.z * B.z)
                + (A.w * B.w));
        }

        public static Double DotPD(Vector4 A, Vector4 B)
        {
            return (Double)((Double)(A.x * B.x)
                + (Double)(A.y * B.y)
                + (Double)(A.z * B.z)
                + (Double)(A.w * B.w));
        }

        // Square length
        public static Int32 SqLen(VectorI2 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLen(VectorI3 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLen(VectorI4 V)
        {
            return DotP(V,V);
        }

        public static Byte SqLen(VectorB2 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLenI(VectorB2 V)
        {
            return DotPI(V,V);
        }

        public static Byte SqLen(VectorB3 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLenI(VectorB3 V)
        {
            return DotPI(V,V);
        }

        public static Byte SqLen(VectorB4 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLenI(VectorB4 V)
        {
            return DotPI(V,V);
        }

        public static Double SqLen(VectorD2 V)
        {
            return DotP(V,V);
        }

        public static Double SqLen(VectorD3 V)
        {
            return DotP(V,V);
        }

        public static Double SqLen(VectorD4 V)
        {
            return DotP(V,V);
        }

        public static Single SqLen(Vector2 V)
        {
            return DotP(V,V);
        }

        public static Double SqLenD(Vector2 V)
        {
            return DotPD(V,V);
        }

        public static Single SqLen(Vector3 V)
        {
            return DotP(V,V);
        }

        public static Double SqLenD(Vector3 V)
        {
            return DotPD(V,V);
        }

        public static Single SqLen(Vector4 V)
        {
            return DotP(V,V);
        }

        public static Double SqLenD(Vector4 V)
        {
            return DotPD(V,V);
        }

        // Manhattan length operators (ie sum of components)
        public static Int32 ManhatLength(VectorI2 V)
        {
            return (Int32)(V.x + V.y);
        }

        public static Int32 ManhatLength(VectorI3 V)
        {
            return (Int32)(V.x + V.y + V.z);
        }

        public static Int32 ManhatLength(VectorI4 V)
        {
            return (Int32)(V.x + V.y + V.z + V.w);
        }

        public static Byte ManhatLength(VectorB2 V)
        {
            return (Byte)(V.x + V.y);
        }

        public static Byte ManhatLength(VectorB3 V)
        {
            return (Byte)(V.x + V.y + V.z);
        }

        public static Byte ManhatLength(VectorB4 V)
        {
            return (Byte)(V.x + V.y + V.z + V.w);
        }

        public static Double ManhatLength(VectorD2 V)
        {
            return (Double)(V.x + V.y);
        }

        public static Double ManhatLength(VectorD3 V)
        {
            return (Double)(V.x + V.y + V.z);
        }

        public static Double ManhatLength(VectorD4 V)
        {
            return (Double)(V.x + V.y + V.z + V.w);
        }

        public static Single ManhatLength(Vector2 V)
        {
            return (Single)(V.x + V.y);
        }

        public static Single ManhatLength(Vector3 V)
        {
            return (Single)(V.x + V.y + V.z);
        }

        public static Single ManhatLength(Vector4 V)
        {
            return (Single)(V.x + V.y + V.z + V.w);
        }

        // Vector length (as in, euclidean)
        public static Double Len(VectorD2 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static Double Len(VectorD3 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static Double Len(VectorD4 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static Single Len(Vector2 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static Single Len(Vector3 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static Single Len(Vector4 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        // Normalized vector
        public static VectorD2 Norm(VectorD2 V)
        {
            return V/Len(V);
        }

        public static VectorD3 Norm(VectorD3 V)
        {
            return V/Len(V);
        }

        public static VectorD4 Norm(VectorD4 V)
        {
            return V/Len(V);
        }

        public static Vector2 Norm(Vector2 V)
        {
            return V/Len(V);
        }

        public static Vector3 Norm(Vector3 V)
        {
            return V/Len(V);
        }

        public static Vector4 Norm(Vector4 V)
        {
            return V/Len(V);
        }

        // Product of components of vector
        public static Int32 Volume(VectorI2 V)
        {
            return (Int32)(V.x * V.y);
        }

        public static Int32 Volume(VectorI3 V)
        {
            return (Int32)(V.x * V.y * V.z);
        }

        public static Int32 Volume(VectorI4 V)
        {
            return (Int32)(V.x * V.y * V.z * V.w);
        }

        public static Byte Volume(VectorB2 V)
        {
            return (Byte)(V.x * V.y);
        }

        public static Int32 VolumeI(VectorB2 V)
        {
            return (Int32)(V.x * V.y);
        }

        public static Byte Volume(VectorB3 V)
        {
            return (Byte)(V.x * V.y * V.z);
        }

        public static Int32 VolumeI(VectorB3 V)
        {
            return (Int32)(V.x * V.y * V.z);
        }

        public static Byte Volume(VectorB4 V)
        {
            return (Byte)(V.x * V.y * V.z * V.w);
        }

        public static Int32 VolumeI(VectorB4 V)
        {
            return (Int32)(V.x * V.y * V.z * V.w);
        }

        public static Double Volume(VectorD2 V)
        {
            return (Double)(V.x * V.y);
        }

        public static Double Volume(VectorD3 V)
        {
            return (Double)(V.x * V.y * V.z);
        }

        public static Double Volume(VectorD4 V)
        {
            return (Double)(V.x * V.y * V.z * V.w);
        }

        public static Single Volume(Vector2 V)
        {
            return (Single)(V.x * V.y);
        }

        public static Double VolumeD(Vector2 V)
        {
            return (Double)(V.x * V.y);
        }

        public static Single Volume(Vector3 V)
        {
            return (Single)(V.x * V.y * V.z);
        }

        public static Double VolumeD(Vector3 V)
        {
            return (Double)(V.x * V.y * V.z);
        }

        public static Single Volume(Vector4 V)
        {
            return (Single)(V.x * V.y * V.z * V.w);
        }

        public static Double VolumeD(Vector4 V)
        {
            return (Double)(V.x * V.y * V.z * V.w);
        }

        public static Int32 Pow2Volume(VectorI2 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y));
        }

        public static Int32 Pow2Volume(VectorI3 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z));
        }

        public static Int32 Pow2Volume(VectorI4 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z + V.w));
        }

        public static Byte Pow2Volume(VectorB2 V)
        {
            return Arith.Pow2Mult((Byte)1, (Byte)(V.x + V.y));
        }

        public static Int32 Pow2VolumeI(VectorB2 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y));
        }

        public static Byte Pow2Volume(VectorB3 V)
        {
            return Arith.Pow2Mult((Byte)1, (Byte)(V.x + V.y + V.z));
        }

        public static Int32 Pow2VolumeI(VectorB3 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z));
        }

        public static Byte Pow2Volume(VectorB4 V)
        {
            return Arith.Pow2Mult((Byte)1, (Byte)(V.x + V.y + V.z + V.w));
        }

        public static Int32 Pow2VolumeI(VectorB4 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z + V.w));
        }

        // Cross product
        public static VectorI3 CrossP(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (A.y * B.z) - (A.z * B.y),
                -(A.x * B.z) + (A.z * B.x),
                (A.x * B.y) - (A.y * B.x));
        }

        public static VectorD3 CrossP(VectorD3 A, VectorD3 B)
        {
            return OHV.MkVectorD3(
                (A.y * B.z) - (A.z * B.y),
                -(A.x * B.z) + (A.z * B.x),
                (A.x * B.y) - (A.y * B.x));
        }

        public static Vector3 CrossP(Vector3 A, Vector3 B)
        {
            return OHV.MkVector3(
                (A.y * B.z) - (A.z * B.y),
                -(A.x * B.z) + (A.z * B.x),
                (A.x * B.y) - (A.y * B.x));
        }

        // Some C#-specific functions
        public static VectorI2 Select(VectorI2 V, Func<Int32, Int32> func)
        {
            return OHV.MkVectorI2(
                (Int32)(func(V.x)),
                (Int32)(func(V.y)));
        }

        public static VectorI3 Select(VectorI3 V, Func<Int32, Int32> func)
        {
            return OHV.MkVectorI3(
                (Int32)(func(V.x)),
                (Int32)(func(V.y)),
                (Int32)(func(V.z)));
        }

        public static VectorI4 Select(VectorI4 V, Func<Int32, Int32> func)
        {
            return OHV.MkVectorI4(
                (Int32)(func(V.x)),
                (Int32)(func(V.y)),
                (Int32)(func(V.z)),
                (Int32)(func(V.w)));
        }

        public static VectorB2 Select(VectorB2 V, Func<Byte, Byte> func)
        {
            return OHV.MkVectorB2(
                (Byte)(func(V.x)),
                (Byte)(func(V.y)));
        }

        public static VectorB3 Select(VectorB3 V, Func<Byte, Byte> func)
        {
            return OHV.MkVectorB3(
                (Byte)(func(V.x)),
                (Byte)(func(V.y)),
                (Byte)(func(V.z)));
        }

        public static VectorB4 Select(VectorB4 V, Func<Byte, Byte> func)
        {
            return OHV.MkVectorB4(
                (Byte)(func(V.x)),
                (Byte)(func(V.y)),
                (Byte)(func(V.z)),
                (Byte)(func(V.w)));
        }

        public static VectorD2 Select(VectorD2 V, Func<Double, Double> func)
        {
            return OHV.MkVectorD2(
                (Double)(func(V.x)),
                (Double)(func(V.y)));
        }

        public static VectorD3 Select(VectorD3 V, Func<Double, Double> func)
        {
            return OHV.MkVectorD3(
                (Double)(func(V.x)),
                (Double)(func(V.y)),
                (Double)(func(V.z)));
        }

        public static VectorD4 Select(VectorD4 V, Func<Double, Double> func)
        {
            return OHV.MkVectorD4(
                (Double)(func(V.x)),
                (Double)(func(V.y)),
                (Double)(func(V.z)),
                (Double)(func(V.w)));
        }

        public static Vector2 Select(Vector2 V, Func<Single, Single> func)
        {
            return OHV.MkVector2(
                (Single)(func(V.x)),
                (Single)(func(V.y)));
        }

        public static Vector3 Select(Vector3 V, Func<Single, Single> func)
        {
            return OHV.MkVector3(
                (Single)(func(V.x)),
                (Single)(func(V.y)),
                (Single)(func(V.z)));
        }

        public static Vector4 Select(Vector4 V, Func<Single, Single> func)
        {
            return OHV.MkVector4(
                (Single)(func(V.x)),
                (Single)(func(V.y)),
                (Single)(func(V.z)),
                (Single)(func(V.w)));
        }

        public static Int32[] Members(VectorI2 V)
        {
            return new[] { V.x, V.y };
        }

        public static Int32[] Members(VectorI3 V)
        {
            return new[] { V.x, V.y, V.z };
        }

        public static Int32[] Members(VectorI4 V)
        {
            return new[] { V.x, V.y, V.z, V.w };
        }

        public static Byte[] Members(VectorB2 V)
        {
            return new[] { V.x, V.y };
        }

        public static Byte[] Members(VectorB3 V)
        {
            return new[] { V.x, V.y, V.z };
        }

        public static Byte[] Members(VectorB4 V)
        {
            return new[] { V.x, V.y, V.z, V.w };
        }

        public static Double[] Members(VectorD2 V)
        {
            return new[] { V.x, V.y };
        }

        public static Double[] Members(VectorD3 V)
        {
            return new[] { V.x, V.y, V.z };
        }

        public static Double[] Members(VectorD4 V)
        {
            return new[] { V.x, V.y, V.z, V.w };
        }

        public static Single[] Members(Vector2 V)
        {
            return new[] { V.x, V.y };
        }

        public static Single[] Members(Vector3 V)
        {
            return new[] { V.x, V.y, V.z };
        }

        public static Single[] Members(Vector4 V)
        {
            return new[] { V.x, V.y, V.z, V.w };
        }

        public static VectorI2 ToVectorI2(System.Collections.Generic.IEnumerable<Int32> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return OHV.MkVectorI2(array[0], array[1]);
        }

        public static VectorI3 ToVectorI3(System.Collections.Generic.IEnumerable<Int32> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return OHV.MkVectorI3(array[0], array[1], array[2]);
        }

        public static VectorI4 ToVectorI4(System.Collections.Generic.IEnumerable<Int32> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return OHV.MkVectorI4(array[0], array[1], array[2], array[3]);
        }

        public static VectorB2 ToVectorB2(System.Collections.Generic.IEnumerable<Byte> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return OHV.MkVectorB2(array[0], array[1]);
        }

        public static VectorB3 ToVectorB3(System.Collections.Generic.IEnumerable<Byte> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return OHV.MkVectorB3(array[0], array[1], array[2]);
        }

        public static VectorB4 ToVectorB4(System.Collections.Generic.IEnumerable<Byte> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return OHV.MkVectorB4(array[0], array[1], array[2], array[3]);
        }

        public static VectorD2 ToVectorD2(System.Collections.Generic.IEnumerable<Double> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return OHV.MkVectorD2(array[0], array[1]);
        }

        public static VectorD3 ToVectorD3(System.Collections.Generic.IEnumerable<Double> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return OHV.MkVectorD3(array[0], array[1], array[2]);
        }

        public static VectorD4 ToVectorD4(System.Collections.Generic.IEnumerable<Double> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return OHV.MkVectorD4(array[0], array[1], array[2], array[3]);
        }

        public static Vector2 ToVector2(System.Collections.Generic.IEnumerable<Single> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return OHV.MkVector2(array[0], array[1]);
        }

        public static Vector3 ToVector3(System.Collections.Generic.IEnumerable<Single> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return OHV.MkVector3(array[0], array[1], array[2]);
        }

        public static Vector4 ToVector4(System.Collections.Generic.IEnumerable<Single> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return OHV.MkVector4(array[0], array[1], array[2], array[3]);
        }

        public static void VisitElements(ref VectorI2 V, Visitor<Int32> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
        }

        public static void VisitElements(ref VectorI3 V, Visitor<Int32> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
            visitor(ref V.z);
        }

        public static void VisitElements(ref VectorI4 V, Visitor<Int32> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
            visitor(ref V.z);
            visitor(ref V.w);
        }

        public static void VisitElements(ref VectorB2 V, Visitor<Byte> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
        }

        public static void VisitElements(ref VectorB3 V, Visitor<Byte> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
            visitor(ref V.z);
        }

        public static void VisitElements(ref VectorB4 V, Visitor<Byte> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
            visitor(ref V.z);
            visitor(ref V.w);
        }

        public static void VisitElements(ref VectorD2 V, Visitor<Double> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
        }

        public static void VisitElements(ref VectorD3 V, Visitor<Double> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
            visitor(ref V.z);
        }

        public static void VisitElements(ref VectorD4 V, Visitor<Double> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
            visitor(ref V.z);
            visitor(ref V.w);
        }

        public static void VisitElements(ref Vector2 V, Visitor<Single> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
        }

        public static void VisitElements(ref Vector3 V, Visitor<Single> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
            visitor(ref V.z);
        }

        public static void VisitElements(ref Vector4 V, Visitor<Single> visitor)
        {
            visitor(ref V.x);
            visitor(ref V.y);
            visitor(ref V.z);
            visitor(ref V.w);
        }

    }
}