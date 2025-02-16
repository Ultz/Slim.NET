// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.radios.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IRadio
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x18,
                0x21,
                0x25,
                0x3E,
                0xB3,
                0x6A,
                0x41,
                0x87,
                0x5F,
                0x1C,
                0xF3,
                0x8A,
                0xE2,
                0xD8,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadioStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0xA1,
                0xB6,
                0x5F,
                0xCB,
                0x67,
                0xAE,
                0x46,
                0xAA,
                0xE9,
                0x65,
                0x91,
                0x9F,
                0x86,
                0xEF,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
