// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDCompositionRectangleClip"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDCompositionRectangleClipTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDCompositionRectangleClip"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IDCompositionRectangleClip).GUID,
            Is.EqualTo(IID_IDCompositionRectangleClip)
        );
    }

    /// <summary>Validates that the <see cref = "IDCompositionRectangleClip"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IDCompositionRectangleClip>(),
            Is.EqualTo(sizeof(IDCompositionRectangleClip))
        );
    }

    /// <summary>Validates that the <see cref = "IDCompositionRectangleClip"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDCompositionRectangleClip).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDCompositionRectangleClip"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDCompositionRectangleClip), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDCompositionRectangleClip), Is.EqualTo(4));
        }
    }
}
