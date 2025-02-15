// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ACCESS_REASONS"/> struct.</summary>
public static unsafe partial class ACCESS_REASONSTests
{
    /// <summary>Validates that the <see cref = "ACCESS_REASONS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ACCESS_REASONS>(), Is.EqualTo(sizeof(ACCESS_REASONS)));
    }

    /// <summary>Validates that the <see cref = "ACCESS_REASONS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACCESS_REASONS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ACCESS_REASONS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ACCESS_REASONS), Is.EqualTo(128));
    }
}
