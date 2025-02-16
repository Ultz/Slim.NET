// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ICoreTextCompositionCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xEB,
                0x34,
                0x1F,
                0x9F,
                0xB7,
                0x21,
                0x41,
                0xA5,
                0xE7,
                0xFD,
                0xA9,
                0xB8,
                0x61,
                0x6E,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextCompositionSegment
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x6B,
                0x6C,
                0x77,
                0xAD,
                0x4E,
                0xA7,
                0x4D,
                0x8F,
                0x47,
                0x3A,
                0x88,
                0xB5,
                0x23,
                0xCC,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextCompositionStartedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x16,
                0x6B,
                0x27,
                0xE7,
                0x64,
                0xB0,
                0x4A,
                0xBC,
                0x4B,
                0xA0,
                0x2D,
                0x73,
                0x83,
                0x5B,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextEditContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x08,
                0x66,
                0xBF,
                0x41,
                0x40,
                0xC3,
                0x47,
                0xB2,
                0x63,
                0xA9,
                0x18,
                0xEB,
                0x5E,
                0xAE,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextEditContext2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x7D,
                0x86,
                0xB1,
                0x3B,
                0x08,
                0xE1,
                0x49,
                0xB2,
                0x81,
                0x2B,
                0x35,
                0xD6,
                0x2B,
                0xF4,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextFormatUpdatingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0xBD,
                0x10,
                0x73,
                0xA8,
                0xB4,
                0xB1,
                0x43,
                0xB3,
                0x7B,
                0x07,
                0x24,
                0xD4,
                0xAC,
                0xA7,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextLayoutBounds
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0xC9,
                0x72,
                0xE9,
                0x36,
                0x44,
                0x17,
                0x49,
                0x80,
                0xD0,
                0xA5,
                0x25,
                0xE4,
                0xCA,
                0x67,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextLayoutRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0xA8,
                0x55,
                0x25,
                0xFD,
                0x51,
                0x03,
                0x4F,
                0x98,
                0xBF,
                0xAC,
                0x78,
                0x17,
                0x4D,
                0x68,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextLayoutRequest2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0xE6,
                0x6D,
                0x67,
                0x3D,
                0xCD,
                0xCD,
                0x4B,
                0xBF,
                0x01,
                0x7F,
                0x71,
                0x10,
                0x95,
                0x45,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextLayoutRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x6A,
                0xDC,
                0xB1,
                0x7B,
                0x9A,
                0x9E,
                0x4E,
                0xA5,
                0x66,
                0x4A,
                0x6B,
                0x5F,
                0x8A,
                0xD6,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextSelectionRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x04,
                0xA7,
                0xF0,
                0x8B,
                0x20,
                0x01,
                0x43,
                0x88,
                0x3C,
                0x74,
                0xCA,
                0x74,
                0x85,
                0xFD,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextSelectionRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x68,
                0xC6,
                0x13,
                0x14,
                0xF6,
                0x1A,
                0x42,
                0x8F,
                0x4B,
                0x9E,
                0xC8,
                0xA5,
                0xA3,
                0x7F,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextSelectionUpdatingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x83,
                0x45,
                0xD4,
                0x7F,
                0xFE,
                0xD5,
                0x4B,
                0x8A,
                0x26,
                0x09,
                0x22,
                0xC1,
                0xB3,
                0xE6,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextServicesManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x7D,
                0x50,
                0xC2,
                0x0A,
                0x6E,
                0x8A,
                0x4A,
                0xBD,
                0xF8,
                0x19,
                0x48,
                0x87,
                0x48,
                0x54,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextServicesManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xA3,
                0x20,
                0x15,
                0xCF,
                0xE2,
                0x65,
                0x4D,
                0xAE,
                0xB9,
                0xB3,
                0x2D,
                0x86,
                0xFE,
                0x39,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextServicesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x9A,
                0x85,
                0x91,
                0xCF,
                0xEC,
                0xA4,
                0x47,
                0x8A,
                0xE7,
                0x09,
                0x8A,
                0x9C,
                0x6F,
                0xBB,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextTextRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x50,
                0xD9,
                0x50,
                0x1E,
                0xF5,
                0xC1,
                0x4C,
                0x8C,
                0xA1,
                0xE6,
                0x34,
                0x6D,
                0x1A,
                0x61,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextTextRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xA2,
                0x96,
                0xF0,
                0xC6,
                0x41,
                0x02,
                0x4C,
                0x8B,
                0x1A,
                0xD9,
                0x53,
                0xB0,
                0x0C,
                0xAB,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTextTextUpdatingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x91,
                0xA7,
                0xEE,
                0x2B,
                0xCC,
                0x03,
                0x4F,
                0x8F,
                0xF6,
                0x02,
                0xFD,
                0x21,
                0x7D,
                0xB4,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
