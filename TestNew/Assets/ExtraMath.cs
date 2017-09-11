using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace OH
{
    public static class Arith
    {
        public static Int32 Pow2Rem(Int32 A, Int32 Pow2)
        {
            return A & (1 << Pow2) - 1;
        }

        public static Int32 Pow2Div(Int32 A, Int32 Pow2)
        {
            return A >> Pow2;
        }

        public static Int32 Pow2Mult(Int32 A, Int32 Pow2)
        {
            return A << Pow2;
        }

        public static Int32 Pow2CeilDiv(Int32 A, Int32 Pow2)
        {
            Int32 Remainderizer = ((A & ((1 << Pow2) - 1)) != 0) ? 1 : 0;
            return (A >> Pow2) + Remainderizer;
        }

        public static Int64 Pow2Mult(Int64 A, Int64 Pow2)
        {
            return A << (int)Pow2;
        }

        public static byte Pow2Rem(byte A, byte Pow2)
        {
            return (byte)(A & (1 << Pow2) - 1);
        }

        public static byte Pow2Div(byte A, byte Pow2)
        {
            return (byte)(A >> Pow2);
        }

        public static byte Pow2Mult(byte A, byte Pow2)
        {
            return (byte)(A << Pow2);
        }

        public static byte Pow2CeilDiv(byte A, byte Pow2)
        {
            Int32 Remainderizer = ((A & ((1 << Pow2) - 1)) != 0) ? 1 : 0;
            return (byte)((A >> Pow2) + Remainderizer);
        }

        public static Int32 CeilingDiv(Int32 x, Int32 y)
        {
            bool quotientNegative = ((x >= 0) && (y < 0)) || ((x < 0) && (y >= 0));

            if (quotientNegative)
            {
                return (x / y);
            }
            else
            {
                return (byte)(x / y + (x % y != 0 ? 1 : 0));
            }
        }

        public static Int32 Div(Int32 v1, Int32 v2)
        {
            Int32 q = v1 / v2, r = v1 % v2;
            if ((r > 0 && v2 < 0) || (r < 0 && v2 > 0))
                return q - 1;
            else
                return q;
        }

        public static Int32 CeilDiv(Int32 A, Int32 B)
        {
            return (A / B) + ((A % B != 0)
                ? (!((A > 0) ^ (B > 0)) ? 1 : 0)
                : 0);
        }

        public static Int32 Rem(Int32 v1, Int32 v2)
        {
            Int32 r = v1 % v2;
            if ((r > 0 && v2 < 0) || (r < 0 && v2 > 0))
                return r + v2;
            else
                return r;
        }

        public static float Div(float A, float B)
        {
            return A / B;
        }

        public static byte Div(byte A, byte B)
        {
            return (byte)(A / B);
        }

        public static byte CeilDiv(byte A, byte B)
        {
            return (byte)
                (
                    (A/B) + ((A%B!=0)
                    ? (!((A>0)^(B>0)) ? 1 : 0)
                    : 0)
                );
        }

        public static byte Rem(byte A, byte B)
        {
            return (byte)(A % B);
        }

        public static Int32 FloorIF(float x)
        {
            return Mathf.FloorToInt(x);
        }

        public static Int32 CeilIF(float x)
        {
            return Mathf.CeilToInt(x);
        }

        public static byte FloorBF(float x)
        {
            return (byte)Mathf.FloorToInt(x);
        }

        public static byte CeilBF(float x)
        {
            return (byte)Mathf.FloorToInt(x);
        }

        public static Int32 Max(Int32 A, Int32 B)
        {
            return System.Math.Max(A, B);
        }

        public static Byte Max(Byte A, Byte B)
        {
            return System.Math.Max(A, B);
        }

        public static Int64 Max(Int64 A, Int64 B)
        {
            return System.Math.Max(A, B);
        }

        public static float Max(float A, float B)
        {
            return System.Math.Max(A, B);
        }

        public static double Max(double A, double B)
        {
            return System.Math.Max(A, B);
        }

        public static Int32 Min(Int32 A, Int32 B)
        {
            return System.Math.Min(A, B);
        }

        public static Byte Min(Byte A, Byte B)
        {
            return System.Math.Min(A, B);
        }

        public static Int64 Min(Int64 A, Int64 B)
        {
            return System.Math.Min(A, B);
        }

        public static float Min(float A, float B)
        {
            return System.Math.Min(A, B);
        }

        public static double Min(double A, double B)
        {
            return System.Math.Min(A, B);
        }

        public static float Sqrt(float A)
        {
            return (float)System.Math.Sqrt(A);
        }

        public static double Sqrt(double A)
        {
            return System.Math.Sqrt(A);
        }
    }
}
