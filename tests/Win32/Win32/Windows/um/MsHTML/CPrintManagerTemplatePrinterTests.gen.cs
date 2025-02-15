// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CPrintManagerTemplatePrinter"/> struct.</summary>
public static unsafe partial class CPrintManagerTemplatePrinterTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "CPrintManagerTemplatePrinter"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(CPrintManagerTemplatePrinter).GUID,
            Is.EqualTo(IID_CPrintManagerTemplatePrinter)
        );
    }

    /// <summary>Validates that the <see cref = "CPrintManagerTemplatePrinter"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CPrintManagerTemplatePrinter>(),
            Is.EqualTo(sizeof(CPrintManagerTemplatePrinter))
        );
    }

    /// <summary>Validates that the <see cref = "CPrintManagerTemplatePrinter"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CPrintManagerTemplatePrinter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CPrintManagerTemplatePrinter"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CPrintManagerTemplatePrinter), Is.EqualTo(1));
    }
}
