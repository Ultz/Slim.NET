// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("const float")]
    public const float POSITIVE_INFINITY = ((float)(1e308 * 10));

    [NativeTypeName("const float")]
    public const float NEGATIVE_INFINITY = ((float)(-1e308 * 10));

    [NativeTypeName("const float")]
    public const float NaN = ((float)((1e308 * 10) * 0.0));
}
