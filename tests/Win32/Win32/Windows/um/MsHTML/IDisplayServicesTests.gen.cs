// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IDisplayServices"/> struct.</summary>
public static unsafe partial class IDisplayServicesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDisplayServices"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDisplayServices).GUID, Is.EqualTo(IID_IDisplayServices));
    }

    /// <summary>Validates that the <see cref = "IDisplayServices"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDisplayServices>(), Is.EqualTo(sizeof(IDisplayServices)));
    }

    /// <summary>Validates that the <see cref = "IDisplayServices"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDisplayServices).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDisplayServices"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDisplayServices), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDisplayServices), Is.EqualTo(4));
        }
    }
}
