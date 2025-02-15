// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5BC8A76B-869A-46A3-9B03-FA218A66AEBE")]
[NativeTypeName("struct IMFCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFCollection : IMFCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCollection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCollection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFCollection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCollection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetElementCount([NativeTypeName("DWORD *")] uint* pcElements)
    {
        return ((delegate* unmanaged<IMFCollection, uint*, int>)((*lpVtbl)[3]))(this, pcElements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetElement([NativeTypeName("DWORD")] uint dwElementIndex, IUnknown* ppUnkElement)
    {
        return ((delegate* unmanaged<IMFCollection, uint, IUnknown*, int>)((*lpVtbl)[4]))(
            this,
            dwElementIndex,
            ppUnkElement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddElement(IUnknown pUnkElement)
    {
        return ((delegate* unmanaged<IMFCollection, IUnknown, int>)((*lpVtbl)[5]))(
            this,
            pUnkElement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveElement(
        [NativeTypeName("DWORD")] uint dwElementIndex,
        IUnknown* ppUnkElement
    )
    {
        return ((delegate* unmanaged<IMFCollection, uint, IUnknown*, int>)((*lpVtbl)[6]))(
            this,
            dwElementIndex,
            ppUnkElement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertElementAt([NativeTypeName("DWORD")] uint dwIndex, IUnknown pUnknown)
    {
        return ((delegate* unmanaged<IMFCollection, uint, IUnknown, int>)((*lpVtbl)[7]))(
            this,
            dwIndex,
            pUnknown
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveAllElements()
    {
        return ((delegate* unmanaged<IMFCollection, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetElementCount([NativeTypeName("DWORD *")] uint* pcElements);

        [VtblIndex(4)]
        HRESULT GetElement([NativeTypeName("DWORD")] uint dwElementIndex, IUnknown* ppUnkElement);

        [VtblIndex(5)]
        HRESULT AddElement(IUnknown pUnkElement);

        [VtblIndex(6)]
        HRESULT RemoveElement(
            [NativeTypeName("DWORD")] uint dwElementIndex,
            IUnknown* ppUnkElement
        );

        [VtblIndex(7)]
        HRESULT InsertElementAt([NativeTypeName("DWORD")] uint dwIndex, IUnknown pUnknown);

        [VtblIndex(8)]
        HRESULT RemoveAllElements();
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetElementCount;

        [NativeTypeName("HRESULT (DWORD, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, int> GetElement;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> AddElement;

        [NativeTypeName("HRESULT (DWORD, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, int> RemoveElement;

        [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown, int> InsertElementAt;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllElements;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFCollection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFCollection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFCollection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFCollection(Silk.NET.Windows.IUnknown value)
    {
        return new IMFCollection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCollection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCollection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFCollection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
