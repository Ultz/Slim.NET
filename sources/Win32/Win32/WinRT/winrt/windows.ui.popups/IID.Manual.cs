// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IUICommandInvokedHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0x7A,
                0xF7,
                0xDA,
                0x7A,
                0xC2,
                0x98,
                0x42,
                0x9A,
                0xC6,
                0x29,
                0x22,
                0xC4,
                0x5E,
                0x7D,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMessageDialog
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x9B,
                0xF5,
                0x33,
                0x25,
                0x53,
                0xAB,
                0x43,
                0x9A,
                0xB3,
                0xBD,
                0xAE,
                0x44,
                0x0E,
                0x41,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMessageDialogFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x17,
                0x16,
                0x2D,
                0x6F,
                0xA6,
                0xA5,
                0x4E,
                0xBB,
                0x87,
                0x79,
                0x3F,
                0xFA,
                0x49,
                0x41,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPopupMenu
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0xC6,
                0x9B,
                0x4E,
                0x0D,
                0x88,
                0xFC,
                0x47,
                0xA0,
                0xA1,
                0x72,
                0xB6,
                0x39,
                0xE6,
                0x25,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUICommand
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x3A,
                0xF9,
                0x4F,
                0x45,
                0x41,
                0xFF,
                0x47,
                0xAC,
                0x7F,
                0xDF,
                0xF1,
                0xC1,
                0xFA,
                0x5B,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUICommandFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0x81,
                0x1A,
                0xA2,
                0xB0,
                0x26,
                0x76,
                0x46,
                0xAE,
                0x94,
                0x54,
                0x04,
                0x1B,
                0xC1,
                0x25,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
