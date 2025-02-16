// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public readonly unsafe partial struct InstanceHandle
    : IComparable,
        IComparable<InstanceHandle>,
        IEquatable<InstanceHandle>,
        IFormattable
{
    public readonly ulong Value;

    public InstanceHandle(ulong value)
    {
        Value = value;
    }

    public static bool operator ==(InstanceHandle left, InstanceHandle right) =>
        left.Value == right.Value;

    public static bool operator !=(InstanceHandle left, InstanceHandle right) =>
        left.Value != right.Value;

    public static bool operator <(InstanceHandle left, InstanceHandle right) =>
        left.Value < right.Value;

    public static bool operator <=(InstanceHandle left, InstanceHandle right) =>
        left.Value <= right.Value;

    public static bool operator >(InstanceHandle left, InstanceHandle right) =>
        left.Value > right.Value;

    public static bool operator >=(InstanceHandle left, InstanceHandle right) =>
        left.Value >= right.Value;

    public static implicit operator InstanceHandle(byte value) => new InstanceHandle(value);

    public static explicit operator byte(InstanceHandle value) => (byte)(value.Value);

    public static explicit operator InstanceHandle(short value) =>
        new InstanceHandle(unchecked((ulong)(value)));

    public static explicit operator short(InstanceHandle value) => (short)(value.Value);

    public static explicit operator InstanceHandle(int value) =>
        new InstanceHandle(unchecked((ulong)(value)));

    public static explicit operator int(InstanceHandle value) => (int)(value.Value);

    public static explicit operator InstanceHandle(long value) =>
        new InstanceHandle(unchecked((ulong)(value)));

    public static explicit operator long(InstanceHandle value) => (long)(value.Value);

    public static explicit operator InstanceHandle(nint value) =>
        new InstanceHandle(unchecked((ulong)(value)));

    public static explicit operator nint(InstanceHandle value) => (nint)(value.Value);

    public static explicit operator InstanceHandle(sbyte value) =>
        new InstanceHandle(unchecked((ulong)(value)));

    public static explicit operator sbyte(InstanceHandle value) => (sbyte)(value.Value);

    public static implicit operator InstanceHandle(ushort value) => new InstanceHandle(value);

    public static explicit operator ushort(InstanceHandle value) => (ushort)(value.Value);

    public static implicit operator InstanceHandle(uint value) => new InstanceHandle(value);

    public static explicit operator uint(InstanceHandle value) => (uint)(value.Value);

    public static implicit operator InstanceHandle(ulong value) => new InstanceHandle(value);

    public static implicit operator ulong(InstanceHandle value) => value.Value;

    public static implicit operator InstanceHandle(nuint value) => new InstanceHandle(value);

    public static explicit operator nuint(InstanceHandle value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is InstanceHandle other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of InstanceHandle.");
    }

    public int CompareTo(InstanceHandle other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is InstanceHandle other) && Equals(other);

    public bool Equals(InstanceHandle other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString("X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        Value.ToString(format, formatProvider);
}
