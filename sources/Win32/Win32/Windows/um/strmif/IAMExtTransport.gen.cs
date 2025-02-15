// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A03CD5F0-3045-11CF-8C44-00AA006B6814")]
[NativeTypeName("struct IAMExtTransport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMExtTransport : IAMExtTransport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMExtTransport));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMExtTransport, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMExtTransport, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMExtTransport, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCapability(
        [NativeTypeName("long")] int Capability,
        [NativeTypeName("long *")] int* pValue,
        double* pdblValue
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int*, double*, int>)((*lpVtbl)[3]))(
            this,
            Capability,
            pValue,
            pdblValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_MediaState([NativeTypeName("long")] int State)
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int>)((*lpVtbl)[4]))(this, State);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_MediaState([NativeTypeName("long *")] int* pState)
    {
        return ((delegate* unmanaged<IAMExtTransport, int*, int>)((*lpVtbl)[5]))(this, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_LocalControl([NativeTypeName("long")] int State)
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int>)((*lpVtbl)[6]))(this, State);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LocalControl([NativeTypeName("long *")] int* pState)
    {
        return ((delegate* unmanaged<IAMExtTransport, int*, int>)((*lpVtbl)[7]))(this, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStatus(
        [NativeTypeName("long")] int StatusItem,
        [NativeTypeName("long *")] int* pValue
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int*, int>)((*lpVtbl)[8]))(
            this,
            StatusItem,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTransportBasicParameters(
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long *")] int* pValue,
        [NativeTypeName("LPOLESTR *")] ushort** ppszData
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int*, ushort**, int>)((*lpVtbl)[9]))(
            this,
            Param,
            pValue,
            ppszData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetTransportBasicParameters(
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long")] int Value,
        [NativeTypeName("LPCOLESTR")] ushort* pszData
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int, ushort*, int>)((*lpVtbl)[10]))(
            this,
            Param,
            Value,
            pszData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetTransportVideoParameters(
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long *")] int* pValue
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int*, int>)((*lpVtbl)[11]))(
            this,
            Param,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetTransportVideoParameters(
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long")] int Value
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int, int>)((*lpVtbl)[12]))(
            this,
            Param,
            Value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetTransportAudioParameters(
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long *")] int* pValue
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int*, int>)((*lpVtbl)[13]))(
            this,
            Param,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetTransportAudioParameters(
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long")] int Value
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int, int>)((*lpVtbl)[14]))(
            this,
            Param,
            Value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Mode([NativeTypeName("long")] int Mode)
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int>)((*lpVtbl)[15]))(this, Mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Mode([NativeTypeName("long *")] int* pMode)
    {
        return ((delegate* unmanaged<IAMExtTransport, int*, int>)((*lpVtbl)[16]))(this, pMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Rate(double dblRate)
    {
        return ((delegate* unmanaged<IAMExtTransport, double, int>)((*lpVtbl)[17]))(this, dblRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Rate(double* pdblRate)
    {
        return ((delegate* unmanaged<IAMExtTransport, double*, int>)((*lpVtbl)[18]))(
            this,
            pdblRate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetChase(
        [NativeTypeName("long *")] int* pEnabled,
        [NativeTypeName("long *")] int* pOffset,
        HEVENT* phEvent
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int*, int*, HEVENT*, int>)((*lpVtbl)[19]))(
            this,
            pEnabled,
            pOffset,
            phEvent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetChase(
        [NativeTypeName("long")] int Enable,
        [NativeTypeName("long")] int Offset,
        HEVENT hEvent
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int, HEVENT, int>)((*lpVtbl)[20]))(
            this,
            Enable,
            Offset,
            hEvent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetBump(
        [NativeTypeName("long *")] int* pSpeed,
        [NativeTypeName("long *")] int* pDuration
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int*, int*, int>)((*lpVtbl)[21]))(
            this,
            pSpeed,
            pDuration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetBump(
        [NativeTypeName("long")] int Speed,
        [NativeTypeName("long")] int Duration
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int, int>)((*lpVtbl)[22]))(
            this,
            Speed,
            Duration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_AntiClogControl([NativeTypeName("long *")] int* pEnabled)
    {
        return ((delegate* unmanaged<IAMExtTransport, int*, int>)((*lpVtbl)[23]))(this, pEnabled);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_AntiClogControl([NativeTypeName("long")] int Enable)
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int>)((*lpVtbl)[24]))(this, Enable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetEditPropertySet(
        [NativeTypeName("long")] int EditID,
        [NativeTypeName("long *")] int* pState
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int*, int>)((*lpVtbl)[25]))(
            this,
            EditID,
            pState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetEditPropertySet(
        [NativeTypeName("long *")] int* pEditID,
        [NativeTypeName("long")] int State
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int*, int, int>)((*lpVtbl)[26]))(
            this,
            pEditID,
            State
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetEditProperty(
        [NativeTypeName("long")] int EditID,
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long *")] int* pValue
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int, int*, int>)((*lpVtbl)[27]))(
            this,
            EditID,
            Param,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetEditProperty(
        [NativeTypeName("long")] int EditID,
        [NativeTypeName("long")] int Param,
        [NativeTypeName("long")] int Value
    )
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int, int, int>)((*lpVtbl)[28]))(
            this,
            EditID,
            Param,
            Value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_EditStart([NativeTypeName("long *")] int* pValue)
    {
        return ((delegate* unmanaged<IAMExtTransport, int*, int>)((*lpVtbl)[29]))(this, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_EditStart([NativeTypeName("long")] int Value)
    {
        return ((delegate* unmanaged<IAMExtTransport, int, int>)((*lpVtbl)[30]))(this, Value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCapability(
            [NativeTypeName("long")] int Capability,
            [NativeTypeName("long *")] int* pValue,
            double* pdblValue
        );

        [VtblIndex(4)]
        HRESULT put_MediaState([NativeTypeName("long")] int State);

        [VtblIndex(5)]
        HRESULT get_MediaState([NativeTypeName("long *")] int* pState);

        [VtblIndex(6)]
        HRESULT put_LocalControl([NativeTypeName("long")] int State);

        [VtblIndex(7)]
        HRESULT get_LocalControl([NativeTypeName("long *")] int* pState);

        [VtblIndex(8)]
        HRESULT GetStatus(
            [NativeTypeName("long")] int StatusItem,
            [NativeTypeName("long *")] int* pValue
        );

        [VtblIndex(9)]
        HRESULT GetTransportBasicParameters(
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long *")] int* pValue,
            [NativeTypeName("LPOLESTR *")] ushort** ppszData
        );

        [VtblIndex(10)]
        HRESULT SetTransportBasicParameters(
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long")] int Value,
            [NativeTypeName("LPCOLESTR")] ushort* pszData
        );

        [VtblIndex(11)]
        HRESULT GetTransportVideoParameters(
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long *")] int* pValue
        );

        [VtblIndex(12)]
        HRESULT SetTransportVideoParameters(
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long")] int Value
        );

        [VtblIndex(13)]
        HRESULT GetTransportAudioParameters(
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long *")] int* pValue
        );

        [VtblIndex(14)]
        HRESULT SetTransportAudioParameters(
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long")] int Value
        );

        [VtblIndex(15)]
        HRESULT put_Mode([NativeTypeName("long")] int Mode);

        [VtblIndex(16)]
        HRESULT get_Mode([NativeTypeName("long *")] int* pMode);

        [VtblIndex(17)]
        HRESULT put_Rate(double dblRate);

        [VtblIndex(18)]
        HRESULT get_Rate(double* pdblRate);

        [VtblIndex(19)]
        HRESULT GetChase(
            [NativeTypeName("long *")] int* pEnabled,
            [NativeTypeName("long *")] int* pOffset,
            HEVENT* phEvent
        );

        [VtblIndex(20)]
        HRESULT SetChase(
            [NativeTypeName("long")] int Enable,
            [NativeTypeName("long")] int Offset,
            HEVENT hEvent
        );

        [VtblIndex(21)]
        HRESULT GetBump(
            [NativeTypeName("long *")] int* pSpeed,
            [NativeTypeName("long *")] int* pDuration
        );

        [VtblIndex(22)]
        HRESULT SetBump([NativeTypeName("long")] int Speed, [NativeTypeName("long")] int Duration);

        [VtblIndex(23)]
        HRESULT get_AntiClogControl([NativeTypeName("long *")] int* pEnabled);

        [VtblIndex(24)]
        HRESULT put_AntiClogControl([NativeTypeName("long")] int Enable);

        [VtblIndex(25)]
        HRESULT GetEditPropertySet(
            [NativeTypeName("long")] int EditID,
            [NativeTypeName("long *")] int* pState
        );

        [VtblIndex(26)]
        HRESULT SetEditPropertySet(
            [NativeTypeName("long *")] int* pEditID,
            [NativeTypeName("long")] int State
        );

        [VtblIndex(27)]
        HRESULT GetEditProperty(
            [NativeTypeName("long")] int EditID,
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long *")] int* pValue
        );

        [VtblIndex(28)]
        HRESULT SetEditProperty(
            [NativeTypeName("long")] int EditID,
            [NativeTypeName("long")] int Param,
            [NativeTypeName("long")] int Value
        );

        [VtblIndex(29)]
        HRESULT get_EditStart([NativeTypeName("long *")] int* pValue);

        [VtblIndex(30)]
        HRESULT put_EditStart([NativeTypeName("long")] int Value);
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

        [NativeTypeName("HRESULT (long, long *, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, double*, int> GetCapability;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_MediaState;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MediaState;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_LocalControl;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LocalControl;

        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetStatus;

        [NativeTypeName("HRESULT (long, long *, LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, ushort**, int> GetTransportBasicParameters;

        [NativeTypeName("HRESULT (long, long, LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ushort*, int> SetTransportBasicParameters;

        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetTransportVideoParameters;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetTransportVideoParameters;

        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetTransportAudioParameters;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetTransportAudioParameters;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Mode;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Mode;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Rate;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Rate;

        [NativeTypeName("HRESULT (long *, long *, HEVENT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, HEVENT*, int> GetChase;

        [NativeTypeName("HRESULT (long, long, HEVENT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, HEVENT, int> SetChase;

        [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetBump;

        [NativeTypeName("HRESULT (long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int> SetBump;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AntiClogControl;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_AntiClogControl;

        [NativeTypeName("HRESULT (long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetEditPropertySet;

        [NativeTypeName("HRESULT (long *, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int, int> SetEditPropertySet;

        [NativeTypeName("HRESULT (long, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int*, int> GetEditProperty;

        [NativeTypeName("HRESULT (long, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, int> SetEditProperty;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_EditStart;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_EditStart;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMExtTransport"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMExtTransport(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMExtTransport"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMExtTransport(Silk.NET.Windows.IUnknown value)
    {
        return new IAMExtTransport(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMExtTransport"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMExtTransport"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMExtTransport value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
