// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class FSCTL
{
    [NativeTypeName(
        "#define FSCTL_ENABLE_PER_IO_FLAGS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 267, METHOD_BUFFERED, FILE_ANY_ACCESS)"
    )]
    public static int FSCTL_ENABLE_PER_IO_FLAGS
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return 0;
            }
            else
            {
                return (((0x00000009) << 16) | ((0) << 14) | ((267) << 2) | (0));
            }
        }
    }
}
