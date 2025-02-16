// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAppDisplayInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x11,
                0xEB,
                0x1A,
                0xD4,
                0xE4,
                0xAA,
                0x41,
                0xA4,
                0xF6,
                0xC4,
                0xA2,
                0x76,
                0xE7,
                0x9E,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x59,
                0x7F,
                0xCF,
                0x09,
                0x6A,
                0xE8,
                0x4D,
                0xA6,
                0xC0,
                0x57,
                0x92,
                0xD5,
                0x68,
                0x80,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x1F,
                0x4B,
                0xBE,
                0x98,
                0x20,
                0x1B,
                0x43,
                0xBD,
                0x25,
                0xB3,
                0x08,
                0x78,
                0x74,
                0x8D,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppInfo3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x8E,
                0xA7,
                0x09,
                0xA4,
                0x93,
                0xDE,
                0x46,
                0x93,
                0x97,
                0x08,
                0x43,
                0xB5,
                0x71,
                0x15,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppInfo4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0xBD,
                0x34,
                0x2F,
                0x09,
                0x16,
                0x54,
                0x45,
                0x9F,
                0x33,
                0x12,
                0xE1,
                0xE8,
                0x03,
                0xE0,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppInfoStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0x78,
                0x1F,
                0xCF,
                0x8B,
                0xE4,
                0x0C,
                0x4F,
                0x9B,
                0x0B,
                0x79,
                0xC3,
                0xF8,
                0x95,
                0x7D,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppInstallerInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x2A,
                0xAB,
                0x29,
                0xF6,
                0xD4,
                0xA3,
                0x42,
                0xAD,
                0xCD,
                0xD6,
                0x58,
                0x3C,
                0x65,
                0x95,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppInstallerInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x13,
                0x0F,
                0xD2,
                0x56,
                0x82,
                0x7C,
                0x59,
                0x85,
                0x11,
                0xC8,
                0x4E,
                0xC5,
                0x0D,
                0x5E,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppInstance
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x2B,
                0x5F,
                0x67,
                0x5F,
                0xF2,
                0x32,
                0x45,
                0x9F,
                0xD6,
                0x36,
                0x33,
                0xE0,
                0x63,
                0x4D,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppInstanceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0xE7,
                0x11,
                0x9D,
                0xA6,
                0x9E,
                0xAF,
                0x47,
                0xA6,
                0xEC,
                0x46,
                0x78,
                0x4C,
                0x5B,
                0xA2,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDesignModeStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x93,
                0x38,
                0x2C,
                0x1A,
                0xF8,
                0x7A,
                0x4E,
                0xB8,
                0x57,
                0x76,
                0xA8,
                0x08,
                0x87,
                0xE1,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDesignModeStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x81,
                0xCF,
                0x80,
                0x64,
                0xB0,
                0x58,
                0x48,
                0xBE,
                0xC8,
                0x3E,
                0xBA,
                0x22,
                0x35,
                0x75,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEnteredBackgroundEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0xDC,
                0x22,
                0xF7,
                0x27,
                0x98,
                0x3D,
                0x40,
                0xAA,
                0xED,
                0xEC,
                0xCA,
                0x9A,
                0xC1,
                0x73,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFindRelatedPackagesOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x7E,
                0xDD,
                0x41,
                0x35,
                0xB3,
                0x1F,
                0x52,
                0xB9,
                0x6C,
                0x5E,
                0xA0,
                0x7F,
                0x5B,
                0x73,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFindRelatedPackagesOptionsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0x72,
                0xD1,
                0xD7,
                0xFD,
                0xA4,
                0xC4,
                0x55,
                0x98,
                0xCF,
                0xF2,
                0x71,
                0x0B,
                0x7D,
                0x8B,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFullTrustProcessLaunchResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xD8,
                0x17,
                0x89,
                0xFB,
                0xED,
                0x5F,
                0x51,
                0x8E,
                0x22,
                0x5E,
                0xBC,
                0xEB,
                0x69,
                0xDF,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFullTrustProcessLauncherStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x83,
                0x84,
                0xD7,
                0x00,
                0x11,
                0x6B,
                0x3C,
                0xA4,
                0x55,
                0xF6,
                0x26,
                0x2C,
                0xC3,
                0x31,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFullTrustProcessLauncherStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0xD7,
                0x8E,
                0x8B,
                0x5C,
                0xB6,
                0xCF,
                0x56,
                0xA1,
                0xA7,
                0x2B,
                0xF7,
                0x7C,
                0xBC,
                0x6E,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILeavingBackgroundEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0xEC,
                0xC6,
                0x39,
                0x6E,
                0xAE,
                0xF9,
                0x46,
                0xA0,
                0x7A,
                0xCF,
                0xC2,
                0x3F,
                0x88,
                0x73,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILimitedAccessFeatureRequestResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x56,
                0x51,
                0xD4,
                0x24,
                0x1E,
                0xDD,
                0x5D,
                0xAB,
                0xB4,
                0x61,
                0x88,
                0xAB,
                0xA4,
                0xD5,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILimitedAccessFeaturesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x12,
                0xE6,
                0x8B,
                0x2B,
                0x30,
                0xBF,
                0x5F,
                0xA6,
                0x32,
                0x1A,
                0x99,
                0xE4,
                0x3E,
                0x89,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x79,
                0x3C,
                0x16,
                0x75,
                0xBD,
                0x3C,
                0x41,
                0xBF,
                0x23,
                0xB1,
                0xFE,
                0x7B,
                0x95,
                0xD8,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackage2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x2F,
                0x61,
                0xA6,
                0x88,
                0x76,
                0xCE,
                0x4A,
                0x95,
                0xFB,
                0x35,
                0x95,
                0x38,
                0xE7,
                0xAA,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackage3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x8B,
                0x73,
                0x5F,
                0x6A,
                0xF8,
                0x17,
                0x49,
                0x93,
                0xD1,
                0xF1,
                0xEE,
                0x9D,
                0x3B,
                0x35,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackage4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0xD1,
                0xAE,
                0x65,
                0x5B,
                0xB9,
                0x0C,
                0x45,
                0x88,
                0x2B,
                0x62,
                0x55,
                0x18,
                0x7F,
                0x39,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackage5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x2D,
                0x84,
                0x0E,
                0xAC,
                0xD9,
                0xED,
                0x45,
                0x9A,
                0x1E,
                0x74,
                0xCE,
                0x05,
                0x6B,
                0x26,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackage6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0xD9,
                0x1A,
                0x8B,
                0xD7,
                0x12,
                0x54,
                0x47,
                0xAE,
                0x4E,
                0x63,
                0x8C,
                0xBC,
                0x0E,
                0x3A,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackage7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0x8D,
                0xFF,
                0x86,
                0xE4,
                0xA2,
                0xE0,
                0x45,
                0x97,
                0x32,
                0x28,
                0x3A,
                0x6D,
                0x88,
                0xFD,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackage8
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x4F,
                0x58,
                0x2C,
                0x2A,
                0xCE,
                0xE6,
                0x4B,
                0xA0,
                0x93,
                0x77,
                0xCF,
                0xBB,
                0x2A,
                0x7E,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackage9
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0x22,
                0xAB,
                0xD5,
                0xE1,
                0xD7,
                0xEC,
                0x49,
                0x90,
                0xCE,
                0x72,
                0x0C,
                0xDB,
                0xD0,
                0x2E,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageCatalog
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x37,
                0x0A,
                0x23,
                0xE3,
                0x9D,
                0x45,
                0x44,
                0xBE,
                0x74,
                0x91,
                0xFB,
                0x32,
                0x5A,
                0xBE,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageCatalog2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0x0C,
                0xA6,
                0x96,
                0xF7,
                0x8F,
                0x44,
                0x43,
                0xB6,
                0xBF,
                0xEE,
                0x64,
                0xC2,
                0x20,
                0x7E,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageCatalog3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x5C,
                0xDD,
                0x96,
                0x37,
                0x88,
                0xF9,
                0x43,
                0x90,
                0x15,
                0x03,
                0x34,
                0x34,
                0xBA,
                0x14,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageCatalog4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x39,
                0x7C,
                0xC3,
                0xCC,
                0x44,
                0x7B,
                0x4B,
                0x8B,
                0xAF,
                0x79,
                0x6C,
                0x04,
                0xEA,
                0xD3,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageCatalogAddOptionalPackageResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x0C,
                0xF1,
                0x3B,
                0xDF,
                0xB4,
                0xB3,
                0x47,
                0xA9,
                0x63,
                0xE2,
                0xFA,
                0x83,
                0x2F,
                0x7D,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageCatalogAddResourcePackageResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xCE,
                0x36,
                0x96,
                0x17,
                0x3E,
                0x3F,
                0x49,
                0xAA,
                0x08,
                0xCC,
                0xEC,
                0x6F,
                0xDE,
                0xF6,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageCatalogRemoveOptionalPackagesResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xF9,
                0xD2,
                0x29,
                0x74,
                0xD9,
                0x64,
                0x4E,
                0x93,
                0x59,
                0x22,
                0xCA,
                0xDF,
                0xD7,
                0x98,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageCatalogRemoveResourcePackagesResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x97,
                0x71,
                0xAE,
                0x52,
                0x1A,
                0x21,
                0x43,
                0x87,
                0xB3,
                0xE5,
                0xA1,
                0xA1,
                0x79,
                0x81,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageCatalogStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x96,
                0x8C,
                0xA1,
                0x5B,
                0xE6,
                0x34,
                0x46,
                0xBA,
                0x21,
                0x5E,
                0x63,
                0xEB,
                0x72,
                0x44,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageCatalogStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0xC1,
                0x11,
                0x4C,
                0x28,
                0x9A,
                0x8C,
                0x59,
                0xB1,
                0x85,
                0x55,
                0xE1,
                0x89,
                0x9B,
                0x2B,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageContentGroup
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x69,
                0x62,
                0x8F,
                0x0A,
                0x12,
                0x98,
                0x47,
                0xB5,
                0xE1,
                0x58,
                0x00,
                0xDD,
                0xA8,
                0xF2,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageContentGroupStagingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0xC2,
                0x7B,
                0x3D,
                0x27,
                0x6F,
                0x6C,
                0x44,
                0x98,
                0x6E,
                0xD4,
                0x73,
                0x3D,
                0x4D,
                0x91,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageContentGroupStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x76,
                0xEE,
                0x70,
                0x12,
                0x5F,
                0x92,
                0x4B,
                0xB9,
                0xEA,
                0x6C,
                0xCA,
                0xDA,
                0x13,
                0xBC,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x66,
                0xDB,
                0x1A,
                0xC7,
                0x37,
                0x90,
                0x47,
                0x99,
                0x80,
                0xDD,
                0x7A,
                0xE7,
                0x4E,
                0x8B,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageIdWithMetadata
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x7A,
                0x57,
                0x40,
                0x9E,
                0x0C,
                0x3D,
                0x44,
                0x90,
                0x74,
                0x85,
                0x5F,
                0x5C,
                0xE0,
                0xA0,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageInstallingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x1E,
                0x74,
                0x97,
                0x7A,
                0xAB,
                0x1A,
                0x40,
                0x8B,
                0x61,
                0xEB,
                0x0E,
                0x7F,
                0xAF,
                0xF2,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageStagingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x68,
                0x41,
                0x10,
                0xE2,
                0x54,
                0x51,
                0x4F,
                0xB8,
                0x28,
                0x9E,
                0xF7,
                0x04,
                0x6C,
                0x21,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x4B,
                0x53,
                0x4E,
                0x60,
                0x29,
                0x78,
                0x48,
                0x97,
                0xA4,
                0x96,
                0x24,
                0xDE,
                0xB7,
                0x2F,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageStatus
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x4F,
                0xE7,
                0x5F,
                0x65,
                0xA3,
                0x09,
                0x4C,
                0xA0,
                0x2D,
                0x04,
                0x6D,
                0x52,
                0x5E,
                0xA1,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageStatus2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0xFA,
                0x28,
                0xF4,
                0x56,
                0x7C,
                0x62,
                0x48,
                0xAC,
                0xFA,
                0xAB,
                0xAE,
                0xDC,
                0xC0,
                0x69,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageStatusChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x71,
                0x7D,
                0x43,
                0x80,
                0xBD,
                0x70,
                0x4A,
                0xBC,
                0x50,
                0xF6,
                0xE7,
                0x96,
                0x50,
                0x95,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageUninstallingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0xAA,
                0x43,
                0x44,
                0x22,
                0xAB,
                0xCD,
                0x44,
                0x82,
                0xBB,
                0x4E,
                0xC9,
                0xB8,
                0x27,
                0x36,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageUpdateAvailabilityResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x50,
                0x4E,
                0x11,
                0x9A,
                0x19,
                0xA1,
                0x48,
                0xA0,
                0x79,
                0x31,
                0x3C,
                0x45,
                0x63,
                0x4A,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageUpdatingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x42,
                0x7B,
                0xCD,
                0x74,
                0xFD,
                0x3E,
                0x44,
                0xB1,
                0x14,
                0x23,
                0xE6,
                0x77,
                0xB0,
                0xE8,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPackageWithMetadata
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x97,
                0x94,
                0x95,
                0xE9,
                0x1D,
                0xF2,
                0x40,
                0xB4,
                0x52,
                0x0D,
                0xE9,
                0xF1,
                0x91,
                0x00,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStartupTask
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x23,
                0x5C,
                0xF7,
                0xF2,
                0xB5,
                0x6C,
                0x4F,
                0x88,
                0xDD,
                0x36,
                0xCB,
                0x1D,
                0x59,
                0x9D,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStartupTaskStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x60,
                0x5B,
                0xEE,
                0x48,
                0xA1,
                0xA7,
                0x41,
                0xB2,
                0x6E,
                0xE8,
                0xB8,
                0x8A,
                0x1E,
                0x62,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISuspendingDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x05,
                0x14,
                0x59,
                0xC9,
                0x8B,
                0xB4,
                0x4E,
                0xB6,
                0x36,
                0xDA,
                0xBD,
                0xC4,
                0xF4,
                0x6F,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISuspendingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x1C,
                0x06,
                0x96,
                0xBA,
                0x2D,
                0x08,
                0x4D,
                0xB0,
                0xBD,
                0x2B,
                0x30,
                0xA1,
                0x31,
                0xC6,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISuspendingOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xCA,
                0xA4,
                0x9D,
                0xE1,
                0x20,
                0x9B,
                0x4E,
                0x9F,
                0x65,
                0xA9,
                0xF4,
                0x35,
                0x34,
                0x0C,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
