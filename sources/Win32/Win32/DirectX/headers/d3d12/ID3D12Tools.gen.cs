// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12Tools.xml' path='doc/member[@name="ID3D12Tools"]/*'/>
[Guid("7071E1F0-E84B-4B33-974F-12FA49DE65C5")]
[NativeTypeName("struct ID3D12Tools : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12Tools : ID3D12Tools.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Tools));
    public void** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Tools*, Guid*, void**, int>)(lpVtbl[0]))(
            (ID3D12Tools*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12Tools*, uint>)(lpVtbl[1]))(
            (ID3D12Tools*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Tools*, uint>)(lpVtbl[2]))(
            (ID3D12Tools*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='ID3D12Tools.xml' path='doc/member[@name="ID3D12Tools.EnableShaderInstrumentation"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableShaderInstrumentation(BOOL bEnable)
    {
        ((delegate* unmanaged<ID3D12Tools*, BOOL, void>)(lpVtbl[3]))(
            (ID3D12Tools*)Unsafe.AsPointer(ref this),
            bEnable
        );
    }

    /// <include file='ID3D12Tools.xml' path='doc/member[@name="ID3D12Tools.ShaderInstrumentationEnabled"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public BOOL ShaderInstrumentationEnabled()
    {
        return ((delegate* unmanaged<ID3D12Tools*, int>)(lpVtbl[4]))(
            (ID3D12Tools*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void EnableShaderInstrumentation(BOOL bEnable);

        [VtblIndex(4)]
        BOOL ShaderInstrumentationEnabled();
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

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> EnableShaderInstrumentation;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ShaderInstrumentationEnabled;
    }
}
