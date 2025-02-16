// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HRAWINPUT
    : IComparable,
        IComparable<HRAWINPUT>,
        IEquatable<HRAWINPUT>,
        IFormattable
{
    public readonly void* Value;

    public HRAWINPUT(void* value)
    {
        Value = value;
    }

    public static HRAWINPUT INVALID_VALUE => new HRAWINPUT((void*)(-1));
    public static HRAWINPUT NULL => new HRAWINPUT(null);

    public static bool operator ==(HRAWINPUT left, HRAWINPUT right) => left.Value == right.Value;

    public static bool operator !=(HRAWINPUT left, HRAWINPUT right) => left.Value != right.Value;

    public static bool operator <(HRAWINPUT left, HRAWINPUT right) => left.Value < right.Value;

    public static bool operator <=(HRAWINPUT left, HRAWINPUT right) => left.Value <= right.Value;

    public static bool operator >(HRAWINPUT left, HRAWINPUT right) => left.Value > right.Value;

    public static bool operator >=(HRAWINPUT left, HRAWINPUT right) => left.Value >= right.Value;

    public static explicit operator HRAWINPUT(void* value) => new HRAWINPUT(value);

    public static implicit operator void*(HRAWINPUT value) => value.Value;

    public static explicit operator HRAWINPUT(HANDLE value) => new HRAWINPUT(value);

    public static implicit operator HANDLE(HRAWINPUT value) => new HANDLE(value.Value);

    public static explicit operator HRAWINPUT(byte value) =>
        new HRAWINPUT(unchecked((void*)(value)));

    public static explicit operator byte(HRAWINPUT value) => (byte)(value.Value);

    public static explicit operator HRAWINPUT(short value) =>
        new HRAWINPUT(unchecked((void*)(value)));

    public static explicit operator short(HRAWINPUT value) => (short)(value.Value);

    public static explicit operator HRAWINPUT(int value) =>
        new HRAWINPUT(unchecked((void*)(value)));

    public static explicit operator int(HRAWINPUT value) => (int)(value.Value);

    public static explicit operator HRAWINPUT(long value) =>
        new HRAWINPUT(unchecked((void*)(value)));

    public static explicit operator long(HRAWINPUT value) => (long)(value.Value);

    public static explicit operator HRAWINPUT(nint value) =>
        new HRAWINPUT(unchecked((void*)(value)));

    public static implicit operator nint(HRAWINPUT value) => (nint)(value.Value);

    public static explicit operator HRAWINPUT(sbyte value) =>
        new HRAWINPUT(unchecked((void*)(value)));

    public static explicit operator sbyte(HRAWINPUT value) => (sbyte)(value.Value);

    public static explicit operator HRAWINPUT(ushort value) =>
        new HRAWINPUT(unchecked((void*)(value)));

    public static explicit operator ushort(HRAWINPUT value) => (ushort)(value.Value);

    public static explicit operator HRAWINPUT(uint value) =>
        new HRAWINPUT(unchecked((void*)(value)));

    public static explicit operator uint(HRAWINPUT value) => (uint)(value.Value);

    public static explicit operator HRAWINPUT(ulong value) =>
        new HRAWINPUT(unchecked((void*)(value)));

    public static explicit operator ulong(HRAWINPUT value) => (ulong)(value.Value);

    public static explicit operator HRAWINPUT(nuint value) =>
        new HRAWINPUT(unchecked((void*)(value)));

    public static implicit operator nuint(HRAWINPUT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HRAWINPUT other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HRAWINPUT.");
    }

    public int CompareTo(HRAWINPUT other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HRAWINPUT other) && Equals(other);

    public bool Equals(HRAWINPUT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
