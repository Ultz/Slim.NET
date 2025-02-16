// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
using static Silk.NET.Win32.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <inheritdoc cref = "IDisposable.Dispose"></inheritdoc>

[Guid("8BA5FB08-5195-40E2-AC58-0D989C3A0102")]
[NativeTypeName("struct ID3D10Blob : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DBlob : ID3DBlob.Native.Interface, IComInterface, IDisposable
{
    public Native* lpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10Blob));

    /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob"]/*'/>

    [Guid("8BA5FB08-5195-40E2-AC58-0D989C3A0102")]
    [NativeTypeName("struct ID3D10Blob : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : ID3DBlob.Native.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10Blob));
        public void** lpVtbl;

        public interface Interface : IUnknown.Native.Interface
        {
            [VtblIndex(3)]
            [return: NativeTypeName("LPVOID")]
            [MethodImpl(
                MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
            )]
            Ptr GetBufferPointer();

            [VtblIndex(3)]
            [return: NativeTypeName("LPVOID")]
            void* GetBufferPointerRaw();

            [VtblIndex(4)]
            [return: NativeTypeName("SIZE_T")]
            nuint GetBufferSize();
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

            [NativeTypeName("LPVOID () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*> GetBufferPointer;

            [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, nuint> GetBufferSize;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3DBlob.Native*, uint>)(lpVtbl[1]))(
                (ID3DBlob.Native*)Unsafe.AsPointer(ref this)
            );
        }

        [VtblIndex(3)]
        [return: NativeTypeName("LPVOID")]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr GetBufferPointer() => (void*)GetBufferPointerRaw();

        /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferPointer"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("LPVOID")]
        public void* GetBufferPointerRaw()
        {
            return ((delegate* unmanaged<ID3DBlob.Native*, void*>)(lpVtbl[3]))(
                (ID3DBlob.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferSize"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("SIZE_T")]
        public nuint GetBufferSize()
        {
            return ((delegate* unmanaged<ID3DBlob.Native*, nuint>)(lpVtbl[4]))(
                (ID3DBlob.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3DBlob.Native*, Guid*, void**, int>)(lpVtbl[0]))(
                (ID3DBlob.Native*)Unsafe.AsPointer(ref this),
                riid,
                ppvObject
            );
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HRESULT QueryInterface(
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvObject
        )
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HRESULT)QueryInterface(__dsl_riid, __dsl_ppvObject);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface<TCom>(out TCom ppvObject)
            where TCom : unmanaged, IComInterface
        {
            ppvObject = default;
            return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        /// <inheritdoc cref = "IUnknown.Release"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3DBlob.Native*, uint>)(lpVtbl[2]))(
                (ID3DBlob.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3DBlob"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public ID3DBlob(Ptr2D* vtbl) => lpVtbl = (ID3DBlob.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "ID3DBlob"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public ID3DBlob(ID3DBlob.Native* vtbl) => lpVtbl = vtbl;

    /// <summary>casts <see cref = "ID3DBlob.Native"/> to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The <see cref = "ID3DBlob.Native"/> instance to be converted </param>

    public static implicit operator ID3DBlob(ID3DBlob.Native* value) => new ID3DBlob(value);

    /// <summary>casts <see cref = "ID3DBlob"/> to <see cref = "ID3DBlob.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator ID3DBlob.Native*(ID3DBlob value) => value.lpVtbl;

    /// <summary>casts <see cref = "Ptr2D"/> to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr2D"/> instance to be converted </param>

    public static explicit operator ID3DBlob(Ptr2D* value) => new ID3DBlob(value);

    /// <summary>casts <see cref = "ID3DBlob"/> to <see cref = "Ptr2D"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator Ptr2D*(ID3DBlob value) => (Ptr2D*)value.lpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator ID3DBlob(Ptr<ID3DBlob.Native> value) => new ID3DBlob(value);

    /// <summary>casts <see cref = "ID3DBlob"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator Ptr<ID3DBlob.Native>(ID3DBlob value) =>
        (Ptr<ID3DBlob.Native>)value.lpVtbl;

    /// <summary>casts void*** pointer to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The void*** instance to be converted</param>

    public static explicit operator ID3DBlob(void*** value) => new ID3DBlob((Native*)value);

    /// <summary>casts <see cref = "ID3DBlob"/> to void*** pointer</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator void***(ID3DBlob value) => (void***)value.lpVtbl;

    /// <summary>casts nuint to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The nuint instance to be converted</param>

    public static explicit operator ID3DBlob(nuint value) =>
        new ID3DBlob((Native*)value.ToPointer());

    /// <summary>casts <see cref = "ID3DBlob"/> to nuint</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator nuint(ID3DBlob value) => (nuint)value.lpVtbl;

    /// <summary>Downcasts <see cref = "Silk.NET.Win32.IUnknown"/> to <see cref = "ID3DBlob"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Win32.IUnknown"/> instance to be converted </param>

    public static explicit operator ID3DBlob(Silk.NET.Win32.IUnknown value) =>
        new ID3DBlob((ID3DBlob.Native*)value.lpVtbl);

    /// <summary>Upcasts <see cref = "ID3DBlob"/> to <see cref = "Silk.NET.Win32.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3DBlob"/> instance to be converted </param>

    public static implicit operator Silk.NET.Win32.IUnknown(ID3DBlob value) =>
        new Silk.NET.Win32.IUnknown((Silk.NET.Win32.IUnknown.Native*)value.lpVtbl);

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => lpVtbl->AddRef();

    public void Dispose() => Release();

    /// <inheritdoc cref = "INativeInterface.GetAddressOf{TNativeInterface}()"></inheritdoc>

    public readonly Ptr2D<TNativeInterface> GetAddressOf<TNativeInterface>()
        where TNativeInterface : unmanaged =>
        (TNativeInterface**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));

    /// <inheritdoc cref = "INativeInterface.GetAddressOf()"></inheritdoc>

    public readonly Ptr2D GetAddressOf() => (void**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));

    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public Ptr GetBufferPointer() => (void*)GetBufferPointerRaw();

    /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferPointer"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointerRaw() => lpVtbl->GetBufferPointerRaw();

    /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferSize"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize() => lpVtbl->GetBufferSize();

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) =>
        lpVtbl->QueryInterface(riid, ppvObject);

    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HRESULT)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComInterface
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => lpVtbl->Release();
}
