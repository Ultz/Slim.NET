// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IHttpBaseProtocolFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x9B,
                0xC8,
                0x71,
                0x31,
                0xE1,
                0x54,
                0x4B,
                0xA5,
                0x3C,
                0xEB,
                0x43,
                0xFF,
                0x37,
                0xE9,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpBaseProtocolFilter2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x00,
                0xC3,
                0x2E,
                0x27,
                0x94,
                0x00,
                0x49,
                0xA0,
                0x17,
                0xFA,
                0x7D,
                0xA3,
                0xB5,
                0xC9,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpBaseProtocolFilter3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x4D,
                0x3F,
                0xD4,
                0x42,
                0xBD,
                0xAE,
                0x43,
                0x87,
                0x17,
                0xAD,
                0x2C,
                0x8F,
                0x4B,
                0x29,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpBaseProtocolFilter4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x6C,
                0xE3,
                0x9F,
                0x83,
                0x29,
                0x93,
                0x48,
                0x94,
                0x1F,
                0xEB,
                0x51,
                0x8C,
                0xA8,
                0xCE,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpBaseProtocolFilter5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x49,
                0x6E,
                0x41,
                0xE3,
                0x31,
                0x16,
                0x48,
                0xBF,
                0x09,
                0xE0,
                0x18,
                0xEE,
                0x8D,
                0xC1,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpBaseProtocolFilterStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0xEE,
                0x4D,
                0x6D,
                0x08,
                0xE9,
                0x4E,
                0x49,
                0xB5,
                0xA3,
                0x12,
                0x63,
                0xC9,
                0xB8,
                0x24,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCacheControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x1C,
                0x7E,
                0xC7,
                0xEA,
                0x3C,
                0xB5,
                0x4E,
                0xAC,
                0x85,
                0x04,
                0xE1,
                0x86,
                0xE6,
                0x3A,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x6D,
                0xCB,
                0xA4,
                0x02,
                0x09,
                0x9E,
                0x43,
                0xBF,
                0xD7,
                0xE1,
                0x25,
                0x52,
                0xB1,
                0x65,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpServerCustomValidationRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0xFE,
                0x65,
                0x31,
                0xDD,
                0xE7,
                0xB7,
                0x48,
                0xA3,
                0x61,
                0x93,
                0x9C,
                0x75,
                0x0E,
                0x63,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
