// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateToolhelp32Snapshot(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint th32ProcessID
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Heap32ListFirst(
        HANDLE hSnapshot,
        [NativeTypeName("LPHEAPLIST32")] HEAPLIST32* lphl
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Heap32ListNext(
        HANDLE hSnapshot,
        [NativeTypeName("LPHEAPLIST32")] HEAPLIST32* lphl
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Heap32First(
        [NativeTypeName("LPHEAPENTRY32")] HEAPENTRY32* lphe,
        [NativeTypeName("DWORD")] uint th32ProcessID,
        [NativeTypeName("ULONG_PTR")] nuint th32HeapID
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Heap32Next([NativeTypeName("LPHEAPENTRY32")] HEAPENTRY32* lphe);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL Toolhelp32ReadProcessMemory(
        [NativeTypeName("DWORD")] uint th32ProcessID,
        [NativeTypeName("LPCVOID")] void* lpBaseAddress,
        [NativeTypeName("LPVOID")] void* lpBuffer,
        [NativeTypeName("SIZE_T")] nuint cbRead,
        [NativeTypeName("SIZE_T *")] nuint* lpNumberOfBytesRead
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Process32FirstW(
        HANDLE hSnapshot,
        [NativeTypeName("LPPROCESSENTRY32W")] PROCESSENTRY32W* lppe
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Process32NextW(
        HANDLE hSnapshot,
        [NativeTypeName("LPPROCESSENTRY32W")] PROCESSENTRY32W* lppe
    );

    [DllImport("kernel32", EntryPoint = "Process32First", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Process32FirstA(
        HANDLE hSnapshot,
        [NativeTypeName("LPPROCESSENTRY32")] PROCESSENTRY32* lppe
    );

    [DllImport("kernel32", EntryPoint = "Process32Next", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Process32NextA(
        HANDLE hSnapshot,
        [NativeTypeName("LPPROCESSENTRY32")] PROCESSENTRY32* lppe
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Thread32First(
        HANDLE hSnapshot,
        [NativeTypeName("LPTHREADENTRY32")] THREADENTRY32* lpte
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Thread32Next(
        HANDLE hSnapshot,
        [NativeTypeName("LPTHREADENTRY32")] THREADENTRY32* lpte
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Module32FirstW(
        HANDLE hSnapshot,
        [NativeTypeName("LPMODULEENTRY32W")] MODULEENTRY32W* lpme
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Module32NextW(
        HANDLE hSnapshot,
        [NativeTypeName("LPMODULEENTRY32W")] MODULEENTRY32W* lpme
    );

    [DllImport("kernel32", EntryPoint = "Module32First", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Module32FirstA(
        HANDLE hSnapshot,
        [NativeTypeName("LPMODULEENTRY32")] MODULEENTRY32* lpme
    );

    [DllImport("kernel32", EntryPoint = "Module32Next", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL Module32NextA(
        HANDLE hSnapshot,
        [NativeTypeName("LPMODULEENTRY32")] MODULEENTRY32* lpme
    );

    [NativeTypeName("#define TH32CS_SNAPHEAPLIST 0x00000001")]
    public const int TH32CS_SNAPHEAPLIST = 0x00000001;

    [NativeTypeName("#define TH32CS_SNAPPROCESS 0x00000002")]
    public const int TH32CS_SNAPPROCESS = 0x00000002;

    [NativeTypeName("#define TH32CS_SNAPTHREAD 0x00000004")]
    public const int TH32CS_SNAPTHREAD = 0x00000004;

    [NativeTypeName("#define TH32CS_SNAPMODULE 0x00000008")]
    public const int TH32CS_SNAPMODULE = 0x00000008;

    [NativeTypeName("#define TH32CS_SNAPMODULE32 0x00000010")]
    public const int TH32CS_SNAPMODULE32 = 0x00000010;

    [NativeTypeName(
        "#define TH32CS_SNAPALL (TH32CS_SNAPHEAPLIST | TH32CS_SNAPPROCESS | TH32CS_SNAPTHREAD | TH32CS_SNAPMODULE)"
    )]
    public const int TH32CS_SNAPALL = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008);

    [NativeTypeName("#define TH32CS_INHERIT 0x80000000")]
    public const uint TH32CS_INHERIT = 0x80000000;

    [NativeTypeName("#define HF32_DEFAULT 1")]
    public const int HF32_DEFAULT = 1;

    [NativeTypeName("#define HF32_SHARED 2")]
    public const int HF32_SHARED = 2;

    [NativeTypeName("#define LF32_FIXED 0x00000001")]
    public const int LF32_FIXED = 0x00000001;

    [NativeTypeName("#define LF32_FREE 0x00000002")]
    public const int LF32_FREE = 0x00000002;

    [NativeTypeName("#define LF32_MOVEABLE 0x00000004")]
    public const int LF32_MOVEABLE = 0x00000004;

    [NativeTypeName("#define Process32First Process32FirstW")]
    public static delegate* <HANDLE, PROCESSENTRY32W*, BOOL> Process32First => &Process32FirstW;

    [NativeTypeName("#define Process32Next Process32NextW")]
    public static delegate* <HANDLE, PROCESSENTRY32W*, BOOL> Process32Next => &Process32NextW;

    [NativeTypeName("#define Module32First Module32FirstW")]
    public static delegate* <HANDLE, MODULEENTRY32W*, BOOL> Module32First => &Module32FirstW;

    [NativeTypeName("#define Module32Next Module32NextW")]
    public static delegate* <HANDLE, MODULEENTRY32W*, BOOL> Module32Next => &Module32NextW;
}
