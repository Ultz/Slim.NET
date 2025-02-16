// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IGpioChangeCounter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0xC0,
                0x5E,
                0xCB,
                0x01,
                0x68,
                0xFF,
                0x43,
                0x80,
                0x3D,
                0x45,
                0x76,
                0x62,
                0x8A,
                0x8B,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioChangeCounterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x94,
                0x7D,
                0x14,
                0x9E,
                0x0A,
                0x0C,
                0x41,
                0xB4,
                0xFA,
                0xF8,
                0x9F,
                0x40,
                0x52,
                0x08,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioChangeReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x88,
                0xBC,
                0x0A,
                0x31,
                0xE0,
                0xE8,
                0x48,
                0x85,
                0x90,
                0x70,
                0xDE,
                0x78,
                0x36,
                0x3C,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioChangeReaderFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x8E,
                0x59,
                0xA9,
                0x0E,
                0x39,
                0x1A,
                0x44,
                0x9D,
                0x1C,
                0xE8,
                0xDE,
                0x0B,
                0x2D,
                0xF0,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x12,
                0x40,
                0x28,
                0x61,
                0x74,
                0x9C,
                0x46,
                0xA8,
                0xBC,
                0x61,
                0xD6,
                0x9D,
                0x08,
                0xA5,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0xF4,
                0xD6,
                0x2E,
                0xF7,
                0x7A,
                0x16,
                0x41,
                0x95,
                0x33,
                0xC4,
                0x3D,
                0x99,
                0xA1,
                0xFB,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioControllerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x7D,
                0x2B,
                0x91,
                0xA4,
                0x6C,
                0x06,
                0x41,
                0xA3,
                0x73,
                0xFF,
                0xFD,
                0x34,
                0x6B,
                0x0E,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioPin
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0xB0,
                0xD9,
                0x11,
                0xAE,
                0xAF,
                0x90,
                0x47,
                0x9E,
                0xE9,
                0xE0,
                0xEA,
                0xC9,
                0x42,
                0xD2,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioPinValueChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0xAA,
                0x37,
                0x31,
                0x3D,
                0x70,
                0x59,
                0x40,
                0xBD,
                0x24,
                0xB5,
                0xB2,
                0x5D,
                0xFF,
                0xB8,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
