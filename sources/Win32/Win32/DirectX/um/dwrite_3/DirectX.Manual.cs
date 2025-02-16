// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    public static DWRITE_FONT_AXIS_TAG DWRITE_MAKE_FONT_AXIS_TAG(byte a, byte b, byte c, byte d) =>
        (DWRITE_FONT_AXIS_TAG)DWRITE_MAKE_OPENTYPE_TAG(a, b, c, d);
}
