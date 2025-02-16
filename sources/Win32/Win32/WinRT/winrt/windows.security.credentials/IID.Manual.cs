// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ICredentialFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x13,
                0xEF,
                0x54,
                0x26,
                0xBF,
                0xB5,
                0x47,
                0x97,
                0xDD,
                0xDE,
                0x77,
                0x9B,
                0x7C,
                0xAD,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyCredential
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0xEF,
                0x85,
                0x95,
                0x7B,
                0x45,
                0x47,
                0x48,
                0xB1,
                0x1A,
                0xFA,
                0x96,
                0x0B,
                0xBD,
                0xB1,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyCredentialAttestationResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xB3,
                0xAA,
                0x78,
                0xC1,
                0xA3,
                0x03,
                0x41,
                0xB6,
                0xCC,
                0x47,
                0x2C,
                0x44,
                0x17,
                0x1C,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyCredentialManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x46,
                0xAC,
                0x6A,
                0xF1,
                0x0E,
                0xE0,
                0x4C,
                0x82,
                0x90,
                0x41,
                0x06,
                0xDA,
                0x6A,
                0x63,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyCredentialOperationResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x86,
                0x37,
                0xF5,
                0x61,
                0x52,
                0xDD,
                0x4C,
                0x97,
                0x6D,
                0xCC,
                0x90,
                0x9A,
                0xC7,
                0x16,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyCredentialRetrievalResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x77,
                0xCD,
                0x58,
                0x87,
                0x8D,
                0x49,
                0x42,
                0x9B,
                0x58,
                0xF6,
                0x59,
                0x8C,
                0xC9,
                0x64,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPasswordCredential
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0x89,
                0xB1,
                0x6A,
                0x20,
                0xC7,
                0xA7,
                0x41,
                0xA6,
                0xC1,
                0xFE,
                0xAD,
                0xB3,
                0x63,
                0x29,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPasswordVault
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0x2C,
                0xFD,
                0x61,
                0xD4,
                0xC8,
                0xC1,
                0x48,
                0xA5,
                0x4F,
                0xBC,
                0x5A,
                0x64,
                0x20,
                0x5A,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccount
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x3E,
                0x47,
                0x69,
                0x31,
                0x80,
                0xBE,
                0x49,
                0x80,
                0xBB,
                0x96,
                0xCB,
                0x46,
                0xD9,
                0x9A,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccount2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xD6,
                0x56,
                0x7B,
                0x0B,
                0x99,
                0xB5,
                0x4E,
                0x94,
                0xA7,
                0x56,
                0x21,
                0xF3,
                0xA8,
                0xB8,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0xFB,
                0x9A,
                0xAC,
                0xE9,
                0x1D,
                0x92,
                0x4E,
                0xB7,
                0x8F,
                0x05,
                0x81,
                0xA8,
                0x7F,
                0x6E,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0xC8,
                0xDC,
                0x29,
                0xB9,
                0x7A,
                0x7C,
                0x4A,
                0xA3,
                0x36,
                0xB9,
                0x42,
                0xF9,
                0xDB,
                0xF7,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProvider2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0xEB,
                0x01,
                0x4A,
                0x42,
                0x4E,
                0xD4,
                0x41,
                0xB5,
                0x18,
                0xE0,
                0x08,
                0xA5,
                0x16,
                0x36,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProvider3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x51,
                0x1C,
                0xDA,
                0x0D,
                0x97,
                0x49,
                0x4D,
                0x82,
                0x5C,
                0xF2,
                0x70,
                0x6F,
                0x8C,
                0xA7,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProvider4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xD8,
                0x8F,
                0x71,
                0x96,
                0xE7,
                0x10,
                0x42,
                0xB7,
                0x4E,
                0x84,
                0xD2,
                0x98,
                0x94,
                0xB0,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x7D,
                0x76,
                0x1D,
                0xE1,
                0xE1,
                0x9A,
                0x4B,
                0xA7,
                0x74,
                0x5C,
                0x7C,
                0x7E,
                0x3B,
                0xF3,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
