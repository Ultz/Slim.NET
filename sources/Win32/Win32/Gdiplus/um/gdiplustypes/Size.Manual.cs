// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public partial struct Size
{
    public static Size operator +(in Size self, in Size sz)
    {
        return new Size(self.Width + sz.Width, self.Height + sz.Height);
    }

    public static Size operator -(in Size self, in Size sz)
    {
        return new Size(self.Width - sz.Width, self.Height - sz.Height);
    }
}
