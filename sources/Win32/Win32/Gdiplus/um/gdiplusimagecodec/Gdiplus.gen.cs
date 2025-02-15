// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimagecodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public static unsafe partial class Gdiplus
{
    [return: NativeTypeName("Gdiplus::Status")]
    public static GpStatus GetImageDecodersSize(uint* numDecoders, uint* size)
    {
        return GdipGetImageDecodersSize(numDecoders, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public static GpStatus GetImageDecoders(
        uint numDecoders,
        uint size,
        [NativeTypeName("Gdiplus::ImageCodecInfo *")] ImageCodecInfo* decoders
    )
    {
        return GdipGetImageDecoders(numDecoders, size, decoders);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public static GpStatus GetImageEncodersSize(uint* numEncoders, uint* size)
    {
        return GdipGetImageEncodersSize(numEncoders, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public static GpStatus GetImageEncoders(
        uint numEncoders,
        uint size,
        [NativeTypeName("Gdiplus::ImageCodecInfo *")] ImageCodecInfo* encoders
    )
    {
        return GdipGetImageEncoders(numEncoders, size, encoders);
    }
}
