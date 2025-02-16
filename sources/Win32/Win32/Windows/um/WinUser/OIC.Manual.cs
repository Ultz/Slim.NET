// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winuser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class OIC
{
    public const int OIC_SAMPLE = 32512;
    public const int OIC_HAND = 32513;
    public const int OIC_QUES = 32514;
    public const int OIC_BANG = 32515;
    public const int OIC_NOTE = 32516;
    public const int OIC_WINLOGO = 32517;
    public const int OIC_WARNING = OIC_BANG;
    public const int OIC_ERROR = OIC_HAND;
    public const int OIC_INFORMATION = OIC_NOTE;
    public const int OIC_SHIELD = 32518;
}
