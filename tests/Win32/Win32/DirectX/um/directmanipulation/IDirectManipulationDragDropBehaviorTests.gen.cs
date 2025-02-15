// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDirectManipulationDragDropBehavior"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IDirectManipulationDragDropBehaviorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirectManipulationDragDropBehavior"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IDirectManipulationDragDropBehavior).GUID,
            Is.EqualTo(IID_IDirectManipulationDragDropBehavior)
        );
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationDragDropBehavior"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IDirectManipulationDragDropBehavior>(),
            Is.EqualTo(sizeof(IDirectManipulationDragDropBehavior))
        );
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationDragDropBehavior"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectManipulationDragDropBehavior).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationDragDropBehavior"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectManipulationDragDropBehavior), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectManipulationDragDropBehavior), Is.EqualTo(4));
        }
    }
}
