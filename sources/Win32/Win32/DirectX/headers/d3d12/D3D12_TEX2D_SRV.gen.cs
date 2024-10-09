// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_TEX2D_SRV.xml' path='doc/member[@name="D3D12_TEX2D_SRV"]/*'/>
public partial struct D3D12_TEX2D_SRV
{
    /// <include file='D3D12_TEX2D_SRV.xml' path='doc/member[@name="D3D12_TEX2D_SRV.MostDetailedMip"]/*'/>

    public uint MostDetailedMip;

    /// <include file='D3D12_TEX2D_SRV.xml' path='doc/member[@name="D3D12_TEX2D_SRV.MipLevels"]/*'/>

    public uint MipLevels;

    /// <include file='D3D12_TEX2D_SRV.xml' path='doc/member[@name="D3D12_TEX2D_SRV.PlaneSlice"]/*'/>

    public uint PlaneSlice;

    /// <include file='D3D12_TEX2D_SRV.xml' path='doc/member[@name="D3D12_TEX2D_SRV.ResourceMinLODClamp"]/*'/>

    public float ResourceMinLODClamp;
}
