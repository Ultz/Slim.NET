// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAudioCaptureEffectsManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x71,
                0xC2,
                0x85,
                0x8F,
                0x8D,
                0x03,
                0x93,
                0x43,
                0x82,
                0x98,
                0x54,
                0x01,
                0x10,
                0x60,
                0x8E,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0xFA,
                0xAA,
                0x34,
                0x07,
                0x92,
                0x55,
                0x40,
                0xBE,
                0x93,
                0x6E,
                0x57,
                0x34,
                0xA8,
                0x6A,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioEffectDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0xF9,
                0xD7,
                0xE4,
                0x80,
                0x7D,
                0x73,
                0x4F,
                0x90,
                0x89,
                0xE3,
                0x1C,
                0x9D,
                0xB9,
                0xC2,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioEffectDefinitionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0xA6,
                0x1D,
                0x8E,
                0x05,
                0xE7,
                0xED,
                0x45,
                0x8A,
                0x2B,
                0xFC,
                0x4E,
                0x4F,
                0x40,
                0x5A,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioEffectsManagerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x6C,
                0x40,
                0x66,
                0xFA,
                0x86,
                0xCC,
                0x47,
                0xA3,
                0x15,
                0xF4,
                0x89,
                0xD8,
                0xC3,
                0xFE,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioRenderEffectsManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x89,
                0xC9,
                0x4D,
                0x51,
                0x87,
                0xB2,
                0x42,
                0xBF,
                0xCB,
                0x39,
                0xCA,
                0x78,
                0x64,
                0xBD,
                0x47,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAudioRenderEffectsManager2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0xCD,
                0x44,
                0xA8,
                0xCC,
                0x5E,
                0xB3,
                0x44,
                0xBB,
                0x4E,
                0x1D,
                0xB0,
                0x72,
                0x87,
                0x13,
                0x9C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBasicAudioEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x53,
                0x2C,
                0x06,
                0x8C,
                0xC0,
                0x6B,
                0xB8,
                0x48,
                0xA9,
                0x9A,
                0x4B,
                0x41,
                0x55,
                0x0F,
                0x13,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBasicVideoEffect
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEF,
                0xC7,
                0x62,
                0x82,
                0x60,
                0xB3,
                0xBE,
                0x40,
                0x94,
                0x9B,
                0x2F,
                0xF4,
                0x2F,
                0xF3,
                0x56,
                0x93,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositeVideoFrameContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0x02,
                0x30,
                0x6C,
                0x14,
                0xF5,
                0x78,
                0x42,
                0xA5,
                0xF7,
                0xB9,
                0x18,
                0x80,
                0x49,
                0xD1,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessAudioFrameContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x46,
                0x29,
                0xD9,
                0x4C,
                0x22,
                0x12,
                0x27,
                0x4A,
                0xA5,
                0x86,
                0xFB,
                0x3E,
                0x20,
                0x27,
                0x32,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IProcessVideoFrameContext
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x0E,
                0x6F,
                0x27,
                0x61,
                0x64,
                0x1E,
                0x40,
                0xBA,
                0x78,
                0x0F,
                0xDA,
                0xD6,
                0x11,
                0x4E,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoCompositor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0xB4,
                0x10,
                0x85,
                0x0C,
                0x42,
                0x0F,
                0x42,
                0x96,
                0xC7,
                0x7C,
                0x98,
                0xBB,
                0xA1,
                0xFC,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoCompositorDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xB8,
                0x46,
                0x79,
                0x10,
                0x20,
                0xE3,
                0x4A,
                0x9A,
                0xB2,
                0x2C,
                0xEF,
                0x42,
                0xED,
                0xD4,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoCompositorDefinitionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x10,
                0xFD,
                0x66,
                0x43,
                0xB8,
                0x68,
                0x52,
                0x4D,
                0x89,
                0xB6,
                0x02,
                0xA9,
                0x68,
                0xCC,
                0xA8,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEffectDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x8C,
                0xF3,
                0x39,
                0x0F,
                0x8D,
                0x3E,
                0x4F,
                0x84,
                0xFC,
                0x2D,
                0x46,
                0xA5,
                0x29,
                0x79,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoEffectDefinitionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x9B,
                0x43,
                0x81,
                0x33,
                0x6E,
                0x8F,
                0x42,
                0x9D,
                0x21,
                0xB5,
                0xAA,
                0xFE,
                0xF7,
                0x61,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoTransformEffectDefinition
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0xBB,
                0x64,
                0x96,
                0xA6,
                0x1E,
                0xA6,
                0x4A,
                0x80,
                0x74,
                0xAB,
                0xE8,
                0x85,
                0x1E,
                0xCA,
                0xE2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoTransformEffectDefinition2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9F,
                0x08,
                0xA8,
                0xF0,
                0xC8,
                0x66,
                0x94,
                0x46,
                0x9F,
                0xD9,
                0x11,
                0x36,
                0xAB,
                0xF7,
                0x44,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVideoTransformSphericalProjection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x01,
                0x44,
                0xCF,
                0xF2,
                0x9B,
                0x39,
                0x4C,
                0x9F,
                0x41,
                0xE0,
                0x22,
                0x51,
                0x4A,
                0x84,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
