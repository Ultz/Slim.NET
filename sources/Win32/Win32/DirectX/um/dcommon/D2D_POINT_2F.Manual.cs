// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D2D_POINT_2F : IEquatable<D2D_POINT_2F>
{
    public D2D_POINT_2F(float x = 0.0f, float y = 0.0f)
    {
        this.x = x;
        this.y = y;
    }

    public static bool operator ==(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F l,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F r
    )
    {
        return (l.x == r.x) && (l.y == r.y);
    }

    public static bool operator !=(
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F l,
        [NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F r
    ) => !(l == r);

    public readonly bool Equals(D2D_POINT_2F other) => this == other;

    public override readonly bool Equals(object? obj) =>
        (obj is D2D_POINT_2F other) && this == other;

    public override readonly int GetHashCode() => HashCode.Combine(x, y);
}
