// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SYNCMGR_RESOLUTION_FEEDBACK
{
    SYNCMGR_RF_CONTINUE = 0,
    SYNCMGR_RF_REFRESH = (SYNCMGR_RF_CONTINUE + 1),
    SYNCMGR_RF_CANCEL = (SYNCMGR_RF_REFRESH + 1),
}
