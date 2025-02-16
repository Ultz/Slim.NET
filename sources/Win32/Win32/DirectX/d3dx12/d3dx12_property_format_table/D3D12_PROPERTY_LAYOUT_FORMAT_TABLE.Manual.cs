// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_property_format_table.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
using static Silk.NET.DirectX.D3D_FEATURE_LEVEL;
using static Silk.NET.DirectX.D3D_FORMAT_COMPONENT_INTERPRETATION;
using static Silk.NET.DirectX.D3D_FORMAT_COMPONENT_NAME;
using static Silk.NET.DirectX.D3D_FORMAT_LAYOUT;
using static Silk.NET.DirectX.D3D_FORMAT_TYPE_LEVEL;
using static Silk.NET.DirectX.D3D10_SB_4_COMPONENT_NAME;
using static Silk.NET.DirectX.D3D12;
using static Silk.NET.DirectX.D3D12_RESOURCE_DIMENSION;
using static Silk.NET.DirectX.DirectX;
using static Silk.NET.DirectX.DXGI_FORMAT;
using static Silk.NET.Win32.E;
using static Silk.NET.Win32.S;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_PROPERTY_LAYOUT_FORMAT_TABLE
{
    private const int INTSAFE_E_ARITHMETIC_OVERFLOW = unchecked((int)(0x80070216));
    private const D3D_FORMAT_COMPONENT_NAME R = D3DFCN_R;
    private const D3D_FORMAT_COMPONENT_NAME G = D3DFCN_G;
    private const D3D_FORMAT_COMPONENT_NAME B = D3DFCN_B;
    private const D3D_FORMAT_COMPONENT_NAME A = D3DFCN_A;
    private const D3D_FORMAT_COMPONENT_NAME D = D3DFCN_D;
    private const D3D_FORMAT_COMPONENT_NAME S = D3DFCN_S;
    private const D3D_FORMAT_COMPONENT_NAME X = D3DFCN_X;
    private const D3D_FORMAT_COMPONENT_INTERPRETATION _TYPELESS = D3DFCI_TYPELESS;
    private const D3D_FORMAT_COMPONENT_INTERPRETATION _FLOAT = D3DFCI_FLOAT;
    private const D3D_FORMAT_COMPONENT_INTERPRETATION _SNORM = D3DFCI_SNORM;
    private const D3D_FORMAT_COMPONENT_INTERPRETATION _UNORM = D3DFCI_UNORM;
    private const D3D_FORMAT_COMPONENT_INTERPRETATION _SINT = D3DFCI_SINT;
    private const D3D_FORMAT_COMPONENT_INTERPRETATION _UINT = D3DFCI_UINT;
    private const D3D_FORMAT_COMPONENT_INTERPRETATION _UNORM_SRGB = D3DFCI_UNORM_SRGB;
    private const D3D_FORMAT_COMPONENT_INTERPRETATION _FIXED_2_8 = D3DFCI_BIASED_FIXED_2_8;

    public partial struct FORMAT_DETAIL
    {
        public FORMAT_DETAIL(
            DXGI_FORMAT DXGIFormat,
            DXGI_FORMAT ParentFormat,
            ReadOnlySpan<DXGI_FORMAT> DefaultFormatCastSet,
            ReadOnlySpan<byte> BitsPerComponent,
            byte BitsPerUnit,
            bool SRGBFormat,
            uint WidthAlignment,
            uint HeightAlignment,
            uint DepthAlignment,
            D3D_FORMAT_LAYOUT Layout,
            D3D_FORMAT_TYPE_LEVEL TypeLevel,
            ReadOnlySpan<D3D_FORMAT_COMPONENT_NAME> ComponentNames,
            ReadOnlySpan<D3D_FORMAT_COMPONENT_INTERPRETATION> ComponentInterpretations,
            bool bDX9VertexOrIndexFormat,
            bool bDX9TextureFormat,
            bool bFloatNormFormat,
            bool bPlanar,
            bool bYUV,
            bool bDependentFormatCastSet,
            bool bInternal
        )
        {
            Debug.Assert(BitsPerComponent.Length == 4);
            Debug.Assert(ComponentNames.Length == 4);
            Debug.Assert(ComponentInterpretations.Length == 4);
            this.DXGIFormat = DXGIFormat;
            this.ParentFormat = ParentFormat;
            pDefaultFormatCastSet = (DXGI_FORMAT*)(
                Unsafe.AsPointer(ref MemoryMarshal.GetReference(DefaultFormatCastSet))
            );
            this.BitsPerComponent[0] = BitsPerComponent[0];
            this.BitsPerComponent[1] = BitsPerComponent[1];
            this.BitsPerComponent[2] = BitsPerComponent[2];
            this.BitsPerComponent[3] = BitsPerComponent[3];
            this.BitsPerUnit = BitsPerUnit;
            this.SRGBFormat = SRGBFormat;
            this.WidthAlignment = WidthAlignment;
            this.HeightAlignment = HeightAlignment;
            this.DepthAlignment = DepthAlignment;
            this.Layout = Layout;
            this.TypeLevel = TypeLevel;
            ComponentName0 = ComponentNames[0];
            ComponentName1 = ComponentNames[1];
            ComponentName2 = ComponentNames[2];
            ComponentName3 = ComponentNames[3];
            ComponentInterpretation0 = ComponentInterpretations[0];
            ComponentInterpretation1 = ComponentInterpretations[1];
            ComponentInterpretation2 = ComponentInterpretations[2];
            ComponentInterpretation3 = ComponentInterpretations[3];
            this.bDX9VertexOrIndexFormat = bDX9VertexOrIndexFormat;
            this.bDX9TextureFormat = bDX9TextureFormat;
            this.bFloatNormFormat = bFloatNormFormat;
            this.bPlanar = bPlanar;
            this.bYUV = bYUV;
            this.bDependentFormatCastSet = bDependentFormatCastSet;
            this.bInternal = bInternal;
        }

        public DXGI_FORMAT DXGIFormat;
        public DXGI_FORMAT ParentFormat;

        [NativeTypeName("const DXGI_FORMAT *")]
        public DXGI_FORMAT* pDefaultFormatCastSet;

        [NativeTypeName("UINT8[4]")]
        public _BitsPerComponent_e__FixedBuffer BitsPerComponent;

        [NativeTypeName("UINT8")]
        public byte BitsPerUnit;
        public byte _bitfield1;

        [NativeTypeName("byte : 1")]
        public bool SRGBFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield1 & 0x1u) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield1 = (byte)((_bitfield1 & ~0x1u) | (value ? 1u : 0u)); }
        }
        public uint _bitfield2;

        [NativeTypeName("uint : 4")]
        public uint WidthAlignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield2 & 0xFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~0xFu) | (value & 0xFu); }
        }

        [NativeTypeName("uint : 4")]
        public uint HeightAlignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield2 >> 4) & 0xFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4); }
        }

        [NativeTypeName("uint : 1")]
        public uint DepthAlignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield2 >> 8) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x1u << 8)) | ((value & 0x1u) << 8); }
        }

        [NativeTypeName("D3D_FORMAT_LAYOUT : 1")]
        public D3D_FORMAT_LAYOUT Layout
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3D_FORMAT_LAYOUT)((_bitfield2 << 22) >> 31); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x1u << 9)) | (((uint)(value) & 0x1) << 9); }
        }

        [NativeTypeName("D3D_FORMAT_TYPE_LEVEL : 2")]
        public D3D_FORMAT_TYPE_LEVEL TypeLevel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3D_FORMAT_TYPE_LEVEL)((_bitfield2 << 20) >> 30); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x3u << 10)) | (((uint)(value) & 0x3) << 10); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_NAME : 3")]
        public D3D_FORMAT_COMPONENT_NAME ComponentName0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3D_FORMAT_COMPONENT_NAME)((_bitfield2 << 17) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 12)) | (((uint)(value) & 0x7) << 12); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_NAME : 3")]
        public D3D_FORMAT_COMPONENT_NAME ComponentName1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3D_FORMAT_COMPONENT_NAME)((_bitfield2 << 14) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 15)) | (((uint)(value) & 0x7) << 15); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_NAME : 3")]
        public D3D_FORMAT_COMPONENT_NAME ComponentName2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3D_FORMAT_COMPONENT_NAME)((_bitfield2 << 11) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 18)) | (((uint)(value) & 0x7) << 18); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_NAME : 3")]
        public D3D_FORMAT_COMPONENT_NAME ComponentName3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3D_FORMAT_COMPONENT_NAME)((_bitfield2 << 8) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 21)) | (((uint)(value) & 0x7) << 21); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_INTERPRETATION : 3")]
        public D3D_FORMAT_COMPONENT_INTERPRETATION ComponentInterpretation0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3D_FORMAT_COMPONENT_INTERPRETATION)((_bitfield2 << 5) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 24)) | (((uint)(value) & 0x7) << 24); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_INTERPRETATION : 3")]
        public D3D_FORMAT_COMPONENT_INTERPRETATION ComponentInterpretation1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3D_FORMAT_COMPONENT_INTERPRETATION)((_bitfield2 << 2) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 27)) | (((uint)(value) & 0x7) << 27); }
        }
        public int _bitfield3;

        [NativeTypeName("D3D_FORMAT_COMPONENT_INTERPRETATION : 3")]
        public D3D_FORMAT_COMPONENT_INTERPRETATION ComponentInterpretation2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3D_FORMAT_COMPONENT_INTERPRETATION)((_bitfield3 << 29) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield3 = (_bitfield3 & ~0x7) | ((int)(value) & 0x7); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_INTERPRETATION : 3")]
        public D3D_FORMAT_COMPONENT_INTERPRETATION ComponentInterpretation3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3D_FORMAT_COMPONENT_INTERPRETATION)((_bitfield3 << 26) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield3 = (_bitfield3 & ~(0x7 << 3)) | (((int)(value) & 0x7) << 3); }
        }
        public byte _bitfield4;

        [NativeTypeName("bool : 1")]
        public bool bDX9VertexOrIndexFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield4 & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~0x1) | (value ? 1 : 0)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bDX9TextureFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 1) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 1)) | ((value ? 1 : 0) << 1)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bFloatNormFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 2) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 2)) | ((value ? 1 : 0) << 2)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bPlanar
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 3) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 3)) | ((value ? 1 : 0) << 3)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bYUV
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 4) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 4)) | ((value ? 1 : 0) << 4)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bDependentFormatCastSet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 5) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 5)) | ((value ? 1 : 0) << 5)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bInternal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 6) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 6)) | ((value ? 1 : 0) << 6)); }
        }

        [InlineArray(4)]
        public partial struct _BitsPerComponent_e__FixedBuffer
        {
            public byte e0;
        }
    }

    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_UNKNOWN =>
        [
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R32G32B32A32 =>
        [
            DXGI_FORMAT_R32G32B32A32_TYPELESS,
            DXGI_FORMAT_R32G32B32A32_FLOAT,
            DXGI_FORMAT_R32G32B32A32_UINT,
            DXGI_FORMAT_R32G32B32A32_SINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R32G32B32 =>
        [
            DXGI_FORMAT_R32G32B32_TYPELESS,
            DXGI_FORMAT_R32G32B32_FLOAT,
            DXGI_FORMAT_R32G32B32_UINT,
            DXGI_FORMAT_R32G32B32_SINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R16G16B16A16 =>
        [
            DXGI_FORMAT_R16G16B16A16_TYPELESS,
            DXGI_FORMAT_R16G16B16A16_FLOAT,
            DXGI_FORMAT_R16G16B16A16_UNORM,
            DXGI_FORMAT_R16G16B16A16_UINT,
            DXGI_FORMAT_R16G16B16A16_SNORM,
            DXGI_FORMAT_R16G16B16A16_SINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R32G32 =>
        [
            DXGI_FORMAT_R32G32_TYPELESS,
            DXGI_FORMAT_R32G32_FLOAT,
            DXGI_FORMAT_R32G32_UINT,
            DXGI_FORMAT_R32G32_SINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R32G8X24 =>
        [
            DXGI_FORMAT_R32G8X24_TYPELESS,
            DXGI_FORMAT_D32_FLOAT_S8X24_UINT,
            DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS,
            DXGI_FORMAT_X32_TYPELESS_G8X24_UINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R11G11B10 =>
        [
            DXGI_FORMAT_R11G11B10_FLOAT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R8G8B8A8 =>
        [
            DXGI_FORMAT_R8G8B8A8_TYPELESS,
            DXGI_FORMAT_R8G8B8A8_UNORM,
            DXGI_FORMAT_R8G8B8A8_UNORM_SRGB,
            DXGI_FORMAT_R8G8B8A8_UINT,
            DXGI_FORMAT_R8G8B8A8_SNORM,
            DXGI_FORMAT_R8G8B8A8_SINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R16G16 =>
        [
            DXGI_FORMAT_R16G16_TYPELESS,
            DXGI_FORMAT_R16G16_FLOAT,
            DXGI_FORMAT_R16G16_UNORM,
            DXGI_FORMAT_R16G16_UINT,
            DXGI_FORMAT_R16G16_SNORM,
            DXGI_FORMAT_R16G16_SINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R32 =>
        [
            DXGI_FORMAT_R32_TYPELESS,
            DXGI_FORMAT_D32_FLOAT,
            DXGI_FORMAT_R32_FLOAT,
            DXGI_FORMAT_R32_UINT,
            DXGI_FORMAT_R32_SINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R24G8 =>
        [
            DXGI_FORMAT_R24G8_TYPELESS,
            DXGI_FORMAT_D24_UNORM_S8_UINT,
            DXGI_FORMAT_R24_UNORM_X8_TYPELESS,
            DXGI_FORMAT_X24_TYPELESS_G8_UINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R8G8 =>
        [
            DXGI_FORMAT_R8G8_TYPELESS,
            DXGI_FORMAT_R8G8_UNORM,
            DXGI_FORMAT_R8G8_UINT,
            DXGI_FORMAT_R8G8_SNORM,
            DXGI_FORMAT_R8G8_SINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R16 =>
        [
            DXGI_FORMAT_R16_TYPELESS,
            DXGI_FORMAT_R16_FLOAT,
            DXGI_FORMAT_D16_UNORM,
            DXGI_FORMAT_R16_UNORM,
            DXGI_FORMAT_R16_UINT,
            DXGI_FORMAT_R16_SNORM,
            DXGI_FORMAT_R16_SINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R8 =>
        [
            DXGI_FORMAT_R8_TYPELESS,
            DXGI_FORMAT_R8_UNORM,
            DXGI_FORMAT_R8_UINT,
            DXGI_FORMAT_R8_SNORM,
            DXGI_FORMAT_R8_SINT,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_A8 =>
        [
            DXGI_FORMAT_A8_UNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R1 =>
        [
            DXGI_FORMAT_R1_UNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R9G9B9E5 =>
        [
            DXGI_FORMAT_R9G9B9E5_SHAREDEXP,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R8G8_B8G8 =>
        [
            DXGI_FORMAT_R8G8_B8G8_UNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_G8R8_G8B8 =>
        [
            DXGI_FORMAT_G8R8_G8B8_UNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_BC1 =>
        [
            DXGI_FORMAT_BC1_TYPELESS,
            DXGI_FORMAT_BC1_UNORM,
            DXGI_FORMAT_BC1_UNORM_SRGB,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_BC2 =>
        [
            DXGI_FORMAT_BC2_TYPELESS,
            DXGI_FORMAT_BC2_UNORM,
            DXGI_FORMAT_BC2_UNORM_SRGB,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_BC3 =>
        [
            DXGI_FORMAT_BC3_TYPELESS,
            DXGI_FORMAT_BC3_UNORM,
            DXGI_FORMAT_BC3_UNORM_SRGB,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_BC4 =>
        [
            DXGI_FORMAT_BC4_TYPELESS,
            DXGI_FORMAT_BC4_UNORM,
            DXGI_FORMAT_BC4_SNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_BC5 =>
        [
            DXGI_FORMAT_BC5_TYPELESS,
            DXGI_FORMAT_BC5_UNORM,
            DXGI_FORMAT_BC5_SNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_B5G6R5 =>
        [
            DXGI_FORMAT_B5G6R5_UNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_B5G5R5A1 =>
        [
            DXGI_FORMAT_B5G5R5A1_UNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_B8G8R8A8 =>
        [
            DXGI_FORMAT_B8G8R8A8_TYPELESS,
            DXGI_FORMAT_B8G8R8A8_UNORM,
            DXGI_FORMAT_B8G8R8A8_UNORM_SRGB,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_B8G8R8X8 =>
        [
            DXGI_FORMAT_B8G8R8X8_TYPELESS,
            DXGI_FORMAT_B8G8R8X8_UNORM,
            DXGI_FORMAT_B8G8R8X8_UNORM_SRGB,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_R10G10B10A2 =>
        [
            DXGI_FORMAT_R10G10B10A2_TYPELESS,
            DXGI_FORMAT_R10G10B10A2_UNORM,
            DXGI_FORMAT_R10G10B10A2_UINT,
            DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_BC6H =>
        [
            DXGI_FORMAT_BC6H_TYPELESS,
            DXGI_FORMAT_BC6H_UF16,
            DXGI_FORMAT_BC6H_SF16,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_BC7 =>
        [
            DXGI_FORMAT_BC7_TYPELESS,
            DXGI_FORMAT_BC7_UNORM,
            DXGI_FORMAT_BC7_UNORM_SRGB,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_AYUV =>
        [
            DXGI_FORMAT_AYUV,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_NV12 =>
        [
            DXGI_FORMAT_NV12,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_YUY2 =>
        [
            DXGI_FORMAT_YUY2,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_P010 =>
        [
            DXGI_FORMAT_P010,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_P016 =>
        [
            DXGI_FORMAT_P016,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_NV11 =>
        [
            DXGI_FORMAT_NV11,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_420_OPAQUE =>
        [
            DXGI_FORMAT_420_OPAQUE,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_Y410 =>
        [
            DXGI_FORMAT_Y410,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_Y416 =>
        [
            DXGI_FORMAT_Y416,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_Y210 =>
        [
            DXGI_FORMAT_Y210,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_Y216 =>
        [
            DXGI_FORMAT_Y216,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_AI44 =>
        [
            DXGI_FORMAT_AI44,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_IA44 =>
        [
            DXGI_FORMAT_IA44,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_P8 =>
        [
            DXGI_FORMAT_P8,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_A8P8 =>
        [
            DXGI_FORMAT_A8P8,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_B4G4R4A4 =>
        [
            DXGI_FORMAT_B4G4R4A4_UNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_P208 =>
        [
            DXGI_FORMAT_P208,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_V208 =>
        [
            DXGI_FORMAT_V208,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_V408 =>
        [
            DXGI_FORMAT_V408,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static ReadOnlySpan<DXGI_FORMAT> D3DFCS_A4B4G4R4 =>
        [
            DXGI_FORMAT_A4B4G4R4_UNORM,
            DXGI_FORMAT_UNKNOWN, // not part of cast set, just the "null terminator"
        ];
    private static readonly FORMAT_DETAIL[] s_FormatDetail =
    [
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_UNKNOWN,
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32B32A32_TYPELESS,
            ParentFormat: DXGI_FORMAT_R32G32B32A32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32B32A32,
            BitsPerComponent: [32, 32, 32, 32],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32B32A32_FLOAT,
            ParentFormat: DXGI_FORMAT_R32G32B32A32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32B32A32,
            BitsPerComponent: [32, 32, 32, 32],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _FLOAT],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32B32A32_UINT,
            ParentFormat: DXGI_FORMAT_R32G32B32A32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32B32A32,
            BitsPerComponent: [32, 32, 32, 32],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UINT, _UINT, _UINT, _UINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32B32A32_SINT,
            ParentFormat: DXGI_FORMAT_R32G32B32A32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32B32A32,
            BitsPerComponent: [32, 32, 32, 32],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_SINT, _SINT, _SINT, _SINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32B32_TYPELESS,
            ParentFormat: DXGI_FORMAT_R32G32B32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32B32,
            BitsPerComponent: [32, 32, 32, 0],
            BitsPerUnit: 96,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32B32_FLOAT,
            ParentFormat: DXGI_FORMAT_R32G32B32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32B32,
            BitsPerComponent: [32, 32, 32, 0],
            BitsPerUnit: 96,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32B32_UINT,
            ParentFormat: DXGI_FORMAT_R32G32B32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32B32,
            BitsPerComponent: [32, 32, 32, 0],
            BitsPerUnit: 96,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UINT, _UINT, _UINT, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32B32_SINT,
            ParentFormat: DXGI_FORMAT_R32G32B32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32B32,
            BitsPerComponent: [32, 32, 32, 0],
            BitsPerUnit: 96,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_SINT, _SINT, _SINT, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16B16A16_TYPELESS,
            ParentFormat: DXGI_FORMAT_R16G16B16A16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16B16A16_FLOAT,
            ParentFormat: DXGI_FORMAT_R16G16B16A16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _FLOAT],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16B16A16_UNORM,
            ParentFormat: DXGI_FORMAT_R16G16B16A16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16B16A16_UINT,
            ParentFormat: DXGI_FORMAT_R16G16B16A16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UINT, _UINT, _UINT, _UINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16B16A16_SNORM,
            ParentFormat: DXGI_FORMAT_R16G16B16A16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_SNORM, _SNORM, _SNORM, _SNORM],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16B16A16_SINT,
            ParentFormat: DXGI_FORMAT_R16G16B16A16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_SINT, _SINT, _SINT, _SINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32_TYPELESS,
            ParentFormat: DXGI_FORMAT_R32G32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32,
            BitsPerComponent: [32, 32, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32_FLOAT,
            ParentFormat: DXGI_FORMAT_R32G32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32,
            BitsPerComponent: [32, 32, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32_UINT,
            ParentFormat: DXGI_FORMAT_R32G32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32,
            BitsPerComponent: [32, 32, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UINT, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G32_SINT,
            ParentFormat: DXGI_FORMAT_R32G32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G32,
            BitsPerComponent: [32, 32, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SINT, _SINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32G8X24_TYPELESS,
            ParentFormat: DXGI_FORMAT_R32G8X24_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G8X24,
            BitsPerComponent: [32, 8, 24, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_D32_FLOAT_S8X24_UINT,
            ParentFormat: DXGI_FORMAT_R32G8X24_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G8X24,
            BitsPerComponent: [32, 8, 24, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [D, S, X, X],
            ComponentInterpretations: [_FLOAT, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS,
            ParentFormat: DXGI_FORMAT_R32G8X24_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G8X24,
            BitsPerComponent: [32, 8, 24, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_FLOAT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_X32_TYPELESS_G8X24_UINT,
            ParentFormat: DXGI_FORMAT_R32G8X24_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32G8X24,
            BitsPerComponent: [32, 8, 24, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [X, G, X, X],
            ComponentInterpretations: [_TYPELESS, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R10G10B10A2_TYPELESS,
            ParentFormat: DXGI_FORMAT_R10G10B10A2_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R10G10B10A2,
            BitsPerComponent: [10, 10, 10, 2],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: true,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R10G10B10A2_UNORM,
            ParentFormat: DXGI_FORMAT_R10G10B10A2_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R10G10B10A2,
            BitsPerComponent: [10, 10, 10, 2],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: true,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R10G10B10A2_UINT,
            ParentFormat: DXGI_FORMAT_R10G10B10A2_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R10G10B10A2,
            BitsPerComponent: [10, 10, 10, 2],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UINT, _UINT, _UINT, _UINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: true,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R11G11B10_FLOAT,
            ParentFormat: DXGI_FORMAT_R11G11B10_FLOAT,
            DefaultFormatCastSet: D3DFCS_R11G11B10,
            BitsPerComponent: [11, 11, 10, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8B8A8_TYPELESS,
            ParentFormat: DXGI_FORMAT_R8G8B8A8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8B8A8_UNORM,
            ParentFormat: DXGI_FORMAT_R8G8B8A8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8B8A8_UNORM_SRGB,
            ParentFormat: DXGI_FORMAT_R8G8B8A8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: true,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8B8A8_UINT,
            ParentFormat: DXGI_FORMAT_R8G8B8A8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UINT, _UINT, _UINT, _UINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8B8A8_SNORM,
            ParentFormat: DXGI_FORMAT_R8G8B8A8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_SNORM, _SNORM, _SNORM, _SNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8B8A8_SINT,
            ParentFormat: DXGI_FORMAT_R8G8B8A8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_SINT, _SINT, _SINT, _SINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16_TYPELESS,
            ParentFormat: DXGI_FORMAT_R16G16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16_FLOAT,
            ParentFormat: DXGI_FORMAT_R16G16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16_UNORM,
            ParentFormat: DXGI_FORMAT_R16G16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UNORM, _UNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16_UINT,
            ParentFormat: DXGI_FORMAT_R16G16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UINT, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16_SNORM,
            ParentFormat: DXGI_FORMAT_R16G16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SNORM, _SNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16G16_SINT,
            ParentFormat: DXGI_FORMAT_R16G16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SINT, _SINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32_TYPELESS,
            ParentFormat: DXGI_FORMAT_R32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32,
            BitsPerComponent: [32, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_D32_FLOAT,
            ParentFormat: DXGI_FORMAT_R32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32,
            BitsPerComponent: [32, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [D, X, X, X],
            ComponentInterpretations: [_FLOAT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32_FLOAT,
            ParentFormat: DXGI_FORMAT_R32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32,
            BitsPerComponent: [32, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_FLOAT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32_UINT,
            ParentFormat: DXGI_FORMAT_R32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32,
            BitsPerComponent: [32, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R32_SINT,
            ParentFormat: DXGI_FORMAT_R32_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R32,
            BitsPerComponent: [32, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R24G8_TYPELESS,
            ParentFormat: DXGI_FORMAT_R24G8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R24G8,
            BitsPerComponent: [24, 8, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_D24_UNORM_S8_UINT,
            ParentFormat: DXGI_FORMAT_R24G8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R24G8,
            BitsPerComponent: [24, 8, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [D, S, X, X],
            ComponentInterpretations: [_UNORM, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R24_UNORM_X8_TYPELESS,
            ParentFormat: DXGI_FORMAT_R24G8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R24G8,
            BitsPerComponent: [24, 8, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_X24_TYPELESS_G8_UINT,
            ParentFormat: DXGI_FORMAT_R24G8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R24G8,
            BitsPerComponent: [24, 8, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [X, G, X, X],
            ComponentInterpretations: [_TYPELESS, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8_TYPELESS,
            ParentFormat: DXGI_FORMAT_R8G8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8,
            BitsPerComponent: [8, 8, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8_UNORM,
            ParentFormat: DXGI_FORMAT_R8G8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8,
            BitsPerComponent: [8, 8, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UNORM, _UNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8_UINT,
            ParentFormat: DXGI_FORMAT_R8G8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8,
            BitsPerComponent: [8, 8, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UINT, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8_SNORM,
            ParentFormat: DXGI_FORMAT_R8G8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8,
            BitsPerComponent: [8, 8, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SNORM, _SNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8_SINT,
            ParentFormat: DXGI_FORMAT_R8G8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8G8,
            BitsPerComponent: [8, 8, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SINT, _SINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16_TYPELESS,
            ParentFormat: DXGI_FORMAT_R16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16_FLOAT,
            ParentFormat: DXGI_FORMAT_R16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_FLOAT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_D16_UNORM,
            ParentFormat: DXGI_FORMAT_R16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [D, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16_UNORM,
            ParentFormat: DXGI_FORMAT_R16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16_UINT,
            ParentFormat: DXGI_FORMAT_R16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16_SNORM,
            ParentFormat: DXGI_FORMAT_R16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R16_SINT,
            ParentFormat: DXGI_FORMAT_R16_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8_TYPELESS,
            ParentFormat: DXGI_FORMAT_R8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8,
            BitsPerComponent: [8, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8_UNORM,
            ParentFormat: DXGI_FORMAT_R8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8,
            BitsPerComponent: [8, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8_UINT,
            ParentFormat: DXGI_FORMAT_R8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8,
            BitsPerComponent: [8, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8_SNORM,
            ParentFormat: DXGI_FORMAT_R8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8,
            BitsPerComponent: [8, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8_SINT,
            ParentFormat: DXGI_FORMAT_R8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R8,
            BitsPerComponent: [8, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_A8_UNORM,
            ParentFormat: DXGI_FORMAT_A8_UNORM,
            DefaultFormatCastSet: D3DFCS_A8,
            BitsPerComponent: [0, 0, 0, 8],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [X, X, X, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R1_UNORM,
            ParentFormat: DXGI_FORMAT_R1_UNORM,
            DefaultFormatCastSet: D3DFCS_R1,
            BitsPerComponent: [1, 0, 0, 0],
            BitsPerUnit: 1,
            SRGBFormat: false,
            WidthAlignment: 8,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R9G9B9E5_SHAREDEXP,
            ParentFormat: DXGI_FORMAT_R9G9B9E5_SHAREDEXP,
            DefaultFormatCastSet: D3DFCS_R9G9B9E5,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _FLOAT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R8G8_B8G8_UNORM,
            ParentFormat: DXGI_FORMAT_R8G8_B8G8_UNORM,
            DefaultFormatCastSet: D3DFCS_R8G8_B8G8,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_G8R8_G8B8_UNORM,
            ParentFormat: DXGI_FORMAT_G8R8_G8B8_UNORM,
            DefaultFormatCastSet: D3DFCS_G8R8_G8B8,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC1_TYPELESS,
            ParentFormat: DXGI_FORMAT_BC1_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC1,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC1_UNORM,
            ParentFormat: DXGI_FORMAT_BC1_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC1,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC1_UNORM_SRGB,
            ParentFormat: DXGI_FORMAT_BC1_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC1,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: true,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC2_TYPELESS,
            ParentFormat: DXGI_FORMAT_BC2_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC2,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC2_UNORM,
            ParentFormat: DXGI_FORMAT_BC2_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC2,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC2_UNORM_SRGB,
            ParentFormat: DXGI_FORMAT_BC2_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC2,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: true,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC3_TYPELESS,
            ParentFormat: DXGI_FORMAT_BC3_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC3,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC3_UNORM,
            ParentFormat: DXGI_FORMAT_BC3_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC3,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC3_UNORM_SRGB,
            ParentFormat: DXGI_FORMAT_BC3_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC3,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: true,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC4_TYPELESS,
            ParentFormat: DXGI_FORMAT_BC4_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC4,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC4_UNORM,
            ParentFormat: DXGI_FORMAT_BC4_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC4,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC4_SNORM,
            ParentFormat: DXGI_FORMAT_BC4_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC4,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC5_TYPELESS,
            ParentFormat: DXGI_FORMAT_BC5_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC5,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC5_UNORM,
            ParentFormat: DXGI_FORMAT_BC5_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC5,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UNORM, _UNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC5_SNORM,
            ParentFormat: DXGI_FORMAT_BC5_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC5,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SNORM, _SNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_B5G6R5_UNORM,
            ParentFormat: DXGI_FORMAT_B5G6R5_UNORM,
            DefaultFormatCastSet: D3DFCS_B5G6R5,
            BitsPerComponent: [5, 6, 5, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [B, G, R, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_B5G5R5A1_UNORM,
            ParentFormat: DXGI_FORMAT_B5G5R5A1_UNORM,
            DefaultFormatCastSet: D3DFCS_B5G5R5A1,
            BitsPerComponent: [5, 5, 5, 1],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_B8G8R8A8_UNORM,
            ParentFormat: DXGI_FORMAT_B8G8R8A8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_B8G8R8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_B8G8R8X8_UNORM,
            ParentFormat: DXGI_FORMAT_B8G8R8X8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_B8G8R8X8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [B, G, R, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM,
            ParentFormat: DXGI_FORMAT_R10G10B10A2_TYPELESS,
            DefaultFormatCastSet: D3DFCS_R10G10B10A2,
            BitsPerComponent: [10, 10, 10, 2],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_FIXED_2_8, _FIXED_2_8, _FIXED_2_8, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_B8G8R8A8_TYPELESS,
            ParentFormat: DXGI_FORMAT_B8G8R8A8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_B8G8R8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_B8G8R8A8_UNORM_SRGB,
            ParentFormat: DXGI_FORMAT_B8G8R8A8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_B8G8R8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: true,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_B8G8R8X8_TYPELESS,
            ParentFormat: DXGI_FORMAT_B8G8R8X8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_B8G8R8X8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [B, G, R, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_B8G8R8X8_UNORM_SRGB,
            ParentFormat: DXGI_FORMAT_B8G8R8X8_TYPELESS,
            DefaultFormatCastSet: D3DFCS_B8G8R8X8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: true,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [B, G, R, X],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC6H_TYPELESS,
            ParentFormat: DXGI_FORMAT_BC6H_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC6H,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC6H_SF16,
            ParentFormat: DXGI_FORMAT_BC6H_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC6H,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC6H_UF16,
            ParentFormat: DXGI_FORMAT_BC6H_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC6H,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC7_TYPELESS,
            ParentFormat: DXGI_FORMAT_BC7_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC7,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_PARTIAL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC7_UNORM,
            ParentFormat: DXGI_FORMAT_BC7_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC7,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_BC7_UNORM_SRGB,
            ParentFormat: DXGI_FORMAT_BC7_TYPELESS,
            DefaultFormatCastSet: D3DFCS_BC7,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: true,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        // YUV 4:4:4 formats
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_AYUV,
            ParentFormat: DXGI_FORMAT_AYUV,
            DefaultFormatCastSet: D3DFCS_AYUV,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_Y410,
            ParentFormat: DXGI_FORMAT_Y410,
            DefaultFormatCastSet: D3DFCS_Y410,
            BitsPerComponent: [10, 10, 10, 2],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_Y416,
            ParentFormat: DXGI_FORMAT_Y416,
            DefaultFormatCastSet: D3DFCS_Y416,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        // YUV 4:2:0 formats
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_NV12,
            ParentFormat: DXGI_FORMAT_NV12,
            DefaultFormatCastSet: D3DFCS_NV12,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 2,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_P010,
            ParentFormat: DXGI_FORMAT_P010,
            DefaultFormatCastSet: D3DFCS_P010,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 2,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_P016,
            ParentFormat: DXGI_FORMAT_P016,
            DefaultFormatCastSet: D3DFCS_P016,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 2,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_420_OPAQUE,
            ParentFormat: DXGI_FORMAT_420_OPAQUE,
            DefaultFormatCastSet: D3DFCS_420_OPAQUE,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 2,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        // YUV 4:2:2 formats
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_YUY2,
            ParentFormat: DXGI_FORMAT_YUY2,
            DefaultFormatCastSet: D3DFCS_YUY2,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_Y210,
            ParentFormat: DXGI_FORMAT_Y210,
            DefaultFormatCastSet: D3DFCS_Y210,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_Y216,
            ParentFormat: DXGI_FORMAT_Y216,
            DefaultFormatCastSet: D3DFCS_Y216,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        // YUV 4:1:1 formats
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_NV11,
            ParentFormat: DXGI_FORMAT_NV11,
            DefaultFormatCastSet: D3DFCS_NV11,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        // Legacy substream formats
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_AI44,
            ParentFormat: DXGI_FORMAT_AI44,
            DefaultFormatCastSet: D3DFCS_AI44,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_IA44,
            ParentFormat: DXGI_FORMAT_IA44,
            DefaultFormatCastSet: D3DFCS_IA44,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_P8,
            ParentFormat: DXGI_FORMAT_P8,
            DefaultFormatCastSet: D3DFCS_P8,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_A8P8,
            ParentFormat: DXGI_FORMAT_A8P8,
            DefaultFormatCastSet: D3DFCS_A8P8,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_B4G4R4A4_UNORM,
            ParentFormat: DXGI_FORMAT_B4G4R4A4_UNORM,
            DefaultFormatCastSet: D3DFCS_B4G4R4A4,
            BitsPerComponent: [4, 4, 4, 4],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(116),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(117),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(118),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(119),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(120),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(121),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(122),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(123),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(124),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(125),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(126),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(127),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(128),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(129),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_P208,
            ParentFormat: DXGI_FORMAT_P208,
            DefaultFormatCastSet: D3DFCS_P208,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_V208,
            ParentFormat: DXGI_FORMAT_V208,
            DefaultFormatCastSet: D3DFCS_V208,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 2,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_V408,
            ParentFormat: DXGI_FORMAT_V408,
            DefaultFormatCastSet: D3DFCS_V408,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(133),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(134),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(135),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(136),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(137),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(138),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(139),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(140),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(141),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(142),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(143),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(144),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(145),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(146),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(147),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(148),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(149),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(150),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(151),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(152),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(153),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(154),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(155),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(156),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(157),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(158),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(159),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(160),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(161),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(162),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(163),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(164),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(165),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(166),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(167),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(168),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(169),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(170),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(171),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(172),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(173),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(174),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(175),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(176),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(177),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(178),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(179),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(180),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(181),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(182),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(183),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(184),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(185),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(186),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(187),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DXGI_FORMAT)(188),
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_NO_TYPE,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_SAMPLER_FEEDBACK_MIN_MIP_OPAQUE,
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE,
            ParentFormat: DXGI_FORMAT_UNKNOWN,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_CUSTOM,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DXGI_FORMAT_A4B4G4R4_UNORM,
            ParentFormat: DXGI_FORMAT_A4B4G4R4_UNORM,
            DefaultFormatCastSet: D3DFCS_A4B4G4R4,
            BitsPerComponent: [4, 4, 4, 4],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFL_STANDARD,
            TypeLevel: D3DFTL_FULL_TYPE,
            ComponentNames: [A, B, G, R],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
    ];
    private static uint s_NumFormats => (uint)(s_FormatDetail.Length);

    [NativeTypeName("LPCSTR")]
    private static readonly string[] s_FormatNames =
    [
        "UNKNOWN",
        "R32G32B32A32_TYPELESS",
        "R32G32B32A32_FLOAT",
        "R32G32B32A32_UINT",
        "R32G32B32A32_SINT",
        "R32G32B32_TYPELESS",
        "R32G32B32_FLOAT",
        "R32G32B32_UINT",
        "R32G32B32_SINT",
        "R16G16B16A16_TYPELESS",
        "R16G16B16A16_FLOAT",
        "R16G16B16A16_UNORM",
        "R16G16B16A16_UINT",
        "R16G16B16A16_SNORM",
        "R16G16B16A16_SINT",
        "R32G32_TYPELESS",
        "R32G32_FLOAT",
        "R32G32_UINT",
        "R32G32_SINT",
        "R32G8X24_TYPELESS",
        "D32_FLOAT_S8X24_UINT",
        "R32_FLOAT_X8X24_TYPELESS",
        "X32_TYPELESS_G8X24_UINT",
        "R10G10B10A2_TYPELESS",
        "R10G10B10A2_UNORM",
        "R10G10B10A2_UINT",
        "R11G11B10_FLOAT",
        "R8G8B8A8_TYPELESS",
        "R8G8B8A8_UNORM",
        "R8G8B8A8_UNORM_SRGB",
        "R8G8B8A8_UINT",
        "R8G8B8A8_SNORM",
        "R8G8B8A8_SINT",
        "R16G16_TYPELESS",
        "R16G16_FLOAT",
        "R16G16_UNORM",
        "R16G16_UINT",
        "R16G16_SNORM",
        "R16G16_SINT",
        "R32_TYPELESS",
        "D32_FLOAT",
        "R32_FLOAT",
        "R32_UINT",
        "R32_SINT",
        "R24G8_TYPELESS",
        "D24_UNORM_S8_UINT",
        "R24_UNORM_X8_TYPELESS",
        "X24_TYPELESS_G8_UINT",
        "R8G8_TYPELESS",
        "R8G8_UNORM",
        "R8G8_UINT",
        "R8G8_SNORM",
        "R8G8_SINT",
        "R16_TYPELESS",
        "R16_FLOAT",
        "D16_UNORM",
        "R16_UNORM",
        "R16_UINT",
        "R16_SNORM",
        "R16_SINT",
        "R8_TYPELESS",
        "R8_UNORM",
        "R8_UINT",
        "R8_SNORM",
        "R8_SINT",
        "A8_UNORM",
        "R1_UNORM",
        "R9G9B9E5_SHAREDEXP",
        "R8G8_B8G8_UNORM",
        "G8R8_G8B8_UNORM",
        "BC1_TYPELESS",
        "BC1_UNORM",
        "BC1_UNORM_SRGB",
        "BC2_TYPELESS",
        "BC2_UNORM",
        "BC2_UNORM_SRGB",
        "BC3_TYPELESS",
        "BC3_UNORM",
        "BC3_UNORM_SRGB",
        "BC4_TYPELESS",
        "BC4_UNORM",
        "BC4_SNORM",
        "BC5_TYPELESS",
        "BC5_UNORM",
        "BC5_SNORM",
        "B5G6R5_UNORM",
        "B5G5R5A1_UNORM",
        "B8G8R8A8_UNORM",
        "B8G8R8X8_UNORM",
        "R10G10B10_XR_BIAS_A2_UNORM",
        "B8G8R8A8_TYPELESS",
        "B8G8R8A8_UNORM_SRGB",
        "B8G8R8X8_TYPELESS",
        "B8G8R8X8_UNORM_SRGB",
        "BC6H_TYPELESS",
        "BC6H_UF16",
        "BC6H_SF16",
        "BC7_TYPELESS",
        "BC7_UNORM",
        "BC7_UNORM_SRGB",
        "AYUV",
        "Y410",
        "Y416",
        "NV12",
        "P010",
        "P016",
        "420_OPAQUE",
        "YUY2",
        "Y210",
        "Y216",
        "NV11",
        "AI44",
        "IA44",
        "P8",
        "A8P8",
    ];

    public static HRESULT CalculateExtraPlanarRows(
        DXGI_FORMAT format,
        uint plane0Height,
        [NativeTypeName("UINT &")] out uint totalHeight
    )
    {
        Unsafe.SkipInit(out totalHeight);
        if (!PlanarRaw(format))
        {
            totalHeight = plane0Height;
            return S_OK;
        }
        // blockWidth, blockHeight, and blockSize only reflect the size of plane 0.  Each planar format has additional planes that must
        // be counted.  Each format increases size by another 0.5x, 1x, or 2x.  Grab the number of "half allocation" increments so integer
        // math can be used to calculate the extra size.
        uint extraHalfHeight;
        uint round;
        switch (GetParentFormat(format))
        {
            case DXGI_FORMAT_NV12:
            case DXGI_FORMAT_P010:
            case DXGI_FORMAT_P016:
            case DXGI_FORMAT_420_OPAQUE:
            {
                extraHalfHeight = 1;
                round = 1;
                break;
            }
            case DXGI_FORMAT_NV11:
            case DXGI_FORMAT_P208:
            {
                extraHalfHeight = 2;
                round = 0;
                break;
            }
            case DXGI_FORMAT_V208:
            {
                extraHalfHeight = 2;
                round = 1;
                break;
            }
            case DXGI_FORMAT_V408:
            {
                extraHalfHeight = 4;
                round = 0;
                break;
            }
            case DXGI_FORMAT_R24G8_TYPELESS:
            case DXGI_FORMAT_R32G8X24_TYPELESS:
            {
                totalHeight = plane0Height;
                return S_OK;
            }
            default:
            {
                Debug.Assert(false);
                return S_OK;
            }
        }
        if (
            FAILED(Safe_UIntMult(plane0Height, extraHalfHeight, out uint extraPlaneHeight))
            || FAILED(Safe_UIntAdd(extraPlaneHeight, round, out extraPlaneHeight))
            || FAILED(Safe_UIntAdd(plane0Height, (extraPlaneHeight >> 1), out totalHeight))
        )
        {
            return INTSAFE_E_ARITHMETIC_OVERFLOW;
        }
        return S_OK;
    }

    // This helper function calculates the Row Pitch for a given format. For Planar formats this function returns
    // the row major RowPitch of the resource. The RowPitch is the same for all the planes. For Planar
    // also use the CalculateExtraPlanarRows function to calculate the corresponding height or use the CalculateMinimumRowMajorSlicePitch
    // function. For Block Compressed Formats, this function returns the RowPitch of a row of blocks. For packed subsampled formats and other formats,
    // this function returns the row pitch of one single row of pixels.
    public static HRESULT CalculateMinimumRowMajorRowPitch(
        DXGI_FORMAT Format,
        uint Width,
        [NativeTypeName("UINT &")] out uint RowPitch
    )
    {
        Unsafe.SkipInit(out RowPitch);
        // Early out for DXGI_FORMAT_UNKNOWN special case.
        if (Format == DXGI_FORMAT_UNKNOWN)
        {
            RowPitch = Width;
            return S_OK;
        }
        uint WidthAlignment = GetWidthAlignment(Format);
        uint NumUnits;
        if (IsBlockCompressFormat(Format))
        {
            // This function calculates the minimum stride needed for a block row when the format
            // is block compressed.The GetBitsPerUnit value stored in the format table indicates
            // the size of a compressed block for block compressed formats.
            Debug.Assert(WidthAlignment != 0);
            if (FAILED(DivideAndRoundUp(Width, WidthAlignment, out NumUnits)))
            {
                return INTSAFE_E_ARITHMETIC_OVERFLOW;
            }
        }
        else
        {
            // All other formats must have strides aligned to their width alignment requirements.
            // The Width may not be aligned to the WidthAlignment.  This is not an error for this
            // function as we expect to allow formats like NV12 to have odd dimensions in the future.
            // The following alignement code expects only pow2 alignment requirements.  Only block
            // compressed formats currently have non-pow2 alignment requriements.
            Debug.Assert(IsPow2(WidthAlignment));
            uint Mask = WidthAlignment - 1;
            if (FAILED(Safe_UIntAdd(Width, Mask, out NumUnits)))
            {
                return INTSAFE_E_ARITHMETIC_OVERFLOW;
            }
            NumUnits &= ~Mask;
        }
        if (FAILED(Safe_UIntMult(NumUnits, GetBitsPerUnit(Format), out RowPitch)))
        {
            return INTSAFE_E_ARITHMETIC_OVERFLOW;
        }
        // This must to always be Byte aligned.
        Debug.Assert((RowPitch & 7) == 0);
        RowPitch >>= 3;
        return S_OK;
    }

    // This helper function calculates the SlicePitch for a given format. For Planar formats the slice pitch includes the extra planes.
    public static HRESULT CalculateMinimumRowMajorSlicePitch(
        DXGI_FORMAT Format,
        uint ContextBasedRowPitch,
        uint Height,
        [NativeTypeName("UINT &")] out uint SlicePitch
    )
    {
        Unsafe.SkipInit(out SlicePitch);
        if (PlanarRaw(Format))
        {
            if (FAILED(CalculateExtraPlanarRows(Format, Height, out uint PlanarHeight)))
            {
                return INTSAFE_E_ARITHMETIC_OVERFLOW;
            }
            return Safe_UIntMult(ContextBasedRowPitch, PlanarHeight, out SlicePitch);
        }
        else if (Format == DXGI_FORMAT_UNKNOWN)
        {
            return Safe_UIntMult(ContextBasedRowPitch, Height, out SlicePitch);
        }
        uint HeightAlignment = GetHeightAlignment(Format);
        // Caution assert to make sure that no new format breaks this assumption that all HeightAlignment formats are BC or Planar.
        // This is to make sure that Height handled correctly for this calculation.
        Debug.Assert(HeightAlignment == 1 || IsBlockCompressFormat(Format));
        if (FAILED(DivideAndRoundUp(Height, HeightAlignment, out uint HeightOfPacked)))
        {
            return INTSAFE_E_ARITHMETIC_OVERFLOW;
        }
        if (FAILED(Safe_UIntMult(HeightOfPacked, ContextBasedRowPitch, out SlicePitch)))
        {
            return INTSAFE_E_ARITHMETIC_OVERFLOW;
        }
        return S_OK;
    }

    public static HRESULT CalculateResourceSize(
        uint width,
        uint height,
        uint depth,
        DXGI_FORMAT format,
        uint mipLevels,
        uint subresources,
        [NativeTypeName("SIZE_T &")] out nuint totalByteSize,
        D3D12_MEMCPY_DEST* pDst = null
    )
    {
        Unsafe.SkipInit(out totalByteSize);
        uint tableIndex = GetDetailTableIndexNoThrow(format);
        ref readonly FORMAT_DETAIL formatDetail = ref s_FormatDetail[tableIndex];
        bool fIsBlockCompressedFormat = IsBlockCompressFormat(format);
        // No format currently requires depth alignment.
        Debug.Assert(formatDetail.DepthAlignment == 1);
        uint subWidth = width;
        uint subHeight = height;
        uint subDepth = depth;
        for (uint s = 0, iM = 0; s < subresources; ++s)
        {
            if (
                FAILED(DivideAndRoundUp(subWidth, formatDetail.WidthAlignment, out uint blockWidth))
            )
            {
                return INTSAFE_E_ARITHMETIC_OVERFLOW;
            }
            uint blockSize,
                blockHeight;
            if (fIsBlockCompressedFormat)
            {
                if (
                    FAILED(
                        DivideAndRoundUp(subHeight, formatDetail.HeightAlignment, out blockHeight)
                    )
                )
                {
                    return INTSAFE_E_ARITHMETIC_OVERFLOW;
                }
                // Block Compressed formats use BitsPerUnit as block size.
                blockSize = formatDetail.BitsPerUnit;
            }
            else
            {
                // The height must *not* be aligned to HeightAlign.  As there is no plane pitch/stride, the expectation is that the 2nd plane
                // begins immediately after the first.  The only formats with HeightAlignment other than 1 are planar or block compressed, and
                // block compressed is handled above.
                Debug.Assert(formatDetail.bPlanar || (formatDetail.HeightAlignment == 1));
                blockHeight = subHeight;
                // Combined with the division os subWidth by the width alignment above, this helps achieve rounding the stride up to an even multiple of
                // block width.  This is especially important for formats like NV12 and P208 whose chroma plane is wider than the luma.
                blockSize = formatDetail.BitsPerUnit * formatDetail.WidthAlignment;
            }
            if (DXGI_FORMAT_UNKNOWN == formatDetail.DXGIFormat)
            {
                blockSize = 8;
            }
            // Convert block width size to bytes.
            Debug.Assert((blockSize & 0x7) == 0);
            blockSize >>= 3;
            if (formatDetail.bPlanar)
            {
                if (FAILED(CalculateExtraPlanarRows(format, blockHeight, out blockHeight)))
                {
                    return INTSAFE_E_ARITHMETIC_OVERFLOW;
                }
            }
            // Calculate rowPitch, depthPitch, and total subresource size.
            if (
                FAILED(Safe_UIntMult(blockWidth, blockSize, out uint rowPitch))
                || FAILED(Safe_UIntMult(blockHeight, rowPitch, out uint depthPitch))
            )
            {
                return INTSAFE_E_ARITHMETIC_OVERFLOW;
            }
            nuint subresourceByteSize = subDepth * depthPitch;
            if (pDst != null)
            {
                ref D3D12_MEMCPY_DEST dst = ref pDst[s];
                // This data will be returned straight from the API to satisfy Map. So, strides/ alignment must be API-correct.
                dst.pData = (void*)(totalByteSize);
                Debug.Assert((s != 0) || (dst.pData == null));
                dst.RowPitch = rowPitch;
                dst.SlicePitch = depthPitch;
            }
            // Align the subresource size.
            Debug.Assert(
                (MAP_ALIGN_REQUIREMENT & (MAP_ALIGN_REQUIREMENT - 1)) == 0,
                "This code expects MAP_ALIGN_REQUIREMENT to be a power of 2."
            );
            nuint subresourceByteSizeAligned = subresourceByteSize + MAP_ALIGN_REQUIREMENT - 1;
            subresourceByteSizeAligned &= ~(MAP_ALIGN_REQUIREMENT - 1u);
            totalByteSize += subresourceByteSizeAligned;
            // Iterate over mip levels and array elements
            if (++iM >= mipLevels)
            {
                iM = 0;
                subWidth = width;
                subHeight = height;
                subDepth = depth;
            }
            else
            {
                subWidth /= ((1 == subWidth) ? 1u : 2u);
                subHeight /= ((1 == subHeight) ? 1u : 2u);
                subDepth /= ((1 == subDepth) ? 1u : 2u);
            }
        }
        return S_OK;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT CalculateResourceSize(
        uint width,
        uint height,
        uint depth,
        DXGI_FORMAT format,
        uint mipLevels,
        uint subresources,
        [NativeTypeName("SIZE_T &")] out nuint totalByteSize,
        Ref<D3D12_MEMCPY_DEST> pDst = default
    )
    {
        fixed (D3D12_MEMCPY_DEST* __dsl_pDst = pDst)
        {
            return (HRESULT)CalculateResourceSize(
                width,
                height,
                depth,
                format,
                mipLevels,
                subresources,
                out totalByteSize,
                __dsl_pDst
            );
        }
    }

    public static bool CanBeCastEvenFullyTyped(DXGI_FORMAT Format, D3D_FEATURE_LEVEL fl)
    {
        //SRGB can be cast away/back, and XR_BIAS can be cast to/from UNORM
        switch (fl)
        {
            case D3D_FEATURE_LEVEL_1_0_GENERIC:
            case D3D_FEATURE_LEVEL_1_0_CORE:
            {
                return false;
            }
            default:
            {
                break;
            }
        }
        switch (Format)
        {
            case DXGI_FORMAT_R8G8B8A8_UNORM:
            case DXGI_FORMAT_R8G8B8A8_UNORM_SRGB:
            case DXGI_FORMAT_B8G8R8A8_UNORM:
            case DXGI_FORMAT_B8G8R8A8_UNORM_SRGB:
            {
                return true;
            }
            case DXGI_FORMAT_R10G10B10A2_UNORM:
            case DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM:
            {
                return fl >= D3D_FEATURE_LEVEL_10_0;
            }
            default:
            {
                return false;
            }
        }
    }

    public static bool DecodeHistogramAllowedForOutputFormatSupport(DXGI_FORMAT Format)
    {
        return (Format == DXGI_FORMAT_NV12) || (Format == DXGI_FORMAT_P010);
    }

    public static bool DepthOnlyFormat(DXGI_FORMAT Format)
    {
        switch (Format)
        {
            case DXGI_FORMAT_D32_FLOAT:
            case DXGI_FORMAT_D16_UNORM:
            {
                return true;
            }
            default:
            {
                return false;
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static HRESULT DivideAndRoundUp(
        uint dividend,
        uint divisor,
        [NativeTypeName("UINT &")] out uint result
    )
    {
        HRESULT hr = Safe_UIntAdd(dividend, (divisor - 1), out uint adjustedDividend);
        result = SUCCEEDED(hr) ? (adjustedDividend / divisor) : 0;
        return hr;
    }

    [Transformed]
    public static MaybeBool<BOOL> DX9TextureFormat(DXGI_FORMAT Format) =>
        (MaybeBool<BOOL>)(BOOL)DX9TextureFormatRaw(Format);

    public static BOOL DX9TextureFormatRaw(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefThrow(Format).bDX9TextureFormat;
    }

    [Transformed]
    public static MaybeBool<BOOL> DX9VertexOrIndexFormat(DXGI_FORMAT Format) =>
        (MaybeBool<BOOL>)(BOOL)DX9VertexOrIndexFormatRaw(Format);

    public static BOOL DX9VertexOrIndexFormatRaw(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefThrow(Format).bDX9VertexOrIndexFormat;
    }

    public static bool FamilySupportsStencil(DXGI_FORMAT Format)
    {
        switch (GetParentFormat(Format))
        {
            case DXGI_FORMAT_R32G8X24_TYPELESS:
            case DXGI_FORMAT_R24G8_TYPELESS:
            {
                return true;
            }
            default:
            {
                return false;
            }
        }
    }

    public static bool FloatAndNotFloatFormats(DXGI_FORMAT FormatA, DXGI_FORMAT FormatB)
    {
        uint NumComponents = uint.Min(
            GetNumComponentsInFormat(FormatA),
            GetNumComponentsInFormat(FormatB)
        );
        for (uint c = 0; c < NumComponents; c++)
        {
            D3D_FORMAT_COMPONENT_INTERPRETATION fciA = GetFormatComponentInterpretation(FormatA, c);
            D3D_FORMAT_COMPONENT_INTERPRETATION fciB = GetFormatComponentInterpretation(FormatB, c);
            if ((fciA != fciB) && ((fciA == D3DFCI_FLOAT) || (fciB == D3DFCI_FLOAT)))
            {
                return true;
            }
        }
        return false;
    }

    [Transformed]
    public static MaybeBool<BOOL> FloatNormTextureFormat(DXGI_FORMAT Format) =>
        (MaybeBool<BOOL>)(BOOL)FloatNormTextureFormatRaw(Format);

    public static BOOL FloatNormTextureFormatRaw(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefThrow(Format).bFloatNormFormat;
    }

    public static bool FormatExists(DXGI_FORMAT Format)
    {
        return GetFormat((nuint)(Format)) != (DXGI_FORMAT)(-1);
    }

    public static bool FormatExistsInHeader(DXGI_FORMAT Format, bool bExternalHeader = true)
    {
        uint Index = GetDetailTableIndex(Format);
        if (
            (unchecked((uint)(-1)) == Index)
            || (bExternalHeader && GetFormatDetail(Format).bInternal)
        )
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static void Get4KTileShape(
        D3D12_TILE_SHAPE* pTileShape,
        DXGI_FORMAT Format,
        D3D12_RESOURCE_DIMENSION Dimension,
        uint SampleCount
    )
    {
        uint BPU = GetBitsPerUnit(Format);
        switch (Dimension)
        {
            case D3D12_RESOURCE_DIMENSION_UNKNOWN:
            case D3D12_RESOURCE_DIMENSION_BUFFER:
            case D3D12_RESOURCE_DIMENSION_TEXTURE1D:
            {
                Debug.Assert(!IsBlockCompressFormat(Format));
                pTileShape->WidthInTexels = (BPU == 0) ? 4096 : 4096 * 8 / BPU;
                pTileShape->HeightInTexels = 1;
                pTileShape->DepthInTexels = 1;
                break;
            }
            case D3D12_RESOURCE_DIMENSION_TEXTURE2D:
            {
                pTileShape->DepthInTexels = 1;
                if (IsBlockCompressFormat(Format))
                {
                    // Currently only supported block sizes are 64 and 128.
                    // These equations calculate the size in texels for a tile. It relies on the fact that 16*16*16 blocks fit in a tile if the block size is 128 bits.
                    Debug.Assert(BPU == 64 || BPU == 128);
                    pTileShape->WidthInTexels = 16 * GetWidthAlignment(Format);
                    pTileShape->HeightInTexels = 16 * GetHeightAlignment(Format);
                    if (BPU == 64)
                    {
                        // If bits per block are 64 we double width so it takes up the full tile size.
                        // This is only true for BC1 and BC4
                        Debug.Assert(
                            (
                                Format >= DXGI_FORMAT_BC1_TYPELESS
                                && Format <= DXGI_FORMAT_BC1_UNORM_SRGB
                            )
                                || (
                                    Format >= DXGI_FORMAT_BC4_TYPELESS
                                    && Format <= DXGI_FORMAT_BC4_SNORM
                                )
                        );
                        pTileShape->WidthInTexels *= 2;
                    }
                }
                else
                {
                    if (BPU <= 8)
                    {
                        pTileShape->WidthInTexels = 64;
                        pTileShape->HeightInTexels = 64;
                    }
                    else if (BPU <= 16)
                    {
                        pTileShape->WidthInTexels = 64;
                        pTileShape->HeightInTexels = 32;
                    }
                    else if (BPU <= 32)
                    {
                        pTileShape->WidthInTexels = 32;
                        pTileShape->HeightInTexels = 32;
                    }
                    else if (BPU <= 64)
                    {
                        pTileShape->WidthInTexels = 32;
                        pTileShape->HeightInTexels = 16;
                    }
                    else if (BPU <= 128)
                    {
                        pTileShape->WidthInTexels = 16;
                        pTileShape->HeightInTexels = 16;
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                    if (SampleCount <= 1)
                    {
                        // Do nothing
                    }
                    else if (SampleCount <= 2)
                    {
                        pTileShape->WidthInTexels /= 2;
                        pTileShape->HeightInTexels /= 1;
                    }
                    else if (SampleCount <= 4)
                    {
                        pTileShape->WidthInTexels /= 2;
                        pTileShape->HeightInTexels /= 2;
                    }
                    else if (SampleCount <= 8)
                    {
                        pTileShape->WidthInTexels /= 4;
                        pTileShape->HeightInTexels /= 2;
                    }
                    else if (SampleCount <= 16)
                    {
                        pTileShape->WidthInTexels /= 4;
                        pTileShape->HeightInTexels /= 4;
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                    Debug.Assert(GetWidthAlignment(Format) == 1);
                    Debug.Assert(GetHeightAlignment(Format) == 1);
                    Debug.Assert(GetDepthAlignment(Format) == 1);
                }
                break;
            }
            case D3D12_RESOURCE_DIMENSION_TEXTURE3D:
                {
                    if (IsBlockCompressFormat(Format))
                    {
                        // Currently only supported block sizes are 64 and 128.
                        // These equations calculate the size in texels for a tile. It relies on the fact that 16*16*16 blocks fit in a tile if the block size is 128 bits.
                        Debug.Assert(BPU == 64 || BPU == 128);
                        pTileShape->WidthInTexels = 8 * GetWidthAlignment(Format);
                        pTileShape->HeightInTexels = 8 * GetHeightAlignment(Format);
                        pTileShape->DepthInTexels = 4;
                        if (BPU == 64)
                        {
                            // If bits per block are 64 we double width so it takes up the full tile size.
                            // This is only true for BC1 and BC4
                            Debug.Assert(
                                (
                                    Format >= DXGI_FORMAT_BC1_TYPELESS
                                    && Format <= DXGI_FORMAT_BC1_UNORM_SRGB
                                )
                                    || (
                                        Format >= DXGI_FORMAT_BC4_TYPELESS
                                        && Format <= DXGI_FORMAT_BC4_SNORM
                                    )
                            );
                            pTileShape->DepthInTexels *= 2;
                        }
                    }
                    else
                    {
                        if (BPU <= 8)
                        {
                            pTileShape->WidthInTexels = 16;
                            pTileShape->HeightInTexels = 16;
                            pTileShape->DepthInTexels = 16;
                        }
                        else if (BPU <= 16)
                        {
                            pTileShape->WidthInTexels = 16;
                            pTileShape->HeightInTexels = 16;
                            pTileShape->DepthInTexels = 8;
                        }
                        else if (BPU <= 32)
                        {
                            pTileShape->WidthInTexels = 16;
                            pTileShape->HeightInTexels = 8;
                            pTileShape->DepthInTexels = 8;
                        }
                        else if (BPU <= 64)
                        {
                            pTileShape->WidthInTexels = 8;
                            pTileShape->HeightInTexels = 8;
                            pTileShape->DepthInTexels = 8;
                        }
                        else if (BPU <= 128)
                        {
                            pTileShape->WidthInTexels = 8;
                            pTileShape->HeightInTexels = 8;
                            pTileShape->DepthInTexels = 4;
                        }
                        else
                        {
                            Debug.Assert(false);
                        }
                        Debug.Assert(GetWidthAlignment(Format) == 1);
                        Debug.Assert(GetHeightAlignment(Format) == 1);
                        Debug.Assert(GetDepthAlignment(Format) == 1);
                    }
                }
                break;
        }
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Get4KTileShape(
        Ref<D3D12_TILE_SHAPE> pTileShape,
        DXGI_FORMAT Format,
        D3D12_RESOURCE_DIMENSION Dimension,
        uint SampleCount
    )
    {
        fixed (D3D12_TILE_SHAPE* __dsl_pTileShape = pTileShape)
        {
            Get4KTileShape(__dsl_pTileShape, Format, Dimension, SampleCount);
        }
    }

    [return: NativeTypeName("UINT8")]
    public static byte GetAddressingBitsPerAlignedSize(DXGI_FORMAT Format)
    {
        uint byteAlignment = GetByteAlignment(Format);
        byte addressBitsPerElement;
        switch (byteAlignment)
        {
            case 1:
            {
                addressBitsPerElement = 0;
                break;
            }
            case 2:
            {
                addressBitsPerElement = 1;
                break;
            }
            case 4:
            {
                addressBitsPerElement = 2;
                break;
            }
            case 8:
            {
                addressBitsPerElement = 3;
                break;
            }
            case 16:
            {
                addressBitsPerElement = 4;
                break;
            }
            // The format is not supported
            default:
            {
                return unchecked((byte)(-1));
            }
        }
        return addressBitsPerElement;
    }

    public static uint GetBitsPerComponent(DXGI_FORMAT Format, uint AbsoluteComponentIndex)
    {
        if (AbsoluteComponentIndex > 3)
        {
            ThrowHR(E_FAIL);
        }
        return Unsafe.Add(
            ref MemoryMarshal.GetReference(
                (ReadOnlySpan<byte>)(GetFormatDetailRefThrow(Format).BitsPerComponent)
            ),
            AbsoluteComponentIndex
        );
    }

    public static uint GetBitsPerStencil(DXGI_FORMAT Format)
    {
        uint Index = GetDetailTableIndexThrow(Format);
        if (
            (GetFormatDetailRef(Index).TypeLevel != D3DFTL_PARTIAL_TYPE)
            && (GetFormatDetailRef(Index).TypeLevel != D3DFTL_FULL_TYPE)
        )
        {
            return 0;
        }
        for (uint comp = 0; comp < 4; comp++)
        {
            D3D_FORMAT_COMPONENT_NAME name = D3DFCN_D;
            switch (comp)
            {
                case 0:
                {
                    name = GetFormatDetailRef(Index).ComponentName0;
                    break;
                }
                case 1:
                {
                    name = GetFormatDetailRef(Index).ComponentName1;
                    break;
                }
                case 2:
                {
                    name = GetFormatDetailRef(Index).ComponentName2;
                    break;
                }
                case 3:
                {
                    name = GetFormatDetailRef(Index).ComponentName3;
                    break;
                }
            }
            if (name == D3DFCN_S)
            {
                return Unsafe.Add(
                    ref MemoryMarshal.GetReference(
                        (ReadOnlySpan<byte>)(GetFormatDetailRef(Index).BitsPerComponent)
                    ),
                    comp
                );
            }
        }
        return 0;
    }

    // Returns bits per pixel unless format is a block compress format then it returns bits per block.
    // Use IsBlockCompressFormat() to determine if block size is returned.
    public static uint GetBitsPerUnit(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefNoThrow(Format).BitsPerUnit;
    }

    public static uint GetBitsPerUnitThrow(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefThrow(Format).BitsPerUnit;
    }

    public static uint GetByteAlignment(DXGI_FORMAT Format)
    {
        uint bits = GetBitsPerUnit(Format);
        if (!IsBlockCompressFormat(Format))
        {
            bits *=
                GetWidthAlignment(Format) * GetHeightAlignment(Format) * GetDepthAlignment(Format);
        }
        Debug.Assert((bits & 0x7) == 0); // Unit must be byte-aligned
        return bits >> 3;
    }

    public static D3D_FORMAT_COMPONENT_NAME GetComponentName(
        DXGI_FORMAT Format,
        uint AbsoluteComponentIndex
    )
    {
        Unsafe.SkipInit(out D3D_FORMAT_COMPONENT_NAME name);
        switch (AbsoluteComponentIndex)
        {
            case 0:
            {
                name = GetFormatDetailRefThrow(Format).ComponentName0;
                break;
            }
            case 1:
            {
                name = GetFormatDetailRefThrow(Format).ComponentName1;
                break;
            }
            case 2:
            {
                name = GetFormatDetailRefThrow(Format).ComponentName2;
                break;
            }
            case 3:
            {
                name = GetFormatDetailRefThrow(Format).ComponentName3;
                break;
            }
            default:
            {
                ThrowHR(E_FAIL);
                break;
            }
        }
        return name;
    }

    public static uint GetDepthAlignment(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefThrow(Format).DepthAlignment;
    }

    public static uint GetDetailTableIndex(DXGI_FORMAT Format)
    {
        if ((uint)(Format) < s_FormatDetail.Length)
        {
            Debug.Assert(GetFormatDetailRef(Format).DXGIFormat == Format);
            return (uint)(Format);
        }
        return unchecked((uint)(-1));
    }

    public static uint GetDetailTableIndexNoThrow(DXGI_FORMAT Format)
    {
        uint Index = GetDetailTableIndex(Format);
        Debug.Assert(unchecked((uint)(-1)) != Index); // Needs to be validated externally.
        return Index;
    }

    public static uint GetDetailTableIndexThrow(DXGI_FORMAT Format)
    {
        uint Index = GetDetailTableIndex(Format);
        if (unchecked((uint)(-1)) == Index)
        {
            ThrowHR(E_FAIL);
        }
        return Index;
    }

    public static DXGI_FORMAT GetFormat([NativeTypeName("SIZE_T")] nuint Index)
    {
        if (Index < GetNumFormats())
        {
            return GetFormatDetailRef(Index).DXGIFormat;
        }
        return (DXGI_FORMAT)(-1);
    }

    [return: NativeTypeName("const DXGI_FORMAT *")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<DXGI_FORMAT> GetFormatCastSet(DXGI_FORMAT Format) =>
        (DXGI_FORMAT*)GetFormatCastSetRaw(Format);

    [return: NativeTypeName("const DXGI_FORMAT *")]
    public static DXGI_FORMAT* GetFormatCastSetRaw(DXGI_FORMAT Format)
    {
        return GetFormatDetailRef(Format).pDefaultFormatCastSet;
    }

    public static D3D_FORMAT_COMPONENT_INTERPRETATION GetFormatComponentInterpretation(
        DXGI_FORMAT Format,
        uint AbsoluteComponentIndex
    )
    {
        D3D_FORMAT_COMPONENT_INTERPRETATION interp = new D3D_FORMAT_COMPONENT_INTERPRETATION();
        switch (AbsoluteComponentIndex)
        {
            case 0:
            {
                interp = GetFormatDetailRefThrow(Format).ComponentInterpretation0;
                break;
            }
            case 1:
            {
                interp = GetFormatDetailRefThrow(Format).ComponentInterpretation1;
                break;
            }
            case 2:
            {
                interp = GetFormatDetailRefThrow(Format).ComponentInterpretation2;
                break;
            }
            case 3:
            {
                interp = GetFormatDetailRefThrow(Format).ComponentInterpretation3;
                break;
            }
            default:
            {
                ThrowHR(E_FAIL);
                break;
            }
        }
        return interp;
    }

    [return: NativeTypeName("const FORMAT_DETAILS *")]
    private static ref readonly FORMAT_DETAIL GetFormatDetail(DXGI_FORMAT Format)
    {
        uint Index = GetDetailTableIndex(Format);
        if (unchecked((uint)(-1)) == Index)
        {
            return ref Unsafe.NullRef<FORMAT_DETAIL>();
        }
        return ref GetFormatDetailRef(Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ref readonly FORMAT_DETAIL GetFormatDetailRef(nuint Index)
    {
        return ref Unsafe.Add(ref MemoryMarshal.GetArrayDataReference(s_FormatDetail), Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ref readonly FORMAT_DETAIL GetFormatDetailRef(DXGI_FORMAT Format)
    {
        return ref Unsafe.Add(
            ref MemoryMarshal.GetArrayDataReference(s_FormatDetail),
            (uint)(Format)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ref readonly FORMAT_DETAIL GetFormatDetailRefNoThrow(DXGI_FORMAT Format)
    {
        return ref Unsafe.Add(
            ref MemoryMarshal.GetArrayDataReference(s_FormatDetail),
            GetDetailTableIndexNoThrow(Format)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ref readonly FORMAT_DETAIL GetFormatDetailRefThrow(DXGI_FORMAT Format)
    {
        return ref Unsafe.Add(
            ref MemoryMarshal.GetArrayDataReference(s_FormatDetail),
            GetDetailTableIndexThrow(Format)
        );
    }

    public static void GetFormatReturnTypes(
        DXGI_FORMAT Format,
        D3D_FORMAT_COMPONENT_INTERPRETATION* pInterpretations
    )
    {
        uint Index = GetDetailTableIndexThrow(Format);
        pInterpretations[(int)(D3D10_SB_4_COMPONENT_R)] = GetFormatDetailRef(
            Index
        ).ComponentInterpretation0;
        pInterpretations[(int)(D3D10_SB_4_COMPONENT_G)] = GetFormatDetailRef(
            Index
        ).ComponentInterpretation1;
        pInterpretations[(int)(D3D10_SB_4_COMPONENT_B)] = GetFormatDetailRef(
            Index
        ).ComponentInterpretation2;
        pInterpretations[(int)(D3D10_SB_4_COMPONENT_A)] = GetFormatDetailRef(
            Index
        ).ComponentInterpretation3;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetFormatReturnTypes(
        DXGI_FORMAT Format,
        Ref<D3D_FORMAT_COMPONENT_INTERPRETATION> pInterpretations
    )
    {
        fixed (D3D_FORMAT_COMPONENT_INTERPRETATION* __dsl_pInterpretations = pInterpretations)
        {
            GetFormatReturnTypes(Format, __dsl_pInterpretations);
        }
    }

    [return: NativeTypeName("const FORMAT_DETAIL *")]
    public static ReadOnlySpan<FORMAT_DETAIL> GetFormatTable()
    {
        return s_FormatDetail;
    }

    public static uint GetHeightAlignment(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefThrow(Format).HeightAlignment;
    }

    public static D3D_FEATURE_LEVEL GetHighestDefinedFeatureLevel()
    {
        return D3D_FEATURE_LEVEL_12_2;
    }

    public static D3D_FORMAT_LAYOUT GetLayout(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefNoThrow(Format).Layout;
    }

    public static void GetMipDimensions(
        [NativeTypeName("UINT8")] byte mipSlice,
        [NativeTypeName("UINT64")] ulong* pWidth,
        [NativeTypeName("UINT64")] ulong* pHeight = null,
        [NativeTypeName("UINT64")] ulong* pDepth = null
    )
    {
        uint denominator = (1u << mipSlice); // 2 ^ subresource
        ulong mipWidth = *pWidth / denominator;
        ulong mipHeight = (pHeight != null) ? *pHeight / denominator : 1;
        ulong mipDepth = (pDepth != null) ? *pDepth / denominator : 1;
        // Adjust dimensions for degenerate mips
        if (mipHeight == 0)
        {
            mipHeight = 1;
        }
        if (mipWidth == 0)
        {
            mipWidth = 1;
        }
        if (mipDepth == 0)
        {
            mipDepth = 1;
        }
        *pWidth = mipWidth;
        if (pHeight != null)
        {
            *pHeight = mipHeight;
        }
        if (pDepth != null)
        {
            *pDepth = mipDepth;
        }
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetMipDimensions(
        [NativeTypeName("UINT8")] byte mipSlice,
        [NativeTypeName("UINT64")] Ref<ulong> pWidth,
        [NativeTypeName("UINT64")] Ref<ulong> pHeight = default,
        [NativeTypeName("UINT64")] Ref<ulong> pDepth = default
    )
    {
        fixed (ulong* __dsl_pDepth = pDepth)
        fixed (ulong* __dsl_pHeight = pHeight)
        fixed (ulong* __dsl_pWidth = pWidth)
        {
            GetMipDimensions(mipSlice, __dsl_pWidth, __dsl_pHeight, __dsl_pDepth);
        }
    }

    [return: NativeTypeName("LPCSTR")]
    public static string GetName(DXGI_FORMAT Format, bool bHideInternalFormats = true)
    {
        uint Index = GetDetailTableIndex(Format);
        if (
            unchecked((uint)(-1)) == Index
            || (bHideInternalFormats && GetFormatDetail(Format).bInternal)
        )
        {
            return "Unrecognized";
        }
        else
        {
            return Unsafe.Add(ref MemoryMarshal.GetArrayDataReference(s_FormatNames), Index);
        }
    }

    public static uint GetNumComponentsInFormat(DXGI_FORMAT Format)
    {
        uint n = 0;
        uint Index = GetDetailTableIndexThrow(Format);
        for (uint comp = 0; comp < 4; comp++)
        {
            D3D_FORMAT_COMPONENT_NAME name = D3DFCN_D;
            switch (comp)
            {
                case 0:
                {
                    name = GetFormatDetailRef(Index).ComponentName0;
                    break;
                }
                case 1:
                {
                    name = GetFormatDetailRef(Index).ComponentName1;
                    break;
                }
                case 2:
                {
                    name = GetFormatDetailRef(Index).ComponentName2;
                    break;
                }
                case 3:
                {
                    name = GetFormatDetailRef(Index).ComponentName3;
                    break;
                }
            }
            if (name != D3DFCN_X)
            {
                n++;
            }
        }
        return n;
    }

    public static uint GetNumFormats()
    {
        return s_NumFormats;
    }

    public static DXGI_FORMAT GetParentFormat(DXGI_FORMAT Format)
    {
        return GetFormatDetailRef(Format).ParentFormat;
    }

    [return: NativeTypeName("UINT8")]
    public static byte GetPlaneCount(DXGI_FORMAT Format)
    {
        switch (GetParentFormat(Format))
        {
            case DXGI_FORMAT_NV12:
            case DXGI_FORMAT_NV11:
            case DXGI_FORMAT_P208:
            case DXGI_FORMAT_P016:
            case DXGI_FORMAT_P010:
            case DXGI_FORMAT_R24G8_TYPELESS:
            case DXGI_FORMAT_R32G8X24_TYPELESS:
            {
                return 2;
            }
            case DXGI_FORMAT_V208:
            case DXGI_FORMAT_V408:
            {
                return 3;
            }
            default:
            {
                return 1;
            }
        }
    }

    // Maps resource format + view format to a plane index for resource formats where the plane index can be inferred from this information.
    // For planar formats where the plane index is ambiguous given this information (examples: V208, V408), this function returns 0.
    // This function returns 0 for non-planar formats.
    [return: NativeTypeName("UINT8")]
    public static byte GetPlaneSliceFromViewFormat(
        DXGI_FORMAT ResourceFormat,
        DXGI_FORMAT ViewFormat
    )
    {
        switch (GetParentFormat(ResourceFormat))
        {
            case DXGI_FORMAT_R24G8_TYPELESS:
            {
                switch (ViewFormat)
                {
                    case DXGI_FORMAT_R24_UNORM_X8_TYPELESS:
                    {
                        return 0;
                    }
                    case DXGI_FORMAT_X24_TYPELESS_G8_UINT:
                    {
                        return 1;
                    }
                    default:
                    {
                        Debug.Assert(false);
                        break;
                    }
                }
                break;
            }
            case DXGI_FORMAT_R32G8X24_TYPELESS:
            {
                switch (ViewFormat)
                {
                    case DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS:
                    {
                        return 0;
                    }
                    case DXGI_FORMAT_X32_TYPELESS_G8X24_UINT:
                    {
                        return 1;
                    }
                    default:
                    {
                        Debug.Assert(false);
                        break;
                    }
                }
                break;
            }
            case DXGI_FORMAT_NV12:
            case DXGI_FORMAT_NV11:
            case DXGI_FORMAT_P208:
            {
                switch (ViewFormat)
                {
                    case DXGI_FORMAT_R8_UNORM:
                    case DXGI_FORMAT_R8_UINT:
                    {
                        return 0;
                    }
                    case DXGI_FORMAT_R8G8_UNORM:
                    case DXGI_FORMAT_R8G8_UINT:
                    {
                        return 1;
                    }
                    default:
                    {
                        Debug.Assert(false);
                        break;
                    }
                }
                break;
            }
            case DXGI_FORMAT_P016:
            case DXGI_FORMAT_P010:
            {
                switch (ViewFormat)
                {
                    case DXGI_FORMAT_R16_UNORM:
                    case DXGI_FORMAT_R16_UINT:
                    {
                        return 0;
                    }
                    case DXGI_FORMAT_R16G16_UNORM:
                    case DXGI_FORMAT_R16G16_UINT:
                    case DXGI_FORMAT_R32_UINT:
                    {
                        return 1;
                    }
                    default:
                    {
                        Debug.Assert(false);
                        break;
                    }
                }
                break;
            }
            default:
            {
                break;
            }
        }
        return 0;
    }

    public static void GetPlaneSubsampledSizeAndFormatForCopyableLayout(
        uint PlaneSlice,
        DXGI_FORMAT Format,
        uint Width,
        uint Height,
        [NativeTypeName("DXGI_FORMAT &")] out DXGI_FORMAT PlaneFormat,
        [NativeTypeName("UINT &")] out uint MinPlanePitchWidth,
        [NativeTypeName("UINT &")] out uint PlaneWidth,
        [NativeTypeName("UINT &")] out uint PlaneHeight
    )
    {
        Unsafe.SkipInit(out PlaneFormat);
        Unsafe.SkipInit(out MinPlanePitchWidth);
        Unsafe.SkipInit(out PlaneWidth);
        Unsafe.SkipInit(out PlaneHeight);
        DXGI_FORMAT ParentFormat = GetParentFormat(Format);
        if (PlanarRaw(ParentFormat))
        {
            switch (ParentFormat)
            {
                // YCbCr 4:2:0
                case DXGI_FORMAT_NV12:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneFormat = DXGI_FORMAT_R8_TYPELESS;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            break;
                        }
                        case 1:
                        {
                            PlaneFormat = DXGI_FORMAT_R8G8_TYPELESS;
                            PlaneWidth = (Width + 1) >> 1;
                            PlaneHeight = (Height + 1) >> 1;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    MinPlanePitchWidth = PlaneWidth;
                    break;
                }
                case DXGI_FORMAT_P010:
                case DXGI_FORMAT_P016:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneFormat = DXGI_FORMAT_R16_TYPELESS;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            break;
                        }
                        case 1:
                        {
                            PlaneFormat = DXGI_FORMAT_R16G16_TYPELESS;
                            PlaneWidth = (Width + 1) >> 1;
                            PlaneHeight = (Height + 1) >> 1;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    MinPlanePitchWidth = PlaneWidth;
                    break;
                }
                // YCbCr 4:2:2
                case DXGI_FORMAT_P208:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneFormat = DXGI_FORMAT_R8_TYPELESS;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            break;
                        }
                        case 1:
                        {
                            PlaneFormat = DXGI_FORMAT_R8G8_TYPELESS;
                            PlaneWidth = (Width + 1) >> 1;
                            PlaneHeight = Height;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    MinPlanePitchWidth = PlaneWidth;
                    break;
                }
                // YCbCr 4:4:0
                case DXGI_FORMAT_V208:
                {
                    PlaneFormat = DXGI_FORMAT_R8_TYPELESS;
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            break;
                        }
                        case 1:
                        case 2:
                        {
                            PlaneWidth = Width;
                            PlaneHeight = (Height + 1) >> 1;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    MinPlanePitchWidth = PlaneWidth;
                    break;
                }
                // YCbCr 4:4:4
                case DXGI_FORMAT_V408:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        case 1:
                        case 2:
                        {
                            PlaneFormat = DXGI_FORMAT_R8_TYPELESS;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            MinPlanePitchWidth = PlaneWidth;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    break;
                }
                // YCbCr 4:1:1
                case DXGI_FORMAT_NV11:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneFormat = DXGI_FORMAT_R8_TYPELESS;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            MinPlanePitchWidth = Width;
                            break;
                        }
                        case 1:
                        {
                            PlaneFormat = DXGI_FORMAT_R8G8_TYPELESS;
                            PlaneWidth = (Width + 3) >> 2;
                            PlaneHeight = Height;
                            // NV11 has unused padding to the right of the chroma plane in the RowMajor (linear) copyable layout.
                            MinPlanePitchWidth = (Width + 1) >> 1;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    break;
                }
                case DXGI_FORMAT_R32G8X24_TYPELESS:
                case DXGI_FORMAT_R24G8_TYPELESS:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneFormat = DXGI_FORMAT_R32_TYPELESS;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            MinPlanePitchWidth = Width;
                            break;
                        }
                        case 1:
                        {
                            PlaneFormat = DXGI_FORMAT_R8_TYPELESS;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            MinPlanePitchWidth = Width;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    break;
                }
                default:
                {
                    Debug.Assert(false);
                    break;
                }
            }
        }
        else
        {
            Debug.Assert(PlaneSlice == 0);
            PlaneFormat = Format;
            PlaneWidth = Width;
            PlaneHeight = Height;
            MinPlanePitchWidth = PlaneWidth;
        }
    }

    public static void GetTileShape(
        D3D12_TILE_SHAPE* pTileShape,
        DXGI_FORMAT Format,
        D3D12_RESOURCE_DIMENSION Dimension,
        uint SampleCount
    )
    {
        uint BPU = GetBitsPerUnit(Format);
        switch (Dimension)
        {
            case D3D12_RESOURCE_DIMENSION_UNKNOWN:
            case D3D12_RESOURCE_DIMENSION_BUFFER:
            case D3D12_RESOURCE_DIMENSION_TEXTURE1D:
            {
                Debug.Assert(!IsBlockCompressFormat(Format));
                pTileShape->WidthInTexels =
                    (BPU == 0)
                        ? D3D12_TILED_RESOURCE_TILE_SIZE_IN_BYTES
                        : D3D12_TILED_RESOURCE_TILE_SIZE_IN_BYTES * 8 / BPU;
                pTileShape->HeightInTexels = 1;
                pTileShape->DepthInTexels = 1;
                break;
            }
            case D3D12_RESOURCE_DIMENSION_TEXTURE2D:
            {
                if (IsBlockCompressFormat(Format))
                {
                    // Currently only supported block sizes are 64 and 128.
                    // These equations calculate the size in texels for a tile. It relies on the fact that 64 * 64 blocks fit in a tile if the block size is 128 bits.
                    Debug.Assert(BPU == 64 || BPU == 128);
                    pTileShape->WidthInTexels = 64 * GetWidthAlignment(Format);
                    pTileShape->HeightInTexels = 64 * GetHeightAlignment(Format);
                    pTileShape->DepthInTexels = 1;
                    if (BPU == 64)
                    {
                        // If bits per block are 64 we double width so it takes up the full tile size.
                        // This is only true for BC1 and BC4
                        Debug.Assert(
                            (
                                Format >= DXGI_FORMAT_BC1_TYPELESS
                                && Format <= DXGI_FORMAT_BC1_UNORM_SRGB
                            )
                                || (
                                    Format >= DXGI_FORMAT_BC4_TYPELESS
                                    && Format <= DXGI_FORMAT_BC4_SNORM
                                )
                        );
                        pTileShape->WidthInTexels *= 2;
                    }
                }
                else
                {
                    pTileShape->DepthInTexels = 1;
                    if (BPU <= 8)
                    {
                        pTileShape->WidthInTexels = 256;
                        pTileShape->HeightInTexels = 256;
                    }
                    else if (BPU <= 16)
                    {
                        pTileShape->WidthInTexels = 256;
                        pTileShape->HeightInTexels = 128;
                    }
                    else if (BPU <= 32)
                    {
                        pTileShape->WidthInTexels = 128;
                        pTileShape->HeightInTexels = 128;
                    }
                    else if (BPU <= 64)
                    {
                        pTileShape->WidthInTexels = 128;
                        pTileShape->HeightInTexels = 64;
                    }
                    else if (BPU <= 128)
                    {
                        pTileShape->WidthInTexels = 64;
                        pTileShape->HeightInTexels = 64;
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                    if (SampleCount <= 1)
                    {
                        // Do nothing
                    }
                    else if (SampleCount <= 2)
                    {
                        pTileShape->WidthInTexels /= 2;
                        pTileShape->HeightInTexels /= 1;
                    }
                    else if (SampleCount <= 4)
                    {
                        pTileShape->WidthInTexels /= 2;
                        pTileShape->HeightInTexels /= 2;
                    }
                    else if (SampleCount <= 8)
                    {
                        pTileShape->WidthInTexels /= 4;
                        pTileShape->HeightInTexels /= 2;
                    }
                    else if (SampleCount <= 16)
                    {
                        pTileShape->WidthInTexels /= 4;
                        pTileShape->HeightInTexels /= 4;
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                }
                break;
            }
            case D3D12_RESOURCE_DIMENSION_TEXTURE3D:
            {
                if (IsBlockCompressFormat(Format))
                {
                    // Currently only supported block sizes are 64 and 128.
                    // These equations calculate the size in texels for a tile. It relies on the fact that 16*16*16 blocks fit in a tile if the block size is 128 bits.
                    Debug.Assert(BPU == 64 || BPU == 128);
                    pTileShape->WidthInTexels = 16 * GetWidthAlignment(Format);
                    pTileShape->HeightInTexels = 16 * GetHeightAlignment(Format);
                    pTileShape->DepthInTexels = 16 * GetDepthAlignment(Format);
                    if (BPU == 64)
                    {
                        // If bits per block are 64 we double width so it takes up the full tile size.
                        // This is only true for BC1 and BC4
                        Debug.Assert(
                            (
                                Format >= DXGI_FORMAT_BC1_TYPELESS
                                && Format <= DXGI_FORMAT_BC1_UNORM_SRGB
                            )
                                || (
                                    Format >= DXGI_FORMAT_BC4_TYPELESS
                                    && Format <= DXGI_FORMAT_BC4_SNORM
                                )
                        );
                        pTileShape->WidthInTexels *= 2;
                    }
                }
                else if (
                    (Format == DXGI_FORMAT_R8G8_B8G8_UNORM)
                    || (Format == DXGI_FORMAT_G8R8_G8B8_UNORM)
                )
                {
                    //RGBG and GRGB are treated as 2x1 block format
                    pTileShape->WidthInTexels = 64;
                    pTileShape->HeightInTexels = 32;
                    pTileShape->DepthInTexels = 16;
                }
                else
                {
                    // Not a block format so BPU is bits per pixel.
                    Debug.Assert(
                        (GetWidthAlignment(Format) == 1)
                            && (GetHeightAlignment(Format) == 1)
                            && (GetDepthAlignment(Format) != 0)
                    );
                    switch (BPU)
                    {
                        case 8:
                        {
                            pTileShape->WidthInTexels = 64;
                            pTileShape->HeightInTexels = 32;
                            pTileShape->DepthInTexels = 32;
                            break;
                        }
                        case 16:
                        {
                            pTileShape->WidthInTexels = 32;
                            pTileShape->HeightInTexels = 32;
                            pTileShape->DepthInTexels = 32;
                            break;
                        }
                        case 32:
                        {
                            pTileShape->WidthInTexels = 32;
                            pTileShape->HeightInTexels = 32;
                            pTileShape->DepthInTexels = 16;
                            break;
                        }
                        case 64:
                        {
                            pTileShape->WidthInTexels = 32;
                            pTileShape->HeightInTexels = 16;
                            pTileShape->DepthInTexels = 16;
                            break;
                        }
                        case 128:
                        {
                            pTileShape->WidthInTexels = 16;
                            pTileShape->HeightInTexels = 16;
                            pTileShape->DepthInTexels = 16;
                            break;
                        }
                    }
                }
                break;
            }
        }
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetTileShape(
        Ref<D3D12_TILE_SHAPE> pTileShape,
        DXGI_FORMAT Format,
        D3D12_RESOURCE_DIMENSION Dimension,
        uint SampleCount
    )
    {
        fixed (D3D12_TILE_SHAPE* __dsl_pTileShape = pTileShape)
        {
            GetTileShape(__dsl_pTileShape, Format, Dimension, SampleCount);
        }
    }

    public static D3D_FORMAT_TYPE_LEVEL GetTypeLevel(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefNoThrow(Format).TypeLevel;
    }

    public static uint GetWidthAlignment(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefThrow(Format).WidthAlignment;
    }

    public static void GetYCbCrChromaSubsampling(
        DXGI_FORMAT Format,
        [NativeTypeName("UINT &")] out uint HorizontalSubsampling,
        [NativeTypeName("UINT &")] out uint VerticalSubsampling
    )
    {
        switch (Format)
        {
            // YCbCr 4:2:0
            case DXGI_FORMAT_NV12:
            case DXGI_FORMAT_P010:
            case DXGI_FORMAT_P016:
            case DXGI_FORMAT_420_OPAQUE:
            {
                HorizontalSubsampling = 2;
                VerticalSubsampling = 2;
                break;
            }
            // YCbCr 4:2:2
            case DXGI_FORMAT_P208:
            case DXGI_FORMAT_YUY2:
            case DXGI_FORMAT_Y210:
            {
                HorizontalSubsampling = 2;
                VerticalSubsampling = 1;
                break;
            }
            // YCbCr 4:4:0
            case DXGI_FORMAT_V208:
            {
                HorizontalSubsampling = 1;
                VerticalSubsampling = 2;
                break;
            }
            // YCbCr 4:4:4
            case DXGI_FORMAT_AYUV:
            case DXGI_FORMAT_V408:
            case DXGI_FORMAT_Y410:
            case DXGI_FORMAT_Y416:
            {
                // Fallthrough
                goto case DXGI_FORMAT_AI44;
            }
            // YCbCr palletized  4:4:4:
            case DXGI_FORMAT_AI44:
            case DXGI_FORMAT_IA44:
            case DXGI_FORMAT_P8:
            case DXGI_FORMAT_A8P8:
            {
                HorizontalSubsampling = 1;
                VerticalSubsampling = 1;
                break;
            }
            // YCbCr 4:1:1
            case DXGI_FORMAT_NV11:
            {
                HorizontalSubsampling = 4;
                VerticalSubsampling = 1;
                break;
            }
            default:
            {
                // All YCbCr formats should be in this list.
                Debug.Assert(!YUVRaw(Format));
                HorizontalSubsampling = 1;
                VerticalSubsampling = 1;
                break;
            }
        }
    }

    // Returns true if format is block compressed. This function is a helper function for GetBitsPerUnit and
    // if this function returns true then GetBitsPerUnit returns block size.
    public static bool IsBlockCompressFormat(DXGI_FORMAT Format)
    {
        // Returns true if BC1, BC2, BC3, BC4, BC5, BC6, BC7, or ASTC
        return (Format >= DXGI_FORMAT_BC1_TYPELESS && Format <= DXGI_FORMAT_BC5_SNORM)
            || (Format >= DXGI_FORMAT_BC6H_TYPELESS && Format <= DXGI_FORMAT_BC7_UNORM_SRGB);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool IsPow2(uint Val)
    {
        return 0 == (Val & (Val - 1));
    }

    public static bool IsSRGBFormat(DXGI_FORMAT Format)
    {
        uint Index = GetDetailTableIndex(Format);
        if (unchecked((uint)(-1)) == Index)
        {
            return false;
        }
        return GetFormatDetailRef(Index).SRGBFormat;
    }

    public static bool IsSupportedTextureDisplayableFormat(
        DXGI_FORMAT Format,
        bool bMediaFormatOnly
    )
    {
        if (bMediaFormatOnly)
        {
            return (Format == DXGI_FORMAT_NV12) || (Format == DXGI_FORMAT_YUY2);
        }
        else
        {
            return (Format == DXGI_FORMAT_B8G8R8A8_UNORM)
                || (Format == DXGI_FORMAT_R8G8B8A8_UNORM)
                || (Format == DXGI_FORMAT_R16G16B16A16_FLOAT)
                || (Format == DXGI_FORMAT_R10G10B10A2_UNORM)
                || (Format == DXGI_FORMAT_NV12)
                || (Format == DXGI_FORMAT_YUY2);
        }
    }

    public static bool MotionEstimatorAllowedInputFormat(DXGI_FORMAT Format)
    {
        return Format == DXGI_FORMAT_NV12;
    }

    [Transformed]
    public static MaybeBool<BOOL> NonOpaquePlanar(DXGI_FORMAT Format) =>
        (MaybeBool<BOOL>)(BOOL)NonOpaquePlanarRaw(Format);

    public static BOOL NonOpaquePlanarRaw(DXGI_FORMAT Format)
    {
        return PlanarRaw(Format) && !OpaqueRaw(Format);
    }

    public static uint NonOpaquePlaneCount(DXGI_FORMAT Format)
    {
        if (!NonOpaquePlanarRaw(Format))
        {
            return 1;
        }
        // V208 and V408 are the only 3-plane formats.
        return ((Format == DXGI_FORMAT_V208) || (Format == DXGI_FORMAT_V408)) ? 3u : 2u;
    }

    [Transformed]
    public static MaybeBool<BOOL> Opaque(DXGI_FORMAT Format) =>
        (MaybeBool<BOOL>)(BOOL)OpaqueRaw(Format);

    public static BOOL OpaqueRaw(DXGI_FORMAT Format)
    {
        return Format == DXGI_FORMAT_420_OPAQUE;
    }

    [Transformed]
    public static MaybeBool<BOOL> Planar(DXGI_FORMAT Format) =>
        (MaybeBool<BOOL>)(BOOL)PlanarRaw(Format);

    public static BOOL PlanarRaw(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefThrow(Format).bPlanar;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static HRESULT Safe_UIntAdd(
        uint uAugend,
        uint uAddend,
        [NativeTypeName("UINT *")] out uint puResult
    )
    {
        if ((uAugend + uAddend) >= uAugend)
        {
            puResult = (uAugend + uAddend);
            return S_OK;
        }
        puResult = uint.MaxValue;
        return E_FAIL;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static HRESULT Safe_UIntMult(
        uint uMultiplicand,
        uint uMultiplier,
        [NativeTypeName("UINT *")] out uint puResult
    )
    {
        ulong ull64Result = (ulong)(uMultiplicand) * (ulong)(uMultiplier);
        if (ull64Result <= uint.MaxValue)
        {
            puResult = (uint)(ull64Result);
            return S_OK;
        }
        puResult = uint.MaxValue;
        return E_FAIL;
    }

    public static uint Sequential2AbsoluteComponentIndex(
        DXGI_FORMAT Format,
        uint SequentialComponentIndex
    )
    {
        uint n = 0;
        uint Index = GetDetailTableIndexThrow(Format);
        for (uint comp = 0; comp < 4; comp++)
        {
            D3D_FORMAT_COMPONENT_NAME name = (D3D_FORMAT_COMPONENT_NAME)(0);
            switch (comp)
            {
                case 0:
                {
                    name = GetFormatDetailRef(Index).ComponentName0;
                    break;
                }
                case 1:
                {
                    name = GetFormatDetailRef(Index).ComponentName1;
                    break;
                }
                case 2:
                {
                    name = GetFormatDetailRef(Index).ComponentName2;
                    break;
                }
                case 3:
                {
                    name = GetFormatDetailRef(Index).ComponentName3;
                    break;
                }
            }
            if (name != D3DFCN_X)
            {
                if (SequentialComponentIndex == n)
                {
                    return comp;
                }
                n++;
            }
        }
        return unchecked((uint)(-1));
    }

    public static bool SNORMAndUNORMFormats(DXGI_FORMAT FormatA, DXGI_FORMAT FormatB)
    {
        uint NumComponents = uint.Min(
            GetNumComponentsInFormat(FormatA),
            GetNumComponentsInFormat(FormatB)
        );
        for (uint c = 0; c < NumComponents; c++)
        {
            D3D_FORMAT_COMPONENT_INTERPRETATION fciA = GetFormatComponentInterpretation(FormatA, c);
            D3D_FORMAT_COMPONENT_INTERPRETATION fciB = GetFormatComponentInterpretation(FormatB, c);
            if (
                ((fciA == D3DFCI_SNORM) && (fciB == D3DFCI_UNORM))
                || ((fciB == D3DFCI_SNORM) && (fciA == D3DFCI_UNORM))
            )
            {
                return true;
            }
        }
        return false;
    }

    public static bool SupportsSamplerFeedback(DXGI_FORMAT Format)
    {
        switch (Format)
        {
            case DXGI_FORMAT_SAMPLER_FEEDBACK_MIN_MIP_OPAQUE:
            case DXGI_FORMAT_SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE:
            {
                return true;
            }
            default:
            {
                return false;
            }
        }
    }

    [DoesNotReturn]
    private static void ThrowHR(HRESULT hr)
    {
        throw new ExternalException(null, hr);
    }

    // D3D11 has a limitation on typed UAVs (e.g. Texture1D/2D/3D) whereby the only format that can be read is R32_*.  Lots of formats
    // can be written though, with type conversion (e.g. R8G8B8A8_*).  If an API user wants to do image processing in-place, in either
    // the Compute Shader or the Pixel Shader, the only format available is R32_* (since it can be read and written at the same time).
    //
    // We were able to allow resources (Texture1D/2D/3D), created with a format from a small set of families that have 32 bits per element
    // (such as R8G8B8A8_TYPELESS), to be cast to R32_* when creating a UAV.  This means the Compute Shader or Pixel Shader can
    // do simultaneous read+write on the resource when bound as an R32_* UAV, with the caveat that the shader code has to do manual
    // type conversion manually, but later on the resource can be used as an SRV or RT as the desired type (e.g. R8G8B8A8_UNORM), and
    // thus have access to filtering/blending where the hardware knows what the format is.
    //
    // If we didn't have this ability to cast some formats to R32_* UAVs, applications would have to keep an extra allocation around
    // and do a rendering pass that copies from the R32_* UAV to whatever typed resource they really wanted.  For formats not included
    // in this list, such as any format that doesn't have 32-bits per component, as well as some 32-bit per component formats like
    // R24G8 or R11G11B10_FLOAT there is no alternative for an application but to do the extra copy as mentioned, or avoid in-place
    // image editing in favor of ping-ponging between buffers with multiple passes.
    public static bool ValidCastToR32UAV(DXGI_FORMAT from, DXGI_FORMAT to)
    {
        // Allow casting of 32 bit formats to R32_*
        if (
            (
                (to == DXGI_FORMAT_R32_UINT)
                || (to == DXGI_FORMAT_R32_SINT)
                || (to == DXGI_FORMAT_R32_FLOAT)
            )
        )
        {
            if (
                (from == DXGI_FORMAT_R10G10B10A2_TYPELESS)
                || (from == DXGI_FORMAT_R8G8B8A8_TYPELESS)
                || (from == DXGI_FORMAT_B8G8R8A8_TYPELESS)
                || (from == DXGI_FORMAT_B8G8R8X8_TYPELESS)
                || (from == DXGI_FORMAT_R16G16_TYPELESS)
                || (from == DXGI_FORMAT_R32_TYPELESS)
            )
            {
                return true;
            }
        }
        return false;
    }

    [Transformed]
    public static MaybeBool<BOOL> YUV(DXGI_FORMAT Format) => (MaybeBool<BOOL>)(BOOL)YUVRaw(Format);

    public static BOOL YUVRaw(DXGI_FORMAT Format)
    {
        return GetFormatDetailRefThrow(Format).bYUV;
    }
}
