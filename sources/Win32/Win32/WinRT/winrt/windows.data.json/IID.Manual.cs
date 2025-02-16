// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IJsonArray
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xDD,
                0xC1,
                0x08,
                0xBD,
                0x0C,
                0x9A,
                0x4A,
                0xB5,
                0xD3,
                0x2F,
                0x85,
                0x2D,
                0xC3,
                0x7E,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IJsonArrayStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x34,
                0x14,
                0xDB,
                0x64,
                0xE1,
                0x9F,
                0x49,
                0x93,
                0xE2,
                0x8A,
                0x8F,
                0x49,
                0xBB,
                0x90,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IJsonErrorStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x30,
                0x40,
                0x40,
                0xD0,
                0x87,
                0x6C,
                0x43,
                0x83,
                0xAB,
                0xFC,
                0x7B,
                0x12,
                0xC0,
                0xCC,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IJsonObject
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x24,
                0x4E,
                0x06,
                0xC2,
                0x29,
                0x83,
                0x4F,
                0x9A,
                0xC1,
                0x9E,
                0xE1,
                0x15,
                0x78,
                0xBE,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IJsonObjectStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xF1,
                0x89,
                0x22,
                0xDE,
                0x54,
                0xD8,
                0x45,
                0xAB,
                0xCC,
                0x22,
                0x60,
                0x3F,
                0xA0,
                0x66,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IJsonObjectWithDefaultValues
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0xD2,
                0x60,
                0xD9,
                0xF0,
                0xB7,
                0x00,
                0x4F,
                0x8E,
                0x44,
                0xD8,
                0x2C,
                0xF4,
                0x15,
                0xEA,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IJsonValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x9E,
                0x21,
                0xA3,
                0xB3,
                0xF0,
                0xCD,
                0x4D,
                0xBE,
                0xEE,
                0x19,
                0xD4,
                0x8C,
                0xD3,
                0xED,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IJsonValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x54,
                0x6B,
                0x5F,
                0x53,
                0x2F,
                0xE1,
                0x48,
                0x91,
                0xA3,
                0xF7,
                0x8B,
                0x50,
                0xA6,
                0x34,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IJsonValueStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0xCB,
                0x9E,
                0x1D,
                0xE8,
                0x3F,
                0x35,
                0x43,
                0x83,
                0x92,
                0x93,
                0xD8,
                0xE3,
                0x68,
                0x65,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
