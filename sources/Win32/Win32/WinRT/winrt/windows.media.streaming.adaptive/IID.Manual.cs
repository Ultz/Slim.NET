// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAdaptiveMediaSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x32,
                0x73,
                0x4C,
                0x9F,
                0xD3,
                0x96,
                0x43,
                0xB4,
                0xD9,
                0x04,
                0x39,
                0x57,
                0xA7,
                0xC9,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSource2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x03,
                0x89,
                0x17,
                0x60,
                0x67,
                0xB9,
                0x4B,
                0xA5,
                0x8A,
                0xF7,
                0xAA,
                0x98,
                0xB0,
                0x8C,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSource3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x23,
                0x70,
                0xBA,
                0x34,
                0xC3,
                0x1B,
                0x46,
                0xA3,
                0x6E,
                0xC9,
                0x9F,
                0x54,
                0xF7,
                0x17,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceAdvancedSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x16,
                0xDB,
                0x55,
                0xEB,
                0x1A,
                0xDC,
                0x47,
                0xAA,
                0x08,
                0x9A,
                0x11,
                0x61,
                0x0B,
                0xA4,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceCorrelatedTimes
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x87,
                0x10,
                0x05,
                0x32,
                0xE0,
                0xE1,
                0x48,
                0xAB,
                0x8D,
                0x00,
                0x2B,
                0x0B,
                0x30,
                0x51,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceCreationResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0xB6,
                0x86,
                0x46,
                0x0F,
                0x80,
                0x31,
                0x4E,
                0x90,
                0x93,
                0x76,
                0xD4,
                0x78,
                0x20,
                0x13,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceCreationResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x43,
                0x32,
                0x1C,
                0x44,
                0x1C,
                0x4B,
                0x40,
                0xA2,
                0x01,
                0xDF,
                0x45,
                0xAC,
                0x78,
                0x98,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDiagnosticAvailableEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0x4F,
                0xF6,
                0x3A,
                0x9C,
                0x6D,
                0x4A,
                0x49,
                0xB7,
                0xA9,
                0xB3,
                0xA5,
                0xDE,
                0xE6,
                0xAD,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDiagnosticAvailableEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xD8,
                0x6D,
                0x8C,
                0xA5,
                0x16,
                0x9F,
                0x4D,
                0x81,
                0x0E,
                0x00,
                0xBD,
                0x90,
                0x1B,
                0x3E,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDiagnosticAvailableEventArgs3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x0C,
                0x65,
                0xC3,
                0xEB,
                0xDA,
                0x03,
                0x41,
                0x84,
                0xDA,
                0x68,
                0x76,
                0x9A,
                0xD5,
                0x13,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDiagnostics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0xEE,
                0x24,
                0x9B,
                0x2E,
                0x96,
                0x8C,
                0x44,
                0xAE,
                0xBF,
                0xB2,
                0x9B,
                0x56,
                0x09,
                0x8E,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadBitrateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x0A,
                0x0C,
                0x67,
                0x4E,
                0xE0,
                0xFF,
                0x4E,
                0x81,
                0x6A,
                0x17,
                0x39,
                0x9F,
                0x78,
                0xF4,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadBitrateChangedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0xF4,
                0xF1,
                0xF3,
                0xAE,
                0x96,
                0xE0,
                0x4D,
                0xB5,
                0x40,
                0x2B,
                0x32,
                0x46,
                0xE6,
                0x96,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x0D,
                0x24,
                0x19,
                0x37,
                0x5B,
                0x1A,
                0x4A,
                0x89,
                0x70,
                0xD6,
                0x21,
                0xCB,
                0x6C,
                0xA8,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadCompletedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0x44,
                0x47,
                0x70,
                0x4A,
                0x96,
                0xE4,
                0x40,
                0xAF,
                0x95,
                0x91,
                0x77,
                0xDD,
                0x6D,
                0xFA,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadCompletedEventArgs3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x8B,
                0x8A,
                0x0F,
                0xB2,
                0x93,
                0xC6,
                0x47,
                0xBA,
                0xDC,
                0x8B,
                0xE2,
                0xC8,
                0xF7,
                0xF6,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadFailedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x90,
                0x73,
                0x37,
                0xAB,
                0xF4,
                0xA4,
                0x40,
                0xB1,
                0x35,
                0xC6,
                0xDF,
                0xD8,
                0xBD,
                0x7F,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadFailedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x95,
                0x91,
                0x70,
                0x7C,
                0x96,
                0x86,
                0x49,
                0x90,
                0xC5,
                0xC6,
                0xFC,
                0x4B,
                0x31,
                0xE2,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadFailedEventArgs3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x45,
                0x35,
                0xD0,
                0x32,
                0x11,
                0x10,
                0x4A,
                0x91,
                0x5A,
                0xC2,
                0x21,
                0x1B,
                0x5B,
                0x94,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadRequestedDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x8F,
                0xC6,
                0x05,
                0x20,
                0xFA,
                0xBD,
                0x4D,
                0x98,
                0x21,
                0x4B,
                0xF4,
                0xC9,
                0xBF,
                0x77,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0xDF,
                0x3F,
                0xC8,
                0xA9,
                0x44,
                0xA2,
                0x47,
                0xBF,
                0x96,
                0x03,
                0x39,
                0x8B,
                0x4B,
                0xFA,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadRequestedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x8B,
                0x7D,
                0xB3,
                0x44,
                0xAA,
                0x82,
                0x4D,
                0x82,
                0x5B,
                0x61,
                0x1D,
                0xE3,
                0xBC,
                0xFE,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadRequestedEventArgs3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x50,
                0x3C,
                0x33,
                0x62,
                0x4F,
                0x81,
                0x44,
                0xAB,
                0x44,
                0x1E,
                0x47,
                0xB0,
                0x57,
                0x42,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xDC,
                0xAF,
                0xF4,
                0xEE,
                0xBC,
                0x6A,
                0x4A,
                0x9F,
                0x0A,
                0xFE,
                0xC4,
                0x1E,
                0x23,
                0x39,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x2C,
                0x55,
                0x15,
                0x80,
                0x7B,
                0xC4,
                0x4A,
                0x86,
                0x60,
                0xA4,
                0xB9,
                0x7F,
                0x7C,
                0x70,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceDownloadStatistics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0xCE,
                0x06,
                0xA3,
                0x6A,
                0xE9,
                0xFF,
                0x4D,
                0xA9,
                0xB8,
                0x1A,
                0xE0,
                0x8C,
                0x01,
                0xAE,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourcePlaybackBitrateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x9F,
                0xA2,
                0x23,
                0xDA,
                0x7D,
                0x51,
                0x4A,
                0x87,
                0xA9,
                0x6F,
                0xA8,
                0xC5,
                0xB2,
                0x92,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveMediaSourceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xBD,
                0xA6,
                0x50,
                0xEF,
                0x66,
                0xD3,
                0x4C,
                0x95,
                0x79,
                0x9E,
                0x66,
                0x05,
                0x07,
                0xDC,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
