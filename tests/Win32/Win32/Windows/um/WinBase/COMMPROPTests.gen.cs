// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "COMMPROP"/> struct.</summary>
public static unsafe partial class COMMPROPTests
{
    /// <summary>Validates that the <see cref = "COMMPROP"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COMMPROP>(), Is.EqualTo(sizeof(COMMPROP)));
    }

    /// <summary>Validates that the <see cref = "COMMPROP"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COMMPROP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COMMPROP"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(COMMPROP), Is.EqualTo(64));
    }
}
