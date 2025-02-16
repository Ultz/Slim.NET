// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ICallAnswerEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x96,
                0x78,
                0xFD,
                0xD7,
                0x2D,
                0x8C,
                0x4C,
                0xB2,
                0xBD,
                0x95,
                0xD1,
                0x7A,
                0x5B,
                0xB7,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICallRejectEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0xFA,
                0x47,
                0xDA,
                0xD4,
                0x13,
                0x92,
                0x4D,
                0xA1,
                0xC2,
                0xB7,
                0x78,
                0x11,
                0xEE,
                0x37,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICallStateChangeEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x34,
                0xB2,
                0xEA,
                0xF5,
                0x66,
                0xF9,
                0x47,
                0x9F,
                0xB5,
                0x45,
                0x9C,
                0x51,
                0x98,
                0xC7,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILockScreenCallEndCallDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xED,
                0xD7,
                0x2D,
                0xED,
                0x98,
                0x41,
                0x40,
                0x96,
                0x32,
                0x50,
                0xFF,
                0x81,
                0x2B,
                0x77,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILockScreenCallEndRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0xA3,
                0x90,
                0x81,
                0x27,
                0x6F,
                0xE9,
                0x46,
                0xAE,
                0xB6,
                0xC0,
                0xAE,
                0x83,
                0xE4,
                0x7D,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILockScreenCallUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0xFD,
                0x96,
                0xC5,
                0xC9,
                0x73,
                0x14,
                0x4A,
                0xB0,
                0x21,
                0xEC,
                0x1C,
                0x50,
                0xA3,
                0xB7,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMuteChangeEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xE1,
                0x85,
                0x85,
                0x41,
                0x0C,
                0x2C,
                0x43,
                0x81,
                0x4D,
                0xC5,
                0xF1,
                0xFD,
                0xF5,
                0x30,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCall
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xD0,
                0x4E,
                0xC1,
                0x7D,
                0xC1,
                0xD2,
                0x59,
                0x96,
                0x28,
                0x66,
                0xE5,
                0x45,
                0xB6,
                0xCD,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallBlockingStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0x6F,
                0x64,
                0x19,
                0x79,
                0x2B,
                0xF1,
                0x26,
                0xA4,
                0x6F,
                0x69,
                0x4B,
                0xE0,
                0x43,
                0xF3,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallHistoryEntry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xE1,
                0xB0,
                0xFA,
                0xA4,
                0x32,
                0x85,
                0x4B,
                0x83,
                0xD1,
                0xF9,
                0x0D,
                0x8C,
                0x23,
                0xA8,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallHistoryEntryAddress
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x59,
                0xF1,
                0x30,
                0x55,
                0x39,
                0x42,
                0x40,
                0x84,
                0xE6,
                0x66,
                0xEE,
                0xBF,
                0x82,
                0xE6,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallHistoryEntryAddressFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0xAD,
                0x0F,
                0xFB,
                0xF0,
                0xC7,
                0xB6,
                0x4B,
                0x9F,
                0x6B,
                0xBA,
                0x5D,
                0x73,
                0x20,
                0x9A,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallHistoryEntryQueryOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0xE1,
                0x5F,
                0x9C,
                0xED,
                0x8B,
                0xCA,
                0x40,
                0xB0,
                0x6E,
                0xC4,
                0xCA,
                0x8E,
                0xAE,
                0x5C,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallHistoryEntryReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0xE4,
                0xEC,
                0x61,
                0x86,
                0x8D,
                0x9F,
                0x47,
                0x84,
                0x04,
                0xA9,
                0x84,
                0x69,
                0x20,
                0xFE,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallHistoryManagerForUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0xC5,
                0x25,
                0xD9,
                0x5F,
                0xF5,
                0x53,
                0x43,
                0x9D,
                0xB4,
                0x02,
                0x05,
                0xA5,
                0x26,
                0x5A,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallHistoryManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0xDA,
                0xA6,
                0xF5,
                0x1F,
                0xB3,
                0x45,
                0x4F,
                0xAC,
                0x8E,
                0x1B,
                0x08,
                0x89,
                0x3C,
                0x1B,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallHistoryManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x74,
                0xD4,
                0xEF,
                0xDB,
                0xA2,
                0x88,
                0x41,
                0x9E,
                0x92,
                0xBC,
                0x3C,
                0xFA,
                0x68,
                0x13,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallHistoryStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x7D,
                0x90,
                0x2F,
                0x0E,
                0xB4,
                0x2B,
                0x42,
                0x85,
                0x45,
                0xCB,
                0x19,
                0x10,
                0xA6,
                0x1C,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x25,
                0xB4,
                0x22,
                0x4D,
                0x3E,
                0xC6,
                0x5D,
                0x89,
                0xC2,
                0x46,
                0x9F,
                0xE5,
                0xFF,
                0xC1,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xAC,
                0xED,
                0x60,
                0xA6,
                0x78,
                0x72,
                0x48,
                0xA3,
                0xEF,
                0x98,
                0x32,
                0x5E,
                0xC8,
                0xB8,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0xC8,
                0xE3,
                0xC7,
                0x70,
                0x23,
                0x1C,
                0x43,
                0x98,
                0xFD,
                0x43,
                0xBE,
                0x5F,
                0x03,
                0x08,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xEE,
                0x18,
                0x22,
                0x0B,
                0xF6,
                0xE7,
                0x53,
                0xBA,
                0x13,
                0x5A,
                0xEA,
                0xFB,
                0xC2,
                0x29,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x07,
                0x61,
                0x5F,
                0xA6,
                0x18,
                0x73,
                0x41,
                0x86,
                0xD1,
                0x28,
                0xBE,
                0x9D,
                0xC6,
                0x2D,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallVideoCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x27,
                0x38,
                0x02,
                0x6A,
                0xB1,
                0xDB,
                0x4F,
                0xBE,
                0x3B,
                0xC4,
                0x24,
                0x0E,
                0x13,
                0xAD,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallVideoCapabilitiesManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x4B,
                0xC6,
                0xF3,
                0x0B,
                0xF0,
                0x1C,
                0x4A,
                0xA0,
                0xC6,
                0xEE,
                0x19,
                0x10,
                0x74,
                0x9C,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallsResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xD3,
                0xFA,
                0x1B,
                0xCF,
                0x57,
                0xDD,
                0x57,
                0x98,
                0x6D,
                0xB0,
                0x57,
                0xC9,
                0x1E,
                0xAC,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneDialOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0xC4,
                0x39,
                0xB6,
                0x6F,
                0xF0,
                0xCB,
                0x36,
                0xA8,
                0x63,
                0x82,
                0x37,
                0x42,
                0xB5,
                0xF2,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLine
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x6F,
                0xC6,
                0x27,
                0x69,
                0x6A,
                0xCA,
                0x34,
                0xA2,
                0xBA,
                0x65,
                0x30,
                0x25,
                0x30,
                0xC3,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLine2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xF5,
                0x67,
                0x01,
                0x44,
                0x53,
                0x64,
                0x5D,
                0x8A,
                0xF3,
                0xA3,
                0x1A,
                0x95,
                0x0E,
                0x91,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLine3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x3C,
                0xE3,
                0xE2,
                0x06,
                0x24,
                0xF3,
                0x57,
                0x82,
                0x6A,
                0xE5,
                0xA5,
                0xF4,
                0x0D,
                0x6F,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLineCellularDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x01,
                0x26,
                0x19,
                0x7C,
                0x14,
                0x69,
                0x47,
                0xB6,
                0x73,
                0x98,
                0xA5,
                0xEC,
                0x84,
                0x26,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLineConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0x58,
                0x26,
                0xFE,
                0x4F,
                0xF6,
                0x12,
                0x43,
                0xB2,
                0xA8,
                0x4E,
                0x25,
                0x77,
                0x21,
                0xAA,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLineDialResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0xA3,
                0x25,
                0xE8,
                0x7F,
                0x5C,
                0x6F,
                0x54,
                0xB9,
                0x18,
                0x3A,
                0xD2,
                0xFE,
                0x70,
                0xFB,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLineStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x5F,
                0x8B,
                0xF3,
                0xB0,
                0xCE,
                0x4F,
                0x40,
                0xBC,
                0xF2,
                0xBA,
                0x9F,
                0x69,
                0x7D,
                0x8A,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLineTransportDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xF8,
                0xA8,
                0xEF,
                0xFA,
                0xCF,
                0xF4,
                0x59,
                0x97,
                0xE4,
                0x74,
                0x70,
                0x5B,
                0x7D,
                0xC4,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLineTransportDevice2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x85,
                0xC8,
                0x64,
                0xF4,
                0xEC,
                0x61,
                0x57,
                0x8C,
                0x04,
                0x3C,
                0x24,
                0x8C,
                0xE6,
                0x16,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLineTransportDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x21,
                0x31,
                0x0F,
                0x09,
                0xD6,
                0xA1,
                0x51,
                0x96,
                0xF3,
                0xFB,
                0x00,
                0xD1,
                0x81,
                0x92,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLineWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0xCD,
                0x45,
                0x8A,
                0x23,
                0x63,
                0xE0,
                0x44,
                0xA6,
                0xF6,
                0x9F,
                0x21,
                0xF6,
                0x4D,
                0xC9,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLineWatcherEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x75,
                0x7C,
                0xD0,
                0x12,
                0x9E,
                0x37,
                0x4A,
                0x82,
                0xB7,
                0xAD,
                0x53,
                0x5D,
                0xAD,
                0x6A,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneVoicemail
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x77,
                0xCE,
                0xC9,
                0x9F,
                0x6E,
                0x8B,
                0x3A,
                0xB7,
                0x27,
                0x6E,
                0x0C,
                0xF6,
                0x99,
                0x82,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoipCallCoordinator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x8B,
                0x11,
                0x4F,
                0xEF,
                0xE8,
                0x34,
                0x44,
                0x9C,
                0x5F,
                0xA8,
                0xD8,
                0x93,
                0xFA,
                0xFE,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoipCallCoordinator2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0xA9,
                0xB4,
                0xBE,
                0x04,
                0xC7,
                0x34,
                0x42,
                0x89,
                0xCE,
                0xE8,
                0x8C,
                0xC0,
                0xD2,
                0x8F,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoipCallCoordinator3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x0C,
                0x8D,
                0x33,
                0x55,
                0x9B,
                0x21,
                0x40,
                0x87,
                0xCA,
                0xE6,
                0x4B,
                0x9B,
                0xD6,
                0x66,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoipCallCoordinator4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x72,
                0x73,
                0x83,
                0x11,
                0x93,
                0x8F,
                0x46,
                0xBB,
                0x49,
                0x47,
                0xE0,
                0xDF,
                0xB5,
                0xD9,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoipCallCoordinatorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x1F,
                0x5D,
                0x7F,
                0x4A,
                0xE0,
                0x10,
                0x4D,
                0xB3,
                0x1A,
                0xA5,
                0x5C,
                0x92,
                0x2C,
                0xC2,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoipPhoneCall
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0xF1,
                0xF1,
                0x6C,
                0x94,
                0x77,
                0x5A,
                0x4A,
                0x8C,
                0x68,
                0xAE,
                0x87,
                0x94,
                0x7A,
                0x69,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoipPhoneCall2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x46,
                0x1B,
                0x74,
                0x5F,
                0x24,
                0xF3,
                0x41,
                0x93,
                0x99,
                0x31,
                0x41,
                0xD2,
                0x5B,
                0x52,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoipPhoneCall3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x15,
                0x89,
                0x0D,
                0x58,
                0xE2,
                0xA9,
                0x4A,
                0x90,
                0x7A,
                0x1A,
                0xA4,
                0x13,
                0xC2,
                0x55,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
