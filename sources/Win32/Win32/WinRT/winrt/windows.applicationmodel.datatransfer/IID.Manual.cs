// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDataProviderHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0xD7,
                0xEC,
                0xE7,
                0xF4,
                0xF2,
                0x2D,
                0x4A,
                0x92,
                0x0E,
                0x17,
                0x0A,
                0x2F,
                0x48,
                0x2A,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareProviderHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0xD9,
                0xF9,
                0xE7,
                0xBA,
                0xE1,
                0x4D,
                0x4E,
                0xBD,
                0x65,
                0xD4,
                0x38,
                0x45,
                0xD3,
                0x21,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IClipboardContentOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0xA9,
                0x88,
                0xE8,
                0x4B,
                0xAD,
                0x47,
                0x54,
                0xA0,
                0x56,
                0xAB,
                0x35,
                0x56,
                0x27,
                0x6D,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IClipboardHistoryChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0x45,
                0xBE,
                0xC0,
                0xA2,
                0x8E,
                0xCE,
                0x53,
                0x9A,
                0xBA,
                0x8D,
                0x22,
                0x12,
                0x57,
                0x34,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IClipboardHistoryItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0xBD,
                0x73,
                0x01,
                0xFF,
                0xAF,
                0x50,
                0x5C,
                0xAB,
                0x92,
                0x3D,
                0x19,
                0xF4,
                0x81,
                0xEC,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IClipboardHistoryItemsResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0xDE,
                0xDF,
                0xE6,
                0xE2,
                0x0E,
                0xE3,
                0x52,
                0x85,
                0x2B,
                0xF2,
                0x95,
                0xDB,
                0x65,
                0x93,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IClipboardStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0xE2,
                0x27,
                0xC6,
                0xE2,
                0x34,
                0x63,
                0x49,
                0x8E,
                0xED,
                0x93,
                0xCB,
                0xB0,
                0xEA,
                0x3D,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IClipboardStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x1B,
                0xAC,
                0xD2,
                0x9F,
                0xD2,
                0x4B,
                0x55,
                0xB3,
                0x03,
                0xF0,
                0x45,
                0x23,
                0x45,
                0xFE,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xF5,
                0xEB,
                0x61,
                0xEA,
                0xEF,
                0x46,
                0x43,
                0x95,
                0x54,
                0x98,
                0x1D,
                0x7E,
                0x19,
                0x8F,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackage2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0x1F,
                0x1C,
                0x04,
                0x09,
                0x24,
                0xE1,
                0x45,
                0xA5,
                0x38,
                0x4C,
                0x53,
                0xEE,
                0xEE,
                0x04,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackage3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x1F,
                0xF3,
                0x88,
                0x7B,
                0x78,
                0x32,
                0x4D,
                0x96,
                0x5A,
                0xA9,
                0x83,
                0x81,
                0x05,
                0xA0,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackage4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x4E,
                0xA2,
                0x13,
                0x82,
                0x93,
                0x6F,
                0x53,
                0x85,
                0x2A,
                0x30,
                0x45,
                0xE1,
                0xB2,
                0x9A,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackagePropertySet
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x93,
                0x1C,
                0xCD,
                0x4C,
                0x4C,
                0x3A,
                0x44,
                0xA8,
                0xD3,
                0xF5,
                0xC2,
                0x41,
                0xE9,
                0x16,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackagePropertySet2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x5D,
                0x50,
                0xEB,
                0x00,
                0x98,
                0xAA,
                0x46,
                0xB1,
                0x81,
                0x7B,
                0x6F,
                0x0F,
                0x2B,
                0x91,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackagePropertySet3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xFD,
                0x87,
                0x9E,
                0x05,
                0x52,
                0x1B,
                0x40,
                0x87,
                0x4A,
                0x45,
                0x56,
                0x53,
                0xBD,
                0x39,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackagePropertySet4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0xEB,
                0x90,
                0x63,
                0x39,
                0x17,
                0x74,
                0x4C,
                0xB2,
                0x2F,
                0x86,
                0x5F,
                0xAB,
                0x5E,
                0x85,
                0x45,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackagePropertySetView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xEC,
                0x4C,
                0xB9,
                0x1A,
                0x0C,
                0x57,
                0x4C,
                0xBE,
                0x55,
                0x75,
                0xD0,
                0x12,
                0x89,
                0x73,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackagePropertySetView2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x50,
                0x54,
                0x60,
                0xBE,
                0x8E,
                0xEB,
                0x4F,
                0x9C,
                0x1E,
                0x75,
                0xE6,
                0x9D,
                0xE5,
                0x4B,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackagePropertySetView3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x4C,
                0x76,
                0xDB,
                0x74,
                0xD1,
                0x5C,
                0x49,
                0x84,
                0xFC,
                0x1A,
                0x51,
                0xF6,
                0xAB,
                0x45,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackagePropertySetView4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xC8,
                0x74,
                0x44,
                0x6F,
                0xD1,
                0xAE,
                0x40,
                0x95,
                0x80,
                0x6F,
                0x85,
                0x62,
                0xB9,
                0x42,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackagePropertySetView5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x94,
                0x0A,
                0x6F,
                0x60,
                0x37,
                0xBB,
                0x50,
                0x85,
                0x23,
                0xC4,
                0x20,
                0x2D,
                0xED,
                0x7D,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackageView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x04,
                0x84,
                0x7B,
                0x00,
                0x59,
                0x85,
                0x4D,
                0xA9,
                0x0B,
                0x10,
                0xCB,
                0x85,
                0xFE,
                0x35,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackageView2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0xBA,
                0xEC,
                0x40,
                0x50,
                0x24,
                0x1D,
                0x4C,
                0xB6,
                0xB4,
                0xED,
                0x45,
                0x46,
                0x3D,
                0xEE,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackageView3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x71,
                0x77,
                0xD3,
                0xAD,
                0xDD,
                0x88,
                0x42,
                0x84,
                0x28,
                0xD1,
                0xCA,
                0xE3,
                0x94,
                0x12,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPackageView4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x6F,
                0xE9,
                0xDF,
                0x42,
                0xE0,
                0x33,
                0x44,
                0xA0,
                0x9F,
                0x26,
                0xD6,
                0xFF,
                0xDA,
                0x8B,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataProviderDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x23,
                0xCF,
                0xC2,
                0x26,
                0x2D,
                0xD9,
                0x43,
                0xB6,
                0x9D,
                0xDC,
                0xB8,
                0x6D,
                0x03,
                0xF6,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataProviderRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x71,
                0xBC,
                0xEB,
                0xC8,
                0xD3,
                0xDA,
                0x47,
                0xAC,
                0xDE,
                0xF8,
                0x23,
                0x88,
                0xD5,
                0xF7,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0xAE,
                0x41,
                0x43,
                0x12,
                0xFC,
                0x53,
                0x4E,
                0x8C,
                0x02,
                0xAC,
                0x71,
                0x4C,
                0x41,
                0x5A,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataRequestDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0xB8,
                0xC4,
                0x6D,
                0x86,
                0x03,
                0x63,
                0x42,
                0x87,
                0xC1,
                0xED,
                0x7D,
                0xCE,
                0x30,
                0x89,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0xA8,
                0x8B,
                0xCB,
                0xC5,
                0x6A,
                0xC9,
                0x43,
                0x8A,
                0xC5,
                0x9B,
                0xA2,
                0x32,
                0x16,
                0x31,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataTransferManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xEE,
                0xCA,
                0xA5,
                0x08,
                0x87,
                0xD1,
                0x49,
                0x8D,
                0x36,
                0x67,
                0xD2,
                0x5A,
                0x8D,
                0xA0,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataTransferManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x7D,
                0xAE,
                0x30,
                0xA8,
                0x8B,
                0x02,
                0x4C,
                0x8E,
                0x3F,
                0xDD,
                0xB2,
                0x3B,
                0x38,
                0x87,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataTransferManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x01,
                0xDA,
                0xA9,
                0x0E,
                0xE0,
                0xFE,
                0x4C,
                0xAA,
                0x44,
                0x2D,
                0xD9,
                0x32,
                0xDC,
                0xA3,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataTransferManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0xC2,
                0x4E,
                0xC5,
                0x97,
                0x9F,
                0x63,
                0x4D,
                0x98,
                0x68,
                0x39,
                0x5E,
                0x27,
                0x1A,
                0xD8,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataTransferManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x54,
                0x84,
                0x05,
                0x82,
                0x6C,
                0x5C,
                0x4F,
                0xAC,
                0x23,
                0x62,
                0xE4,
                0x58,
                0x36,
                0x1F,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHtmlFormatHelperStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x77,
                0x2E,
                0xE2,
                0x70,
                0xDD,
                0x6F,
                0x44,
                0xAE,
                0xFC,
                0x61,
                0xCE,
                0xE5,
                0x9F,
                0x65,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOperationCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x32,
                0xAF,
                0xE7,
                0x1D,
                0x05,
                0xAB,
                0x4F,
                0xB1,
                0xA9,
                0x47,
                0xFD,
                0x77,
                0xF7,
                0x0A,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOperationCompletedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xA0,
                0x8F,
                0x85,
                0x19,
                0x1E,
                0x05,
                0x41,
                0xB2,
                0xF7,
                0xC8,
                0x47,
                0x88,
                0x08,
                0xD5,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0xC4,
                0x74,
                0x45,
                0x13,
                0xF9,
                0x60,
                0x4F,
                0x9D,
                0xF7,
                0xCC,
                0x40,
                0x60,
                0xAB,
                0x19,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0xE0,
                0xAB,
                0x2F,
                0x3E,
                0x44,
                0xDA,
                0x4C,
                0xAF,
                0x25,
                0x8D,
                0x81,
                0x07,
                0x0E,
                0xFD,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareProviderFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x17,
                0x2A,
                0x17,
                0x9E,
                0xE7,
                0x6D,
                0x4F,
                0xB0,
                0x7D,
                0x12,
                0x8F,
                0x46,
                0x9E,
                0x02,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareProviderOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0xF9,
                0xCE,
                0x19,
                0x35,
                0xD4,
                0x79,
                0x41,
                0xB6,
                0xAF,
                0x14,
                0xE0,
                0x49,
                0x2B,
                0x69,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareProvidersRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0xF3,
                0x88,
                0xF8,
                0xF8,
                0xA3,
                0xCE,
                0x4F,
                0x85,
                0xE4,
                0x88,
                0x26,
                0xE6,
                0x3B,
                0xE7,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareTargetInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0xE6,
                0x5B,
                0x38,
                0xE8,
                0xC6,
                0x14,
                0x41,
                0xB2,
                0x94,
                0x28,
                0xF3,
                0xBB,
                0x6F,
                0x99,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareUIOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x8A,
                0xFA,
                0x72,
                0x2F,
                0x34,
                0x90,
                0x4D,
                0x95,
                0x51,
                0x2A,
                0xE0,
                0x4E,
                0x37,
                0x68,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISharedStorageAccessManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x2A,
                0x13,
                0xC6,
                0xB1,
                0x34,
                0x49,
                0x48,
                0xBD,
                0x5F,
                0xD0,
                0x9F,
                0xEE,
                0x31,
                0x58,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStandardDataFormatsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x81,
                0xD6,
                0x7E,
                0x80,
                0xA8,
                0xC9,
                0x40,
                0xB4,
                0xED,
                0x0B,
                0xEE,
                0x1E,
                0x15,
                0xF5,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStandardDataFormatsStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x54,
                0xA2,
                0x42,
                0x76,
                0x9D,
                0xE8,
                0x42,
                0x86,
                0x1B,
                0x47,
                0xC2,
                0x5D,
                0xD0,
                0xCF,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStandardDataFormatsStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xB0,
                0x57,
                0x3B,
                0xD4,
                0x01,
                0x4C,
                0x47,
                0x8B,
                0x5F,
                0xBC,
                0x8E,
                0x27,
                0xF3,
                0x8B,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITargetApplicationChosenEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0xB8,
                0x6F,
                0xCA,
                0x87,
                0x29,
                0xE3,
                0x4E,
                0x9C,
                0x54,
                0xD8,
                0xAF,
                0xBC,
                0xB8,
                0x6C,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
