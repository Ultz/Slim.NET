// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HMETAFILEPICT
    : IComparable,
        IComparable<HMETAFILEPICT>,
        IEquatable<HMETAFILEPICT>,
        IFormattable
{
    public readonly void* Value;

    public HMETAFILEPICT(void* value)
    {
        Value = value;
    }

    public static HMETAFILEPICT INVALID_VALUE => new HMETAFILEPICT((void*)(-1));
    public static HMETAFILEPICT NULL => new HMETAFILEPICT(null);

    public static bool operator ==(HMETAFILEPICT left, HMETAFILEPICT right) =>
        left.Value == right.Value;

    public static bool operator !=(HMETAFILEPICT left, HMETAFILEPICT right) =>
        left.Value != right.Value;

    public static bool operator <(HMETAFILEPICT left, HMETAFILEPICT right) =>
        left.Value < right.Value;

    public static bool operator <=(HMETAFILEPICT left, HMETAFILEPICT right) =>
        left.Value <= right.Value;

    public static bool operator >(HMETAFILEPICT left, HMETAFILEPICT right) =>
        left.Value > right.Value;

    public static bool operator >=(HMETAFILEPICT left, HMETAFILEPICT right) =>
        left.Value >= right.Value;

    public static explicit operator HMETAFILEPICT(void* value) => new HMETAFILEPICT(value);

    public static implicit operator void*(HMETAFILEPICT value) => value.Value;

    public static explicit operator HMETAFILEPICT(HANDLE value) => new HMETAFILEPICT(value);

    public static implicit operator HANDLE(HMETAFILEPICT value) => new HANDLE(value.Value);

    public static explicit operator HMETAFILEPICT(byte value) =>
        new HMETAFILEPICT(unchecked((void*)(value)));

    public static explicit operator byte(HMETAFILEPICT value) => (byte)(value.Value);

    public static explicit operator HMETAFILEPICT(short value) =>
        new HMETAFILEPICT(unchecked((void*)(value)));

    public static explicit operator short(HMETAFILEPICT value) => (short)(value.Value);

    public static explicit operator HMETAFILEPICT(int value) =>
        new HMETAFILEPICT(unchecked((void*)(value)));

    public static explicit operator int(HMETAFILEPICT value) => (int)(value.Value);

    public static explicit operator HMETAFILEPICT(long value) =>
        new HMETAFILEPICT(unchecked((void*)(value)));

    public static explicit operator long(HMETAFILEPICT value) => (long)(value.Value);

    public static explicit operator HMETAFILEPICT(nint value) =>
        new HMETAFILEPICT(unchecked((void*)(value)));

    public static implicit operator nint(HMETAFILEPICT value) => (nint)(value.Value);

    public static explicit operator HMETAFILEPICT(sbyte value) =>
        new HMETAFILEPICT(unchecked((void*)(value)));

    public static explicit operator sbyte(HMETAFILEPICT value) => (sbyte)(value.Value);

    public static explicit operator HMETAFILEPICT(ushort value) =>
        new HMETAFILEPICT(unchecked((void*)(value)));

    public static explicit operator ushort(HMETAFILEPICT value) => (ushort)(value.Value);

    public static explicit operator HMETAFILEPICT(uint value) =>
        new HMETAFILEPICT(unchecked((void*)(value)));

    public static explicit operator uint(HMETAFILEPICT value) => (uint)(value.Value);

    public static explicit operator HMETAFILEPICT(ulong value) =>
        new HMETAFILEPICT(unchecked((void*)(value)));

    public static explicit operator ulong(HMETAFILEPICT value) => (ulong)(value.Value);

    public static explicit operator HMETAFILEPICT(nuint value) =>
        new HMETAFILEPICT(unchecked((void*)(value)));

    public static implicit operator nuint(HMETAFILEPICT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HMETAFILEPICT other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMETAFILEPICT.");
    }

    public int CompareTo(HMETAFILEPICT other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HMETAFILEPICT other) && Equals(other);

    public bool Equals(HMETAFILEPICT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
