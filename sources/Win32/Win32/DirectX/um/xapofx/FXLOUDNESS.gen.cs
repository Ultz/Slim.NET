// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class FXLOUDNESS
{
    [NativeTypeName("#define FXLOUDNESS_DEFAULT_MOMENTARY_MS 400")]
    public const int FXLOUDNESS_DEFAULT_MOMENTARY_MS = 400;

    [NativeTypeName("#define FXLOUDNESS_DEFAULT_SHORTTERM_MS 3000")]
    public const int FXLOUDNESS_DEFAULT_SHORTTERM_MS = 3000;
}
