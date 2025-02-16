using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Sources;
using Diagnostic = ClangSharp.Diagnostic;

namespace Silk.NET.SilkTouch;

/// <summary>
/// The main entry-point class for SilkTouch.
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="mods">The mods to use.</param>
/// <param name="modContextProvider">The provider of <see cref="IModContext"/>s.</param>
/// <param name="inputResolver">The user path input resolver.</param>
public class SilkTouchGenerator(
    ILogger<SilkTouchGenerator> logger,
    IEnumerable<IMod> mods,
    IModContextProvider modContextProvider,
    IInputResolver inputResolver
)
{
    private AsyncLocal<SilkTouchConfiguration> _jobConfig = new();

    /// <summary>
    /// Gets the loaded mods for this generator instance.
    /// </summary>
    public IReadOnlyList<IMod> Mods { get; } = mods.ToArray();

    /// <summary>
    /// The current job.
    /// </summary>
    public SilkTouchConfiguration? Current => _jobConfig.Value;

    /// <summary>
    /// Generates binding syntax trees per the given configuration.
    /// </summary>
    /// <param name="key">The name of the current job (used as a configuration key).</param>
    /// <param name="jobConfig">The configuration, expected to be stored as <c>Jobs:{key}</c>.</param>
    /// <param name="ct">Cancellation token (if any)</param>
    /// <returns>The generated bindings' syntax trees.</returns>
    public async Task RunAsync(
        string key,
        IConfigurationSection jobConfig,
        CancellationToken ct = default
    )
    {
        using var scope = logger.BeginScope("{} >", key);

        var sw = Stopwatch.StartNew();
        var job =
            jobConfig.Get<SilkTouchConfiguration>()
            ?? throw new InvalidOperationException("Configuration was null");

        // Resolve any relative paths in the job configuration.
        job = await inputResolver.Resolve(job);
        _jobConfig.Value = job;

        // Prepare the mods
        var jobMods =
            job.Mods?.Select(x => Mods.First(y => y.GetType().Name == x)).ToArray()
            ?? Array.Empty<IMod>();

        var ctx = await modContextProvider.GetContextAsync(key, jobConfig, ct);

        // Just in case a mod gets naughty and tries to modify at the initialization stage.
        var srcProj = ctx.SourceProject;
        var testProj = ctx.TestProject;

        var modPerf = new Dictionary<IMod, Stopwatch>();

        // Initialize the mods
        foreach (var jobMod in jobMods)
        {
            logger.LogDebug("Using mod {0} for {1}", jobMod.GetType().Name, key);
            modPerf.Add(jobMod, Stopwatch.StartNew());
            await jobMod.InitializeAsync(ctx, ct);
            modPerf[jobMod].Stop();
            if (ctx.SourceProject != srcProj || ctx.TestProject != testProj)
            {
                throw new InvalidOperationException(
                    $"{jobMod.GetType().Name} illegally generated code at the initialization stage."
                );
            }
        }

        foreach (var jobMod in jobMods)
        {
            logger.LogInformation("Executing {} for {}...", jobMod.GetType().Name, key);
            modPerf[jobMod].Start();
            await jobMod.ExecuteAsync(ctx, ct);
            modPerf[jobMod].Stop();
        }

        // Manually dispose so that we don't do this when generation fails (await using is too clever).
        await ctx.DisposeAsync();

        logger.LogInformation("Job Mod Performance Data for {} \n{}", key,
            string.Join("\n", modPerf.Select(kvp => $"{kvp.Key.GetType().Name} : {kvp.Value.Elapsed.TotalSeconds} seconds")));

        // Output the generated bindings
        logger.LogInformation(
            "Bindings generation for {} completed in {} seconds.",
            key,
            sw.Elapsed.TotalSeconds
        );
    }

    internal static string GetLongestCommonPrefix(string[] s)
    {
        var k = s[0].Length;
        for (var i = 1; i < s.Length; i++)
        {
            k = Math.Min(k, s[i].Length);
            for (var j = 0; j < k; j++)
            {
                if (s[i][j] == s[0][j])
                {
                    continue;
                }

                k = j;
                break;
            }
        }

        return s[0][..k];
    }

    internal static string GetLongestCommonPath(IEnumerable<string> s)
    {
        var ret = GetLongestCommonPrefix(
            s.Select(x => Path.GetFullPath(x.Replace('\\', '/').TrimEnd('/'))).ToArray()
        );
        Debug.Assert(Directory.Exists(ret));
        return ret;
    }
}
