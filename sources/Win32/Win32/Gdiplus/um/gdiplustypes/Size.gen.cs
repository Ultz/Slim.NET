// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct Size
{
    public int Width;
    public int Height;

    public Size()
    {
        Width = Height = 0;
    }

    public Size([NativeTypeName("const Size &")] Size* size)
    {
        Width = size->Width;
        Height = size->Height;
    }

    public Size(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public BOOL Equals([NativeTypeName("const Size &")] Size* sz)
    {
        return ((Width == sz->Width) && (Height == sz->Height)) ? 1 : 0;
    }

    public BOOL Empty()
    {
        return (Width == 0 && Height == 0) ? 1 : 0;
    }
}
