// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HTHEME
    : IComparable,
        IComparable<HTHEME>,
        IEquatable<HTHEME>,
        IFormattable
{
    public readonly void* Value;

    public HTHEME(void* value)
    {
        Value = value;
    }

    public static HTHEME INVALID_VALUE => new HTHEME((void*)(-1));
    public static HTHEME NULL => new HTHEME(null);

    public static bool operator ==(HTHEME left, HTHEME right) => left.Value == right.Value;

    public static bool operator !=(HTHEME left, HTHEME right) => left.Value != right.Value;

    public static bool operator <(HTHEME left, HTHEME right) => left.Value < right.Value;

    public static bool operator <=(HTHEME left, HTHEME right) => left.Value <= right.Value;

    public static bool operator >(HTHEME left, HTHEME right) => left.Value > right.Value;

    public static bool operator >=(HTHEME left, HTHEME right) => left.Value >= right.Value;

    public static explicit operator HTHEME(void* value) => new HTHEME(value);

    public static implicit operator void*(HTHEME value) => value.Value;

    public static explicit operator HTHEME(HANDLE value) => new HTHEME(value);

    public static implicit operator HANDLE(HTHEME value) => new HANDLE(value.Value);

    public static explicit operator HTHEME(byte value) => new HTHEME(unchecked((void*)(value)));

    public static explicit operator byte(HTHEME value) => (byte)(value.Value);

    public static explicit operator HTHEME(short value) => new HTHEME(unchecked((void*)(value)));

    public static explicit operator short(HTHEME value) => (short)(value.Value);

    public static explicit operator HTHEME(int value) => new HTHEME(unchecked((void*)(value)));

    public static explicit operator int(HTHEME value) => (int)(value.Value);

    public static explicit operator HTHEME(long value) => new HTHEME(unchecked((void*)(value)));

    public static explicit operator long(HTHEME value) => (long)(value.Value);

    public static explicit operator HTHEME(nint value) => new HTHEME(unchecked((void*)(value)));

    public static implicit operator nint(HTHEME value) => (nint)(value.Value);

    public static explicit operator HTHEME(sbyte value) => new HTHEME(unchecked((void*)(value)));

    public static explicit operator sbyte(HTHEME value) => (sbyte)(value.Value);

    public static explicit operator HTHEME(ushort value) => new HTHEME(unchecked((void*)(value)));

    public static explicit operator ushort(HTHEME value) => (ushort)(value.Value);

    public static explicit operator HTHEME(uint value) => new HTHEME(unchecked((void*)(value)));

    public static explicit operator uint(HTHEME value) => (uint)(value.Value);

    public static explicit operator HTHEME(ulong value) => new HTHEME(unchecked((void*)(value)));

    public static explicit operator ulong(HTHEME value) => (ulong)(value.Value);

    public static explicit operator HTHEME(nuint value) => new HTHEME(unchecked((void*)(value)));

    public static implicit operator nuint(HTHEME value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HTHEME other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HTHEME.");
    }

    public int CompareTo(HTHEME other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HTHEME other) && Equals(other);

    public bool Equals(HTHEME other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
