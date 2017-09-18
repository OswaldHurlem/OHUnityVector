// Generated with oh_unity_vector_generator.py
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEditor;

namespace OH
{
    [StructLayout(LayoutKind.Sequential, Pack=0), Serializable]
    public struct VectorI2 : IEquatable<VectorI2>
    {
        // All state
        public Int32 x, y;
        
        // Member functions
        public Int32 this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    default: { return Int32.MaxValue; }
                }
            }
            set
            {
                switch (i)
                {
                    case 0: { x = value; break; }
                    case 1: { y = value; break; }
                }
            }
        }

        public static VectorI2 left = VecOps.MkVectorI2(-1,  0 );
        public static VectorI2 down = VecOps.MkVectorI2( 0, -1 );
        public static VectorI2 right = VecOps.MkVectorI2( 1,  0 );
        public static VectorI2 up    = VecOps.MkVectorI2( 0,  1 );
        
        public static Boolean operator==(VectorI2 A, VectorI2 B)
        {
            return (A.x == B.x)
                && (A.y == B.y);
        }

        public static Boolean operator!=(VectorI2 A, VectorI2 B)
        {
            return (A.x != B.x)
                || (A.y != B.y);
        }

        public static VectorI2 operator-(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(A.x - B.x),
                (Int32)(A.y - B.y));
        }

        public static VectorI2 operator+(VectorI2 A, VectorI2 B)
        {
            return VecOps.MkVectorI2(
                (Int32)(A.x + B.x),
                (Int32)(A.y + B.y));
        }

        public static VectorI2 operator-(VectorI2 V)
        {
            return VecOps.MkVectorI2(-V.x, -V.y);
        }

        public static VectorI2 operator*(Int32 A, VectorI2 V)
        {
            return VecOps.MkVectorI2(
                (Int32)((A * V.x)),
                (Int32)((A * V.y)));
        }

        public static VectorI2 operator/(Int32 A, VectorI2 V)
        {
            return VecOps.MkVectorI2(
                (Int32)((Arith.Div(A, V.x))),
                (Int32)((Arith.Div(A, V.y))));
        }

        public static VectorI2 operator*(VectorI2 V, Int32 A)
        {
            return VecOps.MkVectorI2(
                (Int32)((V.x * A)),
                (Int32)((V.y * A)));
        }

        public static VectorI2 operator/(VectorI2 V, Int32 A)
        {
            return VecOps.MkVectorI2(
                (Int32)((Arith.Div(V.x, A))),
                (Int32)((Arith.Div(V.y, A))));
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}}}", x, y);
        }

        public Boolean Equals(VectorI2 other)
        {
            return this == other;
        }

        public override Boolean Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VectorI2 && Equals((VectorI2)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0), Serializable]
    public struct VectorI3 : IEquatable<VectorI3>
    {
        // All state
        public Int32 x, y, z;
        
        // Member functions
        public Int32 this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    case 2: { return z; }
                    default: { return Int32.MaxValue; }
                }
            }
            set
            {
                switch (i)
                {
                    case 0: { x = value; break; }
                    case 1: { y = value; break; }
                    case 2: { z = value; break; }
                }
            }
        }

        public static VectorI3 left  = VecOps.MkVectorI3(-1,  0,  0 );
        public static VectorI3 down  = VecOps.MkVectorI3( 0, -1,  0 );
        public static VectorI3 back  = VecOps.MkVectorI3( 0,  0, -1 );
        public static VectorI3 right   = VecOps.MkVectorI3( 1,  0,  0 );
        public static VectorI3 up      = VecOps.MkVectorI3( 0,  1,  0 );
        public static VectorI3 forward = VecOps.MkVectorI3( 0,  0,  1 );
        
        public static Boolean operator==(VectorI3 A, VectorI3 B)
        {
            return (A.x == B.x)
                && (A.y == B.y)
                && (A.z == B.z);
        }

        public static Boolean operator!=(VectorI3 A, VectorI3 B)
        {
            return (A.x != B.x)
                || (A.y != B.y)
                || (A.z != B.z);
        }

        public static VectorI3 operator-(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(A.x - B.x),
                (Int32)(A.y - B.y),
                (Int32)(A.z - B.z));
        }

        public static VectorI3 operator+(VectorI3 A, VectorI3 B)
        {
            return VecOps.MkVectorI3(
                (Int32)(A.x + B.x),
                (Int32)(A.y + B.y),
                (Int32)(A.z + B.z));
        }

        public static VectorI3 operator-(VectorI3 V)
        {
            return VecOps.MkVectorI3(-V.x, -V.y, -V.z);
        }

        public static VectorI3 operator*(Int32 A, VectorI3 V)
        {
            return VecOps.MkVectorI3(
                (Int32)((A * V.x)),
                (Int32)((A * V.y)),
                (Int32)((A * V.z)));
        }

        public static VectorI3 operator/(Int32 A, VectorI3 V)
        {
            return VecOps.MkVectorI3(
                (Int32)((Arith.Div(A, V.x))),
                (Int32)((Arith.Div(A, V.y))),
                (Int32)((Arith.Div(A, V.z))));
        }

        public static VectorI3 operator*(VectorI3 V, Int32 A)
        {
            return VecOps.MkVectorI3(
                (Int32)((V.x * A)),
                (Int32)((V.y * A)),
                (Int32)((V.z * A)));
        }

        public static VectorI3 operator/(VectorI3 V, Int32 A)
        {
            return VecOps.MkVectorI3(
                (Int32)((Arith.Div(V.x, A))),
                (Int32)((Arith.Div(V.y, A))),
                (Int32)((Arith.Div(V.z, A))));
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}, {2}}}", x, y, z);
        }

        public Boolean Equals(VectorI3 other)
        {
            return this == other;
        }

        public override Boolean Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VectorI3 && Equals((VectorI3)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                hashCode = (hashCode * 397) ^ z.GetHashCode();
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0), Serializable]
    public struct VectorI4 : IEquatable<VectorI4>
    {
        // All state
        public Int32 x, y, z, w;
        
        // Member functions
        public Int32 this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    case 2: { return z; }
                    case 3: { return w; }
                    default: { return Int32.MaxValue; }
                }
            }
            set
            {
                switch (i)
                {
                    case 0: { x = value; break; }
                    case 1: { y = value; break; }
                    case 2: { z = value; break; }
                    case 3: { w = value; break; }
                }
            }
        }

        
        public static Boolean operator==(VectorI4 A, VectorI4 B)
        {
            return (A.x == B.x)
                && (A.y == B.y)
                && (A.z == B.z)
                && (A.w == B.w);
        }

        public static Boolean operator!=(VectorI4 A, VectorI4 B)
        {
            return (A.x != B.x)
                || (A.y != B.y)
                || (A.z != B.z)
                || (A.w != B.w);
        }

        public static VectorI4 operator-(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(A.x - B.x),
                (Int32)(A.y - B.y),
                (Int32)(A.z - B.z),
                (Int32)(A.w - B.w));
        }

        public static VectorI4 operator+(VectorI4 A, VectorI4 B)
        {
            return VecOps.MkVectorI4(
                (Int32)(A.x + B.x),
                (Int32)(A.y + B.y),
                (Int32)(A.z + B.z),
                (Int32)(A.w + B.w));
        }

        public static VectorI4 operator-(VectorI4 V)
        {
            return VecOps.MkVectorI4(-V.x, -V.y, -V.z, -V.w);
        }

        public static VectorI4 operator*(Int32 A, VectorI4 V)
        {
            return VecOps.MkVectorI4(
                (Int32)((A * V.x)),
                (Int32)((A * V.y)),
                (Int32)((A * V.z)),
                (Int32)((A * V.w)));
        }

        public static VectorI4 operator/(Int32 A, VectorI4 V)
        {
            return VecOps.MkVectorI4(
                (Int32)((Arith.Div(A, V.x))),
                (Int32)((Arith.Div(A, V.y))),
                (Int32)((Arith.Div(A, V.z))),
                (Int32)((Arith.Div(A, V.w))));
        }

        public static VectorI4 operator*(VectorI4 V, Int32 A)
        {
            return VecOps.MkVectorI4(
                (Int32)((V.x * A)),
                (Int32)((V.y * A)),
                (Int32)((V.z * A)),
                (Int32)((V.w * A)));
        }

        public static VectorI4 operator/(VectorI4 V, Int32 A)
        {
            return VecOps.MkVectorI4(
                (Int32)((Arith.Div(V.x, A))),
                (Int32)((Arith.Div(V.y, A))),
                (Int32)((Arith.Div(V.z, A))),
                (Int32)((Arith.Div(V.w, A))));
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}, {2}, {3}}}", x, y, z, w);
        }

        public Boolean Equals(VectorI4 other)
        {
            return this == other;
        }

        public override Boolean Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VectorI4 && Equals((VectorI4)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                hashCode = (hashCode * 397) ^ z.GetHashCode();
                hashCode = (hashCode * 397) ^ w.GetHashCode();
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0), Serializable]
    public struct VectorB2 : IEquatable<VectorB2>
    {
        // All state
        public byte x, y;
        
        // Member functions
        public byte this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    default: { return byte.MaxValue; }
                }
            }
            set
            {
                switch (i)
                {
                    case 0: { x = value; break; }
                    case 1: { y = value; break; }
                }
            }
        }

        public static VectorB2 right = VecOps.MkVectorB2( 1,  0 );
        public static VectorB2 up    = VecOps.MkVectorB2( 0,  1 );
        
        public static Boolean operator==(VectorB2 A, VectorB2 B)
        {
            return (A.x == B.x)
                && (A.y == B.y);
        }

        public static Boolean operator!=(VectorB2 A, VectorB2 B)
        {
            return (A.x != B.x)
                || (A.y != B.y);
        }

        public static VectorB2 operator-(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(A.x - B.x),
                (byte)(A.y - B.y));
        }

        public static VectorB2 operator+(VectorB2 A, VectorB2 B)
        {
            return VecOps.MkVectorB2(
                (byte)(A.x + B.x),
                (byte)(A.y + B.y));
        }

        public static VectorB2 operator*(byte A, VectorB2 V)
        {
            return VecOps.MkVectorB2(
                (byte)((A * V.x)),
                (byte)((A * V.y)));
        }

        public static VectorB2 operator/(byte A, VectorB2 V)
        {
            return VecOps.MkVectorB2(
                (byte)((Arith.Div(A, V.x))),
                (byte)((Arith.Div(A, V.y))));
        }

        public static VectorB2 operator*(VectorB2 V, byte A)
        {
            return VecOps.MkVectorB2(
                (byte)((V.x * A)),
                (byte)((V.y * A)));
        }

        public static VectorB2 operator/(VectorB2 V, byte A)
        {
            return VecOps.MkVectorB2(
                (byte)((Arith.Div(V.x, A))),
                (byte)((Arith.Div(V.y, A))));
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}}}", x, y);
        }

        public Boolean Equals(VectorB2 other)
        {
            return this == other;
        }

        public override Boolean Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VectorB2 && Equals((VectorB2)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0), Serializable]
    public struct VectorB3 : IEquatable<VectorB3>
    {
        // All state
        public byte x, y, z;
        
        // Member functions
        public byte this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    case 2: { return z; }
                    default: { return byte.MaxValue; }
                }
            }
            set
            {
                switch (i)
                {
                    case 0: { x = value; break; }
                    case 1: { y = value; break; }
                    case 2: { z = value; break; }
                }
            }
        }

        public static VectorB3 right   = VecOps.MkVectorB3( 1,  0,  0 );
        public static VectorB3 up      = VecOps.MkVectorB3( 0,  1,  0 );
        public static VectorB3 forward = VecOps.MkVectorB3( 0,  0,  1 );
        
        public static Boolean operator==(VectorB3 A, VectorB3 B)
        {
            return (A.x == B.x)
                && (A.y == B.y)
                && (A.z == B.z);
        }

        public static Boolean operator!=(VectorB3 A, VectorB3 B)
        {
            return (A.x != B.x)
                || (A.y != B.y)
                || (A.z != B.z);
        }

        public static VectorB3 operator-(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(A.x - B.x),
                (byte)(A.y - B.y),
                (byte)(A.z - B.z));
        }

        public static VectorB3 operator+(VectorB3 A, VectorB3 B)
        {
            return VecOps.MkVectorB3(
                (byte)(A.x + B.x),
                (byte)(A.y + B.y),
                (byte)(A.z + B.z));
        }

        public static VectorB3 operator*(byte A, VectorB3 V)
        {
            return VecOps.MkVectorB3(
                (byte)((A * V.x)),
                (byte)((A * V.y)),
                (byte)((A * V.z)));
        }

        public static VectorB3 operator/(byte A, VectorB3 V)
        {
            return VecOps.MkVectorB3(
                (byte)((Arith.Div(A, V.x))),
                (byte)((Arith.Div(A, V.y))),
                (byte)((Arith.Div(A, V.z))));
        }

        public static VectorB3 operator*(VectorB3 V, byte A)
        {
            return VecOps.MkVectorB3(
                (byte)((V.x * A)),
                (byte)((V.y * A)),
                (byte)((V.z * A)));
        }

        public static VectorB3 operator/(VectorB3 V, byte A)
        {
            return VecOps.MkVectorB3(
                (byte)((Arith.Div(V.x, A))),
                (byte)((Arith.Div(V.y, A))),
                (byte)((Arith.Div(V.z, A))));
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}, {2}}}", x, y, z);
        }

        public Boolean Equals(VectorB3 other)
        {
            return this == other;
        }

        public override Boolean Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VectorB3 && Equals((VectorB3)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                hashCode = (hashCode * 397) ^ z.GetHashCode();
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0), Serializable]
    public struct VectorB4 : IEquatable<VectorB4>
    {
        // All state
        public byte x, y, z, w;
        
        // Member functions
        public byte this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    case 2: { return z; }
                    case 3: { return w; }
                    default: { return byte.MaxValue; }
                }
            }
            set
            {
                switch (i)
                {
                    case 0: { x = value; break; }
                    case 1: { y = value; break; }
                    case 2: { z = value; break; }
                    case 3: { w = value; break; }
                }
            }
        }

        
        public static Boolean operator==(VectorB4 A, VectorB4 B)
        {
            return (A.x == B.x)
                && (A.y == B.y)
                && (A.z == B.z)
                && (A.w == B.w);
        }

        public static Boolean operator!=(VectorB4 A, VectorB4 B)
        {
            return (A.x != B.x)
                || (A.y != B.y)
                || (A.z != B.z)
                || (A.w != B.w);
        }

        public static VectorB4 operator-(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(A.x - B.x),
                (byte)(A.y - B.y),
                (byte)(A.z - B.z),
                (byte)(A.w - B.w));
        }

        public static VectorB4 operator+(VectorB4 A, VectorB4 B)
        {
            return VecOps.MkVectorB4(
                (byte)(A.x + B.x),
                (byte)(A.y + B.y),
                (byte)(A.z + B.z),
                (byte)(A.w + B.w));
        }

        public static VectorB4 operator*(byte A, VectorB4 V)
        {
            return VecOps.MkVectorB4(
                (byte)((A * V.x)),
                (byte)((A * V.y)),
                (byte)((A * V.z)),
                (byte)((A * V.w)));
        }

        public static VectorB4 operator/(byte A, VectorB4 V)
        {
            return VecOps.MkVectorB4(
                (byte)((Arith.Div(A, V.x))),
                (byte)((Arith.Div(A, V.y))),
                (byte)((Arith.Div(A, V.z))),
                (byte)((Arith.Div(A, V.w))));
        }

        public static VectorB4 operator*(VectorB4 V, byte A)
        {
            return VecOps.MkVectorB4(
                (byte)((V.x * A)),
                (byte)((V.y * A)),
                (byte)((V.z * A)),
                (byte)((V.w * A)));
        }

        public static VectorB4 operator/(VectorB4 V, byte A)
        {
            return VecOps.MkVectorB4(
                (byte)((Arith.Div(V.x, A))),
                (byte)((Arith.Div(V.y, A))),
                (byte)((Arith.Div(V.z, A))),
                (byte)((Arith.Div(V.w, A))));
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}, {2}, {3}}}", x, y, z, w);
        }

        public Boolean Equals(VectorB4 other)
        {
            return this == other;
        }

        public override Boolean Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VectorB4 && Equals((VectorB4)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                hashCode = (hashCode * 397) ^ z.GetHashCode();
                hashCode = (hashCode * 397) ^ w.GetHashCode();
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0), Serializable]
    public struct VectorD2 : IEquatable<VectorD2>
    {
        // All state
        public double x, y;
        
        // Member functions
        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    default: { return double.MaxValue; }
                }
            }
            set
            {
                switch (i)
                {
                    case 0: { x = value; break; }
                    case 1: { y = value; break; }
                }
            }
        }

        public static VectorD2 left = VecOps.MkVectorD2(-1,  0 );
        public static VectorD2 down = VecOps.MkVectorD2( 0, -1 );
        public static VectorD2 right = VecOps.MkVectorD2( 1,  0 );
        public static VectorD2 up    = VecOps.MkVectorD2( 0,  1 );
        
        public static Boolean operator==(VectorD2 A, VectorD2 B)
        {
            return (A.x == B.x)
                && (A.y == B.y);
        }

        public static Boolean operator!=(VectorD2 A, VectorD2 B)
        {
            return (A.x != B.x)
                || (A.y != B.y);
        }

        public static VectorD2 operator-(VectorD2 A, VectorD2 B)
        {
            return VecOps.MkVectorD2(
                (double)(A.x - B.x),
                (double)(A.y - B.y));
        }

        public static VectorD2 operator+(VectorD2 A, VectorD2 B)
        {
            return VecOps.MkVectorD2(
                (double)(A.x + B.x),
                (double)(A.y + B.y));
        }

        public static VectorD2 operator-(VectorD2 V)
        {
            return VecOps.MkVectorD2(-V.x, -V.y);
        }

        public static VectorD2 operator*(double A, VectorD2 V)
        {
            return VecOps.MkVectorD2(
                (double)((A * V.x)),
                (double)((A * V.y)));
        }

        public static VectorD2 operator/(double A, VectorD2 V)
        {
            return VecOps.MkVectorD2(
                (double)((Arith.Div(A, V.x))),
                (double)((Arith.Div(A, V.y))));
        }

        public static VectorD2 operator*(VectorD2 V, double A)
        {
            return VecOps.MkVectorD2(
                (double)((V.x * A)),
                (double)((V.y * A)));
        }

        public static VectorD2 operator/(VectorD2 V, double A)
        {
            return VecOps.MkVectorD2(
                (double)((Arith.Div(V.x, A))),
                (double)((Arith.Div(V.y, A))));
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}}}", x, y);
        }

        public Boolean Equals(VectorD2 other)
        {
            return this == other;
        }

        public override Boolean Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VectorD2 && Equals((VectorD2)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0), Serializable]
    public struct VectorD3 : IEquatable<VectorD3>
    {
        // All state
        public double x, y, z;
        
        // Member functions
        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    case 2: { return z; }
                    default: { return double.MaxValue; }
                }
            }
            set
            {
                switch (i)
                {
                    case 0: { x = value; break; }
                    case 1: { y = value; break; }
                    case 2: { z = value; break; }
                }
            }
        }

        public static VectorD3 left  = VecOps.MkVectorD3(-1,  0,  0 );
        public static VectorD3 down  = VecOps.MkVectorD3( 0, -1,  0 );
        public static VectorD3 back  = VecOps.MkVectorD3( 0,  0, -1 );
        public static VectorD3 right   = VecOps.MkVectorD3( 1,  0,  0 );
        public static VectorD3 up      = VecOps.MkVectorD3( 0,  1,  0 );
        public static VectorD3 forward = VecOps.MkVectorD3( 0,  0,  1 );
        
        public static Boolean operator==(VectorD3 A, VectorD3 B)
        {
            return (A.x == B.x)
                && (A.y == B.y)
                && (A.z == B.z);
        }

        public static Boolean operator!=(VectorD3 A, VectorD3 B)
        {
            return (A.x != B.x)
                || (A.y != B.y)
                || (A.z != B.z);
        }

        public static VectorD3 operator-(VectorD3 A, VectorD3 B)
        {
            return VecOps.MkVectorD3(
                (double)(A.x - B.x),
                (double)(A.y - B.y),
                (double)(A.z - B.z));
        }

        public static VectorD3 operator+(VectorD3 A, VectorD3 B)
        {
            return VecOps.MkVectorD3(
                (double)(A.x + B.x),
                (double)(A.y + B.y),
                (double)(A.z + B.z));
        }

        public static VectorD3 operator-(VectorD3 V)
        {
            return VecOps.MkVectorD3(-V.x, -V.y, -V.z);
        }

        public static VectorD3 operator*(double A, VectorD3 V)
        {
            return VecOps.MkVectorD3(
                (double)((A * V.x)),
                (double)((A * V.y)),
                (double)((A * V.z)));
        }

        public static VectorD3 operator/(double A, VectorD3 V)
        {
            return VecOps.MkVectorD3(
                (double)((Arith.Div(A, V.x))),
                (double)((Arith.Div(A, V.y))),
                (double)((Arith.Div(A, V.z))));
        }

        public static VectorD3 operator*(VectorD3 V, double A)
        {
            return VecOps.MkVectorD3(
                (double)((V.x * A)),
                (double)((V.y * A)),
                (double)((V.z * A)));
        }

        public static VectorD3 operator/(VectorD3 V, double A)
        {
            return VecOps.MkVectorD3(
                (double)((Arith.Div(V.x, A))),
                (double)((Arith.Div(V.y, A))),
                (double)((Arith.Div(V.z, A))));
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}, {2}}}", x, y, z);
        }

        public Boolean Equals(VectorD3 other)
        {
            return this == other;
        }

        public override Boolean Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VectorD3 && Equals((VectorD3)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                hashCode = (hashCode * 397) ^ z.GetHashCode();
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0), Serializable]
    public struct VectorD4 : IEquatable<VectorD4>
    {
        // All state
        public double x, y, z, w;
        
        // Member functions
        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    case 2: { return z; }
                    case 3: { return w; }
                    default: { return double.MaxValue; }
                }
            }
            set
            {
                switch (i)
                {
                    case 0: { x = value; break; }
                    case 1: { y = value; break; }
                    case 2: { z = value; break; }
                    case 3: { w = value; break; }
                }
            }
        }

        
        public static Boolean operator==(VectorD4 A, VectorD4 B)
        {
            return (A.x == B.x)
                && (A.y == B.y)
                && (A.z == B.z)
                && (A.w == B.w);
        }

        public static Boolean operator!=(VectorD4 A, VectorD4 B)
        {
            return (A.x != B.x)
                || (A.y != B.y)
                || (A.z != B.z)
                || (A.w != B.w);
        }

        public static VectorD4 operator-(VectorD4 A, VectorD4 B)
        {
            return VecOps.MkVectorD4(
                (double)(A.x - B.x),
                (double)(A.y - B.y),
                (double)(A.z - B.z),
                (double)(A.w - B.w));
        }

        public static VectorD4 operator+(VectorD4 A, VectorD4 B)
        {
            return VecOps.MkVectorD4(
                (double)(A.x + B.x),
                (double)(A.y + B.y),
                (double)(A.z + B.z),
                (double)(A.w + B.w));
        }

        public static VectorD4 operator-(VectorD4 V)
        {
            return VecOps.MkVectorD4(-V.x, -V.y, -V.z, -V.w);
        }

        public static VectorD4 operator*(double A, VectorD4 V)
        {
            return VecOps.MkVectorD4(
                (double)((A * V.x)),
                (double)((A * V.y)),
                (double)((A * V.z)),
                (double)((A * V.w)));
        }

        public static VectorD4 operator/(double A, VectorD4 V)
        {
            return VecOps.MkVectorD4(
                (double)((Arith.Div(A, V.x))),
                (double)((Arith.Div(A, V.y))),
                (double)((Arith.Div(A, V.z))),
                (double)((Arith.Div(A, V.w))));
        }

        public static VectorD4 operator*(VectorD4 V, double A)
        {
            return VecOps.MkVectorD4(
                (double)((V.x * A)),
                (double)((V.y * A)),
                (double)((V.z * A)),
                (double)((V.w * A)));
        }

        public static VectorD4 operator/(VectorD4 V, double A)
        {
            return VecOps.MkVectorD4(
                (double)((Arith.Div(V.x, A))),
                (double)((Arith.Div(V.y, A))),
                (double)((Arith.Div(V.z, A))),
                (double)((Arith.Div(V.w, A))));
        }

        public override string ToString()
        {
            return string.Format("{{{0}, {1}, {2}, {3}}}", x, y, z, w);
        }

        public Boolean Equals(VectorD4 other)
        {
            return this == other;
        }

        public override Boolean Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is VectorD4 && Equals((VectorD4)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = 0;
                hashCode = (hashCode * 397) ^ x.GetHashCode();
                hashCode = (hashCode * 397) ^ y.GetHashCode();
                hashCode = (hashCode * 397) ^ z.GetHashCode();
                hashCode = (hashCode * 397) ^ w.GetHashCode();
                return hashCode;
            }
        }
    }

}