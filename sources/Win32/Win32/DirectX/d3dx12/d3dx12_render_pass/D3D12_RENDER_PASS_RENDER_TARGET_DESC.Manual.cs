// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_RENDER_PASS_RENDER_TARGET_DESC
    : IEquatable<D3D12_RENDER_PASS_RENDER_TARGET_DESC>
{
    public static bool operator ==(
        [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")]
            in D3D12_RENDER_PASS_RENDER_TARGET_DESC a,
        [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")]
            in D3D12_RENDER_PASS_RENDER_TARGET_DESC b
    )
    {
        if (a.cpuDescriptor.ptr != b.cpuDescriptor.ptr)
        {
            return false;
        }
        if (a.BeginningAccess != b.BeginningAccess)
        {
            return false;
        }
        if (a.EndingAccess != b.EndingAccess)
        {
            return false;
        }
        return true;
    }

    public static bool operator !=(
        [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")]
            in D3D12_RENDER_PASS_RENDER_TARGET_DESC a,
        [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")]
            in D3D12_RENDER_PASS_RENDER_TARGET_DESC b
    ) => !(a == b);

    public override readonly bool Equals([NotNullWhen(true)] object? obj) =>
        (obj is D3D12_RENDER_PASS_RENDER_TARGET_DESC other) && Equals(other);

    public readonly bool Equals(D3D12_RENDER_PASS_RENDER_TARGET_DESC other) => this == other;

    public override readonly int GetHashCode() =>
        HashCode.Combine(cpuDescriptor.ptr, BeginningAccess, EndingAccess);
}
