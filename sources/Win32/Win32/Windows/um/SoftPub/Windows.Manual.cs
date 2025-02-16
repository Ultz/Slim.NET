// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class Windows
{
    public static ref readonly Guid WINTRUST_ACTION_GENERIC_VERIFY_V2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0xC5,
                0xAA,
                0x00,
                0x44,
                0xCD,
                0xD0,
                0x11,
                0x8C,
                0xC2,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0x95,
                0xEE,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WINTRUST_ACTION_TRUSTPROVIDER_TEST
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x31,
                0x3E,
                0x57,
                0xBA,
                0xDD,
                0xD0,
                0x11,
                0x8C,
                0xCB,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0x95,
                0xEE,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WINTRUST_ACTION_GENERIC_CHAIN_VERIFY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x1C,
                0x45,
                0xFC,
                0x75,
                0xAC,
                0xD1,
                0x11,
                0xB4,
                0xB8,
                0x00,
                0xC0,
                0x4F,
                0xB6,
                0x6E,
                0xA0,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid HTTPSPROV_ACTION
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x31,
                0x3E,
                0x57,
                0xBA,
                0xAA,
                0xD0,
                0x11,
                0x8C,
                0xCB,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0x95,
                0xEE,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid OFFICESIGN_ACTION_VERIFY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0xC2,
                0x55,
                0x55,
                0xFB,
                0x17,
                0xD1,
                0x11,
                0x85,
                0xC4,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0x95,
                0xEE,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid DRIVER_ACTION_VERIFY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0xE6,
                0x50,
                0xF7,
                0xEE,
                0x38,
                0xD1,
                0x11,
                0x85,
                0xE5,
                0x00,
                0xC0,
                0x4F,
                0xC2,
                0x95,
                0xEE,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CONFIG_CI_ACTION_VERIFY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x06,
                0x78,
                0x60,
                0x22,
                0x8F,
                0x13,
                0x4B,
                0xBD,
                0x9B,
                0x5B,
                0x76,
                0x27,
                0x76,
                0xF3,
                0x86,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
