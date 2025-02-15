// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/immdev.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "GUIDELINE"/> struct.</summary>
public static unsafe partial class GUIDELINETests
{
    /// <summary>Validates that the <see cref = "GUIDELINE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GUIDELINE>(), Is.EqualTo(sizeof(GUIDELINE)));
    }

    /// <summary>Validates that the <see cref = "GUIDELINE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GUIDELINE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GUIDELINE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GUIDELINE), Is.EqualTo(28));
    }
}
