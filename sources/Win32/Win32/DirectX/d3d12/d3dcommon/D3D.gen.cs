// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3D
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D_TEXTURE_LAYOUT_ROW_MAJOR
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0x23,
                0xDC,
                0xB5,
                0xBB,
                0x72,
                0xEC,
                0x4B,
                0x97,
                0x05,
                0x8C,
                0xF2,
                0x58,
                0xDF,
                0x6B,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x29,
                0x0F,
                0x4C,
                0x5F,
                0x3F,
                0x35,
                0x4D,
                0x84,
                0xC9,
                0xBC,
                0x09,
                0x83,
                0xB6,
                0x2C,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION 2048")]
    public const int D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION = 2048;

    [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION 4096")]
    public const int D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION = 4096;

    [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION 2048")]
    public const int D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION = 2048;

    [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION 4096")]
    public const int D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION = 4096;

    [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION 512")]
    public const int D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION = 512;

    [NativeTypeName("#define D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION 4096")]
    public const int D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION = 4096;

    [NativeTypeName("#define D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION 256")]
    public const int D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = 256;

    [NativeTypeName("#define D3D_FL9_1_DEFAULT_MAX_ANISOTROPY 2")]
    public const int D3D_FL9_1_DEFAULT_MAX_ANISOTROPY = 2;

    [NativeTypeName("#define D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT 65535")]
    public const int D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT = 65535;

    [NativeTypeName("#define D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT 1048575")]
    public const int D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT = 1048575;

    [NativeTypeName("#define D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT 1")]
    public const int D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT = 1;

    [NativeTypeName("#define D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT 4")]
    public const int D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT = 4;

    [NativeTypeName("#define D3D_FL9_1_MAX_TEXTURE_REPEAT 128")]
    public const int D3D_FL9_1_MAX_TEXTURE_REPEAT = 128;

    [NativeTypeName("#define D3D_FL9_2_MAX_TEXTURE_REPEAT 2048")]
    public const int D3D_FL9_2_MAX_TEXTURE_REPEAT = 2048;

    [NativeTypeName("#define D3D_FL9_3_MAX_TEXTURE_REPEAT 8192")]
    public const int D3D_FL9_3_MAX_TEXTURE_REPEAT = 8192;

    [NativeTypeName("#define D3D_SHADER_FEATURE_DOUBLES 0x00001")]
    public const int D3D_SHADER_FEATURE_DOUBLES = 0x00001;

    [NativeTypeName(
        "#define D3D_SHADER_FEATURE_COMPUTE_SHADERS_PLUS_RAW_AND_STRUCTURED_BUFFERS_VIA_SHADER_4_X 0x00002"
    )]
    public const int D3D_SHADER_FEATURE_COMPUTE_SHADERS_PLUS_RAW_AND_STRUCTURED_BUFFERS_VIA_SHADER_4_X =
        0x00002;

    [NativeTypeName("#define D3D_SHADER_FEATURE_UAVS_AT_EVERY_STAGE 0x00004")]
    public const int D3D_SHADER_FEATURE_UAVS_AT_EVERY_STAGE = 0x00004;

    [NativeTypeName("#define D3D_SHADER_FEATURE_64_UAVS 0x00008")]
    public const int D3D_SHADER_FEATURE_64_UAVS = 0x00008;

    [NativeTypeName("#define D3D_SHADER_FEATURE_MINIMUM_PRECISION 0x00010")]
    public const int D3D_SHADER_FEATURE_MINIMUM_PRECISION = 0x00010;

    [NativeTypeName("#define D3D_SHADER_FEATURE_11_1_DOUBLE_EXTENSIONS 0x00020")]
    public const int D3D_SHADER_FEATURE_11_1_DOUBLE_EXTENSIONS = 0x00020;

    [NativeTypeName("#define D3D_SHADER_FEATURE_11_1_SHADER_EXTENSIONS 0x00040")]
    public const int D3D_SHADER_FEATURE_11_1_SHADER_EXTENSIONS = 0x00040;

    [NativeTypeName("#define D3D_SHADER_FEATURE_LEVEL_9_COMPARISON_FILTERING 0x00080")]
    public const int D3D_SHADER_FEATURE_LEVEL_9_COMPARISON_FILTERING = 0x00080;

    [NativeTypeName("#define D3D_SHADER_FEATURE_TILED_RESOURCES 0x00100")]
    public const int D3D_SHADER_FEATURE_TILED_RESOURCES = 0x00100;

    [NativeTypeName("#define D3D_SHADER_FEATURE_STENCIL_REF 0x00200")]
    public const int D3D_SHADER_FEATURE_STENCIL_REF = 0x00200;

    [NativeTypeName("#define D3D_SHADER_FEATURE_INNER_COVERAGE 0x00400")]
    public const int D3D_SHADER_FEATURE_INNER_COVERAGE = 0x00400;

    [NativeTypeName("#define D3D_SHADER_FEATURE_TYPED_UAV_LOAD_ADDITIONAL_FORMATS 0x00800")]
    public const int D3D_SHADER_FEATURE_TYPED_UAV_LOAD_ADDITIONAL_FORMATS = 0x00800;

    [NativeTypeName("#define D3D_SHADER_FEATURE_ROVS 0x01000")]
    public const int D3D_SHADER_FEATURE_ROVS = 0x01000;

    [NativeTypeName(
        "#define D3D_SHADER_FEATURE_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER 0x02000"
    )]
    public const int D3D_SHADER_FEATURE_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER =
        0x02000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_WAVE_OPS 0x04000")]
    public const int D3D_SHADER_FEATURE_WAVE_OPS = 0x04000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_INT64_OPS 0x08000")]
    public const int D3D_SHADER_FEATURE_INT64_OPS = 0x08000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_VIEW_ID 0x10000")]
    public const int D3D_SHADER_FEATURE_VIEW_ID = 0x10000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_BARYCENTRICS 0x20000")]
    public const int D3D_SHADER_FEATURE_BARYCENTRICS = 0x20000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_NATIVE_16BIT_OPS 0x40000")]
    public const int D3D_SHADER_FEATURE_NATIVE_16BIT_OPS = 0x40000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_SHADING_RATE 0x80000")]
    public const int D3D_SHADER_FEATURE_SHADING_RATE = 0x80000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_RAYTRACING_TIER_1_1 0x100000")]
    public const int D3D_SHADER_FEATURE_RAYTRACING_TIER_1_1 = 0x100000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_SAMPLER_FEEDBACK 0x200000")]
    public const int D3D_SHADER_FEATURE_SAMPLER_FEEDBACK = 0x200000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_ATOMIC_INT64_ON_TYPED_RESOURCE 0x400000")]
    public const int D3D_SHADER_FEATURE_ATOMIC_INT64_ON_TYPED_RESOURCE = 0x400000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_ATOMIC_INT64_ON_GROUP_SHARED 0x800000")]
    public const int D3D_SHADER_FEATURE_ATOMIC_INT64_ON_GROUP_SHARED = 0x800000;

    [NativeTypeName(
        "#define D3D_SHADER_FEATURE_DERIVATIVES_IN_MESH_AND_AMPLIFICATION_SHADERS 0x1000000"
    )]
    public const int D3D_SHADER_FEATURE_DERIVATIVES_IN_MESH_AND_AMPLIFICATION_SHADERS = 0x1000000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_RESOURCE_DESCRIPTOR_HEAP_INDEXING 0x2000000")]
    public const int D3D_SHADER_FEATURE_RESOURCE_DESCRIPTOR_HEAP_INDEXING = 0x2000000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_SAMPLER_DESCRIPTOR_HEAP_INDEXING 0x4000000")]
    public const int D3D_SHADER_FEATURE_SAMPLER_DESCRIPTOR_HEAP_INDEXING = 0x4000000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_WAVE_MMA 0x8000000")]
    public const int D3D_SHADER_FEATURE_WAVE_MMA = 0x8000000;

    [NativeTypeName(
        "#define D3D_SHADER_FEATURE_ATOMIC_INT64_ON_DESCRIPTOR_HEAP_RESOURCE 0x10000000"
    )]
    public const int D3D_SHADER_FEATURE_ATOMIC_INT64_ON_DESCRIPTOR_HEAP_RESOURCE = 0x10000000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_ADVANCED_TEXTURE_OPS 0x20000000")]
    public const int D3D_SHADER_FEATURE_ADVANCED_TEXTURE_OPS = 0x20000000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_WRITEABLE_MSAA_TEXTURES 0x40000000")]
    public const int D3D_SHADER_FEATURE_WRITEABLE_MSAA_TEXTURES = 0x40000000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_SAMPLE_CMP_GRADIENT_OR_BIAS 0x80000000")]
    public const uint D3D_SHADER_FEATURE_SAMPLE_CMP_GRADIENT_OR_BIAS = 0x80000000;

    [NativeTypeName("#define D3D_SHADER_FEATURE_EXTENDED_COMMAND_INFO 0x100000000ull")]
    public const ulong D3D_SHADER_FEATURE_EXTENDED_COMMAND_INFO = 0x100000000UL;

    [NativeTypeName("#define D3D_OPT_SHADER_FEATURE_USES_DERIVATIVES 0x0000010000000000ull")]
    public const ulong D3D_OPT_SHADER_FEATURE_USES_DERIVATIVES = 0x0000010000000000UL;

    [NativeTypeName("#define D3D_OPT_SHADER_FEATURE_REQUIRES_GROUP 0x0000020000000000ull")]
    public const ulong D3D_OPT_SHADER_FEATURE_REQUIRES_GROUP = 0x0000020000000000UL;

    [NativeTypeName("#define D3D_COMPONENT_MASK_X 1")]
    public const int D3D_COMPONENT_MASK_X = 1;

    [NativeTypeName("#define D3D_COMPONENT_MASK_Y 2")]
    public const int D3D_COMPONENT_MASK_Y = 2;

    [NativeTypeName("#define D3D_COMPONENT_MASK_Z 4")]
    public const int D3D_COMPONENT_MASK_Z = 4;

    [NativeTypeName("#define D3D_COMPONENT_MASK_W 8")]
    public const int D3D_COMPONENT_MASK_W = 8;
}
