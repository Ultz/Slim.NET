// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CODECAPI_AVEncVideoUseLTRFrame"/> struct.</summary>
public static unsafe partial class CODECAPI_AVEncVideoUseLTRFrameTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "CODECAPI_AVEncVideoUseLTRFrame"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(CODECAPI_AVEncVideoUseLTRFrame).GUID,
            Is.EqualTo(IID_CODECAPI_AVEncVideoUseLTRFrame)
        );
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVEncVideoUseLTRFrame"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CODECAPI_AVEncVideoUseLTRFrame>(),
            Is.EqualTo(sizeof(CODECAPI_AVEncVideoUseLTRFrame))
        );
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVEncVideoUseLTRFrame"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CODECAPI_AVEncVideoUseLTRFrame).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVEncVideoUseLTRFrame"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CODECAPI_AVEncVideoUseLTRFrame), Is.EqualTo(1));
    }
}
