// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SpatialAudioHrtfActivationParams
{
    [NativeTypeName("const WAVEFORMATEX *")]
    public WAVEFORMATEX* ObjectFormat;
    public AudioObjectType StaticObjectTypeMask;

    [NativeTypeName("UINT32")]
    public uint MinDynamicObjectCount;

    [NativeTypeName("UINT32")]
    public uint MaxDynamicObjectCount;
    public AUDIO_STREAM_CATEGORY Category;
    public HANDLE EventHandle;
    public ISpatialAudioObjectRenderStreamNotify NotifyObject;
    public SpatialAudioHrtfDistanceDecay* DistanceDecay;
    public SpatialAudioHrtfDirectivityUnion* Directivity;
    public SpatialAudioHrtfEnvironmentType* Environment;

    [NativeTypeName("SpatialAudioHrtfOrientation *")]
    public float** Orientation;
}
