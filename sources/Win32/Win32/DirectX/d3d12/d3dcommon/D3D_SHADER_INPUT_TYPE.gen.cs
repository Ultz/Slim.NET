// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE"]/*'/>
public enum D3D_SHADER_INPUT_TYPE
{
    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_CBUFFER"]/*'/>

    D3D_SIT_CBUFFER = 0,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_TBUFFER"]/*'/>

    D3D_SIT_TBUFFER = (D3D_SIT_CBUFFER + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_TEXTURE"]/*'/>

    D3D_SIT_TEXTURE = (D3D_SIT_TBUFFER + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_SAMPLER"]/*'/>

    D3D_SIT_SAMPLER = (D3D_SIT_TEXTURE + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWTYPED"]/*'/>

    D3D_SIT_UAV_RWTYPED = (D3D_SIT_SAMPLER + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_STRUCTURED"]/*'/>

    D3D_SIT_STRUCTURED = (D3D_SIT_UAV_RWTYPED + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWSTRUCTURED"]/*'/>

    D3D_SIT_UAV_RWSTRUCTURED = (D3D_SIT_STRUCTURED + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_BYTEADDRESS"]/*'/>

    D3D_SIT_BYTEADDRESS = (D3D_SIT_UAV_RWSTRUCTURED + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWBYTEADDRESS"]/*'/>

    D3D_SIT_UAV_RWBYTEADDRESS = (D3D_SIT_BYTEADDRESS + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_APPEND_STRUCTURED"]/*'/>

    D3D_SIT_UAV_APPEND_STRUCTURED = (D3D_SIT_UAV_RWBYTEADDRESS + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_CONSUME_STRUCTURED"]/*'/>

    D3D_SIT_UAV_CONSUME_STRUCTURED = (D3D_SIT_UAV_APPEND_STRUCTURED + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER"]/*'/>

    D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER = (D3D_SIT_UAV_CONSUME_STRUCTURED + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_RTACCELERATIONSTRUCTURE"]/*'/>

    D3D_SIT_RTACCELERATIONSTRUCTURE = (D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_FEEDBACKTEXTURE"]/*'/>

    D3D_SIT_UAV_FEEDBACKTEXTURE = (D3D_SIT_RTACCELERATIONSTRUCTURE + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_CBUFFER"]/*'/>

    D3D10_SIT_CBUFFER = D3D_SIT_CBUFFER,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_TBUFFER"]/*'/>

    D3D10_SIT_TBUFFER = D3D_SIT_TBUFFER,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_TEXTURE"]/*'/>

    D3D10_SIT_TEXTURE = D3D_SIT_TEXTURE,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_SAMPLER"]/*'/>

    D3D10_SIT_SAMPLER = D3D_SIT_SAMPLER,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWTYPED"]/*'/>

    D3D11_SIT_UAV_RWTYPED = D3D_SIT_UAV_RWTYPED,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_STRUCTURED"]/*'/>

    D3D11_SIT_STRUCTURED = D3D_SIT_STRUCTURED,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWSTRUCTURED"]/*'/>

    D3D11_SIT_UAV_RWSTRUCTURED = D3D_SIT_UAV_RWSTRUCTURED,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_BYTEADDRESS"]/*'/>

    D3D11_SIT_BYTEADDRESS = D3D_SIT_BYTEADDRESS,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWBYTEADDRESS"]/*'/>

    D3D11_SIT_UAV_RWBYTEADDRESS = D3D_SIT_UAV_RWBYTEADDRESS,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_APPEND_STRUCTURED"]/*'/>

    D3D11_SIT_UAV_APPEND_STRUCTURED = D3D_SIT_UAV_APPEND_STRUCTURED,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_CONSUME_STRUCTURED"]/*'/>

    D3D11_SIT_UAV_CONSUME_STRUCTURED = D3D_SIT_UAV_CONSUME_STRUCTURED,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWSTRUCTURED_WITH_COUNTER"]/*'/>

    D3D11_SIT_UAV_RWSTRUCTURED_WITH_COUNTER = D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER,
}
