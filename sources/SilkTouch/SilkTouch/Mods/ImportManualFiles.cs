// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Sources;
using static Silk.NET.SilkTouch.Mods.TransformHandles;

namespace Silk.NET.SilkTouch.Mods
{
    /// <summary>
    /// A mod to import any manual files into the generator process
    /// </summary>
    /// <param name="logger">The logger to use.</param>
    /// <param name="config">The configuration to use.</param>
    [ModConfiguration<Configuration>]
    public class ImportManualFiles(
        ILogger<ImportManualFiles> logger,
        IOptionsSnapshot<ImportManualFiles.Configuration> config
    ) : Mod
    {
        /// <summary>
        /// The configuration for the <see cref="TransformCOM"/> mod.
        /// </summary>
        public class Configuration
        {
            /// <summary>
            /// File location to import to and the file to be imported (or globs representing them)
            /// </summary>
            public Dictionary<string, string>? ManualImports { get; init; }
        }

        /// <inheritdoc />
        public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
        {
            await base.ExecuteAsync(ctx, ct);

            // Read the configuration.
            var cfg = config.Get(ctx.JobKey);

            if (cfg.ManualImports is null)
            {
                return;
            }

            Dictionary<Regex, string> regexConverters = [];
            List<string> pathGlobs = [];

            foreach (var import in cfg.ManualImports)
            {
                string regexPatternIn = GlobToRegexInput(import.Value);
                string regexPatternOut = GlobToRegexOutput(import.Key);

                pathGlobs.Add(import.Value);

                regexConverters.Add(new(regexPatternIn), regexPatternOut);
            }

            var files = ResponseFileHandler.Glob(pathGlobs);

            var aggregatedSources = new ConcurrentDictionary<string, SyntaxTree>();
            var aggregatedTests = new ConcurrentDictionary<string, SyntaxTree>();

            foreach (var file in files)
            {
                foreach (var regex in regexConverters)
                {
                    if (regex.Key.Match(file).Success)
                    {
                        string outputLocation = regex.Key.Replace(file, regex.Value);
                        bool isTest = outputLocation.StartsWith("tests/");
                        outputLocation = outputLocation.Remove(
                            0,
                            outputLocation.IndexOf(isTest ? "tests/" : "sources/")
                        );
                        string relativeKey = outputLocation.Remove(0, isTest ? 6 : 8);
                        if (
                            !(isTest ? aggregatedTests : aggregatedSources).TryAdd(
                                relativeKey,
                                CSharpSyntaxTree.ParseText(
                                    SourceText.From(File.OpenRead(file)),
                                    path: relativeKey
                                )
                            )
                        )
                        {
                            logger.LogError(
                                "Failed to add {0} - are the response file outputs conflicting?",
                                relativeKey
                            );
                        }
                        else
                        {
                            logger.LogTrace("ClangSharp generated {0}", relativeKey);
                        }
                    }
                }
            }

            var src = ctx.SourceProject;
            foreach (var (fname, tree) in aggregatedSources)
            {
                src = src
                    ?.AddDocument(
                        Path.GetFileName(fname),
                        await tree.GetRootAsync(ct),
                        filePath: src.FullPath(fname)
                    )
                    .Project;
                logger.LogDebug($"Add Src Document {fname}");
            }

            ctx.SourceProject = src;
            var test = ctx.TestProject;
            foreach (var (fname, tree) in aggregatedTests)
            {
                test = test
                    ?.AddDocument(
                        Path.GetFileName(fname),
                        await tree.GetRootAsync(ct),
                        filePath: test.FullPath(fname)
                    )
                    .Project;
            }

            ctx.TestProject = test;
        }

        private string GlobToRegexInput(string glob)
        {
            return glob.Replace("*", "**").Replace("****", "(.*)").Replace("**", @"([^\/]*)");
        }

        private string GlobToRegexOutput(string glob)
        {
            int index = 1;
            return glob.Split("**")
                .SelectMany(split => split.Split('*'))
                .Aggregate((s1, s2) => $"{s1}${index++}{s2}");
        }
    }
}
