// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IEmailAttachment
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0xCA,
                0x53,
                0xF3,
                0xC8,
                0x57,
                0xDB,
                0x4A,
                0xB9,
                0x92,
                0x60,
                0xFC,
                0xEB,
                0x58,
                0x4F,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailAttachment2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x10,
                0x5F,
                0x22,
                0xFF,
                0xB0,
                0x71,
                0x45,
                0x9D,
                0x54,
                0xA7,
                0x06,
                0xC4,
                0x8D,
                0x55,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailAttachmentFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xAC,
                0x6E,
                0x79,
                0x56,
                0xED,
                0x79,
                0x49,
                0x87,
                0x08,
                0xAB,
                0xB8,
                0xBC,
                0x85,
                0x4B,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailAttachmentFactory2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x94,
                0x25,
                0x23,
                0xF9,
                0x51,
                0x7D,
                0x42,
                0xAD,
                0xCD,
                0x24,
                0x10,
                0x23,
                0xC8,
                0xCF,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailConversation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xC2,
                0x18,
                0xDA,
                0xBC,
                0xA0,
                0x49,
                0x43,
                0x90,
                0x2D,
                0x90,
                0xF6,
                0x63,
                0x89,
                0xF5,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailConversationBatch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xAB,
                0xC1,
                0xB8,
                0xC5,
                0x01,
                0x2A,
                0x43,
                0x9D,
                0xF1,
                0xFE,
                0x85,
                0xD9,
                0x8A,
                0x27,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailConversationReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x0F,
                0x63,
                0xB4,
                0x75,
                0x28,
                0xC8,
                0x44,
                0x9B,
                0x8C,
                0x85,
                0xBE,
                0xB3,
                0xA3,
                0xC6,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailFolder
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x77,
                0x4F,
                0xA2,
                0x6C,
                0x99,
                0x64,
                0x48,
                0xB1,
                0xBA,
                0xED,
                0x12,
                0x40,
                0xE5,
                0x7D,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailIrmInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x21,
                0xF5,
                0x90,
                0xA0,
                0xB1,
                0xBD,
                0x4E,
                0xA6,
                0xB6,
                0xDD,
                0xCA,
                0x55,
                0x60,
                0x6E,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailIrmInfoFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0xB1,
                0x4B,
                0x31,
                0xE6,
                0xE3,
                0x7B,
                0x4D,
                0xBE,
                0x8D,
                0x91,
                0xA9,
                0x63,
                0x11,
                0xB0,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailIrmTemplate
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x75,
                0x27,
                0xF3,
                0x6D,
                0x54,
                0xEA,
                0x4B,
                0xA9,
                0x63,
                0x54,
                0xA3,
                0x8B,
                0x2C,
                0xC0,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailIrmTemplateFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x18,
                0xA3,
                0x3D,
                0x38,
                0x87,
                0x18,
                0x44,
                0xB9,
                0xCB,
                0x47,
                0x1B,
                0x93,
                0x6F,
                0xE7,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailItemCounts
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x33,
                0xD1,
                0x5B,
                0xC8,
                0xFE,
                0xAB,
                0x4B,
                0x83,
                0xBA,
                0x0B,
                0xAF,
                0x3C,
                0x1F,
                0x6C,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailbox
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x06,
                0x79,
                0xA8,
                0x5B,
                0xCF,
                0x1B,
                0x41,
                0x80,
                0xB1,
                0x4A,
                0x6A,
                0x14,
                0x84,
                0xCE,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailbox2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0xE4,
                0xF8,
                0x14,
                0xA2,
                0x6C,
                0xB2,
                0x4A,
                0x92,
                0x41,
                0x79,
                0xCD,
                0x7B,
                0xF4,
                0x63,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailbox3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x89,
                0xA5,
                0x3D,
                0x8B,
                0x45,
                0x8A,
                0x40,
                0x8E,
                0x37,
                0xAC,
                0x8B,
                0x05,
                0xD8,
                0xAF,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailbox4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x30,
                0x1F,
                0x5D,
                0x22,
                0xF2,
                0xA7,
                0x48,
                0xB7,
                0xB6,
                0x71,
                0x63,
                0x56,
                0xCD,
                0x26,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailbox5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x70,
                0x96,
                0x39,
                0x92,
                0x00,
                0xBE,
                0x49,
                0xBD,
                0x0E,
                0x5D,
                0x4D,
                0xC9,
                0xD9,
                0x6D,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxAction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x89,
                0x98,
                0xAC,
                0xFA,
                0x21,
                0x27,
                0x49,
                0x92,
                0x10,
                0xD4,
                0x10,
                0x58,
                0x2F,
                0xDF,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxAutoReply
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x25,
                0x23,
                0xE2,
                0xB4,
                0x8A,
                0x5B,
                0x48,
                0xB3,
                0x1F,
                0x04,
                0xD1,
                0x54,
                0x76,
                0xBD,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxAutoReplySettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x9F,
                0x7A,
                0xA8,
                0xC6,
                0x0A,
                0x77,
                0x4B,
                0xBA,
                0x77,
                0xA6,
                0xB9,
                0x9E,
                0x9A,
                0x27,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0xC3,
                0xDE,
                0xEE,
                0xDB,
                0x89,
                0x05,
                0x43,
                0x82,
                0xC4,
                0x43,
                0x9E,
                0x0A,
                0x33,
                0xDA,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxCapabilities2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x3E,
                0x72,
                0x69,
                0x21,
                0x2F,
                0xBC,
                0x4C,
                0x88,
                0xAB,
                0x2E,
                0x76,
                0x02,
                0xA4,
                0x80,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxCapabilities3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0xE9,
                0x90,
                0xF6,
                0xF2,
                0x56,
                0xAA,
                0x45,
                0x87,
                0x2C,
                0x0C,
                0xE9,
                0xF3,
                0xDB,
                0x0B,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxChange
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0xF5,
                0xED,
                0x61,
                0xEF,
                0x11,
                0x0C,
                0x40,
                0xAD,
                0xDE,
                0x8C,
                0xDE,
                0x65,
                0xC8,
                0x5E,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxChangeReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x0E,
                0xBD,
                0xBD,
                0x3D,
                0xC5,
                0x31,
                0x43,
                0x97,
                0xBE,
                0xBE,
                0x75,
                0xA2,
                0x14,
                0x6A,
                0x75,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxChangeTracker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0x86,
                0xE4,
                0x7A,
                0x66,
                0x51,
                0xB7,
                0x42,
                0x88,
                0x82,
                0xFD,
                0x21,
                0xC9,
                0x2B,
                0xDD,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxChangedDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x74,
                0x9A,
                0x77,
                0xC5,
                0x97,
                0x54,
                0x4B,
                0xB3,
                0x0D,
                0x30,
                0x62,
                0x32,
                0x62,
                0x3E,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x5F,
                0xFD,
                0x3C,
                0xD4,
                0x01,
                0x4A,
                0x4E,
                0xA4,
                0x4C,
                0xB2,
                0x2D,
                0xD4,
                0x2E,
                0xC2,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxCreateFolderResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x55,
                0x28,
                0xB2,
                0x85,
                0x28,
                0x98,
                0x49,
                0xB5,
                0x95,
                0x8A,
                0x2D,
                0x37,
                0x4C,
                0xE9,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxPolicies
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0x45,
                0x33,
                0x1F,
                0x3B,
                0x1C,
                0xC7,
                0x4D,
                0xB4,
                0x10,
                0x63,
                0x73,
                0x78,
                0x3E,
                0x54,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxPolicies2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0x8A,
                0xB5,
                0xBA,
                0x4B,
                0xA1,
                0x7C,
                0x49,
                0xA8,
                0xE2,
                0x55,
                0xEA,
                0xC2,
                0x9C,
                0xC4,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxPolicies3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0xA0,
                0xD4,
                0xBD,
                0x67,
                0x48,
                0x4A,
                0x41,
                0x81,
                0xA2,
                0x80,
                0x39,
                0x19,
                0xC4,
                0x41,
                0x91,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxSyncManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0xC5,
                0x7A,
                0x51,
                0x91,
                0x35,
                0x5D,
                0x4B,
                0x85,
                0xBC,
                0xC7,
                0x1D,
                0xDE,
                0x86,
                0x22,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMailboxSyncManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0xC9,
                0x8D,
                0xCD,
                0xC1,
                0x95,
                0x89,
                0x4F,
                0x81,
                0xB7,
                0xE6,
                0xAE,
                0xCB,
                0x66,
                0x95,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailManagerForUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0xDE,
                0x73,
                0xF7,
                0xA5,
                0x3C,
                0x0F,
                0x4B,
                0x90,
                0xC1,
                0x15,
                0x6E,
                0x40,
                0x17,
                0x4C,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0x86,
                0x12,
                0xF5,
                0xC5,
                0x55,
                0x90,
                0x48,
                0xA8,
                0x24,
                0x21,
                0x6C,
                0x26,
                0x18,
                0xCE,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x2D,
                0x05,
                0xAC,
                0x94,
                0xB1,
                0x5D,
                0x42,
                0xB6,
                0xD9,
                0xD0,
                0xF0,
                0x41,
                0x35,
                0xED,
                0xA2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x23,
                0x72,
                0x4A,
                0x3E,
                0x84,
                0x45,
                0x49,
                0xB3,
                0xAA,
                0x34,
                0x9E,
                0x07,
                0xA3,
                0x62,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMeetingInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x3F,
                0xC0,
                0x31,
                0x33,
                0x79,
                0x5F,
                0x41,
                0xA2,
                0x75,
                0xD1,
                0x65,
                0xBA,
                0x07,
                0x02,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMeetingInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x38,
                0x59,
                0x7E,
                0xD9,
                0xB0,
                0xE5,
                0x4F,
                0x86,
                0x7C,
                0xE3,
                0x1E,
                0xD2,
                0xB5,
                0x88,
                0xB8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMessage
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8D,
                0x94,
                0x6D,
                0x6C,
                0xB5,
                0x80,
                0xF8,
                0x48,
                0xB0,
                0xB1,
                0xE0,
                0x4E,
                0x43,
                0x0F,
                0x44,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMessage2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x24,
                0xC8,
                0xFD,
                0x1A,
                0x9F,
                0xDB,
                0x44,
                0xBD,
                0x3C,
                0x65,
                0xC3,
                0x84,
                0x77,
                0x0F,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMessage3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x67,
                0xEA,
                0xA1,
                0x98,
                0xE5,
                0x29,
                0x4D,
                0xA0,
                0x18,
                0xFC,
                0x7B,
                0x7E,
                0xEC,
                0xE0,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMessage4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xF1,
                0x7C,
                0x31,
                0x7F,
                0x3E,
                0x05,
                0x4A,
                0x83,
                0x94,
                0x3E,
                0x10,
                0x33,
                0x6D,
                0xD4,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMessageBatch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0xD0,
                0x5C,
                0x60,
                0xD9,
                0x25,
                0x1B,
                0x4F,
                0x9E,
                0x51,
                0x05,
                0x14,
                0xC0,
                0x14,
                0x96,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailMessageReader
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0xBE,
                0x4A,
                0x2F,
                0x13,
                0x62,
                0x85,
                0x4A,
                0xA3,
                0xB0,
                0xF9,
                0x2D,
                0x1A,
                0x83,
                0x9D,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailQueryOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x4B,
                0x50,
                0x45,
                0x7F,
                0x3E,
                0x52,
                0x4D,
                0xB6,
                0xDD,
                0xD6,
                0xFD,
                0x4E,
                0x1F,
                0xBD,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailQueryOptionsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0xA1,
                0xF1,
                0x88,
                0xAB,
                0x78,
                0xE8,
                0x4E,
                0xB4,
                0xE3,
                0x04,
                0x6D,
                0x6E,
                0x2F,
                0xE5,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailQueryTextSearch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xA2,
                0xA0,
                0x9F,
                0x5D,
                0x3C,
                0xA5,
                0x46,
                0xA6,
                0xE2,
                0x31,
                0xD6,
                0xFD,
                0x17,
                0xE5,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailRecipient
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x25,
                0xE8,
                0xCA,
                0x78,
                0x44,
                0x14,
                0x48,
                0xB9,
                0x00,
                0xC9,
                0x02,
                0xB5,
                0xE1,
                0x9B,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailRecipientFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0xB8,
                0x00,
                0x55,
                0x9A,
                0xC7,
                0xF8,
                0x4E,
                0xB9,
                0x09,
                0x72,
                0x2E,
                0x18,
                0xE3,
                0x93,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailRecipientResolutionResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFA,
                0x38,
                0x83,
                0x91,
                0x8D,
                0x8D,
                0x73,
                0x45,
                0x80,
                0xD1,
                0x07,
                0x17,
                0x2A,
                0x34,
                0xB9,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailRecipientResolutionResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x0B,
                0x42,
                0x5E,
                0x5B,
                0xCE,
                0xDE,
                0x4B,
                0xB9,
                0xD4,
                0xE1,
                0x6D,
                0xA0,
                0xB0,
                0x9F,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailStore
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0x22,
                0x03,
                0xF8,
                0x37,
                0x91,
                0x8B,
                0x4F,
                0xA4,
                0x70,
                0x27,
                0x9A,
                0xC3,
                0x05,
                0x8E,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEmailStoreNotificationTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3C,
                0x56,
                0x17,
                0xCE,
                0xE6,
                0x46,
                0xC9,
                0x43,
                0x96,
                0xF7,
                0xFA,
                0xCF,
                0x7D,
                0xD7,
                0x10,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
