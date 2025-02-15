// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("ABAD189D-9FA3-4278-B3CA-8CA448A88DCB")]
[NativeTypeName("struct IAppActivationUIInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppActivationUIInfo : IAppActivationUIInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppActivationUIInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppActivationUIInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppActivationUIInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppActivationUIInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMonitor(HMONITOR* value)
    {
        return ((delegate* unmanaged<IAppActivationUIInfo, HMONITOR*, int>)((*lpVtbl)[3]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetInvokePoint(POINT* value)
    {
        return ((delegate* unmanaged<IAppActivationUIInfo, POINT*, int>)((*lpVtbl)[4]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetShowCommand(int* value)
    {
        return ((delegate* unmanaged<IAppActivationUIInfo, int*, int>)((*lpVtbl)[5]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetShowUI(BOOL* value)
    {
        return ((delegate* unmanaged<IAppActivationUIInfo, BOOL*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetKeyState([NativeTypeName("DWORD *")] uint* value)
    {
        return ((delegate* unmanaged<IAppActivationUIInfo, uint*, int>)((*lpVtbl)[7]))(this, value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMonitor(HMONITOR* value);

        [VtblIndex(4)]
        HRESULT GetInvokePoint(POINT* value);

        [VtblIndex(5)]
        HRESULT GetShowCommand(int* value);

        [VtblIndex(6)]
        HRESULT GetShowUI(BOOL* value);

        [VtblIndex(7)]
        HRESULT GetKeyState([NativeTypeName("DWORD *")] uint* value);
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

        [NativeTypeName("HRESULT (HMONITOR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMONITOR*, int> GetMonitor;

        [NativeTypeName("HRESULT (POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, int> GetInvokePoint;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetShowCommand;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetShowUI;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetKeyState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppActivationUIInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppActivationUIInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppActivationUIInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppActivationUIInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IAppActivationUIInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppActivationUIInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppActivationUIInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppActivationUIInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
