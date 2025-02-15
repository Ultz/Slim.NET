// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocumentTarget.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C560298A-535C-48F9-866A-632540660CB4")]
[NativeTypeName("struct IPrintDocumentPackageTarget2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPrintDocumentPackageTarget2
    : IPrintDocumentPackageTarget2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDocumentPackageTarget2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintDocumentPackageTarget2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIsTargetIppPrinter(BOOL* isIppPrinter)
    {
        return ((delegate* unmanaged<IPrintDocumentPackageTarget2, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            isIppPrinter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTargetIppPrintDevice(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvTarget
    )
    {
        return (
            (delegate* unmanaged<IPrintDocumentPackageTarget2, Guid*, void**, int>)((*lpVtbl)[4])
        )(this, riid, ppvTarget);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIsTargetIppPrinter(BOOL* isIppPrinter);

        [VtblIndex(4)]
        HRESULT GetTargetIppPrintDevice(
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvTarget
        );
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetIsTargetIppPrinter;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetTargetIppPrintDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintDocumentPackageTarget2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintDocumentPackageTarget2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintDocumentPackageTarget2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintDocumentPackageTarget2(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintDocumentPackageTarget2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintDocumentPackageTarget2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintDocumentPackageTarget2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintDocumentPackageTarget2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
