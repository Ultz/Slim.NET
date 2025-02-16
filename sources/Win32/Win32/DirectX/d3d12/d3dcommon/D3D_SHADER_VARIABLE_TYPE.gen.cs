// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE"]/*'/>
public enum D3D_SHADER_VARIABLE_TYPE
{
    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_VOID"]/*'/>

    D3D_SVT_VOID = 0,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_BOOL"]/*'/>

    D3D_SVT_BOOL = 1,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_INT"]/*'/>

    D3D_SVT_INT = 2,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_FLOAT"]/*'/>

    D3D_SVT_FLOAT = 3,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_STRING"]/*'/>

    D3D_SVT_STRING = 4,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE"]/*'/>

    D3D_SVT_TEXTURE = 5,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE1D"]/*'/>

    D3D_SVT_TEXTURE1D = 6,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE2D"]/*'/>

    D3D_SVT_TEXTURE2D = 7,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE3D"]/*'/>

    D3D_SVT_TEXTURE3D = 8,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURECUBE"]/*'/>

    D3D_SVT_TEXTURECUBE = 9,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_SAMPLER"]/*'/>

    D3D_SVT_SAMPLER = 10,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_SAMPLER1D"]/*'/>

    D3D_SVT_SAMPLER1D = 11,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_SAMPLER2D"]/*'/>

    D3D_SVT_SAMPLER2D = 12,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_SAMPLER3D"]/*'/>

    D3D_SVT_SAMPLER3D = 13,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_SAMPLERCUBE"]/*'/>

    D3D_SVT_SAMPLERCUBE = 14,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_PIXELSHADER"]/*'/>

    D3D_SVT_PIXELSHADER = 15,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_VERTEXSHADER"]/*'/>

    D3D_SVT_VERTEXSHADER = 16,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_PIXELFRAGMENT"]/*'/>

    D3D_SVT_PIXELFRAGMENT = 17,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_VERTEXFRAGMENT"]/*'/>

    D3D_SVT_VERTEXFRAGMENT = 18,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_UINT"]/*'/>

    D3D_SVT_UINT = 19,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_UINT8"]/*'/>

    D3D_SVT_UINT8 = 20,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_GEOMETRYSHADER"]/*'/>

    D3D_SVT_GEOMETRYSHADER = 21,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RASTERIZER"]/*'/>

    D3D_SVT_RASTERIZER = 22,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_DEPTHSTENCIL"]/*'/>

    D3D_SVT_DEPTHSTENCIL = 23,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_BLEND"]/*'/>

    D3D_SVT_BLEND = 24,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_BUFFER"]/*'/>

    D3D_SVT_BUFFER = 25,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_CBUFFER"]/*'/>

    D3D_SVT_CBUFFER = 26,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TBUFFER"]/*'/>

    D3D_SVT_TBUFFER = 27,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE1DARRAY"]/*'/>

    D3D_SVT_TEXTURE1DARRAY = 28,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE2DARRAY"]/*'/>

    D3D_SVT_TEXTURE2DARRAY = 29,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RENDERTARGETVIEW"]/*'/>

    D3D_SVT_RENDERTARGETVIEW = 30,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_DEPTHSTENCILVIEW"]/*'/>

    D3D_SVT_DEPTHSTENCILVIEW = 31,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE2DMS"]/*'/>

    D3D_SVT_TEXTURE2DMS = 32,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURE2DMSARRAY"]/*'/>

    D3D_SVT_TEXTURE2DMSARRAY = 33,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_TEXTURECUBEARRAY"]/*'/>

    D3D_SVT_TEXTURECUBEARRAY = 34,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_HULLSHADER"]/*'/>

    D3D_SVT_HULLSHADER = 35,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_DOMAINSHADER"]/*'/>

    D3D_SVT_DOMAINSHADER = 36,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_INTERFACE_POINTER"]/*'/>

    D3D_SVT_INTERFACE_POINTER = 37,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_COMPUTESHADER"]/*'/>

    D3D_SVT_COMPUTESHADER = 38,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_DOUBLE"]/*'/>

    D3D_SVT_DOUBLE = 39,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWTEXTURE1D"]/*'/>

    D3D_SVT_RWTEXTURE1D = 40,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWTEXTURE1DARRAY"]/*'/>

    D3D_SVT_RWTEXTURE1DARRAY = 41,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWTEXTURE2D"]/*'/>

    D3D_SVT_RWTEXTURE2D = 42,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWTEXTURE2DARRAY"]/*'/>

    D3D_SVT_RWTEXTURE2DARRAY = 43,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWTEXTURE3D"]/*'/>

    D3D_SVT_RWTEXTURE3D = 44,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWBUFFER"]/*'/>

