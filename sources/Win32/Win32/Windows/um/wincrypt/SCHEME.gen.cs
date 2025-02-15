// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SCHEME
{
    [NativeTypeName(
        "#define SCHEME_OID_RETRIEVE_ENCODED_OBJECT_FUNC \"SchemeDllRetrieveEncodedObject\""
    )]
    public static ReadOnlySpan<byte> SCHEME_OID_RETRIEVE_ENCODED_OBJECT_FUNC =>
        "SchemeDllRetrieveEncodedObject"u8;

    [NativeTypeName(
        "#define SCHEME_OID_RETRIEVE_ENCODED_OBJECTW_FUNC \"SchemeDllRetrieveEncodedObjectW\""
    )]
    public static ReadOnlySpan<byte> SCHEME_OID_RETRIEVE_ENCODED_OBJECTW_FUNC =>
        "SchemeDllRetrieveEncodedObjectW"u8;
}
