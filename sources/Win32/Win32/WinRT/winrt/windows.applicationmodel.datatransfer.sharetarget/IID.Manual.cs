// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.datatransfer.sharetarget.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IQuickLink
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x43,
                0x3E,
                0x60,
                0xBE,
                0xF0,
                0xDC,
                0x4A,
                0xAC,
                0xC9,
                0x8B,
                0x27,
                0xAB,
                0x9C,
                0xF5,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0xBA,
                0x46,
                0x22,
                0xF8,
                0xD0,
                0xC1,
                0x41,
                0xA8,
                0x2A,
                0x41,
                0x37,
                0xDB,
                0x65,
                0x04,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareOperation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x97,
                0xFB,
                0x0F,
                0x78,
                0x97,
                0x09,
                0x4A,
                0x8E,
                0x5B,
                0xCB,
                0x5E,
                0x48,
                0x2D,
                0x05,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareOperation3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0xB3,
                0xF6,
                0x5E,
                0xA7,
                0xB7,
                0x71,
                0x45,
                0xA2,
                0xA6,
                0x99,
                0x4A,
                0x03,
                0x49,
                0x88,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
