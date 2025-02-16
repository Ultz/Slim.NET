// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
using static Silk.NET.DirectX.D3D12_RESOURCE_DIMENSION;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_VIEWPORT : IEquatable<D3D12_VIEWPORT>
{
    public D3D12_VIEWPORT(
        ID3D12Resource pResource,
        uint mipSlice = 0,
        float topLeftX = 0.0f,
        float topLeftY = 0.0f,
        float minDepth = (0.0f),
        float maxDepth = (1.0f)
    )
    {
        D3D12_RESOURCE_DESC Desc = pResource.GetDesc();
        ulong SubresourceWidth = Desc.Width >> (int)(mipSlice);
        ulong SubresourceHeight = Desc.Height >> (int)(mipSlice);
        switch (Desc.Dimension)
        {
            case D3D12_RESOURCE_DIMENSION_BUFFER:
            {
                TopLeftX = topLeftX;
                TopLeftY = 0.0f;
                Width = (float)(Desc.Width) - topLeftX;
                Height = 1.0f;
                break;
            }
            case D3D12_RESOURCE_DIMENSION_TEXTURE1D:
            {
                TopLeftX = topLeftX;
                TopLeftY = 0.0f;
                Width = ((SubresourceWidth) != 0 ? (float)(SubresourceWidth) : 1.0f) - topLeftX;
                Height = 1.0f;
                break;
            }
            case D3D12_RESOURCE_DIMENSION_TEXTURE2D:
            case D3D12_RESOURCE_DIMENSION_TEXTURE3D:
            {
                TopLeftX = topLeftX;
                TopLeftY = topLeftY;
                Width = ((SubresourceWidth) != 0 ? (float)(SubresourceWidth) : 1.0f) - topLeftX;
                Height = ((SubresourceHeight) != 0 ? (float)(SubresourceHeight) : 1.0f) - topLeftY;
                break;
            }
            case D3D12_RESOURCE_DIMENSION_UNKNOWN:
            default:
            {
                break;
            }
        }
        MinDepth = minDepth;
        MaxDepth = maxDepth;
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.Equals"]/*'/>

    public static bool operator ==(
        [NativeTypeName("const D3D12_VIEWPORT &")] in D3D12_VIEWPORT l,
        [NativeTypeName("const D3D12_VIEWPORT &")] in D3D12_VIEWPORT r
    ) =>
        (l.TopLeftX == r.TopLeftX)
        && (l.TopLeftY == r.TopLeftY)
        && (l.Width == r.Width)
        && (l.Height == r.Height)
        && (l.MinDepth == r.MinDepth)
        && (l.MaxDepth == r.MaxDepth);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.NotEquals"]/*'/>

    public static bool operator !=(
        [NativeTypeName("const D3D12_VIEWPORT &")] in D3D12_VIEWPORT l,
        [NativeTypeName("const D3D12_VIEWPORT &")] in D3D12_VIEWPORT r
    ) => !(l == r);

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12_VIEWPORT other) && Equals(other);

    public readonly bool Equals(D3D12_VIEWPORT other) => (this == other);

    public override readonly int GetHashCode() =>
        HashCode.Combine(TopLeftX, TopLeftY, Width, Height, MinDepth, MaxDepth);
}
