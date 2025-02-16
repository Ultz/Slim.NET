// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ISpatialAnchor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0xE5,
                0x29,
                0x05,
                0x34,
                0x1D,
                0x02,
                0x37,
                0xBC,
                0xEC,
                0xEA,
                0xBF,
                0xF5,
                0x78,
                0xA8,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAnchor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xC9,
                0x17,
                0xED,
                0x95,
                0xA6,
                0xF6,
                0x4C,
                0x92,
                0xFD,
                0x97,
                0x26,
                0x3B,
                0xA7,
                0x10,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAnchorExportSufficiency
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x5B,
                0xC2,
                0x77,
                0x09,
                0x34,
                0x88,
                0x40,
                0xB9,
                0x1B,
                0xFD,
                0xFD,
                0x05,
                0xD1,
                0x64,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAnchorExporter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0x43,
                0x2A,
                0x9A,
                0xFB,
                0x24,
                0x69,
                0x42,
                0x89,
                0xC5,
                0x88,
                0x30,
                0x4A,
                0xEE,
                0xF2,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAnchorExporterStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x07,
                0x25,
                0xED,
                0x75,
                0x24,
                0x9C,
                0x43,
                0x85,
                0xFF,
                0x7F,
                0xED,
                0x34,
                0x1F,
                0xDC,
                0x88,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAnchorManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0x0E,
                0xE3,
                0x88,
                0xB7,
                0xF3,
                0x0B,
                0x42,
                0xB0,
                0x86,
                0x8A,
                0x80,
                0xC0,
                0x7D,
                0x91,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAnchorRawCoordinateSystemAdjustedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x1E,
                0xE8,
                0xA1,
                0xC7,
                0x56,
                0x17,
                0x31,
                0xA2,
                0xE4,
                0x81,
                0xE0,
                0xFC,
                0xF2,
                0x8E,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAnchorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x86,
                0x92,
                0xA9,
                0x74,
                0x01,
                0x1C,
                0x31,
                0xAE,
                0x79,
                0x0E,
                0x51,
                0x07,
                0x66,
                0x9F,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAnchorStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0x36,
                0xBC,
                0xB0,
                0x6A,
                0x48,
                0xB0,
                0x3C,
                0x9E,
                0x6F,
                0x12,
                0x45,
                0x16,
                0x5C,
                0x4D,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAnchorTransferManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xF9,
                0xBB,
                0x03,
                0xD8,
                0x12,
                0xCE,
                0x4B,
                0x88,
                0x35,
                0xC5,
                0xDF,
                0x3A,
                0xC0,
                0xAD,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialBoundingVolume
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x65,
                0x20,
                0xFB,
                0xC3,
                0x68,
                0xDF,
                0x33,
                0xB7,
                0xAF,
                0x4C,
                0x78,
                0x72,
                0x07,
                0x99,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialBoundingVolumeStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x91,
                0x88,
                0x05,
                0xE1,
                0xB3,
                0xD8,
                0x36,
                0xB0,
                0x17,
                0x56,
                0x61,
                0x81,
                0xA5,
                0xB1,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialCoordinateSystem
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0xCA,
                0xEB,
                0x69,
                0xA3,
                0x60,
                0x86,
                0x35,
                0xA6,
                0x53,
                0x59,
                0xA7,
                0xBD,
                0x67,
                0x6D,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialEntity
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0xE9,
                0x6D,
                0x16,
                0xEB,
                0xE1,
                0x4C,
                0x45,
                0xBA,
                0x08,
                0xE6,
                0xC0,
                0x66,
                0x8D,
                0xDC,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialEntityAddedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xF4,
                0x97,
                0xA3,
                0x6A,
                0x15,
                0x07,
                0x47,
                0xAC,
                0x2C,
                0xD3,
                0x1D,
                0x57,
                0x0E,
                0xD3,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialEntityFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0xE3,
                0xF1,
                0xE1,
                0x9F,
                0x34,
                0x25,
                0x42,
                0xA2,
                0xF3,
                0x4B,
                0x01,
                0xC1,
                0x5F,
                0xE0,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialEntityRemovedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x18,
                0x74,
                0x91,
                0x6D,
                0x53,
                0x9F,
                0x4E,
                0xAB,
                0xF6,
                0x41,
                0x5B,
                0x54,
                0x44,
                0xD6,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialEntityStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x88,
                0x97,
                0x32,
                0x13,
                0xE5,
                0x06,
                0x4F,
                0x88,
                0x9D,
                0x1B,
                0xE3,
                0x0E,
                0xCF,
                0x43,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialEntityStoreStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x38,
                0x4B,
                0x6B,
                0x50,
                0x7C,
                0x92,
                0x4E,
                0x8A,
                0x62,
                0x4D,
                0x1D,
                0x4B,
                0x7C,
                0xCD,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialEntityUpdatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x17,
                0x67,
                0xE5,
                0x7B,
                0x62,
                0xCB,
                0x43,
                0xA4,
                0x9F,
                0xB3,
                0xBE,
                0x6D,
                0x47,
                0xDE,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialEntityWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x5F,
                0xB8,
                0xB3,
                0x5E,
                0x6D,
                0xBC,
                0x4B,
                0x80,
                0x5D,
                0x5F,
                0xE5,
                0xB9,
                0xBA,
                0x19,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialLocation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0xD2,
                0x81,
                0x1D,
                0xA1,
                0x24,
                0xD5,
                0x37,
                0x8F,
                0xA1,
                0x39,
                0xB4,
                0xF9,
                0xAD,
                0x67,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialLocation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x24,
                0x7F,
                0x11,
                0xA7,
                0x38,
                0x18,
                0x4A,
                0xB4,
                0x04,
                0xAB,
                0x8F,
                0xAB,
                0xE1,
                0xD7,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialLocator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x89,
                0x47,
                0xF6,
                0x0C,
                0x9E,
                0xB6,
                0x3B,
                0x99,
                0x7E,
                0xB6,
                0x4E,
                0xCC,
                0xA2,
                0x4C,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialLocatorAttachedFrameOfReference
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x4E,
                0x77,
                0xE1,
                0x4F,
                0x1F,
                0x9C,
                0x49,
                0x96,
                0x25,
                0xEF,
                0x5E,
                0x6E,
                0xD7,
                0xA0,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialLocatorPositionalTrackingDeactivatingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0x40,
                0xA8,
                0xB8,
                0xF4,
                0xE3,
                0x8B,
                0x36,
                0x90,
                0x61,
                0x9E,
                0xA9,
                0xD1,
                0xD6,
                0xCC,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialLocatorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x33,
                0x6E,
                0xB7,
                0xC2,
                0xA7,
                0x1B,
                0x36,
                0xBB,
                0x82,
                0x56,
                0xE9,
                0x3B,
                0x89,
                0xB1,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialStageFrameOfReference
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x34,
                0x8A,
                0x7A,
                0x0D,
                0xAD,
                0x90,
                0x45,
                0xAB,
                0x86,
                0x33,
                0x06,
                0x2B,
                0x67,
                0x49,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialStageFrameOfReferenceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x5C,
                0x8D,
                0xF7,
                0xA4,
                0xA0,
                0x9C,
                0x49,
                0x8D,
                0x91,
                0xA8,
                0xC9,
                0x65,
                0xD4,
                0x06,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialStationaryFrameOfReference
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xCC,
                0xDB,
                0x09,
                0xF8,
                0xBC,
                0x7F,
                0x3E,
                0xBE,
                0x7E,
                0x7E,
                0xDC,
                0xCB,
                0xB1,
                0x78,
                0xA8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
