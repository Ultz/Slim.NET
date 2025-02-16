// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAudioMediaFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0xFE,
                0xA9,
                0xA3,
                0x21,
                0x80,
                0x1B,
                0x44,
                0x9A,
                0x46,
                0xE7,
                0xF0,
                0x13,
                0x7B,
                0x79,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBufferMediaFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x53,
                0xB1,
                0xB5,
                0x84,
                0x9B,
                0x62,
                0x40,
                0xB7,
                0x9C,
                0xA3,
                0x65,
                0xB2,
                0x59,
                0x68,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDepthMediaFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0x5E,
                0x13,
                0x47,
                0x49,
                0x85,
                0xC0,
                0x45,
                0x92,
                0x5B,
                0x80,
                0xD3,
                0x5E,
                0xFD,
                0xB1,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDepthMediaFrame2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x47,
                0xCA,
                0x6C,
                0xA4,
                0xC4,
                0x76,
                0x41,
                0xB0,
                0xCD,
                0x33,
                0xEA,
                0xE3,
                0xB3,
                0x5A,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDepthMediaFrameFormat
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xCF,
                0x12,
                0xC3,
                0x29,
                0xD7,
                0x3E,
                0x45,
                0x87,
                0x80,
                0x2E,
                0x04,
                0xF1,
                0x40,
                0xD2,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInfraredMediaFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x35,
                0xD1,
                0x3F,
                0x4B,
                0x00,
                0x0E,
                0x4F,
                0x91,
                0xAC,
                0x46,
                0x52,
                0x99,
                0xB4,
                0x16,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameArrivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x0A,
                0x43,
                0x0B,
                0x90,
                0xA4,
                0x35,
                0x44,
                0xAD,
                0xA1,
                0x9A,
                0xFF,
                0xD5,
                0x52,
                0x39,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameFormat
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x2B,
                0x90,
                0x71,
                0x79,
                0xB2,
                0x97,
                0x4A,
                0xA9,
                0xDB,
                0xBD,
                0x5A,
                0x2F,
                0xB7,
                0x8F,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameFormat2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x63,
                0x85,
                0x63,
                0x87,
                0x5E,
                0x10,
                0x4C,
                0x86,
                0xD1,
                0x6D,
                0xF0,
                0x97,
                0xA6,
                0xC6,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x43,
                0xC9,
                0xE4,
                0x28,
                0x20,
                0xED,
                0x48,
                0x90,
                0xB0,
                0xD1,
                0xC1,
                0xB1,
                0x62,
                0xE2,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameReader2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x27,
                0x11,
                0x87,
                0x31,
                0x85,
                0x50,
                0x40,
                0x87,
                0xCC,
                0xA1,
                0x37,
                0x33,
                0xCF,
                0x3E,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameReference
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x86,
                0xB8,
                0xF6,
                0xDC,
                0xF0,
                0x44,
                0x40,
                0x8D,
                0xC9,
                0x96,
                0x1C,
                0xED,
                0xD0,
                0x5B,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameReference2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x3E,
                0xBC,
                0xDD,
                0xB2,
                0xD5,
                0xEF,
                0x49,
                0x83,
                0x6A,
                0x94,
                0x7D,
                0x98,
                0x9B,
                0x80,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x29,
                0x78,
                0xD6,
                0xDB,
                0x90,
                0xA8,
                0x46,
                0x8A,
                0xDD,
                0x2A,
                0xA8,
                0x84,
                0xA8,
                0xD2,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSourceController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x66,
                0x07,
                0x6D,
                0x6D,
                0x31,
                0x8F,
                0x4B,
                0xB7,
                0xB6,
                0xEE,
                0xB0,
                0x4A,
                0x8C,
                0x65,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSourceController2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x9F,
                0xC4,
                0xEF,
                0xF2,
                0xFC,
                0x03,
                0x4A,
                0xB4,
                0xE4,
                0xAC,
                0x96,
                0x28,
                0x73,
                0x9B,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSourceController3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0xF8,
                0x0C,
                0x1F,
                0x64,
                0x24,
                0x51,
                0x46,
                0xB1,
                0xE8,
                0x4A,
                0x82,
                0xDB,
                0xDB,
                0x54,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSourceGetPropertyResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0x16,
                0x86,
                0x08,
                0x64,
                0x3A,
                0xD5,
                0x4B,
                0xBD,
                0x2B,
                0xE7,
                0xC8,
                0x98,
                0xD2,
                0xF3,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSourceGroup
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x5B,
                0x60,
                0x7F,
                0x32,
                0x48,
                0x5F,
                0x4B,
                0xAE,
                0x3D,
                0x41,
                0x2F,
                0xAA,
                0xB3,
                0x7D,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSourceGroupStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0xBF,
                0x48,
                0x1C,
                0x6F,
                0x43,
                0x08,
                0x45,
                0x94,
                0xCF,
                0xD5,
                0xD8,
                0xB7,
                0x32,
                0x64,
                0x45,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSourceInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0xC9,
                0xBD,
                0x87,
                0x01,
                0x46,
                0x8F,
                0x40,
                0x91,
                0xCF,
                0x03,
                0x83,
                0x18,
                0xCD,
                0x0A,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSourceInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x78,
                0x5A,
                0x19,
                0x57,
                0x64,
                0xC6,
                0x42,
                0xA7,
                0x69,
                0x19,
                0xB6,
                0x5B,
                0xD3,
                0x2E,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSourceInfo3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x4A,
                0x82,
                0xCA,
                0xEA,
                0x66,
                0x85,
                0x58,
                0xA2,
                0xB6,
                0x26,
                0xC0,
                0xEE,
                0xEC,
                0x3C,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrameSourceInfo4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0xD7,
                0x17,
                0x48,
                0xEB,
                0x85,
                0x0C,
                0x47,
                0x8F,
                0x37,
                0x43,
                0xCA,
                0x54,
                0x98,
                0xE4,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMultiSourceMediaFrameArrivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x5E,
                0x11,
                0x63,
                0x51,
                0xCF,
                0xFD,
                0x48,
                0xAA,
                0xB0,
                0x6D,
                0x69,
                0x3E,
                0xB4,
                0x81,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMultiSourceMediaFrameReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0x44,
                0x14,
                0x8D,
                0x63,
                0xF7,
                0x8D,
                0x48,
                0x98,
                0xF2,
                0xB4,
                0x37,
                0xBC,
                0xF0,
                0x75,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMultiSourceMediaFrameReader2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x8A,
                0x5C,
                0xEF,
                0x5C,
                0xFC,
                0x6B,
                0x4C,
                0x9D,
                0x81,
                0x3C,
                0xB9,
                0xCC,
                0x63,
                0x7C,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMultiSourceMediaFrameReference
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0x4B,
                0x96,
                0x21,
                0xE2,
                0x7F,
                0xD6,
                0x44,
                0x92,
                0xE5,
                0x29,
                0x8E,
                0x6D,
                0x28,
                0x10,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoMediaFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x4C,
                0xDD,
                0x00,
                0xBD,
                0x32,
                0xE1,
                0x4F,
                0xA0,
                0x13,
                0x7C,
                0xC1,
                0x3C,
                0xF5,
                0xDB,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoMediaFrameFormat
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x7F,
                0x02,
                0x46,
                0x1B,
                0xD7,
                0xC7,
                0x45,
                0x8F,
                0x14,
                0x6D,
                0x9A,
                0x0A,
                0xE6,
                0x04,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
