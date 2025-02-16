// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct SPSTATEHANDLE
    : IComparable,
        IComparable<SPSTATEHANDLE>,
        IEquatable<SPSTATEHANDLE>,
        IFormattable
{
    public readonly void* Value;

    public SPSTATEHANDLE(void* value)
    {
        Value = value;
    }

    public static SPSTATEHANDLE INVALID_VALUE => new SPSTATEHANDLE((void*)(-1));
    public static SPSTATEHANDLE NULL => new SPSTATEHANDLE(null);

    public static bool operator ==(SPSTATEHANDLE left, SPSTATEHANDLE right) =>
        left.Value == right.Value;

    public static bool operator !=(SPSTATEHANDLE left, SPSTATEHANDLE right) =>
        left.Value != right.Value;

    public static bool operator <(SPSTATEHANDLE left, SPSTATEHANDLE right) =>
        left.Value < right.Value;

    public static bool operator <=(SPSTATEHANDLE left, SPSTATEHANDLE right) =>
        left.Value <= right.Value;

    public static bool operator >(SPSTATEHANDLE left, SPSTATEHANDLE right) =>
        left.Value > right.Value;

    public static bool operator >=(SPSTATEHANDLE left, SPSTATEHANDLE right) =>
        left.Value >= right.Value;

    public static explicit operator SPSTATEHANDLE(void* value) => new SPSTATEHANDLE(value);

    public static implicit operator void*(SPSTATEHANDLE value) => value.Value;

    public static explicit operator SPSTATEHANDLE(HANDLE value) => new SPSTATEHANDLE(value);

    public static implicit operator HANDLE(SPSTATEHANDLE value) => new HANDLE(value.Value);

    public static explicit operator SPSTATEHANDLE(byte value) =>
        new SPSTATEHANDLE(unchecked((void*)(value)));

    public static explicit operator byte(SPSTATEHANDLE value) => (byte)(value.Value);

    public static explicit operator SPSTATEHANDLE(short value) =>
        new SPSTATEHANDLE(unchecked((void*)(value)));

    public static explicit operator short(SPSTATEHANDLE value) => (short)(value.Value);

    public static explicit operator SPSTATEHANDLE(int value) =>
        new SPSTATEHANDLE(unchecked((void*)(value)));

    public static explicit operator int(SPSTATEHANDLE value) => (int)(value.Value);

    public static explicit operator SPSTATEHANDLE(long value) =>
        new SPSTATEHANDLE(unchecked((void*)(value)));

    public static explicit operator long(SPSTATEHANDLE value) => (long)(value.Value);

    public static explicit operator SPSTATEHANDLE(nint value) =>
        new SPSTATEHANDLE(unchecked((void*)(value)));

    public static implicit operator nint(SPSTATEHANDLE value) => (nint)(value.Value);

    public static explicit operator SPSTATEHANDLE(sbyte value) =>
        new SPSTATEHANDLE(unchecked((void*)(value)));

    public static explicit operator sbyte(SPSTATEHANDLE value) => (sbyte)(value.Value);

    public static explicit operator SPSTATEHANDLE(ushort value) =>
        new SPSTATEHANDLE(unchecked((void*)(value)));

    public static explicit operator ushort(SPSTATEHANDLE value) => (ushort)(value.Value);

    public static explicit operator SPSTATEHANDLE(uint value) =>
        new SPSTATEHANDLE(unchecked((void*)(value)));

    public static explicit operator uint(SPSTATEHANDLE value) => (uint)(value.Value);

    public static explicit operator SPSTATEHANDLE(ulong value) =>
        new SPSTATEHANDLE(unchecked((void*)(value)));

    public static explicit operator ulong(SPSTATEHANDLE value) => (ulong)(value.Value);

    public static explicit operator SPSTATEHANDLE(nuint value) =>
        new SPSTATEHANDLE(unchecked((void*)(value)));

    public static implicit operator nuint(SPSTATEHANDLE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is SPSTATEHANDLE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of SPSTATEHANDLE.");
    }

    public int CompareTo(SPSTATEHANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is SPSTATEHANDLE other) && Equals(other);

    public bool Equals(SPSTATEHANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
