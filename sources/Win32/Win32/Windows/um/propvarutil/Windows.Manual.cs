// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Win32.E;
using static Silk.NET.Win32.PROPVAR_COMPARE_FLAGS;
using static Silk.NET.Win32.PROPVAR_COMPARE_UNIT;
using static Silk.NET.Win32.S;
using static Silk.NET.Win32.VARENUM;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromBoolean"]/*'/>
    public static HRESULT InitPropVariantFromBoolean(BOOL fVal, PROPVARIANT* ppropvar)
    {
        ((ppropvar)->Anonymous.Anonymous.vt) = (ushort)(VT_BOOL);
        ((ppropvar)->Anonymous.Anonymous.Anonymous.boolVal) =
            (fVal) != 0 ? ((short)(-1)) : ((short)(0));
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromBoolean"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitPropVariantFromBoolean(
        MaybeBool<BOOL> fVal,
        Ref<PROPVARIANT> ppropvar
    )
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        {
            return (HRESULT)InitPropVariantFromBoolean((BOOL)fVal, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromDouble"]/*'/>
    public static HRESULT InitPropVariantFromDouble(double dblVal, PROPVARIANT* ppropvar)
    {
        ((ppropvar)->Anonymous.Anonymous.vt) = (ushort)(VT_R8);
        ((ppropvar)->Anonymous.Anonymous.Anonymous.dblVal) = dblVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromDouble"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitPropVariantFromDouble(double dblVal, Ref<PROPVARIANT> ppropvar)
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        {
            return (HRESULT)InitPropVariantFromDouble(dblVal, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromGUIDAsBuffer"]/*'/>
    public static HRESULT InitPropVariantFromGUIDAsBuffer(
        [NativeTypeName("const GUID &")] Guid* guid,
        PROPVARIANT* ppropvar
    )
    {
        return InitPropVariantFromBuffer(guid, (uint)(sizeof(Guid)), ppropvar);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromGUIDAsBuffer"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitPropVariantFromGUIDAsBuffer(
        [NativeTypeName("const GUID &")] Ref<Guid> guid,
        Ref<PROPVARIANT> ppropvar
    )
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        fixed (Guid* __dsl_guid = guid)
        {
            return (HRESULT)InitPropVariantFromGUIDAsBuffer(__dsl_guid, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromInt16"]/*'/>
    public static HRESULT InitPropVariantFromInt16(short nVal, PROPVARIANT* ppropvar)
    {
        ((ppropvar)->Anonymous.Anonymous.vt) = (ushort)(VT_I2);
        ((ppropvar)->Anonymous.Anonymous.Anonymous.iVal) = nVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromInt16"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitPropVariantFromInt16(short nVal, Ref<PROPVARIANT> ppropvar)
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        {
            return (HRESULT)InitPropVariantFromInt16(nVal, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromInt32"]/*'/>
    public static HRESULT InitPropVariantFromInt32(
        [NativeTypeName("LONG")] int lVal,
        PROPVARIANT* ppropvar
    )
    {
        ((ppropvar)->Anonymous.Anonymous.vt) = (ushort)(VT_I4);
        ((ppropvar)->Anonymous.Anonymous.Anonymous.lVal) = lVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromInt32"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitPropVariantFromInt32(
        [NativeTypeName("LONG")] int lVal,
        Ref<PROPVARIANT> ppropvar
    )
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        {
            return (HRESULT)InitPropVariantFromInt32(lVal, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromInt64"]/*'/>
    public static HRESULT InitPropVariantFromInt64(
        [NativeTypeName("LONGLONG")] long llVal,
        PROPVARIANT* ppropvar
    )
    {
        ((ppropvar)->Anonymous.Anonymous.vt) = (ushort)(VT_I8);
        ((ppropvar)->Anonymous.Anonymous.Anonymous.hVal).QuadPart = llVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromInt64"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitPropVariantFromInt64(
        [NativeTypeName("LONGLONG")] long llVal,
        Ref<PROPVARIANT> ppropvar
    )
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        {
            return (HRESULT)InitPropVariantFromInt64(llVal, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromString"]/*'/>

    public static HRESULT InitPropVariantFromString(
        [NativeTypeName("PCWSTR")] char* psz,
        PROPVARIANT* ppropvar
    )
    {
        HRESULT hr = psz != null ? S_OK : E_INVALIDARG;
        if (SUCCEEDED(hr))
        {
            nuint byteCount = (nuint)(
                (MemoryMarshal.CreateReadOnlySpanFromNullTerminated(psz).Length + 1) * 2
            );
            ((ppropvar)->Anonymous.Anonymous.Anonymous.pwszVal) = (ushort*)(
                CoTaskMemAllocRaw(byteCount)
            );
            hr = ((ppropvar)->Anonymous.Anonymous.Anonymous.pwszVal) != null ? S_OK : E_OUTOFMEMORY;
            if (SUCCEEDED(hr))
            {
                NativeMemory.Copy(
                    psz,
                    ((ppropvar)->Anonymous.Anonymous.Anonymous.pwszVal),
                    unchecked(byteCount)
                );
                ((ppropvar)->Anonymous.Anonymous.vt) = (ushort)(VT_LPWSTR);
            }
        }
        if (FAILED(hr))
        {
            PropVariantInit(ppropvar);
        }
        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromString"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitPropVariantFromString(
        [NativeTypeName("PCWSTR")] Ref<char> psz,
        Ref<PROPVARIANT> ppropvar
    )
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        fixed (char* __dsl_psz = psz)
        {
            return (HRESULT)InitPropVariantFromString(__dsl_psz, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromUInt16"]/*'/>
    public static HRESULT InitPropVariantFromUInt16(ushort uiVal, PROPVARIANT* ppropvar)
    {
        ((ppropvar)->Anonymous.Anonymous.vt) = (ushort)(VT_UI2);
        ((ppropvar)->Anonymous.Anonymous.Anonymous.uiVal) = uiVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromUInt16"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitPropVariantFromUInt16(ushort uiVal, Ref<PROPVARIANT> ppropvar)
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        {
            return (HRESULT)InitPropVariantFromUInt16(uiVal, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromUInt32"]/*'/>
    public static HRESULT InitPropVariantFromUInt32(
        [NativeTypeName("ULONG")] uint ulVal,
        PROPVARIANT* ppropvar
    )
    {
        ((ppropvar)->Anonymous.Anonymous.vt) = (ushort)(VT_UI4);
        ((ppropvar)->Anonymous.Anonymous.Anonymous.ulVal) = ulVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromUInt32"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitPropVariantFromUInt32(
        [NativeTypeName("ULONG")] uint ulVal,
        Ref<PROPVARIANT> ppropvar
    )
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        {
            return (HRESULT)InitPropVariantFromUInt32(ulVal, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromUInt64"]/*'/>
    public static HRESULT InitPropVariantFromUInt64(
        [NativeTypeName("ULONGLONG")] ulong ullVal,
        PROPVARIANT* ppropvar
    )
    {
        ((ppropvar)->Anonymous.Anonymous.vt) = (ushort)(VT_UI8);
        ((ppropvar)->Anonymous.Anonymous.Anonymous.uhVal).QuadPart = ullVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitPropVariantFromUInt64"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitPropVariantFromUInt64(
        [NativeTypeName("ULONGLONG")] ulong ullVal,
        Ref<PROPVARIANT> ppropvar
    )
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        {
            return (HRESULT)InitPropVariantFromUInt64(ullVal, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromBoolean"]/*'/>
    public static HRESULT InitVariantFromBoolean(BOOL fVal, VARIANT* pvar)
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_BOOL);
        ((pvar)->Anonymous.Anonymous.Anonymous.boolVal) =
            (fVal) != 0 ? ((short)(-1)) : ((short)(0));
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromBoolean"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromBoolean(MaybeBool<BOOL> fVal, Ref<VARIANT> pvar)
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        {
            return (HRESULT)InitVariantFromBoolean((BOOL)fVal, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromDispatch"]/*'/>
    public static HRESULT InitVariantFromDispatch(IDispatch pdisp, VARIANT* pvar)
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_DISPATCH);
        ((pvar)->Anonymous.Anonymous.Anonymous.pdispVal) = pdisp;
        if (((pvar)->Anonymous.Anonymous.Anonymous.pdispVal).lpVtbl != null)
        {
            _ = (((pvar)->Anonymous.Anonymous.Anonymous.pdispVal)).AddRef();
        }
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromDispatch"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromDispatch(IDispatch pdisp, Ref<VARIANT> pvar)
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        {
            return (HRESULT)InitVariantFromDispatch(pdisp, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromDosDateTime"]/*'/>
    public static HRESULT InitVariantFromDosDateTime(
        [NativeTypeName("WORD")] ushort wDate,
        [NativeTypeName("WORD")] ushort wTime,
        VARIANT* pvar
    )
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_DATE);
        return
            (DosDateTimeToVariantTime(wDate, wTime, &((pvar)->Anonymous.Anonymous.Anonymous.date)))
            != 0
            ? S_OK
            : ((HRESULT)(1));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromDosDateTime"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromDosDateTime(
        [NativeTypeName("WORD")] ushort wDate,
        [NativeTypeName("WORD")] ushort wTime,
        Ref<VARIANT> pvar
    )
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        {
            return (HRESULT)InitVariantFromDosDateTime(wDate, wTime, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromDouble"]/*'/>
    public static HRESULT InitVariantFromDouble(double dblVal, VARIANT* pvar)
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_R8);
        ((pvar)->Anonymous.Anonymous.Anonymous.dblVal) = dblVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromDouble"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromDouble(double dblVal, Ref<VARIANT> pvar)
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        {
            return (HRESULT)InitVariantFromDouble(dblVal, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromGUIDAsBuffer"]/*'/>
    public static HRESULT InitVariantFromGUIDAsBuffer(
        [NativeTypeName("const GUID &")] Guid* guid,
        VARIANT* pvar
    )
    {
        return InitVariantFromBuffer(guid, (uint)(sizeof(Guid)), pvar);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromGUIDAsBuffer"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromGUIDAsBuffer(
        [NativeTypeName("const GUID &")] Ref<Guid> guid,
        Ref<VARIANT> pvar
    )
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        fixed (Guid* __dsl_guid = guid)
        {
            return (HRESULT)InitVariantFromGUIDAsBuffer(__dsl_guid, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromInt16"]/*'/>
    public static HRESULT InitVariantFromInt16(short iVal, VARIANT* pvar)
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_I2);
        ((pvar)->Anonymous.Anonymous.Anonymous.iVal) = iVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromInt16"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromInt16(short iVal, Ref<VARIANT> pvar)
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        {
            return (HRESULT)InitVariantFromInt16(iVal, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromInt32"]/*'/>
    public static HRESULT InitVariantFromInt32([NativeTypeName("LONG")] int lVal, VARIANT* pvar)
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_I4);
        ((pvar)->Anonymous.Anonymous.Anonymous.lVal) = lVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromInt32"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromInt32([NativeTypeName("LONG")] int lVal, Ref<VARIANT> pvar)
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        {
            return (HRESULT)InitVariantFromInt32(lVal, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromInt64"]/*'/>
    public static HRESULT InitVariantFromInt64(
        [NativeTypeName("LONGLONG")] long llVal,
        VARIANT* pvar
    )
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_I8);
        ((pvar)->Anonymous.Anonymous.Anonymous.llVal) = llVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromInt64"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromInt64(
        [NativeTypeName("LONGLONG")] long llVal,
        Ref<VARIANT> pvar
    )
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        {
            return (HRESULT)InitVariantFromInt64(llVal, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromString"]/*'/>
    public static HRESULT InitVariantFromString([NativeTypeName("PCWSTR")] char* psz, VARIANT* pvar)
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_BSTR);
        ((pvar)->Anonymous.Anonymous.Anonymous.bstrVal) = SysAllocString(psz);
        HRESULT hr =
            ((pvar)->Anonymous.Anonymous.Anonymous.bstrVal) != null
                ? S_OK
                : ((psz) != null ? E_OUTOFMEMORY : E_INVALIDARG);
        if ((((HRESULT)(hr)) < 0))
        {
            VariantInit(pvar);
        }
        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromString"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromString(
        [NativeTypeName("PCWSTR")] Ref<char> psz,
        Ref<VARIANT> pvar
    )
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        fixed (char* __dsl_psz = psz)
        {
            return (HRESULT)InitVariantFromString(__dsl_psz, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUInt16"]/*'/>
    public static HRESULT InitVariantFromUInt16(ushort uiVal, VARIANT* pvar)
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_UI2);
        ((pvar)->Anonymous.Anonymous.Anonymous.uiVal) = uiVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUInt16"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromUInt16(ushort uiVal, Ref<VARIANT> pvar)
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        {
            return (HRESULT)InitVariantFromUInt16(uiVal, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUInt32"]/*'/>
    public static HRESULT InitVariantFromUInt32([NativeTypeName("ULONG")] uint ulVal, VARIANT* pvar)
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_UI4);
        ((pvar)->Anonymous.Anonymous.Anonymous.ulVal) = ulVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUInt32"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromUInt32(
        [NativeTypeName("ULONG")] uint ulVal,
        Ref<VARIANT> pvar
    )
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        {
            return (HRESULT)InitVariantFromUInt32(ulVal, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUInt64"]/*'/>
    public static HRESULT InitVariantFromUInt64(
        [NativeTypeName("ULONGLONG")] ulong ullVal,
        VARIANT* pvar
    )
    {
        ((pvar)->Anonymous.Anonymous.vt) = (ushort)(VT_UI8);
        ((pvar)->Anonymous.Anonymous.Anonymous.ullVal) = ullVal;
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUInt64"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromUInt64(
        [NativeTypeName("ULONGLONG")] ulong ullVal,
        Ref<VARIANT> pvar
    )
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        {
            return (HRESULT)InitVariantFromUInt64(ullVal, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUnknown"]/*'/>
    public static HRESULT InitVariantFromUnknown(IUnknown unknown, VARIANT* variant)
    {
        VariantInit(variant);
        ((variant)->Anonymous.Anonymous.vt) = (ushort)(VT_UNKNOWN);
        ((variant)->Anonymous.Anonymous.Anonymous.punkVal) = unknown;
        if (((variant)->Anonymous.Anonymous.Anonymous.punkVal).lpVtbl != null)
        {
            _ = ((variant)->Anonymous.Anonymous.Anonymous.punkVal).AddRef();
        }
        return S_OK;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitVariantFromUnknown"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT InitVariantFromUnknown(IUnknown unknown, Ref<VARIANT> variant)
    {
        fixed (VARIANT* __dsl_variant = variant)
        {
            return (HRESULT)InitVariantFromUnknown(unknown, __dsl_variant);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsPropVariantString"]/*'/>
    public static BOOL IsPropVariantString(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar
    )
    {
        return (PropVariantToStringWithDefault(propvar, null) != null) ? 1 : 0;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsPropVariantString"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> IsPropVariantString(
        [NativeTypeName("const PROPVARIANT &")] Ref<PROPVARIANT> propvar
    )
    {
        fixed (PROPVARIANT* __dsl_propvar = propvar)
        {
            return (MaybeBool<BOOL>)(BOOL)IsPropVariantString(__dsl_propvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsPropVariantVector"]/*'/>
    public static BOOL IsPropVariantVector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar
    )
    {
        return (propvar->Anonymous.Anonymous.vt & ((int)(VT_ARRAY) | (int)(VT_VECTOR)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsPropVariantVector"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> IsPropVariantVector(
        [NativeTypeName("const PROPVARIANT &")] Ref<PROPVARIANT> propvar
    )
    {
        fixed (PROPVARIANT* __dsl_propvar = propvar)
        {
            return (MaybeBool<BOOL>)(BOOL)IsPropVariantVector(__dsl_propvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVariantArray"]/*'/>
    public static BOOL IsVariantArray([NativeTypeName("const VARIANT &")] VARIANT* var)
    {
        return (var->Anonymous.Anonymous.vt & (int)(VT_ARRAY));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVariantArray"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> IsVariantArray(
        [NativeTypeName("const VARIANT &")] Ref<VARIANT> var
    )
    {
        fixed (VARIANT* __dsl_var = var)
        {
            return (MaybeBool<BOOL>)(BOOL)IsVariantArray(__dsl_var);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVariantString"]/*'/>
    public static BOOL IsVariantString([NativeTypeName("const VARIANT &")] VARIANT* var)
    {
        return (VariantToStringWithDefault(var, null) != null) ? 1 : 0;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVariantString"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<BOOL> IsVariantString(
        [NativeTypeName("const VARIANT &")] Ref<VARIANT> var
    )
    {
        fixed (VARIANT* __dsl_var = var)
        {
            return (MaybeBool<BOOL>)(BOOL)IsVariantString(__dsl_var);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVarTypeFloat"]/*'/>
    [Transformed]
    public static MaybeBool<BOOL> IsVarTypeFloat([NativeTypeName("VARTYPE")] ushort vt) =>
        (MaybeBool<BOOL>)(BOOL)IsVarTypeFloatRaw(vt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVarTypeFloat"]/*'/>
    public static BOOL IsVarTypeFloatRaw([NativeTypeName("VARTYPE")] ushort vt)
    {
        return (vt == (ushort)(VT_R4) || vt == (ushort)(VT_R8)) ? 1 : 0;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVarTypeInteger"]/*'/>
    [Transformed]
    public static MaybeBool<BOOL> IsVarTypeInteger([NativeTypeName("VARTYPE")] ushort vt) =>
        (MaybeBool<BOOL>)(BOOL)IsVarTypeIntegerRaw(vt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVarTypeInteger"]/*'/>
    public static BOOL IsVarTypeIntegerRaw([NativeTypeName("VARTYPE")] ushort vt)
    {
        return ((IsVarTypeSignedIntegerRaw(vt)) != 0 || (IsVarTypeUnsignedIntegerRaw(vt)) != 0)
            ? 1
            : 0;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVarTypeNumber"]/*'/>
    [Transformed]
    public static MaybeBool<BOOL> IsVarTypeNumber([NativeTypeName("VARTYPE")] ushort vt) =>
        (MaybeBool<BOOL>)(BOOL)IsVarTypeNumberRaw(vt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVarTypeNumber"]/*'/>
    public static BOOL IsVarTypeNumberRaw([NativeTypeName("VARTYPE")] ushort vt)
    {
        return ((IsVarTypeIntegerRaw(vt)) != 0 || (IsVarTypeFloatRaw(vt)) != 0) ? 1 : 0;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVarTypeSignedInteger"]/*'/>
    [Transformed]
    public static MaybeBool<BOOL> IsVarTypeSignedInteger([NativeTypeName("VARTYPE")] ushort vt) =>
        (MaybeBool<BOOL>)(BOOL)IsVarTypeSignedIntegerRaw(vt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVarTypeSignedInteger"]/*'/>
    public static BOOL IsVarTypeSignedIntegerRaw([NativeTypeName("VARTYPE")] ushort vt)
    {
        BOOL fRet = 0;
        switch (vt)
        {
            case (int)(VT_I1):
            case (int)(VT_I2):
            case (int)(VT_I4):
            case (int)(VT_I8):
            {
                fRet = 1;
                break;
            }
        }
        return fRet;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVarTypeUnsignedInteger"]/*'/>
    [Transformed]
    public static MaybeBool<BOOL> IsVarTypeUnsignedInteger([NativeTypeName("VARTYPE")] ushort vt) =>
        (MaybeBool<BOOL>)(BOOL)IsVarTypeUnsignedIntegerRaw(vt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsVarTypeUnsignedInteger"]/*'/>
    public static BOOL IsVarTypeUnsignedIntegerRaw([NativeTypeName("VARTYPE")] ushort vt)
    {
        BOOL fRet = 0;
        switch (vt)
        {
            case (int)(VT_UI1):
            case (int)(VT_UI2):
            case (int)(VT_UI4):
            case (int)(VT_UI8):
            {
                fRet = 1;
                break;
            }
        }
        return fRet;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantCompare"]/*'/>
    public static int PropVariantCompare(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2
    )
    {
        return PropVariantCompareEx(propvar1, propvar2, PVCU_DEFAULT, (int)(PVCF_DEFAULT));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantCompare"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int PropVariantCompare(
        [NativeTypeName("const PROPVARIANT &")] Ref<PROPVARIANT> propvar1,
        [NativeTypeName("const PROPVARIANT &")] Ref<PROPVARIANT> propvar2
    )
    {
        fixed (PROPVARIANT* __dsl_propvar2 = propvar2)
        fixed (PROPVARIANT* __dsl_propvar1 = propvar1)
        {
            return (int)PropVariantCompare(__dsl_propvar1, __dsl_propvar2);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetElem"]/*'/>
    public static HRESULT PropVariantGetElem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        [NativeTypeName("ULONG")] uint iElem,
        PROPVARIANT* ppropvar
    )
    {
        return InitPropVariantFromPropVariantVectorElem(propvarIn, iElem, ppropvar);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantGetElem"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT PropVariantGetElem(
        [NativeTypeName("const PROPVARIANT &")] Ref<PROPVARIANT> propvarIn,
        [NativeTypeName("ULONG")] uint iElem,
        Ref<PROPVARIANT> ppropvar
    )
    {
        fixed (PROPVARIANT* __dsl_ppropvar = ppropvar)
        fixed (PROPVARIANT* __dsl_propvarIn = propvarIn)
        {
            return (HRESULT)PropVariantGetElem(__dsl_propvarIn, iElem, __dsl_ppropvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToCLSID"]/*'/>
    public static HRESULT PropVariantToCLSID(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("CLSID *")] Guid* pclsid
    )
    {
        return PropVariantToGUID(propvar, unchecked((Guid*)(pclsid)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToCLSID"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT PropVariantToCLSID(
        [NativeTypeName("const PROPVARIANT &")] Ref<PROPVARIANT> propvar,
        [NativeTypeName("CLSID *")] Ref<Guid> pclsid
    )
    {
        fixed (Guid* __dsl_pclsid = pclsid)
        fixed (PROPVARIANT* __dsl_propvar = propvar)
        {
            return (HRESULT)PropVariantToCLSID(__dsl_propvar, __dsl_pclsid);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt32"]/*'/>
    public static HRESULT PropVariantToInt32(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        int* piRet
    )
    {
        return PropVariantToInt32(propvarIn, unchecked((int*)(piRet)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToInt32"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT PropVariantToInt32(
        [NativeTypeName("const PROPVARIANT &")] Ref<PROPVARIANT> propvarIn,
        Ref<int> piRet
    )
    {
        fixed (int* __dsl_piRet = piRet)
        fixed (PROPVARIANT* __dsl_propvarIn = propvarIn)
        {
            return (HRESULT)PropVariantToInt32(__dsl_propvarIn, __dsl_piRet);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt32"]/*'/>
    public static HRESULT PropVariantToUInt32(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        uint* piRet
    )
    {
        return PropVariantToUInt32(propvarIn, unchecked((uint*)(piRet)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToUInt32"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT PropVariantToUInt32(
        [NativeTypeName("const PROPVARIANT &")] Ref<PROPVARIANT> propvarIn,
        Ref<uint> piRet
    )
    {
        fixed (uint* __dsl_piRet = piRet)
        fixed (PROPVARIANT* __dsl_propvarIn = propvarIn)
        {
            return (HRESULT)PropVariantToUInt32(__dsl_propvarIn, __dsl_piRet);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetElem"]/*'/>
    public static HRESULT VariantGetElem(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("ULONG")] uint iElem,
        VARIANT* pvar
    )
    {
        return InitVariantFromVariantArrayElem(varIn, iElem, pvar);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantGetElem"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT VariantGetElem(
        [NativeTypeName("const VARIANT &")] Ref<VARIANT> varIn,
        [NativeTypeName("ULONG")] uint iElem,
        Ref<VARIANT> pvar
    )
    {
        fixed (VARIANT* __dsl_pvar = pvar)
        fixed (VARIANT* __dsl_varIn = varIn)
        {
            return (HRESULT)VariantGetElem(__dsl_varIn, iElem, __dsl_pvar);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt32"]/*'/>
    public static HRESULT VariantToInt32(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        int* piRet
    )
    {
        return VariantToInt32(varIn, unchecked((int*)(piRet)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToInt32"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT VariantToInt32(
        [NativeTypeName("const VARIANT &")] Ref<VARIANT> varIn,
        Ref<int> piRet
    )
    {
        fixed (int* __dsl_piRet = piRet)
        fixed (VARIANT* __dsl_varIn = varIn)
        {
            return (HRESULT)VariantToInt32(__dsl_varIn, __dsl_piRet);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt32"]/*'/>
    public static HRESULT VariantToUInt32(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        uint* piRet
    )
    {
        return VariantToUInt32(varIn, unchecked((uint*)(piRet)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VariantToUInt32"]/*'/>
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT VariantToUInt32(
        [NativeTypeName("const VARIANT &")] Ref<VARIANT> varIn,
        Ref<uint> piRet
    )
    {
        fixed (uint* __dsl_piRet = piRet)
        fixed (VARIANT* __dsl_varIn = varIn)
        {
            return (HRESULT)VariantToUInt32(__dsl_varIn, __dsl_piRet);
        }
    }
}
