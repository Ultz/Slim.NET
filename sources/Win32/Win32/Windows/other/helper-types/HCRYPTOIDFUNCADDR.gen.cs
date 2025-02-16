// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCRYPTOIDFUNCADDR
    : IComparable,
        IComparable<HCRYPTOIDFUNCADDR>,
        IEquatable<HCRYPTOIDFUNCADDR>,
        IFormattable
{
    public readonly void* Value;

    public HCRYPTOIDFUNCADDR(void* value)
    {
        Value = value;
    }

    public static HCRYPTOIDFUNCADDR INVALID_VALUE => new HCRYPTOIDFUNCADDR((void*)(-1));
    public static HCRYPTOIDFUNCADDR NULL => new HCRYPTOIDFUNCADDR(null);

    public static bool operator ==(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) =>
        left.Value == right.Value;

    public static bool operator !=(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) =>
        left.Value != right.Value;

    public static bool operator <(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) =>
        left.Value < right.Value;

    public static bool operator <=(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) =>
        left.Value <= right.Value;

    public static bool operator >(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) =>
        left.Value > right.Value;

    public static bool operator >=(HCRYPTOIDFUNCADDR left, HCRYPTOIDFUNCADDR right) =>
        left.Value >= right.Value;

    public static explicit operator HCRYPTOIDFUNCADDR(void* value) => new HCRYPTOIDFUNCADDR(value);

    public static implicit operator void*(HCRYPTOIDFUNCADDR value) => value.Value;

    public static explicit operator HCRYPTOIDFUNCADDR(HANDLE value) => new HCRYPTOIDFUNCADDR(value);

    public static implicit operator HANDLE(HCRYPTOIDFUNCADDR value) => new HANDLE(value.Value);

    public static explicit operator HCRYPTOIDFUNCADDR(byte value) =>
        new HCRYPTOIDFUNCADDR(unchecked((void*)(value)));

    public static explicit operator byte(HCRYPTOIDFUNCADDR value) => (byte)(value.Value);

    public static explicit operator HCRYPTOIDFUNCADDR(short value) =>
        new HCRYPTOIDFUNCADDR(unchecked((void*)(value)));

    public static explicit operator short(HCRYPTOIDFUNCADDR value) => (short)(value.Value);

    public static explicit operator HCRYPTOIDFUNCADDR(int value) =>
        new HCRYPTOIDFUNCADDR(unchecked((void*)(value)));

    public static explicit operator int(HCRYPTOIDFUNCADDR value) => (int)(value.Value);

    public static explicit operator HCRYPTOIDFUNCADDR(long value) =>
        new HCRYPTOIDFUNCADDR(unchecked((void*)(value)));

    public static explicit operator long(HCRYPTOIDFUNCADDR value) => (long)(value.Value);

    public static explicit operator HCRYPTOIDFUNCADDR(nint value) =>
        new HCRYPTOIDFUNCADDR(unchecked((void*)(value)));

    public static implicit operator nint(HCRYPTOIDFUNCADDR value) => (nint)(value.Value);

    public static explicit operator HCRYPTOIDFUNCADDR(sbyte value) =>
        new HCRYPTOIDFUNCADDR(unchecked((void*)(value)));

    public static explicit operator sbyte(HCRYPTOIDFUNCADDR value) => (sbyte)(value.Value);

    public static explicit operator HCRYPTOIDFUNCADDR(ushort value) =>
        new HCRYPTOIDFUNCADDR(unchecked((void*)(value)));

    public static explicit operator ushort(HCRYPTOIDFUNCADDR value) => (ushort)(value.Value);

    public static explicit operator HCRYPTOIDFUNCADDR(uint value) =>
        new HCRYPTOIDFUNCADDR(unchecked((void*)(value)));

    public static explicit operator uint(HCRYPTOIDFUNCADDR value) => (uint)(value.Value);

    public static explicit operator HCRYPTOIDFUNCADDR(ulong value) =>
        new HCRYPTOIDFUNCADDR(unchecked((void*)(value)));

    public static explicit operator ulong(HCRYPTOIDFUNCADDR value) => (ulong)(value.Value);

    public static explicit operator HCRYPTOIDFUNCADDR(nuint value) =>
        new HCRYPTOIDFUNCADDR(unchecked((void*)(value)));

    public static implicit operator nuint(HCRYPTOIDFUNCADDR value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCRYPTOIDFUNCADDR other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTOIDFUNCADDR.");
    }

    public int CompareTo(HCRYPTOIDFUNCADDR other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCRYPTOIDFUNCADDR other) && Equals(other);

    public bool Equals(HCRYPTOIDFUNCADDR other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
