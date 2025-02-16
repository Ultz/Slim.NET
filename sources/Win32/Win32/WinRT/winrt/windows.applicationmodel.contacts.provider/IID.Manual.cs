// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IContactPickerUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x13,
                0xCC,
                0xE2,
                0x66,
                0xCF,
                0xC4,
                0x43,
                0xA9,
                0x6A,
                0xA5,
                0xA1,
                0x12,
                0xDB,
                0x47,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPickerUI2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x9E,
                0x44,
                0x6E,
                0x25,
                0x7B,
                0x99,
                0x49,
                0x9B,
                0x0B,
                0x87,
                0x54,
                0x00,
                0xA1,
                0xE8,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactRemovedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0x43,
                0x35,
                0x6F,
                0x02,
                0x33,
                0x13,
                0x4D,
                0xAD,
                0x8D,
                0xAD,
                0xCC,
                0x0F,
                0xF9,
                0xE4,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
