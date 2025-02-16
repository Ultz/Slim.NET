// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IHdmiDisplayInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x3C,
                0x0B,
                0x13,
                0x65,
                0xF5,
                0x6E,
                0x47,
                0xAB,
                0xD5,
                0xEA,
                0x05,
                0xAE,
                0xE7,
                0x4C,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHdmiDisplayInformationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xB2,
                0xE6,
                0x6C,
                0x2A,
                0xF4,
                0x15,
                0x4A,
                0x91,
                0x4C,
                0x7B,
                0x8E,
                0x2A,
                0x5A,
                0x65,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHdmiDisplayMode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0xD5,
                0x06,
                0x0C,
                0x90,
                0x1B,
                0x51,
                0x4F,
                0x99,
                0x81,
                0xEF,
                0x5A,
                0x1C,
                0x0D,
                0xDF,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHdmiDisplayMode2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x4E,
                0xCD,
                0x07,
                0x3C,
                0x4B,
                0xB8,
                0x42,
                0x84,
                0xE7,
                0x89,
                0x53,
                0x68,
                0x71,
                0x8A,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
