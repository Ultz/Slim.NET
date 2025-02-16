// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IConnectionStatusHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0xC2,
                0x71,
                0xB5,
                0x72,
                0xA4,
                0xD5,
                0x48,
                0x88,
                0xD2,
                0x8A,
                0xDC,
                0xAF,
                0x1B,
                0x88,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceControllerFinderHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0x7D,
                0x8A,
                0xA8,
                0x8C,
                0x98,
                0x03,
                0x44,
                0x9D,
                0x8A,
                0x01,
                0x5B,
                0xED,
                0x14,
                0x0B,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRenderingParametersUpdateHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x9D,
                0x2D,
                0x3A,
                0xE9,
                0x72,
                0x11,
                0x43,
                0xB4,
                0x6C,
                0x27,
                0xC8,
                0xBB,
                0x7E,
                0x6C,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITransportParametersUpdateHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x02,
                0xFD,
                0x16,
                0x61,
                0xDA,
                0xD7,
                0x49,
                0xAA,
                0xB2,
                0x76,
                0x86,
                0x7D,
                0xD4,
                0x2D,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActiveBasicDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x69,
                0x4D,
                0xB6,
                0x79,
                0x6E,
                0xAF,
                0x49,
                0x99,
                0x33,
                0x90,
                0x8B,
                0x6E,
                0x9A,
                0x16,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActiveBasicDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x25,
                0x33,
                0x6D,
                0x42,
                0x36,
                0x18,
                0x46,
                0x9D,
                0xB6,
                0x43,
                0x52,
                0x4F,
                0x4D,
                0xEA,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBasicDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x6C,
                0xF2,
                0xF4,
                0x62,
                0x79,
                0xB7,
                0x48,
                0x80,
                0xF7,
                0xC3,
                0xA5,
                0xD7,
                0x53,
                0xBC,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0xB2,
                0xEE,
                0x4F,
                0xA7,
                0x50,
                0x2B,
                0x40,
                0x89,
                0x6A,
                0xBE,
                0x95,
                0x06,
                0x4D,
                0x6B,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceIcon
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x1A,
                0xFB,
                0x8F,
                0x3D,
                0x02,
                0xE1,
                0x4D,
                0xB5,
                0x56,
                0xAB,
                0x5A,
                0xBF,
                0x01,
                0x92,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDevicePair
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x23,
                0xA4,
                0xF1,
                0xB4,
                0xB7,
                0x9C,
                0x44,
                0xA9,
                0x0D,
                0xAE,
                0xA8,
                0xE1,
                0x7C,
                0x5E,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaRenderer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x2E,
                0x01,
                0x2C,
                0x75,
                0xD9,
                0xFB,
                0x47,
                0x96,
                0xAC,
                0xA6,
                0x41,
                0x8B,
                0x32,
                0x6D,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaRendererActionInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0xBF,
                0xFB,
                0x66,
                0xB0,
                0x5A,
                0x4F,
                0x4A,
                0x8D,
                0x15,
                0xE5,
                0x05,
                0x6B,
                0x26,
                0xBE,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaRendererFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0xB4,
                0x7A,
                0x65,
                0x09,
                0xB9,
                0xB2,
                0x42,
                0x94,
                0xD0,
                0xE3,
                0xA0,
                0xB1,
                0x34,
                0xE8,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamSelectorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xD4,
                0x4C,
                0x8A,
                0x85,
                0xED,
                0x0F,
                0x4E,
                0xBD,
                0x68,
                0x8A,
                0x68,
                0x62,
                0xE4,
                0x63,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITransportParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x4E,
                0x0C,
                0xEB,
                0x83,
                0x22,
                0x8D,
                0x43,
                0x8F,
                0xFF,
                0xDB,
                0xE9,
                0xDF,
                0x1C,
                0xB2,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
