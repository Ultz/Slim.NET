// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IMediaCaptureFailedEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0xEF,
                0x14,
                0x20,
                0xD8,
                0x5C,
                0x08,
                0x4F,
                0xA3,
                0x14,
                0x0D,
                0x36,
                0x0D,
                0xA5,
                0x9F,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRecordLimitationExceededEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x8F,
                0xAE,
                0x3F,
                0xE1,
                0x4F,
                0xFD,
                0x4F,
                0xAA,
                0xBA,
                0xE1,
                0xF1,
                0x33,
                0x7D,
                0x4E,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedCapturedPhoto
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x72,
                0x72,
                0xF0,
                0x92,
                0xB2,
                0x91,
                0x44,
                0x9D,
                0x41,
                0x99,
                0x80,
                0x7A,
                0x55,
                0x0B,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedCapturedPhoto2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x6C,
                0xCF,
                0x18,
                0xFE,
                0xCF,
                0xD8,
                0x42,
                0x81,
                0x04,
                0x01,
                0x7B,
                0xB3,
                0x18,
                0xF4,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedPhotoCapture
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0xAA,
                0xFF,
                0x83,
                0x67,
                0x66,
                0xDC,
                0x44,
                0x97,
                0x3C,
                0xA6,
                0xBC,
                0xE5,
                0x96,
                0xAA,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastBackgroundService
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0xE7,
                0xD1,
                0xBA,
                0x94,
                0xFA,
                0xF9,
                0x46,
                0x95,
                0xFC,
                0xD7,
                0x15,
                0x11,
                0xCD,
                0xA7,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastBackgroundService2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0xCB,
                0x8C,
                0xFC,
                0x49,
                0x55,
                0x87,
                0x4B,
                0x95,
                0x9F,
                0x23,
                0xCA,
                0x40,
                0x1F,
                0xD4,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastBackgroundServiceSignInInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x52,
                0x73,
                0x5E,
                0xC8,
                0x88,
                0xCA,
                0x4E,
                0x89,
                0xBA,
                0x48,
                0x25,
                0x98,
                0x5D,
                0xB8,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastBackgroundServiceSignInInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x28,
                0x04,
                0x91,
                0xCF,
                0x62,
                0x3C,
                0x4A,
                0xA7,
                0xEE,
                0xAE,
                0xB5,
                0x07,
                0x40,
                0x46,
                0x45,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastBackgroundServiceStreamInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x02,
                0xDC,
                0x31,
                0x0A,
                0x99,
                0x04,
                0x49,
                0xAA,
                0x96,
                0xFE,
                0x36,
                0x43,
                0x81,
                0xF1,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastBackgroundServiceStreamInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x9F,
                0x1E,
                0xBD,
                0xDC,
                0x94,
                0xCE,
                0x4F,
                0x95,
                0x41,
                0xA9,
                0xF1,
                0x29,
                0x59,
                0x63,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastCameraCaptureStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x4C,
                0x33,
                0x1E,
                0x82,
                0xB8,
                0x88,
                0x4B,
                0x86,
                0x92,
                0x05,
                0x99,
                0x9A,
                0xCE,
                0xB7,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastGlobalSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA5,
                0x27,
                0xCB,
                0xB2,
                0xFC,
                0x70,
                0x17,
                0x4E,
                0x80,
                0xBD,
                0x6B,
                0xA0,
                0xFD,
                0x3F,
                0xF3,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastHeartbeatRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x42,
                0xA5,
                0xCE,
                0x51,
                0xEE,
                0xBF,
                0x4D,
                0x94,
                0x72,
                0x79,
                0xA9,
                0xED,
                0x4E,
                0x21,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x01,
                0x4E,
                0x36,
                0x4E,
                0x1E,
                0x1F,
                0x41,
                0xAB,
                0x3E,
                0x92,
                0x95,
                0x98,
                0x44,
                0xC1,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastMicrophoneCaptureStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0xD5,
                0x6A,
                0xA8,
                0x40,
                0x94,
                0x08,
                0x49,
                0x9D,
                0x09,
                0x65,
                0xB7,
                0xE3,
                0x15,
                0xD7,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastPlugIn
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x1E,
                0x0C,
                0x52,
                0x13,
                0x65,
                0x74,
                0x45,
                0xAC,
                0x54,
                0x23,
                0xB7,
                0x97,
                0x29,
                0x61,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastPlugInManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0xD9,
                0x50,
                0xE5,
                0xA1,
                0x27,
                0xA7,
                0x49,
                0xBB,
                0xF4,
                0xD7,
                0xA9,
                0xE9,
                0xD0,
                0x76,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastPlugInManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x5C,
                0x64,
                0xF2,
                0x76,
                0x5C,
                0xDC,
                0x4C,
                0x93,
                0x64,
                0x82,
                0xFE,
                0x9E,
                0xB6,
                0x53,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastPlugInStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xD0,
                0x81,
                0x48,
                0xC5,
                0xAB,
                0xC6,
                0x4F,
                0x84,
                0xB0,
                0x89,
                0x37,
                0x0B,
                0xB4,
                0x72,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastPreview
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x0F,
                0xB6,
                0x14,
                0x4A,
                0x6E,
                0x80,
                0x4B,
                0xA1,
                0x4F,
                0x67,
                0xEE,
                0x77,
                0xD1,
                0x53,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastPreviewStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0xF2,
                0x57,
                0x5A,
                0xEA,
                0x8D,
                0x86,
                0x4E,
                0x90,
                0xAD,
                0x03,
                0xFC,
                0x26,
                0xB9,
                0x65,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastPreviewStreamReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x8D,
                0x22,
                0x92,
                0x3F,
                0xDB,
                0xA8,
                0x40,
                0x8C,
                0xD4,
                0xF4,
                0xE3,
                0x71,
                0xDD,
                0xAB,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastPreviewStreamVideoFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xBE,
                0x0F,
                0x01,
                0xFE,
                0x94,
                0x99,
                0x44,
                0xB8,
                0xC0,
                0x8D,
                0x24,
                0x42,
                0x79,
                0xFB,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastPreviewStreamVideoHeader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x61,
                0xEF,
                0x8B,
                0x84,
                0xDA,
                0x99,
                0x44,
                0xA7,
                0xAB,
                0x87,
                0x11,
                0x8C,
                0xB4,
                0xA1,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastProviderSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xDF,
                0x0B,
                0xC3,
                0x48,
                0x99,
                0x8F,
                0x45,
                0xAD,
                0x50,
                0xAA,
                0x06,
                0xEC,
                0x03,
                0xDA,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastServices
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xB4,
                0x60,
                0x86,
                0x9B,
                0x96,
                0x3C,
                0x4E,
                0xAC,
                0x3A,
                0x8B,
                0x04,
                0x2E,
                0xE4,
                0xEE,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastSignInStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x92,
                0xB6,
                0x02,
                0x19,
                0x59,
                0x9E,
                0x4A,
                0x8D,
                0x5E,
                0xC9,
                0xBB,
                0x0D,
                0xD3,
                0x37,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastState
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x05,
                0x08,
                0xEE,
                0x99,
                0x80,
                0xDD,
                0x4D,
                0x92,
                0x2E,
                0xC5,
                0x6D,
                0xAC,
                0x58,
                0xAB,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastStreamAudioFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4A,
                0xAB,
                0xEF,
                0xBA,
                0x21,
                0x3F,
                0x45,
                0x8B,
                0xB7,
                0x5E,
                0x93,
                0x8A,
                0x2E,
                0x9A,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastStreamAudioHeader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0xA5,
                0x21,
                0xBF,
                0x78,
                0x6B,
                0x16,
                0x42,
                0x9F,
                0x07,
                0x5A,
                0xFF,
                0x52,
                0x56,
                0xF1,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastStreamReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0xBC,
                0x38,
                0xB3,
                0x64,
                0x33,
                0x60,
                0x44,
                0xB5,
                0xF1,
                0x3C,
                0xC2,
                0x79,
                0x6A,
                0x8A,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastStreamStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0xA7,
                0x08,
                0x51,
                0x08,
                0xD0,
                0x89,
                0x4A,
                0x93,
                0xBE,
                0x58,
                0xAE,
                0xD9,
                0x61,
                0x37,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastStreamVideoFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xCF,
                0x97,
                0x0F,
                0xE4,
                0xC9,
                0x88,
                0x4E,
                0x81,
                0x94,
                0xD8,
                0x14,
                0xCB,
                0xD5,
                0x85,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastStreamVideoHeader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0xBE,
                0x9E,
                0x0B,
                0x32,
                0x7E,
                0x2D,
                0x43,
                0x8C,
                0xA2,
                0x36,
                0xBF,
                0x10,
                0xB9,
                0xF4,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0xAB,
                0xEB,
                0xDE,
                0x5E,
                0xEC,
                0x8F,
                0x4D,
                0xB1,
                0xC0,
                0x5D,
                0xA6,
                0xE8,
                0xC7,
                0x56,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastViewerCountChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x18,
                0xE1,
                0xE6,
                0x01,
                0x54,
                0xDE,
                0x4A,
                0x8B,
                0xD2,
                0xC1,
                0x4E,
                0xCE,
                0xE6,
                0x80,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCapture
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xD4,
                0x49,
                0x97,
                0x9A,
                0xA2,
                0xED,
                0x45,
                0x8F,
                0x29,
                0x22,
                0xD0,
                0x99,
                0x42,
                0xCF,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureAlternateShortcutKeys
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0xE0,
                0xE8,
                0x19,
                0x6C,
                0x23,
                0xF9,
                0x40,
                0xB3,
                0x8F,
                0x9B,
                0x7D,
                0xD6,
                0x5D,
                0x1C,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureAlternateShortcutKeys2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x90,
                0x66,
                0xC3,
                0x17,
                0xDD,
                0xF0,
                0x47,
                0x95,
                0xE5,
                0xCE,
                0x42,
                0x28,
                0x6C,
                0xF3,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureAlternateShortcutKeys3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x44,
                0x81,
                0x7B,
                0x8E,
                0x41,
                0x9C,
                0x46,
                0xA4,
                0x9A,
                0x45,
                0xB5,
                0x97,
                0xC8,
                0x26,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureDurationGeneratedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0x56,
                0xF5,
                0xC1,
                0xA1,
                0xFF,
                0xC9,
                0x44,
                0x97,
                0x5F,
                0x27,
                0xFB,
                0xEB,
                0x55,
                0x3B,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureFileGeneratedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xFB,
                0x89,
                0x41,
                0x5E,
                0x46,
                0xBF,
                0x45,
                0x90,
                0x7F,
                0x16,
                0x5B,
                0x3F,
                0xB2,
                0x37,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x3E,
                0x9E,
                0x7D,
                0x82,
                0x62,
                0x35,
                0x47,
                0x8D,
                0x4E,
                0xAA,
                0x45,
                0xF9,
                0x0F,
                0x67,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureMetadataWriter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x48,
                0xCE,
                0xE0,
                0xAF,
                0x9A,
                0xB4,
                0x46,
                0xAD,
                0x31,
                0x6A,
                0x60,
                0xB4,
                0x41,
                0xC7,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureMicrophoneCaptureStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x24,
                0x4D,
                0x32,
                0xBC,
                0x45,
                0x35,
                0x4C,
                0xBC,
                0x35,
                0xE4,
                0x69,
                0xFC,
                0x7A,
                0x69,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureRecordOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x20,
                0x60,
                0xC6,
                0x38,
                0x15,
                0x5C,
                0x49,
                0x9B,
                0xBB,
                0x2B,
                0xA8,
                0x70,
                0xEC,
                0x58,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureRecordingStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x87,
                0xFC,
                0x24,
                0x05,
                0xE3,
                0x0D,
                0x49,
                0xB4,
                0x15,
                0x6B,
                0x1C,
                0x90,
                0x49,
                0x73,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureServices
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0xC0,
                0xFE,
                0x44,
                0xF5,
                0x34,
                0x18,
                0x4F,
                0xAE,
                0x8C,
                0xB9,
                0x12,
                0x3A,
                0xBB,
                0xFC,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x3A,
                0x68,
                0x14,
                0x07,
                0x88,
                0xD3,
                0x48,
                0x88,
                0x3A,
                0x97,
                0x0E,
                0xE4,
                0x53,
                0x2A,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureSettings2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xCE,
                0xB8,
                0xFC,
                0x6B,
                0xE2,
                0x6F,
                0x47,
                0x9B,
                0x1A,
                0xEC,
                0x34,
                0x2D,
                0x2A,
                0x8F,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureSettings3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x02,
                0x35,
                0xA9,
                0xC2,
                0x88,
                0xD6,
                0x42,
                0xAA,
                0xAA,
                0x40,
                0xFE,
                0xFF,
                0xD7,
                0x5A,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureSettings4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x77,
                0xC2,
                0x07,
                0x81,
                0x1A,
                0x2F,
                0x48,
                0xA2,
                0x44,
                0x04,
                0x9D,
                0x95,
                0xF2,
                0x5B,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureSettings5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x45,
                0x89,
                0x18,
                0xE8,
                0xB0,
                0xA0,
                0x4B,
                0x8F,
                0x13,
                0x3E,
                0xAA,
                0x5F,
                0xA4,
                0x01,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureState
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x43,
                0x13,
                0x73,
                0xEB,
                0xD4,
                0xCE,
                0x44,
                0x95,
                0x38,
                0x46,
                0x5F,
                0x50,
                0x6A,
                0xC4,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0xDD,
                0x22,
                0xF9,
                0x7E,
                0x0A,
                0x74,
                0x4E,
                0x8B,
                0x20,
                0x9C,
                0x1F,
                0x90,
                0x2D,
                0x08,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppCaptureStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x81,
                0xD8,
                0xB2,
                0x6C,
                0x83,
                0xA4,
                0x4D,
                0xAF,
                0xD7,
                0xFA,
                0xCC,
                0x04,
                0x1E,
                0x1C,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICameraCaptureUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x75,
                0x58,
                0x48,
                0x93,
                0x6F,
                0xB4,
                0x4B,
                0xB8,
                0xF3,
                0xE8,
                0x9E,
                0x48,
                0x94,
                0x8C,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICameraCaptureUIPhotoCaptureSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0xBE,
                0xF5,
                0xB9,
                0x72,
                0x34,
                0xA8,
                0x46,
                0x8A,
                0x9E,
                0x04,
                0xCE,
                0x42,
                0xCC,
                0xC9,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICameraCaptureUIVideoCaptureSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x2D,
                0xE9,
                0x64,
                0x8D,
                0xA2,
                0x5A,
                0x42,
                0xB8,
                0x4F,
                0xE5,
                0x68,
                0x33,
                0x5F,
                0xF2,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICameraOptionsUIStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x5E,
                0x0D,
                0x3B,
                0x06,
                0x39,
                0x7D,
                0x4B,
                0x94,
                0x6C,
                0x7B,
                0xDE,
                0x84,
                0x44,
                0x99,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICapturedFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0xDE,
                0xD2,
                0x1D,
                0x1B,
                0x57,
                0xD8,
                0x44,
                0x8E,
                0x80,
                0xA0,
                0x8A,
                0x15,
                0x78,
                0x76,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICapturedFrame2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xA6,
                0x3F,
                0x54,
                0x78,
                0xBD,
                0x66,
                0x48,
                0xAD,
                0xDA,
                0x24,
                0x31,
                0x4B,
                0xC6,
                0x5D,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICapturedFrameControlValues
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x5B,
                0xC6,
                0x90,
                0x0D,
                0x4E,
                0xA4,
                0x4C,
                0x88,
                0x2D,
                0x7A,
                0x14,
                0x4F,
                0xED,
                0x0A,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICapturedFrameControlValues2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x2B,
                0x0B,
                0x50,
                0xD2,
                0x06,
                0xA7,
                0x4A,
                0xA7,
                0xDB,
                0xD3,
                0x7A,
                0xF7,
                0x33,
                0x21,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICapturedFrameWithSoftwareBitmap
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x8B,
                0x8E,
                0xB5,
                0x03,
                0x85,
                0xB5,
                0x49,
                0x9E,
                0x86,
                0x89,
                0x7D,
                0x26,
                0xA3,
                0xFF,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICapturedPhoto
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x7E,
                0xCE,
                0xB0,
                0xCC,
                0xCF,
                0x6C,
                0x4D,
                0x8A,
                0xD1,
                0x08,
                0x69,
                0x20,
                0x8A,
                0xCA,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGameBarServices
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xAD,
                0xBE,
                0x2D,
                0xA6,
                0x50,
                0x9E,
                0x49,
                0x8C,
                0x6C,
                0xD3,
                0x30,
                0xA7,
                0x31,
                0x17,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGameBarServicesCommandEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x26,
                0x42,
                0xA7,
                0x76,
                0xF1,
                0xCF,
                0x4F,
                0x8F,
                0xBB,
                0xCF,
                0x69,
                0x8B,
                0x2E,
                0xB8,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGameBarServicesManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x9C,
                0x4B,
                0x3A,
                0x8B,
                0x7F,
                0x60,
                0x4C,
                0x9D,
                0xBB,
                0x0B,
                0xCD,
                0x26,
                0x2D,
                0xFF,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGameBarServicesManagerGameBarServicesCreatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0xBD,
                0xED,
                0xED,
                0x3E,
                0x14,
                0xA3,
                0x49,
                0xA5,
                0xEA,
                0x0B,
                0x19,
                0x95,
                0xC8,
                0xD4,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGameBarServicesManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0xB6,
                0xC1,
                0x34,
                0x25,
                0xFF,
                0x92,
                0x47,
                0x98,
                0xF2,
                0xD3,
                0x75,
                0x3F,
                0x15,
                0xAC,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGameBarServicesTargetInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x2F,
                0x20,
                0xB4,
                0x11,
                0x16,
                0x05,
                0x4E,
                0xB6,
                0xEF,
                0xDF,
                0xD7,
                0x37,
                0xAE,
                0x33,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLagMediaRecording
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0xBA,
                0xC8,
                0x41,
                0x3F,
                0xFF,
                0xF0,
                0x49,
                0xA4,
                0x77,
                0xF1,
                0x95,
                0xE3,
                0xCE,
                0x51,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLagMediaRecording2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xC7,
                0x69,
                0x63,
                0x44,
                0x56,
                0xE2,
                0x41,
                0x97,
                0xAF,
                0x8E,
                0xF5,
                0x6A,
                0x25,
                0xE2,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLagMediaRecording3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0xAB,
                0x33,
                0x5C,
                0xF7,
                0x48,
                0xDA,
                0x47,
                0xB4,
                0x1E,
                0x90,
                0x88,
                0x0A,
                0x5F,
                0xE0,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLagPhotoCapture
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x51,
                0x72,
                0xA3,
                0x44,
                0x6B,
                0x3D,
                0x47,
                0x8F,
                0x24,
                0xF7,
                0x03,
                0xD6,
                0xC0,
                0xEC,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLagPhotoSequenceCapture
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x46,
                0xC3,
                0x7C,
                0xA9,
                0xB9,
                0x91,
                0x4C,
                0x8F,
                0xFA,
                0x28,
                0x7E,
                0x9C,
                0x66,
                0x86,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCapture
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0xFB,
                0x1A,
                0xC6,
                0x10,
                0xFB,
                0x34,
                0x4A,
                0xAC,
                0x18,
                0xCA,
                0x80,
                0xD9,
                0xC8,
                0xE7,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCapture2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0x82,
                0xC6,
                0x9C,
                0xA1,
                0x7D,
                0x43,
                0x40,
                0xB6,
                0x52,
                0x21,
                0xB8,
                0x87,
                0x8D,
                0xAF,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCapture3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x6F,
                0x13,
                0xD4,
                0x64,
                0x15,
                0x6E,
                0x46,
                0xBC,
                0x0A,
                0xAF,
                0x94,
                0xE0,
                0x2A,
                0xB0,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCapture4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x6F,
                0xCD,
                0xBA,
                0x08,
                0xFB,
                0x47,
                0x49,
                0xAE,
                0xA2,
                0xCE,
                0x14,
                0xEF,
                0xF0,
                0xCE,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCapture5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x7C,
                0x78,
                0xDA,
                0x9B,
                0x3A,
                0x20,
                0x47,
                0xA7,
                0x1E,
                0x97,
                0x90,
                0x0A,
                0x31,
                0x6E,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCapture6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x48,
                0x89,
                0x22,
                0x20,
                0x4B,
                0xB1,
                0x4B,
                0x9F,
                0xD6,
                0xA5,
                0x83,
                0x21,
                0x2A,
                0x10,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCapture7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xF1,
                0x69,
                0x91,
                0x88,
                0x88,
                0x1A,
                0x54,
                0x95,
                0xBC,
                0x24,
                0xE4,
                0xD4,
                0x62,
                0x54,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0x92,
                0x2F,
                0x9D,
                0x88,
                0xA5,
                0xC6,
                0x43,
                0x89,
                0xD6,
                0x5A,
                0xD3,
                0x22,
                0xAF,
                0x00,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureFailedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xE3,
                0xFD,
                0x80,
                0xC4,
                0x54,
                0xC0,
                0x42,
                0x8D,
                0x19,
                0xCE,
                0xA1,
                0xA8,
                0x7C,
                0xA1,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureFocusChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xBC,
                0xE1,
                0x81,
                0x77,
                0x22,
                0x3E,
                0x49,
                0xAB,
                0xEE,
                0xD3,
                0xF4,
                0x4F,
                0xF9,
                0x8C,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureInitializationSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0xBA,
                0x82,
                0x97,
                0x65,
                0xEA,
                0x00,
                0x49,
                0x93,
                0x56,
                0x8C,
                0xA8,
                0x87,
                0x72,
                0x68,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureInitializationSettings2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x06,
                0x4E,
                0x40,
                0xDC,
                0xC9,
                0xE9,
                0x43,
                0xAE,
                0xE4,
                0xE6,
                0xBF,
                0x1B,
                0x57,
                0xB4,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureInitializationSettings3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x51,
                0x60,
                0x41,
                0x48,
                0xBE,
                0x30,
                0x47,
                0x81,
                0x04,
                0x0C,
                0xF6,
                0xE9,
                0xE9,
                0x79,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureInitializationSettings4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0xA5,
                0x02,
                0xF5,
                0xB7,
                0x4C,
                0x28,
                0x4D,
                0x95,
                0xED,
                0x4F,
                0x9F,
                0x01,
                0x2E,
                0x05,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureInitializationSettings5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0xE3,
                0xA2,
                0xD5,
                0x26,
                0x26,
                0x94,
                0x4E,
                0xB7,
                0xB3,
                0x53,
                0x08,
                0xA0,
                0xF6,
                0x4B,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureInitializationSettings6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x6B,
                0xE2,
                0xB2,
                0xB1,
                0x3D,
                0x33,
                0x4D,
                0xAB,
                0x63,
                0x0F,
                0xFA,
                0x09,
                0x05,
                0x65,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureInitializationSettings7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x69,
                0x54,
                0x41,
                0x8A,
                0xF5,
                0x82,
                0x5D,
                0x9E,
                0xF4,
                0xED,
                0x57,
                0x2F,
                0xB5,
                0xE3,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCapturePauseResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x7C,
                0xC4,
                0xAE,
                0x77,
                0x44,
                0x04,
                0x4B,
                0xA0,
                0x6F,
                0x2C,
                0x1C,
                0x51,
                0x82,
                0xFE,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureRelativePanelWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x65,
                0x89,
                0x7D,
                0xBE,
                0x04,
                0x89,
                0x5B,
                0xB3,
                0x0E,
                0xBD,
                0x34,
                0xA9,
                0xF1,
                0x2D,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0xAA,
                0x83,
                0x1D,
                0x45,
                0x6D,
                0x77,
                0x44,
                0x8D,
                0xC4,
                0xAC,
                0x5B,
                0xC0,
                0x1C,
                0x40,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureSettings2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x7C,
                0x9E,
                0x6F,
                0x9F,
                0xFA,
                0x13,
                0x4B,
                0x9C,
                0xBE,
                0x5A,
                0xB9,
                0x4F,
                0x1F,
                0x34,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureSettings3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0x67,
                0x3C,
                0x30,
                0x58,
                0x80,
                0x1B,
                0x4B,
                0xB8,
                0x77,
                0x8C,
                0x2E,
                0xF3,
                0x52,
                0x84,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x81,
                0xEF,
                0xAC,
                0xED,
                0x99,
                0x45,
                0x46,
                0x96,
                0x5E,
                0x19,
                0x25,
                0xCF,
                0xC6,
                0x38,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureStopResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0x6A,
                0xDB,
                0xF9,
                0x92,
                0xA0,
                0xD1,
                0x4A,
                0x97,
                0xD4,
                0xF2,
                0x01,
                0xF9,
                0xD0,
                0x82,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureVideoPreview
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x70,
                0x72,
                0x27,
                0x9E,
                0x54,
                0x7F,
                0x44,
                0xA2,
                0x0A,
                0x4F,
                0x03,
                0xC4,
                0x79,
                0xD8,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureVideoProfile
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x73,
                0xA0,
                0x21,
                0xEE,
                0xA3,
                0xCF,
                0x4E,
                0x9E,
                0xF6,
                0x50,
                0xB0,
                0xBC,
                0x4E,
                0x13,
                0x05,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureVideoProfile2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xC9,
                0xDD,
                0x97,
                0xCE,
                0x94,
                0x8F,
                0x46,
                0x93,
                0x16,
                0xFC,
                0x5B,
                0xC2,
                0x63,
                0x8F,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureVideoProfileMediaDescription
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0xAF,
                0x12,
                0x80,
                0x91,
                0xB6,
                0xFF,
                0x49,
                0x83,
                0xF2,
                0xC1,
                0xE7,
                0x6E,
                0xAA,
                0xEA,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaCaptureVideoProfileMediaDescription2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0xEF,
                0xA6,
                0xC6,
                0x2D,
                0x32,
                0x3A,
                0x41,
                0xB8,
                0x5A,
                0x68,
                0xA8,
                0x8E,
                0x02,
                0xF4,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOptionalReferencePhotoCapturedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x88,
                0x0F,
                0x47,
                0x6D,
                0x1E,
                0x51,
                0x40,
                0x9C,
                0x8B,
                0xF1,
                0xD8,
                0x5A,
                0xF0,
                0x47,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhotoCapturedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0xFB,
                0x3B,
                0x37,
                0x4E,
                0x98,
                0xF0,
                0x4F,
                0xBF,
                0x85,
                0x1C,
                0x00,
                0xAA,
                0xBC,
                0x5A,
                0x45,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhotoConfirmationCapturedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x36,
                0x47,
                0xAB,
                0x8A,
                0xC2,
                0x27,
                0x48,
                0x8F,
                0x8D,
                0x36,
                0x36,
                0xD3,
                0xBE,
                0xB5,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoStreamConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x0A,
                0x77,
                0xD8,
                0x90,
                0x43,
                0x5E,
                0x4B,
                0xAD,
                0x3E,
                0x0F,
                0x8A,
                0xF0,
                0x96,
                0x34,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
