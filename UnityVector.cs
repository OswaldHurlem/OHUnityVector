// Generated with oh_unity_vector_generator.py
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;

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

        public static VectorI2 left = OHV.MkVectorI2(-1,  0 );
        public static VectorI2 down = OHV.MkVectorI2( 0, -1 );
        public static VectorI2 right = OHV.MkVectorI2( 1,  0 );
        public static VectorI2 up    = OHV.MkVectorI2( 0,  1 );
        public static VectorI2 one = OHV.MkVectorI2(1);
        public static VectorI2 zero = OHV.MkVectorI2(0);
        public static VectorI2 MinValue = OHV.MkVectorI2(Int32.MinValue);
        public static VectorI2 MaxValue = OHV.MkVectorI2(Int32.MaxValue);
        
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
            return OHV.MkVectorI2(
                (Int32)(A.x - B.x),
                (Int32)(A.y - B.y));
        }

        public static VectorI2 operator+(VectorI2 A, VectorI2 B)
        {
            return OHV.MkVectorI2(
                (Int32)(A.x + B.x),
                (Int32)(A.y + B.y));
        }

        public static VectorI2 operator-(VectorI2 V)
        {
            return OHV.MkVectorI2(-V.x, -V.y);
        }

        public static VectorI2 operator*(Int32 A, VectorI2 V)
        {
            return OHV.MkVectorI2(
                (Int32)((A * V.x)),
                (Int32)((A * V.y)));
        }

        public static VectorI2 operator/(Int32 A, VectorI2 V)
        {
            return OHV.MkVectorI2(
                (Int32)((Arith.Div(A, V.x))),
                (Int32)((Arith.Div(A, V.y))));
        }

        public static VectorI2 operator*(VectorI2 V, Int32 A)
        {
            return OHV.MkVectorI2(
                (Int32)((V.x * A)),
                (Int32)((V.y * A)));
        }

        public static VectorI2 operator/(VectorI2 V, Int32 A)
        {
            return OHV.MkVectorI2(
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

        public static VectorI3 left  = OHV.MkVectorI3(-1,  0,  0 );
        public static VectorI3 down  = OHV.MkVectorI3( 0, -1,  0 );
        public static VectorI3 back  = OHV.MkVectorI3( 0,  0, -1 );
        public static VectorI3 right   = OHV.MkVectorI3( 1,  0,  0 );
        public static VectorI3 up      = OHV.MkVectorI3( 0,  1,  0 );
        public static VectorI3 forward = OHV.MkVectorI3( 0,  0,  1 );
        public static VectorI3 one = OHV.MkVectorI3(1);
        public static VectorI3 zero = OHV.MkVectorI3(0);
        public static VectorI3 MinValue = OHV.MkVectorI3(Int32.MinValue);
        public static VectorI3 MaxValue = OHV.MkVectorI3(Int32.MaxValue);
        
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
            return OHV.MkVectorI3(
                (Int32)(A.x - B.x),
                (Int32)(A.y - B.y),
                (Int32)(A.z - B.z));
        }

        public static VectorI3 operator+(VectorI3 A, VectorI3 B)
        {
            return OHV.MkVectorI3(
                (Int32)(A.x + B.x),
                (Int32)(A.y + B.y),
                (Int32)(A.z + B.z));
        }

        public static VectorI3 operator-(VectorI3 V)
        {
            return OHV.MkVectorI3(-V.x, -V.y, -V.z);
        }

        public static VectorI3 operator*(Int32 A, VectorI3 V)
        {
            return OHV.MkVectorI3(
                (Int32)((A * V.x)),
                (Int32)((A * V.y)),
                (Int32)((A * V.z)));
        }

        public static VectorI3 operator/(Int32 A, VectorI3 V)
        {
            return OHV.MkVectorI3(
                (Int32)((Arith.Div(A, V.x))),
                (Int32)((Arith.Div(A, V.y))),
                (Int32)((Arith.Div(A, V.z))));
        }

        public static VectorI3 operator*(VectorI3 V, Int32 A)
        {
            return OHV.MkVectorI3(
                (Int32)((V.x * A)),
                (Int32)((V.y * A)),
                (Int32)((V.z * A)));
        }

        public static VectorI3 operator/(VectorI3 V, Int32 A)
        {
            return OHV.MkVectorI3(
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

        public static VectorI4 one = OHV.MkVectorI4(1);
        public static VectorI4 zero = OHV.MkVectorI4(0);
        public static VectorI4 MinValue = OHV.MkVectorI4(Int32.MinValue);
        public static VectorI4 MaxValue = OHV.MkVectorI4(Int32.MaxValue);
        
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
            return OHV.MkVectorI4(
                (Int32)(A.x - B.x),
                (Int32)(A.y - B.y),
                (Int32)(A.z - B.z),
                (Int32)(A.w - B.w));
        }

        public static VectorI4 operator+(VectorI4 A, VectorI4 B)
        {
            return OHV.MkVectorI4(
                (Int32)(A.x + B.x),
                (Int32)(A.y + B.y),
                (Int32)(A.z + B.z),
                (Int32)(A.w + B.w));
        }

        public static VectorI4 operator-(VectorI4 V)
        {
            return OHV.MkVectorI4(-V.x, -V.y, -V.z, -V.w);
        }

        public static VectorI4 operator*(Int32 A, VectorI4 V)
        {
            return OHV.MkVectorI4(
                (Int32)((A * V.x)),
                (Int32)((A * V.y)),
                (Int32)((A * V.z)),
                (Int32)((A * V.w)));
        }

        public static VectorI4 operator/(Int32 A, VectorI4 V)
        {
            return OHV.MkVectorI4(
                (Int32)((Arith.Div(A, V.x))),
                (Int32)((Arith.Div(A, V.y))),
                (Int32)((Arith.Div(A, V.z))),
                (Int32)((Arith.Div(A, V.w))));
        }

        public static VectorI4 operator*(VectorI4 V, Int32 A)
        {
            return OHV.MkVectorI4(
                (Int32)((V.x * A)),
                (Int32)((V.y * A)),
                (Int32)((V.z * A)),
                (Int32)((V.w * A)));
        }

        public static VectorI4 operator/(VectorI4 V, Int32 A)
        {
            return OHV.MkVectorI4(
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
        public Byte x, y;
        
        // Member functions
        public Byte this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    default: { return Byte.MaxValue; }
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

        public static VectorB2 right = OHV.MkVectorB2( 1,  0 );
        public static VectorB2 up    = OHV.MkVectorB2( 0,  1 );
        public static VectorB2 one = OHV.MkVectorB2(1);
        public static VectorB2 zero = OHV.MkVectorB2(0);
        public static VectorB2 MinValue = OHV.MkVectorB2(0);
        public static VectorB2 MaxValue = OHV.MkVectorB2(Byte.MaxValue);
        
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
            return OHV.MkVectorB2(
                (Byte)(A.x - B.x),
                (Byte)(A.y - B.y));
        }

        public static VectorB2 operator+(VectorB2 A, VectorB2 B)
        {
            return OHV.MkVectorB2(
                (Byte)(A.x + B.x),
                (Byte)(A.y + B.y));
        }

        public static VectorB2 operator*(Byte A, VectorB2 V)
        {
            return OHV.MkVectorB2(
                (Byte)((A * V.x)),
                (Byte)((A * V.y)));
        }

        public static VectorB2 operator/(Byte A, VectorB2 V)
        {
            return OHV.MkVectorB2(
                (Byte)((Arith.Div(A, V.x))),
                (Byte)((Arith.Div(A, V.y))));
        }

        public static VectorB2 operator*(VectorB2 V, Byte A)
        {
            return OHV.MkVectorB2(
                (Byte)((V.x * A)),
                (Byte)((V.y * A)));
        }

        public static VectorB2 operator/(VectorB2 V, Byte A)
        {
            return OHV.MkVectorB2(
                (Byte)((Arith.Div(V.x, A))),
                (Byte)((Arith.Div(V.y, A))));
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
        public Byte x, y, z;
        
        // Member functions
        public Byte this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    case 2: { return z; }
                    default: { return Byte.MaxValue; }
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

        public static VectorB3 right   = OHV.MkVectorB3( 1,  0,  0 );
        public static VectorB3 up      = OHV.MkVectorB3( 0,  1,  0 );
        public static VectorB3 forward = OHV.MkVectorB3( 0,  0,  1 );
        public static VectorB3 one = OHV.MkVectorB3(1);
        public static VectorB3 zero = OHV.MkVectorB3(0);
        public static VectorB3 MinValue = OHV.MkVectorB3(0);
        public static VectorB3 MaxValue = OHV.MkVectorB3(Byte.MaxValue);
        
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
            return OHV.MkVectorB3(
                (Byte)(A.x - B.x),
                (Byte)(A.y - B.y),
                (Byte)(A.z - B.z));
        }

        public static VectorB3 operator+(VectorB3 A, VectorB3 B)
        {
            return OHV.MkVectorB3(
                (Byte)(A.x + B.x),
                (Byte)(A.y + B.y),
                (Byte)(A.z + B.z));
        }

        public static VectorB3 operator*(Byte A, VectorB3 V)
        {
            return OHV.MkVectorB3(
                (Byte)((A * V.x)),
                (Byte)((A * V.y)),
                (Byte)((A * V.z)));
        }

        public static VectorB3 operator/(Byte A, VectorB3 V)
        {
            return OHV.MkVectorB3(
                (Byte)((Arith.Div(A, V.x))),
                (Byte)((Arith.Div(A, V.y))),
                (Byte)((Arith.Div(A, V.z))));
        }

        public static VectorB3 operator*(VectorB3 V, Byte A)
        {
            return OHV.MkVectorB3(
                (Byte)((V.x * A)),
                (Byte)((V.y * A)),
                (Byte)((V.z * A)));
        }

        public static VectorB3 operator/(VectorB3 V, Byte A)
        {
            return OHV.MkVectorB3(
                (Byte)((Arith.Div(V.x, A))),
                (Byte)((Arith.Div(V.y, A))),
                (Byte)((Arith.Div(V.z, A))));
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
        public Byte x, y, z, w;
        
        // Member functions
        public Byte this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    case 2: { return z; }
                    case 3: { return w; }
                    default: { return Byte.MaxValue; }
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

        public static VectorB4 one = OHV.MkVectorB4(1);
        public static VectorB4 zero = OHV.MkVectorB4(0);
        public static VectorB4 MinValue = OHV.MkVectorB4(0);
        public static VectorB4 MaxValue = OHV.MkVectorB4(Byte.MaxValue);
        
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
            return OHV.MkVectorB4(
                (Byte)(A.x - B.x),
                (Byte)(A.y - B.y),
                (Byte)(A.z - B.z),
                (Byte)(A.w - B.w));
        }

        public static VectorB4 operator+(VectorB4 A, VectorB4 B)
        {
            return OHV.MkVectorB4(
                (Byte)(A.x + B.x),
                (Byte)(A.y + B.y),
                (Byte)(A.z + B.z),
                (Byte)(A.w + B.w));
        }

        public static VectorB4 operator*(Byte A, VectorB4 V)
        {
            return OHV.MkVectorB4(
                (Byte)((A * V.x)),
                (Byte)((A * V.y)),
                (Byte)((A * V.z)),
                (Byte)((A * V.w)));
        }

        public static VectorB4 operator/(Byte A, VectorB4 V)
        {
            return OHV.MkVectorB4(
                (Byte)((Arith.Div(A, V.x))),
                (Byte)((Arith.Div(A, V.y))),
                (Byte)((Arith.Div(A, V.z))),
                (Byte)((Arith.Div(A, V.w))));
        }

        public static VectorB4 operator*(VectorB4 V, Byte A)
        {
            return OHV.MkVectorB4(
                (Byte)((V.x * A)),
                (Byte)((V.y * A)),
                (Byte)((V.z * A)),
                (Byte)((V.w * A)));
        }

        public static VectorB4 operator/(VectorB4 V, Byte A)
        {
            return OHV.MkVectorB4(
                (Byte)((Arith.Div(V.x, A))),
                (Byte)((Arith.Div(V.y, A))),
                (Byte)((Arith.Div(V.z, A))),
                (Byte)((Arith.Div(V.w, A))));
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
        public Double x, y;
        
        // Member functions
        public Double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    default: { return Double.MaxValue; }
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

        public static VectorD2 left = OHV.MkVectorD2(-1,  0 );
        public static VectorD2 down = OHV.MkVectorD2( 0, -1 );
        public static VectorD2 right = OHV.MkVectorD2( 1,  0 );
        public static VectorD2 up    = OHV.MkVectorD2( 0,  1 );
        public static VectorD2 one = OHV.MkVectorD2(1);
        public static VectorD2 zero = OHV.MkVectorD2(0);
        public static VectorD2 negativeInfinity = OHV.MkVectorD2(Double.NegativeInfinity);
        public static VectorD2 positiveInfinity = OHV.MkVectorD2(Double.PositiveInfinity);
        
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
            return OHV.MkVectorD2(
                (Double)(A.x - B.x),
                (Double)(A.y - B.y));
        }

        public static VectorD2 operator+(VectorD2 A, VectorD2 B)
        {
            return OHV.MkVectorD2(
                (Double)(A.x + B.x),
                (Double)(A.y + B.y));
        }

        public static VectorD2 operator-(VectorD2 V)
        {
            return OHV.MkVectorD2(-V.x, -V.y);
        }

        public static VectorD2 operator*(Double A, VectorD2 V)
        {
            return OHV.MkVectorD2(
                (Double)((A * V.x)),
                (Double)((A * V.y)));
        }

        public static VectorD2 operator/(Double A, VectorD2 V)
        {
            return OHV.MkVectorD2(
                (Double)((Arith.Div(A, V.x))),
                (Double)((Arith.Div(A, V.y))));
        }

        public static VectorD2 operator*(VectorD2 V, Double A)
        {
            return OHV.MkVectorD2(
                (Double)((V.x * A)),
                (Double)((V.y * A)));
        }

        public static VectorD2 operator/(VectorD2 V, Double A)
        {
            return OHV.MkVectorD2(
                (Double)((Arith.Div(V.x, A))),
                (Double)((Arith.Div(V.y, A))));
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
        public Double x, y, z;
        
        // Member functions
        public Double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    case 2: { return z; }
                    default: { return Double.MaxValue; }
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

        public static VectorD3 left  = OHV.MkVectorD3(-1,  0,  0 );
        public static VectorD3 down  = OHV.MkVectorD3( 0, -1,  0 );
        public static VectorD3 back  = OHV.MkVectorD3( 0,  0, -1 );
        public static VectorD3 right   = OHV.MkVectorD3( 1,  0,  0 );
        public static VectorD3 up      = OHV.MkVectorD3( 0,  1,  0 );
        public static VectorD3 forward = OHV.MkVectorD3( 0,  0,  1 );
        public static VectorD3 one = OHV.MkVectorD3(1);
        public static VectorD3 zero = OHV.MkVectorD3(0);
        public static VectorD3 negativeInfinity = OHV.MkVectorD3(Double.NegativeInfinity);
        public static VectorD3 positiveInfinity = OHV.MkVectorD3(Double.PositiveInfinity);
        
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
            return OHV.MkVectorD3(
                (Double)(A.x - B.x),
                (Double)(A.y - B.y),
                (Double)(A.z - B.z));
        }

        public static VectorD3 operator+(VectorD3 A, VectorD3 B)
        {
            return OHV.MkVectorD3(
                (Double)(A.x + B.x),
                (Double)(A.y + B.y),
                (Double)(A.z + B.z));
        }

        public static VectorD3 operator-(VectorD3 V)
        {
            return OHV.MkVectorD3(-V.x, -V.y, -V.z);
        }

        public static VectorD3 operator*(Double A, VectorD3 V)
        {
            return OHV.MkVectorD3(
                (Double)((A * V.x)),
                (Double)((A * V.y)),
                (Double)((A * V.z)));
        }

        public static VectorD3 operator/(Double A, VectorD3 V)
        {
            return OHV.MkVectorD3(
                (Double)((Arith.Div(A, V.x))),
                (Double)((Arith.Div(A, V.y))),
                (Double)((Arith.Div(A, V.z))));
        }

        public static VectorD3 operator*(VectorD3 V, Double A)
        {
            return OHV.MkVectorD3(
                (Double)((V.x * A)),
                (Double)((V.y * A)),
                (Double)((V.z * A)));
        }

        public static VectorD3 operator/(VectorD3 V, Double A)
        {
            return OHV.MkVectorD3(
                (Double)((Arith.Div(V.x, A))),
                (Double)((Arith.Div(V.y, A))),
                (Double)((Arith.Div(V.z, A))));
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
        public Double x, y, z, w;
        
        // Member functions
        public Double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: { return x; }
                    case 1: { return y; }
                    case 2: { return z; }
                    case 3: { return w; }
                    default: { return Double.MaxValue; }
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

        public static VectorD4 one = OHV.MkVectorD4(1);
        public static VectorD4 zero = OHV.MkVectorD4(0);
        public static VectorD4 negativeInfinity = OHV.MkVectorD4(Double.NegativeInfinity);
        public static VectorD4 positiveInfinity = OHV.MkVectorD4(Double.PositiveInfinity);
        
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
            return OHV.MkVectorD4(
                (Double)(A.x - B.x),
                (Double)(A.y - B.y),
                (Double)(A.z - B.z),
                (Double)(A.w - B.w));
        }

        public static VectorD4 operator+(VectorD4 A, VectorD4 B)
        {
            return OHV.MkVectorD4(
                (Double)(A.x + B.x),
                (Double)(A.y + B.y),
                (Double)(A.z + B.z),
                (Double)(A.w + B.w));
        }

        public static VectorD4 operator-(VectorD4 V)
        {
            return OHV.MkVectorD4(-V.x, -V.y, -V.z, -V.w);
        }

        public static VectorD4 operator*(Double A, VectorD4 V)
        {
            return OHV.MkVectorD4(
                (Double)((A * V.x)),
                (Double)((A * V.y)),
                (Double)((A * V.z)),
                (Double)((A * V.w)));
        }

        public static VectorD4 operator/(Double A, VectorD4 V)
        {
            return OHV.MkVectorD4(
                (Double)((Arith.Div(A, V.x))),
                (Double)((Arith.Div(A, V.y))),
                (Double)((Arith.Div(A, V.z))),
                (Double)((Arith.Div(A, V.w))));
        }

        public static VectorD4 operator*(VectorD4 V, Double A)
        {
            return OHV.MkVectorD4(
                (Double)((V.x * A)),
                (Double)((V.y * A)),
                (Double)((V.z * A)),
                (Double)((V.w * A)));
        }

        public static VectorD4 operator/(VectorD4 V, Double A)
        {
            return OHV.MkVectorD4(
                (Double)((Arith.Div(V.x, A))),
                (Double)((Arith.Div(V.y, A))),
                (Double)((Arith.Div(V.z, A))),
                (Double)((Arith.Div(V.w, A))));
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