// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCRYPTASYNC
    : IComparable,
        IComparable<HCRYPTASYNC>,
        IEquatable<HCRYPTASYNC>,
        IFormattable
{
    public readonly void* Value;

    public HCRYPTASYNC(void* value)
    {
        Value = value;
    }

    public static HCRYPTASYNC INVALID_VALUE => new HCRYPTASYNC((void*)(-1));
    public static HCRYPTASYNC NULL => new HCRYPTASYNC(null);

    public static bool operator ==(HCRYPTASYNC left, HCRYPTASYNC right) =>
        left.Value == right.Value;

    public static bool operator !=(HCRYPTASYNC left, HCRYPTASYNC right) =>
        left.Value != right.Value;

    public static bool operator <(HCRYPTASYNC left, HCRYPTASYNC right) => left.Value < right.Value;

    public static bool operator <=(HCRYPTASYNC left, HCRYPTASYNC right) =>
        left.Value <= right.Value;

    public static bool operator >(HCRYPTASYNC left, HCRYPTASYNC right) => left.Value > right.Value;

    public static bool operator >=(HCRYPTASYNC left, HCRYPTASYNC right) =>
        left.Value >= right.Value;

    public static explicit operator HCRYPTASYNC(void* value) => new HCRYPTASYNC(value);

    public static implicit operator void*(HCRYPTASYNC value) => value.Value;

    public static explicit operator HCRYPTASYNC(HANDLE value) => new HCRYPTASYNC(value);

    public static implicit operator HANDLE(HCRYPTASYNC value) => new HANDLE(value.Value);

    public static explicit operator HCRYPTASYNC(byte value) =>
        new HCRYPTASYNC(unchecked((void*)(value)));

    public static explicit operator byte(HCRYPTASYNC value) => (byte)(value.Value);

    public static explicit operator HCRYPTASYNC(short value) =>
        new HCRYPTASYNC(unchecked((void*)(value)));

    public static explicit operator short(HCRYPTASYNC value) => (short)(value.Value);

    public static explicit operator HCRYPTASYNC(int value) =>
        new HCRYPTASYNC(unchecked((void*)(value)));

    public static explicit operator int(HCRYPTASYNC value) => (int)(value.Value);

    public static explicit operator HCRYPTASYNC(long value) =>
        new HCRYPTASYNC(unchecked((void*)(value)));

    public static explicit operator long(HCRYPTASYNC value) => (long)(value.Value);

    public static explicit operator HCRYPTASYNC(nint value) =>
        new HCRYPTASYNC(unchecked((void*)(value)));

    public static implicit operator nint(HCRYPTASYNC value) => (nint)(value.Value);

    public static explicit operator HCRYPTASYNC(sbyte value) =>
        new HCRYPTASYNC(unchecked((void*)(value)));

    public static explicit operator sbyte(HCRYPTASYNC value) => (sbyte)(value.Value);

    public static explicit operator HCRYPTASYNC(ushort value) =>
        new HCRYPTASYNC(unchecked((void*)(value)));

    public static explicit operator ushort(HCRYPTASYNC value) => (ushort)(value.Value);

    public static explicit operator HCRYPTASYNC(uint value) =>
        new HCRYPTASYNC(unchecked((void*)(value)));

    public static explicit operator uint(HCRYPTASYNC value) => (uint)(value.Value);

    public static explicit operator HCRYPTASYNC(ulong value) =>
        new HCRYPTASYNC(unchecked((void*)(value)));

    public static explicit operator ulong(HCRYPTASYNC value) => (ulong)(value.Value);

    public static explicit operator HCRYPTASYNC(nuint value) =>
        new HCRYPTASYNC(unchecked((void*)(value)));

    public static implicit operator nuint(HCRYPTASYNC value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCRYPTASYNC other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTASYNC.");
    }

    public int CompareTo(HCRYPTASYNC other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCRYPTASYNC other) && Equals(other);

    public bool Equals(HCRYPTASYNC other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
