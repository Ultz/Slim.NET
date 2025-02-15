// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DCOMPOSITION
{
    [NativeTypeName("#define DCOMPOSITION_MAX_WAITFORCOMPOSITORCLOCK_OBJECTS 32")]
    public const int DCOMPOSITION_MAX_WAITFORCOMPOSITORCLOCK_OBJECTS = 32;
}
