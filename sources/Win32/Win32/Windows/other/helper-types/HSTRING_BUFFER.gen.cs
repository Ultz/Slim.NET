// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public readonly unsafe partial struct HSTRING_BUFFER
    : IComparable,
        IComparable<HSTRING_BUFFER>,
        IEquatable<HSTRING_BUFFER>,
        IFormattable
{
    public readonly void* Value;

    public HSTRING_BUFFER(void* value)
    {
        Value = value;
    }

    public static HSTRING_BUFFER INVALID_VALUE => new HSTRING_BUFFER((void*)(-1));
    public static HSTRING_BUFFER NULL => new HSTRING_BUFFER(null);

    public static bool operator ==(HSTRING_BUFFER left, HSTRING_BUFFER right) =>
        left.Value == right.Value;

    public static bool operator !=(HSTRING_BUFFER left, HSTRING_BUFFER right) =>
        left.Value != right.Value;

    public static bool operator <(HSTRING_BUFFER left, HSTRING_BUFFER right) =>
        left.Value < right.Value;

    public static bool operator <=(HSTRING_BUFFER left, HSTRING_BUFFER right) =>
        left.Value <= right.Value;

    public static bool operator >(HSTRING_BUFFER left, HSTRING_BUFFER right) =>
        left.Value > right.Value;

    public static bool operator >=(HSTRING_BUFFER left, HSTRING_BUFFER right) =>
        left.Value >= right.Value;

    public static explicit operator HSTRING_BUFFER(void* value) => new HSTRING_BUFFER(value);

    public static implicit operator void*(HSTRING_BUFFER value) => value.Value;

    public static explicit operator HSTRING_BUFFER(HANDLE value) => new HSTRING_BUFFER(value);

    public static implicit operator HANDLE(HSTRING_BUFFER value) => new HANDLE(value.Value);

    public static explicit operator HSTRING_BUFFER(byte value) =>
        new HSTRING_BUFFER(unchecked((void*)(value)));

    public static explicit operator byte(HSTRING_BUFFER value) => (byte)(value.Value);

    public static explicit operator HSTRING_BUFFER(short value) =>
        new HSTRING_BUFFER(unchecked((void*)(value)));

    public static explicit operator short(HSTRING_BUFFER value) => (short)(value.Value);

    public static explicit operator HSTRING_BUFFER(int value) =>
        new HSTRING_BUFFER(unchecked((void*)(value)));

    public static explicit operator int(HSTRING_BUFFER value) => (int)(value.Value);

    public static explicit operator HSTRING_BUFFER(long value) =>
        new HSTRING_BUFFER(unchecked((void*)(value)));

    public static explicit operator long(HSTRING_BUFFER value) => (long)(value.Value);

    public static explicit operator HSTRING_BUFFER(nint value) =>
        new HSTRING_BUFFER(unchecked((void*)(value)));

    public static implicit operator nint(HSTRING_BUFFER value) => (nint)(value.Value);

    public static explicit operator HSTRING_BUFFER(sbyte value) =>
        new HSTRING_BUFFER(unchecked((void*)(value)));

    public static explicit operator sbyte(HSTRING_BUFFER value) => (sbyte)(value.Value);

    public static explicit operator HSTRING_BUFFER(ushort value) =>
        new HSTRING_BUFFER(unchecked((void*)(value)));

    public static explicit operator ushort(HSTRING_BUFFER value) => (ushort)(value.Value);

    public static explicit operator HSTRING_BUFFER(uint value) =>
        new HSTRING_BUFFER(unchecked((void*)(value)));

    public static explicit operator uint(HSTRING_BUFFER value) => (uint)(value.Value);

    public static explicit operator HSTRING_BUFFER(ulong value) =>
        new HSTRING_BUFFER(unchecked((void*)(value)));

    public static explicit operator ulong(HSTRING_BUFFER value) => (ulong)(value.Value);

    public static explicit operator HSTRING_BUFFER(nuint value) =>
        new HSTRING_BUFFER(unchecked((void*)(value)));

    public static implicit operator nuint(HSTRING_BUFFER value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HSTRING_BUFFER other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HSTRING_BUFFER.");
    }

    public int CompareTo(HSTRING_BUFFER other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HSTRING_BUFFER other) && Equals(other);

    public bool Equals(HSTRING_BUFFER other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
