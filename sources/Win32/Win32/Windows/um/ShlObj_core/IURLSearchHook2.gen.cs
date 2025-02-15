// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5EE44DA4-6D32-46E3-86BC-07540DEDD0E0")]
[NativeTypeName("struct IURLSearchHook2 : IURLSearchHook")]
[NativeInheritance("IURLSearchHook")]
public unsafe partial struct IURLSearchHook2 : IURLSearchHook2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IURLSearchHook2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IURLSearchHook2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IURLSearchHook2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IURLSearchHook2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Translate(
        [NativeTypeName("PWSTR")] ushort* pwszSearchURL,
        [NativeTypeName("DWORD")] uint cchBufferSize
    )
    {
        return ((delegate* unmanaged<IURLSearchHook2, ushort*, uint, int>)((*lpVtbl)[3]))(
            this,
            pwszSearchURL,
            cchBufferSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TranslateWithSearchContext(
        [NativeTypeName("PWSTR")] ushort* pwszSearchURL,
        [NativeTypeName("DWORD")] uint cchBufferSize,
        ISearchContext pSearchContext
    )
    {
        return (
            (delegate* unmanaged<IURLSearchHook2, ushort*, uint, ISearchContext, int>)((*lpVtbl)[4])
        )(this, pwszSearchURL, cchBufferSize, pSearchContext);
    }

    public interface Interface : IURLSearchHook.Interface
    {
        [VtblIndex(4)]
        HRESULT TranslateWithSearchContext(
            [NativeTypeName("PWSTR")] ushort* pwszSearchURL,
            [NativeTypeName("DWORD")] uint cchBufferSize,
            ISearchContext pSearchContext
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

        [NativeTypeName("HRESULT (PWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> Translate;

        [NativeTypeName(
            "HRESULT (PWSTR, DWORD, ISearchContext *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            ISearchContext,
            int> TranslateWithSearchContext;
    }

    /// <summary>Initializes a new instance of the <see cref = "IURLSearchHook2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IURLSearchHook2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IURLSearchHook"/> to <see cref = "IURLSearchHook2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IURLSearchHook"/> instance to be converted </param>
    public static explicit operator IURLSearchHook2(Silk.NET.Windows.IURLSearchHook value)
    {
        return new IURLSearchHook2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IURLSearchHook2"/> to <see cref = "Silk.NET.Windows.IURLSearchHook"/>.</summary>
    /// <param name = "value">The <see cref = "IURLSearchHook2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IURLSearchHook(IURLSearchHook2 value)
    {
        return new Silk.NET.Windows.IURLSearchHook(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IURLSearchHook2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IURLSearchHook2(Silk.NET.Windows.IUnknown value)
    {
        return new IURLSearchHook2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IURLSearchHook2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IURLSearchHook2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IURLSearchHook2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
