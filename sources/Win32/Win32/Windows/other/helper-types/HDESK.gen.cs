// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HDESK
    : IComparable,
        IComparable<HDESK>,
        IEquatable<HDESK>,
        IFormattable
{
    public readonly void* Value;

    public HDESK(void* value)
    {
        Value = value;
    }

    public static HDESK INVALID_VALUE => new HDESK((void*)(-1));
    public static HDESK NULL => new HDESK(null);

    public static bool operator ==(HDESK left, HDESK right) => left.Value == right.Value;

    public static bool operator !=(HDESK left, HDESK right) => left.Value != right.Value;

    public static bool operator <(HDESK left, HDESK right) => left.Value < right.Value;

    public static bool operator <=(HDESK left, HDESK right) => left.Value <= right.Value;

    public static bool operator >(HDESK left, HDESK right) => left.Value > right.Value;

    public static bool operator >=(HDESK left, HDESK right) => left.Value >= right.Value;

    public static explicit operator HDESK(void* value) => new HDESK(value);

    public static implicit operator void*(HDESK value) => value.Value;

    public static explicit operator HDESK(HANDLE value) => new HDESK(value);

    public static implicit operator HANDLE(HDESK value) => new HANDLE(value.Value);

    public static explicit operator HDESK(byte value) => new HDESK(unchecked((void*)(value)));

    public static explicit operator byte(HDESK value) => (byte)(value.Value);

    public static explicit operator HDESK(short value) => new HDESK(unchecked((void*)(value)));

    public static explicit operator short(HDESK value) => (short)(value.Value);

    public static explicit operator HDESK(int value) => new HDESK(unchecked((void*)(value)));

    public static explicit operator int(HDESK value) => (int)(value.Value);

    public static explicit operator HDESK(long value) => new HDESK(unchecked((void*)(value)));

    public static explicit operator long(HDESK value) => (long)(value.Value);

    public static explicit operator HDESK(nint value) => new HDESK(unchecked((void*)(value)));

    public static implicit operator nint(HDESK value) => (nint)(value.Value);

    public static explicit operator HDESK(sbyte value) => new HDESK(unchecked((void*)(value)));

    public static explicit operator sbyte(HDESK value) => (sbyte)(value.Value);

    public static explicit operator HDESK(ushort value) => new HDESK(unchecked((void*)(value)));

    public static explicit operator ushort(HDESK value) => (ushort)(value.Value);

    public static explicit operator HDESK(uint value) => new HDESK(unchecked((void*)(value)));

    public static explicit operator uint(HDESK value) => (uint)(value.Value);

    public static explicit operator HDESK(ulong value) => new HDESK(unchecked((void*)(value)));

    public static explicit operator ulong(HDESK value) => (ulong)(value.Value);

    public static explicit operator HDESK(nuint value) => new HDESK(unchecked((void*)(value)));

    public static implicit operator nuint(HDESK value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HDESK other)
        {
            return CompareTo(other);
        }
        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDESK.");
    }

    public int CompareTo(HDESK other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is HDESK other) && Equals(other);

    public bool Equals(HDESK other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
