// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public partial struct EMR
{
    public const int EMR_COMMENT = EMR_GDICOMMENT;
    public const int EMR_DRAWESCAPE = EMR_RESERVED_105;
    public const int EMR_EXTESCAPE = EMR_RESERVED_106;
    public const int EMR_SMALLTEXTOUT = EMR_RESERVED_108;
    public const int EMR_FORCEUFIMAPPING = EMR_RESERVED_109;
    public const int EMR_NAMEDESCAPE = EMR_RESERVED_110;
    public const int EMR_SETLINKEDUFIS = EMR_RESERVED_119;
    public const int EMR_SETTEXTJUSTIFICATION = EMR_RESERVED_120;
}
