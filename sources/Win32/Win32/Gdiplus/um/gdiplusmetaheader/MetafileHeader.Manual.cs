// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
using static Silk.NET.Gdiplus.MetafileType;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public partial struct MetafileHeader
{
    [Transformed]
    public readonly MaybeBool<BOOL> IsEmfOrEmfPlus() => (MaybeBool<BOOL>)(BOOL)IsEmfOrEmfPlusRaw();

    public readonly BOOL IsEmfOrEmfPlusRaw()
    {
        return Type >= MetafileTypeEmf;
    }

    [Transformed]
    public readonly MaybeBool<BOOL> IsEmfPlus() => (MaybeBool<BOOL>)(BOOL)IsEmfPlusRaw();

    public readonly BOOL IsEmfPlusRaw()
    {
        return Type >= MetafileTypeEmfPlusOnly;
    }
}
