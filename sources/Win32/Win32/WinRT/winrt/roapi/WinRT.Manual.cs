// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Silk.NET.Win32;
using static Silk.NET.Win32.IID;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static unsafe partial class WinRT
{
    [SupportedOSPlatform("windows6.2")]
    public static HRESULT ActivateInstance<T>(HSTRING activatableClassId, T* instance)
        where T : unmanaged, IComInterface
    {
        IInspectable pInspectable;
        HRESULT hr = RoActivateInstance(activatableClassId, &pInspectable);
        if (SUCCEEDED(hr))
        {
            if (__uuidof<T>() == IID_IInspectable)
            {
                void** address = instance->GetAddressOf();
                *address = pInspectable.lpVtbl;
            }
            else
            {
                hr = pInspectable.QueryInterface(__uuidof<T>(), instance->GetAddressOf());
                _ = pInspectable.Release();
            }
        }
        return hr;
    }

    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT ActivateInstance<T>(HSTRING activatableClassId, out T instance)
        where T : unmanaged, IComInterface
    {
        instance = default;
        return ActivateInstance(activatableClassId, (T*)instance.GetAddressOf());
    }

    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT ActivateInstance<T>(HSTRING activatableClassId, Ref<T> instance)
        where T : unmanaged, IComInterface
    {
        fixed (T* __dsl_instance = instance)
        {
            return (HRESULT)ActivateInstance(activatableClassId, __dsl_instance);
        }
    }

    [SupportedOSPlatform("windows6.2")]
    public static HRESULT GetActivationFactory<T>(HSTRING activatableClassId, T* factory)
        where T : unmanaged, IComInterface
    {
        return RoGetActivationFactory(activatableClassId, __uuidof<T>(), (void**)factory);
    }

    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT GetActivationFactory<T>(HSTRING activatableClassId, Ref<T> factory)
        where T : unmanaged, IComInterface
    {
        fixed (T* __dsl_factory = factory)
        {
            return (HRESULT)GetActivationFactory(activatableClassId, __dsl_factory);
        }
    }

    [SupportedOSPlatform("windows6.2")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT GetActivationFactory<T>(HSTRING activatableClassId, out T factory)
        where T : unmanaged, IComInterface
    {
        factory = default;
        return GetActivationFactory(activatableClassId, (T*)factory.GetAddressOf());
    }
}
