// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using static Silk.NET.Windows.MFVideoInterlaceMode;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFSerializeAttributesToStream(
        IMFAttributes pAttr,
        [NativeTypeName("DWORD")] uint dwOptions,
        IStream pStm
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFDeserializeAttributesFromStream(
        IMFAttributes pAttr,
        [NativeTypeName("DWORD")] uint dwOptions,
        IStream pStm
    );

    [NativeTypeName(
        "#define MFVideoInterlace_FieldSingleUpperFirst MFVideoInterlace_FieldSingleUpper"
    )]
    public const MFVideoInterlaceMode MFVideoInterlace_FieldSingleUpperFirst =
        MFVideoInterlace_FieldSingleUpper;

    [NativeTypeName(
        "#define MFVideoInterlace_FieldSingleLowerFirst MFVideoInterlace_FieldSingleLower"
    )]
    public const MFVideoInterlaceMode MFVideoInterlace_FieldSingleLowerFirst =
        MFVideoInterlace_FieldSingleLower;
}
