// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME"]/*'/>
public enum D3D_NAME
{
    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_UNDEFINED"]/*'/>

    D3D_NAME_UNDEFINED = 0,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_POSITION"]/*'/>

    D3D_NAME_POSITION = 1,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_CLIP_DISTANCE"]/*'/>

    D3D_NAME_CLIP_DISTANCE = 2,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_CULL_DISTANCE"]/*'/>

    D3D_NAME_CULL_DISTANCE = 3,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_RENDER_TARGET_ARRAY_INDEX"]/*'/>

    D3D_NAME_RENDER_TARGET_ARRAY_INDEX = 4,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_VIEWPORT_ARRAY_INDEX"]/*'/>

    D3D_NAME_VIEWPORT_ARRAY_INDEX = 5,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_VERTEX_ID"]/*'/>

    D3D_NAME_VERTEX_ID = 6,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_PRIMITIVE_ID"]/*'/>

    D3D_NAME_PRIMITIVE_ID = 7,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_INSTANCE_ID"]/*'/>

    D3D_NAME_INSTANCE_ID = 8,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_IS_FRONT_FACE"]/*'/>

    D3D_NAME_IS_FRONT_FACE = 9,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_SAMPLE_INDEX"]/*'/>

    D3D_NAME_SAMPLE_INDEX = 10,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_QUAD_EDGE_TESSFACTOR"]/*'/>

    D3D_NAME_FINAL_QUAD_EDGE_TESSFACTOR = 11,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_QUAD_INSIDE_TESSFACTOR"]/*'/>

    D3D_NAME_FINAL_QUAD_INSIDE_TESSFACTOR = 12,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_TRI_EDGE_TESSFACTOR"]/*'/>

    D3D_NAME_FINAL_TRI_EDGE_TESSFACTOR = 13,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_TRI_INSIDE_TESSFACTOR"]/*'/>

    D3D_NAME_FINAL_TRI_INSIDE_TESSFACTOR = 14,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_LINE_DETAIL_TESSFACTOR"]/*'/>

    D3D_NAME_FINAL_LINE_DETAIL_TESSFACTOR = 15,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_FINAL_LINE_DENSITY_TESSFACTOR"]/*'/>

    D3D_NAME_FINAL_LINE_DENSITY_TESSFACTOR = 16,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_BARYCENTRICS"]/*'/>

    D3D_NAME_BARYCENTRICS = 23,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_SHADINGRATE"]/*'/>

    D3D_NAME_SHADINGRATE = 24,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_CULLPRIMITIVE"]/*'/>

    D3D_NAME_CULLPRIMITIVE = 25,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_TARGET"]/*'/>

    D3D_NAME_TARGET = 64,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_DEPTH"]/*'/>

    D3D_NAME_DEPTH = 65,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_COVERAGE"]/*'/>

    D3D_NAME_COVERAGE = 66,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_DEPTH_GREATER_EQUAL"]/*'/>

    D3D_NAME_DEPTH_GREATER_EQUAL = 67,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_DEPTH_LESS_EQUAL"]/*'/>

    D3D_NAME_DEPTH_LESS_EQUAL = 68,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_STENCIL_REF"]/*'/>

    D3D_NAME_STENCIL_REF = 69,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D_NAME_INNER_COVERAGE"]/*'/>

    D3D_NAME_INNER_COVERAGE = 70,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_UNDEFINED"]/*'/>

    D3D10_NAME_UNDEFINED = D3D_NAME_UNDEFINED,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_POSITION"]/*'/>

    D3D10_NAME_POSITION = D3D_NAME_POSITION,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_CLIP_DISTANCE"]/*'/>

    D3D10_NAME_CLIP_DISTANCE = D3D_NAME_CLIP_DISTANCE,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_CULL_DISTANCE"]/*'/>

    D3D10_NAME_CULL_DISTANCE = D3D_NAME_CULL_DISTANCE,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_RENDER_TARGET_ARRAY_INDEX"]/*'/>

