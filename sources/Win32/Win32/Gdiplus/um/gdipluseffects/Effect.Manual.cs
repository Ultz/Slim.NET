// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct Effect : Effect.Interface
{
    private static readonly void** s_vtbl = InitVtblRaw();

    public Effect()
    {
        lpVtbl = s_vtbl;
        auxDataSize = 0;
        auxData = null;
        nativeEffect = null;
        useAuxData = 0;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static Ptr2D InitVtbl() => (void**)InitVtblRaw();

    private static void** InitVtblRaw()
    {
        var lpVtbl = (void**)
            RuntimeHelpers.AllocateTypeAssociatedMemory(typeof(Effect), sizeof(void*) * 1);
        {
            lpVtbl[0] = (void*)(delegate* unmanaged<Effect*, void>)&Dispose;
        }
        return lpVtbl;
        [UnmanagedCallersOnly]
        static void Dispose(Effect* pThis)
        {
            pThis->Dispose();
        }
    }
}
