// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AM_DVDCOPYSTATE
{
    AM_DVDCOPYSTATE_INITIALIZE = 0,
    AM_DVDCOPYSTATE_INITIALIZE_TITLE = 1,
    AM_DVDCOPYSTATE_AUTHENTICATION_NOT_REQUIRED = 2,
    AM_DVDCOPYSTATE_AUTHENTICATION_REQUIRED = 3,
    AM_DVDCOPYSTATE_DONE = 4,
}
