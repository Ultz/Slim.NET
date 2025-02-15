// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TF_PROPERTYVAL"/> struct.</summary>
public static unsafe partial class TF_PROPERTYVALTests
{
    /// <summary>Validates that the <see cref = "TF_PROPERTYVAL"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TF_PROPERTYVAL>(), Is.EqualTo(sizeof(TF_PROPERTYVAL)));
    }

    /// <summary>Validates that the <see cref = "TF_PROPERTYVAL"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TF_PROPERTYVAL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TF_PROPERTYVAL"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TF_PROPERTYVAL), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(TF_PROPERTYVAL), Is.EqualTo(32));
        }
    }
}
