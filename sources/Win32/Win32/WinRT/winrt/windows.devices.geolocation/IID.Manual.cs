// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ICivicAddress
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0x7A,
                0x56,
                0xA8,
                0xF4,
                0x64,
                0x48,
                0x4D,
                0xBC,
                0xEA,
                0xF6,
                0xB0,
                0x08,
                0xEC,
                0xA3,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeoboundingBox
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0xC8,
                0x96,
                0x08,
                0x4F,
                0x27,
                0xDA,
                0x43,
                0x9A,
                0x06,
                0xCB,
                0xFC,
                0xDA,
                0xEB,
                0x4E,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeoboundingBoxFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xA5,
                0xFB,
                0x4D,
                0x11,
                0x04,
                0xBC,
                0x4A,
                0xB3,
                0xB5,
                0x5B,
                0xBC,
                0xCB,
                0x57,
                0xD9,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeoboundingBoxStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x07,
                0xB8,
                0x67,
                0x1A,
                0xE6,
                0xD0,
                0x4C,
                0x84,
                0x1B,
                0x93,
                0x23,
                0x37,
                0x92,
                0xB5,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeocircle
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x58,
                0xE4,
                0x39,
                0xF9,
                0xA7,
                0x63,
                0x4E,
                0x92,
                0xA7,
                0xBA,
                0x0C,
                0x28,
                0xD1,
                0x24,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeocircleFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x53,
                0xD6,
                0xAF,
                0xB1,
                0x72,
                0x7D,
                0x4F,
                0x87,
                0xCC,
                0x4E,
                0xD4,
                0xC9,
                0x84,
                0x9C,
                0x05,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeocoordinate
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0xA3,
                0x21,
                0xEE,
                0x6A,
                0x97,
                0x70,
                0x4C,
                0x80,
                0x3D,
                0x08,
                0x3E,
                0xA5,
                0x5B,
                0xCB,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeocoordinateSatelliteData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x74,
                0x2A,
                0xC3,
                0x08,
                0x26,
                0x4C,
                0x47,
                0x91,
                0x2C,
                0x06,
                0xDD,
                0x49,
                0x0F,
                0x4A,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeocoordinateSatelliteData2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x8C,
                0x1C,
                0x76,
                0x9D,
                0xA1,
                0x51,
                0x5A,
                0x80,
                0xF5,
                0x71,
                0x67,
                0x61,
                0x15,
                0x48,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeocoordinateWithPoint
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x05,
                0xEA,
                0xFE,
                0x2C,
                0xD2,
                0x46,
                0x4D,
                0xB5,
                0x27,
                0x0B,
                0x96,
                0x06,
                0x6F,
                0xC7,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeocoordinateWithPositionData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x34,
                0xE6,
                0x95,
                0xD6,
                0xDB,
                0xAC,
                0x40,
                0xB8,
                0xF2,
                0xA6,
                0x5C,
                0x03,
                0x40,
                0xD9,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeocoordinateWithPositionSourceTimestamp
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xFC,
                0x43,
                0x85,
                0xF1,
                0xC9,
                0x10,
                0x46,
                0xAF,
                0xE0,
                0x8B,
                0xC3,
                0xA6,
                0xA8,
                0x70,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeocoordinateWithRemoteSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0xEB,
                0x7C,
                0x39,
                0x38,
                0xEE,
                0x3B,
                0x5F,
                0x89,
                0x00,
                0xC4,
                0xA7,
                0xBC,
                0x9C,
                0xF9,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeolocator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xBF,
                0xC3,
                0xA9,
                0x24,
                0x45,
                0x89,
                0x49,
                0x8A,
                0xA9,
                0xDE,
                0x01,
                0x9D,
                0x2E,
                0x55,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeolocator2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x2E,
                0xB4,
                0xD1,
                0x91,
                0x88,
                0xB4,
                0x43,
                0xAD,
                0x36,
                0x27,
                0xC6,
                0xFE,
                0x9A,
                0x97,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeolocatorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x75,
                0x8E,
                0x9A,
                0xF5,
                0x2D,
                0x91,
                0x45,
                0x9F,
                0x87,
                0xEB,
                0x5F,
                0xD8,
                0x94,
                0xE9,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeolocatorStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x11,
                0x30,
                0x99,
                0x1C,
                0xFA,
                0x31,
                0x46,
                0xA7,
                0x1D,
                0x0D,
                0xBE,
                0xB1,
                0x25,
                0x0D,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeolocatorWithScalarAccuracy
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0xD3,
                0xF5,
                0x96,
                0x0F,
                0xB8,
                0x0A,
                0x46,
                0x99,
                0x4D,
                0xA9,
                0x6C,
                0x47,
                0xA5,
                0x1A,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeopath
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xD7,
                0x3F,
                0xE5,
                0xA4,
                0x2D,
                0x14,
                0x47,
                0xA6,
                0x52,
                0xDE,
                0x85,
                0x93,
                0x28,
                0x98,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeopathFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0xA9,
                0xBE,
                0x27,
                0xE7,
                0xC7,
                0x59,
                0x43,
                0x9B,
                0x9B,
                0xFC,
                0xA3,
                0xE0,
                0x5E,
                0xF5,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeopoint
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x00,
                0xFA,
                0x6B,
                0x6E,
                0xE5,
                0xBB,
                0x49,
                0x9C,
                0xAF,
                0xCB,
                0xAA,
                0x78,
                0xA8,
                0xBC,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeopointFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x8D,
                0x6B,
                0xDB,
                0xBD,
                0x76,
                0x30,
                0x4E,
                0x8A,
                0xF7,
                0xA8,
                0x44,
                0xDC,
                0x37,
                0xB7,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeoposition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0x04,
                0x8D,
                0xC1,
                0x41,
                0x7D,
                0xF7,
                0x4F,
                0xA9,
                0x57,
                0x9D,
                0xFF,
                0xB4,
                0xEF,
                0x7F,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeoposition2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0xF6,
                0x62,
                0x7F,
                0x71,
                0x86,
                0x0D,
                0x4B,
                0x86,
                0xF8,
                0x47,
                0x4A,
                0x84,
                0x96,
                0x18,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeoshape
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0xA2,
                0x9C,
                0xC9,
                0x29,
                0xC7,
                0xC1,
                0x43,
                0x8F,
                0xAB,
                0xD6,
                0xDE,
                0xC9,
                0x14,
                0xDF,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeovisit
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x7A,
                0x87,
                0xB1,
                0xF6,
                0x9E,
                0xAB,
                0x41,
                0xA0,
                0xDD,
                0x79,
                0x3E,
                0xCE,
                0x76,
                0xE2,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeovisitMonitor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x8A,
                0x11,
                0x80,
                0x44,
                0x59,
                0x91,
                0x45,
                0x83,
                0xC1,
                0x39,
                0x66,
                0x47,
                0xF5,
                0x4F,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeovisitMonitorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0x76,
                0xF9,
                0xBC,
                0xF2,
                0xBB,
                0xDD,
                0x4C,
                0x95,
                0xCF,
                0x55,
                0x4C,
                0x82,
                0xED,
                0xFB,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeovisitStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0xD1,
                0xB4,
                0xCE,
                0x53,
                0x8B,
                0x68,
                0x49,
                0xBE,
                0xED,
                0x4C,
                0xEC,
                0xD0,
                0x29,
                0xCE,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeovisitTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x0D,
                0x77,
                0xEA,
                0xC9,
                0xD1,
                0x4B,
                0x45,
                0x99,
                0xB7,
                0xB2,
                0xF8,
                0xCD,
                0xD2,
                0x48,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPositionChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x9C,
                0x85,
                0x37,
                0x1E,
                0x9D,
                0xC5,
                0x46,
                0xBF,
                0x3B,
                0x6A,
                0xD8,
                0xCA,
                0xC1,
                0xA0,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStatusChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0xD2,
                0x53,
                0x34,
                0x93,
                0x8C,
                0x11,
                0x41,
                0xA2,
                0x05,
                0x9A,
                0xEC,
                0xFC,
                0x9B,
                0xE5,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVenueData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x91,
                0xF3,
                0x66,
                0xE3,
                0x60,
                0x2F,
                0x4B,
                0xB5,
                0x27,
                0x4F,
                0x53,
                0xF1,
                0xC3,
                0xC6,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
