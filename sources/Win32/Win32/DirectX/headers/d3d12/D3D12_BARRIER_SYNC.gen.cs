// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC"]/*'/>
public enum D3D12_BARRIER_SYNC
{
    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_NONE"]/*'/>

    D3D12_BARRIER_SYNC_NONE = 0,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_ALL"]/*'/>

    D3D12_BARRIER_SYNC_ALL = 0x1,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_DRAW"]/*'/>

    D3D12_BARRIER_SYNC_DRAW = 0x2,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_INPUT_ASSEMBLER"]/*'/>

    D3D12_BARRIER_SYNC_INPUT_ASSEMBLER = 0x4,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_VERTEX_SHADING"]/*'/>

    D3D12_BARRIER_SYNC_VERTEX_SHADING = 0x8,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_PIXEL_SHADING"]/*'/>

    D3D12_BARRIER_SYNC_PIXEL_SHADING = 0x10,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_DEPTH_STENCIL"]/*'/>

    D3D12_BARRIER_SYNC_DEPTH_STENCIL = 0x20,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_RENDER_TARGET"]/*'/>

    D3D12_BARRIER_SYNC_RENDER_TARGET = 0x40,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_COMPUTE_SHADING"]/*'/>

    D3D12_BARRIER_SYNC_COMPUTE_SHADING = 0x80,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_RAYTRACING"]/*'/>

    D3D12_BARRIER_SYNC_RAYTRACING = 0x100,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_COPY"]/*'/>

    D3D12_BARRIER_SYNC_COPY = 0x200,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_RESOLVE"]/*'/>

    D3D12_BARRIER_SYNC_RESOLVE = 0x400,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_EXECUTE_INDIRECT"]/*'/>

    D3D12_BARRIER_SYNC_EXECUTE_INDIRECT = 0x800,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_PREDICATION"]/*'/>

    D3D12_BARRIER_SYNC_PREDICATION = 0x800,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_ALL_SHADING"]/*'/>

    D3D12_BARRIER_SYNC_ALL_SHADING = 0x1000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_NON_PIXEL_SHADING"]/*'/>

    D3D12_BARRIER_SYNC_NON_PIXEL_SHADING = 0x2000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO"]/*'/>

    D3D12_BARRIER_SYNC_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO = 0x4000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_CLEAR_UNORDERED_ACCESS_VIEW"]/*'/>

    D3D12_BARRIER_SYNC_CLEAR_UNORDERED_ACCESS_VIEW = 0x8000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_VIDEO_DECODE"]/*'/>

    D3D12_BARRIER_SYNC_VIDEO_DECODE = 0x100000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_VIDEO_PROCESS"]/*'/>

    D3D12_BARRIER_SYNC_VIDEO_PROCESS = 0x200000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_VIDEO_ENCODE"]/*'/>

    D3D12_BARRIER_SYNC_VIDEO_ENCODE = 0x400000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_BUILD_RAYTRACING_ACCELERATION_STRUCTURE"]/*'/>

    D3D12_BARRIER_SYNC_BUILD_RAYTRACING_ACCELERATION_STRUCTURE = 0x800000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_COPY_RAYTRACING_ACCELERATION_STRUCTURE"]/*'/>

    D3D12_BARRIER_SYNC_COPY_RAYTRACING_ACCELERATION_STRUCTURE = 0x1000000,

    /// <include file='D3D12_BARRIER_SYNC.xml' path='doc/member[@name="D3D12_BARRIER_SYNC.D3D12_BARRIER_SYNC_SPLIT"]/*'/>

    D3D12_BARRIER_SYNC_SPLIT = unchecked((int)(0x80000000)),
}
