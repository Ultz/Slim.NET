// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class MF
{
    public const int MF_CAPTURE_ENGINE_PREFERRED_SOURCE_STREAM_FOR_VIDEO_PREVIEW = unchecked(
        (int)0xFFFFFFFA
    );
    public const int MF_CAPTURE_ENGINE_PREFERRED_SOURCE_STREAM_FOR_VIDEO_RECORD = unchecked(
        (int)0xFFFFFFF9
    );
    public const int MF_CAPTURE_ENGINE_PREFERRED_SOURCE_STREAM_FOR_PHOTO = unchecked(
        (int)0xFFFFFFF8
    );
    public const int MF_CAPTURE_ENGINE_PREFERRED_SOURCE_STREAM_FOR_AUDIO = unchecked(
        (int)0xFFFFFFF7
    );
    public const int MF_CAPTURE_ENGINE_MEDIASOURCE = unchecked((int)0xFFFFFFFF);
}
