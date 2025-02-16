// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.directx.direct3d11.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static unsafe partial class WinRT
{
    public static IInspectable CreateDirect3DDevice(IDXGISurface dxgiSurface)
    {
        IInspectable inspectableSurface;
        Marshal.ThrowExceptionForHR(
            CreateDirect3D11SurfaceFromDXGISurface(dxgiSurface, &inspectableSurface)
        );
        return inspectableSurface;
    }

    [SupportedOSPlatform("windows10.0.19043.0")]
    public static HRESULT GetDXGIInterface<DXGI_TYPE>(IInspectable @object, out DXGI_TYPE dxgi)
        where DXGI_TYPE : unmanaged, IComInterface
    {
        dxgi = default;
        return GetDXGIInterfaceFromObject(@object, __uuidof<DXGI_TYPE>(), dxgi.GetAddressOf());
    }

    [SupportedOSPlatform("windows10.0.19043.0")]
    public static HRESULT GetDXGIInterfaceFromObject(IInspectable @object, Guid* iid, void** p)
    {
        IDirect3DDxgiInterfaceAccess dxgiInterfaceAccess;
        HRESULT hr = @object.QueryInterface(
            __uuidof<IDirect3DDxgiInterfaceAccess.Native>(),
            (void**)&dxgiInterfaceAccess
        );
        if (SUCCEEDED(hr))
        {
            hr = dxgiInterfaceAccess.GetInterface(iid, p);
        }
        _ = dxgiInterfaceAccess.Release();
        return hr;
    }

    [SupportedOSPlatform("windows10.0.19043.0")]
    public static HRESULT GetDXGIInterfaceFromObject<TCom>(IInspectable @object, out TCom p)
        where TCom: unmanaged, IComInterface
    {
        p = default;
        IDirect3DDxgiInterfaceAccess dxgiInterfaceAccess;
        HRESULT hr = @object.QueryInterface(
            __uuidof<IDirect3DDxgiInterfaceAccess.Native>(),
            (void**)&dxgiInterfaceAccess
        );
        if (SUCCEEDED(hr))
        {
            hr = dxgiInterfaceAccess.GetInterface(TCom.NativeGuid, p.GetAddressOf());
        }
        _ = dxgiInterfaceAccess.Release();
        return hr;
    }

    [SupportedOSPlatform("windows10.0.19043.0")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT GetDXGIInterfaceFromObject(IInspectable @object, Ref<Guid> iid, Ref2D p)
    {
        fixed (void** __dsl_p = p)
        fixed (Guid* __dsl_iid = iid)
        {
            return (HRESULT)GetDXGIInterfaceFromObject(@object, __dsl_iid, __dsl_p);
        }
    }
}
