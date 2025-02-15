// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public static partial class Gdiplus
{
    [NativeTypeName("#define GDIP_EMFPLUSFLAGS_DISPLAY 0x00000001")]
    public const int GDIP_EMFPLUSFLAGS_DISPLAY = 0x00000001;
}
