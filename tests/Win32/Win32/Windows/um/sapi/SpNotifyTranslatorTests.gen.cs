// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SpNotifyTranslator"/> struct.</summary>
public static unsafe partial class SpNotifyTranslatorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SpNotifyTranslator"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SpNotifyTranslator).GUID, Is.EqualTo(CLSID_SpNotifyTranslator));
    }

    /// <summary>Validates that the <see cref = "SpNotifyTranslator"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SpNotifyTranslator>(), Is.EqualTo(sizeof(SpNotifyTranslator)));
    }

    /// <summary>Validates that the <see cref = "SpNotifyTranslator"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpNotifyTranslator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpNotifyTranslator"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SpNotifyTranslator), Is.EqualTo(1));
    }
}
