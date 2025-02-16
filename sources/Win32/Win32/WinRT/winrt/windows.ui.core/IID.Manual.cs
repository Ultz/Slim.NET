// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IDispatchedHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0x76,
                0xF2,
                0xD1,
                0xD8,
                0x98,
                0x36,
                0x46,
                0xBF,
                0x49,
                0xEB,
                0x79,
                0x50,
                0x75,
                0x48,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIdleDispatchedHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x0C,
                0x2B,
                0xA4,
                0x21,
                0x7F,
                0xBC,
                0x4A,
                0x99,
                0xC1,
                0x8F,
                0x01,
                0x00,
                0x7F,
                0x08,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAcceleratorKeyEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x4C,
                0x1C,
                0xFF,
                0x87,
                0x92,
                0x0B,
                0x47,
                0x83,
                0x6E,
                0x90,
                0x86,
                0xE3,
                0x12,
                0x6A,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAcceleratorKeyEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0xA9,
                0x00,
                0xD3,
                0x7E,
                0x2F,
                0x73,
                0x48,
                0xA5,
                0x55,
                0x16,
                0x6E,
                0x59,
                0x6E,
                0xE1,
                0xC5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAutomationProviderRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xF2,
                0x1F,
                0x96,
                0xBF,
                0x21,
                0x42,
                0x4B,
                0xA2,
                0x98,
                0xFA,
                0x47,
                0x9D,
                0x4C,
                0x52,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0xD2,
                0x03,
                0xD6,
                0x11,
                0xE4,
                0x4E,
                0x4A,
                0xBA,
                0x41,
                0x6A,
                0x32,
                0x7A,
                0x86,
                0x75,
                0xBC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICharacterReceivedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x65,
                0x84,
                0xC5,
                0xB2,
                0x99,
                0xCC,
                0x4B,
                0xBD,
                0x33,
                0x04,
                0xE6,
                0x3F,
                0x42,
                0x90,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IClosestInteractiveBoundsRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x11,
                0x7C,
                0x34,
                0xF8,
                0xF6,
                0xE3,
                0x40,
                0xB2,
                0x9F,
                0xAE,
                0x50,
                0xD3,
                0xE8,
                0x64,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreAcceleratorKeys
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF5,
                0xF7,
                0xFD,
                0x9F,
                0xC9,
                0xB8,
                0xF0,
                0x4E,
                0xB7,
                0xD2,
                0x1D,
                0xE6,
                0x26,
                0x56,
                0x1F,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreClosestInteractiveBoundsRequested
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x04,
                0x03,
                0xF3,
                0xBF,
                0xE8,
                0x8E,
                0x4E,
                0xAE,
                0x69,
                0xC9,
                0xDA,
                0xDD,
                0x57,
                0xA1,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreComponentFocusable
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x6F,
                0xF9,
                0x52,
                0x42,
                0x87,
                0x11,
                0x44,
                0xAE,
                0x69,
                0x79,
                0xA8,
                0x5F,
                0x29,
                0xAC,
                0x8B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreCursor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x3A,
                0x89,
                0x96,
                0x1D,
                0x11,
                0x2C,
                0x44,
                0x8A,
                0x77,
                0xB8,
                0x79,
                0x92,
                0xF8,
                0xE2,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreCursorFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x21,
                0x96,
                0x35,
                0xF6,
                0x9D,
                0xA7,
                0xD3,
                0x4E,
                0x8C,
                0x32,
                0xA9,
                0xEF,
                0x9D,
                0x6B,
                0x76,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreDispatcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x2F,
                0xDB,
                0x60,
                0x05,
                0xB7,
                0xDE,
                0x4F,
                0xA7,
                0xD6,
                0xEB,
                0xBB,
                0x18,
                0x91,
                0xD3,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreDispatcher2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x63,
                0x5E,
                0x6F,
                0xAA,
                0xE3,
                0xAE,
                0x4E,
                0xB0,
                0xE0,
                0xDC,
                0xF3,
                0x21,
                0xCA,
                0x4B,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreDispatcherWithTaskPriority
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0xEC,
                0xFA,
                0xBA,
                0x4D,
                0x48,
                0xBE,
                0x41,
                0xBA,
                0x80,
                0x1D,
                0x58,
                0xC6,
                0x52,
                0x63,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreIndependentInputSourceController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x26,
                0x63,
                0x09,
                0xFE,
                0x84,
                0x8A,
                0x57,
                0x83,
                0xCA,
                0x64,
                0x25,
                0x30,
                0x9C,
                0xCD,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreIndependentInputSourceControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x4E,
                0xDC,
                0x3E,
                0x8A,
                0x9A,
                0x91,
                0x56,
                0x85,
                0x86,
                0xFC,
                0xA4,
                0xCB,
                0x57,
                0x52,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputSourceBase
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x88,
                0x48,
                0x9F,
                0x80,
                0x45,
                0xE8,
                0x4B,
                0xBE,
                0x68,
                0x92,
                0xA9,
                0x31,
                0x17,
                0x13,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreKeyboardInputSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0x90,
                0x1C,
                0x23,
                0x69,
                0xE4,
                0xF1,
                0x4D,
                0xB2,
                0x08,
                0x6E,
                0x49,
                0x0D,
                0x71,
                0xCB,
                0x90,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreKeyboardInputSource2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0xCB,
                0x24,
                0xFA,
                0x63,
                0xF9,
                0xA5,
                0x47,
                0x87,
                0x78,
                0x20,
                0x7C,
                0x48,
                0x2B,
                0x0A,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICorePointerInputSource
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0xBB,
                0xF1,
                0xBB,
                0x7A,
                0xE4,
                0xEB,
                0x48,
                0x88,
                0x07,
                0xF8,
                0xF8,
                0xD3,
                0xEA,
                0x45,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICorePointerInputSource2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0x70,
                0x03,
                0xD7,
                0x16,
                0x45,
                0x86,
                0x47,
                0xB1,
                0xE5,
                0x27,
                0x51,
                0xD5,
                0x63,
                0xF9,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICorePointerRedirector
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x0C,
                0x9D,
                0x8F,
                0x88,
                0x56,
                0x0C,
                0x4B,
                0xA9,
                0xF1,
                0xF9,
                0x31,
                0xF7,
                0xFA,
                0x3D,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreTouchHitTesting
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xA2,
                0xD8,
                0xB1,
                0xCF,
                0x3A,
                0x24,
                0x41,
                0x9F,
                0xA3,
                0xEA,
                0x8A,
                0xBA,
                0x35,
                0x3C,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindow
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0xD5,
                0xB9,
                0x79,
                0x9E,
                0x87,
                0x89,
                0x4B,
                0xB7,
                0x98,
                0x79,
                0xE4,
                0x75,
                0x98,
                0x03,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindow2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x1B,
                0x2B,
                0x7C,
                0x17,
                0x69,
                0x61,
                0x43,
                0x9C,
                0x02,
                0x0D,
                0x9E,
                0x3A,
                0x42,
                0x0B,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindow3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x0D,
                0xC2,
                0x32,
                0xEF,
                0xFA,
                0x75,
                0x43,
                0xA2,
                0xAB,
                0x32,
                0x64,
                0x0E,
                0x48,
                0x15,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindow4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xF0,
                0xCA,
                0x35,
                0xF0,
                0x47,
                0x6C,
                0x43,
                0xAF,
                0x97,
                0x0D,
                0xD8,
                0x8F,
                0x6F,
                0x5F,
                0x02,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindow5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0xE1,
                0x4A,
                0x4B,
                0x6D,
                0x2E,
                0xAA,
                0x4E,
                0xBD,
                0xA1,
                0x1C,
                0x5C,
                0xC1,
                0xBE,
                0xE1,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowDialog
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x2C,
                0x39,
                0xE7,
                0x8D,
                0xC7,
                0x7E,
                0x42,
                0x8B,
                0x2C,
                0x01,
                0xFF,
                0x42,
                0x0C,
                0x69,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowDialogFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0xA8,
                0xB2,
                0xCF,
                0x59,
                0x1C,
                0x13,
                0x4B,
                0xB1,
                0xE5,
                0x16,
                0xE2,
                0x98,
                0x05,
                0xF7,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF3,
                0x1E,
                0x2B,
                0x27,
                0x33,
                0xC6,
                0xA5,
                0x4D,
                0xA2,
                0x6C,
                0xC6,
                0xD0,
                0xF5,
                0x6B,
                0x29,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowFlyout
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x85,
                0x9D,
                0xE8,
                0x50,
                0x20,
                0xBB,
                0x40,
                0xB3,
                0x44,
                0xF6,
                0xF3,
                0x55,
                0xEE,
                0xB3,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowFlyoutFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0xC6,
                0xC4,
                0xDE,
                0xE8,
                0x93,
                0x7C,
                0x4F,
                0xBE,
                0x27,
                0xCE,
                0xFA,
                0xA1,
                0xAF,
                0x68,
                0xA7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowPopupShowingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x5F,
                0x15,
                0x26,
                0xA5,
                0x5B,
                0xA4,
                0x4E,
                0xA3,
                0xB4,
                0x2D,
                0xC7,
                0xD6,
                0x3C,
                0x8E,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowResizeManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0xB9,
                0xF0,
                0xB8,
                0x50,
                0xB3,
                0xB3,
                0x48,
                0xA1,
                0x98,
                0x5C,
                0x1A,
                0x84,
                0x70,
                0x02,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowResizeManagerLayoutCapability
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xF2,
                0x74,
                0xBB,
                0x44,
                0xA5,
                0x01,
                0x43,
                0x80,
                0xE6,
                0x0A,
                0xE0,
                0x33,
                0xEF,
                0x45,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowResizeManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0x90,
                0x4A,
                0xAE,
                0x70,
                0x6D,
                0xDB,
                0x49,
                0x8E,
                0x68,
                0x46,
                0xFF,
                0xBD,
                0x17,
                0xD3,
                0x8D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowStatic
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x90,
                0x23,
                0x4D,
                0x2A,
                0x3C,
                0xB1,
                0x41,
                0x90,
                0x22,
                0x53,
                0x6B,
                0xB9,
                0xCF,
                0x93,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreWindowWithContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0x02,
                0xC4,
                0x9A,
                0x75,
                0x35,
                0x3B,
                0x4C,
                0xAF,
                0x66,
                0xE8,
                0xC5,
                0x29,
                0xD4,
                0xD0,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIdleDispatchedHandlerArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x6A,
                0xBB,
                0x98,
                0x1C,
                0xDC,
                0xCB,
                0x43,
                0xB4,
                0xED,
                0xD1,
                0xC0,
                0xEB,
                0x23,
                0x91,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInitializeWithCoreWindow
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x20,
                0x8F,
                0x18,
                0x73,
                0x98,
                0x4A,
                0x46,
                0xAC,
                0xE5,
                0x57,
                0xE0,
                0x10,
                0xF4,
                0x65,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputEnabledEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0x1D,
                0x37,
                0x80,
                0xD8,
                0x2F,
                0x24,
                0x4C,
                0xAA,
                0x86,
                0x31,
                0x63,
                0xA8,
                0x7B,
                0x4E,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x30,
                0xE9,
                0xF5,
                0x5F,
                0x44,
                0x25,
                0x17,
                0x4A,
                0xBD,
                0x78,
                0x1F,
                0x2F,
                0xDE,
                0xBB,
                0x10,
                0x6B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0xDD,
                0x3A,
                0x58,
                0x90,
                0x07,
                0x71,
                0x45,
                0x9B,
                0x12,
                0x64,
                0x5E,
                0xF9,
                0xD7,
                0x9E,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointerEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x9C,
                0x0D,
                0x92,
                0xFC,
                0xA5,
                0x21,
                0x4A,
                0x8C,
                0x09,
                0x49,
                0xDF,
                0xE6,
                0xFF,
                0xE2,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemNavigationManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x18,
                0x31,
                0x02,
                0x93,
                0x50,
                0xCF,
                0xA6,
                0x42,
                0x97,
                0x06,
                0x69,
                0x10,
                0x7F,
                0xA1,
                0x22,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemNavigationManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x04,
                0x51,
                0x8C,
                0xBE,
                0x67,
                0xAE,
                0x49,
                0x95,
                0x09,
                0x67,
                0x1C,
                0x1E,
                0x54,
                0xA3,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISystemNavigationManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0xB5,
                0x52,
                0xDC,
                0xE0,
                0xBE,
                0x05,
                0x43,
                0x8C,
                0x54,
                0x68,
                0x22,
                0x8E,
                0xD6,
                0x83,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITouchHitTestingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0xB8,
                0xF3,
                0x22,
                0x7C,
                0x0B,
                0x4E,
                0x42,
                0x9D,
                0xF7,
                0x33,
                0xD4,
                0xF9,
                0x62,
                0x93,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisibilityChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x18,
                0x99,
                0xBF,
                0x01,
                0xD8,
                0x64,
                0x45,
                0xA4,
                0x95,
                0xB1,
                0xE8,
                0x4F,
                0x8A,
                0xD0,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWindowActivatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE7,
                0x65,
                0x9D,
                0x17,
                0x58,
                0x46,
                0xB6,
                0x4C,
                0xAA,
                0x13,
                0x41,
                0xD0,
                0x94,
                0xEA,
                0x25,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWindowSizeChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x0E,
                0x20,
                0x5A,
                0x26,
                0x04,
                0xDC,
                0x47,
                0xB8,
                0x6C,
                0x6F,
                0x47,
                0x59,
                0x15,
                0xE4,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
