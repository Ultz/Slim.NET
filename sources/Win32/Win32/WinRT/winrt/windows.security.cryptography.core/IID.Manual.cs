// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAsymmetricAlgorithmNamesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0xFC,
                0xF6,
                0xCA,
                0xC0,
                0x67,
                0xAA,
                0x46,
                0x84,
                0xF9,
                0x75,
                0x2E,
                0x77,
                0x44,
                0x9F,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAsymmetricAlgorithmNamesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xC0,
                0x41,
                0xF1,
                0xFF,
                0x4B,
                0x23,
                0x4F,
                0xBA,
                0x66,
                0x60,
                0x45,
                0xB1,
                0x37,
                0xD5,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAsymmetricKeyAlgorithmProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0xFF,
                0xD2,
                0xE8,
                0x59,
                0x62,
                0x88,
                0x4E,
                0xB7,
                0xE0,
                0x94,
                0x19,
                0x1F,
                0xDE,
                0x69,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAsymmetricKeyAlgorithmProvider2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x2A,
                0x32,
                0x4E,
                0x4D,
                0x7C,
                0x97,
                0x49,
                0xAC,
                0x4F,
                0x1B,
                0x84,
                0x8B,
                0x36,
                0x30,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAsymmetricKeyAlgorithmProviderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0xDE,
                0x5B,
                0x42,
                0xF3,
                0xA7,
                0xA6,
                0x47,
                0xA8,
                0xD2,
                0xC4,
                0x8D,
                0x60,
                0x33,
                0xA6,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICryptographicEngineStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x06,
                0xEA,
                0x9F,
                0xF7,
                0x6F,
                0x85,
                0x4C,
                0xA0,
                0x95,
                0x95,
                0xEB,
                0x31,
                0x71,
                0x5E,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICryptographicEngineStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x48,
                0x59,
                0x67,
                0x9F,
                0xDF,
                0x91,
                0x41,
                0x92,
                0xC7,
                0x6C,
                0xE6,
                0xF5,
                0x84,
                0x20,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICryptographicKey
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x3B,
                0x2A,
                0xED,
                0x7B,
                0x8E,
                0x09,
                0x40,
                0x84,
                0x01,
                0xFF,
                0xD1,
                0xA6,
                0x2E,
                0xEB,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEccCurveNamesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x93,
                0xFF,
                0xB3,
                0xEB,
                0xAE,
                0x9E,
                0x40,
                0xB7,
                0xD4,
                0x9B,
                0x95,
                0x29,
                0x5A,
                0xAE,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEncryptedAndAuthenticatedData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x2F,
                0xA4,
                0x6F,
                0xCB,
                0x1E,
                0x00,
                0x4B,
                0xBE,
                0xA5,
                0x60,
                0xB8,
                0x3F,
                0x86,
                0x2F,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHashAlgorithmNamesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x05,
                0x5E,
                0x6B,
                0x96,
                0xDE,
                0x0A,
                0x4F,
                0x8D,
                0x57,
                0xDC,
                0xC9,
                0xDA,
                0xE3,
                0x6C,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHashAlgorithmProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x30,
                0x9B,
                0xBE,
                0xC3,
                0xB2,
                0x2B,
                0x42,
                0xBC,
                0xE1,
                0xEC,
                0x90,
                0xEF,
                0xB5,
                0xD7,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHashAlgorithmProviderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x97,
                0xAC,
                0x9F,
                0xC4,
                0x5C,
                0x36,
                0x43,
                0xAE,
                0x38,
                0x62,
                0x12,
                0xB7,
                0x5A,
                0x91,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHashComputation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xD1,
                0x04,
                0x59,
                0x31,
                0xAD,
                0x03,
                0x46,
                0xA3,
                0xA4,
                0xB1,
                0xBD,
                0xA9,
                0x8E,
                0x25,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyDerivationAlgorithmNamesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x36,
                0x6E,
                0x7B,
                0xD2,
                0x94,
                0x39,
                0x47,
                0xA5,
                0x7B,
                0x02,
                0x2E,
                0x0C,
                0x3A,
                0x40,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyDerivationAlgorithmNamesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x3F,
                0x95,
                0x57,
                0x44,
                0x60,
                0x6F,
                0x46,
                0x97,
                0xF4,
                0x33,
                0x7B,
                0x78,
                0x08,
                0x38,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyDerivationAlgorithmProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0xA8,
                0xFB,
                0xE1,
                0x71,
                0x46,
                0xB7,
                0x43,
                0x91,
                0x58,
                0x76,
                0x3A,
                0xAA,
                0x98,
                0xB6,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyDerivationAlgorithmProviderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0x09,
                0x22,
                0x0A,
                0x1C,
                0x0A,
                0x3B,
                0x44,
                0x94,
                0x18,
                0xB9,
                0x49,
                0x8A,
                0xEB,
                0x16,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyDerivationParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x59,
                0xF0,
                0x7B,
                0x7B,
                0x04,
                0x8C,
                0x4A,
                0x96,
                0x4A,
                0x46,
                0x9F,
                0xFD,
                0x55,
                0x22,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyDerivationParameters2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x66,
                0x41,
                0xCD,
                0x7E,
                0x41,
                0x4C,
                0x4F,
                0xB6,
                0x66,
                0xC0,
                0xD8,
                0x79,
                0xF3,
                0xF8,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyDerivationParametersStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x1F,
                0x96,
                0xEA,
                0x7F,
                0xF3,
                0x46,
                0x41,
                0x9D,
                0xFE,
                0xA4,
                0x56,
                0xF1,
                0x73,
                0x5F,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyDerivationParametersStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x3D,
                0x78,
                0xA5,
                0xE3,
                0x58,
                0xFB,
                0x4E,
                0xB2,
                0x83,
                0xA1,
                0x65,
                0x31,
                0x26,
                0xE1,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMacAlgorithmNamesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0x26,
                0x41,
                0x41,
                0x1E,
                0xFB,
                0xA4,
                0x43,
                0x89,
                0x5E,
                0xA9,
                0x02,
                0x6E,
                0x43,
                0x90,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMacAlgorithmProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0xC5,
                0x3F,
                0x4A,
                0xBD,
                0x1C,
                0xCE,
                0x41,
                0xA0,
                0x92,
                0xAA,
                0x0B,
                0xC5,
                0xD2,
                0xD2,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMacAlgorithmProvider2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x2A,
                0xA3,
                0x6D,
                0x31,
                0xD9,
                0xED,
                0x42,
                0x8E,
                0x7E,
                0xC3,
                0x01,
                0xCA,
                0xEE,
                0x11,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMacAlgorithmProviderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0xC1,
                0xBD,
                0xC9,
                0x77,
                0xCC,
                0xF0,
                0x4D,
                0x9E,
                0x4E,
                0xB9,
                0x21,
                0xE0,
                0x80,
                0x64,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPersistedKeyProviderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0x48,
                0x27,
                0x77,
                0xD4,
                0xD9,
                0xF5,
                0x4C,
                0xB6,
                0x68,
                0xE0,
                0x45,
                0x7D,
                0xF3,
                0x08,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISymmetricAlgorithmNamesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x72,
                0x70,
                0x68,
                0x96,
                0xC9,
                0xAE,
                0x4E,
                0x84,
                0xD7,
                0x79,
                0xB2,
                0xAE,
                0xB7,
                0x3B,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISymmetricKeyAlgorithmProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x4A,
                0x7E,
                0x3D,
                0xD0,
                0x3B,
                0x02,
                0x49,
                0x8A,
                0xC8,
                0x47,
                0x0D,
                0x50,
                0xD2,
                0x13,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISymmetricKeyAlgorithmProviderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x23,
                0x3B,
                0x8D,
                0x37,
                0x1F,
                0x1F,
                0x49,
                0xB6,
                0x0E,
                0xF5,
                0x43,
                0x1B,
                0x26,
                0xB4,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
