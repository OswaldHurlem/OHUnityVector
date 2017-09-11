// Generated with oh_unity_vector_generator.py
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;

namespace OH
{
    [StructLayout(LayoutKind.Sequential, Pack=0)]
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
                int hashCode = x;
                hashCode = (hashCode * 397) ^ x;
                hashCode = (hashCode * 397) ^ y;
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0)]
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
                int hashCode = x;
                hashCode = (hashCode * 397) ^ x;
                hashCode = (hashCode * 397) ^ y;
                hashCode = (hashCode * 397) ^ z;
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0)]
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
                int hashCode = x;
                hashCode = (hashCode * 397) ^ x;
                hashCode = (hashCode * 397) ^ y;
                hashCode = (hashCode * 397) ^ z;
                hashCode = (hashCode * 397) ^ w;
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0)]
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
                int hashCode = x;
                hashCode = (hashCode * 397) ^ x;
                hashCode = (hashCode * 397) ^ y;
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0)]
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
                int hashCode = x;
                hashCode = (hashCode * 397) ^ x;
                hashCode = (hashCode * 397) ^ y;
                hashCode = (hashCode * 397) ^ z;
                return hashCode;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack=0)]
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
                int hashCode = x;
                hashCode = (hashCode * 397) ^ x;
                hashCode = (hashCode * 397) ^ y;
                hashCode = (hashCode * 397) ^ z;
                hashCode = (hashCode * 397) ^ w;
                return hashCode;
            }
        }
    }

}