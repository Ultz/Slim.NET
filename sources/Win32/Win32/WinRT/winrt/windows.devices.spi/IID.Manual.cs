// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ISpiBusInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x44,
                0x29,
                0x99,
                0xF2,
                0x54,
                0xC6,
                0x48,
                0xB9,
                0x52,
                0x9C,
                0x32,
                0xFC,
                0x02,
                0xC6,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpiConnectionSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xA3,
                0x83,
                0x52,
                0x35,
                0xF9,
                0x9F,
                0x4B,
                0xA7,
                0xA7,
                0x3A,
                0x78,
                0x90,
                0xAF,
                0xA5,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpiConnectionSettingsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x08,
                0x99,
                0xFF,
                0xC4,
                0x10,
                0xB7,
                0x44,
                0x9F,
                0xEA,
                0xA7,
                0x48,
                0xB5,
                0xA4,
                0x6F,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpiController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xC8,
                0xD3,
                0xA8,
                0x95,
                0x98,
                0x59,
                0x41,
                0xA9,
                0x34,
                0x87,
                0x41,
                0xF1,
                0xEE,
                0x6D,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpiControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x29,
                0x52,
                0x0D,
                0x8B,
                0x13,
                0x48,
                0x4E,
                0xB9,
                0x64,
                0x4F,
                0x2F,
                0x79,
                0xB9,
                0xC5,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpiDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x35,
                0xD5,
                0x05,
                0xB6,
                0x11,
                0x39,
                0x4D,
                0x84,
                0xD5,
                0x95,
                0xDF,
                0xB4,
                0xC9,
                0xF2,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpiDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xE5,
                0x78,
                0xA2,
                0x20,
                0x57,
                0x3F,
                0x4D,
                0xBD,
                0x93,
                0x56,
                0xF5,
                0xFF,
                0x5A,
                0x58,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
