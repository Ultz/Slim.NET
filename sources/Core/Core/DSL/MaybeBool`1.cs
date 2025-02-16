// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// A boolean represented as an underlying value.
/// </summary>
/// <param name="Value">The underlying value/</param>
/// <typeparam name="T">The underlying type.</typeparam>
public readonly record struct MaybeBool<T>(T Value)
    where T : unmanaged, IEquatable<T>, IIncrementOperators<T>
{
    /// <summary>
    /// Creates a <see cref="MaybeBool{T}"/> from a <typeparamref name="T"/>.
    /// </summary>
    /// <param name="Value">The underlying value.</param>
    /// <returns>The wrapped value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MaybeBool<T>(T Value) => new(Value);

    /// <summary>
    /// Gets the underlying value.
    /// </summary>
    /// <param name="value">The wrapped value.</param>
    /// <returns>The underlying value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator T(MaybeBool<T> value) => value.Value;

    /// <summary>
    /// Creates a boolean wrapper of the specified type representing the given value.
    /// </summary>
    /// <param name="value">The boolean value.</param>
    /// <returns>The wrapped underlying value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator MaybeBool<T>(bool value)
    {
        var val = default(T);
        if (value)
        {
            val++;
        }

        return val;
    }

    /// <summary>
    /// Gets the boolean value of this wrapped value.
    /// </summary>
    /// <param name="value">The wrapped underlying value.</param>
    /// <returns>The boolean value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator bool(MaybeBool<T> value) => !value.Value.Equals(default);

    /// <summary>
    /// compares boolean value and int
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns></returns>
    public static bool operator ==(MaybeBool<T> lh, int rh) => lh == (rh != 0);
    /// <summary>
    /// Compares boolean value and int
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns></returns>
    public static bool operator !=(MaybeBool<T> lh, int rh) => lh != (rh != 0);

    /// <summary>
    /// compares boolean value and int
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns></returns>
    public static bool operator ==(int lh, MaybeBool<T> rh) => (lh != 0) == rh;
    /// <summary>
    /// Compares boolean value and int
    /// </summary>
    /// <param name="lh"></param>
    /// <param name="rh"></param>
    /// <returns></returns>
    public static bool operator !=(int lh, MaybeBool<T> rh) => (lh != 0) != rh;
}
