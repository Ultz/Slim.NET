// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCRYPTDEFAULTCONTEXT
    : IComparable,
        IComparable<HCRYPTDEFAULTCONTEXT>,
        IEquatable<HCRYPTDEFAULTCONTEXT>,
        IFormattable
{
    public readonly void* Value;

    public HCRYPTDEFAULTCONTEXT(void* value)
    {
        Value = value;
    }

    public static HCRYPTDEFAULTCONTEXT INVALID_VALUE => new HCRYPTDEFAULTCONTEXT((void*)(-1));
    public static HCRYPTDEFAULTCONTEXT NULL => new HCRYPTDEFAULTCONTEXT(null);

    public static bool operator ==(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) =>
        left.Value == right.Value;

    public static bool operator !=(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) =>
        left.Value != right.Value;

    public static bool operator <(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) =>
        left.Value < right.Value;

    public static bool operator <=(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) =>
        left.Value <= right.Value;

    public static bool operator >(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) =>
        left.Value > right.Value;

    public static bool operator >=(HCRYPTDEFAULTCONTEXT left, HCRYPTDEFAULTCONTEXT right) =>
        left.Value >= right.Value;

    public static explicit operator HCRYPTDEFAULTCONTEXT(void* value) =>
        new HCRYPTDEFAULTCONTEXT(value);

    public static implicit operator void*(HCRYPTDEFAULTCONTEXT value) => value.Value;

    public static explicit operator HCRYPTDEFAULTCONTEXT(HANDLE value) =>
        new HCRYPTDEFAULTCONTEXT(value);

    public static implicit operator HANDLE(HCRYPTDEFAULTCONTEXT value) => new HANDLE(value.Value);

    public static explicit operator HCRYPTDEFAULTCONTEXT(byte value) =>
        new HCRYPTDEFAULTCONTEXT(unchecked((void*)(value)));

    public static explicit operator byte(HCRYPTDEFAULTCONTEXT value) => (byte)(value.Value);

    public static explicit operator HCRYPTDEFAULTCONTEXT(short value) =>
        new HCRYPTDEFAULTCONTEXT(unchecked((void*)(value)));

    public static explicit operator short(HCRYPTDEFAULTCONTEXT value) => (short)(value.Value);

    public static explicit operator HCRYPTDEFAULTCONTEXT(int value) =>
        new HCRYPTDEFAULTCONTEXT(unchecked((void*)(value)));

    public static explicit operator int(HCRYPTDEFAULTCONTEXT value) => (int)(value.Value);

    public static explicit operator HCRYPTDEFAULTCONTEXT(long value) =>
        new HCRYPTDEFAULTCONTEXT(unchecked((void*)(value)));

    public static explicit operator long(HCRYPTDEFAULTCONTEXT value) => (long)(value.Value);

    public static explicit operator HCRYPTDEFAULTCONTEXT(nint value) =>
        new HCRYPTDEFAULTCONTEXT(unchecked((void*)(value)));

    public static implicit operator nint(HCRYPTDEFAULTCONTEXT value) => (nint)(value.Value);

    public static explicit operator HCRYPTDEFAULTCONTEXT(sbyte value) =>
        new HCRYPTDEFAULTCONTEXT(unchecked((void*)(value)));

    public static explicit operator sbyte(HCRYPTDEFAULTCONTEXT value) => (sbyte)(value.Value);

    public static explicit operator HCRYPTDEFAULTCONTEXT(ushort value) =>
        new HCRYPTDEFAULTCONTEXT(unchecked((void*)(value)));

    public static explicit operator ushort(HCRYPTDEFAULTCONTEXT value) => (ushort)(value.Value);

    public static explicit operator HCRYPTDEFAULTCONTEXT(uint value) =>
        new HCRYPTDEFAULTCONTEXT(unchecked((void*)(value)));

    public static explicit operator uint(HCRYPTDEFAULTCONTEXT value) => (uint)(value.Value);

    public static explicit operator HCRYPTDEFAULTCONTEXT(ulong value) =>
        new HCRYPTDEFAULTCONTEXT(unchecked((void*)(value)));

    public static explicit operator ulong(HCRYPTDEFAULTCONTEXT value) => (ulong)(value.Value);

    public static explicit operator HCRYPTDEFAULTCONTEXT(nuint value) =>
        new HCRYPTDEFAULTCONTEXT(unchecked((void*)(value)));

    public static implicit operator nuint(HCRYPTDEFAULTCONTEXT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCRYPTDEFAULTCONTEXT other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCRYPTDEFAULTCONTEXT.");
    }

    public int CompareTo(HCRYPTDEFAULTCONTEXT other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is HCRYPTDEFAULTCONTEXT other) && Equals(other);

    public bool Equals(HCRYPTDEFAULTCONTEXT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
