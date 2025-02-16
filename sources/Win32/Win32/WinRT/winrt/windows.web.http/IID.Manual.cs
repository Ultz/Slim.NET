// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IHttpBufferContentFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0xC1,
                0x20,
                0xBC,
                0x1F,
                0xC4,
                0xF7,
                0x4F,
                0x91,
                0x23,
                0x64,
                0x35,
                0x73,
                0x6E,
                0xAD,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpClient
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x11,
                0xDA,
                0x7F,
                0x74,
                0x35,
                0x80,
                0x48,
                0xA8,
                0xBA,
                0xE6,
                0xB1,
                0xE0,
                0x06,
                0x1F,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpClient2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x33,
                0xD8,
                0xCD,
                0xB7,
                0xE8,
                0xEC,
                0x4C,
                0xB1,
                0xB0,
                0xDC,
                0x45,
                0x5F,
                0xE7,
                0x2C,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpClient3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xFD,
                0x72,
                0x11,
                0x99,
                0x98,
                0x94,
                0x41,
                0x96,
                0x3F,
                0x8F,
                0x9D,
                0x72,
                0xA7,
                0xEC,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpClientFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0x4E,
                0x0C,
                0xC3,
                0xFA,
                0xE3,
                0x99,
                0x4F,
                0xAF,
                0xB4,
                0x63,
                0xCC,
                0x65,
                0x00,
                0x94,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpContent
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xA4,
                0x14,
                0x6B,
                0xA7,
                0xFB,
                0xD2,
                0x4B,
                0xAF,
                0x0A,
                0x83,
                0x9D,
                0xE7,
                0xC2,
                0x95,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCookie
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x88,
                0x54,
                0x1F,
                0x2D,
                0xCC,
                0x79,
                0x47,
                0x86,
                0xA7,
                0x88,
                0xF1,
                0x06,
                0x87,
                0xD2,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCookieFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x85,
                0x05,
                0x6A,
                0x1C,
                0x93,
                0xD1,
                0x4C,
                0xA9,
                0x6D,
                0xC2,
                0x17,
                0x01,
                0x78,
                0x5C,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpCookieManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x17,
                0x43,
                0x7A,
                0x4F,
                0xCD,
                0x57,
                0x4E,
                0xA8,
                0x4A,
                0x5B,
                0x0A,
                0x53,
                0xD6,
                0xBB,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpFormUrlEncodedContentFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x13,
                0xF0,
                0x43,
                0x73,
                0x2F,
                0x02,
                0x43,
                0xB5,
                0xF3,
                0xEA,
                0xE9,
                0x23,
                0x8A,
                0x5E,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpGetBufferResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x8E,
                0xD0,
                0x53,
                0x09,
                0xE2,
                0x4E,
                0x40,
                0x9A,
                0x49,
                0x74,
                0x2D,
                0x82,
                0x36,
                0xFD,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpGetInputStreamResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0x34,
                0xD6,
                0xD5,
                0xAA,
                0x13,
                0xE0,
                0x4E,
                0xBE,
                0x95,
                0xA0,
                0xC3,
                0x9F,
                0xE9,
                0x12,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpGetStringResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x46,
                0xAC,
                0x9B,
                0x09,
                0x85,
                0x75,
                0x47,
                0xB1,
                0x6D,
                0x89,
                0x53,
                0xF4,
                0x7A,
                0x7F,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMethod
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x40,
                0x8D,
                0x72,
                0x0D,
                0x70,
                0xE0,
                0x4F,
                0xAF,
                0xA5,
                0x40,
                0x29,
                0x9C,
                0x58,
                0xDB,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMethodFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xD1,
                0x51,
                0x3C,
                0xD7,
                0x36,
                0xF8,
                0x40,
                0xA8,
                0x6D,
                0xE7,
                0x59,
                0xCA,
                0xF2,
                0xF8,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMethodStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x71,
                0xD1,
                0x64,
                0x9A,
                0xD9,
                0x53,
                0x41,
                0x8D,
                0xC6,
                0xD6,
                0x8C,
                0xC4,
                0xCC,
                0xE3,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMultipartContent
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x6A,
                0x91,
                0xDF,
                0x26,
                0x99,
                0xC9,
                0x4A,
                0xAA,
                0xF1,
                0xE0,
                0xD0,
                0x4E,
                0xF0,
                0x9B,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMultipartContentFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0x2E,
                0xB4,
                0x7E,
                0x22,
                0x02,
                0x20,
                0x4F,
                0xB3,
                0x72,
                0x47,
                0xD5,
                0xDB,
                0x5D,
                0x33,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMultipartFormDataContent
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x37,
                0xD3,
                0x64,
                0x67,
                0xE9,
                0x24,
                0x46,
                0xB6,
                0xD1,
                0xCF,
                0x74,
                0x60,
                0x4A,
                0x4A,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpMultipartFormDataContentFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x73,
                0x4D,
                0xA0,
                0x17,
                0x50,
                0x22,
                0x46,
                0x93,
                0xA8,
                0x49,
                0xB2,
                0x4A,
                0x4F,
                0xCB,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpRequestMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x2B,
                0x76,
                0xF5,
                0xD4,
                0x74,
                0x11,
                0x48,
                0xB5,
                0xDC,
                0x9F,
                0x8B,
                0x4E,
                0x2F,
                0x9A,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpRequestMessage2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0x04,
                0xC6,
                0xC3,
                0xC2,
                0x62,
                0x3F,
                0x4A,
                0x95,
                0x54,
                0x22,
                0x6E,
                0x7C,
                0x60,
                0xBD,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpRequestMessageFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x99,
                0xAC,
                0x5B,
                0x86,
                0x38,
                0x2E,
                0x41,
                0xAE,
                0xC3,
                0x52,
                0xEC,
                0x7F,
                0x25,
                0x61,
                0x6F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpRequestResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x4D,
                0xCF,
                0x6A,
                0xEB,
                0xB5,
                0x35,
                0x4A,
                0xA9,
                0x02,
                0x42,
                0x17,
                0xFB,
                0xE8,
                0x20,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpResponseMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x00,
                0xE2,
                0xFE,
                0x64,
                0x86,
                0xE0,
                0x44,
                0x95,
                0xD9,
                0x42,
                0x69,
                0x61,
                0x99,
                0xBF,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpResponseMessageFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0xAF,
                0xA8,
                0x52,
                0x95,
                0xF0,
                0xDA,
                0x43,
                0xB6,
                0x0F,
                0x7C,
                0xFC,
                0x2B,
                0xC7,
                0xEA,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpStreamContentFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x4D,
                0xE6,
                0xF3,
                0x25,
                0xF7,
                0x7E,
                0x40,
                0x94,
                0x2F,
                0x0E,
                0xDA,
                0x18,
                0x98,
                0x09,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpStringContentFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x9D,
                0x64,
                0x46,
                0x93,
                0x2E,
                0xEB,
                0x48,
                0x8E,
                0x61,
                0x19,
                0x67,
                0x78,
                0x78,
                0xE5,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHttpTransportInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0x71,
                0x12,
                0x70,
                0xA7,
                0xC6,
                0xD0,
                0x4E,
                0x83,
                0x3A,
                0x83,
                0xFD,
                0x8B,
                0x8F,
                0x17,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
