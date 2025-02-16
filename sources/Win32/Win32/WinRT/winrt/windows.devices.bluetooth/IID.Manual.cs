// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBluetoothAdapter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0xF0,
                0x74,
                0x79,
                0x7A,
                0x5F,
                0x34,
                0x4A,
                0x92,
                0x25,
                0xA8,
                0x55,
                0xF8,
                0x4B,
                0x1A,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothAdapter2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0xCE,
                0x94,
                0xAC,
                0xD5,
                0x24,
                0xB3,
                0x41,
                0x91,
                0x6D,
                0x10,
                0x97,
                0xC5,
                0x0B,
                0x10,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothAdapter3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x24,
                0x86,
                0x8F,
                0xA9,
                0xCB,
                0x11,
                0x52,
                0x9F,
                0x89,
                0x3A,
                0xAC,
                0x62,
                0xB4,
                0xC6,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothAdapterStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xFB,
                0x02,
                0x8B,
                0x4C,
                0xAC,
                0x41,
                0x47,
                0x86,
                0x61,
                0x8E,
                0xAB,
                0x7D,
                0x17,
                0xEA,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothClassOfDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x22,
                0x40,
                0xD6,
                0xD7,
                0xD7,
                0x61,
                0x46,
                0x94,
                0x54,
                0x65,
                0x03,
                0x9C,
                0xA1,
                0x7A,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothClassOfDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x35,
                0x61,
                0xE4,
                0xA2,
                0x0F,
                0x6C,
                0x41,
                0x91,
                0xB4,
                0xC1,
                0xE4,
                0x8C,
                0xA0,
                0x61,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0xB1,
                0x35,
                0x23,
                0xD2,
                0x90,
                0x04,
                0x4A,
                0xAE,
                0xF5,
                0x0E,
                0x20,
                0xB9,
                0xE6,
                0xB7,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothDevice2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xF9,
                0x33,
                0x01,
                0x56,
                0xB1,
                0xD0,
                0x4D,
                0xB1,
                0xF5,
                0xC1,
                0x1B,
                0xC3,
                0x1A,
                0x51,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothDevice3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xF7,
                0xFF,
                0x57,
                0x1A,
                0x65,
                0x54,
                0x44,
                0xB9,
                0x0F,
                0xEB,
                0x21,
                0xEF,
                0x0B,
                0x0D,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothDevice4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x34,
                0x7C,
                0x81,
                0x9C,
                0x0E,
                0xB2,
                0x42,
                0xA8,
                0xDC,
                0x3E,
                0x80,
                0x94,
                0x94,
                0x0D,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothDevice5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0xB3,
                0xE0,
                0xB5,
                0x85,
                0x5E,
                0x59,
                0x45,
                0xA1,
                0x0D,
                0x1C,
                0x72,
                0x81,
                0x37,
                0x9F,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothDeviceId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x49,
                0x79,
                0xC1,
                0xC1,
                0x57,
                0x42,
                0x46,
                0xBC,
                0xCE,
                0xE6,
                0xC0,
                0x6B,
                0x20,
                0xAE,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothDeviceIdStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x4E,
                0x88,
                0xA7,
                0xFB,
                0x3E,
                0x31,
                0x4F,
                0xBB,
                0xC2,
                0x81,
                0x0E,
                0x09,
                0x97,
                0x74,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xDF,
                0x91,
                0x09,
                0xDB,
                0x57,
                0x25,
                0x47,
                0xBB,
                0xD7,
                0x84,
                0xF6,
                0x43,
                0x27,
                0xEC,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothDeviceStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x8E,
                0x9E,
                0xC2,
                0x14,
                0x4E,
                0x77,
                0x44,
                0xAA,
                0x1B,
                0xB8,
                0xB4,
                0x7E,
                0x5B,
                0x7E,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAppearance
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x79,
                0x20,
                0x5D,
                0xA8,
                0x66,
                0x58,
                0x42,
                0x98,
                0x5E,
                0x02,
                0xB4,
                0xD9,
                0x50,
                0x9F,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAppearanceCategoriesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x54,
                0x4D,
                0x6D,
                0x6A,
                0x04,
                0x85,
                0x41,
                0xAA,
                0xB6,
                0x82,
                0x4C,
                0xF0,
                0x61,
                0x08,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAppearanceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xC0,
                0x93,
                0xA1,
                0x04,
                0x45,
                0x4A,
                0x4F,
                0x9B,
                0xA5,
                0xCD,
                0x10,
                0x54,
                0xE5,
                0xE0,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAppearanceSubcategoriesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xA6,
                0x7B,
                0xE5,
                0x44,
                0x21,
                0x5A,
                0x41,
                0x83,
                0x12,
                0x71,
                0xCC,
                0xF2,
                0x91,
                0xF8,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEConnectionParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x07,
                0xCB,
                0x33,
                0xA9,
                0x8D,
                0x8F,
                0x50,
                0xA3,
                0x66,
                0x1C,
                0xA3,
                0x88,
                0xC9,
                0x29,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEConnectionPhy
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x5E,
                0x1E,
                0x78,
                0x1E,
                0x62,
                0x7E,
                0x5A,
                0x8B,
                0xE6,
                0x1B,
                0x95,
                0x61,
                0xFF,
                0x63,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEConnectionPhyInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x0B,
                0x10,
                0x9A,
                0x2E,
                0x60,
                0x27,
                0x5C,
                0xA1,
                0xAE,
                0xB2,
                0x30,
                0x01,
                0x5A,
                0x63,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x2F,
                0xEE,
                0xB5,
                0xD8,
                0x4A,
                0x42,
                0x46,
                0xAC,
                0x48,
                0x80,
                0xA0,
                0xB5,
                0x00,
                0xE8,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEDevice2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x62,
                0xF0,
                0x26,
                0xEE,
                0x7A,
                0x31,
                0x4D,
                0xBA,
                0xBA,
                0xB1,
                0xB9,
                0x77,
                0x5F,
                0x59,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEDevice3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0xE4,
                0xE9,
                0xAE,
                0xAC,
                0x44,
                0xDC,
                0x40,
                0xAF,
                0x33,
                0xB2,
                0xC1,
                0x3C,
                0x01,
                0xCA,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEDevice4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0x50,
                0x60,
                0x2B,
                0x48,
                0x22,
                0x2F,
                0x4B,
                0xAC,
                0xF0,
                0x7C,
                0xEE,
                0x36,
                0xFC,
                0x58,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEDevice5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0x12,
                0x6A,
                0x9D,
                0x87,
                0x52,
                0x8E,
                0x45,
                0x95,
                0xBA,
                0x17,
                0xC8,
                0xB7,
                0xBB,
                0x32,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEDevice6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x90,
                0x71,
                0xCA,
                0xAE,
                0x0C,
                0x3C,
                0x57,
                0xA1,
                0xCA,
                0xE1,
                0xFC,
                0x5B,
                0xFC,
                0x39,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x1A,
                0xCF,
                0xC8,
                0xB6,
                0xF0,
                0xF0,
                0x4B,
                0x86,
                0x89,
                0x41,
                0x30,
                0x3D,
                0xE2,
                0xD9,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEDeviceStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0xC0,
                0x12,
                0x5F,
                0xAC,
                0x3B,
                0xE8,
                0x43,
                0xAD,
                0x16,
                0x56,
                0x32,
                0x71,
                0xBD,
                0x41,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEPreferredConnectionParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x43,
                0xF4,
                0xF2,
                0x72,
                0x73,
                0x7B,
                0x5F,
                0x9B,
                0x34,
                0x29,
                0xC9,
                0x44,
                0xF5,
                0xA7,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEPreferredConnectionParametersRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x52,
                0x37,
                0x8A,
                0x28,
                0xA5,
                0x66,
                0x52,
                0xB6,
                0x61,
                0xCC,
                0xE6,
                0xA5,
                0xFF,
                0x97,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEPreferredConnectionParametersStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x8E,
                0x3E,
                0x0E,
                0x51,
                0x27,
                0xAA,
                0x55,
                0xA8,
                0x38,
                0x8F,
                0xAE,
                0xEE,
                0x81,
                0x8D,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothSignalStrengthFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x73,
                0x7B,
                0xDF,
                0xB5,
                0x6B,
                0xFE,
                0x4C,
                0x90,
                0xB1,
                0x5D,
                0x73,
                0x24,
                0xED,
                0xCF,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothUuidHelperStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x0C,
                0xDF,
                0x17,
                0x74,
                0xCF,
                0x21,
                0x4B,
                0xAF,
                0xE6,
                0xF5,
                0x7A,
                0x11,
                0xBC,
                0xDE,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
