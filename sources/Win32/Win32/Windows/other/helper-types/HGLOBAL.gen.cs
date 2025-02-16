// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HGLOBAL
    : IComparable,
        IComparable<HGLOBAL>,
        IEquatable<HGLOBAL>,
        IFormattable
{
    public readonly void* Value;

    public HGLOBAL(void* value)
    {
        Value = value;
    }

    public static HGLOBAL INVALID_VALUE => new HGLOBAL((void*)(-1));
    public static HGLOBAL NULL => new HGLOBAL(null);

    public static bool operator ==(HGLOBAL left, HGLOBAL right) => left.Value == right.Value;

    public static bool operator !=(HGLOBAL left, HGLOBAL right) => left.Value != right.Value;

    public static bool operator <(HGLOBAL left, HGLOBAL right) => left.Value < right.Value;

    public static bool operator <=(HGLOBAL left, HGLOBAL right) => left.Value <= right.Value;

    public static bool operator >(HGLOBAL left, HGLOBAL right) => left.Value > right.Value;

    public static bool operator >=(HGLOBAL left, HGLOBAL right) => left.Value >= right.Value;

    public static explicit operator HGLOBAL(void* value) => new HGLOBAL(value);

    public static implicit operator void*(HGLOBAL value) => value.Value;

    public static explicit operator HGLOBAL(HANDLE value) => new HGLOBAL(value);

    public static implicit operator HANDLE(HGLOBAL value) => new HANDLE(value.Value);

    public static explicit operator HGLOBAL(byte value) => new HGLOBAL(unchecked((void*)(value)));

    public static explicit operator byte(HGLOBAL value) => (byte)(value.Value);

    public static explicit operator HGLOBAL(short value) => new HGLOBAL(unchecked((void*)(value)));

    public static explicit operator short(HGLOBAL value) => (short)(value.Value);

    public static explicit operator HGLOBAL(int value) => new HGLOBAL(unchecked((void*)(value)));

    public static explicit operator int(HGLOBAL value) => (int)(value.Value);

    public static explicit operator HGLOBAL(long value) => new HGLOBAL(unchecked((void*)(value)));

    public static explicit operator long(HGLOBAL value) => (long)(value.Value);

    public static explicit operator HGLOBAL(nint value) => new HGLOBAL(unchecked((void*)(value)));

    public static implicit operator nint(HGLOBAL value) => (nint)(value.Value);

    public static explicit operator HGLOBAL(sbyte value) => new HGLOBAL(unchecked((void*)(value)));

    public static explicit operator sbyte(HGLOBAL value) => (sbyte)(value.Value);

    public static explicit operator HGLOBAL(ushort value) => new HGLOBAL(unchecked((void*)(value)));

    public static explicit operator ushort(HGLOBAL value) => (ushort)(value.Value);

    public static explicit operator HGLOBAL(uint value) => new HGLOBAL(unchecked((void*)(value)));

    public static explicit operator uint(HGLOBAL value) => (uint)(value.Value);

    public static explicit operator HGLOBAL(ulong value) => new HGLOBAL(unchecked((void*)(value)));

    public static explicit operator ulong(HGLOBAL value) => (ulong)(value.Value);

    public static explicit operator HGLOBAL(nuint value) => new HGLOBAL(unchecked((void*)(value)));

    public static implicit operator nuint(HGLOBAL value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HGLOBAL other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HGLOBAL.");
    }

    public int CompareTo(HGLOBAL other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HGLOBAL other) && Equals(other);

    public bool Equals(HGLOBAL other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
