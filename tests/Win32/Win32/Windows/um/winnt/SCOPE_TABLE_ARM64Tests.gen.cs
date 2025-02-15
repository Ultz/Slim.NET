// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SCOPE_TABLE_ARM64"/> struct.</summary>
public static unsafe partial class SCOPE_TABLE_ARM64Tests
{
    /// <summary>Validates that the <see cref = "SCOPE_TABLE_ARM64"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCOPE_TABLE_ARM64>(), Is.EqualTo(sizeof(SCOPE_TABLE_ARM64)));
    }

    /// <summary>Validates that the <see cref = "SCOPE_TABLE_ARM64"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCOPE_TABLE_ARM64).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SCOPE_TABLE_ARM64"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SCOPE_TABLE_ARM64), Is.EqualTo(20));
    }
}
