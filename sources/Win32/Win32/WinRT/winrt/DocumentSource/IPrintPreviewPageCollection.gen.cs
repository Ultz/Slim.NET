// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/DocumentSource.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("0B31CC62-D7EC-4747-9D6E-F2537D870F2B")]
[NativeTypeName("struct IPrintPreviewPageCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPrintPreviewPageCollection
    : IPrintPreviewPageCollection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintPreviewPageCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintPreviewPageCollection, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintPreviewPageCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintPreviewPageCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Paginate(
        [NativeTypeName("UINT32")] uint currentJobPage,
        IInspectable printTaskOptions
    )
    {
        return (
            (delegate* unmanaged<IPrintPreviewPageCollection, uint, IInspectable, int>)(
                (*lpVtbl)[3]
            )
        )(this, currentJobPage, printTaskOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MakePage(
        [NativeTypeName("UINT32")] uint desiredJobPage,
        float width,
        float height
    )
    {
        return (
            (delegate* unmanaged<IPrintPreviewPageCollection, uint, float, float, int>)(
                (*lpVtbl)[4]
            )
        )(this, desiredJobPage, width, height);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Paginate(
            [NativeTypeName("UINT32")] uint currentJobPage,
            IInspectable printTaskOptions
        );

        [VtblIndex(4)]
        HRESULT MakePage([NativeTypeName("UINT32")] uint desiredJobPage, float width, float height);
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

        [NativeTypeName("HRESULT (UINT32, IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IInspectable, int> Paginate;

        [NativeTypeName("HRESULT (UINT32, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, float, int> MakePage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintPreviewPageCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintPreviewPageCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintPreviewPageCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintPreviewPageCollection(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintPreviewPageCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintPreviewPageCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintPreviewPageCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintPreviewPageCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
