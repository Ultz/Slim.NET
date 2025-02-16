// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.adc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAdcChannel
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0xF4,
                0x0B,
                0x04,
                0x88,
                0x25,
                0x56,
                0x4A,
                0xAB,
                0xEF,
                0x73,
                0xA2,
                0x60,
                0xAC,
                0xC6,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdcController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xE4,
                0x76,
                0x2A,
                0x96,
                0xA8,
                0x19,
                0x42,
                0x86,
                0xB6,
                0xEA,
                0x8C,
                0xDC,
                0xE9,
                0x8F,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdcControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x8E,
                0xE9,
                0xCC,
                0xF8,
                0x01,
                0x91,
                0x48,
                0xBC,
                0x3B,
                0xBE,
                0x53,
                0xEF,
                0x27,
                0x9C,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdcControllerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x3B,
                0xB9,
                0xA2,
                0x7B,
                0x97,
                0x5A,
                0x4F,
                0xA5,
                0xFE,
                0xA6,
                0xAB,
                0xAF,
                0xFE,
                0x64,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
