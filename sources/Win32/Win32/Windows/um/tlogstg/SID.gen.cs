// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SID
{
    [NativeTypeName("#define SID_STravelLogCursor IID_ITravelLogStg")]
    public static ref readonly Guid SID_STravelLogCursor => ref IID_ITravelLogStg;
}
