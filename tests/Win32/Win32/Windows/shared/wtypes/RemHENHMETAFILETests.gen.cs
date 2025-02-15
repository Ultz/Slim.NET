// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "RemHENHMETAFILE"/> struct.</summary>
public static unsafe partial class RemHENHMETAFILETests
{
    /// <summary>Validates that the <see cref = "RemHENHMETAFILE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RemHENHMETAFILE>(), Is.EqualTo(sizeof(RemHENHMETAFILE)));
    }

    /// <summary>Validates that the <see cref = "RemHENHMETAFILE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RemHENHMETAFILE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RemHENHMETAFILE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RemHENHMETAFILE), Is.EqualTo(8));
    }
}
