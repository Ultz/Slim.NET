// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS.xml' path='doc/member[@name="D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS"]/*'/>
public partial struct D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS
{
    /// <include file='D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS.xml' path='doc/member[@name="D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS.ShaderPatchMode"]/*'/>

    public D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE ShaderPatchMode;
}
