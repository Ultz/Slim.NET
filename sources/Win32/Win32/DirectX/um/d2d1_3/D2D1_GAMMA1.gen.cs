// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.D2D1_GAMMA;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_GAMMA1
{
    D2D1_GAMMA1_G22 = D2D1_GAMMA_2_2,
    D2D1_GAMMA1_G10 = D2D1_GAMMA_1_0,
    D2D1_GAMMA1_G2084 = 2,
    D2D1_GAMMA1_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
