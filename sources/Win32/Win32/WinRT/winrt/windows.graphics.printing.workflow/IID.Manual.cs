// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.WinRT;

namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IPrintWorkflowBackgroundSession
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xBA, 0x13, 0x79, 0x5B,
                0x5E, 0x0C,
                0x8A, 0x52,
                0x74,
                0x58,
                0x86,
                0xA4,
                0x6C,
                0xBD,
                0xDC,
                0x45
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowBackgroundSetupRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x42, 0x73, 0xE9, 0x43,
                0x50, 0x17,
                0xC9, 0x59,
                0x61,
                0xFB,
                0x38,
                0x37,
                0x48,
                0xA2,
                0x03,
                0x62
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xED, 0xC4, 0xAA, 0xD0,
                0x4B, 0xFD,
                0xF5, 0x5D,
                0x4B,
                0xB6,
                0x8D,
                0x0D,
                0x15,
                0x9E,
                0xBE,
                0x3F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowConfiguration2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x50, 0x0A, 0x35, 0xDE,
                0xD4, 0xA6,
                0xE2, 0x5B,
                0x8B,
                0x9A,
                0x09,
                0xD3,
                0xD3,
                0x9E,
                0xA7,
                0x80
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowForegroundSession
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xD0, 0x63, 0x9B, 0xC7,
                0xEC, 0xF8,
                0xEB, 0x4C,
                0x95,
                0x3A,
                0xC8,
                0x87,
                0x61,
                0x57,
                0xDD,
                0x33
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowForegroundSetupRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x47, 0x82, 0xE3, 0xBB,
                0x1B, 0x9C,
                0xD3, 0x4D,
                0x9B,
                0x2B,
                0xC8,
                0x04,
                0x68,
                0xD9,
                0x41,
                0xB3
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowJobActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x6D, 0x5E, 0xBD, 0xD4,
                0x4E, 0x03,
                0x00, 0x5E,
                0xA6,
                0x16,
                0xF9,
                0x61,
                0xA0,
                0x33,
                0xDC,
                0xC8
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowJobBackgroundSession
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xD8, 0x6A, 0xEC, 0xC5,
                0xC9, 0x20,
                0x51, 0x5D,
                0x85,
                0x07,
                0x27,
                0x34,
                0xB4,
                0x6F,
                0x96,
                0xC5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowJobBackgroundSession2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xAF, 0xAD, 0x2A, 0x59,
                0x26, 0xEF,
                0x55, 0x5A,
                0xAD,
                0x21,
                0x5F,
                0x63,
                0xFF,
                0xCF,
                0x83,
                0x66
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowJobIssueDetectedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x6E, 0xA4, 0x58, 0xDE,
                0x1E, 0xE4,
                0x0A, 0x55,
                0xA9,
                0xFB,
                0x4B,
                0x1F,
                0x93,
                0xFB,
                0x9D,
                0x98
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowJobNotificationEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xBA, 0x6F, 0xE1, 0x0A,
                0x98, 0x53,
                0xBA, 0x5E,
                0xB4,
                0x72,
                0x97,
                0x86,
                0x50,
                0x18,
                0x6A,
                0x9A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowJobStartingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xA8, 0x9B, 0xD9, 0xE3,
                0xAD, 0x31,
                0x09, 0x5E,
                0xB0,
                0xD7,
                0x60,
                0x1B,
                0x97,
                0xF1,
                0x61,
                0xAD
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowJobStartingEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x67, 0xED, 0xED, 0x7D,
                0xDC, 0xD3,
                0x23, 0x5B,
                0x86,
                0x90,
                0x4E,
                0xBF,
                0xC0,
                0xF0,
                0x91,
                0x4A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowJobTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x29, 0x61, 0x29, 0xFF,
                0xE2, 0x60,
                0xDB, 0x51,
                0xBA,
                0x8C,
                0xE2,
                0xCC,
                0xDD,
                0xB5,
                0x16,
                0xB9
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowJobUISession
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x6B, 0x73, 0xC8, 0x00,
                0x37, 0x76,
                0x87, 0x56,
                0xA3,
                0x02,
                0x0F,
                0x66,
                0x4D,
                0x2A,
                0xAC,
                0x65
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowJobUISession2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x68, 0x93, 0x52, 0xA8,
                0x74, 0x91,
                0x78, 0x5C,
                0x9F,
                0xDB,
                0x89,
                0x4A,
                0x82,
                0xE9,
                0x2A,
                0xDA
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowObjectModelSourceFileContent
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x6A, 0x8A, 0x6C, 0xC3,
                0x2A, 0x8A,
                0x9A, 0x41,
                0xB3,
                0xC3,
                0x20,
                0x90,
                0xE6,
                0xBF,
                0xAB,
                0x2F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowObjectModelSourceFileContentFactory
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x03, 0xB9, 0xB1, 0x93,
                0x13, 0xF0,
                0xD6, 0x56,
                0xB7,
                0x08,
                0x99,
                0xAC,
                0x2C,
                0xCB,
                0x12,
                0xEE
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowObjectModelTargetPackage
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x74, 0xBC, 0x96, 0x7D,
                0x54, 0x9B,
                0xA1, 0x4C,
                0xAD,
                0x3A,
                0x97,
                0x9C,
                0x3D,
                0x44,
                0xDD,
                0xAC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowPdlConverter
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x62, 0x4B, 0x60, 0x40,
                0xE4, 0x0A,
                0xF1, 0x51,
                0x81,
                0x8F,
                0x73,
                0x1D,
                0xC0,
                0xB0,
                0x05,
                0xAB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowPdlConverter2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xC1, 0xEE, 0x4C, 0x85,
                0x37, 0x78,
                0x93, 0x5B,
                0xB7,
                0xAF,
                0x57,
                0xA6,
                0x99,
                0x8C,
                0x2F,
                0x71
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowPdlDataAvailableEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x50, 0x6B, 0xAD, 0xD4,
                0x47, 0x15,
                0x91, 0x59,
                0xA0,
                0xEF,
                0xE2,
                0xEE,
                0x20,
                0x21,
                0x15,
                0x18
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowPdlModificationRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x61, 0x9A, 0x33, 0x1A,
                0x13, 0x2E,
                0xDD, 0x5E,
                0xA7,
                0x07,
                0xCE,
                0xEC,
                0x61,
                0xD7,
                0x33,
                0x3B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowPdlModificationRequestedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x47, 0x21, 0x69, 0x8D,
                0x62, 0x6C,
                0x31, 0x5E,
                0xA0,
                0xE7,
                0xD4,
                0x9F,
                0x92,
                0xC1,
                0x11,
                0xC0
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowPdlSourceContent
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x41, 0xFC, 0xF7, 0x92,
                0xB8, 0x32,
                0xAB, 0x56,
                0x84,
                0x5E,
                0xB1,
                0xE6,
                0x8B,
                0x3A,
                0xED,
                0xD5
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowPdlTargetStream
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xE5, 0xDF, 0x42, 0xA7,
                0xE3, 0x1E,
                0xA9, 0x52,
                0x9F,
                0x9F,
                0x2E,
                0x20,
                0x43,
                0x18,
                0x0F,
                0xD1
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowPrinterJob
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x94, 0x9F, 0x00, 0x12,
                0x14, 0x0D,
                0x43, 0x54,
                0xBC,
                0x09,
                0x25,
                0x03,
                0x11,
                0xCE,
                0x57,
                0x0B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowPrinterJob2
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xD7, 0x21, 0x7E, 0x74,
                0xA9, 0x69,
                0x29, 0x52,
                0xB8,
                0xF0,
                0x87,
                0x4C,
                0xA1,
                0xA8,
                0x87,
                0x1B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowSourceContent
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x41, 0xC6, 0x28, 0x1A,
                0xB1, 0xCE,
                0x33, 0x45,
                0xBB,
                0x73,
                0xFB,
                0xE6,
                0x3E,
                0xEF,
                0xDB,
                0x18
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowSpoolStreamContent
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xCE, 0x5E, 0xE5, 0x72,
                0x06, 0xE4,
                0x74, 0x4B,
                0x84,
                0xE1,
                0x3F,
                0xF3,
                0xFD,
                0xCD,
                0xAF,
                0x70
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowStreamTarget
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x84, 0xBA, 0x3B, 0xB2,
                0x65, 0x85,
                0x8B, 0x48,
                0x98,
                0x39,
                0x1C,
                0x9E,
                0x7C,
                0x7A,
                0xA9,
                0x16
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowSubmittedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x41, 0x0A, 0xDD, 0x3A,
                0x94, 0x37,
                0x69, 0x55,
                0x5C,
                0x87,
                0x40,
                0xE8,
                0xFF,
                0x72,
                0x0F,
                0x83
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowSubmittedOperation
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0x62, 0x4E, 0x2E,
                0xE1, 0x3B,
                0x0F, 0x5F,
                0x5C,
                0x81,
                0xA5,
                0xA2,
                0xBD,
                0x4E,
                0xAB,
                0x0E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowTarget
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x6C, 0x27, 0xDA, 0x29,
                0x73, 0x0A,
                0xED, 0x5A,
                0x4F,
                0x3D,
                0x97,
                0x0D,
                0x32,
                0x51,
                0xF0,
                0x57
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x68, 0xD8, 0x39, 0x57,
                0x86, 0x9D,
                0x52, 0x40,
                0xB0,
                0xCB,
                0xF3,
                0x10,
                0xBE,
                0xCD,
                0x59,
                0xBB
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowUIActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x84, 0x8A, 0xBC,
                0xEB, 0x09,
                0x46, 0x57,
                0x72,
                0xA6,
                0x8D,
                0xC8,
                0xB5,
                0xED,
                0xBE,
                0x9B
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowUILauncher
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x2F, 0xE2, 0xE9, 0x64,
                0xCC, 0x14,
                0x28, 0x58,
                0x96,
                0xFB,
                0x39,
                0x16,
                0x3F,
                0xB6,
                0xC3,
                0x78
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowVirtualPrinterDataAvailableEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x03, 0x50, 0x7D, 0x6B,
                0xA8, 0x14,
                0x52, 0x5D,
                0xA4,
                0x28,
                0x07,
                0x33,
                0x0F,
                0xBA,
                0xB1,
                0x1F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowVirtualPrinterSession
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xF2, 0x26, 0x39, 0xAA,
                0x85, 0x84,
                0x27, 0x5C,
                0xA0,
                0x16,
                0x9D,
                0x39,
                0xE3,
                0xBA,
                0x26,
                0x14
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowVirtualPrinterTriggerDetails
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x97, 0x22, 0x8F, 0xFF,
                0x7B, 0x72,
                0xEC, 0x53,
                0xB9,
                0xE0,
                0xF3,
                0x93,
                0xF7,
                0x2D,
                0x4E,
                0x50
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowVirtualPrinterUIEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0xCA, 0xBB, 0x4D, 0x33,
                0x10, 0xBF,
                0x5F, 0x58,
                0xB7,
                0xE0,
                0x58,
                0xC4,
                0xAA,
                0x43,
                0xA0,
                0x3F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPrintWorkflowXpsDataAvailableEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data = [
                0x31, 0xC3, 0x11, 0x4D,
                0xD1, 0x54,
                0x4E, 0x43,
                0xBE,
                0x0E,
                0x82,
                0xC5,
                0xFA,
                0x58,
                0xE5,
                0xB2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
