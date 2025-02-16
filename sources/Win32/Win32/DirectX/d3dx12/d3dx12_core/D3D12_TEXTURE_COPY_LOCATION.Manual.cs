// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using static Silk.NET.DirectX.D3D12_TEXTURE_COPY_TYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_TEXTURE_COPY_LOCATION
{
    public D3D12_TEXTURE_COPY_LOCATION(
        ID3D12Resource pRes,
        [NativeTypeName("const D3D12_PLACED_SUBRESOURCE_FOOTPRINT &")]
            in D3D12_PLACED_SUBRESOURCE_FOOTPRINT Footprint
    )
    {
        pResource = pRes;
        Type = D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT;
        Anonymous.PlacedFootprint = Footprint;
    }
}
