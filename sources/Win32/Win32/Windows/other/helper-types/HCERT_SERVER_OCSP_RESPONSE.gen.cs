// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct HCERT_SERVER_OCSP_RESPONSE
    : IComparable,
        IComparable<HCERT_SERVER_OCSP_RESPONSE>,
        IEquatable<HCERT_SERVER_OCSP_RESPONSE>,
        IFormattable
{
    public readonly void* Value;

    public HCERT_SERVER_OCSP_RESPONSE(void* value)
    {
        Value = value;
    }

    public static HCERT_SERVER_OCSP_RESPONSE INVALID_VALUE =>
        new HCERT_SERVER_OCSP_RESPONSE((void*)(-1));
    public static HCERT_SERVER_OCSP_RESPONSE NULL => new HCERT_SERVER_OCSP_RESPONSE(null);

    public static bool operator ==(
        HCERT_SERVER_OCSP_RESPONSE left,
        HCERT_SERVER_OCSP_RESPONSE right
    ) => left.Value == right.Value;

    public static bool operator !=(
        HCERT_SERVER_OCSP_RESPONSE left,
        HCERT_SERVER_OCSP_RESPONSE right
    ) => left.Value != right.Value;

    public static bool operator <(
        HCERT_SERVER_OCSP_RESPONSE left,
        HCERT_SERVER_OCSP_RESPONSE right
    ) => left.Value < right.Value;

    public static bool operator <=(
        HCERT_SERVER_OCSP_RESPONSE left,
        HCERT_SERVER_OCSP_RESPONSE right
    ) => left.Value <= right.Value;

    public static bool operator >(
        HCERT_SERVER_OCSP_RESPONSE left,
        HCERT_SERVER_OCSP_RESPONSE right
    ) => left.Value > right.Value;

    public static bool operator >=(
        HCERT_SERVER_OCSP_RESPONSE left,
        HCERT_SERVER_OCSP_RESPONSE right
    ) => left.Value >= right.Value;

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(void* value) =>
        new HCERT_SERVER_OCSP_RESPONSE(value);

    public static implicit operator void*(HCERT_SERVER_OCSP_RESPONSE value) => value.Value;

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(HANDLE value) =>
        new HCERT_SERVER_OCSP_RESPONSE(value);

    public static implicit operator HANDLE(HCERT_SERVER_OCSP_RESPONSE value) =>
        new HANDLE(value.Value);

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(byte value) =>
        new HCERT_SERVER_OCSP_RESPONSE(unchecked((void*)(value)));

    public static explicit operator byte(HCERT_SERVER_OCSP_RESPONSE value) => (byte)(value.Value);

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(short value) =>
        new HCERT_SERVER_OCSP_RESPONSE(unchecked((void*)(value)));

    public static explicit operator short(HCERT_SERVER_OCSP_RESPONSE value) => (short)(value.Value);

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(int value) =>
        new HCERT_SERVER_OCSP_RESPONSE(unchecked((void*)(value)));

    public static explicit operator int(HCERT_SERVER_OCSP_RESPONSE value) => (int)(value.Value);

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(long value) =>
        new HCERT_SERVER_OCSP_RESPONSE(unchecked((void*)(value)));

    public static explicit operator long(HCERT_SERVER_OCSP_RESPONSE value) => (long)(value.Value);

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(nint value) =>
        new HCERT_SERVER_OCSP_RESPONSE(unchecked((void*)(value)));

    public static implicit operator nint(HCERT_SERVER_OCSP_RESPONSE value) => (nint)(value.Value);

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(sbyte value) =>
        new HCERT_SERVER_OCSP_RESPONSE(unchecked((void*)(value)));

    public static explicit operator sbyte(HCERT_SERVER_OCSP_RESPONSE value) => (sbyte)(value.Value);

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(ushort value) =>
        new HCERT_SERVER_OCSP_RESPONSE(unchecked((void*)(value)));

    public static explicit operator ushort(HCERT_SERVER_OCSP_RESPONSE value) =>
        (ushort)(value.Value);

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(uint value) =>
        new HCERT_SERVER_OCSP_RESPONSE(unchecked((void*)(value)));

    public static explicit operator uint(HCERT_SERVER_OCSP_RESPONSE value) => (uint)(value.Value);

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(ulong value) =>
        new HCERT_SERVER_OCSP_RESPONSE(unchecked((void*)(value)));

    public static explicit operator ulong(HCERT_SERVER_OCSP_RESPONSE value) => (ulong)(value.Value);

    public static explicit operator HCERT_SERVER_OCSP_RESPONSE(nuint value) =>
        new HCERT_SERVER_OCSP_RESPONSE(unchecked((void*)(value)));

    public static implicit operator nuint(HCERT_SERVER_OCSP_RESPONSE value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is HCERT_SERVER_OCSP_RESPONSE other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException("obj is not an instance of HCERT_SERVER_OCSP_RESPONSE.");
    }

    public int CompareTo(HCERT_SERVER_OCSP_RESPONSE other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is HCERT_SERVER_OCSP_RESPONSE other) && Equals(other);

    public bool Equals(HCERT_SERVER_OCSP_RESPONSE other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
