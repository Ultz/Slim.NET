// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBluetoothLEAdvertisement
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0xB2,
                0x6F,
                0x06,
                0xD1,
                0x33,
                0x7D,
                0x4E,
                0x83,
                0x67,
                0xCF,
                0x81,
                0xD0,
                0xF7,
                0x96,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementBytePattern
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xD7,
                0xFA,
                0xFB,
                0xC5,
                0xB9,
                0x08,
                0x4A,
                0xBC,
                0x51,
                0x50,
                0x2F,
                0x8E,
                0xF6,
                0x8A,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementBytePatternFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x4D,
                0xE2,
                0xC2,
                0x5C,
                0xFD,
                0xC3,
                0x4E,
                0xBE,
                0x2A,
                0x9C,
                0xA6,
                0xFA,
                0x11,
                0xB7,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementDataSection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0x33,
                0x21,
                0xD7,
                0x43,
                0x3A,
                0xF9,
                0x40,
                0xB6,
                0xF0,
                0x92,
                0xBF,
                0xEF,
                0xC3,
                0x4A,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementDataSectionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x09,
                0xA4,
                0xE7,
                0x45,
                0xA8,
                0x45,
                0x40,
                0xBF,
                0x7E,
                0x3E,
                0x99,
                0x71,
                0xDB,
                0x8A,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementDataTypesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x47,
                0xB6,
                0x3B,
                0x06,
                0x06,
                0x4B,
                0x43,
                0xA7,
                0x6E,
                0x74,
                0x15,
                0x9F,
                0x06,
                0x84,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0xB0,
                0x1E,
                0x13,
                0x4E,
                0xD0,
                0xB1,
                0x47,
                0x83,
                0x7E,
                0x49,
                0x40,
                0x5B,
                0xF6,
                0xF8,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementPublisher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x20,
                0xE8,
                0xCD,
                0xFA,
                0xD9,
                0xD6,
                0x43,
                0xA2,
                0x64,
                0xDD,
                0xD8,
                0xB7,
                0xDA,
                0x8B,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementPublisher2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x54,
                0xDB,
                0xFB,
                0xF1,
                0x56,
                0x0F,
                0x51,
                0xA4,
                0x34,
                0x21,
                0x7F,
                0xBD,
                0x9E,
                0x7B,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementPublisherFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x06,
                0x5F,
                0x5C,
                0x63,
                0xB8,
                0x81,
                0x49,
                0xA1,
                0xAF,
                0x1C,
                0x54,
                0x4D,
                0x8B,
                0x0C,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementPublisherStatusChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0xBD,
                0xC2,
                0x09,
                0xFF,
                0x2D,
                0x23,
                0x4B,
                0x86,
                0xEE,
                0x0D,
                0x14,
                0xFB,
                0x94,
                0xAE,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementPublisherStatusChangedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x79,
                0x62,
                0x8F,
                0x88,
                0xDC,
                0x8B,
                0x5C,
                0xB3,
                0x4E,
                0x10,
                0xB3,
                0x21,
                0x85,
                0x0F,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x7D,
                0x98,
                0x27,
                0x96,
                0xE5,
                0xBE,
                0x41,
                0x8D,
                0x43,
                0x9E,
                0x67,
                0x31,
                0xD4,
                0xA9,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementReceivedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xC8,
                0xD9,
                0x12,
                0x99,
                0x03,
                0x0E,
                0x5F,
                0xA3,
                0x48,
                0x53,
                0xB0,
                0x2B,
                0x6B,
                0x16,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x33,
                0xAC,
                0xA6,
                0xD3,
                0xF3,
                0x97,
                0x42,
                0x8D,
                0x6C,
                0xC8,
                0x1E,
                0xA6,
                0x62,
                0x3F,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementWatcher2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x26,
                0xBF,
                0x01,
                0x64,
                0xB1,
                0x05,
                0x58,
                0x90,
                0xA3,
                0xE8,
                0xA7,
                0x99,
                0x7F,
                0xF2,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementWatcherFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x2D,
                0xAF,
                0x9A,
                0xAC,
                0x39,
                0x3E,
                0x45,
                0xB3,
                0x2A,
                0x85,
                0xC6,
                0x57,
                0xE0,
                0x17,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementWatcherStoppedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0xF8,
                0x40,
                0xDD,
                0xB9,
                0xE7,
                0xE3,
                0x43,
                0x9C,
                0x04,
                0x06,
                0x85,
                0xD0,
                0x85,
                0xFD,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEManufacturerData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0xBA,
                0x2D,
                0x91,
                0x63,
                0x69,
                0x33,
                0x45,
                0xB0,
                0x61,
                0x46,
                0x94,
                0xDA,
                0xFB,
                0x34,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEManufacturerDataFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x39,
                0x9B,
                0xC0,
                0x9A,
                0x31,
                0x1E,
                0x44,
                0x8D,
                0xE5,
                0x66,
                0xA8,
                0x1E,
                0x87,
                0x7A,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
