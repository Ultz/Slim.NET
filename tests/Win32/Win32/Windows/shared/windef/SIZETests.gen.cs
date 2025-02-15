// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SIZE"/> struct.</summary>
public static unsafe partial class SIZETests
{
    /// <summary>Validates that the <see cref = "SIZE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SIZE>(), Is.EqualTo(sizeof(SIZE)));
    }

    /// <summary>Validates that the <see cref = "SIZE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SIZE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SIZE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SIZE), Is.EqualTo(8));
    }
}