    D3D_SVT_RWBUFFER = 45,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_BYTEADDRESS_BUFFER"]/*'/>

    D3D_SVT_BYTEADDRESS_BUFFER = 46,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWBYTEADDRESS_BUFFER"]/*'/>

    D3D_SVT_RWBYTEADDRESS_BUFFER = 47,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_STRUCTURED_BUFFER"]/*'/>

    D3D_SVT_STRUCTURED_BUFFER = 48,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_RWSTRUCTURED_BUFFER"]/*'/>

    D3D_SVT_RWSTRUCTURED_BUFFER = 49,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_APPEND_STRUCTURED_BUFFER"]/*'/>

    D3D_SVT_APPEND_STRUCTURED_BUFFER = 50,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_CONSUME_STRUCTURED_BUFFER"]/*'/>

    D3D_SVT_CONSUME_STRUCTURED_BUFFER = 51,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN8FLOAT"]/*'/>

    D3D_SVT_MIN8FLOAT = 52,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN10FLOAT"]/*'/>

    D3D_SVT_MIN10FLOAT = 53,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN16FLOAT"]/*'/>

    D3D_SVT_MIN16FLOAT = 54,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN12INT"]/*'/>

    D3D_SVT_MIN12INT = 55,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN16INT"]/*'/>

    D3D_SVT_MIN16INT = 56,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_MIN16UINT"]/*'/>

    D3D_SVT_MIN16UINT = 57,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_INT16"]/*'/>

    D3D_SVT_INT16 = 58,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_UINT16"]/*'/>

    D3D_SVT_UINT16 = 59,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_FLOAT16"]/*'/>

    D3D_SVT_FLOAT16 = 60,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_INT64"]/*'/>

    D3D_SVT_INT64 = 61,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_UINT64"]/*'/>

    D3D_SVT_UINT64 = 62,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_VOID"]/*'/>

    D3D10_SVT_VOID = D3D_SVT_VOID,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_BOOL"]/*'/>

    D3D10_SVT_BOOL = D3D_SVT_BOOL,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_INT"]/*'/>

    D3D10_SVT_INT = D3D_SVT_INT,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_FLOAT"]/*'/>

    D3D10_SVT_FLOAT = D3D_SVT_FLOAT,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_STRING"]/*'/>

    D3D10_SVT_STRING = D3D_SVT_STRING,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE"]/*'/>

    D3D10_SVT_TEXTURE = D3D_SVT_TEXTURE,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE1D"]/*'/>

    D3D10_SVT_TEXTURE1D = D3D_SVT_TEXTURE1D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE2D"]/*'/>

    D3D10_SVT_TEXTURE2D = D3D_SVT_TEXTURE2D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE3D"]/*'/>

    D3D10_SVT_TEXTURE3D = D3D_SVT_TEXTURE3D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURECUBE"]/*'/>

    D3D10_SVT_TEXTURECUBE = D3D_SVT_TEXTURECUBE,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_SAMPLER"]/*'/>

    D3D10_SVT_SAMPLER = D3D_SVT_SAMPLER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_SAMPLER1D"]/*'/>

    D3D10_SVT_SAMPLER1D = D3D_SVT_SAMPLER1D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_SAMPLER2D"]/*'/>

    D3D10_SVT_SAMPLER2D = D3D_SVT_SAMPLER2D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_SAMPLER3D"]/*'/>

    D3D10_SVT_SAMPLER3D = D3D_SVT_SAMPLER3D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_SAMPLERCUBE"]/*'/>

    D3D10_SVT_SAMPLERCUBE = D3D_SVT_SAMPLERCUBE,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_PIXELSHADER"]/*'/>

    D3D10_SVT_PIXELSHADER = D3D_SVT_PIXELSHADER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_VERTEXSHADER"]/*'/>

    D3D10_SVT_VERTEXSHADER = D3D_SVT_VERTEXSHADER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_PIXELFRAGMENT"]/*'/>

    D3D10_SVT_PIXELFRAGMENT = D3D_SVT_PIXELFRAGMENT,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_VERTEXFRAGMENT"]/*'/>

    D3D10_SVT_VERTEXFRAGMENT = D3D_SVT_VERTEXFRAGMENT,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_UINT"]/*'/>

    D3D10_SVT_UINT = D3D_SVT_UINT,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_UINT8"]/*'/>

    D3D10_SVT_UINT8 = D3D_SVT_UINT8,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_GEOMETRYSHADER"]/*'/>

    D3D10_SVT_GEOMETRYSHADER = D3D_SVT_GEOMETRYSHADER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_RASTERIZER"]/*'/>

    D3D10_SVT_RASTERIZER = D3D_SVT_RASTERIZER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_DEPTHSTENCIL"]/*'/>

