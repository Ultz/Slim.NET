// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D11_SAMPLER_DESC
{
    public static ref readonly D3D11_SAMPLER_DESC DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x00,
                0x00,
                0x00,
                0x03,
                0x00,
                0x00,
                0x00,
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
                0x01,
                0x00,
                0x00,
                0x00,
                0x01,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x80,
                0x3F,
                0xFF,
                0xFF,
                0x7F,
                0xFF,
                0xFF,
                0xFF,
                0x7F,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<D3D11_SAMPLER_DESC>());
            return ref Unsafe.As<byte, D3D11_SAMPLER_DESC>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D3D11_SAMPLER_DESC(
        D3D11_FILTER filter,
        D3D11_TEXTURE_ADDRESS_MODE addressU,
        D3D11_TEXTURE_ADDRESS_MODE addressV,
        D3D11_TEXTURE_ADDRESS_MODE addressW,
        float mipLODBias,
        uint maxAnisotropy,
        D3D11_COMPARISON_FUNC comparisonFunc,
        [NativeTypeName("FLOAT [4]")] float* borderColor,
        float minLOD,
        float maxLOD
    )
    {
        Filter = filter;
        AddressU = addressU;
        AddressV = addressV;
        AddressW = addressW;
        MipLODBias = mipLODBias;
        MaxAnisotropy = maxAnisotropy;
        ComparisonFunc = comparisonFunc;
        var defaultColor = stackalloc float[4] { 1.0f, 1.0f, 1.0f, 1.0f };
        if (borderColor == null)
        {
            borderColor = defaultColor;
        }
        BorderColor[0] = borderColor[0];
        BorderColor[1] = borderColor[1];
        BorderColor[2] = borderColor[2];
        BorderColor[3] = borderColor[3];
        MinLOD = minLOD;
        MaxLOD = maxLOD;
    }
}
