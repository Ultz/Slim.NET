// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION"]/*'/>
public enum D3D_MIN_PRECISION
{
    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_DEFAULT"]/*'/>

    D3D_MIN_PRECISION_DEFAULT = 0,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_FLOAT_16"]/*'/>

    D3D_MIN_PRECISION_FLOAT_16 = 1,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_FLOAT_2_8"]/*'/>

    D3D_MIN_PRECISION_FLOAT_2_8 = 2,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_RESERVED"]/*'/>

    D3D_MIN_PRECISION_RESERVED = 3,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_SINT_16"]/*'/>

    D3D_MIN_PRECISION_SINT_16 = 4,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_UINT_16"]/*'/>

    D3D_MIN_PRECISION_UINT_16 = 5,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_ANY_16"]/*'/>

    D3D_MIN_PRECISION_ANY_16 = 0xf0,

    /// <include file='D3D_MIN_PRECISION.xml' path='doc/member[@name="D3D_MIN_PRECISION.D3D_MIN_PRECISION_ANY_10"]/*'/>

    D3D_MIN_PRECISION_ANY_10 = 0xf1,
}
