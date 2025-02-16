using System;
using System.Collections.Concurrent;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClangSharp;
using Microsoft.Build.Locator;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Silk.NET.SilkTouch;
using Silk.NET.SilkTouch.Caching;
using Silk.NET.SilkTouch.Logging;
using Silk.NET.SilkTouch.Utility;

var logging = new Option<LogLevel>(new[] { "--log-level", "-l" }, () => LogLevel.Information);
var skip = new Option<string[]>(
    new[] { "--skip", "-s" },
    Array.Empty<string>,
    "A list of job names to skip. Takes precendence over --only."
)
{
    Arity = ArgumentArity.ZeroOrMore
};
var only = new Option<string[]>(
    new[] { "--only", "-o" },
    Array.Empty<string>,
    "A list of job names to run."
) {
    Arity = ArgumentArity.ZeroOrMore
};
var configs = new Argument<string[]>("configs", "Path(s) to JSON SilkTouch configuration(s)")
{
    Arity = ArgumentArity.OneOrMore
};
var configOverrides = new Argument<string[]>(
    "overrides",
    Array.Empty<string>,
    "Arguments recognisable by Microsoft.Extensions.Configuration.CommandLine to override JSON configuration items."
)
{
    Arity = ArgumentArity.ZeroOrMore
};
var jobs = new Option<int>(
    new[] { "--max-jobs", "-j" },
    () => Environment.ProcessorCount,
    "Maximum number of parallel ClangSharp executions."
);
var rootCommand = new RootCommand { logging, skip, only, configs, configOverrides, jobs };
rootCommand.SetHandler(async ctx => {
    // Create the ConfigurationBuilder with support for env var & command line overrides
    var cb = new ConfigurationBuilder()
        .AddEnvironmentVariables(source => source.Prefix = "SILKDOTNET_")
        .AddCommandLine(ctx.ParseResult.GetValueForArgument(configOverrides));

    // Add the JSON files to the ConfigurationBuilder
    var jsons = ctx.ParseResult.GetValueForArgument(configs);
    cb = jsons.Aggregate(cb, (current, file) => current.AddJsonFile(Path.GetFullPath(file)));
    var config = cb.Build();
    if (jsons.Length == 1)
    {
        FileSystemCacheProvider.CommonDir = Path.GetFullPath(
            (Path.GetDirectoryName(jsons[0]) is (null or not "") and var path ? path : ".")
                ?? Environment.CurrentDirectory
        );
    }

    // Register MSBuild
    MSBuildLocator.RegisterDefaults();

    JobContext jobContext = new();

    var sp = new ServiceCollection()
        .AddSingleton(jobContext)
        .AddSingleton<IProgressService, ProgressService>()
        .AddLogging(builder => {
            builder.ClearProviders();
            builder.AddSimpleConsole(opts => {
                opts.SingleLine = true;
                opts.ColorBehavior = Console.IsOutputRedirected
                    ? LoggerColorBehavior.Disabled
                    : LoggerColorBehavior.Default;
                opts.IncludeScopes = true;
            });

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
            });

            builder.SetMinimumLevel(ctx.ParseResult.GetValueForOption(logging));

            builder.Services.AddSingleton(typeof(ILogger<>), typeof(SilkLogger<>));
        })
        .AddSingleton<ConsoleRenderer>()
        .AddOptions()
        .AddSilkTouch(config)
        .BuildServiceProvider();

    // Start the console renderer
    var consoleRenderer = sp.GetService<ConsoleRenderer>();

    var logger = sp.GetRequiredService<ILogger<Program>>();
    var skipped = SeparateCSV(ctx.ParseResult.GetValueForOption(skip));
    var jobsToRun = SeparateCSV(ctx.ParseResult.GetValueForOption(only));

    var generator = sp.GetRequiredService<SilkTouchGenerator>();
    var progressService = sp.GetRequiredService<IProgressService>();

    await Parallel.ForEachAsync(
        config
            .GetSection("Jobs")
            .GetChildren()
            .Where(x =>
                (skipped?.All(y => !x.Key.Equals(y, StringComparison.OrdinalIgnoreCase)) ?? true) &&
                (jobsToRun is null || jobsToRun.Count == 0 || jobsToRun.Any(y => x.Key.Equals(y, StringComparison.OrdinalIgnoreCase)))
            ),
        async (job, ct) => {
            jobContext.JobKey = job.Key;
            await generator.RunAsync(
                job.Key,
                job,
                // TODO parallelism configuration
                // ctx.ParseResult.GetValueForOption(jobs),
                ct
            );
            progressService.RemoveProgress();
        }
    );

    // Stop the renderer gracefully
    consoleRenderer?.Stop();

    // workaround for dangling logging/socket engine threads
    Environment.Exit(0);
});

await rootCommand.InvokeAsync(args);

static List<string> SeparateCSV(Span<string> strs)
{
    if (strs.Length == 0)
        return [];

    List<string> result = [];
    foreach (string str in strs)
    {
        if (str.Contains(','))
        {
            result.AddRange(str.Split(','));
        }
        else
        {
            result.Add(str);
        }
    }
    return result;
}
