// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TAPE_ERASE"/> struct.</summary>
public static unsafe partial class TAPE_ERASETests
{
    /// <summary>Validates that the <see cref = "TAPE_ERASE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TAPE_ERASE>(), Is.EqualTo(sizeof(TAPE_ERASE)));
    }

    /// <summary>Validates that the <see cref = "TAPE_ERASE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TAPE_ERASE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TAPE_ERASE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TAPE_ERASE), Is.EqualTo(8));
    }
}
