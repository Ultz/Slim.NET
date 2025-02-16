// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
using static Silk.NET.DirectX.XAUDIO2;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("XAudio2_9", ExactSpelling = true)]
    private static extern HRESULT _XAudio2Create(
        [NativeTypeName("IXAudio2 **")] IXAudio2.Native** ppXAudio2,
        [NativeTypeName("UINT32")] uint Flags = 0,
        [NativeTypeName("XAUDIO2_PROCESSOR")] uint XAudio2Processor = XAUDIO2_DEFAULT_PROCESSOR
    );

    [Transformed]
    [NativeFunction("XAudio2_9", EntryPoint = "_XAudio2Create")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static HRESULT _XAudio2Create(
        [NativeTypeName("IXAudio2 **")] Ref2D<IXAudio2.Native> ppXAudio2,
        [NativeTypeName("UINT32")] uint Flags = 0,
        [NativeTypeName("XAUDIO2_PROCESSOR")] uint XAudio2Processor = XAUDIO2_DEFAULT_PROCESSOR
    )
    {
        fixed (IXAudio2.Native** __dsl_ppXAudio2 = ppXAudio2)
        {
            return (HRESULT)_XAudio2Create(__dsl_ppXAudio2, Flags, XAudio2Processor);
        }
    }

    public static float XAudio2AmplitudeRatioToDecibels(float Volume)
    {
        if (Volume == 0)
        {
            return -3.402823466e+38f;
        }
        return 20.0f * MathF.Log10(Volume);
    }

    public static HRESULT XAudio2Create(
        [NativeTypeName("IXAudio2 **")] IXAudio2* ppXAudio2,
        [NativeTypeName("UINT32")] uint Flags = 0,
        [NativeTypeName("XAUDIO2_PROCESSOR")] uint XAudio2Processor = XAUDIO2_DEFAULT_PROCESSOR
    ) => _XAudio2Create(&ppXAudio2->lpVtbl, Flags, XAudio2Processor);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT XAudio2Create(
        [NativeTypeName("IXAudio2 **")] Ref<IXAudio2> ppXAudio2,
        [NativeTypeName("UINT32")] uint Flags = 0,
        [NativeTypeName("XAUDIO2_PROCESSOR")] uint XAudio2Processor = XAUDIO2_DEFAULT_PROCESSOR
    )
    {
        fixed (IXAudio2* __dsl_ppXAudio2 = ppXAudio2)
        {
            return (HRESULT)XAudio2Create(__dsl_ppXAudio2, Flags, XAudio2Processor);
        }
    }

    public static float XAudio2CutoffFrequencyToOnePoleCoefficient(
        float CutoffFrequency,
        [NativeTypeName("UINT32")] uint SampleRate
    )
    {
        if ((uint)CutoffFrequency >= SampleRate)
        {
            return 1.0f;
        }
        return (1.0f - MathF.Pow(1.0f - 2.0f * CutoffFrequency / SampleRate, 2.0f));
    }

    public static float XAudio2CutoffFrequencyToRadians(
        float CutoffFrequency,
        [NativeTypeName("UINT32")] uint SampleRate
    )
    {
        if ((uint)(CutoffFrequency * 6.0f) >= SampleRate)
        {
            return 1.0f;
        }
        return 2.0f * MathF.Sin((float)3.14159265358979323846 * CutoffFrequency / SampleRate);
    }

    public static float XAudio2DecibelsToAmplitudeRatio(float Decibels)
    {
        return MathF.Pow(10.0f, Decibels / 20.0f);
    }

    public static float XAudio2FrequencyRatioToSemitones(float FrequencyRatio)
    {
        return 39.86313713864835f * MathF.Log10(FrequencyRatio);
    }

    public static float XAudio2RadiansToCutoffFrequency(float Radians, float SampleRate)
    {
        return SampleRate * MathF.Asin(Radians / 2.0f) / (float)3.14159265358979323846;
    }

    public static float XAudio2SemitonesToFrequencyRatio(float Semitones)
    {
        return MathF.Pow(2.0f, Semitones / 12.0f);
    }
}
