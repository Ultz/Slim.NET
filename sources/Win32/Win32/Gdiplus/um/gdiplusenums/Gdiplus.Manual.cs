// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
using static Silk.NET.Gdiplus.ObjectType;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public static partial class Gdiplus
{
    [Transformed]
    public static MaybeBool<BOOL> ObjectTypeIsValid(
        [NativeTypeName("Gdiplus::ObjectType")] ObjectType type
    ) => (MaybeBool<BOOL>)(BOOL)ObjectTypeIsValidRaw(type);

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.ObjectTypeIsValid"]/*'/>

    public static BOOL ObjectTypeIsValidRaw([NativeTypeName("Gdiplus::ObjectType")] ObjectType type)
    {
        return (type >= ObjectTypeMin) && (type <= ObjectTypeMax);
    }
}
