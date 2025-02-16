// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License._d in the repository root for more information.
// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D_MATRIX_4X3_F : IEquatable<D2D_MATRIX_4X3_F>
{
    public D2D_MATRIX_4X3_F(
        float m11,
        float m12,
        float m13,
        float m21,
        float m22,
        float m23,
        float m31,
        float m32,
        float m33,
        float m41,
        float m42,
        float m43
    )
    {
        Unsafe.SkipInit(out this);
        _11 = m11;
        _12 = m12;
        _13 = m13;
        _21 = m21;
        _22 = m22;
        _23 = m23;
        _31 = m31;
        _32 = m32;
        _33 = m33;
        _41 = m41;
        _42 = m42;
        _43 = m43;
    }

    public static ref readonly D2D_MATRIX_4X3_F Identity
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
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D_MATRIX_4X3_F>());
            return ref Unsafe.As<byte, D2D_MATRIX_4X3_F>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static bool operator ==(
        [NativeTypeName("const D2D_MATRIX_4X3_F &")] in D2D_MATRIX_4X3_F l,
        [NativeTypeName("const D2D_MATRIX_4X3_F &")] in D2D_MATRIX_4X3_F r
    )
    {
        return (l._11 == r._11)
            && (l._12 == r._12)
            && (l._13 == r._13)
            && (l._21 == r._21)
            && (l._22 == r._22)
            && (l._23 == r._23)
            && (l._31 == r._31)
            && (l._32 == r._32)
            && (l._33 == r._33)
            && (l._41 == r._41)
            && (l._42 == r._42)
            && (l._43 == r._43);
    }

    public static bool operator !=(
        [NativeTypeName("const D2D_MATRIX_4X3_F &")] in D2D_MATRIX_4X3_F l,
        [NativeTypeName("const D2D_MATRIX_4X3_F &")] in D2D_MATRIX_4X3_F r
    ) => !(l == r);

    public readonly bool Equals(D2D_MATRIX_4X3_F other) => this == other;

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_MATRIX_4X3_F other) && this == other;

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        {
            hashCode.Add(_11);
            hashCode.Add(_12);
            hashCode.Add(_13);
            hashCode.Add(_21);
            hashCode.Add(_22);
            hashCode.Add(_23);
            hashCode.Add(_31);
            hashCode.Add(_32);
            hashCode.Add(_33);
            hashCode.Add(_41);
            hashCode.Add(_42);
            hashCode.Add(_43);
        }
        return hashCode.ToHashCode();
    }
}
