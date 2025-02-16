// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class Windows
{
    public static ReadOnlySpan<byte> SpcSerializedObjectAttributesClassId =>
        [
            0xA6,
            0xB5,
            0x86,
            0xD5,
            0xB4,
            0xA1,
            0x24,
            0x66,
            0xAE,
            0x05,
            0xA2,
            0x17,
            0xDA,
            0x8E,
            0x60,
            0xD6,
        ];
    public static ref readonly Guid WIN_TRUST_SUBJTYPE_RAW_FILE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xC4,
                0x9D,
                0x95,
                0x9E,
                0x8D,
                0xCF,
                0x11,
                0x87,
                0x36,
                0x00,
                0xAA,
                0x00,
                0xA4,
                0x85,
                0xEB,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_TRUST_SUBJTYPE_PE_IMAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xA1,
                0xC9,
                0x43,
                0xA0,
                0x8D,
                0xCF,
                0x11,
                0x87,
                0x36,
                0x00,
                0xAA,
                0x00,
                0xA4,
                0x85,
                0xEB,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_TRUST_SUBJTYPE_JAVA_CLASS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x39,
                0xAD,
                0x08,
                0xA1,
                0x8D,
                0xCF,
                0x11,
                0x87,
                0x36,
                0x00,
                0xAA,
                0x00,
                0xA4,
                0x85,
                0xEB,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_TRUST_SUBJTYPE_CABINET
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x53,
                0x7C,
                0xD1,
                0x92,
                0xA3,
                0xCF,
                0x11,
                0x9D,
                0xF5,
                0x00,
                0xAA,
                0x00,
                0xC1,
                0x84,
                0xE0,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_TRUST_SUBJTYPE_RAW_FILEEX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x81,
                0x45,
                0x6F,
                0xF1,
                0xC2,
                0xCF,
                0x11,
                0x8A,
                0x69,
                0x00,
                0xAA,
                0x00,
                0x6C,
                0x37,
                0x06,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_TRUST_SUBJTYPE_PE_IMAGEEX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x81,
                0x45,
                0x6F,
                0xF1,
                0xC2,
                0xCF,
                0x11,
                0x8A,
                0x69,
                0x00,
                0xAA,
                0x00,
                0x6C,
                0x37,
                0x06,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_TRUST_SUBJTYPE_JAVA_CLASSEX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x81,
                0x45,
                0x6F,
                0xF1,
                0xC2,
                0xCF,
                0x11,
                0x8A,
                0x69,
                0x00,
                0xAA,
                0x00,
                0x6C,
                0x37,
                0x06,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_TRUST_SUBJTYPE_CABINETEX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0x81,
                0x45,
                0x6F,
                0xF1,
                0xC2,
                0xCF,
                0x11,
                0x8A,
                0x69,
                0x00,
                0xAA,
                0x00,
                0x6C,
                0x37,
                0x06,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_TRUST_SUBJTYPE_OLE_STORAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xE7,
                0x57,
                0xC2,
                0xA0,
                0x8D,
                0xCF,
                0x11,
                0x87,
                0x36,
                0x00,
                0xAA,
                0x00,
                0xA4,
                0x85,
                0xEB,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_SPUB_ACTION_TRUSTED_PUBLISHER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x67,
                0x42,
                0x66,
                0xA1,
                0x8D,
                0xCF,
                0x11,
                0x87,
                0x36,
                0x00,
                0xAA,
                0x00,
                0xA4,
                0x85,
                0xEB,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_SPUB_ACTION_NT_ACTIVATE_IMAGE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x6B,
                0xC9,
                0x8B,
                0xA1,
                0x8D,
                0xCF,
                0x11,
                0x87,
                0x36,
                0x00,
                0xAA,
                0x00,
                0xA4,
                0x85,
                0xEB,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid WIN_SPUB_ACTION_PUBLISHED_SOFTWARE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xD1,
                0xB9,
                0x64,
                0xA2,
                0x8D,
                0xCF,
                0x11,
                0x87,
                0x36,
                0x00,
                0xAA,
                0x00,
                0xA4,
                0x85,
                0xEB,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
