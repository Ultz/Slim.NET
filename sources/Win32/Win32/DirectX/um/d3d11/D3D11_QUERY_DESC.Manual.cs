// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D11_QUERY_DESC
{
    public D3D11_QUERY_DESC(D3D11_QUERY query, uint miscFlags = 0)
    {
        Query = query;
        MiscFlags = miscFlags;
    }
}
