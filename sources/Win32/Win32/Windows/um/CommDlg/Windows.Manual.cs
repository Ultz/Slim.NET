// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [NativeTypeName(
        "#define OPENFILENAME_SIZE_VERSION_400A CDSIZEOF_STRUCT(OPENFILENAMEA,lpTemplateName)"
    )]
    public static nuint OPENFILENAME_SIZE_VERSION_400A
    {
        get
        {
            Unsafe.SkipInit(out OPENFILENAMEA tmp);
            return unchecked(
                (nuint)(((byte*)(&tmp)->lpTemplateName) - ((byte*)(&tmp))) + (uint)sizeof(char*)
            );
        }
    }

    [NativeTypeName(
        "#define OPENFILENAME_SIZE_VERSION_400W CDSIZEOF_STRUCT(OPENFILENAMEW,lpTemplateName)"
    )]
    public static nuint OPENFILENAME_SIZE_VERSION_400W
    {
        get
        {
            Unsafe.SkipInit(out OPENFILENAMEW tmp);
            return unchecked(
                (nuint)(((byte*)(&tmp)->lpTemplateName) - ((byte*)(&tmp))) + (uint)sizeof(char*)
            );
        }
    }

    [NativeTypeName("#define OPENFILENAME_SIZE_VERSION_400 OPENFILENAME_SIZE_VERSION_400W")]
    public static nuint OPENFILENAME_SIZE_VERSION_400 => OPENFILENAME_SIZE_VERSION_400W;
}
