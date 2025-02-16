// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.faceanalysis.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDetectedFace
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xD4,
                0x00,
                0x82,
                0xBC,
                0x66,
                0xDF,
                0x34,
                0x94,
                0x10,
                0xE8,
                0x94,
                0x00,
                0x19,
                0x54,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFaceDetector
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x72,
                0xB6,
                0x16,
                0x6F,
                0xFE,
                0x17,
                0x31,
                0x8D,
                0x95,
                0xC3,
                0xF0,
                0x4D,
                0x51,
                0x63,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFaceDetectorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x2D,
                0x04,
                0xBC,
                0x47,
                0x90,
                0xF6,
                0x33,
                0x88,
                0x1B,
                0x67,
                0x46,
                0xC1,
                0xB2,
                0x18,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFaceTracker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x7D,
                0xA6,
                0x6B,
                0x41,
                0xA8,
                0x20,
                0x44,
                0x93,
                0xE6,
                0x24,
                0x20,
                0xA1,
                0x88,
                0x4F,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFaceTrackerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0x91,
                0x62,
                0xE9,
                0x01,
                0x18,
                0xA5,
                0x3F,
                0x93,
                0x2E,
                0x31,
                0xD7,
                0x67,
                0xAF,
                0x6C,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
