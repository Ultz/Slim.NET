// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAccessibilitySettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x81,
                0x0E,
                0xFE,
                0xC0,
                0xC4,
                0x62,
                0x45,
                0xB9,
                0x62,
                0x13,
                0x27,
                0xB5,
                0x2A,
                0xD5,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IActivationViewSwitcher
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x1B,
                0xA7,
                0xDC,
                0x50,
                0x73,
                0x2B,
                0x49,
                0xAA,
                0xC7,
                0xC8,
                0xA1,
                0x3D,
                0x72,
                0x24,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationView
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0xD5,
                0x22,
                0xD2,
                0x61,
                0x43,
                0x1E,
                0x45,
                0x96,
                0xC4,
                0x60,
                0xF4,
                0xF9,
                0x74,
                0x2D,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationView2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xB1,
                0x76,
                0xE8,
                0x45,
                0xA5,
                0xDC,
                0x40,
                0xB5,
                0x94,
                0x45,
                0x0C,
                0xBA,
                0x68,
                0xCC,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationView3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x9C,
                0x3C,
                0x90,
                0x3A,
                0x79,
                0xDF,
                0x4F,
                0xA2,
                0xB2,
                0xAF,
                0x1A,
                0xC2,
                0x1E,
                0x31,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationView4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0xCB,
                0xE5,
                0x15,
                0x0F,
                0x9E,
                0xB5,
                0x46,
                0xBC,
                0x3F,
                0x9B,
                0xF6,
                0x53,
                0xE7,
                0x4B,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationView7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x96,
                0x36,
                0xA0,
                0xAF,
                0x5F,
                0xA6,
                0x5A,
                0x9C,
                0x38,
                0xBE,
                0xFB,
                0xB1,
                0x2A,
                0x07,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationView9
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x16,
                0x65,
                0x9C,
                0x1A,
                0x02,
                0x01,
                0x5F,
                0x93,
                0xE5,
                0x9B,
                0xDA,
                0xD2,
                0x64,
                0x75,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewConsolidatedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0x49,
                0x44,
                0x51,
                0xA2,
                0x7E,
                0xE7,
                0x4D,
                0xA6,
                0xA6,
                0x7D,
                0xFB,
                0xAA,
                0xEB,
                0xB6,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewConsolidatedEventArgs2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x9E,
                0x19,
                0x1C,
                0xC1,
                0x6D,
                0xF4,
                0x40,
                0xAF,
                0xEE,
                0x07,
                0xD9,
                0xEA,
                0x29,
                0x64,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewFullscreenStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0x2E,
                0x79,
                0xBC,
                0xFE,
                0x64,
                0x65,
                0x4B,
                0xA0,
                0xC0,
                0x90,
                0x1C,
                0xE2,
                0xB6,
                0x86,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewInteropStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xFB,
                0x46,
                0xC4,
                0x93,
                0x47,
                0x96,
                0x48,
                0xA8,
                0xE2,
                0xBE,
                0x57,
                0xA8,
                0xBB,
                0x0F,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewScaling
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0xDC,
                0x0D,
                0x1D,
                0xF3,
                0x23,
                0x2D,
                0x4B,
                0x84,
                0xFE,
                0x74,
                0xBF,
                0x37,
                0xB4,
                0x8B,
                0x66,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewScalingStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0xEC,
                0x8F,
                0xB0,
                0x46,
                0xB9,
                0xC8,
                0x45,
                0xA5,
                0xE3,
                0x71,
                0xF5,
                0xAA,
                0x78,
                0xF8,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0x63,
                0x0A,
                0x01,
                0x33,
                0xC4,
                0xE5,
                0x44,
                0xA9,
                0xF2,
                0xBD,
                0x84,
                0xD4,
                0x03,
                0x0A,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x8A,
                0x33,
                0xAF,
                0x64,
                0xCF,
                0x3C,
                0x42,
                0x85,
                0xE5,
                0xF3,
                0xE7,
                0x24,
                0x48,
                0xFB,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x94,
                0x75,
                0x8D,
                0xA2,
                0x41,
                0x8C,
                0x13,
                0x4E,
                0x97,
                0x19,
                0x51,
                0x64,
                0x79,
                0x6F,
                0xE4,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewStatics4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x33,
                0x8D,
                0xFD,
                0x08,
                0x11,
                0x26,
                0x36,
                0x53,
                0xA3,
                0x15,
                0xD9,
                0x8E,
                0x63,
                0x66,
                0xC9,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewSwitcherStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x2F,
                0x5F,
                0x97,
                0x56,
                0xE6,
                0x5E,
                0x4C,
                0xA0,
                0xA1,
                0x71,
                0x7C,
                0x6F,
                0xFA,
                0x7D,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewSwitcherStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCD,
                0x95,
                0xE9,
                0x60,
                0xC2,
                0x4F,
                0xC4,
                0x48,
                0xB8,
                0xE3,
                0x39,
                0x5F,
                0x2B,
                0x9F,
                0x0F,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewSwitcherStatics3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x94,
                0x05,
                0x92,
                0xA7,
                0x80,
                0x6D,
                0x48,
                0xB2,
                0x1F,
                0xC7,
                0xA4,
                0xA2,
                0x42,
                0xA3,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewTitleBar
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x4A,
                0x92,
                0x00,
                0x2B,
                0x93,
                0x6B,
                0x4A,
                0x9C,
                0x4B,
                0xDC,
                0x38,
                0xC8,
                0x24,
                0x78,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewTransferContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0xBC,
                0x74,
                0x85,
                0x17,
                0x3C,
                0x8E,
                0x40,
                0x94,
                0x08,
                0x8A,
                0x1A,
                0x9E,
                0xA8,
                0x1B,
                0xFA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewTransferContextStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x9D,
                0xA8,
                0x15,
                0x79,
                0xDD,
                0x0B,
                0x4B,
                0xBC,
                0x47,
                0xD5,
                0xF1,
                0x95,
                0xF1,
                0x46,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IApplicationViewWithContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0xD5,
                0x55,
                0xBD,
                0xC1,
                0x9D,
                0xFC,
                0x44,
                0x85,
                0x01,
                0x66,
                0x66,
                0x25,
                0xDF,
                0x60,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputPane
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0xDA,
                0x0A,
                0x64,
                0xF3,
                0x06,
                0x87,
                0x4C,
                0xA6,
                0x78,
                0x98,
                0x29,
                0xC9,
                0x12,
                0x7C,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputPane2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x3F,
                0x6B,
                0x8A,
                0x90,
                0x70,
                0x93,
                0x47,
                0x94,
                0x4C,
                0xC3,
                0xF2,
                0xCD,
                0xE2,
                0x62,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputPaneControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0xB2,
                0x8B,
                0x08,
                0x2F,
                0x96,
                0x9D,
                0x48,
                0xAA,
                0x6E,
                0xC6,
                0xBE,
                0x1A,
                0x0A,
                0x6E,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputPaneStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0xAF,
                0xF4,
                0x95,
                0x47,
                0xEF,
                0x4A,
                0x42,
                0x97,
                0x41,
                0xFD,
                0x28,
                0x15,
                0xEB,
                0xA2,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputPaneStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x52,
                0x63,
                0x1B,
                0xEC,
                0xD9,
                0x31,
                0x45,
                0x84,
                0x45,
                0x71,
                0xBA,
                0xB9,
                0xFB,
                0x82,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInputPaneVisibilityEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0xE0,
                0x43,
                0xD2,
                0x07,
                0xD9,
                0xCC,
                0x4F,
                0xBB,
                0x8D,
                0xF7,
                0x7B,
                0xAA,
                0x50,
                0x28,
                0xF1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProjectionManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x91,
                0x5F,
                0xB6,
                0xF0,
                0xE2,
                0xFD,
                0x4F,
                0xBA,
                0x95,
                0x34,
                0x24,
                0x16,
                0x47,
                0xE4,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProjectionManagerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x43,
                0x2F,
                0x3D,
                0xF3,
                0x49,
                0x27,
                0xDE,
                0x4C,
                0xB9,
                0x77,
                0xC0,
                0xC4,
                0x1E,
                0x74,
                0x15,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStatusBar
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0xC5,
                0xFC,
                0x0F,
                0xD0,
                0x98,
                0x64,
                0x48,
                0xB1,
                0xE8,
                0xB3,
                0xF4,
                0x02,
                0x0B,
                0xE8,
                0xB4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStatusBarProgressIndicator
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x26,
                0xCB,
                0x76,
                0xD7,
                0xA3,
                0xCF,
                0x49,
                0x82,
                0x00,
                0x4F,
                0x3E,
                0xED,
                0xCA,
                0x27,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStatusBarStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x3F,
                0x46,
                0x8B,
                0x2F,
                0x42,
                0x61,
                0x45,
                0x88,
                0x06,
                0xFB,
                0x12,
                0x89,
                0xCA,
                0xDF,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x16,
                0x36,
                0x85,
                0x63,
                0x1C,
                0x27,
                0x46,
                0xBC,
                0xB1,
                0x3A,
                0x89,
                0xE0,
                0xBC,
                0x9C,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettings2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x24,
                0xD8,
                0xBA,
                0x21,
                0x27,
                0xF9,
                0x44,
                0xBB,
                0x91,
                0x2B,
                0xB2,
                0x28,
                0xBE,
                0x44,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettings3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x1B,
                0x02,
                0x03,
                0x54,
                0x52,
                0x81,
                0x47,
                0x81,
                0x94,
                0x51,
                0x68,
                0xF7,
                0xD0,
                0x6D,
                0x7B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettings4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0x30,
                0xBB,
                0x52,
                0x9B,
                0x91,
                0x6B,
                0x4D,
                0x9B,
                0x78,
                0x8D,
                0xD6,
                0x6F,
                0xF4,
                0xB9,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettings5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xD5,
                0x49,
                0x53,
                0xB5,
                0x0C,
                0x05,
                0x5F,
                0xBD,
                0x34,
                0x70,
                0x6B,
                0x32,
                0x31,
                0xF0,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettings6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x9B,
                0xF1,
                0xAE,
                0x31,
                0xFE,
                0x04,
                0x5A,
                0xAD,
                0xA4,
                0x46,
                0x9A,
                0xAE,
                0xC6,
                0xDF,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettingsAnimationsEnabledChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x4B,
                0x7B,
                0x0C,
                0xA1,
                0x2E,
                0x3E,
                0x53,
                0x89,
                0x4D,
                0x41,
                0x5B,
                0xC5,
                0x24,
                0x3C,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettingsAutoHideScrollBarsChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0xD4,
                0xAF,
                0x87,
                0x46,
                0x91,
                0x02,
                0x5F,
                0x8F,
                0x6B,
                0x06,
                0xD4,
                0x54,
                0x17,
                0x4C,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUISettingsMessageDurationChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0xAD,
                0x8A,
                0x33,
                0x5D,
                0x4A,
                0x59,
                0x5B,
                0x80,
                0x02,
                0xD9,
                0x30,
                0xF6,
                0x08,
                0xFD,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIViewSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x57,
                0x36,
                0xC6,
                0x50,
                0x88,
                0x0D,
                0x47,
                0x88,
                0xF8,
                0x45,
                0x5E,
                0x16,
                0xEA,
                0x2C,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IUIViewSettingsStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA5,
                0x97,
                0x5C,
                0x59,
                0xF6,
                0xF8,
                0xCF,
                0x41,
                0xB0,
                0xFB,
                0xAA,
                0xCD,
                0xB8,
                0x1F,
                0xD5,
                0xF6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IViewModePreferences
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0xCD,
                0x8F,
                0x87,
                0x99,
                0x0B,
                0xC9,
                0x42,
                0x84,
                0xD0,
                0xD3,
                0xF1,
                0xD4,
                0x03,
                0x55,
                0x4B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IViewModePreferencesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x0A,
                0xB6,
                0x69,
                0xE5,
                0x5D,
                0xD8,
                0x40,
                0x83,
                0x06,
                0x38,
                0x33,
                0xDF,
                0x7A,
                0x22,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
