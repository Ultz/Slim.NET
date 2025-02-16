// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winuser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class CONSOLE
{
    public static int CONSOLE_APPLICATION_16BIT
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return 0x0001;
            }
            else
            {
                return 0x0000;
            }
        }
    }
}
