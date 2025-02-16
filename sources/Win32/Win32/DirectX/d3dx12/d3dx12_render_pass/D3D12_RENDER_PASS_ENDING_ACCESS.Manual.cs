// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
using static Silk.NET.DirectX.D3D12_RENDER_PASS_ENDING_ACCESS_TYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_RENDER_PASS_ENDING_ACCESS : IEquatable<D3D12_RENDER_PASS_ENDING_ACCESS>
{
    public static bool operator ==(
        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS &")]
            in D3D12_RENDER_PASS_ENDING_ACCESS a,
        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS &")]
            in D3D12_RENDER_PASS_ENDING_ACCESS b
    )
    {
        if (a.Type != b.Type)
        {
            return false;
        }
        switch (a.Type)
        {
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_RESOLVE:
            {
                if (a.Anonymous.Resolve != b.Anonymous.Resolve)
                {
                    return false;
                }
                break;
            }
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_RENDER:
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_SRV:
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_UAV:
            {
                if (a.Anonymous.PreserveLocal != b.Anonymous.PreserveLocal)
                {
                    return false;
                }
                break;
            }
        }
        return true;
    }

    public static bool operator !=(
        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS &")]
            in D3D12_RENDER_PASS_ENDING_ACCESS a,
        [NativeTypeName("const D3D12_RENDER_PASS_ENDING_ACCESS &")]
            in D3D12_RENDER_PASS_ENDING_ACCESS b
    ) => !(a == b);

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12_RENDER_PASS_ENDING_ACCESS other) && Equals(other);

    public readonly bool Equals(D3D12_RENDER_PASS_ENDING_ACCESS other) => this == other;

    public override readonly int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(Type);
        switch (Type)
        {
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_RESOLVE:
            {
                hashCode.Add(Anonymous.Resolve);
                break;
            }
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_RENDER:
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_SRV:
            case D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE_LOCAL_UAV:
            {
                hashCode.Add(Anonymous.PreserveLocal);
                break;
            }
        }
        return hashCode.ToHashCode();
    }
}
