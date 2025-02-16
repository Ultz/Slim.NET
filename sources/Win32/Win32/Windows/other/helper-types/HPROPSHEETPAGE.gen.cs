// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HPROPSHEETPAGE
    : IComparable,
        IComparable<HPROPSHEETPAGE>,
        IEquatable<HPROPSHEETPAGE>,
        IFormattable
{
    public readonly void* Value;

    public HPROPSHEETPAGE(void* value)
    {
        Value = value;
    }

    public static HPROPSHEETPAGE INVALID_VALUE => new HPROPSHEETPAGE((void*)(-1));
    public static HPROPSHEETPAGE NULL => new HPROPSHEETPAGE(null);

    public static bool operator ==(HPROPSHEETPAGE left, HPROPSHEETPAGE right) =>
        left.Value == right.Value;

    public static bool operator !=(HPROPSHEETPAGE left, HPROPSHEETPAGE right) =>
        left.Value != right.Value;

    public static bool operator <(HPROPSHEETPAGE left, HPROPSHEETPAGE right) =>
        left.Value < right.Value;

    public static bool operator <=(HPROPSHEETPAGE left, HPROPSHEETPAGE right) =>
        left.Value <= right.Value;

    public static bool operator >(HPROPSHEETPAGE left, HPROPSHEETPAGE right) =>
        left.Value > right.Value;

    public static bool operator >=(HPROPSHEETPAGE left, HPROPSHEETPAGE right) =>
        left.Value >= right.Value;

    public static explicit operator HPROPSHEETPAGE(void* value) => new HPROPSHEETPAGE(value);

    public static implicit operator void*(HPROPSHEETPAGE value) => value.Value;

    public static explicit operator HPROPSHEETPAGE(HANDLE value) => new HPROPSHEETPAGE(value);

    public static implicit operator HANDLE(HPROPSHEETPAGE value) => new HANDLE(value.Value);

    public static explicit operator HPROPSHEETPAGE(byte value) =>
        new HPROPSHEETPAGE(unchecked((void*)(value)));

    public static explicit operator byte(HPROPSHEETPAGE value) => (byte)(value.Value);

    public static explicit operator HPROPSHEETPAGE(short value) =>
        new HPROPSHEETPAGE(unchecked((void*)(value)));

    public static explicit operator short(HPROPSHEETPAGE value) => (short)(value.Value);

    public static explicit operator HPROPSHEETPAGE(int value) =>
        new HPROPSHEETPAGE(unchecked((void*)(value)));

    public static explicit operator int(HPROPSHEETPAGE value) => (int)(value.Value);

    public static explicit operator HPROPSHEETPAGE(long value) =>
        new HPROPSHEETPAGE(unchecked((void*)(value)));

    public static explicit operator long(HPROPSHEETPAGE value) => (long)(value.Value);

    public static explicit operator HPROPSHEETPAGE(nint value) =>
        new HPROPSHEETPAGE(unchecked((void*)(value)));

    public static implicit operator nint(HPROPSHEETPAGE value) => (nint)(value.Value);

    public static explicit operator HPROPSHEETPAGE(sbyte value) =>
        new HPROPSHEETPAGE(unchecked((void*)(value)));

    public static explicit operator sbyte(HPROPSHEETPAGE value) => (sbyte)(value.Value);

    public static explicit operator HPROPSHEETPAGE(ushort value) =>
        new HPROPSHEETPAGE(unchecked((void*)(value)));

    public static explicit operator ushort(HPROPSHEETPAGE value) => (ushort)(value.Value);

    public static explicit operator HPROPSHEETPAGE(uint value) =>
        new HPROPSHEETPAGE(unchecked((void*)(value)));

    public static explicit operator uint(HPROPSHEETPAGE value) => (uint)(value.Value);

    public static explicit operator HPROPSHEETPAGE(ulong value) =>
        new HPROPSHEETPAGE(unchecked((void*)(value)));

    public static explicit operator ulong(HPROPSHEETPAGE value) => (ulong)(value.Value);

    public static explicit operator HPROPSHEETPAGE(nuint value) =>
        new HPROPSHEETPAGE(unchecked((void*)(value)));

    public static implicit operator nuint(HPROPSHEETPAGE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HPROPSHEETPAGE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HPROPSHEETPAGE.");
    }

    public int CompareTo(HPROPSHEETPAGE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HPROPSHEETPAGE other) && Equals(other);

    public bool Equals(HPROPSHEETPAGE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
