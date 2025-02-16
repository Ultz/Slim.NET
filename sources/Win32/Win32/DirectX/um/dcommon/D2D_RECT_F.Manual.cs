// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D_RECT_F : IEquatable<D2D_RECT_F>
{
    public static ref readonly D2D_RECT_F Infinite
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0xFF,
                0x7F,
                0xFF,
                0xFF,
                0xFF,
                0x7F,
                0xFF,
                0xFF,
                0xFF,
                0x7F,
                0x7F,
                0xFF,
                0xFF,
                0x7F,
                0x7F,
            ];
            return ref Unsafe.As<byte, D2D_RECT_F>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D2D_RECT_F(float left = 0.0f, float top = 0.0f, float right = 0.0f, float bottom = 0.0f)
    {
        this.left = left;
        this.top = top;
        this.right = right;
        this.bottom = bottom;
    }

    public static bool operator ==(
        [NativeTypeName("const D2D1_RECT_F &")] in D2D_RECT_F l,
        [NativeTypeName("const D2D1_RECT_F &")] in D2D_RECT_F r
    )
    {
        return (l.left == r.left)
            && (l.top == r.top)
            && (l.right == r.right)
            && (l.bottom == r.bottom);
    }

    public static bool operator !=(
        [NativeTypeName("const D2D1_RECT_F &")] in D2D_RECT_F l,
        [NativeTypeName("const D2D1_RECT_F &")] in D2D_RECT_F r
    ) => !(l == r);

    public readonly bool Equals(D2D_RECT_F other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is D2D_RECT_F other) && this == other;

    public override readonly int GetHashCode() => HashCode.Combine(left, top, right, bottom);
}
