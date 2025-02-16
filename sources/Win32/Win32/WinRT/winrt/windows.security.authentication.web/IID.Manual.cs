// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IWebAuthenticationBrokerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0x9F,
                0x14,
                0x2F,
                0x73,
                0xE6,
                0xB5,
                0x40,
                0xBC,
                0x22,
                0x20,
                0x1A,
                0x68,
                0x64,
                0xA3,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAuthenticationBrokerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xFB,
                0xCD,
                0x73,
                0xE7,
                0x14,
                0xDA,
                0x41,
                0xA9,
                0x71,
                0xAA,
                0xF4,
                0x41,
                0x0B,
                0x62,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAuthenticationResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x2B,
                0x00,
                0x64,
                0xE9,
                0xED,
                0x0A,
                0x47,
                0xA5,
                0xCD,
                0x03,
                0x23,
                0xFA,
                0xF6,
                0xE2,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
