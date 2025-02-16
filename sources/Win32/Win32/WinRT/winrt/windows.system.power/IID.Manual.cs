// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.power.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBackgroundEnergyManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x1D,
                0x16,
                0xB3,
                0x80,
                0x11,
                0x76,
                0x43,
                0x96,
                0xE1,
                0x40,
                0x95,
                0x56,
                0x81,
                0x47,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IForegroundEnergyManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x68,
                0xF8,
                0x9F,
                0x77,
                0xE6,
                0x14,
                0x48,
                0x9A,
                0x20,
                0x53,
                0x37,
                0xCA,
                0x73,
                0x2B,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPowerManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x82,
                0x94,
                0x13,
                0xCE,
                0x62,
                0x64,
                0x43,
                0x98,
                0xD5,
                0xAA,
                0x28,
                0xC7,
                0xFB,
                0xD1,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