    D3D10_SVT_DEPTHSTENCIL = D3D_SVT_DEPTHSTENCIL,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_BLEND"]/*'/>

    D3D10_SVT_BLEND = D3D_SVT_BLEND,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_BUFFER"]/*'/>

    D3D10_SVT_BUFFER = D3D_SVT_BUFFER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_CBUFFER"]/*'/>

    D3D10_SVT_CBUFFER = D3D_SVT_CBUFFER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TBUFFER"]/*'/>

    D3D10_SVT_TBUFFER = D3D_SVT_TBUFFER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE1DARRAY"]/*'/>

    D3D10_SVT_TEXTURE1DARRAY = D3D_SVT_TEXTURE1DARRAY,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE2DARRAY"]/*'/>

    D3D10_SVT_TEXTURE2DARRAY = D3D_SVT_TEXTURE2DARRAY,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_RENDERTARGETVIEW"]/*'/>

    D3D10_SVT_RENDERTARGETVIEW = D3D_SVT_RENDERTARGETVIEW,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_DEPTHSTENCILVIEW"]/*'/>

    D3D10_SVT_DEPTHSTENCILVIEW = D3D_SVT_DEPTHSTENCILVIEW,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE2DMS"]/*'/>

    D3D10_SVT_TEXTURE2DMS = D3D_SVT_TEXTURE2DMS,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURE2DMSARRAY"]/*'/>

    D3D10_SVT_TEXTURE2DMSARRAY = D3D_SVT_TEXTURE2DMSARRAY,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D10_SVT_TEXTURECUBEARRAY"]/*'/>

    D3D10_SVT_TEXTURECUBEARRAY = D3D_SVT_TEXTURECUBEARRAY,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_HULLSHADER"]/*'/>

    D3D11_SVT_HULLSHADER = D3D_SVT_HULLSHADER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_DOMAINSHADER"]/*'/>

    D3D11_SVT_DOMAINSHADER = D3D_SVT_DOMAINSHADER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_INTERFACE_POINTER"]/*'/>

    D3D11_SVT_INTERFACE_POINTER = D3D_SVT_INTERFACE_POINTER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_COMPUTESHADER"]/*'/>

    D3D11_SVT_COMPUTESHADER = D3D_SVT_COMPUTESHADER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_DOUBLE"]/*'/>

    D3D11_SVT_DOUBLE = D3D_SVT_DOUBLE,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWTEXTURE1D"]/*'/>

    D3D11_SVT_RWTEXTURE1D = D3D_SVT_RWTEXTURE1D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWTEXTURE1DARRAY"]/*'/>

    D3D11_SVT_RWTEXTURE1DARRAY = D3D_SVT_RWTEXTURE1DARRAY,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWTEXTURE2D"]/*'/>

    D3D11_SVT_RWTEXTURE2D = D3D_SVT_RWTEXTURE2D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWTEXTURE2DARRAY"]/*'/>

    D3D11_SVT_RWTEXTURE2DARRAY = D3D_SVT_RWTEXTURE2DARRAY,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWTEXTURE3D"]/*'/>

    D3D11_SVT_RWTEXTURE3D = D3D_SVT_RWTEXTURE3D,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWBUFFER"]/*'/>

    D3D11_SVT_RWBUFFER = D3D_SVT_RWBUFFER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_BYTEADDRESS_BUFFER"]/*'/>

    D3D11_SVT_BYTEADDRESS_BUFFER = D3D_SVT_BYTEADDRESS_BUFFER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWBYTEADDRESS_BUFFER"]/*'/>

    D3D11_SVT_RWBYTEADDRESS_BUFFER = D3D_SVT_RWBYTEADDRESS_BUFFER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_STRUCTURED_BUFFER"]/*'/>

    D3D11_SVT_STRUCTURED_BUFFER = D3D_SVT_STRUCTURED_BUFFER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_RWSTRUCTURED_BUFFER"]/*'/>

    D3D11_SVT_RWSTRUCTURED_BUFFER = D3D_SVT_RWSTRUCTURED_BUFFER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_APPEND_STRUCTURED_BUFFER"]/*'/>

    D3D11_SVT_APPEND_STRUCTURED_BUFFER = D3D_SVT_APPEND_STRUCTURED_BUFFER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D11_SVT_CONSUME_STRUCTURED_BUFFER"]/*'/>

    D3D11_SVT_CONSUME_STRUCTURED_BUFFER = D3D_SVT_CONSUME_STRUCTURED_BUFFER,

    /// <include file='D3D_SHADER_VARIABLE_TYPE.xml' path='doc/member[@name="D3D_SHADER_VARIABLE_TYPE.D3D_SVT_FORCE_DWORD"]/*'/>

    D3D_SVT_FORCE_DWORD = 0x7fffffff,
}
