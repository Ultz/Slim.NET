// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IComponentLoadFailedEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x64,
                0xDA,
                0x95,
                0xB9,
                0x6D,
                0x4B,
                0x42,
                0x86,
                0xCA,
                0x09,
                0x1A,
                0xF4,
                0x32,
                0x08,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRebootNeededEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x2A,
                0xE1,
                0x64,
                0x3B,
                0x97,
                0x3A,
                0x4A,
                0xB2,
                0x60,
                0x91,
                0x89,
                0x8A,
                0x49,
                0xA8,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IServiceRequestedEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x90,
                0xD6,
                0xD2,
                0xC9,
                0xCA,
                0xE1,
                0x48,
                0x95,
                0xC0,
                0xD3,
                0x84,
                0x95,
                0xA8,
                0x40,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IComponentLoadFailedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x2E,
                0x97,
                0x95,
                0x46,
                0x77,
                0x7E,
                0x41,
                0x84,
                0x95,
                0xF0,
                0x31,
                0xBB,
                0xC5,
                0x86,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IComponentRenewalStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0xCD,
                0xFB,
                0x6F,
                0x95,
                0xB7,
                0xC5,
                0x48,
                0x8B,
                0x7B,
                0xA7,
                0xC4,
                0xEF,
                0xE2,
                0x02,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHdcpSession
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0x45,
                0x88,
                0x71,
                0xD7,
                0x64,
                0x6D,
                0x42,
                0x80,
                0x9B,
                0x1B,
                0xE4,
                0x61,
                0x94,
                0x1A,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaProtectionManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x49,
                0x69,
                0x45,
                0x41,
                0xC7,
                0x4B,
                0x43,
                0xA7,
                0x9E,
                0x47,
                0x4C,
                0x12,
                0xD9,
                0x3D,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaProtectionPMPServer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x12,
                0x11,
                0x0C,
                0x26,
                0x7B,
                0x31,
                0x4D,
                0x95,
                0xBB,
                0x9C,
                0x1B,
                0x08,
                0xEF,
                0x7F,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaProtectionPMPServerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x8E,
                0x2C,
                0x60,
                0xD2,
                0xF7,
                0x7E,
                0x48,
                0xAF,
                0x91,
                0xDB,
                0xC4,
                0x25,
                0x2B,
                0x21,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaProtectionServiceCompletion
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0xCA,
                0x5C,
                0x8B,
                0xD5,
                0xCF,
                0xEE,
                0x44,
                0xA2,
                0xED,
                0xDF,
                0x76,
                0x01,
                0x0C,
                0x14,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaProtectionServiceRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x0E,
                0xDE,
                0xB1,
                0x94,
                0x20,
                0x8D,
                0x47,
                0x87,
                0xA4,
                0x8B,
                0x95,
                0x20,
                0x0F,
                0x85,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x5D,
                0xAC,
                0xC7,
                0x80,
                0x74,
                0x29,
                0x4D,
                0xA4,
                0x64,
                0x7B,
                0xCD,
                0x91,
                0x3D,
                0xD8,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRevocationAndRenewalInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x93,
                0xA1,
                0xF3,
                0x01,
                0x25,
                0x9E,
                0x43,
                0xA6,
                0xE7,
                0x6F,
                0xC9,
                0x5E,
                0x17,
                0x5F,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRevocationAndRenewalItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0xC2,
                0x99,
                0x30,
                0xF0,
                0x3C,
                0xEA,
                0x49,
                0x90,
                0x2D,
                0xCA,
                0xF3,
                0x2D,
                0x2D,
                0xDE,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IServiceRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x3B,
                0x28,
                0x34,
                0xB4,
                0xAB,
                0xC1,
                0x4F,
                0xBD,
                0x89,
                0x93,
                0xF1,
                0x06,
                0x57,
                0x3A,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IServiceRequestedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x69,
                0x3C,
                0x55,
                0xFE,
                0xFA,
                0x28,
                0x41,
                0x8D,
                0xFA,
                0x13,
                0x0E,
                0x39,
                0x8A,
                0x13,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
