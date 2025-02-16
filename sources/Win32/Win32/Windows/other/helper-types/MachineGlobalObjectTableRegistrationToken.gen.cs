// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public readonly unsafe partial struct MachineGlobalObjectTableRegistrationToken
    : IComparable,
        IComparable<MachineGlobalObjectTableRegistrationToken>,
        IEquatable<MachineGlobalObjectTableRegistrationToken>,
        IFormattable
{
    public readonly void* Value;

    public MachineGlobalObjectTableRegistrationToken(void* value)
    {
        Value = value;
    }

    public static MachineGlobalObjectTableRegistrationToken NULL =>
        new MachineGlobalObjectTableRegistrationToken(null);

    public static bool operator ==(
        MachineGlobalObjectTableRegistrationToken left,
        MachineGlobalObjectTableRegistrationToken right
    ) => left.Value == right.Value;

    public static bool operator !=(
        MachineGlobalObjectTableRegistrationToken left,
        MachineGlobalObjectTableRegistrationToken right
    ) => left.Value != right.Value;

    public static bool operator <(
        MachineGlobalObjectTableRegistrationToken left,
        MachineGlobalObjectTableRegistrationToken right
    ) => left.Value < right.Value;

    public static bool operator <=(
        MachineGlobalObjectTableRegistrationToken left,
        MachineGlobalObjectTableRegistrationToken right
    ) => left.Value <= right.Value;

    public static bool operator >(
        MachineGlobalObjectTableRegistrationToken left,
        MachineGlobalObjectTableRegistrationToken right
    ) => left.Value > right.Value;

    public static bool operator >=(
        MachineGlobalObjectTableRegistrationToken left,
        MachineGlobalObjectTableRegistrationToken right
    ) => left.Value >= right.Value;

    public static explicit operator MachineGlobalObjectTableRegistrationToken(void* value) =>
        new MachineGlobalObjectTableRegistrationToken(value);

    public static implicit operator void*(MachineGlobalObjectTableRegistrationToken value) =>
        value.Value;

    public static explicit operator MachineGlobalObjectTableRegistrationToken(byte value) =>
        new MachineGlobalObjectTableRegistrationToken(unchecked((void*)(value)));

    public static explicit operator byte(MachineGlobalObjectTableRegistrationToken value) =>
        (byte)(value.Value);

    public static explicit operator MachineGlobalObjectTableRegistrationToken(short value) =>
        new MachineGlobalObjectTableRegistrationToken(unchecked((void*)(value)));

    public static explicit operator short(MachineGlobalObjectTableRegistrationToken value) =>
        (short)(value.Value);

    public static explicit operator MachineGlobalObjectTableRegistrationToken(int value) =>
        new MachineGlobalObjectTableRegistrationToken(unchecked((void*)(value)));

    public static explicit operator int(MachineGlobalObjectTableRegistrationToken value) =>
        (int)(value.Value);

    public static explicit operator MachineGlobalObjectTableRegistrationToken(long value) =>
        new MachineGlobalObjectTableRegistrationToken(unchecked((void*)(value)));

    public static explicit operator long(MachineGlobalObjectTableRegistrationToken value) =>
        (long)(value.Value);

    public static explicit operator MachineGlobalObjectTableRegistrationToken(nint value) =>
        new MachineGlobalObjectTableRegistrationToken(unchecked((void*)(value)));

    public static implicit operator nint(MachineGlobalObjectTableRegistrationToken value) =>
        (nint)(value.Value);

    public static explicit operator MachineGlobalObjectTableRegistrationToken(sbyte value) =>
        new MachineGlobalObjectTableRegistrationToken(unchecked((void*)(value)));

    public static explicit operator sbyte(MachineGlobalObjectTableRegistrationToken value) =>
        (sbyte)(value.Value);

    public static explicit operator MachineGlobalObjectTableRegistrationToken(ushort value) =>
        new MachineGlobalObjectTableRegistrationToken(unchecked((void*)(value)));

    public static explicit operator ushort(MachineGlobalObjectTableRegistrationToken value) =>
        (ushort)(value.Value);

    public static explicit operator MachineGlobalObjectTableRegistrationToken(uint value) =>
        new MachineGlobalObjectTableRegistrationToken(unchecked((void*)(value)));

    public static explicit operator uint(MachineGlobalObjectTableRegistrationToken value) =>
        (uint)(value.Value);

    public static explicit operator MachineGlobalObjectTableRegistrationToken(ulong value) =>
        new MachineGlobalObjectTableRegistrationToken(unchecked((void*)(value)));

    public static explicit operator ulong(MachineGlobalObjectTableRegistrationToken value) =>
        (ulong)(value.Value);

    public static explicit operator MachineGlobalObjectTableRegistrationToken(nuint value) =>
        new MachineGlobalObjectTableRegistrationToken(unchecked((void*)(value)));

    public static implicit operator nuint(MachineGlobalObjectTableRegistrationToken value) =>
        (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is MachineGlobalObjectTableRegistrationToken other)
        {
            return CompareTo(other);
        }
        return (obj is null)
            ? 1
            : throw new ArgumentException(
                "obj is not an instance of MachineGlobalObjectTableRegistrationToken."
            );
    }

    public int CompareTo(MachineGlobalObjectTableRegistrationToken other) =>
        ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) =>
        (obj is MachineGlobalObjectTableRegistrationToken other) && Equals(other);

    public bool Equals(MachineGlobalObjectTableRegistrationToken other) =>
        ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() =>
        ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) =>
        ((nuint)(Value)).ToString(format, formatProvider);
}
