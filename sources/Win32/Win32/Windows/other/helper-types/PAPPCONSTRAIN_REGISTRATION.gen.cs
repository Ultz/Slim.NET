// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct PAPPCONSTRAIN_REGISTRATION
    : IComparable,
        IComparable<PAPPCONSTRAIN_REGISTRATION>,
        IEquatable<PAPPCONSTRAIN_REGISTRATION>,
        IFormattable
{
    public readonly void* Value;

    public PAPPCONSTRAIN_REGISTRATION(void* value)
    {
        Value = value;
    }

    public static PAPPCONSTRAIN_REGISTRATION NULL => new PAPPCONSTRAIN_REGISTRATION(null);

    public static bool operator ==(
        PAPPCONSTRAIN_REGISTRATION left,
        PAPPCONSTRAIN_REGISTRATION right
    ) => left.Value == right.Value;

    public static bool operator !=(
        PAPPCONSTRAIN_REGISTRATION left,
        PAPPCONSTRAIN_REGISTRATION right
    ) => left.Value != right.Value;

    public static bool operator <(
        PAPPCONSTRAIN_REGISTRATION left,
        PAPPCONSTRAIN_REGISTRATION right
    ) => left.Value < right.Value;

    public static bool operator <=(
        PAPPCONSTRAIN_REGISTRATION left,
        PAPPCONSTRAIN_REGISTRATION right
    ) => left.Value <= right.Value;

    public static bool operator >(
        PAPPCONSTRAIN_REGISTRATION left,
        PAPPCONSTRAIN_REGISTRATION right
    ) => left.Value > right.Value;

    public static bool operator >=(
        PAPPCONSTRAIN_REGISTRATION left,
        PAPPCONSTRAIN_REGISTRATION right
    ) => left.Value >= right.Value;

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(void* value) =>
        new PAPPCONSTRAIN_REGISTRATION(value);

    public static implicit operator void*(PAPPCONSTRAIN_REGISTRATION value) => value.Value;

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(byte value) =>
        new PAPPCONSTRAIN_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator byte(PAPPCONSTRAIN_REGISTRATION value) => (byte)(value.Value);

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(short value) =>
        new PAPPCONSTRAIN_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator short(PAPPCONSTRAIN_REGISTRATION value) => (short)(value.Value);

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(int value) =>
        new PAPPCONSTRAIN_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator int(PAPPCONSTRAIN_REGISTRATION value) => (int)(value.Value);

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(long value) =>
        new PAPPCONSTRAIN_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator long(PAPPCONSTRAIN_REGISTRATION value) => (long)(value.Value);

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(nint value) =>
        new PAPPCONSTRAIN_REGISTRATION(unchecked((void*)(value)));

    public static implicit operator nint(PAPPCONSTRAIN_REGISTRATION value) => (nint)(value.Value);

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(sbyte value) =>
        new PAPPCONSTRAIN_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator sbyte(PAPPCONSTRAIN_REGISTRATION value) => (sbyte)(value.Value);

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(ushort value) =>
        new PAPPCONSTRAIN_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator ushort(PAPPCONSTRAIN_REGISTRATION value) =>
        (ushort)(value.Value);

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(uint value) =>
        new PAPPCONSTRAIN_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator uint(PAPPCONSTRAIN_REGISTRATION value) => (uint)(value.Value);

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(ulong value) =>
        new PAPPCONSTRAIN_REGISTRATION(unchecked((void*)(value)));

    public static explicit operator ulong(PAPPCONSTRAIN_REGISTRATION value) => (ulong)(value.Value);

    public static explicit operator PAPPCONSTRAIN_REGISTRATION(nuint value) =>
        new PAPPCONSTRAIN_REGISTRATION(unchecked((void*)(value)));

    public static implicit operator nuint(PAPPCONSTRAIN_REGISTRATION value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PAPPCONSTRAIN_REGISTRATION other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PAPPCONSTRAIN_REGISTRATION.");
    }

    public int CompareTo(PAPPCONSTRAIN_REGISTRATION other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is PAPPCONSTRAIN_REGISTRATION other) && Equals(other);

    public bool Equals(PAPPCONSTRAIN_REGISTRATION other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
