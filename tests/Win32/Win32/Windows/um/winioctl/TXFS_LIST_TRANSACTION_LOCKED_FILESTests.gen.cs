// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TXFS_LIST_TRANSACTION_LOCKED_FILES"/> struct.</summary>
public static unsafe partial class TXFS_LIST_TRANSACTION_LOCKED_FILESTests
{
    /// <summary>Validates that the <see cref = "TXFS_LIST_TRANSACTION_LOCKED_FILES"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<TXFS_LIST_TRANSACTION_LOCKED_FILES>(),
            Is.EqualTo(sizeof(TXFS_LIST_TRANSACTION_LOCKED_FILES))
        );
    }

    /// <summary>Validates that the <see cref = "TXFS_LIST_TRANSACTION_LOCKED_FILES"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TXFS_LIST_TRANSACTION_LOCKED_FILES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TXFS_LIST_TRANSACTION_LOCKED_FILES"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TXFS_LIST_TRANSACTION_LOCKED_FILES), Is.EqualTo(40));
    }
}
