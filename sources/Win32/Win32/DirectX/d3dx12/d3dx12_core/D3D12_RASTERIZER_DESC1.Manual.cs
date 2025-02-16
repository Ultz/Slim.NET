// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_RASTERIZER_DESC1
{
    public D3D12_RASTERIZER_DESC1(
        [NativeTypeName("const D3D12_RASTERIZER_DESC &")] in D3D12_RASTERIZER_DESC o
    )
    {
        FillMode = o.FillMode;
        CullMode = o.CullMode;
        FrontCounterClockwise = o.FrontCounterClockwise;
        DepthBias = (float)(o.DepthBias);
        DepthBiasClamp = o.DepthBiasClamp;
        SlopeScaledDepthBias = o.SlopeScaledDepthBias;
        DepthClipEnable = o.DepthClipEnable;
        MultisampleEnable = o.MultisampleEnable;
        AntialiasedLineEnable = o.AntialiasedLineEnable;
        ForcedSampleCount = o.ForcedSampleCount;
        ConservativeRaster = o.ConservativeRaster;
    }

    public static ref readonly D3D12_RASTERIZER_DESC1 DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x00,
                0x00,
                0x00,
                0x03,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
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
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_RASTERIZER_DESC1>());
            return ref Unsafe.As<byte, D3D12_RASTERIZER_DESC1>(
                ref MemoryMarshal.GetReference(data)
            );
        }
    }

    public static explicit operator D3D12_RASTERIZER_DESC(in D3D12_RASTERIZER_DESC1 value)
    {
        D3D12_RASTERIZER_DESC o = new D3D12_RASTERIZER_DESC
        {
            FillMode = value.FillMode,
            CullMode = value.CullMode,
            FrontCounterClockwise = value.FrontCounterClockwise,
            DepthBias = (int)(value.DepthBias),
            DepthBiasClamp = value.DepthBiasClamp,
            SlopeScaledDepthBias = value.SlopeScaledDepthBias,
            DepthClipEnable = value.DepthClipEnable,
            MultisampleEnable = value.MultisampleEnable,
            AntialiasedLineEnable = value.AntialiasedLineEnable,
            ForcedSampleCount = value.ForcedSampleCount,
            ConservativeRaster = value.ConservativeRaster,
        };
        return o;
    }
}
