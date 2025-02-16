// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_II2cControllerProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0xBB,
                0xC2,
                0x61,
                0x10,
                0x45,
                0x63,
                0x41,
                0xA8,
                0x7C,
                0x4E,
                0x15,
                0xA9,
                0x55,
                0x89,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_II2cDeviceProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0x26,
                0x34,
                0xAD,
                0xE8,
                0x57,
                0x3E,
                0x45,
                0x83,
                0x29,
                0xD1,
                0xE4,
                0x47,
                0xD1,
                0x03,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_II2cProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x08,
                0x13,
                0x6F,
                0x62,
                0xBF,
                0xE2,
                0x4F,
                0xA9,
                0x5A,
                0xF0,
                0x89,
                0x99,
                0x66,
                0x98,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProviderI2cConnectionSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x4E,
                0xDB,
                0xE9,
                0x10,
                0xE5,
                0xB7,
                0x44,
                0x80,
                0x9D,
                0xF2,
                0xF8,
                0x5B,
                0x55,
                0x53,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
