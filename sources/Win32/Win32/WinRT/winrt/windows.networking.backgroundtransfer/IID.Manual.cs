// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBackgroundDownloader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x93,
                0xC7,
                0xC1,
                0x49,
                0x66,
                0x1D,
                0x4B,
                0xA8,
                0x26,
                0xA4,
                0xB3,
                0xDD,
                0x23,
                0x4D,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundDownloader2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x58,
                0x4A,
                0xA9,
                0x8D,
                0x34,
                0x35,
                0x4A,
                0x89,
                0x0E,
                0x8A,
                0x1E,
                0xF3,
                0x79,
                0x84,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundDownloader3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x8C,
                0x1A,
                0xD1,
                0xE8,
                0x86,
                0xE2,
                0x48,
                0xB6,
                0x15,
                0x69,
                0x76,
                0xAA,
                0xBF,
                0x86,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundDownloaderFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x6C,
                0x83,
                0x26,
                0x9E,
                0xD8,
                0xF4,
                0x46,
                0xA2,
                0x9A,
                0x4F,
                0x4D,
                0x4F,
                0x14,
                0x41,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundDownloaderStaticMethods
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x5A,
                0xA6,
                0x52,
                0x4E,
                0xC6,
                0x6C,
                0x42,
                0x99,
                0x19,
                0x54,
                0x0D,
                0x0D,
                0x21,
                0xA6,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundDownloaderStaticMethods2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x13,
                0xAA,
                0x2F,
                0xD4,
                0x1A,
                0xA5,
                0x4C,
                0xB2,
                0xCD,
                0x08,
                0xDB,
                0xF0,
                0x74,
                0x6A,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundDownloaderUserConsent
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xE9,
                0x14,
                0x5D,
                0x66,
                0x92,
                0x08,
                0x48,
                0xBD,
                0x71,
                0x59,
                0x25,
                0xF2,
                0xA3,
                0x13,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferBase
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xA2,
                0x9D,
                0x2A,
                0x69,
                0xC7,
                0x8C,
                0x45,
                0xAF,
                0xE8,
                0xFE,
                0xB8,
                0xD4,
                0xD3,
                0xB2,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferCompletionGroup
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x02,
                0x93,
                0x2D,
                0x6B,
                0x98,
                0x4D,
                0x57,
                0x79,
                0x50,
                0x0A,
                0xDD,
                0x47,
                0xF5,
                0xD7,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferCompletionGroupTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0xE2,
                0x6B,
                0x7B,
                0x47,
                0x6E,
                0x36,
                0x51,
                0x7F,
                0xCB,
                0xFA,
                0x43,
                0x89,
                0xF4,
                0x6F,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferContentPart
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x56,
                0xE1,
                0xE8,
                0xD1,
                0xD7,
                0xD8,
                0x4E,
                0x83,
                0x8E,
                0x67,
                0x4A,
                0xC2,
                0x17,
                0xAC,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferContentPartFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x98,
                0xEF,
                0x90,
                0x01,
                0x7A,
                0x0B,
                0x4A,
                0x9F,
                0x80,
                0xA0,
                0xB0,
                0xBB,
                0x37,
                0x0F,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferErrorStaticMethods
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x3B,
                0xD3,
                0xAA,
                0x92,
                0x11,
                0xF4,
                0x4B,
                0x8B,
                0x68,
                0x39,
                0xC5,
                0xAD,
                0xD2,
                0x44,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferGroup
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0xE3,
                0xC3,
                0xD8,
                0x59,
                0x64,
                0x40,
                0x45,
                0x85,
                0xEB,
                0xAA,
                0xA1,
                0xC8,
                0x90,
                0x36,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferGroupStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x50,
                0xEC,
                0x02,
                0x18,
                0x7D,
                0x5B,
                0x49,
                0xAA,
                0x22,
                0x32,
                0xA9,
                0x7D,
                0x45,
                0xD3,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x68,
                0xD0,
                0xDE,
                0xCA,
                0x90,
                0xFB,
                0x44,
                0x8F,
                0xB1,
                0x12,
                0x41,
                0x54,
                0xC0,
                0xD5,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferOperationPriority
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x43,
                0x85,
                0x04,
                0x54,
                0x52,
                0x3A,
                0x4B,
                0x91,
                0x5E,
                0x0A,
                0xA4,
                0x92,
                0x75,
                0xC0,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTransferRangesDownloadedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x74,
                0xBC,
                0x3E,
                0x48,
                0xBF,
                0x88,
                0x4A,
                0x92,
                0x48,
                0xB0,
                0xC1,
                0x65,
                0x18,
                0x4F,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundUploader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0xC9,
                0x95,
                0xC5,
                0xAD,
                0xCE,
                0x5B,
                0x46,
                0x88,
                0x01,
                0xC5,
                0x5A,
                0xC9,
                0x0A,
                0x01,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundUploader2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x12,
                0x06,
                0x8E,
                0x34,
                0x0C,
                0x63,
                0x44,
                0x80,
                0x7F,
                0x19,
                0x8A,
                0x1B,
                0x8B,
                0xD4,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundUploader3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x94,
                0x5E,
                0xB9,
                0xF0,
                0x5B,
                0x3A,
                0x4B,
                0x8C,
                0x47,
                0x2C,
                0x61,
                0x99,
                0xA8,
                0x54,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundUploaderFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x03,
                0x62,
                0x73,
                0xE7,
                0x10,
                0xA0,
                0x48,
                0xAC,
                0x3C,
                0x1A,
                0xC7,
                0x10,
                0x95,
                0xEC,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundUploaderStaticMethods
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x5C,
                0x87,
                0xF2,
                0x05,
                0x9B,
                0x41,
                0x47,
                0x91,
                0x21,
                0x74,
                0x0A,
                0x83,
                0xE2,
                0x47,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundUploaderStaticMethods2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xAC,
                0x19,
                0xE9,
                0x08,
                0xEA,
                0xF0,
                0x42,
                0xA2,
                0xAC,
                0x07,
                0xE4,
                0x67,
                0x54,
                0x90,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundUploaderUserConsent
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x84,
                0xB3,
                0x3B,
                0x60,
                0x07,
                0x1D,
                0x46,
                0x90,
                0x7F,
                0x51,
                0x38,
                0xF8,
                0x4D,
                0x44,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContentPrefetcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xF7,
                0xD6,
                0xA8,
                0xC1,
                0x7D,
                0xD9,
                0x4C,
                0x88,
                0x10,
                0x2A,
                0x6A,
                0xA9,
                0x41,
                0x7E,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContentPrefetcherTime
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xFD,
                0x61,
                0xE3,
                0x2A,
                0x13,
                0xDE,
                0x4F,
                0xA7,
                0xCC,
                0xFC,
                0xB0,
                0xE6,
                0x65,
                0x23,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDownloadOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xEB,
                0x87,
                0xBD,
                0x14,
                0x57,
                0x09,
                0x4E,
                0xBA,
                0x68,
                0xBE,
                0xF7,
                0x39,
                0x03,
                0xB0,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDownloadOperation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xED,
                0xCC,
                0xA3,
                0x9C,
                0x8F,
                0x53,
                0x43,
                0x9C,
                0xD4,
                0x29,
                0x0D,
                0xEE,
                0x38,
                0x7C,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDownloadOperation3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x35,
                0x27,
                0x50,
                0x5E,
                0x7D,
                0xDC,
                0x4A,
                0xB8,
                0xD3,
                0xDF,
                0x5C,
                0x60,
                0x31,
                0xB9,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDownloadOperation4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xAE,
                0xDA,
                0x0C,
                0xEF,
                0x8C,
                0x4A,
                0x40,
                0x96,
                0x6D,
                0xF0,
                0x58,
                0x40,
                0x0B,
                0xED,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDownloadOperation5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0xA8,
                0x99,
                0xA6,
                0x90,
                0x55,
                0x3A,
                0x46,
                0xB8,
                0xD6,
                0x1E,
                0x49,
                0x1A,
                0x27,
                0x60,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IResponseInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x9A,
                0xBB,
                0xF8,
                0x13,
                0xF7,
                0x92,
                0x47,
                0x8B,
                0x68,
                0xD9,
                0xD2,
                0x97,
                0xF9,
                0x1D,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUnconstrainedTransferRequestResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0xB8,
                0x24,
                0x4C,
                0x44,
                0xD9,
                0x12,
                0x41,
                0xA9,
                0x8E,
                0x6A,
                0x69,
                0x52,
                0x2B,
                0x7E,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUploadOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x24,
                0x56,
                0x3E,
                0x89,
                0x73,
                0x4C,
                0x43,
                0x8B,
                0x35,
                0x42,
                0x7F,
                0xD3,
                0x6B,
                0xBD,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUploadOperation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x89,
                0x61,
                0x55,
                0x74,
                0x27,
                0xF6,
                0x4D,
                0x9F,
                0xA5,
                0x20,
                0x9F,
                0x2B,
                0xFB,
                0x12,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUploadOperation3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x2C,
                0xC9,
                0x42,
                0x39,
                0xDE,
                0x46,
                0x45,
                0xBC,
                0x62,
                0x37,
                0x74,
                0xB4,
                0x29,
                0x4D,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUploadOperation4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0xEF,
                0xED,
                0x50,
                0xC5,
                0xFA,
                0xEE,
                0x41,
                0xB0,
                0x30,
                0xDC,
                0x77,
                0xCA,
                0xEE,
                0x9F,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
