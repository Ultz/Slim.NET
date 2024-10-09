// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXCoreAdapterMemoryBudget"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class DXCoreAdapterMemoryBudgetTests
{
    /// <summary>Validates that the <see cref = "DXCoreAdapterMemoryBudget"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DXCoreAdapterMemoryBudget>(),
            Is.EqualTo(sizeof(DXCoreAdapterMemoryBudget))
        );
    }

    /// <summary>Validates that the <see cref = "DXCoreAdapterMemoryBudget"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXCoreAdapterMemoryBudget).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXCoreAdapterMemoryBudget"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXCoreAdapterMemoryBudget), Is.EqualTo(32));
    }
}
