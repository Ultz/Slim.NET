// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum eAVEncH265VLevel
{
    eAVEncH265VLevel1 = 30,
    eAVEncH265VLevel2 = 60,
    eAVEncH265VLevel2_1 = 63,
    eAVEncH265VLevel3 = 90,
    eAVEncH265VLevel3_1 = 93,
    eAVEncH265VLevel4 = 120,
    eAVEncH265VLevel4_1 = 123,
    eAVEncH265VLevel5 = 150,
    eAVEncH265VLevel5_1 = 153,
    eAVEncH265VLevel5_2 = 156,
    eAVEncH265VLevel6 = 180,
    eAVEncH265VLevel6_1 = 183,
    eAVEncH265VLevel6_2 = 186,
}
