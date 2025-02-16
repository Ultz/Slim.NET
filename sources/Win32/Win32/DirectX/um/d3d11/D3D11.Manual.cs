// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class D3D11
{
    public const int D3D11_OMAC_SIZE = 16;
    public static ref readonly Guid D3D11_DECODER_PROFILE_MPEG2AND1_VLD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x5F,
                0x69,
                0x86,
                0x0E,
                0x34,
                0x04,
                0x4F,
                0x9F,
                0xD3,
                0x92,
                0x53,
                0xDD,
                0x32,
                0x74,
                0x60,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
