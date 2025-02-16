// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D11_DEPTH_STENCIL_DESC
{
    public static ref readonly D3D11_DEPTH_STENCIL_DESC DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x00,
                0x00,
                0x00,
                0x01,
                0x00,
                0x00,
                0x00,
                0x02,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0xFF,
                0xFF,
                0x00,
                0x00,
                0x01,
                0x00,
                0x00,
                0x00,
                0x01,
                0x00,
                0x00,
                0x00,
                0x01,
                0x00,
                0x00,
                0x00,
                0x08,
                0x00,
                0x00,
                0x00,
                0x01,
                0x00,
                0x00,
                0x00,
                0x01,
                0x00,
                0x00,
                0x00,
                0x01,
                0x00,
                0x00,
                0x00,
                0x08,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D3D11_DEPTH_STENCIL_DESC>());
            return ref Unsafe.As<byte, D3D11_DEPTH_STENCIL_DESC>(
                ref MemoryMarshal.GetReference(data)
            );
        }
    }

    public D3D11_DEPTH_STENCIL_DESC(
        BOOL depthEnable,
        D3D11_DEPTH_WRITE_MASK depthWriteMask,
        D3D11_COMPARISON_FUNC depthFunc,
        BOOL stencilEnable,
        [NativeTypeName("UINT8")] byte stencilReadMask,
        [NativeTypeName("UINT8")] byte stencilWriteMask,
        D3D11_STENCIL_OP frontStencilFailOp,
        D3D11_STENCIL_OP frontStencilDepthFailOp,
        D3D11_STENCIL_OP frontStencilPassOp,
        D3D11_COMPARISON_FUNC frontStencilFunc,
        D3D11_STENCIL_OP backStencilFailOp,
        D3D11_STENCIL_OP backStencilDepthFailOp,
        D3D11_STENCIL_OP backStencilPassOp,
        D3D11_COMPARISON_FUNC backStencilFunc
    )
    {
        DepthEnable = depthEnable;
        DepthWriteMask = depthWriteMask;
        DepthFunc = depthFunc;
        StencilEnable = stencilEnable;
        StencilReadMask = stencilReadMask;
        StencilWriteMask = stencilWriteMask;
        FrontFace.StencilFailOp = frontStencilFailOp;
        FrontFace.StencilDepthFailOp = frontStencilDepthFailOp;
        FrontFace.StencilPassOp = frontStencilPassOp;
        FrontFace.StencilFunc = frontStencilFunc;
        BackFace.StencilFailOp = backStencilFailOp;
        BackFace.StencilDepthFailOp = backStencilDepthFailOp;
        BackFace.StencilPassOp = backStencilPassOp;
        BackFace.StencilFunc = backStencilFunc;
    }
}
