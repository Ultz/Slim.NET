// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1F02B6C5-7842-4EE6-8A0B-9A24183A95CA")]
[NativeTypeName("struct ITfInputProcessorProfiles : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfInputProcessorProfiles
    : ITfInputProcessorProfiles.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInputProcessorProfiles));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfiles, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfInputProcessorProfiles, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfInputProcessorProfiles, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Register([NativeTypeName("const IID &")] Guid* rclsid)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfiles, Guid*, int>)((*lpVtbl)[3]))(
            this,
            rclsid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unregister([NativeTypeName("const IID &")] Guid* rclsid)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfiles, Guid*, int>)((*lpVtbl)[4]))(
            this,
            rclsid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddLanguageProfile(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* guidProfile,
        [NativeTypeName("const WCHAR *")] ushort* pchDesc,
        [NativeTypeName("ULONG")] uint cchDesc,
        [NativeTypeName("const WCHAR *")] ushort* pchIconFile,
        [NativeTypeName("ULONG")] uint cchFile,
        [NativeTypeName("ULONG")] uint uIconIndex
    )
    {
        return (
            (delegate* unmanaged<
                ITfInputProcessorProfiles,
                Guid*,
                ushort,
                Guid*,
                ushort*,
                uint,
                ushort*,
                uint,
                uint,
                int>)((*lpVtbl)[5])
        )(this, rclsid, langid, guidProfile, pchDesc, cchDesc, pchIconFile, cchFile, uIconIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveLanguageProfile(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* guidProfile
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, Guid*, ushort, Guid*, int>)(
                (*lpVtbl)[6]
            )
        )(this, rclsid, langid, guidProfile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumInputProcessorInfo(IEnumGUID* ppEnum)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfiles, IEnumGUID*, int>)((*lpVtbl)[7]))(
            this,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDefaultLanguageProfile(
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* catid,
        [NativeTypeName("CLSID *")] Guid* pclsid,
        Guid* pguidProfile
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, ushort, Guid*, Guid*, Guid*, int>)(
                (*lpVtbl)[8]
            )
        )(this, langid, catid, pclsid, pguidProfile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetDefaultLanguageProfile(
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("const GUID &")] Guid* guidProfiles
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, ushort, Guid*, Guid*, int>)(
                (*lpVtbl)[9]
            )
        )(this, langid, rclsid, guidProfiles);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateLanguageProfile(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* guidProfiles
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, Guid*, ushort, Guid*, int>)(
                (*lpVtbl)[10]
            )
        )(this, rclsid, langid, guidProfiles);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetActiveLanguageProfile(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LANGID *")] ushort* plangid,
        Guid* pguidProfile
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, Guid*, ushort*, Guid*, int>)(
                (*lpVtbl)[11]
            )
        )(this, rclsid, plangid, pguidProfile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetLanguageProfileDescription(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* guidProfile,
        [NativeTypeName("BSTR *")] ushort** pbstrProfile
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, Guid*, ushort, Guid*, ushort**, int>)(
                (*lpVtbl)[12]
            )
        )(this, rclsid, langid, guidProfile, pbstrProfile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCurrentLanguage([NativeTypeName("LANGID *")] ushort* plangid)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfiles, ushort*, int>)((*lpVtbl)[13]))(
            this,
            plangid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ChangeCurrentLanguage([NativeTypeName("LANGID")] ushort langid)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfiles, ushort, int>)((*lpVtbl)[14]))(
            this,
            langid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetLanguageList(
        [NativeTypeName("LANGID **")] ushort** ppLangId,
        [NativeTypeName("ULONG *")] uint* pulCount
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, ushort**, uint*, int>)((*lpVtbl)[15])
        )(this, ppLangId, pulCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnumLanguageProfiles(
        [NativeTypeName("LANGID")] ushort langid,
        IEnumTfLanguageProfiles* ppEnum
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, ushort, IEnumTfLanguageProfiles*, int>)(
                (*lpVtbl)[16]
            )
        )(this, langid, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT EnableLanguageProfile(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* guidProfile,
        BOOL fEnable
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, Guid*, ushort, Guid*, BOOL, int>)(
                (*lpVtbl)[17]
            )
        )(this, rclsid, langid, guidProfile, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT IsEnabledLanguageProfile(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* guidProfile,
        BOOL* pfEnable
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, Guid*, ushort, Guid*, BOOL*, int>)(
                (*lpVtbl)[18]
            )
        )(this, rclsid, langid, guidProfile, pfEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT EnableLanguageProfileByDefault(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* guidProfile,
        BOOL fEnable
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, Guid*, ushort, Guid*, BOOL, int>)(
                (*lpVtbl)[19]
            )
        )(this, rclsid, langid, guidProfile, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SubstituteKeyboardLayout(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* guidProfile,
        HKL hKL
    )
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfiles, Guid*, ushort, Guid*, HKL, int>)(
                (*lpVtbl)[20]
            )
        )(this, rclsid, langid, guidProfile, hKL);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Register([NativeTypeName("const IID &")] Guid* rclsid);

        [VtblIndex(4)]
        HRESULT Unregister([NativeTypeName("const IID &")] Guid* rclsid);

        [VtblIndex(5)]
        HRESULT AddLanguageProfile(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* guidProfile,
            [NativeTypeName("const WCHAR *")] ushort* pchDesc,
            [NativeTypeName("ULONG")] uint cchDesc,
            [NativeTypeName("const WCHAR *")] ushort* pchIconFile,
            [NativeTypeName("ULONG")] uint cchFile,
            [NativeTypeName("ULONG")] uint uIconIndex
        );

        [VtblIndex(6)]
        HRESULT RemoveLanguageProfile(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* guidProfile
        );

        [VtblIndex(7)]
        HRESULT EnumInputProcessorInfo(IEnumGUID* ppEnum);

        [VtblIndex(8)]
        HRESULT GetDefaultLanguageProfile(
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* catid,
            [NativeTypeName("CLSID *")] Guid* pclsid,
            Guid* pguidProfile
        );

        [VtblIndex(9)]
        HRESULT SetDefaultLanguageProfile(
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("const GUID &")] Guid* guidProfiles
        );

        [VtblIndex(10)]
        HRESULT ActivateLanguageProfile(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* guidProfiles
        );

        [VtblIndex(11)]
        HRESULT GetActiveLanguageProfile(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LANGID *")] ushort* plangid,
            Guid* pguidProfile
        );

        [VtblIndex(12)]
        HRESULT GetLanguageProfileDescription(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* guidProfile,
            [NativeTypeName("BSTR *")] ushort** pbstrProfile
        );

        [VtblIndex(13)]
        HRESULT GetCurrentLanguage([NativeTypeName("LANGID *")] ushort* plangid);

        [VtblIndex(14)]
        HRESULT ChangeCurrentLanguage([NativeTypeName("LANGID")] ushort langid);

        [VtblIndex(15)]
        HRESULT GetLanguageList(
            [NativeTypeName("LANGID **")] ushort** ppLangId,
            [NativeTypeName("ULONG *")] uint* pulCount
        );

        [VtblIndex(16)]
        HRESULT EnumLanguageProfiles(
            [NativeTypeName("LANGID")] ushort langid,
            IEnumTfLanguageProfiles* ppEnum
        );

        [VtblIndex(17)]
        HRESULT EnableLanguageProfile(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* guidProfile,
            BOOL fEnable
        );

        [VtblIndex(18)]
        HRESULT IsEnabledLanguageProfile(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* guidProfile,
            BOOL* pfEnable
        );

        [VtblIndex(19)]
        HRESULT EnableLanguageProfileByDefault(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* guidProfile,
            BOOL fEnable
        );

        [VtblIndex(20)]
        HRESULT SubstituteKeyboardLayout(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* guidProfile,
            HKL hKL
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

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> Register;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> Unregister;

        [NativeTypeName(
            "HRESULT (const IID &, LANGID, const GUID &, const WCHAR *, ULONG, const WCHAR *, ULONG, ULONG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort,
            Guid*,
            ushort*,
            uint,
            ushort*,
            uint,
            uint,
            int> AddLanguageProfile;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, int> RemoveLanguageProfile;

        [NativeTypeName("HRESULT (IEnumGUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumGUID*, int> EnumInputProcessorInfo;

        [NativeTypeName("HRESULT (LANGID, const GUID &, CLSID *, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort,
            Guid*,
            Guid*,
            Guid*,
            int> GetDefaultLanguageProfile;

        [NativeTypeName("HRESULT (LANGID, const IID &, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, Guid*, Guid*, int> SetDefaultLanguageProfile;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, int> ActivateLanguageProfile;

        [NativeTypeName("HRESULT (const IID &, LANGID *, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, Guid*, int> GetActiveLanguageProfile;

        [NativeTypeName(
            "HRESULT (const IID &, LANGID, const GUID &, BSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort,
            Guid*,
            ushort**,
            int> GetLanguageProfileDescription;

        [NativeTypeName("HRESULT (LANGID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetCurrentLanguage;

        [NativeTypeName("HRESULT (LANGID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> ChangeCurrentLanguage;

        [NativeTypeName("HRESULT (LANGID **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, int> GetLanguageList;

        [NativeTypeName("HRESULT (LANGID, IEnumTfLanguageProfiles **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort,
            IEnumTfLanguageProfiles*,
            int> EnumLanguageProfiles;

        [NativeTypeName(
            "HRESULT (const IID &, LANGID, const GUID &, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, BOOL, int> EnableLanguageProfile;

        [NativeTypeName(
            "HRESULT (const IID &, LANGID, const GUID &, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort,
            Guid*,
            BOOL*,
            int> IsEnabledLanguageProfile;

        [NativeTypeName(
            "HRESULT (const IID &, LANGID, const GUID &, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort,
            Guid*,
            BOOL,
            int> EnableLanguageProfileByDefault;

        [NativeTypeName(
            "HRESULT (const IID &, LANGID, const GUID &, HKL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, HKL, int> SubstituteKeyboardLayout;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfInputProcessorProfiles"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfInputProcessorProfiles(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfInputProcessorProfiles"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfInputProcessorProfiles(Silk.NET.Windows.IUnknown value)
    {
        return new ITfInputProcessorProfiles(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfInputProcessorProfiles"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfInputProcessorProfiles"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfInputProcessorProfiles value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
