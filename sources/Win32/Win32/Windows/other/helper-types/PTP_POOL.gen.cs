// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct PTP_POOL
    : IComparable,
        IComparable<PTP_POOL>,
        IEquatable<PTP_POOL>,
        IFormattable
{
    public readonly void* Value;

    public PTP_POOL(void* value)
    {
        Value = value;
    }

    public static PTP_POOL NULL => new PTP_POOL(null);

    public static bool operator ==(PTP_POOL left, PTP_POOL right) => left.Value == right.Value;

    public static bool operator !=(PTP_POOL left, PTP_POOL right) => left.Value != right.Value;

    public static bool operator <(PTP_POOL left, PTP_POOL right) => left.Value < right.Value;

    public static bool operator <=(PTP_POOL left, PTP_POOL right) => left.Value <= right.Value;

    public static bool operator >(PTP_POOL left, PTP_POOL right) => left.Value > right.Value;

    public static bool operator >=(PTP_POOL left, PTP_POOL right) => left.Value >= right.Value;

    public static explicit operator PTP_POOL(void* value) => new PTP_POOL(value);

    public static implicit operator void*(PTP_POOL value) => value.Value;

    public static explicit operator PTP_POOL(byte value) => new PTP_POOL(unchecked((void*)(value)));

    public static explicit operator byte(PTP_POOL value) => (byte)(value.Value);

    public static explicit operator PTP_POOL(short value) =>
        new PTP_POOL(unchecked((void*)(value)));

    public static explicit operator short(PTP_POOL value) => (short)(value.Value);

    public static explicit operator PTP_POOL(int value) => new PTP_POOL(unchecked((void*)(value)));

    public static explicit operator int(PTP_POOL value) => (int)(value.Value);

    public static explicit operator PTP_POOL(long value) => new PTP_POOL(unchecked((void*)(value)));

    public static explicit operator long(PTP_POOL value) => (long)(value.Value);

    public static explicit operator PTP_POOL(nint value) => new PTP_POOL(unchecked((void*)(value)));

    public static implicit operator nint(PTP_POOL value) => (nint)(value.Value);

    public static explicit operator PTP_POOL(sbyte value) =>
        new PTP_POOL(unchecked((void*)(value)));

    public static explicit operator sbyte(PTP_POOL value) => (sbyte)(value.Value);

    public static explicit operator PTP_POOL(ushort value) =>
        new PTP_POOL(unchecked((void*)(value)));

    public static explicit operator ushort(PTP_POOL value) => (ushort)(value.Value);

    public static explicit operator PTP_POOL(uint value) => new PTP_POOL(unchecked((void*)(value)));

    public static explicit operator uint(PTP_POOL value) => (uint)(value.Value);

    public static explicit operator PTP_POOL(ulong value) =>
        new PTP_POOL(unchecked((void*)(value)));

    public static explicit operator ulong(PTP_POOL value) => (ulong)(value.Value);

    public static explicit operator PTP_POOL(nuint value) =>
        new PTP_POOL(unchecked((void*)(value)));

    public static implicit operator nuint(PTP_POOL value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PTP_POOL other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PTP_POOL.");
    }

    public int CompareTo(PTP_POOL other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is PTP_POOL other) && Equals(other);

    public bool Equals(PTP_POOL other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
