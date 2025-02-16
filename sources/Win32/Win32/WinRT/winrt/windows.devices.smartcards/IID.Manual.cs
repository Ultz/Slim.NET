// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ISmartCardPinResetHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x5E,
                0x8D,
                0x13,
                0xBC,
                0xF3,
                0x5C,
                0x4A,
                0xB4,
                0x1D,
                0x4B,
                0x4E,
                0xF6,
                0x84,
                0xE2,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICardAddedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0xEF,
                0xBB,
                0x18,
                0x8B,
                0xF1,
                0xD3,
                0x4D,
                0xB1,
                0x18,
                0xDF,
                0xB2,
                0xC8,
                0xE2,
                0x3C,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICardRemovedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x1A,
                0x33,
                0x15,
                0xD7,
                0x22,
                0x45,
                0x49,
                0xAF,
                0xC9,
                0x03,
                0xB4,
                0x6F,
                0x42,
                0xA6,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownSmartCardAppletIds
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0xD8,
                0x04,
                0x7B,
                0xB4,
                0x95,
                0x88,
                0x4C,
                0x8C,
                0xEA,
                0x41,
                0x1E,
                0x55,
                0x51,
                0x1E,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCard
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x88,
                0x71,
                0x1B,
                0x34,
                0x64,
                0xF4,
                0x43,
                0xB5,
                0x5A,
                0x6A,
                0x29,
                0x62,
                0x38,
                0x70,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardAppletIdGroup
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x65,
                0xB1,
                0x7D,
                0x64,
                0x62,
                0xF4,
                0x56,
                0x5E,
                0x03,
                0xC8,
                0x63,
                0x85,
                0x39,
                0x5E,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardAppletIdGroup2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0xF9,
                0x0E,
                0x6B,
                0x56,
                0x99,
                0x62,
                0x4A,
                0x8D,
                0x4E,
                0xD3,
                0x7A,
                0x68,
                0xEB,
                0xC3,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardAppletIdGroupFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0xEB,
                0x05,
                0x91,
                0x65,
                0x4A,
                0x41,
                0x4E,
                0x80,
                0x61,
                0xCB,
                0xE8,
                0x3F,
                0x36,
                0x95,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardAppletIdGroupRegistration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x08,
                0x12,
                0xDF,
                0xBB,
                0x31,
                0x96,
                0x55,
                0x43,
                0xB1,
                0x6D,
                0x69,
                0xA0,
                0x25,
                0x7B,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardAppletIdGroupRegistration2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x08,
                0x55,
                0x5F,
                0xA7,
                0x98,
                0x2E,
                0x4F,
                0x91,
                0xD9,
                0x6C,
                0xFC,
                0xCE,
                0xDA,
                0x40,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardAppletIdGroupStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x99,
                0x28,
                0xAB,
                0x6C,
                0xE7,
                0xCF,
                0x45,
                0xBF,
                0x1D,
                0x90,
                0xEA,
                0xA6,
                0x20,
                0x59,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardAutomaticResponseApdu
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x2B,
                0x15,
                0x52,
                0x3E,
                0xC6,
                0x31,
                0x45,
                0xA8,
                0x57,
                0xD7,
                0x56,
                0xD9,
                0x9B,
                0x98,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardAutomaticResponseApdu2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0xBB,
                0xAE,
                0x44,
                0x9D,
                0x55,
                0x31,
                0x45,
                0x4E,
                0x51,
                0x89,
                0xDB,
                0x6F,
                0xA8,
                0xA5,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardAutomaticResponseApdu3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0xDA,
                0x43,
                0xBF,
                0x76,
                0x65,
                0x92,
                0x43,
                0x93,
                0x67,
                0xFE,
                0x3B,
                0xC9,
                0xE2,
                0xD4,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardAutomaticResponseApduFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0xA2,
                0x7E,
                0xE9,
                0x2C,
                0xD0,
                0x55,
                0x4C,
                0xB0,
                0x2A,
                0x8C,
                0xFF,
                0x7F,
                0xA9,
                0xF0,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardChallengeContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x53,
                0x2A,
                0x19,
                0xC4,
                0xC9,
                0x47,
                0x49,
                0x81,
                0xCC,
                0x44,
                0x79,
                0x4A,
                0x61,
                0xEF,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardConnect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x87,
                0xDF,
                0x2F,
                0x8D,
                0x02,
                0x1E,
                0x49,
                0xA0,
                0x58,
                0x33,
                0x82,
                0xC3,
                0x98,
                0x6F,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardConnection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0x99,
                0xDB,
                0x7E,
                0x1A,
                0xA8,
                0xBC,
                0x47,
                0xA6,
                0x49,
                0x15,
                0x6B,
                0xE6,
                0xB7,
                0xF2,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramGenerator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x58,
                0x9F,
                0xE3,
                0xD3,
                0xED,
                0x49,
                0x4E,
                0xB5,
                0x94,
                0x0F,
                0xF5,
                0xE4,
                0xD0,
                0xC7,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramGenerator2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0xAA,
                0x16,
                0x71,
                0x6D,
                0x5D,
                0x4A,
                0x4B,
                0x96,
                0xA3,
                0xEF,
                0xA4,
                0x7D,
                0x2A,
                0x7E,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramGeneratorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x39,
                0x93,
                0x09,
                0x9C,
                0xCB,
                0x15,
                0x40,
                0x96,
                0x7D,
                0x52,
                0x34,
                0xF3,
                0xB0,
                0x29,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramGeneratorStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0xF5,
                0xBD,
                0x09,
                0xBD,
                0xB4,
                0x23,
                0x4E,
                0xA5,
                0x88,
                0x74,
                0x46,
                0x92,
                0x04,
                0xC1,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xE0,
                0x98,
                0x27,
                0x87,
                0xD6,
                0x92,
                0x4C,
                0x86,
                0xC6,
                0x39,
                0x9E,
                0x9A,
                0x0E,
                0xCB,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x8A,
                0x6A,
                0x4E,
                0x73,
                0x97,
                0xC4,
                0x46,
                0xA3,
                0x2F,
                0xB1,
                0xE5,
                0x43,
                0x15,
                0x9E,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xE8,
                0x7C,
                0x8C,
                0xE7,
                0xA7,
                0x9D,
                0x48,
                0xB9,
                0xD6,
                0x36,
                0x80,
                0x61,
                0x51,
                0x50,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramMaterialCharacteristics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0xC5,
                0x9A,
                0xFC,
                0xD7,
                0xC1,
                0x53,
                0x41,
                0x92,
                0x3B,
                0xA2,
                0xD4,
                0x3C,
                0x6C,
                0x8D,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramMaterialPackageCharacteristics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x8E,
                0xB5,
                0xFF,
                0x92,
                0x06,
                0x47,
                0x4C,
                0x93,
                0xCF,
                0x34,
                0xD9,
                0x1F,
                0x9D,
                0xCD,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramMaterialPossessionProof
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0xAB,
                0xB9,
                0xE5,
                0x41,
                0xA1,
                0x35,
                0x41,
                0x9A,
                0xDD,
                0xB0,
                0xD2,
                0xE3,
                0xAA,
                0x1F,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramPlacementStep
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x03,
                0x7B,
                0x94,
                0x42,
                0x83,
                0x92,
                0x47,
                0xA2,
                0xE5,
                0x92,
                0x56,
                0x36,
                0x37,
                0x8A,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramStorageKeyCharacteristics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x54,
                0x52,
                0x85,
                0x57,
                0x44,
                0x25,
                0x48,
                0xB4,
                0x64,
                0x63,
                0x54,
                0x71,
                0xA3,
                0x9F,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramStorageKeyInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xF0,
                0xB0,
                0x77,
                0x97,
                0xB0,
                0x61,
                0x4F,
                0xA2,
                0x6A,
                0x95,
                0x61,
                0x63,
                0x9C,
                0x9C,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardCryptogramStorageKeyInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x40,
                0x04,
                0x00,
                0xFD,
                0xF7,
                0x7D,
                0x41,
                0x89,
                0xE1,
                0xFB,
                0xB0,
                0x38,
                0x2A,
                0xDC,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardEmulator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x06,
                0xB9,
                0xDF,
                0x5E,
                0x87,
                0xE5,
                0x47,
                0x80,
                0x77,
                0xE8,
                0xBF,
                0xF1,
                0xB1,
                0xC6,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardEmulator2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0xC0,
                0x3F,
                0xFE,
                0x29,
                0x85,
                0x1A,
                0x41,
                0x80,
                0x7B,
                0x48,
                0xED,
                0xC2,
                0xA0,
                0xAB,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardEmulatorApduReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x15,
                0x5D,
                0xD5,
                0xD2,
                0x69,
                0x33,
                0x53,
                0x5B,
                0x5F,
                0xF8,
                0xC0,
                0xD6,
                0xE9,
                0xF0,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardEmulatorApduReceivedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x3D,
                0xF9,
                0x8B,
                0xE1,
                0x22,
                0x38,
                0x42,
                0x86,
                0x10,
                0x94,
                0xCE,
                0x4A,
                0x96,
                0x54,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardEmulatorApduReceivedEventArgsWithCryptograms
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xBA,
                0x50,
                0xD5,
                0xBF,
                0xB7,
                0x29,
                0x4E,
                0x92,
                0x94,
                0x0C,
                0x4A,
                0xC3,
                0xC9,
                0x41,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardEmulatorConnectionDeactivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0xD8,
                0x86,
                0x21,
                0xEB,
                0xC5,
                0x62,
                0x52,
                0x43,
                0xDF,
                0x62,
                0xA0,
                0xA1,
                0xB5,
                0x55,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardEmulatorConnectionProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0xA5,
                0x2C,
                0x4E,
                0x69,
                0xF9,
                0x7D,
                0x50,
                0x6C,
                0xF9,
                0x34,
                0xE2,
                0xD1,
                0x8D,
                0xF3,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardEmulatorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0xFC,
                0x9B,
                0x7A,
                0xD3,
                0xC4,
                0x4F,
                0x49,
                0xB8,
                0xA2,
                0x62,
                0x15,
                0xD8,
                0x1E,
                0x85,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardEmulatorStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x9F,
                0xAE,
                0x69,
                0x75,
                0xB7,
                0x8B,
                0x48,
                0x84,
                0x36,
                0x6C,
                0x1E,
                0x28,
                0xED,
                0x73,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardEmulatorStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0x14,
                0xEA,
                0x59,
                0x09,
                0x9F,
                0xF5,
                0x43,
                0x85,
                0x65,
                0xCF,
                0xA8,
                0x14,
                0x8E,
                0x4C,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardPinPolicy
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0xE1,
                0x3C,
                0x18,
                0xB6,
                0x4D,
                0x41,
                0x48,
                0xAC,
                0x9E,
                0x2A,
                0xC1,
                0xF3,
                0x9B,
                0x73,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardPinResetDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x4A,
                0xC9,
                0x18,
                0x05,
                0x78,
                0x04,
                0x40,
                0x85,
                0xE4,
                0xBB,
                0xEF,
                0xAC,
                0x8F,
                0x68,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardPinResetRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x3C,
                0xFE,
                0x12,
                0xB9,
                0x5F,
                0x8E,
                0x4E,
                0x9F,
                0xF6,
                0x61,
                0xF4,
                0x75,
                0x12,
                0x4F,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardProvisioning
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0xED,
                0xEE,
                0x19,
                0xAB,
                0x1F,
                0x7C,
                0x47,
                0xB7,
                0x12,
                0x1A,
                0x2C,
                0x5A,
                0xF1,
                0xFD,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardProvisioning2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x28,
                0xFD,
                0x10,
                0x79,
                0x3F,
                0x66,
                0x4B,
                0x9B,
                0x7C,
                0x11,
                0xC1,
                0x49,
                0xB7,
                0xD0,
                0xBC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardProvisioningStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x28,
                0x88,
                0x13,
                0x13,
                0x0D,
                0x70,
                0x4E,
                0x97,
                0x35,
                0x51,
                0xDA,
                0xEC,
                0xA5,
                0x25,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardProvisioningStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0xC6,
                0x47,
                0x34,
                0xA0,
                0xC9,
                0xD6,
                0x4B,
                0xB5,
                0x0D,
                0x25,
                0x1F,
                0x4E,
                0x8D,
                0x3A,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xB4,
                0x74,
                0x10,
                0xC2,
                0x54,
                0xF0,
                0x4D,
                0x81,
                0x7A,
                0x14,
                0xC1,
                0x43,
                0x78,
                0xF0,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardReaderStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x04,
                0x3C,
                0x10,
                0xCA,
                0xA1,
                0xF2,
                0x48,
                0xA2,
                0x81,
                0x5B,
                0x6F,
                0x66,
                0x9A,
                0xF1,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0xF1,
                0x9B,
                0x5F,
                0xEF,
                0x39,
                0x2B,
                0x4F,
                0xB4,
                0x4F,
                0x0A,
                0x91,
                0x55,
                0xB1,
                0x77,
                0xBC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardTriggerDetails2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xC5,
                0x45,
                0x29,
                0x75,
                0x89,
                0x51,
                0x4A,
                0x9E,
                0x1A,
                0x5F,
                0x8A,
                0x76,
                0xEE,
                0x51,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardTriggerDetails3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xC2,
                0xE2,
                0xB3,
                0xC6,
                0x18,
                0xA8,
                0x4B,
                0x83,
                0x76,
                0xEF,
                0x03,
                0xD4,
                0x91,
                0x26,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
