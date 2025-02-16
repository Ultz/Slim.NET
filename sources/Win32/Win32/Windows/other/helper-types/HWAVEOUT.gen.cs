// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HWAVEOUT
    : IComparable,
        IComparable<HWAVEOUT>,
        IEquatable<HWAVEOUT>,
        IFormattable
{
    public readonly void* Value;

    public HWAVEOUT(void* value)
    {
        Value = value;
    }

    public static HWAVEOUT INVALID_VALUE => new HWAVEOUT((void*)(-1));
    public static HWAVEOUT NULL => new HWAVEOUT(null);

    public static bool operator ==(HWAVEOUT left, HWAVEOUT right) => left.Value == right.Value;

    public static bool operator !=(HWAVEOUT left, HWAVEOUT right) => left.Value != right.Value;

    public static bool operator <(HWAVEOUT left, HWAVEOUT right) => left.Value < right.Value;

    public static bool operator <=(HWAVEOUT left, HWAVEOUT right) => left.Value <= right.Value;

    public static bool operator >(HWAVEOUT left, HWAVEOUT right) => left.Value > right.Value;

    public static bool operator >=(HWAVEOUT left, HWAVEOUT right) => left.Value >= right.Value;

    public static explicit operator HWAVEOUT(void* value) => new HWAVEOUT(value);

    public static implicit operator void*(HWAVEOUT value) => value.Value;

    public static explicit operator HWAVEOUT(HANDLE value) => new HWAVEOUT(value);

    public static implicit operator HANDLE(HWAVEOUT value) => new HANDLE(value.Value);

    public static explicit operator HWAVEOUT(byte value) => new HWAVEOUT(unchecked((void*)(value)));

    public static explicit operator byte(HWAVEOUT value) => (byte)(value.Value);

    public static explicit operator HWAVEOUT(short value) =>
        new HWAVEOUT(unchecked((void*)(value)));

    public static explicit operator short(HWAVEOUT value) => (short)(value.Value);

    public static explicit operator HWAVEOUT(int value) => new HWAVEOUT(unchecked((void*)(value)));

    public static explicit operator int(HWAVEOUT value) => (int)(value.Value);

    public static explicit operator HWAVEOUT(long value) => new HWAVEOUT(unchecked((void*)(value)));

    public static explicit operator long(HWAVEOUT value) => (long)(value.Value);

    public static explicit operator HWAVEOUT(nint value) => new HWAVEOUT(unchecked((void*)(value)));

    public static implicit operator nint(HWAVEOUT value) => (nint)(value.Value);

    public static explicit operator HWAVEOUT(sbyte value) =>
        new HWAVEOUT(unchecked((void*)(value)));

    public static explicit operator sbyte(HWAVEOUT value) => (sbyte)(value.Value);

    public static explicit operator HWAVEOUT(ushort value) =>
        new HWAVEOUT(unchecked((void*)(value)));

    public static explicit operator ushort(HWAVEOUT value) => (ushort)(value.Value);

    public static explicit operator HWAVEOUT(uint value) => new HWAVEOUT(unchecked((void*)(value)));

    public static explicit operator uint(HWAVEOUT value) => (uint)(value.Value);

    public static explicit operator HWAVEOUT(ulong value) =>
        new HWAVEOUT(unchecked((void*)(value)));

    public static explicit operator ulong(HWAVEOUT value) => (ulong)(value.Value);

    public static explicit operator HWAVEOUT(nuint value) =>
        new HWAVEOUT(unchecked((void*)(value)));

    public static implicit operator nuint(HWAVEOUT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HWAVEOUT other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HWAVEOUT.");
    }

    public int CompareTo(HWAVEOUT other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HWAVEOUT other) && Equals(other);

    public bool Equals(HWAVEOUT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
