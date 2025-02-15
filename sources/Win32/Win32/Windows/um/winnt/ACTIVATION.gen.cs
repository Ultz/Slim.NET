// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class ACTIVATION
{
    [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_NONE (1)")]
    public const int ACTIVATION_CONTEXT_PATH_TYPE_NONE = (1);

    [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_WIN32_FILE (2)")]
    public const int ACTIVATION_CONTEXT_PATH_TYPE_WIN32_FILE = (2);

    [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_URL (3)")]
    public const int ACTIVATION_CONTEXT_PATH_TYPE_URL = (3);

    [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_ASSEMBLYREF (4)")]
    public const int ACTIVATION_CONTEXT_PATH_TYPE_ASSEMBLYREF = (4);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_ASSEMBLY_INFORMATION (1)")]
    public const int ACTIVATION_CONTEXT_SECTION_ASSEMBLY_INFORMATION = (1);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_DLL_REDIRECTION (2)")]
    public const int ACTIVATION_CONTEXT_SECTION_DLL_REDIRECTION = (2);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_WINDOW_CLASS_REDIRECTION (3)")]
    public const int ACTIVATION_CONTEXT_SECTION_WINDOW_CLASS_REDIRECTION = (3);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_SERVER_REDIRECTION (4)")]
    public const int ACTIVATION_CONTEXT_SECTION_COM_SERVER_REDIRECTION = (4);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_INTERFACE_REDIRECTION (5)")]
    public const int ACTIVATION_CONTEXT_SECTION_COM_INTERFACE_REDIRECTION = (5);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_TYPE_LIBRARY_REDIRECTION (6)")]
    public const int ACTIVATION_CONTEXT_SECTION_COM_TYPE_LIBRARY_REDIRECTION = (6);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_PROGID_REDIRECTION (7)")]
    public const int ACTIVATION_CONTEXT_SECTION_COM_PROGID_REDIRECTION = (7);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_GLOBAL_OBJECT_RENAME_TABLE (8)")]
    public const int ACTIVATION_CONTEXT_SECTION_GLOBAL_OBJECT_RENAME_TABLE = (8);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_CLR_SURROGATES (9)")]
    public const int ACTIVATION_CONTEXT_SECTION_CLR_SURROGATES = (9);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_APPLICATION_SETTINGS (10)")]
    public const int ACTIVATION_CONTEXT_SECTION_APPLICATION_SETTINGS = (10);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COMPATIBILITY_INFO (11)")]
    public const int ACTIVATION_CONTEXT_SECTION_COMPATIBILITY_INFO = (11);

    [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_WINRT_ACTIVATABLE_CLASSES (12)")]
    public const int ACTIVATION_CONTEXT_SECTION_WINRT_ACTIVATABLE_CLASSES = (12);
}
