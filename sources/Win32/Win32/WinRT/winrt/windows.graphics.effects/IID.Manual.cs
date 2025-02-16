// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IGraphicsEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0xC0,
                0x51,
                0xCB,
                0xE6,
                0x8F,
                0x36,
                0x46,
                0xB2,
                0x02,
                0x86,
                0x1F,
                0xAA,
                0x07,
                0xD8,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGraphicsEffectSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x9D,
                0x8F,
                0x2D,
                0x39,
                0x43,
                0xB9,
                0x4E,
                0x92,
                0x16,
                0xF9,
                0xDE,
                0xB7,
                0x56,
                0x58,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
