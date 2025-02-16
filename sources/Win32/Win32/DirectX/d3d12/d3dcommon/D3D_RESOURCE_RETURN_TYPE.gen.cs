// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE"]/*'/>
public enum D3D_RESOURCE_RETURN_TYPE
{
    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_UNORM"]/*'/>

    D3D_RETURN_TYPE_UNORM = 1,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_SNORM"]/*'/>

    D3D_RETURN_TYPE_SNORM = 2,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_SINT"]/*'/>

    D3D_RETURN_TYPE_SINT = 3,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_UINT"]/*'/>

    D3D_RETURN_TYPE_UINT = 4,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_FLOAT"]/*'/>

    D3D_RETURN_TYPE_FLOAT = 5,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_MIXED"]/*'/>

    D3D_RETURN_TYPE_MIXED = 6,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_DOUBLE"]/*'/>

    D3D_RETURN_TYPE_DOUBLE = 7,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_CONTINUED"]/*'/>

    D3D_RETURN_TYPE_CONTINUED = 8,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_UNORM"]/*'/>

    D3D10_RETURN_TYPE_UNORM = D3D_RETURN_TYPE_UNORM,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_SNORM"]/*'/>

    D3D10_RETURN_TYPE_SNORM = D3D_RETURN_TYPE_SNORM,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_SINT"]/*'/>

    D3D10_RETURN_TYPE_SINT = D3D_RETURN_TYPE_SINT,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_UINT"]/*'/>

    D3D10_RETURN_TYPE_UINT = D3D_RETURN_TYPE_UINT,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_FLOAT"]/*'/>

    D3D10_RETURN_TYPE_FLOAT = D3D_RETURN_TYPE_FLOAT,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_MIXED"]/*'/>

    D3D10_RETURN_TYPE_MIXED = D3D_RETURN_TYPE_MIXED,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_UNORM"]/*'/>

    D3D11_RETURN_TYPE_UNORM = D3D_RETURN_TYPE_UNORM,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_SNORM"]/*'/>

    D3D11_RETURN_TYPE_SNORM = D3D_RETURN_TYPE_SNORM,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_SINT"]/*'/>

    D3D11_RETURN_TYPE_SINT = D3D_RETURN_TYPE_SINT,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_UINT"]/*'/>

    D3D11_RETURN_TYPE_UINT = D3D_RETURN_TYPE_UINT,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_FLOAT"]/*'/>

    D3D11_RETURN_TYPE_FLOAT = D3D_RETURN_TYPE_FLOAT,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_MIXED"]/*'/>

    D3D11_RETURN_TYPE_MIXED = D3D_RETURN_TYPE_MIXED,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_DOUBLE"]/*'/>

    D3D11_RETURN_TYPE_DOUBLE = D3D_RETURN_TYPE_DOUBLE,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_CONTINUED"]/*'/>

    D3D11_RETURN_TYPE_CONTINUED = D3D_RETURN_TYPE_CONTINUED,
}
