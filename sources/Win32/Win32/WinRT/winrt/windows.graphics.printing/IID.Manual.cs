// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPrintTaskSourceRequestedHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x9F,
                0x10,
                0x6C,
                0xB6,
                0x5C,
                0x3A,
                0x4B,
                0x86,
                0x63,
                0xF3,
                0x9C,
                0xB0,
                0x2D,
                0xC9,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintDocumentSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x0C,
                0xDC,
                0xDE,
                0xEB,
                0xF1,
                0xDF,
                0x47,
                0xAA,
                0xE6,
                0xED,
                0x54,
                0x27,
                0x51,
                0x1F,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x96,
                0x2A,
                0xFF,
                0x99,
                0x8C,
                0xFD,
                0x44,
                0xAE,
                0x4A,
                0x19,
                0xD9,
                0xAA,
                0x9A,
                0x0F,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintManagerStatic
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x5D,
                0x18,
                0x58,
                0x34,
                0xE6,
                0x54,
                0x46,
                0x84,
                0xF0,
                0xE0,
                0x15,
                0x2A,
                0x82,
                0x17,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintManagerStatic2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x99,
                0xA9,
                0x35,
                0xAB,
                0xE6,
                0x39,
                0x41,
                0x9A,
                0xBD,
                0xB8,
                0x6A,
                0x72,
                0x9B,
                0x35,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintPageInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0xE9,
                0x4B,
                0xDD,
                0xA1,
                0xA6,
                0xDA,
                0x4A,
                0x93,
                0x0E,
                0xDA,
                0x87,
                0x2A,
                0x4F,
                0x23,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintPageRange
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0x6C,
                0xA0,
                0xF8,
                0x7C,
                0x6E,
                0xC5,
                0x51,
                0x57,
                0xFD,
                0x06,
                0x60,
                0xC2,
                0xD7,
                0x15,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintPageRangeFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xD4,
                0x8F,
                0x40,
                0x47,
                0xE0,
                0x85,
                0x5F,
                0x71,
                0x29,
                0xFB,
                0x08,
                0x5A,
                0x4F,
                0xAD,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintPageRangeOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0xB7,
                0x6D,
                0xCE,
                0x57,
                0x13,
                0xB2,
                0x46,
                0xA9,
                0x23,
                0x79,
                0xF9,
                0x95,
                0xF4,
                0x48,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTask
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x02,
                0xD8,
                0x61,
                0xF6,
                0x6C,
                0xAD,
                0x4F,
                0x84,
                0xE2,
                0xA5,
                0xE8,
                0x2E,
                0x2D,
                0x4C,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTask2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x48,
                0x23,
                0x36,
                0x53,
                0x3E,
                0x9D,
                0x4D,
                0x8F,
                0x5E,
                0x31,
                0x6A,
                0xC8,
                0xDE,
                0xDA,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x34,
                0xCD,
                0x5B,
                0xE9,
                0x24,
                0x10,
                0x4C,
                0x8D,
                0x07,
                0x14,
                0xC3,
                0x46,
                0xBA,
                0x3F,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x66,
                0x0A,
                0x5A,
                0x89,
                0xD2,
                0xBB,
                0x41,
                0x96,
                0xDD,
                0x57,
                0xE2,
                0x83,
                0x38,
                0xAE,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskOptions2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0x16,
                0x9B,
                0xEB,
                0x36,
                0x9A,
                0x59,
                0x4B,
                0x86,
                0x17,
                0xB2,
                0x17,
                0x84,
                0x92,
                0x62,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskOptionsCore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0xB4,
                0xDB,
                0x1B,
                0xD1,
                0x4E,
                0xEB,
                0x41,
                0xBE,
                0x3C,
                0x72,
                0xD1,
                0x8E,
                0xD6,
                0x73,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskOptionsCoreProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0x18,
                0xB7,
                0xC1,
                0x93,
                0x9E,
                0x55,
                0x4E,
                0x81,
                0x4B,
                0x33,
                0x26,
                0xA5,
                0x9E,
                0xFC,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskOptionsCoreUIConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x9E,
                0xE6,
                0x62,
                0x1E,
                0x9A,
                0x36,
                0x43,
                0xB7,
                0x4F,
                0x3C,
                0xC7,
                0xF4,
                0xCF,
                0xF7,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskProgressingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xD3,
                0x0C,
                0x81,
                0x10,
                0xB4,
                0x82,
                0x42,
                0xA0,
                0x73,
                0x5A,
                0xC3,
                0x78,
                0x23,
                0x41,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x1E,
                0xF6,
                0x6F,
                0x22,
                0x27,
                0x40,
                0x42,
                0xA6,
                0x7C,
                0xF3,
                0x64,
                0x84,
                0x9A,
                0x17,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskRequestedDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0xB3,
                0xEF,
                0xCF,
                0x3E,
                0xCE,
                0xC7,
                0x42,
                0x94,
                0x96,
                0x64,
                0x80,
                0x0C,
                0x62,
                0x2C,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0xF9,
                0xAF,
                0xD0,
                0x1B,
                0xA3,
                0x4C,
                0x45,
                0xA7,
                0xB6,
                0x5D,
                0x0C,
                0xC5,
                0x22,
                0xFC,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskSourceRequestedArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x67,
                0xF0,
                0xF9,
                0x56,
                0xF4,
                0xF0,
                0x41,
                0x9C,
                0x98,
                0x5C,
                0xE7,
                0x3E,
                0x85,
                0x14,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskSourceRequestedDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x60,
                0x15,
                0x4A,
                0x92,
                0x69,
                0x9D,
                0x4D,
                0x85,
                0x55,
                0x4C,
                0xA4,
                0x56,
                0x3F,
                0xB1,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskTargetDeviceSupport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x70,
                0x5D,
                0x29,
                0xCB,
                0xC2,
                0x7D,
                0x4B,
                0xB0,
                0xEA,
                0x93,
                0x09,
                0x50,
                0x91,
                0xA2,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStandardPrintTaskOptionsStatic
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x3D,
                0x48,
                0xB4,
                0xD0,
                0x0D,
                0xD4,
                0x4C,
                0xBA,
                0xFF,
                0x93,
                0x0F,
                0xC7,
                0xD6,
                0xA5,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStandardPrintTaskOptionsStatic2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x8B,
                0xE3,
                0x3B,
                0x44,
                0x7A,
                0x69,
                0x42,
                0x9A,
                0x52,
                0x81,
                0x26,
                0x1E,
                0x28,
                0x9E,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStandardPrintTaskOptionsStatic3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x8E,
                0xF6,
                0xBB,
                0x58,
                0x38,
                0xB3,
                0x41,
                0xA7,
                0x99,
                0x55,
                0xDD,
                0x98,
                0x88,
                0xD4,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
