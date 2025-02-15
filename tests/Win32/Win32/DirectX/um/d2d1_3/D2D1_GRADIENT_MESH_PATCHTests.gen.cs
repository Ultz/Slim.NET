// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D2D1_GRADIENT_MESH_PATCH"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class D2D1_GRADIENT_MESH_PATCHTests
{
    /// <summary>Validates that the <see cref = "D2D1_GRADIENT_MESH_PATCH"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D2D1_GRADIENT_MESH_PATCH>(),
            Is.EqualTo(sizeof(D2D1_GRADIENT_MESH_PATCH))
        );
    }

    /// <summary>Validates that the <see cref = "D2D1_GRADIENT_MESH_PATCH"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D2D1_GRADIENT_MESH_PATCH).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D2D1_GRADIENT_MESH_PATCH"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D2D1_GRADIENT_MESH_PATCH), Is.EqualTo(208));
    }
}
