// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.D3D_SRV_DIMENSION;
using static Silk.NET.DirectX.DXGI_FORMAT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D11_SHADER_RESOURCE_VIEW_DESC
{
    public D3D11_SHADER_RESOURCE_VIEW_DESC(
        D3D_SRV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        uint flags = 0
    )
    {
        Format = format;
        ViewDimension = viewDimension;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3D11_SRV_DIMENSION_BUFFER:
            {
                Anonymous.Buffer.Anonymous1.FirstElement = mostDetailedMip;
                Anonymous.Buffer.Anonymous2.NumElements = mipLevels;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE1D:
            {
                Anonymous.Texture1D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1D.MipLevels = mipLevels;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE1DARRAY:
            {
                Anonymous.Texture1DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1DArray.MipLevels = mipLevels;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE2D:
            {
                Anonymous.Texture2D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2D.MipLevels = mipLevels;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE2DARRAY:
            {
                Anonymous.Texture2DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2DArray.MipLevels = mipLevels;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE2DMS:
            {
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY:
            {
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE3D:
            {
                Anonymous.Texture3D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture3D.MipLevels = mipLevels;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURECUBE:
            {
                Anonymous.TextureCube.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCube.MipLevels = mipLevels;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURECUBEARRAY:
            {
                Anonymous.TextureCubeArray.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCubeArray.MipLevels = mipLevels;
                Anonymous.TextureCubeArray.First2DArrayFace = firstArraySlice;
                Anonymous.TextureCubeArray.NumCubes = arraySize;
                break;
            }
            case D3D11_SRV_DIMENSION_BUFFEREX:
            {
                Anonymous.BufferEx.FirstElement = mostDetailedMip;
                Anonymous.BufferEx.NumElements = mipLevels;
                Anonymous.BufferEx.Flags = flags;
                break;
            }
            default:
            {
                break;
            }
        }
    }

    public D3D11_SHADER_RESOURCE_VIEW_DESC(
        ID3D11Buffer param0,
        DXGI_FORMAT format,
        uint firstElement,
        uint numElements,
        uint flags = 0
    )
    {
        Format = format;
        ViewDimension = D3D11_SRV_DIMENSION_BUFFEREX;
        Anonymous = default;
        Anonymous.BufferEx.FirstElement = firstElement;
        Anonymous.BufferEx.NumElements = numElements;
        Anonymous.BufferEx.Flags = flags;
    }

    public D3D11_SHADER_RESOURCE_VIEW_DESC(
        ID3D11Texture1D pTex1D,
        D3D_SRV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1)
    )
    {
        ViewDimension = viewDimension;
        if (
            (DXGI_FORMAT_UNKNOWN == format)
            || (unchecked((uint)-1) == mipLevels)
            || (
                (unchecked((uint)-1) == arraySize)
                && (D3D11_SRV_DIMENSION_TEXTURE1DARRAY == viewDimension)
            )
        )
        {
            D3D11_TEXTURE1D_DESC TexDesc;
            pTex1D.GetDesc(&TexDesc);
            if (DXGI_FORMAT_UNKNOWN == format)
            {
                format = TexDesc.Format;
            }
            if (unchecked((uint)-1) == mipLevels)
            {
                mipLevels = TexDesc.MipLevels - mostDetailedMip;
            }
            if (unchecked((uint)-1) == arraySize)
            {
                arraySize = TexDesc.ArraySize - firstArraySlice;
            }
        }
        Format = format;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3D11_SRV_DIMENSION_TEXTURE1D:
            {
                Anonymous.Texture1D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1D.MipLevels = mipLevels;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE1DARRAY:
            {
                Anonymous.Texture1DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture1DArray.MipLevels = mipLevels;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            }
            default:
            {
                break;
            }
        }
    }

    public D3D11_SHADER_RESOURCE_VIEW_DESC(
        ID3D11Texture2D pTex2D,
        D3D_SRV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1),
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1)
    )
    {
        ViewDimension = viewDimension;
        if (
            (DXGI_FORMAT_UNKNOWN == format)
            || (
                (unchecked((uint)-1) == mipLevels)
                && (D3D11_SRV_DIMENSION_TEXTURE2DMS != viewDimension)
                && (D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY != viewDimension)
            )
            || (
                (unchecked((uint)-1) == arraySize)
                && (
                    (D3D11_SRV_DIMENSION_TEXTURE2DARRAY == viewDimension)
                    || (D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY == viewDimension)
                    || (D3D11_SRV_DIMENSION_TEXTURECUBEARRAY == viewDimension)
                )
            )
        )
        {
            D3D11_TEXTURE2D_DESC TexDesc;
            pTex2D.GetDesc(&TexDesc);
            if (DXGI_FORMAT_UNKNOWN == format)
            {
                format = TexDesc.Format;
            }
            if (unchecked((uint)-1) == mipLevels)
            {
                mipLevels = TexDesc.MipLevels - mostDetailedMip;
            }
            if (unchecked((uint)-1) == arraySize)
            {
                arraySize = TexDesc.ArraySize - firstArraySlice;
                if (D3D11_SRV_DIMENSION_TEXTURECUBEARRAY == viewDimension)
                {
                    arraySize /= 6;
                }
            }
        }
        Format = format;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3D11_SRV_DIMENSION_TEXTURE2D:
            {
                Anonymous.Texture2D.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2D.MipLevels = mipLevels;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE2DARRAY:
            {
                Anonymous.Texture2DArray.MostDetailedMip = mostDetailedMip;
                Anonymous.Texture2DArray.MipLevels = mipLevels;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE2DMS:
            {
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURE2DMSARRAY:
            {
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURECUBE:
            {
                Anonymous.TextureCube.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCube.MipLevels = mipLevels;
                break;
            }
            case D3D11_SRV_DIMENSION_TEXTURECUBEARRAY:
            {
                Anonymous.TextureCubeArray.MostDetailedMip = mostDetailedMip;
                Anonymous.TextureCubeArray.MipLevels = mipLevels;
                Anonymous.TextureCubeArray.First2DArrayFace = firstArraySlice;
                Anonymous.TextureCubeArray.NumCubes = arraySize;
                break;
            }
            default:
            {
                break;
            }
        }
    }

    public D3D11_SHADER_RESOURCE_VIEW_DESC(
        ID3D11Texture3D pTex3D,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mostDetailedMip = 0,
        uint mipLevels = unchecked((uint)-1)
    )
    {
        ViewDimension = D3D11_SRV_DIMENSION_TEXTURE3D;
        if ((DXGI_FORMAT_UNKNOWN == format) || (unchecked((uint)-1) == mipLevels))
        {
            D3D11_TEXTURE3D_DESC TexDesc;
            pTex3D.GetDesc(&TexDesc);
            if (DXGI_FORMAT_UNKNOWN == format)
            {
                format = TexDesc.Format;
            }
            if (unchecked((uint)-1) == mipLevels)
            {
                mipLevels = TexDesc.MipLevels - mostDetailedMip;
            }
        }
        Format = format;
        Anonymous = default;
        Anonymous.Texture3D.MostDetailedMip = mostDetailedMip;
        Anonymous.Texture3D.MipLevels = mipLevels;
    }
}
