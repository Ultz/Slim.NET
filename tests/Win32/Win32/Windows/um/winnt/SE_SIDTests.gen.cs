// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SE_SID"/> struct.</summary>
public static unsafe partial class SE_SIDTests
{
    /// <summary>Validates that the <see cref = "SE_SID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SE_SID>(), Is.EqualTo(sizeof(SE_SID)));
    }

    /// <summary>Validates that the <see cref = "SE_SID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(SE_SID).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "SE_SID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SE_SID), Is.EqualTo(68));
    }
}
