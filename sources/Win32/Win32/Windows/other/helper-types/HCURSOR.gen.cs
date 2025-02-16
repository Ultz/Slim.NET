// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCURSOR
    : IComparable,
        IComparable<HCURSOR>,
        IEquatable<HCURSOR>,
        IFormattable
{
    public readonly void* Value;

    public HCURSOR(void* value)
    {
        Value = value;
    }

    public static HCURSOR INVALID_VALUE => new HCURSOR((void*)(-1));
    public static HCURSOR NULL => new HCURSOR(null);

    public static bool operator ==(HCURSOR left, HCURSOR right) => left.Value == right.Value;

    public static bool operator !=(HCURSOR left, HCURSOR right) => left.Value != right.Value;

    public static bool operator <(HCURSOR left, HCURSOR right) => left.Value < right.Value;

    public static bool operator <=(HCURSOR left, HCURSOR right) => left.Value <= right.Value;

    public static bool operator >(HCURSOR left, HCURSOR right) => left.Value > right.Value;

    public static bool operator >=(HCURSOR left, HCURSOR right) => left.Value >= right.Value;

    public static explicit operator HCURSOR(void* value) => new HCURSOR(value);

    public static implicit operator void*(HCURSOR value) => value.Value;

    public static explicit operator HCURSOR(HANDLE value) => new HCURSOR(value);

    public static implicit operator HANDLE(HCURSOR value) => new HANDLE(value.Value);

    public static explicit operator HCURSOR(byte value) => new HCURSOR(unchecked((void*)(value)));

    public static explicit operator byte(HCURSOR value) => (byte)(value.Value);

    public static explicit operator HCURSOR(short value) => new HCURSOR(unchecked((void*)(value)));

    public static explicit operator short(HCURSOR value) => (short)(value.Value);

    public static explicit operator HCURSOR(int value) => new HCURSOR(unchecked((void*)(value)));

    public static explicit operator int(HCURSOR value) => (int)(value.Value);

    public static explicit operator HCURSOR(long value) => new HCURSOR(unchecked((void*)(value)));

    public static explicit operator long(HCURSOR value) => (long)(value.Value);

    public static explicit operator HCURSOR(nint value) => new HCURSOR(unchecked((void*)(value)));

    public static implicit operator nint(HCURSOR value) => (nint)(value.Value);

    public static explicit operator HCURSOR(sbyte value) => new HCURSOR(unchecked((void*)(value)));

    public static explicit operator sbyte(HCURSOR value) => (sbyte)(value.Value);

    public static explicit operator HCURSOR(ushort value) => new HCURSOR(unchecked((void*)(value)));

    public static explicit operator ushort(HCURSOR value) => (ushort)(value.Value);

    public static explicit operator HCURSOR(uint value) => new HCURSOR(unchecked((void*)(value)));

    public static explicit operator uint(HCURSOR value) => (uint)(value.Value);

    public static explicit operator HCURSOR(ulong value) => new HCURSOR(unchecked((void*)(value)));

    public static explicit operator ulong(HCURSOR value) => (ulong)(value.Value);

    public static explicit operator HCURSOR(nuint value) => new HCURSOR(unchecked((void*)(value)));

    public static implicit operator nuint(HCURSOR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCURSOR other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCURSOR.");
    }

    public int CompareTo(HCURSOR other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCURSOR other) && Equals(other);

    public bool Equals(HCURSOR other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
