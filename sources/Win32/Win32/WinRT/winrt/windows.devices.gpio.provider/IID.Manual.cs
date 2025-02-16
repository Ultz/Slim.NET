// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.gpio.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IGpioControllerProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xCE,
                0x11,
                0xAD,
                0xEA,
                0x19,
                0x21,
                0x4B,
                0x87,
                0x4F,
                0xB9,
                0x1A,
                0xED,
                0x4A,
                0x25,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioPinProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x4C,
                0x34,
                0x42,
                0xBC,
                0x6A,
                0xFF,
                0x40,
                0x9C,
                0xE7,
                0x73,
                0xB8,
                0x53,
                0x01,
                0xB9,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioPinProviderValueChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xD6,
                0xA6,
                0x32,
                0x5B,
                0x3D,
                0xCD,
                0x44,
                0x8F,
                0xBE,
                0x13,
                0xA6,
                0x9F,
                0x2E,
                0xDB,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioPinProviderValueChangedEventArgsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x0B,
                0xCB,
                0x3E,
                0x8C,
                0x56,
                0x92,
                0x43,
                0xB2,
                0x4A,
                0x8A,
                0x59,
                0xA9,
                0x02,
                0xB1,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGpioProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x27,
                0xE8,
                0x44,
                0xCA,
                0x08,
                0x4A,
                0x43,
                0xAF,
                0xE0,
                0xD6,
                0x15,
                0x80,
                0x44,
                0x6F,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
