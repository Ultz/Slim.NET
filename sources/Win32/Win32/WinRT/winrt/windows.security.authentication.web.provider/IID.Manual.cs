// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IWebAccountClientView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x66,
                0xBD,
                0xE7,
                0xC7,
                0x0B,
                0x66,
                0x4C,
                0xBF,
                0xD4,
                0x65,
                0xD3,
                0x08,
                0x2C,
                0xBC,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountClientViewFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x16,
                0x6D,
                0x61,
                0x22,
                0xDE,
                0x55,
                0x48,
                0xA3,
                0x26,
                0x06,
                0xCE,
                0xBF,
                0x2A,
                0x3F,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0xE1,
                0xE8,
                0xB2,
                0x9A,
                0xD4,
                0x32,
                0x40,
                0x84,
                0xBF,
                0x1A,
                0x28,
                0x47,
                0x74,
                0x7B,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xA8,
                0xA7,
                0x68,
                0x5F,
                0x2D,
                0x53,
                0x46,
                0x8B,
                0xB0,
                0xBD,
                0x2F,
                0xA6,
                0xBD,
                0x2D,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x23,
                0x45,
                0xDD,
                0x4F,
                0x8A,
                0xA2,
                0x4A,
                0xB1,
                0x5E,
                0x03,
                0xF5,
                0x50,
                0xAF,
                0x13,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountManagerStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0xC2,
                0xEB,
                0x59,
                0xDB,
                0xF7,
                0x2F,
                0x41,
                0xBC,
                0x3F,
                0xF2,
                0xFE,
                0xA0,
                0x44,
                0x30,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountMapManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x44,
                0xFA,
                0xE8,
                0x1B,
                0x3A,
                0xA4,
                0x48,
                0x8E,
                0x90,
                0x1E,
                0x59,
                0xCA,
                0x6F,
                0x54,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderAddAccountOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0xDC,
                0xEB,
                0x73,
                0x78,
                0x43,
                0x79,
                0x4C,
                0x93,
                0x35,
                0xA5,
                0xD7,
                0xAB,
                0x81,
                0x59,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderBaseReportOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0xAC,
                0xA4,
                0xBB,
                0x3B,
                0x99,
                0x57,
                0x4D,
                0xBB,
                0xE4,
                0x14,
                0x21,
                0xE3,
                0x66,
                0x8B,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderDeleteAccountOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x48,
                0xBB,
                0x0A,
                0x01,
                0x9E,
                0xC9,
                0x49,
                0xA3,
                0x55,
                0x7D,
                0x48,
                0xCA,
                0xF7,
                0xD6,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderManageAccountOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0xDC,
                0x20,
                0xED,
                0x1B,
                0xD2,
                0x3E,
                0x46,
                0xA9,
                0xB7,
                0xC1,
                0xFD,
                0x0E,
                0xDA,
                0xE9,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x24,
                0x5D,
                0x6D,
                0xB1,
                0x10,
                0x9A,
                0x41,
                0xA4,
                0x4E,
                0xF9,
                0xC5,
                0x16,
                0x15,
                0x74,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderRetrieveCookiesOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x04,
                0x04,
                0x5A,
                0xA3,
                0x0F,
                0xB1,
                0x4A,
                0xA0,
                0x1C,
                0x20,
                0xB1,
                0x10,
                0x35,
                0x85,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderSignOutAccountOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0xE2,
                0x90,
                0xB8,
                0x55,
                0x0C,
                0xBC,
                0x47,
                0x8C,
                0x72,
                0x04,
                0xA6,
                0xFC,
                0x7C,
                0xAC,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderSilentReportOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x45,
                0xB5,
                0xE0,
                0x0F,
                0x3B,
                0xDA,
                0x44,
                0x92,
                0x4C,
                0x7B,
                0x18,
                0xBA,
                0xAA,
                0x62,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderTokenObjects
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x28,
                0x8F,
                0x40,
                0x28,
                0x13,
                0xDB,
                0x42,
                0x89,
                0xA4,
                0x0B,
                0xCE,
                0x7A,
                0x71,
                0x7D,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderTokenObjects2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0xB8,
                0x20,
                0x10,
                0xA5,
                0x5C,
                0xFF,
                0x4F,
                0x95,
                0xFB,
                0xB8,
                0x20,
                0x27,
                0x3F,
                0xC3,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderTokenOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x13,
                0xC6,
                0x95,
                0x34,
                0x20,
                0x38,
                0x4C,
                0x94,
                0x34,
                0xD2,
                0x6C,
                0x14,
                0xB2,
                0xB4,
                0xB2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderUIReportOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x92,
                0xFF,
                0x28,
                0x80,
                0x8F,
                0xFB,
                0x42,
                0x94,
                0x4F,
                0xB2,
                0x10,
                0x7B,
                0xBD,
                0x42,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountScopeManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0xE3,
                0x6C,
                0x5C,
                0xB2,
                0x12,
                0x3A,
                0x42,
                0xBF,
                0x3D,
                0x85,
                0xB8,
                0xD7,
                0xE5,
                0x36,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebProviderTokenRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x77,
                0x18,
                0x1E,
                0x05,
                0x88,
                0x4B,
                0x45,
                0x9F,
                0x11,
                0x46,
                0x8D,
                0x2A,
                0xF1,
                0x09,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebProviderTokenRequest2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x2E,
                0xD7,
                0xB5,
                0xB1,
                0x10,
                0xA6,
                0x4A,
                0x88,
                0xB1,
                0x0B,
                0x6C,
                0x9E,
                0x0C,
                0x1E,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebProviderTokenRequest3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x16,
                0x27,
                0x1B,
                0x89,
                0x42,
                0x6E,
                0x44,
                0x92,
                0x56,
                0xDA,
                0xFB,
                0x6F,
                0x66,
                0xA5,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebProviderTokenResponse
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x37,
                0x21,
                0xEF,
                0x55,
                0xEF,
                0x86,
                0x41,
                0xB7,
                0xCE,
                0x8C,
                0xB2,
                0xE7,
                0xF9,
                0x84,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebProviderTokenResponseFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0xD9,
                0x49,
                0xFA,
                0xBA,
                0x25,
                0x77,
                0x40,
                0x9C,
                0xFA,
                0x9D,
                0xB4,
                0xDE,
                0xA7,
                0xB7,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
