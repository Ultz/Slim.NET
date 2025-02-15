// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C81984C4-74C8-11D2-BAA9-00C04FC2040E")]
[NativeTypeName("struct ISecureUrlHost : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISecureUrlHost : ISecureUrlHost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISecureUrlHost));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISecureUrlHost, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISecureUrlHost, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISecureUrlHost, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ValidateSecureUrl(
        BOOL* pfAllow,
        [NativeTypeName("OLECHAR *")] ushort* pchUrlInQuestion,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<ISecureUrlHost, BOOL*, ushort*, uint, int>)((*lpVtbl)[3]))(
            this,
            pfAllow,
            pchUrlInQuestion,
            dwFlags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ValidateSecureUrl(
            BOOL* pfAllow,
            [NativeTypeName("OLECHAR *")] ushort* pchUrlInQuestion,
            [NativeTypeName("DWORD")] uint dwFlags
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

        [NativeTypeName("HRESULT (BOOL *, OLECHAR *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, ushort*, uint, int> ValidateSecureUrl;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISecureUrlHost"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISecureUrlHost(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISecureUrlHost"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISecureUrlHost(Silk.NET.Windows.IUnknown value)
    {
        return new ISecureUrlHost(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISecureUrlHost"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISecureUrlHost"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISecureUrlHost value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
