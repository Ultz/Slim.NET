// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/DocumentSource.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class JOB
{
    [NativeTypeName("#define JOB_PAGE_APPLICATION_DEFINED ( ( UINT32  )-1 )")]
    public const uint JOB_PAGE_APPLICATION_DEFINED = unchecked((uint)(-1));
}
