// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IGattCharacteristic
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x50,
                0xCB,
                0x59,
                0x34,
                0x59,
                0x68,
                0x4F,
                0xA1,
                0x98,
                0xEB,
                0x86,
                0x4F,
                0xA4,
                0x4E,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristic2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xB5,
                0x1A,
                0xAE,
                0x06,
                0xEC,
                0x64,
                0x47,
                0xB7,
                0x80,
                0x98,
                0x35,
                0xA1,
                0xD3,
                0x5D,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristic3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x66,
                0x3C,
                0x3F,
                0xD4,
                0x93,
                0x6B,
                0x40,
                0xB8,
                0x17,
                0xDB,
                0x81,
                0xF8,
                0xED,
                0x53,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristicStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x50,
                0xCB,
                0x59,
                0x34,
                0x59,
                0x68,
                0x4F,
                0xA1,
                0x98,
                0xEB,
                0x86,
                0x4F,
                0xA4,
                0x4E,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristicUuidsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x45,
                0xFA,
                0x58,
                0xDE,
                0xB1,
                0x0C,
                0x47,
                0xB7,
                0xDE,
                0x0D,
                0x11,
                0xFF,
                0x44,
                0xF4,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristicUuidsStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0xB4,
                0x55,
                0x18,
                0x6E,
                0xD4,
                0x2C,
                0x4A,
                0x9C,
                0x3F,
                0xED,
                0x6D,
                0xEA,
                0x29,
                0xE7,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristicsResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x94,
                0x94,
                0x11,
                0x57,
                0xB2,
                0x3E,
                0x4F,
                0x9D,
                0xB7,
                0xF6,
                0x8B,
                0xC9,
                0xA9,
                0xAE,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattClientNotificationResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x55,
                0x6D,
                0x50,
                0x12,
                0x01,
                0x9A,
                0x41,
                0x8E,
                0x3B,
                0xAE,
                0x21,
                0xAF,
                0xAB,
                0xD2,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattClientNotificationResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0xC4,
                0xAE,
                0x8F,
                0xE0,
                0x45,
                0x7E,
                0x49,
                0x95,
                0x82,
                0x29,
                0xA1,
                0xFE,
                0x28,
                0x1A,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDescriptor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x5F,
                0x05,
                0x92,
                0x84,
                0x80,
                0x44,
                0x43,
                0xB4,
                0xC2,
                0x28,
                0x4D,
                0xE1,
                0x9A,
                0x85,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDescriptor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x3D,
                0x56,
                0x8F,
                0x30,
                0xD6,
                0x6C,
                0x40,
                0xBA,
                0x11,
                0x10,
                0xCD,
                0xD1,
                0x6B,
                0x0E,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDescriptorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x5F,
                0x05,
                0x92,
                0x84,
                0x80,
                0x44,
                0x43,
                0xB4,
                0xC2,
                0x28,
                0x4D,
                0xE1,
                0x9A,
                0x85,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDescriptorUuidsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x62,
                0xF8,
                0xA6,
                0xFC,
                0x9C,
                0xF1,
                0x42,
                0x91,
                0x85,
                0xFF,
                0x37,
                0xB7,
                0x51,
                0x81,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDescriptorsResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x91,
                0xC0,
                0x9B,
                0xE7,
                0x95,
                0x89,
                0x44,
                0x8D,
                0x25,
                0xFF,
                0x81,
                0x95,
                0x5A,
                0x57,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDeviceService
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x7C,
                0x7B,
                0xAC,
                0x3C,
                0xB3,
                0xCF,
                0x47,
                0x99,
                0x0F,
                0x6B,
                0x8F,
                0x55,
                0x77,
                0xDF,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDeviceService2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0x52,
                0x54,
                0xFC,
                0x0D,
                0x0B,
                0x08,
                0x47,
                0xBA,
                0xE0,
                0x9F,
                0xFD,
                0x94,
                0x89,
                0xBC,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDeviceService3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xA9,
                0x93,
                0xB2,
                0x53,
                0x0C,
                0x7C,
                0x43,
                0xA9,
                0xB3,
                0x5C,
                0x32,
                0x10,
                0xC6,
                0xE5,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDeviceServiceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x00,
                0x6D,
                0x19,
                0xAD,
                0xFA,
                0xDC,
                0x45,
                0xAE,
                0x5B,
                0x2A,
                0xC3,
                0x18,
                0x4E,
                0x84,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDeviceServiceStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x18,
                0x04,
                0x06,
                0xA6,
                0x24,
                0x0D,
                0x4B,
                0xA2,
                0xF2,
                0x30,
                0xCC,
                0x01,
                0x54,
                0x5D,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattDeviceServicesResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0xD3,
                0x1D,
                0x17,
                0x6D,
                0x01,
                0x9D,
                0x41,
                0x83,
                0x8A,
                0x57,
                0x6C,
                0xF4,
                0x75,
                0xA3,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattLocalCharacteristic
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x37,
                0xDE,
                0xAE,
                0x12,
                0x54,
                0x74,
                0x4D,
                0x92,
                0xA8,
                0x8D,
                0xEB,
                0x85,
                0x26,
                0x82,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattLocalCharacteristicParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x3D,
                0xF7,
                0xFA,
                0xFF,
                0x4C,
                0xC7,
                0x44,
                0x84,
                0x45,
                0x04,
                0x0E,
                0x6E,
                0xAD,
                0x00,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattLocalCharacteristicResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xDE,
                0x75,
                0x79,
                0x70,
                0x01,
                0x97,
                0x43,
                0x96,
                0x66,
                0x92,
                0xF8,
                0x63,
                0xF1,
                0x2E,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattLocalDescriptor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xBE,
                0x8E,
                0xF4,
                0x9D,
                0x78,
                0x4B,
                0x4A,
                0x86,
                0x52,
                0xBD,
                0x01,
                0x7B,
                0x5D,
                0x2F,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattLocalDescriptorParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xDE,
                0xDE,
                0x5F,
                0xC1,
                0xF3,
                0x66,
                0x4B,
                0x8C,
                0x4B,
                0xE3,
                0xD2,
                0x29,
                0x3B,
                0x40,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattLocalDescriptorResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x91,
                0x57,
                0x37,
                0x1F,
                0x32,
                0x66,
                0x43,
                0xBF,
                0xC1,
                0x3B,
                0xC6,
                0xB8,
                0x2C,
                0x79,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattLocalService
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xE2,
                0x13,
                0xF5,
                0xF7,
                0xF7,
                0x02,
                0x49,
                0xB8,
                0x03,
                0x57,
                0xFC,
                0xC7,
                0xD6,
                0xFE,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattPresentationFormat
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x00,
                0x6D,
                0x19,
                0xAD,
                0xFA,
                0xDC,
                0x45,
                0xAE,
                0x5B,
                0x2A,
                0xC3,
                0x18,
                0x4E,
                0x84,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattPresentationFormatStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x00,
                0x6D,
                0x19,
                0xAD,
                0xFA,
                0xDC,
                0x45,
                0xAE,
                0x5B,
                0x2A,
                0xC3,
                0x18,
                0x4E,
                0x84,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattPresentationFormatStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x17,
                0xC2,
                0xA9,
                0x2F,
                0xB8,
                0x5E,
                0x43,
                0xB6,
                0x34,
                0x21,
                0xFD,
                0x85,
                0xA4,
                0x3C,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattPresentationFormatTypesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0xBA,
                0xF1,
                0xFA,
                0xBA,
                0x30,
                0x9C,
                0x40,
                0xBE,
                0xF7,
                0xCF,
                0xFB,
                0x6D,
                0x03,
                0xB8,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattProtocolErrorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0xC5,
                0x46,
                0xCA,
                0xCC,
                0x0E,
                0x09,
                0x48,
                0xBE,
                0xA3,
                0xCF,
                0x79,
                0xBC,
                0x99,
                0x1E,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattReadClientCharacteristicConfigurationDescriptorResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x6F,
                0xA6,
                0x63,
                0xEA,
                0x1A,
                0x4C,
                0x4C,
                0xA5,
                0x0F,
                0x97,
                0xBA,
                0xE4,
                0x74,
                0xB3,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattReadClientCharacteristicConfigurationDescriptorResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0xA5,
                0xF1,
                0x1B,
                0x4D,
                0xBA,
                0x22,
                0x46,
                0x86,
                0x51,
                0xF4,
                0xEE,
                0x15,
                0x0D,
                0x0A,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattReadRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x65,
                0xDD,
                0xF1,
                0xCD,
                0x6A,
                0xA6,
                0x42,
                0xA4,
                0xBB,
                0xD7,
                0x89,
                0xDA,
                0xE0,
                0x04,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattReadRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x72,
                0x49,
                0x93,
                0x9C,
                0xF3,
                0x4B,
                0x48,
                0x8A,
                0xB6,
                0x99,
                0x6B,
                0xA4,
                0x86,
                0xCF,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattReadResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x6F,
                0xA6,
                0x63,
                0xEA,
                0x1A,
                0x4C,
                0x4C,
                0xA5,
                0x0F,
                0x97,
                0xBA,
                0xE4,
                0x74,
                0xB3,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattReadResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x50,
                0x0F,
                0xA1,
                0x43,
                0xFB,
                0xAF,
                0x48,
                0xBA,
                0xAA,
                0x63,
                0x8A,
                0x5C,
                0x63,
                0x29,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattReliableWriteTransaction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x6F,
                0xA6,
                0x63,
                0xEA,
                0x1A,
                0x4C,
                0x4C,
                0xA5,
                0x0F,
                0x97,
                0xBA,
                0xE4,
                0x74,
                0xB3,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattReliableWriteTransaction2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x39,
                0x11,
                0x51,
                0x12,
                0xEF,
                0x2F,
                0x46,
                0x9F,
                0xB2,
                0xA1,
                0xA4,
                0x3A,
                0x67,
                0x94,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattRequestStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0xD9,
                0x34,
                0xE8,
                0xBE,
                0x27,
                0xB3,
                0x44,
                0x9D,
                0x0D,
                0x4F,
                0xC6,
                0xE8,
                0x08,
                0xDD,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0xB3,
                0x22,
                0x78,
                0x89,
                0x28,
                0x86,
                0x4F,
                0xA0,
                0x51,
                0x3F,
                0x0A,
                0xED,
                0x1C,
                0x27,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderAdvertisementStatusChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xAA,
                0xA5,
                0x59,
                0x21,
                0xFA,
                0xFC,
                0x4F,
                0xB1,
                0x55,
                0x04,
                0xD9,
                0x28,
                0x01,
                0x26,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderAdvertisingParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x31,
                0xCE,
                0xE2,
                0x15,
                0x63,
                0x22,
                0x4C,
                0x9B,
                0xD7,
                0x78,
                0x1D,
                0xBC,
                0x3D,
                0x8D,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderAdvertisingParameters2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x46,
                0x68,
                0xFF,
                0x92,
                0xCA,
                0x34,
                0x44,
                0x97,
                0x43,
                0x0E,
                0x90,
                0x98,
                0x8A,
                0xD8,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x96,
                0x46,
                0x76,
                0x3E,
                0xC5,
                0x8C,
                0x42,
                0x8A,
                0x48,
                0x67,
                0xAF,
                0xE0,
                0x2C,
                0x3A,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0x40,
                0x79,
                0x31,
                0x56,
                0x52,
                0x54,
                0x40,
                0xA4,
                0xF4,
                0x7B,
                0xBE,
                0x77,
                0x55,
                0xA5,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceUuidsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x70,
                0xC5,
                0x6D,
                0xBA,
                0x9A,
                0x17,
                0x44,
                0xB8,
                0xF2,
                0xDC,
                0xE0,
                0x16,
                0xD3,
                0x4E,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceUuidsStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0x94,
                0xAE,
                0xD2,
                0x15,
                0x3D,
                0x79,
                0x4F,
                0x9C,
                0x0C,
                0xEA,
                0xAF,
                0xA6,
                0x75,
                0x15,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattSession
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x51,
                0x3B,
                0xD2,
                0x4E,
                0xE0,
                0x24,
                0x4C,
                0x99,
                0x9C,
                0x9C,
                0x25,
                0x6F,
                0x98,
                0x56,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattSessionStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0xB9,
                0x65,
                0x2E,
                0x9F,
                0x53,
                0xB7,
                0x4D,
                0x82,
                0xA8,
                0x73,
                0xBD,
                0xBB,
                0xF7,
                0x3E,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattSessionStatusChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0xB7,
                0x05,
                0x76,
                0x7F,
                0x83,
                0x4C,
                0x40,
                0xAB,
                0x34,
                0x31,
                0x63,
                0xF3,
                0x9D,
                0xDF,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattSubscribedClient
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x90,
                0x6E,
                0x73,
                0xA4,
                0x15,
                0xC2,
                0x4E,
                0x92,
                0x48,
                0xE3,
                0xF2,
                0x0D,
                0x46,
                0x3B,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattValueChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xDB,
                0x1B,
                0xD2,
                0xE3,
                0x06,
                0xD8,
                0x4E,
                0xA2,
                0x63,
                0xAC,
                0xFA,
                0xC8,
                0xBA,
                0x73,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattWriteRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0xA9,
                0xB6,
                0xAE,
                0x2F,
                0xDE,
                0xC2,
                0x4F,
                0xA9,
                0xA8,
                0x94,
                0xEA,
                0x78,
                0x44,
                0xF1,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattWriteRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x8B,
                0xEC,
                0x2D,
                0x3A,
                0xA7,
                0x1A,
                0x47,
                0x94,
                0xD5,
                0x03,
                0x7D,
                0xEA,
                0xDD,
                0x08,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattWriteResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0xDD,
                0x91,
                0x49,
                0x2B,
                0xCB,
                0xF7,
                0x44,
                0x99,
                0xFC,
                0xD2,
                0x9A,
                0x28,
                0x71,
                0xDC,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
