// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("30510740-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLCSSStyleDeclaration : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLCSSStyleDeclaration
    : IHTMLCSSStyleDeclaration.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLCSSStyleDeclaration));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IHTMLCSSStyleDeclaration, uint, uint, ITypeInfo*, int>)(
                (*lpVtbl)[4]
            )
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IHTMLCSSStyleDeclaration, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLCSSStyleDeclaration,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, int*, int>)((*lpVtbl)[7]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_parentRule(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[8]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT getPropertyValue(
        [NativeTypeName("BSTR")] ushort* bstrPropertyName,
        [NativeTypeName("BSTR *")] ushort** pbstrPropertyValue
    )
    {
        return (
            (delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, ushort**, int>)((*lpVtbl)[9])
        )(this, bstrPropertyName, pbstrPropertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT getPropertyPriority(
        [NativeTypeName("BSTR")] ushort* bstrPropertyName,
        [NativeTypeName("BSTR *")] ushort** pbstrPropertyPriority
    )
    {
        return (
            (delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, ushort**, int>)((*lpVtbl)[10])
        )(this, bstrPropertyName, pbstrPropertyPriority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT removeProperty(
        [NativeTypeName("BSTR")] ushort* bstrPropertyName,
        [NativeTypeName("BSTR *")] ushort** pbstrPropertyValue
    )
    {
        return (
            (delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, ushort**, int>)((*lpVtbl)[11])
        )(this, bstrPropertyName, pbstrPropertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT setProperty(
        [NativeTypeName("BSTR")] ushort* bstrPropertyName,
        VARIANT* pvarPropertyValue,
        VARIANT* pvarPropertyPriority = null
    )
    {
        return (
            (delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, VARIANT*, VARIANT*, int>)(
                (*lpVtbl)[12]
            )
        )(this, bstrPropertyName, pvarPropertyValue, pvarPropertyPriority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT item(
        [NativeTypeName("long")] int index,
        [NativeTypeName("BSTR *")] ushort** pbstrPropertyName
    )
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, int, ushort**, int>)((*lpVtbl)[13]))(
            this,
            index,
            pbstrPropertyName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_fontFamily([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[14]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_fontFamily([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[15]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_fontStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[16]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_fontStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[17]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_fontVariant([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[18]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_fontVariant([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[19]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_fontWeight([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[20]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_fontWeight([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[21]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_fontSize(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[22]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_fontSize(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[23]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_font([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[24]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_font([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[25]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_color(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[26]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_color(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[27]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_background([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[28]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_background([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[29]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_backgroundColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[30]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_backgroundColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[31]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_backgroundImage([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[32]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_backgroundImage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[33]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_backgroundRepeat([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[34]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_backgroundRepeat([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[35]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_backgroundAttachment([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[36]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_backgroundAttachment([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[37]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_backgroundPosition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[38]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_backgroundPosition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[39]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_backgroundPositionX(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[40]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_backgroundPositionX(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[41]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_backgroundPositionY(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[42]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_backgroundPositionY(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[43]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_wordSpacing(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[44]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_wordSpacing(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[45]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_letterSpacing(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[46]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_letterSpacing(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[47]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_textDecoration([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[48]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_textDecoration([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[49]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT put_verticalAlign(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[50]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_verticalAlign(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[51]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT put_textTransform([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[52]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_textTransform([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[53]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT put_textAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[54]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_textAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[55]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT put_textIndent(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[56]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_textIndent(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[57]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT put_lineHeight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[58]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_lineHeight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[59]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT put_marginTop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[60]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_marginTop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[61]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT put_marginRight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[62]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_marginRight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[63]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT put_marginBottom(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[64]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_marginBottom(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[65]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT put_marginLeft(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[66]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_marginLeft(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[67]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT put_margin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[68]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_margin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[69]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT put_paddingTop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[70]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT get_paddingTop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[71]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT put_paddingRight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[72]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT get_paddingRight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[73]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT put_paddingBottom(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[74]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT get_paddingBottom(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[75]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT put_paddingLeft(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[76]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT get_paddingLeft(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[77]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT put_padding([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[78]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT get_padding([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[79]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT put_border([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[80]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT get_border([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[81]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT put_borderTop([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[82]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT get_borderTop([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[83]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT put_borderRight([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[84]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT get_borderRight([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[85]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT put_borderBottom([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[86]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT get_borderBottom([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[87]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT put_borderLeft([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[88]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT get_borderLeft([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[89]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT put_borderColor([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[90]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT get_borderColor([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[91]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT put_borderTopColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[92]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT get_borderTopColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[93]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT put_borderRightColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[94]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT get_borderRightColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[95]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT put_borderBottomColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[96]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT get_borderBottomColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[97]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT put_borderLeftColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[98]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT get_borderLeftColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[99]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT put_borderWidth([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[100]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT get_borderWidth([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[101]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT put_borderTopWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[102]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT get_borderTopWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[103]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT put_borderRightWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[104]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT get_borderRightWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[105]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT put_borderBottomWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[106]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT get_borderBottomWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[107]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT put_borderLeftWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[108]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT get_borderLeftWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[109]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT put_borderStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[110]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT get_borderStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[111]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT put_borderTopStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[112]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT get_borderTopStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[113]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT put_borderRightStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[114]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT get_borderRightStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[115]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HRESULT put_borderBottomStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[116]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT get_borderBottomStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[117]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT put_borderLeftStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[118]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public HRESULT get_borderLeftStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[119]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public HRESULT put_width(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[120]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public HRESULT get_width(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[121]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public HRESULT put_height(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[122]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public HRESULT get_height(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[123]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public HRESULT put_styleFloat([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[124]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public HRESULT get_styleFloat([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[125]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(126)]
    public HRESULT put_clear([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[126]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(127)]
    public HRESULT get_clear([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[127]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(128)]
    public HRESULT put_display([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[128]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(129)]
    public HRESULT get_display([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[129]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(130)]
    public HRESULT put_visibility([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[130]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(131)]
    public HRESULT get_visibility([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[131]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(132)]
    public HRESULT put_listStyleType([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[132]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(133)]
    public HRESULT get_listStyleType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[133]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(134)]
    public HRESULT put_listStylePosition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[134]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(135)]
    public HRESULT get_listStylePosition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[135]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(136)]
    public HRESULT put_listStyleImage([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[136]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(137)]
    public HRESULT get_listStyleImage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[137]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(138)]
    public HRESULT put_listStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[138]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(139)]
    public HRESULT get_listStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[139]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(140)]
    public HRESULT put_whiteSpace([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[140]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(141)]
    public HRESULT get_whiteSpace([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[141]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(142)]
    public HRESULT put_top(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[142]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(143)]
    public HRESULT get_top(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[143]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(144)]
    public HRESULT put_left(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[144]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(145)]
    public HRESULT get_left(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[145]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(146)]
    public HRESULT put_zIndex(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[146]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(147)]
    public HRESULT get_zIndex(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[147]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(148)]
    public HRESULT put_overflow([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[148]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(149)]
    public HRESULT get_overflow([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[149]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(150)]
    public HRESULT put_pageBreakBefore([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[150]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(151)]
    public HRESULT get_pageBreakBefore([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[151]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(152)]
    public HRESULT put_pageBreakAfter([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[152]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(153)]
    public HRESULT get_pageBreakAfter([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[153]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(154)]
    public HRESULT put_cssText([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[154]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(155)]
    public HRESULT get_cssText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[155]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(156)]
    public HRESULT put_cursor([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[156]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(157)]
    public HRESULT get_cursor([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[157]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(158)]
    public HRESULT put_clip([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[158]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(159)]
    public HRESULT get_clip([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[159]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(160)]
    public HRESULT put_filter([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[160]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(161)]
    public HRESULT get_filter([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[161]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(162)]
    public HRESULT put_tableLayout([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[162]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(163)]
    public HRESULT get_tableLayout([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[163]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(164)]
    public HRESULT put_borderCollapse([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[164]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(165)]
    public HRESULT get_borderCollapse([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[165]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(166)]
    public HRESULT put_direction([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[166]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(167)]
    public HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[167]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(168)]
    public HRESULT put_behavior([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[168]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(169)]
    public HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[169]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(170)]
    public HRESULT put_position([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[170]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(171)]
    public HRESULT get_position([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[171]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(172)]
    public HRESULT put_unicodeBidi([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[172]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(173)]
    public HRESULT get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[173]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(174)]
    public HRESULT put_bottom(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[174]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(175)]
    public HRESULT get_bottom(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[175]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(176)]
    public HRESULT put_right(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[176]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(177)]
    public HRESULT get_right(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[177]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(178)]
    public HRESULT put_imeMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[178]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(179)]
    public HRESULT get_imeMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[179]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(180)]
    public HRESULT put_rubyAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[180]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(181)]
    public HRESULT get_rubyAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[181]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(182)]
    public HRESULT put_rubyPosition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[182]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(183)]
    public HRESULT get_rubyPosition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[183]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(184)]
    public HRESULT put_rubyOverhang([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[184]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(185)]
    public HRESULT get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[185]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(186)]
    public HRESULT put_layoutGridChar(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[186]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(187)]
    public HRESULT get_layoutGridChar(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[187]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(188)]
    public HRESULT put_layoutGridLine(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[188]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(189)]
    public HRESULT get_layoutGridLine(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[189]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(190)]
    public HRESULT put_layoutGridMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[190]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(191)]
    public HRESULT get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[191]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(192)]
    public HRESULT put_layoutGridType([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[192]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(193)]
    public HRESULT get_layoutGridType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[193]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(194)]
    public HRESULT put_layoutGrid([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[194]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(195)]
    public HRESULT get_layoutGrid([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[195]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(196)]
    public HRESULT put_textAutospace([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[196]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(197)]
    public HRESULT get_textAutospace([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[197]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(198)]
    public HRESULT put_wordBreak([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[198]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(199)]
    public HRESULT get_wordBreak([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[199]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(200)]
    public HRESULT put_lineBreak([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[200]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(201)]
    public HRESULT get_lineBreak([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[201]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(202)]
    public HRESULT put_textJustify([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[202]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(203)]
    public HRESULT get_textJustify([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[203]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(204)]
    public HRESULT put_textJustifyTrim([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[204]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(205)]
    public HRESULT get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[205]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(206)]
    public HRESULT put_textKashida(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[206]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(207)]
    public HRESULT get_textKashida(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[207]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(208)]
    public HRESULT put_overflowX([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[208]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(209)]
    public HRESULT get_overflowX([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[209]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(210)]
    public HRESULT put_overflowY([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[210]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(211)]
    public HRESULT get_overflowY([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[211]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(212)]
    public HRESULT put_accelerator([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[212]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(213)]
    public HRESULT get_accelerator([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[213]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(214)]
    public HRESULT put_layoutFlow([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[214]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(215)]
    public HRESULT get_layoutFlow([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[215]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(216)]
    public HRESULT put_zoom(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[216]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(217)]
    public HRESULT get_zoom(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[217]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(218)]
    public HRESULT put_wordWrap([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[218]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(219)]
    public HRESULT get_wordWrap([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[219]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(220)]
    public HRESULT put_textUnderlinePosition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[220]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(221)]
    public HRESULT get_textUnderlinePosition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[221]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(222)]
    public HRESULT put_scrollbarBaseColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[222]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(223)]
    public HRESULT get_scrollbarBaseColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[223]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(224)]
    public HRESULT put_scrollbarFaceColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[224]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(225)]
    public HRESULT get_scrollbarFaceColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[225]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(226)]
    public HRESULT put_scrollbar3dLightColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[226]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(227)]
    public HRESULT get_scrollbar3dLightColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[227]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(228)]
    public HRESULT put_scrollbarShadowColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[228]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(229)]
    public HRESULT get_scrollbarShadowColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[229]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(230)]
    public HRESULT put_scrollbarHighlightColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[230]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(231)]
    public HRESULT get_scrollbarHighlightColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[231]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(232)]
    public HRESULT put_scrollbarDarkShadowColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[232]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(233)]
    public HRESULT get_scrollbarDarkShadowColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[233]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(234)]
    public HRESULT put_scrollbarArrowColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[234]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(235)]
    public HRESULT get_scrollbarArrowColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[235]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(236)]
    public HRESULT put_scrollbarTrackColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[236]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(237)]
    public HRESULT get_scrollbarTrackColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[237]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(238)]
    public HRESULT put_writingMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[238]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(239)]
    public HRESULT get_writingMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[239]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(240)]
    public HRESULT put_textAlignLast([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[240]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(241)]
    public HRESULT get_textAlignLast([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[241]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(242)]
    public HRESULT put_textKashidaSpace(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[242]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(243)]
    public HRESULT get_textKashidaSpace(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[243]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(244)]
    public HRESULT put_textOverflow([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[244]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(245)]
    public HRESULT get_textOverflow([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[245]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(246)]
    public HRESULT put_minHeight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[246]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(247)]
    public HRESULT get_minHeight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[247]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(248)]
    public HRESULT put_msInterpolationMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[248]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(249)]
    public HRESULT get_msInterpolationMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[249]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(250)]
    public HRESULT put_maxHeight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[250]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(251)]
    public HRESULT get_maxHeight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[251]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(252)]
    public HRESULT put_minWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[252]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(253)]
    public HRESULT get_minWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[253]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(254)]
    public HRESULT put_maxWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[254]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(255)]
    public HRESULT get_maxWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[255]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(256)]
    public HRESULT put_content([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[256]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(257)]
    public HRESULT get_content([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[257]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(258)]
    public HRESULT put_captionSide([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[258]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(259)]
    public HRESULT get_captionSide([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[259]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(260)]
    public HRESULT put_counterIncrement([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[260]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(261)]
    public HRESULT get_counterIncrement([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[261]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(262)]
    public HRESULT put_counterReset([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[262]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(263)]
    public HRESULT get_counterReset([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[263]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(264)]
    public HRESULT put_outline([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[264]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(265)]
    public HRESULT get_outline([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[265]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(266)]
    public HRESULT put_outlineWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[266]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(267)]
    public HRESULT get_outlineWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[267]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(268)]
    public HRESULT put_outlineStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[268]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(269)]
    public HRESULT get_outlineStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[269]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(270)]
    public HRESULT put_outlineColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[270]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(271)]
    public HRESULT get_outlineColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[271]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(272)]
    public HRESULT put_boxSizing([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[272]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(273)]
    public HRESULT get_boxSizing([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[273]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(274)]
    public HRESULT put_borderSpacing([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[274]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(275)]
    public HRESULT get_borderSpacing([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[275]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(276)]
    public HRESULT put_orphans(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[276]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(277)]
    public HRESULT get_orphans(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[277]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(278)]
    public HRESULT put_widows(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[278]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(279)]
    public HRESULT get_widows(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[279]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(280)]
    public HRESULT put_pageBreakInside([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[280]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(281)]
    public HRESULT get_pageBreakInside([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[281]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(282)]
    public HRESULT put_emptyCells([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[282]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(283)]
    public HRESULT get_emptyCells([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[283]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(284)]
    public HRESULT put_msBlockProgression([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[284]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(285)]
    public HRESULT get_msBlockProgression([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[285]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(286)]
    public HRESULT put_quotes([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[286]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(287)]
    public HRESULT get_quotes([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[287]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(288)]
    public HRESULT put_alignmentBaseline([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[288]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(289)]
    public HRESULT get_alignmentBaseline([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[289]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(290)]
    public HRESULT put_baselineShift(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[290]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(291)]
    public HRESULT get_baselineShift(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[291]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(292)]
    public HRESULT put_dominantBaseline([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[292]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(293)]
    public HRESULT get_dominantBaseline([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[293]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(294)]
    public HRESULT put_fontSizeAdjust(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[294]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(295)]
    public HRESULT get_fontSizeAdjust(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[295]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(296)]
    public HRESULT put_fontStretch([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[296]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(297)]
    public HRESULT get_fontStretch([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[297]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(298)]
    public HRESULT put_opacity(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[298]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(299)]
    public HRESULT get_opacity(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[299]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(300)]
    public HRESULT put_clipPath([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[300]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(301)]
    public HRESULT get_clipPath([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[301]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(302)]
    public HRESULT put_clipRule([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[302]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(303)]
    public HRESULT get_clipRule([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[303]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(304)]
    public HRESULT put_fill([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[304]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(305)]
    public HRESULT get_fill([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[305]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(306)]
    public HRESULT put_fillOpacity(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[306]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(307)]
    public HRESULT get_fillOpacity(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[307]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(308)]
    public HRESULT put_fillRule([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[308]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(309)]
    public HRESULT get_fillRule([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[309]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(310)]
    public HRESULT put_kerning(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[310]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(311)]
    public HRESULT get_kerning(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[311]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(312)]
    public HRESULT put_marker([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[312]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(313)]
    public HRESULT get_marker([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[313]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(314)]
    public HRESULT put_markerEnd([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[314]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(315)]
    public HRESULT get_markerEnd([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[315]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(316)]
    public HRESULT put_markerMid([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[316]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(317)]
    public HRESULT get_markerMid([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[317]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(318)]
    public HRESULT put_markerStart([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[318]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(319)]
    public HRESULT get_markerStart([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[319]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(320)]
    public HRESULT put_mask([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[320]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(321)]
    public HRESULT get_mask([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[321]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(322)]
    public HRESULT put_pointerEvents([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[322]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(323)]
    public HRESULT get_pointerEvents([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[323]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(324)]
    public HRESULT put_stopColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[324]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(325)]
    public HRESULT get_stopColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[325]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(326)]
    public HRESULT put_stopOpacity(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[326]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(327)]
    public HRESULT get_stopOpacity(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[327]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(328)]
    public HRESULT put_stroke([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[328]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(329)]
    public HRESULT get_stroke([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[329]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(330)]
    public HRESULT put_strokeDasharray([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[330]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(331)]
    public HRESULT get_strokeDasharray([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[331]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(332)]
    public HRESULT put_strokeDashoffset(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[332]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(333)]
    public HRESULT get_strokeDashoffset(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[333]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(334)]
    public HRESULT put_strokeLinecap([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[334]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(335)]
    public HRESULT get_strokeLinecap([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[335]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(336)]
    public HRESULT put_strokeLinejoin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[336]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(337)]
    public HRESULT get_strokeLinejoin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[337]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(338)]
    public HRESULT put_strokeMiterlimit(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[338]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(339)]
    public HRESULT get_strokeMiterlimit(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[339]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(340)]
    public HRESULT put_strokeOpacity(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[340]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(341)]
    public HRESULT get_strokeOpacity(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[341]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(342)]
    public HRESULT put_strokeWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[342]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(343)]
    public HRESULT get_strokeWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[343]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(344)]
    public HRESULT put_textAnchor([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[344]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(345)]
    public HRESULT get_textAnchor([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[345]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(346)]
    public HRESULT put_glyphOrientationHorizontal(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[346]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(347)]
    public HRESULT get_glyphOrientationHorizontal(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[347]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(348)]
    public HRESULT put_glyphOrientationVertical(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[348]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(349)]
    public HRESULT get_glyphOrientationVertical(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[349]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(350)]
    public HRESULT put_borderRadius([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[350]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(351)]
    public HRESULT get_borderRadius([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[351]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(352)]
    public HRESULT put_borderTopLeftRadius([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[352]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(353)]
    public HRESULT get_borderTopLeftRadius([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[353]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(354)]
    public HRESULT put_borderTopRightRadius([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[354]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(355)]
    public HRESULT get_borderTopRightRadius([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[355]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(356)]
    public HRESULT put_borderBottomRightRadius([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[356]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(357)]
    public HRESULT get_borderBottomRightRadius([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[357]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(358)]
    public HRESULT put_borderBottomLeftRadius([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[358]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(359)]
    public HRESULT get_borderBottomLeftRadius([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[359]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(360)]
    public HRESULT put_clipTop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[360]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(361)]
    public HRESULT get_clipTop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[361]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(362)]
    public HRESULT put_clipRight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[362]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(363)]
    public HRESULT get_clipRight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[363]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(364)]
    public HRESULT get_clipBottom(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[364]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(365)]
    public HRESULT put_clipLeft(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT, int>)((*lpVtbl)[365]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(366)]
    public HRESULT get_clipLeft(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, VARIANT*, int>)((*lpVtbl)[366]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(367)]
    public HRESULT put_cssFloat([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[367]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(368)]
    public HRESULT get_cssFloat([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[368]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(369)]
    public HRESULT put_backgroundClip([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[369]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(370)]
    public HRESULT get_backgroundClip([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[370]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(371)]
    public HRESULT put_backgroundOrigin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[371]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(372)]
    public HRESULT get_backgroundOrigin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[372]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(373)]
    public HRESULT put_backgroundSize([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[373]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(374)]
    public HRESULT get_backgroundSize([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[374]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(375)]
    public HRESULT put_boxShadow([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[375]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(376)]
    public HRESULT get_boxShadow([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[376]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(377)]
    public HRESULT put_msTransform([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[377]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(378)]
    public HRESULT get_msTransform([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[378]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(379)]
    public HRESULT put_msTransformOrigin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort*, int>)((*lpVtbl)[379]))(
            this,
            v
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(380)]
    public HRESULT get_msTransformOrigin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration, ushort**, int>)((*lpVtbl)[380]))(
            this,
            p
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_length([NativeTypeName("long *")] int* p);

        [VtblIndex(8)]
        HRESULT get_parentRule(VARIANT* p);

        [VtblIndex(9)]
        HRESULT getPropertyValue(
            [NativeTypeName("BSTR")] ushort* bstrPropertyName,
            [NativeTypeName("BSTR *")] ushort** pbstrPropertyValue
        );

        [VtblIndex(10)]
        HRESULT getPropertyPriority(
            [NativeTypeName("BSTR")] ushort* bstrPropertyName,
            [NativeTypeName("BSTR *")] ushort** pbstrPropertyPriority
        );

        [VtblIndex(11)]
        HRESULT removeProperty(
            [NativeTypeName("BSTR")] ushort* bstrPropertyName,
            [NativeTypeName("BSTR *")] ushort** pbstrPropertyValue
        );

        [VtblIndex(12)]
        HRESULT setProperty(
            [NativeTypeName("BSTR")] ushort* bstrPropertyName,
            VARIANT* pvarPropertyValue,
            VARIANT* pvarPropertyPriority = null
        );

        [VtblIndex(13)]
        HRESULT item(
            [NativeTypeName("long")] int index,
            [NativeTypeName("BSTR *")] ushort** pbstrPropertyName
        );

        [VtblIndex(14)]
        HRESULT put_fontFamily([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(15)]
        HRESULT get_fontFamily([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(16)]
        HRESULT put_fontStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(17)]
        HRESULT get_fontStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(18)]
        HRESULT put_fontVariant([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(19)]
        HRESULT get_fontVariant([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(20)]
        HRESULT put_fontWeight([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(21)]
        HRESULT get_fontWeight([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(22)]
        HRESULT put_fontSize(VARIANT v);

        [VtblIndex(23)]
        HRESULT get_fontSize(VARIANT* p);

        [VtblIndex(24)]
        HRESULT put_font([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(25)]
        HRESULT get_font([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(26)]
        HRESULT put_color(VARIANT v);

        [VtblIndex(27)]
        HRESULT get_color(VARIANT* p);

        [VtblIndex(28)]
        HRESULT put_background([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(29)]
        HRESULT get_background([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(30)]
        HRESULT put_backgroundColor(VARIANT v);

        [VtblIndex(31)]
        HRESULT get_backgroundColor(VARIANT* p);

        [VtblIndex(32)]
        HRESULT put_backgroundImage([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(33)]
        HRESULT get_backgroundImage([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(34)]
        HRESULT put_backgroundRepeat([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(35)]
        HRESULT get_backgroundRepeat([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(36)]
        HRESULT put_backgroundAttachment([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(37)]
        HRESULT get_backgroundAttachment([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(38)]
        HRESULT put_backgroundPosition([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(39)]
        HRESULT get_backgroundPosition([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(40)]
        HRESULT put_backgroundPositionX(VARIANT v);

        [VtblIndex(41)]
        HRESULT get_backgroundPositionX(VARIANT* p);

        [VtblIndex(42)]
        HRESULT put_backgroundPositionY(VARIANT v);

        [VtblIndex(43)]
        HRESULT get_backgroundPositionY(VARIANT* p);

        [VtblIndex(44)]
        HRESULT put_wordSpacing(VARIANT v);

        [VtblIndex(45)]
        HRESULT get_wordSpacing(VARIANT* p);

        [VtblIndex(46)]
        HRESULT put_letterSpacing(VARIANT v);

        [VtblIndex(47)]
        HRESULT get_letterSpacing(VARIANT* p);

        [VtblIndex(48)]
        HRESULT put_textDecoration([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(49)]
        HRESULT get_textDecoration([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(50)]
        HRESULT put_verticalAlign(VARIANT v);

        [VtblIndex(51)]
        HRESULT get_verticalAlign(VARIANT* p);

        [VtblIndex(52)]
        HRESULT put_textTransform([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(53)]
        HRESULT get_textTransform([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(54)]
        HRESULT put_textAlign([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(55)]
        HRESULT get_textAlign([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(56)]
        HRESULT put_textIndent(VARIANT v);

        [VtblIndex(57)]
        HRESULT get_textIndent(VARIANT* p);

        [VtblIndex(58)]
        HRESULT put_lineHeight(VARIANT v);

        [VtblIndex(59)]
        HRESULT get_lineHeight(VARIANT* p);

        [VtblIndex(60)]
        HRESULT put_marginTop(VARIANT v);

        [VtblIndex(61)]
        HRESULT get_marginTop(VARIANT* p);

        [VtblIndex(62)]
        HRESULT put_marginRight(VARIANT v);

        [VtblIndex(63)]
        HRESULT get_marginRight(VARIANT* p);

        [VtblIndex(64)]
        HRESULT put_marginBottom(VARIANT v);

        [VtblIndex(65)]
        HRESULT get_marginBottom(VARIANT* p);

        [VtblIndex(66)]
        HRESULT put_marginLeft(VARIANT v);

        [VtblIndex(67)]
        HRESULT get_marginLeft(VARIANT* p);

        [VtblIndex(68)]
        HRESULT put_margin([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(69)]
        HRESULT get_margin([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(70)]
        HRESULT put_paddingTop(VARIANT v);

        [VtblIndex(71)]
        HRESULT get_paddingTop(VARIANT* p);

        [VtblIndex(72)]
        HRESULT put_paddingRight(VARIANT v);

        [VtblIndex(73)]
        HRESULT get_paddingRight(VARIANT* p);

        [VtblIndex(74)]
        HRESULT put_paddingBottom(VARIANT v);

        [VtblIndex(75)]
        HRESULT get_paddingBottom(VARIANT* p);

        [VtblIndex(76)]
        HRESULT put_paddingLeft(VARIANT v);

        [VtblIndex(77)]
        HRESULT get_paddingLeft(VARIANT* p);

        [VtblIndex(78)]
        HRESULT put_padding([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(79)]
        HRESULT get_padding([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(80)]
        HRESULT put_border([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(81)]
        HRESULT get_border([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(82)]
        HRESULT put_borderTop([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(83)]
        HRESULT get_borderTop([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(84)]
        HRESULT put_borderRight([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(85)]
        HRESULT get_borderRight([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(86)]
        HRESULT put_borderBottom([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(87)]
        HRESULT get_borderBottom([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(88)]
        HRESULT put_borderLeft([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(89)]
        HRESULT get_borderLeft([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(90)]
        HRESULT put_borderColor([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(91)]
        HRESULT get_borderColor([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(92)]
        HRESULT put_borderTopColor(VARIANT v);

        [VtblIndex(93)]
        HRESULT get_borderTopColor(VARIANT* p);

        [VtblIndex(94)]
        HRESULT put_borderRightColor(VARIANT v);

        [VtblIndex(95)]
        HRESULT get_borderRightColor(VARIANT* p);

        [VtblIndex(96)]
        HRESULT put_borderBottomColor(VARIANT v);

        [VtblIndex(97)]
        HRESULT get_borderBottomColor(VARIANT* p);

        [VtblIndex(98)]
        HRESULT put_borderLeftColor(VARIANT v);

        [VtblIndex(99)]
        HRESULT get_borderLeftColor(VARIANT* p);

        [VtblIndex(100)]
        HRESULT put_borderWidth([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(101)]
        HRESULT get_borderWidth([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(102)]
        HRESULT put_borderTopWidth(VARIANT v);

        [VtblIndex(103)]
        HRESULT get_borderTopWidth(VARIANT* p);

        [VtblIndex(104)]
        HRESULT put_borderRightWidth(VARIANT v);

        [VtblIndex(105)]
        HRESULT get_borderRightWidth(VARIANT* p);

        [VtblIndex(106)]
        HRESULT put_borderBottomWidth(VARIANT v);

        [VtblIndex(107)]
        HRESULT get_borderBottomWidth(VARIANT* p);

        [VtblIndex(108)]
        HRESULT put_borderLeftWidth(VARIANT v);

        [VtblIndex(109)]
        HRESULT get_borderLeftWidth(VARIANT* p);

        [VtblIndex(110)]
        HRESULT put_borderStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(111)]
        HRESULT get_borderStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(112)]
        HRESULT put_borderTopStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(113)]
        HRESULT get_borderTopStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(114)]
        HRESULT put_borderRightStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(115)]
        HRESULT get_borderRightStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(116)]
        HRESULT put_borderBottomStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(117)]
        HRESULT get_borderBottomStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(118)]
        HRESULT put_borderLeftStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(119)]
        HRESULT get_borderLeftStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(120)]
        HRESULT put_width(VARIANT v);

        [VtblIndex(121)]
        HRESULT get_width(VARIANT* p);

        [VtblIndex(122)]
        HRESULT put_height(VARIANT v);

        [VtblIndex(123)]
        HRESULT get_height(VARIANT* p);

        [VtblIndex(124)]
        HRESULT put_styleFloat([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(125)]
        HRESULT get_styleFloat([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(126)]
        HRESULT put_clear([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(127)]
        HRESULT get_clear([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(128)]
        HRESULT put_display([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(129)]
        HRESULT get_display([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(130)]
        HRESULT put_visibility([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(131)]
        HRESULT get_visibility([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(132)]
        HRESULT put_listStyleType([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(133)]
        HRESULT get_listStyleType([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(134)]
        HRESULT put_listStylePosition([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(135)]
        HRESULT get_listStylePosition([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(136)]
        HRESULT put_listStyleImage([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(137)]
        HRESULT get_listStyleImage([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(138)]
        HRESULT put_listStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(139)]
        HRESULT get_listStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(140)]
        HRESULT put_whiteSpace([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(141)]
        HRESULT get_whiteSpace([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(142)]
        HRESULT put_top(VARIANT v);

        [VtblIndex(143)]
        HRESULT get_top(VARIANT* p);

        [VtblIndex(144)]
        HRESULT put_left(VARIANT v);

        [VtblIndex(145)]
        HRESULT get_left(VARIANT* p);

        [VtblIndex(146)]
        HRESULT put_zIndex(VARIANT v);

        [VtblIndex(147)]
        HRESULT get_zIndex(VARIANT* p);

        [VtblIndex(148)]
        HRESULT put_overflow([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(149)]
        HRESULT get_overflow([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(150)]
        HRESULT put_pageBreakBefore([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(151)]
        HRESULT get_pageBreakBefore([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(152)]
        HRESULT put_pageBreakAfter([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(153)]
        HRESULT get_pageBreakAfter([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(154)]
        HRESULT put_cssText([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(155)]
        HRESULT get_cssText([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(156)]
        HRESULT put_cursor([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(157)]
        HRESULT get_cursor([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(158)]
        HRESULT put_clip([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(159)]
        HRESULT get_clip([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(160)]
        HRESULT put_filter([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(161)]
        HRESULT get_filter([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(162)]
        HRESULT put_tableLayout([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(163)]
        HRESULT get_tableLayout([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(164)]
        HRESULT put_borderCollapse([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(165)]
        HRESULT get_borderCollapse([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(166)]
        HRESULT put_direction([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(167)]
        HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(168)]
        HRESULT put_behavior([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(169)]
        HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(170)]
        HRESULT put_position([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(171)]
        HRESULT get_position([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(172)]
        HRESULT put_unicodeBidi([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(173)]
        HRESULT get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(174)]
        HRESULT put_bottom(VARIANT v);

        [VtblIndex(175)]
        HRESULT get_bottom(VARIANT* p);

        [VtblIndex(176)]
        HRESULT put_right(VARIANT v);

        [VtblIndex(177)]
        HRESULT get_right(VARIANT* p);

        [VtblIndex(178)]
        HRESULT put_imeMode([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(179)]
        HRESULT get_imeMode([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(180)]
        HRESULT put_rubyAlign([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(181)]
        HRESULT get_rubyAlign([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(182)]
        HRESULT put_rubyPosition([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(183)]
        HRESULT get_rubyPosition([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(184)]
        HRESULT put_rubyOverhang([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(185)]
        HRESULT get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(186)]
        HRESULT put_layoutGridChar(VARIANT v);

        [VtblIndex(187)]
        HRESULT get_layoutGridChar(VARIANT* p);

        [VtblIndex(188)]
        HRESULT put_layoutGridLine(VARIANT v);

        [VtblIndex(189)]
        HRESULT get_layoutGridLine(VARIANT* p);

        [VtblIndex(190)]
        HRESULT put_layoutGridMode([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(191)]
        HRESULT get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(192)]
        HRESULT put_layoutGridType([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(193)]
        HRESULT get_layoutGridType([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(194)]
        HRESULT put_layoutGrid([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(195)]
        HRESULT get_layoutGrid([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(196)]
        HRESULT put_textAutospace([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(197)]
        HRESULT get_textAutospace([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(198)]
        HRESULT put_wordBreak([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(199)]
        HRESULT get_wordBreak([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(200)]
        HRESULT put_lineBreak([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(201)]
        HRESULT get_lineBreak([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(202)]
        HRESULT put_textJustify([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(203)]
        HRESULT get_textJustify([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(204)]
        HRESULT put_textJustifyTrim([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(205)]
        HRESULT get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(206)]
        HRESULT put_textKashida(VARIANT v);

        [VtblIndex(207)]
        HRESULT get_textKashida(VARIANT* p);

        [VtblIndex(208)]
        HRESULT put_overflowX([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(209)]
        HRESULT get_overflowX([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(210)]
        HRESULT put_overflowY([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(211)]
        HRESULT get_overflowY([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(212)]
        HRESULT put_accelerator([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(213)]
        HRESULT get_accelerator([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(214)]
        HRESULT put_layoutFlow([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(215)]
        HRESULT get_layoutFlow([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(216)]
        HRESULT put_zoom(VARIANT v);

        [VtblIndex(217)]
        HRESULT get_zoom(VARIANT* p);

        [VtblIndex(218)]
        HRESULT put_wordWrap([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(219)]
        HRESULT get_wordWrap([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(220)]
        HRESULT put_textUnderlinePosition([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(221)]
        HRESULT get_textUnderlinePosition([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(222)]
        HRESULT put_scrollbarBaseColor(VARIANT v);

        [VtblIndex(223)]
        HRESULT get_scrollbarBaseColor(VARIANT* p);

        [VtblIndex(224)]
        HRESULT put_scrollbarFaceColor(VARIANT v);

        [VtblIndex(225)]
        HRESULT get_scrollbarFaceColor(VARIANT* p);

        [VtblIndex(226)]
        HRESULT put_scrollbar3dLightColor(VARIANT v);

        [VtblIndex(227)]
        HRESULT get_scrollbar3dLightColor(VARIANT* p);

        [VtblIndex(228)]
        HRESULT put_scrollbarShadowColor(VARIANT v);

        [VtblIndex(229)]
        HRESULT get_scrollbarShadowColor(VARIANT* p);

        [VtblIndex(230)]
        HRESULT put_scrollbarHighlightColor(VARIANT v);

        [VtblIndex(231)]
        HRESULT get_scrollbarHighlightColor(VARIANT* p);

        [VtblIndex(232)]
        HRESULT put_scrollbarDarkShadowColor(VARIANT v);

        [VtblIndex(233)]
        HRESULT get_scrollbarDarkShadowColor(VARIANT* p);

        [VtblIndex(234)]
        HRESULT put_scrollbarArrowColor(VARIANT v);

        [VtblIndex(235)]
        HRESULT get_scrollbarArrowColor(VARIANT* p);

        [VtblIndex(236)]
        HRESULT put_scrollbarTrackColor(VARIANT v);

        [VtblIndex(237)]
        HRESULT get_scrollbarTrackColor(VARIANT* p);

        [VtblIndex(238)]
        HRESULT put_writingMode([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(239)]
        HRESULT get_writingMode([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(240)]
        HRESULT put_textAlignLast([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(241)]
        HRESULT get_textAlignLast([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(242)]
        HRESULT put_textKashidaSpace(VARIANT v);

        [VtblIndex(243)]
        HRESULT get_textKashidaSpace(VARIANT* p);

        [VtblIndex(244)]
        HRESULT put_textOverflow([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(245)]
        HRESULT get_textOverflow([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(246)]
        HRESULT put_minHeight(VARIANT v);

        [VtblIndex(247)]
        HRESULT get_minHeight(VARIANT* p);

        [VtblIndex(248)]
        HRESULT put_msInterpolationMode([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(249)]
        HRESULT get_msInterpolationMode([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(250)]
        HRESULT put_maxHeight(VARIANT v);

        [VtblIndex(251)]
        HRESULT get_maxHeight(VARIANT* p);

        [VtblIndex(252)]
        HRESULT put_minWidth(VARIANT v);

        [VtblIndex(253)]
        HRESULT get_minWidth(VARIANT* p);

        [VtblIndex(254)]
        HRESULT put_maxWidth(VARIANT v);

        [VtblIndex(255)]
        HRESULT get_maxWidth(VARIANT* p);

        [VtblIndex(256)]
        HRESULT put_content([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(257)]
        HRESULT get_content([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(258)]
        HRESULT put_captionSide([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(259)]
        HRESULT get_captionSide([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(260)]
        HRESULT put_counterIncrement([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(261)]
        HRESULT get_counterIncrement([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(262)]
        HRESULT put_counterReset([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(263)]
        HRESULT get_counterReset([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(264)]
        HRESULT put_outline([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(265)]
        HRESULT get_outline([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(266)]
        HRESULT put_outlineWidth(VARIANT v);

        [VtblIndex(267)]
        HRESULT get_outlineWidth(VARIANT* p);

        [VtblIndex(268)]
        HRESULT put_outlineStyle([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(269)]
        HRESULT get_outlineStyle([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(270)]
        HRESULT put_outlineColor(VARIANT v);

        [VtblIndex(271)]
        HRESULT get_outlineColor(VARIANT* p);

        [VtblIndex(272)]
        HRESULT put_boxSizing([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(273)]
        HRESULT get_boxSizing([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(274)]
        HRESULT put_borderSpacing([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(275)]
        HRESULT get_borderSpacing([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(276)]
        HRESULT put_orphans(VARIANT v);

        [VtblIndex(277)]
        HRESULT get_orphans(VARIANT* p);

        [VtblIndex(278)]
        HRESULT put_widows(VARIANT v);

        [VtblIndex(279)]
        HRESULT get_widows(VARIANT* p);

        [VtblIndex(280)]
        HRESULT put_pageBreakInside([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(281)]
        HRESULT get_pageBreakInside([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(282)]
        HRESULT put_emptyCells([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(283)]
        HRESULT get_emptyCells([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(284)]
        HRESULT put_msBlockProgression([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(285)]
        HRESULT get_msBlockProgression([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(286)]
        HRESULT put_quotes([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(287)]
        HRESULT get_quotes([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(288)]
        HRESULT put_alignmentBaseline([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(289)]
        HRESULT get_alignmentBaseline([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(290)]
        HRESULT put_baselineShift(VARIANT v);

        [VtblIndex(291)]
        HRESULT get_baselineShift(VARIANT* p);

        [VtblIndex(292)]
        HRESULT put_dominantBaseline([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(293)]
        HRESULT get_dominantBaseline([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(294)]
        HRESULT put_fontSizeAdjust(VARIANT v);

        [VtblIndex(295)]
        HRESULT get_fontSizeAdjust(VARIANT* p);

        [VtblIndex(296)]
        HRESULT put_fontStretch([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(297)]
        HRESULT get_fontStretch([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(298)]
        HRESULT put_opacity(VARIANT v);

        [VtblIndex(299)]
        HRESULT get_opacity(VARIANT* p);

        [VtblIndex(300)]
        HRESULT put_clipPath([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(301)]
        HRESULT get_clipPath([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(302)]
        HRESULT put_clipRule([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(303)]
        HRESULT get_clipRule([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(304)]
        HRESULT put_fill([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(305)]
        HRESULT get_fill([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(306)]
        HRESULT put_fillOpacity(VARIANT v);

        [VtblIndex(307)]
        HRESULT get_fillOpacity(VARIANT* p);

        [VtblIndex(308)]
        HRESULT put_fillRule([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(309)]
        HRESULT get_fillRule([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(310)]
        HRESULT put_kerning(VARIANT v);

        [VtblIndex(311)]
        HRESULT get_kerning(VARIANT* p);

        [VtblIndex(312)]
        HRESULT put_marker([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(313)]
        HRESULT get_marker([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(314)]
        HRESULT put_markerEnd([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(315)]
        HRESULT get_markerEnd([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(316)]
        HRESULT put_markerMid([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(317)]
        HRESULT get_markerMid([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(318)]
        HRESULT put_markerStart([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(319)]
        HRESULT get_markerStart([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(320)]
        HRESULT put_mask([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(321)]
        HRESULT get_mask([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(322)]
        HRESULT put_pointerEvents([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(323)]
        HRESULT get_pointerEvents([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(324)]
        HRESULT put_stopColor(VARIANT v);

        [VtblIndex(325)]
        HRESULT get_stopColor(VARIANT* p);

        [VtblIndex(326)]
        HRESULT put_stopOpacity(VARIANT v);

        [VtblIndex(327)]
        HRESULT get_stopOpacity(VARIANT* p);

        [VtblIndex(328)]
        HRESULT put_stroke([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(329)]
        HRESULT get_stroke([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(330)]
        HRESULT put_strokeDasharray([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(331)]
        HRESULT get_strokeDasharray([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(332)]
        HRESULT put_strokeDashoffset(VARIANT v);

        [VtblIndex(333)]
        HRESULT get_strokeDashoffset(VARIANT* p);

        [VtblIndex(334)]
        HRESULT put_strokeLinecap([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(335)]
        HRESULT get_strokeLinecap([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(336)]
        HRESULT put_strokeLinejoin([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(337)]
        HRESULT get_strokeLinejoin([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(338)]
        HRESULT put_strokeMiterlimit(VARIANT v);

        [VtblIndex(339)]
        HRESULT get_strokeMiterlimit(VARIANT* p);

        [VtblIndex(340)]
        HRESULT put_strokeOpacity(VARIANT v);

        [VtblIndex(341)]
        HRESULT get_strokeOpacity(VARIANT* p);

        [VtblIndex(342)]
        HRESULT put_strokeWidth(VARIANT v);

        [VtblIndex(343)]
        HRESULT get_strokeWidth(VARIANT* p);

        [VtblIndex(344)]
        HRESULT put_textAnchor([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(345)]
        HRESULT get_textAnchor([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(346)]
        HRESULT put_glyphOrientationHorizontal(VARIANT v);

        [VtblIndex(347)]
        HRESULT get_glyphOrientationHorizontal(VARIANT* p);

        [VtblIndex(348)]
        HRESULT put_glyphOrientationVertical(VARIANT v);

        [VtblIndex(349)]
        HRESULT get_glyphOrientationVertical(VARIANT* p);

        [VtblIndex(350)]
        HRESULT put_borderRadius([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(351)]
        HRESULT get_borderRadius([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(352)]
        HRESULT put_borderTopLeftRadius([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(353)]
        HRESULT get_borderTopLeftRadius([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(354)]
        HRESULT put_borderTopRightRadius([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(355)]
        HRESULT get_borderTopRightRadius([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(356)]
        HRESULT put_borderBottomRightRadius([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(357)]
        HRESULT get_borderBottomRightRadius([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(358)]
        HRESULT put_borderBottomLeftRadius([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(359)]
        HRESULT get_borderBottomLeftRadius([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(360)]
        HRESULT put_clipTop(VARIANT v);

        [VtblIndex(361)]
        HRESULT get_clipTop(VARIANT* p);

        [VtblIndex(362)]
        HRESULT put_clipRight(VARIANT v);

        [VtblIndex(363)]
        HRESULT get_clipRight(VARIANT* p);

        [VtblIndex(364)]
        HRESULT get_clipBottom(VARIANT* p);

        [VtblIndex(365)]
        HRESULT put_clipLeft(VARIANT v);

        [VtblIndex(366)]
        HRESULT get_clipLeft(VARIANT* p);

        [VtblIndex(367)]
        HRESULT put_cssFloat([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(368)]
        HRESULT get_cssFloat([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(369)]
        HRESULT put_backgroundClip([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(370)]
        HRESULT get_backgroundClip([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(371)]
        HRESULT put_backgroundOrigin([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(372)]
        HRESULT get_backgroundOrigin([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(373)]
        HRESULT put_backgroundSize([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(374)]
        HRESULT get_backgroundSize([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(375)]
        HRESULT put_boxShadow([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(376)]
        HRESULT get_boxShadow([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(377)]
        HRESULT put_msTransform([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(378)]
        HRESULT get_msTransform([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(379)]
        HRESULT put_msTransformOrigin([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(380)]
        HRESULT get_msTransformOrigin([NativeTypeName("BSTR *")] ushort** p);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_parentRule;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> getPropertyValue;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> getPropertyPriority;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> removeProperty;

        [NativeTypeName("HRESULT (BSTR, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, VARIANT*, int> setProperty;

        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> item;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fontFamily;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fontFamily;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fontStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fontStyle;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fontVariant;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fontVariant;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fontWeight;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fontWeight;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_fontSize;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_fontSize;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_font;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_font;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_color;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_color;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_background;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_background;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_backgroundColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_backgroundColor;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundImage;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundImage;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundRepeat;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundRepeat;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundAttachment;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundAttachment;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundPosition;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundPosition;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_backgroundPositionX;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_backgroundPositionX;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_backgroundPositionY;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_backgroundPositionY;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_wordSpacing;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_wordSpacing;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_letterSpacing;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_letterSpacing;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textDecoration;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textDecoration;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_verticalAlign;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_verticalAlign;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textTransform;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textTransform;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textAlign;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_textIndent;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_textIndent;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_lineHeight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_lineHeight;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_marginTop;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_marginTop;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_marginRight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_marginRight;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_marginBottom;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_marginBottom;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_marginLeft;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_marginLeft;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_margin;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_margin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_paddingTop;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_paddingTop;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_paddingRight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_paddingRight;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_paddingBottom;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_paddingBottom;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_paddingLeft;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_paddingLeft;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_padding;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_padding;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_border;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_border;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderTop;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderTop;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderRight;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderRight;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderBottom;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderBottom;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderLeft;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderLeft;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderColor;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderTopColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderTopColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderRightColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderRightColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderBottomColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderBottomColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderLeftColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderLeftColor;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderWidth;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderWidth;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderTopWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderTopWidth;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderRightWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderRightWidth;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderBottomWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderBottomWidth;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderLeftWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderLeftWidth;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderStyle;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderTopStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderTopStyle;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderRightStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderRightStyle;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderBottomStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderBottomStyle;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderLeftStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderLeftStyle;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_width;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_width;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_height;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_height;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_styleFloat;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_styleFloat;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_clear;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_clear;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_display;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_display;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_visibility;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_visibility;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_listStyleType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_listStyleType;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_listStylePosition;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_listStylePosition;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_listStyleImage;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_listStyleImage;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_listStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_listStyle;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_whiteSpace;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_whiteSpace;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_top;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_top;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_left;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_left;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_zIndex;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_zIndex;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_overflow;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_overflow;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_pageBreakBefore;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pageBreakBefore;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_pageBreakAfter;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pageBreakAfter;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_cssText;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_cssText;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_cursor;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_cursor;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_clip;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_clip;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_filter;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_filter;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_tableLayout;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_tableLayout;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderCollapse;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderCollapse;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_direction;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_direction;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_behavior;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_behavior;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_position;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_position;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_unicodeBidi;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_unicodeBidi;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bottom;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bottom;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_right;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_right;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_imeMode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_imeMode;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rubyAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rubyAlign;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rubyPosition;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rubyPosition;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rubyOverhang;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rubyOverhang;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_layoutGridChar;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_layoutGridChar;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_layoutGridLine;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_layoutGridLine;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_layoutGridMode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_layoutGridMode;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_layoutGridType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_layoutGridType;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_layoutGrid;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_layoutGrid;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textAutospace;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textAutospace;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_wordBreak;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_wordBreak;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_lineBreak;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_lineBreak;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textJustify;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textJustify;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textJustifyTrim;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textJustifyTrim;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_textKashida;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_textKashida;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_overflowX;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_overflowX;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_overflowY;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_overflowY;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_accelerator;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_accelerator;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_layoutFlow;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_layoutFlow;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_zoom;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_zoom;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_wordWrap;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_wordWrap;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textUnderlinePosition;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textUnderlinePosition;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_scrollbarBaseColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarBaseColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_scrollbarFaceColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarFaceColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_scrollbar3dLightColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbar3dLightColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_scrollbarShadowColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarShadowColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_scrollbarHighlightColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarHighlightColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_scrollbarDarkShadowColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarDarkShadowColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_scrollbarArrowColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarArrowColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_scrollbarTrackColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_scrollbarTrackColor;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_writingMode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_writingMode;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textAlignLast;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textAlignLast;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_textKashidaSpace;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_textKashidaSpace;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textOverflow;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textOverflow;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_minHeight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_minHeight;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msInterpolationMode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msInterpolationMode;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_maxHeight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_maxHeight;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_minWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_minWidth;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_maxWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_maxWidth;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_content;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_content;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_captionSide;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_captionSide;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_counterIncrement;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_counterIncrement;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_counterReset;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_counterReset;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_outline;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_outline;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_outlineWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_outlineWidth;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_outlineStyle;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_outlineStyle;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_outlineColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_outlineColor;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_boxSizing;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_boxSizing;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderSpacing;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderSpacing;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_orphans;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_orphans;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_widows;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_widows;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_pageBreakInside;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pageBreakInside;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_emptyCells;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_emptyCells;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msBlockProgression;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msBlockProgression;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_quotes;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_quotes;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_alignmentBaseline;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_alignmentBaseline;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_baselineShift;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_baselineShift;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_dominantBaseline;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_dominantBaseline;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_fontSizeAdjust;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_fontSizeAdjust;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fontStretch;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fontStretch;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_opacity;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_opacity;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_clipPath;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_clipPath;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_clipRule;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_clipRule;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fill;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fill;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_fillOpacity;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_fillOpacity;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fillRule;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fillRule;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_kerning;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_kerning;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_marker;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_marker;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_markerEnd;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_markerEnd;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_markerMid;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_markerMid;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_markerStart;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_markerStart;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_mask;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_mask;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_pointerEvents;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pointerEvents;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_stopColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_stopColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_stopOpacity;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_stopOpacity;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_stroke;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_stroke;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_strokeDasharray;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_strokeDasharray;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_strokeDashoffset;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_strokeDashoffset;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_strokeLinecap;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_strokeLinecap;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_strokeLinejoin;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_strokeLinejoin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_strokeMiterlimit;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_strokeMiterlimit;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_strokeOpacity;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_strokeOpacity;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_strokeWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_strokeWidth;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textAnchor;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textAnchor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_glyphOrientationHorizontal;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_glyphOrientationHorizontal;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_glyphOrientationVertical;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_glyphOrientationVertical;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderRadius;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderRadius;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderTopLeftRadius;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderTopLeftRadius;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderTopRightRadius;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderTopRightRadius;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderBottomRightRadius;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderBottomRightRadius;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderBottomLeftRadius;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderBottomLeftRadius;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_clipTop;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_clipTop;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_clipRight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_clipRight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_clipBottom;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_clipLeft;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_clipLeft;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_cssFloat;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_cssFloat;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundClip;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundClip;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundOrigin;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundOrigin;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundSize;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundSize;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_boxShadow;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_boxShadow;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msTransform;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msTransform;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msTransformOrigin;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msTransformOrigin;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLCSSStyleDeclaration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLCSSStyleDeclaration(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLCSSStyleDeclaration"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLCSSStyleDeclaration(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLCSSStyleDeclaration(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLCSSStyleDeclaration"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLCSSStyleDeclaration"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLCSSStyleDeclaration value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLCSSStyleDeclaration"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLCSSStyleDeclaration(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLCSSStyleDeclaration(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLCSSStyleDeclaration"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLCSSStyleDeclaration"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLCSSStyleDeclaration value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
