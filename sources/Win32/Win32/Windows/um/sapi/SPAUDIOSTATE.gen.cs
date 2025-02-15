// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPAUDIOSTATE
{
    SPAS_CLOSED = 0,
    SPAS_STOP = (SPAS_CLOSED + 1),
    SPAS_PAUSE = (SPAS_STOP + 1),
    SPAS_RUN = (SPAS_PAUSE + 1),
}
