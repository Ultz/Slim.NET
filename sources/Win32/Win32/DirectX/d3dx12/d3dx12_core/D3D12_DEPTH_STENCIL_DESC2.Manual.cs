// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_DEPTH_STENCIL_DESC2
{
    public D3D12_DEPTH_STENCIL_DESC2(
        [NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] in D3D12_DEPTH_STENCIL_DESC1 o
    )
    {
        DepthEnable = o.DepthEnable;
        DepthWriteMask = o.DepthWriteMask;
        DepthFunc = o.DepthFunc;
        StencilEnable = o.StencilEnable;
        FrontFace.StencilFailOp = o.FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o.FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o.FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o.FrontFace.StencilFunc;
        FrontFace.StencilReadMask = o.StencilReadMask;
        FrontFace.StencilWriteMask = o.StencilWriteMask;
        BackFace.StencilFailOp = o.BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o.BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o.BackFace.StencilPassOp;
        BackFace.StencilFunc = o.BackFace.StencilFunc;
        BackFace.StencilReadMask = o.StencilReadMask;
        BackFace.StencilWriteMask = o.StencilWriteMask;
        DepthBoundsTestEnable = o.DepthBoundsTestEnable;
    }

    public D3D12_DEPTH_STENCIL_DESC2(
        [NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] in D3D12_DEPTH_STENCIL_DESC o
    )
    {
        DepthEnable = o.DepthEnable;
        DepthWriteMask = o.DepthWriteMask;
        DepthFunc = o.DepthFunc;
        StencilEnable = o.StencilEnable;
        FrontFace.StencilFailOp = o.FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o.FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o.FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o.FrontFace.StencilFunc;
        FrontFace.StencilReadMask = o.StencilReadMask;
        FrontFace.StencilWriteMask = o.StencilWriteMask;
        BackFace.StencilFailOp = o.BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o.BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o.BackFace.StencilPassOp;
        BackFace.StencilFunc = o.BackFace.StencilFunc;
        BackFace.StencilReadMask = o.StencilReadMask;
        BackFace.StencilWriteMask = o.StencilWriteMask;
        DepthBoundsTestEnable = 0;
    }

    public static ref readonly D3D12_DEPTH_STENCIL_DESC2 DEFAULT
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
                0xFF,
                0xFF,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_DEPTH_STENCIL_DESC2>());
            return ref Unsafe.As<byte, D3D12_DEPTH_STENCIL_DESC2>(
                ref MemoryMarshal.GetReference(data)
            );
        }
    }

    public static explicit operator D3D12_DEPTH_STENCIL_DESC(in D3D12_DEPTH_STENCIL_DESC2 value) =>
        new D3D12_DEPTH_STENCIL_DESC
        {
            DepthEnable = value.DepthEnable,
            DepthWriteMask = value.DepthWriteMask,
            DepthFunc = value.DepthFunc,
            StencilEnable = value.StencilEnable,
            StencilReadMask = value.FrontFace.StencilReadMask,
            StencilWriteMask = value.FrontFace.StencilWriteMask,
            FrontFace = new D3D12_DEPTH_STENCILOP_DESC
            {
                StencilFailOp = value.FrontFace.StencilFailOp,
                StencilDepthFailOp = value.FrontFace.StencilDepthFailOp,
                StencilPassOp = value.FrontFace.StencilPassOp,
                StencilFunc = value.FrontFace.StencilFunc,
            },
            BackFace = new D3D12_DEPTH_STENCILOP_DESC
            {
                StencilFailOp = value.BackFace.StencilFailOp,
                StencilDepthFailOp = value.BackFace.StencilDepthFailOp,
                StencilPassOp = value.BackFace.StencilPassOp,
                StencilFunc = value.BackFace.StencilFunc,
            },
        };
}
