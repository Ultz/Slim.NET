// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.spi.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IProviderSpiConnectionSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x45,
                0x03,
                0xF6,
                0x42,
                0xA5,
                0xC0,
                0x4E,
                0x96,
                0x01,
                0xA4,
                0xDD,
                0x68,
                0xF8,
                0x69,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProviderSpiConnectionSettingsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x6B,
                0x45,
                0x66,
                0x79,
                0x0C,
                0xE3,
                0x43,
                0x9F,
                0x3C,
                0xE5,
                0x97,
                0x80,
                0xAC,
                0x18,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpiControllerProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x65,
                0x68,
                0xC1,
                0xCE,
                0x02,
                0x26,
                0x42,
                0xA3,
                0x85,
                0x4F,
                0x11,
                0xFB,
                0x04,
                0xB4,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpiDeviceProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x34,
                0x1C,
                0x0D,
                0x4B,
                0x30,
                0x5C,
                0x40,
                0xB4,
                0xF7,
                0xF5,
                0xAB,
                0x10,
                0x74,
                0x46,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpiProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x61,
                0xB4,
                0x96,
                0xD4,
                0x77,
                0xCE,
                0x48,
                0xAA,
                0xA0,
                0x75,
                0x71,
                0x5A,
                0x83,
                0x62,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
