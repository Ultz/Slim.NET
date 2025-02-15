// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D2D1_RESOURCE_TEXTURE_PROPERTIES"/> struct.</summary>
public static unsafe partial class D2D1_RESOURCE_TEXTURE_PROPERTIESTests
{
    /// <summary>Validates that the <see cref = "D2D1_RESOURCE_TEXTURE_PROPERTIES"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D2D1_RESOURCE_TEXTURE_PROPERTIES>(),
            Is.EqualTo(sizeof(D2D1_RESOURCE_TEXTURE_PROPERTIES))
        );
    }

    /// <summary>Validates that the <see cref = "D2D1_RESOURCE_TEXTURE_PROPERTIES"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D2D1_RESOURCE_TEXTURE_PROPERTIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D2D1_RESOURCE_TEXTURE_PROPERTIES"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D2D1_RESOURCE_TEXTURE_PROPERTIES), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(D2D1_RESOURCE_TEXTURE_PROPERTIES), Is.EqualTo(24));
        }
    }
}
