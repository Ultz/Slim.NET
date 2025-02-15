// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "GET_FILTER_FILE_IDENTIFIER_OUTPUT"/> struct.</summary>
public static unsafe partial class GET_FILTER_FILE_IDENTIFIER_OUTPUTTests
{
    /// <summary>Validates that the <see cref = "GET_FILTER_FILE_IDENTIFIER_OUTPUT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<GET_FILTER_FILE_IDENTIFIER_OUTPUT>(),
            Is.EqualTo(sizeof(GET_FILTER_FILE_IDENTIFIER_OUTPUT))
        );
    }

    /// <summary>Validates that the <see cref = "GET_FILTER_FILE_IDENTIFIER_OUTPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GET_FILTER_FILE_IDENTIFIER_OUTPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GET_FILTER_FILE_IDENTIFIER_OUTPUT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GET_FILTER_FILE_IDENTIFIER_OUTPUT), Is.EqualTo(4));
    }
}
