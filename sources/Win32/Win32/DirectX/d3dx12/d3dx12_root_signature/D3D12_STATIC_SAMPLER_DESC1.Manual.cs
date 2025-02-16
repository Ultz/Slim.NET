// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using static Silk.NET.DirectX.D3D12_COMPARISON_FUNC;
using static Silk.NET.DirectX.D3D12_FILTER;
using static Silk.NET.DirectX.D3D12_SAMPLER_FLAGS;
using static Silk.NET.DirectX.D3D12_SHADER_VISIBILITY;
using static Silk.NET.DirectX.D3D12_STATIC_BORDER_COLOR;
using static Silk.NET.DirectX.D3D12_TEXTURE_ADDRESS_MODE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_STATIC_SAMPLER_DESC1
{
    public D3D12_STATIC_SAMPLER_DESC1(
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC &")] in D3D12_STATIC_SAMPLER_DESC o
    )
    {
        Unsafe.As<D3D12_STATIC_SAMPLER_DESC1, D3D12_STATIC_SAMPLER_DESC>(ref this) = o;
        Flags = D3D12_SAMPLER_FLAG_NONE;
    }

    public D3D12_STATIC_SAMPLER_DESC1(
        uint shaderRegister,
        D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC,
        D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP,
        D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP,
        D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP,
        float mipLODBias = 0,
        uint maxAnisotropy = 16,
        D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL,
        D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE,
        float minLOD = 0.0f,
        float maxLOD = (3.402823466e+38f),
        D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL,
        uint registerSpace = 0,
        D3D12_SAMPLER_FLAGS flags = D3D12_SAMPLER_FLAG_NONE
    )
    {
        Init(
            shaderRegister,
            filter,
            addressU,
            addressV,
            addressW,
            mipLODBias,
            maxAnisotropy,
            comparisonFunc,
            borderColor,
            minLOD,
            maxLOD,
            shaderVisibility,
            registerSpace,
            flags
        );
    }

    public static void Init(
        [NativeTypeName("D3D12_STATIC_SAMPLER_DESC1 &")] ref D3D12_STATIC_SAMPLER_DESC1 samplerDesc,
        uint shaderRegister,
        D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC,
        D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP,
        D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP,
        D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP,
        float mipLODBias = 0,
        uint maxAnisotropy = 16,
        D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL,
        D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE,
        float minLOD = 0.0f,
        float maxLOD = (3.402823466e+38f),
        D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL,
        uint registerSpace = 0,
        D3D12_SAMPLER_FLAGS flags = D3D12_SAMPLER_FLAG_NONE
    )
    {
        samplerDesc.ShaderRegister = shaderRegister;
        samplerDesc.Filter = filter;
        samplerDesc.AddressU = addressU;
        samplerDesc.AddressV = addressV;
        samplerDesc.AddressW = addressW;
        samplerDesc.MipLODBias = mipLODBias;
        samplerDesc.MaxAnisotropy = maxAnisotropy;
        samplerDesc.ComparisonFunc = comparisonFunc;
        samplerDesc.BorderColor = borderColor;
        samplerDesc.MinLOD = minLOD;
        samplerDesc.MaxLOD = maxLOD;
        samplerDesc.ShaderVisibility = shaderVisibility;
        samplerDesc.RegisterSpace = registerSpace;
        samplerDesc.Flags = flags;
    }

    public void Init(
        uint shaderRegister,
        D3D12_FILTER filter = D3D12_FILTER_ANISOTROPIC,
        D3D12_TEXTURE_ADDRESS_MODE addressU = D3D12_TEXTURE_ADDRESS_MODE_WRAP,
        D3D12_TEXTURE_ADDRESS_MODE addressV = D3D12_TEXTURE_ADDRESS_MODE_WRAP,
        D3D12_TEXTURE_ADDRESS_MODE addressW = D3D12_TEXTURE_ADDRESS_MODE_WRAP,
        float mipLODBias = 0,
        uint maxAnisotropy = 16,
        D3D12_COMPARISON_FUNC comparisonFunc = D3D12_COMPARISON_FUNC_LESS_EQUAL,
        D3D12_STATIC_BORDER_COLOR borderColor = D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE,
        float minLOD = 0.0f,
        float maxLOD = (3.402823466e+38f),
        D3D12_SHADER_VISIBILITY shaderVisibility = D3D12_SHADER_VISIBILITY_ALL,
        uint registerSpace = 0,
        D3D12_SAMPLER_FLAGS flags = D3D12_SAMPLER_FLAG_NONE
    )
    {
        Init(
            ref this,
            shaderRegister,
            filter,
            addressU,
            addressV,
            addressW,
            mipLODBias,
            maxAnisotropy,
            comparisonFunc,
            borderColor,
            minLOD,
            maxLOD,
            shaderVisibility,
            registerSpace,
            flags
        );
    }
}
