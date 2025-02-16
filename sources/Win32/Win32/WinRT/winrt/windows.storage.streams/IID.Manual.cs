// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBuffer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x0F,
                0x5A,
                0x90,
                0x53,
                0xBC,
                0xDF,
                0x11,
                0x8C,
                0x49,
                0x00,
                0x1E,
                0x4F,
                0xC6,
                0x86,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBufferFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x91,
                0xAF,
                0x71,
                0x0F,
                0xC1,
                0x4B,
                0x48,
                0xBC,
                0x50,
                0x14,
                0xBC,
                0x62,
                0x3B,
                0x3A,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBufferStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0xE6,
                0x01,
                0xE9,
                0x16,
                0xD7,
                0x5A,
                0x47,
                0xA9,
                0x0A,
                0xAF,
                0x72,
                0x29,
                0xB1,
                0xE7,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContentTypeProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA5,
                0x98,
                0xD0,
                0x97,
                0x99,
                0x3B,
                0xE9,
                0x4D,
                0x88,
                0xA5,
                0xE1,
                0x1D,
                0x2F,
                0x50,
                0xC7,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0x00,
                0xB5,
                0xE2,
                0xC1,
                0xB4,
                0x14,
                0x43,
                0xA4,
                0xB8,
                0xFB,
                0x81,
                0x3A,
                0x2F,
                0x27,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataReaderFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x78,
                0x52,
                0xD7,
                0xDA,
                0x57,
                0x15,
                0x4E,
                0x91,
                0x4C,
                0x06,
                0x80,
                0x66,
                0x99,
                0xA0,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataReaderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0xBF,
                0xFC,
                0x11,
                0x3A,
                0xF9,
                0x1B,
                0x47,
                0xB1,
                0x21,
                0xF3,
                0x79,
                0xE3,
                0x49,
                0x31,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataWriter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x92,
                0xB8,
                0x64,
                0x41,
                0xD3,
                0x22,
                0x49,
                0xB3,
                0x8A,
                0xDD,
                0x4A,
                0xF8,
                0x80,
                0x8C,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataWriterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0x67,
                0x8C,
                0x33,
                0x84,
                0x8B,
                0x2B,
                0x4C,
                0x9C,
                0x50,
                0x7B,
                0x87,
                0x67,
                0x84,
                0x7A,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileRandomAccessStreamStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x01,
                0x55,
                0x73,
                0x57,
                0x3B,
                0x5D,
                0x4B,
                0x83,
                0x45,
                0x55,
                0x4D,
                0x2F,
                0xC6,
                0x21,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputStream
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x0F,
                0x5A,
                0x90,
                0x53,
                0xBC,
                0xDF,
                0x11,
                0x8C,
                0x49,
                0x00,
                0x1E,
                0x4F,
                0xC6,
                0x86,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputStreamReference
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x9D,
                0x92,
                0x43,
                0xC9,
                0x5E,
                0x5A,
                0x4B,
                0x91,
                0x9C,
                0x42,
                0x05,
                0xB0,
                0xC8,
                0x04,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOutputStream
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x0F,
                0x5A,
                0x90,
                0x53,
                0xBC,
                0xDF,
                0x11,
                0x8C,
                0x49,
                0x00,
                0x1E,
                0x4F,
                0xC6,
                0x86,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertySetSerializer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0xBF,
                0x8E,
                0x6E,
                0x3D,
                0xEF,
                0x76,
                0x43,
                0xB2,
                0x0E,
                0x5B,
                0xE6,
                0x38,
                0xAE,
                0xAC,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRandomAccessStream
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x0F,
                0x5A,
                0x90,
                0x53,
                0xBC,
                0xDF,
                0x11,
                0x8C,
                0x49,
                0x00,
                0x1E,
                0x4F,
                0xC6,
                0x86,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRandomAccessStreamReference
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x31,
                0xEE,
                0x33,
                0xD6,
                0x1D,
                0x3A,
                0x4E,
                0x80,
                0x67,
                0xD1,
                0xC1,
                0x62,
                0xE8,
                0x64,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRandomAccessStreamReferenceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x09,
                0x73,
                0x85,
                0xBF,
                0x3F,
                0x7D,
                0x4E,
                0x98,
                0x6F,
                0xEF,
                0x3B,
                0x1A,
                0x07,
                0xA9,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRandomAccessStreamStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0xED,
                0x4C,
                0x52,
                0x29,
                0x6E,
                0xE5,
                0x4C,
                0x95,
                0x73,
                0x6B,
                0x75,
                0x3D,
                0xB6,
                0x6C,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRandomAccessStreamWithContentType
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x48,
                0x25,
                0xCC,
                0x3D,
                0x4B,
                0x8F,
                0x43,
                0x92,
                0x32,
                0x10,
                0xC7,
                0x6B,
                0xC7,
                0xE0,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
