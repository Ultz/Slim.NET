// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("d3d11", ExactSpelling = true)]
    public static extern HRESULT D3D11On12CreateDevice(
        IUnknown pDevice,
        uint Flags,
        [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pFeatureLevels,
        uint FeatureLevels,
        [NativeTypeName("IUnknown *const *")] IUnknown* ppCommandQueues,
        uint NumQueues,
        uint NodeMask,
        ID3D11Device* ppDevice,
        ID3D11DeviceContext* ppImmediateContext,
        D3D_FEATURE_LEVEL* pChosenFeatureLevel
    );
}
