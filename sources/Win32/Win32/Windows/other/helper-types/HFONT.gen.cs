// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HFONT
    : IComparable,
        IComparable<HFONT>,
        IEquatable<HFONT>,
        IFormattable
{
    public readonly void* Value;

    public HFONT(void* value)
    {
        Value = value;
    }

    public static HFONT INVALID_VALUE => new HFONT((void*)(-1));
    public static HFONT NULL => new HFONT(null);

    public static bool operator ==(HFONT left, HFONT right) => left.Value == right.Value;

    public static bool operator !=(HFONT left, HFONT right) => left.Value != right.Value;

    public static bool operator <(HFONT left, HFONT right) => left.Value < right.Value;

    public static bool operator <=(HFONT left, HFONT right) => left.Value <= right.Value;

    public static bool operator >(HFONT left, HFONT right) => left.Value > right.Value;

    public static bool operator >=(HFONT left, HFONT right) => left.Value >= right.Value;

    public static explicit operator HFONT(void* value) => new HFONT(value);

    public static implicit operator void*(HFONT value) => value.Value;

    public static explicit operator HFONT(HANDLE value) => new HFONT(value);

    public static implicit operator HANDLE(HFONT value) => new HANDLE(value.Value);

    public static explicit operator HFONT(byte value) => new HFONT(unchecked((void*)(value)));

    public static explicit operator byte(HFONT value) => (byte)(value.Value);

    public static explicit operator HFONT(short value) => new HFONT(unchecked((void*)(value)));

    public static explicit operator short(HFONT value) => (short)(value.Value);

    public static explicit operator HFONT(int value) => new HFONT(unchecked((void*)(value)));

    public static explicit operator int(HFONT value) => (int)(value.Value);

    public static explicit operator HFONT(long value) => new HFONT(unchecked((void*)(value)));

    public static explicit operator long(HFONT value) => (long)(value.Value);

    public static explicit operator HFONT(nint value) => new HFONT(unchecked((void*)(value)));

    public static implicit operator nint(HFONT value) => (nint)(value.Value);

    public static explicit operator HFONT(sbyte value) => new HFONT(unchecked((void*)(value)));

    public static explicit operator sbyte(HFONT value) => (sbyte)(value.Value);

    public static explicit operator HFONT(ushort value) => new HFONT(unchecked((void*)(value)));

    public static explicit operator ushort(HFONT value) => (ushort)(value.Value);

    public static explicit operator HFONT(uint value) => new HFONT(unchecked((void*)(value)));

    public static explicit operator uint(HFONT value) => (uint)(value.Value);

    public static explicit operator HFONT(ulong value) => new HFONT(unchecked((void*)(value)));

    public static explicit operator ulong(HFONT value) => (ulong)(value.Value);

    public static explicit operator HFONT(nuint value) => new HFONT(unchecked((void*)(value)));

    public static implicit operator nuint(HFONT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HFONT other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HFONT.");
    }

    public int CompareTo(HFONT other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HFONT other) && Equals(other);

    public bool Equals(HFONT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
