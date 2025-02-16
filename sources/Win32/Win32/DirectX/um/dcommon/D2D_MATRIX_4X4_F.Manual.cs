// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License._d in the repository root for more information.
// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D2D_MATRIX_4X4_F : IEquatable<D2D_MATRIX_4X4_F>
{
    public D2D_MATRIX_4X4_F(
        float m11,
        float m12,
        float m13,
        float m14,
        float m21,
        float m22,
        float m23,
        float m24,
        float m31,
        float m32,
        float m33,
        float m34,
        float m41,
        float m42,
        float m43,
        float m44
    )
    {
        Unsafe.SkipInit(out this);
        _11 = m11;
        _12 = m12;
        _13 = m13;
        _14 = m14;
        _21 = m21;
        _22 = m22;
        _23 = m23;
        _24 = m24;
        _31 = m31;
        _32 = m32;
        _33 = m33;
        _34 = m34;
        _41 = m41;
        _42 = m42;
        _43 = m43;
        _44 = m44;
    }

    public static ref readonly D2D_MATRIX_4X4_F Identity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x80,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D_MATRIX_4X4_F>());
            return ref Unsafe.As<byte, D2D_MATRIX_4X4_F>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static bool operator ==(
        [NativeTypeName("const D2D1_MATRIX_4X4_F &")] in D2D_MATRIX_4X4_F l,
        [NativeTypeName("const D2D1_MATRIX_4X4_F &")] in D2D_MATRIX_4X4_F r
    )
    {
        return (l._11 == r._11)
            && (l._12 == r._12)
            && (l._13 == r._13)
            && (l._14 == r._14)
            && (l._21 == r._21)
            && (l._22 == r._22)
            && (l._23 == r._23)
            && (l._24 == r._24)
            && (l._31 == r._31)
            && (l._32 == r._32)
            && (l._33 == r._33)
            && (l._34 == r._34)
            && (l._41 == r._41)
            && (l._42 == r._42)
            && (l._43 == r._43)
            && (l._44 == r._44);
    }

    public static bool operator !=(
        [NativeTypeName("const D2D1_MATRIX_4X4_F &")] in D2D_MATRIX_4X4_F l,
        [NativeTypeName("const D2D1_MATRIX_4X4_F &")] in D2D_MATRIX_4X4_F r
    ) => !(l == r);

    public float Determinant
    {
        get
        {
            float minor1 =
                _41
                * (
                    _12 * (_23 * _34 - _33 * _24)
                    - _13 * (_22 * _34 - _24 * _32)
                    + _14 * (_22 * _33 - _23 * _32)
                );
            float minor2 =
                _42
                * (
                    _11 * (_21 * _34 - _31 * _24)
                    - _13 * (_21 * _34 - _24 * _31)
                    + _14 * (_21 * _33 - _23 * _31)
                );
            float minor3 =
                _43
                * (
                    _11 * (_22 * _34 - _32 * _24)
                    - _12 * (_21 * _34 - _24 * _31)
                    + _14 * (_21 * _32 - _22 * _31)
                );
            float minor4 =
                _44
                * (
                    _11 * (_22 * _33 - _32 * _23)
                    - _12 * (_21 * _33 - _23 * _31)
                    + _13 * (_21 * _32 - _22 * _31)
                );
            return minor1 - minor2 + minor3 - minor4;
        }
    }
    public bool IsIdentity
    {
        get
        {
            return (_11 == 1.0f)
                && (_12 == 0.0f)
                && (_13 == 0.0f)
                && (_14 == 0.0f)
                && (_21 == 0.0f)
                && (_22 == 1.0f)
                && (_23 == 0.0f)
                && (_24 == 0.0f)
                && (_31 == 0.0f)
                && (_32 == 0.0f)
                && (_33 == 1.0f)
                && (_34 == 0.0f)
                && (_41 == 0.0f)
                && (_42 == 0.0f)
                && (_43 == 0.0f)
                && (_44 == 1.0f);
        }
    }

    public static D2D_MATRIX_4X4_F operator *(
        [NativeTypeName("const D2D1_MATRIX_4x4_F &")] in D2D_MATRIX_4X4_F a,
        [NativeTypeName("const D2D1_MATRIX_4x4_F &")] in D2D_MATRIX_4X4_F b
    )
    {
        D2D_MATRIX_4X4_F result = default;
        result.SetProduct(a, b);
        return result;
    }

    public readonly bool Equals(D2D_MATRIX_4X4_F other) => this == other;

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_MATRIX_4X4_F other) && this == other;

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        {
            hashCode.Add(_11);
            hashCode.Add(_12);
            hashCode.Add(_13);
            hashCode.Add(_14);
            hashCode.Add(_21);
            hashCode.Add(_22);
            hashCode.Add(_23);
            hashCode.Add(_24);
            hashCode.Add(_31);
            hashCode.Add(_32);
            hashCode.Add(_33);
            hashCode.Add(_34);
            hashCode.Add(_41);
            hashCode.Add(_42);
            hashCode.Add(_43);
            hashCode.Add(_44);
        }
        return hashCode.ToHashCode();
    }

    public static D2D_MATRIX_4X4_F PerspectiveProjection(float depth)
    {
        float proj = 0;
        if (depth > 0)
        {
            proj = -1 / depth;
        }
        D2D_MATRIX_4X4_F projection = new D2D_MATRIX_4X4_F(
            1,
            0,
            0,
            0,
            0,
            1,
            0,
            0,
            0,
            0,
            1,
            proj,
            0,
            0,
            0,
            1
        );
        return projection;
    }

    public static D2D_MATRIX_4X4_F RotationArbitraryAxis(float x, float y, float z, float degree)
    {
        float magnitude = D2D1Vec3Length(x, y, z);
        x /= magnitude;
        y /= magnitude;
        z /= magnitude;
        float angleInRadian = degree * (3.141592654f / 180.0f);
        float sinAngle = 0.0f;
        float cosAngle = 0.0f;
        D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);
        float oneMinusCosAngle = 1 - cosAngle;
        D2D_MATRIX_4X4_F rotationArb = new D2D_MATRIX_4X4_F(
            1 + oneMinusCosAngle * (x * x - 1),
            z * sinAngle + oneMinusCosAngle * x * y,
            -y * sinAngle + oneMinusCosAngle * x * z,
            0,
            -z * sinAngle + oneMinusCosAngle * y * x,
            1 + oneMinusCosAngle * (y * y - 1),
            x * sinAngle + oneMinusCosAngle * y * z,
            0,
            y * sinAngle + oneMinusCosAngle * z * x,
            -x * sinAngle + oneMinusCosAngle * z * y,
            1 + oneMinusCosAngle * (z * z - 1),
            0,
            0,
            0,
            0,
            1
        );
        return rotationArb;
    }

    public static D2D_MATRIX_4X4_F RotationX(float degreeX)
    {
        float angleInRadian = degreeX * (MathF.PI / 180.0f);
        float sinAngle = 0.0f;
        float cosAngle = 0.0f;
        D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);
        D2D_MATRIX_4X4_F rotationX = new D2D_MATRIX_4X4_F(
            1,
            0,
            0,
            0,
            0,
            cosAngle,
            sinAngle,
            0,
            0,
            -sinAngle,
            cosAngle,
            0,
            0,
            0,
            0,
            1
        );
        return rotationX;
    }

    public static D2D_MATRIX_4X4_F RotationY(float degreeY)
    {
        float angleInRadian = degreeY * (MathF.PI / 180.0f);
        float sinAngle = 0.0f;
        float cosAngle = 0.0f;
        D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);
        D2D_MATRIX_4X4_F rotationY = new D2D_MATRIX_4X4_F(
            cosAngle,
            0,
            -sinAngle,
            0,
            0,
            1,
            0,
            0,
            sinAngle,
            0,
            cosAngle,
            0,
            0,
            0,
            0,
            1
        );
        return rotationY;
    }

    public static D2D_MATRIX_4X4_F RotationZ(float degreeZ)
    {
        float angleInRadian = degreeZ * (MathF.PI / 180.0f);
        float sinAngle = 0.0f;
        float cosAngle = 0.0f;
        D2D1SinCos(angleInRadian, &sinAngle, &cosAngle);
        D2D_MATRIX_4X4_F rotationZ = new D2D_MATRIX_4X4_F(
            cosAngle,
            sinAngle,
            0,
            0,
            -sinAngle,
            cosAngle,
            0,
            0,
            0,
            0,
            1,
            0,
            0,
            0,
            0,
            1
        );
        return rotationZ;
    }

    public static D2D_MATRIX_4X4_F Scale(float x, float y, float z)
    {
        D2D_MATRIX_4X4_F scale = default;
        scale._11 = x;
        scale._12 = 0.0f;
        scale._13 = 0.0f;
        scale._14 = 0.0f;
        scale._21 = 0.0f;
        scale._22 = y;
        scale._23 = 0.0f;
        scale._24 = 0.0f;
        scale._31 = 0.0f;
        scale._32 = 0.0f;
        scale._33 = z;
        scale._34 = 0.0f;
        scale._41 = 0.0f;
        scale._42 = 0.0f;
        scale._43 = 0.0f;
        scale._44 = 1.0f;
        return scale;
    }

    public void SetProduct(
        [NativeTypeName("const D2D1_MATRIX_4x4_F &")] in D2D_MATRIX_4X4_F a,
        [NativeTypeName("const D2D1_MATRIX_4x4_F &")] in D2D_MATRIX_4X4_F b
    )
    {
        _11 = a._11 * b._11 + a._12 * b._21 + a._13 * b._31 + a._14 * b._41;
        _12 = a._11 * b._12 + a._12 * b._22 + a._13 * b._32 + a._14 * b._42;
        _13 = a._11 * b._13 + a._12 * b._23 + a._13 * b._33 + a._14 * b._43;
        _14 = a._11 * b._14 + a._12 * b._24 + a._13 * b._34 + a._14 * b._44;
        _21 = a._21 * b._11 + a._22 * b._21 + a._23 * b._31 + a._24 * b._41;
        _22 = a._21 * b._12 + a._22 * b._22 + a._23 * b._32 + a._24 * b._42;
        _23 = a._21 * b._13 + a._22 * b._23 + a._23 * b._33 + a._24 * b._43;
        _24 = a._21 * b._14 + a._22 * b._24 + a._23 * b._34 + a._24 * b._44;
        _31 = a._31 * b._11 + a._32 * b._21 + a._33 * b._31 + a._34 * b._41;
        _32 = a._31 * b._12 + a._32 * b._22 + a._33 * b._32 + a._34 * b._42;
        _33 = a._31 * b._13 + a._32 * b._23 + a._33 * b._33 + a._34 * b._43;
        _34 = a._31 * b._14 + a._32 * b._24 + a._33 * b._34 + a._34 * b._44;
        _41 = a._41 * b._11 + a._42 * b._21 + a._43 * b._31 + a._44 * b._41;
        _42 = a._41 * b._12 + a._42 * b._22 + a._43 * b._32 + a._44 * b._42;
        _43 = a._41 * b._13 + a._42 * b._23 + a._43 * b._33 + a._44 * b._43;
        _44 = a._41 * b._14 + a._42 * b._24 + a._43 * b._34 + a._44 * b._44;
    }

    public static D2D_MATRIX_4X4_F SkewX(float degreeX)
    {
        float angleInRadian = degreeX * (3.141592654f / 180.0f);
        float tanAngle = D2D1Tan(angleInRadian);
        D2D_MATRIX_4X4_F skewX = new D2D_MATRIX_4X4_F(
            1,
            0,
            0,
            0,
            tanAngle,
            1,
            0,
            0,
            0,
            0,
            1,
            0,
            0,
            0,
            0,
            1
        );
        return skewX;
    }

    public static D2D_MATRIX_4X4_F SkewY(float degreeY)
    {
        float angleInRadian = degreeY * (3.141592654f / 180.0f);
        float tanAngle = D2D1Tan(angleInRadian);
        D2D_MATRIX_4X4_F skewY = new D2D_MATRIX_4X4_F(
            1,
            tanAngle,
            0,
            0,
            0,
            1,
            0,
            0,
            0,
            0,
            1,
            0,
            0,
            0,
            0,
            1
        );
        return skewY;
    }

    public static D2D_MATRIX_4X4_F Translation(float x, float y, float z)
    {
        D2D_MATRIX_4X4_F translation = default;
        translation._11 = 1.0f;
        translation._12 = 0.0f;
        translation._13 = 0.0f;
        translation._14 = 0.0f;
        translation._21 = 0.0f;
        translation._22 = 1.0f;
        translation._23 = 0.0f;
        translation._24 = 0.0f;
        translation._31 = 0.0f;
        translation._32 = 0.0f;
        translation._33 = 1.0f;
        translation._34 = 0.0f;
        translation._41 = x;
        translation._42 = y;
        translation._43 = z;
        translation._44 = 1.0f;
        return translation;
    }
}
