// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IUserDataAccount
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x36,
                0xC4,
                0xB9,
                0x48,
                0xB3,
                0x10,
                0x49,
                0xBE,
                0x94,
                0x4A,
                0xD4,
                0xBB,
                0xA6,
                0xDE,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccount2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0xD8,
                0x8C,
                0x07,
                0x82,
                0xDE,
                0x4B,
                0x40,
                0x81,
                0x95,
                0xC8,
                0xA3,
                0xAC,
                0x19,
                0x8F,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccount3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x38,
                0x53,
                0x01,
                0x43,
                0x6C,
                0x86,
                0x42,
                0x9D,
                0x69,
                0x3E,
                0x17,
                0x09,
                0xA1,
                0xF2,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccount4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x52,
                0x31,
                0xC4,
                0xE5,
                0xEA,
                0x0A,
                0x4F,
                0xA8,
                0xB2,
                0x1C,
                0xCA,
                0x11,
                0x5E,
                0x00,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountManagerForUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xE8,
                0xA6,
                0x56,
                0x8F,
                0xDB,
                0xAB,
                0x41,
                0xA6,
                0x5F,
                0x8C,
                0x59,
                0x71,
                0xAA,
                0xC9,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x89,
                0x9B,
                0x0D,
                0x28,
                0x19,
                0x20,
                0x4A,
                0x86,
                0xD5,
                0x3C,
                0x73,
                0x7F,
                0x7D,
                0xC3,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xED,
                0x3D,
                0x6A,
                0x6B,
                0x31,
                0x5E,
                0x43,
                0xB5,
                0x34,
                0xF7,
                0xD4,
                0xB4,
                0xB7,
                0xDB,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0xB0,
                0x73,
                0x20,
                0x0A,
                0x7D,
                0x76,
                0x4E,
                0xBF,
                0x45,
                0x23,
                0x68,
                0xF9,
                0x78,
                0xA5,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountStore2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0xAE,
                0xE0,
                0xB1,
                0x60,
                0x95,
                0x31,
                0x46,
                0x8A,
                0xF0,
                0x06,
                0x1D,
                0x30,
                0x16,
                0x14,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountStore3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0xC0,
                0x42,
                0x81,
                0xC9,
                0xF3,
                0x8B,
                0x47,
                0xB1,
                0x17,
                0x65,
                0x85,
                0xBE,
                0xBB,
                0x67,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountStoreChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0xE2,
                0xE3,
                0x84,
                0x20,
                0x88,
                0x12,
                0x45,
                0xB1,
                0xF6,
                0x2E,
                0x03,
                0x5B,
                0xE1,
                0x07,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
