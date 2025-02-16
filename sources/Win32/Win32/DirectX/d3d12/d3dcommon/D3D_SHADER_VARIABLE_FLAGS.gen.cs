// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS"]/*'/>
[Flags]
public enum D3D_SHADER_VARIABLE_FLAGS
{
    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D_SVF_USERPACKED"]/*'/>

    D3D_SVF_USERPACKED = 1,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D_SVF_USED"]/*'/>

    D3D_SVF_USED = 2,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D_SVF_INTERFACE_POINTER"]/*'/>

    D3D_SVF_INTERFACE_POINTER = 4,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D_SVF_INTERFACE_PARAMETER"]/*'/>

    D3D_SVF_INTERFACE_PARAMETER = 8,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D10_SVF_USERPACKED"]/*'/>

    D3D10_SVF_USERPACKED = D3D_SVF_USERPACKED,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D10_SVF_USED"]/*'/>

    D3D10_SVF_USED = D3D_SVF_USED,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D11_SVF_INTERFACE_POINTER"]/*'/>

    D3D11_SVF_INTERFACE_POINTER = D3D_SVF_INTERFACE_POINTER,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D11_SVF_INTERFACE_PARAMETER"]/*'/>

    D3D11_SVF_INTERFACE_PARAMETER = D3D_SVF_INTERFACE_PARAMETER,

    /// <include file='D3D_SHADER_VARIABLE_FLAGS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_FLAGS.D3D_SVF_FORCE_DWORD"]/*'/>

    D3D_SVF_FORCE_DWORD = 0x7fffffff,
}
