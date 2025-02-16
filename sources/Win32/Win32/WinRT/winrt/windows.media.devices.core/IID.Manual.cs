// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ICameraIntrinsics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0xED,
                0xA6,
                0x0A,
                0x89,
                0x65,
                0xDA,
                0x49,
                0xAF,
                0xDE,
                0x59,
                0x42,
                0x70,
                0xCA,
                0x0A,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICameraIntrinsics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0xA4,
                0xDA,
                0x0C,
                0x98,
                0x07,
                0x4D,
                0x4B,
                0x83,
                0x9F,
                0xC5,
                0xEC,
                0x41,
                0x4D,
                0xB2,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICameraIntrinsicsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0xC4,
                0xDD,
                0xC0,
                0x32,
                0x21,
                0x34,
                0x4A,
                0xA6,
                0x59,
                0x9B,
                0xFE,
                0x2A,
                0x05,
                0x57,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDepthCorrelatedCoordinateMapper
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x89,
                0x5D,
                0xF9,
                0xF0,
                0x8A,
                0xB0,
                0x4C,
                0x92,
                0x6D,
                0x69,
                0x68,
                0x66,
                0xE5,
                0x04,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameControlCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xAE,
                0xFF,
                0xA8,
                0x9E,
                0x4E,
                0x77,
                0x43,
                0xA7,
                0x89,
                0xE2,
                0x4C,
                0x4A,
                0xE7,
                0xE5,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameControlCapabilities2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x04,
                0x9B,
                0xCE,
                0x30,
                0x47,
                0x0F,
                0x44,
                0xBD,
                0x3E,
                0xEF,
                0xE8,
                0xA8,
                0xF2,
                0x30,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x59,
                0x64,
                0xC1,
                0xEF,
                0xBA,
                0x52,
                0x40,
                0x91,
                0x77,
                0x48,
                0xAF,
                0xF2,
                0xAF,
                0x75,
                0x22,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameController2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xBC,
                0xD3,
                0x00,
                0x7C,
                0xD8,
                0x5B,
                0x48,
                0x8A,
                0x09,
                0x5C,
                0x35,
                0x85,
                0x68,
                0xB4,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameExposureCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x9C,
                0xBE,
                0xBD,
                0x85,
                0x39,
                0x72,
                0x4E,
                0x97,
                0xC2,
                0x05,
                0x90,
                0xD6,
                0x13,
                0x07,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameExposureCompensationCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0xA8,
                0x88,
                0xB9,
                0x65,
                0x80,
                0xEE,
                0x41,
                0xB0,
                0x4F,
                0x72,
                0x22,
                0x65,
                0x95,
                0x45,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameExposureCompensationControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x96,
                0x58,
                0xE9,
                0xF9,
                0xF7,
                0xCA,
                0x48,
                0x85,
                0x91,
                0xA2,
                0x65,
                0x31,
                0xCB,
                0x15,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameExposureControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x5A,
                0x60,
                0xB1,
                0xAF,
                0xFF,
                0x52,
                0x47,
                0xB6,
                0x21,
                0xF5,
                0xB6,
                0xF1,
                0x17,
                0xF4,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameFlashCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x41,
                0x93,
                0xBB,
                0xBE,
                0x5E,
                0x62,
                0x4F,
                0x82,
                0x23,
                0x0E,
                0x2B,
                0x05,
                0xBF,
                0xBB,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameFlashControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xF6,
                0xD5,
                0x75,
                0x45,
                0xBD,
                0xAB,
                0x4F,
                0x93,
                0x75,
                0x45,
                0xAC,
                0x04,
                0xB3,
                0x32,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameFocusCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xCD,
                0x25,
                0x7B,
                0xC0,
                0x01,
                0x65,
                0x40,
                0x9C,
                0x40,
                0xC1,
                0xA7,
                0x21,
                0x42,
                0x5C,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameFocusControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xF1,
                0x2D,
                0x27,
                0x12,
                0xD9,
                0x14,
                0x42,
                0xA6,
                0x7B,
                0xE3,
                0x8A,
                0x8D,
                0x48,
                0xD8,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameIsoSpeedCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xFF,
                0xBD,
                0x16,
                0xF6,
                0x6D,
                0xC9,
                0x4A,
                0xB9,
                0x2A,
                0x9F,
                0x6E,
                0xCD,
                0x1A,
                0xD2,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameIsoSpeedControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0xEF,
                0x03,
                0x1A,
                0x6A,
                0x78,
                0x75,
                0x4C,
                0xA5,
                0x57,
                0x7A,
                0xB9,
                0xA8,
                0x5F,
                0x58,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVariablePhotoSequenceController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xF8,
                0xBF,
                0x7F,
                0x8C,
                0xED,
                0xFD,
                0x43,
                0xA7,
                0xC3,
                0xB3,
                0x58,
                0x09,
                0xE4,
                0x22,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
