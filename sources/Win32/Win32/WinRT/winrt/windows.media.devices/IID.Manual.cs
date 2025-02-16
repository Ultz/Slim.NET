// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ICallControlEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x75,
                0x6F,
                0x59,
                0xDF,
                0x50,
                0x54,
                0x44,
                0xBC,
                0x63,
                0x4D,
                0x3D,
                0x01,
                0xB6,
                0x19,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDialRequestedEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0xFF,
                0xBB,
                0x5A,
                0x1F,
                0xC2,
                0xC4,
                0x4B,
                0x89,
                0x1B,
                0x25,
                0x7E,
                0x28,
                0xC1,
                0xB1,
                0xA4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeypadPressedEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x54,
                0xA4,
                0x37,
                0xE6,
                0x27,
                0xC5,
                0x2C,
                0x42,
                0x89,
                0x26,
                0xC9,
                0xAF,
                0x83,
                0xB5,
                0x59,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRedialRequestedEventHandler
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x57,
                0xF2,
                0xBA,
                0xBD,
                0x4E,
                0x84,
                0x4B,
                0x9F,
                0x47,
                0x6E,
                0xC4,
                0x3D,
                0x75,
                0xD8,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedPhotoCaptureSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0x86,
                0xF3,
                0x08,
                0x18,
                0x00,
                0x5B,
                0x44,
                0x93,
                0xD2,
                0x64,
                0x6D,
                0x1C,
                0x5E,
                0xD0,
                0x5C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedPhotoControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x86,
                0x54,
                0xB1,
                0xC5,
                0x01,
                0x90,
                0x82,
                0x46,
                0x93,
                0x09,
                0x68,
                0xEA,
                0xE0,
                0x08,
                0x0E,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD3,
                0xF4,
                0x6F,
                0xDE,
                0x96,
                0x2B,
                0x83,
                0x45,
                0x80,
                0xAB,
                0xB5,
                0xB0,
                0x1D,
                0xC6,
                0xA8,
                0xD7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController10
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0xB8,
                0x21,
                0xC6,
                0xF0,
                0xD6,
                0x1B,
                0x5C,
                0xA3,
                0x88,
                0xA6,
                0xE9,
                0x38,
                0x40,
                0x71,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController11
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x5A,
                0xB6,
                0xD5,
                0x72,
                0x37,
                0x0C,
                0x58,
                0xA6,
                0x30,
                0xE7,
                0x5D,
                0xE9,
                0x10,
                0x69,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x4F,
                0xB9,
                0x8B,
                0x1A,
                0xF1,
                0xDB,
                0x43,
                0xB4,
                0x02,
                0x11,
                0x93,
                0x0B,
                0x80,
                0xAE,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x8F,
                0x8B,
                0xA9,
                0x0D,
                0xEE,
                0x0C,
                0x47,
                0xB9,
                0xF0,
                0x42,
                0x29,
                0xC4,
                0xBB,
                0xD0,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0xBF,
                0x9F,
                0xEA,
                0x71,
                0xD3,
                0xC3,
                0x41,
                0x9A,
                0x17,
                0x82,
                0x4A,
                0x87,
                0xEB,
                0xDF,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x17,
                0x2B,
                0x51,
                0x33,
                0xCB,
                0xB9,
                0x23,
                0x4A,
                0xB8,
                0x75,
                0xF9,
                0xEA,
                0xAB,
                0x53,
                0x54,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x3A,
                0x56,
                0xB6,
                0xA1,
                0x68,
                0xB7,
                0x44,
                0x9F,
                0x89,
                0xB5,
                0xFA,
                0x97,
                0xAC,
                0x0C,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x27,
                0x29,
                0x8D,
                0x54,
                0xA0,
                0xE7,
                0x50,
                0xB7,
                0xDF,
                0x7C,
                0x04,
                0x23,
                0x4D,
                0x10,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController8
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xF0,
                0x43,
                0xD8,
                0xFB,
                0xE7,
                0x5B,
                0x59,
                0x9A,
                0x78,
                0x0E,
                0x54,
                0xC4,
                0x53,
                0x2B,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAdvancedVideoCaptureDeviceController9
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0xA9,
                0xDC,
                0x8B,
                0x55,
                0x02,
                0xBC,
                0x51,
                0xA1,
                0x0D,
                0x5A,
                0x16,
                0x9E,
                0xC1,
                0x62,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioDeviceController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x88,
                0xA3,
                0xD4,
                0xED,
                0xC7,
                0x79,
                0x7C,
                0x4F,
                0x90,
                0xE8,
                0xEF,
                0x93,
                0x4B,
                0x21,
                0x58,
                0x0A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioDeviceModule
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0xAC,
                0xCF,
                0x86,
                0xC1,
                0x47,
                0x33,
                0x4B,
                0x98,
                0x52,
                0x87,
                0x73,
                0xEC,
                0x4B,
                0xE1,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioDeviceModuleNotificationEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0xCC,
                0xE3,
                0xE3,
                0x4C,
                0x22,
                0xBE,
                0x48,
                0x95,
                0x6B,
                0x9A,
                0x13,
                0x13,
                0x4E,
                0x96,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioDeviceModulesManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4D,
                0x0C,
                0xA4,
                0x6A,
                0x0A,
                0x96,
                0x1C,
                0x4D,
                0xB3,
                0x18,
                0x00,
                0x22,
                0x60,
                0x45,
                0x47,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioDeviceModulesManagerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0x36,
                0xB0,
                0x8D,
                0x4D,
                0xE6,
                0x73,
                0x47,
                0x96,
                0xC0,
                0xBC,
                0x7E,
                0xBF,
                0x0E,
                0x06,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICallControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0xD0,
                0x20,
                0xA5,
                0x8D,
                0xAE,
                0xDB,
                0x45,
                0x80,
                0x11,
                0xCA,
                0x49,
                0xD3,
                0xB3,
                0xE5,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICallControlStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x5A,
                0x94,
                0x03,
                0xAB,
                0x85,
                0xE1,
                0x40,
                0xAF,
                0x19,
                0x56,
                0xC9,
                0x43,
                0x03,
                0xB0,
                0x19,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICameraOcclusionInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x4A,
                0x6C,
                0xAF,
                0x4D,
                0xA8,
                0xB6,
                0x5D,
                0xBE,
                0x58,
                0xA5,
                0xDA,
                0x21,
                0xCF,
                0xE0,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICameraOcclusionState
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB8,
                0xDE,
                0x0A,
                0x43,
                0x42,
                0x68,
                0x55,
                0x5E,
                0x9B,
                0xDE,
                0x04,
                0xB4,
                0xEF,
                0x3A,
                0x8A,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICameraOcclusionStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xD8,
                0x12,
                0x85,
                0xDE,
                0xC0,
                0xCA,
                0x57,
                0xA1,
                0xCA,
                0xFB,
                0x2C,
                0x3D,
                0x23,
                0xDF,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDefaultAudioDeviceChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x88,
                0x0F,
                0x11,
                0x05,
                0x1C,
                0x57,
                0x46,
                0xA1,
                0x8E,
                0x47,
                0xC9,
                0xB6,
                0x9F,
                0x07,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDialRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x92,
                0x7B,
                0x03,
                0x3C,
                0x95,
                0x86,
                0x42,
                0x88,
                0x66,
                0x4F,
                0x0F,
                0x37,
                0x6C,
                0x85,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDigitalWindowBounds
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x21,
                0x4F,
                0xDD,
                0x73,
                0xD1,
                0x6B,
                0x5C,
                0x8C,
                0x25,
                0xBD,
                0xD2,
                0x6D,
                0x51,
                0x22,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDigitalWindowCapability
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0xAD,
                0x8B,
                0xD7,
                0x21,
                0xF7,
                0x44,
                0x52,
                0xA1,
                0x96,
                0xB5,
                0x6C,
                0xCB,
                0xEC,
                0x60,
                0x6C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDigitalWindowControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0x9E,
                0xB6,
                0x23,
                0xD2,
                0x65,
                0xEA,
                0x53,
                0x87,
                0x80,
                0xDE,
                0x58,
                0x2B,
                0x48,
                0xB5,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IExposureCompensationControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0xE8,
                0xC8,
                0x81,
                0xEC,
                0xDC,
                0x11,
                0x40,
                0xA6,
                0x10,
                0x1F,
                0x38,
                0x47,
                0xE6,
                0x4A,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IExposureControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0xCB,
                0xE8,
                0x09,
                0x96,
                0xAD,
                0x28,
                0x4F,
                0xA0,
                0xE0,
                0x96,
                0xED,
                0x7E,
                0x1B,
                0x5F,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IExposurePriorityVideoControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x40,
                0xB2,
                0x2C,
                0x68,
                0x51,
                0x71,
                0x42,
                0x9E,
                0xA5,
                0x47,
                0x62,
                0x1A,
                0x98,
                0xA3,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFlashControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x1D,
                0xF4,
                0xDE,
                0x68,
                0x7D,
                0xE3,
                0x45,
                0x8C,
                0x0F,
                0xBE,
                0x7B,
                0xB3,
                0x28,
                0x37,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFlashControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xCC,
                0x29,
                0x7D,
                0xE1,
                0x75,
                0xF7,
                0x4A,
                0xBD,
                0x7D,
                0x4E,
                0x38,
                0xE1,
                0xC0,
                0x6C,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFocusControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0x89,
                0xD8,
                0xC0,
                0x28,
                0x52,
                0x53,
                0x44,
                0xB1,
                0x53,
                0x85,
                0x60,
                0x65,
                0x92,
                0xB2,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFocusControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0xFF,
                0x7C,
                0x3F,
                0x34,
                0xC5,
                0x9E,
                0x4E,
                0x94,
                0xC3,
                0x52,
                0xEF,
                0x2A,
                0xFD,
                0x5D,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFocusSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6B,
                0x8F,
                0x95,
                0x79,
                0x63,
                0x32,
                0x75,
                0x42,
                0x85,
                0xD6,
                0xAE,
                0xAE,
                0x89,
                0x1C,
                0x96,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IHdrVideoControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xE2,
                0xD8,
                0x55,
                0xC0,
                0x30,
                0xBF,
                0x43,
                0x9B,
                0x9A,
                0x97,
                0x99,
                0xD7,
                0x0C,
                0xED,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInfraredTorchControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0x2C,
                0xBA,
                0x1C,
                0xB6,
                0x6C,
                0x04,
                0x5A,
                0xA6,
                0xFC,
                0x3B,
                0xE7,
                0xB3,
                0x3F,
                0xF0,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIsoSpeedControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0xC3,
                0xB6,
                0x27,
                0xAD,
                0x25,
                0x1B,
                0x4F,
                0xAA,
                0xAB,
                0x52,
                0x4A,
                0xB3,
                0x76,
                0xCA,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IIsoSpeedControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF2,
                0x78,
                0x15,
                0x6F,
                0x77,
                0x6D,
                0x8A,
                0x4F,
                0x8C,
                0x2F,
                0x61,
                0x30,
                0xB6,
                0x39,
                0x50,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeypadPressedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x39,
                0xA4,
                0xD3,
                0xFA,
                0xB4,
                0xCD,
                0x49,
                0x94,
                0x42,
                0x89,
                0xAF,
                0x65,
                0x68,
                0xF6,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLagPhotoControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x4D,
                0x5C,
                0x6D,
                0xDF,
                0xFA,
                0x5D,
                0x41,
                0xAE,
                0xE6,
                0x3B,
                0xAA,
                0x52,
                0x93,
                0x00,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILowLagPhotoSequenceControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9D,
                0x90,
                0xCF,
                0x3D,
                0x16,
                0x6D,
                0x9C,
                0x40,
                0xBA,
                0xFE,
                0xB9,
                0xA5,
                0x94,
                0xC6,
                0xFD,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaDeviceControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0xDF,
                0xA8,
                0xEF,
                0x75,
                0x6F,
                0x63,
                0x48,
                0xBA,
                0x0B,
                0x58,
                0x3F,
                0x30,
                0x36,
                0xB4,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaDeviceControlCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x58,
                0x00,
                0x23,
                0x85,
                0xEB,
                0xE2,
                0x43,
                0xB9,
                0x2B,
                0x82,
                0x40,
                0xD5,
                0xEE,
                0x70,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaDeviceController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0xF5,
                0xF8,
                0xF6,
                0x9A,
                0x20,
                0xFB,
                0x48,
                0x86,
                0xFC,
                0xD4,
                0x45,
                0x78,
                0xF3,
                0x17,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaDeviceStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0x9A,
                0x2D,
                0xAA,
                0x9F,
                0x90,
                0xBA,
                0x4B,
                0xBF,
                0x8B,
                0x0C,
                0x0D,
                0x29,
                0x6F,
                0x14,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IModuleCommandResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x1E,
                0x0D,
                0x52,
                0x74,
                0x13,
                0x7D,
                0x4C,
                0xB1,
                0xE4,
                0x39,
                0xDC,
                0xDF,
                0x3E,
                0xAE,
                0x4E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IOpticalImageStabilizationControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x9C,
                0xAD,
                0xBF,
                0xBC,
                0x00,
                0x3B,
                0x42,
                0x8E,
                0xB2,
                0xA0,
                0x17,
                0x8C,
                0xA9,
                0x42,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPanelBasedOptimizationControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x32,
                0x32,
                0x33,
                0x47,
                0x62,
                0x19,
                0x54,
                0xA5,
                0xA4,
                0x3D,
                0x80,
                0x86,
                0x45,
                0xD9,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPhotoConfirmationControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x63,
                0xF3,
                0xF3,
                0xC8,
                0x5E,
                0xFF,
                0x82,
                0x45,
                0xA9,
                0xA8,
                0x05,
                0x50,
                0xF8,
                0x5A,
                0x4A,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRedialRequestedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x52,
                0xB5,
                0x7E,
                0xAB,
                0x76,
                0x31,
                0x4C,
                0xB4,
                0x0E,
                0x4B,
                0x58,
                0x37,
                0x9D,
                0x58,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRegionOfInterest
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0xC8,
                0xEC,
                0xE5,
                0x66,
                0xCE,
                0x05,
                0x4E,
                0xA7,
                0x8F,
                0xCF,
                0x39,
                0x1A,
                0x5E,
                0xC2,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRegionOfInterest2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x2A,
                0xFE,
                0x19,
                0xAA,
                0x73,
                0x51,
                0x4D,
                0x8A,
                0x9D,
                0x56,
                0xCC,
                0xF7,
                0xDB,
                0x7F,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRegionsOfInterestControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0xF5,
                0x23,
                0xC3,
                0x0B,
                0xAB,
                0x58,
                0x45,
                0x8B,
                0x5B,
                0xDF,
                0x56,
                0x93,
                0xDB,
                0x03,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISceneModeControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x5A,
                0x8E,
                0xD4,
                0x59,
                0x8D,
                0x54,
                0x48,
                0x8C,
                0x62,
                0x12,
                0xC7,
                0x0B,
                0xA8,
                0x9B,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ITorchControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0x36,
                0x05,
                0xA6,
                0x50,
                0x82,
                0x6C,
                0x41,
                0x91,
                0x9A,
                0x72,
                0x42,
                0x96,
                0xAF,
                0xA3,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoDeviceController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0x55,
                0x55,
                0x99,
                0x2E,
                0x2E,
                0xB8,
                0x40,
                0xB6,
                0xC7,
                0xF8,
                0x2D,
                0x10,
                0x01,
                0x32,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoDeviceControllerGetDevicePropertyResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x83,
                0xD8,
                0xC5,
                0xD5,
                0x6E,
                0x90,
                0x47,
                0x8B,
                0x5D,
                0x0E,
                0xF1,
                0x39,
                0x35,
                0xD0,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoTemporalDenoisingControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x47,
                0xB3,
                0x7A,
                0x2A,
                0x3E,
                0x32,
                0x4A,
                0xBA,
                0xFF,
                0x43,
                0x58,
                0xC4,
                0xFB,
                0xDD,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IWhiteBalanceControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x04,
                0x1F,
                0x78,
                0x62,
                0x71,
                0xC8,
                0x49,
                0xA8,
                0xF9,
                0x94,
                0x81,
                0xC5,
                0x65,
                0x36,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IZoomControl
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x0B,
                0x1E,
                0x3A,
                0xDA,
                0x32,
                0x17,
                0x4C,
                0xBF,
                0xD7,
                0x8D,
                0x0C,
                0x73,
                0xC8,
                0xF5,
                0xA5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IZoomControl2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x3D,
                0x84,
                0x69,
                0x99,
                0x2E,
                0x41,
                0x46,
                0x85,
                0x29,
                0x18,
                0x4F,
                0x31,
                0x9D,
                0x16,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IZoomSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x6B,
                0xD6,
                0x6A,
                0xB4,
                0x14,
                0xFD,
                0x4B,
                0xB1,
                0x8F,
                0x88,
                0xFE,
                0x24,
                0x46,
                0x3B,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
