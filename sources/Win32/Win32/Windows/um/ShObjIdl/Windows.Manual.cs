// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using static Silk.NET.Win32.SIGDN;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static HRESULT SHResolveFolderPathInLibrary(
        IShellLibrary plib,
        [NativeTypeName("PCWSTR")] char* pszFolderPath,
        [NativeTypeName("DWORD")] uint dwTimeout,
        [NativeTypeName("PWSTR *")] char** ppszResolvedPath
    )
    {
        *ppszResolvedPath = null;
        ITEMIDLIST* pidlFolder = SHSimpleIDListFromPath(pszFolderPath);
        HRESULT hr = unchecked((pidlFolder) != null ? ((int)(0)) : ((int)(0x80070057)));
        if (((unchecked((int)(hr))) >= 0))
        {
            IShellItem psiFolder;
            hr = SHCreateItemFromIDList(
                pidlFolder,
                __uuidof<IShellItem.Native>(),
                (void**)(&psiFolder)
            );
            if (((unchecked((int)(hr))) >= 0))
            {
                IShellItem psiResolved;
                hr = plib.ResolveFolder(
                    psiFolder,
                    dwTimeout,
                    __uuidof<IShellItem.Native>(),
                    (void**)(&psiResolved)
                );
                if (((unchecked((int)(hr))) >= 0))
                {
                    unchecked(hr) = psiResolved.GetDisplayName(
                        SIGDN_DESKTOPABSOLUTEPARSING,
                        ppszResolvedPath
                    );
                    _ = psiResolved.Release();
                }
                _ = psiFolder.Release();
            }
            CoTaskMemFree(pidlFolder);
        }
        return hr;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT SHResolveFolderPathInLibrary(
        IShellLibrary plib,
        [NativeTypeName("PCWSTR")] Ref<char> pszFolderPath,
        [NativeTypeName("DWORD")] uint dwTimeout,
        [NativeTypeName("PWSTR *")] Ref2D<char> ppszResolvedPath
    )
    {
        fixed (char** __dsl_ppszResolvedPath = ppszResolvedPath)
        fixed (char* __dsl_pszFolderPath = pszFolderPath)
        {
            return (HRESULT)SHResolveFolderPathInLibrary(
                plib,
                __dsl_pszFolderPath,
                dwTimeout,
                __dsl_ppszResolvedPath
            );
        }
    }
}
