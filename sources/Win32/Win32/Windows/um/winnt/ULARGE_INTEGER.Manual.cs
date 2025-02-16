// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public partial struct ULARGE_INTEGER
{
    public static implicit operator ulong(ULARGE_INTEGER value) => value.QuadPart;

    public static implicit operator ULARGE_INTEGER(ulong value)
    {
        Unsafe.SkipInit(out ULARGE_INTEGER result);
        result.QuadPart = value;
        return result;
    }
}
