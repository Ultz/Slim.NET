// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.WinRT;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPrintTicketCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x8B, 0x50, 0x45, 0x8C,
                0xDC, 0xBB,
                0x56, 0x42,
                0xA1,
                0x42,
                0x2F,
                0xD6,
                0x15,
                0xEC,
                0xB4,
                0x16
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintTicketFeature
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x6A, 0x7D, 0x60, 0xE7,
                0xF5, 0x59,
                0x03, 0x41,
                0x88,
                0x58,
                0xB9,
                0x77,
                0x10,
                0x96,
                0x3D,
                0x39
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintTicketOption
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x90, 0xCF, 0x86, 0xB0,
                0x67, 0xB3,
                0x4B, 0x4E,
                0xBD,
                0x48,
                0x9C,
                0x78,
                0xA0,
                0xBB,
                0x31,
                0xCE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintTicketParameterDefinition
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xE4, 0xB4, 0xBA, 0xD6,
                0x62, 0x29,
                0x01, 0x4C,
                0xB7,
                0xF3,
                0x9A,
                0x92,
                0x94,
                0xEB,
                0x83,
                0x35
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintTicketParameterInitializer
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xBB, 0x35, 0x33, 0x5E,
                0xA5, 0xA0,
                0xB1, 0x48,
                0x9D,
                0x5C,
                0x07,
                0x11,
                0x6D,
                0xDC,
                0x59,
                0x7A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintTicketValue
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x32, 0x0A, 0xB3, 0x66,
                0x4D, 0x24,
                0x22, 0x4E,
                0xA9,
                0x8B,
                0xBB,
                0x3C,
                0xF1,
                0xF2,
                0xDD,
                0x91
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWorkflowPrintTicket
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x85, 0x22, 0xD5, 0x41,
                0xE8, 0x35,
                0x8E, 0x44,
                0xA8,
                0xC5,
                0xE4,
                0xB6,
                0xA2,
                0xCF,
                0x82,
                0x6C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IWorkflowPrintTicketValidationResult
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x92, 0xF3, 0xD1, 0x0A,
                0x7B, 0xDA,
                0x36, 0x4A,
                0xBF,
                0x36,
                0x6A,
                0x99,
                0xA6,
                0x2E,
                0x20,
                0x59
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
