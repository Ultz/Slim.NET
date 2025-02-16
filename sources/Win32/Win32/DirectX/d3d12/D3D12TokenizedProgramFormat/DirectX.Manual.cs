// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using static Silk.NET.DirectX.D3D10;
using static Silk.NET.DirectX.D3D10_SB_EXTENDED_OPERAND_TYPE;
using static Silk.NET.DirectX.D3D10_SB_OPCODE_TYPE;
using static Silk.NET.DirectX.D3D11;
using static Silk.NET.DirectX.D3D12;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DirectX
{
    public static uint D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_MASK(uint Coord) =>
        0x0000000Fu << D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_SHIFT(Coord);

    public static int D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_SHIFT(uint Coord) =>
        9 + 4 * ((int)(Coord) & D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_COORD_MASK);

    public static uint D3D10_SB_OPERAND_4_COMPONENT_MASK(int ComponentName) =>
        (1u << (D3D10_SB_OPERAND_4_COMPONENT_MASK_SHIFT + ComponentName))
        & D3D10_SB_OPERAND_4_COMPONENT_MASK_MASK;

    public static uint D3D10_SB_OPERAND_INDEX_REPRESENTATION_MASK(int Dim) =>
        0x3u << D3D10_SB_OPERAND_INDEX_REPRESENTATION_SHIFT(Dim);

    public static int D3D10_SB_OPERAND_INDEX_REPRESENTATION_SHIFT(int Dim) => 22 + 3 * (Dim & 3);

    public static D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN DECODE_D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN(
        uint OpcodeToken0
    ) =>
        (D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN)(
            (OpcodeToken0 & D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_MASK)
            >> D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_SHIFT
        );

    public static D3D10_SB_CUSTOMDATA_CLASS DECODE_D3D10_SB_CUSTOMDATA_CLASS(
        uint CustomDataDescTok
    ) =>
        (D3D10_SB_CUSTOMDATA_CLASS)(
            (CustomDataDescTok & D3D10_SB_CUSTOMDATA_CLASS_MASK) >> D3D10_SB_CUSTOMDATA_CLASS_SHIFT
        );

    public static D3D10_SB_EXTENDED_OPCODE_TYPE DECODE_D3D10_SB_EXTENDED_OPCODE_TYPE(
        uint OpcodeToken1
    ) => (D3D10_SB_EXTENDED_OPCODE_TYPE)(OpcodeToken1 & D3D10_SB_EXTENDED_OPCODE_TYPE_MASK);

    public static D3D10_SB_EXTENDED_OPERAND_TYPE DECODE_D3D10_SB_EXTENDED_OPERAND_TYPE(
        uint OperandToken1
    ) => (D3D10_SB_EXTENDED_OPERAND_TYPE)(OperandToken1 & D3D10_SB_EXTENDED_OPERAND_TYPE_MASK);

    public static uint DECODE_D3D10_SB_GLOBAL_FLAGS(uint OpcodeToken0) =>
        OpcodeToken0 & D3D10_SB_GLOBAL_FLAGS_MASK;

    public static D3D10_SB_PRIMITIVE DECODE_D3D10_SB_GS_INPUT_PRIMITIVE(uint OpcodeToken0) =>
        (D3D10_SB_PRIMITIVE)(
            (OpcodeToken0 & D3D10_SB_GS_INPUT_PRIMITIVE_MASK) >> D3D10_SB_GS_INPUT_PRIMITIVE_SHIFT
        );

    public static D3D10_SB_PRIMITIVE_TOPOLOGY DECODE_D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY(
        uint OpcodeToken0
    ) =>
        (D3D10_SB_PRIMITIVE_TOPOLOGY)(
            (OpcodeToken0 & D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_MASK)
            >> D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_SHIFT
        );

    public static D3D10_SB_INTERPOLATION_MODE DECODE_D3D10_SB_INPUT_INTERPOLATION_MODE(
        uint OpcodeToken0
    ) =>
        (D3D10_SB_INTERPOLATION_MODE)(
            (OpcodeToken0 & D3D10_SB_INPUT_INTERPOLATION_MODE_MASK)
            >> D3D10_SB_INPUT_INTERPOLATION_MODE_SHIFT
        );

    public static D3D10_SB_INSTRUCTION_RETURN_TYPE DECODE_D3D10_SB_INSTRUCTION_RETURN_TYPE(
        uint OpcodeToken0
    ) =>
        (D3D10_SB_INSTRUCTION_RETURN_TYPE)(
            (OpcodeToken0 & D3D10_SB_INSTRUCTION_RETURN_TYPE_MASK)
            >> D3D10_SB_INSTRUCTION_RETURN_TYPE_SHIFT
        );

    public static D3D10_SB_INSTRUCTION_TEST_BOOLEAN DECODE_D3D10_SB_INSTRUCTION_TEST_BOOLEAN(
        uint OpcodeToken0
    ) =>
        (D3D10_SB_INSTRUCTION_TEST_BOOLEAN)(
            (OpcodeToken0 & D3D10_SB_INSTRUCTION_TEST_BOOLEAN_MASK)
            >> D3D10_SB_INSTRUCTION_TEST_BOOLEAN_SHIFT
        );

    public static D3D10_SB_NAME DECODE_D3D10_SB_NAME(uint NameToken) =>
        (D3D10_SB_NAME)(NameToken & D3D10_SB_NAME_MASK);

    public static D3D10_SB_OPCODE_TYPE DECODE_D3D10_SB_OPCODE_TYPE(uint OpcodeToken0) =>
        (D3D10_SB_OPCODE_TYPE)(OpcodeToken0 & D3D10_SB_OPCODE_TYPE_MASK);

    public static uint DECODE_D3D10_SB_OPERAND_4_COMPONENT_MASK(uint OperandToken0) =>
        OperandToken0 & D3D10_SB_OPERAND_4_COMPONENT_MASK_MASK;

    public static D3D10_SB_4_COMPONENT_NAME DECODE_D3D10_SB_OPERAND_4_COMPONENT_SELECT_1(
        uint OperandToken0
    ) =>
        (D3D10_SB_4_COMPONENT_NAME)(
            (OperandToken0 & D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_MASK)
            >> D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_SHIFT
        );

    public static D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE DECODE_D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE(
        uint OperandToken0
    ) =>
        (D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE)(
            (OperandToken0 & D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_MASK)
            >> D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_SHIFT
        );

    public static uint DECODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(uint OperandToken0) =>
        OperandToken0 & D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_MASK;

    public static D3D10_SB_4_COMPONENT_NAME DECODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_SOURCE(
        uint OperandToken0,
        int DestComp
    ) =>
        (D3D10_SB_4_COMPONENT_NAME)(
            (
                OperandToken0
                >> (
                    D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_SHIFT
                    + 2 * ((DestComp) & D3D10_SB_4_COMPONENT_NAME_MASK)
                )
            ) & D3D10_SB_4_COMPONENT_NAME_MASK
        );

    public static D3D10_SB_OPERAND_INDEX_DIMENSION DECODE_D3D10_SB_OPERAND_INDEX_DIMENSION(
        uint OperandToken0
    ) =>
        (D3D10_SB_OPERAND_INDEX_DIMENSION)(
            (OperandToken0 & D3D10_SB_OPERAND_INDEX_DIMENSION_MASK)
            >> D3D10_SB_OPERAND_INDEX_DIMENSION_SHIFT
        );

    public static D3D10_SB_OPERAND_INDEX_REPRESENTATION DECODE_D3D10_SB_OPERAND_INDEX_REPRESENTATION(
        int Dim,
        uint OperandToken0
    ) =>
        (D3D10_SB_OPERAND_INDEX_REPRESENTATION)(
            (OperandToken0 & D3D10_SB_OPERAND_INDEX_REPRESENTATION_MASK(Dim))
            >> D3D10_SB_OPERAND_INDEX_REPRESENTATION_SHIFT(Dim)
        );

    public static D3D10_SB_OPERAND_MODIFIER DECODE_D3D10_SB_OPERAND_MODIFIER(uint OperandToken1) =>
        (D3D10_SB_OPERAND_MODIFIER)(
            (OperandToken1 & D3D10_SB_OPERAND_MODIFIER_MASK) >> D3D10_SB_OPERAND_MODIFIER_SHIFT
        );

    public static D3D10_SB_OPERAND_NUM_COMPONENTS DECODE_D3D10_SB_OPERAND_NUM_COMPONENTS(
        uint OperandToken0
    ) => ((D3D10_SB_OPERAND_NUM_COMPONENTS)(OperandToken0 & D3D10_SB_OPERAND_NUM_COMPONENTS_MASK));

    public static D3D10_SB_OPERAND_TYPE DECODE_D3D10_SB_OPERAND_TYPE(uint OperandToken0) =>
        (D3D10_SB_OPERAND_TYPE)(
            (OperandToken0 & D3D10_SB_OPERAND_TYPE_MASK) >> D3D10_SB_OPERAND_TYPE_SHIFT
        );

    public static D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE DECODE_D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE(
        uint OpcodeToken0
    ) =>
        (D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE)(
            (OpcodeToken0 & D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_MASK)
            >> D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_SHIFT
        );

    public static D3D10_SB_RESOURCE_DIMENSION DECODE_D3D10_SB_RESOURCE_DIMENSION(
        uint OpcodeToken0
    ) =>
        (D3D10_SB_RESOURCE_DIMENSION)(
            (OpcodeToken0 & D3D10_SB_RESOURCE_DIMENSION_MASK) >> D3D10_SB_RESOURCE_DIMENSION_SHIFT
        );

    public static D3D10_SB_RESOURCE_RETURN_TYPE DECODE_D3D10_SB_RESOURCE_RETURN_TYPE(
        uint ResourceReturnTypeToken,
        int Component
    ) =>
        (D3D10_SB_RESOURCE_RETURN_TYPE)(
            (ResourceReturnTypeToken >> (Component * D3D10_SB_RESOURCE_RETURN_TYPE_NUMBITS))
            & D3D10_SB_RESOURCE_RETURN_TYPE_MASK
        );

    public static uint DECODE_D3D10_SB_RESOURCE_SAMPLE_COUNT(uint OpcodeToken0) =>
        (uint)(
            (OpcodeToken0 & D3D10_SB_RESOURCE_SAMPLE_COUNT_MASK)
            >> D3D10_SB_RESOURCE_SAMPLE_COUNT_SHIFT
        );

    public static D3D10_SB_SAMPLER_MODE DECODE_D3D10_SB_SAMPLER_MODE(uint OpcodeToken0) =>
        (D3D10_SB_SAMPLER_MODE)(
            (OpcodeToken0 & D3D10_SB_SAMPLER_MODE_MASK) >> D3D10_SB_SAMPLER_MODE_SHIFT
        );

    public static uint DECODE_D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH(uint OpcodeToken0) =>
        (OpcodeToken0 & D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_MASK)
        >> D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_SHIFT;

    public static uint DECODE_D3D10_SB_TOKENIZED_PROGRAM_LENGTH(uint LenTok) => LenTok;

    public static uint DECODE_D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION(uint VerTok) =>
        (VerTok & D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_MASK)
        >> D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_SHIFT;

    public static uint DECODE_D3D10_SB_TOKENIZED_PROGRAM_MINOR_VERSION(uint VerTok) =>
        VerTok & D3D10_SB_TOKENIZED_PROGRAM_MINOR_VERSION_MASK;

    public static D3D10_SB_TOKENIZED_PROGRAM_TYPE DECODE_D3D10_SB_TOKENIZED_PROGRAM_TYPE(
        uint VerTok
    ) =>
        (
            (D3D10_SB_TOKENIZED_PROGRAM_TYPE)(
                (VerTok & D3D10_SB_TOKENIZED_PROGRAM_TYPE_MASK)
                >> D3D10_SB_TOKENIZED_PROGRAM_TYPE_SHIFT
            )
        );

    public static uint DECODE_D3D11_SB_ACCESS_COHERENCY_FLAGS(uint OperandToken0) =>
        OperandToken0 & D3D11_SB_ACCESS_COHERENCY_MASK;

    public static D3D10_SB_RESOURCE_DIMENSION DECODE_D3D11_SB_EXTENDED_RESOURCE_DIMENSION(
        uint OpcodeTokenN
    ) =>
        (D3D10_SB_RESOURCE_DIMENSION)(
            ((OpcodeTokenN) & D3D11_SB_EXTENDED_RESOURCE_DIMENSION_MASK)
            >> D3D11_SB_EXTENDED_RESOURCE_DIMENSION_SHIFT
        );

    public static uint DECODE_D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE(
        uint OpcodeTokenN
    ) =>
        (OpcodeTokenN & D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE_MASK)
        >> D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE_SHIFT;

    public static D3D10_SB_RESOURCE_RETURN_TYPE DECODE_D3D11_SB_EXTENDED_RESOURCE_RETURN_TYPE(
        uint OpcodeTokenN,
        int Component
    ) =>
        (D3D10_SB_RESOURCE_RETURN_TYPE)(
            (
                OpcodeTokenN
                >> (
                    Component * D3D10_SB_RESOURCE_RETURN_TYPE_NUMBITS
                    + D3D11_SB_EXTENDED_RESOURCE_RETURN_TYPE_SHIFT
                )
            ) & D3D10_SB_RESOURCE_RETURN_TYPE_MASK
        );

    public static uint DECODE_D3D11_SB_INPUT_CONTROL_POINT_COUNT(uint OpcodeToken0) =>
        (uint)(
            (OpcodeToken0 & D3D11_SB_INPUT_CONTROL_POINT_COUNT_MASK)
            >> D3D11_SB_INPUT_CONTROL_POINT_COUNT_SHIFT
        );

    public static uint DECODE_D3D11_SB_INSTRUCTION_PRECISE_VALUES(uint OpcodeToken0) =>
        (
            (OpcodeToken0 & D3D11_SB_INSTRUCTION_PRECISE_VALUES_MASK)
            >> D3D11_SB_INSTRUCTION_PRECISE_VALUES_SHIFT
        );

    public static uint DECODE_D3D11_SB_INTERFACE_ARRAY_LENGTH(uint OpcodeToken0) =>
        (OpcodeToken0 & D3D11_SB_INTERFACE_ARRAY_LENGTH_MASK)
        >> D3D11_SB_INTERFACE_ARRAY_LENGTH_SHIFT;

    public static bool DECODE_D3D11_SB_INTERFACE_INDEXED_BIT(uint OpcodeToken0) =>
        (
            (OpcodeToken0 & D3D11_SB_INTERFACE_INDEXED_BIT_MASK)
            >> D3D11_SB_INTERFACE_INDEXED_BIT_SHIFT
        ) != 0;

    public static uint DECODE_D3D11_SB_INTERFACE_TABLE_LENGTH(uint OpcodeToken0) =>
        (OpcodeToken0 & D3D11_SB_INTERFACE_TABLE_LENGTH_MASK)
        >> D3D11_SB_INTERFACE_TABLE_LENGTH_SHIFT;

    public static D3D11_SB_OPERAND_MIN_PRECISION DECODE_D3D11_SB_OPERAND_MIN_PRECISION(
        uint OperandToken1
    ) =>
        (
            (D3D11_SB_OPERAND_MIN_PRECISION)(
                ((OperandToken1) & D3D11_SB_OPERAND_MIN_PRECISION_MASK)
                >> D3D11_SB_OPERAND_MIN_PRECISION_SHIFT
            )
        );

    public static uint DECODE_D3D11_SB_OUTPUT_CONTROL_POINT_COUNT(uint OpcodeToken0) =>
        (OpcodeToken0 & D3D11_SB_OUTPUT_CONTROL_POINT_COUNT_MASK)
        >> D3D11_SB_OUTPUT_CONTROL_POINT_COUNT_SHIFT;

    public static uint DECODE_D3D11_SB_RESOURCE_FLAGS(uint OperandToken0) =>
        OperandToken0 & D3D11_SB_RESOURCE_FLAGS_MASK;

    public static uint DECODE_D3D11_SB_SYNC_FLAGS(uint OperandToken0) =>
        OperandToken0 & D3D11_SB_SYNC_FLAGS_MASK;

    public static D3D11_SB_TESSELLATOR_DOMAIN DECODE_D3D11_SB_TESS_DOMAIN(uint OpcodeToken0) =>
        (D3D11_SB_TESSELLATOR_DOMAIN)(
            (OpcodeToken0 & D3D11_SB_TESS_DOMAIN_MASK) >> D3D11_SB_TESS_DOMAIN_SHIFT
        );

    public static D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE DECODE_D3D11_SB_TESS_OUTPUT_PRIMITIVE(
        uint OpcodeToken0
    ) =>
        (D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE)(
            (OpcodeToken0 & D3D11_SB_TESS_OUTPUT_PRIMITIVE_MASK)
            >> D3D11_SB_TESS_OUTPUT_PRIMITIVE_SHIFT
        );

    public static D3D11_SB_TESSELLATOR_PARTITIONING DECODE_D3D11_SB_TESS_PARTITIONING(
        uint OpcodeToken0
    ) =>
        (D3D11_SB_TESSELLATOR_PARTITIONING)(
            (OpcodeToken0 & D3D11_SB_TESS_PARTITIONING_MASK) >> D3D11_SB_TESS_PARTITIONING_SHIFT
        );

    public static uint DECODE_D3D11_SB_UAV_FLAGS(uint OperandToken0) =>
        OperandToken0 & D3D11_SB_UAV_FLAGS_MASK;

    public static uint DECODE_D3D12_SB_OPERAND_NON_UNIFORM(uint OperandToken1) =>
        (OperandToken1 & D3D12_SB_OPERAND_NON_UNIFORM_MASK) >> D3D12_SB_OPERAND_NON_UNIFORM_SHIFT;

    public static int DECODE_IMMEDIATE_D3D10_SB_ADDRESS_OFFSET(uint Coord, uint OpcodeToken1) =>
        (int)(
            (OpcodeToken1 & D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_MASK(Coord))
            >> (D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_SHIFT(Coord))
        );

    public static bool DECODE_IS_D3D10_SB_INSTRUCTION_SATURATE_ENABLED(uint OpcodeToken0) =>
        (OpcodeToken0 & D3D10_SB_INSTRUCTION_SATURATE_MASK) != 0;

    public static bool DECODE_IS_D3D10_SB_OPCODE_EXTENDED(uint OpcodeToken0) =>
        ((OpcodeToken0 & D3D10_SB_OPCODE_EXTENDED_MASK) >> D3D10_SB_OPCODE_EXTENDED_SHIFT) != 0;

    public static bool DECODE_IS_D3D10_SB_OPERAND_DOUBLE_EXTENDED(uint OperandToken1) =>
        (
            (OperandToken1 & D3D10_SB_OPERAND_DOUBLE_EXTENDED_MASK)
            >> D3D10_SB_OPERAND_DOUBLE_EXTENDED_SHIFT
        ) != 0;

    public static bool DECODE_IS_D3D10_SB_OPERAND_EXTENDED(uint OperandToken0) =>
        ((OperandToken0 & D3D10_SB_OPERAND_EXTENDED_MASK) >> D3D10_SB_OPERAND_EXTENDED_SHIFT) != 0;

    public static uint ENCODE_D3D10_SB_CUSTOMDATA_CLASS(
        D3D10_SB_CUSTOMDATA_CLASS CustomDataClass
    ) =>
        ENCODE_D3D10_SB_OPCODE_TYPE(D3D10_SB_OPCODE_CUSTOMDATA)
        | (
            ((uint)(CustomDataClass) << D3D10_SB_CUSTOMDATA_CLASS_SHIFT)
            & D3D10_SB_CUSTOMDATA_CLASS_MASK
        );

    public static uint ENCODE_D3D10_SB_D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN(
        D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN AccessPattern
    ) =>
        ((uint)(AccessPattern) << D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_SHIFT)
        & D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_MASK;

    public static uint ENCODE_D3D10_SB_EXTENDED_OPCODE_TYPE(
        D3D10_SB_EXTENDED_OPCODE_TYPE ExtOpcodeType
    ) => (uint)(ExtOpcodeType) & D3D10_SB_EXTENDED_OPCODE_TYPE_MASK;

    public static uint ENCODE_D3D10_SB_EXTENDED_OPERAND_MODIFIER(
        D3D10_SB_OPERAND_MODIFIER SourceMod
    ) =>
        (((uint)(SourceMod) << D3D10_SB_OPERAND_MODIFIER_SHIFT) & D3D10_SB_OPERAND_MODIFIER_MASK)
        | ENCODE_D3D10_SB_EXTENDED_OPERAND_TYPE(D3D10_SB_EXTENDED_OPERAND_MODIFIER)
        | ENCODE_D3D10_SB_OPERAND_DOUBLE_EXTENDED(false);

    public static uint ENCODE_D3D10_SB_EXTENDED_OPERAND_TYPE(
        D3D10_SB_EXTENDED_OPERAND_TYPE ExtOperandType
    ) => (uint)(ExtOperandType) & D3D10_SB_EXTENDED_OPERAND_TYPE_MASK;

    public static uint ENCODE_D3D10_SB_GLOBAL_FLAGS(uint Flags) =>
        Flags & D3D10_SB_GLOBAL_FLAGS_MASK;

    public static uint ENCODE_D3D10_SB_GS_INPUT_PRIMITIVE(D3D10_SB_PRIMITIVE Prim) =>
        ((uint)(Prim) << D3D10_SB_GS_INPUT_PRIMITIVE_SHIFT) & D3D10_SB_GS_INPUT_PRIMITIVE_MASK;

    public static uint ENCODE_D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY(
        D3D10_SB_PRIMITIVE_TOPOLOGY PrimTopology
    ) =>
        ((uint)(PrimTopology) << D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_SHIFT)
        & D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_MASK;

    public static uint ENCODE_D3D10_SB_INPUT_INTERPOLATION_MODE(
        D3D10_SB_INTERPOLATION_MODE InterpolationMode
    ) =>
        ((uint)(InterpolationMode) << D3D10_SB_INPUT_INTERPOLATION_MODE_SHIFT)
        & D3D10_SB_INPUT_INTERPOLATION_MODE_MASK;

    public static uint ENCODE_D3D10_SB_INSTRUCTION_RETURN_TYPE(
        D3D10_SB_INSTRUCTION_RETURN_TYPE ReturnType
    ) =>
        ((uint)(ReturnType) << D3D10_SB_INSTRUCTION_RETURN_TYPE_SHIFT)
        & D3D10_SB_INSTRUCTION_RETURN_TYPE_MASK;

    public static uint ENCODE_D3D10_SB_INSTRUCTION_SATURATE(bool bSat) =>
        bSat ? D3D10_SB_INSTRUCTION_SATURATE_MASK : 0u;

    public static uint ENCODE_D3D10_SB_INSTRUCTION_TEST_BOOLEAN(
        D3D10_SB_INSTRUCTION_TEST_BOOLEAN Boolean
    ) =>
        ((uint)(Boolean) << D3D10_SB_INSTRUCTION_TEST_BOOLEAN_SHIFT)
        & D3D10_SB_INSTRUCTION_TEST_BOOLEAN_MASK;

    public static uint ENCODE_D3D10_SB_NAME(D3D10_SB_NAME Name) =>
        (uint)(Name) & D3D10_SB_NAME_MASK;

    public static uint ENCODE_D3D10_SB_OPCODE_EXTENDED(bool bExtended) =>
        bExtended ? D3D10_SB_OPCODE_EXTENDED_MASK : 0u;

    public static uint ENCODE_D3D10_SB_OPCODE_TYPE(D3D10_SB_OPCODE_TYPE OpcodeName) =>
        (uint)(OpcodeName) & D3D10_SB_OPCODE_TYPE_MASK;

    public static uint ENCODE_D3D10_SB_OPERAND_4_COMPONENT_MASK(uint ComponentMask) =>
        ComponentMask & D3D10_SB_OPERAND_4_COMPONENT_MASK_MASK;

    public static uint ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SELECT_1(
        D3D10_SB_4_COMPONENT_NAME SelectedComp
    ) =>
        ((uint)(SelectedComp) << D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_SHIFT)
        & D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_MASK;

    public static uint ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE(
        D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE SelectionMode
    ) =>
        ((uint)(SelectionMode) << D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_SHIFT)
        & D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_MASK;

    public static uint ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(
        D3D10_SB_4_COMPONENT_NAME XSrc,
        D3D10_SB_4_COMPONENT_NAME YSrc,
        D3D10_SB_4_COMPONENT_NAME ZSrc,
        D3D10_SB_4_COMPONENT_NAME WSrc
    ) =>
        (
            ((uint)(XSrc) & D3D10_SB_4_COMPONENT_NAME_MASK)
            | (((uint)(YSrc) & D3D10_SB_4_COMPONENT_NAME_MASK) << 2)
            | (((uint)(ZSrc) & D3D10_SB_4_COMPONENT_NAME_MASK) << 4)
            | (((uint)(WSrc) & D3D10_SB_4_COMPONENT_NAME_MASK) << 6)
        ) << D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_SHIFT;

    public static uint ENCODE_D3D10_SB_OPERAND_DOUBLE_EXTENDED(bool bExtended) =>
        bExtended ? D3D10_SB_OPERAND_DOUBLE_EXTENDED_MASK : 0;

    public static uint ENCODE_D3D10_SB_OPERAND_EXTENDED(bool bExtended) =>
        bExtended ? D3D10_SB_OPERAND_EXTENDED_MASK : 0u;

    public static uint ENCODE_D3D10_SB_OPERAND_INDEX_DIMENSION(
        D3D10_SB_OPERAND_INDEX_DIMENSION OperandIndexDim
    ) =>
        ((uint)(OperandIndexDim) << D3D10_SB_OPERAND_INDEX_DIMENSION_SHIFT)
        & D3D10_SB_OPERAND_INDEX_DIMENSION_MASK;

    public static uint ENCODE_D3D10_SB_OPERAND_INDEX_REPRESENTATION(
        int Dim,
        D3D10_SB_OPERAND_INDEX_REPRESENTATION IndexRepresentation
    ) =>
        ((uint)(IndexRepresentation) << D3D10_SB_OPERAND_INDEX_REPRESENTATION_SHIFT(Dim))
        & D3D10_SB_OPERAND_INDEX_REPRESENTATION_MASK(Dim);

    public static uint ENCODE_D3D10_SB_OPERAND_NUM_COMPONENTS(
        D3D10_SB_OPERAND_NUM_COMPONENTS NumComp
    ) => (uint)(NumComp) & D3D10_SB_OPERAND_NUM_COMPONENTS_MASK;

    public static uint ENCODE_D3D10_SB_OPERAND_TYPE(D3D10_SB_OPERAND_TYPE OperandType) =>
        ((uint)(OperandType) << D3D10_SB_OPERAND_TYPE_SHIFT) & D3D10_SB_OPERAND_TYPE_MASK;

    public static uint ENCODE_D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE(
        D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE ReturnType
    ) =>
        ((uint)(ReturnType) << D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_SHIFT)
        & D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_MASK;

    public static uint ENCODE_D3D10_SB_RESOURCE_DIMENSION(
        D3D10_SB_RESOURCE_DIMENSION ResourceDim
    ) =>
        ((uint)(ResourceDim) << D3D10_SB_RESOURCE_DIMENSION_SHIFT)
        & D3D10_SB_RESOURCE_DIMENSION_MASK;

    public static uint ENCODE_D3D10_SB_RESOURCE_RETURN_TYPE(
        D3D10_SB_RESOURCE_RETURN_TYPE ReturnType,
        int Component
    ) =>
        ((uint)(ReturnType) & D3D10_SB_RESOURCE_RETURN_TYPE_MASK)
        << (Component * D3D10_SB_RESOURCE_RETURN_TYPE_NUMBITS);

    public static uint ENCODE_D3D10_SB_RESOURCE_SAMPLE_COUNT(uint SampleCount) =>
        (((SampleCount > 127) ? 127 : SampleCount) << D3D10_SB_RESOURCE_SAMPLE_COUNT_SHIFT)
        & D3D10_SB_RESOURCE_SAMPLE_COUNT_MASK;

    public static uint ENCODE_D3D10_SB_SAMPLER_MODE(D3D10_SB_SAMPLER_MODE SamplerMode) =>
        ((uint)(SamplerMode) << D3D10_SB_SAMPLER_MODE_SHIFT) & D3D10_SB_SAMPLER_MODE_MASK;

    public static uint ENCODE_D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH(uint Length) =>
        (Length << D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_SHIFT)
        & D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_MASK;

    public static uint ENCODE_D3D10_SB_TOKENIZED_PROGRAM_LENGTH(uint Length) => Length;

    public static uint ENCODE_D3D10_SB_TOKENIZED_PROGRAM_VERSION_TOKEN(
        D3D10_SB_TOKENIZED_PROGRAM_TYPE ProgType,
        uint MajorVer,
        uint MinorVer
    ) =>
        (
            ((uint)(ProgType) << D3D10_SB_TOKENIZED_PROGRAM_TYPE_SHIFT)
            & D3D10_SB_TOKENIZED_PROGRAM_TYPE_MASK
        )
        | (
            (
                (MajorVer << D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_SHIFT)
                & D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_MASK
            )
        )
        | (MinorVer & D3D10_SB_TOKENIZED_PROGRAM_MINOR_VERSION_MASK);

    public static uint ENCODE_D3D11_SB_ACCESS_COHERENCY_FLAGS(uint Flags) =>
        Flags & D3D11_SB_ACCESS_COHERENCY_MASK;

    public static uint ENCODE_D3D11_SB_EXTENDED_RESOURCE_DIMENSION(
        D3D10_SB_RESOURCE_DIMENSION ResourceDim
    ) =>
        ((uint)(ResourceDim) << D3D11_SB_EXTENDED_RESOURCE_DIMENSION_SHIFT)
        & D3D11_SB_EXTENDED_RESOURCE_DIMENSION_MASK;

    public static uint ENCODE_D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE(uint Stride) =>
        (Stride << D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE_SHIFT)
        & D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE_MASK;

    public static uint ENCODE_D3D11_SB_EXTENDED_RESOURCE_RETURN_TYPE(
        D3D10_SB_RESOURCE_RETURN_TYPE ReturnType,
        int Component
    ) =>
        ((uint)(ReturnType) & D3D10_SB_RESOURCE_RETURN_TYPE_MASK)
        << (
            Component * D3D10_SB_RESOURCE_RETURN_TYPE_NUMBITS
            + D3D11_SB_EXTENDED_RESOURCE_RETURN_TYPE_SHIFT
        );

    public static uint ENCODE_D3D11_SB_INPUT_CONTROL_POINT_COUNT(uint Count) =>
        (Count << D3D11_SB_INPUT_CONTROL_POINT_COUNT_SHIFT)
        & D3D11_SB_INPUT_CONTROL_POINT_COUNT_MASK;

    public static uint ENCODE_D3D11_SB_INSTRUCTION_PRECISE_VALUES(uint ComponentMask) =>
        (ComponentMask << D3D11_SB_INSTRUCTION_PRECISE_VALUES_SHIFT)
        & D3D11_SB_INSTRUCTION_PRECISE_VALUES_MASK;

    public static uint ENCODE_D3D11_SB_INTERFACE_ARRAY_LENGTH(uint ArrayLength) =>
        (ArrayLength << D3D11_SB_INTERFACE_ARRAY_LENGTH_SHIFT)
        & D3D11_SB_INTERFACE_ARRAY_LENGTH_MASK;

    public static uint ENCODE_D3D11_SB_INTERFACE_INDEXED_BIT(bool IndexedBit) =>
        ((IndexedBit ? 1u : 0u) << D3D11_SB_INTERFACE_INDEXED_BIT_SHIFT)
        & D3D11_SB_INTERFACE_INDEXED_BIT_MASK;

    public static uint ENCODE_D3D11_SB_INTERFACE_TABLE_LENGTH(uint TableLength) =>
        (TableLength << D3D11_SB_INTERFACE_TABLE_LENGTH_SHIFT)
        & D3D11_SB_INTERFACE_TABLE_LENGTH_MASK;

    public static uint ENCODE_D3D11_SB_OPERAND_MIN_PRECISION(
        D3D11_SB_OPERAND_MIN_PRECISION MinPrecision
    ) =>
        ((uint)(MinPrecision) << D3D11_SB_OPERAND_MIN_PRECISION_SHIFT)
        & D3D11_SB_OPERAND_MIN_PRECISION_MASK;

    public static uint ENCODE_D3D11_SB_OUTPUT_CONTROL_POINT_COUNT(uint Count) =>
        (Count << D3D11_SB_OUTPUT_CONTROL_POINT_COUNT_SHIFT)
        & D3D11_SB_OUTPUT_CONTROL_POINT_COUNT_MASK;

    public static uint ENCODE_D3D11_SB_RESOURCE_FLAGS(uint Flags) =>
        Flags & D3D11_SB_RESOURCE_FLAGS_MASK;

    public static uint ENCODE_D3D11_SB_SYNC_FLAGS(uint Flags) => Flags & D3D11_SB_SYNC_FLAGS_MASK;

    public static uint ENCODE_D3D11_SB_TESS_DOMAIN(D3D11_SB_TESSELLATOR_DOMAIN Domain) =>
        ((uint)(Domain) << D3D11_SB_TESS_DOMAIN_SHIFT) & D3D11_SB_TESS_DOMAIN_MASK;

    public static uint ENCODE_D3D11_SB_TESS_OUTPUT_PRIMITIVE(
        D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE OutputPrimitive
    ) =>
        ((uint)(OutputPrimitive) << D3D11_SB_TESS_OUTPUT_PRIMITIVE_SHIFT)
        & D3D11_SB_TESS_OUTPUT_PRIMITIVE_MASK;

    public static uint ENCODE_D3D11_SB_TESS_PARTITIONING(
        D3D11_SB_TESSELLATOR_PARTITIONING Partitioning
    ) =>
        ((uint)(Partitioning) << D3D11_SB_TESS_PARTITIONING_SHIFT)
        & D3D11_SB_TESS_PARTITIONING_MASK;

    public static uint ENCODE_D3D11_SB_UAV_FLAGS(uint Flags) => Flags & D3D11_SB_UAV_FLAGS_MASK;

    public static uint ENCODE_D3D12_SB_OPERAND_NON_UNIFORM(uint NonUniform) =>
        (NonUniform << D3D12_SB_OPERAND_NON_UNIFORM_SHIFT) & D3D12_SB_OPERAND_NON_UNIFORM_MASK;

    public static uint ENCODE_IMMEDIATE_D3D10_SB_ADDRESS_OFFSET(uint Coord, int ImmediateOffset) =>
        (uint)(ImmediateOffset << D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_SHIFT(Coord))
        & D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_MASK(Coord);
}
