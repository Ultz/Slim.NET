// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ISmsDeviceStatusChangedEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0x11,
                0x2B,
                0x98,
                0xD7,
                0x3D,
                0x18,
                0x46,
                0xAF,
                0x89,
                0x0C,
                0x27,
                0x2D,
                0x5D,
                0x06,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsMessageReceivedEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0xD4,
                0x7A,
                0x0B,
                0x2D,
                0xEC,
                0xCE,
                0x47,
                0xA2,
                0x53,
                0x73,
                0x2B,
                0xEE,
                0xEB,
                0xCA,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsAppMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x84,
                0xBB,
                0xE8,
                0xA0,
                0xD3,
                0x0A,
                0x4A,
                0x86,
                0xD7,
                0x29,
                0x10,
                0x33,
                0xA8,
                0xCF,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsBinaryMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0xE8,
                0xF4,
                0x5B,
                0x53,
                0x3B,
                0x6E,
                0x4C,
                0xB6,
                0x1A,
                0xD8,
                0x6A,
                0x63,
                0x75,
                0x56,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsBroadcastMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0xBB,
                0xAE,
                0x75,
                0xB7,
                0xE4,
                0x74,
                0x48,
                0xA0,
                0x9C,
                0x29,
                0x56,
                0xE5,
                0x92,
                0xF9,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x91,
                0x17,
                0x09,
                0x2B,
                0x87,
                0xEC,
                0x4E,
                0x9C,
                0x72,
                0xAB,
                0x11,
                0x62,
                0x7B,
                0x34,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsDevice2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x5C,
                0x8A,
                0xBD,
                0x22,
                0xE5,
                0xCB,
                0x46,
                0xB8,
                0xD5,
                0x9E,
                0xAD,
                0x30,
                0xFB,
                0x6C,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsDevice2Statics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x83,
                0xC7,
                0x65,
                0x31,
                0x10,
                0x1E,
                0x49,
                0x8F,
                0xB6,
                0xEF,
                0x99,
                0x91,
                0xAF,
                0xE3,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsDeviceMessageStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xF2,
                0x89,
                0x98,
                0x88,
                0xF1,
                0x27,
                0x44,
                0x8D,
                0x54,
                0xCE,
                0x0C,
                0x24,
                0x23,
                0xC5,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x07,
                0x8D,
                0xF8,
                0x15,
                0xD8,
                0xD1,
                0x4D,
                0xA2,
                0x34,
                0x45,
                0x20,
                0xCE,
                0x46,
                0x04,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsDeviceStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x1C,
                0xA1,
                0x2C,
                0x73,
                0x08,
                0xAF,
                0x4C,
                0x8A,
                0x7D,
                0xBD,
                0x47,
                0x1E,
                0x85,
                0x86,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsFilterRule
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0x2F,
                0xE3,
                0x40,
                0x49,
                0xB0,
                0xBC,
                0x4F,
                0xAF,
                0xE9,
                0xE2,
                0xA6,
                0x10,
                0xEF,
                0xF5,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsFilterRuleFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x65,
                0xC3,
                0x00,
                0x96,
                0x62,
                0x29,
                0x4F,
                0x9A,
                0xAD,
                0x89,
                0x20,
                0xCE,
                0xBA,
                0x3C,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsFilterRules
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0xEA,
                0x47,
                0x4E,
                0xCD,
                0x79,
                0x81,
                0x48,
                0x98,
                0x94,
                0x55,
                0xA4,
                0x13,
                0x5B,
                0x23,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsFilterRulesFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x24,
                0x99,
                0xA0,
                0x2E,
                0x6E,
                0x30,
                0x45,
                0x9F,
                0xDE,
                0x46,
                0x5D,
                0x02,
                0xEE,
                0xD0,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x5E,
                0x3C,
                0xED,
                0x84,
                0x69,
                0x07,
                0x4B,
                0x81,
                0x1D,
                0x8D,
                0x59,
                0x06,
                0xED,
                0x3C,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsMessageBase
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xFE,
                0xF0,
                0x2C,
                0x50,
                0xFE,
                0xC6,
                0x4F,
                0xAA,
                0x88,
                0x4C,
                0xCF,
                0xE2,
                0x7A,
                0x29,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsMessageReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0x0A,
                0xE8,
                0x08,
                0xE5,
                0xB8,
                0xC1,
                0x41,
                0xA3,
                0xD8,
                0xD3,
                0xAB,
                0xFA,
                0xE2,
                0x26,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsMessageReceivedTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0xCB,
                0xCF,
                0x2B,
                0x57,
                0x26,
                0x28,
                0x41,
                0xAD,
                0x5F,
                0xE3,
                0x87,
                0x71,
                0x32,
                0xBD,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsMessageRegistration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x50,
                0x20,
                0x17,
                0x4F,
                0xF3,
                0x6B,
                0x44,
                0x83,
                0xB3,
                0x0F,
                0xF1,
                0x99,
                0x23,
                0xB4,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsMessageRegistrationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x54,
                0xA0,
                0x63,
                0x98,
                0x28,
                0x78,
                0x47,
                0xA0,
                0x3C,
                0x6F,
                0x99,
                0x49,
                0x07,
                0xD6,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsReceivedEventDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x0F,
                0xB5,
                0x5B,
                0x6D,
                0xE4,
                0x82,
                0x4C,
                0x84,
                0x7D,
                0x5A,
                0x03,
                0x04,
                0xC1,
                0xD5,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsReceivedEventDetails2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x5C,
                0xE0,
                0x40,
                0xB4,
                0xA7,
                0x71,
                0x47,
                0x9A,
                0xE7,
                0x0B,
                0x5F,
                0xFB,
                0x12,
                0xC0,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsSendMessageResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x9A,
                0x13,
                0xDB,
                0xC9,
                0x78,
                0xEB,
                0x4F,
                0x96,
                0x22,
                0x45,
                0x23,
                0x28,
                0x08,
                0x8D,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsStatusMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x83,
                0xD2,
                0xE6,
                0x0B,
                0xB7,
                0x77,
                0x46,
                0x93,
                0x79,
                0xC9,
                0x78,
                0x3F,
                0xDF,
                0xF8,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsTextMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x90,
                0x1C,
                0xD6,
                0x95,
                0xA4,
                0x7F,
                0x48,
                0x9A,
                0x6F,
                0x97,
                0x15,
                0x48,
                0xC5,
                0xBC,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsTextMessage2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0xD8,
                0xA0,
                0x22,
                0x55,
                0x45,
                0x55,
                0x47,
                0xB5,
                0xA1,
                0xE7,
                0xFD,
                0x84,
                0x95,
                0x5F,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsTextMessageStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0xC5,
                0x68,
                0x7F,
                0xCC,
                0x3C,
                0xA3,
                0x47,
                0x8C,
                0x55,
                0x38,
                0x0D,
                0x3B,
                0x01,
                0x08,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsVoicemailMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0xA0,
                0x1A,
                0x27,
                0xB1,
                0x95,
                0xFF,
                0x44,
                0xBC,
                0xB8,
                0xB8,
                0xFD,
                0xD7,
                0xE0,
                0x8B,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsWapMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x77,
                0x93,
                0xCD,
                0x55,
                0x7A,
                0x3B,
                0x4D,
                0x90,
                0x21,
                0xF2,
                0x2E,
                0x02,
                0x2D,
                0x09,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
