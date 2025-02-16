// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCOLORSPACE
    : IComparable,
        IComparable<HCOLORSPACE>,
        IEquatable<HCOLORSPACE>,
        IFormattable
{
    public readonly void* Value;

    public HCOLORSPACE(void* value)
    {
        Value = value;
    }

    public static HCOLORSPACE INVALID_VALUE => new HCOLORSPACE((void*)(-1));
    public static HCOLORSPACE NULL => new HCOLORSPACE(null);

    public static bool operator ==(HCOLORSPACE left, HCOLORSPACE right) =>
        left.Value == right.Value;

    public static bool operator !=(HCOLORSPACE left, HCOLORSPACE right) =>
        left.Value != right.Value;

    public static bool operator <(HCOLORSPACE left, HCOLORSPACE right) => left.Value < right.Value;

    public static bool operator <=(HCOLORSPACE left, HCOLORSPACE right) =>
        left.Value <= right.Value;

    public static bool operator >(HCOLORSPACE left, HCOLORSPACE right) => left.Value > right.Value;

    public static bool operator >=(HCOLORSPACE left, HCOLORSPACE right) =>
        left.Value >= right.Value;

    public static explicit operator HCOLORSPACE(void* value) => new HCOLORSPACE(value);

    public static implicit operator void*(HCOLORSPACE value) => value.Value;

    public static explicit operator HCOLORSPACE(HANDLE value) => new HCOLORSPACE(value);

    public static implicit operator HANDLE(HCOLORSPACE value) => new HANDLE(value.Value);

    public static explicit operator HCOLORSPACE(byte value) =>
        new HCOLORSPACE(unchecked((void*)(value)));

    public static explicit operator byte(HCOLORSPACE value) => (byte)(value.Value);

    public static explicit operator HCOLORSPACE(short value) =>
        new HCOLORSPACE(unchecked((void*)(value)));

    public static explicit operator short(HCOLORSPACE value) => (short)(value.Value);

    public static explicit operator HCOLORSPACE(int value) =>
        new HCOLORSPACE(unchecked((void*)(value)));

    public static explicit operator int(HCOLORSPACE value) => (int)(value.Value);

    public static explicit operator HCOLORSPACE(long value) =>
        new HCOLORSPACE(unchecked((void*)(value)));

    public static explicit operator long(HCOLORSPACE value) => (long)(value.Value);

    public static explicit operator HCOLORSPACE(nint value) =>
        new HCOLORSPACE(unchecked((void*)(value)));

    public static implicit operator nint(HCOLORSPACE value) => (nint)(value.Value);

    public static explicit operator HCOLORSPACE(sbyte value) =>
        new HCOLORSPACE(unchecked((void*)(value)));

    public static explicit operator sbyte(HCOLORSPACE value) => (sbyte)(value.Value);

    public static explicit operator HCOLORSPACE(ushort value) =>
        new HCOLORSPACE(unchecked((void*)(value)));

    public static explicit operator ushort(HCOLORSPACE value) => (ushort)(value.Value);

    public static explicit operator HCOLORSPACE(uint value) =>
        new HCOLORSPACE(unchecked((void*)(value)));

    public static explicit operator uint(HCOLORSPACE value) => (uint)(value.Value);

    public static explicit operator HCOLORSPACE(ulong value) =>
        new HCOLORSPACE(unchecked((void*)(value)));

    public static explicit operator ulong(HCOLORSPACE value) => (ulong)(value.Value);

    public static explicit operator HCOLORSPACE(nuint value) =>
        new HCOLORSPACE(unchecked((void*)(value)));

    public static implicit operator nuint(HCOLORSPACE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCOLORSPACE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCOLORSPACE.");
    }

    public int CompareTo(HCOLORSPACE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCOLORSPACE other) && Equals(other);

    public bool Equals(HCOLORSPACE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
