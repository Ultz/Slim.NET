// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IUserDataTask
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x85,
                0x65,
                0x7C,
                0xD4,
                0xE0,
                0x99,
                0x4F,
                0xAE,
                0xE2,
                0xBC,
                0x2D,
                0x5D,
                0xDA,
                0xDF,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskBatch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0xA5,
                0x2D,
                0x38,
                0xB5,
                0x20,
                0x1C,
                0x43,
                0x8F,
                0x42,
                0xA5,
                0xD2,
                0x92,
                0xEC,
                0x93,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x2E,
                0x41,
                0x49,
                0x1D,
                0x7C,
                0xF1,
                0x4D,
                0xBE,
                0xD3,
                0x31,
                0x4B,
                0x7C,
                0xBF,
                0x5E,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskListLimitedWriteOperations
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x67,
                0xA2,
                0x7A,
                0x78,
                0x60,
                0x83,
                0x41,
                0x91,
                0x9E,
                0x4F,
                0x29,
                0xF1,
                0x9C,
                0xFA,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskListSyncManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x1A,
                0x59,
                0x8E,
                0xCF,
                0x1D,
                0x9F,
                0x46,
                0x93,
                0xEC,
                0xBA,
                0x48,
                0xBB,
                0x55,
                0x3C,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0xC9,
                0x51,
                0x84,
                0x0B,
                0xE6,
                0xA9,
                0x48,
                0x92,
                0x11,
                0x7F,
                0xB8,
                0xA5,
                0x6C,
                0xB8,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x39,
                0x55,
                0xB3,
                0x02,
                0xC5,
                0xFC,
                0x47,
                0xA8,
                0x1E,
                0x10,
                0x08,
                0x83,
                0x71,
                0x9D,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskQueryOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x27,
                0x9F,
                0x95,
                0x9A,
                0x90,
                0x30,
                0x4D,
                0x8C,
                0x1B,
                0x33,
                0x1D,
                0x8F,
                0xE6,
                0x67,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x88,
                0xE6,
                0x03,
                0xCF,
                0x4C,
                0x00,
                0x45,
                0x88,
                0x3B,
                0xE7,
                0x62,
                0x90,
                0xCF,
                0xED,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskRecurrenceProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x80,
                0xDF,
                0x73,
                0xC6,
                0x27,
                0xCE,
                0x40,
                0xB1,
                0x49,
                0x9C,
                0xD4,
                0x14,
                0x85,
                0xA6,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskRegenerationProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x00,
                0xAB,
                0x92,
                0x0E,
                0x09,
                0x04,
                0x47,
                0xBB,
                0x5C,
                0x84,
                0xFC,
                0x0B,
                0x0D,
                0x9C,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataTaskStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x9C,
                0x6A,
                0xF0,
                0xDB,
                0xF1,
                0xBA,
                0x45,
                0x8A,
                0x62,
                0x08,
                0x60,
                0x04,
                0xC0,
                0x21,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
