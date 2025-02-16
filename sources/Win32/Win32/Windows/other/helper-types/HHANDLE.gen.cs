// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HHANDLE
    : IComparable,
        IComparable<HHANDLE>,
        IEquatable<HHANDLE>,
        IFormattable
{
    public readonly void* Value;

    public HHANDLE(void* value)
    {
        Value = value;
    }

    public static HHANDLE INVALID_VALUE => new HHANDLE((void*)(-1));
    public static HHANDLE NULL => new HHANDLE(null);

    public static bool operator ==(HHANDLE left, HHANDLE right) => left.Value == right.Value;

    public static bool operator !=(HHANDLE left, HHANDLE right) => left.Value != right.Value;

    public static bool operator <(HHANDLE left, HHANDLE right) => left.Value < right.Value;

    public static bool operator <=(HHANDLE left, HHANDLE right) => left.Value <= right.Value;

    public static bool operator >(HHANDLE left, HHANDLE right) => left.Value > right.Value;

    public static bool operator >=(HHANDLE left, HHANDLE right) => left.Value >= right.Value;

    public static explicit operator HHANDLE(void* value) => new HHANDLE(value);

    public static implicit operator void*(HHANDLE value) => value.Value;

    public static explicit operator HHANDLE(HANDLE value) => new HHANDLE(value);

    public static implicit operator HANDLE(HHANDLE value) => new HANDLE(value.Value);

    public static explicit operator HHANDLE(byte value) => new HHANDLE(unchecked((void*)(value)));

    public static explicit operator byte(HHANDLE value) => (byte)(value.Value);

    public static explicit operator HHANDLE(short value) => new HHANDLE(unchecked((void*)(value)));

    public static explicit operator short(HHANDLE value) => (short)(value.Value);

    public static explicit operator HHANDLE(int value) => new HHANDLE(unchecked((void*)(value)));

    public static explicit operator int(HHANDLE value) => (int)(value.Value);

    public static explicit operator HHANDLE(long value) => new HHANDLE(unchecked((void*)(value)));

    public static explicit operator long(HHANDLE value) => (long)(value.Value);

    public static explicit operator HHANDLE(nint value) => new HHANDLE(unchecked((void*)(value)));

    public static implicit operator nint(HHANDLE value) => (nint)(value.Value);

    public static explicit operator HHANDLE(sbyte value) => new HHANDLE(unchecked((void*)(value)));

    public static explicit operator sbyte(HHANDLE value) => (sbyte)(value.Value);

    public static explicit operator HHANDLE(ushort value) => new HHANDLE(unchecked((void*)(value)));

    public static explicit operator ushort(HHANDLE value) => (ushort)(value.Value);

    public static explicit operator HHANDLE(uint value) => new HHANDLE(unchecked((void*)(value)));

    public static explicit operator uint(HHANDLE value) => (uint)(value.Value);

    public static explicit operator HHANDLE(ulong value) => new HHANDLE(unchecked((void*)(value)));

    public static explicit operator ulong(HHANDLE value) => (ulong)(value.Value);

    public static explicit operator HHANDLE(nuint value) => new HHANDLE(unchecked((void*)(value)));

    public static implicit operator nuint(HHANDLE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HHANDLE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HHANDLE.");
    }

    public int CompareTo(HHANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HHANDLE other) && Equals(other);

    public bool Equals(HHANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
