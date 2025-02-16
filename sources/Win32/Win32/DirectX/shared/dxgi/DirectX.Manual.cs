// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static HRESULT D3D_SET_OBJECT_NAME_A<TDXGIObject>(TDXGIObject* pObject, sbyte* pName)
        where TDXGIObject : unmanaged, IDXGIObject.Native.Interface
    {
        return D3D_SET_OBJECT_NAME_N_A(pObject, (uint)lstrlenA(pName), pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3D_SET_OBJECT_NAME_A<TDXGIObject>(
        Ref<TDXGIObject> pObject,
        Ref<sbyte> pName
    )
        where TDXGIObject : unmanaged, IDXGIObject.Native.Interface
    {
        fixed (sbyte* __dsl_pName = pName)
        fixed (TDXGIObject* __dsl_pObject = pObject)
        {
            return (HRESULT)D3D_SET_OBJECT_NAME_A(__dsl_pObject, __dsl_pName);
        }
    }

    public static HRESULT D3D_SET_OBJECT_NAME_N_A<TDXGIObject>(
        TDXGIObject* pObject,
        uint Chars,
        sbyte* pName
    )
        where TDXGIObject : unmanaged, IDXGIObject.Native.Interface
    {
        var guid = WKPDID_D3DDebugObjectName;
        return pObject->SetPrivateData(&guid, Chars, pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3D_SET_OBJECT_NAME_N_A<TDXGIObject>(
        Ref<TDXGIObject> pObject,
        uint Chars,
        Ref<sbyte> pName
    )
        where TDXGIObject : unmanaged, IDXGIObject.Native.Interface
    {
        fixed (sbyte* __dsl_pName = pName)
        fixed (TDXGIObject* __dsl_pObject = pObject)
        {
            return (HRESULT)D3D_SET_OBJECT_NAME_N_A(__dsl_pObject, Chars, __dsl_pName);
        }
    }

    public static HRESULT D3D_SET_OBJECT_NAME_N_W<TDXGIObject>(
        TDXGIObject* pObject,
        uint Chars,
        char* pName
    )
        where TDXGIObject : unmanaged, IDXGIObject.Native.Interface
    {
        var guid = WKPDID_D3DDebugObjectNameW;
        return pObject->SetPrivateData(&guid, Chars * 2, pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3D_SET_OBJECT_NAME_N_W<TDXGIObject>(
        Ref<TDXGIObject> pObject,
        uint Chars,
        Ref<char> pName
    )
        where TDXGIObject : unmanaged, IDXGIObject.Native.Interface
    {
        fixed (char* __dsl_pName = pName)
        fixed (TDXGIObject* __dsl_pObject = pObject)
        {
            return (HRESULT)D3D_SET_OBJECT_NAME_N_W(__dsl_pObject, Chars, __dsl_pName);
        }
    }

    public static HRESULT D3D_SET_OBJECT_NAME_W<TDXGIObject>(TDXGIObject* pObject, char* pName)
        where TDXGIObject : unmanaged, IDXGIObject.Native.Interface
    {
        return D3D_SET_OBJECT_NAME_N_W(pObject, (uint)lstrlenW(pName), pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT D3D_SET_OBJECT_NAME_W<TDXGIObject>(
        Ref<TDXGIObject> pObject,
        Ref<char> pName
    )
        where TDXGIObject : unmanaged, IDXGIObject.Native.Interface
    {
        fixed (char* __dsl_pName = pName)
        fixed (TDXGIObject* __dsl_pObject = pObject)
        {
            return (HRESULT)D3D_SET_OBJECT_NAME_W(__dsl_pObject, __dsl_pName);
        }
    }
}
