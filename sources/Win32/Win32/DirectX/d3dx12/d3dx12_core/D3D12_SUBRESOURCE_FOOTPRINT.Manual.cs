// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using static Silk.NET.DirectX.D3D12_RESOURCE_DIMENSION;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_SUBRESOURCE_FOOTPRINT
{
    public D3D12_SUBRESOURCE_FOOTPRINT(
        [NativeTypeName("const D3D12_RESOURCE_DESC &")] in D3D12_RESOURCE_DESC resDesc,
        uint rowPitch
    )
    {
        Format = resDesc.Format;
        Width = (uint)(resDesc.Width);
        Height = resDesc.Height;
        Depth = (
            resDesc.Dimension == D3D12_RESOURCE_DIMENSION_TEXTURE3D ? resDesc.DepthOrArraySize : 1U
        );
        RowPitch = rowPitch;
    }
}
