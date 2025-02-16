// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.globalization.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IApplicationLanguagesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x08,
                0xB4,
                0x75,
                0x4C,
                0x0A,
                0x92,
                0x4A,
                0x95,
                0x65,
                0xFD,
                0x63,
                0xC9,
                0x5F,
                0x7A,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationLanguagesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0xDE,
                0xF0,
                0x1D,
                0x2B,
                0x07,
                0x7B,
                0x4D,
                0x8F,
                0x06,
                0xCB,
                0x2D,
                0xB4,
                0x0F,
                0x2B,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICalendar
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x22,
                0x30,
                0xCA,
                0xD9,
                0x86,
                0xFB,
                0x40,
                0xA2,
                0x6B,
                0xD4,
                0x4E,
                0xB7,
                0xCF,
                0x08,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICalendarFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x84,
                0xF5,
                0x83,
                0x6B,
                0xE5,
                0x75,
                0x4C,
                0xA6,
                0x6E,
                0x0F,
                0x63,
                0xD5,
                0x77,
                0x58,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICalendarFactory2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x37,
                0x4B,
                0xB4,
                0x7E,
                0xCA,
                0x90,
                0x45,
                0x9E,
                0x72,
                0xEA,
                0x2B,
                0xEC,
                0x1A,
                0x51,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICalendarIdentifiersStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x3F,
                0x65,
                0x80,
                0xB2,
                0x2C,
                0x1F,
                0x4C,
                0xB5,
                0x90,
                0xF0,
                0xF5,
                0x2B,
                0xF4,
                0xFD,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICalendarIdentifiersStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xD4,
                0xF4,
                0x7D,
                0xD0,
                0x5F,
                0xA7,
                0x42,
                0x95,
                0xB5,
                0x7D,
                0x98,
                0xD8,
                0x23,
                0x07,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICalendarIdentifiersStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x54,
                0x22,
                0x2C,
                0xAD,
                0x1F,
                0xC0,
                0x40,
                0x93,
                0x34,
                0xA8,
                0xEB,
                0x90,
                0xDB,
                0x04,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IClockIdentifiersStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x05,
                0x38,
                0x52,
                0xEC,
                0x12,
                0x83,
                0x4F,
                0xBC,
                0x31,
                0xB1,
                0xB4,
                0x37,
                0x6B,
                0x08,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICurrencyAmount
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x99,
                0xB4,
                0x74,
                0x75,
                0xEB,
                0x3A,
                0x44,
                0x95,
                0xB3,
                0x7D,
                0x72,
                0x3F,
                0x56,
                0xF9,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICurrencyAmountFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x16,
                0xD7,
                0x48,
                0x3B,
                0xEF,
                0xEE,
                0x4A,
                0xA6,
                0xA1,
                0x4B,
                0x03,
                0x6F,
                0xE0,
                0x3F,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICurrencyIdentifiersStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x09,
                0x1D,
                0x9F,
                0x86,
                0xD5,
                0x13,
                0x49,
                0x9B,
                0x6A,
                0xA9,
                0xBD,
                0x2D,
                0xC1,
                0x28,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICurrencyIdentifiersStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x79,
                0x14,
                0x18,
                0xB2,
                0xC3,
                0x33,
                0x4C,
                0x95,
                0x91,
                0x98,
                0x00,
                0x11,
                0x95,
                0x0D,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICurrencyIdentifiersStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x3B,
                0xB2,
                0x4F,
                0x25,
                0xED,
                0x4D,
                0x4F,
                0x85,
                0x7F,
                0x23,
                0x7F,
                0x17,
                0x48,
                0xC2,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeographicRegion
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0xA6,
                0xE9,
                0x01,
                0x64,
                0x4A,
                0xD9,
                0x4E,
                0x95,
                0x4F,
                0x9E,
                0xDE,
                0xB0,
                0x7B,
                0xD9,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeographicRegionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x52,
                0x42,
                0x53,
                0xB4,
                0x77,
                0x6B,
                0x42,
                0x85,
                0x9F,
                0x81,
                0xE1,
                0x9D,
                0x51,
                0x25,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeographicRegionStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x89,
                0xE2,
                0x29,
                0xD9,
                0x7A,
                0xF4,
                0x4E,
                0x87,
                0x99,
                0xB3,
                0xB4,
                0x4F,
                0xAD,
                0xEC,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IJapanesePhoneme
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x93,
                0x6A,
                0x2F,
                0x5B,
                0xE8,
                0xE6,
                0x43,
                0x89,
                0x7D,
                0x5D,
                0x82,
                0xF8,
                0x62,
                0xDF,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IJapanesePhoneticAnalyzerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x9E,
                0xAB,
                0x88,
                0xDE,
                0x93,
                0xB2,
                0x41,
                0xB4,
                0xD5,
                0x8E,
                0xDB,
                0x22,
                0x7F,
                0xD1,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0xA7,
                0x79,
                0xEA,
                0xC2,
                0xF7,
                0x65,
                0x42,
                0xB1,
                0xBD,
                0xC4,
                0xDE,
                0xC4,
                0xE4,
                0xF0,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguage2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0xE5,
                0x47,
                0x6A,
                0x4D,
                0xD9,
                0x86,
                0x48,
                0xA4,
                0x04,
                0xA5,
                0xA5,
                0xB9,
                0xD5,
                0xB4,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguage3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x3D,
                0xAF,
                0xC6,
                0x1A,
                0x64,
                0xA4,
                0x5B,
                0xBB,
                0x43,
                0x5E,
                0x12,
                0xAE,
                0xD7,
                0x59,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguageExtensionSubtags
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0xAF,
                0x7D,
                0x7D,
                0x8D,
                0x36,
                0x64,
                0x43,
                0x85,
                0x2B,
                0xDE,
                0xC9,
                0x27,
                0x03,
                0x7B,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguageFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x52,
                0x02,
                0x9B,
                0x27,
                0x0C,
                0xF8,
                0x44,
                0xB7,
                0x92,
                0x97,
                0x93,
                0xFB,
                0x66,
                0xC6,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguageStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xD5,
                0x3C,
                0xB2,
                0x65,
                0x08,
                0xD4,
                0x46,
                0x89,
                0xB8,
                0xD5,
                0x9B,
                0xE8,
                0x99,
                0x0F,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguageStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x9F,
                0x19,
                0x30,
                0x4B,
                0x91,
                0x2A,
                0x4B,
                0x9D,
                0x6E,
                0xE3,
                0xB0,
                0xE2,
                0x7D,
                0xBE,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanguageStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0xCB,
                0x5E,
                0xD1,
                0xDE,
                0x71,
                0x52,
                0x57,
                0x95,
                0x42,
                0xFA,
                0xC5,
                0xB4,
                0xF2,
                0x72,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INumeralSystemIdentifiersStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x62,
                0xC6,
                0xA5,
                0xC9,
                0x68,
                0x3D,
                0x4D,
                0xB7,
                0x65,
                0x97,
                0x20,
                0x29,
                0xE2,
                0x1D,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INumeralSystemIdentifiersStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x32,
                0x00,
                0x7F,
                0xDB,
                0x9D,
                0x34,
                0x4A,
                0x91,
                0x04,
                0x02,
                0x60,
                0xC0,
                0x91,
                0xA7,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimeZoneOnCalendar
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x25,
                0x3C,
                0xBB,
                0xCF,
                0x46,
                0x17,
                0x43,
                0xA3,
                0xF5,
                0x02,
                0x62,
                0x1A,
                0xD5,
                0x44,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
