// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ICastingConnection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x16,
                0x95,
                0xCD,
                0xF1,
                0xC2,
                0x98,
                0x44,
                0x8B,
                0x78,
                0x5F,
                0xB4,
                0xCD,
                0x36,
                0x40,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICastingConnectionErrorOccurredEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0x3C,
                0xFB,
                0xA7,
                0x19,
                0x87,
                0x00,
                0x4F,
                0x81,
                0xFB,
                0x96,
                0x18,
                0x63,
                0xC7,
                0x9A,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICastingDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x1C,
                0x72,
                0xDE,
                0x43,
                0x4A,
                0xD1,
                0x4A,
                0xA6,
                0xD2,
                0x24,
                0x92,
                0xA7,
                0x96,
                0xC3,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICastingDevicePicker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x99,
                0xD3,
                0xDC,
                0x91,
                0x05,
                0xBE,
                0x49,
                0xAA,
                0xCB,
                0x4B,
                0x82,
                0xEE,
                0x75,
                0x6A,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICastingDevicePickerFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0x61,
                0x8C,
                0xBE,
                0x63,
                0xB5,
                0x54,
                0x43,
                0xAE,
                0x33,
                0x9F,
                0xDA,
                0xAD,
                0x8C,
                0x62,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICastingDeviceSelectedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x9E,
                0x43,
                0xDC,
                0x57,
                0xDD,
                0x0D,
                0x4D,
                0x94,
                0x00,
                0xAF,
                0x45,
                0xE4,
                0xFB,
                0x36,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICastingDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x58,
                0xD9,
                0xE7,
                0x13,
                0x4D,
                0x37,
                0x42,
                0xA3,
                0x65,
                0x4C,
                0x4F,
                0x6A,
                0x4C,
                0xFD,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICastingSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0xEA,
                0x29,
                0xF4,
                0x67,
                0x34,
                0xE6,
                0x47,
                0xA0,
                0x27,
                0x52,
                0x29,
                0x23,
                0xE9,
                0xD7,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
