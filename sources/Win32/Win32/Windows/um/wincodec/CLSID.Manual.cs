// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class CLSID
{
    public static ref readonly Guid CLSID_WICImagingFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xF2,
                0xCA,
                0xCA,
                0x70,
                0x93,
                0x15,
                0x46,
                0xA1,
                0x3B,
                0x9F,
                0x55,
                0x39,
                0xDA,
                0x4C,
                0x0A,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_WICPngDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xA1,
                0x9E,
                0x38,
                0x78,
                0x50,
                0xDE,
                0x4C,
                0xB6,
                0xEF,
                0x25,
                0xC1,
                0x51,
                0x75,
                0xC7,
                0x51,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
