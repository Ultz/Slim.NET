// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAppWindow
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x14,
                0x30,
                0x66,
                0x5E,
                0xB7,
                0xBD,
                0x5D,
                0x99,
                0x5C,
                0xF0,
                0x11,
                0x7F,
                0xA3,
                0xFB,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0xF3,
                0xE1,
                0x1D,
                0x55,
                0xA6,
                0xAD,
                0x55,
                0xB2,
                0xB6,
                0xEB,
                0x24,
                0x0F,
                0x88,
                0x03,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowCloseRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDA,
                0x01,
                0xFF,
                0xE9,
                0xA2,
                0xE7,
                0xA8,
                0x57,
                0x8B,
                0x5E,
                0x39,
                0xC4,
                0x00,
                0x3A,
                0xFD,
                0xBB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowClosedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0xF8,
                0x7D,
                0xCC,
                0x20,
                0x95,
                0x06,
                0x5A,
                0x82,
                0x1E,
                0x45,
                0x6A,
                0xD8,
                0xB3,
                0x58,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowFrame
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x01,
                0x26,
                0xE2,
                0x9E,
                0x5D,
                0x7E,
                0xAF,
                0x52,
                0x84,
                0x6B,
                0x01,
                0xDC,
                0x6C,
                0x29,
                0x65,
                0x67,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowFrameStyle
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x29,
                0x41,
                0xAC,
                0xAC,
                0xE1,
                0x30,
                0x52,
                0x94,
                0x4A,
                0xC6,
                0x08,
                0x73,
                0xDC,
                0xF4,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowPlacement
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x81,
                0xDC,
                0x03,
                0xA9,
                0xE7,
                0x57,
                0x58,
                0x9C,
                0x03,
                0x7D,
                0x67,
                0x05,
                0x94,
                0x41,
                0x0E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowPresentationConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0x3E,
                0xA4,
                0xB5,
                0x33,
                0xDF,
                0x67,
                0x5E,
                0xBD,
                0x31,
                0x10,
                0x72,
                0x45,
                0x73,
                0x00,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowPresentationConfigurationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA6,
                0x06,
                0x36,
                0xFD,
                0x75,
                0x78,
                0xE8,
                0x5D,
                0x84,
                0xFF,
                0x63,
                0x51,
                0xEE,
                0x13,
                0xDD,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowPresenter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xED,
                0xE9,
                0x5A,
                0xFD,
                0xE1,
                0x17,
                0x53,
                0xAD,
                0x78,
                0x5A,
                0x3E,
                0xD2,
                0x71,
                0xBB,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x3E,
                0x1F,
                0xFF,
                0x69,
                0xB7,
                0xEF,
                0x50,
                0x98,
                0x73,
                0x10,
                0x8C,
                0xD0,
                0xE8,
                0x97,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowTitleBar
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0x2C,
                0x93,
                0x6E,
                0x44,
                0xF6,
                0x1D,
                0x54,
                0xA2,
                0xD7,
                0x0C,
                0x26,
                0x24,
                0x37,
                0x84,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowTitleBarOcclusion
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFD,
                0xCF,
                0xA3,
                0xFE,
                0xCF,
                0x2C,
                0xC3,
                0x5F,
                0xAE,
                0xAE,
                0xF8,
                0x43,
                0x87,
                0x6B,
                0xF3,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAppWindowTitleBarVisibility
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE3,
                0xA4,
                0x15,
                0xA2,
                0x7E,
                0x6E,
                0x51,
                0x56,
                0x8C,
                0x3B,
                0x62,
                0x48,
                0x19,
                0x52,
                0x81,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompactOverlayPresentationConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0F,
                0x75,
                0xE5,
                0xA7,
                0x30,
                0x57,
                0xC6,
                0x56,
                0x8E,
                0x1F,
                0xD6,
                0x3F,
                0xF4,
                0xD7,
                0x98,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDefaultPresentationConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0xB5,
                0xC2,
                0xD8,
                0x68,
                0x21,
                0x03,
                0x57,
                0xA8,
                0x53,
                0xD5,
                0x25,
                0x58,
                0x9F,
                0xE2,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDisplayRegion
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0xC3,
                0x50,
                0xDB,
                0x94,
                0x40,
                0x47,
                0x5F,
                0x8C,
                0xB1,
                0xEA,
                0x01,
                0xDD,
                0xAF,
                0xAA,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFullScreenPresentationConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0xDC,
                0xD3,
                0x43,
                0xA8,
                0xD2,
                0x3D,
                0x50,
                0xA6,
                0x26,
                0x15,
                0x53,
                0x3D,
                0x6D,
                0x5F,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWindowServicesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0xD5,
                0xF4,
                0xCF,
                0xA6,
                0x50,
                0x64,
                0x5C,
                0x97,
                0xF6,
                0xC2,
                0xD9,
                0x6A,
                0xDD,
                0x7F,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWindowingEnvironment
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC0,
                0x63,
                0x43,
                0x26,
                0x49,
                0x2A,
                0x17,
                0x54,
                0xB3,
                0xAE,
                0x48,
                0xA7,
                0x1C,
                0x63,
                0xA3,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWindowingEnvironmentAddedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x5B,
                0x2A,
                0xFF,
                0x83,
                0xF1,
                0x66,
                0x5C,
                0x99,
                0xB2,
                0x42,
                0x90,
                0x82,
                0x06,
                0x92,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWindowingEnvironmentChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0xCF,
                0x60,
                0x41,
                0x3D,
                0x02,
                0x9A,
                0x5E,
                0xB4,
                0x31,
                0x35,
                0x0E,
                0x67,
                0xDC,
                0x97,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWindowingEnvironmentRemovedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0x54,
                0x5B,
                0x2E,
                0xFF,
                0xBE,
                0x53,
                0x5E,
                0x93,
                0x16,
                0x7E,
                0x77,
                0x5F,
                0xE5,
                0x68,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWindowingEnvironmentStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x9F,
                0x4E,
                0x87,
                0x42,
                0xC6,
                0xAB,
                0x55,
                0x8A,
                0xA2,
                0x16,
                0x2F,
                0x73,
                0x4A,
                0x9A,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
