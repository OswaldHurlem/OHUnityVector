// Generated with oh_unity_vector_generator.py
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;

namespace OH
{
    namespace Ext
    {
        public static partial class VecExt
        {
            // Constructors from other vectors. Float converts to int using floor
            public static VectorI2 MkVectorI2B(this VectorB2 V)
            {
                return OHV.MkVectorI2B(V.x, V.y);
            }

            public static VectorI2 MkVectorI2D(this VectorD2 V)
            {
                return OHV.MkVectorI2D(V.x, V.y);
            }

            public static VectorI2 MkVectorI2F(this Vector2 V)
            {
                return OHV.MkVectorI2F(V.x, V.y);
            }

            public static VectorI3 MkVectorI3B(this VectorB3 V)
            {
                return OHV.MkVectorI3B(V.x, V.y, V.z);
            }

            public static VectorI3 MkVectorI3D(this VectorD3 V)
            {
                return OHV.MkVectorI3D(V.x, V.y, V.z);
            }

            public static VectorI3 MkVectorI3F(this Vector3 V)
            {
                return OHV.MkVectorI3F(V.x, V.y, V.z);
            }

            public static VectorI4 MkVectorI4B(this VectorB4 V)
            {
                return OHV.MkVectorI4B(V.x, V.y, V.z, V.w);
            }

            public static VectorI4 MkVectorI4D(this VectorD4 V)
            {
                return OHV.MkVectorI4D(V.x, V.y, V.z, V.w);
            }

            public static VectorI4 MkVectorI4F(this Vector4 V)
            {
                return OHV.MkVectorI4F(V.x, V.y, V.z, V.w);
            }

            public static VectorB2 MkVectorB2I(this VectorI2 V)
            {
                return OHV.MkVectorB2I(V.x, V.y);
            }

            public static VectorB2 MkVectorB2D(this VectorD2 V)
            {
                return OHV.MkVectorB2D(V.x, V.y);
            }

            public static VectorB2 MkVectorB2F(this Vector2 V)
            {
                return OHV.MkVectorB2F(V.x, V.y);
            }

            public static VectorB3 MkVectorB3I(this VectorI3 V)
            {
                return OHV.MkVectorB3I(V.x, V.y, V.z);
            }

            public static VectorB3 MkVectorB3D(this VectorD3 V)
            {
                return OHV.MkVectorB3D(V.x, V.y, V.z);
            }

            public static VectorB3 MkVectorB3F(this Vector3 V)
            {
                return OHV.MkVectorB3F(V.x, V.y, V.z);
            }

            public static VectorB4 MkVectorB4I(this VectorI4 V)
            {
                return OHV.MkVectorB4I(V.x, V.y, V.z, V.w);
            }

            public static VectorB4 MkVectorB4D(this VectorD4 V)
            {
                return OHV.MkVectorB4D(V.x, V.y, V.z, V.w);
            }

            public static VectorB4 MkVectorB4F(this Vector4 V)
            {
                return OHV.MkVectorB4F(V.x, V.y, V.z, V.w);
            }

            public static VectorD2 MkVectorD2I(this VectorI2 V)
            {
                return OHV.MkVectorD2I(V.x, V.y);
            }

            public static VectorD2 MkVectorD2B(this VectorB2 V)
            {
                return OHV.MkVectorD2B(V.x, V.y);
            }

            public static VectorD2 MkVectorD2F(this Vector2 V)
            {
                return OHV.MkVectorD2F(V.x, V.y);
            }

            public static VectorD3 MkVectorD3I(this VectorI3 V)
            {
                return OHV.MkVectorD3I(V.x, V.y, V.z);
            }

            public static VectorD3 MkVectorD3B(this VectorB3 V)
            {
                return OHV.MkVectorD3B(V.x, V.y, V.z);
            }

            public static VectorD3 MkVectorD3F(this Vector3 V)
            {
                return OHV.MkVectorD3F(V.x, V.y, V.z);
            }

            public static VectorD4 MkVectorD4I(this VectorI4 V)
            {
                return OHV.MkVectorD4I(V.x, V.y, V.z, V.w);
            }

            public static VectorD4 MkVectorD4B(this VectorB4 V)
            {
                return OHV.MkVectorD4B(V.x, V.y, V.z, V.w);
            }

            public static VectorD4 MkVectorD4F(this Vector4 V)
            {
                return OHV.MkVectorD4F(V.x, V.y, V.z, V.w);
            }

            public static Vector2 MkVector2I(this VectorI2 V)
            {
                return OHV.MkVector2I(V.x, V.y);
            }

            public static Vector2 MkVector2B(this VectorB2 V)
            {
                return OHV.MkVector2B(V.x, V.y);
            }

            public static Vector2 MkVector2D(this VectorD2 V)
            {
                return OHV.MkVector2D(V.x, V.y);
            }

            public static Vector3 MkVector3I(this VectorI3 V)
            {
                return OHV.MkVector3I(V.x, V.y, V.z);
            }

            public static Vector3 MkVector3B(this VectorB3 V)
            {
                return OHV.MkVector3B(V.x, V.y, V.z);
            }

            public static Vector3 MkVector3D(this VectorD3 V)
            {
                return OHV.MkVector3D(V.x, V.y, V.z);
            }

            public static Vector4 MkVector4I(this VectorI4 V)
            {
                return OHV.MkVector4I(V.x, V.y, V.z, V.w);
            }

            public static Vector4 MkVector4B(this VectorB4 V)
            {
                return OHV.MkVector4B(V.x, V.y, V.z, V.w);
            }

            public static Vector4 MkVector4D(this VectorD4 V)
            {
                return OHV.MkVector4D(V.x, V.y, V.z, V.w);
            }

            // Constructors from ceiling rather than floor
            public static VectorI2 CeilVectorI2D(this VectorD2 V)
            {
                return OHV.MkVectorI2D(Arith.CeilID(V.x), Arith.CeilID(V.y));
            }

            public static VectorI2 CeilVectorI2F(this Vector2 V)
            {
                return OHV.MkVectorI2F(Arith.CeilIF(V.x), Arith.CeilIF(V.y));
            }

            public static VectorI3 CeilVectorI3D(this VectorD3 V)
            {
                return OHV.MkVectorI3D(Arith.CeilID(V.x), Arith.CeilID(V.y), Arith.CeilID(V.z));
            }

            public static VectorI3 CeilVectorI3F(this Vector3 V)
            {
                return OHV.MkVectorI3F(Arith.CeilIF(V.x), Arith.CeilIF(V.y), Arith.CeilIF(V.z));
            }

