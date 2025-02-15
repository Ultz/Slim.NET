// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("13D29038-C3E6-4034-9081-13B53A417992")]
[NativeTypeName("struct ID2D1TransformGraph : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1TransformGraph : ID2D1TransformGraph.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1TransformGraph));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1TransformGraph, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1TransformGraph, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetInputCount()
    {
        return ((delegate* unmanaged<ID2D1TransformGraph, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSingleTransformNode(ID2D1TransformNode node)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph, ID2D1TransformNode, int>)((*lpVtbl)[4]))(
            this,
            node
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddNode(ID2D1TransformNode node)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph, ID2D1TransformNode, int>)((*lpVtbl)[5]))(
            this,
            node
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveNode(ID2D1TransformNode node)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph, ID2D1TransformNode, int>)((*lpVtbl)[6]))(
            this,
            node
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetOutputNode(ID2D1TransformNode node)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph, ID2D1TransformNode, int>)((*lpVtbl)[7]))(
            this,
            node
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ConnectNode(
        ID2D1TransformNode fromNode,
        ID2D1TransformNode toNode,
        [NativeTypeName("UINT32")] uint toNodeInputIndex
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1TransformGraph,
                ID2D1TransformNode,
                ID2D1TransformNode,
                uint,
                int>)((*lpVtbl)[8])
        )(this, fromNode, toNode, toNodeInputIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ConnectToEffectInput(
        [NativeTypeName("UINT32")] uint toEffectInputIndex,
        ID2D1TransformNode node,
        [NativeTypeName("UINT32")] uint toNodeInputIndex
    )
    {
        return (
            (delegate* unmanaged<ID2D1TransformGraph, uint, ID2D1TransformNode, uint, int>)(
                (*lpVtbl)[9]
            )
        )(this, toEffectInputIndex, node, toNodeInputIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void Clear()
    {
        ((delegate* unmanaged<ID2D1TransformGraph, void>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetPassthroughGraph([NativeTypeName("UINT32")] uint effectInputIndex)
    {
        return ((delegate* unmanaged<ID2D1TransformGraph, uint, int>)((*lpVtbl)[11]))(
            this,
            effectInputIndex
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        uint GetInputCount();

        [VtblIndex(4)]
        HRESULT SetSingleTransformNode(ID2D1TransformNode node);

        [VtblIndex(5)]
        HRESULT AddNode(ID2D1TransformNode node);

        [VtblIndex(6)]
        HRESULT RemoveNode(ID2D1TransformNode node);

        [VtblIndex(7)]
        HRESULT SetOutputNode(ID2D1TransformNode node);

        [VtblIndex(8)]
        HRESULT ConnectNode(
            ID2D1TransformNode fromNode,
            ID2D1TransformNode toNode,
            [NativeTypeName("UINT32")] uint toNodeInputIndex
        );

        [VtblIndex(9)]
        HRESULT ConnectToEffectInput(
            [NativeTypeName("UINT32")] uint toEffectInputIndex,
            ID2D1TransformNode node,
            [NativeTypeName("UINT32")] uint toNodeInputIndex
        );

        [VtblIndex(10)]
        void Clear();

        [VtblIndex(11)]
        HRESULT SetPassthroughGraph([NativeTypeName("UINT32")] uint effectInputIndex);
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

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetInputCount;

        [NativeTypeName(
            "HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1TransformNode, int> SetSingleTransformNode;

        [NativeTypeName(
            "HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1TransformNode, int> AddNode;

        [NativeTypeName(
            "HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1TransformNode, int> RemoveNode;

        [NativeTypeName(
            "HRESULT (ID2D1TransformNode *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1TransformNode, int> SetOutputNode;

        [NativeTypeName(
            "HRESULT (ID2D1TransformNode *, ID2D1TransformNode *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1TransformNode,
            ID2D1TransformNode,
            uint,
            int> ConnectNode;

        [NativeTypeName(
            "HRESULT (UINT32, ID2D1TransformNode *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ID2D1TransformNode,
            uint,
            int> ConnectToEffectInput;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Clear;

        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetPassthroughGraph;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1TransformGraph"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1TransformGraph(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1TransformGraph"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1TransformGraph(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1TransformGraph(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1TransformGraph"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1TransformGraph"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1TransformGraph value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
