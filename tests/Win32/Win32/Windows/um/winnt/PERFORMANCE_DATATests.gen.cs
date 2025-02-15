// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PERFORMANCE_DATA"/> struct.</summary>
public static unsafe partial class PERFORMANCE_DATATests
{
    /// <summary>Validates that the <see cref = "PERFORMANCE_DATA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PERFORMANCE_DATA>(), Is.EqualTo(sizeof(PERFORMANCE_DATA)));
    }

    /// <summary>Validates that the <see cref = "PERFORMANCE_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PERFORMANCE_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PERFORMANCE_DATA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PERFORMANCE_DATA), Is.EqualTo(288));
    }
}
