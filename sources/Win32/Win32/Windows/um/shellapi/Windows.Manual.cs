// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [NativeTypeName("#define NOTIFYICONDATAA_V1_SIZE FIELD_OFFSET(NOTIFYICONDATAA, szTip[64])")]
    public static uint NOTIFYICONDATAA_V1_SIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out NOTIFYICONDATAA tmp);
            return (uint)(&tmp.szTip) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define NOTIFYICONDATAW_V1_SIZE FIELD_OFFSET(NOTIFYICONDATAW, szTip[64])")]
    public static uint NOTIFYICONDATAW_V1_SIZE
    {
        get
        {
            Unsafe.SkipInit(out NOTIFYICONDATAW tmp);
            return (uint)(&tmp.szTip) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define NOTIFYICONDATA_V1_SIZE NOTIFYICONDATAW_V1_SIZE")]
    public static uint NOTIFYICONDATA_V1_SIZE => NOTIFYICONDATAW_V1_SIZE;

    [NativeTypeName("#define NOTIFYICONDATAA_V2_SIZE FIELD_OFFSET(NOTIFYICONDATAA, guidItem)")]
    public static uint NOTIFYICONDATAA_V2_SIZE
    {
        get
        {
            Unsafe.SkipInit(out NOTIFYICONDATAA tmp);
            return (uint)(&tmp.guidItem) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define NOTIFYICONDATAW_V2_SIZE FIELD_OFFSET(NOTIFYICONDATAW, guidItem)")]
    public static uint NOTIFYICONDATAW_V2_SIZE
    {
        get
        {
            Unsafe.SkipInit(out NOTIFYICONDATAW tmp);
            return (uint)(&tmp.guidItem) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define NOTIFYICONDATA_V2_SIZE NOTIFYICONDATAW_V2_SIZE")]
    public static uint NOTIFYICONDATA_V2_SIZE => NOTIFYICONDATAW_V2_SIZE;

    [NativeTypeName("#define NOTIFYICONDATAA_V3_SIZE FIELD_OFFSET(NOTIFYICONDATAA, hBalloonIcon)")]
    public static uint NOTIFYICONDATAA_V3_SIZE
    {
        get
        {
            Unsafe.SkipInit(out NOTIFYICONDATAA tmp);
            return (uint)(&tmp.hBalloonIcon) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define NOTIFYICONDATAW_V3_SIZE FIELD_OFFSET(NOTIFYICONDATAW, hBalloonIcon)")]
    public static uint NOTIFYICONDATAW_V3_SIZE
    {
        get
        {
            Unsafe.SkipInit(out NOTIFYICONDATAW tmp);
            return (uint)(&tmp.hBalloonIcon) - (uint)(&tmp);
        }
    }

    [NativeTypeName("#define NOTIFYICONDATA_V3_SIZE NOTIFYICONDATAW_V3_SIZE")]
    public static uint NOTIFYICONDATA_V3_SIZE => NOTIFYICONDATAW_V3_SIZE;
}
