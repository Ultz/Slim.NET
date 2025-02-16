// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDisplayPropertiesEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x8B,
                0xDD,
                0xDB,
                0xA1,
                0xF1,
                0xD1,
                0x46,
                0x9E,
                0xE3,
                0x54,
                0x3B,
                0xCC,
                0x99,
                0x59,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedColorInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0xDC,
                0x97,
                0x87,
                0x29,
                0xB2,
                0x81,
                0x40,
                0xAE,
                0x9A,
                0x2C,
                0xC8,
                0x5E,
                0x34,
                0xAD,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBrightnessOverride
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0x62,
                0xC9,
                0x96,
                0x43,
                0xC1,
                0x92,
                0x43,
                0xBE,
                0xDD,
                0x4A,
                0x7E,
                0x95,
                0x74,
                0xC8,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBrightnessOverrideSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0xAB,
                0x12,
                0xD1,
                0x04,
                0x76,
                0xBA,
                0x4D,
                0xBC,
                0xF8,
                0x4B,
                0x6F,
                0x49,
                0x50,
                0x2C,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBrightnessOverrideSettingsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0xDC,
                0x87,
                0xD4,
                0x74,
                0x6F,
                0x0B,
                0x44,
                0xB3,
                0x83,
                0x5F,
                0xE9,
                0x6C,
                0xF0,
                0x0B,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBrightnessOverrideStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0xB9,
                0xA7,
                0x03,
                0xF1,
                0xE1,
                0x68,
                0x4A,
                0xA1,
                0x1F,
                0x94,
                0x6A,
                0xD8,
                0xCE,
                0x53,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IColorOverrideSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0xA1,
                0xEF,
                0xFB,
                0x81,
                0x4A,
                0x4D,
                0x4C,
                0xA5,
                0xB6,
                0x7D,
                0x1B,
                0x5C,
                0x4B,
                0xD0,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IColorOverrideSettingsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xE0,
                0x68,
                0xB0,
                0x1F,
                0xC4,
                0xC9,
                0x4A,
                0xAF,
                0xAB,
                0x82,
                0x7A,
                0xB6,
                0x24,
                0x8F,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayEnhancementOverride
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x94,
                0x95,
                0x42,
                0x7A,
                0xD9,
                0x02,
                0x4B,
                0xA4,
                0x28,
                0x5C,
                0x42,
                0x92,
                0xF7,
                0xF5,
                0x22,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayEnhancementOverrideCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x60,
                0x70,
                0x45,
                0x5A,
                0xEE,
                0xB7,
                0x47,
                0x99,
                0x18,
                0x1E,
                0x51,
                0xE8,
                0x12,
                0xCC,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayEnhancementOverrideCapabilitiesChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0xE6,
                0x61,
                0xDB,
                0xFA,
                0x15,
                0xDA,
                0x49,
                0x8B,
                0x77,
                0x07,
                0xDB,
                0xD2,
                0xAF,
                0x58,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayEnhancementOverrideStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x7E,
                0x5B,
                0xCF,
                0x91,
                0x97,
                0x53,
                0x44,
                0xB0,
                0x13,
                0x29,
                0xB6,
                0xF7,
                0x78,
                0xE5,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0x12,
                0xD1,
                0xBE,
                0xC3,
                0xAD,
                0xC9,
                0x4D,
                0xAE,
                0x65,
                0x85,
                0x1F,
                0x4D,
                0x7D,
                0x47,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayInformation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x00,
                0xCD,
                0x4D,
                0xD1,
                0xFA,
                0x8E,
                0x4B,
                0x8E,
                0xDF,
                0x77,
                0x58,
                0x87,
                0xB8,
                0xBF,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayInformation3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x01,
                0x15,
                0xDB,
                0x09,
                0x0F,
                0x66,
                0x44,
                0x8F,
                0xF3,
                0x11,
                0xDE,
                0x9A,
                0x3C,
                0x92,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayInformation4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0xCE,
                0x72,
                0xC9,
                0x42,
                0x12,
                0xBE,
                0x46,
                0xB5,
                0x36,
                0xE1,
                0xAA,
                0xFE,
                0x9E,
                0x7A,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayInformation5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x42,
                0x54,
                0x3A,
                0xDE,
                0x2C,
                0x8D,
                0x4A,
                0x80,
                0xD1,
                0x21,
                0xDC,
                0x5A,
                0xDC,
                0xC1,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayInformationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x2A,
                0xA0,
                0xC6,
                0x52,
                0xD4,
                0xDC,
                0x44,
                0xBA,
                0x07,
                0x96,
                0xF3,
                0xC6,
                0xAD,
                0xF9,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayPropertiesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0xED,
                0x37,
                0x69,
                0xEA,
                0x30,
                0xED,
                0x4D,
                0x82,
                0x71,
                0x45,
                0x53,
                0xFF,
                0x02,
                0xF6,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_WinRT_IDisplayServices
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xF3,
                0x54,
                0x1B,
                0x0D,
                0x89,
                0x47,
                0x57,
                0xBD,
                0x26,
                0xFD,
                0xBD,
                0xEB,
                0x0C,
                0x8A,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayServicesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x96,
                0x20,
                0xDC,
                0x0A,
                0x73,
                0x60,
                0x55,
                0xB4,
                0x61,
                0x91,
                0xC1,
                0x3D,
                0x69,
                0x2E,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
