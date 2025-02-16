// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.D3D11_BIND_FLAG;
using static Silk.NET.DirectX.D3D11_TEXTURE_LAYOUT;
using static Silk.NET.DirectX.D3D11_USAGE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D11_TEXTURE2D_DESC1
{
    public D3D11_TEXTURE2D_DESC1(
        DXGI_FORMAT format,
        uint width,
        uint height,
        uint arraySize = 1,
        uint mipLevels = 0,
        uint bindFlags = (uint)D3D11_BIND_SHADER_RESOURCE,
        D3D11_USAGE usage = D3D11_USAGE_DEFAULT,
        uint cpuaccessFlags = 0,
        uint sampleCount = 1,
        uint sampleQuality = 0,
        uint miscFlags = 0,
        D3D11_TEXTURE_LAYOUT textureLayout = D3D11_TEXTURE_LAYOUT_UNDEFINED
    )
    {
        Width = width;
        Height = height;
        MipLevels = mipLevels;
        ArraySize = arraySize;
        Format = format;
        SampleDesc.Count = sampleCount;
        SampleDesc.Quality = sampleQuality;
        Usage = usage;
        BindFlags = bindFlags;
        CPUAccessFlags = cpuaccessFlags;
        MiscFlags = miscFlags;
        TextureLayout = textureLayout;
    }

    public D3D11_TEXTURE2D_DESC1(
        [NativeTypeName("const D3D11_TEXTURE2D_DESC &")] D3D11_TEXTURE2D_DESC* desc,
        D3D11_TEXTURE_LAYOUT textureLayout = D3D11_TEXTURE_LAYOUT_UNDEFINED
    )
    {
        Width = desc->Width;
        Height = desc->Height;
        MipLevels = desc->MipLevels;
        ArraySize = desc->ArraySize;
        Format = desc->Format;
        SampleDesc.Count = desc->SampleDesc.Count;
        SampleDesc.Quality = desc->SampleDesc.Quality;
        Usage = desc->Usage;
        BindFlags = desc->BindFlags;
        CPUAccessFlags = desc->CPUAccessFlags;
        MiscFlags = desc->MiscFlags;
        TextureLayout = textureLayout;
    }
}
