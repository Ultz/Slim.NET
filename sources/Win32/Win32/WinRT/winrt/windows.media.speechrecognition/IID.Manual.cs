// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IID
{
    public static ref readonly Guid IID_ISpeechContinuousRecognitionCompletedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBB,
                0x69,
                0xD0,
                0xE3,
                0x0C,
                0xE3,
                0x18,
                0x5E,
                0x42,
                0x4B,
                0x7F,
                0xBE,
                0x81,
                0xF8,
                0xFB,
                0xD0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechContinuousRecognitionResultGeneratedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1E,
                0x1E,
                0x09,
                0x19,
                0x7E,
                0x6E,
                0x46,
                0x5A,
                0x40,
                0xFB,
                0x76,
                0x59,
                0x4F,
                0x78,
                0x65,
                0x04,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechContinuousRecognitionSession
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x04,
                0x3C,
                0x21,
                0x6A,
                0x14,
                0x66,
                0xF8,
                0x49,
                0x99,
                0xA2,
                0xB5,
                0xE9,
                0xB3,
                0xA0,
                0x85,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionCompilationResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5D,
                0x6C,
                0x7E,
                0x40,
                0xC7,
                0x6A,
                0xA4,
                0x4D,
                0x9C,
                0xC1,
                0x2F,
                0xCE,
                0x32,
                0xCF,
                0x74,
                0x89,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionConstraint
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x28,
                0x16,
                0xAC,
                0x79,
                0x68,
                0x4D,
                0xC4,
                0x43,
                0x89,
                0x11,
                0x40,
                0xDC,
                0x41,
                0x01,
                0xB5,
                0x5B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionGrammarFileConstraint
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x1A,
                0x03,
                0xB5,
                0xCA,
                0x85,
                0xA4,
                0x4F,
                0xB1,
                0x1A,
                0x47,
                0x4F,
                0xC4,
                0x1B,
                0x38,
                0x35,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionGrammarFileConstraintFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0x70,
                0xA7,
                0x3D,
                0x79,
                0xC4,
                0x27,
                0x4C,
                0x9F,
                0x19,
                0x89,
                0x97,
                0x4E,
                0xF3,
                0x92,
                0xD1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionHypothesis
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x25,
                0x7B,
                0x7A,
                0xC5,
                0x99,
                0x7D,
                0x4F,
                0xBF,
                0x84,
                0x10,
                0xAA,
                0x13,
                0x02,
                0xB6,
                0x34,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionHypothesisGeneratedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0x1A,
                0x16,
                0x55,
                0x23,
                0x80,
                0x66,
                0x58,
                0x41,
                0x1D,
                0x12,
                0x13,
                0xBB,
                0x27,
                0x14,
                0x76,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionListConstraint
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE9,
                0x87,
                0xC4,
                0x09,
                0xAD,
                0xE4,
                0x26,
                0x45,
                0x81,
                0xF2,
                0x49,
                0x46,
                0xFB,
                0x48,
                0x1D,
                0x98,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionListConstraintFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0xCD,
                0xF3,
                0x40,
                0x2A,
                0x56,
                0x6A,
                0x42,
                0x9F,
                0x3B,
                0x3B,
                0x4E,
                0x28,
                0x2B,
                0xE1,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionQualityDegradingEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x05,
                0x41,
                0xE2,
                0x4F,
                0x3A,
                0x8C,
                0x7E,
                0x4C,
                0x8D,
                0x0A,
                0x5B,
                0xD4,
                0xF5,
                0xB1,
                0x4A,
                0xD8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionResult
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x31,
                0x30,
                0x4E,
                0x4E,
                0x03,
                0x52,
                0x46,
                0x85,
                0x7E,
                0xD0,
                0x45,
                0x4C,
                0xC4,
                0xBE,
                0xEC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionResult2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xBA,
                0xD1,
                0x7E,
                0xAF,
                0x1B,
                0x45,
                0x66,
                0x41,
                0xA0,
                0xC1,
                0x1F,
                0xFE,
                0x84,
                0x03,
                0x2D,
                0x03,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionSemanticInterpretation
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0xDA,
                0xE1,
                0xAA,
                0x32,
                0x7E,
                0x1F,
                0x4C,
                0x89,
                0xFE,
                0x0C,
                0x65,
                0xF4,
                0x86,
                0xF5,
                0x2E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionTopicConstraint
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x19,
                0xDF,
                0x6F,
                0xBF,
                0x5D,
                0x82,
                0x69,
                0x4E,
                0xA6,
                0x81,
                0x36,
                0xE4,
                0x8C,
                0xF1,
                0xC9,
                0x3E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionTopicConstraintFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x63,
                0x68,
                0x6E,
                0x05,
                0xEC,
                0xD7,
                0x47,
                0xA5,
                0xDF,
                0x56,
                0xA3,
                0x43,
                0x1E,
                0x58,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognitionVoiceCommandDefinitionConstraint
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x1C,
                0x79,
                0xF2,
                0xF4,
                0x1E,
                0xE7,
                0x4A,
                0x9D,
                0x77,
                0xB6,
                0xFF,
                0x10,
                0xB8,
                0xA3,
                0xC2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_WinRT_ISpeechRecognizer
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0xC9,
                0xC3,
                0x0B,
                0x6A,
                0xC2,
                0xF2,
                0x40,
                0xAE,
                0xB5,
                0x80,
                0x96,
                0xB2,
                0xE4,
                0x80,
                0x73,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognizer2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF1,
                0xBA,
                0xC9,
                0x63,
                0xE3,
                0x91,
                0xA4,
                0x4E,
                0x86,
                0xA1,
                0x7C,
                0x38,
                0x67,
                0xD0,
                0x84,
                0xA6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognizerFactory
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDD,
                0x88,
                0xC4,
                0x60,
                0xB8,
                0x7F,
                0x33,
                0x40,
                0xAC,
                0x70,
                0xD0,
                0x46,
                0xF6,
                0x48,
                0x18,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognizerStateChangedEventArgs
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x09,
                0x4F,
                0x3D,
                0x56,
                0x03,
                0xBA,
                0xAD,
                0x4B,
                0xAD,
                0x81,
                0xDD,
                0xC6,
                0xC4,
                0xDA,
                0xB0,
                0xC3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognizerStatics
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAC,
                0x5E,
                0xA3,
                0x87,
                0xDC,
                0xA7,
                0x0B,
                0x4B,
                0xBC,
                0xC9,
                0x24,
                0xF4,
                0x7C,
                0x0B,
                0x7E,
                0xBF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognizerStatics2
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x95,
                0x0D,
                0x1B,
                0x1D,
                0x65,
                0x75,
                0xF9,
                0x4E,
                0xA2,
                0xF3,
                0xBA,
                0x15,
                0x16,
                0x2A,
                0x96,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognizerTimeouts
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCA,
                0x6F,
                0xF7,
                0x2E,
                0x3C,
                0x6A,
                0xCA,
                0x4D,
                0xA1,
                0x53,
                0xDF,
                0x1B,
                0xC8,
                0x8A,
                0x79,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_ISpeechRecognizerUIOptions
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x41,
                0xD6,
                0x88,
                0x78,
                0x2B,
                0xB9,
                0xBA,
                0x44,
                0xA2,
                0x5F,
                0xD1,
                0x86,
                0x46,
                0x30,
                0x64,
                0x1F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoiceCommandManager
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD5,
                0x8D,
                0x3A,
                0xAA,
                0xE7,
                0xB6,
                0xE2,
                0x4E,
                0xBA,
                0xA9,
                0xDD,
                0x6B,
                0xAC,
                0xED,
                0x0A,
                0x2B,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
    public static ref readonly Guid IID_IVoiceCommandSet
    {
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x75,
                0xDA,
                0xED,
                0x0B,
                0xE6,
                0x46,
                0x11,
                0x4B,
                0xA0,
                0x88,
                0x5C,
                0x68,
                0x63,
                0x28,
                0x99,
                0xB5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
