// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D2D1
{
    [NativeTypeName("#define D2D1_INVALID_PROPERTY_INDEX UINT_MAX")]
    public const uint D2D1_INVALID_PROPERTY_INDEX = 0xffffffff;
}
