// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IApplicationDataSetVersionHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x91,
                0x57,
                0xA0,
                0x9F,
                0xCC,
                0x87,
                0x46,
                0xAC,
                0xAB,
                0xA3,
                0x64,
                0xFD,
                0x78,
                0x54,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamedFileDataRequestedHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0xA8,
                0xF6,
                0xFE,
                0xE1,
                0x2F,
                0x07,
                0x4D,
                0xA3,
                0x5B,
                0xB7,
                0x7C,
                0x50,
                0xB5,
                0xF4,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppDataPaths
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0xD6,
                0x01,
                0x73,
                0xA2,
                0x79,
                0xC9,
                0x48,
                0x9E,
                0xC0,
                0x3F,
                0xDA,
                0x09,
                0x2F,
                0x79,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppDataPathsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x2A,
                0xEB,
                0xD8,
                0xD9,
                0xA9,
                0x14,
                0x4B,
                0xB9,
                0x99,
                0xE3,
                0x92,
                0x13,
                0x79,
                0xD9,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x6F,
                0xDA,
                0xC3,
                0x44,
                0xB7,
                0x45,
                0x4B,
                0xB0,
                0xB8,
                0x22,
                0x3A,
                0x09,
                0x38,
                0xD0,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationData2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xCD,
                0x65,
                0x9E,
                0xA3,
                0x0B,
                0x32,
                0x4E,
                0xBE,
                0x29,
                0xB0,
                0x2D,
                0xE6,
                0x60,
                0x76,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationData3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x2C,
                0x22,
                0xDC,
                0x72,
                0x27,
                0x1D,
                0x4C,
                0xAA,
                0x2C,
                0xC9,
                0xF7,
                0x43,
                0xAD,
                0xE8,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationDataContainer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0xFD,
                0xAE,
                0xC5,
                0x67,
                0xF4,
                0xBA,
                0x40,
                0x85,
                0x66,
                0xAB,
                0x64,
                0x0A,
                0x44,
                0x1E,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationDataStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x14,
                0x12,
                0x56,
                0x43,
                0xE8,
                0xE3,
                0x45,
                0x94,
                0xD8,
                0x06,
                0x16,
                0x9E,
                0x3C,
                0x8E,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationDataStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x62,
                0x60,
                0xCD,
                0x49,
                0xCF,
                0xA4,
                0x40,
                0xA4,
                0x7C,
                0xC7,
                0xF0,
                0xDB,
                0xBA,
                0x81,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICachedFileManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x22,
                0xFC,
                0x8F,
                0x82,
                0xE7,
                0x5D,
                0x49,
                0xB6,
                0x14,
                0x65,
                0x4C,
                0x4F,
                0x0B,
                0x23,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDownloadsFolderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x2E,
                0x86,
                0x27,
                0x4E,
                0x40,
                0xDF,
                0x47,
                0xA1,
                0xE2,
                0xE3,
                0x73,
                0x08,
                0xBE,
                0x7B,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDownloadsFolderStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x45,
                0x30,
                0xE9,
                0xF8,
                0x8E,
                0x8E,
                0x4F,
                0x8D,
                0x15,
                0xAC,
                0x0E,
                0x26,
                0x5F,
                0x39,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileIOStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x11,
                0x74,
                0x88,
                0x54,
                0x7F,
                0x32,
                0x47,
                0xA5,
                0xF0,
                0x5E,
                0x43,
                0xE3,
                0xB8,
                0xC2,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownFoldersCameraRollStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x5E,
                0x11,
                0x5D,
                0xE8,
                0x27,
                0x2F,
                0x49,
                0xB8,
                0xE5,
                0x2F,
                0x90,
                0x89,
                0x6C,
                0xD4,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownFoldersPlaylistsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xEC,
                0xD5,
                0xDA,
                0x6F,
                0x30,
                0x6A,
                0x4D,
                0xB4,
                0x96,
                0x46,
                0xBA,
                0x8E,
                0xB1,
                0x06,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownFoldersSavedPicturesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x93,
                0x5C,
                0x05,
                0x3D,
                0x25,
                0x7C,
                0x46,
                0xB6,
                0xCA,
                0xA9,
                0x7D,
                0xA1,
                0xE9,
                0xA1,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownFoldersStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x75,
                0x2A,
                0x5A,
                0x02,
                0x48,
                0x2D,
                0x45,
                0x9A,
                0xD9,
                0x43,
                0x51,
                0xAD,
                0xA7,
                0xEC,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownFoldersStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0xD0,
                0x4B,
                0x19,
                0x6E,
                0xCF,
                0x07,
                0x4D,
                0x9D,
                0x53,
                0xE9,
                0x16,
                0x3A,
                0x25,
                0x36,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownFoldersStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x43,
                0x19,
                0xC5,
                0x42,
                0x97,
                0xD5,
                0x4E,
                0x82,
                0x3D,
                0xFC,
                0x14,
                0x01,
                0x14,
                0x87,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownFoldersStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0xE6,
                0x22,
                0x17,
                0xF9,
                0x9F,
                0x21,
                0x4B,
                0xBE,
                0xD5,
                0x90,
                0xEC,
                0xB1,
                0x3A,
                0x19,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPathIOStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x37,
                0x2F,
                0x0F,
                0xC7,
                0x8E,
                0x81,
                0x43,
                0x92,
                0x2B,
                0x8F,
                0x6C,
                0x07,
                0xD2,
                0x88,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISetVersionDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x08,
                0x35,
                0x03,
                0x1A,
                0x78,
                0x7A,
                0x43,
                0xB0,
                0x78,
                0x3F,
                0x32,
                0xBA,
                0xDC,
                0xFE,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISetVersionRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x6B,
                0xC7,
                0xB9,
                0x56,
                0x10,
                0x69,
                0x4E,
                0x83,
                0x30,
                0x16,
                0x26,
                0x19,
                0x95,
                0x6F,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFile
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x61,
                0x3F,
                0xFA,
                0x14,
                0x42,
                0x8C,
                0x42,
                0xA6,
                0x4C,
                0x14,
                0xC9,
                0xAC,
                0x73,
                0x15,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFile2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x4B,
                0x4E,
                0x95,
                0x77,
                0x0A,
                0xFB,
                0x42,
                0xB7,
                0x77,
                0xC2,
                0xED,
                0x58,
                0xA5,
                0x2E,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFilePropertiesWithAvailability
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xBE,
                0xCB,
                0xAF,
                0x2B,
                0x58,
                0x33,
                0x41,
                0x96,
                0x48,
                0xE4,
                0x4C,
                0xA4,
                0x6E,
                0xE4,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFileStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xC7,
                0x84,
                0x59,
                0xF2,
                0xDA,
                0xC8,
                0x43,
                0x8B,
                0xB4,
                0xA4,
                0xD3,
                0xEA,
                0xCF,
                0xD0,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFileStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xA7,
                0x76,
                0x5C,
                0x2E,
                0x21,
                0xF9,
                0x4A,
                0x8F,
                0x04,
                0x74,
                0x0C,
                0xAE,
                0x10,
                0x89,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFolder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xCB,
                0xD1,
                0x72,
                0xEF,
                0xB3,
                0x75,
                0x4F,
                0xA8,
                0x0B,
                0x6F,
                0xD9,
                0xDA,
                0xE2,
                0x94,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFolder2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xE8,
                0x27,
                0xE8,
                0xD9,
                0x08,
                0x8E,
                0x4A,
                0xA0,
                0xAC,
                0xFE,
                0x5E,
                0xD3,
                0xCB,
                0xBB,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFolder3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x78,
                0x61,
                0x9F,
                0xE1,
                0xBD,
                0x24,
                0x41,
                0xAE,
                0xB3,
                0xB0,
                0x6A,
                0xD9,
                0x6F,
                0x98,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFolderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x27,
                0xF3,
                0x08,
                0xD5,
                0x85,
                0xB9,
                0x48,
                0xAE,
                0xE9,
                0x28,
                0x51,
                0x1E,
                0x33,
                0x9F,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageFolderStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x6D,
                0x65,
                0xB4,
                0xD2,
                0x71,
                0x7D,
                0x46,
                0x8B,
                0x29,
                0x37,
                0x1F,
                0x0F,
                0x62,
                0xBF,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xA9,
                0x07,
                0x42,
                0x2F,
                0xCA,
                0xF7,
                0x42,
                0xBD,
                0xE8,
                0x8B,
                0x10,
                0x45,
                0x7A,
                0x7F,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageItem2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x26,
                0xF9,
                0x53,
                0x3C,
                0x08,
                0x83,
                0x42,
                0xB4,
                0x5B,
                0x81,
                0xC0,
                0x07,
                0x23,
                0x7E,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageItemProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0x44,
                0x66,
                0x86,
                0x29,
                0x80,
                0xFE,
                0x46,
                0xA7,
                0x89,
                0x1C,
                0x2F,
                0x3E,
                0x2F,
                0xFB,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageItemProperties2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xA9,
                0x86,
                0x8E,
                0xB9,
                0x04,
                0xD2,
                0x4B,
                0x92,
                0x9D,
                0xFE,
                0xF3,
                0xF7,
                0x16,
                0x21,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageItemPropertiesWithProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xF3,
                0x1B,
                0x86,
                0x68,
                0x63,
                0xEE,
                0x4D,
                0xB4,
                0x0E,
                0x74,
                0x68,
                0x4A,
                0x5C,
                0xE7,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibrary
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x71,
                0xDD,
                0x1E,
                0x5E,
                0x0E,
                0x6C,
                0x4D,
                0xB5,
                0xE8,
                0x93,
                0x18,
                0x98,
                0x3D,
                0x6A,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibrary2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xE3,
                0x0C,
                0x5B,
                0xB3,
                0xFC,
                0x31,
                0x40,
                0xAF,
                0xB0,
                0xA6,
                0x8D,
                0x7B,
                0xD4,
                0x45,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibrary3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x12,
                0x28,
                0x8A,
                0x54,
                0x21,
                0x01,
                0x42,
                0x81,
                0x13,
                0xD2,
                0xC0,
                0x5C,
                0xE1,
                0xAD,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryChange
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x0B,
                0x98,
                0x00,
                0xE2,
                0x2B,
                0x09,
                0x49,
                0xAA,
                0x48,
                0x15,
                0x9F,
                0x52,
                0x03,
                0xA5,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryChangeReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0xBC,
                0x05,
                0xF2,
                0xA2,
                0xFC,
                0xF9,
                0x41,
                0x89,
                0x54,
                0xEE,
                0x2E,
                0x99,
                0x1E,
                0xB9,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryChangeReader2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x86,
                0xF4,
                0xAB,
                0xCC,
                0xFB,
                0x4F,
                0x4A,
                0x99,
                0x9E,
                0xE7,
                0xAB,
                0x7C,
                0x64,
                0x6D,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryChangeTracker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x73,
                0x15,
                0x9E,
                0x73,
                0x60,
                0xF6,
                0x44,
                0x96,
                0x81,
                0x74,
                0x92,
                0xD1,
                0x28,
                0x6C,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryChangeTracker2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0x1C,
                0x05,
                0xCD,
                0x9F,
                0x0F,
                0xF9,
                0x42,
                0x8F,
                0xB3,
                0x15,
                0x8D,
                0x82,
                0xE1,
                0x38,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryChangeTrackerOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0xBC,
                0x52,
                0xBB,
                0x6D,
                0x1A,
                0xC0,
                0x59,
                0xAD,
                0x2A,
                0x82,
                0x3A,
                0x20,
                0x53,
                0x24,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryLastChangeId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x82,
                0x81,
                0x52,
                0xE1,
                0xBB,
                0xBC,
                0x53,
                0x82,
                0xCA,
                0x81,
                0xCC,
                0x7F,
                0x03,
                0x93,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryLastChangeIdStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x91,
                0xA4,
                0x81,
                0xA3,
                0x2C,
                0x09,
                0x53,
                0xB0,
                0xD1,
                0xCF,
                0x07,
                0x88,
                0xE4,
                0x07,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xA6,
                0x08,
                0x42,
                0x4A,
                0x68,
                0xC6,
                0x49,
                0x9E,
                0x59,
                0x90,
                0x12,
                0x1E,
                0xE0,
                0x50,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x8D,
                0xB0,
                0xFF,
                0x75,
                0xFA,
                0x95,
                0x46,
                0xB9,
                0xD1,
                0x7F,
                0x81,
                0xF9,
                0x78,
                0x32,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0xEE,
                0x05,
                0xE7,
                0x78,
                0xD4,
                0xD6,
                0x47,
                0xBA,
                0x46,
                0x1A,
                0x8E,
                0xBE,
                0x11,
                0x4A,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageProvider2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x19,
                0x0D,
                0x01,
                0x04,
                0x34,
                0x4B,
                0x41,
                0x9F,
                0xD7,
                0xCD,
                0x44,
                0x47,
                0x2E,
                0xAA,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageStreamTransaction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0xF3,
                0x7C,
                0xF6,
                0x3D,
                0xA5,
                0x94,
                0x4D,
                0xAE,
                0x2C,
                0x67,
                0x23,
                0x2D,
                0x93,
                0xAC,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStreamedFileDataRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0xFC,
                0x73,
                0x16,
                0xBD,
                0xDA,
                0x50,
                0x4D,
                0xBE,
                0xEE,
                0x18,
                0x0B,
                0x8A,
                0x81,
                0x91,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemAudioProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x38,
                0x8F,
                0x3F,
                0x8C,
                0x30,
                0xE1,
                0x47,
                0x92,
                0x4D,
                0x86,
                0x45,
                0x34,
                0x8E,
                0x5D,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemDataPaths
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0xBF,
                0x2A,
                0xE3,
                0xFA,
                0xD8,
                0xEC,
                0x45,
                0xA9,
                0x42,
                0xD2,
                0xE2,
                0x6F,
                0xB6,
                0x0B,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemDataPathsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x6F,
                0xF9,
                0xE0,
                0x20,
                0x99,
                0xCA,
                0x4B,
                0xB3,
                0x79,
                0xF9,
                0x6F,
                0xDF,
                0x7C,
                0xAA,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemGPSProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x6E,
                0xF4,
                0xC0,
                0x74,
                0xC1,
                0x1A,
                0x48,
                0xBC,
                0x25,
                0x92,
                0x19,
                0x86,
                0xF6,
                0xA6,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemImageProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x2E,
                0x1B,
                0x01,
                0x39,
                0x8B,
                0x08,
                0x43,
                0xBE,
                0xA1,
                0xE8,
                0xAA,
                0x61,
                0xE4,
                0x78,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMediaProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x33,
                0x2B,
                0xA4,
                0x15,
                0x84,
                0xDC,
                0x40,
                0x8C,
                0x44,
                0x98,
                0x36,
                0x1D,
                0x23,
                0x54,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemMusicProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x88,
                0x79,
                0xB4,
                0xAF,
                0x67,
                0xC3,
                0x4B,
                0x8D,
                0x39,
                0x5B,
                0x89,
                0x02,
                0x20,
                0x26,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemPhotoProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0xFC,
                0x34,
                0x47,
                0x21,
                0xAB,
                0x24,
                0x44,
                0xB7,
                0x35,
                0xF4,
                0x35,
                0x3A,
                0x56,
                0xC8,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x71,
                0x7A,
                0x91,
                0xF3,
                0x85,
                0xD1,
                0x4D,
                0xB0,
                0x01,
                0xA5,
                0x0B,
                0xFD,
                0x21,
                0xC8,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemVideoProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0xF7,
                0x40,
                0x20,
                0xF8,
                0x67,
                0x22,
                0x43,
                0x9B,
                0x80,
                0x4F,
                0xA9,
                0xFE,
                0xFB,
                0x83,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataPaths
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x39,
                0xC5,
                0xF9,
                0xC4,
                0xAB,
                0xFF,
                0x46,
                0x8A,
                0x2B,
                0xDC,
                0x9D,
                0x7F,
                0xA6,
                0xE5,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataPathsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x9D,
                0xB2,
                0x01,
                0x62,
                0xE0,
                0xA1,
                0x48,
                0x8B,
                0x0C,
                0xF2,
                0xC7,
                0xA9,
                0xCA,
                0x56,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
