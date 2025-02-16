// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE"]/*'/>
public enum D3D_INCLUDE_TYPE
{
    /// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE.D3D_INCLUDE_LOCAL"]/*'/>

    D3D_INCLUDE_LOCAL = 0,

    /// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE.D3D_INCLUDE_SYSTEM"]/*'/>

    D3D_INCLUDE_SYSTEM = (D3D_INCLUDE_LOCAL + 1),

    /// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE.D3D10_INCLUDE_LOCAL"]/*'/>

    D3D10_INCLUDE_LOCAL = D3D_INCLUDE_LOCAL,

    /// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE.D3D10_INCLUDE_SYSTEM"]/*'/>

    D3D10_INCLUDE_SYSTEM = D3D_INCLUDE_SYSTEM,

    /// <include file='D3D_INCLUDE_TYPE.xml' path='doc/member[@name="D3D_INCLUDE_TYPE.D3D_INCLUDE_FORCE_DWORD"]/*'/>

    D3D_INCLUDE_FORCE_DWORD = 0x7fffffff,
}
