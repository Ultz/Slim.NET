// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IWalletBarcode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0x7B,
                0x85,
                0x4F,
                0x80,
                0xDE,
                0xA4,
                0x4E,
                0xA1,
                0xCD,
                0x81,
                0xCD,
                0x08,
                0x4D,
                0xAC,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletBarcodeFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x71,
                0x11,
                0x30,
                0x9C,
                0xED,
                0x9E,
                0x46,
                0xBB,
                0xFD,
                0x30,
                0x6C,
                0x95,
                0xEA,
                0x71,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x4B,
                0xB5,
                0x20,
                0x8D,
                0x11,
                0xC4,
                0x4E,
                0x99,
                0x6C,
                0xB9,
                0x63,
                0xE7,
                0xBD,
                0x3E,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletItemCustomProperty
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x40,
                0x4B,
                0xB9,
                0x00,
                0xFA,
                0xFD,
                0x40,
                0x98,
                0xDC,
                0x9D,
                0xE4,
                0x66,
                0x97,
                0xF1,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletItemCustomPropertyFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x6A,
                0x04,
                0xD0,
                0xA1,
                0x61,
                0xAA,
                0x41,
                0xB2,
                0x59,
                0xA5,
                0x61,
                0x0A,
                0xB5,
                0xD5,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletItemFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x74,
                0xE2,
                0x53,
                0x0B,
                0x4F,
                0x3E,
                0x4A,
                0x99,
                0xE5,
                0x0B,
                0xBB,
                0x1E,
                0xAB,
                0x38,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletItemStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x48,
                0x60,
                0x71,
                0x49,
                0x6D,
                0xF8,
                0x48,
                0x91,
                0xA9,
                0x40,
                0xA1,
                0xD0,
                0xF1,
                0x3E,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletItemStore2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x82,
                0xE6,
                0x65,
                0x09,
                0x70,
                0x15,
                0x4A,
                0xBD,
                0x54,
                0x4F,
                0xFF,
                0x37,
                0x9B,
                0xFF,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0xD6,
                0x11,
                0x51,
                0xA4,
                0xC9,
                0x64,
                0x4C,
                0xB4,
                0xDD,
                0xE1,
                0xE5,
                0x48,
                0x00,
                0x1C,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletRelevantLocation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0x78,
                0xD8,
                0x9F,
                0xF9,
                0xE3,
                0xE1,
                0x4D,
                0xBA,
                0xB3,
                0xBB,
                0x19,
                0x2E,
                0x46,
                0xB3,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletTransaction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xE9,
                0xE1,
                0x40,
                0x06,
                0x26,
                0x19,
                0x45,
                0x81,
                0xCB,
                0xBF,
                0xF1,
                0xC6,
                0x0D,
                0x1F,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletVerb
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x26,
                0xB8,
                0x17,
                0xC1,
                0xE3,
                0x74,
                0x4C,
                0x8A,
                0x94,
                0x21,
                0x7A,
                0xAD,
                0xBC,
                0x48,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletVerbFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x27,
                0x01,
                0x76,
                0x58,
                0xBE,
                0x5E,
                0x4D,
                0x83,
                0xED,
                0x58,
                0xB1,
                0x66,
                0x9C,
                0x7A,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
