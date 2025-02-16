// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_FORMAT_TYPE_LEVEL.xml' path='doc/member[@name="D3D_FORMAT_TYPE_LEVEL"]/*'/>
public enum D3D_FORMAT_TYPE_LEVEL
{
    /// <include file='D3D_FORMAT_TYPE_LEVEL.xml' path='doc/member[@name="D3D_FORMAT_TYPE_LEVEL.D3DFTL_NO_TYPE"]/*'/>

    D3DFTL_NO_TYPE = 0,

    /// <include file='D3D_FORMAT_TYPE_LEVEL.xml' path='doc/member[@name="D3D_FORMAT_TYPE_LEVEL.D3DFTL_PARTIAL_TYPE"]/*'/>

    D3DFTL_PARTIAL_TYPE = -2,

    /// <include file='D3D_FORMAT_TYPE_LEVEL.xml' path='doc/member[@name="D3D_FORMAT_TYPE_LEVEL.D3DFTL_FULL_TYPE"]/*'/>

    D3DFTL_FULL_TYPE = -1,
}
