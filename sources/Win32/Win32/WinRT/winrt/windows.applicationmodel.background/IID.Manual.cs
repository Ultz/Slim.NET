// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IBackgroundTaskCanceledEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0xBA,
                0xC4,
                0xA6,
                0xF8,
                0x51,
                0x57,
                0x4C,
                0xAC,
                0x3F,
                0x15,
                0x6D,
                0xD1,
                0x68,
                0x0C,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskCompletedEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xE9,
                0x38,
                0x5B,
                0x86,
                0xA0,
                0xA7,
                0x46,
                0xA6,
                0x78,
                0x43,
                0x91,
                0x35,
                0x82,
                0x2B,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskProgressEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x68,
                0xE0,
                0x46,
                0x88,
                0x8A,
                0x99,
                0x4C,
                0x80,
                0x4C,
                0x76,
                0x89,
                0x7F,
                0x62,
                0x77,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActivitySensorTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x43,
                0xDD,
                0xD0,
                0x7B,
                0xE3,
                0x23,
                0x48,
                0xA5,
                0xFE,
                0x6B,
                0x31,
                0xDF,
                0xEF,
                0xDE,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActivitySensorTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x91,
                0x26,
                0xA7,
                0x37,
                0x38,
                0xF7,
                0x44,
                0x83,
                0x1B,
                0x01,
                0x32,
                0xCC,
                0x87,
                0x2B,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAlarmApplicationManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0xFA,
                0x03,
                0xCA,
                0xE6,
                0xCC,
                0xE2,
                0x4D,
                0xB0,
                0x9B,
                0x96,
                0x28,
                0xBD,
                0x33,
                0xBB,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xF4,
                0xD4,
                0x74,
                0x37,
                0x8D,
                0xEC,
                0x44,
                0x94,
                0x81,
                0x2A,
                0x0B,
                0x98,
                0x54,
                0xEB,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0x9F,
                0x0B,
                0x28,
                0xF4,
                0x22,
                0x18,
                0x46,
                0xA0,
                0x2E,
                0xE7,
                0xE4,
                0x11,
                0xEB,
                0x72,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppBroadcastTriggerProviderInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x35,
                0x19,
                0xF2,
                0xE8,
                0x9D,
                0x20,
                0x44,
                0x9C,
                0xE2,
                0x5E,
                0xFF,
                0x8F,
                0x17,
                0x37,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0x86,
                0x46,
                0x0B,
                0x74,
                0x95,
                0x2C,
                0x49,
                0x9E,
                0x93,
                0x1A,
                0x3A,
                0xE6,
                0x33,
                0x5F,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x6A,
                0xDC,
                0x97,
                0x19,
                0x22,
                0x9E,
                0x4A,
                0x9C,
                0x5E,
                0x41,
                0xD0,
                0x47,
                0xF7,
                0x6E,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStoreNotificationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x04,
                0xD4,
                0x64,
                0x01,
                0xC2,
                0xAD,
                0x42,
                0xAA,
                0x2A,
                0xE2,
                0x1B,
                0xA3,
                0x42,
                0x5B,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundCondition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0xA1,
                0x48,
                0xAE,
                0x51,
                0x89,
                0x0A,
                0x40,
                0x83,
                0x02,
                0x9C,
                0x9C,
                0x9A,
                0x2A,
                0x3A,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundExecutionManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xEA,
                0x26,
                0xE8,
                0xA9,
                0x66,
                0x41,
                0x4D,
                0x83,
                0xD4,
                0xB4,
                0xC1,
                0x8C,
                0x87,
                0xB8,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundExecutionManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x24,
                0x9B,
                0x46,
                0xBB,
                0x9B,
                0x18,
                0x4E,
                0x99,
                0x9A,
                0xFD,
                0x65,
                0x12,
                0x93,
                0x1B,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundExecutionManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0xD3,
                0xA5,
                0x98,
                0x25,
                0x5A,
                0x6C,
                0x5B,
                0x91,
                0x92,
                0xD7,
                0x7A,
                0x43,
                0xDF,
                0xED,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTask
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0xD5,
                0x13,
                0x7D,
                0x12,
                0xFD,
                0xCE,
                0x43,
                0x8C,
                0x22,
                0xEA,
                0x1F,
                0xF1,
                0x3C,
                0x06,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskBuilder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x55,
                0x51,
                0x03,
                0x64,
                0x3E,
                0x72,
                0x45,
                0xA9,
                0x3A,
                0x84,
                0x07,
                0x5A,
                0x37,
                0xC9,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskBuilder2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0xCF,
                0xE7,
                0x6A,
                0x4F,
                0x10,
                0x6D,
                0x40,
                0x8D,
                0xB6,
                0x84,
                0x4A,
                0x57,
                0x0F,
                0x42,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskBuilder3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x4F,
                0xC7,
                0x28,
                0xA9,
                0x8B,
                0x09,
                0x4C,
                0xA2,
                0x4F,
                0x19,
                0x68,
                0x3E,
                0x2C,
                0x92,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskBuilder4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0xE5,
                0x55,
                0x47,
                0xA2,
                0xCB,
                0x35,
                0x4E,
                0xBD,
                0x16,
                0xA6,
                0xDA,
                0x7F,
                0x1C,
                0x19,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskBuilder5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x03,
                0x71,
                0x07,
                0xF5,
                0x99,
                0xF4,
                0x4A,
                0xBC,
                0xAD,
                0x47,
                0x31,
                0xD0,
                0x33,
                0x0D,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x25,
                0x5D,
                0x56,
                0x09,
                0xF2,
                0xF4,
                0x48,
                0x99,
                0x67,
                0x2B,
                0x18,
                0x4F,
                0x7B,
                0xFB,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x15,
                0xCC,
                0x93,
                0x27,
                0xAF,
                0xD3,
                0x4D,
                0x84,
                0x6E,
                0x24,
                0xEE,
                0x40,
                0xCA,
                0xDD,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskInstance
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0xDA,
                0x5B,
                0x86,
                0xD8,
                0x21,
                0x73,
                0x45,
                0x8F,
                0x32,
                0x92,
                0x8A,
                0x1B,
                0x06,
                0x41,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskInstance2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x01,
                0x7D,
                0x4F,
                0x76,
                0x0C,
                0xB4,
                0x4F,
                0x89,
                0x6D,
                0x5D,
                0xE1,
                0x86,
                0x41,
                0x22,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskInstance4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0xF2,
                0x29,
                0x7F,
                0x04,
                0xAA,
                0x08,
                0x4B,
                0x97,
                0xB0,
                0x06,
                0xD8,
                0x74,
                0xCD,
                0xAB,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskProgressEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x68,
                0x14,
                0xFB,
                0x32,
                0x83,
                0x0A,
                0x4D,
                0x95,
                0x32,
                0x03,
                0xEA,
                0xE6,
                0x84,
                0xDA,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskRegistration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0x4C,
                0x65,
                0x10,
                0x6E,
                0xA2,
                0xBF,
                0x43,
                0x8C,
                0x12,
                0x1F,
                0xB4,
                0x0D,
                0xBF,
                0xBF,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskRegistration2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0xC7,
                0x38,
                0x61,
                0x86,
                0xBB,
                0x12,
                0x41,
                0xAF,
                0xC3,
                0x7F,
                0x93,
                0x9B,
                0x16,
                0x6E,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskRegistration3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x81,
                0x33,
                0xFE,
                0x23,
                0x94,
                0x8B,
                0x4D,
                0x83,
                0x0D,
                0xB1,
                0xDD,
                0x2C,
                0x7B,
                0xAD,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskRegistrationGroup
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x91,
                0xB1,
                0x2A,
                0x1B,
                0x87,
                0x67,
                0x41,
                0x8A,
                0x76,
                0x05,
                0x5C,
                0xD6,
                0x7B,
                0x5B,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskRegistrationGroupFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0x2B,
                0xD9,
                0x83,
                0xCF,
                0x44,
                0x31,
                0x46,
                0x97,
                0x40,
                0x03,
                0xC7,
                0xD8,
                0x74,
                0x1B,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskRegistrationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0x2F,
                0x54,
                0x4C,
                0x00,
                0xB0,
                0xBA,
                0x42,
                0xA0,
                0x93,
                0x6A,
                0x56,
                0x3C,
                0x65,
                0xE3,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTaskRegistrationStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x67,
                0x4B,
                0x17,
                0x0D,
                0xB2,
                0xA9,
                0x4F,
                0xAD,
                0x9A,
                0xE9,
                0x3A,
                0xD6,
                0xC7,
                0x1E,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xA0,
                0xB3,
                0x84,
                0x27,
                0x60,
                0x87,
                0x4B,
                0x97,
                0x90,
                0xBD,
                0xF3,
                0xF7,
                0x57,
                0xDB,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundWorkCostStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0xA6,
                0x40,
                0xC7,
                0x10,
                0xC3,
                0x82,
                0x4B,
                0xB3,
                0xE3,
                0x3B,
                0xCF,
                0xB9,
                0xE4,
                0xC7,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementPublisherTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x26,
                0x3E,
                0xAB,
                0xD3,
                0x25,
                0xAE,
                0x48,
                0x87,
                0x24,
                0xD8,
                0x18,
                0x77,
                0xAE,
                0x61,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementPublisherTrigger2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0xD0,
                0x28,
                0xAA,
                0xF4,
                0x38,
                0x7D,
                0x59,
                0xB5,
                0x97,
                0x4E,
                0x55,
                0x58,
                0x8C,
                0x65,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementWatcherTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x18,
                0xAB,
                0x1A,
                0xE1,
                0xBC,
                0xEB,
                0x48,
                0xA8,
                0x27,
                0x59,
                0xFB,
                0x7C,
                0xEE,
                0x52,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBluetoothLEAdvertisementWatcherTrigger2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x67,
                0xB5,
                0x39,
                0x39,
                0xEB,
                0xB6,
                0x5A,
                0x99,
                0x32,
                0xAA,
                0x9E,
                0x45,
                0x49,
                0x60,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICachedFileUpdaterTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0xAE,
                0x1C,
                0xE2,
                0xF2,
                0x32,
                0x31,
                0x4D,
                0xB5,
                0x53,
                0xB9,
                0xE0,
                0x1B,
                0xDE,
                0x37,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICachedFileUpdaterTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x8C,
                0x83,
                0x71,
                0x14,
                0x13,
                0xB4,
                0x47,
                0x95,
                0x97,
                0xDC,
                0x7E,
                0x24,
                0x8C,
                0x17,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IChatMessageNotificationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x43,
                0x3B,
                0x51,
                0x40,
                0x1D,
                0x5D,
                0x5C,
                0x78,
                0xF5,
                0xC9,
                0x23,
                0xFE,
                0xE3,
                0x73,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IChatMessageReceivedNotificationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x76,
                0xA3,
                0x3E,
                0xF5,
                0xBA,
                0x77,
                0x40,
                0x88,
                0xE9,
                0x06,
                0x0C,
                0xF6,
                0xF0,
                0xC6,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICommunicationBlockingAppSetAsActiveTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0xF2,
                0x91,
                0xFB,
                0xA5,
                0x16,
                0x6D,
                0x48,
                0x97,
                0x4C,
                0x78,
                0x35,
                0xA8,
                0x47,
                0x7B,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactStoreNotificationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x41,
                0x33,
                0xC8,
                0x05,
                0x47,
                0x71,
                0x45,
                0x9A,
                0x16,
                0x06,
                0xB9,
                0x97,
                0xBF,
                0x9C,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContentPrefetchTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x27,
                0x06,
                0x71,
                0xFA,
                0x04,
                0x0B,
                0x44,
                0x80,
                0xC0,
                0x17,
                0x32,
                0x02,
                0x19,
                0x9E,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContentPrefetchTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x3E,
                0x64,
                0xC2,
                0x03,
                0x8A,
                0x9E,
                0x40,
                0xB8,
                0xC4,
                0x88,
                0x81,
                0x4C,
                0x28,
                0xCC,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICustomSystemEventTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0x67,
                0x59,
                0xF3,
                0x6B,
                0xCF,
                0xF4,
                0x4E,
                0xA0,
                0xCA,
                0x29,
                0xCF,
                0x4A,
                0x27,
                0x8C,
                0x87,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICustomSystemEventTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0x16,
                0xCB,
                0x6B,
                0xDC,
                0xF2,
                0xB2,
                0x41,
                0x9E,
                0xFD,
                0xB9,
                0x6B,
                0xDC,
                0xD1,
                0x3C,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceConnectionChangeTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x5E,
                0x87,
                0x90,
                0xDD,
                0x3C,
                0xFB,
                0x4E,
                0xAB,
                0x1C,
                0x5B,
                0x3B,
                0x6A,
                0x60,
                0xCE,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceConnectionChangeTriggerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x24,
                0xEA,
                0xC3,
                0xFD,
                0x4E,
                0x98,
                0x44,
                0xAA,
                0x60,
                0xA4,
                0xE4,
                0xE3,
                0xB1,
                0x7A,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceManufacturerNotificationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x8A,
                0x27,
                0x81,
                0xAB,
                0x41,
                0xDA,
                0x16,
                0x86,
                0xC2,
                0x7F,
                0x7B,
                0xF0,
                0x91,
                0x2F,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceManufacturerNotificationTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xDE,
                0x55,
                0x79,
                0xBB,
                0x25,
                0x53,
                0x41,
                0xA1,
                0xA2,
                0x30,
                0x29,
                0xFC,
                0xAB,
                0xB6,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceServicingTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x17,
                0xB2,
                0x1A,
                0x34,
                0x6E,
                0xD3,
                0x49,
                0x9E,
                0x6F,
                0x17,
                0xF1,
                0xB6,
                0xDF,
                0xA8,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceUseTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x80,
                0xA6,
                0x0D,
                0x4F,
                0x33,
                0x57,
                0x4D,
                0xB6,
                0xEC,
                0x6D,
                0xCA,
                0x64,
                0xB4,
                0x12,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceWatcherTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x7F,
                0x61,
                0xA4,
                0x73,
                0x85,
                0x60,
                0x42,
                0xBE,
                0xFC,
                0x5B,
                0xEC,
                0x89,
                0xCB,
                0x69,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailStoreNotificationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x06,
                0x6D,
                0x98,
                0xEB,
                0x47,
                0x68,
                0x42,
                0xA4,
                0xF2,
                0xF3,
                0xF7,
                0x71,
                0x88,
                0x38,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristicNotificationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x8F,
                0x5F,
                0xE2,
                0x96,
                0x06,
                0x4F,
                0x47,
                0xA7,
                0x32,
                0xF2,
                0x92,
                0xB0,
                0xCE,
                0xBC,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristicNotificationTrigger2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0xA2,
                0x22,
                0x93,
                0x0E,
                0xAE,
                0xF2,
                0x42,
                0xB2,
                0x8C,
                0xF5,
                0x13,
                0x72,
                0xE6,
                0x92,
                0x45,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristicNotificationTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x19,
                0xBA,
                0x57,
                0x43,
                0xB1,
                0x75,
                0x45,
                0x9F,
                0x6B,
                0xFD,
                0x59,
                0xD9,
                0x3A,
                0xCE,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattCharacteristicNotificationTriggerFactory2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0xE9,
                0x98,
                0x59,
                0x53,
                0x8A,
                0x9F,
                0x4E,
                0xA3,
                0x2C,
                0x23,
                0xCD,
                0x33,
                0x66,
                0x4C,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0xA3,
                0xC6,
                0xDD,
                0x57,
                0x15,
                0xD8,
                0x4B,
                0x85,
                0x42,
                0x46,
                0x8A,
                0xA0,
                0xC6,
                0x96,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderTriggerResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x91,
                0x46,
                0x3C,
                0x98,
                0xB1,
                0x84,
                0x4E,
                0xBA,
                0xD4,
                0xCF,
                0x4A,
                0xD2,
                0x99,
                0xED,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGattServiceProviderTriggerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xA3,
                0x13,
                0xB4,
                0x94,
                0xE2,
                0x91,
                0x45,
                0xA5,
                0xA6,
                0x64,
                0x89,
                0x1A,
                0x82,
                0x81,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IGeovisitTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0xED,
                0x18,
                0x48,
                0xE1,
                0x04,
                0x27,
                0x41,
                0x9A,
                0x4C,
                0x19,
                0x35,
                0x1B,
                0x8A,
                0x80,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILocationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x6A,
                0x66,
                0x47,
                0x77,
                0x68,
                0x1E,
                0x48,
                0x80,
                0x26,
                0xFF,
                0x7E,
                0x14,
                0xA8,
                0x11,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILocationTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0xBB,
                0x06,
                0x11,
                0x69,
                0xFF,
                0x09,
                0x4E,
                0xAA,
                0x8B,
                0x13,
                0x84,
                0xEA,
                0x47,
                0x5E,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMaintenanceTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x4C,
                0x18,
                0x68,
                0x22,
                0xFC,
                0xE5,
                0x4C,
                0x84,
                0x1A,
                0x72,
                0x39,
                0xA9,
                0x81,
                0x00,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMaintenanceTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0xDB,
                0x3D,
                0x4B,
                0xDD,
                0x97,
                0x29,
                0x46,
                0x88,
                0xB0,
                0xB0,
                0x6C,
                0xF9,
                0x48,
                0x2A,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaProcessingTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xBE,
                0x95,
                0x9A,
                0x52,
                0x8A,
                0x30,
                0x4B,
                0x90,
                0x11,
                0xCF,
                0x38,
                0x04,
                0x0E,
                0xA8,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkOperatorHotspotAuthenticationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0xC7,
                0x56,
                0xE7,
                0x01,
                0x30,
                0xE5,
                0x4D,
                0x83,
                0xC7,
                0xDE,
                0x61,
                0xD8,
                0x88,
                0x31,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkOperatorNotificationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x9C,
                0x08,
                0x90,
                0xCD,
                0x63,
                0x0C,
                0x48,
                0x95,
                0xD1,
                0x6E,
                0x6A,
                0xEF,
                0x80,
                0x1E,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INetworkOperatorNotificationTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x3E,
                0x22,
                0x0A,
                0xD7,
                0x27,
                0x53,
                0x43,
                0xAD,
                0xB9,
                0x92,
                0x65,
                0xAA,
                0xEA,
                0x57,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xE9,
                0xCF,
                0x8D,
                0xC5,
                0xD4,
                0xF1,
                0x49,
                0xB7,
                0xD3,
                0x82,
                0xE8,
                0x7A,
                0x0E,
                0x9D,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x3C,
                0xD9,
                0xA0,
                0xC1,
                0x5F,
                0xFB,
                0x48,
                0xA5,
                0x46,
                0x32,
                0x26,
                0x20,
                0x40,
                0x15,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPushNotificationTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0xED,
                0xD8,
                0x6D,
                0x8E,
                0x45,
                0xC2,
                0x4F,
                0xBC,
                0x2E,
                0xD5,
                0x66,
                0x4F,
                0x77,
                0xED,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRcsEndUserMessageAvailableTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x0D,
                0x6D,
                0x98,
                0xF6,
                0xB2,
                0x7F,
                0x46,
                0xA9,
                0x78,
                0xA4,
                0x40,
                0x91,
                0xC1,
                0x1A,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRfcommConnectionTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0xCA,
                0xC4,
                0xE8,
                0x53,
                0x0B,
                0x64,
                0x44,
                0x93,
                0x94,
                0xFD,
                0x87,
                0x56,
                0x54,
                0xDE,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISecondaryAuthenticationFactorAuthenticationTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xF3,
                0x37,
                0xF2,
                0x81,
                0x51,
                0x24,
                0x4F,
                0x96,
                0xA7,
                0x70,
                0x0A,
                0x4E,
                0x5F,
                0xAC,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISensorDataThresholdTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0xF3,
                0xC0,
                0x5B,
                0x8B,
                0xD4,
                0x7F,
                0x4B,
                0xAB,
                0xEC,
                0x15,
                0xF9,
                0xBA,
                0xCC,
                0x12,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISensorDataThresholdTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xE6,
                0x1F,
                0x92,
                0xF0,
                0x7D,
                0xA3,
                0x4D,
                0x97,
                0xB3,
                0xE5,
                0x44,
                0xEE,
                0x85,
                0x7F,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0xC5,
                0x3B,
                0xF5,
                0xCA,
                0x84,
                0x72,
                0x49,
                0x8C,
                0xE9,
                0xE5,
                0x8F,
                0x97,
                0xB3,
                0x7A,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmartCardTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x54,
                0xBF,
                0x63,
                0xC1,
                0x89,
                0x00,
                0x4E,
                0xA9,
                0xD3,
                0x97,
                0xC6,
                0x29,
                0x26,
                0x9D,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISmsMessageReceivedTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0xD8,
                0x3A,
                0xEA,
                0xA4,
                0x6B,
                0xB2,
                0x4A,
                0x8D,
                0x21,
                0xBC,
                0x6B,
                0x09,
                0xC7,
                0x75,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISocketActivityTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xF8,
                0xBB,
                0xA9,
                0xDE,
                0x9D,
                0x8A,
                0x4F,
                0x83,
                0xE3,
                0xB0,
                0xE0,
                0xE7,
                0xA5,
                0x0D,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryChangeTrackerTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xFF,
                0xB0,
                0x1E,
                0x85,
                0x5A,
                0x9E,
                0x49,
                0xA8,
                0x88,
                0x82,
                0x46,
                0x07,
                0x12,
                0x4F,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryContentChangedTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0xE0,
                0x37,
                0x16,
                0x9C,
                0x82,
                0xBC,
                0x45,
                0x92,
                0x9B,
                0xA1,
                0xE7,
                0xEA,
                0x78,
                0xD8,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStorageLibraryContentChangedTriggerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x1B,
                0x9F,
                0x7F,
                0x90,
                0x5F,
                0x12,
                0x4E,
                0x91,
                0x4E,
                0xA7,
                0xD8,
                0xE0,
                0xBB,
                0xFB,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemCondition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0xB4,
                0x5F,
                0xC1,
                0xC5,
                0x89,
                0x0B,
                0x42,
                0xAB,
                0xD3,
                0xFB,
                0x30,
                0x30,
                0x47,
                0x21,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemConditionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0xD1,
                0x69,
                0xD2,
                0xA7,
                0x05,
                0xAE,
                0x49,
                0x87,
                0xD7,
                0x16,
                0xB2,
                0xB8,
                0xB9,
                0xA5,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0xC7,
                0x80,
                0x1D,
                0x48,
                0x37,
                0x63,
                0x44,
                0x8D,
                0x7E,
                0x27,
                0x6D,
                0xC1,
                0x39,
                0xAC,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x23,
                0x04,
                0xE8,
                0x91,
                0x87,
                0x79,
                0x45,
                0x81,
                0x26,
                0x87,
                0xEC,
                0x8A,
                0xAA,
                0x40,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimeTrigger
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0x55,
                0x6E,
                0x65,
                0x2A,
                0x0B,
                0x77,
                0x43,
                0xBA,
                0x70,
                0x3B,
                0x45,
                0xA9,
                0x35,
                0x54,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimeTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x82,
                0xC6,
                0x38,
                0x54,
                0x9B,
                0xE6,
                0x45,
                0xB2,
                0xF3,
                0x26,
                0x9B,
                0x87,
                0xA6,
                0xF7,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationActionTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xFC,
                0x9D,
                0xB0,
                0x80,
                0x64,
                0x49,
                0x43,
                0x81,
                0x25,
                0x97,
                0xB3,
                0xEF,
                0xAA,
                0x0A,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationHistoryChangedTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0xFA,
                0xC6,
                0x81,
                0x97,
                0x87,
                0x85,
                0x47,
                0x81,
                0xB4,
                0xB0,
                0xCC,
                0xCB,
                0x73,
                0xD1,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserNotificationChangedTriggerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x43,
                0xD4,
                0xCA,
                0xAB,
                0x69,
                0x18,
                0x4E,
                0xA4,
                0x8A,
                0x5E,
                0xD2,
                0xAC,
                0x43,
                0x59,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
