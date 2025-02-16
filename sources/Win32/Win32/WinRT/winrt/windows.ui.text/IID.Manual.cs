// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IContentLinkInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x25,
                0xD5,
                0x1E,
                0x5F,
                0x1C,
                0xCB,
                0x48,
                0xB3,
                0x35,
                0x78,
                0xB5,
                0x0A,
                0x2E,
                0xE6,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFontWeights
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0xA4,
                0x80,
                0x78,
                0xAB,
                0x01,
                0x97,
                0x49,
                0x85,
                0x17,
                0xDF,
                0x82,
                0x2A,
                0x0C,
                0x45,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFontWeightsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x79,
                0xB5,
                0xB3,
                0xA9,
                0x1B,
                0xEB,
                0x48,
                0x9D,
                0xAD,
                0xC0,
                0x95,
                0xE8,
                0xC2,
                0x3B,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRichEditTextRange
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x35,
                0x4E,
                0x37,
                0x8A,
                0xBA,
                0x6E,
                0x4A,
                0x8C,
                0x59,
                0x0D,
                0xDE,
                0x3D,
                0x0C,
                0xF5,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextCharacterFormat
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xF3,
                0xDE,
                0x5A,
                0xFB,
                0x05,
                0x2D,
                0x44,
                0x80,
                0x65,
                0x64,
                0x2A,
                0xFE,
                0xA0,
                0x2C,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextConstantsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x7C,
                0x9E,
                0x77,
                0x9D,
                0x18,
                0xFA,
                0x4B,
                0x97,
                0xC8,
                0x10,
                0xDB,
                0x13,
                0x5D,
                0x97,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextDocument
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x4D,
                0xEE,
                0xBE,
                0xB2,
                0x90,
                0x8C,
                0x40,
                0xA2,
                0xF6,
                0x0A,
                0x0A,
                0xC3,
                0x1E,
                0x33,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextDocument2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x11,
                0x31,
                0xF2,
                0x89,
                0x8C,
                0xC9,
                0x49,
                0x91,
                0x18,
                0xF0,
                0x57,
                0xCB,
                0xB8,
                0x14,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextDocument3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x03,
                0xAB,
                0x75,
                0xF8,
                0xA6,
                0x1D,
                0x44,
                0xAA,
                0x18,
                0x0A,
                0x85,
                0x1D,
                0x6E,
                0x5E,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextDocument4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x20,
                0x9C,
                0x61,
                0x3B,
                0xCB,
                0x21,
                0x45,
                0x98,
                0x1F,
                0x28,
                0x65,
                0xB1,
                0xB9,
                0x3F,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextParagraphFormat
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0xCF,
                0xF8,
                0x2C,
                0x76,
                0x46,
                0x8A,
                0x49,
                0x93,
                0xF5,
                0xBB,
                0xDB,
                0xFC,
                0x0B,
                0xD8,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextRange
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x4E,
                0x9E,
                0x5B,
                0x72,
                0xC0,
                0xA0,
                0x42,
                0x89,
                0x45,
                0xAF,
                0x50,
                0x3E,
                0xE5,
                0x47,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextSelection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x67,
                0xD3,
                0xA6,
                0x8F,
                0xF2,
                0x0A,
                0x43,
                0xB2,
                0xCF,
                0xC3,
                0x43,
                0x67,
                0x1E,
                0xC0,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
