// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define TMTVS_RESERVEDLOW 100000")]
    public const int TMTVS_RESERVEDLOW = 100000;

    [NativeTypeName("#define TMTVS_RESERVEDHIGH 19999")]
    public const int TMTVS_RESERVEDHIGH = 19999;
}
