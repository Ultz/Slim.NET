// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IColorHelper
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xFB,
                0x3C,
                0x19,
                0xC7,
                0x65,
                0x40,
                0x45,
                0xAD,
                0x08,
                0x62,
                0x83,
                0xBA,
                0x76,
                0x87,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IColorHelperStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0xDB,
                0x04,
                0x85,
                0x6A,
                0xFB,
                0x44,
                0x41,
                0xA6,
                0xC2,
                0x33,
                0x49,
                0x9C,
                0x92,
                0x84,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IColorHelperStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xAF,
                0xD9,
                0x24,
                0xB0,
                0x6E,
                0x94,
                0x4B,
                0x85,
                0x5C,
                0xFC,
                0xF0,
                0x81,
                0x8D,
                0x9A,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IColors
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x93,
                0x8C,
                0x9B,
                0xA6,
                0x4C,
                0xE5,
                0x4C,
                0x89,
                0x94,
                0x9E,
                0xFF,
                0x65,
                0xCA,
                0xBD,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IColorsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x2E,
                0xF5,
                0xCF,
                0xA6,
                0xCC,
                0x14,
                0x46,
                0xA1,
                0x7E,
                0x75,
                0x49,
                0x10,
                0xC8,
                0x4A,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIContentRoot
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0xBA,
                0xFC,
                0x1D,
                0x6B,
                0xB3,
                0xB9,
                0x5C,
                0x9B,
                0xC5,
                0x2B,
                0x7A,
                0x0E,
                0xDD,
                0xC3,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0xFA,
                0x5C,
                0xBB,
                0xD8,
                0x5B,
                0xD0,
                0x59,
                0xA5,
                0x9E,
                0x1C,
                0x17,
                0xA4,
                0xD6,
                0xD2,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
