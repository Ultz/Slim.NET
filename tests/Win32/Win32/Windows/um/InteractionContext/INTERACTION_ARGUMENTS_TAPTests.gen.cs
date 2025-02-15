// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "INTERACTION_ARGUMENTS_TAP"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class INTERACTION_ARGUMENTS_TAPTests
{
    /// <summary>Validates that the <see cref = "INTERACTION_ARGUMENTS_TAP"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<INTERACTION_ARGUMENTS_TAP>(),
            Is.EqualTo(sizeof(INTERACTION_ARGUMENTS_TAP))
        );
    }

    /// <summary>Validates that the <see cref = "INTERACTION_ARGUMENTS_TAP"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INTERACTION_ARGUMENTS_TAP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INTERACTION_ARGUMENTS_TAP"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(INTERACTION_ARGUMENTS_TAP), Is.EqualTo(4));
    }
}
