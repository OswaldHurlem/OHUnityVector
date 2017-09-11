// Generated with oh_unity_vector_generator.py
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;

namespace OH
{
    public static partial class VecExt
    {
        // Constructors from other vectors. Float converts to int using floor
        public static VectorI2 MkVectorI2B(this VectorB2 V)
        {
            return VecOps.MkVectorI2B(V.x, V.y);
        }

        public static VectorI2 MkVectorI2F(this Vector2 V)
        {
            return VecOps.MkVectorI2F(V.x, V.y);
        }

        public static VectorI3 MkVectorI3B(this VectorB3 V)
        {
            return VecOps.MkVectorI3B(V.x, V.y, V.z);
        }

        public static VectorI3 MkVectorI3F(this Vector3 V)
        {
            return VecOps.MkVectorI3F(V.x, V.y, V.z);
        }

        public static VectorI4 MkVectorI4B(this VectorB4 V)
        {
            return VecOps.MkVectorI4B(V.x, V.y, V.z, V.w);
        }

        public static VectorI4 MkVectorI4F(this Vector4 V)
        {
            return VecOps.MkVectorI4F(V.x, V.y, V.z, V.w);
        }

        public static VectorB2 MkVectorB2I(this VectorI2 V)
        {
            return VecOps.MkVectorB2I(V.x, V.y);
        }

        public static VectorB2 MkVectorB2F(this Vector2 V)
        {
            return VecOps.MkVectorB2F(V.x, V.y);
        }

        public static VectorB3 MkVectorB3I(this VectorI3 V)
        {
            return VecOps.MkVectorB3I(V.x, V.y, V.z);
        }

        public static VectorB3 MkVectorB3F(this Vector3 V)
        {
            return VecOps.MkVectorB3F(V.x, V.y, V.z);
        }

        public static VectorB4 MkVectorB4I(this VectorI4 V)
        {
            return VecOps.MkVectorB4I(V.x, V.y, V.z, V.w);
        }

        public static VectorB4 MkVectorB4F(this Vector4 V)
        {
            return VecOps.MkVectorB4F(V.x, V.y, V.z, V.w);
        }

        public static Vector2 MkVector2I(this VectorI2 V)
        {
            return VecOps.MkVector2I(V.x, V.y);
        }

        public static Vector2 MkVector2B(this VectorB2 V)
        {
            return VecOps.MkVector2B(V.x, V.y);
        }

        public static Vector3 MkVector3I(this VectorI3 V)
        {
            return VecOps.MkVector3I(V.x, V.y, V.z);
        }

        public static Vector3 MkVector3B(this VectorB3 V)
        {
            return VecOps.MkVector3B(V.x, V.y, V.z);
        }

        public static Vector4 MkVector4I(this VectorI4 V)
        {
            return VecOps.MkVector4I(V.x, V.y, V.z, V.w);
        }

        public static Vector4 MkVector4B(this VectorB4 V)
        {
            return VecOps.MkVector4B(V.x, V.y, V.z, V.w);
        }

        // Constructors from ceiling rather than floor
        public static VectorI2 CeilVectorI2F(this Vector2 V)
        {
            return VecOps.MkVectorI2F(Arith.CeilIF(V.x), Arith.CeilIF(V.y));
        }

        public static VectorI3 CeilVectorI3F(this Vector3 V)
        {
            return VecOps.MkVectorI3F(Arith.CeilIF(V.x), Arith.CeilIF(V.y), Arith.CeilIF(V.z));
        }

        public static VectorI4 CeilVectorI4F(this Vector4 V)
        {
            return VecOps.MkVectorI4F(Arith.CeilIF(V.x), Arith.CeilIF(V.y), Arith.CeilIF(V.z), Arith.CeilIF(V.w));
        }

        public static VectorB2 CeilVectorB2F(this Vector2 V)
        {
            return VecOps.MkVectorB2F(Arith.CeilBF(V.x), Arith.CeilBF(V.y));
        }

        public static VectorB3 CeilVectorB3F(this Vector3 V)
        {
            return VecOps.MkVectorB3F(Arith.CeilBF(V.x), Arith.CeilBF(V.y), Arith.CeilBF(V.z));
        }

        public static VectorB4 CeilVectorB4F(this Vector4 V)
        {
            return VecOps.MkVectorB4F(Arith.CeilBF(V.x), Arith.CeilBF(V.y), Arith.CeilBF(V.z), Arith.CeilBF(V.w));
        }

        // Evaluate whether all terms are greater than, less than, greater than or equal, less than or equal
        public static Boolean StrictGt(this VectorI2 A, VectorI2 B)
        {
            return (A.x > B.x)
                && (A.y > B.y);
        }

