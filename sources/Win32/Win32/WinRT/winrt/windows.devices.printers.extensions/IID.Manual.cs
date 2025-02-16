// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.printers.extensions.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPrint3DWorkflow
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x74,
                0x6F,
                0xC5,
                0x69,
                0x36,
                0x66,
                0x4A,
                0xAB,
                0x42,
                0xC8,
                0x15,
                0x19,
                0x30,
                0xCD,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrint3DWorkflow2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0xC5,
                0xA6,
                0xA2,
                0xC1,
                0x8A,
                0x18,
                0x49,
                0x97,
                0x41,
                0xE3,
                0x4F,
                0x30,
                0x04,
                0x23,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrint3DWorkflowPrintRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xC8,
                0xF8,
                0x19,
                0xC8,
                0x5A,
                0x55,
                0x4B,
                0x8A,
                0x5F,
                0xE6,
                0x15,
                0x67,
                0xDA,
                0xFB,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrint3DWorkflowPrinterChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0x64,
                0x22,
                0x45,
                0xFC,
                0x95,
                0x47,
                0x48,
                0x93,
                0xB3,
                0x13,
                0x4D,
                0xBF,
                0x5C,
                0x60,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintExtensionContextStatic
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x9F,
                0x0D,
                0xE7,
                0x79,
                0xFF,
                0xA4,
                0x4A,
                0x8C,
                0x9B,
                0x0C,
                0x93,
                0xAE,
                0xDF,
                0xDE,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintNotificationEventDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x4C,
                0x0E,
                0xE0,
                0x28,
                0x48,
                0xA1,
                0x4D,
                0x8B,
                0xB8,
                0x86,
                0x72,
                0xDF,
                0x85,
                0x15,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x24,
                0xC2,
                0xE3,
                0xA4,
                0x3A,
                0x85,
                0x48,
                0x92,
                0x40,
                0x31,
                0x1F,
                0x5F,
                0x8F,
                0xBE,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskConfigurationSaveRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x2F,
                0xAF,
                0xEE,
                0x1E,
                0x62,
                0x62,
                0x4B,
                0xAC,
                0x77,
                0xB2,
                0x81,
                0xCC,
                0xE0,
                0x8D,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskConfigurationSaveRequestedDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0xD5,
                0x59,
                0xE9,
                0x29,
                0xF7,
                0xA4,
                0x44,
                0x87,
                0x1D,
                0xBD,
                0x06,
                0x28,
                0x69,
                0x6A,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskConfigurationSaveRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x28,
                0x6C,
                0xE0,
                0x61,
                0x0D,
                0x38,
                0x49,
                0x91,
                0xD0,
                0x96,
                0xA4,
                0x5B,
                0xEE,
                0x84,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
