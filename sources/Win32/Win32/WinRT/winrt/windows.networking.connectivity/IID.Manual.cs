// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_INetworkStatusChangedEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0x14,
                0xBA,
                0x71,
                0x8E,
                0x59,
                0xD0,
                0x49,
                0x84,
                0xEB,
                0x8F,
                0xEB,
                0xAE,
                0xDC,
                0xC1,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAttributedNetworkUsage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0xB0,
                0x69,
                0xF7,
                0xA2,
                0xEC,
                0xEB,
                0x45,
                0xAD,
                0xE1,
                0xB0,
                0x36,
                0x8B,
                0x75,
                0x6C,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICellularApnContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x29,
                0xA5,
                0x6F,
                0xFD,
                0xEF,
                0x42,
                0x45,
                0x9A,
                0xB2,
                0x70,
                0x5B,
                0xBF,
                0x94,
                0x94,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICellularApnContext2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0xEB,
                0xB0,
                0x76,
                0x49,
                0xAC,
                0x50,
                0x43,
                0xB1,
                0xE5,
                0xDC,
                0x47,
                0x63,
                0xBC,
                0x69,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionCost
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xD8,
                0xD7,
                0xBA,
                0x16,
                0x34,
                0x10,
                0x4B,
                0xA2,
                0x02,
                0xBA,
                0xC0,
                0xB0,
                0x75,
                0xBD,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionCost2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x3A,
                0x11,
                0x8E,
                0x09,
                0xE2,
                0x49,
                0x45,
                0xBB,
                0x25,
                0x5E,
                0x0D,
                0xB6,
                0x91,
                0xCB,
                0x05,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionProfile
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x14,
                0xBA,
                0x71,
                0x8E,
                0x59,
                0xD0,
                0x49,
                0x84,
                0xEB,
                0x8F,
                0xEB,
                0xAE,
                0xDC,
                0xC1,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionProfile2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x51,
                0x04,
                0xE2,
                0x9F,
                0x4C,
                0x0C,
                0x40,
                0x91,
                0x50,
                0x7E,
                0xC7,
                0xD6,
                0xE2,
                0x88,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionProfile3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x25,
                0x8C,
                0x57,
                0xD9,
                0x4C,
                0x61,
                0x41,
                0x80,
                0x45,
                0x20,
                0x1C,
                0xFD,
                0x5B,
                0x11,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionProfile4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x42,
                0x2D,
                0x7A,
                0xE0,
                0x81,
                0xE6,
                0x4A,
                0xAB,
                0xED,
                0xAB,
                0x9C,
                0xA1,
                0x3E,
                0xB7,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionProfile5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x1E,
                0x36,
                0x85,
                0x73,
                0x9C,
                0xE0,
                0x4B,
                0x8F,
                0x14,
                0x57,
                0x8E,
                0xEC,
                0x71,
                0xEE,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionProfile6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0xDF,
                0x27,
                0xDC,
                0x6F,
                0x7A,
                0x0E,
                0x5D,
                0x95,
                0x89,
                0x2F,
                0xE2,
                0xE5,
                0xB6,
                0xF9,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionProfileFilter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x7C,
                0x4C,
                0x20,
                0x2D,
                0xBD,
                0x8D,
                0x4E,
                0xA4,
                0xB3,
                0x45,
                0x5E,
                0xC3,
                0x37,
                0x38,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionProfileFilter2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x8E,
                0x06,
                0xCD,
                0xFC,
                0xC3,
                0xAD,
                0x4F,
                0x9D,
                0xDC,
                0x59,
                0x3F,
                0xAA,
                0x4B,
                0x78,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionProfileFilter3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x09,
                0xAA,
                0x0A,
                0x14,
                0x50,
                0x7C,
                0x44,
                0x88,
                0x09,
                0xAE,
                0xE4,
                0xCB,
                0x0A,
                0xF9,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectionSession
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x5D,
                0x90,
                0xFF,
                0x3B,
                0xF8,
                0xB0,
                0x41,
                0x8A,
                0x0C,
                0x14,
                0x62,
                0xD9,
                0xC5,
                0x6B,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectivityInterval
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x3F,
                0xAA,
                0x4F,
                0x46,
                0x67,
                0x24,
                0x48,
                0xA9,
                0x64,
                0xEE,
                0xD8,
                0xE8,
                0x7F,
                0x87,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IConnectivityManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0xD4,
                0x20,
                0x51,
                0xB1,
                0x4F,
                0xB0,
                0x48,
                0xAF,
                0xC9,
                0x42,
                0xE0,
                0x09,
                0x2A,
                0x81,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPlanStatus
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x8B,
                0x7A,
                0x97,
                0x85,
                0x38,
                0xF3,
                0x40,
                0x88,
                0x51,
                0x42,
                0xCD,
                0x2B,
                0xD5,
                0x68,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataPlanUsage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x49,
                0x21,
                0xB9,
                0x44,
                0x3B,
                0xFF,
                0x47,
                0xB3,
                0x61,
                0xBE,
                0x59,
                0xE6,
                0x9E,
                0xD1,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDataUsage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x1D,
                0x43,
                0xC1,
                0x46,
                0xB1,
                0x39,
                0x4D,
                0xB9,
                0x59,
                0x0C,
                0x69,
                0xB0,
                0x96,
                0xC5,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIPInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x45,
                0x51,
                0xD8,
                0x8F,
                0x13,
                0xD7,
                0x47,
                0x9B,
                0x3A,
                0x36,
                0xBB,
                0x48,
                0x8C,
                0xEF,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanIdentifier
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x53,
                0xAA,
                0x48,
                0x08,
                0x11,
                0x46,
                0x45,
                0xA6,
                0xCB,
                0x9A,
                0x74,
                0xDA,
                0x4B,
                0x7B,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILanIdentifierData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x83,
                0x4E,
                0xA7,
                0x39,
                0xD6,
                0xBE,
                0x45,
                0xA3,
                0x6A,
                0xC4,
                0xE4,
                0xAE,
                0xAF,
                0x6D,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkAdapter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0x2E,
                0x54,
                0x3B,
                0x88,
                0x53,
                0x6C,
                0x49,
                0xA8,
                0xA3,
                0xAF,
                0xFD,
                0x39,
                0xAE,
                0xC2,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkInformationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xF8,
                0x74,
                0x50,
                0x0D,
                0x95,
                0x65,
                0x41,
                0x9C,
                0x15,
                0x36,
                0x56,
                0x19,
                0x48,
                0x1E,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkInformationStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0xED,
                0x9C,
                0x45,
                0x32,
                0x28,
                0xB6,
                0x49,
                0xBA,
                0x6E,
                0xE2,
                0x65,
                0xF0,
                0x47,
                0x86,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkItem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x4D,
                0xBC,
                0x01,
                0xE0,
                0xF5,
                0x67,
                0x45,
                0xA2,
                0x8C,
                0x42,
                0x08,
                0x0C,
                0x83,
                0x1B,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkSecuritySettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x7E,
                0xA0,
                0x7C,
                0x7B,
                0x91,
                0x5F,
                0x4B,
                0xB8,
                0x4D,
                0x28,
                0xF7,
                0xA5,
                0xAC,
                0x54,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkStateChangeEventDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0xF3,
                0x0C,
                0x1F,
                0xA6,
                0xD7,
                0xDD,
                0x44,
                0xA4,
                0xE9,
                0x68,
                0x7C,
                0x47,
                0x6B,
                0x90,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkStateChangeEventDetails2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0xC0,
                0x43,
                0xD6,
                0xD3,
                0x30,
                0x6A,
                0x4F,
                0xAD,
                0x47,
                0x6A,
                0x18,
                0x73,
                0xCE,
                0xB3,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkUsage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x8F,
                0xDA,
                0x49,
                0x85,
                0x99,
                0x27,
                0x49,
                0xBF,
                0x5B,
                0x07,
                0x2B,
                0x5C,
                0x65,
                0xF8,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProviderNetworkUsage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x9E,
                0xC6,
                0x5E,
                0x31,
                0x79,
                0xC8,
                0x48,
                0xB8,
                0xF3,
                0x46,
                0x30,
                0x0F,
                0xA4,
                0x27,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProxyConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x60,
                0x3A,
                0xEF,
                0x04,
                0x90,
                0xD6,
                0x4D,
                0xB7,
                0xD8,
                0xB3,
                0xE5,
                0x02,
                0xF4,
                0xAA,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRoutePolicy
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0xC4,
                0xAB,
                0x11,
                0xC7,
                0x0F,
                0xE4,
                0x42,
                0x87,
                0x42,
                0x56,
                0x99,
                0x23,
                0xB1,
                0xCA,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRoutePolicyFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x79,
                0x02,
                0x36,
                0x8E,
                0xA1,
                0xB5,
                0x4D,
                0xA6,
                0x97,
                0xF5,
                0x8F,
                0xA7,
                0x36,
                0x4E,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWlanConnectionProfileDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x98,
                0x20,
                0x56,
                0x5A,
                0xB3,
                0xF1,
                0x4B,
                0xA8,
                0x84,
                0xB7,
                0x55,
                0x7E,
                0x88,
                0xFF,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWwanConnectionProfileDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0xA8,
                0x4D,
                0x0E,
                0x5F,
                0x83,
                0xF3,
                0x4D,
                0x82,
                0xFD,
                0xDF,
                0x55,
                0x6E,
                0xBC,
                0x09,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWwanConnectionProfileDetails2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDE,
                0x4E,
                0x75,
                0x7A,
                0xED,
                0xA1,
                0xB2,
                0x48,
                0x8E,
                0x92,
                0xB4,
                0x60,
                0x03,
                0x3D,
                0x52,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
