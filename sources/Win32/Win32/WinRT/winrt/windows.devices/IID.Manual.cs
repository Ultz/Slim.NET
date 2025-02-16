// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ILowLevelDevicesAggregateProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x56,
                0x3E,
                0xA7,
                0xC1,
                0xAA,
                0xC7,
                0x4E,
                0xA8,
                0x52,
                0x47,
                0x9F,
                0x70,
                0x60,
                0xD0,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLevelDevicesAggregateProviderFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0xAA,
                0xC4,
                0x9A,
                0x73,
                0x34,
                0x5E,
                0x46,
                0x96,
                0xD5,
                0x36,
                0x28,
                0x1A,
                0x2C,
                0x57,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLevelDevicesController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x3D,
                0xC2,
                0x2E,
                0x9B,
                0x17,
                0xDE,
                0x45,
                0x9B,
                0x39,
                0x3A,
                0xE0,
                0x25,
                0x27,
                0xDE,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLevelDevicesControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x92,
                0x3E,
                0x09,
                0xCB,
                0xFC,
                0x94,
                0x43,
                0xA6,
                0x97,
                0x19,
                0xDE,
                0x63,
                0x7C,
                0x2D,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
