// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public static partial class Gdiplus
{
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GetPixelFormatSize"]/*'/>

    public static uint GetPixelFormatSize([NativeTypeName("Gdiplus::PixelFormat")] int pixfmt)
    {
        return (uint)((pixfmt >> 8) & 0xff);
    }
}
