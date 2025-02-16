// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAppointment
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x2F,
                0x00,
                0xDD,
                0xDD,
                0x2B,
                0x76,
                0x40,
                0x90,
                0xA3,
                0x22,
                0xC2,
                0x75,
                0x31,
                0x29,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointment2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x98,
                0x85,
                0x5E,
                0x0F,
                0x54,
                0x52,
                0x34,
                0x9B,
                0x5C,
                0x0D,
                0xD7,
                0xAD,
                0x4C,
                0x65,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointment3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x45,
                0xCC,
                0xBF,
                0x61,
                0x89,
                0x91,
                0x49,
                0x93,
                0x4B,
                0xC4,
                0x87,
                0x68,
                0xE5,
                0xA9,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentCalendar
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x81,
                0x73,
                0x52,
                0x39,
                0x83,
                0x4F,
                0x3D,
                0xA0,
                0x2F,
                0x64,
                0x08,
                0x44,
                0x52,
                0xBB,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentCalendar2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0xE4,
                0xE7,
                0x18,
                0x67,
                0x24,
                0x1C,
                0x4E,
                0xA4,
                0x59,
                0xD8,
                0xA2,
                0x93,
                0x03,
                0xD0,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentCalendar3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0xD2,
                0x23,
                0xEB,
                0x85,
                0xA6,
                0xAE,
                0x42,
                0x84,
                0x95,
                0xB3,
                0x11,
                0x9A,
                0xDB,
                0x41,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentCalendarSyncManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0xB3,
                0x21,
                0x2B,
                0xFF,
                0x4A,
                0x92,
                0x43,
                0xBC,
                0x5F,
                0x56,
                0x45,
                0xFF,
                0xCF,
                0xFB,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentCalendarSyncManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x28,
                0x75,
                0x64,
                0x29,
                0x0D,
                0x7C,
                0x4C,
                0xAA,
                0xA7,
                0xBF,
                0x99,
                0x68,
                0x05,
                0x53,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentConflictResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0xF0,
                0xCD,
                0xD5,
                0x2F,
                0x2F,
                0x7D,
                0x3B,
                0xAF,
                0x0A,
                0xA7,
                0xE2,
                0x0F,
                0x3A,
                0x46,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentException
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x67,
                0x07,
                0xA2,
                0xF6,
                0x16,
                0xCE,
                0x4B,
                0x9F,
                0x5A,
                0x86,
                0x00,
                0xB8,
                0x01,
                0x9F,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentInvitee
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x07,
                0xBF,
                0x13,
                0x42,
                0x98,
                0x5B,
                0x49,
                0xB0,
                0xE7,
                0xEF,
                0x8F,
                0x79,
                0xC0,
                0x70,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentManagerForUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x14,
                0x26,
                0x70,
                0xCC,
                0x73,
                0x60,
                0x46,
                0xB3,
                0x18,
                0xB0,
                0x13,
                0x65,
                0x30,
                0x2A,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xFA,
                0x30,
                0x3A,
                0x40,
                0x5C,
                0x9D,
                0x49,
                0xB3,
                0x3F,
                0xA4,
                0x30,
                0x50,
                0xF7,
                0x4F,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xF6,
                0x81,
                0x0A,
                0x4F,
                0xD0,
                0x34,
                0x40,
                0xAF,
                0x72,
                0xA3,
                0x65,
                0x73,
                0xB4,
                0x5F,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0xE0,
                0x9A,
                0x2F,
                0x4C,
                0xB3,
                0xC7,
                0x4D,
                0xA3,
                0x5D,
                0xCA,
                0xFD,
                0x88,
                0xAE,
                0x3E,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentParticipant
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0x29,
                0x5E,
                0x61,
                0x18,
                0x97,
                0x7B,
                0x46,
                0x83,
                0xFB,
                0xB2,
                0x93,
                0xA1,
                0x91,
                0x21,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentPropertiesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0x1F,
                0x14,
                0x25,
                0xAE,
                0x68,
                0xAE,
                0x3A,
                0x85,
                0x5F,
                0xBC,
                0x44,
                0x41,
                0xCA,
                0xA2,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentPropertiesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x43,
                0xFC,
                0xDF,
                0x17,
                0xB0,
                0xDD,
                0x45,
                0x8A,
                0xF5,
                0xD1,
                0x63,
                0xD1,
                0x08,
                0x01,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentRecurrence
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x3E,
                0x7B,
                0xD8,
                0xA6,
                0x15,
                0x7B,
                0x48,
                0xB9,
                0x59,
                0x0C,
                0x36,
                0x1E,
                0x60,
                0xE9,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentRecurrence2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xA2,
                0xF3,
                0x3D,
                0xA7,
                0x05,
                0x50,
                0x4F,
                0x9F,
                0x86,
                0xB0,
                0x3F,
                0x94,
                0x36,
                0x25,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentRecurrence3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x96,
                0xFF,
                0x89,
                0x4D,
                0xDA,
                0x17,
                0x4A,
                0x8D,
                0xD2,
                0x1C,
                0xEB,
                0xC2,
                0xB5,
                0xFF,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x91,
                0x61,
                0xA4,
                0x47,
                0x7A,
                0x96,
                0x4D,
                0x96,
                0xC9,
                0x15,
                0xCD,
                0x8A,
                0x05,
                0xA7,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStore2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x8C,
                0xC4,
                0x25,
                0x41,
                0x1C,
                0x4F,
                0x42,
                0x80,
                0x84,
                0x67,
                0xC1,
                0xCF,
                0xE0,
                0xA8,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStore3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0x94,
                0x51,
                0x42,
                0x78,
                0xB0,
                0x0A,
                0x47,
                0x9A,
                0x40,
                0xC2,
                0xE0,
                0x17,
                0x61,
                0xF7,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStoreChange
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0xE0,
                0xA6,
                0xA5,
                0x33,
                0x0A,
                0x54,
                0x36,
                0x84,
                0x63,
                0xB5,
                0x43,
                0xE9,
                0x0C,
                0x3B,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStoreChange2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x0D,
                0x7D,
                0xB3,
                0x11,
                0x52,
                0x02,
                0x44,
                0xA6,
                0x08,
                0xA9,
                0x6F,
                0xE7,
                0x0B,
                0x8E,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStoreChangeReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x09,
                0x24,
                0x8B,
                0xF3,
                0x65,
                0xA0,
                0x42,
                0x96,
                0x1D,
                0x4C,
                0x20,
                0x9B,
                0xF3,
                0x03,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStoreChangeTracker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0xF4,
                0x25,
                0x1B,
                0xCE,
                0x8E,
                0x17,
                0x4F,
                0x93,
                0xC8,
                0xE6,
                0x41,
                0x24,
                0x58,
                0xFD,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStoreChangeTracker2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0xAF,
                0x6A,
                0xB6,
                0x42,
                0x95,
                0xF7,
                0x4C,
                0x85,
                0x50,
                0xEB,
                0x37,
                0x0E,
                0x0C,
                0x08,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStoreChangedDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x20,
                0xB8,
                0x4C,
                0xDB,
                0xFE,
                0xC3,
                0x4B,
                0x96,
                0x62,
                0x95,
                0xA9,
                0xBE,
                0xFD,
                0xF4,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStoreChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xF8,
                0x85,
                0x22,
                0x91,
                0x07,
                0x7E,
                0x41,
                0xBF,
                0xEA,
                0xCC,
                0x6D,
                0x41,
                0x63,
                0x6C,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentStoreNotificationTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0xCB,
                0x33,
                0x9B,
                0x01,
                0xC3,
                0x1E,
                0x42,
                0xAF,
                0xEF,
                0x04,
                0x7E,
                0xCF,
                0xA7,
                0x6A,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFindAppointmentsOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0xDC,
                0xF7,
                0x55,
                0x42,
                0x99,
                0x86,
                0x30,
                0x82,
                0xB5,
                0x2C,
                0xB2,
                0x9F,
                0x64,
                0xD5,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
