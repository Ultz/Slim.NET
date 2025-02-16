// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct DISPATCHER_CONTEXT_OTHER
{
    [NativeTypeName("DWORD64")]
    public ulong ControlPc;

    [NativeTypeName("DWORD64")]
    public ulong ImageBase;

    [NativeTypeName("PRUNTIME_FUNCTION")]
    public void* FunctionEntry;

    [NativeTypeName("DWORD64")]
    public ulong EstablisherFrame;

    [NativeTypeName("DWORD64")]
    public ulong TargetIp;

    [NativeTypeName("PCONTEXT")]
    public void* ContextRecord;

    [NativeTypeName("PEXCEPTION_ROUTINE")]
    public delegate* unmanaged<EXCEPTION_RECORD*, void*, void*, void*, int> LanguageHandler;

    [NativeTypeName("PVOID")]
    public void* HandlerData;

    [NativeTypeName("struct _UNWIND_HISTORY_TABLE *")]
    public UNWIND_HISTORY_TABLE* HistoryTable;

    [NativeTypeName("DWORD")]
    public uint ScopeIndex;

    [NativeTypeName("DWORD")]
    public uint Fill0;
}
