// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLOBAL GlobalAlloc(uint uFlags, [NativeTypeName("SIZE_T")] nuint dwBytes);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLOBAL GlobalReAlloc(
        HGLOBAL hMem,
        [NativeTypeName("SIZE_T")] nuint dwBytes,
        uint uFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint GlobalSize(HGLOBAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GlobalUnlock(HGLOBAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* GlobalLock(HGLOBAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GlobalFlags(HGLOBAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLOBAL GlobalHandle([NativeTypeName("LPCVOID")] void* pMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLOBAL GlobalFree(HGLOBAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint GlobalCompact([NativeTypeName("DWORD")] uint dwMinFree);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GlobalFix(HGLOBAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GlobalUnfix(HGLOBAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* GlobalWire(HGLOBAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GlobalUnWire(HGLOBAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GlobalMemoryStatus(
        [NativeTypeName("LPMEMORYSTATUS")] MEMORYSTATUS* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HLOCAL LocalAlloc(uint uFlags, [NativeTypeName("SIZE_T")] nuint uBytes);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HLOCAL LocalReAlloc(
        HLOCAL hMem,
        [NativeTypeName("SIZE_T")] nuint uBytes,
        uint uFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* LocalLock(HLOCAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HLOCAL LocalHandle([NativeTypeName("LPCVOID")] void* pMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LocalUnlock(HLOCAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint LocalSize(HLOCAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint LocalFlags(HLOCAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HLOCAL LocalFree(HLOCAL hMem);

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint LocalShrink(HLOCAL hMem, uint cbNewSize);

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint LocalCompact(uint uMinFree);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetBinaryTypeA(
        [NativeTypeName("LPCSTR")] sbyte* lpApplicationName,
        [NativeTypeName("LPDWORD")] uint* lpBinaryType
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetBinaryTypeW(
        [NativeTypeName("LPCWSTR")] ushort* lpApplicationName,
        [NativeTypeName("LPDWORD")] uint* lpBinaryType
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetShortPathNameA(
        [NativeTypeName("LPCSTR")] sbyte* lpszLongPath,
        [NativeTypeName("LPSTR")] sbyte* lpszShortPath,
        [NativeTypeName("DWORD")] uint cchBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLongPathNameTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpszShortPath,
        [NativeTypeName("LPSTR")] sbyte* lpszLongPath,
        [NativeTypeName("DWORD")] uint cchBuffer,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLongPathNameTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpszShortPath,
        [NativeTypeName("LPWSTR")] ushort* lpszLongPath,
        [NativeTypeName("DWORD")] uint cchBuffer,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessAffinityMask(
        HANDLE hProcess,
        [NativeTypeName("PDWORD_PTR")] nuint* lpProcessAffinityMask,
        [NativeTypeName("PDWORD_PTR")] nuint* lpSystemAffinityMask
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessAffinityMask(
        HANDLE hProcess,
        [NativeTypeName("DWORD_PTR")] nuint dwProcessAffinityMask
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessIoCounters(
        HANDLE hProcess,
        [NativeTypeName("PIO_COUNTERS")] IO_COUNTERS* lpIoCounters
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void FatalExit(int ExitCode);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetEnvironmentStringsA(
        [NativeTypeName("LPCH")] sbyte* NewEnvironment
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SwitchToFiber([NativeTypeName("LPVOID")] void* lpFiber);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void DeleteFiber([NativeTypeName("LPVOID")] void* lpFiber);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ConvertFiberToThread();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* CreateFiberEx(
        [NativeTypeName("SIZE_T")] nuint dwStackCommitSize,
        [NativeTypeName("SIZE_T")] nuint dwStackReserveSize,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPFIBER_START_ROUTINE")] delegate* unmanaged<void*, void> lpStartAddress,
        [NativeTypeName("LPVOID")] void* lpParameter
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* ConvertThreadToFiberEx(
        [NativeTypeName("LPVOID")] void* lpParameter,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* CreateFiber(
        [NativeTypeName("SIZE_T")] nuint dwStackSize,
        [NativeTypeName("LPFIBER_START_ROUTINE")] delegate* unmanaged<void*, void> lpStartAddress,
        [NativeTypeName("LPVOID")] void* lpParameter
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* ConvertThreadToFiber([NativeTypeName("LPVOID")] void* lpParameter);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateUmsCompletionList(
        [NativeTypeName("PUMS_COMPLETION_LIST *")] void** UmsCompletionList
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DequeueUmsCompletionListItems(
        [NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList,
        [NativeTypeName("DWORD")] uint WaitTimeOut,
        [NativeTypeName("PUMS_CONTEXT *")] void** UmsThreadList
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUmsCompletionListEvent(
        [NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList,
        [NativeTypeName("PHANDLE")] HANDLE* UmsCompletionEvent
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ExecuteUmsThread([NativeTypeName("PUMS_CONTEXT")] void* UmsThread);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UmsThreadYield([NativeTypeName("PVOID")] void* SchedulerParam);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteUmsCompletionList(
        [NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PUMS_CONTEXT")]
    public static extern void* GetCurrentUmsThread();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("PUMS_CONTEXT")]
    public static extern void* GetNextUmsListItem(
        [NativeTypeName("PUMS_CONTEXT")] void* UmsContext
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryUmsThreadInformation(
        [NativeTypeName("PUMS_CONTEXT")] void* UmsThread,
        UMS_THREAD_INFO_CLASS UmsThreadInfoClass,
        [NativeTypeName("PVOID")] void* UmsThreadInformation,
        [NativeTypeName("ULONG")] uint UmsThreadInformationLength,
        [NativeTypeName("PULONG")] uint* ReturnLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetUmsThreadInformation(
        [NativeTypeName("PUMS_CONTEXT")] void* UmsThread,
        UMS_THREAD_INFO_CLASS UmsThreadInfoClass,
        [NativeTypeName("PVOID")] void* UmsThreadInformation,
        [NativeTypeName("ULONG")] uint UmsThreadInformationLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteUmsThreadContext(
        [NativeTypeName("PUMS_CONTEXT")] void* UmsThread
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateUmsThreadContext(
        [NativeTypeName("PUMS_CONTEXT *")] void** lpUmsThread
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnterUmsSchedulingMode(
        [NativeTypeName("PUMS_SCHEDULER_STARTUP_INFO")]
            UMS_SCHEDULER_STARTUP_INFO* SchedulerStartupInfo
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetUmsSystemThreadInformation(
        HANDLE ThreadHandle,
        [NativeTypeName("PUMS_SYSTEM_THREAD_INFORMATION")]
            UMS_SYSTEM_THREAD_INFORMATION* SystemThreadInfo
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD_PTR")]
    public static extern nuint SetThreadAffinityMask(
        HANDLE hThread,
        [NativeTypeName("DWORD_PTR")] nuint dwThreadAffinityMask
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetProcessDEPPolicy([NativeTypeName("DWORD")] uint dwFlags);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetProcessDEPPolicy(
        HANDLE hProcess,
        [NativeTypeName("LPDWORD")] uint* lpFlags,
        [NativeTypeName("PBOOL")] BOOL* lpPermanent
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL RequestWakeupLatency(LATENCY_TIME latency);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsSystemResumeAutomatic();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetThreadSelectorEntry(
        HANDLE hThread,
        [NativeTypeName("DWORD")] uint dwSelector,
        [NativeTypeName("LPLDT_ENTRY")] void* lpSelectorEntry
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("EXECUTION_STATE")]
    public static extern uint SetThreadExecutionState(
        [NativeTypeName("EXECUTION_STATE")] uint esFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE PowerCreateRequest(
        [NativeTypeName("PREASON_CONTEXT")] REASON_CONTEXT* Context
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PowerSetRequest(HANDLE PowerRequest, POWER_REQUEST_TYPE RequestType);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PowerClearRequest(
        HANDLE PowerRequest,
        POWER_REQUEST_TYPE RequestType
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileCompletionNotificationModes(
        HANDLE FileHandle,
        [NativeTypeName("UCHAR")] byte Flags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Wow64GetThreadSelectorEntry(
        HANDLE hThread,
        [NativeTypeName("DWORD")] uint dwSelector,
        [NativeTypeName("PWOW64_LDT_ENTRY")] WOW64_LDT_ENTRY* lpSelectorEntry
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DebugSetProcessKillOnExit(BOOL KillOnExit);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DebugBreakProcess(HANDLE Process);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PulseEvent(HANDLE hEvent);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalDeleteAtom([NativeTypeName("ATOM")] ushort nAtom);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL InitAtomTable([NativeTypeName("DWORD")] uint nSize);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort DeleteAtom([NativeTypeName("ATOM")] ushort nAtom);

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint SetHandleCount(uint uNumber);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL RequestDeviceWakeup(HANDLE hDevice);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL CancelDeviceWakeupRequest(HANDLE hDevice);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetDevicePowerState(HANDLE hDevice, BOOL* pfOn);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetMessageWaitingIndicator(
        HANDLE hMsgIndicator,
        [NativeTypeName("ULONG")] uint ulMsgCount
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileShortNameA(
        HANDLE hFile,
        [NativeTypeName("LPCSTR")] sbyte* lpShortName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileShortNameW(
        HANDLE hFile,
        [NativeTypeName("LPCWSTR")] ushort* lpShortName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint LoadModule(
        [NativeTypeName("LPCSTR")] sbyte* lpModuleName,
        [NativeTypeName("LPVOID")] void* lpParameterBlock
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint WinExec([NativeTypeName("LPCSTR")] sbyte* lpCmdLine, uint uCmdShow);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ClearCommBreak(HANDLE hFile);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ClearCommError(
        HANDLE hFile,
        [NativeTypeName("LPDWORD")] uint* lpErrors,
        [NativeTypeName("LPCOMSTAT")] COMSTAT* lpStat
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetupComm(
        HANDLE hFile,
        [NativeTypeName("DWORD")] uint dwInQueue,
        [NativeTypeName("DWORD")] uint dwOutQueue
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EscapeCommFunction(
        HANDLE hFile,
        [NativeTypeName("DWORD")] uint dwFunc
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommConfig(
        HANDLE hCommDev,
        [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC,
        [NativeTypeName("LPDWORD")] uint* lpdwSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommMask(
        HANDLE hFile,
        [NativeTypeName("LPDWORD")] uint* lpEvtMask
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommProperties(
        HANDLE hFile,
        [NativeTypeName("LPCOMMPROP")] COMMPROP* lpCommProp
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommModemStatus(
        HANDLE hFile,
        [NativeTypeName("LPDWORD")] uint* lpModemStat
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommState(HANDLE hFile, [NativeTypeName("LPDCB")] DCB* lpDCB);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCommTimeouts(
        HANDLE hFile,
        [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PurgeComm(HANDLE hFile, [NativeTypeName("DWORD")] uint dwFlags);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCommBreak(HANDLE hFile);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCommConfig(
        HANDLE hCommDev,
        [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC,
        [NativeTypeName("DWORD")] uint dwSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCommMask(HANDLE hFile, [NativeTypeName("DWORD")] uint dwEvtMask);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCommState(HANDLE hFile, [NativeTypeName("LPDCB")] DCB* lpDCB);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetCommTimeouts(
        HANDLE hFile,
        [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL TransmitCommChar(HANDLE hFile, [NativeTypeName("char")] sbyte cChar);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WaitCommEvent(
        HANDLE hFile,
        [NativeTypeName("LPDWORD")] uint* lpEvtMask,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.16299.0")]
    public static extern HANDLE OpenCommPort(
        [NativeTypeName("ULONG")] uint uPortNumber,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("DWORD")] uint dwFlagsAndAttributes
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern uint GetCommPorts(
        [NativeTypeName("PULONG")] uint* lpPortNumbers,
        [NativeTypeName("ULONG")] uint uPortNumbersCount,
        [NativeTypeName("PULONG")] uint* puPortNumbersFound
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetTapePosition(
        HANDLE hDevice,
        [NativeTypeName("DWORD")] uint dwPositionMethod,
        [NativeTypeName("DWORD")] uint dwPartition,
        [NativeTypeName("DWORD")] uint dwOffsetLow,
        [NativeTypeName("DWORD")] uint dwOffsetHigh,
        BOOL bImmediate
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTapePosition(
        HANDLE hDevice,
        [NativeTypeName("DWORD")] uint dwPositionType,
        [NativeTypeName("LPDWORD")] uint* lpdwPartition,
        [NativeTypeName("LPDWORD")] uint* lpdwOffsetLow,
        [NativeTypeName("LPDWORD")] uint* lpdwOffsetHigh
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PrepareTape(
        HANDLE hDevice,
        [NativeTypeName("DWORD")] uint dwOperation,
        BOOL bImmediate
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint EraseTape(
        HANDLE hDevice,
        [NativeTypeName("DWORD")] uint dwEraseType,
        BOOL bImmediate
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CreateTapePartition(
        HANDLE hDevice,
        [NativeTypeName("DWORD")] uint dwPartitionMethod,
        [NativeTypeName("DWORD")] uint dwCount,
        [NativeTypeName("DWORD")] uint dwSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WriteTapemark(
        HANDLE hDevice,
        [NativeTypeName("DWORD")] uint dwTapemarkType,
        [NativeTypeName("DWORD")] uint dwTapemarkCount,
        BOOL bImmediate
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTapeStatus(HANDLE hDevice);

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTapeParameters(
        HANDLE hDevice,
        [NativeTypeName("DWORD")] uint dwOperation,
        [NativeTypeName("LPDWORD")] uint* lpdwSize,
        [NativeTypeName("LPVOID")] void* lpTapeInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetTapeParameters(
        HANDLE hDevice,
        [NativeTypeName("DWORD")] uint dwOperation,
        [NativeTypeName("LPVOID")] void* lpTapeInformation
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern DEP_SYSTEM_POLICY_TYPE GetSystemDEPPolicy();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSystemRegistryQuota(
        [NativeTypeName("PDWORD")] uint* pdwQuotaAllowed,
        [NativeTypeName("PDWORD")] uint* pdwQuotaUsed
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FileTimeToDosDateTime(
        [NativeTypeName("const FILETIME *")] FILETIME* lpFileTime,
        [NativeTypeName("LPWORD")] ushort* lpFatDate,
        [NativeTypeName("LPWORD")] ushort* lpFatTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DosDateTimeToFileTime(
        [NativeTypeName("WORD")] ushort wFatDate,
        [NativeTypeName("WORD")] ushort wFatTime,
        [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint FormatMessageA(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCVOID")] void* lpSource,
        [NativeTypeName("DWORD")] uint dwMessageId,
        [NativeTypeName("DWORD")] uint dwLanguageId,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("va_list *")] sbyte** Arguments
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint FormatMessageW(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCVOID")] void* lpSource,
        [NativeTypeName("DWORD")] uint dwMessageId,
        [NativeTypeName("DWORD")] uint dwLanguageId,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("va_list *")] sbyte** Arguments
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateMailslotA(
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("DWORD")] uint nMaxMessageSize,
        [NativeTypeName("DWORD")] uint lReadTimeout,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateMailslotW(
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("DWORD")] uint nMaxMessageSize,
        [NativeTypeName("DWORD")] uint lReadTimeout,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetMailslotInfo(
        HANDLE hMailslot,
        [NativeTypeName("LPDWORD")] uint* lpMaxMessageSize,
        [NativeTypeName("LPDWORD")] uint* lpNextSize,
        [NativeTypeName("LPDWORD")] uint* lpMessageCount,
        [NativeTypeName("LPDWORD")] uint* lpReadTimeout
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetMailslotInfo(
        HANDLE hMailslot,
        [NativeTypeName("DWORD")] uint lReadTimeout
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EncryptFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EncryptFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DecryptFileA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("DWORD")] uint dwReserved
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DecryptFileW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("DWORD")] uint dwReserved
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FileEncryptionStatusA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("LPDWORD")] uint* lpStatus
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FileEncryptionStatusW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("LPDWORD")] uint* lpStatus
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint OpenEncryptedFileRawA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("ULONG")] uint ulFlags,
        [NativeTypeName("PVOID *")] void** pvContext
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint OpenEncryptedFileRawW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("ULONG")] uint ulFlags,
        [NativeTypeName("PVOID *")] void** pvContext
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ReadEncryptedFileRaw(
        [NativeTypeName("PFE_EXPORT_FUNC")]
            delegate* unmanaged<byte*, void*, uint, uint> pfExportCallback,
        [NativeTypeName("PVOID")] void* pvCallbackContext,
        [NativeTypeName("PVOID")] void* pvContext
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WriteEncryptedFileRaw(
        [NativeTypeName("PFE_IMPORT_FUNC")]
            delegate* unmanaged<byte*, void*, uint*, uint> pfImportCallback,
        [NativeTypeName("PVOID")] void* pvCallbackContext,
        [NativeTypeName("PVOID")] void* pvContext
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern void CloseEncryptedFileRaw([NativeTypeName("PVOID")] void* pvContext);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrcmpA(
        [NativeTypeName("LPCSTR")] sbyte* lpString1,
        [NativeTypeName("LPCSTR")] sbyte* lpString2
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrcmpW(
        [NativeTypeName("LPCWSTR")] ushort* lpString1,
        [NativeTypeName("LPCWSTR")] ushort* lpString2
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrcmpiA(
        [NativeTypeName("LPCSTR")] sbyte* lpString1,
        [NativeTypeName("LPCSTR")] sbyte* lpString2
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrcmpiW(
        [NativeTypeName("LPCWSTR")] ushort* lpString1,
        [NativeTypeName("LPCWSTR")] ushort* lpString2
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* lstrcpynA(
        [NativeTypeName("LPSTR")] sbyte* lpString1,
        [NativeTypeName("LPCSTR")] sbyte* lpString2,
        int iMaxLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* lstrcpynW(
        [NativeTypeName("LPWSTR")] ushort* lpString1,
        [NativeTypeName("LPCWSTR")] ushort* lpString2,
        int iMaxLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* lstrcpyA(
        [NativeTypeName("LPSTR")] sbyte* lpString1,
        [NativeTypeName("LPCSTR")] sbyte* lpString2
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* lstrcpyW(
        [NativeTypeName("LPWSTR")] ushort* lpString1,
        [NativeTypeName("LPCWSTR")] ushort* lpString2
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* lstrcatA(
        [NativeTypeName("LPSTR")] sbyte* lpString1,
        [NativeTypeName("LPCSTR")] sbyte* lpString2
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* lstrcatW(
        [NativeTypeName("LPWSTR")] ushort* lpString1,
        [NativeTypeName("LPCWSTR")] ushort* lpString2
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrlenA([NativeTypeName("LPCSTR")] sbyte* lpString);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern int lstrlenW([NativeTypeName("LPCWSTR")] ushort* lpString);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("HFILE")]
    public static extern int OpenFile(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("LPOFSTRUCT")] OFSTRUCT* lpReOpenBuff,
        uint uStyle
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("HFILE")]
    public static extern int _lopen([NativeTypeName("LPCSTR")] sbyte* lpPathName, int iReadWrite);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("HFILE")]
    public static extern int _lcreat([NativeTypeName("LPCSTR")] sbyte* lpPathName, int iAttribute);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint _lread(
        [NativeTypeName("HFILE")] int hFile,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        uint uBytes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint _lwrite(
        [NativeTypeName("HFILE")] int hFile,
        [NativeTypeName("LPCCH")] sbyte* lpBuffer,
        uint uBytes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("HFILE")]
    public static extern int _lclose([NativeTypeName("HFILE")] int hFile);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LONG")]
    public static extern int _llseek(
        [NativeTypeName("HFILE")] int hFile,
        [NativeTypeName("LONG")] int lOffset,
        int iOrigin
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL IsTextUnicode(
        [NativeTypeName("const void *")] void* lpv,
        int iSize,
        [NativeTypeName("LPINT")] int* lpiResult
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BackupRead(
        HANDLE hFile,
        [NativeTypeName("LPBYTE")] byte* lpBuffer,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToRead,
        [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead,
        BOOL bAbort,
        BOOL bProcessSecurity,
        [NativeTypeName("LPVOID *")] void** lpContext
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BackupSeek(
        HANDLE hFile,
        [NativeTypeName("DWORD")] uint dwLowBytesToSeek,
        [NativeTypeName("DWORD")] uint dwHighBytesToSeek,
        [NativeTypeName("LPDWORD")] uint* lpdwLowByteSeeked,
        [NativeTypeName("LPDWORD")] uint* lpdwHighByteSeeked,
        [NativeTypeName("LPVOID *")] void** lpContext
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BackupWrite(
        HANDLE hFile,
        [NativeTypeName("LPBYTE")] byte* lpBuffer,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite,
        [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten,
        BOOL bAbort,
        BOOL bProcessSecurity,
        [NativeTypeName("LPVOID *")] void** lpContext
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE OpenMutexA(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        BOOL bInheritHandle,
        [NativeTypeName("LPCSTR")] sbyte* lpName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateSemaphoreA(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes,
        [NativeTypeName("LONG")] int lInitialCount,
        [NativeTypeName("LONG")] int lMaximumCount,
        [NativeTypeName("LPCSTR")] sbyte* lpName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE OpenSemaphoreA(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        BOOL bInheritHandle,
        [NativeTypeName("LPCSTR")] sbyte* lpName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE CreateWaitableTimerA(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes,
        BOOL bManualReset,
        [NativeTypeName("LPCSTR")] sbyte* lpTimerName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE OpenWaitableTimerA(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        BOOL bInheritHandle,
        [NativeTypeName("LPCSTR")] sbyte* lpTimerName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateSemaphoreExA(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes,
        [NativeTypeName("LONG")] int lInitialCount,
        [NativeTypeName("LONG")] int lMaximumCount,
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwDesiredAccess
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE CreateWaitableTimerExA(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes,
        [NativeTypeName("LPCSTR")] sbyte* lpTimerName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwDesiredAccess
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileMappingA(
        HANDLE hFile,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes,
        [NativeTypeName("DWORD")] uint flProtect,
        [NativeTypeName("DWORD")] uint dwMaximumSizeHigh,
        [NativeTypeName("DWORD")] uint dwMaximumSizeLow,
        [NativeTypeName("LPCSTR")] sbyte* lpName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileMappingNumaA(
        HANDLE hFile,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes,
        [NativeTypeName("DWORD")] uint flProtect,
        [NativeTypeName("DWORD")] uint dwMaximumSizeHigh,
        [NativeTypeName("DWORD")] uint dwMaximumSizeLow,
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("DWORD")] uint nndPreferred
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenFileMappingA(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        BOOL bInheritHandle,
        [NativeTypeName("LPCSTR")] sbyte* lpName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLogicalDriveStringsA(
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern HMODULE LoadPackagedLibrary(
        [NativeTypeName("LPCWSTR")] ushort* lpwLibFileName,
        [NativeTypeName("DWORD")] uint Reserved
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryFullProcessImageNameA(
        HANDLE hProcess,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPSTR")] sbyte* lpExeName,
        [NativeTypeName("PDWORD")] uint* lpdwSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryFullProcessImageNameW(
        HANDLE hProcess,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPWSTR")] ushort* lpExeName,
        [NativeTypeName("PDWORD")] uint* lpdwSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void GetStartupInfoA(
        [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFirmwareEnvironmentVariableA(
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("LPCSTR")] sbyte* lpGuid,
        [NativeTypeName("PVOID")] void* pBuffer,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFirmwareEnvironmentVariableW(
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("LPCWSTR")] ushort* lpGuid,
        [NativeTypeName("PVOID")] void* pBuffer,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint GetFirmwareEnvironmentVariableExA(
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("LPCSTR")] sbyte* lpGuid,
        [NativeTypeName("PVOID")] void* pBuffer,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("PDWORD")] uint* pdwAttribubutes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint GetFirmwareEnvironmentVariableExW(
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("LPCWSTR")] ushort* lpGuid,
        [NativeTypeName("PVOID")] void* pBuffer,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("PDWORD")] uint* pdwAttribubutes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFirmwareEnvironmentVariableA(
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("LPCSTR")] sbyte* lpGuid,
        [NativeTypeName("PVOID")] void* pValue,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFirmwareEnvironmentVariableW(
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("LPCWSTR")] ushort* lpGuid,
        [NativeTypeName("PVOID")] void* pValue,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetFirmwareEnvironmentVariableExA(
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("LPCSTR")] sbyte* lpGuid,
        [NativeTypeName("PVOID")] void* pValue,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("DWORD")] uint dwAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL SetFirmwareEnvironmentVariableExW(
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("LPCWSTR")] ushort* lpGuid,
        [NativeTypeName("PVOID")] void* pValue,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("DWORD")] uint dwAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL GetFirmwareType(
        [NativeTypeName("PFIRMWARE_TYPE")] FIRMWARE_TYPE* FirmwareType
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL IsNativeVhdBoot([NativeTypeName("PBOOL")] BOOL* NativeVhdBoot);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HRSRC FindResourceA(
        HMODULE hModule,
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("LPCSTR")] sbyte* lpType
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HRSRC FindResourceExA(
        HMODULE hModule,
        [NativeTypeName("LPCSTR")] sbyte* lpType,
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("WORD")] ushort wLanguage
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceTypesA(
        HMODULE hModule,
        [NativeTypeName("ENUMRESTYPEPROCA")]
            delegate* unmanaged<HMODULE, sbyte*, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceTypesW(
        HMODULE hModule,
        [NativeTypeName("ENUMRESTYPEPROCW")]
            delegate* unmanaged<HMODULE, ushort*, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceLanguagesA(
        HMODULE hModule,
        [NativeTypeName("LPCSTR")] sbyte* lpType,
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("ENUMRESLANGPROCA")]
            delegate* unmanaged<HMODULE, sbyte*, sbyte*, ushort, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceLanguagesW(
        HMODULE hModule,
        [NativeTypeName("LPCWSTR")] ushort* lpType,
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("ENUMRESLANGPROCW")]
            delegate* unmanaged<HMODULE, ushort*, ushort*, ushort, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE BeginUpdateResourceA(
        [NativeTypeName("LPCSTR")] sbyte* pFileName,
        BOOL bDeleteExistingResources
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE BeginUpdateResourceW(
        [NativeTypeName("LPCWSTR")] ushort* pFileName,
        BOOL bDeleteExistingResources
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UpdateResourceA(
        HANDLE hUpdate,
        [NativeTypeName("LPCSTR")] sbyte* lpType,
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("WORD")] ushort wLanguage,
        [NativeTypeName("LPVOID")] void* lpData,
        [NativeTypeName("DWORD")] uint cb
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UpdateResourceW(
        HANDLE hUpdate,
        [NativeTypeName("LPCWSTR")] ushort* lpType,
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("WORD")] ushort wLanguage,
        [NativeTypeName("LPVOID")] void* lpData,
        [NativeTypeName("DWORD")] uint cb
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EndUpdateResourceA(HANDLE hUpdate, BOOL fDiscard);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EndUpdateResourceW(HANDLE hUpdate, BOOL fDiscard);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalAddAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalAddAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalAddAtomExA(
        [NativeTypeName("LPCSTR")] sbyte* lpString,
        [NativeTypeName("DWORD")] uint Flags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalAddAtomExW(
        [NativeTypeName("LPCWSTR")] ushort* lpString,
        [NativeTypeName("DWORD")] uint Flags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalFindAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort GlobalFindAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GlobalGetAtomNameA(
        [NativeTypeName("ATOM")] ushort nAtom,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        int nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GlobalGetAtomNameW(
        [NativeTypeName("ATOM")] ushort nAtom,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        int nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort AddAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort AddAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort FindAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("ATOM")]
    public static extern ushort FindAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetAtomNameA(
        [NativeTypeName("ATOM")] ushort nAtom,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        int nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetAtomNameW(
        [NativeTypeName("ATOM")] ushort nAtom,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        int nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetProfileIntA(
        [NativeTypeName("LPCSTR")] sbyte* lpAppName,
        [NativeTypeName("LPCSTR")] sbyte* lpKeyName,
        int nDefault
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetProfileIntW(
        [NativeTypeName("LPCWSTR")] ushort* lpAppName,
        [NativeTypeName("LPCWSTR")] ushort* lpKeyName,
        int nDefault
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProfileStringA(
        [NativeTypeName("LPCSTR")] sbyte* lpAppName,
        [NativeTypeName("LPCSTR")] sbyte* lpKeyName,
        [NativeTypeName("LPCSTR")] sbyte* lpDefault,
        [NativeTypeName("LPSTR")] sbyte* lpReturnedString,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProfileStringW(
        [NativeTypeName("LPCWSTR")] ushort* lpAppName,
        [NativeTypeName("LPCWSTR")] ushort* lpKeyName,
        [NativeTypeName("LPCWSTR")] ushort* lpDefault,
        [NativeTypeName("LPWSTR")] ushort* lpReturnedString,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteProfileStringA(
        [NativeTypeName("LPCSTR")] sbyte* lpAppName,
        [NativeTypeName("LPCSTR")] sbyte* lpKeyName,
        [NativeTypeName("LPCSTR")] sbyte* lpString
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteProfileStringW(
        [NativeTypeName("LPCWSTR")] ushort* lpAppName,
        [NativeTypeName("LPCWSTR")] ushort* lpKeyName,
        [NativeTypeName("LPCWSTR")] ushort* lpString
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProfileSectionA(
        [NativeTypeName("LPCSTR")] sbyte* lpAppName,
        [NativeTypeName("LPSTR")] sbyte* lpReturnedString,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetProfileSectionW(
        [NativeTypeName("LPCWSTR")] ushort* lpAppName,
        [NativeTypeName("LPWSTR")] ushort* lpReturnedString,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteProfileSectionA(
        [NativeTypeName("LPCSTR")] sbyte* lpAppName,
        [NativeTypeName("LPCSTR")] sbyte* lpString
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteProfileSectionW(
        [NativeTypeName("LPCWSTR")] ushort* lpAppName,
        [NativeTypeName("LPCWSTR")] ushort* lpString
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetPrivateProfileIntA(
        [NativeTypeName("LPCSTR")] sbyte* lpAppName,
        [NativeTypeName("LPCSTR")] sbyte* lpKeyName,
        int nDefault,
        [NativeTypeName("LPCSTR")] sbyte* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetPrivateProfileIntW(
        [NativeTypeName("LPCWSTR")] ushort* lpAppName,
        [NativeTypeName("LPCWSTR")] ushort* lpKeyName,
        int nDefault,
        [NativeTypeName("LPCWSTR")] ushort* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileStringA(
        [NativeTypeName("LPCSTR")] sbyte* lpAppName,
        [NativeTypeName("LPCSTR")] sbyte* lpKeyName,
        [NativeTypeName("LPCSTR")] sbyte* lpDefault,
        [NativeTypeName("LPSTR")] sbyte* lpReturnedString,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("LPCSTR")] sbyte* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileStringW(
        [NativeTypeName("LPCWSTR")] ushort* lpAppName,
        [NativeTypeName("LPCWSTR")] ushort* lpKeyName,
        [NativeTypeName("LPCWSTR")] ushort* lpDefault,
        [NativeTypeName("LPWSTR")] ushort* lpReturnedString,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("LPCWSTR")] ushort* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileStringA(
        [NativeTypeName("LPCSTR")] sbyte* lpAppName,
        [NativeTypeName("LPCSTR")] sbyte* lpKeyName,
        [NativeTypeName("LPCSTR")] sbyte* lpString,
        [NativeTypeName("LPCSTR")] sbyte* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileStringW(
        [NativeTypeName("LPCWSTR")] ushort* lpAppName,
        [NativeTypeName("LPCWSTR")] ushort* lpKeyName,
        [NativeTypeName("LPCWSTR")] ushort* lpString,
        [NativeTypeName("LPCWSTR")] ushort* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileSectionA(
        [NativeTypeName("LPCSTR")] sbyte* lpAppName,
        [NativeTypeName("LPSTR")] sbyte* lpReturnedString,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("LPCSTR")] sbyte* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileSectionW(
        [NativeTypeName("LPCWSTR")] ushort* lpAppName,
        [NativeTypeName("LPWSTR")] ushort* lpReturnedString,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("LPCWSTR")] ushort* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileSectionA(
        [NativeTypeName("LPCSTR")] sbyte* lpAppName,
        [NativeTypeName("LPCSTR")] sbyte* lpString,
        [NativeTypeName("LPCSTR")] sbyte* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileSectionW(
        [NativeTypeName("LPCWSTR")] ushort* lpAppName,
        [NativeTypeName("LPCWSTR")] ushort* lpString,
        [NativeTypeName("LPCWSTR")] ushort* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileSectionNamesA(
        [NativeTypeName("LPSTR")] sbyte* lpszReturnBuffer,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("LPCSTR")] sbyte* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPrivateProfileSectionNamesW(
        [NativeTypeName("LPWSTR")] ushort* lpszReturnBuffer,
        [NativeTypeName("DWORD")] uint nSize,
        [NativeTypeName("LPCWSTR")] ushort* lpFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetPrivateProfileStructA(
        [NativeTypeName("LPCSTR")] sbyte* lpszSection,
        [NativeTypeName("LPCSTR")] sbyte* lpszKey,
        [NativeTypeName("LPVOID")] void* lpStruct,
        uint uSizeStruct,
        [NativeTypeName("LPCSTR")] sbyte* szFile
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetPrivateProfileStructW(
        [NativeTypeName("LPCWSTR")] ushort* lpszSection,
        [NativeTypeName("LPCWSTR")] ushort* lpszKey,
        [NativeTypeName("LPVOID")] void* lpStruct,
        uint uSizeStruct,
        [NativeTypeName("LPCWSTR")] ushort* szFile
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileStructA(
        [NativeTypeName("LPCSTR")] sbyte* lpszSection,
        [NativeTypeName("LPCSTR")] sbyte* lpszKey,
        [NativeTypeName("LPVOID")] void* lpStruct,
        uint uSizeStruct,
        [NativeTypeName("LPCSTR")] sbyte* szFile
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WritePrivateProfileStructW(
        [NativeTypeName("LPCWSTR")] ushort* lpszSection,
        [NativeTypeName("LPCWSTR")] ushort* lpszKey,
        [NativeTypeName("LPVOID")] void* lpStruct,
        uint uSizeStruct,
        [NativeTypeName("LPCWSTR")] ushort* szFile
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDllDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDllDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetDllDirectoryA(
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetDllDirectoryW(
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSearchPathMode([NativeTypeName("DWORD")] uint Flags);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryExA(
        [NativeTypeName("LPCSTR")] sbyte* lpTemplateDirectory,
        [NativeTypeName("LPCSTR")] sbyte* lpNewDirectory,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryExW(
        [NativeTypeName("LPCWSTR")] ushort* lpTemplateDirectory,
        [NativeTypeName("LPCWSTR")] ushort* lpNewDirectory,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpTemplateDirectory,
        [NativeTypeName("LPCSTR")] sbyte* lpNewDirectory,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpTemplateDirectory,
        [NativeTypeName("LPCWSTR")] ushort* lpNewDirectory,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveDirectoryTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpPathName,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveDirectoryTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpPathName,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFullPathNameTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        [NativeTypeName("LPSTR *")] sbyte** lpFilePart,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFullPathNameTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        [NativeTypeName("LPWSTR *")] ushort** lpFilePart,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DefineDosDeviceA(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCSTR")] sbyte* lpDeviceName,
        [NativeTypeName("LPCSTR")] sbyte* lpTargetPath
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint QueryDosDeviceA(
        [NativeTypeName("LPCSTR")] sbyte* lpDeviceName,
        [NativeTypeName("LPSTR")] sbyte* lpTargetPath,
        [NativeTypeName("DWORD")] uint ucchMax
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("DWORD")] uint dwShareMode,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("DWORD")] uint dwCreationDisposition,
        [NativeTypeName("DWORD")] uint dwFlagsAndAttributes,
        HANDLE hTemplateFile,
        HANDLE hTransaction,
        [NativeTypeName("PUSHORT")] ushort* pusMiniVersion,
        [NativeTypeName("PVOID")] void* lpExtendedParameter
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("DWORD")] uint dwShareMode,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("DWORD")] uint dwCreationDisposition,
        [NativeTypeName("DWORD")] uint dwFlagsAndAttributes,
        HANDLE hTemplateFile,
        HANDLE hTransaction,
        [NativeTypeName("PUSHORT")] ushort* pusMiniVersion,
        [NativeTypeName("PVOID")] void* lpExtendedParameter
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE ReOpenFile(
        HANDLE hOriginalFile,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("DWORD")] uint dwShareMode,
        [NativeTypeName("DWORD")] uint dwFlagsAndAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileAttributesTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("DWORD")] uint dwFileAttributes,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileAttributesTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("DWORD")] uint dwFileAttributes,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileAttributesTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        GET_FILEEX_INFO_LEVELS fInfoLevelId,
        [NativeTypeName("LPVOID")] void* lpFileInformation,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileAttributesTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        GET_FILEEX_INFO_LEVELS fInfoLevelId,
        [NativeTypeName("LPVOID")] void* lpFileInformation,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCompressedFileSizeTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCompressedFileSizeTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteFileTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteFileTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckNameLegalDOS8Dot3A(
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("LPSTR")] sbyte* lpOemName,
        [NativeTypeName("DWORD")] uint OemNameSize,
        [NativeTypeName("PBOOL")] BOOL* pbNameContainsSpaces,
        [NativeTypeName("PBOOL")] BOOL* pbNameLegal
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CheckNameLegalDOS8Dot3W(
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("LPSTR")] sbyte* lpOemName,
        [NativeTypeName("DWORD")] uint OemNameSize,
        [NativeTypeName("PBOOL")] BOOL* pbNameContainsSpaces,
        [NativeTypeName("PBOOL")] BOOL* pbNameLegal
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        FINDEX_INFO_LEVELS fInfoLevelId,
        [NativeTypeName("LPVOID")] void* lpFindFileData,
        FINDEX_SEARCH_OPS fSearchOp,
        [NativeTypeName("LPVOID")] void* lpSearchFilter,
        [NativeTypeName("DWORD")] uint dwAdditionalFlags,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        FINDEX_INFO_LEVELS fInfoLevelId,
        [NativeTypeName("LPVOID")] void* lpFindFileData,
        FINDEX_SEARCH_OPS fSearchOp,
        [NativeTypeName("LPVOID")] void* lpSearchFilter,
        [NativeTypeName("DWORD")] uint dwAdditionalFlags,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileA(
        [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpNewFileName,
        BOOL bFailIfExists
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileW(
        [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpNewFileName,
        BOOL bFailIfExists
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileExA(
        [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpNewFileName,
        [NativeTypeName("LPPROGRESS_ROUTINE")]
            delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint> lpProgressRoutine,
        [NativeTypeName("LPVOID")] void* lpData,
        [NativeTypeName("LPBOOL")] BOOL* pbCancel,
        [NativeTypeName("DWORD")] uint dwCopyFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileExW(
        [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpNewFileName,
        [NativeTypeName("LPPROGRESS_ROUTINE")]
            delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint> lpProgressRoutine,
        [NativeTypeName("LPVOID")] void* lpData,
        [NativeTypeName("LPBOOL")] BOOL* pbCancel,
        [NativeTypeName("DWORD")] uint dwCopyFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpNewFileName,
        [NativeTypeName("LPPROGRESS_ROUTINE")]
            delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint> lpProgressRoutine,
        [NativeTypeName("LPVOID")] void* lpData,
        [NativeTypeName("LPBOOL")] BOOL* pbCancel,
        [NativeTypeName("DWORD")] uint dwCopyFlags,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyFileTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpNewFileName,
        [NativeTypeName("LPPROGRESS_ROUTINE")]
            delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint> lpProgressRoutine,
        [NativeTypeName("LPVOID")] void* lpData,
        [NativeTypeName("LPBOOL")] BOOL* pbCancel,
        [NativeTypeName("DWORD")] uint dwCopyFlags,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT CopyFile2(
        [NativeTypeName("PCWSTR")] ushort* pwszExistingFileName,
        [NativeTypeName("PCWSTR")] ushort* pwszNewFileName,
        COPYFILE2_EXTENDED_PARAMETERS* pExtendedParameters
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileA(
        [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpNewFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileW(
        [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpNewFileName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileExA(
        [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpNewFileName,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileExW(
        [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpNewFileName,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileWithProgressA(
        [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpNewFileName,
        [NativeTypeName("LPPROGRESS_ROUTINE")]
            delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint> lpProgressRoutine,
        [NativeTypeName("LPVOID")] void* lpData,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileWithProgressW(
        [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpNewFileName,
        [NativeTypeName("LPPROGRESS_ROUTINE")]
            delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint> lpProgressRoutine,
        [NativeTypeName("LPVOID")] void* lpData,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpNewFileName,
        [NativeTypeName("LPPROGRESS_ROUTINE")]
            delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint> lpProgressRoutine,
        [NativeTypeName("LPVOID")] void* lpData,
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MoveFileTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpNewFileName,
        [NativeTypeName("LPPROGRESS_ROUTINE")]
            delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint> lpProgressRoutine,
        [NativeTypeName("LPVOID")] void* lpData,
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReplaceFileA(
        [NativeTypeName("LPCSTR")] sbyte* lpReplacedFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpReplacementFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName,
        [NativeTypeName("DWORD")] uint dwReplaceFlags,
        [NativeTypeName("LPVOID")] void* lpExclude,
        [NativeTypeName("LPVOID")] void* lpReserved
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReplaceFileW(
        [NativeTypeName("LPCWSTR")] ushort* lpReplacedFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpReplacementFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName,
        [NativeTypeName("DWORD")] uint dwReplaceFlags,
        [NativeTypeName("LPVOID")] void* lpExclude,
        [NativeTypeName("LPVOID")] void* lpReserved
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateHardLinkA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateHardLinkW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateHardLinkTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateHardLinkTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstStreamTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        STREAM_INFO_LEVELS InfoLevel,
        [NativeTypeName("LPVOID")] void* lpFindStreamData,
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileNameTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPDWORD")] uint* StringLength,
        [NativeTypeName("PWSTR")] ushort* LinkName,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateNamedPipeA(
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("DWORD")] uint dwOpenMode,
        [NativeTypeName("DWORD")] uint dwPipeMode,
        [NativeTypeName("DWORD")] uint nMaxInstances,
        [NativeTypeName("DWORD")] uint nOutBufferSize,
        [NativeTypeName("DWORD")] uint nInBufferSize,
        [NativeTypeName("DWORD")] uint nDefaultTimeOut,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeHandleStateA(
        HANDLE hNamedPipe,
        [NativeTypeName("LPDWORD")] uint* lpState,
        [NativeTypeName("LPDWORD")] uint* lpCurInstances,
        [NativeTypeName("LPDWORD")] uint* lpMaxCollectionCount,
        [NativeTypeName("LPDWORD")] uint* lpCollectDataTimeout,
        [NativeTypeName("LPSTR")] sbyte* lpUserName,
        [NativeTypeName("DWORD")] uint nMaxUserNameSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CallNamedPipeA(
        [NativeTypeName("LPCSTR")] sbyte* lpNamedPipeName,
        [NativeTypeName("LPVOID")] void* lpInBuffer,
        [NativeTypeName("DWORD")] uint nInBufferSize,
        [NativeTypeName("LPVOID")] void* lpOutBuffer,
        [NativeTypeName("DWORD")] uint nOutBufferSize,
        [NativeTypeName("LPDWORD")] uint* lpBytesRead,
        [NativeTypeName("DWORD")] uint nTimeOut
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WaitNamedPipeA(
        [NativeTypeName("LPCSTR")] sbyte* lpNamedPipeName,
        [NativeTypeName("DWORD")] uint nTimeOut
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeClientComputerNameA(
        HANDLE Pipe,
        [NativeTypeName("LPSTR")] sbyte* ClientComputerName,
        [NativeTypeName("ULONG")] uint ClientComputerNameLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeClientProcessId(
        HANDLE Pipe,
        [NativeTypeName("PULONG")] uint* ClientProcessId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeClientSessionId(
        HANDLE Pipe,
        [NativeTypeName("PULONG")] uint* ClientSessionId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeServerProcessId(
        HANDLE Pipe,
        [NativeTypeName("PULONG")] uint* ServerProcessId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNamedPipeServerSessionId(
        HANDLE Pipe,
        [NativeTypeName("PULONG")] uint* ServerSessionId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetVolumeLabelA(
        [NativeTypeName("LPCSTR")] sbyte* lpRootPathName,
        [NativeTypeName("LPCSTR")] sbyte* lpVolumeName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetVolumeLabelW(
        [NativeTypeName("LPCWSTR")] ushort* lpRootPathName,
        [NativeTypeName("LPCWSTR")] ushort* lpVolumeName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileBandwidthReservation(
        HANDLE hFile,
        [NativeTypeName("DWORD")] uint nPeriodMilliseconds,
        [NativeTypeName("DWORD")] uint nBytesPerPeriod,
        BOOL bDiscardable,
        [NativeTypeName("LPDWORD")] uint* lpTransferSize,
        [NativeTypeName("LPDWORD")] uint* lpNumOutstandingRequests
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileBandwidthReservation(
        HANDLE hFile,
        [NativeTypeName("LPDWORD")] uint* lpPeriodMilliseconds,
        [NativeTypeName("LPDWORD")] uint* lpBytesPerPeriod,
        [NativeTypeName("LPBOOL")] BOOL* pDiscardable,
        [NativeTypeName("LPDWORD")] uint* lpTransferSize,
        [NativeTypeName("LPDWORD")] uint* lpNumOutstandingRequests
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ClearEventLogA(
        HANDLE hEventLog,
        [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ClearEventLogW(
        HANDLE hEventLog,
        [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BackupEventLogA(
        HANDLE hEventLog,
        [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BackupEventLogW(
        HANDLE hEventLog,
        [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CloseEventLog(HANDLE hEventLog);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeregisterEventSource(HANDLE hEventLog);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL NotifyChangeEventLog(HANDLE hEventLog, HANDLE hEvent);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumberOfEventLogRecords(
        HANDLE hEventLog,
        [NativeTypeName("PDWORD")] uint* NumberOfRecords
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetOldestEventLogRecord(
        HANDLE hEventLog,
        [NativeTypeName("PDWORD")] uint* OldestRecord
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenEventLogA(
        [NativeTypeName("LPCSTR")] sbyte* lpUNCServerName,
        [NativeTypeName("LPCSTR")] sbyte* lpSourceName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenEventLogW(
        [NativeTypeName("LPCWSTR")] ushort* lpUNCServerName,
        [NativeTypeName("LPCWSTR")] ushort* lpSourceName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE RegisterEventSourceA(
        [NativeTypeName("LPCSTR")] sbyte* lpUNCServerName,
        [NativeTypeName("LPCSTR")] sbyte* lpSourceName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE RegisterEventSourceW(
        [NativeTypeName("LPCWSTR")] ushort* lpUNCServerName,
        [NativeTypeName("LPCWSTR")] ushort* lpSourceName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenBackupEventLogA(
        [NativeTypeName("LPCSTR")] sbyte* lpUNCServerName,
        [NativeTypeName("LPCSTR")] sbyte* lpFileName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenBackupEventLogW(
        [NativeTypeName("LPCWSTR")] ushort* lpUNCServerName,
        [NativeTypeName("LPCWSTR")] ushort* lpFileName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadEventLogA(
        HANDLE hEventLog,
        [NativeTypeName("DWORD")] uint dwReadFlags,
        [NativeTypeName("DWORD")] uint dwRecordOffset,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToRead,
        [NativeTypeName("DWORD *")] uint* pnBytesRead,
        [NativeTypeName("DWORD *")] uint* pnMinNumberOfBytesNeeded
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadEventLogW(
        HANDLE hEventLog,
        [NativeTypeName("DWORD")] uint dwReadFlags,
        [NativeTypeName("DWORD")] uint dwRecordOffset,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint nNumberOfBytesToRead,
        [NativeTypeName("DWORD *")] uint* pnBytesRead,
        [NativeTypeName("DWORD *")] uint* pnMinNumberOfBytesNeeded
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReportEventA(
        HANDLE hEventLog,
        [NativeTypeName("WORD")] ushort wType,
        [NativeTypeName("WORD")] ushort wCategory,
        [NativeTypeName("DWORD")] uint dwEventID,
        [NativeTypeName("PSID")] void* lpUserSid,
        [NativeTypeName("WORD")] ushort wNumStrings,
        [NativeTypeName("DWORD")] uint dwDataSize,
        [NativeTypeName("LPCSTR *")] sbyte** lpStrings,
        [NativeTypeName("LPVOID")] void* lpRawData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReportEventW(
        HANDLE hEventLog,
        [NativeTypeName("WORD")] ushort wType,
        [NativeTypeName("WORD")] ushort wCategory,
        [NativeTypeName("DWORD")] uint dwEventID,
        [NativeTypeName("PSID")] void* lpUserSid,
        [NativeTypeName("WORD")] ushort wNumStrings,
        [NativeTypeName("DWORD")] uint dwDataSize,
        [NativeTypeName("LPCWSTR *")] ushort** lpStrings,
        [NativeTypeName("LPVOID")] void* lpRawData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetEventLogInformation(
        HANDLE hEventLog,
        [NativeTypeName("DWORD")] uint dwInfoLevel,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint cbBufSize,
        [NativeTypeName("LPDWORD")] uint* pcbBytesNeeded
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL OperationStart(OPERATION_START_PARAMETERS* OperationStartParams);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL OperationEnd(OPERATION_END_PARAMETERS* OperationEndParams);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckAndAuditAlarmA(
        [NativeTypeName("LPCSTR")] sbyte* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        [NativeTypeName("LPSTR")] sbyte* ObjectTypeName,
        [NativeTypeName("LPSTR")] sbyte* ObjectName,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        BOOL ObjectCreation,
        [NativeTypeName("LPDWORD")] uint* GrantedAccess,
        [NativeTypeName("LPBOOL")] BOOL* AccessStatus,
        [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeAndAuditAlarmA(
        [NativeTypeName("LPCSTR")] sbyte* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName,
        [NativeTypeName("LPCSTR")] sbyte* ObjectName,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("PSID")] void* PrincipalSelfSid,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        AUDIT_EVENT_TYPE AuditType,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList,
        [NativeTypeName("DWORD")] uint ObjectTypeListLength,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        BOOL ObjectCreation,
        [NativeTypeName("LPDWORD")] uint* GrantedAccess,
        [NativeTypeName("LPBOOL")] BOOL* AccessStatus,
        [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeResultListAndAuditAlarmA(
        [NativeTypeName("LPCSTR")] sbyte* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName,
        [NativeTypeName("LPCSTR")] sbyte* ObjectName,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("PSID")] void* PrincipalSelfSid,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        AUDIT_EVENT_TYPE AuditType,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList,
        [NativeTypeName("DWORD")] uint ObjectTypeListLength,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        BOOL ObjectCreation,
        [NativeTypeName("LPDWORD")] uint* GrantedAccess,
        [NativeTypeName("LPDWORD")] uint* AccessStatusList,
        [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AccessCheckByTypeResultListAndAuditAlarmByHandleA(
        [NativeTypeName("LPCSTR")] sbyte* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        HANDLE ClientToken,
        [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName,
        [NativeTypeName("LPCSTR")] sbyte* ObjectName,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor,
        [NativeTypeName("PSID")] void* PrincipalSelfSid,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        AUDIT_EVENT_TYPE AuditType,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList,
        [NativeTypeName("DWORD")] uint ObjectTypeListLength,
        [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping,
        BOOL ObjectCreation,
        [NativeTypeName("LPDWORD")] uint* GrantedAccess,
        [NativeTypeName("LPDWORD")] uint* AccessStatusList,
        [NativeTypeName("LPBOOL")] BOOL* pfGenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectOpenAuditAlarmA(
        [NativeTypeName("LPCSTR")] sbyte* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        [NativeTypeName("LPSTR")] sbyte* ObjectTypeName,
        [NativeTypeName("LPSTR")] sbyte* ObjectName,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        HANDLE ClientToken,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        [NativeTypeName("DWORD")] uint GrantedAccess,
        [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges,
        BOOL ObjectCreation,
        BOOL AccessGranted,
        [NativeTypeName("LPBOOL")] BOOL* GenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectPrivilegeAuditAlarmA(
        [NativeTypeName("LPCSTR")] sbyte* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        HANDLE ClientToken,
        [NativeTypeName("DWORD")] uint DesiredAccess,
        [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges,
        BOOL AccessGranted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectCloseAuditAlarmA(
        [NativeTypeName("LPCSTR")] sbyte* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        BOOL GenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ObjectDeleteAuditAlarmA(
        [NativeTypeName("LPCSTR")] sbyte* SubsystemName,
        [NativeTypeName("LPVOID")] void* HandleId,
        BOOL GenerateOnClose
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PrivilegedServiceAuditAlarmA(
        [NativeTypeName("LPCSTR")] sbyte* SubsystemName,
        [NativeTypeName("LPCSTR")] sbyte* ServiceName,
        HANDLE ClientToken,
        [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges,
        BOOL AccessGranted
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddConditionalAce(
        [NativeTypeName("PACL")] ACL* pAcl,
        [NativeTypeName("DWORD")] uint dwAceRevision,
        [NativeTypeName("DWORD")] uint AceFlags,
        [NativeTypeName("UCHAR")] byte AceType,
        [NativeTypeName("DWORD")] uint AccessMask,
        [NativeTypeName("PSID")] void* pSid,
        [NativeTypeName("PWCHAR")] ushort* ConditionStr,
        [NativeTypeName("DWORD *")] uint* ReturnLength
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileSecurityA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileSecurityA(
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("DWORD")] uint nLength,
        [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadDirectoryChangesW(
        HANDLE hDirectory,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint nBufferLength,
        BOOL bWatchSubtree,
        [NativeTypeName("DWORD")] uint dwNotifyFilter,
        [NativeTypeName("LPDWORD")] uint* lpBytesReturned,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped,
        [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")]
            delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.16299.0")]
    public static extern BOOL ReadDirectoryChangesExW(
        HANDLE hDirectory,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("DWORD")] uint nBufferLength,
        BOOL bWatchSubtree,
        [NativeTypeName("DWORD")] uint dwNotifyFilter,
        [NativeTypeName("LPDWORD")] uint* lpBytesReturned,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped,
        [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")]
            delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine,
        READ_DIRECTORY_NOTIFY_INFORMATION_CLASS ReadDirectoryNotifyInformationClass
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("LPVOID")]
    public static extern void* MapViewOfFileExNuma(
        HANDLE hFileMappingObject,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("DWORD")] uint dwFileOffsetHigh,
        [NativeTypeName("DWORD")] uint dwFileOffsetLow,
        [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToMap,
        [NativeTypeName("LPVOID")] void* lpBaseAddress,
        [NativeTypeName("DWORD")] uint nndPreferred
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadReadPtr(
        [NativeTypeName("const void *")] void* lp,
        [NativeTypeName("UINT_PTR")] nuint ucb
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadWritePtr(
        [NativeTypeName("LPVOID")] void* lp,
        [NativeTypeName("UINT_PTR")] nuint ucb
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadHugeReadPtr(
        [NativeTypeName("const void *")] void* lp,
        [NativeTypeName("UINT_PTR")] nuint ucb
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadHugeWritePtr(
        [NativeTypeName("LPVOID")] void* lp,
        [NativeTypeName("UINT_PTR")] nuint ucb
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL IsBadCodePtr([NativeTypeName("FARPROC")] void* lpfn);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadStringPtrA(
        [NativeTypeName("LPCSTR")] sbyte* lpsz,
        [NativeTypeName("UINT_PTR")] nuint ucchMax
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL IsBadStringPtrW(
        [NativeTypeName("LPCWSTR")] ushort* lpsz,
        [NativeTypeName("UINT_PTR")] nuint ucchMax
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountSidA(
        [NativeTypeName("LPCSTR")] sbyte* lpSystemName,
        [NativeTypeName("PSID")] void* Sid,
        [NativeTypeName("LPSTR")] sbyte* Name,
        [NativeTypeName("LPDWORD")] uint* cchName,
        [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName,
        [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName,
        [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountSidW(
        [NativeTypeName("LPCWSTR")] ushort* lpSystemName,
        [NativeTypeName("PSID")] void* Sid,
        [NativeTypeName("LPWSTR")] ushort* Name,
        [NativeTypeName("LPDWORD")] uint* cchName,
        [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName,
        [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName,
        [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountNameA(
        [NativeTypeName("LPCSTR")] sbyte* lpSystemName,
        [NativeTypeName("LPCSTR")] sbyte* lpAccountName,
        [NativeTypeName("PSID")] void* Sid,
        [NativeTypeName("LPDWORD")] uint* cbSid,
        [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName,
        [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName,
        [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountNameW(
        [NativeTypeName("LPCWSTR")] ushort* lpSystemName,
        [NativeTypeName("LPCWSTR")] ushort* lpAccountName,
        [NativeTypeName("PSID")] void* Sid,
        [NativeTypeName("LPDWORD")] uint* cbSid,
        [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName,
        [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName,
        [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse
    );

    [DllImport("sechost", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountSidLocalA(
        [NativeTypeName("PSID")] void* Sid,
        [NativeTypeName("LPSTR")] sbyte* Name,
        [NativeTypeName("LPDWORD")] uint* cchName,
        [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName,
        [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName,
        [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse
    );

    [DllImport("sechost", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupAccountSidLocalW(
        [NativeTypeName("PSID")] void* Sid,
        [NativeTypeName("LPWSTR")] ushort* Name,
        [NativeTypeName("LPDWORD")] uint* cchName,
        [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName,
        [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName,
        [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeValueA(
        [NativeTypeName("LPCSTR")] sbyte* lpSystemName,
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("PLUID")] LUID* lpLuid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeValueW(
        [NativeTypeName("LPCWSTR")] ushort* lpSystemName,
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("PLUID")] LUID* lpLuid
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeNameA(
        [NativeTypeName("LPCSTR")] sbyte* lpSystemName,
        [NativeTypeName("PLUID")] LUID* lpLuid,
        [NativeTypeName("LPSTR")] sbyte* lpName,
        [NativeTypeName("LPDWORD")] uint* cchName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeNameW(
        [NativeTypeName("LPCWSTR")] ushort* lpSystemName,
        [NativeTypeName("PLUID")] LUID* lpLuid,
        [NativeTypeName("LPWSTR")] ushort* lpName,
        [NativeTypeName("LPDWORD")] uint* cchName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeDisplayNameA(
        [NativeTypeName("LPCSTR")] sbyte* lpSystemName,
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("LPSTR")] sbyte* lpDisplayName,
        [NativeTypeName("LPDWORD")] uint* cchDisplayName,
        [NativeTypeName("LPDWORD")] uint* lpLanguageId
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LookupPrivilegeDisplayNameW(
        [NativeTypeName("LPCWSTR")] ushort* lpSystemName,
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("LPWSTR")] ushort* lpDisplayName,
        [NativeTypeName("LPDWORD")] uint* cchDisplayName,
        [NativeTypeName("LPDWORD")] uint* lpLanguageId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BuildCommDCBA(
        [NativeTypeName("LPCSTR")] sbyte* lpDef,
        [NativeTypeName("LPDCB")] DCB* lpDCB
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BuildCommDCBW(
        [NativeTypeName("LPCWSTR")] ushort* lpDef,
        [NativeTypeName("LPDCB")] DCB* lpDCB
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BuildCommDCBAndTimeoutsA(
        [NativeTypeName("LPCSTR")] sbyte* lpDef,
        [NativeTypeName("LPDCB")] DCB* lpDCB,
        [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BuildCommDCBAndTimeoutsW(
        [NativeTypeName("LPCWSTR")] ushort* lpDef,
        [NativeTypeName("LPDCB")] DCB* lpDCB,
        [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CommConfigDialogA(
        [NativeTypeName("LPCSTR")] sbyte* lpszName,
        HWND hWnd,
        [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CommConfigDialogW(
        [NativeTypeName("LPCWSTR")] ushort* lpszName,
        HWND hWnd,
        [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDefaultCommConfigA(
        [NativeTypeName("LPCSTR")] sbyte* lpszName,
        [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC,
        [NativeTypeName("LPDWORD")] uint* lpdwSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDefaultCommConfigW(
        [NativeTypeName("LPCWSTR")] ushort* lpszName,
        [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC,
        [NativeTypeName("LPDWORD")] uint* lpdwSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDefaultCommConfigA(
        [NativeTypeName("LPCSTR")] sbyte* lpszName,
        [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC,
        [NativeTypeName("DWORD")] uint dwSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDefaultCommConfigW(
        [NativeTypeName("LPCWSTR")] ushort* lpszName,
        [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC,
        [NativeTypeName("DWORD")] uint dwSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetComputerNameA(
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        [NativeTypeName("LPDWORD")] uint* nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetComputerNameW(
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        [NativeTypeName("LPDWORD")] uint* nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DnsHostnameToComputerNameA(
        [NativeTypeName("LPCSTR")] sbyte* Hostname,
        [NativeTypeName("LPSTR")] sbyte* ComputerName,
        [NativeTypeName("LPDWORD")] uint* nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DnsHostnameToComputerNameW(
        [NativeTypeName("LPCWSTR")] ushort* Hostname,
        [NativeTypeName("LPWSTR")] ushort* ComputerName,
        [NativeTypeName("LPDWORD")] uint* nSize
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUserNameA(
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        [NativeTypeName("LPDWORD")] uint* pcbBuffer
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetUserNameW(
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        [NativeTypeName("LPDWORD")] uint* pcbBuffer
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LogonUserA(
        [NativeTypeName("LPCSTR")] sbyte* lpszUsername,
        [NativeTypeName("LPCSTR")] sbyte* lpszDomain,
        [NativeTypeName("LPCSTR")] sbyte* lpszPassword,
        [NativeTypeName("DWORD")] uint dwLogonType,
        [NativeTypeName("DWORD")] uint dwLogonProvider,
        [NativeTypeName("PHANDLE")] HANDLE* phToken
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LogonUserW(
        [NativeTypeName("LPCWSTR")] ushort* lpszUsername,
        [NativeTypeName("LPCWSTR")] ushort* lpszDomain,
        [NativeTypeName("LPCWSTR")] ushort* lpszPassword,
        [NativeTypeName("DWORD")] uint dwLogonType,
        [NativeTypeName("DWORD")] uint dwLogonProvider,
        [NativeTypeName("PHANDLE")] HANDLE* phToken
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LogonUserExA(
        [NativeTypeName("LPCSTR")] sbyte* lpszUsername,
        [NativeTypeName("LPCSTR")] sbyte* lpszDomain,
        [NativeTypeName("LPCSTR")] sbyte* lpszPassword,
        [NativeTypeName("DWORD")] uint dwLogonType,
        [NativeTypeName("DWORD")] uint dwLogonProvider,
        [NativeTypeName("PHANDLE")] HANDLE* phToken,
        [NativeTypeName("PSID *")] void** ppLogonSid,
        [NativeTypeName("PVOID *")] void** ppProfileBuffer,
        [NativeTypeName("LPDWORD")] uint* pdwProfileLength,
        [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* pQuotaLimits
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LogonUserExW(
        [NativeTypeName("LPCWSTR")] ushort* lpszUsername,
        [NativeTypeName("LPCWSTR")] ushort* lpszDomain,
        [NativeTypeName("LPCWSTR")] ushort* lpszPassword,
        [NativeTypeName("DWORD")] uint dwLogonType,
        [NativeTypeName("DWORD")] uint dwLogonProvider,
        [NativeTypeName("PHANDLE")] HANDLE* phToken,
        [NativeTypeName("PSID *")] void** ppLogonSid,
        [NativeTypeName("PVOID *")] void** ppProfileBuffer,
        [NativeTypeName("LPDWORD")] uint* pdwProfileLength,
        [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* pQuotaLimits
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessWithLogonW(
        [NativeTypeName("LPCWSTR")] ushort* lpUsername,
        [NativeTypeName("LPCWSTR")] ushort* lpDomain,
        [NativeTypeName("LPCWSTR")] ushort* lpPassword,
        [NativeTypeName("DWORD")] uint dwLogonFlags,
        [NativeTypeName("LPCWSTR")] ushort* lpApplicationName,
        [NativeTypeName("LPWSTR")] ushort* lpCommandLine,
        [NativeTypeName("DWORD")] uint dwCreationFlags,
        [NativeTypeName("LPVOID")] void* lpEnvironment,
        [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory,
        [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo,
        [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateProcessWithTokenW(
        HANDLE hToken,
        [NativeTypeName("DWORD")] uint dwLogonFlags,
        [NativeTypeName("LPCWSTR")] ushort* lpApplicationName,
        [NativeTypeName("LPWSTR")] ushort* lpCommandLine,
        [NativeTypeName("DWORD")] uint dwCreationFlags,
        [NativeTypeName("LPVOID")] void* lpEnvironment,
        [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory,
        [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo,
        [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation
    );

    [DllImport("advapi32", ExactSpelling = true)]
    public static extern BOOL IsTokenUntrusted(HANDLE TokenHandle);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RegisterWaitForSingleObject(
        [NativeTypeName("PHANDLE")] HANDLE* phNewWaitObject,
        HANDLE hObject,
        [NativeTypeName("WAITORTIMERCALLBACK")] delegate* unmanaged<void*, byte, void> Callback,
        [NativeTypeName("PVOID")] void* Context,
        [NativeTypeName("ULONG")] uint dwMilliseconds,
        [NativeTypeName("ULONG")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnregisterWait(HANDLE WaitHandle);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL BindIoCompletionCallback(
        HANDLE FileHandle,
        [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")]
            delegate* unmanaged<uint, uint, OVERLAPPED*, void> Function,
        [NativeTypeName("ULONG")] uint Flags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE SetTimerQueueTimer(
        HANDLE TimerQueue,
        [NativeTypeName("WAITORTIMERCALLBACK")] delegate* unmanaged<void*, byte, void> Callback,
        [NativeTypeName("PVOID")] void* Parameter,
        [NativeTypeName("DWORD")] uint DueTime,
        [NativeTypeName("DWORD")] uint Period,
        BOOL PreferIo
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL CancelTimerQueueTimer(HANDLE TimerQueue, HANDLE Timer);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreatePrivateNamespaceA(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpPrivateNamespaceAttributes,
        [NativeTypeName("LPVOID")] void* lpBoundaryDescriptor,
        [NativeTypeName("LPCSTR")] sbyte* lpAliasPrefix
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HANDLE OpenPrivateNamespaceA(
        [NativeTypeName("LPVOID")] void* lpBoundaryDescriptor,
        [NativeTypeName("LPCSTR")] sbyte* lpAliasPrefix
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateBoundaryDescriptorA(
        [NativeTypeName("LPCSTR")] sbyte* Name,
        [NativeTypeName("ULONG")] uint Flags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddIntegrityLabelToBoundaryDescriptor(
        HANDLE* BoundaryDescriptor,
        [NativeTypeName("PSID")] void* IntegrityLabel
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCurrentHwProfileA(
        [NativeTypeName("LPHW_PROFILE_INFOA")] HW_PROFILE_INFOA* lpHwProfileInfo
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCurrentHwProfileW(
        [NativeTypeName("LPHW_PROFILE_INFOW")] HW_PROFILE_INFOW* lpHwProfileInfo
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL VerifyVersionInfoA(
        [NativeTypeName("LPOSVERSIONINFOEXA")] OSVERSIONINFOEXA* lpVersionInformation,
        [NativeTypeName("DWORD")] uint dwTypeMask,
        [NativeTypeName("DWORDLONG")] ulong dwlConditionMask
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL VerifyVersionInfoW(
        [NativeTypeName("LPOSVERSIONINFOEXW")] OSVERSIONINFOEXW* lpVersionInformation,
        [NativeTypeName("DWORD")] uint dwTypeMask,
        [NativeTypeName("DWORDLONG")] ulong dwlConditionMask
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetSystemPowerState(BOOL fSuspend, BOOL fForce);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetSystemPowerStatus(
        [NativeTypeName("LPSYSTEM_POWER_STATUS")] SYSTEM_POWER_STATUS* lpSystemPowerStatus
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL MapUserPhysicalPagesScatter(
        [NativeTypeName("PVOID *")] void** VirtualAddresses,
        [NativeTypeName("ULONG_PTR")] nuint NumberOfPages,
        [NativeTypeName("PULONG_PTR")] nuint* PageArray
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateJobObjectA(
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpJobAttributes,
        [NativeTypeName("LPCSTR")] sbyte* lpName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenJobObjectA(
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        BOOL bInheritHandle,
        [NativeTypeName("LPCSTR")] sbyte* lpName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL CreateJobSet(
        [NativeTypeName("ULONG")] uint NumJob,
        [NativeTypeName("PJOB_SET_ARRAY")] JOB_SET_ARRAY* UserJobSet,
        [NativeTypeName("ULONG")] uint Flags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstVolumeA(
        [NativeTypeName("LPSTR")] sbyte* lpszVolumeName,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextVolumeA(
        HANDLE hFindVolume,
        [NativeTypeName("LPSTR")] sbyte* lpszVolumeName,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstVolumeMountPointA(
        [NativeTypeName("LPCSTR")] sbyte* lpszRootPathName,
        [NativeTypeName("LPSTR")] sbyte* lpszVolumeMountPoint,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstVolumeMountPointW(
        [NativeTypeName("LPCWSTR")] ushort* lpszRootPathName,
        [NativeTypeName("LPWSTR")] ushort* lpszVolumeMountPoint,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextVolumeMountPointA(
        HANDLE hFindVolumeMountPoint,
        [NativeTypeName("LPSTR")] sbyte* lpszVolumeMountPoint,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextVolumeMountPointW(
        HANDLE hFindVolumeMountPoint,
        [NativeTypeName("LPWSTR")] ushort* lpszVolumeMountPoint,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindVolumeMountPointClose(HANDLE hFindVolumeMountPoint);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetVolumeMountPointA(
        [NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint,
        [NativeTypeName("LPCSTR")] sbyte* lpszVolumeName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetVolumeMountPointW(
        [NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint,
        [NativeTypeName("LPCWSTR")] ushort* lpszVolumeName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteVolumeMountPointA(
        [NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumeNameForVolumeMountPointA(
        [NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint,
        [NativeTypeName("LPSTR")] sbyte* lpszVolumeName,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumePathNameA(
        [NativeTypeName("LPCSTR")] sbyte* lpszFileName,
        [NativeTypeName("LPSTR")] sbyte* lpszVolumePathName,
        [NativeTypeName("DWORD")] uint cchBufferLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumePathNamesForVolumeNameA(
        [NativeTypeName("LPCSTR")] sbyte* lpszVolumeName,
        [NativeTypeName("LPCH")] sbyte* lpszVolumePathNames,
        [NativeTypeName("DWORD")] uint cchBufferLength,
        [NativeTypeName("PDWORD")] uint* lpcchReturnLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateActCtxA([NativeTypeName("PCACTCTXA")] ACTCTXA* pActCtx);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateActCtxW([NativeTypeName("PCACTCTXW")] ACTCTXW* pActCtx);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void AddRefActCtx(HANDLE hActCtx);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ReleaseActCtx(HANDLE hActCtx);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ZombifyActCtx(HANDLE hActCtx);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ActivateActCtx(
        HANDLE hActCtx,
        [NativeTypeName("ULONG_PTR *")] nuint* lpCookie
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeactivateActCtx(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("ULONG_PTR")] nuint ulCookie
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetCurrentActCtx(HANDLE* lphActCtx);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindActCtxSectionStringA(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const GUID *")] Guid* lpExtensionGuid,
        [NativeTypeName("ULONG")] uint ulSectionId,
        [NativeTypeName("LPCSTR")] sbyte* lpStringToFind,
        [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindActCtxSectionStringW(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const GUID *")] Guid* lpExtensionGuid,
        [NativeTypeName("ULONG")] uint ulSectionId,
        [NativeTypeName("LPCWSTR")] ushort* lpStringToFind,
        [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindActCtxSectionGuid(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const GUID *")] Guid* lpExtensionGuid,
        [NativeTypeName("ULONG")] uint ulSectionId,
        [NativeTypeName("const GUID *")] Guid* lpGuidToFind,
        [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryActCtxW(
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hActCtx,
        [NativeTypeName("PVOID")] void* pvSubInstance,
        [NativeTypeName("ULONG")] uint ulInfoClass,
        [NativeTypeName("PVOID")] void* pvBuffer,
        [NativeTypeName("SIZE_T")] nuint cbBuffer,
        [NativeTypeName("SIZE_T *")] nuint* pcbWrittenOrRequired
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WTSGetActiveConsoleSessionId();

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WTSGetServiceSessionId();

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte WTSIsServerContainer();

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("WORD")]
    public static extern ushort GetActiveProcessorGroupCount();

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("WORD")]
    public static extern ushort GetMaximumProcessorGroupCount();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetActiveProcessorCount([NativeTypeName("WORD")] ushort GroupNumber);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetMaximumProcessorCount([NativeTypeName("WORD")] ushort GroupNumber);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaProcessorNode(
        [NativeTypeName("UCHAR")] byte Processor,
        [NativeTypeName("PUCHAR")] byte* NodeNumber
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaNodeNumberFromHandle(
        HANDLE hFile,
        [NativeTypeName("PUSHORT")] ushort* NodeNumber
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaProcessorNodeEx(
        [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* Processor,
        [NativeTypeName("PUSHORT")] ushort* NodeNumber
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaNodeProcessorMask(
        [NativeTypeName("UCHAR")] byte Node,
        [NativeTypeName("PULONGLONG")] ulong* ProcessorMask
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaAvailableMemoryNode(
        [NativeTypeName("UCHAR")] byte Node,
        [NativeTypeName("PULONGLONG")] ulong* AvailableBytes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaAvailableMemoryNodeEx(
        ushort Node,
        [NativeTypeName("PULONGLONG")] ulong* AvailableBytes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetNumaProximityNode(
        [NativeTypeName("ULONG")] uint ProximityId,
        [NativeTypeName("PUCHAR")] byte* NodeNumber
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT RegisterApplicationRecoveryCallback(
        [NativeTypeName("APPLICATION_RECOVERY_CALLBACK")]
            delegate* unmanaged<void*, uint> pRecoveyCallback,
        [NativeTypeName("PVOID")] void* pvParameter,
        [NativeTypeName("DWORD")] uint dwPingInterval,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT UnregisterApplicationRecoveryCallback();

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT RegisterApplicationRestart(
        [NativeTypeName("PCWSTR")] ushort* pwzCommandline,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT UnregisterApplicationRestart();

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT GetApplicationRecoveryCallback(
        HANDLE hProcess,
        [NativeTypeName("APPLICATION_RECOVERY_CALLBACK *")]
            delegate* unmanaged<void*, uint>* pRecoveryCallback,
        [NativeTypeName("PVOID *")] void** ppvParameter,
        [NativeTypeName("PDWORD")] uint* pdwPingInterval,
        [NativeTypeName("PDWORD")] uint* pdwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT GetApplicationRestartSettings(
        HANDLE hProcess,
        [NativeTypeName("PWSTR")] ushort* pwzCommandline,
        [NativeTypeName("PDWORD")] uint* pcchSize,
        [NativeTypeName("PDWORD")] uint* pdwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern HRESULT ApplicationRecoveryInProgress(
        [NativeTypeName("PBOOL")] BOOL* pbCancelled
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void ApplicationRecoveryFinished(BOOL bSuccess);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileInformationByHandleEx(
        HANDLE hFile,
        FILE_INFO_BY_HANDLE_CLASS FileInformationClass,
        [NativeTypeName("LPVOID")] void* lpFileInformation,
        [NativeTypeName("DWORD")] uint dwBufferSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetFileInformationByName(
        [NativeTypeName("PCWSTR")] ushort* FileName,
        FILE_INFO_BY_NAME_CLASS FileInformationClass,
        [NativeTypeName("PVOID")] void* FileInfoBuffer,
        [NativeTypeName("ULONG")] uint FileInfoBufferSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE OpenFileById(
        HANDLE hVolumeHint,
        [NativeTypeName("LPFILE_ID_DESCRIPTOR")] FILE_ID_DESCRIPTOR* lpFileId,
        [NativeTypeName("DWORD")] uint dwDesiredAccess,
        [NativeTypeName("DWORD")] uint dwShareMode,
        [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("DWORD")] uint dwFlagsAndAttributes
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte CreateSymbolicLinkA(
        [NativeTypeName("LPCSTR")] sbyte* lpSymlinkFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpTargetFileName,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte CreateSymbolicLinkW(
        [NativeTypeName("LPCWSTR")] ushort* lpSymlinkFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpTargetFileName,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL QueryActCtxSettingsW(
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hActCtx,
        [NativeTypeName("PCWSTR")] ushort* settingsNameSpace,
        [NativeTypeName("PCWSTR")] ushort* settingName,
        [NativeTypeName("PWSTR")] ushort* pvBuffer,
        [NativeTypeName("SIZE_T")] nuint dwBuffer,
        [NativeTypeName("SIZE_T *")] nuint* pdwWrittenOrRequired
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte CreateSymbolicLinkTransactedA(
        [NativeTypeName("LPCSTR")] sbyte* lpSymlinkFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpTargetFileName,
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte CreateSymbolicLinkTransactedW(
        [NativeTypeName("LPCWSTR")] ushort* lpSymlinkFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpTargetFileName,
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hTransaction
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL ReplacePartitionUnit(
        [NativeTypeName("PWSTR")] ushort* TargetPartition,
        [NativeTypeName("PWSTR")] ushort* SparePartition,
        [NativeTypeName("ULONG")] uint Flags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AddSecureMemoryCacheCallback(
        [NativeTypeName("PSECURE_MEMORY_CACHE_CALLBACK")]
            delegate* unmanaged<void*, nuint, byte> pfnCallBack
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL RemoveSecureMemoryCacheCallback(
        [NativeTypeName("PSECURE_MEMORY_CACHE_CALLBACK")]
            delegate* unmanaged<void*, nuint, byte> pfnCallBack
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CopyContext(
        [NativeTypeName("PCONTEXT")] void* Destination,
        [NativeTypeName("DWORD")] uint ContextFlags,
        [NativeTypeName("PCONTEXT")] void* Source
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitializeContext(
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("DWORD")] uint ContextFlags,
        [NativeTypeName("PCONTEXT *")] void** Context,
        [NativeTypeName("PDWORD")] uint* ContextLength
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL InitializeContext2(
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("DWORD")] uint ContextFlags,
        [NativeTypeName("PCONTEXT *")] void** Context,
        [NativeTypeName("PDWORD")] uint* ContextLength,
        [NativeTypeName("ULONG64")] ulong XStateCompactionMask
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD64")]
    public static extern ulong GetEnabledXStateFeatures();

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL GetXStateFeaturesMask(
        [NativeTypeName("PCONTEXT")] void* Context,
        [NativeTypeName("PDWORD64")] ulong* FeatureMask
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("PVOID")]
    public static extern void* LocateXStateFeature(
        [NativeTypeName("PCONTEXT")] void* Context,
        [NativeTypeName("DWORD")] uint FeatureId,
        [NativeTypeName("PDWORD")] uint* Length
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetXStateFeaturesMask(
        [NativeTypeName("PCONTEXT")] void* Context,
        [NativeTypeName("DWORD64")] ulong FeatureMask
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD64")]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern ulong GetThreadEnabledXStateFeatures();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern BOOL EnableProcessOptionalXStateFeatures(
        [NativeTypeName("DWORD64")] ulong Features
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint EnableThreadProfiling(
        HANDLE ThreadHandle,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("DWORD64")] ulong HardwareCounters,
        HANDLE* PerformanceDataHandle
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DisableThreadProfiling(HANDLE PerformanceDataHandle);

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint QueryThreadProfiling(
        HANDLE ThreadHandle,
        [NativeTypeName("PBOOLEAN")] byte* Enabled
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ReadThreadProfilingData(
        HANDLE PerformanceDataHandle,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("PPERFORMANCE_DATA")] PERFORMANCE_DATA* PerformanceData
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RaiseCustomSystemEventTrigger(
        [NativeTypeName("PCUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG")]
            CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG* CustomSystemEventTriggerConfig
    );

    [NativeTypeName("#define PROGRESS_CONTINUE 0")]
    public const int PROGRESS_CONTINUE = 0;

    [NativeTypeName("#define PROGRESS_CANCEL 1")]
    public const int PROGRESS_CANCEL = 1;

    [NativeTypeName("#define PROGRESS_STOP 2")]
    public const int PROGRESS_STOP = 2;

    [NativeTypeName("#define PROGRESS_QUIET 3")]
    public const int PROGRESS_QUIET = 3;

    [NativeTypeName("#define CALLBACK_CHUNK_FINISHED 0x00000000")]
    public const int CALLBACK_CHUNK_FINISHED = 0x00000000;

    [NativeTypeName("#define CALLBACK_STREAM_SWITCH 0x00000001")]
    public const int CALLBACK_STREAM_SWITCH = 0x00000001;

    [NativeTypeName("#define REPLACEFILE_WRITE_THROUGH 0x00000001")]
    public const int REPLACEFILE_WRITE_THROUGH = 0x00000001;

    [NativeTypeName("#define REPLACEFILE_IGNORE_MERGE_ERRORS 0x00000002")]
    public const int REPLACEFILE_IGNORE_MERGE_ERRORS = 0x00000002;

    [NativeTypeName("#define REPLACEFILE_IGNORE_ACL_ERRORS 0x00000004")]
    public const int REPLACEFILE_IGNORE_ACL_ERRORS = 0x00000004;

    [NativeTypeName("#define FAIL_FAST_GENERATE_EXCEPTION_ADDRESS 0x1")]
    public const int FAIL_FAST_GENERATE_EXCEPTION_ADDRESS = 0x1;

    [NativeTypeName("#define FAIL_FAST_NO_HARD_ERROR_DLG 0x2")]
    public const int FAIL_FAST_NO_HARD_ERROR_DLG = 0x2;

    [NativeTypeName("#define DATABITS_5 ((WORD)0x0001)")]
    public const ushort DATABITS_5 = ((ushort)(0x0001));

    [NativeTypeName("#define DATABITS_6 ((WORD)0x0002)")]
    public const ushort DATABITS_6 = ((ushort)(0x0002));

    [NativeTypeName("#define DATABITS_7 ((WORD)0x0004)")]
    public const ushort DATABITS_7 = ((ushort)(0x0004));

    [NativeTypeName("#define DATABITS_8 ((WORD)0x0008)")]
    public const ushort DATABITS_8 = ((ushort)(0x0008));

    [NativeTypeName("#define DATABITS_16 ((WORD)0x0010)")]
    public const ushort DATABITS_16 = ((ushort)(0x0010));

    [NativeTypeName("#define DATABITS_16X ((WORD)0x0020)")]
    public const ushort DATABITS_16X = ((ushort)(0x0020));

    [NativeTypeName("#define STOPBITS_10 ((WORD)0x0001)")]
    public const ushort STOPBITS_10 = ((ushort)(0x0001));

    [NativeTypeName("#define STOPBITS_15 ((WORD)0x0002)")]
    public const ushort STOPBITS_15 = ((ushort)(0x0002));

    [NativeTypeName("#define STOPBITS_20 ((WORD)0x0004)")]
    public const ushort STOPBITS_20 = ((ushort)(0x0004));

    [NativeTypeName("#define PARITY_NONE ((WORD)0x0100)")]
    public const ushort PARITY_NONE = ((ushort)(0x0100));

    [NativeTypeName("#define PARITY_ODD ((WORD)0x0200)")]
    public const ushort PARITY_ODD = ((ushort)(0x0200));

    [NativeTypeName("#define PARITY_EVEN ((WORD)0x0400)")]
    public const ushort PARITY_EVEN = ((ushort)(0x0400));

    [NativeTypeName("#define PARITY_MARK ((WORD)0x0800)")]
    public const ushort PARITY_MARK = ((ushort)(0x0800));

    [NativeTypeName("#define PARITY_SPACE ((WORD)0x1000)")]
    public const ushort PARITY_SPACE = ((ushort)(0x1000));

    [NativeTypeName("#define COMMPROP_INITIALIZED ((DWORD)0xE73CF52E)")]
    public const uint COMMPROP_INITIALIZED = ((uint)(0xE73CF52E));

    [NativeTypeName("#define DTR_CONTROL_DISABLE 0x00")]
    public const int DTR_CONTROL_DISABLE = 0x00;

    [NativeTypeName("#define DTR_CONTROL_ENABLE 0x01")]
    public const int DTR_CONTROL_ENABLE = 0x01;

    [NativeTypeName("#define DTR_CONTROL_HANDSHAKE 0x02")]
    public const int DTR_CONTROL_HANDSHAKE = 0x02;

    [NativeTypeName("#define RTS_CONTROL_DISABLE 0x00")]
    public const int RTS_CONTROL_DISABLE = 0x00;

    [NativeTypeName("#define RTS_CONTROL_ENABLE 0x01")]
    public const int RTS_CONTROL_ENABLE = 0x01;

    [NativeTypeName("#define RTS_CONTROL_HANDSHAKE 0x02")]
    public const int RTS_CONTROL_HANDSHAKE = 0x02;

    [NativeTypeName("#define RTS_CONTROL_TOGGLE 0x03")]
    public const int RTS_CONTROL_TOGGLE = 0x03;

    [NativeTypeName("#define GHND (GMEM_MOVEABLE | GMEM_ZEROINIT)")]
    public const int GHND = (0x0002 | 0x0040);

    [NativeTypeName("#define GPTR (GMEM_FIXED | GMEM_ZEROINIT)")]
    public const int GPTR = (0x0000 | 0x0040);

    [NativeTypeName("#define DEBUG_PROCESS 0x00000001")]
    public const int DEBUG_PROCESS = 0x00000001;

    [NativeTypeName("#define DEBUG_ONLY_THIS_PROCESS 0x00000002")]
    public const int DEBUG_ONLY_THIS_PROCESS = 0x00000002;

    [NativeTypeName("#define DETACHED_PROCESS 0x00000008")]
    public const int DETACHED_PROCESS = 0x00000008;

    [NativeTypeName("#define NORMAL_PRIORITY_CLASS 0x00000020")]
    public const int NORMAL_PRIORITY_CLASS = 0x00000020;

    [NativeTypeName("#define IDLE_PRIORITY_CLASS 0x00000040")]
    public const int IDLE_PRIORITY_CLASS = 0x00000040;

    [NativeTypeName("#define HIGH_PRIORITY_CLASS 0x00000080")]
    public const int HIGH_PRIORITY_CLASS = 0x00000080;

    [NativeTypeName("#define REALTIME_PRIORITY_CLASS 0x00000100")]
    public const int REALTIME_PRIORITY_CLASS = 0x00000100;

    [NativeTypeName("#define BELOW_NORMAL_PRIORITY_CLASS 0x00004000")]
    public const int BELOW_NORMAL_PRIORITY_CLASS = 0x00004000;

    [NativeTypeName("#define ABOVE_NORMAL_PRIORITY_CLASS 0x00008000")]
    public const int ABOVE_NORMAL_PRIORITY_CLASS = 0x00008000;

    [NativeTypeName("#define INHERIT_PARENT_AFFINITY 0x00010000")]
    public const int INHERIT_PARENT_AFFINITY = 0x00010000;

    [NativeTypeName("#define INHERIT_CALLER_PRIORITY 0x00020000")]
    public const int INHERIT_CALLER_PRIORITY = 0x00020000;

    [NativeTypeName("#define EXTENDED_STARTUPINFO_PRESENT 0x00080000")]
    public const int EXTENDED_STARTUPINFO_PRESENT = 0x00080000;

    [NativeTypeName("#define PROFILE_USER 0x10000000")]
    public const int PROFILE_USER = 0x10000000;

    [NativeTypeName("#define PROFILE_KERNEL 0x20000000")]
    public const int PROFILE_KERNEL = 0x20000000;

    [NativeTypeName("#define PROFILE_SERVER 0x40000000")]
    public const int PROFILE_SERVER = 0x40000000;

    [NativeTypeName("#define STACK_SIZE_PARAM_IS_A_RESERVATION 0x00010000")]
    public const int STACK_SIZE_PARAM_IS_A_RESERVATION = 0x00010000;

    [NativeTypeName("#define VOLUME_NAME_DOS 0x0")]
    public const int VOLUME_NAME_DOS = 0x0;

    [NativeTypeName("#define VOLUME_NAME_GUID 0x1")]
    public const int VOLUME_NAME_GUID = 0x1;

    [NativeTypeName("#define VOLUME_NAME_NT 0x2")]
    public const int VOLUME_NAME_NT = 0x2;

    [NativeTypeName("#define VOLUME_NAME_NONE 0x4")]
    public const int VOLUME_NAME_NONE = 0x4;

    [NativeTypeName("#define DRIVE_UNKNOWN 0")]
    public const int DRIVE_UNKNOWN = 0;

    [NativeTypeName("#define DRIVE_NO_ROOT_DIR 1")]
    public const int DRIVE_NO_ROOT_DIR = 1;

    [NativeTypeName("#define DRIVE_REMOVABLE 2")]
    public const int DRIVE_REMOVABLE = 2;

    [NativeTypeName("#define DRIVE_FIXED 3")]
    public const int DRIVE_FIXED = 3;

    [NativeTypeName("#define DRIVE_REMOTE 4")]
    public const int DRIVE_REMOTE = 4;

    [NativeTypeName("#define DRIVE_CDROM 5")]
    public const int DRIVE_CDROM = 5;

    [NativeTypeName("#define DRIVE_RAMDISK 6")]
    public const int DRIVE_RAMDISK = 6;

    [NativeTypeName("#define NOPARITY 0")]
    public const int NOPARITY = 0;

    [NativeTypeName("#define ODDPARITY 1")]
    public const int ODDPARITY = 1;

    [NativeTypeName("#define EVENPARITY 2")]
    public const int EVENPARITY = 2;

    [NativeTypeName("#define MARKPARITY 3")]
    public const int MARKPARITY = 3;

    [NativeTypeName("#define SPACEPARITY 4")]
    public const int SPACEPARITY = 4;

    [NativeTypeName("#define ONESTOPBIT 0")]
    public const int ONESTOPBIT = 0;

    [NativeTypeName("#define ONE5STOPBITS 1")]
    public const int ONE5STOPBITS = 1;

    [NativeTypeName("#define TWOSTOPBITS 2")]
    public const int TWOSTOPBITS = 2;

    [NativeTypeName("#define IGNORE 0")]
    public const int IGNORE = 0;

    [NativeTypeName("#define INFINITE 0xFFFFFFFF")]
    public const uint INFINITE = 0xFFFFFFFF;

    [NativeTypeName("#define IE_BADID (-1)")]
    public const int IE_BADID = (-1);

    [NativeTypeName("#define IE_OPEN (-2)")]
    public const int IE_OPEN = (-2);

    [NativeTypeName("#define IE_NOPEN (-3)")]
    public const int IE_NOPEN = (-3);

    [NativeTypeName("#define IE_MEMORY (-4)")]
    public const int IE_MEMORY = (-4);

    [NativeTypeName("#define IE_DEFAULT (-5)")]
    public const int IE_DEFAULT = (-5);

    [NativeTypeName("#define IE_HARDWARE (-10)")]
    public const int IE_HARDWARE = (-10);

    [NativeTypeName("#define IE_BYTESIZE (-11)")]
    public const int IE_BYTESIZE = (-11);

    [NativeTypeName("#define IE_BAUDRATE (-12)")]
    public const int IE_BAUDRATE = (-12);

    [NativeTypeName("#define SETXOFF 1")]
    public const int SETXOFF = 1;

    [NativeTypeName("#define SETXON 2")]
    public const int SETXON = 2;

    [NativeTypeName("#define SETRTS 3")]
    public const int SETRTS = 3;

    [NativeTypeName("#define CLRRTS 4")]
    public const int CLRRTS = 4;

    [NativeTypeName("#define SETDTR 5")]
    public const int SETDTR = 5;

    [NativeTypeName("#define CLRDTR 6")]
    public const int CLRDTR = 6;

    [NativeTypeName("#define RESETDEV 7")]
    public const int RESETDEV = 7;

    [NativeTypeName("#define SETBREAK 8")]
    public const int SETBREAK = 8;

    [NativeTypeName("#define CLRBREAK 9")]
    public const int CLRBREAK = 9;

    [NativeTypeName("#define PURGE_TXABORT 0x0001")]
    public const int PURGE_TXABORT = 0x0001;

    [NativeTypeName("#define PURGE_RXABORT 0x0002")]
    public const int PURGE_RXABORT = 0x0002;

    [NativeTypeName("#define PURGE_TXCLEAR 0x0004")]
    public const int PURGE_TXCLEAR = 0x0004;

    [NativeTypeName("#define PURGE_RXCLEAR 0x0008")]
    public const int PURGE_RXCLEAR = 0x0008;

    [NativeTypeName("#define LPTx 0x80")]
    public const int LPTx = 0x80;

    [NativeTypeName("#define NMPWAIT_WAIT_FOREVER 0xffffffff")]
    public const uint NMPWAIT_WAIT_FOREVER = 0xffffffff;

    [NativeTypeName("#define NMPWAIT_NOWAIT 0x00000001")]
    public const int NMPWAIT_NOWAIT = 0x00000001;

    [NativeTypeName("#define NMPWAIT_USE_DEFAULT_WAIT 0x00000000")]
    public const int NMPWAIT_USE_DEFAULT_WAIT = 0x00000000;

    [NativeTypeName("#define OFS_MAXPATHNAME 128")]
    public const int OFS_MAXPATHNAME = 128;

    [NativeTypeName("#define MAXINTATOM 0xC000")]
    public const int MAXINTATOM = 0xC000;

    [NativeTypeName("#define INVALID_ATOM ((ATOM)0)")]
    public const ushort INVALID_ATOM = ((ushort)(0));

    [NativeTypeName("#define GetBinaryType GetBinaryTypeW")]
    public static delegate* <ushort*, uint*, BOOL> GetBinaryType => &GetBinaryTypeW;

    [NativeTypeName("#define GetLongPathNameTransacted GetLongPathNameTransactedW")]
    public static delegate* <ushort*, ushort*, uint, HANDLE, uint> GetLongPathNameTransacted =>
        &GetLongPathNameTransactedW;

    [NativeTypeName("#define FIBER_FLAG_FLOAT_SWITCH 0x1")]
    public const int FIBER_FLAG_FLOAT_SWITCH = 0x1;

    [NativeTypeName("#define UMS_VERSION RTL_UMS_VERSION")]
    public const int UMS_VERSION = (0x0100);

    [NativeTypeName("#define SEM_FAILCRITICALERRORS 0x0001")]
    public const int SEM_FAILCRITICALERRORS = 0x0001;

    [NativeTypeName("#define SEM_NOGPFAULTERRORBOX 0x0002")]
    public const int SEM_NOGPFAULTERRORBOX = 0x0002;

    [NativeTypeName("#define SEM_NOALIGNMENTFAULTEXCEPT 0x0004")]
    public const int SEM_NOALIGNMENTFAULTEXCEPT = 0x0004;

    [NativeTypeName("#define SEM_NOOPENFILEERRORBOX 0x8000")]
    public const int SEM_NOOPENFILEERRORBOX = 0x8000;

    [NativeTypeName(
        "#define CRITICAL_SECTION_NO_DEBUG_INFO RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO"
    )]
    public const int CRITICAL_SECTION_NO_DEBUG_INFO = 0x01000000;

    [NativeTypeName("#define SetFileShortName SetFileShortNameW")]
    public static delegate* <HANDLE, ushort*, BOOL> SetFileShortName => &SetFileShortNameW;

    [NativeTypeName("#define HINSTANCE_ERROR 32")]
    public const int HINSTANCE_ERROR = 32;

    [NativeTypeName("#define FormatMessage FormatMessageW")]
    public static delegate* <uint, void*, uint, uint, ushort*, uint, sbyte**, uint> FormatMessage =>
        &FormatMessageW;

    [NativeTypeName("#define CreateMailslot CreateMailslotW")]
    public static delegate* <ushort*, uint, uint, SECURITY_ATTRIBUTES*, HANDLE> CreateMailslot =>
        &CreateMailslotW;

    [NativeTypeName("#define EncryptFile EncryptFileW")]
    public static delegate* <ushort*, BOOL> EncryptFile => &EncryptFileW;

    [NativeTypeName("#define DecryptFile DecryptFileW")]
    public static delegate* <ushort*, uint, BOOL> DecryptFile => &DecryptFileW;

    [NativeTypeName("#define FileEncryptionStatus FileEncryptionStatusW")]
    public static delegate* <ushort*, uint*, BOOL> FileEncryptionStatus => &FileEncryptionStatusW;

    [NativeTypeName("#define EFS_USE_RECOVERY_KEYS (0x1)")]
    public const int EFS_USE_RECOVERY_KEYS = (0x1);

    [NativeTypeName("#define OVERWRITE_HIDDEN (4)")]
    public const int OVERWRITE_HIDDEN = (4);

    [NativeTypeName("#define EFSRPC_SECURE_ONLY (8)")]
    public const int EFSRPC_SECURE_ONLY = (8);

    [NativeTypeName("#define EFS_DROP_ALTERNATE_STREAMS (0x10)")]
    public const int EFS_DROP_ALTERNATE_STREAMS = (0x10);

    [NativeTypeName("#define OpenEncryptedFileRaw OpenEncryptedFileRawW")]
    public static delegate* <ushort*, uint, void**, uint> OpenEncryptedFileRaw =>
        &OpenEncryptedFileRawW;

    [NativeTypeName("#define lstrcmp lstrcmpW")]
    public static delegate* <ushort*, ushort*, int> lstrcmp => &lstrcmpW;

    [NativeTypeName("#define lstrcmpi lstrcmpiW")]
    public static delegate* <ushort*, ushort*, int> lstrcmpi => &lstrcmpiW;

    [NativeTypeName("#define lstrcpyn lstrcpynW")]
    public static delegate* <ushort*, ushort*, int, ushort*> lstrcpyn => &lstrcpynW;

    [NativeTypeName("#define lstrcpy lstrcpyW")]
    public static delegate* <ushort*, ushort*, ushort*> lstrcpy => &lstrcpyW;

    [NativeTypeName("#define lstrcat lstrcatW")]
    public static delegate* <ushort*, ushort*, ushort*> lstrcat => &lstrcatW;

    [NativeTypeName("#define lstrlen lstrlenW")]
    public static delegate* <ushort*, int> lstrlen => &lstrlenW;

    [NativeTypeName("#define QueryFullProcessImageName QueryFullProcessImageNameW")]
    public static delegate* <HANDLE, uint, ushort*, uint*, BOOL> QueryFullProcessImageName =>
        &QueryFullProcessImageNameW;

    [NativeTypeName("#define GetFirmwareEnvironmentVariable GetFirmwareEnvironmentVariableW")]
    public static delegate* <ushort*, ushort*, void*, uint, uint> GetFirmwareEnvironmentVariable =>
        &GetFirmwareEnvironmentVariableW;

    [NativeTypeName("#define GetFirmwareEnvironmentVariableEx GetFirmwareEnvironmentVariableExW")]
    [SupportedOSPlatform("windows6.2")]
    public static delegate* <
        ushort*,
        ushort*,
        void*,
        uint,
        uint*,
        uint> GetFirmwareEnvironmentVariableEx => &GetFirmwareEnvironmentVariableExW;

    [NativeTypeName("#define SetFirmwareEnvironmentVariable SetFirmwareEnvironmentVariableW")]
    public static delegate* <ushort*, ushort*, void*, uint, BOOL> SetFirmwareEnvironmentVariable =>
        &SetFirmwareEnvironmentVariableW;

    [NativeTypeName("#define SetFirmwareEnvironmentVariableEx SetFirmwareEnvironmentVariableExW")]
    [SupportedOSPlatform("windows6.2")]
    public static delegate* <
        ushort*,
        ushort*,
        void*,
        uint,
        uint,
        BOOL> SetFirmwareEnvironmentVariableEx => &SetFirmwareEnvironmentVariableExW;

    [NativeTypeName("#define EnumResourceTypes EnumResourceTypesW")]
    public static delegate* <
        HMODULE,
        delegate* unmanaged<HMODULE, ushort*, nint, BOOL>,
        nint,
        BOOL> EnumResourceTypes => &EnumResourceTypesW;

    [NativeTypeName("#define EnumResourceLanguages EnumResourceLanguagesW")]
    public static delegate* <
        HMODULE,
        ushort*,
        ushort*,
        delegate* unmanaged<HMODULE, ushort*, ushort*, ushort, nint, BOOL>,
        nint,
        BOOL> EnumResourceLanguages => &EnumResourceLanguagesW;

    [NativeTypeName("#define BeginUpdateResource BeginUpdateResourceW")]
    public static delegate* <ushort*, BOOL, HANDLE> BeginUpdateResource => &BeginUpdateResourceW;

    [NativeTypeName("#define UpdateResource UpdateResourceW")]
    public static delegate* <HANDLE, ushort*, ushort*, ushort, void*, uint, BOOL> UpdateResource =>
        &UpdateResourceW;

    [NativeTypeName("#define EndUpdateResource EndUpdateResourceW")]
    public static delegate* <HANDLE, BOOL, BOOL> EndUpdateResource => &EndUpdateResourceW;

    [NativeTypeName("#define ATOM_FLAG_GLOBAL 0x2")]
    public const int ATOM_FLAG_GLOBAL = 0x2;

    [NativeTypeName("#define GlobalAddAtom GlobalAddAtomW")]
    public static delegate* <ushort*, ushort> GlobalAddAtom => &GlobalAddAtomW;

    [NativeTypeName("#define GlobalAddAtomEx GlobalAddAtomExW")]
    public static delegate* <ushort*, uint, ushort> GlobalAddAtomEx => &GlobalAddAtomExW;

    [NativeTypeName("#define GlobalFindAtom GlobalFindAtomW")]
    public static delegate* <ushort*, ushort> GlobalFindAtom => &GlobalFindAtomW;

    [NativeTypeName("#define GlobalGetAtomName GlobalGetAtomNameW")]
    public static delegate* <ushort, ushort*, int, uint> GlobalGetAtomName => &GlobalGetAtomNameW;

    [NativeTypeName("#define AddAtom AddAtomW")]
    public static delegate* <ushort*, ushort> AddAtom => &AddAtomW;

    [NativeTypeName("#define FindAtom FindAtomW")]
    public static delegate* <ushort*, ushort> FindAtom => &FindAtomW;

    [NativeTypeName("#define GetAtomName GetAtomNameW")]
    public static delegate* <ushort, ushort*, int, uint> GetAtomName => &GetAtomNameW;

    [NativeTypeName("#define GetProfileInt GetProfileIntW")]
    public static delegate* <ushort*, ushort*, int, uint> GetProfileInt => &GetProfileIntW;

    [NativeTypeName("#define GetProfileString GetProfileStringW")]
    public static delegate* <ushort*, ushort*, ushort*, ushort*, uint, uint> GetProfileString =>
        &GetProfileStringW;

    [NativeTypeName("#define WriteProfileString WriteProfileStringW")]
    public static delegate* <ushort*, ushort*, ushort*, BOOL> WriteProfileString =>
        &WriteProfileStringW;

    [NativeTypeName("#define GetProfileSection GetProfileSectionW")]
    public static delegate* <ushort*, ushort*, uint, uint> GetProfileSection => &GetProfileSectionW;

    [NativeTypeName("#define WriteProfileSection WriteProfileSectionW")]
    public static delegate* <ushort*, ushort*, BOOL> WriteProfileSection => &WriteProfileSectionW;

    [NativeTypeName("#define GetPrivateProfileInt GetPrivateProfileIntW")]
    public static delegate* <ushort*, ushort*, int, ushort*, uint> GetPrivateProfileInt =>
        &GetPrivateProfileIntW;

    [NativeTypeName("#define GetPrivateProfileString GetPrivateProfileStringW")]
    public static delegate* <
        ushort*,
        ushort*,
        ushort*,
        ushort*,
        uint,
        ushort*,
        uint> GetPrivateProfileString => &GetPrivateProfileStringW;

    [NativeTypeName("#define WritePrivateProfileString WritePrivateProfileStringW")]
    public static delegate* <ushort*, ushort*, ushort*, ushort*, BOOL> WritePrivateProfileString =>
        &WritePrivateProfileStringW;

    [NativeTypeName("#define GetPrivateProfileSection GetPrivateProfileSectionW")]
    public static delegate* <ushort*, ushort*, uint, ushort*, uint> GetPrivateProfileSection =>
        &GetPrivateProfileSectionW;

    [NativeTypeName("#define WritePrivateProfileSection WritePrivateProfileSectionW")]
    public static delegate* <ushort*, ushort*, ushort*, BOOL> WritePrivateProfileSection =>
        &WritePrivateProfileSectionW;

    [NativeTypeName("#define GetPrivateProfileSectionNames GetPrivateProfileSectionNamesW")]
    public static delegate* <ushort*, uint, ushort*, uint> GetPrivateProfileSectionNames =>
        &GetPrivateProfileSectionNamesW;

    [NativeTypeName("#define GetPrivateProfileStruct GetPrivateProfileStructW")]
    public static delegate* <
        ushort*,
        ushort*,
        void*,
        uint,
        ushort*,
        BOOL> GetPrivateProfileStruct => &GetPrivateProfileStructW;

    [NativeTypeName("#define WritePrivateProfileStruct WritePrivateProfileStructW")]
    public static delegate* <
        ushort*,
        ushort*,
        void*,
        uint,
        ushort*,
        BOOL> WritePrivateProfileStruct => &WritePrivateProfileStructW;

    [NativeTypeName("#define SetDllDirectory SetDllDirectoryW")]
    public static delegate* <ushort*, BOOL> SetDllDirectory => &SetDllDirectoryW;

    [NativeTypeName("#define GetDllDirectory GetDllDirectoryW")]
    public static delegate* <uint, ushort*, uint> GetDllDirectory => &GetDllDirectoryW;

    [NativeTypeName("#define BASE_SEARCH_PATH_ENABLE_SAFE_SEARCHMODE 0x1")]
    public const int BASE_SEARCH_PATH_ENABLE_SAFE_SEARCHMODE = 0x1;

    [NativeTypeName("#define BASE_SEARCH_PATH_DISABLE_SAFE_SEARCHMODE 0x10000")]
    public const int BASE_SEARCH_PATH_DISABLE_SAFE_SEARCHMODE = 0x10000;

    [NativeTypeName("#define BASE_SEARCH_PATH_PERMANENT 0x8000")]
    public const int BASE_SEARCH_PATH_PERMANENT = 0x8000;

    [NativeTypeName("#define BASE_SEARCH_PATH_INVALID_FLAGS ~0x18001")]
    public const int BASE_SEARCH_PATH_INVALID_FLAGS = ~0x18001;

    [NativeTypeName("#define CreateDirectoryEx CreateDirectoryExW")]
    public static delegate* <ushort*, ushort*, SECURITY_ATTRIBUTES*, BOOL> CreateDirectoryEx =>
        &CreateDirectoryExW;

    [NativeTypeName("#define CreateDirectoryTransacted CreateDirectoryTransactedW")]
    public static delegate* <
        ushort*,
        ushort*,
        SECURITY_ATTRIBUTES*,
        HANDLE,
        BOOL> CreateDirectoryTransacted => &CreateDirectoryTransactedW;

    [NativeTypeName("#define RemoveDirectoryTransacted RemoveDirectoryTransactedW")]
    public static delegate* <ushort*, HANDLE, BOOL> RemoveDirectoryTransacted =>
        &RemoveDirectoryTransactedW;

    [NativeTypeName("#define GetFullPathNameTransacted GetFullPathNameTransactedW")]
    public static delegate* <
        ushort*,
        uint,
        ushort*,
        ushort**,
        HANDLE,
        uint> GetFullPathNameTransacted => &GetFullPathNameTransactedW;

    [NativeTypeName("#define DDD_RAW_TARGET_PATH 0x00000001")]
    public const int DDD_RAW_TARGET_PATH = 0x00000001;

    [NativeTypeName("#define DDD_REMOVE_DEFINITION 0x00000002")]
    public const int DDD_REMOVE_DEFINITION = 0x00000002;

    [NativeTypeName("#define DDD_EXACT_MATCH_ON_REMOVE 0x00000004")]
    public const int DDD_EXACT_MATCH_ON_REMOVE = 0x00000004;

    [NativeTypeName("#define DDD_NO_BROADCAST_SYSTEM 0x00000008")]
    public const int DDD_NO_BROADCAST_SYSTEM = 0x00000008;

    [NativeTypeName("#define DDD_LUID_BROADCAST_DRIVE 0x00000010")]
    public const int DDD_LUID_BROADCAST_DRIVE = 0x00000010;

    [NativeTypeName("#define CreateFileTransacted CreateFileTransactedW")]
    public static delegate* <
        ushort*,
        uint,
        uint,
        SECURITY_ATTRIBUTES*,
        uint,
        uint,
        HANDLE,
        HANDLE,
        ushort*,
        void*,
        HANDLE> CreateFileTransacted => &CreateFileTransactedW;

    [NativeTypeName("#define SetFileAttributesTransacted SetFileAttributesTransactedW")]
    public static delegate* <ushort*, uint, HANDLE, BOOL> SetFileAttributesTransacted =>
        &SetFileAttributesTransactedW;

    [NativeTypeName("#define GetFileAttributesTransacted GetFileAttributesTransactedW")]
    public static delegate* <
        ushort*,
        GET_FILEEX_INFO_LEVELS,
        void*,
        HANDLE,
        BOOL> GetFileAttributesTransacted => &GetFileAttributesTransactedW;

    [NativeTypeName("#define GetCompressedFileSizeTransacted GetCompressedFileSizeTransactedW")]
    public static delegate* <ushort*, uint*, HANDLE, uint> GetCompressedFileSizeTransacted =>
        &GetCompressedFileSizeTransactedW;

    [NativeTypeName("#define DeleteFileTransacted DeleteFileTransactedW")]
    public static delegate* <ushort*, HANDLE, BOOL> DeleteFileTransacted => &DeleteFileTransactedW;

    [NativeTypeName("#define CheckNameLegalDOS8Dot3 CheckNameLegalDOS8Dot3W")]
    public static delegate* <ushort*, sbyte*, uint, BOOL*, BOOL*, BOOL> CheckNameLegalDOS8Dot3 =>
        &CheckNameLegalDOS8Dot3W;

    [NativeTypeName("#define FindFirstFileTransacted FindFirstFileTransactedW")]
    public static delegate* <
        ushort*,
        FINDEX_INFO_LEVELS,
        void*,
        FINDEX_SEARCH_OPS,
        void*,
        uint,
        HANDLE,
        HANDLE> FindFirstFileTransacted => &FindFirstFileTransactedW;

    [NativeTypeName("#define CopyFile CopyFileW")]
    public static delegate* <ushort*, ushort*, BOOL, BOOL> CopyFile => &CopyFileW;

    [NativeTypeName("#define CopyFileEx CopyFileExW")]
    public static delegate* <
        ushort*,
        ushort*,
        delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint>,
        void*,
        BOOL*,
        uint,
        BOOL> CopyFileEx => &CopyFileExW;

    [NativeTypeName("#define CopyFileTransacted CopyFileTransactedW")]
    public static delegate* <
        ushort*,
        ushort*,
        delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint>,
        void*,
        BOOL*,
        uint,
        HANDLE,
        BOOL> CopyFileTransacted => &CopyFileTransactedW;

    [NativeTypeName("#define COPYFILE2_MESSAGE_COPY_OFFLOAD (0x00000001L)")]
    public const int COPYFILE2_MESSAGE_COPY_OFFLOAD = (0x00000001);

    [NativeTypeName("#define COPYFILE2_IO_CYCLE_SIZE_MIN 4096")]
    public const int COPYFILE2_IO_CYCLE_SIZE_MIN = 4096;

    [NativeTypeName("#define COPYFILE2_IO_CYCLE_SIZE_MAX 0x40000000")]
    public const int COPYFILE2_IO_CYCLE_SIZE_MAX = 0x40000000;

    [NativeTypeName("#define COPYFILE2_IO_RATE_MIN 512")]
    public const int COPYFILE2_IO_RATE_MIN = 512;

    [NativeTypeName("#define MoveFile MoveFileW")]
    public static delegate* <ushort*, ushort*, BOOL> MoveFile => &MoveFileW;

    [NativeTypeName("#define MoveFileEx MoveFileExW")]
    public static delegate* <ushort*, ushort*, uint, BOOL> MoveFileEx => &MoveFileExW;

    [NativeTypeName("#define MoveFileWithProgress MoveFileWithProgressW")]
    public static delegate* <
        ushort*,
        ushort*,
        delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint>,
        void*,
        uint,
        BOOL> MoveFileWithProgress => &MoveFileWithProgressW;

    [NativeTypeName("#define MoveFileTransacted MoveFileTransactedW")]
    public static delegate* <
        ushort*,
        ushort*,
        delegate* unmanaged<
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            LARGE_INTEGER,
            uint,
            uint,
            HANDLE,
            HANDLE,
            void*,
            uint>,
        void*,
        uint,
        HANDLE,
        BOOL> MoveFileTransacted => &MoveFileTransactedW;

    [NativeTypeName("#define MOVEFILE_REPLACE_EXISTING 0x00000001")]
    public const int MOVEFILE_REPLACE_EXISTING = 0x00000001;

    [NativeTypeName("#define MOVEFILE_COPY_ALLOWED 0x00000002")]
    public const int MOVEFILE_COPY_ALLOWED = 0x00000002;

    [NativeTypeName("#define MOVEFILE_DELAY_UNTIL_REBOOT 0x00000004")]
    public const int MOVEFILE_DELAY_UNTIL_REBOOT = 0x00000004;

    [NativeTypeName("#define MOVEFILE_WRITE_THROUGH 0x00000008")]
    public const int MOVEFILE_WRITE_THROUGH = 0x00000008;

    [NativeTypeName("#define MOVEFILE_CREATE_HARDLINK 0x00000010")]
    public const int MOVEFILE_CREATE_HARDLINK = 0x00000010;

    [NativeTypeName("#define MOVEFILE_FAIL_IF_NOT_TRACKABLE 0x00000020")]
    public const int MOVEFILE_FAIL_IF_NOT_TRACKABLE = 0x00000020;

    [NativeTypeName("#define ReplaceFile ReplaceFileW")]
    public static delegate* <ushort*, ushort*, ushort*, uint, void*, void*, BOOL> ReplaceFile =>
        &ReplaceFileW;

    [NativeTypeName("#define CreateHardLink CreateHardLinkW")]
    public static delegate* <ushort*, ushort*, SECURITY_ATTRIBUTES*, BOOL> CreateHardLink =>
        &CreateHardLinkW;

    [NativeTypeName("#define CreateHardLinkTransacted CreateHardLinkTransactedW")]
    public static delegate* <
        ushort*,
        ushort*,
        SECURITY_ATTRIBUTES*,
        HANDLE,
        BOOL> CreateHardLinkTransacted => &CreateHardLinkTransactedW;

    [NativeTypeName("#define SetVolumeLabel SetVolumeLabelW")]
    public static delegate* <ushort*, ushort*, BOOL> SetVolumeLabel => &SetVolumeLabelW;

    [NativeTypeName("#define ClearEventLog ClearEventLogW")]
    public static delegate* <HANDLE, ushort*, BOOL> ClearEventLog => &ClearEventLogW;

    [NativeTypeName("#define BackupEventLog BackupEventLogW")]
    public static delegate* <HANDLE, ushort*, BOOL> BackupEventLog => &BackupEventLogW;

    [NativeTypeName("#define OpenEventLog OpenEventLogW")]
    public static delegate* <ushort*, ushort*, HANDLE> OpenEventLog => &OpenEventLogW;

    [NativeTypeName("#define RegisterEventSource RegisterEventSourceW")]
    public static delegate* <ushort*, ushort*, HANDLE> RegisterEventSource => &RegisterEventSourceW;

    [NativeTypeName("#define OpenBackupEventLog OpenBackupEventLogW")]
    public static delegate* <ushort*, ushort*, HANDLE> OpenBackupEventLog => &OpenBackupEventLogW;

    [NativeTypeName("#define ReadEventLog ReadEventLogW")]
    public static delegate* <HANDLE, uint, uint, void*, uint, uint*, uint*, BOOL> ReadEventLog =>
        &ReadEventLogW;

    [NativeTypeName("#define ReportEvent ReportEventW")]
    public static delegate* <
        HANDLE,
        ushort,
        ushort,
        uint,
        void*,
        ushort,
        uint,
        ushort**,
        void*,
        BOOL> ReportEvent => &ReportEventW;

    [NativeTypeName("#define OPERATION_API_VERSION 1")]
    public const int OPERATION_API_VERSION = 1;

    [NativeTypeName("#define OPERATION_START_TRACE_CURRENT_THREAD 0x1")]
    public const int OPERATION_START_TRACE_CURRENT_THREAD = 0x1;

    [NativeTypeName("#define OPERATION_END_DISCARD 0x1")]
    public const int OPERATION_END_DISCARD = 0x1;

    [NativeTypeName("#define IsBadStringPtr IsBadStringPtrW")]
    public static delegate* <ushort*, nuint, BOOL> IsBadStringPtr => &IsBadStringPtrW;

    [NativeTypeName("#define LookupAccountSid LookupAccountSidW")]
    public static delegate* <
        ushort*,
        void*,
        ushort*,
        uint*,
        ushort*,
        uint*,
        SID_NAME_USE*,
        BOOL> LookupAccountSid => &LookupAccountSidW;

    [NativeTypeName("#define LookupAccountName LookupAccountNameW")]
    public static delegate* <
        ushort*,
        ushort*,
        void*,
        uint*,
        ushort*,
        uint*,
        SID_NAME_USE*,
        BOOL> LookupAccountName => &LookupAccountNameW;

    [NativeTypeName("#define LookupAccountSidLocal LookupAccountSidLocalW")]
    public static delegate* <
        void*,
        ushort*,
        uint*,
        ushort*,
        uint*,
        SID_NAME_USE*,
        BOOL> LookupAccountSidLocal => &LookupAccountSidLocalW;

    [NativeTypeName("#define LookupPrivilegeValue LookupPrivilegeValueW")]
    public static delegate* <ushort*, ushort*, LUID*, BOOL> LookupPrivilegeValue =>
        &LookupPrivilegeValueW;

    [NativeTypeName("#define LookupPrivilegeName LookupPrivilegeNameW")]
    public static delegate* <ushort*, LUID*, ushort*, uint*, BOOL> LookupPrivilegeName =>
        &LookupPrivilegeNameW;

    [NativeTypeName("#define LookupPrivilegeDisplayName LookupPrivilegeDisplayNameW")]
    public static delegate* <
        ushort*,
        ushort*,
        ushort*,
        uint*,
        uint*,
        BOOL> LookupPrivilegeDisplayName => &LookupPrivilegeDisplayNameW;

    [NativeTypeName("#define BuildCommDCB BuildCommDCBW")]
    public static delegate* <ushort*, DCB*, BOOL> BuildCommDCB => &BuildCommDCBW;

    [NativeTypeName("#define BuildCommDCBAndTimeouts BuildCommDCBAndTimeoutsW")]
    public static delegate* <ushort*, DCB*, COMMTIMEOUTS*, BOOL> BuildCommDCBAndTimeouts =>
        &BuildCommDCBAndTimeoutsW;

    [NativeTypeName("#define CommConfigDialog CommConfigDialogW")]
    public static delegate* <ushort*, HWND, COMMCONFIG*, BOOL> CommConfigDialog =>
        &CommConfigDialogW;

    [NativeTypeName("#define GetDefaultCommConfig GetDefaultCommConfigW")]
    public static delegate* <ushort*, COMMCONFIG*, uint*, BOOL> GetDefaultCommConfig =>
        &GetDefaultCommConfigW;

    [NativeTypeName("#define SetDefaultCommConfig SetDefaultCommConfigW")]
    public static delegate* <ushort*, COMMCONFIG*, uint, BOOL> SetDefaultCommConfig =>
        &SetDefaultCommConfigW;

    [NativeTypeName("#define GetComputerName GetComputerNameW")]
    public static delegate* <ushort*, uint*, BOOL> GetComputerName => &GetComputerNameW;

    [NativeTypeName("#define DnsHostnameToComputerName DnsHostnameToComputerNameW")]
    public static delegate* <ushort*, ushort*, uint*, BOOL> DnsHostnameToComputerName =>
        &DnsHostnameToComputerNameW;

    [NativeTypeName("#define GetUserName GetUserNameW")]
    public static delegate* <ushort*, uint*, BOOL> GetUserName => &GetUserNameW;

    [NativeTypeName("#define LogonUser LogonUserW")]
    public static delegate* <ushort*, ushort*, ushort*, uint, uint, HANDLE*, BOOL> LogonUser =>
        &LogonUserW;

    [NativeTypeName("#define LogonUserEx LogonUserExW")]
    public static delegate* <
        ushort*,
        ushort*,
        ushort*,
        uint,
        uint,
        HANDLE*,
        void**,
        void**,
        uint*,
        QUOTA_LIMITS*,
        BOOL> LogonUserEx => &LogonUserExW;

    [NativeTypeName("#define CreatePrivateNamespace CreatePrivateNamespaceW")]
    public static delegate* <SECURITY_ATTRIBUTES*, void*, ushort*, HANDLE> CreatePrivateNamespace =>
        &CreatePrivateNamespaceW;

    [NativeTypeName("#define OpenPrivateNamespace OpenPrivateNamespaceW")]
    public static delegate* <void*, ushort*, HANDLE> OpenPrivateNamespace => &OpenPrivateNamespaceW;

    [NativeTypeName("#define CreateBoundaryDescriptor CreateBoundaryDescriptorW")]
    public static delegate* <ushort*, uint, HANDLE> CreateBoundaryDescriptor =>
        &CreateBoundaryDescriptorW;

    [NativeTypeName("#define HW_PROFILE_GUIDLEN 39")]
    public const int HW_PROFILE_GUIDLEN = 39;

    [NativeTypeName("#define DOCKINFO_UNDOCKED (0x1)")]
    public const int DOCKINFO_UNDOCKED = (0x1);

    [NativeTypeName("#define DOCKINFO_DOCKED (0x2)")]
    public const int DOCKINFO_DOCKED = (0x2);

    [NativeTypeName("#define DOCKINFO_USER_SUPPLIED (0x4)")]
    public const int DOCKINFO_USER_SUPPLIED = (0x4);

    [NativeTypeName("#define DOCKINFO_USER_UNDOCKED (DOCKINFO_USER_SUPPLIED | DOCKINFO_UNDOCKED)")]
    public const int DOCKINFO_USER_UNDOCKED = ((0x4) | (0x1));

    [NativeTypeName("#define DOCKINFO_USER_DOCKED (DOCKINFO_USER_SUPPLIED | DOCKINFO_DOCKED)")]
    public const int DOCKINFO_USER_DOCKED = ((0x4) | (0x2));

    [NativeTypeName("#define GetCurrentHwProfile GetCurrentHwProfileW")]
    public static delegate* <HW_PROFILE_INFOW*, BOOL> GetCurrentHwProfile => &GetCurrentHwProfileW;

    [NativeTypeName("#define VerifyVersionInfo VerifyVersionInfoW")]
    public static delegate* <OSVERSIONINFOEXW*, uint, ulong, BOOL> VerifyVersionInfo =>
        &VerifyVersionInfoW;

    [NativeTypeName("#define AC_LINE_OFFLINE 0x00")]
    public const int AC_LINE_OFFLINE = 0x00;

    [NativeTypeName("#define AC_LINE_ONLINE 0x01")]
    public const int AC_LINE_ONLINE = 0x01;

    [NativeTypeName("#define AC_LINE_BACKUP_POWER 0x02")]
    public const int AC_LINE_BACKUP_POWER = 0x02;

    [NativeTypeName("#define AC_LINE_UNKNOWN 0xFF")]
    public const int AC_LINE_UNKNOWN = 0xFF;

    [NativeTypeName("#define CreateJobObject CreateJobObjectW")]
    public static delegate* <SECURITY_ATTRIBUTES*, ushort*, HANDLE> CreateJobObject =>
        &CreateJobObjectW;

    [NativeTypeName("#define OpenJobObject OpenJobObjectW")]
    public static delegate* <uint, BOOL, ushort*, HANDLE> OpenJobObject => &OpenJobObjectW;

    [NativeTypeName("#define FindFirstVolumeMountPoint FindFirstVolumeMountPointW")]
    public static delegate* <ushort*, ushort*, uint, HANDLE> FindFirstVolumeMountPoint =>
        &FindFirstVolumeMountPointW;

    [NativeTypeName("#define FindNextVolumeMountPoint FindNextVolumeMountPointW")]
    public static delegate* <HANDLE, ushort*, uint, BOOL> FindNextVolumeMountPoint =>
        &FindNextVolumeMountPointW;

    [NativeTypeName("#define SetVolumeMountPoint SetVolumeMountPointW")]
    public static delegate* <ushort*, ushort*, BOOL> SetVolumeMountPoint => &SetVolumeMountPointW;

    [NativeTypeName("#define ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID (0x00000001)")]
    public const int ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID = (0x00000001);

    [NativeTypeName("#define ACTCTX_FLAG_LANGID_VALID (0x00000002)")]
    public const int ACTCTX_FLAG_LANGID_VALID = (0x00000002);

    [NativeTypeName("#define ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID (0x00000004)")]
    public const int ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID = (0x00000004);

    [NativeTypeName("#define ACTCTX_FLAG_RESOURCE_NAME_VALID (0x00000008)")]
    public const int ACTCTX_FLAG_RESOURCE_NAME_VALID = (0x00000008);

    [NativeTypeName("#define ACTCTX_FLAG_SET_PROCESS_DEFAULT (0x00000010)")]
    public const int ACTCTX_FLAG_SET_PROCESS_DEFAULT = (0x00000010);

    [NativeTypeName("#define ACTCTX_FLAG_APPLICATION_NAME_VALID (0x00000020)")]
    public const int ACTCTX_FLAG_APPLICATION_NAME_VALID = (0x00000020);

    [NativeTypeName("#define ACTCTX_FLAG_SOURCE_IS_ASSEMBLYREF (0x00000040)")]
    public const int ACTCTX_FLAG_SOURCE_IS_ASSEMBLYREF = (0x00000040);

    [NativeTypeName("#define ACTCTX_FLAG_HMODULE_VALID (0x00000080)")]
    public const int ACTCTX_FLAG_HMODULE_VALID = (0x00000080);

    [NativeTypeName("#define CreateActCtx CreateActCtxW")]
    public static delegate* <ACTCTXW*, HANDLE> CreateActCtx => &CreateActCtxW;

    [NativeTypeName("#define DEACTIVATE_ACTCTX_FLAG_FORCE_EARLY_DEACTIVATION (0x00000001)")]
    public const int DEACTIVATE_ACTCTX_FLAG_FORCE_EARLY_DEACTIVATION = (0x00000001);

    [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_HACTCTX (0x00000001)")]
    public const int FIND_ACTCTX_SECTION_KEY_RETURN_HACTCTX = (0x00000001);

    [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_FLAGS (0x00000002)")]
    public const int FIND_ACTCTX_SECTION_KEY_RETURN_FLAGS = (0x00000002);

    [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_ASSEMBLY_METADATA (0x00000004)")]
    public const int FIND_ACTCTX_SECTION_KEY_RETURN_ASSEMBLY_METADATA = (0x00000004);

    [NativeTypeName("#define FindActCtxSectionString FindActCtxSectionStringW")]
    public static delegate* <
        uint,
        Guid*,
        uint,
        ushort*,
        ACTCTX_SECTION_KEYED_DATA*,
        BOOL> FindActCtxSectionString => &FindActCtxSectionStringW;

    [NativeTypeName("#define RESTART_MAX_CMD_LINE 1024")]
    public const int RESTART_MAX_CMD_LINE = 1024;

    [NativeTypeName("#define RESTART_NO_CRASH 1")]
    public const int RESTART_NO_CRASH = 1;

    [NativeTypeName("#define RESTART_NO_HANG 2")]
    public const int RESTART_NO_HANG = 2;

    [NativeTypeName("#define RESTART_NO_PATCH 4")]
    public const int RESTART_NO_PATCH = 4;

    [NativeTypeName("#define RESTART_NO_REBOOT 8")]
    public const int RESTART_NO_REBOOT = 8;

    [NativeTypeName("#define RECOVERY_DEFAULT_PING_INTERVAL 5000")]
    public const int RECOVERY_DEFAULT_PING_INTERVAL = 5000;

    [NativeTypeName("#define RECOVERY_MAX_PING_INTERVAL (5 * 60 * 1000)")]
    public const int RECOVERY_MAX_PING_INTERVAL = (5 * 60 * 1000);

    [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_LOOPBACK 0x00000001")]
    public const int REMOTE_PROTOCOL_INFO_FLAG_LOOPBACK = 0x00000001;

    [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_OFFLINE 0x00000002")]
    public const int REMOTE_PROTOCOL_INFO_FLAG_OFFLINE = 0x00000002;

    [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_PERSISTENT_HANDLE 0x00000004")]
    public const int REMOTE_PROTOCOL_INFO_FLAG_PERSISTENT_HANDLE = 0x00000004;

    [NativeTypeName("#define SYMBOLIC_LINK_FLAG_DIRECTORY (0x1)")]
    public const int SYMBOLIC_LINK_FLAG_DIRECTORY = (0x1);

    [NativeTypeName("#define SYMBOLIC_LINK_FLAG_ALLOW_UNPRIVILEGED_CREATE (0x2)")]
    public const int SYMBOLIC_LINK_FLAG_ALLOW_UNPRIVILEGED_CREATE = (0x2);

    [NativeTypeName("#define CreateSymbolicLink CreateSymbolicLinkW")]
    public static delegate* <ushort*, ushort*, uint, byte> CreateSymbolicLink =>
        &CreateSymbolicLinkW;

    [NativeTypeName("#define CreateSymbolicLinkTransacted CreateSymbolicLinkTransactedW")]
    public static delegate* <ushort*, ushort*, uint, HANDLE, byte> CreateSymbolicLinkTransacted =>
        &CreateSymbolicLinkTransactedW;

    [NativeTypeName("#define MICROSOFT_WINBASE_H_DEFINE_INTERLOCKED_CPLUSPLUS_OVERLOADS 0")]
    public const int MICROSOFT_WINBASE_H_DEFINE_INTERLOCKED_CPLUSPLUS_OVERLOADS = 0;
}
