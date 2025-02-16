// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.adc.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAdcControllerProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x58,
                0x54,
                0xBE,
                0x6D,
                0x81,
                0xE5,
                0x4D,
                0xA0,
                0x48,
                0xAB,
                0xA0,
                0x69,
                0x58,
                0xAA,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdcProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x36,
                0x95,
                0x28,
                0x59,
                0x93,
                0x57,
                0x4C,
                0xBC,
                0x88,
                0xE2,
                0x75,
                0xE8,
                0x16,
                0x38,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
