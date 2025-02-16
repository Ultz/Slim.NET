// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public readonly unsafe partial struct HSTRING
    : IComparable,
        IComparable<HSTRING>,
        IEquatable<HSTRING>,
        IFormattable
{
    public readonly void* Value;

    public HSTRING(void* value)
    {
        Value = value;
    }

    public static HSTRING INVALID_VALUE => new HSTRING((void*)(-1));
    public static HSTRING NULL => new HSTRING(null);

    public static bool operator ==(HSTRING left, HSTRING right) => left.Value == right.Value;

    public static bool operator !=(HSTRING left, HSTRING right) => left.Value != right.Value;

    public static bool operator <(HSTRING left, HSTRING right) => left.Value < right.Value;

    public static bool operator <=(HSTRING left, HSTRING right) => left.Value <= right.Value;

    public static bool operator >(HSTRING left, HSTRING right) => left.Value > right.Value;

    public static bool operator >=(HSTRING left, HSTRING right) => left.Value >= right.Value;

    public static explicit operator HSTRING(void* value) => new HSTRING(value);

    public static implicit operator void*(HSTRING value) => value.Value;

    public static explicit operator HSTRING(HANDLE value) => new HSTRING(value);

    public static implicit operator HANDLE(HSTRING value) => new HANDLE(value.Value);

    public static explicit operator HSTRING(byte value) => new HSTRING(unchecked((void*)(value)));

    public static explicit operator byte(HSTRING value) => (byte)(value.Value);

    public static explicit operator HSTRING(short value) => new HSTRING(unchecked((void*)(value)));

    public static explicit operator short(HSTRING value) => (short)(value.Value);

    public static explicit operator HSTRING(int value) => new HSTRING(unchecked((void*)(value)));

    public static explicit operator int(HSTRING value) => (int)(value.Value);

    public static explicit operator HSTRING(long value) => new HSTRING(unchecked((void*)(value)));

    public static explicit operator long(HSTRING value) => (long)(value.Value);

    public static explicit operator HSTRING(nint value) => new HSTRING(unchecked((void*)(value)));

    public static implicit operator nint(HSTRING value) => (nint)(value.Value);

    public static explicit operator HSTRING(sbyte value) => new HSTRING(unchecked((void*)(value)));

    public static explicit operator sbyte(HSTRING value) => (sbyte)(value.Value);

    public static explicit operator HSTRING(ushort value) => new HSTRING(unchecked((void*)(value)));

    public static explicit operator ushort(HSTRING value) => (ushort)(value.Value);

    public static explicit operator HSTRING(uint value) => new HSTRING(unchecked((void*)(value)));

    public static explicit operator uint(HSTRING value) => (uint)(value.Value);

    public static explicit operator HSTRING(ulong value) => new HSTRING(unchecked((void*)(value)));

    public static explicit operator ulong(HSTRING value) => (ulong)(value.Value);

    public static explicit operator HSTRING(nuint value) => new HSTRING(unchecked((void*)(value)));

    public static implicit operator nuint(HSTRING value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HSTRING other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSTRING.");
    }

    public int CompareTo(HSTRING other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HSTRING other) && Equals(other);

    public bool Equals(HSTRING other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
