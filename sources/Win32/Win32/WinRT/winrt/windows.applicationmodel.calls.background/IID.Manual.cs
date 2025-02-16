// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPhoneCallBlockedTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x90,
                0xA6,
                0xA4,
                0xC1,
                0xE4,
                0x7F,
                0x42,
                0x86,
                0x4E,
                0xE4,
                0x70,
                0x47,
                0x7D,
                0xDB,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallOriginDataRequestTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0x5B,
                0x9B,
                0x6E,
                0x4B,
                0xC5,
                0x82,
                0x4E,
                0x4C,
                0xC9,
                0xE3,
                0x29,
                0xA4,
                0x18,
                0x45,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneIncomingCallDismissedTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x02,
                0xD3,
                0xBA,
                0xB6,
                0x83,
                0x32,
                0x57,
                0x9C,
                0x38,
                0x0C,
                0x20,
                0x65,
                0x46,
                0x19,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneIncomingCallNotificationTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x60,
                0x0E,
                0x2B,
                0x32,
                0x9B,
                0x42,
                0x5D,
                0x82,
                0x22,
                0xD2,
                0x81,
                0x2E,
                0x39,
                0xFB,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneLineChangedTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x21,
                0xD3,
                0xC6,
                0x1D,
                0xD1,
                0xD8,
                0x40,
                0xB2,
                0xB7,
                0xE4,
                0x0A,
                0x01,
                0xD6,
                0x62,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneNewVoicemailMessageTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0xC0,
                0xA8,
                0x13,
                0x31,
                0xB8,
                0xD3,
                0x48,
                0x8B,
                0xA9,
                0x8D,
                0x22,
                0xA6,
                0x58,
                0x0D,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
