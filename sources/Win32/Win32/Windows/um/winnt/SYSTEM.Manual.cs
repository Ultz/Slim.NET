// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Intrinsics.X86;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class SYSTEM
{
    public static int SYSTEM_CACHE_ALIGNMENT_SIZE
    {
        get
        {
            if (X86Base.IsSupported)
            {
                return 64;
            }
            else
            {
                return 128;
            }
        }
    }
}
