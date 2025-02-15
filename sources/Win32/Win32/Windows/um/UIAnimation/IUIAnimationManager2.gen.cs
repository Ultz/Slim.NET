// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D8B6F7D4-4109-4D3F-ACEE-879926968CB1")]
[NativeTypeName("struct IUIAnimationManager2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationManager2 : IUIAnimationManager2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationManager2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationManager2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUIAnimationManager2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationManager2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateAnimationVectorVariable(
        [NativeTypeName("const DOUBLE *")] double* initialValue,
        uint cDimension,
        IUIAnimationVariable2* variable
    )
    {
        return (
            (delegate* unmanaged<IUIAnimationManager2, double*, uint, IUIAnimationVariable2*, int>)(
                (*lpVtbl)[3]
            )
        )(this, initialValue, cDimension, variable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateAnimationVariable(double initialValue, IUIAnimationVariable2* variable)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager2, double, IUIAnimationVariable2*, int>)(
                (*lpVtbl)[4]
            )
        )(this, initialValue, variable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ScheduleTransition(
        IUIAnimationVariable2 variable,
        IUIAnimationTransition2 transition,
        [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationManager2,
                IUIAnimationVariable2,
                IUIAnimationTransition2,
                double,
                int>)((*lpVtbl)[5])
        )(this, variable, transition, timeNow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateStoryboard(IUIAnimationStoryboard2* storyboard)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager2, IUIAnimationStoryboard2*, int>)((*lpVtbl)[6])
        )(this, storyboard);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FinishAllStoryboards(
        [NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline
    )
    {
        return ((delegate* unmanaged<IUIAnimationManager2, double, int>)((*lpVtbl)[7]))(
            this,
            completionDeadline
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AbandonAllStoryboards()
    {
        return ((delegate* unmanaged<IUIAnimationManager2, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Update(
        [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow,
        UI_ANIMATION_UPDATE_RESULT* updateResult = null
    )
    {
        return (
            (delegate* unmanaged<IUIAnimationManager2, double, UI_ANIMATION_UPDATE_RESULT*, int>)(
                (*lpVtbl)[9]
            )
        )(this, timeNow, updateResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetVariableFromTag(
        IUnknown @object,
        [NativeTypeName("UINT32")] uint id,
        IUIAnimationVariable2* variable
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationManager2,
                IUnknown,
                uint,
                IUIAnimationVariable2*,
                int>)((*lpVtbl)[10])
        )(this, @object, id, variable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStoryboardFromTag(
        IUnknown @object,
        [NativeTypeName("UINT32")] uint id,
        IUIAnimationStoryboard2* storyboard
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationManager2,
                IUnknown,
                uint,
                IUIAnimationStoryboard2*,
                int>)((*lpVtbl)[11])
        )(this, @object, id, storyboard);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EstimateNextEventTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* seconds)
    {
        return ((delegate* unmanaged<IUIAnimationManager2, double*, int>)((*lpVtbl)[12]))(
            this,
            seconds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetStatus(UI_ANIMATION_MANAGER_STATUS* status)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager2, UI_ANIMATION_MANAGER_STATUS*, int>)(
                (*lpVtbl)[13]
            )
        )(this, status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetAnimationMode(UI_ANIMATION_MODE mode)
    {
        return ((delegate* unmanaged<IUIAnimationManager2, UI_ANIMATION_MODE, int>)((*lpVtbl)[14]))(
            this,
            mode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IUIAnimationManager2, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IUIAnimationManager2, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetManagerEventHandler(
        IUIAnimationManagerEventHandler2 handler,
        [Optional] BOOL fRegisterForNextAnimationEvent
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationManager2,
                IUIAnimationManagerEventHandler2,
                BOOL,
                int>)((*lpVtbl)[17])
        )(this, handler, fRegisterForNextAnimationEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetCancelPriorityComparison(IUIAnimationPriorityComparison2 comparison)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager2, IUIAnimationPriorityComparison2, int>)(
                (*lpVtbl)[18]
            )
        )(this, comparison);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetTrimPriorityComparison(IUIAnimationPriorityComparison2 comparison)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager2, IUIAnimationPriorityComparison2, int>)(
                (*lpVtbl)[19]
            )
        )(this, comparison);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetCompressPriorityComparison(IUIAnimationPriorityComparison2 comparison)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager2, IUIAnimationPriorityComparison2, int>)(
                (*lpVtbl)[20]
            )
        )(this, comparison);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetConcludePriorityComparison(IUIAnimationPriorityComparison2 comparison)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager2, IUIAnimationPriorityComparison2, int>)(
                (*lpVtbl)[21]
            )
        )(this, comparison);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetDefaultLongestAcceptableDelay(
        [NativeTypeName("UI_ANIMATION_SECONDS")] double delay
    )
    {
        return ((delegate* unmanaged<IUIAnimationManager2, double, int>)((*lpVtbl)[22]))(
            this,
            delay
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IUIAnimationManager2, int>)((*lpVtbl)[23]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateAnimationVectorVariable(
            [NativeTypeName("const DOUBLE *")] double* initialValue,
            uint cDimension,
            IUIAnimationVariable2* variable
        );

        [VtblIndex(4)]
        HRESULT CreateAnimationVariable(double initialValue, IUIAnimationVariable2* variable);

        [VtblIndex(5)]
        HRESULT ScheduleTransition(
            IUIAnimationVariable2 variable,
            IUIAnimationTransition2 transition,
            [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow
        );

        [VtblIndex(6)]
        HRESULT CreateStoryboard(IUIAnimationStoryboard2* storyboard);

        [VtblIndex(7)]
        HRESULT FinishAllStoryboards(
            [NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline
        );

        [VtblIndex(8)]
        HRESULT AbandonAllStoryboards();

        [VtblIndex(9)]
        HRESULT Update(
            [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow,
            UI_ANIMATION_UPDATE_RESULT* updateResult = null
        );

        [VtblIndex(10)]
        HRESULT GetVariableFromTag(
            IUnknown @object,
            [NativeTypeName("UINT32")] uint id,
            IUIAnimationVariable2* variable
        );

        [VtblIndex(11)]
        HRESULT GetStoryboardFromTag(
            IUnknown @object,
            [NativeTypeName("UINT32")] uint id,
            IUIAnimationStoryboard2* storyboard
        );

        [VtblIndex(12)]
        HRESULT EstimateNextEventTime([NativeTypeName("UI_ANIMATION_SECONDS *")] double* seconds);

        [VtblIndex(13)]
        HRESULT GetStatus(UI_ANIMATION_MANAGER_STATUS* status);

        [VtblIndex(14)]
        HRESULT SetAnimationMode(UI_ANIMATION_MODE mode);

        [VtblIndex(15)]
        HRESULT Pause();

        [VtblIndex(16)]
        HRESULT Resume();

        [VtblIndex(17)]
        HRESULT SetManagerEventHandler(
            IUIAnimationManagerEventHandler2 handler,
            [Optional] BOOL fRegisterForNextAnimationEvent
        );

        [VtblIndex(18)]
        HRESULT SetCancelPriorityComparison(IUIAnimationPriorityComparison2 comparison);

        [VtblIndex(19)]
        HRESULT SetTrimPriorityComparison(IUIAnimationPriorityComparison2 comparison);

        [VtblIndex(20)]
        HRESULT SetCompressPriorityComparison(IUIAnimationPriorityComparison2 comparison);

        [VtblIndex(21)]
        HRESULT SetConcludePriorityComparison(IUIAnimationPriorityComparison2 comparison);

        [VtblIndex(22)]
        HRESULT SetDefaultLongestAcceptableDelay(
            [NativeTypeName("UI_ANIMATION_SECONDS")] double delay
        );

        [VtblIndex(23)]
        HRESULT Shutdown();
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

        [NativeTypeName(
            "HRESULT (const DOUBLE *, UINT, IUIAnimationVariable2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            double*,
            uint,
            IUIAnimationVariable2*,
            int> CreateAnimationVectorVariable;

        [NativeTypeName("HRESULT (DOUBLE, IUIAnimationVariable2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            double,
            IUIAnimationVariable2*,
            int> CreateAnimationVariable;

        [NativeTypeName(
            "HRESULT (IUIAnimationVariable2 *, IUIAnimationTransition2 *, UI_ANIMATION_SECONDS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationVariable2,
            IUIAnimationTransition2,
            double,
            int> ScheduleTransition;

        [NativeTypeName("HRESULT (IUIAnimationStoryboard2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationStoryboard2*, int> CreateStoryboard;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> FinishAllStoryboards;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> AbandonAllStoryboards;

        [NativeTypeName(
            "HRESULT (UI_ANIMATION_SECONDS, UI_ANIMATION_UPDATE_RESULT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, double, UI_ANIMATION_UPDATE_RESULT*, int> Update;

        [NativeTypeName(
            "HRESULT (IUnknown *, UINT32, IUIAnimationVariable2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            uint,
            IUIAnimationVariable2*,
            int> GetVariableFromTag;

        [NativeTypeName(
            "HRESULT (IUnknown *, UINT32, IUIAnimationStoryboard2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            uint,
            IUIAnimationStoryboard2*,
            int> GetStoryboardFromTag;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> EstimateNextEventTime;

        [NativeTypeName("HRESULT (UI_ANIMATION_MANAGER_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_MANAGER_STATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (UI_ANIMATION_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_MODE, int> SetAnimationMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;

        [NativeTypeName(
            "HRESULT (IUIAnimationManagerEventHandler2 *, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationManagerEventHandler2,
            BOOL,
            int> SetManagerEventHandler;

        [NativeTypeName("HRESULT (IUIAnimationPriorityComparison2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationPriorityComparison2,
            int> SetCancelPriorityComparison;

        [NativeTypeName("HRESULT (IUIAnimationPriorityComparison2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationPriorityComparison2,
            int> SetTrimPriorityComparison;

        [NativeTypeName("HRESULT (IUIAnimationPriorityComparison2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationPriorityComparison2,
            int> SetCompressPriorityComparison;

        [NativeTypeName("HRESULT (IUIAnimationPriorityComparison2 *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationPriorityComparison2,
            int> SetConcludePriorityComparison;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetDefaultLongestAcceptableDelay;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUIAnimationManager2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUIAnimationManager2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUIAnimationManager2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUIAnimationManager2(Silk.NET.Windows.IUnknown value)
    {
        return new IUIAnimationManager2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUIAnimationManager2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUIAnimationManager2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUIAnimationManager2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
