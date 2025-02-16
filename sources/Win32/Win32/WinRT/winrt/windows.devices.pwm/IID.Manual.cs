// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.pwm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPwmController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x5C,
                0x5F,
                0xC4,
                0xE8,
                0xD2,
                0xCF,
                0x42,
                0x9B,
                0xD6,
                0xCF,
                0x5E,
                0xD0,
                0x29,
                0xE6,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPwmControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xBD,
                0x63,
                0x42,
                0x46,
                0x89,
                0x04,
                0x44,
                0xBD,
                0x48,
                0x81,
                0xDD,
                0x12,
                0x4A,
                0xF4,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPwmControllerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x5B,
                0xFC,
                0x44,
                0x19,
                0xF1,
                0xDD,
                0x4B,
                0x97,
                0xAD,
                0xF7,
                0x6E,
                0xF9,
                0x86,
                0x73,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPwmControllerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x18,
                0x58,
                0xB2,
                0x29,
                0x02,
                0x44,
                0x43,
                0xAE,
                0x3F,
                0x9B,
                0x7C,
                0xD0,
                0xE6,
                0x6B,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPwmPin
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x2D,
                0x97,
                0x22,
                0xCF,
                0xC6,
                0x21,
                0x48,
                0xB7,
                0xF9,
                0xC6,
                0x45,
                0x4F,
                0xB6,
                0xAF,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
