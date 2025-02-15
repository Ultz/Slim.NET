// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IAsyncManager"/> struct.</summary>
public static unsafe partial class IAsyncManagerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAsyncManager"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAsyncManager).GUID, Is.EqualTo(IID_IAsyncManager));
    }

    /// <summary>Validates that the <see cref = "IAsyncManager"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAsyncManager>(), Is.EqualTo(sizeof(IAsyncManager)));
    }

    /// <summary>Validates that the <see cref = "IAsyncManager"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAsyncManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAsyncManager"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAsyncManager), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAsyncManager), Is.EqualTo(4));
        }
    }
}
