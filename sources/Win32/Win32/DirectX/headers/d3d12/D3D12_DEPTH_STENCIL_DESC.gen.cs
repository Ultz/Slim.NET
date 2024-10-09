// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC"]/*'/>
public partial struct D3D12_DEPTH_STENCIL_DESC
{
    /// <include file='D3D12_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC.DepthEnable"]/*'/>

    public BOOL DepthEnable;

    /// <include file='D3D12_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC.DepthWriteMask"]/*'/>

    public D3D12_DEPTH_WRITE_MASK DepthWriteMask;

    /// <include file='D3D12_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC.DepthFunc"]/*'/>

    public D3D12_COMPARISON_FUNC DepthFunc;

    /// <include file='D3D12_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC.StencilEnable"]/*'/>

    public BOOL StencilEnable;

    /// <include file='D3D12_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC.StencilReadMask"]/*'/>

    [NativeTypeName("UINT8")]
    public byte StencilReadMask;

    /// <include file='D3D12_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC.StencilWriteMask"]/*'/>

    [NativeTypeName("UINT8")]
    public byte StencilWriteMask;

    /// <include file='D3D12_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC.FrontFace"]/*'/>

    public D3D12_DEPTH_STENCILOP_DESC FrontFace;

    /// <include file='D3D12_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC.BackFace"]/*'/>

    public D3D12_DEPTH_STENCILOP_DESC BackFace;
}
