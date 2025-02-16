// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS"]/*'/>
[Flags]
public enum D3D_PARAMETER_FLAGS
{
    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_NONE"]/*'/>

    D3D_PF_NONE = 0,

    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_IN"]/*'/>

    D3D_PF_IN = 0x1,

    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_OUT"]/*'/>

    D3D_PF_OUT = 0x2,

    /// <include file='D3D_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D_PARAMETER_FLAGS.D3D_PF_FORCE_DWORD"]/*'/>

    D3D_PF_FORCE_DWORD = 0x7fffffff,
}
