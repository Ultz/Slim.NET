// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_TEX2D_UAV.xml' path='doc/member[@name="D3D12_TEX2D_UAV"]/*'/>
public partial struct D3D12_TEX2D_UAV
{
    /// <include file='D3D12_TEX2D_UAV.xml' path='doc/member[@name="D3D12_TEX2D_UAV.MipSlice"]/*'/>

    public uint MipSlice;

    /// <include file='D3D12_TEX2D_UAV.xml' path='doc/member[@name="D3D12_TEX2D_UAV.PlaneSlice"]/*'/>

    public uint PlaneSlice;
}
