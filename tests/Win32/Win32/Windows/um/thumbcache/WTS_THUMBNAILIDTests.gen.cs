// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WTS_THUMBNAILID"/> struct.</summary>
public static unsafe partial class WTS_THUMBNAILIDTests
{
    /// <summary>Validates that the <see cref = "WTS_THUMBNAILID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WTS_THUMBNAILID>(), Is.EqualTo(sizeof(WTS_THUMBNAILID)));
    }

    /// <summary>Validates that the <see cref = "WTS_THUMBNAILID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WTS_THUMBNAILID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WTS_THUMBNAILID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WTS_THUMBNAILID), Is.EqualTo(16));
    }
}
