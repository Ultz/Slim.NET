// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IIppAttributeError
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xED,
                0x0F,
                0x75,
                0xEF,
                0x9E,
                0x39,
                0x5C,
                0x93,
                0xE4,
                0x46,
                0x14,
                0x9B,
                0xBC,
                0xEF,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppAttributeValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x7F,
                0x40,
                0x99,
                0xBB,
                0xE2,
                0xA3,
                0x59,
                0x98,
                0x8B,
                0x28,
                0xA9,
                0x74,
                0x05,
                0x2A,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppAttributeValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x39,
                0xD4,
                0x10,
                0x94,
                0xDD,
                0x98,
                0x59,
                0xB2,
                0x35,
                0xAF,
                0xAF,
                0xB6,
                0xFA,
                0x79,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppIntegerRange
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x73,
                0x90,
                0x92,
                0xEA,
                0xC3,
                0xD6,
                0x5E,
                0xBD,
                0xB1,
                0x37,
                0x52,
                0xC6,
                0x2C,
                0x6F,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppIntegerRangeFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0xEC,
                0xD4,
                0x75,
                0x7E,
                0xF8,
                0xAD,
                0x54,
                0xB5,
                0xD0,
                0x46,
                0x52,
                0x04,
                0xDB,
                0x75,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppPrintDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0xAC,
                0x48,
                0xD7,
                0xF3,
                0x76,
                0xC6,
                0x5D,
                0xAF,
                0xD4,
                0xC2,
                0xA8,
                0x68,
                0x6B,
                0x93,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppPrintDevice2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x44,
                0xC8,
                0xF7,
                0x21,
                0x9D,
                0x63,
                0x5C,
                0xAC,
                0x20,
                0x36,
                0x76,
                0x91,
                0x5B,
                0xE2,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppPrintDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x9F,
                0xC1,
                0x7D,
                0x20,
                0x7F,
                0xAB,
                0x52,
                0x94,
                0xA7,
                0x89,
                0x4B,
                0x83,
                0xB2,
                0xA1,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppResolution
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x3F,
                0x49,
                0xCB,
                0xF3,
                0x6B,
                0xF5,
                0x56,
                0x86,
                0xCE,
                0x26,
                0x3D,
                0x08,
                0xAE,
                0xAD,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppResolutionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0xC2,
                0x81,
                0xE4,
                0x1A,
                0x25,
                0x26,
                0x53,
                0xB1,
                0x73,
                0x95,
                0x54,
                0x3E,
                0xD9,
                0x9A,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppSetAttributesResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x7F,
                0x1C,
                0x7D,
                0x9D,
                0xAA,
                0xA3,
                0x58,
                0x90,
                0xE9,
                0x17,
                0xBD,
                0xC5,
                0x28,
                0x1F,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppTextWithLanguage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x47,
                0x64,
                0x32,
                0x49,
                0x51,
                0x36,
                0x59,
                0x90,
                0xE8,
                0x0C,
                0x73,
                0x60,
                0x36,
                0xBF,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIppTextWithLanguageFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x1E,
                0x4A,
                0xCA,
                0x68,
                0x29,
                0x75,
                0x57,
                0x99,
                0x7C,
                0x8A,
                0x46,
                0xF1,
                0xA5,
                0x74,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPageConfigurationSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0x1E,
                0xFC,
                0xB6,
                0x31,
                0x53,
                0xFF,
                0x54,
                0x95,
                0xA0,
                0x1F,
                0xCB,
                0x76,
                0xBB,
                0x97,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPdlPassthroughProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x1D,
                0xC7,
                0x23,
                0x17,
                0x61,
                0x3F,
                0x55,
                0x93,
                0x78,
                0x18,
                0x0A,
                0xF5,
                0x84,
                0x9A,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPdlPassthroughTarget
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0xBE,
                0x40,
                0x98,
                0xF8,
                0x67,
                0x85,
                0x53,
                0xA5,
                0xB9,
                0xE8,
                0xC9,
                0x6E,
                0x0F,
                0xCA,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrint3DDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x3D,
                0x1C,
                0x04,
                0x13,
                0x97,
                0xA2,
                0x42,
                0x98,
                0x13,
                0x7D,
                0xC3,
                0x33,
                0x74,
                0x28,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrint3DDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x62,
                0xE3,
                0xFD,
                0xCD,
                0x67,
                0xB7,
                0x41,
                0xA3,
                0x44,
                0x51,
                0x50,
                0xA1,
                0xFD,
                0x75,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintSchema
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x83,
                0xB9,
                0xC2,
                0xB8,
                0x26,
                0xFB,
                0x4B,
                0x81,
                0x38,
                0x9F,
                0x96,
                0x2C,
                0x22,
                0xA3,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
