// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAdaptiveNotificationContent
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0xBE,
                0x0D,
                0xEB,
                0x48,
                0x74,
                0x8D,
                0x44,
                0x9D,
                0xB8,
                0xD7,
                0x8A,
                0xCD,
                0x2A,
                0xBB,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdaptiveNotificationText
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0xA3,
                0xD4,
                0x46,
                0x9A,
                0x60,
                0x26,
                0x43,
                0xA4,
                0x0B,
                0xBF,
                0xDE,
                0x87,
                0x20,
                0x34,
                0xA3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBadgeNotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0xB4,
                0x5C,
                0x07,
                0x8A,
                0xD0,
                0x2F,
                0x4E,
                0x92,
                0x33,
                0x7E,
                0x28,
                0x9C,
                0x1F,
                0x77,
                0x22,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBadgeNotificationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x55,
                0xF2,
                0xED,
                0x18,
                0x06,
                0x59,
                0x4D,
                0x94,
                0x8A,
                0x5A,
                0x61,
                0x04,
                0x0C,
                0x52,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBadgeUpdateManagerForUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x21,
                0x6B,
                0x99,
                0x86,
                0x03,
                0xE5,
                0x44,
                0xBA,
                0x8D,
                0x0C,
                0x10,
                0x77,
                0xA6,
                0x2E,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBadgeUpdateManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x0F,
                0x40,
                0x33,
                0xD5,
                0x6D,
                0x05,
                0x41,
                0xAE,
                0xBC,
                0x9B,
                0x50,
                0xFC,
                0xA4,
                0x92,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBadgeUpdateManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x35,
                0x9A,
                0x97,
                0x40,
                0xF9,
                0xBF,
                0x48,
                0x94,
                0xE8,
                0xCA,
                0x24,
                0x4D,
                0x40,
                0x0B,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBadgeUpdater
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x1F,
                0xFA,
                0xB5,
                0x62,
                0x75,
                0x6C,
                0x4F,
                0xBF,
                0xA3,
                0x1B,
                0x6E,
                0xD2,
                0xE5,
                0x7F,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownAdaptiveNotificationHintsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0x65,
                0x20,
                0x06,
                0x96,
                0xD4,
                0x7D,
                0x49,
                0x86,
                0x92,
                0x4F,
                0x7D,
                0x7C,
                0x27,
                0x70,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownAdaptiveNotificationTextStylesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x92,
                0x21,
                0x20,
                0x96,
                0x89,
                0xAA,
                0x45,
                0x8B,
                0xA1,
                0xD4,
                0x61,
                0xD7,
                0x2C,
                0x2A,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownNotificationBindingsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0x7B,
                0x42,
                0x79,
                0xB7,
                0xA8,
                0x58,
                0x4D,
                0x89,
                0xEA,
                0x76,
                0xA7,
                0xB7,
                0xBC,
                0xCD,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x37,
                0x80,
                0x10,
                0x76,
                0xEB,
                0x82,
                0x4F,
                0x97,
                0xBC,
                0xDA,
                0x07,
                0x53,
                0x0A,
                0x2E,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INotificationBinding
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x4B,
                0x9E,
                0xF2,
                0x70,
                0x03,
                0xD3,
                0x4A,
                0xB4,
                0xEA,
                0xDA,
                0x9E,
                0x35,
                0xE7,
                0xEA,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INotificationData
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x23,
                0xFD,
                0x9F,
                0x6A,
                0x9D,
                0xAF,
                0x4A,
                0xB6,
                0xAC,
                0xFF,
                0x17,
                0xF0,
                0xC1,
                0xF2,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INotificationDataFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0xE3,
                0xC1,
                0x23,
                0x10,
                0x1C,
                0xFB,
                0x46,
                0x80,
                0x40,
                0xDE,
                0xC3,
                0x84,
                0x62,
                0x1C,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INotificationVisual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8E,
                0x5B,
                0x83,
                0x68,
                0x56,
                0xAA,
                0x11,
                0x4E,
                0x86,
                0xD3,
                0x5F,
                0x9A,
                0x69,
                0x57,
                0xBC,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScheduledTileNotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0xA6,
                0xBC,
                0x0A,
                0xDC,
                0x99,
                0x78,
                0x4C,
                0xA1,
                0x1C,
                0xC9,
                0xE7,
                0xF8,
                0x6D,
                0x7E,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScheduledTileNotificationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x13,
                0x83,
                0x33,
                0xC0,
                0x98,
                0x3B,
                0x4C,
                0xBB,
                0xD6,
                0x4A,
                0x63,
                0x3C,
                0x7C,
                0xFC,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScheduledToastNotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x77,
                0xF5,
                0x79,
                0xE7,
                0x0D,
                0xCD,
                0x48,
                0x97,
                0x40,
                0x9B,
                0x37,
                0x04,
                0x90,
                0xC8,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScheduledToastNotification2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0xA0,
                0x6E,
                0xA6,
                0xB4,
                0x31,
                0xB0,
                0x43,
                0xB5,
                0xDD,
                0x7A,
                0x40,
                0xE8,
                0x53,
                0x63,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScheduledToastNotification3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x9E,
                0x42,
                0x98,
                0x32,
                0xBD,
                0x3B,
                0x4A,
                0x9D,
                0x15,
                0x22,
                0xAE,
                0xA4,
                0x94,
                0x62,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScheduledToastNotification4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0x61,
                0x47,
                0x1D,
                0xEF,
                0xBD,
                0x4A,
                0x4E,
                0x96,
                0xBE,
                0x01,
                0x01,
                0x36,
                0x9B,
                0x58,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScheduledToastNotificationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0xD1,
                0xBE,
                0xE7,
                0xB9,
                0x0B,
                0x89,
                0x41,
                0x83,
                0x94,
                0x31,
                0x76,
                0x1B,
                0x47,
                0x6F,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScheduledToastNotificationShowingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0xF6,
                0x73,
                0x61,
                0x2A,
                0x41,
                0x2C,
                0x5E,
                0xA6,
                0xED,
                0xA0,
                0x20,
                0x9A,
                0xEF,
                0x9A,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShownTileNotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x89,
                0x2D,
                0x34,
                0xF2,
                0x5A,
                0x1A,
                0x48,
                0xA6,
                0xA3,
                0xF2,
                0xFD,
                0xC7,
                0x8D,
                0xE8,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileFlyoutNotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xB2,
                0x53,
                0x9A,
                0x0C,
                0xC7,
                0xBE,
                0x42,
                0xB2,
                0xF3,
                0xF4,
                0x2A,
                0xA9,
                0x7D,
                0x34,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileFlyoutNotificationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0x6F,
                0x55,
                0xEF,
                0x26,
                0x52,
                0x2B,
                0x4F,
                0xB2,
                0x78,
                0x88,
                0xA3,
                0x5D,
                0xFE,
                0x56,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileFlyoutUpdateManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0B,
                0x3B,
                0x36,
                0x04,
                0xC0,
                0x1A,
                0x99,
                0x4B,
                0x88,
                0xE7,
                0xAD,
                0xA8,
                0x3E,
                0x95,
                0x3D,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileFlyoutUpdater
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xC7,
                0x40,
                0x8D,
                0x65,
                0xC4,
                0x52,
                0x40,
                0xA7,
                0x40,
                0x5C,
                0x26,
                0x54,
                0xC1,
                0xA0,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileNotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0xC8,
                0xAE,
                0xEB,
                0xEC,
                0x50,
                0x18,
                0x4C,
                0xB4,
                0xD0,
                0x3A,
                0xF0,
                0x2E,
                0x55,
                0x40,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileNotificationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0xDD,
                0xAB,
                0xC6,
                0x28,
                0x49,
                0xC8,
                0x46,
                0xBD,
                0xBF,
                0x81,
                0xA0,
                0x47,
                0xDE,
                0xA0,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileUpdateManagerForUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x13,
                0x14,
                0x55,
                0xE2,
                0x2E,
                0x2D,
                0x4E,
                0x9C,
                0xC1,
                0x21,
                0x6A,
                0x20,
                0xDE,
                0xCC,
                0x9F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileUpdateManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x9E,
                0x15,
                0xDA,
                0xA9,
                0x3E,
                0x86,
                0x49,
                0x8D,
                0x84,
                0xB0,
                0x9D,
                0x5E,
                0x12,
                0x27,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileUpdateManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x1D,
                0x1C,
                0x73,
                0x14,
                0x8E,
                0x7C,
                0x4B,
                0xA3,
                0x4B,
                0x9D,
                0x22,
                0xDE,
                0x76,
                0xC8,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileUpdater
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xA4,
                0x42,
                0x09,
                0x91,
                0x1D,
                0xEC,
                0x44,
                0x92,
                0x43,
                0xC1,
                0xE8,
                0x21,
                0xC2,
                0x9A,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITileUpdater2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x6E,
                0x26,
                0xA2,
                0xEE,
                0x15,
                0xED,
                0x43,
                0x83,
                0xF5,
                0x65,
                0xB3,
                0x52,
                0xBB,
                0x1A,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x92,
                0xBF,
                0xE3,
                0x97,
                0xC1,
                0x6F,
                0x43,
                0x82,
                0x65,
                0x06,
                0x25,
                0x82,
                0x4F,
                0x8D,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastActivatedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0xA5,
                0x7D,
                0xAB,
                0x61,
                0xCC,
                0x8E,
                0x56,
                0x81,
                0xBE,
                0x30,
                0x4A,
                0xC3,
                0x10,
                0x38,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xC3,
                0x8B,
                0x0A,
                0xBE,
                0xE0,
                0x58,
                0x48,
                0xBC,
                0x2A,
                0x89,
                0xDF,
                0xE0,
                0xB3,
                0x28,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastCollectionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0xD3,
                0x4D,
                0x16,
                0xC4,
                0x73,
                0xF7,
                0x44,
                0xB4,
                0xFF,
                0xFB,
                0x6D,
                0x4B,
                0xF1,
                0xF4,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastCollectionManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0x21,
                0x18,
                0x2A,
                0x9D,
                0x17,
                0xBC,
                0x49,
                0xB7,
                0x9D,
                0xA5,
                0x27,
                0x92,
                0x0D,
                0x36,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastDismissedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0xD9,
                0x89,
                0x3F,
                0xCB,
                0xD9,
                0x38,
                0x45,
                0xA0,
                0xF0,
                0xFF,
                0xE7,
                0x65,
                0x99,
                0x38,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastFailedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0x68,
                0x17,
                0x35,
                0xD4,
                0xCF,
                0xF8,
                0x44,
                0xAD,
                0x64,
                0xF5,
                0x00,
                0xFD,
                0x89,
                0x6C,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x26,
                0x7E,
                0x99,
                0x9E,
                0x05,
                0x60,
                0x4E,
                0x8B,
                0x06,
                0x17,
                0x60,
                0x91,
                0x7C,
                0x8B,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotification2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x9F,
                0xFB,
                0x9D,
                0x3A,
                0x14,
                0x0E,
                0x49,
                0x90,
                0xBF,
                0xB9,
                0xFB,
                0xA7,
                0x13,
                0x2D,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotification3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0xAE,
                0xE8,
                0x31,
                0x41,
                0x81,
                0x99,
                0x4F,
                0xBC,
                0x0A,
                0xC4,
                0xED,
                0x21,
                0x29,
                0x7D,
                0x77,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotification4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x49,
                0x15,
                0x15,
                0xEA,
                0x28,
                0x27,
                0x47,
                0x88,
                0xE9,
                0xC5,
                0x86,
                0x80,
                0xE2,
                0xD1,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotification6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xFE,
                0xEB,
                0x43,
                0xAE,
                0x89,
                0x1E,
                0x5C,
                0xA2,
                0x79,
                0x3A,
                0xEC,
                0xFE,
                0x9B,
                0x6F,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationActionTriggerDetail
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x13,
                0x45,
                0x94,
                0xF3,
                0x38,
                0xF6,
                0x42,
                0x96,
                0xAA,
                0x79,
                0x55,
                0xB0,
                0xF0,
                0x3D,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x4B,
                0x12,
                0x04,
                0xC6,
                0x82,
                0x29,
                0x42,
                0xB1,
                0x09,
                0xFD,
                0x9E,
                0xD4,
                0x66,
                0x2B,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationHistory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0xDC,
                0xAD,
                0x5C,
                0xD3,
                0x01,
                0x97,
                0x4C,
                0x98,
                0x6F,
                0x05,
                0x33,
                0x48,
                0x3F,
                0xEE,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationHistory2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0xD2,
                0xC3,
                0x3B,
                0x31,
                0x2F,
                0x92,
                0x40,
                0x91,
                0x29,
                0x8A,
                0xD5,
                0xAB,
                0xF0,
                0x67,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationHistoryChangedTriggerDetail
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x7F,
                0x03,
                0xDB,
                0x68,
                0x00,
                0x2C,
                0x41,
                0x9C,
                0x83,
                0x26,
                0x7C,
                0x37,
                0xF6,
                0x56,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationHistoryChangedTriggerDetail2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0xE9,
                0x36,
                0x0B,
                0x71,
                0xC8,
                0xFB,
                0x49,
                0xBA,
                0xBB,
                0x25,
                0xBD,
                0xBC,
                0x4C,
                0xC4,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationManagerForUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x57,
                0xAB,
                0x79,
                0xFE,
                0x43,
                0x7B,
                0x48,
                0x8A,
                0x7F,
                0x99,
                0x56,
                0x72,
                0x00,
                0xAE,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationManagerForUser2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x64,
                0x9C,
                0x67,
                0xAB,
                0x81,
                0xC2,
                0x42,
                0x88,
                0x19,
                0xC9,
                0x58,
                0x76,
                0x77,
                0x53,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationManagerForUser3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0xB1,
                0xFC,
                0x3E,
                0xC1,
                0x6C,
                0xDC,
                0x56,
                0x97,
                0x3B,
                0x25,
                0x1F,
                0x7A,
                0xAC,
                0xB1,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0x10,
                0xAC,
                0x50,
                0x35,
                0xD2,
                0x98,
                0x45,
                0xBB,
                0xEF,
                0x98,
                0xFE,
                0x4D,
                0x1A,
                0x3A,
                0xD4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x3C,
                0xB9,
                0x7A,
                0x48,
                0x0E,
                0x50,
                0x47,
                0xBA,
                0x9D,
                0x1A,
                0x41,
                0x13,
                0x98,
                0x18,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationManagerStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0x3F,
                0x99,
                0x8F,
                0x16,
                0xE5,
                0xFB,
                0x45,
                0x81,
                0x30,
                0x39,
                0x8E,
                0x93,
                0xFA,
                0x52,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotificationManagerStatics5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xF5,
                0xF5,
                0xD6,
                0x0D,
                0xD4,
                0x7C,
                0x40,
                0x89,
                0x89,
                0x88,
                0xCA,
                0xB4,
                0x2C,
                0xFD,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotifier
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x7B,
                0x92,
                0x75,
                0xF3,
                0x03,
                0xEC,
                0x41,
                0x91,
                0xD3,
                0x6E,
                0x5B,
                0xAC,
                0x1B,
                0x38,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotifier2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x89,
                0x43,
                0x35,
                0x01,
                0x7C,
                0xD5,
                0x4B,
                0x9C,
                0x20,
                0x60,
                0x43,
                0x40,
                0xCD,
                0x2B,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IToastNotifier3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0xA0,
                0x75,
                0xAE,
                0x0C,
                0x3B,
                0xAD,
                0x51,
                0xB7,
                0xE8,
                0xB0,
                0x8A,
                0xB6,
                0x05,
                0x25,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_WinRT_IUserNotification
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0xE5,
                0xF7,
                0xAD,
                0x53,
                0x4E,
                0xD5,
                0x42,
                0x9C,
                0x33,
                0xEB,
                0x5E,
                0xA5,
                0x15,
                0xB2,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserNotificationChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x39,
                0x68,
                0xBD,
                0xB6,
                0xCF,
                0x79,
                0x25,
                0x4B,
                0x82,
                0xC0,
                0x0C,
                0xE1,
                0xEE,
                0xF8,
                0x1F,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