            public static VectorI4 CeilVectorI4D(this VectorD4 V)
            {
                return OHV.MkVectorI4D(Arith.CeilID(V.x), Arith.CeilID(V.y), Arith.CeilID(V.z), Arith.CeilID(V.w));
            }

            public static VectorI4 CeilVectorI4F(this Vector4 V)
            {
                return OHV.MkVectorI4F(Arith.CeilIF(V.x), Arith.CeilIF(V.y), Arith.CeilIF(V.z), Arith.CeilIF(V.w));
            }

            public static VectorB2 CeilVectorB2D(this VectorD2 V)
            {
                return OHV.MkVectorB2D(Arith.CeilBD(V.x), Arith.CeilBD(V.y));
            }

            public static VectorB2 CeilVectorB2F(this Vector2 V)
            {
                return OHV.MkVectorB2F(Arith.CeilBF(V.x), Arith.CeilBF(V.y));
            }

            public static VectorB3 CeilVectorB3D(this VectorD3 V)
            {
                return OHV.MkVectorB3D(Arith.CeilBD(V.x), Arith.CeilBD(V.y), Arith.CeilBD(V.z));
            }

            public static VectorB3 CeilVectorB3F(this Vector3 V)
            {
                return OHV.MkVectorB3F(Arith.CeilBF(V.x), Arith.CeilBF(V.y), Arith.CeilBF(V.z));
            }

            public static VectorB4 CeilVectorB4D(this VectorD4 V)
            {
                return OHV.MkVectorB4D(Arith.CeilBD(V.x), Arith.CeilBD(V.y), Arith.CeilBD(V.z), Arith.CeilBD(V.w));
            }

            public static VectorB4 CeilVectorB4F(this Vector4 V)
            {
                return OHV.MkVectorB4F(Arith.CeilBF(V.x), Arith.CeilBF(V.y), Arith.CeilBF(V.z), Arith.CeilBF(V.w));
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

            public static Boolean StrictGt(this VectorD2 A, VectorD2 B)
            {
                return (A.x > B.x)
                    && (A.y > B.y);
            }

            public static Boolean StrictGt(this VectorD3 A, VectorD3 B)
            {
                return (A.x > B.x)
                    && (A.y > B.y)
                    && (A.z > B.z);
            }

            public static Boolean StrictGt(this VectorD4 A, VectorD4 B)
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

            public static Boolean StrictLt(this VectorD2 A, VectorD2 B)
            {
                return (A.x < B.x)
                    && (A.y < B.y);
            }

            public static Boolean StrictLt(this VectorD3 A, VectorD3 B)
            {
                return (A.x < B.x)
                    && (A.y < B.y)
                    && (A.z < B.z);
            }

            public static Boolean StrictLt(this VectorD4 A, VectorD4 B)
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

            public static Boolean StrictGte(this VectorD2 A, VectorD2 B)
            {
                return (A.x >= B.x)
                    && (A.y >= B.y);
            }

            public static Boolean StrictGte(this VectorD3 A, VectorD3 B)
            {
                return (A.x >= B.x)
                    && (A.y >= B.y)
                    && (A.z >= B.z);
            }

            public static Boolean StrictGte(this VectorD4 A, VectorD4 B)
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

            public static Boolean StrictLte(this VectorD2 A, VectorD2 B)
            {
                return (A.x <= B.x)
                    && (A.y <= B.y);
            }

            public static Boolean StrictLte(this VectorD3 A, VectorD3 B)
            {
                return (A.x <= B.x)
                    && (A.y <= B.y)
                    && (A.z <= B.z);
            }

            public static Boolean StrictLte(this VectorD4 A, VectorD4 B)
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
                return OHV.MkVectorI2(
                    (Int32)(A.x * B.x),
                    (Int32)(A.y * B.y));
            }

            public static VectorI3 ElMult(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (Int32)(A.x * B.x),
                    (Int32)(A.y * B.y),
                    (Int32)(A.z * B.z));
            }

            public static VectorI4 ElMult(this VectorI4 A, VectorI4 B)
            {
                return OHV.MkVectorI4(
                    (Int32)(A.x * B.x),
                    (Int32)(A.y * B.y),
                    (Int32)(A.z * B.z),
                    (Int32)(A.w * B.w));
            }

            public static VectorB2 ElMult(this VectorB2 A, VectorB2 B)
            {
                return OHV.MkVectorB2(
                    (Byte)(A.x * B.x),
                    (Byte)(A.y * B.y));
            }

            public static VectorB3 ElMult(this VectorB3 A, VectorB3 B)
            {
                return OHV.MkVectorB3(
                    (Byte)(A.x * B.x),
                    (Byte)(A.y * B.y),
                    (Byte)(A.z * B.z));
            }

            public static VectorB4 ElMult(this VectorB4 A, VectorB4 B)
            {
                return OHV.MkVectorB4(
                    (Byte)(A.x * B.x),
                    (Byte)(A.y * B.y),
                    (Byte)(A.z * B.z),
                    (Byte)(A.w * B.w));
            }

            public static VectorD2 ElMult(this VectorD2 A, VectorD2 B)
            {
                return OHV.MkVectorD2(
                    (Double)(A.x * B.x),
                    (Double)(A.y * B.y));
            }

            public static VectorD3 ElMult(this VectorD3 A, VectorD3 B)
            {
                return OHV.MkVectorD3(
                    (Double)(A.x * B.x),
                    (Double)(A.y * B.y),
                    (Double)(A.z * B.z));
            }

            public static VectorD4 ElMult(this VectorD4 A, VectorD4 B)
            {
                return OHV.MkVectorD4(
                    (Double)(A.x * B.x),
                    (Double)(A.y * B.y),
                    (Double)(A.z * B.z),
                    (Double)(A.w * B.w));
            }

            public static Vector2 ElMult(this Vector2 A, Vector2 B)
            {
                return OHV.MkVector2(
                    (Single)(A.x * B.x),
                    (Single)(A.y * B.y));
            }

            public static Vector3 ElMult(this Vector3 A, Vector3 B)
            {
                return OHV.MkVector3(
                    (Single)(A.x * B.x),
                    (Single)(A.y * B.y),
                    (Single)(A.z * B.z));
            }

            public static Vector4 ElMult(this Vector4 A, Vector4 B)
            {
                return OHV.MkVector4(
                    (Single)(A.x * B.x),
                    (Single)(A.y * B.y),
                    (Single)(A.z * B.z),
                    (Single)(A.w * B.w));
            }

            // Elementwise division. Uses floor.
            public static VectorI2 ElDiv(this VectorI2 A, VectorI2 B)
            {
                return OHV.MkVectorI2(
                    (Int32)(Arith.Div(A.x, B.x)),
                    (Int32)(Arith.Div(A.y, B.y)));
            }

