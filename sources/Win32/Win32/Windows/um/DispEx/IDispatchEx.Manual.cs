// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DispEx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Win32.IID;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;
/// <inheritdoc cref = "IDisposable.Dispose"></inheritdoc>
	[Guid("A6EF9860-C720-11D0-9337-00A0C90DCAA9")]
[NativeTypeName("struct IDispatchEx : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDispatchEx : IDispatch.Native.Interface, IComInterface, IDisposable
{
    public Native* lpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDispatchEx));

    [Guid("A6EF9860-C720-11D0-9337-00A0C90DCAA9")]
    [NativeTypeName("struct IDispatchEx : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct Native : IDispatch.Native.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDispatchEx));

        public void** lpVtbl;
        public interface Interface : IDispatch.Native.Interface
        {
            [VtblIndex(10)]
            HRESULT DeleteMemberByDispID([NativeTypeName("DISPID")] int id);
            [VtblIndex(9)]
            HRESULT DeleteMemberByName([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex);
            [VtblIndex(9)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            HRESULT DeleteMemberByName([NativeTypeName("BSTR")] Ref<ushort> bstrName, [NativeTypeName("DWORD")] uint grfdex);
            [VtblIndex(7)]
            HRESULT GetDispID([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID *")] int* pid);
            [VtblIndex(7)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            HRESULT GetDispID([NativeTypeName("BSTR")] Ref<ushort> bstrName, [NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID *")] Ref<int> pid);
            [VtblIndex(12)]
            HRESULT GetMemberName([NativeTypeName("DISPID")] int id, [NativeTypeName("BSTR *")] ushort** pbstrName);
            [VtblIndex(12)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            HRESULT GetMemberName([NativeTypeName("DISPID")] int id, [NativeTypeName("BSTR *")] Ref2D<ushort> pbstrName);
            [VtblIndex(11)]
            HRESULT GetMemberProperties([NativeTypeName("DISPID")] int id, [NativeTypeName("DWORD")] uint grfdexFetch, [NativeTypeName("DWORD *")] uint* pgrfdex);
            [VtblIndex(11)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            HRESULT GetMemberProperties([NativeTypeName("DISPID")] int id, [NativeTypeName("DWORD")] uint grfdexFetch, [NativeTypeName("DWORD *")] Ref<uint> pgrfdex);
            [VtblIndex(14)]
            HRESULT GetNameSpaceParent(IUnknown* ppunk);
            [VtblIndex(14)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            HRESULT GetNameSpaceParent(Ref<IUnknown> ppunk);
            [VtblIndex(13)]
            HRESULT GetNextDispID([NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID")] int id, [NativeTypeName("DISPID *")] int* pid);
            [VtblIndex(13)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            HRESULT GetNextDispID([NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID")] int id, [NativeTypeName("DISPID *")] Ref<int> pid);
            [VtblIndex(8)]
            HRESULT InvokeEx([NativeTypeName("DISPID")] int id, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdp, VARIANT* pvarRes, EXCEPINFO* pei, IServiceProvider pspCaller);
            [VtblIndex(8)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            HRESULT InvokeEx([NativeTypeName("DISPID")] int id, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, Ref<DISPPARAMS> pdp, Ref<VARIANT> pvarRes, Ref<EXCEPINFO> pei, IServiceProvider pspCaller);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, Guid*, void**, int> QueryInterface;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, uint> AddRef;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, uint> Release;
            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, uint*, int> GetTypeInfoCount;
            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, uint, uint, ITypeInfo.Native**, int> GetTypeInfo;
            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
            [NativeTypeName("HRESULT (BSTR, DWORD, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, ushort*, uint, int*, int> GetDispID;
            [NativeTypeName("HRESULT (DISPID, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, IServiceProvider *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, int, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, IServiceProvider.Native*, int> InvokeEx;
            [NativeTypeName("HRESULT (BSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, ushort*, uint, int> DeleteMemberByName;
            [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, int, int> DeleteMemberByDispID;
            [NativeTypeName("HRESULT (DISPID, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, int, uint, uint*, int> GetMemberProperties;
            [NativeTypeName("HRESULT (DISPID, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, int, ushort**, int> GetMemberName;
            [NativeTypeName("HRESULT (DWORD, DISPID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, uint, int, int*, int> GetNextDispID;
            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, IUnknown.Native**, int> GetNameSpaceParent;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, uint> )(lpVtbl[1]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT DeleteMemberByDispID([NativeTypeName("DISPID")] int id)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, int, int> )(lpVtbl[10]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT DeleteMemberByName([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, ushort*, uint, int> )(lpVtbl[9]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), bstrName, grfdex);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT DeleteMemberByName([NativeTypeName("BSTR")] Ref<ushort> bstrName, [NativeTypeName("DWORD")] uint grfdex)
        {
            fixed (ushort* __dsl_bstrName = bstrName)
            {
                return (HRESULT)DeleteMemberByName(__dsl_bstrName, grfdex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDispID([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID *")] int* pid)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, ushort*, uint, int*, int> )(lpVtbl[7]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), bstrName, grfdex, pid);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT GetDispID([NativeTypeName("BSTR")] Ref<ushort> bstrName, [NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID *")] Ref<int> pid)
        {
            fixed (int* __dsl_pid = pid)
            fixed (ushort* __dsl_bstrName = bstrName)
            {
                return (HRESULT)GetDispID(__dsl_bstrName, grfdex, __dsl_pid);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Ref<Guid> riid, [NativeTypeName("LPOLESTR *")] Ref2D<ushort> rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] Ref<int> rgDispId)
        {
            fixed (int* __dsl_rgDispId = rgDispId)
            fixed (ushort** __dsl_rgszNames = rgszNames)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HRESULT)GetIDsOfNames(__dsl_riid, __dsl_rgszNames, cNames, lcid, __dsl_rgDispId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetMemberName([NativeTypeName("DISPID")] int id, [NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, int, ushort**, int> )(lpVtbl[12]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), id, pbstrName);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT GetMemberName([NativeTypeName("DISPID")] int id, [NativeTypeName("BSTR *")] Ref2D<ushort> pbstrName)
        {
            fixed (ushort** __dsl_pbstrName = pbstrName)
            {
                return (HRESULT)GetMemberName(id, __dsl_pbstrName);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetMemberProperties([NativeTypeName("DISPID")] int id, [NativeTypeName("DWORD")] uint grfdexFetch, [NativeTypeName("DWORD *")] uint* pgrfdex)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, int, uint, uint*, int> )(lpVtbl[11]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), id, grfdexFetch, pgrfdex);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT GetMemberProperties([NativeTypeName("DISPID")] int id, [NativeTypeName("DWORD")] uint grfdexFetch, [NativeTypeName("DWORD *")] Ref<uint> pgrfdex)
        {
            fixed (uint* __dsl_pgrfdex = pgrfdex)
            {
                return (HRESULT)GetMemberProperties(id, grfdexFetch, __dsl_pgrfdex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetNameSpaceParent(IUnknown* ppunk)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, IUnknown.Native**, int> )(lpVtbl[14]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), &ppunk->lpVtbl);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT GetNameSpaceParent(Ref<IUnknown> ppunk)
        {
            fixed (IUnknown* __dsl_ppunk = ppunk)
            {
                return (HRESULT)GetNameSpaceParent(__dsl_ppunk);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetNextDispID([NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID")] int id, [NativeTypeName("DISPID *")] int* pid)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, uint, int, int*, int> )(lpVtbl[13]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), grfdex, id, pid);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT GetNextDispID([NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID")] int id, [NativeTypeName("DISPID *")] Ref<int> pid)
        {
            fixed (int* __dsl_pid = pid)
            {
                return (HRESULT)GetNextDispID(grfdex, id, __dsl_pid);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, uint, uint, ITypeInfo.Native**, int> )(lpVtbl[4]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), iTInfo, lcid, &ppTInfo->lpVtbl);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, Ref<ITypeInfo> ppTInfo)
        {
            fixed (ITypeInfo* __dsl_ppTInfo = ppTInfo)
            {
                return (HRESULT)GetTypeInfo(iTInfo, lcid, __dsl_ppTInfo);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, uint*, int> )(lpVtbl[3]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT GetTypeInfoCount(Ref<uint> pctinfo)
        {
            fixed (uint* __dsl_pctinfo = pctinfo)
            {
                return (HRESULT)GetTypeInfoCount(__dsl_pctinfo);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Ref<Guid> riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, Ref<DISPPARAMS> pDispParams, Ref<VARIANT> pVarResult, Ref<EXCEPINFO> pExcepInfo, Ref<uint> puArgErr)
        {
            fixed (uint* __dsl_puArgErr = puArgErr)
            fixed (EXCEPINFO* __dsl_pExcepInfo = pExcepInfo)
            fixed (VARIANT* __dsl_pVarResult = pVarResult)
            fixed (DISPPARAMS* __dsl_pDispParams = pDispParams)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HRESULT)Invoke(dispIdMember, __dsl_riid, lcid, wFlags, __dsl_pDispParams, __dsl_pVarResult, __dsl_pExcepInfo, __dsl_puArgErr);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT InvokeEx([NativeTypeName("DISPID")] int id, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdp, VARIANT* pvarRes, EXCEPINFO* pei, IServiceProvider pspCaller)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, int, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, IServiceProvider.Native*, int> )(lpVtbl[8]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), id, lcid, wFlags, pdp, pvarRes, pei, pspCaller.lpVtbl);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT InvokeEx([NativeTypeName("DISPID")] int id, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, Ref<DISPPARAMS> pdp, Ref<VARIANT> pvarRes, Ref<EXCEPINFO> pei, IServiceProvider pspCaller)
        {
            fixed (EXCEPINFO* __dsl_pei = pei)
            fixed (VARIANT* __dsl_pvarRes = pvarRes)
            fixed (DISPPARAMS* __dsl_pdp = pdp)
            {
                return (HRESULT)InvokeEx(id, lcid, wFlags, __dsl_pdp, __dsl_pvarRes, __dsl_pei, pspCaller);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, Guid*, void**, int> )(lpVtbl[0]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface<TCom>(out TCom ppvObject)
            where TCom : unmanaged, IComInterface
        {
            ppvObject = default;
            return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, uint> )(lpVtbl[2]))((IDispatchEx.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDispatchEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDispatchEx(Ptr2D* vtbl) => lpVtbl = (IDispatchEx.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "IDispatchEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDispatchEx(IDispatchEx.Native* vtbl) => lpVtbl = vtbl;
    /// <summary>casts <see cref = "IDispatchEx.Native"/> to <see cref = "IDispatchEx"/>.</summary>
    /// <param name = "value">The <see cref = "IDispatchEx.Native"/> instance to be converted </param>
    public static implicit operator IDispatchEx(IDispatchEx.Native* value) => new IDispatchEx(value);
    /// <summary>casts <see cref = "IDispatchEx"/> to <see cref = "IDispatchEx.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDispatchEx"/> instance to be converted </param>
    public static implicit operator IDispatchEx.Native*(IDispatchEx value) => value.lpVtbl;
    /// <summary>casts <see cref = "Ptr2D"/> to <see cref = "IDispatchEx"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr2D"/> instance to be converted </param>
    public static explicit operator IDispatchEx(Ptr2D* value) => new IDispatchEx(value);
    /// <summary>casts <see cref = "IDispatchEx"/> to <see cref = "Ptr2D"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDispatchEx"/> instance to be converted </param>
    public static implicit operator Ptr2D*(IDispatchEx value) => (Ptr2D*)value.lpVtbl;
    /// <summary>casts void*** pointer to <see cref = "IDispatchEx"/>.</summary>
    /// <param name = "value">The void*** instance to be converted</param>
    public static explicit operator IDispatchEx(void*** value) => new IDispatchEx((Native*)value);
    /// <summary>casts <see cref = "IDispatchEx"/> to void*** pointer</summary>
    /// <param name = "value">The <see cref = "IDispatchEx"/> instance to be converted </param>
    public static implicit operator void***(IDispatchEx value) => (void***)value.lpVtbl;
    /// <summary>casts nuint to <see cref = "IDispatchEx"/>.</summary>
    /// <param name = "value">The nuint instance to be converted</param>
    public static explicit operator IDispatchEx(nuint value) => new IDispatchEx((Native*)value.ToPointer());
    /// <summary>casts <see cref = "IDispatchEx"/> to nuint</summary>
    /// <param name = "value">The <see cref = "IDispatchEx"/> instance to be converted </param>
    public static implicit operator nuint(IDispatchEx value) => (nuint)value.lpVtbl;
    /// <summary>Downcasts <see cref = "Silk.NET.Win32.IUnknown"/> to <see cref = "IDispatchEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Win32.IUnknown"/> instance to be converted </param>
    public static explicit operator IDispatchEx(Silk.NET.Win32.IUnknown value) => new IDispatchEx((IDispatchEx.Native*)value.lpVtbl);
    /// <summary>Upcasts <see cref = "IDispatchEx"/> to <see cref = "Silk.NET.Win32.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDispatchEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Win32.IUnknown(IDispatchEx value) => new Silk.NET.Win32.IUnknown((Silk.NET.Win32.IUnknown.Native*)value.lpVtbl);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => lpVtbl->AddRef();
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteMemberByDispID([NativeTypeName("DISPID")] int id) => lpVtbl->DeleteMemberByDispID(id);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeleteMemberByName([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex) => lpVtbl->DeleteMemberByName(bstrName, grfdex);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT DeleteMemberByName([NativeTypeName("BSTR")] Ref<ushort> bstrName, [NativeTypeName("DWORD")] uint grfdex)
    {
        fixed (ushort* __dsl_bstrName = bstrName)
        {
            return (HRESULT)DeleteMemberByName(__dsl_bstrName, grfdex);
        }
    }

    public void Dispose() => Release();
    /// <inheritdoc cref = "INativeInterface.GetAddressOf{TNativeInterface}()"></inheritdoc>
	public readonly Ptr2D<TNativeInterface> GetAddressOf<TNativeInterface>()
        where TNativeInterface : unmanaged => (TNativeInterface**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
    /// <inheritdoc cref = "INativeInterface.GetAddressOf()"></inheritdoc>
	public readonly Ptr2D GetAddressOf() => (void**)Unsafe.AsPointer(ref Unsafe.AsRef(in this));
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDispID([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID *")] int* pid) => lpVtbl->GetDispID(bstrName, grfdex, pid);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetDispID([NativeTypeName("BSTR")] Ref<ushort> bstrName, [NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID *")] Ref<int> pid)
    {
        fixed (int* __dsl_pid = pid)
        fixed (ushort* __dsl_bstrName = bstrName)
        {
            return (HRESULT)GetDispID(__dsl_bstrName, grfdex, __dsl_pid);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId) => lpVtbl->GetIDsOfNames(riid, rgszNames, cNames, lcid, rgDispId);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Ref<Guid> riid, [NativeTypeName("LPOLESTR *")] Ref2D<ushort> rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] Ref<int> rgDispId)
    {
        fixed (int* __dsl_rgDispId = rgDispId)
        fixed (ushort** __dsl_rgszNames = rgszNames)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HRESULT)GetIDsOfNames(__dsl_riid, __dsl_rgszNames, cNames, lcid, __dsl_rgDispId);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMemberName([NativeTypeName("DISPID")] int id, [NativeTypeName("BSTR *")] ushort** pbstrName) => lpVtbl->GetMemberName(id, pbstrName);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetMemberName([NativeTypeName("DISPID")] int id, [NativeTypeName("BSTR *")] Ref2D<ushort> pbstrName)
    {
        fixed (ushort** __dsl_pbstrName = pbstrName)
        {
            return (HRESULT)GetMemberName(id, __dsl_pbstrName);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMemberProperties([NativeTypeName("DISPID")] int id, [NativeTypeName("DWORD")] uint grfdexFetch, [NativeTypeName("DWORD *")] uint* pgrfdex) => lpVtbl->GetMemberProperties(id, grfdexFetch, pgrfdex);
    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetMemberProperties([NativeTypeName("DISPID")] int id, [NativeTypeName("DWORD")] uint grfdexFetch, [NativeTypeName("DWORD *")] Ref<uint> pgrfdex)
    {
        fixed (uint* __dsl_pgrfdex = pgrfdex)
        {
            return (HRESULT)GetMemberProperties(id, grfdexFetch, __dsl_pgrfdex);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetNameSpaceParent(IUnknown* ppunk) => lpVtbl->GetNameSpaceParent(ppunk);
    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetNameSpaceParent(Ref<IUnknown> ppunk)
    {
        fixed (IUnknown* __dsl_ppunk = ppunk)
        {
            return (HRESULT)GetNameSpaceParent(__dsl_ppunk);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetNextDispID([NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID")] int id, [NativeTypeName("DISPID *")] int* pid) => lpVtbl->GetNextDispID(grfdex, id, pid);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetNextDispID([NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID")] int id, [NativeTypeName("DISPID *")] Ref<int> pid)
    {
        fixed (int* __dsl_pid = pid)
        {
            return (HRESULT)GetNextDispID(grfdex, id, __dsl_pid);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo) => lpVtbl->GetTypeInfo(iTInfo, lcid, ppTInfo);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, Ref<ITypeInfo> ppTInfo)
    {
        fixed (ITypeInfo* __dsl_ppTInfo = ppTInfo)
        {
            return (HRESULT)GetTypeInfo(iTInfo, lcid, __dsl_ppTInfo);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo) => lpVtbl->GetTypeInfoCount(pctinfo);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT GetTypeInfoCount(Ref<uint> pctinfo)
    {
        fixed (uint* __dsl_pctinfo = pctinfo)
        {
            return (HRESULT)GetTypeInfoCount(__dsl_pctinfo);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr) => lpVtbl->Invoke(dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Ref<Guid> riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, Ref<DISPPARAMS> pDispParams, Ref<VARIANT> pVarResult, Ref<EXCEPINFO> pExcepInfo, Ref<uint> puArgErr)
    {
        fixed (uint* __dsl_puArgErr = puArgErr)
        fixed (EXCEPINFO* __dsl_pExcepInfo = pExcepInfo)
        fixed (VARIANT* __dsl_pVarResult = pVarResult)
        fixed (DISPPARAMS* __dsl_pDispParams = pDispParams)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HRESULT)Invoke(dispIdMember, __dsl_riid, lcid, wFlags, __dsl_pDispParams, __dsl_pVarResult, __dsl_pExcepInfo, __dsl_puArgErr);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InvokeEx([NativeTypeName("DISPID")] int id, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdp, VARIANT* pvarRes, EXCEPINFO* pei, IServiceProvider pspCaller) => lpVtbl->InvokeEx(id, lcid, wFlags, pdp, pvarRes, pei, pspCaller);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HRESULT InvokeEx([NativeTypeName("DISPID")] int id, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, Ref<DISPPARAMS> pdp, Ref<VARIANT> pvarRes, Ref<EXCEPINFO> pei, IServiceProvider pspCaller)
    {
        fixed (EXCEPINFO* __dsl_pei = pei)
        fixed (VARIANT* __dsl_pvarRes = pvarRes)
        fixed (DISPPARAMS* __dsl_pdp = pdp)
        {
            return (HRESULT)InvokeEx(id, lcid, wFlags, __dsl_pdp, __dsl_pvarRes, __dsl_pei, pspCaller);
        }
    }

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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComInterface
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => lpVtbl->Release();
}
