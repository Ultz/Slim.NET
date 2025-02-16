// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IContentIndexer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x7F,
                0x76,
                0xB1,
                0x98,
                0xF6,
                0x82,
                0x49,
                0xB0,
                0x5F,
                0x3A,
                0x6E,
                0x8C,
                0xAB,
                0x01,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContentIndexerQuery
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0xB0,
                0xE3,
                0x70,
                0xFC,
                0x4B,
                0x8A,
                0x42,
                0x88,
                0x89,
                0xCC,
                0x51,
                0xDA,
                0x9A,
                0x7B,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContentIndexerQueryOperations
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x3E,
                0x82,
                0x28,
                0x86,
                0x47,
                0xF1,
                0x42,
                0x97,
                0x30,
                0x79,
                0x2B,
                0x35,
                0x66,
                0xB1,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContentIndexerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x83,
                0x48,
                0x8C,
                0x7E,
                0xB3,
                0x60,
                0x4C,
                0x9B,
                0xA8,
                0xB7,
                0x60,
                0xFD,
                0xA3,
                0xE5,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIndexableContent
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xA0,
                0xF1,
                0xCC,
                0xB5,
                0xD4,
                0x3A,
                0x48,
                0xB0,
                0x6E,
                0xE0,
                0xDB,
                0x1E,
                0xC4,
                0x20,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IQueryOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x46,
                0x5E,
                0x1E,
                0x45,
                0x0F,
                0x38,
                0x48,
                0xA8,
                0xE9,
                0xD0,
                0x47,
                0x9D,
                0x44,
                0x6C,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IQueryOptionsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x1F,
                0x2E,
                0x03,
                0xC1,
                0xA9,
                0x71,
                0x4E,
                0x80,
                0x11,
                0x0D,
                0xEE,
                0x9D,
                0x48,
                0x11,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IQueryOptionsWithProviderFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x10,
                0x9D,
                0x5B,
                0xC4,
                0x15,
                0xDD,
                0x44,
                0xB8,
                0x9A,
                0x47,
                0xA5,
                0x9B,
                0x7D,
                0x7C,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFileQueryResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0xA4,
                0xFD,
                0x52,
                0xAA,
                0x2B,
                0x2C,
                0x41,
                0xB2,
                0x9F,
                0xD4,
                0xB1,
                0x77,
                0x8E,
                0xFA,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFileQueryResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0xB9,
                0x5D,
                0x4E,
                0x41,
                0x71,
                0xC4,
                0x46,
                0x8B,
                0xE3,
                0xE9,
                0xDC,
                0x9E,
                0x27,
                0x27,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFolderQueryOperations
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0xCC,
                0x43,
                0xCB,
                0x6B,
                0x44,
                0x4F,
                0x4A,
                0xBE,
                0x97,
                0x75,
                0x77,
                0x71,
                0xBE,
                0x52,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFolderQueryResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0xC9,
                0x54,
                0x66,
                0x66,
                0x7D,
                0xFA,
                0x46,
                0xAE,
                0xCF,
                0xE4,
                0xA4,
                0xBA,
                0xA9,
                0x3A,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageItemQueryResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x80,
                0x94,
                0xE8,
                0x58,
                0x9D,
                0xB8,
                0x47,
                0xB2,
                0xB2,
                0x41,
                0xB0,
                0x7F,
                0x47,
                0x95,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryChangeTrackerTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xA3,
                0xC7,
                0x1D,
                0xA3,
                0xB7,
                0xF2,
                0x4D,
                0x9D,
                0x61,
                0xEB,
                0xA8,
                0x5A,
                0x03,
                0x43,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryContentChangedTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x19,
                0x37,
                0x2A,
                0xBF,
                0xAB,
                0x1D,
                0x4E,
                0x8A,
                0xA5,
                0x63,
                0x85,
                0xD8,
                0x88,
                0x47,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageQueryResultBase
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xD7,
                0x97,
                0xC2,
                0x53,
                0x73,
                0xAB,
                0x47,
                0xBA,
                0x58,
                0x8C,
                0x61,
                0x42,
                0x5D,
                0xC5,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IValueAndLanguage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x48,
                0x91,
                0xB9,
                0xEE,
                0xA1,
                0xC4,
                0x4B,
                0x92,
                0xA5,
                0x46,
                0x69,
                0x68,
                0xE3,
                0x04,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
