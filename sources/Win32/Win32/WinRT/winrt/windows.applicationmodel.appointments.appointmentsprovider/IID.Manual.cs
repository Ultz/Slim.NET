// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appointments.appointmentsprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAddAppointmentOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x9A,
                0x4A,
                0xEC,
                0x0D,
                0x62,
                0x69,
                0x4C,
                0xAD,
                0xD7,
                0x97,
                0x94,
                0xE9,
                0x18,
                0x08,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentsProviderLaunchActionVerbsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0xBA,
                0xDB,
                0x36,
                0x2E,
                0x9E,
                0xC6,
                0x49,
                0x8E,
                0xF7,
                0x3A,
                0xB7,
                0xA5,
                0xDC,
                0xC8,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentsProviderLaunchActionVerbsStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x49,
                0x90,
                0xEF,
                0x21,
                0xAF,
                0x3C,
                0x47,
                0x88,
                0xDC,
                0x76,
                0xCD,
                0x89,
                0xF6,
                0x0C,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoveAppointmentOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0x6A,
                0xB6,
                0x08,
                0x33,
                0xFE,
                0xCD,
                0x46,
                0xA5,
                0x0C,
                0xA8,
                0xFF,
                0xB3,
                0x26,
                0x05,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IReplaceAppointmentOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x3D,
                0x90,
                0xF4,
                0x61,
                0x9E,
                0xE2,
                0x4D,
                0xA7,
                0x32,
                0x26,
                0x87,
                0xC0,
                0x7D,
                0x1D,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
