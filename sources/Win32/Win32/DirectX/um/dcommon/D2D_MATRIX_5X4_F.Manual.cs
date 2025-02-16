// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D_MATRIX_5X4_F : IEquatable<D2D_MATRIX_5X4_F>
{
    public static ref readonly D2D_MATRIX_5X4_F Identity
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
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D_MATRIX_5X4_F>());
            return ref Unsafe.As<byte, D2D_MATRIX_5X4_F>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D2D_MATRIX_5X4_F(
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
        float m44,
        float m51,
        float m52,
        float m53,
        float m54
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
        _51 = m51;
        _52 = m52;
        _53 = m53;
        _54 = m54;
    }

    public static bool operator ==(
        [NativeTypeName("const D2D1_MATRIX_5X4_F &")] in D2D_MATRIX_5X4_F l,
        [NativeTypeName("const D2D1_MATRIX_5X4_F &")] in D2D_MATRIX_5X4_F r
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
            && (l._44 == r._44)
            && (l._51 == r._51)
            && (l._52 == r._52)
            && (l._53 == r._53)
            && (l._54 == r._54);
    }

    public static bool operator !=(
        [NativeTypeName("const D2D1_MATRIX_5X4_F &")] in D2D_MATRIX_5X4_F l,
        [NativeTypeName("const D2D1_MATRIX_5X4_F &")] in D2D_MATRIX_5X4_F r
    ) => !(l == r);

    public readonly bool Equals(D2D_MATRIX_5X4_F other) => this == other;

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_MATRIX_5X4_F other) && this == other;

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
            hashCode.Add(_51);
            hashCode.Add(_52);
            hashCode.Add(_53);
            hashCode.Add(_54);
        }
        return hashCode.ToHashCode();
    }
}
