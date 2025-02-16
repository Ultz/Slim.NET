// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IVariablePhotoCapturedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x4C,
                0xEB,
                0xD1,
                0x53,
                0x1B,
                0x4A,
                0x4E,
                0x8B,
                0x5C,
                0xDB,
                0x78,
                0x87,
                0xAC,
                0x94,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVariablePhotoSequenceCapture
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x2D,
                0x11,
                0xD0,
                0x1E,
                0x03,
                0x41,
                0x40,
                0xA6,
                0xD6,
                0xBD,
                0x74,
                0x24,
                0x76,
                0xA8,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVariablePhotoSequenceCapture2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x62,
                0x2C,
                0xFE,
                0xB0,
                0x50,
                0xE3,
                0x43,
                0x91,
                0x7C,
                0xE3,
                0xB9,
                0x27,
                0x98,
                0x94,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
