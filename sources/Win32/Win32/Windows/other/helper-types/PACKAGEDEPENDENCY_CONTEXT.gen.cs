// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct PACKAGEDEPENDENCY_CONTEXT
    : IComparable,
        IComparable<PACKAGEDEPENDENCY_CONTEXT>,
        IEquatable<PACKAGEDEPENDENCY_CONTEXT>,
        IFormattable
{
    public readonly void* Value;

    public PACKAGEDEPENDENCY_CONTEXT(void* value)
    {
        Value = value;
    }

    public static PACKAGEDEPENDENCY_CONTEXT NULL => new PACKAGEDEPENDENCY_CONTEXT(null);

    public static bool operator ==(
        PACKAGEDEPENDENCY_CONTEXT left,
        PACKAGEDEPENDENCY_CONTEXT right
    ) => left.Value == right.Value;

    public static bool operator !=(
        PACKAGEDEPENDENCY_CONTEXT left,
        PACKAGEDEPENDENCY_CONTEXT right
    ) => left.Value != right.Value;

    public static bool operator <(
        PACKAGEDEPENDENCY_CONTEXT left,
        PACKAGEDEPENDENCY_CONTEXT right
    ) => left.Value < right.Value;

    public static bool operator <=(
        PACKAGEDEPENDENCY_CONTEXT left,
        PACKAGEDEPENDENCY_CONTEXT right
    ) => left.Value <= right.Value;

    public static bool operator >(
        PACKAGEDEPENDENCY_CONTEXT left,
        PACKAGEDEPENDENCY_CONTEXT right
    ) => left.Value > right.Value;

    public static bool operator >=(
        PACKAGEDEPENDENCY_CONTEXT left,
        PACKAGEDEPENDENCY_CONTEXT right
    ) => left.Value >= right.Value;

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(void* value) =>
        new PACKAGEDEPENDENCY_CONTEXT(value);

    public static implicit operator void*(PACKAGEDEPENDENCY_CONTEXT value) => value.Value;

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(byte value) =>
        new PACKAGEDEPENDENCY_CONTEXT(unchecked((void*)(value)));

    public static explicit operator byte(PACKAGEDEPENDENCY_CONTEXT value) => (byte)(value.Value);

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(short value) =>
        new PACKAGEDEPENDENCY_CONTEXT(unchecked((void*)(value)));

    public static explicit operator short(PACKAGEDEPENDENCY_CONTEXT value) => (short)(value.Value);

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(int value) =>
        new PACKAGEDEPENDENCY_CONTEXT(unchecked((void*)(value)));

    public static explicit operator int(PACKAGEDEPENDENCY_CONTEXT value) => (int)(value.Value);

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(long value) =>
        new PACKAGEDEPENDENCY_CONTEXT(unchecked((void*)(value)));

    public static explicit operator long(PACKAGEDEPENDENCY_CONTEXT value) => (long)(value.Value);

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(nint value) =>
        new PACKAGEDEPENDENCY_CONTEXT(unchecked((void*)(value)));

    public static implicit operator nint(PACKAGEDEPENDENCY_CONTEXT value) => (nint)(value.Value);

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(sbyte value) =>
        new PACKAGEDEPENDENCY_CONTEXT(unchecked((void*)(value)));

    public static explicit operator sbyte(PACKAGEDEPENDENCY_CONTEXT value) => (sbyte)(value.Value);

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(ushort value) =>
        new PACKAGEDEPENDENCY_CONTEXT(unchecked((void*)(value)));

    public static explicit operator ushort(PACKAGEDEPENDENCY_CONTEXT value) =>
        (ushort)(value.Value);

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(uint value) =>
        new PACKAGEDEPENDENCY_CONTEXT(unchecked((void*)(value)));

    public static explicit operator uint(PACKAGEDEPENDENCY_CONTEXT value) => (uint)(value.Value);

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(ulong value) =>
        new PACKAGEDEPENDENCY_CONTEXT(unchecked((void*)(value)));

    public static explicit operator ulong(PACKAGEDEPENDENCY_CONTEXT value) => (ulong)(value.Value);

    public static explicit operator PACKAGEDEPENDENCY_CONTEXT(nuint value) =>
        new PACKAGEDEPENDENCY_CONTEXT(unchecked((void*)(value)));

    public static implicit operator nuint(PACKAGEDEPENDENCY_CONTEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PACKAGEDEPENDENCY_CONTEXT other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PACKAGEDEPENDENCY_CONTEXT.");
    }

    public int CompareTo(PACKAGEDEPENDENCY_CONTEXT other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PACKAGEDEPENDENCY_CONTEXT other) && Equals(other);

    public bool Equals(PACKAGEDEPENDENCY_CONTEXT other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
