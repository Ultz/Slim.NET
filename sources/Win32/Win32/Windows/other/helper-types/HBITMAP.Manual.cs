// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct HBITMAP : IEquatable<HBITMAP>
{
    public static explicit operator HBITMAP(HGDIOBJ value) => new HBITMAP(value.Value);

    public static implicit operator HGDIOBJ(HBITMAP value) => new HGDIOBJ(value.Value);
}
