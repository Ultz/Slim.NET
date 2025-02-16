// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HINTERACTIONCONTEXT
    : IComparable,
        IComparable<HINTERACTIONCONTEXT>,
        IEquatable<HINTERACTIONCONTEXT>,
        IFormattable
{
    public readonly void* Value;

    public HINTERACTIONCONTEXT(void* value)
    {
        Value = value;
    }

    public static HINTERACTIONCONTEXT INVALID_VALUE => new HINTERACTIONCONTEXT((void*)(-1));
    public static HINTERACTIONCONTEXT NULL => new HINTERACTIONCONTEXT(null);

    public static bool operator ==(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) =>
        left.Value == right.Value;

    public static bool operator !=(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) =>
        left.Value != right.Value;

    public static bool operator <(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) =>
        left.Value < right.Value;

    public static bool operator <=(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) =>
        left.Value <= right.Value;

    public static bool operator >(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) =>
        left.Value > right.Value;

    public static bool operator >=(HINTERACTIONCONTEXT left, HINTERACTIONCONTEXT right) =>
        left.Value >= right.Value;

    public static explicit operator HINTERACTIONCONTEXT(void* value) =>
        new HINTERACTIONCONTEXT(value);

    public static implicit operator void*(HINTERACTIONCONTEXT value) => value.Value;

    public static explicit operator HINTERACTIONCONTEXT(HANDLE value) =>
        new HINTERACTIONCONTEXT(value);

    public static implicit operator HANDLE(HINTERACTIONCONTEXT value) => new HANDLE(value.Value);

    public static explicit operator HINTERACTIONCONTEXT(byte value) =>
        new HINTERACTIONCONTEXT(unchecked((void*)(value)));

    public static explicit operator byte(HINTERACTIONCONTEXT value) => (byte)(value.Value);

    public static explicit operator HINTERACTIONCONTEXT(short value) =>
        new HINTERACTIONCONTEXT(unchecked((void*)(value)));

    public static explicit operator short(HINTERACTIONCONTEXT value) => (short)(value.Value);

    public static explicit operator HINTERACTIONCONTEXT(int value) =>
        new HINTERACTIONCONTEXT(unchecked((void*)(value)));

    public static explicit operator int(HINTERACTIONCONTEXT value) => (int)(value.Value);

    public static explicit operator HINTERACTIONCONTEXT(long value) =>
        new HINTERACTIONCONTEXT(unchecked((void*)(value)));

    public static explicit operator long(HINTERACTIONCONTEXT value) => (long)(value.Value);

    public static explicit operator HINTERACTIONCONTEXT(nint value) =>
        new HINTERACTIONCONTEXT(unchecked((void*)(value)));

    public static implicit operator nint(HINTERACTIONCONTEXT value) => (nint)(value.Value);

    public static explicit operator HINTERACTIONCONTEXT(sbyte value) =>
        new HINTERACTIONCONTEXT(unchecked((void*)(value)));

    public static explicit operator sbyte(HINTERACTIONCONTEXT value) => (sbyte)(value.Value);

    public static explicit operator HINTERACTIONCONTEXT(ushort value) =>
        new HINTERACTIONCONTEXT(unchecked((void*)(value)));

    public static explicit operator ushort(HINTERACTIONCONTEXT value) => (ushort)(value.Value);

    public static explicit operator HINTERACTIONCONTEXT(uint value) =>
        new HINTERACTIONCONTEXT(unchecked((void*)(value)));

    public static explicit operator uint(HINTERACTIONCONTEXT value) => (uint)(value.Value);

    public static explicit operator HINTERACTIONCONTEXT(ulong value) =>
        new HINTERACTIONCONTEXT(unchecked((void*)(value)));

    public static explicit operator ulong(HINTERACTIONCONTEXT value) => (ulong)(value.Value);

    public static explicit operator HINTERACTIONCONTEXT(nuint value) =>
        new HINTERACTIONCONTEXT(unchecked((void*)(value)));

    public static implicit operator nuint(HINTERACTIONCONTEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HINTERACTIONCONTEXT other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HINTERACTIONCONTEXT.");
    }

    public int CompareTo(HINTERACTIONCONTEXT other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HINTERACTIONCONTEXT other) && Equals(other);

    public bool Equals(HINTERACTIONCONTEXT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
