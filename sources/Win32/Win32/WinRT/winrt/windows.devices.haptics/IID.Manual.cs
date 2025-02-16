// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IKnownSimpleHapticsControllerWaveformsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
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
    public static ref readonly Guid IID_IKnownSimpleHapticsControllerWaveformsStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x4C,
                0xD2,
                0xA7,
                0x9D,
                0xB7,
                0x0A,
                0x51,
                0xBF,
                0x79,
                0xFF,
                0x6D,
                0x49,
                0x17,
                0x3E,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISimpleHapticsController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
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
    public static ref readonly Guid IID_ISimpleHapticsControllerFeedback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
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
    public static ref readonly Guid IID_IVibrationDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x1A,
                0xF2,
                0x40,
                0x44,
                0x88,
                0xFF,
                0x47,
                0xB3,
                0x12,
                0x06,
                0x18,
                0x5A,
                0x38,
                0x44,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVibrationDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0xED,
                0xE2,
                0x53,
                0x90,
                0x22,
                0xC9,
                0x4A,
                0x8E,
                0xB3,
                0x1A,
                0x84,
                0x12,
                0x2E,
                0xB7,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
