// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HIMAGELIST
    : IComparable,
        IComparable<HIMAGELIST>,
        IEquatable<HIMAGELIST>,
        IFormattable
{
    public readonly void* Value;

    public HIMAGELIST(void* value)
    {
        Value = value;
    }

    public static HIMAGELIST INVALID_VALUE => new HIMAGELIST((void*)(-1));
    public static HIMAGELIST NULL => new HIMAGELIST(null);

    public static bool operator ==(HIMAGELIST left, HIMAGELIST right) => left.Value == right.Value;

    public static bool operator !=(HIMAGELIST left, HIMAGELIST right) => left.Value != right.Value;

    public static bool operator <(HIMAGELIST left, HIMAGELIST right) => left.Value < right.Value;

    public static bool operator <=(HIMAGELIST left, HIMAGELIST right) => left.Value <= right.Value;

    public static bool operator >(HIMAGELIST left, HIMAGELIST right) => left.Value > right.Value;

    public static bool operator >=(HIMAGELIST left, HIMAGELIST right) => left.Value >= right.Value;

    public static explicit operator HIMAGELIST(void* value) => new HIMAGELIST(value);

    public static implicit operator void*(HIMAGELIST value) => value.Value;

    public static explicit operator HIMAGELIST(HANDLE value) => new HIMAGELIST(value);

    public static implicit operator HANDLE(HIMAGELIST value) => new HANDLE(value.Value);

    public static explicit operator HIMAGELIST(byte value) =>
        new HIMAGELIST(unchecked((void*)(value)));

    public static explicit operator byte(HIMAGELIST value) => (byte)(value.Value);

    public static explicit operator HIMAGELIST(short value) =>
        new HIMAGELIST(unchecked((void*)(value)));

    public static explicit operator short(HIMAGELIST value) => (short)(value.Value);

    public static explicit operator HIMAGELIST(int value) =>
        new HIMAGELIST(unchecked((void*)(value)));

    public static explicit operator int(HIMAGELIST value) => (int)(value.Value);

    public static explicit operator HIMAGELIST(long value) =>
        new HIMAGELIST(unchecked((void*)(value)));

    public static explicit operator long(HIMAGELIST value) => (long)(value.Value);

    public static explicit operator HIMAGELIST(nint value) =>
        new HIMAGELIST(unchecked((void*)(value)));

    public static implicit operator nint(HIMAGELIST value) => (nint)(value.Value);

    public static explicit operator HIMAGELIST(sbyte value) =>
        new HIMAGELIST(unchecked((void*)(value)));

    public static explicit operator sbyte(HIMAGELIST value) => (sbyte)(value.Value);

    public static explicit operator HIMAGELIST(ushort value) =>
        new HIMAGELIST(unchecked((void*)(value)));

    public static explicit operator ushort(HIMAGELIST value) => (ushort)(value.Value);

    public static explicit operator HIMAGELIST(uint value) =>
        new HIMAGELIST(unchecked((void*)(value)));

    public static explicit operator uint(HIMAGELIST value) => (uint)(value.Value);

    public static explicit operator HIMAGELIST(ulong value) =>
        new HIMAGELIST(unchecked((void*)(value)));

    public static explicit operator ulong(HIMAGELIST value) => (ulong)(value.Value);

    public static explicit operator HIMAGELIST(nuint value) =>
        new HIMAGELIST(unchecked((void*)(value)));

    public static implicit operator nuint(HIMAGELIST value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HIMAGELIST other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HIMAGELIST.");
    }

    public int CompareTo(HIMAGELIST other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HIMAGELIST other) && Equals(other);

    public bool Equals(HIMAGELIST other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
