// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DML_SIZE_2D"/> struct.</summary>
public static unsafe partial class DML_SIZE_2DTests
{
    /// <summary>Validates that the <see cref = "DML_SIZE_2D"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DML_SIZE_2D>(), Is.EqualTo(sizeof(DML_SIZE_2D)));
    }

    /// <summary>Validates that the <see cref = "DML_SIZE_2D"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DML_SIZE_2D).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DML_SIZE_2D"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DML_SIZE_2D), Is.EqualTo(8));
    }
}
