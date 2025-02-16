// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ICoreFrameworkInputView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0x94,
                0x7C,
                0xD7,
                0xB8,
                0x46,
                0x4A,
                0x5D,
                0x94,
                0x89,
                0x8D,
                0xDE,
                0xC3,
                0xD6,
                0x39,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreFrameworkInputViewAnimationStartingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0x90,
                0xEC,
                0xC0,
                0xA4,
                0xBB,
                0x1B,
                0x50,
                0xAE,
                0x8B,
                0x65,
                0xC9,
                0xE7,
                0x56,
                0xA7,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreFrameworkInputViewOcclusionsChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0x49,
                0x6F,
                0xF3,
                0x2C,
                0xC8,
                0xD1,
                0x53,
                0xA7,
                0x5D,
                0x2B,
                0x2B,
                0xAF,
                0x0D,
                0x9B,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreFrameworkInputViewStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0xD9,
                0xEB,
                0x6E,
                0xC2,
                0xEA,
                0x8B,
                0x5F,
                0x97,
                0x5F,
                0x77,
                0x2E,
                0xE3,
                0xE4,
                0x2E,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0xCD,
                0x70,
                0xC7,
                0x01,
                0x70,
                0x32,
                0x4C,
                0xBF,
                0x94,
                0x25,
                0xC1,
                0xF5,
                0x54,
                0xCB,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputView2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC1,
                0x26,
                0xD7,
                0x0E,
                0x9A,
                0xE0,
                0xE8,
                0x4A,
                0xAE,
                0xDF,
                0xDF,
                0xA4,
                0x85,
                0x7D,
                0x1A,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputView3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x16,
                0x94,
                0xBC,
                0xB9,
                0x3A,
                0x49,
                0x48,
                0x8F,
                0x58,
                0x46,
                0xE7,
                0xF0,
                0x35,
                0x3C,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputView4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x63,
                0x28,
                0x00,
                0xEF,
                0xD9,
                0xEB,
                0x57,
                0x8C,
                0xEF,
                0x77,
                0xF6,
                0xCE,
                0x1B,
                0x7E,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputView5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x16,
                0x63,
                0x13,
                0xD5,
                0xC6,
                0x57,
                0x5C,
                0x81,
                0x1E,
                0x1A,
                0xD8,
                0xA9,
                0x9B,
                0xA6,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputViewAnimationStartingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x4A,
                0x14,
                0xA9,
                0x5C,
                0xB5,
                0xA1,
                0x5E,
                0xB8,
                0xAB,
                0x53,
                0x40,
                0xF3,
                0xE9,
                0x48,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputViewHidingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x47,
                0xDA,
                0xEA,
                0xC5,
                0xBA,
                0x36,
                0x53,
                0x84,
                0x8D,
                0x41,
                0x08,
                0x35,
                0x84,
                0xDA,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputViewOcclusion
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xCE,
                0x36,
                0xCC,
                0x65,
                0x38,
                0x77,
                0x41,
                0xB5,
                0xF5,
                0x8B,
                0x65,
                0xE0,
                0xB9,
                0xCE,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputViewOcclusionsChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x27,
                0x10,
                0xBE,
                0xEE,
                0xB3,
                0xF7,
                0x4D,
                0x95,
                0x54,
                0x89,
                0xCD,
                0xC6,
                0x60,
                0x82,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputViewShowingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x26,
                0x52,
                0xCA,
                0x9E,
                0xFB,
                0xAF,
                0x5D,
                0xA9,
                0x8C,
                0x26,
                0x2B,
                0x8B,
                0x76,
                0xAF,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputViewStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x97,
                0x9B,
                0x7D,
                0xBE,
                0xED,
                0xCF,
                0x49,
                0xA5,
                0x4F,
                0x33,
                0x7D,
                0xE0,
                0x52,
                0x90,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputViewStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x62,
                0x08,
                0xBC,
                0x7E,
                0x49,
                0xD0,
                0x52,
                0x4E,
                0x87,
                0xB0,
                0x1E,
                0x90,
                0xE9,
                0x8C,
                0x49,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICoreInputViewTransferringXYFocusEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x16,
                0xDE,
                0x04,
                0x02,
                0xBA,
                0x50,
                0x48,
                0x8B,
                0x55,
                0xD8,
                0x2D,
                0x03,
                0xBA,
                0x6D,
                0x7F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettingsController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0x1A,
                0xA5,
                0x78,
                0xC0,
                0x15,
                0x1B,
                0x5A,
                0xA7,
                0x5B,
                0xAC,
                0xBF,
                0x9C,
                0xB8,
                0xBB,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettingsControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x68,
                0x3C,
                0xEB,
                0x20,
                0xC2,
                0x8C,
                0x57,
                0x81,
                0x19,
                0x7D,
                0xB3,
                0x24,
                0xED,
                0x26,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
