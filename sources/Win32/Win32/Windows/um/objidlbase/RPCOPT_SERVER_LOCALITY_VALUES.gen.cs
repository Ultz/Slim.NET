// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum RPCOPT_SERVER_LOCALITY_VALUES
{
    SERVER_LOCALITY_PROCESS_LOCAL = 0,
    SERVER_LOCALITY_MACHINE_LOCAL = 1,
    SERVER_LOCALITY_REMOTE = 2,
}
