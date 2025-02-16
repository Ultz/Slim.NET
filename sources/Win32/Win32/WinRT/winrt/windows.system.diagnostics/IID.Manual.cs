// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDiagnosticActionResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xA2,
                0x65,
                0xC2,
                0x3B,
                0xE7,
                0x97,
                0x40,
                0xB2,
                0x8F,
                0x34,
                0x42,
                0xF0,
                0x3D,
                0xD8,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiagnosticInvoker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x27,
                0x7B,
                0x18,
                0xE3,
                0x02,
                0x86,
                0x4F,
                0x84,
                0xFC,
                0xFD,
                0xD8,
                0x92,
                0xB5,
                0x94,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiagnosticInvoker2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x94,
                0xBF,
                0xE3,
                0x5A,
                0x15,
                0x52,
                0x4B,
                0xA8,
                0xEC,
                0x07,
                0x0C,
                0x44,
                0xF9,
                0x50,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDiagnosticInvokerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0xD8,
                0xFA,
                0x5C,
                0x5C,
                0xF1,
                0x54,
                0x45,
                0xA8,
                0x13,
                0xC1,
                0x13,
                0xC3,
                0x88,
                0x1B,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessCpuUsage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x24,
                0xBB,
                0x0B,
                0xBF,
                0xC8,
                0x3A,
                0x42,
                0xA8,
                0x10,
                0xB5,
                0x59,
                0xAE,
                0x43,
                0x54,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessCpuUsageReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x9C,
                0x6D,
                0x8A,
                0x87,
                0x39,
                0x2F,
                0x4E,
                0xA1,
                0x19,
                0x6B,
                0x5F,
                0xA2,
                0x14,
                0xF1,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessDiagnosticInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0xB0,
                0x30,
                0xE8,
                0x0E,
                0x30,
                0xE6,
                0x4E,
                0xA0,
                0xAB,
                0x5B,
                0x5F,
                0x52,
                0x31,
                0xB4,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessDiagnosticInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0xCB,
                0x58,
                0x95,
                0x0B,
                0x3D,
                0xEC,
                0x49,
                0xAB,
                0x70,
                0x4F,
                0x7A,
                0x11,
                0x28,
                0x05,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessDiagnosticInfoStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xB2,
                0x41,
                0x2F,
                0x9F,
                0xB4,
                0x8C,
                0x42,
                0xAA,
                0x0E,
                0x84,
                0x74,
                0x4F,
                0x49,
                0xCA,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessDiagnosticInfoStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0x98,
                0x86,
                0x4A,
                0x99,
                0x98,
                0x44,
                0x4A,
                0xA2,
                0x9B,
                0x09,
                0x16,
                0x63,
                0xBE,
                0x09,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessDiskUsage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x8B,
                0xD7,
                0x5A,
                0x51,
                0x7E,
                0x53,
                0x4E,
                0xBF,
                0xAA,
                0x5A,
                0x6E,
                0xE1,
                0xAA,
                0xBB,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessDiskUsageReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x27,
                0x16,
                0x40,
                0x5D,
                0x53,
                0x1F,
                0x4C,
                0x81,
                0xB8,
                0xDA,
                0x54,
                0xE1,
                0xBE,
                0x63,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessMemoryUsage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x22,
                0x0B,
                0xF5,
                0x7C,
                0x82,
                0xB7,
                0x42,
                0xB0,
                0x7C,
                0x0E,
                0x32,
                0x62,
                0x7E,
                0x6B,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessMemoryUsageReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x7C,
                0xC7,
                0xC2,
                0x51,
                0x19,
                0x85,
                0x46,
                0x85,
                0x32,
                0x7E,
                0x74,
                0x9E,
                0xCF,
                0x8E,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemCpuUsage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0xB3,
                0x37,
                0x60,
                0xD6,
                0x02,
                0x34,
                0x42,
                0x83,
                0x62,
                0x7F,
                0xE3,
                0xAD,
                0xC8,
                0x1F,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemCpuUsageReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0xD0,
                0x26,
                0x2C,
                0x83,
                0x94,
                0x62,
                0x4F,
                0xAB,
                0x57,
                0x82,
                0xB2,
                0x9D,
                0x97,
                0x19,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemDiagnosticInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0xFE,
                0x90,
                0xA2,
                0xF3,
                0xDF,
                0x7F,
                0x40,
                0x9A,
                0x1B,
                0x0B,
                0x2B,
                0x31,
                0x7C,
                0xA8,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemDiagnosticInfoStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0xAC,
                0x04,
                0xD4,
                0x7D,
                0xFC,
                0xF0,
                0x45,
                0x9A,
                0x3F,
                0x39,
                0x20,
                0x3A,
                0xED,
                0x9F,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemDiagnosticInfoStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xD1,
                0xDE,
                0x79,
                0xF9,
                0x6A,
                0xA9,
                0x4D,
                0xA4,
                0x22,
                0x15,
                0xF7,
                0x32,
                0x55,
                0xB3,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMemoryUsage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0xC5,
                0xFF,
                0x17,
                0x02,
                0x17,
                0xCF,
                0x49,
                0xAA,
                0x27,
                0x2F,
                0x0A,
                0x32,
                0x59,
                0x14,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMemoryUsageReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x3C,
                0x66,
                0x38,
                0x9F,
                0x2A,
                0x3A,
                0x40,
                0xBD,
                0x19,
                0x2C,
                0xF3,
                0xE8,
                0x16,
                0x95,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
