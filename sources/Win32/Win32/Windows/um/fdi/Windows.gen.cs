// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("cabinet", ExactSpelling = true)]
    [return: NativeTypeName("HFDI")]
    public static extern void* FDICreate(
        [NativeTypeName("PFNALLOC")] delegate* unmanaged<uint, void*> pfnalloc,
        [NativeTypeName("PFNFREE")] delegate* unmanaged<void*, void> pfnfree,
        [NativeTypeName("PFNOPEN")] delegate* unmanaged<sbyte*, int, int, nint> pfnopen,
        [NativeTypeName("PFNREAD")] delegate* unmanaged<nint, void*, uint, uint> pfnread,
        [NativeTypeName("PFNWRITE")] delegate* unmanaged<nint, void*, uint, uint> pfnwrite,
        [NativeTypeName("PFNCLOSE")] delegate* unmanaged<nint, int> pfnclose,
        [NativeTypeName("PFNSEEK")] delegate* unmanaged<nint, int, int, int> pfnseek,
        int cpuType,
        [NativeTypeName("PERF")] ERF* perf
    );

    [DllImport("cabinet", ExactSpelling = true)]
    public static extern BOOL FDIIsCabinet(
        [NativeTypeName("HFDI")] void* hfdi,
        [NativeTypeName("INT_PTR")] nint hf,
        [NativeTypeName("PFDICABINETINFO")] FDICABINETINFO* pfdici
    );

    [DllImport("cabinet", ExactSpelling = true)]
    public static extern BOOL FDICopy(
        [NativeTypeName("HFDI")] void* hfdi,
        [NativeTypeName("LPSTR")] sbyte* pszCabinet,
        [NativeTypeName("LPSTR")] sbyte* pszCabPath,
        int flags,
        [NativeTypeName("PFNFDINOTIFY")]
            delegate* unmanaged<FDINOTIFICATIONTYPE, FDINOTIFICATION*, nint> pfnfdin,
        [NativeTypeName("PFNFDIDECRYPT")] delegate* unmanaged<FDIDECRYPT*, int> pfnfdid,
        void* pvUser
    );

    [DllImport("cabinet", ExactSpelling = true)]
    public static extern BOOL FDIDestroy([NativeTypeName("HFDI")] void* hfdi);

    [DllImport("cabinet", ExactSpelling = true)]
    public static extern BOOL FDITruncateCabinet(
        [NativeTypeName("HFDI")] void* hfdi,
        [NativeTypeName("LPSTR")] sbyte* pszCabinetName,
        ushort iFolderToDelete
    );

    [NativeTypeName("#define INCLUDED_FDI 1")]
    public const int INCLUDED_FDI = 1;

    [NativeTypeName("#define cpuUNKNOWN (-1)")]
    public const int cpuUNKNOWN = (-1);

    [NativeTypeName("#define cpu80286 (0)")]
    public const int cpu80286 = (0);

    [NativeTypeName("#define cpu80386 (1)")]
    public const int cpu80386 = (1);
}
