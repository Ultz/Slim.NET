// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Win32;

public readonly partial struct BOOL : IIncrementOperators<BOOL>
{
    public static BOOL operator ++(BOOL value) => new(value.Value + 1);
}
