// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HMONITOR
    : IComparable,
        IComparable<HMONITOR>,
        IEquatable<HMONITOR>,
        IFormattable
{
    public readonly void* Value;

    public HMONITOR(void* value)
    {
        Value = value;
    }

    public static HMONITOR INVALID_VALUE => new HMONITOR((void*)(-1));
    public static HMONITOR NULL => new HMONITOR(null);

    public static bool operator ==(HMONITOR left, HMONITOR right) => left.Value == right.Value;

    public static bool operator !=(HMONITOR left, HMONITOR right) => left.Value != right.Value;

    public static bool operator <(HMONITOR left, HMONITOR right) => left.Value < right.Value;

    public static bool operator <=(HMONITOR left, HMONITOR right) => left.Value <= right.Value;

    public static bool operator >(HMONITOR left, HMONITOR right) => left.Value > right.Value;

    public static bool operator >=(HMONITOR left, HMONITOR right) => left.Value >= right.Value;

    public static explicit operator HMONITOR(void* value) => new HMONITOR(value);

    public static implicit operator void*(HMONITOR value) => value.Value;

    public static explicit operator HMONITOR(HANDLE value) => new HMONITOR(value);

    public static implicit operator HANDLE(HMONITOR value) => new HANDLE(value.Value);

    public static explicit operator HMONITOR(byte value) => new HMONITOR(unchecked((void*)(value)));

    public static explicit operator byte(HMONITOR value) => (byte)(value.Value);

    public static explicit operator HMONITOR(short value) =>
        new HMONITOR(unchecked((void*)(value)));

    public static explicit operator short(HMONITOR value) => (short)(value.Value);

    public static explicit operator HMONITOR(int value) => new HMONITOR(unchecked((void*)(value)));

    public static explicit operator int(HMONITOR value) => (int)(value.Value);

    public static explicit operator HMONITOR(long value) => new HMONITOR(unchecked((void*)(value)));

    public static explicit operator long(HMONITOR value) => (long)(value.Value);

    public static explicit operator HMONITOR(nint value) => new HMONITOR(unchecked((void*)(value)));

    public static implicit operator nint(HMONITOR value) => (nint)(value.Value);

    public static explicit operator HMONITOR(sbyte value) =>
        new HMONITOR(unchecked((void*)(value)));

    public static explicit operator sbyte(HMONITOR value) => (sbyte)(value.Value);

    public static explicit operator HMONITOR(ushort value) =>
        new HMONITOR(unchecked((void*)(value)));

    public static explicit operator ushort(HMONITOR value) => (ushort)(value.Value);

    public static explicit operator HMONITOR(uint value) => new HMONITOR(unchecked((void*)(value)));

    public static explicit operator uint(HMONITOR value) => (uint)(value.Value);

    public static explicit operator HMONITOR(ulong value) =>
        new HMONITOR(unchecked((void*)(value)));

    public static explicit operator ulong(HMONITOR value) => (ulong)(value.Value);

    public static explicit operator HMONITOR(nuint value) =>
        new HMONITOR(unchecked((void*)(value)));

    public static implicit operator nuint(HMONITOR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HMONITOR other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HMONITOR.");
    }

    public int CompareTo(HMONITOR other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HMONITOR other) && Equals(other);

    public bool Equals(HMONITOR other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
