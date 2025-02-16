// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.pickers.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IFileOpenPickerUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x5A,
                0xA4,
                0xDD,
                0xD4,
                0xF9,
                0xC4,
                0x40,
                0x8A,
                0xF5,
                0xC5,
                0xB6,
                0xB5,
                0xA6,
                0x1D,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileRemovedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x3D,
                0x04,
                0x13,
                0xCA,
                0x7F,
                0x2B,
                0x4C,
                0x9E,
                0xCA,
                0x68,
                0x90,
                0xF9,
                0xF0,
                0x01,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileSavePickerUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xC1,
                0x56,
                0x96,
                0x56,
                0x3E,
                0xCC,
                0x43,
                0x8A,
                0x39,
                0x33,
                0xC7,
                0x3D,
                0x9D,
                0x54,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPickerClosingDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0xF7,
                0xF7,
                0x7A,
                0x67,
                0x1A,
                0x31,
                0x4A,
                0xAE,
                0x80,
                0xE9,
                0x07,
                0x70,
                0x8A,
                0x61,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPickerClosingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0xF2,
                0x59,
                0x7E,
                0x32,
                0xB3,
                0x12,
                0x4F,
                0x8B,
                0x9F,
                0xA8,
                0xC2,
                0xF0,
                0x6B,
                0x32,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPickerClosingOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0xFB,
                0xE9,
                0x4C,
                0xEE,
                0xBE,
                0x39,
                0x4E,
                0xA7,
                0x73,
                0xFC,
                0x5F,
                0x0E,
                0xAE,
                0x32,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITargetFileRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x33,
                0xBD,
                0x42,
                0x88,
                0x7F,
                0x8B,
                0x47,
                0x8E,
                0x81,
                0x69,
                0x0B,
                0x20,
                0x34,
                0x06,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITargetFileRequestDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x9D,
                0xEE,
                0x4A,
                0x15,
                0xBF,
                0xA9,
                0x4D,
                0x95,
                0xF6,
                0xF6,
                0xB7,
                0xD5,
                0x58,
                0x22,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITargetFileRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0xDB,
                0x63,
                0xB1,
                0x51,
                0x1B,
                0x89,
                0x4C,
                0xA5,
                0x91,
                0x0F,
                0xD4,
                0x0B,
                0x3C,
                0x57,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
