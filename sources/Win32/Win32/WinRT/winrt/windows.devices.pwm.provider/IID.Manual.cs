// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.pwm.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPwmControllerProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0x59,
                0x00,
                0x13,
                0xE3,
                0xE2,
                0xA4,
                0x40,
                0xB7,
                0xD9,
                0x48,
                0xDF,
                0xF0,
                0x37,
                0x7A,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPwmProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x12,
                0x30,
                0xA3,
                0xF1,
                0x52,
                0xB0,
                0x47,
                0x93,
                0x49,
                0x66,
                0xBA,
                0x43,
                0xD2,
                0x59,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
