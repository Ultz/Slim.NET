// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.transcoding.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IMediaTranscoder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x99,
                0x0C,
                0x19,
                0xAA,
                0xA0,
                0x34,
                0x4D,
                0x86,
                0xBC,
                0xEE,
                0xD1,
                0xB1,
                0x2C,
                0x2F,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaTranscoder2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x1D,
                0x53,
                0x40,
                0xE0,
                0x35,
                0x04,
                0x4F,
                0x85,
                0x74,
                0xCA,
                0x8B,
                0xC4,
                0xE5,
                0xA0,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrepareTranscodeResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x5D,
                0xF2,
                0x05,
                0x4F,
                0x99,
                0x34,
                0x4A,
                0x9D,
                0x68,
                0x97,
                0xCC,
                0xCE,
                0x17,
                0x30,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
