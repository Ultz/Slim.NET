// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCMTRANSFORM
    : IComparable,
        IComparable<HCMTRANSFORM>,
        IEquatable<HCMTRANSFORM>,
        IFormattable
{
    public readonly void* Value;

    public HCMTRANSFORM(void* value)
    {
        Value = value;
    }

    public static HCMTRANSFORM INVALID_VALUE => new HCMTRANSFORM((void*)(-1));
    public static HCMTRANSFORM NULL => new HCMTRANSFORM(null);

    public static bool operator ==(HCMTRANSFORM left, HCMTRANSFORM right) =>
        left.Value == right.Value;

    public static bool operator !=(HCMTRANSFORM left, HCMTRANSFORM right) =>
        left.Value != right.Value;

    public static bool operator <(HCMTRANSFORM left, HCMTRANSFORM right) =>
        left.Value < right.Value;

    public static bool operator <=(HCMTRANSFORM left, HCMTRANSFORM right) =>
        left.Value <= right.Value;

    public static bool operator >(HCMTRANSFORM left, HCMTRANSFORM right) =>
        left.Value > right.Value;

    public static bool operator >=(HCMTRANSFORM left, HCMTRANSFORM right) =>
        left.Value >= right.Value;

    public static explicit operator HCMTRANSFORM(void* value) => new HCMTRANSFORM(value);

    public static implicit operator void*(HCMTRANSFORM value) => value.Value;

    public static explicit operator HCMTRANSFORM(HANDLE value) => new HCMTRANSFORM(value);

    public static implicit operator HANDLE(HCMTRANSFORM value) => new HANDLE(value.Value);

    public static explicit operator HCMTRANSFORM(byte value) =>
        new HCMTRANSFORM(unchecked((void*)(value)));

    public static explicit operator byte(HCMTRANSFORM value) => (byte)(value.Value);

    public static explicit operator HCMTRANSFORM(short value) =>
        new HCMTRANSFORM(unchecked((void*)(value)));

    public static explicit operator short(HCMTRANSFORM value) => (short)(value.Value);

    public static explicit operator HCMTRANSFORM(int value) =>
        new HCMTRANSFORM(unchecked((void*)(value)));

    public static explicit operator int(HCMTRANSFORM value) => (int)(value.Value);

    public static explicit operator HCMTRANSFORM(long value) =>
        new HCMTRANSFORM(unchecked((void*)(value)));

    public static explicit operator long(HCMTRANSFORM value) => (long)(value.Value);

    public static explicit operator HCMTRANSFORM(nint value) =>
        new HCMTRANSFORM(unchecked((void*)(value)));

    public static implicit operator nint(HCMTRANSFORM value) => (nint)(value.Value);

    public static explicit operator HCMTRANSFORM(sbyte value) =>
        new HCMTRANSFORM(unchecked((void*)(value)));

    public static explicit operator sbyte(HCMTRANSFORM value) => (sbyte)(value.Value);

    public static explicit operator HCMTRANSFORM(ushort value) =>
        new HCMTRANSFORM(unchecked((void*)(value)));

    public static explicit operator ushort(HCMTRANSFORM value) => (ushort)(value.Value);

    public static explicit operator HCMTRANSFORM(uint value) =>
        new HCMTRANSFORM(unchecked((void*)(value)));

    public static explicit operator uint(HCMTRANSFORM value) => (uint)(value.Value);

    public static explicit operator HCMTRANSFORM(ulong value) =>
        new HCMTRANSFORM(unchecked((void*)(value)));

    public static explicit operator ulong(HCMTRANSFORM value) => (ulong)(value.Value);

    public static explicit operator HCMTRANSFORM(nuint value) =>
        new HCMTRANSFORM(unchecked((void*)(value)));

    public static implicit operator nuint(HCMTRANSFORM value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCMTRANSFORM other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCMTRANSFORM.");
    }

    public int CompareTo(HCMTRANSFORM other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HCMTRANSFORM other) && Equals(other);

    public bool Equals(HCMTRANSFORM other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
