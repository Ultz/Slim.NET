// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct ROPARAMIIDHANDLE
    : IComparable,
        IComparable<ROPARAMIIDHANDLE>,
        IEquatable<ROPARAMIIDHANDLE>,
        IFormattable
{
    public readonly void* Value;

    public ROPARAMIIDHANDLE(void* value)
    {
        Value = value;
    }

    public static ROPARAMIIDHANDLE INVALID_VALUE => new ROPARAMIIDHANDLE((void*)(-1));
    public static ROPARAMIIDHANDLE NULL => new ROPARAMIIDHANDLE(null);

    public static bool operator ==(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) =>
        left.Value == right.Value;

    public static bool operator !=(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) =>
        left.Value != right.Value;

    public static bool operator <(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) =>
        left.Value < right.Value;

    public static bool operator <=(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) =>
        left.Value <= right.Value;

    public static bool operator >(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) =>
        left.Value > right.Value;

    public static bool operator >=(ROPARAMIIDHANDLE left, ROPARAMIIDHANDLE right) =>
        left.Value >= right.Value;

    public static explicit operator ROPARAMIIDHANDLE(void* value) => new ROPARAMIIDHANDLE(value);

    public static implicit operator void*(ROPARAMIIDHANDLE value) => value.Value;

    public static explicit operator ROPARAMIIDHANDLE(HANDLE value) => new ROPARAMIIDHANDLE(value);

    public static implicit operator HANDLE(ROPARAMIIDHANDLE value) => new HANDLE(value.Value);

    public static explicit operator ROPARAMIIDHANDLE(byte value) =>
        new ROPARAMIIDHANDLE(unchecked((void*)(value)));

    public static explicit operator byte(ROPARAMIIDHANDLE value) => (byte)(value.Value);

    public static explicit operator ROPARAMIIDHANDLE(short value) =>
        new ROPARAMIIDHANDLE(unchecked((void*)(value)));

    public static explicit operator short(ROPARAMIIDHANDLE value) => (short)(value.Value);

    public static explicit operator ROPARAMIIDHANDLE(int value) =>
        new ROPARAMIIDHANDLE(unchecked((void*)(value)));

    public static explicit operator int(ROPARAMIIDHANDLE value) => (int)(value.Value);

    public static explicit operator ROPARAMIIDHANDLE(long value) =>
        new ROPARAMIIDHANDLE(unchecked((void*)(value)));

    public static explicit operator long(ROPARAMIIDHANDLE value) => (long)(value.Value);

    public static explicit operator ROPARAMIIDHANDLE(nint value) =>
        new ROPARAMIIDHANDLE(unchecked((void*)(value)));

    public static implicit operator nint(ROPARAMIIDHANDLE value) => (nint)(value.Value);

    public static explicit operator ROPARAMIIDHANDLE(sbyte value) =>
        new ROPARAMIIDHANDLE(unchecked((void*)(value)));

    public static explicit operator sbyte(ROPARAMIIDHANDLE value) => (sbyte)(value.Value);

    public static explicit operator ROPARAMIIDHANDLE(ushort value) =>
        new ROPARAMIIDHANDLE(unchecked((void*)(value)));

    public static explicit operator ushort(ROPARAMIIDHANDLE value) => (ushort)(value.Value);

    public static explicit operator ROPARAMIIDHANDLE(uint value) =>
        new ROPARAMIIDHANDLE(unchecked((void*)(value)));

    public static explicit operator uint(ROPARAMIIDHANDLE value) => (uint)(value.Value);

    public static explicit operator ROPARAMIIDHANDLE(ulong value) =>
        new ROPARAMIIDHANDLE(unchecked((void*)(value)));

    public static explicit operator ulong(ROPARAMIIDHANDLE value) => (ulong)(value.Value);

    public static explicit operator ROPARAMIIDHANDLE(nuint value) =>
        new ROPARAMIIDHANDLE(unchecked((void*)(value)));

    public static implicit operator nuint(ROPARAMIIDHANDLE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is ROPARAMIIDHANDLE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of ROPARAMIIDHANDLE.");
    }

    public int CompareTo(ROPARAMIIDHANDLE other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is ROPARAMIIDHANDLE other) && Equals(other);

    public bool Equals(ROPARAMIIDHANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
