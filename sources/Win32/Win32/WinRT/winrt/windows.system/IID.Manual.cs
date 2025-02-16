// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDispatcherQueueHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0xDC,
                0xA2,
                0xDF,
                0x2D,
                0x1A,
                0x17,
                0x49,
                0x98,
                0xF2,
                0x93,
                0x9A,
                0xF1,
                0xD6,
                0xE0,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppActivationResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x89,
                0x52,
                0x6B,
                0x6E,
                0xF4,
                0xB0,
                0x4E,
                0xAA,
                0x6C,
                0x38,
                0xAF,
                0x55,
                0x7C,
                0xF9,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppDiagnosticInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0xA6,
                0x48,
                0xE3,
                0x89,
                0x88,
                0xA3,
                0x4C,
                0xBE,
                0x07,
                0xD5,
                0xFF,
                0xFF,
                0x5F,
                0x08,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppDiagnosticInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0xFB,
                0x46,
                0xDF,
                0x1A,
                0x19,
                0x6C,
                0x44,
                0x94,
                0x73,
                0x8F,
                0xBC,
                0x23,
                0x74,
                0xA3,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppDiagnosticInfo3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0xC6,
                0x95,
                0xC8,
                0x61,
                0xDD,
                0x65,
                0x4C,
                0xBA,
                0xBD,
                0x81,
                0xA1,
                0x0B,
                0x4F,
                0x98,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppDiagnosticInfoStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x25,
                0x69,
                0xCE,
                0xCA,
                0x10,
                0xC8,
                0x40,
                0xA9,
                0xCA,
                0xC5,
                0xC9,
                0x65,
                0x01,
                0x86,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppDiagnosticInfoStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x4B,
                0xB2,
                0x05,
                0x00,
                0x10,
                0x90,
                0x4C,
                0xBB,
                0x9F,
                0x72,
                0x35,
                0x07,
                0x1C,
                0x50,
                0xFE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppDiagnosticInfoWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x50,
                0x57,
                0x75,
                0xD3,
                0x01,
                0x9A,
                0x48,
                0x93,
                0x25,
                0x52,
                0xF9,
                0xCC,
                0x6E,
                0xDE,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppDiagnosticInfoWatcherEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0xC7,
                0x17,
                0x70,
                0xDA,
                0xE1,
                0x65,
                0x4C,
                0x99,
                0xDF,
                0x04,
                0x6D,
                0xFF,
                0x5B,
                0xE7,
                0x1A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppExecutionStateChangeResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x9B,
                0x03,
                0x6F,
                0x1B,
                0xF9,
                0xF8,
                0x4D,
                0xAE,
                0x77,
                0x30,
                0x33,
                0xCC,
                0xB6,
                0x91,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppMemoryReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x33,
                0x65,
                0x6D,
                0x6F,
                0x4D,
                0xBC,
                0x45,
                0x9C,
                0x5E,
                0xE4,
                0x9B,
                0x3F,
                0xF2,
                0x75,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppMemoryReport2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0x37,
                0x7F,
                0x5F,
                0xB7,
                0x51,
                0xDC,
                0x42,
                0xB7,
                0xED,
                0x79,
                0xBA,
                0x46,
                0xD2,
                0x88,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppMemoryUsageLimitChangingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x66,
                0xF8,
                0x79,
                0xCA,
                0xFE,
                0xA5,
                0x4D,
                0x9E,
                0x40,
                0x2B,
                0xC6,
                0x3E,
                0xFD,
                0xC9,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppResourceGroupBackgroundTaskReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0xE7,
                0x66,
                0x25,
                0x5D,
                0xB0,
                0xC2,
                0x40,
                0x9D,
                0xC1,
                0x1A,
                0x4F,
                0x03,
                0x9E,
                0xA1,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppResourceGroupInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0xF7,
                0x13,
                0xB9,
                0x07,
                0xE8,
                0xF4,
                0x49,
                0x84,
                0x5E,
                0x7B,
                0x8B,
                0xDC,
                0xFE,
                0x8E,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppResourceGroupInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6D,
                0x23,
                0x9B,
                0xEE,
                0x05,
                0xD3,
                0x6B,
                0x4D,
                0x92,
                0xF7,
                0x6A,
                0xFD,
                0xAD,
                0x72,
                0xDE,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppResourceGroupInfoWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0xA0,
                0xB0,
                0xD9,
                0x5A,
                0x6E,
                0x72,
                0x4C,
                0x8B,
                0x17,
                0x09,
                0xFE,
                0xC4,
                0xA2,
                0x12,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppResourceGroupInfoWatcherEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x37,
                0x76,
                0x78,
                0x7A,
                0x02,
                0x63,
                0x2F,
                0x4D,
                0xBF,
                0x89,
                0x1C,
                0x12,
                0xD0,
                0xB2,
                0xA6,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0xED,
                0xDB,
                0x1B,
                0xE6,
                0xFE,
                0xD4,
                0x4F,
                0x98,
                0xDD,
                0xE9,
                0x2A,
                0x2C,
                0xC2,
                0x99,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppResourceGroupMemoryReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x06,
                0x8C,
                0x2C,
                0xB1,
                0x7D,
                0x51,
                0x4C,
                0xA2,
                0x25,
                0x7F,
                0xAE,
                0x2D,
                0x49,
                0xE4,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppResourceGroupStateReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x9F,
                0x84,
                0x52,
                0x70,
                0x2F,
                0x36,
                0x42,
                0xAB,
                0x40,
                0xD0,
                0x4D,
                0xB0,
                0xC7,
                0xB9,
                0x31,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppUriHandlerHost
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0xCA,
                0x50,
                0x5D,
                0xD2,
                0x92,
                0x09,
                0x54,
                0xB5,
                0x6F,
                0x7F,
                0x73,
                0xE1,
                0x0E,
                0xA4,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppUriHandlerHost2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0xEE,
                0x0B,
                0x3A,
                0xE4,
                0x29,
                0xBF,
                0x51,
                0x80,
                0x95,
                0xA3,
                0xC0,
                0x68,
                0xE3,
                0xC7,
                0x2A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppUriHandlerHostFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x3C,
                0x7C,
                0x25,
                0x04,
                0xCE,
                0x98,
                0x5F,
                0x96,
                0xBB,
                0x3E,
                0xBD,
                0x3E,
                0x92,
                0x75,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppUriHandlerRegistration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0xAE,
                0x73,
                0x6F,
                0x69,
                0x45,
                0x3F,
                0x5C,
                0x9B,
                0xA0,
                0x99,
                0x12,
                0x3E,
                0xEA,
                0x32,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppUriHandlerRegistration2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x97,
                0xAC,
                0x4D,
                0xD5,
                0x39,
                0xCB,
                0x1F,
                0x5F,
                0x88,
                0x3E,
                0x01,
                0x85,
                0x37,
                0x30,
                0xBD,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppUriHandlerRegistrationManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x9A,
                0x2C,
                0xE6,
                0x94,
                0xAC,
                0x50,
                0x57,
                0xAC,
                0x1B,
                0x6C,
                0xFB,
                0x6F,
                0x25,
                0x02,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppUriHandlerRegistrationManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0xCA,
                0xDF,
                0xBD,
                0x1A,
                0xB5,
                0x69,
                0x5E,
                0xAE,
                0xFD,
                0x70,
                0x88,
                0xD9,
                0xF2,
                0xB1,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppUriHandlerRegistrationManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0xDD,
                0xCE,
                0xD5,
                0x29,
                0x57,
                0x76,
                0x5B,
                0xA1,
                0xD4,
                0x02,
                0x85,
                0xF2,
                0x95,
                0xC1,
                0x24,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppUriHandlerRegistrationManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x83,
                0xF7,
                0x14,
                0x90,
                0x68,
                0x80,
                0x50,
                0x90,
                0xA7,
                0x98,
                0x82,
                0x4A,
                0x7F,
                0x07,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDateTimeSettingsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x50,
                0x21,
                0x5D,
                0xEE,
                0x47,
                0xAB,
                0x48,
                0xA5,
                0x2B,
                0x9F,
                0x19,
                0x54,
                0x27,
                0x8D,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDispatcherQueue
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x88,
                0x3E,
                0x60,
                0x38,
                0xA3,
                0xFE,
                0x4F,
                0xA4,
                0x57,
                0xA5,
                0xCF,
                0xB9,
                0xCE,
                0xB8,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDispatcherQueue2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0xC6,
                0x22,
                0xC8,
                0xEF,
                0x30,
                0x6E,
                0x50,
                0xBD,
                0x1E,
                0xA6,
                0x47,
                0xAE,
                0x66,
                0x75,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDispatcherQueueController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x4E,
                0xF3,
                0x22,
                0xDB,
                0x50,
                0x36,
                0x4E,
                0xA9,
                0x8D,
                0x61,
                0xC0,
                0x1B,
                0x38,
                0x4D,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDispatcherQueueControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x98,
                0x6C,
                0x0A,
                0x98,
                0x51,
                0xA2,
                0x49,
                0xA3,
                0x13,
                0x3F,
                0x70,
                0xD1,
                0xF1,
                0x3C,
                0x27,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDispatcherQueueShutdownStartingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x4C,
                0x72,
                0xC4,
                0x97,
                0xFF,
                0xC0,
                0x40,
                0xA2,
                0x26,
                0xCC,
                0x0A,
                0xAA,
                0x54,
                0x5E,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDispatcherQueueStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x83,
                0x6D,
                0xA9,
                0x71,
                0x93,
                0x17,
                0x45,
                0x92,
                0x45,
                0xD0,
                0x82,
                0x4A,
                0xC1,
                0x2C,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDispatcherQueueTimer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0xBB,
                0xEA,
                0x5F,
                0x1C,
                0xA3,
                0x27,
                0x47,
                0xB1,
                0xAC,
                0x37,
                0x45,
                0x46,
                0x49,
                0xD5,
                0x6A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFolderLauncherOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xC2,
                0x91,
                0xBB,
                0x87,
                0x6B,
                0x2A,
                0x43,
                0xBD,
                0x04,
                0x77,
                0x6C,
                0x6F,
                0x5F,
                0xB2,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownUserPropertiesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1A,
                0x91,
                0x55,
                0x77,
                0xC5,
                0x70,
                0xE5,
                0x48,
                0xB6,
                0x37,
                0x5B,
                0xA3,
                0x44,
                0x1E,
                0x4E,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKnownUserPropertiesStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x82,
                0x07,
                0x45,
                0x5B,
                0x20,
                0xF6,
                0x7E,
                0x57,
                0xB1,
                0xB3,
                0xDD,
                0x56,
                0x64,
                0x4D,
                0x79,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILaunchUriResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0xA8,
                0x27,
                0xEC,
                0xD5,
                0xF6,
                0xCA,
                0x45,
                0x91,
                0x3A,
                0x70,
                0xA4,
                0x0C,
                0x5C,
                0x82,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x21,
                0xFA,
                0xBA,
                0x71,
                0xB0,
                0xD8,
                0x4C,
                0x85,
                0x3E,
                0x34,
                0x12,
                0x03,
                0xE5,
                0x57,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherOptions2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x8E,
                0xA0,
                0x3B,
                0x40,
                0x6E,
                0xCE,
                0x4D,
                0xA1,
                0xA3,
                0x2F,
                0x53,
                0x95,
                0x0A,
                0xFB,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherOptions3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x06,
                0x77,
                0xF0,
                0x63,
                0x4B,
                0x3A,
                0x4E,
                0x91,
                0x07,
                0x4E,
                0x68,
                0x78,
                0x41,
                0x92,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherOptions4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0xD1,
                0x6F,
                0xEF,
                0xFB,
                0xE6,
                0x14,
                0x48,
                0xA4,
                0x4E,
                0x57,
                0xE8,
                0xB9,
                0xD9,
                0xA0,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x51,
                0x71,
                0x27,
                0x3E,
                0x9E,
                0xF6,
                0x42,
                0x91,
                0xA4,
                0x5D,
                0xFD,
                0xEB,
                0x23,
                0x24,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x2F,
                0xBA,
                0x59,
                0xCB,
                0x24,
                0x02,
                0x4C,
                0xA4,
                0xC4,
                0x82,
                0x94,
                0x56,
                0x9D,
                0x54,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x61,
                0x42,
                0x23,
                0xB3,
                0x9D,
                0x83,
                0x46,
                0xAA,
                0x42,
                0xDC,
                0x6F,
                0x51,
                0xD3,
                0x38,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x81,
                0xEC,
                0xB9,
                0xA5,
                0xB5,
                0xC6,
                0x41,
                0xB3,
                0xB3,
                0xDD,
                0x1B,
                0x31,
                0x78,
                0xBC,
                0xF2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherStatics5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0xEF,
                0x24,
                0x5B,
                0x95,
                0xD8,
                0xEA,
                0x5F,
                0x91,
                0x53,
                0x1A,
                0xC4,
                0x9A,
                0xED,
                0x9B,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherUIOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0xDA,
                0x25,
                0x1B,
                0xA6,
                0x8A,
                0xE9,
                0x41,
                0x82,
                0x51,
                0x41,
                0x65,
                0xF5,
                0x98,
                0x5F,
                0x49,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILauncherViewOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0x29,
                0x9B,
                0x8A,
                0xA7,
                0x7C,
                0xDE,
                0x49,
                0x9B,
                0xD3,
                0x3C,
                0x5B,
                0x71,
                0x84,
                0xF6,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMemoryManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0x27,
                0x6C,
                0x5C,
                0xCA,
                0xD7,
                0x79,
                0x47,
                0x91,
                0x88,
                0x40,
                0x57,
                0x21,
                0x9C,
                0xE6,
                0x4C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMemoryManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x35,
                0xEE,
                0x6E,
                0x62,
                0x6D,
                0x3F,
                0x42,
                0x94,
                0x79,
                0xB0,
                0x1F,
                0x9C,
                0x9F,
                0x76,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMemoryManagerStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x59,
                0x9B,
                0x14,
                0xAD,
                0x92,
                0x35,
                0x4E,
                0x89,
                0xEB,
                0x50,
                0xDF,
                0xB4,
                0xC0,
                0xD9,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMemoryManagerStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x48,
                0xA9,
                0xC5,
                0x4E,
                0xE8,
                0x86,
                0x48,
                0x8A,
                0x0D,
                0x44,
                0xB3,
                0x19,
                0x0E,
                0x3B,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessLauncherOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0xB9,
                0x80,
                0x30,
                0x44,
                0xF4,
                0x83,
                0x4A,
                0xBE,
                0xAF,
                0xA5,
                0x49,
                0xA0,
                0xF3,
                0x22,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessLauncherResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x89,
                0x4C,
                0x54,
                0xD8,
                0x86,
                0x91,
                0x49,
                0x8E,
                0x75,
                0xEC,
                0xE8,
                0xA4,
                0x3B,
                0x6B,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessLauncherStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x66,
                0xAB,
                0x33,
                0x0E,
                0x2D,
                0x8B,
                0x44,
                0xA6,
                0xA0,
                0xC1,
                0x3C,
                0x38,
                0x36,
                0xD0,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessMemoryReport
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x05,
                0x73,
                0x08,
                0x70,
                0x9B,
                0x82,
                0x47,
                0x87,
                0x41,
                0x3A,
                0x98,
                0x2B,
                0x6C,
                0xE5,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProtocolForResultsOperation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x29,
                0x81,
                0xD5,
                0xE9,
                0x6D,
                0x28,
                0x4D,
                0x93,
                0x78,
                0xF8,
                0x67,
                0x82,
                0xE1,
                0x82,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteLauncherOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x27,
                0x3A,
                0x9E,
                0x91,
                0x28,
                0xDF,
                0x4C,
                0xA2,
                0xD6,
                0x9D,
                0xFF,
                0x7D,
                0x02,
                0xE6,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRemoteLauncherStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0x7A,
                0xDB,
                0xD7,
                0x0C,
                0xA3,
                0xB7,
                0x48,
                0x9F,
                0x21,
                0x05,
                0x10,
                0x26,
                0xA4,
                0xE5,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShutdownManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x47,
                0xE2,
                0x72,
                0x5B,
                0xDD,
                0x6C,
                0x4D,
                0xB1,
                0xD0,
                0xC5,
                0x7A,
                0x7B,
                0xBB,
                0x5F,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShutdownManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0xA0,
                0x69,
                0x0F,
                0x34,
                0x9C,
                0xC7,
                0x43,
                0xA8,
                0xC3,
                0x70,
                0xB3,
                0x0A,
                0x7F,
                0x75,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimeZoneSettingsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x2B,
                0x3B,
                0x9B,
                0x01,
                0xA1,
                0xAE,
                0x41,
                0x9F,
                0xBD,
                0x02,
                0x87,
                0x28,
                0xBA,
                0xB7,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITimeZoneSettingsStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0x0D,
                0x5C,
                0x55,
                0xA8,
                0x39,
                0xFA,
                0x49,
                0xB4,
                0xF6,
                0xA2,
                0xC7,
                0xFC,
                0x28,
                0x42,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUser
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x26,
                0x9A,
                0xDF,
                0x46,
                0xE7,
                0xCD,
                0x4B,
                0xB5,
                0xD4,
                0x12,
                0x01,
                0x03,
                0xC4,
                0x20,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUser2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x56,
                0xBA,
                0x98,
                0xE3,
                0xA6,
                0x8E,
                0x51,
                0x89,
                0xD9,
                0xD3,
                0xB2,
                0xB1,
                0x99,
                0x1A,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserAuthenticationStatusChangeDeferral
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x95,
                0xB5,
                0x88,
                0x30,
                0xBB,
                0xFB,
                0x42,
                0xA2,
                0x70,
                0xE9,
                0x90,
                0x2E,
                0x40,
                0xEF,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserAuthenticationStatusChangingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x0F,
                0x03,
                0x8C,
                0x11,
                0xA7,
                0x1E,
                0x4C,
                0xAB,
                0x48,
                0x04,
                0x17,
                0x9C,
                0x15,
                0x93,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x59,
                0x64,
                0x08,
                0xC6,
                0x18,
                0xDB,
                0x48,
                0xBC,
                0x99,
                0x72,
                0x4F,
                0xB9,
                0x20,
                0x3C,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserChangedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x44,
                0xCB,
                0x2C,
                0x6B,
                0x01,
                0x6F,
                0x0C,
                0x56,
                0x97,
                0xAD,
                0xFC,
                0x7F,
                0x32,
                0xEC,
                0x58,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDeviceAssociationChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x6F,
                0x1F,
                0xBD,
                0x5D,
                0xBB,
                0x7B,
                0x4D,
                0xA5,
                0xF0,
                0xC8,
                0xCD,
                0x11,
                0xA3,
                0x8D,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserDeviceAssociationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0x1E,
                0x49,
                0x7E,
                0x5A,
                0xF8,
                0x07,
                0x4C,
                0x8D,
                0xA9,
                0x7F,
                0xE3,
                0xD0,
                0x54,
                0x23,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserPicker
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x80,
                0x54,
                0x7D,
                0xE3,
                0xF1,
                0x6C,
                0x4A,
                0x8D,
                0xDC,
                0xA9,
                0xBB,
                0x0F,
                0x48,
                0x8A,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserPickerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x90,
                0x32,
                0xDE,
                0x73,
                0x7E,
                0xF6,
                0x4D,
                0xA1,
                0xAE,
                0x4D,
                0x7E,
                0xCA,
                0x82,
                0xB4,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0xB2,
                0x5E,
                0x15,
                0x2A,
                0x24,
                0xE0,
                0x45,
                0xA2,
                0xE9,
                0x31,
                0x71,
                0xFC,
                0x6A,
                0x7F,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0x7E,
                0xA3,
                0x74,
                0xB5,
                0x2E,
                0x87,
                0x44,
                0xB0,
                0xD5,
                0x2C,
                0x67,
                0x90,
                0xE0,
                0x13,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUserWatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0xB2,
                0x5E,
                0x15,
                0x2A,
                0x24,
                0xE0,
                0x45,
                0xA2,
                0xE9,
                0x31,
                0x71,
                0xFC,
                0x6A,
                0x7F,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
