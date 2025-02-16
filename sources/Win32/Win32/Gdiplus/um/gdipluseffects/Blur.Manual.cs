// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using static Silk.NET.Gdiplus.Gdiplus;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct Blur : Blur.Interface
{
    public Blur()
    {
        Base = new Effect();
        CGpEffect* nativeEffect;
        _ = GdipCreateEffect(BlurEffectGuid, &nativeEffect);
        Base.nativeEffect = nativeEffect;
    }

    public interface Interface : Effect.Interface { }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void Dispose()
    {
        ((delegate* unmanaged<Blur*, void>)(Base.lpVtbl[0]))((Blur*)Unsafe.AsPointer(ref this));
    }
}
