// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBasicProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x55,
                0x5D,
                0xD0,
                0x5E,
                0x78,
                0x66,
                0x4A,
                0xBE,
                0x02,
                0x9B,
                0xEE,
                0xC5,
                0x8A,
                0xEA,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDocumentProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x19,
                0xAB,
                0x7E,
                0x21,
                0x18,
                0x23,
                0x49,
                0xB4,
                0xA9,
                0x0A,
                0xEA,
                0x40,
                0x4D,
                0x00,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeotagHelperStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x32,
                0x49,
                0x41,
                0x24,
                0x25,
                0x55,
                0x46,
                0x86,
                0xA6,
                0xED,
                0x16,
                0xF5,
                0xFC,
                0x71,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IImageProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x94,
                0x3C,
                0x52,
                0xFF,
                0xFC,
                0x75,
                0x42,
                0xAF,
                0xEE,
                0xEC,
                0xDB,
                0x9A,
                0xB4,
                0x79,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMusicProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xAB,
                0x8A,
                0xBC,
                0xEC,
                0x66,
                0x9A,
                0x41,
                0xBC,
                0x5D,
                0xCA,
                0x65,
                0xA4,
                0xCB,
                0x46,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageItemContentProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x4B,
                0x29,
                0x05,
                0x38,
                0xBC,
                0xBF,
                0x48,
                0x85,
                0xD7,
                0x77,
                0x0E,
                0x0E,
                0x2A,
                0xE0,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageItemExtraProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x61,
                0x43,
                0xC5,
                0xCD,
                0x54,
                0x2B,
                0x43,
                0xBD,
                0xBC,
                0x4B,
                0x19,
                0xC4,
                0xB4,
                0x70,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IThumbnailProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0xD4,
                0x3D,
                0x69,
                0xE7,
                0xDB,
                0xB5,
                0x49,
                0xB3,
                0xB3,
                0x28,
                0x93,
                0xAC,
                0x5D,
                0x34,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0xE5,
                0x9A,
                0x71,
                0xDE,
                0x68,
                0xB8,
                0x4D,
                0x97,
                0xDE,
                0x49,
                0x99,
                0x8C,
                0x05,
                0x9F,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
