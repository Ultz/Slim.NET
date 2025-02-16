// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using static Silk.NET.DirectX.D3D11;
using static Silk.NET.DirectX.D3D11_RTV_DIMENSION;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D11_VIEWPORT : IEquatable<D3D11_VIEWPORT>
{
    public D3D11_VIEWPORT(
        float topLeftX,
        float topLeftY,
        float width,
        float height,
        float minDepth = D3D11_MIN_DEPTH,
        float maxDepth = D3D11_MAX_DEPTH
    )
    {
        TopLeftX = topLeftX;
        TopLeftY = topLeftY;
        Width = width;
        Height = height;
        MinDepth = minDepth;
        MaxDepth = maxDepth;
    }

    public D3D11_VIEWPORT(
        ID3D11Buffer param0,
        ID3D11RenderTargetView pRTView,
        float topLeftX = 0.0f,
        float minDepth = D3D11_MIN_DEPTH,
        float maxDepth = D3D11_MAX_DEPTH
    )
    {
        D3D11_RENDER_TARGET_VIEW_DESC RTVDesc;
        pRTView.GetDesc(&RTVDesc);
        uint NumElements = 0;
        switch (RTVDesc.ViewDimension)
        {
            case D3D11_RTV_DIMENSION_BUFFER:
            {
                NumElements = RTVDesc.Anonymous.Buffer.Anonymous2.NumElements;
                break;
            }
            default:
            {
                break;
            }
        }
        TopLeftX = topLeftX;
        TopLeftY = 0.0f;
        Width = NumElements - topLeftX;
        Height = 1.0f;
        MinDepth = minDepth;
        MaxDepth = maxDepth;
    }

    public D3D11_VIEWPORT(
        ID3D11Texture1D pTex1D,
        ID3D11RenderTargetView pRTView,
        float topLeftX = 0.0f,
        float minDepth = D3D11_MIN_DEPTH,
        float maxDepth = D3D11_MAX_DEPTH
    )
    {
        D3D11_TEXTURE1D_DESC TexDesc;
        pTex1D.GetDesc(&TexDesc);
        D3D11_RENDER_TARGET_VIEW_DESC RTVDesc;
        pRTView.GetDesc(&RTVDesc);
        uint MipSlice = 0;
        switch (RTVDesc.ViewDimension)
        {
            case D3D11_RTV_DIMENSION_TEXTURE1D:
            {
                MipSlice = RTVDesc.Anonymous.Texture1D.MipSlice;
                break;
            }
            case D3D11_RTV_DIMENSION_TEXTURE1DARRAY:
            {
                MipSlice = RTVDesc.Anonymous.Texture1DArray.MipSlice;
                break;
            }
            default:
            {
                break;
            }
        }
        var SubResourceWidth = TexDesc.Width / (1u << unchecked((int)MipSlice));
        TopLeftX = topLeftX;
        TopLeftY = 0.0f;
        Width = ((SubResourceWidth != 0) ? SubResourceWidth : 1) - topLeftX;
        Height = 1.0f;
        MinDepth = minDepth;
        MaxDepth = maxDepth;
    }

    public D3D11_VIEWPORT(
        ID3D11Texture2D pTex2D,
        ID3D11RenderTargetView pRTView,
        float topLeftX = 0.0f,
        float topLeftY = 0.0f,
        float minDepth = D3D11_MIN_DEPTH,
        float maxDepth = D3D11_MAX_DEPTH
    )
    {
        D3D11_TEXTURE2D_DESC TexDesc;
        pTex2D.GetDesc(&TexDesc);
        D3D11_RENDER_TARGET_VIEW_DESC RTVDesc;
        pRTView.GetDesc(&RTVDesc);
        uint MipSlice = 0;
        switch (RTVDesc.ViewDimension)
        {
            case D3D11_RTV_DIMENSION_TEXTURE2D:
            {
                MipSlice = RTVDesc.Anonymous.Texture2D.MipSlice;
                break;
            }
            case D3D11_RTV_DIMENSION_TEXTURE2DARRAY:
            {
                MipSlice = RTVDesc.Anonymous.Texture2DArray.MipSlice;
                break;
            }
            case D3D11_RTV_DIMENSION_TEXTURE2DMS:
            case D3D11_RTV_DIMENSION_TEXTURE2DMSARRAY:
            {
                break;
            }
            default:
            {
                break;
            }
        }
        var SubResourceWidth = TexDesc.Width / (1u << unchecked((int)MipSlice));
        var SubResourceHeight = TexDesc.Height / (1u << unchecked((int)MipSlice));
        TopLeftX = topLeftX;
        TopLeftY = topLeftY;
        Width = ((SubResourceWidth != 0) ? SubResourceWidth : 1) - topLeftX;
        Height = ((SubResourceHeight != 0) ? SubResourceHeight : 1) - topLeftY;
        MinDepth = minDepth;
        MaxDepth = maxDepth;
    }

    public D3D11_VIEWPORT(
        ID3D11Texture3D pTex3D,
        ID3D11RenderTargetView pRTView,
        float topLeftX = 0.0f,
        float topLeftY = 0.0f,
        float minDepth = D3D11_MIN_DEPTH,
        float maxDepth = D3D11_MAX_DEPTH
    )
    {
        D3D11_TEXTURE3D_DESC TexDesc;
        pTex3D.GetDesc(&TexDesc);
        D3D11_RENDER_TARGET_VIEW_DESC RTVDesc;
        pRTView.GetDesc(&RTVDesc);
        uint MipSlice = 0;
        switch (RTVDesc.ViewDimension)
        {
            case D3D11_RTV_DIMENSION_TEXTURE3D:
            {
                MipSlice = RTVDesc.Anonymous.Texture3D.MipSlice;
                break;
            }
            default:
            {
                break;
            }
        }
        var SubResourceWidth = TexDesc.Width / (1u << unchecked((int)MipSlice));
        var SubResourceHeight = TexDesc.Height / (1u << unchecked((int)MipSlice));
        TopLeftX = topLeftX;
        TopLeftY = topLeftY;
        Width = ((SubResourceWidth != 0) ? SubResourceWidth : 1) - topLeftX;
        Height = ((SubResourceHeight != 0) ? SubResourceHeight : 1) - topLeftY;
        MinDepth = minDepth;
        MaxDepth = maxDepth;
    }

    public static bool operator ==(in D3D11_VIEWPORT l, in D3D11_VIEWPORT r)
    {
        return (l.TopLeftX == r.TopLeftX)
            && (l.TopLeftY == r.TopLeftY)
            && (l.Width == r.Width)
            && (l.Height == r.Height)
            && (l.MinDepth == r.MinDepth)
            && (l.MaxDepth == r.MaxDepth);
    }

    public static bool operator !=(in D3D11_VIEWPORT l, in D3D11_VIEWPORT r) => !(l == r);

    public override readonly bool Equals(object? obj) =>
        (obj is D3D11_VIEWPORT other) && Equals(other);

    public readonly bool Equals(D3D11_VIEWPORT other) => this == other;

    public override readonly int GetHashCode() =>
        HashCode.Combine(TopLeftX, TopLeftY, Width, Height, MinDepth, MaxDepth);
}
