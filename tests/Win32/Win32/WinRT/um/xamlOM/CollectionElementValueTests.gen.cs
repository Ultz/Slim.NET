// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "CollectionElementValue"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class CollectionElementValueTests
{
    /// <summary>Validates that the <see cref = "CollectionElementValue"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CollectionElementValue>(),
            Is.EqualTo(sizeof(CollectionElementValue))
        );
    }

    /// <summary>Validates that the <see cref = "CollectionElementValue"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CollectionElementValue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CollectionElementValue"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CollectionElementValue), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(CollectionElementValue), Is.EqualTo(24));
        }
    }
}
