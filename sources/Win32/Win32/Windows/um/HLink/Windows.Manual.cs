// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public const int HLTB_DOCKEDLEFT = 0;
    public const int HLTB_DOCKEDTOP = 1;
    public const int HLTB_DOCKEDRIGHT = 2;
    public const int HLTB_DOCKEDBOTTOM = 3;
    public const int HLTB_FLOATING = 4;
    public const int HLBWIF_HASFRAMEWNDINFO = 0x1;
    public const int HLBWIF_HASDOCWNDINFO = 0x2;
    public const int HLBWIF_FRAMEWNDMAXIMIZED = 0x4;
    public const int HLBWIF_DOCWNDMAXIMIZED = 0x8;
    public const int HLBWIF_HASWEBTOOLBARINFO = 0x10;
    public const int HLBWIF_WEBTOOLBARHIDDEN = 0x20;
    public const int HLID_INVALID = 0;
    public const int HLID_PREVIOUS = unchecked((int)(0xffffffff));
    public const int HLID_NEXT = unchecked((int)(0xfffffffe));
    public const int HLID_CURRENT = unchecked((int)(0xfffffffd));
    public const int HLID_STACKBOTTOM = unchecked((int)(0xfffffffc));
    public const int HLID_STACKTOP = unchecked((int)(0xfffffffb));
    public const int HLQF_ISVALID = 0x1;
    public const int HLQF_ISCURRENT = 0x2;
}
