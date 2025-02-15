// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1F76A169-F994-40AC-8FC8-0959E8874710")]
[NativeTypeName("struct IApplicationAssociationRegistrationUI : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IApplicationAssociationRegistrationUI
    : IApplicationAssociationRegistrationUI.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationAssociationRegistrationUI));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IApplicationAssociationRegistrationUI, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistrationUI, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistrationUI, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LaunchAdvancedAssociationUI(
        [NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName
    )
    {
        return (
            (delegate* unmanaged<IApplicationAssociationRegistrationUI, ushort*, int>)((*lpVtbl)[3])
        )(this, pszAppRegistryName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LaunchAdvancedAssociationUI([NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> LaunchAdvancedAssociationUI;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationAssociationRegistrationUI"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationAssociationRegistrationUI(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationAssociationRegistrationUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationAssociationRegistrationUI(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IApplicationAssociationRegistrationUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationAssociationRegistrationUI"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationAssociationRegistrationUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IApplicationAssociationRegistrationUI value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
