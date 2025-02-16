using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClangSharp;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Utility;

namespace Silk.NET.SilkTouch.Sources;

/// <summary>
/// Resolves a path in a SilkTouch configuration to its canonical path on the host file system. This allows for multiple
/// <see cref="IInputSource"/>s with varying behaviour e.g. a NuGet resolver that resolves paths starting with nuget://
/// </summary>
public interface IInputResolver
{
    /// <summary>
    /// Resolves the input path to its canonical host file system path, returning null if resolution failed.
    /// </summary>
    /// <param name="path">The path input.</param>
    /// <returns>The resolved path asynchronously.</returns>
    Task<string?> TryResolvePath(string path);

    /// <summary>
    /// Resolves the input path to its canonical host file system path, returning the original path if resolution failed.
    /// </summary>
    /// <param name="path">The path input.</param>
    /// <returns>The resolved path asynchronously.</returns>
    async Task<string> ResolvePath(string path) =>
        (await TryResolvePath(path))?.Replace('\\', '/') ?? path;

    /// <summary>
    /// Resolves all of the paths referenced in the given response file in place.
    /// </summary>
    /// <param name="rsps">The response files.</param>
    /// <param name="progressService">the progress service to use</param>
    /// <returns>An asynchronous task.</returns>
    async Task ResolveInPlace(IList<ResponseFile> rsps, IProgressService? progressService = null)
    {
        progressService?.SetTask("Resolving File Paths");
        // Resolve any foreign paths
        for (var i = 0; i < rsps.Count; i++)
        {
            var rsp = rsps[i];
            var files = rsp.Files.ToArray();
            for (var j = 0; j < files.Length; j++)
            {
                files[j] = await ResolvePath(files[j]);
            }

            for (var j = 0; j < rsp.ClangCommandLineArgs.Length; j++)
            {
                var arg = rsp.ClangCommandLineArgs[j];
                if (arg is "--include-directory" or "-I")
                {
                    for (var k = j; k < rsp.ClangCommandLineArgs.Length; k++)
                    {
                        if (rsp.ClangCommandLineArgs[k][0] == '-')
                        {
                            break;
                        }
                        rsp.ClangCommandLineArgs[k] = await ResolvePath(
                            rsp.ClangCommandLineArgs[k]
                        );
                        j++;
                    }
                }
                else if (arg.StartsWith("--include-directory"))
                {
                    rsp.ClangCommandLineArgs[j] =
                        "--include-directory="
                        + await ResolvePath(arg["--include-directory".Length..].TrimStart('='));
                }
                else if (arg.StartsWith("-I"))
                {
                    rsp.ClangCommandLineArgs[j] =
                        "-I" + await ResolvePath(arg["-I".Length..].TrimStart('='));
                }
            }

            var traversals = rsp.GeneratorConfiguration.TraversalNames.ToArray();
            for (var j = 0; j < traversals.Length; j++)
            {
                traversals[j] = await ResolvePath(traversals[j]);
            }

            var tmp = Path.GetTempFileName();
            await File.WriteAllTextAsync(tmp, rsp.GeneratorConfiguration.HeaderText);
            rsps[i] = rsp with
            {
                Files = files,
                FileDirectory =
                    (await TryResolvePath(rsp.FileDirectory))?.Replace('\\', '/')
                    ?? rsp.FileDirectory,
                ClangCommandLineArgs = rsp.ClangCommandLineArgs,
                GeneratorConfiguration = new PInvokeGeneratorConfiguration(
                    rsp.GeneratorConfiguration.Language,
                    rsp.GeneratorConfiguration.LanguageStandard,
                    rsp.GeneratorConfiguration.DefaultNamespace,
                    await ResolvePath(rsp.GeneratorConfiguration.OutputLocation),
                    tmp,
                    rsp.GeneratorConfiguration.OutputMode,
                    rsp.GeneratorConfiguration.ReconstructOptions()
                )
                {
                    WithClasses = rsp.GeneratorConfiguration.WithClasses,
                    WithGuids = rsp.GeneratorConfiguration.WithGuids,
                    DefaultClass = rsp.GeneratorConfiguration.DefaultClass,
                    ExcludedNames = rsp.GeneratorConfiguration.ExcludedNames,
                    ExcludeFnptrCodegen = rsp.GeneratorConfiguration.ExcludeFnptrCodegen,
                    IncludedNames = rsp.GeneratorConfiguration.IncludedNames,
                    LibraryPath = rsp.GeneratorConfiguration.LibraryPath,
                    MethodPrefixToStrip = rsp.GeneratorConfiguration.MethodPrefixToStrip,
                    NativeTypeNamesToStrip = rsp.GeneratorConfiguration.NativeTypeNamesToStrip,
                    RemappedNames = rsp.GeneratorConfiguration.RemappedNames,
                    TraversalNames = traversals,
                    WithAttributes = rsp.GeneratorConfiguration.WithAttributes,
                    WithCallConvs = rsp.GeneratorConfiguration.WithCallConvs,
                    WithNamespaces = rsp.GeneratorConfiguration.WithNamespaces,
                    WithTypes = rsp.GeneratorConfiguration.WithTypes,
                    WithUsings = rsp.GeneratorConfiguration.WithUsings,
                    WithPackings = rsp.GeneratorConfiguration.WithPackings,
                    WithAccessSpecifiers = rsp.GeneratorConfiguration.WithAccessSpecifiers,
                    WithLibraryPaths = rsp.GeneratorConfiguration.WithLibraryPaths,
                    WithManualImports = rsp.GeneratorConfiguration.WithManualImports,
                    WithTransparentStructs = rsp.GeneratorConfiguration.WithTransparentStructs,
                    WithSetLastErrors = rsp.GeneratorConfiguration.WithSetLastErrors,
                    WithSuppressGCTransitions =
                        rsp.GeneratorConfiguration.WithSuppressGCTransitions,
                    TestOutputLocation = await ResolvePath(
                        rsp.GeneratorConfiguration.TestOutputLocation
                    )
                }
            };
            progressService?.SetProgress(i / (float)rsps.Count);
        }
    }

