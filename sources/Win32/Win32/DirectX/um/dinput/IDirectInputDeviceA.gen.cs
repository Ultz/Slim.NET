// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("5944E680-C92E-11CF-BFC7-444553540000")]
[NativeTypeName("struct IDirectInputDeviceA : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectInputDeviceA : IDirectInputDeviceA.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectInputDeviceA));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirectInputDeviceA, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCapabilities([NativeTypeName("LPDIDEVCAPS")] DIDEVCAPS* param0)
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, DIDEVCAPS*, int>)((*lpVtbl)[3]))(
            this,
            param0
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumObjects(
        [NativeTypeName("LPDIENUMDEVICEOBJECTSCALLBACKA")]
            delegate* unmanaged<DIDEVICEOBJECTINSTANCEA*, void*, BOOL> param0,
        [NativeTypeName("LPVOID")] void* param1,
        [NativeTypeName("DWORD")] uint param2
    )
    {
        return (
            (delegate* unmanaged<
                IDirectInputDeviceA,
                delegate* unmanaged<DIDEVICEOBJECTINSTANCEA*, void*, BOOL>,
                void*,
                uint,
                int>)((*lpVtbl)[4])
        )(this, param0, param1, param2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetProperty(
        [NativeTypeName("const GUID &")] Guid* param0,
        [NativeTypeName("LPDIPROPHEADER")] DIPROPHEADER* param1
    )
    {
        return (
            (delegate* unmanaged<IDirectInputDeviceA, Guid*, DIPROPHEADER*, int>)((*lpVtbl)[5])
        )(this, param0, param1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetProperty(
        [NativeTypeName("const GUID &")] Guid* param0,
        [NativeTypeName("LPCDIPROPHEADER")] DIPROPHEADER* param1
    )
    {
        return (
            (delegate* unmanaged<IDirectInputDeviceA, Guid*, DIPROPHEADER*, int>)((*lpVtbl)[6])
        )(this, param0, param1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Acquire()
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Unacquire()
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceState(
        [NativeTypeName("DWORD")] uint param0,
        [NativeTypeName("LPVOID")] void* param1
    )
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, uint, void*, int>)((*lpVtbl)[9]))(
            this,
            param0,
            param1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeviceData(
        [NativeTypeName("DWORD")] uint param0,
        [NativeTypeName("LPDIDEVICEOBJECTDATA")] DIDEVICEOBJECTDATA* param1,
        [NativeTypeName("LPDWORD")] uint* param2,
        [NativeTypeName("DWORD")] uint param3
    )
    {
        return (
            (delegate* unmanaged<IDirectInputDeviceA, uint, DIDEVICEOBJECTDATA*, uint*, uint, int>)(
                (*lpVtbl)[10]
            )
        )(this, param0, param1, param2, param3);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDataFormat([NativeTypeName("LPCDIDATAFORMAT")] DIDATAFORMAT* param0)
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, DIDATAFORMAT*, int>)((*lpVtbl)[11]))(
            this,
            param0
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetEventNotification(HANDLE param0)
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, HANDLE, int>)((*lpVtbl)[12]))(
            this,
            param0
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, HWND, uint, int>)((*lpVtbl)[13]))(
            this,
            param0,
            param1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetObjectInfo(
        [NativeTypeName("LPDIDEVICEOBJECTINSTANCEA")] DIDEVICEOBJECTINSTANCEA* param0,
        [NativeTypeName("DWORD")] uint param1,
        [NativeTypeName("DWORD")] uint param2
    )
    {
        return (
            (delegate* unmanaged<IDirectInputDeviceA, DIDEVICEOBJECTINSTANCEA*, uint, uint, int>)(
                (*lpVtbl)[14]
            )
        )(this, param0, param1, param2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeviceInfo([NativeTypeName("LPDIDEVICEINSTANCEA")] DIDEVICEINSTANCEA* param0)
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, DIDEVICEINSTANCEA*, int>)((*lpVtbl)[15]))(
            this,
            param0
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInputDeviceA, HWND, uint, int>)((*lpVtbl)[16]))(
            this,
            param0,
            param1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Initialize(
        HINSTANCE param0,
        [NativeTypeName("DWORD")] uint param1,
        [NativeTypeName("const GUID &")] Guid* param2
    )
    {
        return (
            (delegate* unmanaged<IDirectInputDeviceA, HINSTANCE, uint, Guid*, int>)((*lpVtbl)[17])
        )(this, param0, param1, param2);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCapabilities([NativeTypeName("LPDIDEVCAPS")] DIDEVCAPS* param0);

        [VtblIndex(5)]
        HRESULT GetProperty(
            [NativeTypeName("const GUID &")] Guid* param0,
            [NativeTypeName("LPDIPROPHEADER")] DIPROPHEADER* param1
        );

        [VtblIndex(6)]
        HRESULT SetProperty(
            [NativeTypeName("const GUID &")] Guid* param0,
            [NativeTypeName("LPCDIPROPHEADER")] DIPROPHEADER* param1
        );

        [VtblIndex(7)]
        HRESULT Acquire();

        [VtblIndex(8)]
        HRESULT Unacquire();

        [VtblIndex(9)]
        HRESULT GetDeviceState(
            [NativeTypeName("DWORD")] uint param0,
            [NativeTypeName("LPVOID")] void* param1
        );

        [VtblIndex(10)]
        HRESULT GetDeviceData(
            [NativeTypeName("DWORD")] uint param0,
            [NativeTypeName("LPDIDEVICEOBJECTDATA")] DIDEVICEOBJECTDATA* param1,
            [NativeTypeName("LPDWORD")] uint* param2,
            [NativeTypeName("DWORD")] uint param3
        );

        [VtblIndex(11)]
        HRESULT SetDataFormat([NativeTypeName("LPCDIDATAFORMAT")] DIDATAFORMAT* param0);

        [VtblIndex(12)]
        HRESULT SetEventNotification(HANDLE param0);

        [VtblIndex(13)]
        HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(14)]
        HRESULT GetObjectInfo(
            [NativeTypeName("LPDIDEVICEOBJECTINSTANCEA")] DIDEVICEOBJECTINSTANCEA* param0,
            [NativeTypeName("DWORD")] uint param1,
            [NativeTypeName("DWORD")] uint param2
        );

        [VtblIndex(15)]
        HRESULT GetDeviceInfo([NativeTypeName("LPDIDEVICEINSTANCEA")] DIDEVICEINSTANCEA* param0);

        [VtblIndex(16)]
        HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(17)]
        HRESULT Initialize(
            HINSTANCE param0,
            [NativeTypeName("DWORD")] uint param1,
            [NativeTypeName("const GUID &")] Guid* param2
        );
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

        [NativeTypeName("HRESULT (LPDIDEVCAPS) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIDEVCAPS*, int> GetCapabilities;

        [NativeTypeName(
            "HRESULT (LPDIENUMDEVICEOBJECTSCALLBACKA, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            delegate* unmanaged<DIDEVICEOBJECTINSTANCEA*, void*, BOOL>,
            void*,
            uint,
            int> EnumObjects;

        [NativeTypeName(
            "HRESULT (const GUID &, LPDIPROPHEADER) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, DIPROPHEADER*, int> GetProperty;

        [NativeTypeName(
            "HRESULT (const GUID &, LPCDIPROPHEADER) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, DIPROPHEADER*, int> SetProperty;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Acquire;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unacquire;

        [NativeTypeName(
            "HRESULT (DWORD, LPVOID) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, void*, int> GetDeviceState;

        [NativeTypeName(
            "HRESULT (DWORD, LPDIDEVICEOBJECTDATA, LPDWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DIDEVICEOBJECTDATA*,
            uint*,
            uint,
            int> GetDeviceData;

        [NativeTypeName(
            "HRESULT (LPCDIDATAFORMAT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DIDATAFORMAT*, int> SetDataFormat;

        [NativeTypeName("HRESULT (HANDLE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> SetEventNotification;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> SetCooperativeLevel;

        [NativeTypeName(
            "HRESULT (LPDIDEVICEOBJECTINSTANCEA, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DIDEVICEOBJECTINSTANCEA*, uint, uint, int> GetObjectInfo;

        [NativeTypeName(
            "HRESULT (LPDIDEVICEINSTANCEA) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DIDEVICEINSTANCEA*, int> GetDeviceInfo;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> RunControlPanel;

        [NativeTypeName(
            "HRESULT (HINSTANCE, DWORD, const GUID &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HINSTANCE, uint, Guid*, int> Initialize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectInputDeviceA"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectInputDeviceA(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectInputDeviceA"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectInputDeviceA(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectInputDeviceA(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectInputDeviceA"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectInputDeviceA"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectInputDeviceA value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
