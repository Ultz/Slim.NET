// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IKnownRemoteSystemCapabilitiesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xE3,
                0x08,
                0x81,
                0x8A,
                0x7F,
                0xE4,
                0x44,
                0x92,
                0xCD,
                0x03,
                0xB6,
                0x46,
                0x9B,
                0x94,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x38,
                0x58,
                0xED,
                0x10,
                0x1E,
                0x8C,
                0x4A,
                0xB4,
                0xA6,
                0x4E,
                0x5F,
                0xD6,
                0xF9,
                0x77,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystem2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0xE4,
                0xDF,
                0x09,
                0x8B,
                0xFB,
                0x08,
                0x4A,
                0xA7,
                0x58,
                0x68,
                0x76,
                0x43,
                0x5D,
                0x76,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystem3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0xB4,
                0xB4,
                0x72,
                0xC6,
                0xB7,
                0xBE,
                0x40,
                0x83,
                0x1B,
                0x73,
                0x56,
                0x2F,
                0x12,
                0xFF,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystem4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0xFF,
                0x64,
                0xF1,
                0x87,
                0xB9,
                0xA5,
                0x4C,
                0x99,
                0x26,
                0xFA,
                0x04,
                0x38,
                0xBE,
                0x62,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystem5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0xD7,
                0x2A,
                0xEB,
                0xE2,
                0xE5,
                0xE2,
                0x4A,
                0xA7,
                0xA7,
                0xA1,
                0x09,
                0x7A,
                0x09,
                0x8E,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystem6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0xA9,
                0xCD,
                0xD4,
                0x27,
                0xC0,
                0x3E,
                0x53,
                0x93,
                0x84,
                0x3A,
                0x19,
                0xB4,
                0xF7,
                0xEE,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemAddedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x56,
                0x39,
                0x8F,
                0x34,
                0xE5,
                0x97,
                0x46,
                0x88,
                0x36,
                0x7A,
                0xBE,
                0xA1,
                0x51,
                0x51,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemApp
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0xBC,
                0xE5,
                0x80,
                0x4D,
                0xD5,
                0xB1,
                0x41,
                0x9B,
                0x16,
                0x68,
                0x10,
                0xA8,
                0x71,
                0xED,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemApp2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0xBF,
                0x69,
                0x63,
                0x96,
                0x0A,
                0x7A,
                0x57,
                0x8F,
                0xF6,
                0xC3,
                0x59,
                0x04,
                0xDF,
                0xA8,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemAppRegistration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x47,
                0x79,
                0xB4,
                0x35,
                0x70,
                0x5A,
                0x4A,
                0xB8,
                0xDF,
                0x96,
                0x2D,
                0x8F,
                0x84,
                0x31,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemAppRegistrationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x98,
                0xB9,
                0x01,
                0xD2,
                0xCF,
                0x3F,
                0x45,
                0xAE,
                0x25,
                0xC2,
                0x53,
                0x9F,
                0x08,
                0x6A,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemAuthorizationKindFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8E,
                0xDE,
                0x0D,
                0x6B,
                0xD0,
                0x04,
                0xF4,
                0x40,
                0xA2,
                0x7F,
                0xC2,
                0xAC,
                0xBB,
                0xD6,
                0xB7,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemAuthorizationKindFilterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0xDF,
                0x65,
                0xAD,
                0x6A,
                0xB6,
                0xA4,
                0x45,
                0x81,
                0x77,
                0x8C,
                0xAE,
                0xD7,
                0x5D,
                0x9E,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemConnectionInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x8B,
                0x27,
                0x23,
                0x09,
                0x0D,
                0xCB,
                0x52,
                0x9C,
                0x6A,
                0xEE,
                0xD2,
                0x94,
                0x0B,
                0xEE,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemConnectionInfoStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x1E,
                0x83,
                0xAC,
                0xC5,
                0x66,
                0xD7,
                0x56,
                0xA4,
                0xCE,
                0x70,
                0x5D,
                0x94,
                0x92,
                0x5A,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemConnectionRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x41,
                0xED,
                0x84,
                0x5E,
                0x8D,
                0x72,
                0x4D,
                0x82,
                0x38,
                0x76,
                0x21,
                0x57,
                0x6C,
                0x7A,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemConnectionRequest2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x6D,
                0xDF,
                0x12,
                0xFC,
                0xBF,
                0x3A,
                0x48,
                0x8A,
                0xBE,
                0xD3,
                0x4A,
                0x6C,
                0x19,
                0xF9,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemConnectionRequest3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xC3,
                0x86,
                0xDE,
                0xCC,
                0xC9,
                0x50,
                0x5A,
                0xB8,
                0xD9,
                0xBA,
                0x7B,
                0x34,
                0xBB,
                0x8D,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemConnectionRequestFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x0A,
                0x0A,
                0xAA,
                0xEB,
                0xBA,
                0x75,
                0x45,
                0xB5,
                0x30,
                0x81,
                0x0B,
                0xB9,
                0x78,
                0x63,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemConnectionRequestStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x14,
                0xCA,
                0x86,
                0x14,
                0x82,
                0x5C,
                0x42,
                0x89,
                0x32,
                0xDB,
                0x49,
                0x03,
                0x2D,
                0x13,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemConnectionRequestStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x10,
                0x0F,
                0x46,
                0xEC,
                0x64,
                0x8E,
                0x59,
                0xA8,
                0x00,
                0x4F,
                0x2E,
                0xE5,
                0x8D,
                0xEF,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemDiscoveryTypeFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x04,
                0xD9,
                0x42,
                0x5A,
                0xEE,
                0xDA,
                0x43,
                0xAC,
                0x6A,
                0x6F,
                0xEE,
                0x25,
                0x46,
                0x07,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemDiscoveryTypeFilterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0xB9,
                0x9E,
                0x9F,
                0x60,
                0xC2,
                0x61,
                0x41,
                0x92,
                0xF2,
                0x9C,
                0x02,
                0x1F,
                0x23,
                0xFE,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemEnumerationCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x3D,
                0xE8,
                0xC6,
                0x30,
                0x40,
                0x54,
                0x43,
                0xA0,
                0x60,
                0x14,
                0xF1,
                0xB2,
                0x2C,
                0x54,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0xA9,
                0x3B,
                0x4A,
                0xEB,
                0x99,
                0xEB,
                0x45,
                0xBA,
                0x16,
                0x03,
                0x67,
                0x72,
                0x8F,
                0xF3,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemKindFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0xC9,
                0xE1,
                0x38,
                0xC3,
                0x22,
                0xF6,
                0x4E,
                0x90,
                0x1A,
                0xBB,
                0xB1,
                0xC7,
                0xAA,
                0xD4,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemKindFilterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x18,
                0xFB,
                0xA1,
                0xEA,
                0x99,
                0xBC,
                0x40,
                0x9A,
                0x39,
                0xC6,
                0x70,
                0xAA,
                0x80,
                0x4A,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemKindStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x76,
                0x31,
                0xF6,
                0x14,
                0xAB,
                0xD0,
                0x41,
                0x95,
                0x53,
                0x79,
                0x6A,
                0xAD,
                0xB8,
                0x82,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemKindStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xA3,
                0xE3,
                0xB9,
                0x66,
                0x04,
                0x49,
                0x47,
                0x91,
                0xE8,
                0x65,
                0xF9,
                0xD1,
                0x9A,
                0x96,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemRemovedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x16,
                0x3D,
                0x8B,
                0x06,
                0x73,
                0xEA,
                0x49,
                0xB7,
                0xDF,
                0x67,
                0xD5,
                0x71,
                0x4C,
                0xB0,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSession
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x6A,
                0x47,
                0x69,
                0xDA,
                0x9A,
                0x0F,
                0x49,
                0x95,
                0x49,
                0xD3,
                0x1C,
                0xB1,
                0x4C,
                0x9E,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionAddedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xD7,
                0x85,
                0xD5,
                0x97,
                0xBC,
                0x39,
                0x4C,
                0x99,
                0xB4,
                0xBE,
                0xCA,
                0x76,
                0xE0,
                0x4C,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0x2D,
                0x8B,
                0xE4,
                0x20,
                0x68,
                0x67,
                0x48,
                0xB4,
                0x25,
                0xD8,
                0x9C,
                0x0A,
                0x3E,
                0xF7,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionControllerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0x2F,
                0xCC,
                0xBF,
                0x3D,
                0xAC,
                0x99,
                0x41,
                0x82,
                0xCD,
                0x66,
                0x70,
                0xA7,
                0x73,
                0xEF,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionCreationResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0x12,
                0x98,
                0xA7,
                0xDE,
                0x37,
                0x8C,
                0x44,
                0x8B,
                0x83,
                0xA3,
                0x0A,
                0xA3,
                0xC4,
                0xEA,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionDisconnectedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xC6,
                0x0B,
                0xDE,
                0xC5,
                0x77,
                0x1C,
                0x46,
                0x82,
                0x09,
                0x7C,
                0x6C,
                0x5D,
                0x31,
                0x11,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xF6,
                0x4D,
                0xFF,
                0x0A,
                0x8B,
                0x9A,
                0x4E,
                0x99,
                0x05,
                0x69,
                0xE4,
                0xB8,
                0x41,
                0xC5,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionInvitation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0xCC,
                0x32,
                0x3E,
                0xD7,
                0x51,
                0x66,
                0x47,
                0xA1,
                0x21,
                0x25,
                0x51,
                0x6C,
                0x3B,
                0x82,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionInvitationListener
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0x00,
                0xF4,
                0x08,
                0x71,
                0xBC,
                0xE1,
                0x49,
                0x87,
                0x4A,
                0x31,
                0xDD,
                0xFF,
                0x9A,
                0x27,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionInvitationReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x4A,
                0x96,
                0x5E,
                0x0D,
                0xA1,
                0xDB,
                0x4E,
                0x8D,
                0xEA,
                0x54,
                0xD2,
                0x0A,
                0xC1,
                0x95,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionJoinRequest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x00,
                0x60,
                0x20,
                0x94,
                0x79,
                0x31,
                0x43,
                0x86,
                0xD1,
                0xD8,
                0x9D,
                0x88,
                0x25,
                0x85,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionJoinRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x4F,
                0xCA,
                0xDB,
                0xB9,
                0x82,
                0x16,
                0x48,
                0x9C,
                0x24,
                0xE4,
                0x0E,
                0x61,
                0x77,
                0x4B,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionJoinResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x1F,
                0x7B,
                0xCE,
                0x3E,
                0xA0,
                0xA4,
                0x41,
                0x90,
                0x0B,
                0x1E,
                0x79,
                0x32,
                0x8C,
                0x12,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionMessageChannel
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0xD1,
                0x24,
                0x95,
                0xD9,
                0x73,
                0x10,
                0x4C,
                0xB7,
                0x51,
                0xC2,
                0x67,
                0x84,
                0x43,
                0x71,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionMessageChannelFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x1C,
                0x5E,
                0x29,
                0x16,
                0xBD,
                0x98,
                0x42,
                0xB7,
                0xCE,
                0x41,
                0x54,
                0x82,
                0xB0,
                0xE1,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0xD7,
                0x0E,
                0x74,
                0x18,
                0x84,
                0x01,
                0x4F,
                0x93,
                0x53,
                0xE2,
                0x1C,
                0x9E,
                0xCC,
                0x6C,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionParticipant
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x05,
                0x90,
                0x7E,
                0xF9,
                0xAC,
                0x29,
                0x47,
                0x8A,
                0x17,
                0x44,
                0xE7,
                0xBA,
                0xED,
                0x5D,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionParticipantAddedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x57,
                0x5A,
                0xD3,
                0xA1,
                0xC9,
                0xB7,
                0x4B,
                0xB6,
                0xB0,
                0x79,
                0xBB,
                0x91,
                0xAD,
                0xF9,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionParticipantRemovedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xF0,
                0x6E,
                0x86,
                0x68,
                0xDE,
                0xBF,
                0x4A,
                0x88,
                0xA1,
                0xF9,
                0x0D,
                0x16,
                0x27,
                0x41,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionParticipantWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x02,
                0xDD,
                0xDC,
                0x87,
                0xAA,
                0x79,
                0x4D,
                0xB6,
                0xCC,
                0x44,
                0x59,
                0xB3,
                0xE9,
                0x20,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionRemovedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x91,
                0x82,
                0xAF,
                0xA1,
                0x39,
                0xEA,
                0x4D,
                0x9D,
                0x63,
                0x43,
                0x79,
                0x8D,
                0x5B,
                0xBB,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x89,
                0x24,
                0x85,
                0x20,
                0xFD,
                0xE3,
                0x44,
                0x95,
                0x65,
                0xE7,
                0x5A,
                0x3B,
                0x14,
                0xC6,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionUpdatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0x50,
                0x87,
                0x16,
                0x1E,
                0x23,
                0x91,
                0x4C,
                0x8E,
                0xC8,
                0xB3,
                0xA3,
                0x9D,
                0x9E,
                0x55,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionValueSetReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x17,
                0xF3,
                0x06,
                0xA5,
                0x2D,
                0x58,
                0x4E,
                0xA7,
                0x8F,
                0x9E,
                0x8D,
                0x07,
                0x84,
                0xEE,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemSessionWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xE3,
                0x03,
                0x80,
                0x41,
                0x0C,
                0x62,
                0x4A,
                0xB6,
                0xD7,
                0xBD,
                0xBE,
                0x2B,
                0x19,
                0xBE,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0xB3,
                0x85,
                0xA4,
                0x2B,
                0xFF,
                0x47,
                0x4B,
                0xBE,
                0x62,
                0x74,
                0x3F,
                0x2F,
                0x14,
                0x0F,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0xED,
                0x98,
                0x0C,
                0x99,
                0x6F,
                0x52,
                0x4C,
                0xA2,
                0x72,
                0xEA,
                0x4F,
                0x36,
                0x47,
                0x17,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0xF1,
                0x95,
                0x99,
                0x3C,
                0x0B,
                0xC5,
                0x5A,
                0xB3,
                0x25,
                0xCC,
                0x73,
                0xF4,
                0x37,
                0xDF,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemStatusTypeFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x51,
                0x39,
                0x0C,
                0xB6,
                0xCB,
                0x77,
                0x47,
                0x85,
                0x34,
                0x2E,
                0x0C,
                0x52,
                0x1A,
                0xFF,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemStatusTypeFilterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x78,
                0xCF,
                0x33,
                0x24,
                0xD7,
                0x25,
                0x41,
                0xAC,
                0x7A,
                0x8D,
                0x28,
                0x1E,
                0x44,
                0xC9,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemUpdatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0xFF,
                0x02,
                0x75,
                0xCB,
                0xDB,
                0x55,
                0x41,
                0xB4,
                0xCA,
                0xB3,
                0x0A,
                0x04,
                0xF2,
                0x76,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x0C,
                0x60,
                0x5D,
                0x07,
                0x2C,
                0xC5,
                0x48,
                0x88,
                0x9C,
                0x45,
                0x5D,
                0x2B,
                0x09,
                0x97,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemWatcher2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x67,
                0x43,
                0x73,
                0xCA,
                0x19,
                0xF9,
                0x48,
                0xA4,
                0xCD,
                0x78,
                0x0F,
                0x7A,
                0xD5,
                0x8C,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemWatcher3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x0F,
                0x9C,
                0xF7,
                0x13,
                0xA9,
                0xD3,
                0x55,
                0x84,
                0x13,
                0x41,
                0x8F,
                0xCF,
                0x15,
                0xBA,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemWatcherErrorOccurredEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0xC6,
                0xC5,
                0x74,
                0x14,
                0x51,
                0x26,
                0x44,
                0x92,
                0x16,
                0x20,
                0xD8,
                0x1F,
                0x85,
                0x19,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemWebAccountFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x58,
                0xB7,
                0x3F,
                0xC8,
                0x87,
                0x8F,
                0x5D,
                0x97,
                0x7E,
                0xF6,
                0x9F,
                0x96,
                0xD6,
                0x72,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteSystemWebAccountFilterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x27,
                0x8A,
                0x34,
                0x4D,
                0x5F,
                0x27,
                0x51,
                0xB4,
                0xA7,
                0xBF,
                0x99,
                0xD5,
                0x25,
                0x2B,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
