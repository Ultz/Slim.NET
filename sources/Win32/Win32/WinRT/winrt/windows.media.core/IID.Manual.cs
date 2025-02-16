// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAudioStreamDescriptor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x92,
                0x36,
                0x1E,
                0x27,
                0x40,
                0x47,
                0x48,
                0xA7,
                0x0B,
                0xDF,
                0x1D,
                0x9A,
                0x2A,
                0x7B,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioStreamDescriptor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0xF1,
                0x68,
                0x2E,
                0x48,
                0xA4,
                0x7B,
                0x49,
                0x88,
                0x40,
                0x85,
                0x08,
                0x26,
                0x65,
                0xAC,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioStreamDescriptor3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x0D,
                0x22,
                0x4D,
                0x83,
                0x8E,
                0xEF,
                0x44,
                0x89,
                0x73,
                0x2F,
                0x63,
                0xE9,
                0x93,
                0xF3,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioStreamDescriptorFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xCE,
                0x86,
                0x4A,
                0xB1,
                0x4C,
                0x80,
                0x43,
                0x8E,
                0x0C,
                0x83,
                0x50,
                0x4B,
                0x7F,
                0x5B,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioTrack
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x6E,
                0x3B,
                0xF2,
                0xF7,
                0x3E,
                0xDE,
                0x40,
                0xB9,
                0x43,
                0x06,
                0x8B,
                0x13,
                0x21,
                0x70,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioTrackOpenFailedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xB9,
                0xDD,
                0xEE,
                0x7C,
                0xBB,
                0x12,
                0x41,
                0xBF,
                0x76,
                0x93,
                0x84,
                0x67,
                0x6F,
                0x82,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioTrackSupportInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0xEF,
                0x8B,
                0x17,
                0x39,
                0xCC,
                0xA6,
                0x44,
                0xB9,
                0x51,
                0x4A,
                0x56,
                0x53,
                0xF0,
                0x73,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IChapterCue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x80,
                0xA9,
                0x72,
                0x8A,
                0xD3,
                0x0A,
                0x4C,
                0x8F,
                0xA6,
                0x75,
                0xCD,
                0xDA,
                0xF4,
                0x66,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICodecInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x9F,
                0xE8,
                0x51,
                0x97,
                0xEA,
                0x9C,
                0x49,
                0x86,
                0xAC,
                0x4C,
                0xE5,
                0xE7,
                0x3F,
                0x3A,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICodecQuery
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x95,
                0x2A,
                0x22,
                0x61,
                0xAF,
                0x04,
                0x4E,
                0x80,
                0x8A,
                0xA4,
                0x63,
                0x4E,
                0x2F,
                0x3A,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICodecSubtypesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xC4,
                0x6A,
                0xA6,
                0x8B,
                0x88,
                0x24,
                0x42,
                0x8C,
                0xF6,
                0x2A,
                0x8D,
                0x4E,
                0xB0,
                0x23,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataCue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x67,
                0x7F,
                0x7C,
                0xBC,
                0x1F,
                0x2D,
                0x4E,
                0x9A,
                0x87,
                0xEE,
                0x38,
                0xBD,
                0x1D,
                0xC6,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataCue2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x1B,
                0x56,
                0xBC,
                0xF2,
                0x95,
                0xE8,
                0x49,
                0x96,
                0xF1,
                0x8D,
                0xD5,
                0xDA,
                0xC6,
                0x8D,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFaceDetectedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x84,
                0x91,
                0x19,
                0x5B,
                0xC6,
                0xBA,
                0x46,
                0x85,
                0xF8,
                0x13,
                0x88,
                0x05,
                0x76,
                0xC9,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFaceDetectionEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0xEB,
                0x15,
                0xAE,
                0x42,
                0x05,
                0xA9,
                0x42,
                0xBC,
                0x90,
                0xF2,
                0x83,
                0xA2,
                0x9F,
                0x46,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFaceDetectionEffectDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xA0,
                0xDC,
                0x43,
                0x48,
                0xB8,
                0x33,
                0x4F,
                0xB7,
                0x02,
                0x1F,
                0xD2,
                0x62,
                0x4F,
                0xB0,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFaceDetectionEffectFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x89,
                0xB0,
                0x8A,
                0xC8,
                0x5D,
                0x7B,
                0x44,
                0xA2,
                0x47,
                0x52,
                0x70,
                0xBD,
                0x80,
                0x2E,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHighDynamicRangeControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0xA7,
                0xF1,
                0x55,
                0x57,
                0xD9,
                0xC9,
                0x4D,
                0x9D,
                0x1C,
                0x85,
                0x53,
                0xA8,
                0x2A,
                0x7D,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHighDynamicRangeOutput
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0x80,
                0x57,
                0x0F,
                0x3B,
                0x25,
                0x19,
                0x41,
                0xBB,
                0x40,
                0x3A,
                0x90,
                0xE5,
                0x13,
                0x84,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IImageCue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x82,
                0x82,
                0x52,
                0x7B,
                0x36,
                0x0B,
                0x44,
                0x91,
                0x16,
                0x3C,
                0x84,
                0x57,
                0x0D,
                0xD2,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInitializeMediaStreamSourceRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x45,
                0xBC,
                0x25,
                0x08,
                0x9B,
                0x2E,
                0x4C,
                0xA8,
                0x55,
                0x45,
                0x42,
                0xF1,
                0xA7,
                0x5D,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLightFusionResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0xBE,
                0xED,
                0x78,
                0xA0,
                0x27,
                0xE0,
                0x42,
                0x9C,
                0xD3,
                0x73,
                0x8D,
                0x20,
                0x89,
                0xDE,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLightFusionStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x01,
                0x05,
                0x53,
                0x9E,
                0xC2,
                0xE2,
                0x40,
                0x87,
                0xA9,
                0x9E,
                0x1F,
                0xD2,
                0xF1,
                0x92,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBinder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x40,
                0x7E,
                0x2B,
                0x07,
                0xDE,
                0x4F,
                0x42,
                0x83,
                0xF1,
                0xF1,
                0xDE,
                0x46,
                0xC4,
                0xFA,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBindingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0xB2,
                0x1C,
                0xB6,
                0x6D,
                0x1B,
                0x30,
                0x46,
                0xA8,
                0x6D,
                0x2F,
                0x08,
                0x37,
                0xF7,
                0x12,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBindingEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0xCC,
                0x64,
                0x04,
                0x5A,
                0xBB,
                0x2F,
                0x48,
                0xB8,
                0xBA,
                0xF0,
                0x28,
                0x4C,
                0x69,
                0x65,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBindingEventArgs3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x47,
                0xEB,
                0xF8,
                0xBE,
                0x19,
                0xFC,
                0x44,
                0xA5,
                0xED,
                0x7A,
                0xBA,
                0x31,
                0x50,
                0x37,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x5E,
                0xD1,
                0xC7,
                0xDC,
                0x59,
                0x1F,
                0x43,
                0xA0,
                0xEE,
                0x27,
                0x74,
                0x43,
                0x23,
                0xB3,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCueEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x47,
                0x2F,
                0xD1,
                0xA4,
                0x5F,
                0x68,
                0x4E,
                0x9F,
                0xE5,
                0x32,
                0x16,
                0x0D,
                0xCE,
                0xE5,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0xB5,
                0xBF,
                0xE7,
                0x9D,
                0xA0,
                0x21,
                0x4C,
                0xBC,
                0xDF,
                0x20,
                0xAF,
                0x4F,
                0x86,
                0xB3,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSource2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x10,
                0xB6,
                0x2E,
                0x5F,
                0x65,
                0x37,
                0x4C,
                0xB8,
                0x13,
                0xB4,
                0xE4,
                0x5D,
                0xFA,
                0x0A,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSource3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x0D,
                0x9F,
                0xB5,
                0x6E,
                0x4B,
                0xED,
                0x41,
                0xBB,
                0xB4,
                0x7C,
                0x75,
                0x09,
                0xA9,
                0x94,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSource4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xAD,
                0xAF,
                0xBD,
                0xFF,
                0x8E,
                0x63,
                0x4C,
                0x85,
                0xA6,
                0x84,
                0xDE,
                0x0A,
                0xE3,
                0xE4,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSource5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0x22,
                0x1A,
                0x33,
                0x2E,
                0xED,
                0x22,
                0x4A,
                0x94,
                0xC8,
                0xB7,
                0x43,
                0xA9,
                0x2B,
                0x30,
                0x22,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSourceAppServiceConnection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0xEA,
                0xE1,
                0x61,
                0x16,
                0x19,
                0x10,
                0x48,
                0xB7,
                0xF4,
                0xB6,
                0x42,
                0xBE,
                0x82,
                0x95,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSourceAppServiceConnectionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x12,
                0xB9,
                0x65,
                0xB9,
                0x80,
                0xF9,
                0x44,
                0x9C,
                0x1E,
                0xE1,
                0x20,
                0xF6,
                0xD9,
                0x28,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSourceError
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x89,
                0x0A,
                0x5C,
                0xC5,
                0x37,
                0x9D,
                0x4E,
                0x8D,
                0x21,
                0x1C,
                0xDE,
                0xE9,
                0x0C,
                0xEC,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSourceOpenOperationCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x2C,
                0x68,
                0xFC,
                0x81,
                0xE2,
                0x7C,
                0x47,
                0xA8,
                0xE0,
                0x1A,
                0xCD,
                0x65,
                0x41,
                0x14,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSourceStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0xAF,
                0x30,
                0x0A,
                0x71,
                0x90,
                0xAC,
                0x4B,
                0xBC,
                0x39,
                0xCA,
                0x2A,
                0x93,
                0xB7,
                0x17,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSourceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x6F,
                0x7D,
                0xF7,
                0x52,
                0x46,
                0x0E,
                0x41,
                0xB1,
                0xD8,
                0xE9,
                0xA5,
                0xE2,
                0x45,
                0xA4,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSourceStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x61,
                0xE1,
                0xEE,
                0x13,
                0x7F,
                0x96,
                0x48,
                0xB8,
                0xCB,
                0xDF,
                0x0D,
                0xE5,
                0xBC,
                0xB9,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSourceStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x30,
                0x3A,
                0x45,
                0xEA,
                0x2B,
                0x22,
                0x41,
                0x9F,
                0x73,
                0xEA,
                0xCE,
                0x04,
                0x52,
                0x6E,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSourceStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0x3B,
                0x1B,
                0x28,
                0x0A,
                0xE5,
                0x28,
                0x44,
                0xA5,
                0x00,
                0x9C,
                0x4E,
                0xD9,
                0x18,
                0xD3,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamDescriptor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x6E,
                0xF1,
                0x80,
                0xF7,
                0x92,
                0x1E,
                0x45,
                0x97,
                0xD2,
                0xAF,
                0xD8,
                0x07,
                0x42,
                0xDA,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamDescriptor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x01,
                0x73,
                0x50,
                0xB2,
                0xE8,
                0x71,
                0x40,
                0xB0,
                0x0B,
                0xEB,
                0xF3,
                0x37,
                0xA7,
                0x6B,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSample
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xB6,
                0x8D,
                0x5C,
                0x80,
                0x4B,
                0x61,
                0x43,
                0x98,
                0x37,
                0x6C,
                0xB7,
                0x48,
                0x1A,
                0xD9,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSample2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x86,
                0x07,
                0x45,
                0xE8,
                0xFC,
                0x46,
                0x47,
                0xA1,
                0xC8,
                0x10,
                0xC2,
                0x5D,
                0x3D,
                0x7C,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSampleProtectionProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x82,
                0xB8,
                0x4E,
                0xDF,
                0xEC,
                0x3E,
                0x49,
                0x84,
                0x1D,
                0xDD,
                0x4A,
                0xDD,
                0x7C,
                0xAC,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSampleStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x21,
                0xDF,
                0xDF,
                0xCF,
                0xA6,
                0x79,
                0x45,
                0xBE,
                0x41,
                0x73,
                0xDD,
                0x94,
                0x1A,
                0xD9,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSampleStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x95,
                0xFE,
                0x9E,
                0x46,
                0x6D,
                0x4C,
                0x49,
                0xA2,
                0xF8,
                0xD6,
                0x62,
                0x92,
                0x2E,
                0x2D,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0xD5,
                0x12,
                0x37,
                0xEB,
                0x45,
                0x38,
                0x41,
                0xAA,
                0x62,
                0xC0,
                0x1E,
                0x26,
                0xF3,
                0x84,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSource2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0xD0,
                0x55,
                0xEC,
                0x6A,
                0x2E,
                0x74,
                0x4F,
                0xAD,
                0xBB,
                0xB5,
                0x62,
                0xD1,
                0x53,
                0x38,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSource3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x27,
                0x2A,
                0x6A,
                0xDD,
                0x3D,
                0xDF,
                0x4D,
                0xA1,
                0x21,
                0x94,
                0x04,
                0x5E,
                0xCF,
                0x94,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSource4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xFC,
                0x0C,
                0x1D,
                0x0D,
                0x83,
                0x7C,
                0x41,
                0xA3,
                0xA9,
                0x24,
                0x54,
                0xFD,
                0x64,
                0x15,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceClosedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x7E,
                0x8C,
                0xCD,
                0x16,
                0x48,
                0x24,
                0x4E,
                0x88,
                0xF0,
                0x49,
                0x1E,
                0xF7,
                0x38,
                0x64,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceClosedRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0x00,
                0x7C,
                0x90,
                0xA3,
                0x18,
                0x51,
                0x49,
                0x88,
                0x7A,
                0x2C,
                0x1E,
                0xEB,
                0xD5,
                0xC6,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0xE0,
                0x77,
                0xEF,
                0x58,
                0xD1,
                0x7A,
                0x4B,
                0x86,
                0x3F,
                0x20,
                0x33,
                0x42,
                0xFB,
                0xFD,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceSampleRenderedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x7B,
                0x69,
                0x9D,
                0xF2,
                0xD4,
                0x7A,
                0x4C,
                0x9D,
                0xFE,
                0x8D,
                0x6C,
                0xD0,
                0xB3,
                0xEE,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceSampleRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x41,
                0xB3,
                0x4D,
                0x01,
                0x35,
                0x9B,
                0x4D,
                0x83,
                0xF9,
                0x8F,
                0x23,
                0x5C,
                0x82,
                0x25,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceSampleRequestDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xCC,
                0x95,
                0x78,
                0x82,
                0xF9,
                0xC8,
                0x43,
                0x9D,
                0x16,
                0xC6,
                0x2D,
                0x99,
                0x93,
                0x19,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceSampleRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xBB,
                0xF9,
                0x10,
                0xC5,
                0x71,
                0x2F,
                0x49,
                0x84,
                0x7F,
                0x0D,
                0xA1,
                0xF3,
                0x5E,
                0x81,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceStartingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x68,
                0x14,
                0xF4,
                0x74,
                0xC2,
                0x40,
                0x49,
                0xA5,
                0xBB,
                0x28,
                0xA5,
                0x72,
                0x45,
                0x2F,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceStartingRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x93,
                0x90,
                0x2A,
                0xC4,
                0x35,
                0x1B,
                0x4B,
                0xA7,
                0x91,
                0x0D,
                0x99,
                0xDB,
                0x56,
                0xDD,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceStartingRequestDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA5,
                0x56,
                0x13,
                0x3F,
                0x40,
                0x63,
                0xC4,
                0x4D,
                0x99,
                0x10,
                0x06,
                0x8E,
                0xD9,
                0xF5,
                0x98,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceSwitchStreamsRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8E,
                0x80,
                0xB8,
                0x41,
                0xA9,
                0x38,
                0xC3,
                0x4E,
                0x9B,
                0xA0,
                0xB6,
                0x9B,
                0x85,
                0x50,
                0x1E,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceSwitchStreamsRequestDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0xD8,
                0xE3,
                0xBE,
                0x05,
                0xA5,
                0x9A,
                0x4F,
                0xB9,
                0x43,
                0x2B,
                0x8C,
                0xB1,
                0xB4,
                0xBB,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaStreamSourceSwitchStreamsRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x2B,
                0x20,
                0x42,
                0xA1,
                0x6E,
                0x77,
                0x46,
                0x98,
                0x1E,
                0x35,
                0x0A,
                0x0D,
                0xA4,
                0x12,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaTrack
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xFA,
                0xE1,
                0x03,
                0x31,
                0xC9,
                0x1A,
                0x49,
                0xB4,
                0x6B,
                0xC1,
                0x0E,
                0xE8,
                0xC2,
                0x56,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMseSourceBuffer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0xA3,
                0x1A,
                0x0C,
                0x8D,
                0xDF,
                0x79,
                0x40,
                0xA3,
                0xFE,
                0x68,
                0x49,
                0x18,
                0x4B,
                0x4E,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMseSourceBufferList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xE8,
                0xFA,
                0x95,
                0xE7,
                0xA8,
                0xBF,
                0x4E,
                0x89,
                0x27,
                0x14,
                0x5E,
                0x94,
                0x0B,
                0xA5,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMseStreamSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x19,
                0xB4,
                0xB0,
                0xF4,
                0x02,
                0x23,
                0x49,
                0x88,
                0xDD,
                0x81,
                0xBC,
                0x3F,
                0x36,
                0x0F,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMseStreamSource2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x7D,
                0xF5,
                0x66,
                0xE7,
                0xF9,
                0x8A,
                0x41,
                0x9C,
                0xDE,
                0xA0,
                0x20,
                0xE9,
                0x56,
                0x55,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMseStreamSourceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x67,
                0x5C,
                0x46,
                0x70,
                0xD5,
                0xCE,
                0x43,
                0xBA,
                0x21,
                0x0B,
                0xFF,
                0x5F,
                0x3F,
                0xBD,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISceneAnalysisEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0xA3,
                0x4B,
                0xC0,
                0x41,
                0xCA,
                0x13,
                0x48,
                0xBF,
                0xFD,
                0x7B,
                0x08,
                0xB0,
                0xED,
                0x25,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISceneAnalysisEffectFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x0E,
                0xB1,
                0xD8,
                0xD9,
                0x7F,
                0xE1,
                0x42,
                0x85,
                0xEB,
                0x65,
                0x72,
                0xC2,
                0x97,
                0xC9,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISceneAnalysisEffectFrame2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x29,
                0x4E,
                0x2D,
                0x1F,
                0x06,
                0xAE,
                0x47,
                0x99,
                0x15,
                0x02,
                0x52,
                0x4B,
                0x5F,
                0x9A,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISceneAnalyzedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x95,
                0x6B,
                0x14,
                0x51,
                0x28,
                0xE4,
                0x45,
                0xAD,
                0x55,
                0x44,
                0xCF,
                0x8D,
                0xF8,
                0xDB,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISingleSelectMediaTrackList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x6F,
                0x20,
                0x77,
                0x4F,
                0xC3,
                0x4F,
                0x49,
                0x80,
                0x77,
                0x2B,
                0xAD,
                0x9F,
                0xF4,
                0xEC,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechCue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x54,
                0xE2,
                0xAE,
                0x25,
                0x17,
                0xAD,
                0x4B,
                0x80,
                0x43,
                0xA9,
                0x84,
                0x99,
                0xB0,
                0x17,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataStreamDescriptor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x36,
                0x33,
                0x13,
                0x6A,
                0x29,
                0x3E,
                0x46,
                0x9F,
                0xF9,
                0x01,
                0xCD,
                0x25,
                0x69,
                0x14,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataStreamDescriptorFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xDE,
                0x27,
                0xC0,
                0x62,
                0x73,
                0xF9,
                0x4F,
                0x98,
                0xB1,
                0x2D,
                0xFD,
                0x0B,
                0x8D,
                0x1C,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataTrack
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xED,
                0x6A,
                0x9E,
                0x7A,
                0xF6,
                0xA9,
                0x49,
                0xB3,
                0x30,
                0xCF,
                0x03,
                0xB0,
                0xE9,
                0xCF,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataTrack2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xB6,
                0xB4,
                0x21,
                0x9D,
                0x9F,
                0xBA,
                0x40,
                0xA8,
                0xF3,
                0x1A,
                0x92,
                0x75,
                0x3A,
                0xEF,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataTrackError
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x79,
                0x76,
                0xB3,
                0x14,
                0x41,
                0x19,
                0x48,
                0xB9,
                0xD9,
                0xDD,
                0x76,
                0x08,
                0x9E,
                0x72,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataTrackFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x76,
                0xD5,
                0x8D,
                0xB3,
                0x97,
                0x1F,
                0x4E,
                0x85,
                0x2C,
                0x0F,
                0x48,
                0x2C,
                0x81,
                0xAD,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataTrackFailedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xC9,
                0x7F,
                0xA5,
                0x89,
                0x67,
                0x4D,
                0x4D,
                0xB0,
                0x7F,
                0x84,
                0xB4,
                0xF3,
                0x1A,
                0xCB,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataTrackProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x20,
                0x7F,
                0x3B,
                0x4E,
                0xF7,
                0xDE,
                0x4A,
                0x93,
                0xC5,
                0x21,
                0x9D,
                0xA0,
                0x5B,
                0x68,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextBouten
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x27,
                0x06,
                0xD9,
                0x97,
                0x55,
                0x92,
                0x50,
                0x82,
                0x0C,
                0x8F,
                0x73,
                0x8E,
                0x0F,
                0x77,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextCue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x9E,
                0xC7,
                0x51,
                0x86,
                0x3B,
                0x4D,
                0x49,
                0xB3,
                0x59,
                0xBB,
                0x2E,
                0xA7,
                0xAC,
                0xA9,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextLine
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x7C,
                0x8D,
                0x97,
                0x08,
                0x73,
                0x66,
                0x4C,
                0xBE,
                0x50,
                0x65,
                0x77,
                0x72,
                0x89,
                0xF5,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextRegion
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x88,
                0xD0,
                0x1E,
                0x06,
                0x8A,
                0x22,
                0x42,
                0x9F,
                0x59,
                0xB2,
                0x1B,
                0xF4,
                0x01,
                0x24,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextRuby
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0x5C,
                0x33,
                0x10,
                0x3C,
                0x5B,
                0x93,
                0x56,
                0x99,
                0x59,
                0xD0,
                0x5A,
                0x0B,
                0xD2,
                0x46,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x9B,
                0xED,
                0xC4,
                0x1F,
                0x10,
                0x4D,
                0x40,
                0xA9,
                0x49,
                0x82,
                0xF3,
                0x3F,
                0xCD,
                0x93,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextSourceResolveResultEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0x7C,
                0x90,
                0x48,
                0xD8,
                0xDC,
                0x33,
                0x4C,
                0x9A,
                0xD3,
                0x6C,
                0xDC,
                0xE7,
                0xB1,
                0xC5,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextSourceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x18,
                0x31,
                0x7E,
                0xBA,
                0x9A,
                0xC4,
                0x4A,
                0xBB,
                0x98,
                0x2F,
                0xB1,
                0x76,
                0xC3,
                0xBF,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextSourceStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0x76,
                0x6B,
                0xB6,
                0x3E,
                0x92,
                0xFA,
                0x43,
                0x96,
                0x33,
                0x58,
                0x70,
                0x75,
                0x81,
                0x2D,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextStyle
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x38,
                0xB2,
                0x1B,
                0x25,
                0xA8,
                0xC2,
                0x40,
                0xA7,
                0xF5,
                0x28,
                0x1E,
                0xAE,
                0xDF,
                0x3B,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextStyle2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x49,
                0x5F,
                0x65,
                0x11,
                0x61,
                0x87,
                0x47,
                0x89,
                0xCC,
                0x68,
                0x6F,
                0xEC,
                0xE5,
                0x7E,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextStyle3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0xF9,
                0x03,
                0xF8,
                0x99,
                0x3E,
                0x5E,
                0x59,
                0xBB,
                0xB7,
                0x78,
                0xA2,
                0xFA,
                0x13,
                0xC2,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedTextSubformat
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x50,
                0x13,
                0xD7,
                0x61,
                0x32,
                0x22,
                0x47,
                0xA0,
                0xC2,
                0xB9,
                0x37,
                0xB2,
                0x39,
                0x0F,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoStabilizationEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xA6,
                0x08,
                0x08,
                0x98,
                0x96,
                0x57,
                0x4E,
                0x87,
                0x7B,
                0xBD,
                0x7C,
                0xB2,
                0xEE,
                0x0F,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoStabilizationEffectEnabledChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0xFF,
                0x7E,
                0x18,
                0xBB,
                0x67,
                0x13,
                0x47,
                0xB9,
                0x00,
                0x41,
                0x68,
                0xDA,
                0x16,
                0x45,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoStreamDescriptor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x0D,
                0xEE,
                0x12,
                0x2B,
                0x9C,
                0x40,
                0x44,
                0x80,
                0x57,
                0x2C,
                0x7A,
                0x90,
                0xF0,
                0xCB,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoStreamDescriptor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x6E,
                0x30,
                0x8B,
                0x3E,
                0x45,
                0x88,
                0x40,
                0x83,
                0x2D,
                0xC3,
                0x6F,
                0xA4,
                0xF9,
                0x4A,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoStreamDescriptorFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xF6,
                0x4E,
                0x49,
                0x75,
                0xBB,
                0xD2,
                0x43,
                0x9E,
                0x5E,
                0x7B,
                0x79,
                0xA3,
                0xAF,
                0xCE,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoTrack
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0xB7,
                0xF3,
                0x99,
                0x98,
                0xE2,
                0x96,
                0x43,
                0xBB,
                0x6A,
                0xA5,
                0x1B,
                0xE6,
                0xA2,
                0xA2,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoTrackOpenFailedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0xE2,
                0x79,
                0x76,
                0xF9,
                0x04,
                0x82,
                0x4C,
                0xA4,
                0xEE,
                0x86,
                0x02,
                0xC8,
                0xBB,
                0x47,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoTrackSupportInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x34,
                0xB5,
                0x4B,
                0x5F,
                0xFC,
                0x0D,
                0x45,
                0x8F,
                0xF0,
                0x77,
                0x8D,
                0x59,
                0x04,
                0x86,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
