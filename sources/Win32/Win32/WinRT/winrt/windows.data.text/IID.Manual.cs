// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ISelectableWordSegmentsTokenizingHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0xFC,
                0x3D,
                0x3A,
                0xDE,
                0xAE,
                0xC7,
                0x4D,
                0x9E,
                0x6C,
                0x41,
                0xC0,
                0x44,
                0xBD,
                0x35,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWordSegmentsTokenizingHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x63,
                0xDD,
                0xA5,
                0x2A,
                0xBF,
                0x4F,
                0x4C,
                0xA3,
                0x1F,
                0x29,
                0xE7,
                0x1C,
                0x6F,
                0x8B,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAlternateWordForm
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x6C,
                0x39,
                0x47,
                0xB9,
                0x51,
                0x07,
                0x42,
                0x91,
                0x46,
                0x24,
                0x8E,
                0x63,
                0x6A,
                0x1D,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISelectableWordSegment
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x4C,
                0x6A,
                0x91,
                0xA7,
                0x8A,
                0x78,
                0x4C,
                0xB3,
                0x74,
                0x5D,
                0xED,
                0xB7,
                0x52,
                0xE6,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISelectableWordsSegmenter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x31,
                0xDC,
                0xF6,
                0x13,
                0x4B,
                0xC5,
                0x45,
                0x88,
                0x97,
                0x7D,
                0x71,
                0x26,
                0x9E,
                0x08,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISelectableWordsSegmenterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x76,
                0x7A,
                0x8C,
                0x57,
                0x60,
                0x39,
                0x43,
                0xBC,
                0x70,
                0xF2,
                0x10,
                0x01,
                0x0A,
                0x41,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISemanticTextQuery
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xAB,
                0x1C,
                0x6A,
                0xB2,
                0x1F,
                0x09,
                0x49,
                0x80,
                0xB8,
                0x35,
                0x73,
                0x1A,
                0x2B,
                0x3E,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISemanticTextQueryFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x05,
                0x8C,
                0x23,
                0x95,
                0xF9,
                0x87,
                0x45,
                0x87,
                0x77,
                0xA2,
                0xB7,
                0xD8,
                0x0A,
                0xCF,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextConversionGenerator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x6A,
                0x60,
                0x03,
                0xA9,
                0x2A,
                0xB6,
                0x4A,
                0xAF,
                0x8B,
                0xA5,
                0x62,
                0xB6,
                0x3A,
                0x89,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextConversionGeneratorFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x37,
                0xAA,
                0xFC,
                0x83,
                0x30,
                0xAB,
                0x49,
                0xBE,
                0x15,
                0x56,
                0xDF,
                0xBB,
                0xB7,
                0x4D,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextPhoneme
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0xA4,
                0x62,
                0x93,
                0x7A,
                0x9B,
                0x69,
                0x45,
                0x94,
                0xCF,
                0xD8,
                0x4F,
                0x2F,
                0x38,
                0xCF,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextPredictionGenerator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0xAB,
                0xAC,
                0x5E,
                0xF1,
                0xAB,
                0xB6,
                0x4C,
                0x9D,
                0x9E,
                0x32,
                0x6F,
                0x2B,
                0x46,
                0x87,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextPredictionGenerator2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x23,
                0x47,
                0xB8,
                0x77,
                0x2C,
                0x6A,
                0x48,
                0x90,
                0x0A,
                0xA3,
                0x45,
                0x3E,
                0xED,
                0xC1,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextPredictionGeneratorFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0xB4,
                0x57,
                0x72,
                0xA2,
                0x8B,
                0x51,
                0x47,
                0x9D,
                0x30,
                0x9D,
                0x85,
                0x43,
                0x56,
                0x53,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextReverseConversionGenerator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0xF5,
                0xE7,
                0x51,
                0x51,
                0x9C,
                0x86,
                0x4D,
                0xAE,
                0x1B,
                0xB4,
                0x98,
                0xFB,
                0xAD,
                0x83,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextReverseConversionGenerator2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0xD2,
                0xAF,
                0x1A,
                0xD6,
                0x85,
                0xFD,
                0x46,
                0x82,
                0x8A,
                0x3A,
                0x48,
                0x30,
                0xFA,
                0x6E,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITextReverseConversionGeneratorFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0xD3,
                0xBE,
                0x63,
                0xDA,
                0x1F,
                0xF6,
                0x41,
                0x89,
                0xD5,
                0x23,
                0xDD,
                0xEA,
                0x3C,
                0x72,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUnicodeCharactersStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x9E,
                0x90,
                0x97,
                0x91,
                0x92,
                0x91,
                0x4F,
                0xB6,
                0xC8,
                0xB6,
                0xE3,
                0x59,
                0xD7,
                0xA7,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWordSegment
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0xBA,
                0xD4,
                0xD2,
                0x7C,
                0x98,
                0xC0,
                0x4C,
                0xB6,
                0xBD,
                0xD4,
                0x9A,
                0x11,
                0xB3,
                0x8F,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWordsSegmenter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xD4,
                0xB4,
                0x86,
                0xFE,
                0xB2,
                0x34,
                0x4E,
                0xA8,
                0x1D,
                0x66,
                0x64,
                0x03,
                0x00,
                0x45,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWordsSegmenterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x72,
                0x97,
                0xE6,
                0x35,
                0xFC,
                0x5C,
                0x45,
                0x8B,
                0xFB,
                0x6D,
                0x7F,
                0x46,
                0x53,
                0xCA,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