            public static VectorI3 ElDiv(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (Int32)(Arith.Div(A.x, B.x)),
                    (Int32)(Arith.Div(A.y, B.y)),
                    (Int32)(Arith.Div(A.z, B.z)));
            }

            public static VectorI4 ElDiv(this VectorI4 A, VectorI4 B)
            {
                return OHV.MkVectorI4(
                    (Int32)(Arith.Div(A.x, B.x)),
                    (Int32)(Arith.Div(A.y, B.y)),
                    (Int32)(Arith.Div(A.z, B.z)),
                    (Int32)(Arith.Div(A.w, B.w)));
            }

            public static VectorB2 ElDiv(this VectorB2 A, VectorB2 B)
            {
                return OHV.MkVectorB2(
                    (Byte)(Arith.Div(A.x, B.x)),
                    (Byte)(Arith.Div(A.y, B.y)));
            }

            public static VectorB3 ElDiv(this VectorB3 A, VectorB3 B)
            {
                return OHV.MkVectorB3(
                    (Byte)(Arith.Div(A.x, B.x)),
                    (Byte)(Arith.Div(A.y, B.y)),
                    (Byte)(Arith.Div(A.z, B.z)));
            }

            public static VectorB4 ElDiv(this VectorB4 A, VectorB4 B)
            {
                return OHV.MkVectorB4(
                    (Byte)(Arith.Div(A.x, B.x)),
                    (Byte)(Arith.Div(A.y, B.y)),
                    (Byte)(Arith.Div(A.z, B.z)),
                    (Byte)(Arith.Div(A.w, B.w)));
            }

            public static VectorD2 ElDiv(this VectorD2 A, VectorD2 B)
            {
                return OHV.MkVectorD2(
                    (Double)(Arith.Div(A.x, B.x)),
                    (Double)(Arith.Div(A.y, B.y)));
            }

            public static VectorD3 ElDiv(this VectorD3 A, VectorD3 B)
            {
                return OHV.MkVectorD3(
                    (Double)(Arith.Div(A.x, B.x)),
                    (Double)(Arith.Div(A.y, B.y)),
                    (Double)(Arith.Div(A.z, B.z)));
            }

            public static VectorD4 ElDiv(this VectorD4 A, VectorD4 B)
            {
                return OHV.MkVectorD4(
                    (Double)(Arith.Div(A.x, B.x)),
                    (Double)(Arith.Div(A.y, B.y)),
                    (Double)(Arith.Div(A.z, B.z)),
                    (Double)(Arith.Div(A.w, B.w)));
            }

            public static Vector2 ElDiv(this Vector2 A, Vector2 B)
            {
                return OHV.MkVector2(
                    (Single)(Arith.Div(A.x, B.x)),
                    (Single)(Arith.Div(A.y, B.y)));
            }

            public static Vector3 ElDiv(this Vector3 A, Vector3 B)
            {
                return OHV.MkVector3(
                    (Single)(Arith.Div(A.x, B.x)),
                    (Single)(Arith.Div(A.y, B.y)),
                    (Single)(Arith.Div(A.z, B.z)));
            }

            public static Vector4 ElDiv(this Vector4 A, Vector4 B)
            {
                return OHV.MkVector4(
                    (Single)(Arith.Div(A.x, B.x)),
                    (Single)(Arith.Div(A.y, B.y)),
                    (Single)(Arith.Div(A.z, B.z)),
                    (Single)(Arith.Div(A.w, B.w)));
            }

            // Elementwise division that uses ceiling instead of floor
            public static VectorI2 ElCeilDiv(this VectorI2 A, VectorI2 B)
            {
                return OHV.MkVectorI2(
                    (Int32)(Arith.CeilDiv(A.x, B.x)),
                    (Int32)(Arith.CeilDiv(A.y, B.y)));
            }

