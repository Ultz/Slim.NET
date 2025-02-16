// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCATADMIN
    : IComparable,
        IComparable<HCATADMIN>,
        IEquatable<HCATADMIN>,
        IFormattable
{
    public readonly void* Value;

    public HCATADMIN(void* value)
    {
        Value = value;
    }

    public static HCATADMIN INVALID_VALUE => new HCATADMIN((void*)(-1));
    public static HCATADMIN NULL => new HCATADMIN(null);

    public static bool operator ==(HCATADMIN left, HCATADMIN right) => left.Value == right.Value;

    public static bool operator !=(HCATADMIN left, HCATADMIN right) => left.Value != right.Value;

    public static bool operator <(HCATADMIN left, HCATADMIN right) => left.Value < right.Value;

    public static bool operator <=(HCATADMIN left, HCATADMIN right) => left.Value <= right.Value;

    public static bool operator >(HCATADMIN left, HCATADMIN right) => left.Value > right.Value;

    public static bool operator >=(HCATADMIN left, HCATADMIN right) => left.Value >= right.Value;

    public static explicit operator HCATADMIN(void* value) => new HCATADMIN(value);

    public static implicit operator void*(HCATADMIN value) => value.Value;

    public static explicit operator HCATADMIN(HANDLE value) => new HCATADMIN(value);

    public static implicit operator HANDLE(HCATADMIN value) => new HANDLE(value.Value);

    public static explicit operator HCATADMIN(byte value) =>
        new HCATADMIN(unchecked((void*)(value)));

    public static explicit operator byte(HCATADMIN value) => (byte)(value.Value);

    public static explicit operator HCATADMIN(short value) =>
        new HCATADMIN(unchecked((void*)(value)));

    public static explicit operator short(HCATADMIN value) => (short)(value.Value);

    public static explicit operator HCATADMIN(int value) =>
        new HCATADMIN(unchecked((void*)(value)));

    public static explicit operator int(HCATADMIN value) => (int)(value.Value);

    public static explicit operator HCATADMIN(long value) =>
        new HCATADMIN(unchecked((void*)(value)));

    public static explicit operator long(HCATADMIN value) => (long)(value.Value);

    public static explicit operator HCATADMIN(nint value) =>
        new HCATADMIN(unchecked((void*)(value)));

    public static implicit operator nint(HCATADMIN value) => (nint)(value.Value);

    public static explicit operator HCATADMIN(sbyte value) =>
        new HCATADMIN(unchecked((void*)(value)));

    public static explicit operator sbyte(HCATADMIN value) => (sbyte)(value.Value);

    public static explicit operator HCATADMIN(ushort value) =>
        new HCATADMIN(unchecked((void*)(value)));

    public static explicit operator ushort(HCATADMIN value) => (ushort)(value.Value);

    public static explicit operator HCATADMIN(uint value) =>
        new HCATADMIN(unchecked((void*)(value)));

    public static explicit operator uint(HCATADMIN value) => (uint)(value.Value);

    public static explicit operator HCATADMIN(ulong value) =>
        new HCATADMIN(unchecked((void*)(value)));

    public static explicit operator ulong(HCATADMIN value) => (ulong)(value.Value);

    public static explicit operator HCATADMIN(nuint value) =>
        new HCATADMIN(unchecked((void*)(value)));

    public static implicit operator nuint(HCATADMIN value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCATADMIN other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCATADMIN.");
    }

    public int CompareTo(HCATADMIN other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCATADMIN other) && Equals(other);

    public bool Equals(HCATADMIN other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
