// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBackgroundMediaPlayerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0xDB,
                0x6D,
                0x85,
                0xF7,
                0x55,
                0x1F,
                0x47,
                0xA0,
                0xF2,
                0x68,
                0xAC,
                0x4C,
                0x90,
                0x45,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICurrentMediaPlaybackItemChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0xA8,
                0x43,
                0x17,
                0x43,
                0x5C,
                0x15,
                0x4A,
                0x96,
                0x7A,
                0x57,
                0x2D,
                0x2D,
                0x0F,
                0x26,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICurrentMediaPlaybackItemChangedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0xA5,
                0x80,
                0x1D,
                0x6E,
                0x99,
                0xA9,
                0x40,
                0xBE,
                0x48,
                0xE6,
                0x6E,
                0xC9,
                0x0B,
                0x2B,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBreak
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0xE2,
                0x4B,
                0x71,
                0xEF,
                0x0D,
                0xBC,
                0x4E,
                0xA4,
                0x89,
                0x6B,
                0x34,
                0x93,
                0x0E,
                0x15,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBreakEndedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x32,
                0xB9,
                0x32,
                0x5D,
                0x1C,
                0xEE,
                0x4F,
                0x87,
                0x32,
                0x23,
                0x6D,
                0xC3,
                0xA8,
                0x85,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBreakFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xE0,
                0x16,
                0x45,
                0xE0,
                0x18,
                0x79,
                0x40,
                0x8B,
                0x5F,
                0xD3,
                0x34,
                0x95,
                0xC1,
                0x5D,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBreakManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0xDD,
                0x54,
                0xA8,
                0xB4,
                0xFE,
                0x9B,
                0x4D,
                0x9D,
                0x97,
                0x0F,
                0xDB,
                0xE5,
                0x8E,
                0x5E,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBreakSchedule
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x58,
                0x9A,
                0xA1,
                0xB6,
                0x98,
                0xD8,
                0x41,
                0x83,
                0xDA,
                0xF9,
                0x71,
                0xD2,
                0x2B,
                0x7B,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBreakSeekedOverEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x67,
                0xAA,
                0xE5,
                0x06,
                0x06,
                0x92,
                0x44,
                0xB9,
                0xD3,
                0xC3,
                0xC8,
                0xFD,
                0xE0,
                0xA4,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBreakSkippedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x4C,
                0xE9,
                0x6E,
                0x54,
                0x2F,
                0x3E,
                0x4A,
                0xA3,
                0xAB,
                0x24,
                0xC3,
                0xB2,
                0x70,
                0xB4,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaBreakStartedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xFE,
                0x7E,
                0xA8,
                0xD4,
                0xDF,
                0x4A,
                0x45,
                0x95,
                0x6E,
                0x0A,
                0x4A,
                0x64,
                0x83,
                0x95,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaEnginePlaybackSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x0B,
                0x1D,
                0x5C,
                0x56,
                0x38,
                0xB9,
                0x48,
                0x8D,
                0xC6,
                0x24,
                0x4B,
                0xF1,
                0x07,
                0xBF,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaItemDisplayProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x1B,
                0x3C,
                0x1E,
                0x97,
                0x70,
                0x84,
                0x43,
                0xA2,
                0x17,
                0xC1,
                0x29,
                0x1D,
                0xFA,
                0x8C,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0xE5,
                0xCE,
                0x5A,
                0xB6,
                0x5C,
                0x5A,
                0x4A,
                0x85,
                0x21,
                0xCC,
                0x86,
                0xB1,
                0xC1,
                0xED,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x4F,
                0x6F,
                0x3D,
                0x30,
                0x52,
                0x11,
                0x44,
                0xA0,
                0xE9,
                0xBA,
                0xD9,
                0x4C,
                0x2A,
                0x04,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerCommandBehavior
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0x1E,
                0x6C,
                0x78,
                0x78,
                0xCE,
                0x10,
                0x4A,
                0xAF,
                0xD6,
                0x84,
                0x3F,
                0xCB,
                0xB9,
                0x0C,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerFastForwardReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x64,
                0xF0,
                0x30,
                0x91,
                0xB4,
                0x0A,
                0x4D,
                0xBC,
                0x21,
                0x30,
                0x98,
                0xBD,
                0x13,
                0x32,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerNextReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x44,
                0x50,
                0xE1,
                0xB0,
                0xA2,
                0xD4,
                0x45,
                0xB9,
                0xDE,
                0x5F,
                0x42,
                0xAC,
                0x14,
                0xA8,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerPauseReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0xCD,
                0xEC,
                0x5C,
                0x5C,
                0xC2,
                0x21,
                0x42,
                0xB1,
                0x6C,
                0xC3,
                0xC9,
                0x8C,
                0xE0,
                0x12,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerPlayReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x00,
                0xF0,
                0x9A,
                0x8B,
                0x57,
                0x56,
                0x4C,
                0xA0,
                0x06,
                0x16,
                0x15,
                0x9D,
                0x88,
                0x8A,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerPositionReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xA7,
                0x91,
                0x55,
                0x27,
                0xD6,
                0xDD,
                0x4B,
                0xA9,
                0x0D,
                0x86,
                0xA0,
                0x15,
                0xB2,
                0x49,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerPreviousReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x30,
                0x5E,
                0x52,
                0x32,
                0x46,
                0x76,
                0x4F,
                0x99,
                0xB1,
                0xD7,
                0x71,
                0x62,
                0x3F,
                0x62,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerRateReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x39,
                0xEA,
                0x18,
                0x16,
                0x4A,
                0x69,
                0x41,
                0x8B,
                0x05,
                0x3E,
                0xB9,
                0xF5,
                0xFF,
                0x78,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerRewindReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x59,
                0x08,
                0x9F,
                0xC0,
                0xA3,
                0x5D,
                0x42,
                0xAA,
                0xEF,
                0x97,
                0xBA,
                0x78,
                0x98,
                0xB1,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackCommandManagerShuffleReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x5C,
                0xA0,
                0x50,
                0xEE,
                0x63,
                0x96,
                0x4A,
                0xB7,
                0xB5,
                0xFE,
                0xE0,
                0x8B,
                0x9F,
                0xF9,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x97,
                0x70,
                0x04,
                0xAF,
                0xE4,
                0xAB,
                0x48,
                0xB2,
                0x83,
                0x69,
                0x29,
                0xE6,
                0x74,
                0xEC,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackItem2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xD1,
                0x59,
                0xD8,
                0xEF,
                0xD7,
                0x81,
                0x4B,
                0xAC,
                0x1F,
                0xF4,
                0x04,
                0x93,
                0xCB,
                0xB0,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackItem3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x82,
                0x32,
                0x0D,
                0x0A,
                0xB8,
                0x09,
                0x4D,
                0x9F,
                0xF8,
                0xF8,
                0x70,
                0x94,
                0xA1,
                0xC8,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackItemError
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xEF,
                0xFB,
                0x69,
                0xD6,
                0xDC,
                0xF9,
                0x4D,
                0xA4,
                0x50,
                0xDB,
                0xF4,
                0xC6,
                0xF1,
                0xC2,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackItemFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0xFC,
                0x33,
                0x71,
                0x69,
                0x17,
                0xF9,
                0x4F,
                0xA7,
                0xC1,
                0x38,
                0xD2,
                0xC4,
                0xD4,
                0x23,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackItemFactory2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0xDF,
                0x7C,
                0xD7,
                0x47,
                0xB9,
                0x72,
                0x49,
                0xB3,
                0x5D,
                0xAD,
                0xFB,
                0x93,
                0x1A,
                0x71,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackItemFailedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x13,
                0x03,
                0x77,
                0xA7,
                0xE9,
                0xC3,
                0x47,
                0x86,
                0x2C,
                0xC6,
                0x56,
                0xD3,
                0x06,
                0x83,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackItemOpenedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0xBD,
                0xD9,
                0xCB,
                0x37,
                0x30,
                0xBE,
                0x4F,
                0xAE,
                0x8F,
                0x39,
                0xFC,
                0x39,
                0xED,
                0xF4,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackItemStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xE7,
                0x1B,
                0x4B,
                0x45,
                0x43,
                0x3C,
                0x40,
                0x8A,
                0x67,
                0xF5,
                0xDE,
                0x91,
                0xDF,
                0x4C,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0xEE,
                0x77,
                0x7F,
                0x42,
                0xDC,
                0x26,
                0x4E,
                0xA9,
                0x8D,
                0x78,
                0x50,
                0xDF,
                0x8E,
                0xC9,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackList2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xB4,
                0x09,
                0x0E,
                0x0A,
                0x60,
                0x74,
                0x42,
                0xA1,
                0x4B,
                0x0B,
                0x67,
                0x23,
                0xD0,
                0xF4,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackList3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0xBB,
                0x24,
                0xDD,
                0x47,
                0xBC,
                0x63,
                0x44,
                0xAA,
                0x90,
                0xC1,
                0x8B,
                0x7E,
                0x5F,
                0xFD,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackSession
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x68,
                0x2B,
                0xC3,
                0x07,
                0x04,
                0xBA,
                0x41,
                0x89,
                0x46,
                0x8B,
                0x34,
                0x5A,
                0x5A,
                0x54,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackSession2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x7C,
                0xBA,
                0xF8,
                0xC8,
                0x1F,
                0x97,
                0x40,
                0xAD,
                0x70,
                0xC0,
                0xFA,
                0x18,
                0xCC,
                0x00,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackSession3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0xB4,
                0xA2,
                0x7B,
                0xE2,
                0xA3,
                0x5F,
                0x40,
                0xB7,
                0x7B,
                0xA4,
                0x81,
                0x2C,
                0x23,
                0x8B,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackSessionBufferingStartedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0xAF,
                0x6A,
                0xCD,
                0xE2,
                0x74,
                0xB5,
                0x43,
                0xB1,
                0x15,
                0x76,
                0x23,
                0x6C,
                0x33,
                0x79,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackSessionOutputDegradationPolicyState
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0x72,
                0x8E,
                0x55,
                0x33,
                0xF6,
                0xF9,
                0x49,
                0x96,
                0x5A,
                0xAB,
                0xAA,
                0x1D,
                0xB7,
                0x09,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0xC2,
                0x9D,
                0xEF,
                0x17,
                0x93,
                0x96,
                0x46,
                0xB0,
                0x51,
                0x2B,
                0xAD,
                0x64,
                0x31,
                0x77,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackSphericalVideoProjection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0xB3,
                0x05,
                0xD4,
                0x0E,
                0x6F,
                0x61,
                0x46,
                0xB8,
                0xEE,
                0xD4,
                0x87,
                0xBA,
                0x97,
                0x52,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlaybackTimedMetadataTrackList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x13,
                0xB4,
                0x72,
                0xFB,
                0xBB,
                0xA3,
                0x46,
                0x93,
                0x72,
                0x9C,
                0x9C,
                0x74,
                0x4B,
                0x94,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x83,
                0x1A,
                0x38,
                0xFF,
                0x6F,
                0x9B,
                0x49,
                0x8D,
                0x64,
                0x28,
                0x85,
                0xDF,
                0xC1,
                0x24,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayer2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x12,
                0x84,
                0x3C,
                0x23,
                0x21,
                0xC5,
                0x4F,
                0x90,
                0x82,
                0x2F,
                0x88,
                0x3F,
                0x77,
                0xBD,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayer3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x60,
                0x06,
                0xEE,
                0x1B,
                0x03,
                0xEB,
                0x4F,
                0xBD,
                0x9B,
                0x92,
                0xE0,
                0xA0,
                0xA8,
                0xD2,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayer4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x5D,
                0x03,
                0x80,
                0x48,
                0x74,
                0x70,
                0x47,
                0xAF,
                0xCF,
                0x2A,
                0x57,
                0x45,
                0x09,
                0x14,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayer5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x37,
                0xE5,
                0xCF,
                0x6A,
                0xF8,
                0x46,
                0x44,
                0xBF,
                0x4D,
                0xC8,
                0xE7,
                0x92,
                0xB7,
                0xB4,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayer6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0xA0,
                0xCA,
                0xE0,
                0x65,
                0xAE,
                0x4C,
                0x41,
                0xB0,
                0x10,
                0x8B,
                0xC5,
                0x5F,
                0x00,
                0xE6,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayer7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xC4,
                0x1D,
                0x5D,
                0x00,
                0x45,
                0x31,
                0x45,
                0xB3,
                0xF4,
                0x77,
                0x7A,
                0x71,
                0x49,
                0x1F,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayerDataReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x94,
                0x5A,
                0xC7,
                0x01,
                0xC8,
                0x2A,
                0x41,
                0x83,
                0x5B,
                0x83,
                0xFC,
                0x0E,
                0x62,
                0x2A,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayerEffects
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0xDE,
                0xA1,
                0x85,
                0xB6,
                0xCA,
                0xC0,
                0x4C,
                0x8B,
                0xE3,
                0x60,
                0x35,
                0xF4,
                0xDE,
                0x25,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayerEffects2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x9A,
                0x41,
                0xFA,
                0xBE,
                0x1B,
                0xC5,
                0x46,
                0xAE,
                0x1F,
                0x8E,
                0xE6,
                0x9F,
                0xB3,
                0xC2,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayerFailedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xE9,
                0x44,
                0x27,
                0xE3,
                0xA7,
                0x16,
                0x4F,
                0xBA,
                0xC4,
                0x79,
                0x14,
                0xEB,
                0xC0,
                0x83,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayerRateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x0D,
                0x60,
                0x40,
                0x61,
                0x3B,
                0xB2,
                0x4B,
                0x98,
                0x9F,
                0xFC,
                0x65,
                0x60,
                0x8B,
                0x6C,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayerSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0x88,
                0x4F,
                0xBD,
                0x23,
                0x14,
                0x3E,
                0x4C,
                0x82,
                0xC5,
                0x0F,
                0xB1,
                0xAF,
                0x94,
                0xF7,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayerSource2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x9B,
                0x44,
                0x82,
                0x22,
                0x73,
                0x0B,
                0x4C,
                0xB0,
                0x3B,
                0x3E,
                0x69,
                0xA4,
                0x82,
                0x60,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaPlayerSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x53,
                0xD6,
                0x0E,
                0x36,
                0xB7,
                0xC3,
                0x49,
                0x83,
                0x0B,
                0x76,
                0x4A,
                0x38,
                0x45,
                0x31,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPlaybackMediaMarker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x2F,
                0xD2,
                0xC4,
                0x1C,
                0x3C,
                0x44,
                0x44,
                0xB6,
                0xB9,
                0x77,
                0x8B,
                0x04,
                0x22,
                0xD4,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPlaybackMediaMarkerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0x0A,
                0x53,
                0x8C,
                0xAE,
                0xE0,
                0x1A,
                0x4E,
                0xA8,
                0xC8,
                0xE2,
                0x3F,
                0x98,
                0x2A,
                0x93,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPlaybackMediaMarkerReachedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xD1,
                0x8C,
                0x57,
                0xE2,
                0x90,
                0x60,
                0x4E,
                0xAB,
                0xC4,
                0x87,
                0x40,
                0xB0,
                0x1F,
                0x61,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPlaybackMediaMarkerSequence
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x0C,
                0x81,
                0xF2,
                0x8B,
                0x63,
                0xCF,
                0x46,
                0x88,
                0x17,
                0x1D,
                0x11,
                0x1F,
                0xE9,
                0xD8,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimedMetadataPresentationModeChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x60,
                0x63,
                0xD1,
                0xDF,
                0x65,
                0xAE,
                0x45,
                0x8C,
                0xEF,
                0xDC,
                0x0B,
                0x53,
                0xFD,
                0xC2,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
