// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IEndpointPair
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0xAA,
                0xA0,
                0x33,
                0xFA,
                0xF8,
                0x30,
                0x4B,
                0xB8,
                0x56,
                0x76,
                0x51,
                0x7C,
                0x3B,
                0xD0,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEndpointPairFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xD9,
                0x09,
                0xB6,
                0xE0,
                0x64,
                0x2B,
                0x44,
                0xAA,
                0x6F,
                0xCC,
                0x8C,
                0x8F,
                0x18,
                0x1F,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHostName
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0xCA,
                0x8E,
                0xBF,
                0x96,
                0xED,
                0xA7,
                0x49,
                0x90,
                0x84,
                0xD4,
                0x16,
                0xCA,
                0xE8,
                0x8D,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHostNameFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x23,
                0x8C,
                0x45,
                0x2F,
                0x71,
                0x76,
                0x45,
                0xAD,
                0xF1,
                0xC2,
                0x0B,
                0x2C,
                0x64,
                0x35,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHostNameStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0xD4,
                0x8C,
                0xF6,
                0x88,
                0xA3,
                0x8B,
                0x4E,
                0x91,
                0xEA,
                0x54,
                0xDD,
                0x6D,
                0xD9,
                0x01,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
