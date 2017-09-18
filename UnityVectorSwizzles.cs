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
        public static VectorI2 XX(VectorI2 V){ return VecOps.MkVectorI2(V.x, V.x); }
        public static VectorI2 XY(VectorI2 V){ return VecOps.MkVectorI2(V.x, V.y); }
        public static VectorI2 X_(VectorI2 V){ return VecOps.MkVectorI2(V.x, 0); }
        public static VectorI2 YX(VectorI2 V){ return VecOps.MkVectorI2(V.y, V.x); }
        public static VectorI2 YY(VectorI2 V){ return VecOps.MkVectorI2(V.y, V.y); }
        public static VectorI2 Y_(VectorI2 V){ return VecOps.MkVectorI2(V.y, 0); }
        public static VectorI2 _X(VectorI2 V){ return VecOps.MkVectorI2(0, V.x); }
        public static VectorI2 _Y(VectorI2 V){ return VecOps.MkVectorI2(0, V.y); }
        public static VectorI3 XXX(VectorI2 V){ return VecOps.MkVectorI3(V.x, V.x, V.x); }
        public static VectorI3 XXY(VectorI2 V){ return VecOps.MkVectorI3(V.x, V.x, V.y); }
        public static VectorI3 XX_(VectorI2 V){ return VecOps.MkVectorI3(V.x, V.x, 0); }
        public static VectorI3 XYX(VectorI2 V){ return VecOps.MkVectorI3(V.x, V.y, V.x); }
        public static VectorI3 XYY(VectorI2 V){ return VecOps.MkVectorI3(V.x, V.y, V.y); }
        public static VectorI3 XY_(VectorI2 V){ return VecOps.MkVectorI3(V.x, V.y, 0); }
        public static VectorI3 X_X(VectorI2 V){ return VecOps.MkVectorI3(V.x, 0, V.x); }
        public static VectorI3 X_Y(VectorI2 V){ return VecOps.MkVectorI3(V.x, 0, V.y); }
        public static VectorI3 X__(VectorI2 V){ return VecOps.MkVectorI3(V.x, 0, 0); }
        public static VectorI3 YXX(VectorI2 V){ return VecOps.MkVectorI3(V.y, V.x, V.x); }
        public static VectorI3 YXY(VectorI2 V){ return VecOps.MkVectorI3(V.y, V.x, V.y); }
        public static VectorI3 YX_(VectorI2 V){ return VecOps.MkVectorI3(V.y, V.x, 0); }
        public static VectorI3 YYX(VectorI2 V){ return VecOps.MkVectorI3(V.y, V.y, V.x); }
        public static VectorI3 YYY(VectorI2 V){ return VecOps.MkVectorI3(V.y, V.y, V.y); }
        public static VectorI3 YY_(VectorI2 V){ return VecOps.MkVectorI3(V.y, V.y, 0); }
        public static VectorI3 Y_X(VectorI2 V){ return VecOps.MkVectorI3(V.y, 0, V.x); }
        public static VectorI3 Y_Y(VectorI2 V){ return VecOps.MkVectorI3(V.y, 0, V.y); }
        public static VectorI3 Y__(VectorI2 V){ return VecOps.MkVectorI3(V.y, 0, 0); }
        public static VectorI3 _XX(VectorI2 V){ return VecOps.MkVectorI3(0, V.x, V.x); }
        public static VectorI3 _XY(VectorI2 V){ return VecOps.MkVectorI3(0, V.x, V.y); }
        public static VectorI3 _X_(VectorI2 V){ return VecOps.MkVectorI3(0, V.x, 0); }
        public static VectorI3 _YX(VectorI2 V){ return VecOps.MkVectorI3(0, V.y, V.x); }
        public static VectorI3 _YY(VectorI2 V){ return VecOps.MkVectorI3(0, V.y, V.y); }
        public static VectorI3 _Y_(VectorI2 V){ return VecOps.MkVectorI3(0, V.y, 0); }
        public static VectorI3 __X(VectorI2 V){ return VecOps.MkVectorI3(0, 0, V.x); }
        public static VectorI3 __Y(VectorI2 V){ return VecOps.MkVectorI3(0, 0, V.y); }
        public static VectorI4 XXXX(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.x); }
        public static VectorI4 XXXY(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.y); }
        public static VectorI4 XXX_(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, 0); }
        public static VectorI4 XXYX(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.x); }
        public static VectorI4 XXYY(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.y); }
        public static VectorI4 XXY_(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, 0); }
        public static VectorI4 XX_X(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.x); }
        public static VectorI4 XX_Y(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.y); }
        public static VectorI4 XX__(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, 0, 0); }
        public static VectorI4 XYXX(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.x); }
        public static VectorI4 XYXY(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.y); }
        public static VectorI4 XYX_(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, 0); }
        public static VectorI4 XYYX(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.x); }
        public static VectorI4 XYYY(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.y); }
        public static VectorI4 XYY_(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, 0); }
        public static VectorI4 XY_X(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.x); }
        public static VectorI4 XY_Y(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.y); }
        public static VectorI4 XY__(VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, 0, 0); }
        public static VectorI4 X_XX(VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.x); }
        public static VectorI4 X_XY(VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.y); }
        public static VectorI4 X_X_(VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.x, 0); }
        public static VectorI4 X_YX(VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.x); }
        public static VectorI4 X_YY(VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.y); }
        public static VectorI4 X_Y_(VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.y, 0); }
        public static VectorI4 X__X(VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.x); }
        public static VectorI4 X__Y(VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.y); }
        public static VectorI4 X___(VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, 0, 0); }
        public static VectorI4 YXXX(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.x); }
        public static VectorI4 YXXY(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.y); }
        public static VectorI4 YXX_(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, 0); }
        public static VectorI4 YXYX(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.x); }
        public static VectorI4 YXYY(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.y); }
        public static VectorI4 YXY_(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, 0); }
        public static VectorI4 YX_X(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.x); }
        public static VectorI4 YX_Y(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.y); }
        public static VectorI4 YX__(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, 0, 0); }
        public static VectorI4 YYXX(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.x); }
        public static VectorI4 YYXY(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.y); }
        public static VectorI4 YYX_(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, 0); }
        public static VectorI4 YYYX(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.x); }
        public static VectorI4 YYYY(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.y); }
        public static VectorI4 YYY_(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, 0); }
        public static VectorI4 YY_X(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.x); }
        public static VectorI4 YY_Y(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.y); }
        public static VectorI4 YY__(VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, 0, 0); }
        public static VectorI4 Y_XX(VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.x); }
        public static VectorI4 Y_XY(VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.y); }
        public static VectorI4 Y_X_(VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.x, 0); }
        public static VectorI4 Y_YX(VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.x); }
        public static VectorI4 Y_YY(VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.y); }
        public static VectorI4 Y_Y_(VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.y, 0); }
        public static VectorI4 Y__X(VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.x); }
        public static VectorI4 Y__Y(VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.y); }
        public static VectorI4 Y___(VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, 0, 0); }
        public static VectorI4 _XXX(VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.x); }
        public static VectorI4 _XXY(VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.y); }
        public static VectorI4 _XX_(VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.x, 0); }
        public static VectorI4 _XYX(VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.x); }
        public static VectorI4 _XYY(VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.y); }
        public static VectorI4 _XY_(VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.y, 0); }
        public static VectorI4 _X_X(VectorI2 V){ return VecOps.MkVectorI4(0, V.x, 0, V.x); }
        public static VectorI4 _X_Y(VectorI2 V){ return VecOps.MkVectorI4(0, V.x, 0, V.y); }
        public static VectorI4 _X__(VectorI2 V){ return VecOps.MkVectorI4(0, V.x, 0, 0); }
        public static VectorI4 _YXX(VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.x); }
        public static VectorI4 _YXY(VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.y); }
        public static VectorI4 _YX_(VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.x, 0); }
        public static VectorI4 _YYX(VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.x); }
        public static VectorI4 _YYY(VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.y); }
        public static VectorI4 _YY_(VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.y, 0); }
        public static VectorI4 _Y_X(VectorI2 V){ return VecOps.MkVectorI4(0, V.y, 0, V.x); }
        public static VectorI4 _Y_Y(VectorI2 V){ return VecOps.MkVectorI4(0, V.y, 0, V.y); }
        public static VectorI4 _Y__(VectorI2 V){ return VecOps.MkVectorI4(0, V.y, 0, 0); }
        public static VectorI4 __XX(VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.x, V.x); }
        public static VectorI4 __XY(VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.x, V.y); }
        public static VectorI4 __X_(VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.x, 0); }
        public static VectorI4 __YX(VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.y, V.x); }
        public static VectorI4 __YY(VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.y, V.y); }
        public static VectorI4 __Y_(VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.y, 0); }
        public static VectorI4 ___X(VectorI2 V){ return VecOps.MkVectorI4(0, 0, 0, V.x); }
        public static VectorI4 ___Y(VectorI2 V){ return VecOps.MkVectorI4(0, 0, 0, V.y); }
        public static VectorI2 XX(VectorI3 V){ return VecOps.MkVectorI2(V.x, V.x); }
        public static VectorI2 XY(VectorI3 V){ return VecOps.MkVectorI2(V.x, V.y); }
        public static VectorI2 XZ(VectorI3 V){ return VecOps.MkVectorI2(V.x, V.z); }
        public static VectorI2 X_(VectorI3 V){ return VecOps.MkVectorI2(V.x, 0); }
        public static VectorI2 YX(VectorI3 V){ return VecOps.MkVectorI2(V.y, V.x); }
        public static VectorI2 YY(VectorI3 V){ return VecOps.MkVectorI2(V.y, V.y); }
        public static VectorI2 YZ(VectorI3 V){ return VecOps.MkVectorI2(V.y, V.z); }
        public static VectorI2 Y_(VectorI3 V){ return VecOps.MkVectorI2(V.y, 0); }
        public static VectorI2 ZX(VectorI3 V){ return VecOps.MkVectorI2(V.z, V.x); }
        public static VectorI2 ZY(VectorI3 V){ return VecOps.MkVectorI2(V.z, V.y); }
        public static VectorI2 ZZ(VectorI3 V){ return VecOps.MkVectorI2(V.z, V.z); }
        public static VectorI2 Z_(VectorI3 V){ return VecOps.MkVectorI2(V.z, 0); }
        public static VectorI2 _X(VectorI3 V){ return VecOps.MkVectorI2(0, V.x); }
        public static VectorI2 _Y(VectorI3 V){ return VecOps.MkVectorI2(0, V.y); }
        public static VectorI2 _Z(VectorI3 V){ return VecOps.MkVectorI2(0, V.z); }
        public static VectorI3 XXX(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.x, V.x); }
        public static VectorI3 XXY(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.x, V.y); }
        public static VectorI3 XXZ(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.x, V.z); }
        public static VectorI3 XX_(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.x, 0); }
        public static VectorI3 XYX(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.y, V.x); }
        public static VectorI3 XYY(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.y, V.y); }
        public static VectorI3 XYZ(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.y, V.z); }
        public static VectorI3 XY_(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.y, 0); }
        public static VectorI3 XZX(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.z, V.x); }
        public static VectorI3 XZY(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.z, V.y); }
        public static VectorI3 XZZ(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.z, V.z); }
        public static VectorI3 XZ_(VectorI3 V){ return VecOps.MkVectorI3(V.x, V.z, 0); }
        public static VectorI3 X_X(VectorI3 V){ return VecOps.MkVectorI3(V.x, 0, V.x); }
        public static VectorI3 X_Y(VectorI3 V){ return VecOps.MkVectorI3(V.x, 0, V.y); }
        public static VectorI3 X_Z(VectorI3 V){ return VecOps.MkVectorI3(V.x, 0, V.z); }
        public static VectorI3 X__(VectorI3 V){ return VecOps.MkVectorI3(V.x, 0, 0); }
        public static VectorI3 YXX(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.x, V.x); }
        public static VectorI3 YXY(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.x, V.y); }
        public static VectorI3 YXZ(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.x, V.z); }
        public static VectorI3 YX_(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.x, 0); }
        public static VectorI3 YYX(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.y, V.x); }
        public static VectorI3 YYY(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.y, V.y); }
        public static VectorI3 YYZ(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.y, V.z); }
        public static VectorI3 YY_(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.y, 0); }
        public static VectorI3 YZX(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.z, V.x); }
        public static VectorI3 YZY(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.z, V.y); }
        public static VectorI3 YZZ(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.z, V.z); }
        public static VectorI3 YZ_(VectorI3 V){ return VecOps.MkVectorI3(V.y, V.z, 0); }
        public static VectorI3 Y_X(VectorI3 V){ return VecOps.MkVectorI3(V.y, 0, V.x); }
        public static VectorI3 Y_Y(VectorI3 V){ return VecOps.MkVectorI3(V.y, 0, V.y); }
        public static VectorI3 Y_Z(VectorI3 V){ return VecOps.MkVectorI3(V.y, 0, V.z); }
        public static VectorI3 Y__(VectorI3 V){ return VecOps.MkVectorI3(V.y, 0, 0); }
        public static VectorI3 ZXX(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.x, V.x); }
        public static VectorI3 ZXY(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.x, V.y); }
        public static VectorI3 ZXZ(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.x, V.z); }
        public static VectorI3 ZX_(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.x, 0); }
        public static VectorI3 ZYX(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.y, V.x); }
        public static VectorI3 ZYY(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.y, V.y); }
        public static VectorI3 ZYZ(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.y, V.z); }
        public static VectorI3 ZY_(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.y, 0); }
        public static VectorI3 ZZX(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.z, V.x); }
        public static VectorI3 ZZY(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.z, V.y); }
        public static VectorI3 ZZZ(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.z, V.z); }
        public static VectorI3 ZZ_(VectorI3 V){ return VecOps.MkVectorI3(V.z, V.z, 0); }
        public static VectorI3 Z_X(VectorI3 V){ return VecOps.MkVectorI3(V.z, 0, V.x); }
        public static VectorI3 Z_Y(VectorI3 V){ return VecOps.MkVectorI3(V.z, 0, V.y); }
        public static VectorI3 Z_Z(VectorI3 V){ return VecOps.MkVectorI3(V.z, 0, V.z); }
        public static VectorI3 Z__(VectorI3 V){ return VecOps.MkVectorI3(V.z, 0, 0); }
        public static VectorI3 _XX(VectorI3 V){ return VecOps.MkVectorI3(0, V.x, V.x); }
        public static VectorI3 _XY(VectorI3 V){ return VecOps.MkVectorI3(0, V.x, V.y); }
        public static VectorI3 _XZ(VectorI3 V){ return VecOps.MkVectorI3(0, V.x, V.z); }
        public static VectorI3 _X_(VectorI3 V){ return VecOps.MkVectorI3(0, V.x, 0); }
        public static VectorI3 _YX(VectorI3 V){ return VecOps.MkVectorI3(0, V.y, V.x); }
        public static VectorI3 _YY(VectorI3 V){ return VecOps.MkVectorI3(0, V.y, V.y); }
        public static VectorI3 _YZ(VectorI3 V){ return VecOps.MkVectorI3(0, V.y, V.z); }
        public static VectorI3 _Y_(VectorI3 V){ return VecOps.MkVectorI3(0, V.y, 0); }
        public static VectorI3 _ZX(VectorI3 V){ return VecOps.MkVectorI3(0, V.z, V.x); }
        public static VectorI3 _ZY(VectorI3 V){ return VecOps.MkVectorI3(0, V.z, V.y); }
        public static VectorI3 _ZZ(VectorI3 V){ return VecOps.MkVectorI3(0, V.z, V.z); }
        public static VectorI3 _Z_(VectorI3 V){ return VecOps.MkVectorI3(0, V.z, 0); }
        public static VectorI3 __X(VectorI3 V){ return VecOps.MkVectorI3(0, 0, V.x); }
        public static VectorI3 __Y(VectorI3 V){ return VecOps.MkVectorI3(0, 0, V.y); }
        public static VectorI3 __Z(VectorI3 V){ return VecOps.MkVectorI3(0, 0, V.z); }
        public static VectorI4 XXXX(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.x); }
        public static VectorI4 XXXY(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.y); }
        public static VectorI4 XXXZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.z); }
        public static VectorI4 XXX_(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, 0); }
        public static VectorI4 XXYX(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.x); }
        public static VectorI4 XXYY(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.y); }
        public static VectorI4 XXYZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.z); }
        public static VectorI4 XXY_(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, 0); }
        public static VectorI4 XXZX(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.x); }
        public static VectorI4 XXZY(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.y); }
        public static VectorI4 XXZZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.z); }
        public static VectorI4 XXZ_(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, 0); }
        public static VectorI4 XX_X(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.x); }
        public static VectorI4 XX_Y(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.y); }
        public static VectorI4 XX_Z(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.z); }
        public static VectorI4 XX__(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, 0, 0); }
        public static VectorI4 XYXX(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.x); }
        public static VectorI4 XYXY(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.y); }
        public static VectorI4 XYXZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.z); }
        public static VectorI4 XYX_(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, 0); }
        public static VectorI4 XYYX(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.x); }
        public static VectorI4 XYYY(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.y); }
        public static VectorI4 XYYZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.z); }
        public static VectorI4 XYY_(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, 0); }
        public static VectorI4 XYZX(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.x); }
        public static VectorI4 XYZY(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.y); }
        public static VectorI4 XYZZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.z); }
        public static VectorI4 XYZ_(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, 0); }
        public static VectorI4 XY_X(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.x); }
        public static VectorI4 XY_Y(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.y); }
        public static VectorI4 XY_Z(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.z); }
        public static VectorI4 XY__(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, 0, 0); }
        public static VectorI4 XZXX(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.x); }
        public static VectorI4 XZXY(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.y); }
        public static VectorI4 XZXZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.z); }
        public static VectorI4 XZX_(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, 0); }
        public static VectorI4 XZYX(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.x); }
        public static VectorI4 XZYY(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.y); }
        public static VectorI4 XZYZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.z); }
        public static VectorI4 XZY_(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, 0); }
        public static VectorI4 XZZX(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.x); }
        public static VectorI4 XZZY(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.y); }
        public static VectorI4 XZZZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.z); }
        public static VectorI4 XZZ_(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, 0); }
        public static VectorI4 XZ_X(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.x); }
        public static VectorI4 XZ_Y(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.y); }
        public static VectorI4 XZ_Z(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.z); }
        public static VectorI4 XZ__(VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, 0, 0); }
        public static VectorI4 X_XX(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.x); }
        public static VectorI4 X_XY(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.y); }
        public static VectorI4 X_XZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.z); }
        public static VectorI4 X_X_(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.x, 0); }
        public static VectorI4 X_YX(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.x); }
        public static VectorI4 X_YY(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.y); }
        public static VectorI4 X_YZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.z); }
        public static VectorI4 X_Y_(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.y, 0); }
        public static VectorI4 X_ZX(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.x); }
        public static VectorI4 X_ZY(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.y); }
        public static VectorI4 X_ZZ(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.z); }
        public static VectorI4 X_Z_(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.z, 0); }
        public static VectorI4 X__X(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.x); }
        public static VectorI4 X__Y(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.y); }
        public static VectorI4 X__Z(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.z); }
        public static VectorI4 X___(VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, 0, 0); }
        public static VectorI4 YXXX(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.x); }
        public static VectorI4 YXXY(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.y); }
        public static VectorI4 YXXZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.z); }
        public static VectorI4 YXX_(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, 0); }
        public static VectorI4 YXYX(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.x); }
        public static VectorI4 YXYY(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.y); }
        public static VectorI4 YXYZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.z); }
        public static VectorI4 YXY_(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, 0); }
        public static VectorI4 YXZX(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.x); }
        public static VectorI4 YXZY(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.y); }
        public static VectorI4 YXZZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.z); }
        public static VectorI4 YXZ_(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, 0); }
        public static VectorI4 YX_X(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.x); }
        public static VectorI4 YX_Y(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.y); }
        public static VectorI4 YX_Z(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.z); }
        public static VectorI4 YX__(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, 0, 0); }
        public static VectorI4 YYXX(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.x); }
        public static VectorI4 YYXY(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.y); }
        public static VectorI4 YYXZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.z); }
        public static VectorI4 YYX_(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, 0); }
        public static VectorI4 YYYX(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.x); }
        public static VectorI4 YYYY(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.y); }
        public static VectorI4 YYYZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.z); }
        public static VectorI4 YYY_(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, 0); }
        public static VectorI4 YYZX(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.x); }
        public static VectorI4 YYZY(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.y); }
        public static VectorI4 YYZZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.z); }
        public static VectorI4 YYZ_(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, 0); }
        public static VectorI4 YY_X(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.x); }
        public static VectorI4 YY_Y(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.y); }
        public static VectorI4 YY_Z(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.z); }
        public static VectorI4 YY__(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, 0, 0); }
        public static VectorI4 YZXX(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.x); }
        public static VectorI4 YZXY(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.y); }
        public static VectorI4 YZXZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.z); }
        public static VectorI4 YZX_(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, 0); }
        public static VectorI4 YZYX(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.x); }
        public static VectorI4 YZYY(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.y); }
        public static VectorI4 YZYZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.z); }
        public static VectorI4 YZY_(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, 0); }
        public static VectorI4 YZZX(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.x); }
        public static VectorI4 YZZY(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.y); }
        public static VectorI4 YZZZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.z); }
        public static VectorI4 YZZ_(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, 0); }
        public static VectorI4 YZ_X(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.x); }
        public static VectorI4 YZ_Y(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.y); }
        public static VectorI4 YZ_Z(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.z); }
        public static VectorI4 YZ__(VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, 0, 0); }
        public static VectorI4 Y_XX(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.x); }
        public static VectorI4 Y_XY(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.y); }
        public static VectorI4 Y_XZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.z); }
        public static VectorI4 Y_X_(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.x, 0); }
        public static VectorI4 Y_YX(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.x); }
        public static VectorI4 Y_YY(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.y); }
        public static VectorI4 Y_YZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.z); }
        public static VectorI4 Y_Y_(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.y, 0); }
        public static VectorI4 Y_ZX(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.x); }
        public static VectorI4 Y_ZY(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.y); }
        public static VectorI4 Y_ZZ(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.z); }
        public static VectorI4 Y_Z_(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.z, 0); }
        public static VectorI4 Y__X(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.x); }
        public static VectorI4 Y__Y(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.y); }
        public static VectorI4 Y__Z(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.z); }
        public static VectorI4 Y___(VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, 0, 0); }
        public static VectorI4 ZXXX(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.x); }
        public static VectorI4 ZXXY(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.y); }
        public static VectorI4 ZXXZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.z); }
        public static VectorI4 ZXX_(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, 0); }
        public static VectorI4 ZXYX(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.x); }
        public static VectorI4 ZXYY(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.y); }
        public static VectorI4 ZXYZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.z); }
        public static VectorI4 ZXY_(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, 0); }
        public static VectorI4 ZXZX(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.x); }
        public static VectorI4 ZXZY(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.y); }
        public static VectorI4 ZXZZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.z); }
        public static VectorI4 ZXZ_(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, 0); }
        public static VectorI4 ZX_X(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.x); }
        public static VectorI4 ZX_Y(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.y); }
        public static VectorI4 ZX_Z(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.z); }
        public static VectorI4 ZX__(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, 0, 0); }
        public static VectorI4 ZYXX(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.x); }
        public static VectorI4 ZYXY(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.y); }
        public static VectorI4 ZYXZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.z); }
        public static VectorI4 ZYX_(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, 0); }
        public static VectorI4 ZYYX(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.x); }
        public static VectorI4 ZYYY(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.y); }
        public static VectorI4 ZYYZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.z); }
        public static VectorI4 ZYY_(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, 0); }
        public static VectorI4 ZYZX(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.x); }
        public static VectorI4 ZYZY(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.y); }
        public static VectorI4 ZYZZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.z); }
        public static VectorI4 ZYZ_(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, 0); }
        public static VectorI4 ZY_X(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.x); }
        public static VectorI4 ZY_Y(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.y); }
        public static VectorI4 ZY_Z(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.z); }
        public static VectorI4 ZY__(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, 0, 0); }
        public static VectorI4 ZZXX(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.x); }
        public static VectorI4 ZZXY(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.y); }
        public static VectorI4 ZZXZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.z); }
        public static VectorI4 ZZX_(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, 0); }
        public static VectorI4 ZZYX(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.x); }
        public static VectorI4 ZZYY(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.y); }
        public static VectorI4 ZZYZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.z); }
        public static VectorI4 ZZY_(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, 0); }
        public static VectorI4 ZZZX(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.x); }
        public static VectorI4 ZZZY(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.y); }
        public static VectorI4 ZZZZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.z); }
        public static VectorI4 ZZZ_(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, 0); }
        public static VectorI4 ZZ_X(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.x); }
        public static VectorI4 ZZ_Y(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.y); }
        public static VectorI4 ZZ_Z(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.z); }
        public static VectorI4 ZZ__(VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, 0, 0); }
        public static VectorI4 Z_XX(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.x); }
        public static VectorI4 Z_XY(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.y); }
        public static VectorI4 Z_XZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.z); }
        public static VectorI4 Z_X_(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.x, 0); }
        public static VectorI4 Z_YX(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.x); }
        public static VectorI4 Z_YY(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.y); }
        public static VectorI4 Z_YZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.z); }
        public static VectorI4 Z_Y_(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.y, 0); }
        public static VectorI4 Z_ZX(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.x); }
        public static VectorI4 Z_ZY(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.y); }
        public static VectorI4 Z_ZZ(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.z); }
        public static VectorI4 Z_Z_(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.z, 0); }
        public static VectorI4 Z__X(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.x); }
        public static VectorI4 Z__Y(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.y); }
        public static VectorI4 Z__Z(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.z); }
        public static VectorI4 Z___(VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, 0, 0); }
        public static VectorI4 _XXX(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.x); }
        public static VectorI4 _XXY(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.y); }
        public static VectorI4 _XXZ(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.z); }
        public static VectorI4 _XX_(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.x, 0); }
        public static VectorI4 _XYX(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.x); }
        public static VectorI4 _XYY(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.y); }
        public static VectorI4 _XYZ(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.z); }
        public static VectorI4 _XY_(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.y, 0); }
        public static VectorI4 _XZX(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.x); }
        public static VectorI4 _XZY(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.y); }
        public static VectorI4 _XZZ(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.z); }
        public static VectorI4 _XZ_(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.z, 0); }
        public static VectorI4 _X_X(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, 0, V.x); }
        public static VectorI4 _X_Y(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, 0, V.y); }
        public static VectorI4 _X_Z(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, 0, V.z); }
        public static VectorI4 _X__(VectorI3 V){ return VecOps.MkVectorI4(0, V.x, 0, 0); }
        public static VectorI4 _YXX(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.x); }
        public static VectorI4 _YXY(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.y); }
        public static VectorI4 _YXZ(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.z); }
        public static VectorI4 _YX_(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.x, 0); }
        public static VectorI4 _YYX(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.x); }
        public static VectorI4 _YYY(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.y); }
        public static VectorI4 _YYZ(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.z); }
        public static VectorI4 _YY_(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.y, 0); }
        public static VectorI4 _YZX(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.x); }
        public static VectorI4 _YZY(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.y); }
        public static VectorI4 _YZZ(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.z); }
        public static VectorI4 _YZ_(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.z, 0); }
        public static VectorI4 _Y_X(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, 0, V.x); }
        public static VectorI4 _Y_Y(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, 0, V.y); }
        public static VectorI4 _Y_Z(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, 0, V.z); }
        public static VectorI4 _Y__(VectorI3 V){ return VecOps.MkVectorI4(0, V.y, 0, 0); }
        public static VectorI4 _ZXX(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.x); }
        public static VectorI4 _ZXY(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.y); }
        public static VectorI4 _ZXZ(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.z); }
        public static VectorI4 _ZX_(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.x, 0); }
        public static VectorI4 _ZYX(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.x); }
        public static VectorI4 _ZYY(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.y); }
        public static VectorI4 _ZYZ(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.z); }
        public static VectorI4 _ZY_(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.y, 0); }
        public static VectorI4 _ZZX(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.x); }
        public static VectorI4 _ZZY(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.y); }
        public static VectorI4 _ZZZ(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.z); }
        public static VectorI4 _ZZ_(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.z, 0); }
        public static VectorI4 _Z_X(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, 0, V.x); }
        public static VectorI4 _Z_Y(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, 0, V.y); }
        public static VectorI4 _Z_Z(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, 0, V.z); }
        public static VectorI4 _Z__(VectorI3 V){ return VecOps.MkVectorI4(0, V.z, 0, 0); }
        public static VectorI4 __XX(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.x, V.x); }
        public static VectorI4 __XY(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.x, V.y); }
        public static VectorI4 __XZ(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.x, V.z); }
        public static VectorI4 __X_(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.x, 0); }
        public static VectorI4 __YX(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.y, V.x); }
        public static VectorI4 __YY(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.y, V.y); }
        public static VectorI4 __YZ(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.y, V.z); }
        public static VectorI4 __Y_(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.y, 0); }
        public static VectorI4 __ZX(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.z, V.x); }
        public static VectorI4 __ZY(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.z, V.y); }
        public static VectorI4 __ZZ(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.z, V.z); }
        public static VectorI4 __Z_(VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.z, 0); }
        public static VectorI4 ___X(VectorI3 V){ return VecOps.MkVectorI4(0, 0, 0, V.x); }
        public static VectorI4 ___Y(VectorI3 V){ return VecOps.MkVectorI4(0, 0, 0, V.y); }
        public static VectorI4 ___Z(VectorI3 V){ return VecOps.MkVectorI4(0, 0, 0, V.z); }
        public static VectorI2 XX(VectorI4 V){ return VecOps.MkVectorI2(V.x, V.x); }
        public static VectorI2 XY(VectorI4 V){ return VecOps.MkVectorI2(V.x, V.y); }
        public static VectorI2 XZ(VectorI4 V){ return VecOps.MkVectorI2(V.x, V.z); }
        public static VectorI2 XW(VectorI4 V){ return VecOps.MkVectorI2(V.x, V.w); }
        public static VectorI2 X_(VectorI4 V){ return VecOps.MkVectorI2(V.x, 0); }
        public static VectorI2 YX(VectorI4 V){ return VecOps.MkVectorI2(V.y, V.x); }
        public static VectorI2 YY(VectorI4 V){ return VecOps.MkVectorI2(V.y, V.y); }
        public static VectorI2 YZ(VectorI4 V){ return VecOps.MkVectorI2(V.y, V.z); }
        public static VectorI2 YW(VectorI4 V){ return VecOps.MkVectorI2(V.y, V.w); }
        public static VectorI2 Y_(VectorI4 V){ return VecOps.MkVectorI2(V.y, 0); }
        public static VectorI2 ZX(VectorI4 V){ return VecOps.MkVectorI2(V.z, V.x); }
        public static VectorI2 ZY(VectorI4 V){ return VecOps.MkVectorI2(V.z, V.y); }
        public static VectorI2 ZZ(VectorI4 V){ return VecOps.MkVectorI2(V.z, V.z); }
        public static VectorI2 ZW(VectorI4 V){ return VecOps.MkVectorI2(V.z, V.w); }
        public static VectorI2 Z_(VectorI4 V){ return VecOps.MkVectorI2(V.z, 0); }
        public static VectorI2 WX(VectorI4 V){ return VecOps.MkVectorI2(V.w, V.x); }
        public static VectorI2 WY(VectorI4 V){ return VecOps.MkVectorI2(V.w, V.y); }
        public static VectorI2 WZ(VectorI4 V){ return VecOps.MkVectorI2(V.w, V.z); }
        public static VectorI2 WW(VectorI4 V){ return VecOps.MkVectorI2(V.w, V.w); }
        public static VectorI2 W_(VectorI4 V){ return VecOps.MkVectorI2(V.w, 0); }
        public static VectorI2 _X(VectorI4 V){ return VecOps.MkVectorI2(0, V.x); }
        public static VectorI2 _Y(VectorI4 V){ return VecOps.MkVectorI2(0, V.y); }
        public static VectorI2 _Z(VectorI4 V){ return VecOps.MkVectorI2(0, V.z); }
        public static VectorI2 _W(VectorI4 V){ return VecOps.MkVectorI2(0, V.w); }
        public static VectorI3 XXX(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.x, V.x); }
        public static VectorI3 XXY(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.x, V.y); }
        public static VectorI3 XXZ(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.x, V.z); }
        public static VectorI3 XXW(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.x, V.w); }
        public static VectorI3 XX_(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.x, 0); }
        public static VectorI3 XYX(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.y, V.x); }
        public static VectorI3 XYY(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.y, V.y); }
        public static VectorI3 XYZ(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.y, V.z); }
        public static VectorI3 XYW(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.y, V.w); }
        public static VectorI3 XY_(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.y, 0); }
        public static VectorI3 XZX(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.z, V.x); }
        public static VectorI3 XZY(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.z, V.y); }
        public static VectorI3 XZZ(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.z, V.z); }
        public static VectorI3 XZW(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.z, V.w); }
        public static VectorI3 XZ_(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.z, 0); }
        public static VectorI3 XWX(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.w, V.x); }
        public static VectorI3 XWY(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.w, V.y); }
        public static VectorI3 XWZ(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.w, V.z); }
        public static VectorI3 XWW(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.w, V.w); }
        public static VectorI3 XW_(VectorI4 V){ return VecOps.MkVectorI3(V.x, V.w, 0); }
        public static VectorI3 X_X(VectorI4 V){ return VecOps.MkVectorI3(V.x, 0, V.x); }
        public static VectorI3 X_Y(VectorI4 V){ return VecOps.MkVectorI3(V.x, 0, V.y); }
        public static VectorI3 X_Z(VectorI4 V){ return VecOps.MkVectorI3(V.x, 0, V.z); }
        public static VectorI3 X_W(VectorI4 V){ return VecOps.MkVectorI3(V.x, 0, V.w); }
        public static VectorI3 X__(VectorI4 V){ return VecOps.MkVectorI3(V.x, 0, 0); }
        public static VectorI3 YXX(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.x, V.x); }
        public static VectorI3 YXY(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.x, V.y); }
        public static VectorI3 YXZ(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.x, V.z); }
        public static VectorI3 YXW(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.x, V.w); }
        public static VectorI3 YX_(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.x, 0); }
        public static VectorI3 YYX(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.y, V.x); }
        public static VectorI3 YYY(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.y, V.y); }
        public static VectorI3 YYZ(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.y, V.z); }
        public static VectorI3 YYW(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.y, V.w); }
        public static VectorI3 YY_(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.y, 0); }
        public static VectorI3 YZX(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.z, V.x); }
        public static VectorI3 YZY(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.z, V.y); }
        public static VectorI3 YZZ(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.z, V.z); }
        public static VectorI3 YZW(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.z, V.w); }
        public static VectorI3 YZ_(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.z, 0); }
        public static VectorI3 YWX(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.w, V.x); }
        public static VectorI3 YWY(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.w, V.y); }
        public static VectorI3 YWZ(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.w, V.z); }
        public static VectorI3 YWW(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.w, V.w); }
        public static VectorI3 YW_(VectorI4 V){ return VecOps.MkVectorI3(V.y, V.w, 0); }
        public static VectorI3 Y_X(VectorI4 V){ return VecOps.MkVectorI3(V.y, 0, V.x); }
        public static VectorI3 Y_Y(VectorI4 V){ return VecOps.MkVectorI3(V.y, 0, V.y); }
        public static VectorI3 Y_Z(VectorI4 V){ return VecOps.MkVectorI3(V.y, 0, V.z); }
        public static VectorI3 Y_W(VectorI4 V){ return VecOps.MkVectorI3(V.y, 0, V.w); }
        public static VectorI3 Y__(VectorI4 V){ return VecOps.MkVectorI3(V.y, 0, 0); }
        public static VectorI3 ZXX(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.x, V.x); }
        public static VectorI3 ZXY(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.x, V.y); }
        public static VectorI3 ZXZ(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.x, V.z); }
        public static VectorI3 ZXW(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.x, V.w); }
        public static VectorI3 ZX_(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.x, 0); }
        public static VectorI3 ZYX(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.y, V.x); }
        public static VectorI3 ZYY(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.y, V.y); }
        public static VectorI3 ZYZ(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.y, V.z); }
        public static VectorI3 ZYW(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.y, V.w); }
        public static VectorI3 ZY_(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.y, 0); }
        public static VectorI3 ZZX(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.z, V.x); }
        public static VectorI3 ZZY(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.z, V.y); }
        public static VectorI3 ZZZ(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.z, V.z); }
        public static VectorI3 ZZW(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.z, V.w); }
        public static VectorI3 ZZ_(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.z, 0); }
        public static VectorI3 ZWX(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.w, V.x); }
        public static VectorI3 ZWY(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.w, V.y); }
        public static VectorI3 ZWZ(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.w, V.z); }
        public static VectorI3 ZWW(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.w, V.w); }
        public static VectorI3 ZW_(VectorI4 V){ return VecOps.MkVectorI3(V.z, V.w, 0); }
        public static VectorI3 Z_X(VectorI4 V){ return VecOps.MkVectorI3(V.z, 0, V.x); }
        public static VectorI3 Z_Y(VectorI4 V){ return VecOps.MkVectorI3(V.z, 0, V.y); }
        public static VectorI3 Z_Z(VectorI4 V){ return VecOps.MkVectorI3(V.z, 0, V.z); }
        public static VectorI3 Z_W(VectorI4 V){ return VecOps.MkVectorI3(V.z, 0, V.w); }
        public static VectorI3 Z__(VectorI4 V){ return VecOps.MkVectorI3(V.z, 0, 0); }
        public static VectorI3 WXX(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.x, V.x); }
        public static VectorI3 WXY(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.x, V.y); }
        public static VectorI3 WXZ(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.x, V.z); }
        public static VectorI3 WXW(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.x, V.w); }
        public static VectorI3 WX_(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.x, 0); }
        public static VectorI3 WYX(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.y, V.x); }
        public static VectorI3 WYY(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.y, V.y); }
        public static VectorI3 WYZ(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.y, V.z); }
        public static VectorI3 WYW(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.y, V.w); }
        public static VectorI3 WY_(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.y, 0); }
        public static VectorI3 WZX(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.z, V.x); }
        public static VectorI3 WZY(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.z, V.y); }
        public static VectorI3 WZZ(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.z, V.z); }
        public static VectorI3 WZW(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.z, V.w); }
        public static VectorI3 WZ_(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.z, 0); }
        public static VectorI3 WWX(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.w, V.x); }
        public static VectorI3 WWY(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.w, V.y); }
        public static VectorI3 WWZ(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.w, V.z); }
        public static VectorI3 WWW(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.w, V.w); }
        public static VectorI3 WW_(VectorI4 V){ return VecOps.MkVectorI3(V.w, V.w, 0); }
        public static VectorI3 W_X(VectorI4 V){ return VecOps.MkVectorI3(V.w, 0, V.x); }
        public static VectorI3 W_Y(VectorI4 V){ return VecOps.MkVectorI3(V.w, 0, V.y); }
        public static VectorI3 W_Z(VectorI4 V){ return VecOps.MkVectorI3(V.w, 0, V.z); }
        public static VectorI3 W_W(VectorI4 V){ return VecOps.MkVectorI3(V.w, 0, V.w); }
        public static VectorI3 W__(VectorI4 V){ return VecOps.MkVectorI3(V.w, 0, 0); }
        public static VectorI3 _XX(VectorI4 V){ return VecOps.MkVectorI3(0, V.x, V.x); }
        public static VectorI3 _XY(VectorI4 V){ return VecOps.MkVectorI3(0, V.x, V.y); }
        public static VectorI3 _XZ(VectorI4 V){ return VecOps.MkVectorI3(0, V.x, V.z); }
        public static VectorI3 _XW(VectorI4 V){ return VecOps.MkVectorI3(0, V.x, V.w); }
        public static VectorI3 _X_(VectorI4 V){ return VecOps.MkVectorI3(0, V.x, 0); }
        public static VectorI3 _YX(VectorI4 V){ return VecOps.MkVectorI3(0, V.y, V.x); }
        public static VectorI3 _YY(VectorI4 V){ return VecOps.MkVectorI3(0, V.y, V.y); }
        public static VectorI3 _YZ(VectorI4 V){ return VecOps.MkVectorI3(0, V.y, V.z); }
        public static VectorI3 _YW(VectorI4 V){ return VecOps.MkVectorI3(0, V.y, V.w); }
        public static VectorI3 _Y_(VectorI4 V){ return VecOps.MkVectorI3(0, V.y, 0); }
        public static VectorI3 _ZX(VectorI4 V){ return VecOps.MkVectorI3(0, V.z, V.x); }
        public static VectorI3 _ZY(VectorI4 V){ return VecOps.MkVectorI3(0, V.z, V.y); }
        public static VectorI3 _ZZ(VectorI4 V){ return VecOps.MkVectorI3(0, V.z, V.z); }
        public static VectorI3 _ZW(VectorI4 V){ return VecOps.MkVectorI3(0, V.z, V.w); }
        public static VectorI3 _Z_(VectorI4 V){ return VecOps.MkVectorI3(0, V.z, 0); }
        public static VectorI3 _WX(VectorI4 V){ return VecOps.MkVectorI3(0, V.w, V.x); }
        public static VectorI3 _WY(VectorI4 V){ return VecOps.MkVectorI3(0, V.w, V.y); }
        public static VectorI3 _WZ(VectorI4 V){ return VecOps.MkVectorI3(0, V.w, V.z); }
        public static VectorI3 _WW(VectorI4 V){ return VecOps.MkVectorI3(0, V.w, V.w); }
        public static VectorI3 _W_(VectorI4 V){ return VecOps.MkVectorI3(0, V.w, 0); }
        public static VectorI3 __X(VectorI4 V){ return VecOps.MkVectorI3(0, 0, V.x); }
        public static VectorI3 __Y(VectorI4 V){ return VecOps.MkVectorI3(0, 0, V.y); }
        public static VectorI3 __Z(VectorI4 V){ return VecOps.MkVectorI3(0, 0, V.z); }
        public static VectorI3 __W(VectorI4 V){ return VecOps.MkVectorI3(0, 0, V.w); }
        public static VectorI4 XXXX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.x); }
        public static VectorI4 XXXY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.y); }
        public static VectorI4 XXXZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.z); }
        public static VectorI4 XXXW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.w); }
        public static VectorI4 XXX_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, 0); }
        public static VectorI4 XXYX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.x); }
        public static VectorI4 XXYY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.y); }
        public static VectorI4 XXYZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.z); }
        public static VectorI4 XXYW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.w); }
        public static VectorI4 XXY_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, 0); }
        public static VectorI4 XXZX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.x); }
        public static VectorI4 XXZY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.y); }
        public static VectorI4 XXZZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.z); }
        public static VectorI4 XXZW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.w); }
        public static VectorI4 XXZ_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, 0); }
        public static VectorI4 XXWX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.w, V.x); }
        public static VectorI4 XXWY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.w, V.y); }
        public static VectorI4 XXWZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.w, V.z); }
        public static VectorI4 XXWW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.w, V.w); }
        public static VectorI4 XXW_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.w, 0); }
        public static VectorI4 XX_X(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.x); }
        public static VectorI4 XX_Y(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.y); }
        public static VectorI4 XX_Z(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.z); }
        public static VectorI4 XX_W(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.w); }
        public static VectorI4 XX__(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, 0, 0); }
        public static VectorI4 XYXX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.x); }
        public static VectorI4 XYXY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.y); }
        public static VectorI4 XYXZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.z); }
        public static VectorI4 XYXW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.w); }
        public static VectorI4 XYX_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, 0); }
        public static VectorI4 XYYX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.x); }
        public static VectorI4 XYYY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.y); }
        public static VectorI4 XYYZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.z); }
        public static VectorI4 XYYW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.w); }
        public static VectorI4 XYY_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, 0); }
        public static VectorI4 XYZX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.x); }
        public static VectorI4 XYZY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.y); }
        public static VectorI4 XYZZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.z); }
        public static VectorI4 XYZW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.w); }
        public static VectorI4 XYZ_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, 0); }
        public static VectorI4 XYWX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.w, V.x); }
        public static VectorI4 XYWY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.w, V.y); }
        public static VectorI4 XYWZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.w, V.z); }
        public static VectorI4 XYWW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.w, V.w); }
        public static VectorI4 XYW_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.w, 0); }
        public static VectorI4 XY_X(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.x); }
        public static VectorI4 XY_Y(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.y); }
        public static VectorI4 XY_Z(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.z); }
        public static VectorI4 XY_W(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.w); }
        public static VectorI4 XY__(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, 0, 0); }
        public static VectorI4 XZXX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.x); }
        public static VectorI4 XZXY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.y); }
        public static VectorI4 XZXZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.z); }
        public static VectorI4 XZXW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.w); }
        public static VectorI4 XZX_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, 0); }
        public static VectorI4 XZYX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.x); }
        public static VectorI4 XZYY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.y); }
        public static VectorI4 XZYZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.z); }
        public static VectorI4 XZYW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.w); }
        public static VectorI4 XZY_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, 0); }
        public static VectorI4 XZZX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.x); }
        public static VectorI4 XZZY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.y); }
        public static VectorI4 XZZZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.z); }
        public static VectorI4 XZZW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.w); }
        public static VectorI4 XZZ_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, 0); }
        public static VectorI4 XZWX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.w, V.x); }
        public static VectorI4 XZWY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.w, V.y); }
        public static VectorI4 XZWZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.w, V.z); }
        public static VectorI4 XZWW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.w, V.w); }
        public static VectorI4 XZW_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.w, 0); }
        public static VectorI4 XZ_X(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.x); }
        public static VectorI4 XZ_Y(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.y); }
        public static VectorI4 XZ_Z(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.z); }
        public static VectorI4 XZ_W(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.w); }
        public static VectorI4 XZ__(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, 0, 0); }
        public static VectorI4 XWXX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.x, V.x); }
        public static VectorI4 XWXY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.x, V.y); }
        public static VectorI4 XWXZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.x, V.z); }
        public static VectorI4 XWXW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.x, V.w); }
        public static VectorI4 XWX_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.x, 0); }
        public static VectorI4 XWYX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.y, V.x); }
        public static VectorI4 XWYY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.y, V.y); }
        public static VectorI4 XWYZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.y, V.z); }
        public static VectorI4 XWYW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.y, V.w); }
        public static VectorI4 XWY_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.y, 0); }
        public static VectorI4 XWZX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.z, V.x); }
        public static VectorI4 XWZY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.z, V.y); }
        public static VectorI4 XWZZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.z, V.z); }
        public static VectorI4 XWZW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.z, V.w); }
        public static VectorI4 XWZ_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.z, 0); }
        public static VectorI4 XWWX(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.w, V.x); }
        public static VectorI4 XWWY(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.w, V.y); }
        public static VectorI4 XWWZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.w, V.z); }
        public static VectorI4 XWWW(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.w, V.w); }
        public static VectorI4 XWW_(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.w, 0); }
        public static VectorI4 XW_X(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, 0, V.x); }
        public static VectorI4 XW_Y(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, 0, V.y); }
        public static VectorI4 XW_Z(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, 0, V.z); }
        public static VectorI4 XW_W(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, 0, V.w); }
        public static VectorI4 XW__(VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, 0, 0); }
        public static VectorI4 X_XX(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.x); }
        public static VectorI4 X_XY(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.y); }
        public static VectorI4 X_XZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.z); }
        public static VectorI4 X_XW(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.w); }
        public static VectorI4 X_X_(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.x, 0); }
        public static VectorI4 X_YX(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.x); }
        public static VectorI4 X_YY(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.y); }
        public static VectorI4 X_YZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.z); }
        public static VectorI4 X_YW(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.w); }
        public static VectorI4 X_Y_(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.y, 0); }
        public static VectorI4 X_ZX(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.x); }
        public static VectorI4 X_ZY(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.y); }
        public static VectorI4 X_ZZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.z); }
        public static VectorI4 X_ZW(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.w); }
        public static VectorI4 X_Z_(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.z, 0); }
        public static VectorI4 X_WX(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.w, V.x); }
        public static VectorI4 X_WY(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.w, V.y); }
        public static VectorI4 X_WZ(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.w, V.z); }
        public static VectorI4 X_WW(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.w, V.w); }
        public static VectorI4 X_W_(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.w, 0); }
        public static VectorI4 X__X(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.x); }
        public static VectorI4 X__Y(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.y); }
        public static VectorI4 X__Z(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.z); }
        public static VectorI4 X__W(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.w); }
        public static VectorI4 X___(VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, 0, 0); }
        public static VectorI4 YXXX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.x); }
        public static VectorI4 YXXY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.y); }
        public static VectorI4 YXXZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.z); }
        public static VectorI4 YXXW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.w); }
        public static VectorI4 YXX_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, 0); }
        public static VectorI4 YXYX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.x); }
        public static VectorI4 YXYY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.y); }
        public static VectorI4 YXYZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.z); }
        public static VectorI4 YXYW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.w); }
        public static VectorI4 YXY_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, 0); }
        public static VectorI4 YXZX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.x); }
        public static VectorI4 YXZY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.y); }
        public static VectorI4 YXZZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.z); }
        public static VectorI4 YXZW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.w); }
        public static VectorI4 YXZ_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, 0); }
        public static VectorI4 YXWX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.w, V.x); }
        public static VectorI4 YXWY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.w, V.y); }
        public static VectorI4 YXWZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.w, V.z); }
        public static VectorI4 YXWW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.w, V.w); }
        public static VectorI4 YXW_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.w, 0); }
        public static VectorI4 YX_X(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.x); }
        public static VectorI4 YX_Y(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.y); }
        public static VectorI4 YX_Z(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.z); }
        public static VectorI4 YX_W(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.w); }
        public static VectorI4 YX__(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, 0, 0); }
        public static VectorI4 YYXX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.x); }
        public static VectorI4 YYXY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.y); }
        public static VectorI4 YYXZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.z); }
        public static VectorI4 YYXW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.w); }
        public static VectorI4 YYX_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, 0); }
        public static VectorI4 YYYX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.x); }
        public static VectorI4 YYYY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.y); }
        public static VectorI4 YYYZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.z); }
        public static VectorI4 YYYW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.w); }
        public static VectorI4 YYY_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, 0); }
        public static VectorI4 YYZX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.x); }
        public static VectorI4 YYZY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.y); }
        public static VectorI4 YYZZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.z); }
        public static VectorI4 YYZW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.w); }
        public static VectorI4 YYZ_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, 0); }
        public static VectorI4 YYWX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.w, V.x); }
        public static VectorI4 YYWY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.w, V.y); }
        public static VectorI4 YYWZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.w, V.z); }
        public static VectorI4 YYWW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.w, V.w); }
        public static VectorI4 YYW_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.w, 0); }
        public static VectorI4 YY_X(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.x); }
        public static VectorI4 YY_Y(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.y); }
        public static VectorI4 YY_Z(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.z); }
        public static VectorI4 YY_W(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.w); }
        public static VectorI4 YY__(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, 0, 0); }
        public static VectorI4 YZXX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.x); }
        public static VectorI4 YZXY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.y); }
        public static VectorI4 YZXZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.z); }
        public static VectorI4 YZXW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.w); }
        public static VectorI4 YZX_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, 0); }
        public static VectorI4 YZYX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.x); }
        public static VectorI4 YZYY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.y); }
        public static VectorI4 YZYZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.z); }
        public static VectorI4 YZYW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.w); }
        public static VectorI4 YZY_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, 0); }
        public static VectorI4 YZZX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.x); }
        public static VectorI4 YZZY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.y); }
        public static VectorI4 YZZZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.z); }
        public static VectorI4 YZZW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.w); }
        public static VectorI4 YZZ_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, 0); }
        public static VectorI4 YZWX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.w, V.x); }
        public static VectorI4 YZWY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.w, V.y); }
        public static VectorI4 YZWZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.w, V.z); }
        public static VectorI4 YZWW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.w, V.w); }
        public static VectorI4 YZW_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.w, 0); }
        public static VectorI4 YZ_X(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.x); }
        public static VectorI4 YZ_Y(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.y); }
        public static VectorI4 YZ_Z(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.z); }
        public static VectorI4 YZ_W(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.w); }
        public static VectorI4 YZ__(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, 0, 0); }
        public static VectorI4 YWXX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.x, V.x); }
        public static VectorI4 YWXY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.x, V.y); }
        public static VectorI4 YWXZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.x, V.z); }
        public static VectorI4 YWXW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.x, V.w); }
        public static VectorI4 YWX_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.x, 0); }
        public static VectorI4 YWYX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.y, V.x); }
        public static VectorI4 YWYY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.y, V.y); }
        public static VectorI4 YWYZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.y, V.z); }
        public static VectorI4 YWYW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.y, V.w); }
        public static VectorI4 YWY_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.y, 0); }
        public static VectorI4 YWZX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.z, V.x); }
        public static VectorI4 YWZY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.z, V.y); }
        public static VectorI4 YWZZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.z, V.z); }
        public static VectorI4 YWZW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.z, V.w); }
        public static VectorI4 YWZ_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.z, 0); }
        public static VectorI4 YWWX(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.w, V.x); }
        public static VectorI4 YWWY(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.w, V.y); }
        public static VectorI4 YWWZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.w, V.z); }
        public static VectorI4 YWWW(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.w, V.w); }
        public static VectorI4 YWW_(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.w, 0); }
        public static VectorI4 YW_X(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, 0, V.x); }
        public static VectorI4 YW_Y(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, 0, V.y); }
        public static VectorI4 YW_Z(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, 0, V.z); }
        public static VectorI4 YW_W(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, 0, V.w); }
        public static VectorI4 YW__(VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, 0, 0); }
        public static VectorI4 Y_XX(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.x); }
        public static VectorI4 Y_XY(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.y); }
        public static VectorI4 Y_XZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.z); }
        public static VectorI4 Y_XW(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.w); }
        public static VectorI4 Y_X_(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.x, 0); }
        public static VectorI4 Y_YX(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.x); }
        public static VectorI4 Y_YY(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.y); }
        public static VectorI4 Y_YZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.z); }
        public static VectorI4 Y_YW(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.w); }
        public static VectorI4 Y_Y_(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.y, 0); }
        public static VectorI4 Y_ZX(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.x); }
        public static VectorI4 Y_ZY(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.y); }
        public static VectorI4 Y_ZZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.z); }
        public static VectorI4 Y_ZW(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.w); }
        public static VectorI4 Y_Z_(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.z, 0); }
        public static VectorI4 Y_WX(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.w, V.x); }
        public static VectorI4 Y_WY(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.w, V.y); }
        public static VectorI4 Y_WZ(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.w, V.z); }
        public static VectorI4 Y_WW(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.w, V.w); }
        public static VectorI4 Y_W_(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.w, 0); }
        public static VectorI4 Y__X(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.x); }
        public static VectorI4 Y__Y(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.y); }
        public static VectorI4 Y__Z(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.z); }
        public static VectorI4 Y__W(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.w); }
        public static VectorI4 Y___(VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, 0, 0); }
        public static VectorI4 ZXXX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.x); }
        public static VectorI4 ZXXY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.y); }
        public static VectorI4 ZXXZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.z); }
        public static VectorI4 ZXXW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.w); }
        public static VectorI4 ZXX_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, 0); }
        public static VectorI4 ZXYX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.x); }
        public static VectorI4 ZXYY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.y); }
        public static VectorI4 ZXYZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.z); }
        public static VectorI4 ZXYW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.w); }
        public static VectorI4 ZXY_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, 0); }
        public static VectorI4 ZXZX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.x); }
        public static VectorI4 ZXZY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.y); }
        public static VectorI4 ZXZZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.z); }
        public static VectorI4 ZXZW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.w); }
        public static VectorI4 ZXZ_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, 0); }
        public static VectorI4 ZXWX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.w, V.x); }
        public static VectorI4 ZXWY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.w, V.y); }
        public static VectorI4 ZXWZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.w, V.z); }
        public static VectorI4 ZXWW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.w, V.w); }
        public static VectorI4 ZXW_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.w, 0); }
        public static VectorI4 ZX_X(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.x); }
        public static VectorI4 ZX_Y(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.y); }
        public static VectorI4 ZX_Z(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.z); }
        public static VectorI4 ZX_W(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.w); }
        public static VectorI4 ZX__(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, 0, 0); }
        public static VectorI4 ZYXX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.x); }
        public static VectorI4 ZYXY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.y); }
        public static VectorI4 ZYXZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.z); }
        public static VectorI4 ZYXW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.w); }
        public static VectorI4 ZYX_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, 0); }
        public static VectorI4 ZYYX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.x); }
        public static VectorI4 ZYYY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.y); }
        public static VectorI4 ZYYZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.z); }
        public static VectorI4 ZYYW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.w); }
        public static VectorI4 ZYY_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, 0); }
        public static VectorI4 ZYZX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.x); }
        public static VectorI4 ZYZY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.y); }
        public static VectorI4 ZYZZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.z); }
        public static VectorI4 ZYZW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.w); }
        public static VectorI4 ZYZ_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, 0); }
        public static VectorI4 ZYWX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.w, V.x); }
        public static VectorI4 ZYWY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.w, V.y); }
        public static VectorI4 ZYWZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.w, V.z); }
        public static VectorI4 ZYWW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.w, V.w); }
        public static VectorI4 ZYW_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.w, 0); }
        public static VectorI4 ZY_X(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.x); }
        public static VectorI4 ZY_Y(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.y); }
        public static VectorI4 ZY_Z(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.z); }
        public static VectorI4 ZY_W(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.w); }
        public static VectorI4 ZY__(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, 0, 0); }
        public static VectorI4 ZZXX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.x); }
        public static VectorI4 ZZXY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.y); }
        public static VectorI4 ZZXZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.z); }
        public static VectorI4 ZZXW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.w); }
        public static VectorI4 ZZX_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, 0); }
        public static VectorI4 ZZYX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.x); }
        public static VectorI4 ZZYY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.y); }
        public static VectorI4 ZZYZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.z); }
        public static VectorI4 ZZYW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.w); }
        public static VectorI4 ZZY_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, 0); }
        public static VectorI4 ZZZX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.x); }
        public static VectorI4 ZZZY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.y); }
        public static VectorI4 ZZZZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.z); }
        public static VectorI4 ZZZW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.w); }
        public static VectorI4 ZZZ_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, 0); }
        public static VectorI4 ZZWX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.w, V.x); }
        public static VectorI4 ZZWY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.w, V.y); }
        public static VectorI4 ZZWZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.w, V.z); }
        public static VectorI4 ZZWW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.w, V.w); }
        public static VectorI4 ZZW_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.w, 0); }
        public static VectorI4 ZZ_X(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.x); }
        public static VectorI4 ZZ_Y(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.y); }
        public static VectorI4 ZZ_Z(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.z); }
        public static VectorI4 ZZ_W(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.w); }
        public static VectorI4 ZZ__(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, 0, 0); }
        public static VectorI4 ZWXX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.x, V.x); }
        public static VectorI4 ZWXY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.x, V.y); }
        public static VectorI4 ZWXZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.x, V.z); }
        public static VectorI4 ZWXW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.x, V.w); }
        public static VectorI4 ZWX_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.x, 0); }
        public static VectorI4 ZWYX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.y, V.x); }
        public static VectorI4 ZWYY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.y, V.y); }
        public static VectorI4 ZWYZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.y, V.z); }
        public static VectorI4 ZWYW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.y, V.w); }
        public static VectorI4 ZWY_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.y, 0); }
        public static VectorI4 ZWZX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.z, V.x); }
        public static VectorI4 ZWZY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.z, V.y); }
        public static VectorI4 ZWZZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.z, V.z); }
        public static VectorI4 ZWZW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.z, V.w); }
        public static VectorI4 ZWZ_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.z, 0); }
        public static VectorI4 ZWWX(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.w, V.x); }
        public static VectorI4 ZWWY(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.w, V.y); }
        public static VectorI4 ZWWZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.w, V.z); }
        public static VectorI4 ZWWW(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.w, V.w); }
        public static VectorI4 ZWW_(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.w, 0); }
        public static VectorI4 ZW_X(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, 0, V.x); }
        public static VectorI4 ZW_Y(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, 0, V.y); }
        public static VectorI4 ZW_Z(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, 0, V.z); }
        public static VectorI4 ZW_W(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, 0, V.w); }
        public static VectorI4 ZW__(VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, 0, 0); }
        public static VectorI4 Z_XX(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.x); }
        public static VectorI4 Z_XY(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.y); }
        public static VectorI4 Z_XZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.z); }
        public static VectorI4 Z_XW(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.w); }
        public static VectorI4 Z_X_(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.x, 0); }
        public static VectorI4 Z_YX(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.x); }
        public static VectorI4 Z_YY(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.y); }
        public static VectorI4 Z_YZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.z); }
        public static VectorI4 Z_YW(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.w); }
        public static VectorI4 Z_Y_(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.y, 0); }
        public static VectorI4 Z_ZX(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.x); }
        public static VectorI4 Z_ZY(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.y); }
        public static VectorI4 Z_ZZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.z); }
        public static VectorI4 Z_ZW(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.w); }
        public static VectorI4 Z_Z_(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.z, 0); }
        public static VectorI4 Z_WX(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.w, V.x); }
        public static VectorI4 Z_WY(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.w, V.y); }
        public static VectorI4 Z_WZ(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.w, V.z); }
        public static VectorI4 Z_WW(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.w, V.w); }
        public static VectorI4 Z_W_(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.w, 0); }
        public static VectorI4 Z__X(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.x); }
        public static VectorI4 Z__Y(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.y); }
        public static VectorI4 Z__Z(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.z); }
        public static VectorI4 Z__W(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.w); }
        public static VectorI4 Z___(VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, 0, 0); }
        public static VectorI4 WXXX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.x, V.x); }
        public static VectorI4 WXXY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.x, V.y); }
        public static VectorI4 WXXZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.x, V.z); }
        public static VectorI4 WXXW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.x, V.w); }
        public static VectorI4 WXX_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.x, 0); }
        public static VectorI4 WXYX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.y, V.x); }
        public static VectorI4 WXYY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.y, V.y); }
        public static VectorI4 WXYZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.y, V.z); }
        public static VectorI4 WXYW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.y, V.w); }
        public static VectorI4 WXY_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.y, 0); }
        public static VectorI4 WXZX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.z, V.x); }
        public static VectorI4 WXZY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.z, V.y); }
        public static VectorI4 WXZZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.z, V.z); }
        public static VectorI4 WXZW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.z, V.w); }
        public static VectorI4 WXZ_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.z, 0); }
        public static VectorI4 WXWX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.w, V.x); }
        public static VectorI4 WXWY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.w, V.y); }
        public static VectorI4 WXWZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.w, V.z); }
        public static VectorI4 WXWW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.w, V.w); }
        public static VectorI4 WXW_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.w, 0); }
        public static VectorI4 WX_X(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, 0, V.x); }
        public static VectorI4 WX_Y(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, 0, V.y); }
        public static VectorI4 WX_Z(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, 0, V.z); }
        public static VectorI4 WX_W(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, 0, V.w); }
        public static VectorI4 WX__(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, 0, 0); }
        public static VectorI4 WYXX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.x, V.x); }
        public static VectorI4 WYXY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.x, V.y); }
        public static VectorI4 WYXZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.x, V.z); }
        public static VectorI4 WYXW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.x, V.w); }
        public static VectorI4 WYX_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.x, 0); }
        public static VectorI4 WYYX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.y, V.x); }
        public static VectorI4 WYYY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.y, V.y); }
        public static VectorI4 WYYZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.y, V.z); }
        public static VectorI4 WYYW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.y, V.w); }
        public static VectorI4 WYY_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.y, 0); }
        public static VectorI4 WYZX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.z, V.x); }
        public static VectorI4 WYZY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.z, V.y); }
        public static VectorI4 WYZZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.z, V.z); }
        public static VectorI4 WYZW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.z, V.w); }
        public static VectorI4 WYZ_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.z, 0); }
        public static VectorI4 WYWX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.w, V.x); }
        public static VectorI4 WYWY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.w, V.y); }
        public static VectorI4 WYWZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.w, V.z); }
        public static VectorI4 WYWW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.w, V.w); }
        public static VectorI4 WYW_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.w, 0); }
        public static VectorI4 WY_X(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, 0, V.x); }
        public static VectorI4 WY_Y(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, 0, V.y); }
        public static VectorI4 WY_Z(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, 0, V.z); }
        public static VectorI4 WY_W(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, 0, V.w); }
        public static VectorI4 WY__(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, 0, 0); }
        public static VectorI4 WZXX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.x, V.x); }
        public static VectorI4 WZXY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.x, V.y); }
        public static VectorI4 WZXZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.x, V.z); }
        public static VectorI4 WZXW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.x, V.w); }
        public static VectorI4 WZX_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.x, 0); }
        public static VectorI4 WZYX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.y, V.x); }
        public static VectorI4 WZYY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.y, V.y); }
        public static VectorI4 WZYZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.y, V.z); }
        public static VectorI4 WZYW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.y, V.w); }
        public static VectorI4 WZY_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.y, 0); }
        public static VectorI4 WZZX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.z, V.x); }
        public static VectorI4 WZZY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.z, V.y); }
        public static VectorI4 WZZZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.z, V.z); }
        public static VectorI4 WZZW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.z, V.w); }
        public static VectorI4 WZZ_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.z, 0); }
        public static VectorI4 WZWX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.w, V.x); }
        public static VectorI4 WZWY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.w, V.y); }
        public static VectorI4 WZWZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.w, V.z); }
        public static VectorI4 WZWW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.w, V.w); }
        public static VectorI4 WZW_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.w, 0); }
        public static VectorI4 WZ_X(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, 0, V.x); }
        public static VectorI4 WZ_Y(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, 0, V.y); }
        public static VectorI4 WZ_Z(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, 0, V.z); }
        public static VectorI4 WZ_W(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, 0, V.w); }
        public static VectorI4 WZ__(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, 0, 0); }
        public static VectorI4 WWXX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.x, V.x); }
        public static VectorI4 WWXY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.x, V.y); }
        public static VectorI4 WWXZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.x, V.z); }
        public static VectorI4 WWXW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.x, V.w); }
        public static VectorI4 WWX_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.x, 0); }
        public static VectorI4 WWYX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.y, V.x); }
        public static VectorI4 WWYY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.y, V.y); }
        public static VectorI4 WWYZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.y, V.z); }
        public static VectorI4 WWYW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.y, V.w); }
        public static VectorI4 WWY_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.y, 0); }
        public static VectorI4 WWZX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.z, V.x); }
        public static VectorI4 WWZY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.z, V.y); }
        public static VectorI4 WWZZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.z, V.z); }
        public static VectorI4 WWZW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.z, V.w); }
        public static VectorI4 WWZ_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.z, 0); }
        public static VectorI4 WWWX(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.w, V.x); }
        public static VectorI4 WWWY(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.w, V.y); }
        public static VectorI4 WWWZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.w, V.z); }
        public static VectorI4 WWWW(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.w, V.w); }
        public static VectorI4 WWW_(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.w, 0); }
        public static VectorI4 WW_X(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, 0, V.x); }
        public static VectorI4 WW_Y(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, 0, V.y); }
        public static VectorI4 WW_Z(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, 0, V.z); }
        public static VectorI4 WW_W(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, 0, V.w); }
        public static VectorI4 WW__(VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, 0, 0); }
        public static VectorI4 W_XX(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.x, V.x); }
        public static VectorI4 W_XY(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.x, V.y); }
        public static VectorI4 W_XZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.x, V.z); }
        public static VectorI4 W_XW(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.x, V.w); }
        public static VectorI4 W_X_(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.x, 0); }
        public static VectorI4 W_YX(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.y, V.x); }
        public static VectorI4 W_YY(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.y, V.y); }
        public static VectorI4 W_YZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.y, V.z); }
        public static VectorI4 W_YW(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.y, V.w); }
        public static VectorI4 W_Y_(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.y, 0); }
        public static VectorI4 W_ZX(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.z, V.x); }
        public static VectorI4 W_ZY(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.z, V.y); }
        public static VectorI4 W_ZZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.z, V.z); }
        public static VectorI4 W_ZW(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.z, V.w); }
        public static VectorI4 W_Z_(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.z, 0); }
        public static VectorI4 W_WX(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.w, V.x); }
        public static VectorI4 W_WY(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.w, V.y); }
        public static VectorI4 W_WZ(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.w, V.z); }
        public static VectorI4 W_WW(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.w, V.w); }
        public static VectorI4 W_W_(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.w, 0); }
        public static VectorI4 W__X(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, 0, V.x); }
        public static VectorI4 W__Y(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, 0, V.y); }
        public static VectorI4 W__Z(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, 0, V.z); }
        public static VectorI4 W__W(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, 0, V.w); }
        public static VectorI4 W___(VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, 0, 0); }
        public static VectorI4 _XXX(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.x); }
        public static VectorI4 _XXY(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.y); }
        public static VectorI4 _XXZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.z); }
        public static VectorI4 _XXW(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.w); }
        public static VectorI4 _XX_(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.x, 0); }
        public static VectorI4 _XYX(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.x); }
        public static VectorI4 _XYY(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.y); }
        public static VectorI4 _XYZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.z); }
        public static VectorI4 _XYW(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.w); }
        public static VectorI4 _XY_(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.y, 0); }
        public static VectorI4 _XZX(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.x); }
        public static VectorI4 _XZY(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.y); }
        public static VectorI4 _XZZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.z); }
        public static VectorI4 _XZW(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.w); }
        public static VectorI4 _XZ_(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.z, 0); }
        public static VectorI4 _XWX(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.w, V.x); }
        public static VectorI4 _XWY(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.w, V.y); }
        public static VectorI4 _XWZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.w, V.z); }
        public static VectorI4 _XWW(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.w, V.w); }
        public static VectorI4 _XW_(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.w, 0); }
        public static VectorI4 _X_X(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, 0, V.x); }
        public static VectorI4 _X_Y(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, 0, V.y); }
        public static VectorI4 _X_Z(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, 0, V.z); }
        public static VectorI4 _X_W(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, 0, V.w); }
        public static VectorI4 _X__(VectorI4 V){ return VecOps.MkVectorI4(0, V.x, 0, 0); }
        public static VectorI4 _YXX(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.x); }
        public static VectorI4 _YXY(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.y); }
        public static VectorI4 _YXZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.z); }
        public static VectorI4 _YXW(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.w); }
        public static VectorI4 _YX_(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.x, 0); }
        public static VectorI4 _YYX(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.x); }
        public static VectorI4 _YYY(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.y); }
        public static VectorI4 _YYZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.z); }
        public static VectorI4 _YYW(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.w); }
        public static VectorI4 _YY_(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.y, 0); }
        public static VectorI4 _YZX(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.x); }
        public static VectorI4 _YZY(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.y); }
        public static VectorI4 _YZZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.z); }
        public static VectorI4 _YZW(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.w); }
        public static VectorI4 _YZ_(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.z, 0); }
        public static VectorI4 _YWX(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.w, V.x); }
        public static VectorI4 _YWY(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.w, V.y); }
        public static VectorI4 _YWZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.w, V.z); }
        public static VectorI4 _YWW(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.w, V.w); }
        public static VectorI4 _YW_(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.w, 0); }
        public static VectorI4 _Y_X(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, 0, V.x); }
        public static VectorI4 _Y_Y(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, 0, V.y); }
        public static VectorI4 _Y_Z(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, 0, V.z); }
        public static VectorI4 _Y_W(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, 0, V.w); }
        public static VectorI4 _Y__(VectorI4 V){ return VecOps.MkVectorI4(0, V.y, 0, 0); }
        public static VectorI4 _ZXX(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.x); }
        public static VectorI4 _ZXY(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.y); }
        public static VectorI4 _ZXZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.z); }
        public static VectorI4 _ZXW(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.w); }
        public static VectorI4 _ZX_(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.x, 0); }
        public static VectorI4 _ZYX(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.x); }
        public static VectorI4 _ZYY(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.y); }
        public static VectorI4 _ZYZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.z); }
        public static VectorI4 _ZYW(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.w); }
        public static VectorI4 _ZY_(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.y, 0); }
        public static VectorI4 _ZZX(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.x); }
        public static VectorI4 _ZZY(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.y); }
        public static VectorI4 _ZZZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.z); }
        public static VectorI4 _ZZW(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.w); }
        public static VectorI4 _ZZ_(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.z, 0); }
        public static VectorI4 _ZWX(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.w, V.x); }
        public static VectorI4 _ZWY(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.w, V.y); }
        public static VectorI4 _ZWZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.w, V.z); }
        public static VectorI4 _ZWW(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.w, V.w); }
        public static VectorI4 _ZW_(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.w, 0); }
        public static VectorI4 _Z_X(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, 0, V.x); }
        public static VectorI4 _Z_Y(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, 0, V.y); }
        public static VectorI4 _Z_Z(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, 0, V.z); }
        public static VectorI4 _Z_W(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, 0, V.w); }
        public static VectorI4 _Z__(VectorI4 V){ return VecOps.MkVectorI4(0, V.z, 0, 0); }
        public static VectorI4 _WXX(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.x, V.x); }
        public static VectorI4 _WXY(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.x, V.y); }
        public static VectorI4 _WXZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.x, V.z); }
        public static VectorI4 _WXW(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.x, V.w); }
        public static VectorI4 _WX_(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.x, 0); }
        public static VectorI4 _WYX(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.y, V.x); }
        public static VectorI4 _WYY(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.y, V.y); }
        public static VectorI4 _WYZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.y, V.z); }
        public static VectorI4 _WYW(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.y, V.w); }
        public static VectorI4 _WY_(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.y, 0); }
        public static VectorI4 _WZX(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.z, V.x); }
        public static VectorI4 _WZY(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.z, V.y); }
        public static VectorI4 _WZZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.z, V.z); }
        public static VectorI4 _WZW(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.z, V.w); }
        public static VectorI4 _WZ_(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.z, 0); }
        public static VectorI4 _WWX(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.w, V.x); }
        public static VectorI4 _WWY(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.w, V.y); }
        public static VectorI4 _WWZ(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.w, V.z); }
        public static VectorI4 _WWW(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.w, V.w); }
        public static VectorI4 _WW_(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.w, 0); }
        public static VectorI4 _W_X(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, 0, V.x); }
        public static VectorI4 _W_Y(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, 0, V.y); }
        public static VectorI4 _W_Z(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, 0, V.z); }
        public static VectorI4 _W_W(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, 0, V.w); }
        public static VectorI4 _W__(VectorI4 V){ return VecOps.MkVectorI4(0, V.w, 0, 0); }
        public static VectorI4 __XX(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.x, V.x); }
        public static VectorI4 __XY(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.x, V.y); }
        public static VectorI4 __XZ(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.x, V.z); }
        public static VectorI4 __XW(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.x, V.w); }
        public static VectorI4 __X_(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.x, 0); }
        public static VectorI4 __YX(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.y, V.x); }
        public static VectorI4 __YY(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.y, V.y); }
        public static VectorI4 __YZ(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.y, V.z); }
        public static VectorI4 __YW(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.y, V.w); }
        public static VectorI4 __Y_(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.y, 0); }
        public static VectorI4 __ZX(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.z, V.x); }
        public static VectorI4 __ZY(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.z, V.y); }
        public static VectorI4 __ZZ(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.z, V.z); }
        public static VectorI4 __ZW(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.z, V.w); }
        public static VectorI4 __Z_(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.z, 0); }
        public static VectorI4 __WX(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.w, V.x); }
        public static VectorI4 __WY(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.w, V.y); }
        public static VectorI4 __WZ(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.w, V.z); }
        public static VectorI4 __WW(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.w, V.w); }
        public static VectorI4 __W_(VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.w, 0); }
        public static VectorI4 ___X(VectorI4 V){ return VecOps.MkVectorI4(0, 0, 0, V.x); }
        public static VectorI4 ___Y(VectorI4 V){ return VecOps.MkVectorI4(0, 0, 0, V.y); }
        public static VectorI4 ___Z(VectorI4 V){ return VecOps.MkVectorI4(0, 0, 0, V.z); }
        public static VectorI4 ___W(VectorI4 V){ return VecOps.MkVectorI4(0, 0, 0, V.w); }
        public static VectorB2 XX(VectorB2 V){ return VecOps.MkVectorB2(V.x, V.x); }
        public static VectorB2 XY(VectorB2 V){ return VecOps.MkVectorB2(V.x, V.y); }
        public static VectorB2 X_(VectorB2 V){ return VecOps.MkVectorB2(V.x, 0); }
        public static VectorB2 YX(VectorB2 V){ return VecOps.MkVectorB2(V.y, V.x); }
        public static VectorB2 YY(VectorB2 V){ return VecOps.MkVectorB2(V.y, V.y); }
        public static VectorB2 Y_(VectorB2 V){ return VecOps.MkVectorB2(V.y, 0); }
        public static VectorB2 _X(VectorB2 V){ return VecOps.MkVectorB2(0, V.x); }
        public static VectorB2 _Y(VectorB2 V){ return VecOps.MkVectorB2(0, V.y); }
        public static VectorB3 XXX(VectorB2 V){ return VecOps.MkVectorB3(V.x, V.x, V.x); }
        public static VectorB3 XXY(VectorB2 V){ return VecOps.MkVectorB3(V.x, V.x, V.y); }
        public static VectorB3 XX_(VectorB2 V){ return VecOps.MkVectorB3(V.x, V.x, 0); }
        public static VectorB3 XYX(VectorB2 V){ return VecOps.MkVectorB3(V.x, V.y, V.x); }
        public static VectorB3 XYY(VectorB2 V){ return VecOps.MkVectorB3(V.x, V.y, V.y); }
        public static VectorB3 XY_(VectorB2 V){ return VecOps.MkVectorB3(V.x, V.y, 0); }
        public static VectorB3 X_X(VectorB2 V){ return VecOps.MkVectorB3(V.x, 0, V.x); }
        public static VectorB3 X_Y(VectorB2 V){ return VecOps.MkVectorB3(V.x, 0, V.y); }
        public static VectorB3 X__(VectorB2 V){ return VecOps.MkVectorB3(V.x, 0, 0); }
        public static VectorB3 YXX(VectorB2 V){ return VecOps.MkVectorB3(V.y, V.x, V.x); }
        public static VectorB3 YXY(VectorB2 V){ return VecOps.MkVectorB3(V.y, V.x, V.y); }
        public static VectorB3 YX_(VectorB2 V){ return VecOps.MkVectorB3(V.y, V.x, 0); }
        public static VectorB3 YYX(VectorB2 V){ return VecOps.MkVectorB3(V.y, V.y, V.x); }
        public static VectorB3 YYY(VectorB2 V){ return VecOps.MkVectorB3(V.y, V.y, V.y); }
        public static VectorB3 YY_(VectorB2 V){ return VecOps.MkVectorB3(V.y, V.y, 0); }
        public static VectorB3 Y_X(VectorB2 V){ return VecOps.MkVectorB3(V.y, 0, V.x); }
        public static VectorB3 Y_Y(VectorB2 V){ return VecOps.MkVectorB3(V.y, 0, V.y); }
        public static VectorB3 Y__(VectorB2 V){ return VecOps.MkVectorB3(V.y, 0, 0); }
        public static VectorB3 _XX(VectorB2 V){ return VecOps.MkVectorB3(0, V.x, V.x); }
        public static VectorB3 _XY(VectorB2 V){ return VecOps.MkVectorB3(0, V.x, V.y); }
        public static VectorB3 _X_(VectorB2 V){ return VecOps.MkVectorB3(0, V.x, 0); }
        public static VectorB3 _YX(VectorB2 V){ return VecOps.MkVectorB3(0, V.y, V.x); }
        public static VectorB3 _YY(VectorB2 V){ return VecOps.MkVectorB3(0, V.y, V.y); }
        public static VectorB3 _Y_(VectorB2 V){ return VecOps.MkVectorB3(0, V.y, 0); }
        public static VectorB3 __X(VectorB2 V){ return VecOps.MkVectorB3(0, 0, V.x); }
        public static VectorB3 __Y(VectorB2 V){ return VecOps.MkVectorB3(0, 0, V.y); }
        public static VectorB4 XXXX(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.x); }
        public static VectorB4 XXXY(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.y); }
        public static VectorB4 XXX_(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, 0); }
        public static VectorB4 XXYX(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.x); }
        public static VectorB4 XXYY(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.y); }
        public static VectorB4 XXY_(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, 0); }
        public static VectorB4 XX_X(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.x); }
        public static VectorB4 XX_Y(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.y); }
        public static VectorB4 XX__(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, 0, 0); }
        public static VectorB4 XYXX(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.x); }
        public static VectorB4 XYXY(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.y); }
        public static VectorB4 XYX_(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, 0); }
        public static VectorB4 XYYX(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.x); }
        public static VectorB4 XYYY(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.y); }
        public static VectorB4 XYY_(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, 0); }
        public static VectorB4 XY_X(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.x); }
        public static VectorB4 XY_Y(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.y); }
        public static VectorB4 XY__(VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, 0, 0); }
        public static VectorB4 X_XX(VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.x); }
        public static VectorB4 X_XY(VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.y); }
        public static VectorB4 X_X_(VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.x, 0); }
        public static VectorB4 X_YX(VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.x); }
        public static VectorB4 X_YY(VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.y); }
        public static VectorB4 X_Y_(VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.y, 0); }
        public static VectorB4 X__X(VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.x); }
        public static VectorB4 X__Y(VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.y); }
        public static VectorB4 X___(VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, 0, 0); }
        public static VectorB4 YXXX(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.x); }
        public static VectorB4 YXXY(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.y); }
        public static VectorB4 YXX_(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, 0); }
        public static VectorB4 YXYX(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.x); }
        public static VectorB4 YXYY(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.y); }
        public static VectorB4 YXY_(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, 0); }
        public static VectorB4 YX_X(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.x); }
        public static VectorB4 YX_Y(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.y); }
        public static VectorB4 YX__(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, 0, 0); }
        public static VectorB4 YYXX(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.x); }
        public static VectorB4 YYXY(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.y); }
        public static VectorB4 YYX_(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, 0); }
        public static VectorB4 YYYX(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.x); }
        public static VectorB4 YYYY(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.y); }
        public static VectorB4 YYY_(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, 0); }
        public static VectorB4 YY_X(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.x); }
        public static VectorB4 YY_Y(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.y); }
        public static VectorB4 YY__(VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, 0, 0); }
        public static VectorB4 Y_XX(VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.x); }
        public static VectorB4 Y_XY(VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.y); }
        public static VectorB4 Y_X_(VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.x, 0); }
        public static VectorB4 Y_YX(VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.x); }
        public static VectorB4 Y_YY(VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.y); }
        public static VectorB4 Y_Y_(VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.y, 0); }
        public static VectorB4 Y__X(VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.x); }
        public static VectorB4 Y__Y(VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.y); }
        public static VectorB4 Y___(VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, 0, 0); }
        public static VectorB4 _XXX(VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.x); }
        public static VectorB4 _XXY(VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.y); }
        public static VectorB4 _XX_(VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.x, 0); }
        public static VectorB4 _XYX(VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.x); }
        public static VectorB4 _XYY(VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.y); }
        public static VectorB4 _XY_(VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.y, 0); }
        public static VectorB4 _X_X(VectorB2 V){ return VecOps.MkVectorB4(0, V.x, 0, V.x); }
        public static VectorB4 _X_Y(VectorB2 V){ return VecOps.MkVectorB4(0, V.x, 0, V.y); }
        public static VectorB4 _X__(VectorB2 V){ return VecOps.MkVectorB4(0, V.x, 0, 0); }
        public static VectorB4 _YXX(VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.x); }
        public static VectorB4 _YXY(VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.y); }
        public static VectorB4 _YX_(VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.x, 0); }
        public static VectorB4 _YYX(VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.x); }
        public static VectorB4 _YYY(VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.y); }
        public static VectorB4 _YY_(VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.y, 0); }
        public static VectorB4 _Y_X(VectorB2 V){ return VecOps.MkVectorB4(0, V.y, 0, V.x); }
        public static VectorB4 _Y_Y(VectorB2 V){ return VecOps.MkVectorB4(0, V.y, 0, V.y); }
        public static VectorB4 _Y__(VectorB2 V){ return VecOps.MkVectorB4(0, V.y, 0, 0); }
        public static VectorB4 __XX(VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.x, V.x); }
        public static VectorB4 __XY(VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.x, V.y); }
        public static VectorB4 __X_(VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.x, 0); }
        public static VectorB4 __YX(VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.y, V.x); }
        public static VectorB4 __YY(VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.y, V.y); }
        public static VectorB4 __Y_(VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.y, 0); }
        public static VectorB4 ___X(VectorB2 V){ return VecOps.MkVectorB4(0, 0, 0, V.x); }
        public static VectorB4 ___Y(VectorB2 V){ return VecOps.MkVectorB4(0, 0, 0, V.y); }
        public static VectorB2 XX(VectorB3 V){ return VecOps.MkVectorB2(V.x, V.x); }
        public static VectorB2 XY(VectorB3 V){ return VecOps.MkVectorB2(V.x, V.y); }
        public static VectorB2 XZ(VectorB3 V){ return VecOps.MkVectorB2(V.x, V.z); }
        public static VectorB2 X_(VectorB3 V){ return VecOps.MkVectorB2(V.x, 0); }
        public static VectorB2 YX(VectorB3 V){ return VecOps.MkVectorB2(V.y, V.x); }
        public static VectorB2 YY(VectorB3 V){ return VecOps.MkVectorB2(V.y, V.y); }
        public static VectorB2 YZ(VectorB3 V){ return VecOps.MkVectorB2(V.y, V.z); }
        public static VectorB2 Y_(VectorB3 V){ return VecOps.MkVectorB2(V.y, 0); }
        public static VectorB2 ZX(VectorB3 V){ return VecOps.MkVectorB2(V.z, V.x); }
        public static VectorB2 ZY(VectorB3 V){ return VecOps.MkVectorB2(V.z, V.y); }
        public static VectorB2 ZZ(VectorB3 V){ return VecOps.MkVectorB2(V.z, V.z); }
        public static VectorB2 Z_(VectorB3 V){ return VecOps.MkVectorB2(V.z, 0); }
        public static VectorB2 _X(VectorB3 V){ return VecOps.MkVectorB2(0, V.x); }
        public static VectorB2 _Y(VectorB3 V){ return VecOps.MkVectorB2(0, V.y); }
        public static VectorB2 _Z(VectorB3 V){ return VecOps.MkVectorB2(0, V.z); }
        public static VectorB3 XXX(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.x, V.x); }
        public static VectorB3 XXY(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.x, V.y); }
        public static VectorB3 XXZ(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.x, V.z); }
        public static VectorB3 XX_(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.x, 0); }
        public static VectorB3 XYX(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.y, V.x); }
        public static VectorB3 XYY(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.y, V.y); }
        public static VectorB3 XYZ(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.y, V.z); }
        public static VectorB3 XY_(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.y, 0); }
        public static VectorB3 XZX(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.z, V.x); }
        public static VectorB3 XZY(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.z, V.y); }
        public static VectorB3 XZZ(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.z, V.z); }
        public static VectorB3 XZ_(VectorB3 V){ return VecOps.MkVectorB3(V.x, V.z, 0); }
        public static VectorB3 X_X(VectorB3 V){ return VecOps.MkVectorB3(V.x, 0, V.x); }
        public static VectorB3 X_Y(VectorB3 V){ return VecOps.MkVectorB3(V.x, 0, V.y); }
        public static VectorB3 X_Z(VectorB3 V){ return VecOps.MkVectorB3(V.x, 0, V.z); }
        public static VectorB3 X__(VectorB3 V){ return VecOps.MkVectorB3(V.x, 0, 0); }
        public static VectorB3 YXX(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.x, V.x); }
        public static VectorB3 YXY(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.x, V.y); }
        public static VectorB3 YXZ(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.x, V.z); }
        public static VectorB3 YX_(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.x, 0); }
        public static VectorB3 YYX(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.y, V.x); }
        public static VectorB3 YYY(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.y, V.y); }
        public static VectorB3 YYZ(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.y, V.z); }
        public static VectorB3 YY_(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.y, 0); }
        public static VectorB3 YZX(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.z, V.x); }
        public static VectorB3 YZY(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.z, V.y); }
        public static VectorB3 YZZ(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.z, V.z); }
        public static VectorB3 YZ_(VectorB3 V){ return VecOps.MkVectorB3(V.y, V.z, 0); }
        public static VectorB3 Y_X(VectorB3 V){ return VecOps.MkVectorB3(V.y, 0, V.x); }
        public static VectorB3 Y_Y(VectorB3 V){ return VecOps.MkVectorB3(V.y, 0, V.y); }
        public static VectorB3 Y_Z(VectorB3 V){ return VecOps.MkVectorB3(V.y, 0, V.z); }
        public static VectorB3 Y__(VectorB3 V){ return VecOps.MkVectorB3(V.y, 0, 0); }
        public static VectorB3 ZXX(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.x, V.x); }
        public static VectorB3 ZXY(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.x, V.y); }
        public static VectorB3 ZXZ(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.x, V.z); }
        public static VectorB3 ZX_(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.x, 0); }
        public static VectorB3 ZYX(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.y, V.x); }
        public static VectorB3 ZYY(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.y, V.y); }
        public static VectorB3 ZYZ(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.y, V.z); }
        public static VectorB3 ZY_(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.y, 0); }
        public static VectorB3 ZZX(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.z, V.x); }
        public static VectorB3 ZZY(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.z, V.y); }
        public static VectorB3 ZZZ(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.z, V.z); }
        public static VectorB3 ZZ_(VectorB3 V){ return VecOps.MkVectorB3(V.z, V.z, 0); }
        public static VectorB3 Z_X(VectorB3 V){ return VecOps.MkVectorB3(V.z, 0, V.x); }
        public static VectorB3 Z_Y(VectorB3 V){ return VecOps.MkVectorB3(V.z, 0, V.y); }
        public static VectorB3 Z_Z(VectorB3 V){ return VecOps.MkVectorB3(V.z, 0, V.z); }
        public static VectorB3 Z__(VectorB3 V){ return VecOps.MkVectorB3(V.z, 0, 0); }
        public static VectorB3 _XX(VectorB3 V){ return VecOps.MkVectorB3(0, V.x, V.x); }
        public static VectorB3 _XY(VectorB3 V){ return VecOps.MkVectorB3(0, V.x, V.y); }
        public static VectorB3 _XZ(VectorB3 V){ return VecOps.MkVectorB3(0, V.x, V.z); }
        public static VectorB3 _X_(VectorB3 V){ return VecOps.MkVectorB3(0, V.x, 0); }
        public static VectorB3 _YX(VectorB3 V){ return VecOps.MkVectorB3(0, V.y, V.x); }
        public static VectorB3 _YY(VectorB3 V){ return VecOps.MkVectorB3(0, V.y, V.y); }
        public static VectorB3 _YZ(VectorB3 V){ return VecOps.MkVectorB3(0, V.y, V.z); }
        public static VectorB3 _Y_(VectorB3 V){ return VecOps.MkVectorB3(0, V.y, 0); }
        public static VectorB3 _ZX(VectorB3 V){ return VecOps.MkVectorB3(0, V.z, V.x); }
        public static VectorB3 _ZY(VectorB3 V){ return VecOps.MkVectorB3(0, V.z, V.y); }
        public static VectorB3 _ZZ(VectorB3 V){ return VecOps.MkVectorB3(0, V.z, V.z); }
        public static VectorB3 _Z_(VectorB3 V){ return VecOps.MkVectorB3(0, V.z, 0); }
        public static VectorB3 __X(VectorB3 V){ return VecOps.MkVectorB3(0, 0, V.x); }
        public static VectorB3 __Y(VectorB3 V){ return VecOps.MkVectorB3(0, 0, V.y); }
        public static VectorB3 __Z(VectorB3 V){ return VecOps.MkVectorB3(0, 0, V.z); }
        public static VectorB4 XXXX(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.x); }
        public static VectorB4 XXXY(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.y); }
        public static VectorB4 XXXZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.z); }
        public static VectorB4 XXX_(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, 0); }
        public static VectorB4 XXYX(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.x); }
        public static VectorB4 XXYY(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.y); }
        public static VectorB4 XXYZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.z); }
        public static VectorB4 XXY_(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, 0); }
        public static VectorB4 XXZX(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.x); }
        public static VectorB4 XXZY(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.y); }
        public static VectorB4 XXZZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.z); }
        public static VectorB4 XXZ_(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, 0); }
        public static VectorB4 XX_X(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.x); }
        public static VectorB4 XX_Y(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.y); }
        public static VectorB4 XX_Z(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.z); }
        public static VectorB4 XX__(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, 0, 0); }
        public static VectorB4 XYXX(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.x); }
        public static VectorB4 XYXY(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.y); }
        public static VectorB4 XYXZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.z); }
        public static VectorB4 XYX_(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, 0); }
        public static VectorB4 XYYX(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.x); }
        public static VectorB4 XYYY(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.y); }
        public static VectorB4 XYYZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.z); }
        public static VectorB4 XYY_(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, 0); }
        public static VectorB4 XYZX(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.x); }
        public static VectorB4 XYZY(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.y); }
        public static VectorB4 XYZZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.z); }
        public static VectorB4 XYZ_(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, 0); }
        public static VectorB4 XY_X(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.x); }
        public static VectorB4 XY_Y(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.y); }
        public static VectorB4 XY_Z(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.z); }
        public static VectorB4 XY__(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, 0, 0); }
        public static VectorB4 XZXX(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.x); }
        public static VectorB4 XZXY(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.y); }
        public static VectorB4 XZXZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.z); }
        public static VectorB4 XZX_(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, 0); }
        public static VectorB4 XZYX(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.x); }
        public static VectorB4 XZYY(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.y); }
        public static VectorB4 XZYZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.z); }
        public static VectorB4 XZY_(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, 0); }
        public static VectorB4 XZZX(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.x); }
        public static VectorB4 XZZY(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.y); }
        public static VectorB4 XZZZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.z); }
        public static VectorB4 XZZ_(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, 0); }
        public static VectorB4 XZ_X(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.x); }
        public static VectorB4 XZ_Y(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.y); }
        public static VectorB4 XZ_Z(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.z); }
        public static VectorB4 XZ__(VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, 0, 0); }
        public static VectorB4 X_XX(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.x); }
        public static VectorB4 X_XY(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.y); }
        public static VectorB4 X_XZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.z); }
        public static VectorB4 X_X_(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.x, 0); }
        public static VectorB4 X_YX(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.x); }
        public static VectorB4 X_YY(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.y); }
        public static VectorB4 X_YZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.z); }
        public static VectorB4 X_Y_(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.y, 0); }
        public static VectorB4 X_ZX(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.x); }
        public static VectorB4 X_ZY(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.y); }
        public static VectorB4 X_ZZ(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.z); }
        public static VectorB4 X_Z_(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.z, 0); }
        public static VectorB4 X__X(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.x); }
        public static VectorB4 X__Y(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.y); }
        public static VectorB4 X__Z(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.z); }
        public static VectorB4 X___(VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, 0, 0); }
        public static VectorB4 YXXX(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.x); }
        public static VectorB4 YXXY(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.y); }
        public static VectorB4 YXXZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.z); }
        public static VectorB4 YXX_(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, 0); }
        public static VectorB4 YXYX(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.x); }
        public static VectorB4 YXYY(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.y); }
        public static VectorB4 YXYZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.z); }
        public static VectorB4 YXY_(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, 0); }
        public static VectorB4 YXZX(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.x); }
        public static VectorB4 YXZY(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.y); }
        public static VectorB4 YXZZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.z); }
        public static VectorB4 YXZ_(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, 0); }
        public static VectorB4 YX_X(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.x); }
        public static VectorB4 YX_Y(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.y); }
        public static VectorB4 YX_Z(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.z); }
        public static VectorB4 YX__(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, 0, 0); }
        public static VectorB4 YYXX(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.x); }
        public static VectorB4 YYXY(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.y); }
        public static VectorB4 YYXZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.z); }
        public static VectorB4 YYX_(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, 0); }
        public static VectorB4 YYYX(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.x); }
        public static VectorB4 YYYY(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.y); }
        public static VectorB4 YYYZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.z); }
        public static VectorB4 YYY_(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, 0); }
        public static VectorB4 YYZX(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.x); }
        public static VectorB4 YYZY(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.y); }
        public static VectorB4 YYZZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.z); }
        public static VectorB4 YYZ_(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, 0); }
        public static VectorB4 YY_X(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.x); }
        public static VectorB4 YY_Y(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.y); }
        public static VectorB4 YY_Z(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.z); }
        public static VectorB4 YY__(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, 0, 0); }
        public static VectorB4 YZXX(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.x); }
        public static VectorB4 YZXY(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.y); }
        public static VectorB4 YZXZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.z); }
        public static VectorB4 YZX_(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, 0); }
        public static VectorB4 YZYX(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.x); }
        public static VectorB4 YZYY(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.y); }
        public static VectorB4 YZYZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.z); }
        public static VectorB4 YZY_(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, 0); }
        public static VectorB4 YZZX(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.x); }
        public static VectorB4 YZZY(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.y); }
        public static VectorB4 YZZZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.z); }
        public static VectorB4 YZZ_(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, 0); }
        public static VectorB4 YZ_X(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.x); }
        public static VectorB4 YZ_Y(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.y); }
        public static VectorB4 YZ_Z(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.z); }
        public static VectorB4 YZ__(VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, 0, 0); }
        public static VectorB4 Y_XX(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.x); }
        public static VectorB4 Y_XY(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.y); }
        public static VectorB4 Y_XZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.z); }
        public static VectorB4 Y_X_(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.x, 0); }
        public static VectorB4 Y_YX(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.x); }
        public static VectorB4 Y_YY(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.y); }
        public static VectorB4 Y_YZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.z); }
        public static VectorB4 Y_Y_(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.y, 0); }
        public static VectorB4 Y_ZX(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.x); }
        public static VectorB4 Y_ZY(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.y); }
        public static VectorB4 Y_ZZ(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.z); }
        public static VectorB4 Y_Z_(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.z, 0); }
        public static VectorB4 Y__X(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.x); }
        public static VectorB4 Y__Y(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.y); }
        public static VectorB4 Y__Z(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.z); }
        public static VectorB4 Y___(VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, 0, 0); }
        public static VectorB4 ZXXX(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.x); }
        public static VectorB4 ZXXY(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.y); }
        public static VectorB4 ZXXZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.z); }
        public static VectorB4 ZXX_(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, 0); }
        public static VectorB4 ZXYX(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.x); }
        public static VectorB4 ZXYY(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.y); }
        public static VectorB4 ZXYZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.z); }
        public static VectorB4 ZXY_(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, 0); }
        public static VectorB4 ZXZX(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.x); }
        public static VectorB4 ZXZY(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.y); }
        public static VectorB4 ZXZZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.z); }
        public static VectorB4 ZXZ_(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, 0); }
        public static VectorB4 ZX_X(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.x); }
        public static VectorB4 ZX_Y(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.y); }
        public static VectorB4 ZX_Z(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.z); }
        public static VectorB4 ZX__(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, 0, 0); }
        public static VectorB4 ZYXX(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.x); }
        public static VectorB4 ZYXY(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.y); }
        public static VectorB4 ZYXZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.z); }
        public static VectorB4 ZYX_(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, 0); }
        public static VectorB4 ZYYX(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.x); }
        public static VectorB4 ZYYY(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.y); }
        public static VectorB4 ZYYZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.z); }
        public static VectorB4 ZYY_(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, 0); }
        public static VectorB4 ZYZX(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.x); }
        public static VectorB4 ZYZY(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.y); }
        public static VectorB4 ZYZZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.z); }
        public static VectorB4 ZYZ_(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, 0); }
        public static VectorB4 ZY_X(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.x); }
        public static VectorB4 ZY_Y(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.y); }
        public static VectorB4 ZY_Z(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.z); }
        public static VectorB4 ZY__(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, 0, 0); }
        public static VectorB4 ZZXX(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.x); }
        public static VectorB4 ZZXY(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.y); }
        public static VectorB4 ZZXZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.z); }
        public static VectorB4 ZZX_(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, 0); }
        public static VectorB4 ZZYX(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.x); }
        public static VectorB4 ZZYY(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.y); }
        public static VectorB4 ZZYZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.z); }
        public static VectorB4 ZZY_(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, 0); }
        public static VectorB4 ZZZX(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.x); }
        public static VectorB4 ZZZY(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.y); }
        public static VectorB4 ZZZZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.z); }
        public static VectorB4 ZZZ_(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, 0); }
        public static VectorB4 ZZ_X(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.x); }
        public static VectorB4 ZZ_Y(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.y); }
        public static VectorB4 ZZ_Z(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.z); }
        public static VectorB4 ZZ__(VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, 0, 0); }
        public static VectorB4 Z_XX(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.x); }
        public static VectorB4 Z_XY(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.y); }
        public static VectorB4 Z_XZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.z); }
        public static VectorB4 Z_X_(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.x, 0); }
        public static VectorB4 Z_YX(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.x); }
        public static VectorB4 Z_YY(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.y); }
        public static VectorB4 Z_YZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.z); }
        public static VectorB4 Z_Y_(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.y, 0); }
        public static VectorB4 Z_ZX(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.x); }
        public static VectorB4 Z_ZY(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.y); }
        public static VectorB4 Z_ZZ(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.z); }
        public static VectorB4 Z_Z_(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.z, 0); }
        public static VectorB4 Z__X(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.x); }
        public static VectorB4 Z__Y(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.y); }
        public static VectorB4 Z__Z(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.z); }
        public static VectorB4 Z___(VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, 0, 0); }
        public static VectorB4 _XXX(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.x); }
        public static VectorB4 _XXY(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.y); }
        public static VectorB4 _XXZ(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.z); }
        public static VectorB4 _XX_(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.x, 0); }
        public static VectorB4 _XYX(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.x); }
        public static VectorB4 _XYY(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.y); }
        public static VectorB4 _XYZ(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.z); }
        public static VectorB4 _XY_(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.y, 0); }
        public static VectorB4 _XZX(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.x); }
        public static VectorB4 _XZY(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.y); }
        public static VectorB4 _XZZ(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.z); }
        public static VectorB4 _XZ_(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.z, 0); }
        public static VectorB4 _X_X(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, 0, V.x); }
        public static VectorB4 _X_Y(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, 0, V.y); }
        public static VectorB4 _X_Z(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, 0, V.z); }
        public static VectorB4 _X__(VectorB3 V){ return VecOps.MkVectorB4(0, V.x, 0, 0); }
        public static VectorB4 _YXX(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.x); }
        public static VectorB4 _YXY(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.y); }
        public static VectorB4 _YXZ(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.z); }
        public static VectorB4 _YX_(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.x, 0); }
        public static VectorB4 _YYX(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.x); }
        public static VectorB4 _YYY(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.y); }
        public static VectorB4 _YYZ(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.z); }
        public static VectorB4 _YY_(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.y, 0); }
        public static VectorB4 _YZX(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.x); }
        public static VectorB4 _YZY(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.y); }
        public static VectorB4 _YZZ(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.z); }
        public static VectorB4 _YZ_(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.z, 0); }
        public static VectorB4 _Y_X(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, 0, V.x); }
        public static VectorB4 _Y_Y(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, 0, V.y); }
        public static VectorB4 _Y_Z(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, 0, V.z); }
        public static VectorB4 _Y__(VectorB3 V){ return VecOps.MkVectorB4(0, V.y, 0, 0); }
        public static VectorB4 _ZXX(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.x); }
        public static VectorB4 _ZXY(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.y); }
        public static VectorB4 _ZXZ(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.z); }
        public static VectorB4 _ZX_(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.x, 0); }
        public static VectorB4 _ZYX(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.x); }
        public static VectorB4 _ZYY(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.y); }
        public static VectorB4 _ZYZ(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.z); }
        public static VectorB4 _ZY_(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.y, 0); }
        public static VectorB4 _ZZX(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.x); }
        public static VectorB4 _ZZY(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.y); }
        public static VectorB4 _ZZZ(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.z); }
        public static VectorB4 _ZZ_(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.z, 0); }
        public static VectorB4 _Z_X(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, 0, V.x); }
        public static VectorB4 _Z_Y(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, 0, V.y); }
        public static VectorB4 _Z_Z(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, 0, V.z); }
        public static VectorB4 _Z__(VectorB3 V){ return VecOps.MkVectorB4(0, V.z, 0, 0); }
        public static VectorB4 __XX(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.x, V.x); }
        public static VectorB4 __XY(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.x, V.y); }
        public static VectorB4 __XZ(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.x, V.z); }
        public static VectorB4 __X_(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.x, 0); }
        public static VectorB4 __YX(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.y, V.x); }
        public static VectorB4 __YY(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.y, V.y); }
        public static VectorB4 __YZ(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.y, V.z); }
        public static VectorB4 __Y_(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.y, 0); }
        public static VectorB4 __ZX(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.z, V.x); }
        public static VectorB4 __ZY(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.z, V.y); }
        public static VectorB4 __ZZ(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.z, V.z); }
        public static VectorB4 __Z_(VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.z, 0); }
        public static VectorB4 ___X(VectorB3 V){ return VecOps.MkVectorB4(0, 0, 0, V.x); }
        public static VectorB4 ___Y(VectorB3 V){ return VecOps.MkVectorB4(0, 0, 0, V.y); }
        public static VectorB4 ___Z(VectorB3 V){ return VecOps.MkVectorB4(0, 0, 0, V.z); }
        public static VectorB2 XX(VectorB4 V){ return VecOps.MkVectorB2(V.x, V.x); }
        public static VectorB2 XY(VectorB4 V){ return VecOps.MkVectorB2(V.x, V.y); }
        public static VectorB2 XZ(VectorB4 V){ return VecOps.MkVectorB2(V.x, V.z); }
        public static VectorB2 XW(VectorB4 V){ return VecOps.MkVectorB2(V.x, V.w); }
        public static VectorB2 X_(VectorB4 V){ return VecOps.MkVectorB2(V.x, 0); }
        public static VectorB2 YX(VectorB4 V){ return VecOps.MkVectorB2(V.y, V.x); }
        public static VectorB2 YY(VectorB4 V){ return VecOps.MkVectorB2(V.y, V.y); }
        public static VectorB2 YZ(VectorB4 V){ return VecOps.MkVectorB2(V.y, V.z); }
        public static VectorB2 YW(VectorB4 V){ return VecOps.MkVectorB2(V.y, V.w); }
        public static VectorB2 Y_(VectorB4 V){ return VecOps.MkVectorB2(V.y, 0); }
        public static VectorB2 ZX(VectorB4 V){ return VecOps.MkVectorB2(V.z, V.x); }
        public static VectorB2 ZY(VectorB4 V){ return VecOps.MkVectorB2(V.z, V.y); }
        public static VectorB2 ZZ(VectorB4 V){ return VecOps.MkVectorB2(V.z, V.z); }
        public static VectorB2 ZW(VectorB4 V){ return VecOps.MkVectorB2(V.z, V.w); }
        public static VectorB2 Z_(VectorB4 V){ return VecOps.MkVectorB2(V.z, 0); }
        public static VectorB2 WX(VectorB4 V){ return VecOps.MkVectorB2(V.w, V.x); }
        public static VectorB2 WY(VectorB4 V){ return VecOps.MkVectorB2(V.w, V.y); }
        public static VectorB2 WZ(VectorB4 V){ return VecOps.MkVectorB2(V.w, V.z); }
        public static VectorB2 WW(VectorB4 V){ return VecOps.MkVectorB2(V.w, V.w); }
        public static VectorB2 W_(VectorB4 V){ return VecOps.MkVectorB2(V.w, 0); }
        public static VectorB2 _X(VectorB4 V){ return VecOps.MkVectorB2(0, V.x); }
        public static VectorB2 _Y(VectorB4 V){ return VecOps.MkVectorB2(0, V.y); }
        public static VectorB2 _Z(VectorB4 V){ return VecOps.MkVectorB2(0, V.z); }
        public static VectorB2 _W(VectorB4 V){ return VecOps.MkVectorB2(0, V.w); }
        public static VectorB3 XXX(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.x, V.x); }
        public static VectorB3 XXY(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.x, V.y); }
        public static VectorB3 XXZ(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.x, V.z); }
        public static VectorB3 XXW(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.x, V.w); }
        public static VectorB3 XX_(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.x, 0); }
        public static VectorB3 XYX(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.y, V.x); }
        public static VectorB3 XYY(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.y, V.y); }
        public static VectorB3 XYZ(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.y, V.z); }
        public static VectorB3 XYW(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.y, V.w); }
        public static VectorB3 XY_(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.y, 0); }
        public static VectorB3 XZX(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.z, V.x); }
        public static VectorB3 XZY(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.z, V.y); }
        public static VectorB3 XZZ(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.z, V.z); }
        public static VectorB3 XZW(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.z, V.w); }
        public static VectorB3 XZ_(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.z, 0); }
        public static VectorB3 XWX(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.w, V.x); }
        public static VectorB3 XWY(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.w, V.y); }
        public static VectorB3 XWZ(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.w, V.z); }
        public static VectorB3 XWW(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.w, V.w); }
        public static VectorB3 XW_(VectorB4 V){ return VecOps.MkVectorB3(V.x, V.w, 0); }
        public static VectorB3 X_X(VectorB4 V){ return VecOps.MkVectorB3(V.x, 0, V.x); }
        public static VectorB3 X_Y(VectorB4 V){ return VecOps.MkVectorB3(V.x, 0, V.y); }
        public static VectorB3 X_Z(VectorB4 V){ return VecOps.MkVectorB3(V.x, 0, V.z); }
        public static VectorB3 X_W(VectorB4 V){ return VecOps.MkVectorB3(V.x, 0, V.w); }
        public static VectorB3 X__(VectorB4 V){ return VecOps.MkVectorB3(V.x, 0, 0); }
        public static VectorB3 YXX(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.x, V.x); }
        public static VectorB3 YXY(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.x, V.y); }
        public static VectorB3 YXZ(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.x, V.z); }
        public static VectorB3 YXW(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.x, V.w); }
        public static VectorB3 YX_(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.x, 0); }
        public static VectorB3 YYX(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.y, V.x); }
        public static VectorB3 YYY(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.y, V.y); }
        public static VectorB3 YYZ(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.y, V.z); }
        public static VectorB3 YYW(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.y, V.w); }
        public static VectorB3 YY_(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.y, 0); }
        public static VectorB3 YZX(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.z, V.x); }
        public static VectorB3 YZY(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.z, V.y); }
        public static VectorB3 YZZ(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.z, V.z); }
        public static VectorB3 YZW(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.z, V.w); }
        public static VectorB3 YZ_(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.z, 0); }
        public static VectorB3 YWX(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.w, V.x); }
        public static VectorB3 YWY(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.w, V.y); }
        public static VectorB3 YWZ(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.w, V.z); }
        public static VectorB3 YWW(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.w, V.w); }
        public static VectorB3 YW_(VectorB4 V){ return VecOps.MkVectorB3(V.y, V.w, 0); }
        public static VectorB3 Y_X(VectorB4 V){ return VecOps.MkVectorB3(V.y, 0, V.x); }
        public static VectorB3 Y_Y(VectorB4 V){ return VecOps.MkVectorB3(V.y, 0, V.y); }
        public static VectorB3 Y_Z(VectorB4 V){ return VecOps.MkVectorB3(V.y, 0, V.z); }
        public static VectorB3 Y_W(VectorB4 V){ return VecOps.MkVectorB3(V.y, 0, V.w); }
        public static VectorB3 Y__(VectorB4 V){ return VecOps.MkVectorB3(V.y, 0, 0); }
        public static VectorB3 ZXX(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.x, V.x); }
        public static VectorB3 ZXY(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.x, V.y); }
        public static VectorB3 ZXZ(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.x, V.z); }
        public static VectorB3 ZXW(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.x, V.w); }
        public static VectorB3 ZX_(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.x, 0); }
        public static VectorB3 ZYX(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.y, V.x); }
        public static VectorB3 ZYY(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.y, V.y); }
        public static VectorB3 ZYZ(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.y, V.z); }
        public static VectorB3 ZYW(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.y, V.w); }
        public static VectorB3 ZY_(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.y, 0); }
        public static VectorB3 ZZX(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.z, V.x); }
        public static VectorB3 ZZY(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.z, V.y); }
        public static VectorB3 ZZZ(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.z, V.z); }
        public static VectorB3 ZZW(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.z, V.w); }
        public static VectorB3 ZZ_(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.z, 0); }
        public static VectorB3 ZWX(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.w, V.x); }
        public static VectorB3 ZWY(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.w, V.y); }
        public static VectorB3 ZWZ(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.w, V.z); }
        public static VectorB3 ZWW(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.w, V.w); }
        public static VectorB3 ZW_(VectorB4 V){ return VecOps.MkVectorB3(V.z, V.w, 0); }
        public static VectorB3 Z_X(VectorB4 V){ return VecOps.MkVectorB3(V.z, 0, V.x); }
        public static VectorB3 Z_Y(VectorB4 V){ return VecOps.MkVectorB3(V.z, 0, V.y); }
        public static VectorB3 Z_Z(VectorB4 V){ return VecOps.MkVectorB3(V.z, 0, V.z); }
        public static VectorB3 Z_W(VectorB4 V){ return VecOps.MkVectorB3(V.z, 0, V.w); }
        public static VectorB3 Z__(VectorB4 V){ return VecOps.MkVectorB3(V.z, 0, 0); }
        public static VectorB3 WXX(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.x, V.x); }
        public static VectorB3 WXY(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.x, V.y); }
        public static VectorB3 WXZ(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.x, V.z); }
        public static VectorB3 WXW(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.x, V.w); }
        public static VectorB3 WX_(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.x, 0); }
        public static VectorB3 WYX(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.y, V.x); }
        public static VectorB3 WYY(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.y, V.y); }
        public static VectorB3 WYZ(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.y, V.z); }
        public static VectorB3 WYW(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.y, V.w); }
        public static VectorB3 WY_(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.y, 0); }
        public static VectorB3 WZX(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.z, V.x); }
        public static VectorB3 WZY(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.z, V.y); }
        public static VectorB3 WZZ(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.z, V.z); }
        public static VectorB3 WZW(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.z, V.w); }
        public static VectorB3 WZ_(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.z, 0); }
        public static VectorB3 WWX(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.w, V.x); }
        public static VectorB3 WWY(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.w, V.y); }
        public static VectorB3 WWZ(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.w, V.z); }
        public static VectorB3 WWW(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.w, V.w); }
        public static VectorB3 WW_(VectorB4 V){ return VecOps.MkVectorB3(V.w, V.w, 0); }
        public static VectorB3 W_X(VectorB4 V){ return VecOps.MkVectorB3(V.w, 0, V.x); }
        public static VectorB3 W_Y(VectorB4 V){ return VecOps.MkVectorB3(V.w, 0, V.y); }
        public static VectorB3 W_Z(VectorB4 V){ return VecOps.MkVectorB3(V.w, 0, V.z); }
        public static VectorB3 W_W(VectorB4 V){ return VecOps.MkVectorB3(V.w, 0, V.w); }
        public static VectorB3 W__(VectorB4 V){ return VecOps.MkVectorB3(V.w, 0, 0); }
        public static VectorB3 _XX(VectorB4 V){ return VecOps.MkVectorB3(0, V.x, V.x); }
        public static VectorB3 _XY(VectorB4 V){ return VecOps.MkVectorB3(0, V.x, V.y); }
        public static VectorB3 _XZ(VectorB4 V){ return VecOps.MkVectorB3(0, V.x, V.z); }
        public static VectorB3 _XW(VectorB4 V){ return VecOps.MkVectorB3(0, V.x, V.w); }
        public static VectorB3 _X_(VectorB4 V){ return VecOps.MkVectorB3(0, V.x, 0); }
        public static VectorB3 _YX(VectorB4 V){ return VecOps.MkVectorB3(0, V.y, V.x); }
        public static VectorB3 _YY(VectorB4 V){ return VecOps.MkVectorB3(0, V.y, V.y); }
        public static VectorB3 _YZ(VectorB4 V){ return VecOps.MkVectorB3(0, V.y, V.z); }
        public static VectorB3 _YW(VectorB4 V){ return VecOps.MkVectorB3(0, V.y, V.w); }
        public static VectorB3 _Y_(VectorB4 V){ return VecOps.MkVectorB3(0, V.y, 0); }
        public static VectorB3 _ZX(VectorB4 V){ return VecOps.MkVectorB3(0, V.z, V.x); }
        public static VectorB3 _ZY(VectorB4 V){ return VecOps.MkVectorB3(0, V.z, V.y); }
        public static VectorB3 _ZZ(VectorB4 V){ return VecOps.MkVectorB3(0, V.z, V.z); }
        public static VectorB3 _ZW(VectorB4 V){ return VecOps.MkVectorB3(0, V.z, V.w); }
        public static VectorB3 _Z_(VectorB4 V){ return VecOps.MkVectorB3(0, V.z, 0); }
        public static VectorB3 _WX(VectorB4 V){ return VecOps.MkVectorB3(0, V.w, V.x); }
        public static VectorB3 _WY(VectorB4 V){ return VecOps.MkVectorB3(0, V.w, V.y); }
        public static VectorB3 _WZ(VectorB4 V){ return VecOps.MkVectorB3(0, V.w, V.z); }
        public static VectorB3 _WW(VectorB4 V){ return VecOps.MkVectorB3(0, V.w, V.w); }
        public static VectorB3 _W_(VectorB4 V){ return VecOps.MkVectorB3(0, V.w, 0); }
        public static VectorB3 __X(VectorB4 V){ return VecOps.MkVectorB3(0, 0, V.x); }
        public static VectorB3 __Y(VectorB4 V){ return VecOps.MkVectorB3(0, 0, V.y); }
        public static VectorB3 __Z(VectorB4 V){ return VecOps.MkVectorB3(0, 0, V.z); }
        public static VectorB3 __W(VectorB4 V){ return VecOps.MkVectorB3(0, 0, V.w); }
        public static VectorB4 XXXX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.x); }
        public static VectorB4 XXXY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.y); }
        public static VectorB4 XXXZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.z); }
        public static VectorB4 XXXW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.w); }
        public static VectorB4 XXX_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, 0); }
        public static VectorB4 XXYX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.x); }
        public static VectorB4 XXYY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.y); }
        public static VectorB4 XXYZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.z); }
        public static VectorB4 XXYW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.w); }
        public static VectorB4 XXY_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, 0); }
        public static VectorB4 XXZX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.x); }
        public static VectorB4 XXZY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.y); }
        public static VectorB4 XXZZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.z); }
        public static VectorB4 XXZW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.w); }
        public static VectorB4 XXZ_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, 0); }
        public static VectorB4 XXWX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.w, V.x); }
        public static VectorB4 XXWY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.w, V.y); }
        public static VectorB4 XXWZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.w, V.z); }
        public static VectorB4 XXWW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.w, V.w); }
        public static VectorB4 XXW_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.w, 0); }
        public static VectorB4 XX_X(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.x); }
        public static VectorB4 XX_Y(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.y); }
        public static VectorB4 XX_Z(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.z); }
        public static VectorB4 XX_W(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.w); }
        public static VectorB4 XX__(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, 0, 0); }
        public static VectorB4 XYXX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.x); }
        public static VectorB4 XYXY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.y); }
        public static VectorB4 XYXZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.z); }
        public static VectorB4 XYXW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.w); }
        public static VectorB4 XYX_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, 0); }
        public static VectorB4 XYYX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.x); }
        public static VectorB4 XYYY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.y); }
        public static VectorB4 XYYZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.z); }
        public static VectorB4 XYYW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.w); }
        public static VectorB4 XYY_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, 0); }
        public static VectorB4 XYZX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.x); }
        public static VectorB4 XYZY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.y); }
        public static VectorB4 XYZZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.z); }
        public static VectorB4 XYZW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.w); }
        public static VectorB4 XYZ_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, 0); }
        public static VectorB4 XYWX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.w, V.x); }
        public static VectorB4 XYWY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.w, V.y); }
        public static VectorB4 XYWZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.w, V.z); }
        public static VectorB4 XYWW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.w, V.w); }
        public static VectorB4 XYW_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.w, 0); }
        public static VectorB4 XY_X(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.x); }
        public static VectorB4 XY_Y(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.y); }
        public static VectorB4 XY_Z(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.z); }
        public static VectorB4 XY_W(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.w); }
        public static VectorB4 XY__(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, 0, 0); }
        public static VectorB4 XZXX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.x); }
        public static VectorB4 XZXY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.y); }
        public static VectorB4 XZXZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.z); }
        public static VectorB4 XZXW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.w); }
        public static VectorB4 XZX_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, 0); }
        public static VectorB4 XZYX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.x); }
        public static VectorB4 XZYY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.y); }
        public static VectorB4 XZYZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.z); }
        public static VectorB4 XZYW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.w); }
        public static VectorB4 XZY_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, 0); }
        public static VectorB4 XZZX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.x); }
        public static VectorB4 XZZY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.y); }
        public static VectorB4 XZZZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.z); }
        public static VectorB4 XZZW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.w); }
        public static VectorB4 XZZ_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, 0); }
        public static VectorB4 XZWX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.w, V.x); }
        public static VectorB4 XZWY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.w, V.y); }
        public static VectorB4 XZWZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.w, V.z); }
        public static VectorB4 XZWW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.w, V.w); }
        public static VectorB4 XZW_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.w, 0); }
        public static VectorB4 XZ_X(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.x); }
        public static VectorB4 XZ_Y(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.y); }
        public static VectorB4 XZ_Z(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.z); }
        public static VectorB4 XZ_W(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.w); }
        public static VectorB4 XZ__(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, 0, 0); }
        public static VectorB4 XWXX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.x, V.x); }
        public static VectorB4 XWXY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.x, V.y); }
        public static VectorB4 XWXZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.x, V.z); }
        public static VectorB4 XWXW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.x, V.w); }
        public static VectorB4 XWX_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.x, 0); }
        public static VectorB4 XWYX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.y, V.x); }
        public static VectorB4 XWYY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.y, V.y); }
        public static VectorB4 XWYZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.y, V.z); }
        public static VectorB4 XWYW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.y, V.w); }
        public static VectorB4 XWY_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.y, 0); }
        public static VectorB4 XWZX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.z, V.x); }
        public static VectorB4 XWZY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.z, V.y); }
        public static VectorB4 XWZZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.z, V.z); }
        public static VectorB4 XWZW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.z, V.w); }
        public static VectorB4 XWZ_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.z, 0); }
        public static VectorB4 XWWX(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.w, V.x); }
        public static VectorB4 XWWY(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.w, V.y); }
        public static VectorB4 XWWZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.w, V.z); }
        public static VectorB4 XWWW(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.w, V.w); }
        public static VectorB4 XWW_(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.w, 0); }
        public static VectorB4 XW_X(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, 0, V.x); }
        public static VectorB4 XW_Y(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, 0, V.y); }
        public static VectorB4 XW_Z(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, 0, V.z); }
        public static VectorB4 XW_W(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, 0, V.w); }
        public static VectorB4 XW__(VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, 0, 0); }
        public static VectorB4 X_XX(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.x); }
        public static VectorB4 X_XY(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.y); }
        public static VectorB4 X_XZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.z); }
        public static VectorB4 X_XW(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.w); }
        public static VectorB4 X_X_(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.x, 0); }
        public static VectorB4 X_YX(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.x); }
        public static VectorB4 X_YY(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.y); }
        public static VectorB4 X_YZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.z); }
        public static VectorB4 X_YW(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.w); }
        public static VectorB4 X_Y_(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.y, 0); }
        public static VectorB4 X_ZX(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.x); }
        public static VectorB4 X_ZY(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.y); }
        public static VectorB4 X_ZZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.z); }
        public static VectorB4 X_ZW(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.w); }
        public static VectorB4 X_Z_(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.z, 0); }
        public static VectorB4 X_WX(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.w, V.x); }
        public static VectorB4 X_WY(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.w, V.y); }
        public static VectorB4 X_WZ(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.w, V.z); }
        public static VectorB4 X_WW(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.w, V.w); }
        public static VectorB4 X_W_(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.w, 0); }
        public static VectorB4 X__X(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.x); }
        public static VectorB4 X__Y(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.y); }
        public static VectorB4 X__Z(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.z); }
        public static VectorB4 X__W(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.w); }
        public static VectorB4 X___(VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, 0, 0); }
        public static VectorB4 YXXX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.x); }
        public static VectorB4 YXXY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.y); }
        public static VectorB4 YXXZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.z); }
        public static VectorB4 YXXW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.w); }
        public static VectorB4 YXX_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, 0); }
        public static VectorB4 YXYX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.x); }
        public static VectorB4 YXYY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.y); }
        public static VectorB4 YXYZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.z); }
        public static VectorB4 YXYW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.w); }
        public static VectorB4 YXY_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, 0); }
        public static VectorB4 YXZX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.x); }
        public static VectorB4 YXZY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.y); }
        public static VectorB4 YXZZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.z); }
        public static VectorB4 YXZW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.w); }
        public static VectorB4 YXZ_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, 0); }
        public static VectorB4 YXWX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.w, V.x); }
        public static VectorB4 YXWY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.w, V.y); }
        public static VectorB4 YXWZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.w, V.z); }
        public static VectorB4 YXWW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.w, V.w); }
        public static VectorB4 YXW_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.w, 0); }
        public static VectorB4 YX_X(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.x); }
        public static VectorB4 YX_Y(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.y); }
        public static VectorB4 YX_Z(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.z); }
        public static VectorB4 YX_W(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.w); }
        public static VectorB4 YX__(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, 0, 0); }
        public static VectorB4 YYXX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.x); }
        public static VectorB4 YYXY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.y); }
        public static VectorB4 YYXZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.z); }
        public static VectorB4 YYXW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.w); }
        public static VectorB4 YYX_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, 0); }
        public static VectorB4 YYYX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.x); }
        public static VectorB4 YYYY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.y); }
        public static VectorB4 YYYZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.z); }
        public static VectorB4 YYYW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.w); }
        public static VectorB4 YYY_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, 0); }
        public static VectorB4 YYZX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.x); }
        public static VectorB4 YYZY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.y); }
        public static VectorB4 YYZZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.z); }
        public static VectorB4 YYZW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.w); }
        public static VectorB4 YYZ_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, 0); }
        public static VectorB4 YYWX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.w, V.x); }
        public static VectorB4 YYWY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.w, V.y); }
        public static VectorB4 YYWZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.w, V.z); }
        public static VectorB4 YYWW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.w, V.w); }
        public static VectorB4 YYW_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.w, 0); }
        public static VectorB4 YY_X(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.x); }
        public static VectorB4 YY_Y(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.y); }
        public static VectorB4 YY_Z(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.z); }
        public static VectorB4 YY_W(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.w); }
        public static VectorB4 YY__(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, 0, 0); }
        public static VectorB4 YZXX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.x); }
        public static VectorB4 YZXY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.y); }
        public static VectorB4 YZXZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.z); }
        public static VectorB4 YZXW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.w); }
        public static VectorB4 YZX_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, 0); }
        public static VectorB4 YZYX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.x); }
        public static VectorB4 YZYY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.y); }
        public static VectorB4 YZYZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.z); }
        public static VectorB4 YZYW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.w); }
        public static VectorB4 YZY_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, 0); }
        public static VectorB4 YZZX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.x); }
        public static VectorB4 YZZY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.y); }
        public static VectorB4 YZZZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.z); }
        public static VectorB4 YZZW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.w); }
        public static VectorB4 YZZ_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, 0); }
        public static VectorB4 YZWX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.w, V.x); }
        public static VectorB4 YZWY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.w, V.y); }
        public static VectorB4 YZWZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.w, V.z); }
        public static VectorB4 YZWW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.w, V.w); }
        public static VectorB4 YZW_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.w, 0); }
        public static VectorB4 YZ_X(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.x); }
        public static VectorB4 YZ_Y(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.y); }
        public static VectorB4 YZ_Z(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.z); }
        public static VectorB4 YZ_W(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.w); }
        public static VectorB4 YZ__(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, 0, 0); }
        public static VectorB4 YWXX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.x, V.x); }
        public static VectorB4 YWXY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.x, V.y); }
        public static VectorB4 YWXZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.x, V.z); }
        public static VectorB4 YWXW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.x, V.w); }
        public static VectorB4 YWX_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.x, 0); }
        public static VectorB4 YWYX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.y, V.x); }
        public static VectorB4 YWYY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.y, V.y); }
        public static VectorB4 YWYZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.y, V.z); }
        public static VectorB4 YWYW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.y, V.w); }
        public static VectorB4 YWY_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.y, 0); }
        public static VectorB4 YWZX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.z, V.x); }
        public static VectorB4 YWZY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.z, V.y); }
        public static VectorB4 YWZZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.z, V.z); }
        public static VectorB4 YWZW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.z, V.w); }
        public static VectorB4 YWZ_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.z, 0); }
        public static VectorB4 YWWX(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.w, V.x); }
        public static VectorB4 YWWY(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.w, V.y); }
        public static VectorB4 YWWZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.w, V.z); }
        public static VectorB4 YWWW(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.w, V.w); }
        public static VectorB4 YWW_(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.w, 0); }
        public static VectorB4 YW_X(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, 0, V.x); }
        public static VectorB4 YW_Y(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, 0, V.y); }
        public static VectorB4 YW_Z(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, 0, V.z); }
        public static VectorB4 YW_W(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, 0, V.w); }
        public static VectorB4 YW__(VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, 0, 0); }
        public static VectorB4 Y_XX(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.x); }
        public static VectorB4 Y_XY(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.y); }
        public static VectorB4 Y_XZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.z); }
        public static VectorB4 Y_XW(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.w); }
        public static VectorB4 Y_X_(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.x, 0); }
        public static VectorB4 Y_YX(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.x); }
        public static VectorB4 Y_YY(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.y); }
        public static VectorB4 Y_YZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.z); }
        public static VectorB4 Y_YW(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.w); }
        public static VectorB4 Y_Y_(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.y, 0); }
        public static VectorB4 Y_ZX(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.x); }
        public static VectorB4 Y_ZY(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.y); }
        public static VectorB4 Y_ZZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.z); }
        public static VectorB4 Y_ZW(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.w); }
        public static VectorB4 Y_Z_(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.z, 0); }
        public static VectorB4 Y_WX(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.w, V.x); }
        public static VectorB4 Y_WY(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.w, V.y); }
        public static VectorB4 Y_WZ(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.w, V.z); }
        public static VectorB4 Y_WW(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.w, V.w); }
        public static VectorB4 Y_W_(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.w, 0); }
        public static VectorB4 Y__X(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.x); }
        public static VectorB4 Y__Y(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.y); }
        public static VectorB4 Y__Z(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.z); }
        public static VectorB4 Y__W(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.w); }
        public static VectorB4 Y___(VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, 0, 0); }
        public static VectorB4 ZXXX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.x); }
        public static VectorB4 ZXXY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.y); }
        public static VectorB4 ZXXZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.z); }
        public static VectorB4 ZXXW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.w); }
        public static VectorB4 ZXX_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, 0); }
        public static VectorB4 ZXYX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.x); }
        public static VectorB4 ZXYY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.y); }
        public static VectorB4 ZXYZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.z); }
        public static VectorB4 ZXYW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.w); }
        public static VectorB4 ZXY_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, 0); }
        public static VectorB4 ZXZX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.x); }
        public static VectorB4 ZXZY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.y); }
        public static VectorB4 ZXZZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.z); }
        public static VectorB4 ZXZW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.w); }
        public static VectorB4 ZXZ_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, 0); }
        public static VectorB4 ZXWX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.w, V.x); }
        public static VectorB4 ZXWY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.w, V.y); }
        public static VectorB4 ZXWZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.w, V.z); }
        public static VectorB4 ZXWW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.w, V.w); }
        public static VectorB4 ZXW_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.w, 0); }
        public static VectorB4 ZX_X(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.x); }
        public static VectorB4 ZX_Y(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.y); }
        public static VectorB4 ZX_Z(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.z); }
        public static VectorB4 ZX_W(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.w); }
        public static VectorB4 ZX__(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, 0, 0); }
        public static VectorB4 ZYXX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.x); }
        public static VectorB4 ZYXY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.y); }
        public static VectorB4 ZYXZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.z); }
        public static VectorB4 ZYXW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.w); }
        public static VectorB4 ZYX_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, 0); }
        public static VectorB4 ZYYX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.x); }
        public static VectorB4 ZYYY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.y); }
        public static VectorB4 ZYYZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.z); }
        public static VectorB4 ZYYW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.w); }
        public static VectorB4 ZYY_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, 0); }
        public static VectorB4 ZYZX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.x); }
        public static VectorB4 ZYZY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.y); }
        public static VectorB4 ZYZZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.z); }
        public static VectorB4 ZYZW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.w); }
        public static VectorB4 ZYZ_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, 0); }
        public static VectorB4 ZYWX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.w, V.x); }
        public static VectorB4 ZYWY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.w, V.y); }
        public static VectorB4 ZYWZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.w, V.z); }
        public static VectorB4 ZYWW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.w, V.w); }
        public static VectorB4 ZYW_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.w, 0); }
        public static VectorB4 ZY_X(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.x); }
        public static VectorB4 ZY_Y(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.y); }
        public static VectorB4 ZY_Z(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.z); }
        public static VectorB4 ZY_W(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.w); }
        public static VectorB4 ZY__(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, 0, 0); }
        public static VectorB4 ZZXX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.x); }
        public static VectorB4 ZZXY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.y); }
        public static VectorB4 ZZXZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.z); }
        public static VectorB4 ZZXW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.w); }
        public static VectorB4 ZZX_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, 0); }
        public static VectorB4 ZZYX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.x); }
        public static VectorB4 ZZYY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.y); }
        public static VectorB4 ZZYZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.z); }
        public static VectorB4 ZZYW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.w); }
        public static VectorB4 ZZY_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, 0); }
        public static VectorB4 ZZZX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.x); }
        public static VectorB4 ZZZY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.y); }
        public static VectorB4 ZZZZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.z); }
        public static VectorB4 ZZZW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.w); }
        public static VectorB4 ZZZ_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, 0); }
        public static VectorB4 ZZWX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.w, V.x); }
        public static VectorB4 ZZWY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.w, V.y); }
        public static VectorB4 ZZWZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.w, V.z); }
        public static VectorB4 ZZWW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.w, V.w); }
        public static VectorB4 ZZW_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.w, 0); }
        public static VectorB4 ZZ_X(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.x); }
        public static VectorB4 ZZ_Y(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.y); }
        public static VectorB4 ZZ_Z(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.z); }
        public static VectorB4 ZZ_W(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.w); }
        public static VectorB4 ZZ__(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, 0, 0); }
        public static VectorB4 ZWXX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.x, V.x); }
        public static VectorB4 ZWXY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.x, V.y); }
        public static VectorB4 ZWXZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.x, V.z); }
        public static VectorB4 ZWXW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.x, V.w); }
        public static VectorB4 ZWX_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.x, 0); }
        public static VectorB4 ZWYX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.y, V.x); }
        public static VectorB4 ZWYY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.y, V.y); }
        public static VectorB4 ZWYZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.y, V.z); }
        public static VectorB4 ZWYW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.y, V.w); }
        public static VectorB4 ZWY_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.y, 0); }
        public static VectorB4 ZWZX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.z, V.x); }
        public static VectorB4 ZWZY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.z, V.y); }
        public static VectorB4 ZWZZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.z, V.z); }
        public static VectorB4 ZWZW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.z, V.w); }
        public static VectorB4 ZWZ_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.z, 0); }
        public static VectorB4 ZWWX(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.w, V.x); }
        public static VectorB4 ZWWY(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.w, V.y); }
        public static VectorB4 ZWWZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.w, V.z); }
        public static VectorB4 ZWWW(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.w, V.w); }
        public static VectorB4 ZWW_(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.w, 0); }
        public static VectorB4 ZW_X(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, 0, V.x); }
        public static VectorB4 ZW_Y(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, 0, V.y); }
        public static VectorB4 ZW_Z(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, 0, V.z); }
        public static VectorB4 ZW_W(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, 0, V.w); }
        public static VectorB4 ZW__(VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, 0, 0); }
        public static VectorB4 Z_XX(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.x); }
        public static VectorB4 Z_XY(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.y); }
        public static VectorB4 Z_XZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.z); }
        public static VectorB4 Z_XW(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.w); }
        public static VectorB4 Z_X_(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.x, 0); }
        public static VectorB4 Z_YX(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.x); }
        public static VectorB4 Z_YY(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.y); }
        public static VectorB4 Z_YZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.z); }
        public static VectorB4 Z_YW(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.w); }
        public static VectorB4 Z_Y_(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.y, 0); }
        public static VectorB4 Z_ZX(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.x); }
        public static VectorB4 Z_ZY(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.y); }
        public static VectorB4 Z_ZZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.z); }
        public static VectorB4 Z_ZW(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.w); }
        public static VectorB4 Z_Z_(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.z, 0); }
        public static VectorB4 Z_WX(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.w, V.x); }
        public static VectorB4 Z_WY(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.w, V.y); }
        public static VectorB4 Z_WZ(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.w, V.z); }
        public static VectorB4 Z_WW(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.w, V.w); }
        public static VectorB4 Z_W_(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.w, 0); }
        public static VectorB4 Z__X(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.x); }
        public static VectorB4 Z__Y(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.y); }
        public static VectorB4 Z__Z(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.z); }
        public static VectorB4 Z__W(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.w); }
        public static VectorB4 Z___(VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, 0, 0); }
        public static VectorB4 WXXX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.x, V.x); }
        public static VectorB4 WXXY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.x, V.y); }
        public static VectorB4 WXXZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.x, V.z); }
        public static VectorB4 WXXW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.x, V.w); }
        public static VectorB4 WXX_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.x, 0); }
        public static VectorB4 WXYX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.y, V.x); }
        public static VectorB4 WXYY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.y, V.y); }
        public static VectorB4 WXYZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.y, V.z); }
        public static VectorB4 WXYW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.y, V.w); }
        public static VectorB4 WXY_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.y, 0); }
        public static VectorB4 WXZX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.z, V.x); }
        public static VectorB4 WXZY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.z, V.y); }
        public static VectorB4 WXZZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.z, V.z); }
        public static VectorB4 WXZW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.z, V.w); }
        public static VectorB4 WXZ_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.z, 0); }
        public static VectorB4 WXWX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.w, V.x); }
        public static VectorB4 WXWY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.w, V.y); }
        public static VectorB4 WXWZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.w, V.z); }
        public static VectorB4 WXWW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.w, V.w); }
        public static VectorB4 WXW_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.w, 0); }
        public static VectorB4 WX_X(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, 0, V.x); }
        public static VectorB4 WX_Y(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, 0, V.y); }
        public static VectorB4 WX_Z(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, 0, V.z); }
        public static VectorB4 WX_W(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, 0, V.w); }
        public static VectorB4 WX__(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, 0, 0); }
        public static VectorB4 WYXX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.x, V.x); }
        public static VectorB4 WYXY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.x, V.y); }
        public static VectorB4 WYXZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.x, V.z); }
        public static VectorB4 WYXW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.x, V.w); }
        public static VectorB4 WYX_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.x, 0); }
        public static VectorB4 WYYX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.y, V.x); }
        public static VectorB4 WYYY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.y, V.y); }
        public static VectorB4 WYYZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.y, V.z); }
        public static VectorB4 WYYW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.y, V.w); }
        public static VectorB4 WYY_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.y, 0); }
        public static VectorB4 WYZX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.z, V.x); }
        public static VectorB4 WYZY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.z, V.y); }
        public static VectorB4 WYZZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.z, V.z); }
        public static VectorB4 WYZW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.z, V.w); }
        public static VectorB4 WYZ_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.z, 0); }
        public static VectorB4 WYWX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.w, V.x); }
        public static VectorB4 WYWY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.w, V.y); }
        public static VectorB4 WYWZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.w, V.z); }
        public static VectorB4 WYWW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.w, V.w); }
        public static VectorB4 WYW_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.w, 0); }
        public static VectorB4 WY_X(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, 0, V.x); }
        public static VectorB4 WY_Y(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, 0, V.y); }
        public static VectorB4 WY_Z(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, 0, V.z); }
        public static VectorB4 WY_W(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, 0, V.w); }
        public static VectorB4 WY__(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, 0, 0); }
        public static VectorB4 WZXX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.x, V.x); }
        public static VectorB4 WZXY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.x, V.y); }
        public static VectorB4 WZXZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.x, V.z); }
        public static VectorB4 WZXW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.x, V.w); }
        public static VectorB4 WZX_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.x, 0); }
        public static VectorB4 WZYX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.y, V.x); }
        public static VectorB4 WZYY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.y, V.y); }
        public static VectorB4 WZYZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.y, V.z); }
        public static VectorB4 WZYW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.y, V.w); }
        public static VectorB4 WZY_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.y, 0); }
        public static VectorB4 WZZX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.z, V.x); }
        public static VectorB4 WZZY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.z, V.y); }
        public static VectorB4 WZZZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.z, V.z); }
        public static VectorB4 WZZW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.z, V.w); }
        public static VectorB4 WZZ_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.z, 0); }
        public static VectorB4 WZWX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.w, V.x); }
        public static VectorB4 WZWY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.w, V.y); }
        public static VectorB4 WZWZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.w, V.z); }
        public static VectorB4 WZWW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.w, V.w); }
        public static VectorB4 WZW_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.w, 0); }
        public static VectorB4 WZ_X(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, 0, V.x); }
        public static VectorB4 WZ_Y(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, 0, V.y); }
        public static VectorB4 WZ_Z(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, 0, V.z); }
        public static VectorB4 WZ_W(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, 0, V.w); }
        public static VectorB4 WZ__(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, 0, 0); }
        public static VectorB4 WWXX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.x, V.x); }
        public static VectorB4 WWXY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.x, V.y); }
        public static VectorB4 WWXZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.x, V.z); }
        public static VectorB4 WWXW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.x, V.w); }
        public static VectorB4 WWX_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.x, 0); }
        public static VectorB4 WWYX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.y, V.x); }
        public static VectorB4 WWYY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.y, V.y); }
        public static VectorB4 WWYZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.y, V.z); }
        public static VectorB4 WWYW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.y, V.w); }
        public static VectorB4 WWY_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.y, 0); }
        public static VectorB4 WWZX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.z, V.x); }
        public static VectorB4 WWZY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.z, V.y); }
        public static VectorB4 WWZZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.z, V.z); }
        public static VectorB4 WWZW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.z, V.w); }
        public static VectorB4 WWZ_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.z, 0); }
        public static VectorB4 WWWX(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.w, V.x); }
        public static VectorB4 WWWY(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.w, V.y); }
        public static VectorB4 WWWZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.w, V.z); }
        public static VectorB4 WWWW(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.w, V.w); }
        public static VectorB4 WWW_(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.w, 0); }
        public static VectorB4 WW_X(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, 0, V.x); }
        public static VectorB4 WW_Y(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, 0, V.y); }
        public static VectorB4 WW_Z(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, 0, V.z); }
        public static VectorB4 WW_W(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, 0, V.w); }
        public static VectorB4 WW__(VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, 0, 0); }
        public static VectorB4 W_XX(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.x, V.x); }
        public static VectorB4 W_XY(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.x, V.y); }
        public static VectorB4 W_XZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.x, V.z); }
        public static VectorB4 W_XW(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.x, V.w); }
        public static VectorB4 W_X_(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.x, 0); }
        public static VectorB4 W_YX(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.y, V.x); }
        public static VectorB4 W_YY(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.y, V.y); }
        public static VectorB4 W_YZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.y, V.z); }
        public static VectorB4 W_YW(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.y, V.w); }
        public static VectorB4 W_Y_(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.y, 0); }
        public static VectorB4 W_ZX(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.z, V.x); }
        public static VectorB4 W_ZY(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.z, V.y); }
        public static VectorB4 W_ZZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.z, V.z); }
        public static VectorB4 W_ZW(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.z, V.w); }
        public static VectorB4 W_Z_(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.z, 0); }
        public static VectorB4 W_WX(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.w, V.x); }
        public static VectorB4 W_WY(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.w, V.y); }
        public static VectorB4 W_WZ(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.w, V.z); }
        public static VectorB4 W_WW(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.w, V.w); }
        public static VectorB4 W_W_(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.w, 0); }
        public static VectorB4 W__X(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, 0, V.x); }
        public static VectorB4 W__Y(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, 0, V.y); }
        public static VectorB4 W__Z(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, 0, V.z); }
        public static VectorB4 W__W(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, 0, V.w); }
        public static VectorB4 W___(VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, 0, 0); }
        public static VectorB4 _XXX(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.x); }
        public static VectorB4 _XXY(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.y); }
        public static VectorB4 _XXZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.z); }
        public static VectorB4 _XXW(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.w); }
        public static VectorB4 _XX_(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.x, 0); }
        public static VectorB4 _XYX(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.x); }
        public static VectorB4 _XYY(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.y); }
        public static VectorB4 _XYZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.z); }
        public static VectorB4 _XYW(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.w); }
        public static VectorB4 _XY_(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.y, 0); }
        public static VectorB4 _XZX(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.x); }
        public static VectorB4 _XZY(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.y); }
        public static VectorB4 _XZZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.z); }
        public static VectorB4 _XZW(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.w); }
        public static VectorB4 _XZ_(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.z, 0); }
        public static VectorB4 _XWX(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.w, V.x); }
        public static VectorB4 _XWY(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.w, V.y); }
        public static VectorB4 _XWZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.w, V.z); }
        public static VectorB4 _XWW(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.w, V.w); }
        public static VectorB4 _XW_(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.w, 0); }
        public static VectorB4 _X_X(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, 0, V.x); }
        public static VectorB4 _X_Y(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, 0, V.y); }
        public static VectorB4 _X_Z(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, 0, V.z); }
        public static VectorB4 _X_W(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, 0, V.w); }
        public static VectorB4 _X__(VectorB4 V){ return VecOps.MkVectorB4(0, V.x, 0, 0); }
        public static VectorB4 _YXX(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.x); }
        public static VectorB4 _YXY(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.y); }
        public static VectorB4 _YXZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.z); }
        public static VectorB4 _YXW(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.w); }
        public static VectorB4 _YX_(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.x, 0); }
        public static VectorB4 _YYX(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.x); }
        public static VectorB4 _YYY(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.y); }
        public static VectorB4 _YYZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.z); }
        public static VectorB4 _YYW(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.w); }
        public static VectorB4 _YY_(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.y, 0); }
        public static VectorB4 _YZX(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.x); }
        public static VectorB4 _YZY(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.y); }
        public static VectorB4 _YZZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.z); }
        public static VectorB4 _YZW(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.w); }
        public static VectorB4 _YZ_(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.z, 0); }
        public static VectorB4 _YWX(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.w, V.x); }
        public static VectorB4 _YWY(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.w, V.y); }
        public static VectorB4 _YWZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.w, V.z); }
        public static VectorB4 _YWW(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.w, V.w); }
        public static VectorB4 _YW_(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.w, 0); }
        public static VectorB4 _Y_X(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, 0, V.x); }
        public static VectorB4 _Y_Y(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, 0, V.y); }
        public static VectorB4 _Y_Z(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, 0, V.z); }
        public static VectorB4 _Y_W(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, 0, V.w); }
        public static VectorB4 _Y__(VectorB4 V){ return VecOps.MkVectorB4(0, V.y, 0, 0); }
        public static VectorB4 _ZXX(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.x); }
        public static VectorB4 _ZXY(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.y); }
        public static VectorB4 _ZXZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.z); }
        public static VectorB4 _ZXW(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.w); }
        public static VectorB4 _ZX_(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.x, 0); }
        public static VectorB4 _ZYX(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.x); }
        public static VectorB4 _ZYY(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.y); }
        public static VectorB4 _ZYZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.z); }
        public static VectorB4 _ZYW(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.w); }
        public static VectorB4 _ZY_(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.y, 0); }
        public static VectorB4 _ZZX(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.x); }
        public static VectorB4 _ZZY(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.y); }
        public static VectorB4 _ZZZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.z); }
        public static VectorB4 _ZZW(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.w); }
        public static VectorB4 _ZZ_(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.z, 0); }
        public static VectorB4 _ZWX(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.w, V.x); }
        public static VectorB4 _ZWY(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.w, V.y); }
        public static VectorB4 _ZWZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.w, V.z); }
        public static VectorB4 _ZWW(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.w, V.w); }
        public static VectorB4 _ZW_(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.w, 0); }
        public static VectorB4 _Z_X(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, 0, V.x); }
        public static VectorB4 _Z_Y(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, 0, V.y); }
        public static VectorB4 _Z_Z(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, 0, V.z); }
        public static VectorB4 _Z_W(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, 0, V.w); }
        public static VectorB4 _Z__(VectorB4 V){ return VecOps.MkVectorB4(0, V.z, 0, 0); }
        public static VectorB4 _WXX(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.x, V.x); }
        public static VectorB4 _WXY(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.x, V.y); }
        public static VectorB4 _WXZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.x, V.z); }
        public static VectorB4 _WXW(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.x, V.w); }
        public static VectorB4 _WX_(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.x, 0); }
        public static VectorB4 _WYX(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.y, V.x); }
        public static VectorB4 _WYY(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.y, V.y); }
        public static VectorB4 _WYZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.y, V.z); }
        public static VectorB4 _WYW(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.y, V.w); }
        public static VectorB4 _WY_(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.y, 0); }
        public static VectorB4 _WZX(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.z, V.x); }
        public static VectorB4 _WZY(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.z, V.y); }
        public static VectorB4 _WZZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.z, V.z); }
        public static VectorB4 _WZW(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.z, V.w); }
        public static VectorB4 _WZ_(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.z, 0); }
        public static VectorB4 _WWX(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.w, V.x); }
        public static VectorB4 _WWY(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.w, V.y); }
        public static VectorB4 _WWZ(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.w, V.z); }
        public static VectorB4 _WWW(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.w, V.w); }
        public static VectorB4 _WW_(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.w, 0); }
        public static VectorB4 _W_X(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, 0, V.x); }
        public static VectorB4 _W_Y(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, 0, V.y); }
        public static VectorB4 _W_Z(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, 0, V.z); }
        public static VectorB4 _W_W(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, 0, V.w); }
        public static VectorB4 _W__(VectorB4 V){ return VecOps.MkVectorB4(0, V.w, 0, 0); }
        public static VectorB4 __XX(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.x, V.x); }
        public static VectorB4 __XY(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.x, V.y); }
        public static VectorB4 __XZ(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.x, V.z); }
        public static VectorB4 __XW(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.x, V.w); }
        public static VectorB4 __X_(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.x, 0); }
        public static VectorB4 __YX(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.y, V.x); }
        public static VectorB4 __YY(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.y, V.y); }
        public static VectorB4 __YZ(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.y, V.z); }
        public static VectorB4 __YW(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.y, V.w); }
        public static VectorB4 __Y_(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.y, 0); }
        public static VectorB4 __ZX(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.z, V.x); }
        public static VectorB4 __ZY(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.z, V.y); }
        public static VectorB4 __ZZ(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.z, V.z); }
        public static VectorB4 __ZW(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.z, V.w); }
        public static VectorB4 __Z_(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.z, 0); }
        public static VectorB4 __WX(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.w, V.x); }
        public static VectorB4 __WY(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.w, V.y); }
        public static VectorB4 __WZ(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.w, V.z); }
        public static VectorB4 __WW(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.w, V.w); }
        public static VectorB4 __W_(VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.w, 0); }
        public static VectorB4 ___X(VectorB4 V){ return VecOps.MkVectorB4(0, 0, 0, V.x); }
        public static VectorB4 ___Y(VectorB4 V){ return VecOps.MkVectorB4(0, 0, 0, V.y); }
        public static VectorB4 ___Z(VectorB4 V){ return VecOps.MkVectorB4(0, 0, 0, V.z); }
        public static VectorB4 ___W(VectorB4 V){ return VecOps.MkVectorB4(0, 0, 0, V.w); }
        public static VectorD2 XX(VectorD2 V){ return VecOps.MkVectorD2(V.x, V.x); }
        public static VectorD2 XY(VectorD2 V){ return VecOps.MkVectorD2(V.x, V.y); }
        public static VectorD2 X_(VectorD2 V){ return VecOps.MkVectorD2(V.x, 0); }
        public static VectorD2 YX(VectorD2 V){ return VecOps.MkVectorD2(V.y, V.x); }
        public static VectorD2 YY(VectorD2 V){ return VecOps.MkVectorD2(V.y, V.y); }
        public static VectorD2 Y_(VectorD2 V){ return VecOps.MkVectorD2(V.y, 0); }
        public static VectorD2 _X(VectorD2 V){ return VecOps.MkVectorD2(0, V.x); }
        public static VectorD2 _Y(VectorD2 V){ return VecOps.MkVectorD2(0, V.y); }
        public static VectorD3 XXX(VectorD2 V){ return VecOps.MkVectorD3(V.x, V.x, V.x); }
        public static VectorD3 XXY(VectorD2 V){ return VecOps.MkVectorD3(V.x, V.x, V.y); }
        public static VectorD3 XX_(VectorD2 V){ return VecOps.MkVectorD3(V.x, V.x, 0); }
        public static VectorD3 XYX(VectorD2 V){ return VecOps.MkVectorD3(V.x, V.y, V.x); }
        public static VectorD3 XYY(VectorD2 V){ return VecOps.MkVectorD3(V.x, V.y, V.y); }
        public static VectorD3 XY_(VectorD2 V){ return VecOps.MkVectorD3(V.x, V.y, 0); }
        public static VectorD3 X_X(VectorD2 V){ return VecOps.MkVectorD3(V.x, 0, V.x); }
        public static VectorD3 X_Y(VectorD2 V){ return VecOps.MkVectorD3(V.x, 0, V.y); }
        public static VectorD3 X__(VectorD2 V){ return VecOps.MkVectorD3(V.x, 0, 0); }
        public static VectorD3 YXX(VectorD2 V){ return VecOps.MkVectorD3(V.y, V.x, V.x); }
        public static VectorD3 YXY(VectorD2 V){ return VecOps.MkVectorD3(V.y, V.x, V.y); }
        public static VectorD3 YX_(VectorD2 V){ return VecOps.MkVectorD3(V.y, V.x, 0); }
        public static VectorD3 YYX(VectorD2 V){ return VecOps.MkVectorD3(V.y, V.y, V.x); }
        public static VectorD3 YYY(VectorD2 V){ return VecOps.MkVectorD3(V.y, V.y, V.y); }
        public static VectorD3 YY_(VectorD2 V){ return VecOps.MkVectorD3(V.y, V.y, 0); }
        public static VectorD3 Y_X(VectorD2 V){ return VecOps.MkVectorD3(V.y, 0, V.x); }
        public static VectorD3 Y_Y(VectorD2 V){ return VecOps.MkVectorD3(V.y, 0, V.y); }
        public static VectorD3 Y__(VectorD2 V){ return VecOps.MkVectorD3(V.y, 0, 0); }
        public static VectorD3 _XX(VectorD2 V){ return VecOps.MkVectorD3(0, V.x, V.x); }
        public static VectorD3 _XY(VectorD2 V){ return VecOps.MkVectorD3(0, V.x, V.y); }
        public static VectorD3 _X_(VectorD2 V){ return VecOps.MkVectorD3(0, V.x, 0); }
        public static VectorD3 _YX(VectorD2 V){ return VecOps.MkVectorD3(0, V.y, V.x); }
        public static VectorD3 _YY(VectorD2 V){ return VecOps.MkVectorD3(0, V.y, V.y); }
        public static VectorD3 _Y_(VectorD2 V){ return VecOps.MkVectorD3(0, V.y, 0); }
        public static VectorD3 __X(VectorD2 V){ return VecOps.MkVectorD3(0, 0, V.x); }
        public static VectorD3 __Y(VectorD2 V){ return VecOps.MkVectorD3(0, 0, V.y); }
        public static VectorD4 XXXX(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, V.x); }
        public static VectorD4 XXXY(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, V.y); }
        public static VectorD4 XXX_(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, 0); }
        public static VectorD4 XXYX(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, V.x); }
        public static VectorD4 XXYY(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, V.y); }
        public static VectorD4 XXY_(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, 0); }
        public static VectorD4 XX_X(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.x, 0, V.x); }
        public static VectorD4 XX_Y(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.x, 0, V.y); }
        public static VectorD4 XX__(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.x, 0, 0); }
        public static VectorD4 XYXX(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, V.x); }
        public static VectorD4 XYXY(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, V.y); }
        public static VectorD4 XYX_(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, 0); }
        public static VectorD4 XYYX(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, V.x); }
        public static VectorD4 XYYY(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, V.y); }
        public static VectorD4 XYY_(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, 0); }
        public static VectorD4 XY_X(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.y, 0, V.x); }
        public static VectorD4 XY_Y(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.y, 0, V.y); }
        public static VectorD4 XY__(VectorD2 V){ return VecOps.MkVectorD4(V.x, V.y, 0, 0); }
        public static VectorD4 X_XX(VectorD2 V){ return VecOps.MkVectorD4(V.x, 0, V.x, V.x); }
        public static VectorD4 X_XY(VectorD2 V){ return VecOps.MkVectorD4(V.x, 0, V.x, V.y); }
        public static VectorD4 X_X_(VectorD2 V){ return VecOps.MkVectorD4(V.x, 0, V.x, 0); }
        public static VectorD4 X_YX(VectorD2 V){ return VecOps.MkVectorD4(V.x, 0, V.y, V.x); }
        public static VectorD4 X_YY(VectorD2 V){ return VecOps.MkVectorD4(V.x, 0, V.y, V.y); }
        public static VectorD4 X_Y_(VectorD2 V){ return VecOps.MkVectorD4(V.x, 0, V.y, 0); }
        public static VectorD4 X__X(VectorD2 V){ return VecOps.MkVectorD4(V.x, 0, 0, V.x); }
        public static VectorD4 X__Y(VectorD2 V){ return VecOps.MkVectorD4(V.x, 0, 0, V.y); }
        public static VectorD4 X___(VectorD2 V){ return VecOps.MkVectorD4(V.x, 0, 0, 0); }
        public static VectorD4 YXXX(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, V.x); }
        public static VectorD4 YXXY(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, V.y); }
        public static VectorD4 YXX_(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, 0); }
        public static VectorD4 YXYX(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, V.x); }
        public static VectorD4 YXYY(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, V.y); }
        public static VectorD4 YXY_(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, 0); }
        public static VectorD4 YX_X(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.x, 0, V.x); }
        public static VectorD4 YX_Y(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.x, 0, V.y); }
        public static VectorD4 YX__(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.x, 0, 0); }
        public static VectorD4 YYXX(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, V.x); }
        public static VectorD4 YYXY(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, V.y); }
        public static VectorD4 YYX_(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, 0); }
        public static VectorD4 YYYX(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, V.x); }
        public static VectorD4 YYYY(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, V.y); }
        public static VectorD4 YYY_(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, 0); }
        public static VectorD4 YY_X(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.y, 0, V.x); }
        public static VectorD4 YY_Y(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.y, 0, V.y); }
        public static VectorD4 YY__(VectorD2 V){ return VecOps.MkVectorD4(V.y, V.y, 0, 0); }
        public static VectorD4 Y_XX(VectorD2 V){ return VecOps.MkVectorD4(V.y, 0, V.x, V.x); }
        public static VectorD4 Y_XY(VectorD2 V){ return VecOps.MkVectorD4(V.y, 0, V.x, V.y); }
        public static VectorD4 Y_X_(VectorD2 V){ return VecOps.MkVectorD4(V.y, 0, V.x, 0); }
        public static VectorD4 Y_YX(VectorD2 V){ return VecOps.MkVectorD4(V.y, 0, V.y, V.x); }
        public static VectorD4 Y_YY(VectorD2 V){ return VecOps.MkVectorD4(V.y, 0, V.y, V.y); }
        public static VectorD4 Y_Y_(VectorD2 V){ return VecOps.MkVectorD4(V.y, 0, V.y, 0); }
        public static VectorD4 Y__X(VectorD2 V){ return VecOps.MkVectorD4(V.y, 0, 0, V.x); }
        public static VectorD4 Y__Y(VectorD2 V){ return VecOps.MkVectorD4(V.y, 0, 0, V.y); }
        public static VectorD4 Y___(VectorD2 V){ return VecOps.MkVectorD4(V.y, 0, 0, 0); }
        public static VectorD4 _XXX(VectorD2 V){ return VecOps.MkVectorD4(0, V.x, V.x, V.x); }
        public static VectorD4 _XXY(VectorD2 V){ return VecOps.MkVectorD4(0, V.x, V.x, V.y); }
        public static VectorD4 _XX_(VectorD2 V){ return VecOps.MkVectorD4(0, V.x, V.x, 0); }
        public static VectorD4 _XYX(VectorD2 V){ return VecOps.MkVectorD4(0, V.x, V.y, V.x); }
        public static VectorD4 _XYY(VectorD2 V){ return VecOps.MkVectorD4(0, V.x, V.y, V.y); }
        public static VectorD4 _XY_(VectorD2 V){ return VecOps.MkVectorD4(0, V.x, V.y, 0); }
        public static VectorD4 _X_X(VectorD2 V){ return VecOps.MkVectorD4(0, V.x, 0, V.x); }
        public static VectorD4 _X_Y(VectorD2 V){ return VecOps.MkVectorD4(0, V.x, 0, V.y); }
        public static VectorD4 _X__(VectorD2 V){ return VecOps.MkVectorD4(0, V.x, 0, 0); }
        public static VectorD4 _YXX(VectorD2 V){ return VecOps.MkVectorD4(0, V.y, V.x, V.x); }
        public static VectorD4 _YXY(VectorD2 V){ return VecOps.MkVectorD4(0, V.y, V.x, V.y); }
        public static VectorD4 _YX_(VectorD2 V){ return VecOps.MkVectorD4(0, V.y, V.x, 0); }
        public static VectorD4 _YYX(VectorD2 V){ return VecOps.MkVectorD4(0, V.y, V.y, V.x); }
        public static VectorD4 _YYY(VectorD2 V){ return VecOps.MkVectorD4(0, V.y, V.y, V.y); }
        public static VectorD4 _YY_(VectorD2 V){ return VecOps.MkVectorD4(0, V.y, V.y, 0); }
        public static VectorD4 _Y_X(VectorD2 V){ return VecOps.MkVectorD4(0, V.y, 0, V.x); }
        public static VectorD4 _Y_Y(VectorD2 V){ return VecOps.MkVectorD4(0, V.y, 0, V.y); }
        public static VectorD4 _Y__(VectorD2 V){ return VecOps.MkVectorD4(0, V.y, 0, 0); }
        public static VectorD4 __XX(VectorD2 V){ return VecOps.MkVectorD4(0, 0, V.x, V.x); }
        public static VectorD4 __XY(VectorD2 V){ return VecOps.MkVectorD4(0, 0, V.x, V.y); }
        public static VectorD4 __X_(VectorD2 V){ return VecOps.MkVectorD4(0, 0, V.x, 0); }
        public static VectorD4 __YX(VectorD2 V){ return VecOps.MkVectorD4(0, 0, V.y, V.x); }
        public static VectorD4 __YY(VectorD2 V){ return VecOps.MkVectorD4(0, 0, V.y, V.y); }
        public static VectorD4 __Y_(VectorD2 V){ return VecOps.MkVectorD4(0, 0, V.y, 0); }
        public static VectorD4 ___X(VectorD2 V){ return VecOps.MkVectorD4(0, 0, 0, V.x); }
        public static VectorD4 ___Y(VectorD2 V){ return VecOps.MkVectorD4(0, 0, 0, V.y); }
        public static VectorD2 XX(VectorD3 V){ return VecOps.MkVectorD2(V.x, V.x); }
        public static VectorD2 XY(VectorD3 V){ return VecOps.MkVectorD2(V.x, V.y); }
        public static VectorD2 XZ(VectorD3 V){ return VecOps.MkVectorD2(V.x, V.z); }
        public static VectorD2 X_(VectorD3 V){ return VecOps.MkVectorD2(V.x, 0); }
        public static VectorD2 YX(VectorD3 V){ return VecOps.MkVectorD2(V.y, V.x); }
        public static VectorD2 YY(VectorD3 V){ return VecOps.MkVectorD2(V.y, V.y); }
        public static VectorD2 YZ(VectorD3 V){ return VecOps.MkVectorD2(V.y, V.z); }
        public static VectorD2 Y_(VectorD3 V){ return VecOps.MkVectorD2(V.y, 0); }
        public static VectorD2 ZX(VectorD3 V){ return VecOps.MkVectorD2(V.z, V.x); }
        public static VectorD2 ZY(VectorD3 V){ return VecOps.MkVectorD2(V.z, V.y); }
        public static VectorD2 ZZ(VectorD3 V){ return VecOps.MkVectorD2(V.z, V.z); }
        public static VectorD2 Z_(VectorD3 V){ return VecOps.MkVectorD2(V.z, 0); }
        public static VectorD2 _X(VectorD3 V){ return VecOps.MkVectorD2(0, V.x); }
        public static VectorD2 _Y(VectorD3 V){ return VecOps.MkVectorD2(0, V.y); }
        public static VectorD2 _Z(VectorD3 V){ return VecOps.MkVectorD2(0, V.z); }
        public static VectorD3 XXX(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.x, V.x); }
        public static VectorD3 XXY(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.x, V.y); }
        public static VectorD3 XXZ(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.x, V.z); }
        public static VectorD3 XX_(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.x, 0); }
        public static VectorD3 XYX(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.y, V.x); }
        public static VectorD3 XYY(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.y, V.y); }
        public static VectorD3 XYZ(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.y, V.z); }
        public static VectorD3 XY_(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.y, 0); }
        public static VectorD3 XZX(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.z, V.x); }
        public static VectorD3 XZY(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.z, V.y); }
        public static VectorD3 XZZ(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.z, V.z); }
        public static VectorD3 XZ_(VectorD3 V){ return VecOps.MkVectorD3(V.x, V.z, 0); }
        public static VectorD3 X_X(VectorD3 V){ return VecOps.MkVectorD3(V.x, 0, V.x); }
        public static VectorD3 X_Y(VectorD3 V){ return VecOps.MkVectorD3(V.x, 0, V.y); }
        public static VectorD3 X_Z(VectorD3 V){ return VecOps.MkVectorD3(V.x, 0, V.z); }
        public static VectorD3 X__(VectorD3 V){ return VecOps.MkVectorD3(V.x, 0, 0); }
        public static VectorD3 YXX(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.x, V.x); }
        public static VectorD3 YXY(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.x, V.y); }
        public static VectorD3 YXZ(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.x, V.z); }
        public static VectorD3 YX_(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.x, 0); }
        public static VectorD3 YYX(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.y, V.x); }
        public static VectorD3 YYY(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.y, V.y); }
        public static VectorD3 YYZ(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.y, V.z); }
        public static VectorD3 YY_(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.y, 0); }
        public static VectorD3 YZX(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.z, V.x); }
        public static VectorD3 YZY(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.z, V.y); }
        public static VectorD3 YZZ(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.z, V.z); }
        public static VectorD3 YZ_(VectorD3 V){ return VecOps.MkVectorD3(V.y, V.z, 0); }
        public static VectorD3 Y_X(VectorD3 V){ return VecOps.MkVectorD3(V.y, 0, V.x); }
        public static VectorD3 Y_Y(VectorD3 V){ return VecOps.MkVectorD3(V.y, 0, V.y); }
        public static VectorD3 Y_Z(VectorD3 V){ return VecOps.MkVectorD3(V.y, 0, V.z); }
        public static VectorD3 Y__(VectorD3 V){ return VecOps.MkVectorD3(V.y, 0, 0); }
        public static VectorD3 ZXX(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.x, V.x); }
        public static VectorD3 ZXY(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.x, V.y); }
        public static VectorD3 ZXZ(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.x, V.z); }
        public static VectorD3 ZX_(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.x, 0); }
        public static VectorD3 ZYX(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.y, V.x); }
        public static VectorD3 ZYY(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.y, V.y); }
        public static VectorD3 ZYZ(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.y, V.z); }
        public static VectorD3 ZY_(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.y, 0); }
        public static VectorD3 ZZX(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.z, V.x); }
        public static VectorD3 ZZY(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.z, V.y); }
        public static VectorD3 ZZZ(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.z, V.z); }
        public static VectorD3 ZZ_(VectorD3 V){ return VecOps.MkVectorD3(V.z, V.z, 0); }
        public static VectorD3 Z_X(VectorD3 V){ return VecOps.MkVectorD3(V.z, 0, V.x); }
        public static VectorD3 Z_Y(VectorD3 V){ return VecOps.MkVectorD3(V.z, 0, V.y); }
        public static VectorD3 Z_Z(VectorD3 V){ return VecOps.MkVectorD3(V.z, 0, V.z); }
        public static VectorD3 Z__(VectorD3 V){ return VecOps.MkVectorD3(V.z, 0, 0); }
        public static VectorD3 _XX(VectorD3 V){ return VecOps.MkVectorD3(0, V.x, V.x); }
        public static VectorD3 _XY(VectorD3 V){ return VecOps.MkVectorD3(0, V.x, V.y); }
        public static VectorD3 _XZ(VectorD3 V){ return VecOps.MkVectorD3(0, V.x, V.z); }
        public static VectorD3 _X_(VectorD3 V){ return VecOps.MkVectorD3(0, V.x, 0); }
        public static VectorD3 _YX(VectorD3 V){ return VecOps.MkVectorD3(0, V.y, V.x); }
        public static VectorD3 _YY(VectorD3 V){ return VecOps.MkVectorD3(0, V.y, V.y); }
        public static VectorD3 _YZ(VectorD3 V){ return VecOps.MkVectorD3(0, V.y, V.z); }
        public static VectorD3 _Y_(VectorD3 V){ return VecOps.MkVectorD3(0, V.y, 0); }
        public static VectorD3 _ZX(VectorD3 V){ return VecOps.MkVectorD3(0, V.z, V.x); }
        public static VectorD3 _ZY(VectorD3 V){ return VecOps.MkVectorD3(0, V.z, V.y); }
        public static VectorD3 _ZZ(VectorD3 V){ return VecOps.MkVectorD3(0, V.z, V.z); }
        public static VectorD3 _Z_(VectorD3 V){ return VecOps.MkVectorD3(0, V.z, 0); }
        public static VectorD3 __X(VectorD3 V){ return VecOps.MkVectorD3(0, 0, V.x); }
        public static VectorD3 __Y(VectorD3 V){ return VecOps.MkVectorD3(0, 0, V.y); }
        public static VectorD3 __Z(VectorD3 V){ return VecOps.MkVectorD3(0, 0, V.z); }
        public static VectorD4 XXXX(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, V.x); }
        public static VectorD4 XXXY(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, V.y); }
        public static VectorD4 XXXZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, V.z); }
        public static VectorD4 XXX_(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, 0); }
        public static VectorD4 XXYX(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, V.x); }
        public static VectorD4 XXYY(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, V.y); }
        public static VectorD4 XXYZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, V.z); }
        public static VectorD4 XXY_(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, 0); }
        public static VectorD4 XXZX(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.z, V.x); }
        public static VectorD4 XXZY(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.z, V.y); }
        public static VectorD4 XXZZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.z, V.z); }
        public static VectorD4 XXZ_(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, V.z, 0); }
        public static VectorD4 XX_X(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, 0, V.x); }
        public static VectorD4 XX_Y(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, 0, V.y); }
        public static VectorD4 XX_Z(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, 0, V.z); }
        public static VectorD4 XX__(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.x, 0, 0); }
        public static VectorD4 XYXX(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, V.x); }
        public static VectorD4 XYXY(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, V.y); }
        public static VectorD4 XYXZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, V.z); }
        public static VectorD4 XYX_(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, 0); }
        public static VectorD4 XYYX(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, V.x); }
        public static VectorD4 XYYY(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, V.y); }
        public static VectorD4 XYYZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, V.z); }
        public static VectorD4 XYY_(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, 0); }
        public static VectorD4 XYZX(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.z, V.x); }
        public static VectorD4 XYZY(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.z, V.y); }
        public static VectorD4 XYZZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.z, V.z); }
        public static VectorD4 XYZ_(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, V.z, 0); }
        public static VectorD4 XY_X(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, 0, V.x); }
        public static VectorD4 XY_Y(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, 0, V.y); }
        public static VectorD4 XY_Z(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, 0, V.z); }
        public static VectorD4 XY__(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.y, 0, 0); }
        public static VectorD4 XZXX(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.x, V.x); }
        public static VectorD4 XZXY(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.x, V.y); }
        public static VectorD4 XZXZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.x, V.z); }
        public static VectorD4 XZX_(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.x, 0); }
        public static VectorD4 XZYX(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.y, V.x); }
        public static VectorD4 XZYY(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.y, V.y); }
        public static VectorD4 XZYZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.y, V.z); }
        public static VectorD4 XZY_(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.y, 0); }
        public static VectorD4 XZZX(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.z, V.x); }
        public static VectorD4 XZZY(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.z, V.y); }
        public static VectorD4 XZZZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.z, V.z); }
        public static VectorD4 XZZ_(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, V.z, 0); }
        public static VectorD4 XZ_X(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, 0, V.x); }
        public static VectorD4 XZ_Y(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, 0, V.y); }
        public static VectorD4 XZ_Z(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, 0, V.z); }
        public static VectorD4 XZ__(VectorD3 V){ return VecOps.MkVectorD4(V.x, V.z, 0, 0); }
        public static VectorD4 X_XX(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.x, V.x); }
        public static VectorD4 X_XY(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.x, V.y); }
        public static VectorD4 X_XZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.x, V.z); }
        public static VectorD4 X_X_(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.x, 0); }
        public static VectorD4 X_YX(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.y, V.x); }
        public static VectorD4 X_YY(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.y, V.y); }
        public static VectorD4 X_YZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.y, V.z); }
        public static VectorD4 X_Y_(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.y, 0); }
        public static VectorD4 X_ZX(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.z, V.x); }
        public static VectorD4 X_ZY(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.z, V.y); }
        public static VectorD4 X_ZZ(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.z, V.z); }
        public static VectorD4 X_Z_(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, V.z, 0); }
        public static VectorD4 X__X(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, 0, V.x); }
        public static VectorD4 X__Y(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, 0, V.y); }
        public static VectorD4 X__Z(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, 0, V.z); }
        public static VectorD4 X___(VectorD3 V){ return VecOps.MkVectorD4(V.x, 0, 0, 0); }
        public static VectorD4 YXXX(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, V.x); }
        public static VectorD4 YXXY(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, V.y); }
        public static VectorD4 YXXZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, V.z); }
        public static VectorD4 YXX_(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, 0); }
        public static VectorD4 YXYX(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, V.x); }
        public static VectorD4 YXYY(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, V.y); }
        public static VectorD4 YXYZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, V.z); }
        public static VectorD4 YXY_(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, 0); }
        public static VectorD4 YXZX(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.z, V.x); }
        public static VectorD4 YXZY(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.z, V.y); }
        public static VectorD4 YXZZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.z, V.z); }
        public static VectorD4 YXZ_(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, V.z, 0); }
        public static VectorD4 YX_X(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, 0, V.x); }
        public static VectorD4 YX_Y(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, 0, V.y); }
        public static VectorD4 YX_Z(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, 0, V.z); }
        public static VectorD4 YX__(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.x, 0, 0); }
        public static VectorD4 YYXX(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, V.x); }
        public static VectorD4 YYXY(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, V.y); }
        public static VectorD4 YYXZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, V.z); }
        public static VectorD4 YYX_(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, 0); }
        public static VectorD4 YYYX(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, V.x); }
        public static VectorD4 YYYY(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, V.y); }
        public static VectorD4 YYYZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, V.z); }
        public static VectorD4 YYY_(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, 0); }
        public static VectorD4 YYZX(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.z, V.x); }
        public static VectorD4 YYZY(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.z, V.y); }
        public static VectorD4 YYZZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.z, V.z); }
        public static VectorD4 YYZ_(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, V.z, 0); }
        public static VectorD4 YY_X(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, 0, V.x); }
        public static VectorD4 YY_Y(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, 0, V.y); }
        public static VectorD4 YY_Z(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, 0, V.z); }
        public static VectorD4 YY__(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.y, 0, 0); }
        public static VectorD4 YZXX(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.x, V.x); }
        public static VectorD4 YZXY(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.x, V.y); }
        public static VectorD4 YZXZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.x, V.z); }
        public static VectorD4 YZX_(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.x, 0); }
        public static VectorD4 YZYX(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.y, V.x); }
        public static VectorD4 YZYY(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.y, V.y); }
        public static VectorD4 YZYZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.y, V.z); }
        public static VectorD4 YZY_(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.y, 0); }
        public static VectorD4 YZZX(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.z, V.x); }
        public static VectorD4 YZZY(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.z, V.y); }
        public static VectorD4 YZZZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.z, V.z); }
        public static VectorD4 YZZ_(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, V.z, 0); }
        public static VectorD4 YZ_X(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, 0, V.x); }
        public static VectorD4 YZ_Y(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, 0, V.y); }
        public static VectorD4 YZ_Z(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, 0, V.z); }
        public static VectorD4 YZ__(VectorD3 V){ return VecOps.MkVectorD4(V.y, V.z, 0, 0); }
        public static VectorD4 Y_XX(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.x, V.x); }
        public static VectorD4 Y_XY(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.x, V.y); }
        public static VectorD4 Y_XZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.x, V.z); }
        public static VectorD4 Y_X_(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.x, 0); }
        public static VectorD4 Y_YX(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.y, V.x); }
        public static VectorD4 Y_YY(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.y, V.y); }
        public static VectorD4 Y_YZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.y, V.z); }
        public static VectorD4 Y_Y_(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.y, 0); }
        public static VectorD4 Y_ZX(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.z, V.x); }
        public static VectorD4 Y_ZY(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.z, V.y); }
        public static VectorD4 Y_ZZ(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.z, V.z); }
        public static VectorD4 Y_Z_(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, V.z, 0); }
        public static VectorD4 Y__X(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, 0, V.x); }
        public static VectorD4 Y__Y(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, 0, V.y); }
        public static VectorD4 Y__Z(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, 0, V.z); }
        public static VectorD4 Y___(VectorD3 V){ return VecOps.MkVectorD4(V.y, 0, 0, 0); }
        public static VectorD4 ZXXX(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.x, V.x); }
        public static VectorD4 ZXXY(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.x, V.y); }
        public static VectorD4 ZXXZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.x, V.z); }
        public static VectorD4 ZXX_(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.x, 0); }
        public static VectorD4 ZXYX(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.y, V.x); }
        public static VectorD4 ZXYY(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.y, V.y); }
        public static VectorD4 ZXYZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.y, V.z); }
        public static VectorD4 ZXY_(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.y, 0); }
        public static VectorD4 ZXZX(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.z, V.x); }
        public static VectorD4 ZXZY(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.z, V.y); }
        public static VectorD4 ZXZZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.z, V.z); }
        public static VectorD4 ZXZ_(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, V.z, 0); }
        public static VectorD4 ZX_X(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, 0, V.x); }
        public static VectorD4 ZX_Y(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, 0, V.y); }
        public static VectorD4 ZX_Z(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, 0, V.z); }
        public static VectorD4 ZX__(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.x, 0, 0); }
        public static VectorD4 ZYXX(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.x, V.x); }
        public static VectorD4 ZYXY(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.x, V.y); }
        public static VectorD4 ZYXZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.x, V.z); }
        public static VectorD4 ZYX_(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.x, 0); }
        public static VectorD4 ZYYX(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.y, V.x); }
        public static VectorD4 ZYYY(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.y, V.y); }
        public static VectorD4 ZYYZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.y, V.z); }
        public static VectorD4 ZYY_(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.y, 0); }
        public static VectorD4 ZYZX(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.z, V.x); }
        public static VectorD4 ZYZY(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.z, V.y); }
        public static VectorD4 ZYZZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.z, V.z); }
        public static VectorD4 ZYZ_(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, V.z, 0); }
        public static VectorD4 ZY_X(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, 0, V.x); }
        public static VectorD4 ZY_Y(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, 0, V.y); }
        public static VectorD4 ZY_Z(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, 0, V.z); }
        public static VectorD4 ZY__(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.y, 0, 0); }
        public static VectorD4 ZZXX(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.x, V.x); }
        public static VectorD4 ZZXY(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.x, V.y); }
        public static VectorD4 ZZXZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.x, V.z); }
        public static VectorD4 ZZX_(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.x, 0); }
        public static VectorD4 ZZYX(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.y, V.x); }
        public static VectorD4 ZZYY(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.y, V.y); }
        public static VectorD4 ZZYZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.y, V.z); }
        public static VectorD4 ZZY_(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.y, 0); }
        public static VectorD4 ZZZX(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.z, V.x); }
        public static VectorD4 ZZZY(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.z, V.y); }
        public static VectorD4 ZZZZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.z, V.z); }
        public static VectorD4 ZZZ_(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, V.z, 0); }
        public static VectorD4 ZZ_X(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, 0, V.x); }
        public static VectorD4 ZZ_Y(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, 0, V.y); }
        public static VectorD4 ZZ_Z(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, 0, V.z); }
        public static VectorD4 ZZ__(VectorD3 V){ return VecOps.MkVectorD4(V.z, V.z, 0, 0); }
        public static VectorD4 Z_XX(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.x, V.x); }
        public static VectorD4 Z_XY(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.x, V.y); }
        public static VectorD4 Z_XZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.x, V.z); }
        public static VectorD4 Z_X_(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.x, 0); }
        public static VectorD4 Z_YX(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.y, V.x); }
        public static VectorD4 Z_YY(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.y, V.y); }
        public static VectorD4 Z_YZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.y, V.z); }
        public static VectorD4 Z_Y_(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.y, 0); }
        public static VectorD4 Z_ZX(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.z, V.x); }
        public static VectorD4 Z_ZY(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.z, V.y); }
        public static VectorD4 Z_ZZ(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.z, V.z); }
        public static VectorD4 Z_Z_(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, V.z, 0); }
        public static VectorD4 Z__X(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, 0, V.x); }
        public static VectorD4 Z__Y(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, 0, V.y); }
        public static VectorD4 Z__Z(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, 0, V.z); }
        public static VectorD4 Z___(VectorD3 V){ return VecOps.MkVectorD4(V.z, 0, 0, 0); }
        public static VectorD4 _XXX(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.x, V.x); }
        public static VectorD4 _XXY(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.x, V.y); }
        public static VectorD4 _XXZ(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.x, V.z); }
        public static VectorD4 _XX_(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.x, 0); }
        public static VectorD4 _XYX(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.y, V.x); }
        public static VectorD4 _XYY(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.y, V.y); }
        public static VectorD4 _XYZ(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.y, V.z); }
        public static VectorD4 _XY_(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.y, 0); }
        public static VectorD4 _XZX(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.z, V.x); }
        public static VectorD4 _XZY(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.z, V.y); }
        public static VectorD4 _XZZ(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.z, V.z); }
        public static VectorD4 _XZ_(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, V.z, 0); }
        public static VectorD4 _X_X(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, 0, V.x); }
        public static VectorD4 _X_Y(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, 0, V.y); }
        public static VectorD4 _X_Z(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, 0, V.z); }
        public static VectorD4 _X__(VectorD3 V){ return VecOps.MkVectorD4(0, V.x, 0, 0); }
        public static VectorD4 _YXX(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.x, V.x); }
        public static VectorD4 _YXY(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.x, V.y); }
        public static VectorD4 _YXZ(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.x, V.z); }
        public static VectorD4 _YX_(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.x, 0); }
        public static VectorD4 _YYX(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.y, V.x); }
        public static VectorD4 _YYY(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.y, V.y); }
        public static VectorD4 _YYZ(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.y, V.z); }
        public static VectorD4 _YY_(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.y, 0); }
        public static VectorD4 _YZX(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.z, V.x); }
        public static VectorD4 _YZY(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.z, V.y); }
        public static VectorD4 _YZZ(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.z, V.z); }
        public static VectorD4 _YZ_(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, V.z, 0); }
        public static VectorD4 _Y_X(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, 0, V.x); }
        public static VectorD4 _Y_Y(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, 0, V.y); }
        public static VectorD4 _Y_Z(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, 0, V.z); }
        public static VectorD4 _Y__(VectorD3 V){ return VecOps.MkVectorD4(0, V.y, 0, 0); }
        public static VectorD4 _ZXX(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.x, V.x); }
        public static VectorD4 _ZXY(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.x, V.y); }
        public static VectorD4 _ZXZ(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.x, V.z); }
        public static VectorD4 _ZX_(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.x, 0); }
        public static VectorD4 _ZYX(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.y, V.x); }
        public static VectorD4 _ZYY(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.y, V.y); }
        public static VectorD4 _ZYZ(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.y, V.z); }
        public static VectorD4 _ZY_(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.y, 0); }
        public static VectorD4 _ZZX(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.z, V.x); }
        public static VectorD4 _ZZY(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.z, V.y); }
        public static VectorD4 _ZZZ(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.z, V.z); }
        public static VectorD4 _ZZ_(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, V.z, 0); }
        public static VectorD4 _Z_X(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, 0, V.x); }
        public static VectorD4 _Z_Y(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, 0, V.y); }
        public static VectorD4 _Z_Z(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, 0, V.z); }
        public static VectorD4 _Z__(VectorD3 V){ return VecOps.MkVectorD4(0, V.z, 0, 0); }
        public static VectorD4 __XX(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.x, V.x); }
        public static VectorD4 __XY(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.x, V.y); }
        public static VectorD4 __XZ(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.x, V.z); }
        public static VectorD4 __X_(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.x, 0); }
        public static VectorD4 __YX(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.y, V.x); }
        public static VectorD4 __YY(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.y, V.y); }
        public static VectorD4 __YZ(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.y, V.z); }
        public static VectorD4 __Y_(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.y, 0); }
        public static VectorD4 __ZX(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.z, V.x); }
        public static VectorD4 __ZY(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.z, V.y); }
        public static VectorD4 __ZZ(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.z, V.z); }
        public static VectorD4 __Z_(VectorD3 V){ return VecOps.MkVectorD4(0, 0, V.z, 0); }
        public static VectorD4 ___X(VectorD3 V){ return VecOps.MkVectorD4(0, 0, 0, V.x); }
        public static VectorD4 ___Y(VectorD3 V){ return VecOps.MkVectorD4(0, 0, 0, V.y); }
        public static VectorD4 ___Z(VectorD3 V){ return VecOps.MkVectorD4(0, 0, 0, V.z); }
        public static VectorD2 XX(VectorD4 V){ return VecOps.MkVectorD2(V.x, V.x); }
        public static VectorD2 XY(VectorD4 V){ return VecOps.MkVectorD2(V.x, V.y); }
        public static VectorD2 XZ(VectorD4 V){ return VecOps.MkVectorD2(V.x, V.z); }
        public static VectorD2 XW(VectorD4 V){ return VecOps.MkVectorD2(V.x, V.w); }
        public static VectorD2 X_(VectorD4 V){ return VecOps.MkVectorD2(V.x, 0); }
        public static VectorD2 YX(VectorD4 V){ return VecOps.MkVectorD2(V.y, V.x); }
        public static VectorD2 YY(VectorD4 V){ return VecOps.MkVectorD2(V.y, V.y); }
        public static VectorD2 YZ(VectorD4 V){ return VecOps.MkVectorD2(V.y, V.z); }
        public static VectorD2 YW(VectorD4 V){ return VecOps.MkVectorD2(V.y, V.w); }
        public static VectorD2 Y_(VectorD4 V){ return VecOps.MkVectorD2(V.y, 0); }
        public static VectorD2 ZX(VectorD4 V){ return VecOps.MkVectorD2(V.z, V.x); }
        public static VectorD2 ZY(VectorD4 V){ return VecOps.MkVectorD2(V.z, V.y); }
        public static VectorD2 ZZ(VectorD4 V){ return VecOps.MkVectorD2(V.z, V.z); }
        public static VectorD2 ZW(VectorD4 V){ return VecOps.MkVectorD2(V.z, V.w); }
        public static VectorD2 Z_(VectorD4 V){ return VecOps.MkVectorD2(V.z, 0); }
        public static VectorD2 WX(VectorD4 V){ return VecOps.MkVectorD2(V.w, V.x); }
        public static VectorD2 WY(VectorD4 V){ return VecOps.MkVectorD2(V.w, V.y); }
        public static VectorD2 WZ(VectorD4 V){ return VecOps.MkVectorD2(V.w, V.z); }
        public static VectorD2 WW(VectorD4 V){ return VecOps.MkVectorD2(V.w, V.w); }
        public static VectorD2 W_(VectorD4 V){ return VecOps.MkVectorD2(V.w, 0); }
        public static VectorD2 _X(VectorD4 V){ return VecOps.MkVectorD2(0, V.x); }
        public static VectorD2 _Y(VectorD4 V){ return VecOps.MkVectorD2(0, V.y); }
        public static VectorD2 _Z(VectorD4 V){ return VecOps.MkVectorD2(0, V.z); }
        public static VectorD2 _W(VectorD4 V){ return VecOps.MkVectorD2(0, V.w); }
        public static VectorD3 XXX(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.x, V.x); }
        public static VectorD3 XXY(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.x, V.y); }
        public static VectorD3 XXZ(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.x, V.z); }
        public static VectorD3 XXW(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.x, V.w); }
        public static VectorD3 XX_(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.x, 0); }
        public static VectorD3 XYX(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.y, V.x); }
        public static VectorD3 XYY(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.y, V.y); }
        public static VectorD3 XYZ(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.y, V.z); }
        public static VectorD3 XYW(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.y, V.w); }
        public static VectorD3 XY_(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.y, 0); }
        public static VectorD3 XZX(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.z, V.x); }
        public static VectorD3 XZY(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.z, V.y); }
        public static VectorD3 XZZ(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.z, V.z); }
        public static VectorD3 XZW(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.z, V.w); }
        public static VectorD3 XZ_(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.z, 0); }
        public static VectorD3 XWX(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.w, V.x); }
        public static VectorD3 XWY(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.w, V.y); }
        public static VectorD3 XWZ(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.w, V.z); }
        public static VectorD3 XWW(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.w, V.w); }
        public static VectorD3 XW_(VectorD4 V){ return VecOps.MkVectorD3(V.x, V.w, 0); }
        public static VectorD3 X_X(VectorD4 V){ return VecOps.MkVectorD3(V.x, 0, V.x); }
        public static VectorD3 X_Y(VectorD4 V){ return VecOps.MkVectorD3(V.x, 0, V.y); }
        public static VectorD3 X_Z(VectorD4 V){ return VecOps.MkVectorD3(V.x, 0, V.z); }
        public static VectorD3 X_W(VectorD4 V){ return VecOps.MkVectorD3(V.x, 0, V.w); }
        public static VectorD3 X__(VectorD4 V){ return VecOps.MkVectorD3(V.x, 0, 0); }
        public static VectorD3 YXX(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.x, V.x); }
        public static VectorD3 YXY(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.x, V.y); }
        public static VectorD3 YXZ(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.x, V.z); }
        public static VectorD3 YXW(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.x, V.w); }
        public static VectorD3 YX_(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.x, 0); }
        public static VectorD3 YYX(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.y, V.x); }
        public static VectorD3 YYY(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.y, V.y); }
        public static VectorD3 YYZ(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.y, V.z); }
        public static VectorD3 YYW(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.y, V.w); }
        public static VectorD3 YY_(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.y, 0); }
        public static VectorD3 YZX(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.z, V.x); }
        public static VectorD3 YZY(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.z, V.y); }
        public static VectorD3 YZZ(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.z, V.z); }
        public static VectorD3 YZW(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.z, V.w); }
        public static VectorD3 YZ_(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.z, 0); }
        public static VectorD3 YWX(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.w, V.x); }
        public static VectorD3 YWY(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.w, V.y); }
        public static VectorD3 YWZ(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.w, V.z); }
        public static VectorD3 YWW(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.w, V.w); }
        public static VectorD3 YW_(VectorD4 V){ return VecOps.MkVectorD3(V.y, V.w, 0); }
        public static VectorD3 Y_X(VectorD4 V){ return VecOps.MkVectorD3(V.y, 0, V.x); }
        public static VectorD3 Y_Y(VectorD4 V){ return VecOps.MkVectorD3(V.y, 0, V.y); }
        public static VectorD3 Y_Z(VectorD4 V){ return VecOps.MkVectorD3(V.y, 0, V.z); }
        public static VectorD3 Y_W(VectorD4 V){ return VecOps.MkVectorD3(V.y, 0, V.w); }
        public static VectorD3 Y__(VectorD4 V){ return VecOps.MkVectorD3(V.y, 0, 0); }
        public static VectorD3 ZXX(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.x, V.x); }
        public static VectorD3 ZXY(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.x, V.y); }
        public static VectorD3 ZXZ(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.x, V.z); }
        public static VectorD3 ZXW(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.x, V.w); }
        public static VectorD3 ZX_(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.x, 0); }
        public static VectorD3 ZYX(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.y, V.x); }
        public static VectorD3 ZYY(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.y, V.y); }
        public static VectorD3 ZYZ(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.y, V.z); }
        public static VectorD3 ZYW(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.y, V.w); }
        public static VectorD3 ZY_(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.y, 0); }
        public static VectorD3 ZZX(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.z, V.x); }
        public static VectorD3 ZZY(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.z, V.y); }
        public static VectorD3 ZZZ(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.z, V.z); }
        public static VectorD3 ZZW(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.z, V.w); }
        public static VectorD3 ZZ_(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.z, 0); }
        public static VectorD3 ZWX(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.w, V.x); }
        public static VectorD3 ZWY(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.w, V.y); }
        public static VectorD3 ZWZ(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.w, V.z); }
        public static VectorD3 ZWW(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.w, V.w); }
        public static VectorD3 ZW_(VectorD4 V){ return VecOps.MkVectorD3(V.z, V.w, 0); }
        public static VectorD3 Z_X(VectorD4 V){ return VecOps.MkVectorD3(V.z, 0, V.x); }
        public static VectorD3 Z_Y(VectorD4 V){ return VecOps.MkVectorD3(V.z, 0, V.y); }
        public static VectorD3 Z_Z(VectorD4 V){ return VecOps.MkVectorD3(V.z, 0, V.z); }
        public static VectorD3 Z_W(VectorD4 V){ return VecOps.MkVectorD3(V.z, 0, V.w); }
        public static VectorD3 Z__(VectorD4 V){ return VecOps.MkVectorD3(V.z, 0, 0); }
        public static VectorD3 WXX(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.x, V.x); }
        public static VectorD3 WXY(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.x, V.y); }
        public static VectorD3 WXZ(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.x, V.z); }
        public static VectorD3 WXW(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.x, V.w); }
        public static VectorD3 WX_(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.x, 0); }
        public static VectorD3 WYX(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.y, V.x); }
        public static VectorD3 WYY(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.y, V.y); }
        public static VectorD3 WYZ(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.y, V.z); }
        public static VectorD3 WYW(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.y, V.w); }
        public static VectorD3 WY_(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.y, 0); }
        public static VectorD3 WZX(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.z, V.x); }
        public static VectorD3 WZY(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.z, V.y); }
        public static VectorD3 WZZ(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.z, V.z); }
        public static VectorD3 WZW(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.z, V.w); }
        public static VectorD3 WZ_(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.z, 0); }
        public static VectorD3 WWX(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.w, V.x); }
        public static VectorD3 WWY(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.w, V.y); }
        public static VectorD3 WWZ(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.w, V.z); }
        public static VectorD3 WWW(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.w, V.w); }
        public static VectorD3 WW_(VectorD4 V){ return VecOps.MkVectorD3(V.w, V.w, 0); }
        public static VectorD3 W_X(VectorD4 V){ return VecOps.MkVectorD3(V.w, 0, V.x); }
        public static VectorD3 W_Y(VectorD4 V){ return VecOps.MkVectorD3(V.w, 0, V.y); }
        public static VectorD3 W_Z(VectorD4 V){ return VecOps.MkVectorD3(V.w, 0, V.z); }
        public static VectorD3 W_W(VectorD4 V){ return VecOps.MkVectorD3(V.w, 0, V.w); }
        public static VectorD3 W__(VectorD4 V){ return VecOps.MkVectorD3(V.w, 0, 0); }
        public static VectorD3 _XX(VectorD4 V){ return VecOps.MkVectorD3(0, V.x, V.x); }
        public static VectorD3 _XY(VectorD4 V){ return VecOps.MkVectorD3(0, V.x, V.y); }
        public static VectorD3 _XZ(VectorD4 V){ return VecOps.MkVectorD3(0, V.x, V.z); }
        public static VectorD3 _XW(VectorD4 V){ return VecOps.MkVectorD3(0, V.x, V.w); }
        public static VectorD3 _X_(VectorD4 V){ return VecOps.MkVectorD3(0, V.x, 0); }
        public static VectorD3 _YX(VectorD4 V){ return VecOps.MkVectorD3(0, V.y, V.x); }
        public static VectorD3 _YY(VectorD4 V){ return VecOps.MkVectorD3(0, V.y, V.y); }
        public static VectorD3 _YZ(VectorD4 V){ return VecOps.MkVectorD3(0, V.y, V.z); }
        public static VectorD3 _YW(VectorD4 V){ return VecOps.MkVectorD3(0, V.y, V.w); }
        public static VectorD3 _Y_(VectorD4 V){ return VecOps.MkVectorD3(0, V.y, 0); }
        public static VectorD3 _ZX(VectorD4 V){ return VecOps.MkVectorD3(0, V.z, V.x); }
        public static VectorD3 _ZY(VectorD4 V){ return VecOps.MkVectorD3(0, V.z, V.y); }
        public static VectorD3 _ZZ(VectorD4 V){ return VecOps.MkVectorD3(0, V.z, V.z); }
        public static VectorD3 _ZW(VectorD4 V){ return VecOps.MkVectorD3(0, V.z, V.w); }
        public static VectorD3 _Z_(VectorD4 V){ return VecOps.MkVectorD3(0, V.z, 0); }
        public static VectorD3 _WX(VectorD4 V){ return VecOps.MkVectorD3(0, V.w, V.x); }
        public static VectorD3 _WY(VectorD4 V){ return VecOps.MkVectorD3(0, V.w, V.y); }
        public static VectorD3 _WZ(VectorD4 V){ return VecOps.MkVectorD3(0, V.w, V.z); }
        public static VectorD3 _WW(VectorD4 V){ return VecOps.MkVectorD3(0, V.w, V.w); }
        public static VectorD3 _W_(VectorD4 V){ return VecOps.MkVectorD3(0, V.w, 0); }
        public static VectorD3 __X(VectorD4 V){ return VecOps.MkVectorD3(0, 0, V.x); }
        public static VectorD3 __Y(VectorD4 V){ return VecOps.MkVectorD3(0, 0, V.y); }
        public static VectorD3 __Z(VectorD4 V){ return VecOps.MkVectorD3(0, 0, V.z); }
        public static VectorD3 __W(VectorD4 V){ return VecOps.MkVectorD3(0, 0, V.w); }
        public static VectorD4 XXXX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, V.x); }
        public static VectorD4 XXXY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, V.y); }
        public static VectorD4 XXXZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, V.z); }
        public static VectorD4 XXXW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, V.w); }
        public static VectorD4 XXX_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.x, 0); }
        public static VectorD4 XXYX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, V.x); }
        public static VectorD4 XXYY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, V.y); }
        public static VectorD4 XXYZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, V.z); }
        public static VectorD4 XXYW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, V.w); }
        public static VectorD4 XXY_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.y, 0); }
        public static VectorD4 XXZX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.z, V.x); }
        public static VectorD4 XXZY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.z, V.y); }
        public static VectorD4 XXZZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.z, V.z); }
        public static VectorD4 XXZW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.z, V.w); }
        public static VectorD4 XXZ_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.z, 0); }
        public static VectorD4 XXWX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.w, V.x); }
        public static VectorD4 XXWY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.w, V.y); }
        public static VectorD4 XXWZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.w, V.z); }
        public static VectorD4 XXWW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.w, V.w); }
        public static VectorD4 XXW_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, V.w, 0); }
        public static VectorD4 XX_X(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, 0, V.x); }
        public static VectorD4 XX_Y(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, 0, V.y); }
        public static VectorD4 XX_Z(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, 0, V.z); }
        public static VectorD4 XX_W(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, 0, V.w); }
        public static VectorD4 XX__(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.x, 0, 0); }
        public static VectorD4 XYXX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, V.x); }
        public static VectorD4 XYXY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, V.y); }
        public static VectorD4 XYXZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, V.z); }
        public static VectorD4 XYXW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, V.w); }
        public static VectorD4 XYX_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.x, 0); }
        public static VectorD4 XYYX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, V.x); }
        public static VectorD4 XYYY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, V.y); }
        public static VectorD4 XYYZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, V.z); }
        public static VectorD4 XYYW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, V.w); }
        public static VectorD4 XYY_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.y, 0); }
        public static VectorD4 XYZX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.z, V.x); }
        public static VectorD4 XYZY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.z, V.y); }
        public static VectorD4 XYZZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.z, V.z); }
        public static VectorD4 XYZW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.z, V.w); }
        public static VectorD4 XYZ_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.z, 0); }
        public static VectorD4 XYWX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.w, V.x); }
        public static VectorD4 XYWY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.w, V.y); }
        public static VectorD4 XYWZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.w, V.z); }
        public static VectorD4 XYWW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.w, V.w); }
        public static VectorD4 XYW_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, V.w, 0); }
        public static VectorD4 XY_X(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, 0, V.x); }
        public static VectorD4 XY_Y(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, 0, V.y); }
        public static VectorD4 XY_Z(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, 0, V.z); }
        public static VectorD4 XY_W(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, 0, V.w); }
        public static VectorD4 XY__(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.y, 0, 0); }
        public static VectorD4 XZXX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.x, V.x); }
        public static VectorD4 XZXY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.x, V.y); }
        public static VectorD4 XZXZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.x, V.z); }
        public static VectorD4 XZXW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.x, V.w); }
        public static VectorD4 XZX_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.x, 0); }
        public static VectorD4 XZYX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.y, V.x); }
        public static VectorD4 XZYY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.y, V.y); }
        public static VectorD4 XZYZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.y, V.z); }
        public static VectorD4 XZYW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.y, V.w); }
        public static VectorD4 XZY_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.y, 0); }
        public static VectorD4 XZZX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.z, V.x); }
        public static VectorD4 XZZY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.z, V.y); }
        public static VectorD4 XZZZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.z, V.z); }
        public static VectorD4 XZZW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.z, V.w); }
        public static VectorD4 XZZ_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.z, 0); }
        public static VectorD4 XZWX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.w, V.x); }
        public static VectorD4 XZWY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.w, V.y); }
        public static VectorD4 XZWZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.w, V.z); }
        public static VectorD4 XZWW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.w, V.w); }
        public static VectorD4 XZW_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, V.w, 0); }
        public static VectorD4 XZ_X(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, 0, V.x); }
        public static VectorD4 XZ_Y(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, 0, V.y); }
        public static VectorD4 XZ_Z(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, 0, V.z); }
        public static VectorD4 XZ_W(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, 0, V.w); }
        public static VectorD4 XZ__(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.z, 0, 0); }
        public static VectorD4 XWXX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.x, V.x); }
        public static VectorD4 XWXY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.x, V.y); }
        public static VectorD4 XWXZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.x, V.z); }
        public static VectorD4 XWXW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.x, V.w); }
        public static VectorD4 XWX_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.x, 0); }
        public static VectorD4 XWYX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.y, V.x); }
        public static VectorD4 XWYY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.y, V.y); }
        public static VectorD4 XWYZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.y, V.z); }
        public static VectorD4 XWYW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.y, V.w); }
        public static VectorD4 XWY_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.y, 0); }
        public static VectorD4 XWZX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.z, V.x); }
        public static VectorD4 XWZY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.z, V.y); }
        public static VectorD4 XWZZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.z, V.z); }
        public static VectorD4 XWZW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.z, V.w); }
        public static VectorD4 XWZ_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.z, 0); }
        public static VectorD4 XWWX(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.w, V.x); }
        public static VectorD4 XWWY(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.w, V.y); }
        public static VectorD4 XWWZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.w, V.z); }
        public static VectorD4 XWWW(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.w, V.w); }
        public static VectorD4 XWW_(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, V.w, 0); }
        public static VectorD4 XW_X(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, 0, V.x); }
        public static VectorD4 XW_Y(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, 0, V.y); }
        public static VectorD4 XW_Z(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, 0, V.z); }
        public static VectorD4 XW_W(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, 0, V.w); }
        public static VectorD4 XW__(VectorD4 V){ return VecOps.MkVectorD4(V.x, V.w, 0, 0); }
        public static VectorD4 X_XX(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.x, V.x); }
        public static VectorD4 X_XY(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.x, V.y); }
        public static VectorD4 X_XZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.x, V.z); }
        public static VectorD4 X_XW(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.x, V.w); }
        public static VectorD4 X_X_(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.x, 0); }
        public static VectorD4 X_YX(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.y, V.x); }
        public static VectorD4 X_YY(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.y, V.y); }
        public static VectorD4 X_YZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.y, V.z); }
        public static VectorD4 X_YW(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.y, V.w); }
        public static VectorD4 X_Y_(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.y, 0); }
        public static VectorD4 X_ZX(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.z, V.x); }
        public static VectorD4 X_ZY(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.z, V.y); }
        public static VectorD4 X_ZZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.z, V.z); }
        public static VectorD4 X_ZW(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.z, V.w); }
        public static VectorD4 X_Z_(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.z, 0); }
        public static VectorD4 X_WX(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.w, V.x); }
        public static VectorD4 X_WY(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.w, V.y); }
        public static VectorD4 X_WZ(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.w, V.z); }
        public static VectorD4 X_WW(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.w, V.w); }
        public static VectorD4 X_W_(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, V.w, 0); }
        public static VectorD4 X__X(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, 0, V.x); }
        public static VectorD4 X__Y(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, 0, V.y); }
        public static VectorD4 X__Z(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, 0, V.z); }
        public static VectorD4 X__W(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, 0, V.w); }
        public static VectorD4 X___(VectorD4 V){ return VecOps.MkVectorD4(V.x, 0, 0, 0); }
        public static VectorD4 YXXX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, V.x); }
        public static VectorD4 YXXY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, V.y); }
        public static VectorD4 YXXZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, V.z); }
        public static VectorD4 YXXW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, V.w); }
        public static VectorD4 YXX_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.x, 0); }
        public static VectorD4 YXYX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, V.x); }
        public static VectorD4 YXYY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, V.y); }
        public static VectorD4 YXYZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, V.z); }
        public static VectorD4 YXYW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, V.w); }
        public static VectorD4 YXY_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.y, 0); }
        public static VectorD4 YXZX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.z, V.x); }
        public static VectorD4 YXZY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.z, V.y); }
        public static VectorD4 YXZZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.z, V.z); }
        public static VectorD4 YXZW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.z, V.w); }
        public static VectorD4 YXZ_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.z, 0); }
        public static VectorD4 YXWX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.w, V.x); }
        public static VectorD4 YXWY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.w, V.y); }
        public static VectorD4 YXWZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.w, V.z); }
        public static VectorD4 YXWW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.w, V.w); }
        public static VectorD4 YXW_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, V.w, 0); }
        public static VectorD4 YX_X(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, 0, V.x); }
        public static VectorD4 YX_Y(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, 0, V.y); }
        public static VectorD4 YX_Z(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, 0, V.z); }
        public static VectorD4 YX_W(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, 0, V.w); }
        public static VectorD4 YX__(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.x, 0, 0); }
        public static VectorD4 YYXX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, V.x); }
        public static VectorD4 YYXY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, V.y); }
        public static VectorD4 YYXZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, V.z); }
        public static VectorD4 YYXW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, V.w); }
        public static VectorD4 YYX_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.x, 0); }
        public static VectorD4 YYYX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, V.x); }
        public static VectorD4 YYYY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, V.y); }
        public static VectorD4 YYYZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, V.z); }
        public static VectorD4 YYYW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, V.w); }
        public static VectorD4 YYY_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.y, 0); }
        public static VectorD4 YYZX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.z, V.x); }
        public static VectorD4 YYZY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.z, V.y); }
        public static VectorD4 YYZZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.z, V.z); }
        public static VectorD4 YYZW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.z, V.w); }
        public static VectorD4 YYZ_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.z, 0); }
        public static VectorD4 YYWX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.w, V.x); }
        public static VectorD4 YYWY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.w, V.y); }
        public static VectorD4 YYWZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.w, V.z); }
        public static VectorD4 YYWW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.w, V.w); }
        public static VectorD4 YYW_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, V.w, 0); }
        public static VectorD4 YY_X(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, 0, V.x); }
        public static VectorD4 YY_Y(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, 0, V.y); }
        public static VectorD4 YY_Z(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, 0, V.z); }
        public static VectorD4 YY_W(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, 0, V.w); }
        public static VectorD4 YY__(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.y, 0, 0); }
        public static VectorD4 YZXX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.x, V.x); }
        public static VectorD4 YZXY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.x, V.y); }
        public static VectorD4 YZXZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.x, V.z); }
        public static VectorD4 YZXW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.x, V.w); }
        public static VectorD4 YZX_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.x, 0); }
        public static VectorD4 YZYX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.y, V.x); }
        public static VectorD4 YZYY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.y, V.y); }
        public static VectorD4 YZYZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.y, V.z); }
        public static VectorD4 YZYW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.y, V.w); }
        public static VectorD4 YZY_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.y, 0); }
        public static VectorD4 YZZX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.z, V.x); }
        public static VectorD4 YZZY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.z, V.y); }
        public static VectorD4 YZZZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.z, V.z); }
        public static VectorD4 YZZW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.z, V.w); }
        public static VectorD4 YZZ_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.z, 0); }
        public static VectorD4 YZWX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.w, V.x); }
        public static VectorD4 YZWY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.w, V.y); }
        public static VectorD4 YZWZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.w, V.z); }
        public static VectorD4 YZWW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.w, V.w); }
        public static VectorD4 YZW_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, V.w, 0); }
        public static VectorD4 YZ_X(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, 0, V.x); }
        public static VectorD4 YZ_Y(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, 0, V.y); }
        public static VectorD4 YZ_Z(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, 0, V.z); }
        public static VectorD4 YZ_W(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, 0, V.w); }
        public static VectorD4 YZ__(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.z, 0, 0); }
        public static VectorD4 YWXX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.x, V.x); }
        public static VectorD4 YWXY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.x, V.y); }
        public static VectorD4 YWXZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.x, V.z); }
        public static VectorD4 YWXW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.x, V.w); }
        public static VectorD4 YWX_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.x, 0); }
        public static VectorD4 YWYX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.y, V.x); }
        public static VectorD4 YWYY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.y, V.y); }
        public static VectorD4 YWYZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.y, V.z); }
        public static VectorD4 YWYW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.y, V.w); }
        public static VectorD4 YWY_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.y, 0); }
        public static VectorD4 YWZX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.z, V.x); }
        public static VectorD4 YWZY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.z, V.y); }
        public static VectorD4 YWZZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.z, V.z); }
        public static VectorD4 YWZW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.z, V.w); }
        public static VectorD4 YWZ_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.z, 0); }
        public static VectorD4 YWWX(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.w, V.x); }
        public static VectorD4 YWWY(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.w, V.y); }
        public static VectorD4 YWWZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.w, V.z); }
        public static VectorD4 YWWW(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.w, V.w); }
        public static VectorD4 YWW_(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, V.w, 0); }
        public static VectorD4 YW_X(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, 0, V.x); }
        public static VectorD4 YW_Y(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, 0, V.y); }
        public static VectorD4 YW_Z(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, 0, V.z); }
        public static VectorD4 YW_W(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, 0, V.w); }
        public static VectorD4 YW__(VectorD4 V){ return VecOps.MkVectorD4(V.y, V.w, 0, 0); }
        public static VectorD4 Y_XX(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.x, V.x); }
        public static VectorD4 Y_XY(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.x, V.y); }
        public static VectorD4 Y_XZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.x, V.z); }
        public static VectorD4 Y_XW(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.x, V.w); }
        public static VectorD4 Y_X_(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.x, 0); }
        public static VectorD4 Y_YX(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.y, V.x); }
        public static VectorD4 Y_YY(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.y, V.y); }
        public static VectorD4 Y_YZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.y, V.z); }
        public static VectorD4 Y_YW(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.y, V.w); }
        public static VectorD4 Y_Y_(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.y, 0); }
        public static VectorD4 Y_ZX(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.z, V.x); }
        public static VectorD4 Y_ZY(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.z, V.y); }
        public static VectorD4 Y_ZZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.z, V.z); }
        public static VectorD4 Y_ZW(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.z, V.w); }
        public static VectorD4 Y_Z_(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.z, 0); }
        public static VectorD4 Y_WX(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.w, V.x); }
        public static VectorD4 Y_WY(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.w, V.y); }
        public static VectorD4 Y_WZ(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.w, V.z); }
        public static VectorD4 Y_WW(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.w, V.w); }
        public static VectorD4 Y_W_(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, V.w, 0); }
        public static VectorD4 Y__X(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, 0, V.x); }
        public static VectorD4 Y__Y(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, 0, V.y); }
        public static VectorD4 Y__Z(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, 0, V.z); }
        public static VectorD4 Y__W(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, 0, V.w); }
        public static VectorD4 Y___(VectorD4 V){ return VecOps.MkVectorD4(V.y, 0, 0, 0); }
        public static VectorD4 ZXXX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.x, V.x); }
        public static VectorD4 ZXXY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.x, V.y); }
        public static VectorD4 ZXXZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.x, V.z); }
        public static VectorD4 ZXXW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.x, V.w); }
        public static VectorD4 ZXX_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.x, 0); }
        public static VectorD4 ZXYX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.y, V.x); }
        public static VectorD4 ZXYY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.y, V.y); }
        public static VectorD4 ZXYZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.y, V.z); }
        public static VectorD4 ZXYW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.y, V.w); }
        public static VectorD4 ZXY_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.y, 0); }
        public static VectorD4 ZXZX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.z, V.x); }
        public static VectorD4 ZXZY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.z, V.y); }
        public static VectorD4 ZXZZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.z, V.z); }
        public static VectorD4 ZXZW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.z, V.w); }
        public static VectorD4 ZXZ_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.z, 0); }
        public static VectorD4 ZXWX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.w, V.x); }
        public static VectorD4 ZXWY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.w, V.y); }
        public static VectorD4 ZXWZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.w, V.z); }
        public static VectorD4 ZXWW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.w, V.w); }
        public static VectorD4 ZXW_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, V.w, 0); }
        public static VectorD4 ZX_X(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, 0, V.x); }
        public static VectorD4 ZX_Y(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, 0, V.y); }
        public static VectorD4 ZX_Z(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, 0, V.z); }
        public static VectorD4 ZX_W(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, 0, V.w); }
        public static VectorD4 ZX__(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.x, 0, 0); }
        public static VectorD4 ZYXX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.x, V.x); }
        public static VectorD4 ZYXY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.x, V.y); }
        public static VectorD4 ZYXZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.x, V.z); }
        public static VectorD4 ZYXW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.x, V.w); }
        public static VectorD4 ZYX_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.x, 0); }
        public static VectorD4 ZYYX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.y, V.x); }
        public static VectorD4 ZYYY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.y, V.y); }
        public static VectorD4 ZYYZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.y, V.z); }
        public static VectorD4 ZYYW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.y, V.w); }
        public static VectorD4 ZYY_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.y, 0); }
        public static VectorD4 ZYZX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.z, V.x); }
        public static VectorD4 ZYZY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.z, V.y); }
        public static VectorD4 ZYZZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.z, V.z); }
        public static VectorD4 ZYZW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.z, V.w); }
        public static VectorD4 ZYZ_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.z, 0); }
        public static VectorD4 ZYWX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.w, V.x); }
        public static VectorD4 ZYWY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.w, V.y); }
        public static VectorD4 ZYWZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.w, V.z); }
        public static VectorD4 ZYWW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.w, V.w); }
        public static VectorD4 ZYW_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, V.w, 0); }
        public static VectorD4 ZY_X(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, 0, V.x); }
        public static VectorD4 ZY_Y(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, 0, V.y); }
        public static VectorD4 ZY_Z(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, 0, V.z); }
        public static VectorD4 ZY_W(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, 0, V.w); }
        public static VectorD4 ZY__(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.y, 0, 0); }
        public static VectorD4 ZZXX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.x, V.x); }
        public static VectorD4 ZZXY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.x, V.y); }
        public static VectorD4 ZZXZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.x, V.z); }
        public static VectorD4 ZZXW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.x, V.w); }
        public static VectorD4 ZZX_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.x, 0); }
        public static VectorD4 ZZYX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.y, V.x); }
        public static VectorD4 ZZYY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.y, V.y); }
        public static VectorD4 ZZYZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.y, V.z); }
        public static VectorD4 ZZYW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.y, V.w); }
        public static VectorD4 ZZY_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.y, 0); }
        public static VectorD4 ZZZX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.z, V.x); }
        public static VectorD4 ZZZY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.z, V.y); }
        public static VectorD4 ZZZZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.z, V.z); }
        public static VectorD4 ZZZW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.z, V.w); }
        public static VectorD4 ZZZ_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.z, 0); }
        public static VectorD4 ZZWX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.w, V.x); }
        public static VectorD4 ZZWY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.w, V.y); }
        public static VectorD4 ZZWZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.w, V.z); }
        public static VectorD4 ZZWW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.w, V.w); }
        public static VectorD4 ZZW_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, V.w, 0); }
        public static VectorD4 ZZ_X(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, 0, V.x); }
        public static VectorD4 ZZ_Y(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, 0, V.y); }
        public static VectorD4 ZZ_Z(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, 0, V.z); }
        public static VectorD4 ZZ_W(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, 0, V.w); }
        public static VectorD4 ZZ__(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.z, 0, 0); }
        public static VectorD4 ZWXX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.x, V.x); }
        public static VectorD4 ZWXY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.x, V.y); }
        public static VectorD4 ZWXZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.x, V.z); }
        public static VectorD4 ZWXW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.x, V.w); }
        public static VectorD4 ZWX_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.x, 0); }
        public static VectorD4 ZWYX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.y, V.x); }
        public static VectorD4 ZWYY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.y, V.y); }
        public static VectorD4 ZWYZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.y, V.z); }
        public static VectorD4 ZWYW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.y, V.w); }
        public static VectorD4 ZWY_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.y, 0); }
        public static VectorD4 ZWZX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.z, V.x); }
        public static VectorD4 ZWZY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.z, V.y); }
        public static VectorD4 ZWZZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.z, V.z); }
        public static VectorD4 ZWZW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.z, V.w); }
        public static VectorD4 ZWZ_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.z, 0); }
        public static VectorD4 ZWWX(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.w, V.x); }
        public static VectorD4 ZWWY(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.w, V.y); }
        public static VectorD4 ZWWZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.w, V.z); }
        public static VectorD4 ZWWW(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.w, V.w); }
        public static VectorD4 ZWW_(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, V.w, 0); }
        public static VectorD4 ZW_X(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, 0, V.x); }
        public static VectorD4 ZW_Y(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, 0, V.y); }
        public static VectorD4 ZW_Z(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, 0, V.z); }
        public static VectorD4 ZW_W(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, 0, V.w); }
        public static VectorD4 ZW__(VectorD4 V){ return VecOps.MkVectorD4(V.z, V.w, 0, 0); }
        public static VectorD4 Z_XX(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.x, V.x); }
        public static VectorD4 Z_XY(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.x, V.y); }
        public static VectorD4 Z_XZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.x, V.z); }
        public static VectorD4 Z_XW(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.x, V.w); }
        public static VectorD4 Z_X_(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.x, 0); }
        public static VectorD4 Z_YX(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.y, V.x); }
        public static VectorD4 Z_YY(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.y, V.y); }
        public static VectorD4 Z_YZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.y, V.z); }
        public static VectorD4 Z_YW(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.y, V.w); }
        public static VectorD4 Z_Y_(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.y, 0); }
        public static VectorD4 Z_ZX(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.z, V.x); }
        public static VectorD4 Z_ZY(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.z, V.y); }
        public static VectorD4 Z_ZZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.z, V.z); }
        public static VectorD4 Z_ZW(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.z, V.w); }
        public static VectorD4 Z_Z_(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.z, 0); }
        public static VectorD4 Z_WX(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.w, V.x); }
        public static VectorD4 Z_WY(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.w, V.y); }
        public static VectorD4 Z_WZ(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.w, V.z); }
        public static VectorD4 Z_WW(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.w, V.w); }
        public static VectorD4 Z_W_(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, V.w, 0); }
        public static VectorD4 Z__X(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, 0, V.x); }
        public static VectorD4 Z__Y(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, 0, V.y); }
        public static VectorD4 Z__Z(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, 0, V.z); }
        public static VectorD4 Z__W(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, 0, V.w); }
        public static VectorD4 Z___(VectorD4 V){ return VecOps.MkVectorD4(V.z, 0, 0, 0); }
        public static VectorD4 WXXX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.x, V.x); }
        public static VectorD4 WXXY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.x, V.y); }
        public static VectorD4 WXXZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.x, V.z); }
        public static VectorD4 WXXW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.x, V.w); }
        public static VectorD4 WXX_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.x, 0); }
        public static VectorD4 WXYX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.y, V.x); }
        public static VectorD4 WXYY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.y, V.y); }
        public static VectorD4 WXYZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.y, V.z); }
        public static VectorD4 WXYW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.y, V.w); }
        public static VectorD4 WXY_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.y, 0); }
        public static VectorD4 WXZX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.z, V.x); }
        public static VectorD4 WXZY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.z, V.y); }
        public static VectorD4 WXZZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.z, V.z); }
        public static VectorD4 WXZW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.z, V.w); }
        public static VectorD4 WXZ_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.z, 0); }
        public static VectorD4 WXWX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.w, V.x); }
        public static VectorD4 WXWY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.w, V.y); }
        public static VectorD4 WXWZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.w, V.z); }
        public static VectorD4 WXWW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.w, V.w); }
        public static VectorD4 WXW_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, V.w, 0); }
        public static VectorD4 WX_X(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, 0, V.x); }
        public static VectorD4 WX_Y(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, 0, V.y); }
        public static VectorD4 WX_Z(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, 0, V.z); }
        public static VectorD4 WX_W(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, 0, V.w); }
        public static VectorD4 WX__(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.x, 0, 0); }
        public static VectorD4 WYXX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.x, V.x); }
        public static VectorD4 WYXY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.x, V.y); }
        public static VectorD4 WYXZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.x, V.z); }
        public static VectorD4 WYXW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.x, V.w); }
        public static VectorD4 WYX_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.x, 0); }
        public static VectorD4 WYYX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.y, V.x); }
        public static VectorD4 WYYY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.y, V.y); }
        public static VectorD4 WYYZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.y, V.z); }
        public static VectorD4 WYYW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.y, V.w); }
        public static VectorD4 WYY_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.y, 0); }
        public static VectorD4 WYZX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.z, V.x); }
        public static VectorD4 WYZY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.z, V.y); }
        public static VectorD4 WYZZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.z, V.z); }
        public static VectorD4 WYZW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.z, V.w); }
        public static VectorD4 WYZ_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.z, 0); }
        public static VectorD4 WYWX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.w, V.x); }
        public static VectorD4 WYWY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.w, V.y); }
        public static VectorD4 WYWZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.w, V.z); }
        public static VectorD4 WYWW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.w, V.w); }
        public static VectorD4 WYW_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, V.w, 0); }
        public static VectorD4 WY_X(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, 0, V.x); }
        public static VectorD4 WY_Y(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, 0, V.y); }
        public static VectorD4 WY_Z(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, 0, V.z); }
        public static VectorD4 WY_W(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, 0, V.w); }
        public static VectorD4 WY__(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.y, 0, 0); }
        public static VectorD4 WZXX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.x, V.x); }
        public static VectorD4 WZXY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.x, V.y); }
        public static VectorD4 WZXZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.x, V.z); }
        public static VectorD4 WZXW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.x, V.w); }
        public static VectorD4 WZX_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.x, 0); }
        public static VectorD4 WZYX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.y, V.x); }
        public static VectorD4 WZYY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.y, V.y); }
        public static VectorD4 WZYZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.y, V.z); }
        public static VectorD4 WZYW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.y, V.w); }
        public static VectorD4 WZY_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.y, 0); }
        public static VectorD4 WZZX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.z, V.x); }
        public static VectorD4 WZZY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.z, V.y); }
        public static VectorD4 WZZZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.z, V.z); }
        public static VectorD4 WZZW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.z, V.w); }
        public static VectorD4 WZZ_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.z, 0); }
        public static VectorD4 WZWX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.w, V.x); }
        public static VectorD4 WZWY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.w, V.y); }
        public static VectorD4 WZWZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.w, V.z); }
        public static VectorD4 WZWW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.w, V.w); }
        public static VectorD4 WZW_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, V.w, 0); }
        public static VectorD4 WZ_X(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, 0, V.x); }
        public static VectorD4 WZ_Y(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, 0, V.y); }
        public static VectorD4 WZ_Z(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, 0, V.z); }
        public static VectorD4 WZ_W(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, 0, V.w); }
        public static VectorD4 WZ__(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.z, 0, 0); }
        public static VectorD4 WWXX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.x, V.x); }
        public static VectorD4 WWXY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.x, V.y); }
        public static VectorD4 WWXZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.x, V.z); }
        public static VectorD4 WWXW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.x, V.w); }
        public static VectorD4 WWX_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.x, 0); }
        public static VectorD4 WWYX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.y, V.x); }
        public static VectorD4 WWYY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.y, V.y); }
        public static VectorD4 WWYZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.y, V.z); }
        public static VectorD4 WWYW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.y, V.w); }
        public static VectorD4 WWY_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.y, 0); }
        public static VectorD4 WWZX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.z, V.x); }
        public static VectorD4 WWZY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.z, V.y); }
        public static VectorD4 WWZZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.z, V.z); }
        public static VectorD4 WWZW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.z, V.w); }
        public static VectorD4 WWZ_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.z, 0); }
        public static VectorD4 WWWX(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.w, V.x); }
        public static VectorD4 WWWY(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.w, V.y); }
        public static VectorD4 WWWZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.w, V.z); }
        public static VectorD4 WWWW(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.w, V.w); }
        public static VectorD4 WWW_(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, V.w, 0); }
        public static VectorD4 WW_X(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, 0, V.x); }
        public static VectorD4 WW_Y(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, 0, V.y); }
        public static VectorD4 WW_Z(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, 0, V.z); }
        public static VectorD4 WW_W(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, 0, V.w); }
        public static VectorD4 WW__(VectorD4 V){ return VecOps.MkVectorD4(V.w, V.w, 0, 0); }
        public static VectorD4 W_XX(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.x, V.x); }
        public static VectorD4 W_XY(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.x, V.y); }
        public static VectorD4 W_XZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.x, V.z); }
        public static VectorD4 W_XW(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.x, V.w); }
        public static VectorD4 W_X_(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.x, 0); }
        public static VectorD4 W_YX(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.y, V.x); }
        public static VectorD4 W_YY(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.y, V.y); }
        public static VectorD4 W_YZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.y, V.z); }
        public static VectorD4 W_YW(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.y, V.w); }
        public static VectorD4 W_Y_(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.y, 0); }
        public static VectorD4 W_ZX(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.z, V.x); }
        public static VectorD4 W_ZY(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.z, V.y); }
        public static VectorD4 W_ZZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.z, V.z); }
        public static VectorD4 W_ZW(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.z, V.w); }
        public static VectorD4 W_Z_(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.z, 0); }
        public static VectorD4 W_WX(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.w, V.x); }
        public static VectorD4 W_WY(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.w, V.y); }
        public static VectorD4 W_WZ(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.w, V.z); }
        public static VectorD4 W_WW(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.w, V.w); }
        public static VectorD4 W_W_(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, V.w, 0); }
        public static VectorD4 W__X(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, 0, V.x); }
        public static VectorD4 W__Y(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, 0, V.y); }
        public static VectorD4 W__Z(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, 0, V.z); }
        public static VectorD4 W__W(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, 0, V.w); }
        public static VectorD4 W___(VectorD4 V){ return VecOps.MkVectorD4(V.w, 0, 0, 0); }
        public static VectorD4 _XXX(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.x, V.x); }
        public static VectorD4 _XXY(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.x, V.y); }
        public static VectorD4 _XXZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.x, V.z); }
        public static VectorD4 _XXW(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.x, V.w); }
        public static VectorD4 _XX_(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.x, 0); }
        public static VectorD4 _XYX(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.y, V.x); }
        public static VectorD4 _XYY(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.y, V.y); }
        public static VectorD4 _XYZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.y, V.z); }
        public static VectorD4 _XYW(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.y, V.w); }
        public static VectorD4 _XY_(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.y, 0); }
        public static VectorD4 _XZX(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.z, V.x); }
        public static VectorD4 _XZY(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.z, V.y); }
        public static VectorD4 _XZZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.z, V.z); }
        public static VectorD4 _XZW(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.z, V.w); }
        public static VectorD4 _XZ_(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.z, 0); }
        public static VectorD4 _XWX(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.w, V.x); }
        public static VectorD4 _XWY(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.w, V.y); }
        public static VectorD4 _XWZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.w, V.z); }
        public static VectorD4 _XWW(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.w, V.w); }
        public static VectorD4 _XW_(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, V.w, 0); }
        public static VectorD4 _X_X(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, 0, V.x); }
        public static VectorD4 _X_Y(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, 0, V.y); }
        public static VectorD4 _X_Z(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, 0, V.z); }
        public static VectorD4 _X_W(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, 0, V.w); }
        public static VectorD4 _X__(VectorD4 V){ return VecOps.MkVectorD4(0, V.x, 0, 0); }
        public static VectorD4 _YXX(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.x, V.x); }
        public static VectorD4 _YXY(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.x, V.y); }
        public static VectorD4 _YXZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.x, V.z); }
        public static VectorD4 _YXW(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.x, V.w); }
        public static VectorD4 _YX_(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.x, 0); }
        public static VectorD4 _YYX(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.y, V.x); }
        public static VectorD4 _YYY(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.y, V.y); }
        public static VectorD4 _YYZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.y, V.z); }
        public static VectorD4 _YYW(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.y, V.w); }
        public static VectorD4 _YY_(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.y, 0); }
        public static VectorD4 _YZX(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.z, V.x); }
        public static VectorD4 _YZY(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.z, V.y); }
        public static VectorD4 _YZZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.z, V.z); }
        public static VectorD4 _YZW(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.z, V.w); }
        public static VectorD4 _YZ_(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.z, 0); }
        public static VectorD4 _YWX(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.w, V.x); }
        public static VectorD4 _YWY(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.w, V.y); }
        public static VectorD4 _YWZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.w, V.z); }
        public static VectorD4 _YWW(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.w, V.w); }
        public static VectorD4 _YW_(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, V.w, 0); }
        public static VectorD4 _Y_X(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, 0, V.x); }
        public static VectorD4 _Y_Y(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, 0, V.y); }
        public static VectorD4 _Y_Z(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, 0, V.z); }
        public static VectorD4 _Y_W(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, 0, V.w); }
        public static VectorD4 _Y__(VectorD4 V){ return VecOps.MkVectorD4(0, V.y, 0, 0); }
        public static VectorD4 _ZXX(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.x, V.x); }
        public static VectorD4 _ZXY(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.x, V.y); }
        public static VectorD4 _ZXZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.x, V.z); }
        public static VectorD4 _ZXW(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.x, V.w); }
        public static VectorD4 _ZX_(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.x, 0); }
        public static VectorD4 _ZYX(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.y, V.x); }
        public static VectorD4 _ZYY(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.y, V.y); }
        public static VectorD4 _ZYZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.y, V.z); }
        public static VectorD4 _ZYW(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.y, V.w); }
        public static VectorD4 _ZY_(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.y, 0); }
        public static VectorD4 _ZZX(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.z, V.x); }
        public static VectorD4 _ZZY(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.z, V.y); }
        public static VectorD4 _ZZZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.z, V.z); }
        public static VectorD4 _ZZW(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.z, V.w); }
        public static VectorD4 _ZZ_(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.z, 0); }
        public static VectorD4 _ZWX(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.w, V.x); }
        public static VectorD4 _ZWY(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.w, V.y); }
        public static VectorD4 _ZWZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.w, V.z); }
        public static VectorD4 _ZWW(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.w, V.w); }
        public static VectorD4 _ZW_(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, V.w, 0); }
        public static VectorD4 _Z_X(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, 0, V.x); }
        public static VectorD4 _Z_Y(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, 0, V.y); }
        public static VectorD4 _Z_Z(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, 0, V.z); }
        public static VectorD4 _Z_W(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, 0, V.w); }
        public static VectorD4 _Z__(VectorD4 V){ return VecOps.MkVectorD4(0, V.z, 0, 0); }
        public static VectorD4 _WXX(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.x, V.x); }
        public static VectorD4 _WXY(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.x, V.y); }
        public static VectorD4 _WXZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.x, V.z); }
        public static VectorD4 _WXW(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.x, V.w); }
        public static VectorD4 _WX_(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.x, 0); }
        public static VectorD4 _WYX(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.y, V.x); }
        public static VectorD4 _WYY(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.y, V.y); }
        public static VectorD4 _WYZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.y, V.z); }
        public static VectorD4 _WYW(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.y, V.w); }
        public static VectorD4 _WY_(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.y, 0); }
        public static VectorD4 _WZX(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.z, V.x); }
        public static VectorD4 _WZY(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.z, V.y); }
        public static VectorD4 _WZZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.z, V.z); }
        public static VectorD4 _WZW(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.z, V.w); }
        public static VectorD4 _WZ_(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.z, 0); }
        public static VectorD4 _WWX(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.w, V.x); }
        public static VectorD4 _WWY(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.w, V.y); }
        public static VectorD4 _WWZ(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.w, V.z); }
        public static VectorD4 _WWW(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.w, V.w); }
        public static VectorD4 _WW_(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, V.w, 0); }
        public static VectorD4 _W_X(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, 0, V.x); }
        public static VectorD4 _W_Y(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, 0, V.y); }
        public static VectorD4 _W_Z(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, 0, V.z); }
        public static VectorD4 _W_W(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, 0, V.w); }
        public static VectorD4 _W__(VectorD4 V){ return VecOps.MkVectorD4(0, V.w, 0, 0); }
        public static VectorD4 __XX(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.x, V.x); }
        public static VectorD4 __XY(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.x, V.y); }
        public static VectorD4 __XZ(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.x, V.z); }
        public static VectorD4 __XW(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.x, V.w); }
        public static VectorD4 __X_(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.x, 0); }
        public static VectorD4 __YX(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.y, V.x); }
        public static VectorD4 __YY(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.y, V.y); }
        public static VectorD4 __YZ(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.y, V.z); }
        public static VectorD4 __YW(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.y, V.w); }
        public static VectorD4 __Y_(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.y, 0); }
        public static VectorD4 __ZX(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.z, V.x); }
        public static VectorD4 __ZY(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.z, V.y); }
        public static VectorD4 __ZZ(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.z, V.z); }
        public static VectorD4 __ZW(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.z, V.w); }
        public static VectorD4 __Z_(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.z, 0); }
        public static VectorD4 __WX(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.w, V.x); }
        public static VectorD4 __WY(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.w, V.y); }
        public static VectorD4 __WZ(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.w, V.z); }
        public static VectorD4 __WW(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.w, V.w); }
        public static VectorD4 __W_(VectorD4 V){ return VecOps.MkVectorD4(0, 0, V.w, 0); }
        public static VectorD4 ___X(VectorD4 V){ return VecOps.MkVectorD4(0, 0, 0, V.x); }
        public static VectorD4 ___Y(VectorD4 V){ return VecOps.MkVectorD4(0, 0, 0, V.y); }
        public static VectorD4 ___Z(VectorD4 V){ return VecOps.MkVectorD4(0, 0, 0, V.z); }
        public static VectorD4 ___W(VectorD4 V){ return VecOps.MkVectorD4(0, 0, 0, V.w); }
        public static Vector2 XX(Vector2 V){ return VecOps.MkVector2(V.x, V.x); }
        public static Vector2 XY(Vector2 V){ return VecOps.MkVector2(V.x, V.y); }
        public static Vector2 X_(Vector2 V){ return VecOps.MkVector2(V.x, 0); }
        public static Vector2 YX(Vector2 V){ return VecOps.MkVector2(V.y, V.x); }
        public static Vector2 YY(Vector2 V){ return VecOps.MkVector2(V.y, V.y); }
        public static Vector2 Y_(Vector2 V){ return VecOps.MkVector2(V.y, 0); }
        public static Vector2 _X(Vector2 V){ return VecOps.MkVector2(0, V.x); }
        public static Vector2 _Y(Vector2 V){ return VecOps.MkVector2(0, V.y); }
        public static Vector3 XXX(Vector2 V){ return VecOps.MkVector3(V.x, V.x, V.x); }
        public static Vector3 XXY(Vector2 V){ return VecOps.MkVector3(V.x, V.x, V.y); }
        public static Vector3 XX_(Vector2 V){ return VecOps.MkVector3(V.x, V.x, 0); }
        public static Vector3 XYX(Vector2 V){ return VecOps.MkVector3(V.x, V.y, V.x); }
        public static Vector3 XYY(Vector2 V){ return VecOps.MkVector3(V.x, V.y, V.y); }
        public static Vector3 XY_(Vector2 V){ return VecOps.MkVector3(V.x, V.y, 0); }
        public static Vector3 X_X(Vector2 V){ return VecOps.MkVector3(V.x, 0, V.x); }
        public static Vector3 X_Y(Vector2 V){ return VecOps.MkVector3(V.x, 0, V.y); }
        public static Vector3 X__(Vector2 V){ return VecOps.MkVector3(V.x, 0, 0); }
        public static Vector3 YXX(Vector2 V){ return VecOps.MkVector3(V.y, V.x, V.x); }
        public static Vector3 YXY(Vector2 V){ return VecOps.MkVector3(V.y, V.x, V.y); }
        public static Vector3 YX_(Vector2 V){ return VecOps.MkVector3(V.y, V.x, 0); }
        public static Vector3 YYX(Vector2 V){ return VecOps.MkVector3(V.y, V.y, V.x); }
        public static Vector3 YYY(Vector2 V){ return VecOps.MkVector3(V.y, V.y, V.y); }
        public static Vector3 YY_(Vector2 V){ return VecOps.MkVector3(V.y, V.y, 0); }
        public static Vector3 Y_X(Vector2 V){ return VecOps.MkVector3(V.y, 0, V.x); }
        public static Vector3 Y_Y(Vector2 V){ return VecOps.MkVector3(V.y, 0, V.y); }
        public static Vector3 Y__(Vector2 V){ return VecOps.MkVector3(V.y, 0, 0); }
        public static Vector3 _XX(Vector2 V){ return VecOps.MkVector3(0, V.x, V.x); }
        public static Vector3 _XY(Vector2 V){ return VecOps.MkVector3(0, V.x, V.y); }
        public static Vector3 _X_(Vector2 V){ return VecOps.MkVector3(0, V.x, 0); }
        public static Vector3 _YX(Vector2 V){ return VecOps.MkVector3(0, V.y, V.x); }
        public static Vector3 _YY(Vector2 V){ return VecOps.MkVector3(0, V.y, V.y); }
        public static Vector3 _Y_(Vector2 V){ return VecOps.MkVector3(0, V.y, 0); }
        public static Vector3 __X(Vector2 V){ return VecOps.MkVector3(0, 0, V.x); }
        public static Vector3 __Y(Vector2 V){ return VecOps.MkVector3(0, 0, V.y); }
        public static Vector4 XXXX(Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.x); }
        public static Vector4 XXXY(Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.y); }
        public static Vector4 XXX_(Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.x, 0); }
        public static Vector4 XXYX(Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.x); }
        public static Vector4 XXYY(Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.y); }
        public static Vector4 XXY_(Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.y, 0); }
        public static Vector4 XX_X(Vector2 V){ return VecOps.MkVector4(V.x, V.x, 0, V.x); }
        public static Vector4 XX_Y(Vector2 V){ return VecOps.MkVector4(V.x, V.x, 0, V.y); }
        public static Vector4 XX__(Vector2 V){ return VecOps.MkVector4(V.x, V.x, 0, 0); }
        public static Vector4 XYXX(Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.x); }
        public static Vector4 XYXY(Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.y); }
        public static Vector4 XYX_(Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.x, 0); }
        public static Vector4 XYYX(Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.x); }
        public static Vector4 XYYY(Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.y); }
        public static Vector4 XYY_(Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.y, 0); }
        public static Vector4 XY_X(Vector2 V){ return VecOps.MkVector4(V.x, V.y, 0, V.x); }
        public static Vector4 XY_Y(Vector2 V){ return VecOps.MkVector4(V.x, V.y, 0, V.y); }
        public static Vector4 XY__(Vector2 V){ return VecOps.MkVector4(V.x, V.y, 0, 0); }
        public static Vector4 X_XX(Vector2 V){ return VecOps.MkVector4(V.x, 0, V.x, V.x); }
        public static Vector4 X_XY(Vector2 V){ return VecOps.MkVector4(V.x, 0, V.x, V.y); }
        public static Vector4 X_X_(Vector2 V){ return VecOps.MkVector4(V.x, 0, V.x, 0); }
        public static Vector4 X_YX(Vector2 V){ return VecOps.MkVector4(V.x, 0, V.y, V.x); }
        public static Vector4 X_YY(Vector2 V){ return VecOps.MkVector4(V.x, 0, V.y, V.y); }
        public static Vector4 X_Y_(Vector2 V){ return VecOps.MkVector4(V.x, 0, V.y, 0); }
        public static Vector4 X__X(Vector2 V){ return VecOps.MkVector4(V.x, 0, 0, V.x); }
        public static Vector4 X__Y(Vector2 V){ return VecOps.MkVector4(V.x, 0, 0, V.y); }
        public static Vector4 X___(Vector2 V){ return VecOps.MkVector4(V.x, 0, 0, 0); }
        public static Vector4 YXXX(Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.x); }
        public static Vector4 YXXY(Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.y); }
        public static Vector4 YXX_(Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.x, 0); }
        public static Vector4 YXYX(Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.x); }
        public static Vector4 YXYY(Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.y); }
        public static Vector4 YXY_(Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.y, 0); }
        public static Vector4 YX_X(Vector2 V){ return VecOps.MkVector4(V.y, V.x, 0, V.x); }
        public static Vector4 YX_Y(Vector2 V){ return VecOps.MkVector4(V.y, V.x, 0, V.y); }
        public static Vector4 YX__(Vector2 V){ return VecOps.MkVector4(V.y, V.x, 0, 0); }
        public static Vector4 YYXX(Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.x); }
        public static Vector4 YYXY(Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.y); }
        public static Vector4 YYX_(Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.x, 0); }
        public static Vector4 YYYX(Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.x); }
        public static Vector4 YYYY(Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.y); }
        public static Vector4 YYY_(Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.y, 0); }
        public static Vector4 YY_X(Vector2 V){ return VecOps.MkVector4(V.y, V.y, 0, V.x); }
        public static Vector4 YY_Y(Vector2 V){ return VecOps.MkVector4(V.y, V.y, 0, V.y); }
        public static Vector4 YY__(Vector2 V){ return VecOps.MkVector4(V.y, V.y, 0, 0); }
        public static Vector4 Y_XX(Vector2 V){ return VecOps.MkVector4(V.y, 0, V.x, V.x); }
        public static Vector4 Y_XY(Vector2 V){ return VecOps.MkVector4(V.y, 0, V.x, V.y); }
        public static Vector4 Y_X_(Vector2 V){ return VecOps.MkVector4(V.y, 0, V.x, 0); }
        public static Vector4 Y_YX(Vector2 V){ return VecOps.MkVector4(V.y, 0, V.y, V.x); }
        public static Vector4 Y_YY(Vector2 V){ return VecOps.MkVector4(V.y, 0, V.y, V.y); }
        public static Vector4 Y_Y_(Vector2 V){ return VecOps.MkVector4(V.y, 0, V.y, 0); }
        public static Vector4 Y__X(Vector2 V){ return VecOps.MkVector4(V.y, 0, 0, V.x); }
        public static Vector4 Y__Y(Vector2 V){ return VecOps.MkVector4(V.y, 0, 0, V.y); }
        public static Vector4 Y___(Vector2 V){ return VecOps.MkVector4(V.y, 0, 0, 0); }
        public static Vector4 _XXX(Vector2 V){ return VecOps.MkVector4(0, V.x, V.x, V.x); }
        public static Vector4 _XXY(Vector2 V){ return VecOps.MkVector4(0, V.x, V.x, V.y); }
        public static Vector4 _XX_(Vector2 V){ return VecOps.MkVector4(0, V.x, V.x, 0); }
        public static Vector4 _XYX(Vector2 V){ return VecOps.MkVector4(0, V.x, V.y, V.x); }
        public static Vector4 _XYY(Vector2 V){ return VecOps.MkVector4(0, V.x, V.y, V.y); }
        public static Vector4 _XY_(Vector2 V){ return VecOps.MkVector4(0, V.x, V.y, 0); }
        public static Vector4 _X_X(Vector2 V){ return VecOps.MkVector4(0, V.x, 0, V.x); }
        public static Vector4 _X_Y(Vector2 V){ return VecOps.MkVector4(0, V.x, 0, V.y); }
        public static Vector4 _X__(Vector2 V){ return VecOps.MkVector4(0, V.x, 0, 0); }
        public static Vector4 _YXX(Vector2 V){ return VecOps.MkVector4(0, V.y, V.x, V.x); }
        public static Vector4 _YXY(Vector2 V){ return VecOps.MkVector4(0, V.y, V.x, V.y); }
        public static Vector4 _YX_(Vector2 V){ return VecOps.MkVector4(0, V.y, V.x, 0); }
        public static Vector4 _YYX(Vector2 V){ return VecOps.MkVector4(0, V.y, V.y, V.x); }
        public static Vector4 _YYY(Vector2 V){ return VecOps.MkVector4(0, V.y, V.y, V.y); }
        public static Vector4 _YY_(Vector2 V){ return VecOps.MkVector4(0, V.y, V.y, 0); }
        public static Vector4 _Y_X(Vector2 V){ return VecOps.MkVector4(0, V.y, 0, V.x); }
        public static Vector4 _Y_Y(Vector2 V){ return VecOps.MkVector4(0, V.y, 0, V.y); }
        public static Vector4 _Y__(Vector2 V){ return VecOps.MkVector4(0, V.y, 0, 0); }
        public static Vector4 __XX(Vector2 V){ return VecOps.MkVector4(0, 0, V.x, V.x); }
        public static Vector4 __XY(Vector2 V){ return VecOps.MkVector4(0, 0, V.x, V.y); }
        public static Vector4 __X_(Vector2 V){ return VecOps.MkVector4(0, 0, V.x, 0); }
        public static Vector4 __YX(Vector2 V){ return VecOps.MkVector4(0, 0, V.y, V.x); }
        public static Vector4 __YY(Vector2 V){ return VecOps.MkVector4(0, 0, V.y, V.y); }
        public static Vector4 __Y_(Vector2 V){ return VecOps.MkVector4(0, 0, V.y, 0); }
        public static Vector4 ___X(Vector2 V){ return VecOps.MkVector4(0, 0, 0, V.x); }
        public static Vector4 ___Y(Vector2 V){ return VecOps.MkVector4(0, 0, 0, V.y); }
        public static Vector2 XX(Vector3 V){ return VecOps.MkVector2(V.x, V.x); }
        public static Vector2 XY(Vector3 V){ return VecOps.MkVector2(V.x, V.y); }
        public static Vector2 XZ(Vector3 V){ return VecOps.MkVector2(V.x, V.z); }
        public static Vector2 X_(Vector3 V){ return VecOps.MkVector2(V.x, 0); }
        public static Vector2 YX(Vector3 V){ return VecOps.MkVector2(V.y, V.x); }
        public static Vector2 YY(Vector3 V){ return VecOps.MkVector2(V.y, V.y); }
        public static Vector2 YZ(Vector3 V){ return VecOps.MkVector2(V.y, V.z); }
        public static Vector2 Y_(Vector3 V){ return VecOps.MkVector2(V.y, 0); }
        public static Vector2 ZX(Vector3 V){ return VecOps.MkVector2(V.z, V.x); }
        public static Vector2 ZY(Vector3 V){ return VecOps.MkVector2(V.z, V.y); }
        public static Vector2 ZZ(Vector3 V){ return VecOps.MkVector2(V.z, V.z); }
        public static Vector2 Z_(Vector3 V){ return VecOps.MkVector2(V.z, 0); }
        public static Vector2 _X(Vector3 V){ return VecOps.MkVector2(0, V.x); }
        public static Vector2 _Y(Vector3 V){ return VecOps.MkVector2(0, V.y); }
        public static Vector2 _Z(Vector3 V){ return VecOps.MkVector2(0, V.z); }
        public static Vector3 XXX(Vector3 V){ return VecOps.MkVector3(V.x, V.x, V.x); }
        public static Vector3 XXY(Vector3 V){ return VecOps.MkVector3(V.x, V.x, V.y); }
        public static Vector3 XXZ(Vector3 V){ return VecOps.MkVector3(V.x, V.x, V.z); }
        public static Vector3 XX_(Vector3 V){ return VecOps.MkVector3(V.x, V.x, 0); }
        public static Vector3 XYX(Vector3 V){ return VecOps.MkVector3(V.x, V.y, V.x); }
        public static Vector3 XYY(Vector3 V){ return VecOps.MkVector3(V.x, V.y, V.y); }
        public static Vector3 XYZ(Vector3 V){ return VecOps.MkVector3(V.x, V.y, V.z); }
        public static Vector3 XY_(Vector3 V){ return VecOps.MkVector3(V.x, V.y, 0); }
        public static Vector3 XZX(Vector3 V){ return VecOps.MkVector3(V.x, V.z, V.x); }
        public static Vector3 XZY(Vector3 V){ return VecOps.MkVector3(V.x, V.z, V.y); }
        public static Vector3 XZZ(Vector3 V){ return VecOps.MkVector3(V.x, V.z, V.z); }
        public static Vector3 XZ_(Vector3 V){ return VecOps.MkVector3(V.x, V.z, 0); }
        public static Vector3 X_X(Vector3 V){ return VecOps.MkVector3(V.x, 0, V.x); }
        public static Vector3 X_Y(Vector3 V){ return VecOps.MkVector3(V.x, 0, V.y); }
        public static Vector3 X_Z(Vector3 V){ return VecOps.MkVector3(V.x, 0, V.z); }
        public static Vector3 X__(Vector3 V){ return VecOps.MkVector3(V.x, 0, 0); }
        public static Vector3 YXX(Vector3 V){ return VecOps.MkVector3(V.y, V.x, V.x); }
        public static Vector3 YXY(Vector3 V){ return VecOps.MkVector3(V.y, V.x, V.y); }
        public static Vector3 YXZ(Vector3 V){ return VecOps.MkVector3(V.y, V.x, V.z); }
        public static Vector3 YX_(Vector3 V){ return VecOps.MkVector3(V.y, V.x, 0); }
        public static Vector3 YYX(Vector3 V){ return VecOps.MkVector3(V.y, V.y, V.x); }
        public static Vector3 YYY(Vector3 V){ return VecOps.MkVector3(V.y, V.y, V.y); }
        public static Vector3 YYZ(Vector3 V){ return VecOps.MkVector3(V.y, V.y, V.z); }
        public static Vector3 YY_(Vector3 V){ return VecOps.MkVector3(V.y, V.y, 0); }
        public static Vector3 YZX(Vector3 V){ return VecOps.MkVector3(V.y, V.z, V.x); }
        public static Vector3 YZY(Vector3 V){ return VecOps.MkVector3(V.y, V.z, V.y); }
        public static Vector3 YZZ(Vector3 V){ return VecOps.MkVector3(V.y, V.z, V.z); }
        public static Vector3 YZ_(Vector3 V){ return VecOps.MkVector3(V.y, V.z, 0); }
        public static Vector3 Y_X(Vector3 V){ return VecOps.MkVector3(V.y, 0, V.x); }
        public static Vector3 Y_Y(Vector3 V){ return VecOps.MkVector3(V.y, 0, V.y); }
        public static Vector3 Y_Z(Vector3 V){ return VecOps.MkVector3(V.y, 0, V.z); }
        public static Vector3 Y__(Vector3 V){ return VecOps.MkVector3(V.y, 0, 0); }
        public static Vector3 ZXX(Vector3 V){ return VecOps.MkVector3(V.z, V.x, V.x); }
        public static Vector3 ZXY(Vector3 V){ return VecOps.MkVector3(V.z, V.x, V.y); }
        public static Vector3 ZXZ(Vector3 V){ return VecOps.MkVector3(V.z, V.x, V.z); }
        public static Vector3 ZX_(Vector3 V){ return VecOps.MkVector3(V.z, V.x, 0); }
        public static Vector3 ZYX(Vector3 V){ return VecOps.MkVector3(V.z, V.y, V.x); }
        public static Vector3 ZYY(Vector3 V){ return VecOps.MkVector3(V.z, V.y, V.y); }
        public static Vector3 ZYZ(Vector3 V){ return VecOps.MkVector3(V.z, V.y, V.z); }
        public static Vector3 ZY_(Vector3 V){ return VecOps.MkVector3(V.z, V.y, 0); }
        public static Vector3 ZZX(Vector3 V){ return VecOps.MkVector3(V.z, V.z, V.x); }
        public static Vector3 ZZY(Vector3 V){ return VecOps.MkVector3(V.z, V.z, V.y); }
        public static Vector3 ZZZ(Vector3 V){ return VecOps.MkVector3(V.z, V.z, V.z); }
        public static Vector3 ZZ_(Vector3 V){ return VecOps.MkVector3(V.z, V.z, 0); }
        public static Vector3 Z_X(Vector3 V){ return VecOps.MkVector3(V.z, 0, V.x); }
        public static Vector3 Z_Y(Vector3 V){ return VecOps.MkVector3(V.z, 0, V.y); }
        public static Vector3 Z_Z(Vector3 V){ return VecOps.MkVector3(V.z, 0, V.z); }
        public static Vector3 Z__(Vector3 V){ return VecOps.MkVector3(V.z, 0, 0); }
        public static Vector3 _XX(Vector3 V){ return VecOps.MkVector3(0, V.x, V.x); }
        public static Vector3 _XY(Vector3 V){ return VecOps.MkVector3(0, V.x, V.y); }
        public static Vector3 _XZ(Vector3 V){ return VecOps.MkVector3(0, V.x, V.z); }
        public static Vector3 _X_(Vector3 V){ return VecOps.MkVector3(0, V.x, 0); }
        public static Vector3 _YX(Vector3 V){ return VecOps.MkVector3(0, V.y, V.x); }
        public static Vector3 _YY(Vector3 V){ return VecOps.MkVector3(0, V.y, V.y); }
        public static Vector3 _YZ(Vector3 V){ return VecOps.MkVector3(0, V.y, V.z); }
        public static Vector3 _Y_(Vector3 V){ return VecOps.MkVector3(0, V.y, 0); }
        public static Vector3 _ZX(Vector3 V){ return VecOps.MkVector3(0, V.z, V.x); }
        public static Vector3 _ZY(Vector3 V){ return VecOps.MkVector3(0, V.z, V.y); }
        public static Vector3 _ZZ(Vector3 V){ return VecOps.MkVector3(0, V.z, V.z); }
        public static Vector3 _Z_(Vector3 V){ return VecOps.MkVector3(0, V.z, 0); }
        public static Vector3 __X(Vector3 V){ return VecOps.MkVector3(0, 0, V.x); }
        public static Vector3 __Y(Vector3 V){ return VecOps.MkVector3(0, 0, V.y); }
        public static Vector3 __Z(Vector3 V){ return VecOps.MkVector3(0, 0, V.z); }
        public static Vector4 XXXX(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.x); }
        public static Vector4 XXXY(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.y); }
        public static Vector4 XXXZ(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.z); }
        public static Vector4 XXX_(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.x, 0); }
        public static Vector4 XXYX(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.x); }
        public static Vector4 XXYY(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.y); }
        public static Vector4 XXYZ(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.z); }
        public static Vector4 XXY_(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.y, 0); }
        public static Vector4 XXZX(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.x); }
        public static Vector4 XXZY(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.y); }
        public static Vector4 XXZZ(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.z); }
        public static Vector4 XXZ_(Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.z, 0); }
        public static Vector4 XX_X(Vector3 V){ return VecOps.MkVector4(V.x, V.x, 0, V.x); }
        public static Vector4 XX_Y(Vector3 V){ return VecOps.MkVector4(V.x, V.x, 0, V.y); }
        public static Vector4 XX_Z(Vector3 V){ return VecOps.MkVector4(V.x, V.x, 0, V.z); }
        public static Vector4 XX__(Vector3 V){ return VecOps.MkVector4(V.x, V.x, 0, 0); }
        public static Vector4 XYXX(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.x); }
        public static Vector4 XYXY(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.y); }
        public static Vector4 XYXZ(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.z); }
        public static Vector4 XYX_(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.x, 0); }
        public static Vector4 XYYX(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.x); }
        public static Vector4 XYYY(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.y); }
        public static Vector4 XYYZ(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.z); }
        public static Vector4 XYY_(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.y, 0); }
        public static Vector4 XYZX(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.x); }
        public static Vector4 XYZY(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.y); }
        public static Vector4 XYZZ(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.z); }
        public static Vector4 XYZ_(Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.z, 0); }
        public static Vector4 XY_X(Vector3 V){ return VecOps.MkVector4(V.x, V.y, 0, V.x); }
        public static Vector4 XY_Y(Vector3 V){ return VecOps.MkVector4(V.x, V.y, 0, V.y); }
        public static Vector4 XY_Z(Vector3 V){ return VecOps.MkVector4(V.x, V.y, 0, V.z); }
        public static Vector4 XY__(Vector3 V){ return VecOps.MkVector4(V.x, V.y, 0, 0); }
        public static Vector4 XZXX(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.x); }
        public static Vector4 XZXY(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.y); }
        public static Vector4 XZXZ(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.z); }
        public static Vector4 XZX_(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.x, 0); }
        public static Vector4 XZYX(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.x); }
        public static Vector4 XZYY(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.y); }
        public static Vector4 XZYZ(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.z); }
        public static Vector4 XZY_(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.y, 0); }
        public static Vector4 XZZX(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.x); }
        public static Vector4 XZZY(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.y); }
        public static Vector4 XZZZ(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.z); }
        public static Vector4 XZZ_(Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.z, 0); }
        public static Vector4 XZ_X(Vector3 V){ return VecOps.MkVector4(V.x, V.z, 0, V.x); }
        public static Vector4 XZ_Y(Vector3 V){ return VecOps.MkVector4(V.x, V.z, 0, V.y); }
        public static Vector4 XZ_Z(Vector3 V){ return VecOps.MkVector4(V.x, V.z, 0, V.z); }
        public static Vector4 XZ__(Vector3 V){ return VecOps.MkVector4(V.x, V.z, 0, 0); }
        public static Vector4 X_XX(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.x, V.x); }
        public static Vector4 X_XY(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.x, V.y); }
        public static Vector4 X_XZ(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.x, V.z); }
        public static Vector4 X_X_(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.x, 0); }
        public static Vector4 X_YX(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.y, V.x); }
        public static Vector4 X_YY(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.y, V.y); }
        public static Vector4 X_YZ(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.y, V.z); }
        public static Vector4 X_Y_(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.y, 0); }
        public static Vector4 X_ZX(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.z, V.x); }
        public static Vector4 X_ZY(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.z, V.y); }
        public static Vector4 X_ZZ(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.z, V.z); }
        public static Vector4 X_Z_(Vector3 V){ return VecOps.MkVector4(V.x, 0, V.z, 0); }
        public static Vector4 X__X(Vector3 V){ return VecOps.MkVector4(V.x, 0, 0, V.x); }
        public static Vector4 X__Y(Vector3 V){ return VecOps.MkVector4(V.x, 0, 0, V.y); }
        public static Vector4 X__Z(Vector3 V){ return VecOps.MkVector4(V.x, 0, 0, V.z); }
        public static Vector4 X___(Vector3 V){ return VecOps.MkVector4(V.x, 0, 0, 0); }
        public static Vector4 YXXX(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.x); }
        public static Vector4 YXXY(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.y); }
        public static Vector4 YXXZ(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.z); }
        public static Vector4 YXX_(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.x, 0); }
        public static Vector4 YXYX(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.x); }
        public static Vector4 YXYY(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.y); }
        public static Vector4 YXYZ(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.z); }
        public static Vector4 YXY_(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.y, 0); }
        public static Vector4 YXZX(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.x); }
        public static Vector4 YXZY(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.y); }
        public static Vector4 YXZZ(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.z); }
        public static Vector4 YXZ_(Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.z, 0); }
        public static Vector4 YX_X(Vector3 V){ return VecOps.MkVector4(V.y, V.x, 0, V.x); }
        public static Vector4 YX_Y(Vector3 V){ return VecOps.MkVector4(V.y, V.x, 0, V.y); }
        public static Vector4 YX_Z(Vector3 V){ return VecOps.MkVector4(V.y, V.x, 0, V.z); }
        public static Vector4 YX__(Vector3 V){ return VecOps.MkVector4(V.y, V.x, 0, 0); }
        public static Vector4 YYXX(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.x); }
        public static Vector4 YYXY(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.y); }
        public static Vector4 YYXZ(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.z); }
        public static Vector4 YYX_(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.x, 0); }
        public static Vector4 YYYX(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.x); }
        public static Vector4 YYYY(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.y); }
        public static Vector4 YYYZ(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.z); }
        public static Vector4 YYY_(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.y, 0); }
        public static Vector4 YYZX(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.x); }
        public static Vector4 YYZY(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.y); }
        public static Vector4 YYZZ(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.z); }
        public static Vector4 YYZ_(Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.z, 0); }
        public static Vector4 YY_X(Vector3 V){ return VecOps.MkVector4(V.y, V.y, 0, V.x); }
        public static Vector4 YY_Y(Vector3 V){ return VecOps.MkVector4(V.y, V.y, 0, V.y); }
        public static Vector4 YY_Z(Vector3 V){ return VecOps.MkVector4(V.y, V.y, 0, V.z); }
        public static Vector4 YY__(Vector3 V){ return VecOps.MkVector4(V.y, V.y, 0, 0); }
        public static Vector4 YZXX(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.x); }
        public static Vector4 YZXY(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.y); }
        public static Vector4 YZXZ(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.z); }
        public static Vector4 YZX_(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.x, 0); }
        public static Vector4 YZYX(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.x); }
        public static Vector4 YZYY(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.y); }
        public static Vector4 YZYZ(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.z); }
        public static Vector4 YZY_(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.y, 0); }
        public static Vector4 YZZX(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.x); }
        public static Vector4 YZZY(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.y); }
        public static Vector4 YZZZ(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.z); }
        public static Vector4 YZZ_(Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.z, 0); }
        public static Vector4 YZ_X(Vector3 V){ return VecOps.MkVector4(V.y, V.z, 0, V.x); }
        public static Vector4 YZ_Y(Vector3 V){ return VecOps.MkVector4(V.y, V.z, 0, V.y); }
        public static Vector4 YZ_Z(Vector3 V){ return VecOps.MkVector4(V.y, V.z, 0, V.z); }
        public static Vector4 YZ__(Vector3 V){ return VecOps.MkVector4(V.y, V.z, 0, 0); }
        public static Vector4 Y_XX(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.x, V.x); }
        public static Vector4 Y_XY(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.x, V.y); }
        public static Vector4 Y_XZ(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.x, V.z); }
        public static Vector4 Y_X_(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.x, 0); }
        public static Vector4 Y_YX(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.y, V.x); }
        public static Vector4 Y_YY(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.y, V.y); }
        public static Vector4 Y_YZ(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.y, V.z); }
        public static Vector4 Y_Y_(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.y, 0); }
        public static Vector4 Y_ZX(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.z, V.x); }
        public static Vector4 Y_ZY(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.z, V.y); }
        public static Vector4 Y_ZZ(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.z, V.z); }
        public static Vector4 Y_Z_(Vector3 V){ return VecOps.MkVector4(V.y, 0, V.z, 0); }
        public static Vector4 Y__X(Vector3 V){ return VecOps.MkVector4(V.y, 0, 0, V.x); }
        public static Vector4 Y__Y(Vector3 V){ return VecOps.MkVector4(V.y, 0, 0, V.y); }
        public static Vector4 Y__Z(Vector3 V){ return VecOps.MkVector4(V.y, 0, 0, V.z); }
        public static Vector4 Y___(Vector3 V){ return VecOps.MkVector4(V.y, 0, 0, 0); }
        public static Vector4 ZXXX(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.x); }
        public static Vector4 ZXXY(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.y); }
        public static Vector4 ZXXZ(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.z); }
        public static Vector4 ZXX_(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.x, 0); }
        public static Vector4 ZXYX(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.x); }
        public static Vector4 ZXYY(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.y); }
        public static Vector4 ZXYZ(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.z); }
        public static Vector4 ZXY_(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.y, 0); }
        public static Vector4 ZXZX(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.x); }
        public static Vector4 ZXZY(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.y); }
        public static Vector4 ZXZZ(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.z); }
        public static Vector4 ZXZ_(Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.z, 0); }
        public static Vector4 ZX_X(Vector3 V){ return VecOps.MkVector4(V.z, V.x, 0, V.x); }
        public static Vector4 ZX_Y(Vector3 V){ return VecOps.MkVector4(V.z, V.x, 0, V.y); }
        public static Vector4 ZX_Z(Vector3 V){ return VecOps.MkVector4(V.z, V.x, 0, V.z); }
        public static Vector4 ZX__(Vector3 V){ return VecOps.MkVector4(V.z, V.x, 0, 0); }
        public static Vector4 ZYXX(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.x); }
        public static Vector4 ZYXY(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.y); }
        public static Vector4 ZYXZ(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.z); }
        public static Vector4 ZYX_(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.x, 0); }
        public static Vector4 ZYYX(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.x); }
        public static Vector4 ZYYY(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.y); }
        public static Vector4 ZYYZ(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.z); }
        public static Vector4 ZYY_(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.y, 0); }
        public static Vector4 ZYZX(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.x); }
        public static Vector4 ZYZY(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.y); }
        public static Vector4 ZYZZ(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.z); }
        public static Vector4 ZYZ_(Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.z, 0); }
        public static Vector4 ZY_X(Vector3 V){ return VecOps.MkVector4(V.z, V.y, 0, V.x); }
        public static Vector4 ZY_Y(Vector3 V){ return VecOps.MkVector4(V.z, V.y, 0, V.y); }
        public static Vector4 ZY_Z(Vector3 V){ return VecOps.MkVector4(V.z, V.y, 0, V.z); }
        public static Vector4 ZY__(Vector3 V){ return VecOps.MkVector4(V.z, V.y, 0, 0); }
        public static Vector4 ZZXX(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.x); }
        public static Vector4 ZZXY(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.y); }
        public static Vector4 ZZXZ(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.z); }
        public static Vector4 ZZX_(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.x, 0); }
        public static Vector4 ZZYX(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.x); }
        public static Vector4 ZZYY(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.y); }
        public static Vector4 ZZYZ(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.z); }
        public static Vector4 ZZY_(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.y, 0); }
        public static Vector4 ZZZX(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.x); }
        public static Vector4 ZZZY(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.y); }
        public static Vector4 ZZZZ(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.z); }
        public static Vector4 ZZZ_(Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.z, 0); }
        public static Vector4 ZZ_X(Vector3 V){ return VecOps.MkVector4(V.z, V.z, 0, V.x); }
        public static Vector4 ZZ_Y(Vector3 V){ return VecOps.MkVector4(V.z, V.z, 0, V.y); }
        public static Vector4 ZZ_Z(Vector3 V){ return VecOps.MkVector4(V.z, V.z, 0, V.z); }
        public static Vector4 ZZ__(Vector3 V){ return VecOps.MkVector4(V.z, V.z, 0, 0); }
        public static Vector4 Z_XX(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.x, V.x); }
        public static Vector4 Z_XY(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.x, V.y); }
        public static Vector4 Z_XZ(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.x, V.z); }
        public static Vector4 Z_X_(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.x, 0); }
        public static Vector4 Z_YX(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.y, V.x); }
        public static Vector4 Z_YY(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.y, V.y); }
        public static Vector4 Z_YZ(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.y, V.z); }
        public static Vector4 Z_Y_(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.y, 0); }
        public static Vector4 Z_ZX(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.z, V.x); }
        public static Vector4 Z_ZY(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.z, V.y); }
        public static Vector4 Z_ZZ(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.z, V.z); }
        public static Vector4 Z_Z_(Vector3 V){ return VecOps.MkVector4(V.z, 0, V.z, 0); }
        public static Vector4 Z__X(Vector3 V){ return VecOps.MkVector4(V.z, 0, 0, V.x); }
        public static Vector4 Z__Y(Vector3 V){ return VecOps.MkVector4(V.z, 0, 0, V.y); }
        public static Vector4 Z__Z(Vector3 V){ return VecOps.MkVector4(V.z, 0, 0, V.z); }
        public static Vector4 Z___(Vector3 V){ return VecOps.MkVector4(V.z, 0, 0, 0); }
        public static Vector4 _XXX(Vector3 V){ return VecOps.MkVector4(0, V.x, V.x, V.x); }
        public static Vector4 _XXY(Vector3 V){ return VecOps.MkVector4(0, V.x, V.x, V.y); }
        public static Vector4 _XXZ(Vector3 V){ return VecOps.MkVector4(0, V.x, V.x, V.z); }
        public static Vector4 _XX_(Vector3 V){ return VecOps.MkVector4(0, V.x, V.x, 0); }
        public static Vector4 _XYX(Vector3 V){ return VecOps.MkVector4(0, V.x, V.y, V.x); }
        public static Vector4 _XYY(Vector3 V){ return VecOps.MkVector4(0, V.x, V.y, V.y); }
        public static Vector4 _XYZ(Vector3 V){ return VecOps.MkVector4(0, V.x, V.y, V.z); }
        public static Vector4 _XY_(Vector3 V){ return VecOps.MkVector4(0, V.x, V.y, 0); }
        public static Vector4 _XZX(Vector3 V){ return VecOps.MkVector4(0, V.x, V.z, V.x); }
        public static Vector4 _XZY(Vector3 V){ return VecOps.MkVector4(0, V.x, V.z, V.y); }
        public static Vector4 _XZZ(Vector3 V){ return VecOps.MkVector4(0, V.x, V.z, V.z); }
        public static Vector4 _XZ_(Vector3 V){ return VecOps.MkVector4(0, V.x, V.z, 0); }
        public static Vector4 _X_X(Vector3 V){ return VecOps.MkVector4(0, V.x, 0, V.x); }
        public static Vector4 _X_Y(Vector3 V){ return VecOps.MkVector4(0, V.x, 0, V.y); }
        public static Vector4 _X_Z(Vector3 V){ return VecOps.MkVector4(0, V.x, 0, V.z); }
        public static Vector4 _X__(Vector3 V){ return VecOps.MkVector4(0, V.x, 0, 0); }
        public static Vector4 _YXX(Vector3 V){ return VecOps.MkVector4(0, V.y, V.x, V.x); }
        public static Vector4 _YXY(Vector3 V){ return VecOps.MkVector4(0, V.y, V.x, V.y); }
        public static Vector4 _YXZ(Vector3 V){ return VecOps.MkVector4(0, V.y, V.x, V.z); }
        public static Vector4 _YX_(Vector3 V){ return VecOps.MkVector4(0, V.y, V.x, 0); }
        public static Vector4 _YYX(Vector3 V){ return VecOps.MkVector4(0, V.y, V.y, V.x); }
        public static Vector4 _YYY(Vector3 V){ return VecOps.MkVector4(0, V.y, V.y, V.y); }
        public static Vector4 _YYZ(Vector3 V){ return VecOps.MkVector4(0, V.y, V.y, V.z); }
        public static Vector4 _YY_(Vector3 V){ return VecOps.MkVector4(0, V.y, V.y, 0); }
        public static Vector4 _YZX(Vector3 V){ return VecOps.MkVector4(0, V.y, V.z, V.x); }
        public static Vector4 _YZY(Vector3 V){ return VecOps.MkVector4(0, V.y, V.z, V.y); }
        public static Vector4 _YZZ(Vector3 V){ return VecOps.MkVector4(0, V.y, V.z, V.z); }
        public static Vector4 _YZ_(Vector3 V){ return VecOps.MkVector4(0, V.y, V.z, 0); }
        public static Vector4 _Y_X(Vector3 V){ return VecOps.MkVector4(0, V.y, 0, V.x); }
        public static Vector4 _Y_Y(Vector3 V){ return VecOps.MkVector4(0, V.y, 0, V.y); }
        public static Vector4 _Y_Z(Vector3 V){ return VecOps.MkVector4(0, V.y, 0, V.z); }
        public static Vector4 _Y__(Vector3 V){ return VecOps.MkVector4(0, V.y, 0, 0); }
        public static Vector4 _ZXX(Vector3 V){ return VecOps.MkVector4(0, V.z, V.x, V.x); }
        public static Vector4 _ZXY(Vector3 V){ return VecOps.MkVector4(0, V.z, V.x, V.y); }
        public static Vector4 _ZXZ(Vector3 V){ return VecOps.MkVector4(0, V.z, V.x, V.z); }
        public static Vector4 _ZX_(Vector3 V){ return VecOps.MkVector4(0, V.z, V.x, 0); }
        public static Vector4 _ZYX(Vector3 V){ return VecOps.MkVector4(0, V.z, V.y, V.x); }
        public static Vector4 _ZYY(Vector3 V){ return VecOps.MkVector4(0, V.z, V.y, V.y); }
        public static Vector4 _ZYZ(Vector3 V){ return VecOps.MkVector4(0, V.z, V.y, V.z); }
        public static Vector4 _ZY_(Vector3 V){ return VecOps.MkVector4(0, V.z, V.y, 0); }
        public static Vector4 _ZZX(Vector3 V){ return VecOps.MkVector4(0, V.z, V.z, V.x); }
        public static Vector4 _ZZY(Vector3 V){ return VecOps.MkVector4(0, V.z, V.z, V.y); }
        public static Vector4 _ZZZ(Vector3 V){ return VecOps.MkVector4(0, V.z, V.z, V.z); }
        public static Vector4 _ZZ_(Vector3 V){ return VecOps.MkVector4(0, V.z, V.z, 0); }
        public static Vector4 _Z_X(Vector3 V){ return VecOps.MkVector4(0, V.z, 0, V.x); }
        public static Vector4 _Z_Y(Vector3 V){ return VecOps.MkVector4(0, V.z, 0, V.y); }
        public static Vector4 _Z_Z(Vector3 V){ return VecOps.MkVector4(0, V.z, 0, V.z); }
        public static Vector4 _Z__(Vector3 V){ return VecOps.MkVector4(0, V.z, 0, 0); }
        public static Vector4 __XX(Vector3 V){ return VecOps.MkVector4(0, 0, V.x, V.x); }
        public static Vector4 __XY(Vector3 V){ return VecOps.MkVector4(0, 0, V.x, V.y); }
        public static Vector4 __XZ(Vector3 V){ return VecOps.MkVector4(0, 0, V.x, V.z); }
        public static Vector4 __X_(Vector3 V){ return VecOps.MkVector4(0, 0, V.x, 0); }
        public static Vector4 __YX(Vector3 V){ return VecOps.MkVector4(0, 0, V.y, V.x); }
        public static Vector4 __YY(Vector3 V){ return VecOps.MkVector4(0, 0, V.y, V.y); }
        public static Vector4 __YZ(Vector3 V){ return VecOps.MkVector4(0, 0, V.y, V.z); }
        public static Vector4 __Y_(Vector3 V){ return VecOps.MkVector4(0, 0, V.y, 0); }
        public static Vector4 __ZX(Vector3 V){ return VecOps.MkVector4(0, 0, V.z, V.x); }
        public static Vector4 __ZY(Vector3 V){ return VecOps.MkVector4(0, 0, V.z, V.y); }
        public static Vector4 __ZZ(Vector3 V){ return VecOps.MkVector4(0, 0, V.z, V.z); }
        public static Vector4 __Z_(Vector3 V){ return VecOps.MkVector4(0, 0, V.z, 0); }
        public static Vector4 ___X(Vector3 V){ return VecOps.MkVector4(0, 0, 0, V.x); }
        public static Vector4 ___Y(Vector3 V){ return VecOps.MkVector4(0, 0, 0, V.y); }
        public static Vector4 ___Z(Vector3 V){ return VecOps.MkVector4(0, 0, 0, V.z); }
        public static Vector2 XX(Vector4 V){ return VecOps.MkVector2(V.x, V.x); }
        public static Vector2 XY(Vector4 V){ return VecOps.MkVector2(V.x, V.y); }
        public static Vector2 XZ(Vector4 V){ return VecOps.MkVector2(V.x, V.z); }
        public static Vector2 XW(Vector4 V){ return VecOps.MkVector2(V.x, V.w); }
        public static Vector2 X_(Vector4 V){ return VecOps.MkVector2(V.x, 0); }
        public static Vector2 YX(Vector4 V){ return VecOps.MkVector2(V.y, V.x); }
        public static Vector2 YY(Vector4 V){ return VecOps.MkVector2(V.y, V.y); }
        public static Vector2 YZ(Vector4 V){ return VecOps.MkVector2(V.y, V.z); }
        public static Vector2 YW(Vector4 V){ return VecOps.MkVector2(V.y, V.w); }
        public static Vector2 Y_(Vector4 V){ return VecOps.MkVector2(V.y, 0); }
        public static Vector2 ZX(Vector4 V){ return VecOps.MkVector2(V.z, V.x); }
        public static Vector2 ZY(Vector4 V){ return VecOps.MkVector2(V.z, V.y); }
        public static Vector2 ZZ(Vector4 V){ return VecOps.MkVector2(V.z, V.z); }
        public static Vector2 ZW(Vector4 V){ return VecOps.MkVector2(V.z, V.w); }
        public static Vector2 Z_(Vector4 V){ return VecOps.MkVector2(V.z, 0); }
        public static Vector2 WX(Vector4 V){ return VecOps.MkVector2(V.w, V.x); }
        public static Vector2 WY(Vector4 V){ return VecOps.MkVector2(V.w, V.y); }
        public static Vector2 WZ(Vector4 V){ return VecOps.MkVector2(V.w, V.z); }
        public static Vector2 WW(Vector4 V){ return VecOps.MkVector2(V.w, V.w); }
        public static Vector2 W_(Vector4 V){ return VecOps.MkVector2(V.w, 0); }
        public static Vector2 _X(Vector4 V){ return VecOps.MkVector2(0, V.x); }
        public static Vector2 _Y(Vector4 V){ return VecOps.MkVector2(0, V.y); }
        public static Vector2 _Z(Vector4 V){ return VecOps.MkVector2(0, V.z); }
        public static Vector2 _W(Vector4 V){ return VecOps.MkVector2(0, V.w); }
        public static Vector3 XXX(Vector4 V){ return VecOps.MkVector3(V.x, V.x, V.x); }
        public static Vector3 XXY(Vector4 V){ return VecOps.MkVector3(V.x, V.x, V.y); }
        public static Vector3 XXZ(Vector4 V){ return VecOps.MkVector3(V.x, V.x, V.z); }
        public static Vector3 XXW(Vector4 V){ return VecOps.MkVector3(V.x, V.x, V.w); }
        public static Vector3 XX_(Vector4 V){ return VecOps.MkVector3(V.x, V.x, 0); }
        public static Vector3 XYX(Vector4 V){ return VecOps.MkVector3(V.x, V.y, V.x); }
        public static Vector3 XYY(Vector4 V){ return VecOps.MkVector3(V.x, V.y, V.y); }
        public static Vector3 XYZ(Vector4 V){ return VecOps.MkVector3(V.x, V.y, V.z); }
        public static Vector3 XYW(Vector4 V){ return VecOps.MkVector3(V.x, V.y, V.w); }
        public static Vector3 XY_(Vector4 V){ return VecOps.MkVector3(V.x, V.y, 0); }
        public static Vector3 XZX(Vector4 V){ return VecOps.MkVector3(V.x, V.z, V.x); }
        public static Vector3 XZY(Vector4 V){ return VecOps.MkVector3(V.x, V.z, V.y); }
        public static Vector3 XZZ(Vector4 V){ return VecOps.MkVector3(V.x, V.z, V.z); }
        public static Vector3 XZW(Vector4 V){ return VecOps.MkVector3(V.x, V.z, V.w); }
        public static Vector3 XZ_(Vector4 V){ return VecOps.MkVector3(V.x, V.z, 0); }
        public static Vector3 XWX(Vector4 V){ return VecOps.MkVector3(V.x, V.w, V.x); }
        public static Vector3 XWY(Vector4 V){ return VecOps.MkVector3(V.x, V.w, V.y); }
        public static Vector3 XWZ(Vector4 V){ return VecOps.MkVector3(V.x, V.w, V.z); }
        public static Vector3 XWW(Vector4 V){ return VecOps.MkVector3(V.x, V.w, V.w); }
        public static Vector3 XW_(Vector4 V){ return VecOps.MkVector3(V.x, V.w, 0); }
        public static Vector3 X_X(Vector4 V){ return VecOps.MkVector3(V.x, 0, V.x); }
        public static Vector3 X_Y(Vector4 V){ return VecOps.MkVector3(V.x, 0, V.y); }
        public static Vector3 X_Z(Vector4 V){ return VecOps.MkVector3(V.x, 0, V.z); }
        public static Vector3 X_W(Vector4 V){ return VecOps.MkVector3(V.x, 0, V.w); }
        public static Vector3 X__(Vector4 V){ return VecOps.MkVector3(V.x, 0, 0); }
        public static Vector3 YXX(Vector4 V){ return VecOps.MkVector3(V.y, V.x, V.x); }
        public static Vector3 YXY(Vector4 V){ return VecOps.MkVector3(V.y, V.x, V.y); }
        public static Vector3 YXZ(Vector4 V){ return VecOps.MkVector3(V.y, V.x, V.z); }
        public static Vector3 YXW(Vector4 V){ return VecOps.MkVector3(V.y, V.x, V.w); }
        public static Vector3 YX_(Vector4 V){ return VecOps.MkVector3(V.y, V.x, 0); }
        public static Vector3 YYX(Vector4 V){ return VecOps.MkVector3(V.y, V.y, V.x); }
        public static Vector3 YYY(Vector4 V){ return VecOps.MkVector3(V.y, V.y, V.y); }
        public static Vector3 YYZ(Vector4 V){ return VecOps.MkVector3(V.y, V.y, V.z); }
        public static Vector3 YYW(Vector4 V){ return VecOps.MkVector3(V.y, V.y, V.w); }
        public static Vector3 YY_(Vector4 V){ return VecOps.MkVector3(V.y, V.y, 0); }
        public static Vector3 YZX(Vector4 V){ return VecOps.MkVector3(V.y, V.z, V.x); }
        public static Vector3 YZY(Vector4 V){ return VecOps.MkVector3(V.y, V.z, V.y); }
        public static Vector3 YZZ(Vector4 V){ return VecOps.MkVector3(V.y, V.z, V.z); }
        public static Vector3 YZW(Vector4 V){ return VecOps.MkVector3(V.y, V.z, V.w); }
        public static Vector3 YZ_(Vector4 V){ return VecOps.MkVector3(V.y, V.z, 0); }
        public static Vector3 YWX(Vector4 V){ return VecOps.MkVector3(V.y, V.w, V.x); }
        public static Vector3 YWY(Vector4 V){ return VecOps.MkVector3(V.y, V.w, V.y); }
        public static Vector3 YWZ(Vector4 V){ return VecOps.MkVector3(V.y, V.w, V.z); }
        public static Vector3 YWW(Vector4 V){ return VecOps.MkVector3(V.y, V.w, V.w); }
        public static Vector3 YW_(Vector4 V){ return VecOps.MkVector3(V.y, V.w, 0); }
        public static Vector3 Y_X(Vector4 V){ return VecOps.MkVector3(V.y, 0, V.x); }
        public static Vector3 Y_Y(Vector4 V){ return VecOps.MkVector3(V.y, 0, V.y); }
        public static Vector3 Y_Z(Vector4 V){ return VecOps.MkVector3(V.y, 0, V.z); }
        public static Vector3 Y_W(Vector4 V){ return VecOps.MkVector3(V.y, 0, V.w); }
        public static Vector3 Y__(Vector4 V){ return VecOps.MkVector3(V.y, 0, 0); }
        public static Vector3 ZXX(Vector4 V){ return VecOps.MkVector3(V.z, V.x, V.x); }
        public static Vector3 ZXY(Vector4 V){ return VecOps.MkVector3(V.z, V.x, V.y); }
        public static Vector3 ZXZ(Vector4 V){ return VecOps.MkVector3(V.z, V.x, V.z); }
        public static Vector3 ZXW(Vector4 V){ return VecOps.MkVector3(V.z, V.x, V.w); }
        public static Vector3 ZX_(Vector4 V){ return VecOps.MkVector3(V.z, V.x, 0); }
        public static Vector3 ZYX(Vector4 V){ return VecOps.MkVector3(V.z, V.y, V.x); }
        public static Vector3 ZYY(Vector4 V){ return VecOps.MkVector3(V.z, V.y, V.y); }
        public static Vector3 ZYZ(Vector4 V){ return VecOps.MkVector3(V.z, V.y, V.z); }
        public static Vector3 ZYW(Vector4 V){ return VecOps.MkVector3(V.z, V.y, V.w); }
        public static Vector3 ZY_(Vector4 V){ return VecOps.MkVector3(V.z, V.y, 0); }
        public static Vector3 ZZX(Vector4 V){ return VecOps.MkVector3(V.z, V.z, V.x); }
        public static Vector3 ZZY(Vector4 V){ return VecOps.MkVector3(V.z, V.z, V.y); }
        public static Vector3 ZZZ(Vector4 V){ return VecOps.MkVector3(V.z, V.z, V.z); }
        public static Vector3 ZZW(Vector4 V){ return VecOps.MkVector3(V.z, V.z, V.w); }
        public static Vector3 ZZ_(Vector4 V){ return VecOps.MkVector3(V.z, V.z, 0); }
        public static Vector3 ZWX(Vector4 V){ return VecOps.MkVector3(V.z, V.w, V.x); }
        public static Vector3 ZWY(Vector4 V){ return VecOps.MkVector3(V.z, V.w, V.y); }
        public static Vector3 ZWZ(Vector4 V){ return VecOps.MkVector3(V.z, V.w, V.z); }
        public static Vector3 ZWW(Vector4 V){ return VecOps.MkVector3(V.z, V.w, V.w); }
        public static Vector3 ZW_(Vector4 V){ return VecOps.MkVector3(V.z, V.w, 0); }
        public static Vector3 Z_X(Vector4 V){ return VecOps.MkVector3(V.z, 0, V.x); }
        public static Vector3 Z_Y(Vector4 V){ return VecOps.MkVector3(V.z, 0, V.y); }
        public static Vector3 Z_Z(Vector4 V){ return VecOps.MkVector3(V.z, 0, V.z); }
        public static Vector3 Z_W(Vector4 V){ return VecOps.MkVector3(V.z, 0, V.w); }
        public static Vector3 Z__(Vector4 V){ return VecOps.MkVector3(V.z, 0, 0); }
        public static Vector3 WXX(Vector4 V){ return VecOps.MkVector3(V.w, V.x, V.x); }
        public static Vector3 WXY(Vector4 V){ return VecOps.MkVector3(V.w, V.x, V.y); }
        public static Vector3 WXZ(Vector4 V){ return VecOps.MkVector3(V.w, V.x, V.z); }
        public static Vector3 WXW(Vector4 V){ return VecOps.MkVector3(V.w, V.x, V.w); }
        public static Vector3 WX_(Vector4 V){ return VecOps.MkVector3(V.w, V.x, 0); }
        public static Vector3 WYX(Vector4 V){ return VecOps.MkVector3(V.w, V.y, V.x); }
        public static Vector3 WYY(Vector4 V){ return VecOps.MkVector3(V.w, V.y, V.y); }
        public static Vector3 WYZ(Vector4 V){ return VecOps.MkVector3(V.w, V.y, V.z); }
        public static Vector3 WYW(Vector4 V){ return VecOps.MkVector3(V.w, V.y, V.w); }
        public static Vector3 WY_(Vector4 V){ return VecOps.MkVector3(V.w, V.y, 0); }
        public static Vector3 WZX(Vector4 V){ return VecOps.MkVector3(V.w, V.z, V.x); }
        public static Vector3 WZY(Vector4 V){ return VecOps.MkVector3(V.w, V.z, V.y); }
        public static Vector3 WZZ(Vector4 V){ return VecOps.MkVector3(V.w, V.z, V.z); }
        public static Vector3 WZW(Vector4 V){ return VecOps.MkVector3(V.w, V.z, V.w); }
        public static Vector3 WZ_(Vector4 V){ return VecOps.MkVector3(V.w, V.z, 0); }
        public static Vector3 WWX(Vector4 V){ return VecOps.MkVector3(V.w, V.w, V.x); }
        public static Vector3 WWY(Vector4 V){ return VecOps.MkVector3(V.w, V.w, V.y); }
        public static Vector3 WWZ(Vector4 V){ return VecOps.MkVector3(V.w, V.w, V.z); }
        public static Vector3 WWW(Vector4 V){ return VecOps.MkVector3(V.w, V.w, V.w); }
        public static Vector3 WW_(Vector4 V){ return VecOps.MkVector3(V.w, V.w, 0); }
        public static Vector3 W_X(Vector4 V){ return VecOps.MkVector3(V.w, 0, V.x); }
        public static Vector3 W_Y(Vector4 V){ return VecOps.MkVector3(V.w, 0, V.y); }
        public static Vector3 W_Z(Vector4 V){ return VecOps.MkVector3(V.w, 0, V.z); }
        public static Vector3 W_W(Vector4 V){ return VecOps.MkVector3(V.w, 0, V.w); }
        public static Vector3 W__(Vector4 V){ return VecOps.MkVector3(V.w, 0, 0); }
        public static Vector3 _XX(Vector4 V){ return VecOps.MkVector3(0, V.x, V.x); }
        public static Vector3 _XY(Vector4 V){ return VecOps.MkVector3(0, V.x, V.y); }
        public static Vector3 _XZ(Vector4 V){ return VecOps.MkVector3(0, V.x, V.z); }
        public static Vector3 _XW(Vector4 V){ return VecOps.MkVector3(0, V.x, V.w); }
        public static Vector3 _X_(Vector4 V){ return VecOps.MkVector3(0, V.x, 0); }
        public static Vector3 _YX(Vector4 V){ return VecOps.MkVector3(0, V.y, V.x); }
        public static Vector3 _YY(Vector4 V){ return VecOps.MkVector3(0, V.y, V.y); }
        public static Vector3 _YZ(Vector4 V){ return VecOps.MkVector3(0, V.y, V.z); }
        public static Vector3 _YW(Vector4 V){ return VecOps.MkVector3(0, V.y, V.w); }
        public static Vector3 _Y_(Vector4 V){ return VecOps.MkVector3(0, V.y, 0); }
        public static Vector3 _ZX(Vector4 V){ return VecOps.MkVector3(0, V.z, V.x); }
        public static Vector3 _ZY(Vector4 V){ return VecOps.MkVector3(0, V.z, V.y); }
        public static Vector3 _ZZ(Vector4 V){ return VecOps.MkVector3(0, V.z, V.z); }
        public static Vector3 _ZW(Vector4 V){ return VecOps.MkVector3(0, V.z, V.w); }
        public static Vector3 _Z_(Vector4 V){ return VecOps.MkVector3(0, V.z, 0); }
        public static Vector3 _WX(Vector4 V){ return VecOps.MkVector3(0, V.w, V.x); }
        public static Vector3 _WY(Vector4 V){ return VecOps.MkVector3(0, V.w, V.y); }
        public static Vector3 _WZ(Vector4 V){ return VecOps.MkVector3(0, V.w, V.z); }
        public static Vector3 _WW(Vector4 V){ return VecOps.MkVector3(0, V.w, V.w); }
        public static Vector3 _W_(Vector4 V){ return VecOps.MkVector3(0, V.w, 0); }
        public static Vector3 __X(Vector4 V){ return VecOps.MkVector3(0, 0, V.x); }
        public static Vector3 __Y(Vector4 V){ return VecOps.MkVector3(0, 0, V.y); }
        public static Vector3 __Z(Vector4 V){ return VecOps.MkVector3(0, 0, V.z); }
        public static Vector3 __W(Vector4 V){ return VecOps.MkVector3(0, 0, V.w); }
        public static Vector4 XXXX(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.x); }
        public static Vector4 XXXY(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.y); }
        public static Vector4 XXXZ(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.z); }
        public static Vector4 XXXW(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.w); }
        public static Vector4 XXX_(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.x, 0); }
        public static Vector4 XXYX(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.x); }
        public static Vector4 XXYY(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.y); }
        public static Vector4 XXYZ(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.z); }
        public static Vector4 XXYW(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.w); }
        public static Vector4 XXY_(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.y, 0); }
        public static Vector4 XXZX(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.x); }
        public static Vector4 XXZY(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.y); }
        public static Vector4 XXZZ(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.z); }
        public static Vector4 XXZW(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.w); }
        public static Vector4 XXZ_(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.z, 0); }
        public static Vector4 XXWX(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.w, V.x); }
        public static Vector4 XXWY(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.w, V.y); }
        public static Vector4 XXWZ(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.w, V.z); }
        public static Vector4 XXWW(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.w, V.w); }
        public static Vector4 XXW_(Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.w, 0); }
        public static Vector4 XX_X(Vector4 V){ return VecOps.MkVector4(V.x, V.x, 0, V.x); }
        public static Vector4 XX_Y(Vector4 V){ return VecOps.MkVector4(V.x, V.x, 0, V.y); }
        public static Vector4 XX_Z(Vector4 V){ return VecOps.MkVector4(V.x, V.x, 0, V.z); }
        public static Vector4 XX_W(Vector4 V){ return VecOps.MkVector4(V.x, V.x, 0, V.w); }
        public static Vector4 XX__(Vector4 V){ return VecOps.MkVector4(V.x, V.x, 0, 0); }
        public static Vector4 XYXX(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.x); }
        public static Vector4 XYXY(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.y); }
        public static Vector4 XYXZ(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.z); }
        public static Vector4 XYXW(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.w); }
        public static Vector4 XYX_(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.x, 0); }
        public static Vector4 XYYX(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.x); }
        public static Vector4 XYYY(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.y); }
        public static Vector4 XYYZ(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.z); }
        public static Vector4 XYYW(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.w); }
        public static Vector4 XYY_(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.y, 0); }
        public static Vector4 XYZX(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.x); }
        public static Vector4 XYZY(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.y); }
        public static Vector4 XYZZ(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.z); }
        public static Vector4 XYZW(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.w); }
        public static Vector4 XYZ_(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.z, 0); }
        public static Vector4 XYWX(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.w, V.x); }
        public static Vector4 XYWY(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.w, V.y); }
        public static Vector4 XYWZ(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.w, V.z); }
        public static Vector4 XYWW(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.w, V.w); }
        public static Vector4 XYW_(Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.w, 0); }
        public static Vector4 XY_X(Vector4 V){ return VecOps.MkVector4(V.x, V.y, 0, V.x); }
        public static Vector4 XY_Y(Vector4 V){ return VecOps.MkVector4(V.x, V.y, 0, V.y); }
        public static Vector4 XY_Z(Vector4 V){ return VecOps.MkVector4(V.x, V.y, 0, V.z); }
        public static Vector4 XY_W(Vector4 V){ return VecOps.MkVector4(V.x, V.y, 0, V.w); }
        public static Vector4 XY__(Vector4 V){ return VecOps.MkVector4(V.x, V.y, 0, 0); }
        public static Vector4 XZXX(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.x); }
        public static Vector4 XZXY(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.y); }
        public static Vector4 XZXZ(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.z); }
        public static Vector4 XZXW(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.w); }
        public static Vector4 XZX_(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.x, 0); }
        public static Vector4 XZYX(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.x); }
        public static Vector4 XZYY(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.y); }
        public static Vector4 XZYZ(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.z); }
        public static Vector4 XZYW(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.w); }
        public static Vector4 XZY_(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.y, 0); }
        public static Vector4 XZZX(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.x); }
        public static Vector4 XZZY(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.y); }
        public static Vector4 XZZZ(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.z); }
        public static Vector4 XZZW(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.w); }
        public static Vector4 XZZ_(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.z, 0); }
        public static Vector4 XZWX(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.w, V.x); }
        public static Vector4 XZWY(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.w, V.y); }
        public static Vector4 XZWZ(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.w, V.z); }
        public static Vector4 XZWW(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.w, V.w); }
        public static Vector4 XZW_(Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.w, 0); }
        public static Vector4 XZ_X(Vector4 V){ return VecOps.MkVector4(V.x, V.z, 0, V.x); }
        public static Vector4 XZ_Y(Vector4 V){ return VecOps.MkVector4(V.x, V.z, 0, V.y); }
        public static Vector4 XZ_Z(Vector4 V){ return VecOps.MkVector4(V.x, V.z, 0, V.z); }
        public static Vector4 XZ_W(Vector4 V){ return VecOps.MkVector4(V.x, V.z, 0, V.w); }
        public static Vector4 XZ__(Vector4 V){ return VecOps.MkVector4(V.x, V.z, 0, 0); }
        public static Vector4 XWXX(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.x, V.x); }
        public static Vector4 XWXY(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.x, V.y); }
        public static Vector4 XWXZ(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.x, V.z); }
        public static Vector4 XWXW(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.x, V.w); }
        public static Vector4 XWX_(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.x, 0); }
        public static Vector4 XWYX(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.y, V.x); }
        public static Vector4 XWYY(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.y, V.y); }
        public static Vector4 XWYZ(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.y, V.z); }
        public static Vector4 XWYW(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.y, V.w); }
        public static Vector4 XWY_(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.y, 0); }
        public static Vector4 XWZX(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.z, V.x); }
        public static Vector4 XWZY(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.z, V.y); }
        public static Vector4 XWZZ(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.z, V.z); }
        public static Vector4 XWZW(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.z, V.w); }
        public static Vector4 XWZ_(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.z, 0); }
        public static Vector4 XWWX(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.w, V.x); }
        public static Vector4 XWWY(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.w, V.y); }
        public static Vector4 XWWZ(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.w, V.z); }
        public static Vector4 XWWW(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.w, V.w); }
        public static Vector4 XWW_(Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.w, 0); }
        public static Vector4 XW_X(Vector4 V){ return VecOps.MkVector4(V.x, V.w, 0, V.x); }
        public static Vector4 XW_Y(Vector4 V){ return VecOps.MkVector4(V.x, V.w, 0, V.y); }
        public static Vector4 XW_Z(Vector4 V){ return VecOps.MkVector4(V.x, V.w, 0, V.z); }
        public static Vector4 XW_W(Vector4 V){ return VecOps.MkVector4(V.x, V.w, 0, V.w); }
        public static Vector4 XW__(Vector4 V){ return VecOps.MkVector4(V.x, V.w, 0, 0); }
        public static Vector4 X_XX(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.x, V.x); }
        public static Vector4 X_XY(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.x, V.y); }
        public static Vector4 X_XZ(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.x, V.z); }
        public static Vector4 X_XW(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.x, V.w); }
        public static Vector4 X_X_(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.x, 0); }
        public static Vector4 X_YX(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.y, V.x); }
        public static Vector4 X_YY(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.y, V.y); }
        public static Vector4 X_YZ(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.y, V.z); }
        public static Vector4 X_YW(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.y, V.w); }
        public static Vector4 X_Y_(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.y, 0); }
        public static Vector4 X_ZX(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.z, V.x); }
        public static Vector4 X_ZY(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.z, V.y); }
        public static Vector4 X_ZZ(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.z, V.z); }
        public static Vector4 X_ZW(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.z, V.w); }
        public static Vector4 X_Z_(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.z, 0); }
        public static Vector4 X_WX(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.w, V.x); }
        public static Vector4 X_WY(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.w, V.y); }
        public static Vector4 X_WZ(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.w, V.z); }
        public static Vector4 X_WW(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.w, V.w); }
        public static Vector4 X_W_(Vector4 V){ return VecOps.MkVector4(V.x, 0, V.w, 0); }
        public static Vector4 X__X(Vector4 V){ return VecOps.MkVector4(V.x, 0, 0, V.x); }
        public static Vector4 X__Y(Vector4 V){ return VecOps.MkVector4(V.x, 0, 0, V.y); }
        public static Vector4 X__Z(Vector4 V){ return VecOps.MkVector4(V.x, 0, 0, V.z); }
        public static Vector4 X__W(Vector4 V){ return VecOps.MkVector4(V.x, 0, 0, V.w); }
        public static Vector4 X___(Vector4 V){ return VecOps.MkVector4(V.x, 0, 0, 0); }
        public static Vector4 YXXX(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.x); }
        public static Vector4 YXXY(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.y); }
        public static Vector4 YXXZ(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.z); }
        public static Vector4 YXXW(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.w); }
        public static Vector4 YXX_(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.x, 0); }
        public static Vector4 YXYX(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.x); }
        public static Vector4 YXYY(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.y); }
        public static Vector4 YXYZ(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.z); }
        public static Vector4 YXYW(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.w); }
        public static Vector4 YXY_(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.y, 0); }
        public static Vector4 YXZX(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.x); }
        public static Vector4 YXZY(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.y); }
        public static Vector4 YXZZ(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.z); }
        public static Vector4 YXZW(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.w); }
        public static Vector4 YXZ_(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.z, 0); }
        public static Vector4 YXWX(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.w, V.x); }
        public static Vector4 YXWY(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.w, V.y); }
        public static Vector4 YXWZ(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.w, V.z); }
        public static Vector4 YXWW(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.w, V.w); }
        public static Vector4 YXW_(Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.w, 0); }
        public static Vector4 YX_X(Vector4 V){ return VecOps.MkVector4(V.y, V.x, 0, V.x); }
        public static Vector4 YX_Y(Vector4 V){ return VecOps.MkVector4(V.y, V.x, 0, V.y); }
        public static Vector4 YX_Z(Vector4 V){ return VecOps.MkVector4(V.y, V.x, 0, V.z); }
        public static Vector4 YX_W(Vector4 V){ return VecOps.MkVector4(V.y, V.x, 0, V.w); }
        public static Vector4 YX__(Vector4 V){ return VecOps.MkVector4(V.y, V.x, 0, 0); }
        public static Vector4 YYXX(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.x); }
        public static Vector4 YYXY(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.y); }
        public static Vector4 YYXZ(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.z); }
        public static Vector4 YYXW(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.w); }
        public static Vector4 YYX_(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.x, 0); }
        public static Vector4 YYYX(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.x); }
        public static Vector4 YYYY(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.y); }
        public static Vector4 YYYZ(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.z); }
        public static Vector4 YYYW(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.w); }
        public static Vector4 YYY_(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.y, 0); }
        public static Vector4 YYZX(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.x); }
        public static Vector4 YYZY(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.y); }
        public static Vector4 YYZZ(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.z); }
        public static Vector4 YYZW(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.w); }
        public static Vector4 YYZ_(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.z, 0); }
        public static Vector4 YYWX(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.w, V.x); }
        public static Vector4 YYWY(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.w, V.y); }
        public static Vector4 YYWZ(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.w, V.z); }
        public static Vector4 YYWW(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.w, V.w); }
        public static Vector4 YYW_(Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.w, 0); }
        public static Vector4 YY_X(Vector4 V){ return VecOps.MkVector4(V.y, V.y, 0, V.x); }
        public static Vector4 YY_Y(Vector4 V){ return VecOps.MkVector4(V.y, V.y, 0, V.y); }
        public static Vector4 YY_Z(Vector4 V){ return VecOps.MkVector4(V.y, V.y, 0, V.z); }
        public static Vector4 YY_W(Vector4 V){ return VecOps.MkVector4(V.y, V.y, 0, V.w); }
        public static Vector4 YY__(Vector4 V){ return VecOps.MkVector4(V.y, V.y, 0, 0); }
        public static Vector4 YZXX(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.x); }
        public static Vector4 YZXY(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.y); }
        public static Vector4 YZXZ(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.z); }
        public static Vector4 YZXW(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.w); }
        public static Vector4 YZX_(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.x, 0); }
        public static Vector4 YZYX(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.x); }
        public static Vector4 YZYY(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.y); }
        public static Vector4 YZYZ(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.z); }
        public static Vector4 YZYW(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.w); }
        public static Vector4 YZY_(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.y, 0); }
        public static Vector4 YZZX(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.x); }
        public static Vector4 YZZY(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.y); }
        public static Vector4 YZZZ(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.z); }
        public static Vector4 YZZW(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.w); }
        public static Vector4 YZZ_(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.z, 0); }
        public static Vector4 YZWX(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.w, V.x); }
        public static Vector4 YZWY(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.w, V.y); }
        public static Vector4 YZWZ(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.w, V.z); }
        public static Vector4 YZWW(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.w, V.w); }
        public static Vector4 YZW_(Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.w, 0); }
        public static Vector4 YZ_X(Vector4 V){ return VecOps.MkVector4(V.y, V.z, 0, V.x); }
        public static Vector4 YZ_Y(Vector4 V){ return VecOps.MkVector4(V.y, V.z, 0, V.y); }
        public static Vector4 YZ_Z(Vector4 V){ return VecOps.MkVector4(V.y, V.z, 0, V.z); }
        public static Vector4 YZ_W(Vector4 V){ return VecOps.MkVector4(V.y, V.z, 0, V.w); }
        public static Vector4 YZ__(Vector4 V){ return VecOps.MkVector4(V.y, V.z, 0, 0); }
        public static Vector4 YWXX(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.x, V.x); }
        public static Vector4 YWXY(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.x, V.y); }
        public static Vector4 YWXZ(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.x, V.z); }
        public static Vector4 YWXW(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.x, V.w); }
        public static Vector4 YWX_(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.x, 0); }
        public static Vector4 YWYX(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.y, V.x); }
        public static Vector4 YWYY(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.y, V.y); }
        public static Vector4 YWYZ(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.y, V.z); }
        public static Vector4 YWYW(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.y, V.w); }
        public static Vector4 YWY_(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.y, 0); }
        public static Vector4 YWZX(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.z, V.x); }
        public static Vector4 YWZY(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.z, V.y); }
        public static Vector4 YWZZ(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.z, V.z); }
        public static Vector4 YWZW(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.z, V.w); }
        public static Vector4 YWZ_(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.z, 0); }
        public static Vector4 YWWX(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.w, V.x); }
        public static Vector4 YWWY(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.w, V.y); }
        public static Vector4 YWWZ(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.w, V.z); }
        public static Vector4 YWWW(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.w, V.w); }
        public static Vector4 YWW_(Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.w, 0); }
        public static Vector4 YW_X(Vector4 V){ return VecOps.MkVector4(V.y, V.w, 0, V.x); }
        public static Vector4 YW_Y(Vector4 V){ return VecOps.MkVector4(V.y, V.w, 0, V.y); }
        public static Vector4 YW_Z(Vector4 V){ return VecOps.MkVector4(V.y, V.w, 0, V.z); }
        public static Vector4 YW_W(Vector4 V){ return VecOps.MkVector4(V.y, V.w, 0, V.w); }
        public static Vector4 YW__(Vector4 V){ return VecOps.MkVector4(V.y, V.w, 0, 0); }
        public static Vector4 Y_XX(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.x, V.x); }
        public static Vector4 Y_XY(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.x, V.y); }
        public static Vector4 Y_XZ(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.x, V.z); }
        public static Vector4 Y_XW(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.x, V.w); }
        public static Vector4 Y_X_(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.x, 0); }
        public static Vector4 Y_YX(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.y, V.x); }
        public static Vector4 Y_YY(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.y, V.y); }
        public static Vector4 Y_YZ(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.y, V.z); }
        public static Vector4 Y_YW(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.y, V.w); }
        public static Vector4 Y_Y_(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.y, 0); }
        public static Vector4 Y_ZX(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.z, V.x); }
        public static Vector4 Y_ZY(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.z, V.y); }
        public static Vector4 Y_ZZ(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.z, V.z); }
        public static Vector4 Y_ZW(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.z, V.w); }
        public static Vector4 Y_Z_(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.z, 0); }
        public static Vector4 Y_WX(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.w, V.x); }
        public static Vector4 Y_WY(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.w, V.y); }
        public static Vector4 Y_WZ(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.w, V.z); }
        public static Vector4 Y_WW(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.w, V.w); }
        public static Vector4 Y_W_(Vector4 V){ return VecOps.MkVector4(V.y, 0, V.w, 0); }
        public static Vector4 Y__X(Vector4 V){ return VecOps.MkVector4(V.y, 0, 0, V.x); }
        public static Vector4 Y__Y(Vector4 V){ return VecOps.MkVector4(V.y, 0, 0, V.y); }
        public static Vector4 Y__Z(Vector4 V){ return VecOps.MkVector4(V.y, 0, 0, V.z); }
        public static Vector4 Y__W(Vector4 V){ return VecOps.MkVector4(V.y, 0, 0, V.w); }
        public static Vector4 Y___(Vector4 V){ return VecOps.MkVector4(V.y, 0, 0, 0); }
        public static Vector4 ZXXX(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.x); }
        public static Vector4 ZXXY(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.y); }
        public static Vector4 ZXXZ(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.z); }
        public static Vector4 ZXXW(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.w); }
        public static Vector4 ZXX_(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.x, 0); }
        public static Vector4 ZXYX(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.x); }
        public static Vector4 ZXYY(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.y); }
        public static Vector4 ZXYZ(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.z); }
        public static Vector4 ZXYW(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.w); }
        public static Vector4 ZXY_(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.y, 0); }
        public static Vector4 ZXZX(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.x); }
        public static Vector4 ZXZY(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.y); }
        public static Vector4 ZXZZ(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.z); }
        public static Vector4 ZXZW(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.w); }
        public static Vector4 ZXZ_(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.z, 0); }
        public static Vector4 ZXWX(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.w, V.x); }
        public static Vector4 ZXWY(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.w, V.y); }
        public static Vector4 ZXWZ(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.w, V.z); }
        public static Vector4 ZXWW(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.w, V.w); }
        public static Vector4 ZXW_(Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.w, 0); }
        public static Vector4 ZX_X(Vector4 V){ return VecOps.MkVector4(V.z, V.x, 0, V.x); }
        public static Vector4 ZX_Y(Vector4 V){ return VecOps.MkVector4(V.z, V.x, 0, V.y); }
        public static Vector4 ZX_Z(Vector4 V){ return VecOps.MkVector4(V.z, V.x, 0, V.z); }
        public static Vector4 ZX_W(Vector4 V){ return VecOps.MkVector4(V.z, V.x, 0, V.w); }
        public static Vector4 ZX__(Vector4 V){ return VecOps.MkVector4(V.z, V.x, 0, 0); }
        public static Vector4 ZYXX(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.x); }
        public static Vector4 ZYXY(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.y); }
        public static Vector4 ZYXZ(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.z); }
        public static Vector4 ZYXW(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.w); }
        public static Vector4 ZYX_(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.x, 0); }
        public static Vector4 ZYYX(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.x); }
        public static Vector4 ZYYY(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.y); }
        public static Vector4 ZYYZ(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.z); }
        public static Vector4 ZYYW(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.w); }
        public static Vector4 ZYY_(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.y, 0); }
        public static Vector4 ZYZX(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.x); }
        public static Vector4 ZYZY(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.y); }
        public static Vector4 ZYZZ(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.z); }
        public static Vector4 ZYZW(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.w); }
        public static Vector4 ZYZ_(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.z, 0); }
        public static Vector4 ZYWX(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.w, V.x); }
        public static Vector4 ZYWY(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.w, V.y); }
        public static Vector4 ZYWZ(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.w, V.z); }
        public static Vector4 ZYWW(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.w, V.w); }
        public static Vector4 ZYW_(Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.w, 0); }
        public static Vector4 ZY_X(Vector4 V){ return VecOps.MkVector4(V.z, V.y, 0, V.x); }
        public static Vector4 ZY_Y(Vector4 V){ return VecOps.MkVector4(V.z, V.y, 0, V.y); }
        public static Vector4 ZY_Z(Vector4 V){ return VecOps.MkVector4(V.z, V.y, 0, V.z); }
        public static Vector4 ZY_W(Vector4 V){ return VecOps.MkVector4(V.z, V.y, 0, V.w); }
        public static Vector4 ZY__(Vector4 V){ return VecOps.MkVector4(V.z, V.y, 0, 0); }
        public static Vector4 ZZXX(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.x); }
        public static Vector4 ZZXY(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.y); }
        public static Vector4 ZZXZ(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.z); }
        public static Vector4 ZZXW(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.w); }
        public static Vector4 ZZX_(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.x, 0); }
        public static Vector4 ZZYX(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.x); }
        public static Vector4 ZZYY(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.y); }
        public static Vector4 ZZYZ(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.z); }
        public static Vector4 ZZYW(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.w); }
        public static Vector4 ZZY_(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.y, 0); }
        public static Vector4 ZZZX(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.x); }
        public static Vector4 ZZZY(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.y); }
        public static Vector4 ZZZZ(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.z); }
        public static Vector4 ZZZW(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.w); }
        public static Vector4 ZZZ_(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.z, 0); }
        public static Vector4 ZZWX(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.w, V.x); }
        public static Vector4 ZZWY(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.w, V.y); }
        public static Vector4 ZZWZ(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.w, V.z); }
        public static Vector4 ZZWW(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.w, V.w); }
        public static Vector4 ZZW_(Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.w, 0); }
        public static Vector4 ZZ_X(Vector4 V){ return VecOps.MkVector4(V.z, V.z, 0, V.x); }
        public static Vector4 ZZ_Y(Vector4 V){ return VecOps.MkVector4(V.z, V.z, 0, V.y); }
        public static Vector4 ZZ_Z(Vector4 V){ return VecOps.MkVector4(V.z, V.z, 0, V.z); }
        public static Vector4 ZZ_W(Vector4 V){ return VecOps.MkVector4(V.z, V.z, 0, V.w); }
        public static Vector4 ZZ__(Vector4 V){ return VecOps.MkVector4(V.z, V.z, 0, 0); }
        public static Vector4 ZWXX(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.x, V.x); }
        public static Vector4 ZWXY(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.x, V.y); }
        public static Vector4 ZWXZ(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.x, V.z); }
        public static Vector4 ZWXW(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.x, V.w); }
        public static Vector4 ZWX_(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.x, 0); }
        public static Vector4 ZWYX(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.y, V.x); }
        public static Vector4 ZWYY(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.y, V.y); }
        public static Vector4 ZWYZ(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.y, V.z); }
        public static Vector4 ZWYW(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.y, V.w); }
        public static Vector4 ZWY_(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.y, 0); }
        public static Vector4 ZWZX(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.z, V.x); }
        public static Vector4 ZWZY(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.z, V.y); }
        public static Vector4 ZWZZ(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.z, V.z); }
        public static Vector4 ZWZW(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.z, V.w); }
        public static Vector4 ZWZ_(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.z, 0); }
        public static Vector4 ZWWX(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.w, V.x); }
        public static Vector4 ZWWY(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.w, V.y); }
        public static Vector4 ZWWZ(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.w, V.z); }
        public static Vector4 ZWWW(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.w, V.w); }
        public static Vector4 ZWW_(Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.w, 0); }
        public static Vector4 ZW_X(Vector4 V){ return VecOps.MkVector4(V.z, V.w, 0, V.x); }
        public static Vector4 ZW_Y(Vector4 V){ return VecOps.MkVector4(V.z, V.w, 0, V.y); }
        public static Vector4 ZW_Z(Vector4 V){ return VecOps.MkVector4(V.z, V.w, 0, V.z); }
        public static Vector4 ZW_W(Vector4 V){ return VecOps.MkVector4(V.z, V.w, 0, V.w); }
        public static Vector4 ZW__(Vector4 V){ return VecOps.MkVector4(V.z, V.w, 0, 0); }
        public static Vector4 Z_XX(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.x, V.x); }
        public static Vector4 Z_XY(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.x, V.y); }
        public static Vector4 Z_XZ(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.x, V.z); }
        public static Vector4 Z_XW(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.x, V.w); }
        public static Vector4 Z_X_(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.x, 0); }
        public static Vector4 Z_YX(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.y, V.x); }
        public static Vector4 Z_YY(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.y, V.y); }
        public static Vector4 Z_YZ(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.y, V.z); }
        public static Vector4 Z_YW(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.y, V.w); }
        public static Vector4 Z_Y_(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.y, 0); }
        public static Vector4 Z_ZX(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.z, V.x); }
        public static Vector4 Z_ZY(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.z, V.y); }
        public static Vector4 Z_ZZ(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.z, V.z); }
        public static Vector4 Z_ZW(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.z, V.w); }
        public static Vector4 Z_Z_(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.z, 0); }
        public static Vector4 Z_WX(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.w, V.x); }
        public static Vector4 Z_WY(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.w, V.y); }
        public static Vector4 Z_WZ(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.w, V.z); }
        public static Vector4 Z_WW(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.w, V.w); }
        public static Vector4 Z_W_(Vector4 V){ return VecOps.MkVector4(V.z, 0, V.w, 0); }
        public static Vector4 Z__X(Vector4 V){ return VecOps.MkVector4(V.z, 0, 0, V.x); }
        public static Vector4 Z__Y(Vector4 V){ return VecOps.MkVector4(V.z, 0, 0, V.y); }
        public static Vector4 Z__Z(Vector4 V){ return VecOps.MkVector4(V.z, 0, 0, V.z); }
        public static Vector4 Z__W(Vector4 V){ return VecOps.MkVector4(V.z, 0, 0, V.w); }
        public static Vector4 Z___(Vector4 V){ return VecOps.MkVector4(V.z, 0, 0, 0); }
        public static Vector4 WXXX(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.x, V.x); }
        public static Vector4 WXXY(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.x, V.y); }
        public static Vector4 WXXZ(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.x, V.z); }
        public static Vector4 WXXW(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.x, V.w); }
        public static Vector4 WXX_(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.x, 0); }
        public static Vector4 WXYX(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.y, V.x); }
        public static Vector4 WXYY(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.y, V.y); }
        public static Vector4 WXYZ(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.y, V.z); }
        public static Vector4 WXYW(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.y, V.w); }
        public static Vector4 WXY_(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.y, 0); }
        public static Vector4 WXZX(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.z, V.x); }
        public static Vector4 WXZY(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.z, V.y); }
        public static Vector4 WXZZ(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.z, V.z); }
        public static Vector4 WXZW(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.z, V.w); }
        public static Vector4 WXZ_(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.z, 0); }
        public static Vector4 WXWX(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.w, V.x); }
        public static Vector4 WXWY(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.w, V.y); }
        public static Vector4 WXWZ(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.w, V.z); }
        public static Vector4 WXWW(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.w, V.w); }
        public static Vector4 WXW_(Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.w, 0); }
        public static Vector4 WX_X(Vector4 V){ return VecOps.MkVector4(V.w, V.x, 0, V.x); }
        public static Vector4 WX_Y(Vector4 V){ return VecOps.MkVector4(V.w, V.x, 0, V.y); }
        public static Vector4 WX_Z(Vector4 V){ return VecOps.MkVector4(V.w, V.x, 0, V.z); }
        public static Vector4 WX_W(Vector4 V){ return VecOps.MkVector4(V.w, V.x, 0, V.w); }
        public static Vector4 WX__(Vector4 V){ return VecOps.MkVector4(V.w, V.x, 0, 0); }
        public static Vector4 WYXX(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.x, V.x); }
        public static Vector4 WYXY(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.x, V.y); }
        public static Vector4 WYXZ(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.x, V.z); }
        public static Vector4 WYXW(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.x, V.w); }
        public static Vector4 WYX_(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.x, 0); }
        public static Vector4 WYYX(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.y, V.x); }
        public static Vector4 WYYY(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.y, V.y); }
        public static Vector4 WYYZ(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.y, V.z); }
        public static Vector4 WYYW(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.y, V.w); }
        public static Vector4 WYY_(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.y, 0); }
        public static Vector4 WYZX(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.z, V.x); }
        public static Vector4 WYZY(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.z, V.y); }
        public static Vector4 WYZZ(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.z, V.z); }
        public static Vector4 WYZW(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.z, V.w); }
        public static Vector4 WYZ_(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.z, 0); }
        public static Vector4 WYWX(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.w, V.x); }
        public static Vector4 WYWY(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.w, V.y); }
        public static Vector4 WYWZ(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.w, V.z); }
        public static Vector4 WYWW(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.w, V.w); }
        public static Vector4 WYW_(Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.w, 0); }
        public static Vector4 WY_X(Vector4 V){ return VecOps.MkVector4(V.w, V.y, 0, V.x); }
        public static Vector4 WY_Y(Vector4 V){ return VecOps.MkVector4(V.w, V.y, 0, V.y); }
        public static Vector4 WY_Z(Vector4 V){ return VecOps.MkVector4(V.w, V.y, 0, V.z); }
        public static Vector4 WY_W(Vector4 V){ return VecOps.MkVector4(V.w, V.y, 0, V.w); }
        public static Vector4 WY__(Vector4 V){ return VecOps.MkVector4(V.w, V.y, 0, 0); }
        public static Vector4 WZXX(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.x, V.x); }
        public static Vector4 WZXY(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.x, V.y); }
        public static Vector4 WZXZ(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.x, V.z); }
        public static Vector4 WZXW(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.x, V.w); }
        public static Vector4 WZX_(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.x, 0); }
        public static Vector4 WZYX(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.y, V.x); }
        public static Vector4 WZYY(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.y, V.y); }
        public static Vector4 WZYZ(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.y, V.z); }
        public static Vector4 WZYW(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.y, V.w); }
        public static Vector4 WZY_(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.y, 0); }
        public static Vector4 WZZX(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.z, V.x); }
        public static Vector4 WZZY(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.z, V.y); }
        public static Vector4 WZZZ(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.z, V.z); }
        public static Vector4 WZZW(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.z, V.w); }
        public static Vector4 WZZ_(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.z, 0); }
        public static Vector4 WZWX(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.w, V.x); }
        public static Vector4 WZWY(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.w, V.y); }
        public static Vector4 WZWZ(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.w, V.z); }
        public static Vector4 WZWW(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.w, V.w); }
        public static Vector4 WZW_(Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.w, 0); }
        public static Vector4 WZ_X(Vector4 V){ return VecOps.MkVector4(V.w, V.z, 0, V.x); }
        public static Vector4 WZ_Y(Vector4 V){ return VecOps.MkVector4(V.w, V.z, 0, V.y); }
        public static Vector4 WZ_Z(Vector4 V){ return VecOps.MkVector4(V.w, V.z, 0, V.z); }
        public static Vector4 WZ_W(Vector4 V){ return VecOps.MkVector4(V.w, V.z, 0, V.w); }
        public static Vector4 WZ__(Vector4 V){ return VecOps.MkVector4(V.w, V.z, 0, 0); }
        public static Vector4 WWXX(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.x, V.x); }
        public static Vector4 WWXY(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.x, V.y); }
        public static Vector4 WWXZ(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.x, V.z); }
        public static Vector4 WWXW(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.x, V.w); }
        public static Vector4 WWX_(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.x, 0); }
        public static Vector4 WWYX(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.y, V.x); }
        public static Vector4 WWYY(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.y, V.y); }
        public static Vector4 WWYZ(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.y, V.z); }
        public static Vector4 WWYW(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.y, V.w); }
        public static Vector4 WWY_(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.y, 0); }
        public static Vector4 WWZX(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.z, V.x); }
        public static Vector4 WWZY(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.z, V.y); }
        public static Vector4 WWZZ(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.z, V.z); }
        public static Vector4 WWZW(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.z, V.w); }
        public static Vector4 WWZ_(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.z, 0); }
        public static Vector4 WWWX(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.w, V.x); }
        public static Vector4 WWWY(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.w, V.y); }
        public static Vector4 WWWZ(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.w, V.z); }
        public static Vector4 WWWW(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.w, V.w); }
        public static Vector4 WWW_(Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.w, 0); }
        public static Vector4 WW_X(Vector4 V){ return VecOps.MkVector4(V.w, V.w, 0, V.x); }
        public static Vector4 WW_Y(Vector4 V){ return VecOps.MkVector4(V.w, V.w, 0, V.y); }
        public static Vector4 WW_Z(Vector4 V){ return VecOps.MkVector4(V.w, V.w, 0, V.z); }
        public static Vector4 WW_W(Vector4 V){ return VecOps.MkVector4(V.w, V.w, 0, V.w); }
        public static Vector4 WW__(Vector4 V){ return VecOps.MkVector4(V.w, V.w, 0, 0); }
        public static Vector4 W_XX(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.x, V.x); }
        public static Vector4 W_XY(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.x, V.y); }
        public static Vector4 W_XZ(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.x, V.z); }
        public static Vector4 W_XW(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.x, V.w); }
        public static Vector4 W_X_(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.x, 0); }
        public static Vector4 W_YX(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.y, V.x); }
        public static Vector4 W_YY(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.y, V.y); }
        public static Vector4 W_YZ(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.y, V.z); }
        public static Vector4 W_YW(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.y, V.w); }
        public static Vector4 W_Y_(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.y, 0); }
        public static Vector4 W_ZX(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.z, V.x); }
        public static Vector4 W_ZY(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.z, V.y); }
        public static Vector4 W_ZZ(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.z, V.z); }
        public static Vector4 W_ZW(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.z, V.w); }
        public static Vector4 W_Z_(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.z, 0); }
        public static Vector4 W_WX(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.w, V.x); }
        public static Vector4 W_WY(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.w, V.y); }
        public static Vector4 W_WZ(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.w, V.z); }
        public static Vector4 W_WW(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.w, V.w); }
        public static Vector4 W_W_(Vector4 V){ return VecOps.MkVector4(V.w, 0, V.w, 0); }
        public static Vector4 W__X(Vector4 V){ return VecOps.MkVector4(V.w, 0, 0, V.x); }
        public static Vector4 W__Y(Vector4 V){ return VecOps.MkVector4(V.w, 0, 0, V.y); }
        public static Vector4 W__Z(Vector4 V){ return VecOps.MkVector4(V.w, 0, 0, V.z); }
        public static Vector4 W__W(Vector4 V){ return VecOps.MkVector4(V.w, 0, 0, V.w); }
        public static Vector4 W___(Vector4 V){ return VecOps.MkVector4(V.w, 0, 0, 0); }
        public static Vector4 _XXX(Vector4 V){ return VecOps.MkVector4(0, V.x, V.x, V.x); }
        public static Vector4 _XXY(Vector4 V){ return VecOps.MkVector4(0, V.x, V.x, V.y); }
        public static Vector4 _XXZ(Vector4 V){ return VecOps.MkVector4(0, V.x, V.x, V.z); }
        public static Vector4 _XXW(Vector4 V){ return VecOps.MkVector4(0, V.x, V.x, V.w); }
        public static Vector4 _XX_(Vector4 V){ return VecOps.MkVector4(0, V.x, V.x, 0); }
        public static Vector4 _XYX(Vector4 V){ return VecOps.MkVector4(0, V.x, V.y, V.x); }
        public static Vector4 _XYY(Vector4 V){ return VecOps.MkVector4(0, V.x, V.y, V.y); }
        public static Vector4 _XYZ(Vector4 V){ return VecOps.MkVector4(0, V.x, V.y, V.z); }
        public static Vector4 _XYW(Vector4 V){ return VecOps.MkVector4(0, V.x, V.y, V.w); }
        public static Vector4 _XY_(Vector4 V){ return VecOps.MkVector4(0, V.x, V.y, 0); }
        public static Vector4 _XZX(Vector4 V){ return VecOps.MkVector4(0, V.x, V.z, V.x); }
        public static Vector4 _XZY(Vector4 V){ return VecOps.MkVector4(0, V.x, V.z, V.y); }
        public static Vector4 _XZZ(Vector4 V){ return VecOps.MkVector4(0, V.x, V.z, V.z); }
        public static Vector4 _XZW(Vector4 V){ return VecOps.MkVector4(0, V.x, V.z, V.w); }
        public static Vector4 _XZ_(Vector4 V){ return VecOps.MkVector4(0, V.x, V.z, 0); }
        public static Vector4 _XWX(Vector4 V){ return VecOps.MkVector4(0, V.x, V.w, V.x); }
        public static Vector4 _XWY(Vector4 V){ return VecOps.MkVector4(0, V.x, V.w, V.y); }
        public static Vector4 _XWZ(Vector4 V){ return VecOps.MkVector4(0, V.x, V.w, V.z); }
        public static Vector4 _XWW(Vector4 V){ return VecOps.MkVector4(0, V.x, V.w, V.w); }
        public static Vector4 _XW_(Vector4 V){ return VecOps.MkVector4(0, V.x, V.w, 0); }
        public static Vector4 _X_X(Vector4 V){ return VecOps.MkVector4(0, V.x, 0, V.x); }
        public static Vector4 _X_Y(Vector4 V){ return VecOps.MkVector4(0, V.x, 0, V.y); }
        public static Vector4 _X_Z(Vector4 V){ return VecOps.MkVector4(0, V.x, 0, V.z); }
        public static Vector4 _X_W(Vector4 V){ return VecOps.MkVector4(0, V.x, 0, V.w); }
        public static Vector4 _X__(Vector4 V){ return VecOps.MkVector4(0, V.x, 0, 0); }
        public static Vector4 _YXX(Vector4 V){ return VecOps.MkVector4(0, V.y, V.x, V.x); }
        public static Vector4 _YXY(Vector4 V){ return VecOps.MkVector4(0, V.y, V.x, V.y); }
        public static Vector4 _YXZ(Vector4 V){ return VecOps.MkVector4(0, V.y, V.x, V.z); }
        public static Vector4 _YXW(Vector4 V){ return VecOps.MkVector4(0, V.y, V.x, V.w); }
        public static Vector4 _YX_(Vector4 V){ return VecOps.MkVector4(0, V.y, V.x, 0); }
        public static Vector4 _YYX(Vector4 V){ return VecOps.MkVector4(0, V.y, V.y, V.x); }
        public static Vector4 _YYY(Vector4 V){ return VecOps.MkVector4(0, V.y, V.y, V.y); }
        public static Vector4 _YYZ(Vector4 V){ return VecOps.MkVector4(0, V.y, V.y, V.z); }
        public static Vector4 _YYW(Vector4 V){ return VecOps.MkVector4(0, V.y, V.y, V.w); }
        public static Vector4 _YY_(Vector4 V){ return VecOps.MkVector4(0, V.y, V.y, 0); }
        public static Vector4 _YZX(Vector4 V){ return VecOps.MkVector4(0, V.y, V.z, V.x); }
        public static Vector4 _YZY(Vector4 V){ return VecOps.MkVector4(0, V.y, V.z, V.y); }
        public static Vector4 _YZZ(Vector4 V){ return VecOps.MkVector4(0, V.y, V.z, V.z); }
        public static Vector4 _YZW(Vector4 V){ return VecOps.MkVector4(0, V.y, V.z, V.w); }
        public static Vector4 _YZ_(Vector4 V){ return VecOps.MkVector4(0, V.y, V.z, 0); }
        public static Vector4 _YWX(Vector4 V){ return VecOps.MkVector4(0, V.y, V.w, V.x); }
        public static Vector4 _YWY(Vector4 V){ return VecOps.MkVector4(0, V.y, V.w, V.y); }
        public static Vector4 _YWZ(Vector4 V){ return VecOps.MkVector4(0, V.y, V.w, V.z); }
        public static Vector4 _YWW(Vector4 V){ return VecOps.MkVector4(0, V.y, V.w, V.w); }
        public static Vector4 _YW_(Vector4 V){ return VecOps.MkVector4(0, V.y, V.w, 0); }
        public static Vector4 _Y_X(Vector4 V){ return VecOps.MkVector4(0, V.y, 0, V.x); }
        public static Vector4 _Y_Y(Vector4 V){ return VecOps.MkVector4(0, V.y, 0, V.y); }
        public static Vector4 _Y_Z(Vector4 V){ return VecOps.MkVector4(0, V.y, 0, V.z); }
        public static Vector4 _Y_W(Vector4 V){ return VecOps.MkVector4(0, V.y, 0, V.w); }
        public static Vector4 _Y__(Vector4 V){ return VecOps.MkVector4(0, V.y, 0, 0); }
        public static Vector4 _ZXX(Vector4 V){ return VecOps.MkVector4(0, V.z, V.x, V.x); }
        public static Vector4 _ZXY(Vector4 V){ return VecOps.MkVector4(0, V.z, V.x, V.y); }
        public static Vector4 _ZXZ(Vector4 V){ return VecOps.MkVector4(0, V.z, V.x, V.z); }
        public static Vector4 _ZXW(Vector4 V){ return VecOps.MkVector4(0, V.z, V.x, V.w); }
        public static Vector4 _ZX_(Vector4 V){ return VecOps.MkVector4(0, V.z, V.x, 0); }
        public static Vector4 _ZYX(Vector4 V){ return VecOps.MkVector4(0, V.z, V.y, V.x); }
        public static Vector4 _ZYY(Vector4 V){ return VecOps.MkVector4(0, V.z, V.y, V.y); }
        public static Vector4 _ZYZ(Vector4 V){ return VecOps.MkVector4(0, V.z, V.y, V.z); }
        public static Vector4 _ZYW(Vector4 V){ return VecOps.MkVector4(0, V.z, V.y, V.w); }
        public static Vector4 _ZY_(Vector4 V){ return VecOps.MkVector4(0, V.z, V.y, 0); }
        public static Vector4 _ZZX(Vector4 V){ return VecOps.MkVector4(0, V.z, V.z, V.x); }
        public static Vector4 _ZZY(Vector4 V){ return VecOps.MkVector4(0, V.z, V.z, V.y); }
        public static Vector4 _ZZZ(Vector4 V){ return VecOps.MkVector4(0, V.z, V.z, V.z); }
        public static Vector4 _ZZW(Vector4 V){ return VecOps.MkVector4(0, V.z, V.z, V.w); }
        public static Vector4 _ZZ_(Vector4 V){ return VecOps.MkVector4(0, V.z, V.z, 0); }
        public static Vector4 _ZWX(Vector4 V){ return VecOps.MkVector4(0, V.z, V.w, V.x); }
        public static Vector4 _ZWY(Vector4 V){ return VecOps.MkVector4(0, V.z, V.w, V.y); }
        public static Vector4 _ZWZ(Vector4 V){ return VecOps.MkVector4(0, V.z, V.w, V.z); }
        public static Vector4 _ZWW(Vector4 V){ return VecOps.MkVector4(0, V.z, V.w, V.w); }
        public static Vector4 _ZW_(Vector4 V){ return VecOps.MkVector4(0, V.z, V.w, 0); }
        public static Vector4 _Z_X(Vector4 V){ return VecOps.MkVector4(0, V.z, 0, V.x); }
        public static Vector4 _Z_Y(Vector4 V){ return VecOps.MkVector4(0, V.z, 0, V.y); }
        public static Vector4 _Z_Z(Vector4 V){ return VecOps.MkVector4(0, V.z, 0, V.z); }
        public static Vector4 _Z_W(Vector4 V){ return VecOps.MkVector4(0, V.z, 0, V.w); }
        public static Vector4 _Z__(Vector4 V){ return VecOps.MkVector4(0, V.z, 0, 0); }
        public static Vector4 _WXX(Vector4 V){ return VecOps.MkVector4(0, V.w, V.x, V.x); }
        public static Vector4 _WXY(Vector4 V){ return VecOps.MkVector4(0, V.w, V.x, V.y); }
        public static Vector4 _WXZ(Vector4 V){ return VecOps.MkVector4(0, V.w, V.x, V.z); }
        public static Vector4 _WXW(Vector4 V){ return VecOps.MkVector4(0, V.w, V.x, V.w); }
        public static Vector4 _WX_(Vector4 V){ return VecOps.MkVector4(0, V.w, V.x, 0); }
        public static Vector4 _WYX(Vector4 V){ return VecOps.MkVector4(0, V.w, V.y, V.x); }
        public static Vector4 _WYY(Vector4 V){ return VecOps.MkVector4(0, V.w, V.y, V.y); }
        public static Vector4 _WYZ(Vector4 V){ return VecOps.MkVector4(0, V.w, V.y, V.z); }
        public static Vector4 _WYW(Vector4 V){ return VecOps.MkVector4(0, V.w, V.y, V.w); }
        public static Vector4 _WY_(Vector4 V){ return VecOps.MkVector4(0, V.w, V.y, 0); }
        public static Vector4 _WZX(Vector4 V){ return VecOps.MkVector4(0, V.w, V.z, V.x); }
        public static Vector4 _WZY(Vector4 V){ return VecOps.MkVector4(0, V.w, V.z, V.y); }
        public static Vector4 _WZZ(Vector4 V){ return VecOps.MkVector4(0, V.w, V.z, V.z); }
        public static Vector4 _WZW(Vector4 V){ return VecOps.MkVector4(0, V.w, V.z, V.w); }
        public static Vector4 _WZ_(Vector4 V){ return VecOps.MkVector4(0, V.w, V.z, 0); }
        public static Vector4 _WWX(Vector4 V){ return VecOps.MkVector4(0, V.w, V.w, V.x); }
        public static Vector4 _WWY(Vector4 V){ return VecOps.MkVector4(0, V.w, V.w, V.y); }
        public static Vector4 _WWZ(Vector4 V){ return VecOps.MkVector4(0, V.w, V.w, V.z); }
        public static Vector4 _WWW(Vector4 V){ return VecOps.MkVector4(0, V.w, V.w, V.w); }
        public static Vector4 _WW_(Vector4 V){ return VecOps.MkVector4(0, V.w, V.w, 0); }
        public static Vector4 _W_X(Vector4 V){ return VecOps.MkVector4(0, V.w, 0, V.x); }
        public static Vector4 _W_Y(Vector4 V){ return VecOps.MkVector4(0, V.w, 0, V.y); }
        public static Vector4 _W_Z(Vector4 V){ return VecOps.MkVector4(0, V.w, 0, V.z); }
        public static Vector4 _W_W(Vector4 V){ return VecOps.MkVector4(0, V.w, 0, V.w); }
        public static Vector4 _W__(Vector4 V){ return VecOps.MkVector4(0, V.w, 0, 0); }
        public static Vector4 __XX(Vector4 V){ return VecOps.MkVector4(0, 0, V.x, V.x); }
        public static Vector4 __XY(Vector4 V){ return VecOps.MkVector4(0, 0, V.x, V.y); }
        public static Vector4 __XZ(Vector4 V){ return VecOps.MkVector4(0, 0, V.x, V.z); }
        public static Vector4 __XW(Vector4 V){ return VecOps.MkVector4(0, 0, V.x, V.w); }
        public static Vector4 __X_(Vector4 V){ return VecOps.MkVector4(0, 0, V.x, 0); }
        public static Vector4 __YX(Vector4 V){ return VecOps.MkVector4(0, 0, V.y, V.x); }
        public static Vector4 __YY(Vector4 V){ return VecOps.MkVector4(0, 0, V.y, V.y); }
        public static Vector4 __YZ(Vector4 V){ return VecOps.MkVector4(0, 0, V.y, V.z); }
        public static Vector4 __YW(Vector4 V){ return VecOps.MkVector4(0, 0, V.y, V.w); }
        public static Vector4 __Y_(Vector4 V){ return VecOps.MkVector4(0, 0, V.y, 0); }
        public static Vector4 __ZX(Vector4 V){ return VecOps.MkVector4(0, 0, V.z, V.x); }
        public static Vector4 __ZY(Vector4 V){ return VecOps.MkVector4(0, 0, V.z, V.y); }
        public static Vector4 __ZZ(Vector4 V){ return VecOps.MkVector4(0, 0, V.z, V.z); }
        public static Vector4 __ZW(Vector4 V){ return VecOps.MkVector4(0, 0, V.z, V.w); }
        public static Vector4 __Z_(Vector4 V){ return VecOps.MkVector4(0, 0, V.z, 0); }
        public static Vector4 __WX(Vector4 V){ return VecOps.MkVector4(0, 0, V.w, V.x); }
        public static Vector4 __WY(Vector4 V){ return VecOps.MkVector4(0, 0, V.w, V.y); }
        public static Vector4 __WZ(Vector4 V){ return VecOps.MkVector4(0, 0, V.w, V.z); }
        public static Vector4 __WW(Vector4 V){ return VecOps.MkVector4(0, 0, V.w, V.w); }
        public static Vector4 __W_(Vector4 V){ return VecOps.MkVector4(0, 0, V.w, 0); }
        public static Vector4 ___X(Vector4 V){ return VecOps.MkVector4(0, 0, 0, V.x); }
        public static Vector4 ___Y(Vector4 V){ return VecOps.MkVector4(0, 0, 0, V.y); }
        public static Vector4 ___Z(Vector4 V){ return VecOps.MkVector4(0, 0, 0, V.z); }
        public static Vector4 ___W(Vector4 V){ return VecOps.MkVector4(0, 0, 0, V.w); }
    }
}