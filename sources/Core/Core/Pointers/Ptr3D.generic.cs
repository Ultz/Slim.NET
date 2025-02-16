using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using InlineIL;

namespace Silk.NET.Core
{
    /// <summary>
    /// A single dimensional pointer wrapper class
    /// </summary>
    public unsafe struct Ptr3D<T>
        where T : unmanaged
    {
        /// <summary>
        /// Creates an instance of <see cref="Ptr3D{T}"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr3D(Ptr2D<T>* ptr)
        {
            Native = ptr;
        }

        /// <summary>
        /// Creates an instance of <see cref="Ptr3D{T}"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr3D(void*** ptr)
            : this((Ptr2D<T>*)ptr) { }

        /// <summary>
        /// Creates an instance of <see cref="Ptr3D{T}"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        public Ptr3D(T*** ptr)
            : this((Ptr2D<T>*)ptr) { }

        /// <summary>
        /// The native pointer
        /// </summary>
        public readonly Ptr2D<T>* Native;

        /// <summary>
        /// A reference to the pointer value
        /// </summary>
        public readonly ref Ptr<T> Handle => ref Unsafe.AsRef<Ptr<T>>(Native);

        /// <summary>
        /// The value located within this pointer
        /// </summary>
        public ref T Value
        {
            get
            {
                if (Native == null || Native->Native == null)
                    return ref Unsafe.NullRef<T>();
                return ref Native->Native->Handle;
            }
        }

        /// <summary>
        /// Gets a ref to the offset pointer value
        /// </summary>
        /// <param name="index"></param>
        /// <returns>the offset pointer value</returns>
        public ref Ptr<T> this[nuint index] =>
            ref Unsafe.AsRef<Ptr<T>>(((nuint)Native + (index * (nuint)sizeof(T))).ToPointer());

        /// <summary>
        /// Gets the underlying pointer.
        /// </summary>
        /// <returns>The underlying pointer.</returns>
        /// <remarks>
        /// This function allows a <see cref="Ptr"/> to be used in a <c>fixed</c> statement.
        /// </remarks>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public ref T** GetPinnableReference()
        {
            IL.Emit.Ldarg_0();
            IL.Emit.Ldfld(
                FieldRef.Field(
                    TypeRef.Type(typeof(Ptr3D<>)).MakeGenericType(typeof(T)),
                    nameof(Native)
                )
            );
            IL.Emit.Ret();
            throw IL.Unreachable();
        }

        /// <summary>
        /// Creates a span with the given length from this pointer.
        /// </summary>
        /// <param name="length">the span length</param>
        /// <returns>the span</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Span<Ptr2D<T>> AsSpan(int length) => new(Native, length);

        /// <summary>
        /// Creates an array with the given length from this pointer
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public Ptr2D<T>[] ToArray(int length) => AsSpan(length).ToArray();

        /// <summary>
        /// Creates a 2D Jagged array from this pointer
        /// </summary>
        /// <param name="length">the number of arrays at this pointer</param>
        /// <param name="lengths">the numer of elements in each array at this pointer</param>
        /// <returns></returns>
        public Ptr<T>[][] ToArray(int length, int[] lengths) =>
            SilkMarshal.NativeToArray<Ptr<T>>(new(Native, length), lengths);

        /// <summary>
        /// Creates a 3D Jagged array from this pointer
        /// </summary>
        /// <param name="length">the number of arrays at this pointer</param>
        /// <param name="lengths0">the number of arrays in each array at this pointer</param>
        /// <param name="lengths1">the number of elements in each array</param>
        /// <returns></returns>
        public T[][][] ToArray(int length, int[] lengths0, int[][] lengths1) =>
            SilkMarshal.NativeToArray<T>(new(Native, length), lengths0, lengths1);

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D<T> lh, Ref2D<T> rh) => lh.Native == (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D<T> lh, Ref2D<T> rh) => lh.Native != (void*)rh;

        /// <summary>
        /// Determines whether a pointer and reference are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ref2D<T> lh, Ptr3D<T> rh) => (void*)lh == rh.Native;

        /// <summary>
        /// Determines whether a pointer and reference are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and reference are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ref2D<T> lh, Ptr3D<T> rh) => (void*)lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D<T> lh, void* rh) => lh.Native->Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D<T> lh, void* rh) => lh.Native->Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(void* lh, Ptr3D<T> rh) => lh == rh.Native->Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(void* lh, Ptr3D<T> rh) => lh != rh.Native->Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D<T> lh, void** rh) => lh.Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D<T> lh, void** rh) => lh.Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(void** lh, Ptr3D<T> rh) => lh == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(void** lh, Ptr3D<T> rh) => lh != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D<T> lh, T* rh) => lh.Native->Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D<T> lh, T* rh) => lh.Native->Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(T* lh, Ptr3D<T> rh) => lh == rh.Native->Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(T* lh, Ptr3D<T> rh) => lh != rh.Native->Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D<T> lh, T** rh) => lh.Native == rh;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D<T> lh, T** rh) => lh.Native != rh;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(T** lh, Ptr3D<T> rh) => lh == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(T** lh, Ptr3D<T> rh) => lh != rh.Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D<T> lh, NullPtr rh) => lh.Native == null;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D<T> lh, NullPtr rh) => lh.Native != null;

