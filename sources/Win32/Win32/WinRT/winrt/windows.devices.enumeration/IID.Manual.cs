// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDeviceAccessChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x0B,
                0xDA,
                0xDE,
                0x9D,
                0x4F,
                0x58,
                0x4F,
                0x9D,
                0xBA,
                0xA9,
                0xBC,
                0x80,
                0x04,
                0x08,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceAccessChangedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0x32,
                0x52,
                0x82,
                0x4B,
                0x93,
                0x30,
                0x4B,
                0xA1,
                0x78,
                0xAD,
                0xC3,
                0x9F,
                0x2F,
                0x2B,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceAccessInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x9A,
                0xAA,
                0x0B,
                0xE5,
                0x6D,
                0x15,
                0x49,
                0x8D,
                0xDD,
                0x9A,
                0x05,
                0x54,
                0xA6,
                0xF5,
                0x45,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceAccessInformationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0xD3,
                0x4B,
                0x57,
                0x30,
                0x5F,
                0xCD,
                0x45,
                0x8A,
                0x94,
                0x72,
                0x4F,
                0xE5,
                0x97,
                0x30,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceConnectionChangeTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x8C,
                0x57,
                0xB8,
                0xC1,
                0xBB,
                0x4B,
                0x48,
                0xBF,
                0xFA,
                0x7B,
                0x31,
                0xDC,
                0xC2,
                0x00,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceDisconnectButtonClickedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0xB5,
                0x44,
                0x8E,
                0x02,
                0xF9,
                0x00,
                0x4A,
                0xB5,
                0x36,
                0xF3,
                0x79,
                0x92,
                0xE6,
                0xA2,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0xFB,
                0xA0,
                0xAB,
                0x98,
                0x43,
                0x9D,
                0x48,
                0x8E,
                0x44,
                0xE6,
                0x13,
                0x09,
                0x27,
                0x01,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0xA6,
                0x56,
                0xF1,
                0x97,
                0x79,
                0xD9,
                0x48,
                0xA1,
                0x0C,
                0x26,
                0x9D,
                0x46,
                0x53,
                0x3F,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformationCustomPairing
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0x8C,
                0x13,
                0x85,
                0xE6,
                0x4E,
                0x14,
                0x49,
                0x83,
                0x70,
                0x10,
                0x7A,
                0x39,
                0x14,
                0x4C,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformationPairing
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0x69,
                0x47,
                0x2C,
                0x84,
                0xF6,
                0xD5,
                0x40,
                0x84,
                0x69,
                0xE8,
                0xDB,
                0xAA,
                0xB7,
                0x04,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformationPairing2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x12,
                0x86,
                0xF6,
                0xEE,
                0x0A,
                0x28,
                0x43,
                0x85,
                0xCC,
                0x1C,
                0x74,
                0x2B,
                0xB1,
                0x79,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformationPairingStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xC4,
                0x15,
                0xE9,
                0xD4,
                0x36,
                0xA1,
                0x49,
                0xBF,
                0x13,
                0x51,
                0x41,
                0x73,
                0x79,
                0x9B,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformationPairingStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x53,
                0xDE,
                0x04,
                0xB7,
                0xB7,
                0x6B,
                0x47,
                0xA7,
                0x4F,
                0xC5,
                0x83,
                0x6A,
                0x70,
                0x4D,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x10,
                0x7F,
                0xC1,
                0x46,
                0x3A,
                0x78,
                0x4A,
                0x80,
                0x13,
                0x76,
                0x9D,
                0xC9,
                0xB9,
                0x73,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformationStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x4F,
                0x3B,
                0x49,
                0x4F,
                0xA8,
                0xFD,
                0x45,
                0x91,
                0x67,
                0x15,
                0xD1,
                0xCB,
                0x1B,
                0xD1,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformationUpdate
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x53,
                0x31,
                0x8F,
                0x72,
                0xD9,
                0xB7,
                0x44,
                0xA3,
                0x7E,
                0x9E,
                0x82,
                0x2C,
                0x78,
                0x21,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceInformationUpdate2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x14,
                0x9D,
                0x5D,
                0x73,
                0xA8,
                0x5E,
                0x48,
                0xBA,
                0xA6,
                0xAA,
                0x62,
                0x07,
                0x88,
                0xE3,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDevicePairingRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0xFC,
                0x17,
                0xF7,
                0x6B,
                0xDE,
                0x7F,
                0x48,
                0x83,
                0x76,
                0x01,
                0x80,
                0xAC,
                0xA6,
                0x99,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDevicePairingRequestedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x52,
                0x37,
                0xC8,
                0xD3,
                0xE4,
                0xB0,
                0x4D,
                0xA3,
                0x60,
                0xA1,
                0x05,
                0xE4,
                0x37,
                0xDB,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDevicePairingResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x02,
                0x2B,
                0x07,
                0x95,
                0xDD,
                0x25,
                0x40,
                0x9B,
                0x37,
                0xDE,
                0x51,
                0xAD,
                0xBA,
                0x37,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDevicePairingSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0xB2,
                0x2C,
                0x48,
                0xBB,
                0x83,
                0x0E,
                0x42,
                0xBE,
                0x51,
                0x66,
                0x02,
                0xB2,
                0x22,
                0xDE,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDevicePicker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x7A,
                0x99,
                0x84,
                0x4A,
                0x03,
                0x40,
                0x44,
                0x88,
                0x13,
                0x7D,
                0x0B,
                0xD4,
                0x79,
                0xBF,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDevicePickerAppearance
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x12,
                0x9A,
                0xE6,
                0x27,
                0xE6,
                0xD8,
                0x4E,
                0x9B,
                0x6C,
                0x46,
                0x0A,
                0xF4,
                0x45,
                0xE5,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDevicePickerFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x92,
                0xDB,
                0x91,
                0xCB,
                0x57,
                0xF1,
                0x48,
                0x9B,
                0x59,
                0xA5,
                0x9B,
                0x7A,
                0x1F,
                0x02,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceSelectedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0xDA,
                0x9E,
                0x26,
                0x2F,
                0x1D,
                0x40,
                0x49,
                0x84,
                0x02,
                0x41,
                0x56,
                0xB8,
                0x1D,
                0x3C,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceUnpairingResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x4A,
                0xF4,
                0x66,
                0xD9,
                0x79,
                0x4B,
                0x44,
                0x92,
                0xCF,
                0xA9,
                0x2E,
                0xF7,
                0x25,
                0x71,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xB9,
                0xEA,
                0xC9,
                0x6B,
                0x8F,
                0x96,
                0x4F,
                0xA9,
                0xF4,
                0xAB,
                0xC8,
                0x14,
                0xE2,
                0x22,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceWatcher2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x45,
                0x08,
                0xFF,
                0x14,
                0xED,
                0xE9,
                0x49,
                0x9A,
                0x69,
                0x81,
                0x17,
                0xC5,
                0x4A,
                0xE9,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceWatcherEvent
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0x9C,
                0xAA,
                0x74,
                0xBD,
                0x1D,
                0xFD,
                0x47,
                0xB6,
                0x35,
                0x3C,
                0xC5,
                0x56,
                0xD0,
                0xFF,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceWatcherTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x81,
                0x80,
                0x38,
                0xB7,
                0x4C,
                0x57,
                0x4E,
                0xA5,
                0x6D,
                0x77,
                0x6D,
                0x07,
                0xCB,
                0xFE,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEnclosureLocation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x0A,
                0x34,
                0x42,
                0x10,
                0x58,
                0x9C,
                0x45,
                0xAA,
                0xBB,
                0xC6,
                0x5E,
                0x1F,
                0x81,
                0x3E,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEnclosureLocation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x99,
                0x85,
                0x28,
                0x7D,
                0xE0,
                0x5D,
                0x48,
                0x8A,
                0x9E,
                0xBD,
                0xF2,
                0x9A,
                0xEF,
                0x4F,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
