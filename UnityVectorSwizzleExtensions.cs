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
        public static VectorI2 XX(this VectorI2 V){ return VecOps.MkVectorI2(V.x, V.x); }
        public static VectorI2 XY(this VectorI2 V){ return VecOps.MkVectorI2(V.x, V.y); }
        public static VectorI2 X_(this VectorI2 V){ return VecOps.MkVectorI2(V.x, 0); }
        public static VectorI2 YX(this VectorI2 V){ return VecOps.MkVectorI2(V.y, V.x); }
        public static VectorI2 YY(this VectorI2 V){ return VecOps.MkVectorI2(V.y, V.y); }
        public static VectorI2 Y_(this VectorI2 V){ return VecOps.MkVectorI2(V.y, 0); }
        public static VectorI2 _X(this VectorI2 V){ return VecOps.MkVectorI2(0, V.x); }
        public static VectorI2 _Y(this VectorI2 V){ return VecOps.MkVectorI2(0, V.y); }
        public static VectorI3 XXX(this VectorI2 V){ return VecOps.MkVectorI3(V.x, V.x, V.x); }
        public static VectorI3 XXY(this VectorI2 V){ return VecOps.MkVectorI3(V.x, V.x, V.y); }
        public static VectorI3 XX_(this VectorI2 V){ return VecOps.MkVectorI3(V.x, V.x, 0); }
        public static VectorI3 XYX(this VectorI2 V){ return VecOps.MkVectorI3(V.x, V.y, V.x); }
        public static VectorI3 XYY(this VectorI2 V){ return VecOps.MkVectorI3(V.x, V.y, V.y); }
        public static VectorI3 XY_(this VectorI2 V){ return VecOps.MkVectorI3(V.x, V.y, 0); }
        public static VectorI3 X_X(this VectorI2 V){ return VecOps.MkVectorI3(V.x, 0, V.x); }
        public static VectorI3 X_Y(this VectorI2 V){ return VecOps.MkVectorI3(V.x, 0, V.y); }
        public static VectorI3 X__(this VectorI2 V){ return VecOps.MkVectorI3(V.x, 0, 0); }
        public static VectorI3 YXX(this VectorI2 V){ return VecOps.MkVectorI3(V.y, V.x, V.x); }
        public static VectorI3 YXY(this VectorI2 V){ return VecOps.MkVectorI3(V.y, V.x, V.y); }
        public static VectorI3 YX_(this VectorI2 V){ return VecOps.MkVectorI3(V.y, V.x, 0); }
        public static VectorI3 YYX(this VectorI2 V){ return VecOps.MkVectorI3(V.y, V.y, V.x); }
        public static VectorI3 YYY(this VectorI2 V){ return VecOps.MkVectorI3(V.y, V.y, V.y); }
        public static VectorI3 YY_(this VectorI2 V){ return VecOps.MkVectorI3(V.y, V.y, 0); }
        public static VectorI3 Y_X(this VectorI2 V){ return VecOps.MkVectorI3(V.y, 0, V.x); }
        public static VectorI3 Y_Y(this VectorI2 V){ return VecOps.MkVectorI3(V.y, 0, V.y); }
        public static VectorI3 Y__(this VectorI2 V){ return VecOps.MkVectorI3(V.y, 0, 0); }
        public static VectorI3 _XX(this VectorI2 V){ return VecOps.MkVectorI3(0, V.x, V.x); }
        public static VectorI3 _XY(this VectorI2 V){ return VecOps.MkVectorI3(0, V.x, V.y); }
        public static VectorI3 _X_(this VectorI2 V){ return VecOps.MkVectorI3(0, V.x, 0); }
        public static VectorI3 _YX(this VectorI2 V){ return VecOps.MkVectorI3(0, V.y, V.x); }
        public static VectorI3 _YY(this VectorI2 V){ return VecOps.MkVectorI3(0, V.y, V.y); }
        public static VectorI3 _Y_(this VectorI2 V){ return VecOps.MkVectorI3(0, V.y, 0); }
        public static VectorI3 __X(this VectorI2 V){ return VecOps.MkVectorI3(0, 0, V.x); }
        public static VectorI3 __Y(this VectorI2 V){ return VecOps.MkVectorI3(0, 0, V.y); }
        public static VectorI4 XXXX(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.x); }
        public static VectorI4 XXXY(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.y); }
        public static VectorI4 XXX_(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, 0); }
        public static VectorI4 XXYX(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.x); }
        public static VectorI4 XXYY(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.y); }
        public static VectorI4 XXY_(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, 0); }
        public static VectorI4 XX_X(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.x); }
        public static VectorI4 XX_Y(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.y); }
        public static VectorI4 XX__(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.x, 0, 0); }
        public static VectorI4 XYXX(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.x); }
        public static VectorI4 XYXY(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.y); }
        public static VectorI4 XYX_(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, 0); }
        public static VectorI4 XYYX(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.x); }
        public static VectorI4 XYYY(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.y); }
        public static VectorI4 XYY_(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, 0); }
        public static VectorI4 XY_X(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.x); }
        public static VectorI4 XY_Y(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.y); }
        public static VectorI4 XY__(this VectorI2 V){ return VecOps.MkVectorI4(V.x, V.y, 0, 0); }
        public static VectorI4 X_XX(this VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.x); }
        public static VectorI4 X_XY(this VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.y); }
        public static VectorI4 X_X_(this VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.x, 0); }
        public static VectorI4 X_YX(this VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.x); }
        public static VectorI4 X_YY(this VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.y); }
        public static VectorI4 X_Y_(this VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, V.y, 0); }
        public static VectorI4 X__X(this VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.x); }
        public static VectorI4 X__Y(this VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.y); }
        public static VectorI4 X___(this VectorI2 V){ return VecOps.MkVectorI4(V.x, 0, 0, 0); }
        public static VectorI4 YXXX(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.x); }
        public static VectorI4 YXXY(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.y); }
        public static VectorI4 YXX_(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, 0); }
        public static VectorI4 YXYX(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.x); }
        public static VectorI4 YXYY(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.y); }
        public static VectorI4 YXY_(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, 0); }
        public static VectorI4 YX_X(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.x); }
        public static VectorI4 YX_Y(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.y); }
        public static VectorI4 YX__(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.x, 0, 0); }
        public static VectorI4 YYXX(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.x); }
        public static VectorI4 YYXY(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.y); }
        public static VectorI4 YYX_(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, 0); }
        public static VectorI4 YYYX(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.x); }
        public static VectorI4 YYYY(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.y); }
        public static VectorI4 YYY_(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, 0); }
        public static VectorI4 YY_X(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.x); }
        public static VectorI4 YY_Y(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.y); }
        public static VectorI4 YY__(this VectorI2 V){ return VecOps.MkVectorI4(V.y, V.y, 0, 0); }
        public static VectorI4 Y_XX(this VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.x); }
        public static VectorI4 Y_XY(this VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.y); }
        public static VectorI4 Y_X_(this VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.x, 0); }
        public static VectorI4 Y_YX(this VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.x); }
        public static VectorI4 Y_YY(this VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.y); }
        public static VectorI4 Y_Y_(this VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, V.y, 0); }
        public static VectorI4 Y__X(this VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.x); }
        public static VectorI4 Y__Y(this VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.y); }
        public static VectorI4 Y___(this VectorI2 V){ return VecOps.MkVectorI4(V.y, 0, 0, 0); }
        public static VectorI4 _XXX(this VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.x); }
        public static VectorI4 _XXY(this VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.y); }
        public static VectorI4 _XX_(this VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.x, 0); }
        public static VectorI4 _XYX(this VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.x); }
        public static VectorI4 _XYY(this VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.y); }
        public static VectorI4 _XY_(this VectorI2 V){ return VecOps.MkVectorI4(0, V.x, V.y, 0); }
        public static VectorI4 _X_X(this VectorI2 V){ return VecOps.MkVectorI4(0, V.x, 0, V.x); }
        public static VectorI4 _X_Y(this VectorI2 V){ return VecOps.MkVectorI4(0, V.x, 0, V.y); }
        public static VectorI4 _X__(this VectorI2 V){ return VecOps.MkVectorI4(0, V.x, 0, 0); }
        public static VectorI4 _YXX(this VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.x); }
        public static VectorI4 _YXY(this VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.y); }
        public static VectorI4 _YX_(this VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.x, 0); }
        public static VectorI4 _YYX(this VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.x); }
        public static VectorI4 _YYY(this VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.y); }
        public static VectorI4 _YY_(this VectorI2 V){ return VecOps.MkVectorI4(0, V.y, V.y, 0); }
        public static VectorI4 _Y_X(this VectorI2 V){ return VecOps.MkVectorI4(0, V.y, 0, V.x); }
        public static VectorI4 _Y_Y(this VectorI2 V){ return VecOps.MkVectorI4(0, V.y, 0, V.y); }
        public static VectorI4 _Y__(this VectorI2 V){ return VecOps.MkVectorI4(0, V.y, 0, 0); }
        public static VectorI4 __XX(this VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.x, V.x); }
        public static VectorI4 __XY(this VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.x, V.y); }
        public static VectorI4 __X_(this VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.x, 0); }
        public static VectorI4 __YX(this VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.y, V.x); }
        public static VectorI4 __YY(this VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.y, V.y); }
        public static VectorI4 __Y_(this VectorI2 V){ return VecOps.MkVectorI4(0, 0, V.y, 0); }
        public static VectorI4 ___X(this VectorI2 V){ return VecOps.MkVectorI4(0, 0, 0, V.x); }
        public static VectorI4 ___Y(this VectorI2 V){ return VecOps.MkVectorI4(0, 0, 0, V.y); }
        public static VectorI2 XX(this VectorI3 V){ return VecOps.MkVectorI2(V.x, V.x); }
        public static VectorI2 XY(this VectorI3 V){ return VecOps.MkVectorI2(V.x, V.y); }
        public static VectorI2 XZ(this VectorI3 V){ return VecOps.MkVectorI2(V.x, V.z); }
        public static VectorI2 X_(this VectorI3 V){ return VecOps.MkVectorI2(V.x, 0); }
        public static VectorI2 YX(this VectorI3 V){ return VecOps.MkVectorI2(V.y, V.x); }
        public static VectorI2 YY(this VectorI3 V){ return VecOps.MkVectorI2(V.y, V.y); }
        public static VectorI2 YZ(this VectorI3 V){ return VecOps.MkVectorI2(V.y, V.z); }
        public static VectorI2 Y_(this VectorI3 V){ return VecOps.MkVectorI2(V.y, 0); }
        public static VectorI2 ZX(this VectorI3 V){ return VecOps.MkVectorI2(V.z, V.x); }
        public static VectorI2 ZY(this VectorI3 V){ return VecOps.MkVectorI2(V.z, V.y); }
        public static VectorI2 ZZ(this VectorI3 V){ return VecOps.MkVectorI2(V.z, V.z); }
        public static VectorI2 Z_(this VectorI3 V){ return VecOps.MkVectorI2(V.z, 0); }
        public static VectorI2 _X(this VectorI3 V){ return VecOps.MkVectorI2(0, V.x); }
        public static VectorI2 _Y(this VectorI3 V){ return VecOps.MkVectorI2(0, V.y); }
        public static VectorI2 _Z(this VectorI3 V){ return VecOps.MkVectorI2(0, V.z); }
        public static VectorI3 XXX(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.x, V.x); }
        public static VectorI3 XXY(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.x, V.y); }
        public static VectorI3 XXZ(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.x, V.z); }
        public static VectorI3 XX_(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.x, 0); }
        public static VectorI3 XYX(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.y, V.x); }
        public static VectorI3 XYY(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.y, V.y); }
        public static VectorI3 XYZ(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.y, V.z); }
        public static VectorI3 XY_(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.y, 0); }
        public static VectorI3 XZX(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.z, V.x); }
        public static VectorI3 XZY(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.z, V.y); }
        public static VectorI3 XZZ(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.z, V.z); }
        public static VectorI3 XZ_(this VectorI3 V){ return VecOps.MkVectorI3(V.x, V.z, 0); }
        public static VectorI3 X_X(this VectorI3 V){ return VecOps.MkVectorI3(V.x, 0, V.x); }
        public static VectorI3 X_Y(this VectorI3 V){ return VecOps.MkVectorI3(V.x, 0, V.y); }
        public static VectorI3 X_Z(this VectorI3 V){ return VecOps.MkVectorI3(V.x, 0, V.z); }
        public static VectorI3 X__(this VectorI3 V){ return VecOps.MkVectorI3(V.x, 0, 0); }
        public static VectorI3 YXX(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.x, V.x); }
        public static VectorI3 YXY(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.x, V.y); }
        public static VectorI3 YXZ(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.x, V.z); }
        public static VectorI3 YX_(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.x, 0); }
        public static VectorI3 YYX(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.y, V.x); }
        public static VectorI3 YYY(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.y, V.y); }
        public static VectorI3 YYZ(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.y, V.z); }
        public static VectorI3 YY_(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.y, 0); }
        public static VectorI3 YZX(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.z, V.x); }
        public static VectorI3 YZY(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.z, V.y); }
        public static VectorI3 YZZ(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.z, V.z); }
        public static VectorI3 YZ_(this VectorI3 V){ return VecOps.MkVectorI3(V.y, V.z, 0); }
        public static VectorI3 Y_X(this VectorI3 V){ return VecOps.MkVectorI3(V.y, 0, V.x); }
        public static VectorI3 Y_Y(this VectorI3 V){ return VecOps.MkVectorI3(V.y, 0, V.y); }
        public static VectorI3 Y_Z(this VectorI3 V){ return VecOps.MkVectorI3(V.y, 0, V.z); }
        public static VectorI3 Y__(this VectorI3 V){ return VecOps.MkVectorI3(V.y, 0, 0); }
        public static VectorI3 ZXX(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.x, V.x); }
        public static VectorI3 ZXY(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.x, V.y); }
        public static VectorI3 ZXZ(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.x, V.z); }
        public static VectorI3 ZX_(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.x, 0); }
        public static VectorI3 ZYX(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.y, V.x); }
        public static VectorI3 ZYY(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.y, V.y); }
        public static VectorI3 ZYZ(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.y, V.z); }
        public static VectorI3 ZY_(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.y, 0); }
        public static VectorI3 ZZX(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.z, V.x); }
        public static VectorI3 ZZY(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.z, V.y); }
        public static VectorI3 ZZZ(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.z, V.z); }
        public static VectorI3 ZZ_(this VectorI3 V){ return VecOps.MkVectorI3(V.z, V.z, 0); }
        public static VectorI3 Z_X(this VectorI3 V){ return VecOps.MkVectorI3(V.z, 0, V.x); }
        public static VectorI3 Z_Y(this VectorI3 V){ return VecOps.MkVectorI3(V.z, 0, V.y); }
        public static VectorI3 Z_Z(this VectorI3 V){ return VecOps.MkVectorI3(V.z, 0, V.z); }
        public static VectorI3 Z__(this VectorI3 V){ return VecOps.MkVectorI3(V.z, 0, 0); }
        public static VectorI3 _XX(this VectorI3 V){ return VecOps.MkVectorI3(0, V.x, V.x); }
        public static VectorI3 _XY(this VectorI3 V){ return VecOps.MkVectorI3(0, V.x, V.y); }
        public static VectorI3 _XZ(this VectorI3 V){ return VecOps.MkVectorI3(0, V.x, V.z); }
        public static VectorI3 _X_(this VectorI3 V){ return VecOps.MkVectorI3(0, V.x, 0); }
        public static VectorI3 _YX(this VectorI3 V){ return VecOps.MkVectorI3(0, V.y, V.x); }
        public static VectorI3 _YY(this VectorI3 V){ return VecOps.MkVectorI3(0, V.y, V.y); }
        public static VectorI3 _YZ(this VectorI3 V){ return VecOps.MkVectorI3(0, V.y, V.z); }
        public static VectorI3 _Y_(this VectorI3 V){ return VecOps.MkVectorI3(0, V.y, 0); }
        public static VectorI3 _ZX(this VectorI3 V){ return VecOps.MkVectorI3(0, V.z, V.x); }
        public static VectorI3 _ZY(this VectorI3 V){ return VecOps.MkVectorI3(0, V.z, V.y); }
        public static VectorI3 _ZZ(this VectorI3 V){ return VecOps.MkVectorI3(0, V.z, V.z); }
        public static VectorI3 _Z_(this VectorI3 V){ return VecOps.MkVectorI3(0, V.z, 0); }
        public static VectorI3 __X(this VectorI3 V){ return VecOps.MkVectorI3(0, 0, V.x); }
        public static VectorI3 __Y(this VectorI3 V){ return VecOps.MkVectorI3(0, 0, V.y); }
        public static VectorI3 __Z(this VectorI3 V){ return VecOps.MkVectorI3(0, 0, V.z); }
        public static VectorI4 XXXX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.x); }
        public static VectorI4 XXXY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.y); }
        public static VectorI4 XXXZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.z); }
        public static VectorI4 XXX_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, 0); }
        public static VectorI4 XXYX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.x); }
        public static VectorI4 XXYY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.y); }
        public static VectorI4 XXYZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.z); }
        public static VectorI4 XXY_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, 0); }
        public static VectorI4 XXZX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.x); }
        public static VectorI4 XXZY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.y); }
        public static VectorI4 XXZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.z); }
        public static VectorI4 XXZ_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, 0); }
        public static VectorI4 XX_X(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.x); }
        public static VectorI4 XX_Y(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.y); }
        public static VectorI4 XX_Z(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.z); }
        public static VectorI4 XX__(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.x, 0, 0); }
        public static VectorI4 XYXX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.x); }
        public static VectorI4 XYXY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.y); }
        public static VectorI4 XYXZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.z); }
        public static VectorI4 XYX_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, 0); }
        public static VectorI4 XYYX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.x); }
        public static VectorI4 XYYY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.y); }
        public static VectorI4 XYYZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.z); }
        public static VectorI4 XYY_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, 0); }
        public static VectorI4 XYZX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.x); }
        public static VectorI4 XYZY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.y); }
        public static VectorI4 XYZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.z); }
        public static VectorI4 XYZ_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, 0); }
        public static VectorI4 XY_X(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.x); }
        public static VectorI4 XY_Y(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.y); }
        public static VectorI4 XY_Z(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.z); }
        public static VectorI4 XY__(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.y, 0, 0); }
        public static VectorI4 XZXX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.x); }
        public static VectorI4 XZXY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.y); }
        public static VectorI4 XZXZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.z); }
        public static VectorI4 XZX_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, 0); }
        public static VectorI4 XZYX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.x); }
        public static VectorI4 XZYY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.y); }
        public static VectorI4 XZYZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.z); }
        public static VectorI4 XZY_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, 0); }
        public static VectorI4 XZZX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.x); }
        public static VectorI4 XZZY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.y); }
        public static VectorI4 XZZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.z); }
        public static VectorI4 XZZ_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, 0); }
        public static VectorI4 XZ_X(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.x); }
        public static VectorI4 XZ_Y(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.y); }
        public static VectorI4 XZ_Z(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.z); }
        public static VectorI4 XZ__(this VectorI3 V){ return VecOps.MkVectorI4(V.x, V.z, 0, 0); }
        public static VectorI4 X_XX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.x); }
        public static VectorI4 X_XY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.y); }
        public static VectorI4 X_XZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.z); }
        public static VectorI4 X_X_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.x, 0); }
        public static VectorI4 X_YX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.x); }
        public static VectorI4 X_YY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.y); }
        public static VectorI4 X_YZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.z); }
        public static VectorI4 X_Y_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.y, 0); }
        public static VectorI4 X_ZX(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.x); }
        public static VectorI4 X_ZY(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.y); }
        public static VectorI4 X_ZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.z); }
        public static VectorI4 X_Z_(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, V.z, 0); }
        public static VectorI4 X__X(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.x); }
        public static VectorI4 X__Y(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.y); }
        public static VectorI4 X__Z(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.z); }
        public static VectorI4 X___(this VectorI3 V){ return VecOps.MkVectorI4(V.x, 0, 0, 0); }
        public static VectorI4 YXXX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.x); }
        public static VectorI4 YXXY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.y); }
        public static VectorI4 YXXZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.z); }
        public static VectorI4 YXX_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, 0); }
        public static VectorI4 YXYX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.x); }
        public static VectorI4 YXYY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.y); }
        public static VectorI4 YXYZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.z); }
        public static VectorI4 YXY_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, 0); }
        public static VectorI4 YXZX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.x); }
        public static VectorI4 YXZY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.y); }
        public static VectorI4 YXZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.z); }
        public static VectorI4 YXZ_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, 0); }
        public static VectorI4 YX_X(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.x); }
        public static VectorI4 YX_Y(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.y); }
        public static VectorI4 YX_Z(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.z); }
        public static VectorI4 YX__(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.x, 0, 0); }
        public static VectorI4 YYXX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.x); }
        public static VectorI4 YYXY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.y); }
        public static VectorI4 YYXZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.z); }
        public static VectorI4 YYX_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, 0); }
        public static VectorI4 YYYX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.x); }
        public static VectorI4 YYYY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.y); }
        public static VectorI4 YYYZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.z); }
        public static VectorI4 YYY_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, 0); }
        public static VectorI4 YYZX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.x); }
        public static VectorI4 YYZY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.y); }
        public static VectorI4 YYZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.z); }
        public static VectorI4 YYZ_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, 0); }
        public static VectorI4 YY_X(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.x); }
        public static VectorI4 YY_Y(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.y); }
        public static VectorI4 YY_Z(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.z); }
        public static VectorI4 YY__(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.y, 0, 0); }
        public static VectorI4 YZXX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.x); }
        public static VectorI4 YZXY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.y); }
        public static VectorI4 YZXZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.z); }
        public static VectorI4 YZX_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, 0); }
        public static VectorI4 YZYX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.x); }
        public static VectorI4 YZYY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.y); }
        public static VectorI4 YZYZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.z); }
        public static VectorI4 YZY_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, 0); }
        public static VectorI4 YZZX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.x); }
        public static VectorI4 YZZY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.y); }
        public static VectorI4 YZZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.z); }
        public static VectorI4 YZZ_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, 0); }
        public static VectorI4 YZ_X(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.x); }
        public static VectorI4 YZ_Y(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.y); }
        public static VectorI4 YZ_Z(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.z); }
        public static VectorI4 YZ__(this VectorI3 V){ return VecOps.MkVectorI4(V.y, V.z, 0, 0); }
        public static VectorI4 Y_XX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.x); }
        public static VectorI4 Y_XY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.y); }
        public static VectorI4 Y_XZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.z); }
        public static VectorI4 Y_X_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.x, 0); }
        public static VectorI4 Y_YX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.x); }
        public static VectorI4 Y_YY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.y); }
        public static VectorI4 Y_YZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.z); }
        public static VectorI4 Y_Y_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.y, 0); }
        public static VectorI4 Y_ZX(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.x); }
        public static VectorI4 Y_ZY(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.y); }
        public static VectorI4 Y_ZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.z); }
        public static VectorI4 Y_Z_(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, V.z, 0); }
        public static VectorI4 Y__X(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.x); }
        public static VectorI4 Y__Y(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.y); }
        public static VectorI4 Y__Z(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.z); }
        public static VectorI4 Y___(this VectorI3 V){ return VecOps.MkVectorI4(V.y, 0, 0, 0); }
        public static VectorI4 ZXXX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.x); }
        public static VectorI4 ZXXY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.y); }
        public static VectorI4 ZXXZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.z); }
        public static VectorI4 ZXX_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, 0); }
        public static VectorI4 ZXYX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.x); }
        public static VectorI4 ZXYY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.y); }
        public static VectorI4 ZXYZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.z); }
        public static VectorI4 ZXY_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, 0); }
        public static VectorI4 ZXZX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.x); }
        public static VectorI4 ZXZY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.y); }
        public static VectorI4 ZXZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.z); }
        public static VectorI4 ZXZ_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, 0); }
        public static VectorI4 ZX_X(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.x); }
        public static VectorI4 ZX_Y(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.y); }
        public static VectorI4 ZX_Z(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.z); }
        public static VectorI4 ZX__(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.x, 0, 0); }
        public static VectorI4 ZYXX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.x); }
        public static VectorI4 ZYXY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.y); }
        public static VectorI4 ZYXZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.z); }
        public static VectorI4 ZYX_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, 0); }
        public static VectorI4 ZYYX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.x); }
        public static VectorI4 ZYYY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.y); }
        public static VectorI4 ZYYZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.z); }
        public static VectorI4 ZYY_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, 0); }
        public static VectorI4 ZYZX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.x); }
        public static VectorI4 ZYZY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.y); }
        public static VectorI4 ZYZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.z); }
        public static VectorI4 ZYZ_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, 0); }
        public static VectorI4 ZY_X(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.x); }
        public static VectorI4 ZY_Y(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.y); }
        public static VectorI4 ZY_Z(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.z); }
        public static VectorI4 ZY__(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.y, 0, 0); }
        public static VectorI4 ZZXX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.x); }
        public static VectorI4 ZZXY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.y); }
        public static VectorI4 ZZXZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.z); }
        public static VectorI4 ZZX_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, 0); }
        public static VectorI4 ZZYX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.x); }
        public static VectorI4 ZZYY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.y); }
        public static VectorI4 ZZYZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.z); }
        public static VectorI4 ZZY_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, 0); }
        public static VectorI4 ZZZX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.x); }
        public static VectorI4 ZZZY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.y); }
        public static VectorI4 ZZZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.z); }
        public static VectorI4 ZZZ_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, 0); }
        public static VectorI4 ZZ_X(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.x); }
        public static VectorI4 ZZ_Y(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.y); }
        public static VectorI4 ZZ_Z(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.z); }
        public static VectorI4 ZZ__(this VectorI3 V){ return VecOps.MkVectorI4(V.z, V.z, 0, 0); }
        public static VectorI4 Z_XX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.x); }
        public static VectorI4 Z_XY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.y); }
        public static VectorI4 Z_XZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.z); }
        public static VectorI4 Z_X_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.x, 0); }
        public static VectorI4 Z_YX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.x); }
        public static VectorI4 Z_YY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.y); }
        public static VectorI4 Z_YZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.z); }
        public static VectorI4 Z_Y_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.y, 0); }
        public static VectorI4 Z_ZX(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.x); }
        public static VectorI4 Z_ZY(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.y); }
        public static VectorI4 Z_ZZ(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.z); }
        public static VectorI4 Z_Z_(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, V.z, 0); }
        public static VectorI4 Z__X(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.x); }
        public static VectorI4 Z__Y(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.y); }
        public static VectorI4 Z__Z(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.z); }
        public static VectorI4 Z___(this VectorI3 V){ return VecOps.MkVectorI4(V.z, 0, 0, 0); }
        public static VectorI4 _XXX(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.x); }
        public static VectorI4 _XXY(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.y); }
        public static VectorI4 _XXZ(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.z); }
        public static VectorI4 _XX_(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.x, 0); }
        public static VectorI4 _XYX(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.x); }
        public static VectorI4 _XYY(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.y); }
        public static VectorI4 _XYZ(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.z); }
        public static VectorI4 _XY_(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.y, 0); }
        public static VectorI4 _XZX(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.x); }
        public static VectorI4 _XZY(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.y); }
        public static VectorI4 _XZZ(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.z); }
        public static VectorI4 _XZ_(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, V.z, 0); }
        public static VectorI4 _X_X(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, 0, V.x); }
        public static VectorI4 _X_Y(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, 0, V.y); }
        public static VectorI4 _X_Z(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, 0, V.z); }
        public static VectorI4 _X__(this VectorI3 V){ return VecOps.MkVectorI4(0, V.x, 0, 0); }
        public static VectorI4 _YXX(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.x); }
        public static VectorI4 _YXY(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.y); }
        public static VectorI4 _YXZ(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.z); }
        public static VectorI4 _YX_(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.x, 0); }
        public static VectorI4 _YYX(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.x); }
        public static VectorI4 _YYY(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.y); }
        public static VectorI4 _YYZ(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.z); }
        public static VectorI4 _YY_(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.y, 0); }
        public static VectorI4 _YZX(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.x); }
        public static VectorI4 _YZY(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.y); }
        public static VectorI4 _YZZ(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.z); }
        public static VectorI4 _YZ_(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, V.z, 0); }
        public static VectorI4 _Y_X(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, 0, V.x); }
        public static VectorI4 _Y_Y(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, 0, V.y); }
        public static VectorI4 _Y_Z(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, 0, V.z); }
        public static VectorI4 _Y__(this VectorI3 V){ return VecOps.MkVectorI4(0, V.y, 0, 0); }
        public static VectorI4 _ZXX(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.x); }
        public static VectorI4 _ZXY(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.y); }
        public static VectorI4 _ZXZ(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.z); }
        public static VectorI4 _ZX_(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.x, 0); }
        public static VectorI4 _ZYX(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.x); }
        public static VectorI4 _ZYY(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.y); }
        public static VectorI4 _ZYZ(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.z); }
        public static VectorI4 _ZY_(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.y, 0); }
        public static VectorI4 _ZZX(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.x); }
        public static VectorI4 _ZZY(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.y); }
        public static VectorI4 _ZZZ(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.z); }
        public static VectorI4 _ZZ_(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, V.z, 0); }
        public static VectorI4 _Z_X(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, 0, V.x); }
        public static VectorI4 _Z_Y(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, 0, V.y); }
        public static VectorI4 _Z_Z(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, 0, V.z); }
        public static VectorI4 _Z__(this VectorI3 V){ return VecOps.MkVectorI4(0, V.z, 0, 0); }
        public static VectorI4 __XX(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.x, V.x); }
        public static VectorI4 __XY(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.x, V.y); }
        public static VectorI4 __XZ(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.x, V.z); }
        public static VectorI4 __X_(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.x, 0); }
        public static VectorI4 __YX(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.y, V.x); }
        public static VectorI4 __YY(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.y, V.y); }
        public static VectorI4 __YZ(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.y, V.z); }
        public static VectorI4 __Y_(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.y, 0); }
        public static VectorI4 __ZX(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.z, V.x); }
        public static VectorI4 __ZY(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.z, V.y); }
        public static VectorI4 __ZZ(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.z, V.z); }
        public static VectorI4 __Z_(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, V.z, 0); }
        public static VectorI4 ___X(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, 0, V.x); }
        public static VectorI4 ___Y(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, 0, V.y); }
        public static VectorI4 ___Z(this VectorI3 V){ return VecOps.MkVectorI4(0, 0, 0, V.z); }
        public static VectorI2 XX(this VectorI4 V){ return VecOps.MkVectorI2(V.x, V.x); }
        public static VectorI2 XY(this VectorI4 V){ return VecOps.MkVectorI2(V.x, V.y); }
        public static VectorI2 XZ(this VectorI4 V){ return VecOps.MkVectorI2(V.x, V.z); }
        public static VectorI2 XW(this VectorI4 V){ return VecOps.MkVectorI2(V.x, V.w); }
        public static VectorI2 X_(this VectorI4 V){ return VecOps.MkVectorI2(V.x, 0); }
        public static VectorI2 YX(this VectorI4 V){ return VecOps.MkVectorI2(V.y, V.x); }
        public static VectorI2 YY(this VectorI4 V){ return VecOps.MkVectorI2(V.y, V.y); }
        public static VectorI2 YZ(this VectorI4 V){ return VecOps.MkVectorI2(V.y, V.z); }
        public static VectorI2 YW(this VectorI4 V){ return VecOps.MkVectorI2(V.y, V.w); }
        public static VectorI2 Y_(this VectorI4 V){ return VecOps.MkVectorI2(V.y, 0); }
        public static VectorI2 ZX(this VectorI4 V){ return VecOps.MkVectorI2(V.z, V.x); }
        public static VectorI2 ZY(this VectorI4 V){ return VecOps.MkVectorI2(V.z, V.y); }
        public static VectorI2 ZZ(this VectorI4 V){ return VecOps.MkVectorI2(V.z, V.z); }
        public static VectorI2 ZW(this VectorI4 V){ return VecOps.MkVectorI2(V.z, V.w); }
        public static VectorI2 Z_(this VectorI4 V){ return VecOps.MkVectorI2(V.z, 0); }
        public static VectorI2 WX(this VectorI4 V){ return VecOps.MkVectorI2(V.w, V.x); }
        public static VectorI2 WY(this VectorI4 V){ return VecOps.MkVectorI2(V.w, V.y); }
        public static VectorI2 WZ(this VectorI4 V){ return VecOps.MkVectorI2(V.w, V.z); }
        public static VectorI2 WW(this VectorI4 V){ return VecOps.MkVectorI2(V.w, V.w); }
        public static VectorI2 W_(this VectorI4 V){ return VecOps.MkVectorI2(V.w, 0); }
        public static VectorI2 _X(this VectorI4 V){ return VecOps.MkVectorI2(0, V.x); }
        public static VectorI2 _Y(this VectorI4 V){ return VecOps.MkVectorI2(0, V.y); }
        public static VectorI2 _Z(this VectorI4 V){ return VecOps.MkVectorI2(0, V.z); }
        public static VectorI2 _W(this VectorI4 V){ return VecOps.MkVectorI2(0, V.w); }
        public static VectorI3 XXX(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.x, V.x); }
        public static VectorI3 XXY(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.x, V.y); }
        public static VectorI3 XXZ(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.x, V.z); }
        public static VectorI3 XXW(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.x, V.w); }
        public static VectorI3 XX_(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.x, 0); }
        public static VectorI3 XYX(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.y, V.x); }
        public static VectorI3 XYY(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.y, V.y); }
        public static VectorI3 XYZ(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.y, V.z); }
        public static VectorI3 XYW(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.y, V.w); }
        public static VectorI3 XY_(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.y, 0); }
        public static VectorI3 XZX(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.z, V.x); }
        public static VectorI3 XZY(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.z, V.y); }
        public static VectorI3 XZZ(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.z, V.z); }
        public static VectorI3 XZW(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.z, V.w); }
        public static VectorI3 XZ_(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.z, 0); }
        public static VectorI3 XWX(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.w, V.x); }
        public static VectorI3 XWY(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.w, V.y); }
        public static VectorI3 XWZ(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.w, V.z); }
        public static VectorI3 XWW(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.w, V.w); }
        public static VectorI3 XW_(this VectorI4 V){ return VecOps.MkVectorI3(V.x, V.w, 0); }
        public static VectorI3 X_X(this VectorI4 V){ return VecOps.MkVectorI3(V.x, 0, V.x); }
        public static VectorI3 X_Y(this VectorI4 V){ return VecOps.MkVectorI3(V.x, 0, V.y); }
        public static VectorI3 X_Z(this VectorI4 V){ return VecOps.MkVectorI3(V.x, 0, V.z); }
        public static VectorI3 X_W(this VectorI4 V){ return VecOps.MkVectorI3(V.x, 0, V.w); }
        public static VectorI3 X__(this VectorI4 V){ return VecOps.MkVectorI3(V.x, 0, 0); }
        public static VectorI3 YXX(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.x, V.x); }
        public static VectorI3 YXY(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.x, V.y); }
        public static VectorI3 YXZ(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.x, V.z); }
        public static VectorI3 YXW(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.x, V.w); }
        public static VectorI3 YX_(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.x, 0); }
        public static VectorI3 YYX(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.y, V.x); }
        public static VectorI3 YYY(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.y, V.y); }
        public static VectorI3 YYZ(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.y, V.z); }
        public static VectorI3 YYW(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.y, V.w); }
        public static VectorI3 YY_(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.y, 0); }
        public static VectorI3 YZX(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.z, V.x); }
        public static VectorI3 YZY(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.z, V.y); }
        public static VectorI3 YZZ(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.z, V.z); }
        public static VectorI3 YZW(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.z, V.w); }
        public static VectorI3 YZ_(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.z, 0); }
        public static VectorI3 YWX(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.w, V.x); }
        public static VectorI3 YWY(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.w, V.y); }
        public static VectorI3 YWZ(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.w, V.z); }
        public static VectorI3 YWW(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.w, V.w); }
        public static VectorI3 YW_(this VectorI4 V){ return VecOps.MkVectorI3(V.y, V.w, 0); }
        public static VectorI3 Y_X(this VectorI4 V){ return VecOps.MkVectorI3(V.y, 0, V.x); }
        public static VectorI3 Y_Y(this VectorI4 V){ return VecOps.MkVectorI3(V.y, 0, V.y); }
        public static VectorI3 Y_Z(this VectorI4 V){ return VecOps.MkVectorI3(V.y, 0, V.z); }
        public static VectorI3 Y_W(this VectorI4 V){ return VecOps.MkVectorI3(V.y, 0, V.w); }
        public static VectorI3 Y__(this VectorI4 V){ return VecOps.MkVectorI3(V.y, 0, 0); }
        public static VectorI3 ZXX(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.x, V.x); }
        public static VectorI3 ZXY(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.x, V.y); }
        public static VectorI3 ZXZ(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.x, V.z); }
        public static VectorI3 ZXW(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.x, V.w); }
        public static VectorI3 ZX_(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.x, 0); }
        public static VectorI3 ZYX(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.y, V.x); }
        public static VectorI3 ZYY(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.y, V.y); }
        public static VectorI3 ZYZ(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.y, V.z); }
        public static VectorI3 ZYW(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.y, V.w); }
        public static VectorI3 ZY_(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.y, 0); }
        public static VectorI3 ZZX(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.z, V.x); }
        public static VectorI3 ZZY(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.z, V.y); }
        public static VectorI3 ZZZ(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.z, V.z); }
        public static VectorI3 ZZW(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.z, V.w); }
        public static VectorI3 ZZ_(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.z, 0); }
        public static VectorI3 ZWX(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.w, V.x); }
        public static VectorI3 ZWY(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.w, V.y); }
        public static VectorI3 ZWZ(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.w, V.z); }
        public static VectorI3 ZWW(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.w, V.w); }
        public static VectorI3 ZW_(this VectorI4 V){ return VecOps.MkVectorI3(V.z, V.w, 0); }
        public static VectorI3 Z_X(this VectorI4 V){ return VecOps.MkVectorI3(V.z, 0, V.x); }
        public static VectorI3 Z_Y(this VectorI4 V){ return VecOps.MkVectorI3(V.z, 0, V.y); }
        public static VectorI3 Z_Z(this VectorI4 V){ return VecOps.MkVectorI3(V.z, 0, V.z); }
        public static VectorI3 Z_W(this VectorI4 V){ return VecOps.MkVectorI3(V.z, 0, V.w); }
        public static VectorI3 Z__(this VectorI4 V){ return VecOps.MkVectorI3(V.z, 0, 0); }
        public static VectorI3 WXX(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.x, V.x); }
        public static VectorI3 WXY(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.x, V.y); }
        public static VectorI3 WXZ(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.x, V.z); }
        public static VectorI3 WXW(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.x, V.w); }
        public static VectorI3 WX_(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.x, 0); }
        public static VectorI3 WYX(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.y, V.x); }
        public static VectorI3 WYY(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.y, V.y); }
        public static VectorI3 WYZ(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.y, V.z); }
        public static VectorI3 WYW(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.y, V.w); }
        public static VectorI3 WY_(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.y, 0); }
        public static VectorI3 WZX(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.z, V.x); }
        public static VectorI3 WZY(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.z, V.y); }
        public static VectorI3 WZZ(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.z, V.z); }
        public static VectorI3 WZW(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.z, V.w); }
        public static VectorI3 WZ_(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.z, 0); }
        public static VectorI3 WWX(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.w, V.x); }
        public static VectorI3 WWY(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.w, V.y); }
        public static VectorI3 WWZ(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.w, V.z); }
        public static VectorI3 WWW(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.w, V.w); }
        public static VectorI3 WW_(this VectorI4 V){ return VecOps.MkVectorI3(V.w, V.w, 0); }
        public static VectorI3 W_X(this VectorI4 V){ return VecOps.MkVectorI3(V.w, 0, V.x); }
        public static VectorI3 W_Y(this VectorI4 V){ return VecOps.MkVectorI3(V.w, 0, V.y); }
        public static VectorI3 W_Z(this VectorI4 V){ return VecOps.MkVectorI3(V.w, 0, V.z); }
        public static VectorI3 W_W(this VectorI4 V){ return VecOps.MkVectorI3(V.w, 0, V.w); }
        public static VectorI3 W__(this VectorI4 V){ return VecOps.MkVectorI3(V.w, 0, 0); }
        public static VectorI3 _XX(this VectorI4 V){ return VecOps.MkVectorI3(0, V.x, V.x); }
        public static VectorI3 _XY(this VectorI4 V){ return VecOps.MkVectorI3(0, V.x, V.y); }
        public static VectorI3 _XZ(this VectorI4 V){ return VecOps.MkVectorI3(0, V.x, V.z); }
        public static VectorI3 _XW(this VectorI4 V){ return VecOps.MkVectorI3(0, V.x, V.w); }
        public static VectorI3 _X_(this VectorI4 V){ return VecOps.MkVectorI3(0, V.x, 0); }
        public static VectorI3 _YX(this VectorI4 V){ return VecOps.MkVectorI3(0, V.y, V.x); }
        public static VectorI3 _YY(this VectorI4 V){ return VecOps.MkVectorI3(0, V.y, V.y); }
        public static VectorI3 _YZ(this VectorI4 V){ return VecOps.MkVectorI3(0, V.y, V.z); }
        public static VectorI3 _YW(this VectorI4 V){ return VecOps.MkVectorI3(0, V.y, V.w); }
        public static VectorI3 _Y_(this VectorI4 V){ return VecOps.MkVectorI3(0, V.y, 0); }
        public static VectorI3 _ZX(this VectorI4 V){ return VecOps.MkVectorI3(0, V.z, V.x); }
        public static VectorI3 _ZY(this VectorI4 V){ return VecOps.MkVectorI3(0, V.z, V.y); }
        public static VectorI3 _ZZ(this VectorI4 V){ return VecOps.MkVectorI3(0, V.z, V.z); }
        public static VectorI3 _ZW(this VectorI4 V){ return VecOps.MkVectorI3(0, V.z, V.w); }
        public static VectorI3 _Z_(this VectorI4 V){ return VecOps.MkVectorI3(0, V.z, 0); }
        public static VectorI3 _WX(this VectorI4 V){ return VecOps.MkVectorI3(0, V.w, V.x); }
        public static VectorI3 _WY(this VectorI4 V){ return VecOps.MkVectorI3(0, V.w, V.y); }
        public static VectorI3 _WZ(this VectorI4 V){ return VecOps.MkVectorI3(0, V.w, V.z); }
        public static VectorI3 _WW(this VectorI4 V){ return VecOps.MkVectorI3(0, V.w, V.w); }
        public static VectorI3 _W_(this VectorI4 V){ return VecOps.MkVectorI3(0, V.w, 0); }
        public static VectorI3 __X(this VectorI4 V){ return VecOps.MkVectorI3(0, 0, V.x); }
        public static VectorI3 __Y(this VectorI4 V){ return VecOps.MkVectorI3(0, 0, V.y); }
        public static VectorI3 __Z(this VectorI4 V){ return VecOps.MkVectorI3(0, 0, V.z); }
        public static VectorI3 __W(this VectorI4 V){ return VecOps.MkVectorI3(0, 0, V.w); }
        public static VectorI4 XXXX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.x); }
        public static VectorI4 XXXY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.y); }
        public static VectorI4 XXXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.z); }
        public static VectorI4 XXXW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, V.w); }
        public static VectorI4 XXX_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.x, 0); }
        public static VectorI4 XXYX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.x); }
        public static VectorI4 XXYY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.y); }
        public static VectorI4 XXYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.z); }
        public static VectorI4 XXYW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, V.w); }
        public static VectorI4 XXY_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.y, 0); }
        public static VectorI4 XXZX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.x); }
        public static VectorI4 XXZY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.y); }
        public static VectorI4 XXZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.z); }
        public static VectorI4 XXZW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, V.w); }
        public static VectorI4 XXZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.z, 0); }
        public static VectorI4 XXWX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.w, V.x); }
        public static VectorI4 XXWY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.w, V.y); }
        public static VectorI4 XXWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.w, V.z); }
        public static VectorI4 XXWW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.w, V.w); }
        public static VectorI4 XXW_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, V.w, 0); }
        public static VectorI4 XX_X(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.x); }
        public static VectorI4 XX_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.y); }
        public static VectorI4 XX_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.z); }
        public static VectorI4 XX_W(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, 0, V.w); }
        public static VectorI4 XX__(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.x, 0, 0); }
        public static VectorI4 XYXX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.x); }
        public static VectorI4 XYXY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.y); }
        public static VectorI4 XYXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.z); }
        public static VectorI4 XYXW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, V.w); }
        public static VectorI4 XYX_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.x, 0); }
        public static VectorI4 XYYX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.x); }
        public static VectorI4 XYYY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.y); }
        public static VectorI4 XYYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.z); }
        public static VectorI4 XYYW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, V.w); }
        public static VectorI4 XYY_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.y, 0); }
        public static VectorI4 XYZX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.x); }
        public static VectorI4 XYZY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.y); }
        public static VectorI4 XYZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.z); }
        public static VectorI4 XYZW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, V.w); }
        public static VectorI4 XYZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.z, 0); }
        public static VectorI4 XYWX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.w, V.x); }
        public static VectorI4 XYWY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.w, V.y); }
        public static VectorI4 XYWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.w, V.z); }
        public static VectorI4 XYWW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.w, V.w); }
        public static VectorI4 XYW_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, V.w, 0); }
        public static VectorI4 XY_X(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.x); }
        public static VectorI4 XY_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.y); }
        public static VectorI4 XY_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.z); }
        public static VectorI4 XY_W(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, 0, V.w); }
        public static VectorI4 XY__(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.y, 0, 0); }
        public static VectorI4 XZXX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.x); }
        public static VectorI4 XZXY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.y); }
        public static VectorI4 XZXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.z); }
        public static VectorI4 XZXW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, V.w); }
        public static VectorI4 XZX_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.x, 0); }
        public static VectorI4 XZYX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.x); }
        public static VectorI4 XZYY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.y); }
        public static VectorI4 XZYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.z); }
        public static VectorI4 XZYW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, V.w); }
        public static VectorI4 XZY_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.y, 0); }
        public static VectorI4 XZZX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.x); }
        public static VectorI4 XZZY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.y); }
        public static VectorI4 XZZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.z); }
        public static VectorI4 XZZW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, V.w); }
        public static VectorI4 XZZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.z, 0); }
        public static VectorI4 XZWX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.w, V.x); }
        public static VectorI4 XZWY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.w, V.y); }
        public static VectorI4 XZWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.w, V.z); }
        public static VectorI4 XZWW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.w, V.w); }
        public static VectorI4 XZW_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, V.w, 0); }
        public static VectorI4 XZ_X(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.x); }
        public static VectorI4 XZ_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.y); }
        public static VectorI4 XZ_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.z); }
        public static VectorI4 XZ_W(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, 0, V.w); }
        public static VectorI4 XZ__(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.z, 0, 0); }
        public static VectorI4 XWXX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.x, V.x); }
        public static VectorI4 XWXY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.x, V.y); }
        public static VectorI4 XWXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.x, V.z); }
        public static VectorI4 XWXW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.x, V.w); }
        public static VectorI4 XWX_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.x, 0); }
        public static VectorI4 XWYX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.y, V.x); }
        public static VectorI4 XWYY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.y, V.y); }
        public static VectorI4 XWYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.y, V.z); }
        public static VectorI4 XWYW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.y, V.w); }
        public static VectorI4 XWY_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.y, 0); }
        public static VectorI4 XWZX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.z, V.x); }
        public static VectorI4 XWZY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.z, V.y); }
        public static VectorI4 XWZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.z, V.z); }
        public static VectorI4 XWZW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.z, V.w); }
        public static VectorI4 XWZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.z, 0); }
        public static VectorI4 XWWX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.w, V.x); }
        public static VectorI4 XWWY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.w, V.y); }
        public static VectorI4 XWWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.w, V.z); }
        public static VectorI4 XWWW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.w, V.w); }
        public static VectorI4 XWW_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, V.w, 0); }
        public static VectorI4 XW_X(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, 0, V.x); }
        public static VectorI4 XW_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, 0, V.y); }
        public static VectorI4 XW_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, 0, V.z); }
        public static VectorI4 XW_W(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, 0, V.w); }
        public static VectorI4 XW__(this VectorI4 V){ return VecOps.MkVectorI4(V.x, V.w, 0, 0); }
        public static VectorI4 X_XX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.x); }
        public static VectorI4 X_XY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.y); }
        public static VectorI4 X_XZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.z); }
        public static VectorI4 X_XW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.x, V.w); }
        public static VectorI4 X_X_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.x, 0); }
        public static VectorI4 X_YX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.x); }
        public static VectorI4 X_YY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.y); }
        public static VectorI4 X_YZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.z); }
        public static VectorI4 X_YW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.y, V.w); }
        public static VectorI4 X_Y_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.y, 0); }
        public static VectorI4 X_ZX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.x); }
        public static VectorI4 X_ZY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.y); }
        public static VectorI4 X_ZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.z); }
        public static VectorI4 X_ZW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.z, V.w); }
        public static VectorI4 X_Z_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.z, 0); }
        public static VectorI4 X_WX(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.w, V.x); }
        public static VectorI4 X_WY(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.w, V.y); }
        public static VectorI4 X_WZ(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.w, V.z); }
        public static VectorI4 X_WW(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.w, V.w); }
        public static VectorI4 X_W_(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, V.w, 0); }
        public static VectorI4 X__X(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.x); }
        public static VectorI4 X__Y(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.y); }
        public static VectorI4 X__Z(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.z); }
        public static VectorI4 X__W(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, 0, V.w); }
        public static VectorI4 X___(this VectorI4 V){ return VecOps.MkVectorI4(V.x, 0, 0, 0); }
        public static VectorI4 YXXX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.x); }
        public static VectorI4 YXXY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.y); }
        public static VectorI4 YXXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.z); }
        public static VectorI4 YXXW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, V.w); }
        public static VectorI4 YXX_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.x, 0); }
        public static VectorI4 YXYX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.x); }
        public static VectorI4 YXYY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.y); }
        public static VectorI4 YXYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.z); }
        public static VectorI4 YXYW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, V.w); }
        public static VectorI4 YXY_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.y, 0); }
        public static VectorI4 YXZX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.x); }
        public static VectorI4 YXZY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.y); }
        public static VectorI4 YXZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.z); }
        public static VectorI4 YXZW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, V.w); }
        public static VectorI4 YXZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.z, 0); }
        public static VectorI4 YXWX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.w, V.x); }
        public static VectorI4 YXWY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.w, V.y); }
        public static VectorI4 YXWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.w, V.z); }
        public static VectorI4 YXWW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.w, V.w); }
        public static VectorI4 YXW_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, V.w, 0); }
        public static VectorI4 YX_X(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.x); }
        public static VectorI4 YX_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.y); }
        public static VectorI4 YX_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.z); }
        public static VectorI4 YX_W(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, 0, V.w); }
        public static VectorI4 YX__(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.x, 0, 0); }
        public static VectorI4 YYXX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.x); }
        public static VectorI4 YYXY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.y); }
        public static VectorI4 YYXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.z); }
        public static VectorI4 YYXW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, V.w); }
        public static VectorI4 YYX_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.x, 0); }
        public static VectorI4 YYYX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.x); }
        public static VectorI4 YYYY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.y); }
        public static VectorI4 YYYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.z); }
        public static VectorI4 YYYW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, V.w); }
        public static VectorI4 YYY_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.y, 0); }
        public static VectorI4 YYZX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.x); }
        public static VectorI4 YYZY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.y); }
        public static VectorI4 YYZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.z); }
        public static VectorI4 YYZW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, V.w); }
        public static VectorI4 YYZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.z, 0); }
        public static VectorI4 YYWX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.w, V.x); }
        public static VectorI4 YYWY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.w, V.y); }
        public static VectorI4 YYWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.w, V.z); }
        public static VectorI4 YYWW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.w, V.w); }
        public static VectorI4 YYW_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, V.w, 0); }
        public static VectorI4 YY_X(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.x); }
        public static VectorI4 YY_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.y); }
        public static VectorI4 YY_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.z); }
        public static VectorI4 YY_W(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, 0, V.w); }
        public static VectorI4 YY__(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.y, 0, 0); }
        public static VectorI4 YZXX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.x); }
        public static VectorI4 YZXY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.y); }
        public static VectorI4 YZXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.z); }
        public static VectorI4 YZXW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, V.w); }
        public static VectorI4 YZX_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.x, 0); }
        public static VectorI4 YZYX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.x); }
        public static VectorI4 YZYY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.y); }
        public static VectorI4 YZYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.z); }
        public static VectorI4 YZYW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, V.w); }
        public static VectorI4 YZY_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.y, 0); }
        public static VectorI4 YZZX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.x); }
        public static VectorI4 YZZY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.y); }
        public static VectorI4 YZZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.z); }
        public static VectorI4 YZZW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, V.w); }
        public static VectorI4 YZZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.z, 0); }
        public static VectorI4 YZWX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.w, V.x); }
        public static VectorI4 YZWY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.w, V.y); }
        public static VectorI4 YZWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.w, V.z); }
        public static VectorI4 YZWW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.w, V.w); }
        public static VectorI4 YZW_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, V.w, 0); }
        public static VectorI4 YZ_X(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.x); }
        public static VectorI4 YZ_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.y); }
        public static VectorI4 YZ_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.z); }
        public static VectorI4 YZ_W(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, 0, V.w); }
        public static VectorI4 YZ__(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.z, 0, 0); }
        public static VectorI4 YWXX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.x, V.x); }
        public static VectorI4 YWXY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.x, V.y); }
        public static VectorI4 YWXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.x, V.z); }
        public static VectorI4 YWXW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.x, V.w); }
        public static VectorI4 YWX_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.x, 0); }
        public static VectorI4 YWYX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.y, V.x); }
        public static VectorI4 YWYY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.y, V.y); }
        public static VectorI4 YWYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.y, V.z); }
        public static VectorI4 YWYW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.y, V.w); }
        public static VectorI4 YWY_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.y, 0); }
        public static VectorI4 YWZX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.z, V.x); }
        public static VectorI4 YWZY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.z, V.y); }
        public static VectorI4 YWZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.z, V.z); }
        public static VectorI4 YWZW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.z, V.w); }
        public static VectorI4 YWZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.z, 0); }
        public static VectorI4 YWWX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.w, V.x); }
        public static VectorI4 YWWY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.w, V.y); }
        public static VectorI4 YWWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.w, V.z); }
        public static VectorI4 YWWW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.w, V.w); }
        public static VectorI4 YWW_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, V.w, 0); }
        public static VectorI4 YW_X(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, 0, V.x); }
        public static VectorI4 YW_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, 0, V.y); }
        public static VectorI4 YW_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, 0, V.z); }
        public static VectorI4 YW_W(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, 0, V.w); }
        public static VectorI4 YW__(this VectorI4 V){ return VecOps.MkVectorI4(V.y, V.w, 0, 0); }
        public static VectorI4 Y_XX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.x); }
        public static VectorI4 Y_XY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.y); }
        public static VectorI4 Y_XZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.z); }
        public static VectorI4 Y_XW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.x, V.w); }
        public static VectorI4 Y_X_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.x, 0); }
        public static VectorI4 Y_YX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.x); }
        public static VectorI4 Y_YY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.y); }
        public static VectorI4 Y_YZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.z); }
        public static VectorI4 Y_YW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.y, V.w); }
        public static VectorI4 Y_Y_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.y, 0); }
        public static VectorI4 Y_ZX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.x); }
        public static VectorI4 Y_ZY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.y); }
        public static VectorI4 Y_ZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.z); }
        public static VectorI4 Y_ZW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.z, V.w); }
        public static VectorI4 Y_Z_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.z, 0); }
        public static VectorI4 Y_WX(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.w, V.x); }
        public static VectorI4 Y_WY(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.w, V.y); }
        public static VectorI4 Y_WZ(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.w, V.z); }
        public static VectorI4 Y_WW(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.w, V.w); }
        public static VectorI4 Y_W_(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, V.w, 0); }
        public static VectorI4 Y__X(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.x); }
        public static VectorI4 Y__Y(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.y); }
        public static VectorI4 Y__Z(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.z); }
        public static VectorI4 Y__W(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, 0, V.w); }
        public static VectorI4 Y___(this VectorI4 V){ return VecOps.MkVectorI4(V.y, 0, 0, 0); }
        public static VectorI4 ZXXX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.x); }
        public static VectorI4 ZXXY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.y); }
        public static VectorI4 ZXXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.z); }
        public static VectorI4 ZXXW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, V.w); }
        public static VectorI4 ZXX_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.x, 0); }
        public static VectorI4 ZXYX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.x); }
        public static VectorI4 ZXYY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.y); }
        public static VectorI4 ZXYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.z); }
        public static VectorI4 ZXYW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, V.w); }
        public static VectorI4 ZXY_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.y, 0); }
        public static VectorI4 ZXZX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.x); }
        public static VectorI4 ZXZY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.y); }
        public static VectorI4 ZXZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.z); }
        public static VectorI4 ZXZW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, V.w); }
        public static VectorI4 ZXZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.z, 0); }
        public static VectorI4 ZXWX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.w, V.x); }
        public static VectorI4 ZXWY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.w, V.y); }
        public static VectorI4 ZXWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.w, V.z); }
        public static VectorI4 ZXWW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.w, V.w); }
        public static VectorI4 ZXW_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, V.w, 0); }
        public static VectorI4 ZX_X(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.x); }
        public static VectorI4 ZX_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.y); }
        public static VectorI4 ZX_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.z); }
        public static VectorI4 ZX_W(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, 0, V.w); }
        public static VectorI4 ZX__(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.x, 0, 0); }
        public static VectorI4 ZYXX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.x); }
        public static VectorI4 ZYXY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.y); }
        public static VectorI4 ZYXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.z); }
        public static VectorI4 ZYXW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, V.w); }
        public static VectorI4 ZYX_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.x, 0); }
        public static VectorI4 ZYYX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.x); }
        public static VectorI4 ZYYY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.y); }
        public static VectorI4 ZYYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.z); }
        public static VectorI4 ZYYW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, V.w); }
        public static VectorI4 ZYY_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.y, 0); }
        public static VectorI4 ZYZX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.x); }
        public static VectorI4 ZYZY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.y); }
        public static VectorI4 ZYZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.z); }
        public static VectorI4 ZYZW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, V.w); }
        public static VectorI4 ZYZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.z, 0); }
        public static VectorI4 ZYWX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.w, V.x); }
        public static VectorI4 ZYWY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.w, V.y); }
        public static VectorI4 ZYWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.w, V.z); }
        public static VectorI4 ZYWW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.w, V.w); }
        public static VectorI4 ZYW_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, V.w, 0); }
        public static VectorI4 ZY_X(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.x); }
        public static VectorI4 ZY_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.y); }
        public static VectorI4 ZY_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.z); }
        public static VectorI4 ZY_W(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, 0, V.w); }
        public static VectorI4 ZY__(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.y, 0, 0); }
        public static VectorI4 ZZXX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.x); }
        public static VectorI4 ZZXY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.y); }
        public static VectorI4 ZZXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.z); }
        public static VectorI4 ZZXW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, V.w); }
        public static VectorI4 ZZX_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.x, 0); }
        public static VectorI4 ZZYX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.x); }
        public static VectorI4 ZZYY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.y); }
        public static VectorI4 ZZYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.z); }
        public static VectorI4 ZZYW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, V.w); }
        public static VectorI4 ZZY_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.y, 0); }
        public static VectorI4 ZZZX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.x); }
        public static VectorI4 ZZZY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.y); }
        public static VectorI4 ZZZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.z); }
        public static VectorI4 ZZZW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, V.w); }
        public static VectorI4 ZZZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.z, 0); }
        public static VectorI4 ZZWX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.w, V.x); }
        public static VectorI4 ZZWY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.w, V.y); }
        public static VectorI4 ZZWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.w, V.z); }
        public static VectorI4 ZZWW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.w, V.w); }
        public static VectorI4 ZZW_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, V.w, 0); }
        public static VectorI4 ZZ_X(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.x); }
        public static VectorI4 ZZ_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.y); }
        public static VectorI4 ZZ_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.z); }
        public static VectorI4 ZZ_W(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, 0, V.w); }
        public static VectorI4 ZZ__(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.z, 0, 0); }
        public static VectorI4 ZWXX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.x, V.x); }
        public static VectorI4 ZWXY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.x, V.y); }
        public static VectorI4 ZWXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.x, V.z); }
        public static VectorI4 ZWXW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.x, V.w); }
        public static VectorI4 ZWX_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.x, 0); }
        public static VectorI4 ZWYX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.y, V.x); }
        public static VectorI4 ZWYY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.y, V.y); }
        public static VectorI4 ZWYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.y, V.z); }
        public static VectorI4 ZWYW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.y, V.w); }
        public static VectorI4 ZWY_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.y, 0); }
        public static VectorI4 ZWZX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.z, V.x); }
        public static VectorI4 ZWZY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.z, V.y); }
        public static VectorI4 ZWZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.z, V.z); }
        public static VectorI4 ZWZW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.z, V.w); }
        public static VectorI4 ZWZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.z, 0); }
        public static VectorI4 ZWWX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.w, V.x); }
        public static VectorI4 ZWWY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.w, V.y); }
        public static VectorI4 ZWWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.w, V.z); }
        public static VectorI4 ZWWW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.w, V.w); }
        public static VectorI4 ZWW_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, V.w, 0); }
        public static VectorI4 ZW_X(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, 0, V.x); }
        public static VectorI4 ZW_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, 0, V.y); }
        public static VectorI4 ZW_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, 0, V.z); }
        public static VectorI4 ZW_W(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, 0, V.w); }
        public static VectorI4 ZW__(this VectorI4 V){ return VecOps.MkVectorI4(V.z, V.w, 0, 0); }
        public static VectorI4 Z_XX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.x); }
        public static VectorI4 Z_XY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.y); }
        public static VectorI4 Z_XZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.z); }
        public static VectorI4 Z_XW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.x, V.w); }
        public static VectorI4 Z_X_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.x, 0); }
        public static VectorI4 Z_YX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.x); }
        public static VectorI4 Z_YY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.y); }
        public static VectorI4 Z_YZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.z); }
        public static VectorI4 Z_YW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.y, V.w); }
        public static VectorI4 Z_Y_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.y, 0); }
        public static VectorI4 Z_ZX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.x); }
        public static VectorI4 Z_ZY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.y); }
        public static VectorI4 Z_ZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.z); }
        public static VectorI4 Z_ZW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.z, V.w); }
        public static VectorI4 Z_Z_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.z, 0); }
        public static VectorI4 Z_WX(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.w, V.x); }
        public static VectorI4 Z_WY(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.w, V.y); }
        public static VectorI4 Z_WZ(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.w, V.z); }
        public static VectorI4 Z_WW(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.w, V.w); }
        public static VectorI4 Z_W_(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, V.w, 0); }
        public static VectorI4 Z__X(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.x); }
        public static VectorI4 Z__Y(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.y); }
        public static VectorI4 Z__Z(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.z); }
        public static VectorI4 Z__W(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, 0, V.w); }
        public static VectorI4 Z___(this VectorI4 V){ return VecOps.MkVectorI4(V.z, 0, 0, 0); }
        public static VectorI4 WXXX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.x, V.x); }
        public static VectorI4 WXXY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.x, V.y); }
        public static VectorI4 WXXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.x, V.z); }
        public static VectorI4 WXXW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.x, V.w); }
        public static VectorI4 WXX_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.x, 0); }
        public static VectorI4 WXYX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.y, V.x); }
        public static VectorI4 WXYY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.y, V.y); }
        public static VectorI4 WXYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.y, V.z); }
        public static VectorI4 WXYW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.y, V.w); }
        public static VectorI4 WXY_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.y, 0); }
        public static VectorI4 WXZX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.z, V.x); }
        public static VectorI4 WXZY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.z, V.y); }
        public static VectorI4 WXZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.z, V.z); }
        public static VectorI4 WXZW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.z, V.w); }
        public static VectorI4 WXZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.z, 0); }
        public static VectorI4 WXWX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.w, V.x); }
        public static VectorI4 WXWY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.w, V.y); }
        public static VectorI4 WXWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.w, V.z); }
        public static VectorI4 WXWW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.w, V.w); }
        public static VectorI4 WXW_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, V.w, 0); }
        public static VectorI4 WX_X(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, 0, V.x); }
        public static VectorI4 WX_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, 0, V.y); }
        public static VectorI4 WX_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, 0, V.z); }
        public static VectorI4 WX_W(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, 0, V.w); }
        public static VectorI4 WX__(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.x, 0, 0); }
        public static VectorI4 WYXX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.x, V.x); }
        public static VectorI4 WYXY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.x, V.y); }
        public static VectorI4 WYXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.x, V.z); }
        public static VectorI4 WYXW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.x, V.w); }
        public static VectorI4 WYX_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.x, 0); }
        public static VectorI4 WYYX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.y, V.x); }
        public static VectorI4 WYYY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.y, V.y); }
        public static VectorI4 WYYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.y, V.z); }
        public static VectorI4 WYYW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.y, V.w); }
        public static VectorI4 WYY_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.y, 0); }
        public static VectorI4 WYZX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.z, V.x); }
        public static VectorI4 WYZY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.z, V.y); }
        public static VectorI4 WYZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.z, V.z); }
        public static VectorI4 WYZW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.z, V.w); }
        public static VectorI4 WYZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.z, 0); }
        public static VectorI4 WYWX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.w, V.x); }
        public static VectorI4 WYWY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.w, V.y); }
        public static VectorI4 WYWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.w, V.z); }
        public static VectorI4 WYWW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.w, V.w); }
        public static VectorI4 WYW_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, V.w, 0); }
        public static VectorI4 WY_X(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, 0, V.x); }
        public static VectorI4 WY_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, 0, V.y); }
        public static VectorI4 WY_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, 0, V.z); }
        public static VectorI4 WY_W(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, 0, V.w); }
        public static VectorI4 WY__(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.y, 0, 0); }
        public static VectorI4 WZXX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.x, V.x); }
        public static VectorI4 WZXY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.x, V.y); }
        public static VectorI4 WZXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.x, V.z); }
        public static VectorI4 WZXW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.x, V.w); }
        public static VectorI4 WZX_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.x, 0); }
        public static VectorI4 WZYX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.y, V.x); }
        public static VectorI4 WZYY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.y, V.y); }
        public static VectorI4 WZYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.y, V.z); }
        public static VectorI4 WZYW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.y, V.w); }
        public static VectorI4 WZY_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.y, 0); }
        public static VectorI4 WZZX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.z, V.x); }
        public static VectorI4 WZZY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.z, V.y); }
        public static VectorI4 WZZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.z, V.z); }
        public static VectorI4 WZZW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.z, V.w); }
        public static VectorI4 WZZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.z, 0); }
        public static VectorI4 WZWX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.w, V.x); }
        public static VectorI4 WZWY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.w, V.y); }
        public static VectorI4 WZWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.w, V.z); }
        public static VectorI4 WZWW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.w, V.w); }
        public static VectorI4 WZW_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, V.w, 0); }
        public static VectorI4 WZ_X(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, 0, V.x); }
        public static VectorI4 WZ_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, 0, V.y); }
        public static VectorI4 WZ_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, 0, V.z); }
        public static VectorI4 WZ_W(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, 0, V.w); }
        public static VectorI4 WZ__(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.z, 0, 0); }
        public static VectorI4 WWXX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.x, V.x); }
        public static VectorI4 WWXY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.x, V.y); }
        public static VectorI4 WWXZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.x, V.z); }
        public static VectorI4 WWXW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.x, V.w); }
        public static VectorI4 WWX_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.x, 0); }
        public static VectorI4 WWYX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.y, V.x); }
        public static VectorI4 WWYY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.y, V.y); }
        public static VectorI4 WWYZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.y, V.z); }
        public static VectorI4 WWYW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.y, V.w); }
        public static VectorI4 WWY_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.y, 0); }
        public static VectorI4 WWZX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.z, V.x); }
        public static VectorI4 WWZY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.z, V.y); }
        public static VectorI4 WWZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.z, V.z); }
        public static VectorI4 WWZW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.z, V.w); }
        public static VectorI4 WWZ_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.z, 0); }
        public static VectorI4 WWWX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.w, V.x); }
        public static VectorI4 WWWY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.w, V.y); }
        public static VectorI4 WWWZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.w, V.z); }
        public static VectorI4 WWWW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.w, V.w); }
        public static VectorI4 WWW_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, V.w, 0); }
        public static VectorI4 WW_X(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, 0, V.x); }
        public static VectorI4 WW_Y(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, 0, V.y); }
        public static VectorI4 WW_Z(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, 0, V.z); }
        public static VectorI4 WW_W(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, 0, V.w); }
        public static VectorI4 WW__(this VectorI4 V){ return VecOps.MkVectorI4(V.w, V.w, 0, 0); }
        public static VectorI4 W_XX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.x, V.x); }
        public static VectorI4 W_XY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.x, V.y); }
        public static VectorI4 W_XZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.x, V.z); }
        public static VectorI4 W_XW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.x, V.w); }
        public static VectorI4 W_X_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.x, 0); }
        public static VectorI4 W_YX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.y, V.x); }
        public static VectorI4 W_YY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.y, V.y); }
        public static VectorI4 W_YZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.y, V.z); }
        public static VectorI4 W_YW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.y, V.w); }
        public static VectorI4 W_Y_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.y, 0); }
        public static VectorI4 W_ZX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.z, V.x); }
        public static VectorI4 W_ZY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.z, V.y); }
        public static VectorI4 W_ZZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.z, V.z); }
        public static VectorI4 W_ZW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.z, V.w); }
        public static VectorI4 W_Z_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.z, 0); }
        public static VectorI4 W_WX(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.w, V.x); }
        public static VectorI4 W_WY(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.w, V.y); }
        public static VectorI4 W_WZ(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.w, V.z); }
        public static VectorI4 W_WW(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.w, V.w); }
        public static VectorI4 W_W_(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, V.w, 0); }
        public static VectorI4 W__X(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, 0, V.x); }
        public static VectorI4 W__Y(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, 0, V.y); }
        public static VectorI4 W__Z(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, 0, V.z); }
        public static VectorI4 W__W(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, 0, V.w); }
        public static VectorI4 W___(this VectorI4 V){ return VecOps.MkVectorI4(V.w, 0, 0, 0); }
        public static VectorI4 _XXX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.x); }
        public static VectorI4 _XXY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.y); }
        public static VectorI4 _XXZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.z); }
        public static VectorI4 _XXW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.x, V.w); }
        public static VectorI4 _XX_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.x, 0); }
        public static VectorI4 _XYX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.x); }
        public static VectorI4 _XYY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.y); }
        public static VectorI4 _XYZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.z); }
        public static VectorI4 _XYW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.y, V.w); }
        public static VectorI4 _XY_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.y, 0); }
        public static VectorI4 _XZX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.x); }
        public static VectorI4 _XZY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.y); }
        public static VectorI4 _XZZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.z); }
        public static VectorI4 _XZW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.z, V.w); }
        public static VectorI4 _XZ_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.z, 0); }
        public static VectorI4 _XWX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.w, V.x); }
        public static VectorI4 _XWY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.w, V.y); }
        public static VectorI4 _XWZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.w, V.z); }
        public static VectorI4 _XWW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.w, V.w); }
        public static VectorI4 _XW_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, V.w, 0); }
        public static VectorI4 _X_X(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, 0, V.x); }
        public static VectorI4 _X_Y(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, 0, V.y); }
        public static VectorI4 _X_Z(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, 0, V.z); }
        public static VectorI4 _X_W(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, 0, V.w); }
        public static VectorI4 _X__(this VectorI4 V){ return VecOps.MkVectorI4(0, V.x, 0, 0); }
        public static VectorI4 _YXX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.x); }
        public static VectorI4 _YXY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.y); }
        public static VectorI4 _YXZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.z); }
        public static VectorI4 _YXW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.x, V.w); }
        public static VectorI4 _YX_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.x, 0); }
        public static VectorI4 _YYX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.x); }
        public static VectorI4 _YYY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.y); }
        public static VectorI4 _YYZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.z); }
        public static VectorI4 _YYW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.y, V.w); }
        public static VectorI4 _YY_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.y, 0); }
        public static VectorI4 _YZX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.x); }
        public static VectorI4 _YZY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.y); }
        public static VectorI4 _YZZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.z); }
        public static VectorI4 _YZW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.z, V.w); }
        public static VectorI4 _YZ_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.z, 0); }
        public static VectorI4 _YWX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.w, V.x); }
        public static VectorI4 _YWY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.w, V.y); }
        public static VectorI4 _YWZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.w, V.z); }
        public static VectorI4 _YWW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.w, V.w); }
        public static VectorI4 _YW_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, V.w, 0); }
        public static VectorI4 _Y_X(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, 0, V.x); }
        public static VectorI4 _Y_Y(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, 0, V.y); }
        public static VectorI4 _Y_Z(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, 0, V.z); }
        public static VectorI4 _Y_W(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, 0, V.w); }
        public static VectorI4 _Y__(this VectorI4 V){ return VecOps.MkVectorI4(0, V.y, 0, 0); }
        public static VectorI4 _ZXX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.x); }
        public static VectorI4 _ZXY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.y); }
        public static VectorI4 _ZXZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.z); }
        public static VectorI4 _ZXW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.x, V.w); }
        public static VectorI4 _ZX_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.x, 0); }
        public static VectorI4 _ZYX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.x); }
        public static VectorI4 _ZYY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.y); }
        public static VectorI4 _ZYZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.z); }
        public static VectorI4 _ZYW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.y, V.w); }
        public static VectorI4 _ZY_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.y, 0); }
        public static VectorI4 _ZZX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.x); }
        public static VectorI4 _ZZY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.y); }
        public static VectorI4 _ZZZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.z); }
        public static VectorI4 _ZZW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.z, V.w); }
        public static VectorI4 _ZZ_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.z, 0); }
        public static VectorI4 _ZWX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.w, V.x); }
        public static VectorI4 _ZWY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.w, V.y); }
        public static VectorI4 _ZWZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.w, V.z); }
        public static VectorI4 _ZWW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.w, V.w); }
        public static VectorI4 _ZW_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, V.w, 0); }
        public static VectorI4 _Z_X(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, 0, V.x); }
        public static VectorI4 _Z_Y(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, 0, V.y); }
        public static VectorI4 _Z_Z(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, 0, V.z); }
        public static VectorI4 _Z_W(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, 0, V.w); }
        public static VectorI4 _Z__(this VectorI4 V){ return VecOps.MkVectorI4(0, V.z, 0, 0); }
        public static VectorI4 _WXX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.x, V.x); }
        public static VectorI4 _WXY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.x, V.y); }
        public static VectorI4 _WXZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.x, V.z); }
        public static VectorI4 _WXW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.x, V.w); }
        public static VectorI4 _WX_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.x, 0); }
        public static VectorI4 _WYX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.y, V.x); }
        public static VectorI4 _WYY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.y, V.y); }
        public static VectorI4 _WYZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.y, V.z); }
        public static VectorI4 _WYW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.y, V.w); }
        public static VectorI4 _WY_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.y, 0); }
        public static VectorI4 _WZX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.z, V.x); }
        public static VectorI4 _WZY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.z, V.y); }
        public static VectorI4 _WZZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.z, V.z); }
        public static VectorI4 _WZW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.z, V.w); }
        public static VectorI4 _WZ_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.z, 0); }
        public static VectorI4 _WWX(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.w, V.x); }
        public static VectorI4 _WWY(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.w, V.y); }
        public static VectorI4 _WWZ(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.w, V.z); }
        public static VectorI4 _WWW(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.w, V.w); }
        public static VectorI4 _WW_(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, V.w, 0); }
        public static VectorI4 _W_X(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, 0, V.x); }
        public static VectorI4 _W_Y(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, 0, V.y); }
        public static VectorI4 _W_Z(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, 0, V.z); }
        public static VectorI4 _W_W(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, 0, V.w); }
        public static VectorI4 _W__(this VectorI4 V){ return VecOps.MkVectorI4(0, V.w, 0, 0); }
        public static VectorI4 __XX(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.x, V.x); }
        public static VectorI4 __XY(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.x, V.y); }
        public static VectorI4 __XZ(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.x, V.z); }
        public static VectorI4 __XW(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.x, V.w); }
        public static VectorI4 __X_(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.x, 0); }
        public static VectorI4 __YX(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.y, V.x); }
        public static VectorI4 __YY(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.y, V.y); }
        public static VectorI4 __YZ(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.y, V.z); }
        public static VectorI4 __YW(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.y, V.w); }
        public static VectorI4 __Y_(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.y, 0); }
        public static VectorI4 __ZX(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.z, V.x); }
        public static VectorI4 __ZY(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.z, V.y); }
        public static VectorI4 __ZZ(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.z, V.z); }
        public static VectorI4 __ZW(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.z, V.w); }
        public static VectorI4 __Z_(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.z, 0); }
        public static VectorI4 __WX(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.w, V.x); }
        public static VectorI4 __WY(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.w, V.y); }
        public static VectorI4 __WZ(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.w, V.z); }
        public static VectorI4 __WW(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.w, V.w); }
        public static VectorI4 __W_(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, V.w, 0); }
        public static VectorI4 ___X(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, 0, V.x); }
        public static VectorI4 ___Y(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, 0, V.y); }
        public static VectorI4 ___Z(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, 0, V.z); }
        public static VectorI4 ___W(this VectorI4 V){ return VecOps.MkVectorI4(0, 0, 0, V.w); }
        public static VectorB2 XX(this VectorB2 V){ return VecOps.MkVectorB2(V.x, V.x); }
        public static VectorB2 XY(this VectorB2 V){ return VecOps.MkVectorB2(V.x, V.y); }
        public static VectorB2 X_(this VectorB2 V){ return VecOps.MkVectorB2(V.x, 0); }
        public static VectorB2 YX(this VectorB2 V){ return VecOps.MkVectorB2(V.y, V.x); }
        public static VectorB2 YY(this VectorB2 V){ return VecOps.MkVectorB2(V.y, V.y); }
        public static VectorB2 Y_(this VectorB2 V){ return VecOps.MkVectorB2(V.y, 0); }
        public static VectorB2 _X(this VectorB2 V){ return VecOps.MkVectorB2(0, V.x); }
        public static VectorB2 _Y(this VectorB2 V){ return VecOps.MkVectorB2(0, V.y); }
        public static VectorB3 XXX(this VectorB2 V){ return VecOps.MkVectorB3(V.x, V.x, V.x); }
        public static VectorB3 XXY(this VectorB2 V){ return VecOps.MkVectorB3(V.x, V.x, V.y); }
        public static VectorB3 XX_(this VectorB2 V){ return VecOps.MkVectorB3(V.x, V.x, 0); }
        public static VectorB3 XYX(this VectorB2 V){ return VecOps.MkVectorB3(V.x, V.y, V.x); }
        public static VectorB3 XYY(this VectorB2 V){ return VecOps.MkVectorB3(V.x, V.y, V.y); }
        public static VectorB3 XY_(this VectorB2 V){ return VecOps.MkVectorB3(V.x, V.y, 0); }
        public static VectorB3 X_X(this VectorB2 V){ return VecOps.MkVectorB3(V.x, 0, V.x); }
        public static VectorB3 X_Y(this VectorB2 V){ return VecOps.MkVectorB3(V.x, 0, V.y); }
        public static VectorB3 X__(this VectorB2 V){ return VecOps.MkVectorB3(V.x, 0, 0); }
        public static VectorB3 YXX(this VectorB2 V){ return VecOps.MkVectorB3(V.y, V.x, V.x); }
        public static VectorB3 YXY(this VectorB2 V){ return VecOps.MkVectorB3(V.y, V.x, V.y); }
        public static VectorB3 YX_(this VectorB2 V){ return VecOps.MkVectorB3(V.y, V.x, 0); }
        public static VectorB3 YYX(this VectorB2 V){ return VecOps.MkVectorB3(V.y, V.y, V.x); }
        public static VectorB3 YYY(this VectorB2 V){ return VecOps.MkVectorB3(V.y, V.y, V.y); }
        public static VectorB3 YY_(this VectorB2 V){ return VecOps.MkVectorB3(V.y, V.y, 0); }
        public static VectorB3 Y_X(this VectorB2 V){ return VecOps.MkVectorB3(V.y, 0, V.x); }
        public static VectorB3 Y_Y(this VectorB2 V){ return VecOps.MkVectorB3(V.y, 0, V.y); }
        public static VectorB3 Y__(this VectorB2 V){ return VecOps.MkVectorB3(V.y, 0, 0); }
        public static VectorB3 _XX(this VectorB2 V){ return VecOps.MkVectorB3(0, V.x, V.x); }
        public static VectorB3 _XY(this VectorB2 V){ return VecOps.MkVectorB3(0, V.x, V.y); }
        public static VectorB3 _X_(this VectorB2 V){ return VecOps.MkVectorB3(0, V.x, 0); }
        public static VectorB3 _YX(this VectorB2 V){ return VecOps.MkVectorB3(0, V.y, V.x); }
        public static VectorB3 _YY(this VectorB2 V){ return VecOps.MkVectorB3(0, V.y, V.y); }
        public static VectorB3 _Y_(this VectorB2 V){ return VecOps.MkVectorB3(0, V.y, 0); }
        public static VectorB3 __X(this VectorB2 V){ return VecOps.MkVectorB3(0, 0, V.x); }
        public static VectorB3 __Y(this VectorB2 V){ return VecOps.MkVectorB3(0, 0, V.y); }
        public static VectorB4 XXXX(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.x); }
        public static VectorB4 XXXY(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.y); }
        public static VectorB4 XXX_(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, 0); }
        public static VectorB4 XXYX(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.x); }
        public static VectorB4 XXYY(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.y); }
        public static VectorB4 XXY_(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, 0); }
        public static VectorB4 XX_X(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.x); }
        public static VectorB4 XX_Y(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.y); }
        public static VectorB4 XX__(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.x, 0, 0); }
        public static VectorB4 XYXX(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.x); }
        public static VectorB4 XYXY(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.y); }
        public static VectorB4 XYX_(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, 0); }
        public static VectorB4 XYYX(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.x); }
        public static VectorB4 XYYY(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.y); }
        public static VectorB4 XYY_(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, 0); }
        public static VectorB4 XY_X(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.x); }
        public static VectorB4 XY_Y(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.y); }
        public static VectorB4 XY__(this VectorB2 V){ return VecOps.MkVectorB4(V.x, V.y, 0, 0); }
        public static VectorB4 X_XX(this VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.x); }
        public static VectorB4 X_XY(this VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.y); }
        public static VectorB4 X_X_(this VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.x, 0); }
        public static VectorB4 X_YX(this VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.x); }
        public static VectorB4 X_YY(this VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.y); }
        public static VectorB4 X_Y_(this VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, V.y, 0); }
        public static VectorB4 X__X(this VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.x); }
        public static VectorB4 X__Y(this VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.y); }
        public static VectorB4 X___(this VectorB2 V){ return VecOps.MkVectorB4(V.x, 0, 0, 0); }
        public static VectorB4 YXXX(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.x); }
        public static VectorB4 YXXY(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.y); }
        public static VectorB4 YXX_(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, 0); }
        public static VectorB4 YXYX(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.x); }
        public static VectorB4 YXYY(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.y); }
        public static VectorB4 YXY_(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, 0); }
        public static VectorB4 YX_X(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.x); }
        public static VectorB4 YX_Y(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.y); }
        public static VectorB4 YX__(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.x, 0, 0); }
        public static VectorB4 YYXX(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.x); }
        public static VectorB4 YYXY(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.y); }
        public static VectorB4 YYX_(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, 0); }
        public static VectorB4 YYYX(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.x); }
        public static VectorB4 YYYY(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.y); }
        public static VectorB4 YYY_(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, 0); }
        public static VectorB4 YY_X(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.x); }
        public static VectorB4 YY_Y(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.y); }
        public static VectorB4 YY__(this VectorB2 V){ return VecOps.MkVectorB4(V.y, V.y, 0, 0); }
        public static VectorB4 Y_XX(this VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.x); }
        public static VectorB4 Y_XY(this VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.y); }
        public static VectorB4 Y_X_(this VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.x, 0); }
        public static VectorB4 Y_YX(this VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.x); }
        public static VectorB4 Y_YY(this VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.y); }
        public static VectorB4 Y_Y_(this VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, V.y, 0); }
        public static VectorB4 Y__X(this VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.x); }
        public static VectorB4 Y__Y(this VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.y); }
        public static VectorB4 Y___(this VectorB2 V){ return VecOps.MkVectorB4(V.y, 0, 0, 0); }
        public static VectorB4 _XXX(this VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.x); }
        public static VectorB4 _XXY(this VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.y); }
        public static VectorB4 _XX_(this VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.x, 0); }
        public static VectorB4 _XYX(this VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.x); }
        public static VectorB4 _XYY(this VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.y); }
        public static VectorB4 _XY_(this VectorB2 V){ return VecOps.MkVectorB4(0, V.x, V.y, 0); }
        public static VectorB4 _X_X(this VectorB2 V){ return VecOps.MkVectorB4(0, V.x, 0, V.x); }
        public static VectorB4 _X_Y(this VectorB2 V){ return VecOps.MkVectorB4(0, V.x, 0, V.y); }
        public static VectorB4 _X__(this VectorB2 V){ return VecOps.MkVectorB4(0, V.x, 0, 0); }
        public static VectorB4 _YXX(this VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.x); }
        public static VectorB4 _YXY(this VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.y); }
        public static VectorB4 _YX_(this VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.x, 0); }
        public static VectorB4 _YYX(this VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.x); }
        public static VectorB4 _YYY(this VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.y); }
        public static VectorB4 _YY_(this VectorB2 V){ return VecOps.MkVectorB4(0, V.y, V.y, 0); }
        public static VectorB4 _Y_X(this VectorB2 V){ return VecOps.MkVectorB4(0, V.y, 0, V.x); }
        public static VectorB4 _Y_Y(this VectorB2 V){ return VecOps.MkVectorB4(0, V.y, 0, V.y); }
        public static VectorB4 _Y__(this VectorB2 V){ return VecOps.MkVectorB4(0, V.y, 0, 0); }
        public static VectorB4 __XX(this VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.x, V.x); }
        public static VectorB4 __XY(this VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.x, V.y); }
        public static VectorB4 __X_(this VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.x, 0); }
        public static VectorB4 __YX(this VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.y, V.x); }
        public static VectorB4 __YY(this VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.y, V.y); }
        public static VectorB4 __Y_(this VectorB2 V){ return VecOps.MkVectorB4(0, 0, V.y, 0); }
        public static VectorB4 ___X(this VectorB2 V){ return VecOps.MkVectorB4(0, 0, 0, V.x); }
        public static VectorB4 ___Y(this VectorB2 V){ return VecOps.MkVectorB4(0, 0, 0, V.y); }
        public static VectorB2 XX(this VectorB3 V){ return VecOps.MkVectorB2(V.x, V.x); }
        public static VectorB2 XY(this VectorB3 V){ return VecOps.MkVectorB2(V.x, V.y); }
        public static VectorB2 XZ(this VectorB3 V){ return VecOps.MkVectorB2(V.x, V.z); }
        public static VectorB2 X_(this VectorB3 V){ return VecOps.MkVectorB2(V.x, 0); }
        public static VectorB2 YX(this VectorB3 V){ return VecOps.MkVectorB2(V.y, V.x); }
        public static VectorB2 YY(this VectorB3 V){ return VecOps.MkVectorB2(V.y, V.y); }
        public static VectorB2 YZ(this VectorB3 V){ return VecOps.MkVectorB2(V.y, V.z); }
        public static VectorB2 Y_(this VectorB3 V){ return VecOps.MkVectorB2(V.y, 0); }
        public static VectorB2 ZX(this VectorB3 V){ return VecOps.MkVectorB2(V.z, V.x); }
        public static VectorB2 ZY(this VectorB3 V){ return VecOps.MkVectorB2(V.z, V.y); }
        public static VectorB2 ZZ(this VectorB3 V){ return VecOps.MkVectorB2(V.z, V.z); }
        public static VectorB2 Z_(this VectorB3 V){ return VecOps.MkVectorB2(V.z, 0); }
        public static VectorB2 _X(this VectorB3 V){ return VecOps.MkVectorB2(0, V.x); }
        public static VectorB2 _Y(this VectorB3 V){ return VecOps.MkVectorB2(0, V.y); }
        public static VectorB2 _Z(this VectorB3 V){ return VecOps.MkVectorB2(0, V.z); }
        public static VectorB3 XXX(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.x, V.x); }
        public static VectorB3 XXY(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.x, V.y); }
        public static VectorB3 XXZ(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.x, V.z); }
        public static VectorB3 XX_(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.x, 0); }
        public static VectorB3 XYX(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.y, V.x); }
        public static VectorB3 XYY(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.y, V.y); }
        public static VectorB3 XYZ(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.y, V.z); }
        public static VectorB3 XY_(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.y, 0); }
        public static VectorB3 XZX(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.z, V.x); }
        public static VectorB3 XZY(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.z, V.y); }
        public static VectorB3 XZZ(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.z, V.z); }
        public static VectorB3 XZ_(this VectorB3 V){ return VecOps.MkVectorB3(V.x, V.z, 0); }
        public static VectorB3 X_X(this VectorB3 V){ return VecOps.MkVectorB3(V.x, 0, V.x); }
        public static VectorB3 X_Y(this VectorB3 V){ return VecOps.MkVectorB3(V.x, 0, V.y); }
        public static VectorB3 X_Z(this VectorB3 V){ return VecOps.MkVectorB3(V.x, 0, V.z); }
        public static VectorB3 X__(this VectorB3 V){ return VecOps.MkVectorB3(V.x, 0, 0); }
        public static VectorB3 YXX(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.x, V.x); }
        public static VectorB3 YXY(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.x, V.y); }
        public static VectorB3 YXZ(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.x, V.z); }
        public static VectorB3 YX_(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.x, 0); }
        public static VectorB3 YYX(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.y, V.x); }
        public static VectorB3 YYY(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.y, V.y); }
        public static VectorB3 YYZ(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.y, V.z); }
        public static VectorB3 YY_(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.y, 0); }
        public static VectorB3 YZX(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.z, V.x); }
        public static VectorB3 YZY(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.z, V.y); }
        public static VectorB3 YZZ(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.z, V.z); }
        public static VectorB3 YZ_(this VectorB3 V){ return VecOps.MkVectorB3(V.y, V.z, 0); }
        public static VectorB3 Y_X(this VectorB3 V){ return VecOps.MkVectorB3(V.y, 0, V.x); }
        public static VectorB3 Y_Y(this VectorB3 V){ return VecOps.MkVectorB3(V.y, 0, V.y); }
        public static VectorB3 Y_Z(this VectorB3 V){ return VecOps.MkVectorB3(V.y, 0, V.z); }
        public static VectorB3 Y__(this VectorB3 V){ return VecOps.MkVectorB3(V.y, 0, 0); }
        public static VectorB3 ZXX(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.x, V.x); }
        public static VectorB3 ZXY(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.x, V.y); }
        public static VectorB3 ZXZ(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.x, V.z); }
        public static VectorB3 ZX_(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.x, 0); }
        public static VectorB3 ZYX(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.y, V.x); }
        public static VectorB3 ZYY(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.y, V.y); }
        public static VectorB3 ZYZ(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.y, V.z); }
        public static VectorB3 ZY_(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.y, 0); }
        public static VectorB3 ZZX(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.z, V.x); }
        public static VectorB3 ZZY(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.z, V.y); }
        public static VectorB3 ZZZ(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.z, V.z); }
        public static VectorB3 ZZ_(this VectorB3 V){ return VecOps.MkVectorB3(V.z, V.z, 0); }
        public static VectorB3 Z_X(this VectorB3 V){ return VecOps.MkVectorB3(V.z, 0, V.x); }
        public static VectorB3 Z_Y(this VectorB3 V){ return VecOps.MkVectorB3(V.z, 0, V.y); }
        public static VectorB3 Z_Z(this VectorB3 V){ return VecOps.MkVectorB3(V.z, 0, V.z); }
        public static VectorB3 Z__(this VectorB3 V){ return VecOps.MkVectorB3(V.z, 0, 0); }
        public static VectorB3 _XX(this VectorB3 V){ return VecOps.MkVectorB3(0, V.x, V.x); }
        public static VectorB3 _XY(this VectorB3 V){ return VecOps.MkVectorB3(0, V.x, V.y); }
        public static VectorB3 _XZ(this VectorB3 V){ return VecOps.MkVectorB3(0, V.x, V.z); }
        public static VectorB3 _X_(this VectorB3 V){ return VecOps.MkVectorB3(0, V.x, 0); }
        public static VectorB3 _YX(this VectorB3 V){ return VecOps.MkVectorB3(0, V.y, V.x); }
        public static VectorB3 _YY(this VectorB3 V){ return VecOps.MkVectorB3(0, V.y, V.y); }
        public static VectorB3 _YZ(this VectorB3 V){ return VecOps.MkVectorB3(0, V.y, V.z); }
        public static VectorB3 _Y_(this VectorB3 V){ return VecOps.MkVectorB3(0, V.y, 0); }
        public static VectorB3 _ZX(this VectorB3 V){ return VecOps.MkVectorB3(0, V.z, V.x); }
        public static VectorB3 _ZY(this VectorB3 V){ return VecOps.MkVectorB3(0, V.z, V.y); }
        public static VectorB3 _ZZ(this VectorB3 V){ return VecOps.MkVectorB3(0, V.z, V.z); }
        public static VectorB3 _Z_(this VectorB3 V){ return VecOps.MkVectorB3(0, V.z, 0); }
        public static VectorB3 __X(this VectorB3 V){ return VecOps.MkVectorB3(0, 0, V.x); }
        public static VectorB3 __Y(this VectorB3 V){ return VecOps.MkVectorB3(0, 0, V.y); }
        public static VectorB3 __Z(this VectorB3 V){ return VecOps.MkVectorB3(0, 0, V.z); }
        public static VectorB4 XXXX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.x); }
        public static VectorB4 XXXY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.y); }
        public static VectorB4 XXXZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.z); }
        public static VectorB4 XXX_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, 0); }
        public static VectorB4 XXYX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.x); }
        public static VectorB4 XXYY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.y); }
        public static VectorB4 XXYZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.z); }
        public static VectorB4 XXY_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, 0); }
        public static VectorB4 XXZX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.x); }
        public static VectorB4 XXZY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.y); }
        public static VectorB4 XXZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.z); }
        public static VectorB4 XXZ_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, 0); }
        public static VectorB4 XX_X(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.x); }
        public static VectorB4 XX_Y(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.y); }
        public static VectorB4 XX_Z(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.z); }
        public static VectorB4 XX__(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.x, 0, 0); }
        public static VectorB4 XYXX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.x); }
        public static VectorB4 XYXY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.y); }
        public static VectorB4 XYXZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.z); }
        public static VectorB4 XYX_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, 0); }
        public static VectorB4 XYYX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.x); }
        public static VectorB4 XYYY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.y); }
        public static VectorB4 XYYZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.z); }
        public static VectorB4 XYY_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, 0); }
        public static VectorB4 XYZX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.x); }
        public static VectorB4 XYZY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.y); }
        public static VectorB4 XYZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.z); }
        public static VectorB4 XYZ_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, 0); }
        public static VectorB4 XY_X(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.x); }
        public static VectorB4 XY_Y(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.y); }
        public static VectorB4 XY_Z(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.z); }
        public static VectorB4 XY__(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.y, 0, 0); }
        public static VectorB4 XZXX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.x); }
        public static VectorB4 XZXY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.y); }
        public static VectorB4 XZXZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.z); }
        public static VectorB4 XZX_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, 0); }
        public static VectorB4 XZYX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.x); }
        public static VectorB4 XZYY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.y); }
        public static VectorB4 XZYZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.z); }
        public static VectorB4 XZY_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, 0); }
        public static VectorB4 XZZX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.x); }
        public static VectorB4 XZZY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.y); }
        public static VectorB4 XZZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.z); }
        public static VectorB4 XZZ_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, 0); }
        public static VectorB4 XZ_X(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.x); }
        public static VectorB4 XZ_Y(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.y); }
        public static VectorB4 XZ_Z(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.z); }
        public static VectorB4 XZ__(this VectorB3 V){ return VecOps.MkVectorB4(V.x, V.z, 0, 0); }
        public static VectorB4 X_XX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.x); }
        public static VectorB4 X_XY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.y); }
        public static VectorB4 X_XZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.z); }
        public static VectorB4 X_X_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.x, 0); }
        public static VectorB4 X_YX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.x); }
        public static VectorB4 X_YY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.y); }
        public static VectorB4 X_YZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.z); }
        public static VectorB4 X_Y_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.y, 0); }
        public static VectorB4 X_ZX(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.x); }
        public static VectorB4 X_ZY(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.y); }
        public static VectorB4 X_ZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.z); }
        public static VectorB4 X_Z_(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, V.z, 0); }
        public static VectorB4 X__X(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.x); }
        public static VectorB4 X__Y(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.y); }
        public static VectorB4 X__Z(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.z); }
        public static VectorB4 X___(this VectorB3 V){ return VecOps.MkVectorB4(V.x, 0, 0, 0); }
        public static VectorB4 YXXX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.x); }
        public static VectorB4 YXXY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.y); }
        public static VectorB4 YXXZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.z); }
        public static VectorB4 YXX_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, 0); }
        public static VectorB4 YXYX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.x); }
        public static VectorB4 YXYY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.y); }
        public static VectorB4 YXYZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.z); }
        public static VectorB4 YXY_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, 0); }
        public static VectorB4 YXZX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.x); }
        public static VectorB4 YXZY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.y); }
        public static VectorB4 YXZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.z); }
        public static VectorB4 YXZ_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, 0); }
        public static VectorB4 YX_X(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.x); }
        public static VectorB4 YX_Y(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.y); }
        public static VectorB4 YX_Z(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.z); }
        public static VectorB4 YX__(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.x, 0, 0); }
        public static VectorB4 YYXX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.x); }
        public static VectorB4 YYXY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.y); }
        public static VectorB4 YYXZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.z); }
        public static VectorB4 YYX_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, 0); }
        public static VectorB4 YYYX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.x); }
        public static VectorB4 YYYY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.y); }
        public static VectorB4 YYYZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.z); }
        public static VectorB4 YYY_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, 0); }
        public static VectorB4 YYZX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.x); }
        public static VectorB4 YYZY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.y); }
        public static VectorB4 YYZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.z); }
        public static VectorB4 YYZ_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, 0); }
        public static VectorB4 YY_X(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.x); }
        public static VectorB4 YY_Y(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.y); }
        public static VectorB4 YY_Z(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.z); }
        public static VectorB4 YY__(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.y, 0, 0); }
        public static VectorB4 YZXX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.x); }
        public static VectorB4 YZXY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.y); }
        public static VectorB4 YZXZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.z); }
        public static VectorB4 YZX_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, 0); }
        public static VectorB4 YZYX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.x); }
        public static VectorB4 YZYY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.y); }
        public static VectorB4 YZYZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.z); }
        public static VectorB4 YZY_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, 0); }
        public static VectorB4 YZZX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.x); }
        public static VectorB4 YZZY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.y); }
        public static VectorB4 YZZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.z); }
        public static VectorB4 YZZ_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, 0); }
        public static VectorB4 YZ_X(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.x); }
        public static VectorB4 YZ_Y(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.y); }
        public static VectorB4 YZ_Z(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.z); }
        public static VectorB4 YZ__(this VectorB3 V){ return VecOps.MkVectorB4(V.y, V.z, 0, 0); }
        public static VectorB4 Y_XX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.x); }
        public static VectorB4 Y_XY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.y); }
        public static VectorB4 Y_XZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.z); }
        public static VectorB4 Y_X_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.x, 0); }
        public static VectorB4 Y_YX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.x); }
        public static VectorB4 Y_YY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.y); }
        public static VectorB4 Y_YZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.z); }
        public static VectorB4 Y_Y_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.y, 0); }
        public static VectorB4 Y_ZX(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.x); }
        public static VectorB4 Y_ZY(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.y); }
        public static VectorB4 Y_ZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.z); }
        public static VectorB4 Y_Z_(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, V.z, 0); }
        public static VectorB4 Y__X(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.x); }
        public static VectorB4 Y__Y(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.y); }
        public static VectorB4 Y__Z(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.z); }
        public static VectorB4 Y___(this VectorB3 V){ return VecOps.MkVectorB4(V.y, 0, 0, 0); }
        public static VectorB4 ZXXX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.x); }
        public static VectorB4 ZXXY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.y); }
        public static VectorB4 ZXXZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.z); }
        public static VectorB4 ZXX_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, 0); }
        public static VectorB4 ZXYX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.x); }
        public static VectorB4 ZXYY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.y); }
        public static VectorB4 ZXYZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.z); }
        public static VectorB4 ZXY_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, 0); }
        public static VectorB4 ZXZX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.x); }
        public static VectorB4 ZXZY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.y); }
        public static VectorB4 ZXZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.z); }
        public static VectorB4 ZXZ_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, 0); }
        public static VectorB4 ZX_X(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.x); }
        public static VectorB4 ZX_Y(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.y); }
        public static VectorB4 ZX_Z(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.z); }
        public static VectorB4 ZX__(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.x, 0, 0); }
        public static VectorB4 ZYXX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.x); }
        public static VectorB4 ZYXY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.y); }
        public static VectorB4 ZYXZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.z); }
        public static VectorB4 ZYX_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, 0); }
        public static VectorB4 ZYYX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.x); }
        public static VectorB4 ZYYY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.y); }
        public static VectorB4 ZYYZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.z); }
        public static VectorB4 ZYY_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, 0); }
        public static VectorB4 ZYZX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.x); }
        public static VectorB4 ZYZY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.y); }
        public static VectorB4 ZYZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.z); }
        public static VectorB4 ZYZ_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, 0); }
        public static VectorB4 ZY_X(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.x); }
        public static VectorB4 ZY_Y(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.y); }
        public static VectorB4 ZY_Z(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.z); }
        public static VectorB4 ZY__(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.y, 0, 0); }
        public static VectorB4 ZZXX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.x); }
        public static VectorB4 ZZXY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.y); }
        public static VectorB4 ZZXZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.z); }
        public static VectorB4 ZZX_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, 0); }
        public static VectorB4 ZZYX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.x); }
        public static VectorB4 ZZYY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.y); }
        public static VectorB4 ZZYZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.z); }
        public static VectorB4 ZZY_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, 0); }
        public static VectorB4 ZZZX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.x); }
        public static VectorB4 ZZZY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.y); }
        public static VectorB4 ZZZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.z); }
        public static VectorB4 ZZZ_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, 0); }
        public static VectorB4 ZZ_X(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.x); }
        public static VectorB4 ZZ_Y(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.y); }
        public static VectorB4 ZZ_Z(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.z); }
        public static VectorB4 ZZ__(this VectorB3 V){ return VecOps.MkVectorB4(V.z, V.z, 0, 0); }
        public static VectorB4 Z_XX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.x); }
        public static VectorB4 Z_XY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.y); }
        public static VectorB4 Z_XZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.z); }
        public static VectorB4 Z_X_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.x, 0); }
        public static VectorB4 Z_YX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.x); }
        public static VectorB4 Z_YY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.y); }
        public static VectorB4 Z_YZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.z); }
        public static VectorB4 Z_Y_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.y, 0); }
        public static VectorB4 Z_ZX(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.x); }
        public static VectorB4 Z_ZY(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.y); }
        public static VectorB4 Z_ZZ(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.z); }
        public static VectorB4 Z_Z_(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, V.z, 0); }
        public static VectorB4 Z__X(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.x); }
        public static VectorB4 Z__Y(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.y); }
        public static VectorB4 Z__Z(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.z); }
        public static VectorB4 Z___(this VectorB3 V){ return VecOps.MkVectorB4(V.z, 0, 0, 0); }
        public static VectorB4 _XXX(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.x); }
        public static VectorB4 _XXY(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.y); }
        public static VectorB4 _XXZ(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.z); }
        public static VectorB4 _XX_(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.x, 0); }
        public static VectorB4 _XYX(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.x); }
        public static VectorB4 _XYY(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.y); }
        public static VectorB4 _XYZ(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.z); }
        public static VectorB4 _XY_(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.y, 0); }
        public static VectorB4 _XZX(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.x); }
        public static VectorB4 _XZY(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.y); }
        public static VectorB4 _XZZ(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.z); }
        public static VectorB4 _XZ_(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, V.z, 0); }
        public static VectorB4 _X_X(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, 0, V.x); }
        public static VectorB4 _X_Y(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, 0, V.y); }
        public static VectorB4 _X_Z(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, 0, V.z); }
        public static VectorB4 _X__(this VectorB3 V){ return VecOps.MkVectorB4(0, V.x, 0, 0); }
        public static VectorB4 _YXX(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.x); }
        public static VectorB4 _YXY(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.y); }
        public static VectorB4 _YXZ(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.z); }
        public static VectorB4 _YX_(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.x, 0); }
        public static VectorB4 _YYX(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.x); }
        public static VectorB4 _YYY(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.y); }
        public static VectorB4 _YYZ(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.z); }
        public static VectorB4 _YY_(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.y, 0); }
        public static VectorB4 _YZX(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.x); }
        public static VectorB4 _YZY(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.y); }
        public static VectorB4 _YZZ(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.z); }
        public static VectorB4 _YZ_(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, V.z, 0); }
        public static VectorB4 _Y_X(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, 0, V.x); }
        public static VectorB4 _Y_Y(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, 0, V.y); }
        public static VectorB4 _Y_Z(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, 0, V.z); }
        public static VectorB4 _Y__(this VectorB3 V){ return VecOps.MkVectorB4(0, V.y, 0, 0); }
        public static VectorB4 _ZXX(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.x); }
        public static VectorB4 _ZXY(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.y); }
        public static VectorB4 _ZXZ(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.z); }
        public static VectorB4 _ZX_(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.x, 0); }
        public static VectorB4 _ZYX(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.x); }
        public static VectorB4 _ZYY(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.y); }
        public static VectorB4 _ZYZ(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.z); }
        public static VectorB4 _ZY_(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.y, 0); }
        public static VectorB4 _ZZX(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.x); }
        public static VectorB4 _ZZY(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.y); }
        public static VectorB4 _ZZZ(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.z); }
        public static VectorB4 _ZZ_(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, V.z, 0); }
        public static VectorB4 _Z_X(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, 0, V.x); }
        public static VectorB4 _Z_Y(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, 0, V.y); }
        public static VectorB4 _Z_Z(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, 0, V.z); }
        public static VectorB4 _Z__(this VectorB3 V){ return VecOps.MkVectorB4(0, V.z, 0, 0); }
        public static VectorB4 __XX(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.x, V.x); }
        public static VectorB4 __XY(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.x, V.y); }
        public static VectorB4 __XZ(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.x, V.z); }
        public static VectorB4 __X_(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.x, 0); }
        public static VectorB4 __YX(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.y, V.x); }
        public static VectorB4 __YY(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.y, V.y); }
        public static VectorB4 __YZ(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.y, V.z); }
        public static VectorB4 __Y_(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.y, 0); }
        public static VectorB4 __ZX(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.z, V.x); }
        public static VectorB4 __ZY(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.z, V.y); }
        public static VectorB4 __ZZ(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.z, V.z); }
        public static VectorB4 __Z_(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, V.z, 0); }
        public static VectorB4 ___X(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, 0, V.x); }
        public static VectorB4 ___Y(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, 0, V.y); }
        public static VectorB4 ___Z(this VectorB3 V){ return VecOps.MkVectorB4(0, 0, 0, V.z); }
        public static VectorB2 XX(this VectorB4 V){ return VecOps.MkVectorB2(V.x, V.x); }
        public static VectorB2 XY(this VectorB4 V){ return VecOps.MkVectorB2(V.x, V.y); }
        public static VectorB2 XZ(this VectorB4 V){ return VecOps.MkVectorB2(V.x, V.z); }
        public static VectorB2 XW(this VectorB4 V){ return VecOps.MkVectorB2(V.x, V.w); }
        public static VectorB2 X_(this VectorB4 V){ return VecOps.MkVectorB2(V.x, 0); }
        public static VectorB2 YX(this VectorB4 V){ return VecOps.MkVectorB2(V.y, V.x); }
        public static VectorB2 YY(this VectorB4 V){ return VecOps.MkVectorB2(V.y, V.y); }
        public static VectorB2 YZ(this VectorB4 V){ return VecOps.MkVectorB2(V.y, V.z); }
        public static VectorB2 YW(this VectorB4 V){ return VecOps.MkVectorB2(V.y, V.w); }
        public static VectorB2 Y_(this VectorB4 V){ return VecOps.MkVectorB2(V.y, 0); }
        public static VectorB2 ZX(this VectorB4 V){ return VecOps.MkVectorB2(V.z, V.x); }
        public static VectorB2 ZY(this VectorB4 V){ return VecOps.MkVectorB2(V.z, V.y); }
        public static VectorB2 ZZ(this VectorB4 V){ return VecOps.MkVectorB2(V.z, V.z); }
        public static VectorB2 ZW(this VectorB4 V){ return VecOps.MkVectorB2(V.z, V.w); }
        public static VectorB2 Z_(this VectorB4 V){ return VecOps.MkVectorB2(V.z, 0); }
        public static VectorB2 WX(this VectorB4 V){ return VecOps.MkVectorB2(V.w, V.x); }
        public static VectorB2 WY(this VectorB4 V){ return VecOps.MkVectorB2(V.w, V.y); }
        public static VectorB2 WZ(this VectorB4 V){ return VecOps.MkVectorB2(V.w, V.z); }
        public static VectorB2 WW(this VectorB4 V){ return VecOps.MkVectorB2(V.w, V.w); }
        public static VectorB2 W_(this VectorB4 V){ return VecOps.MkVectorB2(V.w, 0); }
        public static VectorB2 _X(this VectorB4 V){ return VecOps.MkVectorB2(0, V.x); }
        public static VectorB2 _Y(this VectorB4 V){ return VecOps.MkVectorB2(0, V.y); }
        public static VectorB2 _Z(this VectorB4 V){ return VecOps.MkVectorB2(0, V.z); }
        public static VectorB2 _W(this VectorB4 V){ return VecOps.MkVectorB2(0, V.w); }
        public static VectorB3 XXX(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.x, V.x); }
        public static VectorB3 XXY(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.x, V.y); }
        public static VectorB3 XXZ(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.x, V.z); }
        public static VectorB3 XXW(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.x, V.w); }
        public static VectorB3 XX_(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.x, 0); }
        public static VectorB3 XYX(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.y, V.x); }
        public static VectorB3 XYY(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.y, V.y); }
        public static VectorB3 XYZ(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.y, V.z); }
        public static VectorB3 XYW(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.y, V.w); }
        public static VectorB3 XY_(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.y, 0); }
        public static VectorB3 XZX(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.z, V.x); }
        public static VectorB3 XZY(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.z, V.y); }
        public static VectorB3 XZZ(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.z, V.z); }
        public static VectorB3 XZW(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.z, V.w); }
        public static VectorB3 XZ_(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.z, 0); }
        public static VectorB3 XWX(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.w, V.x); }
        public static VectorB3 XWY(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.w, V.y); }
        public static VectorB3 XWZ(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.w, V.z); }
        public static VectorB3 XWW(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.w, V.w); }
        public static VectorB3 XW_(this VectorB4 V){ return VecOps.MkVectorB3(V.x, V.w, 0); }
        public static VectorB3 X_X(this VectorB4 V){ return VecOps.MkVectorB3(V.x, 0, V.x); }
        public static VectorB3 X_Y(this VectorB4 V){ return VecOps.MkVectorB3(V.x, 0, V.y); }
        public static VectorB3 X_Z(this VectorB4 V){ return VecOps.MkVectorB3(V.x, 0, V.z); }
        public static VectorB3 X_W(this VectorB4 V){ return VecOps.MkVectorB3(V.x, 0, V.w); }
        public static VectorB3 X__(this VectorB4 V){ return VecOps.MkVectorB3(V.x, 0, 0); }
        public static VectorB3 YXX(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.x, V.x); }
        public static VectorB3 YXY(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.x, V.y); }
        public static VectorB3 YXZ(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.x, V.z); }
        public static VectorB3 YXW(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.x, V.w); }
        public static VectorB3 YX_(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.x, 0); }
        public static VectorB3 YYX(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.y, V.x); }
        public static VectorB3 YYY(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.y, V.y); }
        public static VectorB3 YYZ(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.y, V.z); }
        public static VectorB3 YYW(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.y, V.w); }
        public static VectorB3 YY_(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.y, 0); }
        public static VectorB3 YZX(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.z, V.x); }
        public static VectorB3 YZY(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.z, V.y); }
        public static VectorB3 YZZ(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.z, V.z); }
        public static VectorB3 YZW(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.z, V.w); }
        public static VectorB3 YZ_(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.z, 0); }
        public static VectorB3 YWX(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.w, V.x); }
        public static VectorB3 YWY(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.w, V.y); }
        public static VectorB3 YWZ(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.w, V.z); }
        public static VectorB3 YWW(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.w, V.w); }
        public static VectorB3 YW_(this VectorB4 V){ return VecOps.MkVectorB3(V.y, V.w, 0); }
        public static VectorB3 Y_X(this VectorB4 V){ return VecOps.MkVectorB3(V.y, 0, V.x); }
        public static VectorB3 Y_Y(this VectorB4 V){ return VecOps.MkVectorB3(V.y, 0, V.y); }
        public static VectorB3 Y_Z(this VectorB4 V){ return VecOps.MkVectorB3(V.y, 0, V.z); }
        public static VectorB3 Y_W(this VectorB4 V){ return VecOps.MkVectorB3(V.y, 0, V.w); }
        public static VectorB3 Y__(this VectorB4 V){ return VecOps.MkVectorB3(V.y, 0, 0); }
        public static VectorB3 ZXX(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.x, V.x); }
        public static VectorB3 ZXY(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.x, V.y); }
        public static VectorB3 ZXZ(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.x, V.z); }
        public static VectorB3 ZXW(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.x, V.w); }
        public static VectorB3 ZX_(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.x, 0); }
        public static VectorB3 ZYX(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.y, V.x); }
        public static VectorB3 ZYY(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.y, V.y); }
        public static VectorB3 ZYZ(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.y, V.z); }
        public static VectorB3 ZYW(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.y, V.w); }
        public static VectorB3 ZY_(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.y, 0); }
        public static VectorB3 ZZX(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.z, V.x); }
        public static VectorB3 ZZY(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.z, V.y); }
        public static VectorB3 ZZZ(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.z, V.z); }
        public static VectorB3 ZZW(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.z, V.w); }
        public static VectorB3 ZZ_(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.z, 0); }
        public static VectorB3 ZWX(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.w, V.x); }
        public static VectorB3 ZWY(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.w, V.y); }
        public static VectorB3 ZWZ(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.w, V.z); }
        public static VectorB3 ZWW(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.w, V.w); }
        public static VectorB3 ZW_(this VectorB4 V){ return VecOps.MkVectorB3(V.z, V.w, 0); }
        public static VectorB3 Z_X(this VectorB4 V){ return VecOps.MkVectorB3(V.z, 0, V.x); }
        public static VectorB3 Z_Y(this VectorB4 V){ return VecOps.MkVectorB3(V.z, 0, V.y); }
        public static VectorB3 Z_Z(this VectorB4 V){ return VecOps.MkVectorB3(V.z, 0, V.z); }
        public static VectorB3 Z_W(this VectorB4 V){ return VecOps.MkVectorB3(V.z, 0, V.w); }
        public static VectorB3 Z__(this VectorB4 V){ return VecOps.MkVectorB3(V.z, 0, 0); }
        public static VectorB3 WXX(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.x, V.x); }
        public static VectorB3 WXY(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.x, V.y); }
        public static VectorB3 WXZ(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.x, V.z); }
        public static VectorB3 WXW(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.x, V.w); }
        public static VectorB3 WX_(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.x, 0); }
        public static VectorB3 WYX(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.y, V.x); }
        public static VectorB3 WYY(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.y, V.y); }
        public static VectorB3 WYZ(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.y, V.z); }
        public static VectorB3 WYW(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.y, V.w); }
        public static VectorB3 WY_(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.y, 0); }
        public static VectorB3 WZX(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.z, V.x); }
        public static VectorB3 WZY(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.z, V.y); }
        public static VectorB3 WZZ(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.z, V.z); }
        public static VectorB3 WZW(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.z, V.w); }
        public static VectorB3 WZ_(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.z, 0); }
        public static VectorB3 WWX(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.w, V.x); }
        public static VectorB3 WWY(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.w, V.y); }
        public static VectorB3 WWZ(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.w, V.z); }
        public static VectorB3 WWW(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.w, V.w); }
        public static VectorB3 WW_(this VectorB4 V){ return VecOps.MkVectorB3(V.w, V.w, 0); }
        public static VectorB3 W_X(this VectorB4 V){ return VecOps.MkVectorB3(V.w, 0, V.x); }
        public static VectorB3 W_Y(this VectorB4 V){ return VecOps.MkVectorB3(V.w, 0, V.y); }
        public static VectorB3 W_Z(this VectorB4 V){ return VecOps.MkVectorB3(V.w, 0, V.z); }
        public static VectorB3 W_W(this VectorB4 V){ return VecOps.MkVectorB3(V.w, 0, V.w); }
        public static VectorB3 W__(this VectorB4 V){ return VecOps.MkVectorB3(V.w, 0, 0); }
        public static VectorB3 _XX(this VectorB4 V){ return VecOps.MkVectorB3(0, V.x, V.x); }
        public static VectorB3 _XY(this VectorB4 V){ return VecOps.MkVectorB3(0, V.x, V.y); }
        public static VectorB3 _XZ(this VectorB4 V){ return VecOps.MkVectorB3(0, V.x, V.z); }
        public static VectorB3 _XW(this VectorB4 V){ return VecOps.MkVectorB3(0, V.x, V.w); }
        public static VectorB3 _X_(this VectorB4 V){ return VecOps.MkVectorB3(0, V.x, 0); }
        public static VectorB3 _YX(this VectorB4 V){ return VecOps.MkVectorB3(0, V.y, V.x); }
        public static VectorB3 _YY(this VectorB4 V){ return VecOps.MkVectorB3(0, V.y, V.y); }
        public static VectorB3 _YZ(this VectorB4 V){ return VecOps.MkVectorB3(0, V.y, V.z); }
        public static VectorB3 _YW(this VectorB4 V){ return VecOps.MkVectorB3(0, V.y, V.w); }
        public static VectorB3 _Y_(this VectorB4 V){ return VecOps.MkVectorB3(0, V.y, 0); }
        public static VectorB3 _ZX(this VectorB4 V){ return VecOps.MkVectorB3(0, V.z, V.x); }
        public static VectorB3 _ZY(this VectorB4 V){ return VecOps.MkVectorB3(0, V.z, V.y); }
        public static VectorB3 _ZZ(this VectorB4 V){ return VecOps.MkVectorB3(0, V.z, V.z); }
        public static VectorB3 _ZW(this VectorB4 V){ return VecOps.MkVectorB3(0, V.z, V.w); }
        public static VectorB3 _Z_(this VectorB4 V){ return VecOps.MkVectorB3(0, V.z, 0); }
        public static VectorB3 _WX(this VectorB4 V){ return VecOps.MkVectorB3(0, V.w, V.x); }
        public static VectorB3 _WY(this VectorB4 V){ return VecOps.MkVectorB3(0, V.w, V.y); }
        public static VectorB3 _WZ(this VectorB4 V){ return VecOps.MkVectorB3(0, V.w, V.z); }
        public static VectorB3 _WW(this VectorB4 V){ return VecOps.MkVectorB3(0, V.w, V.w); }
        public static VectorB3 _W_(this VectorB4 V){ return VecOps.MkVectorB3(0, V.w, 0); }
        public static VectorB3 __X(this VectorB4 V){ return VecOps.MkVectorB3(0, 0, V.x); }
        public static VectorB3 __Y(this VectorB4 V){ return VecOps.MkVectorB3(0, 0, V.y); }
        public static VectorB3 __Z(this VectorB4 V){ return VecOps.MkVectorB3(0, 0, V.z); }
        public static VectorB3 __W(this VectorB4 V){ return VecOps.MkVectorB3(0, 0, V.w); }
        public static VectorB4 XXXX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.x); }
        public static VectorB4 XXXY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.y); }
        public static VectorB4 XXXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.z); }
        public static VectorB4 XXXW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, V.w); }
        public static VectorB4 XXX_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.x, 0); }
        public static VectorB4 XXYX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.x); }
        public static VectorB4 XXYY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.y); }
        public static VectorB4 XXYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.z); }
        public static VectorB4 XXYW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, V.w); }
        public static VectorB4 XXY_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.y, 0); }
        public static VectorB4 XXZX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.x); }
        public static VectorB4 XXZY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.y); }
        public static VectorB4 XXZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.z); }
        public static VectorB4 XXZW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, V.w); }
        public static VectorB4 XXZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.z, 0); }
        public static VectorB4 XXWX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.w, V.x); }
        public static VectorB4 XXWY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.w, V.y); }
        public static VectorB4 XXWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.w, V.z); }
        public static VectorB4 XXWW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.w, V.w); }
        public static VectorB4 XXW_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, V.w, 0); }
        public static VectorB4 XX_X(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.x); }
        public static VectorB4 XX_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.y); }
        public static VectorB4 XX_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.z); }
        public static VectorB4 XX_W(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, 0, V.w); }
        public static VectorB4 XX__(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.x, 0, 0); }
        public static VectorB4 XYXX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.x); }
        public static VectorB4 XYXY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.y); }
        public static VectorB4 XYXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.z); }
        public static VectorB4 XYXW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, V.w); }
        public static VectorB4 XYX_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.x, 0); }
        public static VectorB4 XYYX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.x); }
        public static VectorB4 XYYY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.y); }
        public static VectorB4 XYYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.z); }
        public static VectorB4 XYYW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, V.w); }
        public static VectorB4 XYY_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.y, 0); }
        public static VectorB4 XYZX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.x); }
        public static VectorB4 XYZY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.y); }
        public static VectorB4 XYZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.z); }
        public static VectorB4 XYZW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, V.w); }
        public static VectorB4 XYZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.z, 0); }
        public static VectorB4 XYWX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.w, V.x); }
        public static VectorB4 XYWY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.w, V.y); }
        public static VectorB4 XYWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.w, V.z); }
        public static VectorB4 XYWW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.w, V.w); }
        public static VectorB4 XYW_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, V.w, 0); }
        public static VectorB4 XY_X(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.x); }
        public static VectorB4 XY_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.y); }
        public static VectorB4 XY_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.z); }
        public static VectorB4 XY_W(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, 0, V.w); }
        public static VectorB4 XY__(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.y, 0, 0); }
        public static VectorB4 XZXX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.x); }
        public static VectorB4 XZXY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.y); }
        public static VectorB4 XZXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.z); }
        public static VectorB4 XZXW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, V.w); }
        public static VectorB4 XZX_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.x, 0); }
        public static VectorB4 XZYX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.x); }
        public static VectorB4 XZYY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.y); }
        public static VectorB4 XZYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.z); }
        public static VectorB4 XZYW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, V.w); }
        public static VectorB4 XZY_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.y, 0); }
        public static VectorB4 XZZX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.x); }
        public static VectorB4 XZZY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.y); }
        public static VectorB4 XZZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.z); }
        public static VectorB4 XZZW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, V.w); }
        public static VectorB4 XZZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.z, 0); }
        public static VectorB4 XZWX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.w, V.x); }
        public static VectorB4 XZWY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.w, V.y); }
        public static VectorB4 XZWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.w, V.z); }
        public static VectorB4 XZWW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.w, V.w); }
        public static VectorB4 XZW_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, V.w, 0); }
        public static VectorB4 XZ_X(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.x); }
        public static VectorB4 XZ_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.y); }
        public static VectorB4 XZ_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.z); }
        public static VectorB4 XZ_W(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, 0, V.w); }
        public static VectorB4 XZ__(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.z, 0, 0); }
        public static VectorB4 XWXX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.x, V.x); }
        public static VectorB4 XWXY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.x, V.y); }
        public static VectorB4 XWXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.x, V.z); }
        public static VectorB4 XWXW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.x, V.w); }
        public static VectorB4 XWX_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.x, 0); }
        public static VectorB4 XWYX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.y, V.x); }
        public static VectorB4 XWYY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.y, V.y); }
        public static VectorB4 XWYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.y, V.z); }
        public static VectorB4 XWYW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.y, V.w); }
        public static VectorB4 XWY_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.y, 0); }
        public static VectorB4 XWZX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.z, V.x); }
        public static VectorB4 XWZY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.z, V.y); }
        public static VectorB4 XWZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.z, V.z); }
        public static VectorB4 XWZW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.z, V.w); }
        public static VectorB4 XWZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.z, 0); }
        public static VectorB4 XWWX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.w, V.x); }
        public static VectorB4 XWWY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.w, V.y); }
        public static VectorB4 XWWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.w, V.z); }
        public static VectorB4 XWWW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.w, V.w); }
        public static VectorB4 XWW_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, V.w, 0); }
        public static VectorB4 XW_X(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, 0, V.x); }
        public static VectorB4 XW_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, 0, V.y); }
        public static VectorB4 XW_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, 0, V.z); }
        public static VectorB4 XW_W(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, 0, V.w); }
        public static VectorB4 XW__(this VectorB4 V){ return VecOps.MkVectorB4(V.x, V.w, 0, 0); }
        public static VectorB4 X_XX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.x); }
        public static VectorB4 X_XY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.y); }
        public static VectorB4 X_XZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.z); }
        public static VectorB4 X_XW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.x, V.w); }
        public static VectorB4 X_X_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.x, 0); }
        public static VectorB4 X_YX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.x); }
        public static VectorB4 X_YY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.y); }
        public static VectorB4 X_YZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.z); }
        public static VectorB4 X_YW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.y, V.w); }
        public static VectorB4 X_Y_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.y, 0); }
        public static VectorB4 X_ZX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.x); }
        public static VectorB4 X_ZY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.y); }
        public static VectorB4 X_ZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.z); }
        public static VectorB4 X_ZW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.z, V.w); }
        public static VectorB4 X_Z_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.z, 0); }
        public static VectorB4 X_WX(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.w, V.x); }
        public static VectorB4 X_WY(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.w, V.y); }
        public static VectorB4 X_WZ(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.w, V.z); }
        public static VectorB4 X_WW(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.w, V.w); }
        public static VectorB4 X_W_(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, V.w, 0); }
        public static VectorB4 X__X(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.x); }
        public static VectorB4 X__Y(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.y); }
        public static VectorB4 X__Z(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.z); }
        public static VectorB4 X__W(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, 0, V.w); }
        public static VectorB4 X___(this VectorB4 V){ return VecOps.MkVectorB4(V.x, 0, 0, 0); }
        public static VectorB4 YXXX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.x); }
        public static VectorB4 YXXY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.y); }
        public static VectorB4 YXXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.z); }
        public static VectorB4 YXXW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, V.w); }
        public static VectorB4 YXX_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.x, 0); }
        public static VectorB4 YXYX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.x); }
        public static VectorB4 YXYY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.y); }
        public static VectorB4 YXYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.z); }
        public static VectorB4 YXYW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, V.w); }
        public static VectorB4 YXY_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.y, 0); }
        public static VectorB4 YXZX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.x); }
        public static VectorB4 YXZY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.y); }
        public static VectorB4 YXZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.z); }
        public static VectorB4 YXZW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, V.w); }
        public static VectorB4 YXZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.z, 0); }
        public static VectorB4 YXWX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.w, V.x); }
        public static VectorB4 YXWY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.w, V.y); }
        public static VectorB4 YXWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.w, V.z); }
        public static VectorB4 YXWW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.w, V.w); }
        public static VectorB4 YXW_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, V.w, 0); }
        public static VectorB4 YX_X(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.x); }
        public static VectorB4 YX_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.y); }
        public static VectorB4 YX_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.z); }
        public static VectorB4 YX_W(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, 0, V.w); }
        public static VectorB4 YX__(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.x, 0, 0); }
        public static VectorB4 YYXX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.x); }
        public static VectorB4 YYXY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.y); }
        public static VectorB4 YYXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.z); }
        public static VectorB4 YYXW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, V.w); }
        public static VectorB4 YYX_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.x, 0); }
        public static VectorB4 YYYX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.x); }
        public static VectorB4 YYYY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.y); }
        public static VectorB4 YYYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.z); }
        public static VectorB4 YYYW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, V.w); }
        public static VectorB4 YYY_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.y, 0); }
        public static VectorB4 YYZX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.x); }
        public static VectorB4 YYZY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.y); }
        public static VectorB4 YYZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.z); }
        public static VectorB4 YYZW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, V.w); }
        public static VectorB4 YYZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.z, 0); }
        public static VectorB4 YYWX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.w, V.x); }
        public static VectorB4 YYWY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.w, V.y); }
        public static VectorB4 YYWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.w, V.z); }
        public static VectorB4 YYWW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.w, V.w); }
        public static VectorB4 YYW_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, V.w, 0); }
        public static VectorB4 YY_X(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.x); }
        public static VectorB4 YY_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.y); }
        public static VectorB4 YY_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.z); }
        public static VectorB4 YY_W(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, 0, V.w); }
        public static VectorB4 YY__(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.y, 0, 0); }
        public static VectorB4 YZXX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.x); }
        public static VectorB4 YZXY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.y); }
        public static VectorB4 YZXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.z); }
        public static VectorB4 YZXW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, V.w); }
        public static VectorB4 YZX_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.x, 0); }
        public static VectorB4 YZYX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.x); }
        public static VectorB4 YZYY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.y); }
        public static VectorB4 YZYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.z); }
        public static VectorB4 YZYW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, V.w); }
        public static VectorB4 YZY_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.y, 0); }
        public static VectorB4 YZZX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.x); }
        public static VectorB4 YZZY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.y); }
        public static VectorB4 YZZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.z); }
        public static VectorB4 YZZW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, V.w); }
        public static VectorB4 YZZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.z, 0); }
        public static VectorB4 YZWX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.w, V.x); }
        public static VectorB4 YZWY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.w, V.y); }
        public static VectorB4 YZWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.w, V.z); }
        public static VectorB4 YZWW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.w, V.w); }
        public static VectorB4 YZW_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, V.w, 0); }
        public static VectorB4 YZ_X(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.x); }
        public static VectorB4 YZ_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.y); }
        public static VectorB4 YZ_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.z); }
        public static VectorB4 YZ_W(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, 0, V.w); }
        public static VectorB4 YZ__(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.z, 0, 0); }
        public static VectorB4 YWXX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.x, V.x); }
        public static VectorB4 YWXY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.x, V.y); }
        public static VectorB4 YWXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.x, V.z); }
        public static VectorB4 YWXW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.x, V.w); }
        public static VectorB4 YWX_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.x, 0); }
        public static VectorB4 YWYX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.y, V.x); }
        public static VectorB4 YWYY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.y, V.y); }
        public static VectorB4 YWYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.y, V.z); }
        public static VectorB4 YWYW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.y, V.w); }
        public static VectorB4 YWY_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.y, 0); }
        public static VectorB4 YWZX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.z, V.x); }
        public static VectorB4 YWZY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.z, V.y); }
        public static VectorB4 YWZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.z, V.z); }
        public static VectorB4 YWZW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.z, V.w); }
        public static VectorB4 YWZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.z, 0); }
        public static VectorB4 YWWX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.w, V.x); }
        public static VectorB4 YWWY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.w, V.y); }
        public static VectorB4 YWWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.w, V.z); }
        public static VectorB4 YWWW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.w, V.w); }
        public static VectorB4 YWW_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, V.w, 0); }
        public static VectorB4 YW_X(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, 0, V.x); }
        public static VectorB4 YW_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, 0, V.y); }
        public static VectorB4 YW_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, 0, V.z); }
        public static VectorB4 YW_W(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, 0, V.w); }
        public static VectorB4 YW__(this VectorB4 V){ return VecOps.MkVectorB4(V.y, V.w, 0, 0); }
        public static VectorB4 Y_XX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.x); }
        public static VectorB4 Y_XY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.y); }
        public static VectorB4 Y_XZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.z); }
        public static VectorB4 Y_XW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.x, V.w); }
        public static VectorB4 Y_X_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.x, 0); }
        public static VectorB4 Y_YX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.x); }
        public static VectorB4 Y_YY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.y); }
        public static VectorB4 Y_YZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.z); }
        public static VectorB4 Y_YW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.y, V.w); }
        public static VectorB4 Y_Y_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.y, 0); }
        public static VectorB4 Y_ZX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.x); }
        public static VectorB4 Y_ZY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.y); }
        public static VectorB4 Y_ZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.z); }
        public static VectorB4 Y_ZW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.z, V.w); }
        public static VectorB4 Y_Z_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.z, 0); }
        public static VectorB4 Y_WX(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.w, V.x); }
        public static VectorB4 Y_WY(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.w, V.y); }
        public static VectorB4 Y_WZ(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.w, V.z); }
        public static VectorB4 Y_WW(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.w, V.w); }
        public static VectorB4 Y_W_(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, V.w, 0); }
        public static VectorB4 Y__X(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.x); }
        public static VectorB4 Y__Y(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.y); }
        public static VectorB4 Y__Z(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.z); }
        public static VectorB4 Y__W(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, 0, V.w); }
        public static VectorB4 Y___(this VectorB4 V){ return VecOps.MkVectorB4(V.y, 0, 0, 0); }
        public static VectorB4 ZXXX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.x); }
        public static VectorB4 ZXXY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.y); }
        public static VectorB4 ZXXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.z); }
        public static VectorB4 ZXXW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, V.w); }
        public static VectorB4 ZXX_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.x, 0); }
        public static VectorB4 ZXYX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.x); }
        public static VectorB4 ZXYY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.y); }
        public static VectorB4 ZXYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.z); }
        public static VectorB4 ZXYW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, V.w); }
        public static VectorB4 ZXY_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.y, 0); }
        public static VectorB4 ZXZX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.x); }
        public static VectorB4 ZXZY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.y); }
        public static VectorB4 ZXZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.z); }
        public static VectorB4 ZXZW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, V.w); }
        public static VectorB4 ZXZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.z, 0); }
        public static VectorB4 ZXWX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.w, V.x); }
        public static VectorB4 ZXWY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.w, V.y); }
        public static VectorB4 ZXWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.w, V.z); }
        public static VectorB4 ZXWW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.w, V.w); }
        public static VectorB4 ZXW_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, V.w, 0); }
        public static VectorB4 ZX_X(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.x); }
        public static VectorB4 ZX_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.y); }
        public static VectorB4 ZX_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.z); }
        public static VectorB4 ZX_W(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, 0, V.w); }
        public static VectorB4 ZX__(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.x, 0, 0); }
        public static VectorB4 ZYXX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.x); }
        public static VectorB4 ZYXY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.y); }
        public static VectorB4 ZYXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.z); }
        public static VectorB4 ZYXW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, V.w); }
        public static VectorB4 ZYX_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.x, 0); }
        public static VectorB4 ZYYX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.x); }
        public static VectorB4 ZYYY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.y); }
        public static VectorB4 ZYYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.z); }
        public static VectorB4 ZYYW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, V.w); }
        public static VectorB4 ZYY_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.y, 0); }
        public static VectorB4 ZYZX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.x); }
        public static VectorB4 ZYZY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.y); }
        public static VectorB4 ZYZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.z); }
        public static VectorB4 ZYZW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, V.w); }
        public static VectorB4 ZYZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.z, 0); }
        public static VectorB4 ZYWX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.w, V.x); }
        public static VectorB4 ZYWY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.w, V.y); }
        public static VectorB4 ZYWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.w, V.z); }
        public static VectorB4 ZYWW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.w, V.w); }
        public static VectorB4 ZYW_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, V.w, 0); }
        public static VectorB4 ZY_X(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.x); }
        public static VectorB4 ZY_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.y); }
        public static VectorB4 ZY_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.z); }
        public static VectorB4 ZY_W(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, 0, V.w); }
        public static VectorB4 ZY__(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.y, 0, 0); }
        public static VectorB4 ZZXX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.x); }
        public static VectorB4 ZZXY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.y); }
        public static VectorB4 ZZXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.z); }
        public static VectorB4 ZZXW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, V.w); }
        public static VectorB4 ZZX_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.x, 0); }
        public static VectorB4 ZZYX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.x); }
        public static VectorB4 ZZYY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.y); }
        public static VectorB4 ZZYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.z); }
        public static VectorB4 ZZYW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, V.w); }
        public static VectorB4 ZZY_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.y, 0); }
        public static VectorB4 ZZZX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.x); }
        public static VectorB4 ZZZY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.y); }
        public static VectorB4 ZZZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.z); }
        public static VectorB4 ZZZW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, V.w); }
        public static VectorB4 ZZZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.z, 0); }
        public static VectorB4 ZZWX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.w, V.x); }
        public static VectorB4 ZZWY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.w, V.y); }
        public static VectorB4 ZZWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.w, V.z); }
        public static VectorB4 ZZWW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.w, V.w); }
        public static VectorB4 ZZW_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, V.w, 0); }
        public static VectorB4 ZZ_X(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.x); }
        public static VectorB4 ZZ_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.y); }
        public static VectorB4 ZZ_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.z); }
        public static VectorB4 ZZ_W(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, 0, V.w); }
        public static VectorB4 ZZ__(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.z, 0, 0); }
        public static VectorB4 ZWXX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.x, V.x); }
        public static VectorB4 ZWXY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.x, V.y); }
        public static VectorB4 ZWXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.x, V.z); }
        public static VectorB4 ZWXW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.x, V.w); }
        public static VectorB4 ZWX_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.x, 0); }
        public static VectorB4 ZWYX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.y, V.x); }
        public static VectorB4 ZWYY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.y, V.y); }
        public static VectorB4 ZWYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.y, V.z); }
        public static VectorB4 ZWYW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.y, V.w); }
        public static VectorB4 ZWY_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.y, 0); }
        public static VectorB4 ZWZX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.z, V.x); }
        public static VectorB4 ZWZY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.z, V.y); }
        public static VectorB4 ZWZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.z, V.z); }
        public static VectorB4 ZWZW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.z, V.w); }
        public static VectorB4 ZWZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.z, 0); }
        public static VectorB4 ZWWX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.w, V.x); }
        public static VectorB4 ZWWY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.w, V.y); }
        public static VectorB4 ZWWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.w, V.z); }
        public static VectorB4 ZWWW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.w, V.w); }
        public static VectorB4 ZWW_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, V.w, 0); }
        public static VectorB4 ZW_X(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, 0, V.x); }
        public static VectorB4 ZW_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, 0, V.y); }
        public static VectorB4 ZW_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, 0, V.z); }
        public static VectorB4 ZW_W(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, 0, V.w); }
        public static VectorB4 ZW__(this VectorB4 V){ return VecOps.MkVectorB4(V.z, V.w, 0, 0); }
        public static VectorB4 Z_XX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.x); }
        public static VectorB4 Z_XY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.y); }
        public static VectorB4 Z_XZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.z); }
        public static VectorB4 Z_XW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.x, V.w); }
        public static VectorB4 Z_X_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.x, 0); }
        public static VectorB4 Z_YX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.x); }
        public static VectorB4 Z_YY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.y); }
        public static VectorB4 Z_YZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.z); }
        public static VectorB4 Z_YW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.y, V.w); }
        public static VectorB4 Z_Y_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.y, 0); }
        public static VectorB4 Z_ZX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.x); }
        public static VectorB4 Z_ZY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.y); }
        public static VectorB4 Z_ZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.z); }
        public static VectorB4 Z_ZW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.z, V.w); }
        public static VectorB4 Z_Z_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.z, 0); }
        public static VectorB4 Z_WX(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.w, V.x); }
        public static VectorB4 Z_WY(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.w, V.y); }
        public static VectorB4 Z_WZ(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.w, V.z); }
        public static VectorB4 Z_WW(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.w, V.w); }
        public static VectorB4 Z_W_(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, V.w, 0); }
        public static VectorB4 Z__X(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.x); }
        public static VectorB4 Z__Y(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.y); }
        public static VectorB4 Z__Z(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.z); }
        public static VectorB4 Z__W(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, 0, V.w); }
        public static VectorB4 Z___(this VectorB4 V){ return VecOps.MkVectorB4(V.z, 0, 0, 0); }
        public static VectorB4 WXXX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.x, V.x); }
        public static VectorB4 WXXY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.x, V.y); }
        public static VectorB4 WXXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.x, V.z); }
        public static VectorB4 WXXW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.x, V.w); }
        public static VectorB4 WXX_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.x, 0); }
        public static VectorB4 WXYX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.y, V.x); }
        public static VectorB4 WXYY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.y, V.y); }
        public static VectorB4 WXYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.y, V.z); }
        public static VectorB4 WXYW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.y, V.w); }
        public static VectorB4 WXY_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.y, 0); }
        public static VectorB4 WXZX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.z, V.x); }
        public static VectorB4 WXZY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.z, V.y); }
        public static VectorB4 WXZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.z, V.z); }
        public static VectorB4 WXZW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.z, V.w); }
        public static VectorB4 WXZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.z, 0); }
        public static VectorB4 WXWX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.w, V.x); }
        public static VectorB4 WXWY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.w, V.y); }
        public static VectorB4 WXWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.w, V.z); }
        public static VectorB4 WXWW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.w, V.w); }
        public static VectorB4 WXW_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, V.w, 0); }
        public static VectorB4 WX_X(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, 0, V.x); }
        public static VectorB4 WX_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, 0, V.y); }
        public static VectorB4 WX_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, 0, V.z); }
        public static VectorB4 WX_W(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, 0, V.w); }
        public static VectorB4 WX__(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.x, 0, 0); }
        public static VectorB4 WYXX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.x, V.x); }
        public static VectorB4 WYXY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.x, V.y); }
        public static VectorB4 WYXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.x, V.z); }
        public static VectorB4 WYXW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.x, V.w); }
        public static VectorB4 WYX_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.x, 0); }
        public static VectorB4 WYYX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.y, V.x); }
        public static VectorB4 WYYY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.y, V.y); }
        public static VectorB4 WYYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.y, V.z); }
        public static VectorB4 WYYW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.y, V.w); }
        public static VectorB4 WYY_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.y, 0); }
        public static VectorB4 WYZX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.z, V.x); }
        public static VectorB4 WYZY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.z, V.y); }
        public static VectorB4 WYZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.z, V.z); }
        public static VectorB4 WYZW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.z, V.w); }
        public static VectorB4 WYZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.z, 0); }
        public static VectorB4 WYWX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.w, V.x); }
        public static VectorB4 WYWY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.w, V.y); }
        public static VectorB4 WYWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.w, V.z); }
        public static VectorB4 WYWW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.w, V.w); }
        public static VectorB4 WYW_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, V.w, 0); }
        public static VectorB4 WY_X(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, 0, V.x); }
        public static VectorB4 WY_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, 0, V.y); }
        public static VectorB4 WY_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, 0, V.z); }
        public static VectorB4 WY_W(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, 0, V.w); }
        public static VectorB4 WY__(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.y, 0, 0); }
        public static VectorB4 WZXX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.x, V.x); }
        public static VectorB4 WZXY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.x, V.y); }
        public static VectorB4 WZXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.x, V.z); }
        public static VectorB4 WZXW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.x, V.w); }
        public static VectorB4 WZX_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.x, 0); }
        public static VectorB4 WZYX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.y, V.x); }
        public static VectorB4 WZYY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.y, V.y); }
        public static VectorB4 WZYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.y, V.z); }
        public static VectorB4 WZYW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.y, V.w); }
        public static VectorB4 WZY_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.y, 0); }
        public static VectorB4 WZZX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.z, V.x); }
        public static VectorB4 WZZY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.z, V.y); }
        public static VectorB4 WZZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.z, V.z); }
        public static VectorB4 WZZW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.z, V.w); }
        public static VectorB4 WZZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.z, 0); }
        public static VectorB4 WZWX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.w, V.x); }
        public static VectorB4 WZWY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.w, V.y); }
        public static VectorB4 WZWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.w, V.z); }
        public static VectorB4 WZWW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.w, V.w); }
        public static VectorB4 WZW_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, V.w, 0); }
        public static VectorB4 WZ_X(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, 0, V.x); }
        public static VectorB4 WZ_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, 0, V.y); }
        public static VectorB4 WZ_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, 0, V.z); }
        public static VectorB4 WZ_W(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, 0, V.w); }
        public static VectorB4 WZ__(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.z, 0, 0); }
        public static VectorB4 WWXX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.x, V.x); }
        public static VectorB4 WWXY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.x, V.y); }
        public static VectorB4 WWXZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.x, V.z); }
        public static VectorB4 WWXW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.x, V.w); }
        public static VectorB4 WWX_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.x, 0); }
        public static VectorB4 WWYX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.y, V.x); }
        public static VectorB4 WWYY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.y, V.y); }
        public static VectorB4 WWYZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.y, V.z); }
        public static VectorB4 WWYW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.y, V.w); }
        public static VectorB4 WWY_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.y, 0); }
        public static VectorB4 WWZX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.z, V.x); }
        public static VectorB4 WWZY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.z, V.y); }
        public static VectorB4 WWZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.z, V.z); }
        public static VectorB4 WWZW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.z, V.w); }
        public static VectorB4 WWZ_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.z, 0); }
        public static VectorB4 WWWX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.w, V.x); }
        public static VectorB4 WWWY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.w, V.y); }
        public static VectorB4 WWWZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.w, V.z); }
        public static VectorB4 WWWW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.w, V.w); }
        public static VectorB4 WWW_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, V.w, 0); }
        public static VectorB4 WW_X(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, 0, V.x); }
        public static VectorB4 WW_Y(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, 0, V.y); }
        public static VectorB4 WW_Z(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, 0, V.z); }
        public static VectorB4 WW_W(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, 0, V.w); }
        public static VectorB4 WW__(this VectorB4 V){ return VecOps.MkVectorB4(V.w, V.w, 0, 0); }
        public static VectorB4 W_XX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.x, V.x); }
        public static VectorB4 W_XY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.x, V.y); }
        public static VectorB4 W_XZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.x, V.z); }
        public static VectorB4 W_XW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.x, V.w); }
        public static VectorB4 W_X_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.x, 0); }
        public static VectorB4 W_YX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.y, V.x); }
        public static VectorB4 W_YY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.y, V.y); }
        public static VectorB4 W_YZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.y, V.z); }
        public static VectorB4 W_YW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.y, V.w); }
        public static VectorB4 W_Y_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.y, 0); }
        public static VectorB4 W_ZX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.z, V.x); }
        public static VectorB4 W_ZY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.z, V.y); }
        public static VectorB4 W_ZZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.z, V.z); }
        public static VectorB4 W_ZW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.z, V.w); }
        public static VectorB4 W_Z_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.z, 0); }
        public static VectorB4 W_WX(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.w, V.x); }
        public static VectorB4 W_WY(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.w, V.y); }
        public static VectorB4 W_WZ(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.w, V.z); }
        public static VectorB4 W_WW(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.w, V.w); }
        public static VectorB4 W_W_(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, V.w, 0); }
        public static VectorB4 W__X(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, 0, V.x); }
        public static VectorB4 W__Y(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, 0, V.y); }
        public static VectorB4 W__Z(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, 0, V.z); }
        public static VectorB4 W__W(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, 0, V.w); }
        public static VectorB4 W___(this VectorB4 V){ return VecOps.MkVectorB4(V.w, 0, 0, 0); }
        public static VectorB4 _XXX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.x); }
        public static VectorB4 _XXY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.y); }
        public static VectorB4 _XXZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.z); }
        public static VectorB4 _XXW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.x, V.w); }
        public static VectorB4 _XX_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.x, 0); }
        public static VectorB4 _XYX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.x); }
        public static VectorB4 _XYY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.y); }
        public static VectorB4 _XYZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.z); }
        public static VectorB4 _XYW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.y, V.w); }
        public static VectorB4 _XY_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.y, 0); }
        public static VectorB4 _XZX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.x); }
        public static VectorB4 _XZY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.y); }
        public static VectorB4 _XZZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.z); }
        public static VectorB4 _XZW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.z, V.w); }
        public static VectorB4 _XZ_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.z, 0); }
        public static VectorB4 _XWX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.w, V.x); }
        public static VectorB4 _XWY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.w, V.y); }
        public static VectorB4 _XWZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.w, V.z); }
        public static VectorB4 _XWW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.w, V.w); }
        public static VectorB4 _XW_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, V.w, 0); }
        public static VectorB4 _X_X(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, 0, V.x); }
        public static VectorB4 _X_Y(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, 0, V.y); }
        public static VectorB4 _X_Z(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, 0, V.z); }
        public static VectorB4 _X_W(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, 0, V.w); }
        public static VectorB4 _X__(this VectorB4 V){ return VecOps.MkVectorB4(0, V.x, 0, 0); }
        public static VectorB4 _YXX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.x); }
        public static VectorB4 _YXY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.y); }
        public static VectorB4 _YXZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.z); }
        public static VectorB4 _YXW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.x, V.w); }
        public static VectorB4 _YX_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.x, 0); }
        public static VectorB4 _YYX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.x); }
        public static VectorB4 _YYY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.y); }
        public static VectorB4 _YYZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.z); }
        public static VectorB4 _YYW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.y, V.w); }
        public static VectorB4 _YY_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.y, 0); }
        public static VectorB4 _YZX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.x); }
        public static VectorB4 _YZY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.y); }
        public static VectorB4 _YZZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.z); }
        public static VectorB4 _YZW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.z, V.w); }
        public static VectorB4 _YZ_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.z, 0); }
        public static VectorB4 _YWX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.w, V.x); }
        public static VectorB4 _YWY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.w, V.y); }
        public static VectorB4 _YWZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.w, V.z); }
        public static VectorB4 _YWW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.w, V.w); }
        public static VectorB4 _YW_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, V.w, 0); }
        public static VectorB4 _Y_X(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, 0, V.x); }
        public static VectorB4 _Y_Y(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, 0, V.y); }
        public static VectorB4 _Y_Z(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, 0, V.z); }
        public static VectorB4 _Y_W(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, 0, V.w); }
        public static VectorB4 _Y__(this VectorB4 V){ return VecOps.MkVectorB4(0, V.y, 0, 0); }
        public static VectorB4 _ZXX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.x); }
        public static VectorB4 _ZXY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.y); }
        public static VectorB4 _ZXZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.z); }
        public static VectorB4 _ZXW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.x, V.w); }
        public static VectorB4 _ZX_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.x, 0); }
        public static VectorB4 _ZYX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.x); }
        public static VectorB4 _ZYY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.y); }
        public static VectorB4 _ZYZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.z); }
        public static VectorB4 _ZYW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.y, V.w); }
        public static VectorB4 _ZY_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.y, 0); }
        public static VectorB4 _ZZX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.x); }
        public static VectorB4 _ZZY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.y); }
        public static VectorB4 _ZZZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.z); }
        public static VectorB4 _ZZW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.z, V.w); }
        public static VectorB4 _ZZ_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.z, 0); }
        public static VectorB4 _ZWX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.w, V.x); }
        public static VectorB4 _ZWY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.w, V.y); }
        public static VectorB4 _ZWZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.w, V.z); }
        public static VectorB4 _ZWW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.w, V.w); }
        public static VectorB4 _ZW_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, V.w, 0); }
        public static VectorB4 _Z_X(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, 0, V.x); }
        public static VectorB4 _Z_Y(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, 0, V.y); }
        public static VectorB4 _Z_Z(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, 0, V.z); }
        public static VectorB4 _Z_W(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, 0, V.w); }
        public static VectorB4 _Z__(this VectorB4 V){ return VecOps.MkVectorB4(0, V.z, 0, 0); }
        public static VectorB4 _WXX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.x, V.x); }
        public static VectorB4 _WXY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.x, V.y); }
        public static VectorB4 _WXZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.x, V.z); }
        public static VectorB4 _WXW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.x, V.w); }
        public static VectorB4 _WX_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.x, 0); }
        public static VectorB4 _WYX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.y, V.x); }
        public static VectorB4 _WYY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.y, V.y); }
        public static VectorB4 _WYZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.y, V.z); }
        public static VectorB4 _WYW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.y, V.w); }
        public static VectorB4 _WY_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.y, 0); }
        public static VectorB4 _WZX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.z, V.x); }
        public static VectorB4 _WZY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.z, V.y); }
        public static VectorB4 _WZZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.z, V.z); }
        public static VectorB4 _WZW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.z, V.w); }
        public static VectorB4 _WZ_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.z, 0); }
        public static VectorB4 _WWX(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.w, V.x); }
        public static VectorB4 _WWY(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.w, V.y); }
        public static VectorB4 _WWZ(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.w, V.z); }
        public static VectorB4 _WWW(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.w, V.w); }
        public static VectorB4 _WW_(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, V.w, 0); }
        public static VectorB4 _W_X(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, 0, V.x); }
        public static VectorB4 _W_Y(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, 0, V.y); }
        public static VectorB4 _W_Z(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, 0, V.z); }
        public static VectorB4 _W_W(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, 0, V.w); }
        public static VectorB4 _W__(this VectorB4 V){ return VecOps.MkVectorB4(0, V.w, 0, 0); }
        public static VectorB4 __XX(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.x, V.x); }
        public static VectorB4 __XY(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.x, V.y); }
        public static VectorB4 __XZ(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.x, V.z); }
        public static VectorB4 __XW(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.x, V.w); }
        public static VectorB4 __X_(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.x, 0); }
        public static VectorB4 __YX(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.y, V.x); }
        public static VectorB4 __YY(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.y, V.y); }
        public static VectorB4 __YZ(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.y, V.z); }
        public static VectorB4 __YW(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.y, V.w); }
        public static VectorB4 __Y_(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.y, 0); }
        public static VectorB4 __ZX(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.z, V.x); }
        public static VectorB4 __ZY(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.z, V.y); }
        public static VectorB4 __ZZ(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.z, V.z); }
        public static VectorB4 __ZW(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.z, V.w); }
        public static VectorB4 __Z_(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.z, 0); }
        public static VectorB4 __WX(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.w, V.x); }
        public static VectorB4 __WY(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.w, V.y); }
        public static VectorB4 __WZ(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.w, V.z); }
        public static VectorB4 __WW(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.w, V.w); }
        public static VectorB4 __W_(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, V.w, 0); }
        public static VectorB4 ___X(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, 0, V.x); }
        public static VectorB4 ___Y(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, 0, V.y); }
        public static VectorB4 ___Z(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, 0, V.z); }
        public static VectorB4 ___W(this VectorB4 V){ return VecOps.MkVectorB4(0, 0, 0, V.w); }
        public static Vector2 XX(this Vector2 V){ return VecOps.MkVector2(V.x, V.x); }
        public static Vector2 XY(this Vector2 V){ return VecOps.MkVector2(V.x, V.y); }
        public static Vector2 X_(this Vector2 V){ return VecOps.MkVector2(V.x, 0); }
        public static Vector2 YX(this Vector2 V){ return VecOps.MkVector2(V.y, V.x); }
        public static Vector2 YY(this Vector2 V){ return VecOps.MkVector2(V.y, V.y); }
        public static Vector2 Y_(this Vector2 V){ return VecOps.MkVector2(V.y, 0); }
        public static Vector2 _X(this Vector2 V){ return VecOps.MkVector2(0, V.x); }
        public static Vector2 _Y(this Vector2 V){ return VecOps.MkVector2(0, V.y); }
        public static Vector3 XXX(this Vector2 V){ return VecOps.MkVector3(V.x, V.x, V.x); }
        public static Vector3 XXY(this Vector2 V){ return VecOps.MkVector3(V.x, V.x, V.y); }
        public static Vector3 XX_(this Vector2 V){ return VecOps.MkVector3(V.x, V.x, 0); }
        public static Vector3 XYX(this Vector2 V){ return VecOps.MkVector3(V.x, V.y, V.x); }
        public static Vector3 XYY(this Vector2 V){ return VecOps.MkVector3(V.x, V.y, V.y); }
        public static Vector3 XY_(this Vector2 V){ return VecOps.MkVector3(V.x, V.y, 0); }
        public static Vector3 X_X(this Vector2 V){ return VecOps.MkVector3(V.x, 0, V.x); }
        public static Vector3 X_Y(this Vector2 V){ return VecOps.MkVector3(V.x, 0, V.y); }
        public static Vector3 X__(this Vector2 V){ return VecOps.MkVector3(V.x, 0, 0); }
        public static Vector3 YXX(this Vector2 V){ return VecOps.MkVector3(V.y, V.x, V.x); }
        public static Vector3 YXY(this Vector2 V){ return VecOps.MkVector3(V.y, V.x, V.y); }
        public static Vector3 YX_(this Vector2 V){ return VecOps.MkVector3(V.y, V.x, 0); }
        public static Vector3 YYX(this Vector2 V){ return VecOps.MkVector3(V.y, V.y, V.x); }
        public static Vector3 YYY(this Vector2 V){ return VecOps.MkVector3(V.y, V.y, V.y); }
        public static Vector3 YY_(this Vector2 V){ return VecOps.MkVector3(V.y, V.y, 0); }
        public static Vector3 Y_X(this Vector2 V){ return VecOps.MkVector3(V.y, 0, V.x); }
        public static Vector3 Y_Y(this Vector2 V){ return VecOps.MkVector3(V.y, 0, V.y); }
        public static Vector3 Y__(this Vector2 V){ return VecOps.MkVector3(V.y, 0, 0); }
        public static Vector3 _XX(this Vector2 V){ return VecOps.MkVector3(0, V.x, V.x); }
        public static Vector3 _XY(this Vector2 V){ return VecOps.MkVector3(0, V.x, V.y); }
        public static Vector3 _X_(this Vector2 V){ return VecOps.MkVector3(0, V.x, 0); }
        public static Vector3 _YX(this Vector2 V){ return VecOps.MkVector3(0, V.y, V.x); }
        public static Vector3 _YY(this Vector2 V){ return VecOps.MkVector3(0, V.y, V.y); }
        public static Vector3 _Y_(this Vector2 V){ return VecOps.MkVector3(0, V.y, 0); }
        public static Vector3 __X(this Vector2 V){ return VecOps.MkVector3(0, 0, V.x); }
        public static Vector3 __Y(this Vector2 V){ return VecOps.MkVector3(0, 0, V.y); }
        public static Vector4 XXXX(this Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.x); }
        public static Vector4 XXXY(this Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.y); }
        public static Vector4 XXX_(this Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.x, 0); }
        public static Vector4 XXYX(this Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.x); }
        public static Vector4 XXYY(this Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.y); }
        public static Vector4 XXY_(this Vector2 V){ return VecOps.MkVector4(V.x, V.x, V.y, 0); }
        public static Vector4 XX_X(this Vector2 V){ return VecOps.MkVector4(V.x, V.x, 0, V.x); }
        public static Vector4 XX_Y(this Vector2 V){ return VecOps.MkVector4(V.x, V.x, 0, V.y); }
        public static Vector4 XX__(this Vector2 V){ return VecOps.MkVector4(V.x, V.x, 0, 0); }
        public static Vector4 XYXX(this Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.x); }
        public static Vector4 XYXY(this Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.y); }
        public static Vector4 XYX_(this Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.x, 0); }
        public static Vector4 XYYX(this Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.x); }
        public static Vector4 XYYY(this Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.y); }
        public static Vector4 XYY_(this Vector2 V){ return VecOps.MkVector4(V.x, V.y, V.y, 0); }
        public static Vector4 XY_X(this Vector2 V){ return VecOps.MkVector4(V.x, V.y, 0, V.x); }
        public static Vector4 XY_Y(this Vector2 V){ return VecOps.MkVector4(V.x, V.y, 0, V.y); }
        public static Vector4 XY__(this Vector2 V){ return VecOps.MkVector4(V.x, V.y, 0, 0); }
        public static Vector4 X_XX(this Vector2 V){ return VecOps.MkVector4(V.x, 0, V.x, V.x); }
        public static Vector4 X_XY(this Vector2 V){ return VecOps.MkVector4(V.x, 0, V.x, V.y); }
        public static Vector4 X_X_(this Vector2 V){ return VecOps.MkVector4(V.x, 0, V.x, 0); }
        public static Vector4 X_YX(this Vector2 V){ return VecOps.MkVector4(V.x, 0, V.y, V.x); }
        public static Vector4 X_YY(this Vector2 V){ return VecOps.MkVector4(V.x, 0, V.y, V.y); }
        public static Vector4 X_Y_(this Vector2 V){ return VecOps.MkVector4(V.x, 0, V.y, 0); }
        public static Vector4 X__X(this Vector2 V){ return VecOps.MkVector4(V.x, 0, 0, V.x); }
        public static Vector4 X__Y(this Vector2 V){ return VecOps.MkVector4(V.x, 0, 0, V.y); }
        public static Vector4 X___(this Vector2 V){ return VecOps.MkVector4(V.x, 0, 0, 0); }
        public static Vector4 YXXX(this Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.x); }
        public static Vector4 YXXY(this Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.y); }
        public static Vector4 YXX_(this Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.x, 0); }
        public static Vector4 YXYX(this Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.x); }
        public static Vector4 YXYY(this Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.y); }
        public static Vector4 YXY_(this Vector2 V){ return VecOps.MkVector4(V.y, V.x, V.y, 0); }
        public static Vector4 YX_X(this Vector2 V){ return VecOps.MkVector4(V.y, V.x, 0, V.x); }
        public static Vector4 YX_Y(this Vector2 V){ return VecOps.MkVector4(V.y, V.x, 0, V.y); }
        public static Vector4 YX__(this Vector2 V){ return VecOps.MkVector4(V.y, V.x, 0, 0); }
        public static Vector4 YYXX(this Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.x); }
        public static Vector4 YYXY(this Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.y); }
        public static Vector4 YYX_(this Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.x, 0); }
        public static Vector4 YYYX(this Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.x); }
        public static Vector4 YYYY(this Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.y); }
        public static Vector4 YYY_(this Vector2 V){ return VecOps.MkVector4(V.y, V.y, V.y, 0); }
        public static Vector4 YY_X(this Vector2 V){ return VecOps.MkVector4(V.y, V.y, 0, V.x); }
        public static Vector4 YY_Y(this Vector2 V){ return VecOps.MkVector4(V.y, V.y, 0, V.y); }
        public static Vector4 YY__(this Vector2 V){ return VecOps.MkVector4(V.y, V.y, 0, 0); }
        public static Vector4 Y_XX(this Vector2 V){ return VecOps.MkVector4(V.y, 0, V.x, V.x); }
        public static Vector4 Y_XY(this Vector2 V){ return VecOps.MkVector4(V.y, 0, V.x, V.y); }
        public static Vector4 Y_X_(this Vector2 V){ return VecOps.MkVector4(V.y, 0, V.x, 0); }
        public static Vector4 Y_YX(this Vector2 V){ return VecOps.MkVector4(V.y, 0, V.y, V.x); }
        public static Vector4 Y_YY(this Vector2 V){ return VecOps.MkVector4(V.y, 0, V.y, V.y); }
        public static Vector4 Y_Y_(this Vector2 V){ return VecOps.MkVector4(V.y, 0, V.y, 0); }
        public static Vector4 Y__X(this Vector2 V){ return VecOps.MkVector4(V.y, 0, 0, V.x); }
        public static Vector4 Y__Y(this Vector2 V){ return VecOps.MkVector4(V.y, 0, 0, V.y); }
        public static Vector4 Y___(this Vector2 V){ return VecOps.MkVector4(V.y, 0, 0, 0); }
        public static Vector4 _XXX(this Vector2 V){ return VecOps.MkVector4(0, V.x, V.x, V.x); }
        public static Vector4 _XXY(this Vector2 V){ return VecOps.MkVector4(0, V.x, V.x, V.y); }
        public static Vector4 _XX_(this Vector2 V){ return VecOps.MkVector4(0, V.x, V.x, 0); }
        public static Vector4 _XYX(this Vector2 V){ return VecOps.MkVector4(0, V.x, V.y, V.x); }
        public static Vector4 _XYY(this Vector2 V){ return VecOps.MkVector4(0, V.x, V.y, V.y); }
        public static Vector4 _XY_(this Vector2 V){ return VecOps.MkVector4(0, V.x, V.y, 0); }
        public static Vector4 _X_X(this Vector2 V){ return VecOps.MkVector4(0, V.x, 0, V.x); }
        public static Vector4 _X_Y(this Vector2 V){ return VecOps.MkVector4(0, V.x, 0, V.y); }
        public static Vector4 _X__(this Vector2 V){ return VecOps.MkVector4(0, V.x, 0, 0); }
        public static Vector4 _YXX(this Vector2 V){ return VecOps.MkVector4(0, V.y, V.x, V.x); }
        public static Vector4 _YXY(this Vector2 V){ return VecOps.MkVector4(0, V.y, V.x, V.y); }
        public static Vector4 _YX_(this Vector2 V){ return VecOps.MkVector4(0, V.y, V.x, 0); }
        public static Vector4 _YYX(this Vector2 V){ return VecOps.MkVector4(0, V.y, V.y, V.x); }
        public static Vector4 _YYY(this Vector2 V){ return VecOps.MkVector4(0, V.y, V.y, V.y); }
        public static Vector4 _YY_(this Vector2 V){ return VecOps.MkVector4(0, V.y, V.y, 0); }
        public static Vector4 _Y_X(this Vector2 V){ return VecOps.MkVector4(0, V.y, 0, V.x); }
        public static Vector4 _Y_Y(this Vector2 V){ return VecOps.MkVector4(0, V.y, 0, V.y); }
        public static Vector4 _Y__(this Vector2 V){ return VecOps.MkVector4(0, V.y, 0, 0); }
        public static Vector4 __XX(this Vector2 V){ return VecOps.MkVector4(0, 0, V.x, V.x); }
        public static Vector4 __XY(this Vector2 V){ return VecOps.MkVector4(0, 0, V.x, V.y); }
        public static Vector4 __X_(this Vector2 V){ return VecOps.MkVector4(0, 0, V.x, 0); }
        public static Vector4 __YX(this Vector2 V){ return VecOps.MkVector4(0, 0, V.y, V.x); }
        public static Vector4 __YY(this Vector2 V){ return VecOps.MkVector4(0, 0, V.y, V.y); }
        public static Vector4 __Y_(this Vector2 V){ return VecOps.MkVector4(0, 0, V.y, 0); }
        public static Vector4 ___X(this Vector2 V){ return VecOps.MkVector4(0, 0, 0, V.x); }
        public static Vector4 ___Y(this Vector2 V){ return VecOps.MkVector4(0, 0, 0, V.y); }
        public static Vector2 XX(this Vector3 V){ return VecOps.MkVector2(V.x, V.x); }
        public static Vector2 XY(this Vector3 V){ return VecOps.MkVector2(V.x, V.y); }
        public static Vector2 XZ(this Vector3 V){ return VecOps.MkVector2(V.x, V.z); }
        public static Vector2 X_(this Vector3 V){ return VecOps.MkVector2(V.x, 0); }
        public static Vector2 YX(this Vector3 V){ return VecOps.MkVector2(V.y, V.x); }
        public static Vector2 YY(this Vector3 V){ return VecOps.MkVector2(V.y, V.y); }
        public static Vector2 YZ(this Vector3 V){ return VecOps.MkVector2(V.y, V.z); }
        public static Vector2 Y_(this Vector3 V){ return VecOps.MkVector2(V.y, 0); }
        public static Vector2 ZX(this Vector3 V){ return VecOps.MkVector2(V.z, V.x); }
        public static Vector2 ZY(this Vector3 V){ return VecOps.MkVector2(V.z, V.y); }
        public static Vector2 ZZ(this Vector3 V){ return VecOps.MkVector2(V.z, V.z); }
        public static Vector2 Z_(this Vector3 V){ return VecOps.MkVector2(V.z, 0); }
        public static Vector2 _X(this Vector3 V){ return VecOps.MkVector2(0, V.x); }
        public static Vector2 _Y(this Vector3 V){ return VecOps.MkVector2(0, V.y); }
        public static Vector2 _Z(this Vector3 V){ return VecOps.MkVector2(0, V.z); }
        public static Vector3 XXX(this Vector3 V){ return VecOps.MkVector3(V.x, V.x, V.x); }
        public static Vector3 XXY(this Vector3 V){ return VecOps.MkVector3(V.x, V.x, V.y); }
        public static Vector3 XXZ(this Vector3 V){ return VecOps.MkVector3(V.x, V.x, V.z); }
        public static Vector3 XX_(this Vector3 V){ return VecOps.MkVector3(V.x, V.x, 0); }
        public static Vector3 XYX(this Vector3 V){ return VecOps.MkVector3(V.x, V.y, V.x); }
        public static Vector3 XYY(this Vector3 V){ return VecOps.MkVector3(V.x, V.y, V.y); }
        public static Vector3 XYZ(this Vector3 V){ return VecOps.MkVector3(V.x, V.y, V.z); }
        public static Vector3 XY_(this Vector3 V){ return VecOps.MkVector3(V.x, V.y, 0); }
        public static Vector3 XZX(this Vector3 V){ return VecOps.MkVector3(V.x, V.z, V.x); }
        public static Vector3 XZY(this Vector3 V){ return VecOps.MkVector3(V.x, V.z, V.y); }
        public static Vector3 XZZ(this Vector3 V){ return VecOps.MkVector3(V.x, V.z, V.z); }
        public static Vector3 XZ_(this Vector3 V){ return VecOps.MkVector3(V.x, V.z, 0); }
        public static Vector3 X_X(this Vector3 V){ return VecOps.MkVector3(V.x, 0, V.x); }
        public static Vector3 X_Y(this Vector3 V){ return VecOps.MkVector3(V.x, 0, V.y); }
        public static Vector3 X_Z(this Vector3 V){ return VecOps.MkVector3(V.x, 0, V.z); }
        public static Vector3 X__(this Vector3 V){ return VecOps.MkVector3(V.x, 0, 0); }
        public static Vector3 YXX(this Vector3 V){ return VecOps.MkVector3(V.y, V.x, V.x); }
        public static Vector3 YXY(this Vector3 V){ return VecOps.MkVector3(V.y, V.x, V.y); }
        public static Vector3 YXZ(this Vector3 V){ return VecOps.MkVector3(V.y, V.x, V.z); }
        public static Vector3 YX_(this Vector3 V){ return VecOps.MkVector3(V.y, V.x, 0); }
        public static Vector3 YYX(this Vector3 V){ return VecOps.MkVector3(V.y, V.y, V.x); }
        public static Vector3 YYY(this Vector3 V){ return VecOps.MkVector3(V.y, V.y, V.y); }
        public static Vector3 YYZ(this Vector3 V){ return VecOps.MkVector3(V.y, V.y, V.z); }
        public static Vector3 YY_(this Vector3 V){ return VecOps.MkVector3(V.y, V.y, 0); }
        public static Vector3 YZX(this Vector3 V){ return VecOps.MkVector3(V.y, V.z, V.x); }
        public static Vector3 YZY(this Vector3 V){ return VecOps.MkVector3(V.y, V.z, V.y); }
        public static Vector3 YZZ(this Vector3 V){ return VecOps.MkVector3(V.y, V.z, V.z); }
        public static Vector3 YZ_(this Vector3 V){ return VecOps.MkVector3(V.y, V.z, 0); }
        public static Vector3 Y_X(this Vector3 V){ return VecOps.MkVector3(V.y, 0, V.x); }
        public static Vector3 Y_Y(this Vector3 V){ return VecOps.MkVector3(V.y, 0, V.y); }
        public static Vector3 Y_Z(this Vector3 V){ return VecOps.MkVector3(V.y, 0, V.z); }
        public static Vector3 Y__(this Vector3 V){ return VecOps.MkVector3(V.y, 0, 0); }
        public static Vector3 ZXX(this Vector3 V){ return VecOps.MkVector3(V.z, V.x, V.x); }
        public static Vector3 ZXY(this Vector3 V){ return VecOps.MkVector3(V.z, V.x, V.y); }
        public static Vector3 ZXZ(this Vector3 V){ return VecOps.MkVector3(V.z, V.x, V.z); }
        public static Vector3 ZX_(this Vector3 V){ return VecOps.MkVector3(V.z, V.x, 0); }
        public static Vector3 ZYX(this Vector3 V){ return VecOps.MkVector3(V.z, V.y, V.x); }
        public static Vector3 ZYY(this Vector3 V){ return VecOps.MkVector3(V.z, V.y, V.y); }
        public static Vector3 ZYZ(this Vector3 V){ return VecOps.MkVector3(V.z, V.y, V.z); }
        public static Vector3 ZY_(this Vector3 V){ return VecOps.MkVector3(V.z, V.y, 0); }
        public static Vector3 ZZX(this Vector3 V){ return VecOps.MkVector3(V.z, V.z, V.x); }
        public static Vector3 ZZY(this Vector3 V){ return VecOps.MkVector3(V.z, V.z, V.y); }
        public static Vector3 ZZZ(this Vector3 V){ return VecOps.MkVector3(V.z, V.z, V.z); }
        public static Vector3 ZZ_(this Vector3 V){ return VecOps.MkVector3(V.z, V.z, 0); }
        public static Vector3 Z_X(this Vector3 V){ return VecOps.MkVector3(V.z, 0, V.x); }
        public static Vector3 Z_Y(this Vector3 V){ return VecOps.MkVector3(V.z, 0, V.y); }
        public static Vector3 Z_Z(this Vector3 V){ return VecOps.MkVector3(V.z, 0, V.z); }
        public static Vector3 Z__(this Vector3 V){ return VecOps.MkVector3(V.z, 0, 0); }
        public static Vector3 _XX(this Vector3 V){ return VecOps.MkVector3(0, V.x, V.x); }
        public static Vector3 _XY(this Vector3 V){ return VecOps.MkVector3(0, V.x, V.y); }
        public static Vector3 _XZ(this Vector3 V){ return VecOps.MkVector3(0, V.x, V.z); }
        public static Vector3 _X_(this Vector3 V){ return VecOps.MkVector3(0, V.x, 0); }
        public static Vector3 _YX(this Vector3 V){ return VecOps.MkVector3(0, V.y, V.x); }
        public static Vector3 _YY(this Vector3 V){ return VecOps.MkVector3(0, V.y, V.y); }
        public static Vector3 _YZ(this Vector3 V){ return VecOps.MkVector3(0, V.y, V.z); }
        public static Vector3 _Y_(this Vector3 V){ return VecOps.MkVector3(0, V.y, 0); }
        public static Vector3 _ZX(this Vector3 V){ return VecOps.MkVector3(0, V.z, V.x); }
        public static Vector3 _ZY(this Vector3 V){ return VecOps.MkVector3(0, V.z, V.y); }
        public static Vector3 _ZZ(this Vector3 V){ return VecOps.MkVector3(0, V.z, V.z); }
        public static Vector3 _Z_(this Vector3 V){ return VecOps.MkVector3(0, V.z, 0); }
        public static Vector3 __X(this Vector3 V){ return VecOps.MkVector3(0, 0, V.x); }
        public static Vector3 __Y(this Vector3 V){ return VecOps.MkVector3(0, 0, V.y); }
        public static Vector3 __Z(this Vector3 V){ return VecOps.MkVector3(0, 0, V.z); }
        public static Vector4 XXXX(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.x); }
        public static Vector4 XXXY(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.y); }
        public static Vector4 XXXZ(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.z); }
        public static Vector4 XXX_(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.x, 0); }
        public static Vector4 XXYX(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.x); }
        public static Vector4 XXYY(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.y); }
        public static Vector4 XXYZ(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.z); }
        public static Vector4 XXY_(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.y, 0); }
        public static Vector4 XXZX(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.x); }
        public static Vector4 XXZY(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.y); }
        public static Vector4 XXZZ(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.z); }
        public static Vector4 XXZ_(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, V.z, 0); }
        public static Vector4 XX_X(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, 0, V.x); }
        public static Vector4 XX_Y(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, 0, V.y); }
        public static Vector4 XX_Z(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, 0, V.z); }
        public static Vector4 XX__(this Vector3 V){ return VecOps.MkVector4(V.x, V.x, 0, 0); }
        public static Vector4 XYXX(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.x); }
        public static Vector4 XYXY(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.y); }
        public static Vector4 XYXZ(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.z); }
        public static Vector4 XYX_(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.x, 0); }
        public static Vector4 XYYX(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.x); }
        public static Vector4 XYYY(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.y); }
        public static Vector4 XYYZ(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.z); }
        public static Vector4 XYY_(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.y, 0); }
        public static Vector4 XYZX(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.x); }
        public static Vector4 XYZY(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.y); }
        public static Vector4 XYZZ(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.z); }
        public static Vector4 XYZ_(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, V.z, 0); }
        public static Vector4 XY_X(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, 0, V.x); }
        public static Vector4 XY_Y(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, 0, V.y); }
        public static Vector4 XY_Z(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, 0, V.z); }
        public static Vector4 XY__(this Vector3 V){ return VecOps.MkVector4(V.x, V.y, 0, 0); }
        public static Vector4 XZXX(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.x); }
        public static Vector4 XZXY(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.y); }
        public static Vector4 XZXZ(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.z); }
        public static Vector4 XZX_(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.x, 0); }
        public static Vector4 XZYX(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.x); }
        public static Vector4 XZYY(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.y); }
        public static Vector4 XZYZ(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.z); }
        public static Vector4 XZY_(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.y, 0); }
        public static Vector4 XZZX(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.x); }
        public static Vector4 XZZY(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.y); }
        public static Vector4 XZZZ(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.z); }
        public static Vector4 XZZ_(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, V.z, 0); }
        public static Vector4 XZ_X(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, 0, V.x); }
        public static Vector4 XZ_Y(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, 0, V.y); }
        public static Vector4 XZ_Z(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, 0, V.z); }
        public static Vector4 XZ__(this Vector3 V){ return VecOps.MkVector4(V.x, V.z, 0, 0); }
        public static Vector4 X_XX(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.x, V.x); }
        public static Vector4 X_XY(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.x, V.y); }
        public static Vector4 X_XZ(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.x, V.z); }
        public static Vector4 X_X_(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.x, 0); }
        public static Vector4 X_YX(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.y, V.x); }
        public static Vector4 X_YY(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.y, V.y); }
        public static Vector4 X_YZ(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.y, V.z); }
        public static Vector4 X_Y_(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.y, 0); }
        public static Vector4 X_ZX(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.z, V.x); }
        public static Vector4 X_ZY(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.z, V.y); }
        public static Vector4 X_ZZ(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.z, V.z); }
        public static Vector4 X_Z_(this Vector3 V){ return VecOps.MkVector4(V.x, 0, V.z, 0); }
        public static Vector4 X__X(this Vector3 V){ return VecOps.MkVector4(V.x, 0, 0, V.x); }
        public static Vector4 X__Y(this Vector3 V){ return VecOps.MkVector4(V.x, 0, 0, V.y); }
        public static Vector4 X__Z(this Vector3 V){ return VecOps.MkVector4(V.x, 0, 0, V.z); }
        public static Vector4 X___(this Vector3 V){ return VecOps.MkVector4(V.x, 0, 0, 0); }
        public static Vector4 YXXX(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.x); }
        public static Vector4 YXXY(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.y); }
        public static Vector4 YXXZ(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.z); }
        public static Vector4 YXX_(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.x, 0); }
        public static Vector4 YXYX(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.x); }
        public static Vector4 YXYY(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.y); }
        public static Vector4 YXYZ(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.z); }
        public static Vector4 YXY_(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.y, 0); }
        public static Vector4 YXZX(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.x); }
        public static Vector4 YXZY(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.y); }
        public static Vector4 YXZZ(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.z); }
        public static Vector4 YXZ_(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, V.z, 0); }
        public static Vector4 YX_X(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, 0, V.x); }
        public static Vector4 YX_Y(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, 0, V.y); }
        public static Vector4 YX_Z(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, 0, V.z); }
        public static Vector4 YX__(this Vector3 V){ return VecOps.MkVector4(V.y, V.x, 0, 0); }
        public static Vector4 YYXX(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.x); }
        public static Vector4 YYXY(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.y); }
        public static Vector4 YYXZ(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.z); }
        public static Vector4 YYX_(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.x, 0); }
        public static Vector4 YYYX(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.x); }
        public static Vector4 YYYY(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.y); }
        public static Vector4 YYYZ(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.z); }
        public static Vector4 YYY_(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.y, 0); }
        public static Vector4 YYZX(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.x); }
        public static Vector4 YYZY(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.y); }
        public static Vector4 YYZZ(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.z); }
        public static Vector4 YYZ_(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, V.z, 0); }
        public static Vector4 YY_X(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, 0, V.x); }
        public static Vector4 YY_Y(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, 0, V.y); }
        public static Vector4 YY_Z(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, 0, V.z); }
        public static Vector4 YY__(this Vector3 V){ return VecOps.MkVector4(V.y, V.y, 0, 0); }
        public static Vector4 YZXX(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.x); }
        public static Vector4 YZXY(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.y); }
        public static Vector4 YZXZ(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.z); }
        public static Vector4 YZX_(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.x, 0); }
        public static Vector4 YZYX(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.x); }
        public static Vector4 YZYY(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.y); }
        public static Vector4 YZYZ(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.z); }
        public static Vector4 YZY_(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.y, 0); }
        public static Vector4 YZZX(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.x); }
        public static Vector4 YZZY(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.y); }
        public static Vector4 YZZZ(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.z); }
        public static Vector4 YZZ_(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, V.z, 0); }
        public static Vector4 YZ_X(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, 0, V.x); }
        public static Vector4 YZ_Y(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, 0, V.y); }
        public static Vector4 YZ_Z(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, 0, V.z); }
        public static Vector4 YZ__(this Vector3 V){ return VecOps.MkVector4(V.y, V.z, 0, 0); }
        public static Vector4 Y_XX(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.x, V.x); }
        public static Vector4 Y_XY(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.x, V.y); }
        public static Vector4 Y_XZ(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.x, V.z); }
        public static Vector4 Y_X_(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.x, 0); }
        public static Vector4 Y_YX(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.y, V.x); }
        public static Vector4 Y_YY(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.y, V.y); }
        public static Vector4 Y_YZ(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.y, V.z); }
        public static Vector4 Y_Y_(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.y, 0); }
        public static Vector4 Y_ZX(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.z, V.x); }
        public static Vector4 Y_ZY(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.z, V.y); }
        public static Vector4 Y_ZZ(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.z, V.z); }
        public static Vector4 Y_Z_(this Vector3 V){ return VecOps.MkVector4(V.y, 0, V.z, 0); }
        public static Vector4 Y__X(this Vector3 V){ return VecOps.MkVector4(V.y, 0, 0, V.x); }
        public static Vector4 Y__Y(this Vector3 V){ return VecOps.MkVector4(V.y, 0, 0, V.y); }
        public static Vector4 Y__Z(this Vector3 V){ return VecOps.MkVector4(V.y, 0, 0, V.z); }
        public static Vector4 Y___(this Vector3 V){ return VecOps.MkVector4(V.y, 0, 0, 0); }
        public static Vector4 ZXXX(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.x); }
        public static Vector4 ZXXY(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.y); }
        public static Vector4 ZXXZ(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.z); }
        public static Vector4 ZXX_(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.x, 0); }
        public static Vector4 ZXYX(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.x); }
        public static Vector4 ZXYY(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.y); }
        public static Vector4 ZXYZ(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.z); }
        public static Vector4 ZXY_(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.y, 0); }
        public static Vector4 ZXZX(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.x); }
        public static Vector4 ZXZY(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.y); }
        public static Vector4 ZXZZ(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.z); }
        public static Vector4 ZXZ_(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, V.z, 0); }
        public static Vector4 ZX_X(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, 0, V.x); }
        public static Vector4 ZX_Y(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, 0, V.y); }
        public static Vector4 ZX_Z(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, 0, V.z); }
        public static Vector4 ZX__(this Vector3 V){ return VecOps.MkVector4(V.z, V.x, 0, 0); }
        public static Vector4 ZYXX(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.x); }
        public static Vector4 ZYXY(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.y); }
        public static Vector4 ZYXZ(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.z); }
        public static Vector4 ZYX_(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.x, 0); }
        public static Vector4 ZYYX(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.x); }
        public static Vector4 ZYYY(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.y); }
        public static Vector4 ZYYZ(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.z); }
        public static Vector4 ZYY_(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.y, 0); }
        public static Vector4 ZYZX(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.x); }
        public static Vector4 ZYZY(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.y); }
        public static Vector4 ZYZZ(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.z); }
        public static Vector4 ZYZ_(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, V.z, 0); }
        public static Vector4 ZY_X(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, 0, V.x); }
        public static Vector4 ZY_Y(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, 0, V.y); }
        public static Vector4 ZY_Z(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, 0, V.z); }
        public static Vector4 ZY__(this Vector3 V){ return VecOps.MkVector4(V.z, V.y, 0, 0); }
        public static Vector4 ZZXX(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.x); }
        public static Vector4 ZZXY(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.y); }
        public static Vector4 ZZXZ(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.z); }
        public static Vector4 ZZX_(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.x, 0); }
        public static Vector4 ZZYX(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.x); }
        public static Vector4 ZZYY(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.y); }
        public static Vector4 ZZYZ(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.z); }
        public static Vector4 ZZY_(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.y, 0); }
        public static Vector4 ZZZX(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.x); }
        public static Vector4 ZZZY(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.y); }
        public static Vector4 ZZZZ(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.z); }
        public static Vector4 ZZZ_(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, V.z, 0); }
        public static Vector4 ZZ_X(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, 0, V.x); }
        public static Vector4 ZZ_Y(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, 0, V.y); }
        public static Vector4 ZZ_Z(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, 0, V.z); }
        public static Vector4 ZZ__(this Vector3 V){ return VecOps.MkVector4(V.z, V.z, 0, 0); }
        public static Vector4 Z_XX(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.x, V.x); }
        public static Vector4 Z_XY(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.x, V.y); }
        public static Vector4 Z_XZ(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.x, V.z); }
        public static Vector4 Z_X_(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.x, 0); }
        public static Vector4 Z_YX(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.y, V.x); }
        public static Vector4 Z_YY(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.y, V.y); }
        public static Vector4 Z_YZ(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.y, V.z); }
        public static Vector4 Z_Y_(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.y, 0); }
        public static Vector4 Z_ZX(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.z, V.x); }
        public static Vector4 Z_ZY(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.z, V.y); }
        public static Vector4 Z_ZZ(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.z, V.z); }
        public static Vector4 Z_Z_(this Vector3 V){ return VecOps.MkVector4(V.z, 0, V.z, 0); }
        public static Vector4 Z__X(this Vector3 V){ return VecOps.MkVector4(V.z, 0, 0, V.x); }
        public static Vector4 Z__Y(this Vector3 V){ return VecOps.MkVector4(V.z, 0, 0, V.y); }
        public static Vector4 Z__Z(this Vector3 V){ return VecOps.MkVector4(V.z, 0, 0, V.z); }
        public static Vector4 Z___(this Vector3 V){ return VecOps.MkVector4(V.z, 0, 0, 0); }
        public static Vector4 _XXX(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.x, V.x); }
        public static Vector4 _XXY(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.x, V.y); }
        public static Vector4 _XXZ(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.x, V.z); }
        public static Vector4 _XX_(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.x, 0); }
        public static Vector4 _XYX(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.y, V.x); }
        public static Vector4 _XYY(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.y, V.y); }
        public static Vector4 _XYZ(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.y, V.z); }
        public static Vector4 _XY_(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.y, 0); }
        public static Vector4 _XZX(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.z, V.x); }
        public static Vector4 _XZY(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.z, V.y); }
        public static Vector4 _XZZ(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.z, V.z); }
        public static Vector4 _XZ_(this Vector3 V){ return VecOps.MkVector4(0, V.x, V.z, 0); }
        public static Vector4 _X_X(this Vector3 V){ return VecOps.MkVector4(0, V.x, 0, V.x); }
        public static Vector4 _X_Y(this Vector3 V){ return VecOps.MkVector4(0, V.x, 0, V.y); }
        public static Vector4 _X_Z(this Vector3 V){ return VecOps.MkVector4(0, V.x, 0, V.z); }
        public static Vector4 _X__(this Vector3 V){ return VecOps.MkVector4(0, V.x, 0, 0); }
        public static Vector4 _YXX(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.x, V.x); }
        public static Vector4 _YXY(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.x, V.y); }
        public static Vector4 _YXZ(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.x, V.z); }
        public static Vector4 _YX_(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.x, 0); }
        public static Vector4 _YYX(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.y, V.x); }
        public static Vector4 _YYY(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.y, V.y); }
        public static Vector4 _YYZ(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.y, V.z); }
        public static Vector4 _YY_(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.y, 0); }
        public static Vector4 _YZX(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.z, V.x); }
        public static Vector4 _YZY(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.z, V.y); }
        public static Vector4 _YZZ(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.z, V.z); }
        public static Vector4 _YZ_(this Vector3 V){ return VecOps.MkVector4(0, V.y, V.z, 0); }
        public static Vector4 _Y_X(this Vector3 V){ return VecOps.MkVector4(0, V.y, 0, V.x); }
        public static Vector4 _Y_Y(this Vector3 V){ return VecOps.MkVector4(0, V.y, 0, V.y); }
        public static Vector4 _Y_Z(this Vector3 V){ return VecOps.MkVector4(0, V.y, 0, V.z); }
        public static Vector4 _Y__(this Vector3 V){ return VecOps.MkVector4(0, V.y, 0, 0); }
        public static Vector4 _ZXX(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.x, V.x); }
        public static Vector4 _ZXY(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.x, V.y); }
        public static Vector4 _ZXZ(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.x, V.z); }
        public static Vector4 _ZX_(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.x, 0); }
        public static Vector4 _ZYX(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.y, V.x); }
        public static Vector4 _ZYY(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.y, V.y); }
        public static Vector4 _ZYZ(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.y, V.z); }
        public static Vector4 _ZY_(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.y, 0); }
        public static Vector4 _ZZX(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.z, V.x); }
        public static Vector4 _ZZY(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.z, V.y); }
        public static Vector4 _ZZZ(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.z, V.z); }
        public static Vector4 _ZZ_(this Vector3 V){ return VecOps.MkVector4(0, V.z, V.z, 0); }
        public static Vector4 _Z_X(this Vector3 V){ return VecOps.MkVector4(0, V.z, 0, V.x); }
        public static Vector4 _Z_Y(this Vector3 V){ return VecOps.MkVector4(0, V.z, 0, V.y); }
        public static Vector4 _Z_Z(this Vector3 V){ return VecOps.MkVector4(0, V.z, 0, V.z); }
        public static Vector4 _Z__(this Vector3 V){ return VecOps.MkVector4(0, V.z, 0, 0); }
        public static Vector4 __XX(this Vector3 V){ return VecOps.MkVector4(0, 0, V.x, V.x); }
        public static Vector4 __XY(this Vector3 V){ return VecOps.MkVector4(0, 0, V.x, V.y); }
        public static Vector4 __XZ(this Vector3 V){ return VecOps.MkVector4(0, 0, V.x, V.z); }
        public static Vector4 __X_(this Vector3 V){ return VecOps.MkVector4(0, 0, V.x, 0); }
        public static Vector4 __YX(this Vector3 V){ return VecOps.MkVector4(0, 0, V.y, V.x); }
        public static Vector4 __YY(this Vector3 V){ return VecOps.MkVector4(0, 0, V.y, V.y); }
        public static Vector4 __YZ(this Vector3 V){ return VecOps.MkVector4(0, 0, V.y, V.z); }
        public static Vector4 __Y_(this Vector3 V){ return VecOps.MkVector4(0, 0, V.y, 0); }
        public static Vector4 __ZX(this Vector3 V){ return VecOps.MkVector4(0, 0, V.z, V.x); }
        public static Vector4 __ZY(this Vector3 V){ return VecOps.MkVector4(0, 0, V.z, V.y); }
        public static Vector4 __ZZ(this Vector3 V){ return VecOps.MkVector4(0, 0, V.z, V.z); }
        public static Vector4 __Z_(this Vector3 V){ return VecOps.MkVector4(0, 0, V.z, 0); }
        public static Vector4 ___X(this Vector3 V){ return VecOps.MkVector4(0, 0, 0, V.x); }
        public static Vector4 ___Y(this Vector3 V){ return VecOps.MkVector4(0, 0, 0, V.y); }
        public static Vector4 ___Z(this Vector3 V){ return VecOps.MkVector4(0, 0, 0, V.z); }
        public static Vector2 XX(this Vector4 V){ return VecOps.MkVector2(V.x, V.x); }
        public static Vector2 XY(this Vector4 V){ return VecOps.MkVector2(V.x, V.y); }
        public static Vector2 XZ(this Vector4 V){ return VecOps.MkVector2(V.x, V.z); }
        public static Vector2 XW(this Vector4 V){ return VecOps.MkVector2(V.x, V.w); }
        public static Vector2 X_(this Vector4 V){ return VecOps.MkVector2(V.x, 0); }
        public static Vector2 YX(this Vector4 V){ return VecOps.MkVector2(V.y, V.x); }
        public static Vector2 YY(this Vector4 V){ return VecOps.MkVector2(V.y, V.y); }
        public static Vector2 YZ(this Vector4 V){ return VecOps.MkVector2(V.y, V.z); }
        public static Vector2 YW(this Vector4 V){ return VecOps.MkVector2(V.y, V.w); }
        public static Vector2 Y_(this Vector4 V){ return VecOps.MkVector2(V.y, 0); }
        public static Vector2 ZX(this Vector4 V){ return VecOps.MkVector2(V.z, V.x); }
        public static Vector2 ZY(this Vector4 V){ return VecOps.MkVector2(V.z, V.y); }
        public static Vector2 ZZ(this Vector4 V){ return VecOps.MkVector2(V.z, V.z); }
        public static Vector2 ZW(this Vector4 V){ return VecOps.MkVector2(V.z, V.w); }
        public static Vector2 Z_(this Vector4 V){ return VecOps.MkVector2(V.z, 0); }
        public static Vector2 WX(this Vector4 V){ return VecOps.MkVector2(V.w, V.x); }
        public static Vector2 WY(this Vector4 V){ return VecOps.MkVector2(V.w, V.y); }
        public static Vector2 WZ(this Vector4 V){ return VecOps.MkVector2(V.w, V.z); }
        public static Vector2 WW(this Vector4 V){ return VecOps.MkVector2(V.w, V.w); }
        public static Vector2 W_(this Vector4 V){ return VecOps.MkVector2(V.w, 0); }
        public static Vector2 _X(this Vector4 V){ return VecOps.MkVector2(0, V.x); }
        public static Vector2 _Y(this Vector4 V){ return VecOps.MkVector2(0, V.y); }
        public static Vector2 _Z(this Vector4 V){ return VecOps.MkVector2(0, V.z); }
        public static Vector2 _W(this Vector4 V){ return VecOps.MkVector2(0, V.w); }
        public static Vector3 XXX(this Vector4 V){ return VecOps.MkVector3(V.x, V.x, V.x); }
        public static Vector3 XXY(this Vector4 V){ return VecOps.MkVector3(V.x, V.x, V.y); }
        public static Vector3 XXZ(this Vector4 V){ return VecOps.MkVector3(V.x, V.x, V.z); }
        public static Vector3 XXW(this Vector4 V){ return VecOps.MkVector3(V.x, V.x, V.w); }
        public static Vector3 XX_(this Vector4 V){ return VecOps.MkVector3(V.x, V.x, 0); }
        public static Vector3 XYX(this Vector4 V){ return VecOps.MkVector3(V.x, V.y, V.x); }
        public static Vector3 XYY(this Vector4 V){ return VecOps.MkVector3(V.x, V.y, V.y); }
        public static Vector3 XYZ(this Vector4 V){ return VecOps.MkVector3(V.x, V.y, V.z); }
        public static Vector3 XYW(this Vector4 V){ return VecOps.MkVector3(V.x, V.y, V.w); }
        public static Vector3 XY_(this Vector4 V){ return VecOps.MkVector3(V.x, V.y, 0); }
        public static Vector3 XZX(this Vector4 V){ return VecOps.MkVector3(V.x, V.z, V.x); }
        public static Vector3 XZY(this Vector4 V){ return VecOps.MkVector3(V.x, V.z, V.y); }
        public static Vector3 XZZ(this Vector4 V){ return VecOps.MkVector3(V.x, V.z, V.z); }
        public static Vector3 XZW(this Vector4 V){ return VecOps.MkVector3(V.x, V.z, V.w); }
        public static Vector3 XZ_(this Vector4 V){ return VecOps.MkVector3(V.x, V.z, 0); }
        public static Vector3 XWX(this Vector4 V){ return VecOps.MkVector3(V.x, V.w, V.x); }
        public static Vector3 XWY(this Vector4 V){ return VecOps.MkVector3(V.x, V.w, V.y); }
        public static Vector3 XWZ(this Vector4 V){ return VecOps.MkVector3(V.x, V.w, V.z); }
        public static Vector3 XWW(this Vector4 V){ return VecOps.MkVector3(V.x, V.w, V.w); }
        public static Vector3 XW_(this Vector4 V){ return VecOps.MkVector3(V.x, V.w, 0); }
        public static Vector3 X_X(this Vector4 V){ return VecOps.MkVector3(V.x, 0, V.x); }
        public static Vector3 X_Y(this Vector4 V){ return VecOps.MkVector3(V.x, 0, V.y); }
        public static Vector3 X_Z(this Vector4 V){ return VecOps.MkVector3(V.x, 0, V.z); }
        public static Vector3 X_W(this Vector4 V){ return VecOps.MkVector3(V.x, 0, V.w); }
        public static Vector3 X__(this Vector4 V){ return VecOps.MkVector3(V.x, 0, 0); }
        public static Vector3 YXX(this Vector4 V){ return VecOps.MkVector3(V.y, V.x, V.x); }
        public static Vector3 YXY(this Vector4 V){ return VecOps.MkVector3(V.y, V.x, V.y); }
        public static Vector3 YXZ(this Vector4 V){ return VecOps.MkVector3(V.y, V.x, V.z); }
        public static Vector3 YXW(this Vector4 V){ return VecOps.MkVector3(V.y, V.x, V.w); }
        public static Vector3 YX_(this Vector4 V){ return VecOps.MkVector3(V.y, V.x, 0); }
        public static Vector3 YYX(this Vector4 V){ return VecOps.MkVector3(V.y, V.y, V.x); }
        public static Vector3 YYY(this Vector4 V){ return VecOps.MkVector3(V.y, V.y, V.y); }
        public static Vector3 YYZ(this Vector4 V){ return VecOps.MkVector3(V.y, V.y, V.z); }
        public static Vector3 YYW(this Vector4 V){ return VecOps.MkVector3(V.y, V.y, V.w); }
        public static Vector3 YY_(this Vector4 V){ return VecOps.MkVector3(V.y, V.y, 0); }
        public static Vector3 YZX(this Vector4 V){ return VecOps.MkVector3(V.y, V.z, V.x); }
        public static Vector3 YZY(this Vector4 V){ return VecOps.MkVector3(V.y, V.z, V.y); }
        public static Vector3 YZZ(this Vector4 V){ return VecOps.MkVector3(V.y, V.z, V.z); }
        public static Vector3 YZW(this Vector4 V){ return VecOps.MkVector3(V.y, V.z, V.w); }
        public static Vector3 YZ_(this Vector4 V){ return VecOps.MkVector3(V.y, V.z, 0); }
        public static Vector3 YWX(this Vector4 V){ return VecOps.MkVector3(V.y, V.w, V.x); }
        public static Vector3 YWY(this Vector4 V){ return VecOps.MkVector3(V.y, V.w, V.y); }
        public static Vector3 YWZ(this Vector4 V){ return VecOps.MkVector3(V.y, V.w, V.z); }
        public static Vector3 YWW(this Vector4 V){ return VecOps.MkVector3(V.y, V.w, V.w); }
        public static Vector3 YW_(this Vector4 V){ return VecOps.MkVector3(V.y, V.w, 0); }
        public static Vector3 Y_X(this Vector4 V){ return VecOps.MkVector3(V.y, 0, V.x); }
        public static Vector3 Y_Y(this Vector4 V){ return VecOps.MkVector3(V.y, 0, V.y); }
        public static Vector3 Y_Z(this Vector4 V){ return VecOps.MkVector3(V.y, 0, V.z); }
        public static Vector3 Y_W(this Vector4 V){ return VecOps.MkVector3(V.y, 0, V.w); }
        public static Vector3 Y__(this Vector4 V){ return VecOps.MkVector3(V.y, 0, 0); }
        public static Vector3 ZXX(this Vector4 V){ return VecOps.MkVector3(V.z, V.x, V.x); }
        public static Vector3 ZXY(this Vector4 V){ return VecOps.MkVector3(V.z, V.x, V.y); }
        public static Vector3 ZXZ(this Vector4 V){ return VecOps.MkVector3(V.z, V.x, V.z); }
        public static Vector3 ZXW(this Vector4 V){ return VecOps.MkVector3(V.z, V.x, V.w); }
        public static Vector3 ZX_(this Vector4 V){ return VecOps.MkVector3(V.z, V.x, 0); }
        public static Vector3 ZYX(this Vector4 V){ return VecOps.MkVector3(V.z, V.y, V.x); }
        public static Vector3 ZYY(this Vector4 V){ return VecOps.MkVector3(V.z, V.y, V.y); }
        public static Vector3 ZYZ(this Vector4 V){ return VecOps.MkVector3(V.z, V.y, V.z); }
        public static Vector3 ZYW(this Vector4 V){ return VecOps.MkVector3(V.z, V.y, V.w); }
        public static Vector3 ZY_(this Vector4 V){ return VecOps.MkVector3(V.z, V.y, 0); }
        public static Vector3 ZZX(this Vector4 V){ return VecOps.MkVector3(V.z, V.z, V.x); }
        public static Vector3 ZZY(this Vector4 V){ return VecOps.MkVector3(V.z, V.z, V.y); }
        public static Vector3 ZZZ(this Vector4 V){ return VecOps.MkVector3(V.z, V.z, V.z); }
        public static Vector3 ZZW(this Vector4 V){ return VecOps.MkVector3(V.z, V.z, V.w); }
        public static Vector3 ZZ_(this Vector4 V){ return VecOps.MkVector3(V.z, V.z, 0); }
        public static Vector3 ZWX(this Vector4 V){ return VecOps.MkVector3(V.z, V.w, V.x); }
        public static Vector3 ZWY(this Vector4 V){ return VecOps.MkVector3(V.z, V.w, V.y); }
        public static Vector3 ZWZ(this Vector4 V){ return VecOps.MkVector3(V.z, V.w, V.z); }
        public static Vector3 ZWW(this Vector4 V){ return VecOps.MkVector3(V.z, V.w, V.w); }
        public static Vector3 ZW_(this Vector4 V){ return VecOps.MkVector3(V.z, V.w, 0); }
        public static Vector3 Z_X(this Vector4 V){ return VecOps.MkVector3(V.z, 0, V.x); }
        public static Vector3 Z_Y(this Vector4 V){ return VecOps.MkVector3(V.z, 0, V.y); }
        public static Vector3 Z_Z(this Vector4 V){ return VecOps.MkVector3(V.z, 0, V.z); }
        public static Vector3 Z_W(this Vector4 V){ return VecOps.MkVector3(V.z, 0, V.w); }
        public static Vector3 Z__(this Vector4 V){ return VecOps.MkVector3(V.z, 0, 0); }
        public static Vector3 WXX(this Vector4 V){ return VecOps.MkVector3(V.w, V.x, V.x); }
        public static Vector3 WXY(this Vector4 V){ return VecOps.MkVector3(V.w, V.x, V.y); }
        public static Vector3 WXZ(this Vector4 V){ return VecOps.MkVector3(V.w, V.x, V.z); }
        public static Vector3 WXW(this Vector4 V){ return VecOps.MkVector3(V.w, V.x, V.w); }
        public static Vector3 WX_(this Vector4 V){ return VecOps.MkVector3(V.w, V.x, 0); }
        public static Vector3 WYX(this Vector4 V){ return VecOps.MkVector3(V.w, V.y, V.x); }
        public static Vector3 WYY(this Vector4 V){ return VecOps.MkVector3(V.w, V.y, V.y); }
        public static Vector3 WYZ(this Vector4 V){ return VecOps.MkVector3(V.w, V.y, V.z); }
        public static Vector3 WYW(this Vector4 V){ return VecOps.MkVector3(V.w, V.y, V.w); }
        public static Vector3 WY_(this Vector4 V){ return VecOps.MkVector3(V.w, V.y, 0); }
        public static Vector3 WZX(this Vector4 V){ return VecOps.MkVector3(V.w, V.z, V.x); }
        public static Vector3 WZY(this Vector4 V){ return VecOps.MkVector3(V.w, V.z, V.y); }
        public static Vector3 WZZ(this Vector4 V){ return VecOps.MkVector3(V.w, V.z, V.z); }
        public static Vector3 WZW(this Vector4 V){ return VecOps.MkVector3(V.w, V.z, V.w); }
        public static Vector3 WZ_(this Vector4 V){ return VecOps.MkVector3(V.w, V.z, 0); }
        public static Vector3 WWX(this Vector4 V){ return VecOps.MkVector3(V.w, V.w, V.x); }
        public static Vector3 WWY(this Vector4 V){ return VecOps.MkVector3(V.w, V.w, V.y); }
        public static Vector3 WWZ(this Vector4 V){ return VecOps.MkVector3(V.w, V.w, V.z); }
        public static Vector3 WWW(this Vector4 V){ return VecOps.MkVector3(V.w, V.w, V.w); }
        public static Vector3 WW_(this Vector4 V){ return VecOps.MkVector3(V.w, V.w, 0); }
        public static Vector3 W_X(this Vector4 V){ return VecOps.MkVector3(V.w, 0, V.x); }
        public static Vector3 W_Y(this Vector4 V){ return VecOps.MkVector3(V.w, 0, V.y); }
        public static Vector3 W_Z(this Vector4 V){ return VecOps.MkVector3(V.w, 0, V.z); }
        public static Vector3 W_W(this Vector4 V){ return VecOps.MkVector3(V.w, 0, V.w); }
        public static Vector3 W__(this Vector4 V){ return VecOps.MkVector3(V.w, 0, 0); }
        public static Vector3 _XX(this Vector4 V){ return VecOps.MkVector3(0, V.x, V.x); }
        public static Vector3 _XY(this Vector4 V){ return VecOps.MkVector3(0, V.x, V.y); }
        public static Vector3 _XZ(this Vector4 V){ return VecOps.MkVector3(0, V.x, V.z); }
        public static Vector3 _XW(this Vector4 V){ return VecOps.MkVector3(0, V.x, V.w); }
        public static Vector3 _X_(this Vector4 V){ return VecOps.MkVector3(0, V.x, 0); }
        public static Vector3 _YX(this Vector4 V){ return VecOps.MkVector3(0, V.y, V.x); }
        public static Vector3 _YY(this Vector4 V){ return VecOps.MkVector3(0, V.y, V.y); }
        public static Vector3 _YZ(this Vector4 V){ return VecOps.MkVector3(0, V.y, V.z); }
        public static Vector3 _YW(this Vector4 V){ return VecOps.MkVector3(0, V.y, V.w); }
        public static Vector3 _Y_(this Vector4 V){ return VecOps.MkVector3(0, V.y, 0); }
        public static Vector3 _ZX(this Vector4 V){ return VecOps.MkVector3(0, V.z, V.x); }
        public static Vector3 _ZY(this Vector4 V){ return VecOps.MkVector3(0, V.z, V.y); }
        public static Vector3 _ZZ(this Vector4 V){ return VecOps.MkVector3(0, V.z, V.z); }
        public static Vector3 _ZW(this Vector4 V){ return VecOps.MkVector3(0, V.z, V.w); }
        public static Vector3 _Z_(this Vector4 V){ return VecOps.MkVector3(0, V.z, 0); }
        public static Vector3 _WX(this Vector4 V){ return VecOps.MkVector3(0, V.w, V.x); }
        public static Vector3 _WY(this Vector4 V){ return VecOps.MkVector3(0, V.w, V.y); }
        public static Vector3 _WZ(this Vector4 V){ return VecOps.MkVector3(0, V.w, V.z); }
        public static Vector3 _WW(this Vector4 V){ return VecOps.MkVector3(0, V.w, V.w); }
        public static Vector3 _W_(this Vector4 V){ return VecOps.MkVector3(0, V.w, 0); }
        public static Vector3 __X(this Vector4 V){ return VecOps.MkVector3(0, 0, V.x); }
        public static Vector3 __Y(this Vector4 V){ return VecOps.MkVector3(0, 0, V.y); }
        public static Vector3 __Z(this Vector4 V){ return VecOps.MkVector3(0, 0, V.z); }
        public static Vector3 __W(this Vector4 V){ return VecOps.MkVector3(0, 0, V.w); }
        public static Vector4 XXXX(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.x); }
        public static Vector4 XXXY(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.y); }
        public static Vector4 XXXZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.z); }
        public static Vector4 XXXW(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.x, V.w); }
        public static Vector4 XXX_(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.x, 0); }
        public static Vector4 XXYX(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.x); }
        public static Vector4 XXYY(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.y); }
        public static Vector4 XXYZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.z); }
        public static Vector4 XXYW(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.y, V.w); }
        public static Vector4 XXY_(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.y, 0); }
        public static Vector4 XXZX(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.x); }
        public static Vector4 XXZY(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.y); }
        public static Vector4 XXZZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.z); }
        public static Vector4 XXZW(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.z, V.w); }
        public static Vector4 XXZ_(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.z, 0); }
        public static Vector4 XXWX(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.w, V.x); }
        public static Vector4 XXWY(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.w, V.y); }
        public static Vector4 XXWZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.w, V.z); }
        public static Vector4 XXWW(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.w, V.w); }
        public static Vector4 XXW_(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, V.w, 0); }
        public static Vector4 XX_X(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, 0, V.x); }
        public static Vector4 XX_Y(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, 0, V.y); }
        public static Vector4 XX_Z(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, 0, V.z); }
        public static Vector4 XX_W(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, 0, V.w); }
        public static Vector4 XX__(this Vector4 V){ return VecOps.MkVector4(V.x, V.x, 0, 0); }
        public static Vector4 XYXX(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.x); }
        public static Vector4 XYXY(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.y); }
        public static Vector4 XYXZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.z); }
        public static Vector4 XYXW(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.x, V.w); }
        public static Vector4 XYX_(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.x, 0); }
        public static Vector4 XYYX(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.x); }
        public static Vector4 XYYY(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.y); }
        public static Vector4 XYYZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.z); }
        public static Vector4 XYYW(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.y, V.w); }
        public static Vector4 XYY_(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.y, 0); }
        public static Vector4 XYZX(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.x); }
        public static Vector4 XYZY(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.y); }
        public static Vector4 XYZZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.z); }
        public static Vector4 XYZW(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.z, V.w); }
        public static Vector4 XYZ_(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.z, 0); }
        public static Vector4 XYWX(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.w, V.x); }
        public static Vector4 XYWY(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.w, V.y); }
        public static Vector4 XYWZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.w, V.z); }
        public static Vector4 XYWW(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.w, V.w); }
        public static Vector4 XYW_(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, V.w, 0); }
        public static Vector4 XY_X(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, 0, V.x); }
        public static Vector4 XY_Y(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, 0, V.y); }
        public static Vector4 XY_Z(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, 0, V.z); }
        public static Vector4 XY_W(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, 0, V.w); }
        public static Vector4 XY__(this Vector4 V){ return VecOps.MkVector4(V.x, V.y, 0, 0); }
        public static Vector4 XZXX(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.x); }
        public static Vector4 XZXY(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.y); }
        public static Vector4 XZXZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.z); }
        public static Vector4 XZXW(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.x, V.w); }
        public static Vector4 XZX_(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.x, 0); }
        public static Vector4 XZYX(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.x); }
        public static Vector4 XZYY(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.y); }
        public static Vector4 XZYZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.z); }
        public static Vector4 XZYW(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.y, V.w); }
        public static Vector4 XZY_(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.y, 0); }
        public static Vector4 XZZX(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.x); }
        public static Vector4 XZZY(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.y); }
        public static Vector4 XZZZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.z); }
        public static Vector4 XZZW(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.z, V.w); }
        public static Vector4 XZZ_(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.z, 0); }
        public static Vector4 XZWX(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.w, V.x); }
        public static Vector4 XZWY(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.w, V.y); }
        public static Vector4 XZWZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.w, V.z); }
        public static Vector4 XZWW(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.w, V.w); }
        public static Vector4 XZW_(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, V.w, 0); }
        public static Vector4 XZ_X(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, 0, V.x); }
        public static Vector4 XZ_Y(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, 0, V.y); }
        public static Vector4 XZ_Z(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, 0, V.z); }
        public static Vector4 XZ_W(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, 0, V.w); }
        public static Vector4 XZ__(this Vector4 V){ return VecOps.MkVector4(V.x, V.z, 0, 0); }
        public static Vector4 XWXX(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.x, V.x); }
        public static Vector4 XWXY(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.x, V.y); }
        public static Vector4 XWXZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.x, V.z); }
        public static Vector4 XWXW(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.x, V.w); }
        public static Vector4 XWX_(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.x, 0); }
        public static Vector4 XWYX(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.y, V.x); }
        public static Vector4 XWYY(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.y, V.y); }
        public static Vector4 XWYZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.y, V.z); }
        public static Vector4 XWYW(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.y, V.w); }
        public static Vector4 XWY_(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.y, 0); }
        public static Vector4 XWZX(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.z, V.x); }
        public static Vector4 XWZY(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.z, V.y); }
        public static Vector4 XWZZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.z, V.z); }
        public static Vector4 XWZW(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.z, V.w); }
        public static Vector4 XWZ_(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.z, 0); }
        public static Vector4 XWWX(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.w, V.x); }
        public static Vector4 XWWY(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.w, V.y); }
        public static Vector4 XWWZ(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.w, V.z); }
        public static Vector4 XWWW(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.w, V.w); }
        public static Vector4 XWW_(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, V.w, 0); }
        public static Vector4 XW_X(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, 0, V.x); }
        public static Vector4 XW_Y(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, 0, V.y); }
        public static Vector4 XW_Z(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, 0, V.z); }
        public static Vector4 XW_W(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, 0, V.w); }
        public static Vector4 XW__(this Vector4 V){ return VecOps.MkVector4(V.x, V.w, 0, 0); }
        public static Vector4 X_XX(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.x, V.x); }
        public static Vector4 X_XY(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.x, V.y); }
        public static Vector4 X_XZ(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.x, V.z); }
        public static Vector4 X_XW(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.x, V.w); }
        public static Vector4 X_X_(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.x, 0); }
        public static Vector4 X_YX(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.y, V.x); }
        public static Vector4 X_YY(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.y, V.y); }
        public static Vector4 X_YZ(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.y, V.z); }
        public static Vector4 X_YW(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.y, V.w); }
        public static Vector4 X_Y_(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.y, 0); }
        public static Vector4 X_ZX(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.z, V.x); }
        public static Vector4 X_ZY(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.z, V.y); }
        public static Vector4 X_ZZ(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.z, V.z); }
        public static Vector4 X_ZW(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.z, V.w); }
        public static Vector4 X_Z_(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.z, 0); }
        public static Vector4 X_WX(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.w, V.x); }
        public static Vector4 X_WY(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.w, V.y); }
        public static Vector4 X_WZ(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.w, V.z); }
        public static Vector4 X_WW(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.w, V.w); }
        public static Vector4 X_W_(this Vector4 V){ return VecOps.MkVector4(V.x, 0, V.w, 0); }
        public static Vector4 X__X(this Vector4 V){ return VecOps.MkVector4(V.x, 0, 0, V.x); }
        public static Vector4 X__Y(this Vector4 V){ return VecOps.MkVector4(V.x, 0, 0, V.y); }
        public static Vector4 X__Z(this Vector4 V){ return VecOps.MkVector4(V.x, 0, 0, V.z); }
        public static Vector4 X__W(this Vector4 V){ return VecOps.MkVector4(V.x, 0, 0, V.w); }
        public static Vector4 X___(this Vector4 V){ return VecOps.MkVector4(V.x, 0, 0, 0); }
        public static Vector4 YXXX(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.x); }
        public static Vector4 YXXY(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.y); }
        public static Vector4 YXXZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.z); }
        public static Vector4 YXXW(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.x, V.w); }
        public static Vector4 YXX_(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.x, 0); }
        public static Vector4 YXYX(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.x); }
        public static Vector4 YXYY(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.y); }
        public static Vector4 YXYZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.z); }
        public static Vector4 YXYW(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.y, V.w); }
        public static Vector4 YXY_(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.y, 0); }
        public static Vector4 YXZX(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.x); }
        public static Vector4 YXZY(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.y); }
        public static Vector4 YXZZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.z); }
        public static Vector4 YXZW(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.z, V.w); }
        public static Vector4 YXZ_(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.z, 0); }
        public static Vector4 YXWX(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.w, V.x); }
        public static Vector4 YXWY(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.w, V.y); }
        public static Vector4 YXWZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.w, V.z); }
        public static Vector4 YXWW(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.w, V.w); }
        public static Vector4 YXW_(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, V.w, 0); }
        public static Vector4 YX_X(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, 0, V.x); }
        public static Vector4 YX_Y(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, 0, V.y); }
        public static Vector4 YX_Z(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, 0, V.z); }
        public static Vector4 YX_W(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, 0, V.w); }
        public static Vector4 YX__(this Vector4 V){ return VecOps.MkVector4(V.y, V.x, 0, 0); }
        public static Vector4 YYXX(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.x); }
        public static Vector4 YYXY(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.y); }
        public static Vector4 YYXZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.z); }
        public static Vector4 YYXW(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.x, V.w); }
        public static Vector4 YYX_(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.x, 0); }
        public static Vector4 YYYX(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.x); }
        public static Vector4 YYYY(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.y); }
        public static Vector4 YYYZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.z); }
        public static Vector4 YYYW(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.y, V.w); }
        public static Vector4 YYY_(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.y, 0); }
        public static Vector4 YYZX(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.x); }
        public static Vector4 YYZY(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.y); }
        public static Vector4 YYZZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.z); }
        public static Vector4 YYZW(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.z, V.w); }
        public static Vector4 YYZ_(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.z, 0); }
        public static Vector4 YYWX(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.w, V.x); }
        public static Vector4 YYWY(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.w, V.y); }
        public static Vector4 YYWZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.w, V.z); }
        public static Vector4 YYWW(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.w, V.w); }
        public static Vector4 YYW_(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, V.w, 0); }
        public static Vector4 YY_X(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, 0, V.x); }
        public static Vector4 YY_Y(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, 0, V.y); }
        public static Vector4 YY_Z(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, 0, V.z); }
        public static Vector4 YY_W(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, 0, V.w); }
        public static Vector4 YY__(this Vector4 V){ return VecOps.MkVector4(V.y, V.y, 0, 0); }
        public static Vector4 YZXX(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.x); }
        public static Vector4 YZXY(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.y); }
        public static Vector4 YZXZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.z); }
        public static Vector4 YZXW(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.x, V.w); }
        public static Vector4 YZX_(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.x, 0); }
        public static Vector4 YZYX(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.x); }
        public static Vector4 YZYY(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.y); }
        public static Vector4 YZYZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.z); }
        public static Vector4 YZYW(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.y, V.w); }
        public static Vector4 YZY_(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.y, 0); }
        public static Vector4 YZZX(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.x); }
        public static Vector4 YZZY(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.y); }
        public static Vector4 YZZZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.z); }
        public static Vector4 YZZW(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.z, V.w); }
        public static Vector4 YZZ_(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.z, 0); }
        public static Vector4 YZWX(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.w, V.x); }
        public static Vector4 YZWY(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.w, V.y); }
        public static Vector4 YZWZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.w, V.z); }
        public static Vector4 YZWW(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.w, V.w); }
        public static Vector4 YZW_(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, V.w, 0); }
        public static Vector4 YZ_X(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, 0, V.x); }
        public static Vector4 YZ_Y(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, 0, V.y); }
        public static Vector4 YZ_Z(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, 0, V.z); }
        public static Vector4 YZ_W(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, 0, V.w); }
        public static Vector4 YZ__(this Vector4 V){ return VecOps.MkVector4(V.y, V.z, 0, 0); }
        public static Vector4 YWXX(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.x, V.x); }
        public static Vector4 YWXY(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.x, V.y); }
        public static Vector4 YWXZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.x, V.z); }
        public static Vector4 YWXW(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.x, V.w); }
        public static Vector4 YWX_(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.x, 0); }
        public static Vector4 YWYX(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.y, V.x); }
        public static Vector4 YWYY(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.y, V.y); }
        public static Vector4 YWYZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.y, V.z); }
        public static Vector4 YWYW(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.y, V.w); }
        public static Vector4 YWY_(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.y, 0); }
        public static Vector4 YWZX(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.z, V.x); }
        public static Vector4 YWZY(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.z, V.y); }
        public static Vector4 YWZZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.z, V.z); }
        public static Vector4 YWZW(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.z, V.w); }
        public static Vector4 YWZ_(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.z, 0); }
        public static Vector4 YWWX(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.w, V.x); }
        public static Vector4 YWWY(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.w, V.y); }
        public static Vector4 YWWZ(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.w, V.z); }
        public static Vector4 YWWW(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.w, V.w); }
        public static Vector4 YWW_(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, V.w, 0); }
        public static Vector4 YW_X(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, 0, V.x); }
        public static Vector4 YW_Y(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, 0, V.y); }
        public static Vector4 YW_Z(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, 0, V.z); }
        public static Vector4 YW_W(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, 0, V.w); }
        public static Vector4 YW__(this Vector4 V){ return VecOps.MkVector4(V.y, V.w, 0, 0); }
        public static Vector4 Y_XX(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.x, V.x); }
        public static Vector4 Y_XY(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.x, V.y); }
        public static Vector4 Y_XZ(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.x, V.z); }
        public static Vector4 Y_XW(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.x, V.w); }
        public static Vector4 Y_X_(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.x, 0); }
        public static Vector4 Y_YX(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.y, V.x); }
        public static Vector4 Y_YY(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.y, V.y); }
        public static Vector4 Y_YZ(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.y, V.z); }
        public static Vector4 Y_YW(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.y, V.w); }
        public static Vector4 Y_Y_(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.y, 0); }
        public static Vector4 Y_ZX(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.z, V.x); }
        public static Vector4 Y_ZY(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.z, V.y); }
        public static Vector4 Y_ZZ(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.z, V.z); }
        public static Vector4 Y_ZW(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.z, V.w); }
        public static Vector4 Y_Z_(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.z, 0); }
        public static Vector4 Y_WX(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.w, V.x); }
        public static Vector4 Y_WY(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.w, V.y); }
        public static Vector4 Y_WZ(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.w, V.z); }
        public static Vector4 Y_WW(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.w, V.w); }
        public static Vector4 Y_W_(this Vector4 V){ return VecOps.MkVector4(V.y, 0, V.w, 0); }
        public static Vector4 Y__X(this Vector4 V){ return VecOps.MkVector4(V.y, 0, 0, V.x); }
        public static Vector4 Y__Y(this Vector4 V){ return VecOps.MkVector4(V.y, 0, 0, V.y); }
        public static Vector4 Y__Z(this Vector4 V){ return VecOps.MkVector4(V.y, 0, 0, V.z); }
        public static Vector4 Y__W(this Vector4 V){ return VecOps.MkVector4(V.y, 0, 0, V.w); }
        public static Vector4 Y___(this Vector4 V){ return VecOps.MkVector4(V.y, 0, 0, 0); }
        public static Vector4 ZXXX(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.x); }
        public static Vector4 ZXXY(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.y); }
        public static Vector4 ZXXZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.z); }
        public static Vector4 ZXXW(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.x, V.w); }
        public static Vector4 ZXX_(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.x, 0); }
        public static Vector4 ZXYX(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.x); }
        public static Vector4 ZXYY(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.y); }
        public static Vector4 ZXYZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.z); }
        public static Vector4 ZXYW(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.y, V.w); }
        public static Vector4 ZXY_(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.y, 0); }
        public static Vector4 ZXZX(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.x); }
        public static Vector4 ZXZY(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.y); }
        public static Vector4 ZXZZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.z); }
        public static Vector4 ZXZW(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.z, V.w); }
        public static Vector4 ZXZ_(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.z, 0); }
        public static Vector4 ZXWX(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.w, V.x); }
        public static Vector4 ZXWY(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.w, V.y); }
        public static Vector4 ZXWZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.w, V.z); }
        public static Vector4 ZXWW(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.w, V.w); }
        public static Vector4 ZXW_(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, V.w, 0); }
        public static Vector4 ZX_X(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, 0, V.x); }
        public static Vector4 ZX_Y(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, 0, V.y); }
        public static Vector4 ZX_Z(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, 0, V.z); }
        public static Vector4 ZX_W(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, 0, V.w); }
        public static Vector4 ZX__(this Vector4 V){ return VecOps.MkVector4(V.z, V.x, 0, 0); }
        public static Vector4 ZYXX(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.x); }
        public static Vector4 ZYXY(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.y); }
        public static Vector4 ZYXZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.z); }
        public static Vector4 ZYXW(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.x, V.w); }
        public static Vector4 ZYX_(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.x, 0); }
        public static Vector4 ZYYX(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.x); }
        public static Vector4 ZYYY(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.y); }
        public static Vector4 ZYYZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.z); }
        public static Vector4 ZYYW(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.y, V.w); }
        public static Vector4 ZYY_(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.y, 0); }
        public static Vector4 ZYZX(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.x); }
        public static Vector4 ZYZY(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.y); }
        public static Vector4 ZYZZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.z); }
        public static Vector4 ZYZW(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.z, V.w); }
        public static Vector4 ZYZ_(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.z, 0); }
        public static Vector4 ZYWX(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.w, V.x); }
        public static Vector4 ZYWY(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.w, V.y); }
        public static Vector4 ZYWZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.w, V.z); }
        public static Vector4 ZYWW(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.w, V.w); }
        public static Vector4 ZYW_(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, V.w, 0); }
        public static Vector4 ZY_X(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, 0, V.x); }
        public static Vector4 ZY_Y(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, 0, V.y); }
        public static Vector4 ZY_Z(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, 0, V.z); }
        public static Vector4 ZY_W(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, 0, V.w); }
        public static Vector4 ZY__(this Vector4 V){ return VecOps.MkVector4(V.z, V.y, 0, 0); }
        public static Vector4 ZZXX(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.x); }
        public static Vector4 ZZXY(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.y); }
        public static Vector4 ZZXZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.z); }
        public static Vector4 ZZXW(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.x, V.w); }
        public static Vector4 ZZX_(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.x, 0); }
        public static Vector4 ZZYX(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.x); }
        public static Vector4 ZZYY(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.y); }
        public static Vector4 ZZYZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.z); }
        public static Vector4 ZZYW(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.y, V.w); }
        public static Vector4 ZZY_(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.y, 0); }
        public static Vector4 ZZZX(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.x); }
        public static Vector4 ZZZY(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.y); }
        public static Vector4 ZZZZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.z); }
        public static Vector4 ZZZW(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.z, V.w); }
        public static Vector4 ZZZ_(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.z, 0); }
        public static Vector4 ZZWX(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.w, V.x); }
        public static Vector4 ZZWY(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.w, V.y); }
        public static Vector4 ZZWZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.w, V.z); }
        public static Vector4 ZZWW(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.w, V.w); }
        public static Vector4 ZZW_(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, V.w, 0); }
        public static Vector4 ZZ_X(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, 0, V.x); }
        public static Vector4 ZZ_Y(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, 0, V.y); }
        public static Vector4 ZZ_Z(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, 0, V.z); }
        public static Vector4 ZZ_W(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, 0, V.w); }
        public static Vector4 ZZ__(this Vector4 V){ return VecOps.MkVector4(V.z, V.z, 0, 0); }
        public static Vector4 ZWXX(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.x, V.x); }
        public static Vector4 ZWXY(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.x, V.y); }
        public static Vector4 ZWXZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.x, V.z); }
        public static Vector4 ZWXW(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.x, V.w); }
        public static Vector4 ZWX_(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.x, 0); }
        public static Vector4 ZWYX(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.y, V.x); }
        public static Vector4 ZWYY(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.y, V.y); }
        public static Vector4 ZWYZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.y, V.z); }
        public static Vector4 ZWYW(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.y, V.w); }
        public static Vector4 ZWY_(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.y, 0); }
        public static Vector4 ZWZX(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.z, V.x); }
        public static Vector4 ZWZY(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.z, V.y); }
        public static Vector4 ZWZZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.z, V.z); }
        public static Vector4 ZWZW(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.z, V.w); }
        public static Vector4 ZWZ_(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.z, 0); }
        public static Vector4 ZWWX(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.w, V.x); }
        public static Vector4 ZWWY(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.w, V.y); }
        public static Vector4 ZWWZ(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.w, V.z); }
        public static Vector4 ZWWW(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.w, V.w); }
        public static Vector4 ZWW_(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, V.w, 0); }
        public static Vector4 ZW_X(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, 0, V.x); }
        public static Vector4 ZW_Y(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, 0, V.y); }
        public static Vector4 ZW_Z(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, 0, V.z); }
        public static Vector4 ZW_W(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, 0, V.w); }
        public static Vector4 ZW__(this Vector4 V){ return VecOps.MkVector4(V.z, V.w, 0, 0); }
        public static Vector4 Z_XX(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.x, V.x); }
        public static Vector4 Z_XY(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.x, V.y); }
        public static Vector4 Z_XZ(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.x, V.z); }
        public static Vector4 Z_XW(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.x, V.w); }
        public static Vector4 Z_X_(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.x, 0); }
        public static Vector4 Z_YX(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.y, V.x); }
        public static Vector4 Z_YY(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.y, V.y); }
        public static Vector4 Z_YZ(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.y, V.z); }
        public static Vector4 Z_YW(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.y, V.w); }
        public static Vector4 Z_Y_(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.y, 0); }
        public static Vector4 Z_ZX(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.z, V.x); }
        public static Vector4 Z_ZY(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.z, V.y); }
        public static Vector4 Z_ZZ(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.z, V.z); }
        public static Vector4 Z_ZW(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.z, V.w); }
        public static Vector4 Z_Z_(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.z, 0); }
        public static Vector4 Z_WX(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.w, V.x); }
        public static Vector4 Z_WY(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.w, V.y); }
        public static Vector4 Z_WZ(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.w, V.z); }
        public static Vector4 Z_WW(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.w, V.w); }
        public static Vector4 Z_W_(this Vector4 V){ return VecOps.MkVector4(V.z, 0, V.w, 0); }
        public static Vector4 Z__X(this Vector4 V){ return VecOps.MkVector4(V.z, 0, 0, V.x); }
        public static Vector4 Z__Y(this Vector4 V){ return VecOps.MkVector4(V.z, 0, 0, V.y); }
        public static Vector4 Z__Z(this Vector4 V){ return VecOps.MkVector4(V.z, 0, 0, V.z); }
        public static Vector4 Z__W(this Vector4 V){ return VecOps.MkVector4(V.z, 0, 0, V.w); }
        public static Vector4 Z___(this Vector4 V){ return VecOps.MkVector4(V.z, 0, 0, 0); }
        public static Vector4 WXXX(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.x, V.x); }
        public static Vector4 WXXY(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.x, V.y); }
        public static Vector4 WXXZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.x, V.z); }
        public static Vector4 WXXW(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.x, V.w); }
        public static Vector4 WXX_(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.x, 0); }
        public static Vector4 WXYX(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.y, V.x); }
        public static Vector4 WXYY(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.y, V.y); }
        public static Vector4 WXYZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.y, V.z); }
        public static Vector4 WXYW(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.y, V.w); }
        public static Vector4 WXY_(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.y, 0); }
        public static Vector4 WXZX(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.z, V.x); }
        public static Vector4 WXZY(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.z, V.y); }
        public static Vector4 WXZZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.z, V.z); }
        public static Vector4 WXZW(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.z, V.w); }
        public static Vector4 WXZ_(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.z, 0); }
        public static Vector4 WXWX(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.w, V.x); }
        public static Vector4 WXWY(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.w, V.y); }
        public static Vector4 WXWZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.w, V.z); }
        public static Vector4 WXWW(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.w, V.w); }
        public static Vector4 WXW_(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, V.w, 0); }
        public static Vector4 WX_X(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, 0, V.x); }
        public static Vector4 WX_Y(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, 0, V.y); }
        public static Vector4 WX_Z(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, 0, V.z); }
        public static Vector4 WX_W(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, 0, V.w); }
        public static Vector4 WX__(this Vector4 V){ return VecOps.MkVector4(V.w, V.x, 0, 0); }
        public static Vector4 WYXX(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.x, V.x); }
        public static Vector4 WYXY(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.x, V.y); }
        public static Vector4 WYXZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.x, V.z); }
        public static Vector4 WYXW(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.x, V.w); }
        public static Vector4 WYX_(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.x, 0); }
        public static Vector4 WYYX(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.y, V.x); }
        public static Vector4 WYYY(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.y, V.y); }
        public static Vector4 WYYZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.y, V.z); }
        public static Vector4 WYYW(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.y, V.w); }
        public static Vector4 WYY_(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.y, 0); }
        public static Vector4 WYZX(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.z, V.x); }
        public static Vector4 WYZY(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.z, V.y); }
        public static Vector4 WYZZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.z, V.z); }
        public static Vector4 WYZW(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.z, V.w); }
        public static Vector4 WYZ_(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.z, 0); }
        public static Vector4 WYWX(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.w, V.x); }
        public static Vector4 WYWY(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.w, V.y); }
        public static Vector4 WYWZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.w, V.z); }
        public static Vector4 WYWW(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.w, V.w); }
        public static Vector4 WYW_(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, V.w, 0); }
        public static Vector4 WY_X(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, 0, V.x); }
        public static Vector4 WY_Y(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, 0, V.y); }
        public static Vector4 WY_Z(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, 0, V.z); }
        public static Vector4 WY_W(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, 0, V.w); }
        public static Vector4 WY__(this Vector4 V){ return VecOps.MkVector4(V.w, V.y, 0, 0); }
        public static Vector4 WZXX(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.x, V.x); }
        public static Vector4 WZXY(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.x, V.y); }
        public static Vector4 WZXZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.x, V.z); }
        public static Vector4 WZXW(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.x, V.w); }
        public static Vector4 WZX_(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.x, 0); }
        public static Vector4 WZYX(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.y, V.x); }
        public static Vector4 WZYY(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.y, V.y); }
        public static Vector4 WZYZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.y, V.z); }
        public static Vector4 WZYW(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.y, V.w); }
        public static Vector4 WZY_(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.y, 0); }
        public static Vector4 WZZX(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.z, V.x); }
        public static Vector4 WZZY(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.z, V.y); }
        public static Vector4 WZZZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.z, V.z); }
        public static Vector4 WZZW(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.z, V.w); }
        public static Vector4 WZZ_(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.z, 0); }
        public static Vector4 WZWX(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.w, V.x); }
        public static Vector4 WZWY(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.w, V.y); }
        public static Vector4 WZWZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.w, V.z); }
        public static Vector4 WZWW(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.w, V.w); }
        public static Vector4 WZW_(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, V.w, 0); }
        public static Vector4 WZ_X(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, 0, V.x); }
        public static Vector4 WZ_Y(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, 0, V.y); }
        public static Vector4 WZ_Z(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, 0, V.z); }
        public static Vector4 WZ_W(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, 0, V.w); }
        public static Vector4 WZ__(this Vector4 V){ return VecOps.MkVector4(V.w, V.z, 0, 0); }
        public static Vector4 WWXX(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.x, V.x); }
        public static Vector4 WWXY(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.x, V.y); }
        public static Vector4 WWXZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.x, V.z); }
        public static Vector4 WWXW(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.x, V.w); }
        public static Vector4 WWX_(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.x, 0); }
        public static Vector4 WWYX(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.y, V.x); }
        public static Vector4 WWYY(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.y, V.y); }
        public static Vector4 WWYZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.y, V.z); }
        public static Vector4 WWYW(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.y, V.w); }
        public static Vector4 WWY_(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.y, 0); }
        public static Vector4 WWZX(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.z, V.x); }
        public static Vector4 WWZY(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.z, V.y); }
        public static Vector4 WWZZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.z, V.z); }
        public static Vector4 WWZW(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.z, V.w); }
        public static Vector4 WWZ_(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.z, 0); }
        public static Vector4 WWWX(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.w, V.x); }
        public static Vector4 WWWY(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.w, V.y); }
        public static Vector4 WWWZ(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.w, V.z); }
        public static Vector4 WWWW(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.w, V.w); }
        public static Vector4 WWW_(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, V.w, 0); }
        public static Vector4 WW_X(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, 0, V.x); }
        public static Vector4 WW_Y(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, 0, V.y); }
        public static Vector4 WW_Z(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, 0, V.z); }
        public static Vector4 WW_W(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, 0, V.w); }
        public static Vector4 WW__(this Vector4 V){ return VecOps.MkVector4(V.w, V.w, 0, 0); }
        public static Vector4 W_XX(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.x, V.x); }
        public static Vector4 W_XY(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.x, V.y); }
        public static Vector4 W_XZ(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.x, V.z); }
        public static Vector4 W_XW(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.x, V.w); }
        public static Vector4 W_X_(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.x, 0); }
        public static Vector4 W_YX(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.y, V.x); }
        public static Vector4 W_YY(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.y, V.y); }
        public static Vector4 W_YZ(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.y, V.z); }
        public static Vector4 W_YW(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.y, V.w); }
        public static Vector4 W_Y_(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.y, 0); }
        public static Vector4 W_ZX(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.z, V.x); }
        public static Vector4 W_ZY(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.z, V.y); }
        public static Vector4 W_ZZ(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.z, V.z); }
        public static Vector4 W_ZW(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.z, V.w); }
        public static Vector4 W_Z_(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.z, 0); }
        public static Vector4 W_WX(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.w, V.x); }
        public static Vector4 W_WY(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.w, V.y); }
        public static Vector4 W_WZ(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.w, V.z); }
        public static Vector4 W_WW(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.w, V.w); }
        public static Vector4 W_W_(this Vector4 V){ return VecOps.MkVector4(V.w, 0, V.w, 0); }
        public static Vector4 W__X(this Vector4 V){ return VecOps.MkVector4(V.w, 0, 0, V.x); }
        public static Vector4 W__Y(this Vector4 V){ return VecOps.MkVector4(V.w, 0, 0, V.y); }
        public static Vector4 W__Z(this Vector4 V){ return VecOps.MkVector4(V.w, 0, 0, V.z); }
        public static Vector4 W__W(this Vector4 V){ return VecOps.MkVector4(V.w, 0, 0, V.w); }
        public static Vector4 W___(this Vector4 V){ return VecOps.MkVector4(V.w, 0, 0, 0); }
        public static Vector4 _XXX(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.x, V.x); }
        public static Vector4 _XXY(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.x, V.y); }
        public static Vector4 _XXZ(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.x, V.z); }
        public static Vector4 _XXW(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.x, V.w); }
        public static Vector4 _XX_(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.x, 0); }
        public static Vector4 _XYX(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.y, V.x); }
        public static Vector4 _XYY(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.y, V.y); }
        public static Vector4 _XYZ(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.y, V.z); }
        public static Vector4 _XYW(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.y, V.w); }
        public static Vector4 _XY_(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.y, 0); }
        public static Vector4 _XZX(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.z, V.x); }
        public static Vector4 _XZY(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.z, V.y); }
        public static Vector4 _XZZ(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.z, V.z); }
        public static Vector4 _XZW(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.z, V.w); }
        public static Vector4 _XZ_(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.z, 0); }
        public static Vector4 _XWX(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.w, V.x); }
        public static Vector4 _XWY(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.w, V.y); }
        public static Vector4 _XWZ(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.w, V.z); }
        public static Vector4 _XWW(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.w, V.w); }
        public static Vector4 _XW_(this Vector4 V){ return VecOps.MkVector4(0, V.x, V.w, 0); }
        public static Vector4 _X_X(this Vector4 V){ return VecOps.MkVector4(0, V.x, 0, V.x); }
        public static Vector4 _X_Y(this Vector4 V){ return VecOps.MkVector4(0, V.x, 0, V.y); }
        public static Vector4 _X_Z(this Vector4 V){ return VecOps.MkVector4(0, V.x, 0, V.z); }
        public static Vector4 _X_W(this Vector4 V){ return VecOps.MkVector4(0, V.x, 0, V.w); }
        public static Vector4 _X__(this Vector4 V){ return VecOps.MkVector4(0, V.x, 0, 0); }
        public static Vector4 _YXX(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.x, V.x); }
        public static Vector4 _YXY(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.x, V.y); }
        public static Vector4 _YXZ(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.x, V.z); }
        public static Vector4 _YXW(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.x, V.w); }
        public static Vector4 _YX_(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.x, 0); }
        public static Vector4 _YYX(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.y, V.x); }
        public static Vector4 _YYY(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.y, V.y); }
        public static Vector4 _YYZ(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.y, V.z); }
        public static Vector4 _YYW(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.y, V.w); }
        public static Vector4 _YY_(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.y, 0); }
        public static Vector4 _YZX(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.z, V.x); }
        public static Vector4 _YZY(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.z, V.y); }
        public static Vector4 _YZZ(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.z, V.z); }
        public static Vector4 _YZW(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.z, V.w); }
        public static Vector4 _YZ_(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.z, 0); }
        public static Vector4 _YWX(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.w, V.x); }
        public static Vector4 _YWY(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.w, V.y); }
        public static Vector4 _YWZ(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.w, V.z); }
        public static Vector4 _YWW(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.w, V.w); }
        public static Vector4 _YW_(this Vector4 V){ return VecOps.MkVector4(0, V.y, V.w, 0); }
        public static Vector4 _Y_X(this Vector4 V){ return VecOps.MkVector4(0, V.y, 0, V.x); }
        public static Vector4 _Y_Y(this Vector4 V){ return VecOps.MkVector4(0, V.y, 0, V.y); }
        public static Vector4 _Y_Z(this Vector4 V){ return VecOps.MkVector4(0, V.y, 0, V.z); }
        public static Vector4 _Y_W(this Vector4 V){ return VecOps.MkVector4(0, V.y, 0, V.w); }
        public static Vector4 _Y__(this Vector4 V){ return VecOps.MkVector4(0, V.y, 0, 0); }
        public static Vector4 _ZXX(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.x, V.x); }
        public static Vector4 _ZXY(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.x, V.y); }
        public static Vector4 _ZXZ(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.x, V.z); }
        public static Vector4 _ZXW(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.x, V.w); }
        public static Vector4 _ZX_(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.x, 0); }
        public static Vector4 _ZYX(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.y, V.x); }
        public static Vector4 _ZYY(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.y, V.y); }
        public static Vector4 _ZYZ(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.y, V.z); }
        public static Vector4 _ZYW(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.y, V.w); }
        public static Vector4 _ZY_(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.y, 0); }
        public static Vector4 _ZZX(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.z, V.x); }
        public static Vector4 _ZZY(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.z, V.y); }
        public static Vector4 _ZZZ(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.z, V.z); }
        public static Vector4 _ZZW(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.z, V.w); }
        public static Vector4 _ZZ_(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.z, 0); }
        public static Vector4 _ZWX(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.w, V.x); }
        public static Vector4 _ZWY(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.w, V.y); }
        public static Vector4 _ZWZ(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.w, V.z); }
        public static Vector4 _ZWW(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.w, V.w); }
        public static Vector4 _ZW_(this Vector4 V){ return VecOps.MkVector4(0, V.z, V.w, 0); }
        public static Vector4 _Z_X(this Vector4 V){ return VecOps.MkVector4(0, V.z, 0, V.x); }
        public static Vector4 _Z_Y(this Vector4 V){ return VecOps.MkVector4(0, V.z, 0, V.y); }
        public static Vector4 _Z_Z(this Vector4 V){ return VecOps.MkVector4(0, V.z, 0, V.z); }
        public static Vector4 _Z_W(this Vector4 V){ return VecOps.MkVector4(0, V.z, 0, V.w); }
        public static Vector4 _Z__(this Vector4 V){ return VecOps.MkVector4(0, V.z, 0, 0); }
        public static Vector4 _WXX(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.x, V.x); }
        public static Vector4 _WXY(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.x, V.y); }
        public static Vector4 _WXZ(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.x, V.z); }
        public static Vector4 _WXW(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.x, V.w); }
        public static Vector4 _WX_(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.x, 0); }
        public static Vector4 _WYX(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.y, V.x); }
        public static Vector4 _WYY(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.y, V.y); }
        public static Vector4 _WYZ(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.y, V.z); }
        public static Vector4 _WYW(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.y, V.w); }
        public static Vector4 _WY_(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.y, 0); }
        public static Vector4 _WZX(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.z, V.x); }
        public static Vector4 _WZY(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.z, V.y); }
        public static Vector4 _WZZ(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.z, V.z); }
        public static Vector4 _WZW(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.z, V.w); }
        public static Vector4 _WZ_(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.z, 0); }
        public static Vector4 _WWX(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.w, V.x); }
        public static Vector4 _WWY(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.w, V.y); }
        public static Vector4 _WWZ(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.w, V.z); }
        public static Vector4 _WWW(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.w, V.w); }
        public static Vector4 _WW_(this Vector4 V){ return VecOps.MkVector4(0, V.w, V.w, 0); }
        public static Vector4 _W_X(this Vector4 V){ return VecOps.MkVector4(0, V.w, 0, V.x); }
        public static Vector4 _W_Y(this Vector4 V){ return VecOps.MkVector4(0, V.w, 0, V.y); }
        public static Vector4 _W_Z(this Vector4 V){ return VecOps.MkVector4(0, V.w, 0, V.z); }
        public static Vector4 _W_W(this Vector4 V){ return VecOps.MkVector4(0, V.w, 0, V.w); }
        public static Vector4 _W__(this Vector4 V){ return VecOps.MkVector4(0, V.w, 0, 0); }
        public static Vector4 __XX(this Vector4 V){ return VecOps.MkVector4(0, 0, V.x, V.x); }
        public static Vector4 __XY(this Vector4 V){ return VecOps.MkVector4(0, 0, V.x, V.y); }
        public static Vector4 __XZ(this Vector4 V){ return VecOps.MkVector4(0, 0, V.x, V.z); }
        public static Vector4 __XW(this Vector4 V){ return VecOps.MkVector4(0, 0, V.x, V.w); }
        public static Vector4 __X_(this Vector4 V){ return VecOps.MkVector4(0, 0, V.x, 0); }
        public static Vector4 __YX(this Vector4 V){ return VecOps.MkVector4(0, 0, V.y, V.x); }
        public static Vector4 __YY(this Vector4 V){ return VecOps.MkVector4(0, 0, V.y, V.y); }
        public static Vector4 __YZ(this Vector4 V){ return VecOps.MkVector4(0, 0, V.y, V.z); }
        public static Vector4 __YW(this Vector4 V){ return VecOps.MkVector4(0, 0, V.y, V.w); }
        public static Vector4 __Y_(this Vector4 V){ return VecOps.MkVector4(0, 0, V.y, 0); }
        public static Vector4 __ZX(this Vector4 V){ return VecOps.MkVector4(0, 0, V.z, V.x); }
        public static Vector4 __ZY(this Vector4 V){ return VecOps.MkVector4(0, 0, V.z, V.y); }
        public static Vector4 __ZZ(this Vector4 V){ return VecOps.MkVector4(0, 0, V.z, V.z); }
        public static Vector4 __ZW(this Vector4 V){ return VecOps.MkVector4(0, 0, V.z, V.w); }
        public static Vector4 __Z_(this Vector4 V){ return VecOps.MkVector4(0, 0, V.z, 0); }
        public static Vector4 __WX(this Vector4 V){ return VecOps.MkVector4(0, 0, V.w, V.x); }
        public static Vector4 __WY(this Vector4 V){ return VecOps.MkVector4(0, 0, V.w, V.y); }
        public static Vector4 __WZ(this Vector4 V){ return VecOps.MkVector4(0, 0, V.w, V.z); }
        public static Vector4 __WW(this Vector4 V){ return VecOps.MkVector4(0, 0, V.w, V.w); }
        public static Vector4 __W_(this Vector4 V){ return VecOps.MkVector4(0, 0, V.w, 0); }
        public static Vector4 ___X(this Vector4 V){ return VecOps.MkVector4(0, 0, 0, V.x); }
        public static Vector4 ___Y(this Vector4 V){ return VecOps.MkVector4(0, 0, 0, V.y); }
        public static Vector4 ___Z(this Vector4 V){ return VecOps.MkVector4(0, 0, 0, V.z); }
        public static Vector4 ___W(this Vector4 V){ return VecOps.MkVector4(0, 0, 0, V.w); }
    }
}
