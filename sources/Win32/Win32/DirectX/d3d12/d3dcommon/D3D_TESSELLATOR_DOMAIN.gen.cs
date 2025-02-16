// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN"]/*'/>
public enum D3D_TESSELLATOR_DOMAIN
{
    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_UNDEFINED"]/*'/>

    D3D_TESSELLATOR_DOMAIN_UNDEFINED = 0,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_ISOLINE"]/*'/>

    D3D_TESSELLATOR_DOMAIN_ISOLINE = 1,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_TRI"]/*'/>

    D3D_TESSELLATOR_DOMAIN_TRI = 2,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D_TESSELLATOR_DOMAIN_QUAD"]/*'/>

    D3D_TESSELLATOR_DOMAIN_QUAD = 3,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_UNDEFINED"]/*'/>

    D3D11_TESSELLATOR_DOMAIN_UNDEFINED = D3D_TESSELLATOR_DOMAIN_UNDEFINED,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_ISOLINE"]/*'/>

    D3D11_TESSELLATOR_DOMAIN_ISOLINE = D3D_TESSELLATOR_DOMAIN_ISOLINE,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_TRI"]/*'/>

    D3D11_TESSELLATOR_DOMAIN_TRI = D3D_TESSELLATOR_DOMAIN_TRI,

    /// <include file='D3D_TESSELLATOR_DOMAIN.xml' path='doc/member[@name="D3D_TESSELLATOR_DOMAIN.D3D11_TESSELLATOR_DOMAIN_QUAD"]/*'/>

    D3D11_TESSELLATOR_DOMAIN_QUAD = D3D_TESSELLATOR_DOMAIN_QUAD,
}
