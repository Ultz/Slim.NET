// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public static partial class Gdiplus
{
    [NativeTypeName("#define REAL_MAX FLT_MAX")]
    public const float REAL_MAX = float.MaxValue;

    [NativeTypeName("#define REAL_MIN FLT_MIN")]
    public const float REAL_MIN = float.MinValue;

    [NativeTypeName("#define REAL_TOLERANCE (FLT_MIN * 100)")]
    public const float REAL_TOLERANCE = (float.MinValue * 100);
}
