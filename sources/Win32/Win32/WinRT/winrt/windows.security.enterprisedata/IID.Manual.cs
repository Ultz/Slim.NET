// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBufferProtectUnprotectResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x5E,
                0x99,
                0x47,
                0xEC,
                0x6C,
                0x3A,
                0x4E,
                0xB2,
                0x51,
                0x9E,
                0x74,
                0x85,
                0xD7,
                0x9E,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataProtectionInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0xB0,
                0x20,
                0x84,
                0x31,
                0x5E,
                0x05,
                0x44,
                0x95,
                0x40,
                0x3F,
                0x94,
                0x3A,
                0xF0,
                0xCB,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataProtectionManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x9B,
                0x14,
                0xB6,
                0x44,
                0x91,
                0xE4,
                0x4E,
                0x8A,
                0x8A,
                0x30,
                0xB5,
                0xF3,
                0x61,
                0x43,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileProtectionInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x64,
                0xE9,
                0x4E,
                0x7E,
                0x14,
                0xD0,
                0x4D,
                0x8F,
                0xAF,
                0x52,
                0x53,
                0xED,
                0x91,
                0xAD,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileProtectionInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x3A,
                0x12,
                0x82,
                0x7A,
                0x55,
                0x8D,
                0x49,
                0x8E,
                0x94,
                0x94,
                0x4C,
                0xD5,
                0x83,
                0x64,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileProtectionManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xFC,
                0x46,
                0x58,
                0x13,
                0xE6,
                0x6B,
                0x42,
                0xBB,
                0x38,
                0x88,
                0xCB,
                0xA1,
                0xDC,
                0x9A,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileProtectionManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0xA7,
                0xD2,
                0x83,
                0x83,
                0x04,
                0xAB,
                0x41,
                0xB2,
                0xD5,
                0xBC,
                0x7F,
                0x23,
                0xD7,
                0x4E,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileProtectionManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x84,
                0x18,
                0x69,
                0x4F,
                0x62,
                0xD6,
                0x46,
                0xB2,
                0x41,
                0xE9,
                0xCD,
                0x5F,
                0xDF,
                0x3E,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileRevocationManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0xBC,
                0x6B,
                0x25,
                0x5D,
                0x1C,
                0x60,
                0x42,
                0x8C,
                0x75,
                0x91,
                0x44,
                0xCF,
                0xB7,
                0x8B,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileUnprotectOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x12,
                0x13,
                0x7D,
                0x0D,
                0x3B,
                0xD8,
                0x4D,
                0xA1,
                0xF8,
                0x1E,
                0xC5,
                0x38,
                0x22,
                0xE2,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileUnprotectOptionsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0xB3,
                0xAE,
                0x51,
                0x8C,
                0xDA,
                0x3F,
                0x4C,
                0x9B,
                0xFB,
                0xCB,
                0x73,
                0xA7,
                0xCC,
                0xE0,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectedAccessResumedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xCA,
                0x4D,
                0xAC,
                0x80,
                0x5D,
                0x95,
                0x4E,
                0x8C,
                0x5F,
                0x85,
                0x39,
                0x45,
                0x0E,
                0xEB,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectedAccessSuspendingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x93,
                0xA1,
                0x75,
                0x44,
                0xA3,
                0x9F,
                0x42,
                0xB9,
                0x75,
                0x04,
                0xFC,
                0x1F,
                0x88,
                0xC1,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectedContainerExportResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0xEF,
                0x48,
                0x39,
                0xFB,
                0xF7,
                0x42,
                0x4B,
                0xAF,
                0xB0,
                0xDF,
                0x70,
                0xB4,
                0x15,
                0x43,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectedContainerImportResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x80,
                0xB7,
                0xCD,
                0xBB,
                0xE7,
                0x1A,
                0x4D,
                0x93,
                0x39,
                0x34,
                0xDC,
                0x41,
                0x14,
                0x9F,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectedContentRevokedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x68,
                0x68,
                0x63,
                0xB9,
                0x58,
                0xEE,
                0x47,
                0x93,
                0xD9,
                0xF0,
                0xF7,
                0x41,
                0xCF,
                0x43,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectedFileCreateResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xED,
                0xE3,
                0x28,
                0xE7,
                0xE9,
                0x03,
                0x4A,
                0x9F,
                0x53,
                0xBD,
                0xB1,
                0x61,
                0x72,
                0x69,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionPolicyAuditInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0xB7,
                0x5A,
                0x42,
                0xB7,
                0xFE,
                0xFC,
                0x44,
                0xB3,
                0xBB,
                0xC3,
                0xC4,
                0xD7,
                0xEC,
                0xBE,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionPolicyAuditInfoFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0x18,
                0xD4,
                0x7E,
                0xE8,
                0x92,
                0xD5,
                0x42,
                0x83,
                0xD4,
                0x25,
                0x44,
                0x0B,
                0x42,
                0x35,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionPolicyManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x3E,
                0x70,
                0xD5,
                0x8D,
                0xA0,
                0xE6,
                0x47,
                0xA2,
                0x40,
                0x99,
                0x34,
                0xD7,
                0x16,
                0x5E,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionPolicyManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0x52,
                0xF7,
                0xAB,
                0x35,
                0x84,
                0x7F,
                0x41,
                0x99,
                0xB6,
                0x51,
                0xBE,
                0xAF,
                0x36,
                0x58,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionPolicyManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0xFC,
                0xBF,
                0xC0,
                0x3D,
                0x8C,
                0x56,
                0x4D,
                0x88,
                0x04,
                0xC6,
                0x8F,
                0x0A,
                0xD3,
                0x2E,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionPolicyManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x9A,
                0x8F,
                0xB6,
                0xE0,
                0x39,
                0x49,
                0x46,
                0xB2,
                0xE4,
                0x07,
                0x0A,
                0xB8,
                0xA5,
                0x79,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionPolicyManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x9E,
                0xFF,
                0x48,
                0x6F,
                0x6A,
                0x9F,
                0x4D,
                0xBC,
                0xED,
                0x18,
                0xAB,
                0x53,
                0x7A,
                0xA0,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtectionPolicyManagerStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x94,
                0xB7,
                0x20,
                0xBD,
                0xCC,
                0x0F,
                0x49,
                0x8C,
                0x83,
                0x49,
                0xCC,
                0xB7,
                0x7A,
                0xEA,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IThreadNetworkContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0xA8,
                0x4E,
                0xFA,
                0x13,
                0xEF,
                0x5A,
                0x40,
                0xB1,
                0x2C,
                0xD7,
                0x34,
                0x8C,
                0x6F,
                0x41,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
