// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IAppxBlockMapBlocksEnumerator"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IAppxBlockMapBlocksEnumeratorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAppxBlockMapBlocksEnumerator"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IAppxBlockMapBlocksEnumerator).GUID,
            Is.EqualTo(IID_IAppxBlockMapBlocksEnumerator)
        );
    }

    /// <summary>Validates that the <see cref = "IAppxBlockMapBlocksEnumerator"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IAppxBlockMapBlocksEnumerator>(),
            Is.EqualTo(sizeof(IAppxBlockMapBlocksEnumerator))
        );
    }

    /// <summary>Validates that the <see cref = "IAppxBlockMapBlocksEnumerator"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxBlockMapBlocksEnumerator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAppxBlockMapBlocksEnumerator"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxBlockMapBlocksEnumerator), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxBlockMapBlocksEnumerator), Is.EqualTo(4));
        }
    }
}
