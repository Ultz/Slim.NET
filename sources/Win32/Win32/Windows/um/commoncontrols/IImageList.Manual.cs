// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Win32.IID;

namespace Silk.NET.Win32;

public unsafe partial struct IImageList : IImageList.Native.Interface, INativeGuid
{
    public static explicit operator HIMAGELIST(IImageList imageList) => new(imageList.lpVtbl);
    public static explicit operator IImageList(HIMAGELIST imageList) => new() { lpVtbl = (Native*)imageList.Value };
}
