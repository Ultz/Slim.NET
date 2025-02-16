// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HTREEITEM
    : IComparable,
        IComparable<HTREEITEM>,
        IEquatable<HTREEITEM>,
        IFormattable
{
    public readonly void* Value;

    public HTREEITEM(void* value)
    {
        Value = value;
    }

    public static HTREEITEM INVALID_VALUE => new HTREEITEM((void*)(-1));
    public static HTREEITEM NULL => new HTREEITEM(null);

    public static bool operator ==(HTREEITEM left, HTREEITEM right) => left.Value == right.Value;

    public static bool operator !=(HTREEITEM left, HTREEITEM right) => left.Value != right.Value;

    public static bool operator <(HTREEITEM left, HTREEITEM right) => left.Value < right.Value;

    public static bool operator <=(HTREEITEM left, HTREEITEM right) => left.Value <= right.Value;

    public static bool operator >(HTREEITEM left, HTREEITEM right) => left.Value > right.Value;

    public static bool operator >=(HTREEITEM left, HTREEITEM right) => left.Value >= right.Value;

    public static explicit operator HTREEITEM(void* value) => new HTREEITEM(value);

    public static implicit operator void*(HTREEITEM value) => value.Value;

    public static explicit operator HTREEITEM(HANDLE value) => new HTREEITEM(value);

    public static implicit operator HANDLE(HTREEITEM value) => new HANDLE(value.Value);

    public static explicit operator HTREEITEM(byte value) =>
        new HTREEITEM(unchecked((void*)(value)));

    public static explicit operator byte(HTREEITEM value) => (byte)(value.Value);

    public static explicit operator HTREEITEM(short value) =>
        new HTREEITEM(unchecked((void*)(value)));

    public static explicit operator short(HTREEITEM value) => (short)(value.Value);

    public static explicit operator HTREEITEM(int value) =>
        new HTREEITEM(unchecked((void*)(value)));

    public static explicit operator int(HTREEITEM value) => (int)(value.Value);

    public static explicit operator HTREEITEM(long value) =>
        new HTREEITEM(unchecked((void*)(value)));

    public static explicit operator long(HTREEITEM value) => (long)(value.Value);

    public static explicit operator HTREEITEM(nint value) =>
        new HTREEITEM(unchecked((void*)(value)));

    public static implicit operator nint(HTREEITEM value) => (nint)(value.Value);

    public static explicit operator HTREEITEM(sbyte value) =>
        new HTREEITEM(unchecked((void*)(value)));

    public static explicit operator sbyte(HTREEITEM value) => (sbyte)(value.Value);

    public static explicit operator HTREEITEM(ushort value) =>
        new HTREEITEM(unchecked((void*)(value)));

    public static explicit operator ushort(HTREEITEM value) => (ushort)(value.Value);

    public static explicit operator HTREEITEM(uint value) =>
        new HTREEITEM(unchecked((void*)(value)));

    public static explicit operator uint(HTREEITEM value) => (uint)(value.Value);

    public static explicit operator HTREEITEM(ulong value) =>
        new HTREEITEM(unchecked((void*)(value)));

    public static explicit operator ulong(HTREEITEM value) => (ulong)(value.Value);

    public static explicit operator HTREEITEM(nuint value) =>
        new HTREEITEM(unchecked((void*)(value)));

    public static implicit operator nuint(HTREEITEM value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HTREEITEM other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HTREEITEM.");
    }

    public int CompareTo(HTREEITEM other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HTREEITEM other) && Equals(other);

    public bool Equals(HTREEITEM other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
