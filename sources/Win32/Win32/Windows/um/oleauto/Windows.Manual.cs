// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
// VarI4FromUI8 and VarI4FromI8 show up twice in OleAuto.h.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.VarI4FromI8"]/*'/>

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromI8(
        [NativeTypeName("LONG64")] long i64In,
        [NativeTypeName("LONG *")] int* plOut
    );

    [Transformed]
    [NativeFunction("oleaut32", EntryPoint = "VarI4FromI8")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT VarI4FromI8(
        [NativeTypeName("LONG64")] long i64In,
        [NativeTypeName("LONG *")] Ref<int> plOut
    )
    {
        fixed (int* __dsl_plOut = plOut)
        {
            return (HRESULT)VarI4FromI8(i64In, __dsl_plOut);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.VarI4FromUI8"]/*'/>

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        [NativeTypeName("LONG *")] int* plOut
    );

    [Transformed]
    [NativeFunction("oleaut32", EntryPoint = "VarI4FromUI8")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HRESULT VarI4FromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        [NativeTypeName("LONG *")] Ref<int> plOut
    )
    {
        fixed (int* __dsl_plOut = plOut)
        {
            return (HRESULT)VarI4FromUI8(ui64In, __dsl_plOut);
        }
    }
}
