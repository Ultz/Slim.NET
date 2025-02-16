// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class SCS
{
    public static int SCS_THIS_PLATFORM_BINARY
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return SCS_32BIT_BINARY;
            }
            else
            {
                return SCS_64BIT_BINARY;
            }
        }
    }
}
