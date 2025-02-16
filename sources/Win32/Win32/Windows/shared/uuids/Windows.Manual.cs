// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class Windows
{
    /// <summary>A proxy type that wraps a pointer to GUID data. Values of this type can be implicitly converted to and assigned to <see cref = "Guid"/>* or <see cref = "Guid"/> parameters.</summary>

    [EditorBrowsable(EditorBrowsableState.Never)]
    public readonly unsafe ref struct UuidOfType
    {
        private readonly Guid* _value;

        internal UuidOfType(Guid* value)
        {
            _value = value;
        }

        /// <summary>Reads a <see cref = "Guid"/> value from the GUID buffer for a given <see cref = "UuidOfType"/> instance.</summary>
        /// <param name = "value">The input <see cref = "UuidOfType"/> instance to read data for.</param>

        public static implicit operator Guid(UuidOfType value) => *value._value;

        /// <summary>Returns the <see cref = "Guid"/>* pointer to the GUID buffer for a given <see cref = "UuidOfType"/> instance.</summary>
        /// <param name = "value">The input <see cref = "UuidOfType"/> instance to read data for.</param>

        public static implicit operator Guid*(UuidOfType value) => value._value;
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <param name = "value">A value of type <typeparamref name = "T"/>.</param>
    /// <typeparam name = "T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref = "UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref = "Guid"/> pointer, or implicitly assigned to a <see cref = "Guid"/> value.</returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe UuidOfType __uuidof<T>(T value) // for type inference similar to C++'s __uuidof
        where T : unmanaged, INativeGuid
    {
        return new UuidOfType(T.NativeGuid);
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <param name = "value">A pointer to a value of type <typeparamref name = "T"/>.</param>
    /// <typeparam name = "T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref = "UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref = "Guid"/> pointer, or implicitly assigned to a <see cref = "Guid"/> value.</returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe UuidOfType __uuidof<T>(T* value) // for type inference similar to C++'s __uuidof
        where T : unmanaged, INativeGuid
    {
        return new UuidOfType(T.NativeGuid);
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <param name = "value">A pointer to a value of type <typeparamref name = "T"/>.</param>
    /// <typeparam name = "T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref = "UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref = "Guid"/> pointer, or implicitly assigned to a <see cref = "Guid"/> value.</returns>

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe UuidOfType __uuidof<T>(Ref<T> value)
        where T : unmanaged, INativeGuid
    {
        fixed (T* __dsl_value = value)
        {
            return (UuidOfType)__uuidof(__dsl_value);
        }
    }

    /// <summary>Retrieves the GUID of of a specified type.</summary>
    /// <typeparam name = "T">The type to retrieve the GUID for.</typeparam>
    /// <returns>A <see cref = "UuidOfType"/> value wrapping a pointer to the GUID data for the input type. This value can be either converted to a <see cref = "Guid"/> pointer, or implicitly assigned to a <see cref = "Guid"/> value.</returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe UuidOfType __uuidof<T>()
        where T : unmanaged, INativeGuid
    {
        return new UuidOfType(T.NativeGuid);
    }
}
