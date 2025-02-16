// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBackgroundAudioTrack
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0xB3,
                0x91,
                0x4B,
                0x21,
                0x9E,
                0x66,
                0x42,
                0xA9,
                0xC2,
                0x67,
                0xDD,
                0x01,
                0x1A,
                0x23,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundAudioTrackStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0xC0,
                0xB1,
                0xD9,
                0x18,
                0xD0,
                0xA8,
                0x42,
                0xA5,
                0x59,
                0xCB,
                0x4D,
                0x9E,
                0x97,
                0xE6,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmbeddedAudioTrack
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0x5A,
                0xEE,
                0x55,
                0x30,
                0x2D,
                0xBA,
                0x3F,
                0xA1,
                0x90,
                0x4F,
                0x1A,
                0x64,
                0x54,
                0xF8,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaClip
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x53,
                0xF2,
                0x53,
                0xBA,
                0x5F,
                0xA4,
                0x3E,
                0x86,
                0x93,
                0x24,
                0x76,
                0x18,
                0x11,
                0x14,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaClipStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x2B,
                0x40,
                0xFA,
                0x8F,
                0x92,
                0xC4,
                0x43,
                0xBC,
                0x6E,
                0x78,
                0x3A,
                0x1A,
                0x35,
                0x96,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaClipStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0xD7,
                0x1D,
                0x5B,
                0x4E,
                0x85,
                0x9B,
                0x4D,
                0x87,
                0x7D,
                0x47,
                0x74,
                0xA5,
                0x56,
                0xCD,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaComposition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0xE6,
                0x06,
                0x2E,
                0x71,
                0xDC,
                0xD6,
                0x41,
                0xB8,
                0x37,
                0x2D,
                0x2B,
                0xC1,
                0x4A,
                0x29,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaComposition2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x53,
                0x9E,
                0xA5,
                0x66,
                0x23,
                0x2C,
                0x49,
                0xBE,
                0xC8,
                0xE6,
                0xDF,
                0xBA,
                0x6D,
                0x02,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCompositionStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x8F,
                0xA0,
                0x87,
                0x2A,
                0xE3,
                0xCE,
                0x45,
                0x8F,
                0x66,
                0xA3,
                0x0D,
                0xF0,
                0x76,
                0x62,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaOverlay
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xAE,
                0x02,
                0xA9,
                0x69,
                0x78,
                0x30,
                0x48,
                0x8A,
                0xB1,
                0x94,
                0xDC,
                0x01,
                0xC0,
                0x5F,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaOverlayFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x82,
                0x84,
                0xB5,
                0x88,
                0x61,
                0x8F,
                0x4F,
                0xA2,
                0xE0,
                0xAA,
                0x55,
                0x2D,
                0x59,
                0x8E,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaOverlayLayer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xBA,
                0xD9,
                0xA6,
                0xDA,
                0xEE,
                0xC6,
                0x46,
                0xBB,
                0xE5,
                0xE3,
                0x98,
                0xC8,
                0x41,
                0x68,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaOverlayLayerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xB4,
                0x7C,
                0x94,
                0x9E,
                0xA3,
                0x62,
                0x43,
                0xAB,
                0xBF,
                0x9F,
                0x8B,
                0x50,
                0x70,
                0xA0,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
