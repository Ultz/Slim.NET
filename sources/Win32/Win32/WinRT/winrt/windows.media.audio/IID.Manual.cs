// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAudioDeviceInputNode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0x6B,
                0x1B,
                0xB0,
                0x4E,
                0x6F,
                0xE2,
                0x49,
                0xAC,
                0x01,
                0x55,
                0x9D,
                0x62,
                0xBE,
                0xB3,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioDeviceOutputNode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0xDB,
                0x2E,
                0x36,
                0x1C,
                0xFF,
                0x34,
                0x44,
                0x9E,
                0x0F,
                0xBD,
                0x2E,
                0xF5,
                0x22,
                0xAC,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioFileInputNode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x67,
                0x5B,
                0x90,
                0x65,
                0x6F,
                0xD4,
                0x4C,
                0x88,
                0x90,
                0x46,
                0x94,
                0x84,
                0x3C,
                0x27,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioFileOutputNode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x19,
                0xE0,
                0x50,
                0x66,
                0x51,
                0x93,
                0x40,
                0x80,
                0xF8,
                0xAD,
                0xA0,
                0x00,
                0x89,
                0xE9,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioFrameCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x82,
                0x7C,
                0xDC,
                0x08,
                0x02,
                0x04,
                0x45,
                0xA5,
                0xA8,
                0xF0,
                0xF2,
                0x68,
                0x92,
                0x0A,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioFrameInputNode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x66,
                0xB2,
                0x01,
                0x96,
                0xFD,
                0xF5,
                0x4F,
                0xA3,
                0xC5,
                0xD2,
                0x7A,
                0x9B,
                0xF4,
                0x42,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioFrameOutputNode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x37,
                0x47,
                0xB8,
                0x99,
                0x32,
                0xF5,
                0x45,
                0x88,
                0xB3,
                0xC9,
                0xD1,
                0x2A,
                0x3F,
                0x1C,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioGraph
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x6E,
                0xD4,
                0x1A,
                0x8C,
                0xE4,
                0x14,
                0x4E,
                0x96,
                0x60,
                0x2C,
                0x4F,
                0x83,
                0xE9,
                0xCD,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioGraph2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x3B,
                0x4C,
                0x4E,
                0xC1,
                0x4F,
                0xF6,
                0x45,
                0xA9,
                0x47,
                0x3C,
                0xD3,
                0x8F,
                0x4F,
                0xD8,
                0x39,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioGraph3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAE,
                0x25,
                0xCD,
                0xDD,
                0x85,
                0x11,
                0xA7,
                0x42,
                0x83,
                0x1D,
                0x6A,
                0x9B,
                0x0F,
                0xC8,
                0x68,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioGraphConnection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xED,
                0x70,
                0x30,
                0x76,
                0x4E,
                0xD0,
                0xAC,
                0x4F,
                0xB2,
                0x33,
                0x60,
                0x0B,
                0x42,
                0xED,
                0xD4,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioGraphSettings
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x64,
                0x59,
                0x1D,
                0xFE,
                0xE6,
                0x28,
                0x46,
                0x84,
                0xF8,
                0x9D,
                0x8B,
                0xDB,
                0xA2,
                0x57,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioGraphSettings2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x87,
                0x97,
                0x91,
                0x72,
                0xAB,
                0x4D,
                0xE3,
                0x46,
                0xB4,
                0xC9,
                0xD8,
                0xE1,
                0xA2,
                0x63,
                0x60,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioGraphSettingsFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC6,
                0x1C,
                0xD9,
                0xA5,
                0xEB,
                0xC2,
                0x61,
                0x4A,
                0xA2,
                0x14,
                0x1D,
                0x66,
                0xD7,
                0x5F,
                0x83,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioGraphStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x32,
                0x31,
                0xEC,
                0x76,
                0x59,
                0xE1,
                0xB7,
                0x4A,
                0xA8,
                0x2A,
                0x17,
                0xBE,
                0xB4,
                0xB3,
                0x1E,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioGraphUnrecoverableErrorOccurredEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0xCB,
                0xD9,
                0xC3,
                0xF6,
                0x3F,
                0xB3,
                0x4F,
                0xB2,
                0x62,
                0x50,
                0xD4,
                0x35,
                0xC5,
                0x54,
                0x23,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioInputNode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x00,
                0x48,
                0xD1,
                0x28,
                0x84,
                0x84,
                0x47,
                0xB7,
                0xFD,
                0xA9,
                0x9D,
                0x46,
                0x8C,
                0x5D,
                0x20,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioInputNode2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0x56,
                0x51,
                0x90,
                0x68,
                0xCA,
                0x6D,
                0x4C,
                0xA8,
                0xBC,
                0xE3,
                0xEE,
                0x17,
                0xFE,
                0x3F,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7F,
                0x9D,
                0x38,
                0x15,
                0xD8,
                0xDB,
                0x19,
                0x48,
                0xBF,
                0x03,
                0x66,
                0x8E,
                0x93,
                0x57,
                0xCD,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeEmitter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x97,
                0x76,
                0x36,
                0x0A,
                0x88,
                0xB8,
                0x47,
                0xAD,
                0xF7,
                0x13,
                0x23,
                0xA9,
                0xD9,
                0x65,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeEmitter2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xEE,
                0xB6,
                0x4A,
                0x29,
                0xEC,
                0xF8,
                0x47,
                0x81,
                0x8C,
                0xB6,
                0xB6,
                0x60,
                0xA5,
                0xAE,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeEmitterConeProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0x2C,
                0x9B,
                0xE9,
                0xCA,
                0x02,
                0x75,
                0x43,
                0x93,
                0x26,
                0x0C,
                0x6A,
                0xE4,
                0xBC,
                0xDF,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeEmitterDecayModel
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0x5A,
                0x1D,
                0x1D,
                0x53,
                0x0D,
                0xA9,
                0x4F,
                0xBD,
                0x84,
                0xD5,
                0x81,
                0x6A,
                0x86,
                0xF3,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeEmitterDecayModelStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x7C,
                0x78,
                0xC7,
                0x78,
                0xF1,
                0x2F,
                0x46,
                0xBC,
                0x81,
                0x8D,
                0xD5,
                0xCB,
                0xE5,
                0xDA,
                0xE8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeEmitterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9A,
                0x48,
                0xC8,
                0xFD,
                0xD6,
                0x6A,
                0xE4,
                0x4C,
                0xB7,
                0xF7,
                0xA9,
                0x93,
                0x70,
                0xDF,
                0x7E,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeEmitterNaturalDecayModelProperties
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCF,
                0x4B,
                0x93,
                0x48,
                0x2C,
                0xCF,
                0xFC,
                0x4E,
                0x93,
                0x31,
                0x75,
                0xBD,
                0x22,
                0xDF,
                0x1F,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeEmitterShape
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0x11,
                0x03,
                0xEA,
                0x3D,
                0xE7,
                0xBC,
                0x44,
                0x85,
                0x9C,
                0x45,
                0x55,
                0x3B,
                0xBC,
                0x48,
                0x28,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeEmitterShapeStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0x27,
                0xBB,
                0x57,
                0xA5,
                0xFF,
                0x86,
                0x4B,
                0xA7,
                0x79,
                0xE2,
                0x64,
                0xAE,
                0xB9,
                0x14,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeListener
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x2E,
                0x72,
                0xD9,
                0x0A,
                0x0C,
                0xDA,
                0x41,
                0xB7,
                0x55,
                0x6C,
                0x77,
                0x83,
                0x5F,
                0xB1,
                0xEB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioNodeWithListener
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x90,
                0x0F,
                0x0E,
                0xFF,
                0x79,
                0x44,
                0x45,
                0x9E,
                0xEB,
                0x01,
                0x25,
                0x7B,
                0x15,
                0x10,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioPlaybackConnection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x1D,
                0x4C,
                0x1A,
                0xFC,
                0xCA,
                0xE7,
                0x50,
                0x87,
                0x18,
                0xEA,
                0x3F,
                0x81,
                0xCB,
                0xFA,
                0x51,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioPlaybackConnectionOpenResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0x6A,
                0x65,
                0x4E,
                0xF9,
                0x39,
                0xC9,
                0x5F,
                0xA5,
                0x19,
                0xA5,
                0xBB,
                0xFD,
                0x9F,
                0xE9,
                0x21,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioPlaybackConnectionStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x63,
                0x09,
                0xE6,
                0xE6,
                0x69,
                0xFC,
                0x5F,
                0x9E,
                0x13,
                0x82,
                0x4A,
                0x85,
                0x21,
                0x3D,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioStateMonitor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0xD1,
                0x13,
                0x1D,
                0x99,
                0x01,
                0xDC,
                0x4C,
                0xB8,
                0x4E,
                0xE7,
                0x2C,
                0x2B,
                0x58,
                0x1E,
                0xCE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioStateMonitorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0xEA,
                0x74,
                0x63,
                0x3B,
                0x1B,
                0x01,
                0x40,
                0x94,
                0xD9,
                0xDD,
                0x22,
                0x53,
                0x30,
                0xFA,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateAudioDeviceInputNodeResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0xC7,
                0xEE,
                0x16,
                0xA7,
                0x1C,
                0xEF,
                0x40,
                0x91,
                0xA4,
                0xD3,
                0x46,
                0xE0,
                0xAA,
                0x1B,
                0xBA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateAudioDeviceInputNodeResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCE,
                0x69,
                0x1C,
                0x92,
                0x35,
                0x3F,
                0xC7,
                0x41,
                0x96,
                0x22,
                0x79,
                0xF6,
                0x08,
                0xBA,
                0xED,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateAudioDeviceOutputNodeResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x27,
                0x6D,
                0x77,
                0xF7,
                0x9A,
                0x1D,
                0xF7,
                0x47,
                0x9C,
                0xD4,
                0x28,
                0x59,
                0xCC,
                0x1B,
                0x7B,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateAudioDeviceOutputNodeResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x26,
                0x64,
                0x48,
                0xCE,
                0xBD,
                0xB1,
                0x4A,
                0xBD,
                0x38,
                0xFB,
                0xAE,
                0x93,
                0xAE,
                0xDA,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateAudioFileInputNodeResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0xD6,
                0x83,
                0xCE,
                0x97,
                0xE2,
                0x50,
                0x4C,
                0x9C,
                0xE7,
                0x1C,
                0x7A,
                0x69,
                0xD6,
                0xBD,
                0x09,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateAudioFileInputNodeResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x20,
                0x08,
                0xF9,
                0x80,
                0x3D,
                0xE0,
                0x4F,
                0x81,
                0xC1,
                0x76,
                0x8F,
                0xEA,
                0x7C,
                0xA7,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateAudioFileOutputNodeResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xBA,
                0xD6,
                0x47,
                0x09,
                0xE9,
                0x3F,
                0x45,
                0x86,
                0x6E,
                0x55,
                0x40,
                0xCD,
                0xA7,
                0x34,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateAudioFileOutputNodeResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0xB5,
                0x01,
                0x9F,
                0x18,
                0x33,
                0xB3,
                0x47,
                0xA6,
                0x0A,
                0x1B,
                0x49,
                0x2B,
                0xE7,
                0xFC,
                0x0D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateAudioGraphResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0xEF,
                0x53,
                0x54,
                0xDE,
                0x7B,
                0x76,
                0x4B,
                0xBB,
                0x5D,
                0x48,
                0xF7,
                0x9C,
                0xFC,
                0x8C,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateAudioGraphResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0x8D,
                0x73,
                0x6D,
                0xC6,
                0x88,
                0xCB,
                0x4F,
                0xA5,
                0x34,
                0x85,
                0xCE,
                0xDD,
                0x40,
                0x50,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateMediaSourceAudioInputNodeResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0x58,
                0xA6,
                0x46,
                0xC0,
                0x53,
                0x59,
                0x4D,
                0x9E,
                0x51,
                0xCC,
                0x1D,
                0x10,
                0x44,
                0xA4,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICreateMediaSourceAudioInputNodeResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE8,
                0x4C,
                0x51,
                0x63,
                0x1A,
                0x6A,
                0xE3,
                0x49,
                0x97,
                0xEC,
                0x28,
                0xFD,
                0x5B,
                0xE1,
                0x14,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEchoEffectDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x3F,
                0x4D,
                0x0E,
                0xB8,
                0x36,
                0x91,
                0x4C,
                0xB9,
                0xDA,
                0x11,
                0xF4,
                0x4A,
                0x8A,
                0x66,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEchoEffectDefinitionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x22,
                0x4E,
                0x0D,
                0xF2,
                0xAA,
                0x86,
                0x4E,
                0xA5,
                0x4C,
                0xFB,
                0x79,
                0xDB,
                0x8F,
                0x6C,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEqualizerBand
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x5A,
                0x0A,
                0xC0,
                0x2D,
                0x26,
                0x85,
                0x4B,
                0x9B,
                0xB7,
                0x43,
                0x28,
                0x0B,
                0x62,
                0xED,
                0x0C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEqualizerEffectDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1F,
                0x6F,
                0x3F,
                0x02,
                0xFE,
                0x83,
                0x9A,
                0x44,
                0xA8,
                0x22,
                0xC6,
                0x96,
                0x44,
                0x2D,
                0x16,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IEqualizerEffectDefinitionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC4,
                0x6F,
                0x87,
                0xD2,
                0x10,
                0xD4,
                0xB5,
                0x4E,
                0x9E,
                0x69,
                0xC9,
                0xAA,
                0x12,
                0x77,
                0xEA,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IFrameInputNodeQuantumStartedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x98,
                0xD4,
                0x9B,
                0x3D,
                0x06,
                0xA3,
                0x06,
                0x4F,
                0xBD,
                0x9F,
                0xE9,
                0xEF,
                0xC8,
                0x22,
                0x63,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILimiterEffectDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0x5D,
                0x75,
                0x6B,
                0x03,
                0x26,
                0xBA,
                0x47,
                0xBD,
                0xEB,
                0x39,
                0x05,
                0x5E,
                0x34,
                0x86,
                0xDC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILimiterEffectDefinitionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0xE6,
                0xBA,
                0xEC,
                0xFF,
                0x61,
                0xEF,
                0x45,
                0xB8,
                0xF5,
                0x48,
                0x65,
                0x9A,
                0x57,
                0xC7,
                0x2D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IMediaSourceAudioInputNode
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3B,
                0x98,
                0xD8,
                0x99,
                0x8A,
                0xA8,
                0x41,
                0x40,
                0x8E,
                0x4F,
                0xDD,
                0xBA,
                0xC0,
                0xC9,
                0x1F,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IReverbEffectDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xAA,
                0x06,
                0x46,
                0x63,
                0xF5,
                0x0A,
                0x4D,
                0x8F,
                0x6E,
                0xF0,
                0xCD,
                0xDF,
                0xF3,
                0x5D,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IReverbEffectDefinitionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFE,
                0xCB,
                0xD5,
                0xA7,
                0x0B,
                0x10,
                0xF0,
                0x4F,
                0x9D,
                0xA6,
                0xDC,
                0x4E,
                0x05,
                0xA7,
                0x59,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISetDefaultSpatialAudioFormatResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0xA5,
                0x2A,
                0x1C,
                0x00,
                0x14,
                0x70,
                0x5E,
                0x9E,
                0xA9,
                0xAE,
                0x15,
                0x12,
                0x41,
                0xE8,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioDeviceConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x34,
                0x00,
                0x83,
                0xEE,
                0xCF,
                0x61,
                0x49,
                0x57,
                0x9D,
                0xA4,
                0x10,
                0xF0,
                0xFE,
                0x02,
                0x81,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioDeviceConfigurationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0x7F,
                0xC3,
                0x3E,
                0x6D,
                0x93,
                0x04,
                0x4E,
                0x97,
                0x28,
                0x28,
                0x27,
                0xD9,
                0xF7,
                0x58,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioFormatConfiguration
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x09,
                0xDF,
                0x32,
                0xF0,
                0x50,
                0x95,
                0x53,
                0x99,
                0x23,
                0x7D,
                0x44,
                0xCA,
                0x71,
                0xED,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioFormatConfigurationStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xEF,
                0x5F,
                0x2B,
                0xC9,
                0x67,
                0x5F,
                0x4E,
                0xA3,
                0x5B,
                0x41,
                0x68,
                0x07,
                0x11,
                0xF8,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioFormatSubtypeStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0x8A,
                0xDE,
                0xB3,
                0xEE,
                0x83,
                0x66,
                0x42,
                0xA9,
                0x45,
                0xBE,
                0xDF,
                0x50,
                0x7A,
                0xFE,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpatialAudioFormatSubtypeStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xE6,
                0x65,
                0x45,
                0x5B,
                0xD9,
                0x21,
                0x56,
                0xB6,
                0xAF,
                0x0E,
                0x88,
                0x49,
                0xC5,
                0x7C,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
