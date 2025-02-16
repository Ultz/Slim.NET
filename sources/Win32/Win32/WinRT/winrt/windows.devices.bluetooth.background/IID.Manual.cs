// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBluetoothLEAdvertisementPublisherTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0xCA,
                0x0E,
                0x61,
                0x80,
                0x34,
                0xC9,
                0x41,
                0xA9,
                0x18,
                0x7D,
                0xDA,
                0xDF,
                0x20,
                0x7E,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementPublisherTriggerDetails2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0xD0,
                0xA3,
                0xD4,
                0x01,
                0xC6,
                0xD6,
                0x42,
                0x98,
                0x29,
                0x4C,
                0xCB,
                0x3F,
                0x5C,
                0xD7,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementWatcherTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x5A,
                0xDB,
                0xA7,
                0x57,
                0x22,
                0x69,
                0x4E,
                0x97,
                0x84,
                0xFE,
                0xE6,
                0x45,
                0xC1,
                0xDC,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristicNotificationTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x3B,
                0xA0,
                0x9B,
                0xEC,
                0x0F,
                0x6A,
                0x43,
                0x93,
                0xB1,
                0xF4,
                0x6C,
                0x69,
                0x75,
                0x32,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristicNotificationTriggerDetails2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x50,
                0x7A,
                0x72,
                0x9D,
                0x94,
                0x4A,
                0x45,
                0xB1,
                0x92,
                0x98,
                0x34,
                0x67,
                0xE3,
                0xD5,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderConnection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xB9,
                0xA1,
                0x7F,
                0x13,
                0x2F,
                0xB5,
                0x40,
                0x95,
                0x82,
                0x8E,
                0xB7,
                0x8E,
                0x98,
                0xEF,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderConnectionStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x9F,
                0x50,
                0x3D,
                0x0E,
                0x0B,
                0x66,
                0x44,
                0xB8,
                0xCD,
                0x6E,
                0xBD,
                0xDA,
                0x1F,
                0xA1,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x06,
                0x8C,
                0xAE,
                0xFF,
                0x05,
                0xFB,
                0x4A,
                0xB1,
                0x6A,
                0xDE,
                0x95,
                0xF3,
                0xCF,
                0x01,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommConnectionTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x73,
                0x22,
                0xF9,
                0x3C,
                0x2E,
                0xFC,
                0x4E,
                0xAB,
                0x59,
                0xFC,
                0x5C,
                0xF9,
                0x6F,
                0x97,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommInboundConnectionInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x75,
                0x3E,
                0x6D,
                0x29,
                0x54,
                0x59,
                0x40,
                0x92,
                0xE3,
                0x1E,
                0x8B,
                0x65,
                0x52,
                0x87,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommOutboundConnectionInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x22,
                0x91,
                0xB0,
                0x34,
                0xF4,
                0xB0,
                0x4C,
                0x99,
                0xB1,
                0x4A,
                0xB8,
                0xCE,
                0xDA,
                0xED,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
