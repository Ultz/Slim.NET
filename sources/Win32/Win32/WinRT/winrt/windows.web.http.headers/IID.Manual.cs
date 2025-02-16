// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IHttpCacheDirectiveHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0x6B,
                0x58,
                0x9A,
                0xD0,
                0xD5,
                0xBE,
                0x4F,
                0xBD,
                0x9D,
                0xB5,
                0xB3,
                0x63,
                0x68,
                0x11,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpChallengeHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x61,
                0x33,
                0x39,
                0x7D,
                0x0F,
                0x20,
                0x48,
                0x9F,
                0xDD,
                0xA2,
                0xB9,
                0x56,
                0xEE,
                0xAE,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpChallengeHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x5F,
                0x9E,
                0xCA,
                0xE0,
                0xAE,
                0x53,
                0x43,
                0xA1,
                0x0B,
                0xE6,
                0x25,
                0xBA,
                0xBD,
                0x64,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpChallengeHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xC4,
                0x52,
                0xC4,
                0x9C,
                0xD9,
                0xAA,
                0x40,
                0x93,
                0x99,
                0x90,
                0xEE,
                0xB9,
                0x8F,
                0xC6,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpChallengeHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x8A,
                0xD3,
                0xF3,
                0x01,
                0xFC,
                0x01,
                0x4D,
                0xA0,
                0x08,
                0xFC,
                0xB7,
                0xC4,
                0x59,
                0xD6,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpConnectionOptionHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0xF2,
                0x4A,
                0xCB,
                0x90,
                0x4E,
                0xEB,
                0x45,
                0x8D,
                0xCD,
                0xFD,
                0x14,
                0x08,
                0xF4,
                0xC4,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpConnectionOptionHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x6C,
                0xF5,
                0xE4,
                0x42,
                0x51,
                0x00,
                0x4E,
                0x8E,
                0x0F,
                0x01,
                0x95,
                0x09,
                0x33,
                0x76,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpConnectionOptionHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0xCC,
                0x3C,
                0xD9,
                0x7D,
                0x0B,
                0x3F,
                0x4C,
                0xA5,
                0x8D,
                0xA2,
                0xA1,
                0xBD,
                0xEA,
                0xBC,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpConnectionOptionHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x5D,
                0xA7,
                0xAA,
                0x46,
                0xA9,
                0x1F,
                0x4B,
                0x85,
                0xAF,
                0x48,
                0xB6,
                0x8B,
                0x3C,
                0x50,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentCodingHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0xF9,
                0xF7,
                0xBC,
                0x76,
                0x93,
                0x85,
                0x4D,
                0xBC,
                0xCC,
                0x9F,
                0x4F,
                0x9A,
                0xCA,
                0xB4,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentCodingHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x17,
                0x22,
                0x7D,
                0xDB,
                0xA6,
                0x6E,
                0x43,
                0x8E,
                0x83,
                0x91,
                0x59,
                0x61,
                0x92,
                0x81,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentCodingHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x2B,
                0x3D,
                0xC5,
                0x2B,
                0x33,
                0x50,
                0x43,
                0x85,
                0x10,
                0x2E,
                0x67,
                0xA2,
                0x28,
                0x9A,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentCodingHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x60,
                0xD8,
                0x94,
                0xBF,
                0xF9,
                0xF7,
                0x42,
                0xAA,
                0x46,
                0xED,
                0x27,
                0x2A,
                0x41,
                0xE2,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentCodingWithQualityHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x1C,
                0x53,
                0x94,
                0x13,
                0x8B,
                0x73,
                0x4D,
                0x86,
                0x51,
                0xF7,
                0x6B,
                0x38,
                0xF8,
                0x84,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentCodingWithQualityHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x75,
                0x0D,
                0x7C,
                0x99,
                0xE8,
                0x78,
                0x43,
                0xB5,
                0xC8,
                0x41,
                0x2D,
                0x82,
                0x07,
                0x11,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentCodingWithQualityHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0xEE,
                0x5E,
                0xC4,
                0x53,
                0xC5,
                0xFC,
                0x46,
                0xAD,
                0xE2,
                0xD7,
                0x5C,
                0x1D,
                0x53,
                0xDF,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentCodingWithQualityHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x35,
                0xC9,
                0xE8,
                0x89,
                0x8F,
                0x01,
                0x48,
                0x8E,
                0x75,
                0x4C,
                0x9A,
                0xBF,
                0xC3,
                0xDE,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentDispositionHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0xEE,
                0xA2,
                0xF2,
                0x29,
                0x26,
                0x49,
                0x4B,
                0x99,
                0x08,
                0x96,
                0xA1,
                0x68,
                0xE9,
                0x36,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentDispositionHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0xBB,
                0x15,
                0x99,
                0x6C,
                0x45,
                0x81,
                0x4E,
                0x82,
                0x95,
                0xB2,
                0xAB,
                0x3C,
                0xBC,
                0xF5,
                0x45,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentDispositionHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x60,
                0xC5,
                0x29,
                0x37,
                0x5A,
                0xE4,
                0x46,
                0xB0,
                0x74,
                0xC5,
                0x17,
                0x7D,
                0x69,
                0xCA,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentHeaderCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x2A,
                0x61,
                0x40,
                0xAE,
                0x47,
                0x7E,
                0x4B,
                0x91,
                0x24,
                0x69,
                0x62,
                0x8B,
                0x64,
                0xAA,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentRangeHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x67,
                0xD9,
                0x04,
                0xF6,
                0xA4,
                0x5C,
                0x49,
                0x95,
                0x30,
                0x85,
                0x79,
                0xFC,
                0xBA,
                0x8A,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentRangeHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0xD6,
                0x5B,
                0x3F,
                0x3C,
                0xA0,
                0x56,
                0x44,
                0x9A,
                0x6F,
                0xEF,
                0x27,
                0xEC,
                0xD0,
                0x3C,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContentRangeHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0x46,
                0xA3,
                0x80,
                0x4C,
                0x17,
                0xAE,
                0x4F,
                0x82,
                0x1C,
                0x13,
                0x4C,
                0xD2,
                0x94,
                0xAA,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCookiePairHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x62,
                0xD4,
                0xCB,
                0x29,
                0x4B,
                0x2B,
                0x41,
                0xBD,
                0x90,
                0xB3,
                0xD8,
                0x14,
                0xAB,
                0x8E,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCookiePairHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x43,
                0xF4,
                0xF3,
                0x1E,
                0x58,
                0xCC,
                0x4E,
                0x9F,
                0x59,
                0xE5,
                0x07,
                0xD0,
                0x4F,
                0x06,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCookiePairHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x32,
                0x5E,
                0x63,
                0x6F,
                0x14,
                0x56,
                0x4F,
                0xAA,
                0x21,
                0x2C,
                0xB7,
                0xD6,
                0xD5,
                0x8B,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCookiePairHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x6D,
                0x86,
                0x6E,
                0xAF,
                0x06,
                0x62,
                0x44,
                0x81,
                0x58,
                0x99,
                0x38,
                0x8D,
                0x5D,
                0xCA,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCredentialsHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xC3,
                0x4C,
                0xC3,
                0x2E,
                0x54,
                0x77,
                0x41,
                0xA6,
                0xC7,
                0xB6,
                0x74,
                0xCE,
                0x19,
                0x3F,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCredentialsHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x9E,
                0x1D,
                0xF2,
                0x1C,
                0x4D,
                0x82,
                0x41,
                0xBF,
                0xD1,
                0x34,
                0x47,
                0x0A,
                0x62,
                0xF9,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCredentialsHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x2B,
                0x9B,
                0xA6,
                0x8C,
                0xCE,
                0x43,
                0x44,
                0xA3,
                0x5A,
                0x1B,
                0x72,
                0x7B,
                0x13,
                0x10,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpDateOrDeltaHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xAA,
                0xFC,
                0xEA,
                0xDC,
                0xC4,
                0xE2,
                0x49,
                0xA2,
                0x7D,
                0x04,
                0x3A,
                0xDF,
                0x58,
                0x67,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpDateOrDeltaHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x59,
                0x26,
                0x7C,
                0x72,
                0x66,
                0x90,
                0x4E,
                0x9A,
                0x9A,
                0xF3,
                0x97,
                0x66,
                0xF7,
                0xF5,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpExpectationHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x85,
                0xE5,
                0x4C,
                0x99,
                0x3A,
                0xAF,
                0x43,
                0xA2,
                0xE6,
                0xEC,
                0x23,
                0x2F,
                0xEA,
                0x96,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpExpectationHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x21,
                0x85,
                0xE7,
                0xE2,
                0xA0,
                0xC4,
                0x4A,
                0x9E,
                0x66,
                0x79,
                0x70,
                0x6C,
                0xB9,
                0xFD,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpExpectationHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x75,
                0xA2,
                0x4E,
                0x3E,
                0xD5,
                0x68,
                0x48,
                0x88,
                0x56,
                0x1E,
                0x21,
                0xA5,
                0x03,
                0x0D,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpExpectationHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0xAB,
                0x19,
                0x30,
                0xE5,
                0xCF,
                0x3B,
                0x47,
                0xA5,
                0x7F,
                0xFB,
                0xA5,
                0xB1,
                0x4E,
                0xB2,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpLanguageHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x7C,
                0xBD,
                0x9E,
                0x19,
                0x82,
                0xF6,
                0x44,
                0x99,
                0x02,
                0x8C,
                0x56,
                0xDF,
                0xD3,
                0x34,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpLanguageRangeWithQualityHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xE1,
                0x56,
                0x72,
                0x80,
                0x00,
                0xB4,
                0x4D,
                0xA0,
                0x83,
                0x7D,
                0xE7,
                0xB2,
                0xE5,
                0xBA,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpLanguageRangeWithQualityHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x5A,
                0x5D,
                0x88,
                0x4F,
                0x4B,
                0x0A,
                0x48,
                0x89,
                0xCE,
                0x8A,
                0xED,
                0xCE,
                0xE6,
                0xE3,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpLanguageRangeWithQualityHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x39,
                0xB8,
                0x7B,
                0x0F,
                0x78,
                0x83,
                0x4C,
                0x9F,
                0xE4,
                0xDC,
                0x30,
                0x87,
                0xF6,
                0xBD,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpLanguageRangeWithQualityHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xE1,
                0x41,
                0x25,
                0x08,
                0xF3,
                0xF5,
                0x46,
                0xB6,
                0x95,
                0x42,
                0xF5,
                0x40,
                0x24,
                0xEC,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMediaTypeHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x85,
                0xB2,
                0x16,
                0x28,
                0xE7,
                0xCB,
                0x4F,
                0xBD,
                0xB0,
                0x08,
                0xA4,
                0x31,
                0xA1,
                0x48,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMediaTypeHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x47,
                0xD7,
                0xBE,
                0x17,
                0xCD,
                0xDD,
                0x42,
                0x93,
                0x67,
                0xAB,
                0x9C,
                0x5B,
                0x56,
                0xDD,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMediaTypeHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x83,
                0x4D,
                0xE0,
                0x41,
                0x1D,
                0x8C,
                0x4D,
                0xA2,
                0xDE,
                0x6F,
                0xD2,
                0xED,
                0x87,
                0x39,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMediaTypeWithQualityHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0x5E,
                0x8D,
                0x18,
                0xBE,
                0x76,
                0xA0,
                0x44,
                0xB1,
                0xCD,
                0x20,
                0x74,
                0xBD,
                0xED,
                0x2D,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMediaTypeWithQualityHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x6B,
                0x0C,
                0x3C,
                0x42,
                0x13,
                0x87,
                0x45,
                0xA0,
                0x56,
                0x18,
                0xD0,
                0x2F,
                0xF6,
                0x71,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMediaTypeWithQualityHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x20,
                0x6D,
                0x4C,
                0x57,
                0x94,
                0xE6,
                0x44,
                0xA3,
                0x23,
                0xD1,
                0x22,
                0xB9,
                0x58,
                0x78,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMediaTypeWithQualityHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x0C,
                0x07,
                0x5B,
                0x60,
                0xB5,
                0xC8,
                0x4F,
                0x98,
                0x35,
                0x7E,
                0x6C,
                0x0A,
                0x65,
                0x7B,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMethodHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x3F,
                0xBC,
                0x43,
                0x19,
                0x61,
                0xDF,
                0x4A,
                0x93,
                0x8C,
                0x34,
                0xBF,
                0xFF,
                0xCF,
                0x92,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpNameValueHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0x74,
                0xBA,
                0xD8,
                0x9A,
                0x5B,
                0x1B,
                0x4D,
                0x93,
                0xF9,
                0xAA,
                0x5B,
                0x44,
                0xEC,
                0xFD,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpNameValueHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x22,
                0x0E,
                0x77,
                0xF8,
                0xCB,
                0x36,
                0x47,
                0xA9,
                0x25,
                0x93,
                0xFB,
                0xE1,
                0x0C,
                0x7C,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpNameValueHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x03,
                0xD4,
                0xFF,
                0x30,
                0x11,
                0x52,
                0x41,
                0x86,
                0x59,
                0x25,
                0x69,
                0x09,
                0xA9,
                0xD1,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpProductHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0xEE,
                0xFE,
                0xF4,
                0xD4,
                0xEB,
                0x60,
                0x41,
                0xB9,
                0xFF,
                0x80,
                0x7C,
                0x51,
                0x83,
                0xB6,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpProductHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0xA4,
                0x1A,
                0x61,
                0xBC,
                0x82,
                0xFB,
                0x42,
                0x97,
                0x7B,
                0xDC,
                0x00,
                0x53,
                0x6E,
                0x5E,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpProductHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0x3E,
                0xC3,
                0x90,
                0xFC,
                0xBE,
                0x37,
                0x43,
                0xBE,
                0x62,
                0x49,
                0xF0,
                0x97,
                0x97,
                0x5F,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpProductInfoHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0x87,
                0x1A,
                0x1B,
                0x35,
                0x4C,
                0x6A,
                0x48,
                0x96,
                0x6F,
                0x64,
                0x64,
                0x89,
                0x19,
                0x8E,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpProductInfoHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0xF7,
                0x7D,
                0x87,
                0x9B,
                0xD6,
                0xF8,
                0x44,
                0xAD,
                0x4F,
                0x45,
                0x3A,
                0xF9,
                0xC4,
                0x2E,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpProductInfoHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x0F,
                0x22,
                0x24,
                0xBE,
                0xEA,
                0x64,
                0x44,
                0xB4,
                0x60,
                0xEC,
                0x01,
                0x0B,
                0x7C,
                0x41,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpProductInfoHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xD8,
                0x7F,
                0xDB,
                0x7A,
                0x32,
                0x73,
                0x4E,
                0x81,
                0xE5,
                0x70,
                0x59,
                0xA3,
                0x02,
                0xB0,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpRequestHeaderCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x32,
                0x40,
                0xAF,
                0x44,
                0xB5,
                0x9B,
                0x46,
                0x86,
                0xB9,
                0xAC,
                0x3D,
                0x46,
                0x6F,
                0xEA,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpResponseHeaderCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0x09,
                0x99,
                0x7A,
                0x3F,
                0xFA,
                0xED,
                0x41,
                0xAA,
                0xC6,
                0xBF,
                0x95,
                0x79,
                0x75,
                0xC1,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpTransferCodingHeaderValue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x32,
                0x6F,
                0x43,
                0xED,
                0x3D,
                0xBD,
                0x42,
                0xB3,
                0x8A,
                0x54,
                0x96,
                0xA2,
                0x51,
                0x1C,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpTransferCodingHeaderValueCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x8C,
                0x2C,
                0x20,
                0x03,
                0x2C,
                0xB8,
                0x49,
                0x96,
                0x65,
                0x73,
                0xE2,
                0x7C,
                0xB2,
                0xFC,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpTransferCodingHeaderValueFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xDF,
                0x62,
                0xBB,
                0x61,
                0xE3,
                0x08,
                0x4F,
                0x8E,
                0x4F,
                0xC9,
                0xE7,
                0x23,
                0xDE,
                0x70,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpTransferCodingHeaderValueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0x89,
                0xB8,
                0x6A,
                0x98,
                0x1A,
                0x32,
                0x4D,
                0xA9,
                0x06,
                0x74,
                0x70,
                0xA9,
                0x87,
                0x5C,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
