// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "HTMLInputButtonElement"/> struct.</summary>
public static unsafe partial class HTMLInputButtonElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLInputButtonElement"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLInputButtonElement).GUID, Is.EqualTo(IID_HTMLInputButtonElement));
    }

    /// <summary>Validates that the <see cref = "HTMLInputButtonElement"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<HTMLInputButtonElement>(),
            Is.EqualTo(sizeof(HTMLInputButtonElement))
        );
    }

    /// <summary>Validates that the <see cref = "HTMLInputButtonElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLInputButtonElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLInputButtonElement"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLInputButtonElement), Is.EqualTo(1));
    }
}
