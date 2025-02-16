// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.pickers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IFileOpenPicker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x27,
                0xA8,
                0x2C,
                0xC5,
                0x12,
                0x5F,
                0x4C,
                0x89,
                0x77,
                0x94,
                0x54,
                0x77,
                0x93,
                0xC2,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileOpenPicker2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x6C,
                0xEB,
                0x8C,
                0x46,
                0xB4,
                0xF7,
                0x46,
                0xB2,
                0x65,
                0x90,
                0xF8,
                0xE5,
                0x5A,
                0xD6,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileOpenPicker3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0xC5,
                0xA5,
                0xD9,
                0xDC,
                0xC5,
                0x98,
                0x5B,
                0xBD,
                0x80,
                0xA8,
                0xD0,
                0xCA,
                0x05,
                0x84,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileOpenPickerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0x57,
                0x21,
                0x68,
                0x02,
                0x2F,
                0x33,
                0x48,
                0x96,
                0xD4,
                0xAB,
                0xBF,
                0xAD,
                0x72,
                0xB6,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileOpenPickerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x74,
                0x91,
                0xE8,
                0xDD,
                0xED,
                0x98,
                0x5C,
                0xB6,
                0xF3,
                0x36,
                0x6F,
                0xDF,
                0xCA,
                0xD3,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileOpenPickerWithOperationId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xB5,
                0x57,
                0x3F,
                0x22,
                0x25,
                0xA5,
                0x4C,
                0xAA,
                0x73,
                0xA1,
                0x55,
                0x09,
                0xF1,
                0xFC,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileSavePicker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xFF,
                0x86,
                0x32,
                0x7F,
                0x61,
                0xC5,
                0x4C,
                0xAF,
                0x6A,
                0xB3,
                0xFD,
                0xF2,
                0x9A,
                0xD1,
                0x45,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileSavePicker2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x13,
                0xC3,
                0x0E,
                0x4B,
                0xD2,
                0x9A,
                0x44,
                0x81,
                0x97,
                0xE8,
                0x91,
                0x04,
                0xFD,
                0x42,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileSavePicker3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xEC,
                0x8A,
                0x69,
                0x3C,
                0xBA,
                0x51,
                0x4E,
                0xBD,
                0x90,
                0x4A,
                0xBC,
                0xBB,
                0xF4,
                0xCF,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileSavePicker4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x3A,
                0xD8,
                0xE7,
                0xFA,
                0xDD,
                0xE0,
                0x5D,
                0x8B,
                0x70,
                0xC8,
                0x42,
                0xC2,
                0x19,
                0x88,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileSavePickerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xCF,
                0xE3,
                0x28,
                0x1C,
                0x96,
                0x2C,
                0x5E,
                0xAE,
                0xD7,
                0xE6,
                0x47,
                0x37,
                0xF4,
                0xCE,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFolderPicker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x77,
                0x4F,
                0x08,
                0xFB,
                0xF3,
                0x0A,
                0x40,
                0x99,
                0xB1,
                0x7B,
                0x4A,
                0x77,
                0x2F,
                0xD6,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFolderPicker2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0xBA,
                0xB3,
                0x8E,
                0x85,
                0xDC,
                0x16,
                0x46,
                0xBE,
                0x94,
                0x96,
                0x60,
                0x88,
                0x1F,
                0x2F,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFolderPicker3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0x1E,
                0x3B,
                0x67,
                0x26,
                0xD3,
                0xC0,
                0x53,
                0xBD,
                0x24,
                0xA2,
                0x5C,
                0x71,
                0x4C,
                0xEE,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFolderPickerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x47,
                0xE3,
                0x9B,
                0xA1,
                0x7C,
                0x42,
                0x59,
                0xA3,
                0xC8,
                0x46,
                0xF2,
                0x55,
                0x1E,
                0xCF,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
