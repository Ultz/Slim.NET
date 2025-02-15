// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("64961751-0835-43C0-8FFE-D57686530E64")]
[NativeTypeName("struct IExplorerCommandProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExplorerCommandProvider
    : IExplorerCommandProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExplorerCommandProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExplorerCommandProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IExplorerCommandProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExplorerCommandProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCommands(
        IUnknown punkSite,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IExplorerCommandProvider, IUnknown, Guid*, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, punkSite, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCommand(
        [NativeTypeName("const GUID &")] Guid* rguidCommandId,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IExplorerCommandProvider, Guid*, Guid*, void**, int>)((*lpVtbl)[4])
        )(this, rguidCommandId, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCommands(
            IUnknown punkSite,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(4)]
        HRESULT GetCommand(
            [NativeTypeName("const GUID &")] Guid* rguidCommandId,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
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

        [NativeTypeName("HRESULT (IUnknown *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, Guid*, void**, int> GetCommands;

        [NativeTypeName("HRESULT (const GUID &, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> GetCommand;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExplorerCommandProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExplorerCommandProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExplorerCommandProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExplorerCommandProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IExplorerCommandProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExplorerCommandProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExplorerCommandProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IExplorerCommandProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