        public static Boolean StrictGt(this VectorI3 A, VectorI3 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z);
        }

        public static Boolean StrictGt(this VectorI4 A, VectorI4 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z)
                && (A.w > B.w);
        }

        public static Boolean StrictGt(this VectorB2 A, VectorB2 B)
        {
            return (A.x > B.x)
                && (A.y > B.y);
        }

        public static Boolean StrictGt(this VectorB3 A, VectorB3 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z);
        }

        public static Boolean StrictGt(this VectorB4 A, VectorB4 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z)
                && (A.w > B.w);
        }

        public static Boolean StrictGt(this Vector2 A, Vector2 B)
        {
            return (A.x > B.x)
                && (A.y > B.y);
        }

        public static Boolean StrictGt(this Vector3 A, Vector3 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z);
        }

        public static Boolean StrictGt(this Vector4 A, Vector4 B)
        {
            return (A.x > B.x)
                && (A.y > B.y)
                && (A.z > B.z)
                && (A.w > B.w);
        }

        public static Boolean StrictLt(this VectorI2 A, VectorI2 B)
        {
            return (A.x < B.x)
                && (A.y < B.y);
        }

        public static Boolean StrictLt(this VectorI3 A, VectorI3 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z);
        }

        public static Boolean StrictLt(this VectorI4 A, VectorI4 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z)
                && (A.w < B.w);
        }

        public static Boolean StrictLt(this VectorB2 A, VectorB2 B)
        {
            return (A.x < B.x)
                && (A.y < B.y);
        }

        public static Boolean StrictLt(this VectorB3 A, VectorB3 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z);
        }

        public static Boolean StrictLt(this VectorB4 A, VectorB4 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z)
                && (A.w < B.w);
        }

        public static Boolean StrictLt(this Vector2 A, Vector2 B)
        {
            return (A.x < B.x)
                && (A.y < B.y);
        }

        public static Boolean StrictLt(this Vector3 A, Vector3 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z);
        }

        public static Boolean StrictLt(this Vector4 A, Vector4 B)
        {
            return (A.x < B.x)
                && (A.y < B.y)
                && (A.z < B.z)
                && (A.w < B.w);
        }

        public static Boolean StrictGte(this VectorI2 A, VectorI2 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y);
        }

        public static Boolean StrictGte(this VectorI3 A, VectorI3 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z);
        }

        public static Boolean StrictGte(this VectorI4 A, VectorI4 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z)
                && (A.w >= B.w);
        }

        public static Boolean StrictGte(this VectorB2 A, VectorB2 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y);
        }

        public static Boolean StrictGte(this VectorB3 A, VectorB3 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z);
        }

        public static Boolean StrictGte(this VectorB4 A, VectorB4 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z)
                && (A.w >= B.w);
        }

        public static Boolean StrictGte(this Vector2 A, Vector2 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y);
        }

        public static Boolean StrictGte(this Vector3 A, Vector3 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z);
        }

        public static Boolean StrictGte(this Vector4 A, Vector4 B)
        {
            return (A.x >= B.x)
                && (A.y >= B.y)
                && (A.z >= B.z)
                && (A.w >= B.w);
        }

        public static Boolean StrictLte(this VectorI2 A, VectorI2 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y);
        }

        public static Boolean StrictLte(this VectorI3 A, VectorI3 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z);
        }

        public static Boolean StrictLte(this VectorI4 A, VectorI4 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z)
                && (A.w <= B.w);
        }

        public static Boolean StrictLte(this VectorB2 A, VectorB2 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y);
        }

        public static Boolean StrictLte(this VectorB3 A, VectorB3 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z);
        }

        public static Boolean StrictLte(this VectorB4 A, VectorB4 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z)
                && (A.w <= B.w);
        }

        public static Boolean StrictLte(this Vector2 A, Vector2 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y);
        }

        public static Boolean StrictLte(this Vector3 A, Vector3 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z);
        }

        public static Boolean StrictLte(this Vector4 A, Vector4 B)
        {
            return (A.x <= B.x)
                && (A.y <= B.y)
                && (A.z <= B.z)
                && (A.w <= B.w);
        }

        // Elementwise multiplication (equivalent to Scale() in Unity)
        public static VectorI2 ElMult(this VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(A.x * B.x),
                (Int32)(A.y * B.y));
        }

        public static VectorI3 ElMult(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(A.x * B.x),
                (Int32)(A.y * B.y),
                (Int32)(A.z * B.z));
        }

        public static VectorI4 ElMult(this VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(A.x * B.x),
                (Int32)(A.y * B.y),
                (Int32)(A.z * B.z),
                (Int32)(A.w * B.w));
        }

        public static VectorB2 ElMult(this VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(A.x * B.x),
                (byte)(A.y * B.y));
        }

        public static VectorB3 ElMult(this VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(A.x * B.x),
                (byte)(A.y * B.y),
                (byte)(A.z * B.z));
        }

        public static VectorB4 ElMult(this VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(A.x * B.x),
                (byte)(A.y * B.y),
                (byte)(A.z * B.z),
                (byte)(A.w * B.w));
        }

        public static Vector2 ElMult(this Vector2 A, Vector2 B)
        {
            return VecOps.MkVector2(
                (float)(A.x * B.x),
                (float)(A.y * B.y));
        }

        public static Vector3 ElMult(this Vector3 A, Vector3 B)
        {
            return VecOps.MkVector3(
                (float)(A.x * B.x),
                (float)(A.y * B.y),
                (float)(A.z * B.z));
        }

        public static Vector4 ElMult(this Vector4 A, Vector4 B)
        {
            return VecOps.MkVector4(
                (float)(A.x * B.x),
                (float)(A.y * B.y),
                (float)(A.z * B.z),
                (float)(A.w * B.w));
        }

        // Elementwise division. Uses floor.
        public static VectorI2 ElDiv(this VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Div(A.x, B.x)),
                (Int32)(Arith.Div(A.y, B.y)));
        }

        public static VectorI3 ElDiv(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Div(A.x, B.x)),
                (Int32)(Arith.Div(A.y, B.y)),
                (Int32)(Arith.Div(A.z, B.z)));
        }

        public static VectorI4 ElDiv(this VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Div(A.x, B.x)),
                (Int32)(Arith.Div(A.y, B.y)),
                (Int32)(Arith.Div(A.z, B.z)),
                (Int32)(Arith.Div(A.w, B.w)));
        }

        public static VectorB2 ElDiv(this VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Div(A.x, B.x)),
                (byte)(Arith.Div(A.y, B.y)));
        }

        public static VectorB3 ElDiv(this VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Div(A.x, B.x)),
                (byte)(Arith.Div(A.y, B.y)),
                (byte)(Arith.Div(A.z, B.z)));
        }

        public static VectorB4 ElDiv(this VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Div(A.x, B.x)),
                (byte)(Arith.Div(A.y, B.y)),
                (byte)(Arith.Div(A.z, B.z)),
                (byte)(Arith.Div(A.w, B.w)));
        }

        public static Vector2 ElDiv(this Vector2 A, Vector2 B)
        {
            return VecOps.MkVector2(
                (float)(Arith.Div(A.x, B.x)),
                (float)(Arith.Div(A.y, B.y)));
        }

        public static Vector3 ElDiv(this Vector3 A, Vector3 B)
        {
            return VecOps.MkVector3(
                (float)(Arith.Div(A.x, B.x)),
                (float)(Arith.Div(A.y, B.y)),
                (float)(Arith.Div(A.z, B.z)));
        }

        public static Vector4 ElDiv(this Vector4 A, Vector4 B)
        {
            return VecOps.MkVector4(
                (float)(Arith.Div(A.x, B.x)),
                (float)(Arith.Div(A.y, B.y)),
                (float)(Arith.Div(A.z, B.z)),
                (float)(Arith.Div(A.w, B.w)));
        }

        // Elementwise division that uses ceiling instead of floor
        public static VectorI2 ElCeilDiv(this VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.CeilDiv(A.x, B.x)),
                (Int32)(Arith.CeilDiv(A.y, B.y)));
        }

        public static VectorI3 ElCeilDiv(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.CeilDiv(A.x, B.x)),
                (Int32)(Arith.CeilDiv(A.y, B.y)),
                (Int32)(Arith.CeilDiv(A.z, B.z)));
        }

        public static VectorI4 ElCeilDiv(this VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.CeilDiv(A.x, B.x)),
                (Int32)(Arith.CeilDiv(A.y, B.y)),
                (Int32)(Arith.CeilDiv(A.z, B.z)),
                (Int32)(Arith.CeilDiv(A.w, B.w)));
        }

        public static VectorB2 ElCeilDiv(this VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.CeilDiv(A.x, B.x)),
                (byte)(Arith.CeilDiv(A.y, B.y)));
        }

        public static VectorB3 ElCeilDiv(this VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.CeilDiv(A.x, B.x)),
                (byte)(Arith.CeilDiv(A.y, B.y)),
                (byte)(Arith.CeilDiv(A.z, B.z)));
        }

        public static VectorB4 ElCeilDiv(this VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.CeilDiv(A.x, B.x)),
                (byte)(Arith.CeilDiv(A.y, B.y)),
                (byte)(Arith.CeilDiv(A.z, B.z)),
                (byte)(Arith.CeilDiv(A.w, B.w)));
        }

        // Elementwise min/max
        public static VectorI2 ElMin(this VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Min(A.x, B.x)),
                (Int32)(Arith.Min(A.y, B.y)));
        }

        public static VectorI3 ElMin(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Min(A.x, B.x)),
                (Int32)(Arith.Min(A.y, B.y)),
                (Int32)(Arith.Min(A.z, B.z)));
        }

        public static VectorI4 ElMin(this VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Min(A.x, B.x)),
                (Int32)(Arith.Min(A.y, B.y)),
                (Int32)(Arith.Min(A.z, B.z)),
                (Int32)(Arith.Min(A.w, B.w)));
        }

        public static VectorB2 ElMin(this VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Min(A.x, B.x)),
                (byte)(Arith.Min(A.y, B.y)));
        }

        public static VectorB3 ElMin(this VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Min(A.x, B.x)),
                (byte)(Arith.Min(A.y, B.y)),
                (byte)(Arith.Min(A.z, B.z)));
        }

        public static VectorB4 ElMin(this VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Min(A.x, B.x)),
                (byte)(Arith.Min(A.y, B.y)),
                (byte)(Arith.Min(A.z, B.z)),
                (byte)(Arith.Min(A.w, B.w)));
        }

        public static Vector2 ElMin(this Vector2 A, Vector2 B)
        {
            return VecOps.MkVector2(
                (float)(Arith.Min(A.x, B.x)),
                (float)(Arith.Min(A.y, B.y)));
        }

        public static Vector3 ElMin(this Vector3 A, Vector3 B)
        {
            return VecOps.MkVector3(
                (float)(Arith.Min(A.x, B.x)),
                (float)(Arith.Min(A.y, B.y)),
                (float)(Arith.Min(A.z, B.z)));
        }

        public static Vector4 ElMin(this Vector4 A, Vector4 B)
        {
            return VecOps.MkVector4(
                (float)(Arith.Min(A.x, B.x)),
                (float)(Arith.Min(A.y, B.y)),
                (float)(Arith.Min(A.z, B.z)),
                (float)(Arith.Min(A.w, B.w)));
        }

        public static VectorI2 ElMax(this VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Max(A.x, B.x)),
                (Int32)(Arith.Max(A.y, B.y)));
        }

        public static VectorI3 ElMax(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Max(A.x, B.x)),
                (Int32)(Arith.Max(A.y, B.y)),
                (Int32)(Arith.Max(A.z, B.z)));
        }

        public static VectorI4 ElMax(this VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Max(A.x, B.x)),
                (Int32)(Arith.Max(A.y, B.y)),
                (Int32)(Arith.Max(A.z, B.z)),
                (Int32)(Arith.Max(A.w, B.w)));
        }

        public static VectorB2 ElMax(this VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Max(A.x, B.x)),
                (byte)(Arith.Max(A.y, B.y)));
        }

        public static VectorB3 ElMax(this VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Max(A.x, B.x)),
                (byte)(Arith.Max(A.y, B.y)),
                (byte)(Arith.Max(A.z, B.z)));
        }

        public static VectorB4 ElMax(this VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Max(A.x, B.x)),
                (byte)(Arith.Max(A.y, B.y)),
                (byte)(Arith.Max(A.z, B.z)),
                (byte)(Arith.Max(A.w, B.w)));
        }

        public static Vector2 ElMax(this Vector2 A, Vector2 B)
        {
            return VecOps.MkVector2(
                (float)(Arith.Max(A.x, B.x)),
                (float)(Arith.Max(A.y, B.y)));
        }

        public static Vector3 ElMax(this Vector3 A, Vector3 B)
        {
            return VecOps.MkVector3(
                (float)(Arith.Max(A.x, B.x)),
                (float)(Arith.Max(A.y, B.y)),
                (float)(Arith.Max(A.z, B.z)));
        }

        public static Vector4 ElMax(this Vector4 A, Vector4 B)
        {
            return VecOps.MkVector4(
                (float)(Arith.Max(A.x, B.x)),
                (float)(Arith.Max(A.y, B.y)),
                (float)(Arith.Max(A.z, B.z)),
                (float)(Arith.Max(A.w, B.w)));
        }

        // Elementwise remainder. Uses floor.
        public static VectorI2 ElRem(this VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Rem(A.x, B.x)),
                (Int32)(Arith.Rem(A.y, B.y)));
        }

        public static VectorI3 ElRem(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Rem(A.x, B.x)),
                (Int32)(Arith.Rem(A.y, B.y)),
                (Int32)(Arith.Rem(A.z, B.z)));
        }

        public static VectorI4 ElRem(this VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Rem(A.x, B.x)),
                (Int32)(Arith.Rem(A.y, B.y)),
                (Int32)(Arith.Rem(A.z, B.z)),
                (Int32)(Arith.Rem(A.w, B.w)));
        }

        public static VectorB2 ElRem(this VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Rem(A.x, B.x)),
                (byte)(Arith.Rem(A.y, B.y)));
        }

        public static VectorB3 ElRem(this VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Rem(A.x, B.x)),
                (byte)(Arith.Rem(A.y, B.y)),
                (byte)(Arith.Rem(A.z, B.z)));
        }

        public static VectorB4 ElRem(this VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Rem(A.x, B.x)),
                (byte)(Arith.Rem(A.y, B.y)),
                (byte)(Arith.Rem(A.z, B.z)),
                (byte)(Arith.Rem(A.w, B.w)));
        }

        // Elementwise multiplication/division/remainder by 2^B_i
        public static VectorI2 ElPow2CeilDiv(this VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Int32)(Arith.Pow2CeilDiv(A.y, B.y)));
        }

        public static VectorI3 ElPow2CeilDiv(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Int32)(Arith.Pow2CeilDiv(A.y, B.y)),
                (Int32)(Arith.Pow2CeilDiv(A.z, B.z)));
        }

        public static VectorI4 ElPow2CeilDiv(this VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                (Int32)(Arith.Pow2CeilDiv(A.y, B.y)),
                (Int32)(Arith.Pow2CeilDiv(A.z, B.z)),
                (Int32)(Arith.Pow2CeilDiv(A.w, B.w)));
        }

        public static VectorB2 ElPow2CeilDiv(this VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                (byte)(Arith.Pow2CeilDiv(A.y, B.y)));
        }

        public static VectorB3 ElPow2CeilDiv(this VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                (byte)(Arith.Pow2CeilDiv(A.y, B.y)),
                (byte)(Arith.Pow2CeilDiv(A.z, B.z)));
        }

        public static VectorB4 ElPow2CeilDiv(this VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                (byte)(Arith.Pow2CeilDiv(A.y, B.y)),
                (byte)(Arith.Pow2CeilDiv(A.z, B.z)),
                (byte)(Arith.Pow2CeilDiv(A.w, B.w)));
        }

        public static VectorI2 ElPow2Div(this VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Pow2Div(A.x, B.x)),
                (Int32)(Arith.Pow2Div(A.y, B.y)));
        }

        public static VectorI3 ElPow2Div(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Pow2Div(A.x, B.x)),
                (Int32)(Arith.Pow2Div(A.y, B.y)),
                (Int32)(Arith.Pow2Div(A.z, B.z)));
        }

        public static VectorI4 ElPow2Div(this VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Pow2Div(A.x, B.x)),
                (Int32)(Arith.Pow2Div(A.y, B.y)),
                (Int32)(Arith.Pow2Div(A.z, B.z)),
                (Int32)(Arith.Pow2Div(A.w, B.w)));
        }

        public static VectorB2 ElPow2Div(this VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Pow2Div(A.x, B.x)),
                (byte)(Arith.Pow2Div(A.y, B.y)));
        }

        public static VectorB3 ElPow2Div(this VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Pow2Div(A.x, B.x)),
                (byte)(Arith.Pow2Div(A.y, B.y)),
                (byte)(Arith.Pow2Div(A.z, B.z)));
        }

        public static VectorB4 ElPow2Div(this VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Pow2Div(A.x, B.x)),
                (byte)(Arith.Pow2Div(A.y, B.y)),
                (byte)(Arith.Pow2Div(A.z, B.z)),
                (byte)(Arith.Pow2Div(A.w, B.w)));
        }

        public static VectorI2 ElPow2Mult(this VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Pow2Mult(A.x, B.x)),
                (Int32)(Arith.Pow2Mult(A.y, B.y)));
        }

        public static VectorI3 ElPow2Mult(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Pow2Mult(A.x, B.x)),
                (Int32)(Arith.Pow2Mult(A.y, B.y)),
                (Int32)(Arith.Pow2Mult(A.z, B.z)));
        }

        public static VectorI4 ElPow2Mult(this VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Pow2Mult(A.x, B.x)),
                (Int32)(Arith.Pow2Mult(A.y, B.y)),
                (Int32)(Arith.Pow2Mult(A.z, B.z)),
                (Int32)(Arith.Pow2Mult(A.w, B.w)));
        }

        public static VectorB2 ElPow2Mult(this VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Pow2Mult(A.x, B.x)),
                (byte)(Arith.Pow2Mult(A.y, B.y)));
        }

        public static VectorB3 ElPow2Mult(this VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Pow2Mult(A.x, B.x)),
                (byte)(Arith.Pow2Mult(A.y, B.y)),
                (byte)(Arith.Pow2Mult(A.z, B.z)));
        }

        public static VectorB4 ElPow2Mult(this VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Pow2Mult(A.x, B.x)),
                (byte)(Arith.Pow2Mult(A.y, B.y)),
                (byte)(Arith.Pow2Mult(A.z, B.z)),
                (byte)(Arith.Pow2Mult(A.w, B.w)));
        }

        public static VectorI2 ElPow2Rem(this VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(Arith.Pow2Rem(A.x, B.x)),
                (Int32)(Arith.Pow2Rem(A.y, B.y)));
        }

        public static VectorI3 ElPow2Rem(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(Arith.Pow2Rem(A.x, B.x)),
                (Int32)(Arith.Pow2Rem(A.y, B.y)),
                (Int32)(Arith.Pow2Rem(A.z, B.z)));
        }

        public static VectorI4 ElPow2Rem(this VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(Arith.Pow2Rem(A.x, B.x)),
                (Int32)(Arith.Pow2Rem(A.y, B.y)),
                (Int32)(Arith.Pow2Rem(A.z, B.z)),
                (Int32)(Arith.Pow2Rem(A.w, B.w)));
        }

        public static VectorB2 ElPow2Rem(this VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(Arith.Pow2Rem(A.x, B.x)),
                (byte)(Arith.Pow2Rem(A.y, B.y)));
        }

        public static VectorB3 ElPow2Rem(this VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(Arith.Pow2Rem(A.x, B.x)),
                (byte)(Arith.Pow2Rem(A.y, B.y)),
                (byte)(Arith.Pow2Rem(A.z, B.z)));
        }

        public static VectorB4 ElPow2Rem(this VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(Arith.Pow2Rem(A.x, B.x)),
                (byte)(Arith.Pow2Rem(A.y, B.y)),
                (byte)(Arith.Pow2Rem(A.z, B.z)),
                (byte)(Arith.Pow2Rem(A.w, B.w)));
        }

        // Dot product
        public static Int32 DotP(this VectorI2 A, VectorI2 B)
        {
            return (Int32)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.y * B.y));
        }

        public static Int32 DotP(this VectorI3 A, VectorI3 B)
        {
            return (Int32)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.z * B.z));
        }

        public static Int32 DotP(this VectorI4 A, VectorI4 B)
        {
            return (Int32)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.w * B.w));
        }

        public static byte DotP(this VectorB2 A, VectorB2 B)
        {
            return (byte)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.y * B.y));
        }

        public static Int32 DotPI(this VectorB2 A, VectorB2 B)
        {
            return (Int32)((Int32)(A.x * B.x)
                + (Int32)(A.y * B.y)
                + (Int32)(A.x * B.x)
                + (Int32)(A.y * B.y));
        }

        public static byte DotP(this VectorB3 A, VectorB3 B)
        {
            return (byte)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.z * B.z));
        }

        public static Int32 DotPI(this VectorB3 A, VectorB3 B)
        {
            return (Int32)((Int32)(A.x * B.x)
                + (Int32)(A.y * B.y)
                + (Int32)(A.x * B.x)
                + (Int32)(A.z * B.z));
        }

        public static byte DotP(this VectorB4 A, VectorB4 B)
        {
            return (byte)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.w * B.w));
        }

        public static Int32 DotPI(this VectorB4 A, VectorB4 B)
        {
            return (Int32)((Int32)(A.x * B.x)
                + (Int32)(A.y * B.y)
                + (Int32)(A.x * B.x)
                + (Int32)(A.w * B.w));
        }

        public static float DotP(this Vector2 A, Vector2 B)
        {
            return (float)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.y * B.y));
        }

        public static float DotP(this Vector3 A, Vector3 B)
        {
            return (float)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.z * B.z));
        }

        public static float DotP(this Vector4 A, Vector4 B)
        {
            return (float)((A.x * B.x)
                + (A.y * B.y)
                + (A.x * B.x)
                + (A.w * B.w));
        }

        // Square length
        public static Int32 SqLen(this VectorI2 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLen(this VectorI3 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLen(this VectorI4 V)
        {
            return DotP(V,V);
        }

        public static byte SqLen(this VectorB2 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLenI(this VectorB2 V)
        {
            return DotPI(V,V);
        }

        public static byte SqLen(this VectorB3 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLenI(this VectorB3 V)
        {
            return DotPI(V,V);
        }

        public static byte SqLen(this VectorB4 V)
        {
            return DotP(V,V);
        }

        public static Int32 SqLenI(this VectorB4 V)
        {
            return DotPI(V,V);
        }

        public static float SqLen(this Vector2 V)
        {
            return DotP(V,V);
        }

        public static float SqLen(this Vector3 V)
        {
            return DotP(V,V);
        }

        public static float SqLen(this Vector4 V)
        {
            return DotP(V,V);
        }

        // Manhattan length operators (ie sum of components)
        public static Int32 ManhatLength(this VectorI2 V)
        {
            return (Int32)(V.x + V.y);
        }

        public static Int32 ManhatLength(this VectorI3 V)
        {
            return (Int32)(V.x + V.y + V.z);
        }

        public static Int32 ManhatLength(this VectorI4 V)
        {
            return (Int32)(V.x + V.y + V.z + V.w);
        }

        public static byte ManhatLength(this VectorB2 V)
        {
            return (byte)(V.x + V.y);
        }

        public static byte ManhatLength(this VectorB3 V)
        {
            return (byte)(V.x + V.y + V.z);
        }

        public static byte ManhatLength(this VectorB4 V)
        {
            return (byte)(V.x + V.y + V.z + V.w);
        }

        public static float ManhatLength(this Vector2 V)
        {
            return (float)(V.x + V.y);
        }

        public static float ManhatLength(this Vector3 V)
        {
            return (float)(V.x + V.y + V.z);
        }

        public static float ManhatLength(this Vector4 V)
        {
            return (float)(V.x + V.y + V.z + V.w);
        }

        // Vector length (as in, euclidean)
        public static float Len(this Vector2 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static float Len(this Vector3 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        public static float Len(this Vector4 V)
        {
            return Arith.Sqrt(SqLen(V));
        }

        // Normalized vector
        public static Vector2 Norm(this Vector2 V)
        {
            return V/Len(V);
        }

        public static Vector3 Norm(this Vector3 V)
        {
            return V/Len(V);
        }

        public static Vector4 Norm(this Vector4 V)
        {
            return V/Len(V);
        }

        // Product of components of vector
        public static Int32 Volume(this VectorI2 V)
        {
            return (Int32)(V.x * V.y);
        }

        public static Int32 Volume(this VectorI3 V)
        {
            return (Int32)(V.x * V.y * V.z);
        }

        public static Int32 Volume(this VectorI4 V)
        {
            return (Int32)(V.x * V.y * V.z * V.w);
        }

        public static byte Volume(this VectorB2 V)
        {
            return (byte)(V.x * V.y);
        }

        public static Int32 VolumeI(this VectorB2 V)
        {
            return (Int32)(V.x * V.y);
        }

        public static byte Volume(this VectorB3 V)
        {
            return (byte)(V.x * V.y * V.z);
        }

        public static Int32 VolumeI(this VectorB3 V)
        {
            return (Int32)(V.x * V.y * V.z);
        }

        public static byte Volume(this VectorB4 V)
        {
            return (byte)(V.x * V.y * V.z * V.w);
        }

        public static Int32 VolumeI(this VectorB4 V)
        {
            return (Int32)(V.x * V.y * V.z * V.w);
        }

        public static float Volume(this Vector2 V)
        {
            return (float)(V.x * V.y);
        }

        public static float Volume(this Vector3 V)
        {
            return (float)(V.x * V.y * V.z);
        }

        public static float Volume(this Vector4 V)
        {
            return (float)(V.x * V.y * V.z * V.w);
        }

        public static Int32 Pow2Volume(this VectorI2 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y));
        }

        public static Int32 Pow2Volume(this VectorI3 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z));
        }

        public static Int32 Pow2Volume(this VectorI4 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z + V.w));
        }

        public static byte Pow2Volume(this VectorB2 V)
        {
            return Arith.Pow2Mult((byte)1, (byte)(V.x + V.y));
        }

        public static Int32 Pow2VolumeI(this VectorB2 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y));
        }

        public static byte Pow2Volume(this VectorB3 V)
        {
            return Arith.Pow2Mult((byte)1, (byte)(V.x + V.y + V.z));
        }

        public static Int32 Pow2VolumeI(this VectorB3 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z));
        }

        public static byte Pow2Volume(this VectorB4 V)
        {
            return Arith.Pow2Mult((byte)1, (byte)(V.x + V.y + V.z + V.w));
        }

        public static Int32 Pow2VolumeI(this VectorB4 V)
        {
            return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z + V.w));
        }

        // Cross product
        public static VectorI3 CrossP(this VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (A.y * B.z) - (A.z * B.y),
                -(A.x * B.z) + (A.z * B.x),
                (A.x * B.y) - (A.y * B.x));
        }

        public static Vector3 CrossP(this Vector3 A, Vector3 B)
        {
            return VecOps.MkVector3(
                (A.y * B.z) - (A.z * B.y),
                -(A.x * B.z) + (A.z * B.x),
                (A.x * B.y) - (A.y * B.x));
        }

        // Some C#-specific functions
        public static VectorI2 Select(this VectorI2 V, Func<Int32, Int32> func)
        {
            return VecOps.MkVectorI2(
                (Int32)(func(V.x)),
                (Int32)(func(V.y)));
        }

        public static VectorI3 Select(this VectorI3 V, Func<Int32, Int32> func)
        {
            return VecOps.MkVectorI3(
                (Int32)(func(V.x)),
                (Int32)(func(V.y)),
                (Int32)(func(V.z)));
        }

        public static VectorI4 Select(this VectorI4 V, Func<Int32, Int32> func)
        {
            return VecOps.MkVectorI4(
                (Int32)(func(V.x)),
                (Int32)(func(V.y)),
                (Int32)(func(V.z)),
                (Int32)(func(V.w)));
        }

        public static VectorB2 Select(this VectorB2 V, Func<byte, byte> func)
        {
            return VecOps.MkVectorB2(
                (byte)(func(V.x)),
                (byte)(func(V.y)));
        }

        public static VectorB3 Select(this VectorB3 V, Func<byte, byte> func)
        {
            return VecOps.MkVectorB3(
                (byte)(func(V.x)),
                (byte)(func(V.y)),
                (byte)(func(V.z)));
        }

        public static VectorB4 Select(this VectorB4 V, Func<byte, byte> func)
        {
            return VecOps.MkVectorB4(
                (byte)(func(V.x)),
                (byte)(func(V.y)),
                (byte)(func(V.z)),
                (byte)(func(V.w)));
        }

        public static Vector2 Select(this Vector2 V, Func<float, float> func)
        {
            return VecOps.MkVector2(
                (float)(func(V.x)),
                (float)(func(V.y)));
        }

        public static Vector3 Select(this Vector3 V, Func<float, float> func)
        {
            return VecOps.MkVector3(
                (float)(func(V.x)),
                (float)(func(V.y)),
                (float)(func(V.z)));
        }

        public static Vector4 Select(this Vector4 V, Func<float, float> func)
        {
            return VecOps.MkVector4(
                (float)(func(V.x)),
                (float)(func(V.y)),
                (float)(func(V.z)),
                (float)(func(V.w)));
        }

        public static Int32[] Members(this VectorI2 V)
        {
            return new[] { V.x, V.y };
        }

        public static Int32[] Members(this VectorI3 V)
        {
            return new[] { V.x, V.y, V.z };
        }

        public static Int32[] Members(this VectorI4 V)
        {
            return new[] { V.x, V.y, V.z, V.w };
        }

        public static byte[] Members(this VectorB2 V)
        {
            return new[] { V.x, V.y };
        }

        public static byte[] Members(this VectorB3 V)
        {
            return new[] { V.x, V.y, V.z };
        }

        public static byte[] Members(this VectorB4 V)
        {
            return new[] { V.x, V.y, V.z, V.w };
        }

        public static float[] Members(this Vector2 V)
        {
            return new[] { V.x, V.y };
        }

        public static float[] Members(this Vector3 V)
        {
            return new[] { V.x, V.y, V.z };
        }

        public static float[] Members(this Vector4 V)
        {
            return new[] { V.x, V.y, V.z, V.w };
        }

        public static VectorI2 ToVectorI2(this System.Collections.Generic.IEnumerable<Int32> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return VecOps.MkVectorI2(array[0], array[1]);
        }

        public static VectorI3 ToVectorI3(this System.Collections.Generic.IEnumerable<Int32> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return VecOps.MkVectorI3(array[0], array[1], array[2]);
        }

        public static VectorI4 ToVectorI4(this System.Collections.Generic.IEnumerable<Int32> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return VecOps.MkVectorI4(array[0], array[1], array[2], array[3]);
        }

        public static VectorB2 ToVectorB2(this System.Collections.Generic.IEnumerable<byte> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return VecOps.MkVectorB2(array[0], array[1]);
        }

        public static VectorB3 ToVectorB3(this System.Collections.Generic.IEnumerable<byte> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return VecOps.MkVectorB3(array[0], array[1], array[2]);
        }

        public static VectorB4 ToVectorB4(this System.Collections.Generic.IEnumerable<byte> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return VecOps.MkVectorB4(array[0], array[1], array[2], array[3]);
        }

        public static Vector2 ToVector2(this System.Collections.Generic.IEnumerable<float> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
            return VecOps.MkVector2(array[0], array[1]);
        }

        public static Vector3 ToVector3(this System.Collections.Generic.IEnumerable<float> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
            return VecOps.MkVector3(array[0], array[1], array[2]);
        }

        public static Vector4 ToVector4(this System.Collections.Generic.IEnumerable<float> list)
        {
            var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
            return VecOps.MkVector4(array[0], array[1], array[2], array[3]);
        }

    }
}