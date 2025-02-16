// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class IMAGE
{
    public static int IMAGE_NT_OPTIONAL_HDR_MAGIC
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return IMAGE_NT_OPTIONAL_HDR32_MAGIC;
            }
            else
            {
                return IMAGE_NT_OPTIONAL_HDR64_MAGIC;
            }
        }
    }
    public static nuint IMAGE_ORDINAL_FLAG
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return IMAGE_ORDINAL_FLAG32;
            }
            else
            {
                return unchecked((nuint)(IMAGE_ORDINAL_FLAG64));
            }
        }
    }
}
