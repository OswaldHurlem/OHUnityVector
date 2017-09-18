// Generated with oh_unity_vector_generator.py
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEditor;

namespace OH
{
    public static partial class VecOps
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

        public static VectorI2 MkVectorI2B(byte x, byte y)
        {
            VectorI2 V;
            V.x = (Int32)(x);
            V.y = (Int32)(y);
            return V;
        }

        public static VectorI2 MkVectorI2B(byte A)
        {
            VectorI2 V;
            V.x = (Int32)(A);
            V.y = (Int32)(A);
            return V;
        }

        public static VectorI2 MkVectorI2D(double x, double y)
        {
            VectorI2 V;
            V.x = Arith.FloorID(x);
            V.y = Arith.FloorID(y);
            return V;
        }

        public static VectorI2 MkVectorI2D(double A)
        {
            VectorI2 V;
            V.x = Arith.FloorID(A);
            V.y = Arith.FloorID(A);
            return V;
        }

        public static VectorI2 MkVectorI2F(float x, float y)
        {
            VectorI2 V;
            V.x = Arith.FloorIF(x);
            V.y = Arith.FloorIF(y);
            return V;
        }

        public static VectorI2 MkVectorI2F(float A)
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

        public static VectorI3 MkVectorI3B(byte x, byte y, byte z)
        {
            VectorI3 V;
            V.x = (Int32)(x);
            V.y = (Int32)(y);
            V.z = (Int32)(z);
            return V;
        }

        public static VectorI3 MkVectorI3B(byte A)
        {
            VectorI3 V;
            V.x = (Int32)(A);
            V.y = (Int32)(A);
            V.z = (Int32)(A);
            return V;
        }

        public static VectorI3 MkVectorI3D(double x, double y, double z)
        {
            VectorI3 V;
            V.x = Arith.FloorID(x);
            V.y = Arith.FloorID(y);
            V.z = Arith.FloorID(z);
            return V;
        }

        public static VectorI3 MkVectorI3D(double A)
        {
            VectorI3 V;
            V.x = Arith.FloorID(A);
            V.y = Arith.FloorID(A);
            V.z = Arith.FloorID(A);
            return V;
        }

        public static VectorI3 MkVectorI3F(float x, float y, float z)
        {
            VectorI3 V;
            V.x = Arith.FloorIF(x);
            V.y = Arith.FloorIF(y);
            V.z = Arith.FloorIF(z);
            return V;
        }

        public static VectorI3 MkVectorI3F(float A)
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

        public static VectorI4 MkVectorI4B(byte x, byte y, byte z, byte w)
        {
            VectorI4 V;
            V.x = (Int32)(x);
            V.y = (Int32)(y);
            V.z = (Int32)(z);
            V.w = (Int32)(w);
            return V;
        }

        public static VectorI4 MkVectorI4B(byte A)
        {
            VectorI4 V;
            V.x = (Int32)(A);
            V.y = (Int32)(A);
            V.z = (Int32)(A);
            V.w = (Int32)(A);
            return V;
        }

        public static VectorI4 MkVectorI4D(double x, double y, double z, double w)
        {
            VectorI4 V;
            V.x = Arith.FloorID(x);
            V.y = Arith.FloorID(y);
            V.z = Arith.FloorID(z);
            V.w = Arith.FloorID(w);
            return V;
        }

        public static VectorI4 MkVectorI4D(double A)
        {
            VectorI4 V;
            V.x = Arith.FloorID(A);
            V.y = Arith.FloorID(A);
            V.z = Arith.FloorID(A);
            V.w = Arith.FloorID(A);
            return V;
        }

        public static VectorI4 MkVectorI4F(float x, float y, float z, float w)
        {
            VectorI4 V;
            V.x = Arith.FloorIF(x);
            V.y = Arith.FloorIF(y);
            V.z = Arith.FloorIF(z);
            V.w = Arith.FloorIF(w);
            return V;
        }

