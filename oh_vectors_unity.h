#ifndef UNITY_VECTORS
union VectorI2
{
    struct { Int32 x, y; };
    Int32 E[2];
};

union VectorI3
{
    struct { Int32 x, y, z; };
    Int32 E[3];
};

union VectorI4
{
    struct { Int32 x, y, z, w; };
    Int32 E[4];
};

union VectorB2
{
    struct { byte x, y; };
    byte E[2];
};

union VectorB3
{
    struct { byte x, y, z; };
    byte E[3];
};

union VectorB4
{
    struct { byte x, y, z, w; };
    byte E[4];
};

union VectorD2
{
    struct { double x, y; };
    double E[2];
};

union VectorD3
{
    struct { double x, y, z; };
    double E[3];
};

union VectorD4
{
    struct { double x, y, z, w; };
    double E[4];
};

union Vector2
{
    struct { float x, y; };
    float E[2];
};

union Vector3
{
    struct { float x, y, z; };
    float E[3];
};

union Vector4
{
    struct { float x, y, z, w; };
    float E[4];
};

#define VectorI2_left    (VectorI2{ -1,  0 })
#define VectorI2_down    (VectorI2{  0, -1 })
#define VectorI2_right   (VectorI2{  1,  0 })
#define VectorI2_up      (VectorI2{  0,  1 })
#define VectorI3_left    (VectorI3{ -1,  0,  0 })
#define VectorI3_down    (VectorI3{  0, -1,  0 })
#define VectorI3_back    (VectorI3{  0,  0, -1 })
#define VectorI3_right   (VectorI3{  1,  0,  0 })
#define VectorI3_up      (VectorI3{  0,  1,  0 })
#define VectorI3_forward (VectorI3{  0,  0,  1 })
#define VectorB2_right   (VectorB2{  1,  0 })
#define VectorB2_up      (VectorB2{  0,  1 })
#define VectorB3_right   (VectorB3{  1,  0,  0 })
#define VectorB3_up      (VectorB3{  0,  1,  0 })
#define VectorB3_forward (VectorB3{  0,  0,  1 })
#define VectorD2_left    (VectorD2{ -1,  0 })
#define VectorD2_down    (VectorD2{  0, -1 })
#define VectorD2_right   (VectorD2{  1,  0 })
#define VectorD2_up      (VectorD2{  0,  1 })
#define VectorD3_left    (VectorD3{ -1,  0,  0 })
#define VectorD3_down    (VectorD3{  0, -1,  0 })
#define VectorD3_back    (VectorD3{  0,  0, -1 })
#define VectorD3_right   (VectorD3{  1,  0,  0 })
#define VectorD3_up      (VectorD3{  0,  1,  0 })
#define VectorD3_forward (VectorD3{  0,  0,  1 })
#define Vector2_left    (Vector2{ -1,  0 })
#define Vector2_down    (Vector2{  0, -1 })
#define Vector2_right   (Vector2{  1,  0 })
#define Vector2_up      (Vector2{  0,  1 })
#define Vector3_left    (Vector3{ -1,  0,  0 })
#define Vector3_down    (Vector3{  0, -1,  0 })
#define Vector3_back    (Vector3{  0,  0, -1 })
#define Vector3_right   (Vector3{  1,  0,  0 })
#define Vector3_up      (Vector3{  0,  1,  0 })
#define Vector3_forward (Vector3{  0,  0,  1 })

// Constructors from primitives. Float converts to int using floor
inline VectorI2 MkVectorI2(Int32 x, Int32 y)
{
    VectorI2 V;
    V.x = (Int32)(x);
    V.y = (Int32)(y);
    return V;
}

inline VectorI2 MkVectorI2(Int32 A)
{
    VectorI2 V;
    V.x = (Int32)(A);
    V.y = (Int32)(A);
    return V;
}

inline VectorI2 MkVectorI2B(byte x, byte y)
{
    VectorI2 V;
    V.x = (Int32)(x);
    V.y = (Int32)(y);
    return V;
}

inline VectorI2 MkVectorI2B(byte A)
{
    VectorI2 V;
    V.x = (Int32)(A);
    V.y = (Int32)(A);
    return V;
}

inline VectorI2 MkVectorI2D(double x, double y)
{
    VectorI2 V;
    V.x = FloorID(x);
    V.y = FloorID(y);
    return V;
}

inline VectorI2 MkVectorI2D(double A)
{
    VectorI2 V;
    V.x = FloorID(A);
    V.y = FloorID(A);
    return V;
}

inline VectorI2 MkVectorI2F(float x, float y)
{
    VectorI2 V;
    V.x = FloorIF(x);
    V.y = FloorIF(y);
    return V;
}

inline VectorI2 MkVectorI2F(float A)
{
    VectorI2 V;
    V.x = FloorIF(A);
    V.y = FloorIF(A);
    return V;
}

inline VectorI3 MkVectorI3(Int32 x, Int32 y, Int32 z)
{
    VectorI3 V;
    V.x = (Int32)(x);
    V.y = (Int32)(y);
    V.z = (Int32)(z);
    return V;
}

inline VectorI3 MkVectorI3(Int32 A)
{
    VectorI3 V;
    V.x = (Int32)(A);
    V.y = (Int32)(A);
    V.z = (Int32)(A);
    return V;
}

inline VectorI3 MkVectorI3B(byte x, byte y, byte z)
{
    VectorI3 V;
    V.x = (Int32)(x);
    V.y = (Int32)(y);
    V.z = (Int32)(z);
    return V;
}

inline VectorI3 MkVectorI3B(byte A)
{
    VectorI3 V;
    V.x = (Int32)(A);
    V.y = (Int32)(A);
    V.z = (Int32)(A);
    return V;
}

inline VectorI3 MkVectorI3D(double x, double y, double z)
{
    VectorI3 V;
    V.x = FloorID(x);
    V.y = FloorID(y);
    V.z = FloorID(z);
    return V;
}

inline VectorI3 MkVectorI3D(double A)
{
    VectorI3 V;
    V.x = FloorID(A);
    V.y = FloorID(A);
    V.z = FloorID(A);
    return V;
}

inline VectorI3 MkVectorI3F(float x, float y, float z)
{
    VectorI3 V;
    V.x = FloorIF(x);
    V.y = FloorIF(y);
    V.z = FloorIF(z);
    return V;
}

inline VectorI3 MkVectorI3F(float A)
{
    VectorI3 V;
    V.x = FloorIF(A);
    V.y = FloorIF(A);
    V.z = FloorIF(A);
    return V;
}

inline VectorI4 MkVectorI4(Int32 x, Int32 y, Int32 z, Int32 w)
{
    VectorI4 V;
    V.x = (Int32)(x);
    V.y = (Int32)(y);
    V.z = (Int32)(z);
    V.w = (Int32)(w);
    return V;
}

inline VectorI4 MkVectorI4(Int32 A)
{
    VectorI4 V;
    V.x = (Int32)(A);
    V.y = (Int32)(A);
    V.z = (Int32)(A);
    V.w = (Int32)(A);
    return V;
}

inline VectorI4 MkVectorI4B(byte x, byte y, byte z, byte w)
{
    VectorI4 V;
    V.x = (Int32)(x);
    V.y = (Int32)(y);
    V.z = (Int32)(z);
    V.w = (Int32)(w);
    return V;
}

inline VectorI4 MkVectorI4B(byte A)
{
    VectorI4 V;
    V.x = (Int32)(A);
    V.y = (Int32)(A);
    V.z = (Int32)(A);
    V.w = (Int32)(A);
    return V;
}

inline VectorI4 MkVectorI4D(double x, double y, double z, double w)
{
    VectorI4 V;
    V.x = FloorID(x);
    V.y = FloorID(y);
    V.z = FloorID(z);
    V.w = FloorID(w);
    return V;
}

inline VectorI4 MkVectorI4D(double A)
{
    VectorI4 V;
    V.x = FloorID(A);
    V.y = FloorID(A);
    V.z = FloorID(A);
    V.w = FloorID(A);
    return V;
}

inline VectorI4 MkVectorI4F(float x, float y, float z, float w)
{
    VectorI4 V;
    V.x = FloorIF(x);
    V.y = FloorIF(y);
    V.z = FloorIF(z);
    V.w = FloorIF(w);
    return V;
}

inline VectorI4 MkVectorI4F(float A)
{
    VectorI4 V;
    V.x = FloorIF(A);
    V.y = FloorIF(A);
    V.z = FloorIF(A);
    V.w = FloorIF(A);
    return V;
}

inline VectorB2 MkVectorB2I(Int32 x, Int32 y)
{
    VectorB2 V;
    V.x = (byte)(x);
    V.y = (byte)(y);
    return V;
}

inline VectorB2 MkVectorB2I(Int32 A)
{
    VectorB2 V;
    V.x = (byte)(A);
    V.y = (byte)(A);
    return V;
}

inline VectorB2 MkVectorB2(byte x, byte y)
{
    VectorB2 V;
    V.x = (byte)(x);
    V.y = (byte)(y);
    return V;
}

inline VectorB2 MkVectorB2(byte A)
{
    VectorB2 V;
    V.x = (byte)(A);
    V.y = (byte)(A);
    return V;
}

inline VectorB2 MkVectorB2D(double x, double y)
{
    VectorB2 V;
    V.x = FloorBD(x);
    V.y = FloorBD(y);
    return V;
}

inline VectorB2 MkVectorB2D(double A)
{
    VectorB2 V;
    V.x = FloorBD(A);
    V.y = FloorBD(A);
    return V;
}

inline VectorB2 MkVectorB2F(float x, float y)
{
    VectorB2 V;
    V.x = FloorBF(x);
    V.y = FloorBF(y);
    return V;
}

inline VectorB2 MkVectorB2F(float A)
{
    VectorB2 V;
    V.x = FloorBF(A);
    V.y = FloorBF(A);
    return V;
}

inline VectorB3 MkVectorB3I(Int32 x, Int32 y, Int32 z)
{
    VectorB3 V;
    V.x = (byte)(x);
    V.y = (byte)(y);
    V.z = (byte)(z);
    return V;
}

inline VectorB3 MkVectorB3I(Int32 A)
{
    VectorB3 V;
    V.x = (byte)(A);
    V.y = (byte)(A);
    V.z = (byte)(A);
    return V;
}

inline VectorB3 MkVectorB3(byte x, byte y, byte z)
{
    VectorB3 V;
    V.x = (byte)(x);
    V.y = (byte)(y);
    V.z = (byte)(z);
    return V;
}

inline VectorB3 MkVectorB3(byte A)
{
    VectorB3 V;
    V.x = (byte)(A);
    V.y = (byte)(A);
    V.z = (byte)(A);
    return V;
}

inline VectorB3 MkVectorB3D(double x, double y, double z)
{
    VectorB3 V;
    V.x = FloorBD(x);
    V.y = FloorBD(y);
    V.z = FloorBD(z);
    return V;
}

inline VectorB3 MkVectorB3D(double A)
{
    VectorB3 V;
    V.x = FloorBD(A);
    V.y = FloorBD(A);
    V.z = FloorBD(A);
    return V;
}

inline VectorB3 MkVectorB3F(float x, float y, float z)
{
    VectorB3 V;
    V.x = FloorBF(x);
    V.y = FloorBF(y);
    V.z = FloorBF(z);
    return V;
}

inline VectorB3 MkVectorB3F(float A)
{
    VectorB3 V;
    V.x = FloorBF(A);
    V.y = FloorBF(A);
    V.z = FloorBF(A);
    return V;
}

inline VectorB4 MkVectorB4I(Int32 x, Int32 y, Int32 z, Int32 w)
{
    VectorB4 V;
    V.x = (byte)(x);
    V.y = (byte)(y);
    V.z = (byte)(z);
    V.w = (byte)(w);
    return V;
}

inline VectorB4 MkVectorB4I(Int32 A)
{
    VectorB4 V;
    V.x = (byte)(A);
    V.y = (byte)(A);
    V.z = (byte)(A);
    V.w = (byte)(A);
    return V;
}

inline VectorB4 MkVectorB4(byte x, byte y, byte z, byte w)
{
    VectorB4 V;
    V.x = (byte)(x);
    V.y = (byte)(y);
    V.z = (byte)(z);
    V.w = (byte)(w);
    return V;
}

inline VectorB4 MkVectorB4(byte A)
{
    VectorB4 V;
    V.x = (byte)(A);
    V.y = (byte)(A);
    V.z = (byte)(A);
    V.w = (byte)(A);
    return V;
}

inline VectorB4 MkVectorB4D(double x, double y, double z, double w)
{
    VectorB4 V;
    V.x = FloorBD(x);
    V.y = FloorBD(y);
    V.z = FloorBD(z);
    V.w = FloorBD(w);
    return V;
}

inline VectorB4 MkVectorB4D(double A)
{
    VectorB4 V;
    V.x = FloorBD(A);
    V.y = FloorBD(A);
    V.z = FloorBD(A);
    V.w = FloorBD(A);
    return V;
}

inline VectorB4 MkVectorB4F(float x, float y, float z, float w)
{
    VectorB4 V;
    V.x = FloorBF(x);
    V.y = FloorBF(y);
    V.z = FloorBF(z);
    V.w = FloorBF(w);
    return V;
}

inline VectorB4 MkVectorB4F(float A)
{
    VectorB4 V;
    V.x = FloorBF(A);
    V.y = FloorBF(A);
    V.z = FloorBF(A);
    V.w = FloorBF(A);
    return V;
}

inline VectorD2 MkVectorD2I(Int32 x, Int32 y)
{
    VectorD2 V;
    V.x = (double)(x);
    V.y = (double)(y);
    return V;
}

inline VectorD2 MkVectorD2I(Int32 A)
{
    VectorD2 V;
    V.x = (double)(A);
    V.y = (double)(A);
    return V;
}

inline VectorD2 MkVectorD2B(byte x, byte y)
{
    VectorD2 V;
    V.x = (double)(x);
    V.y = (double)(y);
    return V;
}

inline VectorD2 MkVectorD2B(byte A)
{
    VectorD2 V;
    V.x = (double)(A);
    V.y = (double)(A);
    return V;
}

inline VectorD2 MkVectorD2(double x, double y)
{
    VectorD2 V;
    V.x = (double)(x);
    V.y = (double)(y);
    return V;
}

inline VectorD2 MkVectorD2(double A)
{
    VectorD2 V;
    V.x = (double)(A);
    V.y = (double)(A);
    return V;
}

inline VectorD2 MkVectorD2F(float x, float y)
{
    VectorD2 V;
    V.x = (double)(x);
    V.y = (double)(y);
    return V;
}

inline VectorD2 MkVectorD2F(float A)
{
    VectorD2 V;
    V.x = (double)(A);
    V.y = (double)(A);
    return V;
}

inline VectorD3 MkVectorD3I(Int32 x, Int32 y, Int32 z)
{
    VectorD3 V;
    V.x = (double)(x);
    V.y = (double)(y);
    V.z = (double)(z);
    return V;
}

inline VectorD3 MkVectorD3I(Int32 A)
{
    VectorD3 V;
    V.x = (double)(A);
    V.y = (double)(A);
    V.z = (double)(A);
    return V;
}

inline VectorD3 MkVectorD3B(byte x, byte y, byte z)
{
    VectorD3 V;
    V.x = (double)(x);
    V.y = (double)(y);
    V.z = (double)(z);
    return V;
}

inline VectorD3 MkVectorD3B(byte A)
{
    VectorD3 V;
    V.x = (double)(A);
    V.y = (double)(A);
    V.z = (double)(A);
    return V;
}

inline VectorD3 MkVectorD3(double x, double y, double z)
{
    VectorD3 V;
    V.x = (double)(x);
    V.y = (double)(y);
    V.z = (double)(z);
    return V;
}

inline VectorD3 MkVectorD3(double A)
{
    VectorD3 V;
    V.x = (double)(A);
    V.y = (double)(A);
    V.z = (double)(A);
    return V;
}

inline VectorD3 MkVectorD3F(float x, float y, float z)
{
    VectorD3 V;
    V.x = (double)(x);
    V.y = (double)(y);
    V.z = (double)(z);
    return V;
}

inline VectorD3 MkVectorD3F(float A)
{
    VectorD3 V;
    V.x = (double)(A);
    V.y = (double)(A);
    V.z = (double)(A);
    return V;
}

inline VectorD4 MkVectorD4I(Int32 x, Int32 y, Int32 z, Int32 w)
{
    VectorD4 V;
    V.x = (double)(x);
    V.y = (double)(y);
    V.z = (double)(z);
    V.w = (double)(w);
    return V;
}

inline VectorD4 MkVectorD4I(Int32 A)
{
    VectorD4 V;
    V.x = (double)(A);
    V.y = (double)(A);
    V.z = (double)(A);
    V.w = (double)(A);
    return V;
}

inline VectorD4 MkVectorD4B(byte x, byte y, byte z, byte w)
{
    VectorD4 V;
    V.x = (double)(x);
    V.y = (double)(y);
    V.z = (double)(z);
    V.w = (double)(w);
    return V;
}

inline VectorD4 MkVectorD4B(byte A)
{
    VectorD4 V;
    V.x = (double)(A);
    V.y = (double)(A);
    V.z = (double)(A);
    V.w = (double)(A);
    return V;
}

inline VectorD4 MkVectorD4(double x, double y, double z, double w)
{
    VectorD4 V;
    V.x = (double)(x);
    V.y = (double)(y);
    V.z = (double)(z);
    V.w = (double)(w);
    return V;
}

inline VectorD4 MkVectorD4(double A)
{
    VectorD4 V;
    V.x = (double)(A);
    V.y = (double)(A);
    V.z = (double)(A);
    V.w = (double)(A);
    return V;
}

inline VectorD4 MkVectorD4F(float x, float y, float z, float w)
{
    VectorD4 V;
    V.x = (double)(x);
    V.y = (double)(y);
    V.z = (double)(z);
    V.w = (double)(w);
    return V;
}

inline VectorD4 MkVectorD4F(float A)
{
    VectorD4 V;
    V.x = (double)(A);
    V.y = (double)(A);
    V.z = (double)(A);
    V.w = (double)(A);
    return V;
}

inline Vector2 MkVector2I(Int32 x, Int32 y)
{
    Vector2 V;
    V.x = (float)(x);
    V.y = (float)(y);
    return V;
}

inline Vector2 MkVector2I(Int32 A)
{
    Vector2 V;
    V.x = (float)(A);
    V.y = (float)(A);
    return V;
}

inline Vector2 MkVector2B(byte x, byte y)
{
    Vector2 V;
    V.x = (float)(x);
    V.y = (float)(y);
    return V;
}

inline Vector2 MkVector2B(byte A)
{
    Vector2 V;
    V.x = (float)(A);
    V.y = (float)(A);
    return V;
}

inline Vector2 MkVector2D(double x, double y)
{
    Vector2 V;
    V.x = (float)(x);
    V.y = (float)(y);
    return V;
}

inline Vector2 MkVector2D(double A)
{
    Vector2 V;
    V.x = (float)(A);
    V.y = (float)(A);
    return V;
}

inline Vector2 MkVector2(float x, float y)
{
    Vector2 V;
    V.x = (float)(x);
    V.y = (float)(y);
    return V;
}

inline Vector2 MkVector2(float A)
{
    Vector2 V;
    V.x = (float)(A);
    V.y = (float)(A);
    return V;
}

inline Vector3 MkVector3I(Int32 x, Int32 y, Int32 z)
{
    Vector3 V;
    V.x = (float)(x);
    V.y = (float)(y);
    V.z = (float)(z);
    return V;
}

inline Vector3 MkVector3I(Int32 A)
{
    Vector3 V;
    V.x = (float)(A);
    V.y = (float)(A);
    V.z = (float)(A);
    return V;
}

inline Vector3 MkVector3B(byte x, byte y, byte z)
{
    Vector3 V;
    V.x = (float)(x);
    V.y = (float)(y);
    V.z = (float)(z);
    return V;
}

inline Vector3 MkVector3B(byte A)
{
    Vector3 V;
    V.x = (float)(A);
    V.y = (float)(A);
    V.z = (float)(A);
    return V;
}

inline Vector3 MkVector3D(double x, double y, double z)
{
    Vector3 V;
    V.x = (float)(x);
    V.y = (float)(y);
    V.z = (float)(z);
    return V;
}

inline Vector3 MkVector3D(double A)
{
    Vector3 V;
    V.x = (float)(A);
    V.y = (float)(A);
    V.z = (float)(A);
    return V;
}

inline Vector3 MkVector3(float x, float y, float z)
{
    Vector3 V;
    V.x = (float)(x);
    V.y = (float)(y);
    V.z = (float)(z);
    return V;
}

inline Vector3 MkVector3(float A)
{
    Vector3 V;
    V.x = (float)(A);
    V.y = (float)(A);
    V.z = (float)(A);
    return V;
}

inline Vector4 MkVector4I(Int32 x, Int32 y, Int32 z, Int32 w)
{
    Vector4 V;
    V.x = (float)(x);
    V.y = (float)(y);
    V.z = (float)(z);
    V.w = (float)(w);
    return V;
}

inline Vector4 MkVector4I(Int32 A)
{
    Vector4 V;
    V.x = (float)(A);
    V.y = (float)(A);
    V.z = (float)(A);
    V.w = (float)(A);
    return V;
}

inline Vector4 MkVector4B(byte x, byte y, byte z, byte w)
{
    Vector4 V;
    V.x = (float)(x);
    V.y = (float)(y);
    V.z = (float)(z);
    V.w = (float)(w);
    return V;
}

inline Vector4 MkVector4B(byte A)
{
    Vector4 V;
    V.x = (float)(A);
    V.y = (float)(A);
    V.z = (float)(A);
    V.w = (float)(A);
    return V;
}

inline Vector4 MkVector4D(double x, double y, double z, double w)
{
    Vector4 V;
    V.x = (float)(x);
    V.y = (float)(y);
    V.z = (float)(z);
    V.w = (float)(w);
    return V;
}

inline Vector4 MkVector4D(double A)
{
    Vector4 V;
    V.x = (float)(A);
    V.y = (float)(A);
    V.z = (float)(A);
    V.w = (float)(A);
    return V;
}

inline Vector4 MkVector4(float x, float y, float z, float w)
{
    Vector4 V;
    V.x = (float)(x);
    V.y = (float)(y);
    V.z = (float)(z);
    V.w = (float)(w);
    return V;
}

inline Vector4 MkVector4(float A)
{
    Vector4 V;
    V.x = (float)(A);
    V.y = (float)(A);
    V.z = (float)(A);
    V.w = (float)(A);
    return V;
}

// Constructors from other vectors. Float converts to int using floor
inline VectorI2 MkVectorI2B(VectorB2 V)
{
    return MkVectorI2B(V.x, V.y);
}

inline VectorI2 MkVectorI2D(VectorD2 V)
{
    return MkVectorI2D(V.x, V.y);
}

inline VectorI2 MkVectorI2F(Vector2 V)
{
    return MkVectorI2F(V.x, V.y);
}

inline VectorI3 MkVectorI3B(VectorB3 V)
{
    return MkVectorI3B(V.x, V.y, V.z);
}

inline VectorI3 MkVectorI3D(VectorD3 V)
{
    return MkVectorI3D(V.x, V.y, V.z);
}

inline VectorI3 MkVectorI3F(Vector3 V)
{
    return MkVectorI3F(V.x, V.y, V.z);
}

inline VectorI4 MkVectorI4B(VectorB4 V)
{
    return MkVectorI4B(V.x, V.y, V.z, V.w);
}

inline VectorI4 MkVectorI4D(VectorD4 V)
{
    return MkVectorI4D(V.x, V.y, V.z, V.w);
}

inline VectorI4 MkVectorI4F(Vector4 V)
{
    return MkVectorI4F(V.x, V.y, V.z, V.w);
}

inline VectorB2 MkVectorB2I(VectorI2 V)
{
    return MkVectorB2I(V.x, V.y);
}

inline VectorB2 MkVectorB2D(VectorD2 V)
{
    return MkVectorB2D(V.x, V.y);
}

inline VectorB2 MkVectorB2F(Vector2 V)
{
    return MkVectorB2F(V.x, V.y);
}

inline VectorB3 MkVectorB3I(VectorI3 V)
{
    return MkVectorB3I(V.x, V.y, V.z);
}

inline VectorB3 MkVectorB3D(VectorD3 V)
{
    return MkVectorB3D(V.x, V.y, V.z);
}

inline VectorB3 MkVectorB3F(Vector3 V)
{
    return MkVectorB3F(V.x, V.y, V.z);
}

inline VectorB4 MkVectorB4I(VectorI4 V)
{
    return MkVectorB4I(V.x, V.y, V.z, V.w);
}

inline VectorB4 MkVectorB4D(VectorD4 V)
{
    return MkVectorB4D(V.x, V.y, V.z, V.w);
}

inline VectorB4 MkVectorB4F(Vector4 V)
{
    return MkVectorB4F(V.x, V.y, V.z, V.w);
}

inline VectorD2 MkVectorD2I(VectorI2 V)
{
    return MkVectorD2I(V.x, V.y);
}

inline VectorD2 MkVectorD2B(VectorB2 V)
{
    return MkVectorD2B(V.x, V.y);
}

inline VectorD2 MkVectorD2F(Vector2 V)
{
    return MkVectorD2F(V.x, V.y);
}

inline VectorD3 MkVectorD3I(VectorI3 V)
{
    return MkVectorD3I(V.x, V.y, V.z);
}

inline VectorD3 MkVectorD3B(VectorB3 V)
{
    return MkVectorD3B(V.x, V.y, V.z);
}

inline VectorD3 MkVectorD3F(Vector3 V)
{
    return MkVectorD3F(V.x, V.y, V.z);
}

inline VectorD4 MkVectorD4I(VectorI4 V)
{
    return MkVectorD4I(V.x, V.y, V.z, V.w);
}

inline VectorD4 MkVectorD4B(VectorB4 V)
{
    return MkVectorD4B(V.x, V.y, V.z, V.w);
}

inline VectorD4 MkVectorD4F(Vector4 V)
{
    return MkVectorD4F(V.x, V.y, V.z, V.w);
}

inline Vector2 MkVector2I(VectorI2 V)
{
    return MkVector2I(V.x, V.y);
}

inline Vector2 MkVector2B(VectorB2 V)
{
    return MkVector2B(V.x, V.y);
}

inline Vector2 MkVector2D(VectorD2 V)
{
    return MkVector2D(V.x, V.y);
}

inline Vector3 MkVector3I(VectorI3 V)
{
    return MkVector3I(V.x, V.y, V.z);
}

inline Vector3 MkVector3B(VectorB3 V)
{
    return MkVector3B(V.x, V.y, V.z);
}

inline Vector3 MkVector3D(VectorD3 V)
{
    return MkVector3D(V.x, V.y, V.z);
}

inline Vector4 MkVector4I(VectorI4 V)
{
    return MkVector4I(V.x, V.y, V.z, V.w);
}

inline Vector4 MkVector4B(VectorB4 V)
{
    return MkVector4B(V.x, V.y, V.z, V.w);
}

inline Vector4 MkVector4D(VectorD4 V)
{
    return MkVector4D(V.x, V.y, V.z, V.w);
}

// Constructors from ceiling rather than floor
inline VectorI2 CeilVectorI2D(VectorD2 V)
{
    return MkVectorI2D(CeilID(V.x), CeilID(V.y));
}

inline VectorI2 CeilVectorI2F(Vector2 V)
{
    return MkVectorI2F(CeilIF(V.x), CeilIF(V.y));
}

inline VectorI3 CeilVectorI3D(VectorD3 V)
{
    return MkVectorI3D(CeilID(V.x), CeilID(V.y), CeilID(V.z));
}

inline VectorI3 CeilVectorI3F(Vector3 V)
{
    return MkVectorI3F(CeilIF(V.x), CeilIF(V.y), CeilIF(V.z));
}

inline VectorI4 CeilVectorI4D(VectorD4 V)
{
    return MkVectorI4D(CeilID(V.x), CeilID(V.y), CeilID(V.z), CeilID(V.w));
}

inline VectorI4 CeilVectorI4F(Vector4 V)
{
    return MkVectorI4F(CeilIF(V.x), CeilIF(V.y), CeilIF(V.z), CeilIF(V.w));
}

inline VectorB2 CeilVectorB2D(VectorD2 V)
{
    return MkVectorB2D(CeilBD(V.x), CeilBD(V.y));
}

inline VectorB2 CeilVectorB2F(Vector2 V)
{
    return MkVectorB2F(CeilBF(V.x), CeilBF(V.y));
}

inline VectorB3 CeilVectorB3D(VectorD3 V)
{
    return MkVectorB3D(CeilBD(V.x), CeilBD(V.y), CeilBD(V.z));
}

inline VectorB3 CeilVectorB3F(Vector3 V)
{
    return MkVectorB3F(CeilBF(V.x), CeilBF(V.y), CeilBF(V.z));
}

inline VectorB4 CeilVectorB4D(VectorD4 V)
{
    return MkVectorB4D(CeilBD(V.x), CeilBD(V.y), CeilBD(V.z), CeilBD(V.w));
}

inline VectorB4 CeilVectorB4F(Vector4 V)
{
    return MkVectorB4F(CeilBF(V.x), CeilBF(V.y), CeilBF(V.z), CeilBF(V.w));
}

// Equality operator
inline Boolean operator==(VectorI2 A, VectorI2 B)
{
    return (A.x == B.x)
        && (A.y == B.y);
}

inline Boolean operator==(VectorI3 A, VectorI3 B)
{
    return (A.x == B.x)
        && (A.y == B.y)
        && (A.z == B.z);
}

inline Boolean operator==(VectorI4 A, VectorI4 B)
{
    return (A.x == B.x)
        && (A.y == B.y)
        && (A.z == B.z)
        && (A.w == B.w);
}

inline Boolean operator==(VectorB2 A, VectorB2 B)
{
    return (A.x == B.x)
        && (A.y == B.y);
}

inline Boolean operator==(VectorB3 A, VectorB3 B)
{
    return (A.x == B.x)
        && (A.y == B.y)
        && (A.z == B.z);
}

inline Boolean operator==(VectorB4 A, VectorB4 B)
{
    return (A.x == B.x)
        && (A.y == B.y)
        && (A.z == B.z)
        && (A.w == B.w);
}

inline Boolean operator==(VectorD2 A, VectorD2 B)
{
    return (A.x == B.x)
        && (A.y == B.y);
}

inline Boolean operator==(VectorD3 A, VectorD3 B)
{
    return (A.x == B.x)
        && (A.y == B.y)
        && (A.z == B.z);
}

inline Boolean operator==(VectorD4 A, VectorD4 B)
{
    return (A.x == B.x)
        && (A.y == B.y)
        && (A.z == B.z)
        && (A.w == B.w);
}

inline Boolean operator==(Vector2 A, Vector2 B)
{
    return (A.x == B.x)
        && (A.y == B.y);
}

inline Boolean operator==(Vector3 A, Vector3 B)
{
    return (A.x == B.x)
        && (A.y == B.y)
        && (A.z == B.z);
}

inline Boolean operator==(Vector4 A, Vector4 B)
{
    return (A.x == B.x)
        && (A.y == B.y)
        && (A.z == B.z)
        && (A.w == B.w);
}

// Inequality operator
inline Boolean operator!=(VectorI2 A, VectorI2 B)
{
    return (A.x != B.x)
        || (A.y != B.y);
}

inline Boolean operator!=(VectorI3 A, VectorI3 B)
{
    return (A.x != B.x)
        || (A.y != B.y)
        || (A.z != B.z);
}

inline Boolean operator!=(VectorI4 A, VectorI4 B)
{
    return (A.x != B.x)
        || (A.y != B.y)
        || (A.z != B.z)
        || (A.w != B.w);
}

inline Boolean operator!=(VectorB2 A, VectorB2 B)
{
    return (A.x != B.x)
        || (A.y != B.y);
}

inline Boolean operator!=(VectorB3 A, VectorB3 B)
{
    return (A.x != B.x)
        || (A.y != B.y)
        || (A.z != B.z);
}

inline Boolean operator!=(VectorB4 A, VectorB4 B)
{
    return (A.x != B.x)
        || (A.y != B.y)
        || (A.z != B.z)
        || (A.w != B.w);
}

inline Boolean operator!=(VectorD2 A, VectorD2 B)
{
    return (A.x != B.x)
        || (A.y != B.y);
}

inline Boolean operator!=(VectorD3 A, VectorD3 B)
{
    return (A.x != B.x)
        || (A.y != B.y)
        || (A.z != B.z);
}

inline Boolean operator!=(VectorD4 A, VectorD4 B)
{
    return (A.x != B.x)
        || (A.y != B.y)
        || (A.z != B.z)
        || (A.w != B.w);
}

inline Boolean operator!=(Vector2 A, Vector2 B)
{
    return (A.x != B.x)
        || (A.y != B.y);
}

inline Boolean operator!=(Vector3 A, Vector3 B)
{
    return (A.x != B.x)
        || (A.y != B.y)
        || (A.z != B.z);
}

inline Boolean operator!=(Vector4 A, Vector4 B)
{
    return (A.x != B.x)
        || (A.y != B.y)
        || (A.z != B.z)
        || (A.w != B.w);
}

// Evaluate whether all terms are greater than, less than, greater than or equal, less than or equal
inline Boolean StrictGt(VectorI2 A, VectorI2 B)
{
    return (A.x > B.x)
        && (A.y > B.y);
}

inline Boolean StrictGt(VectorI3 A, VectorI3 B)
{
    return (A.x > B.x)
        && (A.y > B.y)
        && (A.z > B.z);
}

inline Boolean StrictGt(VectorI4 A, VectorI4 B)
{
    return (A.x > B.x)
        && (A.y > B.y)
        && (A.z > B.z)
        && (A.w > B.w);
}

inline Boolean StrictGt(VectorB2 A, VectorB2 B)
{
    return (A.x > B.x)
        && (A.y > B.y);
}

inline Boolean StrictGt(VectorB3 A, VectorB3 B)
{
    return (A.x > B.x)
        && (A.y > B.y)
        && (A.z > B.z);
}

inline Boolean StrictGt(VectorB4 A, VectorB4 B)
{
    return (A.x > B.x)
        && (A.y > B.y)
        && (A.z > B.z)
        && (A.w > B.w);
}

inline Boolean StrictGt(VectorD2 A, VectorD2 B)
{
    return (A.x > B.x)
        && (A.y > B.y);
}

inline Boolean StrictGt(VectorD3 A, VectorD3 B)
{
    return (A.x > B.x)
        && (A.y > B.y)
        && (A.z > B.z);
}

inline Boolean StrictGt(VectorD4 A, VectorD4 B)
{
    return (A.x > B.x)
        && (A.y > B.y)
        && (A.z > B.z)
        && (A.w > B.w);
}

inline Boolean StrictGt(Vector2 A, Vector2 B)
{
    return (A.x > B.x)
        && (A.y > B.y);
}

inline Boolean StrictGt(Vector3 A, Vector3 B)
{
    return (A.x > B.x)
        && (A.y > B.y)
        && (A.z > B.z);
}

inline Boolean StrictGt(Vector4 A, Vector4 B)
{
    return (A.x > B.x)
        && (A.y > B.y)
        && (A.z > B.z)
        && (A.w > B.w);
}

inline Boolean StrictLt(VectorI2 A, VectorI2 B)
{
    return (A.x < B.x)
        && (A.y < B.y);
}

inline Boolean StrictLt(VectorI3 A, VectorI3 B)
{
    return (A.x < B.x)
        && (A.y < B.y)
        && (A.z < B.z);
}

inline Boolean StrictLt(VectorI4 A, VectorI4 B)
{
    return (A.x < B.x)
        && (A.y < B.y)
        && (A.z < B.z)
        && (A.w < B.w);
}

inline Boolean StrictLt(VectorB2 A, VectorB2 B)
{
    return (A.x < B.x)
        && (A.y < B.y);
}

inline Boolean StrictLt(VectorB3 A, VectorB3 B)
{
    return (A.x < B.x)
        && (A.y < B.y)
        && (A.z < B.z);
}

inline Boolean StrictLt(VectorB4 A, VectorB4 B)
{
    return (A.x < B.x)
        && (A.y < B.y)
        && (A.z < B.z)
        && (A.w < B.w);
}

inline Boolean StrictLt(VectorD2 A, VectorD2 B)
{
    return (A.x < B.x)
        && (A.y < B.y);
}

inline Boolean StrictLt(VectorD3 A, VectorD3 B)
{
    return (A.x < B.x)
        && (A.y < B.y)
        && (A.z < B.z);
}

inline Boolean StrictLt(VectorD4 A, VectorD4 B)
{
    return (A.x < B.x)
        && (A.y < B.y)
        && (A.z < B.z)
        && (A.w < B.w);
}

inline Boolean StrictLt(Vector2 A, Vector2 B)
{
    return (A.x < B.x)
        && (A.y < B.y);
}

inline Boolean StrictLt(Vector3 A, Vector3 B)
{
    return (A.x < B.x)
        && (A.y < B.y)
        && (A.z < B.z);
}

inline Boolean StrictLt(Vector4 A, Vector4 B)
{
    return (A.x < B.x)
        && (A.y < B.y)
        && (A.z < B.z)
        && (A.w < B.w);
}

inline Boolean StrictGte(VectorI2 A, VectorI2 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y);
}

inline Boolean StrictGte(VectorI3 A, VectorI3 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y)
        && (A.z >= B.z);
}

inline Boolean StrictGte(VectorI4 A, VectorI4 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y)
        && (A.z >= B.z)
        && (A.w >= B.w);
}

inline Boolean StrictGte(VectorB2 A, VectorB2 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y);
}

inline Boolean StrictGte(VectorB3 A, VectorB3 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y)
        && (A.z >= B.z);
}

inline Boolean StrictGte(VectorB4 A, VectorB4 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y)
        && (A.z >= B.z)
        && (A.w >= B.w);
}

inline Boolean StrictGte(VectorD2 A, VectorD2 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y);
}

inline Boolean StrictGte(VectorD3 A, VectorD3 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y)
        && (A.z >= B.z);
}

inline Boolean StrictGte(VectorD4 A, VectorD4 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y)
        && (A.z >= B.z)
        && (A.w >= B.w);
}

inline Boolean StrictGte(Vector2 A, Vector2 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y);
}

inline Boolean StrictGte(Vector3 A, Vector3 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y)
        && (A.z >= B.z);
}

inline Boolean StrictGte(Vector4 A, Vector4 B)
{
    return (A.x >= B.x)
        && (A.y >= B.y)
        && (A.z >= B.z)
        && (A.w >= B.w);
}

inline Boolean StrictLte(VectorI2 A, VectorI2 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y);
}

inline Boolean StrictLte(VectorI3 A, VectorI3 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y)
        && (A.z <= B.z);
}

inline Boolean StrictLte(VectorI4 A, VectorI4 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y)
        && (A.z <= B.z)
        && (A.w <= B.w);
}

inline Boolean StrictLte(VectorB2 A, VectorB2 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y);
}

inline Boolean StrictLte(VectorB3 A, VectorB3 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y)
        && (A.z <= B.z);
}

inline Boolean StrictLte(VectorB4 A, VectorB4 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y)
        && (A.z <= B.z)
        && (A.w <= B.w);
}

inline Boolean StrictLte(VectorD2 A, VectorD2 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y);
}

inline Boolean StrictLte(VectorD3 A, VectorD3 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y)
        && (A.z <= B.z);
}

inline Boolean StrictLte(VectorD4 A, VectorD4 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y)
        && (A.z <= B.z)
        && (A.w <= B.w);
}

inline Boolean StrictLte(Vector2 A, Vector2 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y);
}

inline Boolean StrictLte(Vector3 A, Vector3 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y)
        && (A.z <= B.z);
}

inline Boolean StrictLte(Vector4 A, Vector4 B)
{
    return (A.x <= B.x)
        && (A.y <= B.y)
        && (A.z <= B.z)
        && (A.w <= B.w);
}

// Addition operator
inline VectorI2 operator+(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(A.x + B.x),
        (Int32)(A.y + B.y));
}

inline VectorI3 operator+(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(A.x + B.x),
        (Int32)(A.y + B.y),
        (Int32)(A.z + B.z));
}

inline VectorI4 operator+(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(A.x + B.x),
        (Int32)(A.y + B.y),
        (Int32)(A.z + B.z),
        (Int32)(A.w + B.w));
}

inline VectorB2 operator+(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(A.x + B.x),
        (byte)(A.y + B.y));
}

inline VectorB3 operator+(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(A.x + B.x),
        (byte)(A.y + B.y),
        (byte)(A.z + B.z));
}

inline VectorB4 operator+(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(A.x + B.x),
        (byte)(A.y + B.y),
        (byte)(A.z + B.z),
        (byte)(A.w + B.w));
}

inline VectorD2 operator+(VectorD2 A, VectorD2 B)
{
    return MkVectorD2(
        (double)(A.x + B.x),
        (double)(A.y + B.y));
}

inline VectorD3 operator+(VectorD3 A, VectorD3 B)
{
    return MkVectorD3(
        (double)(A.x + B.x),
        (double)(A.y + B.y),
        (double)(A.z + B.z));
}

inline VectorD4 operator+(VectorD4 A, VectorD4 B)
{
    return MkVectorD4(
        (double)(A.x + B.x),
        (double)(A.y + B.y),
        (double)(A.z + B.z),
        (double)(A.w + B.w));
}

inline Vector2 operator+(Vector2 A, Vector2 B)
{
    return MkVector2(
        (float)(A.x + B.x),
        (float)(A.y + B.y));
}

inline Vector3 operator+(Vector3 A, Vector3 B)
{
    return MkVector3(
        (float)(A.x + B.x),
        (float)(A.y + B.y),
        (float)(A.z + B.z));
}

inline Vector4 operator+(Vector4 A, Vector4 B)
{
    return MkVector4(
        (float)(A.x + B.x),
        (float)(A.y + B.y),
        (float)(A.z + B.z),
        (float)(A.w + B.w));
}

// Subtraction operator
inline VectorI2 operator-(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(A.x - B.x),
        (Int32)(A.y - B.y));
}

inline VectorI3 operator-(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(A.x - B.x),
        (Int32)(A.y - B.y),
        (Int32)(A.z - B.z));
}

inline VectorI4 operator-(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(A.x - B.x),
        (Int32)(A.y - B.y),
        (Int32)(A.z - B.z),
        (Int32)(A.w - B.w));
}

inline VectorB2 operator-(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(A.x - B.x),
        (byte)(A.y - B.y));
}

inline VectorB3 operator-(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(A.x - B.x),
        (byte)(A.y - B.y),
        (byte)(A.z - B.z));
}

inline VectorB4 operator-(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(A.x - B.x),
        (byte)(A.y - B.y),
        (byte)(A.z - B.z),
        (byte)(A.w - B.w));
}

inline VectorD2 operator-(VectorD2 A, VectorD2 B)
{
    return MkVectorD2(
        (double)(A.x - B.x),
        (double)(A.y - B.y));
}

inline VectorD3 operator-(VectorD3 A, VectorD3 B)
{
    return MkVectorD3(
        (double)(A.x - B.x),
        (double)(A.y - B.y),
        (double)(A.z - B.z));
}

inline VectorD4 operator-(VectorD4 A, VectorD4 B)
{
    return MkVectorD4(
        (double)(A.x - B.x),
        (double)(A.y - B.y),
        (double)(A.z - B.z),
        (double)(A.w - B.w));
}

inline Vector2 operator-(Vector2 A, Vector2 B)
{
    return MkVector2(
        (float)(A.x - B.x),
        (float)(A.y - B.y));
}

inline Vector3 operator-(Vector3 A, Vector3 B)
{
    return MkVector3(
        (float)(A.x - B.x),
        (float)(A.y - B.y),
        (float)(A.z - B.z));
}

inline Vector4 operator-(Vector4 A, Vector4 B)
{
    return MkVector4(
        (float)(A.x - B.x),
        (float)(A.y - B.y),
        (float)(A.z - B.z),
        (float)(A.w - B.w));
}

// Elementwise multiplication (equivalent to Scale() in Unity)
inline VectorI2 ElMult(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(A.x * B.x),
        (Int32)(A.y * B.y));
}

inline VectorI3 ElMult(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(A.x * B.x),
        (Int32)(A.y * B.y),
        (Int32)(A.z * B.z));
}

inline VectorI4 ElMult(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(A.x * B.x),
        (Int32)(A.y * B.y),
        (Int32)(A.z * B.z),
        (Int32)(A.w * B.w));
}

inline VectorB2 ElMult(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(A.x * B.x),
        (byte)(A.y * B.y));
}

inline VectorB3 ElMult(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(A.x * B.x),
        (byte)(A.y * B.y),
        (byte)(A.z * B.z));
}

inline VectorB4 ElMult(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(A.x * B.x),
        (byte)(A.y * B.y),
        (byte)(A.z * B.z),
        (byte)(A.w * B.w));
}

inline VectorD2 ElMult(VectorD2 A, VectorD2 B)
{
    return MkVectorD2(
        (double)(A.x * B.x),
        (double)(A.y * B.y));
}

inline VectorD3 ElMult(VectorD3 A, VectorD3 B)
{
    return MkVectorD3(
        (double)(A.x * B.x),
        (double)(A.y * B.y),
        (double)(A.z * B.z));
}

inline VectorD4 ElMult(VectorD4 A, VectorD4 B)
{
    return MkVectorD4(
        (double)(A.x * B.x),
        (double)(A.y * B.y),
        (double)(A.z * B.z),
        (double)(A.w * B.w));
}

inline Vector2 ElMult(Vector2 A, Vector2 B)
{
    return MkVector2(
        (float)(A.x * B.x),
        (float)(A.y * B.y));
}

inline Vector3 ElMult(Vector3 A, Vector3 B)
{
    return MkVector3(
        (float)(A.x * B.x),
        (float)(A.y * B.y),
        (float)(A.z * B.z));
}

inline Vector4 ElMult(Vector4 A, Vector4 B)
{
    return MkVector4(
        (float)(A.x * B.x),
        (float)(A.y * B.y),
        (float)(A.z * B.z),
        (float)(A.w * B.w));
}

// Elementwise division. Uses floor.
inline VectorI2 ElDiv(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(Div(A.x, B.x)),
        (Int32)(Div(A.y, B.y)));
}

inline VectorI3 ElDiv(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(Div(A.x, B.x)),
        (Int32)(Div(A.y, B.y)),
        (Int32)(Div(A.z, B.z)));
}

inline VectorI4 ElDiv(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(Div(A.x, B.x)),
        (Int32)(Div(A.y, B.y)),
        (Int32)(Div(A.z, B.z)),
        (Int32)(Div(A.w, B.w)));
}

inline VectorB2 ElDiv(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(Div(A.x, B.x)),
        (byte)(Div(A.y, B.y)));
}

inline VectorB3 ElDiv(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(Div(A.x, B.x)),
        (byte)(Div(A.y, B.y)),
        (byte)(Div(A.z, B.z)));
}

inline VectorB4 ElDiv(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(Div(A.x, B.x)),
        (byte)(Div(A.y, B.y)),
        (byte)(Div(A.z, B.z)),
        (byte)(Div(A.w, B.w)));
}

inline VectorD2 ElDiv(VectorD2 A, VectorD2 B)
{
    return MkVectorD2(
        (double)(Div(A.x, B.x)),
        (double)(Div(A.y, B.y)));
}

inline VectorD3 ElDiv(VectorD3 A, VectorD3 B)
{
    return MkVectorD3(
        (double)(Div(A.x, B.x)),
        (double)(Div(A.y, B.y)),
        (double)(Div(A.z, B.z)));
}

inline VectorD4 ElDiv(VectorD4 A, VectorD4 B)
{
    return MkVectorD4(
        (double)(Div(A.x, B.x)),
        (double)(Div(A.y, B.y)),
        (double)(Div(A.z, B.z)),
        (double)(Div(A.w, B.w)));
}

inline Vector2 ElDiv(Vector2 A, Vector2 B)
{
    return MkVector2(
        (float)(Div(A.x, B.x)),
        (float)(Div(A.y, B.y)));
}

inline Vector3 ElDiv(Vector3 A, Vector3 B)
{
    return MkVector3(
        (float)(Div(A.x, B.x)),
        (float)(Div(A.y, B.y)),
        (float)(Div(A.z, B.z)));
}

inline Vector4 ElDiv(Vector4 A, Vector4 B)
{
    return MkVector4(
        (float)(Div(A.x, B.x)),
        (float)(Div(A.y, B.y)),
        (float)(Div(A.z, B.z)),
        (float)(Div(A.w, B.w)));
}

// Elementwise division that uses ceiling instead of floor
inline VectorI2 ElCeilDiv(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(CeilDiv(A.x, B.x)),
        (Int32)(CeilDiv(A.y, B.y)));
}

inline VectorI3 ElCeilDiv(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(CeilDiv(A.x, B.x)),
        (Int32)(CeilDiv(A.y, B.y)),
        (Int32)(CeilDiv(A.z, B.z)));
}

inline VectorI4 ElCeilDiv(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(CeilDiv(A.x, B.x)),
        (Int32)(CeilDiv(A.y, B.y)),
        (Int32)(CeilDiv(A.z, B.z)),
        (Int32)(CeilDiv(A.w, B.w)));
}

inline VectorB2 ElCeilDiv(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(CeilDiv(A.x, B.x)),
        (byte)(CeilDiv(A.y, B.y)));
}

inline VectorB3 ElCeilDiv(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(CeilDiv(A.x, B.x)),
        (byte)(CeilDiv(A.y, B.y)),
        (byte)(CeilDiv(A.z, B.z)));
}

inline VectorB4 ElCeilDiv(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(CeilDiv(A.x, B.x)),
        (byte)(CeilDiv(A.y, B.y)),
        (byte)(CeilDiv(A.z, B.z)),
        (byte)(CeilDiv(A.w, B.w)));
}

// Elementwise min/max
inline VectorI2 ElMin(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(Min(A.x, B.x)),
        (Int32)(Min(A.y, B.y)));
}

inline VectorI3 ElMin(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(Min(A.x, B.x)),
        (Int32)(Min(A.y, B.y)),
        (Int32)(Min(A.z, B.z)));
}

inline VectorI4 ElMin(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(Min(A.x, B.x)),
        (Int32)(Min(A.y, B.y)),
        (Int32)(Min(A.z, B.z)),
        (Int32)(Min(A.w, B.w)));
}

inline VectorB2 ElMin(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(Min(A.x, B.x)),
        (byte)(Min(A.y, B.y)));
}

inline VectorB3 ElMin(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(Min(A.x, B.x)),
        (byte)(Min(A.y, B.y)),
        (byte)(Min(A.z, B.z)));
}

inline VectorB4 ElMin(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(Min(A.x, B.x)),
        (byte)(Min(A.y, B.y)),
        (byte)(Min(A.z, B.z)),
        (byte)(Min(A.w, B.w)));
}

inline VectorD2 ElMin(VectorD2 A, VectorD2 B)
{
    return MkVectorD2(
        (double)(Min(A.x, B.x)),
        (double)(Min(A.y, B.y)));
}

inline VectorD3 ElMin(VectorD3 A, VectorD3 B)
{
    return MkVectorD3(
        (double)(Min(A.x, B.x)),
        (double)(Min(A.y, B.y)),
        (double)(Min(A.z, B.z)));
}

inline VectorD4 ElMin(VectorD4 A, VectorD4 B)
{
    return MkVectorD4(
        (double)(Min(A.x, B.x)),
        (double)(Min(A.y, B.y)),
        (double)(Min(A.z, B.z)),
        (double)(Min(A.w, B.w)));
}

inline Vector2 ElMin(Vector2 A, Vector2 B)
{
    return MkVector2(
        (float)(Min(A.x, B.x)),
        (float)(Min(A.y, B.y)));
}

inline Vector3 ElMin(Vector3 A, Vector3 B)
{
    return MkVector3(
        (float)(Min(A.x, B.x)),
        (float)(Min(A.y, B.y)),
        (float)(Min(A.z, B.z)));
}

inline Vector4 ElMin(Vector4 A, Vector4 B)
{
    return MkVector4(
        (float)(Min(A.x, B.x)),
        (float)(Min(A.y, B.y)),
        (float)(Min(A.z, B.z)),
        (float)(Min(A.w, B.w)));
}

inline VectorI2 ElMax(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(Max(A.x, B.x)),
        (Int32)(Max(A.y, B.y)));
}

inline VectorI3 ElMax(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(Max(A.x, B.x)),
        (Int32)(Max(A.y, B.y)),
        (Int32)(Max(A.z, B.z)));
}

inline VectorI4 ElMax(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(Max(A.x, B.x)),
        (Int32)(Max(A.y, B.y)),
        (Int32)(Max(A.z, B.z)),
        (Int32)(Max(A.w, B.w)));
}

inline VectorB2 ElMax(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(Max(A.x, B.x)),
        (byte)(Max(A.y, B.y)));
}

inline VectorB3 ElMax(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(Max(A.x, B.x)),
        (byte)(Max(A.y, B.y)),
        (byte)(Max(A.z, B.z)));
}

inline VectorB4 ElMax(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(Max(A.x, B.x)),
        (byte)(Max(A.y, B.y)),
        (byte)(Max(A.z, B.z)),
        (byte)(Max(A.w, B.w)));
}

inline VectorD2 ElMax(VectorD2 A, VectorD2 B)
{
    return MkVectorD2(
        (double)(Max(A.x, B.x)),
        (double)(Max(A.y, B.y)));
}

inline VectorD3 ElMax(VectorD3 A, VectorD3 B)
{
    return MkVectorD3(
        (double)(Max(A.x, B.x)),
        (double)(Max(A.y, B.y)),
        (double)(Max(A.z, B.z)));
}

inline VectorD4 ElMax(VectorD4 A, VectorD4 B)
{
    return MkVectorD4(
        (double)(Max(A.x, B.x)),
        (double)(Max(A.y, B.y)),
        (double)(Max(A.z, B.z)),
        (double)(Max(A.w, B.w)));
}

inline Vector2 ElMax(Vector2 A, Vector2 B)
{
    return MkVector2(
        (float)(Max(A.x, B.x)),
        (float)(Max(A.y, B.y)));
}

inline Vector3 ElMax(Vector3 A, Vector3 B)
{
    return MkVector3(
        (float)(Max(A.x, B.x)),
        (float)(Max(A.y, B.y)),
        (float)(Max(A.z, B.z)));
}

inline Vector4 ElMax(Vector4 A, Vector4 B)
{
    return MkVector4(
        (float)(Max(A.x, B.x)),
        (float)(Max(A.y, B.y)),
        (float)(Max(A.z, B.z)),
        (float)(Max(A.w, B.w)));
}

// Elementwise remainder. Uses floor.
inline VectorI2 ElRem(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(Rem(A.x, B.x)),
        (Int32)(Rem(A.y, B.y)));
}

inline VectorI3 ElRem(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(Rem(A.x, B.x)),
        (Int32)(Rem(A.y, B.y)),
        (Int32)(Rem(A.z, B.z)));
}

inline VectorI4 ElRem(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(Rem(A.x, B.x)),
        (Int32)(Rem(A.y, B.y)),
        (Int32)(Rem(A.z, B.z)),
        (Int32)(Rem(A.w, B.w)));
}

inline VectorB2 ElRem(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(Rem(A.x, B.x)),
        (byte)(Rem(A.y, B.y)));
}

inline VectorB3 ElRem(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(Rem(A.x, B.x)),
        (byte)(Rem(A.y, B.y)),
        (byte)(Rem(A.z, B.z)));
}

inline VectorB4 ElRem(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(Rem(A.x, B.x)),
        (byte)(Rem(A.y, B.y)),
        (byte)(Rem(A.z, B.z)),
        (byte)(Rem(A.w, B.w)));
}

// Elementwise multiplication/division/remainder by 2^B_i
inline VectorI2 ElPow2Div(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(Pow2Div(A.x, B.x)),
        (Int32)(Pow2Div(A.y, B.y)));
}

inline VectorI3 ElPow2Div(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(Pow2Div(A.x, B.x)),
        (Int32)(Pow2Div(A.y, B.y)),
        (Int32)(Pow2Div(A.z, B.z)));
}

inline VectorI4 ElPow2Div(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(Pow2Div(A.x, B.x)),
        (Int32)(Pow2Div(A.y, B.y)),
        (Int32)(Pow2Div(A.z, B.z)),
        (Int32)(Pow2Div(A.w, B.w)));
}

inline VectorB2 ElPow2Div(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(Pow2Div(A.x, B.x)),
        (byte)(Pow2Div(A.y, B.y)));
}

inline VectorB3 ElPow2Div(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(Pow2Div(A.x, B.x)),
        (byte)(Pow2Div(A.y, B.y)),
        (byte)(Pow2Div(A.z, B.z)));
}

inline VectorB4 ElPow2Div(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(Pow2Div(A.x, B.x)),
        (byte)(Pow2Div(A.y, B.y)),
        (byte)(Pow2Div(A.z, B.z)),
        (byte)(Pow2Div(A.w, B.w)));
}

inline VectorI2 ElPow2Mult(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(Pow2Mult(A.x, B.x)),
        (Int32)(Pow2Mult(A.y, B.y)));
}

inline VectorI3 ElPow2Mult(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(Pow2Mult(A.x, B.x)),
        (Int32)(Pow2Mult(A.y, B.y)),
        (Int32)(Pow2Mult(A.z, B.z)));
}

inline VectorI4 ElPow2Mult(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(Pow2Mult(A.x, B.x)),
        (Int32)(Pow2Mult(A.y, B.y)),
        (Int32)(Pow2Mult(A.z, B.z)),
        (Int32)(Pow2Mult(A.w, B.w)));
}

inline VectorB2 ElPow2Mult(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(Pow2Mult(A.x, B.x)),
        (byte)(Pow2Mult(A.y, B.y)));
}

inline VectorB3 ElPow2Mult(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(Pow2Mult(A.x, B.x)),
        (byte)(Pow2Mult(A.y, B.y)),
        (byte)(Pow2Mult(A.z, B.z)));
}

inline VectorB4 ElPow2Mult(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(Pow2Mult(A.x, B.x)),
        (byte)(Pow2Mult(A.y, B.y)),
        (byte)(Pow2Mult(A.z, B.z)),
        (byte)(Pow2Mult(A.w, B.w)));
}

inline VectorI2 ElPow2Rem(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(Pow2Rem(A.x, B.x)),
        (Int32)(Pow2Rem(A.y, B.y)));
}

inline VectorI3 ElPow2Rem(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(Pow2Rem(A.x, B.x)),
        (Int32)(Pow2Rem(A.y, B.y)),
        (Int32)(Pow2Rem(A.z, B.z)));
}

inline VectorI4 ElPow2Rem(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(Pow2Rem(A.x, B.x)),
        (Int32)(Pow2Rem(A.y, B.y)),
        (Int32)(Pow2Rem(A.z, B.z)),
        (Int32)(Pow2Rem(A.w, B.w)));
}

inline VectorB2 ElPow2Rem(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(Pow2Rem(A.x, B.x)),
        (byte)(Pow2Rem(A.y, B.y)));
}

inline VectorB3 ElPow2Rem(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(Pow2Rem(A.x, B.x)),
        (byte)(Pow2Rem(A.y, B.y)),
        (byte)(Pow2Rem(A.z, B.z)));
}

inline VectorB4 ElPow2Rem(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(Pow2Rem(A.x, B.x)),
        (byte)(Pow2Rem(A.y, B.y)),
        (byte)(Pow2Rem(A.z, B.z)),
        (byte)(Pow2Rem(A.w, B.w)));
}

inline VectorI2 ElPow2CeilDiv(VectorI2 A, VectorI2 B)
{
    return MkVectorI2(
        (Int32)(Pow2CeilDiv(A.x, B.x)),
        (Int32)(Pow2CeilDiv(A.y, B.y)));
}

inline VectorI3 ElPow2CeilDiv(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (Int32)(Pow2CeilDiv(A.x, B.x)),
        (Int32)(Pow2CeilDiv(A.y, B.y)),
        (Int32)(Pow2CeilDiv(A.z, B.z)));
}

inline VectorI4 ElPow2CeilDiv(VectorI4 A, VectorI4 B)
{
    return MkVectorI4(
        (Int32)(Pow2CeilDiv(A.x, B.x)),
        (Int32)(Pow2CeilDiv(A.y, B.y)),
        (Int32)(Pow2CeilDiv(A.z, B.z)),
        (Int32)(Pow2CeilDiv(A.w, B.w)));
}

inline VectorB2 ElPow2CeilDiv(VectorB2 A, VectorB2 B)
{
    return MkVectorB2(
        (byte)(Pow2CeilDiv(A.x, B.x)),
        (byte)(Pow2CeilDiv(A.y, B.y)));
}

inline VectorB3 ElPow2CeilDiv(VectorB3 A, VectorB3 B)
{
    return MkVectorB3(
        (byte)(Pow2CeilDiv(A.x, B.x)),
        (byte)(Pow2CeilDiv(A.y, B.y)),
        (byte)(Pow2CeilDiv(A.z, B.z)));
}

inline VectorB4 ElPow2CeilDiv(VectorB4 A, VectorB4 B)
{
    return MkVectorB4(
        (byte)(Pow2CeilDiv(A.x, B.x)),
        (byte)(Pow2CeilDiv(A.y, B.y)),
        (byte)(Pow2CeilDiv(A.z, B.z)),
        (byte)(Pow2CeilDiv(A.w, B.w)));
}

// Negation (as in Additive Inverse) operator
inline VectorI2 operator-(VectorI2 V)
{
    return MkVectorI2(-V.x, -V.y);
}

inline VectorI3 operator-(VectorI3 V)
{
    return MkVectorI3(-V.x, -V.y, -V.z);
}

inline VectorI4 operator-(VectorI4 V)
{
    return MkVectorI4(-V.x, -V.y, -V.z, -V.w);
}

inline VectorD2 operator-(VectorD2 V)
{
    return MkVectorD2(-V.x, -V.y);
}

inline VectorD3 operator-(VectorD3 V)
{
    return MkVectorD3(-V.x, -V.y, -V.z);
}

inline VectorD4 operator-(VectorD4 V)
{
    return MkVectorD4(-V.x, -V.y, -V.z, -V.w);
}

inline Vector2 operator-(Vector2 V)
{
    return MkVector2(-V.x, -V.y);
}

inline Vector3 operator-(Vector3 V)
{
    return MkVector3(-V.x, -V.y, -V.z);
}

inline Vector4 operator-(Vector4 V)
{
    return MkVector4(-V.x, -V.y, -V.z, -V.w);
}

// Scalar multiplication/division operators
inline VectorI2 operator*(Int32 A, VectorI2 V)
{
    return MkVectorI2(
        (Int32)((A * V.x)),
        (Int32)((A * V.y)));
}

inline VectorI3 operator*(Int32 A, VectorI3 V)
{
    return MkVectorI3(
        (Int32)((A * V.x)),
        (Int32)((A * V.y)),
        (Int32)((A * V.z)));
}

inline VectorI4 operator*(Int32 A, VectorI4 V)
{
    return MkVectorI4(
        (Int32)((A * V.x)),
        (Int32)((A * V.y)),
        (Int32)((A * V.z)),
        (Int32)((A * V.w)));
}

inline VectorB2 operator*(byte A, VectorB2 V)
{
    return MkVectorB2(
        (byte)((A * V.x)),
        (byte)((A * V.y)));
}

inline VectorB3 operator*(byte A, VectorB3 V)
{
    return MkVectorB3(
        (byte)((A * V.x)),
        (byte)((A * V.y)),
        (byte)((A * V.z)));
}

inline VectorB4 operator*(byte A, VectorB4 V)
{
    return MkVectorB4(
        (byte)((A * V.x)),
        (byte)((A * V.y)),
        (byte)((A * V.z)),
        (byte)((A * V.w)));
}

inline VectorD2 operator*(double A, VectorD2 V)
{
    return MkVectorD2(
        (double)((A * V.x)),
        (double)((A * V.y)));
}

inline VectorD3 operator*(double A, VectorD3 V)
{
    return MkVectorD3(
        (double)((A * V.x)),
        (double)((A * V.y)),
        (double)((A * V.z)));
}

inline VectorD4 operator*(double A, VectorD4 V)
{
    return MkVectorD4(
        (double)((A * V.x)),
        (double)((A * V.y)),
        (double)((A * V.z)),
        (double)((A * V.w)));
}

inline Vector2 operator*(float A, Vector2 V)
{
    return MkVector2(
        (float)((A * V.x)),
        (float)((A * V.y)));
}

inline Vector3 operator*(float A, Vector3 V)
{
    return MkVector3(
        (float)((A * V.x)),
        (float)((A * V.y)),
        (float)((A * V.z)));
}

inline Vector4 operator*(float A, Vector4 V)
{
    return MkVector4(
        (float)((A * V.x)),
        (float)((A * V.y)),
        (float)((A * V.z)),
        (float)((A * V.w)));
}

inline VectorI2 operator/(Int32 A, VectorI2 V)
{
    return MkVectorI2(
        (Int32)((Div(A, V.x))),
        (Int32)((Div(A, V.y))));
}

inline VectorI3 operator/(Int32 A, VectorI3 V)
{
    return MkVectorI3(
        (Int32)((Div(A, V.x))),
        (Int32)((Div(A, V.y))),
        (Int32)((Div(A, V.z))));
}

inline VectorI4 operator/(Int32 A, VectorI4 V)
{
    return MkVectorI4(
        (Int32)((Div(A, V.x))),
        (Int32)((Div(A, V.y))),
        (Int32)((Div(A, V.z))),
        (Int32)((Div(A, V.w))));
}

inline VectorB2 operator/(byte A, VectorB2 V)
{
    return MkVectorB2(
        (byte)((Div(A, V.x))),
        (byte)((Div(A, V.y))));
}

inline VectorB3 operator/(byte A, VectorB3 V)
{
    return MkVectorB3(
        (byte)((Div(A, V.x))),
        (byte)((Div(A, V.y))),
        (byte)((Div(A, V.z))));
}

inline VectorB4 operator/(byte A, VectorB4 V)
{
    return MkVectorB4(
        (byte)((Div(A, V.x))),
        (byte)((Div(A, V.y))),
        (byte)((Div(A, V.z))),
        (byte)((Div(A, V.w))));
}

inline VectorD2 operator/(double A, VectorD2 V)
{
    return MkVectorD2(
        (double)((Div(A, V.x))),
        (double)((Div(A, V.y))));
}

inline VectorD3 operator/(double A, VectorD3 V)
{
    return MkVectorD3(
        (double)((Div(A, V.x))),
        (double)((Div(A, V.y))),
        (double)((Div(A, V.z))));
}

inline VectorD4 operator/(double A, VectorD4 V)
{
    return MkVectorD4(
        (double)((Div(A, V.x))),
        (double)((Div(A, V.y))),
        (double)((Div(A, V.z))),
        (double)((Div(A, V.w))));
}

inline Vector2 operator/(float A, Vector2 V)
{
    return MkVector2(
        (float)((Div(A, V.x))),
        (float)((Div(A, V.y))));
}

inline Vector3 operator/(float A, Vector3 V)
{
    return MkVector3(
        (float)((Div(A, V.x))),
        (float)((Div(A, V.y))),
        (float)((Div(A, V.z))));
}

inline Vector4 operator/(float A, Vector4 V)
{
    return MkVector4(
        (float)((Div(A, V.x))),
        (float)((Div(A, V.y))),
        (float)((Div(A, V.z))),
        (float)((Div(A, V.w))));
}

inline VectorI2 operator*(VectorI2 V, Int32 A)
{
    return MkVectorI2(
        (Int32)((V.x * A)),
        (Int32)((V.y * A)));
}

inline VectorI3 operator*(VectorI3 V, Int32 A)
{
    return MkVectorI3(
        (Int32)((V.x * A)),
        (Int32)((V.y * A)),
        (Int32)((V.z * A)));
}

inline VectorI4 operator*(VectorI4 V, Int32 A)
{
    return MkVectorI4(
        (Int32)((V.x * A)),
        (Int32)((V.y * A)),
        (Int32)((V.z * A)),
        (Int32)((V.w * A)));
}

inline VectorB2 operator*(VectorB2 V, byte A)
{
    return MkVectorB2(
        (byte)((V.x * A)),
        (byte)((V.y * A)));
}

inline VectorB3 operator*(VectorB3 V, byte A)
{
    return MkVectorB3(
        (byte)((V.x * A)),
        (byte)((V.y * A)),
        (byte)((V.z * A)));
}

inline VectorB4 operator*(VectorB4 V, byte A)
{
    return MkVectorB4(
        (byte)((V.x * A)),
        (byte)((V.y * A)),
        (byte)((V.z * A)),
        (byte)((V.w * A)));
}

inline VectorD2 operator*(VectorD2 V, double A)
{
    return MkVectorD2(
        (double)((V.x * A)),
        (double)((V.y * A)));
}

inline VectorD3 operator*(VectorD3 V, double A)
{
    return MkVectorD3(
        (double)((V.x * A)),
        (double)((V.y * A)),
        (double)((V.z * A)));
}

inline VectorD4 operator*(VectorD4 V, double A)
{
    return MkVectorD4(
        (double)((V.x * A)),
        (double)((V.y * A)),
        (double)((V.z * A)),
        (double)((V.w * A)));
}

inline Vector2 operator*(Vector2 V, float A)
{
    return MkVector2(
        (float)((V.x * A)),
        (float)((V.y * A)));
}

inline Vector3 operator*(Vector3 V, float A)
{
    return MkVector3(
        (float)((V.x * A)),
        (float)((V.y * A)),
        (float)((V.z * A)));
}

inline Vector4 operator*(Vector4 V, float A)
{
    return MkVector4(
        (float)((V.x * A)),
        (float)((V.y * A)),
        (float)((V.z * A)),
        (float)((V.w * A)));
}

inline VectorI2 operator/(VectorI2 V, Int32 A)
{
    return MkVectorI2(
        (Int32)((Div(V.x, A))),
        (Int32)((Div(V.y, A))));
}

inline VectorI3 operator/(VectorI3 V, Int32 A)
{
    return MkVectorI3(
        (Int32)((Div(V.x, A))),
        (Int32)((Div(V.y, A))),
        (Int32)((Div(V.z, A))));
}

inline VectorI4 operator/(VectorI4 V, Int32 A)
{
    return MkVectorI4(
        (Int32)((Div(V.x, A))),
        (Int32)((Div(V.y, A))),
        (Int32)((Div(V.z, A))),
        (Int32)((Div(V.w, A))));
}

inline VectorB2 operator/(VectorB2 V, byte A)
{
    return MkVectorB2(
        (byte)((Div(V.x, A))),
        (byte)((Div(V.y, A))));
}

inline VectorB3 operator/(VectorB3 V, byte A)
{
    return MkVectorB3(
        (byte)((Div(V.x, A))),
        (byte)((Div(V.y, A))),
        (byte)((Div(V.z, A))));
}

inline VectorB4 operator/(VectorB4 V, byte A)
{
    return MkVectorB4(
        (byte)((Div(V.x, A))),
        (byte)((Div(V.y, A))),
        (byte)((Div(V.z, A))),
        (byte)((Div(V.w, A))));
}

inline VectorD2 operator/(VectorD2 V, double A)
{
    return MkVectorD2(
        (double)((Div(V.x, A))),
        (double)((Div(V.y, A))));
}

inline VectorD3 operator/(VectorD3 V, double A)
{
    return MkVectorD3(
        (double)((Div(V.x, A))),
        (double)((Div(V.y, A))),
        (double)((Div(V.z, A))));
}

inline VectorD4 operator/(VectorD4 V, double A)
{
    return MkVectorD4(
        (double)((Div(V.x, A))),
        (double)((Div(V.y, A))),
        (double)((Div(V.z, A))),
        (double)((Div(V.w, A))));
}

inline Vector2 operator/(Vector2 V, float A)
{
    return MkVector2(
        (float)((Div(V.x, A))),
        (float)((Div(V.y, A))));
}

inline Vector3 operator/(Vector3 V, float A)
{
    return MkVector3(
        (float)((Div(V.x, A))),
        (float)((Div(V.y, A))),
        (float)((Div(V.z, A))));
}

inline Vector4 operator/(Vector4 V, float A)
{
    return MkVector4(
        (float)((Div(V.x, A))),
        (float)((Div(V.y, A))),
        (float)((Div(V.z, A))),
        (float)((Div(V.w, A))));
}

// Compound assignment operators
inline VectorI2& operator+=(VectorI2& A, VectorI2 B)
{
    A = A + B;
    return A;
}

inline VectorI3& operator+=(VectorI3& A, VectorI3 B)
{
    A = A + B;
    return A;
}

inline VectorI4& operator+=(VectorI4& A, VectorI4 B)
{
    A = A + B;
    return A;
}

inline VectorB2& operator+=(VectorB2& A, VectorB2 B)
{
    A = A + B;
    return A;
}

inline VectorB3& operator+=(VectorB3& A, VectorB3 B)
{
    A = A + B;
    return A;
}

inline VectorB4& operator+=(VectorB4& A, VectorB4 B)
{
    A = A + B;
    return A;
}

inline VectorD2& operator+=(VectorD2& A, VectorD2 B)
{
    A = A + B;
    return A;
}

inline VectorD3& operator+=(VectorD3& A, VectorD3 B)
{
    A = A + B;
    return A;
}

inline VectorD4& operator+=(VectorD4& A, VectorD4 B)
{
    A = A + B;
    return A;
}

inline Vector2& operator+=(Vector2& A, Vector2 B)
{
    A = A + B;
    return A;
}

inline Vector3& operator+=(Vector3& A, Vector3 B)
{
    A = A + B;
    return A;
}

inline Vector4& operator+=(Vector4& A, Vector4 B)
{
    A = A + B;
    return A;
}

inline VectorI2& operator-=(VectorI2& A, VectorI2 B)
{
    A = A - B;
    return A;
}

inline VectorI3& operator-=(VectorI3& A, VectorI3 B)
{
    A = A - B;
    return A;
}

inline VectorI4& operator-=(VectorI4& A, VectorI4 B)
{
    A = A - B;
    return A;
}

inline VectorB2& operator-=(VectorB2& A, VectorB2 B)
{
    A = A - B;
    return A;
}

inline VectorB3& operator-=(VectorB3& A, VectorB3 B)
{
    A = A - B;
    return A;
}

inline VectorB4& operator-=(VectorB4& A, VectorB4 B)
{
    A = A - B;
    return A;
}

inline VectorD2& operator-=(VectorD2& A, VectorD2 B)
{
    A = A - B;
    return A;
}

inline VectorD3& operator-=(VectorD3& A, VectorD3 B)
{
    A = A - B;
    return A;
}

inline VectorD4& operator-=(VectorD4& A, VectorD4 B)
{
    A = A - B;
    return A;
}

inline Vector2& operator-=(Vector2& A, Vector2 B)
{
    A = A - B;
    return A;
}

inline Vector3& operator-=(Vector3& A, Vector3 B)
{
    A = A - B;
    return A;
}

inline Vector4& operator-=(Vector4& A, Vector4 B)
{
    A = A - B;
    return A;
}

inline VectorI2& operator*=(VectorI2& V, Int32 A)
{
    V = V * A;
    return V;
}

inline VectorI3& operator*=(VectorI3& V, Int32 A)
{
    V = V * A;
    return V;
}

inline VectorI4& operator*=(VectorI4& V, Int32 A)
{
    V = V * A;
    return V;
}

inline VectorB2& operator*=(VectorB2& V, byte A)
{
    V = V * A;
    return V;
}

inline VectorB3& operator*=(VectorB3& V, byte A)
{
    V = V * A;
    return V;
}

inline VectorB4& operator*=(VectorB4& V, byte A)
{
    V = V * A;
    return V;
}

inline VectorD2& operator*=(VectorD2& V, double A)
{
    V = V * A;
    return V;
}

inline VectorD3& operator*=(VectorD3& V, double A)
{
    V = V * A;
    return V;
}

inline VectorD4& operator*=(VectorD4& V, double A)
{
    V = V * A;
    return V;
}

inline Vector2& operator*=(Vector2& V, float A)
{
    V = V * A;
    return V;
}

inline Vector3& operator*=(Vector3& V, float A)
{
    V = V * A;
    return V;
}

inline Vector4& operator*=(Vector4& V, float A)
{
    V = V * A;
    return V;
}

inline VectorI2& operator/=(VectorI2& V, Int32 A)
{
    V = V / A;
    return V;
}

inline VectorI3& operator/=(VectorI3& V, Int32 A)
{
    V = V / A;
    return V;
}

inline VectorI4& operator/=(VectorI4& V, Int32 A)
{
    V = V / A;
    return V;
}

inline VectorB2& operator/=(VectorB2& V, byte A)
{
    V = V / A;
    return V;
}

inline VectorB3& operator/=(VectorB3& V, byte A)
{
    V = V / A;
    return V;
}

inline VectorB4& operator/=(VectorB4& V, byte A)
{
    V = V / A;
    return V;
}

inline VectorD2& operator/=(VectorD2& V, double A)
{
    V = V / A;
    return V;
}

inline VectorD3& operator/=(VectorD3& V, double A)
{
    V = V / A;
    return V;
}

inline VectorD4& operator/=(VectorD4& V, double A)
{
    V = V / A;
    return V;
}

inline Vector2& operator/=(Vector2& V, float A)
{
    V = V / A;
    return V;
}

inline Vector3& operator/=(Vector3& V, float A)
{
    V = V / A;
    return V;
}

inline Vector4& operator/=(Vector4& V, float A)
{
    V = V / A;
    return V;
}

// Dot product
inline Int32 DotP(VectorI2 A, VectorI2 B)
{
    return (Int32)((A.x * B.x)
        + (A.y * B.y));
}

inline Int32 DotP(VectorI3 A, VectorI3 B)
{
    return (Int32)((A.x * B.x)
        + (A.y * B.y)
        + (A.z * B.z));
}

inline Int32 DotP(VectorI4 A, VectorI4 B)
{
    return (Int32)((A.x * B.x)
        + (A.y * B.y)
        + (A.z * B.z)
        + (A.w * B.w));
}

inline byte DotP(VectorB2 A, VectorB2 B)
{
    return (byte)((A.x * B.x)
        + (A.y * B.y));
}

inline Int32 DotPI(VectorB2 A, VectorB2 B)
{
    return (Int32)((Int32)(A.x * B.x)
        + (Int32)(A.y * B.y));
}

inline byte DotP(VectorB3 A, VectorB3 B)
{
    return (byte)((A.x * B.x)
        + (A.y * B.y)
        + (A.z * B.z));
}

inline Int32 DotPI(VectorB3 A, VectorB3 B)
{
    return (Int32)((Int32)(A.x * B.x)
        + (Int32)(A.y * B.y)
        + (Int32)(A.z * B.z));
}

inline byte DotP(VectorB4 A, VectorB4 B)
{
    return (byte)((A.x * B.x)
        + (A.y * B.y)
        + (A.z * B.z)
        + (A.w * B.w));
}

inline Int32 DotPI(VectorB4 A, VectorB4 B)
{
    return (Int32)((Int32)(A.x * B.x)
        + (Int32)(A.y * B.y)
        + (Int32)(A.z * B.z)
        + (Int32)(A.w * B.w));
}

inline double DotP(VectorD2 A, VectorD2 B)
{
    return (double)((A.x * B.x)
        + (A.y * B.y));
}

inline double DotP(VectorD3 A, VectorD3 B)
{
    return (double)((A.x * B.x)
        + (A.y * B.y)
        + (A.z * B.z));
}

inline double DotP(VectorD4 A, VectorD4 B)
{
    return (double)((A.x * B.x)
        + (A.y * B.y)
        + (A.z * B.z)
        + (A.w * B.w));
}

inline float DotP(Vector2 A, Vector2 B)
{
    return (float)((A.x * B.x)
        + (A.y * B.y));
}

inline double DotPD(Vector2 A, Vector2 B)
{
    return (double)((double)(A.x * B.x)
        + (double)(A.y * B.y));
}

inline float DotP(Vector3 A, Vector3 B)
{
    return (float)((A.x * B.x)
        + (A.y * B.y)
        + (A.z * B.z));
}

inline double DotPD(Vector3 A, Vector3 B)
{
    return (double)((double)(A.x * B.x)
        + (double)(A.y * B.y)
        + (double)(A.z * B.z));
}

inline float DotP(Vector4 A, Vector4 B)
{
    return (float)((A.x * B.x)
        + (A.y * B.y)
        + (A.z * B.z)
        + (A.w * B.w));
}

inline double DotPD(Vector4 A, Vector4 B)
{
    return (double)((double)(A.x * B.x)
        + (double)(A.y * B.y)
        + (double)(A.z * B.z)
        + (double)(A.w * B.w));
}

// Square length
inline Int32 SqLen(VectorI2 V)
{
    return DotP(V,V);
}

inline Int32 SqLen(VectorI3 V)
{
    return DotP(V,V);
}

inline Int32 SqLen(VectorI4 V)
{
    return DotP(V,V);
}

inline byte SqLen(VectorB2 V)
{
    return DotP(V,V);
}

inline Int32 SqLenI(VectorB2 V)
{
    return DotPI(V,V);
}

inline byte SqLen(VectorB3 V)
{
    return DotP(V,V);
}

inline Int32 SqLenI(VectorB3 V)
{
    return DotPI(V,V);
}

inline byte SqLen(VectorB4 V)
{
    return DotP(V,V);
}

inline Int32 SqLenI(VectorB4 V)
{
    return DotPI(V,V);
}

inline double SqLen(VectorD2 V)
{
    return DotP(V,V);
}

inline double SqLen(VectorD3 V)
{
    return DotP(V,V);
}

inline double SqLen(VectorD4 V)
{
    return DotP(V,V);
}

inline float SqLen(Vector2 V)
{
    return DotP(V,V);
}

inline double SqLenD(Vector2 V)
{
    return DotPD(V,V);
}

inline float SqLen(Vector3 V)
{
    return DotP(V,V);
}

inline double SqLenD(Vector3 V)
{
    return DotPD(V,V);
}

inline float SqLen(Vector4 V)
{
    return DotP(V,V);
}

inline double SqLenD(Vector4 V)
{
    return DotPD(V,V);
}

// Manhattan length operators (ie sum of components)
inline Int32 ManhatLength(VectorI2 V)
{
    return (Int32)(V.x + V.y);
}

inline Int32 ManhatLength(VectorI3 V)
{
    return (Int32)(V.x + V.y + V.z);
}

inline Int32 ManhatLength(VectorI4 V)
{
    return (Int32)(V.x + V.y + V.z + V.w);
}

inline byte ManhatLength(VectorB2 V)
{
    return (byte)(V.x + V.y);
}

inline byte ManhatLength(VectorB3 V)
{
    return (byte)(V.x + V.y + V.z);
}

inline byte ManhatLength(VectorB4 V)
{
    return (byte)(V.x + V.y + V.z + V.w);
}

inline double ManhatLength(VectorD2 V)
{
    return (double)(V.x + V.y);
}

inline double ManhatLength(VectorD3 V)
{
    return (double)(V.x + V.y + V.z);
}

inline double ManhatLength(VectorD4 V)
{
    return (double)(V.x + V.y + V.z + V.w);
}

inline float ManhatLength(Vector2 V)
{
    return (float)(V.x + V.y);
}

inline float ManhatLength(Vector3 V)
{
    return (float)(V.x + V.y + V.z);
}

inline float ManhatLength(Vector4 V)
{
    return (float)(V.x + V.y + V.z + V.w);
}

// Vector length (as in, euclidean)
inline double Len(VectorD2 V)
{
    return Sqrt(SqLen(V));
}

inline double Len(VectorD3 V)
{
    return Sqrt(SqLen(V));
}

inline double Len(VectorD4 V)
{
    return Sqrt(SqLen(V));
}

inline float Len(Vector2 V)
{
    return Sqrt(SqLen(V));
}

inline float Len(Vector3 V)
{
    return Sqrt(SqLen(V));
}

inline float Len(Vector4 V)
{
    return Sqrt(SqLen(V));
}

// Normalized vector
inline VectorD2 Norm(VectorD2 V)
{
    return V/Len(V);
}

inline VectorD3 Norm(VectorD3 V)
{
    return V/Len(V);
}

inline VectorD4 Norm(VectorD4 V)
{
    return V/Len(V);
}

inline Vector2 Norm(Vector2 V)
{
    return V/Len(V);
}

inline Vector3 Norm(Vector3 V)
{
    return V/Len(V);
}

inline Vector4 Norm(Vector4 V)
{
    return V/Len(V);
}

// Product of components of vector
inline Int32 Volume(VectorI2 V)
{
    return (Int32)(V.x * V.y);
}

inline Int32 Volume(VectorI3 V)
{
    return (Int32)(V.x * V.y * V.z);
}

inline Int32 Volume(VectorI4 V)
{
    return (Int32)(V.x * V.y * V.z * V.w);
}

inline byte Volume(VectorB2 V)
{
    return (byte)(V.x * V.y);
}

inline Int32 VolumeI(VectorB2 V)
{
    return (Int32)(V.x * V.y);
}

inline byte Volume(VectorB3 V)
{
    return (byte)(V.x * V.y * V.z);
}

inline Int32 VolumeI(VectorB3 V)
{
    return (Int32)(V.x * V.y * V.z);
}

inline byte Volume(VectorB4 V)
{
    return (byte)(V.x * V.y * V.z * V.w);
}

inline Int32 VolumeI(VectorB4 V)
{
    return (Int32)(V.x * V.y * V.z * V.w);
}

inline double Volume(VectorD2 V)
{
    return (double)(V.x * V.y);
}

inline double Volume(VectorD3 V)
{
    return (double)(V.x * V.y * V.z);
}

inline double Volume(VectorD4 V)
{
    return (double)(V.x * V.y * V.z * V.w);
}

inline float Volume(Vector2 V)
{
    return (float)(V.x * V.y);
}

inline double VolumeD(Vector2 V)
{
    return (double)(V.x * V.y);
}

inline float Volume(Vector3 V)
{
    return (float)(V.x * V.y * V.z);
}

inline double VolumeD(Vector3 V)
{
    return (double)(V.x * V.y * V.z);
}

inline float Volume(Vector4 V)
{
    return (float)(V.x * V.y * V.z * V.w);
}

inline double VolumeD(Vector4 V)
{
    return (double)(V.x * V.y * V.z * V.w);
}

inline Int32 Pow2Volume(VectorI2 V)
{
    return Pow2Mult((Int32)1, (Int32)(V.x + V.y));
}

inline Int32 Pow2Volume(VectorI3 V)
{
    return Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z));
}

inline Int32 Pow2Volume(VectorI4 V)
{
    return Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z + V.w));
}

inline byte Pow2Volume(VectorB2 V)
{
    return Pow2Mult((byte)1, (byte)(V.x + V.y));
}

inline Int32 Pow2VolumeI(VectorB2 V)
{
    return Pow2Mult((Int32)1, (Int32)(V.x + V.y));
}

inline byte Pow2Volume(VectorB3 V)
{
    return Pow2Mult((byte)1, (byte)(V.x + V.y + V.z));
}

inline Int32 Pow2VolumeI(VectorB3 V)
{
    return Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z));
}

inline byte Pow2Volume(VectorB4 V)
{
    return Pow2Mult((byte)1, (byte)(V.x + V.y + V.z + V.w));
}

inline Int32 Pow2VolumeI(VectorB4 V)
{
    return Pow2Mult((Int32)1, (Int32)(V.x + V.y + V.z + V.w));
}

// Cross product
inline VectorI3 CrossP(VectorI3 A, VectorI3 B)
{
    return MkVectorI3(
        (A.y * B.z) - (A.z * B.y),
        -(A.x * B.z) + (A.z * B.x),
        (A.x * B.y) - (A.y * B.x));
}

inline VectorD3 CrossP(VectorD3 A, VectorD3 B)
{
    return MkVectorD3(
        (A.y * B.z) - (A.z * B.y),
        -(A.x * B.z) + (A.z * B.x),
        (A.x * B.y) - (A.y * B.x));
}

inline Vector3 CrossP(Vector3 A, Vector3 B)
{
    return MkVector3(
        (A.y * B.z) - (A.z * B.y),
        -(A.x * B.z) + (A.z * B.x),
        (A.x * B.y) - (A.y * B.x));
}

// Swizzles
inline VectorI2 SwizzXX(VectorI2 V){ return MkVectorI2(V.x, V.x); }
inline VectorI2 SwizzXY(VectorI2 V){ return MkVectorI2(V.x, V.y); }
inline VectorI2 SwizzX_(VectorI2 V){ return MkVectorI2(V.x, 0); }
inline VectorI2 SwizzYX(VectorI2 V){ return MkVectorI2(V.y, V.x); }
inline VectorI2 SwizzYY(VectorI2 V){ return MkVectorI2(V.y, V.y); }
inline VectorI2 SwizzY_(VectorI2 V){ return MkVectorI2(V.y, 0); }
inline VectorI2 Swizz_X(VectorI2 V){ return MkVectorI2(0, V.x); }
inline VectorI2 Swizz_Y(VectorI2 V){ return MkVectorI2(0, V.y); }
inline VectorI3 SwizzXXX(VectorI2 V){ return MkVectorI3(V.x, V.x, V.x); }
inline VectorI3 SwizzXXY(VectorI2 V){ return MkVectorI3(V.x, V.x, V.y); }
inline VectorI3 SwizzXX_(VectorI2 V){ return MkVectorI3(V.x, V.x, 0); }
inline VectorI3 SwizzXYX(VectorI2 V){ return MkVectorI3(V.x, V.y, V.x); }
inline VectorI3 SwizzXYY(VectorI2 V){ return MkVectorI3(V.x, V.y, V.y); }
inline VectorI3 SwizzXY_(VectorI2 V){ return MkVectorI3(V.x, V.y, 0); }
inline VectorI3 SwizzX_X(VectorI2 V){ return MkVectorI3(V.x, 0, V.x); }
inline VectorI3 SwizzX_Y(VectorI2 V){ return MkVectorI3(V.x, 0, V.y); }
inline VectorI3 SwizzX__(VectorI2 V){ return MkVectorI3(V.x, 0, 0); }
inline VectorI3 SwizzYXX(VectorI2 V){ return MkVectorI3(V.y, V.x, V.x); }
inline VectorI3 SwizzYXY(VectorI2 V){ return MkVectorI3(V.y, V.x, V.y); }
inline VectorI3 SwizzYX_(VectorI2 V){ return MkVectorI3(V.y, V.x, 0); }
inline VectorI3 SwizzYYX(VectorI2 V){ return MkVectorI3(V.y, V.y, V.x); }
inline VectorI3 SwizzYYY(VectorI2 V){ return MkVectorI3(V.y, V.y, V.y); }
inline VectorI3 SwizzYY_(VectorI2 V){ return MkVectorI3(V.y, V.y, 0); }
inline VectorI3 SwizzY_X(VectorI2 V){ return MkVectorI3(V.y, 0, V.x); }
inline VectorI3 SwizzY_Y(VectorI2 V){ return MkVectorI3(V.y, 0, V.y); }
inline VectorI3 SwizzY__(VectorI2 V){ return MkVectorI3(V.y, 0, 0); }
inline VectorI3 Swizz_XX(VectorI2 V){ return MkVectorI3(0, V.x, V.x); }
inline VectorI3 Swizz_XY(VectorI2 V){ return MkVectorI3(0, V.x, V.y); }
inline VectorI3 Swizz_X_(VectorI2 V){ return MkVectorI3(0, V.x, 0); }
inline VectorI3 Swizz_YX(VectorI2 V){ return MkVectorI3(0, V.y, V.x); }
inline VectorI3 Swizz_YY(VectorI2 V){ return MkVectorI3(0, V.y, V.y); }
inline VectorI3 Swizz_Y_(VectorI2 V){ return MkVectorI3(0, V.y, 0); }
inline VectorI3 Swizz__X(VectorI2 V){ return MkVectorI3(0, 0, V.x); }
inline VectorI3 Swizz__Y(VectorI2 V){ return MkVectorI3(0, 0, V.y); }
inline VectorI4 SwizzXXXX(VectorI2 V){ return MkVectorI4(V.x, V.x, V.x, V.x); }
inline VectorI4 SwizzXXXY(VectorI2 V){ return MkVectorI4(V.x, V.x, V.x, V.y); }
inline VectorI4 SwizzXXX_(VectorI2 V){ return MkVectorI4(V.x, V.x, V.x, 0); }
inline VectorI4 SwizzXXYX(VectorI2 V){ return MkVectorI4(V.x, V.x, V.y, V.x); }
inline VectorI4 SwizzXXYY(VectorI2 V){ return MkVectorI4(V.x, V.x, V.y, V.y); }
inline VectorI4 SwizzXXY_(VectorI2 V){ return MkVectorI4(V.x, V.x, V.y, 0); }
inline VectorI4 SwizzXX_X(VectorI2 V){ return MkVectorI4(V.x, V.x, 0, V.x); }
inline VectorI4 SwizzXX_Y(VectorI2 V){ return MkVectorI4(V.x, V.x, 0, V.y); }
inline VectorI4 SwizzXX__(VectorI2 V){ return MkVectorI4(V.x, V.x, 0, 0); }
inline VectorI4 SwizzXYXX(VectorI2 V){ return MkVectorI4(V.x, V.y, V.x, V.x); }
inline VectorI4 SwizzXYXY(VectorI2 V){ return MkVectorI4(V.x, V.y, V.x, V.y); }
inline VectorI4 SwizzXYX_(VectorI2 V){ return MkVectorI4(V.x, V.y, V.x, 0); }
inline VectorI4 SwizzXYYX(VectorI2 V){ return MkVectorI4(V.x, V.y, V.y, V.x); }
inline VectorI4 SwizzXYYY(VectorI2 V){ return MkVectorI4(V.x, V.y, V.y, V.y); }
inline VectorI4 SwizzXYY_(VectorI2 V){ return MkVectorI4(V.x, V.y, V.y, 0); }
inline VectorI4 SwizzXY_X(VectorI2 V){ return MkVectorI4(V.x, V.y, 0, V.x); }
inline VectorI4 SwizzXY_Y(VectorI2 V){ return MkVectorI4(V.x, V.y, 0, V.y); }
inline VectorI4 SwizzXY__(VectorI2 V){ return MkVectorI4(V.x, V.y, 0, 0); }
inline VectorI4 SwizzX_XX(VectorI2 V){ return MkVectorI4(V.x, 0, V.x, V.x); }
inline VectorI4 SwizzX_XY(VectorI2 V){ return MkVectorI4(V.x, 0, V.x, V.y); }
inline VectorI4 SwizzX_X_(VectorI2 V){ return MkVectorI4(V.x, 0, V.x, 0); }
inline VectorI4 SwizzX_YX(VectorI2 V){ return MkVectorI4(V.x, 0, V.y, V.x); }
inline VectorI4 SwizzX_YY(VectorI2 V){ return MkVectorI4(V.x, 0, V.y, V.y); }
inline VectorI4 SwizzX_Y_(VectorI2 V){ return MkVectorI4(V.x, 0, V.y, 0); }
inline VectorI4 SwizzX__X(VectorI2 V){ return MkVectorI4(V.x, 0, 0, V.x); }
inline VectorI4 SwizzX__Y(VectorI2 V){ return MkVectorI4(V.x, 0, 0, V.y); }
inline VectorI4 SwizzX___(VectorI2 V){ return MkVectorI4(V.x, 0, 0, 0); }
inline VectorI4 SwizzYXXX(VectorI2 V){ return MkVectorI4(V.y, V.x, V.x, V.x); }
inline VectorI4 SwizzYXXY(VectorI2 V){ return MkVectorI4(V.y, V.x, V.x, V.y); }
inline VectorI4 SwizzYXX_(VectorI2 V){ return MkVectorI4(V.y, V.x, V.x, 0); }
inline VectorI4 SwizzYXYX(VectorI2 V){ return MkVectorI4(V.y, V.x, V.y, V.x); }
inline VectorI4 SwizzYXYY(VectorI2 V){ return MkVectorI4(V.y, V.x, V.y, V.y); }
inline VectorI4 SwizzYXY_(VectorI2 V){ return MkVectorI4(V.y, V.x, V.y, 0); }
inline VectorI4 SwizzYX_X(VectorI2 V){ return MkVectorI4(V.y, V.x, 0, V.x); }
inline VectorI4 SwizzYX_Y(VectorI2 V){ return MkVectorI4(V.y, V.x, 0, V.y); }
inline VectorI4 SwizzYX__(VectorI2 V){ return MkVectorI4(V.y, V.x, 0, 0); }
inline VectorI4 SwizzYYXX(VectorI2 V){ return MkVectorI4(V.y, V.y, V.x, V.x); }
inline VectorI4 SwizzYYXY(VectorI2 V){ return MkVectorI4(V.y, V.y, V.x, V.y); }
inline VectorI4 SwizzYYX_(VectorI2 V){ return MkVectorI4(V.y, V.y, V.x, 0); }
inline VectorI4 SwizzYYYX(VectorI2 V){ return MkVectorI4(V.y, V.y, V.y, V.x); }
inline VectorI4 SwizzYYYY(VectorI2 V){ return MkVectorI4(V.y, V.y, V.y, V.y); }
inline VectorI4 SwizzYYY_(VectorI2 V){ return MkVectorI4(V.y, V.y, V.y, 0); }
inline VectorI4 SwizzYY_X(VectorI2 V){ return MkVectorI4(V.y, V.y, 0, V.x); }
inline VectorI4 SwizzYY_Y(VectorI2 V){ return MkVectorI4(V.y, V.y, 0, V.y); }
inline VectorI4 SwizzYY__(VectorI2 V){ return MkVectorI4(V.y, V.y, 0, 0); }
inline VectorI4 SwizzY_XX(VectorI2 V){ return MkVectorI4(V.y, 0, V.x, V.x); }
inline VectorI4 SwizzY_XY(VectorI2 V){ return MkVectorI4(V.y, 0, V.x, V.y); }
inline VectorI4 SwizzY_X_(VectorI2 V){ return MkVectorI4(V.y, 0, V.x, 0); }
inline VectorI4 SwizzY_YX(VectorI2 V){ return MkVectorI4(V.y, 0, V.y, V.x); }
inline VectorI4 SwizzY_YY(VectorI2 V){ return MkVectorI4(V.y, 0, V.y, V.y); }
inline VectorI4 SwizzY_Y_(VectorI2 V){ return MkVectorI4(V.y, 0, V.y, 0); }
inline VectorI4 SwizzY__X(VectorI2 V){ return MkVectorI4(V.y, 0, 0, V.x); }
inline VectorI4 SwizzY__Y(VectorI2 V){ return MkVectorI4(V.y, 0, 0, V.y); }
inline VectorI4 SwizzY___(VectorI2 V){ return MkVectorI4(V.y, 0, 0, 0); }
inline VectorI4 Swizz_XXX(VectorI2 V){ return MkVectorI4(0, V.x, V.x, V.x); }
inline VectorI4 Swizz_XXY(VectorI2 V){ return MkVectorI4(0, V.x, V.x, V.y); }
inline VectorI4 Swizz_XX_(VectorI2 V){ return MkVectorI4(0, V.x, V.x, 0); }
inline VectorI4 Swizz_XYX(VectorI2 V){ return MkVectorI4(0, V.x, V.y, V.x); }
inline VectorI4 Swizz_XYY(VectorI2 V){ return MkVectorI4(0, V.x, V.y, V.y); }
inline VectorI4 Swizz_XY_(VectorI2 V){ return MkVectorI4(0, V.x, V.y, 0); }
inline VectorI4 Swizz_X_X(VectorI2 V){ return MkVectorI4(0, V.x, 0, V.x); }
inline VectorI4 Swizz_X_Y(VectorI2 V){ return MkVectorI4(0, V.x, 0, V.y); }
inline VectorI4 Swizz_X__(VectorI2 V){ return MkVectorI4(0, V.x, 0, 0); }
inline VectorI4 Swizz_YXX(VectorI2 V){ return MkVectorI4(0, V.y, V.x, V.x); }
inline VectorI4 Swizz_YXY(VectorI2 V){ return MkVectorI4(0, V.y, V.x, V.y); }
inline VectorI4 Swizz_YX_(VectorI2 V){ return MkVectorI4(0, V.y, V.x, 0); }
inline VectorI4 Swizz_YYX(VectorI2 V){ return MkVectorI4(0, V.y, V.y, V.x); }
inline VectorI4 Swizz_YYY(VectorI2 V){ return MkVectorI4(0, V.y, V.y, V.y); }
inline VectorI4 Swizz_YY_(VectorI2 V){ return MkVectorI4(0, V.y, V.y, 0); }
inline VectorI4 Swizz_Y_X(VectorI2 V){ return MkVectorI4(0, V.y, 0, V.x); }
inline VectorI4 Swizz_Y_Y(VectorI2 V){ return MkVectorI4(0, V.y, 0, V.y); }
inline VectorI4 Swizz_Y__(VectorI2 V){ return MkVectorI4(0, V.y, 0, 0); }
inline VectorI4 Swizz__XX(VectorI2 V){ return MkVectorI4(0, 0, V.x, V.x); }
inline VectorI4 Swizz__XY(VectorI2 V){ return MkVectorI4(0, 0, V.x, V.y); }
inline VectorI4 Swizz__X_(VectorI2 V){ return MkVectorI4(0, 0, V.x, 0); }
inline VectorI4 Swizz__YX(VectorI2 V){ return MkVectorI4(0, 0, V.y, V.x); }
inline VectorI4 Swizz__YY(VectorI2 V){ return MkVectorI4(0, 0, V.y, V.y); }
inline VectorI4 Swizz__Y_(VectorI2 V){ return MkVectorI4(0, 0, V.y, 0); }
inline VectorI4 Swizz___X(VectorI2 V){ return MkVectorI4(0, 0, 0, V.x); }
inline VectorI4 Swizz___Y(VectorI2 V){ return MkVectorI4(0, 0, 0, V.y); }
inline VectorI2 SwizzXX(VectorI3 V){ return MkVectorI2(V.x, V.x); }
inline VectorI2 SwizzXY(VectorI3 V){ return MkVectorI2(V.x, V.y); }
inline VectorI2 SwizzXZ(VectorI3 V){ return MkVectorI2(V.x, V.z); }
inline VectorI2 SwizzX_(VectorI3 V){ return MkVectorI2(V.x, 0); }
inline VectorI2 SwizzYX(VectorI3 V){ return MkVectorI2(V.y, V.x); }
inline VectorI2 SwizzYY(VectorI3 V){ return MkVectorI2(V.y, V.y); }
inline VectorI2 SwizzYZ(VectorI3 V){ return MkVectorI2(V.y, V.z); }
inline VectorI2 SwizzY_(VectorI3 V){ return MkVectorI2(V.y, 0); }
inline VectorI2 SwizzZX(VectorI3 V){ return MkVectorI2(V.z, V.x); }
inline VectorI2 SwizzZY(VectorI3 V){ return MkVectorI2(V.z, V.y); }
inline VectorI2 SwizzZZ(VectorI3 V){ return MkVectorI2(V.z, V.z); }
inline VectorI2 SwizzZ_(VectorI3 V){ return MkVectorI2(V.z, 0); }
inline VectorI2 Swizz_X(VectorI3 V){ return MkVectorI2(0, V.x); }
inline VectorI2 Swizz_Y(VectorI3 V){ return MkVectorI2(0, V.y); }
inline VectorI2 Swizz_Z(VectorI3 V){ return MkVectorI2(0, V.z); }
inline VectorI3 SwizzXXX(VectorI3 V){ return MkVectorI3(V.x, V.x, V.x); }
inline VectorI3 SwizzXXY(VectorI3 V){ return MkVectorI3(V.x, V.x, V.y); }
inline VectorI3 SwizzXXZ(VectorI3 V){ return MkVectorI3(V.x, V.x, V.z); }
inline VectorI3 SwizzXX_(VectorI3 V){ return MkVectorI3(V.x, V.x, 0); }
inline VectorI3 SwizzXYX(VectorI3 V){ return MkVectorI3(V.x, V.y, V.x); }
inline VectorI3 SwizzXYY(VectorI3 V){ return MkVectorI3(V.x, V.y, V.y); }
inline VectorI3 SwizzXYZ(VectorI3 V){ return MkVectorI3(V.x, V.y, V.z); }
inline VectorI3 SwizzXY_(VectorI3 V){ return MkVectorI3(V.x, V.y, 0); }
inline VectorI3 SwizzXZX(VectorI3 V){ return MkVectorI3(V.x, V.z, V.x); }
inline VectorI3 SwizzXZY(VectorI3 V){ return MkVectorI3(V.x, V.z, V.y); }
inline VectorI3 SwizzXZZ(VectorI3 V){ return MkVectorI3(V.x, V.z, V.z); }
inline VectorI3 SwizzXZ_(VectorI3 V){ return MkVectorI3(V.x, V.z, 0); }
inline VectorI3 SwizzX_X(VectorI3 V){ return MkVectorI3(V.x, 0, V.x); }
inline VectorI3 SwizzX_Y(VectorI3 V){ return MkVectorI3(V.x, 0, V.y); }
inline VectorI3 SwizzX_Z(VectorI3 V){ return MkVectorI3(V.x, 0, V.z); }
inline VectorI3 SwizzX__(VectorI3 V){ return MkVectorI3(V.x, 0, 0); }
inline VectorI3 SwizzYXX(VectorI3 V){ return MkVectorI3(V.y, V.x, V.x); }
inline VectorI3 SwizzYXY(VectorI3 V){ return MkVectorI3(V.y, V.x, V.y); }
inline VectorI3 SwizzYXZ(VectorI3 V){ return MkVectorI3(V.y, V.x, V.z); }
inline VectorI3 SwizzYX_(VectorI3 V){ return MkVectorI3(V.y, V.x, 0); }
inline VectorI3 SwizzYYX(VectorI3 V){ return MkVectorI3(V.y, V.y, V.x); }
inline VectorI3 SwizzYYY(VectorI3 V){ return MkVectorI3(V.y, V.y, V.y); }
inline VectorI3 SwizzYYZ(VectorI3 V){ return MkVectorI3(V.y, V.y, V.z); }
inline VectorI3 SwizzYY_(VectorI3 V){ return MkVectorI3(V.y, V.y, 0); }
inline VectorI3 SwizzYZX(VectorI3 V){ return MkVectorI3(V.y, V.z, V.x); }
inline VectorI3 SwizzYZY(VectorI3 V){ return MkVectorI3(V.y, V.z, V.y); }
inline VectorI3 SwizzYZZ(VectorI3 V){ return MkVectorI3(V.y, V.z, V.z); }
inline VectorI3 SwizzYZ_(VectorI3 V){ return MkVectorI3(V.y, V.z, 0); }
inline VectorI3 SwizzY_X(VectorI3 V){ return MkVectorI3(V.y, 0, V.x); }
inline VectorI3 SwizzY_Y(VectorI3 V){ return MkVectorI3(V.y, 0, V.y); }
inline VectorI3 SwizzY_Z(VectorI3 V){ return MkVectorI3(V.y, 0, V.z); }
inline VectorI3 SwizzY__(VectorI3 V){ return MkVectorI3(V.y, 0, 0); }
inline VectorI3 SwizzZXX(VectorI3 V){ return MkVectorI3(V.z, V.x, V.x); }
inline VectorI3 SwizzZXY(VectorI3 V){ return MkVectorI3(V.z, V.x, V.y); }
inline VectorI3 SwizzZXZ(VectorI3 V){ return MkVectorI3(V.z, V.x, V.z); }
inline VectorI3 SwizzZX_(VectorI3 V){ return MkVectorI3(V.z, V.x, 0); }
inline VectorI3 SwizzZYX(VectorI3 V){ return MkVectorI3(V.z, V.y, V.x); }
inline VectorI3 SwizzZYY(VectorI3 V){ return MkVectorI3(V.z, V.y, V.y); }
inline VectorI3 SwizzZYZ(VectorI3 V){ return MkVectorI3(V.z, V.y, V.z); }
inline VectorI3 SwizzZY_(VectorI3 V){ return MkVectorI3(V.z, V.y, 0); }
inline VectorI3 SwizzZZX(VectorI3 V){ return MkVectorI3(V.z, V.z, V.x); }
inline VectorI3 SwizzZZY(VectorI3 V){ return MkVectorI3(V.z, V.z, V.y); }
inline VectorI3 SwizzZZZ(VectorI3 V){ return MkVectorI3(V.z, V.z, V.z); }
inline VectorI3 SwizzZZ_(VectorI3 V){ return MkVectorI3(V.z, V.z, 0); }
inline VectorI3 SwizzZ_X(VectorI3 V){ return MkVectorI3(V.z, 0, V.x); }
inline VectorI3 SwizzZ_Y(VectorI3 V){ return MkVectorI3(V.z, 0, V.y); }
inline VectorI3 SwizzZ_Z(VectorI3 V){ return MkVectorI3(V.z, 0, V.z); }
inline VectorI3 SwizzZ__(VectorI3 V){ return MkVectorI3(V.z, 0, 0); }
inline VectorI3 Swizz_XX(VectorI3 V){ return MkVectorI3(0, V.x, V.x); }
inline VectorI3 Swizz_XY(VectorI3 V){ return MkVectorI3(0, V.x, V.y); }
inline VectorI3 Swizz_XZ(VectorI3 V){ return MkVectorI3(0, V.x, V.z); }
inline VectorI3 Swizz_X_(VectorI3 V){ return MkVectorI3(0, V.x, 0); }
inline VectorI3 Swizz_YX(VectorI3 V){ return MkVectorI3(0, V.y, V.x); }
inline VectorI3 Swizz_YY(VectorI3 V){ return MkVectorI3(0, V.y, V.y); }
inline VectorI3 Swizz_YZ(VectorI3 V){ return MkVectorI3(0, V.y, V.z); }
inline VectorI3 Swizz_Y_(VectorI3 V){ return MkVectorI3(0, V.y, 0); }
inline VectorI3 Swizz_ZX(VectorI3 V){ return MkVectorI3(0, V.z, V.x); }
inline VectorI3 Swizz_ZY(VectorI3 V){ return MkVectorI3(0, V.z, V.y); }
inline VectorI3 Swizz_ZZ(VectorI3 V){ return MkVectorI3(0, V.z, V.z); }
inline VectorI3 Swizz_Z_(VectorI3 V){ return MkVectorI3(0, V.z, 0); }
inline VectorI3 Swizz__X(VectorI3 V){ return MkVectorI3(0, 0, V.x); }
inline VectorI3 Swizz__Y(VectorI3 V){ return MkVectorI3(0, 0, V.y); }
inline VectorI3 Swizz__Z(VectorI3 V){ return MkVectorI3(0, 0, V.z); }
inline VectorI4 SwizzXXXX(VectorI3 V){ return MkVectorI4(V.x, V.x, V.x, V.x); }
inline VectorI4 SwizzXXXY(VectorI3 V){ return MkVectorI4(V.x, V.x, V.x, V.y); }
inline VectorI4 SwizzXXXZ(VectorI3 V){ return MkVectorI4(V.x, V.x, V.x, V.z); }
inline VectorI4 SwizzXXX_(VectorI3 V){ return MkVectorI4(V.x, V.x, V.x, 0); }
inline VectorI4 SwizzXXYX(VectorI3 V){ return MkVectorI4(V.x, V.x, V.y, V.x); }
inline VectorI4 SwizzXXYY(VectorI3 V){ return MkVectorI4(V.x, V.x, V.y, V.y); }
inline VectorI4 SwizzXXYZ(VectorI3 V){ return MkVectorI4(V.x, V.x, V.y, V.z); }
inline VectorI4 SwizzXXY_(VectorI3 V){ return MkVectorI4(V.x, V.x, V.y, 0); }
inline VectorI4 SwizzXXZX(VectorI3 V){ return MkVectorI4(V.x, V.x, V.z, V.x); }
inline VectorI4 SwizzXXZY(VectorI3 V){ return MkVectorI4(V.x, V.x, V.z, V.y); }
inline VectorI4 SwizzXXZZ(VectorI3 V){ return MkVectorI4(V.x, V.x, V.z, V.z); }
inline VectorI4 SwizzXXZ_(VectorI3 V){ return MkVectorI4(V.x, V.x, V.z, 0); }
inline VectorI4 SwizzXX_X(VectorI3 V){ return MkVectorI4(V.x, V.x, 0, V.x); }
inline VectorI4 SwizzXX_Y(VectorI3 V){ return MkVectorI4(V.x, V.x, 0, V.y); }
inline VectorI4 SwizzXX_Z(VectorI3 V){ return MkVectorI4(V.x, V.x, 0, V.z); }
inline VectorI4 SwizzXX__(VectorI3 V){ return MkVectorI4(V.x, V.x, 0, 0); }
inline VectorI4 SwizzXYXX(VectorI3 V){ return MkVectorI4(V.x, V.y, V.x, V.x); }
inline VectorI4 SwizzXYXY(VectorI3 V){ return MkVectorI4(V.x, V.y, V.x, V.y); }
inline VectorI4 SwizzXYXZ(VectorI3 V){ return MkVectorI4(V.x, V.y, V.x, V.z); }
inline VectorI4 SwizzXYX_(VectorI3 V){ return MkVectorI4(V.x, V.y, V.x, 0); }
inline VectorI4 SwizzXYYX(VectorI3 V){ return MkVectorI4(V.x, V.y, V.y, V.x); }
inline VectorI4 SwizzXYYY(VectorI3 V){ return MkVectorI4(V.x, V.y, V.y, V.y); }
inline VectorI4 SwizzXYYZ(VectorI3 V){ return MkVectorI4(V.x, V.y, V.y, V.z); }
inline VectorI4 SwizzXYY_(VectorI3 V){ return MkVectorI4(V.x, V.y, V.y, 0); }
inline VectorI4 SwizzXYZX(VectorI3 V){ return MkVectorI4(V.x, V.y, V.z, V.x); }
inline VectorI4 SwizzXYZY(VectorI3 V){ return MkVectorI4(V.x, V.y, V.z, V.y); }
inline VectorI4 SwizzXYZZ(VectorI3 V){ return MkVectorI4(V.x, V.y, V.z, V.z); }
inline VectorI4 SwizzXYZ_(VectorI3 V){ return MkVectorI4(V.x, V.y, V.z, 0); }
inline VectorI4 SwizzXY_X(VectorI3 V){ return MkVectorI4(V.x, V.y, 0, V.x); }
inline VectorI4 SwizzXY_Y(VectorI3 V){ return MkVectorI4(V.x, V.y, 0, V.y); }
inline VectorI4 SwizzXY_Z(VectorI3 V){ return MkVectorI4(V.x, V.y, 0, V.z); }
inline VectorI4 SwizzXY__(VectorI3 V){ return MkVectorI4(V.x, V.y, 0, 0); }
inline VectorI4 SwizzXZXX(VectorI3 V){ return MkVectorI4(V.x, V.z, V.x, V.x); }
inline VectorI4 SwizzXZXY(VectorI3 V){ return MkVectorI4(V.x, V.z, V.x, V.y); }
inline VectorI4 SwizzXZXZ(VectorI3 V){ return MkVectorI4(V.x, V.z, V.x, V.z); }
inline VectorI4 SwizzXZX_(VectorI3 V){ return MkVectorI4(V.x, V.z, V.x, 0); }
inline VectorI4 SwizzXZYX(VectorI3 V){ return MkVectorI4(V.x, V.z, V.y, V.x); }
inline VectorI4 SwizzXZYY(VectorI3 V){ return MkVectorI4(V.x, V.z, V.y, V.y); }
inline VectorI4 SwizzXZYZ(VectorI3 V){ return MkVectorI4(V.x, V.z, V.y, V.z); }
inline VectorI4 SwizzXZY_(VectorI3 V){ return MkVectorI4(V.x, V.z, V.y, 0); }
inline VectorI4 SwizzXZZX(VectorI3 V){ return MkVectorI4(V.x, V.z, V.z, V.x); }
inline VectorI4 SwizzXZZY(VectorI3 V){ return MkVectorI4(V.x, V.z, V.z, V.y); }
inline VectorI4 SwizzXZZZ(VectorI3 V){ return MkVectorI4(V.x, V.z, V.z, V.z); }
inline VectorI4 SwizzXZZ_(VectorI3 V){ return MkVectorI4(V.x, V.z, V.z, 0); }
inline VectorI4 SwizzXZ_X(VectorI3 V){ return MkVectorI4(V.x, V.z, 0, V.x); }
inline VectorI4 SwizzXZ_Y(VectorI3 V){ return MkVectorI4(V.x, V.z, 0, V.y); }
inline VectorI4 SwizzXZ_Z(VectorI3 V){ return MkVectorI4(V.x, V.z, 0, V.z); }
inline VectorI4 SwizzXZ__(VectorI3 V){ return MkVectorI4(V.x, V.z, 0, 0); }
inline VectorI4 SwizzX_XX(VectorI3 V){ return MkVectorI4(V.x, 0, V.x, V.x); }
inline VectorI4 SwizzX_XY(VectorI3 V){ return MkVectorI4(V.x, 0, V.x, V.y); }
inline VectorI4 SwizzX_XZ(VectorI3 V){ return MkVectorI4(V.x, 0, V.x, V.z); }
inline VectorI4 SwizzX_X_(VectorI3 V){ return MkVectorI4(V.x, 0, V.x, 0); }
inline VectorI4 SwizzX_YX(VectorI3 V){ return MkVectorI4(V.x, 0, V.y, V.x); }
inline VectorI4 SwizzX_YY(VectorI3 V){ return MkVectorI4(V.x, 0, V.y, V.y); }
inline VectorI4 SwizzX_YZ(VectorI3 V){ return MkVectorI4(V.x, 0, V.y, V.z); }
inline VectorI4 SwizzX_Y_(VectorI3 V){ return MkVectorI4(V.x, 0, V.y, 0); }
inline VectorI4 SwizzX_ZX(VectorI3 V){ return MkVectorI4(V.x, 0, V.z, V.x); }
inline VectorI4 SwizzX_ZY(VectorI3 V){ return MkVectorI4(V.x, 0, V.z, V.y); }
inline VectorI4 SwizzX_ZZ(VectorI3 V){ return MkVectorI4(V.x, 0, V.z, V.z); }
inline VectorI4 SwizzX_Z_(VectorI3 V){ return MkVectorI4(V.x, 0, V.z, 0); }
inline VectorI4 SwizzX__X(VectorI3 V){ return MkVectorI4(V.x, 0, 0, V.x); }
inline VectorI4 SwizzX__Y(VectorI3 V){ return MkVectorI4(V.x, 0, 0, V.y); }
inline VectorI4 SwizzX__Z(VectorI3 V){ return MkVectorI4(V.x, 0, 0, V.z); }
inline VectorI4 SwizzX___(VectorI3 V){ return MkVectorI4(V.x, 0, 0, 0); }
inline VectorI4 SwizzYXXX(VectorI3 V){ return MkVectorI4(V.y, V.x, V.x, V.x); }
inline VectorI4 SwizzYXXY(VectorI3 V){ return MkVectorI4(V.y, V.x, V.x, V.y); }
inline VectorI4 SwizzYXXZ(VectorI3 V){ return MkVectorI4(V.y, V.x, V.x, V.z); }
inline VectorI4 SwizzYXX_(VectorI3 V){ return MkVectorI4(V.y, V.x, V.x, 0); }
inline VectorI4 SwizzYXYX(VectorI3 V){ return MkVectorI4(V.y, V.x, V.y, V.x); }
inline VectorI4 SwizzYXYY(VectorI3 V){ return MkVectorI4(V.y, V.x, V.y, V.y); }
inline VectorI4 SwizzYXYZ(VectorI3 V){ return MkVectorI4(V.y, V.x, V.y, V.z); }
inline VectorI4 SwizzYXY_(VectorI3 V){ return MkVectorI4(V.y, V.x, V.y, 0); }
inline VectorI4 SwizzYXZX(VectorI3 V){ return MkVectorI4(V.y, V.x, V.z, V.x); }
inline VectorI4 SwizzYXZY(VectorI3 V){ return MkVectorI4(V.y, V.x, V.z, V.y); }
inline VectorI4 SwizzYXZZ(VectorI3 V){ return MkVectorI4(V.y, V.x, V.z, V.z); }
inline VectorI4 SwizzYXZ_(VectorI3 V){ return MkVectorI4(V.y, V.x, V.z, 0); }
inline VectorI4 SwizzYX_X(VectorI3 V){ return MkVectorI4(V.y, V.x, 0, V.x); }
inline VectorI4 SwizzYX_Y(VectorI3 V){ return MkVectorI4(V.y, V.x, 0, V.y); }
inline VectorI4 SwizzYX_Z(VectorI3 V){ return MkVectorI4(V.y, V.x, 0, V.z); }
inline VectorI4 SwizzYX__(VectorI3 V){ return MkVectorI4(V.y, V.x, 0, 0); }
inline VectorI4 SwizzYYXX(VectorI3 V){ return MkVectorI4(V.y, V.y, V.x, V.x); }
inline VectorI4 SwizzYYXY(VectorI3 V){ return MkVectorI4(V.y, V.y, V.x, V.y); }
inline VectorI4 SwizzYYXZ(VectorI3 V){ return MkVectorI4(V.y, V.y, V.x, V.z); }
inline VectorI4 SwizzYYX_(VectorI3 V){ return MkVectorI4(V.y, V.y, V.x, 0); }
inline VectorI4 SwizzYYYX(VectorI3 V){ return MkVectorI4(V.y, V.y, V.y, V.x); }
inline VectorI4 SwizzYYYY(VectorI3 V){ return MkVectorI4(V.y, V.y, V.y, V.y); }
inline VectorI4 SwizzYYYZ(VectorI3 V){ return MkVectorI4(V.y, V.y, V.y, V.z); }
inline VectorI4 SwizzYYY_(VectorI3 V){ return MkVectorI4(V.y, V.y, V.y, 0); }
inline VectorI4 SwizzYYZX(VectorI3 V){ return MkVectorI4(V.y, V.y, V.z, V.x); }
inline VectorI4 SwizzYYZY(VectorI3 V){ return MkVectorI4(V.y, V.y, V.z, V.y); }
inline VectorI4 SwizzYYZZ(VectorI3 V){ return MkVectorI4(V.y, V.y, V.z, V.z); }
inline VectorI4 SwizzYYZ_(VectorI3 V){ return MkVectorI4(V.y, V.y, V.z, 0); }
inline VectorI4 SwizzYY_X(VectorI3 V){ return MkVectorI4(V.y, V.y, 0, V.x); }
inline VectorI4 SwizzYY_Y(VectorI3 V){ return MkVectorI4(V.y, V.y, 0, V.y); }
inline VectorI4 SwizzYY_Z(VectorI3 V){ return MkVectorI4(V.y, V.y, 0, V.z); }
inline VectorI4 SwizzYY__(VectorI3 V){ return MkVectorI4(V.y, V.y, 0, 0); }
inline VectorI4 SwizzYZXX(VectorI3 V){ return MkVectorI4(V.y, V.z, V.x, V.x); }
inline VectorI4 SwizzYZXY(VectorI3 V){ return MkVectorI4(V.y, V.z, V.x, V.y); }
inline VectorI4 SwizzYZXZ(VectorI3 V){ return MkVectorI4(V.y, V.z, V.x, V.z); }
inline VectorI4 SwizzYZX_(VectorI3 V){ return MkVectorI4(V.y, V.z, V.x, 0); }
inline VectorI4 SwizzYZYX(VectorI3 V){ return MkVectorI4(V.y, V.z, V.y, V.x); }
inline VectorI4 SwizzYZYY(VectorI3 V){ return MkVectorI4(V.y, V.z, V.y, V.y); }
inline VectorI4 SwizzYZYZ(VectorI3 V){ return MkVectorI4(V.y, V.z, V.y, V.z); }
inline VectorI4 SwizzYZY_(VectorI3 V){ return MkVectorI4(V.y, V.z, V.y, 0); }
inline VectorI4 SwizzYZZX(VectorI3 V){ return MkVectorI4(V.y, V.z, V.z, V.x); }
inline VectorI4 SwizzYZZY(VectorI3 V){ return MkVectorI4(V.y, V.z, V.z, V.y); }
inline VectorI4 SwizzYZZZ(VectorI3 V){ return MkVectorI4(V.y, V.z, V.z, V.z); }
inline VectorI4 SwizzYZZ_(VectorI3 V){ return MkVectorI4(V.y, V.z, V.z, 0); }
inline VectorI4 SwizzYZ_X(VectorI3 V){ return MkVectorI4(V.y, V.z, 0, V.x); }
inline VectorI4 SwizzYZ_Y(VectorI3 V){ return MkVectorI4(V.y, V.z, 0, V.y); }
inline VectorI4 SwizzYZ_Z(VectorI3 V){ return MkVectorI4(V.y, V.z, 0, V.z); }
inline VectorI4 SwizzYZ__(VectorI3 V){ return MkVectorI4(V.y, V.z, 0, 0); }
inline VectorI4 SwizzY_XX(VectorI3 V){ return MkVectorI4(V.y, 0, V.x, V.x); }
inline VectorI4 SwizzY_XY(VectorI3 V){ return MkVectorI4(V.y, 0, V.x, V.y); }
inline VectorI4 SwizzY_XZ(VectorI3 V){ return MkVectorI4(V.y, 0, V.x, V.z); }
inline VectorI4 SwizzY_X_(VectorI3 V){ return MkVectorI4(V.y, 0, V.x, 0); }
inline VectorI4 SwizzY_YX(VectorI3 V){ return MkVectorI4(V.y, 0, V.y, V.x); }
inline VectorI4 SwizzY_YY(VectorI3 V){ return MkVectorI4(V.y, 0, V.y, V.y); }
inline VectorI4 SwizzY_YZ(VectorI3 V){ return MkVectorI4(V.y, 0, V.y, V.z); }
inline VectorI4 SwizzY_Y_(VectorI3 V){ return MkVectorI4(V.y, 0, V.y, 0); }
inline VectorI4 SwizzY_ZX(VectorI3 V){ return MkVectorI4(V.y, 0, V.z, V.x); }
inline VectorI4 SwizzY_ZY(VectorI3 V){ return MkVectorI4(V.y, 0, V.z, V.y); }
inline VectorI4 SwizzY_ZZ(VectorI3 V){ return MkVectorI4(V.y, 0, V.z, V.z); }
inline VectorI4 SwizzY_Z_(VectorI3 V){ return MkVectorI4(V.y, 0, V.z, 0); }
inline VectorI4 SwizzY__X(VectorI3 V){ return MkVectorI4(V.y, 0, 0, V.x); }
inline VectorI4 SwizzY__Y(VectorI3 V){ return MkVectorI4(V.y, 0, 0, V.y); }
inline VectorI4 SwizzY__Z(VectorI3 V){ return MkVectorI4(V.y, 0, 0, V.z); }
inline VectorI4 SwizzY___(VectorI3 V){ return MkVectorI4(V.y, 0, 0, 0); }
inline VectorI4 SwizzZXXX(VectorI3 V){ return MkVectorI4(V.z, V.x, V.x, V.x); }
inline VectorI4 SwizzZXXY(VectorI3 V){ return MkVectorI4(V.z, V.x, V.x, V.y); }
inline VectorI4 SwizzZXXZ(VectorI3 V){ return MkVectorI4(V.z, V.x, V.x, V.z); }
inline VectorI4 SwizzZXX_(VectorI3 V){ return MkVectorI4(V.z, V.x, V.x, 0); }
inline VectorI4 SwizzZXYX(VectorI3 V){ return MkVectorI4(V.z, V.x, V.y, V.x); }
inline VectorI4 SwizzZXYY(VectorI3 V){ return MkVectorI4(V.z, V.x, V.y, V.y); }
inline VectorI4 SwizzZXYZ(VectorI3 V){ return MkVectorI4(V.z, V.x, V.y, V.z); }
inline VectorI4 SwizzZXY_(VectorI3 V){ return MkVectorI4(V.z, V.x, V.y, 0); }
inline VectorI4 SwizzZXZX(VectorI3 V){ return MkVectorI4(V.z, V.x, V.z, V.x); }
inline VectorI4 SwizzZXZY(VectorI3 V){ return MkVectorI4(V.z, V.x, V.z, V.y); }
inline VectorI4 SwizzZXZZ(VectorI3 V){ return MkVectorI4(V.z, V.x, V.z, V.z); }
inline VectorI4 SwizzZXZ_(VectorI3 V){ return MkVectorI4(V.z, V.x, V.z, 0); }
inline VectorI4 SwizzZX_X(VectorI3 V){ return MkVectorI4(V.z, V.x, 0, V.x); }
inline VectorI4 SwizzZX_Y(VectorI3 V){ return MkVectorI4(V.z, V.x, 0, V.y); }
inline VectorI4 SwizzZX_Z(VectorI3 V){ return MkVectorI4(V.z, V.x, 0, V.z); }
inline VectorI4 SwizzZX__(VectorI3 V){ return MkVectorI4(V.z, V.x, 0, 0); }
inline VectorI4 SwizzZYXX(VectorI3 V){ return MkVectorI4(V.z, V.y, V.x, V.x); }
inline VectorI4 SwizzZYXY(VectorI3 V){ return MkVectorI4(V.z, V.y, V.x, V.y); }
inline VectorI4 SwizzZYXZ(VectorI3 V){ return MkVectorI4(V.z, V.y, V.x, V.z); }
inline VectorI4 SwizzZYX_(VectorI3 V){ return MkVectorI4(V.z, V.y, V.x, 0); }
inline VectorI4 SwizzZYYX(VectorI3 V){ return MkVectorI4(V.z, V.y, V.y, V.x); }
inline VectorI4 SwizzZYYY(VectorI3 V){ return MkVectorI4(V.z, V.y, V.y, V.y); }
inline VectorI4 SwizzZYYZ(VectorI3 V){ return MkVectorI4(V.z, V.y, V.y, V.z); }
inline VectorI4 SwizzZYY_(VectorI3 V){ return MkVectorI4(V.z, V.y, V.y, 0); }
inline VectorI4 SwizzZYZX(VectorI3 V){ return MkVectorI4(V.z, V.y, V.z, V.x); }
inline VectorI4 SwizzZYZY(VectorI3 V){ return MkVectorI4(V.z, V.y, V.z, V.y); }
inline VectorI4 SwizzZYZZ(VectorI3 V){ return MkVectorI4(V.z, V.y, V.z, V.z); }
inline VectorI4 SwizzZYZ_(VectorI3 V){ return MkVectorI4(V.z, V.y, V.z, 0); }
inline VectorI4 SwizzZY_X(VectorI3 V){ return MkVectorI4(V.z, V.y, 0, V.x); }
inline VectorI4 SwizzZY_Y(VectorI3 V){ return MkVectorI4(V.z, V.y, 0, V.y); }
inline VectorI4 SwizzZY_Z(VectorI3 V){ return MkVectorI4(V.z, V.y, 0, V.z); }
inline VectorI4 SwizzZY__(VectorI3 V){ return MkVectorI4(V.z, V.y, 0, 0); }
inline VectorI4 SwizzZZXX(VectorI3 V){ return MkVectorI4(V.z, V.z, V.x, V.x); }
inline VectorI4 SwizzZZXY(VectorI3 V){ return MkVectorI4(V.z, V.z, V.x, V.y); }
inline VectorI4 SwizzZZXZ(VectorI3 V){ return MkVectorI4(V.z, V.z, V.x, V.z); }
inline VectorI4 SwizzZZX_(VectorI3 V){ return MkVectorI4(V.z, V.z, V.x, 0); }
inline VectorI4 SwizzZZYX(VectorI3 V){ return MkVectorI4(V.z, V.z, V.y, V.x); }
inline VectorI4 SwizzZZYY(VectorI3 V){ return MkVectorI4(V.z, V.z, V.y, V.y); }
inline VectorI4 SwizzZZYZ(VectorI3 V){ return MkVectorI4(V.z, V.z, V.y, V.z); }
inline VectorI4 SwizzZZY_(VectorI3 V){ return MkVectorI4(V.z, V.z, V.y, 0); }
inline VectorI4 SwizzZZZX(VectorI3 V){ return MkVectorI4(V.z, V.z, V.z, V.x); }
inline VectorI4 SwizzZZZY(VectorI3 V){ return MkVectorI4(V.z, V.z, V.z, V.y); }
inline VectorI4 SwizzZZZZ(VectorI3 V){ return MkVectorI4(V.z, V.z, V.z, V.z); }
inline VectorI4 SwizzZZZ_(VectorI3 V){ return MkVectorI4(V.z, V.z, V.z, 0); }
inline VectorI4 SwizzZZ_X(VectorI3 V){ return MkVectorI4(V.z, V.z, 0, V.x); }
inline VectorI4 SwizzZZ_Y(VectorI3 V){ return MkVectorI4(V.z, V.z, 0, V.y); }
inline VectorI4 SwizzZZ_Z(VectorI3 V){ return MkVectorI4(V.z, V.z, 0, V.z); }
inline VectorI4 SwizzZZ__(VectorI3 V){ return MkVectorI4(V.z, V.z, 0, 0); }
inline VectorI4 SwizzZ_XX(VectorI3 V){ return MkVectorI4(V.z, 0, V.x, V.x); }
inline VectorI4 SwizzZ_XY(VectorI3 V){ return MkVectorI4(V.z, 0, V.x, V.y); }
inline VectorI4 SwizzZ_XZ(VectorI3 V){ return MkVectorI4(V.z, 0, V.x, V.z); }
inline VectorI4 SwizzZ_X_(VectorI3 V){ return MkVectorI4(V.z, 0, V.x, 0); }
inline VectorI4 SwizzZ_YX(VectorI3 V){ return MkVectorI4(V.z, 0, V.y, V.x); }
inline VectorI4 SwizzZ_YY(VectorI3 V){ return MkVectorI4(V.z, 0, V.y, V.y); }
inline VectorI4 SwizzZ_YZ(VectorI3 V){ return MkVectorI4(V.z, 0, V.y, V.z); }
inline VectorI4 SwizzZ_Y_(VectorI3 V){ return MkVectorI4(V.z, 0, V.y, 0); }
inline VectorI4 SwizzZ_ZX(VectorI3 V){ return MkVectorI4(V.z, 0, V.z, V.x); }
inline VectorI4 SwizzZ_ZY(VectorI3 V){ return MkVectorI4(V.z, 0, V.z, V.y); }
inline VectorI4 SwizzZ_ZZ(VectorI3 V){ return MkVectorI4(V.z, 0, V.z, V.z); }
inline VectorI4 SwizzZ_Z_(VectorI3 V){ return MkVectorI4(V.z, 0, V.z, 0); }
inline VectorI4 SwizzZ__X(VectorI3 V){ return MkVectorI4(V.z, 0, 0, V.x); }
inline VectorI4 SwizzZ__Y(VectorI3 V){ return MkVectorI4(V.z, 0, 0, V.y); }
inline VectorI4 SwizzZ__Z(VectorI3 V){ return MkVectorI4(V.z, 0, 0, V.z); }
inline VectorI4 SwizzZ___(VectorI3 V){ return MkVectorI4(V.z, 0, 0, 0); }
inline VectorI4 Swizz_XXX(VectorI3 V){ return MkVectorI4(0, V.x, V.x, V.x); }
inline VectorI4 Swizz_XXY(VectorI3 V){ return MkVectorI4(0, V.x, V.x, V.y); }
inline VectorI4 Swizz_XXZ(VectorI3 V){ return MkVectorI4(0, V.x, V.x, V.z); }
inline VectorI4 Swizz_XX_(VectorI3 V){ return MkVectorI4(0, V.x, V.x, 0); }
inline VectorI4 Swizz_XYX(VectorI3 V){ return MkVectorI4(0, V.x, V.y, V.x); }
inline VectorI4 Swizz_XYY(VectorI3 V){ return MkVectorI4(0, V.x, V.y, V.y); }
inline VectorI4 Swizz_XYZ(VectorI3 V){ return MkVectorI4(0, V.x, V.y, V.z); }
inline VectorI4 Swizz_XY_(VectorI3 V){ return MkVectorI4(0, V.x, V.y, 0); }
inline VectorI4 Swizz_XZX(VectorI3 V){ return MkVectorI4(0, V.x, V.z, V.x); }
inline VectorI4 Swizz_XZY(VectorI3 V){ return MkVectorI4(0, V.x, V.z, V.y); }
inline VectorI4 Swizz_XZZ(VectorI3 V){ return MkVectorI4(0, V.x, V.z, V.z); }
inline VectorI4 Swizz_XZ_(VectorI3 V){ return MkVectorI4(0, V.x, V.z, 0); }
inline VectorI4 Swizz_X_X(VectorI3 V){ return MkVectorI4(0, V.x, 0, V.x); }
inline VectorI4 Swizz_X_Y(VectorI3 V){ return MkVectorI4(0, V.x, 0, V.y); }
inline VectorI4 Swizz_X_Z(VectorI3 V){ return MkVectorI4(0, V.x, 0, V.z); }
inline VectorI4 Swizz_X__(VectorI3 V){ return MkVectorI4(0, V.x, 0, 0); }
inline VectorI4 Swizz_YXX(VectorI3 V){ return MkVectorI4(0, V.y, V.x, V.x); }
inline VectorI4 Swizz_YXY(VectorI3 V){ return MkVectorI4(0, V.y, V.x, V.y); }
inline VectorI4 Swizz_YXZ(VectorI3 V){ return MkVectorI4(0, V.y, V.x, V.z); }
inline VectorI4 Swizz_YX_(VectorI3 V){ return MkVectorI4(0, V.y, V.x, 0); }
inline VectorI4 Swizz_YYX(VectorI3 V){ return MkVectorI4(0, V.y, V.y, V.x); }
inline VectorI4 Swizz_YYY(VectorI3 V){ return MkVectorI4(0, V.y, V.y, V.y); }
inline VectorI4 Swizz_YYZ(VectorI3 V){ return MkVectorI4(0, V.y, V.y, V.z); }
inline VectorI4 Swizz_YY_(VectorI3 V){ return MkVectorI4(0, V.y, V.y, 0); }
inline VectorI4 Swizz_YZX(VectorI3 V){ return MkVectorI4(0, V.y, V.z, V.x); }
inline VectorI4 Swizz_YZY(VectorI3 V){ return MkVectorI4(0, V.y, V.z, V.y); }
inline VectorI4 Swizz_YZZ(VectorI3 V){ return MkVectorI4(0, V.y, V.z, V.z); }
inline VectorI4 Swizz_YZ_(VectorI3 V){ return MkVectorI4(0, V.y, V.z, 0); }
inline VectorI4 Swizz_Y_X(VectorI3 V){ return MkVectorI4(0, V.y, 0, V.x); }
inline VectorI4 Swizz_Y_Y(VectorI3 V){ return MkVectorI4(0, V.y, 0, V.y); }
inline VectorI4 Swizz_Y_Z(VectorI3 V){ return MkVectorI4(0, V.y, 0, V.z); }
inline VectorI4 Swizz_Y__(VectorI3 V){ return MkVectorI4(0, V.y, 0, 0); }
inline VectorI4 Swizz_ZXX(VectorI3 V){ return MkVectorI4(0, V.z, V.x, V.x); }
inline VectorI4 Swizz_ZXY(VectorI3 V){ return MkVectorI4(0, V.z, V.x, V.y); }
inline VectorI4 Swizz_ZXZ(VectorI3 V){ return MkVectorI4(0, V.z, V.x, V.z); }
inline VectorI4 Swizz_ZX_(VectorI3 V){ return MkVectorI4(0, V.z, V.x, 0); }
inline VectorI4 Swizz_ZYX(VectorI3 V){ return MkVectorI4(0, V.z, V.y, V.x); }
inline VectorI4 Swizz_ZYY(VectorI3 V){ return MkVectorI4(0, V.z, V.y, V.y); }
inline VectorI4 Swizz_ZYZ(VectorI3 V){ return MkVectorI4(0, V.z, V.y, V.z); }
inline VectorI4 Swizz_ZY_(VectorI3 V){ return MkVectorI4(0, V.z, V.y, 0); }
inline VectorI4 Swizz_ZZX(VectorI3 V){ return MkVectorI4(0, V.z, V.z, V.x); }
inline VectorI4 Swizz_ZZY(VectorI3 V){ return MkVectorI4(0, V.z, V.z, V.y); }
inline VectorI4 Swizz_ZZZ(VectorI3 V){ return MkVectorI4(0, V.z, V.z, V.z); }
inline VectorI4 Swizz_ZZ_(VectorI3 V){ return MkVectorI4(0, V.z, V.z, 0); }
inline VectorI4 Swizz_Z_X(VectorI3 V){ return MkVectorI4(0, V.z, 0, V.x); }
inline VectorI4 Swizz_Z_Y(VectorI3 V){ return MkVectorI4(0, V.z, 0, V.y); }
inline VectorI4 Swizz_Z_Z(VectorI3 V){ return MkVectorI4(0, V.z, 0, V.z); }
inline VectorI4 Swizz_Z__(VectorI3 V){ return MkVectorI4(0, V.z, 0, 0); }
inline VectorI4 Swizz__XX(VectorI3 V){ return MkVectorI4(0, 0, V.x, V.x); }
inline VectorI4 Swizz__XY(VectorI3 V){ return MkVectorI4(0, 0, V.x, V.y); }
inline VectorI4 Swizz__XZ(VectorI3 V){ return MkVectorI4(0, 0, V.x, V.z); }
inline VectorI4 Swizz__X_(VectorI3 V){ return MkVectorI4(0, 0, V.x, 0); }
inline VectorI4 Swizz__YX(VectorI3 V){ return MkVectorI4(0, 0, V.y, V.x); }
inline VectorI4 Swizz__YY(VectorI3 V){ return MkVectorI4(0, 0, V.y, V.y); }
inline VectorI4 Swizz__YZ(VectorI3 V){ return MkVectorI4(0, 0, V.y, V.z); }
inline VectorI4 Swizz__Y_(VectorI3 V){ return MkVectorI4(0, 0, V.y, 0); }
inline VectorI4 Swizz__ZX(VectorI3 V){ return MkVectorI4(0, 0, V.z, V.x); }
inline VectorI4 Swizz__ZY(VectorI3 V){ return MkVectorI4(0, 0, V.z, V.y); }
inline VectorI4 Swizz__ZZ(VectorI3 V){ return MkVectorI4(0, 0, V.z, V.z); }
inline VectorI4 Swizz__Z_(VectorI3 V){ return MkVectorI4(0, 0, V.z, 0); }
inline VectorI4 Swizz___X(VectorI3 V){ return MkVectorI4(0, 0, 0, V.x); }
inline VectorI4 Swizz___Y(VectorI3 V){ return MkVectorI4(0, 0, 0, V.y); }
inline VectorI4 Swizz___Z(VectorI3 V){ return MkVectorI4(0, 0, 0, V.z); }
inline VectorI2 SwizzXX(VectorI4 V){ return MkVectorI2(V.x, V.x); }
inline VectorI2 SwizzXY(VectorI4 V){ return MkVectorI2(V.x, V.y); }
inline VectorI2 SwizzXZ(VectorI4 V){ return MkVectorI2(V.x, V.z); }
inline VectorI2 SwizzXW(VectorI4 V){ return MkVectorI2(V.x, V.w); }
inline VectorI2 SwizzX_(VectorI4 V){ return MkVectorI2(V.x, 0); }
inline VectorI2 SwizzYX(VectorI4 V){ return MkVectorI2(V.y, V.x); }
inline VectorI2 SwizzYY(VectorI4 V){ return MkVectorI2(V.y, V.y); }
inline VectorI2 SwizzYZ(VectorI4 V){ return MkVectorI2(V.y, V.z); }
inline VectorI2 SwizzYW(VectorI4 V){ return MkVectorI2(V.y, V.w); }
inline VectorI2 SwizzY_(VectorI4 V){ return MkVectorI2(V.y, 0); }
inline VectorI2 SwizzZX(VectorI4 V){ return MkVectorI2(V.z, V.x); }
inline VectorI2 SwizzZY(VectorI4 V){ return MkVectorI2(V.z, V.y); }
inline VectorI2 SwizzZZ(VectorI4 V){ return MkVectorI2(V.z, V.z); }
inline VectorI2 SwizzZW(VectorI4 V){ return MkVectorI2(V.z, V.w); }
inline VectorI2 SwizzZ_(VectorI4 V){ return MkVectorI2(V.z, 0); }
inline VectorI2 SwizzWX(VectorI4 V){ return MkVectorI2(V.w, V.x); }
inline VectorI2 SwizzWY(VectorI4 V){ return MkVectorI2(V.w, V.y); }
inline VectorI2 SwizzWZ(VectorI4 V){ return MkVectorI2(V.w, V.z); }
inline VectorI2 SwizzWW(VectorI4 V){ return MkVectorI2(V.w, V.w); }
inline VectorI2 SwizzW_(VectorI4 V){ return MkVectorI2(V.w, 0); }
inline VectorI2 Swizz_X(VectorI4 V){ return MkVectorI2(0, V.x); }
inline VectorI2 Swizz_Y(VectorI4 V){ return MkVectorI2(0, V.y); }
inline VectorI2 Swizz_Z(VectorI4 V){ return MkVectorI2(0, V.z); }
inline VectorI2 Swizz_W(VectorI4 V){ return MkVectorI2(0, V.w); }
inline VectorI3 SwizzXXX(VectorI4 V){ return MkVectorI3(V.x, V.x, V.x); }
inline VectorI3 SwizzXXY(VectorI4 V){ return MkVectorI3(V.x, V.x, V.y); }
inline VectorI3 SwizzXXZ(VectorI4 V){ return MkVectorI3(V.x, V.x, V.z); }
inline VectorI3 SwizzXXW(VectorI4 V){ return MkVectorI3(V.x, V.x, V.w); }
inline VectorI3 SwizzXX_(VectorI4 V){ return MkVectorI3(V.x, V.x, 0); }
inline VectorI3 SwizzXYX(VectorI4 V){ return MkVectorI3(V.x, V.y, V.x); }
inline VectorI3 SwizzXYY(VectorI4 V){ return MkVectorI3(V.x, V.y, V.y); }
inline VectorI3 SwizzXYZ(VectorI4 V){ return MkVectorI3(V.x, V.y, V.z); }
inline VectorI3 SwizzXYW(VectorI4 V){ return MkVectorI3(V.x, V.y, V.w); }
inline VectorI3 SwizzXY_(VectorI4 V){ return MkVectorI3(V.x, V.y, 0); }
inline VectorI3 SwizzXZX(VectorI4 V){ return MkVectorI3(V.x, V.z, V.x); }
inline VectorI3 SwizzXZY(VectorI4 V){ return MkVectorI3(V.x, V.z, V.y); }
inline VectorI3 SwizzXZZ(VectorI4 V){ return MkVectorI3(V.x, V.z, V.z); }
inline VectorI3 SwizzXZW(VectorI4 V){ return MkVectorI3(V.x, V.z, V.w); }
inline VectorI3 SwizzXZ_(VectorI4 V){ return MkVectorI3(V.x, V.z, 0); }
inline VectorI3 SwizzXWX(VectorI4 V){ return MkVectorI3(V.x, V.w, V.x); }
inline VectorI3 SwizzXWY(VectorI4 V){ return MkVectorI3(V.x, V.w, V.y); }
inline VectorI3 SwizzXWZ(VectorI4 V){ return MkVectorI3(V.x, V.w, V.z); }
inline VectorI3 SwizzXWW(VectorI4 V){ return MkVectorI3(V.x, V.w, V.w); }
inline VectorI3 SwizzXW_(VectorI4 V){ return MkVectorI3(V.x, V.w, 0); }
inline VectorI3 SwizzX_X(VectorI4 V){ return MkVectorI3(V.x, 0, V.x); }
inline VectorI3 SwizzX_Y(VectorI4 V){ return MkVectorI3(V.x, 0, V.y); }
inline VectorI3 SwizzX_Z(VectorI4 V){ return MkVectorI3(V.x, 0, V.z); }
inline VectorI3 SwizzX_W(VectorI4 V){ return MkVectorI3(V.x, 0, V.w); }
inline VectorI3 SwizzX__(VectorI4 V){ return MkVectorI3(V.x, 0, 0); }
inline VectorI3 SwizzYXX(VectorI4 V){ return MkVectorI3(V.y, V.x, V.x); }
inline VectorI3 SwizzYXY(VectorI4 V){ return MkVectorI3(V.y, V.x, V.y); }
inline VectorI3 SwizzYXZ(VectorI4 V){ return MkVectorI3(V.y, V.x, V.z); }
inline VectorI3 SwizzYXW(VectorI4 V){ return MkVectorI3(V.y, V.x, V.w); }
inline VectorI3 SwizzYX_(VectorI4 V){ return MkVectorI3(V.y, V.x, 0); }
inline VectorI3 SwizzYYX(VectorI4 V){ return MkVectorI3(V.y, V.y, V.x); }
inline VectorI3 SwizzYYY(VectorI4 V){ return MkVectorI3(V.y, V.y, V.y); }
inline VectorI3 SwizzYYZ(VectorI4 V){ return MkVectorI3(V.y, V.y, V.z); }
inline VectorI3 SwizzYYW(VectorI4 V){ return MkVectorI3(V.y, V.y, V.w); }
inline VectorI3 SwizzYY_(VectorI4 V){ return MkVectorI3(V.y, V.y, 0); }
inline VectorI3 SwizzYZX(VectorI4 V){ return MkVectorI3(V.y, V.z, V.x); }
inline VectorI3 SwizzYZY(VectorI4 V){ return MkVectorI3(V.y, V.z, V.y); }
inline VectorI3 SwizzYZZ(VectorI4 V){ return MkVectorI3(V.y, V.z, V.z); }
inline VectorI3 SwizzYZW(VectorI4 V){ return MkVectorI3(V.y, V.z, V.w); }
inline VectorI3 SwizzYZ_(VectorI4 V){ return MkVectorI3(V.y, V.z, 0); }
inline VectorI3 SwizzYWX(VectorI4 V){ return MkVectorI3(V.y, V.w, V.x); }
inline VectorI3 SwizzYWY(VectorI4 V){ return MkVectorI3(V.y, V.w, V.y); }
inline VectorI3 SwizzYWZ(VectorI4 V){ return MkVectorI3(V.y, V.w, V.z); }
inline VectorI3 SwizzYWW(VectorI4 V){ return MkVectorI3(V.y, V.w, V.w); }
inline VectorI3 SwizzYW_(VectorI4 V){ return MkVectorI3(V.y, V.w, 0); }
inline VectorI3 SwizzY_X(VectorI4 V){ return MkVectorI3(V.y, 0, V.x); }
inline VectorI3 SwizzY_Y(VectorI4 V){ return MkVectorI3(V.y, 0, V.y); }
inline VectorI3 SwizzY_Z(VectorI4 V){ return MkVectorI3(V.y, 0, V.z); }
inline VectorI3 SwizzY_W(VectorI4 V){ return MkVectorI3(V.y, 0, V.w); }
inline VectorI3 SwizzY__(VectorI4 V){ return MkVectorI3(V.y, 0, 0); }
inline VectorI3 SwizzZXX(VectorI4 V){ return MkVectorI3(V.z, V.x, V.x); }
inline VectorI3 SwizzZXY(VectorI4 V){ return MkVectorI3(V.z, V.x, V.y); }
inline VectorI3 SwizzZXZ(VectorI4 V){ return MkVectorI3(V.z, V.x, V.z); }
inline VectorI3 SwizzZXW(VectorI4 V){ return MkVectorI3(V.z, V.x, V.w); }
inline VectorI3 SwizzZX_(VectorI4 V){ return MkVectorI3(V.z, V.x, 0); }
inline VectorI3 SwizzZYX(VectorI4 V){ return MkVectorI3(V.z, V.y, V.x); }
inline VectorI3 SwizzZYY(VectorI4 V){ return MkVectorI3(V.z, V.y, V.y); }
inline VectorI3 SwizzZYZ(VectorI4 V){ return MkVectorI3(V.z, V.y, V.z); }
inline VectorI3 SwizzZYW(VectorI4 V){ return MkVectorI3(V.z, V.y, V.w); }
inline VectorI3 SwizzZY_(VectorI4 V){ return MkVectorI3(V.z, V.y, 0); }
inline VectorI3 SwizzZZX(VectorI4 V){ return MkVectorI3(V.z, V.z, V.x); }
inline VectorI3 SwizzZZY(VectorI4 V){ return MkVectorI3(V.z, V.z, V.y); }
inline VectorI3 SwizzZZZ(VectorI4 V){ return MkVectorI3(V.z, V.z, V.z); }
inline VectorI3 SwizzZZW(VectorI4 V){ return MkVectorI3(V.z, V.z, V.w); }
inline VectorI3 SwizzZZ_(VectorI4 V){ return MkVectorI3(V.z, V.z, 0); }
inline VectorI3 SwizzZWX(VectorI4 V){ return MkVectorI3(V.z, V.w, V.x); }
inline VectorI3 SwizzZWY(VectorI4 V){ return MkVectorI3(V.z, V.w, V.y); }
inline VectorI3 SwizzZWZ(VectorI4 V){ return MkVectorI3(V.z, V.w, V.z); }
inline VectorI3 SwizzZWW(VectorI4 V){ return MkVectorI3(V.z, V.w, V.w); }
inline VectorI3 SwizzZW_(VectorI4 V){ return MkVectorI3(V.z, V.w, 0); }
inline VectorI3 SwizzZ_X(VectorI4 V){ return MkVectorI3(V.z, 0, V.x); }
inline VectorI3 SwizzZ_Y(VectorI4 V){ return MkVectorI3(V.z, 0, V.y); }
inline VectorI3 SwizzZ_Z(VectorI4 V){ return MkVectorI3(V.z, 0, V.z); }
inline VectorI3 SwizzZ_W(VectorI4 V){ return MkVectorI3(V.z, 0, V.w); }
inline VectorI3 SwizzZ__(VectorI4 V){ return MkVectorI3(V.z, 0, 0); }
inline VectorI3 SwizzWXX(VectorI4 V){ return MkVectorI3(V.w, V.x, V.x); }
inline VectorI3 SwizzWXY(VectorI4 V){ return MkVectorI3(V.w, V.x, V.y); }
inline VectorI3 SwizzWXZ(VectorI4 V){ return MkVectorI3(V.w, V.x, V.z); }
inline VectorI3 SwizzWXW(VectorI4 V){ return MkVectorI3(V.w, V.x, V.w); }
inline VectorI3 SwizzWX_(VectorI4 V){ return MkVectorI3(V.w, V.x, 0); }
inline VectorI3 SwizzWYX(VectorI4 V){ return MkVectorI3(V.w, V.y, V.x); }
inline VectorI3 SwizzWYY(VectorI4 V){ return MkVectorI3(V.w, V.y, V.y); }
inline VectorI3 SwizzWYZ(VectorI4 V){ return MkVectorI3(V.w, V.y, V.z); }
inline VectorI3 SwizzWYW(VectorI4 V){ return MkVectorI3(V.w, V.y, V.w); }
inline VectorI3 SwizzWY_(VectorI4 V){ return MkVectorI3(V.w, V.y, 0); }
inline VectorI3 SwizzWZX(VectorI4 V){ return MkVectorI3(V.w, V.z, V.x); }
inline VectorI3 SwizzWZY(VectorI4 V){ return MkVectorI3(V.w, V.z, V.y); }
inline VectorI3 SwizzWZZ(VectorI4 V){ return MkVectorI3(V.w, V.z, V.z); }
inline VectorI3 SwizzWZW(VectorI4 V){ return MkVectorI3(V.w, V.z, V.w); }
inline VectorI3 SwizzWZ_(VectorI4 V){ return MkVectorI3(V.w, V.z, 0); }
inline VectorI3 SwizzWWX(VectorI4 V){ return MkVectorI3(V.w, V.w, V.x); }
inline VectorI3 SwizzWWY(VectorI4 V){ return MkVectorI3(V.w, V.w, V.y); }
inline VectorI3 SwizzWWZ(VectorI4 V){ return MkVectorI3(V.w, V.w, V.z); }
inline VectorI3 SwizzWWW(VectorI4 V){ return MkVectorI3(V.w, V.w, V.w); }
inline VectorI3 SwizzWW_(VectorI4 V){ return MkVectorI3(V.w, V.w, 0); }
inline VectorI3 SwizzW_X(VectorI4 V){ return MkVectorI3(V.w, 0, V.x); }
inline VectorI3 SwizzW_Y(VectorI4 V){ return MkVectorI3(V.w, 0, V.y); }
inline VectorI3 SwizzW_Z(VectorI4 V){ return MkVectorI3(V.w, 0, V.z); }
inline VectorI3 SwizzW_W(VectorI4 V){ return MkVectorI3(V.w, 0, V.w); }
inline VectorI3 SwizzW__(VectorI4 V){ return MkVectorI3(V.w, 0, 0); }
inline VectorI3 Swizz_XX(VectorI4 V){ return MkVectorI3(0, V.x, V.x); }
inline VectorI3 Swizz_XY(VectorI4 V){ return MkVectorI3(0, V.x, V.y); }
inline VectorI3 Swizz_XZ(VectorI4 V){ return MkVectorI3(0, V.x, V.z); }
inline VectorI3 Swizz_XW(VectorI4 V){ return MkVectorI3(0, V.x, V.w); }
inline VectorI3 Swizz_X_(VectorI4 V){ return MkVectorI3(0, V.x, 0); }
inline VectorI3 Swizz_YX(VectorI4 V){ return MkVectorI3(0, V.y, V.x); }
inline VectorI3 Swizz_YY(VectorI4 V){ return MkVectorI3(0, V.y, V.y); }
inline VectorI3 Swizz_YZ(VectorI4 V){ return MkVectorI3(0, V.y, V.z); }
inline VectorI3 Swizz_YW(VectorI4 V){ return MkVectorI3(0, V.y, V.w); }
inline VectorI3 Swizz_Y_(VectorI4 V){ return MkVectorI3(0, V.y, 0); }
inline VectorI3 Swizz_ZX(VectorI4 V){ return MkVectorI3(0, V.z, V.x); }
inline VectorI3 Swizz_ZY(VectorI4 V){ return MkVectorI3(0, V.z, V.y); }
inline VectorI3 Swizz_ZZ(VectorI4 V){ return MkVectorI3(0, V.z, V.z); }
inline VectorI3 Swizz_ZW(VectorI4 V){ return MkVectorI3(0, V.z, V.w); }
inline VectorI3 Swizz_Z_(VectorI4 V){ return MkVectorI3(0, V.z, 0); }
inline VectorI3 Swizz_WX(VectorI4 V){ return MkVectorI3(0, V.w, V.x); }
inline VectorI3 Swizz_WY(VectorI4 V){ return MkVectorI3(0, V.w, V.y); }
inline VectorI3 Swizz_WZ(VectorI4 V){ return MkVectorI3(0, V.w, V.z); }
inline VectorI3 Swizz_WW(VectorI4 V){ return MkVectorI3(0, V.w, V.w); }
inline VectorI3 Swizz_W_(VectorI4 V){ return MkVectorI3(0, V.w, 0); }
inline VectorI3 Swizz__X(VectorI4 V){ return MkVectorI3(0, 0, V.x); }
inline VectorI3 Swizz__Y(VectorI4 V){ return MkVectorI3(0, 0, V.y); }
inline VectorI3 Swizz__Z(VectorI4 V){ return MkVectorI3(0, 0, V.z); }
inline VectorI3 Swizz__W(VectorI4 V){ return MkVectorI3(0, 0, V.w); }
inline VectorI4 SwizzXXXX(VectorI4 V){ return MkVectorI4(V.x, V.x, V.x, V.x); }
inline VectorI4 SwizzXXXY(VectorI4 V){ return MkVectorI4(V.x, V.x, V.x, V.y); }
inline VectorI4 SwizzXXXZ(VectorI4 V){ return MkVectorI4(V.x, V.x, V.x, V.z); }
inline VectorI4 SwizzXXXW(VectorI4 V){ return MkVectorI4(V.x, V.x, V.x, V.w); }
inline VectorI4 SwizzXXX_(VectorI4 V){ return MkVectorI4(V.x, V.x, V.x, 0); }
inline VectorI4 SwizzXXYX(VectorI4 V){ return MkVectorI4(V.x, V.x, V.y, V.x); }
inline VectorI4 SwizzXXYY(VectorI4 V){ return MkVectorI4(V.x, V.x, V.y, V.y); }
inline VectorI4 SwizzXXYZ(VectorI4 V){ return MkVectorI4(V.x, V.x, V.y, V.z); }
inline VectorI4 SwizzXXYW(VectorI4 V){ return MkVectorI4(V.x, V.x, V.y, V.w); }
inline VectorI4 SwizzXXY_(VectorI4 V){ return MkVectorI4(V.x, V.x, V.y, 0); }
inline VectorI4 SwizzXXZX(VectorI4 V){ return MkVectorI4(V.x, V.x, V.z, V.x); }
inline VectorI4 SwizzXXZY(VectorI4 V){ return MkVectorI4(V.x, V.x, V.z, V.y); }
inline VectorI4 SwizzXXZZ(VectorI4 V){ return MkVectorI4(V.x, V.x, V.z, V.z); }
inline VectorI4 SwizzXXZW(VectorI4 V){ return MkVectorI4(V.x, V.x, V.z, V.w); }
inline VectorI4 SwizzXXZ_(VectorI4 V){ return MkVectorI4(V.x, V.x, V.z, 0); }
inline VectorI4 SwizzXXWX(VectorI4 V){ return MkVectorI4(V.x, V.x, V.w, V.x); }
inline VectorI4 SwizzXXWY(VectorI4 V){ return MkVectorI4(V.x, V.x, V.w, V.y); }
inline VectorI4 SwizzXXWZ(VectorI4 V){ return MkVectorI4(V.x, V.x, V.w, V.z); }
inline VectorI4 SwizzXXWW(VectorI4 V){ return MkVectorI4(V.x, V.x, V.w, V.w); }
inline VectorI4 SwizzXXW_(VectorI4 V){ return MkVectorI4(V.x, V.x, V.w, 0); }
inline VectorI4 SwizzXX_X(VectorI4 V){ return MkVectorI4(V.x, V.x, 0, V.x); }
inline VectorI4 SwizzXX_Y(VectorI4 V){ return MkVectorI4(V.x, V.x, 0, V.y); }
inline VectorI4 SwizzXX_Z(VectorI4 V){ return MkVectorI4(V.x, V.x, 0, V.z); }
inline VectorI4 SwizzXX_W(VectorI4 V){ return MkVectorI4(V.x, V.x, 0, V.w); }
inline VectorI4 SwizzXX__(VectorI4 V){ return MkVectorI4(V.x, V.x, 0, 0); }
inline VectorI4 SwizzXYXX(VectorI4 V){ return MkVectorI4(V.x, V.y, V.x, V.x); }
inline VectorI4 SwizzXYXY(VectorI4 V){ return MkVectorI4(V.x, V.y, V.x, V.y); }
inline VectorI4 SwizzXYXZ(VectorI4 V){ return MkVectorI4(V.x, V.y, V.x, V.z); }
inline VectorI4 SwizzXYXW(VectorI4 V){ return MkVectorI4(V.x, V.y, V.x, V.w); }
inline VectorI4 SwizzXYX_(VectorI4 V){ return MkVectorI4(V.x, V.y, V.x, 0); }
inline VectorI4 SwizzXYYX(VectorI4 V){ return MkVectorI4(V.x, V.y, V.y, V.x); }
inline VectorI4 SwizzXYYY(VectorI4 V){ return MkVectorI4(V.x, V.y, V.y, V.y); }
inline VectorI4 SwizzXYYZ(VectorI4 V){ return MkVectorI4(V.x, V.y, V.y, V.z); }
inline VectorI4 SwizzXYYW(VectorI4 V){ return MkVectorI4(V.x, V.y, V.y, V.w); }
inline VectorI4 SwizzXYY_(VectorI4 V){ return MkVectorI4(V.x, V.y, V.y, 0); }
inline VectorI4 SwizzXYZX(VectorI4 V){ return MkVectorI4(V.x, V.y, V.z, V.x); }
inline VectorI4 SwizzXYZY(VectorI4 V){ return MkVectorI4(V.x, V.y, V.z, V.y); }
inline VectorI4 SwizzXYZZ(VectorI4 V){ return MkVectorI4(V.x, V.y, V.z, V.z); }
inline VectorI4 SwizzXYZW(VectorI4 V){ return MkVectorI4(V.x, V.y, V.z, V.w); }
inline VectorI4 SwizzXYZ_(VectorI4 V){ return MkVectorI4(V.x, V.y, V.z, 0); }
inline VectorI4 SwizzXYWX(VectorI4 V){ return MkVectorI4(V.x, V.y, V.w, V.x); }
inline VectorI4 SwizzXYWY(VectorI4 V){ return MkVectorI4(V.x, V.y, V.w, V.y); }
inline VectorI4 SwizzXYWZ(VectorI4 V){ return MkVectorI4(V.x, V.y, V.w, V.z); }
inline VectorI4 SwizzXYWW(VectorI4 V){ return MkVectorI4(V.x, V.y, V.w, V.w); }
inline VectorI4 SwizzXYW_(VectorI4 V){ return MkVectorI4(V.x, V.y, V.w, 0); }
inline VectorI4 SwizzXY_X(VectorI4 V){ return MkVectorI4(V.x, V.y, 0, V.x); }
inline VectorI4 SwizzXY_Y(VectorI4 V){ return MkVectorI4(V.x, V.y, 0, V.y); }
inline VectorI4 SwizzXY_Z(VectorI4 V){ return MkVectorI4(V.x, V.y, 0, V.z); }
inline VectorI4 SwizzXY_W(VectorI4 V){ return MkVectorI4(V.x, V.y, 0, V.w); }
inline VectorI4 SwizzXY__(VectorI4 V){ return MkVectorI4(V.x, V.y, 0, 0); }
inline VectorI4 SwizzXZXX(VectorI4 V){ return MkVectorI4(V.x, V.z, V.x, V.x); }
inline VectorI4 SwizzXZXY(VectorI4 V){ return MkVectorI4(V.x, V.z, V.x, V.y); }
inline VectorI4 SwizzXZXZ(VectorI4 V){ return MkVectorI4(V.x, V.z, V.x, V.z); }
inline VectorI4 SwizzXZXW(VectorI4 V){ return MkVectorI4(V.x, V.z, V.x, V.w); }
inline VectorI4 SwizzXZX_(VectorI4 V){ return MkVectorI4(V.x, V.z, V.x, 0); }
inline VectorI4 SwizzXZYX(VectorI4 V){ return MkVectorI4(V.x, V.z, V.y, V.x); }
inline VectorI4 SwizzXZYY(VectorI4 V){ return MkVectorI4(V.x, V.z, V.y, V.y); }
inline VectorI4 SwizzXZYZ(VectorI4 V){ return MkVectorI4(V.x, V.z, V.y, V.z); }
inline VectorI4 SwizzXZYW(VectorI4 V){ return MkVectorI4(V.x, V.z, V.y, V.w); }
inline VectorI4 SwizzXZY_(VectorI4 V){ return MkVectorI4(V.x, V.z, V.y, 0); }
inline VectorI4 SwizzXZZX(VectorI4 V){ return MkVectorI4(V.x, V.z, V.z, V.x); }
inline VectorI4 SwizzXZZY(VectorI4 V){ return MkVectorI4(V.x, V.z, V.z, V.y); }
inline VectorI4 SwizzXZZZ(VectorI4 V){ return MkVectorI4(V.x, V.z, V.z, V.z); }
inline VectorI4 SwizzXZZW(VectorI4 V){ return MkVectorI4(V.x, V.z, V.z, V.w); }
inline VectorI4 SwizzXZZ_(VectorI4 V){ return MkVectorI4(V.x, V.z, V.z, 0); }
inline VectorI4 SwizzXZWX(VectorI4 V){ return MkVectorI4(V.x, V.z, V.w, V.x); }
inline VectorI4 SwizzXZWY(VectorI4 V){ return MkVectorI4(V.x, V.z, V.w, V.y); }
inline VectorI4 SwizzXZWZ(VectorI4 V){ return MkVectorI4(V.x, V.z, V.w, V.z); }
inline VectorI4 SwizzXZWW(VectorI4 V){ return MkVectorI4(V.x, V.z, V.w, V.w); }
inline VectorI4 SwizzXZW_(VectorI4 V){ return MkVectorI4(V.x, V.z, V.w, 0); }
inline VectorI4 SwizzXZ_X(VectorI4 V){ return MkVectorI4(V.x, V.z, 0, V.x); }
inline VectorI4 SwizzXZ_Y(VectorI4 V){ return MkVectorI4(V.x, V.z, 0, V.y); }
inline VectorI4 SwizzXZ_Z(VectorI4 V){ return MkVectorI4(V.x, V.z, 0, V.z); }
inline VectorI4 SwizzXZ_W(VectorI4 V){ return MkVectorI4(V.x, V.z, 0, V.w); }
inline VectorI4 SwizzXZ__(VectorI4 V){ return MkVectorI4(V.x, V.z, 0, 0); }
inline VectorI4 SwizzXWXX(VectorI4 V){ return MkVectorI4(V.x, V.w, V.x, V.x); }
inline VectorI4 SwizzXWXY(VectorI4 V){ return MkVectorI4(V.x, V.w, V.x, V.y); }
inline VectorI4 SwizzXWXZ(VectorI4 V){ return MkVectorI4(V.x, V.w, V.x, V.z); }
inline VectorI4 SwizzXWXW(VectorI4 V){ return MkVectorI4(V.x, V.w, V.x, V.w); }
inline VectorI4 SwizzXWX_(VectorI4 V){ return MkVectorI4(V.x, V.w, V.x, 0); }
inline VectorI4 SwizzXWYX(VectorI4 V){ return MkVectorI4(V.x, V.w, V.y, V.x); }
inline VectorI4 SwizzXWYY(VectorI4 V){ return MkVectorI4(V.x, V.w, V.y, V.y); }
inline VectorI4 SwizzXWYZ(VectorI4 V){ return MkVectorI4(V.x, V.w, V.y, V.z); }
inline VectorI4 SwizzXWYW(VectorI4 V){ return MkVectorI4(V.x, V.w, V.y, V.w); }
inline VectorI4 SwizzXWY_(VectorI4 V){ return MkVectorI4(V.x, V.w, V.y, 0); }
inline VectorI4 SwizzXWZX(VectorI4 V){ return MkVectorI4(V.x, V.w, V.z, V.x); }
inline VectorI4 SwizzXWZY(VectorI4 V){ return MkVectorI4(V.x, V.w, V.z, V.y); }
inline VectorI4 SwizzXWZZ(VectorI4 V){ return MkVectorI4(V.x, V.w, V.z, V.z); }
inline VectorI4 SwizzXWZW(VectorI4 V){ return MkVectorI4(V.x, V.w, V.z, V.w); }
inline VectorI4 SwizzXWZ_(VectorI4 V){ return MkVectorI4(V.x, V.w, V.z, 0); }
inline VectorI4 SwizzXWWX(VectorI4 V){ return MkVectorI4(V.x, V.w, V.w, V.x); }
inline VectorI4 SwizzXWWY(VectorI4 V){ return MkVectorI4(V.x, V.w, V.w, V.y); }
inline VectorI4 SwizzXWWZ(VectorI4 V){ return MkVectorI4(V.x, V.w, V.w, V.z); }
inline VectorI4 SwizzXWWW(VectorI4 V){ return MkVectorI4(V.x, V.w, V.w, V.w); }
inline VectorI4 SwizzXWW_(VectorI4 V){ return MkVectorI4(V.x, V.w, V.w, 0); }
inline VectorI4 SwizzXW_X(VectorI4 V){ return MkVectorI4(V.x, V.w, 0, V.x); }
inline VectorI4 SwizzXW_Y(VectorI4 V){ return MkVectorI4(V.x, V.w, 0, V.y); }
inline VectorI4 SwizzXW_Z(VectorI4 V){ return MkVectorI4(V.x, V.w, 0, V.z); }
inline VectorI4 SwizzXW_W(VectorI4 V){ return MkVectorI4(V.x, V.w, 0, V.w); }
inline VectorI4 SwizzXW__(VectorI4 V){ return MkVectorI4(V.x, V.w, 0, 0); }
inline VectorI4 SwizzX_XX(VectorI4 V){ return MkVectorI4(V.x, 0, V.x, V.x); }
inline VectorI4 SwizzX_XY(VectorI4 V){ return MkVectorI4(V.x, 0, V.x, V.y); }
inline VectorI4 SwizzX_XZ(VectorI4 V){ return MkVectorI4(V.x, 0, V.x, V.z); }
inline VectorI4 SwizzX_XW(VectorI4 V){ return MkVectorI4(V.x, 0, V.x, V.w); }
inline VectorI4 SwizzX_X_(VectorI4 V){ return MkVectorI4(V.x, 0, V.x, 0); }
inline VectorI4 SwizzX_YX(VectorI4 V){ return MkVectorI4(V.x, 0, V.y, V.x); }
inline VectorI4 SwizzX_YY(VectorI4 V){ return MkVectorI4(V.x, 0, V.y, V.y); }
inline VectorI4 SwizzX_YZ(VectorI4 V){ return MkVectorI4(V.x, 0, V.y, V.z); }
inline VectorI4 SwizzX_YW(VectorI4 V){ return MkVectorI4(V.x, 0, V.y, V.w); }
inline VectorI4 SwizzX_Y_(VectorI4 V){ return MkVectorI4(V.x, 0, V.y, 0); }
inline VectorI4 SwizzX_ZX(VectorI4 V){ return MkVectorI4(V.x, 0, V.z, V.x); }
inline VectorI4 SwizzX_ZY(VectorI4 V){ return MkVectorI4(V.x, 0, V.z, V.y); }
inline VectorI4 SwizzX_ZZ(VectorI4 V){ return MkVectorI4(V.x, 0, V.z, V.z); }
inline VectorI4 SwizzX_ZW(VectorI4 V){ return MkVectorI4(V.x, 0, V.z, V.w); }
inline VectorI4 SwizzX_Z_(VectorI4 V){ return MkVectorI4(V.x, 0, V.z, 0); }
inline VectorI4 SwizzX_WX(VectorI4 V){ return MkVectorI4(V.x, 0, V.w, V.x); }
inline VectorI4 SwizzX_WY(VectorI4 V){ return MkVectorI4(V.x, 0, V.w, V.y); }
inline VectorI4 SwizzX_WZ(VectorI4 V){ return MkVectorI4(V.x, 0, V.w, V.z); }
inline VectorI4 SwizzX_WW(VectorI4 V){ return MkVectorI4(V.x, 0, V.w, V.w); }
inline VectorI4 SwizzX_W_(VectorI4 V){ return MkVectorI4(V.x, 0, V.w, 0); }
inline VectorI4 SwizzX__X(VectorI4 V){ return MkVectorI4(V.x, 0, 0, V.x); }
inline VectorI4 SwizzX__Y(VectorI4 V){ return MkVectorI4(V.x, 0, 0, V.y); }
inline VectorI4 SwizzX__Z(VectorI4 V){ return MkVectorI4(V.x, 0, 0, V.z); }
inline VectorI4 SwizzX__W(VectorI4 V){ return MkVectorI4(V.x, 0, 0, V.w); }
inline VectorI4 SwizzX___(VectorI4 V){ return MkVectorI4(V.x, 0, 0, 0); }
inline VectorI4 SwizzYXXX(VectorI4 V){ return MkVectorI4(V.y, V.x, V.x, V.x); }
inline VectorI4 SwizzYXXY(VectorI4 V){ return MkVectorI4(V.y, V.x, V.x, V.y); }
inline VectorI4 SwizzYXXZ(VectorI4 V){ return MkVectorI4(V.y, V.x, V.x, V.z); }
inline VectorI4 SwizzYXXW(VectorI4 V){ return MkVectorI4(V.y, V.x, V.x, V.w); }
inline VectorI4 SwizzYXX_(VectorI4 V){ return MkVectorI4(V.y, V.x, V.x, 0); }
inline VectorI4 SwizzYXYX(VectorI4 V){ return MkVectorI4(V.y, V.x, V.y, V.x); }
inline VectorI4 SwizzYXYY(VectorI4 V){ return MkVectorI4(V.y, V.x, V.y, V.y); }
inline VectorI4 SwizzYXYZ(VectorI4 V){ return MkVectorI4(V.y, V.x, V.y, V.z); }
inline VectorI4 SwizzYXYW(VectorI4 V){ return MkVectorI4(V.y, V.x, V.y, V.w); }
inline VectorI4 SwizzYXY_(VectorI4 V){ return MkVectorI4(V.y, V.x, V.y, 0); }
inline VectorI4 SwizzYXZX(VectorI4 V){ return MkVectorI4(V.y, V.x, V.z, V.x); }
inline VectorI4 SwizzYXZY(VectorI4 V){ return MkVectorI4(V.y, V.x, V.z, V.y); }
inline VectorI4 SwizzYXZZ(VectorI4 V){ return MkVectorI4(V.y, V.x, V.z, V.z); }
inline VectorI4 SwizzYXZW(VectorI4 V){ return MkVectorI4(V.y, V.x, V.z, V.w); }
inline VectorI4 SwizzYXZ_(VectorI4 V){ return MkVectorI4(V.y, V.x, V.z, 0); }
inline VectorI4 SwizzYXWX(VectorI4 V){ return MkVectorI4(V.y, V.x, V.w, V.x); }
inline VectorI4 SwizzYXWY(VectorI4 V){ return MkVectorI4(V.y, V.x, V.w, V.y); }
inline VectorI4 SwizzYXWZ(VectorI4 V){ return MkVectorI4(V.y, V.x, V.w, V.z); }
inline VectorI4 SwizzYXWW(VectorI4 V){ return MkVectorI4(V.y, V.x, V.w, V.w); }
inline VectorI4 SwizzYXW_(VectorI4 V){ return MkVectorI4(V.y, V.x, V.w, 0); }
inline VectorI4 SwizzYX_X(VectorI4 V){ return MkVectorI4(V.y, V.x, 0, V.x); }
inline VectorI4 SwizzYX_Y(VectorI4 V){ return MkVectorI4(V.y, V.x, 0, V.y); }
inline VectorI4 SwizzYX_Z(VectorI4 V){ return MkVectorI4(V.y, V.x, 0, V.z); }
inline VectorI4 SwizzYX_W(VectorI4 V){ return MkVectorI4(V.y, V.x, 0, V.w); }
inline VectorI4 SwizzYX__(VectorI4 V){ return MkVectorI4(V.y, V.x, 0, 0); }
inline VectorI4 SwizzYYXX(VectorI4 V){ return MkVectorI4(V.y, V.y, V.x, V.x); }
inline VectorI4 SwizzYYXY(VectorI4 V){ return MkVectorI4(V.y, V.y, V.x, V.y); }
inline VectorI4 SwizzYYXZ(VectorI4 V){ return MkVectorI4(V.y, V.y, V.x, V.z); }
inline VectorI4 SwizzYYXW(VectorI4 V){ return MkVectorI4(V.y, V.y, V.x, V.w); }
inline VectorI4 SwizzYYX_(VectorI4 V){ return MkVectorI4(V.y, V.y, V.x, 0); }
inline VectorI4 SwizzYYYX(VectorI4 V){ return MkVectorI4(V.y, V.y, V.y, V.x); }
inline VectorI4 SwizzYYYY(VectorI4 V){ return MkVectorI4(V.y, V.y, V.y, V.y); }
inline VectorI4 SwizzYYYZ(VectorI4 V){ return MkVectorI4(V.y, V.y, V.y, V.z); }
inline VectorI4 SwizzYYYW(VectorI4 V){ return MkVectorI4(V.y, V.y, V.y, V.w); }
inline VectorI4 SwizzYYY_(VectorI4 V){ return MkVectorI4(V.y, V.y, V.y, 0); }
inline VectorI4 SwizzYYZX(VectorI4 V){ return MkVectorI4(V.y, V.y, V.z, V.x); }
inline VectorI4 SwizzYYZY(VectorI4 V){ return MkVectorI4(V.y, V.y, V.z, V.y); }
inline VectorI4 SwizzYYZZ(VectorI4 V){ return MkVectorI4(V.y, V.y, V.z, V.z); }
inline VectorI4 SwizzYYZW(VectorI4 V){ return MkVectorI4(V.y, V.y, V.z, V.w); }
inline VectorI4 SwizzYYZ_(VectorI4 V){ return MkVectorI4(V.y, V.y, V.z, 0); }
inline VectorI4 SwizzYYWX(VectorI4 V){ return MkVectorI4(V.y, V.y, V.w, V.x); }
inline VectorI4 SwizzYYWY(VectorI4 V){ return MkVectorI4(V.y, V.y, V.w, V.y); }
inline VectorI4 SwizzYYWZ(VectorI4 V){ return MkVectorI4(V.y, V.y, V.w, V.z); }
inline VectorI4 SwizzYYWW(VectorI4 V){ return MkVectorI4(V.y, V.y, V.w, V.w); }
inline VectorI4 SwizzYYW_(VectorI4 V){ return MkVectorI4(V.y, V.y, V.w, 0); }
inline VectorI4 SwizzYY_X(VectorI4 V){ return MkVectorI4(V.y, V.y, 0, V.x); }
inline VectorI4 SwizzYY_Y(VectorI4 V){ return MkVectorI4(V.y, V.y, 0, V.y); }
inline VectorI4 SwizzYY_Z(VectorI4 V){ return MkVectorI4(V.y, V.y, 0, V.z); }
inline VectorI4 SwizzYY_W(VectorI4 V){ return MkVectorI4(V.y, V.y, 0, V.w); }
inline VectorI4 SwizzYY__(VectorI4 V){ return MkVectorI4(V.y, V.y, 0, 0); }
inline VectorI4 SwizzYZXX(VectorI4 V){ return MkVectorI4(V.y, V.z, V.x, V.x); }
inline VectorI4 SwizzYZXY(VectorI4 V){ return MkVectorI4(V.y, V.z, V.x, V.y); }
inline VectorI4 SwizzYZXZ(VectorI4 V){ return MkVectorI4(V.y, V.z, V.x, V.z); }
inline VectorI4 SwizzYZXW(VectorI4 V){ return MkVectorI4(V.y, V.z, V.x, V.w); }
inline VectorI4 SwizzYZX_(VectorI4 V){ return MkVectorI4(V.y, V.z, V.x, 0); }
inline VectorI4 SwizzYZYX(VectorI4 V){ return MkVectorI4(V.y, V.z, V.y, V.x); }
inline VectorI4 SwizzYZYY(VectorI4 V){ return MkVectorI4(V.y, V.z, V.y, V.y); }
inline VectorI4 SwizzYZYZ(VectorI4 V){ return MkVectorI4(V.y, V.z, V.y, V.z); }
inline VectorI4 SwizzYZYW(VectorI4 V){ return MkVectorI4(V.y, V.z, V.y, V.w); }
inline VectorI4 SwizzYZY_(VectorI4 V){ return MkVectorI4(V.y, V.z, V.y, 0); }
inline VectorI4 SwizzYZZX(VectorI4 V){ return MkVectorI4(V.y, V.z, V.z, V.x); }
inline VectorI4 SwizzYZZY(VectorI4 V){ return MkVectorI4(V.y, V.z, V.z, V.y); }
inline VectorI4 SwizzYZZZ(VectorI4 V){ return MkVectorI4(V.y, V.z, V.z, V.z); }
inline VectorI4 SwizzYZZW(VectorI4 V){ return MkVectorI4(V.y, V.z, V.z, V.w); }
inline VectorI4 SwizzYZZ_(VectorI4 V){ return MkVectorI4(V.y, V.z, V.z, 0); }
inline VectorI4 SwizzYZWX(VectorI4 V){ return MkVectorI4(V.y, V.z, V.w, V.x); }
inline VectorI4 SwizzYZWY(VectorI4 V){ return MkVectorI4(V.y, V.z, V.w, V.y); }
inline VectorI4 SwizzYZWZ(VectorI4 V){ return MkVectorI4(V.y, V.z, V.w, V.z); }
inline VectorI4 SwizzYZWW(VectorI4 V){ return MkVectorI4(V.y, V.z, V.w, V.w); }
inline VectorI4 SwizzYZW_(VectorI4 V){ return MkVectorI4(V.y, V.z, V.w, 0); }
inline VectorI4 SwizzYZ_X(VectorI4 V){ return MkVectorI4(V.y, V.z, 0, V.x); }
inline VectorI4 SwizzYZ_Y(VectorI4 V){ return MkVectorI4(V.y, V.z, 0, V.y); }
inline VectorI4 SwizzYZ_Z(VectorI4 V){ return MkVectorI4(V.y, V.z, 0, V.z); }
inline VectorI4 SwizzYZ_W(VectorI4 V){ return MkVectorI4(V.y, V.z, 0, V.w); }
inline VectorI4 SwizzYZ__(VectorI4 V){ return MkVectorI4(V.y, V.z, 0, 0); }
inline VectorI4 SwizzYWXX(VectorI4 V){ return MkVectorI4(V.y, V.w, V.x, V.x); }
inline VectorI4 SwizzYWXY(VectorI4 V){ return MkVectorI4(V.y, V.w, V.x, V.y); }
inline VectorI4 SwizzYWXZ(VectorI4 V){ return MkVectorI4(V.y, V.w, V.x, V.z); }
inline VectorI4 SwizzYWXW(VectorI4 V){ return MkVectorI4(V.y, V.w, V.x, V.w); }
inline VectorI4 SwizzYWX_(VectorI4 V){ return MkVectorI4(V.y, V.w, V.x, 0); }
inline VectorI4 SwizzYWYX(VectorI4 V){ return MkVectorI4(V.y, V.w, V.y, V.x); }
inline VectorI4 SwizzYWYY(VectorI4 V){ return MkVectorI4(V.y, V.w, V.y, V.y); }
inline VectorI4 SwizzYWYZ(VectorI4 V){ return MkVectorI4(V.y, V.w, V.y, V.z); }
inline VectorI4 SwizzYWYW(VectorI4 V){ return MkVectorI4(V.y, V.w, V.y, V.w); }
inline VectorI4 SwizzYWY_(VectorI4 V){ return MkVectorI4(V.y, V.w, V.y, 0); }
inline VectorI4 SwizzYWZX(VectorI4 V){ return MkVectorI4(V.y, V.w, V.z, V.x); }
inline VectorI4 SwizzYWZY(VectorI4 V){ return MkVectorI4(V.y, V.w, V.z, V.y); }
inline VectorI4 SwizzYWZZ(VectorI4 V){ return MkVectorI4(V.y, V.w, V.z, V.z); }
inline VectorI4 SwizzYWZW(VectorI4 V){ return MkVectorI4(V.y, V.w, V.z, V.w); }
inline VectorI4 SwizzYWZ_(VectorI4 V){ return MkVectorI4(V.y, V.w, V.z, 0); }
inline VectorI4 SwizzYWWX(VectorI4 V){ return MkVectorI4(V.y, V.w, V.w, V.x); }
inline VectorI4 SwizzYWWY(VectorI4 V){ return MkVectorI4(V.y, V.w, V.w, V.y); }
inline VectorI4 SwizzYWWZ(VectorI4 V){ return MkVectorI4(V.y, V.w, V.w, V.z); }
inline VectorI4 SwizzYWWW(VectorI4 V){ return MkVectorI4(V.y, V.w, V.w, V.w); }
inline VectorI4 SwizzYWW_(VectorI4 V){ return MkVectorI4(V.y, V.w, V.w, 0); }
inline VectorI4 SwizzYW_X(VectorI4 V){ return MkVectorI4(V.y, V.w, 0, V.x); }
inline VectorI4 SwizzYW_Y(VectorI4 V){ return MkVectorI4(V.y, V.w, 0, V.y); }
inline VectorI4 SwizzYW_Z(VectorI4 V){ return MkVectorI4(V.y, V.w, 0, V.z); }
inline VectorI4 SwizzYW_W(VectorI4 V){ return MkVectorI4(V.y, V.w, 0, V.w); }
inline VectorI4 SwizzYW__(VectorI4 V){ return MkVectorI4(V.y, V.w, 0, 0); }
inline VectorI4 SwizzY_XX(VectorI4 V){ return MkVectorI4(V.y, 0, V.x, V.x); }
inline VectorI4 SwizzY_XY(VectorI4 V){ return MkVectorI4(V.y, 0, V.x, V.y); }
inline VectorI4 SwizzY_XZ(VectorI4 V){ return MkVectorI4(V.y, 0, V.x, V.z); }
inline VectorI4 SwizzY_XW(VectorI4 V){ return MkVectorI4(V.y, 0, V.x, V.w); }
inline VectorI4 SwizzY_X_(VectorI4 V){ return MkVectorI4(V.y, 0, V.x, 0); }
inline VectorI4 SwizzY_YX(VectorI4 V){ return MkVectorI4(V.y, 0, V.y, V.x); }
inline VectorI4 SwizzY_YY(VectorI4 V){ return MkVectorI4(V.y, 0, V.y, V.y); }
inline VectorI4 SwizzY_YZ(VectorI4 V){ return MkVectorI4(V.y, 0, V.y, V.z); }
inline VectorI4 SwizzY_YW(VectorI4 V){ return MkVectorI4(V.y, 0, V.y, V.w); }
inline VectorI4 SwizzY_Y_(VectorI4 V){ return MkVectorI4(V.y, 0, V.y, 0); }
inline VectorI4 SwizzY_ZX(VectorI4 V){ return MkVectorI4(V.y, 0, V.z, V.x); }
inline VectorI4 SwizzY_ZY(VectorI4 V){ return MkVectorI4(V.y, 0, V.z, V.y); }
inline VectorI4 SwizzY_ZZ(VectorI4 V){ return MkVectorI4(V.y, 0, V.z, V.z); }
inline VectorI4 SwizzY_ZW(VectorI4 V){ return MkVectorI4(V.y, 0, V.z, V.w); }
inline VectorI4 SwizzY_Z_(VectorI4 V){ return MkVectorI4(V.y, 0, V.z, 0); }
inline VectorI4 SwizzY_WX(VectorI4 V){ return MkVectorI4(V.y, 0, V.w, V.x); }
inline VectorI4 SwizzY_WY(VectorI4 V){ return MkVectorI4(V.y, 0, V.w, V.y); }
inline VectorI4 SwizzY_WZ(VectorI4 V){ return MkVectorI4(V.y, 0, V.w, V.z); }
inline VectorI4 SwizzY_WW(VectorI4 V){ return MkVectorI4(V.y, 0, V.w, V.w); }
inline VectorI4 SwizzY_W_(VectorI4 V){ return MkVectorI4(V.y, 0, V.w, 0); }
inline VectorI4 SwizzY__X(VectorI4 V){ return MkVectorI4(V.y, 0, 0, V.x); }
inline VectorI4 SwizzY__Y(VectorI4 V){ return MkVectorI4(V.y, 0, 0, V.y); }
inline VectorI4 SwizzY__Z(VectorI4 V){ return MkVectorI4(V.y, 0, 0, V.z); }
inline VectorI4 SwizzY__W(VectorI4 V){ return MkVectorI4(V.y, 0, 0, V.w); }
inline VectorI4 SwizzY___(VectorI4 V){ return MkVectorI4(V.y, 0, 0, 0); }
inline VectorI4 SwizzZXXX(VectorI4 V){ return MkVectorI4(V.z, V.x, V.x, V.x); }
inline VectorI4 SwizzZXXY(VectorI4 V){ return MkVectorI4(V.z, V.x, V.x, V.y); }
inline VectorI4 SwizzZXXZ(VectorI4 V){ return MkVectorI4(V.z, V.x, V.x, V.z); }
inline VectorI4 SwizzZXXW(VectorI4 V){ return MkVectorI4(V.z, V.x, V.x, V.w); }
inline VectorI4 SwizzZXX_(VectorI4 V){ return MkVectorI4(V.z, V.x, V.x, 0); }
inline VectorI4 SwizzZXYX(VectorI4 V){ return MkVectorI4(V.z, V.x, V.y, V.x); }
inline VectorI4 SwizzZXYY(VectorI4 V){ return MkVectorI4(V.z, V.x, V.y, V.y); }
inline VectorI4 SwizzZXYZ(VectorI4 V){ return MkVectorI4(V.z, V.x, V.y, V.z); }
inline VectorI4 SwizzZXYW(VectorI4 V){ return MkVectorI4(V.z, V.x, V.y, V.w); }
inline VectorI4 SwizzZXY_(VectorI4 V){ return MkVectorI4(V.z, V.x, V.y, 0); }
inline VectorI4 SwizzZXZX(VectorI4 V){ return MkVectorI4(V.z, V.x, V.z, V.x); }
inline VectorI4 SwizzZXZY(VectorI4 V){ return MkVectorI4(V.z, V.x, V.z, V.y); }
inline VectorI4 SwizzZXZZ(VectorI4 V){ return MkVectorI4(V.z, V.x, V.z, V.z); }
inline VectorI4 SwizzZXZW(VectorI4 V){ return MkVectorI4(V.z, V.x, V.z, V.w); }
inline VectorI4 SwizzZXZ_(VectorI4 V){ return MkVectorI4(V.z, V.x, V.z, 0); }
inline VectorI4 SwizzZXWX(VectorI4 V){ return MkVectorI4(V.z, V.x, V.w, V.x); }
inline VectorI4 SwizzZXWY(VectorI4 V){ return MkVectorI4(V.z, V.x, V.w, V.y); }
inline VectorI4 SwizzZXWZ(VectorI4 V){ return MkVectorI4(V.z, V.x, V.w, V.z); }
inline VectorI4 SwizzZXWW(VectorI4 V){ return MkVectorI4(V.z, V.x, V.w, V.w); }
inline VectorI4 SwizzZXW_(VectorI4 V){ return MkVectorI4(V.z, V.x, V.w, 0); }
inline VectorI4 SwizzZX_X(VectorI4 V){ return MkVectorI4(V.z, V.x, 0, V.x); }
inline VectorI4 SwizzZX_Y(VectorI4 V){ return MkVectorI4(V.z, V.x, 0, V.y); }
inline VectorI4 SwizzZX_Z(VectorI4 V){ return MkVectorI4(V.z, V.x, 0, V.z); }
inline VectorI4 SwizzZX_W(VectorI4 V){ return MkVectorI4(V.z, V.x, 0, V.w); }
inline VectorI4 SwizzZX__(VectorI4 V){ return MkVectorI4(V.z, V.x, 0, 0); }
inline VectorI4 SwizzZYXX(VectorI4 V){ return MkVectorI4(V.z, V.y, V.x, V.x); }
inline VectorI4 SwizzZYXY(VectorI4 V){ return MkVectorI4(V.z, V.y, V.x, V.y); }
inline VectorI4 SwizzZYXZ(VectorI4 V){ return MkVectorI4(V.z, V.y, V.x, V.z); }
inline VectorI4 SwizzZYXW(VectorI4 V){ return MkVectorI4(V.z, V.y, V.x, V.w); }
inline VectorI4 SwizzZYX_(VectorI4 V){ return MkVectorI4(V.z, V.y, V.x, 0); }
inline VectorI4 SwizzZYYX(VectorI4 V){ return MkVectorI4(V.z, V.y, V.y, V.x); }
inline VectorI4 SwizzZYYY(VectorI4 V){ return MkVectorI4(V.z, V.y, V.y, V.y); }
inline VectorI4 SwizzZYYZ(VectorI4 V){ return MkVectorI4(V.z, V.y, V.y, V.z); }
inline VectorI4 SwizzZYYW(VectorI4 V){ return MkVectorI4(V.z, V.y, V.y, V.w); }
inline VectorI4 SwizzZYY_(VectorI4 V){ return MkVectorI4(V.z, V.y, V.y, 0); }
inline VectorI4 SwizzZYZX(VectorI4 V){ return MkVectorI4(V.z, V.y, V.z, V.x); }
inline VectorI4 SwizzZYZY(VectorI4 V){ return MkVectorI4(V.z, V.y, V.z, V.y); }
inline VectorI4 SwizzZYZZ(VectorI4 V){ return MkVectorI4(V.z, V.y, V.z, V.z); }
inline VectorI4 SwizzZYZW(VectorI4 V){ return MkVectorI4(V.z, V.y, V.z, V.w); }
inline VectorI4 SwizzZYZ_(VectorI4 V){ return MkVectorI4(V.z, V.y, V.z, 0); }
inline VectorI4 SwizzZYWX(VectorI4 V){ return MkVectorI4(V.z, V.y, V.w, V.x); }
inline VectorI4 SwizzZYWY(VectorI4 V){ return MkVectorI4(V.z, V.y, V.w, V.y); }
inline VectorI4 SwizzZYWZ(VectorI4 V){ return MkVectorI4(V.z, V.y, V.w, V.z); }
inline VectorI4 SwizzZYWW(VectorI4 V){ return MkVectorI4(V.z, V.y, V.w, V.w); }
inline VectorI4 SwizzZYW_(VectorI4 V){ return MkVectorI4(V.z, V.y, V.w, 0); }
inline VectorI4 SwizzZY_X(VectorI4 V){ return MkVectorI4(V.z, V.y, 0, V.x); }
inline VectorI4 SwizzZY_Y(VectorI4 V){ return MkVectorI4(V.z, V.y, 0, V.y); }
inline VectorI4 SwizzZY_Z(VectorI4 V){ return MkVectorI4(V.z, V.y, 0, V.z); }
inline VectorI4 SwizzZY_W(VectorI4 V){ return MkVectorI4(V.z, V.y, 0, V.w); }
inline VectorI4 SwizzZY__(VectorI4 V){ return MkVectorI4(V.z, V.y, 0, 0); }
inline VectorI4 SwizzZZXX(VectorI4 V){ return MkVectorI4(V.z, V.z, V.x, V.x); }
inline VectorI4 SwizzZZXY(VectorI4 V){ return MkVectorI4(V.z, V.z, V.x, V.y); }
inline VectorI4 SwizzZZXZ(VectorI4 V){ return MkVectorI4(V.z, V.z, V.x, V.z); }
inline VectorI4 SwizzZZXW(VectorI4 V){ return MkVectorI4(V.z, V.z, V.x, V.w); }
inline VectorI4 SwizzZZX_(VectorI4 V){ return MkVectorI4(V.z, V.z, V.x, 0); }
inline VectorI4 SwizzZZYX(VectorI4 V){ return MkVectorI4(V.z, V.z, V.y, V.x); }
inline VectorI4 SwizzZZYY(VectorI4 V){ return MkVectorI4(V.z, V.z, V.y, V.y); }
inline VectorI4 SwizzZZYZ(VectorI4 V){ return MkVectorI4(V.z, V.z, V.y, V.z); }
inline VectorI4 SwizzZZYW(VectorI4 V){ return MkVectorI4(V.z, V.z, V.y, V.w); }
inline VectorI4 SwizzZZY_(VectorI4 V){ return MkVectorI4(V.z, V.z, V.y, 0); }
inline VectorI4 SwizzZZZX(VectorI4 V){ return MkVectorI4(V.z, V.z, V.z, V.x); }
inline VectorI4 SwizzZZZY(VectorI4 V){ return MkVectorI4(V.z, V.z, V.z, V.y); }
inline VectorI4 SwizzZZZZ(VectorI4 V){ return MkVectorI4(V.z, V.z, V.z, V.z); }
inline VectorI4 SwizzZZZW(VectorI4 V){ return MkVectorI4(V.z, V.z, V.z, V.w); }
inline VectorI4 SwizzZZZ_(VectorI4 V){ return MkVectorI4(V.z, V.z, V.z, 0); }
inline VectorI4 SwizzZZWX(VectorI4 V){ return MkVectorI4(V.z, V.z, V.w, V.x); }
inline VectorI4 SwizzZZWY(VectorI4 V){ return MkVectorI4(V.z, V.z, V.w, V.y); }
inline VectorI4 SwizzZZWZ(VectorI4 V){ return MkVectorI4(V.z, V.z, V.w, V.z); }
inline VectorI4 SwizzZZWW(VectorI4 V){ return MkVectorI4(V.z, V.z, V.w, V.w); }
inline VectorI4 SwizzZZW_(VectorI4 V){ return MkVectorI4(V.z, V.z, V.w, 0); }
inline VectorI4 SwizzZZ_X(VectorI4 V){ return MkVectorI4(V.z, V.z, 0, V.x); }
inline VectorI4 SwizzZZ_Y(VectorI4 V){ return MkVectorI4(V.z, V.z, 0, V.y); }
inline VectorI4 SwizzZZ_Z(VectorI4 V){ return MkVectorI4(V.z, V.z, 0, V.z); }
inline VectorI4 SwizzZZ_W(VectorI4 V){ return MkVectorI4(V.z, V.z, 0, V.w); }
inline VectorI4 SwizzZZ__(VectorI4 V){ return MkVectorI4(V.z, V.z, 0, 0); }
inline VectorI4 SwizzZWXX(VectorI4 V){ return MkVectorI4(V.z, V.w, V.x, V.x); }
inline VectorI4 SwizzZWXY(VectorI4 V){ return MkVectorI4(V.z, V.w, V.x, V.y); }
inline VectorI4 SwizzZWXZ(VectorI4 V){ return MkVectorI4(V.z, V.w, V.x, V.z); }
inline VectorI4 SwizzZWXW(VectorI4 V){ return MkVectorI4(V.z, V.w, V.x, V.w); }
inline VectorI4 SwizzZWX_(VectorI4 V){ return MkVectorI4(V.z, V.w, V.x, 0); }
inline VectorI4 SwizzZWYX(VectorI4 V){ return MkVectorI4(V.z, V.w, V.y, V.x); }
inline VectorI4 SwizzZWYY(VectorI4 V){ return MkVectorI4(V.z, V.w, V.y, V.y); }
inline VectorI4 SwizzZWYZ(VectorI4 V){ return MkVectorI4(V.z, V.w, V.y, V.z); }
inline VectorI4 SwizzZWYW(VectorI4 V){ return MkVectorI4(V.z, V.w, V.y, V.w); }
inline VectorI4 SwizzZWY_(VectorI4 V){ return MkVectorI4(V.z, V.w, V.y, 0); }
inline VectorI4 SwizzZWZX(VectorI4 V){ return MkVectorI4(V.z, V.w, V.z, V.x); }
inline VectorI4 SwizzZWZY(VectorI4 V){ return MkVectorI4(V.z, V.w, V.z, V.y); }
inline VectorI4 SwizzZWZZ(VectorI4 V){ return MkVectorI4(V.z, V.w, V.z, V.z); }
inline VectorI4 SwizzZWZW(VectorI4 V){ return MkVectorI4(V.z, V.w, V.z, V.w); }
inline VectorI4 SwizzZWZ_(VectorI4 V){ return MkVectorI4(V.z, V.w, V.z, 0); }
inline VectorI4 SwizzZWWX(VectorI4 V){ return MkVectorI4(V.z, V.w, V.w, V.x); }
inline VectorI4 SwizzZWWY(VectorI4 V){ return MkVectorI4(V.z, V.w, V.w, V.y); }
inline VectorI4 SwizzZWWZ(VectorI4 V){ return MkVectorI4(V.z, V.w, V.w, V.z); }
inline VectorI4 SwizzZWWW(VectorI4 V){ return MkVectorI4(V.z, V.w, V.w, V.w); }
inline VectorI4 SwizzZWW_(VectorI4 V){ return MkVectorI4(V.z, V.w, V.w, 0); }
inline VectorI4 SwizzZW_X(VectorI4 V){ return MkVectorI4(V.z, V.w, 0, V.x); }
inline VectorI4 SwizzZW_Y(VectorI4 V){ return MkVectorI4(V.z, V.w, 0, V.y); }
inline VectorI4 SwizzZW_Z(VectorI4 V){ return MkVectorI4(V.z, V.w, 0, V.z); }
inline VectorI4 SwizzZW_W(VectorI4 V){ return MkVectorI4(V.z, V.w, 0, V.w); }
inline VectorI4 SwizzZW__(VectorI4 V){ return MkVectorI4(V.z, V.w, 0, 0); }
inline VectorI4 SwizzZ_XX(VectorI4 V){ return MkVectorI4(V.z, 0, V.x, V.x); }
inline VectorI4 SwizzZ_XY(VectorI4 V){ return MkVectorI4(V.z, 0, V.x, V.y); }
inline VectorI4 SwizzZ_XZ(VectorI4 V){ return MkVectorI4(V.z, 0, V.x, V.z); }
inline VectorI4 SwizzZ_XW(VectorI4 V){ return MkVectorI4(V.z, 0, V.x, V.w); }
inline VectorI4 SwizzZ_X_(VectorI4 V){ return MkVectorI4(V.z, 0, V.x, 0); }
inline VectorI4 SwizzZ_YX(VectorI4 V){ return MkVectorI4(V.z, 0, V.y, V.x); }
inline VectorI4 SwizzZ_YY(VectorI4 V){ return MkVectorI4(V.z, 0, V.y, V.y); }
inline VectorI4 SwizzZ_YZ(VectorI4 V){ return MkVectorI4(V.z, 0, V.y, V.z); }
inline VectorI4 SwizzZ_YW(VectorI4 V){ return MkVectorI4(V.z, 0, V.y, V.w); }
inline VectorI4 SwizzZ_Y_(VectorI4 V){ return MkVectorI4(V.z, 0, V.y, 0); }
inline VectorI4 SwizzZ_ZX(VectorI4 V){ return MkVectorI4(V.z, 0, V.z, V.x); }
inline VectorI4 SwizzZ_ZY(VectorI4 V){ return MkVectorI4(V.z, 0, V.z, V.y); }
inline VectorI4 SwizzZ_ZZ(VectorI4 V){ return MkVectorI4(V.z, 0, V.z, V.z); }
inline VectorI4 SwizzZ_ZW(VectorI4 V){ return MkVectorI4(V.z, 0, V.z, V.w); }
inline VectorI4 SwizzZ_Z_(VectorI4 V){ return MkVectorI4(V.z, 0, V.z, 0); }
inline VectorI4 SwizzZ_WX(VectorI4 V){ return MkVectorI4(V.z, 0, V.w, V.x); }
inline VectorI4 SwizzZ_WY(VectorI4 V){ return MkVectorI4(V.z, 0, V.w, V.y); }
inline VectorI4 SwizzZ_WZ(VectorI4 V){ return MkVectorI4(V.z, 0, V.w, V.z); }
inline VectorI4 SwizzZ_WW(VectorI4 V){ return MkVectorI4(V.z, 0, V.w, V.w); }
inline VectorI4 SwizzZ_W_(VectorI4 V){ return MkVectorI4(V.z, 0, V.w, 0); }
inline VectorI4 SwizzZ__X(VectorI4 V){ return MkVectorI4(V.z, 0, 0, V.x); }
inline VectorI4 SwizzZ__Y(VectorI4 V){ return MkVectorI4(V.z, 0, 0, V.y); }
inline VectorI4 SwizzZ__Z(VectorI4 V){ return MkVectorI4(V.z, 0, 0, V.z); }
inline VectorI4 SwizzZ__W(VectorI4 V){ return MkVectorI4(V.z, 0, 0, V.w); }
inline VectorI4 SwizzZ___(VectorI4 V){ return MkVectorI4(V.z, 0, 0, 0); }
inline VectorI4 SwizzWXXX(VectorI4 V){ return MkVectorI4(V.w, V.x, V.x, V.x); }
inline VectorI4 SwizzWXXY(VectorI4 V){ return MkVectorI4(V.w, V.x, V.x, V.y); }
inline VectorI4 SwizzWXXZ(VectorI4 V){ return MkVectorI4(V.w, V.x, V.x, V.z); }
inline VectorI4 SwizzWXXW(VectorI4 V){ return MkVectorI4(V.w, V.x, V.x, V.w); }
inline VectorI4 SwizzWXX_(VectorI4 V){ return MkVectorI4(V.w, V.x, V.x, 0); }
inline VectorI4 SwizzWXYX(VectorI4 V){ return MkVectorI4(V.w, V.x, V.y, V.x); }
inline VectorI4 SwizzWXYY(VectorI4 V){ return MkVectorI4(V.w, V.x, V.y, V.y); }
inline VectorI4 SwizzWXYZ(VectorI4 V){ return MkVectorI4(V.w, V.x, V.y, V.z); }
inline VectorI4 SwizzWXYW(VectorI4 V){ return MkVectorI4(V.w, V.x, V.y, V.w); }
inline VectorI4 SwizzWXY_(VectorI4 V){ return MkVectorI4(V.w, V.x, V.y, 0); }
inline VectorI4 SwizzWXZX(VectorI4 V){ return MkVectorI4(V.w, V.x, V.z, V.x); }
inline VectorI4 SwizzWXZY(VectorI4 V){ return MkVectorI4(V.w, V.x, V.z, V.y); }
inline VectorI4 SwizzWXZZ(VectorI4 V){ return MkVectorI4(V.w, V.x, V.z, V.z); }
inline VectorI4 SwizzWXZW(VectorI4 V){ return MkVectorI4(V.w, V.x, V.z, V.w); }
inline VectorI4 SwizzWXZ_(VectorI4 V){ return MkVectorI4(V.w, V.x, V.z, 0); }
inline VectorI4 SwizzWXWX(VectorI4 V){ return MkVectorI4(V.w, V.x, V.w, V.x); }
inline VectorI4 SwizzWXWY(VectorI4 V){ return MkVectorI4(V.w, V.x, V.w, V.y); }
inline VectorI4 SwizzWXWZ(VectorI4 V){ return MkVectorI4(V.w, V.x, V.w, V.z); }
inline VectorI4 SwizzWXWW(VectorI4 V){ return MkVectorI4(V.w, V.x, V.w, V.w); }
inline VectorI4 SwizzWXW_(VectorI4 V){ return MkVectorI4(V.w, V.x, V.w, 0); }
inline VectorI4 SwizzWX_X(VectorI4 V){ return MkVectorI4(V.w, V.x, 0, V.x); }
inline VectorI4 SwizzWX_Y(VectorI4 V){ return MkVectorI4(V.w, V.x, 0, V.y); }
inline VectorI4 SwizzWX_Z(VectorI4 V){ return MkVectorI4(V.w, V.x, 0, V.z); }
inline VectorI4 SwizzWX_W(VectorI4 V){ return MkVectorI4(V.w, V.x, 0, V.w); }
inline VectorI4 SwizzWX__(VectorI4 V){ return MkVectorI4(V.w, V.x, 0, 0); }
inline VectorI4 SwizzWYXX(VectorI4 V){ return MkVectorI4(V.w, V.y, V.x, V.x); }
inline VectorI4 SwizzWYXY(VectorI4 V){ return MkVectorI4(V.w, V.y, V.x, V.y); }
inline VectorI4 SwizzWYXZ(VectorI4 V){ return MkVectorI4(V.w, V.y, V.x, V.z); }
inline VectorI4 SwizzWYXW(VectorI4 V){ return MkVectorI4(V.w, V.y, V.x, V.w); }
inline VectorI4 SwizzWYX_(VectorI4 V){ return MkVectorI4(V.w, V.y, V.x, 0); }
inline VectorI4 SwizzWYYX(VectorI4 V){ return MkVectorI4(V.w, V.y, V.y, V.x); }
inline VectorI4 SwizzWYYY(VectorI4 V){ return MkVectorI4(V.w, V.y, V.y, V.y); }
inline VectorI4 SwizzWYYZ(VectorI4 V){ return MkVectorI4(V.w, V.y, V.y, V.z); }
inline VectorI4 SwizzWYYW(VectorI4 V){ return MkVectorI4(V.w, V.y, V.y, V.w); }
inline VectorI4 SwizzWYY_(VectorI4 V){ return MkVectorI4(V.w, V.y, V.y, 0); }
inline VectorI4 SwizzWYZX(VectorI4 V){ return MkVectorI4(V.w, V.y, V.z, V.x); }
inline VectorI4 SwizzWYZY(VectorI4 V){ return MkVectorI4(V.w, V.y, V.z, V.y); }
inline VectorI4 SwizzWYZZ(VectorI4 V){ return MkVectorI4(V.w, V.y, V.z, V.z); }
inline VectorI4 SwizzWYZW(VectorI4 V){ return MkVectorI4(V.w, V.y, V.z, V.w); }
inline VectorI4 SwizzWYZ_(VectorI4 V){ return MkVectorI4(V.w, V.y, V.z, 0); }
inline VectorI4 SwizzWYWX(VectorI4 V){ return MkVectorI4(V.w, V.y, V.w, V.x); }
inline VectorI4 SwizzWYWY(VectorI4 V){ return MkVectorI4(V.w, V.y, V.w, V.y); }
inline VectorI4 SwizzWYWZ(VectorI4 V){ return MkVectorI4(V.w, V.y, V.w, V.z); }
inline VectorI4 SwizzWYWW(VectorI4 V){ return MkVectorI4(V.w, V.y, V.w, V.w); }
inline VectorI4 SwizzWYW_(VectorI4 V){ return MkVectorI4(V.w, V.y, V.w, 0); }
inline VectorI4 SwizzWY_X(VectorI4 V){ return MkVectorI4(V.w, V.y, 0, V.x); }
inline VectorI4 SwizzWY_Y(VectorI4 V){ return MkVectorI4(V.w, V.y, 0, V.y); }
inline VectorI4 SwizzWY_Z(VectorI4 V){ return MkVectorI4(V.w, V.y, 0, V.z); }
inline VectorI4 SwizzWY_W(VectorI4 V){ return MkVectorI4(V.w, V.y, 0, V.w); }
inline VectorI4 SwizzWY__(VectorI4 V){ return MkVectorI4(V.w, V.y, 0, 0); }
inline VectorI4 SwizzWZXX(VectorI4 V){ return MkVectorI4(V.w, V.z, V.x, V.x); }
inline VectorI4 SwizzWZXY(VectorI4 V){ return MkVectorI4(V.w, V.z, V.x, V.y); }
inline VectorI4 SwizzWZXZ(VectorI4 V){ return MkVectorI4(V.w, V.z, V.x, V.z); }
inline VectorI4 SwizzWZXW(VectorI4 V){ return MkVectorI4(V.w, V.z, V.x, V.w); }
inline VectorI4 SwizzWZX_(VectorI4 V){ return MkVectorI4(V.w, V.z, V.x, 0); }
inline VectorI4 SwizzWZYX(VectorI4 V){ return MkVectorI4(V.w, V.z, V.y, V.x); }
inline VectorI4 SwizzWZYY(VectorI4 V){ return MkVectorI4(V.w, V.z, V.y, V.y); }
inline VectorI4 SwizzWZYZ(VectorI4 V){ return MkVectorI4(V.w, V.z, V.y, V.z); }
inline VectorI4 SwizzWZYW(VectorI4 V){ return MkVectorI4(V.w, V.z, V.y, V.w); }
inline VectorI4 SwizzWZY_(VectorI4 V){ return MkVectorI4(V.w, V.z, V.y, 0); }
inline VectorI4 SwizzWZZX(VectorI4 V){ return MkVectorI4(V.w, V.z, V.z, V.x); }
inline VectorI4 SwizzWZZY(VectorI4 V){ return MkVectorI4(V.w, V.z, V.z, V.y); }
inline VectorI4 SwizzWZZZ(VectorI4 V){ return MkVectorI4(V.w, V.z, V.z, V.z); }
inline VectorI4 SwizzWZZW(VectorI4 V){ return MkVectorI4(V.w, V.z, V.z, V.w); }
inline VectorI4 SwizzWZZ_(VectorI4 V){ return MkVectorI4(V.w, V.z, V.z, 0); }
inline VectorI4 SwizzWZWX(VectorI4 V){ return MkVectorI4(V.w, V.z, V.w, V.x); }
inline VectorI4 SwizzWZWY(VectorI4 V){ return MkVectorI4(V.w, V.z, V.w, V.y); }
inline VectorI4 SwizzWZWZ(VectorI4 V){ return MkVectorI4(V.w, V.z, V.w, V.z); }
inline VectorI4 SwizzWZWW(VectorI4 V){ return MkVectorI4(V.w, V.z, V.w, V.w); }
inline VectorI4 SwizzWZW_(VectorI4 V){ return MkVectorI4(V.w, V.z, V.w, 0); }
inline VectorI4 SwizzWZ_X(VectorI4 V){ return MkVectorI4(V.w, V.z, 0, V.x); }
inline VectorI4 SwizzWZ_Y(VectorI4 V){ return MkVectorI4(V.w, V.z, 0, V.y); }
inline VectorI4 SwizzWZ_Z(VectorI4 V){ return MkVectorI4(V.w, V.z, 0, V.z); }
inline VectorI4 SwizzWZ_W(VectorI4 V){ return MkVectorI4(V.w, V.z, 0, V.w); }
inline VectorI4 SwizzWZ__(VectorI4 V){ return MkVectorI4(V.w, V.z, 0, 0); }
inline VectorI4 SwizzWWXX(VectorI4 V){ return MkVectorI4(V.w, V.w, V.x, V.x); }
inline VectorI4 SwizzWWXY(VectorI4 V){ return MkVectorI4(V.w, V.w, V.x, V.y); }
inline VectorI4 SwizzWWXZ(VectorI4 V){ return MkVectorI4(V.w, V.w, V.x, V.z); }
inline VectorI4 SwizzWWXW(VectorI4 V){ return MkVectorI4(V.w, V.w, V.x, V.w); }
inline VectorI4 SwizzWWX_(VectorI4 V){ return MkVectorI4(V.w, V.w, V.x, 0); }
inline VectorI4 SwizzWWYX(VectorI4 V){ return MkVectorI4(V.w, V.w, V.y, V.x); }
inline VectorI4 SwizzWWYY(VectorI4 V){ return MkVectorI4(V.w, V.w, V.y, V.y); }
inline VectorI4 SwizzWWYZ(VectorI4 V){ return MkVectorI4(V.w, V.w, V.y, V.z); }
inline VectorI4 SwizzWWYW(VectorI4 V){ return MkVectorI4(V.w, V.w, V.y, V.w); }
inline VectorI4 SwizzWWY_(VectorI4 V){ return MkVectorI4(V.w, V.w, V.y, 0); }
inline VectorI4 SwizzWWZX(VectorI4 V){ return MkVectorI4(V.w, V.w, V.z, V.x); }
inline VectorI4 SwizzWWZY(VectorI4 V){ return MkVectorI4(V.w, V.w, V.z, V.y); }
inline VectorI4 SwizzWWZZ(VectorI4 V){ return MkVectorI4(V.w, V.w, V.z, V.z); }
inline VectorI4 SwizzWWZW(VectorI4 V){ return MkVectorI4(V.w, V.w, V.z, V.w); }
inline VectorI4 SwizzWWZ_(VectorI4 V){ return MkVectorI4(V.w, V.w, V.z, 0); }
inline VectorI4 SwizzWWWX(VectorI4 V){ return MkVectorI4(V.w, V.w, V.w, V.x); }
inline VectorI4 SwizzWWWY(VectorI4 V){ return MkVectorI4(V.w, V.w, V.w, V.y); }
inline VectorI4 SwizzWWWZ(VectorI4 V){ return MkVectorI4(V.w, V.w, V.w, V.z); }
inline VectorI4 SwizzWWWW(VectorI4 V){ return MkVectorI4(V.w, V.w, V.w, V.w); }
inline VectorI4 SwizzWWW_(VectorI4 V){ return MkVectorI4(V.w, V.w, V.w, 0); }
inline VectorI4 SwizzWW_X(VectorI4 V){ return MkVectorI4(V.w, V.w, 0, V.x); }
inline VectorI4 SwizzWW_Y(VectorI4 V){ return MkVectorI4(V.w, V.w, 0, V.y); }
inline VectorI4 SwizzWW_Z(VectorI4 V){ return MkVectorI4(V.w, V.w, 0, V.z); }
inline VectorI4 SwizzWW_W(VectorI4 V){ return MkVectorI4(V.w, V.w, 0, V.w); }
inline VectorI4 SwizzWW__(VectorI4 V){ return MkVectorI4(V.w, V.w, 0, 0); }
inline VectorI4 SwizzW_XX(VectorI4 V){ return MkVectorI4(V.w, 0, V.x, V.x); }
inline VectorI4 SwizzW_XY(VectorI4 V){ return MkVectorI4(V.w, 0, V.x, V.y); }
inline VectorI4 SwizzW_XZ(VectorI4 V){ return MkVectorI4(V.w, 0, V.x, V.z); }
inline VectorI4 SwizzW_XW(VectorI4 V){ return MkVectorI4(V.w, 0, V.x, V.w); }
inline VectorI4 SwizzW_X_(VectorI4 V){ return MkVectorI4(V.w, 0, V.x, 0); }
inline VectorI4 SwizzW_YX(VectorI4 V){ return MkVectorI4(V.w, 0, V.y, V.x); }
inline VectorI4 SwizzW_YY(VectorI4 V){ return MkVectorI4(V.w, 0, V.y, V.y); }
inline VectorI4 SwizzW_YZ(VectorI4 V){ return MkVectorI4(V.w, 0, V.y, V.z); }
inline VectorI4 SwizzW_YW(VectorI4 V){ return MkVectorI4(V.w, 0, V.y, V.w); }
inline VectorI4 SwizzW_Y_(VectorI4 V){ return MkVectorI4(V.w, 0, V.y, 0); }
inline VectorI4 SwizzW_ZX(VectorI4 V){ return MkVectorI4(V.w, 0, V.z, V.x); }
inline VectorI4 SwizzW_ZY(VectorI4 V){ return MkVectorI4(V.w, 0, V.z, V.y); }
inline VectorI4 SwizzW_ZZ(VectorI4 V){ return MkVectorI4(V.w, 0, V.z, V.z); }
inline VectorI4 SwizzW_ZW(VectorI4 V){ return MkVectorI4(V.w, 0, V.z, V.w); }
inline VectorI4 SwizzW_Z_(VectorI4 V){ return MkVectorI4(V.w, 0, V.z, 0); }
inline VectorI4 SwizzW_WX(VectorI4 V){ return MkVectorI4(V.w, 0, V.w, V.x); }
inline VectorI4 SwizzW_WY(VectorI4 V){ return MkVectorI4(V.w, 0, V.w, V.y); }
inline VectorI4 SwizzW_WZ(VectorI4 V){ return MkVectorI4(V.w, 0, V.w, V.z); }
inline VectorI4 SwizzW_WW(VectorI4 V){ return MkVectorI4(V.w, 0, V.w, V.w); }
inline VectorI4 SwizzW_W_(VectorI4 V){ return MkVectorI4(V.w, 0, V.w, 0); }
inline VectorI4 SwizzW__X(VectorI4 V){ return MkVectorI4(V.w, 0, 0, V.x); }
inline VectorI4 SwizzW__Y(VectorI4 V){ return MkVectorI4(V.w, 0, 0, V.y); }
inline VectorI4 SwizzW__Z(VectorI4 V){ return MkVectorI4(V.w, 0, 0, V.z); }
inline VectorI4 SwizzW__W(VectorI4 V){ return MkVectorI4(V.w, 0, 0, V.w); }
inline VectorI4 SwizzW___(VectorI4 V){ return MkVectorI4(V.w, 0, 0, 0); }
inline VectorI4 Swizz_XXX(VectorI4 V){ return MkVectorI4(0, V.x, V.x, V.x); }
inline VectorI4 Swizz_XXY(VectorI4 V){ return MkVectorI4(0, V.x, V.x, V.y); }
inline VectorI4 Swizz_XXZ(VectorI4 V){ return MkVectorI4(0, V.x, V.x, V.z); }
inline VectorI4 Swizz_XXW(VectorI4 V){ return MkVectorI4(0, V.x, V.x, V.w); }
inline VectorI4 Swizz_XX_(VectorI4 V){ return MkVectorI4(0, V.x, V.x, 0); }
inline VectorI4 Swizz_XYX(VectorI4 V){ return MkVectorI4(0, V.x, V.y, V.x); }
inline VectorI4 Swizz_XYY(VectorI4 V){ return MkVectorI4(0, V.x, V.y, V.y); }
inline VectorI4 Swizz_XYZ(VectorI4 V){ return MkVectorI4(0, V.x, V.y, V.z); }
inline VectorI4 Swizz_XYW(VectorI4 V){ return MkVectorI4(0, V.x, V.y, V.w); }
inline VectorI4 Swizz_XY_(VectorI4 V){ return MkVectorI4(0, V.x, V.y, 0); }
inline VectorI4 Swizz_XZX(VectorI4 V){ return MkVectorI4(0, V.x, V.z, V.x); }
inline VectorI4 Swizz_XZY(VectorI4 V){ return MkVectorI4(0, V.x, V.z, V.y); }
inline VectorI4 Swizz_XZZ(VectorI4 V){ return MkVectorI4(0, V.x, V.z, V.z); }
inline VectorI4 Swizz_XZW(VectorI4 V){ return MkVectorI4(0, V.x, V.z, V.w); }
inline VectorI4 Swizz_XZ_(VectorI4 V){ return MkVectorI4(0, V.x, V.z, 0); }
inline VectorI4 Swizz_XWX(VectorI4 V){ return MkVectorI4(0, V.x, V.w, V.x); }
inline VectorI4 Swizz_XWY(VectorI4 V){ return MkVectorI4(0, V.x, V.w, V.y); }
inline VectorI4 Swizz_XWZ(VectorI4 V){ return MkVectorI4(0, V.x, V.w, V.z); }
inline VectorI4 Swizz_XWW(VectorI4 V){ return MkVectorI4(0, V.x, V.w, V.w); }
inline VectorI4 Swizz_XW_(VectorI4 V){ return MkVectorI4(0, V.x, V.w, 0); }
inline VectorI4 Swizz_X_X(VectorI4 V){ return MkVectorI4(0, V.x, 0, V.x); }
inline VectorI4 Swizz_X_Y(VectorI4 V){ return MkVectorI4(0, V.x, 0, V.y); }
inline VectorI4 Swizz_X_Z(VectorI4 V){ return MkVectorI4(0, V.x, 0, V.z); }
inline VectorI4 Swizz_X_W(VectorI4 V){ return MkVectorI4(0, V.x, 0, V.w); }
inline VectorI4 Swizz_X__(VectorI4 V){ return MkVectorI4(0, V.x, 0, 0); }
inline VectorI4 Swizz_YXX(VectorI4 V){ return MkVectorI4(0, V.y, V.x, V.x); }
inline VectorI4 Swizz_YXY(VectorI4 V){ return MkVectorI4(0, V.y, V.x, V.y); }
inline VectorI4 Swizz_YXZ(VectorI4 V){ return MkVectorI4(0, V.y, V.x, V.z); }
inline VectorI4 Swizz_YXW(VectorI4 V){ return MkVectorI4(0, V.y, V.x, V.w); }
inline VectorI4 Swizz_YX_(VectorI4 V){ return MkVectorI4(0, V.y, V.x, 0); }
inline VectorI4 Swizz_YYX(VectorI4 V){ return MkVectorI4(0, V.y, V.y, V.x); }
inline VectorI4 Swizz_YYY(VectorI4 V){ return MkVectorI4(0, V.y, V.y, V.y); }
inline VectorI4 Swizz_YYZ(VectorI4 V){ return MkVectorI4(0, V.y, V.y, V.z); }
inline VectorI4 Swizz_YYW(VectorI4 V){ return MkVectorI4(0, V.y, V.y, V.w); }
inline VectorI4 Swizz_YY_(VectorI4 V){ return MkVectorI4(0, V.y, V.y, 0); }
inline VectorI4 Swizz_YZX(VectorI4 V){ return MkVectorI4(0, V.y, V.z, V.x); }
inline VectorI4 Swizz_YZY(VectorI4 V){ return MkVectorI4(0, V.y, V.z, V.y); }
inline VectorI4 Swizz_YZZ(VectorI4 V){ return MkVectorI4(0, V.y, V.z, V.z); }
inline VectorI4 Swizz_YZW(VectorI4 V){ return MkVectorI4(0, V.y, V.z, V.w); }
inline VectorI4 Swizz_YZ_(VectorI4 V){ return MkVectorI4(0, V.y, V.z, 0); }
inline VectorI4 Swizz_YWX(VectorI4 V){ return MkVectorI4(0, V.y, V.w, V.x); }
inline VectorI4 Swizz_YWY(VectorI4 V){ return MkVectorI4(0, V.y, V.w, V.y); }
inline VectorI4 Swizz_YWZ(VectorI4 V){ return MkVectorI4(0, V.y, V.w, V.z); }
inline VectorI4 Swizz_YWW(VectorI4 V){ return MkVectorI4(0, V.y, V.w, V.w); }
inline VectorI4 Swizz_YW_(VectorI4 V){ return MkVectorI4(0, V.y, V.w, 0); }
inline VectorI4 Swizz_Y_X(VectorI4 V){ return MkVectorI4(0, V.y, 0, V.x); }
inline VectorI4 Swizz_Y_Y(VectorI4 V){ return MkVectorI4(0, V.y, 0, V.y); }
inline VectorI4 Swizz_Y_Z(VectorI4 V){ return MkVectorI4(0, V.y, 0, V.z); }
inline VectorI4 Swizz_Y_W(VectorI4 V){ return MkVectorI4(0, V.y, 0, V.w); }
inline VectorI4 Swizz_Y__(VectorI4 V){ return MkVectorI4(0, V.y, 0, 0); }
inline VectorI4 Swizz_ZXX(VectorI4 V){ return MkVectorI4(0, V.z, V.x, V.x); }
inline VectorI4 Swizz_ZXY(VectorI4 V){ return MkVectorI4(0, V.z, V.x, V.y); }
inline VectorI4 Swizz_ZXZ(VectorI4 V){ return MkVectorI4(0, V.z, V.x, V.z); }
inline VectorI4 Swizz_ZXW(VectorI4 V){ return MkVectorI4(0, V.z, V.x, V.w); }
inline VectorI4 Swizz_ZX_(VectorI4 V){ return MkVectorI4(0, V.z, V.x, 0); }
inline VectorI4 Swizz_ZYX(VectorI4 V){ return MkVectorI4(0, V.z, V.y, V.x); }
inline VectorI4 Swizz_ZYY(VectorI4 V){ return MkVectorI4(0, V.z, V.y, V.y); }
inline VectorI4 Swizz_ZYZ(VectorI4 V){ return MkVectorI4(0, V.z, V.y, V.z); }
inline VectorI4 Swizz_ZYW(VectorI4 V){ return MkVectorI4(0, V.z, V.y, V.w); }
inline VectorI4 Swizz_ZY_(VectorI4 V){ return MkVectorI4(0, V.z, V.y, 0); }
inline VectorI4 Swizz_ZZX(VectorI4 V){ return MkVectorI4(0, V.z, V.z, V.x); }
inline VectorI4 Swizz_ZZY(VectorI4 V){ return MkVectorI4(0, V.z, V.z, V.y); }
inline VectorI4 Swizz_ZZZ(VectorI4 V){ return MkVectorI4(0, V.z, V.z, V.z); }
inline VectorI4 Swizz_ZZW(VectorI4 V){ return MkVectorI4(0, V.z, V.z, V.w); }
inline VectorI4 Swizz_ZZ_(VectorI4 V){ return MkVectorI4(0, V.z, V.z, 0); }
inline VectorI4 Swizz_ZWX(VectorI4 V){ return MkVectorI4(0, V.z, V.w, V.x); }
inline VectorI4 Swizz_ZWY(VectorI4 V){ return MkVectorI4(0, V.z, V.w, V.y); }
inline VectorI4 Swizz_ZWZ(VectorI4 V){ return MkVectorI4(0, V.z, V.w, V.z); }
inline VectorI4 Swizz_ZWW(VectorI4 V){ return MkVectorI4(0, V.z, V.w, V.w); }
inline VectorI4 Swizz_ZW_(VectorI4 V){ return MkVectorI4(0, V.z, V.w, 0); }
inline VectorI4 Swizz_Z_X(VectorI4 V){ return MkVectorI4(0, V.z, 0, V.x); }
inline VectorI4 Swizz_Z_Y(VectorI4 V){ return MkVectorI4(0, V.z, 0, V.y); }
inline VectorI4 Swizz_Z_Z(VectorI4 V){ return MkVectorI4(0, V.z, 0, V.z); }
inline VectorI4 Swizz_Z_W(VectorI4 V){ return MkVectorI4(0, V.z, 0, V.w); }
inline VectorI4 Swizz_Z__(VectorI4 V){ return MkVectorI4(0, V.z, 0, 0); }
inline VectorI4 Swizz_WXX(VectorI4 V){ return MkVectorI4(0, V.w, V.x, V.x); }
inline VectorI4 Swizz_WXY(VectorI4 V){ return MkVectorI4(0, V.w, V.x, V.y); }
inline VectorI4 Swizz_WXZ(VectorI4 V){ return MkVectorI4(0, V.w, V.x, V.z); }
inline VectorI4 Swizz_WXW(VectorI4 V){ return MkVectorI4(0, V.w, V.x, V.w); }
inline VectorI4 Swizz_WX_(VectorI4 V){ return MkVectorI4(0, V.w, V.x, 0); }
inline VectorI4 Swizz_WYX(VectorI4 V){ return MkVectorI4(0, V.w, V.y, V.x); }
inline VectorI4 Swizz_WYY(VectorI4 V){ return MkVectorI4(0, V.w, V.y, V.y); }
inline VectorI4 Swizz_WYZ(VectorI4 V){ return MkVectorI4(0, V.w, V.y, V.z); }
inline VectorI4 Swizz_WYW(VectorI4 V){ return MkVectorI4(0, V.w, V.y, V.w); }
inline VectorI4 Swizz_WY_(VectorI4 V){ return MkVectorI4(0, V.w, V.y, 0); }
inline VectorI4 Swizz_WZX(VectorI4 V){ return MkVectorI4(0, V.w, V.z, V.x); }
inline VectorI4 Swizz_WZY(VectorI4 V){ return MkVectorI4(0, V.w, V.z, V.y); }
inline VectorI4 Swizz_WZZ(VectorI4 V){ return MkVectorI4(0, V.w, V.z, V.z); }
inline VectorI4 Swizz_WZW(VectorI4 V){ return MkVectorI4(0, V.w, V.z, V.w); }
inline VectorI4 Swizz_WZ_(VectorI4 V){ return MkVectorI4(0, V.w, V.z, 0); }
inline VectorI4 Swizz_WWX(VectorI4 V){ return MkVectorI4(0, V.w, V.w, V.x); }
inline VectorI4 Swizz_WWY(VectorI4 V){ return MkVectorI4(0, V.w, V.w, V.y); }
inline VectorI4 Swizz_WWZ(VectorI4 V){ return MkVectorI4(0, V.w, V.w, V.z); }
inline VectorI4 Swizz_WWW(VectorI4 V){ return MkVectorI4(0, V.w, V.w, V.w); }
inline VectorI4 Swizz_WW_(VectorI4 V){ return MkVectorI4(0, V.w, V.w, 0); }
inline VectorI4 Swizz_W_X(VectorI4 V){ return MkVectorI4(0, V.w, 0, V.x); }
inline VectorI4 Swizz_W_Y(VectorI4 V){ return MkVectorI4(0, V.w, 0, V.y); }
inline VectorI4 Swizz_W_Z(VectorI4 V){ return MkVectorI4(0, V.w, 0, V.z); }
inline VectorI4 Swizz_W_W(VectorI4 V){ return MkVectorI4(0, V.w, 0, V.w); }
inline VectorI4 Swizz_W__(VectorI4 V){ return MkVectorI4(0, V.w, 0, 0); }
inline VectorI4 Swizz__XX(VectorI4 V){ return MkVectorI4(0, 0, V.x, V.x); }
inline VectorI4 Swizz__XY(VectorI4 V){ return MkVectorI4(0, 0, V.x, V.y); }
inline VectorI4 Swizz__XZ(VectorI4 V){ return MkVectorI4(0, 0, V.x, V.z); }
inline VectorI4 Swizz__XW(VectorI4 V){ return MkVectorI4(0, 0, V.x, V.w); }
inline VectorI4 Swizz__X_(VectorI4 V){ return MkVectorI4(0, 0, V.x, 0); }
inline VectorI4 Swizz__YX(VectorI4 V){ return MkVectorI4(0, 0, V.y, V.x); }
inline VectorI4 Swizz__YY(VectorI4 V){ return MkVectorI4(0, 0, V.y, V.y); }
inline VectorI4 Swizz__YZ(VectorI4 V){ return MkVectorI4(0, 0, V.y, V.z); }
inline VectorI4 Swizz__YW(VectorI4 V){ return MkVectorI4(0, 0, V.y, V.w); }
inline VectorI4 Swizz__Y_(VectorI4 V){ return MkVectorI4(0, 0, V.y, 0); }
inline VectorI4 Swizz__ZX(VectorI4 V){ return MkVectorI4(0, 0, V.z, V.x); }
inline VectorI4 Swizz__ZY(VectorI4 V){ return MkVectorI4(0, 0, V.z, V.y); }
inline VectorI4 Swizz__ZZ(VectorI4 V){ return MkVectorI4(0, 0, V.z, V.z); }
inline VectorI4 Swizz__ZW(VectorI4 V){ return MkVectorI4(0, 0, V.z, V.w); }
inline VectorI4 Swizz__Z_(VectorI4 V){ return MkVectorI4(0, 0, V.z, 0); }
inline VectorI4 Swizz__WX(VectorI4 V){ return MkVectorI4(0, 0, V.w, V.x); }
inline VectorI4 Swizz__WY(VectorI4 V){ return MkVectorI4(0, 0, V.w, V.y); }
inline VectorI4 Swizz__WZ(VectorI4 V){ return MkVectorI4(0, 0, V.w, V.z); }
inline VectorI4 Swizz__WW(VectorI4 V){ return MkVectorI4(0, 0, V.w, V.w); }
inline VectorI4 Swizz__W_(VectorI4 V){ return MkVectorI4(0, 0, V.w, 0); }
inline VectorI4 Swizz___X(VectorI4 V){ return MkVectorI4(0, 0, 0, V.x); }
inline VectorI4 Swizz___Y(VectorI4 V){ return MkVectorI4(0, 0, 0, V.y); }
inline VectorI4 Swizz___Z(VectorI4 V){ return MkVectorI4(0, 0, 0, V.z); }
inline VectorI4 Swizz___W(VectorI4 V){ return MkVectorI4(0, 0, 0, V.w); }
inline VectorB2 SwizzXX(VectorB2 V){ return MkVectorB2(V.x, V.x); }
inline VectorB2 SwizzXY(VectorB2 V){ return MkVectorB2(V.x, V.y); }
inline VectorB2 SwizzX_(VectorB2 V){ return MkVectorB2(V.x, 0); }
inline VectorB2 SwizzYX(VectorB2 V){ return MkVectorB2(V.y, V.x); }
inline VectorB2 SwizzYY(VectorB2 V){ return MkVectorB2(V.y, V.y); }
inline VectorB2 SwizzY_(VectorB2 V){ return MkVectorB2(V.y, 0); }
inline VectorB2 Swizz_X(VectorB2 V){ return MkVectorB2(0, V.x); }
inline VectorB2 Swizz_Y(VectorB2 V){ return MkVectorB2(0, V.y); }
inline VectorB3 SwizzXXX(VectorB2 V){ return MkVectorB3(V.x, V.x, V.x); }
inline VectorB3 SwizzXXY(VectorB2 V){ return MkVectorB3(V.x, V.x, V.y); }
inline VectorB3 SwizzXX_(VectorB2 V){ return MkVectorB3(V.x, V.x, 0); }
inline VectorB3 SwizzXYX(VectorB2 V){ return MkVectorB3(V.x, V.y, V.x); }
inline VectorB3 SwizzXYY(VectorB2 V){ return MkVectorB3(V.x, V.y, V.y); }
inline VectorB3 SwizzXY_(VectorB2 V){ return MkVectorB3(V.x, V.y, 0); }
inline VectorB3 SwizzX_X(VectorB2 V){ return MkVectorB3(V.x, 0, V.x); }
inline VectorB3 SwizzX_Y(VectorB2 V){ return MkVectorB3(V.x, 0, V.y); }
inline VectorB3 SwizzX__(VectorB2 V){ return MkVectorB3(V.x, 0, 0); }
inline VectorB3 SwizzYXX(VectorB2 V){ return MkVectorB3(V.y, V.x, V.x); }
inline VectorB3 SwizzYXY(VectorB2 V){ return MkVectorB3(V.y, V.x, V.y); }
inline VectorB3 SwizzYX_(VectorB2 V){ return MkVectorB3(V.y, V.x, 0); }
inline VectorB3 SwizzYYX(VectorB2 V){ return MkVectorB3(V.y, V.y, V.x); }
inline VectorB3 SwizzYYY(VectorB2 V){ return MkVectorB3(V.y, V.y, V.y); }
inline VectorB3 SwizzYY_(VectorB2 V){ return MkVectorB3(V.y, V.y, 0); }
inline VectorB3 SwizzY_X(VectorB2 V){ return MkVectorB3(V.y, 0, V.x); }
inline VectorB3 SwizzY_Y(VectorB2 V){ return MkVectorB3(V.y, 0, V.y); }
inline VectorB3 SwizzY__(VectorB2 V){ return MkVectorB3(V.y, 0, 0); }
inline VectorB3 Swizz_XX(VectorB2 V){ return MkVectorB3(0, V.x, V.x); }
inline VectorB3 Swizz_XY(VectorB2 V){ return MkVectorB3(0, V.x, V.y); }
inline VectorB3 Swizz_X_(VectorB2 V){ return MkVectorB3(0, V.x, 0); }
inline VectorB3 Swizz_YX(VectorB2 V){ return MkVectorB3(0, V.y, V.x); }
inline VectorB3 Swizz_YY(VectorB2 V){ return MkVectorB3(0, V.y, V.y); }
inline VectorB3 Swizz_Y_(VectorB2 V){ return MkVectorB3(0, V.y, 0); }
inline VectorB3 Swizz__X(VectorB2 V){ return MkVectorB3(0, 0, V.x); }
inline VectorB3 Swizz__Y(VectorB2 V){ return MkVectorB3(0, 0, V.y); }
inline VectorB4 SwizzXXXX(VectorB2 V){ return MkVectorB4(V.x, V.x, V.x, V.x); }
inline VectorB4 SwizzXXXY(VectorB2 V){ return MkVectorB4(V.x, V.x, V.x, V.y); }
inline VectorB4 SwizzXXX_(VectorB2 V){ return MkVectorB4(V.x, V.x, V.x, 0); }
inline VectorB4 SwizzXXYX(VectorB2 V){ return MkVectorB4(V.x, V.x, V.y, V.x); }
inline VectorB4 SwizzXXYY(VectorB2 V){ return MkVectorB4(V.x, V.x, V.y, V.y); }
inline VectorB4 SwizzXXY_(VectorB2 V){ return MkVectorB4(V.x, V.x, V.y, 0); }
inline VectorB4 SwizzXX_X(VectorB2 V){ return MkVectorB4(V.x, V.x, 0, V.x); }
inline VectorB4 SwizzXX_Y(VectorB2 V){ return MkVectorB4(V.x, V.x, 0, V.y); }
inline VectorB4 SwizzXX__(VectorB2 V){ return MkVectorB4(V.x, V.x, 0, 0); }
inline VectorB4 SwizzXYXX(VectorB2 V){ return MkVectorB4(V.x, V.y, V.x, V.x); }
inline VectorB4 SwizzXYXY(VectorB2 V){ return MkVectorB4(V.x, V.y, V.x, V.y); }
inline VectorB4 SwizzXYX_(VectorB2 V){ return MkVectorB4(V.x, V.y, V.x, 0); }
inline VectorB4 SwizzXYYX(VectorB2 V){ return MkVectorB4(V.x, V.y, V.y, V.x); }
inline VectorB4 SwizzXYYY(VectorB2 V){ return MkVectorB4(V.x, V.y, V.y, V.y); }
inline VectorB4 SwizzXYY_(VectorB2 V){ return MkVectorB4(V.x, V.y, V.y, 0); }
inline VectorB4 SwizzXY_X(VectorB2 V){ return MkVectorB4(V.x, V.y, 0, V.x); }
inline VectorB4 SwizzXY_Y(VectorB2 V){ return MkVectorB4(V.x, V.y, 0, V.y); }
inline VectorB4 SwizzXY__(VectorB2 V){ return MkVectorB4(V.x, V.y, 0, 0); }
inline VectorB4 SwizzX_XX(VectorB2 V){ return MkVectorB4(V.x, 0, V.x, V.x); }
inline VectorB4 SwizzX_XY(VectorB2 V){ return MkVectorB4(V.x, 0, V.x, V.y); }
inline VectorB4 SwizzX_X_(VectorB2 V){ return MkVectorB4(V.x, 0, V.x, 0); }
inline VectorB4 SwizzX_YX(VectorB2 V){ return MkVectorB4(V.x, 0, V.y, V.x); }
inline VectorB4 SwizzX_YY(VectorB2 V){ return MkVectorB4(V.x, 0, V.y, V.y); }
inline VectorB4 SwizzX_Y_(VectorB2 V){ return MkVectorB4(V.x, 0, V.y, 0); }
inline VectorB4 SwizzX__X(VectorB2 V){ return MkVectorB4(V.x, 0, 0, V.x); }
inline VectorB4 SwizzX__Y(VectorB2 V){ return MkVectorB4(V.x, 0, 0, V.y); }
inline VectorB4 SwizzX___(VectorB2 V){ return MkVectorB4(V.x, 0, 0, 0); }
inline VectorB4 SwizzYXXX(VectorB2 V){ return MkVectorB4(V.y, V.x, V.x, V.x); }
inline VectorB4 SwizzYXXY(VectorB2 V){ return MkVectorB4(V.y, V.x, V.x, V.y); }
inline VectorB4 SwizzYXX_(VectorB2 V){ return MkVectorB4(V.y, V.x, V.x, 0); }
inline VectorB4 SwizzYXYX(VectorB2 V){ return MkVectorB4(V.y, V.x, V.y, V.x); }
inline VectorB4 SwizzYXYY(VectorB2 V){ return MkVectorB4(V.y, V.x, V.y, V.y); }
inline VectorB4 SwizzYXY_(VectorB2 V){ return MkVectorB4(V.y, V.x, V.y, 0); }
inline VectorB4 SwizzYX_X(VectorB2 V){ return MkVectorB4(V.y, V.x, 0, V.x); }
inline VectorB4 SwizzYX_Y(VectorB2 V){ return MkVectorB4(V.y, V.x, 0, V.y); }
inline VectorB4 SwizzYX__(VectorB2 V){ return MkVectorB4(V.y, V.x, 0, 0); }
inline VectorB4 SwizzYYXX(VectorB2 V){ return MkVectorB4(V.y, V.y, V.x, V.x); }
inline VectorB4 SwizzYYXY(VectorB2 V){ return MkVectorB4(V.y, V.y, V.x, V.y); }
inline VectorB4 SwizzYYX_(VectorB2 V){ return MkVectorB4(V.y, V.y, V.x, 0); }
inline VectorB4 SwizzYYYX(VectorB2 V){ return MkVectorB4(V.y, V.y, V.y, V.x); }
inline VectorB4 SwizzYYYY(VectorB2 V){ return MkVectorB4(V.y, V.y, V.y, V.y); }
inline VectorB4 SwizzYYY_(VectorB2 V){ return MkVectorB4(V.y, V.y, V.y, 0); }
inline VectorB4 SwizzYY_X(VectorB2 V){ return MkVectorB4(V.y, V.y, 0, V.x); }
inline VectorB4 SwizzYY_Y(VectorB2 V){ return MkVectorB4(V.y, V.y, 0, V.y); }
inline VectorB4 SwizzYY__(VectorB2 V){ return MkVectorB4(V.y, V.y, 0, 0); }
inline VectorB4 SwizzY_XX(VectorB2 V){ return MkVectorB4(V.y, 0, V.x, V.x); }
inline VectorB4 SwizzY_XY(VectorB2 V){ return MkVectorB4(V.y, 0, V.x, V.y); }
inline VectorB4 SwizzY_X_(VectorB2 V){ return MkVectorB4(V.y, 0, V.x, 0); }
inline VectorB4 SwizzY_YX(VectorB2 V){ return MkVectorB4(V.y, 0, V.y, V.x); }
inline VectorB4 SwizzY_YY(VectorB2 V){ return MkVectorB4(V.y, 0, V.y, V.y); }
inline VectorB4 SwizzY_Y_(VectorB2 V){ return MkVectorB4(V.y, 0, V.y, 0); }
inline VectorB4 SwizzY__X(VectorB2 V){ return MkVectorB4(V.y, 0, 0, V.x); }
inline VectorB4 SwizzY__Y(VectorB2 V){ return MkVectorB4(V.y, 0, 0, V.y); }
inline VectorB4 SwizzY___(VectorB2 V){ return MkVectorB4(V.y, 0, 0, 0); }
inline VectorB4 Swizz_XXX(VectorB2 V){ return MkVectorB4(0, V.x, V.x, V.x); }
inline VectorB4 Swizz_XXY(VectorB2 V){ return MkVectorB4(0, V.x, V.x, V.y); }
inline VectorB4 Swizz_XX_(VectorB2 V){ return MkVectorB4(0, V.x, V.x, 0); }
inline VectorB4 Swizz_XYX(VectorB2 V){ return MkVectorB4(0, V.x, V.y, V.x); }
inline VectorB4 Swizz_XYY(VectorB2 V){ return MkVectorB4(0, V.x, V.y, V.y); }
inline VectorB4 Swizz_XY_(VectorB2 V){ return MkVectorB4(0, V.x, V.y, 0); }
inline VectorB4 Swizz_X_X(VectorB2 V){ return MkVectorB4(0, V.x, 0, V.x); }
inline VectorB4 Swizz_X_Y(VectorB2 V){ return MkVectorB4(0, V.x, 0, V.y); }
inline VectorB4 Swizz_X__(VectorB2 V){ return MkVectorB4(0, V.x, 0, 0); }
inline VectorB4 Swizz_YXX(VectorB2 V){ return MkVectorB4(0, V.y, V.x, V.x); }
inline VectorB4 Swizz_YXY(VectorB2 V){ return MkVectorB4(0, V.y, V.x, V.y); }
inline VectorB4 Swizz_YX_(VectorB2 V){ return MkVectorB4(0, V.y, V.x, 0); }
inline VectorB4 Swizz_YYX(VectorB2 V){ return MkVectorB4(0, V.y, V.y, V.x); }
inline VectorB4 Swizz_YYY(VectorB2 V){ return MkVectorB4(0, V.y, V.y, V.y); }
inline VectorB4 Swizz_YY_(VectorB2 V){ return MkVectorB4(0, V.y, V.y, 0); }
inline VectorB4 Swizz_Y_X(VectorB2 V){ return MkVectorB4(0, V.y, 0, V.x); }
inline VectorB4 Swizz_Y_Y(VectorB2 V){ return MkVectorB4(0, V.y, 0, V.y); }
inline VectorB4 Swizz_Y__(VectorB2 V){ return MkVectorB4(0, V.y, 0, 0); }
inline VectorB4 Swizz__XX(VectorB2 V){ return MkVectorB4(0, 0, V.x, V.x); }
inline VectorB4 Swizz__XY(VectorB2 V){ return MkVectorB4(0, 0, V.x, V.y); }
inline VectorB4 Swizz__X_(VectorB2 V){ return MkVectorB4(0, 0, V.x, 0); }
inline VectorB4 Swizz__YX(VectorB2 V){ return MkVectorB4(0, 0, V.y, V.x); }
inline VectorB4 Swizz__YY(VectorB2 V){ return MkVectorB4(0, 0, V.y, V.y); }
inline VectorB4 Swizz__Y_(VectorB2 V){ return MkVectorB4(0, 0, V.y, 0); }
inline VectorB4 Swizz___X(VectorB2 V){ return MkVectorB4(0, 0, 0, V.x); }
inline VectorB4 Swizz___Y(VectorB2 V){ return MkVectorB4(0, 0, 0, V.y); }
inline VectorB2 SwizzXX(VectorB3 V){ return MkVectorB2(V.x, V.x); }
inline VectorB2 SwizzXY(VectorB3 V){ return MkVectorB2(V.x, V.y); }
inline VectorB2 SwizzXZ(VectorB3 V){ return MkVectorB2(V.x, V.z); }
inline VectorB2 SwizzX_(VectorB3 V){ return MkVectorB2(V.x, 0); }
inline VectorB2 SwizzYX(VectorB3 V){ return MkVectorB2(V.y, V.x); }
inline VectorB2 SwizzYY(VectorB3 V){ return MkVectorB2(V.y, V.y); }
inline VectorB2 SwizzYZ(VectorB3 V){ return MkVectorB2(V.y, V.z); }
inline VectorB2 SwizzY_(VectorB3 V){ return MkVectorB2(V.y, 0); }
inline VectorB2 SwizzZX(VectorB3 V){ return MkVectorB2(V.z, V.x); }
inline VectorB2 SwizzZY(VectorB3 V){ return MkVectorB2(V.z, V.y); }
inline VectorB2 SwizzZZ(VectorB3 V){ return MkVectorB2(V.z, V.z); }
inline VectorB2 SwizzZ_(VectorB3 V){ return MkVectorB2(V.z, 0); }
inline VectorB2 Swizz_X(VectorB3 V){ return MkVectorB2(0, V.x); }
inline VectorB2 Swizz_Y(VectorB3 V){ return MkVectorB2(0, V.y); }
inline VectorB2 Swizz_Z(VectorB3 V){ return MkVectorB2(0, V.z); }
inline VectorB3 SwizzXXX(VectorB3 V){ return MkVectorB3(V.x, V.x, V.x); }
inline VectorB3 SwizzXXY(VectorB3 V){ return MkVectorB3(V.x, V.x, V.y); }
inline VectorB3 SwizzXXZ(VectorB3 V){ return MkVectorB3(V.x, V.x, V.z); }
inline VectorB3 SwizzXX_(VectorB3 V){ return MkVectorB3(V.x, V.x, 0); }
inline VectorB3 SwizzXYX(VectorB3 V){ return MkVectorB3(V.x, V.y, V.x); }
inline VectorB3 SwizzXYY(VectorB3 V){ return MkVectorB3(V.x, V.y, V.y); }
inline VectorB3 SwizzXYZ(VectorB3 V){ return MkVectorB3(V.x, V.y, V.z); }
inline VectorB3 SwizzXY_(VectorB3 V){ return MkVectorB3(V.x, V.y, 0); }
inline VectorB3 SwizzXZX(VectorB3 V){ return MkVectorB3(V.x, V.z, V.x); }
inline VectorB3 SwizzXZY(VectorB3 V){ return MkVectorB3(V.x, V.z, V.y); }
inline VectorB3 SwizzXZZ(VectorB3 V){ return MkVectorB3(V.x, V.z, V.z); }
inline VectorB3 SwizzXZ_(VectorB3 V){ return MkVectorB3(V.x, V.z, 0); }
inline VectorB3 SwizzX_X(VectorB3 V){ return MkVectorB3(V.x, 0, V.x); }
inline VectorB3 SwizzX_Y(VectorB3 V){ return MkVectorB3(V.x, 0, V.y); }
inline VectorB3 SwizzX_Z(VectorB3 V){ return MkVectorB3(V.x, 0, V.z); }
inline VectorB3 SwizzX__(VectorB3 V){ return MkVectorB3(V.x, 0, 0); }
inline VectorB3 SwizzYXX(VectorB3 V){ return MkVectorB3(V.y, V.x, V.x); }
inline VectorB3 SwizzYXY(VectorB3 V){ return MkVectorB3(V.y, V.x, V.y); }
inline VectorB3 SwizzYXZ(VectorB3 V){ return MkVectorB3(V.y, V.x, V.z); }
inline VectorB3 SwizzYX_(VectorB3 V){ return MkVectorB3(V.y, V.x, 0); }
inline VectorB3 SwizzYYX(VectorB3 V){ return MkVectorB3(V.y, V.y, V.x); }
inline VectorB3 SwizzYYY(VectorB3 V){ return MkVectorB3(V.y, V.y, V.y); }
inline VectorB3 SwizzYYZ(VectorB3 V){ return MkVectorB3(V.y, V.y, V.z); }
inline VectorB3 SwizzYY_(VectorB3 V){ return MkVectorB3(V.y, V.y, 0); }
inline VectorB3 SwizzYZX(VectorB3 V){ return MkVectorB3(V.y, V.z, V.x); }
inline VectorB3 SwizzYZY(VectorB3 V){ return MkVectorB3(V.y, V.z, V.y); }
inline VectorB3 SwizzYZZ(VectorB3 V){ return MkVectorB3(V.y, V.z, V.z); }
inline VectorB3 SwizzYZ_(VectorB3 V){ return MkVectorB3(V.y, V.z, 0); }
inline VectorB3 SwizzY_X(VectorB3 V){ return MkVectorB3(V.y, 0, V.x); }
inline VectorB3 SwizzY_Y(VectorB3 V){ return MkVectorB3(V.y, 0, V.y); }
inline VectorB3 SwizzY_Z(VectorB3 V){ return MkVectorB3(V.y, 0, V.z); }
inline VectorB3 SwizzY__(VectorB3 V){ return MkVectorB3(V.y, 0, 0); }
inline VectorB3 SwizzZXX(VectorB3 V){ return MkVectorB3(V.z, V.x, V.x); }
inline VectorB3 SwizzZXY(VectorB3 V){ return MkVectorB3(V.z, V.x, V.y); }
inline VectorB3 SwizzZXZ(VectorB3 V){ return MkVectorB3(V.z, V.x, V.z); }
inline VectorB3 SwizzZX_(VectorB3 V){ return MkVectorB3(V.z, V.x, 0); }
inline VectorB3 SwizzZYX(VectorB3 V){ return MkVectorB3(V.z, V.y, V.x); }
inline VectorB3 SwizzZYY(VectorB3 V){ return MkVectorB3(V.z, V.y, V.y); }
inline VectorB3 SwizzZYZ(VectorB3 V){ return MkVectorB3(V.z, V.y, V.z); }
inline VectorB3 SwizzZY_(VectorB3 V){ return MkVectorB3(V.z, V.y, 0); }
inline VectorB3 SwizzZZX(VectorB3 V){ return MkVectorB3(V.z, V.z, V.x); }
inline VectorB3 SwizzZZY(VectorB3 V){ return MkVectorB3(V.z, V.z, V.y); }
inline VectorB3 SwizzZZZ(VectorB3 V){ return MkVectorB3(V.z, V.z, V.z); }
inline VectorB3 SwizzZZ_(VectorB3 V){ return MkVectorB3(V.z, V.z, 0); }
inline VectorB3 SwizzZ_X(VectorB3 V){ return MkVectorB3(V.z, 0, V.x); }
inline VectorB3 SwizzZ_Y(VectorB3 V){ return MkVectorB3(V.z, 0, V.y); }
inline VectorB3 SwizzZ_Z(VectorB3 V){ return MkVectorB3(V.z, 0, V.z); }
inline VectorB3 SwizzZ__(VectorB3 V){ return MkVectorB3(V.z, 0, 0); }
inline VectorB3 Swizz_XX(VectorB3 V){ return MkVectorB3(0, V.x, V.x); }
inline VectorB3 Swizz_XY(VectorB3 V){ return MkVectorB3(0, V.x, V.y); }
inline VectorB3 Swizz_XZ(VectorB3 V){ return MkVectorB3(0, V.x, V.z); }
inline VectorB3 Swizz_X_(VectorB3 V){ return MkVectorB3(0, V.x, 0); }
inline VectorB3 Swizz_YX(VectorB3 V){ return MkVectorB3(0, V.y, V.x); }
inline VectorB3 Swizz_YY(VectorB3 V){ return MkVectorB3(0, V.y, V.y); }
inline VectorB3 Swizz_YZ(VectorB3 V){ return MkVectorB3(0, V.y, V.z); }
inline VectorB3 Swizz_Y_(VectorB3 V){ return MkVectorB3(0, V.y, 0); }
inline VectorB3 Swizz_ZX(VectorB3 V){ return MkVectorB3(0, V.z, V.x); }
inline VectorB3 Swizz_ZY(VectorB3 V){ return MkVectorB3(0, V.z, V.y); }
inline VectorB3 Swizz_ZZ(VectorB3 V){ return MkVectorB3(0, V.z, V.z); }
inline VectorB3 Swizz_Z_(VectorB3 V){ return MkVectorB3(0, V.z, 0); }
inline VectorB3 Swizz__X(VectorB3 V){ return MkVectorB3(0, 0, V.x); }
inline VectorB3 Swizz__Y(VectorB3 V){ return MkVectorB3(0, 0, V.y); }
inline VectorB3 Swizz__Z(VectorB3 V){ return MkVectorB3(0, 0, V.z); }
inline VectorB4 SwizzXXXX(VectorB3 V){ return MkVectorB4(V.x, V.x, V.x, V.x); }
inline VectorB4 SwizzXXXY(VectorB3 V){ return MkVectorB4(V.x, V.x, V.x, V.y); }
inline VectorB4 SwizzXXXZ(VectorB3 V){ return MkVectorB4(V.x, V.x, V.x, V.z); }
inline VectorB4 SwizzXXX_(VectorB3 V){ return MkVectorB4(V.x, V.x, V.x, 0); }
inline VectorB4 SwizzXXYX(VectorB3 V){ return MkVectorB4(V.x, V.x, V.y, V.x); }
inline VectorB4 SwizzXXYY(VectorB3 V){ return MkVectorB4(V.x, V.x, V.y, V.y); }
inline VectorB4 SwizzXXYZ(VectorB3 V){ return MkVectorB4(V.x, V.x, V.y, V.z); }
inline VectorB4 SwizzXXY_(VectorB3 V){ return MkVectorB4(V.x, V.x, V.y, 0); }
inline VectorB4 SwizzXXZX(VectorB3 V){ return MkVectorB4(V.x, V.x, V.z, V.x); }
inline VectorB4 SwizzXXZY(VectorB3 V){ return MkVectorB4(V.x, V.x, V.z, V.y); }
inline VectorB4 SwizzXXZZ(VectorB3 V){ return MkVectorB4(V.x, V.x, V.z, V.z); }
inline VectorB4 SwizzXXZ_(VectorB3 V){ return MkVectorB4(V.x, V.x, V.z, 0); }
inline VectorB4 SwizzXX_X(VectorB3 V){ return MkVectorB4(V.x, V.x, 0, V.x); }
inline VectorB4 SwizzXX_Y(VectorB3 V){ return MkVectorB4(V.x, V.x, 0, V.y); }
inline VectorB4 SwizzXX_Z(VectorB3 V){ return MkVectorB4(V.x, V.x, 0, V.z); }
inline VectorB4 SwizzXX__(VectorB3 V){ return MkVectorB4(V.x, V.x, 0, 0); }
inline VectorB4 SwizzXYXX(VectorB3 V){ return MkVectorB4(V.x, V.y, V.x, V.x); }
inline VectorB4 SwizzXYXY(VectorB3 V){ return MkVectorB4(V.x, V.y, V.x, V.y); }
inline VectorB4 SwizzXYXZ(VectorB3 V){ return MkVectorB4(V.x, V.y, V.x, V.z); }
inline VectorB4 SwizzXYX_(VectorB3 V){ return MkVectorB4(V.x, V.y, V.x, 0); }
inline VectorB4 SwizzXYYX(VectorB3 V){ return MkVectorB4(V.x, V.y, V.y, V.x); }
inline VectorB4 SwizzXYYY(VectorB3 V){ return MkVectorB4(V.x, V.y, V.y, V.y); }
inline VectorB4 SwizzXYYZ(VectorB3 V){ return MkVectorB4(V.x, V.y, V.y, V.z); }
inline VectorB4 SwizzXYY_(VectorB3 V){ return MkVectorB4(V.x, V.y, V.y, 0); }
inline VectorB4 SwizzXYZX(VectorB3 V){ return MkVectorB4(V.x, V.y, V.z, V.x); }
inline VectorB4 SwizzXYZY(VectorB3 V){ return MkVectorB4(V.x, V.y, V.z, V.y); }
inline VectorB4 SwizzXYZZ(VectorB3 V){ return MkVectorB4(V.x, V.y, V.z, V.z); }
inline VectorB4 SwizzXYZ_(VectorB3 V){ return MkVectorB4(V.x, V.y, V.z, 0); }
inline VectorB4 SwizzXY_X(VectorB3 V){ return MkVectorB4(V.x, V.y, 0, V.x); }
inline VectorB4 SwizzXY_Y(VectorB3 V){ return MkVectorB4(V.x, V.y, 0, V.y); }
inline VectorB4 SwizzXY_Z(VectorB3 V){ return MkVectorB4(V.x, V.y, 0, V.z); }
inline VectorB4 SwizzXY__(VectorB3 V){ return MkVectorB4(V.x, V.y, 0, 0); }
inline VectorB4 SwizzXZXX(VectorB3 V){ return MkVectorB4(V.x, V.z, V.x, V.x); }
inline VectorB4 SwizzXZXY(VectorB3 V){ return MkVectorB4(V.x, V.z, V.x, V.y); }
inline VectorB4 SwizzXZXZ(VectorB3 V){ return MkVectorB4(V.x, V.z, V.x, V.z); }
inline VectorB4 SwizzXZX_(VectorB3 V){ return MkVectorB4(V.x, V.z, V.x, 0); }
inline VectorB4 SwizzXZYX(VectorB3 V){ return MkVectorB4(V.x, V.z, V.y, V.x); }
inline VectorB4 SwizzXZYY(VectorB3 V){ return MkVectorB4(V.x, V.z, V.y, V.y); }
inline VectorB4 SwizzXZYZ(VectorB3 V){ return MkVectorB4(V.x, V.z, V.y, V.z); }
inline VectorB4 SwizzXZY_(VectorB3 V){ return MkVectorB4(V.x, V.z, V.y, 0); }
inline VectorB4 SwizzXZZX(VectorB3 V){ return MkVectorB4(V.x, V.z, V.z, V.x); }
inline VectorB4 SwizzXZZY(VectorB3 V){ return MkVectorB4(V.x, V.z, V.z, V.y); }
inline VectorB4 SwizzXZZZ(VectorB3 V){ return MkVectorB4(V.x, V.z, V.z, V.z); }
inline VectorB4 SwizzXZZ_(VectorB3 V){ return MkVectorB4(V.x, V.z, V.z, 0); }
inline VectorB4 SwizzXZ_X(VectorB3 V){ return MkVectorB4(V.x, V.z, 0, V.x); }
inline VectorB4 SwizzXZ_Y(VectorB3 V){ return MkVectorB4(V.x, V.z, 0, V.y); }
inline VectorB4 SwizzXZ_Z(VectorB3 V){ return MkVectorB4(V.x, V.z, 0, V.z); }
inline VectorB4 SwizzXZ__(VectorB3 V){ return MkVectorB4(V.x, V.z, 0, 0); }
inline VectorB4 SwizzX_XX(VectorB3 V){ return MkVectorB4(V.x, 0, V.x, V.x); }
inline VectorB4 SwizzX_XY(VectorB3 V){ return MkVectorB4(V.x, 0, V.x, V.y); }
inline VectorB4 SwizzX_XZ(VectorB3 V){ return MkVectorB4(V.x, 0, V.x, V.z); }
inline VectorB4 SwizzX_X_(VectorB3 V){ return MkVectorB4(V.x, 0, V.x, 0); }
inline VectorB4 SwizzX_YX(VectorB3 V){ return MkVectorB4(V.x, 0, V.y, V.x); }
inline VectorB4 SwizzX_YY(VectorB3 V){ return MkVectorB4(V.x, 0, V.y, V.y); }
inline VectorB4 SwizzX_YZ(VectorB3 V){ return MkVectorB4(V.x, 0, V.y, V.z); }
inline VectorB4 SwizzX_Y_(VectorB3 V){ return MkVectorB4(V.x, 0, V.y, 0); }
inline VectorB4 SwizzX_ZX(VectorB3 V){ return MkVectorB4(V.x, 0, V.z, V.x); }
inline VectorB4 SwizzX_ZY(VectorB3 V){ return MkVectorB4(V.x, 0, V.z, V.y); }
inline VectorB4 SwizzX_ZZ(VectorB3 V){ return MkVectorB4(V.x, 0, V.z, V.z); }
inline VectorB4 SwizzX_Z_(VectorB3 V){ return MkVectorB4(V.x, 0, V.z, 0); }
inline VectorB4 SwizzX__X(VectorB3 V){ return MkVectorB4(V.x, 0, 0, V.x); }
inline VectorB4 SwizzX__Y(VectorB3 V){ return MkVectorB4(V.x, 0, 0, V.y); }
inline VectorB4 SwizzX__Z(VectorB3 V){ return MkVectorB4(V.x, 0, 0, V.z); }
inline VectorB4 SwizzX___(VectorB3 V){ return MkVectorB4(V.x, 0, 0, 0); }
inline VectorB4 SwizzYXXX(VectorB3 V){ return MkVectorB4(V.y, V.x, V.x, V.x); }
inline VectorB4 SwizzYXXY(VectorB3 V){ return MkVectorB4(V.y, V.x, V.x, V.y); }
inline VectorB4 SwizzYXXZ(VectorB3 V){ return MkVectorB4(V.y, V.x, V.x, V.z); }
inline VectorB4 SwizzYXX_(VectorB3 V){ return MkVectorB4(V.y, V.x, V.x, 0); }
inline VectorB4 SwizzYXYX(VectorB3 V){ return MkVectorB4(V.y, V.x, V.y, V.x); }
inline VectorB4 SwizzYXYY(VectorB3 V){ return MkVectorB4(V.y, V.x, V.y, V.y); }
inline VectorB4 SwizzYXYZ(VectorB3 V){ return MkVectorB4(V.y, V.x, V.y, V.z); }
inline VectorB4 SwizzYXY_(VectorB3 V){ return MkVectorB4(V.y, V.x, V.y, 0); }
inline VectorB4 SwizzYXZX(VectorB3 V){ return MkVectorB4(V.y, V.x, V.z, V.x); }
inline VectorB4 SwizzYXZY(VectorB3 V){ return MkVectorB4(V.y, V.x, V.z, V.y); }
inline VectorB4 SwizzYXZZ(VectorB3 V){ return MkVectorB4(V.y, V.x, V.z, V.z); }
inline VectorB4 SwizzYXZ_(VectorB3 V){ return MkVectorB4(V.y, V.x, V.z, 0); }
inline VectorB4 SwizzYX_X(VectorB3 V){ return MkVectorB4(V.y, V.x, 0, V.x); }
inline VectorB4 SwizzYX_Y(VectorB3 V){ return MkVectorB4(V.y, V.x, 0, V.y); }
inline VectorB4 SwizzYX_Z(VectorB3 V){ return MkVectorB4(V.y, V.x, 0, V.z); }
inline VectorB4 SwizzYX__(VectorB3 V){ return MkVectorB4(V.y, V.x, 0, 0); }
inline VectorB4 SwizzYYXX(VectorB3 V){ return MkVectorB4(V.y, V.y, V.x, V.x); }
inline VectorB4 SwizzYYXY(VectorB3 V){ return MkVectorB4(V.y, V.y, V.x, V.y); }
inline VectorB4 SwizzYYXZ(VectorB3 V){ return MkVectorB4(V.y, V.y, V.x, V.z); }
inline VectorB4 SwizzYYX_(VectorB3 V){ return MkVectorB4(V.y, V.y, V.x, 0); }
inline VectorB4 SwizzYYYX(VectorB3 V){ return MkVectorB4(V.y, V.y, V.y, V.x); }
inline VectorB4 SwizzYYYY(VectorB3 V){ return MkVectorB4(V.y, V.y, V.y, V.y); }
inline VectorB4 SwizzYYYZ(VectorB3 V){ return MkVectorB4(V.y, V.y, V.y, V.z); }
inline VectorB4 SwizzYYY_(VectorB3 V){ return MkVectorB4(V.y, V.y, V.y, 0); }
inline VectorB4 SwizzYYZX(VectorB3 V){ return MkVectorB4(V.y, V.y, V.z, V.x); }
inline VectorB4 SwizzYYZY(VectorB3 V){ return MkVectorB4(V.y, V.y, V.z, V.y); }
inline VectorB4 SwizzYYZZ(VectorB3 V){ return MkVectorB4(V.y, V.y, V.z, V.z); }
inline VectorB4 SwizzYYZ_(VectorB3 V){ return MkVectorB4(V.y, V.y, V.z, 0); }
inline VectorB4 SwizzYY_X(VectorB3 V){ return MkVectorB4(V.y, V.y, 0, V.x); }
inline VectorB4 SwizzYY_Y(VectorB3 V){ return MkVectorB4(V.y, V.y, 0, V.y); }
inline VectorB4 SwizzYY_Z(VectorB3 V){ return MkVectorB4(V.y, V.y, 0, V.z); }
inline VectorB4 SwizzYY__(VectorB3 V){ return MkVectorB4(V.y, V.y, 0, 0); }
inline VectorB4 SwizzYZXX(VectorB3 V){ return MkVectorB4(V.y, V.z, V.x, V.x); }
inline VectorB4 SwizzYZXY(VectorB3 V){ return MkVectorB4(V.y, V.z, V.x, V.y); }
inline VectorB4 SwizzYZXZ(VectorB3 V){ return MkVectorB4(V.y, V.z, V.x, V.z); }
inline VectorB4 SwizzYZX_(VectorB3 V){ return MkVectorB4(V.y, V.z, V.x, 0); }
inline VectorB4 SwizzYZYX(VectorB3 V){ return MkVectorB4(V.y, V.z, V.y, V.x); }
inline VectorB4 SwizzYZYY(VectorB3 V){ return MkVectorB4(V.y, V.z, V.y, V.y); }
inline VectorB4 SwizzYZYZ(VectorB3 V){ return MkVectorB4(V.y, V.z, V.y, V.z); }
inline VectorB4 SwizzYZY_(VectorB3 V){ return MkVectorB4(V.y, V.z, V.y, 0); }
inline VectorB4 SwizzYZZX(VectorB3 V){ return MkVectorB4(V.y, V.z, V.z, V.x); }
inline VectorB4 SwizzYZZY(VectorB3 V){ return MkVectorB4(V.y, V.z, V.z, V.y); }
inline VectorB4 SwizzYZZZ(VectorB3 V){ return MkVectorB4(V.y, V.z, V.z, V.z); }
inline VectorB4 SwizzYZZ_(VectorB3 V){ return MkVectorB4(V.y, V.z, V.z, 0); }
inline VectorB4 SwizzYZ_X(VectorB3 V){ return MkVectorB4(V.y, V.z, 0, V.x); }
inline VectorB4 SwizzYZ_Y(VectorB3 V){ return MkVectorB4(V.y, V.z, 0, V.y); }
inline VectorB4 SwizzYZ_Z(VectorB3 V){ return MkVectorB4(V.y, V.z, 0, V.z); }
inline VectorB4 SwizzYZ__(VectorB3 V){ return MkVectorB4(V.y, V.z, 0, 0); }
inline VectorB4 SwizzY_XX(VectorB3 V){ return MkVectorB4(V.y, 0, V.x, V.x); }
inline VectorB4 SwizzY_XY(VectorB3 V){ return MkVectorB4(V.y, 0, V.x, V.y); }
inline VectorB4 SwizzY_XZ(VectorB3 V){ return MkVectorB4(V.y, 0, V.x, V.z); }
inline VectorB4 SwizzY_X_(VectorB3 V){ return MkVectorB4(V.y, 0, V.x, 0); }
inline VectorB4 SwizzY_YX(VectorB3 V){ return MkVectorB4(V.y, 0, V.y, V.x); }
inline VectorB4 SwizzY_YY(VectorB3 V){ return MkVectorB4(V.y, 0, V.y, V.y); }
inline VectorB4 SwizzY_YZ(VectorB3 V){ return MkVectorB4(V.y, 0, V.y, V.z); }
inline VectorB4 SwizzY_Y_(VectorB3 V){ return MkVectorB4(V.y, 0, V.y, 0); }
inline VectorB4 SwizzY_ZX(VectorB3 V){ return MkVectorB4(V.y, 0, V.z, V.x); }
inline VectorB4 SwizzY_ZY(VectorB3 V){ return MkVectorB4(V.y, 0, V.z, V.y); }
inline VectorB4 SwizzY_ZZ(VectorB3 V){ return MkVectorB4(V.y, 0, V.z, V.z); }
inline VectorB4 SwizzY_Z_(VectorB3 V){ return MkVectorB4(V.y, 0, V.z, 0); }
inline VectorB4 SwizzY__X(VectorB3 V){ return MkVectorB4(V.y, 0, 0, V.x); }
inline VectorB4 SwizzY__Y(VectorB3 V){ return MkVectorB4(V.y, 0, 0, V.y); }
inline VectorB4 SwizzY__Z(VectorB3 V){ return MkVectorB4(V.y, 0, 0, V.z); }
inline VectorB4 SwizzY___(VectorB3 V){ return MkVectorB4(V.y, 0, 0, 0); }
inline VectorB4 SwizzZXXX(VectorB3 V){ return MkVectorB4(V.z, V.x, V.x, V.x); }
inline VectorB4 SwizzZXXY(VectorB3 V){ return MkVectorB4(V.z, V.x, V.x, V.y); }
inline VectorB4 SwizzZXXZ(VectorB3 V){ return MkVectorB4(V.z, V.x, V.x, V.z); }
inline VectorB4 SwizzZXX_(VectorB3 V){ return MkVectorB4(V.z, V.x, V.x, 0); }
inline VectorB4 SwizzZXYX(VectorB3 V){ return MkVectorB4(V.z, V.x, V.y, V.x); }
inline VectorB4 SwizzZXYY(VectorB3 V){ return MkVectorB4(V.z, V.x, V.y, V.y); }
inline VectorB4 SwizzZXYZ(VectorB3 V){ return MkVectorB4(V.z, V.x, V.y, V.z); }
inline VectorB4 SwizzZXY_(VectorB3 V){ return MkVectorB4(V.z, V.x, V.y, 0); }
inline VectorB4 SwizzZXZX(VectorB3 V){ return MkVectorB4(V.z, V.x, V.z, V.x); }
inline VectorB4 SwizzZXZY(VectorB3 V){ return MkVectorB4(V.z, V.x, V.z, V.y); }
inline VectorB4 SwizzZXZZ(VectorB3 V){ return MkVectorB4(V.z, V.x, V.z, V.z); }
inline VectorB4 SwizzZXZ_(VectorB3 V){ return MkVectorB4(V.z, V.x, V.z, 0); }
inline VectorB4 SwizzZX_X(VectorB3 V){ return MkVectorB4(V.z, V.x, 0, V.x); }
inline VectorB4 SwizzZX_Y(VectorB3 V){ return MkVectorB4(V.z, V.x, 0, V.y); }
inline VectorB4 SwizzZX_Z(VectorB3 V){ return MkVectorB4(V.z, V.x, 0, V.z); }
inline VectorB4 SwizzZX__(VectorB3 V){ return MkVectorB4(V.z, V.x, 0, 0); }
inline VectorB4 SwizzZYXX(VectorB3 V){ return MkVectorB4(V.z, V.y, V.x, V.x); }
inline VectorB4 SwizzZYXY(VectorB3 V){ return MkVectorB4(V.z, V.y, V.x, V.y); }
inline VectorB4 SwizzZYXZ(VectorB3 V){ return MkVectorB4(V.z, V.y, V.x, V.z); }
inline VectorB4 SwizzZYX_(VectorB3 V){ return MkVectorB4(V.z, V.y, V.x, 0); }
inline VectorB4 SwizzZYYX(VectorB3 V){ return MkVectorB4(V.z, V.y, V.y, V.x); }
inline VectorB4 SwizzZYYY(VectorB3 V){ return MkVectorB4(V.z, V.y, V.y, V.y); }
inline VectorB4 SwizzZYYZ(VectorB3 V){ return MkVectorB4(V.z, V.y, V.y, V.z); }
inline VectorB4 SwizzZYY_(VectorB3 V){ return MkVectorB4(V.z, V.y, V.y, 0); }
inline VectorB4 SwizzZYZX(VectorB3 V){ return MkVectorB4(V.z, V.y, V.z, V.x); }
inline VectorB4 SwizzZYZY(VectorB3 V){ return MkVectorB4(V.z, V.y, V.z, V.y); }
inline VectorB4 SwizzZYZZ(VectorB3 V){ return MkVectorB4(V.z, V.y, V.z, V.z); }
inline VectorB4 SwizzZYZ_(VectorB3 V){ return MkVectorB4(V.z, V.y, V.z, 0); }
inline VectorB4 SwizzZY_X(VectorB3 V){ return MkVectorB4(V.z, V.y, 0, V.x); }
inline VectorB4 SwizzZY_Y(VectorB3 V){ return MkVectorB4(V.z, V.y, 0, V.y); }
inline VectorB4 SwizzZY_Z(VectorB3 V){ return MkVectorB4(V.z, V.y, 0, V.z); }
inline VectorB4 SwizzZY__(VectorB3 V){ return MkVectorB4(V.z, V.y, 0, 0); }
inline VectorB4 SwizzZZXX(VectorB3 V){ return MkVectorB4(V.z, V.z, V.x, V.x); }
inline VectorB4 SwizzZZXY(VectorB3 V){ return MkVectorB4(V.z, V.z, V.x, V.y); }
inline VectorB4 SwizzZZXZ(VectorB3 V){ return MkVectorB4(V.z, V.z, V.x, V.z); }
inline VectorB4 SwizzZZX_(VectorB3 V){ return MkVectorB4(V.z, V.z, V.x, 0); }
inline VectorB4 SwizzZZYX(VectorB3 V){ return MkVectorB4(V.z, V.z, V.y, V.x); }
inline VectorB4 SwizzZZYY(VectorB3 V){ return MkVectorB4(V.z, V.z, V.y, V.y); }
inline VectorB4 SwizzZZYZ(VectorB3 V){ return MkVectorB4(V.z, V.z, V.y, V.z); }
inline VectorB4 SwizzZZY_(VectorB3 V){ return MkVectorB4(V.z, V.z, V.y, 0); }
inline VectorB4 SwizzZZZX(VectorB3 V){ return MkVectorB4(V.z, V.z, V.z, V.x); }
inline VectorB4 SwizzZZZY(VectorB3 V){ return MkVectorB4(V.z, V.z, V.z, V.y); }
inline VectorB4 SwizzZZZZ(VectorB3 V){ return MkVectorB4(V.z, V.z, V.z, V.z); }
inline VectorB4 SwizzZZZ_(VectorB3 V){ return MkVectorB4(V.z, V.z, V.z, 0); }
inline VectorB4 SwizzZZ_X(VectorB3 V){ return MkVectorB4(V.z, V.z, 0, V.x); }
inline VectorB4 SwizzZZ_Y(VectorB3 V){ return MkVectorB4(V.z, V.z, 0, V.y); }
inline VectorB4 SwizzZZ_Z(VectorB3 V){ return MkVectorB4(V.z, V.z, 0, V.z); }
inline VectorB4 SwizzZZ__(VectorB3 V){ return MkVectorB4(V.z, V.z, 0, 0); }
inline VectorB4 SwizzZ_XX(VectorB3 V){ return MkVectorB4(V.z, 0, V.x, V.x); }
inline VectorB4 SwizzZ_XY(VectorB3 V){ return MkVectorB4(V.z, 0, V.x, V.y); }
inline VectorB4 SwizzZ_XZ(VectorB3 V){ return MkVectorB4(V.z, 0, V.x, V.z); }
inline VectorB4 SwizzZ_X_(VectorB3 V){ return MkVectorB4(V.z, 0, V.x, 0); }
inline VectorB4 SwizzZ_YX(VectorB3 V){ return MkVectorB4(V.z, 0, V.y, V.x); }
inline VectorB4 SwizzZ_YY(VectorB3 V){ return MkVectorB4(V.z, 0, V.y, V.y); }
inline VectorB4 SwizzZ_YZ(VectorB3 V){ return MkVectorB4(V.z, 0, V.y, V.z); }
inline VectorB4 SwizzZ_Y_(VectorB3 V){ return MkVectorB4(V.z, 0, V.y, 0); }
inline VectorB4 SwizzZ_ZX(VectorB3 V){ return MkVectorB4(V.z, 0, V.z, V.x); }
inline VectorB4 SwizzZ_ZY(VectorB3 V){ return MkVectorB4(V.z, 0, V.z, V.y); }
inline VectorB4 SwizzZ_ZZ(VectorB3 V){ return MkVectorB4(V.z, 0, V.z, V.z); }
inline VectorB4 SwizzZ_Z_(VectorB3 V){ return MkVectorB4(V.z, 0, V.z, 0); }
inline VectorB4 SwizzZ__X(VectorB3 V){ return MkVectorB4(V.z, 0, 0, V.x); }
inline VectorB4 SwizzZ__Y(VectorB3 V){ return MkVectorB4(V.z, 0, 0, V.y); }
inline VectorB4 SwizzZ__Z(VectorB3 V){ return MkVectorB4(V.z, 0, 0, V.z); }
inline VectorB4 SwizzZ___(VectorB3 V){ return MkVectorB4(V.z, 0, 0, 0); }
inline VectorB4 Swizz_XXX(VectorB3 V){ return MkVectorB4(0, V.x, V.x, V.x); }
inline VectorB4 Swizz_XXY(VectorB3 V){ return MkVectorB4(0, V.x, V.x, V.y); }
inline VectorB4 Swizz_XXZ(VectorB3 V){ return MkVectorB4(0, V.x, V.x, V.z); }
inline VectorB4 Swizz_XX_(VectorB3 V){ return MkVectorB4(0, V.x, V.x, 0); }
inline VectorB4 Swizz_XYX(VectorB3 V){ return MkVectorB4(0, V.x, V.y, V.x); }
inline VectorB4 Swizz_XYY(VectorB3 V){ return MkVectorB4(0, V.x, V.y, V.y); }
inline VectorB4 Swizz_XYZ(VectorB3 V){ return MkVectorB4(0, V.x, V.y, V.z); }
inline VectorB4 Swizz_XY_(VectorB3 V){ return MkVectorB4(0, V.x, V.y, 0); }
inline VectorB4 Swizz_XZX(VectorB3 V){ return MkVectorB4(0, V.x, V.z, V.x); }
inline VectorB4 Swizz_XZY(VectorB3 V){ return MkVectorB4(0, V.x, V.z, V.y); }
inline VectorB4 Swizz_XZZ(VectorB3 V){ return MkVectorB4(0, V.x, V.z, V.z); }
inline VectorB4 Swizz_XZ_(VectorB3 V){ return MkVectorB4(0, V.x, V.z, 0); }
inline VectorB4 Swizz_X_X(VectorB3 V){ return MkVectorB4(0, V.x, 0, V.x); }
inline VectorB4 Swizz_X_Y(VectorB3 V){ return MkVectorB4(0, V.x, 0, V.y); }
inline VectorB4 Swizz_X_Z(VectorB3 V){ return MkVectorB4(0, V.x, 0, V.z); }
inline VectorB4 Swizz_X__(VectorB3 V){ return MkVectorB4(0, V.x, 0, 0); }
inline VectorB4 Swizz_YXX(VectorB3 V){ return MkVectorB4(0, V.y, V.x, V.x); }
inline VectorB4 Swizz_YXY(VectorB3 V){ return MkVectorB4(0, V.y, V.x, V.y); }
inline VectorB4 Swizz_YXZ(VectorB3 V){ return MkVectorB4(0, V.y, V.x, V.z); }
inline VectorB4 Swizz_YX_(VectorB3 V){ return MkVectorB4(0, V.y, V.x, 0); }
inline VectorB4 Swizz_YYX(VectorB3 V){ return MkVectorB4(0, V.y, V.y, V.x); }
inline VectorB4 Swizz_YYY(VectorB3 V){ return MkVectorB4(0, V.y, V.y, V.y); }
inline VectorB4 Swizz_YYZ(VectorB3 V){ return MkVectorB4(0, V.y, V.y, V.z); }
inline VectorB4 Swizz_YY_(VectorB3 V){ return MkVectorB4(0, V.y, V.y, 0); }
inline VectorB4 Swizz_YZX(VectorB3 V){ return MkVectorB4(0, V.y, V.z, V.x); }
inline VectorB4 Swizz_YZY(VectorB3 V){ return MkVectorB4(0, V.y, V.z, V.y); }
inline VectorB4 Swizz_YZZ(VectorB3 V){ return MkVectorB4(0, V.y, V.z, V.z); }
inline VectorB4 Swizz_YZ_(VectorB3 V){ return MkVectorB4(0, V.y, V.z, 0); }
inline VectorB4 Swizz_Y_X(VectorB3 V){ return MkVectorB4(0, V.y, 0, V.x); }
inline VectorB4 Swizz_Y_Y(VectorB3 V){ return MkVectorB4(0, V.y, 0, V.y); }
inline VectorB4 Swizz_Y_Z(VectorB3 V){ return MkVectorB4(0, V.y, 0, V.z); }
inline VectorB4 Swizz_Y__(VectorB3 V){ return MkVectorB4(0, V.y, 0, 0); }
inline VectorB4 Swizz_ZXX(VectorB3 V){ return MkVectorB4(0, V.z, V.x, V.x); }
inline VectorB4 Swizz_ZXY(VectorB3 V){ return MkVectorB4(0, V.z, V.x, V.y); }
inline VectorB4 Swizz_ZXZ(VectorB3 V){ return MkVectorB4(0, V.z, V.x, V.z); }
inline VectorB4 Swizz_ZX_(VectorB3 V){ return MkVectorB4(0, V.z, V.x, 0); }
inline VectorB4 Swizz_ZYX(VectorB3 V){ return MkVectorB4(0, V.z, V.y, V.x); }
inline VectorB4 Swizz_ZYY(VectorB3 V){ return MkVectorB4(0, V.z, V.y, V.y); }
inline VectorB4 Swizz_ZYZ(VectorB3 V){ return MkVectorB4(0, V.z, V.y, V.z); }
inline VectorB4 Swizz_ZY_(VectorB3 V){ return MkVectorB4(0, V.z, V.y, 0); }
inline VectorB4 Swizz_ZZX(VectorB3 V){ return MkVectorB4(0, V.z, V.z, V.x); }
inline VectorB4 Swizz_ZZY(VectorB3 V){ return MkVectorB4(0, V.z, V.z, V.y); }
inline VectorB4 Swizz_ZZZ(VectorB3 V){ return MkVectorB4(0, V.z, V.z, V.z); }
inline VectorB4 Swizz_ZZ_(VectorB3 V){ return MkVectorB4(0, V.z, V.z, 0); }
inline VectorB4 Swizz_Z_X(VectorB3 V){ return MkVectorB4(0, V.z, 0, V.x); }
inline VectorB4 Swizz_Z_Y(VectorB3 V){ return MkVectorB4(0, V.z, 0, V.y); }
inline VectorB4 Swizz_Z_Z(VectorB3 V){ return MkVectorB4(0, V.z, 0, V.z); }
inline VectorB4 Swizz_Z__(VectorB3 V){ return MkVectorB4(0, V.z, 0, 0); }
inline VectorB4 Swizz__XX(VectorB3 V){ return MkVectorB4(0, 0, V.x, V.x); }
inline VectorB4 Swizz__XY(VectorB3 V){ return MkVectorB4(0, 0, V.x, V.y); }
inline VectorB4 Swizz__XZ(VectorB3 V){ return MkVectorB4(0, 0, V.x, V.z); }
inline VectorB4 Swizz__X_(VectorB3 V){ return MkVectorB4(0, 0, V.x, 0); }
inline VectorB4 Swizz__YX(VectorB3 V){ return MkVectorB4(0, 0, V.y, V.x); }
inline VectorB4 Swizz__YY(VectorB3 V){ return MkVectorB4(0, 0, V.y, V.y); }
inline VectorB4 Swizz__YZ(VectorB3 V){ return MkVectorB4(0, 0, V.y, V.z); }
inline VectorB4 Swizz__Y_(VectorB3 V){ return MkVectorB4(0, 0, V.y, 0); }
inline VectorB4 Swizz__ZX(VectorB3 V){ return MkVectorB4(0, 0, V.z, V.x); }
inline VectorB4 Swizz__ZY(VectorB3 V){ return MkVectorB4(0, 0, V.z, V.y); }
inline VectorB4 Swizz__ZZ(VectorB3 V){ return MkVectorB4(0, 0, V.z, V.z); }
inline VectorB4 Swizz__Z_(VectorB3 V){ return MkVectorB4(0, 0, V.z, 0); }
inline VectorB4 Swizz___X(VectorB3 V){ return MkVectorB4(0, 0, 0, V.x); }
inline VectorB4 Swizz___Y(VectorB3 V){ return MkVectorB4(0, 0, 0, V.y); }
inline VectorB4 Swizz___Z(VectorB3 V){ return MkVectorB4(0, 0, 0, V.z); }
inline VectorB2 SwizzXX(VectorB4 V){ return MkVectorB2(V.x, V.x); }
inline VectorB2 SwizzXY(VectorB4 V){ return MkVectorB2(V.x, V.y); }
inline VectorB2 SwizzXZ(VectorB4 V){ return MkVectorB2(V.x, V.z); }
inline VectorB2 SwizzXW(VectorB4 V){ return MkVectorB2(V.x, V.w); }
inline VectorB2 SwizzX_(VectorB4 V){ return MkVectorB2(V.x, 0); }
inline VectorB2 SwizzYX(VectorB4 V){ return MkVectorB2(V.y, V.x); }
inline VectorB2 SwizzYY(VectorB4 V){ return MkVectorB2(V.y, V.y); }
inline VectorB2 SwizzYZ(VectorB4 V){ return MkVectorB2(V.y, V.z); }
inline VectorB2 SwizzYW(VectorB4 V){ return MkVectorB2(V.y, V.w); }
inline VectorB2 SwizzY_(VectorB4 V){ return MkVectorB2(V.y, 0); }
inline VectorB2 SwizzZX(VectorB4 V){ return MkVectorB2(V.z, V.x); }
inline VectorB2 SwizzZY(VectorB4 V){ return MkVectorB2(V.z, V.y); }
inline VectorB2 SwizzZZ(VectorB4 V){ return MkVectorB2(V.z, V.z); }
inline VectorB2 SwizzZW(VectorB4 V){ return MkVectorB2(V.z, V.w); }
inline VectorB2 SwizzZ_(VectorB4 V){ return MkVectorB2(V.z, 0); }
inline VectorB2 SwizzWX(VectorB4 V){ return MkVectorB2(V.w, V.x); }
inline VectorB2 SwizzWY(VectorB4 V){ return MkVectorB2(V.w, V.y); }
inline VectorB2 SwizzWZ(VectorB4 V){ return MkVectorB2(V.w, V.z); }
inline VectorB2 SwizzWW(VectorB4 V){ return MkVectorB2(V.w, V.w); }
inline VectorB2 SwizzW_(VectorB4 V){ return MkVectorB2(V.w, 0); }
inline VectorB2 Swizz_X(VectorB4 V){ return MkVectorB2(0, V.x); }
inline VectorB2 Swizz_Y(VectorB4 V){ return MkVectorB2(0, V.y); }
inline VectorB2 Swizz_Z(VectorB4 V){ return MkVectorB2(0, V.z); }
inline VectorB2 Swizz_W(VectorB4 V){ return MkVectorB2(0, V.w); }
inline VectorB3 SwizzXXX(VectorB4 V){ return MkVectorB3(V.x, V.x, V.x); }
inline VectorB3 SwizzXXY(VectorB4 V){ return MkVectorB3(V.x, V.x, V.y); }
inline VectorB3 SwizzXXZ(VectorB4 V){ return MkVectorB3(V.x, V.x, V.z); }
inline VectorB3 SwizzXXW(VectorB4 V){ return MkVectorB3(V.x, V.x, V.w); }
inline VectorB3 SwizzXX_(VectorB4 V){ return MkVectorB3(V.x, V.x, 0); }
inline VectorB3 SwizzXYX(VectorB4 V){ return MkVectorB3(V.x, V.y, V.x); }
inline VectorB3 SwizzXYY(VectorB4 V){ return MkVectorB3(V.x, V.y, V.y); }
inline VectorB3 SwizzXYZ(VectorB4 V){ return MkVectorB3(V.x, V.y, V.z); }
inline VectorB3 SwizzXYW(VectorB4 V){ return MkVectorB3(V.x, V.y, V.w); }
inline VectorB3 SwizzXY_(VectorB4 V){ return MkVectorB3(V.x, V.y, 0); }
inline VectorB3 SwizzXZX(VectorB4 V){ return MkVectorB3(V.x, V.z, V.x); }
inline VectorB3 SwizzXZY(VectorB4 V){ return MkVectorB3(V.x, V.z, V.y); }
inline VectorB3 SwizzXZZ(VectorB4 V){ return MkVectorB3(V.x, V.z, V.z); }
inline VectorB3 SwizzXZW(VectorB4 V){ return MkVectorB3(V.x, V.z, V.w); }
inline VectorB3 SwizzXZ_(VectorB4 V){ return MkVectorB3(V.x, V.z, 0); }
inline VectorB3 SwizzXWX(VectorB4 V){ return MkVectorB3(V.x, V.w, V.x); }
inline VectorB3 SwizzXWY(VectorB4 V){ return MkVectorB3(V.x, V.w, V.y); }
inline VectorB3 SwizzXWZ(VectorB4 V){ return MkVectorB3(V.x, V.w, V.z); }
inline VectorB3 SwizzXWW(VectorB4 V){ return MkVectorB3(V.x, V.w, V.w); }
inline VectorB3 SwizzXW_(VectorB4 V){ return MkVectorB3(V.x, V.w, 0); }
inline VectorB3 SwizzX_X(VectorB4 V){ return MkVectorB3(V.x, 0, V.x); }
inline VectorB3 SwizzX_Y(VectorB4 V){ return MkVectorB3(V.x, 0, V.y); }
inline VectorB3 SwizzX_Z(VectorB4 V){ return MkVectorB3(V.x, 0, V.z); }
inline VectorB3 SwizzX_W(VectorB4 V){ return MkVectorB3(V.x, 0, V.w); }
inline VectorB3 SwizzX__(VectorB4 V){ return MkVectorB3(V.x, 0, 0); }
inline VectorB3 SwizzYXX(VectorB4 V){ return MkVectorB3(V.y, V.x, V.x); }
inline VectorB3 SwizzYXY(VectorB4 V){ return MkVectorB3(V.y, V.x, V.y); }
inline VectorB3 SwizzYXZ(VectorB4 V){ return MkVectorB3(V.y, V.x, V.z); }
inline VectorB3 SwizzYXW(VectorB4 V){ return MkVectorB3(V.y, V.x, V.w); }
inline VectorB3 SwizzYX_(VectorB4 V){ return MkVectorB3(V.y, V.x, 0); }
inline VectorB3 SwizzYYX(VectorB4 V){ return MkVectorB3(V.y, V.y, V.x); }
inline VectorB3 SwizzYYY(VectorB4 V){ return MkVectorB3(V.y, V.y, V.y); }
inline VectorB3 SwizzYYZ(VectorB4 V){ return MkVectorB3(V.y, V.y, V.z); }
inline VectorB3 SwizzYYW(VectorB4 V){ return MkVectorB3(V.y, V.y, V.w); }
inline VectorB3 SwizzYY_(VectorB4 V){ return MkVectorB3(V.y, V.y, 0); }
inline VectorB3 SwizzYZX(VectorB4 V){ return MkVectorB3(V.y, V.z, V.x); }
inline VectorB3 SwizzYZY(VectorB4 V){ return MkVectorB3(V.y, V.z, V.y); }
inline VectorB3 SwizzYZZ(VectorB4 V){ return MkVectorB3(V.y, V.z, V.z); }
inline VectorB3 SwizzYZW(VectorB4 V){ return MkVectorB3(V.y, V.z, V.w); }
inline VectorB3 SwizzYZ_(VectorB4 V){ return MkVectorB3(V.y, V.z, 0); }
inline VectorB3 SwizzYWX(VectorB4 V){ return MkVectorB3(V.y, V.w, V.x); }
inline VectorB3 SwizzYWY(VectorB4 V){ return MkVectorB3(V.y, V.w, V.y); }
inline VectorB3 SwizzYWZ(VectorB4 V){ return MkVectorB3(V.y, V.w, V.z); }
inline VectorB3 SwizzYWW(VectorB4 V){ return MkVectorB3(V.y, V.w, V.w); }
inline VectorB3 SwizzYW_(VectorB4 V){ return MkVectorB3(V.y, V.w, 0); }
inline VectorB3 SwizzY_X(VectorB4 V){ return MkVectorB3(V.y, 0, V.x); }
inline VectorB3 SwizzY_Y(VectorB4 V){ return MkVectorB3(V.y, 0, V.y); }
inline VectorB3 SwizzY_Z(VectorB4 V){ return MkVectorB3(V.y, 0, V.z); }
inline VectorB3 SwizzY_W(VectorB4 V){ return MkVectorB3(V.y, 0, V.w); }
inline VectorB3 SwizzY__(VectorB4 V){ return MkVectorB3(V.y, 0, 0); }
inline VectorB3 SwizzZXX(VectorB4 V){ return MkVectorB3(V.z, V.x, V.x); }
inline VectorB3 SwizzZXY(VectorB4 V){ return MkVectorB3(V.z, V.x, V.y); }
inline VectorB3 SwizzZXZ(VectorB4 V){ return MkVectorB3(V.z, V.x, V.z); }
inline VectorB3 SwizzZXW(VectorB4 V){ return MkVectorB3(V.z, V.x, V.w); }
inline VectorB3 SwizzZX_(VectorB4 V){ return MkVectorB3(V.z, V.x, 0); }
inline VectorB3 SwizzZYX(VectorB4 V){ return MkVectorB3(V.z, V.y, V.x); }
inline VectorB3 SwizzZYY(VectorB4 V){ return MkVectorB3(V.z, V.y, V.y); }
inline VectorB3 SwizzZYZ(VectorB4 V){ return MkVectorB3(V.z, V.y, V.z); }
inline VectorB3 SwizzZYW(VectorB4 V){ return MkVectorB3(V.z, V.y, V.w); }
inline VectorB3 SwizzZY_(VectorB4 V){ return MkVectorB3(V.z, V.y, 0); }
inline VectorB3 SwizzZZX(VectorB4 V){ return MkVectorB3(V.z, V.z, V.x); }
inline VectorB3 SwizzZZY(VectorB4 V){ return MkVectorB3(V.z, V.z, V.y); }
inline VectorB3 SwizzZZZ(VectorB4 V){ return MkVectorB3(V.z, V.z, V.z); }
inline VectorB3 SwizzZZW(VectorB4 V){ return MkVectorB3(V.z, V.z, V.w); }
inline VectorB3 SwizzZZ_(VectorB4 V){ return MkVectorB3(V.z, V.z, 0); }
inline VectorB3 SwizzZWX(VectorB4 V){ return MkVectorB3(V.z, V.w, V.x); }
inline VectorB3 SwizzZWY(VectorB4 V){ return MkVectorB3(V.z, V.w, V.y); }
inline VectorB3 SwizzZWZ(VectorB4 V){ return MkVectorB3(V.z, V.w, V.z); }
inline VectorB3 SwizzZWW(VectorB4 V){ return MkVectorB3(V.z, V.w, V.w); }
inline VectorB3 SwizzZW_(VectorB4 V){ return MkVectorB3(V.z, V.w, 0); }
inline VectorB3 SwizzZ_X(VectorB4 V){ return MkVectorB3(V.z, 0, V.x); }
inline VectorB3 SwizzZ_Y(VectorB4 V){ return MkVectorB3(V.z, 0, V.y); }
inline VectorB3 SwizzZ_Z(VectorB4 V){ return MkVectorB3(V.z, 0, V.z); }
inline VectorB3 SwizzZ_W(VectorB4 V){ return MkVectorB3(V.z, 0, V.w); }
inline VectorB3 SwizzZ__(VectorB4 V){ return MkVectorB3(V.z, 0, 0); }
inline VectorB3 SwizzWXX(VectorB4 V){ return MkVectorB3(V.w, V.x, V.x); }
inline VectorB3 SwizzWXY(VectorB4 V){ return MkVectorB3(V.w, V.x, V.y); }
inline VectorB3 SwizzWXZ(VectorB4 V){ return MkVectorB3(V.w, V.x, V.z); }
inline VectorB3 SwizzWXW(VectorB4 V){ return MkVectorB3(V.w, V.x, V.w); }
inline VectorB3 SwizzWX_(VectorB4 V){ return MkVectorB3(V.w, V.x, 0); }
inline VectorB3 SwizzWYX(VectorB4 V){ return MkVectorB3(V.w, V.y, V.x); }
inline VectorB3 SwizzWYY(VectorB4 V){ return MkVectorB3(V.w, V.y, V.y); }
inline VectorB3 SwizzWYZ(VectorB4 V){ return MkVectorB3(V.w, V.y, V.z); }
inline VectorB3 SwizzWYW(VectorB4 V){ return MkVectorB3(V.w, V.y, V.w); }
inline VectorB3 SwizzWY_(VectorB4 V){ return MkVectorB3(V.w, V.y, 0); }
inline VectorB3 SwizzWZX(VectorB4 V){ return MkVectorB3(V.w, V.z, V.x); }
inline VectorB3 SwizzWZY(VectorB4 V){ return MkVectorB3(V.w, V.z, V.y); }
inline VectorB3 SwizzWZZ(VectorB4 V){ return MkVectorB3(V.w, V.z, V.z); }
inline VectorB3 SwizzWZW(VectorB4 V){ return MkVectorB3(V.w, V.z, V.w); }
inline VectorB3 SwizzWZ_(VectorB4 V){ return MkVectorB3(V.w, V.z, 0); }
inline VectorB3 SwizzWWX(VectorB4 V){ return MkVectorB3(V.w, V.w, V.x); }
inline VectorB3 SwizzWWY(VectorB4 V){ return MkVectorB3(V.w, V.w, V.y); }
inline VectorB3 SwizzWWZ(VectorB4 V){ return MkVectorB3(V.w, V.w, V.z); }
inline VectorB3 SwizzWWW(VectorB4 V){ return MkVectorB3(V.w, V.w, V.w); }
inline VectorB3 SwizzWW_(VectorB4 V){ return MkVectorB3(V.w, V.w, 0); }
inline VectorB3 SwizzW_X(VectorB4 V){ return MkVectorB3(V.w, 0, V.x); }
inline VectorB3 SwizzW_Y(VectorB4 V){ return MkVectorB3(V.w, 0, V.y); }
inline VectorB3 SwizzW_Z(VectorB4 V){ return MkVectorB3(V.w, 0, V.z); }
inline VectorB3 SwizzW_W(VectorB4 V){ return MkVectorB3(V.w, 0, V.w); }
inline VectorB3 SwizzW__(VectorB4 V){ return MkVectorB3(V.w, 0, 0); }
inline VectorB3 Swizz_XX(VectorB4 V){ return MkVectorB3(0, V.x, V.x); }
inline VectorB3 Swizz_XY(VectorB4 V){ return MkVectorB3(0, V.x, V.y); }
inline VectorB3 Swizz_XZ(VectorB4 V){ return MkVectorB3(0, V.x, V.z); }
inline VectorB3 Swizz_XW(VectorB4 V){ return MkVectorB3(0, V.x, V.w); }
inline VectorB3 Swizz_X_(VectorB4 V){ return MkVectorB3(0, V.x, 0); }
inline VectorB3 Swizz_YX(VectorB4 V){ return MkVectorB3(0, V.y, V.x); }
inline VectorB3 Swizz_YY(VectorB4 V){ return MkVectorB3(0, V.y, V.y); }
inline VectorB3 Swizz_YZ(VectorB4 V){ return MkVectorB3(0, V.y, V.z); }
inline VectorB3 Swizz_YW(VectorB4 V){ return MkVectorB3(0, V.y, V.w); }
inline VectorB3 Swizz_Y_(VectorB4 V){ return MkVectorB3(0, V.y, 0); }
inline VectorB3 Swizz_ZX(VectorB4 V){ return MkVectorB3(0, V.z, V.x); }
inline VectorB3 Swizz_ZY(VectorB4 V){ return MkVectorB3(0, V.z, V.y); }
inline VectorB3 Swizz_ZZ(VectorB4 V){ return MkVectorB3(0, V.z, V.z); }
inline VectorB3 Swizz_ZW(VectorB4 V){ return MkVectorB3(0, V.z, V.w); }
inline VectorB3 Swizz_Z_(VectorB4 V){ return MkVectorB3(0, V.z, 0); }
inline VectorB3 Swizz_WX(VectorB4 V){ return MkVectorB3(0, V.w, V.x); }
inline VectorB3 Swizz_WY(VectorB4 V){ return MkVectorB3(0, V.w, V.y); }
inline VectorB3 Swizz_WZ(VectorB4 V){ return MkVectorB3(0, V.w, V.z); }
inline VectorB3 Swizz_WW(VectorB4 V){ return MkVectorB3(0, V.w, V.w); }
inline VectorB3 Swizz_W_(VectorB4 V){ return MkVectorB3(0, V.w, 0); }
inline VectorB3 Swizz__X(VectorB4 V){ return MkVectorB3(0, 0, V.x); }
inline VectorB3 Swizz__Y(VectorB4 V){ return MkVectorB3(0, 0, V.y); }
inline VectorB3 Swizz__Z(VectorB4 V){ return MkVectorB3(0, 0, V.z); }
inline VectorB3 Swizz__W(VectorB4 V){ return MkVectorB3(0, 0, V.w); }
inline VectorB4 SwizzXXXX(VectorB4 V){ return MkVectorB4(V.x, V.x, V.x, V.x); }
inline VectorB4 SwizzXXXY(VectorB4 V){ return MkVectorB4(V.x, V.x, V.x, V.y); }
inline VectorB4 SwizzXXXZ(VectorB4 V){ return MkVectorB4(V.x, V.x, V.x, V.z); }
inline VectorB4 SwizzXXXW(VectorB4 V){ return MkVectorB4(V.x, V.x, V.x, V.w); }
inline VectorB4 SwizzXXX_(VectorB4 V){ return MkVectorB4(V.x, V.x, V.x, 0); }
inline VectorB4 SwizzXXYX(VectorB4 V){ return MkVectorB4(V.x, V.x, V.y, V.x); }
inline VectorB4 SwizzXXYY(VectorB4 V){ return MkVectorB4(V.x, V.x, V.y, V.y); }
inline VectorB4 SwizzXXYZ(VectorB4 V){ return MkVectorB4(V.x, V.x, V.y, V.z); }
inline VectorB4 SwizzXXYW(VectorB4 V){ return MkVectorB4(V.x, V.x, V.y, V.w); }
inline VectorB4 SwizzXXY_(VectorB4 V){ return MkVectorB4(V.x, V.x, V.y, 0); }
inline VectorB4 SwizzXXZX(VectorB4 V){ return MkVectorB4(V.x, V.x, V.z, V.x); }
inline VectorB4 SwizzXXZY(VectorB4 V){ return MkVectorB4(V.x, V.x, V.z, V.y); }
inline VectorB4 SwizzXXZZ(VectorB4 V){ return MkVectorB4(V.x, V.x, V.z, V.z); }
inline VectorB4 SwizzXXZW(VectorB4 V){ return MkVectorB4(V.x, V.x, V.z, V.w); }
inline VectorB4 SwizzXXZ_(VectorB4 V){ return MkVectorB4(V.x, V.x, V.z, 0); }
inline VectorB4 SwizzXXWX(VectorB4 V){ return MkVectorB4(V.x, V.x, V.w, V.x); }
inline VectorB4 SwizzXXWY(VectorB4 V){ return MkVectorB4(V.x, V.x, V.w, V.y); }
inline VectorB4 SwizzXXWZ(VectorB4 V){ return MkVectorB4(V.x, V.x, V.w, V.z); }
inline VectorB4 SwizzXXWW(VectorB4 V){ return MkVectorB4(V.x, V.x, V.w, V.w); }
inline VectorB4 SwizzXXW_(VectorB4 V){ return MkVectorB4(V.x, V.x, V.w, 0); }
inline VectorB4 SwizzXX_X(VectorB4 V){ return MkVectorB4(V.x, V.x, 0, V.x); }
inline VectorB4 SwizzXX_Y(VectorB4 V){ return MkVectorB4(V.x, V.x, 0, V.y); }
inline VectorB4 SwizzXX_Z(VectorB4 V){ return MkVectorB4(V.x, V.x, 0, V.z); }
inline VectorB4 SwizzXX_W(VectorB4 V){ return MkVectorB4(V.x, V.x, 0, V.w); }
inline VectorB4 SwizzXX__(VectorB4 V){ return MkVectorB4(V.x, V.x, 0, 0); }
inline VectorB4 SwizzXYXX(VectorB4 V){ return MkVectorB4(V.x, V.y, V.x, V.x); }
inline VectorB4 SwizzXYXY(VectorB4 V){ return MkVectorB4(V.x, V.y, V.x, V.y); }
inline VectorB4 SwizzXYXZ(VectorB4 V){ return MkVectorB4(V.x, V.y, V.x, V.z); }
inline VectorB4 SwizzXYXW(VectorB4 V){ return MkVectorB4(V.x, V.y, V.x, V.w); }
inline VectorB4 SwizzXYX_(VectorB4 V){ return MkVectorB4(V.x, V.y, V.x, 0); }
inline VectorB4 SwizzXYYX(VectorB4 V){ return MkVectorB4(V.x, V.y, V.y, V.x); }
inline VectorB4 SwizzXYYY(VectorB4 V){ return MkVectorB4(V.x, V.y, V.y, V.y); }
inline VectorB4 SwizzXYYZ(VectorB4 V){ return MkVectorB4(V.x, V.y, V.y, V.z); }
inline VectorB4 SwizzXYYW(VectorB4 V){ return MkVectorB4(V.x, V.y, V.y, V.w); }
inline VectorB4 SwizzXYY_(VectorB4 V){ return MkVectorB4(V.x, V.y, V.y, 0); }
inline VectorB4 SwizzXYZX(VectorB4 V){ return MkVectorB4(V.x, V.y, V.z, V.x); }
inline VectorB4 SwizzXYZY(VectorB4 V){ return MkVectorB4(V.x, V.y, V.z, V.y); }
inline VectorB4 SwizzXYZZ(VectorB4 V){ return MkVectorB4(V.x, V.y, V.z, V.z); }
inline VectorB4 SwizzXYZW(VectorB4 V){ return MkVectorB4(V.x, V.y, V.z, V.w); }
inline VectorB4 SwizzXYZ_(VectorB4 V){ return MkVectorB4(V.x, V.y, V.z, 0); }
inline VectorB4 SwizzXYWX(VectorB4 V){ return MkVectorB4(V.x, V.y, V.w, V.x); }
inline VectorB4 SwizzXYWY(VectorB4 V){ return MkVectorB4(V.x, V.y, V.w, V.y); }
inline VectorB4 SwizzXYWZ(VectorB4 V){ return MkVectorB4(V.x, V.y, V.w, V.z); }
inline VectorB4 SwizzXYWW(VectorB4 V){ return MkVectorB4(V.x, V.y, V.w, V.w); }
inline VectorB4 SwizzXYW_(VectorB4 V){ return MkVectorB4(V.x, V.y, V.w, 0); }
inline VectorB4 SwizzXY_X(VectorB4 V){ return MkVectorB4(V.x, V.y, 0, V.x); }
inline VectorB4 SwizzXY_Y(VectorB4 V){ return MkVectorB4(V.x, V.y, 0, V.y); }
inline VectorB4 SwizzXY_Z(VectorB4 V){ return MkVectorB4(V.x, V.y, 0, V.z); }
inline VectorB4 SwizzXY_W(VectorB4 V){ return MkVectorB4(V.x, V.y, 0, V.w); }
inline VectorB4 SwizzXY__(VectorB4 V){ return MkVectorB4(V.x, V.y, 0, 0); }
inline VectorB4 SwizzXZXX(VectorB4 V){ return MkVectorB4(V.x, V.z, V.x, V.x); }
inline VectorB4 SwizzXZXY(VectorB4 V){ return MkVectorB4(V.x, V.z, V.x, V.y); }
inline VectorB4 SwizzXZXZ(VectorB4 V){ return MkVectorB4(V.x, V.z, V.x, V.z); }
inline VectorB4 SwizzXZXW(VectorB4 V){ return MkVectorB4(V.x, V.z, V.x, V.w); }
inline VectorB4 SwizzXZX_(VectorB4 V){ return MkVectorB4(V.x, V.z, V.x, 0); }
inline VectorB4 SwizzXZYX(VectorB4 V){ return MkVectorB4(V.x, V.z, V.y, V.x); }
inline VectorB4 SwizzXZYY(VectorB4 V){ return MkVectorB4(V.x, V.z, V.y, V.y); }
inline VectorB4 SwizzXZYZ(VectorB4 V){ return MkVectorB4(V.x, V.z, V.y, V.z); }
inline VectorB4 SwizzXZYW(VectorB4 V){ return MkVectorB4(V.x, V.z, V.y, V.w); }
inline VectorB4 SwizzXZY_(VectorB4 V){ return MkVectorB4(V.x, V.z, V.y, 0); }
inline VectorB4 SwizzXZZX(VectorB4 V){ return MkVectorB4(V.x, V.z, V.z, V.x); }
inline VectorB4 SwizzXZZY(VectorB4 V){ return MkVectorB4(V.x, V.z, V.z, V.y); }
inline VectorB4 SwizzXZZZ(VectorB4 V){ return MkVectorB4(V.x, V.z, V.z, V.z); }
inline VectorB4 SwizzXZZW(VectorB4 V){ return MkVectorB4(V.x, V.z, V.z, V.w); }
inline VectorB4 SwizzXZZ_(VectorB4 V){ return MkVectorB4(V.x, V.z, V.z, 0); }
inline VectorB4 SwizzXZWX(VectorB4 V){ return MkVectorB4(V.x, V.z, V.w, V.x); }
inline VectorB4 SwizzXZWY(VectorB4 V){ return MkVectorB4(V.x, V.z, V.w, V.y); }
inline VectorB4 SwizzXZWZ(VectorB4 V){ return MkVectorB4(V.x, V.z, V.w, V.z); }
inline VectorB4 SwizzXZWW(VectorB4 V){ return MkVectorB4(V.x, V.z, V.w, V.w); }
inline VectorB4 SwizzXZW_(VectorB4 V){ return MkVectorB4(V.x, V.z, V.w, 0); }
inline VectorB4 SwizzXZ_X(VectorB4 V){ return MkVectorB4(V.x, V.z, 0, V.x); }
inline VectorB4 SwizzXZ_Y(VectorB4 V){ return MkVectorB4(V.x, V.z, 0, V.y); }
inline VectorB4 SwizzXZ_Z(VectorB4 V){ return MkVectorB4(V.x, V.z, 0, V.z); }
inline VectorB4 SwizzXZ_W(VectorB4 V){ return MkVectorB4(V.x, V.z, 0, V.w); }
inline VectorB4 SwizzXZ__(VectorB4 V){ return MkVectorB4(V.x, V.z, 0, 0); }
inline VectorB4 SwizzXWXX(VectorB4 V){ return MkVectorB4(V.x, V.w, V.x, V.x); }
inline VectorB4 SwizzXWXY(VectorB4 V){ return MkVectorB4(V.x, V.w, V.x, V.y); }
inline VectorB4 SwizzXWXZ(VectorB4 V){ return MkVectorB4(V.x, V.w, V.x, V.z); }
inline VectorB4 SwizzXWXW(VectorB4 V){ return MkVectorB4(V.x, V.w, V.x, V.w); }
inline VectorB4 SwizzXWX_(VectorB4 V){ return MkVectorB4(V.x, V.w, V.x, 0); }
inline VectorB4 SwizzXWYX(VectorB4 V){ return MkVectorB4(V.x, V.w, V.y, V.x); }
inline VectorB4 SwizzXWYY(VectorB4 V){ return MkVectorB4(V.x, V.w, V.y, V.y); }
inline VectorB4 SwizzXWYZ(VectorB4 V){ return MkVectorB4(V.x, V.w, V.y, V.z); }
inline VectorB4 SwizzXWYW(VectorB4 V){ return MkVectorB4(V.x, V.w, V.y, V.w); }
inline VectorB4 SwizzXWY_(VectorB4 V){ return MkVectorB4(V.x, V.w, V.y, 0); }
inline VectorB4 SwizzXWZX(VectorB4 V){ return MkVectorB4(V.x, V.w, V.z, V.x); }
inline VectorB4 SwizzXWZY(VectorB4 V){ return MkVectorB4(V.x, V.w, V.z, V.y); }
inline VectorB4 SwizzXWZZ(VectorB4 V){ return MkVectorB4(V.x, V.w, V.z, V.z); }
inline VectorB4 SwizzXWZW(VectorB4 V){ return MkVectorB4(V.x, V.w, V.z, V.w); }
inline VectorB4 SwizzXWZ_(VectorB4 V){ return MkVectorB4(V.x, V.w, V.z, 0); }
inline VectorB4 SwizzXWWX(VectorB4 V){ return MkVectorB4(V.x, V.w, V.w, V.x); }
inline VectorB4 SwizzXWWY(VectorB4 V){ return MkVectorB4(V.x, V.w, V.w, V.y); }
inline VectorB4 SwizzXWWZ(VectorB4 V){ return MkVectorB4(V.x, V.w, V.w, V.z); }
inline VectorB4 SwizzXWWW(VectorB4 V){ return MkVectorB4(V.x, V.w, V.w, V.w); }
inline VectorB4 SwizzXWW_(VectorB4 V){ return MkVectorB4(V.x, V.w, V.w, 0); }
inline VectorB4 SwizzXW_X(VectorB4 V){ return MkVectorB4(V.x, V.w, 0, V.x); }
inline VectorB4 SwizzXW_Y(VectorB4 V){ return MkVectorB4(V.x, V.w, 0, V.y); }
inline VectorB4 SwizzXW_Z(VectorB4 V){ return MkVectorB4(V.x, V.w, 0, V.z); }
inline VectorB4 SwizzXW_W(VectorB4 V){ return MkVectorB4(V.x, V.w, 0, V.w); }
inline VectorB4 SwizzXW__(VectorB4 V){ return MkVectorB4(V.x, V.w, 0, 0); }
inline VectorB4 SwizzX_XX(VectorB4 V){ return MkVectorB4(V.x, 0, V.x, V.x); }
inline VectorB4 SwizzX_XY(VectorB4 V){ return MkVectorB4(V.x, 0, V.x, V.y); }
inline VectorB4 SwizzX_XZ(VectorB4 V){ return MkVectorB4(V.x, 0, V.x, V.z); }
inline VectorB4 SwizzX_XW(VectorB4 V){ return MkVectorB4(V.x, 0, V.x, V.w); }
inline VectorB4 SwizzX_X_(VectorB4 V){ return MkVectorB4(V.x, 0, V.x, 0); }
inline VectorB4 SwizzX_YX(VectorB4 V){ return MkVectorB4(V.x, 0, V.y, V.x); }
inline VectorB4 SwizzX_YY(VectorB4 V){ return MkVectorB4(V.x, 0, V.y, V.y); }
inline VectorB4 SwizzX_YZ(VectorB4 V){ return MkVectorB4(V.x, 0, V.y, V.z); }
inline VectorB4 SwizzX_YW(VectorB4 V){ return MkVectorB4(V.x, 0, V.y, V.w); }
inline VectorB4 SwizzX_Y_(VectorB4 V){ return MkVectorB4(V.x, 0, V.y, 0); }
inline VectorB4 SwizzX_ZX(VectorB4 V){ return MkVectorB4(V.x, 0, V.z, V.x); }
inline VectorB4 SwizzX_ZY(VectorB4 V){ return MkVectorB4(V.x, 0, V.z, V.y); }
inline VectorB4 SwizzX_ZZ(VectorB4 V){ return MkVectorB4(V.x, 0, V.z, V.z); }
inline VectorB4 SwizzX_ZW(VectorB4 V){ return MkVectorB4(V.x, 0, V.z, V.w); }
inline VectorB4 SwizzX_Z_(VectorB4 V){ return MkVectorB4(V.x, 0, V.z, 0); }
inline VectorB4 SwizzX_WX(VectorB4 V){ return MkVectorB4(V.x, 0, V.w, V.x); }
inline VectorB4 SwizzX_WY(VectorB4 V){ return MkVectorB4(V.x, 0, V.w, V.y); }
inline VectorB4 SwizzX_WZ(VectorB4 V){ return MkVectorB4(V.x, 0, V.w, V.z); }
inline VectorB4 SwizzX_WW(VectorB4 V){ return MkVectorB4(V.x, 0, V.w, V.w); }
inline VectorB4 SwizzX_W_(VectorB4 V){ return MkVectorB4(V.x, 0, V.w, 0); }
inline VectorB4 SwizzX__X(VectorB4 V){ return MkVectorB4(V.x, 0, 0, V.x); }
inline VectorB4 SwizzX__Y(VectorB4 V){ return MkVectorB4(V.x, 0, 0, V.y); }
inline VectorB4 SwizzX__Z(VectorB4 V){ return MkVectorB4(V.x, 0, 0, V.z); }
inline VectorB4 SwizzX__W(VectorB4 V){ return MkVectorB4(V.x, 0, 0, V.w); }
inline VectorB4 SwizzX___(VectorB4 V){ return MkVectorB4(V.x, 0, 0, 0); }
inline VectorB4 SwizzYXXX(VectorB4 V){ return MkVectorB4(V.y, V.x, V.x, V.x); }
inline VectorB4 SwizzYXXY(VectorB4 V){ return MkVectorB4(V.y, V.x, V.x, V.y); }
inline VectorB4 SwizzYXXZ(VectorB4 V){ return MkVectorB4(V.y, V.x, V.x, V.z); }
inline VectorB4 SwizzYXXW(VectorB4 V){ return MkVectorB4(V.y, V.x, V.x, V.w); }
inline VectorB4 SwizzYXX_(VectorB4 V){ return MkVectorB4(V.y, V.x, V.x, 0); }
inline VectorB4 SwizzYXYX(VectorB4 V){ return MkVectorB4(V.y, V.x, V.y, V.x); }
inline VectorB4 SwizzYXYY(VectorB4 V){ return MkVectorB4(V.y, V.x, V.y, V.y); }
inline VectorB4 SwizzYXYZ(VectorB4 V){ return MkVectorB4(V.y, V.x, V.y, V.z); }
inline VectorB4 SwizzYXYW(VectorB4 V){ return MkVectorB4(V.y, V.x, V.y, V.w); }
inline VectorB4 SwizzYXY_(VectorB4 V){ return MkVectorB4(V.y, V.x, V.y, 0); }
inline VectorB4 SwizzYXZX(VectorB4 V){ return MkVectorB4(V.y, V.x, V.z, V.x); }
inline VectorB4 SwizzYXZY(VectorB4 V){ return MkVectorB4(V.y, V.x, V.z, V.y); }
inline VectorB4 SwizzYXZZ(VectorB4 V){ return MkVectorB4(V.y, V.x, V.z, V.z); }
inline VectorB4 SwizzYXZW(VectorB4 V){ return MkVectorB4(V.y, V.x, V.z, V.w); }
inline VectorB4 SwizzYXZ_(VectorB4 V){ return MkVectorB4(V.y, V.x, V.z, 0); }
inline VectorB4 SwizzYXWX(VectorB4 V){ return MkVectorB4(V.y, V.x, V.w, V.x); }
inline VectorB4 SwizzYXWY(VectorB4 V){ return MkVectorB4(V.y, V.x, V.w, V.y); }
inline VectorB4 SwizzYXWZ(VectorB4 V){ return MkVectorB4(V.y, V.x, V.w, V.z); }
inline VectorB4 SwizzYXWW(VectorB4 V){ return MkVectorB4(V.y, V.x, V.w, V.w); }
inline VectorB4 SwizzYXW_(VectorB4 V){ return MkVectorB4(V.y, V.x, V.w, 0); }
inline VectorB4 SwizzYX_X(VectorB4 V){ return MkVectorB4(V.y, V.x, 0, V.x); }
inline VectorB4 SwizzYX_Y(VectorB4 V){ return MkVectorB4(V.y, V.x, 0, V.y); }
inline VectorB4 SwizzYX_Z(VectorB4 V){ return MkVectorB4(V.y, V.x, 0, V.z); }
inline VectorB4 SwizzYX_W(VectorB4 V){ return MkVectorB4(V.y, V.x, 0, V.w); }
inline VectorB4 SwizzYX__(VectorB4 V){ return MkVectorB4(V.y, V.x, 0, 0); }
inline VectorB4 SwizzYYXX(VectorB4 V){ return MkVectorB4(V.y, V.y, V.x, V.x); }
inline VectorB4 SwizzYYXY(VectorB4 V){ return MkVectorB4(V.y, V.y, V.x, V.y); }
inline VectorB4 SwizzYYXZ(VectorB4 V){ return MkVectorB4(V.y, V.y, V.x, V.z); }
inline VectorB4 SwizzYYXW(VectorB4 V){ return MkVectorB4(V.y, V.y, V.x, V.w); }
inline VectorB4 SwizzYYX_(VectorB4 V){ return MkVectorB4(V.y, V.y, V.x, 0); }
inline VectorB4 SwizzYYYX(VectorB4 V){ return MkVectorB4(V.y, V.y, V.y, V.x); }
inline VectorB4 SwizzYYYY(VectorB4 V){ return MkVectorB4(V.y, V.y, V.y, V.y); }
inline VectorB4 SwizzYYYZ(VectorB4 V){ return MkVectorB4(V.y, V.y, V.y, V.z); }
inline VectorB4 SwizzYYYW(VectorB4 V){ return MkVectorB4(V.y, V.y, V.y, V.w); }
inline VectorB4 SwizzYYY_(VectorB4 V){ return MkVectorB4(V.y, V.y, V.y, 0); }
inline VectorB4 SwizzYYZX(VectorB4 V){ return MkVectorB4(V.y, V.y, V.z, V.x); }
inline VectorB4 SwizzYYZY(VectorB4 V){ return MkVectorB4(V.y, V.y, V.z, V.y); }
inline VectorB4 SwizzYYZZ(VectorB4 V){ return MkVectorB4(V.y, V.y, V.z, V.z); }
inline VectorB4 SwizzYYZW(VectorB4 V){ return MkVectorB4(V.y, V.y, V.z, V.w); }
inline VectorB4 SwizzYYZ_(VectorB4 V){ return MkVectorB4(V.y, V.y, V.z, 0); }
inline VectorB4 SwizzYYWX(VectorB4 V){ return MkVectorB4(V.y, V.y, V.w, V.x); }
inline VectorB4 SwizzYYWY(VectorB4 V){ return MkVectorB4(V.y, V.y, V.w, V.y); }
inline VectorB4 SwizzYYWZ(VectorB4 V){ return MkVectorB4(V.y, V.y, V.w, V.z); }
inline VectorB4 SwizzYYWW(VectorB4 V){ return MkVectorB4(V.y, V.y, V.w, V.w); }
inline VectorB4 SwizzYYW_(VectorB4 V){ return MkVectorB4(V.y, V.y, V.w, 0); }
inline VectorB4 SwizzYY_X(VectorB4 V){ return MkVectorB4(V.y, V.y, 0, V.x); }
inline VectorB4 SwizzYY_Y(VectorB4 V){ return MkVectorB4(V.y, V.y, 0, V.y); }
inline VectorB4 SwizzYY_Z(VectorB4 V){ return MkVectorB4(V.y, V.y, 0, V.z); }
inline VectorB4 SwizzYY_W(VectorB4 V){ return MkVectorB4(V.y, V.y, 0, V.w); }
inline VectorB4 SwizzYY__(VectorB4 V){ return MkVectorB4(V.y, V.y, 0, 0); }
inline VectorB4 SwizzYZXX(VectorB4 V){ return MkVectorB4(V.y, V.z, V.x, V.x); }
inline VectorB4 SwizzYZXY(VectorB4 V){ return MkVectorB4(V.y, V.z, V.x, V.y); }
inline VectorB4 SwizzYZXZ(VectorB4 V){ return MkVectorB4(V.y, V.z, V.x, V.z); }
inline VectorB4 SwizzYZXW(VectorB4 V){ return MkVectorB4(V.y, V.z, V.x, V.w); }
inline VectorB4 SwizzYZX_(VectorB4 V){ return MkVectorB4(V.y, V.z, V.x, 0); }
inline VectorB4 SwizzYZYX(VectorB4 V){ return MkVectorB4(V.y, V.z, V.y, V.x); }
inline VectorB4 SwizzYZYY(VectorB4 V){ return MkVectorB4(V.y, V.z, V.y, V.y); }
inline VectorB4 SwizzYZYZ(VectorB4 V){ return MkVectorB4(V.y, V.z, V.y, V.z); }
inline VectorB4 SwizzYZYW(VectorB4 V){ return MkVectorB4(V.y, V.z, V.y, V.w); }
inline VectorB4 SwizzYZY_(VectorB4 V){ return MkVectorB4(V.y, V.z, V.y, 0); }
inline VectorB4 SwizzYZZX(VectorB4 V){ return MkVectorB4(V.y, V.z, V.z, V.x); }
inline VectorB4 SwizzYZZY(VectorB4 V){ return MkVectorB4(V.y, V.z, V.z, V.y); }
inline VectorB4 SwizzYZZZ(VectorB4 V){ return MkVectorB4(V.y, V.z, V.z, V.z); }
inline VectorB4 SwizzYZZW(VectorB4 V){ return MkVectorB4(V.y, V.z, V.z, V.w); }
inline VectorB4 SwizzYZZ_(VectorB4 V){ return MkVectorB4(V.y, V.z, V.z, 0); }
inline VectorB4 SwizzYZWX(VectorB4 V){ return MkVectorB4(V.y, V.z, V.w, V.x); }
inline VectorB4 SwizzYZWY(VectorB4 V){ return MkVectorB4(V.y, V.z, V.w, V.y); }
inline VectorB4 SwizzYZWZ(VectorB4 V){ return MkVectorB4(V.y, V.z, V.w, V.z); }
inline VectorB4 SwizzYZWW(VectorB4 V){ return MkVectorB4(V.y, V.z, V.w, V.w); }
inline VectorB4 SwizzYZW_(VectorB4 V){ return MkVectorB4(V.y, V.z, V.w, 0); }
inline VectorB4 SwizzYZ_X(VectorB4 V){ return MkVectorB4(V.y, V.z, 0, V.x); }
inline VectorB4 SwizzYZ_Y(VectorB4 V){ return MkVectorB4(V.y, V.z, 0, V.y); }
inline VectorB4 SwizzYZ_Z(VectorB4 V){ return MkVectorB4(V.y, V.z, 0, V.z); }
inline VectorB4 SwizzYZ_W(VectorB4 V){ return MkVectorB4(V.y, V.z, 0, V.w); }
inline VectorB4 SwizzYZ__(VectorB4 V){ return MkVectorB4(V.y, V.z, 0, 0); }
inline VectorB4 SwizzYWXX(VectorB4 V){ return MkVectorB4(V.y, V.w, V.x, V.x); }
inline VectorB4 SwizzYWXY(VectorB4 V){ return MkVectorB4(V.y, V.w, V.x, V.y); }
inline VectorB4 SwizzYWXZ(VectorB4 V){ return MkVectorB4(V.y, V.w, V.x, V.z); }
inline VectorB4 SwizzYWXW(VectorB4 V){ return MkVectorB4(V.y, V.w, V.x, V.w); }
inline VectorB4 SwizzYWX_(VectorB4 V){ return MkVectorB4(V.y, V.w, V.x, 0); }
inline VectorB4 SwizzYWYX(VectorB4 V){ return MkVectorB4(V.y, V.w, V.y, V.x); }
inline VectorB4 SwizzYWYY(VectorB4 V){ return MkVectorB4(V.y, V.w, V.y, V.y); }
inline VectorB4 SwizzYWYZ(VectorB4 V){ return MkVectorB4(V.y, V.w, V.y, V.z); }
inline VectorB4 SwizzYWYW(VectorB4 V){ return MkVectorB4(V.y, V.w, V.y, V.w); }
inline VectorB4 SwizzYWY_(VectorB4 V){ return MkVectorB4(V.y, V.w, V.y, 0); }
inline VectorB4 SwizzYWZX(VectorB4 V){ return MkVectorB4(V.y, V.w, V.z, V.x); }
inline VectorB4 SwizzYWZY(VectorB4 V){ return MkVectorB4(V.y, V.w, V.z, V.y); }
inline VectorB4 SwizzYWZZ(VectorB4 V){ return MkVectorB4(V.y, V.w, V.z, V.z); }
inline VectorB4 SwizzYWZW(VectorB4 V){ return MkVectorB4(V.y, V.w, V.z, V.w); }
inline VectorB4 SwizzYWZ_(VectorB4 V){ return MkVectorB4(V.y, V.w, V.z, 0); }
inline VectorB4 SwizzYWWX(VectorB4 V){ return MkVectorB4(V.y, V.w, V.w, V.x); }
inline VectorB4 SwizzYWWY(VectorB4 V){ return MkVectorB4(V.y, V.w, V.w, V.y); }
inline VectorB4 SwizzYWWZ(VectorB4 V){ return MkVectorB4(V.y, V.w, V.w, V.z); }
inline VectorB4 SwizzYWWW(VectorB4 V){ return MkVectorB4(V.y, V.w, V.w, V.w); }
inline VectorB4 SwizzYWW_(VectorB4 V){ return MkVectorB4(V.y, V.w, V.w, 0); }
inline VectorB4 SwizzYW_X(VectorB4 V){ return MkVectorB4(V.y, V.w, 0, V.x); }
inline VectorB4 SwizzYW_Y(VectorB4 V){ return MkVectorB4(V.y, V.w, 0, V.y); }
inline VectorB4 SwizzYW_Z(VectorB4 V){ return MkVectorB4(V.y, V.w, 0, V.z); }
inline VectorB4 SwizzYW_W(VectorB4 V){ return MkVectorB4(V.y, V.w, 0, V.w); }
inline VectorB4 SwizzYW__(VectorB4 V){ return MkVectorB4(V.y, V.w, 0, 0); }
inline VectorB4 SwizzY_XX(VectorB4 V){ return MkVectorB4(V.y, 0, V.x, V.x); }
inline VectorB4 SwizzY_XY(VectorB4 V){ return MkVectorB4(V.y, 0, V.x, V.y); }
inline VectorB4 SwizzY_XZ(VectorB4 V){ return MkVectorB4(V.y, 0, V.x, V.z); }
inline VectorB4 SwizzY_XW(VectorB4 V){ return MkVectorB4(V.y, 0, V.x, V.w); }
inline VectorB4 SwizzY_X_(VectorB4 V){ return MkVectorB4(V.y, 0, V.x, 0); }
inline VectorB4 SwizzY_YX(VectorB4 V){ return MkVectorB4(V.y, 0, V.y, V.x); }
inline VectorB4 SwizzY_YY(VectorB4 V){ return MkVectorB4(V.y, 0, V.y, V.y); }
inline VectorB4 SwizzY_YZ(VectorB4 V){ return MkVectorB4(V.y, 0, V.y, V.z); }
inline VectorB4 SwizzY_YW(VectorB4 V){ return MkVectorB4(V.y, 0, V.y, V.w); }
inline VectorB4 SwizzY_Y_(VectorB4 V){ return MkVectorB4(V.y, 0, V.y, 0); }
inline VectorB4 SwizzY_ZX(VectorB4 V){ return MkVectorB4(V.y, 0, V.z, V.x); }
inline VectorB4 SwizzY_ZY(VectorB4 V){ return MkVectorB4(V.y, 0, V.z, V.y); }
inline VectorB4 SwizzY_ZZ(VectorB4 V){ return MkVectorB4(V.y, 0, V.z, V.z); }
inline VectorB4 SwizzY_ZW(VectorB4 V){ return MkVectorB4(V.y, 0, V.z, V.w); }
inline VectorB4 SwizzY_Z_(VectorB4 V){ return MkVectorB4(V.y, 0, V.z, 0); }
inline VectorB4 SwizzY_WX(VectorB4 V){ return MkVectorB4(V.y, 0, V.w, V.x); }
inline VectorB4 SwizzY_WY(VectorB4 V){ return MkVectorB4(V.y, 0, V.w, V.y); }
inline VectorB4 SwizzY_WZ(VectorB4 V){ return MkVectorB4(V.y, 0, V.w, V.z); }
inline VectorB4 SwizzY_WW(VectorB4 V){ return MkVectorB4(V.y, 0, V.w, V.w); }
inline VectorB4 SwizzY_W_(VectorB4 V){ return MkVectorB4(V.y, 0, V.w, 0); }
inline VectorB4 SwizzY__X(VectorB4 V){ return MkVectorB4(V.y, 0, 0, V.x); }
inline VectorB4 SwizzY__Y(VectorB4 V){ return MkVectorB4(V.y, 0, 0, V.y); }
inline VectorB4 SwizzY__Z(VectorB4 V){ return MkVectorB4(V.y, 0, 0, V.z); }
inline VectorB4 SwizzY__W(VectorB4 V){ return MkVectorB4(V.y, 0, 0, V.w); }
inline VectorB4 SwizzY___(VectorB4 V){ return MkVectorB4(V.y, 0, 0, 0); }
inline VectorB4 SwizzZXXX(VectorB4 V){ return MkVectorB4(V.z, V.x, V.x, V.x); }
inline VectorB4 SwizzZXXY(VectorB4 V){ return MkVectorB4(V.z, V.x, V.x, V.y); }
inline VectorB4 SwizzZXXZ(VectorB4 V){ return MkVectorB4(V.z, V.x, V.x, V.z); }
inline VectorB4 SwizzZXXW(VectorB4 V){ return MkVectorB4(V.z, V.x, V.x, V.w); }
inline VectorB4 SwizzZXX_(VectorB4 V){ return MkVectorB4(V.z, V.x, V.x, 0); }
inline VectorB4 SwizzZXYX(VectorB4 V){ return MkVectorB4(V.z, V.x, V.y, V.x); }
inline VectorB4 SwizzZXYY(VectorB4 V){ return MkVectorB4(V.z, V.x, V.y, V.y); }
inline VectorB4 SwizzZXYZ(VectorB4 V){ return MkVectorB4(V.z, V.x, V.y, V.z); }
inline VectorB4 SwizzZXYW(VectorB4 V){ return MkVectorB4(V.z, V.x, V.y, V.w); }
inline VectorB4 SwizzZXY_(VectorB4 V){ return MkVectorB4(V.z, V.x, V.y, 0); }
inline VectorB4 SwizzZXZX(VectorB4 V){ return MkVectorB4(V.z, V.x, V.z, V.x); }
inline VectorB4 SwizzZXZY(VectorB4 V){ return MkVectorB4(V.z, V.x, V.z, V.y); }
inline VectorB4 SwizzZXZZ(VectorB4 V){ return MkVectorB4(V.z, V.x, V.z, V.z); }
inline VectorB4 SwizzZXZW(VectorB4 V){ return MkVectorB4(V.z, V.x, V.z, V.w); }
inline VectorB4 SwizzZXZ_(VectorB4 V){ return MkVectorB4(V.z, V.x, V.z, 0); }
inline VectorB4 SwizzZXWX(VectorB4 V){ return MkVectorB4(V.z, V.x, V.w, V.x); }
inline VectorB4 SwizzZXWY(VectorB4 V){ return MkVectorB4(V.z, V.x, V.w, V.y); }
inline VectorB4 SwizzZXWZ(VectorB4 V){ return MkVectorB4(V.z, V.x, V.w, V.z); }
inline VectorB4 SwizzZXWW(VectorB4 V){ return MkVectorB4(V.z, V.x, V.w, V.w); }
inline VectorB4 SwizzZXW_(VectorB4 V){ return MkVectorB4(V.z, V.x, V.w, 0); }
inline VectorB4 SwizzZX_X(VectorB4 V){ return MkVectorB4(V.z, V.x, 0, V.x); }
inline VectorB4 SwizzZX_Y(VectorB4 V){ return MkVectorB4(V.z, V.x, 0, V.y); }
inline VectorB4 SwizzZX_Z(VectorB4 V){ return MkVectorB4(V.z, V.x, 0, V.z); }
inline VectorB4 SwizzZX_W(VectorB4 V){ return MkVectorB4(V.z, V.x, 0, V.w); }
inline VectorB4 SwizzZX__(VectorB4 V){ return MkVectorB4(V.z, V.x, 0, 0); }
inline VectorB4 SwizzZYXX(VectorB4 V){ return MkVectorB4(V.z, V.y, V.x, V.x); }
inline VectorB4 SwizzZYXY(VectorB4 V){ return MkVectorB4(V.z, V.y, V.x, V.y); }
inline VectorB4 SwizzZYXZ(VectorB4 V){ return MkVectorB4(V.z, V.y, V.x, V.z); }
inline VectorB4 SwizzZYXW(VectorB4 V){ return MkVectorB4(V.z, V.y, V.x, V.w); }
inline VectorB4 SwizzZYX_(VectorB4 V){ return MkVectorB4(V.z, V.y, V.x, 0); }
inline VectorB4 SwizzZYYX(VectorB4 V){ return MkVectorB4(V.z, V.y, V.y, V.x); }
inline VectorB4 SwizzZYYY(VectorB4 V){ return MkVectorB4(V.z, V.y, V.y, V.y); }
inline VectorB4 SwizzZYYZ(VectorB4 V){ return MkVectorB4(V.z, V.y, V.y, V.z); }
inline VectorB4 SwizzZYYW(VectorB4 V){ return MkVectorB4(V.z, V.y, V.y, V.w); }
inline VectorB4 SwizzZYY_(VectorB4 V){ return MkVectorB4(V.z, V.y, V.y, 0); }
inline VectorB4 SwizzZYZX(VectorB4 V){ return MkVectorB4(V.z, V.y, V.z, V.x); }
inline VectorB4 SwizzZYZY(VectorB4 V){ return MkVectorB4(V.z, V.y, V.z, V.y); }
inline VectorB4 SwizzZYZZ(VectorB4 V){ return MkVectorB4(V.z, V.y, V.z, V.z); }
inline VectorB4 SwizzZYZW(VectorB4 V){ return MkVectorB4(V.z, V.y, V.z, V.w); }
inline VectorB4 SwizzZYZ_(VectorB4 V){ return MkVectorB4(V.z, V.y, V.z, 0); }
inline VectorB4 SwizzZYWX(VectorB4 V){ return MkVectorB4(V.z, V.y, V.w, V.x); }
inline VectorB4 SwizzZYWY(VectorB4 V){ return MkVectorB4(V.z, V.y, V.w, V.y); }
inline VectorB4 SwizzZYWZ(VectorB4 V){ return MkVectorB4(V.z, V.y, V.w, V.z); }
inline VectorB4 SwizzZYWW(VectorB4 V){ return MkVectorB4(V.z, V.y, V.w, V.w); }
inline VectorB4 SwizzZYW_(VectorB4 V){ return MkVectorB4(V.z, V.y, V.w, 0); }
inline VectorB4 SwizzZY_X(VectorB4 V){ return MkVectorB4(V.z, V.y, 0, V.x); }
inline VectorB4 SwizzZY_Y(VectorB4 V){ return MkVectorB4(V.z, V.y, 0, V.y); }
inline VectorB4 SwizzZY_Z(VectorB4 V){ return MkVectorB4(V.z, V.y, 0, V.z); }
inline VectorB4 SwizzZY_W(VectorB4 V){ return MkVectorB4(V.z, V.y, 0, V.w); }
inline VectorB4 SwizzZY__(VectorB4 V){ return MkVectorB4(V.z, V.y, 0, 0); }
inline VectorB4 SwizzZZXX(VectorB4 V){ return MkVectorB4(V.z, V.z, V.x, V.x); }
inline VectorB4 SwizzZZXY(VectorB4 V){ return MkVectorB4(V.z, V.z, V.x, V.y); }
inline VectorB4 SwizzZZXZ(VectorB4 V){ return MkVectorB4(V.z, V.z, V.x, V.z); }
inline VectorB4 SwizzZZXW(VectorB4 V){ return MkVectorB4(V.z, V.z, V.x, V.w); }
inline VectorB4 SwizzZZX_(VectorB4 V){ return MkVectorB4(V.z, V.z, V.x, 0); }
inline VectorB4 SwizzZZYX(VectorB4 V){ return MkVectorB4(V.z, V.z, V.y, V.x); }
inline VectorB4 SwizzZZYY(VectorB4 V){ return MkVectorB4(V.z, V.z, V.y, V.y); }
inline VectorB4 SwizzZZYZ(VectorB4 V){ return MkVectorB4(V.z, V.z, V.y, V.z); }
inline VectorB4 SwizzZZYW(VectorB4 V){ return MkVectorB4(V.z, V.z, V.y, V.w); }
inline VectorB4 SwizzZZY_(VectorB4 V){ return MkVectorB4(V.z, V.z, V.y, 0); }
inline VectorB4 SwizzZZZX(VectorB4 V){ return MkVectorB4(V.z, V.z, V.z, V.x); }
inline VectorB4 SwizzZZZY(VectorB4 V){ return MkVectorB4(V.z, V.z, V.z, V.y); }
inline VectorB4 SwizzZZZZ(VectorB4 V){ return MkVectorB4(V.z, V.z, V.z, V.z); }
inline VectorB4 SwizzZZZW(VectorB4 V){ return MkVectorB4(V.z, V.z, V.z, V.w); }
inline VectorB4 SwizzZZZ_(VectorB4 V){ return MkVectorB4(V.z, V.z, V.z, 0); }
inline VectorB4 SwizzZZWX(VectorB4 V){ return MkVectorB4(V.z, V.z, V.w, V.x); }
inline VectorB4 SwizzZZWY(VectorB4 V){ return MkVectorB4(V.z, V.z, V.w, V.y); }
inline VectorB4 SwizzZZWZ(VectorB4 V){ return MkVectorB4(V.z, V.z, V.w, V.z); }
inline VectorB4 SwizzZZWW(VectorB4 V){ return MkVectorB4(V.z, V.z, V.w, V.w); }
inline VectorB4 SwizzZZW_(VectorB4 V){ return MkVectorB4(V.z, V.z, V.w, 0); }
inline VectorB4 SwizzZZ_X(VectorB4 V){ return MkVectorB4(V.z, V.z, 0, V.x); }
inline VectorB4 SwizzZZ_Y(VectorB4 V){ return MkVectorB4(V.z, V.z, 0, V.y); }
inline VectorB4 SwizzZZ_Z(VectorB4 V){ return MkVectorB4(V.z, V.z, 0, V.z); }
inline VectorB4 SwizzZZ_W(VectorB4 V){ return MkVectorB4(V.z, V.z, 0, V.w); }
inline VectorB4 SwizzZZ__(VectorB4 V){ return MkVectorB4(V.z, V.z, 0, 0); }
inline VectorB4 SwizzZWXX(VectorB4 V){ return MkVectorB4(V.z, V.w, V.x, V.x); }
inline VectorB4 SwizzZWXY(VectorB4 V){ return MkVectorB4(V.z, V.w, V.x, V.y); }
inline VectorB4 SwizzZWXZ(VectorB4 V){ return MkVectorB4(V.z, V.w, V.x, V.z); }
inline VectorB4 SwizzZWXW(VectorB4 V){ return MkVectorB4(V.z, V.w, V.x, V.w); }
inline VectorB4 SwizzZWX_(VectorB4 V){ return MkVectorB4(V.z, V.w, V.x, 0); }
inline VectorB4 SwizzZWYX(VectorB4 V){ return MkVectorB4(V.z, V.w, V.y, V.x); }
inline VectorB4 SwizzZWYY(VectorB4 V){ return MkVectorB4(V.z, V.w, V.y, V.y); }
inline VectorB4 SwizzZWYZ(VectorB4 V){ return MkVectorB4(V.z, V.w, V.y, V.z); }
inline VectorB4 SwizzZWYW(VectorB4 V){ return MkVectorB4(V.z, V.w, V.y, V.w); }
inline VectorB4 SwizzZWY_(VectorB4 V){ return MkVectorB4(V.z, V.w, V.y, 0); }
inline VectorB4 SwizzZWZX(VectorB4 V){ return MkVectorB4(V.z, V.w, V.z, V.x); }
inline VectorB4 SwizzZWZY(VectorB4 V){ return MkVectorB4(V.z, V.w, V.z, V.y); }
inline VectorB4 SwizzZWZZ(VectorB4 V){ return MkVectorB4(V.z, V.w, V.z, V.z); }
inline VectorB4 SwizzZWZW(VectorB4 V){ return MkVectorB4(V.z, V.w, V.z, V.w); }
inline VectorB4 SwizzZWZ_(VectorB4 V){ return MkVectorB4(V.z, V.w, V.z, 0); }
inline VectorB4 SwizzZWWX(VectorB4 V){ return MkVectorB4(V.z, V.w, V.w, V.x); }
inline VectorB4 SwizzZWWY(VectorB4 V){ return MkVectorB4(V.z, V.w, V.w, V.y); }
inline VectorB4 SwizzZWWZ(VectorB4 V){ return MkVectorB4(V.z, V.w, V.w, V.z); }
inline VectorB4 SwizzZWWW(VectorB4 V){ return MkVectorB4(V.z, V.w, V.w, V.w); }
inline VectorB4 SwizzZWW_(VectorB4 V){ return MkVectorB4(V.z, V.w, V.w, 0); }
inline VectorB4 SwizzZW_X(VectorB4 V){ return MkVectorB4(V.z, V.w, 0, V.x); }
inline VectorB4 SwizzZW_Y(VectorB4 V){ return MkVectorB4(V.z, V.w, 0, V.y); }
inline VectorB4 SwizzZW_Z(VectorB4 V){ return MkVectorB4(V.z, V.w, 0, V.z); }
inline VectorB4 SwizzZW_W(VectorB4 V){ return MkVectorB4(V.z, V.w, 0, V.w); }
inline VectorB4 SwizzZW__(VectorB4 V){ return MkVectorB4(V.z, V.w, 0, 0); }
inline VectorB4 SwizzZ_XX(VectorB4 V){ return MkVectorB4(V.z, 0, V.x, V.x); }
inline VectorB4 SwizzZ_XY(VectorB4 V){ return MkVectorB4(V.z, 0, V.x, V.y); }
inline VectorB4 SwizzZ_XZ(VectorB4 V){ return MkVectorB4(V.z, 0, V.x, V.z); }
inline VectorB4 SwizzZ_XW(VectorB4 V){ return MkVectorB4(V.z, 0, V.x, V.w); }
inline VectorB4 SwizzZ_X_(VectorB4 V){ return MkVectorB4(V.z, 0, V.x, 0); }
inline VectorB4 SwizzZ_YX(VectorB4 V){ return MkVectorB4(V.z, 0, V.y, V.x); }
inline VectorB4 SwizzZ_YY(VectorB4 V){ return MkVectorB4(V.z, 0, V.y, V.y); }
inline VectorB4 SwizzZ_YZ(VectorB4 V){ return MkVectorB4(V.z, 0, V.y, V.z); }
inline VectorB4 SwizzZ_YW(VectorB4 V){ return MkVectorB4(V.z, 0, V.y, V.w); }
inline VectorB4 SwizzZ_Y_(VectorB4 V){ return MkVectorB4(V.z, 0, V.y, 0); }
inline VectorB4 SwizzZ_ZX(VectorB4 V){ return MkVectorB4(V.z, 0, V.z, V.x); }
inline VectorB4 SwizzZ_ZY(VectorB4 V){ return MkVectorB4(V.z, 0, V.z, V.y); }
inline VectorB4 SwizzZ_ZZ(VectorB4 V){ return MkVectorB4(V.z, 0, V.z, V.z); }
inline VectorB4 SwizzZ_ZW(VectorB4 V){ return MkVectorB4(V.z, 0, V.z, V.w); }
inline VectorB4 SwizzZ_Z_(VectorB4 V){ return MkVectorB4(V.z, 0, V.z, 0); }
inline VectorB4 SwizzZ_WX(VectorB4 V){ return MkVectorB4(V.z, 0, V.w, V.x); }
inline VectorB4 SwizzZ_WY(VectorB4 V){ return MkVectorB4(V.z, 0, V.w, V.y); }
inline VectorB4 SwizzZ_WZ(VectorB4 V){ return MkVectorB4(V.z, 0, V.w, V.z); }
inline VectorB4 SwizzZ_WW(VectorB4 V){ return MkVectorB4(V.z, 0, V.w, V.w); }
inline VectorB4 SwizzZ_W_(VectorB4 V){ return MkVectorB4(V.z, 0, V.w, 0); }
inline VectorB4 SwizzZ__X(VectorB4 V){ return MkVectorB4(V.z, 0, 0, V.x); }
inline VectorB4 SwizzZ__Y(VectorB4 V){ return MkVectorB4(V.z, 0, 0, V.y); }
inline VectorB4 SwizzZ__Z(VectorB4 V){ return MkVectorB4(V.z, 0, 0, V.z); }
inline VectorB4 SwizzZ__W(VectorB4 V){ return MkVectorB4(V.z, 0, 0, V.w); }
inline VectorB4 SwizzZ___(VectorB4 V){ return MkVectorB4(V.z, 0, 0, 0); }
inline VectorB4 SwizzWXXX(VectorB4 V){ return MkVectorB4(V.w, V.x, V.x, V.x); }
inline VectorB4 SwizzWXXY(VectorB4 V){ return MkVectorB4(V.w, V.x, V.x, V.y); }
inline VectorB4 SwizzWXXZ(VectorB4 V){ return MkVectorB4(V.w, V.x, V.x, V.z); }
inline VectorB4 SwizzWXXW(VectorB4 V){ return MkVectorB4(V.w, V.x, V.x, V.w); }
inline VectorB4 SwizzWXX_(VectorB4 V){ return MkVectorB4(V.w, V.x, V.x, 0); }
inline VectorB4 SwizzWXYX(VectorB4 V){ return MkVectorB4(V.w, V.x, V.y, V.x); }
inline VectorB4 SwizzWXYY(VectorB4 V){ return MkVectorB4(V.w, V.x, V.y, V.y); }
inline VectorB4 SwizzWXYZ(VectorB4 V){ return MkVectorB4(V.w, V.x, V.y, V.z); }
inline VectorB4 SwizzWXYW(VectorB4 V){ return MkVectorB4(V.w, V.x, V.y, V.w); }
inline VectorB4 SwizzWXY_(VectorB4 V){ return MkVectorB4(V.w, V.x, V.y, 0); }
inline VectorB4 SwizzWXZX(VectorB4 V){ return MkVectorB4(V.w, V.x, V.z, V.x); }
inline VectorB4 SwizzWXZY(VectorB4 V){ return MkVectorB4(V.w, V.x, V.z, V.y); }
inline VectorB4 SwizzWXZZ(VectorB4 V){ return MkVectorB4(V.w, V.x, V.z, V.z); }
inline VectorB4 SwizzWXZW(VectorB4 V){ return MkVectorB4(V.w, V.x, V.z, V.w); }
inline VectorB4 SwizzWXZ_(VectorB4 V){ return MkVectorB4(V.w, V.x, V.z, 0); }
inline VectorB4 SwizzWXWX(VectorB4 V){ return MkVectorB4(V.w, V.x, V.w, V.x); }
inline VectorB4 SwizzWXWY(VectorB4 V){ return MkVectorB4(V.w, V.x, V.w, V.y); }
inline VectorB4 SwizzWXWZ(VectorB4 V){ return MkVectorB4(V.w, V.x, V.w, V.z); }
inline VectorB4 SwizzWXWW(VectorB4 V){ return MkVectorB4(V.w, V.x, V.w, V.w); }
inline VectorB4 SwizzWXW_(VectorB4 V){ return MkVectorB4(V.w, V.x, V.w, 0); }
inline VectorB4 SwizzWX_X(VectorB4 V){ return MkVectorB4(V.w, V.x, 0, V.x); }
inline VectorB4 SwizzWX_Y(VectorB4 V){ return MkVectorB4(V.w, V.x, 0, V.y); }
inline VectorB4 SwizzWX_Z(VectorB4 V){ return MkVectorB4(V.w, V.x, 0, V.z); }
inline VectorB4 SwizzWX_W(VectorB4 V){ return MkVectorB4(V.w, V.x, 0, V.w); }
inline VectorB4 SwizzWX__(VectorB4 V){ return MkVectorB4(V.w, V.x, 0, 0); }
inline VectorB4 SwizzWYXX(VectorB4 V){ return MkVectorB4(V.w, V.y, V.x, V.x); }
inline VectorB4 SwizzWYXY(VectorB4 V){ return MkVectorB4(V.w, V.y, V.x, V.y); }
inline VectorB4 SwizzWYXZ(VectorB4 V){ return MkVectorB4(V.w, V.y, V.x, V.z); }
inline VectorB4 SwizzWYXW(VectorB4 V){ return MkVectorB4(V.w, V.y, V.x, V.w); }
inline VectorB4 SwizzWYX_(VectorB4 V){ return MkVectorB4(V.w, V.y, V.x, 0); }
inline VectorB4 SwizzWYYX(VectorB4 V){ return MkVectorB4(V.w, V.y, V.y, V.x); }
inline VectorB4 SwizzWYYY(VectorB4 V){ return MkVectorB4(V.w, V.y, V.y, V.y); }
inline VectorB4 SwizzWYYZ(VectorB4 V){ return MkVectorB4(V.w, V.y, V.y, V.z); }
inline VectorB4 SwizzWYYW(VectorB4 V){ return MkVectorB4(V.w, V.y, V.y, V.w); }
inline VectorB4 SwizzWYY_(VectorB4 V){ return MkVectorB4(V.w, V.y, V.y, 0); }
inline VectorB4 SwizzWYZX(VectorB4 V){ return MkVectorB4(V.w, V.y, V.z, V.x); }
inline VectorB4 SwizzWYZY(VectorB4 V){ return MkVectorB4(V.w, V.y, V.z, V.y); }
inline VectorB4 SwizzWYZZ(VectorB4 V){ return MkVectorB4(V.w, V.y, V.z, V.z); }
inline VectorB4 SwizzWYZW(VectorB4 V){ return MkVectorB4(V.w, V.y, V.z, V.w); }
inline VectorB4 SwizzWYZ_(VectorB4 V){ return MkVectorB4(V.w, V.y, V.z, 0); }
inline VectorB4 SwizzWYWX(VectorB4 V){ return MkVectorB4(V.w, V.y, V.w, V.x); }
inline VectorB4 SwizzWYWY(VectorB4 V){ return MkVectorB4(V.w, V.y, V.w, V.y); }
inline VectorB4 SwizzWYWZ(VectorB4 V){ return MkVectorB4(V.w, V.y, V.w, V.z); }
inline VectorB4 SwizzWYWW(VectorB4 V){ return MkVectorB4(V.w, V.y, V.w, V.w); }
inline VectorB4 SwizzWYW_(VectorB4 V){ return MkVectorB4(V.w, V.y, V.w, 0); }
inline VectorB4 SwizzWY_X(VectorB4 V){ return MkVectorB4(V.w, V.y, 0, V.x); }
inline VectorB4 SwizzWY_Y(VectorB4 V){ return MkVectorB4(V.w, V.y, 0, V.y); }
inline VectorB4 SwizzWY_Z(VectorB4 V){ return MkVectorB4(V.w, V.y, 0, V.z); }
inline VectorB4 SwizzWY_W(VectorB4 V){ return MkVectorB4(V.w, V.y, 0, V.w); }
inline VectorB4 SwizzWY__(VectorB4 V){ return MkVectorB4(V.w, V.y, 0, 0); }
inline VectorB4 SwizzWZXX(VectorB4 V){ return MkVectorB4(V.w, V.z, V.x, V.x); }
inline VectorB4 SwizzWZXY(VectorB4 V){ return MkVectorB4(V.w, V.z, V.x, V.y); }
inline VectorB4 SwizzWZXZ(VectorB4 V){ return MkVectorB4(V.w, V.z, V.x, V.z); }
inline VectorB4 SwizzWZXW(VectorB4 V){ return MkVectorB4(V.w, V.z, V.x, V.w); }
inline VectorB4 SwizzWZX_(VectorB4 V){ return MkVectorB4(V.w, V.z, V.x, 0); }
inline VectorB4 SwizzWZYX(VectorB4 V){ return MkVectorB4(V.w, V.z, V.y, V.x); }
inline VectorB4 SwizzWZYY(VectorB4 V){ return MkVectorB4(V.w, V.z, V.y, V.y); }
inline VectorB4 SwizzWZYZ(VectorB4 V){ return MkVectorB4(V.w, V.z, V.y, V.z); }
inline VectorB4 SwizzWZYW(VectorB4 V){ return MkVectorB4(V.w, V.z, V.y, V.w); }
inline VectorB4 SwizzWZY_(VectorB4 V){ return MkVectorB4(V.w, V.z, V.y, 0); }
inline VectorB4 SwizzWZZX(VectorB4 V){ return MkVectorB4(V.w, V.z, V.z, V.x); }
inline VectorB4 SwizzWZZY(VectorB4 V){ return MkVectorB4(V.w, V.z, V.z, V.y); }
inline VectorB4 SwizzWZZZ(VectorB4 V){ return MkVectorB4(V.w, V.z, V.z, V.z); }
inline VectorB4 SwizzWZZW(VectorB4 V){ return MkVectorB4(V.w, V.z, V.z, V.w); }
inline VectorB4 SwizzWZZ_(VectorB4 V){ return MkVectorB4(V.w, V.z, V.z, 0); }
inline VectorB4 SwizzWZWX(VectorB4 V){ return MkVectorB4(V.w, V.z, V.w, V.x); }
inline VectorB4 SwizzWZWY(VectorB4 V){ return MkVectorB4(V.w, V.z, V.w, V.y); }
inline VectorB4 SwizzWZWZ(VectorB4 V){ return MkVectorB4(V.w, V.z, V.w, V.z); }
inline VectorB4 SwizzWZWW(VectorB4 V){ return MkVectorB4(V.w, V.z, V.w, V.w); }
inline VectorB4 SwizzWZW_(VectorB4 V){ return MkVectorB4(V.w, V.z, V.w, 0); }
inline VectorB4 SwizzWZ_X(VectorB4 V){ return MkVectorB4(V.w, V.z, 0, V.x); }
inline VectorB4 SwizzWZ_Y(VectorB4 V){ return MkVectorB4(V.w, V.z, 0, V.y); }
inline VectorB4 SwizzWZ_Z(VectorB4 V){ return MkVectorB4(V.w, V.z, 0, V.z); }
inline VectorB4 SwizzWZ_W(VectorB4 V){ return MkVectorB4(V.w, V.z, 0, V.w); }
inline VectorB4 SwizzWZ__(VectorB4 V){ return MkVectorB4(V.w, V.z, 0, 0); }
inline VectorB4 SwizzWWXX(VectorB4 V){ return MkVectorB4(V.w, V.w, V.x, V.x); }
inline VectorB4 SwizzWWXY(VectorB4 V){ return MkVectorB4(V.w, V.w, V.x, V.y); }
inline VectorB4 SwizzWWXZ(VectorB4 V){ return MkVectorB4(V.w, V.w, V.x, V.z); }
inline VectorB4 SwizzWWXW(VectorB4 V){ return MkVectorB4(V.w, V.w, V.x, V.w); }
inline VectorB4 SwizzWWX_(VectorB4 V){ return MkVectorB4(V.w, V.w, V.x, 0); }
inline VectorB4 SwizzWWYX(VectorB4 V){ return MkVectorB4(V.w, V.w, V.y, V.x); }
inline VectorB4 SwizzWWYY(VectorB4 V){ return MkVectorB4(V.w, V.w, V.y, V.y); }
inline VectorB4 SwizzWWYZ(VectorB4 V){ return MkVectorB4(V.w, V.w, V.y, V.z); }
inline VectorB4 SwizzWWYW(VectorB4 V){ return MkVectorB4(V.w, V.w, V.y, V.w); }
inline VectorB4 SwizzWWY_(VectorB4 V){ return MkVectorB4(V.w, V.w, V.y, 0); }
inline VectorB4 SwizzWWZX(VectorB4 V){ return MkVectorB4(V.w, V.w, V.z, V.x); }
inline VectorB4 SwizzWWZY(VectorB4 V){ return MkVectorB4(V.w, V.w, V.z, V.y); }
inline VectorB4 SwizzWWZZ(VectorB4 V){ return MkVectorB4(V.w, V.w, V.z, V.z); }
inline VectorB4 SwizzWWZW(VectorB4 V){ return MkVectorB4(V.w, V.w, V.z, V.w); }
inline VectorB4 SwizzWWZ_(VectorB4 V){ return MkVectorB4(V.w, V.w, V.z, 0); }
inline VectorB4 SwizzWWWX(VectorB4 V){ return MkVectorB4(V.w, V.w, V.w, V.x); }
inline VectorB4 SwizzWWWY(VectorB4 V){ return MkVectorB4(V.w, V.w, V.w, V.y); }
inline VectorB4 SwizzWWWZ(VectorB4 V){ return MkVectorB4(V.w, V.w, V.w, V.z); }
inline VectorB4 SwizzWWWW(VectorB4 V){ return MkVectorB4(V.w, V.w, V.w, V.w); }
inline VectorB4 SwizzWWW_(VectorB4 V){ return MkVectorB4(V.w, V.w, V.w, 0); }
inline VectorB4 SwizzWW_X(VectorB4 V){ return MkVectorB4(V.w, V.w, 0, V.x); }
inline VectorB4 SwizzWW_Y(VectorB4 V){ return MkVectorB4(V.w, V.w, 0, V.y); }
inline VectorB4 SwizzWW_Z(VectorB4 V){ return MkVectorB4(V.w, V.w, 0, V.z); }
inline VectorB4 SwizzWW_W(VectorB4 V){ return MkVectorB4(V.w, V.w, 0, V.w); }
inline VectorB4 SwizzWW__(VectorB4 V){ return MkVectorB4(V.w, V.w, 0, 0); }
inline VectorB4 SwizzW_XX(VectorB4 V){ return MkVectorB4(V.w, 0, V.x, V.x); }
inline VectorB4 SwizzW_XY(VectorB4 V){ return MkVectorB4(V.w, 0, V.x, V.y); }
inline VectorB4 SwizzW_XZ(VectorB4 V){ return MkVectorB4(V.w, 0, V.x, V.z); }
inline VectorB4 SwizzW_XW(VectorB4 V){ return MkVectorB4(V.w, 0, V.x, V.w); }
inline VectorB4 SwizzW_X_(VectorB4 V){ return MkVectorB4(V.w, 0, V.x, 0); }
inline VectorB4 SwizzW_YX(VectorB4 V){ return MkVectorB4(V.w, 0, V.y, V.x); }
inline VectorB4 SwizzW_YY(VectorB4 V){ return MkVectorB4(V.w, 0, V.y, V.y); }
inline VectorB4 SwizzW_YZ(VectorB4 V){ return MkVectorB4(V.w, 0, V.y, V.z); }
inline VectorB4 SwizzW_YW(VectorB4 V){ return MkVectorB4(V.w, 0, V.y, V.w); }
inline VectorB4 SwizzW_Y_(VectorB4 V){ return MkVectorB4(V.w, 0, V.y, 0); }
inline VectorB4 SwizzW_ZX(VectorB4 V){ return MkVectorB4(V.w, 0, V.z, V.x); }
inline VectorB4 SwizzW_ZY(VectorB4 V){ return MkVectorB4(V.w, 0, V.z, V.y); }
inline VectorB4 SwizzW_ZZ(VectorB4 V){ return MkVectorB4(V.w, 0, V.z, V.z); }
inline VectorB4 SwizzW_ZW(VectorB4 V){ return MkVectorB4(V.w, 0, V.z, V.w); }
inline VectorB4 SwizzW_Z_(VectorB4 V){ return MkVectorB4(V.w, 0, V.z, 0); }
inline VectorB4 SwizzW_WX(VectorB4 V){ return MkVectorB4(V.w, 0, V.w, V.x); }
inline VectorB4 SwizzW_WY(VectorB4 V){ return MkVectorB4(V.w, 0, V.w, V.y); }
inline VectorB4 SwizzW_WZ(VectorB4 V){ return MkVectorB4(V.w, 0, V.w, V.z); }
inline VectorB4 SwizzW_WW(VectorB4 V){ return MkVectorB4(V.w, 0, V.w, V.w); }
inline VectorB4 SwizzW_W_(VectorB4 V){ return MkVectorB4(V.w, 0, V.w, 0); }
inline VectorB4 SwizzW__X(VectorB4 V){ return MkVectorB4(V.w, 0, 0, V.x); }
inline VectorB4 SwizzW__Y(VectorB4 V){ return MkVectorB4(V.w, 0, 0, V.y); }
inline VectorB4 SwizzW__Z(VectorB4 V){ return MkVectorB4(V.w, 0, 0, V.z); }
inline VectorB4 SwizzW__W(VectorB4 V){ return MkVectorB4(V.w, 0, 0, V.w); }
inline VectorB4 SwizzW___(VectorB4 V){ return MkVectorB4(V.w, 0, 0, 0); }
inline VectorB4 Swizz_XXX(VectorB4 V){ return MkVectorB4(0, V.x, V.x, V.x); }
inline VectorB4 Swizz_XXY(VectorB4 V){ return MkVectorB4(0, V.x, V.x, V.y); }
inline VectorB4 Swizz_XXZ(VectorB4 V){ return MkVectorB4(0, V.x, V.x, V.z); }
inline VectorB4 Swizz_XXW(VectorB4 V){ return MkVectorB4(0, V.x, V.x, V.w); }
inline VectorB4 Swizz_XX_(VectorB4 V){ return MkVectorB4(0, V.x, V.x, 0); }
inline VectorB4 Swizz_XYX(VectorB4 V){ return MkVectorB4(0, V.x, V.y, V.x); }
inline VectorB4 Swizz_XYY(VectorB4 V){ return MkVectorB4(0, V.x, V.y, V.y); }
inline VectorB4 Swizz_XYZ(VectorB4 V){ return MkVectorB4(0, V.x, V.y, V.z); }
inline VectorB4 Swizz_XYW(VectorB4 V){ return MkVectorB4(0, V.x, V.y, V.w); }
inline VectorB4 Swizz_XY_(VectorB4 V){ return MkVectorB4(0, V.x, V.y, 0); }
inline VectorB4 Swizz_XZX(VectorB4 V){ return MkVectorB4(0, V.x, V.z, V.x); }
inline VectorB4 Swizz_XZY(VectorB4 V){ return MkVectorB4(0, V.x, V.z, V.y); }
inline VectorB4 Swizz_XZZ(VectorB4 V){ return MkVectorB4(0, V.x, V.z, V.z); }
inline VectorB4 Swizz_XZW(VectorB4 V){ return MkVectorB4(0, V.x, V.z, V.w); }
inline VectorB4 Swizz_XZ_(VectorB4 V){ return MkVectorB4(0, V.x, V.z, 0); }
inline VectorB4 Swizz_XWX(VectorB4 V){ return MkVectorB4(0, V.x, V.w, V.x); }
inline VectorB4 Swizz_XWY(VectorB4 V){ return MkVectorB4(0, V.x, V.w, V.y); }
inline VectorB4 Swizz_XWZ(VectorB4 V){ return MkVectorB4(0, V.x, V.w, V.z); }
inline VectorB4 Swizz_XWW(VectorB4 V){ return MkVectorB4(0, V.x, V.w, V.w); }
inline VectorB4 Swizz_XW_(VectorB4 V){ return MkVectorB4(0, V.x, V.w, 0); }
inline VectorB4 Swizz_X_X(VectorB4 V){ return MkVectorB4(0, V.x, 0, V.x); }
inline VectorB4 Swizz_X_Y(VectorB4 V){ return MkVectorB4(0, V.x, 0, V.y); }
inline VectorB4 Swizz_X_Z(VectorB4 V){ return MkVectorB4(0, V.x, 0, V.z); }
inline VectorB4 Swizz_X_W(VectorB4 V){ return MkVectorB4(0, V.x, 0, V.w); }
inline VectorB4 Swizz_X__(VectorB4 V){ return MkVectorB4(0, V.x, 0, 0); }
inline VectorB4 Swizz_YXX(VectorB4 V){ return MkVectorB4(0, V.y, V.x, V.x); }
inline VectorB4 Swizz_YXY(VectorB4 V){ return MkVectorB4(0, V.y, V.x, V.y); }
inline VectorB4 Swizz_YXZ(VectorB4 V){ return MkVectorB4(0, V.y, V.x, V.z); }
inline VectorB4 Swizz_YXW(VectorB4 V){ return MkVectorB4(0, V.y, V.x, V.w); }
inline VectorB4 Swizz_YX_(VectorB4 V){ return MkVectorB4(0, V.y, V.x, 0); }
inline VectorB4 Swizz_YYX(VectorB4 V){ return MkVectorB4(0, V.y, V.y, V.x); }
inline VectorB4 Swizz_YYY(VectorB4 V){ return MkVectorB4(0, V.y, V.y, V.y); }
inline VectorB4 Swizz_YYZ(VectorB4 V){ return MkVectorB4(0, V.y, V.y, V.z); }
inline VectorB4 Swizz_YYW(VectorB4 V){ return MkVectorB4(0, V.y, V.y, V.w); }
inline VectorB4 Swizz_YY_(VectorB4 V){ return MkVectorB4(0, V.y, V.y, 0); }
inline VectorB4 Swizz_YZX(VectorB4 V){ return MkVectorB4(0, V.y, V.z, V.x); }
inline VectorB4 Swizz_YZY(VectorB4 V){ return MkVectorB4(0, V.y, V.z, V.y); }
inline VectorB4 Swizz_YZZ(VectorB4 V){ return MkVectorB4(0, V.y, V.z, V.z); }
inline VectorB4 Swizz_YZW(VectorB4 V){ return MkVectorB4(0, V.y, V.z, V.w); }
inline VectorB4 Swizz_YZ_(VectorB4 V){ return MkVectorB4(0, V.y, V.z, 0); }
inline VectorB4 Swizz_YWX(VectorB4 V){ return MkVectorB4(0, V.y, V.w, V.x); }
inline VectorB4 Swizz_YWY(VectorB4 V){ return MkVectorB4(0, V.y, V.w, V.y); }
inline VectorB4 Swizz_YWZ(VectorB4 V){ return MkVectorB4(0, V.y, V.w, V.z); }
inline VectorB4 Swizz_YWW(VectorB4 V){ return MkVectorB4(0, V.y, V.w, V.w); }
inline VectorB4 Swizz_YW_(VectorB4 V){ return MkVectorB4(0, V.y, V.w, 0); }
inline VectorB4 Swizz_Y_X(VectorB4 V){ return MkVectorB4(0, V.y, 0, V.x); }
inline VectorB4 Swizz_Y_Y(VectorB4 V){ return MkVectorB4(0, V.y, 0, V.y); }
inline VectorB4 Swizz_Y_Z(VectorB4 V){ return MkVectorB4(0, V.y, 0, V.z); }
inline VectorB4 Swizz_Y_W(VectorB4 V){ return MkVectorB4(0, V.y, 0, V.w); }
inline VectorB4 Swizz_Y__(VectorB4 V){ return MkVectorB4(0, V.y, 0, 0); }
inline VectorB4 Swizz_ZXX(VectorB4 V){ return MkVectorB4(0, V.z, V.x, V.x); }
inline VectorB4 Swizz_ZXY(VectorB4 V){ return MkVectorB4(0, V.z, V.x, V.y); }
inline VectorB4 Swizz_ZXZ(VectorB4 V){ return MkVectorB4(0, V.z, V.x, V.z); }
inline VectorB4 Swizz_ZXW(VectorB4 V){ return MkVectorB4(0, V.z, V.x, V.w); }
inline VectorB4 Swizz_ZX_(VectorB4 V){ return MkVectorB4(0, V.z, V.x, 0); }
inline VectorB4 Swizz_ZYX(VectorB4 V){ return MkVectorB4(0, V.z, V.y, V.x); }
inline VectorB4 Swizz_ZYY(VectorB4 V){ return MkVectorB4(0, V.z, V.y, V.y); }
inline VectorB4 Swizz_ZYZ(VectorB4 V){ return MkVectorB4(0, V.z, V.y, V.z); }
inline VectorB4 Swizz_ZYW(VectorB4 V){ return MkVectorB4(0, V.z, V.y, V.w); }
inline VectorB4 Swizz_ZY_(VectorB4 V){ return MkVectorB4(0, V.z, V.y, 0); }
inline VectorB4 Swizz_ZZX(VectorB4 V){ return MkVectorB4(0, V.z, V.z, V.x); }
inline VectorB4 Swizz_ZZY(VectorB4 V){ return MkVectorB4(0, V.z, V.z, V.y); }
inline VectorB4 Swizz_ZZZ(VectorB4 V){ return MkVectorB4(0, V.z, V.z, V.z); }
inline VectorB4 Swizz_ZZW(VectorB4 V){ return MkVectorB4(0, V.z, V.z, V.w); }
inline VectorB4 Swizz_ZZ_(VectorB4 V){ return MkVectorB4(0, V.z, V.z, 0); }
inline VectorB4 Swizz_ZWX(VectorB4 V){ return MkVectorB4(0, V.z, V.w, V.x); }
inline VectorB4 Swizz_ZWY(VectorB4 V){ return MkVectorB4(0, V.z, V.w, V.y); }
inline VectorB4 Swizz_ZWZ(VectorB4 V){ return MkVectorB4(0, V.z, V.w, V.z); }
inline VectorB4 Swizz_ZWW(VectorB4 V){ return MkVectorB4(0, V.z, V.w, V.w); }
inline VectorB4 Swizz_ZW_(VectorB4 V){ return MkVectorB4(0, V.z, V.w, 0); }
inline VectorB4 Swizz_Z_X(VectorB4 V){ return MkVectorB4(0, V.z, 0, V.x); }
inline VectorB4 Swizz_Z_Y(VectorB4 V){ return MkVectorB4(0, V.z, 0, V.y); }
inline VectorB4 Swizz_Z_Z(VectorB4 V){ return MkVectorB4(0, V.z, 0, V.z); }
inline VectorB4 Swizz_Z_W(VectorB4 V){ return MkVectorB4(0, V.z, 0, V.w); }
inline VectorB4 Swizz_Z__(VectorB4 V){ return MkVectorB4(0, V.z, 0, 0); }
inline VectorB4 Swizz_WXX(VectorB4 V){ return MkVectorB4(0, V.w, V.x, V.x); }
inline VectorB4 Swizz_WXY(VectorB4 V){ return MkVectorB4(0, V.w, V.x, V.y); }
inline VectorB4 Swizz_WXZ(VectorB4 V){ return MkVectorB4(0, V.w, V.x, V.z); }
inline VectorB4 Swizz_WXW(VectorB4 V){ return MkVectorB4(0, V.w, V.x, V.w); }
inline VectorB4 Swizz_WX_(VectorB4 V){ return MkVectorB4(0, V.w, V.x, 0); }
inline VectorB4 Swizz_WYX(VectorB4 V){ return MkVectorB4(0, V.w, V.y, V.x); }
inline VectorB4 Swizz_WYY(VectorB4 V){ return MkVectorB4(0, V.w, V.y, V.y); }
inline VectorB4 Swizz_WYZ(VectorB4 V){ return MkVectorB4(0, V.w, V.y, V.z); }
inline VectorB4 Swizz_WYW(VectorB4 V){ return MkVectorB4(0, V.w, V.y, V.w); }
inline VectorB4 Swizz_WY_(VectorB4 V){ return MkVectorB4(0, V.w, V.y, 0); }
inline VectorB4 Swizz_WZX(VectorB4 V){ return MkVectorB4(0, V.w, V.z, V.x); }
inline VectorB4 Swizz_WZY(VectorB4 V){ return MkVectorB4(0, V.w, V.z, V.y); }
inline VectorB4 Swizz_WZZ(VectorB4 V){ return MkVectorB4(0, V.w, V.z, V.z); }
inline VectorB4 Swizz_WZW(VectorB4 V){ return MkVectorB4(0, V.w, V.z, V.w); }
inline VectorB4 Swizz_WZ_(VectorB4 V){ return MkVectorB4(0, V.w, V.z, 0); }
inline VectorB4 Swizz_WWX(VectorB4 V){ return MkVectorB4(0, V.w, V.w, V.x); }
inline VectorB4 Swizz_WWY(VectorB4 V){ return MkVectorB4(0, V.w, V.w, V.y); }
inline VectorB4 Swizz_WWZ(VectorB4 V){ return MkVectorB4(0, V.w, V.w, V.z); }
inline VectorB4 Swizz_WWW(VectorB4 V){ return MkVectorB4(0, V.w, V.w, V.w); }
inline VectorB4 Swizz_WW_(VectorB4 V){ return MkVectorB4(0, V.w, V.w, 0); }
inline VectorB4 Swizz_W_X(VectorB4 V){ return MkVectorB4(0, V.w, 0, V.x); }
inline VectorB4 Swizz_W_Y(VectorB4 V){ return MkVectorB4(0, V.w, 0, V.y); }
inline VectorB4 Swizz_W_Z(VectorB4 V){ return MkVectorB4(0, V.w, 0, V.z); }
inline VectorB4 Swizz_W_W(VectorB4 V){ return MkVectorB4(0, V.w, 0, V.w); }
inline VectorB4 Swizz_W__(VectorB4 V){ return MkVectorB4(0, V.w, 0, 0); }
inline VectorB4 Swizz__XX(VectorB4 V){ return MkVectorB4(0, 0, V.x, V.x); }
inline VectorB4 Swizz__XY(VectorB4 V){ return MkVectorB4(0, 0, V.x, V.y); }
inline VectorB4 Swizz__XZ(VectorB4 V){ return MkVectorB4(0, 0, V.x, V.z); }
inline VectorB4 Swizz__XW(VectorB4 V){ return MkVectorB4(0, 0, V.x, V.w); }
inline VectorB4 Swizz__X_(VectorB4 V){ return MkVectorB4(0, 0, V.x, 0); }
inline VectorB4 Swizz__YX(VectorB4 V){ return MkVectorB4(0, 0, V.y, V.x); }
inline VectorB4 Swizz__YY(VectorB4 V){ return MkVectorB4(0, 0, V.y, V.y); }
inline VectorB4 Swizz__YZ(VectorB4 V){ return MkVectorB4(0, 0, V.y, V.z); }
inline VectorB4 Swizz__YW(VectorB4 V){ return MkVectorB4(0, 0, V.y, V.w); }
inline VectorB4 Swizz__Y_(VectorB4 V){ return MkVectorB4(0, 0, V.y, 0); }
inline VectorB4 Swizz__ZX(VectorB4 V){ return MkVectorB4(0, 0, V.z, V.x); }
inline VectorB4 Swizz__ZY(VectorB4 V){ return MkVectorB4(0, 0, V.z, V.y); }
inline VectorB4 Swizz__ZZ(VectorB4 V){ return MkVectorB4(0, 0, V.z, V.z); }
inline VectorB4 Swizz__ZW(VectorB4 V){ return MkVectorB4(0, 0, V.z, V.w); }
inline VectorB4 Swizz__Z_(VectorB4 V){ return MkVectorB4(0, 0, V.z, 0); }
inline VectorB4 Swizz__WX(VectorB4 V){ return MkVectorB4(0, 0, V.w, V.x); }
inline VectorB4 Swizz__WY(VectorB4 V){ return MkVectorB4(0, 0, V.w, V.y); }
inline VectorB4 Swizz__WZ(VectorB4 V){ return MkVectorB4(0, 0, V.w, V.z); }
inline VectorB4 Swizz__WW(VectorB4 V){ return MkVectorB4(0, 0, V.w, V.w); }
inline VectorB4 Swizz__W_(VectorB4 V){ return MkVectorB4(0, 0, V.w, 0); }
inline VectorB4 Swizz___X(VectorB4 V){ return MkVectorB4(0, 0, 0, V.x); }
inline VectorB4 Swizz___Y(VectorB4 V){ return MkVectorB4(0, 0, 0, V.y); }
inline VectorB4 Swizz___Z(VectorB4 V){ return MkVectorB4(0, 0, 0, V.z); }
inline VectorB4 Swizz___W(VectorB4 V){ return MkVectorB4(0, 0, 0, V.w); }
inline VectorD2 SwizzXX(VectorD2 V){ return MkVectorD2(V.x, V.x); }
inline VectorD2 SwizzXY(VectorD2 V){ return MkVectorD2(V.x, V.y); }
inline VectorD2 SwizzX_(VectorD2 V){ return MkVectorD2(V.x, 0); }
inline VectorD2 SwizzYX(VectorD2 V){ return MkVectorD2(V.y, V.x); }
inline VectorD2 SwizzYY(VectorD2 V){ return MkVectorD2(V.y, V.y); }
inline VectorD2 SwizzY_(VectorD2 V){ return MkVectorD2(V.y, 0); }
inline VectorD2 Swizz_X(VectorD2 V){ return MkVectorD2(0, V.x); }
inline VectorD2 Swizz_Y(VectorD2 V){ return MkVectorD2(0, V.y); }
inline VectorD3 SwizzXXX(VectorD2 V){ return MkVectorD3(V.x, V.x, V.x); }
inline VectorD3 SwizzXXY(VectorD2 V){ return MkVectorD3(V.x, V.x, V.y); }
inline VectorD3 SwizzXX_(VectorD2 V){ return MkVectorD3(V.x, V.x, 0); }
inline VectorD3 SwizzXYX(VectorD2 V){ return MkVectorD3(V.x, V.y, V.x); }
inline VectorD3 SwizzXYY(VectorD2 V){ return MkVectorD3(V.x, V.y, V.y); }
inline VectorD3 SwizzXY_(VectorD2 V){ return MkVectorD3(V.x, V.y, 0); }
inline VectorD3 SwizzX_X(VectorD2 V){ return MkVectorD3(V.x, 0, V.x); }
inline VectorD3 SwizzX_Y(VectorD2 V){ return MkVectorD3(V.x, 0, V.y); }
inline VectorD3 SwizzX__(VectorD2 V){ return MkVectorD3(V.x, 0, 0); }
inline VectorD3 SwizzYXX(VectorD2 V){ return MkVectorD3(V.y, V.x, V.x); }
inline VectorD3 SwizzYXY(VectorD2 V){ return MkVectorD3(V.y, V.x, V.y); }
inline VectorD3 SwizzYX_(VectorD2 V){ return MkVectorD3(V.y, V.x, 0); }
inline VectorD3 SwizzYYX(VectorD2 V){ return MkVectorD3(V.y, V.y, V.x); }
inline VectorD3 SwizzYYY(VectorD2 V){ return MkVectorD3(V.y, V.y, V.y); }
inline VectorD3 SwizzYY_(VectorD2 V){ return MkVectorD3(V.y, V.y, 0); }
inline VectorD3 SwizzY_X(VectorD2 V){ return MkVectorD3(V.y, 0, V.x); }
inline VectorD3 SwizzY_Y(VectorD2 V){ return MkVectorD3(V.y, 0, V.y); }
inline VectorD3 SwizzY__(VectorD2 V){ return MkVectorD3(V.y, 0, 0); }
inline VectorD3 Swizz_XX(VectorD2 V){ return MkVectorD3(0, V.x, V.x); }
inline VectorD3 Swizz_XY(VectorD2 V){ return MkVectorD3(0, V.x, V.y); }
inline VectorD3 Swizz_X_(VectorD2 V){ return MkVectorD3(0, V.x, 0); }
inline VectorD3 Swizz_YX(VectorD2 V){ return MkVectorD3(0, V.y, V.x); }
inline VectorD3 Swizz_YY(VectorD2 V){ return MkVectorD3(0, V.y, V.y); }
inline VectorD3 Swizz_Y_(VectorD2 V){ return MkVectorD3(0, V.y, 0); }
inline VectorD3 Swizz__X(VectorD2 V){ return MkVectorD3(0, 0, V.x); }
inline VectorD3 Swizz__Y(VectorD2 V){ return MkVectorD3(0, 0, V.y); }
inline VectorD4 SwizzXXXX(VectorD2 V){ return MkVectorD4(V.x, V.x, V.x, V.x); }
inline VectorD4 SwizzXXXY(VectorD2 V){ return MkVectorD4(V.x, V.x, V.x, V.y); }
inline VectorD4 SwizzXXX_(VectorD2 V){ return MkVectorD4(V.x, V.x, V.x, 0); }
inline VectorD4 SwizzXXYX(VectorD2 V){ return MkVectorD4(V.x, V.x, V.y, V.x); }
inline VectorD4 SwizzXXYY(VectorD2 V){ return MkVectorD4(V.x, V.x, V.y, V.y); }
inline VectorD4 SwizzXXY_(VectorD2 V){ return MkVectorD4(V.x, V.x, V.y, 0); }
inline VectorD4 SwizzXX_X(VectorD2 V){ return MkVectorD4(V.x, V.x, 0, V.x); }
inline VectorD4 SwizzXX_Y(VectorD2 V){ return MkVectorD4(V.x, V.x, 0, V.y); }
inline VectorD4 SwizzXX__(VectorD2 V){ return MkVectorD4(V.x, V.x, 0, 0); }
inline VectorD4 SwizzXYXX(VectorD2 V){ return MkVectorD4(V.x, V.y, V.x, V.x); }
inline VectorD4 SwizzXYXY(VectorD2 V){ return MkVectorD4(V.x, V.y, V.x, V.y); }
inline VectorD4 SwizzXYX_(VectorD2 V){ return MkVectorD4(V.x, V.y, V.x, 0); }
inline VectorD4 SwizzXYYX(VectorD2 V){ return MkVectorD4(V.x, V.y, V.y, V.x); }
inline VectorD4 SwizzXYYY(VectorD2 V){ return MkVectorD4(V.x, V.y, V.y, V.y); }
inline VectorD4 SwizzXYY_(VectorD2 V){ return MkVectorD4(V.x, V.y, V.y, 0); }
inline VectorD4 SwizzXY_X(VectorD2 V){ return MkVectorD4(V.x, V.y, 0, V.x); }
inline VectorD4 SwizzXY_Y(VectorD2 V){ return MkVectorD4(V.x, V.y, 0, V.y); }
inline VectorD4 SwizzXY__(VectorD2 V){ return MkVectorD4(V.x, V.y, 0, 0); }
inline VectorD4 SwizzX_XX(VectorD2 V){ return MkVectorD4(V.x, 0, V.x, V.x); }
inline VectorD4 SwizzX_XY(VectorD2 V){ return MkVectorD4(V.x, 0, V.x, V.y); }
inline VectorD4 SwizzX_X_(VectorD2 V){ return MkVectorD4(V.x, 0, V.x, 0); }
inline VectorD4 SwizzX_YX(VectorD2 V){ return MkVectorD4(V.x, 0, V.y, V.x); }
inline VectorD4 SwizzX_YY(VectorD2 V){ return MkVectorD4(V.x, 0, V.y, V.y); }
inline VectorD4 SwizzX_Y_(VectorD2 V){ return MkVectorD4(V.x, 0, V.y, 0); }
inline VectorD4 SwizzX__X(VectorD2 V){ return MkVectorD4(V.x, 0, 0, V.x); }
inline VectorD4 SwizzX__Y(VectorD2 V){ return MkVectorD4(V.x, 0, 0, V.y); }
inline VectorD4 SwizzX___(VectorD2 V){ return MkVectorD4(V.x, 0, 0, 0); }
inline VectorD4 SwizzYXXX(VectorD2 V){ return MkVectorD4(V.y, V.x, V.x, V.x); }
inline VectorD4 SwizzYXXY(VectorD2 V){ return MkVectorD4(V.y, V.x, V.x, V.y); }
inline VectorD4 SwizzYXX_(VectorD2 V){ return MkVectorD4(V.y, V.x, V.x, 0); }
inline VectorD4 SwizzYXYX(VectorD2 V){ return MkVectorD4(V.y, V.x, V.y, V.x); }
inline VectorD4 SwizzYXYY(VectorD2 V){ return MkVectorD4(V.y, V.x, V.y, V.y); }
inline VectorD4 SwizzYXY_(VectorD2 V){ return MkVectorD4(V.y, V.x, V.y, 0); }
inline VectorD4 SwizzYX_X(VectorD2 V){ return MkVectorD4(V.y, V.x, 0, V.x); }
inline VectorD4 SwizzYX_Y(VectorD2 V){ return MkVectorD4(V.y, V.x, 0, V.y); }
inline VectorD4 SwizzYX__(VectorD2 V){ return MkVectorD4(V.y, V.x, 0, 0); }
inline VectorD4 SwizzYYXX(VectorD2 V){ return MkVectorD4(V.y, V.y, V.x, V.x); }
inline VectorD4 SwizzYYXY(VectorD2 V){ return MkVectorD4(V.y, V.y, V.x, V.y); }
inline VectorD4 SwizzYYX_(VectorD2 V){ return MkVectorD4(V.y, V.y, V.x, 0); }
inline VectorD4 SwizzYYYX(VectorD2 V){ return MkVectorD4(V.y, V.y, V.y, V.x); }
inline VectorD4 SwizzYYYY(VectorD2 V){ return MkVectorD4(V.y, V.y, V.y, V.y); }
inline VectorD4 SwizzYYY_(VectorD2 V){ return MkVectorD4(V.y, V.y, V.y, 0); }
inline VectorD4 SwizzYY_X(VectorD2 V){ return MkVectorD4(V.y, V.y, 0, V.x); }
inline VectorD4 SwizzYY_Y(VectorD2 V){ return MkVectorD4(V.y, V.y, 0, V.y); }
inline VectorD4 SwizzYY__(VectorD2 V){ return MkVectorD4(V.y, V.y, 0, 0); }
inline VectorD4 SwizzY_XX(VectorD2 V){ return MkVectorD4(V.y, 0, V.x, V.x); }
inline VectorD4 SwizzY_XY(VectorD2 V){ return MkVectorD4(V.y, 0, V.x, V.y); }
inline VectorD4 SwizzY_X_(VectorD2 V){ return MkVectorD4(V.y, 0, V.x, 0); }
inline VectorD4 SwizzY_YX(VectorD2 V){ return MkVectorD4(V.y, 0, V.y, V.x); }
inline VectorD4 SwizzY_YY(VectorD2 V){ return MkVectorD4(V.y, 0, V.y, V.y); }
inline VectorD4 SwizzY_Y_(VectorD2 V){ return MkVectorD4(V.y, 0, V.y, 0); }
inline VectorD4 SwizzY__X(VectorD2 V){ return MkVectorD4(V.y, 0, 0, V.x); }
inline VectorD4 SwizzY__Y(VectorD2 V){ return MkVectorD4(V.y, 0, 0, V.y); }
inline VectorD4 SwizzY___(VectorD2 V){ return MkVectorD4(V.y, 0, 0, 0); }
inline VectorD4 Swizz_XXX(VectorD2 V){ return MkVectorD4(0, V.x, V.x, V.x); }
inline VectorD4 Swizz_XXY(VectorD2 V){ return MkVectorD4(0, V.x, V.x, V.y); }
inline VectorD4 Swizz_XX_(VectorD2 V){ return MkVectorD4(0, V.x, V.x, 0); }
inline VectorD4 Swizz_XYX(VectorD2 V){ return MkVectorD4(0, V.x, V.y, V.x); }
inline VectorD4 Swizz_XYY(VectorD2 V){ return MkVectorD4(0, V.x, V.y, V.y); }
inline VectorD4 Swizz_XY_(VectorD2 V){ return MkVectorD4(0, V.x, V.y, 0); }
inline VectorD4 Swizz_X_X(VectorD2 V){ return MkVectorD4(0, V.x, 0, V.x); }
inline VectorD4 Swizz_X_Y(VectorD2 V){ return MkVectorD4(0, V.x, 0, V.y); }
inline VectorD4 Swizz_X__(VectorD2 V){ return MkVectorD4(0, V.x, 0, 0); }
inline VectorD4 Swizz_YXX(VectorD2 V){ return MkVectorD4(0, V.y, V.x, V.x); }
inline VectorD4 Swizz_YXY(VectorD2 V){ return MkVectorD4(0, V.y, V.x, V.y); }
inline VectorD4 Swizz_YX_(VectorD2 V){ return MkVectorD4(0, V.y, V.x, 0); }
inline VectorD4 Swizz_YYX(VectorD2 V){ return MkVectorD4(0, V.y, V.y, V.x); }
inline VectorD4 Swizz_YYY(VectorD2 V){ return MkVectorD4(0, V.y, V.y, V.y); }
inline VectorD4 Swizz_YY_(VectorD2 V){ return MkVectorD4(0, V.y, V.y, 0); }
inline VectorD4 Swizz_Y_X(VectorD2 V){ return MkVectorD4(0, V.y, 0, V.x); }
inline VectorD4 Swizz_Y_Y(VectorD2 V){ return MkVectorD4(0, V.y, 0, V.y); }
inline VectorD4 Swizz_Y__(VectorD2 V){ return MkVectorD4(0, V.y, 0, 0); }
inline VectorD4 Swizz__XX(VectorD2 V){ return MkVectorD4(0, 0, V.x, V.x); }
inline VectorD4 Swizz__XY(VectorD2 V){ return MkVectorD4(0, 0, V.x, V.y); }
inline VectorD4 Swizz__X_(VectorD2 V){ return MkVectorD4(0, 0, V.x, 0); }
inline VectorD4 Swizz__YX(VectorD2 V){ return MkVectorD4(0, 0, V.y, V.x); }
inline VectorD4 Swizz__YY(VectorD2 V){ return MkVectorD4(0, 0, V.y, V.y); }
inline VectorD4 Swizz__Y_(VectorD2 V){ return MkVectorD4(0, 0, V.y, 0); }
inline VectorD4 Swizz___X(VectorD2 V){ return MkVectorD4(0, 0, 0, V.x); }
inline VectorD4 Swizz___Y(VectorD2 V){ return MkVectorD4(0, 0, 0, V.y); }
inline VectorD2 SwizzXX(VectorD3 V){ return MkVectorD2(V.x, V.x); }
inline VectorD2 SwizzXY(VectorD3 V){ return MkVectorD2(V.x, V.y); }
inline VectorD2 SwizzXZ(VectorD3 V){ return MkVectorD2(V.x, V.z); }
inline VectorD2 SwizzX_(VectorD3 V){ return MkVectorD2(V.x, 0); }
inline VectorD2 SwizzYX(VectorD3 V){ return MkVectorD2(V.y, V.x); }
inline VectorD2 SwizzYY(VectorD3 V){ return MkVectorD2(V.y, V.y); }
inline VectorD2 SwizzYZ(VectorD3 V){ return MkVectorD2(V.y, V.z); }
inline VectorD2 SwizzY_(VectorD3 V){ return MkVectorD2(V.y, 0); }
inline VectorD2 SwizzZX(VectorD3 V){ return MkVectorD2(V.z, V.x); }
inline VectorD2 SwizzZY(VectorD3 V){ return MkVectorD2(V.z, V.y); }
inline VectorD2 SwizzZZ(VectorD3 V){ return MkVectorD2(V.z, V.z); }
inline VectorD2 SwizzZ_(VectorD3 V){ return MkVectorD2(V.z, 0); }
inline VectorD2 Swizz_X(VectorD3 V){ return MkVectorD2(0, V.x); }
inline VectorD2 Swizz_Y(VectorD3 V){ return MkVectorD2(0, V.y); }
inline VectorD2 Swizz_Z(VectorD3 V){ return MkVectorD2(0, V.z); }
inline VectorD3 SwizzXXX(VectorD3 V){ return MkVectorD3(V.x, V.x, V.x); }
inline VectorD3 SwizzXXY(VectorD3 V){ return MkVectorD3(V.x, V.x, V.y); }
inline VectorD3 SwizzXXZ(VectorD3 V){ return MkVectorD3(V.x, V.x, V.z); }
inline VectorD3 SwizzXX_(VectorD3 V){ return MkVectorD3(V.x, V.x, 0); }
inline VectorD3 SwizzXYX(VectorD3 V){ return MkVectorD3(V.x, V.y, V.x); }
inline VectorD3 SwizzXYY(VectorD3 V){ return MkVectorD3(V.x, V.y, V.y); }
inline VectorD3 SwizzXYZ(VectorD3 V){ return MkVectorD3(V.x, V.y, V.z); }
inline VectorD3 SwizzXY_(VectorD3 V){ return MkVectorD3(V.x, V.y, 0); }
inline VectorD3 SwizzXZX(VectorD3 V){ return MkVectorD3(V.x, V.z, V.x); }
inline VectorD3 SwizzXZY(VectorD3 V){ return MkVectorD3(V.x, V.z, V.y); }
inline VectorD3 SwizzXZZ(VectorD3 V){ return MkVectorD3(V.x, V.z, V.z); }
inline VectorD3 SwizzXZ_(VectorD3 V){ return MkVectorD3(V.x, V.z, 0); }
inline VectorD3 SwizzX_X(VectorD3 V){ return MkVectorD3(V.x, 0, V.x); }
inline VectorD3 SwizzX_Y(VectorD3 V){ return MkVectorD3(V.x, 0, V.y); }
inline VectorD3 SwizzX_Z(VectorD3 V){ return MkVectorD3(V.x, 0, V.z); }
inline VectorD3 SwizzX__(VectorD3 V){ return MkVectorD3(V.x, 0, 0); }
inline VectorD3 SwizzYXX(VectorD3 V){ return MkVectorD3(V.y, V.x, V.x); }
inline VectorD3 SwizzYXY(VectorD3 V){ return MkVectorD3(V.y, V.x, V.y); }
inline VectorD3 SwizzYXZ(VectorD3 V){ return MkVectorD3(V.y, V.x, V.z); }
inline VectorD3 SwizzYX_(VectorD3 V){ return MkVectorD3(V.y, V.x, 0); }
inline VectorD3 SwizzYYX(VectorD3 V){ return MkVectorD3(V.y, V.y, V.x); }
inline VectorD3 SwizzYYY(VectorD3 V){ return MkVectorD3(V.y, V.y, V.y); }
inline VectorD3 SwizzYYZ(VectorD3 V){ return MkVectorD3(V.y, V.y, V.z); }
inline VectorD3 SwizzYY_(VectorD3 V){ return MkVectorD3(V.y, V.y, 0); }
inline VectorD3 SwizzYZX(VectorD3 V){ return MkVectorD3(V.y, V.z, V.x); }
inline VectorD3 SwizzYZY(VectorD3 V){ return MkVectorD3(V.y, V.z, V.y); }
inline VectorD3 SwizzYZZ(VectorD3 V){ return MkVectorD3(V.y, V.z, V.z); }
inline VectorD3 SwizzYZ_(VectorD3 V){ return MkVectorD3(V.y, V.z, 0); }
inline VectorD3 SwizzY_X(VectorD3 V){ return MkVectorD3(V.y, 0, V.x); }
inline VectorD3 SwizzY_Y(VectorD3 V){ return MkVectorD3(V.y, 0, V.y); }
inline VectorD3 SwizzY_Z(VectorD3 V){ return MkVectorD3(V.y, 0, V.z); }
inline VectorD3 SwizzY__(VectorD3 V){ return MkVectorD3(V.y, 0, 0); }
inline VectorD3 SwizzZXX(VectorD3 V){ return MkVectorD3(V.z, V.x, V.x); }
inline VectorD3 SwizzZXY(VectorD3 V){ return MkVectorD3(V.z, V.x, V.y); }
inline VectorD3 SwizzZXZ(VectorD3 V){ return MkVectorD3(V.z, V.x, V.z); }
inline VectorD3 SwizzZX_(VectorD3 V){ return MkVectorD3(V.z, V.x, 0); }
inline VectorD3 SwizzZYX(VectorD3 V){ return MkVectorD3(V.z, V.y, V.x); }
inline VectorD3 SwizzZYY(VectorD3 V){ return MkVectorD3(V.z, V.y, V.y); }
inline VectorD3 SwizzZYZ(VectorD3 V){ return MkVectorD3(V.z, V.y, V.z); }
inline VectorD3 SwizzZY_(VectorD3 V){ return MkVectorD3(V.z, V.y, 0); }
inline VectorD3 SwizzZZX(VectorD3 V){ return MkVectorD3(V.z, V.z, V.x); }
inline VectorD3 SwizzZZY(VectorD3 V){ return MkVectorD3(V.z, V.z, V.y); }
inline VectorD3 SwizzZZZ(VectorD3 V){ return MkVectorD3(V.z, V.z, V.z); }
inline VectorD3 SwizzZZ_(VectorD3 V){ return MkVectorD3(V.z, V.z, 0); }
inline VectorD3 SwizzZ_X(VectorD3 V){ return MkVectorD3(V.z, 0, V.x); }
inline VectorD3 SwizzZ_Y(VectorD3 V){ return MkVectorD3(V.z, 0, V.y); }
inline VectorD3 SwizzZ_Z(VectorD3 V){ return MkVectorD3(V.z, 0, V.z); }
inline VectorD3 SwizzZ__(VectorD3 V){ return MkVectorD3(V.z, 0, 0); }
inline VectorD3 Swizz_XX(VectorD3 V){ return MkVectorD3(0, V.x, V.x); }
inline VectorD3 Swizz_XY(VectorD3 V){ return MkVectorD3(0, V.x, V.y); }
inline VectorD3 Swizz_XZ(VectorD3 V){ return MkVectorD3(0, V.x, V.z); }
inline VectorD3 Swizz_X_(VectorD3 V){ return MkVectorD3(0, V.x, 0); }
inline VectorD3 Swizz_YX(VectorD3 V){ return MkVectorD3(0, V.y, V.x); }
inline VectorD3 Swizz_YY(VectorD3 V){ return MkVectorD3(0, V.y, V.y); }
inline VectorD3 Swizz_YZ(VectorD3 V){ return MkVectorD3(0, V.y, V.z); }
inline VectorD3 Swizz_Y_(VectorD3 V){ return MkVectorD3(0, V.y, 0); }
inline VectorD3 Swizz_ZX(VectorD3 V){ return MkVectorD3(0, V.z, V.x); }
inline VectorD3 Swizz_ZY(VectorD3 V){ return MkVectorD3(0, V.z, V.y); }
inline VectorD3 Swizz_ZZ(VectorD3 V){ return MkVectorD3(0, V.z, V.z); }
inline VectorD3 Swizz_Z_(VectorD3 V){ return MkVectorD3(0, V.z, 0); }
inline VectorD3 Swizz__X(VectorD3 V){ return MkVectorD3(0, 0, V.x); }
inline VectorD3 Swizz__Y(VectorD3 V){ return MkVectorD3(0, 0, V.y); }
inline VectorD3 Swizz__Z(VectorD3 V){ return MkVectorD3(0, 0, V.z); }
inline VectorD4 SwizzXXXX(VectorD3 V){ return MkVectorD4(V.x, V.x, V.x, V.x); }
inline VectorD4 SwizzXXXY(VectorD3 V){ return MkVectorD4(V.x, V.x, V.x, V.y); }
inline VectorD4 SwizzXXXZ(VectorD3 V){ return MkVectorD4(V.x, V.x, V.x, V.z); }
inline VectorD4 SwizzXXX_(VectorD3 V){ return MkVectorD4(V.x, V.x, V.x, 0); }
inline VectorD4 SwizzXXYX(VectorD3 V){ return MkVectorD4(V.x, V.x, V.y, V.x); }
inline VectorD4 SwizzXXYY(VectorD3 V){ return MkVectorD4(V.x, V.x, V.y, V.y); }
inline VectorD4 SwizzXXYZ(VectorD3 V){ return MkVectorD4(V.x, V.x, V.y, V.z); }
inline VectorD4 SwizzXXY_(VectorD3 V){ return MkVectorD4(V.x, V.x, V.y, 0); }
inline VectorD4 SwizzXXZX(VectorD3 V){ return MkVectorD4(V.x, V.x, V.z, V.x); }
inline VectorD4 SwizzXXZY(VectorD3 V){ return MkVectorD4(V.x, V.x, V.z, V.y); }
inline VectorD4 SwizzXXZZ(VectorD3 V){ return MkVectorD4(V.x, V.x, V.z, V.z); }
inline VectorD4 SwizzXXZ_(VectorD3 V){ return MkVectorD4(V.x, V.x, V.z, 0); }
inline VectorD4 SwizzXX_X(VectorD3 V){ return MkVectorD4(V.x, V.x, 0, V.x); }
inline VectorD4 SwizzXX_Y(VectorD3 V){ return MkVectorD4(V.x, V.x, 0, V.y); }
inline VectorD4 SwizzXX_Z(VectorD3 V){ return MkVectorD4(V.x, V.x, 0, V.z); }
inline VectorD4 SwizzXX__(VectorD3 V){ return MkVectorD4(V.x, V.x, 0, 0); }
inline VectorD4 SwizzXYXX(VectorD3 V){ return MkVectorD4(V.x, V.y, V.x, V.x); }
inline VectorD4 SwizzXYXY(VectorD3 V){ return MkVectorD4(V.x, V.y, V.x, V.y); }
inline VectorD4 SwizzXYXZ(VectorD3 V){ return MkVectorD4(V.x, V.y, V.x, V.z); }
inline VectorD4 SwizzXYX_(VectorD3 V){ return MkVectorD4(V.x, V.y, V.x, 0); }
inline VectorD4 SwizzXYYX(VectorD3 V){ return MkVectorD4(V.x, V.y, V.y, V.x); }
inline VectorD4 SwizzXYYY(VectorD3 V){ return MkVectorD4(V.x, V.y, V.y, V.y); }
inline VectorD4 SwizzXYYZ(VectorD3 V){ return MkVectorD4(V.x, V.y, V.y, V.z); }
inline VectorD4 SwizzXYY_(VectorD3 V){ return MkVectorD4(V.x, V.y, V.y, 0); }
inline VectorD4 SwizzXYZX(VectorD3 V){ return MkVectorD4(V.x, V.y, V.z, V.x); }
inline VectorD4 SwizzXYZY(VectorD3 V){ return MkVectorD4(V.x, V.y, V.z, V.y); }
inline VectorD4 SwizzXYZZ(VectorD3 V){ return MkVectorD4(V.x, V.y, V.z, V.z); }
inline VectorD4 SwizzXYZ_(VectorD3 V){ return MkVectorD4(V.x, V.y, V.z, 0); }
inline VectorD4 SwizzXY_X(VectorD3 V){ return MkVectorD4(V.x, V.y, 0, V.x); }
inline VectorD4 SwizzXY_Y(VectorD3 V){ return MkVectorD4(V.x, V.y, 0, V.y); }
inline VectorD4 SwizzXY_Z(VectorD3 V){ return MkVectorD4(V.x, V.y, 0, V.z); }
inline VectorD4 SwizzXY__(VectorD3 V){ return MkVectorD4(V.x, V.y, 0, 0); }
inline VectorD4 SwizzXZXX(VectorD3 V){ return MkVectorD4(V.x, V.z, V.x, V.x); }
inline VectorD4 SwizzXZXY(VectorD3 V){ return MkVectorD4(V.x, V.z, V.x, V.y); }
inline VectorD4 SwizzXZXZ(VectorD3 V){ return MkVectorD4(V.x, V.z, V.x, V.z); }
inline VectorD4 SwizzXZX_(VectorD3 V){ return MkVectorD4(V.x, V.z, V.x, 0); }
inline VectorD4 SwizzXZYX(VectorD3 V){ return MkVectorD4(V.x, V.z, V.y, V.x); }
inline VectorD4 SwizzXZYY(VectorD3 V){ return MkVectorD4(V.x, V.z, V.y, V.y); }
inline VectorD4 SwizzXZYZ(VectorD3 V){ return MkVectorD4(V.x, V.z, V.y, V.z); }
inline VectorD4 SwizzXZY_(VectorD3 V){ return MkVectorD4(V.x, V.z, V.y, 0); }
inline VectorD4 SwizzXZZX(VectorD3 V){ return MkVectorD4(V.x, V.z, V.z, V.x); }
inline VectorD4 SwizzXZZY(VectorD3 V){ return MkVectorD4(V.x, V.z, V.z, V.y); }
inline VectorD4 SwizzXZZZ(VectorD3 V){ return MkVectorD4(V.x, V.z, V.z, V.z); }
inline VectorD4 SwizzXZZ_(VectorD3 V){ return MkVectorD4(V.x, V.z, V.z, 0); }
inline VectorD4 SwizzXZ_X(VectorD3 V){ return MkVectorD4(V.x, V.z, 0, V.x); }
inline VectorD4 SwizzXZ_Y(VectorD3 V){ return MkVectorD4(V.x, V.z, 0, V.y); }
inline VectorD4 SwizzXZ_Z(VectorD3 V){ return MkVectorD4(V.x, V.z, 0, V.z); }
inline VectorD4 SwizzXZ__(VectorD3 V){ return MkVectorD4(V.x, V.z, 0, 0); }
inline VectorD4 SwizzX_XX(VectorD3 V){ return MkVectorD4(V.x, 0, V.x, V.x); }
inline VectorD4 SwizzX_XY(VectorD3 V){ return MkVectorD4(V.x, 0, V.x, V.y); }
inline VectorD4 SwizzX_XZ(VectorD3 V){ return MkVectorD4(V.x, 0, V.x, V.z); }
inline VectorD4 SwizzX_X_(VectorD3 V){ return MkVectorD4(V.x, 0, V.x, 0); }
inline VectorD4 SwizzX_YX(VectorD3 V){ return MkVectorD4(V.x, 0, V.y, V.x); }
inline VectorD4 SwizzX_YY(VectorD3 V){ return MkVectorD4(V.x, 0, V.y, V.y); }
inline VectorD4 SwizzX_YZ(VectorD3 V){ return MkVectorD4(V.x, 0, V.y, V.z); }
inline VectorD4 SwizzX_Y_(VectorD3 V){ return MkVectorD4(V.x, 0, V.y, 0); }
inline VectorD4 SwizzX_ZX(VectorD3 V){ return MkVectorD4(V.x, 0, V.z, V.x); }
inline VectorD4 SwizzX_ZY(VectorD3 V){ return MkVectorD4(V.x, 0, V.z, V.y); }
inline VectorD4 SwizzX_ZZ(VectorD3 V){ return MkVectorD4(V.x, 0, V.z, V.z); }
inline VectorD4 SwizzX_Z_(VectorD3 V){ return MkVectorD4(V.x, 0, V.z, 0); }
inline VectorD4 SwizzX__X(VectorD3 V){ return MkVectorD4(V.x, 0, 0, V.x); }
inline VectorD4 SwizzX__Y(VectorD3 V){ return MkVectorD4(V.x, 0, 0, V.y); }
inline VectorD4 SwizzX__Z(VectorD3 V){ return MkVectorD4(V.x, 0, 0, V.z); }
inline VectorD4 SwizzX___(VectorD3 V){ return MkVectorD4(V.x, 0, 0, 0); }
inline VectorD4 SwizzYXXX(VectorD3 V){ return MkVectorD4(V.y, V.x, V.x, V.x); }
inline VectorD4 SwizzYXXY(VectorD3 V){ return MkVectorD4(V.y, V.x, V.x, V.y); }
inline VectorD4 SwizzYXXZ(VectorD3 V){ return MkVectorD4(V.y, V.x, V.x, V.z); }
inline VectorD4 SwizzYXX_(VectorD3 V){ return MkVectorD4(V.y, V.x, V.x, 0); }
inline VectorD4 SwizzYXYX(VectorD3 V){ return MkVectorD4(V.y, V.x, V.y, V.x); }
inline VectorD4 SwizzYXYY(VectorD3 V){ return MkVectorD4(V.y, V.x, V.y, V.y); }
inline VectorD4 SwizzYXYZ(VectorD3 V){ return MkVectorD4(V.y, V.x, V.y, V.z); }
inline VectorD4 SwizzYXY_(VectorD3 V){ return MkVectorD4(V.y, V.x, V.y, 0); }
inline VectorD4 SwizzYXZX(VectorD3 V){ return MkVectorD4(V.y, V.x, V.z, V.x); }
inline VectorD4 SwizzYXZY(VectorD3 V){ return MkVectorD4(V.y, V.x, V.z, V.y); }
inline VectorD4 SwizzYXZZ(VectorD3 V){ return MkVectorD4(V.y, V.x, V.z, V.z); }
inline VectorD4 SwizzYXZ_(VectorD3 V){ return MkVectorD4(V.y, V.x, V.z, 0); }
inline VectorD4 SwizzYX_X(VectorD3 V){ return MkVectorD4(V.y, V.x, 0, V.x); }
inline VectorD4 SwizzYX_Y(VectorD3 V){ return MkVectorD4(V.y, V.x, 0, V.y); }
inline VectorD4 SwizzYX_Z(VectorD3 V){ return MkVectorD4(V.y, V.x, 0, V.z); }
inline VectorD4 SwizzYX__(VectorD3 V){ return MkVectorD4(V.y, V.x, 0, 0); }
inline VectorD4 SwizzYYXX(VectorD3 V){ return MkVectorD4(V.y, V.y, V.x, V.x); }
inline VectorD4 SwizzYYXY(VectorD3 V){ return MkVectorD4(V.y, V.y, V.x, V.y); }
inline VectorD4 SwizzYYXZ(VectorD3 V){ return MkVectorD4(V.y, V.y, V.x, V.z); }
inline VectorD4 SwizzYYX_(VectorD3 V){ return MkVectorD4(V.y, V.y, V.x, 0); }
inline VectorD4 SwizzYYYX(VectorD3 V){ return MkVectorD4(V.y, V.y, V.y, V.x); }
inline VectorD4 SwizzYYYY(VectorD3 V){ return MkVectorD4(V.y, V.y, V.y, V.y); }
inline VectorD4 SwizzYYYZ(VectorD3 V){ return MkVectorD4(V.y, V.y, V.y, V.z); }
inline VectorD4 SwizzYYY_(VectorD3 V){ return MkVectorD4(V.y, V.y, V.y, 0); }
inline VectorD4 SwizzYYZX(VectorD3 V){ return MkVectorD4(V.y, V.y, V.z, V.x); }
inline VectorD4 SwizzYYZY(VectorD3 V){ return MkVectorD4(V.y, V.y, V.z, V.y); }
inline VectorD4 SwizzYYZZ(VectorD3 V){ return MkVectorD4(V.y, V.y, V.z, V.z); }
inline VectorD4 SwizzYYZ_(VectorD3 V){ return MkVectorD4(V.y, V.y, V.z, 0); }
inline VectorD4 SwizzYY_X(VectorD3 V){ return MkVectorD4(V.y, V.y, 0, V.x); }
inline VectorD4 SwizzYY_Y(VectorD3 V){ return MkVectorD4(V.y, V.y, 0, V.y); }
inline VectorD4 SwizzYY_Z(VectorD3 V){ return MkVectorD4(V.y, V.y, 0, V.z); }
inline VectorD4 SwizzYY__(VectorD3 V){ return MkVectorD4(V.y, V.y, 0, 0); }
inline VectorD4 SwizzYZXX(VectorD3 V){ return MkVectorD4(V.y, V.z, V.x, V.x); }
inline VectorD4 SwizzYZXY(VectorD3 V){ return MkVectorD4(V.y, V.z, V.x, V.y); }
inline VectorD4 SwizzYZXZ(VectorD3 V){ return MkVectorD4(V.y, V.z, V.x, V.z); }
inline VectorD4 SwizzYZX_(VectorD3 V){ return MkVectorD4(V.y, V.z, V.x, 0); }
inline VectorD4 SwizzYZYX(VectorD3 V){ return MkVectorD4(V.y, V.z, V.y, V.x); }
inline VectorD4 SwizzYZYY(VectorD3 V){ return MkVectorD4(V.y, V.z, V.y, V.y); }
inline VectorD4 SwizzYZYZ(VectorD3 V){ return MkVectorD4(V.y, V.z, V.y, V.z); }
inline VectorD4 SwizzYZY_(VectorD3 V){ return MkVectorD4(V.y, V.z, V.y, 0); }
inline VectorD4 SwizzYZZX(VectorD3 V){ return MkVectorD4(V.y, V.z, V.z, V.x); }
inline VectorD4 SwizzYZZY(VectorD3 V){ return MkVectorD4(V.y, V.z, V.z, V.y); }
inline VectorD4 SwizzYZZZ(VectorD3 V){ return MkVectorD4(V.y, V.z, V.z, V.z); }
inline VectorD4 SwizzYZZ_(VectorD3 V){ return MkVectorD4(V.y, V.z, V.z, 0); }
inline VectorD4 SwizzYZ_X(VectorD3 V){ return MkVectorD4(V.y, V.z, 0, V.x); }
inline VectorD4 SwizzYZ_Y(VectorD3 V){ return MkVectorD4(V.y, V.z, 0, V.y); }
inline VectorD4 SwizzYZ_Z(VectorD3 V){ return MkVectorD4(V.y, V.z, 0, V.z); }
inline VectorD4 SwizzYZ__(VectorD3 V){ return MkVectorD4(V.y, V.z, 0, 0); }
inline VectorD4 SwizzY_XX(VectorD3 V){ return MkVectorD4(V.y, 0, V.x, V.x); }
inline VectorD4 SwizzY_XY(VectorD3 V){ return MkVectorD4(V.y, 0, V.x, V.y); }
inline VectorD4 SwizzY_XZ(VectorD3 V){ return MkVectorD4(V.y, 0, V.x, V.z); }
inline VectorD4 SwizzY_X_(VectorD3 V){ return MkVectorD4(V.y, 0, V.x, 0); }
inline VectorD4 SwizzY_YX(VectorD3 V){ return MkVectorD4(V.y, 0, V.y, V.x); }
inline VectorD4 SwizzY_YY(VectorD3 V){ return MkVectorD4(V.y, 0, V.y, V.y); }
inline VectorD4 SwizzY_YZ(VectorD3 V){ return MkVectorD4(V.y, 0, V.y, V.z); }
inline VectorD4 SwizzY_Y_(VectorD3 V){ return MkVectorD4(V.y, 0, V.y, 0); }
inline VectorD4 SwizzY_ZX(VectorD3 V){ return MkVectorD4(V.y, 0, V.z, V.x); }
inline VectorD4 SwizzY_ZY(VectorD3 V){ return MkVectorD4(V.y, 0, V.z, V.y); }
inline VectorD4 SwizzY_ZZ(VectorD3 V){ return MkVectorD4(V.y, 0, V.z, V.z); }
inline VectorD4 SwizzY_Z_(VectorD3 V){ return MkVectorD4(V.y, 0, V.z, 0); }
inline VectorD4 SwizzY__X(VectorD3 V){ return MkVectorD4(V.y, 0, 0, V.x); }
inline VectorD4 SwizzY__Y(VectorD3 V){ return MkVectorD4(V.y, 0, 0, V.y); }
inline VectorD4 SwizzY__Z(VectorD3 V){ return MkVectorD4(V.y, 0, 0, V.z); }
inline VectorD4 SwizzY___(VectorD3 V){ return MkVectorD4(V.y, 0, 0, 0); }
inline VectorD4 SwizzZXXX(VectorD3 V){ return MkVectorD4(V.z, V.x, V.x, V.x); }
inline VectorD4 SwizzZXXY(VectorD3 V){ return MkVectorD4(V.z, V.x, V.x, V.y); }
inline VectorD4 SwizzZXXZ(VectorD3 V){ return MkVectorD4(V.z, V.x, V.x, V.z); }
inline VectorD4 SwizzZXX_(VectorD3 V){ return MkVectorD4(V.z, V.x, V.x, 0); }
inline VectorD4 SwizzZXYX(VectorD3 V){ return MkVectorD4(V.z, V.x, V.y, V.x); }
inline VectorD4 SwizzZXYY(VectorD3 V){ return MkVectorD4(V.z, V.x, V.y, V.y); }
inline VectorD4 SwizzZXYZ(VectorD3 V){ return MkVectorD4(V.z, V.x, V.y, V.z); }
inline VectorD4 SwizzZXY_(VectorD3 V){ return MkVectorD4(V.z, V.x, V.y, 0); }
inline VectorD4 SwizzZXZX(VectorD3 V){ return MkVectorD4(V.z, V.x, V.z, V.x); }
inline VectorD4 SwizzZXZY(VectorD3 V){ return MkVectorD4(V.z, V.x, V.z, V.y); }
inline VectorD4 SwizzZXZZ(VectorD3 V){ return MkVectorD4(V.z, V.x, V.z, V.z); }
inline VectorD4 SwizzZXZ_(VectorD3 V){ return MkVectorD4(V.z, V.x, V.z, 0); }
inline VectorD4 SwizzZX_X(VectorD3 V){ return MkVectorD4(V.z, V.x, 0, V.x); }
inline VectorD4 SwizzZX_Y(VectorD3 V){ return MkVectorD4(V.z, V.x, 0, V.y); }
inline VectorD4 SwizzZX_Z(VectorD3 V){ return MkVectorD4(V.z, V.x, 0, V.z); }
inline VectorD4 SwizzZX__(VectorD3 V){ return MkVectorD4(V.z, V.x, 0, 0); }
inline VectorD4 SwizzZYXX(VectorD3 V){ return MkVectorD4(V.z, V.y, V.x, V.x); }
inline VectorD4 SwizzZYXY(VectorD3 V){ return MkVectorD4(V.z, V.y, V.x, V.y); }
inline VectorD4 SwizzZYXZ(VectorD3 V){ return MkVectorD4(V.z, V.y, V.x, V.z); }
inline VectorD4 SwizzZYX_(VectorD3 V){ return MkVectorD4(V.z, V.y, V.x, 0); }
inline VectorD4 SwizzZYYX(VectorD3 V){ return MkVectorD4(V.z, V.y, V.y, V.x); }
inline VectorD4 SwizzZYYY(VectorD3 V){ return MkVectorD4(V.z, V.y, V.y, V.y); }
inline VectorD4 SwizzZYYZ(VectorD3 V){ return MkVectorD4(V.z, V.y, V.y, V.z); }
inline VectorD4 SwizzZYY_(VectorD3 V){ return MkVectorD4(V.z, V.y, V.y, 0); }
inline VectorD4 SwizzZYZX(VectorD3 V){ return MkVectorD4(V.z, V.y, V.z, V.x); }
inline VectorD4 SwizzZYZY(VectorD3 V){ return MkVectorD4(V.z, V.y, V.z, V.y); }
inline VectorD4 SwizzZYZZ(VectorD3 V){ return MkVectorD4(V.z, V.y, V.z, V.z); }
inline VectorD4 SwizzZYZ_(VectorD3 V){ return MkVectorD4(V.z, V.y, V.z, 0); }
inline VectorD4 SwizzZY_X(VectorD3 V){ return MkVectorD4(V.z, V.y, 0, V.x); }
inline VectorD4 SwizzZY_Y(VectorD3 V){ return MkVectorD4(V.z, V.y, 0, V.y); }
inline VectorD4 SwizzZY_Z(VectorD3 V){ return MkVectorD4(V.z, V.y, 0, V.z); }
inline VectorD4 SwizzZY__(VectorD3 V){ return MkVectorD4(V.z, V.y, 0, 0); }
inline VectorD4 SwizzZZXX(VectorD3 V){ return MkVectorD4(V.z, V.z, V.x, V.x); }
inline VectorD4 SwizzZZXY(VectorD3 V){ return MkVectorD4(V.z, V.z, V.x, V.y); }
inline VectorD4 SwizzZZXZ(VectorD3 V){ return MkVectorD4(V.z, V.z, V.x, V.z); }
inline VectorD4 SwizzZZX_(VectorD3 V){ return MkVectorD4(V.z, V.z, V.x, 0); }
inline VectorD4 SwizzZZYX(VectorD3 V){ return MkVectorD4(V.z, V.z, V.y, V.x); }
inline VectorD4 SwizzZZYY(VectorD3 V){ return MkVectorD4(V.z, V.z, V.y, V.y); }
inline VectorD4 SwizzZZYZ(VectorD3 V){ return MkVectorD4(V.z, V.z, V.y, V.z); }
inline VectorD4 SwizzZZY_(VectorD3 V){ return MkVectorD4(V.z, V.z, V.y, 0); }
inline VectorD4 SwizzZZZX(VectorD3 V){ return MkVectorD4(V.z, V.z, V.z, V.x); }
inline VectorD4 SwizzZZZY(VectorD3 V){ return MkVectorD4(V.z, V.z, V.z, V.y); }
inline VectorD4 SwizzZZZZ(VectorD3 V){ return MkVectorD4(V.z, V.z, V.z, V.z); }
inline VectorD4 SwizzZZZ_(VectorD3 V){ return MkVectorD4(V.z, V.z, V.z, 0); }
inline VectorD4 SwizzZZ_X(VectorD3 V){ return MkVectorD4(V.z, V.z, 0, V.x); }
inline VectorD4 SwizzZZ_Y(VectorD3 V){ return MkVectorD4(V.z, V.z, 0, V.y); }
inline VectorD4 SwizzZZ_Z(VectorD3 V){ return MkVectorD4(V.z, V.z, 0, V.z); }
inline VectorD4 SwizzZZ__(VectorD3 V){ return MkVectorD4(V.z, V.z, 0, 0); }
inline VectorD4 SwizzZ_XX(VectorD3 V){ return MkVectorD4(V.z, 0, V.x, V.x); }
inline VectorD4 SwizzZ_XY(VectorD3 V){ return MkVectorD4(V.z, 0, V.x, V.y); }
inline VectorD4 SwizzZ_XZ(VectorD3 V){ return MkVectorD4(V.z, 0, V.x, V.z); }
inline VectorD4 SwizzZ_X_(VectorD3 V){ return MkVectorD4(V.z, 0, V.x, 0); }
inline VectorD4 SwizzZ_YX(VectorD3 V){ return MkVectorD4(V.z, 0, V.y, V.x); }
inline VectorD4 SwizzZ_YY(VectorD3 V){ return MkVectorD4(V.z, 0, V.y, V.y); }
inline VectorD4 SwizzZ_YZ(VectorD3 V){ return MkVectorD4(V.z, 0, V.y, V.z); }
inline VectorD4 SwizzZ_Y_(VectorD3 V){ return MkVectorD4(V.z, 0, V.y, 0); }
inline VectorD4 SwizzZ_ZX(VectorD3 V){ return MkVectorD4(V.z, 0, V.z, V.x); }
inline VectorD4 SwizzZ_ZY(VectorD3 V){ return MkVectorD4(V.z, 0, V.z, V.y); }
inline VectorD4 SwizzZ_ZZ(VectorD3 V){ return MkVectorD4(V.z, 0, V.z, V.z); }
inline VectorD4 SwizzZ_Z_(VectorD3 V){ return MkVectorD4(V.z, 0, V.z, 0); }
inline VectorD4 SwizzZ__X(VectorD3 V){ return MkVectorD4(V.z, 0, 0, V.x); }
inline VectorD4 SwizzZ__Y(VectorD3 V){ return MkVectorD4(V.z, 0, 0, V.y); }
inline VectorD4 SwizzZ__Z(VectorD3 V){ return MkVectorD4(V.z, 0, 0, V.z); }
inline VectorD4 SwizzZ___(VectorD3 V){ return MkVectorD4(V.z, 0, 0, 0); }
inline VectorD4 Swizz_XXX(VectorD3 V){ return MkVectorD4(0, V.x, V.x, V.x); }
inline VectorD4 Swizz_XXY(VectorD3 V){ return MkVectorD4(0, V.x, V.x, V.y); }
inline VectorD4 Swizz_XXZ(VectorD3 V){ return MkVectorD4(0, V.x, V.x, V.z); }
inline VectorD4 Swizz_XX_(VectorD3 V){ return MkVectorD4(0, V.x, V.x, 0); }
inline VectorD4 Swizz_XYX(VectorD3 V){ return MkVectorD4(0, V.x, V.y, V.x); }
inline VectorD4 Swizz_XYY(VectorD3 V){ return MkVectorD4(0, V.x, V.y, V.y); }
inline VectorD4 Swizz_XYZ(VectorD3 V){ return MkVectorD4(0, V.x, V.y, V.z); }
inline VectorD4 Swizz_XY_(VectorD3 V){ return MkVectorD4(0, V.x, V.y, 0); }
inline VectorD4 Swizz_XZX(VectorD3 V){ return MkVectorD4(0, V.x, V.z, V.x); }
inline VectorD4 Swizz_XZY(VectorD3 V){ return MkVectorD4(0, V.x, V.z, V.y); }
inline VectorD4 Swizz_XZZ(VectorD3 V){ return MkVectorD4(0, V.x, V.z, V.z); }
inline VectorD4 Swizz_XZ_(VectorD3 V){ return MkVectorD4(0, V.x, V.z, 0); }
inline VectorD4 Swizz_X_X(VectorD3 V){ return MkVectorD4(0, V.x, 0, V.x); }
inline VectorD4 Swizz_X_Y(VectorD3 V){ return MkVectorD4(0, V.x, 0, V.y); }
inline VectorD4 Swizz_X_Z(VectorD3 V){ return MkVectorD4(0, V.x, 0, V.z); }
inline VectorD4 Swizz_X__(VectorD3 V){ return MkVectorD4(0, V.x, 0, 0); }
inline VectorD4 Swizz_YXX(VectorD3 V){ return MkVectorD4(0, V.y, V.x, V.x); }
inline VectorD4 Swizz_YXY(VectorD3 V){ return MkVectorD4(0, V.y, V.x, V.y); }
inline VectorD4 Swizz_YXZ(VectorD3 V){ return MkVectorD4(0, V.y, V.x, V.z); }
inline VectorD4 Swizz_YX_(VectorD3 V){ return MkVectorD4(0, V.y, V.x, 0); }
inline VectorD4 Swizz_YYX(VectorD3 V){ return MkVectorD4(0, V.y, V.y, V.x); }
inline VectorD4 Swizz_YYY(VectorD3 V){ return MkVectorD4(0, V.y, V.y, V.y); }
inline VectorD4 Swizz_YYZ(VectorD3 V){ return MkVectorD4(0, V.y, V.y, V.z); }
inline VectorD4 Swizz_YY_(VectorD3 V){ return MkVectorD4(0, V.y, V.y, 0); }
inline VectorD4 Swizz_YZX(VectorD3 V){ return MkVectorD4(0, V.y, V.z, V.x); }
inline VectorD4 Swizz_YZY(VectorD3 V){ return MkVectorD4(0, V.y, V.z, V.y); }
inline VectorD4 Swizz_YZZ(VectorD3 V){ return MkVectorD4(0, V.y, V.z, V.z); }
inline VectorD4 Swizz_YZ_(VectorD3 V){ return MkVectorD4(0, V.y, V.z, 0); }
inline VectorD4 Swizz_Y_X(VectorD3 V){ return MkVectorD4(0, V.y, 0, V.x); }
inline VectorD4 Swizz_Y_Y(VectorD3 V){ return MkVectorD4(0, V.y, 0, V.y); }
inline VectorD4 Swizz_Y_Z(VectorD3 V){ return MkVectorD4(0, V.y, 0, V.z); }
inline VectorD4 Swizz_Y__(VectorD3 V){ return MkVectorD4(0, V.y, 0, 0); }
inline VectorD4 Swizz_ZXX(VectorD3 V){ return MkVectorD4(0, V.z, V.x, V.x); }
inline VectorD4 Swizz_ZXY(VectorD3 V){ return MkVectorD4(0, V.z, V.x, V.y); }
inline VectorD4 Swizz_ZXZ(VectorD3 V){ return MkVectorD4(0, V.z, V.x, V.z); }
inline VectorD4 Swizz_ZX_(VectorD3 V){ return MkVectorD4(0, V.z, V.x, 0); }
inline VectorD4 Swizz_ZYX(VectorD3 V){ return MkVectorD4(0, V.z, V.y, V.x); }
inline VectorD4 Swizz_ZYY(VectorD3 V){ return MkVectorD4(0, V.z, V.y, V.y); }
inline VectorD4 Swizz_ZYZ(VectorD3 V){ return MkVectorD4(0, V.z, V.y, V.z); }
inline VectorD4 Swizz_ZY_(VectorD3 V){ return MkVectorD4(0, V.z, V.y, 0); }
inline VectorD4 Swizz_ZZX(VectorD3 V){ return MkVectorD4(0, V.z, V.z, V.x); }
inline VectorD4 Swizz_ZZY(VectorD3 V){ return MkVectorD4(0, V.z, V.z, V.y); }
inline VectorD4 Swizz_ZZZ(VectorD3 V){ return MkVectorD4(0, V.z, V.z, V.z); }
inline VectorD4 Swizz_ZZ_(VectorD3 V){ return MkVectorD4(0, V.z, V.z, 0); }
inline VectorD4 Swizz_Z_X(VectorD3 V){ return MkVectorD4(0, V.z, 0, V.x); }
inline VectorD4 Swizz_Z_Y(VectorD3 V){ return MkVectorD4(0, V.z, 0, V.y); }
inline VectorD4 Swizz_Z_Z(VectorD3 V){ return MkVectorD4(0, V.z, 0, V.z); }
inline VectorD4 Swizz_Z__(VectorD3 V){ return MkVectorD4(0, V.z, 0, 0); }
inline VectorD4 Swizz__XX(VectorD3 V){ return MkVectorD4(0, 0, V.x, V.x); }
inline VectorD4 Swizz__XY(VectorD3 V){ return MkVectorD4(0, 0, V.x, V.y); }
inline VectorD4 Swizz__XZ(VectorD3 V){ return MkVectorD4(0, 0, V.x, V.z); }
inline VectorD4 Swizz__X_(VectorD3 V){ return MkVectorD4(0, 0, V.x, 0); }
inline VectorD4 Swizz__YX(VectorD3 V){ return MkVectorD4(0, 0, V.y, V.x); }
inline VectorD4 Swizz__YY(VectorD3 V){ return MkVectorD4(0, 0, V.y, V.y); }
inline VectorD4 Swizz__YZ(VectorD3 V){ return MkVectorD4(0, 0, V.y, V.z); }
inline VectorD4 Swizz__Y_(VectorD3 V){ return MkVectorD4(0, 0, V.y, 0); }
inline VectorD4 Swizz__ZX(VectorD3 V){ return MkVectorD4(0, 0, V.z, V.x); }
inline VectorD4 Swizz__ZY(VectorD3 V){ return MkVectorD4(0, 0, V.z, V.y); }
inline VectorD4 Swizz__ZZ(VectorD3 V){ return MkVectorD4(0, 0, V.z, V.z); }
inline VectorD4 Swizz__Z_(VectorD3 V){ return MkVectorD4(0, 0, V.z, 0); }
inline VectorD4 Swizz___X(VectorD3 V){ return MkVectorD4(0, 0, 0, V.x); }
inline VectorD4 Swizz___Y(VectorD3 V){ return MkVectorD4(0, 0, 0, V.y); }
inline VectorD4 Swizz___Z(VectorD3 V){ return MkVectorD4(0, 0, 0, V.z); }
inline VectorD2 SwizzXX(VectorD4 V){ return MkVectorD2(V.x, V.x); }
inline VectorD2 SwizzXY(VectorD4 V){ return MkVectorD2(V.x, V.y); }
inline VectorD2 SwizzXZ(VectorD4 V){ return MkVectorD2(V.x, V.z); }
inline VectorD2 SwizzXW(VectorD4 V){ return MkVectorD2(V.x, V.w); }
inline VectorD2 SwizzX_(VectorD4 V){ return MkVectorD2(V.x, 0); }
inline VectorD2 SwizzYX(VectorD4 V){ return MkVectorD2(V.y, V.x); }
inline VectorD2 SwizzYY(VectorD4 V){ return MkVectorD2(V.y, V.y); }
inline VectorD2 SwizzYZ(VectorD4 V){ return MkVectorD2(V.y, V.z); }
inline VectorD2 SwizzYW(VectorD4 V){ return MkVectorD2(V.y, V.w); }
inline VectorD2 SwizzY_(VectorD4 V){ return MkVectorD2(V.y, 0); }
inline VectorD2 SwizzZX(VectorD4 V){ return MkVectorD2(V.z, V.x); }
inline VectorD2 SwizzZY(VectorD4 V){ return MkVectorD2(V.z, V.y); }
inline VectorD2 SwizzZZ(VectorD4 V){ return MkVectorD2(V.z, V.z); }
inline VectorD2 SwizzZW(VectorD4 V){ return MkVectorD2(V.z, V.w); }
inline VectorD2 SwizzZ_(VectorD4 V){ return MkVectorD2(V.z, 0); }
inline VectorD2 SwizzWX(VectorD4 V){ return MkVectorD2(V.w, V.x); }
inline VectorD2 SwizzWY(VectorD4 V){ return MkVectorD2(V.w, V.y); }
inline VectorD2 SwizzWZ(VectorD4 V){ return MkVectorD2(V.w, V.z); }
inline VectorD2 SwizzWW(VectorD4 V){ return MkVectorD2(V.w, V.w); }
inline VectorD2 SwizzW_(VectorD4 V){ return MkVectorD2(V.w, 0); }
inline VectorD2 Swizz_X(VectorD4 V){ return MkVectorD2(0, V.x); }
inline VectorD2 Swizz_Y(VectorD4 V){ return MkVectorD2(0, V.y); }
inline VectorD2 Swizz_Z(VectorD4 V){ return MkVectorD2(0, V.z); }
inline VectorD2 Swizz_W(VectorD4 V){ return MkVectorD2(0, V.w); }
inline VectorD3 SwizzXXX(VectorD4 V){ return MkVectorD3(V.x, V.x, V.x); }
inline VectorD3 SwizzXXY(VectorD4 V){ return MkVectorD3(V.x, V.x, V.y); }
inline VectorD3 SwizzXXZ(VectorD4 V){ return MkVectorD3(V.x, V.x, V.z); }
inline VectorD3 SwizzXXW(VectorD4 V){ return MkVectorD3(V.x, V.x, V.w); }
inline VectorD3 SwizzXX_(VectorD4 V){ return MkVectorD3(V.x, V.x, 0); }
inline VectorD3 SwizzXYX(VectorD4 V){ return MkVectorD3(V.x, V.y, V.x); }
inline VectorD3 SwizzXYY(VectorD4 V){ return MkVectorD3(V.x, V.y, V.y); }
inline VectorD3 SwizzXYZ(VectorD4 V){ return MkVectorD3(V.x, V.y, V.z); }
inline VectorD3 SwizzXYW(VectorD4 V){ return MkVectorD3(V.x, V.y, V.w); }
inline VectorD3 SwizzXY_(VectorD4 V){ return MkVectorD3(V.x, V.y, 0); }
inline VectorD3 SwizzXZX(VectorD4 V){ return MkVectorD3(V.x, V.z, V.x); }
inline VectorD3 SwizzXZY(VectorD4 V){ return MkVectorD3(V.x, V.z, V.y); }
inline VectorD3 SwizzXZZ(VectorD4 V){ return MkVectorD3(V.x, V.z, V.z); }
inline VectorD3 SwizzXZW(VectorD4 V){ return MkVectorD3(V.x, V.z, V.w); }
inline VectorD3 SwizzXZ_(VectorD4 V){ return MkVectorD3(V.x, V.z, 0); }
inline VectorD3 SwizzXWX(VectorD4 V){ return MkVectorD3(V.x, V.w, V.x); }
inline VectorD3 SwizzXWY(VectorD4 V){ return MkVectorD3(V.x, V.w, V.y); }
inline VectorD3 SwizzXWZ(VectorD4 V){ return MkVectorD3(V.x, V.w, V.z); }
inline VectorD3 SwizzXWW(VectorD4 V){ return MkVectorD3(V.x, V.w, V.w); }
inline VectorD3 SwizzXW_(VectorD4 V){ return MkVectorD3(V.x, V.w, 0); }
inline VectorD3 SwizzX_X(VectorD4 V){ return MkVectorD3(V.x, 0, V.x); }
inline VectorD3 SwizzX_Y(VectorD4 V){ return MkVectorD3(V.x, 0, V.y); }
inline VectorD3 SwizzX_Z(VectorD4 V){ return MkVectorD3(V.x, 0, V.z); }
inline VectorD3 SwizzX_W(VectorD4 V){ return MkVectorD3(V.x, 0, V.w); }
inline VectorD3 SwizzX__(VectorD4 V){ return MkVectorD3(V.x, 0, 0); }
inline VectorD3 SwizzYXX(VectorD4 V){ return MkVectorD3(V.y, V.x, V.x); }
inline VectorD3 SwizzYXY(VectorD4 V){ return MkVectorD3(V.y, V.x, V.y); }
inline VectorD3 SwizzYXZ(VectorD4 V){ return MkVectorD3(V.y, V.x, V.z); }
inline VectorD3 SwizzYXW(VectorD4 V){ return MkVectorD3(V.y, V.x, V.w); }
inline VectorD3 SwizzYX_(VectorD4 V){ return MkVectorD3(V.y, V.x, 0); }
inline VectorD3 SwizzYYX(VectorD4 V){ return MkVectorD3(V.y, V.y, V.x); }
inline VectorD3 SwizzYYY(VectorD4 V){ return MkVectorD3(V.y, V.y, V.y); }
inline VectorD3 SwizzYYZ(VectorD4 V){ return MkVectorD3(V.y, V.y, V.z); }
inline VectorD3 SwizzYYW(VectorD4 V){ return MkVectorD3(V.y, V.y, V.w); }
inline VectorD3 SwizzYY_(VectorD4 V){ return MkVectorD3(V.y, V.y, 0); }
inline VectorD3 SwizzYZX(VectorD4 V){ return MkVectorD3(V.y, V.z, V.x); }
inline VectorD3 SwizzYZY(VectorD4 V){ return MkVectorD3(V.y, V.z, V.y); }
inline VectorD3 SwizzYZZ(VectorD4 V){ return MkVectorD3(V.y, V.z, V.z); }
inline VectorD3 SwizzYZW(VectorD4 V){ return MkVectorD3(V.y, V.z, V.w); }
inline VectorD3 SwizzYZ_(VectorD4 V){ return MkVectorD3(V.y, V.z, 0); }
inline VectorD3 SwizzYWX(VectorD4 V){ return MkVectorD3(V.y, V.w, V.x); }
inline VectorD3 SwizzYWY(VectorD4 V){ return MkVectorD3(V.y, V.w, V.y); }
inline VectorD3 SwizzYWZ(VectorD4 V){ return MkVectorD3(V.y, V.w, V.z); }
inline VectorD3 SwizzYWW(VectorD4 V){ return MkVectorD3(V.y, V.w, V.w); }
inline VectorD3 SwizzYW_(VectorD4 V){ return MkVectorD3(V.y, V.w, 0); }
inline VectorD3 SwizzY_X(VectorD4 V){ return MkVectorD3(V.y, 0, V.x); }
inline VectorD3 SwizzY_Y(VectorD4 V){ return MkVectorD3(V.y, 0, V.y); }
inline VectorD3 SwizzY_Z(VectorD4 V){ return MkVectorD3(V.y, 0, V.z); }
inline VectorD3 SwizzY_W(VectorD4 V){ return MkVectorD3(V.y, 0, V.w); }
inline VectorD3 SwizzY__(VectorD4 V){ return MkVectorD3(V.y, 0, 0); }
inline VectorD3 SwizzZXX(VectorD4 V){ return MkVectorD3(V.z, V.x, V.x); }
inline VectorD3 SwizzZXY(VectorD4 V){ return MkVectorD3(V.z, V.x, V.y); }
inline VectorD3 SwizzZXZ(VectorD4 V){ return MkVectorD3(V.z, V.x, V.z); }
inline VectorD3 SwizzZXW(VectorD4 V){ return MkVectorD3(V.z, V.x, V.w); }
inline VectorD3 SwizzZX_(VectorD4 V){ return MkVectorD3(V.z, V.x, 0); }
inline VectorD3 SwizzZYX(VectorD4 V){ return MkVectorD3(V.z, V.y, V.x); }
inline VectorD3 SwizzZYY(VectorD4 V){ return MkVectorD3(V.z, V.y, V.y); }
inline VectorD3 SwizzZYZ(VectorD4 V){ return MkVectorD3(V.z, V.y, V.z); }
inline VectorD3 SwizzZYW(VectorD4 V){ return MkVectorD3(V.z, V.y, V.w); }
inline VectorD3 SwizzZY_(VectorD4 V){ return MkVectorD3(V.z, V.y, 0); }
inline VectorD3 SwizzZZX(VectorD4 V){ return MkVectorD3(V.z, V.z, V.x); }
inline VectorD3 SwizzZZY(VectorD4 V){ return MkVectorD3(V.z, V.z, V.y); }
inline VectorD3 SwizzZZZ(VectorD4 V){ return MkVectorD3(V.z, V.z, V.z); }
inline VectorD3 SwizzZZW(VectorD4 V){ return MkVectorD3(V.z, V.z, V.w); }
inline VectorD3 SwizzZZ_(VectorD4 V){ return MkVectorD3(V.z, V.z, 0); }
inline VectorD3 SwizzZWX(VectorD4 V){ return MkVectorD3(V.z, V.w, V.x); }
inline VectorD3 SwizzZWY(VectorD4 V){ return MkVectorD3(V.z, V.w, V.y); }
inline VectorD3 SwizzZWZ(VectorD4 V){ return MkVectorD3(V.z, V.w, V.z); }
inline VectorD3 SwizzZWW(VectorD4 V){ return MkVectorD3(V.z, V.w, V.w); }
inline VectorD3 SwizzZW_(VectorD4 V){ return MkVectorD3(V.z, V.w, 0); }
inline VectorD3 SwizzZ_X(VectorD4 V){ return MkVectorD3(V.z, 0, V.x); }
inline VectorD3 SwizzZ_Y(VectorD4 V){ return MkVectorD3(V.z, 0, V.y); }
inline VectorD3 SwizzZ_Z(VectorD4 V){ return MkVectorD3(V.z, 0, V.z); }
inline VectorD3 SwizzZ_W(VectorD4 V){ return MkVectorD3(V.z, 0, V.w); }
inline VectorD3 SwizzZ__(VectorD4 V){ return MkVectorD3(V.z, 0, 0); }
inline VectorD3 SwizzWXX(VectorD4 V){ return MkVectorD3(V.w, V.x, V.x); }
inline VectorD3 SwizzWXY(VectorD4 V){ return MkVectorD3(V.w, V.x, V.y); }
inline VectorD3 SwizzWXZ(VectorD4 V){ return MkVectorD3(V.w, V.x, V.z); }
inline VectorD3 SwizzWXW(VectorD4 V){ return MkVectorD3(V.w, V.x, V.w); }
inline VectorD3 SwizzWX_(VectorD4 V){ return MkVectorD3(V.w, V.x, 0); }
inline VectorD3 SwizzWYX(VectorD4 V){ return MkVectorD3(V.w, V.y, V.x); }
inline VectorD3 SwizzWYY(VectorD4 V){ return MkVectorD3(V.w, V.y, V.y); }
inline VectorD3 SwizzWYZ(VectorD4 V){ return MkVectorD3(V.w, V.y, V.z); }
inline VectorD3 SwizzWYW(VectorD4 V){ return MkVectorD3(V.w, V.y, V.w); }
inline VectorD3 SwizzWY_(VectorD4 V){ return MkVectorD3(V.w, V.y, 0); }
inline VectorD3 SwizzWZX(VectorD4 V){ return MkVectorD3(V.w, V.z, V.x); }
inline VectorD3 SwizzWZY(VectorD4 V){ return MkVectorD3(V.w, V.z, V.y); }
inline VectorD3 SwizzWZZ(VectorD4 V){ return MkVectorD3(V.w, V.z, V.z); }
inline VectorD3 SwizzWZW(VectorD4 V){ return MkVectorD3(V.w, V.z, V.w); }
inline VectorD3 SwizzWZ_(VectorD4 V){ return MkVectorD3(V.w, V.z, 0); }
inline VectorD3 SwizzWWX(VectorD4 V){ return MkVectorD3(V.w, V.w, V.x); }
inline VectorD3 SwizzWWY(VectorD4 V){ return MkVectorD3(V.w, V.w, V.y); }
inline VectorD3 SwizzWWZ(VectorD4 V){ return MkVectorD3(V.w, V.w, V.z); }
inline VectorD3 SwizzWWW(VectorD4 V){ return MkVectorD3(V.w, V.w, V.w); }
inline VectorD3 SwizzWW_(VectorD4 V){ return MkVectorD3(V.w, V.w, 0); }
inline VectorD3 SwizzW_X(VectorD4 V){ return MkVectorD3(V.w, 0, V.x); }
inline VectorD3 SwizzW_Y(VectorD4 V){ return MkVectorD3(V.w, 0, V.y); }
inline VectorD3 SwizzW_Z(VectorD4 V){ return MkVectorD3(V.w, 0, V.z); }
inline VectorD3 SwizzW_W(VectorD4 V){ return MkVectorD3(V.w, 0, V.w); }
inline VectorD3 SwizzW__(VectorD4 V){ return MkVectorD3(V.w, 0, 0); }
inline VectorD3 Swizz_XX(VectorD4 V){ return MkVectorD3(0, V.x, V.x); }
inline VectorD3 Swizz_XY(VectorD4 V){ return MkVectorD3(0, V.x, V.y); }
inline VectorD3 Swizz_XZ(VectorD4 V){ return MkVectorD3(0, V.x, V.z); }
inline VectorD3 Swizz_XW(VectorD4 V){ return MkVectorD3(0, V.x, V.w); }
inline VectorD3 Swizz_X_(VectorD4 V){ return MkVectorD3(0, V.x, 0); }
inline VectorD3 Swizz_YX(VectorD4 V){ return MkVectorD3(0, V.y, V.x); }
inline VectorD3 Swizz_YY(VectorD4 V){ return MkVectorD3(0, V.y, V.y); }
inline VectorD3 Swizz_YZ(VectorD4 V){ return MkVectorD3(0, V.y, V.z); }
inline VectorD3 Swizz_YW(VectorD4 V){ return MkVectorD3(0, V.y, V.w); }
inline VectorD3 Swizz_Y_(VectorD4 V){ return MkVectorD3(0, V.y, 0); }
inline VectorD3 Swizz_ZX(VectorD4 V){ return MkVectorD3(0, V.z, V.x); }
inline VectorD3 Swizz_ZY(VectorD4 V){ return MkVectorD3(0, V.z, V.y); }
inline VectorD3 Swizz_ZZ(VectorD4 V){ return MkVectorD3(0, V.z, V.z); }
inline VectorD3 Swizz_ZW(VectorD4 V){ return MkVectorD3(0, V.z, V.w); }
inline VectorD3 Swizz_Z_(VectorD4 V){ return MkVectorD3(0, V.z, 0); }
inline VectorD3 Swizz_WX(VectorD4 V){ return MkVectorD3(0, V.w, V.x); }
inline VectorD3 Swizz_WY(VectorD4 V){ return MkVectorD3(0, V.w, V.y); }
inline VectorD3 Swizz_WZ(VectorD4 V){ return MkVectorD3(0, V.w, V.z); }
inline VectorD3 Swizz_WW(VectorD4 V){ return MkVectorD3(0, V.w, V.w); }
inline VectorD3 Swizz_W_(VectorD4 V){ return MkVectorD3(0, V.w, 0); }
inline VectorD3 Swizz__X(VectorD4 V){ return MkVectorD3(0, 0, V.x); }
inline VectorD3 Swizz__Y(VectorD4 V){ return MkVectorD3(0, 0, V.y); }
inline VectorD3 Swizz__Z(VectorD4 V){ return MkVectorD3(0, 0, V.z); }
inline VectorD3 Swizz__W(VectorD4 V){ return MkVectorD3(0, 0, V.w); }
inline VectorD4 SwizzXXXX(VectorD4 V){ return MkVectorD4(V.x, V.x, V.x, V.x); }
inline VectorD4 SwizzXXXY(VectorD4 V){ return MkVectorD4(V.x, V.x, V.x, V.y); }
inline VectorD4 SwizzXXXZ(VectorD4 V){ return MkVectorD4(V.x, V.x, V.x, V.z); }
inline VectorD4 SwizzXXXW(VectorD4 V){ return MkVectorD4(V.x, V.x, V.x, V.w); }
inline VectorD4 SwizzXXX_(VectorD4 V){ return MkVectorD4(V.x, V.x, V.x, 0); }
inline VectorD4 SwizzXXYX(VectorD4 V){ return MkVectorD4(V.x, V.x, V.y, V.x); }
inline VectorD4 SwizzXXYY(VectorD4 V){ return MkVectorD4(V.x, V.x, V.y, V.y); }
inline VectorD4 SwizzXXYZ(VectorD4 V){ return MkVectorD4(V.x, V.x, V.y, V.z); }
inline VectorD4 SwizzXXYW(VectorD4 V){ return MkVectorD4(V.x, V.x, V.y, V.w); }
inline VectorD4 SwizzXXY_(VectorD4 V){ return MkVectorD4(V.x, V.x, V.y, 0); }
inline VectorD4 SwizzXXZX(VectorD4 V){ return MkVectorD4(V.x, V.x, V.z, V.x); }
inline VectorD4 SwizzXXZY(VectorD4 V){ return MkVectorD4(V.x, V.x, V.z, V.y); }
inline VectorD4 SwizzXXZZ(VectorD4 V){ return MkVectorD4(V.x, V.x, V.z, V.z); }
inline VectorD4 SwizzXXZW(VectorD4 V){ return MkVectorD4(V.x, V.x, V.z, V.w); }
inline VectorD4 SwizzXXZ_(VectorD4 V){ return MkVectorD4(V.x, V.x, V.z, 0); }
inline VectorD4 SwizzXXWX(VectorD4 V){ return MkVectorD4(V.x, V.x, V.w, V.x); }
inline VectorD4 SwizzXXWY(VectorD4 V){ return MkVectorD4(V.x, V.x, V.w, V.y); }
inline VectorD4 SwizzXXWZ(VectorD4 V){ return MkVectorD4(V.x, V.x, V.w, V.z); }
inline VectorD4 SwizzXXWW(VectorD4 V){ return MkVectorD4(V.x, V.x, V.w, V.w); }
inline VectorD4 SwizzXXW_(VectorD4 V){ return MkVectorD4(V.x, V.x, V.w, 0); }
inline VectorD4 SwizzXX_X(VectorD4 V){ return MkVectorD4(V.x, V.x, 0, V.x); }
inline VectorD4 SwizzXX_Y(VectorD4 V){ return MkVectorD4(V.x, V.x, 0, V.y); }
inline VectorD4 SwizzXX_Z(VectorD4 V){ return MkVectorD4(V.x, V.x, 0, V.z); }
inline VectorD4 SwizzXX_W(VectorD4 V){ return MkVectorD4(V.x, V.x, 0, V.w); }
inline VectorD4 SwizzXX__(VectorD4 V){ return MkVectorD4(V.x, V.x, 0, 0); }
inline VectorD4 SwizzXYXX(VectorD4 V){ return MkVectorD4(V.x, V.y, V.x, V.x); }
inline VectorD4 SwizzXYXY(VectorD4 V){ return MkVectorD4(V.x, V.y, V.x, V.y); }
inline VectorD4 SwizzXYXZ(VectorD4 V){ return MkVectorD4(V.x, V.y, V.x, V.z); }
inline VectorD4 SwizzXYXW(VectorD4 V){ return MkVectorD4(V.x, V.y, V.x, V.w); }
inline VectorD4 SwizzXYX_(VectorD4 V){ return MkVectorD4(V.x, V.y, V.x, 0); }
inline VectorD4 SwizzXYYX(VectorD4 V){ return MkVectorD4(V.x, V.y, V.y, V.x); }
inline VectorD4 SwizzXYYY(VectorD4 V){ return MkVectorD4(V.x, V.y, V.y, V.y); }
inline VectorD4 SwizzXYYZ(VectorD4 V){ return MkVectorD4(V.x, V.y, V.y, V.z); }
inline VectorD4 SwizzXYYW(VectorD4 V){ return MkVectorD4(V.x, V.y, V.y, V.w); }
inline VectorD4 SwizzXYY_(VectorD4 V){ return MkVectorD4(V.x, V.y, V.y, 0); }
inline VectorD4 SwizzXYZX(VectorD4 V){ return MkVectorD4(V.x, V.y, V.z, V.x); }
inline VectorD4 SwizzXYZY(VectorD4 V){ return MkVectorD4(V.x, V.y, V.z, V.y); }
inline VectorD4 SwizzXYZZ(VectorD4 V){ return MkVectorD4(V.x, V.y, V.z, V.z); }
inline VectorD4 SwizzXYZW(VectorD4 V){ return MkVectorD4(V.x, V.y, V.z, V.w); }
inline VectorD4 SwizzXYZ_(VectorD4 V){ return MkVectorD4(V.x, V.y, V.z, 0); }
inline VectorD4 SwizzXYWX(VectorD4 V){ return MkVectorD4(V.x, V.y, V.w, V.x); }
inline VectorD4 SwizzXYWY(VectorD4 V){ return MkVectorD4(V.x, V.y, V.w, V.y); }
inline VectorD4 SwizzXYWZ(VectorD4 V){ return MkVectorD4(V.x, V.y, V.w, V.z); }
inline VectorD4 SwizzXYWW(VectorD4 V){ return MkVectorD4(V.x, V.y, V.w, V.w); }
inline VectorD4 SwizzXYW_(VectorD4 V){ return MkVectorD4(V.x, V.y, V.w, 0); }
inline VectorD4 SwizzXY_X(VectorD4 V){ return MkVectorD4(V.x, V.y, 0, V.x); }
inline VectorD4 SwizzXY_Y(VectorD4 V){ return MkVectorD4(V.x, V.y, 0, V.y); }
inline VectorD4 SwizzXY_Z(VectorD4 V){ return MkVectorD4(V.x, V.y, 0, V.z); }
inline VectorD4 SwizzXY_W(VectorD4 V){ return MkVectorD4(V.x, V.y, 0, V.w); }
inline VectorD4 SwizzXY__(VectorD4 V){ return MkVectorD4(V.x, V.y, 0, 0); }
inline VectorD4 SwizzXZXX(VectorD4 V){ return MkVectorD4(V.x, V.z, V.x, V.x); }
inline VectorD4 SwizzXZXY(VectorD4 V){ return MkVectorD4(V.x, V.z, V.x, V.y); }
inline VectorD4 SwizzXZXZ(VectorD4 V){ return MkVectorD4(V.x, V.z, V.x, V.z); }
inline VectorD4 SwizzXZXW(VectorD4 V){ return MkVectorD4(V.x, V.z, V.x, V.w); }
inline VectorD4 SwizzXZX_(VectorD4 V){ return MkVectorD4(V.x, V.z, V.x, 0); }
inline VectorD4 SwizzXZYX(VectorD4 V){ return MkVectorD4(V.x, V.z, V.y, V.x); }
inline VectorD4 SwizzXZYY(VectorD4 V){ return MkVectorD4(V.x, V.z, V.y, V.y); }
inline VectorD4 SwizzXZYZ(VectorD4 V){ return MkVectorD4(V.x, V.z, V.y, V.z); }
inline VectorD4 SwizzXZYW(VectorD4 V){ return MkVectorD4(V.x, V.z, V.y, V.w); }
inline VectorD4 SwizzXZY_(VectorD4 V){ return MkVectorD4(V.x, V.z, V.y, 0); }
inline VectorD4 SwizzXZZX(VectorD4 V){ return MkVectorD4(V.x, V.z, V.z, V.x); }
inline VectorD4 SwizzXZZY(VectorD4 V){ return MkVectorD4(V.x, V.z, V.z, V.y); }
inline VectorD4 SwizzXZZZ(VectorD4 V){ return MkVectorD4(V.x, V.z, V.z, V.z); }
inline VectorD4 SwizzXZZW(VectorD4 V){ return MkVectorD4(V.x, V.z, V.z, V.w); }
inline VectorD4 SwizzXZZ_(VectorD4 V){ return MkVectorD4(V.x, V.z, V.z, 0); }
inline VectorD4 SwizzXZWX(VectorD4 V){ return MkVectorD4(V.x, V.z, V.w, V.x); }
inline VectorD4 SwizzXZWY(VectorD4 V){ return MkVectorD4(V.x, V.z, V.w, V.y); }
inline VectorD4 SwizzXZWZ(VectorD4 V){ return MkVectorD4(V.x, V.z, V.w, V.z); }
inline VectorD4 SwizzXZWW(VectorD4 V){ return MkVectorD4(V.x, V.z, V.w, V.w); }
inline VectorD4 SwizzXZW_(VectorD4 V){ return MkVectorD4(V.x, V.z, V.w, 0); }
inline VectorD4 SwizzXZ_X(VectorD4 V){ return MkVectorD4(V.x, V.z, 0, V.x); }
inline VectorD4 SwizzXZ_Y(VectorD4 V){ return MkVectorD4(V.x, V.z, 0, V.y); }
inline VectorD4 SwizzXZ_Z(VectorD4 V){ return MkVectorD4(V.x, V.z, 0, V.z); }
inline VectorD4 SwizzXZ_W(VectorD4 V){ return MkVectorD4(V.x, V.z, 0, V.w); }
inline VectorD4 SwizzXZ__(VectorD4 V){ return MkVectorD4(V.x, V.z, 0, 0); }
inline VectorD4 SwizzXWXX(VectorD4 V){ return MkVectorD4(V.x, V.w, V.x, V.x); }
inline VectorD4 SwizzXWXY(VectorD4 V){ return MkVectorD4(V.x, V.w, V.x, V.y); }
inline VectorD4 SwizzXWXZ(VectorD4 V){ return MkVectorD4(V.x, V.w, V.x, V.z); }
inline VectorD4 SwizzXWXW(VectorD4 V){ return MkVectorD4(V.x, V.w, V.x, V.w); }
inline VectorD4 SwizzXWX_(VectorD4 V){ return MkVectorD4(V.x, V.w, V.x, 0); }
inline VectorD4 SwizzXWYX(VectorD4 V){ return MkVectorD4(V.x, V.w, V.y, V.x); }
inline VectorD4 SwizzXWYY(VectorD4 V){ return MkVectorD4(V.x, V.w, V.y, V.y); }
inline VectorD4 SwizzXWYZ(VectorD4 V){ return MkVectorD4(V.x, V.w, V.y, V.z); }
inline VectorD4 SwizzXWYW(VectorD4 V){ return MkVectorD4(V.x, V.w, V.y, V.w); }
inline VectorD4 SwizzXWY_(VectorD4 V){ return MkVectorD4(V.x, V.w, V.y, 0); }
inline VectorD4 SwizzXWZX(VectorD4 V){ return MkVectorD4(V.x, V.w, V.z, V.x); }
inline VectorD4 SwizzXWZY(VectorD4 V){ return MkVectorD4(V.x, V.w, V.z, V.y); }
inline VectorD4 SwizzXWZZ(VectorD4 V){ return MkVectorD4(V.x, V.w, V.z, V.z); }
inline VectorD4 SwizzXWZW(VectorD4 V){ return MkVectorD4(V.x, V.w, V.z, V.w); }
inline VectorD4 SwizzXWZ_(VectorD4 V){ return MkVectorD4(V.x, V.w, V.z, 0); }
inline VectorD4 SwizzXWWX(VectorD4 V){ return MkVectorD4(V.x, V.w, V.w, V.x); }
inline VectorD4 SwizzXWWY(VectorD4 V){ return MkVectorD4(V.x, V.w, V.w, V.y); }
inline VectorD4 SwizzXWWZ(VectorD4 V){ return MkVectorD4(V.x, V.w, V.w, V.z); }
inline VectorD4 SwizzXWWW(VectorD4 V){ return MkVectorD4(V.x, V.w, V.w, V.w); }
inline VectorD4 SwizzXWW_(VectorD4 V){ return MkVectorD4(V.x, V.w, V.w, 0); }
inline VectorD4 SwizzXW_X(VectorD4 V){ return MkVectorD4(V.x, V.w, 0, V.x); }
inline VectorD4 SwizzXW_Y(VectorD4 V){ return MkVectorD4(V.x, V.w, 0, V.y); }
inline VectorD4 SwizzXW_Z(VectorD4 V){ return MkVectorD4(V.x, V.w, 0, V.z); }
inline VectorD4 SwizzXW_W(VectorD4 V){ return MkVectorD4(V.x, V.w, 0, V.w); }
inline VectorD4 SwizzXW__(VectorD4 V){ return MkVectorD4(V.x, V.w, 0, 0); }
inline VectorD4 SwizzX_XX(VectorD4 V){ return MkVectorD4(V.x, 0, V.x, V.x); }
inline VectorD4 SwizzX_XY(VectorD4 V){ return MkVectorD4(V.x, 0, V.x, V.y); }
inline VectorD4 SwizzX_XZ(VectorD4 V){ return MkVectorD4(V.x, 0, V.x, V.z); }
inline VectorD4 SwizzX_XW(VectorD4 V){ return MkVectorD4(V.x, 0, V.x, V.w); }
inline VectorD4 SwizzX_X_(VectorD4 V){ return MkVectorD4(V.x, 0, V.x, 0); }
inline VectorD4 SwizzX_YX(VectorD4 V){ return MkVectorD4(V.x, 0, V.y, V.x); }
inline VectorD4 SwizzX_YY(VectorD4 V){ return MkVectorD4(V.x, 0, V.y, V.y); }
inline VectorD4 SwizzX_YZ(VectorD4 V){ return MkVectorD4(V.x, 0, V.y, V.z); }
inline VectorD4 SwizzX_YW(VectorD4 V){ return MkVectorD4(V.x, 0, V.y, V.w); }
inline VectorD4 SwizzX_Y_(VectorD4 V){ return MkVectorD4(V.x, 0, V.y, 0); }
inline VectorD4 SwizzX_ZX(VectorD4 V){ return MkVectorD4(V.x, 0, V.z, V.x); }
inline VectorD4 SwizzX_ZY(VectorD4 V){ return MkVectorD4(V.x, 0, V.z, V.y); }
inline VectorD4 SwizzX_ZZ(VectorD4 V){ return MkVectorD4(V.x, 0, V.z, V.z); }
inline VectorD4 SwizzX_ZW(VectorD4 V){ return MkVectorD4(V.x, 0, V.z, V.w); }
inline VectorD4 SwizzX_Z_(VectorD4 V){ return MkVectorD4(V.x, 0, V.z, 0); }
inline VectorD4 SwizzX_WX(VectorD4 V){ return MkVectorD4(V.x, 0, V.w, V.x); }
inline VectorD4 SwizzX_WY(VectorD4 V){ return MkVectorD4(V.x, 0, V.w, V.y); }
inline VectorD4 SwizzX_WZ(VectorD4 V){ return MkVectorD4(V.x, 0, V.w, V.z); }
inline VectorD4 SwizzX_WW(VectorD4 V){ return MkVectorD4(V.x, 0, V.w, V.w); }
inline VectorD4 SwizzX_W_(VectorD4 V){ return MkVectorD4(V.x, 0, V.w, 0); }
inline VectorD4 SwizzX__X(VectorD4 V){ return MkVectorD4(V.x, 0, 0, V.x); }
inline VectorD4 SwizzX__Y(VectorD4 V){ return MkVectorD4(V.x, 0, 0, V.y); }
inline VectorD4 SwizzX__Z(VectorD4 V){ return MkVectorD4(V.x, 0, 0, V.z); }
inline VectorD4 SwizzX__W(VectorD4 V){ return MkVectorD4(V.x, 0, 0, V.w); }
inline VectorD4 SwizzX___(VectorD4 V){ return MkVectorD4(V.x, 0, 0, 0); }
inline VectorD4 SwizzYXXX(VectorD4 V){ return MkVectorD4(V.y, V.x, V.x, V.x); }
inline VectorD4 SwizzYXXY(VectorD4 V){ return MkVectorD4(V.y, V.x, V.x, V.y); }
inline VectorD4 SwizzYXXZ(VectorD4 V){ return MkVectorD4(V.y, V.x, V.x, V.z); }
inline VectorD4 SwizzYXXW(VectorD4 V){ return MkVectorD4(V.y, V.x, V.x, V.w); }
inline VectorD4 SwizzYXX_(VectorD4 V){ return MkVectorD4(V.y, V.x, V.x, 0); }
inline VectorD4 SwizzYXYX(VectorD4 V){ return MkVectorD4(V.y, V.x, V.y, V.x); }
inline VectorD4 SwizzYXYY(VectorD4 V){ return MkVectorD4(V.y, V.x, V.y, V.y); }
inline VectorD4 SwizzYXYZ(VectorD4 V){ return MkVectorD4(V.y, V.x, V.y, V.z); }
inline VectorD4 SwizzYXYW(VectorD4 V){ return MkVectorD4(V.y, V.x, V.y, V.w); }
inline VectorD4 SwizzYXY_(VectorD4 V){ return MkVectorD4(V.y, V.x, V.y, 0); }
inline VectorD4 SwizzYXZX(VectorD4 V){ return MkVectorD4(V.y, V.x, V.z, V.x); }
inline VectorD4 SwizzYXZY(VectorD4 V){ return MkVectorD4(V.y, V.x, V.z, V.y); }
inline VectorD4 SwizzYXZZ(VectorD4 V){ return MkVectorD4(V.y, V.x, V.z, V.z); }
inline VectorD4 SwizzYXZW(VectorD4 V){ return MkVectorD4(V.y, V.x, V.z, V.w); }
inline VectorD4 SwizzYXZ_(VectorD4 V){ return MkVectorD4(V.y, V.x, V.z, 0); }
inline VectorD4 SwizzYXWX(VectorD4 V){ return MkVectorD4(V.y, V.x, V.w, V.x); }
inline VectorD4 SwizzYXWY(VectorD4 V){ return MkVectorD4(V.y, V.x, V.w, V.y); }
inline VectorD4 SwizzYXWZ(VectorD4 V){ return MkVectorD4(V.y, V.x, V.w, V.z); }
inline VectorD4 SwizzYXWW(VectorD4 V){ return MkVectorD4(V.y, V.x, V.w, V.w); }
inline VectorD4 SwizzYXW_(VectorD4 V){ return MkVectorD4(V.y, V.x, V.w, 0); }
inline VectorD4 SwizzYX_X(VectorD4 V){ return MkVectorD4(V.y, V.x, 0, V.x); }
inline VectorD4 SwizzYX_Y(VectorD4 V){ return MkVectorD4(V.y, V.x, 0, V.y); }
inline VectorD4 SwizzYX_Z(VectorD4 V){ return MkVectorD4(V.y, V.x, 0, V.z); }
inline VectorD4 SwizzYX_W(VectorD4 V){ return MkVectorD4(V.y, V.x, 0, V.w); }
inline VectorD4 SwizzYX__(VectorD4 V){ return MkVectorD4(V.y, V.x, 0, 0); }
inline VectorD4 SwizzYYXX(VectorD4 V){ return MkVectorD4(V.y, V.y, V.x, V.x); }
inline VectorD4 SwizzYYXY(VectorD4 V){ return MkVectorD4(V.y, V.y, V.x, V.y); }
inline VectorD4 SwizzYYXZ(VectorD4 V){ return MkVectorD4(V.y, V.y, V.x, V.z); }
inline VectorD4 SwizzYYXW(VectorD4 V){ return MkVectorD4(V.y, V.y, V.x, V.w); }
inline VectorD4 SwizzYYX_(VectorD4 V){ return MkVectorD4(V.y, V.y, V.x, 0); }
inline VectorD4 SwizzYYYX(VectorD4 V){ return MkVectorD4(V.y, V.y, V.y, V.x); }
inline VectorD4 SwizzYYYY(VectorD4 V){ return MkVectorD4(V.y, V.y, V.y, V.y); }
inline VectorD4 SwizzYYYZ(VectorD4 V){ return MkVectorD4(V.y, V.y, V.y, V.z); }
inline VectorD4 SwizzYYYW(VectorD4 V){ return MkVectorD4(V.y, V.y, V.y, V.w); }
inline VectorD4 SwizzYYY_(VectorD4 V){ return MkVectorD4(V.y, V.y, V.y, 0); }
inline VectorD4 SwizzYYZX(VectorD4 V){ return MkVectorD4(V.y, V.y, V.z, V.x); }
inline VectorD4 SwizzYYZY(VectorD4 V){ return MkVectorD4(V.y, V.y, V.z, V.y); }
inline VectorD4 SwizzYYZZ(VectorD4 V){ return MkVectorD4(V.y, V.y, V.z, V.z); }
inline VectorD4 SwizzYYZW(VectorD4 V){ return MkVectorD4(V.y, V.y, V.z, V.w); }
inline VectorD4 SwizzYYZ_(VectorD4 V){ return MkVectorD4(V.y, V.y, V.z, 0); }
inline VectorD4 SwizzYYWX(VectorD4 V){ return MkVectorD4(V.y, V.y, V.w, V.x); }
inline VectorD4 SwizzYYWY(VectorD4 V){ return MkVectorD4(V.y, V.y, V.w, V.y); }
inline VectorD4 SwizzYYWZ(VectorD4 V){ return MkVectorD4(V.y, V.y, V.w, V.z); }
inline VectorD4 SwizzYYWW(VectorD4 V){ return MkVectorD4(V.y, V.y, V.w, V.w); }
inline VectorD4 SwizzYYW_(VectorD4 V){ return MkVectorD4(V.y, V.y, V.w, 0); }
inline VectorD4 SwizzYY_X(VectorD4 V){ return MkVectorD4(V.y, V.y, 0, V.x); }
inline VectorD4 SwizzYY_Y(VectorD4 V){ return MkVectorD4(V.y, V.y, 0, V.y); }
inline VectorD4 SwizzYY_Z(VectorD4 V){ return MkVectorD4(V.y, V.y, 0, V.z); }
inline VectorD4 SwizzYY_W(VectorD4 V){ return MkVectorD4(V.y, V.y, 0, V.w); }
inline VectorD4 SwizzYY__(VectorD4 V){ return MkVectorD4(V.y, V.y, 0, 0); }
inline VectorD4 SwizzYZXX(VectorD4 V){ return MkVectorD4(V.y, V.z, V.x, V.x); }
inline VectorD4 SwizzYZXY(VectorD4 V){ return MkVectorD4(V.y, V.z, V.x, V.y); }
inline VectorD4 SwizzYZXZ(VectorD4 V){ return MkVectorD4(V.y, V.z, V.x, V.z); }
inline VectorD4 SwizzYZXW(VectorD4 V){ return MkVectorD4(V.y, V.z, V.x, V.w); }
inline VectorD4 SwizzYZX_(VectorD4 V){ return MkVectorD4(V.y, V.z, V.x, 0); }
inline VectorD4 SwizzYZYX(VectorD4 V){ return MkVectorD4(V.y, V.z, V.y, V.x); }
inline VectorD4 SwizzYZYY(VectorD4 V){ return MkVectorD4(V.y, V.z, V.y, V.y); }
inline VectorD4 SwizzYZYZ(VectorD4 V){ return MkVectorD4(V.y, V.z, V.y, V.z); }
inline VectorD4 SwizzYZYW(VectorD4 V){ return MkVectorD4(V.y, V.z, V.y, V.w); }
inline VectorD4 SwizzYZY_(VectorD4 V){ return MkVectorD4(V.y, V.z, V.y, 0); }
inline VectorD4 SwizzYZZX(VectorD4 V){ return MkVectorD4(V.y, V.z, V.z, V.x); }
inline VectorD4 SwizzYZZY(VectorD4 V){ return MkVectorD4(V.y, V.z, V.z, V.y); }
inline VectorD4 SwizzYZZZ(VectorD4 V){ return MkVectorD4(V.y, V.z, V.z, V.z); }
inline VectorD4 SwizzYZZW(VectorD4 V){ return MkVectorD4(V.y, V.z, V.z, V.w); }
inline VectorD4 SwizzYZZ_(VectorD4 V){ return MkVectorD4(V.y, V.z, V.z, 0); }
inline VectorD4 SwizzYZWX(VectorD4 V){ return MkVectorD4(V.y, V.z, V.w, V.x); }
inline VectorD4 SwizzYZWY(VectorD4 V){ return MkVectorD4(V.y, V.z, V.w, V.y); }
inline VectorD4 SwizzYZWZ(VectorD4 V){ return MkVectorD4(V.y, V.z, V.w, V.z); }
inline VectorD4 SwizzYZWW(VectorD4 V){ return MkVectorD4(V.y, V.z, V.w, V.w); }
inline VectorD4 SwizzYZW_(VectorD4 V){ return MkVectorD4(V.y, V.z, V.w, 0); }
inline VectorD4 SwizzYZ_X(VectorD4 V){ return MkVectorD4(V.y, V.z, 0, V.x); }
inline VectorD4 SwizzYZ_Y(VectorD4 V){ return MkVectorD4(V.y, V.z, 0, V.y); }
inline VectorD4 SwizzYZ_Z(VectorD4 V){ return MkVectorD4(V.y, V.z, 0, V.z); }
inline VectorD4 SwizzYZ_W(VectorD4 V){ return MkVectorD4(V.y, V.z, 0, V.w); }
inline VectorD4 SwizzYZ__(VectorD4 V){ return MkVectorD4(V.y, V.z, 0, 0); }
inline VectorD4 SwizzYWXX(VectorD4 V){ return MkVectorD4(V.y, V.w, V.x, V.x); }
inline VectorD4 SwizzYWXY(VectorD4 V){ return MkVectorD4(V.y, V.w, V.x, V.y); }
inline VectorD4 SwizzYWXZ(VectorD4 V){ return MkVectorD4(V.y, V.w, V.x, V.z); }
inline VectorD4 SwizzYWXW(VectorD4 V){ return MkVectorD4(V.y, V.w, V.x, V.w); }
inline VectorD4 SwizzYWX_(VectorD4 V){ return MkVectorD4(V.y, V.w, V.x, 0); }
inline VectorD4 SwizzYWYX(VectorD4 V){ return MkVectorD4(V.y, V.w, V.y, V.x); }
inline VectorD4 SwizzYWYY(VectorD4 V){ return MkVectorD4(V.y, V.w, V.y, V.y); }
inline VectorD4 SwizzYWYZ(VectorD4 V){ return MkVectorD4(V.y, V.w, V.y, V.z); }
inline VectorD4 SwizzYWYW(VectorD4 V){ return MkVectorD4(V.y, V.w, V.y, V.w); }
inline VectorD4 SwizzYWY_(VectorD4 V){ return MkVectorD4(V.y, V.w, V.y, 0); }
inline VectorD4 SwizzYWZX(VectorD4 V){ return MkVectorD4(V.y, V.w, V.z, V.x); }
inline VectorD4 SwizzYWZY(VectorD4 V){ return MkVectorD4(V.y, V.w, V.z, V.y); }
inline VectorD4 SwizzYWZZ(VectorD4 V){ return MkVectorD4(V.y, V.w, V.z, V.z); }
inline VectorD4 SwizzYWZW(VectorD4 V){ return MkVectorD4(V.y, V.w, V.z, V.w); }
inline VectorD4 SwizzYWZ_(VectorD4 V){ return MkVectorD4(V.y, V.w, V.z, 0); }
inline VectorD4 SwizzYWWX(VectorD4 V){ return MkVectorD4(V.y, V.w, V.w, V.x); }
inline VectorD4 SwizzYWWY(VectorD4 V){ return MkVectorD4(V.y, V.w, V.w, V.y); }
inline VectorD4 SwizzYWWZ(VectorD4 V){ return MkVectorD4(V.y, V.w, V.w, V.z); }
inline VectorD4 SwizzYWWW(VectorD4 V){ return MkVectorD4(V.y, V.w, V.w, V.w); }
inline VectorD4 SwizzYWW_(VectorD4 V){ return MkVectorD4(V.y, V.w, V.w, 0); }
inline VectorD4 SwizzYW_X(VectorD4 V){ return MkVectorD4(V.y, V.w, 0, V.x); }
inline VectorD4 SwizzYW_Y(VectorD4 V){ return MkVectorD4(V.y, V.w, 0, V.y); }
inline VectorD4 SwizzYW_Z(VectorD4 V){ return MkVectorD4(V.y, V.w, 0, V.z); }
inline VectorD4 SwizzYW_W(VectorD4 V){ return MkVectorD4(V.y, V.w, 0, V.w); }
inline VectorD4 SwizzYW__(VectorD4 V){ return MkVectorD4(V.y, V.w, 0, 0); }
inline VectorD4 SwizzY_XX(VectorD4 V){ return MkVectorD4(V.y, 0, V.x, V.x); }
inline VectorD4 SwizzY_XY(VectorD4 V){ return MkVectorD4(V.y, 0, V.x, V.y); }
inline VectorD4 SwizzY_XZ(VectorD4 V){ return MkVectorD4(V.y, 0, V.x, V.z); }
inline VectorD4 SwizzY_XW(VectorD4 V){ return MkVectorD4(V.y, 0, V.x, V.w); }
inline VectorD4 SwizzY_X_(VectorD4 V){ return MkVectorD4(V.y, 0, V.x, 0); }
inline VectorD4 SwizzY_YX(VectorD4 V){ return MkVectorD4(V.y, 0, V.y, V.x); }
inline VectorD4 SwizzY_YY(VectorD4 V){ return MkVectorD4(V.y, 0, V.y, V.y); }
inline VectorD4 SwizzY_YZ(VectorD4 V){ return MkVectorD4(V.y, 0, V.y, V.z); }
inline VectorD4 SwizzY_YW(VectorD4 V){ return MkVectorD4(V.y, 0, V.y, V.w); }
inline VectorD4 SwizzY_Y_(VectorD4 V){ return MkVectorD4(V.y, 0, V.y, 0); }
inline VectorD4 SwizzY_ZX(VectorD4 V){ return MkVectorD4(V.y, 0, V.z, V.x); }
inline VectorD4 SwizzY_ZY(VectorD4 V){ return MkVectorD4(V.y, 0, V.z, V.y); }
inline VectorD4 SwizzY_ZZ(VectorD4 V){ return MkVectorD4(V.y, 0, V.z, V.z); }
inline VectorD4 SwizzY_ZW(VectorD4 V){ return MkVectorD4(V.y, 0, V.z, V.w); }
inline VectorD4 SwizzY_Z_(VectorD4 V){ return MkVectorD4(V.y, 0, V.z, 0); }
inline VectorD4 SwizzY_WX(VectorD4 V){ return MkVectorD4(V.y, 0, V.w, V.x); }
inline VectorD4 SwizzY_WY(VectorD4 V){ return MkVectorD4(V.y, 0, V.w, V.y); }
inline VectorD4 SwizzY_WZ(VectorD4 V){ return MkVectorD4(V.y, 0, V.w, V.z); }
inline VectorD4 SwizzY_WW(VectorD4 V){ return MkVectorD4(V.y, 0, V.w, V.w); }
inline VectorD4 SwizzY_W_(VectorD4 V){ return MkVectorD4(V.y, 0, V.w, 0); }
inline VectorD4 SwizzY__X(VectorD4 V){ return MkVectorD4(V.y, 0, 0, V.x); }
inline VectorD4 SwizzY__Y(VectorD4 V){ return MkVectorD4(V.y, 0, 0, V.y); }
inline VectorD4 SwizzY__Z(VectorD4 V){ return MkVectorD4(V.y, 0, 0, V.z); }
inline VectorD4 SwizzY__W(VectorD4 V){ return MkVectorD4(V.y, 0, 0, V.w); }
inline VectorD4 SwizzY___(VectorD4 V){ return MkVectorD4(V.y, 0, 0, 0); }
inline VectorD4 SwizzZXXX(VectorD4 V){ return MkVectorD4(V.z, V.x, V.x, V.x); }
inline VectorD4 SwizzZXXY(VectorD4 V){ return MkVectorD4(V.z, V.x, V.x, V.y); }
inline VectorD4 SwizzZXXZ(VectorD4 V){ return MkVectorD4(V.z, V.x, V.x, V.z); }
inline VectorD4 SwizzZXXW(VectorD4 V){ return MkVectorD4(V.z, V.x, V.x, V.w); }
inline VectorD4 SwizzZXX_(VectorD4 V){ return MkVectorD4(V.z, V.x, V.x, 0); }
inline VectorD4 SwizzZXYX(VectorD4 V){ return MkVectorD4(V.z, V.x, V.y, V.x); }
inline VectorD4 SwizzZXYY(VectorD4 V){ return MkVectorD4(V.z, V.x, V.y, V.y); }
inline VectorD4 SwizzZXYZ(VectorD4 V){ return MkVectorD4(V.z, V.x, V.y, V.z); }
inline VectorD4 SwizzZXYW(VectorD4 V){ return MkVectorD4(V.z, V.x, V.y, V.w); }
inline VectorD4 SwizzZXY_(VectorD4 V){ return MkVectorD4(V.z, V.x, V.y, 0); }
inline VectorD4 SwizzZXZX(VectorD4 V){ return MkVectorD4(V.z, V.x, V.z, V.x); }
inline VectorD4 SwizzZXZY(VectorD4 V){ return MkVectorD4(V.z, V.x, V.z, V.y); }
inline VectorD4 SwizzZXZZ(VectorD4 V){ return MkVectorD4(V.z, V.x, V.z, V.z); }
inline VectorD4 SwizzZXZW(VectorD4 V){ return MkVectorD4(V.z, V.x, V.z, V.w); }
inline VectorD4 SwizzZXZ_(VectorD4 V){ return MkVectorD4(V.z, V.x, V.z, 0); }
inline VectorD4 SwizzZXWX(VectorD4 V){ return MkVectorD4(V.z, V.x, V.w, V.x); }
inline VectorD4 SwizzZXWY(VectorD4 V){ return MkVectorD4(V.z, V.x, V.w, V.y); }
inline VectorD4 SwizzZXWZ(VectorD4 V){ return MkVectorD4(V.z, V.x, V.w, V.z); }
inline VectorD4 SwizzZXWW(VectorD4 V){ return MkVectorD4(V.z, V.x, V.w, V.w); }
inline VectorD4 SwizzZXW_(VectorD4 V){ return MkVectorD4(V.z, V.x, V.w, 0); }
inline VectorD4 SwizzZX_X(VectorD4 V){ return MkVectorD4(V.z, V.x, 0, V.x); }
inline VectorD4 SwizzZX_Y(VectorD4 V){ return MkVectorD4(V.z, V.x, 0, V.y); }
inline VectorD4 SwizzZX_Z(VectorD4 V){ return MkVectorD4(V.z, V.x, 0, V.z); }
inline VectorD4 SwizzZX_W(VectorD4 V){ return MkVectorD4(V.z, V.x, 0, V.w); }
inline VectorD4 SwizzZX__(VectorD4 V){ return MkVectorD4(V.z, V.x, 0, 0); }
inline VectorD4 SwizzZYXX(VectorD4 V){ return MkVectorD4(V.z, V.y, V.x, V.x); }
inline VectorD4 SwizzZYXY(VectorD4 V){ return MkVectorD4(V.z, V.y, V.x, V.y); }
inline VectorD4 SwizzZYXZ(VectorD4 V){ return MkVectorD4(V.z, V.y, V.x, V.z); }
inline VectorD4 SwizzZYXW(VectorD4 V){ return MkVectorD4(V.z, V.y, V.x, V.w); }
inline VectorD4 SwizzZYX_(VectorD4 V){ return MkVectorD4(V.z, V.y, V.x, 0); }
inline VectorD4 SwizzZYYX(VectorD4 V){ return MkVectorD4(V.z, V.y, V.y, V.x); }
inline VectorD4 SwizzZYYY(VectorD4 V){ return MkVectorD4(V.z, V.y, V.y, V.y); }
inline VectorD4 SwizzZYYZ(VectorD4 V){ return MkVectorD4(V.z, V.y, V.y, V.z); }
inline VectorD4 SwizzZYYW(VectorD4 V){ return MkVectorD4(V.z, V.y, V.y, V.w); }
inline VectorD4 SwizzZYY_(VectorD4 V){ return MkVectorD4(V.z, V.y, V.y, 0); }
inline VectorD4 SwizzZYZX(VectorD4 V){ return MkVectorD4(V.z, V.y, V.z, V.x); }
inline VectorD4 SwizzZYZY(VectorD4 V){ return MkVectorD4(V.z, V.y, V.z, V.y); }
inline VectorD4 SwizzZYZZ(VectorD4 V){ return MkVectorD4(V.z, V.y, V.z, V.z); }
inline VectorD4 SwizzZYZW(VectorD4 V){ return MkVectorD4(V.z, V.y, V.z, V.w); }
inline VectorD4 SwizzZYZ_(VectorD4 V){ return MkVectorD4(V.z, V.y, V.z, 0); }
inline VectorD4 SwizzZYWX(VectorD4 V){ return MkVectorD4(V.z, V.y, V.w, V.x); }
inline VectorD4 SwizzZYWY(VectorD4 V){ return MkVectorD4(V.z, V.y, V.w, V.y); }
inline VectorD4 SwizzZYWZ(VectorD4 V){ return MkVectorD4(V.z, V.y, V.w, V.z); }
inline VectorD4 SwizzZYWW(VectorD4 V){ return MkVectorD4(V.z, V.y, V.w, V.w); }
inline VectorD4 SwizzZYW_(VectorD4 V){ return MkVectorD4(V.z, V.y, V.w, 0); }
inline VectorD4 SwizzZY_X(VectorD4 V){ return MkVectorD4(V.z, V.y, 0, V.x); }
inline VectorD4 SwizzZY_Y(VectorD4 V){ return MkVectorD4(V.z, V.y, 0, V.y); }
inline VectorD4 SwizzZY_Z(VectorD4 V){ return MkVectorD4(V.z, V.y, 0, V.z); }
inline VectorD4 SwizzZY_W(VectorD4 V){ return MkVectorD4(V.z, V.y, 0, V.w); }
inline VectorD4 SwizzZY__(VectorD4 V){ return MkVectorD4(V.z, V.y, 0, 0); }
inline VectorD4 SwizzZZXX(VectorD4 V){ return MkVectorD4(V.z, V.z, V.x, V.x); }
inline VectorD4 SwizzZZXY(VectorD4 V){ return MkVectorD4(V.z, V.z, V.x, V.y); }
inline VectorD4 SwizzZZXZ(VectorD4 V){ return MkVectorD4(V.z, V.z, V.x, V.z); }
inline VectorD4 SwizzZZXW(VectorD4 V){ return MkVectorD4(V.z, V.z, V.x, V.w); }
inline VectorD4 SwizzZZX_(VectorD4 V){ return MkVectorD4(V.z, V.z, V.x, 0); }
inline VectorD4 SwizzZZYX(VectorD4 V){ return MkVectorD4(V.z, V.z, V.y, V.x); }
inline VectorD4 SwizzZZYY(VectorD4 V){ return MkVectorD4(V.z, V.z, V.y, V.y); }
inline VectorD4 SwizzZZYZ(VectorD4 V){ return MkVectorD4(V.z, V.z, V.y, V.z); }
inline VectorD4 SwizzZZYW(VectorD4 V){ return MkVectorD4(V.z, V.z, V.y, V.w); }
inline VectorD4 SwizzZZY_(VectorD4 V){ return MkVectorD4(V.z, V.z, V.y, 0); }
inline VectorD4 SwizzZZZX(VectorD4 V){ return MkVectorD4(V.z, V.z, V.z, V.x); }
inline VectorD4 SwizzZZZY(VectorD4 V){ return MkVectorD4(V.z, V.z, V.z, V.y); }
inline VectorD4 SwizzZZZZ(VectorD4 V){ return MkVectorD4(V.z, V.z, V.z, V.z); }
inline VectorD4 SwizzZZZW(VectorD4 V){ return MkVectorD4(V.z, V.z, V.z, V.w); }
inline VectorD4 SwizzZZZ_(VectorD4 V){ return MkVectorD4(V.z, V.z, V.z, 0); }
inline VectorD4 SwizzZZWX(VectorD4 V){ return MkVectorD4(V.z, V.z, V.w, V.x); }
inline VectorD4 SwizzZZWY(VectorD4 V){ return MkVectorD4(V.z, V.z, V.w, V.y); }
inline VectorD4 SwizzZZWZ(VectorD4 V){ return MkVectorD4(V.z, V.z, V.w, V.z); }
inline VectorD4 SwizzZZWW(VectorD4 V){ return MkVectorD4(V.z, V.z, V.w, V.w); }
inline VectorD4 SwizzZZW_(VectorD4 V){ return MkVectorD4(V.z, V.z, V.w, 0); }
inline VectorD4 SwizzZZ_X(VectorD4 V){ return MkVectorD4(V.z, V.z, 0, V.x); }
inline VectorD4 SwizzZZ_Y(VectorD4 V){ return MkVectorD4(V.z, V.z, 0, V.y); }
inline VectorD4 SwizzZZ_Z(VectorD4 V){ return MkVectorD4(V.z, V.z, 0, V.z); }
inline VectorD4 SwizzZZ_W(VectorD4 V){ return MkVectorD4(V.z, V.z, 0, V.w); }
inline VectorD4 SwizzZZ__(VectorD4 V){ return MkVectorD4(V.z, V.z, 0, 0); }
inline VectorD4 SwizzZWXX(VectorD4 V){ return MkVectorD4(V.z, V.w, V.x, V.x); }
inline VectorD4 SwizzZWXY(VectorD4 V){ return MkVectorD4(V.z, V.w, V.x, V.y); }
inline VectorD4 SwizzZWXZ(VectorD4 V){ return MkVectorD4(V.z, V.w, V.x, V.z); }
inline VectorD4 SwizzZWXW(VectorD4 V){ return MkVectorD4(V.z, V.w, V.x, V.w); }
inline VectorD4 SwizzZWX_(VectorD4 V){ return MkVectorD4(V.z, V.w, V.x, 0); }
inline VectorD4 SwizzZWYX(VectorD4 V){ return MkVectorD4(V.z, V.w, V.y, V.x); }
inline VectorD4 SwizzZWYY(VectorD4 V){ return MkVectorD4(V.z, V.w, V.y, V.y); }
inline VectorD4 SwizzZWYZ(VectorD4 V){ return MkVectorD4(V.z, V.w, V.y, V.z); }
inline VectorD4 SwizzZWYW(VectorD4 V){ return MkVectorD4(V.z, V.w, V.y, V.w); }
inline VectorD4 SwizzZWY_(VectorD4 V){ return MkVectorD4(V.z, V.w, V.y, 0); }
inline VectorD4 SwizzZWZX(VectorD4 V){ return MkVectorD4(V.z, V.w, V.z, V.x); }
inline VectorD4 SwizzZWZY(VectorD4 V){ return MkVectorD4(V.z, V.w, V.z, V.y); }
inline VectorD4 SwizzZWZZ(VectorD4 V){ return MkVectorD4(V.z, V.w, V.z, V.z); }
inline VectorD4 SwizzZWZW(VectorD4 V){ return MkVectorD4(V.z, V.w, V.z, V.w); }
inline VectorD4 SwizzZWZ_(VectorD4 V){ return MkVectorD4(V.z, V.w, V.z, 0); }
inline VectorD4 SwizzZWWX(VectorD4 V){ return MkVectorD4(V.z, V.w, V.w, V.x); }
inline VectorD4 SwizzZWWY(VectorD4 V){ return MkVectorD4(V.z, V.w, V.w, V.y); }
inline VectorD4 SwizzZWWZ(VectorD4 V){ return MkVectorD4(V.z, V.w, V.w, V.z); }
inline VectorD4 SwizzZWWW(VectorD4 V){ return MkVectorD4(V.z, V.w, V.w, V.w); }
inline VectorD4 SwizzZWW_(VectorD4 V){ return MkVectorD4(V.z, V.w, V.w, 0); }
inline VectorD4 SwizzZW_X(VectorD4 V){ return MkVectorD4(V.z, V.w, 0, V.x); }
inline VectorD4 SwizzZW_Y(VectorD4 V){ return MkVectorD4(V.z, V.w, 0, V.y); }
inline VectorD4 SwizzZW_Z(VectorD4 V){ return MkVectorD4(V.z, V.w, 0, V.z); }
inline VectorD4 SwizzZW_W(VectorD4 V){ return MkVectorD4(V.z, V.w, 0, V.w); }
inline VectorD4 SwizzZW__(VectorD4 V){ return MkVectorD4(V.z, V.w, 0, 0); }
inline VectorD4 SwizzZ_XX(VectorD4 V){ return MkVectorD4(V.z, 0, V.x, V.x); }
inline VectorD4 SwizzZ_XY(VectorD4 V){ return MkVectorD4(V.z, 0, V.x, V.y); }
inline VectorD4 SwizzZ_XZ(VectorD4 V){ return MkVectorD4(V.z, 0, V.x, V.z); }
inline VectorD4 SwizzZ_XW(VectorD4 V){ return MkVectorD4(V.z, 0, V.x, V.w); }
inline VectorD4 SwizzZ_X_(VectorD4 V){ return MkVectorD4(V.z, 0, V.x, 0); }
inline VectorD4 SwizzZ_YX(VectorD4 V){ return MkVectorD4(V.z, 0, V.y, V.x); }
inline VectorD4 SwizzZ_YY(VectorD4 V){ return MkVectorD4(V.z, 0, V.y, V.y); }
inline VectorD4 SwizzZ_YZ(VectorD4 V){ return MkVectorD4(V.z, 0, V.y, V.z); }
inline VectorD4 SwizzZ_YW(VectorD4 V){ return MkVectorD4(V.z, 0, V.y, V.w); }
inline VectorD4 SwizzZ_Y_(VectorD4 V){ return MkVectorD4(V.z, 0, V.y, 0); }
inline VectorD4 SwizzZ_ZX(VectorD4 V){ return MkVectorD4(V.z, 0, V.z, V.x); }
inline VectorD4 SwizzZ_ZY(VectorD4 V){ return MkVectorD4(V.z, 0, V.z, V.y); }
inline VectorD4 SwizzZ_ZZ(VectorD4 V){ return MkVectorD4(V.z, 0, V.z, V.z); }
inline VectorD4 SwizzZ_ZW(VectorD4 V){ return MkVectorD4(V.z, 0, V.z, V.w); }
inline VectorD4 SwizzZ_Z_(VectorD4 V){ return MkVectorD4(V.z, 0, V.z, 0); }
inline VectorD4 SwizzZ_WX(VectorD4 V){ return MkVectorD4(V.z, 0, V.w, V.x); }
inline VectorD4 SwizzZ_WY(VectorD4 V){ return MkVectorD4(V.z, 0, V.w, V.y); }
inline VectorD4 SwizzZ_WZ(VectorD4 V){ return MkVectorD4(V.z, 0, V.w, V.z); }
inline VectorD4 SwizzZ_WW(VectorD4 V){ return MkVectorD4(V.z, 0, V.w, V.w); }
inline VectorD4 SwizzZ_W_(VectorD4 V){ return MkVectorD4(V.z, 0, V.w, 0); }
inline VectorD4 SwizzZ__X(VectorD4 V){ return MkVectorD4(V.z, 0, 0, V.x); }
inline VectorD4 SwizzZ__Y(VectorD4 V){ return MkVectorD4(V.z, 0, 0, V.y); }
inline VectorD4 SwizzZ__Z(VectorD4 V){ return MkVectorD4(V.z, 0, 0, V.z); }
inline VectorD4 SwizzZ__W(VectorD4 V){ return MkVectorD4(V.z, 0, 0, V.w); }
inline VectorD4 SwizzZ___(VectorD4 V){ return MkVectorD4(V.z, 0, 0, 0); }
inline VectorD4 SwizzWXXX(VectorD4 V){ return MkVectorD4(V.w, V.x, V.x, V.x); }
inline VectorD4 SwizzWXXY(VectorD4 V){ return MkVectorD4(V.w, V.x, V.x, V.y); }
inline VectorD4 SwizzWXXZ(VectorD4 V){ return MkVectorD4(V.w, V.x, V.x, V.z); }
inline VectorD4 SwizzWXXW(VectorD4 V){ return MkVectorD4(V.w, V.x, V.x, V.w); }
inline VectorD4 SwizzWXX_(VectorD4 V){ return MkVectorD4(V.w, V.x, V.x, 0); }
inline VectorD4 SwizzWXYX(VectorD4 V){ return MkVectorD4(V.w, V.x, V.y, V.x); }
inline VectorD4 SwizzWXYY(VectorD4 V){ return MkVectorD4(V.w, V.x, V.y, V.y); }
inline VectorD4 SwizzWXYZ(VectorD4 V){ return MkVectorD4(V.w, V.x, V.y, V.z); }
inline VectorD4 SwizzWXYW(VectorD4 V){ return MkVectorD4(V.w, V.x, V.y, V.w); }
inline VectorD4 SwizzWXY_(VectorD4 V){ return MkVectorD4(V.w, V.x, V.y, 0); }
inline VectorD4 SwizzWXZX(VectorD4 V){ return MkVectorD4(V.w, V.x, V.z, V.x); }
inline VectorD4 SwizzWXZY(VectorD4 V){ return MkVectorD4(V.w, V.x, V.z, V.y); }
inline VectorD4 SwizzWXZZ(VectorD4 V){ return MkVectorD4(V.w, V.x, V.z, V.z); }
inline VectorD4 SwizzWXZW(VectorD4 V){ return MkVectorD4(V.w, V.x, V.z, V.w); }
inline VectorD4 SwizzWXZ_(VectorD4 V){ return MkVectorD4(V.w, V.x, V.z, 0); }
inline VectorD4 SwizzWXWX(VectorD4 V){ return MkVectorD4(V.w, V.x, V.w, V.x); }
inline VectorD4 SwizzWXWY(VectorD4 V){ return MkVectorD4(V.w, V.x, V.w, V.y); }
inline VectorD4 SwizzWXWZ(VectorD4 V){ return MkVectorD4(V.w, V.x, V.w, V.z); }
inline VectorD4 SwizzWXWW(VectorD4 V){ return MkVectorD4(V.w, V.x, V.w, V.w); }
inline VectorD4 SwizzWXW_(VectorD4 V){ return MkVectorD4(V.w, V.x, V.w, 0); }
inline VectorD4 SwizzWX_X(VectorD4 V){ return MkVectorD4(V.w, V.x, 0, V.x); }
inline VectorD4 SwizzWX_Y(VectorD4 V){ return MkVectorD4(V.w, V.x, 0, V.y); }
inline VectorD4 SwizzWX_Z(VectorD4 V){ return MkVectorD4(V.w, V.x, 0, V.z); }
inline VectorD4 SwizzWX_W(VectorD4 V){ return MkVectorD4(V.w, V.x, 0, V.w); }
inline VectorD4 SwizzWX__(VectorD4 V){ return MkVectorD4(V.w, V.x, 0, 0); }
inline VectorD4 SwizzWYXX(VectorD4 V){ return MkVectorD4(V.w, V.y, V.x, V.x); }
inline VectorD4 SwizzWYXY(VectorD4 V){ return MkVectorD4(V.w, V.y, V.x, V.y); }
inline VectorD4 SwizzWYXZ(VectorD4 V){ return MkVectorD4(V.w, V.y, V.x, V.z); }
inline VectorD4 SwizzWYXW(VectorD4 V){ return MkVectorD4(V.w, V.y, V.x, V.w); }
inline VectorD4 SwizzWYX_(VectorD4 V){ return MkVectorD4(V.w, V.y, V.x, 0); }
inline VectorD4 SwizzWYYX(VectorD4 V){ return MkVectorD4(V.w, V.y, V.y, V.x); }
inline VectorD4 SwizzWYYY(VectorD4 V){ return MkVectorD4(V.w, V.y, V.y, V.y); }
inline VectorD4 SwizzWYYZ(VectorD4 V){ return MkVectorD4(V.w, V.y, V.y, V.z); }
inline VectorD4 SwizzWYYW(VectorD4 V){ return MkVectorD4(V.w, V.y, V.y, V.w); }
inline VectorD4 SwizzWYY_(VectorD4 V){ return MkVectorD4(V.w, V.y, V.y, 0); }
inline VectorD4 SwizzWYZX(VectorD4 V){ return MkVectorD4(V.w, V.y, V.z, V.x); }
inline VectorD4 SwizzWYZY(VectorD4 V){ return MkVectorD4(V.w, V.y, V.z, V.y); }
inline VectorD4 SwizzWYZZ(VectorD4 V){ return MkVectorD4(V.w, V.y, V.z, V.z); }
inline VectorD4 SwizzWYZW(VectorD4 V){ return MkVectorD4(V.w, V.y, V.z, V.w); }
inline VectorD4 SwizzWYZ_(VectorD4 V){ return MkVectorD4(V.w, V.y, V.z, 0); }
inline VectorD4 SwizzWYWX(VectorD4 V){ return MkVectorD4(V.w, V.y, V.w, V.x); }
inline VectorD4 SwizzWYWY(VectorD4 V){ return MkVectorD4(V.w, V.y, V.w, V.y); }
inline VectorD4 SwizzWYWZ(VectorD4 V){ return MkVectorD4(V.w, V.y, V.w, V.z); }
inline VectorD4 SwizzWYWW(VectorD4 V){ return MkVectorD4(V.w, V.y, V.w, V.w); }
inline VectorD4 SwizzWYW_(VectorD4 V){ return MkVectorD4(V.w, V.y, V.w, 0); }
inline VectorD4 SwizzWY_X(VectorD4 V){ return MkVectorD4(V.w, V.y, 0, V.x); }
inline VectorD4 SwizzWY_Y(VectorD4 V){ return MkVectorD4(V.w, V.y, 0, V.y); }
inline VectorD4 SwizzWY_Z(VectorD4 V){ return MkVectorD4(V.w, V.y, 0, V.z); }
inline VectorD4 SwizzWY_W(VectorD4 V){ return MkVectorD4(V.w, V.y, 0, V.w); }
inline VectorD4 SwizzWY__(VectorD4 V){ return MkVectorD4(V.w, V.y, 0, 0); }
inline VectorD4 SwizzWZXX(VectorD4 V){ return MkVectorD4(V.w, V.z, V.x, V.x); }
inline VectorD4 SwizzWZXY(VectorD4 V){ return MkVectorD4(V.w, V.z, V.x, V.y); }
inline VectorD4 SwizzWZXZ(VectorD4 V){ return MkVectorD4(V.w, V.z, V.x, V.z); }
inline VectorD4 SwizzWZXW(VectorD4 V){ return MkVectorD4(V.w, V.z, V.x, V.w); }
inline VectorD4 SwizzWZX_(VectorD4 V){ return MkVectorD4(V.w, V.z, V.x, 0); }
inline VectorD4 SwizzWZYX(VectorD4 V){ return MkVectorD4(V.w, V.z, V.y, V.x); }
inline VectorD4 SwizzWZYY(VectorD4 V){ return MkVectorD4(V.w, V.z, V.y, V.y); }
inline VectorD4 SwizzWZYZ(VectorD4 V){ return MkVectorD4(V.w, V.z, V.y, V.z); }
inline VectorD4 SwizzWZYW(VectorD4 V){ return MkVectorD4(V.w, V.z, V.y, V.w); }
inline VectorD4 SwizzWZY_(VectorD4 V){ return MkVectorD4(V.w, V.z, V.y, 0); }
inline VectorD4 SwizzWZZX(VectorD4 V){ return MkVectorD4(V.w, V.z, V.z, V.x); }
inline VectorD4 SwizzWZZY(VectorD4 V){ return MkVectorD4(V.w, V.z, V.z, V.y); }
inline VectorD4 SwizzWZZZ(VectorD4 V){ return MkVectorD4(V.w, V.z, V.z, V.z); }
inline VectorD4 SwizzWZZW(VectorD4 V){ return MkVectorD4(V.w, V.z, V.z, V.w); }
inline VectorD4 SwizzWZZ_(VectorD4 V){ return MkVectorD4(V.w, V.z, V.z, 0); }
inline VectorD4 SwizzWZWX(VectorD4 V){ return MkVectorD4(V.w, V.z, V.w, V.x); }
inline VectorD4 SwizzWZWY(VectorD4 V){ return MkVectorD4(V.w, V.z, V.w, V.y); }
inline VectorD4 SwizzWZWZ(VectorD4 V){ return MkVectorD4(V.w, V.z, V.w, V.z); }
inline VectorD4 SwizzWZWW(VectorD4 V){ return MkVectorD4(V.w, V.z, V.w, V.w); }
inline VectorD4 SwizzWZW_(VectorD4 V){ return MkVectorD4(V.w, V.z, V.w, 0); }
inline VectorD4 SwizzWZ_X(VectorD4 V){ return MkVectorD4(V.w, V.z, 0, V.x); }
inline VectorD4 SwizzWZ_Y(VectorD4 V){ return MkVectorD4(V.w, V.z, 0, V.y); }
inline VectorD4 SwizzWZ_Z(VectorD4 V){ return MkVectorD4(V.w, V.z, 0, V.z); }
inline VectorD4 SwizzWZ_W(VectorD4 V){ return MkVectorD4(V.w, V.z, 0, V.w); }
inline VectorD4 SwizzWZ__(VectorD4 V){ return MkVectorD4(V.w, V.z, 0, 0); }
inline VectorD4 SwizzWWXX(VectorD4 V){ return MkVectorD4(V.w, V.w, V.x, V.x); }
inline VectorD4 SwizzWWXY(VectorD4 V){ return MkVectorD4(V.w, V.w, V.x, V.y); }
inline VectorD4 SwizzWWXZ(VectorD4 V){ return MkVectorD4(V.w, V.w, V.x, V.z); }
inline VectorD4 SwizzWWXW(VectorD4 V){ return MkVectorD4(V.w, V.w, V.x, V.w); }
inline VectorD4 SwizzWWX_(VectorD4 V){ return MkVectorD4(V.w, V.w, V.x, 0); }
inline VectorD4 SwizzWWYX(VectorD4 V){ return MkVectorD4(V.w, V.w, V.y, V.x); }
inline VectorD4 SwizzWWYY(VectorD4 V){ return MkVectorD4(V.w, V.w, V.y, V.y); }
inline VectorD4 SwizzWWYZ(VectorD4 V){ return MkVectorD4(V.w, V.w, V.y, V.z); }
inline VectorD4 SwizzWWYW(VectorD4 V){ return MkVectorD4(V.w, V.w, V.y, V.w); }
inline VectorD4 SwizzWWY_(VectorD4 V){ return MkVectorD4(V.w, V.w, V.y, 0); }
inline VectorD4 SwizzWWZX(VectorD4 V){ return MkVectorD4(V.w, V.w, V.z, V.x); }
inline VectorD4 SwizzWWZY(VectorD4 V){ return MkVectorD4(V.w, V.w, V.z, V.y); }
inline VectorD4 SwizzWWZZ(VectorD4 V){ return MkVectorD4(V.w, V.w, V.z, V.z); }
inline VectorD4 SwizzWWZW(VectorD4 V){ return MkVectorD4(V.w, V.w, V.z, V.w); }
inline VectorD4 SwizzWWZ_(VectorD4 V){ return MkVectorD4(V.w, V.w, V.z, 0); }
inline VectorD4 SwizzWWWX(VectorD4 V){ return MkVectorD4(V.w, V.w, V.w, V.x); }
inline VectorD4 SwizzWWWY(VectorD4 V){ return MkVectorD4(V.w, V.w, V.w, V.y); }
inline VectorD4 SwizzWWWZ(VectorD4 V){ return MkVectorD4(V.w, V.w, V.w, V.z); }
inline VectorD4 SwizzWWWW(VectorD4 V){ return MkVectorD4(V.w, V.w, V.w, V.w); }
inline VectorD4 SwizzWWW_(VectorD4 V){ return MkVectorD4(V.w, V.w, V.w, 0); }
inline VectorD4 SwizzWW_X(VectorD4 V){ return MkVectorD4(V.w, V.w, 0, V.x); }
inline VectorD4 SwizzWW_Y(VectorD4 V){ return MkVectorD4(V.w, V.w, 0, V.y); }
inline VectorD4 SwizzWW_Z(VectorD4 V){ return MkVectorD4(V.w, V.w, 0, V.z); }
inline VectorD4 SwizzWW_W(VectorD4 V){ return MkVectorD4(V.w, V.w, 0, V.w); }
inline VectorD4 SwizzWW__(VectorD4 V){ return MkVectorD4(V.w, V.w, 0, 0); }
inline VectorD4 SwizzW_XX(VectorD4 V){ return MkVectorD4(V.w, 0, V.x, V.x); }
inline VectorD4 SwizzW_XY(VectorD4 V){ return MkVectorD4(V.w, 0, V.x, V.y); }
inline VectorD4 SwizzW_XZ(VectorD4 V){ return MkVectorD4(V.w, 0, V.x, V.z); }
inline VectorD4 SwizzW_XW(VectorD4 V){ return MkVectorD4(V.w, 0, V.x, V.w); }
inline VectorD4 SwizzW_X_(VectorD4 V){ return MkVectorD4(V.w, 0, V.x, 0); }
inline VectorD4 SwizzW_YX(VectorD4 V){ return MkVectorD4(V.w, 0, V.y, V.x); }
inline VectorD4 SwizzW_YY(VectorD4 V){ return MkVectorD4(V.w, 0, V.y, V.y); }
inline VectorD4 SwizzW_YZ(VectorD4 V){ return MkVectorD4(V.w, 0, V.y, V.z); }
inline VectorD4 SwizzW_YW(VectorD4 V){ return MkVectorD4(V.w, 0, V.y, V.w); }
inline VectorD4 SwizzW_Y_(VectorD4 V){ return MkVectorD4(V.w, 0, V.y, 0); }
inline VectorD4 SwizzW_ZX(VectorD4 V){ return MkVectorD4(V.w, 0, V.z, V.x); }
inline VectorD4 SwizzW_ZY(VectorD4 V){ return MkVectorD4(V.w, 0, V.z, V.y); }
inline VectorD4 SwizzW_ZZ(VectorD4 V){ return MkVectorD4(V.w, 0, V.z, V.z); }
inline VectorD4 SwizzW_ZW(VectorD4 V){ return MkVectorD4(V.w, 0, V.z, V.w); }
inline VectorD4 SwizzW_Z_(VectorD4 V){ return MkVectorD4(V.w, 0, V.z, 0); }
inline VectorD4 SwizzW_WX(VectorD4 V){ return MkVectorD4(V.w, 0, V.w, V.x); }
inline VectorD4 SwizzW_WY(VectorD4 V){ return MkVectorD4(V.w, 0, V.w, V.y); }
inline VectorD4 SwizzW_WZ(VectorD4 V){ return MkVectorD4(V.w, 0, V.w, V.z); }
inline VectorD4 SwizzW_WW(VectorD4 V){ return MkVectorD4(V.w, 0, V.w, V.w); }
inline VectorD4 SwizzW_W_(VectorD4 V){ return MkVectorD4(V.w, 0, V.w, 0); }
inline VectorD4 SwizzW__X(VectorD4 V){ return MkVectorD4(V.w, 0, 0, V.x); }
inline VectorD4 SwizzW__Y(VectorD4 V){ return MkVectorD4(V.w, 0, 0, V.y); }
inline VectorD4 SwizzW__Z(VectorD4 V){ return MkVectorD4(V.w, 0, 0, V.z); }
inline VectorD4 SwizzW__W(VectorD4 V){ return MkVectorD4(V.w, 0, 0, V.w); }
inline VectorD4 SwizzW___(VectorD4 V){ return MkVectorD4(V.w, 0, 0, 0); }
inline VectorD4 Swizz_XXX(VectorD4 V){ return MkVectorD4(0, V.x, V.x, V.x); }
inline VectorD4 Swizz_XXY(VectorD4 V){ return MkVectorD4(0, V.x, V.x, V.y); }
inline VectorD4 Swizz_XXZ(VectorD4 V){ return MkVectorD4(0, V.x, V.x, V.z); }
inline VectorD4 Swizz_XXW(VectorD4 V){ return MkVectorD4(0, V.x, V.x, V.w); }
inline VectorD4 Swizz_XX_(VectorD4 V){ return MkVectorD4(0, V.x, V.x, 0); }
inline VectorD4 Swizz_XYX(VectorD4 V){ return MkVectorD4(0, V.x, V.y, V.x); }
inline VectorD4 Swizz_XYY(VectorD4 V){ return MkVectorD4(0, V.x, V.y, V.y); }
inline VectorD4 Swizz_XYZ(VectorD4 V){ return MkVectorD4(0, V.x, V.y, V.z); }
inline VectorD4 Swizz_XYW(VectorD4 V){ return MkVectorD4(0, V.x, V.y, V.w); }
inline VectorD4 Swizz_XY_(VectorD4 V){ return MkVectorD4(0, V.x, V.y, 0); }
inline VectorD4 Swizz_XZX(VectorD4 V){ return MkVectorD4(0, V.x, V.z, V.x); }
inline VectorD4 Swizz_XZY(VectorD4 V){ return MkVectorD4(0, V.x, V.z, V.y); }
inline VectorD4 Swizz_XZZ(VectorD4 V){ return MkVectorD4(0, V.x, V.z, V.z); }
inline VectorD4 Swizz_XZW(VectorD4 V){ return MkVectorD4(0, V.x, V.z, V.w); }
inline VectorD4 Swizz_XZ_(VectorD4 V){ return MkVectorD4(0, V.x, V.z, 0); }
inline VectorD4 Swizz_XWX(VectorD4 V){ return MkVectorD4(0, V.x, V.w, V.x); }
inline VectorD4 Swizz_XWY(VectorD4 V){ return MkVectorD4(0, V.x, V.w, V.y); }
inline VectorD4 Swizz_XWZ(VectorD4 V){ return MkVectorD4(0, V.x, V.w, V.z); }
inline VectorD4 Swizz_XWW(VectorD4 V){ return MkVectorD4(0, V.x, V.w, V.w); }
inline VectorD4 Swizz_XW_(VectorD4 V){ return MkVectorD4(0, V.x, V.w, 0); }
inline VectorD4 Swizz_X_X(VectorD4 V){ return MkVectorD4(0, V.x, 0, V.x); }
inline VectorD4 Swizz_X_Y(VectorD4 V){ return MkVectorD4(0, V.x, 0, V.y); }
inline VectorD4 Swizz_X_Z(VectorD4 V){ return MkVectorD4(0, V.x, 0, V.z); }
inline VectorD4 Swizz_X_W(VectorD4 V){ return MkVectorD4(0, V.x, 0, V.w); }
inline VectorD4 Swizz_X__(VectorD4 V){ return MkVectorD4(0, V.x, 0, 0); }
inline VectorD4 Swizz_YXX(VectorD4 V){ return MkVectorD4(0, V.y, V.x, V.x); }
inline VectorD4 Swizz_YXY(VectorD4 V){ return MkVectorD4(0, V.y, V.x, V.y); }
inline VectorD4 Swizz_YXZ(VectorD4 V){ return MkVectorD4(0, V.y, V.x, V.z); }
inline VectorD4 Swizz_YXW(VectorD4 V){ return MkVectorD4(0, V.y, V.x, V.w); }
inline VectorD4 Swizz_YX_(VectorD4 V){ return MkVectorD4(0, V.y, V.x, 0); }
inline VectorD4 Swizz_YYX(VectorD4 V){ return MkVectorD4(0, V.y, V.y, V.x); }
inline VectorD4 Swizz_YYY(VectorD4 V){ return MkVectorD4(0, V.y, V.y, V.y); }
inline VectorD4 Swizz_YYZ(VectorD4 V){ return MkVectorD4(0, V.y, V.y, V.z); }
inline VectorD4 Swizz_YYW(VectorD4 V){ return MkVectorD4(0, V.y, V.y, V.w); }
inline VectorD4 Swizz_YY_(VectorD4 V){ return MkVectorD4(0, V.y, V.y, 0); }
inline VectorD4 Swizz_YZX(VectorD4 V){ return MkVectorD4(0, V.y, V.z, V.x); }
inline VectorD4 Swizz_YZY(VectorD4 V){ return MkVectorD4(0, V.y, V.z, V.y); }
inline VectorD4 Swizz_YZZ(VectorD4 V){ return MkVectorD4(0, V.y, V.z, V.z); }
inline VectorD4 Swizz_YZW(VectorD4 V){ return MkVectorD4(0, V.y, V.z, V.w); }
inline VectorD4 Swizz_YZ_(VectorD4 V){ return MkVectorD4(0, V.y, V.z, 0); }
inline VectorD4 Swizz_YWX(VectorD4 V){ return MkVectorD4(0, V.y, V.w, V.x); }
inline VectorD4 Swizz_YWY(VectorD4 V){ return MkVectorD4(0, V.y, V.w, V.y); }
inline VectorD4 Swizz_YWZ(VectorD4 V){ return MkVectorD4(0, V.y, V.w, V.z); }
inline VectorD4 Swizz_YWW(VectorD4 V){ return MkVectorD4(0, V.y, V.w, V.w); }
inline VectorD4 Swizz_YW_(VectorD4 V){ return MkVectorD4(0, V.y, V.w, 0); }
inline VectorD4 Swizz_Y_X(VectorD4 V){ return MkVectorD4(0, V.y, 0, V.x); }
inline VectorD4 Swizz_Y_Y(VectorD4 V){ return MkVectorD4(0, V.y, 0, V.y); }
inline VectorD4 Swizz_Y_Z(VectorD4 V){ return MkVectorD4(0, V.y, 0, V.z); }
inline VectorD4 Swizz_Y_W(VectorD4 V){ return MkVectorD4(0, V.y, 0, V.w); }
inline VectorD4 Swizz_Y__(VectorD4 V){ return MkVectorD4(0, V.y, 0, 0); }
inline VectorD4 Swizz_ZXX(VectorD4 V){ return MkVectorD4(0, V.z, V.x, V.x); }
inline VectorD4 Swizz_ZXY(VectorD4 V){ return MkVectorD4(0, V.z, V.x, V.y); }
inline VectorD4 Swizz_ZXZ(VectorD4 V){ return MkVectorD4(0, V.z, V.x, V.z); }
inline VectorD4 Swizz_ZXW(VectorD4 V){ return MkVectorD4(0, V.z, V.x, V.w); }
inline VectorD4 Swizz_ZX_(VectorD4 V){ return MkVectorD4(0, V.z, V.x, 0); }
inline VectorD4 Swizz_ZYX(VectorD4 V){ return MkVectorD4(0, V.z, V.y, V.x); }
inline VectorD4 Swizz_ZYY(VectorD4 V){ return MkVectorD4(0, V.z, V.y, V.y); }
inline VectorD4 Swizz_ZYZ(VectorD4 V){ return MkVectorD4(0, V.z, V.y, V.z); }
inline VectorD4 Swizz_ZYW(VectorD4 V){ return MkVectorD4(0, V.z, V.y, V.w); }
inline VectorD4 Swizz_ZY_(VectorD4 V){ return MkVectorD4(0, V.z, V.y, 0); }
inline VectorD4 Swizz_ZZX(VectorD4 V){ return MkVectorD4(0, V.z, V.z, V.x); }
inline VectorD4 Swizz_ZZY(VectorD4 V){ return MkVectorD4(0, V.z, V.z, V.y); }
inline VectorD4 Swizz_ZZZ(VectorD4 V){ return MkVectorD4(0, V.z, V.z, V.z); }
inline VectorD4 Swizz_ZZW(VectorD4 V){ return MkVectorD4(0, V.z, V.z, V.w); }
inline VectorD4 Swizz_ZZ_(VectorD4 V){ return MkVectorD4(0, V.z, V.z, 0); }
inline VectorD4 Swizz_ZWX(VectorD4 V){ return MkVectorD4(0, V.z, V.w, V.x); }
inline VectorD4 Swizz_ZWY(VectorD4 V){ return MkVectorD4(0, V.z, V.w, V.y); }
inline VectorD4 Swizz_ZWZ(VectorD4 V){ return MkVectorD4(0, V.z, V.w, V.z); }
inline VectorD4 Swizz_ZWW(VectorD4 V){ return MkVectorD4(0, V.z, V.w, V.w); }
inline VectorD4 Swizz_ZW_(VectorD4 V){ return MkVectorD4(0, V.z, V.w, 0); }
inline VectorD4 Swizz_Z_X(VectorD4 V){ return MkVectorD4(0, V.z, 0, V.x); }
inline VectorD4 Swizz_Z_Y(VectorD4 V){ return MkVectorD4(0, V.z, 0, V.y); }
inline VectorD4 Swizz_Z_Z(VectorD4 V){ return MkVectorD4(0, V.z, 0, V.z); }
inline VectorD4 Swizz_Z_W(VectorD4 V){ return MkVectorD4(0, V.z, 0, V.w); }
inline VectorD4 Swizz_Z__(VectorD4 V){ return MkVectorD4(0, V.z, 0, 0); }
inline VectorD4 Swizz_WXX(VectorD4 V){ return MkVectorD4(0, V.w, V.x, V.x); }
inline VectorD4 Swizz_WXY(VectorD4 V){ return MkVectorD4(0, V.w, V.x, V.y); }
inline VectorD4 Swizz_WXZ(VectorD4 V){ return MkVectorD4(0, V.w, V.x, V.z); }
inline VectorD4 Swizz_WXW(VectorD4 V){ return MkVectorD4(0, V.w, V.x, V.w); }
inline VectorD4 Swizz_WX_(VectorD4 V){ return MkVectorD4(0, V.w, V.x, 0); }
inline VectorD4 Swizz_WYX(VectorD4 V){ return MkVectorD4(0, V.w, V.y, V.x); }
inline VectorD4 Swizz_WYY(VectorD4 V){ return MkVectorD4(0, V.w, V.y, V.y); }
inline VectorD4 Swizz_WYZ(VectorD4 V){ return MkVectorD4(0, V.w, V.y, V.z); }
inline VectorD4 Swizz_WYW(VectorD4 V){ return MkVectorD4(0, V.w, V.y, V.w); }
inline VectorD4 Swizz_WY_(VectorD4 V){ return MkVectorD4(0, V.w, V.y, 0); }
inline VectorD4 Swizz_WZX(VectorD4 V){ return MkVectorD4(0, V.w, V.z, V.x); }
inline VectorD4 Swizz_WZY(VectorD4 V){ return MkVectorD4(0, V.w, V.z, V.y); }
inline VectorD4 Swizz_WZZ(VectorD4 V){ return MkVectorD4(0, V.w, V.z, V.z); }
inline VectorD4 Swizz_WZW(VectorD4 V){ return MkVectorD4(0, V.w, V.z, V.w); }
inline VectorD4 Swizz_WZ_(VectorD4 V){ return MkVectorD4(0, V.w, V.z, 0); }
inline VectorD4 Swizz_WWX(VectorD4 V){ return MkVectorD4(0, V.w, V.w, V.x); }
inline VectorD4 Swizz_WWY(VectorD4 V){ return MkVectorD4(0, V.w, V.w, V.y); }
inline VectorD4 Swizz_WWZ(VectorD4 V){ return MkVectorD4(0, V.w, V.w, V.z); }
inline VectorD4 Swizz_WWW(VectorD4 V){ return MkVectorD4(0, V.w, V.w, V.w); }
inline VectorD4 Swizz_WW_(VectorD4 V){ return MkVectorD4(0, V.w, V.w, 0); }
inline VectorD4 Swizz_W_X(VectorD4 V){ return MkVectorD4(0, V.w, 0, V.x); }
inline VectorD4 Swizz_W_Y(VectorD4 V){ return MkVectorD4(0, V.w, 0, V.y); }
inline VectorD4 Swizz_W_Z(VectorD4 V){ return MkVectorD4(0, V.w, 0, V.z); }
inline VectorD4 Swizz_W_W(VectorD4 V){ return MkVectorD4(0, V.w, 0, V.w); }
inline VectorD4 Swizz_W__(VectorD4 V){ return MkVectorD4(0, V.w, 0, 0); }
inline VectorD4 Swizz__XX(VectorD4 V){ return MkVectorD4(0, 0, V.x, V.x); }
inline VectorD4 Swizz__XY(VectorD4 V){ return MkVectorD4(0, 0, V.x, V.y); }
inline VectorD4 Swizz__XZ(VectorD4 V){ return MkVectorD4(0, 0, V.x, V.z); }
inline VectorD4 Swizz__XW(VectorD4 V){ return MkVectorD4(0, 0, V.x, V.w); }
inline VectorD4 Swizz__X_(VectorD4 V){ return MkVectorD4(0, 0, V.x, 0); }
inline VectorD4 Swizz__YX(VectorD4 V){ return MkVectorD4(0, 0, V.y, V.x); }
inline VectorD4 Swizz__YY(VectorD4 V){ return MkVectorD4(0, 0, V.y, V.y); }
inline VectorD4 Swizz__YZ(VectorD4 V){ return MkVectorD4(0, 0, V.y, V.z); }
inline VectorD4 Swizz__YW(VectorD4 V){ return MkVectorD4(0, 0, V.y, V.w); }
inline VectorD4 Swizz__Y_(VectorD4 V){ return MkVectorD4(0, 0, V.y, 0); }
inline VectorD4 Swizz__ZX(VectorD4 V){ return MkVectorD4(0, 0, V.z, V.x); }
inline VectorD4 Swizz__ZY(VectorD4 V){ return MkVectorD4(0, 0, V.z, V.y); }
inline VectorD4 Swizz__ZZ(VectorD4 V){ return MkVectorD4(0, 0, V.z, V.z); }
inline VectorD4 Swizz__ZW(VectorD4 V){ return MkVectorD4(0, 0, V.z, V.w); }
inline VectorD4 Swizz__Z_(VectorD4 V){ return MkVectorD4(0, 0, V.z, 0); }
inline VectorD4 Swizz__WX(VectorD4 V){ return MkVectorD4(0, 0, V.w, V.x); }
inline VectorD4 Swizz__WY(VectorD4 V){ return MkVectorD4(0, 0, V.w, V.y); }
inline VectorD4 Swizz__WZ(VectorD4 V){ return MkVectorD4(0, 0, V.w, V.z); }
inline VectorD4 Swizz__WW(VectorD4 V){ return MkVectorD4(0, 0, V.w, V.w); }
inline VectorD4 Swizz__W_(VectorD4 V){ return MkVectorD4(0, 0, V.w, 0); }
inline VectorD4 Swizz___X(VectorD4 V){ return MkVectorD4(0, 0, 0, V.x); }
inline VectorD4 Swizz___Y(VectorD4 V){ return MkVectorD4(0, 0, 0, V.y); }
inline VectorD4 Swizz___Z(VectorD4 V){ return MkVectorD4(0, 0, 0, V.z); }
inline VectorD4 Swizz___W(VectorD4 V){ return MkVectorD4(0, 0, 0, V.w); }
inline Vector2 SwizzXX(Vector2 V){ return MkVector2(V.x, V.x); }
inline Vector2 SwizzXY(Vector2 V){ return MkVector2(V.x, V.y); }
inline Vector2 SwizzX_(Vector2 V){ return MkVector2(V.x, 0); }
inline Vector2 SwizzYX(Vector2 V){ return MkVector2(V.y, V.x); }
inline Vector2 SwizzYY(Vector2 V){ return MkVector2(V.y, V.y); }
inline Vector2 SwizzY_(Vector2 V){ return MkVector2(V.y, 0); }
inline Vector2 Swizz_X(Vector2 V){ return MkVector2(0, V.x); }
inline Vector2 Swizz_Y(Vector2 V){ return MkVector2(0, V.y); }
inline Vector3 SwizzXXX(Vector2 V){ return MkVector3(V.x, V.x, V.x); }
inline Vector3 SwizzXXY(Vector2 V){ return MkVector3(V.x, V.x, V.y); }
inline Vector3 SwizzXX_(Vector2 V){ return MkVector3(V.x, V.x, 0); }
inline Vector3 SwizzXYX(Vector2 V){ return MkVector3(V.x, V.y, V.x); }
inline Vector3 SwizzXYY(Vector2 V){ return MkVector3(V.x, V.y, V.y); }
inline Vector3 SwizzXY_(Vector2 V){ return MkVector3(V.x, V.y, 0); }
inline Vector3 SwizzX_X(Vector2 V){ return MkVector3(V.x, 0, V.x); }
inline Vector3 SwizzX_Y(Vector2 V){ return MkVector3(V.x, 0, V.y); }
inline Vector3 SwizzX__(Vector2 V){ return MkVector3(V.x, 0, 0); }
inline Vector3 SwizzYXX(Vector2 V){ return MkVector3(V.y, V.x, V.x); }
inline Vector3 SwizzYXY(Vector2 V){ return MkVector3(V.y, V.x, V.y); }
inline Vector3 SwizzYX_(Vector2 V){ return MkVector3(V.y, V.x, 0); }
inline Vector3 SwizzYYX(Vector2 V){ return MkVector3(V.y, V.y, V.x); }
inline Vector3 SwizzYYY(Vector2 V){ return MkVector3(V.y, V.y, V.y); }
inline Vector3 SwizzYY_(Vector2 V){ return MkVector3(V.y, V.y, 0); }
inline Vector3 SwizzY_X(Vector2 V){ return MkVector3(V.y, 0, V.x); }
inline Vector3 SwizzY_Y(Vector2 V){ return MkVector3(V.y, 0, V.y); }
inline Vector3 SwizzY__(Vector2 V){ return MkVector3(V.y, 0, 0); }
inline Vector3 Swizz_XX(Vector2 V){ return MkVector3(0, V.x, V.x); }
inline Vector3 Swizz_XY(Vector2 V){ return MkVector3(0, V.x, V.y); }
inline Vector3 Swizz_X_(Vector2 V){ return MkVector3(0, V.x, 0); }
inline Vector3 Swizz_YX(Vector2 V){ return MkVector3(0, V.y, V.x); }
inline Vector3 Swizz_YY(Vector2 V){ return MkVector3(0, V.y, V.y); }
inline Vector3 Swizz_Y_(Vector2 V){ return MkVector3(0, V.y, 0); }
inline Vector3 Swizz__X(Vector2 V){ return MkVector3(0, 0, V.x); }
inline Vector3 Swizz__Y(Vector2 V){ return MkVector3(0, 0, V.y); }
inline Vector4 SwizzXXXX(Vector2 V){ return MkVector4(V.x, V.x, V.x, V.x); }
inline Vector4 SwizzXXXY(Vector2 V){ return MkVector4(V.x, V.x, V.x, V.y); }
inline Vector4 SwizzXXX_(Vector2 V){ return MkVector4(V.x, V.x, V.x, 0); }
inline Vector4 SwizzXXYX(Vector2 V){ return MkVector4(V.x, V.x, V.y, V.x); }
inline Vector4 SwizzXXYY(Vector2 V){ return MkVector4(V.x, V.x, V.y, V.y); }
inline Vector4 SwizzXXY_(Vector2 V){ return MkVector4(V.x, V.x, V.y, 0); }
inline Vector4 SwizzXX_X(Vector2 V){ return MkVector4(V.x, V.x, 0, V.x); }
inline Vector4 SwizzXX_Y(Vector2 V){ return MkVector4(V.x, V.x, 0, V.y); }
inline Vector4 SwizzXX__(Vector2 V){ return MkVector4(V.x, V.x, 0, 0); }
inline Vector4 SwizzXYXX(Vector2 V){ return MkVector4(V.x, V.y, V.x, V.x); }
inline Vector4 SwizzXYXY(Vector2 V){ return MkVector4(V.x, V.y, V.x, V.y); }
inline Vector4 SwizzXYX_(Vector2 V){ return MkVector4(V.x, V.y, V.x, 0); }
inline Vector4 SwizzXYYX(Vector2 V){ return MkVector4(V.x, V.y, V.y, V.x); }
inline Vector4 SwizzXYYY(Vector2 V){ return MkVector4(V.x, V.y, V.y, V.y); }
inline Vector4 SwizzXYY_(Vector2 V){ return MkVector4(V.x, V.y, V.y, 0); }
inline Vector4 SwizzXY_X(Vector2 V){ return MkVector4(V.x, V.y, 0, V.x); }
inline Vector4 SwizzXY_Y(Vector2 V){ return MkVector4(V.x, V.y, 0, V.y); }
inline Vector4 SwizzXY__(Vector2 V){ return MkVector4(V.x, V.y, 0, 0); }
inline Vector4 SwizzX_XX(Vector2 V){ return MkVector4(V.x, 0, V.x, V.x); }
inline Vector4 SwizzX_XY(Vector2 V){ return MkVector4(V.x, 0, V.x, V.y); }
inline Vector4 SwizzX_X_(Vector2 V){ return MkVector4(V.x, 0, V.x, 0); }
inline Vector4 SwizzX_YX(Vector2 V){ return MkVector4(V.x, 0, V.y, V.x); }
inline Vector4 SwizzX_YY(Vector2 V){ return MkVector4(V.x, 0, V.y, V.y); }
inline Vector4 SwizzX_Y_(Vector2 V){ return MkVector4(V.x, 0, V.y, 0); }
inline Vector4 SwizzX__X(Vector2 V){ return MkVector4(V.x, 0, 0, V.x); }
inline Vector4 SwizzX__Y(Vector2 V){ return MkVector4(V.x, 0, 0, V.y); }
inline Vector4 SwizzX___(Vector2 V){ return MkVector4(V.x, 0, 0, 0); }
inline Vector4 SwizzYXXX(Vector2 V){ return MkVector4(V.y, V.x, V.x, V.x); }
inline Vector4 SwizzYXXY(Vector2 V){ return MkVector4(V.y, V.x, V.x, V.y); }
inline Vector4 SwizzYXX_(Vector2 V){ return MkVector4(V.y, V.x, V.x, 0); }
inline Vector4 SwizzYXYX(Vector2 V){ return MkVector4(V.y, V.x, V.y, V.x); }
inline Vector4 SwizzYXYY(Vector2 V){ return MkVector4(V.y, V.x, V.y, V.y); }
inline Vector4 SwizzYXY_(Vector2 V){ return MkVector4(V.y, V.x, V.y, 0); }
inline Vector4 SwizzYX_X(Vector2 V){ return MkVector4(V.y, V.x, 0, V.x); }
inline Vector4 SwizzYX_Y(Vector2 V){ return MkVector4(V.y, V.x, 0, V.y); }
inline Vector4 SwizzYX__(Vector2 V){ return MkVector4(V.y, V.x, 0, 0); }
inline Vector4 SwizzYYXX(Vector2 V){ return MkVector4(V.y, V.y, V.x, V.x); }
inline Vector4 SwizzYYXY(Vector2 V){ return MkVector4(V.y, V.y, V.x, V.y); }
inline Vector4 SwizzYYX_(Vector2 V){ return MkVector4(V.y, V.y, V.x, 0); }
inline Vector4 SwizzYYYX(Vector2 V){ return MkVector4(V.y, V.y, V.y, V.x); }
inline Vector4 SwizzYYYY(Vector2 V){ return MkVector4(V.y, V.y, V.y, V.y); }
inline Vector4 SwizzYYY_(Vector2 V){ return MkVector4(V.y, V.y, V.y, 0); }
inline Vector4 SwizzYY_X(Vector2 V){ return MkVector4(V.y, V.y, 0, V.x); }
inline Vector4 SwizzYY_Y(Vector2 V){ return MkVector4(V.y, V.y, 0, V.y); }
inline Vector4 SwizzYY__(Vector2 V){ return MkVector4(V.y, V.y, 0, 0); }
inline Vector4 SwizzY_XX(Vector2 V){ return MkVector4(V.y, 0, V.x, V.x); }
inline Vector4 SwizzY_XY(Vector2 V){ return MkVector4(V.y, 0, V.x, V.y); }
inline Vector4 SwizzY_X_(Vector2 V){ return MkVector4(V.y, 0, V.x, 0); }
inline Vector4 SwizzY_YX(Vector2 V){ return MkVector4(V.y, 0, V.y, V.x); }
inline Vector4 SwizzY_YY(Vector2 V){ return MkVector4(V.y, 0, V.y, V.y); }
inline Vector4 SwizzY_Y_(Vector2 V){ return MkVector4(V.y, 0, V.y, 0); }
inline Vector4 SwizzY__X(Vector2 V){ return MkVector4(V.y, 0, 0, V.x); }
inline Vector4 SwizzY__Y(Vector2 V){ return MkVector4(V.y, 0, 0, V.y); }
inline Vector4 SwizzY___(Vector2 V){ return MkVector4(V.y, 0, 0, 0); }
inline Vector4 Swizz_XXX(Vector2 V){ return MkVector4(0, V.x, V.x, V.x); }
inline Vector4 Swizz_XXY(Vector2 V){ return MkVector4(0, V.x, V.x, V.y); }
inline Vector4 Swizz_XX_(Vector2 V){ return MkVector4(0, V.x, V.x, 0); }
inline Vector4 Swizz_XYX(Vector2 V){ return MkVector4(0, V.x, V.y, V.x); }
inline Vector4 Swizz_XYY(Vector2 V){ return MkVector4(0, V.x, V.y, V.y); }
inline Vector4 Swizz_XY_(Vector2 V){ return MkVector4(0, V.x, V.y, 0); }
inline Vector4 Swizz_X_X(Vector2 V){ return MkVector4(0, V.x, 0, V.x); }
inline Vector4 Swizz_X_Y(Vector2 V){ return MkVector4(0, V.x, 0, V.y); }
inline Vector4 Swizz_X__(Vector2 V){ return MkVector4(0, V.x, 0, 0); }
inline Vector4 Swizz_YXX(Vector2 V){ return MkVector4(0, V.y, V.x, V.x); }
inline Vector4 Swizz_YXY(Vector2 V){ return MkVector4(0, V.y, V.x, V.y); }
inline Vector4 Swizz_YX_(Vector2 V){ return MkVector4(0, V.y, V.x, 0); }
inline Vector4 Swizz_YYX(Vector2 V){ return MkVector4(0, V.y, V.y, V.x); }
inline Vector4 Swizz_YYY(Vector2 V){ return MkVector4(0, V.y, V.y, V.y); }
inline Vector4 Swizz_YY_(Vector2 V){ return MkVector4(0, V.y, V.y, 0); }
inline Vector4 Swizz_Y_X(Vector2 V){ return MkVector4(0, V.y, 0, V.x); }
inline Vector4 Swizz_Y_Y(Vector2 V){ return MkVector4(0, V.y, 0, V.y); }
inline Vector4 Swizz_Y__(Vector2 V){ return MkVector4(0, V.y, 0, 0); }
inline Vector4 Swizz__XX(Vector2 V){ return MkVector4(0, 0, V.x, V.x); }
inline Vector4 Swizz__XY(Vector2 V){ return MkVector4(0, 0, V.x, V.y); }
inline Vector4 Swizz__X_(Vector2 V){ return MkVector4(0, 0, V.x, 0); }
inline Vector4 Swizz__YX(Vector2 V){ return MkVector4(0, 0, V.y, V.x); }
inline Vector4 Swizz__YY(Vector2 V){ return MkVector4(0, 0, V.y, V.y); }
inline Vector4 Swizz__Y_(Vector2 V){ return MkVector4(0, 0, V.y, 0); }
inline Vector4 Swizz___X(Vector2 V){ return MkVector4(0, 0, 0, V.x); }
inline Vector4 Swizz___Y(Vector2 V){ return MkVector4(0, 0, 0, V.y); }
inline Vector2 SwizzXX(Vector3 V){ return MkVector2(V.x, V.x); }
inline Vector2 SwizzXY(Vector3 V){ return MkVector2(V.x, V.y); }
inline Vector2 SwizzXZ(Vector3 V){ return MkVector2(V.x, V.z); }
inline Vector2 SwizzX_(Vector3 V){ return MkVector2(V.x, 0); }
inline Vector2 SwizzYX(Vector3 V){ return MkVector2(V.y, V.x); }
inline Vector2 SwizzYY(Vector3 V){ return MkVector2(V.y, V.y); }
inline Vector2 SwizzYZ(Vector3 V){ return MkVector2(V.y, V.z); }
inline Vector2 SwizzY_(Vector3 V){ return MkVector2(V.y, 0); }
inline Vector2 SwizzZX(Vector3 V){ return MkVector2(V.z, V.x); }
inline Vector2 SwizzZY(Vector3 V){ return MkVector2(V.z, V.y); }
inline Vector2 SwizzZZ(Vector3 V){ return MkVector2(V.z, V.z); }
inline Vector2 SwizzZ_(Vector3 V){ return MkVector2(V.z, 0); }
inline Vector2 Swizz_X(Vector3 V){ return MkVector2(0, V.x); }
inline Vector2 Swizz_Y(Vector3 V){ return MkVector2(0, V.y); }
inline Vector2 Swizz_Z(Vector3 V){ return MkVector2(0, V.z); }
inline Vector3 SwizzXXX(Vector3 V){ return MkVector3(V.x, V.x, V.x); }
inline Vector3 SwizzXXY(Vector3 V){ return MkVector3(V.x, V.x, V.y); }
inline Vector3 SwizzXXZ(Vector3 V){ return MkVector3(V.x, V.x, V.z); }
inline Vector3 SwizzXX_(Vector3 V){ return MkVector3(V.x, V.x, 0); }
inline Vector3 SwizzXYX(Vector3 V){ return MkVector3(V.x, V.y, V.x); }
inline Vector3 SwizzXYY(Vector3 V){ return MkVector3(V.x, V.y, V.y); }
inline Vector3 SwizzXYZ(Vector3 V){ return MkVector3(V.x, V.y, V.z); }
inline Vector3 SwizzXY_(Vector3 V){ return MkVector3(V.x, V.y, 0); }
inline Vector3 SwizzXZX(Vector3 V){ return MkVector3(V.x, V.z, V.x); }
inline Vector3 SwizzXZY(Vector3 V){ return MkVector3(V.x, V.z, V.y); }
inline Vector3 SwizzXZZ(Vector3 V){ return MkVector3(V.x, V.z, V.z); }
inline Vector3 SwizzXZ_(Vector3 V){ return MkVector3(V.x, V.z, 0); }
inline Vector3 SwizzX_X(Vector3 V){ return MkVector3(V.x, 0, V.x); }
inline Vector3 SwizzX_Y(Vector3 V){ return MkVector3(V.x, 0, V.y); }
inline Vector3 SwizzX_Z(Vector3 V){ return MkVector3(V.x, 0, V.z); }
inline Vector3 SwizzX__(Vector3 V){ return MkVector3(V.x, 0, 0); }
inline Vector3 SwizzYXX(Vector3 V){ return MkVector3(V.y, V.x, V.x); }
inline Vector3 SwizzYXY(Vector3 V){ return MkVector3(V.y, V.x, V.y); }
inline Vector3 SwizzYXZ(Vector3 V){ return MkVector3(V.y, V.x, V.z); }
inline Vector3 SwizzYX_(Vector3 V){ return MkVector3(V.y, V.x, 0); }
inline Vector3 SwizzYYX(Vector3 V){ return MkVector3(V.y, V.y, V.x); }
inline Vector3 SwizzYYY(Vector3 V){ return MkVector3(V.y, V.y, V.y); }
inline Vector3 SwizzYYZ(Vector3 V){ return MkVector3(V.y, V.y, V.z); }
inline Vector3 SwizzYY_(Vector3 V){ return MkVector3(V.y, V.y, 0); }
inline Vector3 SwizzYZX(Vector3 V){ return MkVector3(V.y, V.z, V.x); }
inline Vector3 SwizzYZY(Vector3 V){ return MkVector3(V.y, V.z, V.y); }
inline Vector3 SwizzYZZ(Vector3 V){ return MkVector3(V.y, V.z, V.z); }
inline Vector3 SwizzYZ_(Vector3 V){ return MkVector3(V.y, V.z, 0); }
inline Vector3 SwizzY_X(Vector3 V){ return MkVector3(V.y, 0, V.x); }
inline Vector3 SwizzY_Y(Vector3 V){ return MkVector3(V.y, 0, V.y); }
inline Vector3 SwizzY_Z(Vector3 V){ return MkVector3(V.y, 0, V.z); }
inline Vector3 SwizzY__(Vector3 V){ return MkVector3(V.y, 0, 0); }
inline Vector3 SwizzZXX(Vector3 V){ return MkVector3(V.z, V.x, V.x); }
inline Vector3 SwizzZXY(Vector3 V){ return MkVector3(V.z, V.x, V.y); }
inline Vector3 SwizzZXZ(Vector3 V){ return MkVector3(V.z, V.x, V.z); }
inline Vector3 SwizzZX_(Vector3 V){ return MkVector3(V.z, V.x, 0); }
inline Vector3 SwizzZYX(Vector3 V){ return MkVector3(V.z, V.y, V.x); }
inline Vector3 SwizzZYY(Vector3 V){ return MkVector3(V.z, V.y, V.y); }
inline Vector3 SwizzZYZ(Vector3 V){ return MkVector3(V.z, V.y, V.z); }
inline Vector3 SwizzZY_(Vector3 V){ return MkVector3(V.z, V.y, 0); }
inline Vector3 SwizzZZX(Vector3 V){ return MkVector3(V.z, V.z, V.x); }
inline Vector3 SwizzZZY(Vector3 V){ return MkVector3(V.z, V.z, V.y); }
inline Vector3 SwizzZZZ(Vector3 V){ return MkVector3(V.z, V.z, V.z); }
inline Vector3 SwizzZZ_(Vector3 V){ return MkVector3(V.z, V.z, 0); }
inline Vector3 SwizzZ_X(Vector3 V){ return MkVector3(V.z, 0, V.x); }
inline Vector3 SwizzZ_Y(Vector3 V){ return MkVector3(V.z, 0, V.y); }
inline Vector3 SwizzZ_Z(Vector3 V){ return MkVector3(V.z, 0, V.z); }
inline Vector3 SwizzZ__(Vector3 V){ return MkVector3(V.z, 0, 0); }
inline Vector3 Swizz_XX(Vector3 V){ return MkVector3(0, V.x, V.x); }
inline Vector3 Swizz_XY(Vector3 V){ return MkVector3(0, V.x, V.y); }
inline Vector3 Swizz_XZ(Vector3 V){ return MkVector3(0, V.x, V.z); }
inline Vector3 Swizz_X_(Vector3 V){ return MkVector3(0, V.x, 0); }
inline Vector3 Swizz_YX(Vector3 V){ return MkVector3(0, V.y, V.x); }
inline Vector3 Swizz_YY(Vector3 V){ return MkVector3(0, V.y, V.y); }
inline Vector3 Swizz_YZ(Vector3 V){ return MkVector3(0, V.y, V.z); }
inline Vector3 Swizz_Y_(Vector3 V){ return MkVector3(0, V.y, 0); }
inline Vector3 Swizz_ZX(Vector3 V){ return MkVector3(0, V.z, V.x); }
inline Vector3 Swizz_ZY(Vector3 V){ return MkVector3(0, V.z, V.y); }
inline Vector3 Swizz_ZZ(Vector3 V){ return MkVector3(0, V.z, V.z); }
inline Vector3 Swizz_Z_(Vector3 V){ return MkVector3(0, V.z, 0); }
inline Vector3 Swizz__X(Vector3 V){ return MkVector3(0, 0, V.x); }
inline Vector3 Swizz__Y(Vector3 V){ return MkVector3(0, 0, V.y); }
inline Vector3 Swizz__Z(Vector3 V){ return MkVector3(0, 0, V.z); }
inline Vector4 SwizzXXXX(Vector3 V){ return MkVector4(V.x, V.x, V.x, V.x); }
inline Vector4 SwizzXXXY(Vector3 V){ return MkVector4(V.x, V.x, V.x, V.y); }
inline Vector4 SwizzXXXZ(Vector3 V){ return MkVector4(V.x, V.x, V.x, V.z); }
inline Vector4 SwizzXXX_(Vector3 V){ return MkVector4(V.x, V.x, V.x, 0); }
inline Vector4 SwizzXXYX(Vector3 V){ return MkVector4(V.x, V.x, V.y, V.x); }
inline Vector4 SwizzXXYY(Vector3 V){ return MkVector4(V.x, V.x, V.y, V.y); }
inline Vector4 SwizzXXYZ(Vector3 V){ return MkVector4(V.x, V.x, V.y, V.z); }
inline Vector4 SwizzXXY_(Vector3 V){ return MkVector4(V.x, V.x, V.y, 0); }
inline Vector4 SwizzXXZX(Vector3 V){ return MkVector4(V.x, V.x, V.z, V.x); }
inline Vector4 SwizzXXZY(Vector3 V){ return MkVector4(V.x, V.x, V.z, V.y); }
inline Vector4 SwizzXXZZ(Vector3 V){ return MkVector4(V.x, V.x, V.z, V.z); }
inline Vector4 SwizzXXZ_(Vector3 V){ return MkVector4(V.x, V.x, V.z, 0); }
inline Vector4 SwizzXX_X(Vector3 V){ return MkVector4(V.x, V.x, 0, V.x); }
inline Vector4 SwizzXX_Y(Vector3 V){ return MkVector4(V.x, V.x, 0, V.y); }
inline Vector4 SwizzXX_Z(Vector3 V){ return MkVector4(V.x, V.x, 0, V.z); }
inline Vector4 SwizzXX__(Vector3 V){ return MkVector4(V.x, V.x, 0, 0); }
inline Vector4 SwizzXYXX(Vector3 V){ return MkVector4(V.x, V.y, V.x, V.x); }
inline Vector4 SwizzXYXY(Vector3 V){ return MkVector4(V.x, V.y, V.x, V.y); }
inline Vector4 SwizzXYXZ(Vector3 V){ return MkVector4(V.x, V.y, V.x, V.z); }
inline Vector4 SwizzXYX_(Vector3 V){ return MkVector4(V.x, V.y, V.x, 0); }
inline Vector4 SwizzXYYX(Vector3 V){ return MkVector4(V.x, V.y, V.y, V.x); }
inline Vector4 SwizzXYYY(Vector3 V){ return MkVector4(V.x, V.y, V.y, V.y); }
inline Vector4 SwizzXYYZ(Vector3 V){ return MkVector4(V.x, V.y, V.y, V.z); }
inline Vector4 SwizzXYY_(Vector3 V){ return MkVector4(V.x, V.y, V.y, 0); }
inline Vector4 SwizzXYZX(Vector3 V){ return MkVector4(V.x, V.y, V.z, V.x); }
inline Vector4 SwizzXYZY(Vector3 V){ return MkVector4(V.x, V.y, V.z, V.y); }
inline Vector4 SwizzXYZZ(Vector3 V){ return MkVector4(V.x, V.y, V.z, V.z); }
inline Vector4 SwizzXYZ_(Vector3 V){ return MkVector4(V.x, V.y, V.z, 0); }
inline Vector4 SwizzXY_X(Vector3 V){ return MkVector4(V.x, V.y, 0, V.x); }
inline Vector4 SwizzXY_Y(Vector3 V){ return MkVector4(V.x, V.y, 0, V.y); }
inline Vector4 SwizzXY_Z(Vector3 V){ return MkVector4(V.x, V.y, 0, V.z); }
inline Vector4 SwizzXY__(Vector3 V){ return MkVector4(V.x, V.y, 0, 0); }
inline Vector4 SwizzXZXX(Vector3 V){ return MkVector4(V.x, V.z, V.x, V.x); }
inline Vector4 SwizzXZXY(Vector3 V){ return MkVector4(V.x, V.z, V.x, V.y); }
inline Vector4 SwizzXZXZ(Vector3 V){ return MkVector4(V.x, V.z, V.x, V.z); }
inline Vector4 SwizzXZX_(Vector3 V){ return MkVector4(V.x, V.z, V.x, 0); }
inline Vector4 SwizzXZYX(Vector3 V){ return MkVector4(V.x, V.z, V.y, V.x); }
inline Vector4 SwizzXZYY(Vector3 V){ return MkVector4(V.x, V.z, V.y, V.y); }
inline Vector4 SwizzXZYZ(Vector3 V){ return MkVector4(V.x, V.z, V.y, V.z); }
inline Vector4 SwizzXZY_(Vector3 V){ return MkVector4(V.x, V.z, V.y, 0); }
inline Vector4 SwizzXZZX(Vector3 V){ return MkVector4(V.x, V.z, V.z, V.x); }
inline Vector4 SwizzXZZY(Vector3 V){ return MkVector4(V.x, V.z, V.z, V.y); }
inline Vector4 SwizzXZZZ(Vector3 V){ return MkVector4(V.x, V.z, V.z, V.z); }
inline Vector4 SwizzXZZ_(Vector3 V){ return MkVector4(V.x, V.z, V.z, 0); }
inline Vector4 SwizzXZ_X(Vector3 V){ return MkVector4(V.x, V.z, 0, V.x); }
inline Vector4 SwizzXZ_Y(Vector3 V){ return MkVector4(V.x, V.z, 0, V.y); }
inline Vector4 SwizzXZ_Z(Vector3 V){ return MkVector4(V.x, V.z, 0, V.z); }
inline Vector4 SwizzXZ__(Vector3 V){ return MkVector4(V.x, V.z, 0, 0); }
inline Vector4 SwizzX_XX(Vector3 V){ return MkVector4(V.x, 0, V.x, V.x); }
inline Vector4 SwizzX_XY(Vector3 V){ return MkVector4(V.x, 0, V.x, V.y); }
inline Vector4 SwizzX_XZ(Vector3 V){ return MkVector4(V.x, 0, V.x, V.z); }
inline Vector4 SwizzX_X_(Vector3 V){ return MkVector4(V.x, 0, V.x, 0); }
inline Vector4 SwizzX_YX(Vector3 V){ return MkVector4(V.x, 0, V.y, V.x); }
inline Vector4 SwizzX_YY(Vector3 V){ return MkVector4(V.x, 0, V.y, V.y); }
inline Vector4 SwizzX_YZ(Vector3 V){ return MkVector4(V.x, 0, V.y, V.z); }
inline Vector4 SwizzX_Y_(Vector3 V){ return MkVector4(V.x, 0, V.y, 0); }
inline Vector4 SwizzX_ZX(Vector3 V){ return MkVector4(V.x, 0, V.z, V.x); }
inline Vector4 SwizzX_ZY(Vector3 V){ return MkVector4(V.x, 0, V.z, V.y); }
inline Vector4 SwizzX_ZZ(Vector3 V){ return MkVector4(V.x, 0, V.z, V.z); }
inline Vector4 SwizzX_Z_(Vector3 V){ return MkVector4(V.x, 0, V.z, 0); }
inline Vector4 SwizzX__X(Vector3 V){ return MkVector4(V.x, 0, 0, V.x); }
inline Vector4 SwizzX__Y(Vector3 V){ return MkVector4(V.x, 0, 0, V.y); }
inline Vector4 SwizzX__Z(Vector3 V){ return MkVector4(V.x, 0, 0, V.z); }
inline Vector4 SwizzX___(Vector3 V){ return MkVector4(V.x, 0, 0, 0); }
inline Vector4 SwizzYXXX(Vector3 V){ return MkVector4(V.y, V.x, V.x, V.x); }
inline Vector4 SwizzYXXY(Vector3 V){ return MkVector4(V.y, V.x, V.x, V.y); }
inline Vector4 SwizzYXXZ(Vector3 V){ return MkVector4(V.y, V.x, V.x, V.z); }
inline Vector4 SwizzYXX_(Vector3 V){ return MkVector4(V.y, V.x, V.x, 0); }
inline Vector4 SwizzYXYX(Vector3 V){ return MkVector4(V.y, V.x, V.y, V.x); }
inline Vector4 SwizzYXYY(Vector3 V){ return MkVector4(V.y, V.x, V.y, V.y); }
inline Vector4 SwizzYXYZ(Vector3 V){ return MkVector4(V.y, V.x, V.y, V.z); }
inline Vector4 SwizzYXY_(Vector3 V){ return MkVector4(V.y, V.x, V.y, 0); }
inline Vector4 SwizzYXZX(Vector3 V){ return MkVector4(V.y, V.x, V.z, V.x); }
inline Vector4 SwizzYXZY(Vector3 V){ return MkVector4(V.y, V.x, V.z, V.y); }
inline Vector4 SwizzYXZZ(Vector3 V){ return MkVector4(V.y, V.x, V.z, V.z); }
inline Vector4 SwizzYXZ_(Vector3 V){ return MkVector4(V.y, V.x, V.z, 0); }
inline Vector4 SwizzYX_X(Vector3 V){ return MkVector4(V.y, V.x, 0, V.x); }
inline Vector4 SwizzYX_Y(Vector3 V){ return MkVector4(V.y, V.x, 0, V.y); }
inline Vector4 SwizzYX_Z(Vector3 V){ return MkVector4(V.y, V.x, 0, V.z); }
inline Vector4 SwizzYX__(Vector3 V){ return MkVector4(V.y, V.x, 0, 0); }
inline Vector4 SwizzYYXX(Vector3 V){ return MkVector4(V.y, V.y, V.x, V.x); }
inline Vector4 SwizzYYXY(Vector3 V){ return MkVector4(V.y, V.y, V.x, V.y); }
inline Vector4 SwizzYYXZ(Vector3 V){ return MkVector4(V.y, V.y, V.x, V.z); }
inline Vector4 SwizzYYX_(Vector3 V){ return MkVector4(V.y, V.y, V.x, 0); }
inline Vector4 SwizzYYYX(Vector3 V){ return MkVector4(V.y, V.y, V.y, V.x); }
inline Vector4 SwizzYYYY(Vector3 V){ return MkVector4(V.y, V.y, V.y, V.y); }
inline Vector4 SwizzYYYZ(Vector3 V){ return MkVector4(V.y, V.y, V.y, V.z); }
inline Vector4 SwizzYYY_(Vector3 V){ return MkVector4(V.y, V.y, V.y, 0); }
inline Vector4 SwizzYYZX(Vector3 V){ return MkVector4(V.y, V.y, V.z, V.x); }
inline Vector4 SwizzYYZY(Vector3 V){ return MkVector4(V.y, V.y, V.z, V.y); }
inline Vector4 SwizzYYZZ(Vector3 V){ return MkVector4(V.y, V.y, V.z, V.z); }
inline Vector4 SwizzYYZ_(Vector3 V){ return MkVector4(V.y, V.y, V.z, 0); }
inline Vector4 SwizzYY_X(Vector3 V){ return MkVector4(V.y, V.y, 0, V.x); }
inline Vector4 SwizzYY_Y(Vector3 V){ return MkVector4(V.y, V.y, 0, V.y); }
inline Vector4 SwizzYY_Z(Vector3 V){ return MkVector4(V.y, V.y, 0, V.z); }
inline Vector4 SwizzYY__(Vector3 V){ return MkVector4(V.y, V.y, 0, 0); }
inline Vector4 SwizzYZXX(Vector3 V){ return MkVector4(V.y, V.z, V.x, V.x); }
inline Vector4 SwizzYZXY(Vector3 V){ return MkVector4(V.y, V.z, V.x, V.y); }
inline Vector4 SwizzYZXZ(Vector3 V){ return MkVector4(V.y, V.z, V.x, V.z); }
inline Vector4 SwizzYZX_(Vector3 V){ return MkVector4(V.y, V.z, V.x, 0); }
inline Vector4 SwizzYZYX(Vector3 V){ return MkVector4(V.y, V.z, V.y, V.x); }
inline Vector4 SwizzYZYY(Vector3 V){ return MkVector4(V.y, V.z, V.y, V.y); }
inline Vector4 SwizzYZYZ(Vector3 V){ return MkVector4(V.y, V.z, V.y, V.z); }
inline Vector4 SwizzYZY_(Vector3 V){ return MkVector4(V.y, V.z, V.y, 0); }
inline Vector4 SwizzYZZX(Vector3 V){ return MkVector4(V.y, V.z, V.z, V.x); }
inline Vector4 SwizzYZZY(Vector3 V){ return MkVector4(V.y, V.z, V.z, V.y); }
inline Vector4 SwizzYZZZ(Vector3 V){ return MkVector4(V.y, V.z, V.z, V.z); }
inline Vector4 SwizzYZZ_(Vector3 V){ return MkVector4(V.y, V.z, V.z, 0); }
inline Vector4 SwizzYZ_X(Vector3 V){ return MkVector4(V.y, V.z, 0, V.x); }
inline Vector4 SwizzYZ_Y(Vector3 V){ return MkVector4(V.y, V.z, 0, V.y); }
inline Vector4 SwizzYZ_Z(Vector3 V){ return MkVector4(V.y, V.z, 0, V.z); }
inline Vector4 SwizzYZ__(Vector3 V){ return MkVector4(V.y, V.z, 0, 0); }
inline Vector4 SwizzY_XX(Vector3 V){ return MkVector4(V.y, 0, V.x, V.x); }
inline Vector4 SwizzY_XY(Vector3 V){ return MkVector4(V.y, 0, V.x, V.y); }
inline Vector4 SwizzY_XZ(Vector3 V){ return MkVector4(V.y, 0, V.x, V.z); }
inline Vector4 SwizzY_X_(Vector3 V){ return MkVector4(V.y, 0, V.x, 0); }
inline Vector4 SwizzY_YX(Vector3 V){ return MkVector4(V.y, 0, V.y, V.x); }
inline Vector4 SwizzY_YY(Vector3 V){ return MkVector4(V.y, 0, V.y, V.y); }
inline Vector4 SwizzY_YZ(Vector3 V){ return MkVector4(V.y, 0, V.y, V.z); }
inline Vector4 SwizzY_Y_(Vector3 V){ return MkVector4(V.y, 0, V.y, 0); }
inline Vector4 SwizzY_ZX(Vector3 V){ return MkVector4(V.y, 0, V.z, V.x); }
inline Vector4 SwizzY_ZY(Vector3 V){ return MkVector4(V.y, 0, V.z, V.y); }
inline Vector4 SwizzY_ZZ(Vector3 V){ return MkVector4(V.y, 0, V.z, V.z); }
inline Vector4 SwizzY_Z_(Vector3 V){ return MkVector4(V.y, 0, V.z, 0); }
inline Vector4 SwizzY__X(Vector3 V){ return MkVector4(V.y, 0, 0, V.x); }
inline Vector4 SwizzY__Y(Vector3 V){ return MkVector4(V.y, 0, 0, V.y); }
inline Vector4 SwizzY__Z(Vector3 V){ return MkVector4(V.y, 0, 0, V.z); }
inline Vector4 SwizzY___(Vector3 V){ return MkVector4(V.y, 0, 0, 0); }
inline Vector4 SwizzZXXX(Vector3 V){ return MkVector4(V.z, V.x, V.x, V.x); }
inline Vector4 SwizzZXXY(Vector3 V){ return MkVector4(V.z, V.x, V.x, V.y); }
inline Vector4 SwizzZXXZ(Vector3 V){ return MkVector4(V.z, V.x, V.x, V.z); }
inline Vector4 SwizzZXX_(Vector3 V){ return MkVector4(V.z, V.x, V.x, 0); }
inline Vector4 SwizzZXYX(Vector3 V){ return MkVector4(V.z, V.x, V.y, V.x); }
inline Vector4 SwizzZXYY(Vector3 V){ return MkVector4(V.z, V.x, V.y, V.y); }
inline Vector4 SwizzZXYZ(Vector3 V){ return MkVector4(V.z, V.x, V.y, V.z); }
inline Vector4 SwizzZXY_(Vector3 V){ return MkVector4(V.z, V.x, V.y, 0); }
inline Vector4 SwizzZXZX(Vector3 V){ return MkVector4(V.z, V.x, V.z, V.x); }
inline Vector4 SwizzZXZY(Vector3 V){ return MkVector4(V.z, V.x, V.z, V.y); }
inline Vector4 SwizzZXZZ(Vector3 V){ return MkVector4(V.z, V.x, V.z, V.z); }
inline Vector4 SwizzZXZ_(Vector3 V){ return MkVector4(V.z, V.x, V.z, 0); }
inline Vector4 SwizzZX_X(Vector3 V){ return MkVector4(V.z, V.x, 0, V.x); }
inline Vector4 SwizzZX_Y(Vector3 V){ return MkVector4(V.z, V.x, 0, V.y); }
inline Vector4 SwizzZX_Z(Vector3 V){ return MkVector4(V.z, V.x, 0, V.z); }
inline Vector4 SwizzZX__(Vector3 V){ return MkVector4(V.z, V.x, 0, 0); }
inline Vector4 SwizzZYXX(Vector3 V){ return MkVector4(V.z, V.y, V.x, V.x); }
inline Vector4 SwizzZYXY(Vector3 V){ return MkVector4(V.z, V.y, V.x, V.y); }
inline Vector4 SwizzZYXZ(Vector3 V){ return MkVector4(V.z, V.y, V.x, V.z); }
inline Vector4 SwizzZYX_(Vector3 V){ return MkVector4(V.z, V.y, V.x, 0); }
inline Vector4 SwizzZYYX(Vector3 V){ return MkVector4(V.z, V.y, V.y, V.x); }
inline Vector4 SwizzZYYY(Vector3 V){ return MkVector4(V.z, V.y, V.y, V.y); }
inline Vector4 SwizzZYYZ(Vector3 V){ return MkVector4(V.z, V.y, V.y, V.z); }
inline Vector4 SwizzZYY_(Vector3 V){ return MkVector4(V.z, V.y, V.y, 0); }
inline Vector4 SwizzZYZX(Vector3 V){ return MkVector4(V.z, V.y, V.z, V.x); }
inline Vector4 SwizzZYZY(Vector3 V){ return MkVector4(V.z, V.y, V.z, V.y); }
inline Vector4 SwizzZYZZ(Vector3 V){ return MkVector4(V.z, V.y, V.z, V.z); }
inline Vector4 SwizzZYZ_(Vector3 V){ return MkVector4(V.z, V.y, V.z, 0); }
inline Vector4 SwizzZY_X(Vector3 V){ return MkVector4(V.z, V.y, 0, V.x); }
inline Vector4 SwizzZY_Y(Vector3 V){ return MkVector4(V.z, V.y, 0, V.y); }
inline Vector4 SwizzZY_Z(Vector3 V){ return MkVector4(V.z, V.y, 0, V.z); }
inline Vector4 SwizzZY__(Vector3 V){ return MkVector4(V.z, V.y, 0, 0); }
inline Vector4 SwizzZZXX(Vector3 V){ return MkVector4(V.z, V.z, V.x, V.x); }
inline Vector4 SwizzZZXY(Vector3 V){ return MkVector4(V.z, V.z, V.x, V.y); }
inline Vector4 SwizzZZXZ(Vector3 V){ return MkVector4(V.z, V.z, V.x, V.z); }
inline Vector4 SwizzZZX_(Vector3 V){ return MkVector4(V.z, V.z, V.x, 0); }
inline Vector4 SwizzZZYX(Vector3 V){ return MkVector4(V.z, V.z, V.y, V.x); }
inline Vector4 SwizzZZYY(Vector3 V){ return MkVector4(V.z, V.z, V.y, V.y); }
inline Vector4 SwizzZZYZ(Vector3 V){ return MkVector4(V.z, V.z, V.y, V.z); }
inline Vector4 SwizzZZY_(Vector3 V){ return MkVector4(V.z, V.z, V.y, 0); }
inline Vector4 SwizzZZZX(Vector3 V){ return MkVector4(V.z, V.z, V.z, V.x); }
inline Vector4 SwizzZZZY(Vector3 V){ return MkVector4(V.z, V.z, V.z, V.y); }
inline Vector4 SwizzZZZZ(Vector3 V){ return MkVector4(V.z, V.z, V.z, V.z); }
inline Vector4 SwizzZZZ_(Vector3 V){ return MkVector4(V.z, V.z, V.z, 0); }
inline Vector4 SwizzZZ_X(Vector3 V){ return MkVector4(V.z, V.z, 0, V.x); }
inline Vector4 SwizzZZ_Y(Vector3 V){ return MkVector4(V.z, V.z, 0, V.y); }
inline Vector4 SwizzZZ_Z(Vector3 V){ return MkVector4(V.z, V.z, 0, V.z); }
inline Vector4 SwizzZZ__(Vector3 V){ return MkVector4(V.z, V.z, 0, 0); }
inline Vector4 SwizzZ_XX(Vector3 V){ return MkVector4(V.z, 0, V.x, V.x); }
inline Vector4 SwizzZ_XY(Vector3 V){ return MkVector4(V.z, 0, V.x, V.y); }
inline Vector4 SwizzZ_XZ(Vector3 V){ return MkVector4(V.z, 0, V.x, V.z); }
inline Vector4 SwizzZ_X_(Vector3 V){ return MkVector4(V.z, 0, V.x, 0); }
inline Vector4 SwizzZ_YX(Vector3 V){ return MkVector4(V.z, 0, V.y, V.x); }
inline Vector4 SwizzZ_YY(Vector3 V){ return MkVector4(V.z, 0, V.y, V.y); }
inline Vector4 SwizzZ_YZ(Vector3 V){ return MkVector4(V.z, 0, V.y, V.z); }
inline Vector4 SwizzZ_Y_(Vector3 V){ return MkVector4(V.z, 0, V.y, 0); }
inline Vector4 SwizzZ_ZX(Vector3 V){ return MkVector4(V.z, 0, V.z, V.x); }
inline Vector4 SwizzZ_ZY(Vector3 V){ return MkVector4(V.z, 0, V.z, V.y); }
inline Vector4 SwizzZ_ZZ(Vector3 V){ return MkVector4(V.z, 0, V.z, V.z); }
inline Vector4 SwizzZ_Z_(Vector3 V){ return MkVector4(V.z, 0, V.z, 0); }
inline Vector4 SwizzZ__X(Vector3 V){ return MkVector4(V.z, 0, 0, V.x); }
inline Vector4 SwizzZ__Y(Vector3 V){ return MkVector4(V.z, 0, 0, V.y); }
inline Vector4 SwizzZ__Z(Vector3 V){ return MkVector4(V.z, 0, 0, V.z); }
inline Vector4 SwizzZ___(Vector3 V){ return MkVector4(V.z, 0, 0, 0); }
inline Vector4 Swizz_XXX(Vector3 V){ return MkVector4(0, V.x, V.x, V.x); }
inline Vector4 Swizz_XXY(Vector3 V){ return MkVector4(0, V.x, V.x, V.y); }
inline Vector4 Swizz_XXZ(Vector3 V){ return MkVector4(0, V.x, V.x, V.z); }
inline Vector4 Swizz_XX_(Vector3 V){ return MkVector4(0, V.x, V.x, 0); }
inline Vector4 Swizz_XYX(Vector3 V){ return MkVector4(0, V.x, V.y, V.x); }
inline Vector4 Swizz_XYY(Vector3 V){ return MkVector4(0, V.x, V.y, V.y); }
inline Vector4 Swizz_XYZ(Vector3 V){ return MkVector4(0, V.x, V.y, V.z); }
inline Vector4 Swizz_XY_(Vector3 V){ return MkVector4(0, V.x, V.y, 0); }
inline Vector4 Swizz_XZX(Vector3 V){ return MkVector4(0, V.x, V.z, V.x); }
inline Vector4 Swizz_XZY(Vector3 V){ return MkVector4(0, V.x, V.z, V.y); }
inline Vector4 Swizz_XZZ(Vector3 V){ return MkVector4(0, V.x, V.z, V.z); }
inline Vector4 Swizz_XZ_(Vector3 V){ return MkVector4(0, V.x, V.z, 0); }
inline Vector4 Swizz_X_X(Vector3 V){ return MkVector4(0, V.x, 0, V.x); }
inline Vector4 Swizz_X_Y(Vector3 V){ return MkVector4(0, V.x, 0, V.y); }
inline Vector4 Swizz_X_Z(Vector3 V){ return MkVector4(0, V.x, 0, V.z); }
inline Vector4 Swizz_X__(Vector3 V){ return MkVector4(0, V.x, 0, 0); }
inline Vector4 Swizz_YXX(Vector3 V){ return MkVector4(0, V.y, V.x, V.x); }
inline Vector4 Swizz_YXY(Vector3 V){ return MkVector4(0, V.y, V.x, V.y); }
inline Vector4 Swizz_YXZ(Vector3 V){ return MkVector4(0, V.y, V.x, V.z); }
inline Vector4 Swizz_YX_(Vector3 V){ return MkVector4(0, V.y, V.x, 0); }
inline Vector4 Swizz_YYX(Vector3 V){ return MkVector4(0, V.y, V.y, V.x); }
inline Vector4 Swizz_YYY(Vector3 V){ return MkVector4(0, V.y, V.y, V.y); }
inline Vector4 Swizz_YYZ(Vector3 V){ return MkVector4(0, V.y, V.y, V.z); }
inline Vector4 Swizz_YY_(Vector3 V){ return MkVector4(0, V.y, V.y, 0); }
inline Vector4 Swizz_YZX(Vector3 V){ return MkVector4(0, V.y, V.z, V.x); }
inline Vector4 Swizz_YZY(Vector3 V){ return MkVector4(0, V.y, V.z, V.y); }
inline Vector4 Swizz_YZZ(Vector3 V){ return MkVector4(0, V.y, V.z, V.z); }
inline Vector4 Swizz_YZ_(Vector3 V){ return MkVector4(0, V.y, V.z, 0); }
inline Vector4 Swizz_Y_X(Vector3 V){ return MkVector4(0, V.y, 0, V.x); }
inline Vector4 Swizz_Y_Y(Vector3 V){ return MkVector4(0, V.y, 0, V.y); }
inline Vector4 Swizz_Y_Z(Vector3 V){ return MkVector4(0, V.y, 0, V.z); }
inline Vector4 Swizz_Y__(Vector3 V){ return MkVector4(0, V.y, 0, 0); }
inline Vector4 Swizz_ZXX(Vector3 V){ return MkVector4(0, V.z, V.x, V.x); }
inline Vector4 Swizz_ZXY(Vector3 V){ return MkVector4(0, V.z, V.x, V.y); }
inline Vector4 Swizz_ZXZ(Vector3 V){ return MkVector4(0, V.z, V.x, V.z); }
inline Vector4 Swizz_ZX_(Vector3 V){ return MkVector4(0, V.z, V.x, 0); }
inline Vector4 Swizz_ZYX(Vector3 V){ return MkVector4(0, V.z, V.y, V.x); }
inline Vector4 Swizz_ZYY(Vector3 V){ return MkVector4(0, V.z, V.y, V.y); }
inline Vector4 Swizz_ZYZ(Vector3 V){ return MkVector4(0, V.z, V.y, V.z); }
inline Vector4 Swizz_ZY_(Vector3 V){ return MkVector4(0, V.z, V.y, 0); }
inline Vector4 Swizz_ZZX(Vector3 V){ return MkVector4(0, V.z, V.z, V.x); }
inline Vector4 Swizz_ZZY(Vector3 V){ return MkVector4(0, V.z, V.z, V.y); }
inline Vector4 Swizz_ZZZ(Vector3 V){ return MkVector4(0, V.z, V.z, V.z); }
inline Vector4 Swizz_ZZ_(Vector3 V){ return MkVector4(0, V.z, V.z, 0); }
inline Vector4 Swizz_Z_X(Vector3 V){ return MkVector4(0, V.z, 0, V.x); }
inline Vector4 Swizz_Z_Y(Vector3 V){ return MkVector4(0, V.z, 0, V.y); }
inline Vector4 Swizz_Z_Z(Vector3 V){ return MkVector4(0, V.z, 0, V.z); }
inline Vector4 Swizz_Z__(Vector3 V){ return MkVector4(0, V.z, 0, 0); }
inline Vector4 Swizz__XX(Vector3 V){ return MkVector4(0, 0, V.x, V.x); }
inline Vector4 Swizz__XY(Vector3 V){ return MkVector4(0, 0, V.x, V.y); }
inline Vector4 Swizz__XZ(Vector3 V){ return MkVector4(0, 0, V.x, V.z); }
inline Vector4 Swizz__X_(Vector3 V){ return MkVector4(0, 0, V.x, 0); }
inline Vector4 Swizz__YX(Vector3 V){ return MkVector4(0, 0, V.y, V.x); }
inline Vector4 Swizz__YY(Vector3 V){ return MkVector4(0, 0, V.y, V.y); }
inline Vector4 Swizz__YZ(Vector3 V){ return MkVector4(0, 0, V.y, V.z); }
inline Vector4 Swizz__Y_(Vector3 V){ return MkVector4(0, 0, V.y, 0); }
inline Vector4 Swizz__ZX(Vector3 V){ return MkVector4(0, 0, V.z, V.x); }
inline Vector4 Swizz__ZY(Vector3 V){ return MkVector4(0, 0, V.z, V.y); }
inline Vector4 Swizz__ZZ(Vector3 V){ return MkVector4(0, 0, V.z, V.z); }
inline Vector4 Swizz__Z_(Vector3 V){ return MkVector4(0, 0, V.z, 0); }
inline Vector4 Swizz___X(Vector3 V){ return MkVector4(0, 0, 0, V.x); }
inline Vector4 Swizz___Y(Vector3 V){ return MkVector4(0, 0, 0, V.y); }
inline Vector4 Swizz___Z(Vector3 V){ return MkVector4(0, 0, 0, V.z); }
inline Vector2 SwizzXX(Vector4 V){ return MkVector2(V.x, V.x); }
inline Vector2 SwizzXY(Vector4 V){ return MkVector2(V.x, V.y); }
inline Vector2 SwizzXZ(Vector4 V){ return MkVector2(V.x, V.z); }
inline Vector2 SwizzXW(Vector4 V){ return MkVector2(V.x, V.w); }
inline Vector2 SwizzX_(Vector4 V){ return MkVector2(V.x, 0); }
inline Vector2 SwizzYX(Vector4 V){ return MkVector2(V.y, V.x); }
inline Vector2 SwizzYY(Vector4 V){ return MkVector2(V.y, V.y); }
inline Vector2 SwizzYZ(Vector4 V){ return MkVector2(V.y, V.z); }
inline Vector2 SwizzYW(Vector4 V){ return MkVector2(V.y, V.w); }
inline Vector2 SwizzY_(Vector4 V){ return MkVector2(V.y, 0); }
inline Vector2 SwizzZX(Vector4 V){ return MkVector2(V.z, V.x); }
inline Vector2 SwizzZY(Vector4 V){ return MkVector2(V.z, V.y); }
inline Vector2 SwizzZZ(Vector4 V){ return MkVector2(V.z, V.z); }
inline Vector2 SwizzZW(Vector4 V){ return MkVector2(V.z, V.w); }
inline Vector2 SwizzZ_(Vector4 V){ return MkVector2(V.z, 0); }
inline Vector2 SwizzWX(Vector4 V){ return MkVector2(V.w, V.x); }
inline Vector2 SwizzWY(Vector4 V){ return MkVector2(V.w, V.y); }
inline Vector2 SwizzWZ(Vector4 V){ return MkVector2(V.w, V.z); }
inline Vector2 SwizzWW(Vector4 V){ return MkVector2(V.w, V.w); }
inline Vector2 SwizzW_(Vector4 V){ return MkVector2(V.w, 0); }
inline Vector2 Swizz_X(Vector4 V){ return MkVector2(0, V.x); }
inline Vector2 Swizz_Y(Vector4 V){ return MkVector2(0, V.y); }
inline Vector2 Swizz_Z(Vector4 V){ return MkVector2(0, V.z); }
inline Vector2 Swizz_W(Vector4 V){ return MkVector2(0, V.w); }
inline Vector3 SwizzXXX(Vector4 V){ return MkVector3(V.x, V.x, V.x); }
inline Vector3 SwizzXXY(Vector4 V){ return MkVector3(V.x, V.x, V.y); }
inline Vector3 SwizzXXZ(Vector4 V){ return MkVector3(V.x, V.x, V.z); }
inline Vector3 SwizzXXW(Vector4 V){ return MkVector3(V.x, V.x, V.w); }
inline Vector3 SwizzXX_(Vector4 V){ return MkVector3(V.x, V.x, 0); }
inline Vector3 SwizzXYX(Vector4 V){ return MkVector3(V.x, V.y, V.x); }
inline Vector3 SwizzXYY(Vector4 V){ return MkVector3(V.x, V.y, V.y); }
inline Vector3 SwizzXYZ(Vector4 V){ return MkVector3(V.x, V.y, V.z); }
inline Vector3 SwizzXYW(Vector4 V){ return MkVector3(V.x, V.y, V.w); }
inline Vector3 SwizzXY_(Vector4 V){ return MkVector3(V.x, V.y, 0); }
inline Vector3 SwizzXZX(Vector4 V){ return MkVector3(V.x, V.z, V.x); }
inline Vector3 SwizzXZY(Vector4 V){ return MkVector3(V.x, V.z, V.y); }
inline Vector3 SwizzXZZ(Vector4 V){ return MkVector3(V.x, V.z, V.z); }
inline Vector3 SwizzXZW(Vector4 V){ return MkVector3(V.x, V.z, V.w); }
inline Vector3 SwizzXZ_(Vector4 V){ return MkVector3(V.x, V.z, 0); }
inline Vector3 SwizzXWX(Vector4 V){ return MkVector3(V.x, V.w, V.x); }
inline Vector3 SwizzXWY(Vector4 V){ return MkVector3(V.x, V.w, V.y); }
inline Vector3 SwizzXWZ(Vector4 V){ return MkVector3(V.x, V.w, V.z); }
inline Vector3 SwizzXWW(Vector4 V){ return MkVector3(V.x, V.w, V.w); }
inline Vector3 SwizzXW_(Vector4 V){ return MkVector3(V.x, V.w, 0); }
inline Vector3 SwizzX_X(Vector4 V){ return MkVector3(V.x, 0, V.x); }
inline Vector3 SwizzX_Y(Vector4 V){ return MkVector3(V.x, 0, V.y); }
inline Vector3 SwizzX_Z(Vector4 V){ return MkVector3(V.x, 0, V.z); }
inline Vector3 SwizzX_W(Vector4 V){ return MkVector3(V.x, 0, V.w); }
inline Vector3 SwizzX__(Vector4 V){ return MkVector3(V.x, 0, 0); }
inline Vector3 SwizzYXX(Vector4 V){ return MkVector3(V.y, V.x, V.x); }
inline Vector3 SwizzYXY(Vector4 V){ return MkVector3(V.y, V.x, V.y); }
inline Vector3 SwizzYXZ(Vector4 V){ return MkVector3(V.y, V.x, V.z); }
inline Vector3 SwizzYXW(Vector4 V){ return MkVector3(V.y, V.x, V.w); }
inline Vector3 SwizzYX_(Vector4 V){ return MkVector3(V.y, V.x, 0); }
inline Vector3 SwizzYYX(Vector4 V){ return MkVector3(V.y, V.y, V.x); }
inline Vector3 SwizzYYY(Vector4 V){ return MkVector3(V.y, V.y, V.y); }
inline Vector3 SwizzYYZ(Vector4 V){ return MkVector3(V.y, V.y, V.z); }
inline Vector3 SwizzYYW(Vector4 V){ return MkVector3(V.y, V.y, V.w); }
inline Vector3 SwizzYY_(Vector4 V){ return MkVector3(V.y, V.y, 0); }
inline Vector3 SwizzYZX(Vector4 V){ return MkVector3(V.y, V.z, V.x); }
inline Vector3 SwizzYZY(Vector4 V){ return MkVector3(V.y, V.z, V.y); }
inline Vector3 SwizzYZZ(Vector4 V){ return MkVector3(V.y, V.z, V.z); }
inline Vector3 SwizzYZW(Vector4 V){ return MkVector3(V.y, V.z, V.w); }
inline Vector3 SwizzYZ_(Vector4 V){ return MkVector3(V.y, V.z, 0); }
inline Vector3 SwizzYWX(Vector4 V){ return MkVector3(V.y, V.w, V.x); }
inline Vector3 SwizzYWY(Vector4 V){ return MkVector3(V.y, V.w, V.y); }
inline Vector3 SwizzYWZ(Vector4 V){ return MkVector3(V.y, V.w, V.z); }
inline Vector3 SwizzYWW(Vector4 V){ return MkVector3(V.y, V.w, V.w); }
inline Vector3 SwizzYW_(Vector4 V){ return MkVector3(V.y, V.w, 0); }
inline Vector3 SwizzY_X(Vector4 V){ return MkVector3(V.y, 0, V.x); }
inline Vector3 SwizzY_Y(Vector4 V){ return MkVector3(V.y, 0, V.y); }
inline Vector3 SwizzY_Z(Vector4 V){ return MkVector3(V.y, 0, V.z); }
inline Vector3 SwizzY_W(Vector4 V){ return MkVector3(V.y, 0, V.w); }
inline Vector3 SwizzY__(Vector4 V){ return MkVector3(V.y, 0, 0); }
inline Vector3 SwizzZXX(Vector4 V){ return MkVector3(V.z, V.x, V.x); }
inline Vector3 SwizzZXY(Vector4 V){ return MkVector3(V.z, V.x, V.y); }
inline Vector3 SwizzZXZ(Vector4 V){ return MkVector3(V.z, V.x, V.z); }
inline Vector3 SwizzZXW(Vector4 V){ return MkVector3(V.z, V.x, V.w); }
inline Vector3 SwizzZX_(Vector4 V){ return MkVector3(V.z, V.x, 0); }
inline Vector3 SwizzZYX(Vector4 V){ return MkVector3(V.z, V.y, V.x); }
inline Vector3 SwizzZYY(Vector4 V){ return MkVector3(V.z, V.y, V.y); }
inline Vector3 SwizzZYZ(Vector4 V){ return MkVector3(V.z, V.y, V.z); }
inline Vector3 SwizzZYW(Vector4 V){ return MkVector3(V.z, V.y, V.w); }
inline Vector3 SwizzZY_(Vector4 V){ return MkVector3(V.z, V.y, 0); }
inline Vector3 SwizzZZX(Vector4 V){ return MkVector3(V.z, V.z, V.x); }
inline Vector3 SwizzZZY(Vector4 V){ return MkVector3(V.z, V.z, V.y); }
inline Vector3 SwizzZZZ(Vector4 V){ return MkVector3(V.z, V.z, V.z); }
inline Vector3 SwizzZZW(Vector4 V){ return MkVector3(V.z, V.z, V.w); }
inline Vector3 SwizzZZ_(Vector4 V){ return MkVector3(V.z, V.z, 0); }
inline Vector3 SwizzZWX(Vector4 V){ return MkVector3(V.z, V.w, V.x); }
inline Vector3 SwizzZWY(Vector4 V){ return MkVector3(V.z, V.w, V.y); }
inline Vector3 SwizzZWZ(Vector4 V){ return MkVector3(V.z, V.w, V.z); }
inline Vector3 SwizzZWW(Vector4 V){ return MkVector3(V.z, V.w, V.w); }
inline Vector3 SwizzZW_(Vector4 V){ return MkVector3(V.z, V.w, 0); }
inline Vector3 SwizzZ_X(Vector4 V){ return MkVector3(V.z, 0, V.x); }
inline Vector3 SwizzZ_Y(Vector4 V){ return MkVector3(V.z, 0, V.y); }
inline Vector3 SwizzZ_Z(Vector4 V){ return MkVector3(V.z, 0, V.z); }
inline Vector3 SwizzZ_W(Vector4 V){ return MkVector3(V.z, 0, V.w); }
inline Vector3 SwizzZ__(Vector4 V){ return MkVector3(V.z, 0, 0); }
inline Vector3 SwizzWXX(Vector4 V){ return MkVector3(V.w, V.x, V.x); }
inline Vector3 SwizzWXY(Vector4 V){ return MkVector3(V.w, V.x, V.y); }
inline Vector3 SwizzWXZ(Vector4 V){ return MkVector3(V.w, V.x, V.z); }
inline Vector3 SwizzWXW(Vector4 V){ return MkVector3(V.w, V.x, V.w); }
inline Vector3 SwizzWX_(Vector4 V){ return MkVector3(V.w, V.x, 0); }
inline Vector3 SwizzWYX(Vector4 V){ return MkVector3(V.w, V.y, V.x); }
inline Vector3 SwizzWYY(Vector4 V){ return MkVector3(V.w, V.y, V.y); }
inline Vector3 SwizzWYZ(Vector4 V){ return MkVector3(V.w, V.y, V.z); }
inline Vector3 SwizzWYW(Vector4 V){ return MkVector3(V.w, V.y, V.w); }
inline Vector3 SwizzWY_(Vector4 V){ return MkVector3(V.w, V.y, 0); }
inline Vector3 SwizzWZX(Vector4 V){ return MkVector3(V.w, V.z, V.x); }
inline Vector3 SwizzWZY(Vector4 V){ return MkVector3(V.w, V.z, V.y); }
inline Vector3 SwizzWZZ(Vector4 V){ return MkVector3(V.w, V.z, V.z); }
inline Vector3 SwizzWZW(Vector4 V){ return MkVector3(V.w, V.z, V.w); }
inline Vector3 SwizzWZ_(Vector4 V){ return MkVector3(V.w, V.z, 0); }
inline Vector3 SwizzWWX(Vector4 V){ return MkVector3(V.w, V.w, V.x); }
inline Vector3 SwizzWWY(Vector4 V){ return MkVector3(V.w, V.w, V.y); }
inline Vector3 SwizzWWZ(Vector4 V){ return MkVector3(V.w, V.w, V.z); }
inline Vector3 SwizzWWW(Vector4 V){ return MkVector3(V.w, V.w, V.w); }
inline Vector3 SwizzWW_(Vector4 V){ return MkVector3(V.w, V.w, 0); }
inline Vector3 SwizzW_X(Vector4 V){ return MkVector3(V.w, 0, V.x); }
inline Vector3 SwizzW_Y(Vector4 V){ return MkVector3(V.w, 0, V.y); }
inline Vector3 SwizzW_Z(Vector4 V){ return MkVector3(V.w, 0, V.z); }
inline Vector3 SwizzW_W(Vector4 V){ return MkVector3(V.w, 0, V.w); }
inline Vector3 SwizzW__(Vector4 V){ return MkVector3(V.w, 0, 0); }
inline Vector3 Swizz_XX(Vector4 V){ return MkVector3(0, V.x, V.x); }
inline Vector3 Swizz_XY(Vector4 V){ return MkVector3(0, V.x, V.y); }
inline Vector3 Swizz_XZ(Vector4 V){ return MkVector3(0, V.x, V.z); }
inline Vector3 Swizz_XW(Vector4 V){ return MkVector3(0, V.x, V.w); }
inline Vector3 Swizz_X_(Vector4 V){ return MkVector3(0, V.x, 0); }
inline Vector3 Swizz_YX(Vector4 V){ return MkVector3(0, V.y, V.x); }
inline Vector3 Swizz_YY(Vector4 V){ return MkVector3(0, V.y, V.y); }
inline Vector3 Swizz_YZ(Vector4 V){ return MkVector3(0, V.y, V.z); }
inline Vector3 Swizz_YW(Vector4 V){ return MkVector3(0, V.y, V.w); }
inline Vector3 Swizz_Y_(Vector4 V){ return MkVector3(0, V.y, 0); }
inline Vector3 Swizz_ZX(Vector4 V){ return MkVector3(0, V.z, V.x); }
inline Vector3 Swizz_ZY(Vector4 V){ return MkVector3(0, V.z, V.y); }
inline Vector3 Swizz_ZZ(Vector4 V){ return MkVector3(0, V.z, V.z); }
inline Vector3 Swizz_ZW(Vector4 V){ return MkVector3(0, V.z, V.w); }
inline Vector3 Swizz_Z_(Vector4 V){ return MkVector3(0, V.z, 0); }
inline Vector3 Swizz_WX(Vector4 V){ return MkVector3(0, V.w, V.x); }
inline Vector3 Swizz_WY(Vector4 V){ return MkVector3(0, V.w, V.y); }
inline Vector3 Swizz_WZ(Vector4 V){ return MkVector3(0, V.w, V.z); }
inline Vector3 Swizz_WW(Vector4 V){ return MkVector3(0, V.w, V.w); }
inline Vector3 Swizz_W_(Vector4 V){ return MkVector3(0, V.w, 0); }
inline Vector3 Swizz__X(Vector4 V){ return MkVector3(0, 0, V.x); }
inline Vector3 Swizz__Y(Vector4 V){ return MkVector3(0, 0, V.y); }
inline Vector3 Swizz__Z(Vector4 V){ return MkVector3(0, 0, V.z); }
inline Vector3 Swizz__W(Vector4 V){ return MkVector3(0, 0, V.w); }
inline Vector4 SwizzXXXX(Vector4 V){ return MkVector4(V.x, V.x, V.x, V.x); }
inline Vector4 SwizzXXXY(Vector4 V){ return MkVector4(V.x, V.x, V.x, V.y); }
inline Vector4 SwizzXXXZ(Vector4 V){ return MkVector4(V.x, V.x, V.x, V.z); }
inline Vector4 SwizzXXXW(Vector4 V){ return MkVector4(V.x, V.x, V.x, V.w); }
inline Vector4 SwizzXXX_(Vector4 V){ return MkVector4(V.x, V.x, V.x, 0); }
inline Vector4 SwizzXXYX(Vector4 V){ return MkVector4(V.x, V.x, V.y, V.x); }
inline Vector4 SwizzXXYY(Vector4 V){ return MkVector4(V.x, V.x, V.y, V.y); }
inline Vector4 SwizzXXYZ(Vector4 V){ return MkVector4(V.x, V.x, V.y, V.z); }
inline Vector4 SwizzXXYW(Vector4 V){ return MkVector4(V.x, V.x, V.y, V.w); }
inline Vector4 SwizzXXY_(Vector4 V){ return MkVector4(V.x, V.x, V.y, 0); }
inline Vector4 SwizzXXZX(Vector4 V){ return MkVector4(V.x, V.x, V.z, V.x); }
inline Vector4 SwizzXXZY(Vector4 V){ return MkVector4(V.x, V.x, V.z, V.y); }
inline Vector4 SwizzXXZZ(Vector4 V){ return MkVector4(V.x, V.x, V.z, V.z); }
inline Vector4 SwizzXXZW(Vector4 V){ return MkVector4(V.x, V.x, V.z, V.w); }
inline Vector4 SwizzXXZ_(Vector4 V){ return MkVector4(V.x, V.x, V.z, 0); }
inline Vector4 SwizzXXWX(Vector4 V){ return MkVector4(V.x, V.x, V.w, V.x); }
inline Vector4 SwizzXXWY(Vector4 V){ return MkVector4(V.x, V.x, V.w, V.y); }
inline Vector4 SwizzXXWZ(Vector4 V){ return MkVector4(V.x, V.x, V.w, V.z); }
inline Vector4 SwizzXXWW(Vector4 V){ return MkVector4(V.x, V.x, V.w, V.w); }
inline Vector4 SwizzXXW_(Vector4 V){ return MkVector4(V.x, V.x, V.w, 0); }
inline Vector4 SwizzXX_X(Vector4 V){ return MkVector4(V.x, V.x, 0, V.x); }
inline Vector4 SwizzXX_Y(Vector4 V){ return MkVector4(V.x, V.x, 0, V.y); }
inline Vector4 SwizzXX_Z(Vector4 V){ return MkVector4(V.x, V.x, 0, V.z); }
inline Vector4 SwizzXX_W(Vector4 V){ return MkVector4(V.x, V.x, 0, V.w); }
inline Vector4 SwizzXX__(Vector4 V){ return MkVector4(V.x, V.x, 0, 0); }
inline Vector4 SwizzXYXX(Vector4 V){ return MkVector4(V.x, V.y, V.x, V.x); }
inline Vector4 SwizzXYXY(Vector4 V){ return MkVector4(V.x, V.y, V.x, V.y); }
inline Vector4 SwizzXYXZ(Vector4 V){ return MkVector4(V.x, V.y, V.x, V.z); }
inline Vector4 SwizzXYXW(Vector4 V){ return MkVector4(V.x, V.y, V.x, V.w); }
inline Vector4 SwizzXYX_(Vector4 V){ return MkVector4(V.x, V.y, V.x, 0); }
inline Vector4 SwizzXYYX(Vector4 V){ return MkVector4(V.x, V.y, V.y, V.x); }
inline Vector4 SwizzXYYY(Vector4 V){ return MkVector4(V.x, V.y, V.y, V.y); }
inline Vector4 SwizzXYYZ(Vector4 V){ return MkVector4(V.x, V.y, V.y, V.z); }
inline Vector4 SwizzXYYW(Vector4 V){ return MkVector4(V.x, V.y, V.y, V.w); }
inline Vector4 SwizzXYY_(Vector4 V){ return MkVector4(V.x, V.y, V.y, 0); }
inline Vector4 SwizzXYZX(Vector4 V){ return MkVector4(V.x, V.y, V.z, V.x); }
inline Vector4 SwizzXYZY(Vector4 V){ return MkVector4(V.x, V.y, V.z, V.y); }
inline Vector4 SwizzXYZZ(Vector4 V){ return MkVector4(V.x, V.y, V.z, V.z); }
inline Vector4 SwizzXYZW(Vector4 V){ return MkVector4(V.x, V.y, V.z, V.w); }
inline Vector4 SwizzXYZ_(Vector4 V){ return MkVector4(V.x, V.y, V.z, 0); }
inline Vector4 SwizzXYWX(Vector4 V){ return MkVector4(V.x, V.y, V.w, V.x); }
inline Vector4 SwizzXYWY(Vector4 V){ return MkVector4(V.x, V.y, V.w, V.y); }
inline Vector4 SwizzXYWZ(Vector4 V){ return MkVector4(V.x, V.y, V.w, V.z); }
inline Vector4 SwizzXYWW(Vector4 V){ return MkVector4(V.x, V.y, V.w, V.w); }
inline Vector4 SwizzXYW_(Vector4 V){ return MkVector4(V.x, V.y, V.w, 0); }
inline Vector4 SwizzXY_X(Vector4 V){ return MkVector4(V.x, V.y, 0, V.x); }
inline Vector4 SwizzXY_Y(Vector4 V){ return MkVector4(V.x, V.y, 0, V.y); }
inline Vector4 SwizzXY_Z(Vector4 V){ return MkVector4(V.x, V.y, 0, V.z); }
inline Vector4 SwizzXY_W(Vector4 V){ return MkVector4(V.x, V.y, 0, V.w); }
inline Vector4 SwizzXY__(Vector4 V){ return MkVector4(V.x, V.y, 0, 0); }
inline Vector4 SwizzXZXX(Vector4 V){ return MkVector4(V.x, V.z, V.x, V.x); }
inline Vector4 SwizzXZXY(Vector4 V){ return MkVector4(V.x, V.z, V.x, V.y); }
inline Vector4 SwizzXZXZ(Vector4 V){ return MkVector4(V.x, V.z, V.x, V.z); }
inline Vector4 SwizzXZXW(Vector4 V){ return MkVector4(V.x, V.z, V.x, V.w); }
inline Vector4 SwizzXZX_(Vector4 V){ return MkVector4(V.x, V.z, V.x, 0); }
inline Vector4 SwizzXZYX(Vector4 V){ return MkVector4(V.x, V.z, V.y, V.x); }
inline Vector4 SwizzXZYY(Vector4 V){ return MkVector4(V.x, V.z, V.y, V.y); }
inline Vector4 SwizzXZYZ(Vector4 V){ return MkVector4(V.x, V.z, V.y, V.z); }
inline Vector4 SwizzXZYW(Vector4 V){ return MkVector4(V.x, V.z, V.y, V.w); }
inline Vector4 SwizzXZY_(Vector4 V){ return MkVector4(V.x, V.z, V.y, 0); }
inline Vector4 SwizzXZZX(Vector4 V){ return MkVector4(V.x, V.z, V.z, V.x); }
inline Vector4 SwizzXZZY(Vector4 V){ return MkVector4(V.x, V.z, V.z, V.y); }
inline Vector4 SwizzXZZZ(Vector4 V){ return MkVector4(V.x, V.z, V.z, V.z); }
inline Vector4 SwizzXZZW(Vector4 V){ return MkVector4(V.x, V.z, V.z, V.w); }
inline Vector4 SwizzXZZ_(Vector4 V){ return MkVector4(V.x, V.z, V.z, 0); }
inline Vector4 SwizzXZWX(Vector4 V){ return MkVector4(V.x, V.z, V.w, V.x); }
inline Vector4 SwizzXZWY(Vector4 V){ return MkVector4(V.x, V.z, V.w, V.y); }
inline Vector4 SwizzXZWZ(Vector4 V){ return MkVector4(V.x, V.z, V.w, V.z); }
inline Vector4 SwizzXZWW(Vector4 V){ return MkVector4(V.x, V.z, V.w, V.w); }
inline Vector4 SwizzXZW_(Vector4 V){ return MkVector4(V.x, V.z, V.w, 0); }
inline Vector4 SwizzXZ_X(Vector4 V){ return MkVector4(V.x, V.z, 0, V.x); }
inline Vector4 SwizzXZ_Y(Vector4 V){ return MkVector4(V.x, V.z, 0, V.y); }
inline Vector4 SwizzXZ_Z(Vector4 V){ return MkVector4(V.x, V.z, 0, V.z); }
inline Vector4 SwizzXZ_W(Vector4 V){ return MkVector4(V.x, V.z, 0, V.w); }
inline Vector4 SwizzXZ__(Vector4 V){ return MkVector4(V.x, V.z, 0, 0); }
inline Vector4 SwizzXWXX(Vector4 V){ return MkVector4(V.x, V.w, V.x, V.x); }
inline Vector4 SwizzXWXY(Vector4 V){ return MkVector4(V.x, V.w, V.x, V.y); }
inline Vector4 SwizzXWXZ(Vector4 V){ return MkVector4(V.x, V.w, V.x, V.z); }
inline Vector4 SwizzXWXW(Vector4 V){ return MkVector4(V.x, V.w, V.x, V.w); }
inline Vector4 SwizzXWX_(Vector4 V){ return MkVector4(V.x, V.w, V.x, 0); }
inline Vector4 SwizzXWYX(Vector4 V){ return MkVector4(V.x, V.w, V.y, V.x); }
inline Vector4 SwizzXWYY(Vector4 V){ return MkVector4(V.x, V.w, V.y, V.y); }
inline Vector4 SwizzXWYZ(Vector4 V){ return MkVector4(V.x, V.w, V.y, V.z); }
inline Vector4 SwizzXWYW(Vector4 V){ return MkVector4(V.x, V.w, V.y, V.w); }
inline Vector4 SwizzXWY_(Vector4 V){ return MkVector4(V.x, V.w, V.y, 0); }
inline Vector4 SwizzXWZX(Vector4 V){ return MkVector4(V.x, V.w, V.z, V.x); }
inline Vector4 SwizzXWZY(Vector4 V){ return MkVector4(V.x, V.w, V.z, V.y); }
inline Vector4 SwizzXWZZ(Vector4 V){ return MkVector4(V.x, V.w, V.z, V.z); }
inline Vector4 SwizzXWZW(Vector4 V){ return MkVector4(V.x, V.w, V.z, V.w); }
inline Vector4 SwizzXWZ_(Vector4 V){ return MkVector4(V.x, V.w, V.z, 0); }
inline Vector4 SwizzXWWX(Vector4 V){ return MkVector4(V.x, V.w, V.w, V.x); }
inline Vector4 SwizzXWWY(Vector4 V){ return MkVector4(V.x, V.w, V.w, V.y); }
inline Vector4 SwizzXWWZ(Vector4 V){ return MkVector4(V.x, V.w, V.w, V.z); }
inline Vector4 SwizzXWWW(Vector4 V){ return MkVector4(V.x, V.w, V.w, V.w); }
inline Vector4 SwizzXWW_(Vector4 V){ return MkVector4(V.x, V.w, V.w, 0); }
inline Vector4 SwizzXW_X(Vector4 V){ return MkVector4(V.x, V.w, 0, V.x); }
inline Vector4 SwizzXW_Y(Vector4 V){ return MkVector4(V.x, V.w, 0, V.y); }
inline Vector4 SwizzXW_Z(Vector4 V){ return MkVector4(V.x, V.w, 0, V.z); }
inline Vector4 SwizzXW_W(Vector4 V){ return MkVector4(V.x, V.w, 0, V.w); }
inline Vector4 SwizzXW__(Vector4 V){ return MkVector4(V.x, V.w, 0, 0); }
inline Vector4 SwizzX_XX(Vector4 V){ return MkVector4(V.x, 0, V.x, V.x); }
inline Vector4 SwizzX_XY(Vector4 V){ return MkVector4(V.x, 0, V.x, V.y); }
inline Vector4 SwizzX_XZ(Vector4 V){ return MkVector4(V.x, 0, V.x, V.z); }
inline Vector4 SwizzX_XW(Vector4 V){ return MkVector4(V.x, 0, V.x, V.w); }
inline Vector4 SwizzX_X_(Vector4 V){ return MkVector4(V.x, 0, V.x, 0); }
inline Vector4 SwizzX_YX(Vector4 V){ return MkVector4(V.x, 0, V.y, V.x); }
inline Vector4 SwizzX_YY(Vector4 V){ return MkVector4(V.x, 0, V.y, V.y); }
inline Vector4 SwizzX_YZ(Vector4 V){ return MkVector4(V.x, 0, V.y, V.z); }
inline Vector4 SwizzX_YW(Vector4 V){ return MkVector4(V.x, 0, V.y, V.w); }
inline Vector4 SwizzX_Y_(Vector4 V){ return MkVector4(V.x, 0, V.y, 0); }
inline Vector4 SwizzX_ZX(Vector4 V){ return MkVector4(V.x, 0, V.z, V.x); }
inline Vector4 SwizzX_ZY(Vector4 V){ return MkVector4(V.x, 0, V.z, V.y); }
inline Vector4 SwizzX_ZZ(Vector4 V){ return MkVector4(V.x, 0, V.z, V.z); }
inline Vector4 SwizzX_ZW(Vector4 V){ return MkVector4(V.x, 0, V.z, V.w); }
inline Vector4 SwizzX_Z_(Vector4 V){ return MkVector4(V.x, 0, V.z, 0); }
inline Vector4 SwizzX_WX(Vector4 V){ return MkVector4(V.x, 0, V.w, V.x); }
inline Vector4 SwizzX_WY(Vector4 V){ return MkVector4(V.x, 0, V.w, V.y); }
inline Vector4 SwizzX_WZ(Vector4 V){ return MkVector4(V.x, 0, V.w, V.z); }
inline Vector4 SwizzX_WW(Vector4 V){ return MkVector4(V.x, 0, V.w, V.w); }
inline Vector4 SwizzX_W_(Vector4 V){ return MkVector4(V.x, 0, V.w, 0); }
inline Vector4 SwizzX__X(Vector4 V){ return MkVector4(V.x, 0, 0, V.x); }
inline Vector4 SwizzX__Y(Vector4 V){ return MkVector4(V.x, 0, 0, V.y); }
inline Vector4 SwizzX__Z(Vector4 V){ return MkVector4(V.x, 0, 0, V.z); }
inline Vector4 SwizzX__W(Vector4 V){ return MkVector4(V.x, 0, 0, V.w); }
inline Vector4 SwizzX___(Vector4 V){ return MkVector4(V.x, 0, 0, 0); }
inline Vector4 SwizzYXXX(Vector4 V){ return MkVector4(V.y, V.x, V.x, V.x); }
inline Vector4 SwizzYXXY(Vector4 V){ return MkVector4(V.y, V.x, V.x, V.y); }
inline Vector4 SwizzYXXZ(Vector4 V){ return MkVector4(V.y, V.x, V.x, V.z); }
inline Vector4 SwizzYXXW(Vector4 V){ return MkVector4(V.y, V.x, V.x, V.w); }
inline Vector4 SwizzYXX_(Vector4 V){ return MkVector4(V.y, V.x, V.x, 0); }
inline Vector4 SwizzYXYX(Vector4 V){ return MkVector4(V.y, V.x, V.y, V.x); }
inline Vector4 SwizzYXYY(Vector4 V){ return MkVector4(V.y, V.x, V.y, V.y); }
inline Vector4 SwizzYXYZ(Vector4 V){ return MkVector4(V.y, V.x, V.y, V.z); }
inline Vector4 SwizzYXYW(Vector4 V){ return MkVector4(V.y, V.x, V.y, V.w); }
inline Vector4 SwizzYXY_(Vector4 V){ return MkVector4(V.y, V.x, V.y, 0); }
inline Vector4 SwizzYXZX(Vector4 V){ return MkVector4(V.y, V.x, V.z, V.x); }
inline Vector4 SwizzYXZY(Vector4 V){ return MkVector4(V.y, V.x, V.z, V.y); }
inline Vector4 SwizzYXZZ(Vector4 V){ return MkVector4(V.y, V.x, V.z, V.z); }
inline Vector4 SwizzYXZW(Vector4 V){ return MkVector4(V.y, V.x, V.z, V.w); }
inline Vector4 SwizzYXZ_(Vector4 V){ return MkVector4(V.y, V.x, V.z, 0); }
inline Vector4 SwizzYXWX(Vector4 V){ return MkVector4(V.y, V.x, V.w, V.x); }
inline Vector4 SwizzYXWY(Vector4 V){ return MkVector4(V.y, V.x, V.w, V.y); }
inline Vector4 SwizzYXWZ(Vector4 V){ return MkVector4(V.y, V.x, V.w, V.z); }
inline Vector4 SwizzYXWW(Vector4 V){ return MkVector4(V.y, V.x, V.w, V.w); }
inline Vector4 SwizzYXW_(Vector4 V){ return MkVector4(V.y, V.x, V.w, 0); }
inline Vector4 SwizzYX_X(Vector4 V){ return MkVector4(V.y, V.x, 0, V.x); }
inline Vector4 SwizzYX_Y(Vector4 V){ return MkVector4(V.y, V.x, 0, V.y); }
inline Vector4 SwizzYX_Z(Vector4 V){ return MkVector4(V.y, V.x, 0, V.z); }
inline Vector4 SwizzYX_W(Vector4 V){ return MkVector4(V.y, V.x, 0, V.w); }
inline Vector4 SwizzYX__(Vector4 V){ return MkVector4(V.y, V.x, 0, 0); }
inline Vector4 SwizzYYXX(Vector4 V){ return MkVector4(V.y, V.y, V.x, V.x); }
inline Vector4 SwizzYYXY(Vector4 V){ return MkVector4(V.y, V.y, V.x, V.y); }
inline Vector4 SwizzYYXZ(Vector4 V){ return MkVector4(V.y, V.y, V.x, V.z); }
inline Vector4 SwizzYYXW(Vector4 V){ return MkVector4(V.y, V.y, V.x, V.w); }
inline Vector4 SwizzYYX_(Vector4 V){ return MkVector4(V.y, V.y, V.x, 0); }
inline Vector4 SwizzYYYX(Vector4 V){ return MkVector4(V.y, V.y, V.y, V.x); }
inline Vector4 SwizzYYYY(Vector4 V){ return MkVector4(V.y, V.y, V.y, V.y); }
inline Vector4 SwizzYYYZ(Vector4 V){ return MkVector4(V.y, V.y, V.y, V.z); }
inline Vector4 SwizzYYYW(Vector4 V){ return MkVector4(V.y, V.y, V.y, V.w); }
inline Vector4 SwizzYYY_(Vector4 V){ return MkVector4(V.y, V.y, V.y, 0); }
inline Vector4 SwizzYYZX(Vector4 V){ return MkVector4(V.y, V.y, V.z, V.x); }
inline Vector4 SwizzYYZY(Vector4 V){ return MkVector4(V.y, V.y, V.z, V.y); }
inline Vector4 SwizzYYZZ(Vector4 V){ return MkVector4(V.y, V.y, V.z, V.z); }
inline Vector4 SwizzYYZW(Vector4 V){ return MkVector4(V.y, V.y, V.z, V.w); }
inline Vector4 SwizzYYZ_(Vector4 V){ return MkVector4(V.y, V.y, V.z, 0); }
inline Vector4 SwizzYYWX(Vector4 V){ return MkVector4(V.y, V.y, V.w, V.x); }
inline Vector4 SwizzYYWY(Vector4 V){ return MkVector4(V.y, V.y, V.w, V.y); }
inline Vector4 SwizzYYWZ(Vector4 V){ return MkVector4(V.y, V.y, V.w, V.z); }
inline Vector4 SwizzYYWW(Vector4 V){ return MkVector4(V.y, V.y, V.w, V.w); }
inline Vector4 SwizzYYW_(Vector4 V){ return MkVector4(V.y, V.y, V.w, 0); }
inline Vector4 SwizzYY_X(Vector4 V){ return MkVector4(V.y, V.y, 0, V.x); }
inline Vector4 SwizzYY_Y(Vector4 V){ return MkVector4(V.y, V.y, 0, V.y); }
inline Vector4 SwizzYY_Z(Vector4 V){ return MkVector4(V.y, V.y, 0, V.z); }
inline Vector4 SwizzYY_W(Vector4 V){ return MkVector4(V.y, V.y, 0, V.w); }
inline Vector4 SwizzYY__(Vector4 V){ return MkVector4(V.y, V.y, 0, 0); }
inline Vector4 SwizzYZXX(Vector4 V){ return MkVector4(V.y, V.z, V.x, V.x); }
inline Vector4 SwizzYZXY(Vector4 V){ return MkVector4(V.y, V.z, V.x, V.y); }
inline Vector4 SwizzYZXZ(Vector4 V){ return MkVector4(V.y, V.z, V.x, V.z); }
inline Vector4 SwizzYZXW(Vector4 V){ return MkVector4(V.y, V.z, V.x, V.w); }
inline Vector4 SwizzYZX_(Vector4 V){ return MkVector4(V.y, V.z, V.x, 0); }
inline Vector4 SwizzYZYX(Vector4 V){ return MkVector4(V.y, V.z, V.y, V.x); }
inline Vector4 SwizzYZYY(Vector4 V){ return MkVector4(V.y, V.z, V.y, V.y); }
inline Vector4 SwizzYZYZ(Vector4 V){ return MkVector4(V.y, V.z, V.y, V.z); }
inline Vector4 SwizzYZYW(Vector4 V){ return MkVector4(V.y, V.z, V.y, V.w); }
inline Vector4 SwizzYZY_(Vector4 V){ return MkVector4(V.y, V.z, V.y, 0); }
inline Vector4 SwizzYZZX(Vector4 V){ return MkVector4(V.y, V.z, V.z, V.x); }
inline Vector4 SwizzYZZY(Vector4 V){ return MkVector4(V.y, V.z, V.z, V.y); }
inline Vector4 SwizzYZZZ(Vector4 V){ return MkVector4(V.y, V.z, V.z, V.z); }
inline Vector4 SwizzYZZW(Vector4 V){ return MkVector4(V.y, V.z, V.z, V.w); }
inline Vector4 SwizzYZZ_(Vector4 V){ return MkVector4(V.y, V.z, V.z, 0); }
inline Vector4 SwizzYZWX(Vector4 V){ return MkVector4(V.y, V.z, V.w, V.x); }
inline Vector4 SwizzYZWY(Vector4 V){ return MkVector4(V.y, V.z, V.w, V.y); }
inline Vector4 SwizzYZWZ(Vector4 V){ return MkVector4(V.y, V.z, V.w, V.z); }
inline Vector4 SwizzYZWW(Vector4 V){ return MkVector4(V.y, V.z, V.w, V.w); }
inline Vector4 SwizzYZW_(Vector4 V){ return MkVector4(V.y, V.z, V.w, 0); }
inline Vector4 SwizzYZ_X(Vector4 V){ return MkVector4(V.y, V.z, 0, V.x); }
inline Vector4 SwizzYZ_Y(Vector4 V){ return MkVector4(V.y, V.z, 0, V.y); }
inline Vector4 SwizzYZ_Z(Vector4 V){ return MkVector4(V.y, V.z, 0, V.z); }
inline Vector4 SwizzYZ_W(Vector4 V){ return MkVector4(V.y, V.z, 0, V.w); }
inline Vector4 SwizzYZ__(Vector4 V){ return MkVector4(V.y, V.z, 0, 0); }
inline Vector4 SwizzYWXX(Vector4 V){ return MkVector4(V.y, V.w, V.x, V.x); }
inline Vector4 SwizzYWXY(Vector4 V){ return MkVector4(V.y, V.w, V.x, V.y); }
inline Vector4 SwizzYWXZ(Vector4 V){ return MkVector4(V.y, V.w, V.x, V.z); }
inline Vector4 SwizzYWXW(Vector4 V){ return MkVector4(V.y, V.w, V.x, V.w); }
inline Vector4 SwizzYWX_(Vector4 V){ return MkVector4(V.y, V.w, V.x, 0); }
inline Vector4 SwizzYWYX(Vector4 V){ return MkVector4(V.y, V.w, V.y, V.x); }
inline Vector4 SwizzYWYY(Vector4 V){ return MkVector4(V.y, V.w, V.y, V.y); }
inline Vector4 SwizzYWYZ(Vector4 V){ return MkVector4(V.y, V.w, V.y, V.z); }
inline Vector4 SwizzYWYW(Vector4 V){ return MkVector4(V.y, V.w, V.y, V.w); }
inline Vector4 SwizzYWY_(Vector4 V){ return MkVector4(V.y, V.w, V.y, 0); }
inline Vector4 SwizzYWZX(Vector4 V){ return MkVector4(V.y, V.w, V.z, V.x); }
inline Vector4 SwizzYWZY(Vector4 V){ return MkVector4(V.y, V.w, V.z, V.y); }
inline Vector4 SwizzYWZZ(Vector4 V){ return MkVector4(V.y, V.w, V.z, V.z); }
inline Vector4 SwizzYWZW(Vector4 V){ return MkVector4(V.y, V.w, V.z, V.w); }
inline Vector4 SwizzYWZ_(Vector4 V){ return MkVector4(V.y, V.w, V.z, 0); }
inline Vector4 SwizzYWWX(Vector4 V){ return MkVector4(V.y, V.w, V.w, V.x); }
inline Vector4 SwizzYWWY(Vector4 V){ return MkVector4(V.y, V.w, V.w, V.y); }
inline Vector4 SwizzYWWZ(Vector4 V){ return MkVector4(V.y, V.w, V.w, V.z); }
inline Vector4 SwizzYWWW(Vector4 V){ return MkVector4(V.y, V.w, V.w, V.w); }
inline Vector4 SwizzYWW_(Vector4 V){ return MkVector4(V.y, V.w, V.w, 0); }
inline Vector4 SwizzYW_X(Vector4 V){ return MkVector4(V.y, V.w, 0, V.x); }
inline Vector4 SwizzYW_Y(Vector4 V){ return MkVector4(V.y, V.w, 0, V.y); }
inline Vector4 SwizzYW_Z(Vector4 V){ return MkVector4(V.y, V.w, 0, V.z); }
inline Vector4 SwizzYW_W(Vector4 V){ return MkVector4(V.y, V.w, 0, V.w); }
inline Vector4 SwizzYW__(Vector4 V){ return MkVector4(V.y, V.w, 0, 0); }
inline Vector4 SwizzY_XX(Vector4 V){ return MkVector4(V.y, 0, V.x, V.x); }
inline Vector4 SwizzY_XY(Vector4 V){ return MkVector4(V.y, 0, V.x, V.y); }
inline Vector4 SwizzY_XZ(Vector4 V){ return MkVector4(V.y, 0, V.x, V.z); }
inline Vector4 SwizzY_XW(Vector4 V){ return MkVector4(V.y, 0, V.x, V.w); }
inline Vector4 SwizzY_X_(Vector4 V){ return MkVector4(V.y, 0, V.x, 0); }
inline Vector4 SwizzY_YX(Vector4 V){ return MkVector4(V.y, 0, V.y, V.x); }
inline Vector4 SwizzY_YY(Vector4 V){ return MkVector4(V.y, 0, V.y, V.y); }
inline Vector4 SwizzY_YZ(Vector4 V){ return MkVector4(V.y, 0, V.y, V.z); }
inline Vector4 SwizzY_YW(Vector4 V){ return MkVector4(V.y, 0, V.y, V.w); }
inline Vector4 SwizzY_Y_(Vector4 V){ return MkVector4(V.y, 0, V.y, 0); }
inline Vector4 SwizzY_ZX(Vector4 V){ return MkVector4(V.y, 0, V.z, V.x); }
inline Vector4 SwizzY_ZY(Vector4 V){ return MkVector4(V.y, 0, V.z, V.y); }
inline Vector4 SwizzY_ZZ(Vector4 V){ return MkVector4(V.y, 0, V.z, V.z); }
inline Vector4 SwizzY_ZW(Vector4 V){ return MkVector4(V.y, 0, V.z, V.w); }
inline Vector4 SwizzY_Z_(Vector4 V){ return MkVector4(V.y, 0, V.z, 0); }
inline Vector4 SwizzY_WX(Vector4 V){ return MkVector4(V.y, 0, V.w, V.x); }
inline Vector4 SwizzY_WY(Vector4 V){ return MkVector4(V.y, 0, V.w, V.y); }
inline Vector4 SwizzY_WZ(Vector4 V){ return MkVector4(V.y, 0, V.w, V.z); }
inline Vector4 SwizzY_WW(Vector4 V){ return MkVector4(V.y, 0, V.w, V.w); }
inline Vector4 SwizzY_W_(Vector4 V){ return MkVector4(V.y, 0, V.w, 0); }
inline Vector4 SwizzY__X(Vector4 V){ return MkVector4(V.y, 0, 0, V.x); }
inline Vector4 SwizzY__Y(Vector4 V){ return MkVector4(V.y, 0, 0, V.y); }
inline Vector4 SwizzY__Z(Vector4 V){ return MkVector4(V.y, 0, 0, V.z); }
inline Vector4 SwizzY__W(Vector4 V){ return MkVector4(V.y, 0, 0, V.w); }
inline Vector4 SwizzY___(Vector4 V){ return MkVector4(V.y, 0, 0, 0); }
inline Vector4 SwizzZXXX(Vector4 V){ return MkVector4(V.z, V.x, V.x, V.x); }
inline Vector4 SwizzZXXY(Vector4 V){ return MkVector4(V.z, V.x, V.x, V.y); }
inline Vector4 SwizzZXXZ(Vector4 V){ return MkVector4(V.z, V.x, V.x, V.z); }
inline Vector4 SwizzZXXW(Vector4 V){ return MkVector4(V.z, V.x, V.x, V.w); }
inline Vector4 SwizzZXX_(Vector4 V){ return MkVector4(V.z, V.x, V.x, 0); }
inline Vector4 SwizzZXYX(Vector4 V){ return MkVector4(V.z, V.x, V.y, V.x); }
inline Vector4 SwizzZXYY(Vector4 V){ return MkVector4(V.z, V.x, V.y, V.y); }
inline Vector4 SwizzZXYZ(Vector4 V){ return MkVector4(V.z, V.x, V.y, V.z); }
inline Vector4 SwizzZXYW(Vector4 V){ return MkVector4(V.z, V.x, V.y, V.w); }
inline Vector4 SwizzZXY_(Vector4 V){ return MkVector4(V.z, V.x, V.y, 0); }
inline Vector4 SwizzZXZX(Vector4 V){ return MkVector4(V.z, V.x, V.z, V.x); }
inline Vector4 SwizzZXZY(Vector4 V){ return MkVector4(V.z, V.x, V.z, V.y); }
inline Vector4 SwizzZXZZ(Vector4 V){ return MkVector4(V.z, V.x, V.z, V.z); }
inline Vector4 SwizzZXZW(Vector4 V){ return MkVector4(V.z, V.x, V.z, V.w); }
inline Vector4 SwizzZXZ_(Vector4 V){ return MkVector4(V.z, V.x, V.z, 0); }
inline Vector4 SwizzZXWX(Vector4 V){ return MkVector4(V.z, V.x, V.w, V.x); }
inline Vector4 SwizzZXWY(Vector4 V){ return MkVector4(V.z, V.x, V.w, V.y); }
inline Vector4 SwizzZXWZ(Vector4 V){ return MkVector4(V.z, V.x, V.w, V.z); }
inline Vector4 SwizzZXWW(Vector4 V){ return MkVector4(V.z, V.x, V.w, V.w); }
inline Vector4 SwizzZXW_(Vector4 V){ return MkVector4(V.z, V.x, V.w, 0); }
inline Vector4 SwizzZX_X(Vector4 V){ return MkVector4(V.z, V.x, 0, V.x); }
inline Vector4 SwizzZX_Y(Vector4 V){ return MkVector4(V.z, V.x, 0, V.y); }
inline Vector4 SwizzZX_Z(Vector4 V){ return MkVector4(V.z, V.x, 0, V.z); }
inline Vector4 SwizzZX_W(Vector4 V){ return MkVector4(V.z, V.x, 0, V.w); }
inline Vector4 SwizzZX__(Vector4 V){ return MkVector4(V.z, V.x, 0, 0); }
inline Vector4 SwizzZYXX(Vector4 V){ return MkVector4(V.z, V.y, V.x, V.x); }
inline Vector4 SwizzZYXY(Vector4 V){ return MkVector4(V.z, V.y, V.x, V.y); }
inline Vector4 SwizzZYXZ(Vector4 V){ return MkVector4(V.z, V.y, V.x, V.z); }
inline Vector4 SwizzZYXW(Vector4 V){ return MkVector4(V.z, V.y, V.x, V.w); }
inline Vector4 SwizzZYX_(Vector4 V){ return MkVector4(V.z, V.y, V.x, 0); }
inline Vector4 SwizzZYYX(Vector4 V){ return MkVector4(V.z, V.y, V.y, V.x); }
inline Vector4 SwizzZYYY(Vector4 V){ return MkVector4(V.z, V.y, V.y, V.y); }
inline Vector4 SwizzZYYZ(Vector4 V){ return MkVector4(V.z, V.y, V.y, V.z); }
inline Vector4 SwizzZYYW(Vector4 V){ return MkVector4(V.z, V.y, V.y, V.w); }
inline Vector4 SwizzZYY_(Vector4 V){ return MkVector4(V.z, V.y, V.y, 0); }
inline Vector4 SwizzZYZX(Vector4 V){ return MkVector4(V.z, V.y, V.z, V.x); }
inline Vector4 SwizzZYZY(Vector4 V){ return MkVector4(V.z, V.y, V.z, V.y); }
inline Vector4 SwizzZYZZ(Vector4 V){ return MkVector4(V.z, V.y, V.z, V.z); }
inline Vector4 SwizzZYZW(Vector4 V){ return MkVector4(V.z, V.y, V.z, V.w); }
inline Vector4 SwizzZYZ_(Vector4 V){ return MkVector4(V.z, V.y, V.z, 0); }
inline Vector4 SwizzZYWX(Vector4 V){ return MkVector4(V.z, V.y, V.w, V.x); }
inline Vector4 SwizzZYWY(Vector4 V){ return MkVector4(V.z, V.y, V.w, V.y); }
inline Vector4 SwizzZYWZ(Vector4 V){ return MkVector4(V.z, V.y, V.w, V.z); }
inline Vector4 SwizzZYWW(Vector4 V){ return MkVector4(V.z, V.y, V.w, V.w); }
inline Vector4 SwizzZYW_(Vector4 V){ return MkVector4(V.z, V.y, V.w, 0); }
inline Vector4 SwizzZY_X(Vector4 V){ return MkVector4(V.z, V.y, 0, V.x); }
inline Vector4 SwizzZY_Y(Vector4 V){ return MkVector4(V.z, V.y, 0, V.y); }
inline Vector4 SwizzZY_Z(Vector4 V){ return MkVector4(V.z, V.y, 0, V.z); }
inline Vector4 SwizzZY_W(Vector4 V){ return MkVector4(V.z, V.y, 0, V.w); }
inline Vector4 SwizzZY__(Vector4 V){ return MkVector4(V.z, V.y, 0, 0); }
inline Vector4 SwizzZZXX(Vector4 V){ return MkVector4(V.z, V.z, V.x, V.x); }
inline Vector4 SwizzZZXY(Vector4 V){ return MkVector4(V.z, V.z, V.x, V.y); }
inline Vector4 SwizzZZXZ(Vector4 V){ return MkVector4(V.z, V.z, V.x, V.z); }
inline Vector4 SwizzZZXW(Vector4 V){ return MkVector4(V.z, V.z, V.x, V.w); }
inline Vector4 SwizzZZX_(Vector4 V){ return MkVector4(V.z, V.z, V.x, 0); }
inline Vector4 SwizzZZYX(Vector4 V){ return MkVector4(V.z, V.z, V.y, V.x); }
inline Vector4 SwizzZZYY(Vector4 V){ return MkVector4(V.z, V.z, V.y, V.y); }
inline Vector4 SwizzZZYZ(Vector4 V){ return MkVector4(V.z, V.z, V.y, V.z); }
inline Vector4 SwizzZZYW(Vector4 V){ return MkVector4(V.z, V.z, V.y, V.w); }
inline Vector4 SwizzZZY_(Vector4 V){ return MkVector4(V.z, V.z, V.y, 0); }
inline Vector4 SwizzZZZX(Vector4 V){ return MkVector4(V.z, V.z, V.z, V.x); }
inline Vector4 SwizzZZZY(Vector4 V){ return MkVector4(V.z, V.z, V.z, V.y); }
inline Vector4 SwizzZZZZ(Vector4 V){ return MkVector4(V.z, V.z, V.z, V.z); }
inline Vector4 SwizzZZZW(Vector4 V){ return MkVector4(V.z, V.z, V.z, V.w); }
inline Vector4 SwizzZZZ_(Vector4 V){ return MkVector4(V.z, V.z, V.z, 0); }
inline Vector4 SwizzZZWX(Vector4 V){ return MkVector4(V.z, V.z, V.w, V.x); }
inline Vector4 SwizzZZWY(Vector4 V){ return MkVector4(V.z, V.z, V.w, V.y); }
inline Vector4 SwizzZZWZ(Vector4 V){ return MkVector4(V.z, V.z, V.w, V.z); }
inline Vector4 SwizzZZWW(Vector4 V){ return MkVector4(V.z, V.z, V.w, V.w); }
inline Vector4 SwizzZZW_(Vector4 V){ return MkVector4(V.z, V.z, V.w, 0); }
inline Vector4 SwizzZZ_X(Vector4 V){ return MkVector4(V.z, V.z, 0, V.x); }
inline Vector4 SwizzZZ_Y(Vector4 V){ return MkVector4(V.z, V.z, 0, V.y); }
inline Vector4 SwizzZZ_Z(Vector4 V){ return MkVector4(V.z, V.z, 0, V.z); }
inline Vector4 SwizzZZ_W(Vector4 V){ return MkVector4(V.z, V.z, 0, V.w); }
inline Vector4 SwizzZZ__(Vector4 V){ return MkVector4(V.z, V.z, 0, 0); }
inline Vector4 SwizzZWXX(Vector4 V){ return MkVector4(V.z, V.w, V.x, V.x); }
inline Vector4 SwizzZWXY(Vector4 V){ return MkVector4(V.z, V.w, V.x, V.y); }
inline Vector4 SwizzZWXZ(Vector4 V){ return MkVector4(V.z, V.w, V.x, V.z); }
inline Vector4 SwizzZWXW(Vector4 V){ return MkVector4(V.z, V.w, V.x, V.w); }
inline Vector4 SwizzZWX_(Vector4 V){ return MkVector4(V.z, V.w, V.x, 0); }
inline Vector4 SwizzZWYX(Vector4 V){ return MkVector4(V.z, V.w, V.y, V.x); }
inline Vector4 SwizzZWYY(Vector4 V){ return MkVector4(V.z, V.w, V.y, V.y); }
inline Vector4 SwizzZWYZ(Vector4 V){ return MkVector4(V.z, V.w, V.y, V.z); }
inline Vector4 SwizzZWYW(Vector4 V){ return MkVector4(V.z, V.w, V.y, V.w); }
inline Vector4 SwizzZWY_(Vector4 V){ return MkVector4(V.z, V.w, V.y, 0); }
inline Vector4 SwizzZWZX(Vector4 V){ return MkVector4(V.z, V.w, V.z, V.x); }
inline Vector4 SwizzZWZY(Vector4 V){ return MkVector4(V.z, V.w, V.z, V.y); }
inline Vector4 SwizzZWZZ(Vector4 V){ return MkVector4(V.z, V.w, V.z, V.z); }
inline Vector4 SwizzZWZW(Vector4 V){ return MkVector4(V.z, V.w, V.z, V.w); }
inline Vector4 SwizzZWZ_(Vector4 V){ return MkVector4(V.z, V.w, V.z, 0); }
inline Vector4 SwizzZWWX(Vector4 V){ return MkVector4(V.z, V.w, V.w, V.x); }
inline Vector4 SwizzZWWY(Vector4 V){ return MkVector4(V.z, V.w, V.w, V.y); }
inline Vector4 SwizzZWWZ(Vector4 V){ return MkVector4(V.z, V.w, V.w, V.z); }
inline Vector4 SwizzZWWW(Vector4 V){ return MkVector4(V.z, V.w, V.w, V.w); }
inline Vector4 SwizzZWW_(Vector4 V){ return MkVector4(V.z, V.w, V.w, 0); }
inline Vector4 SwizzZW_X(Vector4 V){ return MkVector4(V.z, V.w, 0, V.x); }
inline Vector4 SwizzZW_Y(Vector4 V){ return MkVector4(V.z, V.w, 0, V.y); }
inline Vector4 SwizzZW_Z(Vector4 V){ return MkVector4(V.z, V.w, 0, V.z); }
inline Vector4 SwizzZW_W(Vector4 V){ return MkVector4(V.z, V.w, 0, V.w); }
inline Vector4 SwizzZW__(Vector4 V){ return MkVector4(V.z, V.w, 0, 0); }
inline Vector4 SwizzZ_XX(Vector4 V){ return MkVector4(V.z, 0, V.x, V.x); }
inline Vector4 SwizzZ_XY(Vector4 V){ return MkVector4(V.z, 0, V.x, V.y); }
inline Vector4 SwizzZ_XZ(Vector4 V){ return MkVector4(V.z, 0, V.x, V.z); }
inline Vector4 SwizzZ_XW(Vector4 V){ return MkVector4(V.z, 0, V.x, V.w); }
inline Vector4 SwizzZ_X_(Vector4 V){ return MkVector4(V.z, 0, V.x, 0); }
inline Vector4 SwizzZ_YX(Vector4 V){ return MkVector4(V.z, 0, V.y, V.x); }
inline Vector4 SwizzZ_YY(Vector4 V){ return MkVector4(V.z, 0, V.y, V.y); }
inline Vector4 SwizzZ_YZ(Vector4 V){ return MkVector4(V.z, 0, V.y, V.z); }
inline Vector4 SwizzZ_YW(Vector4 V){ return MkVector4(V.z, 0, V.y, V.w); }
inline Vector4 SwizzZ_Y_(Vector4 V){ return MkVector4(V.z, 0, V.y, 0); }
inline Vector4 SwizzZ_ZX(Vector4 V){ return MkVector4(V.z, 0, V.z, V.x); }
inline Vector4 SwizzZ_ZY(Vector4 V){ return MkVector4(V.z, 0, V.z, V.y); }
inline Vector4 SwizzZ_ZZ(Vector4 V){ return MkVector4(V.z, 0, V.z, V.z); }
inline Vector4 SwizzZ_ZW(Vector4 V){ return MkVector4(V.z, 0, V.z, V.w); }
inline Vector4 SwizzZ_Z_(Vector4 V){ return MkVector4(V.z, 0, V.z, 0); }
inline Vector4 SwizzZ_WX(Vector4 V){ return MkVector4(V.z, 0, V.w, V.x); }
inline Vector4 SwizzZ_WY(Vector4 V){ return MkVector4(V.z, 0, V.w, V.y); }
inline Vector4 SwizzZ_WZ(Vector4 V){ return MkVector4(V.z, 0, V.w, V.z); }
inline Vector4 SwizzZ_WW(Vector4 V){ return MkVector4(V.z, 0, V.w, V.w); }
inline Vector4 SwizzZ_W_(Vector4 V){ return MkVector4(V.z, 0, V.w, 0); }
inline Vector4 SwizzZ__X(Vector4 V){ return MkVector4(V.z, 0, 0, V.x); }
inline Vector4 SwizzZ__Y(Vector4 V){ return MkVector4(V.z, 0, 0, V.y); }
inline Vector4 SwizzZ__Z(Vector4 V){ return MkVector4(V.z, 0, 0, V.z); }
inline Vector4 SwizzZ__W(Vector4 V){ return MkVector4(V.z, 0, 0, V.w); }
inline Vector4 SwizzZ___(Vector4 V){ return MkVector4(V.z, 0, 0, 0); }
inline Vector4 SwizzWXXX(Vector4 V){ return MkVector4(V.w, V.x, V.x, V.x); }
inline Vector4 SwizzWXXY(Vector4 V){ return MkVector4(V.w, V.x, V.x, V.y); }
inline Vector4 SwizzWXXZ(Vector4 V){ return MkVector4(V.w, V.x, V.x, V.z); }
inline Vector4 SwizzWXXW(Vector4 V){ return MkVector4(V.w, V.x, V.x, V.w); }
inline Vector4 SwizzWXX_(Vector4 V){ return MkVector4(V.w, V.x, V.x, 0); }
inline Vector4 SwizzWXYX(Vector4 V){ return MkVector4(V.w, V.x, V.y, V.x); }
inline Vector4 SwizzWXYY(Vector4 V){ return MkVector4(V.w, V.x, V.y, V.y); }
inline Vector4 SwizzWXYZ(Vector4 V){ return MkVector4(V.w, V.x, V.y, V.z); }
inline Vector4 SwizzWXYW(Vector4 V){ return MkVector4(V.w, V.x, V.y, V.w); }
inline Vector4 SwizzWXY_(Vector4 V){ return MkVector4(V.w, V.x, V.y, 0); }
inline Vector4 SwizzWXZX(Vector4 V){ return MkVector4(V.w, V.x, V.z, V.x); }
inline Vector4 SwizzWXZY(Vector4 V){ return MkVector4(V.w, V.x, V.z, V.y); }
inline Vector4 SwizzWXZZ(Vector4 V){ return MkVector4(V.w, V.x, V.z, V.z); }
inline Vector4 SwizzWXZW(Vector4 V){ return MkVector4(V.w, V.x, V.z, V.w); }
inline Vector4 SwizzWXZ_(Vector4 V){ return MkVector4(V.w, V.x, V.z, 0); }
inline Vector4 SwizzWXWX(Vector4 V){ return MkVector4(V.w, V.x, V.w, V.x); }
inline Vector4 SwizzWXWY(Vector4 V){ return MkVector4(V.w, V.x, V.w, V.y); }
inline Vector4 SwizzWXWZ(Vector4 V){ return MkVector4(V.w, V.x, V.w, V.z); }
inline Vector4 SwizzWXWW(Vector4 V){ return MkVector4(V.w, V.x, V.w, V.w); }
inline Vector4 SwizzWXW_(Vector4 V){ return MkVector4(V.w, V.x, V.w, 0); }
inline Vector4 SwizzWX_X(Vector4 V){ return MkVector4(V.w, V.x, 0, V.x); }
inline Vector4 SwizzWX_Y(Vector4 V){ return MkVector4(V.w, V.x, 0, V.y); }
inline Vector4 SwizzWX_Z(Vector4 V){ return MkVector4(V.w, V.x, 0, V.z); }
inline Vector4 SwizzWX_W(Vector4 V){ return MkVector4(V.w, V.x, 0, V.w); }
inline Vector4 SwizzWX__(Vector4 V){ return MkVector4(V.w, V.x, 0, 0); }
inline Vector4 SwizzWYXX(Vector4 V){ return MkVector4(V.w, V.y, V.x, V.x); }
inline Vector4 SwizzWYXY(Vector4 V){ return MkVector4(V.w, V.y, V.x, V.y); }
inline Vector4 SwizzWYXZ(Vector4 V){ return MkVector4(V.w, V.y, V.x, V.z); }
inline Vector4 SwizzWYXW(Vector4 V){ return MkVector4(V.w, V.y, V.x, V.w); }
inline Vector4 SwizzWYX_(Vector4 V){ return MkVector4(V.w, V.y, V.x, 0); }
inline Vector4 SwizzWYYX(Vector4 V){ return MkVector4(V.w, V.y, V.y, V.x); }
inline Vector4 SwizzWYYY(Vector4 V){ return MkVector4(V.w, V.y, V.y, V.y); }
inline Vector4 SwizzWYYZ(Vector4 V){ return MkVector4(V.w, V.y, V.y, V.z); }
inline Vector4 SwizzWYYW(Vector4 V){ return MkVector4(V.w, V.y, V.y, V.w); }
inline Vector4 SwizzWYY_(Vector4 V){ return MkVector4(V.w, V.y, V.y, 0); }
inline Vector4 SwizzWYZX(Vector4 V){ return MkVector4(V.w, V.y, V.z, V.x); }
inline Vector4 SwizzWYZY(Vector4 V){ return MkVector4(V.w, V.y, V.z, V.y); }
inline Vector4 SwizzWYZZ(Vector4 V){ return MkVector4(V.w, V.y, V.z, V.z); }
inline Vector4 SwizzWYZW(Vector4 V){ return MkVector4(V.w, V.y, V.z, V.w); }
inline Vector4 SwizzWYZ_(Vector4 V){ return MkVector4(V.w, V.y, V.z, 0); }
inline Vector4 SwizzWYWX(Vector4 V){ return MkVector4(V.w, V.y, V.w, V.x); }
inline Vector4 SwizzWYWY(Vector4 V){ return MkVector4(V.w, V.y, V.w, V.y); }
inline Vector4 SwizzWYWZ(Vector4 V){ return MkVector4(V.w, V.y, V.w, V.z); }
inline Vector4 SwizzWYWW(Vector4 V){ return MkVector4(V.w, V.y, V.w, V.w); }
inline Vector4 SwizzWYW_(Vector4 V){ return MkVector4(V.w, V.y, V.w, 0); }
inline Vector4 SwizzWY_X(Vector4 V){ return MkVector4(V.w, V.y, 0, V.x); }
inline Vector4 SwizzWY_Y(Vector4 V){ return MkVector4(V.w, V.y, 0, V.y); }
inline Vector4 SwizzWY_Z(Vector4 V){ return MkVector4(V.w, V.y, 0, V.z); }
inline Vector4 SwizzWY_W(Vector4 V){ return MkVector4(V.w, V.y, 0, V.w); }
inline Vector4 SwizzWY__(Vector4 V){ return MkVector4(V.w, V.y, 0, 0); }
inline Vector4 SwizzWZXX(Vector4 V){ return MkVector4(V.w, V.z, V.x, V.x); }
inline Vector4 SwizzWZXY(Vector4 V){ return MkVector4(V.w, V.z, V.x, V.y); }
inline Vector4 SwizzWZXZ(Vector4 V){ return MkVector4(V.w, V.z, V.x, V.z); }
inline Vector4 SwizzWZXW(Vector4 V){ return MkVector4(V.w, V.z, V.x, V.w); }
inline Vector4 SwizzWZX_(Vector4 V){ return MkVector4(V.w, V.z, V.x, 0); }
inline Vector4 SwizzWZYX(Vector4 V){ return MkVector4(V.w, V.z, V.y, V.x); }
inline Vector4 SwizzWZYY(Vector4 V){ return MkVector4(V.w, V.z, V.y, V.y); }
inline Vector4 SwizzWZYZ(Vector4 V){ return MkVector4(V.w, V.z, V.y, V.z); }
inline Vector4 SwizzWZYW(Vector4 V){ return MkVector4(V.w, V.z, V.y, V.w); }
inline Vector4 SwizzWZY_(Vector4 V){ return MkVector4(V.w, V.z, V.y, 0); }
inline Vector4 SwizzWZZX(Vector4 V){ return MkVector4(V.w, V.z, V.z, V.x); }
inline Vector4 SwizzWZZY(Vector4 V){ return MkVector4(V.w, V.z, V.z, V.y); }
inline Vector4 SwizzWZZZ(Vector4 V){ return MkVector4(V.w, V.z, V.z, V.z); }
inline Vector4 SwizzWZZW(Vector4 V){ return MkVector4(V.w, V.z, V.z, V.w); }
inline Vector4 SwizzWZZ_(Vector4 V){ return MkVector4(V.w, V.z, V.z, 0); }
inline Vector4 SwizzWZWX(Vector4 V){ return MkVector4(V.w, V.z, V.w, V.x); }
inline Vector4 SwizzWZWY(Vector4 V){ return MkVector4(V.w, V.z, V.w, V.y); }
inline Vector4 SwizzWZWZ(Vector4 V){ return MkVector4(V.w, V.z, V.w, V.z); }
inline Vector4 SwizzWZWW(Vector4 V){ return MkVector4(V.w, V.z, V.w, V.w); }
inline Vector4 SwizzWZW_(Vector4 V){ return MkVector4(V.w, V.z, V.w, 0); }
inline Vector4 SwizzWZ_X(Vector4 V){ return MkVector4(V.w, V.z, 0, V.x); }
inline Vector4 SwizzWZ_Y(Vector4 V){ return MkVector4(V.w, V.z, 0, V.y); }
inline Vector4 SwizzWZ_Z(Vector4 V){ return MkVector4(V.w, V.z, 0, V.z); }
inline Vector4 SwizzWZ_W(Vector4 V){ return MkVector4(V.w, V.z, 0, V.w); }
inline Vector4 SwizzWZ__(Vector4 V){ return MkVector4(V.w, V.z, 0, 0); }
inline Vector4 SwizzWWXX(Vector4 V){ return MkVector4(V.w, V.w, V.x, V.x); }
inline Vector4 SwizzWWXY(Vector4 V){ return MkVector4(V.w, V.w, V.x, V.y); }
inline Vector4 SwizzWWXZ(Vector4 V){ return MkVector4(V.w, V.w, V.x, V.z); }
inline Vector4 SwizzWWXW(Vector4 V){ return MkVector4(V.w, V.w, V.x, V.w); }
inline Vector4 SwizzWWX_(Vector4 V){ return MkVector4(V.w, V.w, V.x, 0); }
inline Vector4 SwizzWWYX(Vector4 V){ return MkVector4(V.w, V.w, V.y, V.x); }
inline Vector4 SwizzWWYY(Vector4 V){ return MkVector4(V.w, V.w, V.y, V.y); }
inline Vector4 SwizzWWYZ(Vector4 V){ return MkVector4(V.w, V.w, V.y, V.z); }
inline Vector4 SwizzWWYW(Vector4 V){ return MkVector4(V.w, V.w, V.y, V.w); }
inline Vector4 SwizzWWY_(Vector4 V){ return MkVector4(V.w, V.w, V.y, 0); }
inline Vector4 SwizzWWZX(Vector4 V){ return MkVector4(V.w, V.w, V.z, V.x); }
inline Vector4 SwizzWWZY(Vector4 V){ return MkVector4(V.w, V.w, V.z, V.y); }
inline Vector4 SwizzWWZZ(Vector4 V){ return MkVector4(V.w, V.w, V.z, V.z); }
inline Vector4 SwizzWWZW(Vector4 V){ return MkVector4(V.w, V.w, V.z, V.w); }
inline Vector4 SwizzWWZ_(Vector4 V){ return MkVector4(V.w, V.w, V.z, 0); }
inline Vector4 SwizzWWWX(Vector4 V){ return MkVector4(V.w, V.w, V.w, V.x); }
inline Vector4 SwizzWWWY(Vector4 V){ return MkVector4(V.w, V.w, V.w, V.y); }
inline Vector4 SwizzWWWZ(Vector4 V){ return MkVector4(V.w, V.w, V.w, V.z); }
inline Vector4 SwizzWWWW(Vector4 V){ return MkVector4(V.w, V.w, V.w, V.w); }
inline Vector4 SwizzWWW_(Vector4 V){ return MkVector4(V.w, V.w, V.w, 0); }
inline Vector4 SwizzWW_X(Vector4 V){ return MkVector4(V.w, V.w, 0, V.x); }
inline Vector4 SwizzWW_Y(Vector4 V){ return MkVector4(V.w, V.w, 0, V.y); }
inline Vector4 SwizzWW_Z(Vector4 V){ return MkVector4(V.w, V.w, 0, V.z); }
inline Vector4 SwizzWW_W(Vector4 V){ return MkVector4(V.w, V.w, 0, V.w); }
inline Vector4 SwizzWW__(Vector4 V){ return MkVector4(V.w, V.w, 0, 0); }
inline Vector4 SwizzW_XX(Vector4 V){ return MkVector4(V.w, 0, V.x, V.x); }
inline Vector4 SwizzW_XY(Vector4 V){ return MkVector4(V.w, 0, V.x, V.y); }
inline Vector4 SwizzW_XZ(Vector4 V){ return MkVector4(V.w, 0, V.x, V.z); }
inline Vector4 SwizzW_XW(Vector4 V){ return MkVector4(V.w, 0, V.x, V.w); }
inline Vector4 SwizzW_X_(Vector4 V){ return MkVector4(V.w, 0, V.x, 0); }
inline Vector4 SwizzW_YX(Vector4 V){ return MkVector4(V.w, 0, V.y, V.x); }
inline Vector4 SwizzW_YY(Vector4 V){ return MkVector4(V.w, 0, V.y, V.y); }
inline Vector4 SwizzW_YZ(Vector4 V){ return MkVector4(V.w, 0, V.y, V.z); }
inline Vector4 SwizzW_YW(Vector4 V){ return MkVector4(V.w, 0, V.y, V.w); }
inline Vector4 SwizzW_Y_(Vector4 V){ return MkVector4(V.w, 0, V.y, 0); }
inline Vector4 SwizzW_ZX(Vector4 V){ return MkVector4(V.w, 0, V.z, V.x); }
inline Vector4 SwizzW_ZY(Vector4 V){ return MkVector4(V.w, 0, V.z, V.y); }
inline Vector4 SwizzW_ZZ(Vector4 V){ return MkVector4(V.w, 0, V.z, V.z); }
inline Vector4 SwizzW_ZW(Vector4 V){ return MkVector4(V.w, 0, V.z, V.w); }
inline Vector4 SwizzW_Z_(Vector4 V){ return MkVector4(V.w, 0, V.z, 0); }
inline Vector4 SwizzW_WX(Vector4 V){ return MkVector4(V.w, 0, V.w, V.x); }
inline Vector4 SwizzW_WY(Vector4 V){ return MkVector4(V.w, 0, V.w, V.y); }
inline Vector4 SwizzW_WZ(Vector4 V){ return MkVector4(V.w, 0, V.w, V.z); }
inline Vector4 SwizzW_WW(Vector4 V){ return MkVector4(V.w, 0, V.w, V.w); }
inline Vector4 SwizzW_W_(Vector4 V){ return MkVector4(V.w, 0, V.w, 0); }
inline Vector4 SwizzW__X(Vector4 V){ return MkVector4(V.w, 0, 0, V.x); }
inline Vector4 SwizzW__Y(Vector4 V){ return MkVector4(V.w, 0, 0, V.y); }
inline Vector4 SwizzW__Z(Vector4 V){ return MkVector4(V.w, 0, 0, V.z); }
inline Vector4 SwizzW__W(Vector4 V){ return MkVector4(V.w, 0, 0, V.w); }
inline Vector4 SwizzW___(Vector4 V){ return MkVector4(V.w, 0, 0, 0); }
inline Vector4 Swizz_XXX(Vector4 V){ return MkVector4(0, V.x, V.x, V.x); }
inline Vector4 Swizz_XXY(Vector4 V){ return MkVector4(0, V.x, V.x, V.y); }
inline Vector4 Swizz_XXZ(Vector4 V){ return MkVector4(0, V.x, V.x, V.z); }
inline Vector4 Swizz_XXW(Vector4 V){ return MkVector4(0, V.x, V.x, V.w); }
inline Vector4 Swizz_XX_(Vector4 V){ return MkVector4(0, V.x, V.x, 0); }
inline Vector4 Swizz_XYX(Vector4 V){ return MkVector4(0, V.x, V.y, V.x); }
inline Vector4 Swizz_XYY(Vector4 V){ return MkVector4(0, V.x, V.y, V.y); }
inline Vector4 Swizz_XYZ(Vector4 V){ return MkVector4(0, V.x, V.y, V.z); }
inline Vector4 Swizz_XYW(Vector4 V){ return MkVector4(0, V.x, V.y, V.w); }
inline Vector4 Swizz_XY_(Vector4 V){ return MkVector4(0, V.x, V.y, 0); }
inline Vector4 Swizz_XZX(Vector4 V){ return MkVector4(0, V.x, V.z, V.x); }
inline Vector4 Swizz_XZY(Vector4 V){ return MkVector4(0, V.x, V.z, V.y); }
inline Vector4 Swizz_XZZ(Vector4 V){ return MkVector4(0, V.x, V.z, V.z); }
inline Vector4 Swizz_XZW(Vector4 V){ return MkVector4(0, V.x, V.z, V.w); }
inline Vector4 Swizz_XZ_(Vector4 V){ return MkVector4(0, V.x, V.z, 0); }
inline Vector4 Swizz_XWX(Vector4 V){ return MkVector4(0, V.x, V.w, V.x); }
inline Vector4 Swizz_XWY(Vector4 V){ return MkVector4(0, V.x, V.w, V.y); }
inline Vector4 Swizz_XWZ(Vector4 V){ return MkVector4(0, V.x, V.w, V.z); }
inline Vector4 Swizz_XWW(Vector4 V){ return MkVector4(0, V.x, V.w, V.w); }
inline Vector4 Swizz_XW_(Vector4 V){ return MkVector4(0, V.x, V.w, 0); }
inline Vector4 Swizz_X_X(Vector4 V){ return MkVector4(0, V.x, 0, V.x); }
inline Vector4 Swizz_X_Y(Vector4 V){ return MkVector4(0, V.x, 0, V.y); }
inline Vector4 Swizz_X_Z(Vector4 V){ return MkVector4(0, V.x, 0, V.z); }
inline Vector4 Swizz_X_W(Vector4 V){ return MkVector4(0, V.x, 0, V.w); }
inline Vector4 Swizz_X__(Vector4 V){ return MkVector4(0, V.x, 0, 0); }
inline Vector4 Swizz_YXX(Vector4 V){ return MkVector4(0, V.y, V.x, V.x); }
inline Vector4 Swizz_YXY(Vector4 V){ return MkVector4(0, V.y, V.x, V.y); }
inline Vector4 Swizz_YXZ(Vector4 V){ return MkVector4(0, V.y, V.x, V.z); }
inline Vector4 Swizz_YXW(Vector4 V){ return MkVector4(0, V.y, V.x, V.w); }
inline Vector4 Swizz_YX_(Vector4 V){ return MkVector4(0, V.y, V.x, 0); }
inline Vector4 Swizz_YYX(Vector4 V){ return MkVector4(0, V.y, V.y, V.x); }
inline Vector4 Swizz_YYY(Vector4 V){ return MkVector4(0, V.y, V.y, V.y); }
inline Vector4 Swizz_YYZ(Vector4 V){ return MkVector4(0, V.y, V.y, V.z); }
inline Vector4 Swizz_YYW(Vector4 V){ return MkVector4(0, V.y, V.y, V.w); }
inline Vector4 Swizz_YY_(Vector4 V){ return MkVector4(0, V.y, V.y, 0); }
inline Vector4 Swizz_YZX(Vector4 V){ return MkVector4(0, V.y, V.z, V.x); }
inline Vector4 Swizz_YZY(Vector4 V){ return MkVector4(0, V.y, V.z, V.y); }
inline Vector4 Swizz_YZZ(Vector4 V){ return MkVector4(0, V.y, V.z, V.z); }
inline Vector4 Swizz_YZW(Vector4 V){ return MkVector4(0, V.y, V.z, V.w); }
inline Vector4 Swizz_YZ_(Vector4 V){ return MkVector4(0, V.y, V.z, 0); }
inline Vector4 Swizz_YWX(Vector4 V){ return MkVector4(0, V.y, V.w, V.x); }
inline Vector4 Swizz_YWY(Vector4 V){ return MkVector4(0, V.y, V.w, V.y); }
inline Vector4 Swizz_YWZ(Vector4 V){ return MkVector4(0, V.y, V.w, V.z); }
inline Vector4 Swizz_YWW(Vector4 V){ return MkVector4(0, V.y, V.w, V.w); }
inline Vector4 Swizz_YW_(Vector4 V){ return MkVector4(0, V.y, V.w, 0); }
inline Vector4 Swizz_Y_X(Vector4 V){ return MkVector4(0, V.y, 0, V.x); }
inline Vector4 Swizz_Y_Y(Vector4 V){ return MkVector4(0, V.y, 0, V.y); }
inline Vector4 Swizz_Y_Z(Vector4 V){ return MkVector4(0, V.y, 0, V.z); }
inline Vector4 Swizz_Y_W(Vector4 V){ return MkVector4(0, V.y, 0, V.w); }
inline Vector4 Swizz_Y__(Vector4 V){ return MkVector4(0, V.y, 0, 0); }
inline Vector4 Swizz_ZXX(Vector4 V){ return MkVector4(0, V.z, V.x, V.x); }
inline Vector4 Swizz_ZXY(Vector4 V){ return MkVector4(0, V.z, V.x, V.y); }
inline Vector4 Swizz_ZXZ(Vector4 V){ return MkVector4(0, V.z, V.x, V.z); }
inline Vector4 Swizz_ZXW(Vector4 V){ return MkVector4(0, V.z, V.x, V.w); }
inline Vector4 Swizz_ZX_(Vector4 V){ return MkVector4(0, V.z, V.x, 0); }
inline Vector4 Swizz_ZYX(Vector4 V){ return MkVector4(0, V.z, V.y, V.x); }
inline Vector4 Swizz_ZYY(Vector4 V){ return MkVector4(0, V.z, V.y, V.y); }
inline Vector4 Swizz_ZYZ(Vector4 V){ return MkVector4(0, V.z, V.y, V.z); }
inline Vector4 Swizz_ZYW(Vector4 V){ return MkVector4(0, V.z, V.y, V.w); }
inline Vector4 Swizz_ZY_(Vector4 V){ return MkVector4(0, V.z, V.y, 0); }
inline Vector4 Swizz_ZZX(Vector4 V){ return MkVector4(0, V.z, V.z, V.x); }
inline Vector4 Swizz_ZZY(Vector4 V){ return MkVector4(0, V.z, V.z, V.y); }
inline Vector4 Swizz_ZZZ(Vector4 V){ return MkVector4(0, V.z, V.z, V.z); }
inline Vector4 Swizz_ZZW(Vector4 V){ return MkVector4(0, V.z, V.z, V.w); }
inline Vector4 Swizz_ZZ_(Vector4 V){ return MkVector4(0, V.z, V.z, 0); }
inline Vector4 Swizz_ZWX(Vector4 V){ return MkVector4(0, V.z, V.w, V.x); }
inline Vector4 Swizz_ZWY(Vector4 V){ return MkVector4(0, V.z, V.w, V.y); }
inline Vector4 Swizz_ZWZ(Vector4 V){ return MkVector4(0, V.z, V.w, V.z); }
inline Vector4 Swizz_ZWW(Vector4 V){ return MkVector4(0, V.z, V.w, V.w); }
inline Vector4 Swizz_ZW_(Vector4 V){ return MkVector4(0, V.z, V.w, 0); }
inline Vector4 Swizz_Z_X(Vector4 V){ return MkVector4(0, V.z, 0, V.x); }
inline Vector4 Swizz_Z_Y(Vector4 V){ return MkVector4(0, V.z, 0, V.y); }
inline Vector4 Swizz_Z_Z(Vector4 V){ return MkVector4(0, V.z, 0, V.z); }
inline Vector4 Swizz_Z_W(Vector4 V){ return MkVector4(0, V.z, 0, V.w); }
inline Vector4 Swizz_Z__(Vector4 V){ return MkVector4(0, V.z, 0, 0); }
inline Vector4 Swizz_WXX(Vector4 V){ return MkVector4(0, V.w, V.x, V.x); }
inline Vector4 Swizz_WXY(Vector4 V){ return MkVector4(0, V.w, V.x, V.y); }
inline Vector4 Swizz_WXZ(Vector4 V){ return MkVector4(0, V.w, V.x, V.z); }
inline Vector4 Swizz_WXW(Vector4 V){ return MkVector4(0, V.w, V.x, V.w); }
inline Vector4 Swizz_WX_(Vector4 V){ return MkVector4(0, V.w, V.x, 0); }
inline Vector4 Swizz_WYX(Vector4 V){ return MkVector4(0, V.w, V.y, V.x); }
inline Vector4 Swizz_WYY(Vector4 V){ return MkVector4(0, V.w, V.y, V.y); }
inline Vector4 Swizz_WYZ(Vector4 V){ return MkVector4(0, V.w, V.y, V.z); }
inline Vector4 Swizz_WYW(Vector4 V){ return MkVector4(0, V.w, V.y, V.w); }
inline Vector4 Swizz_WY_(Vector4 V){ return MkVector4(0, V.w, V.y, 0); }
inline Vector4 Swizz_WZX(Vector4 V){ return MkVector4(0, V.w, V.z, V.x); }
inline Vector4 Swizz_WZY(Vector4 V){ return MkVector4(0, V.w, V.z, V.y); }
inline Vector4 Swizz_WZZ(Vector4 V){ return MkVector4(0, V.w, V.z, V.z); }
inline Vector4 Swizz_WZW(Vector4 V){ return MkVector4(0, V.w, V.z, V.w); }
inline Vector4 Swizz_WZ_(Vector4 V){ return MkVector4(0, V.w, V.z, 0); }
inline Vector4 Swizz_WWX(Vector4 V){ return MkVector4(0, V.w, V.w, V.x); }
inline Vector4 Swizz_WWY(Vector4 V){ return MkVector4(0, V.w, V.w, V.y); }
inline Vector4 Swizz_WWZ(Vector4 V){ return MkVector4(0, V.w, V.w, V.z); }
inline Vector4 Swizz_WWW(Vector4 V){ return MkVector4(0, V.w, V.w, V.w); }
inline Vector4 Swizz_WW_(Vector4 V){ return MkVector4(0, V.w, V.w, 0); }
inline Vector4 Swizz_W_X(Vector4 V){ return MkVector4(0, V.w, 0, V.x); }
inline Vector4 Swizz_W_Y(Vector4 V){ return MkVector4(0, V.w, 0, V.y); }
inline Vector4 Swizz_W_Z(Vector4 V){ return MkVector4(0, V.w, 0, V.z); }
inline Vector4 Swizz_W_W(Vector4 V){ return MkVector4(0, V.w, 0, V.w); }
inline Vector4 Swizz_W__(Vector4 V){ return MkVector4(0, V.w, 0, 0); }
inline Vector4 Swizz__XX(Vector4 V){ return MkVector4(0, 0, V.x, V.x); }
inline Vector4 Swizz__XY(Vector4 V){ return MkVector4(0, 0, V.x, V.y); }
inline Vector4 Swizz__XZ(Vector4 V){ return MkVector4(0, 0, V.x, V.z); }
inline Vector4 Swizz__XW(Vector4 V){ return MkVector4(0, 0, V.x, V.w); }
inline Vector4 Swizz__X_(Vector4 V){ return MkVector4(0, 0, V.x, 0); }
inline Vector4 Swizz__YX(Vector4 V){ return MkVector4(0, 0, V.y, V.x); }
inline Vector4 Swizz__YY(Vector4 V){ return MkVector4(0, 0, V.y, V.y); }
inline Vector4 Swizz__YZ(Vector4 V){ return MkVector4(0, 0, V.y, V.z); }
inline Vector4 Swizz__YW(Vector4 V){ return MkVector4(0, 0, V.y, V.w); }
inline Vector4 Swizz__Y_(Vector4 V){ return MkVector4(0, 0, V.y, 0); }
inline Vector4 Swizz__ZX(Vector4 V){ return MkVector4(0, 0, V.z, V.x); }
inline Vector4 Swizz__ZY(Vector4 V){ return MkVector4(0, 0, V.z, V.y); }
inline Vector4 Swizz__ZZ(Vector4 V){ return MkVector4(0, 0, V.z, V.z); }
inline Vector4 Swizz__ZW(Vector4 V){ return MkVector4(0, 0, V.z, V.w); }
inline Vector4 Swizz__Z_(Vector4 V){ return MkVector4(0, 0, V.z, 0); }
inline Vector4 Swizz__WX(Vector4 V){ return MkVector4(0, 0, V.w, V.x); }
inline Vector4 Swizz__WY(Vector4 V){ return MkVector4(0, 0, V.w, V.y); }
inline Vector4 Swizz__WZ(Vector4 V){ return MkVector4(0, 0, V.w, V.z); }
inline Vector4 Swizz__WW(Vector4 V){ return MkVector4(0, 0, V.w, V.w); }
inline Vector4 Swizz__W_(Vector4 V){ return MkVector4(0, 0, V.w, 0); }
inline Vector4 Swizz___X(Vector4 V){ return MkVector4(0, 0, 0, V.x); }
inline Vector4 Swizz___Y(Vector4 V){ return MkVector4(0, 0, 0, V.y); }
inline Vector4 Swizz___Z(Vector4 V){ return MkVector4(0, 0, 0, V.z); }
inline Vector4 Swizz___W(Vector4 V){ return MkVector4(0, 0, 0, V.w); }
#define UNITY_VECTORS
#endif