    D3D10_NAME_RENDER_TARGET_ARRAY_INDEX = D3D_NAME_RENDER_TARGET_ARRAY_INDEX,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_VIEWPORT_ARRAY_INDEX"]/*'/>

    D3D10_NAME_VIEWPORT_ARRAY_INDEX = D3D_NAME_VIEWPORT_ARRAY_INDEX,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_VERTEX_ID"]/*'/>

    D3D10_NAME_VERTEX_ID = D3D_NAME_VERTEX_ID,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_PRIMITIVE_ID"]/*'/>

    D3D10_NAME_PRIMITIVE_ID = D3D_NAME_PRIMITIVE_ID,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_INSTANCE_ID"]/*'/>

    D3D10_NAME_INSTANCE_ID = D3D_NAME_INSTANCE_ID,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_IS_FRONT_FACE"]/*'/>

    D3D10_NAME_IS_FRONT_FACE = D3D_NAME_IS_FRONT_FACE,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_SAMPLE_INDEX"]/*'/>

    D3D10_NAME_SAMPLE_INDEX = D3D_NAME_SAMPLE_INDEX,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_TARGET"]/*'/>

    D3D10_NAME_TARGET = D3D_NAME_TARGET,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_DEPTH"]/*'/>

    D3D10_NAME_DEPTH = D3D_NAME_DEPTH,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D10_NAME_COVERAGE"]/*'/>

    D3D10_NAME_COVERAGE = D3D_NAME_COVERAGE,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_QUAD_EDGE_TESSFACTOR"]/*'/>

    D3D11_NAME_FINAL_QUAD_EDGE_TESSFACTOR = D3D_NAME_FINAL_QUAD_EDGE_TESSFACTOR,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_QUAD_INSIDE_TESSFACTOR"]/*'/>

    D3D11_NAME_FINAL_QUAD_INSIDE_TESSFACTOR = D3D_NAME_FINAL_QUAD_INSIDE_TESSFACTOR,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_TRI_EDGE_TESSFACTOR"]/*'/>

    D3D11_NAME_FINAL_TRI_EDGE_TESSFACTOR = D3D_NAME_FINAL_TRI_EDGE_TESSFACTOR,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_TRI_INSIDE_TESSFACTOR"]/*'/>

    D3D11_NAME_FINAL_TRI_INSIDE_TESSFACTOR = D3D_NAME_FINAL_TRI_INSIDE_TESSFACTOR,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_LINE_DETAIL_TESSFACTOR"]/*'/>

    D3D11_NAME_FINAL_LINE_DETAIL_TESSFACTOR = D3D_NAME_FINAL_LINE_DETAIL_TESSFACTOR,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_FINAL_LINE_DENSITY_TESSFACTOR"]/*'/>

    D3D11_NAME_FINAL_LINE_DENSITY_TESSFACTOR = D3D_NAME_FINAL_LINE_DENSITY_TESSFACTOR,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_DEPTH_GREATER_EQUAL"]/*'/>

    D3D11_NAME_DEPTH_GREATER_EQUAL = D3D_NAME_DEPTH_GREATER_EQUAL,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_DEPTH_LESS_EQUAL"]/*'/>

    D3D11_NAME_DEPTH_LESS_EQUAL = D3D_NAME_DEPTH_LESS_EQUAL,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_STENCIL_REF"]/*'/>

    D3D11_NAME_STENCIL_REF = D3D_NAME_STENCIL_REF,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D11_NAME_INNER_COVERAGE"]/*'/>

    D3D11_NAME_INNER_COVERAGE = D3D_NAME_INNER_COVERAGE,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D12_NAME_BARYCENTRICS"]/*'/>

    D3D12_NAME_BARYCENTRICS = D3D_NAME_BARYCENTRICS,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D12_NAME_SHADINGRATE"]/*'/>

    D3D12_NAME_SHADINGRATE = D3D_NAME_SHADINGRATE,

    /// <include file='D3D_NAME.xml' path='doc/member[@name="D3D_NAME.D3D12_NAME_CULLPRIMITIVE"]/*'/>

    D3D12_NAME_CULLPRIMITIVE = D3D_NAME_CULLPRIMITIVE,
}
