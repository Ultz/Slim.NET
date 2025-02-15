// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8CEEB155-2849-4CE5-9448-91FF70E1E4D9")]
[NativeTypeName("struct IUIAnimationVariable : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationVariable : IUIAnimationVariable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationVariable));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationVariable, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationVariable, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetValue(double* value)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, double*, int>)((*lpVtbl)[3]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFinalValue(double* finalValue)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, double*, int>)((*lpVtbl)[4]))(
            this,
            finalValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPreviousValue(double* previousValue)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, double*, int>)((*lpVtbl)[5]))(
            this,
            previousValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIntegerValue([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, int*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFinalIntegerValue([NativeTypeName("INT32 *")] int* finalValue)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, int*, int>)((*lpVtbl)[7]))(
            this,
            finalValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPreviousIntegerValue([NativeTypeName("INT32 *")] int* previousValue)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, int*, int>)((*lpVtbl)[8]))(
            this,
            previousValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCurrentStoryboard(IUIAnimationStoryboard* storyboard)
    {
        return (
            (delegate* unmanaged<IUIAnimationVariable, IUIAnimationStoryboard*, int>)((*lpVtbl)[9])
        )(this, storyboard);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLowerBound(double bound)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, double, int>)((*lpVtbl)[10]))(
            this,
            bound
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetUpperBound(double bound)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, double, int>)((*lpVtbl)[11]))(
            this,
            bound
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetRoundingMode(UI_ANIMATION_ROUNDING_MODE mode)
    {
        return (
            (delegate* unmanaged<IUIAnimationVariable, UI_ANIMATION_ROUNDING_MODE, int>)(
                (*lpVtbl)[12]
            )
        )(this, mode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetTag(IUnknown @object, [NativeTypeName("UINT32")] uint id)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, IUnknown, uint, int>)((*lpVtbl)[13]))(
            this,
            @object,
            id
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetTag(IUnknown* @object, [NativeTypeName("UINT32 *")] uint* id)
    {
        return ((delegate* unmanaged<IUIAnimationVariable, IUnknown*, uint*, int>)((*lpVtbl)[14]))(
            this,
            @object,
            id
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetVariableChangeHandler(IUIAnimationVariableChangeHandler handler)
    {
        return (
            (delegate* unmanaged<IUIAnimationVariable, IUIAnimationVariableChangeHandler, int>)(
                (*lpVtbl)[15]
            )
        )(this, handler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetVariableIntegerChangeHandler(IUIAnimationVariableIntegerChangeHandler handler)
    {
        return (
            (delegate* unmanaged<
                IUIAnimationVariable,
                IUIAnimationVariableIntegerChangeHandler,
                int>)((*lpVtbl)[16])
        )(this, handler);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetValue(double* value);

        [VtblIndex(4)]
        HRESULT GetFinalValue(double* finalValue);

        [VtblIndex(5)]
        HRESULT GetPreviousValue(double* previousValue);

        [VtblIndex(6)]
        HRESULT GetIntegerValue([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT GetFinalIntegerValue([NativeTypeName("INT32 *")] int* finalValue);

        [VtblIndex(8)]
        HRESULT GetPreviousIntegerValue([NativeTypeName("INT32 *")] int* previousValue);

        [VtblIndex(9)]
        HRESULT GetCurrentStoryboard(IUIAnimationStoryboard* storyboard);

        [VtblIndex(10)]
        HRESULT SetLowerBound(double bound);

        [VtblIndex(11)]
        HRESULT SetUpperBound(double bound);

        [VtblIndex(12)]
        HRESULT SetRoundingMode(UI_ANIMATION_ROUNDING_MODE mode);

        [VtblIndex(13)]
        HRESULT SetTag(IUnknown @object, [NativeTypeName("UINT32")] uint id);

        [VtblIndex(14)]
        HRESULT GetTag(IUnknown* @object, [NativeTypeName("UINT32 *")] uint* id);

        [VtblIndex(15)]
        HRESULT SetVariableChangeHandler(IUIAnimationVariableChangeHandler handler);

        [VtblIndex(16)]
        HRESULT SetVariableIntegerChangeHandler(IUIAnimationVariableIntegerChangeHandler handler);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetValue;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetFinalValue;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetPreviousValue;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetIntegerValue;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetFinalIntegerValue;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetPreviousIntegerValue;

        [NativeTypeName("HRESULT (IUIAnimationStoryboard **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationStoryboard*, int> GetCurrentStoryboard;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetLowerBound;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetUpperBound;

        [NativeTypeName("HRESULT (UI_ANIMATION_ROUNDING_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_ROUNDING_MODE, int> SetRoundingMode;

        [NativeTypeName("HRESULT (IUnknown *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, uint, int> SetTag;

        [NativeTypeName("HRESULT (IUnknown **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint*, int> GetTag;

        [NativeTypeName("HRESULT (IUIAnimationVariableChangeHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationVariableChangeHandler,
            int> SetVariableChangeHandler;

        [NativeTypeName(
            "HRESULT (IUIAnimationVariableIntegerChangeHandler *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationVariableIntegerChangeHandler,
            int> SetVariableIntegerChangeHandler;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUIAnimationVariable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUIAnimationVariable(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUIAnimationVariable"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUIAnimationVariable(Silk.NET.Windows.IUnknown value)
    {
        return new IUIAnimationVariable(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUIAnimationVariable"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUIAnimationVariable"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUIAnimationVariable value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
