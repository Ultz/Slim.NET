// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class Windows
{
    public const int ADVISE_NONE = 0;
    public const int ADVISE_CLIPPING = 0x1;
    public const int ADVISE_PALETTE = 0x2;
    public const int ADVISE_COLORKEY = 0x4;
    public const int ADVISE_POSITION = 0x8;
    public const int ADVISE_DISPLAY_CHANGE = 0x10;
}
