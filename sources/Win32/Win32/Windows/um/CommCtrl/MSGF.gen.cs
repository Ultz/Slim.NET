// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MSGF
{
    [NativeTypeName("#define MSGF_COMMCTRL_BEGINDRAG 0x4200")]
    public const int MSGF_COMMCTRL_BEGINDRAG = 0x4200;

    [NativeTypeName("#define MSGF_COMMCTRL_SIZEHEADER 0x4201")]
    public const int MSGF_COMMCTRL_SIZEHEADER = 0x4201;

    [NativeTypeName("#define MSGF_COMMCTRL_DRAGSELECT 0x4202")]
    public const int MSGF_COMMCTRL_DRAGSELECT = 0x4202;

    [NativeTypeName("#define MSGF_COMMCTRL_TOOLBARCUST 0x4203")]
    public const int MSGF_COMMCTRL_TOOLBARCUST = 0x4203;
}
