// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.DirectX.D3D_ROOT_SIGNATURE_VERSION;
using static Silk.NET.DirectX.D3D12_ROOT_SIGNATURE_FLAGS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VERSIONED_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_VERSIONED_ROOT_SIGNATURE_DESC"]/*'/>
[NativeTypeName(
    "struct CD3DX12_VERSIONED_ROOT_SIGNATURE_DESC : D3D12_VERSIONED_ROOT_SIGNATURE_DESC"
)]
[NativeInheritance("D3D12_VERSIONED_ROOT_SIGNATURE_DESC")]
public unsafe partial struct D3D12_VERSIONED_ROOT_SIGNATURE_DESC
{
    public static ref readonly D3D12_VERSIONED_ROOT_SIGNATURE_DESC DEFAULT
    {
        get
        {
            ReadOnlySpan<byte> data;
            if (Environment.Is64BitProcess)
            {
                data =
                [
                    0x02,
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
                    0x02,
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
            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_VERSIONED_ROOT_SIGNATURE_DESC>());
            return ref Unsafe.As<byte, D3D12_VERSIONED_ROOT_SIGNATURE_DESC>(
                ref MemoryMarshal.GetReference(data)
            );
        }
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC &")] in D3D12_ROOT_SIGNATURE_DESC o
    )
    {
        Version = D3D_ROOT_SIGNATURE_VERSION_1_0;
        Anonymous.Desc_1_0 = o;
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC1 &")] in D3D12_ROOT_SIGNATURE_DESC1 o
    )
    {
        Version = D3D_ROOT_SIGNATURE_VERSION_1_1;
        Anonymous.Desc_1_1 = o;
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC2 &")] in D3D12_ROOT_SIGNATURE_DESC2 o
    )
    {
        Version = D3D_ROOT_SIGNATURE_VERSION_1_2;
        Anonymous.Desc_1_2 = o;
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        Init_1_0(numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        Init_1_1(numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public void Init_1_0(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        Init_1_0(ref this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Init_1_0(
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
            Init_1_0(
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }

    public static void Init_1_0(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12_ROOT_PARAMETER* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        desc.Version = D3D_ROOT_SIGNATURE_VERSION_1_0;
        desc.Anonymous.Desc_1_0.NumParameters = numParameters;
        desc.Anonymous.Desc_1_0.pParameters = _pParameters;
        desc.Anonymous.Desc_1_0.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_0.pStaticSamplers = _pStaticSamplers;
        desc.Anonymous.Desc_1_0.Flags = flags;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Init_1_0(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc,
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
            Init_1_0(
                ref desc,
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }

    public void Init_1_1(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        Init_1_1(ref this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Init_1_1(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] Ref<D3D12_ROOT_PARAMETER1> _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            Ref<D3D12_STATIC_SAMPLER_DESC> _pStaticSamplers = default,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        fixed (D3D12_STATIC_SAMPLER_DESC* __dsl__pStaticSamplers = _pStaticSamplers)
        fixed (D3D12_ROOT_PARAMETER1* __dsl__pParameters = _pParameters)
        {
            Init_1_1(
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }

    public static void Init_1_1(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12_STATIC_SAMPLER_DESC* _pStaticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        desc.Version = D3D_ROOT_SIGNATURE_VERSION_1_1;
        desc.Anonymous.Desc_1_1.NumParameters = numParameters;
        desc.Anonymous.Desc_1_1.pParameters = _pParameters;
        desc.Anonymous.Desc_1_1.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_1.pStaticSamplers = _pStaticSamplers;
        desc.Anonymous.Desc_1_1.Flags = flags;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Init_1_1(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] Ref<D3D12_ROOT_PARAMETER1> _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            Ref<D3D12_STATIC_SAMPLER_DESC> _pStaticSamplers = default,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        fixed (D3D12_STATIC_SAMPLER_DESC* __dsl__pStaticSamplers = _pStaticSamplers)
        fixed (D3D12_ROOT_PARAMETER1* __dsl__pParameters = _pParameters)
        {
            Init_1_1(
                ref desc,
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }

    public static void Init_1_2(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12_ROOT_PARAMETER1* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC1 *")]
            D3D12_STATIC_SAMPLER_DESC1* _pStaticSamplers = null,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        desc.Version = D3D_ROOT_SIGNATURE_VERSION_1_2;
        desc.Anonymous.Desc_1_2.NumParameters = numParameters;
        desc.Anonymous.Desc_1_2.pParameters = _pParameters;
        desc.Anonymous.Desc_1_2.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_2.pStaticSamplers = _pStaticSamplers;
        desc.Anonymous.Desc_1_2.Flags = flags;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Init_1_2(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12_VERSIONED_ROOT_SIGNATURE_DESC desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] Ref<D3D12_ROOT_PARAMETER1> _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC1 *")]
            Ref<D3D12_STATIC_SAMPLER_DESC1> _pStaticSamplers = default,
        D3D12_ROOT_SIGNATURE_FLAGS flags = D3D12_ROOT_SIGNATURE_FLAG_NONE
    )
    {
        fixed (D3D12_STATIC_SAMPLER_DESC1* __dsl__pStaticSamplers = _pStaticSamplers)
        fixed (D3D12_ROOT_PARAMETER1* __dsl__pParameters = _pParameters)
        {
            Init_1_2(
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
