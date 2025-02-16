// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ICertificate
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x74,
                0x3F,
                0x33,
                0xD8,
                0x04,
                0xB3,
                0x43,
                0xB2,
                0x78,
                0x8C,
                0x5F,
                0xCC,
                0x9B,
                0xE5,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificate2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x37,
                0xB8,
                0x17,
                0x25,
                0x8A,
                0x96,
                0x4D,
                0xA4,
                0x92,
                0x8F,
                0xC2,
                0x9A,
                0xC4,
                0xFD,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificate3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0xA9,
                0x51,
                0xBE,
                0x5F,
                0xAE,
                0x52,
                0x46,
                0xAC,
                0xE7,
                0xC6,
                0xD7,
                0xE7,
                0x72,
                0x4C,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateChain
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x53,
                0xBF,
                0x20,
                0x91,
                0x36,
                0x01,
                0x45,
                0xA6,
                0x2C,
                0xFD,
                0x97,
                0x27,
                0x8B,
                0x31,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateEnrollmentManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0xEF,
                0x46,
                0x88,
                0x86,
                0xA9,
                0xFB,
                0x48,
                0x9F,
                0xD7,
                0x9A,
                0xEC,
                0x06,
                0x93,
                0x5B,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateEnrollmentManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x1C,
                0x5B,
                0xDC,
                0x29,
                0x64,
                0x14,
                0x40,
                0x99,
                0x9C,
                0x5D,
                0x97,
                0x35,
                0x80,
                0x2D,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateEnrollmentManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x82,
                0xEC,
                0xFD,
                0x7C,
                0x61,
                0x5A,
                0x42,
                0xB7,
                0x2D,
                0x39,
                0x8B,
                0x26,
                0xAC,
                0x72,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateExtension
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x06,
                0xCF,
                0x84,
                0xE6,
                0xA9,
                0x4D,
                0x45,
                0x8E,
                0x45,
                0x2E,
                0xA7,
                0xC4,
                0xBC,
                0xD5,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x22,
                0xB4,
                0x17,
                0xAF,
                0x4B,
                0xA2,
                0x44,
                0x96,
                0x08,
                0x04,
                0xFB,
                0x62,
                0xB1,
                0x69,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateKeyUsages
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x20,
                0xC6,
                0x6A,
                0xCF,
                0xE1,
                0x6A,
                0x48,
                0xB4,
                0x85,
                0xA6,
                0x9C,
                0x83,
                0xE4,
                0x6F,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateQuery
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0x2A,
                0x08,
                0x5B,
                0x28,
                0xA7,
                0x16,
                0x49,
                0xB5,
                0xEE,
                0xFF,
                0xCB,
                0x8A,
                0xCF,
                0x24,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateQuery2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x0A,
                0x5A,
                0x93,
                0xD9,
                0x0B,
                0x75,
                0x4F,
                0xB8,
                0xC2,
                0xE2,
                0x7A,
                0x7F,
                0x74,
                0xEE,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateRequestProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x84,
                0x7E,
                0x48,
                0xE2,
                0x94,
                0xCE,
                0x4D,
                0x88,
                0x33,
                0x1A,
                0x70,
                0x0A,
                0x37,
                0xA2,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateRequestProperties2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xC9,
                0xA0,
                0x3D,
                0x3F,
                0xD7,
                0xF3,
                0x4F,
                0xA0,
                0xA6,
                0x06,
                0x77,
                0xC0,
                0xAD,
                0xA0,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateRequestProperties3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0xF6,
                0x87,
                0xE6,
                0x4D,
                0x73,
                0xB1,
                0x46,
                0x9D,
                0x4C,
                0x6E,
                0xDF,
                0xDB,
                0xFC,
                0x84,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateRequestProperties4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x9A,
                0x42,
                0x4E,
                0x61,
                0x1C,
                0xEA,
                0x4F,
                0xB8,
                0xFE,
                0x13,
                0x5F,
                0xB1,
                0x9C,
                0xDC,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0xF7,
                0xBF,
                0xB0,
                0x4E,
                0x34,
                0x31,
                0x43,
                0xAF,
                0x14,
                0xA7,
                0xF7,
                0xA7,
                0xEB,
                0xC9,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateStore2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x8E,
                0xE6,
                0xC7,
                0x7D,
                0x41,
                0x1A,
                0x4D,
                0xBA,
                0xBD,
                0x15,
                0x68,
                0x7E,
                0x54,
                0x99,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateStoresStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0xC7,
                0xEC,
                0xFB,
                0xFE,
                0xC6,
                0xE7,
                0x4D,
                0x99,
                0xCF,
                0x74,
                0xC3,
                0xE5,
                0x96,
                0xE0,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICertificateStoresStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x0B,
                0x90,
                0xFA,
                0xD4,
                0xA0,
                0x8C,
                0x4B,
                0xBC,
                0x55,
                0xC0,
                0xA3,
                0x7E,
                0xB1,
                0x41,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IChainBuildingParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0xA9,
                0x2B,
                0x42,
                0x8D,
                0x7C,
                0xB7,
                0x47,
                0xB5,
                0x9B,
                0xB1,
                0x27,
                0x03,
                0x73,
                0x3A,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IChainValidationParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x3B,
                0x74,
                0xC4,
                0xB0,
                0x7E,
                0x56,
                0x4B,
                0xA0,
                0x40,
                0xB9,
                0xC8,
                0xE6,
                0x55,
                0xDD,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICmsAttachedSignature
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x9D,
                0x89,
                0x61,
                0x57,
                0x37,
                0xCB,
                0x4E,
                0xBD,
                0xDC,
                0x0C,
                0xA3,
                0x57,
                0xD7,
                0xA9,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICmsAttachedSignatureFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0xFC,
                0xC8,
                0xD0,
                0x57,
                0xF7,
                0x64,
                0x4C,
                0xA3,
                0x62,
                0x52,
                0xCC,
                0x1C,
                0x77,
                0xCF,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICmsAttachedSignatureStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8E,
                0x9C,
                0x98,
                0x87,
                0xAD,
                0xB0,
                0x8D,
                0x49,
                0xA7,
                0xF5,
                0x78,
                0xB5,
                0x9B,
                0xCE,
                0x4B,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICmsDetachedSignature
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xF1,
                0x1E,
                0x0F,
                0x5E,
                0xF6,
                0x36,
                0x45,
                0x83,
                0x39,
                0x59,
                0x44,
                0x08,
                0x1D,
                0xB2,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICmsDetachedSignatureFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x35,
                0xAB,
                0xC4,
                0x7F,
                0xAE,
                0x87,
                0x43,
                0xAD,
                0x19,
                0x00,
                0xF1,
                0x50,
                0xE4,
                0x8E,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICmsDetachedSignatureStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x4C,
                0x11,
                0x3D,
                0x9B,
                0xBF,
                0x82,
                0x46,
                0x9B,
                0xE6,
                0x91,
                0xF5,
                0x7C,
                0x05,
                0x38,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICmsSignerInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x20,
                0xD0,
                0x50,
                0x2F,
                0x1D,
                0x1A,
                0x4C,
                0xB5,
                0xC5,
                0xD0,
                0x18,
                0x8F,
                0xF9,
                0x1F,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICmsTimestampInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x00,
                0x5F,
                0x2F,
                0x18,
                0x2C,
                0x88,
                0x4F,
                0x84,
                0x35,
                0xC5,
                0x34,
                0x08,
                0x60,
                0x76,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyAlgorithmNamesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x65,
                0x90,
                0x47,
                0xC7,
                0x7A,
                0x81,
                0x45,
                0x8C,
                0x3B,
                0xD0,
                0x70,
                0x27,
                0x14,
                0x04,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyAlgorithmNamesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x56,
                0x9B,
                0xC9,
                0xFD,
                0xE1,
                0x4A,
                0x4A,
                0x89,
                0x3D,
                0xA2,
                0x6F,
                0x33,
                0xDD,
                0x8B,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyAttestationHelperStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xE2,
                0x48,
                0x16,
                0x44,
                0xF6,
                0x26,
                0x43,
                0x88,
                0xBE,
                0x3A,
                0xF1,
                0x02,
                0xD3,
                0x0E,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyAttestationHelperStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0x0B,
                0x59,
                0x9C,
                0xC6,
                0xA6,
                0x5E,
                0x4A,
                0x9E,
                0x64,
                0xE8,
                0x5D,
                0x52,
                0x79,
                0xDF,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyStorageProviderNamesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x6A,
                0x18,
                0xAF,
                0x29,
                0x55,
                0x02,
                0x46,
                0xBD,
                0x94,
                0x0A,
                0xAB,
                0x91,
                0x95,
                0x7B,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyStorageProviderNamesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x74,
                0x2D,
                0x26,
                0x2E,
                0x9C,
                0xCC,
                0x41,
                0x88,
                0x12,
                0xC4,
                0xD9,
                0x71,
                0xDD,
                0x7C,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPfxImportParameters
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x35,
                0x0D,
                0x68,
                0x08,
                0x9A,
                0xC8,
                0x47,
                0x86,
                0x4A,
                0x2E,
                0xDD,
                0x4D,
                0x8E,
                0xB4,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStandardCertificateStoreNamesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x4A,
                0x15,
                0x0C,
                0x96,
                0xA4,
                0xF8,
                0x41,
                0x8F,
                0xE5,
                0x9E,
                0x96,
                0xF3,
                0x6E,
                0xFB,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISubjectAlternativeNameInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x59,
                0x28,
                0x58,
                0x9D,
                0x56,
                0x20,
                0x4C,
                0xBE,
                0x7B,
                0x4E,
                0x1C,
                0x9A,
                0x0B,
                0xC5,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISubjectAlternativeNameInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x78,
                0x7A,
                0x43,
                0x51,
                0x1C,
                0xEA,
                0x41,
                0xB3,
                0x4A,
                0x3D,
                0x65,
                0x43,
                0x98,
                0xA3,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserCertificateEnrollmentManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x37,
                0x31,
                0x96,
                0xE1,
                0x22,
                0x19,
                0x48,
                0xB2,
                0x0B,
                0xAB,
                0x46,
                0xA6,
                0xEC,
                0xA0,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserCertificateEnrollmentManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x9C,
                0xAD,
                0x0D,
                0xDE,
                0x65,
                0x2A,
                0x49,
                0xB8,
                0x6D,
                0xFC,
                0x5C,
                0x48,
                0x2C,
                0x37,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserCertificateStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x1D,
                0xFB,
                0xC9,
                0x9F,
                0x78,
                0x4E,
                0x4B,
                0x91,
                0x80,
                0x04,
                0x5A,
                0x75,
                0x7A,
                0xAC,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
