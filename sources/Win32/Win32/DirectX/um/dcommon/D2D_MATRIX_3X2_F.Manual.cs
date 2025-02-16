// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D2D_MATRIX_3X2_F : IEquatable<D2D_MATRIX_3X2_F>
{
    public D2D_MATRIX_3X2_F(float m11, float m12, float m21, float m22, float dx, float dy)
    {
        Unsafe.SkipInit(out this);
        this.m11 = m11;
        this.m12 = m12;
        this.m21 = m21;
        this.m22 = m22;
        this.dx = dx;
        this.dy = dy;
    }

    public static ref readonly D2D_MATRIX_3X2_F Identity
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
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D_MATRIX_3X2_F>());
            return ref Unsafe.As<byte, D2D_MATRIX_3X2_F>(ref MemoryMarshal.GetReference(data));
        }
    }
    public readonly float Determinant =>
        (Anonymous.Anonymous1.m11 * Anonymous.Anonymous1.m22)
        - (Anonymous.Anonymous1.m12 * Anonymous.Anonymous1.m21);
    public readonly bool IsInvertible
    {
        get
        {
            fixed (D2D_MATRIX_3X2_F* matrix = &this)
            {
                return D2D1IsMatrixInvertible(matrix) != 0;
            }
        }
    }
    public readonly bool IsIdentity
    {
        get
        {
            return (Anonymous.Anonymous1.m11 == 1.0f)
                && (Anonymous.Anonymous1.m12 == 0.0f)
                && (Anonymous.Anonymous1.m21 == 0.0f)
                && (Anonymous.Anonymous1.m22 == 1.0f)
                && (Anonymous.Anonymous1.dx == 0.0f)
                && (Anonymous.Anonymous1.dy == 0.0f);
        }
    }

    public static D2D_MATRIX_3X2_F operator *(
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F a,
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F b
    )
    {
        D2D_MATRIX_3X2_F result = default;
        result.SetProduct(a, b);
        return result;
    }

    public static D2D_POINT_2F operator *(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point,
        [NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F matrix
    ) => matrix.TransformPoint(point);

    public static bool operator ==(D2D_MATRIX_3X2_F l, D2D_MATRIX_3X2_F r)
    {
        return (l.m11 == r.m11)
            && (l.m12 == r.m12)
            && (l.m21 == r.m21)
            && (l.m22 == r.m22)
            && (l.dx == r.dx)
            && (l.dy == r.dy);
    }

    public static bool operator !=(D2D_MATRIX_3X2_F l, D2D_MATRIX_3X2_F r) => !(l == r);

    public readonly bool Equals(D2D_MATRIX_3X2_F other) => this == other;

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_MATRIX_3X2_F other) && this == other;

    public override int GetHashCode() => HashCode.Combine(m11, m12, m21, m22, dx, dy);

    public bool Invert()
    {
        fixed (D2D_MATRIX_3X2_F* matrix = &this)
        {
            return D2D1InvertMatrix(matrix) != 0;
        }
    }

    public static D2D_MATRIX_3X2_F Rotation(float angle, D2D_POINT_2F center = default)
    {
        D2D_MATRIX_3X2_F rotation;
        D2D1MakeRotateMatrix(angle, center, &rotation);
        return rotation;
    }

    public static D2D_MATRIX_3X2_F Scale(
        [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F size,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center = default
    )
    {
        D2D_MATRIX_3X2_F scale = default;
        scale.m11 = size.width;
        scale.m12 = 0.0f;
        scale.m21 = 0.0f;
        scale.m22 = size.height;
        scale.dx = center.x - size.width * center.x;
        scale.dy = center.y - size.height * center.y;
        return scale;
    }

    public static D2D_MATRIX_3X2_F Scale(
        float x,
        float y,
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center = default
    )
    {
        return Scale(new D2D_SIZE_F(x, y), center);
    }

    public void SetProduct(
        [NativeTypeName("const D2D1_MATRIX_3X2 &")] in D2D_MATRIX_3X2_F a,
        [NativeTypeName("const D2D1_MATRIX_3X2 &")] in D2D_MATRIX_3X2_F b
    )
    {
        m11 = (a.m11 * b.m11) + (a.m12 * b.m21);
        m12 = (a.m11 * b.m12) + (a.m12 * b.m22);
        m21 = (a.m21 * b.m11) + (a.m22 * b.m21);
        m22 = (a.m21 * b.m12) + (a.m22 * b.m22);
        dx = (a.dx * b.m11) + (a.dy * b.m21) + b.dx;
        dy = (a.dx * b.m12) + (a.dy * b.m22) + b.dy;
    }

    public static D2D_MATRIX_3X2_F Skew(float angleX, float angleY, D2D_POINT_2F center = default)
    {
        D2D_MATRIX_3X2_F skew;
        D2D1MakeSkewMatrix(angleX, angleY, center, &skew);
        return skew;
    }

    public readonly D2D_POINT_2F TransformPoint(
        [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point
    )
    {
        D2D_POINT_2F result = new D2D_POINT_2F
        {
            x =
                (point.x * Anonymous.Anonymous1.m11)
                + (point.y * Anonymous.Anonymous1.m21)
                + Anonymous.Anonymous1.dx,
            y =
                (point.x * Anonymous.Anonymous1.m12)
                + (point.y * Anonymous.Anonymous1.m22)
                + Anonymous.Anonymous1.dy,
        };
        return result;
    }

    public static D2D_MATRIX_3X2_F Translation([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F size)
    {
        D2D_MATRIX_3X2_F translation = default;
        translation.m11 = 1.0f;
        translation.m12 = 0.0f;
        translation.m21 = 0.0f;
        translation.m22 = 1.0f;
        translation.dx = size.width;
        translation.dy = size.height;
        return translation;
    }

    public static D2D_MATRIX_3X2_F Translation(float x, float y)
    {
        return Translation(new D2D_SIZE_F(x, y));
    }
}
