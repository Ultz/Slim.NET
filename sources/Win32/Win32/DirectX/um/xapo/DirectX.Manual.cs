// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using static Silk.NET.Win32.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr XAPOAlloc(nuint size) => (void*)XAPOAllocRaw(size);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XAPOAlloc"]/*'/>

    public static void* XAPOAllocRaw(nuint size) => CoTaskMemAllocRaw(size);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XAPOFree"]/*'/>

    public static void XAPOFree(void* p) => CoTaskMemFree(p);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void XAPOFree(Ref p)
    {
        fixed (void* __dsl_p = p)
        {
            XAPOFree(__dsl_p);
        }
    }
}
