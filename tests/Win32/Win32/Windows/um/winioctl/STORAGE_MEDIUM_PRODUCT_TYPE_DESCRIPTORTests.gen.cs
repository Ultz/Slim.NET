// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTORTests
{
    /// <summary>Validates that the <see cref = "STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR>(),
            Is.EqualTo(sizeof(STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR))
        );
    }

    /// <summary>Validates that the <see cref = "STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_MEDIUM_PRODUCT_TYPE_DESCRIPTOR), Is.EqualTo(12));
    }
}
