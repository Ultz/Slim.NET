// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class MF
{
    public const int MF_RESOLUTION_MEDIASOURCE = 0x1;
    public const int MF_RESOLUTION_BYTESTREAM = 0x2;
    public const int MF_RESOLUTION_CONTENT_DOES_NOT_HAVE_TO_MATCH_EXTENSION_OR_MIME_TYPE = 0x10;
    public const int MF_RESOLUTION_KEEP_BYTE_STREAM_ALIVE_ON_FAIL = 0x20;
    public const int MF_RESOLUTION_DISABLE_LOCAL_PLUGINS = 0x40;
    public const int MF_RESOLUTION_PLUGIN_CONTROL_POLICY_APPROVED_ONLY = 0x80;
    public const int MF_RESOLUTION_PLUGIN_CONTROL_POLICY_WEB_ONLY = 0x100;
    public const int MF_RESOLUTION_PLUGIN_CONTROL_POLICY_WEB_ONLY_EDGEMODE = 0x200;
    public const int MF_RESOLUTION_ENABLE_STORE_PLUGINS = 0x400;
    public const int MF_RESOLUTION_READ = 0x10000;
    public const int MF_RESOLUTION_WRITE = 0x20000;
    public const int MF_ACTIVATE_CUSTOM_MIXER_ALLOWFAIL = 0x1;
    public const int MF_ACTIVATE_CUSTOM_PRESENTER_ALLOWFAIL = 0x1;
}
