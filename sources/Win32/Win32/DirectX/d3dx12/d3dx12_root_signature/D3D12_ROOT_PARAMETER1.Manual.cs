// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using static Silk.NET.DirectX.D3D12_ROOT_DESCRIPTOR_FLAGS;
using static Silk.NET.DirectX.D3D12_ROOT_PARAMETER_TYPE;
using static Silk.NET.DirectX.D3D12_SHADER_VISIBILITY;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_ROOT_PARAMETER1
{
    public static void InitAsConstantBufferView(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12_ROOT_PARAMETER1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        rootParam.ParameterType = D3D12_ROOT_PARAMETER_TYPE_CBV;
        rootParam.ShaderVisibility = visibility;
        D3D12_ROOT_DESCRIPTOR1.Init(
            ref rootParam.Anonymous.Descriptor,
            shaderRegister,
            registerSpace,
            flags
        );
    }

    public void InitAsConstantBufferView(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        InitAsConstantBufferView(ref this, shaderRegister, registerSpace, flags, visibility);
    }

    public static void InitAsConstants(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12_ROOT_PARAMETER1 rootParam,
        uint num32BitValues,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        rootParam.ParameterType = D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS;
        rootParam.ShaderVisibility = visibility;
        D3D12_ROOT_CONSTANTS.Init(
            ref rootParam.Anonymous.Constants,
            num32BitValues,
            shaderRegister,
            registerSpace
        );
    }

    public void InitAsConstants(
        uint num32BitValues,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        InitAsConstants(ref this, num32BitValues, shaderRegister, registerSpace, visibility);
    }

    public static void InitAsDescriptorTable(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12_ROOT_PARAMETER1 rootParam,
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            D3D12_DESCRIPTOR_RANGE1* pDescriptorRanges,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        rootParam.ParameterType = D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE;
        rootParam.ShaderVisibility = visibility;
        D3D12_ROOT_DESCRIPTOR_TABLE1.Init(
            ref rootParam.Anonymous.DescriptorTable,
            numDescriptorRanges,
            pDescriptorRanges
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void InitAsDescriptorTable(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12_ROOT_PARAMETER1 rootParam,
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            Ref<D3D12_DESCRIPTOR_RANGE1> pDescriptorRanges,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        fixed (D3D12_DESCRIPTOR_RANGE1* __dsl_pDescriptorRanges = pDescriptorRanges)
        {
            InitAsDescriptorTable(
                ref rootParam,
                numDescriptorRanges,
                __dsl_pDescriptorRanges,
                visibility
            );
        }
    }

    public void InitAsDescriptorTable(
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            D3D12_DESCRIPTOR_RANGE1* pDescriptorRanges,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        InitAsDescriptorTable(ref this, numDescriptorRanges, pDescriptorRanges, visibility);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void InitAsDescriptorTable(
        uint numDescriptorRanges,
        [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")]
            Ref<D3D12_DESCRIPTOR_RANGE1> pDescriptorRanges,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        fixed (D3D12_DESCRIPTOR_RANGE1* __dsl_pDescriptorRanges = pDescriptorRanges)
        {
            InitAsDescriptorTable(numDescriptorRanges, __dsl_pDescriptorRanges, visibility);
        }
    }

    public static void InitAsShaderResourceView(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12_ROOT_PARAMETER1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        rootParam.ParameterType = D3D12_ROOT_PARAMETER_TYPE_SRV;
        rootParam.ShaderVisibility = visibility;
        D3D12_ROOT_DESCRIPTOR1.Init(
            ref rootParam.Anonymous.Descriptor,
            shaderRegister,
            registerSpace,
            flags
        );
    }

    public void InitAsShaderResourceView(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        InitAsShaderResourceView(ref this, shaderRegister, registerSpace, flags, visibility);
    }

    public static void InitAsUnorderedAccessView(
        [NativeTypeName("D3D12_ROOT_PARAMETER1 &")] ref D3D12_ROOT_PARAMETER1 rootParam,
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        rootParam.ParameterType = D3D12_ROOT_PARAMETER_TYPE_UAV;
        rootParam.ShaderVisibility = visibility;
        D3D12_ROOT_DESCRIPTOR1.Init(
            ref rootParam.Anonymous.Descriptor,
            shaderRegister,
            registerSpace,
            flags
        );
    }

    public void InitAsUnorderedAccessView(
        uint shaderRegister,
        uint registerSpace = 0,
        D3D12_ROOT_DESCRIPTOR_FLAGS flags = D3D12_ROOT_DESCRIPTOR_FLAG_NONE,
        D3D12_SHADER_VISIBILITY visibility = D3D12_SHADER_VISIBILITY_ALL
    )
    {
        InitAsUnorderedAccessView(ref this, shaderRegister, registerSpace, flags, visibility);
    }
}
