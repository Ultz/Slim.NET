// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.rfcomm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IRfcommDeviceService
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0xFF,
                0x81,
                0xAE,
                0xA1,
                0xC5,
                0x40,
                0x4C,
                0x8C,
                0x28,
                0xF3,
                0xEF,
                0xD6,
                0x90,
                0x62,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommDeviceService2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0xED,
                0x6C,
                0x53,
                0xCD,
                0xEB,
                0xFE,
                0x49,
                0xBF,
                0x9F,
                0x40,
                0xEF,
                0xC6,
                0x89,
                0xB2,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommDeviceService3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0xAC,
                0x22,
                0x1C,
                0x44,
                0xDD,
                0x23,
                0x4D,
                0x86,
                0x6D,
                0x8F,
                0x34,
                0x86,
                0xEE,
                0x64,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommDeviceServiceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x49,
                0xA1,
                0xA4,
                0x6D,
                0x62,
                0xAC,
                0x41,
                0xB2,
                0x53,
                0x87,
                0xAC,
                0x5C,
                0x27,
                0xE2,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommDeviceServiceStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0xB1,
                0x8C,
                0xAA,
                0x8D,
                0xE7,
                0xE4,
                0x4B,
                0x80,
                0x76,
                0x0A,
                0x3D,
                0x87,
                0xA0,
                0xA0,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommDeviceServicesResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x38,
                0x48,
                0x3B,
                0xCF,
                0x7C,
                0x8E,
                0x48,
                0x96,
                0x25,
                0xD2,
                0x59,
                0xA5,
                0x73,
                0x2D,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommServiceId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x92,
                0x62,
                0x22,
                0x02,
                0x7E,
                0x17,
                0x40,
                0x81,
                0x36,
                0xDA,
                0x1B,
                0x6A,
                0x1B,
                0x9B,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommServiceIdStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x9E,
                0x17,
                0x2A,
                0x75,
                0xA9,
                0xE3,
                0x46,
                0xB5,
                0x6B,
                0x08,
                0xFF,
                0xD7,
                0x83,
                0xA5,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommServiceProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0xFD,
                0xDB,
                0xEA,
                0xF6,
                0xB1,
                0xFF,
                0x44,
                0x9F,
                0x7C,
                0xE7,
                0xA8,
                0x2A,
                0xB8,
                0x68,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommServiceProvider2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0xDF,
                0x6B,
                0x73,
                0x81,
                0x3C,
                0x1E,
                0x4D,
                0xBA,
                0xF2,
                0xDD,
                0xBB,
                0x81,
                0x28,
                0x45,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommServiceProviderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x83,
                0x88,
                0x98,
                0xCA,
                0x69,
                0x3A,
                0x41,
                0x84,
                0xF7,
                0x43,
                0x44,
                0xC7,
                0x29,
                0x29,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
