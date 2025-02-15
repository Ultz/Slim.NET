// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9169896C-AC8D-4E7D-94E5-67FA4DC2F2E8")]
[NativeTypeName("struct IUIAnimationManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationManager : IUIAnimationManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUIAnimationManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateAnimationVariable(double initialValue, IUIAnimationVariable* variable)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager, double, IUIAnimationVariable*, int>)(
                (*lpVtbl)[3]
            )
        )(this, initialValue, variable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ScheduleTransition(
        IUIAnimationVariable variable,
        IUIAnimationTransition transition,
        [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationManager,
                IUIAnimationVariable,
                IUIAnimationTransition,
                double,
                int>)((*lpVtbl)[4])
        )(this, variable, transition, timeNow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateStoryboard(IUIAnimationStoryboard* storyboard)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager, IUIAnimationStoryboard*, int>)((*lpVtbl)[5])
        )(this, storyboard);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FinishAllStoryboards(
        [NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline
    )
    {
        return ((delegate* unmanaged<IUIAnimationManager, double, int>)((*lpVtbl)[6]))(
            this,
            completionDeadline
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AbandonAllStoryboards()
    {
        return ((delegate* unmanaged<IUIAnimationManager, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Update(
        [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow,
        UI_ANIMATION_UPDATE_RESULT* updateResult = null
    )
    {
        return (
            (delegate* unmanaged<IUIAnimationManager, double, UI_ANIMATION_UPDATE_RESULT*, int>)(
                (*lpVtbl)[8]
            )
        )(this, timeNow, updateResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetVariableFromTag(
        IUnknown @object,
        [NativeTypeName("UINT32")] uint id,
        IUIAnimationVariable* variable
    )
    {
        return (
            (delegate* unmanaged<IUIAnimationManager, IUnknown, uint, IUIAnimationVariable*, int>)(
                (*lpVtbl)[9]
            )
        )(this, @object, id, variable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetStoryboardFromTag(
        IUnknown @object,
        [NativeTypeName("UINT32")] uint id,
        IUIAnimationStoryboard* storyboard
    )
    {
        return (
            (delegate* unmanaged<
                IUIAnimationManager,
                IUnknown,
                uint,
                IUIAnimationStoryboard*,
                int>)((*lpVtbl)[10])
        )(this, @object, id, storyboard);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStatus(UI_ANIMATION_MANAGER_STATUS* status)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager, UI_ANIMATION_MANAGER_STATUS*, int>)(
                (*lpVtbl)[11]
            )
        )(this, status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetAnimationMode(UI_ANIMATION_MODE mode)
    {
        return ((delegate* unmanaged<IUIAnimationManager, UI_ANIMATION_MODE, int>)((*lpVtbl)[12]))(
            this,
            mode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IUIAnimationManager, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IUIAnimationManager, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetManagerEventHandler(IUIAnimationManagerEventHandler handler)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager, IUIAnimationManagerEventHandler, int>)(
                (*lpVtbl)[15]
            )
        )(this, handler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetCancelPriorityComparison(IUIAnimationPriorityComparison comparison)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager, IUIAnimationPriorityComparison, int>)(
                (*lpVtbl)[16]
            )
        )(this, comparison);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTrimPriorityComparison(IUIAnimationPriorityComparison comparison)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager, IUIAnimationPriorityComparison, int>)(
                (*lpVtbl)[17]
            )
        )(this, comparison);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetCompressPriorityComparison(IUIAnimationPriorityComparison comparison)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager, IUIAnimationPriorityComparison, int>)(
                (*lpVtbl)[18]
            )
        )(this, comparison);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetConcludePriorityComparison(IUIAnimationPriorityComparison comparison)
    {
        return (
            (delegate* unmanaged<IUIAnimationManager, IUIAnimationPriorityComparison, int>)(
                (*lpVtbl)[19]
            )
        )(this, comparison);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetDefaultLongestAcceptableDelay(
        [NativeTypeName("UI_ANIMATION_SECONDS")] double delay
    )
    {
        return ((delegate* unmanaged<IUIAnimationManager, double, int>)((*lpVtbl)[20]))(
            this,
            delay
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IUIAnimationManager, int>)((*lpVtbl)[21]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateAnimationVariable(double initialValue, IUIAnimationVariable* variable);

        [VtblIndex(4)]
        HRESULT ScheduleTransition(
            IUIAnimationVariable variable,
            IUIAnimationTransition transition,
            [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow
        );

        [VtblIndex(5)]
        HRESULT CreateStoryboard(IUIAnimationStoryboard* storyboard);

        [VtblIndex(6)]
        HRESULT FinishAllStoryboards(
            [NativeTypeName("UI_ANIMATION_SECONDS")] double completionDeadline
        );

        [VtblIndex(7)]
        HRESULT AbandonAllStoryboards();

        [VtblIndex(8)]
        HRESULT Update(
            [NativeTypeName("UI_ANIMATION_SECONDS")] double timeNow,
            UI_ANIMATION_UPDATE_RESULT* updateResult = null
        );

        [VtblIndex(9)]
        HRESULT GetVariableFromTag(
            IUnknown @object,
            [NativeTypeName("UINT32")] uint id,
            IUIAnimationVariable* variable
        );

        [VtblIndex(10)]
        HRESULT GetStoryboardFromTag(
            IUnknown @object,
            [NativeTypeName("UINT32")] uint id,
            IUIAnimationStoryboard* storyboard
        );

        [VtblIndex(11)]
        HRESULT GetStatus(UI_ANIMATION_MANAGER_STATUS* status);

        [VtblIndex(12)]
        HRESULT SetAnimationMode(UI_ANIMATION_MODE mode);

        [VtblIndex(13)]
        HRESULT Pause();

        [VtblIndex(14)]
        HRESULT Resume();

        [VtblIndex(15)]
        HRESULT SetManagerEventHandler(IUIAnimationManagerEventHandler handler);

        [VtblIndex(16)]
        HRESULT SetCancelPriorityComparison(IUIAnimationPriorityComparison comparison);

        [VtblIndex(17)]
        HRESULT SetTrimPriorityComparison(IUIAnimationPriorityComparison comparison);

        [VtblIndex(18)]
        HRESULT SetCompressPriorityComparison(IUIAnimationPriorityComparison comparison);

        [VtblIndex(19)]
        HRESULT SetConcludePriorityComparison(IUIAnimationPriorityComparison comparison);

        [VtblIndex(20)]
        HRESULT SetDefaultLongestAcceptableDelay(
            [NativeTypeName("UI_ANIMATION_SECONDS")] double delay
        );

        [VtblIndex(21)]
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

        [NativeTypeName("HRESULT (DOUBLE, IUIAnimationVariable **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            double,
            IUIAnimationVariable*,
            int> CreateAnimationVariable;

        [NativeTypeName(
            "HRESULT (IUIAnimationVariable *, IUIAnimationTransition *, UI_ANIMATION_SECONDS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationVariable,
            IUIAnimationTransition,
            double,
            int> ScheduleTransition;

        [NativeTypeName("HRESULT (IUIAnimationStoryboard **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationStoryboard*, int> CreateStoryboard;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> FinishAllStoryboards;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> AbandonAllStoryboards;

        [NativeTypeName(
            "HRESULT (UI_ANIMATION_SECONDS, UI_ANIMATION_UPDATE_RESULT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, double, UI_ANIMATION_UPDATE_RESULT*, int> Update;

        [NativeTypeName(
            "HRESULT (IUnknown *, UINT32, IUIAnimationVariable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            uint,
            IUIAnimationVariable*,
            int> GetVariableFromTag;

        [NativeTypeName(
            "HRESULT (IUnknown *, UINT32, IUIAnimationStoryboard **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            uint,
            IUIAnimationStoryboard*,
            int> GetStoryboardFromTag;

        [NativeTypeName("HRESULT (UI_ANIMATION_MANAGER_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_MANAGER_STATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (UI_ANIMATION_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UI_ANIMATION_MODE, int> SetAnimationMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;

        [NativeTypeName("HRESULT (IUIAnimationManagerEventHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationManagerEventHandler,
            int> SetManagerEventHandler;

        [NativeTypeName("HRESULT (IUIAnimationPriorityComparison *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationPriorityComparison,
            int> SetCancelPriorityComparison;

        [NativeTypeName("HRESULT (IUIAnimationPriorityComparison *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationPriorityComparison,
            int> SetTrimPriorityComparison;

        [NativeTypeName("HRESULT (IUIAnimationPriorityComparison *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationPriorityComparison,
            int> SetCompressPriorityComparison;

        [NativeTypeName("HRESULT (IUIAnimationPriorityComparison *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUIAnimationPriorityComparison,
            int> SetConcludePriorityComparison;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetDefaultLongestAcceptableDelay;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUIAnimationManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUIAnimationManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUIAnimationManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUIAnimationManager(Silk.NET.Windows.IUnknown value)
    {
        return new IUIAnimationManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUIAnimationManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUIAnimationManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUIAnimationManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