            public static VectorI3 ElCeilDiv(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (Int32)(Arith.CeilDiv(A.x, B.x)),
                    (Int32)(Arith.CeilDiv(A.y, B.y)),
                    (Int32)(Arith.CeilDiv(A.z, B.z)));
            }

            public static VectorI4 ElCeilDiv(this VectorI4 A, VectorI4 B)
            {
                return OHV.MkVectorI4(
                    (Int32)(Arith.CeilDiv(A.x, B.x)),
                    (Int32)(Arith.CeilDiv(A.y, B.y)),
                    (Int32)(Arith.CeilDiv(A.z, B.z)),
                    (Int32)(Arith.CeilDiv(A.w, B.w)));
            }

            public static VectorB2 ElCeilDiv(this VectorB2 A, VectorB2 B)
            {
                return OHV.MkVectorB2(
                    (Byte)(Arith.CeilDiv(A.x, B.x)),
                    (Byte)(Arith.CeilDiv(A.y, B.y)));
            }

            public static VectorB3 ElCeilDiv(this VectorB3 A, VectorB3 B)
            {
                return OHV.MkVectorB3(
                    (Byte)(Arith.CeilDiv(A.x, B.x)),
                    (Byte)(Arith.CeilDiv(A.y, B.y)),
                    (Byte)(Arith.CeilDiv(A.z, B.z)));
            }

            public static VectorB4 ElCeilDiv(this VectorB4 A, VectorB4 B)
            {
                return OHV.MkVectorB4(
                    (Byte)(Arith.CeilDiv(A.x, B.x)),
                    (Byte)(Arith.CeilDiv(A.y, B.y)),
                    (Byte)(Arith.CeilDiv(A.z, B.z)),
                    (Byte)(Arith.CeilDiv(A.w, B.w)));
            }

            // Elementwise min/max
            public static VectorI2 ElMin(this VectorI2 A, VectorI2 B)
            {
                return OHV.MkVectorI2(
                    (Int32)(Arith.Min(A.x, B.x)),
                    (Int32)(Arith.Min(A.y, B.y)));
            }

            public static VectorI3 ElMin(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (Int32)(Arith.Min(A.x, B.x)),
                    (Int32)(Arith.Min(A.y, B.y)),
                    (Int32)(Arith.Min(A.z, B.z)));
            }

            public static VectorI4 ElMin(this VectorI4 A, VectorI4 B)
            {
                return OHV.MkVectorI4(
                    (Int32)(Arith.Min(A.x, B.x)),
                    (Int32)(Arith.Min(A.y, B.y)),
                    (Int32)(Arith.Min(A.z, B.z)),
                    (Int32)(Arith.Min(A.w, B.w)));
            }

            public static VectorB2 ElMin(this VectorB2 A, VectorB2 B)
            {
                return OHV.MkVectorB2(
                    (Byte)(Arith.Min(A.x, B.x)),
                    (Byte)(Arith.Min(A.y, B.y)));
            }

            public static VectorB3 ElMin(this VectorB3 A, VectorB3 B)
            {
                return OHV.MkVectorB3(
                    (Byte)(Arith.Min(A.x, B.x)),
                    (Byte)(Arith.Min(A.y, B.y)),
                    (Byte)(Arith.Min(A.z, B.z)));
            }

            public static VectorB4 ElMin(this VectorB4 A, VectorB4 B)
            {
                return OHV.MkVectorB4(
                    (Byte)(Arith.Min(A.x, B.x)),
                    (Byte)(Arith.Min(A.y, B.y)),
                    (Byte)(Arith.Min(A.z, B.z)),
                    (Byte)(Arith.Min(A.w, B.w)));
            }

            public static VectorD2 ElMin(this VectorD2 A, VectorD2 B)
            {
                return OHV.MkVectorD2(
                    (Double)(Arith.Min(A.x, B.x)),
                    (Double)(Arith.Min(A.y, B.y)));
            }

            public static VectorD3 ElMin(this VectorD3 A, VectorD3 B)
            {
                return OHV.MkVectorD3(
                    (Double)(Arith.Min(A.x, B.x)),
                    (Double)(Arith.Min(A.y, B.y)),
                    (Double)(Arith.Min(A.z, B.z)));
            }

            public static VectorD4 ElMin(this VectorD4 A, VectorD4 B)
            {
                return OHV.MkVectorD4(
                    (Double)(Arith.Min(A.x, B.x)),
                    (Double)(Arith.Min(A.y, B.y)),
                    (Double)(Arith.Min(A.z, B.z)),
                    (Double)(Arith.Min(A.w, B.w)));
            }

            public static Vector2 ElMin(this Vector2 A, Vector2 B)
            {
                return OHV.MkVector2(
                    (Single)(Arith.Min(A.x, B.x)),
                    (Single)(Arith.Min(A.y, B.y)));
            }

            public static Vector3 ElMin(this Vector3 A, Vector3 B)
            {
                return OHV.MkVector3(
                    (Single)(Arith.Min(A.x, B.x)),
                    (Single)(Arith.Min(A.y, B.y)),
                    (Single)(Arith.Min(A.z, B.z)));
            }

            public static Vector4 ElMin(this Vector4 A, Vector4 B)
            {
                return OHV.MkVector4(
                    (Single)(Arith.Min(A.x, B.x)),
                    (Single)(Arith.Min(A.y, B.y)),
                    (Single)(Arith.Min(A.z, B.z)),
                    (Single)(Arith.Min(A.w, B.w)));
            }

            public static VectorI2 ElMax(this VectorI2 A, VectorI2 B)
            {
                return OHV.MkVectorI2(
                    (Int32)(Arith.Max(A.x, B.x)),
                    (Int32)(Arith.Max(A.y, B.y)));
            }

            public static VectorI3 ElMax(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (Int32)(Arith.Max(A.x, B.x)),
                    (Int32)(Arith.Max(A.y, B.y)),
                    (Int32)(Arith.Max(A.z, B.z)));
            }

            public static VectorI4 ElMax(this VectorI4 A, VectorI4 B)
            {
                return OHV.MkVectorI4(
                    (Int32)(Arith.Max(A.x, B.x)),
                    (Int32)(Arith.Max(A.y, B.y)),
                    (Int32)(Arith.Max(A.z, B.z)),
                    (Int32)(Arith.Max(A.w, B.w)));
            }

            public static VectorB2 ElMax(this VectorB2 A, VectorB2 B)
            {
                return OHV.MkVectorB2(
                    (Byte)(Arith.Max(A.x, B.x)),
                    (Byte)(Arith.Max(A.y, B.y)));
            }

            public static VectorB3 ElMax(this VectorB3 A, VectorB3 B)
            {
                return OHV.MkVectorB3(
                    (Byte)(Arith.Max(A.x, B.x)),
                    (Byte)(Arith.Max(A.y, B.y)),
                    (Byte)(Arith.Max(A.z, B.z)));
            }

            public static VectorB4 ElMax(this VectorB4 A, VectorB4 B)
            {
                return OHV.MkVectorB4(
                    (Byte)(Arith.Max(A.x, B.x)),
                    (Byte)(Arith.Max(A.y, B.y)),
                    (Byte)(Arith.Max(A.z, B.z)),
                    (Byte)(Arith.Max(A.w, B.w)));
            }

            public static VectorD2 ElMax(this VectorD2 A, VectorD2 B)
            {
                return OHV.MkVectorD2(
                    (Double)(Arith.Max(A.x, B.x)),
                    (Double)(Arith.Max(A.y, B.y)));
            }

            public static VectorD3 ElMax(this VectorD3 A, VectorD3 B)
            {
                return OHV.MkVectorD3(
                    (Double)(Arith.Max(A.x, B.x)),
                    (Double)(Arith.Max(A.y, B.y)),
                    (Double)(Arith.Max(A.z, B.z)));
            }

            public static VectorD4 ElMax(this VectorD4 A, VectorD4 B)
            {
                return OHV.MkVectorD4(
                    (Double)(Arith.Max(A.x, B.x)),
                    (Double)(Arith.Max(A.y, B.y)),
                    (Double)(Arith.Max(A.z, B.z)),
                    (Double)(Arith.Max(A.w, B.w)));
            }

            public static Vector2 ElMax(this Vector2 A, Vector2 B)
            {
                return OHV.MkVector2(
                    (Single)(Arith.Max(A.x, B.x)),
                    (Single)(Arith.Max(A.y, B.y)));
            }

            public static Vector3 ElMax(this Vector3 A, Vector3 B)
            {
                return OHV.MkVector3(
                    (Single)(Arith.Max(A.x, B.x)),
                    (Single)(Arith.Max(A.y, B.y)),
                    (Single)(Arith.Max(A.z, B.z)));
            }

            public static Vector4 ElMax(this Vector4 A, Vector4 B)
            {
                return OHV.MkVector4(
                    (Single)(Arith.Max(A.x, B.x)),
                    (Single)(Arith.Max(A.y, B.y)),
                    (Single)(Arith.Max(A.z, B.z)),
                    (Single)(Arith.Max(A.w, B.w)));
            }

            // Elementwise remainder. Uses floor.
            public static VectorI2 ElRem(this VectorI2 A, VectorI2 B)
            {
                return OHV.MkVectorI2(
                    (Int32)(Arith.Rem(A.x, B.x)),
                    (Int32)(Arith.Rem(A.y, B.y)));
            }

            public static VectorI3 ElRem(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (Int32)(Arith.Rem(A.x, B.x)),
                    (Int32)(Arith.Rem(A.y, B.y)),
                    (Int32)(Arith.Rem(A.z, B.z)));
            }

            public static VectorI4 ElRem(this VectorI4 A, VectorI4 B)
            {
                return OHV.MkVectorI4(
                    (Int32)(Arith.Rem(A.x, B.x)),
                    (Int32)(Arith.Rem(A.y, B.y)),
                    (Int32)(Arith.Rem(A.z, B.z)),
                    (Int32)(Arith.Rem(A.w, B.w)));
            }

            public static VectorB2 ElRem(this VectorB2 A, VectorB2 B)
            {
                return OHV.MkVectorB2(
                    (Byte)(Arith.Rem(A.x, B.x)),
                    (Byte)(Arith.Rem(A.y, B.y)));
            }

            public static VectorB3 ElRem(this VectorB3 A, VectorB3 B)
            {
                return OHV.MkVectorB3(
                    (Byte)(Arith.Rem(A.x, B.x)),
                    (Byte)(Arith.Rem(A.y, B.y)),
                    (Byte)(Arith.Rem(A.z, B.z)));
            }

            public static VectorB4 ElRem(this VectorB4 A, VectorB4 B)
            {
                return OHV.MkVectorB4(
                    (Byte)(Arith.Rem(A.x, B.x)),
                    (Byte)(Arith.Rem(A.y, B.y)),
                    (Byte)(Arith.Rem(A.z, B.z)),
                    (Byte)(Arith.Rem(A.w, B.w)));
            }

            // Elementwise multiplication/division/remainder by 2^B_i
            public static VectorI2 ElPow2CeilDiv(this VectorI2 A, VectorI2 B)
            {
                return OHV.MkVectorI2(
                    (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                    (Int32)(Arith.Pow2CeilDiv(A.y, B.y)));
            }

            public static VectorI3 ElPow2CeilDiv(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                    (Int32)(Arith.Pow2CeilDiv(A.y, B.y)),
                    (Int32)(Arith.Pow2CeilDiv(A.z, B.z)));
            }

            public static VectorI4 ElPow2CeilDiv(this VectorI4 A, VectorI4 B)
            {
                return OHV.MkVectorI4(
                    (Int32)(Arith.Pow2CeilDiv(A.x, B.x)),
                    (Int32)(Arith.Pow2CeilDiv(A.y, B.y)),
                    (Int32)(Arith.Pow2CeilDiv(A.z, B.z)),
                    (Int32)(Arith.Pow2CeilDiv(A.w, B.w)));
            }

            public static VectorB2 ElPow2CeilDiv(this VectorB2 A, VectorB2 B)
            {
                return OHV.MkVectorB2(
                    (Byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                    (Byte)(Arith.Pow2CeilDiv(A.y, B.y)));
            }

            public static VectorB3 ElPow2CeilDiv(this VectorB3 A, VectorB3 B)
            {
                return OHV.MkVectorB3(
                    (Byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                    (Byte)(Arith.Pow2CeilDiv(A.y, B.y)),
                    (Byte)(Arith.Pow2CeilDiv(A.z, B.z)));
            }

            public static VectorB4 ElPow2CeilDiv(this VectorB4 A, VectorB4 B)
            {
                return OHV.MkVectorB4(
                    (Byte)(Arith.Pow2CeilDiv(A.x, B.x)),
                    (Byte)(Arith.Pow2CeilDiv(A.y, B.y)),
                    (Byte)(Arith.Pow2CeilDiv(A.z, B.z)),
                    (Byte)(Arith.Pow2CeilDiv(A.w, B.w)));
            }

            public static VectorI2 ElPow2Div(this VectorI2 A, VectorI2 B)
            {
                return OHV.MkVectorI2(
                    (Int32)(Arith.Pow2Div(A.x, B.x)),
                    (Int32)(Arith.Pow2Div(A.y, B.y)));
            }

            public static VectorI3 ElPow2Div(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (Int32)(Arith.Pow2Div(A.x, B.x)),
                    (Int32)(Arith.Pow2Div(A.y, B.y)),
                    (Int32)(Arith.Pow2Div(A.z, B.z)));
            }

            public static VectorI4 ElPow2Div(this VectorI4 A, VectorI4 B)
            {
                return OHV.MkVectorI4(
                    (Int32)(Arith.Pow2Div(A.x, B.x)),
                    (Int32)(Arith.Pow2Div(A.y, B.y)),
                    (Int32)(Arith.Pow2Div(A.z, B.z)),
                    (Int32)(Arith.Pow2Div(A.w, B.w)));
            }

            public static VectorB2 ElPow2Div(this VectorB2 A, VectorB2 B)
            {
                return OHV.MkVectorB2(
                    (Byte)(Arith.Pow2Div(A.x, B.x)),
                    (Byte)(Arith.Pow2Div(A.y, B.y)));
            }

            public static VectorB3 ElPow2Div(this VectorB3 A, VectorB3 B)
            {
                return OHV.MkVectorB3(
                    (Byte)(Arith.Pow2Div(A.x, B.x)),
                    (Byte)(Arith.Pow2Div(A.y, B.y)),
                    (Byte)(Arith.Pow2Div(A.z, B.z)));
            }

            public static VectorB4 ElPow2Div(this VectorB4 A, VectorB4 B)
            {
                return OHV.MkVectorB4(
                    (Byte)(Arith.Pow2Div(A.x, B.x)),
                    (Byte)(Arith.Pow2Div(A.y, B.y)),
                    (Byte)(Arith.Pow2Div(A.z, B.z)),
                    (Byte)(Arith.Pow2Div(A.w, B.w)));
            }

            public static VectorI2 ElPow2Mult(this VectorI2 A, VectorI2 B)
            {
                return OHV.MkVectorI2(
                    (Int32)(Arith.Pow2Mult(A.x, B.x)),
                    (Int32)(Arith.Pow2Mult(A.y, B.y)));
            }

            public static VectorI3 ElPow2Mult(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (Int32)(Arith.Pow2Mult(A.x, B.x)),
                    (Int32)(Arith.Pow2Mult(A.y, B.y)),
                    (Int32)(Arith.Pow2Mult(A.z, B.z)));
            }

            public static VectorI4 ElPow2Mult(this VectorI4 A, VectorI4 B)
            {
                return OHV.MkVectorI4(
                    (Int32)(Arith.Pow2Mult(A.x, B.x)),
                    (Int32)(Arith.Pow2Mult(A.y, B.y)),
                    (Int32)(Arith.Pow2Mult(A.z, B.z)),
                    (Int32)(Arith.Pow2Mult(A.w, B.w)));
            }

            public static VectorB2 ElPow2Mult(this VectorB2 A, VectorB2 B)
            {
                return OHV.MkVectorB2(
                    (Byte)(Arith.Pow2Mult(A.x, B.x)),
                    (Byte)(Arith.Pow2Mult(A.y, B.y)));
            }

            public static VectorB3 ElPow2Mult(this VectorB3 A, VectorB3 B)
            {
                return OHV.MkVectorB3(
                    (Byte)(Arith.Pow2Mult(A.x, B.x)),
                    (Byte)(Arith.Pow2Mult(A.y, B.y)),
                    (Byte)(Arith.Pow2Mult(A.z, B.z)));
            }

            public static VectorB4 ElPow2Mult(this VectorB4 A, VectorB4 B)
            {
                return OHV.MkVectorB4(
                    (Byte)(Arith.Pow2Mult(A.x, B.x)),
                    (Byte)(Arith.Pow2Mult(A.y, B.y)),
                    (Byte)(Arith.Pow2Mult(A.z, B.z)),
                    (Byte)(Arith.Pow2Mult(A.w, B.w)));
            }

            public static VectorI2 ElPow2Rem(this VectorI2 A, VectorI2 B)
            {
                return OHV.MkVectorI2(
                    (Int32)(Arith.Pow2Rem(A.x, B.x)),
                    (Int32)(Arith.Pow2Rem(A.y, B.y)));
            }

            public static VectorI3 ElPow2Rem(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (Int32)(Arith.Pow2Rem(A.x, B.x)),
                    (Int32)(Arith.Pow2Rem(A.y, B.y)),
                    (Int32)(Arith.Pow2Rem(A.z, B.z)));
            }

            public static VectorI4 ElPow2Rem(this VectorI4 A, VectorI4 B)
            {
                return OHV.MkVectorI4(
                    (Int32)(Arith.Pow2Rem(A.x, B.x)),
                    (Int32)(Arith.Pow2Rem(A.y, B.y)),
                    (Int32)(Arith.Pow2Rem(A.z, B.z)),
                    (Int32)(Arith.Pow2Rem(A.w, B.w)));
            }

            public static VectorB2 ElPow2Rem(this VectorB2 A, VectorB2 B)
            {
                return OHV.MkVectorB2(
                    (Byte)(Arith.Pow2Rem(A.x, B.x)),
                    (Byte)(Arith.Pow2Rem(A.y, B.y)));
            }

            public static VectorB3 ElPow2Rem(this VectorB3 A, VectorB3 B)
            {
                return OHV.MkVectorB3(
                    (Byte)(Arith.Pow2Rem(A.x, B.x)),
                    (Byte)(Arith.Pow2Rem(A.y, B.y)),
                    (Byte)(Arith.Pow2Rem(A.z, B.z)));
            }

            public static VectorB4 ElPow2Rem(this VectorB4 A, VectorB4 B)
            {
                return OHV.MkVectorB4(
                    (Byte)(Arith.Pow2Rem(A.x, B.x)),
                    (Byte)(Arith.Pow2Rem(A.y, B.y)),
                    (Byte)(Arith.Pow2Rem(A.z, B.z)),
                    (Byte)(Arith.Pow2Rem(A.w, B.w)));
            }

            // Dot product
            public static Int32 DotP(this VectorI2 A, VectorI2 B)
            {
                return (Int32)((A.x * B.x)
                    + (A.y * B.y));
            }

            public static Int32 DotP(this VectorI3 A, VectorI3 B)
            {
                return (Int32)((A.x * B.x)
                    + (A.y * B.y)
                    + (A.z * B.z));
            }

            public static Int32 DotP(this VectorI4 A, VectorI4 B)
            {
                return (Int32)((A.x * B.x)
                    + (A.y * B.y)
                    + (A.z * B.z)
                    + (A.w * B.w));
            }

            public static Byte DotP(this VectorB2 A, VectorB2 B)
            {
                return (Byte)((A.x * B.x)
                    + (A.y * B.y));
            }

            public static Int32 DotPI(this VectorB2 A, VectorB2 B)
            {
                return (Int32)((Int32)(A.x * B.x)
                    + (Int32)(A.y * B.y));
            }

            public static Byte DotP(this VectorB3 A, VectorB3 B)
            {
                return (Byte)((A.x * B.x)
                    + (A.y * B.y)
                    + (A.z * B.z));
            }

            public static Int32 DotPI(this VectorB3 A, VectorB3 B)
            {
                return (Int32)((Int32)(A.x * B.x)
                    + (Int32)(A.y * B.y)
                    + (Int32)(A.z * B.z));
            }

            public static Byte DotP(this VectorB4 A, VectorB4 B)
            {
                return (Byte)((A.x * B.x)
                    + (A.y * B.y)
                    + (A.z * B.z)
                    + (A.w * B.w));
            }

            public static Int32 DotPI(this VectorB4 A, VectorB4 B)
            {
                return (Int32)((Int32)(A.x * B.x)
                    + (Int32)(A.y * B.y)
                    + (Int32)(A.z * B.z)
                    + (Int32)(A.w * B.w));
            }

            public static Double DotP(this VectorD2 A, VectorD2 B)
            {
                return (Double)((A.x * B.x)
                    + (A.y * B.y));
            }

            public static Double DotP(this VectorD3 A, VectorD3 B)
            {
                return (Double)((A.x * B.x)
                    + (A.y * B.y)
                    + (A.z * B.z));
            }

            public static Double DotP(this VectorD4 A, VectorD4 B)
            {
                return (Double)((A.x * B.x)
                    + (A.y * B.y)
                    + (A.z * B.z)
                    + (A.w * B.w));
            }

            public static Single DotP(this Vector2 A, Vector2 B)
            {
                return (Single)((A.x * B.x)
                    + (A.y * B.y));
            }

            public static Double DotPD(this Vector2 A, Vector2 B)
            {
                return (Double)((Double)(A.x * B.x)
                    + (Double)(A.y * B.y));
            }

            public static Single DotP(this Vector3 A, Vector3 B)
            {
                return (Single)((A.x * B.x)
                    + (A.y * B.y)
                    + (A.z * B.z));
            }

            public static Double DotPD(this Vector3 A, Vector3 B)
            {
                return (Double)((Double)(A.x * B.x)
                    + (Double)(A.y * B.y)
                    + (Double)(A.z * B.z));
            }

            public static Single DotP(this Vector4 A, Vector4 B)
            {
                return (Single)((A.x * B.x)
                    + (A.y * B.y)
                    + (A.z * B.z)
                    + (A.w * B.w));
            }

            public static Double DotPD(this Vector4 A, Vector4 B)
            {
                return (Double)((Double)(A.x * B.x)
                    + (Double)(A.y * B.y)
                    + (Double)(A.z * B.z)
                    + (Double)(A.w * B.w));
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

            public static Byte SqLen(this VectorB2 V)
            {
                return DotP(V,V);
            }

            public static Int32 SqLenI(this VectorB2 V)
            {
                return DotPI(V,V);
            }

            public static Byte SqLen(this VectorB3 V)
            {
                return DotP(V,V);
            }

            public static Int32 SqLenI(this VectorB3 V)
            {
                return DotPI(V,V);
            }

            public static Byte SqLen(this VectorB4 V)
            {
                return DotP(V,V);
            }

            public static Int32 SqLenI(this VectorB4 V)
            {
                return DotPI(V,V);
            }

            public static Double SqLen(this VectorD2 V)
            {
                return DotP(V,V);
            }

            public static Double SqLen(this VectorD3 V)
            {
                return DotP(V,V);
            }

            public static Double SqLen(this VectorD4 V)
            {
                return DotP(V,V);
            }

            public static Single SqLen(this Vector2 V)
            {
                return DotP(V,V);
            }

            public static Double SqLenD(this Vector2 V)
            {
                return DotPD(V,V);
            }

            public static Single SqLen(this Vector3 V)
            {
                return DotP(V,V);
            }

            public static Double SqLenD(this Vector3 V)
            {
                return DotPD(V,V);
            }

            public static Single SqLen(this Vector4 V)
            {
                return DotP(V,V);
            }

            public static Double SqLenD(this Vector4 V)
            {
                return DotPD(V,V);
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

            public static Byte ManhatLength(this VectorB2 V)
            {
                return (Byte)(V.x + V.y);
            }

            public static Byte ManhatLength(this VectorB3 V)
            {
                return (Byte)(V.x + V.y + V.z);
            }

            public static Byte ManhatLength(this VectorB4 V)
            {
                return (Byte)(V.x + V.y + V.z + V.w);
            }

            public static Double ManhatLength(this VectorD2 V)
            {
                return (Double)(V.x + V.y);
            }

            public static Double ManhatLength(this VectorD3 V)
            {
                return (Double)(V.x + V.y + V.z);
            }

            public static Double ManhatLength(this VectorD4 V)
            {
                return (Double)(V.x + V.y + V.z + V.w);
            }

            public static Single ManhatLength(this Vector2 V)
            {
                return (Single)(V.x + V.y);
            }

            public static Single ManhatLength(this Vector3 V)
            {
                return (Single)(V.x + V.y + V.z);
            }

            public static Single ManhatLength(this Vector4 V)
            {
                return (Single)(V.x + V.y + V.z + V.w);
            }

            // Vector length (as in, euclidean)
            public static Double Len(this VectorD2 V)
            {
                return Arith.Sqrt(SqLen(V));
            }

            public static Double Len(this VectorD3 V)
            {
                return Arith.Sqrt(SqLen(V));
            }

            public static Double Len(this VectorD4 V)
            {
                return Arith.Sqrt(SqLen(V));
            }

            public static Single Len(this Vector2 V)
            {
                return Arith.Sqrt(SqLen(V));
            }

            public static Single Len(this Vector3 V)
            {
                return Arith.Sqrt(SqLen(V));
            }

            public static Single Len(this Vector4 V)
            {
                return Arith.Sqrt(SqLen(V));
            }

            // Normalized vector
            public static VectorD2 Norm(this VectorD2 V)
            {
                return V/Len(V);
            }

            public static VectorD3 Norm(this VectorD3 V)
            {
                return V/Len(V);
            }

            public static VectorD4 Norm(this VectorD4 V)
            {
                return V/Len(V);
            }

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

            public static Byte Volume(this VectorB2 V)
            {
                return (Byte)(V.x * V.y);
            }

            public static Int32 VolumeI(this VectorB2 V)
            {
                return (Int32)(V.x * V.y);
            }

            public static Byte Volume(this VectorB3 V)
            {
                return (Byte)(V.x * V.y * V.z);
            }

            public static Int32 VolumeI(this VectorB3 V)
            {
                return (Int32)(V.x * V.y * V.z);
            }

            public static Byte Volume(this VectorB4 V)
            {
                return (Byte)(V.x * V.y * V.z * V.w);
            }

            public static Int32 VolumeI(this VectorB4 V)
            {
                return (Int32)(V.x * V.y * V.z * V.w);
            }

            public static Double Volume(this VectorD2 V)
            {
                return (Double)(V.x * V.y);
            }

            public static Double Volume(this VectorD3 V)
            {
                return (Double)(V.x * V.y * V.z);
            }

            public static Double Volume(this VectorD4 V)
            {
                return (Double)(V.x * V.y * V.z * V.w);
            }

            public static Single Volume(this Vector2 V)
            {
                return (Single)(V.x * V.y);
            }

            public static Double VolumeD(this Vector2 V)
            {
                return (Double)(V.x * V.y);
            }

            public static Single Volume(this Vector3 V)
            {
                return (Single)(V.x * V.y * V.z);
            }

            public static Double VolumeD(this Vector3 V)
            {
                return (Double)(V.x * V.y * V.z);
            }

            public static Single Volume(this Vector4 V)
            {
                return (Single)(V.x * V.y * V.z * V.w);
            }

            public static Double VolumeD(this Vector4 V)
            {
                return (Double)(V.x * V.y * V.z * V.w);
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

            public static Byte Pow2Volume(this VectorB2 V)
            {
                return Arith.Pow2Mult((Byte)1, (Byte)(V.x + V.y));
            }

            public static Int32 Pow2VolumeI(this VectorB2 V)
            {
                return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y));
            }

            public static Byte Pow2Volume(this VectorB3 V)
            {
                return Arith.Pow2Mult((Byte)1, (Byte)(V.x + V.y + V.z));
            }

            public static Int32 Pow2VolumeI(this VectorB3 V)
            {
                return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z));
            }

            public static Byte Pow2Volume(this VectorB4 V)
            {
                return Arith.Pow2Mult((Byte)1, (Byte)(V.x + V.y + V.z + V.w));
            }

            public static Int32 Pow2VolumeI(this VectorB4 V)
            {
                return Arith.Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z + V.w));
            }

            // Cross product
            public static VectorI3 CrossP(this VectorI3 A, VectorI3 B)
            {
                return OHV.MkVectorI3(
                    (A.y * B.z) - (A.z * B.y),
                    -(A.x * B.z) + (A.z * B.x),
                    (A.x * B.y) - (A.y * B.x));
            }

            public static VectorD3 CrossP(this VectorD3 A, VectorD3 B)
            {
                return OHV.MkVectorD3(
                    (A.y * B.z) - (A.z * B.y),
                    -(A.x * B.z) + (A.z * B.x),
                    (A.x * B.y) - (A.y * B.x));
            }

            public static Vector3 CrossP(this Vector3 A, Vector3 B)
            {
                return OHV.MkVector3(
                    (A.y * B.z) - (A.z * B.y),
                    -(A.x * B.z) + (A.z * B.x),
                    (A.x * B.y) - (A.y * B.x));
            }

            // Some C#-specific functions
            public static VectorI2 Select(this VectorI2 V, Func<Int32, Int32> func)
            {
                return OHV.MkVectorI2(
                    (Int32)(func(V.x)),
                    (Int32)(func(V.y)));
            }

            public static VectorI3 Select(this VectorI3 V, Func<Int32, Int32> func)
            {
                return OHV.MkVectorI3(
                    (Int32)(func(V.x)),
                    (Int32)(func(V.y)),
                    (Int32)(func(V.z)));
            }

            public static VectorI4 Select(this VectorI4 V, Func<Int32, Int32> func)
            {
                return OHV.MkVectorI4(
                    (Int32)(func(V.x)),
                    (Int32)(func(V.y)),
                    (Int32)(func(V.z)),
                    (Int32)(func(V.w)));
            }

            public static VectorB2 Select(this VectorB2 V, Func<Byte, Byte> func)
            {
                return OHV.MkVectorB2(
                    (Byte)(func(V.x)),
                    (Byte)(func(V.y)));
            }

            public static VectorB3 Select(this VectorB3 V, Func<Byte, Byte> func)
            {
                return OHV.MkVectorB3(
                    (Byte)(func(V.x)),
                    (Byte)(func(V.y)),
                    (Byte)(func(V.z)));
            }

            public static VectorB4 Select(this VectorB4 V, Func<Byte, Byte> func)
            {
                return OHV.MkVectorB4(
                    (Byte)(func(V.x)),
                    (Byte)(func(V.y)),
                    (Byte)(func(V.z)),
                    (Byte)(func(V.w)));
            }

            public static VectorD2 Select(this VectorD2 V, Func<Double, Double> func)
            {
                return OHV.MkVectorD2(
                    (Double)(func(V.x)),
                    (Double)(func(V.y)));
            }

            public static VectorD3 Select(this VectorD3 V, Func<Double, Double> func)
            {
                return OHV.MkVectorD3(
                    (Double)(func(V.x)),
                    (Double)(func(V.y)),
                    (Double)(func(V.z)));
            }

            public static VectorD4 Select(this VectorD4 V, Func<Double, Double> func)
            {
                return OHV.MkVectorD4(
                    (Double)(func(V.x)),
                    (Double)(func(V.y)),
                    (Double)(func(V.z)),
                    (Double)(func(V.w)));
            }

            public static Vector2 Select(this Vector2 V, Func<Single, Single> func)
            {
                return OHV.MkVector2(
                    (Single)(func(V.x)),
                    (Single)(func(V.y)));
            }

            public static Vector3 Select(this Vector3 V, Func<Single, Single> func)
            {
                return OHV.MkVector3(
                    (Single)(func(V.x)),
                    (Single)(func(V.y)),
                    (Single)(func(V.z)));
            }

            public static Vector4 Select(this Vector4 V, Func<Single, Single> func)
            {
                return OHV.MkVector4(
                    (Single)(func(V.x)),
                    (Single)(func(V.y)),
                    (Single)(func(V.z)),
                    (Single)(func(V.w)));
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

            public static Byte[] Members(this VectorB2 V)
            {
                return new[] { V.x, V.y };
            }

            public static Byte[] Members(this VectorB3 V)
            {
                return new[] { V.x, V.y, V.z };
            }

            public static Byte[] Members(this VectorB4 V)
            {
                return new[] { V.x, V.y, V.z, V.w };
            }

            public static Double[] Members(this VectorD2 V)
            {
                return new[] { V.x, V.y };
            }

            public static Double[] Members(this VectorD3 V)
            {
                return new[] { V.x, V.y, V.z };
            }

            public static Double[] Members(this VectorD4 V)
            {
                return new[] { V.x, V.y, V.z, V.w };
            }

            public static Single[] Members(this Vector2 V)
            {
                return new[] { V.x, V.y };
            }

            public static Single[] Members(this Vector3 V)
            {
                return new[] { V.x, V.y, V.z };
            }

            public static Single[] Members(this Vector4 V)
            {
                return new[] { V.x, V.y, V.z, V.w };
            }

            public static VectorI2 ToVectorI2(this System.Collections.Generic.IEnumerable<Int32> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
                return OHV.MkVectorI2(array[0], array[1]);
            }

            public static VectorI3 ToVectorI3(this System.Collections.Generic.IEnumerable<Int32> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
                return OHV.MkVectorI3(array[0], array[1], array[2]);
            }

            public static VectorI4 ToVectorI4(this System.Collections.Generic.IEnumerable<Int32> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
                return OHV.MkVectorI4(array[0], array[1], array[2], array[3]);
            }

            public static VectorB2 ToVectorB2(this System.Collections.Generic.IEnumerable<Byte> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
                return OHV.MkVectorB2(array[0], array[1]);
            }

            public static VectorB3 ToVectorB3(this System.Collections.Generic.IEnumerable<Byte> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
                return OHV.MkVectorB3(array[0], array[1], array[2]);
            }

            public static VectorB4 ToVectorB4(this System.Collections.Generic.IEnumerable<Byte> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
                return OHV.MkVectorB4(array[0], array[1], array[2], array[3]);
            }

            public static VectorD2 ToVectorD2(this System.Collections.Generic.IEnumerable<Double> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
                return OHV.MkVectorD2(array[0], array[1]);
            }

            public static VectorD3 ToVectorD3(this System.Collections.Generic.IEnumerable<Double> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
                return OHV.MkVectorD3(array[0], array[1], array[2]);
            }

            public static VectorD4 ToVectorD4(this System.Collections.Generic.IEnumerable<Double> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
                return OHV.MkVectorD4(array[0], array[1], array[2], array[3]);
            }

            public static Vector2 ToVector2(this System.Collections.Generic.IEnumerable<Single> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 2));
                return OHV.MkVector2(array[0], array[1]);
            }

            public static Vector3 ToVector3(this System.Collections.Generic.IEnumerable<Single> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 3));
                return OHV.MkVector3(array[0], array[1], array[2]);
            }

            public static Vector4 ToVector4(this System.Collections.Generic.IEnumerable<Single> list)
            {
                var array = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Take(list, 4));
                return OHV.MkVector4(array[0], array[1], array[2], array[3]);
            }

        }
    }
}