// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IID
{
    public static ref readonly Guid IID_IMFTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0xC1,
                0x94,
                0xBF,
                0x05,
                0x5B,
                0x6F,
                0x4E,
                0x80,
                0x00,
                0xBA,
                0x59,
                0x89,
                0x61,
                0x41,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMFDeviceTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0xFB,
                0x18,
                0xD8,
                0x46,
                0xFC,
                0xF2,
                0x42,
                0x87,
                0xAC,
                0x1E,
                0xA2,
                0xD1,
                0xF9,
                0xBF,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMFDeviceTransform2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x0F,
                0x98,
                0xF5,
                0x21,
                0xB5,
                0x8F,
                0x48,
                0x90,
                0x9F,
                0x1A,
                0x5F,
                0xCE,
                0xCE,
                0xDB,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMFDeviceTransformCallback
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xB6,
                0x5C,
                0x6D,
                0xEC,
                0x29,
                0xFB,
                0x41,
                0x81,
                0x79,
                0x8C,
                0x4C,
                0x6D,
                0x75,
                0x08,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
