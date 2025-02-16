// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static void ReverbConvertI3DL2ToNative(
        [NativeTypeName("const XAUDIO2FX_REVERB_I3DL2_PARAMETERS *")]
            XAUDIO2FX_REVERB_I3DL2_PARAMETERS* pI3DL2,
        [NativeTypeName("XAUDIO2FX_REVERB_PARAMETERS *")] XAUDIO2FX_REVERB_PARAMETERS* pNative,
        [Optional, DefaultParameterValue(1)] BOOL sevenDotOneReverb
    )
    {
        float reflectionsDelay;
        float reverbDelay;
        if (sevenDotOneReverb != 0)
        {
            pNative->RearDelay = 20;
        }
        else
        {
            pNative->RearDelay = 5;
        }
        pNative->SideDelay = 5;
        pNative->PositionLeft = 6;
        pNative->PositionRight = 6;
        pNative->PositionMatrixLeft = 27;
        pNative->PositionMatrixRight = 27;
        pNative->RoomSize = 100.0f;
        pNative->LowEQCutoff = 4;
        pNative->HighEQCutoff = 6;
        pNative->RoomFilterMain = (float)pI3DL2->Room / 100.0f;
        pNative->RoomFilterHF = (float)pI3DL2->RoomHF / 100.0f;
        if (pI3DL2->DecayHFRatio >= 1.0f)
        {
            int index = (int)(-4.0 * Math.Log10(pI3DL2->DecayHFRatio));
            if (index < -8)
            {
                index = -8;
            }
            pNative->LowEQGain = (byte)((index < 0) ? index + 8 : 8);
            pNative->HighEQGain = 8;
            pNative->DecayTime = pI3DL2->DecayTime * pI3DL2->DecayHFRatio;
        }
        else
        {
            int index = (int)(4.0 * Math.Log10(pI3DL2->DecayHFRatio));
            if (index < -8)
            {
                index = -8;
            }
            pNative->LowEQGain = 8;
            pNative->HighEQGain = (byte)((index < 0) ? index + 8 : 8);
            pNative->DecayTime = pI3DL2->DecayTime;
        }
        reflectionsDelay = pI3DL2->ReflectionsDelay * 1000.0f;
        if (reflectionsDelay >= 300)
        {
            reflectionsDelay = (float)(300 - 1);
        }
        else if (reflectionsDelay <= 1)
        {
            reflectionsDelay = 1;
        }
        pNative->ReflectionsDelay = (uint)reflectionsDelay;
        reverbDelay = pI3DL2->ReverbDelay * 1000.0f;
        if (reverbDelay >= 85)
        {
            reverbDelay = (float)(85 - 1);
        }
        pNative->ReverbDelay = (byte)reverbDelay;
        pNative->ReflectionsGain = pI3DL2->Reflections / 100.0f;
        pNative->ReverbGain = pI3DL2->Reverb / 100.0f;
        pNative->EarlyDiffusion = (byte)(15.0f * pI3DL2->Diffusion / 100.0f);
        pNative->LateDiffusion = pNative->EarlyDiffusion;
        pNative->Density = pI3DL2->Density;
        pNative->RoomFilterFreq = pI3DL2->HFReference;
        pNative->WetDryMix = pI3DL2->WetDryMix;
        pNative->DisableLateField = 0;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ReverbConvertI3DL2ToNative(
        [NativeTypeName("const XAUDIO2FX_REVERB_I3DL2_PARAMETERS *")]
            Ref<XAUDIO2FX_REVERB_I3DL2_PARAMETERS> pI3DL2,
        [NativeTypeName("XAUDIO2FX_REVERB_PARAMETERS *")] Ref<XAUDIO2FX_REVERB_PARAMETERS> pNative,
        [Optional, DefaultParameterValue(true)] MaybeBool<BOOL> sevenDotOneReverb
    )
    {
        fixed (XAUDIO2FX_REVERB_PARAMETERS* __dsl_pNative = pNative)
        fixed (XAUDIO2FX_REVERB_I3DL2_PARAMETERS* __dsl_pI3DL2 = pI3DL2)
        {
            ReverbConvertI3DL2ToNative(__dsl_pI3DL2, __dsl_pNative, (BOOL)sevenDotOneReverb);
        }
    }

    public static HRESULT XAudio2CreateReverb(
        [NativeTypeName("IUnknown **")] IUnknown* ppApo,
        [NativeTypeName("UINT32")] uint Flags = 0
    )
    {
        return CreateAudioReverb(ppApo);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT XAudio2CreateReverb(
        [NativeTypeName("IUnknown **")] Ref<IUnknown> ppApo,
        [NativeTypeName("UINT32")] uint Flags = 0
    )
    {
        fixed (IUnknown* __dsl_ppApo = ppApo)
        {
            return (HRESULT)XAudio2CreateReverb(__dsl_ppApo, Flags);
        }
    }

    public static HRESULT XAudio2CreateVolumeMeter(
        [NativeTypeName("IUnknown **")] IUnknown* ppApo,
        [NativeTypeName("UINT32")] uint Flags = 0
    )
    {
        return CreateAudioVolumeMeter(ppApo);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT XAudio2CreateVolumeMeter(
        [NativeTypeName("IUnknown **")] Ref<IUnknown> ppApo,
        [NativeTypeName("UINT32")] uint Flags = 0
    )
    {
        fixed (IUnknown* __dsl_ppApo = ppApo)
        {
            return (HRESULT)XAudio2CreateVolumeMeter(__dsl_ppApo, Flags);
        }
    }
}
