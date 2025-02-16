// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D_SIZE_U : IEquatable<D2D_SIZE_U>
{
    public D2D_SIZE_U(
        [NativeTypeName("UINT32")] uint width = 0,
        [NativeTypeName("UINT32")] uint height = 0
    )
    {
        this.width = width;
        this.height = height;
    }

    public static bool operator ==(
        [NativeTypeName("const D2D1_SIZE_U &")] in D2D_SIZE_U l,
        [NativeTypeName("const D2D1_SIZE_U &")] in D2D_SIZE_U r
    )
    {
        return (l.width == r.width) && (l.height == r.height);
    }

    public static bool operator !=(
        [NativeTypeName("const D2D1_SIZE_U &")] in D2D_SIZE_U l,
        [NativeTypeName("const D2D1_SIZE_U &")] in D2D_SIZE_U r
    ) => !(l == r);

    public readonly bool Equals(D2D_SIZE_U other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is D2D_SIZE_U other) && this == other;

    public override readonly int GetHashCode() => HashCode.Combine(width, height);
}
