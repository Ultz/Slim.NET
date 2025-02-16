// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class CLSID
{
    public static ref readonly Guid CLSID_AppxFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xA1,
                0x42,
                0x58,
                0x9F,
                0xFF,
                0x66,
                0x41,
                0x8F,
                0x5C,
                0x62,
                0xF5,
                0xB7,
                0xB0,
                0xC7,
                0x81,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_AppxBundleFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x04,
                0x8E,
                0x37,
                0x84,
                0x52,
                0xB7,
                0x43,
                0x88,
                0x77,
                0xE7,
                0xDB,
                0xDD,
                0x88,
                0x34,
                0x46,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_AppxPackagingDiagnosticEventSinkManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x0A,
                0xCA,
                0x50,
                0x88,
                0x15,
                0x61,
                0x41,
                0x8E,
                0xD2,
                0xEF,
                0x9E,
                0x46,
                0x9C,
                0xED,
                0x5D,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_AppxEncryptionFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x4F,
                0x66,
                0xDC,
                0x68,
                0xD8,
                0xEE,
                0x46,
                0x87,
                0x80,
                0x8D,
                0x19,
                0x6C,
                0xB7,
                0x39,
                0xF7,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid CLSID_AppxPackageEditor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0xF2,
                0x04,
                0xF0,
                0xBC,
                0xAE,
                0x0D,
                0x4B,
                0xBF,
                0x58,
                0xE5,
                0x16,
                0xD5,
                0xBC,
                0xC0,
                0xAB,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
