// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAppListEntry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xF0,
                0x00,
                0xEF,
                0x08,
                0x21,
                0x0A,
                0x49,
                0x87,
                0x7A,
                0x8A,
                0x9F,
                0x17,
                0xC2,
                0x5F,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppListEntry2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x18,
                0xA6,
                0xD0,
                0x35,
                0xBF,
                0xAC,
                0x42,
                0xAC,
                0x06,
                0x86,
                0xEE,
                0xEB,
                0x41,
                0xD0,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppListEntry3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0xF2,
                0x99,
                0x60,
                0x32,
                0xFC,
                0x0A,
                0x47,
                0xBC,
                0x69,
                0x4B,
                0x06,
                0x1A,
                0x76,
                0xEF,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppListEntry4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x1E,
                0x13,
                0x2A,
                0xF5,
                0x56,
                0x7C,
                0x48,
                0x86,
                0x97,
                0x51,
                0x66,
                0xF3,
                0xB3,
                0x3D,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplication
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0xF7,
                0xAC,
                0x0A,
                0x1D,
                0x5E,
                0xDF,
                0x49,
                0x80,
                0x34,
                0xFB,
                0x6A,
                0x68,
                0xBC,
                0x5E,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplication2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x81,
                0x86,
                0x99,
                0xB6,
                0x1A,
                0x7F,
                0x4B,
                0xBE,
                0x4A,
                0x9A,
                0x06,
                0x45,
                0x22,
                0x4C,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplication3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x0D,
                0xEC,
                0xFE,
                0x8B,
                0x59,
                0x07,
                0x45,
                0x8A,
                0x67,
                0x77,
                0x26,
                0x32,
                0x58,
                0x0A,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplicationExit
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x46,
                0x86,
                0xCF,
                0x1E,
                0x26,
                0x72,
                0x4B,
                0x9A,
                0xCD,
                0x44,
                0xED,
                0x2A,
                0xCE,
                0x6A,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplicationUnhandledError
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x4A,
                0xE2,
                0xF0,
                0x09,
                0xDD,
                0xE1,
                0x42,
                0xB0,
                0xBC,
                0xE0,
                0xE1,
                0x31,
                0xF7,
                0x8D,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplicationUseCount
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xC4,
                0x8D,
                0x51,
                0x77,
                0xC0,
                0x5B,
                0x47,
                0x80,
                0x9E,
                0x0B,
                0xC0,
                0xC5,
                0x7E,
                0x4B,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplicationView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xB2,
                0x8B,
                0x63,
                0x1D,
                0x45,
                0x61,
                0x46,
                0xB0,
                0x99,
                0x41,
                0x4F,
                0x34,
                0xFF,
                0xB9,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplicationView2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x7A,
                0xEB,
                0x68,
                0x7F,
                0x91,
                0xEB,
                0x48,
                0x9A,
                0xEB,
                0x7D,
                0xE5,
                0x3E,
                0x08,
                0x6A,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplicationView3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0xE1,
                0xEB,
                0x07,
                0xCF,
                0xA4,
                0x50,
                0x45,
                0xAB,
                0x70,
                0xB0,
                0x7E,
                0x85,
                0x33,
                0x0B,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplicationView5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x95,
                0xC0,
                0x2B,
                0xF0,
                0x8E,
                0x6D,
                0x44,
                0x9E,
                0x60,
                0x3A,
                0x3E,
                0x04,
                0x28,
                0xC6,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplicationView6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0xD4,
                0x19,
                0xC1,
                0x79,
                0x06,
                0xBA,
                0x49,
                0x80,
                0x3F,
                0xB7,
                0x9C,
                0x5C,
                0xF3,
                0x4C,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreApplicationViewTitleBar
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x35,
                0x6D,
                0x00,
                0xF1,
                0xE1,
                0x1B,
                0x43,
                0x95,
                0x08,
                0x29,
                0xB9,
                0x69,
                0x26,
                0xAC,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreImmersiveApplication
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x0E,
                0xDA,
                0x1A,
                0xA2,
                0xE4,
                0x23,
                0x41,
                0xB4,
                0x51,
                0xDC,
                0x96,
                0xBF,
                0x80,
                0x04,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreImmersiveApplication2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0x1E,
                0x8E,
                0x82,
                0xE3,
                0xE9,
                0xFC,
                0x4C,
                0x9B,
                0x66,
                0x48,
                0xB7,
                0x8E,
                0xA9,
                0xBB,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreImmersiveApplication3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x5B,
                0xA0,
                0x34,
                0x0D,
                0xEE,
                0xE5,
                0x41,
                0x83,
                0x14,
                0xCF,
                0x10,
                0xC9,
                0x1B,
                0xF0,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameworkView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x5C,
                0xAB,
                0xFA,
                0x24,
                0x89,
                0xAC,
                0x45,
                0xAD,
                0x0F,
                0xA0,
                0x8F,
                0xAE,
                0x5D,
                0x03,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameworkViewSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0x06,
                0x77,
                0xCD,
                0xC4,
                0x65,
                0x6C,
                0x42,
                0x94,
                0x94,
                0x34,
                0xFC,
                0x43,
                0x55,
                0x48,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHostedViewClosingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x94,
                0x38,
                0xD2,
                0x4E,
                0xB2,
                0x90,
                0x47,
                0xAC,
                0xB5,
                0x3E,
                0x42,
                0x43,
                0xC4,
                0xFF,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUnhandledError
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0xB7,
                0x59,
                0x94,
                0xB5,
                0x53,
                0x86,
                0x46,
                0x9E,
                0xAF,
                0xFA,
                0x81,
                0x62,
                0xDC,
                0x39,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUnhandledErrorDetectedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xB7,
                0x9A,
                0x67,
                0x36,
                0xB3,
                0x22,
                0x48,
                0xAC,
                0x40,
                0x0D,
                0x75,
                0x0F,
                0x0B,
                0x7A,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
