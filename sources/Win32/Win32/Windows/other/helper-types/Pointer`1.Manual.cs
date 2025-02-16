// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct Pointer<T>
    : IComparable,
        IComparable<Pointer<T>>,
        IEquatable<Pointer<T>>,
        IFormattable
    where T : unmanaged
{
    public readonly T* Value;

    public Pointer(T* value)
    {
        Value = value;
    }

    public static bool operator ==(Pointer<T> left, Pointer<T> right) => left.Value == right.Value;

    public static bool operator !=(Pointer<T> left, Pointer<T> right) => left.Value != right.Value;

    public static bool operator <(Pointer<T> left, Pointer<T> right) => left.Value < right.Value;

    public static bool operator <=(Pointer<T> left, Pointer<T> right) => left.Value <= right.Value;

    public static bool operator >(Pointer<T> left, Pointer<T> right) => left.Value > right.Value;

    public static bool operator >=(Pointer<T> left, Pointer<T> right) => left.Value >= right.Value;

    public static implicit operator Pointer<T>(T* value) => new Pointer<T>(value);

    public static implicit operator T*(Pointer<T> value) => value.Value;

    public static explicit operator Pointer<T>(void* value) => new Pointer<T>((T*)(value));

    public static implicit operator void*(Pointer<T> value) => value.Value;

    public static explicit operator Pointer<T>(byte value) =>
        new Pointer<T>(unchecked((T*)(value)));

    public static explicit operator byte(Pointer<T> value) => (byte)(value.Value);

    public static explicit operator Pointer<T>(short value) =>
        new Pointer<T>(unchecked((T*)(value)));

    public static explicit operator short(Pointer<T> value) => (short)(value.Value);

    public static explicit operator Pointer<T>(int value) => new Pointer<T>(unchecked((T*)(value)));

    public static explicit operator int(Pointer<T> value) => (int)(value.Value);

    public static explicit operator Pointer<T>(long value) =>
        new Pointer<T>(unchecked((T*)(value)));

    public static explicit operator long(Pointer<T> value) => (long)(value.Value);

    public static explicit operator Pointer<T>(nint value) =>
        new Pointer<T>(unchecked((T*)(value)));

    public static implicit operator nint(Pointer<T> value) => (nint)(value.Value);

    public static explicit operator Pointer<T>(sbyte value) =>
        new Pointer<T>(unchecked((T*)(value)));

    public static explicit operator sbyte(Pointer<T> value) => (sbyte)(value.Value);

    public static explicit operator Pointer<T>(ushort value) =>
        new Pointer<T>(unchecked((T*)(value)));

    public static explicit operator ushort(Pointer<T> value) => (ushort)(value.Value);

    public static explicit operator Pointer<T>(uint value) =>
        new Pointer<T>(unchecked((T*)(value)));

    public static explicit operator uint(Pointer<T> value) => (uint)(value.Value);

    public static explicit operator Pointer<T>(ulong value) =>
        new Pointer<T>(unchecked((T*)(value)));

    public static explicit operator ulong(Pointer<T> value) => (ulong)(value.Value);

    public static explicit operator Pointer<T>(nuint value) =>
        new Pointer<T>(unchecked((T*)(value)));

    public static implicit operator nuint(Pointer<T> value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is Pointer<T> other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of Pointer.");
    }

    public int CompareTo(Pointer<T> other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is Pointer<T> other) && Equals(other);

    public bool Equals(Pointer<T> other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
