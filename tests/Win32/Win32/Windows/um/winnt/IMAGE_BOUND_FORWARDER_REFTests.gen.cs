// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IMAGE_BOUND_FORWARDER_REF"/> struct.</summary>
public static unsafe partial class IMAGE_BOUND_FORWARDER_REFTests
{
    /// <summary>Validates that the <see cref = "IMAGE_BOUND_FORWARDER_REF"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IMAGE_BOUND_FORWARDER_REF>(),
            Is.EqualTo(sizeof(IMAGE_BOUND_FORWARDER_REF))
        );
    }

    /// <summary>Validates that the <see cref = "IMAGE_BOUND_FORWARDER_REF"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_BOUND_FORWARDER_REF).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGE_BOUND_FORWARDER_REF"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_BOUND_FORWARDER_REF), Is.EqualTo(8));
    }
}
