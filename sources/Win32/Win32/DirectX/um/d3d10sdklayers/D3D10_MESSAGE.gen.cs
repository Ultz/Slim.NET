// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D10_MESSAGE
{
    public D3D10_MESSAGE_CATEGORY Category;
    public D3D10_MESSAGE_SEVERITY Severity;
    public D3D10_MESSAGE_ID ID;

    [NativeTypeName("const char *")]
    public sbyte* pDescription;

    [NativeTypeName("SIZE_T")]
    public nuint DescriptionByteLength;
}
