// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0x17,
                0x65,
                0xCF,
                0x08,
                0xCD,
                0xD8,
                0x4F,
                0xB6,
                0x97,
                0xA2,
                0x81,
                0xB6,
                0x54,
                0x4E,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActivatedEventArgsWithUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x9B,
                0xF0,
                0x1C,
                0x62,
                0x99,
                0x36,
                0x49,
                0x80,
                0xFF,
                0xAF,
                0xC8,
                0xE8,
                0xAE,
                0x5C,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0xEF,
                0x0C,
                0x93,
                0x29,
                0xB8,
                0xFC,
                0x40,
                0x88,
                0xF4,
                0x85,
                0x13,
                0xE8,
                0xA6,
                0x47,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentsProviderActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0xC4,
                0x64,
                0x33,
                0x3C,
                0x93,
                0x7D,
                0x4E,
                0xA0,
                0x34,
                0x50,
                0x0F,
                0xB8,
                0xDC,
                0xD9,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentsProviderAddAppointmentActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x13,
                0x86,
                0xA2,
                0xE5,
                0xCE,
                0x4D,
                0x4E,
                0x9E,
                0xD7,
                0x41,
                0xC3,
                0x4E,
                0xC1,
                0x8B,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentsProviderRemoveAppointmentActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x3A,
                0x1F,
                0x75,
                0x8E,
                0x0B,
                0x1C,
                0x45,
                0x9F,
                0x15,
                0x96,
                0x6E,
                0x69,
                0x9B,
                0xAC,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentsProviderReplaceAppointmentActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0xB7,
                0x51,
                0x15,
                0x81,
                0xA9,
                0x67,
                0x40,
                0x8A,
                0x62,
                0x05,
                0x24,
                0xE4,
                0xAD,
                0xE1,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentsProviderShowAppointmentDetailsActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xF0,
                0x58,
                0x39,
                0x41,
                0x98,
                0xA5,
                0x4C,
                0x99,
                0x9B,
                0x88,
                0x51,
                0x98,
                0xB9,
                0xEF,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppointmentsProviderShowTimeFrameActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0xAB,
                0xAE,
                0x9B,
                0x0B,
                0x0E,
                0xAA,
                0x49,
                0xBA,
                0xBC,
                0x12,
                0xB1,
                0xDC,
                0x77,
                0x49,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackgroundActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xBE,
                0x14,
                0xAB,
                0x60,
                0xE7,
                0x0E,
                0x44,
                0xA9,
                0x1C,
                0x44,
                0x79,
                0x6D,
                0xE3,
                0xA9,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBarcodeScannerPreviewActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x79,
                0x72,
                0x67,
                0xBF,
                0x99,
                0x49,
                0x43,
                0xAF,
                0x22,
                0xE4,
                0x12,
                0x35,
                0x60,
                0x37,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICachedFileUpdaterActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xB1,
                0x6E,
                0xD0,
                0x05,
                0x38,
                0xCB,
                0x4E,
                0xB7,
                0x57,
                0x6C,
                0xF1,
                0x5E,
                0x26,
                0xFE,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICameraSettingsActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xA5,
                0x67,
                0xFB,
                0xAD,
                0x2D,
                0x0A,
                0x49,
                0x91,
                0x70,
                0xDC,
                0xA0,
                0x36,
                0xEB,
                0x11,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICommandLineActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0x47,
                0x06,
                0x45,
                0x6A,
                0x00,
                0xEB,
                0x48,
                0x8A,
                0xFB,
                0xD0,
                0x7A,
                0xB2,
                0x5E,
                0x33,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICommandLineActivationOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x28,
                0x4B,
                0x99,
                0x9E,
                0xC5,
                0x69,
                0x4F,
                0xBC,
                0xFD,
                0xB6,
                0x1E,
                0xD4,
                0xE6,
                0x22,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0xA1,
                0x27,
                0xD6,
                0x25,
                0xC0,
                0x41,
                0x4C,
                0x9D,
                0xEF,
                0xF1,
                0xEA,
                0xFA,
                0xD0,
                0x75,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactCallActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x14,
                0xDF,
                0xC2,
                0xEB,
                0x30,
                0xC6,
                0x41,
                0xB3,
                0xBC,
                0x5B,
                0x16,
                0x94,
                0xF9,
                0xDA,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactMapActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0xF8,
                0x2B,
                0xB3,
                0xE7,
                0xEE,
                0xD2,
                0x4A,
                0xAA,
                0xF1,
                0xA8,
                0x7E,
                0xFF,
                0xCF,
                0x00,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactMessageActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x8D,
                0x59,
                0xDE,
                0x03,
                0x0E,
                0xB0,
                0x43,
                0xBF,
                0x56,
                0xBC,
                0xC4,
                0x0B,
                0x31,
                0x62,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPanelActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x63,
                0xBB,
                0x52,
                0xD4,
                0xD3,
                0x63,
                0x4B,
                0x80,
                0x51,
                0x4A,
                0xF2,
                0x08,
                0x2C,
                0xAB,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPickerActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0xAA,
                0x57,
                0xCE,
                0x49,
                0x64,
                0xA7,
                0x45,
                0x97,
                0x1F,
                0xD1,
                0x13,
                0xBE,
                0x7A,
                0x89,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPostActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x3C,
                0x5A,
                0xB3,
                0xE7,
                0xF1,
                0x55,
                0x46,
                0xAD,
                0x6E,
                0x48,
                0x57,
                0x58,
                0x8F,
                0x55,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactVideoCallActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x9D,
                0x07,
                0x61,
                0xE7,
                0xE3,
                0x4F,
                0x4B,
                0x85,
                0x8D,
                0x5C,
                0x63,
                0xA9,
                0x6E,
                0xF6,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactsProviderActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0xDC,
                0x80,
                0x45,
                0x50,
                0x57,
                0x16,
                0x49,
                0xAA,
                0x52,
                0xC0,
                0x82,
                0x95,
                0x21,
                0xEB,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContinuationActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x06,
                0x81,
                0xE5,
                0x5F,
                0x15,
                0x94,
                0x4A,
                0xA7,
                0x42,
                0xC7,
                0xE0,
                0x8F,
                0x4E,
                0x18,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDeviceActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0xB9,
                0x50,
                0xCD,
                0x10,
                0xCE,
                0xD2,
                0x44,
                0x82,
                0x34,
                0xC3,
                0x55,
                0xA0,
                0x73,
                0xEF,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDevicePairingActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0xD1,
                0xA0,
                0xEB,
                0xC6,
                0xEC,
                0x48,
                0x41,
                0x94,
                0xED,
                0xF4,
                0xB3,
                0x7E,
                0xC0,
                0x5B,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDialReceiverActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x7E,
                0x77,
                0xFB,
                0xEE,
                0x85,
                0x6E,
                0x45,
                0xA4,
                0x4D,
                0x85,
                0xD7,
                0x30,
                0xE7,
                0x0A,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0xFC,
                0x2A,
                0xBB,
                0xB1,
                0x93,
                0xED,
                0x42,
                0x8B,
                0x26,
                0x23,
                0x6D,
                0xD9,
                0xC7,
                0x84,
                0x96,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileActivatedEventArgsWithCallerPackageFamilyName
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0xF0,
                0x60,
                0x2D,
                0x5F,
                0xD2,
                0x25,
                0x4D,
                0x86,
                0x53,
                0xE1,
                0xC5,
                0xE1,
                0x10,
                0x83,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileActivatedEventArgsWithNeighboringFiles
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0xA1,
                0x3B,
                0x43,
                0xE2,
                0xE1,
                0xFD,
                0x48,
                0xB7,
                0xFC,
                0xB5,
                0xD6,
                0xEE,
                0xE6,
                0x50,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileOpenPickerActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x70,
                0x82,
                0x72,
                0x25,
                0x55,
                0xF2,
                0x4B,
                0xBC,
                0x09,
                0x1F,
                0x50,
                0x95,
                0xD4,
                0x96,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileOpenPickerActivatedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x1F,
                0x73,
                0x5E,
                0x1F,
                0x8D,
                0xFB,
                0x45,
                0xAF,
                0x1D,
                0x73,
                0x20,
                0x5C,
                0x8F,
                0xC7,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileOpenPickerContinuationEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x3F,
                0xFA,
                0xF0,
                0xE8,
                0xD4,
                0xD3,
                0x4A,
                0x9C,
                0x34,
                0x23,
                0x08,
                0xF3,
                0x2F,
                0xCE,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileSavePickerActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x9C,
                0xC1,
                0x81,
                0xE6,
                0x74,
                0x87,
                0x43,
                0x82,
                0xEB,
                0xBB,
                0x8F,
                0xD6,
                0x4B,
                0x43,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileSavePickerActivatedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x13,
                0xFE,
                0x73,
                0x6B,
                0xF2,
                0x2C,
                0x48,
                0x4D,
                0x8C,
                0xBC,
                0xAF,
                0x67,
                0xD2,
                0x3F,
                0x1C,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFileSavePickerContinuationEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x6F,
                0x84,
                0x2C,
                0xAD,
                0x3B,
                0x33,
                0x4F,
                0x8C,
                0x8B,
                0xE4,
                0x6F,
                0xAE,
                0x82,
                0x4B,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFolderPickerContinuationEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x23,
                0x88,
                0x51,
                0x4B,
                0x9F,
                0x8F,
                0x49,
                0xBE,
                0xB0,
                0x42,
                0x68,
                0x4F,
                0x6E,
                0x1C,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILaunchActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x3E,
                0xC9,
                0xFB,
                0x4A,
                0xA1,
                0x4F,
                0x4B,
                0x82,
                0xB0,
                0x33,
                0xBE,
                0xD9,
                0x20,
                0xAF,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILaunchActivatedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x7E,
                0xD3,
                0x0F,
                0xC9,
                0x9D,
                0xB5,
                0x46,
                0x9A,
                0xCE,
                0xBD,
                0x95,
                0xD4,
                0x56,
                0x53,
                0x45,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILockScreenActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x79,
                0xA7,
                0x3C,
                0x08,
                0x61,
                0x41,
                0x4A,
                0x82,
                0x20,
                0xEE,
                0x7D,
                0x13,
                0x3C,
                0x85,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILockScreenCallActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x7F,
                0xF3,
                0x06,
                0xF2,
                0xB5,
                0x8B,
                0x44,
                0xB1,
                0x3E,
                0xE3,
                0x28,
                0xAC,
                0x1C,
                0x51,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhoneCallActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x52,
                0x61,
                0x54,
                0xC1,
                0xA3,
                0xED,
                0x4C,
                0xB6,
                0x2F,
                0x8C,
                0x60,
                0x52,
                0x36,
                0x19,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPickerReturnedActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0xEF,
                0x0D,
                0x36,
                0xD3,
                0xA9,
                0x84,
                0x49,
                0xA4,
                0xED,
                0x9E,
                0xC7,
                0x34,
                0x60,
                0x49,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrelaunchActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x71,
                0x44,
                0x0C,
                0xF7,
                0x19,
                0xD6,
                0x48,
                0xB0,
                0x46,
                0xCF,
                0x22,
                0x82,
                0x6E,
                0xAA,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrint3DWorkflowActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xE7,
                0x57,
                0x3F,
                0xAC,
                0xF2,
                0x19,
                0x46,
                0x83,
                0x02,
                0xEF,
                0x85,
                0x5E,
                0x1C,
                0x9B,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPrintTaskSettingsActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0xA0,
                0x30,
                0xEE,
                0x56,
                0xCE,
                0x65,
                0x48,
                0xBA,
                0x8E,
                0x89,
                0x54,
                0xAC,
                0x27,
                0x11,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtocolActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0xF4,
                0x95,
                0x60,
                0xC0,
                0xB7,
                0xAB,
                0x46,
                0x81,
                0xFE,
                0xD9,
                0x0F,
                0x36,
                0xD0,
                0x0D,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x0C,
                0x4A,
                0xD8,
                0x8F,
                0x5C,
                0x8C,
                0x43,
                0x83,
                0xCB,
                0xC2,
                0x8F,
                0xCC,
                0x0B,
                0x2F,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtocolForResultsActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0x32,
                0x51,
                0xE7,
                0xE7,
                0x7A,
                0x17,
                0x45,
                0x80,
                0xAC,
                0xDB,
                0xE8,
                0xD7,
                0xCC,
                0x5B,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRestrictedLaunchActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xAC,
                0xB7,
                0xE0,
                0xC3,
                0xBF,
                0x44,
                0x43,
                0xA5,
                0xDA,
                0x19,
                0xFD,
                0x5A,
                0x27,
                0xBA,
                0xAE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x69,
                0xB3,
                0x8C,
                0xC8,
                0x58,
                0xE3,
                0x43,
                0x94,
                0xBC,
                0x41,
                0xD3,
                0x3F,
                0x8B,
                0x63,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISearchActivatedEventArgsWithLinguisticDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x33,
                0x9F,
                0xC0,
                0xAB,
                0x08,
                0x31,
                0x49,
                0x9B,
                0x7C,
                0x45,
                0x10,
                0x25,
                0xF2,
                0x1F,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShareTargetActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0xF9,
                0xDA,
                0x4B,
                0xB2,
                0xCD,
                0xCB,
                0x4A,
                0xBF,
                0xC3,
                0x66,
                0x48,
                0x56,
                0x33,
                0x78,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISplashScreen
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x97,
                0x4D,
                0xCA,
                0xD6,
                0xD4,
                0xF0,
                0x43,
                0x97,
                0xC0,
                0x08,
                0x33,
                0xC6,
                0x39,
                0x1C,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStartupTaskActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x1A,
                0xB1,
                0x03,
                0x76,
                0x52,
                0x91,
                0x4D,
                0x86,
                0x21,
                0x54,
                0x61,
                0x18,
                0x64,
                0xD5,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileActivatedInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0xA3,
                0xE4,
                0x80,
                0x80,
                0x39,
                0x17,
                0x4F,
                0xB7,
                0x38,
                0x89,
                0x19,
                0x4E,
                0x0B,
                0x8F,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x6F,
                0xA8,
                0x92,
                0x90,
                0x52,
                0x1D,
                0x43,
                0xBE,
                0x85,
                0xC4,
                0xAA,
                0xEE,
                0xB8,
                0x68,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDataAccountProviderActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0xF7,
                0xC9,
                0x1B,
                0xF1,
                0x8E,
                0x51,
                0x4A,
                0xA6,
                0x3A,
                0xFE,
                0x71,
                0x1E,
                0xEA,
                0xB6,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IViewSwitcherProvider
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x88,
                0xF2,
                0x33,
                0x2C,
                0x5C,
                0x27,
                0x4D,
                0xBA,
                0xC7,
                0x75,
                0x36,
                0x08,
                0x8F,
                0x12,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoiceCommandActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0xDC,
                0x92,
                0xAB,
                0x43,
                0x8D,
                0xE6,
                0x4D,
                0x97,
                0x75,
                0x20,
                0x70,
                0x4B,
                0x58,
                0x1B,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWalletActionActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x02,
                0xFC,
                0xFC,
                0x1A,
                0x1A,
                0x22,
                0x4D,
                0x92,
                0x3F,
                0xAE,
                0x6F,
                0x45,
                0xFA,
                0x52,
                0xD9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAccountProviderActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x17,
                0xB7,
                0x72,
                0xEA,
                0x98,
                0xCF,
                0x4C,
                0x97,
                0x52,
                0x46,
                0xD9,
                0x05,
                0x10,
                0x04,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWebAuthenticationBrokerContinuationEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0xA3,
                0xDD,
                0x75,
                0x14,
                0x77,
                0x3D,
                0x45,
                0xB7,
                0xFF,
                0xB9,
                0x5E,
                0x3A,
                0x17,
                0x09,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
