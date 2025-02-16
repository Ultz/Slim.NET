// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS"]/*'/>
public enum D3D_SHADER_VARIABLE_CLASS
{
    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_SCALAR"]/*'/>

    D3D_SVC_SCALAR = 0,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_VECTOR"]/*'/>

    D3D_SVC_VECTOR = (D3D_SVC_SCALAR + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_MATRIX_ROWS"]/*'/>

    D3D_SVC_MATRIX_ROWS = (D3D_SVC_VECTOR + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_MATRIX_COLUMNS"]/*'/>

    D3D_SVC_MATRIX_COLUMNS = (D3D_SVC_MATRIX_ROWS + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_OBJECT"]/*'/>

    D3D_SVC_OBJECT = (D3D_SVC_MATRIX_COLUMNS + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_STRUCT"]/*'/>

    D3D_SVC_STRUCT = (D3D_SVC_OBJECT + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_INTERFACE_CLASS"]/*'/>

    D3D_SVC_INTERFACE_CLASS = (D3D_SVC_STRUCT + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_INTERFACE_POINTER"]/*'/>

    D3D_SVC_INTERFACE_POINTER = (D3D_SVC_INTERFACE_CLASS + 1),

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_SCALAR"]/*'/>

    D3D10_SVC_SCALAR = D3D_SVC_SCALAR,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_VECTOR"]/*'/>

    D3D10_SVC_VECTOR = D3D_SVC_VECTOR,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_MATRIX_ROWS"]/*'/>

    D3D10_SVC_MATRIX_ROWS = D3D_SVC_MATRIX_ROWS,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_MATRIX_COLUMNS"]/*'/>

    D3D10_SVC_MATRIX_COLUMNS = D3D_SVC_MATRIX_COLUMNS,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_OBJECT"]/*'/>

    D3D10_SVC_OBJECT = D3D_SVC_OBJECT,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D10_SVC_STRUCT"]/*'/>

    D3D10_SVC_STRUCT = D3D_SVC_STRUCT,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D11_SVC_INTERFACE_CLASS"]/*'/>

    D3D11_SVC_INTERFACE_CLASS = D3D_SVC_INTERFACE_CLASS,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D11_SVC_INTERFACE_POINTER"]/*'/>

    D3D11_SVC_INTERFACE_POINTER = D3D_SVC_INTERFACE_POINTER,

    /// <include file='D3D_SHADER_VARIABLE_CLASS.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_CLASS.D3D_SVC_FORCE_DWORD"]/*'/>

    D3D_SVC_FORCE_DWORD = 0x7fffffff,
}
