// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/intsafe.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static nint INT_PTR_MIN => nint.MinValue;
    public static nint LONG_PTR_MIN => nint.MinValue;
    public static nint PTRDIFF_T_MIN => nint.MinValue;
    public static nint SSIZE_T_MIN => nint.MinValue;
    public static nint INT_PTR_MAX => nint.MaxValue;
    public static nuint UINT_PTR_MAX => nuint.MaxValue;
    public static nint LONG_PTR_MAX => nint.MaxValue;
    public static nuint ULONG_PTR_MAX => nuint.MaxValue;
    public static nuint DWORD_PTR_MAX => nuint.MaxValue;
    public static nint PTRDIFF_T_MAX => nint.MaxValue;
    public static nuint SIZE_T_MAX => nuint.MaxValue;
    public static nint SSIZE_T_MAX => nint.MaxValue;
    public static nuint _SIZE_T_MAX => nuint.MaxValue;
    public static nint INT_PTR_ERROR => (-1);
    public static nuint UINT_PTR_ERROR => nuint.MaxValue;
    public static nint LONG_PTR_ERROR => (-1);
    public static nuint ULONG_PTR_ERROR => nuint.MaxValue;
    public static nuint DWORD_PTR_ERROR => nuint.MaxValue;
    public static nint PTRDIFF_T_ERROR => (-1);
    public static nuint SIZE_T_ERROR => nuint.MaxValue;
    public static nint SSIZE_T_ERROR => (-1);
    public static nuint _SIZE_T_ERROR => nuint.MaxValue;
}
