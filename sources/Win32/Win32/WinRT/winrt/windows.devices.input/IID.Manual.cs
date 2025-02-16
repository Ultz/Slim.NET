// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IKeyboardCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x9B,
                0x3F,
                0x3A,
                0x98,
                0x67,
                0xBC,
                0x4B,
                0x83,
                0x3E,
                0x0F,
                0x34,
                0xB1,
                0x7C,
                0x65,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMouseCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0xE0,
                0xA5,
                0xBC,
                0xD9,
                0x7D,
                0x6B,
                0x4B,
                0x9A,
                0x92,
                0x55,
                0xD4,
                0x3C,
                0xB3,
                0x8F,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMouseDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xF4,
                0xED,
                0x88,
                0xC8,
                0xF2,
                0xF4,
                0x49,
                0xBE,
                0x1F,
                0xC2,
                0x56,
                0xB3,
                0x88,
                0xBC,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMouseDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x90,
                0x4A,
                0x48,
                0x70,
                0x6D,
                0xDB,
                0x49,
                0x8E,
                0x68,
                0x46,
                0xFF,
                0xBD,
                0x17,
                0xD3,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMouseEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xAA,
                0x25,
                0xF6,
                0x54,
                0x23,
                0xC7,
                0x4C,
                0x92,
                0x30,
                0x96,
                0x94,
                0x1C,
                0x96,
                0x9F,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenButtonListener
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0xC3,
                0x45,
                0x82,
                0xE3,
                0x1E,
                0xF7,
                0x53,
                0xB1,
                0xF7,
                0x83,
                0x34,
                0xA1,
                0x6F,
                0x28,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenButtonListenerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0xA5,
                0xA8,
                0x19,
                0x2F,
                0x86,
                0x69,
                0x5F,
                0xBF,
                0xEA,
                0x05,
                0xF6,
                0x58,
                0x4F,
                0x13,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x6E,
                0x85,
                0x31,
                0x38,
                0xA7,
                0x8C,
                0x5A,
                0xB8,
                0xF6,
                0xF9,
                0x7E,
                0xF6,
                0x8D,
                0x18,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenDevice2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xD3,
                0x07,
                0x02,
                0xB8,
                0x7F,
                0x66,
                0x55,
                0x8C,
                0x34,
                0xF8,
                0x34,
                0x20,
                0x37,
                0xB7,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xBE,
                0xFB,
                0x9D,
                0x66,
                0x09,
                0x80,
                0x51,
                0xBC,
                0xB4,
                0xB8,
                0x50,
                0x60,
                0xE3,
                0x94,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenDockListener
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x4D,
                0x9F,
                0x75,
                0xC0,
                0x1D,
                0xCB,
                0x55,
                0xAD,
                0x18,
                0xB9,
                0x10,
                0x14,
                0x56,
                0xF5,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenDockListenerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x5E,
                0xB7,
                0xCA,
                0x16,
                0x00,
                0x72,
                0x5C,
                0x96,
                0x9E,
                0xA9,
                0x7E,
                0x11,
                0x99,
                0x2A,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenDockedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x77,
                0x42,
                0xFD,
                0x63,
                0xCA,
                0x4E,
                0x5D,
                0x9E,
                0xD3,
                0xA2,
                0x8A,
                0x54,
                0x52,
                0x1C,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenTailButtonClickedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xB7,
                0x2F,
                0x5D,
                0xD3,
                0x6A,
                0x3E,
                0x5D,
                0xAB,
                0x29,
                0x05,
                0xEA,
                0x24,
                0x10,
                0xE3,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenTailButtonDoubleClickedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x21,
                0x63,
                0x84,
                0x8A,
                0x61,
                0x78,
                0x54,
                0xB0,
                0x4C,
                0xB3,
                0x58,
                0x23,
                0x1D,
                0xA4,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenTailButtonLongPressedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x60,
                0x7C,
                0xF3,
                0x0A,
                0xC6,
                0x42,
                0x5F,
                0xB8,
                0x18,
                0xA5,
                0x31,
                0x12,
                0x40,
                0x6C,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPenUndockedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x91,
                0xD0,
                0xCC,
                0x1B,
                0x26,
                0xE6,
                0x59,
                0xA5,
                0xD4,
                0xC1,
                0x96,
                0x4C,
                0xD0,
                0x3F,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xBA,
                0xC9,
                0x93,
                0xCB,
                0xEB,
                0x7E,
                0x46,
                0x82,
                0xC6,
                0x27,
                0x6F,
                0xEA,
                0xE3,
                0x6B,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerDevice2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0xD2,
                0xA6,
                0xF8,
                0x84,
                0xC4,
                0x9F,
                0x48,
                0xAE,
                0x3E,
                0x30,
                0xD2,
                0xEE,
                0x1F,
                0xFD,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x9A,
                0xB8,
                0xD8,
                0xC6,
                0xD1,
                0x6E,
                0x41,
                0xBD,
                0x8D,
                0x57,
                0x90,
                0x91,
                0x4D,
                0xC5,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITouchCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x55,
                0xDD,
                0x20,
                0xF1,
                0x13,
                0xC8,
                0x46,
                0x92,
                0x85,
                0x2C,
                0x05,
                0xFA,
                0x3E,
                0xDA,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
