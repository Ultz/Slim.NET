// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SecPkgContext_CipherInfo"/> struct.</summary>
public static unsafe partial class SecPkgContext_CipherInfoTests
{
    /// <summary>Validates that the <see cref = "SecPkgContext_CipherInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SecPkgContext_CipherInfo>(),
            Is.EqualTo(sizeof(SecPkgContext_CipherInfo))
        );
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_CipherInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SecPkgContext_CipherInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SecPkgContext_CipherInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SecPkgContext_CipherInfo), Is.EqualTo(680));
    }
}
