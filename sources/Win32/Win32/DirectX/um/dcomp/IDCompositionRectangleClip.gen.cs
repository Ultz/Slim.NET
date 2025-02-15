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

[Guid("9842AD7D-D9CF-4908-AED7-48B51DA5E7C2")]
[NativeTypeName("struct IDCompositionRectangleClip : IDCompositionClip")]
[NativeInheritance("IDCompositionClip")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionRectangleClip
    : IDCompositionRectangleClip.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionRectangleClip));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetLeft(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[3]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetLeft(float left)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[4]))(
            this,
            left
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetTop(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[5]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTop(float top)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[6]))(
            this,
            top
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRight(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[7]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRight(float right)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[8]))(
            this,
            right
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetBottom(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[9]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetBottom(float bottom)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[10]))(
            this,
            bottom
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetTopLeftRadiusX(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[11]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetTopLeftRadiusX(float radius)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[12]))(
            this,
            radius
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetTopLeftRadiusY(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[13]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetTopLeftRadiusY(float radius)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[14]))(
            this,
            radius
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetTopRightRadiusX(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[15]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetTopRightRadiusX(float radius)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[16]))(
            this,
            radius
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTopRightRadiusY(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[17]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetTopRightRadiusY(float radius)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[18]))(
            this,
            radius
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetBottomLeftRadiusX(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[19]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetBottomLeftRadiusX(float radius)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[20]))(
            this,
            radius
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetBottomLeftRadiusY(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[21]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetBottomLeftRadiusY(float radius)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[22]))(
            this,
            radius
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetBottomRightRadiusX(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[23]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetBottomRightRadiusX(float radius)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[24]))(
            this,
            radius
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetBottomRightRadiusY(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRectangleClip, IDCompositionAnimation, int>)(
                (*lpVtbl)[25]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetBottomRightRadiusY(float radius)
    {
        return ((delegate* unmanaged<IDCompositionRectangleClip, float, int>)((*lpVtbl)[26]))(
            this,
            radius
        );
    }

    public interface Interface : IDCompositionClip.Interface
    {
        [VtblIndex(3)]
        HRESULT SetLeft(IDCompositionAnimation animation);

        [VtblIndex(4)]
        HRESULT SetLeft(float left);

        [VtblIndex(5)]
        HRESULT SetTop(IDCompositionAnimation animation);

        [VtblIndex(6)]
        HRESULT SetTop(float top);

        [VtblIndex(7)]
        HRESULT SetRight(IDCompositionAnimation animation);

        [VtblIndex(8)]
        HRESULT SetRight(float right);

        [VtblIndex(9)]
        HRESULT SetBottom(IDCompositionAnimation animation);

        [VtblIndex(10)]
        HRESULT SetBottom(float bottom);

        [VtblIndex(11)]
        HRESULT SetTopLeftRadiusX(IDCompositionAnimation animation);

        [VtblIndex(12)]
        HRESULT SetTopLeftRadiusX(float radius);

        [VtblIndex(13)]
        HRESULT SetTopLeftRadiusY(IDCompositionAnimation animation);

        [VtblIndex(14)]
        HRESULT SetTopLeftRadiusY(float radius);

        [VtblIndex(15)]
        HRESULT SetTopRightRadiusX(IDCompositionAnimation animation);

        [VtblIndex(16)]
        HRESULT SetTopRightRadiusX(float radius);

        [VtblIndex(17)]
        HRESULT SetTopRightRadiusY(IDCompositionAnimation animation);

        [VtblIndex(18)]
        HRESULT SetTopRightRadiusY(float radius);

        [VtblIndex(19)]
        HRESULT SetBottomLeftRadiusX(IDCompositionAnimation animation);

        [VtblIndex(20)]
        HRESULT SetBottomLeftRadiusX(float radius);

        [VtblIndex(21)]
        HRESULT SetBottomLeftRadiusY(IDCompositionAnimation animation);

        [VtblIndex(22)]
        HRESULT SetBottomLeftRadiusY(float radius);

        [VtblIndex(23)]
        HRESULT SetBottomRightRadiusX(IDCompositionAnimation animation);

        [VtblIndex(24)]
        HRESULT SetBottomRightRadiusX(float radius);

        [VtblIndex(25)]
        HRESULT SetBottomRightRadiusY(IDCompositionAnimation animation);

        [VtblIndex(26)]
        HRESULT SetBottomRightRadiusY(float radius);
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
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetLeft;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetLeft1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetTop;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetTop1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetRight;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetRight1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetBottom;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBottom1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetTopLeftRadiusX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetTopLeftRadiusX1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetTopLeftRadiusY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetTopLeftRadiusY1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetTopRightRadiusX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetTopRightRadiusX1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetTopRightRadiusY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetTopRightRadiusY1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetBottomLeftRadiusX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBottomLeftRadiusX1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetBottomLeftRadiusY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBottomLeftRadiusY1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetBottomRightRadiusX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBottomRightRadiusX1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetBottomRightRadiusY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetBottomRightRadiusY1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionRectangleClip"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionRectangleClip(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionClip"/> to <see cref = "IDCompositionRectangleClip"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionClip"/> instance to be converted </param>
    public static explicit operator IDCompositionRectangleClip(
        Silk.NET.DirectX.IDCompositionClip value
    )
    {
        return new IDCompositionRectangleClip(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionRectangleClip"/> to <see cref = "Silk.NET.DirectX.IDCompositionClip"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionRectangleClip"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionClip(
        IDCompositionRectangleClip value
    )
    {
        return new Silk.NET.DirectX.IDCompositionClip(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionRectangleClip"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionRectangleClip(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionRectangleClip(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionRectangleClip"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionRectangleClip"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionRectangleClip value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
