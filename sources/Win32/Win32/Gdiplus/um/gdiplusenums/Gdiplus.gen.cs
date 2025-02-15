// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public static partial class Gdiplus
{
    [NativeTypeName("const float")]
    public const float FlatnessDefault = 1.0f / 4.0f;

    [NativeTypeName("#define GDIP_EMFPLUS_RECORD_BASE 0x00004000")]
    public const int GDIP_EMFPLUS_RECORD_BASE = 0x00004000;

    [NativeTypeName("#define GDIP_WMF_RECORD_BASE 0x00010000")]
    public const int GDIP_WMF_RECORD_BASE = 0x00010000;
}
