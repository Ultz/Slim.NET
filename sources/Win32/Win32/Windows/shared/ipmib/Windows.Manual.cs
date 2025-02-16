// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [NativeTypeName(
        "#define SIZEOF_BASIC_MIB_MFE (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE, rgmioOutInfo[0]))"
    )]
    public static uint SIZEOF_BASIC_MIB_MFE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out MIB_IPMCAST_MFE tmp);
            return (uint)(&tmp.rgmioOutInfo) - (uint)(&tmp);
        }
    }

    [NativeTypeName(
        "#define SIZEOF_BASIC_MIB_MFE_STATS (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE_STATS, rgmiosOutStats[0]))"
    )]
    public static uint SIZEOF_BASIC_MIB_MFE_STATS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out MIB_IPMCAST_MFE_STATS tmp);
            return (uint)(&tmp.rgmiosOutStats) - (uint)(&tmp);
        }
    }

    [NativeTypeName(
        "#define SIZEOF_BASIC_MIB_MFE_STATS_EX (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE_STATS_EX, rgmiosOutStats[0]))"
    )]
    public static uint SIZEOF_BASIC_MIB_MFE_STATS_EX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out MIB_IPMCAST_MFE_STATS_EX_XP tmp);
            return (uint)(&tmp.rgmiosOutStats) - (uint)(&tmp);
        }
    }
}
