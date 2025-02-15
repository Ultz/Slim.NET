// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("AE471C51-5F53-4A24-8D3E-D0C39C30B3F0")]
[NativeTypeName("struct IDCompositionVirtualSurface : IDCompositionSurface")]
[NativeInheritance("IDCompositionSurface")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionVirtualSurface
    : IDCompositionVirtualSurface.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionVirtualSurface));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionVirtualSurface, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionVirtualSurface, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionVirtualSurface, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginDraw(
        [NativeTypeName("const RECT *")] RECT* updateRect,
        [NativeTypeName("const IID &")] Guid* iid,
        void** updateObject,
        POINT* updateOffset
    )
    {
        return (
            (delegate* unmanaged<IDCompositionVirtualSurface, RECT*, Guid*, void**, POINT*, int>)(
                (*lpVtbl)[3]
            )
        )(this, updateRect, iid, updateObject, updateOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<IDCompositionVirtualSurface, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SuspendDraw()
    {
        return ((delegate* unmanaged<IDCompositionVirtualSurface, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ResumeDraw()
    {
        return ((delegate* unmanaged<IDCompositionVirtualSurface, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Scroll(
        [NativeTypeName("const RECT *")] RECT* scrollRect,
        [NativeTypeName("const RECT *")] RECT* clipRect,
        int offsetX,
        int offsetY
    )
    {
        return (
            (delegate* unmanaged<IDCompositionVirtualSurface, RECT*, RECT*, int, int, int>)(
                (*lpVtbl)[7]
            )
        )(this, scrollRect, clipRect, offsetX, offsetY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Resize(uint width, uint height)
    {
        return ((delegate* unmanaged<IDCompositionVirtualSurface, uint, uint, int>)((*lpVtbl)[8]))(
            this,
            width,
            height
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Trim([NativeTypeName("const RECT *")] RECT* rectangles, uint count)
    {
        return ((delegate* unmanaged<IDCompositionVirtualSurface, RECT*, uint, int>)((*lpVtbl)[9]))(
            this,
            rectangles,
            count
        );
    }

    public interface Interface : IDCompositionSurface.Interface
    {
        [VtblIndex(8)]
        HRESULT Resize(uint width, uint height);

        [VtblIndex(9)]
        HRESULT Trim([NativeTypeName("const RECT *")] RECT* rectangles, uint count);
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

        [NativeTypeName(
            "HRESULT (const RECT *, const IID &, void **, POINT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, Guid*, void**, POINT*, int> BeginDraw;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndDraw;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SuspendDraw;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResumeDraw;

        [NativeTypeName(
            "HRESULT (const RECT *, const RECT *, int, int) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int, int, int> Scroll;

        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> Resize;

        [NativeTypeName(
            "HRESULT (const RECT *, UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, uint, int> Trim;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionVirtualSurface"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionVirtualSurface(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionSurface"/> to <see cref = "IDCompositionVirtualSurface"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionSurface"/> instance to be converted </param>
    public static explicit operator IDCompositionVirtualSurface(
        Silk.NET.DirectX.IDCompositionSurface value
    )
    {
        return new IDCompositionVirtualSurface(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionVirtualSurface"/> to <see cref = "Silk.NET.DirectX.IDCompositionSurface"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionVirtualSurface"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionSurface(
        IDCompositionVirtualSurface value
    )
    {
        return new Silk.NET.DirectX.IDCompositionSurface(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionVirtualSurface"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionVirtualSurface(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionVirtualSurface(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionVirtualSurface"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionVirtualSurface"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionVirtualSurface value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
