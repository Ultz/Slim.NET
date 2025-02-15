// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("80E8E04D-8C88-44AE-A011-7CADF6FB2E72")]
[NativeTypeName("struct IAppxEncryptionFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.14393.0")]
public unsafe partial struct IAppxEncryptionFactory : IAppxEncryptionFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxEncryptionFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxEncryptionFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EncryptPackage(
        IStream inputStream,
        IStream outputStream,
        [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")]
            APPX_ENCRYPTED_PACKAGE_SETTINGS* settings,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
        [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")]
            APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles
    )
    {
        return (
            (delegate* unmanaged<
                IAppxEncryptionFactory,
                IStream,
                IStream,
                APPX_ENCRYPTED_PACKAGE_SETTINGS*,
                APPX_KEY_INFO*,
                APPX_ENCRYPTED_EXEMPTIONS*,
                int>)((*lpVtbl)[3])
        )(this, inputStream, outputStream, settings, keyInfo, exemptedFiles);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DecryptPackage(
        IStream inputStream,
        IStream outputStream,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo
    )
    {
        return (
            (delegate* unmanaged<IAppxEncryptionFactory, IStream, IStream, APPX_KEY_INFO*, int>)(
                (*lpVtbl)[4]
            )
        )(this, inputStream, outputStream, keyInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateEncryptedPackageWriter(
        IStream outputStream,
        IStream manifestStream,
        [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")]
            APPX_ENCRYPTED_PACKAGE_SETTINGS* settings,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
        [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")]
            APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles,
        IAppxEncryptedPackageWriter* packageWriter
    )
    {
        return (
            (delegate* unmanaged<
                IAppxEncryptionFactory,
                IStream,
                IStream,
                APPX_ENCRYPTED_PACKAGE_SETTINGS*,
                APPX_KEY_INFO*,
                APPX_ENCRYPTED_EXEMPTIONS*,
                IAppxEncryptedPackageWriter*,
                int>)((*lpVtbl)[5])
        )(this, outputStream, manifestStream, settings, keyInfo, exemptedFiles, packageWriter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateEncryptedPackageReader(
        IStream inputStream,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
        IAppxPackageReader* packageReader
    )
    {
        return (
            (delegate* unmanaged<
                IAppxEncryptionFactory,
                IStream,
                APPX_KEY_INFO*,
                IAppxPackageReader*,
                int>)((*lpVtbl)[6])
        )(this, inputStream, keyInfo, packageReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EncryptBundle(
        IStream inputStream,
        IStream outputStream,
        [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")]
            APPX_ENCRYPTED_PACKAGE_SETTINGS* settings,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
        [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")]
            APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles
    )
    {
        return (
            (delegate* unmanaged<
                IAppxEncryptionFactory,
                IStream,
                IStream,
                APPX_ENCRYPTED_PACKAGE_SETTINGS*,
                APPX_KEY_INFO*,
                APPX_ENCRYPTED_EXEMPTIONS*,
                int>)((*lpVtbl)[7])
        )(this, inputStream, outputStream, settings, keyInfo, exemptedFiles);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DecryptBundle(
        IStream inputStream,
        IStream outputStream,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo
    )
    {
        return (
            (delegate* unmanaged<IAppxEncryptionFactory, IStream, IStream, APPX_KEY_INFO*, int>)(
                (*lpVtbl)[8]
            )
        )(this, inputStream, outputStream, keyInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateEncryptedBundleWriter(
        IStream outputStream,
        [NativeTypeName("UINT64")] ulong bundleVersion,
        [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")]
            APPX_ENCRYPTED_PACKAGE_SETTINGS* settings,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
        [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")]
            APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles,
        IAppxEncryptedBundleWriter* bundleWriter
    )
    {
        return (
            (delegate* unmanaged<
                IAppxEncryptionFactory,
                IStream,
                ulong,
                APPX_ENCRYPTED_PACKAGE_SETTINGS*,
                APPX_KEY_INFO*,
                APPX_ENCRYPTED_EXEMPTIONS*,
                IAppxEncryptedBundleWriter*,
                int>)((*lpVtbl)[9])
        )(this, outputStream, bundleVersion, settings, keyInfo, exemptedFiles, bundleWriter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateEncryptedBundleReader(
        IStream inputStream,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
        IAppxBundleReader* bundleReader
    )
    {
        return (
            (delegate* unmanaged<
                IAppxEncryptionFactory,
                IStream,
                APPX_KEY_INFO*,
                IAppxBundleReader*,
                int>)((*lpVtbl)[10])
        )(this, inputStream, keyInfo, bundleReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EncryptPackage(
            IStream inputStream,
            IStream outputStream,
            [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")]
                APPX_ENCRYPTED_PACKAGE_SETTINGS* settings,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
            [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")]
                APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles
        );

        [VtblIndex(4)]
        HRESULT DecryptPackage(
            IStream inputStream,
            IStream outputStream,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo
        );

        [VtblIndex(5)]
        HRESULT CreateEncryptedPackageWriter(
            IStream outputStream,
            IStream manifestStream,
            [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")]
                APPX_ENCRYPTED_PACKAGE_SETTINGS* settings,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
            [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")]
                APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles,
            IAppxEncryptedPackageWriter* packageWriter
        );

        [VtblIndex(6)]
        HRESULT CreateEncryptedPackageReader(
            IStream inputStream,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
            IAppxPackageReader* packageReader
        );

        [VtblIndex(7)]
        HRESULT EncryptBundle(
            IStream inputStream,
            IStream outputStream,
            [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")]
                APPX_ENCRYPTED_PACKAGE_SETTINGS* settings,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
            [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")]
                APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles
        );

        [VtblIndex(8)]
        HRESULT DecryptBundle(
            IStream inputStream,
            IStream outputStream,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo
        );

        [VtblIndex(9)]
        HRESULT CreateEncryptedBundleWriter(
            IStream outputStream,
            [NativeTypeName("UINT64")] ulong bundleVersion,
            [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")]
                APPX_ENCRYPTED_PACKAGE_SETTINGS* settings,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
            [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")]
                APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles,
            IAppxEncryptedBundleWriter* bundleWriter
        );

        [VtblIndex(10)]
        HRESULT CreateEncryptedBundleReader(
            IStream inputStream,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
            IAppxBundleReader* bundleReader
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

        [NativeTypeName(
            "HRESULT (IStream *, IStream *, const APPX_ENCRYPTED_PACKAGE_SETTINGS *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IStream,
            APPX_ENCRYPTED_PACKAGE_SETTINGS*,
            APPX_KEY_INFO*,
            APPX_ENCRYPTED_EXEMPTIONS*,
            int> EncryptPackage;

        [NativeTypeName(
            "HRESULT (IStream *, IStream *, const APPX_KEY_INFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStream, IStream, APPX_KEY_INFO*, int> DecryptPackage;

        [NativeTypeName(
            "HRESULT (IStream *, IStream *, const APPX_ENCRYPTED_PACKAGE_SETTINGS *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *, IAppxEncryptedPackageWriter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IStream,
            APPX_ENCRYPTED_PACKAGE_SETTINGS*,
            APPX_KEY_INFO*,
            APPX_ENCRYPTED_EXEMPTIONS*,
            IAppxEncryptedPackageWriter*,
            int> CreateEncryptedPackageWriter;

        [NativeTypeName(
            "HRESULT (IStream *, const APPX_KEY_INFO *, IAppxPackageReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            APPX_KEY_INFO*,
            IAppxPackageReader*,
            int> CreateEncryptedPackageReader;

        [NativeTypeName(
            "HRESULT (IStream *, IStream *, const APPX_ENCRYPTED_PACKAGE_SETTINGS *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IStream,
            APPX_ENCRYPTED_PACKAGE_SETTINGS*,
            APPX_KEY_INFO*,
            APPX_ENCRYPTED_EXEMPTIONS*,
            int> EncryptBundle;

        [NativeTypeName(
            "HRESULT (IStream *, IStream *, const APPX_KEY_INFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStream, IStream, APPX_KEY_INFO*, int> DecryptBundle;

        [NativeTypeName(
            "HRESULT (IStream *, UINT64, const APPX_ENCRYPTED_PACKAGE_SETTINGS *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *, IAppxEncryptedBundleWriter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            ulong,
            APPX_ENCRYPTED_PACKAGE_SETTINGS*,
            APPX_KEY_INFO*,
            APPX_ENCRYPTED_EXEMPTIONS*,
            IAppxEncryptedBundleWriter*,
            int> CreateEncryptedBundleWriter;

        [NativeTypeName(
            "HRESULT (IStream *, const APPX_KEY_INFO *, IAppxBundleReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            APPX_KEY_INFO*,
            IAppxBundleReader*,
            int> CreateEncryptedBundleReader;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxEncryptionFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxEncryptionFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxEncryptionFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxEncryptionFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxEncryptionFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxEncryptionFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxEncryptionFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxEncryptionFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
