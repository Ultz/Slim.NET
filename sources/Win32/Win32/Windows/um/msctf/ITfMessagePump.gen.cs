// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8F1B8AD8-0B6B-4874-90C5-BD76011E8F7C")]
[NativeTypeName("struct ITfMessagePump : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfMessagePump : ITfMessagePump.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfMessagePump));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfMessagePump, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfMessagePump, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfMessagePump, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PeekMessageA(
        [NativeTypeName("LPMSG")] MSG* pMsg,
        HWND hwnd,
        uint wMsgFilterMin,
        uint wMsgFilterMax,
        uint wRemoveMsg,
        BOOL* pfResult
    )
    {
        return (
            (delegate* unmanaged<ITfMessagePump, MSG*, HWND, uint, uint, uint, BOOL*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg, pfResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMessageA(
        [NativeTypeName("LPMSG")] MSG* pMsg,
        HWND hwnd,
        uint wMsgFilterMin,
        uint wMsgFilterMax,
        BOOL* pfResult
    )
    {
        return (
            (delegate* unmanaged<ITfMessagePump, MSG*, HWND, uint, uint, BOOL*, int>)((*lpVtbl)[4])
        )(this, pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, pfResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT PeekMessageW(
        [NativeTypeName("LPMSG")] MSG* pMsg,
        HWND hwnd,
        uint wMsgFilterMin,
        uint wMsgFilterMax,
        uint wRemoveMsg,
        BOOL* pfResult
    )
    {
        return (
            (delegate* unmanaged<ITfMessagePump, MSG*, HWND, uint, uint, uint, BOOL*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg, pfResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMessageW(
        [NativeTypeName("LPMSG")] MSG* pMsg,
        HWND hwnd,
        uint wMsgFilterMin,
        uint wMsgFilterMax,
        BOOL* pfResult
    )
    {
        return (
            (delegate* unmanaged<ITfMessagePump, MSG*, HWND, uint, uint, BOOL*, int>)((*lpVtbl)[6])
        )(this, pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, pfResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PeekMessageA(
            [NativeTypeName("LPMSG")] MSG* pMsg,
            HWND hwnd,
            uint wMsgFilterMin,
            uint wMsgFilterMax,
            uint wRemoveMsg,
            BOOL* pfResult
        );

        [VtblIndex(4)]
        HRESULT GetMessageA(
            [NativeTypeName("LPMSG")] MSG* pMsg,
            HWND hwnd,
            uint wMsgFilterMin,
            uint wMsgFilterMax,
            BOOL* pfResult
        );

        [VtblIndex(5)]
        HRESULT PeekMessageW(
            [NativeTypeName("LPMSG")] MSG* pMsg,
            HWND hwnd,
            uint wMsgFilterMin,
            uint wMsgFilterMax,
            uint wRemoveMsg,
            BOOL* pfResult
        );

        [VtblIndex(6)]
        HRESULT GetMessageW(
            [NativeTypeName("LPMSG")] MSG* pMsg,
            HWND hwnd,
            uint wMsgFilterMin,
            uint wMsgFilterMax,
            BOOL* pfResult
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

        [NativeTypeName("HRESULT (LPMSG, HWND, UINT, UINT, UINT, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, HWND, uint, uint, uint, BOOL*, int> PeekMessageA;

        [NativeTypeName("HRESULT (LPMSG, HWND, UINT, UINT, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, HWND, uint, uint, BOOL*, int> GetMessageA;

        [NativeTypeName("HRESULT (LPMSG, HWND, UINT, UINT, UINT, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, HWND, uint, uint, uint, BOOL*, int> PeekMessageW;

        [NativeTypeName("HRESULT (LPMSG, HWND, UINT, UINT, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, HWND, uint, uint, BOOL*, int> GetMessageW;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfMessagePump"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfMessagePump(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfMessagePump"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfMessagePump(Silk.NET.Windows.IUnknown value)
    {
        return new ITfMessagePump(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfMessagePump"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfMessagePump"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfMessagePump value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
