// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class E
{
    [NativeTypeName("#define E_SURFACE_CONTENTS_LOST 0x802b0020")]
    public const uint E_SURFACE_CONTENTS_LOST = 0x802b0020;
}
