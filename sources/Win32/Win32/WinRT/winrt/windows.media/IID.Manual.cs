// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAudioBuffer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x58,
                0x17,
                0x35,
                0x4B,
                0x72,
                0x6A,
                0x4C,
                0xB1,
                0x30,
                0xF6,
                0x53,
                0x7F,
                0x9A,
                0xE0,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0xC3,
                0x6A,
                0xE3,
                0xB2,
                0xAA,
                0x77,
                0x42,
                0x9E,
                0xD0,
                0x43,
                0xCE,
                0xDF,
                0x8E,
                0x29,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioFrameFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x0A,
                0xA9,
                0x91,
                0x22,
                0x24,
                0xA6,
                0x40,
                0xB9,
                0xAD,
                0x30,
                0xD0,
                0x24,
                0x04,
                0x31,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAutoRepeatModeChangeRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x7E,
                0x13,
                0xEA,
                0x52,
                0xD8,
                0x8E,
                0x43,
                0x88,
                0x2B,
                0xC9,
                0x90,
                0x10,
                0x9A,
                0x78,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IImageDisplayProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0xC7,
                0x0B,
                0xCD,
                0xE7,
                0x54,
                0x1F,
                0x41,
                0x99,
                0x33,
                0xF0,
                0xE9,
                0x8B,
                0x0A,
                0x96,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_WinRT_IMediaControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0xFB,
                0xF1,
                0x98,
                0x8D,
                0x7A,
                0xCB,
                0x42,
                0xB6,
                0xFE,
                0x8F,
                0xE6,
                0x98,
                0x26,
                0x4F,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaExtension
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x51,
                0x91,
                0x07,
                0xDF,
                0x45,
                0x2B,
                0x44,
                0x8A,
                0x3F,
                0xF7,
                0x82,
                0x6A,
                0x63,
                0x70,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaExtensionManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0xEA,
                0x25,
                0x4A,
                0x2D,
                0x24,
                0xFB,
                0x4D,
                0x97,
                0xF4,
                0x69,
                0xB7,
                0xC4,
                0x25,
                0x76,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaExtensionManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0xBF,
                0xCE,
                0x5B,
                0x43,
                0x40,
                0xED,
                0x4F,
                0xAC,
                0xAF,
                0x54,
                0xEC,
                0x29,
                0xDF,
                0xB1,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x2F,
                0xB5,
                0xBF,
                0x43,
                0x59,
                0xD8,
                0x47,
                0x8E,
                0x10,
                0x05,
                0x30,
                0x8A,
                0xA5,
                0xFB,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaMarker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xDE,
                0x03,
                0x18,
                0xA5,
                0xDC,
                0x6F,
                0x4B,
                0x9C,
                0x20,
                0xE3,
                0xD3,
                0xC0,
                0x64,
                0x36,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaMarkerTypesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x80,
                0x19,
                0xBB,
                0x2F,
                0x48,
                0x43,
                0x47,
                0x88,
                0x32,
                0x45,
                0x85,
                0x38,
                0x21,
                0xEC,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaMarkers
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xB1,
                0xEA,
                0xAF,
                0xDD,
                0xF8,
                0x6E,
                0x46,
                0xAA,
                0x10,
                0x92,
                0x0B,
                0x52,
                0x35,
                0x3F,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaProcessingTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x64,
                0x85,
                0xEB,
                0x51,
                0xA3,
                0x4E,
                0x4F,
                0xB4,
                0xF0,
                0x9B,
                0xF2,
                0x40,
                0x89,
                0x93,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaTimelineController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x61,
                0xD3,
                0x8E,
                0x78,
                0x0B,
                0x60,
                0x43,
                0xBF,
                0x71,
                0x0C,
                0x84,
                0x19,
                0x99,
                0xEA,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaTimelineController2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0xEA,
                0x74,
                0xEF,
                0x72,
                0x9E,
                0xF9,
                0x4D,
                0x83,
                0x55,
                0x6E,
                0x90,
                0xC8,
                0x1B,
                0xBA,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaTimelineControllerFailedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0xF8,
                0x21,
                0x88,
                0x77,
                0x3E,
                0xFB,
                0x43,
                0xBE,
                0x26,
                0x4F,
                0xC8,
                0x7A,
                0x04,
                0x48,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMusicDisplayProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x0C,
                0xBF,
                0x6B,
                0xA0,
                0xD0,
                0x26,
                0x4D,
                0x92,
                0xA0,
                0xF9,
                0x78,
                0xE1,
                0xD1,
                0x8E,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMusicDisplayProperties2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0x84,
                0x36,
                0x00,
                0xD3,
                0x97,
                0xB9,
                0x44,
                0xB0,
                0x0F,
                0x00,
                0x8A,
                0xFC,
                0xEF,
                0xAF,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMusicDisplayProperties3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x1A,
                0xB5,
                0x4D,
                0x81,
                0x06,
                0x8C,
                0x4E,
                0x94,
                0x01,
                0xB8,
                0x15,
                0x9D,
                0x9E,
                0xEF,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPlaybackPositionChangeRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x3F,
                0x49,
                0xB4,
                0x28,
                0xEB,
                0x61,
                0x49,
                0x9C,
                0x14,
                0x33,
                0x5E,
                0x44,
                0xF3,
                0xE1,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPlaybackRateChangeRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0xC4,
                0xE2,
                0x2C,
                0xD6,
                0x3C,
                0x77,
                0x4F,
                0x9B,
                0xA7,
                0xEB,
                0x27,
                0xC2,
                0x6A,
                0x21,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShuffleEnabledChangeRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x93,
                0xB5,
                0x49,
                0xD0,
                0x4F,
                0x66,
                0x46,
                0xA3,
                0x14,
                0xC0,
                0xE0,
                0x19,
                0x40,
                0xD3,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMediaTransportControls
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x3F,
                0xFA,
                0x99,
                0x42,
                0x17,
                0xA6,
                0x42,
                0x90,
                0x2E,
                0x08,
                0x7D,
                0x41,
                0xF9,
                0x65,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMediaTransportControls2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0xD2,
                0x98,
                0xEA,
                0x3C,
                0x7F,
                0xF2,
                0x4A,
                0xA5,
                0x86,
                0x72,
                0x88,
                0x98,
                0x08,
                0xEF,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMediaTransportControlsButtonPressedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x71,
                0xF4,
                0xB7,
                0x6F,
                0xA5,
                0xC8,
                0x4D,
                0x9E,
                0x11,
                0x92,
                0x03,
                0x1F,
                0x4A,
                0x87,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMediaTransportControlsDisplayUpdater
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0xC5,
                0xBB,
                0x8A,
                0x55,
                0xFA,
                0xCF,
                0x4E,
                0xAD,
                0x8E,
                0xC9,
                0x84,
                0xE5,
                0xDD,
                0x15,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMediaTransportControlsPropertyChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0x09,
                0xCA,
                0xD0,
                0x9B,
                0x33,
                0xB3,
                0x4C,
                0x8E,
                0xEB,
                0x73,
                0x76,
                0x07,
                0xF5,
                0x6E,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMediaTransportControlsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x38,
                0xBA,
                0x43,
                0xA4,
                0xEC,
                0x32,
                0x48,
                0x91,
                0xAB,
                0xD4,
                0x15,
                0xFA,
                0xE4,
                0x84,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMediaTransportControlsTimelineProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x31,
                0x25,
                0x51,
                0xA2,
                0xC3,
                0x5B,
                0x47,
                0x85,
                0x07,
                0x93,
                0x53,
                0x4D,
                0xC8,
                0x8F,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoDisplayProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0xFD,
                0x09,
                0x56,
                0x2D,
                0x5D,
                0x72,
                0x48,
                0x81,
                0x70,
                0x45,
                0xDE,
                0xE5,
                0xBC,
                0x2F,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoDisplayProperties2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0xE1,
                0x10,
                0xB4,
                0x52,
                0xAB,
                0xAB,
                0x41,
                0xA4,
                0x86,
                0xCC,
                0x10,
                0xFA,
                0xB1,
                0x52,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEffectsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xA5,
                0xCD,
                0x1F,
                0xF1,
                0xBA,
                0x21,
                0x45,
                0x98,
                0x0C,
                0x3B,
                0xCE,
                0xBB,
                0x44,
                0xCF,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x66,
                0xC0,
                0x0C,
                0xFC,
                0x90,
                0x92,
                0x4C,
                0xBD,
                0x95,
                0x7D,
                0xED,
                0x21,
                0x81,
                0x9D,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoFrame2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0x84,
                0x37,
                0x38,
                0x6C,
                0x33,
                0x66,
                0x43,
                0x8D,
                0x46,
                0x06,
                0x07,
                0x98,
                0x73,
                0x6C,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoFrameFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0x6D,
                0x4B,
                0x01,
                0x28,
                0x22,
                0x92,
                0x4C,
                0x92,
                0xFF,
                0x50,
                0xC3,
                0x80,
                0xD3,
                0xE7,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoFrameStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x55,
                0x2A,
                0xAB,
                0x11,
                0x61,
                0x33,
                0x4B,
                0x8E,
                0xC3,
                0x2B,
                0x20,
                0x9A,
                0x02,
                0xE1,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
