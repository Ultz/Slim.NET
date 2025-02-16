// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public partial struct SIZE : IEquatable<SIZE>
{
    public SIZE([NativeTypeName("INT32")] int cx = 0, [NativeTypeName("INT32")] int cy = 0)
    {
        this.cx = cx;
        this.cy = cy;
    }

    public static bool operator ==(
        [NativeTypeName("const SIZE &")] in SIZE l,
        [NativeTypeName("const SIZE &")] in SIZE r
    )
    {
        return (l.cx == r.cx) && (l.cy == r.cy);
    }

    public static bool operator !=(
        [NativeTypeName("const SIZE &")] in SIZE l,
        [NativeTypeName("const SIZE &")] in SIZE r
    ) => !(l == r);

    public override readonly bool Equals(object? obj) => (obj is SIZE other) && Equals(other);

    public readonly bool Equals(SIZE other) => this == other;

    public override readonly int GetHashCode() => HashCode.Combine(cx, cy);
}
