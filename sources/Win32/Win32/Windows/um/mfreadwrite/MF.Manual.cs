// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class MF
{
    public const int MF_SOURCE_READER_INVALID_STREAM_INDEX = unchecked((int)0xFFFFFFFF);
    public const int MF_SOURCE_READER_ALL_STREAMS = unchecked((int)0xFFFFFFFE);
    public const int MF_SOURCE_READER_ANY_STREAM = unchecked((int)0xFFFFFFFE);
    public const int MF_SOURCE_READER_FIRST_AUDIO_STREAM = unchecked((int)0xFFFFFFFD);
    public const int MF_SOURCE_READER_FIRST_VIDEO_STREAM = unchecked((int)0xFFFFFFFC);
    public const int MF_SOURCE_READER_MEDIASOURCE = unchecked((int)0xFFFFFFFF);
    public const int MF_SOURCE_READER_CURRENT_TYPE_INDEX = unchecked((int)0xFFFFFFFF);
    public const int MF_SINK_WRITER_INVALID_STREAM_INDEX = unchecked((int)0xFFFFFFFF);
    public const int MF_SINK_WRITER_ALL_STREAMS = unchecked((int)0xFFFFFFFE);
    public const int MF_SINK_WRITER_MEDIASINK = unchecked((int)0xFFFFFFFF);
}
