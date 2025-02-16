// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
using static Silk.NET.DirectX.D3D12;
using static Silk.NET.DirectX.D3D12_FILTER_REDUCTION_TYPE;
using static Silk.NET.DirectX.D3D12_FILTER_TYPE;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static ref readonly Guid D3D12ComputeOnlyDevices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xAB,
                0xF7,
                0x50,
                0x6D,
                0x4B,
                0x14,
                0x4E,
                0x89,
                0xA5,
                0x5D,
                0x16,
                0xCD,
                0x27,
                0x25,
                0x94,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static D3D12_FILTER_REDUCTION_TYPE D3D12_DECODE_FILTER_REDUCTION(
        D3D12_FILTER D3D12Filter
    ) =>
        (D3D12_FILTER_REDUCTION_TYPE)(
            ((uint)D3D12Filter >> unchecked((int)D3D12_FILTER_REDUCTION_TYPE_SHIFT))
            & D3D12_FILTER_REDUCTION_TYPE_MASK
        );

    public static bool D3D12_DECODE_IS_ANISOTROPIC_FILTER(D3D12_FILTER D3D12Filter)
    {
        return (((uint)D3D12Filter & D3D12_ANISOTROPIC_FILTERING_BIT) != 0)
            && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MIN_FILTER(D3D12Filter))
            && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MAG_FILTER(D3D12Filter))
            && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MIP_FILTER(D3D12Filter));
    }

    public static bool D3D12_DECODE_IS_COMPARISON_FILTER(D3D12_FILTER D3D12Filter) =>
        D3D12_DECODE_FILTER_REDUCTION(D3D12Filter) == D3D12_FILTER_REDUCTION_TYPE_COMPARISON;

    public static D3D12_FILTER_TYPE D3D12_DECODE_MAG_FILTER(D3D12_FILTER D3D12Filter) =>
        (D3D12_FILTER_TYPE)(
            ((uint)D3D12Filter >> unchecked((int)D3D12_MAG_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK
        );

    public static D3D12_FILTER_TYPE D3D12_DECODE_MIN_FILTER(D3D12_FILTER D3D12Filter) =>
        (D3D12_FILTER_TYPE)(
            ((uint)D3D12Filter >> unchecked((int)D3D12_MIN_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK
        );

    public static D3D12_FILTER_TYPE D3D12_DECODE_MIP_FILTER(D3D12_FILTER D3D12Filter) =>
        (D3D12_FILTER_TYPE)(
            ((uint)D3D12Filter >> unchecked((int)D3D12_MIP_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK
        );

    public static D3D12_SHADER_COMPONENT_MAPPING D3D12_DECODE_SHADER_4_COMPONENT_MAPPING(
        int ComponentToExtract,
        uint Mapping
    ) =>
        (D3D12_SHADER_COMPONENT_MAPPING)(
            (Mapping >> (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * ComponentToExtract))
            & D3D12_SHADER_COMPONENT_MAPPING_MASK
        );

    public static D3D12_FILTER D3D12_ENCODE_ANISOTROPIC_FILTER(
        D3D12_FILTER_REDUCTION_TYPE reduction
    ) =>
        (D3D12_FILTER)(
            D3D12_ANISOTROPIC_FILTERING_BIT
            | (uint)D3D12_ENCODE_BASIC_FILTER(
                D3D12_FILTER_TYPE_LINEAR,
                D3D12_FILTER_TYPE_LINEAR,
                D3D12_FILTER_TYPE_LINEAR,
                reduction
            )
        );

    public static D3D12_FILTER D3D12_ENCODE_BASIC_FILTER(
        D3D12_FILTER_TYPE min,
        D3D12_FILTER_TYPE mag,
        D3D12_FILTER_TYPE mip,
        D3D12_FILTER_REDUCTION_TYPE reduction
    )
    {
        return (D3D12_FILTER)(
            (((uint)min & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MIN_FILTER_SHIFT))
            | (((uint)mag & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MAG_FILTER_SHIFT))
            | (((uint)mip & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MIP_FILTER_SHIFT))
            | (
                ((uint)reduction & D3D12_FILTER_REDUCTION_TYPE_MASK)
                << unchecked((int)D3D12_FILTER_REDUCTION_TYPE_SHIFT)
            )
        );
    }

    public static D3D12_FILTER D3D12_ENCODE_MIN_MAG_ANISOTROPIC_MIP_POINT_FILTER(
        D3D12_FILTER_REDUCTION_TYPE reduction
    ) =>
        (D3D12_FILTER)(D3D12_ANISOTROPIC_FILTERING_BIT)
        | D3D12_ENCODE_BASIC_FILTER(
            D3D12_FILTER_TYPE_LINEAR,
            D3D12_FILTER_TYPE_LINEAR,
            D3D12_FILTER_TYPE_POINT,
            reduction
        );

    public static uint D3D12_ENCODE_SHADER_4_COMPONENT_MAPPING(
        D3D12_SHADER_COMPONENT_MAPPING Src0,
        D3D12_SHADER_COMPONENT_MAPPING Src1,
        D3D12_SHADER_COMPONENT_MAPPING Src2,
        D3D12_SHADER_COMPONENT_MAPPING Src3
    )
    {
        return ((uint)Src0 & D3D12_SHADER_COMPONENT_MAPPING_MASK)
            | (
                ((uint)Src1 & D3D12_SHADER_COMPONENT_MAPPING_MASK)
                << unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT)
            )
            | (
                ((uint)Src2 & D3D12_SHADER_COMPONENT_MAPPING_MASK)
                << (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * 2)
            )
            | (
                ((uint)Src3 & D3D12_SHADER_COMPONENT_MAPPING_MASK)
                << (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * 3)
            )
            | D3D12_SHADER_COMPONENT_MAPPING_ALWAYS_SET_BIT_AVOIDING_ZEROMEM_MISTAKES;
    }

    public static uint D3D12_GET_COARSE_SHADING_RATE_X_AXIS(uint x) =>
        (x >> unchecked((int)D3D12_SHADING_RATE_X_AXIS_SHIFT)) & D3D12_SHADING_RATE_VALID_MASK;

    public static uint D3D12_GET_COARSE_SHADING_RATE_Y_AXIS(uint y) =>
        y & D3D12_SHADING_RATE_VALID_MASK;

    public static uint D3D12_MAKE_COARSE_SHADING_RATE(uint x, uint y) =>
        (x << unchecked((int)D3D12_SHADING_RATE_X_AXIS_SHIFT)) | y;

    public static HRESULT D3D12_SET_OBJECT_NAME_A<TD3D12Object>(TD3D12Object* pObject, sbyte* pName)
        where TD3D12Object : unmanaged, ID3D12Object.Native.Interface
    {
        return D3D12_SET_OBJECT_NAME_N_A(pObject, (uint)lstrlenA(pName), pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3D12_SET_OBJECT_NAME_A<TD3D12Object>(
        Ref<TD3D12Object> pObject,
        Ref<sbyte> pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Native.Interface
    {
        fixed (sbyte* __dsl_pName = pName)
        fixed (TD3D12Object* __dsl_pObject = pObject)
        {
            return (HRESULT)D3D12_SET_OBJECT_NAME_A(__dsl_pObject, __dsl_pName);
        }
    }

    public static HRESULT D3D12_SET_OBJECT_NAME_N_A<TD3D12Object>(
        TD3D12Object* pObject,
        uint Chars,
        sbyte* pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Native.Interface
    {
        var guid = WKPDID_D3DDebugObjectName;
        return pObject->SetPrivateData(&guid, Chars, pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3D12_SET_OBJECT_NAME_N_A<TD3D12Object>(
        Ref<TD3D12Object> pObject,
        uint Chars,
        Ref<sbyte> pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Native.Interface
    {
        fixed (sbyte* __dsl_pName = pName)
        fixed (TD3D12Object* __dsl_pObject = pObject)
        {
            return (HRESULT)D3D12_SET_OBJECT_NAME_N_A(__dsl_pObject, Chars, __dsl_pName);
        }
    }

    public static HRESULT D3D12_SET_OBJECT_NAME_N_W<TD3D12Object>(
        TD3D12Object* pObject,
        uint Chars,
        char* pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Native.Interface
    {
        var guid = WKPDID_D3DDebugObjectNameW;
        return pObject->SetPrivateData(&guid, Chars * 2, pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3D12_SET_OBJECT_NAME_N_W<TD3D12Object>(
        Ref<TD3D12Object> pObject,
        uint Chars,
        Ref<char> pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Native.Interface
    {
        fixed (char* __dsl_pName = pName)
        fixed (TD3D12Object* __dsl_pObject = pObject)
        {
            return (HRESULT)D3D12_SET_OBJECT_NAME_N_W(__dsl_pObject, Chars, __dsl_pName);
        }
    }

    public static HRESULT D3D12_SET_OBJECT_NAME_W<TD3D12Object>(TD3D12Object* pObject, char* pName)
        where TD3D12Object : unmanaged, ID3D12Object.Native.Interface
    {
        return D3D12_SET_OBJECT_NAME_N_W(pObject, (uint)lstrlenW(pName), pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3D12_SET_OBJECT_NAME_W<TD3D12Object>(
        Ref<TD3D12Object> pObject,
        Ref<char> pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Native.Interface
    {
        fixed (char* __dsl_pName = pName)
        fixed (TD3D12Object* __dsl_pObject = pObject)
        {
            return (HRESULT)D3D12_SET_OBJECT_NAME_W(__dsl_pObject, __dsl_pName);
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12Reflect"]/*'/>

    public static HRESULT D3D12Reflect(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        ID3D11ShaderReflection* ppReflector
    )
    {
        return D3DReflect(
            pSrcData,
            SrcDataSize,
            __uuidof<ID3D12ShaderReflection.Native>(),
            unchecked((void**)(ppReflector))
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3D12Reflect(
        [NativeTypeName("LPCVOID")] Ref pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        Ref<ID3D11ShaderReflection> ppReflector
    )
    {
        fixed (ID3D11ShaderReflection* __dsl_ppReflector = ppReflector)
        fixed (void* __dsl_pSrcData = pSrcData)
        {
            return (HRESULT)D3D12Reflect(__dsl_pSrcData, SrcDataSize, __dsl_ppReflector);
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12ReflectLibrary"]/*'/>

    public static HRESULT D3D12ReflectLibrary(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        ID3D12LibraryReflection* ppReflector
    )
    {
        return D3DReflectLibrary(
            pSrcData,
            SrcDataSize,
            __uuidof<ID3D12LibraryReflection.Native>(),
            (void**)ppReflector
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3D12ReflectLibrary(
        [NativeTypeName("LPCVOID")] Ref pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        Ref<ID3D12LibraryReflection> ppReflector
    )
    {
        fixed (ID3D12LibraryReflection* __dsl_ppReflector = ppReflector)
        fixed (void* __dsl_pSrcData = pSrcData)
        {
            return (HRESULT)D3D12ReflectLibrary(__dsl_pSrcData, SrcDataSize, __dsl_ppReflector);
        }
    }
}
