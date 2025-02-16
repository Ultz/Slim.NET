// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using static Silk.NET.Win32.CLSCTX;
using static Silk.NET.Win32.SIGDN;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static void SetContractDelegateWindow(HWND hwndSource, HWND hwndDelegate)
    {
        fixed (char* lpString = "ContractDelegate")
        {
            if (hwndDelegate != (nint)(0))
            {
                _ = SetPropW(hwndSource, (ushort*)lpString, (HANDLE)(hwndDelegate));
            }
            else
            {
                _ = RemovePropW(hwndSource, (ushort*)lpString);
            }
        }
    }

    public static HRESULT SHAddFolderPathToLibrary(
        IShellLibrary plib,
        [NativeTypeName("PCWSTR")] ushort* pszFolderPath
    )
    {
        IShellItem psiFolder;
        HRESULT hr = SHCreateItemFromParsingName(
            pszFolderPath,
            null,
            __uuidof<IShellItem.Native>(),
            (void**)(&psiFolder)
        );
        if ((((int)(hr)) >= 0))
        {
            hr = plib.AddFolder(psiFolder);
            _ = psiFolder.Release();
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT SHAddFolderPathToLibrary(
        IShellLibrary plib,
        [NativeTypeName("PCWSTR")] Ref<ushort> pszFolderPath
    )
    {
        fixed (ushort* __dsl_pszFolderPath = pszFolderPath)
        {
            return (HRESULT)SHAddFolderPathToLibrary(plib, __dsl_pszFolderPath);
        }
    }

    public static HRESULT SHCreateLibrary([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return CoCreateInstance(
            __uuidof<ShellLibrary>(),
            default,
            (uint)(CLSCTX_INPROC_SERVER),
            riid,
            ppv
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT SHCreateLibrary([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppv)
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HRESULT)SHCreateLibrary(__dsl_riid, __dsl_ppv);
        }
    }

    public static HRESULT SHLoadLibraryFromItem(
        IShellItem psiLibrary,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        *ppv = null;
        IShellLibrary plib;
        var hr = CoCreateInstance(
            __uuidof<ShellLibrary>(),
            default,
            (uint)(CLSCTX_INPROC_SERVER),
            __uuidof<IShellLibrary.Native>(),
            (void**)(&plib)
        );
        if ((((int)(hr)) >= 0))
        {
            hr = plib.LoadLibraryFromItem(psiLibrary, grfMode);
            if ((((int)(hr)) >= 0))
            {
                hr = plib.QueryInterface(riid, ppv);
            }
            _ = plib.Release();
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT SHLoadLibraryFromItem(
        IShellItem psiLibrary,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppv
    )
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HRESULT)SHLoadLibraryFromItem(psiLibrary, grfMode, __dsl_riid, __dsl_ppv);
        }
    }

    public static HRESULT SHLoadLibraryFromKnownFolder(
        [NativeTypeName("const KNOWNFOLDERID &")] Guid* kfidLibrary,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        *ppv = null;
        IShellLibrary plib;
        var hr = CoCreateInstance(
            __uuidof<ShellLibrary>(),
            default,
            (uint)(CLSCTX_INPROC_SERVER),
            __uuidof<IShellLibrary.Native>(),
            (void**)(&plib)
        );
        if ((((int)(hr)) >= 0))
        {
            hr = plib.LoadLibraryFromKnownFolder(kfidLibrary, grfMode);
            if ((((int)(hr)) >= 0))
            {
                hr = plib.QueryInterface(riid, ppv);
            }
            _ = plib.Release();
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT SHLoadLibraryFromKnownFolder(
        [NativeTypeName("const KNOWNFOLDERID &")] Ref<Guid> kfidLibrary,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppv
    )
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        fixed (Guid* __dsl_kfidLibrary = kfidLibrary)
        {
            return (HRESULT)SHLoadLibraryFromKnownFolder(
                __dsl_kfidLibrary,
                grfMode,
                __dsl_riid,
                __dsl_ppv
            );
        }
    }

    public static HRESULT SHLoadLibraryFromParsingName(
        [NativeTypeName("PCWSTR")] ushort* pszParsingName,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        *ppv = null;
        IShellItem psiLibrary;
        HRESULT hr = SHCreateItemFromParsingName(
            pszParsingName,
            null,
            __uuidof<IShellItem.Native>(),
            (void**)(&psiLibrary)
        );
        if ((((int)(hr)) >= 0))
        {
            hr = SHLoadLibraryFromItem(psiLibrary, grfMode, riid, ppv);
            _ = psiLibrary.Release();
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT SHLoadLibraryFromParsingName(
        [NativeTypeName("PCWSTR")] Ref<ushort> pszParsingName,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppv
    )
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        fixed (ushort* __dsl_pszParsingName = pszParsingName)
        {
            return (HRESULT)SHLoadLibraryFromParsingName(
                __dsl_pszParsingName,
                grfMode,
                __dsl_riid,
                __dsl_ppv
            );
        }
    }

    public static HRESULT SHRemoveFolderPathFromLibrary(
        IShellLibrary plib,
        [NativeTypeName("PCWSTR")] ushort* pszFolderPath
    )
    {
        ITEMIDLIST* pidlFolder = SHSimpleIDListFromPath(pszFolderPath);
        HRESULT hr = unchecked((pidlFolder) != null ? ((int)(0)) : ((int)(0x80070057)));
        if (((unchecked((int)(hr))) >= 0))
        {
            IShellItem psiFolder;
            unchecked(hr) = SHCreateItemFromIDList(
                pidlFolder,
                __uuidof<IShellItem.Native>(),
                (void**)(&psiFolder)
            );
            if (((unchecked((int)(hr))) >= 0))
            {
                unchecked(hr) = plib.RemoveFolder(psiFolder);
                _ = psiFolder.Release();
            }
            CoTaskMemFree(pidlFolder);
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT SHRemoveFolderPathFromLibrary(
        IShellLibrary plib,
        [NativeTypeName("PCWSTR")] Ref<ushort> pszFolderPath
    )
    {
        fixed (ushort* __dsl_pszFolderPath = pszFolderPath)
        {
            return (HRESULT)SHRemoveFolderPathFromLibrary(plib, __dsl_pszFolderPath);
        }
    }

    public static HRESULT SHSaveLibraryInFolderPath(
        IShellLibrary plib,
        [NativeTypeName("PCWSTR")] ushort* pszFolderPath,
        [NativeTypeName("PCWSTR")] ushort* pszLibraryName,
        LIBRARYSAVEFLAGS lsf,
        [NativeTypeName("PWSTR *")] ushort** ppszSavedToPath
    )
    {
        if ((ppszSavedToPath) != null)
        {
            *ppszSavedToPath = null;
        }
        IShellItem psiFolder;
        HRESULT hr = SHCreateItemFromParsingName(
            pszFolderPath,
            null,
            __uuidof<IShellItem.Native>(),
            (void**)(&psiFolder)
        );
        if ((((int)(hr)) >= 0))
        {
            IShellItem psiSavedTo;
            hr = plib.Save(psiFolder, pszLibraryName, lsf, &psiSavedTo);
            if ((((int)(hr)) >= 0))
            {
                if ((ppszSavedToPath) != null)
                {
                    hr = psiSavedTo.GetDisplayName(SIGDN_DESKTOPABSOLUTEPARSING, ppszSavedToPath);
                }
                _ = psiSavedTo.Release();
            }
            _ = psiFolder.Release();
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT SHSaveLibraryInFolderPath(
        IShellLibrary plib,
        [NativeTypeName("PCWSTR")] Ref<ushort> pszFolderPath,
        [NativeTypeName("PCWSTR")] Ref<ushort> pszLibraryName,
        LIBRARYSAVEFLAGS lsf,
        [NativeTypeName("PWSTR *")] Ref2D<ushort> ppszSavedToPath
    )
    {
        fixed (ushort** __dsl_ppszSavedToPath = ppszSavedToPath)
        fixed (ushort* __dsl_pszLibraryName = pszLibraryName)
        fixed (ushort* __dsl_pszFolderPath = pszFolderPath)
        {
            return (HRESULT)SHSaveLibraryInFolderPath(
                plib,
                __dsl_pszFolderPath,
                __dsl_pszLibraryName,
                lsf,
                __dsl_ppszSavedToPath
            );
        }
    }
}
