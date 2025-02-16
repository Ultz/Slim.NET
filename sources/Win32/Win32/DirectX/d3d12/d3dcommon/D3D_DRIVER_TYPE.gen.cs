// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE"]/*'/>
public enum D3D_DRIVER_TYPE
{
    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_UNKNOWN"]/*'/>

    D3D_DRIVER_TYPE_UNKNOWN = 0,

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE"]/*'/>

    D3D_DRIVER_TYPE_HARDWARE = (D3D_DRIVER_TYPE_UNKNOWN + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_REFERENCE"]/*'/>

    D3D_DRIVER_TYPE_REFERENCE = (D3D_DRIVER_TYPE_HARDWARE + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_NULL"]/*'/>

    D3D_DRIVER_TYPE_NULL = (D3D_DRIVER_TYPE_REFERENCE + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_SOFTWARE"]/*'/>

    D3D_DRIVER_TYPE_SOFTWARE = (D3D_DRIVER_TYPE_NULL + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_WARP"]/*'/>

    D3D_DRIVER_TYPE_WARP = (D3D_DRIVER_TYPE_SOFTWARE + 1),
}
