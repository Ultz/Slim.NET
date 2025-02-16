// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION"]/*'/>
public enum D3D_FORMAT_COMPONENT_INTERPRETATION
{
    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_TYPELESS"]/*'/>

    D3DFCI_TYPELESS = 0,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_FLOAT"]/*'/>

    D3DFCI_FLOAT = -4,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_SNORM"]/*'/>

    D3DFCI_SNORM = -3,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_UNORM"]/*'/>

    D3DFCI_UNORM = -2,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_SINT"]/*'/>

    D3DFCI_SINT = -1,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_UINT"]/*'/>

    D3DFCI_UINT = 1,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_UNORM_SRGB"]/*'/>

    D3DFCI_UNORM_SRGB = 2,

    /// <include file='D3D_FORMAT_COMPONENT_INTERPRETATION.xml' path='doc/member[@name="D3D_FORMAT_COMPONENT_INTERPRETATION.D3DFCI_BIASED_FIXED_2_8"]/*'/>

    D3DFCI_BIASED_FIXED_2_8 = 3,
}
