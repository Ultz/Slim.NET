// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D11_BOX : IEquatable<D3D11_BOX>
{
    public D3D11_BOX(int Left, int Top, int Front, int Right, int Bottom, int Back)
    {
        left = (uint)Left;
        top = (uint)Top;
        front = (uint)Front;
        right = (uint)Right;
        bottom = (uint)Bottom;
        back = (uint)Back;
    }

    public static bool operator ==(D3D11_BOX l, D3D11_BOX r)
    {
        return (l.left == r.left)
            && (l.top == r.top)
            && (l.front == r.front)
            && (l.right == r.right)
            && (l.bottom == r.bottom)
            && (l.back == r.back);
    }

    public static bool operator !=(D3D11_BOX l, D3D11_BOX r) => !(l == r);

    public override readonly bool Equals(object? obj) => (obj is D3D11_BOX other) && Equals(other);

    public readonly bool Equals(D3D11_BOX other) => this == other;

    public override readonly int GetHashCode() =>
        HashCode.Combine(left, top, front, right, bottom, back);
}
