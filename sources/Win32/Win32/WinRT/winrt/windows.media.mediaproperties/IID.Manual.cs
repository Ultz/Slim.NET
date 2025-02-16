// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAudioEncodingProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x7A,
                0xBC,
                0x62,
                0x5C,
                0x00,
                0x3B,
                0x4B,
                0x8A,
                0x0B,
                0x0A,
                0x09,
                0x0E,
                0x96,
                0x87,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioEncodingProperties2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x54,
                0x5D,
                0xC4,
                0xBD,
                0x80,
                0x23,
                0x4C,
                0x80,
                0xD5,
                0x72,
                0xD4,
                0xA1,
                0x81,
                0xE8,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioEncodingProperties3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x03,
                0x60,
                0x87,
                0x8C,
                0x74,
                0x8D,
                0x4F,
                0xB0,
                0xFD,
                0x10,
                0xCA,
                0xF0,
                0x8F,
                0xF0,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioEncodingPropertiesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0x33,
                0xAD,
                0x0C,
                0xE9,
                0xEB,
                0x27,
                0x45,
                0xB3,
                0x6D,
                0xE4,
                0x2A,
                0x13,
                0xCF,
                0x38,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioEncodingPropertiesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x31,
                0x89,
                0x74,
                0xA0,
                0x77,
                0x3D,
                0x43,
                0x8E,
                0xD5,
                0x40,
                0x40,
                0x28,
                0x0E,
                0x86,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioEncodingPropertiesWithFormatUserData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x0D,
                0xF1,
                0x98,
                0xEA,
                0x13,
                0xFF,
                0x49,
                0xBE,
                0x70,
                0x26,
                0x73,
                0xDB,
                0x69,
                0x70,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAv1ProfileIdsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x81,
                0x05,
                0x91,
                0x09,
                0x7C,
                0x82,
                0x58,
                0x88,
                0xA4,
                0x67,
                0x80,
                0x08,
                0xA5,
                0x17,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContainerEncodingProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x2A,
                0xAC,
                0x59,
                0x2A,
                0xB3,
                0x9E,
                0x47,
                0x8A,
                0x61,
                0x4B,
                0x7F,
                0x2E,
                0x9E,
                0x7E,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContainerEncodingProperties2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xC0,
                0x72,
                0xB2,
                0x26,
                0xAE,
                0x19,
                0x48,
                0xBA,
                0xAD,
                0xAD,
                0x7A,
                0x49,
                0xB0,
                0xA8,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IH264ProfileIdsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x4C,
                0x65,
                0x38,
                0x6A,
                0x84,
                0x97,
                0x4F,
                0xA2,
                0xE5,
                0xC3,
                0xA1,
                0x5B,
                0xBF,
                0x70,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHevcProfileIdsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xD2,
                0x50,
                0x1E,
                0xA7,
                0x2A,
                0xC1,
                0x53,
                0x97,
                0x3F,
                0x21,
                0x89,
                0xFA,
                0x65,
                0x6F,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IImageEncodingProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x56,
                0x62,
                0x78,
                0x31,
                0xF3,
                0x89,
                0x41,
                0xB1,
                0xC3,
                0xB4,
                0x8D,
                0x5A,
                0xE0,
                0x34,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IImageEncodingProperties2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0xA2,
                0x54,
                0xC8,
                0x23,
                0xC9,
                0x9B,
                0x46,
                0xAC,
                0x8E,
                0x6A,
                0x9F,
                0x3C,
                0x1C,
                0xD9,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IImageEncodingPropertiesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x68,
                0x7C,
                0x25,
                0x99,
                0x8B,
                0x9E,
                0x43,
                0xAA,
                0x59,
                0x91,
                0x3A,
                0x36,
                0x16,
                0x12,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IImageEncodingPropertiesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0x5B,
                0xC2,
                0xF6,
                0x24,
                0x38,
                0xB0,
                0x46,
                0x95,
                0x6E,
                0x50,
                0x13,
                0x29,
                0xE1,
                0xBE,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IImageEncodingPropertiesStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x81,
                0xF4,
                0x48,
                0xFF,
                0xA2,
                0xDC,
                0x48,
                0x8E,
                0xA0,
                0xE9,
                0x06,
                0x80,
                0x66,
                0x36,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingProfile
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0xF5,
                0xDB,
                0xE7,
                0xB9,
                0x1D,
                0x83,
                0x47,
                0x87,
                0x6B,
                0x3D,
                0xFE,
                0x12,
                0xAC,
                0xFD,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingProfile2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x3E,
                0x9B,
                0x34,
                0x35,
                0x40,
                0x8E,
                0x48,
                0x98,
                0x77,
                0x85,
                0x63,
                0x28,
                0x65,
                0xED,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingProfile3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xBE,
                0x6E,
                0xBA,
                0x70,
                0x75,
                0x69,
                0x4E,
                0xAC,
                0xCF,
                0x56,
                0x11,
                0xAD,
                0x01,
                0x5F,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingProfileStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0x35,
                0x7F,
                0x19,
                0xDE,
                0x2E,
                0x45,
                0x4A,
                0xA8,
                0x96,
                0x81,
                0x7A,
                0x48,
                0x54,
                0xF8,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingProfileStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0xE7,
                0x8D,
                0xCE,
                0xF4,
                0x6A,
                0x88,
                0x42,
                0x8F,
                0xE2,
                0x79,
                0xAD,
                0xF1,
                0xF7,
                0x9A,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingProfileStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0xC5,
                0xDA,
                0x90,
                0x76,
                0xCF,
                0x94,
                0x42,
                0xA9,
                0xED,
                0x1A,
                0x14,
                0x20,
                0xF5,
                0x1F,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingProfileStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0xD7,
                0xAF,
                0x6F,
                0x04,
                0x94,
                0x4A,
                0x51,
                0x81,
                0xDD,
                0xC9,
                0x44,
                0x4D,
                0x64,
                0x8A,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x2A,
                0x00,
                0xB4,
                0xD4,
                0xAC,
                0x5A,
                0x4E,
                0xA2,
                0x4B,
                0x5D,
                0x74,
                0x98,
                0xA8,
                0xB8,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingSubtypesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x58,
                0xB6,
                0x37,
                0x71,
                0xA1,
                0x64,
                0x44,
                0xBA,
                0x5A,
                0x53,
                0x18,
                0x9E,
                0x48,
                0xC1,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingSubtypesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0xD2,
                0x7C,
                0x4B,
                0xFF,
                0x42,
                0x33,
                0x4D,
                0x85,
                0x31,
                0x06,
                0x26,
                0xBE,
                0xE4,
                0xB5,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingSubtypesStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x14,
                0x24,
                0xBA,
                0x3D,
                0x88,
                0x4E,
                0x46,
                0xA4,
                0x4F,
                0x09,
                0x7D,
                0xA0,
                0x8E,
                0xF7,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingSubtypesStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0xE5,
                0xEC,
                0xDD,
                0x49,
                0x39,
                0x44,
                0x46,
                0x8A,
                0x2C,
                0x59,
                0xEF,
                0x02,
                0xC6,
                0x42,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingSubtypesStatics5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0xA0,
                0xD4,
                0x5A,
                0xCE,
                0xFF,
                0x60,
                0x47,
                0x98,
                0x28,
                0x5D,
                0x0C,
                0x99,
                0x63,
                0x7E,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingSubtypesStatics6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x29,
                0x25,
                0xA1,
                0x84,
                0xA9,
                0x12,
                0x59,
                0x93,
                0xBB,
                0x54,
                0xE7,
                0xE5,
                0x69,
                0xE0,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEncodingSubtypesStatics7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0xDC,
                0xF2,
                0x92,
                0x37,
                0x99,
                0xA1,
                0x52,
                0xB6,
                0x19,
                0xDD,
                0xFA,
                0xD8,
                0x1C,
                0xD9,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaRatio
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0xFE,
                0xD0,
                0xD2,
                0x29,
                0x89,
                0x1D,
                0x40,
                0xAC,
                0x78,
                0x7D,
                0x35,
                0x7E,
                0x37,
                0x81,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMpeg2ProfileIdsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0xFF,
                0x61,
                0xA4,
                0x7A,
                0xE5,
                0x28,
                0x41,
                0x9B,
                0x21,
                0xD5,
                0x33,
                0x1B,
                0x04,
                0x23,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataEncodingProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x30,
                0xCD,
                0x51,
                0x90,
                0xD6,
                0xFA,
                0x4C,
                0x97,
                0xF4,
                0x4A,
                0x39,
                0x8E,
                0x9D,
                0xB4,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataEncodingPropertiesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0xBB,
                0x29,
                0x66,
                0x55,
                0x6E,
                0x43,
                0x56,
                0x89,
                0xA0,
                0x7A,
                0x7E,
                0x8D,
                0x85,
                0xB5,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEncodingProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x6C,
                0xEE,
                0x76,
                0xC2,
                0x37,
                0x2A,
                0x4F,
                0x88,
                0x0A,
                0x12,
                0x82,
                0xBB,
                0xB4,
                0x37,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEncodingProperties2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0xA1,
                0x43,
                0xF7,
                0x65,
                0xD4,
                0x90,
                0x42,
                0xA9,
                0x4B,
                0xEF,
                0x0F,
                0x15,
                0x28,
                0xF8,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEncodingProperties3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0xCD,
                0x6B,
                0x38,
                0x3A,
                0x87,
                0x9F,
                0x47,
                0xB3,
                0xEB,
                0x56,
                0xC1,
                0xFC,
                0xBE,
                0xC6,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEncodingProperties4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0xF0,
                0x4E,
                0x72,
                0x0C,
                0xC1,
                0xF2,
                0x40,
                0x9D,
                0x72,
                0x3E,
                0xE1,
                0x3B,
                0x45,
                0xFA,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEncodingProperties5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x08,
                0x59,
                0x49,
                0x2F,
                0x27,
                0xCE,
                0x4E,
                0xA4,
                0xDF,
                0xC0,
                0xCC,
                0xDB,
                0x33,
                0xD8,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEncodingPropertiesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x4D,
                0xE1,
                0x3C,
                0xC5,
                0x1D,
                0xDB,
                0x43,
                0x9F,
                0x38,
                0xEB,
                0xEB,
                0xF9,
                0x01,
                0x52,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEncodingPropertiesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xBD,
                0x1E,
                0xCF,
                0xFE,
                0x49,
                0x00,
                0x4D,
                0xB5,
                0x9A,
                0xCF,
                0xA4,
                0xDF,
                0xC5,
                0x19,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEncodingPropertiesStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x66,
                0xB4,
                0x65,
                0xDA,
                0x60,
                0x51,
                0x5E,
                0x91,
                0xA2,
                0xB3,
                0x8C,
                0x47,
                0x63,
                0xB8,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVp9ProfileIdsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x1A,
                0x31,
                0x20,
                0x06,
                0xFE,
                0x83,
                0x58,
                0x92,
                0xD9,
                0x60,
                0x80,
                0xC9,
                0x77,
                0x43,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
