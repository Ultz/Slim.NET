// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum FragmentShaderColorModMaskATI : uint
{
    X2XBit = unchecked((uint)0x00000001),
    CompBit = unchecked((uint)0x00000002),
    NegateBit = unchecked((uint)0x00000004),
    BiasBit = unchecked((uint)0x00000008)
}
