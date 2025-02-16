// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D3D12_ROOT_SIGNATURE_FLAGS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_ROOT_SIGNATURE_DESC
{
    public static ref readonly D3D12_ROOT_SIGNATURE_DESC DEFAULT
    {
        get
        {
            ReadOnlySpan<byte> data;
            if (Environment.Is64BitProcess)
            {
                data =
                [
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                ];
            }
            else
            {
                data =
                [
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                ];
            }
            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_ROOT_SIGNATURE_DESC>());
            return ref Unsafe.As<byte, D3D12_ROOT_SIGNATURE_DESC>(
                ref MemoryMarshal.GetReference(data)
            );
        }
    }

    public D3D12_ROOT_SIGNATURE_DESC(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        Init(numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public void Init(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        Init(ref this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Init(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] Ref<D3D12_ROOT_PARAMETER> _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            Ref<D3D12_STATIC_SAMPLER_DESC> _pStaticSamplers = default,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        fixed (D3D12_STATIC_SAMPLER_DESC* __dsl__pStaticSamplers = _pStaticSamplers)
        fixed (D3D12_ROOT_PARAMETER* __dsl__pParameters = _pParameters)
        {
            Init(
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }

    public static void Init(
        [NativeTypeName("D3D12_ROOT_SIGNATURE_DESC &")] ref D3D12_ROOT_SIGNATURE_DESC desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        desc.NumParameters = numParameters;
        desc.pParameters = _pParameters;
        desc.NumStaticSamplers = numStaticSamplers;
        desc.pStaticSamplers = _pStaticSamplers;
        desc.Flags = flags;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Init(
        [NativeTypeName("D3D12_ROOT_SIGNATURE_DESC &")] ref D3D12_ROOT_SIGNATURE_DESC desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] Ref<D3D12_ROOT_PARAMETER> _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            Ref<D3D12_STATIC_SAMPLER_DESC> _pStaticSamplers = default,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        fixed (D3D12_STATIC_SAMPLER_DESC* __dsl__pStaticSamplers = _pStaticSamplers)
        fixed (D3D12_ROOT_PARAMETER* __dsl__pParameters = _pParameters)
        {
            Init(
                ref desc,
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }
}