        public static VectorI4 MkVectorI4F(float A)
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
            V.x = (byte)(x);
            V.y = (byte)(y);
            return V;
        }

        public static VectorB2 MkVectorB2I(Int32 A)
        {
            VectorB2 V;
            V.x = (byte)(A);
            V.y = (byte)(A);
            return V;
        }

        public static VectorB2 MkVectorB2(byte x, byte y)
        {
            VectorB2 V;
            V.x = (byte)(x);
            V.y = (byte)(y);
            return V;
        }

        public static VectorB2 MkVectorB2(byte A)
        {
            VectorB2 V;
            V.x = (byte)(A);
            V.y = (byte)(A);
            return V;
        }

        public static VectorB2 MkVectorB2D(double x, double y)
        {
            VectorB2 V;
            V.x = Arith.FloorBD(x);
            V.y = Arith.FloorBD(y);
            return V;
        }

        public static VectorB2 MkVectorB2D(double A)
        {
            VectorB2 V;
            V.x = Arith.FloorBD(A);
            V.y = Arith.FloorBD(A);
            return V;
        }

        public static VectorB2 MkVectorB2F(float x, float y)
        {
            VectorB2 V;
            V.x = Arith.FloorBF(x);
            V.y = Arith.FloorBF(y);
            return V;
        }

        public static VectorB2 MkVectorB2F(float A)
        {
            VectorB2 V;
            V.x = Arith.FloorBF(A);
            V.y = Arith.FloorBF(A);
            return V;
        }

        public static VectorB3 MkVectorB3I(Int32 x, Int32 y, Int32 z)
        {
            VectorB3 V;
            V.x = (byte)(x);
            V.y = (byte)(y);
            V.z = (byte)(z);
            return V;
        }

        public static VectorB3 MkVectorB3I(Int32 A)
        {
            VectorB3 V;
            V.x = (byte)(A);
            V.y = (byte)(A);
            V.z = (byte)(A);
            return V;
        }

        public static VectorB3 MkVectorB3(byte x, byte y, byte z)
        {
            VectorB3 V;
            V.x = (byte)(x);
            V.y = (byte)(y);
            V.z = (byte)(z);
            return V;
        }

        public static VectorB3 MkVectorB3(byte A)
        {
            VectorB3 V;
            V.x = (byte)(A);
            V.y = (byte)(A);
            V.z = (byte)(A);
            return V;
        }

        public static VectorB3 MkVectorB3D(double x, double y, double z)
        {
            VectorB3 V;
            V.x = Arith.FloorBD(x);
            V.y = Arith.FloorBD(y);
            V.z = Arith.FloorBD(z);
            return V;
        }

        public static VectorB3 MkVectorB3D(double A)
        {
            VectorB3 V;
            V.x = Arith.FloorBD(A);
            V.y = Arith.FloorBD(A);
            V.z = Arith.FloorBD(A);
            return V;
        }

        public static VectorB3 MkVectorB3F(float x, float y, float z)
        {
            VectorB3 V;
            V.x = Arith.FloorBF(x);
            V.y = Arith.FloorBF(y);
            V.z = Arith.FloorBF(z);
            return V;
        }

        public static VectorB3 MkVectorB3F(float A)
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
            V.x = (byte)(x);
            V.y = (byte)(y);
            V.z = (byte)(z);
            V.w = (byte)(w);
            return V;
        }

        public static VectorB4 MkVectorB4I(Int32 A)
        {
            VectorB4 V;
            V.x = (byte)(A);
            V.y = (byte)(A);
            V.z = (byte)(A);
            V.w = (byte)(A);
            return V;
        }

        public static VectorB4 MkVectorB4(byte x, byte y, byte z, byte w)
        {
            VectorB4 V;
            V.x = (byte)(x);
            V.y = (byte)(y);
            V.z = (byte)(z);
            V.w = (byte)(w);
            return V;
        }

        public static VectorB4 MkVectorB4(byte A)
        {
            VectorB4 V;
            V.x = (byte)(A);
            V.y = (byte)(A);
            V.z = (byte)(A);
            V.w = (byte)(A);
            return V;
        }

        public static VectorB4 MkVectorB4D(double x, double y, double z, double w)
        {
            VectorB4 V;
            V.x = Arith.FloorBD(x);
            V.y = Arith.FloorBD(y);
            V.z = Arith.FloorBD(z);
            V.w = Arith.FloorBD(w);
            return V;
        }

        public static VectorB4 MkVectorB4D(double A)
        {
            VectorB4 V;
            V.x = Arith.FloorBD(A);
            V.y = Arith.FloorBD(A);
            V.z = Arith.FloorBD(A);
            V.w = Arith.FloorBD(A);
            return V;
        }

        public static VectorB4 MkVectorB4F(float x, float y, float z, float w)
        {
            VectorB4 V;
            V.x = Arith.FloorBF(x);
            V.y = Arith.FloorBF(y);
            V.z = Arith.FloorBF(z);
            V.w = Arith.FloorBF(w);
            return V;
        }

        public static VectorB4 MkVectorB4F(float A)
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
            V.x = (double)(x);
            V.y = (double)(y);
            return V;
        }

        public static VectorD2 MkVectorD2I(Int32 A)
        {
            VectorD2 V;
            V.x = (double)(A);
            V.y = (double)(A);
            return V;
        }

        public static VectorD2 MkVectorD2B(byte x, byte y)
        {
            VectorD2 V;
            V.x = (double)(x);
            V.y = (double)(y);
            return V;
        }

        public static VectorD2 MkVectorD2B(byte A)
        {
            VectorD2 V;
            V.x = (double)(A);
            V.y = (double)(A);
            return V;
        }

        public static VectorD2 MkVectorD2(double x, double y)
        {
            VectorD2 V;
            V.x = (double)(x);
            V.y = (double)(y);
            return V;
        }

        public static VectorD2 MkVectorD2(double A)
        {
            VectorD2 V;
            V.x = (double)(A);
            V.y = (double)(A);
            return V;
        }

        public static VectorD2 MkVectorD2F(float x, float y)
        {
            VectorD2 V;
            V.x = (double)(x);
            V.y = (double)(y);
            return V;
        }

        public static VectorD2 MkVectorD2F(float A)
        {
            VectorD2 V;
            V.x = (double)(A);
            V.y = (double)(A);
            return V;
        }

        public static VectorD3 MkVectorD3I(Int32 x, Int32 y, Int32 z)
        {
            VectorD3 V;
            V.x = (double)(x);
            V.y = (double)(y);
            V.z = (double)(z);
            return V;
        }

        public static VectorD3 MkVectorD3I(Int32 A)
        {
            VectorD3 V;
            V.x = (double)(A);
            V.y = (double)(A);
            V.z = (double)(A);
            return V;
        }

        public static VectorD3 MkVectorD3B(byte x, byte y, byte z)
        {
            VectorD3 V;
            V.x = (double)(x);
            V.y = (double)(y);
            V.z = (double)(z);
            return V;
        }

        public static VectorD3 MkVectorD3B(byte A)
        {
            VectorD3 V;
            V.x = (double)(A);
            V.y = (double)(A);
            V.z = (double)(A);
            return V;
        }

        public static VectorD3 MkVectorD3(double x, double y, double z)
        {
            VectorD3 V;
            V.x = (double)(x);
            V.y = (double)(y);
            V.z = (double)(z);
            return V;
        }

        public static VectorD3 MkVectorD3(double A)
        {
            VectorD3 V;
            V.x = (double)(A);
            V.y = (double)(A);
            V.z = (double)(A);
            return V;
        }

        public static VectorD3 MkVectorD3F(float x, float y, float z)
        {
            VectorD3 V;
            V.x = (double)(x);
            V.y = (double)(y);
            V.z = (double)(z);
            return V;
        }

        public static VectorD3 MkVectorD3F(float A)
        {
            VectorD3 V;
            V.x = (double)(A);
            V.y = (double)(A);
            V.z = (double)(A);
            return V;
        }

        public static VectorD4 MkVectorD4I(Int32 x, Int32 y, Int32 z, Int32 w)
        {
            VectorD4 V;
            V.x = (double)(x);
            V.y = (double)(y);
            V.z = (double)(z);
            V.w = (double)(w);
            return V;
        }

        public static VectorD4 MkVectorD4I(Int32 A)
        {
            VectorD4 V;
            V.x = (double)(A);
            V.y = (double)(A);
            V.z = (double)(A);
            V.w = (double)(A);
            return V;
        }

        public static VectorD4 MkVectorD4B(byte x, byte y, byte z, byte w)
        {
            VectorD4 V;
            V.x = (double)(x);
            V.y = (double)(y);
            V.z = (double)(z);
            V.w = (double)(w);
            return V;
        }

        public static VectorD4 MkVectorD4B(byte A)
        {
            VectorD4 V;
            V.x = (double)(A);
            V.y = (double)(A);
            V.z = (double)(A);
            V.w = (double)(A);
            return V;
        }

        public static VectorD4 MkVectorD4(double x, double y, double z, double w)
        {
            VectorD4 V;
            V.x = (double)(x);
            V.y = (double)(y);
            V.z = (double)(z);
            V.w = (double)(w);
            return V;
        }

        public static VectorD4 MkVectorD4(double A)
        {
            VectorD4 V;
            V.x = (double)(A);
            V.y = (double)(A);
            V.z = (double)(A);
            V.w = (double)(A);
            return V;
        }

        public static VectorD4 MkVectorD4F(float x, float y, float z, float w)
        {
            VectorD4 V;
            V.x = (double)(x);
            V.y = (double)(y);
            V.z = (double)(z);
            V.w = (double)(w);
            return V;
        }

        public static VectorD4 MkVectorD4F(float A)
        {
            VectorD4 V;
            V.x = (double)(A);
            V.y = (double)(A);
            V.z = (double)(A);
            V.w = (double)(A);
            return V;
        }

        public static Vector2 MkVector2I(Int32 x, Int32 y)
        {
            Vector2 V;
            V.x = (float)(x);
            V.y = (float)(y);
            return V;
        }

        public static Vector2 MkVector2I(Int32 A)
        {
            Vector2 V;
            V.x = (float)(A);
            V.y = (float)(A);
            return V;
        }

        public static Vector2 MkVector2B(byte x, byte y)
        {
            Vector2 V;
            V.x = (float)(x);
            V.y = (float)(y);
            return V;
        }

        public static Vector2 MkVector2B(byte A)
        {
            Vector2 V;
            V.x = (float)(A);
            V.y = (float)(A);
            return V;
        }

        public static Vector2 MkVector2D(double x, double y)
        {
            Vector2 V;
            V.x = (float)(x);
            V.y = (float)(y);
            return V;
        }

        public static Vector2 MkVector2D(double A)
        {
            Vector2 V;
            V.x = (float)(A);
            V.y = (float)(A);
            return V;
        }

        public static Vector2 MkVector2(float x, float y)
        {
            Vector2 V;
            V.x = (float)(x);
            V.y = (float)(y);
            return V;
        }

        public static Vector2 MkVector2(float A)
        {
            Vector2 V;
            V.x = (float)(A);
            V.y = (float)(A);
            return V;
        }

        public static Vector3 MkVector3I(Int32 x, Int32 y, Int32 z)
        {
            Vector3 V;
            V.x = (float)(x);
            V.y = (float)(y);
            V.z = (float)(z);
            return V;
        }

        public static Vector3 MkVector3I(Int32 A)
        {
            Vector3 V;
            V.x = (float)(A);
            V.y = (float)(A);
            V.z = (float)(A);
            return V;
        }

        public static Vector3 MkVector3B(byte x, byte y, byte z)
        {
            Vector3 V;
            V.x = (float)(x);
            V.y = (float)(y);
            V.z = (float)(z);
            return V;
        }

        public static Vector3 MkVector3B(byte A)
        {
            Vector3 V;
            V.x = (float)(A);
            V.y = (float)(A);
            V.z = (float)(A);
            return V;
        }

        public static Vector3 MkVector3D(double x, double y, double z)
        {
            Vector3 V;
            V.x = (float)(x);
            V.y = (float)(y);
            V.z = (float)(z);
            return V;
        }

        public static Vector3 MkVector3D(double A)
        {
            Vector3 V;
            V.x = (float)(A);
            V.y = (float)(A);
            V.z = (float)(A);
            return V;
        }

        public static Vector3 MkVector3(float x, float y, float z)
        {
            Vector3 V;
            V.x = (float)(x);
            V.y = (float)(y);
            V.z = (float)(z);
            return V;
        }

        public static Vector3 MkVector3(float A)
        {
            Vector3 V;
            V.x = (float)(A);
            V.y = (float)(A);
            V.z = (float)(A);
            return V;
        }

        public static Vector4 MkVector4I(Int32 x, Int32 y, Int32 z, Int32 w)
        {
            Vector4 V;
            V.x = (float)(x);
            V.y = (float)(y);
            V.z = (float)(z);
            V.w = (float)(w);
            return V;
        }

        public static Vector4 MkVector4I(Int32 A)
        {
            Vector4 V;
            V.x = (float)(A);
            V.y = (float)(A);
            V.z = (float)(A);
            V.w = (float)(A);
            return V;
        }

        public static Vector4 MkVector4B(byte x, byte y, byte z, byte w)
        {
            Vector4 V;
            V.x = (float)(x);
            V.y = (float)(y);
            V.z = (float)(z);
            V.w = (float)(w);
            return V;
        }

        public static Vector4 MkVector4B(byte A)
        {
            Vector4 V;
            V.x = (float)(A);
            V.y = (float)(A);
            V.z = (float)(A);
            V.w = (float)(A);
            return V;
        }

        public static Vector4 MkVector4D(double x, double y, double z, double w)
        {
            Vector4 V;
            V.x = (float)(x);
            V.y = (float)(y);
            V.z = (float)(z);
            V.w = (float)(w);
            return V;
        }

        public static Vector4 MkVector4D(double A)
        {
            Vector4 V;
            V.x = (float)(A);
            V.y = (float)(A);
            V.z = (float)(A);
            V.w = (float)(A);
            return V;
        }

        public static Vector4 MkVector4(float x, float y, float z, float w)
        {
            Vector4 V;
            V.x = (float)(x);
            V.y = (float)(y);
            V.z = (float)(z);
            V.w = (float)(w);
            return V;
        }

        public static Vector4 MkVector4(float A)
        {
            Vector4 V;
            V.x = (float)(A);
            V.y = (float)(A);
            V.z = (float)(A);
            V.w = (float)(A);
            return V;
        }

        // Constructors from other vectors. Float converts to int using floor
        public static VectorI2 MkVectorI2B(VectorB2 V)
        {
            return VecOps.MkVectorI2B(V.x, V.y);
        }

        public static VectorI2 MkVectorI2D(VectorD2 V)
        {
            return VecOps.MkVectorI2D(V.x, V.y);
        }

        public static VectorI2 MkVectorI2F(Vector2 V)
        {
            return VecOps.MkVectorI2F(V.x, V.y);
        }

        public static VectorI3 MkVectorI3B(VectorB3 V)
        {
            return VecOps.MkVectorI3B(V.x, V.y, V.z);
        }

        public static VectorI3 MkVectorI3D(VectorD3 V)
        {
            return VecOps.MkVectorI3D(V.x, V.y, V.z);
        }

        public static VectorI3 MkVectorI3F(Vector3 V)
        {
            return VecOps.MkVectorI3F(V.x, V.y, V.z);
        }

        public static VectorI4 MkVectorI4B(VectorB4 V)
        {
            return VecOps.MkVectorI4B(V.x, V.y, V.z, V.w);
        }

        public static VectorI4 MkVectorI4D(VectorD4 V)
        {
            return VecOps.MkVectorI4D(V.x, V.y, V.z, V.w);
        }

        public static VectorI4 MkVectorI4F(Vector4 V)
        {
            return VecOps.MkVectorI4F(V.x, V.y, V.z, V.w);
        }

        public static VectorB2 MkVectorB2I(VectorI2 V)
        {
            return VecOps.MkVectorB2I(V.x, V.y);
        }

        public static VectorB2 MkVectorB2D(VectorD2 V)
        {
            return VecOps.MkVectorB2D(V.x, V.y);
        }

        public static VectorB2 MkVectorB2F(Vector2 V)
        {
            return VecOps.MkVectorB2F(V.x, V.y);
        }

        public static VectorB3 MkVectorB3I(VectorI3 V)
        {
            return VecOps.MkVectorB3I(V.x, V.y, V.z);
        }

        public static VectorB3 MkVectorB3D(VectorD3 V)
        {
            return VecOps.MkVectorB3D(V.x, V.y, V.z);
        }

        public static VectorB3 MkVectorB3F(Vector3 V)
        {
            return VecOps.MkVectorB3F(V.x, V.y, V.z);
        }

        public static VectorB4 MkVectorB4I(VectorI4 V)
        {
            return VecOps.MkVectorB4I(V.x, V.y, V.z, V.w);
        }

        public static VectorB4 MkVectorB4D(VectorD4 V)
        {
            return VecOps.MkVectorB4D(V.x, V.y, V.z, V.w);
        }

        public static VectorB4 MkVectorB4F(Vector4 V)
        {
            return VecOps.MkVectorB4F(V.x, V.y, V.z, V.w);
        }

        public static VectorD2 MkVectorD2I(VectorI2 V)
        {
            return VecOps.MkVectorD2I(V.x, V.y);
        }

        public static VectorD2 MkVectorD2B(VectorB2 V)
        {
            return VecOps.MkVectorD2B(V.x, V.y);
        }

        public static VectorD2 MkVectorD2F(Vector2 V)
        {
            return VecOps.MkVectorD2F(V.x, V.y);
        }

        public static VectorD3 MkVectorD3I(VectorI3 V)
        {
            return VecOps.MkVectorD3I(V.x, V.y, V.z);
        }

        public static VectorD3 MkVectorD3B(VectorB3 V)
        {
            return VecOps.MkVectorD3B(V.x, V.y, V.z);
        }

        public static VectorD3 MkVectorD3F(Vector3 V)
        {
            return VecOps.MkVectorD3F(V.x, V.y, V.z);
        }

        public static VectorD4 MkVectorD4I(VectorI4 V)
        {
            return VecOps.MkVectorD4I(V.x, V.y, V.z, V.w);
        }

        public static VectorD4 MkVectorD4B(VectorB4 V)
        {
            return VecOps.MkVectorD4B(V.x, V.y, V.z, V.w);
        }

        public static VectorD4 MkVectorD4F(Vector4 V)
        {
            return VecOps.MkVectorD4F(V.x, V.y, V.z, V.w);
        }

        public static Vector2 MkVector2I(VectorI2 V)
        {
            return VecOps.MkVector2I(V.x, V.y);
        }

        public static Vector2 MkVector2B(VectorB2 V)
        {
            return VecOps.MkVector2B(V.x, V.y);
        }

        public static Vector2 MkVector2D(VectorD2 V)
        {
            return VecOps.MkVector2D(V.x, V.y);
        }

        public static Vector3 MkVector3I(VectorI3 V)
        {
            return VecOps.MkVector3I(V.x, V.y, V.z);
        }

        public static Vector3 MkVector3B(VectorB3 V)
        {
            return VecOps.MkVector3B(V.x, V.y, V.z);
        }

        public static Vector3 MkVector3D(VectorD3 V)
        {
            return VecOps.MkVector3D(V.x, V.y, V.z);
        }

        public static Vector4 MkVector4I(VectorI4 V)
        {
            return VecOps.MkVector4I(V.x, V.y, V.z, V.w);
        }

        public static Vector4 MkVector4B(VectorB4 V)
        {
            return VecOps.MkVector4B(V.x, V.y, V.z, V.w);
        }

        public static Vector4 MkVector4D(VectorD4 V)
        {
            return VecOps.MkVector4D(V.x, V.y, V.z, V.w);
        }

        // Constructors from ceiling rather than floor
        public static VectorI2 CeilVectorI2D(VectorD2 V)
        {
            return VecOps.MkVectorI2D(Arith.CeilID(V.x), Arith.CeilID(V.y));
        }

        public static VectorI2 CeilVectorI2F(Vector2 V)
        {
            return VecOps.MkVectorI2F(Arith.CeilIF(V.x), Arith.CeilIF(V.y));
        }

        public static VectorI3 CeilVectorI3D(VectorD3 V)
        {
            return VecOps.MkVectorI3D(Arith.CeilID(V.x), Arith.CeilID(V.y), Arith.CeilID(V.z));
        }

        public static VectorI3 CeilVectorI3F(Vector3 V)
        {
            return VecOps.MkVectorI3F(Arith.CeilIF(V.x), Arith.CeilIF(V.y), Arith.CeilIF(V.z));
        }

        public static VectorI4 CeilVectorI4D(VectorD4 V)
        {
            return VecOps.MkVectorI4D(Arith.CeilID(V.x), Arith.CeilID(V.y), Arith.CeilID(V.z), Arith.CeilID(V.w));
        }

        public static VectorI4 CeilVectorI4F(Vector4 V)
        {
            return VecOps.MkVectorI4F(Arith.CeilIF(V.x), Arith.CeilIF(V.y), Arith.CeilIF(V.z), Arith.CeilIF(V.w));
        }

        public static VectorB2 CeilVectorB2D(VectorD2 V)
        {
            return VecOps.MkVectorB2D(Arith.CeilBD(V.x), Arith.CeilBD(V.y));
        }

        public static VectorB2 CeilVectorB2F(Vector2 V)
        {
            return VecOps.MkVectorB2F(Arith.CeilBF(V.x), Arith.CeilBF(V.y));
        }

        public static VectorB3 CeilVectorB3D(VectorD3 V)
        {
            return VecOps.MkVectorB3D(Arith.CeilBD(V.x), Arith.CeilBD(V.y), Arith.CeilBD(V.z));
        }

        public static VectorB3 CeilVectorB3F(Vector3 V)
        {
            return VecOps.MkVectorB3F(Arith.CeilBF(V.x), Arith.CeilBF(V.y), Arith.CeilBF(V.z));
        }

        public static VectorB4 CeilVectorB4D(VectorD4 V)
        {
            return VecOps.MkVectorB4D(Arith.CeilBD(V.x), Arith.CeilBD(V.y), Arith.CeilBD(V.z), Arith.CeilBD(V.w));
        }

        public static VectorB4 CeilVectorB4F(Vector4 V)
        {
            return VecOps.MkVectorB4F(Arith.CeilBF(V.x), Arith.CeilBF(V.y), Arith.CeilBF(V.z), Arith.CeilBF(V.w));
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
            return VecOps.MkVectorI2(
                (Int32)(A.x * B.x),
                (Int32)(A.y * B.y));
        }

        public static VectorI3 ElMult(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(A.x * B.x),
                (Int32)(A.y * B.y),
                (Int32)(A.z * B.z));
        }

        public static VectorI4 ElMult(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(A.x * B.x),
                (Int32)(A.y * B.y),
                (Int32)(A.z * B.z),
                (Int32)(A.w * B.w));
        }

        public static VectorB2 ElMult(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(A.x * B.x),
                (byte)(A.y * B.y));
        }

        public static VectorB3 ElMult(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(A.x * B.x),
                (byte)(A.y * B.y),
                (byte)(A.z * B.z));
        }

        public static VectorB4 ElMult(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(A.x * B.x),
                (byte)(A.y * B.y),
                (byte)(A.z * B.z),
                (byte)(A.w * B.w));
        }

        public static VectorD2 ElMult(VectorD2 A, VectorD2 B)
        {
            return VecOps.MkVectorD2(
                (double)(A.x * B.x),
                (double)(A.y * B.y));
        }

        public static VectorD3 ElMult(VectorD3 A, VectorD3 B)
        {
            return VecOps.MkVectorD3(
                (double)(A.x * B.x),
                (double)(A.y * B.y),
                (double)(A.z * B.z));
        }

        public static VectorD4 ElMult(VectorD4 A, VectorD4 B)
        {
            return VecOps.MkVectorD4(
                (double)(A.x * B.x),
                (double)(A.y * B.y),
                (double)(A.z * B.z),
                (double)(A.w * B.w));
        }

        public static Vector2 ElMult(Vector2 A, Vector2 B)
        {
            return VecOps.MkVector2(
                (float)(A.x * B.x),
                (float)(A.y * B.y));
        }

        public static Vector3 ElMult(Vector3 A, Vector3 B)
        {
            return VecOps.MkVector3(
                (float)(A.x * B.x),
                (float)(A.y * B.y),
                (float)(A.z * B.z));
        }

        public static Vector4 ElMult(Vector4 A, Vector4 B)
        {
            return VecOps.MkVector4(
                (float)(A.x * B.x),
                (float)(A.y * B.y),
                (float)(A.z * B.z),
                (float)(A.w * B.w));
        }

        // Elementwise division. Uses floor.
        public static VectorI2 ElDiv(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Div(A.x, B.x)),
                (Int32)(Arith.Div(A.y, B.y)));
        }

        public static VectorI3 ElDiv(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Div(A.x, B.x)),
                (Int32)(Arith.Div(A.y, B.y)),
                (Int32)(Arith.Div(A.z, B.z)));
        }

        public static VectorI4 ElDiv(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Div(A.x, B.x)),
                (Int32)(Arith.Div(A.y, B.y)),
                (Int32)(Arith.Div(A.z, B.z)),
                (Int32)(Arith.Div(A.w, B.w)));
        }

        public static VectorB2 ElDiv(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Div(A.x, B.x)),
                (byte)(Arith.Div(A.y, B.y)));
        }

        public static VectorB3 ElDiv(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Div(A.x, B.x)),
                (byte)(Arith.Div(A.y, B.y)),
                (byte)(Arith.Div(A.z, B.z)));
        }

        public static VectorB4 ElDiv(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Div(A.x, B.x)),
                (byte)(Arith.Div(A.y, B.y)),
                (byte)(Arith.Div(A.z, B.z)),
                (byte)(Arith.Div(A.w, B.w)));
        }

        public static VectorD2 ElDiv(VectorD2 A, VectorD2 B)
        {
            return VecOps.MkVectorD2(
                (double)(Arith.Div(A.x, B.x)),
                (double)(Arith.Div(A.y, B.y)));
        }

        public static VectorD3 ElDiv(VectorD3 A, VectorD3 B)
        {
            return VecOps.MkVectorD3(
                (double)(Arith.Div(A.x, B.x)),
                (double)(Arith.Div(A.y, B.y)),
                (double)(Arith.Div(A.z, B.z)));
        }

        public static VectorD4 ElDiv(VectorD4 A, VectorD4 B)
        {
            return VecOps.MkVectorD4(
                (double)(Arith.Div(A.x, B.x)),
                (double)(Arith.Div(A.y, B.y)),
                (double)(Arith.Div(A.z, B.z)),
                (double)(Arith.Div(A.w, B.w)));
        }

        public static Vector2 ElDiv(Vector2 A, Vector2 B)
        {
            return VecOps.MkVector2(
                (float)(Arith.Div(A.x, B.x)),
                (float)(Arith.Div(A.y, B.y)));
        }

        public static Vector3 ElDiv(Vector3 A, Vector3 B)
        {
            return VecOps.MkVector3(
                (float)(Arith.Div(A.x, B.x)),
                (float)(Arith.Div(A.y, B.y)),
                (float)(Arith.Div(A.z, B.z)));
        }

        public static Vector4 ElDiv(Vector4 A, Vector4 B)
        {
            return VecOps.MkVector4(
                (float)(Arith.Div(A.x, B.x)),
                (float)(Arith.Div(A.y, B.y)),
                (float)(Arith.Div(A.z, B.z)),
                (float)(Arith.Div(A.w, B.w)));
        }

        // Elementwise division that uses ceiling instead of floor
        public static VectorI2 ElCeilDiv(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.CeilDiv(A.x, B.x)),
                (Int32)(Arith.CeilDiv(A.y, B.y)));
        }

        public static VectorI3 ElCeilDiv(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.CeilDiv(A.x, B.x)),
                (Int32)(Arith.CeilDiv(A.y, B.y)),
                (Int32)(Arith.CeilDiv(A.z, B.z)));
        }

        public static VectorI4 ElCeilDiv(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.CeilDiv(A.x, B.x)),
                (Int32)(Arith.CeilDiv(A.y, B.y)),
                (Int32)(Arith.CeilDiv(A.z, B.z)),
                (Int32)(Arith.CeilDiv(A.w, B.w)));
        }

        public static VectorB2 ElCeilDiv(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.CeilDiv(A.x, B.x)),
                (byte)(Arith.CeilDiv(A.y, B.y)));
        }

        public static VectorB3 ElCeilDiv(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.CeilDiv(A.x, B.x)),
                (byte)(Arith.CeilDiv(A.y, B.y)),
                (byte)(Arith.CeilDiv(A.z, B.z)));
        }

        public static VectorB4 ElCeilDiv(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.CeilDiv(A.x, B.x)),
                (byte)(Arith.CeilDiv(A.y, B.y)),
                (byte)(Arith.CeilDiv(A.z, B.z)),
                (byte)(Arith.CeilDiv(A.w, B.w)));
        }

        // Elementwise min/max
        public static VectorI2 ElMin(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Min(A.x, B.x)),
                (Int32)(Arith.Min(A.y, B.y)));
        }

        public static VectorI3 ElMin(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Min(A.x, B.x)),
                (Int32)(Arith.Min(A.y, B.y)),
                (Int32)(Arith.Min(A.z, B.z)));
        }

        public static VectorI4 ElMin(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Min(A.x, B.x)),
                (Int32)(Arith.Min(A.y, B.y)),
                (Int32)(Arith.Min(A.z, B.z)),
                (Int32)(Arith.Min(A.w, B.w)));
        }

        public static VectorB2 ElMin(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Min(A.x, B.x)),
                (byte)(Arith.Min(A.y, B.y)));
        }

        public static VectorB3 ElMin(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Min(A.x, B.x)),
                (byte)(Arith.Min(A.y, B.y)),
                (byte)(Arith.Min(A.z, B.z)));
        }

        public static VectorB4 ElMin(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Min(A.x, B.x)),
                (byte)(Arith.Min(A.y, B.y)),
                (byte)(Arith.Min(A.z, B.z)),
                (byte)(Arith.Min(A.w, B.w)));
        }

        public static VectorD2 ElMin(VectorD2 A, VectorD2 B)
        {
            return VecOps.MkVectorD2(
                (double)(Arith.Min(A.x, B.x)),
                (double)(Arith.Min(A.y, B.y)));
        }

        public static VectorD3 ElMin(VectorD3 A, VectorD3 B)
        {
            return VecOps.MkVectorD3(
                (double)(Arith.Min(A.x, B.x)),
                (double)(Arith.Min(A.y, B.y)),
                (double)(Arith.Min(A.z, B.z)));
        }

        public static VectorD4 ElMin(VectorD4 A, VectorD4 B)
        {
            return VecOps.MkVectorD4(
                (double)(Arith.Min(A.x, B.x)),
                (double)(Arith.Min(A.y, B.y)),
                (double)(Arith.Min(A.z, B.z)),
                (double)(Arith.Min(A.w, B.w)));
        }

        public static Vector2 ElMin(Vector2 A, Vector2 B)
        {
            return VecOps.MkVector2(
                (float)(Arith.Min(A.x, B.x)),
                (float)(Arith.Min(A.y, B.y)));
        }

        public static Vector3 ElMin(Vector3 A, Vector3 B)
        {
            return VecOps.MkVector3(
                (float)(Arith.Min(A.x, B.x)),
                (float)(Arith.Min(A.y, B.y)),
                (float)(Arith.Min(A.z, B.z)));
        }

        public static Vector4 ElMin(Vector4 A, Vector4 B)
        {
            return VecOps.MkVector4(
                (float)(Arith.Min(A.x, B.x)),
                (float)(Arith.Min(A.y, B.y)),
                (float)(Arith.Min(A.z, B.z)),
                (float)(Arith.Min(A.w, B.w)));
        }

        public static VectorI2 ElMax(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Max(A.x, B.x)),
                (Int32)(Arith.Max(A.y, B.y)));
        }

        public static VectorI3 ElMax(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Max(A.x, B.x)),
                (Int32)(Arith.Max(A.y, B.y)),
                (Int32)(Arith.Max(A.z, B.z)));
        }

        public static VectorI4 ElMax(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Max(A.x, B.x)),
                (Int32)(Arith.Max(A.y, B.y)),
                (Int32)(Arith.Max(A.z, B.z)),
                (Int32)(Arith.Max(A.w, B.w)));
        }

        public static VectorB2 ElMax(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Max(A.x, B.x)),
                (byte)(Arith.Max(A.y, B.y)));
        }

        public static VectorB3 ElMax(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Max(A.x, B.x)),
                (byte)(Arith.Max(A.y, B.y)),
                (byte)(Arith.Max(A.z, B.z)));
        }

        public static VectorB4 ElMax(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Max(A.x, B.x)),
                (byte)(Arith.Max(A.y, B.y)),
                (byte)(Arith.Max(A.z, B.z)),
                (byte)(Arith.Max(A.w, B.w)));
        }

        public static VectorD2 ElMax(VectorD2 A, VectorD2 B)
        {
            return VecOps.MkVectorD2(
                (double)(Arith.Max(A.x, B.x)),
                (double)(Arith.Max(A.y, B.y)));
        }

        public static VectorD3 ElMax(VectorD3 A, VectorD3 B)
        {
            return VecOps.MkVectorD3(
                (double)(Arith.Max(A.x, B.x)),
                (double)(Arith.Max(A.y, B.y)),
                (double)(Arith.Max(A.z, B.z)));
        }

        public static VectorD4 ElMax(VectorD4 A, VectorD4 B)
        {
            return VecOps.MkVectorD4(
                (double)(Arith.Max(A.x, B.x)),
                (double)(Arith.Max(A.y, B.y)),
                (double)(Arith.Max(A.z, B.z)),
                (double)(Arith.Max(A.w, B.w)));
        }

        public static Vector2 ElMax(Vector2 A, Vector2 B)
        {
            return VecOps.MkVector2(
                (float)(Arith.Max(A.x, B.x)),
                (float)(Arith.Max(A.y, B.y)));
        }

        public static Vector3 ElMax(Vector3 A, Vector3 B)
        {
            return VecOps.MkVector3(
                (float)(Arith.Max(A.x, B.x)),
                (float)(Arith.Max(A.y, B.y)),
                (float)(Arith.Max(A.z, B.z)));
        }

        public static Vector4 ElMax(Vector4 A, Vector4 B)
        {
            return VecOps.MkVector4(
                (float)(Arith.Max(A.x, B.x)),
                (float)(Arith.Max(A.y, B.y)),
                (float)(Arith.Max(A.z, B.z)),
                (float)(Arith.Max(A.w, B.w)));
        }

        // Elementwise remainder. Uses floor.
        public static VectorI2 ElRem(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Rem(A.x, B.x)),
                (Int32)(Arith.Rem(A.y, B.y)));
        }

        public static VectorI3 ElRem(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Rem(A.x, B.x)),
                (Int32)(Arith.Rem(A.y, B.y)),
                (Int32)(Arith.Rem(A.z, B.z)));
        }

        public static VectorI4 ElRem(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Rem(A.x, B.x)),
                (Int32)(Arith.Rem(A.y, B.y)),
                (Int32)(Arith.Rem(A.z, B.z)),
                (Int32)(Arith.Rem(A.w, B.w)));
        }

        public static VectorB2 ElRem(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Rem(A.x, B.x)),
                (byte)(Arith.Rem(A.y, B.y)));
        }

        public static VectorB3 ElRem(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Rem(A.x, B.x)),
                (byte)(Arith.Rem(A.y, B.y)),
                (byte)(Arith.Rem(A.z, B.z)));
        }

        public static VectorB4 ElRem(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Rem(A.x, B.x)),
                (byte)(Arith.Rem(A.y, B.y)),
                (byte)(Arith.Rem(A.z, B.z)),
                (byte)(Arith.Rem(A.w, B.w)));
        }

        // Elementwise multiplication/division/remainder by 2^B_i
        public static VectorI2 ElPow2CeilDiv(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Int32)(Arith.Pow2CeilDiv(A.y, B.y)));
        }

        public static VectorI3 ElPow2CeilDiv(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Int32)(Arith.Pow2CeilDiv(A.y, B.y)),
                (Int32)(Arith.Pow2CeilDiv(A.z, B.z)));
        }

        public static VectorI4 ElPow2CeilDiv(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Int32)(Arith.Pow2CeilDiv(A.y, B.y)),
                (Int32)(Arith.Pow2CeilDiv(A.z, B.z)),
                (Int32)(Arith.Pow2CeilDiv(A.w, B.w)));
        }

        public static VectorB2 ElPow2CeilDiv(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                (byte)(Arith.Pow2CeilDiv(A.y, B.y)));
        }

        public static VectorB3 ElPow2CeilDiv(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                (byte)(Arith.Pow2CeilDiv(A.y, B.y)),
                (byte)(Arith.Pow2CeilDiv(A.z, B.z)));
        }

        public static VectorB4 ElPow2CeilDiv(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                (byte)(Arith.Pow2CeilDiv(A.y, B.y)),
                (byte)(Arith.Pow2CeilDiv(A.z, B.z)),
                (byte)(Arith.Pow2CeilDiv(A.w, B.w)));
        }

        public static VectorI2 ElPow2Div(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Pow2Div(A.x, B.x)),
                (Int32)(Arith.Pow2Div(A.y, B.y)));
        }

        public static VectorI3 ElPow2Div(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Pow2Div(A.x, B.x)),
                (Int32)(Arith.Pow2Div(A.y, B.y)),
                (Int32)(Arith.Pow2Div(A.z, B.z)));
        }

        public static VectorI4 ElPow2Div(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Pow2Div(A.x, B.x)),
                (Int32)(Arith.Pow2Div(A.y, B.y)),
                (Int32)(Arith.Pow2Div(A.z, B.z)),
                (Int32)(Arith.Pow2Div(A.w, B.w)));
        }

        public static VectorB2 ElPow2Div(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Pow2Div(A.x, B.x)),
                (byte)(Arith.Pow2Div(A.y, B.y)));
        }

        public static VectorB3 ElPow2Div(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Pow2Div(A.x, B.x)),
                (byte)(Arith.Pow2Div(A.y, B.y)),
                (byte)(Arith.Pow2Div(A.z, B.z)));
        }

        public static VectorB4 ElPow2Div(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Pow2Div(A.x, B.x)),
                (byte)(Arith.Pow2Div(A.y, B.y)),
                (byte)(Arith.Pow2Div(A.z, B.z)),
                (byte)(Arith.Pow2Div(A.w, B.w)));
        }

        public static VectorI2 ElPow2Mult(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Pow2Mult(A.x, B.x)),
                (Int32)(Arith.Pow2Mult(A.y, B.y)));
        }

        public static VectorI3 ElPow2Mult(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Pow2Mult(A.x, B.x)),
                (Int32)(Arith.Pow2Mult(A.y, B.y)),
                (Int32)(Arith.Pow2Mult(A.z, B.z)));
        }

        public static VectorI4 ElPow2Mult(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Pow2Mult(A.x, B.x)),
                (Int32)(Arith.Pow2Mult(A.y, B.y)),
                (Int32)(Arith.Pow2Mult(A.z, B.z)),
                (Int32)(Arith.Pow2Mult(A.w, B.w)));
        }

        public static VectorB2 ElPow2Mult(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Pow2Mult(A.x, B.x)),
                (byte)(Arith.Pow2Mult(A.y, B.y)));
        }

        public static VectorB3 ElPow2Mult(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Pow2Mult(A.x, B.x)),
                (byte)(Arith.Pow2Mult(A.y, B.y)),
                (byte)(Arith.Pow2Mult(A.z, B.z)));
        }

        public static VectorB4 ElPow2Mult(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Pow2Mult(A.x, B.x)),
                (byte)(Arith.Pow2Mult(A.y, B.y)),
                (byte)(Arith.Pow2Mult(A.z, B.z)),
                (byte)(Arith.Pow2Mult(A.w, B.w)));
        }

        public static VectorI2 ElPow2Rem(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Pow2Rem(A.x, B.x)),
                (Int32)(Arith.Pow2Rem(A.y, B.y)));
        }

        public static VectorI3 ElPow2Rem(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Pow2Rem(A.x, B.x)),
                (Int32)(Arith.Pow2Rem(A.y, B.y)),
                (Int32)(Arith.Pow2Rem(A.z, B.z)));
        }

        public static VectorI4 ElPow2Rem(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Pow2Rem(A.x, B.x)),
                (Int32)(Arith.Pow2Rem(A.y, B.y)),
                (Int32)(Arith.Pow2Rem(A.z, B.z)),
                (Int32)(Arith.Pow2Rem(A.w, B.w)));
        }

        public static VectorB2 ElPow2Rem(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Pow2Rem(A.x, B.x)),
                (byte)(Arith.Pow2Rem(A.y, B.y)));
        }

        public static VectorB3 ElPow2Rem(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Pow2Rem(A.x, B.x)),
                (byte)(Arith.Pow2Rem(A.y, B.y)),
                (byte)(Arith.Pow2Rem(A.z, B.z)));
        }

        public static VectorB4 ElPow2Rem(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Pow2Rem(A.x, B.x)),
                (byte)(Arith.Pow2Rem(A.y, B.y)),
                (byte)(Arith.Pow2Rem(A.z, B.z)),
                (byte)(Arith.Pow2Rem(A.w, B.w)));
        }

        // Dot product
        public static Int32 DotP(VectorI2 A, VectorI2 B)
        {
            return (Int32)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.y * B.y));
        }

        public static Int32 DotP(VectorI3 A, VectorI3 B)
        {
            return (Int32)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.z * B.z));
        }

        public static Int32 DotP(VectorI4 A, VectorI4 B)
        {
            return (Int32)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.w * B.w));
        }

        public static byte DotP(VectorB2 A, VectorB2 B)
        {
            return (byte)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.y * B.y));
        }

        public static Int32 DotPI(VectorB2 A, VectorB2 B)
        {
            return (Int32)((Int32)(A.x * B.x)
                + (Int32)(A.y * B.y)
                + (Int32)(A.x * B.x)
                + (Int32)(A.y * B.y));
        }

        public static byte DotP(VectorB3 A, VectorB3 B)
        {
            return (byte)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.z * B.z));
        }

        public static Int32 DotPI(VectorB3 A, VectorB3 B)
        {
            return (Int32)((Int32)(A.x * B.x)
                + (Int32)(A.y * B.y)
                + (Int32)(A.x * B.x)
                + (Int32)(A.z * B.z));
        }

        public static byte DotP(VectorB4 A, VectorB4 B)
        {
            return (byte)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.w * B.w));
        }

        public static Int32 DotPI(VectorB4 A, VectorB4 B)
        {
            return (Int32)((Int32)(A.x * B.x)
                + (Int32)(A.y * B.y)
                + (Int32)(A.x * B.x)
                + (Int32)(A.w * B.w));
        }

        public static double DotP(VectorD2 A, VectorD2 B)
        {
            return (double)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.y * B.y));
        }

        public static double DotP(VectorD3 A, VectorD3 B)
        {
            return (double)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.z * B.z));
        }

        public static double DotP(VectorD4 A, VectorD4 B)
        {
            return (double)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.w * B.w));
        }

        public static float DotP(Vector2 A, Vector2 B)
        {
            return (float)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.y * B.y));
        }

        public static double DotPD(Vector2 A, Vector2 B)
        {
            return (double)((double)(A.x * B.x)
                + (double)(A.y * B.y)
                + (double)(A.x * B.x)
                + (double)(A.y * B.y));
        }

        public static float DotP(Vector3 A, Vector3 B)
        {
            return (float)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.z * B.z));
        }

        public static double DotPD(Vector3 A, Vector3 B)
        {
            return (double)((double)(A.x * B.x)
                + (double)(A.y * B.y)
                + (double)(A.x * B.x)
                + (double)(A.z * B.z));
        }

        public static float DotP(Vector4 A, Vector4 B)
        {
            return (float)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.w * B.w));
        }

        public static double DotPD(Vector4 A, Vector4 B)
        {
            return (double)((double)(A.x * B.x)
                + (double)(A.y * B.y)
                + (double)(A.x * B.x)
                + (double)(A.w * B.w));
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

        public static byte SqLen(VectorB2 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLenI(VectorB2 V)
        {
            return DotPI(V,V);
        }

        public static byte SqLen(VectorB3 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLenI(VectorB3 V)
        {
            return DotPI(V,V);
        }

        public static byte SqLen(VectorB4 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLenI(VectorB4 V)
        {
            return DotPI(V,V);
        }

        public static double SqLen(VectorD2 V)
        {
            return DotP(V,V);
        }

        public static double SqLen(VectorD3 V)
        {
            return DotP(V,V);
        }

        public static double SqLen(VectorD4 V)
        {
            return DotP(V,V);
        }

        public static float SqLen(Vector2 V)
        {
            return DotP(V,V);
        }

        public static double SqLenD(Vector2 V)
        {
            return DotPD(V,V);
        }

        public static float SqLen(Vector3 V)
        {
            return DotP(V,V);
        }

        public static double SqLenD(Vector3 V)
        {
            return DotPD(V,V);
        }

        public static float SqLen(Vector4 V)
        {
            return DotP(V,V);
        }

        public static double SqLenD(Vector4 V)
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

        public static byte ManhatLength(VectorB2 V)
        {
            return (byte)(V.x + V.y);
        }

        public static byte ManhatLength(VectorB3 V)
        {
            return (byte)(V.x + V.y + V.z);
        }

        public static byte ManhatLength(VectorB4 V)
        {
            return (byte)(V.x + V.y + V.z + V.w);
        }

        public static double ManhatLength(VectorD2 V)
        {
            return (double)(V.x + V.y);
        }

        public static double ManhatLength(VectorD3 V)
        {
            return (double)(V.x + V.y + V.z);
        }

        public static double ManhatLength(VectorD4 V)
        {
            return (double)(V.x + V.y + V.z + V.w);
        }

        public static float ManhatLength(Vector2 V)
        {
            return (float)(V.x + V.y);
        }

        public static float ManhatLength(Vector3 V)
        {
            return (float)(V.x + V.y + V.z);
        }

        public static float ManhatLength(Vector4 V)
        {
            return (float)(V.x + V.y + V.z + V.w);
        }

        // Vector length (as in, euclidean)
        public static double Len(VectorD2 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static double Len(VectorD3 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static double Len(VectorD4 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static float Len(Vector2 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static float Len(Vector3 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static float Len(Vector4 V)
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

        public static byte Volume(VectorB2 V)
        {
            return (byte)(V.x * V.y);
        }

        public static Int32 VolumeI(VectorB2 V)
        {
            return (Int32)(V.x * V.y);
        }

        public static byte Volume(VectorB3 V)
        {
            return (byte)(V.x * V.y * V.z);
        }

        public static Int32 VolumeI(VectorB3 V)
        {
            return (Int32)(V.x * V.y * V.z);
        }

        public static byte Volume(VectorB4 V)
        {
            return (byte)(V.x * V.y * V.z * V.w);
        }

        public static Int32 VolumeI(VectorB4 V)
        {
            return (Int32)(V.x * V.y * V.z * V.w);
        }

        public static double Volume(VectorD2 V)
        {
            return (double)(V.x * V.y);
        }

        public static double Volume(VectorD3 V)
        {
            return (double)(V.x * V.y * V.z);
        }

        public static double Volume(VectorD4 V)
        {
            return (double)(V.x * V.y * V.z * V.w);
        }

        public static float Volume(Vector2 V)
        {
            return (float)(V.x * V.y);
        }

        public static double VolumeD(Vector2 V)
        {
            return (double)(V.x * V.y);
        }

        public static float Volume(Vector3 V)
        {
            return (float)(V.x * V.y * V.z);
        }

        public static double VolumeD(Vector3 V)
        {
            return (double)(V.x * V.y * V.z);
        }

        public static float Volume(Vector4 V)
        {
            return (float)(V.x * V.y * V.z * V.w);
        }

        public static double VolumeD(Vector4 V)
        {
            return (double)(V.x * V.y * V.z * V.w);
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

        public static byte Pow2Volume(VectorB2 V)
        {
            return Arith.Pow2Mult((byte)1, (byte)(V.x + V.y));
        }

        public static Int32 Pow2VolumeI(VectorB2 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y));
        }

        public static byte Pow2Volume(VectorB3 V)
        {
            return Arith.Pow2Mult((byte)1, (byte)(V.x + V.y + V.z));
        }

        public static Int32 Pow2VolumeI(VectorB3 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z));
        }

        public static byte Pow2Volume(VectorB4 V)
        {
            return Arith.Pow2Mult((byte)1, (byte)(V.x + V.y + V.z + V.w));
        }

        public static Int32 Pow2VolumeI(VectorB4 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z + V.w));
        }

        // Cross product
        public static VectorI3 CrossP(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (A.y * B.z) - (A.z * B.y),
                -(A.x * B.z) + (A.z * B.x),
                (A.x * B.y) - (A.y * B.x));
        }

        public static VectorD3 CrossP(VectorD3 A, VectorD3 B)
        {
            return VecOps.MkVectorD3(
                (A.y * B.z) - (A.z * B.y),
                -(A.x * B.z) + (A.z * B.x),
                (A.x * B.y) - (A.y * B.x));
        }

        public static Vector3 CrossP(Vector3 A, Vector3 B)
        {
            return VecOps.MkVector3(
                (A.y * B.z) - (A.z * B.y),
                -(A.x * B.z) + (A.z * B.x),
                (A.x * B.y) - (A.y * B.x));
        }

        // Some C#-specific functions
        public static VectorI2 Select(VectorI2 V, Func<Int32, Int32> func)
        {
            return VecOps.MkVectorI2(
                (Int32)(func(V.x)),
                (Int32)(func(V.y)));
        }

        public static VectorI3 Select(VectorI3 V, Func<Int32, Int32> func)
        {
            return VecOps.MkVectorI3(
                (Int32)(func(V.x)),
                (Int32)(func(V.y)),
                (Int32)(func(V.z)));
        }

        public static VectorI4 Select(VectorI4 V, Func<Int32, Int32> func)
        {
            return VecOps.MkVectorI4(
                (Int32)(func(V.x)),
                (Int32)(func(V.y)),
                (Int32)(func(V.z)),
                (Int32)(func(V.w)));
        }

        public static VectorB2 Select(VectorB2 V, Func<byte, byte> func)
        {
            return VecOps.MkVectorB2(
                (byte)(func(V.x)),
                (byte)(func(V.y)));
        }

        public static VectorB3 Select(VectorB3 V, Func<byte, byte> func)
        {
            return VecOps.MkVectorB3(
                (byte)(func(V.x)),
                (byte)(func(V.y)),
                (byte)(func(V.z)));
        }

        public static VectorB4 Select(VectorB4 V, Func<byte, byte> func)
        {
            return VecOps.MkVectorB4(
                (byte)(func(V.x)),
                (byte)(func(V.y)),
                (byte)(func(V.z)),
                (byte)(func(V.w)));
        }

        public static VectorD2 Select(VectorD2 V, Func<double, double> func)
        {
            return VecOps.MkVectorD2(
                (double)(func(V.x)),
                (double)(func(V.y)));
        }

        public static VectorD3 Select(VectorD3 V, Func<double, double> func)
        {
            return VecOps.MkVectorD3(
                (double)(func(V.x)),
                (double)(func(V.y)),
                (double)(func(V.z)));
        }

        public static VectorD4 Select(VectorD4 V, Func<double, double> func)
        {
            return VecOps.MkVectorD4(
                (double)(func(V.x)),
                (double)(func(V.y)),
                (double)(func(V.z)),
                (double)(func(V.w)));
        }

        public static Vector2 Select(Vector2 V, Func<float, float> func)
        {
            return VecOps.MkVector2(
                (float)(func(V.x)),
                (float)(func(V.y)));
        }

        public static Vector3 Select(Vector3 V, Func<float, float> func)
        {
            return VecOps.MkVector3(
                (float)(func(V.x)),
                (float)(func(V.y)),
                (float)(func(V.z)));
        }

        public static Vector4 Select(Vector4 V, Func<float, float> func)
        {
            return VecOps.MkVector4(
                (float)(func(V.x)),
                (float)(func(V.y)),
                (float)(func(V.z)),
                (float)(func(V.w)));
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

        public static byte[] Members(VectorB2 V)
        {
            return new[] { V.x, V.y };
        }

        public static byte[] Members(VectorB3 V)
        {
            return new[] { V.x, V.y, V.z };
        }

        public static byte[] Members(VectorB4 V)
        {
            return new[] { V.x, V.y, V.z, V.w };
        }

        public static double[] Members(VectorD2 V)
        {
            return new[] { V.x, V.y };
        }

        public static double[] Members(VectorD3 V)
        {
            return new[] { V.x, V.y, V.z };
        }

        public static double[] Members(VectorD4 V)
        {
            return new[] { V.x, V.y, V.z, V.w };
        }

        public static float[] Members(Vector2 V)
        {
            return new[] { V.x, V.y };
        }

        public static float[] Members(Vector3 V)
        {
            return new[] { V.x, V.y, V.z };
        }

        public static float[] Members(Vector4 V)
        {
            return new[] { V.x, V.y, V.z, V.w };
        }

        public static VectorI2 ToVectorI2(System.Collections.Generic.IEnumerable<Int32> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return VecOps.MkVectorI2(array[0], array[1]);
        }

        public static VectorI3 ToVectorI3(System.Collections.Generic.IEnumerable<Int32> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return VecOps.MkVectorI3(array[0], array[1], array[2]);
        }

        public static VectorI4 ToVectorI4(System.Collections.Generic.IEnumerable<Int32> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return VecOps.MkVectorI4(array[0], array[1], array[2], array[3]);
        }

        public static VectorB2 ToVectorB2(System.Collections.Generic.IEnumerable<byte> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return VecOps.MkVectorB2(array[0], array[1]);
        }

        public static VectorB3 ToVectorB3(System.Collections.Generic.IEnumerable<byte> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return VecOps.MkVectorB3(array[0], array[1], array[2]);
        }

        public static VectorB4 ToVectorB4(System.Collections.Generic.IEnumerable<byte> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return VecOps.MkVectorB4(array[0], array[1], array[2], array[3]);
        }

        public static VectorD2 ToVectorD2(System.Collections.Generic.IEnumerable<double> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return VecOps.MkVectorD2(array[0], array[1]);
        }

        public static VectorD3 ToVectorD3(System.Collections.Generic.IEnumerable<double> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return VecOps.MkVectorD3(array[0], array[1], array[2]);
        }

        public static VectorD4 ToVectorD4(System.Collections.Generic.IEnumerable<double> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return VecOps.MkVectorD4(array[0], array[1], array[2], array[3]);
        }

        public static Vector2 ToVector2(System.Collections.Generic.IEnumerable<float> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return VecOps.MkVector2(array[0], array[1]);
        }

        public static Vector3 ToVector3(System.Collections.Generic.IEnumerable<float> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return VecOps.MkVector3(array[0], array[1], array[2]);
        }

        public static Vector4 ToVector4(System.Collections.Generic.IEnumerable<float> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return VecOps.MkVector4(array[0], array[1], array[2], array[3]);
        }

    }
}