        /// <summary>
        /// Determines whether a pointer and nullptr are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(NullPtr lh, Ptr3D<T> rh) => null == rh.Native;

        /// <summary>
        /// Determines whether a pointer and nullptr are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the pointer and nullptr are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(NullPtr lh, Ptr3D<T> rh) => null != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D<T> lh, Ptr3D rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D<T> lh, Ptr3D rh) => lh.Native != rh.Native;

        /// <summary>
        /// Determines whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D lh, Ptr3D<T> rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determines whether two pointers are not equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>whether the two pointers are not equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D lh, Ptr3D<T> rh) => lh.Native != rh.Native;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static explicit operator Ptr3D<T>(void* ptr) => new((Ptr2D<T>*)ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator void*(Ptr3D<T> ptr) =>
            ptr.Native is not null && ptr.Native->Native is not null
                ? ptr.Native->Native->Native
                : null;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static explicit operator Ptr3D<T>(void** ptr) => new((Ptr2D<T>*)ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator void**(Ptr3D<T> ptr) =>
            ptr.Native is not null ? (void**)ptr.Native->Native : null;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr3D<T>(void*** ptr) => new((Ptr2D<T>*)ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator void***(Ptr3D<T> ptr) => (void***)ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a native pointer
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr3D<T>(T*** ptr) => new((Ptr2D<T>*)ptr);

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator T*(Ptr3D<T> ptr) =>
            ptr.Native is not null && ptr.Native->Native is not null
                ? ptr.Native->Native->Native
                : null;

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator T**(Ptr3D<T> ptr) =>
            ptr.Native is not null ? (T**)ptr.Native->Native : null;

        /// <summary>
        /// Creates a native pointer from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        public static implicit operator T***(Ptr3D<T> ptr) => (T***)ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ref"/> from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ref3D(Ptr3D<T> ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ref"/> from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ref3D<T>(Ptr3D<T> ptr) => ptr.Native;

        /// <summary>
        /// Expresses this <see cref="Ptr3D{T}" /> as a <see cref="Ref"/>. Note that this does not index the
        /// <see cref="Ptr3D{T}"/>'s dimensions, and is effectively equivalent to converting a <c>void***</c> to a
        /// <c>void*</c>.
        /// </summary>
        /// <param name="ptr">The <see cref="Ptr3D{T}"/>.</param>
        /// <returns>The <see cref="Ref"/>.</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ref(Ptr3D<T> ptr) => ptr.Native;

        /// <summary>
        /// Expresses this <see cref="Ptr3D{T}" /> as a <see cref="Ptr"/>. Note that this does not index the
        /// <see cref="Ptr3D{T}"/>'s dimensions, and is effectively equivalent to converting a <c>void***</c> to a
        /// <c>void*</c>.
        /// </summary>
        /// <param name="ptr">The <see cref="Ptr3D{T}"/>.</param>
        /// <returns>The <see cref="Ptr"/>.</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr(Ptr3D<T> ptr) => ptr.Native;

        /// <summary>
        /// Creates a <see cref="Ref"/> from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        // TODO analyzer to ensure ptr is on stack or otherwise pinned
        public static explicit operator Ptr3D<T>(Ref3D ptr) => (void***)ptr;

        /// <summary>
        /// Creates a <see cref="Ref"/> from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        // TODO analyzer to ensure ptr is on stack or otherwise pinned
        public static explicit operator Ptr3D<T>(Ref3D<T> ptr) => (T***)ptr;

        /// <summary>
        /// Creates a <see cref="Ptr"/> from a <see cref="Ptr3D{T}"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr3D(Ptr3D<T> ptr) => new((Ptr2D*)ptr.Native);

        /// <summary>
        /// Creates a <see cref="Ptr3D{T}"/> from a <see cref="Ptr"/>
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr3D<T>(Ptr3D ptr) => new((Ptr2D<T>*)ptr.Native);

        /// <summary>
        /// Creates a null ptr
        /// </summary>
        /// <param name="ptr"></param>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static implicit operator Ptr3D<T>(NullPtr ptr) => new((Ptr2D<T>*)null);

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator ==(Ptr3D<T> lh, Ptr3D<T> rh) => lh.Native == rh.Native;

        /// <summary>
        /// Determine whether two pointers are equal
        /// </summary>
        /// <param name="lh"></param>
        /// <param name="rh"></param>
        /// <returns>Whether the two pointers are equal</returns>
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static bool operator !=(Ptr3D<T> lh, Ptr3D<T> rh) => lh.Native != rh.Native;

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
        /// Creates a <see cref="Ptr3D{T}"/> from a <see cref="Ptr2D{T}"/> pointer.
        /// </summary>
        /// <param name="ptr">The pointer.</param>
        /// <returns>The wrapped pointer.</returns>
        public static implicit operator Ptr3D<T>(Ptr2D<T>* ptr) => (T***)ptr;
    }
}
