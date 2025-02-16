// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Win32.IID;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <inheritdoc cref = "IDisposable.Dispose"></inheritdoc>
	[Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
[NativeTypeName("struct ID3DDestructionNotifier : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DDestructionNotifier : ID3DDestructionNotifier.Native.Interface, IComInterface, IDisposable
{
    public Native* lpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3DDestructionNotifier));

    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier"]/*'/>
    [Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
    [NativeTypeName("struct ID3DDestructionNotifier : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : ID3DDestructionNotifier.Native.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3DDestructionNotifier));

        public void** lpVtbl;
        public interface Interface : IUnknown.Native.Interface
        {
            [VtblIndex(4)]
            HRESULT UnregisterDestructionCallback(uint callbackID);
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
            [NativeTypeName("HRESULT (PFN_DESTRUCTION_CALLBACK, void *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, delegate* unmanaged<void*, void> , void*, uint*, int> RegisterDestructionCallback;
            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, int> UnregisterDestructionCallback;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier.Native*, uint> )(lpVtbl[1]))((ID3DDestructionNotifier.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier.Native*, Guid*, void**, int> )(lpVtbl[0]))((ID3DDestructionNotifier.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

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

        /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.RegisterDestructionCallback"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn, void* pData, uint* pCallbackID)
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier.Native*, delegate* unmanaged<void*, void> , void*, uint*, int> )(lpVtbl[3]))((ID3DDestructionNotifier.Native*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn, Ref pData, Ref<uint> pCallbackID)
        {
            fixed (uint* __dsl_pCallbackID = pCallbackID)
            fixed (void* __dsl_pData = pData)
            {
                return (HRESULT)RegisterDestructionCallback(callbackFn, __dsl_pData, __dsl_pCallbackID);
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier.Native*, uint> )(lpVtbl[2]))((ID3DDestructionNotifier.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.UnregisterDestructionCallback"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnregisterDestructionCallback(uint callbackID)
        {
            return ((delegate* unmanaged<ID3DDestructionNotifier.Native*, uint, int> )(lpVtbl[4]))((ID3DDestructionNotifier.Native*)Unsafe.AsPointer(ref this), callbackID);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3DDestructionNotifier"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3DDestructionNotifier(Ptr2D* vtbl) => lpVtbl = (ID3DDestructionNotifier.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3DDestructionNotifier"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3DDestructionNotifier(ID3DDestructionNotifier.Native* vtbl) => lpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3DDestructionNotifier.Native"/> to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier.Native"/> instance to be converted </param>
    public static implicit operator ID3DDestructionNotifier(ID3DDestructionNotifier.Native* value) => new ID3DDestructionNotifier(value);
    /// <summary>casts <see cref = "ID3DDestructionNotifier"/> to <see cref = "ID3DDestructionNotifier.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator ID3DDestructionNotifier.Native*(ID3DDestructionNotifier value) => value.lpVtbl;
    /// <summary>casts <see cref = "Ptr2D"/> to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr2D"/> instance to be converted </param>
    public static explicit operator ID3DDestructionNotifier(Ptr2D* value) => new ID3DDestructionNotifier(value);
    /// <summary>casts <see cref = "ID3DDestructionNotifier"/> to <see cref = "Ptr2D"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator Ptr2D*(ID3DDestructionNotifier value) => (Ptr2D*)value.lpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3DDestructionNotifier(Ptr<ID3DDestructionNotifier.Native> value) => new ID3DDestructionNotifier(value);
    /// <summary>casts <see cref = "ID3DDestructionNotifier"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator Ptr<ID3DDestructionNotifier.Native>(ID3DDestructionNotifier value) => (Ptr<ID3DDestructionNotifier.Native>)value.lpVtbl;
    /// <summary>casts void*** pointer to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The void*** instance to be converted</param>
    public static explicit operator ID3DDestructionNotifier(void*** value) => new ID3DDestructionNotifier((Native*)value);
    /// <summary>casts <see cref = "ID3DDestructionNotifier"/> to void*** pointer</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator void***(ID3DDestructionNotifier value) => (void***)value.lpVtbl;
    /// <summary>casts nuint to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The nuint instance to be converted</param>
    public static explicit operator ID3DDestructionNotifier(nuint value) => new ID3DDestructionNotifier((Native*)value.ToPointer());
    /// <summary>casts <see cref = "ID3DDestructionNotifier"/> to nuint</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator nuint(ID3DDestructionNotifier value) => (nuint)value.lpVtbl;
    /// <summary>Downcasts <see cref = "Silk.NET.Win32.IUnknown"/> to <see cref = "ID3DDestructionNotifier"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Win32.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3DDestructionNotifier(Silk.NET.Win32.IUnknown value) => new ID3DDestructionNotifier((ID3DDestructionNotifier.Native*)value.lpVtbl);
    /// <summary>Upcasts <see cref = "ID3DDestructionNotifier"/> to <see cref = "Silk.NET.Win32.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3DDestructionNotifier"/> instance to be converted </param>
    public static implicit operator Silk.NET.Win32.IUnknown(ID3DDestructionNotifier value) => new Silk.NET.Win32.IUnknown((Silk.NET.Win32.IUnknown.Native*)value.lpVtbl);
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => lpVtbl->AddRef();
    public void Dispose() => Release();
    /// <inheritdoc cref = "INativeInterface.GetAddressOf{TNativeInterface}()"></inheritdoc>
	public readonly Ptr2D<TNativeInterface> GetAddressOf<TNativeInterface>()
        where TNativeInterface : unmanaged => (TNativeInterface**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
    /// <inheritdoc cref = "INativeInterface.GetAddressOf()"></inheritdoc>
	public readonly Ptr2D GetAddressOf() => (void**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) => lpVtbl->QueryInterface(riid, ppvObject);
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

    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.RegisterDestructionCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn, void* pData, uint* pCallbackID) => lpVtbl->RegisterDestructionCallback(callbackFn, pData, pCallbackID);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* unmanaged<void*, void> callbackFn, Ref pData, Ref<uint> pCallbackID)
    {
        fixed (uint* __dsl_pCallbackID = pCallbackID)
        fixed (void* __dsl_pData = pData)
        {
            return (HRESULT)RegisterDestructionCallback(callbackFn, __dsl_pData, __dsl_pCallbackID);
        }
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => lpVtbl->Release();
    /// <include file='ID3DDestructionNotifier.xml' path='doc/member[@name="ID3DDestructionNotifier.UnregisterDestructionCallback"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterDestructionCallback(uint callbackID) => lpVtbl->UnregisterDestructionCallback(callbackID);
}