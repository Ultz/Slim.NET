// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IUriToStreamResolver
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xA8,
                0xAB,
                0xB0,
                0xEB,
                0x9A,
                0x3A,
                0x4D,
                0x95,
                0x90,
                0x00,
                0x3E,
                0x3C,
                0xA7,
                0xE2,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebErrorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x67,
                0x61,
                0xFE,
                0x27,
                0xBF,
                0x64,
                0x40,
                0x87,
                0xB7,
                0x65,
                0x63,
                0xBB,
                0x11,
                0xCE,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
