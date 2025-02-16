// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPerceptionTimestamp
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x48,
                0xC2,
                0x87,
                0x2E,
                0xA2,
                0xDB,
                0x4A,
                0xBA,
                0x26,
                0xD7,
                0x8E,
                0xF6,
                0x39,
                0xBC,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPerceptionTimestamp2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0xB7,
                0x54,
                0xE3,
                0xD1,
                0x2B,
                0xB7,
                0x41,
                0x9E,
                0xD0,
                0x74,
                0xA1,
                0x5C,
                0x35,
                0x45,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPerceptionTimestampHelperStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x11,
                0xA6,
                0x47,
                0xDF,
                0xA9,
                0xDC,
                0x4E,
                0x85,
                0x5D,
                0xF4,
                0xD3,
                0x39,
                0xD9,
                0x67,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPerceptionTimestampHelperStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0xA7,
                0xD1,
                0x73,
                0xB9,
                0x3F,
                0x71,
                0x45,
                0x87,
                0xD4,
                0x3C,
                0x92,
                0x0A,
                0x5E,
                0x86,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
