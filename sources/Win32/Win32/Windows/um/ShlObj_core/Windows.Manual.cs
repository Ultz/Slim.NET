// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [NativeTypeName("#define SHELLSTATE_SIZE_WIN95 FIELD_OFFSET(SHELLSTATE,lParamSort)")]
    public static uint SHELLSTATE_SIZE_WIN95
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out SHELLSTATEW tmp);
            return (uint)(&tmp.lParamSort) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define SHELLSTATE_SIZE_NT4 FIELD_OFFSET(SHELLSTATE,version)")]
    public static uint SHELLSTATE_SIZE_NT4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out SHELLSTATEW tmp);
            return (uint)(&tmp.version) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define SHELLSTATE_SIZE_IE4 FIELD_OFFSET(SHELLSTATE,uNotUsed)")]
    public static uint SHELLSTATE_SIZE_IE4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out SHELLSTATEW tmp);
            return (uint)(&tmp.uNotUsed) - (uint)(&tmp);
        }
    }
}
