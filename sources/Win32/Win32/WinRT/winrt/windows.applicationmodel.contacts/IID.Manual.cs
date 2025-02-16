// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAggregateContactManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0xD5,
                0x79,
                0x03,
                0x5A,
                0xDB,
                0xD3,
                0x4F,
                0xB5,
                0x4E,
                0x4D,
                0xF1,
                0x79,
                0x17,
                0xA2,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAggregateContactManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0xC2,
                0x8C,
                0x5E,
                0xCD,
                0xA9,
                0x30,
                0x44,
                0x9C,
                0x4B,
                0x01,
                0x34,
                0x8D,
                0xB2,
                0xCA,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_WinRT_IContact
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x72,
                0x00,
                0xEC,
                0x18,
                0x21,
                0x49,
                0x40,
                0x9E,
                0xBC,
                0x17,
                0xF0,
                0xAB,
                0x69,
                0x2B,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContact2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xF3,
                0x12,
                0xF3,
                0x77,
                0xBB,
                0x94,
                0x4C,
                0x80,
                0x2D,
                0x83,
                0x28,
                0xCE,
                0xE4,
                0x0C,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContact3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x1E,
                0x20,
                0x48,
                0x8E,
                0xE0,
                0xA4,
                0x42,
                0xB5,
                0x61,
                0x41,
                0xD0,
                0x8C,
                0xA9,
                0x57,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactAddress
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0xD3,
                0x39,
                0x97,
                0xCE,
                0x42,
                0x72,
                0x48,
                0x8D,
                0x70,
                0x30,
                0x63,
                0xAA,
                0x58,
                0x4B,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactAnnotation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0xC2,
                0x1F,
                0x82,
                0x41,
                0x7D,
                0xA2,
                0x44,
                0x84,
                0xC3,
                0x60,
                0xA2,
                0x81,
                0xDD,
                0x7B,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactAnnotation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0xEC,
                0x91,
                0xB6,
                0xB7,
                0x4A,
                0x1F,
                0x4A,
                0x99,
                0x41,
                0x0C,
                0x9C,
                0xF3,
                0x17,
                0x1B,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactAnnotationList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x86,
                0xA4,
                0x92,
                0x88,
                0x5C,
                0xB9,
                0x45,
                0xAA,
                0xD0,
                0x46,
                0x18,
                0x88,
                0xE6,
                0x8D,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactAnnotationStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0xF4,
                0xAC,
                0x23,
                0x77,
                0x7A,
                0x7D,
                0x45,
                0x82,
                0x03,
                0x98,
                0x7F,
                0x4B,
                0x31,
                0xAF,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactAnnotationStore2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x23,
                0xDE,
                0x7E,
                0xE7,
                0x61,
                0x67,
                0x49,
                0x8E,
                0xC5,
                0xBD,
                0xF2,
                0x80,
                0xA2,
                0x40,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactBatch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x97,
                0xD1,
                0x35,
                0xCE,
                0xBF,
                0xBB,
                0x46,
                0x93,
                0xF8,
                0xA5,
                0xB0,
                0x6E,
                0xC5,
                0xE2,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactCardDelayedDataLoader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xF9,
                0x0A,
                0xB6,
                0x46,
                0x15,
                0x4D,
                0x43,
                0x86,
                0x9C,
                0x6E,
                0x35,
                0x20,
                0x76,
                0x0E,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactCardOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x4F,
                0x0A,
                0x8C,
                0xB6,
                0x6A,
                0x3F,
                0x4F,
                0xBE,
                0x72,
                0x81,
                0x72,
                0x36,
                0xEE,
                0xEA,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactCardOptions2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x1B,
                0x27,
                0x8F,
                0x4B,
                0xD7,
                0xC6,
                0x4C,
                0x9F,
                0x53,
                0x1B,
                0x0E,
                0xB5,
                0xD1,
                0x27,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactChange
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x4B,
                0x1D,
                0x95,
                0x59,
                0x6A,
                0x20,
                0x47,
                0xA4,
                0xE1,
                0x36,
                0x3D,
                0x98,
                0xC1,
                0x35,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactChangeReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x19,
                0x73,
                0x21,
                0x0C,
                0x2D,
                0xE0,
                0x42,
                0xA9,
                0xDA,
                0x3E,
                0xCD,
                0x56,
                0xA7,
                0x8A,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactChangeTracker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x29,
                0x99,
                0x6E,
                0x9B,
                0x30,
                0x4D,
                0x40,
                0x97,
                0x12,
                0xB3,
                0x7B,
                0xD3,
                0x02,
                0x78,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactChangeTracker2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xD0,
                0x8A,
                0x7F,
                0x21,
                0x93,
                0x18,
                0x4D,
                0x9C,
                0x09,
                0xD7,
                0x08,
                0xC6,
                0x3F,
                0xCD,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactChangedDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x3A,
                0x14,
                0xC5,
                0x03,
                0x1B,
                0xF8,
                0x46,
                0xB6,
                0x94,
                0xA5,
                0x23,
                0xE8,
                0x3C,
                0xFC,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x7F,
                0x5E,
                0x52,
                0xF3,
                0x73,
                0x7D,
                0x4B,
                0xA9,
                0x18,
                0x58,
                0x0B,
                0xE4,
                0x36,
                0x61,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactConnectedServiceAccount
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x35,
                0xF8,
                0xF6,
                0x27,
                0xAA,
                0x31,
                0x47,
                0x8E,
                0x4A,
                0x3D,
                0xEC,
                0x5C,
                0xE9,
                0xEE,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactDate
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0xAE,
                0x98,
                0xFE,
                0x05,
                0xB2,
                0x34,
                0x49,
                0x91,
                0x74,
                0x0F,
                0xF2,
                0xB0,
                0x56,
                0x57,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactEmail
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x19,
                0xA2,
                0x90,
                0xD3,
                0xE3,
                0x63,
                0x4D,
                0x99,
                0x3B,
                0x05,
                0xB9,
                0xA5,
                0x39,
                0x3A,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactField
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x48,
                0x76,
                0xB1,
                0x93,
                0xD2,
                0x2C,
                0x49,
                0xA0,
                0x58,
                0xDB,
                0x57,
                0x5B,
                0x3E,
                0x3C,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactFieldFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0x91,
                0xE2,
                0x85,
                0x4A,
                0x0E,
                0x3E,
                0x4A,
                0x89,
                0x94,
                0x40,
                0x6A,
                0xE7,
                0xED,
                0x64,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactGroup
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xEB,
                0xBD,
                0x59,
                0x9A,
                0x9E,
                0x5D,
                0x47,
                0xBF,
                0xE5,
                0xA3,
                0x7B,
                0x80,
                0x6D,
                0x85,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactInformation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0xB6,
                0x5E,
                0x27,
                0x2E,
                0x6A,
                0x78,
                0x42,
                0xA9,
                0x14,
                0xE4,
                0x60,
                0xD5,
                0xF0,
                0x88,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactInstantMessageField
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x3B,
                0xE3,
                0xCC,
                0x85,
                0x0D,
                0xFA,
                0x41,
                0xB4,
                0x3D,
                0xDA,
                0x59,
                0x9C,
                0x3E,
                0xB0,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactInstantMessageFieldFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x67,
                0x0B,
                0xBA,
                0xA3,
                0x91,
                0xB2,
                0x4B,
                0xB1,
                0xB9,
                0x69,
                0xA5,
                0xDF,
                0xF0,
                0xBA,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactJobInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x7B,
                0x11,
                0x6D,
                0x50,
                0xCE,
                0x43,
                0x4B,
                0x9E,
                0x69,
                0xB1,
                0x82,
                0x58,
                0xEA,
                0x53,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactLaunchActionVerbsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x32,
                0x12,
                0xFB,
                0x73,
                0xEE,
                0xE7,
                0x46,
                0x87,
                0x61,
                0x11,
                0xCD,
                0x01,
                0x57,
                0x72,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactList
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xEC,
                0xDD,
                0x16,
                0x2C,
                0x39,
                0x45,
                0x48,
                0x9D,
                0xFB,
                0x51,
                0xA3,
                0xE7,
                0xEF,
                0x3E,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactList2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x43,
                0x39,
                0xCB,
                0x50,
                0x45,
                0xCB,
                0x4D,
                0x92,
                0x29,
                0x40,
                0xFF,
                0x91,
                0xFB,
                0x02,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactList3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xEE,
                0x78,
                0x15,
                0xFC,
                0x26,
                0xE8,
                0x41,
                0xA8,
                0x50,
                0x5A,
                0xA3,
                0x25,
                0x14,
                0xAC,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactListLimitedWriteOperations
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x13,
                0x98,
                0xE1,
                0x0B,
                0x4A,
                0xB8,
                0x44,
                0x9A,
                0x1F,
                0xA0,
                0xF3,
                0xD2,
                0x18,
                0x17,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactListSyncConstraints
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0xBF,
                0xB0,
                0xB2,
                0x62,
                0x30,
                0x2E,
                0x4E,
                0x96,
                0x9D,
                0x01,
                0x8D,
                0x19,
                0x87,
                0xF3,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactListSyncManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x83,
                0x6E,
                0x14,
                0x25,
                0x79,
                0xCC,
                0x4A,
                0x9D,
                0xE5,
                0x21,
                0xDD,
                0xD0,
                0x6F,
                0x86,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactListSyncManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x12,
                0x59,
                0xA9,
                0x55,
                0xBB,
                0x23,
                0x4E,
                0x81,
                0x28,
                0x37,
                0x01,
                0x34,
                0xA8,
                0x5D,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactLocationField
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x0F,
                0xC0,
                0x9E,
                0x6E,
                0xAB,
                0x36,
                0x4B,
                0x89,
                0xE3,
                0xB2,
                0x3B,
                0xC0,
                0xA1,
                0xDA,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactLocationFieldFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x32,
                0x99,
                0xF7,
                0xDF,
                0x2F,
                0xFE,
                0x43,
                0x8F,
                0x18,
                0x41,
                0x89,
                0x73,
                0x90,
                0xBC,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactManagerForUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0xBA,
                0x4B,
                0xB7,
                0x76,
                0x10,
                0xEF,
                0x4B,
                0xAE,
                0xF3,
                0x54,
                0x68,
                0x6D,
                0x18,
                0x38,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactManagerForUser2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x9C,
                0x46,
                0x4D,
                0x75,
                0x3B,
                0x73,
                0x4A,
                0xBB,
                0x30,
                0x73,
                0x66,
                0x45,
                0x47,
                0x22,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x1A,
                0xF2,
                0x81,
                0x61,
                0xF6,
                0x08,
                0x47,
                0xBA,
                0x4F,
                0xD3,
                0x86,
                0xBD,
                0x0D,
                0x62,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0xE6,
                0x78,
                0xA1,
                0xD8,
                0x47,
                0xCC,
                0x48,
                0x96,
                0x3C,
                0x95,
                0x92,
                0xB6,
                0xE5,
                0x10,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x42,
                0x3D,
                0xCC,
                0xC4,
                0x86,
                0x75,
                0x2A,
                0x49,
                0x93,
                0x0B,
                0x7B,
                0xC1,
                0x38,
                0xFC,
                0x21,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactManagerStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x22,
                0x98,
                0x24,
                0x7B,
                0x34,
                0xDC,
                0x46,
                0x8D,
                0x95,
                0x51,
                0xBD,
                0x41,
                0xE1,
                0x5A,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactManagerStatics5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x1A,
                0x59,
                0xF7,
                0xB7,
                0xAC,
                0xAD,
                0x4F,
                0x90,
                0xF2,
                0xA8,
                0xAB,
                0x64,
                0xCD,
                0xBB,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactMatchReason
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x25,
                0x92,
                0xBC,
                0xD8,
                0xE7,
                0x3E,
                0x41,
                0x95,
                0xF4,
                0xB7,
                0x5C,
                0x54,
                0xC7,
                0x40,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactName
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xE9,
                0x04,
                0xF4,
                0x34,
                0x90,
                0x3C,
                0x45,
                0x8E,
                0xBF,
                0x14,
                0x0A,
                0x38,
                0xC8,
                0x6F,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPanel
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x12,
                0xBF,
                0x41,
                0xEE,
                0xD2,
                0x97,
                0x4B,
                0xA8,
                0x0A,
                0x7D,
                0x8D,
                0x64,
                0xCC,
                0xA6,
                0xF5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPanelClosingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x74,
                0x21,
                0x22,
                0x4B,
                0xCF,
                0xD7,
                0x46,
                0xB7,
                0x39,
                0x6E,
                0xDC,
                0x16,
                0x11,
                0x0B,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPanelLaunchFullAppRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x1C,
                0xD6,
                0x88,
                0xB4,
                0x23,
                0xE8,
                0x4B,
                0x8A,
                0xFC,
                0x07,
                0x2C,
                0x25,
                0xA4,
                0x19,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPhone
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xAB,
                0x7D,
                0x46,
                0x12,
                0x27,
                0x52,
                0x4F,
                0xB7,
                0x83,
                0x9E,
                0xA8,
                0x11,
                0x1C,
                0x63,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPicker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0xFD,
                0x09,
                0x0E,
                0xF8,
                0x42,
                0x55,
                0x40,
                0x90,
                0xA0,
                0x89,
                0x6F,
                0x96,
                0x73,
                0x89,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPicker2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x11,
                0x50,
                0xB3,
                0xEF,
                0x5C,
                0x24,
                0x4D,
                0xAA,
                0x0C,
                0x34,
                0x0C,
                0x52,
                0x08,
                0x72,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPicker3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x33,
                0x72,
                0x0E,
                0x43,
                0xB2,
                0xED,
                0x4B,
                0x85,
                0x16,
                0x22,
                0xB1,
                0xA7,
                0xAC,
                0x0A,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactPickerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0xC0,
                0x88,
                0x74,
                0x53,
                0x6A,
                0x58,
                0x42,
                0xA3,
                0xE9,
                0x62,
                0xDF,
                0xF6,
                0x78,
                0x4B,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactQueryOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xCC,
                0x08,
                0x44,
                0x7C,
                0x7D,
                0xF0,
                0x42,
                0x8A,
                0xC7,
                0xF5,
                0x07,
                0x33,
                0xEC,
                0xDB,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactQueryOptionsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0xBA,
                0x3F,
                0x54,
                0xE7,
                0x8C,
                0xCB,
                0x46,
                0x9D,
                0xAC,
                0x9A,
                0xA4,
                0x2A,
                0x1B,
                0xC8,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactQueryTextSearch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xF9,
                0xE3,
                0xF7,
                0x57,
                0xA9,
                0x9B,
                0x43,
                0xA0,
                0xB7,
                0x1C,
                0x02,
                0xA1,
                0x96,
                0x3F,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0xE4,
                0x97,
                0xD3,
                0x88,
                0x14,
                0xF2,
                0x42,
                0xBF,
                0x64,
                0x25,
                0x3F,
                0x48,
                0x84,
                0xBF,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactSignificantOther
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAB,
                0xB5,
                0x73,
                0x88,
                0xFB,
                0xC5,
                0xD8,
                0x46,
                0x93,
                0xFE,
                0xDA,
                0x3F,
                0xF1,
                0x93,
                0x40,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactSignificantOther2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0xD4,
                0x7B,
                0x8D,
                0x03,
                0x3F,
                0xF8,
                0x45,
                0xBA,
                0x0F,
                0xC4,
                0xED,
                0x37,
                0xD6,
                0x42,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0x0B,
                0x22,
                0x2C,
                0x6C,
                0x3A,
                0x93,
                0x42,
                0xB9,
                0xBC,
                0xFE,
                0x98,
                0x7F,
                0x6E,
                0x0D,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactStore2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x1C,
                0xCE,
                0x18,
                0xD5,
                0xEB,
                0xFB,
                0x4B,
                0xB6,
                0x90,
                0x5F,
                0x4F,
                0x27,
                0xC4,
                0xF0,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactStore3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x2C,
                0x88,
                0xCB,
                0x4E,
                0x00,
                0x50,
                0x40,
                0x87,
                0xF0,
                0x84,
                0x04,
                0x07,
                0xEE,
                0x68,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactStoreNotificationTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x98,
                0xB2,
                0xAB,
                0x8A,
                0x87,
                0x8B,
                0x4F,
                0xA9,
                0xCE,
                0x46,
                0xBB,
                0x7D,
                0x1C,
                0x84,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactWebsite
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x01,
                0x13,
                0x9F,
                0x1B,
                0xDC,
                0x55,
                0x40,
                0xAD,
                0x66,
                0x65,
                0x2F,
                0x39,
                0xD9,
                0x90,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContactWebsite2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0xE9,
                0x7E,
                0xF8,
                0x47,
                0x56,
                0x68,
                0x40,
                0xBB,
                0x5E,
                0x4B,
                0x6F,
                0x43,
                0x7C,
                0xE3,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFullContactCardOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x43,
                0x44,
                0x87,
                0xF9,
                0x5C,
                0x83,
                0x46,
                0xBD,
                0xCA,
                0xA1,
                0xFD,
                0xEB,
                0xF8,
                0xDB,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownContactFieldStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x1B,
                0x0E,
                0x2E,
                0x27,
                0xD6,
                0xCA,
                0x4F,
                0xBA,
                0xD4,
                0x1F,
                0xAF,
                0x16,
                0x8C,
                0x7D,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPinnedContactIdsQueryResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x25,
                0x9B,
                0x7D,
                0x79,
                0x15,
                0xDC,
                0x4D,
                0x87,
                0x1F,
                0xA3,
                0x0A,
                0x3A,
                0xEA,
                0x9B,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPinnedContactManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x74,
                0xBC,
                0xFC,
                0xD6,
                0xE1,
                0xC3,
                0x45,
                0xB8,
                0xB6,
                0xA3,
                0x56,
                0x04,
                0xE1,
                0x67,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPinnedContactManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0xCC,
                0x5C,
                0xF6,
                0xF9,
                0xFD,
                0x6A,
                0x48,
                0xAC,
                0xE9,
                0xBC,
                0x31,
                0x1D,
                0x0A,
                0xE7,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
