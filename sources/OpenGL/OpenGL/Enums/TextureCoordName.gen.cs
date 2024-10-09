// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureCoordName : uint
{
    S = unchecked((uint)0x2000),
    T = unchecked((uint)0x2001),
    R = unchecked((uint)0x2002),
    Q = unchecked((uint)0x2003),
    TextureGenStrOES = unchecked((uint)0x8D60)
}
