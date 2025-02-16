// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAsyncActionCompletedHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x5C,
                0xED,
                0xA4,
                0xC9,
                0x76,
                0xBD,
                0x40,
                0x8B,
                0xE6,
                0xB1,
                0xD9,
                0x0F,
                0xB2,
                0x0A,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeferralCompletedHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0xA3,
                0x32,
                0xED,
                0xC8,
                0xF3,
                0xAA,
                0x4F,
                0x9C,
                0xFB,
                0x47,
                0x01,
                0x48,
                0xDA,
                0x38,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertySet
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0xED,
                0x43,
                0x8A,
                0xE6,
                0xF4,
                0x21,
                0x44,
                0xAC,
                0xF9,
                0x1D,
                0xAB,
                0x29,
                0x86,
                0x82,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAsyncAction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0x80,
                0x64,
                0x5A,
                0x3A,
                0x84,
                0xA9,
                0x4D,
                0x86,
                0x5B,
                0x9D,
                0x26,
                0xE5,
                0xDF,
                0xAD,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IClosable
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xA8,
                0xD5,
                0x30,
                0xA4,
                0x7F,
                0x26,
                0x40,
                0x83,
                0xBB,
                0xD7,
                0x5B,
                0xAE,
                0x4E,
                0xA9,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0x97,
                0x26,
                0xD6,
                0x7F,
                0x3B,
                0xA7,
                0x46,
                0xB4,
                0x0B,
                0x4F,
                0xDC,
                0xA2,
                0xA2,
                0xC6,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeferralFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0xEC,
                0xA1,
                0x65,
                0xB5,
                0x3F,
                0x32,
                0x48,
                0x8C,
                0xA9,
                0xF0,
                0x61,
                0xB2,
                0x81,
                0xD1,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGetActivationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x8E,
                0xDB,
                0x4E,
                0xDD,
                0x96,
                0xA7,
                0x49,
                0x94,
                0xF7,
                0x46,
                0x07,
                0xDD,
                0xAB,
                0x8E,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGuidHelperStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0x96,
                0xC7,
                0x59,
                0x52,
                0xAE,
                0x83,
                0x52,
                0xAD,
                0x7F,
                0xA1,
                0xB9,
                0xE9,
                0x67,
                0x8A,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMemoryBuffer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0xDD,
                0xC4,
                0xFB,
                0x5B,
                0x24,
                0xE4,
                0x11,
                0xAF,
                0x98,
                0x68,
                0x94,
                0x23,
                0x26,
                0x0C,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMemoryBufferFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xDD,
                0xC4,
                0xFB,
                0x5B,
                0x24,
                0xE4,
                0x11,
                0xAF,
                0x98,
                0x68,
                0x94,
                0x23,
                0x26,
                0x0C,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMemoryBufferReference
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xDD,
                0xC4,
                0xFB,
                0x5B,
                0x24,
                0xE4,
                0x11,
                0xAF,
                0x98,
                0x68,
                0x94,
                0x23,
                0x26,
                0x0C,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x82,
                0xD6,
                0x4B,
                0x54,
                0x75,
                0xE9,
                0x40,
                0x9A,
                0x9B,
                0x82,
                0x65,
                0x4E,
                0xDE,
                0x7E,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPropertyValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0xDB,
                0x9B,
                0x62,
                0x32,
                0xD9,
                0xF4,
                0x4F,
                0x96,
                0xB9,
                0x8D,
                0x96,
                0xC5,
                0xC1,
                0xE8,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStringable
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0x9F,
                0x36,
                0x96,
                0xB6,
                0x8E,
                0xF0,
                0x48,
                0xAB,
                0xCE,
                0xC1,
                0xB2,
                0x11,
                0xE6,
                0x27,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUriEscapeStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x32,
                0xD4,
                0xC1,
                0x24,
                0xC8,
                0x52,
                0x44,
                0xA7,
                0xFD,
                0x51,
                0x2B,
                0xC3,
                0xBB,
                0xE9,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUriRuntimeClass
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x5E,
                0x36,
                0x9E,
                0xB2,
                0x48,
                0x60,
                0x41,
                0x95,
                0x6F,
                0xC7,
                0x38,
                0x51,
                0x20,
                0xBB,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUriRuntimeClassFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x79,
                0xA9,
                0x44,
                0x3E,
                0x72,
                0xDF,
                0x4F,
                0xA2,
                0x18,
                0x03,
                0x3E,
                0x75,
                0xB0,
                0xC0,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUriRuntimeClassWithAbsoluteCanonicalUri
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x96,
                0x8D,
                0x75,
                0x1C,
                0x22,
                0x0F,
                0x48,
                0xA3,
                0x39,
                0x50,
                0x65,
                0x66,
                0x73,
                0xF4,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWwwFormUrlDecoderEntry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0x74,
                0x5E,
                0x12,
                0x78,
                0xF6,
                0x8E,
                0x4E,
                0xB6,
                0x70,
                0x20,
                0xA9,
                0xB0,
                0x6C,
                0x51,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWwwFormUrlDecoderRuntimeClass
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x04,
                0x5A,
                0xD4,
                0x25,
                0xF2,
                0x42,
                0x45,
                0x92,
                0x96,
                0x0E,
                0x1D,
                0xF5,
                0xD2,
                0x54,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWwwFormUrlDecoderRuntimeClassFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x6B,
                0x8C,
                0x5B,
                0xAE,
                0x24,
                0xB5,
                0x41,
                0xA1,
                0xBF,
                0xF0,
                0xC3,
                0xD5,
                0x44,
                0x84,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
