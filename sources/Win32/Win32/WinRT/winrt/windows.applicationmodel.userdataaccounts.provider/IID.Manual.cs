// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdataaccounts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IUserDataAccountPartnerAccountInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x00,
                0x20,
                0x5F,
                0xEF,
                0xF6,
                0xC3,
                0x4E,
                0x86,
                0x30,
                0x01,
                0x2C,
                0x59,
                0xC1,
                0x14,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountProviderAddAccountOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x25,
                0xC7,
                0xB9,
                0x84,
                0x3F,
                0x5D,
                0x4B,
                0x8E,
                0xAA,
                0x45,
                0xE9,
                0x7A,
                0xA8,
                0x42,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountProviderOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0xAD,
                0x0A,
                0xA2,
                0x8C,
                0x88,
                0x62,
                0x4A,
                0xA3,
                0xDD,
                0x34,
                0xD0,
                0x7A,
                0x80,
                0x2B,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountProviderResolveErrorsOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0xDC,
                0x35,
                0x62,
                0xCB,
                0xBF,
                0xE1,
                0x41,
                0x99,
                0x57,
                0x97,
                0x59,
                0xA2,
                0x88,
                0x46,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountProviderSettingsOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x4D,
                0x03,
                0x92,
                0x48,
                0x86,
                0x30,
                0x4F,
                0xAC,
                0xFA,
                0x30,
                0x02,
                0x65,
                0x8C,
                0xA8,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