    /// <summary>
    /// Resolves the paths in the given array in-place.
    /// </summary>
    /// <param name="files">The paths to resolve.</param>
    async Task ResolveInPlace(IList<string> files)
    {
        for (var i = 0; i < files.Count; i++)
        {
            files[i] = await ResolvePath(files[i]);
        }
    }

    /// <summary>
    /// Resolves all paths referenced in the given configuration.
    /// </summary>
    /// <param name="config">The configuration.</param>
    /// <returns>The configuration with all paths resolved.</returns>
    async Task<ClangScraper.Configuration> Resolve(ClangScraper.Configuration config)
    {
        await ResolveInPlace(config.ClangSharpResponseFiles);
        foreach (
            var (k, v) in config.ManualOverrides ?? Enumerable.Empty<KeyValuePair<string, string>>()
        )
        {
            config.ManualOverrides![k] = await ResolvePath(v);
        }

        return config with
        {
            InputSourceRoot = config.InputSourceRoot is null
                ? null
                : await ResolvePath(config.InputSourceRoot),
            InputTestRoot = config.InputTestRoot is null
                ? null
                : await ResolvePath(config.InputTestRoot)
        };
    }

    /// <summary>
    /// Resolves all paths referenced in the given job configuration.
    /// </summary>
    /// <param name="config">The job config.</param>
    /// <returns>The job config with all paths resolved.</returns>
    async Task<SilkTouchConfiguration> Resolve(SilkTouchConfiguration config) =>
        config with
        {
            SourceProject = config.SourceProject is null
                ? null
                : await ResolvePath(config.SourceProject),
            TestProject = config.TestProject is null ? null : await ResolvePath(config.TestProject)
        };
}
