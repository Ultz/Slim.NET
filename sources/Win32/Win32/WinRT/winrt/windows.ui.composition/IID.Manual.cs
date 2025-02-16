// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_IAmbientLight
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x30,
                0x81,
                0xA4,
                0xC4,
                0xB7,
                0xF7,
                0x46,
                0xB9,
                0xBF,
                0xDA,
                0xF4,
                0x3A,
                0x44,
                0xE6,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAmbientLight2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0xA6,
                0x64,
                0x3B,
                0x97,
                0x5F,
                0x94,
                0x4C,
                0x86,
                0xE5,
                0x04,
                0x2D,
                0xD3,
                0x86,
                0xB2,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAnimationController
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0xEF,
                0x34,
                0xC9,
                0x22,
                0x07,
                0x5F,
                0x4F,
                0xA4,
                0xE2,
                0x95,
                0x10,
                0xF3,
                0xD4,
                0x3B,
                0xF7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAnimationControllerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x64,
                0x11,
                0xE7,
                0x1B,
                0x65,
                0x00,
                0x48,
                0xB9,
                0xE5,
                0x6A,
                0x3B,
                0xCF,
                0xED,
                0x33,
                0x65,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAnimationObject
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x1E,
                0x14,
                0xE7,
                0xB8,
                0x04,
                0xC5,
                0x4F,
                0xA4,
                0xDC,
                0x19,
                0x53,
                0x92,
                0xE5,
                0x78,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAnimationPropertyInfo
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x6F,
                0x71,
                0xF4,
                0x77,
                0xED,
                0x3C,
                0x4E,
                0xB3,
                0x28,
                0x5C,
                0x39,
                0x85,
                0xB3,
                0x73,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IAnimationPropertyInfo2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0x20,
                0x17,
                0x59,
                0x72,
                0x74,
                0x18,
                0x52,
                0x8B,
                0x39,
                0xDF,
                0xFE,
                0x61,
                0x5A,
                0xE6,
                0xDA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBackEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x0D,
                0x56,
                0xB8,
                0x3C,
                0x5E,
                0x5D,
                0x54,
                0xB2,
                0x63,
                0x79,
                0x87,
                0xA2,
                0xBD,
                0x27,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBooleanKeyFrameAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x3A,
                0xE2,
                0x95,
                0xF4,
                0xD1,
                0x72,
                0x49,
                0x97,
                0x70,
                0x3E,
                0xFE,
                0x68,
                0xD8,
                0x2E,
                0x14,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBounceEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0xB4,
                0xFD,
                0xE7,
                0xD5,
                0xAA,
                0x74,
                0x51,
                0x94,
                0x21,
                0xEE,
                0xF8,
                0xB7,
                0x5A,
                0x6A,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBounceScalarNaturalMotionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCC,
                0x0D,
                0xA3,
                0xBA,
                0x33,
                0xA6,
                0x18,
                0x46,
                0x9B,
                0x06,
                0x7F,
                0x7C,
                0x72,
                0xC8,
                0x7C,
                0xFF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBounceVector2NaturalMotionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0x41,
                0x34,
                0xDA,
                0x54,
                0x21,
                0x3C,
                0x4B,
                0x88,
                0xAA,
                0x47,
                0x36,
                0x12,
                0x04,
                0xEC,
                0xCD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IBounceVector3NaturalMotionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0xBC,
                0xDA,
                0x47,
                0xD3,
                0x10,
                0x18,
                0x45,
                0x86,
                0xF1,
                0x09,
                0xCA,
                0xF7,
                0x42,
                0xD1,
                0x13,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICircleEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2A,
                0x22,
                0x07,
                0x1E,
                0x82,
                0x6F,
                0x28,
                0x5A,
                0x87,
                0x48,
                0x2E,
                0x92,
                0xFC,
                0x46,
                0xEE,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IColorKeyFrameAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0xB5,
                0xAD,
                0x93,
                0x05,
                0x8E,
                0x93,
                0x45,
                0x84,
                0xA3,
                0xDC,
                0xA1,
                0x52,
                0x78,
                0x1E,
                0x56,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0x4C,
                0x4C,
                0x46,
                0xAA,
                0x1C,
                0x61,
                0x40,
                0x9B,
                0x40,
                0xE1,
                0x3F,
                0xDE,
                0x15,
                0x03,
                0xCA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionAnimation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x60,
                0x9B,
                0x36,
                0x0F,
                0xA8,
                0x48,
                0x49,
                0x93,
                0xE3,
                0xED,
                0x23,
                0xFB,
                0x38,
                0xC6,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionAnimation3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0x03,
                0x1E,
                0xD5,
                0xA4,
                0x7D,
                0xD7,
                0x4B,
                0xBC,
                0x2D,
                0xF4,
                0x51,
                0x75,
                0x29,
                0xF4,
                0x3A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionAnimation4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBE,
                0x37,
                0x01,
                0x77,
                0xBC,
                0x76,
                0x23,
                0x4E,
                0xBF,
                0xED,
                0xFE,
                0x9C,
                0xC2,
                0x0F,
                0x6E,
                0xC9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionAnimationBase
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x29,
                0x2C,
                0x1C,
                0x18,
                0xE8,
                0xD3,
                0x48,
                0xA6,
                0xDD,
                0xD7,
                0x8C,
                0x82,
                0xF8,
                0xAC,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionAnimationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFB,
                0xC4,
                0xF6,
                0x10,
                0x51,
                0x6E,
                0x25,
                0x4C,
                0xBB,
                0xD3,
                0x58,
                0x6A,
                0x9B,
                0xEC,
                0x3E,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionAnimationGroup
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0xC9,
                0x7C,
                0x5E,
                0x14,
                0xCD,
                0x07,
                0x4E,
                0x8A,
                0x55,
                0xC7,
                0x25,
                0x27,
                0xAA,
                0xBD,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionBackdropBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0xAE,
                0xAC,
                0xC5,
                0x98,
                0x38,
                0x9E,
                0x49,
                0x8D,
                0x7F,
                0x22,
                0x4E,
                0x91,
                0x28,
                0x6A,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionBatchCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xDA,
                0x00,
                0x0D,
                0x64,
                0x94,
                0x0A,
                0x45,
                0xA5,
                0x62,
                0x2E,
                0x26,
                0x98,
                0xB0,
                0xA8,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0x76,
                0x0D,
                0xAB,
                0xC0,
                0x30,
                0xE9,
                0x40,
                0xB5,
                0x68,
                0xB6,
                0x0A,
                0x6B,
                0xD1,
                0xFB,
                0x46,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionBrushFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0xFB,
                0x53,
                0xDA,
                0x50,
                0x46,
                0xC4,
                0x47,
                0xAD,
                0x76,
                0x76,
                0x53,
                0x79,
                0x60,
                0x7E,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionCapabilities
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0x35,
                0x53,
                0x82,
                0x17,
                0xB5,
                0xBC,
                0x48,
                0xB1,
                0xE8,
                0x4B,
                0x35,
                0x61,
                0xA2,
                0xE1,
                0x81,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionCapabilitiesStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6E,
                0xA8,
                0xB7,
                0xF7,
                0x16,
                0x64,
                0xE5,
                0x49,
                0x8D,
                0xDF,
                0xAF,
                0xE9,
                0x49,
                0xE2,
                0x05,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionClip
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x52,
                0x2A,
                0xCD,
                0x1C,
                0xC7,
                0xCF,
                0xCE,
                0x4A,
                0x99,
                0x83,
                0x14,
                0x6B,
                0xB8,
                0xEB,
                0x6A,
                0x3C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionClip2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x69,
                0xE0,
                0x93,
                0x58,
                0x16,
                0x35,
                0xE1,
                0x40,
                0x89,
                0xE0,
                0x5B,
                0xA9,
                0x24,
                0x92,
                0x72,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionClipFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x4C,
                0x48,
                0xB9,
                0xC7,
                0x20,
                0xED,
                0x4A,
                0xAC,
                0x4A,
                0x9C,
                0x78,
                0xBA,
                0x13,
                0x02,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionColorBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x4C,
                0x26,
                0x2B,
                0x35,
                0xBF,
                0x31,
                0x48,
                0x86,
                0x42,
                0xCF,
                0x70,
                0xC2,
                0x0F,
                0xFF,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionColorGradientStop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0xCA,
                0x00,
                0x6F,
                0x01,
                0xC8,
                0x41,
                0x4E,
                0x9A,
                0x8F,
                0xA5,
                0x3E,
                0x20,
                0xF5,
                0x77,
                0x78,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionColorGradientStopCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEC,
                0x20,
                0x1D,
                0x9F,
                0x04,
                0x7B,
                0x1D,
                0x4B,
                0x90,
                0xBC,
                0x9F,
                0xA3,
                0x2C,
                0x0C,
                0xFD,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionCommitBatch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xDA,
                0x00,
                0x0D,
                0x07,
                0xCA,
                0x00,
                0x44,
                0x8C,
                0x8E,
                0xCB,
                0x5D,
                0xB0,
                0x85,
                0x59,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionContainerShape
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x85,
                0x5E,
                0x4F,
                0x5B,
                0x2E,
                0xA8,
                0x44,
                0x98,
                0x2C,
                0xAA,
                0x0F,
                0x69,
                0xC1,
                0x60,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionDrawingSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0xC3,
                0x66,
                0xA1,
                0xD0,
                0xFA,
                0x11,
                0x4D,
                0x9E,
                0x67,
                0xE4,
                0x33,
                0x16,
                0x2F,
                0xF4,
                0x9E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionDrawingSurface2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0xE8,
                0xD0,
                0xFA,
                0x54,
                0xE3,
                0xE8,
                0x44,
                0x8E,
                0x3D,
                0xC4,
                0x88,
                0x0D,
                0x5A,
                0x21,
                0x3F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionDrawingSurfaceFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0xB0,
                0x97,
                0x94,
                0x2D,
                0x31,
                0xB9,
                0x46,
                0x9D,
                0xB3,
                0x41,
                0x2F,
                0xD7,
                0x94,
                0x64,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x56,
                0xE3,
                0x45,
                0x51,
                0x79,
                0xBF,
                0xA8,
                0x4E,
                0x8C,
                0xC2,
                0x6B,
                0x5B,
                0x47,
                0x2E,
                0x6C,
                0x9A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionEasingFunctionFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x07,
                0x84,
                0x60,
                0xA0,
                0x3D,
                0x49,
                0x49,
                0x82,
                0x00,
                0x72,
                0x06,
                0xC0,
                0x01,
                0x90,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionEasingFunctionStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB6,
                0x66,
                0xA7,
                0x17,
                0x36,
                0x29,
                0xEA,
                0x53,
                0xB5,
                0xAF,
                0xC6,
                0x42,
                0xF4,
                0xA6,
                0x10,
                0x83,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionEffectBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x79,
                0x7F,
                0xBF,
                0xCC,
                0x83,
                0xBF,
                0x44,
                0xA4,
                0x47,
                0x3E,
                0x3C,
                0x07,
                0x17,
                0x89,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionEffectFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAF,
                0x24,
                0x56,
                0xBE,
                0x7E,
                0xBA,
                0x10,
                0x45,
                0x98,
                0x50,
                0x41,
                0xC0,
                0xB4,
                0xFF,
                0x74,
                0xDF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionEffectSourceParameter
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3A,
                0xB1,
                0x8A,
                0x85,
                0x92,
                0x32,
                0x4E,
                0x4E,
                0xB3,
                0xBB,
                0x2B,
                0x6C,
                0x65,
                0x44,
                0xA6,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionEffectSourceParameterFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0xF2,
                0xD9,
                0xB3,
                0xA3,
                0xAB,
                0x24,
                0x47,
                0xAC,
                0xF3,
                0xD0,
                0x39,
                0x74,
                0x64,
                0xDB,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionEllipseGeometry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x84,
                0xF8,
                0x01,
                0x48,
                0xAD,
                0xF6,
                0x93,
                0x4B,
                0xAF,
                0xA9,
                0x89,
                0x7B,
                0x64,
                0xE5,
                0x7B,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGeometricClip
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0xB5,
                0x40,
                0xC8,
                0xC9,
                0x81,
                0x44,
                0x44,
                0xA2,
                0xC1,
                0xCC,
                0xAE,
                0xCE,
                0x3A,
                0x50,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGeometry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x21,
                0x85,
                0xE9,
                0x17,
                0x6A,
                0x07,
                0x42,
                0xAB,
                0xD8,
                0x5F,
                0xD3,
                0xDD,
                0x61,
                0x2A,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGeometryFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0xBF,
                0xFE,
                0xBF,
                0x25,
                0x8C,
                0x0B,
                0x48,
                0x9F,
                0x56,
                0xFE,
                0xD6,
                0xB2,
                0x88,
                0x05,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGradientBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE0,
                0x09,
                0x97,
                0x1D,
                0xC6,
                0xFF,
                0x0E,
                0x4C,
                0xA9,
                0xAB,
                0x34,
                0x14,
                0x4D,
                0x4C,
                0x90,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGradientBrush2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0xD5,
                0x9D,
                0x89,
                0xC7,
                0xB4,
                0x33,
                0x4B,
                0xA1,
                0xB6,
                0x26,
                0x4A,
                0xDD,
                0xC2,
                0x6D,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGradientBrushFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD7,
                0x65,
                0xD7,
                0x56,
                0x89,
                0xF1,
                0xC9,
                0x48,
                0x9C,
                0x8D,
                0x94,
                0xDA,
                0xF1,
                0xBE,
                0xC0,
                0x10,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGraphicsDevice
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE1,
                0xC6,
                0x22,
                0xFB,
                0xA2,
                0x80,
                0x67,
                0x46,
                0x99,
                0x36,
                0xDB,
                0xEA,
                0xF6,
                0xEE,
                0xFE,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGraphicsDevice2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF6,
                0xBD,
                0xB8,
                0x0F,
                0xF0,
                0xC0,
                0xCC,
                0x4B,
                0x9F,
                0xB8,
                0x08,
                0x49,
                0x82,
                0x49,
                0x0D,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGraphicsDevice3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x14,
                0x75,
                0xF6,
                0x37,
                0xEF,
                0xD3,
                0xD1,
                0x49,
                0xB6,
                0x9D,
                0x0D,
                0x8E,
                0xAB,
                0xEB,
                0x36,
                0x26,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionGraphicsDevice4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0xBF,
                0x73,
                0x5A,
                0x7F,
                0xA9,
                0xF5,
                0x4C,
                0xBA,
                0x46,
                0x98,
                0xEF,
                0x35,
                0x8E,
                0x71,
                0xB1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionLight
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC2,
                0xD7,
                0xA6,
                0x41,
                0x5D,
                0x2E,
                0xC1,
                0x4B,
                0xB0,
                0x9E,
                0x8F,
                0x0A,
                0x03,
                0xE3,
                0xD8,
                0xD3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionLight2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0xDA,
                0xBC,
                0xA7,
                0x5D,
                0xF3,
                0x5D,
                0x42,
                0x9B,
                0x98,
                0x23,
                0xF4,
                0x20,
                0x5F,
                0x66,
                0x69,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionLight3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x00,
                0x0B,
                0x4B,
                0x07,
                0xDF,
                0x59,
                0x49,
                0xB7,
                0xA4,
                0x4F,
                0x7E,
                0x42,
                0x33,
                0xF8,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionLightFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xF3,
                0x9C,
                0x06,
                0x3C,
                0xDA,
                0x44,
                0x4B,
                0x83,
                0x8A,
                0x5E,
                0x03,
                0xD5,
                0x1A,
                0xCE,
                0x55,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionLineGeometry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x15,
                0x76,
                0xDD,
                0x9A,
                0x0C,
                0x67,
                0x4B,
                0x8D,
                0xCE,
                0x44,
                0x0A,
                0x5B,
                0xF9,
                0xCD,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionLinearGradientBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0xC5,
                0x3B,
                0x98,
                0xDB,
                0xA9,
                0x3C,
                0x41,
                0xA2,
                0xD8,
                0x2A,
                0x90,
                0x56,
                0xFC,
                0x52,
                0x5E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionMaskBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0xF0,
                0x2C,
                0x52,
                0x6B,
                0xBE,
                0x41,
                0x4F,
                0xBE,
                0x49,
                0xF9,
                0x22,
                0x6D,
                0x47,
                0x1B,
                0x4A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionMipmapSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0x67,
                0x63,
                0x48,
                0x4A,
                0xCF,
                0x1C,
                0x4B,
                0x9E,
                0xCE,
                0xC5,
                0xEC,
                0x0C,
                0x2B,
                0x2F,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionNineGridBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0x54,
                0x51,
                0xF2,
                0x8C,
                0xBC,
                0xE7,
                0x4B,
                0xB8,
                0x0F,
                0x86,
                0x85,
                0xB8,
                0x3C,
                0x01,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionObject
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x45,
                0xAD,
                0xB4,
                0xBC,
                0x09,
                0x76,
                0x50,
                0x45,
                0x93,
                0x4F,
                0x16,
                0x00,
                0x2A,
                0x68,
                0xFD,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionObject2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA1,
                0x4E,
                0x87,
                0xEF,
                0xFF,
                0x5C,
                0x68,
                0x4B,
                0x9E,
                0x30,
                0xA1,
                0x51,
                0x9D,
                0x08,
                0xBA,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionObject3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x79,
                0xC2,
                0x4B,
                0xCD,
                0xDA,
                0xF2,
                0x4C,
                0x98,
                0xB1,
                0x98,
                0x6B,
                0x76,
                0xE7,
                0xEB,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionObject4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x78,
                0xB3,
                0x0B,
                0x6B,
                0x34,
                0x7C,
                0x4A,
                0x96,
                0x6B,
                0x73,
                0x10,
                0x96,
                0x65,
                0x53,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionObject5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x39,
                0x7F,
                0x1D,
                0x30,
                0xA1,
                0x65,
                0x52,
                0xA6,
                0x2B,
                0x60,
                0xB8,
                0xE6,
                0x68,
                0x96,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionObjectFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x5C,
                0x20,
                0x51,
                0x8A,
                0x55,
                0x2A,
                0x4F,
                0x8D,
                0x39,
                0x37,
                0xBF,
                0xE1,
                0xE2,
                0x0D,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionObjectStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x05,
                0xED,
                0xC1,
                0xA2,
                0x1B,
                0xBA,
                0x44,
                0xA9,
                0x04,
                0x6A,
                0x88,
                0x2A,
                0x0A,
                0x5A,
                0xDB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionPath
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0x1D,
                0xDA,
                0x66,
                0x10,
                0x2E,
                0x22,
                0x4F,
                0x8A,
                0x06,
                0x0A,
                0x81,
                0x51,
                0x91,
                0x9E,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionPathFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6A,
                0x8C,
                0x1E,
                0x9C,
                0x33,
                0x0F,
                0x51,
                0x47,
                0x94,
                0x37,
                0xEB,
                0x3F,
                0xB9,
                0xD3,
                0xAB,
                0x07,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionPathGeometry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7E,
                0x41,
                0x6A,
                0x0B,
                0x77,
                0x2C,
                0x23,
                0x4C,
                0xAF,
                0x5E,
                0x63,
                0x04,
                0xC1,
                0x47,
                0xBB,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionProjectedShadow
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x8E,
                0x5B,
                0x28,
                0x28,
                0x43,
                0x3F,
                0x52,
                0xBC,
                0xF2,
                0x55,
                0x57,
                0xC5,
                0x2C,
                0x3B,
                0x25,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionProjectedShadowCaster
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0xD4,
                0xD7,
                0xB1,
                0x36,
                0x1E,
                0x62,
                0x5A,
                0xBE,
                0x56,
                0xA1,
                0x61,
                0x12,
                0xFD,
                0xD1,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionProjectedShadowCasterCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0x5C,
                0x52,
                0xD2,
                0x7F,
                0xE0,
                0xA3,
                0x58,
                0xAC,
                0x91,
                0x37,
                0xF7,
                0x3E,
                0xE9,
                0x17,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionProjectedShadowCasterCollectionStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0xB1,
                0xFB,
                0x56,
                0x4F,
                0xE9,
                0x99,
                0x52,
                0xAB,
                0x5B,
                0x6E,
                0x15,
                0xE3,
                0x8B,
                0xD8,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionProjectedShadowReceiver
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x98,
                0x77,
                0x13,
                0x49,
                0x6A,
                0x6A,
                0x53,
                0x9B,
                0xE4,
                0xA9,
                0x6A,
                0x8E,
                0x52,
                0x98,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionProjectedShadowReceiverUnorderedCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB7,
                0xE3,
                0xB3,
                0x02,
                0xD2,
                0x27,
                0x9F,
                0x59,
                0xAC,
                0x4B,
                0xAB,
                0x78,
                0x7C,
                0xDD,
                0xE6,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionPropertySet
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x02,
                0xD2,
                0xD6,
                0xC9,
                0x67,
                0x5F,
                0x53,
                0x44,
                0x91,
                0x17,
                0x9E,
                0xAD,
                0xD4,
                0x30,
                0xD3,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionPropertySet2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x73,
                0x80,
                0xDE,
                0x11,
                0xA2,
                0x55,
                0x44,
                0x88,
                0x80,
                0x7D,
                0x0F,
                0x3F,
                0x6A,
                0x44,
                0xFD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionRadialGradientBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0x50,
                0x3B,
                0x3D,
                0xFA,
                0xE3,
                0xE2,
                0x4C,
                0xB9,
                0xFC,
                0x3E,
                0xE1,
                0x25,
                0x61,
                0x78,
                0x8F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionRectangleGeometry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x14,
                0xD5,
                0x0C,
                0x56,
                0x53,
                0x46,
                0x42,
                0xAE,
                0xCF,
                0x7A,
                0x0B,
                0x76,
                0x97,
                0x54,
                0x00,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionRoundedRectangleGeometry
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0xC8,
                0x70,
                0x87,
                0x50,
                0x1D,
                0x8B,
                0x4B,
                0xB0,
                0x13,
                0x7C,
                0x9A,
                0x0E,
                0x46,
                0x93,
                0x5F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionScopedBatch
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0xDA,
                0x00,
                0x0D,
                0x07,
                0xFB,
                0xFD,
                0x46,
                0x8C,
                0x72,
                0x62,
                0x80,
                0xD1,
                0xA3,
                0xD1,
                0xDD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionShadow
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0x52,
                0x9E,
                0x32,
                0x35,
                0x43,
                0xCC,
                0x49,
                0xB1,
                0x4A,
                0x37,
                0x78,
                0x2D,
                0x10,
                0xF0,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionShadowFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x49,
                0x1F,
                0x22,
                0xBA,
                0xDC,
                0x91,
                0x4B,
                0x99,
                0x9E,
                0x1D,
                0xC2,
                0x17,
                0xA0,
                0x15,
                0x30,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionShape
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF7,
                0xE2,
                0x7C,
                0xB4,
                0x88,
                0x9A,
                0xC4,
                0x42,
                0x9E,
                0x87,
                0x2E,
                0x50,
                0x0C,
                0xA8,
                0x68,
                0x8C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionShapeFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x36,
                0xFC,
                0x1D,
                0x5A,
                0xB0,
                0xEF,
                0x44,
                0x82,
                0xB0,
                0x12,
                0x11,
                0x8B,
                0xCD,
                0x4C,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionSpriteShape
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x61,
                0x1B,
                0x40,
                0x07,
                0x00,
                0x63,
                0x43,
                0xB1,
                0xF3,
                0x6B,
                0xCC,
                0x00,
                0x3F,
                0xB8,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionSupportsSystemBackdrop
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE4,
                0xAF,
                0x7D,
                0x39,
                0xC2,
                0xB6,
                0xB9,
                0x5B,
                0x95,
                0x1D,
                0xF5,
                0x70,
                0x7D,
                0xE8,
                0xB7,
                0xBC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0x54,
                0x27,
                0x15,
                0xC7,
                0x42,
                0xA6,
                0x47,
                0xA4,
                0x08,
                0x66,
                0x8F,
                0x79,
                0xA9,
                0x0D,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionSurfaceBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0x6D,
                0x01,
                0xAD,
                0x4C,
                0x1E,
                0x0D,
                0x4C,
                0x9C,
                0x29,
                0x83,
                0x33,
                0x8C,
                0x87,
                0xC1,
                0x62,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionSurfaceBrush2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x74,
                0x71,
                0xD2,
                0xF5,
                0x64,
                0x92,
                0x46,
                0x9D,
                0xC7,
                0x71,
                0xB6,
                0x1D,
                0x7E,
                0x58,
                0x80,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionSurfaceBrush3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x89,
                0xB2,
                0x0B,
                0x55,
                0xE0,
                0x1F,
                0xE5,
                0x42,
                0x81,
                0x95,
                0x1E,
                0xEF,
                0xA8,
                0x7F,
                0xF0,
                0x8E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionSurfaceFacade
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x22,
                0x16,
                0xE0,
                0x32,
                0x23,
                0xC7,
                0x55,
                0x88,
                0x68,
                0xA7,
                0x31,
                0x2C,
                0x5C,
                0x22,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionTarget
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0xA8,
                0xBE,
                0xA1,
                0x26,
                0xD7,
                0x63,
                0x46,
                0x81,
                0x29,
                0x6B,
                0x5E,
                0x79,
                0x27,
                0xFF,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionTargetFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x9D,
                0xCD,
                0x93,
                0x16,
                0x85,
                0x14,
                0x4B,
                0xA8,
                0xCE,
                0xF4,
                0x9E,
                0x21,
                0x19,
                0xEC,
                0x42,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionTexture
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x03,
                0x7D,
                0x34,
                0x0A,
                0x1C,
                0x0B,
                0x4C,
                0xB2,
                0x32,
                0x85,
                0x70,
                0xB2,
                0xB1,
                0xA4,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionTextureFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3D,
                0x52,
                0xD9,
                0x09,
                0x1C,
                0x47,
                0xB5,
                0x5A,
                0xB0,
                0x53,
                0xB5,
                0x68,
                0xEE,
                0x46,
                0xEB,
                0xFB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionTransform
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x29,
                0x45,
                0xD5,
                0x7C,
                0xED,
                0xFB,
                0x12,
                0x41,
                0xAB,
                0xC5,
                0x18,
                0x59,
                0x06,
                0xDD,
                0x92,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionTransformFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0xCA,
                0xAE,
                0xAA,
                0x49,
                0xC1,
                0x7A,
                0x51,
                0x8F,
                0x72,
                0x6B,
                0xFF,
                0x7A,
                0x65,
                0xCE,
                0x08,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionViewBox
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0xBF,
                0x40,
                0xB4,
                0x8F,
                0x06,
                0x37,
                0x45,
                0x84,
                0xC6,
                0x4E,
                0xCB,
                0xE0,
                0x19,
                0xE1,
                0xF4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionVirtualDrawingSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDB,
                0x84,
                0xC3,
                0xA9,
                0x40,
                0x87,
                0x94,
                0x4F,
                0x8B,
                0x9D,
                0xB6,
                0x85,
                0x21,
                0xE7,
                0x86,
                0x3D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionVirtualDrawingSurfaceFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x6C,
                0x10,
                0x66,
                0x67,
                0x6B,
                0xD5,
                0x49,
                0x4A,
                0xB1,
                0xDF,
                0x50,
                0x76,
                0xA0,
                0x62,
                0x07,
                0x68,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositionVisualSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x03,
                0xD8,
                0x24,
                0xB2,
                0x6E,
                0x4F,
                0x3F,
                0x4A,
                0x8C,
                0xAE,
                0x3D,
                0xC1,
                0xCD,
                0xA7,
                0x4F,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositor
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x50,
                0xCA,
                0x03,
                0xB4,
                0x8C,
                0x7F,
                0x83,
                0x4E,
                0x98,
                0x5F,
                0xCC,
                0x45,
                0x06,
                0x00,
                0x36,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositor2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDC,
                0x81,
                0x50,
                0x73,
                0x24,
                0x5E,
                0xDA,
                0x45,
                0xA3,
                0x8F,
                0xE3,
                0x2C,
                0xC3,
                0x49,
                0xA9,
                0xA0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositor3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF0,
                0x8E,
                0xDD,
                0xC9,
                0xB1,
                0x6E,
                0x3C,
                0x4E,
                0xA6,
                0x58,
                0x67,
                0x5D,
                0x9C,
                0x64,
                0xD4,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositor4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8A,
                0xE7,
                0x47,
                0xAE,
                0x10,
                0x79,
                0x25,
                0x44,
                0xA4,
                0x82,
                0xA0,
                0x5B,
                0x75,
                0x8A,
                0xDC,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositor5
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x31,
                0xEA,
                0x48,
                0xCD,
                0x7F,
                0x76,
                0x40,
                0xA7,
                0x9C,
                0x90,
                0xCC,
                0x4B,
                0x85,
                0x2C,
                0x9B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositor6
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBD,
                0xB2,
                0x38,
                0x7A,
                0xC8,
                0xCE,
                0xEB,
                0x4E,
                0x83,
                0x0F,
                0xD8,
                0xD0,
                0x7A,
                0xED,
                0xEB,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositor7
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAD,
                0x3F,
                0x48,
                0xD3,
                0x12,
                0x9A,
                0xBA,
                0x53,
                0xBF,
                0xC8,
                0x88,
                0xB7,
                0xFF,
                0x79,
                0x77,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositor8
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE2,
                0xDE,
                0x0B,
                0x9A,
                0x7B,
                0xFE,
                0x62,
                0x5F,
                0xA3,
                0x66,
                0x9C,
                0xF8,
                0xEF,
                0xFE,
                0x21,
                0x12,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositorStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0xB9,
                0x0D,
                0x08,
                0x1E,
                0x12,
                0x97,
                0x4D,
                0x8B,
                0x74,
                0x1D,
                0xFC,
                0xF9,
                0x19,
                0x87,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositorWithBlurredWallpaperBackdropBrush
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0xB1,
                0x8F,
                0x0D,
                0x22,
                0xF1,
                0x8D,
                0x5B,
                0x9F,
                0xDD,
                0x54,
                0x3B,
                0x0D,
                0x8E,
                0xB7,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositorWithProjectedShadow
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0E,
                0x33,
                0xE6,
                0xA2,
                0x60,
                0x8A,
                0x38,
                0x5A,
                0xBB,
                0x85,
                0xB4,
                0x4E,
                0xA9,
                0x01,
                0x67,
                0x7C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositorWithRadialGradient
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA7,
                0xC1,
                0xB9,
                0x98,
                0x71,
                0x8E,
                0x53,
                0x4B,
                0xB4,
                0xA8,
                0x69,
                0xBA,
                0x5D,
                0x19,
                0xDC,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICompositorWithVisualSurface
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8B,
                0x65,
                0xA1,
                0xCF,
                0x23,
                0x01,
                0x51,
                0x45,
                0x88,
                0x91,
                0x89,
                0xBD,
                0xCC,
                0x40,
                0x32,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContainerVisual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0xBC,
                0xF6,
                0x02,
                0x20,
                0xED,
                0x73,
                0x47,
                0xAF,
                0xE6,
                0xD4,
                0x9B,
                0x4A,
                0x93,
                0xDB,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IContainerVisualFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0xA6,
                0x63,
                0x03,
                0xDA,
                0xC7,
                0x9A,
                0x4D,
                0x95,
                0xF4,
                0x69,
                0xB5,
                0xC8,
                0xDF,
                0x67,
                0x0B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ICubicBezierEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0x06,
                0x35,
                0x32,
                0xE8,
                0xC1,
                0xF9,
                0x44,
                0x96,
                0xB8,
                0xC9,
                0x8A,
                0xCF,
                0x0A,
                0xE6,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDelegatedInkTrailVisual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB1,
                0x60,
                0x6E,
                0x85,
                0xAB,
                0xE1,
                0x23,
                0x5B,
                0x8E,
                0x3D,
                0xD5,
                0x13,
                0xF2,
                0x21,
                0xC9,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDelegatedInkTrailVisualStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x6B,
                0xAF,
                0x0D,
                0xC6,
                0x42,
                0x5C,
                0x55,
                0x92,
                0x67,
                0xE0,
                0xAC,
                0x66,
                0x3A,
                0xF8,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDistantLight
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xFA,
                0x8C,
                0x31,
                0xE3,
                0x5C,
                0x55,
                0x4B,
                0xAB,
                0x5D,
                0x07,
                0xA0,
                0x03,
                0x53,
                0xAC,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDistantLight2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1C,
                0xAA,
                0xCD,
                0xDB,
                0x4B,
                0x29,
                0xD7,
                0x48,
                0xB6,
                0x0E,
                0x76,
                0xDF,
                0x64,
                0xAA,
                0x39,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDropShadow
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x07,
                0x7C,
                0x97,
                0xCB,
                0x54,
                0xA1,
                0x51,
                0x48,
                0x85,
                0xE7,
                0xA8,
                0x92,
                0x4C,
                0x84,
                0xFA,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IDropShadow2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBC,
                0x18,
                0x42,
                0x6C,
                0xB9,
                0x15,
                0x2D,
                0x4C,
                0x8D,
                0x4A,
                0x07,
                0x67,
                0xDF,
                0x11,
                0x97,
                0x7A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IElasticEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x62,
                0xDE,
                0x66,
                0x4E,
                0x05,
                0x94,
                0x55,
                0x84,
                0x75,
                0xC2,
                0x2C,
                0xB5,
                0x1F,
                0x1B,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IExponentialEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x51,
                0x1A,
                0x7D,
                0x6F,
                0xD2,
                0x98,
                0x38,
                0x56,
                0xA3,
                0x4A,
                0x00,
                0x48,
                0x65,
                0x54,
                0xC7,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IExpressionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x31,
                0x54,
                0xCC,
                0x6A,
                0x3D,
                0x7D,
                0xF3,
                0x4B,
                0xAB,
                0xB6,
                0xF4,
                0x4B,
                0xDC,
                0x48,
                0x88,
                0xC1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IImplicitAnimationCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFF,
                0xA3,
                0x98,
                0x05,
                0x92,
                0x0A,
                0x9D,
                0x4C,
                0xA4,
                0x27,
                0xB2,
                0x55,
                0x19,
                0x25,
                0x0D,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IInsetClip
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x47,
                0xE6,
                0x73,
                0x1E,
                0xC7,
                0x84,
                0x7A,
                0x47,
                0xB4,
                0x74,
                0x58,
                0x80,
                0xE0,
                0x44,
                0x2E,
                0x15,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyFrameAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x7F,
                0x6E,
                0x12,
                0xE9,
                0x3A,
                0x40,
                0x45,
                0x9A,
                0x8A,
                0xDE,
                0xAE,
                0x8A,
                0x4A,
                0x4A,
                0x84,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyFrameAnimation2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x88,
                0xB4,
                0xF4,
                0x40,
                0x29,
                0xC0,
                0x4E,
                0xA4,
                0x1A,
                0xEB,
                0x6D,
                0x80,
                0x1A,
                0x2F,
                0x18,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyFrameAnimation3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB4,
                0xF0,
                0x5B,
                0x84,
                0xDE,
                0xD8,
                0x2F,
                0x46,
                0x87,
                0x53,
                0xC8,
                0x0D,
                0x43,
                0xC6,
                0xFF,
                0x5A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IKeyFrameAnimationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF8,
                0x03,
                0x08,
                0xBF,
                0x2A,
                0x71,
                0xC1,
                0x4F,
                0x8C,
                0x87,
                0x97,
                0x08,
                0x59,
                0xED,
                0x8D,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILayerVisual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x85,
                0x39,
                0x84,
                0xAF,
                0x44,
                0x04,
                0x87,
                0x48,
                0x8E,
                0x83,
                0xB4,
                0x0B,
                0x25,
                0x3F,
                0x82,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILayerVisual2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0xAE,
                0xF9,
                0x98,
                0x23,
                0x6F,
                0xF1,
                0x49,
                0x90,
                0xB1,
                0x1F,
                0x59,
                0xA1,
                0x4F,
                0xBC,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ILinearEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x97,
                0x00,
                0x94,
                0xA6,
                0xC7,
                0xB3,
                0x46,
                0xAC,
                0xF7,
                0x1A,
                0x26,
                0x8A,
                0x0A,
                0x11,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INaturalMotionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0xE1,
                0x8D,
                0x43,
                0x9B,
                0x76,
                0x21,
                0x48,
                0xA9,
                0x49,
                0x28,
                0x4A,
                0x65,
                0x47,
                0xE8,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_INaturalMotionAnimationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x06,
                0xCB,
                0x3A,
                0xF5,
                0x6A,
                0xCF,
                0x87,
                0x43,
                0xA3,
                0xFE,
                0x52,
                0x21,
                0xF3,
                0xE7,
                0xE0,
                0xE0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPathKeyFrameAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC9,
                0x18,
                0x0D,
                0x9D,
                0x76,
                0x15,
                0x3F,
                0x4B,
                0xBE,
                0x60,
                0x1D,
                0x50,
                0x31,
                0xF5,
                0xE7,
                0x1B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointLight
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB3,
                0x45,
                0x85,
                0xB1,
                0x5A,
                0x0C,
                0xB0,
                0x4A,
                0xBE,
                0xDC,
                0x4F,
                0x35,
                0x46,
                0x94,
                0x82,
                0x72,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointLight2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0x8F,
                0xE9,
                0xEF,
                0x78,
                0x06,
                0x69,
                0x4F,
                0xB1,
                0x64,
                0xA8,
                0x10,
                0xD9,
                0x95,
                0xBC,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPointLight3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x67,
                0x83,
                0x0A,
                0x4C,
                0xE9,
                0xD4,
                0x8A,
                0x46,
                0x87,
                0xAE,
                0x7B,
                0xA4,
                0x3A,
                0xB2,
                0x94,
                0x85,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IPowerEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD6,
                0x53,
                0xFF,
                0xC3,
                0x8B,
                0x13,
                0x15,
                0x58,
                0x89,
                0x1A,
                0xB7,
                0xF6,
                0x15,
                0xCC,
                0xC5,
                0x63,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IQuaternionKeyFrameAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x35,
                0x58,
                0x4E,
                0x40,
                0xF6,
                0xEC,
                0x40,
                0x42,
                0x85,
                0x20,
                0x67,
                0x12,
                0x79,
                0xCF,
                0x36,
                0xBC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRectangleClip
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9E,
                0x54,
                0xE7,
                0xB3,
                0xB4,
                0x00,
                0x53,
                0x5B,
                0x8B,
                0xE8,
                0x35,
                0x3F,
                0x6C,
                0x43,
                0x31,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRedirectVisual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x40,
                0xE3,
                0xC6,
                0x8C,
                0x75,
                0x8B,
                0x22,
                0x54,
                0xB0,
                0x6F,
                0x09,
                0xFF,
                0xE9,
                0xF8,
                0x61,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IRenderingDeviceReplacedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0xAC,
                0x31,
                0x3A,
                0xBF,
                0x28,
                0x7A,
                0x4E,
                0x85,
                0x24,
                0x71,
                0x67,
                0x9D,
                0x48,
                0x0F,
                0x38,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScalarKeyFrameAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA9,
                0x8F,
                0x28,
                0xAE,
                0x2C,
                0x25,
                0x95,
                0x4B,
                0xA7,
                0x25,
                0xBF,
                0x85,
                0xE3,
                0x80,
                0x00,
                0xA1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScalarNaturalMotionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x45,
                0xA9,
                0x94,
                0x92,
                0xBF,
                0x5B,
                0x49,
                0xB5,
                0xBD,
                0xD2,
                0xC6,
                0x59,
                0x43,
                0x07,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IScalarNaturalMotionAnimationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xFC,
                0xA4,
                0x5A,
                0x83,
                0x1C,
                0x67,
                0xDD,
                0x41,
                0xAF,
                0x48,
                0xAE,
                0x8D,
                0xEF,
                0x8B,
                0x15,
                0x29,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IShapeVisual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC3,
                0x13,
                0xBD,
                0xF2,
                0x7E,
                0xBA,
                0x0F,
                0x4B,
                0x91,
                0x26,
                0xFF,
                0xB7,
                0x53,
                0x6B,
                0x81,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISineEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBF,
                0x18,
                0xB5,
                0xF1,
                0x63,
                0x95,
                0x74,
                0x54,
                0xBD,
                0x13,
                0x44,
                0xB2,
                0xDF,
                0x4B,
                0x1D,
                0x58,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpotLight
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x73,
                0xE2,
                0x9F,
                0x5A,
                0xA1,
                0x44,
                0x95,
                0x4F,
                0xA4,
                0x22,
                0x8F,
                0xA5,
                0x11,
                0x6B,
                0xDB,
                0x44,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpotLight2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5E,
                0x61,
                0xEE,
                0x64,
                0x86,
                0x06,
                0xEA,
                0x4D,
                0xA9,
                0xE8,
                0xBC,
                0x3A,
                0x8C,
                0x70,
                0x14,
                0x59,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpotLight3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEA,
                0x3E,
                0xD0,
                0xE4,
                0x1F,
                0x13,
                0x0E,
                0x48,
                0x85,
                0x9E,
                0xB8,
                0x27,
                0x05,
                0xB7,
                0x43,
                0x60,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpringScalarNaturalMotionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5F,
                0xA9,
                0x72,
                0x05,
                0xF9,
                0x37,
                0xBE,
                0x4F,
                0xB8,
                0x7B,
                0x5C,
                0xD0,
                0x3A,
                0x89,
                0x50,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpringVector2NaturalMotionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB5,
                0x94,
                0xF4,
                0x23,
                0x73,
                0xEE,
                0x0F,
                0x4F,
                0xA4,
                0x23,
                0x40,
                0x2B,
                0x94,
                0x6D,
                0xF4,
                0xB3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpringVector3NaturalMotionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x49,
                0x87,
                0x6C,
                0x7B,
                0xD5,
                0x94,
                0x47,
                0x8E,
                0x2D,
                0xCE,
                0xCB,
                0x11,
                0xE1,
                0x94,
                0xE5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpriteVisual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x55,
                0xE0,
                0x08,
                0xD1,
                0x1A,
                0x97,
                0x4F,
                0x97,
                0x57,
                0x40,
                0x2D,
                0x76,
                0xE4,
                0x23,
                0x3B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpriteVisual2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x96,
                0x8C,
                0x58,
                0x7A,
                0x99,
                0x50,
                0x48,
                0x91,
                0xFE,
                0x53,
                0xCB,
                0x58,
                0xF8,
                0x1C,
                0xE9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IStepEasingFunction
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4B,
                0xA7,
                0xCA,
                0xD0,
                0x0C,
                0x56,
                0x0B,
                0x4A,
                0xA5,
                0xF6,
                0x20,
                0x6C,
                0xA8,
                0xC3,
                0xEC,
                0xD6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVector2KeyFrameAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0x45,
                0x41,
                0xDF,
                0x29,
                0x4E,
                0x11,
                0x4F,
                0xB5,
                0x5E,
                0xBF,
                0x2A,
                0x6E,
                0xB3,
                0x62,
                0x94,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVector2NaturalMotionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7D,
                0x0B,
                0x3E,
                0x0F,
                0x12,
                0xE5,
                0x9D,
                0x47,
                0xA0,
                0x0C,
                0x77,
                0xC9,
                0x3A,
                0x30,
                0xA3,
                0x95,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVector2NaturalMotionAnimationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0xFF,
                0x74,
                0x8C,
                0x61,
                0x07,
                0xA2,
                0x48,
                0xBD,
                0xDB,
                0x6A,
                0xFC,
                0xC5,
                0x2B,
                0x89,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVector3KeyFrameAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0x9D,
                0x03,
                0xC8,
                0x81,
                0xA2,
                0xC2,
                0x43,
                0xA7,
                0x3D,
                0xB6,
                0x8E,
                0x3C,
                0x53,
                0x3C,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVector3NaturalMotionAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2C,
                0x04,
                0x17,
                0x9C,
                0xCA,
                0xE2,
                0xAD,
                0x45,
                0x96,
                0x9E,
                0x4E,
                0x78,
                0xB7,
                0xB9,
                0xAD,
                0x41,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVector3NaturalMotionAnimationFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2F,
                0x1D,
                0xA8,
                0x21,
                0x80,
                0x08,
                0x7B,
                0x45,
                0xAC,
                0x87,
                0xB6,
                0x09,
                0x01,
                0x8C,
                0x87,
                0x6D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVector4KeyFrameAnimation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5B,
                0x94,
                0x57,
                0x24,
                0xDD,
                0xAD,
                0x85,
                0x43,
                0x96,
                0x06,
                0xB6,
                0xA3,
                0xD5,
                0xE4,
                0xE1,
                0xB9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisual
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2D,
                0x20,
                0x7E,
                0x11,
                0x59,
                0xA8,
                0x89,
                0x4C,
                0x87,
                0x3B,
                0xC2,
                0xAA,
                0x56,
                0x67,
                0x88,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisual2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0xB6,
                0x52,
                0x30,
                0xC3,
                0x56,
                0x3E,
                0x4C,
                0x8B,
                0xF3,
                0xF6,
                0xE1,
                0xAD,
                0x47,
                0x3F,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisual3
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0D,
                0x58,
                0xBE,
                0x30,
                0xB6,
                0xF4,
                0xB7,
                0x4A,
                0x80,
                0xDD,
                0x37,
                0x38,
                0xCB,
                0xAC,
                0x9F,
                0x2C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisual4
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0xBF,
                0x76,
                0x94,
                0x4B,
                0xE2,
                0xF9,
                0x5B,
                0x9E,
                0xBE,
                0x62,
                0x74,
                0x10,
                0x9B,
                0x27,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x55,
                0x74,
                0x8B,
                0x3E,
                0xFD,
                0x98,
                0x4A,
                0x84,
                0xA8,
                0xE9,
                0x49,
                0x46,
                0x8C,
                0x6B,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualElement
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x12,
                0x46,
                0xE6,
                0x01,
                0x82,
                0x1D,
                0xF4,
                0x42,
                0x8E,
                0x3F,
                0xA7,
                0x22,
                0xDE,
                0xD3,
                0x3F,
                0xC7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualElement2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0xE8,
                0x3A,
                0x99,
                0x57,
                0x60,
                0x40,
                0x5E,
                0x91,
                0x8C,
                0xE0,
                0x6E,
                0x0B,
                0x7E,
                0x7C,
                0x64,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3E,
                0xF9,
                0x0F,
                0xAD,
                0x02,
                0xB5,
                0xB5,
                0x4E,
                0x87,
                0xB4,
                0x9A,
                0x38,
                0xA7,
                0x1D,
                0x01,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVisualUnorderedCollection
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x70,
                0xAA,
                0x8F,
                0x33,
                0xC8,
                0x54,
                0xA7,
                0x40,
                0x80,
                0x29,
                0xC9,
                0xCE,
                0xEB,
                0x0A,
                0xA2,
                0x50,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
