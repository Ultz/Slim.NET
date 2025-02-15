// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SPC_SIGINFO"/> struct.</summary>
public static unsafe partial class SPC_SIGINFOTests
{
    /// <summary>Validates that the <see cref = "SPC_SIGINFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SPC_SIGINFO>(), Is.EqualTo(sizeof(SPC_SIGINFO)));
    }

    /// <summary>Validates that the <see cref = "SPC_SIGINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SPC_SIGINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SPC_SIGINFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SPC_SIGINFO), Is.EqualTo(40));
    }
}
