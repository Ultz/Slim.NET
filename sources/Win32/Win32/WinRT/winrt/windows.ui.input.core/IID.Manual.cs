// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.input.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IRadialControllerIndependentInputSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x4C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerIndependentInputSource2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0xAA,
                0x73,
                0x70,
                0xF3,
                0x35,
                0xEB,
                0x4E,
                0x87,
                0x51,
                0xBE,
                0x4D,
                0x0A,
                0x66,
                0xFA,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRadialControllerIndependentInputSourceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0x7E,
                0x57,
                0x3D,
                0xEE,
                0x4C,
                0xE6,
                0x11,
                0xB5,
                0x35,
                0x00,
                0x1B,
                0xDC,
                0x06,
                0xAB,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
