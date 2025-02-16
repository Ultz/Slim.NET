// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAppServiceCatalogStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x25,
                0x0D,
                0xEF,
                0x32,
                0xD1,
                0x85,
                0x4C,
                0x83,
                0x95,
                0x3C,
                0x31,
                0xD5,
                0xA1,
                0xE9,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceClosedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x16,
                0x60,
                0xDE,
                0x03,
                0xCB,
                0x35,
                0x4D,
                0xAC,
                0x8D,
                0xCC,
                0x63,
                0x03,
                0x23,
                0x97,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceConnection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x74,
                0xD4,
                0x9D,
                0x1F,
                0x87,
                0x52,
                0x4D,
                0x89,
                0xA9,
                0x9E,
                0x09,
                0x05,
                0x31,
                0xBD,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceConnection2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xCD,
                0xDF,
                0x8B,
                0x02,
                0x23,
                0xBD,
                0x4F,
                0x80,
                0x61,
                0x52,
                0x51,
                0x1C,
                0x2F,
                0x8B,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceConnectionStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0x6C,
                0xC5,
                0xAD,
                0x08,
                0xD4,
                0x73,
                0x56,
                0x86,
                0x37,
                0x82,
                0x7A,
                0x4B,
                0x27,
                0x41,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x53,
                0x1B,
                0x7E,
                0xB0,
                0xEA,
                0x48,
                0x42,
                0xAE,
                0x04,
                0xFD,
                0xF9,
                0x38,
                0x38,
                0xE4,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x8D,
                0xE5,
                0x20,
                0xDE,
                0x18,
                0x01,
                0x4B,
                0x80,
                0xBA,
                0x90,
                0xA7,
                0x62,
                0x04,
                0xE3,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceRequestReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0x23,
                0x12,
                0x6E,
                0x65,
                0xFF,
                0xAE,
                0x44,
                0x9E,
                0x45,
                0x85,
                0x7F,
                0xE4,
                0x18,
                0x06,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceResponse
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0x3C,
                0x50,
                0x8D,
                0xA3,
                0x9A,
                0x68,
                0x4E,
                0x95,
                0x59,
                0x9D,
                0xE6,
                0x3E,
                0x37,
                0x2C,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0xDC,
                0xA2,
                0x88,
                0x28,
                0xAD,
                0xB8,
                0x41,
                0x80,
                0xBB,
                0xBD,
                0xF1,
                0xB2,
                0x16,
                0x9E,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceTriggerDetails2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x54,
                0x3D,
                0xE8,
                0xCC,
                0x28,
                0xF2,
                0x43,
                0xB4,
                0x65,
                0xC0,
                0x48,
                0x2E,
                0x59,
                0xE2,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceTriggerDetails3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x1E,
                0xD7,
                0xFB,
                0x39,
                0x79,
                0x68,
                0x4E,
                0x9E,
                0x3C,
                0x77,
                0x80,
                0x14,
                0x7A,
                0xAB,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppServiceTriggerDetails4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xB1,
                0x85,
                0x11,
                0x61,
                0x88,
                0x30,
                0x5E,
                0xAB,
                0x55,
                0x1C,
                0xF4,
                0xD0,
                0x8B,
                0xBF,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStatelessAppServiceResponse
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x4A,
                0x75,
                0x43,
                0xEC,
                0xA9,
                0xFE,
                0x52,
                0x82,
                0xE7,
                0x93,
                0x9B,
                0x68,
                0xDC,
                0x93,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
