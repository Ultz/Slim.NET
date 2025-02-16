using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using InlineIL;

namespace Silk.NET.Core
{
    /// <summary>
    /// A two-dimensional pointer wrapper class
    /// </summary>
    public unsafe struct Ptr2D
    {
        /// <summary>
        /// Creates an instance of <see cref="Ptr2D"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr2D(Ptr* ptr)
        {
            Native = ptr;
        }

        /// <summary>
        /// Creates an instance of <see cref="Ptr2D"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr2D(void** ptr)
            : this((Ptr*)ptr) { }

        /// <summary>
        /// The native pointer
        /// </summary>
        public readonly Ptr* Native;

        /// <summary>
        /// The value stored at the pointer
        /// </summary>
        public ref byte Value
        {
            get
            {
                if (Native == null)
                    return ref Unsafe.NullRef<byte>();
                return ref Native->Handle;
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
        /// This function allows a <see cref="Ptr2D"/> to be used in a <c>fixed</c> statement.
        /// </remarks>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ref void* GetPinnableReference()
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(FieldRef.Field(TypeRef.Type(typeof(Ptr2D)), nameof(Native)));
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
        /// Creates a string array assuming that each string is null-terminated
        /// </summary>
        /// <param name="length">the number of strings at this pointer</param>
        /// <returns></returns>
        public string?[]? ReadToStringArray(int length) =>
            SilkMarshal.NativeToStringArray(AsSpan<nint>(length));

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
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr2D lh, Ref2D rh) => lh.Native == (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr2D lh, Ref2D rh) => lh.Native != (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ref2D lh, Ptr2D rh) => (void*)lh == rh.Native;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ref2D lh, Ptr2D rh) => (void*)lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr2D lh, void* rh) =>
            lh.Native is not null && lh.Native->Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr2D lh, void* rh) =>
            lh.Native is not null && lh.Native->Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(void* lh, Ptr2D rh) =>
            rh.Native is not null && lh == rh.Native->Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(void** lh, Ptr2D rh) =>
            rh.Native is not null && lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr2D lh, void** rh) => lh.Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr2D lh, void** rh) => lh.Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(void** lh, Ptr2D rh) => lh == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(void* lh, Ptr2D rh) =>
            rh.Native is not null && lh != rh.Native->Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr2D lh, NullPtr rh) => lh.Native == null;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr2D lh, NullPtr rh) => lh.Native != null;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(NullPtr lh, Ptr2D rh) => null == rh.Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(NullPtr lh, Ptr2D rh) => null != rh.Native;

        /// <summary>
        /// Creates a <see cref="Ptr2D"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static explicit operator Ptr2D(void* ptr) => new((void**)ptr);

        /// <summary>
        /// Creates a <see cref="Ptr2D"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr2D(void** ptr) => new(ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr2D"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator void*(Ptr2D ptr) =>
            ptr.Native is not null ? ptr.Native->Native : null;

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr2D"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator void**(Ptr2D ptr) => (void**)ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ref2D"/> from a <see cref="Ptr2D"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ref2D(Ptr2D ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ptr2D"/> from a <see cref="Ref2D"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        // TODO analyzer to ensure ptr is on stack or otherwise pinned
        public static explicit operator Ptr2D(Ref2D ptr) => (void**)ptr;

        /// <summary>
        /// Expresses this <see cref="Ptr2D" /> as a <see cref="Ref"/>. Note that this does not index the
        /// <see cref="Ptr2D"/>'s dimensions, and is effectively equivalent to converting a <c>void**</c> to a
        /// <c>void*</c>.
        /// </summary>
        /// <param name="ptr">The <see cref="Ptr2D"/>.</param>
        /// <returns>The <see cref="Ref"/>.</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ref(Ptr2D ptr) => ptr.Native;

        /// <summary>
        /// Expresses this <see cref="Ptr2D" /> as a <see cref="Ptr"/>. Note that this does not index the
        /// <see cref="Ptr2D"/>'s dimensions, and is effectively equivalent to converting a <c>void**</c> to a
        /// <c>void*</c>.
        /// </summary>
        /// <param name="ptr">The <see cref="Ptr2D"/>.</param>
        /// <returns>The <see cref="Ptr"/>.</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr(Ptr2D ptr) => ptr.Native;

        /// <summary>
        /// Creates a null ptr
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr2D(NullPtr ptr) => new((Ptr*)null);

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr2D lh, Ptr2D rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr2D lh, Ptr2D rh) => lh.Native != rh.Native;

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
        /// Creates a <see cref="Ptr2D"/> from a <see cref="Ptr"/> pointer.
        /// </summary>
        /// <param name="ptr">The pointer.</param>
        /// <returns>The wrapped pointer.</returns>
        public static implicit operator Ptr2D(Ptr* ptr) => (Ptr2D)(byte**)ptr;
    }
}
