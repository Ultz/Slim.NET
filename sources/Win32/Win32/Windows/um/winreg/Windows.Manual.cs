// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct HKEY
{
    [NativeTypeName("#define HKEY_CLASSES_ROOT (( HKEY ) (ULONG_PTR)((LONG)0x80000000) )")]
    public static HKEY HKEY_CLASSES_ROOT => unchecked((HKEY)((nuint)((int)(0x80000000))));

    [NativeTypeName("#define HKEY_CURRENT_USER (( HKEY ) (ULONG_PTR)((LONG)0x80000001) )")]
    public static HKEY HKEY_CURRENT_USER => unchecked((HKEY)((nuint)((int)(0x80000001))));

    [NativeTypeName("#define HKEY_LOCAL_MACHINE (( HKEY ) (ULONG_PTR)((LONG)0x80000002) )")]
    public static HKEY HKEY_LOCAL_MACHINE => unchecked((HKEY)((nuint)((int)(0x80000002))));

    [NativeTypeName("#define HKEY_USERS (( HKEY ) (ULONG_PTR)((LONG)0x80000003) )")]
    public static HKEY HKEY_USERS => unchecked((HKEY)((nuint)((int)(0x80000003))));

    [NativeTypeName("#define HKEY_PERFORMANCE_DATA (( HKEY ) (ULONG_PTR)((LONG)0x80000004) )")]
    public static HKEY HKEY_PERFORMANCE_DATA => unchecked((HKEY)((nuint)((int)(0x80000004))));

    [NativeTypeName("#define HKEY_PERFORMANCE_TEXT (( HKEY ) (ULONG_PTR)((LONG)0x80000050) )")]
    public static HKEY HKEY_PERFORMANCE_TEXT => unchecked((HKEY)((nuint)((int)(0x80000050))));

    [NativeTypeName("#define HKEY_PERFORMANCE_NLSTEXT (( HKEY ) (ULONG_PTR)((LONG)0x80000060) )")]
    public static HKEY HKEY_PERFORMANCE_NLSTEXT => unchecked((HKEY)((nuint)((int)(0x80000060))));

    [NativeTypeName("#define HKEY_CURRENT_CONFIG (( HKEY ) (ULONG_PTR)((LONG)0x80000005) )")]
    public static HKEY HKEY_CURRENT_CONFIG => unchecked((HKEY)((nuint)((int)(0x80000005))));

    [NativeTypeName("#define HKEY_DYN_DATA (( HKEY ) (ULONG_PTR)((LONG)0x80000006) )")]
    public static HKEY HKEY_DYN_DATA => unchecked((HKEY)((nuint)((int)(0x80000006))));

    [NativeTypeName(
        "#define HKEY_CURRENT_USER_LOCAL_SETTINGS (( HKEY ) (ULONG_PTR)((LONG)0x80000007) )"
    )]
    public static HKEY HKEY_CURRENT_USER_LOCAL_SETTINGS =>
        unchecked((HKEY)((nuint)((int)(0x80000007))));
}
