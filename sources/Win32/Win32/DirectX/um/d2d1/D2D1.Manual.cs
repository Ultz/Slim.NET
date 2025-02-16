// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class D2D1
{
    public const ulong D2D1_INVALID_TAG = ulong.MaxValue;
    public const uint D2D1_INTERPOLATION_MODE_DEFINITION_NEAREST_NEIGHBOR = 0;
    public const uint D2D1_INTERPOLATION_MODE_DEFINITION_LINEAR = 1;
    public const uint D2D1_INTERPOLATION_MODE_DEFINITION_CUBIC = 2;
    public const uint D2D1_INTERPOLATION_MODE_DEFINITION_MULTI_SAMPLE_LINEAR = 3;
    public const uint D2D1_INTERPOLATION_MODE_DEFINITION_ANISOTROPIC = 4;
    public const uint D2D1_INTERPOLATION_MODE_DEFINITION_HIGH_QUALITY_CUBIC = 5;
    public const uint D2D1_INTERPOLATION_MODE_DEFINITION_FANT = 6;
    public const uint D2D1_INTERPOLATION_MODE_DEFINITION_MIPMAP_LINEAR = 7;
}
