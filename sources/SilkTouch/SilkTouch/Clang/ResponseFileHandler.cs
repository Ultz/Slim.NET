using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Parsing;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Hashing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using ClangSharp;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Utility;
using static ClangSharp.Interop.CXTranslationUnit_Flags;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Reads a response file (rsp) containing ClangSharpPInvokeGenerator command line arguments.
/// </summary>
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class ResponseFileHandler(ILogger<ResponseFileHandler> logger, IProgressService progressService)
{
    // Begin verbatim ClangSharp code
    private static readonly string[] s_additionalOptionAliases = ["--additional", "-a"];
    private static readonly string[] s_configOptionAliases = ["--config", "-c"];
    private static readonly string[] s_defineMacroOptionAliases = ["--define-macro", "-D"];
    private static readonly string[] s_excludeOptionAliases = ["--exclude", "-e"];
    private static readonly string[] s_fileOptionAliases = ["--file", "-f"];
    private static readonly string[] s_fileDirectionOptionAliases = ["--file-directory", "-F"];
    private static readonly string[] s_headerOptionAliases = ["--headerFile", "-hf"];
    private static readonly string[] s_includeOptionAliases = ["--include", "-i"];
    private static readonly string[] s_includeDirectoryOptionAliases =
    [
        "--include-directory",
        "-I",
    ];
    private static readonly string[] s_languageOptionAliases = ["--language", "-x"];
    private static readonly string[] s_libraryOptionAliases = ["--libraryPath", "-l"];
    private static readonly string[] s_methodClassNameOptionAliases = ["--methodClassName", "-m"];
    private static readonly string[] s_namespaceOptionAliases = ["--namespace", "-n"];
    private static readonly string[] s_nativeTypeNamesStripOptionAliases =
    [
        "--nativeTypeNamesToStrip",
    ];
    private static readonly string[] s_outputModeOptionAliases = ["--output-mode", "-om"];
    private static readonly string[] s_outputOptionAliases = ["--output", "-o"];
    private static readonly string[] s_prefixStripOptionAliases = ["--prefixStrip", "-p"];
    private static readonly string[] s_remapOptionAliases = ["--remap", "-r"];
    private static readonly string[] s_stdOptionAliases = ["--std", "-std"];
    private static readonly string[] s_testOutputOptionAliases = ["--test-output", "-to"];
    private static readonly string[] s_traverseOptionAliases = ["--traverse", "-t"];
    private static readonly string[] s_versionOptionAliases = ["--version", "-v"];
    private static readonly string[] s_withAccessSpecifierOptionAliases =
    [
        "--with-access-specifier",
        "-was",
    ];
    private static readonly string[] s_withAttributeOptionAliases = ["--with-attribute", "-wa"];
    private static readonly string[] s_withCallConvOptionAliases = ["--with-callconv", "-wcc"];
    private static readonly string[] s_withClassOptionAliases = ["--with-class", "-wc"];
    private static readonly string[] s_withGuidOptionAliases = ["--with-guid", "-wg"];
    private static readonly string[] s_withLengthOptionAliases = ["--with-length", "-wl"];
    private static readonly string[] s_withLibraryPathOptionAliases =
    [
        "--with-librarypath",
        "-wlb",
    ];
    private static readonly string[] s_withManualImportOptionAliases =
    [
        "--with-manual-import",
        "-wmi",
    ];
    private static readonly string[] s_withNamespaceOptionAliases = ["--with-namespace", "-wn"];
    private static readonly string[] s_withPackingOptionAliases = ["--with-packing", "-wp"];
    private static readonly string[] s_withSetLastErrorOptionAliases =
    [
        "--with-setlasterror",
        "-wsle",
    ];
    private static readonly string[] s_withSuppressGCTransitionOptionAliases =
    [
        "--with-suppressgctransition",
        "-wsgct",
    ];
    private static readonly string[] s_withTransparentStructOptionAliases =
    [
        "--with-transparent-struct",
        "-wts",
    ];
    private static readonly string[] s_withTypeOptionAliases = ["--with-type", "-wt"];
    private static readonly string[] s_withUsingOptionAliases = ["--with-using", "-wu"];

    private static readonly Option<string[]> s_additionalOption = GetAdditionalOption();
    private static readonly Option<string[]> s_configOption = GetConfigOption();
    private static readonly Option<string[]> s_defineMacros = GetDefineMacroOption();
    private static readonly Option<string[]> s_excludedNames = GetExcludeOption();
    private static readonly Option<string[]> s_files = GetFileOption();
    private static readonly Option<string> s_fileDirectory = GetFileDirectoryOption();
    private static readonly Option<string> s_headerFile = GetHeaderOption();
    private static readonly Option<string[]> s_includedNames = GetIncludeOption();
    private static readonly Option<string[]> s_includeDirectories = GetIncludeDirectoryOption();
    private static readonly Option<string> s_language = GetLanguageOption();
    private static readonly Option<string> s_libraryPath = GetLibraryOption();
    private static readonly Option<string> s_methodClassName = GetMethodClassNameOption();
    private static readonly Option<string> s_methodPrefixToStrip = GetPrefixStripOption();
    private static readonly Option<string> s_namespaceName = GetNamespaceOption();
    private static readonly Option<string[]> s_nativeTypeNamesToStrip =
        GetNativeTypeNamesStripOption();
    private static readonly Option<string> s_outputLocation = GetOutputOption();
    private static readonly Option<PInvokeGeneratorOutputMode> s_outputMode = GetOutputModeOption();
    private static readonly Option<string[]> s_remappedNameValuePairs = GetRemapOption();
    private static readonly Option<string> s_std = GetStdOption();
    private static readonly Option<string> s_testOutputLocation = GetTestOutputOption();
    private static readonly Option<string[]> s_traversalNames = GetTraverseOption();
    private static readonly Option<bool> s_versionOption = GetVersionOption();
    private static readonly Option<string[]> s_withAccessSpecifierNameValuePairs =
        GetWithAccessSpecifierOption();
    private static readonly Option<string[]> s_withAttributeNameValuePairs =
        GetWithAttributeOption();
    private static readonly Option<string[]> s_withCallConvNameValuePairs = GetWithCallConvOption();
    private static readonly Option<string[]> s_withClassNameValuePairs = GetWithClassOption();
    private static readonly Option<string[]> s_withGuidNameValuePairs = GetWithGuidOption();
    private static readonly Option<string[]> s_withLengthNameValuePairs = GetWithLengthOption();
    private static readonly Option<string[]> s_withLibraryPathNameValuePairs =
        GetWithLibraryPathOption();
    private static readonly Option<string[]> s_withManualImports = GetWithManualImportOption();
    private static readonly Option<string[]> s_withNamespaceNameValuePairs =
        GetWithNamespaceOption();
    private static readonly Option<string[]> s_withPackingNameValuePairs = GetWithPackingOption();
    private static readonly Option<string[]> s_withSetLastErrors = GetWithSetLastErrorOption();
    private static readonly Option<string[]> s_withSuppressGCTransitions =
        GetWithSuppressGCTransitionOption();
    private static readonly Option<string[]> s_withTransparentStructNameValuePairs =
        GetWithTransparentStructOption();
    private static readonly Option<string[]> s_withTypeNameValuePairs = GetWithTypeOption();
    private static readonly Option<string[]> s_withUsingNameValuePairs = GetWithUsingOption();
    private static readonly RootCommand s_rootCommand = GetRootCommand();

    private static void ParseKeyValuePairs(
        IEnumerable<string> keyValuePairs,
        List<string> errorList,
        out Dictionary<string, string> result
    )
    {
        result = [];

        foreach (var keyValuePair in keyValuePairs)
        {
            var parts = keyValuePair.Split('=', 2);

            if (parts.Length < 2)
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value'"
                );
                continue;
            }

            var key = parts[0].TrimEnd();

            if (result.TryGetValue(key, out var value))
            {
                errorList.Add(
                    $"Error: A key with the given name already exists: {key}. Existing: {value}"
                );
                continue;
            }

            result.Add(key, parts[1].TrimStart());
        }
    }

    private static void ParseKeyValuePairs(
        IEnumerable<string> keyValuePairs,
        List<string> errorList,
        out Dictionary<string, AccessSpecifier> result
    )
    {
        result = [];

        foreach (var keyValuePair in keyValuePairs)
        {
            var parts = keyValuePair.Split('=');

            if (parts.Length != 2)
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value'"
                );
                continue;
            }

            var key = parts[0].TrimEnd();

            if (result.TryGetValue(key, out var value))
            {
                errorList.Add(
                    $"Error: A key with the given name already exists: {key}. Existing: {value}"
                );
                continue;
            }

            result.Add(
                key,
                PInvokeGeneratorConfiguration.ConvertStringToAccessSpecifier(parts[1].TrimStart())
            );
        }
    }

    private static void ParseKeyValuePairs(
        IEnumerable<string> keyValuePairs,
        List<string> errorList,
        out Dictionary<string, Guid> result
    )
    {
        result = [];

        foreach (var keyValuePair in keyValuePairs)
        {
            var parts = keyValuePair.Split('=');

            if (parts.Length != 2)
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value'"
                );
                continue;
            }

            var key = parts[0].TrimEnd();

            if (result.TryGetValue(key, out var value))
            {
                errorList.Add(
                    $"Error: A key with the given name already exists: {key}. Existing: {value}"
                );
                continue;
            }

            if (!Guid.TryParse(parts[1].TrimStart(), out var guid))
            {
                errorList.Add($"Error: Failed to parse guid: {parts[1]}");
                continue;
            }

            result.Add(key, guid);
        }
    }

    private static void ParseKeyValuePairs(
        IEnumerable<string> keyValuePairs,
        List<string> errorList,
        out Dictionary<string, (string, PInvokeGeneratorTransparentStructKind)> result
    )
    {
        result = [];

        foreach (var keyValuePair in keyValuePairs)
        {
            var parts = keyValuePair.Split('=');

            if (parts.Length != 2)
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value' or 'name=value;kind'"
                );
                continue;
            }

            var key = parts[0].TrimEnd();

            if (result.TryGetValue(key, out var value))
            {
                errorList.Add(
                    $"Error: A key with the given name already exists: {key}. Existing: {value}"
                );
                continue;
            }

            parts = parts[1].Split(';');

            if (parts.Length == 1)
            {
                result.Add(key, (parts[0], PInvokeGeneratorTransparentStructKind.Unknown));
            }
            else if (
                (parts.Length == 2)
                && Enum.TryParse<PInvokeGeneratorTransparentStructKind>(
                    parts[1],
                    out var transparentStructKind
                )
            )
            {
                result.Add(key, (parts[0], transparentStructKind));
            }
            else
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value' or 'name=value;kind'"
                );
                continue;
            }
        }
    }

    private static void ParseKeyValuePairs(
        IEnumerable<string> keyValuePairs,
        List<string> errorList,
        out Dictionary<string, IReadOnlyList<string>> result
    )
    {
        result = [];

        foreach (var keyValuePair in keyValuePairs)
        {
            var parts = keyValuePair.Split('=');

            if (parts.Length != 2)
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value'"
                );
                continue;
            }

            var key = parts[0].TrimEnd();

            if (!result.TryGetValue(key, out var value))
            {
                value = new List<string>();
                result.Add(key, value);
            }

            var list = (List<string>)value;
            list.Add(parts[1].TrimStart());
        }
    }

    private static Option<string[]> GetAdditionalOption()
    {
        return new Option<string[]>(
            aliases: s_additionalOptionAliases,
            description: "An argument to pass to Clang when parsing the input files.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetConfigOption()
    {
        return new Option<string[]>(
            aliases: s_configOptionAliases,
            description: "A configuration option that controls how the bindings are generated. Specify 'help' to see the available options.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetDefineMacroOption()
    {
        return new Option<string[]>(
            aliases: s_defineMacroOptionAliases,
            description: "Define <macro> to <value> (or 1 if <value> omitted).",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetExcludeOption()
    {
        return new Option<string[]>(
            aliases: s_excludeOptionAliases,
            description: "A declaration name to exclude from binding generation.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetFileOption()
    {
        return new Option<string[]>(
            aliases: s_fileOptionAliases,
            description: "A file to parse and generate bindings for.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string> GetFileDirectoryOption()
    {
        return new Option<string>(
            aliases: s_fileDirectionOptionAliases,
            description: "The base path for files to parse.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string> GetHeaderOption()
    {
        return new Option<string>(
            aliases: s_headerOptionAliases,
            description: "A file which contains the header to prefix every generated file with.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string[]> GetIncludeOption()
    {
        return new Option<string[]>(
            aliases: s_includeOptionAliases,
            description: "A declaration name to include in binding generation.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetIncludeDirectoryOption()
    {
        return new Option<string[]>(
            aliases: s_includeDirectoryOptionAliases,
            description: "Add directory to include search path.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string> GetLanguageOption()
    {
        return new Option<string>(
            aliases: s_languageOptionAliases,
            description: "Treat subsequent input files as having type <language>.",
            getDefaultValue: () => "c++"
        ).FromAmong("c", "c++");
    }

    private static Option<string> GetLibraryOption()
    {
        return new Option<string>(
            aliases: s_libraryOptionAliases,
            description: "The string to use in the DllImport attribute used when generating bindings.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string> GetMethodClassNameOption()
    {
        return new Option<string>(
            aliases: s_methodClassNameOptionAliases,
            description: "The name of the static class that will contain the generated method bindings.",
            getDefaultValue: () => "Methods"
        );
    }

    private static Option<string> GetNamespaceOption()
    {
        return new Option<string>(
            aliases: s_namespaceOptionAliases,
            description: "The namespace in which to place the generated bindings.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string[]> GetNativeTypeNamesStripOption()
    {
        return new Option<string[]>(
            aliases: s_nativeTypeNamesStripOptionAliases,
            description: "The contents to strip from the generated NativeTypeName attributes.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<PInvokeGeneratorOutputMode> GetOutputModeOption()
    {
        return new Option<PInvokeGeneratorOutputMode>(
            aliases: s_outputModeOptionAliases,
            description: "The mode describing how the information collected from the headers are presented in the resultant bindings.",
            getDefaultValue: () => PInvokeGeneratorOutputMode.CSharp
        );
    }

    private static Option<string> GetOutputOption()
    {
        return new Option<string>(
            aliases: s_outputOptionAliases,
            description: "The output location to write the generated bindings to.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string> GetPrefixStripOption()
    {
        return new Option<string>(
            aliases: s_prefixStripOptionAliases,
            description: "The prefix to strip from the generated method bindings.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string[]> GetRemapOption()
    {
        return new Option<string[]>(
            aliases: s_remapOptionAliases,
            description: "A declaration name to be remapped to another name during binding generation.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static RootCommand GetRootCommand()
    {
        var rootCommand = new RootCommand("ClangSharp P/Invoke Binding Generator")
        {
            s_additionalOption,
            s_configOption,
            s_defineMacros,
            s_excludedNames,
            s_files,
            s_fileDirectory,
            s_headerFile,
            s_includedNames,
            s_includeDirectories,
            s_language,
            s_libraryPath,
            s_methodClassName,
            s_namespaceName,
            s_outputMode,
            s_outputLocation,
            s_methodPrefixToStrip,
            s_nativeTypeNamesToStrip,
            s_remappedNameValuePairs,
            s_std,
            s_testOutputLocation,
            s_traversalNames,
            s_versionOption,
            s_withAccessSpecifierNameValuePairs,
            s_withAttributeNameValuePairs,
            s_withCallConvNameValuePairs,
            s_withClassNameValuePairs,
            s_withGuidNameValuePairs,
            s_withLengthNameValuePairs,
            s_withLibraryPathNameValuePairs,
            s_withManualImports,
            s_withNamespaceNameValuePairs,
            s_withPackingNameValuePairs,
            s_withSetLastErrors,
            s_withSuppressGCTransitions,
            s_withTransparentStructNameValuePairs,
            s_withTypeNameValuePairs,
            s_withUsingNameValuePairs,
        };
        // Handler.SetHandler(rootCommand, (Action<InvocationContext>)Run);
        return rootCommand;
    }

    private static Option<string> GetStdOption()
    {
        return new Option<string>(
            aliases: s_stdOptionAliases,
            description: "Language standard to compile for.",
            getDefaultValue: () => ""
        );
    }

    private static Option<string> GetTestOutputOption()
    {
        return new Option<string>(
            aliases: s_testOutputOptionAliases,
            description: "The output location to write the generated tests to.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<bool> GetVersionOption()
    {
        return new Option<bool>(
            aliases: s_versionOptionAliases,
            description: "Prints the current version information for the tool and its native dependencies."
        )
        {
            Arity = ArgumentArity.Zero,
        };
    }

    private static Option<string[]> GetTraverseOption()
    {
        return new Option<string[]>(
            aliases: s_traverseOptionAliases,
            description: "A file name included either directly or indirectly by -f that should be traversed during binding generation.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithAccessSpecifierOption()
    {
        return new Option<string[]>(
            aliases: s_withAccessSpecifierOptionAliases,
            description: "An access specifier to be used with the given qualified or remapped declaration name during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithAttributeOption()
    {
        return new Option<string[]>(
            aliases: s_withAttributeOptionAliases,
            description: "An attribute to be added to the given remapped declaration name during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithCallConvOption()
    {
        return new Option<string[]>(
            aliases: s_withCallConvOptionAliases,
            description: "A calling convention to be used for the given declaration during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithClassOption()
    {
        return new Option<string[]>(
            aliases: s_withClassOptionAliases,
            description: "A class to be used for the given remapped constant or function declaration name during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithGuidOption()
    {
        return new Option<string[]>(
            aliases: s_withGuidOptionAliases,
            description: "A GUID to be used for the given declaration during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithLengthOption()
    {
        return new Option<string[]>(
            aliases: s_withLengthOptionAliases,
            description: "A length to be used for the given declaration during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithLibraryPathOption()
    {
        return new Option<string[]>(
            aliases: s_withLibraryPathOptionAliases,
            description: "A library path to be used for the given declaration during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithManualImportOption()
    {
        return new Option<string[]>(
            aliases: s_withManualImportOptionAliases,
            description: "A remapped function name to be treated as a manual import during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithNamespaceOption()
    {
        return new Option<string[]>(
            aliases: s_withNamespaceOptionAliases,
            description: "A namespace to be used for the given remapped declaration name during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithSetLastErrorOption()
    {
        return new Option<string[]>(
            aliases: s_withSetLastErrorOptionAliases,
            description: "Add the SetLastError=true modifier or SetsSystemLastError attribute to a given DllImport or UnmanagedFunctionPointer. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithSuppressGCTransitionOption()
    {
        return new Option<string[]>(
            aliases: s_withSuppressGCTransitionOptionAliases,
            description: "Add the SuppressGCTransition calling convention to a given DllImport or UnmanagedFunctionPointer. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithTransparentStructOption()
    {
        return new Option<string[]>(
            aliases: s_withTransparentStructOptionAliases,
            description: "A remapped type name to be treated as a transparent wrapper during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithTypeOption()
    {
        return new Option<string[]>(
            aliases: s_withTypeOptionAliases,
            description: "A type to be used for the given enum declaration during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithUsingOption()
    {
        return new Option<string[]>(
            aliases: s_withUsingOptionAliases,
            description: "A using directive to be included for the given remapped declaration name during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    private static Option<string[]> GetWithPackingOption()
    {
        return new Option<string[]>(
            aliases: s_withPackingOptionAliases,
            description: "Overrides the StructLayoutAttribute.Pack property for the given type. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true,
        };
    }

    // End verbatim ClangSharp code

    /// <summary>
    /// Reads the given string array as ClangSharpPInvokeGenerator arguments from a response file.
    /// </summary>
    /// <param name="args">The arguments read from the rsp file.</param>
    /// <param name="directory">The directory in which the rsp file resides.</param>
    /// <param name="filePath">The file path from which the response file arguments were read.</param>
    /// <returns></returns>
    public ResponseFile ReadResponseFile(
        IReadOnlyList<string> args,
        string? directory = null,
        string? filePath = null
    )
    {
        logger.LogDebug("ClangSharp command line arguments: {0}", string.Join(" ", args));
        var context = (ParseResult: new Parser(s_rootCommand).Parse(args), Dummy: 0);

        // Begin verbatim ClangSharp code: https://github.com/dotnet/ClangSharp/blob/main/sources/ClangSharpPInvokeGenerator/Program.cs
        var additionalArgs = context.ParseResult.GetValueForOption(s_additionalOption) ?? [];
        var configSwitches = context.ParseResult.GetValueForOption(s_configOption) ?? [];
        var defineMacros = context.ParseResult.GetValueForOption(s_defineMacros) ?? [];
        var excludedNames = context.ParseResult.GetValueForOption(s_excludedNames) ?? [];
        var files = context.ParseResult.GetValueForOption(s_files) ?? [];
        var fileDirectory = context.ParseResult.GetValueForOption(s_fileDirectory) ?? "";
        var headerFile = context.ParseResult.GetValueForOption(s_headerFile) ?? "";
        var includedNames = context.ParseResult.GetValueForOption(s_includedNames) ?? [];
        var includeDirectories = context.ParseResult.GetValueForOption(s_includeDirectories) ?? [];
        var language = context.ParseResult.GetValueForOption(s_language) ?? "";
        var libraryPath = context.ParseResult.GetValueForOption(s_libraryPath) ?? "";
        var methodClassName = context.ParseResult.GetValueForOption(s_methodClassName) ?? "";
        var methodPrefixToStrip =
            context.ParseResult.GetValueForOption(s_methodPrefixToStrip) ?? "";
        var nativeTypeNamesToStrip =
            context.ParseResult.GetValueForOption(s_nativeTypeNamesToStrip) ?? [];
        var namespaceName = context.ParseResult.GetValueForOption(s_namespaceName) ?? "";
        var outputLocation = context.ParseResult.GetValueForOption(s_outputLocation) ?? "";
        var outputMode = context.ParseResult.GetValueForOption(s_outputMode);
        var remappedNameValuePairs =
            context.ParseResult.GetValueForOption(s_remappedNameValuePairs) ?? [];
        var std = context.ParseResult.GetValueForOption(s_std) ?? "";
        var testOutputLocation = context.ParseResult.GetValueForOption(s_testOutputLocation) ?? "";
        var traversalNames = context.ParseResult.GetValueForOption(s_traversalNames) ?? [];
        var withAccessSpecifierNameValuePairs =
            context.ParseResult.GetValueForOption(s_withAccessSpecifierNameValuePairs) ?? [];
        var withAttributeNameValuePairs =
            context.ParseResult.GetValueForOption(s_withAttributeNameValuePairs) ?? [];
        var withCallConvNameValuePairs =
            context.ParseResult.GetValueForOption(s_withCallConvNameValuePairs) ?? [];
        var withClassNameValuePairs =
            context.ParseResult.GetValueForOption(s_withClassNameValuePairs) ?? [];
        var withGuidNameValuePairs =
            context.ParseResult.GetValueForOption(s_withGuidNameValuePairs) ?? [];
        var withLengthNameValuePairs =
            context.ParseResult.GetValueForOption(s_withLengthNameValuePairs) ?? [];
        var withLibraryPathNameValuePairs =
            context.ParseResult.GetValueForOption(s_withLibraryPathNameValuePairs) ?? [];
        var withManualImports = context.ParseResult.GetValueForOption(s_withManualImports) ?? [];
        var withNamespaceNameValuePairs =
            context.ParseResult.GetValueForOption(s_withNamespaceNameValuePairs) ?? [];
        var withSetLastErrors = context.ParseResult.GetValueForOption(s_withSetLastErrors) ?? [];
        var withSuppressGCTransitions =
            context.ParseResult.GetValueForOption(s_withSuppressGCTransitions) ?? [];
        var withTransparentStructNameValuePairs =
            context.ParseResult.GetValueForOption(s_withTransparentStructNameValuePairs) ?? [];
        var withTypeNameValuePairs =
            context.ParseResult.GetValueForOption(s_withTypeNameValuePairs) ?? [];
        var withUsingNameValuePairs =
            context.ParseResult.GetValueForOption(s_withUsingNameValuePairs) ?? [];
        var withPackingNameValuePairs =
            context.ParseResult.GetValueForOption(s_withPackingNameValuePairs) ?? [];

        var versionResult = context.ParseResult.FindResultFor(s_versionOption);

        // if (versionResult is not null)
        // {
        //     context.Console.WriteLine($"{s_rootCommand.Description} version 18.1.3");
        //     context.Console.WriteLine($"  {clang.getClangVersion()}");
        //     context.Console.WriteLine($"  {clangsharp.getVersion()}");
        //     context.ExitCode = -1;
        //     return;
        // }

        var errorList = new List<string>();

        if (files.Length == 0)
        {
            errorList.Add("Error: No input C/C++ files provided. Use --file or -f");
        }

        if (string.IsNullOrWhiteSpace(namespaceName))
        {
            errorList.Add("Error: No namespace provided. Use --namespace or -n");
        }

        if (string.IsNullOrWhiteSpace(outputLocation))
        {
            errorList.Add("Error: No output file location provided. Use --output or -o");
        }

        ParseKeyValuePairs(
            remappedNameValuePairs,
            errorList,
            out Dictionary<string, string> remappedNames
        );
        ParseKeyValuePairs(
            withAccessSpecifierNameValuePairs,
            errorList,
            out Dictionary<string, AccessSpecifier> withAccessSpecifiers
        );
        ParseKeyValuePairs(
            withAttributeNameValuePairs,
            errorList,
            out Dictionary<string, IReadOnlyList<string>> withAttributes
        );
        ParseKeyValuePairs(
            withCallConvNameValuePairs,
            errorList,
            out Dictionary<string, string> withCallConvs
        );
        ParseKeyValuePairs(
            withClassNameValuePairs,
            errorList,
            out Dictionary<string, string> withClasses
        );
        ParseKeyValuePairs(
            withGuidNameValuePairs,
            errorList,
            out Dictionary<string, Guid> withGuids
        );
        ParseKeyValuePairs(
            withLengthNameValuePairs,
            errorList,
            out Dictionary<string, string> withLengths
        );
        ParseKeyValuePairs(
            withLibraryPathNameValuePairs,
            errorList,
            out Dictionary<string, string> withLibraryPaths
        );
        ParseKeyValuePairs(
            withNamespaceNameValuePairs,
            errorList,
            out Dictionary<string, string> withNamespaces
        );
        ParseKeyValuePairs(
            withTransparentStructNameValuePairs,
            errorList,
            out Dictionary<
                string,
                (string, PInvokeGeneratorTransparentStructKind)
            > withTransparentStructs
        );
        ParseKeyValuePairs(
            withTypeNameValuePairs,
            errorList,
            out Dictionary<string, string> withTypes
        );
        ParseKeyValuePairs(
            withUsingNameValuePairs,
            errorList,
            out Dictionary<string, IReadOnlyList<string>> withUsings
        );
        ParseKeyValuePairs(
            withPackingNameValuePairs,
            errorList,
            out Dictionary<string, string> withPackings
        );

        foreach (var key in withTransparentStructs.Keys)
        {
            remappedNames.Add(key, key);
        }

        var configOptions = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? PInvokeGeneratorConfigurationOptions.None
            : PInvokeGeneratorConfigurationOptions.GenerateUnixTypes;
        var printConfigHelp = false;

        foreach (var configSwitch in configSwitches)
        {
            switch (configSwitch)
            {
                case "?":
                case "h":
                case "help":
                {
                    printConfigHelp = true;
                    break;
                }

                // Codegen Options

                case "compatible-codegen":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
                    break;
                }

                case "default-codegen":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
                    break;
                }

                case "latest-codegen":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
                    break;
                }

                case "preview-codegen":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
                    configOptions |= PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
                    break;
                }

                // File Options

                case "single-file":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateMultipleFiles;
                    break;
                }

                case "multi-file":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateMultipleFiles;
                    break;
                }

                // Type Options

                case "unix-types":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateUnixTypes;
                    break;
                }

                case "windows-types":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateUnixTypes;
                    break;
                }

                // Exclusion Options

                case "exclude-anonymous-field-helpers":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.ExcludeAnonymousFieldHelpers;
                    break;
                }

                case "exclude-com-proxies":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeComProxies;
                    break;
                }

                case "exclude-default-remappings":
                case "no-default-remappings":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.NoDefaultRemappings;
                    break;
                }

                case "exclude-empty-records":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeEmptyRecords;
                    break;
                }

                case "exclude-enum-operators":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeEnumOperators;
                    break;
                }

                case "exclude-fnptr-codegen":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeFnptrCodegen;
                    break;
                }

                case "exclude-funcs-with-body":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeFunctionsWithBody;
                    break;
                }

                case "exclude-nint-codegen":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeNIntCodegen;
                    break;
                }

                case "exclude-using-statics-for-enums":
                case "dont-use-using-statics-for-enums":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.DontUseUsingStaticsForEnums;
                    break;
                }

                // VTBL Options

                case "explicit-vtbls":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateExplicitVtbls;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateTrimmableVtbls;
                    break;
                }

                case "implicit-vtbls":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateExplicitVtbls;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateTrimmableVtbls;
                    break;
                }

                case "trimmable-vtbls":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateExplicitVtbls;
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateTrimmableVtbls;
                    break;
                }

                // Test Options

                case "generate-tests-nunit":
                {
                    if (string.IsNullOrWhiteSpace(testOutputLocation))
                    {
                        errorList.Add(
                            "Error: No test output file location provided. Use --test-output or -to"
                        );
                    }

                    if (
                        configOptions.HasFlag(
                            PInvokeGeneratorConfigurationOptions.GenerateTestsXUnit
                        )
                    )
                    {
                        errorList.Add("Cannot generate both NUnit and XUnit tests.");
                    }
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateTestsNUnit;
                    break;
                }

                case "generate-tests-xunit":
                {
                    if (string.IsNullOrWhiteSpace(testOutputLocation))
                    {
                        errorList.Add(
                            "Error: No test output file location provided. Use --test-output or -to"
                        );
                    }

                    if (
                        configOptions.HasFlag(
                            PInvokeGeneratorConfigurationOptions.GenerateTestsNUnit
                        )
                    )
                    {
                        errorList.Add("Cannot generate both NUnit and XUnit tests.");
                    }
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateTestsXUnit;
                    break;
                }

                // Generation Options

                case "generate-aggressive-inlining":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateAggressiveInlining;
                    break;
                }

                case "generate-callconv-member-function":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateCallConvMemberFunction;
                    break;
                }

                case "generate-cpp-attributes":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateCppAttributes;
                    break;
                }

                case "generate-disable-runtime-marshalling":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateDisableRuntimeMarshalling;
                    break;
                }

                case "generate-doc-includes":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateDocIncludes;
                    break;
                }

                case "generate-file-scoped-namespaces":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateFileScopedNamespaces;
                    break;
                }

                case "generate-guid-member":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateGuidMember;
                    break;
                }

                case "generate-helper-types":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateHelperTypes;
                    break;
                }

                case "generate-macro-bindings":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateMacroBindings;
                    break;
                }

                case "generate-marker-interfaces":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateMarkerInterfaces;
                    break;
                }

                case "generate-native-bitfield-attribute":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateNativeBitfieldAttribute;
                    break;
                }

                case "generate-native-inheritance-attribute":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateNativeInheritanceAttribute;
                    break;
                }

                case "generate-generic-pointer-wrapper":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateGenericPointerWrapper;
                    break;
                }

                case "generate-setslastsystemerror-attribute":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateSetsLastSystemErrorAttribute;
                    break;
                }

                case "generate-template-bindings":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateTemplateBindings;
                    break;
                }

                case "generate-unmanaged-constants":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateUnmanagedConstants;
                    break;
                }

                case "generate-vtbl-index-attribute":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateVtblIndexAttribute;
                    break;
                }

                // Logging Options

                case "log-exclusions":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.LogExclusions;
                    break;
                }

                case "log-potential-typedef-remappings":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.LogPotentialTypedefRemappings;
                    break;
                }

                case "log-visited-files":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.LogVisitedFiles;
                    break;
                }

                // Strip Options

                case "strip-enum-member-type-name":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.StripEnumMemberTypeName;
                    break;
                }

                // Legacy Options

                case "default-remappings":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.NoDefaultRemappings;
                    break;
                }

                default:
                {
                    errorList.Add($"Error: Unrecognized config switch: {configSwitch}.");
                    break;
                }
            }
        }

        if (
            !string.IsNullOrWhiteSpace(testOutputLocation)
            && !configOptions.HasFlag(PInvokeGeneratorConfigurationOptions.GenerateTestsNUnit)
            && !configOptions.HasFlag(PInvokeGeneratorConfigurationOptions.GenerateTestsXUnit)
        )
        {
            errorList.Add(
                "Error: No test format provided. Use --config generate-tests-nunit or --config generate-tests-xunit"
            );
        }

        if (printConfigHelp)
        {
            errorList.Add(
                "Response file contained config ?/h/help option, please consult ClangSharp documentation."
            );
        }

        // End verbatim ClangSharp code
        if (errorList.Count != 0)
        {
            foreach (var error in errorList)
            {
                logger.LogError($"Error in args for '{files.FirstOrDefault()}': {error}");
            }
        }

        headerFile = Path.GetFullPath(headerFile, directory ?? Environment.CurrentDirectory);
        testOutputLocation = Path.GetFullPath(
            testOutputLocation,
            directory ?? Environment.CurrentDirectory
        );
        outputLocation = Path.GetFullPath(
            outputLocation,
            directory ?? Environment.CurrentDirectory
        );
        for (var i = 0; i < traversalNames.Length; i++)
        {
            traversalNames[i] = Path.GetFullPath(
                traversalNames[i],
                directory ?? Environment.CurrentDirectory
            );
        }

        for (var i = 0; i < includeDirectories.Length; i++)
        {
            includeDirectories[i] = Path.GetFullPath(
                includeDirectories[i],
                directory ?? Environment.CurrentDirectory
            );
        }

        var clangCommandLineArgs = string.IsNullOrWhiteSpace(std)
            ? new string[]
            {
                $"--language={language}", // Treat subsequent input files as having type <language>
                "-Wno-pragma-once-outside-header" // We are processing files which may be header files
                ,
            }
            : new string[]
            {
                $"--language={language}", // Treat subsequent input files as having type <language>
                $"--std={std}", // Language standard to compile for
                "-Wno-pragma-once-outside-header" // We are processing files which may be header files
                ,
            };

        clangCommandLineArgs = clangCommandLineArgs
            .Concat(includeDirectories.Select(x => "--include-directory=" + x))
            .ToArray();
        clangCommandLineArgs = clangCommandLineArgs
            .Concat(defineMacros.Select(x => "--define-macro=" + x))
            .ToArray();
        clangCommandLineArgs = clangCommandLineArgs.Concat(additionalArgs).ToArray();

        var translationFlags = CXTranslationUnit_None;

        translationFlags |= CXTranslationUnit_IncludeAttributedTypes; // Include attributed types in CXType
        translationFlags |= CXTranslationUnit_VisitImplicitAttributes; // Implicit attributes should be visited

        var config = new PInvokeGeneratorConfiguration(
            language,
            std,
            namespaceName,
            outputLocation,
            headerFile,
            outputMode,
            configOptions
        )
        {
            DefaultClass = methodClassName,
            ExcludedNames = excludedNames,
            IncludedNames = includedNames,
            LibraryPath = libraryPath,
            MethodPrefixToStrip = methodPrefixToStrip,
            NativeTypeNamesToStrip = nativeTypeNamesToStrip,
            RemappedNames = remappedNames,
            TraversalNames = traversalNames,
            TestOutputLocation = testOutputLocation,
            WithAccessSpecifiers = withAccessSpecifiers,
            WithAttributes = withAttributes,
            WithCallConvs = withCallConvs,
            WithClasses = withClasses,
            WithGuids = withGuids,
            WithLengths = withLengths,
            WithLibraryPaths = withLibraryPaths,
            WithManualImports = withManualImports,
            WithNamespaces = withNamespaces,
            WithSetLastErrors = withSetLastErrors,
            WithSuppressGCTransitions = withSuppressGCTransitions,
            WithTransparentStructs = withTransparentStructs,
            WithTypes = withTypes,
            WithUsings = withUsings,
            WithPackings = withPackings,
        };

        if (config.GenerateMacroBindings)
        {
            translationFlags |= CXTranslationUnit_DetailedPreprocessingRecord;
        }

        return new ResponseFile(
            errorList,
            config,
            files,
            fileDirectory,
            clangCommandLineArgs,
            translationFlags,
            XxHash64.HashToUInt64(
                Encoding.UTF8.GetBytes(
                    string.Join(
                        '\n',
                        args.Select(x => x.Trim().ToLower().Replace('\\', '/'))
                            .Where(x => x.Length > 0)
                    )
                )
            ),
            filePath
        );
    }

    /// <summary>
    /// Reads the response files matching the given pattern(s) in the given directory.
    /// </summary>
    /// <param name="directory">The directory in which the patterns are applied.</param>
    /// <param name="globs">The glob patterns used to match rsp files.</param>
    /// <returns>The read response files.</returns>
    /// <exception cref="InvalidOperationException">
    /// If the directory name of the file could not be determined.
    /// </exception>
    public IEnumerable<ResponseFile> ReadResponseFiles(
        string directory,
        IReadOnlyList<string> globs
    )
    {
        logger.LogDebug(
            "Looking for response files in {0} (we are in {1})",
            directory,
            Environment.CurrentDirectory
        );
        IEnumerable<string> rsps = Glob(globs);
        int index = 0;
        int count = rsps.Count();
        progressService.SetTask("Reading ResponseFiles");
        foreach (var rsp in rsps)
        {
            index++;
            logger.LogDebug("Reading found file: {0}", rsp);
            var dir =
                Path.GetDirectoryName(rsp)
                ?? throw new InvalidOperationException("Couldn't get directory name of path");
            var read = ReadResponseFile(RspRelativeTo(dir, rsp).ToArray(), dir, rsp);

            progressService.SetProgress(index / (float)count);
            yield return read with
            {
                FileDirectory = dir,
            };
        }
    }

    private IEnumerable<string> RspRelativeTo(string directory, string fullPath)
    {
        logger.LogTrace("Reading {0}", fullPath);
        foreach (var arg in File.ReadAllLines(fullPath))
        {
            if (string.IsNullOrWhiteSpace(arg))
            {
                continue;
            }

            if (arg[0] == '@')
            {
                var innerRsp = Path.GetFullPath(arg[1..], directory);
                logger.LogTrace("{0} includes {1}", fullPath, innerRsp);
                foreach (var inner in RspRelativeTo(directory, innerRsp))
                {
                    yield return inner;
                }
            }
            else
            {
                yield return arg;
            }
        }
    }

    internal static string PathFixup(string path)
    {
        if (Path.IsPathFullyQualified(path))
        {
            path = Path.GetRelativePath(Path.GetPathRoot(path)!, path);
        }

        return path.Replace('\\', '/');
    }

    internal static IEnumerable<string> Glob(IReadOnlyCollection<string> paths, string? cd = null)
    {
        cd ??= Environment.CurrentDirectory;
        var matcher = GetGlobMatcher(paths);

        return matcher
            .GetResultsInFullPath(cd)
            .Concat(
                paths
                    .Select(x => x.StartsWith('!') ? x[1..] : x)
                    .Where(Path.IsPathFullyQualified)
                    .Select(Path.GetPathRoot)
                    .Where(x => x is not null)
                    .Distinct()
                    .SelectMany(x => matcher.GetResultsInFullPath(x!))
            )
            .Concat(paths.Where(File.Exists))
            .Select(x => Path.GetFullPath(x).Replace('\\', '/'))
            .Distinct()
            .ToArray();
    }

    internal static Matcher GetGlobMatcher(IReadOnlyCollection<string> paths)
    {
        var matcher = new Matcher();

        matcher.AddIncludePatterns(paths.Where(x => !x.StartsWith("!")).Select(PathFixup));
        matcher.AddExcludePatterns(
            paths.Where(x => x.StartsWith("!")).Select(x => x[1..]).Select(PathFixup)
        );

        return matcher;
    }
}
