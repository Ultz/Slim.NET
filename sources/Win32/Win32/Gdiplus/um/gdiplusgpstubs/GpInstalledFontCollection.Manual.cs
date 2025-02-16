// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

[NativeTypeName("struct GpInstalledFontCollection : GpFontCollection")]
[NativeInheritance("GpFontCollection")]
public partial struct GpInstalledFontCollection : GpInstalledFontCollection.Interface
{
    public interface Interface : GpFontCollection.Interface { }
}
