// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.D3D11_DSV_DIMENSION;
using static Silk.NET.DirectX.DXGI_FORMAT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D11_DEPTH_STENCIL_VIEW_DESC
{
    public D3D11_DEPTH_STENCIL_VIEW_DESC(
        D3D11_DSV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        uint flags = 0
    )
    {
        Format = format;
        ViewDimension = viewDimension;
        Flags = flags;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3D11_DSV_DIMENSION_TEXTURE1D:
            {
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            }
            case D3D11_DSV_DIMENSION_TEXTURE1DARRAY:
            {
                Anonymous.Texture1DArray.MipSlice = mipSlice;
                Anonymous.Texture1DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture1DArray.ArraySize = arraySize;
                break;
            }
            case D3D11_DSV_DIMENSION_TEXTURE2D:
            {
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            }
            case D3D11_DSV_DIMENSION_TEXTURE2DARRAY:
            {
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            }
            case D3D11_DSV_DIMENSION_TEXTURE2DMS:
            {
                break;
            }
            case D3D11_DSV_DIMENSION_TEXTURE2DMSARRAY:
            {
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            }
            default:
            {
                break;
            }
        }
    }

    public D3D11_DEPTH_STENCIL_VIEW_DESC(
        ID3D11Texture1D pTex1D,
        D3D11_DSV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        uint flags = 0
    )
    {
        ViewDimension = viewDimension;
        Flags = flags;
        if (
            (DXGI_FORMAT_UNKNOWN == format)
            || (
                (unchecked((uint)-1) == arraySize)
                && (D3D11_DSV_DIMENSION_TEXTURE1DARRAY == viewDimension)
            )
        )
        {
            D3D11_TEXTURE1D_DESC TexDesc;
            pTex1D.GetDesc(&TexDesc);
            if (DXGI_FORMAT_UNKNOWN == format)
            {
                format = TexDesc.Format;
            }
            if (unchecked((uint)-1 == arraySize))
            {
                arraySize = TexDesc.ArraySize - firstArraySlice;
            }
        }
        Format = format;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3D11_DSV_DIMENSION_TEXTURE1D:
            {
                Anonymous.Texture1D.MipSlice = mipSlice;
                break;
            }
            case D3D11_DSV_DIMENSION_TEXTURE1DARRAY:
            {
                Anonymous.Texture1DArray.MipSlice = mipSlice;
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

    public D3D11_DEPTH_STENCIL_VIEW_DESC(
        ID3D11Texture2D pTex2D,
        D3D11_DSV_DIMENSION viewDimension,
        DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN,
        uint mipSlice = 0,
        uint firstArraySlice = 0,
        uint arraySize = unchecked((uint)-1),
        uint flags = 0
    )
    {
        ViewDimension = viewDimension;
        Flags = flags;
        if (
            (DXGI_FORMAT_UNKNOWN == format)
            || (
                (unchecked((uint)-1) == arraySize)
                && (
                    (D3D11_DSV_DIMENSION_TEXTURE2DARRAY == viewDimension)
                    || (D3D11_DSV_DIMENSION_TEXTURE2DMSARRAY == viewDimension)
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
            if (unchecked((uint)-1 == arraySize))
            {
                arraySize = TexDesc.ArraySize - firstArraySlice;
            }
        }
        Format = format;
        Anonymous = default;
        switch (viewDimension)
        {
            case D3D11_DSV_DIMENSION_TEXTURE2D:
            {
                Anonymous.Texture2D.MipSlice = mipSlice;
                break;
            }
            case D3D11_DSV_DIMENSION_TEXTURE2DARRAY:
            {
                Anonymous.Texture2DArray.MipSlice = mipSlice;
                Anonymous.Texture2DArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DArray.ArraySize = arraySize;
                break;
            }
            case D3D11_DSV_DIMENSION_TEXTURE2DMS:
            {
                break;
            }
            case D3D11_DSV_DIMENSION_TEXTURE2DMSARRAY:
            {
                Anonymous.Texture2DMSArray.FirstArraySlice = firstArraySlice;
                Anonymous.Texture2DMSArray.ArraySize = arraySize;
                break;
            }
            default:
            {
                break;
            }
        }
    }
}
