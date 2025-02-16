// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public partial struct LARGE_INTEGER
{
    public static implicit operator long(LARGE_INTEGER value) => value.QuadPart;

    public static implicit operator LARGE_INTEGER(long value)
    {
        Unsafe.SkipInit(out LARGE_INTEGER result);
        result.QuadPart = value;
        return result;
    }
}
