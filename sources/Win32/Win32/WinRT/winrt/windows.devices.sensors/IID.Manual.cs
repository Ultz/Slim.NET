// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAccelerometer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x45,
                0x18,
                0xDF,
                0x11,
                0x27,
                0xA7,
                0x4D,
                0x80,
                0x98,
                0x4B,
                0x82,
                0x20,
                0x5D,
                0x3C,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometer2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x92,
                0xF0,
                0xE8,
                0x64,
                0x49,
                0x1A,
                0x40,
                0xB6,
                0x02,
                0x22,
                0x0D,
                0x71,
                0x53,
                0xC6,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometer3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0x02,
                0xE0,
                0x87,
                0x80,
                0xED,
                0xEB,
                0x49,
                0xBF,
                0x8A,
                0xA4,
                0xEA,
                0x31,
                0xE5,
                0xCD,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometer4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0x3C,
                0x37,
                0x1D,
                0xD3,
                0x42,
                0xB2,
                0x45,
                0x81,
                0x44,
                0xAB,
                0x7F,
                0xB6,
                0x65,
                0xEB,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometer5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x70,
                0x7E,
                0x7E,
                0xF4,
                0xDE,
                0xA6,
                0x53,
                0xAF,
                0x43,
                0x80,
                0x6F,
                0xD5,
                0x38,
                0xED,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometerDataThreshold
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x1B,
                0x2C,
                0xF9,
                0x20,
                0x63,
                0x77,
                0x55,
                0x87,
                0x9E,
                0x99,
                0x42,
                0x62,
                0x1C,
                0x3D,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometerDeviceId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x64,
                0xAC,
                0x7E,
                0xD5,
                0x97,
                0x6D,
                0x44,
                0xAB,
                0x5A,
                0x91,
                0x7D,
                0xF9,
                0xB9,
                0x6A,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometerReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x7A,
                0xFE,
                0xB9,
                0x51,
                0xD3,
                0xAF,
                0x40,
                0x8B,
                0xB6,
                0x7A,
                0xA9,
                0xAE,
                0x64,
                0x1F,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometerReading2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x4A,
                0x86,
                0x0A,
                0xAE,
                0x15,
                0x40,
                0x4A,
                0xBE,
                0x55,
                0xDB,
                0x58,
                0xD7,
                0xDE,
                0x73,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometerReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0xC6,
                0x95,
                0x00,
                0xAC,
                0xB6,
                0x5A,
                0x47,
                0x9F,
                0x44,
                0x8B,
                0x32,
                0xD3,
                0x5A,
                0x3F,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometerShakenEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x01,
                0xFF,
                0x95,
                0x28,
                0x4A,
                0x35,
                0x4F,
                0x98,
                0xE8,
                0x81,
                0x78,
                0xAA,
                0xE4,
                0x08,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x8B,
                0xE2,
                0xA5,
                0x87,
                0x5A,
                0x2D,
                0x4A,
                0xBE,
                0xCC,
                0x0F,
                0x90,
                0x6E,
                0xA0,
                0x61,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x84,
                0xC4,
                0xC4,
                0x6B,
                0xD8,
                0x85,
                0x46,
                0xB2,
                0xD7,
                0x33,
                0x96,
                0xF7,
                0x98,
                0xD5,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAccelerometerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x18,
                0xE2,
                0x9D,
                0x5D,
                0x45,
                0xF3,
                0x4C,
                0x82,
                0x00,
                0x70,
                0xE1,
                0x41,
                0x03,
                0x40,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActivitySensor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x63,
                0x7A,
                0xCD,
                0x5F,
                0xFB,
                0xEB,
                0x48,
                0xB0,
                0x9B,
                0xA2,
                0x70,
                0x8D,
                0x1C,
                0x61,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActivitySensorReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x5A,
                0x12,
                0x85,
                0x72,
                0x14,
                0xA2,
                0x40,
                0xB2,
                0xAE,
                0xE1,
                0xEF,
                0x29,
                0x22,
                0x6C,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActivitySensorReadingChangeReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x29,
                0x3C,
                0x4F,
                0x3B,
                0xD9,
                0xBD,
                0x47,
                0x96,
                0x0A,
                0xF2,
                0x0F,
                0xB2,
                0xF3,
                0x22,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActivitySensorReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x67,
                0x38,
                0xDE,
                0xB6,
                0xAE,
                0xC7,
                0x4E,
                0x94,
                0x6A,
                0xD9,
                0xCC,
                0x19,
                0xB9,
                0x51,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActivitySensorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x0E,
                0x1E,
                0xA7,
                0x8B,
                0xEE,
                0xD1,
                0x45,
                0xB2,
                0x5B,
                0x08,
                0xCC,
                0x0D,
                0xF9,
                0x2A,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActivitySensorTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x66,
                0x9E,
                0x2C,
                0xCA,
                0xB9,
                0x77,
                0x46,
                0xB2,
                0x63,
                0x24,
                0x32,
                0x97,
                0xF7,
                0x9D,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveDimmingOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x3C,
                0x21,
                0xD3,
                0xB5,
                0x89,
                0x32,
                0x57,
                0xB2,
                0xA0,
                0xAE,
                0xFE,
                0x32,
                0x4F,
                0x54,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAltimeter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x57,
                0xF0,
                0x72,
                0x04,
                0x8F,
                0xF1,
                0x49,
                0xB4,
                0xA7,
                0xF4,
                0xE3,
                0x63,
                0xB7,
                0x01,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAltimeter2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x1B,
                0x47,
                0xC9,
                0xDD,
                0x2A,
                0xF5,
                0x48,
                0x9F,
                0x08,
                0x3D,
                0x0C,
                0x76,
                0x60,
                0xD9,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAltimeterReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xEF,
                0xE8,
                0xFB,
                0x5E,
                0x7F,
                0xC8,
                0x48,
                0xAA,
                0x1A,
                0xF1,
                0xF3,
                0xBE,
                0xFC,
                0x11,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAltimeterReading2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x1B,
                0x3A,
                0x54,
                0x0B,
                0x6D,
                0xB2,
                0x42,
                0xBD,
                0x69,
                0xBC,
                0x8F,
                0xAE,
                0x0F,
                0x78,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAltimeterReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0xD0,
                0x69,
                0x70,
                0x6D,
                0x44,
                0xF7,
                0x47,
                0x99,
                0x8C,
                0xEB,
                0xC2,
                0x3B,
                0x45,
                0xE4,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAltimeterStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0xD7,
                0xB4,
                0x9E,
                0xAC,
                0xE5,
                0xCE,
                0x47,
                0x8E,
                0xEF,
                0xD3,
                0x71,
                0x81,
                0x68,
                0xC0,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBarometer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x75,
                0x44,
                0x93,
                0xBF,
                0x78,
                0x2F,
                0x45,
                0xB0,
                0x17,
                0xF0,
                0x20,
                0x9C,
                0xE6,
                0xDA,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBarometer2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0xC4,
                0xBC,
                0x32,
                0xEB,
                0x3E,
                0x04,
                0x4D,
                0x95,
                0x74,
                0x76,
                0x33,
                0xA8,
                0x78,
                0x1F,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBarometer3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0xF0,
                0x35,
                0x0E,
                0xB5,
                0x02,
                0x04,
                0x5A,
                0xB0,
                0x3D,
                0x82,
                0x20,
                0x84,
                0x86,
                0x3A,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBarometerDataThreshold
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0x95,
                0x6B,
                0x07,
                0x62,
                0xCB,
                0x90,
                0x5A,
                0xA0,
                0xD1,
                0xF8,
                0x5E,
                0x4A,
                0x93,
                0x63,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBarometerReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0xD2,
                0xB9,
                0xF5,
                0xF6,
                0x1D,
                0x1A,
                0x4A,
                0xA7,
                0xAD,
                0x32,
                0x1D,
                0x4F,
                0x5D,
                0xB2,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBarometerReading2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x44,
                0xA2,
                0x85,
                0xC5,
                0x90,
                0x75,
                0x48,
                0x89,
                0x1C,
                0x38,
                0x65,
                0xB4,
                0xC3,
                0x57,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBarometerReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x94,
                0x84,
                0x3D,
                0x7B,
                0x03,
                0x4F,
                0x40,
                0x9B,
                0xBB,
                0x62,
                0x32,
                0xD6,
                0x95,
                0x43,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBarometerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x27,
                0x6B,
                0x28,
                0xE3,
                0x02,
                0x86,
                0x4F,
                0x84,
                0xFC,
                0xFD,
                0xD8,
                0x92,
                0xB5,
                0x94,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBarometerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xB1,
                0xC6,
                0x8F,
                0xFF,
                0x95,
                0xAC,
                0x44,
                0x87,
                0x8E,
                0xD6,
                0x5C,
                0x83,
                0x08,
                0xC3,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompass
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0xFA,
                0x2F,
                0x29,
                0x45,
                0x1B,
                0x3C,
                0x40,
                0xBA,
                0x06,
                0xB1,
                0x06,
                0xDB,
                0xA6,
                0x9A,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompass2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x6D,
                0xF2,
                0x36,
                0xD7,
                0xC7,
                0x4F,
                0x43,
                0xB4,
                0x61,
                0x97,
                0x9D,
                0xDF,
                0xC2,
                0x32,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompass3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x80,
                0x24,
                0xA4,
                0xEA,
                0xC5,
                0x45,
                0x4D,
                0xA0,
                0xEC,
                0x4B,
                0x79,
                0x1F,
                0x04,
                0x1A,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompass4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x7F,
                0x1E,
                0x29,
                0x32,
                0xEC,
                0xCC,
                0x5D,
                0xBF,
                0xCB,
                0x0B,
                0xB3,
                0x9E,
                0xBA,
                0x57,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompassDataThreshold
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x52,
                0x5B,
                0xD1,
                0x9D,
                0xD3,
                0xC8,
                0x5E,
                0xB2,
                0xE4,
                0xF1,
                0x93,
                0xE6,
                0xAB,
                0x34,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompassDeviceId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xCA,
                0x81,
                0xD1,
                0x85,
                0xB0,
                0x1D,
                0x4B,
                0x87,
                0x0A,
                0x4F,
                0xF5,
                0x7B,
                0xA7,
                0x4F,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompassReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x11,
                0x91,
                0x82,
                0x3D,
                0x51,
                0xC9,
                0x4D,
                0xB7,
                0x81,
                0x5E,
                0xED,
                0xFB,
                0xF0,
                0x2D,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompassReading2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x66,
                0x3A,
                0xB1,
                0xBB,
                0x51,
                0x12,
                0x4A,
                0xBE,
                0xDD,
                0xAD,
                0x47,
                0xFF,
                0x87,
                0xD2,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompassReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x49,
                0x15,
                0x8F,
                0xBC,
                0xE8,
                0x7E,
                0x4C,
                0xB0,
                0x09,
                0x4E,
                0x41,
                0xDF,
                0x13,
                0x70,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompassReadingHeadingAccuracy
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x35,
                0x61,
                0xE7,
                0x11,
                0x89,
                0xF7,
                0x40,
                0x9E,
                0x16,
                0x6E,
                0xCC,
                0x7D,
                0xAE,
                0xC5,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompassStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x97,
                0xBC,
                0x9A,
                0xEC,
                0x56,
                0x25,
                0x4C,
                0xB5,
                0x4D,
                0x40,
                0xA6,
                0x8B,
                0xB5,
                0xB2,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompassStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x0E,
                0xCE,
                0x0A,
                0xAA,
                0x3B,
                0x90,
                0x49,
                0x9C,
                0xE4,
                0xBE,
                0x09,
                0x13,
                0x75,
                0x4E,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0xA9,
                0xB9,
                0xFD,
                0xB1,
                0x84,
                0xA2,
                0x4C,
                0x97,
                0x63,
                0x9B,
                0x58,
                0x95,
                0x06,
                0xC7,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometer2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x24,
                0xDF,
                0x63,
                0xE8,
                0x8C,
                0xC3,
                0x41,
                0xAC,
                0x44,
                0x86,
                0x98,
                0x81,
                0x0B,
                0x55,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometer3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x88,
                0x6F,
                0x5D,
                0xBC,
                0x8F,
                0x84,
                0x44,
                0x91,
                0x4B,
                0x52,
                0x8A,
                0xDF,
                0xD9,
                0x47,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometer4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0xA6,
                0x28,
                0x06,
                0x4B,
                0x4C,
                0x96,
                0x50,
                0x94,
                0xE6,
                0xC3,
                0x56,
                0xDF,
                0x68,
                0xBE,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometerDataThreshold
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0xB3,
                0x48,
                0x86,
                0x52,
                0x6E,
                0x59,
                0x52,
                0xBB,
                0xAD,
                0x24,
                0x2A,
                0x69,
                0xDC,
                0x38,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometerDeviceId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xE9,
                0xE5,
                0x1E,
                0xA2,
                0x89,
                0x75,
                0x42,
                0x9E,
                0x95,
                0x71,
                0x26,
                0xF4,
                0x70,
                0x87,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometerReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0xDE,
                0xD6,
                0xB3,
                0xE4,
                0x1E,
                0x6F,
                0x45,
                0x9D,
                0xE7,
                0xE2,
                0x49,
                0x3B,
                0x5C,
                0x8E,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometerReading2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xE1,
                0xAF,
                0x16,
                0x89,
                0x2B,
                0xBB,
                0x44,
                0x82,
                0x2B,
                0xD1,
                0xE1,
                0x55,
                0x6F,
                0xF0,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometerReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x18,
                0xDF,
                0x0F,
                0x9E,
                0x6F,
                0xCE,
                0x42,
                0x8D,
                0x58,
                0x38,
                0x8C,
                0x0A,
                0xB8,
                0x35,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0xE7,
                0xB6,
                0x83,
                0x9D,
                0xE4,
                0x39,
                0x4B,
                0x86,
                0xE6,
                0xCD,
                0x55,
                0x4B,
                0xE4,
                0xC5,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGyrometerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xF7,
                0x83,
                0xEF,
                0x00,
                0xD7,
                0x04,
                0x42,
                0x96,
                0x13,
                0x79,
                0xC6,
                0xB1,
                0x61,
                0xDF,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHingeAngleReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0x45,
                0xCD,
                0xA3,
                0xF1,
                0x1B,
                0x65,
                0x4F,
                0xA7,
                0x04,
                0xE2,
                0xDA,
                0x04,
                0xF1,
                0x82,
                0xC0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHingeAngleSensor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xBE,
                0xD3,
                0xE9,
                0xDF,
                0xBF,
                0x7F,
                0x43,
                0x8C,
                0x29,
                0x88,
                0xC7,
                0x73,
                0x93,
                0xD3,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHingeAngleSensorReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x55,
                0xD9,
                0x24,
                0xD0,
                0xFA,
                0xB8,
                0x42,
                0xA8,
                0x54,
                0x78,
                0x92,
                0x30,
                0x49,
                0xA1,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHingeAngleSensorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x39,
                0xB6,
                0xB7,
                0xB1,
                0xFB,
                0x23,
                0x41,
                0x89,
                0xCE,
                0x4E,
                0xA3,
                0x4E,
                0xB0,
                0xDF,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceFeatures
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x9F,
                0xB0,
                0xBD,
                0x44,
                0x32,
                0x7A,
                0x55,
                0xBD,
                0x29,
                0x8B,
                0x00,
                0x4F,
                0x59,
                0xF2,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceFeatures2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0xCD,
                0xA9,
                0x08,
                0x29,
                0xD9,
                0xC2,
                0x5E,
                0x81,
                0xE2,
                0x94,
                0x0B,
                0xAF,
                0xA0,
                0x89,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSensor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x78,
                0x16,
                0x21,
                0x89,
                0xE3,
                0xC3,
                0x5C,
                0x9A,
                0x97,
                0xCB,
                0x17,
                0xBE,
                0x10,
                0x08,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSensor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x37,
                0x83,
                0xF8,
                0xFE,
                0x65,
                0x1A,
                0x54,
                0xB9,
                0xD6,
                0x1E,
                0x47,
                0x4A,
                0x48,
                0x5E,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSensorExtension
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x6A,
                0x52,
                0x3E,
                0x1D,
                0x2D,
                0x43,
                0x5D,
                0x8A,
                0x8E,
                0xA4,
                0x34,
                0xA8,
                0x24,
                0x2E,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSensorReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0x3B,
                0x53,
                0x83,
                0x5A,
                0xA8,
                0x50,
                0x5D,
                0x8B,
                0xE4,
                0x60,
                0x72,
                0xD7,
                0x45,
                0xA3,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSensorReading2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xE9,
                0xF0,
                0xC4,
                0xFF,
                0x3B,
                0xD6,
                0x53,
                0xA0,
                0xF8,
                0x51,
                0x4E,
                0xA3,
                0x70,
                0x5C,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSensorReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x45,
                0xDC,
                0xA9,
                0x69,
                0xFD,
                0x5E,
                0x5C,
                0xAB,
                0x1F,
                0x94,
                0x22,
                0x04,
                0xEA,
                0xE2,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSensorReadingUpdate
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x77,
                0x9C,
                0x41,
                0x42,
                0x2F,
                0x6D,
                0xA0,
                0x55,
                0x9E,
                0x01,
                0xC9,
                0xCB,
                0xE7,
                0xB2,
                0xD6,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSensorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x98,
                0xE8,
                0x2A,
                0xA9,
                0xDB,
                0xB2,
                0x56,
                0x9F,
                0x27,
                0xEA,
                0xC6,
                0x9D,
                0x62,
                0x10,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSensorStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x58,
                0xE3,
                0x5D,
                0x60,
                0xD2,
                0x87,
                0x5A,
                0x99,
                0x5E,
                0xAC,
                0xE9,
                0x13,
                0x26,
                0xE1,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0xAF,
                0x4D,
                0xEF,
                0xB7,
                0x07,
                0xB6,
                0x5E,
                0x86,
                0xBB,
                0xB7,
                0xFF,
                0x49,
                0xCE,
                0x44,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSettings2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x70,
                0x6F,
                0xA2,
                0x96,
                0x86,
                0xB4,
                0x5E,
                0xB9,
                0xE1,
                0x26,
                0xA5,
                0x08,
                0xDE,
                0x1C,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHumanPresenceSettingsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0x32,
                0x34,
                0x7F,
                0x10,
                0xE0,
                0xC4,
                0x52,
                0xAF,
                0x0C,
                0x04,
                0xA8,
                0xF1,
                0xE0,
                0x33,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0xCA,
                0x48,
                0x26,
                0x86,
                0x22,
                0x6F,
                0x40,
                0x91,
                0x61,
                0xF0,
                0xC4,
                0xBD,
                0x80,
                0x6E,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometer2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x33,
                0x9F,
                0x02,
                0xB2,
                0x28,
                0xF8,
                0x45,
                0xBB,
                0x16,
                0x61,
                0xE8,
                0x6A,
                0x7F,
                0xAE,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometer3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x50,
                0x09,
                0x3A,
                0x65,
                0xD7,
                0x84,
                0x43,
                0xA3,
                0xD7,
                0x02,
                0x83,
                0xF3,
                0xAB,
                0xE6,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometer4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x26,
                0x85,
                0x43,
                0xCA,
                0x8F,
                0x8E,
                0x54,
                0xBB,
                0xF5,
                0x5C,
                0x50,
                0x41,
                0x2B,
                0x6A,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometerDataThreshold
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x47,
                0x0A,
                0xF8,
                0xFE,
                0x7B,
                0x5E,
                0x54,
                0xBB,
                0x60,
                0xA0,
                0xEB,
                0xC4,
                0x7B,
                0xD2,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometerDeviceId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x19,
                0xE9,
                0x01,
                0xFF,
                0x41,
                0x06,
                0x44,
                0xAE,
                0x83,
                0x62,
                0x21,
                0x0F,
                0xF1,
                0x6F,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometerReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0xF0,
                0x44,
                0x9F,
                0xF6,
                0xB6,
                0x7F,
                0x49,
                0xB1,
                0x27,
                0x1A,
                0x77,
                0x5E,
                0x50,
                0x14,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometerReading2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x47,
                0x16,
                0x4F,
                0x0B,
                0xE9,
                0x58,
                0x46,
                0x89,
                0x15,
                0x01,
                0x03,
                0xE0,
                0x8A,
                0x80,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometerReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x1D,
                0xE9,
                0x4A,
                0xEB,
                0xE7,
                0x38,
                0x49,
                0x85,
                0x11,
                0xAE,
                0x0D,
                0x6B,
                0x44,
                0x04,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometerReadingYawAccuracy
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0xE8,
                0x53,
                0xB4,
                0xE3,
                0x1F,
                0x86,
                0x49,
                0xA2,
                0x57,
                0xE6,
                0xEC,
                0xE2,
                0x72,
                0x39,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xC5,
                0x2E,
                0xF2,
                0x30,
                0x9C,
                0x3A,
                0x45,
                0x8B,
                0x49,
                0x3C,
                0x3E,
                0xEB,
                0x33,
                0xCB,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x97,
                0x3F,
                0x04,
                0x1E,
                0x6A,
                0x9C,
                0x49,
                0x86,
                0xE0,
                0x63,
                0x8C,
                0x1A,
                0x86,
                0x4B,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x42,
                0x9A,
                0xBD,
                0x1A,
                0xB9,
                0x29,
                0x48,
                0x93,
                0x92,
                0xAB,
                0xC0,
                0xB6,
                0xBD,
                0xF2,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInclinometerStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x96,
                0xBA,
                0xE8,
                0x85,
                0x6E,
                0x83,
                0x4A,
                0xAE,
                0xD0,
                0xD7,
                0xCD,
                0xCC,
                0x98,
                0x56,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILightSensor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x07,
                0x4C,
                0xF8,
                0x54,
                0x0C,
                0xAE,
                0x47,
                0x92,
                0x2E,
                0x78,
                0x9F,
                0x57,
                0xFB,
                0x03,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILightSensor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x24,
                0x6B,
                0x48,
                0x4C,
                0xA9,
                0x90,
                0x40,
                0x8F,
                0x48,
                0x09,
                0xF7,
                0x82,
                0xA9,
                0xF7,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILightSensor3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0xD0,
                0x76,
                0x48,
                0x4C,
                0x9F,
                0x72,
                0x5F,
                0xAD,
                0xBD,
                0xA3,
                0x47,
                0x1B,
                0x06,
                0x3C,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILightSensorDataThreshold
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0xAF,
                0x60,
                0xB1,
                0x8F,
                0x87,
                0x92,
                0x54,
                0x9F,
                0x2C,
                0x33,
                0xDC,
                0x3A,
                0xE5,
                0x84,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILightSensorDeviceId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x49,
                0xEE,
                0x7F,
                0xFB,
                0x0A,
                0x51,
                0x4F,
                0x87,
                0xF0,
                0x6C,
                0x26,
                0x37,
                0x5C,
                0xE9,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILightSensorReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x63,
                0xDF,
                0xFF,
                0x7C,
                0x22,
                0x2B,
                0x4D,
                0xB3,
                0x02,
                0xFC,
                0x01,
                0x42,
                0x48,
                0x5C,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILightSensorReading2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x21,
                0x51,
                0xB7,
                0xA3,
                0x44,
                0xC9,
                0x44,
                0x81,
                0x90,
                0x9E,
                0xF6,
                0xDE,
                0x0A,
                0x8A,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILightSensorReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0xF4,
                0xA2,
                0xA3,
                0x8B,
                0x25,
                0x0C,
                0x42,
                0xB8,
                0xAB,
                0x8E,
                0xDD,
                0x60,
                0x1E,
                0xCF,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILightSensorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0x8C,
                0xDB,
                0x45,
                0xA8,
                0xC3,
                0x1E,
                0x47,
                0x9A,
                0x53,
                0x64,
                0x57,
                0xFA,
                0xD8,
                0x7C,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILightSensorStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xA6,
                0xC0,
                0x0E,
                0xC6,
                0xDD,
                0xAB,
                0x40,
                0xAC,
                0xE3,
                0xEC,
                0x33,
                0x59,
                0xD4,
                0x2C,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILockOnLeaveOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0xF8,
                0x6B,
                0x3C,
                0xC1,
                0x04,
                0x29,
                0x58,
                0x8D,
                0x4E,
                0x70,
                0x52,
                0x17,
                0x55,
                0xB8,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x62,
                0x4F,
                0x48,
                0xC9,
                0xD3,
                0x11,
                0x41,
                0xB3,
                0xF6,
                0x2C,
                0xF1,
                0xFA,
                0xA4,
                0x18,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometer2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x6C,
                0x65,
                0xB4,
                0xF6,
                0x26,
                0x4B,
                0x44,
                0xA9,
                0xE2,
                0xA2,
                0x3F,
                0x96,
                0x6C,
                0xD3,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometer3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0xDB,
                0x93,
                0xBE,
                0x25,
                0xA6,
                0xEF,
                0x48,
                0xAC,
                0xF7,
                0xFA,
                0xC1,
                0x04,
                0x83,
                0x26,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometer4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x79,
                0xB1,
                0xDF,
                0x0F,
                0x3E,
                0x8F,
                0x50,
                0xB2,
                0x4B,
                0xF2,
                0xBB,
                0x75,
                0x01,
                0x5F,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometerDataThreshold
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xCB,
                0x77,
                0xD1,
                0x63,
                0x90,
                0xA5,
                0x5F,
                0xB5,
                0x96,
                0xB4,
                0x45,
                0xE9,
                0xDC,
                0x34,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometerDeviceId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0x98,
                0xB4,
                0x58,
                0x4B,
                0x7E,
                0x4C,
                0x40,
                0x9F,
                0xC5,
                0x5D,
                0xE8,
                0xB4,
                0x0E,
                0xBA,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometerReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xC4,
                0x2C,
                0x0C,
                0xFD,
                0xEB,
                0x5C,
                0x4E,
                0xBB,
                0x11,
                0xAF,
                0xC2,
                0x9B,
                0x3C,
                0xAE,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometerReading2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x5C,
                0xC9,
                0xD4,
                0xD9,
                0x61,
                0x4B,
                0x40,
                0xA3,
                0x28,
                0x06,
                0x6F,
                0x17,
                0x7A,
                0x14,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometerReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0xE8,
                0xEA,
                0x17,
                0xB9,
                0x2E,
                0xE7,
                0x4E,
                0x8A,
                0xD0,
                0x31,
                0x27,
                0x53,
                0x7D,
                0x94,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x64,
                0x3C,
                0x85,
                0x98,
                0x06,
                0xDA,
                0x4D,
                0xA6,
                0xDF,
                0x9C,
                0xB9,
                0xCC,
                0x4A,
                0xB4,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMagnetometerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x19,
                0x08,
                0x2C,
                0xC6,
                0xFF,
                0x89,
                0x4F,
                0xA0,
                0x6F,
                0x18,
                0xFA,
                0x10,
                0x79,
                0x29,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x46,
                0x35,
                0x5E,
                0x6B,
                0xCF,
                0x63,
                0x4C,
                0xAB,
                0xD8,
                0x10,
                0x25,
                0x2B,
                0x0B,
                0xF6,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x4C,
                0x92,
                0x0D,
                0x1F,
                0x2F,
                0xC9,
                0x49,
                0x80,
                0x42,
                0x4A,
                0x18,
                0x13,
                0xD6,
                0x77,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensor3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x57,
                0xCE,
                0x2C,
                0x6B,
                0x64,
                0xC5,
                0x48,
                0xB7,
                0xEE,
                0x44,
                0xFD,
                0xC4,
                0xC6,
                0xAA,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensorDeviceId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xB6,
                0x69,
                0x5A,
                0x29,
                0x4C,
                0xEC,
                0x49,
                0xB2,
                0x8F,
                0xEA,
                0x1D,
                0x11,
                0x7B,
                0x66,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensorReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0xC9,
                0x56,
                0x47,
                0x95,
                0x65,
                0x97,
                0x48,
                0xBC,
                0xC6,
                0xD5,
                0x37,
                0xEE,
                0x75,
                0x75,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensorReading2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x6E,
                0x57,
                0x00,
                0xF8,
                0x49,
                0x05,
                0x4C,
                0x9E,
                0x07,
                0x24,
                0xFA,
                0xC7,
                0x94,
                0x08,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensorReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x11,
                0x2C,
                0x01,
                0xBA,
                0xC3,
                0xBC,
                0x46,
                0xAE,
                0x65,
                0x7A,
                0x98,
                0x99,
                0x6C,
                0xBF,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensorReadingYawAccuracy
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x98,
                0xAC,
                0xD1,
                0x5A,
                0x3F,
                0xA2,
                0x49,
                0xBC,
                0x7B,
                0x11,
                0x80,
                0xBC,
                0x38,
                0xCD,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x87,
                0xEF,
                0x10,
                0x4C,
                0xFB,
                0x8A,
                0x42,
                0x89,
                0x8B,
                0x27,
                0x65,
                0xE4,
                0x09,
                0xE6,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensorStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0x0D,
                0xDA,
                0x59,
                0x0A,
                0xD4,
                0x71,
                0x4C,
                0x92,
                0x76,
                0x8A,
                0x27,
                0x2A,
                0x0A,
                0x66,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensorStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0xE9,
                0x2C,
                0xD8,
                0x77,
                0x27,
                0xFF,
                0x40,
                0x9F,
                0x59,
                0xD6,
                0x54,
                0xB0,
                0x85,
                0xF1,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOrientationSensorStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0xEB,
                0x7F,
                0xA6,
                0x85,
                0x2C,
                0x28,
                0x4B,
                0xA0,
                0xFE,
                0x58,
                0xC4,
                0xB2,
                0x04,
                0x95,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPedometer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x01,
                0x1E,
                0x9A,
                0x98,
                0x3D,
                0xF8,
                0x45,
                0x89,
                0x20,
                0x8E,
                0x4E,
                0xCA,
                0xCA,
                0x5F,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPedometer2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x06,
                0xA4,
                0xE5,
                0x81,
                0x2B,
                0xDD,
                0x4A,
                0xB2,
                0xFF,
                0x77,
                0xAB,
                0x6C,
                0x98,
                0xBA,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPedometerDataThresholdFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0x8F,
                0xAD,
                0xCB,
                0x54,
                0x7A,
                0x6B,
                0x46,
                0x90,
                0x10,
                0x77,
                0xA1,
                0x62,
                0xFC,
                0xA5,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPedometerReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xDC,
                0x45,
                0x22,
                0xE1,
                0xA8,
                0x2F,
                0x43,
                0x89,
                0x6A,
                0xBE,
                0x0D,
                0xD9,
                0xB0,
                0x2D,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPedometerReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0xE4,
                0x55,
                0xF8,
                0xBC,
                0xAB,
                0x56,
                0x44,
                0x86,
                0xA8,
                0x25,
                0xCF,
                0x2B,
                0x33,
                0x37,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPedometerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x0A,
                0x98,
                0x82,
                0x83,
                0x40,
                0xFB,
                0x4D,
                0xB4,
                0x11,
                0x93,
                0x8E,
                0xA0,
                0xF4,
                0xB9,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPedometerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0xC6,
                0xF5,
                0x79,
                0x0E,
                0xCE,
                0x33,
                0x41,
                0xB4,
                0x7E,
                0x86,
                0x27,
                0xEA,
                0x72,
                0xF6,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProximitySensor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x76,
                0xC0,
                0x54,
                0xFB,
                0xEC,
                0x44,
                0x49,
                0xB9,
                0x28,
                0x74,
                0xFC,
                0x50,
                0x4D,
                0x47,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProximitySensorDataThresholdFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0xC1,
                0x5A,
                0x90,
                0x27,
                0x6D,
                0xD3,
                0x4A,
                0x9D,
                0xB5,
                0x64,
                0x67,
                0xF2,
                0xA5,
                0xAD,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProximitySensorReading
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x59,
                0x8D,
                0x22,
                0x71,
                0x2D,
                0x13,
                0x5F,
                0x4D,
                0x8F,
                0xF9,
                0x2F,
                0x0D,
                0xB8,
                0x75,
                0x1C,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProximitySensorReadingChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0xF3,
                0xC2,
                0xCF,
                0xE8,
                0xC3,
                0xFD,
                0x40,
                0x8C,
                0xC3,
                0x67,
                0xE2,
                0x89,
                0x00,
                0x49,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProximitySensorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x66,
                0x18,
                0x29,
                0x69,
                0x62,
                0x57,
                0x4E,
                0xA5,
                0xAD,
                0x82,
                0xBE,
                0x80,
                0x81,
                0x33,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProximitySensorStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0x73,
                0xF4,
                0xCB,
                0xCA,
                0xE9,
                0x2F,
                0x42,
                0xAD,
                0x67,
                0x4C,
                0x3D,
                0x25,
                0xDF,
                0x35,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISensorDataThreshold
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xEC,
                0xDA,
                0x54,
                0x4B,
                0xFE,
                0x07,
                0x4E,
                0xB2,
                0x60,
                0x3A,
                0x4C,
                0xDF,
                0xBE,
                0x39,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISensorDataThresholdTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0xF1,
                0x06,
                0x91,
                0x8D,
                0xE8,
                0xB1,
                0x48,
                0xBC,
                0x90,
                0x61,
                0x9C,
                0x7B,
                0x34,
                0x93,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISensorQuaternion
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xC8,
                0xC5,
                0xC9,
                0x1C,
                0xC7,
                0xE7,
                0x46,
                0x9D,
                0xA3,
                0x36,
                0xA1,
                0x93,
                0xB2,
                0x32,
                0xBC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISensorRotationMatrix
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x5A,
                0x3D,
                0x0A,
                0xF4,
                0x22,
                0x92,
                0x43,
                0x95,
                0x38,
                0x65,
                0xD0,
                0xBD,
                0x06,
                0x4A,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISimpleOrientationSensor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x38,
                0xF5,
                0x5F,
                0x4A,
                0x21,
                0xEE,
                0x4D,
                0xA3,
                0xF9,
                0x61,
                0x6F,
                0x1A,
                0xB0,
                0x6F,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISimpleOrientationSensor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0xA7,
                0x77,
                0xA2,
                0x70,
                0x88,
                0x3E,
                0x45,
                0x8B,
                0xD6,
                0xB8,
                0xF5,
                0xD8,
                0xD7,
                0x94,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISimpleOrientationSensorDeviceId
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x0A,
                0xC0,
                0xFB,
                0x76,
                0x3B,
                0xF6,
                0x41,
                0x80,
                0x91,
                0x30,
                0xEF,
                0xE6,
                0x46,
                0xD3,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISimpleOrientationSensorOrientationChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0xC6,
                0xD5,
                0xBC,
                0xD4,
                0x23,
                0x4C,
                0x4B,
                0xA2,
                0x2E,
                0xBA,
                0x81,
                0xAD,
                0xE0,
                0xC6,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISimpleOrientationSensorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6F,
                0x06,
                0xED,
                0x72,
                0xAA,
                0x70,
                0xC6,
                0x40,
                0x9B,
                0x1B,
                0x34,
                0x33,
                0xF7,
                0x45,
                0x9B,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISimpleOrientationSensorStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x9C,
                0x8F,
                0x84,
                0x38,
                0xB1,
                0x11,
                0x4E,
                0x89,
                0x10,
                0xA2,
                0xA2,
                0xA3,
                0xB5,
                0x6D,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWakeOnApproachOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x7A,
                0xB8,
                0xF0,
                0x1F,
                0x7E,
                0xA5,
                0x5E,
                0x81,
                0x4D,
                0x6B,
                0x7E,
                0x07,
                0xDE,
                0xFC,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
