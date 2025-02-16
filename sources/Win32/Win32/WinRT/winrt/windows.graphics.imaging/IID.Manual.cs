// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBitmapBuffer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0x04,
                0x3E,
                0xA5,
                0x9C,
                0x39,
                0x8C,
                0x43,
                0xB2,
                0x8F,
                0xA6,
                0x3A,
                0x6B,
                0x83,
                0xD1,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapCodecInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xAA,
                0x0C,
                0x40,
                0xB0,
                0xC4,
                0x92,
                0x43,
                0xA3,
                0xB0,
                0x6F,
                0x6F,
                0x9B,
                0xA9,
                0x5C,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapDecoder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x22,
                0xEF,
                0xAC,
                0x74,
                0x1D,
                0x91,
                0x4C,
                0x9D,
                0xFC,
                0x96,
                0x20,
                0x74,
                0x52,
                0x33,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapDecoderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0xCB,
                0x8C,
                0x43,
                0xEF,
                0xBC,
                0x95,
                0x4E,
                0xBA,
                0xD6,
                0x23,
                0xA8,
                0x22,
                0xE5,
                0x8D,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapDecoderStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x68,
                0xBA,
                0x50,
                0xA1,
                0x99,
                0xC4,
                0x40,
                0x80,
                0xD9,
                0xAE,
                0xF0,
                0xDA,
                0xFA,
                0x6C,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapEncoder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x68,
                0xC4,
                0x2B,
                0xF8,
                0xE1,
                0x54,
                0x4B,
                0x95,
                0xE8,
                0x32,
                0x91,
                0x95,
                0x51,
                0xCE,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapEncoderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x56,
                0x43,
                0xA7,
                0xE4,
                0xA4,
                0xB9,
                0x4E,
                0x8E,
                0x40,
                0x56,
                0x4D,
                0xE7,
                0xE1,
                0xCC,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapEncoderStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xC2,
                0xCB,
                0x33,
                0x31,
                0xFE,
                0xB1,
                0x41,
                0xB8,
                0x12,
                0x08,
                0x6D,
                0x21,
                0xE8,
                0x7E,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapEncoderWithSoftwareBitmap
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xD2,
                0x6C,
                0x68,
                0x30,
                0x43,
                0x77,
                0x4C,
                0xAC,
                0xE4,
                0x03,
                0x34,
                0x96,
                0x8B,
                0x17,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x9A,
                0xA4,
                0x72,
                0x81,
                0x80,
                0x8D,
                0x43,
                0x91,
                0xBC,
                0x94,
                0xEC,
                0xFC,
                0x81,
                0x85,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapFrameWithSoftwareBitmap
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x7C,
                0x28,
                0xFE,
                0x0C,
                0x42,
                0x63,
                0x49,
                0x87,
                0xAD,
                0x69,
                0x14,
                0x36,
                0xE0,
                0x83,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x4F,
                0x9F,
                0xEA,
                0x05,
                0xB5,
                0x50,
                0x44,
                0xA4,
                0xD1,
                0xE8,
                0xCA,
                0x94,
                0x52,
                0x9D,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapPropertiesView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0xE8,
                0x0F,
                0x7E,
                0x70,
                0x3A,
                0xF8,
                0x48,
                0x9C,
                0x55,
                0x19,
                0x6C,
                0xF5,
                0xA5,
                0x45,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x53,
                0x75,
                0xAE,
                0x68,
                0xE2,
                0x35,
                0x4D,
                0xAD,
                0xCF,
                0xE9,
                0x95,
                0xD3,
                0x1A,
                0x8D,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapTypedValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x44,
                0x80,
                0xCD,
                0x43,
                0x24,
                0x00,
                0x40,
                0xB0,
                0xCD,
                0x79,
                0x31,
                0x6C,
                0x56,
                0xF5,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBitmapTypedValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0xB5,
                0xDB,
                0x92,
                0x13,
                0xCE,
                0xBB,
                0x46,
                0x95,
                0x45,
                0xCB,
                0x3A,
                0x3F,
                0x63,
                0xEB,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPixelDataProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x1F,
                0x83,
                0xDD,
                0x5C,
                0x18,
                0x95,
                0x45,
                0x9F,
                0xB9,
                0xCC,
                0xBE,
                0x6E,
                0xC1,
                0x8A,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISoftwareBitmap
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x07,
                0x9E,
                0x68,
                0xEF,
                0x7E,
                0x3F,
                0x48,
                0x96,
                0x3F,
                0xDA,
                0x93,
                0x88,
                0x18,
                0xE0,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISoftwareBitmapFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xEB,
                0x9F,
                0xC9,
                0x62,
                0x2D,
                0x47,
                0x4D,
                0xA6,
                0xB3,
                0x4F,
                0xDB,
                0x6A,
                0x07,
                0xFD,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISoftwareBitmapStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x85,
                0x03,
                0xDF,
                0x2F,
                0x67,
                0x9D,
                0x4A,
                0x80,
                0x6E,
                0xC2,
                0x44,
                0x2F,
                0x34,
                0x3E,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
