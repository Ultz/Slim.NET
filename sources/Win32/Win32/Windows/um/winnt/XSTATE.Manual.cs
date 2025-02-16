// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class XSTATE
{
    public static ulong XSTATE_MASK_ALLOWED
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (
                    XSTATE_MASK_LEGACY
                    | XSTATE_MASK_AVX
                    | XSTATE_MASK_MPX
                    | XSTATE_MASK_AVX512
                    | XSTATE_MASK_IPT
                    | XSTATE_MASK_CET_U
                    | XSTATE_MASK_LWP
                );
            }
            else
            {
                return (
                    XSTATE_MASK_LEGACY
                    | XSTATE_MASK_AVX
                    | XSTATE_MASK_MPX
                    | XSTATE_MASK_AVX512
                    | XSTATE_MASK_IPT
                    | XSTATE_MASK_CET_U
                    | XSTATE_MASK_AMX_TILE_CONFIG
                    | XSTATE_MASK_AMX_TILE_DATA
                    | XSTATE_MASK_LWP
                );
            }
        }
    }
}
