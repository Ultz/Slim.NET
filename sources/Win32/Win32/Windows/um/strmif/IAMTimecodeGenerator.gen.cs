// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9B496CE0-811B-11CF-8C77-00AA006B6814")]
[NativeTypeName("struct IAMTimecodeGenerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMTimecodeGenerator : IAMTimecodeGenerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMTimecodeGenerator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMTimecodeGenerator, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMTimecodeGenerator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMTimecodeGenerator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTCGMode(
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long *")] int* pValue
    )
    {
        return ((delegate* unmanaged<IAMTimecodeGenerator, int, int*, int>)((*lpVtbl)[3]))(
            this,
            Param,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTCGMode(
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long")] int Value
    )
    {
        return ((delegate* unmanaged<IAMTimecodeGenerator, int, int, int>)((*lpVtbl)[4]))(
            this,
            Param,
            Value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT put_VITCLine([NativeTypeName("long")] int Line)
    {
        return ((delegate* unmanaged<IAMTimecodeGenerator, int, int>)((*lpVtbl)[5]))(this, Line);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VITCLine([NativeTypeName("long *")] int* pLine)
    {
        return ((delegate* unmanaged<IAMTimecodeGenerator, int*, int>)((*lpVtbl)[6]))(this, pLine);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetTimecode(
        [NativeTypeName("PTIMECODE_SAMPLE")] TIMECODE_SAMPLE* pTimecodeSample
    )
    {
        return ((delegate* unmanaged<IAMTimecodeGenerator, TIMECODE_SAMPLE*, int>)((*lpVtbl)[7]))(
            this,
            pTimecodeSample
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTimecode(
        [NativeTypeName("PTIMECODE_SAMPLE")] TIMECODE_SAMPLE* pTimecodeSample
    )
    {
        return ((delegate* unmanaged<IAMTimecodeGenerator, TIMECODE_SAMPLE*, int>)((*lpVtbl)[8]))(
            this,
            pTimecodeSample
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTCGMode(
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long *")] int* pValue
        );

        [VtblIndex(4)]
        HRESULT SetTCGMode([NativeTypeName("long")] int Param, [NativeTypeName("long")] int Value);

        [VtblIndex(5)]
        HRESULT put_VITCLine([NativeTypeName("long")] int Line);

        [VtblIndex(6)]
        HRESULT get_VITCLine([NativeTypeName("long *")] int* pLine);

        [VtblIndex(7)]
        HRESULT SetTimecode([NativeTypeName("PTIMECODE_SAMPLE")] TIMECODE_SAMPLE* pTimecodeSample);

        [VtblIndex(8)]
        HRESULT GetTimecode([NativeTypeName("PTIMECODE_SAMPLE")] TIMECODE_SAMPLE* pTimecodeSample);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetTCGMode;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetTCGMode;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_VITCLine;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_VITCLine;

        [NativeTypeName("HRESULT (PTIMECODE_SAMPLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TIMECODE_SAMPLE*, int> SetTimecode;

        [NativeTypeName("HRESULT (PTIMECODE_SAMPLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TIMECODE_SAMPLE*, int> GetTimecode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMTimecodeGenerator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMTimecodeGenerator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMTimecodeGenerator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMTimecodeGenerator(Silk.NET.Windows.IUnknown value)
    {
        return new IAMTimecodeGenerator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMTimecodeGenerator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMTimecodeGenerator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMTimecodeGenerator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
