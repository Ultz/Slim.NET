// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct PTP_CLEANUP_GROUP
    : IComparable,
        IComparable<PTP_CLEANUP_GROUP>,
        IEquatable<PTP_CLEANUP_GROUP>,
        IFormattable
{
    public readonly void* Value;

    public PTP_CLEANUP_GROUP(void* value)
    {
        Value = value;
    }

    public static PTP_CLEANUP_GROUP NULL => new PTP_CLEANUP_GROUP(null);

    public static bool operator ==(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) =>
        left.Value == right.Value;

    public static bool operator !=(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) =>
        left.Value != right.Value;

    public static bool operator <(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) =>
        left.Value < right.Value;

    public static bool operator <=(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) =>
        left.Value <= right.Value;

    public static bool operator >(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) =>
        left.Value > right.Value;

    public static bool operator >=(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) =>
        left.Value >= right.Value;

    public static explicit operator PTP_CLEANUP_GROUP(void* value) => new PTP_CLEANUP_GROUP(value);

    public static implicit operator void*(PTP_CLEANUP_GROUP value) => value.Value;

    public static explicit operator PTP_CLEANUP_GROUP(byte value) =>
        new PTP_CLEANUP_GROUP(unchecked((void*)(value)));

    public static explicit operator byte(PTP_CLEANUP_GROUP value) => (byte)(value.Value);

    public static explicit operator PTP_CLEANUP_GROUP(short value) =>
        new PTP_CLEANUP_GROUP(unchecked((void*)(value)));

    public static explicit operator short(PTP_CLEANUP_GROUP value) => (short)(value.Value);

    public static explicit operator PTP_CLEANUP_GROUP(int value) =>
        new PTP_CLEANUP_GROUP(unchecked((void*)(value)));

    public static explicit operator int(PTP_CLEANUP_GROUP value) => (int)(value.Value);

    public static explicit operator PTP_CLEANUP_GROUP(long value) =>
        new PTP_CLEANUP_GROUP(unchecked((void*)(value)));

    public static explicit operator long(PTP_CLEANUP_GROUP value) => (long)(value.Value);

    public static explicit operator PTP_CLEANUP_GROUP(nint value) =>
        new PTP_CLEANUP_GROUP(unchecked((void*)(value)));

    public static implicit operator nint(PTP_CLEANUP_GROUP value) => (nint)(value.Value);

    public static explicit operator PTP_CLEANUP_GROUP(sbyte value) =>
        new PTP_CLEANUP_GROUP(unchecked((void*)(value)));

    public static explicit operator sbyte(PTP_CLEANUP_GROUP value) => (sbyte)(value.Value);

    public static explicit operator PTP_CLEANUP_GROUP(ushort value) =>
        new PTP_CLEANUP_GROUP(unchecked((void*)(value)));

    public static explicit operator ushort(PTP_CLEANUP_GROUP value) => (ushort)(value.Value);

    public static explicit operator PTP_CLEANUP_GROUP(uint value) =>
        new PTP_CLEANUP_GROUP(unchecked((void*)(value)));

    public static explicit operator uint(PTP_CLEANUP_GROUP value) => (uint)(value.Value);

    public static explicit operator PTP_CLEANUP_GROUP(ulong value) =>
        new PTP_CLEANUP_GROUP(unchecked((void*)(value)));

    public static explicit operator ulong(PTP_CLEANUP_GROUP value) => (ulong)(value.Value);

    public static explicit operator PTP_CLEANUP_GROUP(nuint value) =>
        new PTP_CLEANUP_GROUP(unchecked((void*)(value)));

    public static implicit operator nuint(PTP_CLEANUP_GROUP value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PTP_CLEANUP_GROUP other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of PTP_CLEANUP_GROUP.");
    }

    public int CompareTo(PTP_CLEANUP_GROUP other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is PTP_CLEANUP_GROUP other) && Equals(other);

    public bool Equals(PTP_CLEANUP_GROUP other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
