// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_II2cConnectionSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x13,
                0xDB,
                0xF2,
                0x6F,
                0xAB,
                0x39,
                0x46,
                0xA7,
                0x67,
                0x54,
                0x53,
                0x6D,
                0xC3,
                0x46,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_II2cConnectionSettingsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x86,
                0xB5,
                0x81,
                0x93,
                0x96,
                0xB1,
                0x41,
                0xA2,
                0x43,
                0xDE,
                0xD4,
                0xF6,
                0xE6,
                0x69,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_II2cController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0xB1,
                0x8A,
                0xC4,
                0xA0,
                0x87,
                0x66,
                0x41,
                0x8E,
                0x3E,
                0xB4,
                0xB8,
                0xF9,
                0x7C,
                0xD7,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_II2cControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x03,
                0xFC,
                0x40,
                0x05,
                0x5F,
                0x7E,
                0x4E,
                0x84,
                0xBD,
                0x10,
                0x0D,
                0xB8,
                0xE0,
                0xAE,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_II2cDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0xC1,
                0x36,
                0x86,
                0xC5,
                0xB9,
                0x70,
                0x4F,
                0x94,
                0x49,
                0xCC,
                0x46,
                0xDC,
                0x6F,
                0x57,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_II2cDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x3B,
                0xA3,
                0x91,
                0x34,
                0x73,
                0x12,
                0x45,
                0x96,
                0xBC,
                0xFB,
                0xAE,
                0x94,
                0x59,
                0xF5,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
