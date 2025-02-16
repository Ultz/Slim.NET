using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Caching;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Mods.Bakery;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Naming;
using Silk.NET.SilkTouch.Sources;

namespace Silk.NET.SilkTouch;

/// <summary>
/// Provides the <see cref="AddSilkTouch"/> method.
/// </summary>
public static class ServiceCollectionExtensions
{
    private static readonly MethodInfo s_configure;

    static ServiceCollectionExtensions()
    {
        var cnf = typeof(OptionsConfigurationServiceCollectionExtensions).GetMethod(
            nameof(OptionsConfigurationServiceCollectionExtensions.Configure),
            1,
            new[] { typeof(IServiceCollection), typeof(string), typeof(IConfiguration) }
        );

        s_configure =
            cnf
            ?? throw new TypeAccessException(
                $"Could not access the {nameof(OptionsConfigurationServiceCollectionExtensions.Configure)} method on "
                    + nameof(OptionsConfigurationServiceCollectionExtensions)
            );
    }

    /// <summary>
    /// Adds a <see cref="SilkTouchGenerator"/> singleton (and its dependencies) to the given
    /// <see cref="IServiceCollection"/>, using the root SilkTouch configuration provided.
    /// </summary>
    /// <remarks>
    /// It is expected that <see cref="OptionsServiceCollectionExtensions.AddOptions"/> and
    /// <see cref="LoggingServiceCollectionExtensions.AddLogging(IServiceCollection)"/> is used before this call.
    /// </remarks>
    /// <param name="services">
    /// The service collection to make the SilkTouch types available on. The service collection shall have the following
    /// types added to it:
    /// <list type="bullet">
    /// <item><description><see cref="ClangScraper"/></description></item>
    /// <item><description><see cref="ResponseFileHandler"/></description></item>
    /// <item><description><see cref="SilkTouchGenerator"/></description></item>
    /// <item><description><see cref="NameTrimmer"/></description></item>
    /// <item><description>One or more <see cref="INameTrimmer"/>s</description></item>
    /// <item><description>An appropriate implementation of <see cref="IStdIncludeResolver"/></description></item>
    /// <item><description>Mod implementations referenced in the configurations</description></item>
    /// <item>
    /// <description>
    /// <see cref="Microsoft.Extensions.Configuration"/> types for <see cref="SilkTouchConfiguration"/> and the
    /// <see cref="ModConfigurationAttribute{TOptions}"/>s for any of the loaded mods.
    /// </description>
    /// </item>
    /// </list>
    /// </param>
    /// <param name="config">
    /// A configuration structure that:
    /// <list type="bullet">
    /// <item>
    /// <description>
    /// Contains a root <c>"Jobs"</c> section, representing a dictionary of string keys to
    /// <see cref="SilkTouchConfiguration"/> values.
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// In each <see cref="SilkTouchConfiguration"/> within <c>"Jobs"</c>, contains a subsection for each of the
    /// <see cref="SilkTouchConfiguration.Mods"/> referenced that has a <see cref="ModConfigurationAttribute{TOptions}"/>.
    /// </description>
    /// </item>
    /// </list>
    /// </param>
    /// <returns>The modified service collection (for chaining purposes).</returns>
    public static IServiceCollection AddSilkTouch(
        this IServiceCollection services,
        IConfiguration config
    )
    {
        // References for our use of Microsoft.Extensions.Configuration/DependencyInjection:
        // - https://stevetalkscode.co.uk/using-iconfigureoptions
        // - https://stevetalkscode.co.uk/configuration-bridging-part-2
        // - https://andrewlock.net/configuring-named-options-using-iconfigurenamedoptions-and-configureall/
        // - https://andrewlock.net/how-to-register-a-service-with-multiple-interfaces-for-in-asp-net-core-di/
        // - https://discordapp.com/channels/143867839282020352/663803973119115264/1129546023388332075 (C# Discord)

        // services.AddSingleton<ClangScraper>(); <-- this is a mod now
        services.AddSingleton<ResponseFileHandler>();
        services.AddSingleton<FunctionTransformer>();
        services.AddSingleton<MSBuildModContextProvider>();
        services.TryAddSingleton<IModContextProvider>(s =>
            s.GetRequiredService<MSBuildModContextProvider>()
        );
        services.AddSingleton<NameTrimmer>();
        services.AddSingleton<DefaultBakeStrategy>();
        services.AddSingleton<INameTrimmer>(s => s.GetRequiredService<NameTrimmer>());
        services.AddSingleton<IBakeStrategy>(s => s.GetRequiredService<DefaultBakeStrategy>());
        services.AddSingleton(typeof(IJobDependency<>), typeof(JobDependencies.Global<>));
        services.TryAddSingleton<ICacheProvider, FileSystemCacheProvider>();
        services.AddSingleton<IInputSource, GitInputSource>();
        services.AddSingleton<IInputSource, NuGetInputSource>();
        services.AddSingleton<IFunctionTransformer, PtrRefTransformer>();
        services.AddSingleton<IFunctionTransformer, BoolTransformer>();
        services.AddSingleton<IFunctionTransformer, ArrayParameterTransformer>();
        services.TryAddSingleton<IInputResolver, UriBasedInputResolver>();
        if (OperatingSystem.IsWindows())
        {
            services.AddSingleton<IStdIncludeResolver, WindowsStdIncludeResolver>();
        }
        else if (OperatingSystem.IsMacOS())
        {
            services.AddSingleton<IStdIncludeResolver, MacOSStdIncludeResolver>();
        }
        else
        {
            services.AddSingleton<IStdIncludeResolver, UnixStdIncludeResolver>();
        }

        // First pass to build the config and load the mods
        var loadedMods = new Dictionary<string, Type>();
        foreach (var job in config.GetSection("Jobs").GetChildren())
        {
            var mods = job.GetSection("Mods").Get<string[]>() ?? Array.Empty<string>();
            services.Configure<SilkTouchConfiguration>(job.Key, job);
            foreach (var m in mods)
            {
                var loadedMod = ModLoader.LoadModByName(m);
                if (loadedMod is null || services.Any(x => x.ImplementationType == loadedMod))
                {
                    continue;
                }

                loadedMods[m] = loadedMod;
                // TODO else log?

                if (ModConfigurationAttribute.GetConfigurationType(loadedMod) is { } cfgType)
                {
                    s_configure
                        .MakeGenericMethod(cfgType)
                        .Invoke(null, new object?[] { services, job.Key, job.GetSection(m) });
                }
            }
        }

        // Second pass to register the mods and generator with DI
        // "order is important" according to this blog post:
        // https://andrewlock.net/configuring-named-options-using-iconfigurenamedoptions-and-configureall/
        services.AddSingleton<SilkTouchGenerator>();
        foreach (var job in config.GetSection("Jobs").GetChildren())
        {
            var mods = job.GetSection("Mods").Get<string[]>() ?? Array.Empty<string>();
            foreach (var m in mods)
            {
                services.AddSingleton(loadedMods[m]);
                services.AddSingleton<IMod>(s => (IMod)s.GetRequiredService(loadedMods[m]));
            }
        }

        // Some dependencies being made available are conditional to whether they've been specified in the config file.
        // We use JobDependencies as indirection so that we can retrieve the service provider and loadedMods from the
        // Mod subclass. This then allows DI to make a generic instantiation of the Mod subclass without requiring a
        // factory.
        services.AddSingleton<JobDependencies>(s => new JobDependencies(loadedMods, s));
        services.AddSingleton(typeof(IJobDependency<>), typeof(JobDependencies.Mod<>));

        // Third pass to add the IConfigureOptions/IConfigureNamedOptions
        foreach (var job in config.GetSection("Jobs").GetChildren())
        {
            var mods = job.GetSection("Mods").Get<string[]>() ?? Array.Empty<string>();
            foreach (var m in mods)
            {
                if (
                    ModConfigurationAttribute.GetConfigurationType(loadedMods[m]) is not { } cfgType
                )
                {
                    continue;
                }

                var cfgOpts = typeof(IConfigureOptions<>).MakeGenericType(cfgType);
                if (loadedMods[m].IsAssignableTo(cfgOpts))
                {
                    services.AddSingleton(cfgOpts, s => (IMod)s.GetRequiredService(loadedMods[m]));
                }

                cfgOpts = typeof(IConfigureNamedOptions<>).MakeGenericType(cfgType);
                if (loadedMods[m].IsAssignableTo(cfgOpts))
                {
                    services.AddSingleton(cfgOpts, s => (IMod)s.GetRequiredService(loadedMods[m]));
                }
            }
        }

        return services;
    }
}
