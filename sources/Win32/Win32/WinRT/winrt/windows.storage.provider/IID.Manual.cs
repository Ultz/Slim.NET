// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IStorageProviderKnownFolderSyncRequestedHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0xB4,
                0xCB,
                0xC4,
                0xDD,
                0x13,
                0x8E,
                0x5C,
                0x8B,
                0x96,
                0x33,
                0x6F,
                0xC3,
                0x0C,
                0x62,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICachedFileUpdaterStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x09,
                0xC9,
                0x9F,
                0xCF,
                0x7B,
                0x88,
                0x48,
                0xA8,
                0x1E,
                0x10,
                0x2D,
                0x70,
                0x34,
                0xD7,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICachedFileUpdaterUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x41,
                0x6F,
                0x9E,
                0xF2,
                0xBA,
                0x97,
                0x4A,
                0xB6,
                0x00,
                0x93,
                0x33,
                0xF5,
                0xDF,
                0x80,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICachedFileUpdaterUI2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0xA2,
                0x56,
                0x88,
                0x99,
                0x86,
                0x40,
                0x43,
                0x9F,
                0x49,
                0xF7,
                0xCA,
                0xD7,
                0xFE,
                0x89,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileUpdateRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0x25,
                0xC8,
                0x40,
                0xFE,
                0xC1,
                0x93,
                0x4D,
                0xA7,
                0x92,
                0x1E,
                0x73,
                0x6B,
                0xC7,
                0x08,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileUpdateRequest2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x46,
                0x48,
                0x82,
                0xBE,
                0xBD,
                0x7B,
                0x44,
                0xA2,
                0xEE,
                0x7A,
                0xFE,
                0x6A,
                0x03,
                0x2A,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileUpdateRequestDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xDB,
                0xCE,
                0xFF,
                0xDE,
                0x8A,
                0xA5,
                0x44,
                0xBB,
                0x00,
                0x16,
                0x4C,
                0x4E,
                0x72,
                0xF1,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileUpdateRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x93,
                0x0A,
                0x7B,
                0x05,
                0x39,
                0x8D,
                0x43,
                0xAA,
                0xEF,
                0x78,
                0xAE,
                0x26,
                0x5F,
                0x8D,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderFileTypeInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0xB9,
                0x55,
                0x19,
                0x84,
                0x01,
                0x88,
                0x5A,
                0x87,
                0xDF,
                0x45,
                0x44,
                0xF4,
                0x64,
                0x36,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderFileTypeInfoFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x2C,
                0xA1,
                0x3F,
                0xE6,
                0xCC,
                0x5D,
                0x5D,
                0x80,
                0xB1,
                0x38,
                0x9E,
                0x7C,
                0xF9,
                0x2D,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderGetContentInfoForPathResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x71,
                0x64,
                0x25,
                0x89,
                0xAA,
                0x12,
                0x4D,
                0x82,
                0xE3,
                0xF7,
                0x2A,
                0x92,
                0xE3,
                0x39,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderGetPathForContentUriResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x1A,
                0x71,
                0x63,
                0x18,
                0x41,
                0xA6,
                0x45,
                0xAC,
                0xB6,
                0x22,
                0xC4,
                0x9D,
                0x01,
                0x9F,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderItemPropertiesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0x1C,
                0x2C,
                0x2D,
                0x04,
                0x27,
                0x29,
                0x47,
                0x8F,
                0xA9,
                0x7E,
                0x6B,
                0x8E,
                0x15,
                0x8C,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderItemProperty
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xB5,
                0x6C,
                0x47,
                0x0B,
                0x73,
                0x88,
                0x41,
                0xB7,
                0xB5,
                0x63,
                0xB7,
                0x16,
                0xED,
                0x47,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderItemPropertyDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x83,
                0xB3,
                0xC5,
                0x1F,
                0xFF,
                0x98,
                0x42,
                0x83,
                0x1E,
                0xFF,
                0x1C,
                0x08,
                0x08,
                0x96,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderItemPropertySource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x9C,
                0x6F,
                0x8F,
                0x32,
                0xF6,
                0x9B,
                0x4A,
                0x8D,
                0x99,
                0xD2,
                0xD7,
                0xA1,
                0x1D,
                0xF5,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderKnownFolderEntry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x7D,
                0xFA,
                0xEF,
                0x44,
                0x1D,
                0x6B,
                0x59,
                0x84,
                0x64,
                0x92,
                0x88,
                0x00,
                0xC5,
                0xE2,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderKnownFolderSyncInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x17,
                0xB0,
                0x98,
                0xC1,
                0xFF,
                0x11,
                0x5B,
                0xAE,
                0x77,
                0xCC,
                0x17,
                0xAF,
                0xEC,
                0x10,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderKnownFolderSyncInfoSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x93,
                0x35,
                0x51,
                0xC0,
                0xF7,
                0xD0,
                0x53,
                0xBB,
                0xB6,
                0x1C,
                0xDC,
                0x09,
                0x8E,
                0xBD,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderKnownFolderSyncInfoSourceFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x03,
                0xEE,
                0xAA,
                0xF6,
                0xA7,
                0xBE,
                0x50,
                0xA9,
                0xB0,
                0x8E,
                0x82,
                0xD0,
                0xC8,
                0x10,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderKnownFolderSyncRequestArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xD5,
                0xA6,
                0xED,
                0xE8,
                0xB4,
                0x2F,
                0x54,
                0xAB,
                0x8D,
                0xF3,
                0x61,
                0x3F,
                0x25,
                0x0A,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderMoreInfoUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0xE5,
                0x38,
                0xEF,
                0xCB,
                0xA7,
                0x7D,
                0x5E,
                0x9B,
                0x5E,
                0x22,
                0x74,
                0x98,
                0x42,
                0x69,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderPropertyCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x2F,
                0x8D,
                0x65,
                0xB7,
                0x63,
                0x67,
                0x45,
                0xAC,
                0xF9,
                0x51,
                0xAB,
                0xE3,
                0x01,
                0xDD,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderQuotaUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x95,
                0x62,
                0xBA,
                0x2E,
                0x31,
                0x4F,
                0x54,
                0x9F,
                0xD5,
                0x1F,
                0x81,
                0xB2,
                0x1F,
                0x36,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderStatusUI
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xA7,
                0xB6,
                0xD6,
                0x8D,
                0x19,
                0x80,
                0x5B,
                0x97,
                0x7F,
                0x5F,
                0xF7,
                0x3D,
                0xA3,
                0x31,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderStatusUISource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0xC2,
                0x06,
                0xA3,
                0x66,
                0x3D,
                0x70,
                0x5E,
                0x90,
                0x07,
                0xE4,
                0x3D,
                0xF9,
                0x60,
                0x51,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderStatusUISourceFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x6B,
                0xE4,
                0x12,
                0x5A,
                0x4E,
                0xD1,
                0x58,
                0xA6,
                0x2F,
                0x03,
                0x76,
                0xE8,
                0xEE,
                0x7D,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderSyncRootInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0x05,
                0x13,
                0x7C,
                0xF9,
                0x99,
                0xAC,
                0x41,
                0x89,
                0x04,
                0xAB,
                0x05,
                0x5D,
                0x65,
                0x49,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderSyncRootInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0xB0,
                0x51,
                0xCF,
                0xF1,
                0x7C,
                0x66,
                0x51,
                0xBD,
                0xBA,
                0xEF,
                0xD9,
                0x5F,
                0x52,
                0x9E,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderSyncRootInfo3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x66,
                0x7A,
                0x50,
                0xF6,
                0xBE,
                0xFD,
                0x56,
                0x85,
                0x5E,
                0x75,
                0xAC,
                0xE2,
                0xE4,
                0x5C,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderSyncRootManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0xFB,
                0x99,
                0x3E,
                0xE3,
                0x8F,
                0x40,
                0x4B,
                0xAB,
                0xC7,
                0xF6,
                0xFC,
                0x3D,
                0x74,
                0xC9,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderSyncRootManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0xCF,
                0xB6,
                0xEF,
                0x74,
                0x13,
                0x4E,
                0x54,
                0x9D,
                0xF1,
                0x55,
                0x98,
                0xD2,
                0xE9,
                0xCF,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderUICommand
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0x07,
                0x3E,
                0x0C,
                0x46,
                0xD8,
                0x8F,
                0x56,
                0x94,
                0x84,
                0x10,
                0x5C,
                0xC5,
                0x7B,
                0x50,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProviderUriSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x06,
                0x98,
                0xB2,
                0xE0,
                0x8B,
                0x62,
                0x49,
                0x8B,
                0xB6,
                0x0D,
                0x4C,
                0x2E,
                0x14,
                0xD4,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
