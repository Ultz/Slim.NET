// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7F9185B0-CB92-43C5-80A9-92277A4F7B54")]
[NativeTypeName("struct IExecuteCommand : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExecuteCommand : IExecuteCommand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExecuteCommand));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExecuteCommand, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IExecuteCommand, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExecuteCommand, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetKeyState([NativeTypeName("DWORD")] uint grfKeyState)
    {
        return ((delegate* unmanaged<IExecuteCommand, uint, int>)((*lpVtbl)[3]))(this, grfKeyState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetParameters([NativeTypeName("LPCWSTR")] ushort* pszParameters)
    {
        return ((delegate* unmanaged<IExecuteCommand, ushort*, int>)((*lpVtbl)[4]))(
            this,
            pszParameters
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPosition(POINT pt)
    {
        return ((delegate* unmanaged<IExecuteCommand, POINT, int>)((*lpVtbl)[5]))(this, pt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetShowWindow(int nShow)
    {
        return ((delegate* unmanaged<IExecuteCommand, int, int>)((*lpVtbl)[6]))(this, nShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetNoShowUI(BOOL fNoShowUI)
    {
        return ((delegate* unmanaged<IExecuteCommand, BOOL, int>)((*lpVtbl)[7]))(this, fNoShowUI);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDirectory([NativeTypeName("LPCWSTR")] ushort* pszDirectory)
    {
        return ((delegate* unmanaged<IExecuteCommand, ushort*, int>)((*lpVtbl)[8]))(
            this,
            pszDirectory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Execute()
    {
        return ((delegate* unmanaged<IExecuteCommand, int>)((*lpVtbl)[9]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetKeyState([NativeTypeName("DWORD")] uint grfKeyState);

        [VtblIndex(4)]
        HRESULT SetParameters([NativeTypeName("LPCWSTR")] ushort* pszParameters);

        [VtblIndex(5)]
        HRESULT SetPosition(POINT pt);

        [VtblIndex(6)]
        HRESULT SetShowWindow(int nShow);

        [VtblIndex(7)]
        HRESULT SetNoShowUI(BOOL fNoShowUI);

        [VtblIndex(8)]
        HRESULT SetDirectory([NativeTypeName("LPCWSTR")] ushort* pszDirectory);

        [VtblIndex(9)]
        HRESULT Execute();
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetKeyState;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetParameters;

        [NativeTypeName("HRESULT (POINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, int> SetPosition;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetShowWindow;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetNoShowUI;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDirectory;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Execute;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExecuteCommand"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExecuteCommand(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExecuteCommand"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExecuteCommand(Silk.NET.Windows.IUnknown value)
    {
        return new IExecuteCommand(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExecuteCommand"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExecuteCommand"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IExecuteCommand value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
