using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using InlineIL;

namespace Silk.NET.Core
{
    /// <summary>
    /// A two-dimensional pointer wrapper class
    /// </summary>
    public unsafe struct Ptr3D
    {
        /// <summary>
        /// Creates an instance of <see cref="Ptr3D"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr3D(Ptr2D* ptr)
        {
            Native = ptr;
        }

        /// <summary>
        /// Creates an instance of <see cref="Ptr3D"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr3D(void*** ptr)
            : this((Ptr2D*)ptr) { }

        /// <summary>
        /// The native pointer
        /// </summary>
        public readonly Ptr2D* Native;

        /// <summary>
        /// The value stored at the pointer
        /// </summary>
        public ref byte Value
        {
            get
            {
                if (Native == null || Native->Native == null)
                    return ref Unsafe.NullRef<byte>();
                return ref Native->Native->Handle;
            }
        }

        /// <summary>
        /// A reference to the pointer value
        /// </summary>
        public ref byte Handle => ref Unsafe.AsRef<byte>(Native);

        /// <summary>
        /// Gets a ref to the offset pointer value
        /// </summary>
        /// <param name="index"></param>
        /// <returns>the offset pointer value</returns>
        public ref Ptr this[nuint index] =>
            ref Unsafe.AsRef<Ptr>(((nuint)Native + (index * (nuint)sizeof(Ptr))).ToPointer());

        /// <summary>
        /// Gets the underlying pointer.
        /// </summary>
        /// <returns>The underlying pointer.</returns>
        /// <remarks>
        /// This function allows a <see cref="Ptr3D"/> to be used in a <c>fixed</c> statement.
        /// </remarks>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ref void** GetPinnableReference()
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(FieldRef.Field(TypeRef.Type(typeof(Ptr3D)), nameof(Native)));
            IL.Emit.Ret();
            throw IL.Unreachable();
        }

        /// <summary>
        /// Creates a span with the given length from this pointer.
        /// </summary>
        /// <param name="length">the span length</param>
        /// <typeparam name="T"></typeparam>
        /// <returns>the span</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Span<T> AsSpan<T>(int length)
            where T : unmanaged => new(Native, length);

        /// <summary>
        /// Creates an array with the given length from this pointer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="length"></param>
        /// <returns></returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public T[] ToArray<T>(int length)
            where T : unmanaged => AsSpan<T>(length).ToArray();

        /// <summary>
        /// Creates a 2D Jagged array from this pointer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="length">the number of arrays at this pointer</param>
        /// <param name="lengths">the number of elements in each array at this pointer</param>
        /// <returns></returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public T[][] ToArray<T>(int length, int[] lengths)
            where T : unmanaged => SilkMarshal.NativeToArray<T>(AsSpan<nint>(length), lengths);

        /// <summary>
        /// Creates a 3D Jagged array from this pointer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="length">the number of arrays at this pointer</param>
        /// <param name="lengths0">the number of arrays in each array at this pointer</param>
        /// <param name="lengths1">the number of elements in each array</param>
        /// <returns></returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public T[][][] ToArray<T>(int length, int[] lengths0, int[][] lengths1)
            where T : unmanaged =>
            SilkMarshal.NativeToArray<T>(AsSpan<nint>(length), lengths0, lengths1);

        /// <summary>
        /// Creates a string 2D jagged array assuming that each string is null-terminated
        /// </summary>
        /// <param name="length">the number of arrays at this pointer</param>
        /// <param name="lengths">the number of strings in each array</param>
        /// <returns></returns>
        public string?[]?[]? ReadToStringArray(int length, int[] lengths) =>
            SilkMarshal.NativeToStringArray(AsSpan<nint>(length), lengths);

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D lh, Ref2D rh) => lh.Native == (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D lh, Ref2D rh) => lh.Native != (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ref2D lh, Ptr3D rh) => (void*)lh == rh.Native;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ref2D lh, Ptr3D rh) => (void*)lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D lh, void* rh) => lh.Native->Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D lh, void* rh) => lh.Native->Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(void* lh, Ptr3D rh) => lh == rh.Native->Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(void** lh, Ptr3D rh) => lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D lh, void** rh) => lh.Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D lh, void** rh) => lh.Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(void** lh, Ptr3D rh) => lh == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(void* lh, Ptr3D rh) => lh != rh.Native->Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D lh, NullPtr rh) => lh.Native == null;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D lh, NullPtr rh) => lh.Native != null;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(NullPtr lh, Ptr3D rh) => null == rh.Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(NullPtr lh, Ptr3D rh) => null != rh.Native;

        /// <summary>
        /// Creates a <see cref="Ptr3D"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static explicit operator Ptr3D(void* ptr) => new((void***)ptr);

        /// <summary>
        /// Creates a <see cref="Ptr3D"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static explicit operator Ptr3D(void** ptr) => new((void***)ptr);

        /// <summary>
        /// Creates a <see cref="Ptr3D"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr3D(void*** ptr) => new(ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr3D"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator void*(Ptr3D ptr) =>
            ptr.Native is not null && ptr.Native->Native is not null
                ? ptr.Native->Native->Native
                : null;

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr3D"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator void**(Ptr3D ptr) =>
            ptr.Native is not null ? (void**)ptr.Native->Native : null;

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr3D"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator void***(Ptr3D ptr) => (void***)ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ref3D"/> from a <see cref="Ptr3D"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ref3D(Ptr3D ptr) => ptr.Native;

        /// <summary>
        /// Expresses this <see cref="Ptr3D" /> as a <see cref="Ref"/>. Note that this does not index the
        /// <see cref="Ptr3D"/>'s dimensions, and is effectively equivalent to converting a <c>void***</c> to a
        /// <c>void*</c>.
        /// </summary>
        /// <param name="ptr">The <see cref="Ptr3D"/>.</param>
        /// <returns>The <see cref="Ref"/>.</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ref(Ptr3D ptr) => ptr.Native;

        /// <summary>
        /// Expresses this <see cref="Ptr3D" /> as a <see cref="Ptr"/>. Note that this does not index the
        /// <see cref="Ptr3D"/>'s dimensions, and is effectively equivalent to converting a <c>void***</c> to a
        /// <c>void*</c>.
        /// </summary>
        /// <param name="ptr">The <see cref="Ptr3D"/>.</param>
        /// <returns>The <see cref="Ptr"/>.</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr(Ptr3D ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ptr3D"/> from a <see cref="Ref2D"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static explicit operator Ptr3D(Ref2D ptr) => (Ptr3D)(void**)ptr;

        /// <summary>
        /// Creates a null ptr
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr3D(NullPtr ptr) => new((Ptr2D*)null);

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D lh, Ptr3D rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D lh, Ptr3D rh) => lh.Native != rh.Native;

        /// <inheritdoc/>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public override bool Equals([NotNullWhen(true)] object? obj) => base.Equals(obj);

        /// <inheritdoc/>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public override int GetHashCode() => base.GetHashCode();

        /// <summary>
        /// Creates a <see cref="Ptr3D"/> from a <see cref="Ptr2D"/> pointer.
        /// </summary>
        /// <param name="ptr">The pointer.</param>
        /// <returns>The wrapped pointer.</returns>
        public static implicit operator Ptr3D(Ptr2D* ptr) => (Ptr3D)(byte***)ptr;
    }
}
